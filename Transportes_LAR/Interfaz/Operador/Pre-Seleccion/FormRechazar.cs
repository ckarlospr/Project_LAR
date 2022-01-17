using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormRechazar : Form
	{		
		
		#region VARIABLES
		int id_usuario;
		Int64 id_CitaManejo;
		Int64 id_CitaMedica;
		Int64 ID_PREOPERADOR;
		string folio;
		string bandera;
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES
		public FormRechazar(FormContratacion refprincipal, int id_usu, Int64 PREOPERADOR, Int64 CitaManejo, Int64 CitaMedica, string folio, string bandera)
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
		void FormRechazarLoad(object sender, EventArgs e)
		{
			txtMotivo.AutoCompleteCustomSource = auto.AutocompleteGeneral("select COMENTARIO from CITA_PRE_OPERADOR", "COMENTARIO");
           	txtMotivo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMotivo.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region BOTONES	
		void BtnValidaClick(object sender, EventArgs e)
		{
			if(bandera == "LLAMADA"){
				if(connO.cancelaLlamda(ID_PREOPERADOR, Convert.ToInt16(folio), "LLAMADA", txtMotivo.Text, "", id_usuario )){
					contratacion.filtrosLlamadas();
					contratacion.limpiarCamposAI();
					contratacion.limpiaFiltrosOperador();
					this.Close();
					MessageBox.Show("Se canceló correctamente la llamada del candidato al operador", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}else{
				if(connO.noContratarCandidato(ID_PREOPERADOR, folio, "CERRADO", "RECHAZADO", txtMotivo.Text, id_usuario)){
					connO.confirmarCita(id_CitaManejo, "NO CONTRATADO", id_usuario);				
					connO.confirmarCita(id_CitaMedica, "NO CONTRATADO", id_usuario);	
					contratacion.filtrosSolicitudes();
					contratacion.limpiarCamposAI();
					contratacion.limpiaFiltrosOperador();
					this.Close();
					MessageBox.Show("Se rechazo correctamente al candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
				
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void TxtMotivoTextChanged(object sender, EventArgs e)
		{
			if(txtMotivo.Text.Length > 0)
				btnValida.Enabled = true;
			else
				btnValida.Enabled = false;
		}
		
		void FormRechazarKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
	}
}
