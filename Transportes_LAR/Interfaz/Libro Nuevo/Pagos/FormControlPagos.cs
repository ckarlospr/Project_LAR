using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormControlPagos : Form
	{
		#region VARIABLES
		Int64 id_re;
		string metodo;
		bool modificarProgramacion = false;
		string t = "";
		Int32 id_usu;
		#endregion
		
		#region INSTANCIAS		
		public FormLibroViajes Libro = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();		
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region CONSTRUCTOR
		public FormControlPagos(FormLibroViajes reflibro, Int64 id_r, string tipo)
		{
			InitializeComponent();
			id_re = id_r;
			Libro = reflibro;
			t = tipo;
		}
		#endregion		
			
		#region INICIO - FIN
		void FormControlPagosLoad(object sender, EventArgs e)
		{	
			id_usu = Libro.id_usuario;
			if(t == "2")
				tabControl1.SelectedTab  = tabPage2;
				
			cargarDatos();
			
			cbTipoPagoProgramacion.SelectedIndex = 0;
			dtpFechaProgramacion.Value = DateTime.Now;
			this.txtImporteProgramcion.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			adaptadorProgramacion();
			
			cbTipoPago.SelectedIndex = 0;
			dtpFechaPago.Value = DateTime.Now;
			this.txtImportePago.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			adaptadorPagos();
		}
		
		void FormControlPagosFormClosing(object sender, FormClosingEventArgs e)
		{
			Libro.filtrosPrincipales();
		}
		#endregion
	
		#region METODOS
		public void cargarDatos(){			
				conn.getAbrirConexion("select DESTINO, SALDO from RUTA_ESPECIAL where ID_RE = "+id_re);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){						
					txtDestinoServicio.Text = conn.leer["DESTINO"].ToString();
					txtImporteSevicio.Text = conn.leer["SALDO"].ToString();	
				}
				conn.conexion.Close();			
		}
		#endregion				
		
		//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		//--------------------------------------------------------------------------------- PESTAÑA PROGRAMACION DE PAGOS ---------------------------------------------------------------------------------//
		//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		
		#region ADAPTADOR
		public void adaptadorProgramacion(){						
			try{
				int contador = 0;
				txtImporteTotalProgramacion.Text = "0";
				string consulta = "select * from PROGRAMACION_PAGOS where id_re = "+id_re;
					dgPagosProgramdos.Rows.Clear();	
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{				
						dgPagosProgramdos.Rows.Add(conn.leer["ID"].ToString(),
							                        Convert.ToDateTime(conn.leer["FECHA"].ToString().Substring(0,10)).ToShortDateString(),
										            conn.leer["TIPO_PAGO"].ToString(),
							                        conn.leer["METODO"].ToString(),
							                        conn.leer["IMPORTE"].ToString());	
						if(conn.leer["FLUJO"].ToString().Equals("2")){
							for(int y=0; y<dgPagosProgramdos.Columns.Count; y++)
								dgPagosProgramdos[y,contador].Style.BackColor = Color.LightGreen;						
						}
						
						/*
						foreach (DataGridViewRow row in dgPagosProgramdos.Rows)
						{							
							if(conn.leer["FLUJO"].ToString().Equals("2"))
								row.DefaultCellStyle.BackColor = Color.LightGreen;
						}*/
						contador++;
						txtImporteTotalProgramacion.Text = (Convert.ToInt32(txtImporteTotalProgramacion.Text) + Convert.ToInt32(conn.leer["IMPORTE"])).ToString();
					}
					conn.conexion.Close();			
				}catch(Exception ex){
					MessageBox.Show("Error: "+ex.Message);				
			}finally{
				conn.conexion.Close();	
			}
				dgPagosProgramdos.ClearSelection();
		}
		#endregion		
		
		#region BOTONES
		void TxtGuardarProgramcionClick(object sender, EventArgs e)
		{
			if(txtImporteProgramcion.Text != ""){
				if(modificarProgramacion == false)
					connL.insertarProgramacionPago(id_re, dtpFechaProgramacion.Value.ToString("yyyy-MM-dd"), cbTipoPagoProgramacion.Text, metodo, txtImporteProgramcion.Text, "", Libro.principal.idUsuario);
				else
					connL.actualizarProgramacionPago(Convert.ToInt32(dgPagosProgramdos[0,dgPagosProgramdos.CurrentRow.Index].Value), dtpFechaProgramacion.Value.ToString("yyyy-MM-dd"), cbTipoPagoProgramacion.Text, metodo, txtImporteProgramcion.Text, "");
				limpiarProgramacion();
			}else{
				errorProvider1.SetError(txtImporteProgramcion, "Captura el campo");
        		txtImporteProgramcion.Focus();
			}
		}
		
		void BnSalirProgramcionClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void CbTipoPagoProgramacionSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbTipoPagoProgramacion.SelectedIndex == 0){
				cbMetodo1Programacion.Visible = true;
				cbMetodo2Programcion.Visible = false;
			}else{				
				cbMetodo1Programacion.Visible = false;
				cbMetodo2Programcion.Visible = true;
			}
			cbMetodo1Programacion.SelectedIndex = -1;
		}
		
		void CbMetodo1ProgramacionSelectedIndexChanged(object sender, EventArgs e)
		{
			metodo = cbMetodo1Programacion.Text;
			if(cbMetodo1Programacion.Text == "AL OPERADOR"){
				dtpFechaProgramacion.Enabled = false;
				dtpFechaProgramacion.Value = Libro.dtpFechaSalida.Value;
			}else{
				dtpFechaProgramacion.Enabled = true;
				dtpFechaProgramacion.Value = DateTime.Now;
			}
		}
		
		void CbMetodo2ProgramcionSelectedIndexChanged(object sender, EventArgs e)
		{
			metodo = cbMetodo2Programcion.Text;
		}
		
		void DgPagosProgramdosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				modificarProgramacion = true;				
				conn.getAbrirConexion("select * from PROGRAMACION_PAGOS where ID = "+dgPagosProgramdos[0,dgPagosProgramdos.CurrentRow.Index].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){						
					dtpFechaProgramacion.Value = Convert.ToDateTime(conn.leer["FECHA"]);
					cbTipoPagoProgramacion.Text = conn.leer["TIPO_PAGO"].ToString();
					if(conn.leer["TIPO_PAGO"].ToString().Equals("EFECTIVO"))
						cbMetodo1Programacion.Text = conn.leer["METODO"].ToString();
					else
						cbMetodo2Programcion.Text = conn.leer["METODO"].ToString();
					txtImporteProgramcion.Text = conn.leer["IMPORTE"].ToString();	
				}
				conn.conexion.Close();			
			}
		}
		#endregion
		
		#region MENU
		void ConfirmarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(modificarProgramacion == true){
				connL.confirmarProgramacionPago(Convert.ToInt32(dgPagosProgramdos[0,dgPagosProgramdos.CurrentRow.Index].Value));
				limpiarProgramacion();
			}
		}
		#endregion
		
		#region METODOS
		public void limpiarProgramacion(){
			
			adaptadorProgramacion();
			modificarProgramacion = false;
			dgPagosProgramdos.ClearSelection();			
			cbTipoPagoProgramacion.SelectedIndex = 0;
			dtpFechaProgramacion.Value = DateTime.Now;
			txtImporteProgramcion.Text = "";
		}
			
		#endregion
		
		//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		//------------------------------------------------------------------------------------ PESTAÑA CONTROL DE PAGOS -----------------------------------------------------------------------------------//
		//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		
		#region ADAPTADOR
		public void adaptadorPagos(){				
			try{
				txtImporteTotalPago.Text = "0";
				string consulta = "select * from ANTICIPOS_ESPECIALES  where id_re = "+id_re;
					dgPagos.Rows.Clear();	
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{				
						//ID	ID_RE	CANTIDAD	NUMERO	FECHA	ESTATUS	ID_U	FECHA_CONFIRMADO	TIPO	cometario	ETIQUETA	UBICA	ID_COBRO
						dgPagos.Rows.Add(conn.leer["ID"].ToString(),
							                        Convert.ToDateTime(conn.leer["FECHA"].ToString().Substring(0,10)).ToShortDateString(),
										            "",//folio
										            conn.leer["CANTIDAD"].ToString(),
							                        conn.leer["TIPO"].ToString(),
							                        conn.leer["NUMERO"].ToString());						
						txtImporteTotalPago.Text = (Convert.ToInt32(txtImporteTotalPago.Text) + Convert.ToInt32(conn.leer["CANTIDAD"])).ToString();
						txtSaldo.Text =  (Convert.ToDouble(txtImporteSevicio.Text) - Convert.ToDouble(txtImporteTotalPago.Text)).ToString();
					}
					conn.conexion.Close();			
				}catch(Exception ex){
					MessageBox.Show("Error: "+ex.Message);				
			}finally{
				conn.conexion.Close();	
			}
			dgPagos.ClearSelection();
		}
		#endregion		
		
		#region BOTONES
		void BtnSalirPagoClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnGuardarPagoClick(object sender, EventArgs e)
		{			
			string tipo = "";
			if(cbTipoPago.Text == "EFECTIVO")
				tipo = "EFECTIVO";
			else
				tipo = "DEPOSITO";
			
			if(validacionCamposPagos()){
				DialogResult respuesta = MessageBox.Show("Al guardar este pago no se podrá modificar ¿Deseas continuar? ", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(respuesta == DialogResult.Yes){
					//connL.insertarPago(id_re, dtpFechaPago.Value.ToString("yyyy-MM-dd"), cbTipoPago.Text, txtComprobantePago.Text, txtFolioPago.Text, txtImportePago.Text, "", Libro.principal.idUsuario, "ANTICIPO", txtubica.Text, txtComentario.Text, ((cbOperador.Checked == true)? "SI" : "NO" ));
					connL.insertarPago2(id_re, dtpFechaPago.Value.ToString("yyyy-MM-dd"), tipo, txtComprobantePago.Text, txtImportePago.Text, "ANTICIPO", txtubica.Text, txtComentario.Text, id_usu);
					limpiarPagos();
				}
			}
		}		
		#endregion
		
		#region METODOS
		public bool validacionCamposPagos(){
			bool respuesta = true;
							
			if(txtComprobantePago.Text == ""){
				errorProvider1.SetError(txtComprobantePago, "Captura el campo");
        		txtComprobantePago.Focus();
        		respuesta = false;
			}
			
			if(txtImportePago.Text == ""){
				errorProvider1.SetError(txtImportePago, "Captura el campo");
        		txtImportePago.Focus();
        		respuesta = false;
			}
			return respuesta;			
		}
		
		public void limpiarPagos(){			
			adaptadorPagos();
			dgPagos.ClearSelection();
			dtpFechaPago.Value = DateTime.Now;			
			cbTipoPago.SelectedIndex = 0;
			txtComprobantePago.Text = "";
			txtFolioPago.Text = "";
			txtImportePago.Text = "";
			txtComentario.Text = "";
		}
			
		#endregion
		
		#region EVENTOS
		void CbTipoPagoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbTipoPago.SelectedIndex == 1){
				lblUbica.Visible = true;
				txtubica.Visible = true;
				txtubica.Text = "";				
			}else if(cbTipoPago.SelectedIndex == 2){
				lblUbica.Visible = true;
				txtubica.Visible = true;
				txtubica.Text = "";			
			}else{
				lblUbica.Visible = false;
				txtubica.Visible = false;	
				txtubica.Text = "N/A";			
			}
		}	

		void CbMetodo2ProgramcionClick(object sender, EventArgs e)
		{
			cbMetodo2Programcion.Items.Clear();
			string consulta = @"select DF.RAZON_SOCIAL from DATOS_FACTURA DF, MAS_DATOS_FACTURACION MDF WHERE DF.ID = MDF.ID_DATOS_F AND TIPO = 'CONTRIBUYENTE'";
			try{			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){	
					cbMetodo2Programcion.Items.Add(conn.leer["RAZON_SOCIAL"].ToString());
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener a los contribuyentes: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				conn.conexion.Close();
			}
		}		
		#endregion				
	}
}
