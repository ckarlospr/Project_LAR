using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormValidaCitas : Form
	{
		#region VARIABLES
		int id_usuario;
		Int64 id_CitaManejo;
		Int64 id_CitaMedica;
		Int64 ID_PREOPERADOR;
		string folio;
		string bandera; // medica, manejo, todas
		string banderaManejo;
		string banderaMedico;
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES
		public FormValidaCitas(FormContratacion refprincipal, int id_usu, Int64 PREOPERADOR, Int64 CitaManejo, Int64 CitaMedica, string folio, string bandera)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			id_CitaManejo = CitaManejo;
			id_CitaMedica = CitaMedica;
			this.folio = folio;
			this.bandera = bandera;
			ID_PREOPERADOR = PREOPERADOR;
		}
		#endregion
		
		#region INICIO - FIN	
		void FormValidaCitasLoad(object sender, EventArgs e)
		{
			tipoCita();
		}		
		#endregion
		
		#region BOTONES	
		void BtnValidaClick(object sender, EventArgs e)
		{		
			bool respuesta = false;
			if(bandera == "MANEJO")				
				respuesta = connO.validaCita(id_CitaManejo, txtEstadoManejo.Text, id_usuario);
			else if(bandera == "MEDICA")
				respuesta = connO.validaCita(id_CitaMedica, txtEstadoMedico.Text, id_usuario);
			else if(bandera == "TODAS"){
				if(validaTipoCita()){
					if(banderaManejo == "SI")
						respuesta = connO.validaCita(id_CitaManejo, txtEstadoManejo.Text, id_usuario);
					if(banderaMedico == "SI")
						respuesta = connO.validaCita(id_CitaMedica, txtEstadoMedico.Text, id_usuario);
				}
			}
			
			if(respuesta){
				contratacion.filtrosSolicitudes();
				MessageBox.Show("Se validarón correctamente las citas del candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}	
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region METODOS
		private bool validaTipoCita(){			
			banderaManejo = "NO";
			banderaMedico = "NO";
			
			if(txtEstadoManejo.Enabled == true){
				if(txtEstadoManejo.SelectedIndex > -1)	
					banderaManejo = "SI";
			}
			
			if(txtEstadoMedico.Enabled == true){
				if(txtEstadoMedico.SelectedIndex > -1)	
					banderaMedico = "SI";
			}				
				
				
			if(banderaManejo == "NO" &&	banderaMedico == "NO"){
				btnValida.Enabled = false;
				return false;
			}else{
				btnValida.Enabled = true;
				return true;
			}
		}
		
		private void tipoCita(){
			if(bandera == "MANEJO"){
				txtEstadoManejo.Enabled = true;
				txtEstadoMedico.Enabled = false;
				if(txtEstadoManejo.Text.Length > 0)
					btnValida.Enabled = true;
			}else if(bandera == "MEDICA"){
				txtEstadoManejo.Enabled = false;
				txtEstadoMedico.Enabled = true;	
				if(txtEstadoMedico.Text.Length > 0)
					btnValida.Enabled = true;			
			}else if(bandera == "TODAS"){
				if(contratacion.dgControlSolicitudes[9, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() ==  "VALIDADO" && contratacion.dgControlSolicitudes[14, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() != "VALIDADA")
					txtEstadoManejo.Enabled = true;
				else
					txtEstadoManejo.Enabled = false;
				
				if(contratacion.dgControlSolicitudes[9, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() ==  "VALIDADO" && contratacion.dgControlSolicitudes[22, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() != "VALIDADA")
					txtEstadoMedico.Enabled = true;	
				else
					txtEstadoMedico.Enabled = false;
			}
		}
		#endregion		
	
		#region EVENTOS		
		void TxtEstadoManejoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(bandera == "TODAS")	
				validaTipoCita();
			else
				tipoCita();
		}
		
		void TxtEstadoMedicoSelectedIndexChanged(object sender, EventArgs e)
		{			
			if(bandera == "TODAS")
				validaTipoCita();
			else
				tipoCita();
		}
		
		void FormValidaCitasKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}		
		#endregion
	}
}
