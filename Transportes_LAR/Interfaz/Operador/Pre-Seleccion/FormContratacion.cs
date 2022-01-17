using System;
using System.Drawing.Text;
using System.IO;
using System.Drawing;
using System.Runtime.Remoting;
using iTextSharp.text;
using System.Diagnostics;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions; 
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormContratacion : Form
	{		
		/*********************************************************************************************************/
		/*********************************************** PRINCIPAL ***********************************************/
		/*********************************************************************************************************/
		
		#region VARIABLES		
		string rutaFile;
		bool imagen = false;
		int id_usuario;
		Int64 ID_PREOPERADOR = 0;
		public int rowIndex = 0;
		public int ColumnIndex = 0;
		System.IO.MemoryStream ms = null;
		public bool banderaModifica = true;
		public bool banderaFiltros = false;
		public bool banderaInicio = true;
		public Dato.Parametros parametros;
		#endregion
		
		#region INSTANCIAS
		private FormPrincipal principal = null;
		private FormRegistar registrar = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
		#endregion
		
		#region CONSTRUCTORES
		public FormContratacion()
		{
			InitializeComponent();
		}
		
		public FormContratacion(FormPrincipal refprincipal, int id_usu)
		{
			InitializeComponent();
			this.principal = refprincipal;
			id_usuario = id_usu;
		}
		
		public FormContratacion(FormRegistar refregistrar, FormPrincipal refprincipal, int id_usu)
		{
			InitializeComponent();
			this.principal = refprincipal;
			this.registrar = refregistrar;
			id_usuario = id_usu;
		}
		#endregion
		
		#region INICIO - FIN
		void FormContratacionLoad(object sender, EventArgs e)
		{
			inicio();
			
			if(registrar != null){
				cmbTipoOperador.Text = registrar.cmbTipoOperador.Text;
				txtNombre.Text = registrar.txtNombre.Text;
				txtApellidoP.Text = registrar.txtApellidoP.Text;
				txtApellidoM.Text = registrar.txtApellidoM.Text;
				
				obtenerCandidatoAI(false);
				validaCandidato();
				logicaAlias();
				
				cmbTipoLicEstatal.Text = registrar.cmbTipoLicEstatal.Text;				
				cmbEstadoEstatal.Text = registrar.cmbEstadoEstatal.Text;
				txtNumLicEstatal.Text = registrar.txtNumLicEstatal.Text;
				dtpVigenciaLicEstatal.Text = registrar.dtpVigenciaLicEstatal.Text;
				cmbTipoLicFederal.Text = registrar.cmbTipoLicFederal.Text;				
				cmbEstadoFederal.Text = registrar.cmbEstadoFederal.Text;
				txtNumLicFederal.Text = registrar.txtNumLicFederal.Text;
				dtpVigenciaLicFederal.Text = registrar.dtpVigenciaLicFederal.Text;
				txtNumLicAptoMedico.Text = registrar.txtNumLicAptoMedico.Text;
				dtpVigenciaLicAptoMedico.Text = registrar.dtpVigenciaLicAptoMedico.Text;
								
				txtDualA.Text = registrar.txtDualA.Text;
				txtDualM.Text = registrar.txtDualM.Text;
				txtDirTraseraA.Text = registrar.txtDirTraseraA.Text;
				txtDirTraseraM.Text = registrar.txtDirTraseraM.Text;
				txtTransPersonalA.Text = registrar.txtTransPersonalA.Text;
				txtTransPersonalM.Text = registrar.txtTransPersonalM.Text;
				cmbZona.Text = registrar.cmbZona.Text;
				txtColonia.Text = registrar.txtColonia.Text;
				
				registrar.Close();
			}
		}
				
		void FormContratacionFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.contratacion = false;			
			if (!(FuenteDeVideo == null))
	            if (FuenteDeVideo.IsRunning){
	                FuenteDeVideo.SignalToStop();
	                FuenteDeVideo = null;
	            }
		}
		#endregion
		
		#region BOTONES
		void PbConfiguracionesClick(object sender, EventArgs e)
		{
			new FormParametros(this, id_usuario).ShowDialog();
		}
		#endregion
		
		#region EVENTOS		
		////////////////////////////// CONTROL DE LLAMADAS //////////////////////////////
		void CbTodosLlamadasCheckedChanged(object sender, EventArgs e)
		{
			if(cbTodosLlamadas.Checked == true){
				dtpInicioLlamadas.Enabled = true;
				dtpInicioLlamadas.Value = Convert.ToDateTime("01/"+DateTime.Now.Month+"/"+DateTime.Now.Year);
				dtpFinLlamadas.Value = Convert.ToDateTime( DateTime.DaysInMonth( DateTime.Now.Year , +DateTime.Now.Month)+"/"+DateTime.Now.Month+"/"+DateTime.Now.Year);
			}else{
				dtpInicioLlamadas.Enabled = false;
				dtpFinLlamadas.Value = DateTime.Now;
			}
		}
		
		void DtpFinLlamadasValueChanged(object sender, EventArgs e)
		{			
			filtrosLlamadas();
		}		
		
		void CbBolsaTrabajoLlamadaCheckedChanged(object sender, EventArgs e)
		{
			filtrosLlamadas();
		}
		
		void CmbFiltroLlamadaSelectedIndexChanged(object sender, EventArgs e)
		{
			filtrosLlamadas();
		}
		
		void TxtFiltroLlamadaTextChanged(object sender, EventArgs e)
		{			
			filtrosLlamadas();
		}
		
		void DgControLlamadasMouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right){				
				dgControlSolicitudes.ClearSelection();	
				var posicion = dgControLlamadas.HitTest(e.X, e.Y);
				dgControLlamadas.ClearSelection();
				if(posicion.RowIndex > -1 && posicion.ColumnIndex > -1){
					dgControLlamadas.Rows[posicion.RowIndex].Selected = true;
					rowIndex = posicion.RowIndex;
					ColumnIndex = posicion.ColumnIndex;
				}
			}
		}
		
		void DgControLlamadasCellClick(object sender, DataGridViewCellEventArgs e)
		{			
			if(e.RowIndex > -1 && e.ColumnIndex > -1){
				dgControlSolicitudes.ClearSelection();				
				rowIndex = e.RowIndex;
				ColumnIndex = e.ColumnIndex;
				ID_PREOPERADOR = Convert.ToInt64(dgControLlamadas[0,rowIndex].Value);
				banderaModifica = false;
				obtenerCandidatoAI(true);
				banderaModifica = true;
				validaCandidato();
			}
		}
		/////////////////////////////////////////////////////////////////////////////////
		
		//////////////////////////// CONTROL DE SOLICITUDES /////////////////////////////
		void CbTodosSolicitudCheckedChanged(object sender, EventArgs e)
		{				
			if(cbTodosSolicitud.Checked == true){
				dtpFinSolicitud.Enabled = true;
				dtpInicioSolicitud.Enabled = true;
			}else{				
				dtpFinSolicitud.Enabled = false;
				dtpInicioSolicitud.Enabled = false;
			}
			filtrosSolicitudes();
		}
		
		void DtpFinSolicitudValueChanged(object sender, EventArgs e)
		{
			if(cbTodosSolicitud.Checked == true)
				filtrosSolicitudes();
		}	
		
		void CmbFiltroSolicitudSelectedIndexChanged(object sender, EventArgs e)
		{
			filtrosSolicitudes();
		}
		
		void TxtFiltroSolicitudTextChanged(object sender, EventArgs e)
		{
			filtrosSolicitudes();
		}	
		
		void DgControlSolicitudesCellClick(object sender, DataGridViewCellEventArgs e)
		{					
			if(e.RowIndex > -1 && e.ColumnIndex > -1){
				dgControLlamadas.ClearSelection();				
				
				rowIndex = e.RowIndex;
				ColumnIndex = e.ColumnIndex;
				ID_PREOPERADOR = Convert.ToInt64(dgControlSolicitudes[0,rowIndex].Value);
				
				banderaModifica = false;
				obtenerCandidatoAI(true);
				banderaModifica = true;
				validaCandidato();
				logicaAlias();
			}
			
		}
		
		void DgControlSolicitudesMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right){			
				dgControLlamadas.ClearSelection();	
				var posicion = dgControlSolicitudes.HitTest(e.X, e.Y);
				if(posicion.RowIndex > -1 && posicion.ColumnIndex > -1){
					dgControlSolicitudes.Rows[posicion.RowIndex].Selected = true;
					rowIndex = posicion.RowIndex;
					ColumnIndex = posicion.ColumnIndex;
				}
			}
		}	
		
		void CbBolsaTrabajoCheckedChanged(object sender, EventArgs e)
		{
			filtrosSolicitudes();
		}
		
		void DgControlSolicitudesCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && dgControlSolicitudes[9,e.RowIndex].Value.ToString() ==  "VALIDADO" ){
				if(e.ColumnIndex == 10){
					DialogResult rs = MessageBox.Show("¿Deseas confirmar la asistencia del canditado a la cita de manejo ?", "Confirmación de cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(rs == DialogResult.Yes){
						if(connO.confirmarCita( Convert.ToInt64(dgControlSolicitudes[11,e.RowIndex].Value),"CONFIRMADA", id_usuario)){
							MessageBox.Show("Se confirmó correctamente la cita de manejo", "Confirmacion de cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtrosSolicitudes();
						}
					}
				}
				if(e.ColumnIndex == 18){
					DialogResult rs = MessageBox.Show("¿Deseas confirmar la asistencia del canditado a la cita médica ?", "Confirmación de cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(rs == DialogResult.Yes){
						if(connO.confirmarCita( Convert.ToInt64(dgControlSolicitudes[19,e.RowIndex].Value),"CONFIRMADA", id_usuario)){
							MessageBox.Show("Se confirmó correctamente la cita médica", "Confirmacion de cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtrosSolicitudes();
						}
					}
				}
			}
			
			if(e.ColumnIndex != 10 && e.ColumnIndex != 18){		
				obtenerCandidatoS();
				if(dgControlSolicitudes[9,e.RowIndex].Value.ToString() ==  "INICIALES")				
					tcPrincipal.SelectedIndex = 1;
				if(dgControlSolicitudes[9,e.RowIndex].Value.ToString() ==  "SOLICITUD")				
					tcPrincipal.SelectedIndex = 2;
			}
		}	
		/////////////////////////////////////////////////////////////////////////////////
		#endregion
		
		#region METODOS
		private void inicio(){
			/******************************************* ASPECTOS INICIALES ******************************************/
			tpSolicitud.Enabled = false;			
			cmbTipoOperador.SelectedIndex = 0;	
			cmbTipoOperador.Focus();
			cmbTipoOperador.Enabled = true;
			
			cmbCasa.SelectedIndex = 0;
			this.txtMontoInf.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			
			txtFuenteOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT Alias FROM OPERADOR group by Alias order by Alias", "Alias");
           	txtFuenteOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFuenteOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtNombre.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT Nombre FROM OPERADOR group by Nombre order by nombre", "Nombre");
           	txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtApellidoP.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT Apellido_Pat FROM OPERADOR group by Apellido_Pat order by Apellido_Pat", "Apellido_Pat");
           	txtApellidoP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtApellidoP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtApellidoM.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT Apellido_Mat FROM OPERADOR group by Apellido_Mat order by Apellido_Mat", "Apellido_Mat");
           	txtApellidoM.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtApellidoM.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            txtColonia.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT COLONIA FROM PRE_OPERADOR group by COLONIA order by COLONIA", "COLONIA");
           	txtColonia.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtColonia.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			this.txtDualA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTransPersonalA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtDirTraseraA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);            
			this.txtDualM.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTransPersonalM.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtDirTraseraM.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			/*********************************************** SOLICITUD ***********************************************/
			cmbEstadoS.SelectedIndex = 0;
			txtMunicipioNaciS.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT MUNICIPIO_NACIMIENTO FROM PRE_OPERADOR group by MUNICIPIO_NACIMIENTO order by MUNICIPIO_NACIMIENTO", "MUNICIPIO_NACIMIENTO");
           	txtMunicipioNaciS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMunicipioNaciS.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtLugarNaciS.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT LUGAR_NACIMIENTO FROM PRE_OPERADOR group by LUGAR_NACIMIENTO order by LUGAR_NACIMIENTO", "LUGAR_NACIMIENTO");
           	txtLugarNaciS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtLugarNaciS.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtEstadoNaciS.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT ESTADO_NACIMIENTO FROM PRE_OPERADOR group by ESTADO_NACIMIENTO order by ESTADO_NACIMIENTO", "ESTADO_NACIMIENTO");
           	txtEstadoNaciS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEstadoNaciS.AutoCompleteSource = AutoCompleteSource.CustomSource;    
            
			txtCalleS.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT CALLE FROM PRE_OPERADOR group by CALLE order by CALLE", "CALLE");
           	txtCalleS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCalleS.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtMunicipioS.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT MUNICIPIO FROM PRE_OPERADOR group by MUNICIPIO order by MUNICIPIO", "MUNICIPIO");
           	txtMunicipioS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMunicipioS.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtCPS.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT CP FROM PRE_OPERADOR group by CP order by CP", "CP");
           	txtCPS.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCPS.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			this.txtCPS.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);			
			
			this.txtPesoS.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			this.txtAlturaS.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
						
			toolTip1.SetToolTip(btnLicenciasAI, "Ajuste Licencias");
			toolTip1.SetToolTip(btnLimpiarAI, "Inicio");
			toolTip1.SetToolTip(btnImprimirAI, "Imprimir");
			toolTip1.SetToolTip(lblAliasS, "Mensaje WhatsApp");
			
			toolTip1.SetToolTip(btnWhatsappS, "Mensaje WhatsApp");
			toolTip1.SetToolTip(btnImprimirS, "Imprimir");
			
			
			
			/*********************************************** PRINCIPAL ***********************************************/
			if(principal.lblDatoNivel.Text=="GERENCIAL" || principal.lblDatoNivel.Text=="MASTER")
				pbConfiguraciones.Visible = true;
						
			dtpFinLlamadas.Value = DateTime.Now;
			dtpInicioLlamadas.Value = DateTime.Now;		
			
			dtpFinSolicitud.Value = DateTime.Now;
			dtpInicioSolicitud.Value = DateTime.Now;
			
			cmbFiltroLlamada.SelectedIndex = 0;
			cmbFiltroSolicitud .SelectedIndex = 0;
			
			banderaInicio = false;
			
			if(registrar == null){
				filtrosLlamadas();
				filtrosSolicitudes();
			}				
			getParametros();
			getZonasFuentes();
		}
		
		////////////////////////////// CONTROL DE LLAMADAS //////////////////////////////
		public void filtrosLlamadas(){	
			if(!banderaInicio){
				
				ColoresAlternadosRows(dgControLlamadas);
				dgControLlamadas.Rows.Clear();	
				
				string consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO = 'LLAMADA' and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO = 'LLAMADA' 
								and ESTADO = 'ACTIVA' and FECHA <= '"+dtpFinLlamadas.Value.ToString("yyyy-MM-dd")+"' )";
				
				string consulta2 = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO = 'LLAMADA' and TRAMITE = 'BOLSA DE TRABAJO'";
	
				if(cbTodosLlamadas.Checked == false){
					consulta += " and ESTATUS != 'CANCELADA'";
					dgControLlamadas.Columns[12].Visible = false;
				}else{
					consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO = 'LLAMADA' and ESTATUS = 'CANCELADA'  and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO = 'LLAMADA' 
					and ESTADO = 'ACTIVA' and FECHA BETWEEN '"+dtpInicioLlamadas.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinLlamadas.Value.ToString("yyyy-MM-dd")+"')";
					dgControLlamadas.Columns[12].Visible = true;	
				}
				if(cmbFiltroLlamada.SelectedIndex == 0){
					consulta += " and NOMBRE like '%"+txtFiltroLlamada.Text+"%'";
					consulta2 += " and NOMBRE like '%"+txtFiltroLlamada.Text+"%'";
				}
				if(cmbFiltroLlamada.SelectedIndex == 1){
					consulta += " and APELLIDO_PAT like '%"+txtFiltroLlamada.Text+"%'";
					consulta2 += " and APELLIDO_PAT like '%"+txtFiltroLlamada.Text+"%'";
				}
				if(cmbFiltroLlamada.SelectedIndex == 2){
					consulta += " and APELLIDO_MAT like '%"+txtFiltroLlamada.Text+"%'";
					consulta2 += " and APELLIDO_MAT like '%"+txtFiltroLlamada.Text+"%'";
				}
				if(cmbFiltroLlamada.SelectedIndex == 3){
					consulta += " and ZONA like '%"+txtFiltroLlamada.Text+"%'";
					consulta2 += " and ZONA like '%"+txtFiltroLlamada.Text+"%'";
				}
				if(!cbBolsaTrabajoLlamada.Checked){
					consulta += " and TRAMITE != 'BOLSA DE TRABAJO'";
				}else			
					adaptadorLlamadas(consulta2);
				adaptadorLlamadas(consulta);

				if(cbBolsaTrabajoLlamada.Checked)
					eliminaRepetidos(dgControLlamadas);
				
				complementoAdaptadorLlamada(dgControLlamadas);
				dgControLlamadas.Sort(dgControLlamadas.Columns[9], ListSortDirection.Ascending);
				dgControLlamadas.ClearSelection();			
				rowIndex = 0;
				ColumnIndex = 0;
			}
		}
		
		private void adaptadorLlamadas(string consulta){
			int contador = 0;			
//			try{
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgControLlamadas.Rows.Add(conn.leer["ID"].ToString(),
 	                      						conn.leer["FOLIO"].ToString(),
 	                      						conn.leer["NOMBRE"].ToString(),
					                      		conn.leer["APELLIDO_PAT"].ToString()+" "+conn.leer["APELLIDO_MAT"].ToString(),
					                      		"", // telefono
					                      		conn.leer["ZONA"].ToString(),
					                      		(DateTime.Today.AddTicks(-Convert.ToDateTime(conn.leer["FECHA_NACIMIENTO"]).Ticks).Year - 1),// Años
						                        conn.leer["FLUJO"].ToString(),     
												conn.leer["TIPO"].ToString(), "", "", "", "", conn.leer["ESTATUS"].ToString());
					if(conn.leer["ESTATUS"].ToString() == "CANCELADA"){
						for(int y=0; y<dgControLlamadas.Columns.Count; y++){
							dgControLlamadas[y,contador].Style.ForeColor = Color.Black;							
							dgControLlamadas[y,contador].Style.BackColor = Color.Red;
						}
					}
					contador++;
				}				
				conn.conexion.Close();			
//			}catch(Exception ex){
//				MessageBox.Show("Error al obtener los registros de los candidatos (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
//			}finally{
//				if(conn.conexion != null)
//					conn.conexion.Close();	
//			}
		}
		
		private void complementoAdaptadorLlamada(DataGridView dgAll){
			string consulta = "";
			txtTiempoLlamada.Text = "0";
			txtTiempoLlamada.BackColor = Color.White;
			for(int x=0; x<dgAll.RowCount; x++){				
				if(dgAll[8,x].Value.ToString() == "Nuevo Ingreso")
					dgAll[8,x].Value = "NUEVO";
				dgAll[8,x].Value = dgAll[8,x].Value.ToString().ToUpper();				
				
				try{
					consulta = "SELECT * FROM TELEFONOS_PRE_OPERADOR WHERE ESTATUS = 'Activo' AND  ID_PREOPERADOR = "+dgAll[0,x].Value.ToString()+" and FOLIO = '"+dgAll[1,x].Value.ToString()+"' order by id ASC";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						dgAll[4,x].Value = conn.leer["NUMERO"].ToString();
					conn.conexion.Close();	
				}catch(Exception){
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
				
				try{
					consulta = "SELECT * FROM CITA_PRE_OPERADOR WHERE ID_PREOPERADOR = "+dgAll[0,x].Value.ToString()+" and FOLIO = '"+dgAll[1,x].Value.ToString()+"' AND  TIPO = 'LLAMADA' AND ESTADO = 'ACTIVA' ORDER BY FECHA, HORA DESC";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgAll[9,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy")+" "+conn.leer["HORA"].ToString().Substring(0,5);
						dgAll[10,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy");
						dgAll[11,x].Value = conn.leer["HORA"].ToString().Substring(0,8);
					}
					conn.conexion.Close();	
				}catch(Exception){
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
				
				if( dgAll[8,x].Value.ToString() !=  "CANCELADA" ){
					try{
						DateTime date1 = Convert.ToDateTime(dgAll[10,x].Value);
						DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
		 				int result1 = DateTime.Compare(date1, date2);     				
		 				if(result1 == -1 && dgAll[2,x].Style.BackColor.Name != "Red"){
				 			dgAll[9,x].Style.ForeColor = Color.Red;
		 					for(int y=0; y<9; y++)
		 						dgAll[y,x].Style.ForeColor = Color.Red;
		 					txtTiempoLlamada.Text = (Convert.ToInt32(txtTiempoLlamada.Text) + 1).ToString();
		 					txtTiempoLlamada.BackColor = Color.Red;
		 				}else{
		 					if( Convert.ToDateTime(dgAll.Rows[x].Cells[10].Value) <= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))){
		 						if(Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).AddHours(1) > Convert.ToDateTime(dgAll.Rows[x].Cells[11].Value)){
						 			//dgAll[9,x].Style.ForeColor = Color.White;
				 					//for(int y=0; y<9; y++)
				 						//dgAll[y,x].Style.ForeColor = Color.White;
				 					txtTiempoLlamada.Text = (Convert.ToInt32(txtTiempoLlamada.Text) + 1).ToString();
				 					txtTiempoLlamada.BackColor = Color.Red;
								}
		 					}	
		 				}
					}catch(Exception){
						dgAll[9,x].Value = "N/A";
						dgAll[10,x].Value = "N/A";
						dgAll[11,x].Value = "N/A";
					}	 				
				}
				//dgAll[4,x].Style.ForeColor = Color.Black;				
				if(cbTodosLlamadas.Checked == true){
					if( dgAll[8,x].Value.ToString().Equals("CANCELADA")){
						try{
							consulta = "SELECT * FROM PRE_OPERADOR_CANCELA WHERE ID_PREOPERADOR = "+dgAll[0,x].Value.ToString()+" and FOLIO = '"+dgAll[1,x].Value.ToString()+"' order by id DESC";
							conn.getAbrirConexion(consulta);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read())
								dgAll[12,x].Value = conn.leer["MOTIVO"].ToString();
							conn.conexion.Close();	
						}catch(Exception){
						}finally{
							if(conn.conexion != null)
								conn.conexion.Close();	
						}
					}else
						dgAll[12,x].Value = "N/A";
				}
			}
		}
			
		/////////////////////////////////////////////////////////////////////////////////
		
		//////////////////////////// CONTROL DE SOLICITUDES /////////////////////////////
		public void filtrosSolicitudes(){
			if(!banderaInicio){
				string consulta = "";
				
				ColoresAlternadosRows(dgControlSolicitudes);
				dgControlSolicitudes.Rows.Clear();	
					
				if(cbTodosSolicitud.Checked == false){
					if(cbBolsaTrabajo.Checked)
						consulta = "select * from PRE_OPERADOR where FLUJO = 'INICIALES'";
					else
						consulta = "select * from PRE_OPERADOR where FLUJO = 'INICIALES' and TRAMITE != 'BOLSA DE TRABAJO'";				
					adaptadorSolicitudes(consulta);	
	
					if(cbBolsaTrabajo.Checked)
						consulta = "select * from PRE_OPERADOR where FLUJO = 'SOLICITUD'";
					else
						consulta = "select * from PRE_OPERADOR where FLUJO = 'SOLICITUD' and TRAMITE != 'BOLSA DE TRABAJO'";				
					adaptadorSolicitudes(consulta);					
					/*
					consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO = 'VALIDADO' and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO = 'MANEJO' 
								and ESTADO = 'ACTIVA' and FECHA <= '"+DateTime.Now.ToString("yyyy-MM-dd")+"' )";
					adaptadorSolicitudes(consulta);
					
					consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO = 'VALIDADO' and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO = 'MEDICO' 
								and ESTADO = 'ACTIVA' and FECHA <= '"+DateTime.Now.ToString("yyyy-MM-dd")+"' )";
					adaptadorSolicitudes(consulta);
					
					if(cbDocumentos.Checked == true){
						consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO = 'CERRADO' and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO = 'DOCUMENTOS' 
									and ESTADO = 'ACTIVA' and FECHA <= '"+DateTime.Now.ToString("yyyy-MM-dd")+"' )";
						adaptadorSolicitudes(consulta);
					}
					*/
					eliminaRepetidos(dgControlSolicitudes);
					
						
				}else{	
					if(cbBolsaTrabajo.Checked)
						consulta = "select * from PRE_OPERADOR where FLUJO = 'SOLICITUD'";
					else
						consulta = "select * from PRE_OPERADOR where FLUJO = 'SOLICITUD' and TRAMITE != 'BOLSA DE TRABAJO'";		
					adaptadorSolicitudes(consulta);					
					
					if(cbBolsaTrabajo.Checked){
						consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO != 'LLAMADA'  and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO != 'LLAMADA'  and TIPO != 'DOCUMENTOS' 
						and ESTADO = 'ACTIVA' and FECHA BETWEEN '"+dtpInicioSolicitud.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinSolicitud.Value.ToString("yyyy-MM-dd")+"')";
					}else{
						consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO != 'LLAMADA'  and TRAMITE != 'BOLSA DE TRABAJO' and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO != 'LLAMADA'  and TIPO != 'DOCUMENTOS' 
						and ESTADO = 'ACTIVA' and FECHA BETWEEN '"+dtpInicioSolicitud.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinSolicitud.Value.ToString("yyyy-MM-dd")+"')";
					}
					adaptadorSolicitudes(consulta);	
					
					/*		
					if(cbDocumentos.Checked == true){
						consulta = @"SELECT * FROM PRE_OPERADOR WHERE FLUJO = 'CERRADO' and ID IN (SELECT ID_PREOPERADOR FROM CITA_PRE_OPERADOR WHERE TIPO = 'DOCUMENTOS' 
						and ESTADO = 'ACTIVA' and FECHA BETWEEN '"+dtpInicioSolicitud.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinSolicitud.Value.ToString("yyyy-MM-dd")+"')";
						adaptadorSolicitudes(consulta);
					}*/
				}
								
				complementoAdaptadorSolicitud(dgControlSolicitudes);			
				dgControlSolicitudes.ClearSelection();
			
				rowIndex = 0;
				ColumnIndex = 0;
			}
		}
		
		private void adaptadorSolicitudes(string consulta){
			int contador = 0;			
//			try{
				
				if(cmbFiltroSolicitud.SelectedIndex == 0)
					consulta += " and NOMBRE like '%"+txtFiltroSolicitud.Text+"%'";
				if(cmbFiltroSolicitud.SelectedIndex == 1)
					consulta += " and APELLIDO_PAT like '%"+txtFiltroSolicitud.Text+"%'";
				if(cmbFiltroSolicitud.SelectedIndex == 2)
					consulta += " and APELLIDO_MAT like '%"+txtFiltroSolicitud.Text+"%'";
				if(cmbFiltroSolicitud.SelectedIndex == 3)
					consulta += " and ZONA like '%"+txtFiltroSolicitud.Text+"%'";	
				
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgControlSolicitudes.Rows.Add(conn.leer["ID"].ToString(),
 	                      						conn.leer["FOLIO"].ToString(),
 	                      						conn.leer["NOMBRE"].ToString(),
					                      		conn.leer["APELLIDO_PAT"].ToString()+" "+conn.leer["APELLIDO_MAT"].ToString(),
					                      		(DateTime.Today.AddTicks(-Convert.ToDateTime(conn.leer["FECHA_NACIMIENTO"]).Ticks).Year - 1),// Años
					                      		"", // telefono
						                        conn.leer["TIPO"].ToString(),
					                      		conn.leer["ZONA"].ToString(),
						                        conn.leer["TRAMITE"].ToString(),  
						                        conn.leer["FLUJO"].ToString(), 
						                        "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",						                        
												conn.leer["ESTATUS"].ToString());
					contador++;					
				}				
				conn.conexion.Close();			
//			}catch(Exception ex){
//				MessageBox.Show("Error al obtener los registros de los candidatos (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
//			}finally{
//				if(conn.conexion != null)
//					conn.conexion.Close();	
//			}
		}
		
		private void complementoAdaptadorSolicitud(DataGridView dgAll){
			string consulta = "";
			txtTiempoSolicitud.Text = "0";
			txtTiempoSolicitud.BackColor = Color.White;
			for(int x=0; x<dgAll.RowCount; x++){
				if(dgAll[6,x].Value.ToString() == "Nuevo Ingreso")
					dgAll[6,x].Value = "NUEVO";
				dgAll[6,x].Value = dgAll[6,x].Value.ToString().ToUpper();
				
				try{
					consulta = "SELECT * FROM TELEFONOS_PRE_OPERADOR WHERE ESTATUS = 'Activo' AND  ID_PREOPERADOR = "+dgAll[0,x].Value.ToString()+" and FOLIO = '"+dgAll[1,x].Value.ToString()+"' order by id ASC";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						dgAll[5,x].Value = conn.leer["NUMERO"].ToString();
					conn.conexion.Close();	
				}catch(Exception){
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
				
				if(dgAll[7,x].Value.ToString() == "SOLICITUD"){
					dgAll[10,x].Value = "N/A";
					dgAll[18,x].Value = "N/A";
				}else if(dgAll[9,x].Value.ToString() == "CERRADO"){
					try{
						consulta = "SELECT * FROM CITA_PRE_OPERADOR WHERE ID_PREOPERADOR = "+dgAll[0,x].Value.ToString()+" and FOLIO = '"+dgAll[1,x].Value.ToString()+"' AND  TIPO = 'DOCUMENTOS' AND ESTADO != 'CANCELADA' ORDER BY FECHA, HORA DESC";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							dgAll[10,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy")+" "+conn.leer["HORA"].ToString().Substring(0,5);
							dgAll[11,x].Value = conn.leer["ID"].ToString();
							dgAll[12,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy");
							dgAll[13,x].Value = conn.leer["HORA"].ToString().Substring(0,8);
							dgAll[14,x].Value = conn.leer["MOTIVO_ESTADO"].ToString();		
							dgAll[15,x].Value = conn.leer["ESTADO"].ToString();		
							dgAll[16,x].Value = conn.leer["COMENTARIO"].ToString();		
							dgAll[17,x].Value = Convert.ToDateTime(conn.leer["FECHA_REGISTRO"]).ToString("dd/MM/yyy");
							dgAll[18,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy")+" "+conn.leer["HORA"].ToString().Substring(0,5);
							dgAll[19,x].Value = conn.leer["ID"].ToString();
							dgAll[20,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy");
							dgAll[21,x].Value = conn.leer["HORA"].ToString().Substring(0,8);	
							dgAll[22,x].Value = conn.leer["MOTIVO_ESTADO"].ToString();	
							dgAll[23,x].Value = conn.leer["ESTADO"].ToString();		
							dgAll[24,x].Value = conn.leer["COMENTARIO"].ToString();	
							dgAll[25,x].Value = Convert.ToDateTime(conn.leer["FECHA_REGISTRO"]).ToString("dd/MM/yyy");	
						}else{
							dgAll[10,x].Value = "SIN AGENDAR";
							dgAll[11,x].Value = "0";
							dgAll[12,x].Value = "0";
							dgAll[13,x].Value = "0";
							dgAll[14,x].Value = "0";
							dgAll[15,x].Value = "0";
							dgAll[16,x].Value = "0";
							dgAll[17,x].Value = "0";
							dgAll[18,x].Value = "SIN AGENDAR";
							dgAll[19,x].Value = "0";
							dgAll[20,x].Value = "0";
							dgAll[21,x].Value = "0";
							dgAll[22,x].Value = "0";
							dgAll[23,x].Value = "0";
							dgAll[24,x].Value = "0";
							dgAll[25,x].Value = "0";
						}
						conn.conexion.Close();	
					}catch(Exception){
					}finally{
						if(conn.conexion != null)
							conn.conexion.Close();	
					}
				}else{
					try{
						consulta = "SELECT * FROM CITA_PRE_OPERADOR WHERE ID_PREOPERADOR = "+dgAll[0,x].Value.ToString()+" and FOLIO = '"+dgAll[1,x].Value.ToString()+"' AND  TIPO = 'MANEJO' AND ESTADO != 'CANCELADA' ORDER BY FECHA, HORA DESC";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							dgAll[10,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy")+" "+conn.leer["HORA"].ToString().Substring(0,5);
							dgAll[11,x].Value = conn.leer["ID"].ToString();
							dgAll[12,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy");
							dgAll[13,x].Value = conn.leer["HORA"].ToString().Substring(0,8);
							dgAll[14,x].Value = conn.leer["MOTIVO_ESTADO"].ToString();		
							dgAll[15,x].Value = conn.leer["ESTADO"].ToString();		
							dgAll[16,x].Value = conn.leer["COMENTARIO"].ToString();		
							dgAll[17,x].Value = Convert.ToDateTime(conn.leer["FECHA_REGISTRO"]).ToString("dd/MM/yyy");
						}else{
							dgAll[10,x].Value = "SIN AGENDAR";
							dgAll[11,x].Value = "0";
							dgAll[12,x].Value = "0";
							dgAll[13,x].Value = "0";
							dgAll[14,x].Value = "0";
							dgAll[15,x].Value = "0";
							dgAll[16,x].Value = "0";
							dgAll[17,x].Value = "0";
						}
						conn.conexion.Close();	
					}catch(Exception){
					}finally{
						if(conn.conexion != null)
							conn.conexion.Close();	
					}
					
					try{
						consulta = "SELECT * FROM CITA_PRE_OPERADOR WHERE ID_PREOPERADOR = "+dgAll[0,x].Value.ToString()+" and FOLIO = '"+dgAll[1,x].Value.ToString()+"' AND  TIPO = 'MEDICO' AND ESTADO != 'CANCELADA' ORDER BY FECHA, HORA DESC";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							dgAll[18,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy")+" "+conn.leer["HORA"].ToString().Substring(0,5);
							dgAll[19,x].Value = conn.leer["ID"].ToString();
							dgAll[20,x].Value = Convert.ToDateTime(conn.leer["FECHA"]).ToString("dd/MM/yyy");
							dgAll[21,x].Value = conn.leer["HORA"].ToString().Substring(0,8);	
							dgAll[22,x].Value = conn.leer["MOTIVO_ESTADO"].ToString();	
							dgAll[23,x].Value = conn.leer["ESTADO"].ToString();		
							dgAll[24,x].Value = conn.leer["COMENTARIO"].ToString();	
							dgAll[25,x].Value = Convert.ToDateTime(conn.leer["FECHA_REGISTRO"]).ToString("dd/MM/yyy");						
						}else{
							dgAll[18,x].Value = "SIN AGENDAR";
							dgAll[19,x].Value = "0";
							dgAll[20,x].Value = "0";
							dgAll[21,x].Value = "0";
							dgAll[22,x].Value = "0";
							dgAll[23,x].Value = "0";
							dgAll[24,x].Value = "0";
							dgAll[25,x].Value = "0";
						}
						conn.conexion.Close();	
					}catch(Exception){
					}finally{
						if(conn.conexion != null)
							conn.conexion.Close();	
					}
					
					//////////////////////////////////////////////////	MANEJO  //////////////////////////////////////////////////
					if( dgAll[9,x].Value.ToString() ==  "VALIDADO"){					
						if(dgAll[14,x].Value.ToString() !=  "VALIDADA" && dgAll[14,x].Value.ToString() !=  "CONFIRMADA"){
							if( Convert.ToDateTime(dgAll.Rows[x].Cells[17].Value) < Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")) ){
								DateTime date1 = Convert.ToDateTime(dgAll[12,x].Value);
								DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
				 				int result1 = DateTime.Compare(date1, date2);
				 				if(result1 == -1){
				 					//dgAll[9,x].Style.BackColor = Color.Red;
				 					dgAll[10,x].Style.ForeColor = Color.Red;
				 					for(int y=0; y<10; y++)
				 						dgAll[y,x].Style.ForeColor = Color.Red;
				 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
				 					txtTiempoSolicitud.BackColor = Color.Red;
				 				}else{
				 					if( Convert.ToDateTime(dgAll.Rows[x].Cells[12].Value) <= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")) ){
				 						if(Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).AddHours(1) > Convert.ToDateTime(dgAll.Rows[x].Cells[13].Value)){
						 					dgAll[10,x].Style.ForeColor = Color.Red;
						 					for(int y=0; y<10; y++)
						 						dgAll[y,x].Style.ForeColor = Color.Red;
						 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
						 					txtTiempoSolicitud.BackColor = Color.Red;
										}
				 					}
				 				}
							}else if( Convert.ToDateTime(dgAll.Rows[x].Cells[17].Value) == Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")) ){
								DateTime date1 = Convert.ToDateTime(dgAll[12,x].Value);
								DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
				 				int result1 = DateTime.Compare(date1, date2);
				 				if(result1 == -1){
				 					dgAll[10,x].Style.ForeColor = Color.Red;
				 					for(int y=0; y<10; y++)
				 						dgAll[y,x].Style.ForeColor = Color.Red;
				 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
				 					txtTiempoSolicitud.BackColor = Color.Red;
				 				}else{
				 					if( Convert.ToDateTime(dgAll.Rows[x].Cells[12].Value) <= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))){
				 						if(Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).AddMinutes(10) > Convert.ToDateTime(dgAll.Rows[x].Cells[13].Value)){
						 					dgAll[10,x].Style.ForeColor = Color.Red;
						 					for(int y=0; y<10; y++)
						 						dgAll[y,x].Style.ForeColor = Color.Red;
						 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
						 					txtTiempoSolicitud.BackColor = Color.Red;
										}
				 					}
				 				}
							}
						}else{
							if(Convert.ToDateTime(dgAll.Rows[x].Cells[13].Value).AddHours(2) <= Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"))){
	 							dgAll[10,x].Style.ForeColor = Color.Red;
			 					for(int y=0; y<10; y++)
			 						dgAll[y,x].Style.ForeColor = Color.Red;
			 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
			 					txtTiempoSolicitud.BackColor = Color.Red;
							}
							
							dgAll[10,x].Style.BackColor = Color.LightGreen;
							if(dgAll[14,x].Value.ToString() ==  "VALIDADA")
								dgAll[10,x].Value = dgAll[16,x].Value.ToString();
						}
					//////////////////////////////////////////////////	MEDICO  //////////////////////////////////////////////////
						 if( dgAll[22,x].Value.ToString() !=  "VALIDADA"  && dgAll[22,x].Value.ToString() !=  "CONFIRMADA"){
							if( Convert.ToDateTime(dgAll.Rows[x].Cells[25].Value) < Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")) ){
								DateTime date1 = Convert.ToDateTime(dgAll[20,x].Value);
								DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
				 				int result1 = DateTime.Compare(date1, date2);
				 				if(result1 == -1){
				 					dgAll[18,x].Style.ForeColor = Color.Red;
				 					for(int y=0; y<10; y++)
				 						dgAll[y,x].Style.ForeColor = Color.Red;
						 					
				 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
				 					txtTiempoSolicitud.BackColor = Color.Red;
				 				}else{
				 					if( Convert.ToDateTime(dgAll.Rows[x].Cells[20].Value) <= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))){
				 						if(Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).AddHours(1) > Convert.ToDateTime(dgAll.Rows[x].Cells[21].Value)){
						 					dgAll[18,x].Style.ForeColor = Color.Red;
						 					for(int y=0; y<10; y++)
				 								dgAll[y,x].Style.ForeColor = Color.Red;
						 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
						 					txtTiempoSolicitud.BackColor = Color.Red;
										}
				 					}
				 				}
							}else if( Convert.ToDateTime(dgAll.Rows[x].Cells[25].Value) == Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")) ){
								DateTime date1 = Convert.ToDateTime(dgAll[20,x].Value);
								DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
				 				int result1 = DateTime.Compare(date1, date2);
				 				if(result1 == -1){
				 					dgAll[18,x].Style.ForeColor = Color.Red;
				 					for(int y=0; y<10; y++)
				 						dgAll[y,x].Style.ForeColor = Color.Red;
				 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
				 					txtTiempoSolicitud.BackColor = Color.Red;
				 				}else{
				 					if( Convert.ToDateTime(dgAll.Rows[x].Cells[20].Value) <= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))){
				 						if(Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).AddMinutes(10) > Convert.ToDateTime(dgAll.Rows[x].Cells[21].Value)){
						 					dgAll[18,x].Style.ForeColor = Color.Red;
						 					for(int y=0; y<10; y++)
				 								dgAll[y,x].Style.ForeColor = Color.Red;
						 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
						 					txtTiempoSolicitud.BackColor = Color.Red;
										}
				 					}
				 				}
							}
						}else{
							if(Convert.ToDateTime(dgAll.Rows[x].Cells[21].Value).AddHours(2) <= Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"))){
	 							dgAll[18,x].Style.ForeColor = Color.Red;
			 					for(int y=0; y<10; y++)
	 								dgAll[y,x].Style.ForeColor = Color.Red;
			 					txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();
			 					txtTiempoSolicitud.BackColor = Color.Red;
							}
						
							dgAll[18,x].Style.BackColor = Color.LightGreen;
							if(dgAll[22,x].Value.ToString() ==  "VALIDADA")
								dgAll[18,x].Value = dgAll[24,x].Value.ToString();
						}
					}else if(dgAll[9,x].Value.ToString() ==  "SOLICITUD")
						 txtTiempoSolicitud.Text = (Convert.ToInt32(txtTiempoSolicitud.Text) + 1).ToString();					
				}
			}
		}
	
		private void eliminaRepetidos(DataGridView dgAll){
			for(int x = 0; x<(dgAll.RowCount-1); x++){
				for(int y = x+1; y<dgAll.RowCount; y++){
					if(dgAll[0,x].Value.ToString() == dgAll[0,y].Value.ToString()){
						dgAll.Rows.RemoveAt(y);
						if(x>0){
							--x;
							break;
						}
					}
				}
			}
		}
		/////////////////////////////////////////////////////////////////////////////////
		
		public void getParametros(){
			if(parametros != null)
				parametros = null;
			parametros = new Dato.Parametros();
			
			if(parametros != null){
				try{
					conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 5");
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						parametros.edadMin = conn.leer["PARAMETRO1"].ToString();
						parametros.edadMax = conn.leer["PARAMETRO2"].ToString();
						parametros.imagen = conn.leer["PARAMETRO3"].ToString();
						parametros.tatuajes = conn.leer["PARAMETRO4"].ToString();
						parametros.percing = conn.leer["PARAMETRO5"].ToString();
						parametros.infonavit = conn.leer["PARAMETRO6"].ToString();						
					}
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
				try{
					conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 6");
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						parametros.expDual = conn.leer["PARAMETRO1"].ToString();
						parametros.expDirTrasera = conn.leer["PARAMETRO2"].ToString();
						parametros.expTransPersonal = conn.leer["PARAMETRO3"].ToString();
						parametros.descEstatal = conn.leer["PARAMETRO4"].ToString();
						parametros.descFederal = conn.leer["PARAMETRO5"].ToString();
						parametros.descAptoMedico = conn.leer["PARAMETRO6"].ToString();						
					}
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
				try{
					conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 7");
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						parametros.licEstatal = conn.leer["PARAMETRO1"].ToString();
						parametros.vigEstatal = conn.leer["PARAMETRO2"].ToString();
						parametros.licFederal = conn.leer["PARAMETRO3"].ToString();
						parametros.vigFederal = conn.leer["PARAMETRO4"].ToString();
						parametros.vigAptoMedico = conn.leer["PARAMETRO5"].ToString();					
					}
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
				try{
					conn.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = 8");
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						parametros.contactoTaller = conn.leer["PARAMETRO1"].ToString();
						parametros.numeroTaller = conn.leer["PARAMETRO2"].ToString();
						parametros.contactoOficina = conn.leer["PARAMETRO3"].ToString();
						parametros.numeroOficina = conn.leer["PARAMETRO4"].ToString();
					}
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener los parámetros: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
			}
		}
		
		public void getZonasFuentes(){
			cmbZona.Items.Clear();
			try{
				conn.getAbrirConexion("SELECT * FROM PRE_OPERADOR_ZONAS_FUENTES WHERE ESTATUS = 'Activo' AND TIPO = 'ZONA' order by NOMBRE");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
					cmbZona.Items.Add(conn.leer["NOMBRE"].ToString());
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las Zonas: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				if(conn.conexion != null)
					conn.conexion.Close();	
			}			
			cmbZona.SelectedIndex = -1;
			
			
			cmFuente.Items.Clear();
			try{
				conn.getAbrirConexion("SELECT * FROM PRE_OPERADOR_ZONAS_FUENTES WHERE ESTATUS = 'Activo' AND TIPO = 'FUENTE' order by NOMBRE");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
					cmFuente.Items.Add(conn.leer["NOMBRE"].ToString());
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las Fuentes: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				if(conn.conexion != null)
					conn.conexion.Close();	
			}			
			cmFuente.SelectedIndex = -1;
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		#endregion	
		
		#region MENU´S		
		////////////////////////////// CONTROL DE LLAMADAS //////////////////////////////
		void CambiarFechaDeCitaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControlSolicitudes.SelectedRows.Count == 0 && dgControLlamadas.SelectedRows.Count == 1){
				if(dgControLlamadas[13, rowIndex].Value.ToString() != "CANCELADA" && dgControLlamadas[9, rowIndex].Value.ToString() != "N/A")
					new FormReCita(this, id_usuario, Convert.ToInt64(dgControLlamadas[0, rowIndex].Value), "LLAMADA").ShowDialog();
				else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			
		}
		
		void CancelarRegistroToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControlSolicitudes.SelectedRows.Count == 0 && dgControLlamadas.SelectedRows.Count == 1){
				if(dgControLlamadas[13, rowIndex].Value.ToString() != "CANCELADA"){
					new FormCancelaLlamada(this, id_usuario, Convert.ToInt64(dgControLlamadas[0, rowIndex].Value), dgControLlamadas[1,rowIndex].Value.ToString(), true).ShowDialog();
					//new FormRechazar(this, id_usuario, Convert.ToInt64(dgControLlamadas[0, rowIndex].Value), 0, 0, dgControLlamadas[1,rowIndex].Value.ToString(), "LLAMADA").ShowDialog();
				}else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/////////////////////////////////////////////////////////////////////////////////
		
		//////////////////////////// CONTROL DE SOLICITUDES /////////////////////////////
		void ReCitasClick(object sender, EventArgs e)
		{
			if(dgControlSolicitudes.SelectedRows.Count == 1 && dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes[11, rowIndex].Value.ToString() != "0" && dgControlSolicitudes[19, rowIndex].Value.ToString() != "0"){
				new FormCitas(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), Convert.ToInt64(dgControlSolicitudes[11, rowIndex].Value), Convert.ToInt64(dgControlSolicitudes[19, rowIndex].Value), 1, dgControlSolicitudes[1, rowIndex].Value.ToString() ).ShowDialog();
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void ReCitaManejoClick(object sender, EventArgs e)
		{
			if(dgControlSolicitudes.SelectedRows.Count == 1 && dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes[11, rowIndex].Value.ToString() != "0" ){
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() == "VALIDADO" && dgControlSolicitudes[14, rowIndex].Value.ToString() != "VALIDADA")
					new FormReCita(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), "MANEJO").ShowDialog();
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void ReCitaMedicaClick(object sender, EventArgs e)
		{
			if(dgControlSolicitudes.SelectedRows.Count == 1 && dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes[19, rowIndex].Value.ToString() != "0"){
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() == "VALIDADO" && dgControlSolicitudes[22, rowIndex].Value.ToString() != "VALIDADA")
					new FormReCita(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), "MEDICO").ShowDialog();
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void OnfirmarCitaManejoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){			
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" && dgControlSolicitudes[14, rowIndex].Value.ToString() != "VALIDADA" && dgControlSolicitudes[14, rowIndex].Value.ToString() != "CONFIRMADA"){
					DialogResult rs = MessageBox.Show("¿Deseas confirmar la asistencia del canditado a la cita de manejo ?", "Confirmación de cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(rs == DialogResult.Yes){
						if(connO.confirmarCita( Convert.ToInt64(dgControlSolicitudes[11,rowIndex].Value),"CONFIRMADA", id_usuario)){
							MessageBox.Show("Se confirmó correctamente la cita de manejo", "Confirmacion de cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtrosSolicitudes();
						}
					}
				}else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void ConfirmarCitaMedicaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" && dgControlSolicitudes[22, rowIndex].Value.ToString() != "VALIDADA" && dgControlSolicitudes[22, rowIndex].Value.ToString() != "CONFIRMADA"){
					DialogResult rs = MessageBox.Show("¿Deseas confirmar la asistencia del canditado a la cita médica ?", "Confirmación de cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(rs == DialogResult.Yes){
						if(connO.confirmarCita( Convert.ToInt64(dgControlSolicitudes[19,rowIndex].Value),"CONFIRMADA", id_usuario)){
							MessageBox.Show("Se confirmó correctamente la cita médica", "Confirmacion de cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtrosSolicitudes();
						}
					}
				}else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void ConfirmarCitasToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" && dgControlSolicitudes[14, rowIndex].Value.ToString() != "VALIDADA" && dgControlSolicitudes[14, rowIndex].Value.ToString() != "CONFIRMADA"
				   && dgControlSolicitudes[22, rowIndex].Value.ToString() != "VALIDADA" && dgControlSolicitudes[22, rowIndex].Value.ToString() != "CONFIRMADA"){
					DialogResult rs = MessageBox.Show("¿Deseas confirmar la asistencia a las citas de manejo y médica del candidato?", "Confirmación de citas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(rs == DialogResult.Yes){
						bool respuesa = connO.confirmarCita( Convert.ToInt64(dgControlSolicitudes[11,rowIndex].Value),"CONFIRMADA", id_usuario);
						respuesa = connO.confirmarCita( Convert.ToInt64(dgControlSolicitudes[19,rowIndex].Value),"CONFIRMADA", id_usuario);
						if(respuesa){
							MessageBox.Show("Se confirmó correctamente las citas de manejo y médica", "Confirmación de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtrosSolicitudes();
						}
					}
				}else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
			
		void ValidaCitaManejoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" && dgControlSolicitudes[14, rowIndex].Value.ToString() != "VALIDADA"){
					new FormValidaCitas(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), Convert.ToInt64(dgControlSolicitudes[11,rowIndex].Value), 
					                    Convert.ToInt64(dgControlSolicitudes[19,rowIndex].Value), dgControlSolicitudes[1,rowIndex].Value.ToString(), "MANEJO").ShowDialog();
				}else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void ValidaCitaMédicaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" && dgControlSolicitudes[22, rowIndex].Value.ToString() != "VALIDADA"){
					new FormValidaCitas(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), Convert.ToInt64(dgControlSolicitudes[11,rowIndex].Value), 
					                    Convert.ToInt64(dgControlSolicitudes[19,rowIndex].Value), dgControlSolicitudes[1,rowIndex].Value.ToString(), "MEDICA").ShowDialog();
				}else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void ValidarCitasToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				//if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" && dgControlSolicitudes[14, rowIndex].Value.ToString() != "VALIDADA" && dgControlSolicitudes[22, rowIndex].Value.ToString() != "VALIDADA"){
					new FormValidaCitas(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), Convert.ToInt64(dgControlSolicitudes[11,rowIndex].Value), 
					                    Convert.ToInt64(dgControlSolicitudes[19,rowIndex].Value), dgControlSolicitudes[1,rowIndex].Value.ToString(), "TODAS").ShowDialog();
				//}else
					//MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}		
		
		void CandidatoAptoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" ){
					new FormApto(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), Convert.ToInt64(dgControlSolicitudes[11,rowIndex].Value), 
					                    Convert.ToInt64(dgControlSolicitudes[19,rowIndex].Value), dgControlSolicitudes[1,rowIndex].Value.ToString()).ShowDialog();
				}else
					MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		void CancelarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				//if(dgControlSolicitudes[9, rowIndex].Value.ToString() ==  "VALIDADO" ){					
					new FormRechazar(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), Convert.ToInt64(dgControlSolicitudes[11,rowIndex].Value), 
					                    Convert.ToInt64(dgControlSolicitudes[19,rowIndex].Value), dgControlSolicitudes[1,rowIndex].Value.ToString(), "SELECCION").ShowDialog();
				//}else
					//MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
				
		void ImprimirToolStripMenuItemClick(object sender, EventArgs e)
		{
			ImprimeDocInduccion();
		}
		
		void CitaTallerToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgControLlamadas.SelectedRows.Count == 0 && dgControlSolicitudes.SelectedRows.Count == 1 && rowIndex > -1){
				new FormCitaWhatsapp(this, id_usuario, Convert.ToInt64(dgControlSolicitudes[0, rowIndex].Value), dgControlSolicitudes[2,rowIndex].Value+" "+dgControlSolicitudes[3,rowIndex].Value).ShowDialog();
			}else
				MessageBox.Show("Selecciona un registro valido", "Error al seleccionar el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		/////////////////////////////////////////////////////////////////////////////////
		
		#endregion
		
		/*********************************************************************************************************/
		/******************************************* ASPECTOS INICIALES ******************************************/
		/*********************************************************************************************************/
		
		#region VARIABLES y ARREGLOS
		public int peinado = 0, pelo = 0, manosCara = 0, rasurado = 0, ropa = 0, pantalon = 0, zapato = 0, calzado = 0, vestimenta = 0, 
					presentacionCamisa1 = 0, presentacionCamisa2 = 0, presentacionCamisa3 = 0, presentacionPantalon1 = 0;
		public List <Interfaz.Operador.Dato.Telefonos> ListarTelefonos = null;
		public Dato.LicenciasAjuste licAjuste;
		bool ajustesLic = false;
		#endregion
		
		#region BOTONES
		void BtnAgregarContactoClick(object sender, EventArgs e)
		{
			new FormTelefonos(this).ShowDialog();
		}
		
		void BtnConfirmarClick(object sender, EventArgs e)
		{
			if(ValidaInsertar()){
				if(lblIngreso.Text == "Nuevo Ingreso"){
					if(InsertaRegistro("NUEVO")){
						MessageBox.Show("Se agregó correctamente el registro NUEVO", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						string folioN = connO.obtenerIDCandidato().ToString();
						lblFolio.Text = ((folioN.Length == 1)? "000"+folioN : ((folioN.Length == 2)? "00"+folioN : ((folioN.Length == 3)? "0"+folioN : folioN ) ) );
						ImprimeAutorizacion();
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Candidato Activo"){
					if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Candidato por Contratar"){
					if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Llamada Cancelada"){
					if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Bolsa de Trabajo"){
					if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Reingreso Sin Control"){
					if(InsertaRegistro("REINGRESO")){
						MessageBox.Show("Se agregó correctamente el registro del REINGRESO", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						string folioN = connO.obtenerIDCandidato().ToString();
						lblFolio.Text = ((folioN.Length == 1)? "000"+folioN : ((folioN.Length == 2)? "00"+folioN : ((folioN.Length == 3)? "0"+folioN : folioN ) ) );
						ImprimeAutorizacion();
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Reingreso Candidato Activo"){
					if(ModificaRegistro("REINGRESO",  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Reingreso"){
					if(ModificaRegistro( "REINGRESO",  "INICIALES", 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Reingreso Llamada Cancelada"){
					if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Reingreso Bolsa de Trabajo"){
					if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}else if(lblIngreso.Text == "Operador Activo"){
					if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
						MessageBox.Show("Se modificó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						filtrosLlamadas();
						filtrosSolicitudes();
						limpiaFiltrosOperador();
						limpiarCamposAI();
						rowIndex = 0;
						ColumnIndex = 0;
					}
				}			
			}
		}
		
		void BtnImprimirAIClick(object sender, EventArgs e)
		{
			if(ValidaInsertar()){
				ImprimeAutorizacion();
				getParametros();
			}
		}
		
		void BtnWhatsappAIClick(object sender, EventArgs e)
		{
			copySpechAspectos2();
		}
		
		void BtnLimpiarAIClick(object sender, EventArgs e)
		{
			/*
			limpiaFiltrosOperador();
			limpiarCamposAI();
			rowIndex = 0;
			ColumnIndex = 0;
			*/
			this.Close();		
			principal.openRegistrar();
		}
		
		void BtnLicenciasAIClick(object sender, EventArgs e)
		{
			if(ajustesLic)
				new FormLicenciasAjuste(this).ShowDialog();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			if(lblIngreso.Text == "Candidato Rechazado" || lblIngreso.Text == "Reingreso Candidato Rechazado"){				
			
			}
		}
		#endregion
		
		#region EVENTOS
		void TxtNombreTextChanged(object sender, EventArgs e)
		{			
			if(txtNombre.Text.Length > 0)
				validaCandidato();
		}
		
		void TxtApellidoPTextChanged(object sender, EventArgs e)
		{
			if(txtApellidoP.Text.Length > 0)
				validaCandidato();
		}
		
		void TxtApellidoMTextChanged(object sender, EventArgs e)
		{
			if(txtApellidoM.Text.Length > 0)
				validaCandidato();
		}
		
		void TxtMontoInfLeave(object sender, EventArgs e)
		{			
			Proceso.ValidarCampo.punto = false;
		}
		
		void TxtMontoInfEnter(object sender, EventArgs e)
		{
			if(txtMontoInf.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}

		void TxtMontoInfTextChanged(object sender, EventArgs e)
		{
			if(txtMontoInf.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			
			if(!banderaFiltros)
				ValidaFiltrosOperador();
		}

		void DtpNacimientoLeave(object sender, EventArgs e)
		{
			Edad();			
		}

		void CmFuenteSelectedIndexChanged(object sender, EventArgs e)
		{
			FiltrosFuente();
		}
		
		void DtpNacimientoValueChanged(object sender, EventArgs e)
		{
			Edad();
		}
				
		void TxtNombreLeave(object sender, EventArgs e)
		{	
			txtNombre.Text = txtNombre.Text.Trim();
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0)
				obtenerCandidatoAI(false);
		}
		
		void TxtApellidoPLeave(object sender, EventArgs e)
		{			
			txtApellidoP.Text = txtApellidoP.Text.Trim();
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0)
				obtenerCandidatoAI(false);
		}
		
		void TxtApellidoMLeave(object sender, EventArgs e)
		{			
			txtApellidoM.Text = txtApellidoM.Text.Trim();
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0 && txtApellidoM.Text.Length > 0){				
				obtenerCandidatoAI(false);
				logicaAlias();
			}
		}		
		
		void CmbTatuajesSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTatuajes.SelectedIndex > -1)
				lblTatuajes.Text = cmbTatuajes.Text;
			else
				lblTatuajes.Text = "";
			if(!banderaFiltros)
				ValidaFiltrosOperador();
		}		
		
		void CmbPiercingSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbPiercing.SelectedIndex > -1)
				lblPiercing.Text = cmbPiercing.Text;
			else
				lblPiercing.Text = "";
			if(!banderaFiltros)
				ValidaFiltrosOperador();
		}
		
		void TxtDualATextChanged(object sender, EventArgs e)
		{
			if(!banderaFiltros)
				ValidaFiltrosOperador();
		}
		
		void TxtDirTraseraATextChanged(object sender, EventArgs e)
		{
			if(!banderaFiltros)
				ValidaFiltrosOperador();
		}
		
		void TxtTransPersonalATextChanged(object sender, EventArgs e)
		{
			if(!banderaFiltros)
				ValidaFiltrosOperador();
		}
		
		void CmbTipoLicEstatalSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipoLicEstatal.SelectedIndex > -1)
				lblTipoEstatal.Text = cmbTipoLicEstatal.Text;
			else
				lblTipoEstatal.Text = "";
			if(!banderaFiltros)
				ValidaFiltrosOperador();
			
			logicaLicencias();
			
			if(cmbTipoLicEstatal.SelectedIndex > 0 && cmbTipoLicFederal.SelectedIndex == -1)
				cmbTipoLicFederal.SelectedIndex = 0;
		}
		
		void CmbTipoLicFederalSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipoLicFederal.SelectedIndex > -1)
				lblTipoFederal.Text = cmbTipoLicFederal.Text;
			else
				lblTipoFederal.Text = "";
			
			if(!banderaFiltros)
				ValidaFiltrosOperador();
			
			logicaLicencias();
			
			if(cmbTipoLicFederal.SelectedIndex > 0 && cmbTipoLicEstatal.SelectedIndex == -1)
				cmbTipoLicEstatal.SelectedIndex = 0;
		}
		
		void DtpVigenciaLicEstatalValueChanged(object sender, EventArgs e)
		{
			if(!banderaFiltros)
				ValidaFiltrosOperador();
			
			logicaLicencias();
		}
		
		void DtpVigenciaLicFederalValueChanged(object sender, EventArgs e)
		{
			if(!banderaFiltros)
				ValidaFiltrosOperador();
			
			logicaLicencias();
		}
		
		void DtpVigenciaLicAptoMedicoValueChanged(object sender, EventArgs e)
		{
			if(!banderaFiltros)
				ValidaFiltrosOperador();
			
			logicaLicencias();
		}
				
		void CmbCreditoInfoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbCreditoInfo.Text == "NO"){
				txtMontoInf.Enabled = false;
				txtMontoInf.Text = "";
			}else
				txtMontoInf.Enabled = true;
		}
		
		void LblImagenClick(object sender, EventArgs e)
		{			
			getParametros();
			new FormImagen(this).ShowDialog();
		}
				
		void TxtImagenPersonalKeyUp(object sender, KeyEventArgs e)
		{
			getParametros();
			if(e.KeyCode == Keys.Return)
				new FormImagen(this).ShowDialog();
		}
		
		void CmbTipoOperadorSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipoOperador.SelectedIndex > 0){
				cmbTramite.Enabled = true;
				pnAspectosIniciales.Enabled = true;
			}
			else{
				cmbTramite.Enabled = false;
				pnAspectosIniciales.Enabled = false;
			}
		}
				
		void LblIngresoClick(object sender, EventArgs e)
		{
			if(lblIngreso.Text == "Llamada Cancelada")
				new FormCancelaLlamada(this, id_usuario, Convert.ToInt64(dgControLlamadas[0, rowIndex].Value), dgControLlamadas[1,rowIndex].Value.ToString(), false).ShowDialog();
		}
		
		void TxtNumLicAptoMedicoTextChanged(object sender, EventArgs e)
		{
			logicaLicencias();
		}
		
		void TxtNumLicFederalTextChanged(object sender, EventArgs e)
		{
			logicaLicencias();
		}
		
		void TxtNumLicEstatalTextChanged(object sender, EventArgs e)
		{
			logicaLicencias();
		}
		
		void LblAliasDoubleClick(object sender, EventArgs e)
		{
			string datos = "*"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+"*";
			Clipboard.Clear();
			Clipboard.SetDataObject(datos);
		}
		
		void LblAliasSDoubleClick(object sender, EventArgs e)
		{
			try{				
				String datos = "*"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+"*";				
				String datos2 = txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text;				
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
				MessageBox.Show("Se generó mensaje para Whatsapp,\n"+datos2+",\nCopiarlo en el grupo pertienente.", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de Whatsapp: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}		
		
		void CmbTramiteSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTramite.Text.Equals("BOLSA DE TRABAJO")){
				cmbMotivoSinCita.Visible = true;
			}else{
				cmbMotivoSinCita.Visible = false;
				cmbMotivoSinCita.Text = "";
			}
		}
				
		void FormContratacionKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape){
				DialogResult result = MessageBox.Show("¿Desea cerrar el modulo de Control de selección?","Cerrar Modulo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
				if(result == DialogResult.OK)
					this.Close();
			}
		}
		
		void CmbMotivoSinCitaClick(object sender, EventArgs e)
		{
			new FormMotivoBT(this).ShowDialog();
		}
		
		void CmbMotivoSinCitaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Return)
				new FormMotivoBT(this).ShowDialog();
		}
		
		void TxtFuenteOperadorTextChanged(object sender, EventArgs e)
		{
			if(banderaModifica){
				if(txtFuenteOperador.Text == "EXTERNO")
					txtFuenteOperador.ResetBackColor();
				else if(connO.validaOperadorRecomendado(txtFuenteOperador.Text))
					txtFuenteOperador.BackColor = Color.LightGreen;
				else
					txtFuenteOperador.BackColor = Color.Red;
			}
		}
		#endregion
		
		#region METODOS
		private void obtenerCandidatoAI(bool tipoOperador){
			limpiaFiltrosOperador();
			banderaFiltros = true;
			bool bandera = false;
			string consulta = "", folio = "";
			errorProvider1.Clear();
			errorProvider2.Clear();
			
			cmbSexo.SelectedIndex = -1;
			cmbTatuajes.SelectedIndex = -1;
			cmbPiercing.SelectedIndex = -1;
			cmbCasa.SelectedIndex = 0;
			cmbEstadoS.SelectedIndex = -1;
			cmbCreditoInfo.SelectedIndex = -1;
			cmbTipoLicFederal.SelectedIndex = -1;
			cmbEstadoEstatal.SelectedIndex = -1;
			cmbEstadoFederal.SelectedIndex = -1;
			cmbTipoLicEstatal.SelectedIndex = -1;
			cmbTramite.SelectedIndex = -1;
			txtNumCelular.Text = "";
			
			lblAlias.Text = "Alias";
			lblAlias.ForeColor = Color.Blue;
			if(tipoOperador)
				cmbTipoOperador.SelectedIndex = 0;
				
			if(banderaModifica)
				ID_PREOPERADOR = connO.getIDCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"));		
			try{
				consulta ="SELECT * FROM PRE_OPERADOR WHERE ID = "+ID_PREOPERADOR;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					String id = conn.leer["ID"].ToString();
					folio = conn.leer["FOLIO"].ToString();
					lblFolio.Text = ((id.Length == 1)? "000"+id : ((id.Length == 2)? "00"+id : ((id.Length == 3)? "0"+id : id ) ) );
					txtNombre.Text = conn.leer["NOMBRE"].ToString();
					txtApellidoP.Text = conn.leer["APELLIDO_PAT"].ToString();
					txtApellidoM.Text = conn.leer["APELLIDO_MAT"].ToString();
					txtColonia.Text = conn.leer["COLONIA"].ToString();
					cmbZona.Text = conn.leer["ZONA"].ToString();
					cmbCasa.Text = conn.leer["TIPO_CASA"].ToString();
					cmbCreditoInfo.Text = conn.leer["INFONAVIT"].ToString();
					txtMontoInf.Text = conn.leer["INFONAVIT_MONTO"].ToString();
					dtpNacimiento.Value = Convert.ToDateTime(conn.leer["FECHA_NACIMIENTO"]);
					txtImagenPersonal.Text = conn.leer["IMAGEN_PERSONAL"].ToString();
					cmbSexo.Text = conn.leer["SEXO"].ToString();
					if(conn.leer["SEXO"] == null)
						cmbSexo.SelectedIndex = -1;
					cmbTatuajes.Text = conn.leer["TATUAJES"].ToString();
					cmbPiercing.Text = conn.leer["PIERCING"].ToString();			
					cmFuente.Text = conn.leer["FUENTE"].ToString();	
					
					
					if(cmFuente.Text.Equals("RECOMENDACION"))
						txtFuenteOperador.Text = conn.leer["DETALLE_FUENTE"].ToString();
					else if(cmFuente.Text.Equals("PERIODICO")){
						cmbFuentePeriodico.Text = conn.leer["DETALLE_FUENTE"].ToString();
						cmbFuentePeriodicoDia.Text = conn.leer["DIA"].ToString();
					}else if(cmFuente.Text.Equals("INTERNET"))
						cmbFuenteInternet.Text = conn.leer["DETALLE_FUENTE"].ToString();
					
					/*
					if(cmFuente.SelectedIndex == 0)
						txtFuenteOperador.Text = conn.leer["DETALLE_FUENTE"].ToString();
					else if(cmFuente.SelectedIndex == 1){
						cmbFuentePeriodico.Text = conn.leer["DETALLE_FUENTE"].ToString();
						cmbFuentePeriodicoDia.Text = conn.leer["DIA"].ToString();
					}else if(cmFuente.SelectedIndex == 2)
						cmbFuenteInternet.Text = conn.leer["DETALLE_FUENTE"].ToString();					
					*/
					
					txtDualA.Text = conn.leer["DUAL"].ToString();
					txtDirTraseraA.Text = conn.leer["DIR_TRASERA"].ToString();
					txtTransPersonalA.Text = conn.leer["TRANSP_PERSONAL"].ToString();
					txtDualM.Text = conn.leer["DUALM"].ToString();
					txtDirTraseraM.Text = conn.leer["DIR_TRASERAM"].ToString();
					txtTransPersonalM.Text = conn.leer["TRANSP_PERSONALM"].ToString();
					
					cmbTipoLicEstatal.Text = conn.leer["TIPO_ESTATAL"].ToString();
					cmbTipoLicFederal.Text = conn.leer["TIPO_FEDERAL"].ToString();
					cmbEstadoEstatal.Text = conn.leer["ESTADO_ESTATAL"].ToString();	
					cmbEstadoFederal.Text = conn.leer["ESTADO_FEDERAL"].ToString();	

					txtNumLicEstatal.Text = conn.leer["NUM_ESTATAL"].ToString();
					dtpVigenciaLicEstatal.Text = conn.leer["VIGENCIA_ESTATAL"].ToString();
					txtNumLicFederal.Text = conn.leer["NUM_FEDERAL"].ToString();
					dtpVigenciaLicFederal.Text = conn.leer["VIGENCIA_FEDERAL"].ToString();
					txtNumLicAptoMedico.Text = conn.leer["NUM_APTO_MEDICO"].ToString();
					dtpVigenciaLicAptoMedico.Text = conn.leer["VIGENCIA_APTO_MEDICO"].ToString();
					txtPesoS.Text = conn.leer["PESO"].ToString();
					txtAlturaS.Text = conn.leer["ALTURA"].ToString();
					
					cmbTramite.Text = conn.leer["TRAMITE"].ToString();					
					if(cmbTramite.Text.Equals("BOLSA DE TRABAJO") && conn.leer["BT"].ToString().Equals("SI") )
						cmbMotivoSinCita.Text = conn.leer["MOTIVO_BT"].ToString();
									
					if(tipoOperador)
						cmbTipoOperador.Text = conn.leer["TIPO"].ToString();
			
					if(conn.leer["IMAGEN"] != null){
						if(conn.leer["IMAGEN"].ToString().Length > 0){
							byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
				  			ms = new System.IO.MemoryStream(imageBuffer);
				  			ptbImagenAI.Image = System.Drawing.Image.FromStream(ms);
			    			imagen = true;
						}else{
							ptbImagenAI.Image = System.Drawing.Image.FromFile("Camara.png");	  			
			    			imagen = false;
						}						
					}else{
						ptbImagenAI.Image = System.Drawing.Image.FromFile("Camara.png");	  			
		    			imagen = false;
					}		  			
					bandera = true;					
				}
				conn.conexion.Close();

				if(!banderaModifica && cmbTipoOperador.SelectedIndex < 1){
					cmbTipoOperador.Enabled = true;
					pnAspectosIniciales.Enabled = false;
				}
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos del candidato): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				if(conn.conexion != null)
				 conn.conexion.Close();				
			}
			if(bandera){
				try{
					Operador.Dato.Telefonos telefono = null;
					if(ListarTelefonos != null)
						ListarTelefonos = null;
					ListarTelefonos = new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Telefonos>();						
								
					consulta = "SELECT * FROM TELEFONOS_PRE_OPERADOR WHERE ESTATUS = 'Activo' AND  ID_PREOPERADOR = "+ID_PREOPERADOR+" and FOLIO = '"+folio+"' order by ID ASC";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read()){
						telefono = new Operador.Dato.Telefonos();
						telefono.id = conn.leer["ID"].ToString();
						telefono.tipo = conn.leer["TIPO"].ToString();
						telefono.numero = conn.leer["NUMERO"].ToString();
						telefono.relacion = conn.leer["RELACION"].ToString();
						telefono.nombre = conn.leer["DESCRIPCION"].ToString();		
						telefono.estatus = conn.leer["ESTATUS"].ToString();				
						ListarTelefonos.Add(telefono);
						
						if(conn.leer["RELACION"].ToString() == "PROPIO" && conn.leer["TIPO"].ToString() == "CELULAR"){
							txtNumCelular.Text = conn.leer["NUMERO"].ToString();
							lblRelacionContacto.Text = "";
						}
						
						if(txtNumCelular.Text.Length == 0){
							txtNumCelular.Text = conn.leer["NUMERO"].ToString();
							lblRelacionContacto.Text = conn.leer["RELACION"].ToString();
						}
					}					
					conn.conexion.Close();	
				}catch(Exception ex){
					MessageBox.Show("Error al obtener sus numeros de teléfonos (error al llenar la tabla de contacto): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
					conn.conexion.Close();				
				}
				try{
					consulta = "SELECT * FROM PRE_OPERADOR_IMAGEN WHERE ID_PREOPERADOR = "+ID_PREOPERADOR+" and FOLIO = '"+folio+"'";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						peinado = (( conn.leer["PEINADO"] != null)? Convert.ToInt16(conn.leer["PEINADO"]) : 0);
						pelo = (( conn.leer["PELO_CORTO"] != null)? Convert.ToInt16(conn.leer["PELO_CORTO"]) : 0);
						manosCara = (( conn.leer["MANOS_LIMPIAS"] != null)? Convert.ToInt16(conn.leer["MANOS_LIMPIAS"]) : 0);
						rasurado = (( conn.leer["RASURADO"] != null)? Convert.ToInt16(conn.leer["RASURADO"]) : 0);
						ropa = (( conn.leer["ROPA_LIMPIA"] != null)? Convert.ToInt16(conn.leer["ROPA_LIMPIA"]) : 0);
						calzado = (( conn.leer["LIMPIEZA_CALZADO"] != null)? Convert.ToInt16(conn.leer["LIMPIEZA_CALZADO"]) : 0);
						vestimenta = (( conn.leer["VETIMENTA"] != null)? Convert.ToInt16(conn.leer["VETIMENTA"]) : 0);
						pantalon = (( conn.leer["PANTALON"] != null)? Convert.ToInt16(conn.leer["PANTALON"]) : 0);
						zapato = (( conn.leer["ZAPATO"] != null)? Convert.ToInt16(conn.leer["ZAPATO"]) : 0);
						presentacionCamisa1 = (( conn.leer["PRESENTACIONCAMISA1"] != null)? Convert.ToInt16(conn.leer["PRESENTACIONCAMISA1"]) : 0);
						presentacionCamisa2 = (( conn.leer["PRESENTACIONCAMISA2"] != null)? Convert.ToInt16(conn.leer["PRESENTACIONCAMISA2"]) : 0);
						presentacionCamisa3 = (( conn.leer["PRESENTACIONCAMISA3"] != null)? Convert.ToInt16(conn.leer["PRESENTACIONCAMISA3"]) : 0);
						presentacionPantalon1 = (( conn.leer["PRESENTACIONPANTALON1"] != null)? Convert.ToInt16(conn.leer["PRESENTACIONPANTALON1"]) : 0);						
					}else{
						peinado = 0;
						pelo = 0;
						manosCara = 0;
						rasurado = 0;
						ropa = 0;
						calzado = 0;
						vestimenta = 0;	
						pantalon = 0;
						zapato = 0;	
						presentacionCamisa1 = 0;
						presentacionCamisa2 = 0;
						presentacionCamisa3 = 0;
						presentacionPantalon1 = 0;
					}
					conn.conexion.Close();	
				}catch(Exception){
					conn.conexion.Close();				
				}
				try{
					licAjuste = null;
					consulta = "SELECT * FROM PRE_OPERADOR_DESCUENTOS WHERE ID_PREOPERADOR = "+ID_PREOPERADOR+" and FOLIO = '"+folio+"'";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						licAjuste = new Dato.LicenciasAjuste();
						licAjuste.id = conn.leer["ID"].ToString();	
						licAjuste.estatal = conn.leer["ESTATAL_DESC"].ToString();
						licAjuste.estatal_vence = conn.leer["ESTATAL_VENCE"].ToString();
						licAjuste.federal = conn.leer["FEDERAL_DESC"].ToString();	
						licAjuste.federal_vence = conn.leer["FEDERAL_VENCE"].ToString();
						licAjuste.medico = conn.leer["MEDICO_DESC"].ToString();
						licAjuste.medico_vence = conn.leer["MEDICO_VENCE"].ToString();
						licAjuste.observaciones = conn.leer["OBSERVACIONES"].ToString();
					}
					conn.conexion.Close();	
				}catch(Exception ex){
					MessageBox.Show("Error al obtener DESCUENTOS por licencias (error al llenar la tabla de contacto): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
					conn.conexion.Close();				
				}
			}
			banderaFiltros = false;
			ValidaFiltrosOperador();
			
			if(banderaModifica){
				if(txtFuenteOperador.Text == "EXTERNO")
					txtFuenteOperador.ResetBackColor();
				else if(connO.validaOperadorRecomendado(txtFuenteOperador.Text))
					txtFuenteOperador.BackColor = Color.LightGreen;
				else
					txtFuenteOperador.BackColor = Color.Red;
			}
		}
		
  		public bool InsertaRegistro(string tipo){
			string detalleFuente = "";
			
			if(cmFuente.Text.Equals("RECOMENDACION"))
				detalleFuente = txtFuenteOperador.Text;
			else if(cmFuente.Text.Equals("PERIODICO"))	
				detalleFuente = cmbFuentePeriodico.Text;
			else if(cmFuente.Text.Equals("INTERNET"))
				detalleFuente = cmbFuenteInternet.Text;
			else						
				detalleFuente = "N/A";
			
			/*
			if(cmFuente.SelectedIndex == 0)
				detalleFuente = txtFuenteOperador.Text;
			else if(cmFuente.SelectedIndex == 1)	
				detalleFuente = cmbFuentePeriodico.Text;
			else if(cmFuente.SelectedIndex == 2)
				detalleFuente = cmbFuenteInternet.Text;
			else						
				detalleFuente = "N/A";
			*/
			
			if(connO.insertarCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtColonia.Text, cmbZona.Text, cmbCasa.Text, cmbCreditoInfo.Text, ((cmbCreditoInfo.SelectedIndex == -1)? "" : txtMontoInf.Text ), 
			                           dtpNacimiento.Value.ToString("yyyy-MM-dd"), txtImagenPersonal.Text, cmbSexo.Text, cmbTatuajes.Text, cmbPiercing.Text, cmFuente.Text, detalleFuente, ((cmFuente.Text.Equals("PERIODICO"))? cmbFuentePeriodicoDia.Text: "0" ),
									   ListarTelefonos, txtDualA.Text, txtDualM.Text, txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, txtTransPersonalM.Text, cmbTipoLicEstatal.Text, cmbEstadoEstatal.Text, txtNumLicEstatal.Text, 
									   dtpVigenciaLicEstatal.Value.ToString("yyyy-MM-dd"), cmbTipoLicFederal.Text, cmbEstadoFederal.Text, txtNumLicFederal.Text, dtpVigenciaLicFederal.Value.ToString("yyyy-MM-dd"), txtNumLicAptoMedico.Text, 
									   dtpVigenciaLicAptoMedico.Value.ToString("yyyy-MM-dd"), cmbTramite.Text, ((ajustesLic)? "SI" : "NO" ), licAjuste, id_usuario, ptbImagenAI, imagen, "INICIALES", tipo, cmbTipoOperador.Text, peinado, pelo, manosCara,
									   rasurado, ropa, calzado, vestimenta, pantalon, zapato, presentacionCamisa1, presentacionCamisa2, presentacionCamisa3, presentacionPantalon1, txtAlturaS.Text, txtPesoS.Text, ((cmbTramite.Text.Equals("BOLSA DE TRABAJO"))? "SI" : "NO"), 
									   ((cmbTramite.Text.Equals("BOLSA DE TRABAJO"))? cmbMotivoSinCita.Text : "") ))
				return true;
			else
				return false;
		}
		
		public bool ModificaRegistro(string ESTATUS, string FLUJO, int banderaFolio){
			string detalleFuente = "";
						
			if(cmFuente.Text.Equals("RECOMENDACION"))
				detalleFuente = txtFuenteOperador.Text;
			else if(cmFuente.Text.Equals("PERIODICO"))	
				detalleFuente = cmbFuentePeriodico.Text;
			else if(cmFuente.Text.Equals("INTERNET"))
				detalleFuente = cmbFuenteInternet.Text;
			else						
				detalleFuente = "N/A";
			/*
			if(cmFuente.SelectedIndex == 0)
				detalleFuente = txtFuenteOperador.Text;
			else if(cmFuente.SelectedIndex == 1)	
				detalleFuente = cmbFuentePeriodico.Text;
			else if(cmFuente.SelectedIndex == 2)
				detalleFuente = cmbFuenteInternet.Text;
			else						
				detalleFuente = "N/A";*/
				
			if(connO.modificaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtColonia.Text, cmbZona.Text, cmbCasa.Text, cmbCreditoInfo.Text, ((cmbCreditoInfo.SelectedIndex == -1)? "" : txtMontoInf.Text ), 
			                           dtpNacimiento.Value.ToString("yyyy-MM-dd"), txtImagenPersonal.Text, cmbSexo.Text, cmbTatuajes.Text, cmbPiercing.Text, cmFuente.Text, detalleFuente, ((cmFuente.Text.Equals("PERIODICO"))? cmbFuentePeriodicoDia.Text: "0" ),
									   ListarTelefonos, txtDualA.Text, txtDualM.Text, txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, txtTransPersonalM.Text, cmbTipoLicEstatal.Text, cmbEstadoEstatal.Text, txtNumLicEstatal.Text, 
									   dtpVigenciaLicEstatal.Value.ToString("yyyy-MM-dd"), cmbTipoLicFederal.Text, cmbEstadoFederal.Text, txtNumLicFederal.Text, dtpVigenciaLicFederal.Value.ToString("yyyy-MM-dd"), txtNumLicAptoMedico.Text, 
									   dtpVigenciaLicAptoMedico.Value.ToString("yyyy-MM-dd"), cmbTramite.Text, ((ajustesLic)? "SI" : "NO" ), licAjuste, id_usuario, ptbImagenAI, imagen, ESTATUS, cmbTipoOperador.Text, FLUJO, banderaFolio, ID_PREOPERADOR, peinado, pelo, manosCara,
			                           rasurado, ropa, calzado, vestimenta, pantalon, zapato, presentacionCamisa1, presentacionCamisa2, presentacionCamisa3, presentacionPantalon1, txtAlturaS.Text, txtPesoS.Text, ((cmbTramite.Text.Equals("BOLSA DE TRABAJO"))? "SI" : "NO"), 
									   ((cmbTramite.Text.Equals("BOLSA DE TRABAJO"))? cmbMotivoSinCita.Text : "") ))
				return true;
			else
				return false;
		}
		
		public void limpiarCamposAI(){
			ID_PREOPERADOR = 0;
			banderaModifica = true;			
			lblIngreso.Text = "Nuevo Ingreso";
			lblIngreso.ForeColor = Color.Black;
			lblFolio.Text = "0001";
			lblAlias.Text = "Alias";
			lblAlias.ForeColor = Color.Blue;
			txtNombre.Text = "";
			txtApellidoP.Text = "";
			txtApellidoM.Text = "";
			cmbZona.SelectedIndex = -1;
			cmFuente.SelectedIndex = -1;
			txtFuenteOperador.Text = "EXTERNO";
			cmbFuentePeriodico.SelectedIndex = -1;
			cmbFuenteInternet.SelectedIndex = -1;
			cmbFuentePeriodicoDia.SelectedIndex = -1;
			ptbImagenAI.Image = System.Drawing.Image.FromFile("Camara.png");			
			dtpNacimiento.Value = DateTime.Now;
			cmbTatuajes.SelectedIndex = -1;
			cmbPiercing.SelectedIndex = -1;
			txtImagenPersonal.Text = "";
			cmbSexo.SelectedIndex = -1;
			txtPesoS.Text = "";
			txtAlturaS.Text = "";
			
			txtColonia.Text = "";
			cmbCasa.SelectedIndex = 0;
			cmbCreditoInfo.SelectedIndex = -1;
			txtMontoInf.Text = "";						
			
			txtNumCelular.Text = "";
						
			txtDualA.Text = "0";
			txtDualM.Text = "0";
			txtDirTraseraA.Text = "0"; 
			txtDirTraseraM.Text = "0"; 
			txtTransPersonalA.Text = "0";
			txtTransPersonalM.Text = "0";
			
			cmbTipoLicEstatal.SelectedIndex = -1;
			cmbEstadoEstatal.SelectedIndex = -1;
			txtNumLicEstatal.Text = ""; 
			dtpVigenciaLicEstatal.Value = DateTime.Now;
			cmbTipoLicFederal.SelectedIndex = -1;
			cmbEstadoFederal.SelectedIndex = -1;
			txtNumLicFederal.Text = ""; 
			dtpVigenciaLicFederal.Value = DateTime.Now;
			txtNumLicAptoMedico.Text = "";
			dtpVigenciaLicAptoMedico.Value = DateTime.Now;
			
			lblEdad.Visible = false;
					
			cmbTipoOperador.SelectedIndex = 0;	
			cmbTipoOperador.Focus();lblAlias.Text = "Alias";
			cmbTipoOperador.Enabled = true;
			pnFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			lblIngreso.ForeColor = Color.Black;
			
			peinado = 0;
			pelo = 0;
			manosCara = 0;
			rasurado = 0;
			ropa = 0;
			calzado = 0;
			pantalon = 0;
			zapato = 0;	
			presentacionCamisa1 = 0;
			presentacionCamisa2 = 0;
			presentacionCamisa3 = 0;
			presentacionPantalon1 = 0;
			
			errorProvider1.Clear();
			dgControLlamadas.ClearSelection();
			dgControlSolicitudes.ClearSelection();
			
			licAjuste = null;
			ListarTelefonos = null;
			
			btnLicenciasAI.Image = System.Drawing.Image.FromFile("btnGris24.png");
			
			btnAgregarContacto.Enabled = true;
			btnGuardar.Enabled = true;
			btnRegistrar.Enabled = true;			
			btnRegistrar.Visible = false;
			btnGuardar.Visible = true;				
			btnLimpiarAI.Enabled = true;
			btnWhatsappAI.Enabled = true;
			btnImprimirAI.Enabled = true;
			btnLicenciasAI.Enabled = true;
			tpSolicitud.Enabled = false;
			
			cmbTramite.SelectedIndex = -1;
			
			limpiarCamposS();
		}
						
		private void validaCandidato(){
			if(banderaModifica){
				int bandera = connO.getValidaOperador(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"));
				pnFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
				lblIngreso.ForeColor = Color.Black;	
				btnAgregarContacto.Enabled = true;
						
				btnRegistrar.Visible = false;
				btnGuardar.Visible = true;
				btnGuardar.Enabled = true;
				btnLimpiarAI.Enabled = true;
				btnWhatsappAI.Enabled = true;
				btnImprimirAI.Enabled = true;
				btnLicenciasAI.Enabled = true;		
				
				if(bandera == 0){
					int banderaPre = connO.getValidaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"));
					if(banderaPre == 0){
						lblIngreso.Text = "Nuevo Ingreso";
						cmbTipoOperador.Enabled = true;
					}else if(banderaPre == 1){
						lblIngreso.Text = "Candidato Activo";
						lblIngreso.ForeColor = Color.Blue;
						btnGuardar.Visible = true;
						btnRegistrar.Visible = false;
					}else if(banderaPre == 2){
						lblIngreso.Text = "Candidato Rechazado";
						lblIngreso.ForeColor = Color.White;
						pnFondo.BackColor = Color.Red;
						btnGuardar.Visible = false;
						btnRegistrar.Visible = true;
						btnLimpiarAI.Enabled = false;
						btnWhatsappAI.Enabled = false;
						btnImprimirAI.Enabled = false;
						btnLicenciasAI.Enabled = false;
					}else if(banderaPre == 3){
						lblIngreso.Text = "Candidato por Contratar";
						lblIngreso.ForeColor = Color.Blue;
						btnGuardar.Visible = true;
						btnRegistrar.Visible = false;
					}else if(banderaPre == 4){
						lblIngreso.Text = "Llamada Cancelada";
						lblIngreso.ForeColor = Color.White;
						pnFondo.BackColor = Color.OrangeRed;
					}else if(banderaPre == 5 || banderaPre == 6){
						lblIngreso.Text = "Bolsa de Trabajo";
					}
				}else if (bandera == 1){
					int banderaPre = connO.getValidaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"));
					if(banderaPre == 0){
						lblIngreso.Text = "Reingreso Sin Control";
						cmbTipoOperador.Enabled = true;
						cmbTipoOperador.SelectedIndex = 2;
					}else if(banderaPre == 1){
						lblIngreso.Text = "Reingreso Candidato Activo";
						lblIngreso.ForeColor = Color.Blue;
						btnGuardar.Visible = true;
						cmbTipoOperador.SelectedIndex = 2;
					}else if(banderaPre == 2){
						lblIngreso.Text = "Reingreso Candidato Rechazado";
						lblIngreso.ForeColor = Color.White;
						pnFondo.BackColor = Color.Red;
						btnGuardar.Visible = false;
						btnRegistrar.Visible = true;
						btnLimpiarAI.Enabled = false;
						btnWhatsappAI.Enabled = false;
						btnImprimirAI.Enabled = false;
						btnLicenciasAI.Enabled = false;
						cmbTipoOperador.SelectedIndex = 2;
					}else if(banderaPre == 3){
						lblIngreso.Text = "Reingreso";						
						lblIngreso.ForeColor = Color.Blue;
						btnGuardar.Visible = true;
						btnRegistrar.Visible = false;
						cmbTipoOperador.SelectedIndex = 2;
					}else if(banderaPre == 4){
						lblIngreso.Text = "Reingreso Llamada Cancelada";
						lblIngreso.ForeColor = Color.White;
						pnFondo.BackColor = Color.OrangeRed;
						cmbTipoOperador.SelectedIndex = 2;
					}else if(banderaPre == 5){
						lblIngreso.Text = "Reingreso Bolsa de Trabajo";
						cmbTipoOperador.SelectedIndex = 2;
					}
				}else if (bandera == 2){
					lblIngreso.Text = "Operador Activo";
					lblIngreso.ForeColor = Color.Blue;
					if(ID_PREOPERADOR == 0)
						cmbTipoOperador.Enabled = false;
				}
			}
		}
				
		private bool ValidaInsertar(){
			bool respuesta = true;
			
			errorProvider1.Clear();
			if(txtNombre.Text.Length == 0){
				errorProvider1.SetError(txtNombre, "Ingresa el nombre del solicitante");
				txtNombre.Focus();
				respuesta = false;
			}
			if(txtApellidoP.Text.Length == 0){
				errorProvider1.SetError(txtApellidoP, "Ingresa el apellido paterno del solicitante");
				txtApellidoP.Focus();
				respuesta = false;
			}
			if(txtColonia.Text.Length == 0){
				errorProvider1.SetError(txtColonia, "Ingresa el nombre de la colonia del solicitante");
				txtColonia.Focus();
				respuesta = false;
			}
			if(cmbZona.SelectedIndex == -1){
				errorProvider1.SetError(cmbZona, "Ingresa la zona del solicitante");
				cmbZona.Focus();
				respuesta = false;
			}
			if(cmbCasa.SelectedIndex == -1){
				errorProvider1.SetError(cmbCasa, "Ingresa el tipo de la casa del solicitante");
				cmbCasa.Focus();
				respuesta = false;
			}
			if(cmbCreditoInfo.SelectedIndex == -1){
				errorProvider1.SetError(cmbCreditoInfo, "Ingresa si el candidato cuenta con credito infonavit");
				cmbCreditoInfo.Focus();
				respuesta = false;
			}else{
				if(cmbCreditoInfo.Text.Equals("SI")){
					//if(txtMontoInf.Text == 0)
				}
			}
			if(dtpNacimiento.Value.ToString("yyyy-MM-dd") == DateTime.Now.ToString("yyyy-MM-dd")){
				errorProvider1.SetError(dtpNacimiento, "Ingresa una fecha de nacimiento valida del solicitante");
				dtpNacimiento.Focus();
				respuesta = false;
			}
			if(cmbSexo.SelectedIndex == -1){
				errorProvider1.SetError(cmbSexo, "Ingresa el sexo del solicitante");
				cmbSexo.Focus();
				respuesta = false;
			}
			if(cmbTatuajes.SelectedIndex == -1){
				errorProvider1.SetError(cmbTatuajes, "Ingresa si tiene tatuajes el solicitante");
				cmbTatuajes.Focus();
				respuesta = false;
			}
			if(cmbPiercing.SelectedIndex == -1){
				errorProvider1.SetError(cmbPiercing, "Ingresa si tiene piercing el solicitante");
				cmbPiercing.Focus();
				respuesta = false;
			}
			if(txtNumCelular.Text.Length == 0){
				errorProvider1.SetError(txtNumCelular, "Ingresa algun número de teléfono del solicitante");
				txtNumCelular.Focus();
				respuesta = false;
			}			
			if(cmFuente.SelectedIndex == -1){
				errorProvider1.SetError(cmFuente, "Ingresa la fuente por la cual el solicitante se entero del trabajo");
				cmFuente.Focus();
				respuesta = false;
			}
			if(cmFuente.Text.Equals("RECOMENDACION")){
				if(txtFuenteOperador.Text.Length == 0){
					errorProvider1.SetError(txtFuenteOperador, "Ingresa el nombre del operador");
					txtFuenteOperador.Focus();
					respuesta = false;
				}else{
					if(txtFuenteOperador.BackColor == Color.Red){
						errorProvider1.SetError(txtFuenteOperador, "Ingresa un operador valido");
						txtFuenteOperador.Focus();
						respuesta = false;
					}
				}
			}
			/*
			 *
			if(cmFuente.SelectedIndex == 0){
				if(txtFuenteOperador.Text.Length == 0){
					errorProvider1.SetError(txtFuenteOperador, "Ingresa el nombre del operador");
					txtFuenteOperador.Focus();
					respuesta = false;
				}
			}
			  * */
			 if(cmFuente.Text.Equals("PERIODICO")){
				if(cmbFuentePeriodico.SelectedIndex == -1){
					errorProvider1.SetError(cmbFuentePeriodico, "Ingresa el nombre del periódico por el cual el solicitante se enteró del trabajo");
					cmbFuentePeriodico.Focus();
					respuesta = false;
				}
				if(cmbFuentePeriodicoDia.SelectedIndex == -1){
					errorProvider1.SetError(cmbFuentePeriodicoDia, "Ingresa el día que se vio el anuncio en el periódico");
					cmbFuentePeriodicoDia.Focus();
					respuesta = false;
				}
			}
			 
			 /*
			  
			if(cmFuente.SelectedIndex == 1){
				if(cmbFuentePeriodico.SelectedIndex == -1){
					errorProvider1.SetError(cmbFuentePeriodico, "Ingresa el nombre del periódico por el cual el solicitante se enteró del trabajo");
					cmbFuentePeriodico.Focus();
					respuesta = false;
				}
				if(cmbFuentePeriodicoDia.SelectedIndex == -1){
					errorProvider1.SetError(cmbFuentePeriodicoDia, "Ingresa el día que se vio el anuncio en el periódico");
					cmbFuentePeriodicoDia.Focus();
					respuesta = false;
				}
			} 
			  */
			 if(cmFuente.Text.Equals("INTERNET")){
				if(cmbFuenteInternet.SelectedIndex == -1){
					errorProvider1.SetError(cmbFuenteInternet, "Ingresa en que página de internet se solicitante se enteró del trabajo");
					cmbFuenteInternet.Focus();
					respuesta = false;
				}
			}
			 
			 /*
			  
			if(cmFuente.SelectedIndex == 2){
				if(cmbFuenteInternet.SelectedIndex == -1){
					errorProvider1.SetError(cmbFuenteInternet, "Ingresa en que página de internet se solicitante se enteró del trabajo");
					cmbFuenteInternet.Focus();
					respuesta = false;
				}
			} 
			  */
			if(txtImagenPersonal.Text.Length == 0){
				errorProvider1.SetError(txtImagenPersonal, "Ingresa un porcentaje que le darías al candidato como imagen personal");
				txtImagenPersonal.Focus();
				respuesta = false;
			}
			
			if(txtDualA.Text.Length == 0 && txtDualM.Text.Length == 0){
				errorProvider1.SetError(txtDualM, "Ingresa la experiencia que el candidato tiene en DUAL");
				txtDualA.Focus();
				respuesta = false;
			}
			if(txtDirTraseraA.Text.Length == 0  && txtDirTraseraM.Text.Length == 0){
				errorProvider1.SetError(txtDirTraseraM, "Ingresa la experiencia que el candidato tiene en DIRECCIÓN TRASERA");
				txtDirTraseraA.Focus();
				respuesta = false;
			}
			if(txtTransPersonalA.Text.Length == 0  && txtTransPersonalM.Text.Length == 0){
				errorProvider1.SetError(txtTransPersonalM, "Ingresa la experiencia que el candidato tiene en TRANSPORTE DE PERSONAL");
				txtTransPersonalA.Focus();
				respuesta = false;
			}
			if(cmbTramite.SelectedIndex == -1){
				errorProvider1.SetError(cmbTramite, "Ingresa el tipo de tramite del solicitante");
				cmbTramite.Focus();
				respuesta = false;
			}
			if(ajustesLic){
				if(licAjuste == null){					
					errorProvider1.SetError(btnLicenciasAI, "Ingresa el ajuste de la licencia");
					btnLicenciasAI.Focus();
					respuesta = false;
				}
			}						
			if(txtPesoS.Text.Length == 0){
				errorProvider1.SetError(txtPesoS, "Ingresa el peso del candidato");
				txtPesoS.Focus();
				respuesta = false;
			}
			if(txtAlturaS.Text.Length == 0){
				errorProvider1.SetError(txtAlturaS, "Ingresa la altura del candidato");
				txtAlturaS.Focus();
				respuesta = false;
			}
			
			return respuesta;
		}		
		
		private void ImprimeAutorizacion(){			
			DialogResult rs = MessageBox.Show(@"¿Deseas Imprimir la autorización para la contratación? ", "Impresión del Autorización de empleo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (DialogResult.Yes==rs){				
				string detalleFuente = "";
								
				if(cmFuente.Text.Equals("RECOMENDACION"))
					detalleFuente = txtFuenteOperador.Text;
				else if(cmFuente.Text.Equals("PERIODICO"))	
					detalleFuente = cmbFuentePeriodico.Text;
				else if(cmFuente.Text.Equals("INTERNET"))
					detalleFuente = cmbFuenteInternet.Text;
				else						
					detalleFuente = "N/A";
			/*
				if(cmFuente.SelectedIndex == 0)
					detalleFuente = txtFuenteOperador.Text;
				else if(cmFuente.SelectedIndex == 1)	
					detalleFuente = cmbFuentePeriodico.Text;
				else if(cmFuente.SelectedIndex == 2)
					detalleFuente = cmbFuenteInternet.Text;
				else						
					detalleFuente = "N/A";*/
			
				try{
					string newPath = System.IO.Path.Combine(activeDir, "Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Autorizaciones");  
					System.IO.Directory.CreateDirectory(newPath);				
					Document doc = new Document(PageSize.LETTER, 20, 20 ,10, 10);
					FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Autorizaciones\"+lblAlias.Text+" Autorización "
					                                 +txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+" Folio "+lblFolio.Text+".pdf",
					                                 FileMode.OpenOrCreate,
					                                 FileAccess.ReadWrite,
					                                 FileShare.ReadWrite);
					PdfWriter writer = PdfWriter.GetInstance(doc, file);
					doc.Open();
					FormatoPdf.FormatoAutorizacionCandidato(doc, writer, ms, ptbImagenAI, lblFolio.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, lblEdad.Text, cmbSexo.Text, txtImagenPersonal.Text,
					                                        cmbTipoOperador.Text, cmbZona.Text, ListarTelefonos, cmbTatuajes.Text, txtColonia.Text, cmbCreditoInfo.Text, txtMontoInf.Text, cmbPiercing.Text,
					                                        cmbTipoLicEstatal.Text, cmbEstadoEstatal.Text, txtNumLicEstatal.Text, ((cmbTipoLicEstatal.SelectedIndex > 0)? dtpVigenciaLicEstatal.Value.ToString("dd/MM/yyyy") : "N/A"), 
					                                        cmbTipoLicFederal.Text, cmbEstadoFederal.Text, txtNumLicFederal.Text, ((cmbTipoLicFederal.SelectedIndex > 0)? dtpVigenciaLicFederal.Value.ToString("dd/MM/yyyy") : "N/A"),
						           							txtNumLicAptoMedico.Text, ((txtNumLicAptoMedico.Text.Length > 0)? dtpVigenciaLicAptoMedico.Value.ToString("dd/MM/yyyy") : "N/A"), txtDualA.Text, txtDualM.Text,
						           							txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, txtTransPersonalM.Text, cmbTramite.Text, cmFuente.Text, detalleFuente, cmbFuentePeriodicoDia.Text,
						           							ajustesLic, licAjuste);
					doc.Close();
					Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Autorizaciones\"+lblAlias.Text+" Autorización "
					              +txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+" Folio "+lblFolio.Text+".pdf");
				}catch (Exception ex){
					MessageBox.Show(ex.Message);
				}
			}
		}
				
		private void Edad(){
			if(dtpNacimiento.Value < DateTime.Now.AddDays(-1)){
				int edad = (DateTime.Today.AddTicks(-dtpNacimiento.Value.Ticks).Year - 1);
				
				if(edad > 0){
					lblEdad.Text = edad.ToString();
					lblEdad.Visible = true;
					if(parametros != null)
						lblEdad.ForeColor = ((edad < Convert.ToInt16(parametros.edadMin) || edad > Convert.ToInt16(parametros.edadMax) )? Color.Red: Color.Black);
				}else{
					lblEdad.Visible = false;
				}
			}	
		}		
		
		public void limpiaFiltrosOperador(){	
			errorProvider2.Clear();
			lblTatuajes.ResetForeColor();
			lblPiercing.ResetForeColor();
			txtDualA.ResetForeColor();
			txtDirTraseraA.ResetForeColor();
			txtTransPersonalA.ResetForeColor();
			lblTipoEstatal.ResetForeColor();
			lblTipoFederal.ResetForeColor();
		}
		
		private bool ValidaFiltrosOperador(){
			errorProvider2.Clear();
			bool respuesta = true;
			getParametros();
			
			if(txtImagenPersonal.Text.Length > 0){
				if( Convert.ToInt32(txtImagenPersonal.Text) < Convert.ToInt32(parametros.imagen)){
	        		txtImagenPersonal.ForeColor = Color.Red;
						respuesta = false;	
				}
	        	else
					txtImagenPersonal.ResetForeColor();
			}
			if(cmbTatuajes.SelectedIndex > -1){
				if(parametros.tatuajes != cmbTatuajes.Text){
					lblTatuajes.ForeColor = Color.Red;
					respuesta = false;
				}
				else
					lblTatuajes.ForeColor = Color.Black;					
			}
			if(cmbPiercing.SelectedIndex > -1){
				if(parametros.percing != cmbPiercing.Text){
					lblPiercing.ForeColor = Color.Red;
					respuesta = false;
				}
				else
					lblPiercing.ForeColor = Color.Black;					
			}
			if(txtMontoInf.Text.Length > 0){
				if(Convert.ToDouble(txtMontoInf.Text) > Convert.ToDouble(parametros.infonavit)){
					txtMontoInf.ForeColor = Color.Red;
					respuesta = false;
				}
				else
					txtMontoInf.ResetForeColor();
			}
			if(txtDualA.Text.Length > 0){
				if(Convert.ToInt16(txtDualA.Text) < Convert.ToInt16(parametros.expDual)){
					txtDualA.ForeColor = Color.Red;
					respuesta = false;
				}
				else
					txtDualA.ResetForeColor();
			}
			if(txtDirTraseraA.Text.Length > 0){
				if(Convert.ToInt16(txtDirTraseraA.Text) < Convert.ToInt16(parametros.expDirTrasera)){
					txtDirTraseraA.ForeColor = Color.Red;
					respuesta = false;
				}
				else
					txtDirTraseraA.ResetForeColor();
			}
			if(txtTransPersonalA.Text.Length > 0){
				if(Convert.ToInt16(txtTransPersonalA.Text) < Convert.ToInt16(parametros.expTransPersonal)){
					txtTransPersonalA.ForeColor = Color.Red;
					respuesta = false;
				}
				else
					txtTransPersonalA.ResetForeColor();
			}
			if(cmbTipoLicEstatal.SelectedIndex > -1){
				if(parametros.licEstatal != "TODAS"){
					if(cmbTipoLicEstatal.Text != parametros.licEstatal){
						lblTipoEstatal.ForeColor = Color.Red;
						respuesta = false;
					}
					else
						lblTipoEstatal.ForeColor = Color.Black;
				}
			}
			if(cmbTipoLicFederal.SelectedIndex > -1){
				if(parametros.licFederal != "TODAS"){
					if(cmbTipoLicFederal.Text != parametros.licFederal){
						lblTipoFederal.ForeColor = Color.Red;
						respuesta = false;
					}
					else
						lblTipoFederal.ForeColor = Color.Black;	
				}
			}
			if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigEstatal)) >= dtpVigenciaLicEstatal.Value && cmbTipoLicEstatal.SelectedIndex > 0){
				errorProvider2.SetError(dtpVigenciaLicEstatal, "La Vigencia no cumple con la mínima necesaria");
				respuesta = false;
			}			
			if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigFederal)) >= dtpVigenciaLicFederal.Value && cmbTipoLicFederal.SelectedIndex > 0){
				errorProvider2.SetError(dtpVigenciaLicFederal, "La Vigencia no cumple con la mínima necesaria");
				respuesta = false;
			}
			if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigAptoMedico)) >= dtpVigenciaLicAptoMedico.Value && txtNumLicAptoMedico.Text.Length > 0){
				errorProvider2.SetError(dtpVigenciaLicAptoMedico, "La Vigencia no cumple con la mínima necesaria");
				respuesta = false;
			}
			return respuesta;
		}	
		
		private void FiltrosFuente(){
			txtFuenteOperador.Text = "EXTERNO";
			cmbFuenteInternet.SelectedIndex = -1;
			cmbFuentePeriodico.SelectedIndex = -1;
			cmbFuentePeriodicoDia.SelectedIndex = -1;
			
			if(cmFuente.Text.Equals("RECOMENDACION")){
				txtFuenteOperador.Visible = true;
				cmbFuenteInternet.Visible = false;
				cmbFuentePeriodico.Visible = false;
				cmbFuentePeriodicoDia.Visible = false;
				lblFuenteNA.Visible = false;
			}else if(cmFuente.Text.Equals("PERIODICO")){
				txtFuenteOperador.Visible = false;
				cmbFuenteInternet.Visible = false;
				cmbFuentePeriodico.Visible = true;
				cmbFuentePeriodicoDia.Visible = true;
				lblFuenteNA.Visible = false;
			}else if(cmFuente.Text.Equals("INTERNET")){
				txtFuenteOperador.Visible = false;
				cmbFuenteInternet.Visible = true;
				cmbFuentePeriodico.Visible = false;
				cmbFuentePeriodicoDia.Visible = false;
				lblFuenteNA.Visible = false;
			}else{							
				txtFuenteOperador.Visible = false;
				cmbFuenteInternet.Visible = false;
				cmbFuentePeriodico.Visible = false;
				cmbFuentePeriodicoDia.Visible = false;
				lblFuenteNA.Visible = true;
			}

			/*
			if(cmFuente.SelectedIndex == 0){
				txtFuenteOperador.Visible = true;
				cmbFuenteInternet.Visible = false;
				cmbFuentePeriodico.Visible = false;
				cmbFuentePeriodicoDia.Visible = false;
				lblFuenteNA.Visible = false;
			}else if(cmFuente.SelectedIndex == 1){				
				txtFuenteOperador.Visible = false;
				cmbFuenteInternet.Visible = false;
				cmbFuentePeriodico.Visible = true;
				cmbFuentePeriodicoDia.Visible = true;
				lblFuenteNA.Visible = false;
			}else if(cmFuente.SelectedIndex == 2){					
				txtFuenteOperador.Visible = false;
				cmbFuenteInternet.Visible = true;
				cmbFuentePeriodico.Visible = false;
				cmbFuentePeriodicoDia.Visible = false;
				lblFuenteNA.Visible = false;
			}else{							
				txtFuenteOperador.Visible = false;
				cmbFuenteInternet.Visible = false;
				cmbFuentePeriodico.Visible = false;
				cmbFuentePeriodicoDia.Visible = false;
				lblFuenteNA.Visible = true;
			}*/
		}		
		
		public void copySpechAspectos(){
			try{
				string tipoTel = "";
				for (int i = 0; i < ListarTelefonos.Count; i++){
					if(ListarTelefonos[i].numero == txtNumCelular.Text)
						tipoTel = ListarTelefonos[i].tipo;
				}
				
				String datos = "*ASPECTOS INICIALES* \n";	
				datos += "Folio: "+lblFolio.Text+", *_"+cmbTipoOperador.Text+"_* \n";
				datos += "Trámite: _*"+cmbTramite.Text+"*_ \n";
				datos += txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+", \n";
				
				if(tipoTel.Length > 0)
					datos += tipoTel+" "+((txtNumCelular.Text.Length == 0)? "*No tiene*, \n": txtNumCelular.Text+" \n");
				else
					datos += "Cel "+((txtNumCelular.Text.Length == 0)? "*No tiene*, \n": txtNumCelular.Text+" \n");
				
				datos += "*"+cmbZona.Text+",*  "+txtColonia.Text+". \n";
				datos += "_Infonavit:_ "+((cmbCreditoInfo.Text == "SI")? "*SI*, _Monto:_ *$"+txtMontoInf.Text+"*": "NO")+" \n";
				datos += "*_Parámetros de Validación_* \n";
				datos +="Edad: "+((lblEdad.ForeColor == Color.Red)? "*"+lblEdad.Text+"*": lblEdad.Text)+" \n";
				datos += "Imagen: "+((txtImagenPersonal.ForeColor == Color.Red)? "*"+txtImagenPersonal.Text+" %*" : txtImagenPersonal.Text+" %")+"  \n";
				datos += "\tTatuajes: "+((lblTatuajes.ForeColor == Color.Red)? "*"+lblTatuajes.Text+"*" : lblTatuajes.Text)+"  \n";
				datos += "\tPiercing: "+((lblPiercing.ForeColor == Color.Red)? "*"+lblPiercing.Text+"*" : lblPiercing.Text)+"  \n";
				datos += "Licencia: \n";
				
				if(cmbTipoLicEstatal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicEstatal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigEstatal)) >= dtpVigenciaLicEstatal.Value)		
						venceE = ", Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = ", *Vencida*" ;
					
					datos += "\tEstatal: "+((lblTipoEstatal.ForeColor == Color.Red)? "*"+lblTipoEstatal.Text+"* "+venceE : lblTipoEstatal.Text+" "+venceE)+"  \n";
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.estatal.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.estatal+"*  \n";
					}						
				}
				if(cmbTipoLicFederal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicFederal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigFederal)) >= dtpVigenciaLicFederal.Value)		
						venceE = ", Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = ", *Vencida*" ;
					
					datos += "\tFederal: "+((lblTipoFederal.ForeColor == Color.Red)? "*"+lblTipoFederal.Text+"* "+venceE : lblTipoFederal.Text+" "+venceE)+"  \n";
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.federal.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.federal+"*  \n";
					}	
				}				
				
				if(cmbTipoLicFederal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicAptoMedico.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigAptoMedico)) >= dtpVigenciaLicAptoMedico.Value)		
						venceE = " Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = " *Vencido*" ;
					
					if(venceE.Length > 0)
						datos += "\tMedico: "+venceE+" \n";
					
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.medico.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.medico+"*  \n";
					}
				}				
				
				datos += "Experiencia: \n";
				datos += "\tDual: "+((txtDualA.ForeColor == Color.Red)?  ((txtDualA.Text.Length == 0)? "*"+txtDualM.Text+"* Meses" : ((Convert.ToInt32(txtDualA.Text) > 0 )? "*"+txtDualA.Text+"* Años" : "*"+txtDualM.Text+"* Meses"  ) )  : txtDualA.Text+" Años")+" \n";
				datos += "\tDirección Trasera: "+((txtDirTraseraA.ForeColor == Color.Red)?  ((txtDirTraseraA.Text.Length == 0)? "*"+txtDirTraseraM.Text+"* Meses" : ((Convert.ToInt32(txtDirTraseraA.Text) > 0 )? "*"+txtDirTraseraA.Text+"* Años" : "*"+txtDirTraseraM.Text+"* Meses"  ) ) : txtDirTraseraA.Text+" Años")+" \n";
				datos += "\tTrans de Personal: "+((txtTransPersonalA.ForeColor == Color.Red)?  ((txtTransPersonalA.Text.Length == 0)? "*"+txtTransPersonalM.Text+"* Meses" :  ((Convert.ToInt32(txtTransPersonalA.Text) > 0 )? "*"+txtTransPersonalA.Text+"* Años" : "*"+txtTransPersonalM.Text+"* Meses"  ) ) : txtTransPersonalA.Text+" Años")+" \n";
				datos += "*_Fuente:_* ";
				
				if(cmFuente.Text.Equals("RECOMENDACION"))
					datos += cmFuente.Text+", "+txtFuenteOperador.Text+". \n";
				else if(cmFuente.Text.Equals("PERIODICO"))
					datos += cmFuente.Text+", "+cmbFuentePeriodico.Text+". \n";
				else if(cmFuente.Text.Equals("INTERNET"))
					datos += cmFuente.Text+", "+cmbFuenteInternet.Text+". \n";
				else	
					datos += cmFuente.Text+". \n";
				
				/*
				 
				if(cmFuente.SelectedIndex == 0)
					datos += cmFuente.Text+", "+txtFuenteOperador.Text+". \n";
				else if(cmFuente.SelectedIndex == 1)
					datos += cmFuente.Text+", "+cmbFuentePeriodico.Text+". \n";
				else if(cmFuente.SelectedIndex == 2)
					datos += cmFuente.Text+", "+cmbFuenteInternet.Text+". \n";
				else	
					datos += cmFuente.Text+". \n"; 
				 */
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
			 	
				MessageBox.Show("Se generó mensaje para Whatsapp, Copiarlo en el grupo pertienente", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de Whatsapp de la autorización: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void copySpechAspectos2(){
			try{
				string tipoTel = "";
				for (int i = 0; i < ListarTelefonos.Count; i++){
					if(ListarTelefonos[i].numero == txtNumCelular.Text)
						tipoTel = ListarTelefonos[i].tipo;
				}
				
				String datos = "*RECEPCIÓN DE CANDIDATO* \n\n";	
				datos += "Folio: "+lblFolio.Text+", *_"+cmbTipoOperador.Text+"_* \n";
				datos += txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+" \n\n";
				
				datos += "Licencia: \n";				
				if(cmbTipoLicEstatal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicEstatal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigEstatal)) >= dtpVigenciaLicEstatal.Value)		
						venceE = ", Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = ", *Vencida*" ;
					
					datos += "\tEstatal: "+((lblTipoEstatal.ForeColor == Color.Red)? "*"+lblTipoEstatal.Text+"* "+venceE : lblTipoEstatal.Text+" "+venceE)+"  \n";
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.estatal.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.estatal+"*  \n";
					}						
				}
				if(cmbTipoLicFederal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicFederal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigFederal)) >= dtpVigenciaLicFederal.Value)		
						venceE = ", Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = ", *Vencida*" ;
					
					datos += "\tFederal: "+((lblTipoFederal.ForeColor == Color.Red)? "*"+lblTipoFederal.Text+"* "+venceE : lblTipoFederal.Text+" "+venceE)+"  \n";
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.federal.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.federal+"*  \n";
					}	
				}				
				
				if(cmbTipoLicFederal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicAptoMedico.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigAptoMedico)) >= dtpVigenciaLicAptoMedico.Value)		
						venceE = " Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = " *Vencido*" ;
					
					if(venceE.Length > 0)
						datos += "\tMedico: "+venceE+" \n";
					
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.medico.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.medico+"*  \n";
					}
				}				
				
				datos += "Experiencia: \n";
				datos += "\tDual: "+((txtDualA.ForeColor == Color.Red)?  ((txtDualA.Text.Length == 0)? "*"+txtDualM.Text+"* Meses" : ((Convert.ToInt32(txtDualA.Text) > 0 )? "*"+txtDualA.Text+"* Años" : "*"+txtDualM.Text+"* Meses"  ) )  : txtDualA.Text+" Años")+" \n";
				datos += "\tDirección Trasera: "+((txtDirTraseraA.ForeColor == Color.Red)?  ((txtDirTraseraA.Text.Length == 0)? "*"+txtDirTraseraM.Text+"* Meses" : ((Convert.ToInt32(txtDirTraseraA.Text) > 0 )? "*"+txtDirTraseraA.Text+"* Años" : "*"+txtDirTraseraM.Text+"* Meses"  ) ) : txtDirTraseraA.Text+" Años")+" \n";
				datos += "\tTrans de Personal: "+((txtTransPersonalA.ForeColor == Color.Red)?  ((txtTransPersonalA.Text.Length == 0)? "*"+txtTransPersonalM.Text+"* Meses" :  ((Convert.ToInt32(txtTransPersonalA.Text) > 0 )? "*"+txtTransPersonalA.Text+"* Años" : "*"+txtTransPersonalM.Text+"* Meses"  ) ) : txtTransPersonalA.Text+" Años")+" \n";
				
				
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
			 	
				MessageBox.Show("Se generó mensaje para Whatsapp, Copiarlo en el grupo pertienente", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de Whatsapp de la autorización: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void logicaLicencias(){
			bool flag = true;
			
			if(cmbTipoLicEstatal.SelectedIndex > 0 && txtNumLicEstatal.Text.Length > 0){
				if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigEstatal)) >= dtpVigenciaLicEstatal.Value)
					flag = false;
			}else
				flag = true;
			
			if(flag){				
				if(cmbTipoLicFederal.SelectedIndex > 0 && txtNumLicFederal.Text.Length > 0){
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigFederal)) >= dtpVigenciaLicFederal.Value)
						flag = false;
				}else
					flag = true;
			}
			
			if(flag){				
				if(txtNumLicAptoMedico.Text.Length > 0){
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigAptoMedico)) >= dtpVigenciaLicAptoMedico.Value)
						flag = false;
				}else
					flag = true;
			}
			
			if(txtNumLicEstatal.Text.Length == 0 && txtNumLicFederal.Text.Length == 0 && txtNumLicAptoMedico.Text.Length == 0){
				btnLicenciasAI.Image = System.Drawing.Image.FromFile("btnGris24.png");
				ajustesLic = false;
			}else if(flag){
				ajustesLic = false;
				btnLicenciasAI.Image = System.Drawing.Image.FromFile("btnVerde24.png");
			}else{				
				ajustesLic = true;
				btnLicenciasAI.Image = System.Drawing.Image.FromFile("btnRojo24.png");	
			}		
		}
		
		private void logicaAlias(){
			lblAlias.Text = "Alias";
			lblAlias.ForeColor = Color.Blue;	
			//if(!banderaFiltros && ID_PREOPERADOR == 0){
			if(!banderaFiltros){
				bool respuesta = true;
				string consulta = "";
				lblAlias.Text = "Alias";
				lblAlias.ForeColor = Color.Blue;
				List<string> nombres = new List<string>();
				if(txtNombre.Text != "" && txtApellidoM.Text != "" && txtApellidoP.Text != ""){
					try{
						Char delimiter = ' ';
					    String[] substrings = txtNombre.Text.Split(delimiter);
					    foreach (var substring in substrings)
					    	nombres.Add(substring);
					    
					    if(nombres.Count == 1){
					    	consulta = "SELECT * FROM OPERADOR WHERE estatus = '1' and alias = '"+nombres[0]+"'";
							conn.getAbrirConexion(consulta);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read())
								respuesta = true;
							else{
								respuesta = false;
								lblAlias.Text = nombres[0];
							}
							
							conn.conexion.Close();
							
							if(respuesta){
								consulta = "SELECT * FROM OPERADOR WHERE estatus = '1' and alias = '"+txtApellidoP.Text+"'";
								conn.getAbrirConexion(consulta);
								conn.leer = conn.comando.ExecuteReader();
								if(conn.leer.Read())
									respuesta = true;
								else{
									respuesta = false;
									lblAlias.Text = txtApellidoP.Text;
								}
								conn.conexion.Close();
							}
							
							if(respuesta){
								consulta = "SELECT * FROM OPERADOR WHERE estatus = '1' and alias = '"+txtApellidoM.Text+"'";
								conn.getAbrirConexion(consulta);
								conn.leer = conn.comando.ExecuteReader();
								if(conn.leer.Read())
									respuesta = true;
								else{
									respuesta = false;
									lblAlias.Text = txtApellidoM.Text;
								}
								conn.conexion.Close();
							}
					    }else{
					    	for(int x = 0; x<nombres.Count; x++){
					    		if(nombres[x] != "DE" && nombres[x] != "LOS" && nombres[x].Length > 3){
					    			consulta = "SELECT * FROM OPERADOR WHERE estatus = '1' and alias = '"+nombres[x]+"'";
									conn.getAbrirConexion(consulta);
									conn.leer = conn.comando.ExecuteReader();
									if(conn.leer.Read())								
										respuesta = true;
									else{
										respuesta = false;
										lblAlias.Text = nombres[x];
										conn.conexion.Close();
										break;
									}
									conn.conexion.Close();
					    		}			
					    	}
					    	if(respuesta){
								consulta = "SELECT * FROM OPERADOR WHERE estatus = '1' and alias = '"+txtApellidoP.Text+"'";
								conn.getAbrirConexion(consulta);
								conn.leer = conn.comando.ExecuteReader();
								if(conn.leer.Read())							
									respuesta = true;
								else{
									respuesta = false;
									lblAlias.Text = txtApellidoP.Text;
								}
								conn.conexion.Close();
							}
							
							if(respuesta){
								consulta = "SELECT * FROM OPERADOR WHERE estatus = '1' and alias = '"+txtApellidoM.Text+"'";
								conn.getAbrirConexion(consulta);
								conn.leer = conn.comando.ExecuteReader();
								if(conn.leer.Read())							
									respuesta = true;
								else{
									respuesta = false;
									lblAlias.Text = txtApellidoM.Text;
								}
								conn.conexion.Close();
							}
					    }				
					}catch(Exception ex){
						MessageBox.Show("Error al obtener ALIAS: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
					}finally{
						if(conn.conexion != null)
							conn.conexion.Close();
					}
				}
				if(respuesta)				
					lblAlias.ForeColor = Color.Red;
				
				lblAliasS.Text = lblAlias.Text;
			}
		}
		
		/*********************************************** OLD ***********************************************/
		private void validaAutorizacion(){
			if(ID_PREOPERADOR > 0)
				new FormValidaDatos(this, id_usuario, ID_PREOPERADOR, lblIngreso.Text).ShowDialog();
			else				
				new FormValidaDatos(this, id_usuario, lblIngreso.Text).ShowDialog();
		}		
		
		public bool validaDatosOperador(string FechaManejo, string HoraManejo, string FechaMedico, string HoraMedico){
			bool respuesta = false;/*
			if(lblIngreso.Text == "Candidato Activo" && ID_PREOPERADOR > 0){
				if(ModificaRegistro(connO.getFlujo(ID_PREOPERADOR), connO.getEstatus(ID_PREOPERADOR), 0 )){
					respuesta = connO.validaCandidato( ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "NORMAL", "DATOS", "N/A", "", "VALIDADO", id_usuario);
					respuesta = connO.insertarCita(ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "MANEJO", FechaManejo, HoraManejo, id_usuario, "ACTIVA");
					respuesta = connO.insertarCita(ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "MEDICO", FechaMedico, HoraMedico, id_usuario, "ACTIVA");
				}else
					respuesta = false;
			}else if( (lblIngreso.Text == "Candidato Rechazado" || lblIngreso.Text == "Llamada Cancelada") && ID_PREOPERADOR > 0){
				DialogResult rs = MessageBox.Show(@"El candidato fue rechazado anteriormente ¿Deseas guardar la información con nuevo folio para dar el seguimiento de contratación? 
				Nota: Para mayor información da doble clic sobre la leyenda de Candidato Rechazado en la parte superior del formulario", "Candidato rechazado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs){			
					if(ModificaRegistro("SOLICITUD", "RECHAZADO", 1)){
						respuesta = connO.validaCandidato( ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "NORMAL", "DATOS", "N/A", "", "VALIDADO", id_usuario);
						respuesta = connO.insertarCita(ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "MANEJO", FechaManejo, HoraManejo, id_usuario, "ACTIVA");
						respuesta = connO.insertarCita(ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "MEDICO", FechaMedico, HoraMedico, id_usuario, "ACTIVA");
					}else
						respuesta = false;
				}
			}else if(lblIngreso.Text == "Nuevo Ingreso" && ID_PREOPERADOR == 0){
				if(InsertaRegistro("NUEVO")){
					Int64 idP = connO.obtenerIDCandidato();
					respuesta = connO.validaCandidato( idP, connO.getFolio(idP).ToString(), "NORMAL", "DATOS", "N/A", "", "VALIDADO", id_usuario);
					respuesta = connO.insertarCita(idP, connO.getFolio(idP).ToString(), "MANEJO", FechaManejo, HoraManejo, id_usuario, "ACTIVA");
					respuesta = connO.insertarCita(idP, connO.getFolio(idP).ToString(), "MEDICO", FechaMedico, HoraMedico, id_usuario, "ACTIVA");
				}else
					respuesta = false;					
			}else if(lblIngreso.Text == "Reingreso"){
				if(connO.getValidaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd")) == 0){
					if(InsertaRegistro("REINGRESO")){
						Int64 idP = connO.obtenerIDCandidato();
						respuesta = connO.validaCandidato( idP, connO.getFolio(idP).ToString() , "NORMAL", "DATOS", "", "", "VALIDADO", id_usuario);
						respuesta = connO.insertarCita(idP, connO.getFolio(idP).ToString(), "MANEJO", FechaManejo, HoraManejo, id_usuario, "ACTIVA");
						respuesta = connO.insertarCita(idP, connO.getFolio(idP).ToString(), "MEDICO", FechaMedico, HoraMedico, id_usuario, "ACTIVA");
					}else
						respuesta = false;
				}else{
					if(ModificaRegistro("SOLICITUD", "REINGRESO", 1)){
						respuesta = connO.validaCandidato( ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "NORMAL", "DATOS", "N/A", "", "VALIDADO", id_usuario);
						respuesta = connO.insertarCita(ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "MANEJO", FechaManejo, HoraManejo, id_usuario, "ACTIVA");
						respuesta = connO.insertarCita(ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), "MEDICO", FechaMedico, HoraMedico, id_usuario, "ACTIVA");
					}else
						respuesta = false;
				}
			}*/
			
			return respuesta;
		}	

		public void copySpech(string FechaManejo, string HoraManejo, string FechaMedico, string HoraMedico){
			try{
				/*String datos = "*SOLICITUD DE EMPLEO* \n"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+", "+((dgContacto[3,0].Value.ToString().Equals("PROPIO"))? "": dgContacto[3,0].Value.ToString())+" "+dgContacto[1,0].Value.ToString()+" "
								+dgContacto[2,0].Value.ToString()+", "+cmbZona.Text+", "+txtColonia.Text;	*/
				
				String datos = "*SOLICITUD DE EMPLEO* \n"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text;	
				
				
				datos += "\n_Parámetros de Validación_ \n\t Edad: "+lblEdad.Text+" \n\t Imagen: "+txtImagenPersonal.Text+" %\n\t     Peso: "+txtPesoS.Text+" Kg\n\t     Altura: "+txtAlturaS.Text+" Mts \n\t Tatuajes: "+cmbTatuajes.Text+" \n\t  Licencia: "
						+((cmbTipoLicEstatal.SelectedIndex > 0)? "\n\t     Estatal: "+cmbTipoLicEstatal.Text : "" )+((cmbTipoLicFederal.SelectedIndex > 0)? "\n\t     Federal: "+cmbTipoLicFederal.Text : "" )+" \n\t Experiencia: \n\t     Dual: "
					   	+txtDualA.Text+" Años \n\t     Direción Trasera: "+txtDirTraseraA.Text+" Años \n\t     Trans de Personal: "+txtTransPersonalA.Text+ " Años\n\n_CITA MANEJO_  "+FechaManejo+" "+HoraManejo+"\n_CITA MEDICO_  "+FechaMedico+" "+HoraMedico;
				
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
			}catch(Exception){				
			}
		}
		#endregion
		
		#region FOTO		
		void CopiarImagenClick(object sender, EventArgs e)
		{
			  if (ptbImagenAI.Image != null) 
                Clipboard.SetImage(ptbImagenAI.Image); 
		}
		
		void PtbImagenAIDoubleClick(object sender, EventArgs e)
		{
			if(pnFoto.Visible == false){	
	            BuscarDispositivos();
				pnFoto.Visible = true;
				if (DispositivosDeVideo.Count > 0)
					IniciaCamara();
			}else{						
	            TerminaCamara();
				pnFoto.Visible = false;
			}
		}
		
			#region VARIABLES - INSTANCIAS
	        private bool ExistenDispositivos = false;
	        private FilterInfoCollection DispositivosDeVideo;
	        private VideoCaptureDevice FuenteDeVideo = null;
			#endregion
				
			#region METODOS
			private void BuscarDispositivos(){
				try{
					DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
					if (DispositivosDeVideo.Count == 0){
		                ExistenDispositivos = false;
						MessageBox.Show("No se encontró ninguna cámara, revisa que esté conectada e inténtalo otra vez", 
		                            "No se encontró cámara", MessageBoxButtons.OK, MessageBoxIcon.Information);		            	
					}else{
		                ExistenDispositivos = true;
		                CargarDispositivos(DispositivosDeVideo);
		            }
				}catch(Exception ex){
					MessageBox.Show("Error al buscar la cámara: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
	        }
			
	        private void CargarDispositivos(FilterInfoCollection Dispositivos){
				try{
					cboDispositivos.Items.Clear();
					for (int i = 0; i < Dispositivos.Count; i++)
		                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString());
		            cboDispositivos.SelectedIndex = 0;
				}catch(Exception ex){
					MessageBox.Show("Error al cargar la cámara: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
	        }
			
	        private void TerminarFuenteDeVideo(){
	            if (!(FuenteDeVideo == null))
	                if (FuenteDeVideo.IsRunning){
	                    FuenteDeVideo.SignalToStop();
	                    FuenteDeVideo = null;
	                }
	        }
			
			private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs){
	         	Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
	            pbFotoUser.Image = Imagen;
	        }

			private void IniciaCamara(){
				if (btnIniciar.Text == "Iniciar Cámara"){
	                if (ExistenDispositivos){
	                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
	                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
	                    FuenteDeVideo.Start();
	                    btnIniciar.Text = "Detener Cámara";
	                    cboDispositivos.Enabled = false;
	                }else
						MessageBox.Show("No se encontró ninguna cámara, revisa que esté conectada e inténtalo otra vez", 
		                            "No se encontró cámara", MessageBoxButtons.OK, MessageBoxIcon.Information);
	            }else
					TerminaCamara();	            
			}
			
			private void TerminaCamara(){
				try{
					if(FuenteDeVideo != null){
						if (FuenteDeVideo.IsRunning){
		                    TerminarFuenteDeVideo();
		                    btnIniciar.Text = "Iniciar Cámara";
		                    cboDispositivos.Enabled = true;
		                    pbFotoUser.Image = null;
		                }
					}						 
				}catch(Exception ex){
					MessageBox.Show("Error al detener la cámara: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			
			private void RedimensionarImagen(string ruta, string carpeta, string nombre){
				System.Drawing.Image image = System.Drawing.Image.FromFile(ruta);
				image = new Proceso.RedimensionarImagen().RedimensionarDinamica(image, 640, 480, Convert.ToInt32(image.HorizontalResolution) );
				//image = new Proceso.RedimensionarImagen().RedimensionarDinamica(image, 113, 151, Convert.ToInt32(image.HorizontalResolution) );
				image.Save(carpeta+@"\R "+nombre);//
				image.Dispose();
			}
			#endregion
		
			#region EVENTOS - BOTONES
			void CboDispositivosClick(object sender, EventArgs e)
			{
				if (DispositivosDeVideo.Count == 0){               	
		            BuscarDispositivos();
					if (DispositivosDeVideo.Count > 0)
						IniciaCamara();            	
				}
			}
		
			void BtnIniciarClick(object sender, EventArgs e)
			{
				IniciaCamara();
			}
			
			void BtnFotoClick(object sender, EventArgs e)
			{
				if (btnIniciar.Text != "Iniciar Cámara"){
					ptbImagenAI.Image = System.Drawing.Image.FromFile("Camara.png");
					string newPath = System.IO.Path.Combine(activeDir, "Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Imagenes"); 
					System.IO.Directory.CreateDirectory(newPath);
					
					rutaFile = newPath+@"\"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+".jpeg";
					string nombre = txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+".jpeg";
					for(int x = 1; x<100; x++){
						if(File.Exists(rutaFile)){
							rutaFile = newPath+@"\"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+" ("+x+").jpeg";
							nombre = txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+" ("+x+").jpeg";
						}else
							break;
					}					
					pbFotoUser.Image.Save(rutaFile, ImageFormat.Jpeg);	        		
			    	if(File.Exists(rutaFile)){
			    		RedimensionarImagen(rutaFile, newPath, nombre);
						ptbImagenAI.Image = System.Drawing.Image.FromFile(newPath+@"\R "+nombre);	

				//ptbImagen.Image = System.Drawing.Image.FromFile(carpeta+@"\R "+nombre); // CARGA  IMAGEN REDIMENSIONADA						
			    		imagen = true;
			    	}
	        		else
						MessageBox.Show("Error al tomar la foto, inténtalo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
				}else
					MessageBox.Show("La cámara debe de estar iniciada para poder tomar la foto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}	
			
			void BtnQuitaFotoClick(object sender, EventArgs e)
			{
				ptbImagenAI.Image = System.Drawing.Image.FromFile("Camara.png");
				TerminaCamara();
				pnFoto.Visible = false;	
				imagen = false;			
			}
			
			void LblCancelarFotoClick(object sender, EventArgs e)
			{
				if (btnIniciar.Text != "Iniciar Cámara")
					TerminaCamara();
				
				pnFoto.Visible = false;				
			}
			
			void BtnImagenClick(object sender, EventArgs e)
			{
				try{
					OpenFileDialog dlg = new OpenFileDialog();
					dlg.Title= "Operador";
					dlg.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG|"+"All files (*.*)|*.*";
					DialogResult result=dlg.ShowDialog();
					if(result== DialogResult.OK){
						ptbImagenAI.Image = System.Drawing.Image.FromFile(dlg.FileName);
						rutaFile = dlg.FileName;
						
						/*System.Drawing.Image image = System.Drawing.Image.FromFile(ruta);
						image = new Proceso.RedimensionarImagen().RedimensionarDinamica(image, 768, 924, Convert.ToInt32(image.HorizontalResolution));	
									
						string newPath = System.IO.Path.Combine(activeDir, "Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Imagenes"); 
						System.IO.Directory.CreateDirectory(newPath);		
						string nombre = txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+".jpeg";
						for(int x = 1; x<100; x++){
							if(File.Exists(newPath+@"\"+nombre)){
								nombre = txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+" ("+x+").jpeg";
							}else
								break;
						}
						image.Save(newPath+@"\"+nombre);
						image.Dispose();
						ptbImagen.Image = System.Drawing.Image.FromFile(newPath+@"\"+nombre);*/
						imagen = true;
					}else{
						imagen = false;
						ptbImagenAI.Image = System.Drawing.Image.FromFile("Camara.png");
					}
				}catch(Exception ex){
					imagen = false;
					MessageBox.Show("Error durante la obtención de la imagen: "+ex.Message,"Cargarndo imagen",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			#endregion	
		
		#endregion
		
		/*********************************************************************************************************/
		/*********************************************** SOLICITUD ***********************************************/
		/*********************************************************************************************************/
		
		#region METODOS		
		private bool ValidaInsertarSolicitud(){
			bool respuesta = true;
			if(txtCalleS.Text.Length == 0){
				errorProvider3.SetError(txtCalleS, "Ingresa la calle de su domicilio");
				txtCalleS.Focus();
				respuesta = false;
			}
			if(txtNumExtS.Text.Length == 0){
				errorProvider3.SetError(txtNumExtS, "Ingresa el numero de su domicilio");
				txtNumExtS.Focus();
				respuesta = false;
			}
			if(txtMunicipioS.Text.Length == 0){
				errorProvider3.SetError(txtMunicipioS, "Ingresa el municipio donde esta domicilio");
				txtMunicipioS.Focus();
				respuesta = false;
			}
			if(cmbEstadoS.SelectedIndex == -1){
				errorProvider3.SetError(cmbEstadoS, "Ingresa el estado de su domicilio");
				cmbEstadoS.Focus();
				respuesta = false;
			}
			return respuesta;
		}
		
		public void limpiarCamposS(){	
			lblNombreCandidatoS.Text = "Nombre Candidado";
			lblFolioS.Text = "0001";
			
			txtCorreoS.Text = "";
			ptbImagenS.Image = System.Drawing.Image.FromFile("Camara.png");			
			dtpNacimientoS.Value = DateTime.Now;
			txtLugarNaciS.Text = "";
			txtMunicipioNaciS.Text = "";
			txtEstadoNaciS.Text = "";
						
			txtCalleS.Text = "";
			txtNumExtS.Text = "";
			txtMunicipioS.Text = "";
			txtColoniaS.Text = "";
			txtNumIntS.Text = "";
			txtCPS.Text = "";
			
			cmbEstadoS.SelectedIndex = 0;
			
			txtCruce1S.Text = "";
			txtCruce2S.Text = "";
			
			lblEdadS.Visible = false;
			lblFuenteNA.Visible = false;	
			errorProvider3.Clear();
			tcPrincipal.SelectedIndex = 0;
			tpSolicitud.Enabled = false;
		}
		
		private void obtenerCandidatoS(){
			string consulta = "";
			tpSolicitud.Enabled = true;
			
			try{
				consulta ="SELECT * FROM PRE_OPERADOR WHERE ID = "+ID_PREOPERADOR;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					String id = conn.leer["ID"].ToString();
					lblFolioS.Text = ((id.Length == 1)? "000"+id : ((id.Length == 2)? "00"+id : ((id.Length == 3)? "0"+id : id ) ) );
					
					lblNombreCandidatoS.Text = conn.leer["NOMBRE"].ToString()+" "+conn.leer["APELLIDO_PAT"].ToString()+" "+conn.leer["APELLIDO_MAT"].ToString();
					txtCorreoS.Text = conn.leer["CORREO"].ToString();
					dtpNacimientoS.Value = Convert.ToDateTime(conn.leer["FECHA_NACIMIENTO"]);
					txtLugarNaciS.Text = conn.leer["LUGAR_NACIMIENTO"].ToString();
					txtMunicipioNaciS.Text = conn.leer["MUNICIPIO_NACIMIENTO"].ToString();
					txtEstadoNaciS.Text = conn.leer["ESTADO_NACIMIENTO"].ToString();
					txtCalleS.Text = conn.leer["CALLE"].ToString();
					txtNumExtS.Text = conn.leer["NUM_EXT"].ToString();
					txtMunicipioS.Text = conn.leer["MUNICIPIO"].ToString();
					txtColoniaS.Text = conn.leer["COLONIA"].ToString();
					txtNumIntS.Text = conn.leer["NUM_INT"].ToString();
					txtCPS.Text = conn.leer["CP"].ToString();
					cmbEstadoS.Text = conn.leer["ESTADO"].ToString();
					txtCruce1S.Text = conn.leer["CRUCE1"].ToString();
					txtCruce2S.Text = conn.leer["CRUCE2"].ToString();
						
					if(conn.leer["IMAGEN"] != null){
						if(conn.leer["IMAGEN"].ToString().Length > 0){
							byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
				  			ms = new System.IO.MemoryStream(imageBuffer);
				  			ptbImagenS.Image = System.Drawing.Image.FromStream(ms);
						}else{
							ptbImagenS.Image = System.Drawing.Image.FromFile("Camara.png");
						}						
					}else
						ptbImagenS.Image = System.Drawing.Image.FromFile("Camara.png");										
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos de la solicitud del candidato): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				if(conn.conexion != null)
				 conn.conexion.Close();				
			}
		}
			
		private void EdadS(){
			if(dtpNacimientoS.Value < DateTime.Now.AddDays(-1)){
				int edad = (DateTime.Today.AddTicks(-dtpNacimientoS.Value.Ticks).Year - 1);
				
				if(edad > 0){
					lblEdadS.Text = edad.ToString();
					lblEdadS.Visible = true;
					if(parametros != null)
						lblEdadS.ForeColor = ((edad < Convert.ToInt16(parametros.edadMin) || edad > Convert.ToInt16(parametros.edadMax) )? Color.Red: Color.Black);
				}else{
					lblEdadS.Visible = false;
				}
			}	
		}
		
		private void ImprimeSolicitud(){
			DialogResult rs = MessageBox.Show(@"¿Deseas Imprimir la Solicitud de empleo? ", "Impresión del Solicitud de empleo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (DialogResult.Yes==rs){
				try{
					string detalleFuente = "";
					if(cmFuente.Text.Equals("RECOMENDACION"))
						detalleFuente = txtFuenteOperador.Text;
					else if(cmFuente.Text.Equals("PERIODICO"))	
						detalleFuente = cmbFuentePeriodico.Text;
					else if(cmFuente.Text.Equals("INTERNET"))
						detalleFuente = cmbFuenteInternet.Text;
					else						
						detalleFuente = "N/A";
			
					string newPath = System.IO.Path.Combine(activeDir, "Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy"));  
					System.IO.Directory.CreateDirectory(newPath);				
					Document doc = new Document(PageSize.LETTER, 20, 20 ,10, 10);
					FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtNombre.Text+" Solicitud Empleo.pdf",
					                                 FileMode.OpenOrCreate,
					                                 FileAccess.ReadWrite,
					                                 FileShare.ReadWrite);
					PdfWriter writer = PdfWriter.GetInstance(doc, file);
					doc.Open();
					FormatoPdf.FormatoSolicitudEmpleo(doc, writer, ms, ptbImagenS, lblFolio.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCalleS.Text, txtNumExtS.Text, txtNumIntS.Text, txtMunicipioS.Text, txtColonia.Text, txtCPS.Text, cmbEstadoS.Text,
					            txtCruce1S.Text, txtCruce2S.Text, txtLugarNaciS.Text, txtMunicipioNaciS.Text, txtEstadoNaciS.Text, dtpNacimiento.Value.ToString("dd/MM/yyyy"), lblEdad.Text, cmbSexo.Text, txtAlturaS.Text, txtPesoS.Text, cmbTipoLicEstatal.Text,
					            txtNumLicEstatal.Text, ((cmbTipoLicEstatal.SelectedIndex > 0)? dtpVigenciaLicEstatal.Value.ToString("dd/MM/yyyy") : ""), cmbTipoLicFederal.Text, txtNumLicFederal.Text, ((cmbTipoLicFederal.SelectedIndex > 0)? dtpVigenciaLicFederal.Value.ToString("dd/MM/yyyy") : ""), 
					            txtNumLicAptoMedico.Text, ((txtNumLicAptoMedico.Text.Length > 0)? dtpVigenciaLicAptoMedico.Value.ToString("dd/MM/yyyy") : ""), cmbCreditoInfo.Text, txtMontoInf.Text, txtCorreoS.Text, cmbZona.Text, txtDualA.Text, txtDirTraseraA.Text, txtTransPersonalA.Text, lblIngreso.Text, 
					           cmFuente.Text, detalleFuente, txtImagenPersonal.Text, cmbTatuajes.Text, ListarTelefonos, cmbCreditoInfo.Text, txtMontoInf.Text, cmbEstadoEstatal.Text, cmbEstadoFederal.Text);
					doc.Close();
					Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtNombre.Text+" Solicitud Empleo.pdf");
				}catch (Exception ex){
					MessageBox.Show(ex.Message);
				}
			}
		}		
		
		private void ImprimeDocInduccion(){
			DialogResult rs = MessageBox.Show(@"¿Deseas Imprimir la documentación para la inducción? ", "Impresión de documentación de inducción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (DialogResult.Yes==rs){
				try{
					string newPath = System.IO.Path.Combine(activeDir, "Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy"));  
					System.IO.Directory.CreateDirectory(newPath);				
					Document doc = new Document(PageSize.LETTER, 20, 20 ,10, 10);
					FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtNombre.Text+" Documentación de Inducción.pdf",
					                                 FileMode.OpenOrCreate,
					                                 FileAccess.ReadWrite,
					                                 FileShare.ReadWrite);
					PdfWriter writer = PdfWriter.GetInstance(doc, file);
					doc.Open();
					FormatoPdf.FormatoDocInduccion(doc, writer, ms, ID_PREOPERADOR.ToString(), dgControlSolicitudes[2,dgControlSolicitudes.CurrentRow.Index].Value.ToString(), dgControlSolicitudes[3,dgControlSolicitudes.CurrentRow.Index].Value.ToString());
					doc.Close();
					Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Solicitud de Empleo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtNombre.Text+" Documentación de Inducción.pdf");
				}catch (Exception ex){
					MessageBox.Show(ex.Message);
				}
			}
		}
		
		public void copySpechSolicitud2(){
			try{
				string tipoTel = "";
				for (int i = 0; i < ListarTelefonos.Count; i++){
					if(ListarTelefonos[i].numero == txtNumCelular.Text)
						tipoTel = ListarTelefonos[i].tipo;
				}
				
				String datos = "*LLENADO DE SOLICITUD* \n";	
				datos += "Folio: "+lblFolio.Text+", *_"+cmbTipoOperador.Text+"_* \n";
				datos += "Trámite: _*"+cmbTramite.Text+"*_ \n";
				datos += txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+", \n";
				
				if(tipoTel.Length > 0)
					datos += tipoTel+" "+((txtNumCelular.Text.Length == 0)? "*No tiene*, \n": txtNumCelular.Text+" \n");
				else
					datos += "Cel "+((txtNumCelular.Text.Length == 0)? "*No tiene*, \n": txtNumCelular.Text+" \n");
				
				datos += "*"+cmbZona.Text+",*  "+txtColonia.Text+". \n";
				datos += "_Infonavit:_ "+((cmbCreditoInfo.Text == "SI")? "*SI*, _Monto:_ *$"+txtMontoInf.Text+"*": "NO")+" \n";
				datos += "*_Parámetros de Validación_* \n";
				datos +="Edad: "+((lblEdad.ForeColor == Color.Red)? "*"+lblEdad.Text+"*": lblEdad.Text)+" \n";
				datos += "Imagen: "+((txtImagenPersonal.ForeColor == Color.Red)? "*"+txtImagenPersonal.Text+" %*" : txtImagenPersonal.Text+" %")+"  \n";
				datos += "\tTatuajes: "+((lblTatuajes.ForeColor == Color.Red)? "*"+lblTatuajes.Text+"*" : lblTatuajes.Text)+"  \n";
				datos += "\tPiercing: "+((lblPiercing.ForeColor == Color.Red)? "*"+lblPiercing.Text+"*" : lblPiercing.Text)+"  \n";
				datos += "\tPesos: "+txtPesoS.Text+" Kg \n";
				datos += "\tAltura: "+txtAlturaS.Text+" Mts \n";
				datos += "Licencia: \n";
				
				if(cmbTipoLicEstatal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicEstatal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigEstatal)) >= dtpVigenciaLicEstatal.Value)		
						venceE = ", Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = ", *Vencida*" ;
					
					datos += "\tEstatal: "+((lblTipoEstatal.ForeColor == Color.Red)? "*"+lblTipoEstatal.Text+"* "+venceE : lblTipoEstatal.Text+" "+venceE)+"  \n";
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.estatal.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.estatal+"*  \n";
					}						
				}
				if(cmbTipoLicFederal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicFederal.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigFederal)) >= dtpVigenciaLicFederal.Value)		
						venceE = ", Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = ", *Vencida*" ;
					
					datos += "\tFederal: "+((lblTipoFederal.ForeColor == Color.Red)? "*"+lblTipoFederal.Text+"* "+venceE : lblTipoFederal.Text+" "+venceE)+"  \n";
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.federal.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.federal+"*  \n";
					}	
				}				
				
				if(cmbTipoLicFederal.SelectedIndex > 0){
					string venceE = "";
					TimeSpan tE = Convert.ToDateTime(dtpVigenciaLicAptoMedico.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")) ;
					double diasE =(tE.Days + 1)/14;
					double vigE = Math.Round(diasE);
					if(DateTime.Now.AddMonths(Convert.ToInt16(parametros.vigAptoMedico)) >= dtpVigenciaLicAptoMedico.Value)		
						venceE = " Vig, *"+Math.Round(diasE)+" Cat* ";					
					if(diasE<=0)
						venceE = " *Vencido*" ;
					
					if(venceE.Length > 0)
						datos += "\tMedico: "+venceE+" \n";
					
					
					if(ajustesLic && licAjuste != null){
						if(licAjuste.medico.Length > 0 && venceE.Length > 0)
							datos += "\t_Ajuste:_ *$"+licAjuste.medico+"*  \n";
					}
				}				
				
				datos += "Experiencia: \n";
				datos += "\tDual: "+((txtDualA.ForeColor == Color.Red)?  ((txtDualA.Text.Length == 0)? "*"+txtDualM.Text+"* Meses" : ((Convert.ToInt32(txtDualA.Text) > 0 )? "*"+txtDualA.Text+"* Años" : "*"+txtDualM.Text+"* Meses"  ) )  : txtDualA.Text+" Años")+" \n";
				datos += "\tDirección Trasera: "+((txtDirTraseraA.ForeColor == Color.Red)?  ((txtDirTraseraA.Text.Length == 0)? "*"+txtDirTraseraM.Text+"* Meses" : ((Convert.ToInt32(txtDirTraseraA.Text) > 0 )? "*"+txtDirTraseraA.Text+"* Años" : "*"+txtDirTraseraM.Text+"* Meses"  ) ) : txtDirTraseraA.Text+" Años")+" \n";
				datos += "\tTrans de Personal: "+((txtTransPersonalA.ForeColor == Color.Red)?  ((txtTransPersonalA.Text.Length == 0)? "*"+txtTransPersonalM.Text+"* Meses" :  ((Convert.ToInt32(txtTransPersonalA.Text) > 0 )? "*"+txtTransPersonalA.Text+"* Años" : "*"+txtTransPersonalM.Text+"* Meses"  ) ) : txtTransPersonalA.Text+" Años")+" \n";
				datos += "*_Fuente:_* ";	

				if(cmFuente.Text.Equals("RECOMENDACION"))
					datos += cmFuente.Text+", "+txtFuenteOperador.Text+". \n";
				else if(cmFuente.Text.Equals("PERIODICO"))
					datos += cmFuente.Text+", "+cmbFuentePeriodico.Text+". \n";
				else if(cmFuente.Text.Equals("INTERNET"))
					datos += cmFuente.Text+", "+cmbFuenteInternet.Text+". \n";
				else	
					datos += cmFuente.Text+". \n";
				/*
				if(cmFuente.SelectedIndex == 0)
					datos += cmFuente.Text+", "+txtFuenteOperador.Text+". \n";
				else if(cmFuente.SelectedIndex == 1)
					datos += cmFuente.Text+", "+cmbFuentePeriodico.Text+". \n";
				else if(cmFuente.SelectedIndex == 2)
					datos += cmFuente.Text+", "+cmbFuenteInternet.Text+". \n";
				else	
					datos += cmFuente.Text+". \n";
				*/
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
			 	
				MessageBox.Show("Se generó mensaje para Whatsapp, Copiarlo en el grupo pertienente", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de Whatsapp de la autorización: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		public void copySpechSolicitud(){
			try{
				string tipoTel = "";
				for (int i = 0; i < ListarTelefonos.Count; i++){
					if(ListarTelefonos[i].numero == txtNumCelular.Text)
						tipoTel = ListarTelefonos[i].tipo;
				}
				
				String datos = "*SOLICITUD DE EMPLEO* \n";	
				datos += "Folio: "+lblFolio.Text+", *_"+cmbTipoOperador.Text+"_* \n";
				datos += "Trámite: _*"+cmbTramite.Text+"*_ \n";
				datos += txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+", \n";
				if(tipoTel.Length > 0)
					datos += tipoTel+" "+((txtNumCelular.Text.Length == 0)? "*No tiene*, \n": txtNumCelular.Text+" \n");
				else
					datos += "Cel "+((txtNumCelular.Text.Length == 0)? "*No tiene*, \n": txtNumCelular.Text+" \n");datos += "*"+cmbZona.Text+",*  "+txtColonia.Text+". \n";
				datos += "*_Parámetros de Validación_* \n";
				datos +="Edad: "+((lblEdad.ForeColor == Color.Red)? "*"+lblEdad.Text+"*": lblEdad.Text)+" \n";
				datos += "Imagen: "+((txtImagenPersonal.ForeColor == Color.Red)? "*"+txtImagenPersonal.Text+" %*" : txtImagenPersonal.Text+" %")+"  \n";
				datos += "\t\tPesos: "+txtPesoS.Text+" Kg \n";
				datos += "\t\tAltura: "+txtAlturaS.Text+" Mts \n";
				datos += "\tTatuajes: "+((lblTatuajes.ForeColor == Color.Red)? "*"+lblTatuajes.Text+"*" : lblTatuajes.Text)+"  \n";
				datos += "\tPiercing: "+((lblPiercing.ForeColor == Color.Red)? "*"+lblPiercing.Text+"*" : lblPiercing.Text)+"  \n";
				datos += "Licencia: \n";
				if(cmbTipoLicEstatal.SelectedIndex > 0)
					datos += "\tEstatal: "+((lblTipoEstatal.ForeColor == Color.Red)? "*"+lblTipoEstatal.Text+" *" : lblTipoEstatal.Text+" ")+"  \n";
				if(cmbTipoLicFederal.SelectedIndex > 0)
					datos += "\tFederal: "+((lblTipoFederal.ForeColor == Color.Red)? "*"+lblTipoFederal.Text+"*" : lblTipoFederal.Text+" ")+"  \n";
				datos += "Experiencia: \n";
				datos += "\tDual: "+((txtDualA.ForeColor == Color.Red)?  ((txtDualA.Text.Length == 0)? "*"+txtDualM.Text+"* Meses" : ((Convert.ToInt32(txtDualA.Text) > 0 )? "*"+txtDualA.Text+"* Años" : "*"+txtDualM.Text+"* Meses"  ) )  : txtDualA.Text+" Años")+" \n";
				datos += "\tDirección Trasera: "+((txtDirTraseraA.ForeColor == Color.Red)?  ((txtDirTraseraA.Text.Length == 0)? "*"+txtDirTraseraM.Text+"* Meses" : ((Convert.ToInt32(txtDirTraseraA.Text) > 0 )? "*"+txtDirTraseraA.Text+"* Años" : "*"+txtDirTraseraM.Text+"* Meses"  ) ) : txtDirTraseraA.Text+" Años")+" \n";
				datos += "\tTrans de Personal: "+((txtTransPersonalA.ForeColor == Color.Red)?  ((txtTransPersonalA.Text.Length == 0)? "*"+txtTransPersonalM.Text+"* Meses" :  ((Convert.ToInt32(txtTransPersonalA.Text) > 0 )? "*"+txtTransPersonalA.Text+"* Años" : "*"+txtTransPersonalM.Text+"* Meses"  ) ) : txtTransPersonalA.Text+" Años")+" \n";
				datos += "\n_Cita en Taller_ "+dtpFechaCita.Value.ToString("dd/MM/yyyy")+"; "+dtpHoraCita.Value.ToString("HH:mm")+" hrs";
				
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
				MessageBox.Show("Se generó mensaje para Whatsapp, Copiarlo en el grupo pertienente", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de Whatsapp de la solicitud : "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		
		#region EVENTOS
		void TxtPesoSLeave(object sender, EventArgs e)
		{
			Proceso.ValidarCampo.punto = false;
		}
		
		void TxtAlturaSLeave(object sender, EventArgs e)
		{			
			Proceso.ValidarCampo.punto = false;
		}		
		
		void TxtPesoSEnter(object sender, EventArgs e)
		{
			if(txtPesoS.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtAlturaSEnter(object sender, EventArgs e)
		{
			if(txtAlturaS.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
				
		void TxtPesoSTextChanged(object sender, EventArgs e)
		{
			if(txtPesoS.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtAlturaSTextChanged(object sender, EventArgs e)
		{
			if(txtAlturaS.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void DtpNacimientoSValueChanged(object sender, EventArgs e)
		{			
			EdadS();
		}
		#endregion
		
		#region BOTONES
		void BtnLimpiarSClick(object sender, EventArgs e)
		{
			limpiarCamposS();
		}
		
		void BtnImprimirSClick(object sender, EventArgs e)
		{
			if(ValidaInsertarSolicitud()){
				ImprimeSolicitud();
				limpiarCamposAI();
			}
		}
		
		void BtnWhatsappSClick(object sender, EventArgs e)
		{
			copySpechSolicitud2();
		}
		
		void BtnGuardarSClick(object sender, EventArgs e)
		{
			if(ValidaInsertarSolicitud()){
				bool flagImprime = ((connO.getFlujo(ID_PREOPERADOR) != "SOLICITUD")? true : false);
				if(connO.modificaCandidatoSolicitud(txtCorreoS.Text, dtpNacimientoS.Value.ToString("yyyy-MM-dd"), txtLugarNaciS.Text, txtMunicipioNaciS.Text, txtEstadoNaciS.Text, txtCalleS.Text, txtNumExtS.Text, txtNumIntS.Text, 
				                                    txtMunicipioS.Text, txtColoniaS.Text, txtCPS.Text, cmbEstadoS.Text, txtCruce1S.Text, txtCruce2S.Text, ((connO.getFlujo(ID_PREOPERADOR) == "INICIALES")? "SOLICITUD" : connO.getFlujo(ID_PREOPERADOR) ), id_usuario, ID_PREOPERADOR)){					
					MessageBox.Show("Se modificó correctamente la solicitud del candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);					
					if(flagImprime)
						ImprimeSolicitud();
					copySpechSolicitud2();
					filtrosSolicitudes();
					limpiarCamposS();
					limpiarCamposAI();
				}
			}
		}
		#endregion
		
		/*********************************************************************************************************/
		/***************************************** REFERENCIAS LABORALES *****************************************/
		/*********************************************************************************************************/	
		
		
		void TpAspectosClick(object sender, EventArgs e)
		{
			
		}
	}
}
