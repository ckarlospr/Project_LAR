using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Asignacion
{
	public partial class FormModificarFecha : Form
	{
		private string idOperador="";
		private string idUnidad="";
		
		#region CONSTRUCTOR 
		public FormModificarFecha(string idOperador,string idUnidad){
			InitializeComponent();
			this.idOperador=idOperador;
			this.idUnidad=idUnidad;
		}
		#endregion
		
		#region EVENTO (LOAD - CLOSING)
		void FormModificarFechaLoad(object sender, EventArgs e){
			txtOperador.Text=new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getDatosAsignacion("select alias from operador where id="+idOperador,"alias");
			txtUnidad.Text=new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getDatosAsignacion("select Numero from VEHICULO where id="+idUnidad,"Numero");
			new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getFecha(idOperador,idUnidad,dateFecha);
		}
		#endregion
		
		#region VALIDACION_DE_CAMPOS
		void TxtOperadorKeyPress(object sender, KeyPressEventArgs e){
			e.Handled=true;
		}
		#endregion
		
		#region EVENTO_BOTONES ( ACEPTAR - CANCELAR )
		void BtnAceptarClick(object sender, EventArgs e){
			new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getModificarFecha(dateFecha.Text,idOperador,idUnidad);
			new Interfaz.FormMensaje("Fecha modificada").Show();
			this.Close();
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
	}
}
