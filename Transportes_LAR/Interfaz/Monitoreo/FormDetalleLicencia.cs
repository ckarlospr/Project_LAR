using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Monitoreo
{
	public partial class FormDetalleLicencia : Form
	{
		#region VARIABLES
		private string licencia="";
		#endregion
		
		#region CONSTRUCTOR
		public FormDetalleLicencia(string licencia){
			InitializeComponent();
			this.licencia=licencia;
		}
		#endregion
		
		#region METODO_LOAD
		void FormDetalleLicenciaLoad(object sender, EventArgs e){
			new Conexion_Servidor.Operador.SQL_Licencia().getDatosLicencia(licencia,txtClase,txtNumero,txtTipo,dateVigencia);
		}
		#endregion
		
		#region EVENTO_BOTONES (ACEPTAR - CANCELAR)
		void BtnAceptarClick(object sender, EventArgs e){
			new Conexion_Servidor.Operador.SQL_Licencia().getCambiarFechaLicencia(licencia,dateVigencia.Value.ToString());
			this.Close();
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void TxtNumeroKeyPress(object sender, KeyPressEventArgs e){
			e.Handled=true;
		}
		#endregion
	}
}
