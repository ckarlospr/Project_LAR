using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina
{
	public partial class FormEfectivoCheque : Form
	{
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTORES
		public FormEfectivoCheque()
		{
			InitializeComponent();
		}
		
		public FormEfectivoCheque(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INICIO
		void FormEfectivoChequeLoad(object sender, EventArgs e)
		{
			String x = new Conexion_Servidor.Nomina.SQL_Nomina().TraerTipoPago();
			if(x == "EFECTIVO")
				rEfectivo.Checked = true;
			else
				rCheque.Checked = true;
		}
		#endregion
		
		#region	EVENTO - CHECKED
		void REfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rEfectivo.Checked == true)
				new Conexion_Servidor.Nomina.SQL_Nomina().ActualizarTipoPago("EFECTIVO");
		}
		
		void RChequeCheckedChanged(object sender, EventArgs e)
		{
			if(rCheque.Checked==true)
				new Conexion_Servidor.Nomina.SQL_Nomina().ActualizarTipoPago("CHEQUE");
		}
		#endregion
	}
}
