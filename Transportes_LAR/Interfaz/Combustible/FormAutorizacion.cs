using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormAutorizacion : Form
	{
		public FormAutorizacion(FormPrincCombustible formPrinc)
		{
			InitializeComponent();
			refPrinComb = formPrinc;
		}
		
		#region VARIABLES
		
		#endregion
		
		#region INSTANCIAS
		FormPrincCombustible refPrinComb;
		#endregion
		
		#region EVENTO LOAD
		void FormAutorizacionLoad(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdAgregarClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Combustible.SQL_Combustible();
		}
		
		void CmdHoraClick(object sender, EventArgs e)
		{
			//dtpCarga.Value = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss"));
		}
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			
		}
		
		void CmdModificarClick(object sender, EventArgs e)
		{
			
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			
		}
		#endregion
	}
}
