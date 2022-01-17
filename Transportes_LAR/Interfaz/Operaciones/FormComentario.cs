using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormComentario : Form
	{
		public FormComentario(FormOperacionesOperador refPrinc)
		{
			InitializeComponent();
			
			refPrincipal = refPrinc;
		}
		
		FormOperacionesOperador refPrincipal;
		
		void CmdGuardaClick(object sender, EventArgs e)
		{
			refPrincipal.Coment=txtComent.Text;
			refPrincipal.guia=true;
			this.Close();
		}
	}
}
