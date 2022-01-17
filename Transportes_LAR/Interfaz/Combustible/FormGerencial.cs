using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormGerencial : Form
	{
		public FormGerencial(FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		FormPrincipal refPrincipal;
		
		void FormGerencialLoad(object sender, EventArgs e)
		{
			generaFilas();
		}
		
		void generaFilas()
		{
			dgRendBajo.Rows.Add();
			dgRendBajo.Rows.Add();
			dgRendBajo.Rows.Add();
			dgRendBajo.Rows.Add();
			dgRendBajo.Rows.Add();
		}
	}
}
