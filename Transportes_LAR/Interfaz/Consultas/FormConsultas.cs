using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Consultas
{
	public partial class FormConsultas : Form
	{
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		#endregion
		
		#region CONTRUCTOR
		public FormConsultas(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region CLOSING
		void FormConsultasFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.Consulta = false;
		}
		#endregion
		
		void TxtSentenciaKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      	{
			 	 dtConsultas.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla(txtSentencia.Text);
			 	}
		}
		
		void LblEjecutarClick(object sender, EventArgs e)
		{
			try
			{
				dtConsultas.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla(txtSentencia.Text);
			}
			catch{}
		}
	}
}
