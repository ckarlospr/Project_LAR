using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormTipoPago : Form
	{
		public FormTipoPago(FormCuentasEsp formCuentas, int TIPO)
		{
			InitializeComponent();
			refCuentas=formCuentas;
			tipo=TIPO;
		}
		
		public FormTipoPago(Interfaz.Nomina.Especiales.Finanzas.FormReporte formRep, int TIPO)
		{
			InitializeComponent();
			formRepor=formRep;
			tipo=TIPO;
		}
		
		#region VARIABLES
		int tipo;
		#endregion
		
		#region INSTANCIA
		Interfaz.Nomina.Especiales.Finanzas.FormReporte formRepor;
		FormCuentasEsp refCuentas;
		#endregion
		
		void FormTipoPagoLoad(object sender, EventArgs e)
		{
			getCargarValidacionCampos(this);
			if(tipo==1)
				getDatos();
			else
				getDatos2();
		}
		
		#region GET DATOS
		void getDatos()
		{
			txtDestino.Text=refCuentas.dgRelacion[6,refCuentas.dgRelacion.CurrentRow.Index].Value.ToString();
			txtImporte.Text=refCuentas.dgRelacion[5,refCuentas.dgRelacion.CurrentRow.Index].Value.ToString();
		}
		
		void getDatos2()
		{
			txtDestino.Text=formRepor.dgReporte[2,formRepor.dgReporte.CurrentRow.Index].Value.ToString();
			txtImporte.Text=formRepor.dgReporte[4,formRepor.dgReporte.CurrentRow.Index].Value.ToString();
		}
		#endregion
		
		#region VALIDACION DE COMPONENTES
		private void getCargarValidacionCampos(FormTipoPago formVal)
		{
			formVal.txtRecuperado.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formVal.txtCanEfect.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formVal.txtCantDeposito.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		#region EVENTOS CHECKBOX
		void CbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(cbEfectivo.Checked)
			{
				txtCanEfect.Enabled=true;
			}
			else
			{
				txtCanEfect.Enabled=false;
				txtCanEfect.Text="0";
			}
		}
		
		void CbDepositoCheckedChanged(object sender, EventArgs e)
		{
			if(cbDeposito.Checked)
			{
				txtCantDeposito.Enabled=true;
			}
			else
			{
				txtCantDeposito.Enabled=false;
				txtCantDeposito.Text="0";
			}
		}
		
		void CbComentarioCheckedChanged(object sender, EventArgs e)
		{
			if(cbComentario.Checked)
			{
				txtComentario.Enabled=true;
				txtComentario.SelectAll();
			}
			else
			{
				txtComentario.Enabled=false;
				txtComentario.Text="Comentario";
			}
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdAceptarClick(object sender, EventArgs e)
		{
			if(tipo==1)
			{
				/*new Conexion_Servidor.Libros.SQL_Libros().guardaDatosInc(Convert.ToInt64(refCuentas.dgRelacion[16,refCuentas.dgRelacion.CurrentRow.Index].Value),txtRecuperado.Text,txtCanEfect.Text, txtCantDeposito.Text, txtComentario.Text, refCuentas.formPrincipal.idUsuario);
				refCuentas.incobrable();
				this.Close();*/
			}
			else
			{
				double perdido = Convert.ToDouble(txtImporte.Text)-(Convert.ToDouble((txtCantDeposito.Text=="")?"0":txtCantDeposito.Text)+Convert.ToDouble((txtCanEfect.Text=="")?"0":txtCanEfect.Text));
				new Conexion_Servidor.Libros.SQL_Libros().guardaDatosInc(Convert.ToInt64(formRepor.dgReporte[0,formRepor.dgReporte.CurrentRow.Index].Value),txtRecuperado.Text,txtCanEfect.Text, txtCantDeposito.Text, txtComentario.Text, formRepor.refPrincipal.idUsuario,perdido.ToString());
				formRepor.incobrable();
				this.Close();
			}
		}
		#endregion
		
		#region DATOS VACIOS
		void TxtRecuperadoKeyUp(object sender, KeyEventArgs e)
		{
			if(txtRecuperado.Text=="")
				txtRecuperado.Text="0";
		}
		
		void TxtCanEfectKeyUp(object sender, KeyEventArgs e)
		{
			if(txtCanEfect.Text=="")
				txtCanEfect.Text="0";
		}
		
		void TxtCantDepositoKeyUp(object sender, KeyEventArgs e)
		{
			if(txtCantDeposito.Text=="")
				txtCantDeposito.Text="0";
		}
		#endregion
	}
}
