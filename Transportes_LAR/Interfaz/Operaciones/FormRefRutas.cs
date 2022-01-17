using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormRefRutas : Form
	{
		public FormRefRutas()
		{
			InitializeComponent();
		}
		
		public void RefRutas(String Alias)
		{
			lblAlias.Text = Alias;
		}
	}
}
