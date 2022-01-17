using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormControl : Form
	{				
		#region CONSTRUCTOR
		public FormControl(FormPrincipal refPrinc, int idUsuario)
		{
			InitializeComponent();
			formPrincipal = refPrinc;
			id_usuario = idUsuario;			
		}
		#endregion		
		
		#region VARIABLES
		public Int32 id_usuario;
		public int rowIndex = 0;
		public int ColumnIndex = 0;
		#endregion
		
		#region INSTANCIAS
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();		
		public FormPrincipal formPrincipal;			
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
 		#region INICIO - FIN
		void FormControlLoad(object sender, EventArgs e)
		{
			Inicio();
		}
		
		void FormControlFormClosing(object sender, FormClosingEventArgs e)
		{
			formPrincipal.controlFacturacion = false;
		}		
		#endregion		
		
		#region METODOS
		public void filtros(){
			string consulta = @"select CF.*, U.usuario from CONTROL_FACTURACION CF JOIN usuario U ON CF.ID_USUARIO_CREACION = U.id_usuario where id > 0  ";
			if(cbPagadas.Checked == true)
				consulta += " and ESTADO = 'PAGADA' ";
			if(cbEliminadas.Checked == true)
				consulta += " and CF.ESTATUS = 'INACTIVO'";
			
			if(cbEliminadasOrdenFactura.Checked == false && cbEliminadas.Checked == false && cbPagadas.Checked == false)
				consulta += " and  ESTADO in('GENERADA', 'FACTURADA') AND CF.ESTATUS = 'ACTIVO' ";
			else
				consulta += " and FECHA_CREACION BETWEEN '"+dtpInicioOrdenFactura.Value.ToShortDateString()+"' AND '"+dtpFinOrdenFactura.Value.ToShortDateString()+"'";
			
			if(txtBusquedaOrdenFactura.Text.Length > 0)
				consulta += " and EMPRESA = '"+txtBusquedaOrdenFactura.Text+"'";
			if(txtFactura.Text.Length > 0)
				consulta += " and factura like '%"+txtFactura.Text+"%'";
			AdaptadorOrdenFactura(consulta);
			dgOrdenFactura.ClearSelection();
			
			rowIndex = 0;
			ColumnIndex = 0;
		}
		
		private void Inicio(){
			filtros();			
			dtpInicioOrdenFactura.Value = DateTime.Now;
			
			txtBusquedaOrdenFactura.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT Empresa FROM Cliente WHERE Empresa != 'Especiales'", "Empresa");
			txtBusquedaOrdenFactura.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtBusquedaOrdenFactura.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtFactura.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT FACTURA FROM CONTROL_FACTURACION WHERE ESTATUS = 'ACTIVO'", "FACTURA");
			txtFactura.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtFactura.AutoCompleteSource = AutoCompleteSource.CustomSource;			
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		
		private void Facturar(){
			if(dgOrdenFactura[1, rowIndex].Value.ToString() == "GENERADA")
				new FormFacturar(this, id_usuario, Convert.ToInt64(dgOrdenFactura[0, rowIndex].Value), rowIndex).ShowDialog();
			else
				MessageBox.Show("Selecciona una factura valida a facturar", "Error al seleccionar Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		
		private void Cancelar(){
			if(dgOrdenFactura[1, rowIndex].Value.ToString() == "GENERADA" || dgOrdenFactura[1, rowIndex].Value.ToString() == "FACTURADA")
				new FormCancelaFactura(this, id_usuario, Convert.ToInt64(dgOrdenFactura[0, rowIndex].Value), rowIndex).ShowDialog();
			else
				MessageBox.Show("Selecciona una factura valida a eliminar", "Error al seleccionar Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		
		private void Pagar(){
			if(dgOrdenFactura[1, rowIndex].Value.ToString() == "FACTURADA")
				new FormPagada(this, id_usuario, Convert.ToInt64(dgOrdenFactura[0, rowIndex].Value), rowIndex).ShowDialog();
			else
				MessageBox.Show("Selecciona una factura valida a pagar", "Error al seleccionar Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		#endregion
		
		#region ADAPTADOR
		private void AdaptadorOrdenFactura(string consulta){
			int contador = 0;			
			try{
				ColoresAlternadosRows(dgOrdenFactura);
				dgOrdenFactura.Rows.Clear();	
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgOrdenFactura.Rows.Add(conn.leer["ID"].ToString(),
					                        ((conn.leer["ESTATUS"].ToString() == "INACTIVO")? "ELIMINADA": conn.leer["ESTADO"].ToString()),
 	                      					conn.leer["EMPRESA"].ToString(),
 	                      					conn.leer["FECHA_CREACION"].ToString().Substring(0,10),
 	                      					conn.leer["FECHA_CREACION"].ToString().Substring(0,10),
				                      		conn.leer["FACTURA"].ToString(),
					                        conn.leer["PERIODO_I"].ToString().Substring(0,10),
					                        conn.leer["PERIODO_F"].ToString().Substring(0,10),     
											conn.leer["IMPORTE"].ToString(),
											conn.leer["IVA"].ToString(),
											conn.leer["TOTAL"].ToString(),
											((conn.leer["DIA_COBRO"].ToString().Length > 9)? conn.leer["DIA_COBRO"].ToString().Substring(0,10): conn.leer["DIA_COBRO"].ToString() ),
											((conn.leer["VENCIMIENTO"].ToString().Length > 9)? conn.leer["VENCIMIENTO"].ToString().Substring(0,10): conn.leer["VENCIMIENTO"].ToString() ),
											conn.leer["OBSERVACIONES"].ToString(),
										    conn.leer["usuario"].ToString());
						dgOrdenFactura[5,contador].Style.BackColor = Color.LightGray;
					if(conn.leer["ESTATUS"].ToString().Equals("INACTIVO"))
						dgOrdenFactura[1,contador].Style.BackColor = Color.Red;					
					if(conn.leer["ESTADO"].ToString().Equals("PAGADA")){
						for(int y=0; y<dgOrdenFactura.Columns.Count; y++){
							dgOrdenFactura[y,contador].Style.BackColor = Color.LightGreen;
						}
					}					
					contador++;	
				}					
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las ordenes de facturas  (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);	
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}		
		}	
		#endregion
		
		#region EVENTOS		
		void DtpInicioOrdenFacturaValueChanged(object sender, EventArgs e)
		{
			dtpFinOrdenFactura.Value = dtpInicioOrdenFactura.Value;
		}
		
		void DtpFinOrdenFacturaValueChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void TxtBusquedaOrdenFacturaTextChanged(object sender, EventArgs e)
		{			
			filtros();
		}
		
		void CbEliminadasCheckedChanged(object sender, EventArgs e)
		{
			if(cbEliminadas.Checked == true){
				cbPagadas.Checked = false;
				dtpInicioOrdenFactura.Enabled = true;
				dtpFinOrdenFactura.Enabled = true;
				filtros();
			}else{
				dtpInicioOrdenFactura.Enabled = false;
				dtpFinOrdenFactura.Enabled = false;
				dtpInicioOrdenFactura.Value = DateTime.Now;
				dtpFinOrdenFactura.Value = DateTime.Now;
				txtBusquedaOrdenFactura.Text = "";				
			}			
		}
		
		void CbPagadasCheckedChanged(object sender, EventArgs e)
		{			
			if(cbPagadas.Checked == true){
				cbEliminadas.Checked = false;
				dtpInicioOrdenFactura.Enabled = true;
				dtpFinOrdenFactura.Enabled = true;
				filtros();
			}else{
				dtpInicioOrdenFactura.Enabled = false;
				dtpFinOrdenFactura.Enabled = false;
				dtpInicioOrdenFactura.Value = DateTime.Now;
				dtpFinOrdenFactura.Value = DateTime.Now;
				txtBusquedaOrdenFactura.Text = "";				
			}		
		}
		
		void CbEliminadasOrdenFacturaCheckedChanged(object sender, EventArgs e)
		{
			if(cbEliminadasOrdenFactura.Checked == true){
				cbEliminadas.Checked = false;
				cbPagadas.Checked = false;
				cbEliminadas.Enabled = false;
				cbPagadas.Enabled = false;
				dtpInicioOrdenFactura.Enabled = true;
				dtpFinOrdenFactura.Enabled = true;
			}else{
				cbEliminadas.Enabled = true;
				cbPagadas.Enabled = true;
				dtpInicioOrdenFactura.Enabled = false;
				dtpFinOrdenFactura.Enabled = false;
				dtpInicioOrdenFactura.Value = DateTime.Now;
				dtpFinOrdenFactura.Value = DateTime.Now;
				txtBusquedaOrdenFactura.Text = "";				
			}			
			filtros();
		}		
		
		void DgOrdenFacturaMouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right){
				var posicion = dgOrdenFactura.HitTest(e.X, e.Y);
				dgOrdenFactura.ClearSelection();
				if(posicion.RowIndex > -1 && posicion.ColumnIndex > -1){
					dgOrdenFactura.Rows[posicion.RowIndex].Selected = true;
					rowIndex = posicion.RowIndex;
					ColumnIndex = posicion.ColumnIndex;
				}
			}
		}
		
		void DgOrdenFacturaCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && e.ColumnIndex > -1 && e.ColumnIndex != 2 && e.ColumnIndex != 15){
				rowIndex = e.RowIndex;
				ColumnIndex = e.ColumnIndex;
				if(dgOrdenFactura[1, rowIndex].Value.ToString() == "GENERADA")
					Facturar();
				else if(dgOrdenFactura[1, rowIndex].Value.ToString() == "FACTURADA")
					Pagar();
				else
					MessageBox.Show("Selecciona una factura valida", "Error al seleccionar Factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
			
				
			if(e.ColumnIndex == 2 && e.RowIndex > -1){
				txtBusquedaOrdenFactura.Text = dgOrdenFactura[2, e.RowIndex].Value.ToString();
				rowIndex = e.RowIndex;
				ColumnIndex = e.ColumnIndex;
				cbEliminadasOrdenFactura.Checked = true;
				dtpInicioOrdenFactura.Value = DateTime.Now.AddDays(-7);
				dtpFinOrdenFactura.Value = DateTime.Now.AddDays(7);
			}
			
			if(e.RowIndex > -1 && e.ColumnIndex == 15){
				rowIndex = e.RowIndex;
				ColumnIndex = e.ColumnIndex;
				Pagar();
			}
		}
		
		void TxtBusquedaOrdenFacturaEnter(object sender, EventArgs e)
		{
			txtBusquedaOrdenFactura.SelectAll();
		}	
		
		void TxtBusquedaOrdenFacturaClick(object sender, EventArgs e)
		{			
			txtBusquedaOrdenFactura.SelectAll();
		}
		
		void TxtFacturaTextChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		//////////////////////////////////////////// MENU ////////////////////////////////////////////
		void TsmFacturarClick(object sender, EventArgs e)
		{
			if(dgOrdenFactura.SelectedRows.Count == 1)
				Facturar();
		}
		
		void TsmPagadaClick(object sender, EventArgs e)
		{			
			if(dgOrdenFactura.SelectedRows.Count == 1)
				Pagar();
		}
		
		void TsmEliminaClick(object sender, EventArgs e)
		{
			if(dgOrdenFactura.SelectedRows.Count == 1)
				Cancelar();
		}		
		#endregion		
	}
}
