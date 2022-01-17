using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormPrivilegioCobro : Form
	{
		public FormPrivilegioCobro(FormPrincipal refPrin)
		{
			InitializeComponent();
			refPrincipal=refPrin;
		}
		
		public FormPrincipal refPrincipal;
		
		void CmdAceptarClick(object sender, EventArgs e)
		{
			ingresar();
		}
		
		void ingresar()
		{
			if(txtClave.Text=="")
			{
				MessageBox.Show("Ingrese clave.");
			}
			else if(txtClave.Text=="LAR951")
			{
				refPrincipal.getCobroEspeciales(1);
				this.Close();
			}
			else if(txtClave.Text=="LAR1")
			{
				refPrincipal.getCobroEspeciales(2);
				this.Close();
			}
			else if(txtClave.Text=="1250")
			{
				refPrincipal.getCobroEspeciales(3);
				this.Close();
			}
			else if(txtClave.Text=="1315")
			{
				refPrincipal.getCobroEspeciales(4);
				this.Close();
			}
			else
			{
				MessageBox.Show("Clave incorrecta");
			}
		}
		
		void TxtClaveKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				ingresar();
			}
		}
		
		void FormPrivilegioCobroLoad(object sender, EventArgs e)
		{
			txtClave.Focus();
		}
	}
}
