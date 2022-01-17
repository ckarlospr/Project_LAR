using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	public partial class FormModificarFechaAnticipo : Form
	{
		#region VARIABLES
		long ID=0;
		int Row = 0;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Interfaz.Nomina.Anticipos.FormPrincAnticipos formAnticipos = null;
		#endregion
		
		#region CONSTRUCTOR
		public FormModificarFechaAnticipo(long id, int row, Interfaz.Nomina.Anticipos.FormPrincAnticipos formAnticipo)
		{
			InitializeComponent();
			this.ID=id;
			this.Row = row;
			this.formAnticipos=formAnticipo;
		}
		#endregion
		
		#region ACEPTAR - CANCELAR
		void BtnFechaClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Anticipos.SQL_Anticipos().UpdateFechaAnticipos(dtFecha.Value.ToString("dd-MM-yyyy"), ID.ToString(), "");
			formAnticipos.AdaptadorDatosPrincipal(Row);
			formAnticipos.AdaptadorDescuentoQuincenal(Row);
			this.Close();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
	}
}
