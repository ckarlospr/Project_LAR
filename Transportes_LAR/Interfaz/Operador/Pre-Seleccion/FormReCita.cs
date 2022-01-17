using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormReCita : Form
	{
		#region VARIABLES
		int id_usuario;
		string tipo;
		Int64 ID_PREOPERADOR;
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES
		public FormReCita(FormContratacion refprincipal, int id_usu, Int64 ID_PREOPERADOR, string tipo)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			this.ID_PREOPERADOR = ID_PREOPERADOR;
			this.tipo = tipo;
		}
		#endregion
		
		#region INICIO - FIN
		void FormReCitaLoad(object sender, EventArgs e)
		{
			int dias = (7 - Convert.ToInt16(DateTime.Now.DayOfWeek) + 6);
				
			dtpFechaCita.MinDate = DateTime.Now;
			dtpFechaCita.MaxDate = DateTime.Now.AddDays(dias);
			dtpFechaCita.Value = DateTime.Now.AddDays(1);
			dtpHoraCita.Value = DateTime.Now;
			this.Text = "Reagendar Cita "+tipo;
		}	
		#endregion
		
		#region BOTONES	
		void BtnAgendaClick(object sender, EventArgs e)
		{
			if(connO.reagendarCita(ID_PREOPERADOR, connO.getFolio(ID_PREOPERADOR).ToString(), tipo, dtpFechaCita.Value.ToString("yyyy-MM-dd"), dtpHoraCita.Value.ToString("HH:mm"), "ACTIVA", "", id_usuario)){
				if(tipo == "LLAMADA")
					contratacion.filtrosLlamadas();
				else
					contratacion.filtrosSolicitudes();
				contratacion.limpiarCamposAI();
				contratacion.limpiaFiltrosOperador();
				MessageBox.Show("Se agendo la nueva cita del candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}
		#endregion
		
		#region EVENTOS
		void FormReCitaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
	}
}
