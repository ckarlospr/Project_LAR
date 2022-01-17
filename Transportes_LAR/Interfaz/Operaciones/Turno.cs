using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class Turno : Form
	{
		private Transportes_LAR.Interfaz.FormPrincipal refPrincipal=null;
		
		
		public Turno(Transportes_LAR.Interfaz.FormPrincipal refer)
		{
			InitializeComponent();
			refPrincipal=refer;
			btnAgregar.Focus();
		}
		
		
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(cmbTurno.Text=="Elija Opción")
			{
				MessageBox.Show("Seleccione turno");
			}
			else
			{
				if(cmbTurno.Text=="Mañana")
				{
					refPrincipal.getFormTablasOperadores("Mañana",dtpFechaDespacho.Text.ToString());
					refPrincipal.princOperaciones("Mañana",dtpFechaDespacho.Text.ToString());
				}
				if(cmbTurno.Text=="Medio día")
				{
					refPrincipal.getFormTablasOperadores("Medio día",dtpFechaDespacho.Text.ToString());
					refPrincipal.princOperaciones("Medio día",dtpFechaDespacho.Text.ToString());
				}
				if(cmbTurno.Text=="Vespertino")
				{
					refPrincipal.getFormTablasOperadores("Vespertino",dtpFechaDespacho.Text.ToString());
					refPrincipal.princOperaciones("Vespertino",dtpFechaDespacho.Text.ToString());
				}
				if(cmbTurno.Text=="Nocturno")
				{
					refPrincipal.getFormTablasOperadores("Nocturno",dtpFechaDespacho.Text.ToString());
					refPrincipal.princOperaciones("Nocturno",dtpFechaDespacho.Text.ToString());
				}
				
				this.Close();
				refPrincipal.turno=false;
			}
		}
		
		
		void TurnoLoad(object sender, EventArgs e)
		{
			dtpFechaDespacho.Value=DateTime.Now;
			cmbTurno.Text="Mañana";
			
			if(refPrincipal.lblDatoNivel.Text != "GERENCIAL" && refPrincipal.lblDatoNivel.Text != "MASTER")
				dtpFechaDespacho.MinDate = DateTime.Now.AddDays(-1);
		}
		
		void TurnoFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.turno = false;
		}
	}
}
