using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormEspExternas : Form
	{
		public FormEspExternas(formPrincipalComb refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		#endregion
		
		#region INSTANCIAS
		formPrincipalComb refPrincipal;
		#endregion
		
		#region EVENTO LOAD
		void FormEspExternasLoad(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region EVENTO BOTONES
		void BtnEntreClick(object sender, EventArgs e)
		{
			if(Convert.ToInt16(nudCantidad.Text)>0 && nudCantidad.Text!="")
			{
				refPrincipal.generaExternas2(Convert.ToInt16(nudCantidad.Text));
				this.Close();
			}
		} 
		#endregion
		
	}
}
