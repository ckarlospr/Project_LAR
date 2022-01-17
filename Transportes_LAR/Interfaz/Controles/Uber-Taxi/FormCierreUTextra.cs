using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	public partial class FormCierreUTextra : Form
	{
		#region INSTANCIAS
		private FormReporteUT formReporte = null;
		private FormUber_TaxiExtra formUberTaxiExtra = null;
		private Conexion_Servidor.Controles.SQL_Controles connC = new Conexion_Servidor.Controles.SQL_Controles();
		#endregion
		
		#region VARIABLES
		string id_usuario;
		string id_uberTaxi;
		string id_pedido;
		#endregion
		
		#region CONSTRUCTOR
		public FormCierreUTextra(FormReporteUT refRUT, string id_usu, string id_ut,  string id_p, string folio)
		{
			InitializeComponent();
			this.formReporte = refRUT;
			this.id_usuario = id_usu;
			this.id_pedido = id_p;
			this.id_uberTaxi = id_ut;
			txtFolio.Text = folio;
		}
		
		public FormCierreUTextra(FormUber_TaxiExtra refRUTE, string id_usu, string id_ut, string id_p, string folio)
		{
			InitializeComponent();
			this.formUberTaxiExtra = refRUTE;
			this.id_usuario = id_usu;
			this.id_pedido = id_p;
			this.id_uberTaxi = id_ut;
			txtFolio.Text = folio;
		}
		#endregion
		
		#region INICIO - FIN		
		void FormCierreUTextraLoad(object sender, EventArgs e)
		{
			this.txtUsuario.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtCosto.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		#region BOTONES
		void BtnGuardarClick(object sender, EventArgs e)
		{			
			if(validaCierre()){
				if(connC.cierreVechiculoUT(txtUsuario.Text, txtCosto.Text, id_usuario, id_uberTaxi, id_pedido)){
				   	MessageBox.Show("Se valido correctamente el vehículo", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				   	if(formUberTaxiExtra == null)
						formReporte.filtros();
				   	else
						formUberTaxiExtra.filtros();
					this.Close();
				}else{					
				   	MessageBox.Show("Error al cerrar el Uber - Taxi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		void LblCerrarClick(object sender, EventArgs e)
		{			
			this.Close();
		}
		#endregion
		
		#region METODOS		
		private bool validaCierre(){
			bool respuesta = true;
			
			errorProvider1.Clear();
			if(txtUsuario.Text.Length == 0){
				errorProvider1.SetError(txtUsuario, "Ingresa el numero de usuarios que viajo en el UBER o Taxi");
				txtUsuario.Focus();
				respuesta = false;
			}
			
			if(txtCosto.Text.Length == 0){
				errorProvider1.SetError(txtCosto, "Ingresa el costo del UBER o Taxi");
				txtCosto.Focus();
				respuesta = false;
			}
			
			if(txtFolio.Text.Length == 0){
				errorProvider1.SetError(txtFolio, "Ingresa el folio del UBER o Taxi");
				txtFolio.Focus();
				respuesta = false;
			}
			
			return respuesta;	
		}
		#endregion
		
		#region EVENTOS		
		void FormCierreUTextraKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
	}
}
