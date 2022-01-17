using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	public partial class FormTelefono : Form
	{
		private int indice=0;
		private List<Interfaz.Operador.Dato.Telefono> lista=null;
		
		public FormTelefono(int indice,List<Interfaz.Operador.Dato.Telefono> lista){
			InitializeComponent();
			this.indice=indice;
			this.lista=lista;
			getCargarValidacionCampos(this);
		}
		
		private void getCargarValidacionCampos(Interfaz.Operador.Modificar.FormTelefono formTelefono){
			formTelefono.cmbTipo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formTelefono.txtNumero.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formTelefono.txtDescripcion.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
		}
		
		void FormTelefonoLoad(object sender, EventArgs e){
			getCargarDato();
		}
		
		
		#region CARGAR_MODIFICAR_DATOS_DE_LA_LISTA
		private void getCargarDato(){
			cmbTipo.SelectedItem=lista[indice].tipo;
			txtNumero.Text=lista[indice].numero;
			txtDescripcion.Text=lista[indice].descripcion;
		}
		
		private void getCargarModificar(){
			lista[indice].tipo=cmbTipo.Text;
			lista[indice].numero=txtNumero.Text;
			lista[indice].descripcion=txtDescripcion.Text;
		}
		#endregion
		
		#region EVENTO_DE_LOS_BOTONES:(ACEPTAR - CANCELAR)
		void BtnAgregarClick(object sender, EventArgs e){
			if(cmbTipo.Text!="" && txtNumero.Text!="" && txtDescripcion.Text!=""){
				getCargarModificar();
				this.Close();
			}else{
				MessageBox.Show("La actualización de los datos de la licencia no se puede llevar a cabo porque existen campos aun sin completar.","Modificar licencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
	}
}
