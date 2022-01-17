using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormFiltros : Form
	{
		public FormFiltros(FormCuentasEsp refCuentasEsp)
		{
			InitializeComponent();
			getNodesFiltro();
			refPrincipal=refCuentasEsp;
		}
		
		Interfaz.Nomina.Especiales.FormCuentasEsp  refPrincipal = null;
		
		public void getNodesFiltro()
		{
			for(int x=0; x<50; x++)
			{
				tvFiltro.Nodes.Add("A"+x);
			}
		}
		
		void CmdCerrarClick(object sender, EventArgs e)
		{
			this.Visible=false;
		}
	}
}
