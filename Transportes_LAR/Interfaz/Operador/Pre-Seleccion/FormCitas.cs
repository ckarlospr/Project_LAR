using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormCitas : Form
	{
		#region VARIABLES
		int id_usuario;
		Int64 id_CitaManejo;
		Int64 id_CitaMedica;
		Int64 ID_PREOPERADOR;
		int bandera;
		string folio;
		string banderaManejo;
		string banderaMedico;
		int banderaInicio = 0;
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES
		public FormCitas(FormContratacion refprincipal, int id_usu, Int64 PREOPERADOR, Int64 CitaManejo, Int64 CitaMedica, int flat, string folio)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			id_CitaManejo = CitaManejo;
			id_CitaMedica = CitaMedica;
			bandera = flat;
			this.folio = folio;
			ID_PREOPERADOR = PREOPERADOR;
		}
		
		public FormCitas(FormContratacion refprincipal, int id_usu, int flat)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			bandera = flat;
		}
		#endregion
		
		#region INICIO - FIN
		void FormCitasLoad(object sender, EventArgs e)
		{			
			if(bandera == 1){
				banderaInicio = 1;
				btnValida.Enabled = false;
				if(contratacion.dgControlSolicitudes[9, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() == "VALIDADO" && contratacion.dgControlSolicitudes[14, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() != "VALIDADA"){
					dtpFechaCitaManejo.Enabled = true;
					dtpHoraCitaManejo.Enabled = true;
					dtpFechaCitaManejo.Value = Convert.ToDateTime(contratacion.dgControlSolicitudes[12, contratacion.dgControlSolicitudes.CurrentRow.Index].Value);
					dtpHoraCitaManejo.Value = Convert.ToDateTime(contratacion.dgControlSolicitudes[13, contratacion.dgControlSolicitudes.CurrentRow.Index].Value);
				}else{
					dtpFechaCitaManejo.Enabled = false;
					dtpHoraCitaManejo.Enabled = false;
				}
				
				if(contratacion.dgControlSolicitudes[9, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() == "VALIDADO" && contratacion.dgControlSolicitudes[22, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() != "VALIDADA"){
					dtpFechaCitaMedico.Enabled = true;
					dtpHoraCitaMedico.Enabled = true;
					dtpFechaCitaMedico.Value = Convert.ToDateTime(contratacion.dgControlSolicitudes[20, contratacion.dgControlSolicitudes.CurrentRow.Index].Value);
					dtpHoraCitaMedico.Value = Convert.ToDateTime(contratacion.dgControlSolicitudes[21, contratacion.dgControlSolicitudes.CurrentRow.Index].Value);
				}else{
					dtpFechaCitaMedico.Enabled = false;
					dtpHoraCitaMedico.Enabled = false;
				}
				banderaInicio = 0;
			}else if(bandera == 0){
				dtpHoraCitaMedico.Value = DateTime.Now.AddHours(1);
				dtpHoraCitaManejo.Value = DateTime.Now.AddHours(1);
			}
		}	
		#endregion
		
		#region BOTONES	
		void BtnValidaClick(object sender, EventArgs e)
		{
			bool respuesta = false;
			if(bandera == 0){
				respuesta = contratacion.validaDatosOperador(dtpFechaCitaManejo.Value.ToString("yyyy-MM-dd"), dtpHoraCitaManejo.Value.ToString("HH:mm"), 
				                                            dtpFechaCitaMedico.Value.ToString("yyyy-MM-dd"), dtpHoraCitaMedico.Value.ToString("HH:mm"));
				if(respuesta){
					contratacion.copySpech(dtpFechaCitaManejo.Value.ToString("dd/MM/yyyy"), dtpHoraCitaManejo.Value.ToString("HH:mm"), dtpFechaCitaMedico.Value.ToString("dd/MM/yyyy"), dtpHoraCitaMedico.Value.ToString("HH:mm"));				
					contratacion.filtrosLlamadas();
					contratacion.filtrosSolicitudes();
					contratacion.limpiarCamposAI();
					contratacion.limpiaFiltrosOperador();
					MessageBox.Show("Se validó correctamente los datos del candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}else{
				if(validaManejo()){
					if(banderaManejo == "SI")
						respuesta = connO.reagendarCitaID(ID_PREOPERADOR, id_CitaManejo, folio, "MANEJO", dtpFechaCitaManejo.Value.ToString("yyyy-MM-dd"), dtpHoraCitaManejo.Value.ToString("HH:mm"), "ACTIVA", "", id_usuario);
					if(banderaMedico == "SI")
						respuesta = connO.reagendarCitaID(ID_PREOPERADOR, id_CitaMedica, folio, "MEDICO", dtpFechaCitaMedico.Value.ToString("yyyy-MM-dd"), dtpHoraCitaMedico.Value.ToString("HH:mm"), "ACTIVA", "", id_usuario);
					
					if(respuesta){
						contratacion.filtrosSolicitudes();
						MessageBox.Show("Se agendarón las nuevas citas del candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}				
			}			
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void DtpFechaCitaManejoValueChanged(object sender, EventArgs e)
		{
			if(bandera == 0)
				dtpFechaCitaMedico.Value = dtpFechaCitaManejo.Value;
			else if(bandera == 1 && banderaInicio == 0)
				validaManejo();
		}
		
		void DtpHoraCitaManejoValueChanged(object sender, EventArgs e)
		{
			if(bandera == 0)	
				dtpHoraCitaMedico.Value = dtpHoraCitaManejo.Value;
			else if(bandera == 1 && banderaInicio == 0)
				validaManejo();
		}
		
		void DtpFechaCitaMedicoValueChanged(object sender, EventArgs e)
		{
			if(bandera == 1 && banderaInicio == 0)
				validaManejo();
		}
		
		void DtpHoraCitaMedicoValueChanged(object sender, EventArgs e)
		{
			if(bandera == 1 && banderaInicio == 0)
				validaManejo();
		}
		#endregion
		
		#region METODOS
		private bool validaManejo(){
			banderaManejo = "NO";
			banderaMedico = "NO";
			
			if(dtpFechaCitaManejo.Enabled == true){
				if(contratacion.dgControlSolicitudes[12, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() != dtpFechaCitaManejo.Value.ToString("dd/MM/yyyy"))
					banderaManejo = "SI";
				if(contratacion.dgControlSolicitudes[13, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString().Substring(0,5) != dtpHoraCitaManejo.Value.ToString("HH:mm"))
					banderaManejo = "SI";
			}
			
			if(dtpFechaCitaMedico.Enabled == true){
				if(contratacion.dgControlSolicitudes[20, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString() != dtpFechaCitaMedico.Value.ToString("dd/MM/yyyy"))
					banderaMedico = "SI";
				if(contratacion.dgControlSolicitudes[21, contratacion.dgControlSolicitudes.CurrentRow.Index].Value.ToString().Substring(0,5) != dtpHoraCitaMedico.Value.ToString("HH:mm"))
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
		#endregion
	}
}
