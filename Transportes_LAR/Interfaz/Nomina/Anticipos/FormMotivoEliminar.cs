using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	public partial class FormMotivoEliminar : Form
	{
		#region VARIABLES
		String id_descuento = "0";
		String id_usuario = "0";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTOR
		public FormMotivoEliminar(String id_descuento, String id_usuario)
		{
			InitializeComponent();
			this.id_descuento = id_descuento;
			this.id_usuario = id_usuario;
		}
		#endregion
		
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Anticipos.SQL_Anticipos().EliminarDescuento(id_descuento, id_usuario, txtMotivo.Text);
			this.Close();
		}
		#endregion
	}
}
