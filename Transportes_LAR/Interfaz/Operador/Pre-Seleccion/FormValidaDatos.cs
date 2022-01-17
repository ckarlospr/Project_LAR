using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormValidaDatos : Form
	{
		#region VARIABLES
		int id_usuario;
		Int64 id_preOperador;
		string tipo;
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();	
		String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
		#endregion
		
		#region CONSTRUCTORES
		public FormValidaDatos(FormContratacion refprincipal, int id_usu, string tip)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			id_preOperador = 0;
			tipo = tip;
		}
		public FormValidaDatos(FormContratacion refprincipal, int id_usu, Int64 id_pre, string tip)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			id_preOperador = id_pre;
			tipo = tip;
		}
		#endregion
		
		#region INICIO - FIN
		void FormValidaDatosLoad(object sender, EventArgs e)
		{
			inicio();
		}	
		#endregion
		
		#region BOTONES		
		void BtnAutorizacionClick(object sender, EventArgs e)
		{
			bool respuesta = false;/*
			if(tipo == "Candidato Activo" && id_preOperador > 0){
				if(contratacion.ModificaRegistro(connO.getFlujo(id_preOperador), connO.getEstatus(id_preOperador), 0 )){
					connO.validaCandidato( id_preOperador, connO.getFolio(id_preOperador).ToString(), "AUTORIZACIÓN", "DATOS", txtFolio.Text, "", "VALIDADO", id_usuario);
					respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MANEJO", dtpFechaCitaManejo.Value.ToString("yyyy-MM-dd"), dtpHoraCitaManejo.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
					respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MEDICO", dtpFechaCitaMedico.Value.ToString("yyyy-MM-dd"), dtpHoraCitaMedico.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
				}else
					respuesta = false;
			}else if(tipo == "Candidato Rechazado" && id_preOperador > 0){
				DialogResult rs = MessageBox.Show(@"El candidato fue rechazado anteriormente ¿Deseas guardar la información con nuevo folio para dar el seguimiento de contratación? /n
				Nota: Para mayor información da doble clic sobre la leyenda de Candidato Rechazado en la parte superior del formulario", "Candidato rechazado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs){				
					//if(contratacion.ModificaRegistro("DATOS", "RECHAZADO", 1)){
					if(contratacion.ModificaRegistro("SOLICITUD", "RECHAZADO", 1)){
						connO.validaCandidato( id_preOperador, connO.getFolio(id_preOperador).ToString(), "AUTORIZACIÓN", "DATOS", txtFolio.Text, "", "VALIDADO", id_usuario);
						respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MANEJO", dtpFechaCitaManejo.Value.ToString("yyyy-MM-dd"), dtpHoraCitaManejo.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
						respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MEDICO", dtpFechaCitaMedico.Value.ToString("yyyy-MM-dd"), dtpHoraCitaMedico.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
					}else
						respuesta = false;
				}
			}else if(tipo == "Nuevo Ingreso" && id_preOperador == 0){
				if(contratacion.InsertaRegistro("NUEVO")){
					id_preOperador = connO.obtenerIDCandidato();
					connO.validaCandidato( id_preOperador, connO.getFolio(id_preOperador).ToString(), "AUTORIZACIÓN", "DATOS", txtFolio.Text, "", "DATOS", id_usuario);
					respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MANEJO", dtpFechaCitaManejo.Value.ToString("yyyy-MM-dd"), dtpHoraCitaManejo.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
					respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MEDICO", dtpFechaCitaMedico.Value.ToString("yyyy-MM-dd"), dtpHoraCitaMedico.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
				}else
					respuesta = false;					
			}else if(tipo == "Reingreso"){
				if(connO.getValidaCandidato(contratacion.txtNombre.Text, contratacion.txtApellidoP.Text, contratacion.txtApellidoM.Text, dtpNacimiento.Value.ToString("yyyy-MM-dd")) == 0){
					if(contratacion.InsertaRegistro("REINGRESO")){
						id_preOperador = connO.obtenerIDCandidato();
						connO.validaCandidato( id_preOperador, connO.getFolio(id_preOperador).ToString() , "AUTORIZACIÓN", "DATOS", txtFolio.Text, "", "VALIDADO", id_usuario);
						respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MANEJO", dtpFechaCitaManejo.Value.ToString("yyyy-MM-dd"), dtpHoraCitaManejo.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
						respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MEDICO", dtpFechaCitaMedico.Value.ToString("yyyy-MM-dd"), dtpHoraCitaMedico.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
					}else
						respuesta = false;
				}else{
					if(contratacion.ModificaRegistro("SOLICITUD", "REINGRESO", 1)){
						connO.validaCandidato( id_preOperador, connO.getFolio(id_preOperador).ToString(), "AUTORIZACIÓN", "DATOS", txtFolio.Text, "", "VALIDADO", id_usuario);
						respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MANEJO", dtpFechaCitaManejo.Value.ToString("yyyy-MM-dd"), dtpHoraCitaManejo.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
						respuesta = connO.insertarCita(id_preOperador, connO.getFolio(id_preOperador).ToString(), "MEDICO", dtpFechaCitaMedico.Value.ToString("yyyy-MM-dd"), dtpHoraCitaMedico.Value.ToString("HH:mm"), id_usuario, "ACTIVA");
					}else
						respuesta = false;
				}
			}*/
			
			if(respuesta){
				contratacion.copySpech(dtpFechaCitaManejo.Value.ToString("dd/MM/yyyy"), dtpHoraCitaManejo.Value.ToString("HH:mm"), dtpFechaCitaMedico.Value.ToString("dd/MM/yyyy"), dtpHoraCitaMedico.Value.ToString("HH:mm"));
				contratacion.filtrosLlamadas();
				contratacion.filtrosSolicitudes();
				contratacion.limpiarCamposAI();
				contratacion.limpiaFiltrosOperador();
				MessageBox.Show("Se validó correctamente los datos del candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}		
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS	
		void TxtFolioTextChanged(object sender, EventArgs e)
		{
			if(txtFolio.Text.Length > 0){
				gbCitas.Enabled = true;
				btnValida.Enabled = true;
			}else{				
				gbCitas.Enabled = false;
				btnValida.Enabled = false;
			}
		}
		
		void DtpFechaCitaManejoValueChanged(object sender, EventArgs e)
		{
			dtpFechaCitaMedico.Value = dtpFechaCitaManejo.Value;
		}
		
		void DtpHoraCitaManejoValueChanged(object sender, EventArgs e)
		{			
			dtpHoraCitaMedico.Value = dtpHoraCitaManejo.Value;
		}
		
		void FormValidaDatosKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
		
		#region METODOS		
		private void inicio(){
			lblNombre.Text = contratacion.txtNombre.Text+" "+contratacion.txtApellidoP.Text+" "+contratacion.txtApellidoM.Text;
			dtpNacimiento.Value = contratacion.dtpNacimiento.Value;
			cmbZona.Text = contratacion.cmbZona.Text;
			cmbTatuajes.Text = contratacion.cmbTatuajes.Text;
			txtDual.Text = contratacion.txtDualA.Text;
			txtDirTrasera.Text = contratacion.txtDirTraseraA.Text;
			txtTransPersonal.Text = contratacion.txtTransPersonalA.Text;
			
			cmbTipoLicEstatal.Text = contratacion.cmbTipoLicEstatal.Text;
			dtpVigenciaLicEstatal.Text = contratacion.dtpVigenciaLicEstatal.Text;
			cmbTipoLicFederal.Text = contratacion.cmbTipoLicFederal.Text;
			dtpVigenciaLicFederal.Text = contratacion.dtpVigenciaLicFederal.Text;
			dtpVigenciaLicAptoMedico.Text = contratacion.dtpVigenciaLicAptoMedico.Text;
			Edad();
			
			ValidaDatos();
		}
								
		private void Edad(){
			if(dtpNacimiento.Value < DateTime.Now.AddDays(-1)){
				int edad = (DateTime.Today.AddTicks(-dtpNacimiento.Value.Ticks).Year - 1);
				
				if(edad > 0){
					lblEdad.Text = edad.ToString();
					lblEdad.Visible = true;
					lblEdad.ForeColor = ((edad < 23 || edad > 45 )? Color.Red: Color.Black);
				}else{
					lblEdad.Visible = false;
				}
			}				
		}
		
		private bool ValidaDatos(){
			bool respuesta = true;
			
			if( Convert.ToInt16(lblEdad.Text) < Convert.ToInt16(contratacion.parametros.edadMin)  || Convert.ToInt16(lblEdad.Text) > Convert.ToInt16(contratacion.parametros.edadMax)  ){
				errorProvider1.SetError(dtpNacimiento, "La edad del candidato");
				respuesta = false;
			}
			if(contratacion.parametros.tatuajes != cmbTatuajes.Text){
				errorProvider1.SetError(cmbTatuajes, "El candidato tiene tatuajes");
				respuesta = false;
			}
			if(Convert.ToInt16(txtDual.Text) < Convert.ToInt16(contratacion.parametros.expDual)){
				errorProvider1.SetError(txtDual, "El candidato no tiene la experiencia en dual necesaria");
				respuesta = false;
			}
			if(Convert.ToInt16(txtDirTrasera.Text) < Convert.ToInt16(contratacion.parametros.expDirTrasera)){
				errorProvider1.SetError(txtDirTrasera, "El candidato no tiene la experiencia en dirección trasera necesaria");
				respuesta = false;
			}
			if(Convert.ToInt16(txtTransPersonal.Text) < Convert.ToInt16(contratacion.parametros.expTransPersonal)){
				errorProvider1.SetError(txtTransPersonal, "El candidato no tiene la experiencia en transporte de personal necesaria");
				respuesta = false;
			}
			if(contratacion.parametros.licEstatal != "TODAS" && cmbTipoLicEstatal.SelectedIndex > 0 ){
				if(cmbTipoLicEstatal.Text != contratacion.parametros.licEstatal){
					errorProvider1.SetError(cmbTipoLicEstatal, "El candidato no tiene el tipo de licencia estatal necesaria");
					respuesta = false;
				}
			}
			if(contratacion.parametros.licFederal != "TODAS" && cmbTipoLicFederal.SelectedIndex > 0 ){
				if(cmbTipoLicFederal.Text != contratacion.parametros.licFederal){
					errorProvider1.SetError(cmbTipoLicFederal, "El candidato no tiene el tipo de licencia federal necesaria");
					respuesta = false;
				}
			}
			if(DateTime.Now.AddMonths(Convert.ToInt16(contratacion.parametros.vigEstatal)) >= dtpVigenciaLicEstatal.Value && cmbTipoLicEstatal.SelectedIndex > 0 ){
				errorProvider1.SetError(dtpVigenciaLicEstatal, "La Vigencia no cumple con la mínima necesaria");
				respuesta = false;
			}
			if(DateTime.Now.AddMonths(Convert.ToInt16(contratacion.parametros.vigFederal)) >= dtpVigenciaLicFederal.Value && cmbTipoLicFederal.SelectedIndex > 0 ){
				errorProvider1.SetError(dtpVigenciaLicFederal, "La Vigencia no cumple con la mínima necesaria");
				respuesta = false;
			}			
			if(DateTime.Now.AddMonths(Convert.ToInt16(contratacion.parametros.vigAptoMedico)) >= dtpVigenciaLicAptoMedico.Value && contratacion.txtNumLicAptoMedico.Text.Length > 0){
				errorProvider1.SetError(dtpVigenciaLicAptoMedico, "La Vigencia no cumple con la mínima necesaria");
				respuesta = false;
			}
			
			if(!respuesta)
				lblValidaDatos.Text = "El candidato no cumple los requisitos establecidos";
			else
				lblValidaDatos.Text = "";
			
			return respuesta;
		}
		#endregion
	}
}
