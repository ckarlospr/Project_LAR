using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormMsjGral : Form
	{
		public FormMsjGral(FormOperadores formOp)
		{
			InitializeComponent();
			formOperad=formOp;
		}
		
		FormOperadores formOperad = null;
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtMensaje.Text!="")
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().msjGral(formOperad.principal.idUsuario, txtMensaje.Text, formOperad.principal.formPrincEmp.fecha_despacho, formOperad.principal.formPrincEmp.ConsTurno);
				formOperad.getMsjGral();
				this.Close();
			}
			else
			{
				MessageBox.Show("Agregue mensaje.");
			}
		}
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
