using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormGloboMsj : Form
	{
		public FormGloboMsj()
		{
			InitializeComponent();
		}
		
		void FormGloboMsjMouseEnter(object sender, EventArgs e)
		{
		
		}
		
		void Label1MouseEnter(object sender, EventArgs e)
		{
			this.Visible=false;
		}
		
		public void muestrarMsj(String dato)
		{
			lblMensaje.Text=dato;
		}
	}
}
