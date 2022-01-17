using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormRegistar : Form
	{		
		#region VARIABLES
		int id_usuario;
		Int64 ID_PREOPERADOR = 0;
		#endregion
		
		#region INSTANCIAS
		public Dato.Parametros parametros;
		private FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES		
		public FormRegistar(FormPrincipal refprincipal, int id_usu)
		{
			InitializeComponent();
			this.principal = refprincipal;
			id_usuario = id_usu;
		}
		#endregion
		
		#region INICIO - FIN
		void FormRegistarLoad(object sender, EventArgs e)
		{
			inicio();			
			
			if(principal.lblDatoNivel.Text != "MASTER" || principal.lblDatoNivel.Text !="ADMINISTRATIVO")
				new FormMensajes("Solicité la Licencia de Conducir al Candidato.").Show();
		}
				
		void FormRegistarFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.contratacionRegistrar = false;
		}
		#endregion
		
		#region METODOS
		private void inicio(){
			cmbTipoOperador.SelectedIndex = 0;	
			cmbTipoOperador.Focus();
			cmbTipoOperador.Enabled = true;
			
            
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
			
			getParametros();
			getZonasFuentes();
		}		
		#endregion	
		
		#region BOTONES		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(ValidaInsertar())
				principal.openContrataciones(this);
		}
				
		void BtnLimpiarAIClick(object sender, EventArgs e)
		{
			limpiarCamposAI();
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
			//principal.openContratacionesAll();
			//this.Close();
		}				
		
		void BtnMessageZonaClick(object sender, EventArgs e)
		{
			try{			
				string message = "*SELECCIÓN DE OPERADOR* \n*Zona:* " + cmbZona.Text + " \n*Colonia:* "+txtColonia.Text+ "\n*_Operador de "+(( Convert.ToDouble(txtDualA.Text) >= Convert.ToDouble(parametros.expDual))? "CAMIÓN" : "CAMIONETA")+"_*";
				string message2 = "Atlas SELECCIÓN DE OPERADOR \nZona: "+ cmbZona.Text + " \nColonia: "+txtColonia.Text+ "\nOperador de "+(( Convert.ToDouble(txtDualA.Text) >= Convert.ToDouble(parametros.expDual))? "CAMIÓN" : "CAMIONETA")+"";
				Clipboard.Clear();
				Clipboard.SetDataObject(message);			 	
			MessageBox.Show("Se generó mensaje para Whatsapp,\n\n"+message2+"\n\nCopiarlo en el grupo pertienente", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de Whatsapp de la autorización: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
		#endregion
		
		#region EVENTOS		
		void CmbZonaLeave(object sender, EventArgs e)
		{
			txtDualA.Focus();
		}
		
		void CmbTipoOperadorSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipoOperador.SelectedIndex > 0)
				pnAspectosIniciales.Enabled = true;			
			else
				pnAspectosIniciales.Enabled = false;			
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
			if(txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0 && txtApellidoM.Text.Length > 0)		
				obtenerCandidatoAI(false);
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
		
		void TxtNombreTextChanged(object sender, EventArgs e)
		{			
			if(txtNombre.Text.Length > 0)
				validaCandidato();
		}
		
		void TxtApellidoPTextChanged(object sender, EventArgs e)
		{
			if(txtApellidoM.Text.Length > 0)
				validaCandidato();
		}
		
		void TxtApellidoMTextChanged(object sender, EventArgs e)
		{
			if(txtApellidoP.Text.Length > 0)
				validaCandidato();
		}
		
		void LblIngresoDoubleClick(object sender, EventArgs e)
		{
			
		}
		
		void TxtColoniaTextChanged(object sender, EventArgs e)
		{
		}
		
		void CmbZonaSelectedIndexChanged(object sender, EventArgs e)
		{
		}
		
		void TxtDualATextChanged(object sender, EventArgs e)
		{
			messageZona();
		}
		
		void TxtDualMTextChanged(object sender, EventArgs e)
		{
			messageZona();
		}					
		
		void TxtDualALeave(object sender, EventArgs e)
		{
			messageZona();
			btnMessageZona.Focus();
		}
		
		void TxtDirTraseraATextChanged(object sender, EventArgs e)
		{
		}
		
		void TxtDirTraseraMTextChanged(object sender, EventArgs e)
		{
		}
		
		void TxtTransPersonalATextChanged(object sender, EventArgs e)
		{
		}
		
		void TxtTransPersonalMTextChanged(object sender, EventArgs e)
		{
		}
		
		void BtnMessageZonaLeave(object sender, EventArgs e)
		{
			txtDirTraseraA.Focus();
		}
		#endregion
		
		#region METODOS
		private void obtenerCandidatoAI(bool tipoOperador){
			string consulta = "";			
			cmbTipoLicFederal.SelectedIndex = -1;
			cmbEstadoEstatal.SelectedIndex = -1;
			cmbEstadoFederal.SelectedIndex = -1;
			cmbTipoLicEstatal.SelectedIndex = -1;				
			ID_PREOPERADOR = connO.getIDCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, "2000-06-29");		
			try{
				consulta ="SELECT * FROM PRE_OPERADOR WHERE ID = "+ID_PREOPERADOR;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){				
					txtNombre.Text = conn.leer["NOMBRE"].ToString();
					txtApellidoP.Text = conn.leer["APELLIDO_PAT"].ToString();
					txtApellidoM.Text = conn.leer["APELLIDO_MAT"].ToString();					
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
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos del candidato): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				if(conn.conexion != null)
					conn.conexion.Close();				
			}
		}
		
		public void limpiarCamposAI(){
			ID_PREOPERADOR = 0;
			txtNombre.Text = "";
			txtApellidoP.Text = "";
			txtApellidoM.Text = "";
			
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
			
			txtColonia.Text = "";
			cmbZona.SelectedIndex = -1;
			
			cmbTipoOperador.SelectedIndex = 0;
			errorProvider1.Clear();			
			
			pnFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			lblIngreso.ForeColor = Color.Black;
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
			if(txtColonia.Text.Length == 0){
				errorProvider1.SetError(txtColonia, "Ingresa la colonia del solicitante");
				txtColonia.Focus();
				respuesta = false;
			}		
			if(cmbZona.SelectedIndex == -1){
				errorProvider1.SetError(cmbZona, "Ingresa la zona del solicitante");
				cmbZona.Focus();
				respuesta = false;
			}			
			return respuesta;
		}
		
		private void validaCandidato(){
			int bandera = connO.getValidaOperador(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, "2000-06-06");
			pnFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			lblIngreso.ForeColor = Color.Black;				
				
			if(bandera == 0){
				int banderaPre = connO.getValidaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, "2000-06-06");
				if(banderaPre == 0){
					lblIngreso.Text = "Nuevo Ingreso";
					cmbTipoOperador.Enabled = true;
				}else if(banderaPre == 1){	
					lblIngreso.Text = "Candidato Activo";
					lblIngreso.ForeColor = Color.Blue;
					cmbTipoOperador.Enabled = false;	
				}else if(banderaPre == 2){
					lblIngreso.Text = "Candidato Rechazado";
					lblIngreso.ForeColor = Color.White;
					pnFondo.BackColor = Color.Red;					
					cmbTipoOperador.Enabled = false;										
				}else if(banderaPre == 3){
					lblIngreso.Text = "Candidato por Contratar";				
					lblIngreso.ForeColor = Color.Blue;
					cmbTipoOperador.Enabled = false;
				}else if(banderaPre == 4){
					lblIngreso.Text = "Llamada Cancelada";
					lblIngreso.ForeColor = Color.White;
					pnFondo.BackColor = Color.OrangeRed;
					cmbTipoOperador.Enabled = false;
				}else if(banderaPre == 5){
					lblIngreso.Text = "Bolsa de Trabajo";
				}else if(banderaPre == 6){
					lblIngreso.Text = "Bolsa de Trabajo";
				}
			}else if (bandera == 1){
				int banderaPre = connO.getValidaCandidato(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, "2000-06-06");				
				if(banderaPre == 0){
					lblIngreso.Text = "Reingreso Sin Control";
					cmbTipoOperador.Enabled = true;
					cmbTipoOperador.SelectedIndex = 2;
				}else if(banderaPre == 1){
					lblIngreso.Text = "Reingreso Candidato Activo";
					lblIngreso.ForeColor = Color.Blue;
					cmbTipoOperador.SelectedIndex = 2;
					cmbTipoOperador.Enabled = false;
				}else if(banderaPre == 2){
					lblIngreso.Text = "Reingreso Candidato Rechazado";
					lblIngreso.ForeColor = Color.White;
					pnFondo.BackColor = Color.Red;
					cmbTipoOperador.Enabled = false;
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
			}		
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
		}
			
		private void messageZona(){
			if(txtColonia.Text.Length > 0 && cmbZona.Text.Length > 0  && txtDualA.Text.Length > 0)
				btnMessageZona.Enabled = true;
			else
				btnMessageZona.Enabled = false;
		}
		#endregion	
	}
}
