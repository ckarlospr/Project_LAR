using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormOrdenCaritas : Form
	{
		String id_usuario = "";
		
		Interfaz.FormPrincipal principal = null;

		public FormOrdenCaritas(Interfaz.FormPrincipal principal, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			this.id_usuario = id_usuario;
		}
		
		void BtnVehiculoClick(object sender, EventArgs e)
		{
			Interfaz.Nomina.FormNomina fnomina = new Interfaz.Nomina.FormNomina(principal, id_usuario);
			fnomina.DirectorioIlustradoOrden(1);
		}
		
		void FormOrdenCaritasFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.ordencaritas=false;
		}
		
		void BtnCamionetaClick(object sender, EventArgs e)
		{
			Interfaz.Nomina.FormNomina fnomina = new Interfaz.Nomina.FormNomina(principal, id_usuario);
			fnomina.DirectorioIlustradoOrden(2);
		}
		
		void BtnAlfabeticoClick(object sender, EventArgs e)
		{
			Interfaz.Nomina.FormNomina fnomina = new Interfaz.Nomina.FormNomina(principal, id_usuario);
			fnomina.DirectorioIlustradoOrden(3);
		}
		
		void BtnventasClick(object sender, EventArgs e)
		{
			Interfaz.Nomina.FormNomina fnomina = new Interfaz.Nomina.FormNomina(principal, id_usuario);
			fnomina.DirectorioIlustradoOrden(4);
		}
	}
}
