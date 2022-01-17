using System;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.ComponentModel;
using System.Linq.Expressions;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using Transportes_LAR.Interfaz.Consultas;
using Transportes_LAR.Interfaz.Operaciones;
using System.Reflection;


namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormGastosServicios : Form
	{		
		#region CONSTRUCTOR
		public FormGastosServicios(FormPrincipal refPrinc)
		{
			InitializeComponent();
			formPrincipal = refPrinc;
			id_usuario = refPrinc.idUsuario;		
		}
		#endregion		
		
		#region VARIABLES
		public Int32 id_usuario;	
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal formPrincipal;
		public nmExcel.ApplicationClass ExcelApp = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN
		void FormGastosServiciosLoad(object sender, EventArgs e)
		{		
			dtpIncio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;
			filtros();
		}		
		
		void FormGastosServiciosFormClosing(object sender, FormClosingEventArgs e)
		{
			formPrincipal.gastoVenta = false;
		}
		#endregion
		
		#region FILTROS	
		public void filtros(){
			txtViajes.Text = "0";
			txtViajesValidados.Text = "0";
			txtDinero.Text = "0";
			txtCasetas.Text = "0";
			txtDiesel.Text = "0";
			txtOtros.Text = "0";
			txtGastos.Text = "0";
			
			string consulta = "";			
			consulta = @"select * from VIAJE_PROSPECTO_NUEVO  where FLUJO = '3' ";	
			if(cmbBusqueda.SelectedIndex > -1)
				consulta += "and "+cmbBusqueda.Text+" like '%"+txtBusqueda.Text+"%' ";
			if(cbTodos.Checked == true)
				consulta += " and FECHA_SALIDA BETWEEN '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"'";
			else
				consulta += " and FECHA_SALIDA >= '"+DateTime.Now.ToString("yyyy-MM-dd")+"' AND FORANEO = '1'";
			
		consulta += " order by FECHA_SALIDA";
			adaptadorPrincipal(consulta);				
		}
		#endregion		
		
		#region ADAPTADOR
		public void adaptadorPrincipal(string consulta){
			int contador = 0;
			ColoresAlternadosRows(dgRelacion);
			dgRelacion.Rows.Clear();					
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(),
				                 	"",
				                	"",
				                	conn.leer["CONTACTO"].ToString(),
				                	conn.leer["COMPANIA_NOMBRE"].ToString(),
				                 	conn.leer["EVENTO"].ToString(),	                
				                 	((conn.leer["FORANEO"].ToString().Equals("1"))? "SI": "NO"),
				                 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10),
				                 	conn.leer["FECHA_REGRESO"].ToString().Substring(0,10),			                
				                 	((conn.leer["FACTURA"].ToString().Equals("1"))? "SI": "NO"),
				                 	conn.leer["CANTIDAD"].ToString(),
				                 	conn.leer["PRECIO_UNITARIO"].ToString(),
				                 	conn.leer["TOTAL_IVA"].ToString(),		
				                 	conn.leer["CASETAS_SERVICIO"].ToString(),		
				                 	conn.leer["DIESEL_SERVICIO"].ToString(),		
				                 	conn.leer["OTROS_SERVICIO"].ToString(),
									"0",	"", ""); 
				contador++;
			}
			conn.conexion.Close();
			datosCompleta();
			dgRelacion.ClearSelection();
		}
		#endregion
		
		#region EVENTOS			
		void CmbBusquedaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbBusqueda.SelectedIndex > -1){
				if(cmbBusqueda.SelectedIndex == 0)
					txtBusqueda.AutoCompleteCustomSource = auto.AutoReconocimiento(@"select ID_RE dato from VIAJE_PROSPECTO_NUEVO where FLUJO = '3'");
				else if(cmbBusqueda.SelectedIndex == 1)
					txtBusqueda.AutoCompleteCustomSource = auto.AutoReconocimiento(@"select CONTACTO dato from VIAJE_PROSPECTO_NUEVO where FLUJO = '3'");
				else if(cmbBusqueda.SelectedIndex == 2)
					txtBusqueda.AutoCompleteCustomSource = auto.AutoReconocimiento(@"select COMPANIA dato from VIAJE_PROSPECTO_NUEVO where FLUJO = '3'");
				else if(cmbBusqueda.SelectedIndex == 3)
					txtBusqueda.AutoCompleteCustomSource = auto.AutoReconocimiento(@"select EVENTO dato from VIAJE_PROSPECTO_NUEVO where FLUJO = '3'");
				txtBusqueda.AutoCompleteMode =AutoCompleteMode.Suggest;
				txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
			}
		}		
		
		void CbTodosCheckedChanged(object sender, EventArgs e)
		{
			if(cbTodos.Checked){
				dtpIncio.Enabled = true;
				dtpFin.Enabled = true;
			}else{
				dtpIncio.Enabled = false;
				dtpFin.Enabled = false;
			}
		}
		#endregion
		
		#region METODOS
		public void datosCompleta(){
			for(int x=0; x<dgRelacion.Rows.Count; x++){
				string consul = @"select ID_C, CONF_CLIENTE from RUTA_ESPECIAL where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[1,x].Value = conn.leer["ID_C"].ToString();
					if(conn.leer["CONF_CLIENTE"].ToString().Length > 0){
						txtViajesValidados.Text = ( 1 + Convert.ToInt16(txtViajesValidados.Text)).ToString();
						for(int y=0; y<dgRelacion.Columns.Count; y++)					
							dgRelacion[y,x].Style.BackColor=Color.LightGreen;
					}
				}
				conn.conexion.Close();
				 
				consul = @"select CONTACTO, COMPANIA_NOMBRE, TOTAL_IVA from VIAJE_PROSPECTO_NUEVO where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[3,x].Value = conn.leer["CONTACTO"].ToString();
					dgRelacion[4,x].Value = conn.leer["COMPANIA_NOMBRE"].ToString();           	
				}	
				conn.conexion.Close();
				
				if(dgRelacion[3,x].Value.ToString() == "" && dgRelacion[4,x].Value.ToString() == ""){
					consul = @"select cs.Nombre, re.RESPONSABLE from ContactoServicio cs, RUTA_ESPECIAL re where cs.IdCliente = re.ID_C and re.ID_RE = "+dgRelacion[0,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgRelacion[3,x].Value = conn.leer["RESPONSABLE"].ToString();
						dgRelacion[4,x].Value = conn.leer["Nombre"].ToString();
				    }				
					conn.conexion.Close();
				}
				
				consul = @"select TIPO from COBRO_ESPECIAL where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["TIPO"].ToString().Equals("PADAGO"))
						dgRelacion[2,x].Value = dgRelacion[2,x].Value.ToString() + " " + "PAGO ANTICIPADO";
					else
						dgRelacion[2,x].Value = dgRelacion[2,x].Value.ToString() + " " + conn.leer["TIPO"].ToString();
				}				
				conn.conexion.Close();
				
				if(dgRelacion[12,x].Value.ToString() == "")
					dgRelacion[12,x].Value = "0";
				if(dgRelacion[13,x].Value.ToString() != "")
					dgRelacion[16,x].Value = ( Convert.ToInt32(dgRelacion[16,x].Value) + Convert.ToInt32(dgRelacion[13,x].Value) ).ToString();
				else
					dgRelacion[13,x].Value = "0";
				if(dgRelacion[14,x].Value.ToString() != "")
					dgRelacion[16,x].Value = ( Convert.ToInt32(dgRelacion[16,x].Value) + Convert.ToInt32(dgRelacion[14,x].Value) ).ToString();
				else
					dgRelacion[14,x].Value = "0";
				if(dgRelacion[15,x].Value.ToString() != "")
					dgRelacion[16,x].Value = ( Convert.ToInt32(dgRelacion[16,x].Value) + Convert.ToInt32(dgRelacion[15,x].Value) ).ToString();	
				else
					dgRelacion[15,x].Value = "0";				
				
				dgRelacion[16,x].Value = ( Convert.ToInt32(dgRelacion[16,x].Value) * Convert.ToInt32(dgRelacion[10,x].Value) ).ToString();
				
				
				txtDinero.Text = (Convert.ToDouble(dgRelacion[12,x].Value) + Convert.ToDouble(txtDinero.Text)).ToString();
				txtCasetas.Text = (Convert.ToDouble(dgRelacion[13,x].Value) + Convert.ToDouble(txtCasetas.Text)).ToString();
				txtDiesel.Text = (Convert.ToDouble(dgRelacion[14,x].Value) + Convert.ToDouble(txtDiesel.Text)).ToString();
				txtOtros.Text = (Convert.ToDouble(dgRelacion[15,x].Value) + Convert.ToDouble(txtOtros.Text)).ToString();
				txtGastos.Text = (Convert.ToDouble(dgRelacion[16,x].Value) + Convert.ToDouble(txtGastos.Text)).ToString();
			}
			txtViajes.Text = dgRelacion.Rows.Count.ToString();
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
			
		private int GetIDProcces(string nameProcces)
		{
			try{
				Process[] asProccess = Process.GetProcessesByName(nameProcces);
				foreach(Process pProccess in asProccess ){
					if(pProccess.MainWindowTitle == "")
						return pProccess.Id;
				}
				return -1;
			}catch{
				return -1;
			}
		}
		#endregion
						
		#region BOTONES				
		void BntBuscarClick(object sender, EventArgs e)
		{
			filtros();
		}
		
		void BtnExcelClick(object sender, EventArgs e)
		{
			try{
				this.ExcelApp = new nmExcel.ApplicationClass();				
				this.ExcelApp.Application.Workbooks.Add(Type.Missing);
				this.ExcelApp.Columns.ColumnWidth = 20;
				
				nmExcel.Worksheet newWorksheet;
				newWorksheet = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				newWorksheet.Name = "Gastos De Servicios";
				nmExcel.Range cells =  newWorksheet.Cells;
					
				cells[1,  1] = "ID";
				cells[1,  2] = "CONTACTO";
				cells[1,  3] = "CLIENTE";
				cells[1,  4] = "DESTINO";
				cells[1,  5] = "FORANEO";
				cells[1,  6] = "SALIDA";
				cells[1,  7] = "REGRESO";
				cells[1,  8] = "FACTURA";
				cells[1,  9] = "C.U.";
				cells[1,  10] = "PRECIO UNITARIO";
				cells[1,  11] = "TOTAL";
				cells[1,  12] = "CASETAS";
				cells[1,  13] = "DIESEL";
				cells[1,  14] = "OTROS";
				cells[1,  15] = "TOTAL GASTOS";
				
				for(int x=0; x<dgRelacion.Rows.Count; x++){
					cells[x + 2, 1] = dgRelacion.Rows[x].Cells[0].Value;
					cells[x + 2, 2] = dgRelacion.Rows[x].Cells[3].Value;
					cells[x + 2, 3] = dgRelacion.Rows[x].Cells[4].Value;
					cells[x + 2, 4] = dgRelacion.Rows[x].Cells[5].Value;
					cells[x + 2, 5] = dgRelacion.Rows[x].Cells[6].Value;
					cells[x + 2, 6] = dgRelacion.Rows[x].Cells[7].Value;
					cells[x + 2, 7] = dgRelacion.Rows[x].Cells[8].Value;
					cells[x + 2, 8] = dgRelacion.Rows[x].Cells[9].Value;
					cells[x + 2, 9] = dgRelacion.Rows[x].Cells[10].Value;
					cells[x + 2, 10] = dgRelacion.Rows[x].Cells[11].Value;
					cells[x + 2, 11] = dgRelacion.Rows[x].Cells[12].Value;
					cells[x + 2, 12] = dgRelacion.Rows[x].Cells[13].Value;
					cells[x + 2, 13] = dgRelacion.Rows[x].Cells[14].Value;
					cells[x + 2, 14] = dgRelacion.Rows[x].Cells[15].Value;
					cells[x + 2, 15] = dgRelacion.Rows[x].Cells[16].Value;
				}
				
					SaveFileDialog CuadroDialogo = new SaveFileDialog();
					CuadroDialogo.DefaultExt = "xlsx";
					CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
					CuadroDialogo.AddExtension = true;
					CuadroDialogo.RestoreDirectory = true;
					CuadroDialogo.Title = "Guardar";
					CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
					CuadroDialogo.FileName = "Gastos Servicios De "+dtpIncio.Value.ToString("dd-MM-yyyy")+" A "+dtpFin.Value.ToString("dd-MM-yyyy");
					if(CuadroDialogo.ShowDialog() == DialogResult.OK){
						this.ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
						this.ExcelApp.ActiveWorkbook.Saved = true;
						CuadroDialogo.Dispose();
						CuadroDialogo = null;
						this.ExcelApp = null;
						MessageBox.Show("Se creo el reporte correctamente ", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
						Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Gastos Servicios De "+dtpIncio.Value.ToString("dd-MM-yyyy")+" A "+dtpFin.Value.ToString("dd-MM-yyyy")+".xlsx"));
					}else
						MessageBox.Show("No Genero el Reporte ... ");
			}catch(Exception ex){
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{
				int idproc = GetIDProcces("EXCEL");
				if(idproc!=-1)
					Process.GetProcessById(idproc).Kill();
			}
		}
		#endregion
	}
}
