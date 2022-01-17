using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormAnticipos : Form
	{
		public FormAnticipos(LibroViajes libro)
		{
			InitializeComponent();
			refLibro=libro;
		}
		
		#region  REFERENCIAS
		LibroViajes refLibro;
		#endregion
		
		void FormAnticiposLoad(object sender, EventArgs e)
		{
			getCargarValidacionCampos(this);
		}
		
		#region EVENTO BOTON		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtCantidad.Text=="0" || txtCantidad.Text=="")
			{
				MessageBox.Show("Ingrese cantidad del anticipo realizado.");
			}
			else
			{
				if(rbEfectivo.Checked==true)
				{
					if(txtRecibo.Text=="")
					{
						MessageBox.Show("Ingrese numero de recibo");
					}
					else
					{
						refLibro.dgAnticipos.Rows.Add(txtCantidad.Text, txtRecibo.Text,dtpFecha.Value.ToString("dd/MM/yyyy"), "1", "EFECTIVO");
						refLibro.cuentaAnticipos();
						this.Close();
					}
				}
				else if(rbDeposito.Checked==true)
				{
					if(txtReferencia.Text=="")
					{
						MessageBox.Show("Ingrese referencia");
					}
					else
					{
						refLibro.dgAnticipos.Rows.Add(txtCantidad.Text, txtReferencia.Text,dtpFecha.Value.ToString("dd/MM/yyyy"), "1", "DEPOSITO");
						refLibro.cuentaAnticipos();
						this.Close();
					}
				}	
			}
		}
		#endregion
		
		#region VALIDACION
		private void getCargarValidacionCampos(FormAnticipos formVal)
		{
			formVal.txtCantidad.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formVal.txtRecibo.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
		}
		
		void TxtCantidadTextChanged(object sender, EventArgs e)
		{
			if(txtCantidad.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtCantidadLeave(object sender, EventArgs e)
		{
			if(txtCantidad.Text=="")
			{
				txtCantidad.Text="0";
			}
		}
		#endregion
		
		void RbDepositoCheckedChanged(object sender, EventArgs e)
		{
			if(rbDeposito.Checked==true)
			{
				txtReferencia.Enabled=true;
				txtRecibo.Text="";
				txtRecibo.Enabled=false;
			}
		}
		
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked==true)
			{
				txtRecibo.Enabled=true;
				txtReferencia.Text="";
				txtReferencia.Enabled=false;
			}
		}
	}
}
