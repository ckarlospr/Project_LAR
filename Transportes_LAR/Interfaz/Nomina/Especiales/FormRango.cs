using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormRango : Form
	{
		public FormRango(FormTotalFecha refTotal)
		{
			InitializeComponent();
			refTotalFecha=refTotal;
		}
		
		FormTotalFecha refTotalFecha ;
		
		void FormRangoLoad(object sender, EventArgs e)
		{
			dtpInicio.Value=DateTime.Now;
		}
		
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			dtpFin.Value=dtpInicio.Value;
		}
		
		void CmdGenerarClick(object sender, EventArgs e)
		{
			refTotalFecha.imprimirDatos(dtpInicio.Value.ToString("dd/MM/yyyy"), dtpFin.Value.ToString("dd/MM/yyyy"));
			this.Close();
		}
	}
}
