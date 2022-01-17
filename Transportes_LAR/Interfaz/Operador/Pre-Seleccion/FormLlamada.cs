using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormLlamada : Form
	{
		#region VARIABLES y ARREGLOS
		int id_usuario;
		bool flagDefaultCita = false;		
		public Dato.Parametros parametros;
		bool flagGet = false;
		string id_preOperador = "0";
		public bool flagMotivo = false;
		#endregion
		
		#region INSTANCIAS
		private FormPrincipal principal = null;
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();	
		String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
		#endregion
		
		#region CONSTRUCTORES
		public FormLlamada()
		{
			InitializeComponent();
		}
		
		public FormLlamada(FormPrincipal refprincipal, int id_usu)
		{
			InitializeComponent();
			this.principal = refprincipal;
			id_usuario = id_usu;
		}
		#endregion
		
		#region INICIO - FIN
		void FormLlamadaLoad(object sender, EventArgs e)
		{
			inicio();
			flagDefaultCita = false;
		}
				
		void FormLlamadaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.llamadaContratacion = false;
		}
		#endregion
				
		#region METODOS		
		private void inicio(){	
			clean();
			
			txtFuenteOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT ALIAS FROM OPERADOR group by ALIAS order by ALIAS", "ALIAS");
           	txtFuenteOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFuenteOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtNombre.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT Nombre FROM OPERADOR  group by Nombre order by Nombre", "Nombre");
           	txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtApellidoP.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT Apellido_Pat FROM OPERADOR  group by Apellido_Pat order by Apellido_Pat", "Apellido_Pat");
           	txtApellidoP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtApellidoP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtApellidoM.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT Apellido_Mat FROM OPERADOR  group by Apellido_Mat order by Apellido_Mat", "Apellido_Mat");
           	txtApellidoM.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtApellidoM.AutoCompleteSource = AutoCompleteSource.CustomSource;            
            
            txtColonia.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT COLONIA FROM PRE_OPERADOR group by COLONIA order by COLONIA", "COLONIA");
           	txtColonia.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtColonia.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			this.txtNumeroContacto.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtDualA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtDirTraseraA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTransPersonalA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);		
			this.txtDualM.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtDirTraseraM.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTransPersonalM.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}		
		
		private void clean(){ // clean fields and assign the values by default
			lblIngreso.Text = "";
			txtNombre.Text = "";
			txtApellidoP.Text = "";
			txtApellidoM.Text = "";
			dtpNacimiento.Value = DateTime.Now;
			cmbTramite.SelectedIndex = -1;
			txtColonia.Text = "";
			cmFuente.SelectedIndex = -1;
			txtFuenteOperador.Text = "EXTERNO";
			cmbFuentePeriodico.SelectedIndex = -1;
			cmbFuenteInternet.SelectedIndex = -1;
			cmbFuentePeriodicoDia.SelectedIndex = -1;
			txtDualA.Text = "0";
			txtDualM.Text = "0";
			txtDirTraseraA.Text = "0"; 
			txtDirTraseraM.Text = "0"; 
			txtTransPersonalA.Text = "0";
			txtTransPersonalM.Text = "0";
			cmbTipoLicEstatal.SelectedIndex = -1;
			cmbTipoLicFederal.SelectedIndex = -1;
			lblEdad.Visible = false;
			lblFuenteNA.Visible = false;
			dgContacto.Rows.Clear();
			errorProvider1.Clear();
			btnAgregarContacto.Enabled = true;			
			
			if(DateTime.Now.AddDays(1).DayOfWeek.ToString().Equals("Sunday"))
				dtpFechaCita.Value = DateTime.Now.AddDays(2);
			else
				dtpFechaCita.Value = DateTime.Now.AddDays(1);
			dtpHoraCita.Text = "09:00";
			
			cleanContact();	
			cmbTipoOperador.SelectedIndex = 0;	
			cmbTipoOperador.Focus();
			cmbTipoOperador.Enabled = true;
			pnFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			lblIngreso.ForeColor = Color.Black;
			
			btnRegistrar.Visible = false;
			btnGuardar.Visible = true;
			getParametros();
			getZonasFuentes();
		}	
		
		private void cleanContact(){			
			cmbTipoContacto.SelectedIndex = 0;
			txtNumeroContacto.Text = "";
			cmbRelacionContacto.SelectedIndex = 0;
			txtNombreContacto.Text = "PROPIO";
			dgContacto.ClearSelection();
			cmbTipoContacto.Focus();			
			btnAgregarContacto.Text = "Agregar";
		}
		
		private void getParametros(){
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
		
		private void FiltersFuente(){
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
		
		private void validaCandidato(){
			int bandera = connO.getValidaOperador(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"));
			pnFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			lblIngreso.ForeColor = Color.Black;	
			btnAgregarContacto.Enabled = true;
			btnCancelarContacto.Enabled = true;
			btnGuardar.Enabled = true;
			btnRegistrar.Enabled = true;			
			btnRegistrar.Visible = false;
			btnGuardar.Visible = true;
			btnCancelar.Enabled = true;
			dtpFechaCita.Enabled = true;
			dtpHoraCita.Enabled = true;
				
			if(bandera == 0){
				int banderaPre = connO.getValidaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"));
				if(banderaPre == 0){
					lblIngreso.Text = "Nuevo Ingreso";
					cmbTipoOperador.Enabled = true;
				}
				else if(banderaPre == 1){	
					lblIngreso.Text = "Candidato Activo";
					lblIngreso.ForeColor = Color.Blue;
					btnAgregarContacto.Enabled = false;
					btnCancelarContacto.Enabled = false;
					cmbTipoOperador.Enabled = false;
					btnGuardar.Enabled = false;
					btnRegistrar.Enabled = false;
					btnCancelar.Enabled = false;				
				}else if(banderaPre == 2){
					lblIngreso.Text = "Candidato Rechazado";
					lblIngreso.ForeColor = Color.White;
					pnFondo.BackColor = Color.Red;
					
					btnAgregarContacto.Enabled = false;
					btnCancelarContacto.Enabled = false;
					cmbTipoOperador.Enabled = false;
					btnGuardar.Enabled = false;
					btnGuardar.Visible = false;
					btnRegistrar.Enabled = true;
					btnRegistrar.Visible = true;
					btnCancelar.Enabled = false;
					
					dtpFechaCita.Enabled = false;
					dtpHoraCita.Enabled = false;					
				}else if(banderaPre == 3){
					lblIngreso.Text = "Candidato por Contratar";				
					lblIngreso.ForeColor = Color.Blue;
					btnAgregarContacto.Enabled = false;
					btnCancelarContacto.Enabled = false;
					cmbTipoOperador.Enabled = false;
					btnGuardar.Enabled = false;
					btnRegistrar.Enabled = false;
					btnCancelar.Enabled = false;
				}else if(banderaPre == 4){
					lblIngreso.Text = "Llamada Cancelada";
					lblIngreso.ForeColor = Color.White;
					pnFondo.BackColor = Color.OrangeRed;
					cmbTipoOperador.Enabled = false;
				}else if(banderaPre == 5){
					lblIngreso.Text = "Bolsa de Trabajo";
				}else if(banderaPre == 6){
					lblIngreso.Text = "Bolsa de Trabajo";
				}else if(banderaPre == 7)
					lblIngreso.Text = "Llamada, Cita Activa";	
				else if(banderaPre == 8 || banderaPre == 9)
					lblIngreso.Text = "Bolsa de Trabajo Llamada";				
			}else if (bandera == 1){
				int banderaPre = connO.getValidaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"));				
				if(banderaPre == 0){
					lblIngreso.Text = "Reingreso Sin Control";
					cmbTipoOperador.Enabled = true;
					cmbTipoOperador.SelectedIndex = 2;
				}else if(banderaPre == 1){
					lblIngreso.Text = "Reingreso Candidato Activo";
					lblIngreso.ForeColor = Color.Blue;
					cmbTipoOperador.SelectedIndex = 2;
					btnAgregarContacto.Enabled = false;
					btnCancelarContacto.Enabled = false;
					cmbTipoOperador.Enabled = false;
					btnGuardar.Enabled = false;
					btnRegistrar.Enabled = false;
					btnCancelar.Enabled = false;
				}else if(banderaPre == 2){
					lblIngreso.Text = "Reingreso Candidato Rechazado";
					lblIngreso.ForeColor = Color.White;
					pnFondo.BackColor = Color.Red;
					btnAgregarContacto.Enabled = false;
					btnCancelarContacto.Enabled = false;
					cmbTipoOperador.Enabled = false;
					btnGuardar.Enabled = false;
					btnRegistrar.Enabled = false;
					btnCancelar.Enabled = false;
				}else if(banderaPre == 3){
					lblIngreso.Text = "Reingreso";						
					lblIngreso.ForeColor = Color.Blue;
					cmbTipoOperador.SelectedIndex = 2;
				}else if(banderaPre == 4){
					lblIngreso.Text = "Reingreso Llamada Cancelada";
					lblIngreso.ForeColor = Color.White;
					pnFondo.BackColor = Color.OrangeRed;
					cmbTipoOperador.SelectedIndex = 2;
				}else if(banderaPre == 5){
					lblIngreso.Text = "Reingreso Bolsa de Trabajo";
					cmbTipoOperador.SelectedIndex = 2;
				}else if(banderaPre == 6){
					lblIngreso.Text = "Reingreso Bolsa de Trabajo";
					cmbTipoOperador.SelectedIndex = 2;
				}
			}else if (bandera == 2){
				lblIngreso.Text = "Operador Activo";
				lblIngreso.ForeColor = Color.Blue;
				cmbTipoOperador.Enabled = false;
				btnAgregarContacto.Enabled = false;
				btnCancelarContacto.Enabled = false;
				cmbTipoOperador.Enabled = false;
				btnGuardar.Enabled = false;
			}		
		}		
				
		private void obtenerCandidato(){
			bool bandera = false;
			flagGet = true;
			string id_C = "", folio = "", consulta = "";
			if(lblIngreso.Text == "Candidato Activo" || lblIngreso.Text == "Candidato Rechazado" || lblIngreso.Text == "Reingreso" || lblIngreso.Text == "Candidato por Contratar" 
			   || lblIngreso.Text == "Llamada Cancelada" || lblIngreso.Text == "Bolsa de Trabajo" || lblIngreso.Text == "Llamada, Cita Activa" || lblIngreso.Text == "Bolsa de Trabajo Llamada"){
				//try{
					consulta = "SELECT * FROM PRE_OPERADOR WHERE NOMBRE = '"+txtNombre.Text+"' AND APELLIDO_PAT = '"+txtApellidoP.Text+"' AND APELLIDO_MAT = '"+txtApellidoM.Text+"'";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						id_C = conn.leer["id"].ToString();	
						id_preOperador = conn.leer["id"].ToString();					
						folio = conn.leer["FOLIO"].ToString();
						dtpNacimiento.Value = Convert.ToDateTime(conn.leer["FECHA_NACIMIENTO"]);
						cmbZona.Text = conn.leer["ZONA"].ToString();
						cmFuente.Text = conn.leer["FUENTE"].ToString();
						txtColonia.Text = conn.leer["COLONIA"].ToString();
						
						if(cmFuente.Text.Equals("RECOMENDACION"))
							txtFuenteOperador.Text = conn.leer["DETALLE_FUENTE"].ToString();
						else if(cmFuente.Text.Equals("PERIODICO")){
							cmbFuentePeriodico.Text = conn.leer["DETALLE_FUENTE"].ToString();
							cmbFuentePeriodicoDia.Text = conn.leer["DIA"].ToString();
						}else if(cmFuente.Text.Equals("PERIODICO"))
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
						
						cmbTramite.Text = conn.leer["TRAMITE"].ToString();
						if(cmbTramite.Text.Equals("BOLSA DE TRABAJO") && conn.leer["BT"].ToString().Equals("SI")){
							cmbMotivoSinCita.Text = conn.leer["MOTIVO_BT"].ToString();
							cbSinCita.Checked = true;
						}
						
						txtDualA.Text = conn.leer["DUAL"].ToString();
						txtDirTraseraA.Text = conn.leer["DIR_TRASERA"].ToString();
						txtTransPersonalA.Text = conn.leer["TRANSP_PERSONAL"].ToString();
						txtDualM.Text = conn.leer["DUALM"].ToString();
						txtDirTraseraM.Text = conn.leer["DIR_TRASERAM"].ToString();
						txtTransPersonalM.Text = conn.leer["TRANSP_PERSONALM"].ToString();
						cmbTipoLicEstatal.Text = conn.leer["TIPO_ESTATAL"].ToString();
						cmbTipoLicFederal.Text = conn.leer["TIPO_FEDERAL"].ToString();
						bandera = true;						
					}
					conn.conexion.Close();					
				/*}catch(Exception ex){
					MessageBox.Show("Error al obtener datos (error al llenar los campos del candidato): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
					conn.conexion.Close();	
					flagGet = false;					
				}*/
				if(bandera){
					dgContacto.Rows.Clear();
					//try{						
						ColoresAlternadosRows(dgContacto);
						consulta = "SELECT * FROM TELEFONOS_PRE_OPERADOR WHERE ESTATUS = 'Activo' and ID_PREOPERADOR = "+id_C+" and FOLIO = '"+folio+"'";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						while(conn.leer.Read())
							dgContacto.Rows.Add(conn.leer["ID"].ToString(),conn.leer["TIPO"].ToString(),conn.leer["NUMERO"].ToString(), conn.leer["RELACION"].ToString(), conn.leer["DESCRIPCION"].ToString());						
						conn.conexion.Close();	
					/*}catch(Exception ex){
						MessageBox.Show("Error al obtener teléfonos (error al llenar la tabla de contacto): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
						conn.conexion.Close();
						flagGet = false;						
					}*/
				}
					
				if(lblIngreso.Text == "Candidato Activo" && bandera){
					//try{
						consulta = "SELECT * FROM CITA_PRE_OPERADOR WHERE ID_PREOPERADOR = "+id_C+" and FOLIO = '"+folio+"'";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							dtpFechaCita.Value = Convert.ToDateTime(conn.leer["FECHA"]);
							dtpHoraCita.Text = conn.leer["HORA"].ToString().Substring(0,5);
							bandera = true;						
						}
						conn.conexion.Close();	
					/*}catch(Exception ex){
						MessageBox.Show("Error al obtener la fecha de la cita (error al llenar los campos de la cita): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
						conn.conexion.Close();
						flagGet = false;						
					}*/
				}					

				if(!bandera){
					//try{
						consulta = "SELECT FECHA_NACIMIENTO FROM OPERADOR WHERE NOMBRE = '"+txtNombre.Text+"' AND APELLIDO_PAT = '"+txtApellidoP.Text+"' AND APELLIDO_MAT = '"+txtApellidoM.Text+"'";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							dtpNacimiento.Value = Convert.ToDateTime(conn.leer["FECHA_NACIMIENTO"]);
							bandera = true;						
						}
						conn.conexion.Close();	
					/*}catch(Exception ex){
						MessageBox.Show("Error al obtener fecha de nacimiento del reingreso (error al llenar los campos del reingreso): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
						conn.conexion.Close();
						flagGet = false;						
					}*/
				}
			}
			dgContacto.ClearSelection();
			flagGet = false;
			if(!flagGet){
				if(txtFuenteOperador.Text == "EXTERNO")
					txtFuenteOperador.ResetBackColor();
				else if(connO.validaOperadorRecomendado(txtFuenteOperador.Text))
					txtFuenteOperador.BackColor = Color.LightGreen;
				else
					txtFuenteOperador.BackColor = Color.Red;
			}
			validaCandidato();
		}
		
		private bool validaContacto(){
			bool respuesta = true;
			
			errorProvider1.Clear();
			if(cmbTipoContacto.SelectedIndex == -1){
				errorProvider1.SetError(cmbTipoContacto, "Seleccione el tipo del número de contacto");
				cmbTipoContacto.Focus();
				respuesta = false;
			}
			if(txtNumeroContacto.Text.Length == 0){
				errorProvider1.SetError(txtNumeroContacto, "Ingresa el número del contacto");
				txtNumeroContacto.Focus();
				respuesta = false;
			}
			if(cmbRelacionContacto.SelectedIndex == -1){
				errorProvider1.SetError(cmbRelacionContacto, "Seleccione la relación del contacto");
				cmbRelacionContacto.Focus();
				respuesta = false;
			}
			if(txtNombreContacto.Text.Length == 0){
				errorProvider1.SetError(txtNombreContacto, "Ingresa el nombre del dueño del número de contacto");
				txtNombreContacto.Focus();
				respuesta = false;
			}
			return respuesta;
		}
				
		private bool ValidaInsertar(){
			bool respuesta = true;
			
			errorProvider1.Clear();
			if(cmbZona.SelectedIndex == -1){
				errorProvider1.SetError(cmbZona, "Ingresa la zona del solicitante");
				cmbZona.Focus();
				respuesta = false;
			}
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
			if(dtpNacimiento.Value.ToString("yyyy-MM-dd") == DateTime.Now.ToString("yyyy-MM-dd")){
				errorProvider1.SetError(dtpNacimiento, "Ingresa una fecha de nacimiento valida del solicitante");
				dtpNacimiento.Focus();
				respuesta = false;
			}
			if(dgContacto.RowCount == 0){
				errorProvider1.SetError(dgContacto, "Ingresa como mínimo un número de contacto del solicitante");
				cmbTipoContacto.Focus();
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
			   if(cmFuente.SelectedIndex == 0){
				if(txtFuenteOperador.Text.Length == 0){
					errorProvider1.SetError(txtFuenteOperador, "Ingresa el nombre del solicitante");
					txtFuenteOperador.Focus();
					respuesta = false;
				}
			}
			   * */
			if(txtColonia.Text.Length == 0){
				errorProvider1.SetError(txtColonia, "Ingresa la colonia del solicitante");
				txtColonia.Focus();
				respuesta = false;
			}
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
			    * */
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
			if(txtDualA.Text.Length == 0){
				errorProvider1.SetError(txtDualA, "Ingresa la experiencia del solicitante en dual");
				txtDualA.Focus();
				respuesta = false;
			}
			if(txtDirTraseraA.Text.Length == 0){
				errorProvider1.SetError(txtDirTraseraA, "Ingresa la experiencia del solicitante en dirección trasera");
				txtDirTraseraA.Focus();
				respuesta = false;
			}
			if(txtTransPersonalA.Text.Length == 0){
				errorProvider1.SetError(txtTransPersonalA, "Ingresa la experiencia del solicitante en el transporte del personal");
				txtTransPersonalA.Focus();
				respuesta = false;
			}
			if(cmbTipoLicEstatal.SelectedIndex == -1){
				errorProvider1.SetError(cmbTipoLicEstatal, "Selecciona el tipo de licencia estatal del solicitante");
				cmbTipoLicEstatal.Focus();
				respuesta = false;
			}
			if(cmbTipoLicFederal.SelectedIndex == -1){				
				errorProvider1.SetError(cmbTipoLicFederal, "Selecciona el tipo de licencia federal del solicitante");
				cmbTipoLicFederal.Focus();
				respuesta = false;
			}
			if(cmbTramite.SelectedIndex == -1){				
				errorProvider1.SetError(cmbTramite, "Selecciona el tipo de tramite del solicitante");
				cmbTramite.Focus();
				respuesta = false;
			}
			return respuesta;
		}
		
		private void guardaRegistro(){			
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
			if(lblIngreso.Text == "Nuevo Ingreso"){
				if(connO.insertarLlamada(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"), cmFuente.Text, detalleFuente, 
				                         ((cmFuente.Text.Equals("PERIODICO"))? cmbFuentePeriodicoDia.Text: "0" ), cmbZona.Text, dtpFechaCita.Value.ToString("yyyy-MM-dd"),
				                         dtpHoraCita.Value.ToString("HH:mm"), txtDualA.Text, txtDualM.Text, txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, 
				                         txtTransPersonalM.Text, cmbTipoLicEstatal.Text, cmbTipoLicFederal.Text, id_usuario, dgContacto, cmbTramite.Text, "LLAMADA", "NUEVO", 
				                         cmbTipoOperador.Text, txtColonia.Text, ((cbSinCita.Checked)? "SI" : "NO"),  ((cbSinCita.Checked)? cmbMotivoSinCita.Text : "") )){
					MessageBox.Show("Se agregó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);		
					clean();
				}
			}else if(lblIngreso.Text == "Candidato Activo"){
				MessageBox.Show("El candidato esta en proceso de contratación ve al módulo correspondiente", "Candidato Activo", MessageBoxButtons.OK, MessageBoxIcon.Information);						
			}else if(lblIngreso.Text == "Candidato por Contratar"){
				MessageBox.Show("El candidato esta en proceso de contratación ve al módulo correspondiente", "Candidato por Contratar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else if(lblIngreso.Text == "Operador Activo"){
				MessageBox.Show("El candidato esta contratado ve al módulo correspondiente", "Operador Activo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else if(lblIngreso.Text == "Reingreso Sin Control"){
				if(connO.insertarLlamada(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"), cmFuente.Text, detalleFuente, 
				                         ((cmFuente.Text.Equals("PERIODICO"))? cmbFuentePeriodicoDia.Text: "0" ), cmbZona.Text, dtpFechaCita.Value.ToString("yyyy-MM-dd"),
				                         dtpHoraCita.Value.ToString("HH:mm"), txtDualA.Text, txtDualM.Text, txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, 
				                         txtTransPersonalM.Text, cmbTipoLicEstatal.Text, cmbTipoLicFederal.Text, id_usuario, dgContacto, cmbTramite.Text, "LLAMADA", "NUEVO", 
				                         cmbTipoOperador.Text, txtColonia.Text, ((cbSinCita.Checked)? "SI" : "NO"),  ((cbSinCita.Checked)? cmbMotivoSinCita.Text : "") )){
					MessageBox.Show("Se agregó correctamente el registro", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);		
					clean();
				}
			}else if(lblIngreso.Text == "Llamada, Cita Activa"){
				if(connO.updateLlamada(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"), cmFuente.Text, detalleFuente, 
				                         ((cmFuente.Text.Equals("PERIODICO"))? cmbFuentePeriodicoDia.Text: "0" ), cmbZona.Text, dtpFechaCita.Value.ToString("yyyy-MM-dd"),
				                         dtpHoraCita.Value.ToString("HH:mm"), txtDualA.Text, txtDualM.Text, txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, 
				                         txtTransPersonalM.Text, cmbTipoLicEstatal.Text, cmbTipoLicFederal.Text, id_usuario, dgContacto, cmbTramite.Text, 
				                         cmbTipoOperador.Text, txtColonia.Text, ((cbSinCita.Checked)? "SI" : "NO"),  ((cbSinCita.Checked)? cmbMotivoSinCita.Text : ""), Convert.ToInt64(id_preOperador) )){
					MessageBox.Show("Se modifico los datos correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);		
					clean();
				}
			}else if(lblIngreso.Text == "Bolsa de Trabajo Llamada"){
				if(connO.updateLlamada(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"), cmFuente.Text, detalleFuente, 
				                         ((cmFuente.Text.Equals("PERIODICO"))? cmbFuentePeriodicoDia.Text: "0" ), cmbZona.Text, dtpFechaCita.Value.ToString("yyyy-MM-dd"),
				                         dtpHoraCita.Value.ToString("HH:mm"), txtDualA.Text, txtDualM.Text, txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, 
				                         txtTransPersonalM.Text, cmbTipoLicEstatal.Text, cmbTipoLicFederal.Text, id_usuario, dgContacto, cmbTramite.Text, 
				                         cmbTipoOperador.Text, txtColonia.Text, ((cbSinCita.Checked)? "SI" : "NO"),  ((cbSinCita.Checked)? cmbMotivoSinCita.Text : ""), Convert.ToInt64(id_preOperador) )){
					MessageBox.Show("Se modifico los datos correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);		
					clean();
				}
			}else if(lblIngreso.Text == "Bolsa de Trabajo"){
				if(connO.updateLlamada(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd"), cmFuente.Text, detalleFuente, 
				                         ((cmFuente.Text.Equals("PERIODICO"))? cmbFuentePeriodicoDia.Text: "0" ), cmbZona.Text, dtpFechaCita.Value.ToString("yyyy-MM-dd"),
				                         dtpHoraCita.Value.ToString("HH:mm"), txtDualA.Text, txtDualM.Text, txtDirTraseraA.Text, txtDirTraseraM.Text, txtTransPersonalA.Text, 
				                         txtTransPersonalM.Text, cmbTipoLicEstatal.Text, cmbTipoLicFederal.Text, id_usuario, dgContacto, cmbTramite.Text, 
				                         cmbTipoOperador.Text, txtColonia.Text, ((cbSinCita.Checked)? "SI" : "NO"),  ((cbSinCita.Checked)? cmbMotivoSinCita.Text : ""), Convert.ToInt64(id_preOperador) )){
					MessageBox.Show("Se modifico los datos correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);		
					clean();
				}
			}
			/*
			else if(lblIngreso.Text == "Llamada Cancelada"){
				//if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
					
				//}
			}else if(lblIngreso.Text == "Bolsa de Trabajo"){
				//if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
				//	
				}
			}else if(lblIngreso.Text == "Reingreso"){
				//if(ModificaRegistro( "REINGRESO",  "INICIALES", 0 )){
					
				//}
			}else if(lblIngreso.Text == "Reingreso Llamada Cancelada"){
				//if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
				//	
				//}
			}else if(lblIngreso.Text == "Reingreso Bolsa de Trabajo"){
				//if(ModificaRegistro( connO.getEstatus(ID_PREOPERADOR),  ((connO.getFlujo(ID_PREOPERADOR) == "LLAMADA")? "INICIALES" : connO.getFlujo(ID_PREOPERADOR) ), 0 )){
					
				//}
			}*/
		}
		
		private void ColoresAlternadosRows(DataGridView datag){
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
				
		private void messageZona(){
			if(txtColonia.Text.Length > 0 && cmbZona.Text.Length > 0  && txtDualA.Text.Length > 0 )
				btnMessageZona.Enabled = true;
			else
				btnMessageZona.Enabled = false;
		}
		#endregion	
		
		#region BOTONES	
		void BtnCancelarClick(object sender, EventArgs e)
		{
			clean();
		}
		
		void BtnAgregarContactoClick(object sender, EventArgs e)
		{
			if(validaContacto()){
				ColoresAlternadosRows(dgContacto);
				if(btnAgregarContacto.Text == "Agregar")
					dgContacto.Rows.Add("0", cmbTipoContacto.Text, txtNumeroContacto.Text, cmbRelacionContacto.Text, txtNombreContacto.Text);
				else{
					dgContacto[1,dgContacto.CurrentCell.RowIndex].Value = cmbTipoContacto.Text;
					dgContacto[2,dgContacto.CurrentCell.RowIndex].Value = txtNumeroContacto.Text;
					dgContacto[3,dgContacto.CurrentCell.RowIndex].Value = cmbRelacionContacto.Text;
					dgContacto[4,dgContacto.CurrentCell.RowIndex].Value = txtNombreContacto.Text;
					btnAgregarContacto.Text = "Agregar";
				}
				cleanContact();
				cmbTramite.Focus();
			}
		}
				
		void BtnCancelarContactoClick(object sender, EventArgs e)
		{
			cleanContact();
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(ValidaInsertar()){
				if(!flagDefaultCita && cbSinCita.Checked == false){
					DialogResult rs = MessageBox.Show(@"La cita está como predeterminada se agendara para mañana a las 9:00. ¿Deseas agendarla ? ", "Cita Predeterminada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes == rs){
						guardaRegistro();
						flagDefaultCita = false;
					}else
						dtpFechaCita.Focus();	
				}else{
					guardaRegistro();
				}
			}
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnMessageZonaClick(object sender, EventArgs e)
		{
			try{			
				string message = "*SELECCIÓN DE OPERADOR* \n*Zona:* " + cmbZona.Text + " \n*Colonia:* "+txtColonia.Text+ "\n*_Operador de "+(( Convert.ToDouble(txtDualA.Text) >= Convert.ToDouble(parametros.expDual))? "CAMIÓN" : "CAMIONETA")+"_*";
				string message2 = "SELECCIÓN DE OPERADOR \nZona: " + cmbZona.Text + " \nColonia: "+txtColonia.Text+ "\nOperador de "+(( Convert.ToDouble(txtDualA.Text) >= Convert.ToDouble(parametros.expDual))? "CAMIÓN" : "CAMIONETA")+"";
				Clipboard.Clear();
				Clipboard.SetDataObject(message);			 	
				MessageBox.Show("Se generó mensaje para Whatsapp,\n\n"+message2+"\n\nCopiarlo en el grupo pertienente", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de Whatsapp de la autorización: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		
		#region EVENTOS
		void FormLlamadaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		
		void CmbTipoOperadorSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipoOperador.SelectedIndex > 0){
				gbProgramacion.Enabled = true;
				txtNombre.Focus();
			}else
				gbProgramacion.Enabled = false;				
		}		
		
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			if(txtNombre.Text.Length > 0 && !flagGet)
				validaCandidato();
		}
		
		void TxtApellidoMTextChanged(object sender, EventArgs e)
		{			
			if(txtApellidoM.Text.Length > 0  && !flagGet)
				validaCandidato();
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0 && txtApellidoM.Text.Length > 0 && !flagGet)
				obtenerCandidato();
		}
		
		void TxtApellidoPTextChanged(object sender, EventArgs e)
		{			
			if(txtApellidoP.Text.Length > 0 && !flagGet)
				validaCandidato();
		}
		
		void TxtNombreLeave(object sender, EventArgs e)
		{
			txtNombre.Text = txtNombre.Text.Trim();
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0 && !flagGet)
				obtenerCandidato();
		}
		
		void TxtApellidoPLeave(object sender, EventArgs e)
		{
			txtApellidoP.Text = txtApellidoP.Text.Trim();
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0 && !flagGet)
				obtenerCandidato();
		}
		
		void TxtApellidoMLeave(object sender, EventArgs e)
		{
			txtApellidoM.Text = txtApellidoM.Text.Trim();
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0 && txtApellidoM.Text.Length > 0 && !flagGet){
				obtenerCandidato();
			}
		}		
		
		void CmFuenteSelectedIndexChanged(object sender, EventArgs e)
		{			
			FiltersFuente();
		}
		
		void TxtDescContactoClick(object sender, EventArgs e)
		{
			if(txtNombreContacto.Text == "PROPIO")
				txtNombreContacto.SelectAll();			
		}
		
		void DtpNacimientoValueChanged(object sender, EventArgs e)
		{		
			Edad();
		}
						
		void DtpFechaCitaValueChanged(object sender, EventArgs e)
		{
			flagDefaultCita = true;
		}
		
		void DtpHoraCitaValueChanged(object sender, EventArgs e)
		{			
			flagDefaultCita = true;
		}
		
		void TxtDualATextChanged(object sender, EventArgs e)
		{
			messageZona();
		}
		
		void TxtDualMTextChanged(object sender, EventArgs e)
		{
			if(txtDualM.Text.Length == 2)
				txtDirTraseraA.Focus();
			messageZona();
		}
		
		void TxtDirTraseraATextChanged(object sender, EventArgs e)
		{			
			if(txtDirTraseraA.Text.Length == 2)
				txtDirTraseraM.Focus();
		}
		
		void TxtDirTraseraMTextChanged(object sender, EventArgs e)
		{
			if(txtDirTraseraM.Text.Length == 2)
				txtTransPersonalA.Focus();
		}
		
		void TxtTransPersonalATextChanged(object sender, EventArgs e)
		{
			if(txtTransPersonalA.Text.Length == 2)
				txtTransPersonalM.Focus();
		}
			
		void TxtColoniaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbZonaSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtTransPersonalMTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void DgContactoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgContacto.SelectedRows.Count == 1 && e.RowIndex > -1){
				cmbTipoContacto.Text = dgContacto[1,e.RowIndex].Value.ToString();
				txtNumeroContacto.Text = dgContacto[2,e.RowIndex].Value.ToString();
				cmbRelacionContacto.Text = dgContacto[3,e.RowIndex].Value.ToString();
				txtNombreContacto.Text = dgContacto[4,e.RowIndex].Value.ToString();
				btnAgregarContacto.Text = "Modificar";
			}
		}		
				
		void CmbTipoLicEstatalSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipoLicEstatal.SelectedIndex > 0 && cmbTipoLicFederal.SelectedIndex == -1)
				cmbTipoLicFederal.SelectedIndex = 0;
		}
		
		void CmbTipoLicFederalSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipoLicFederal.SelectedIndex > 0 && cmbTipoLicEstatal.SelectedIndex == -1)
				cmbTipoLicEstatal.SelectedIndex = 0;
		}
		
		void LblIngresoDoubleClick(object sender, EventArgs e)
		{
			
		}
		
		void CmbTramiteSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTramite.Text.Equals("BOLSA DE TRABAJO")){				
				cbSinCita.Visible = true;
			}else{
				cbSinCita.Visible = false;
				cbSinCita.Checked = false;
			}
		}
		
		void CbSinCitaCheckedChanged(object sender, EventArgs e)
		{
			if(cbSinCita.Checked){
				label19.Visible = true;
				cmbMotivoSinCita.Visible = true;
				dtpFechaCita.Enabled = false;
				dtpHoraCita.Enabled = false;
			}else{
				cmbMotivoSinCita.Visible = false;
				label19.Visible = false;
				cmbMotivoSinCita.Text = "";
				dtpFechaCita.Enabled = true;
				dtpHoraCita.Enabled = true;
			}
		}
		
		void CmbMotivoSinCitaClick(object sender, EventArgs e)
		{
			if(!flagMotivo)
				new FormMotivoBT(this).ShowDialog();
		}
		
		void CmbTramiteLeave(object sender, EventArgs e)
		{
			if(cmbTramite.Text == "BOLSA DE TRABAJO")
				cbSinCita.Focus();
			else
				dtpFechaCita.Focus();
		}
		
		void CmbMotivoSinCitaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Return)
				new FormMotivoBT(this).ShowDialog();
		}
		
		void TxtFuenteOperadorTextChanged(object sender, EventArgs e)
		{
			if(!flagGet){
				if(txtFuenteOperador.Text == "EXTERNO")
					txtFuenteOperador.ResetBackColor();
				else if(connO.validaOperadorRecomendado(txtFuenteOperador.Text))
					txtFuenteOperador.BackColor = Color.LightGreen;
				else
					txtFuenteOperador.BackColor = Color.Red;
			}
		}
		
		void TxtFuenteOperadorLeave(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtFuenteOperador.BackColor == Color.Red){
				errorProvider1.SetError(txtFuenteOperador, "Ingresa un operador valido");
				txtFuenteOperador.Focus();
			}
		}
		
		void TxtDualALeave(object sender, EventArgs e)
		{
			messageZona();
			btnMessageZona.Focus();
		}
		
		void LblTodosDoubleClick(object sender, EventArgs e)
		{
			if(lblIngreso.Text.Contains("REINGRESO") || lblIngreso.Text.Contains("Reingreso") || lblIngreso.Text.Contains("reingreso") || cmbTipoOperador.SelectedIndex == 2){
				try{				
					String datos = "Favor de revisar reingreso de \n *"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+"*";	
					String datos2 = "Favor de revisar reingreso de \n"+txtNombre.Text+" "+txtApellidoP.Text+" "+txtApellidoM.Text+"";				
					Clipboard.Clear();
				 	Clipboard.SetDataObject(datos);
					MessageBox.Show("Se generó mensaje para Whatsapp,\n"+datos2+",\nCopiarlo en el grupo pertienente.", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}catch(Exception ex){
					MessageBox.Show("Error al general mensaje de Whatsapp: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		void DtpNacimientoLeave(object sender, EventArgs e)
		{			
			txtDualA.Focus();
		}
		
		void BtnMessageZonaLeave(object sender, EventArgs e)
		{			
			txtDirTraseraA.Focus();
		}
		#endregion
	}
}
