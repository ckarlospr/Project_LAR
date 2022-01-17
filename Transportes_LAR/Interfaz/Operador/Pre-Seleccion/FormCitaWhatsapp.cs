using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormCitaWhatsapp : Form
	{		
		#region VARIABLES
		int id_usuario;
		Int64 ID_PREOPERADOR;
		string nombre = "";
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES
		public FormCitaWhatsapp(FormContratacion refprincipal, int id_usu, Int64 ID_PREOPERADOR, string nombre)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			this.ID_PREOPERADOR = ID_PREOPERADOR;
			this.nombre = nombre;
		}
		#endregion
		
		#region INICIO - FIN
		void FormCitaWhatsappLoad(object sender, EventArgs e)
		{
			int dias = (7 - Convert.ToInt16(DateTime.Now.DayOfWeek) + 6);
				
			dtpFechaCita.MinDate = DateTime.Now;
			dtpFechaCita.MaxDate = DateTime.Now.AddDays(dias);
			dtpFechaCita.Value = DateTime.Now.AddDays(1);
			dtpHoraCita.Value = DateTime.Now;
		}	
		#endregion
		
		#region BOTONES	
		void BtnWhatsappAIClick(object sender, EventArgs e)
		{
			try{
				String datos = "*Citado: "+((dtpFechaCita.Value == DateTime.Now)? "Hoy" : dtpFechaCita.Value.ToString("dd/MM/yyyy"))+" A las "+dtpHoraCita.Value.ToString("HH:mm")+"* \n";
				datos += "El candidato\n"+nombre+"\nSe dirige a realizar las pruebas en taller.\n";
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
				MessageBox.Show("Se generó mensaje de la cita, Copiarlo en el grupo pertienente", "Mensaje Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al general mensaje de la cita: "+ex.Message, "Error Whatsapp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		
		#region EVENTOS
		void FormCitaWhatsappKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion		
	}
}
