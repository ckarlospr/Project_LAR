using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	public partial class FormTaxiPago : Form
	{
		#region VARIABLES
		String id_taxi;
		String id_descuento;
		String id_usuario = "";
		#endregion
		
		#region INSTANCIAS
		Interfaz.Nomina.Anticipos.FormPrincAnticipos prinDescuentos= null;
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTOR
		public FormTaxiPago(Interfaz.FormPrincipal principal, String ID_TAXI, String ID_DESC, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			this.id_usuario = id_usuario;
			Interfaz.Nomina.Anticipos.FormPrincAnticipos prinDesc = new Interfaz.Nomina.Anticipos.FormPrincAnticipos(principal, id_usuario);
			this.prinDescuentos=prinDesc;
			this.id_taxi=ID_TAXI;
			this.id_descuento=ID_DESC;
		}
		#endregion
		
		#region VALIDACION DEL PUNTO
		void TxtCargoOperadorTextChanged(object sender, EventArgs e)
		{
			if(txtCargoOperador.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		#endregion
		
		#region BOTONES
		void BtnDescontarClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Anticipos.SQL_Anticipos().ModificarCantidadTaxi(id_descuento, txtCargoOperador.Text);
			new Conexion_Servidor.Anticipos.SQL_Anticipos().ModificarEstadoTaxi(id_taxi, "Descontando");
				for(int contador = 0; contador<dataAnticipos.RowCount; contador++)
					new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataAnticipos.Rows[contador].Cells[2].Value.ToString(), dataAnticipos.Rows[contador].Cells[3].Value.ToString(), (Convert.ToDouble(dataAnticipos.Rows[contador].Cells[4].Value)));
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region INICIO
		void FormTaxiPagoLoad(object sender, EventArgs e)
		{
			this.txtCargoOperador.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			this.txtCantPago.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		#region PAGOS
		void TxtCantPagoTextChanged(object sender, EventArgs e)
		{
			if(txtCantPago.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			
			if(txtCantPago.Text!=""&&txtCargoOperador.Text!="")
			{
				if ((Convert.ToDouble(txtCantPago.Text))>(Convert.ToDouble(txtCargoOperador.Text)))
				{
	               txtCantPago.Text= "0.00";
	               dataConteoDesc.Rows.Clear();
	               MessageBox.Show("Numero mayor al de importe", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            }
				else
				{
					prinDescuentos.AdaptadorPagos(dataAnticipos, txtCargoOperador, txtCantPago, "TAX");
					if((Convert.ToDouble(txtCantPago.Text))>0)
								prinDescuentos.ContabilizadorPagos(dataAnticipos, dataConteoDesc);
				}
			}
		}
		#endregion
		
		#region LIMPIAR
		void TxtCargoOperadorEnter(object sender, EventArgs e)
		{
			txtCargoOperador.Text="";
			txtCantPago.Text="";
			dataAnticipos.Rows.Clear();
			dataAnticipos.ClearSelection();
			dataConteoDesc.Rows.Clear();
			dataConteoDesc.ClearSelection();
		}
		
		void TxtCantPagoEnter(object sender, EventArgs e)
		{
			txtCantPago.Text="";
			dataAnticipos.Rows.Clear();
			dataAnticipos.ClearSelection();
			dataConteoDesc.Rows.Clear();
			dataConteoDesc.ClearSelection();
		}
		#endregion
	}
}
