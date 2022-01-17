using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	public partial class FormLicencia : Form
	{
		private int indice=0;
		private List<Interfaz.Operador.Dato.Licencia> lista=null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public FormLicencia(int indice,List<Interfaz.Operador.Dato.Licencia> lista){
			InitializeComponent();
			this.indice=indice;
			this.lista=lista;
			getCargarValidacionCampos(this);
		}
		
		//--EVENTO_INICIO_DE_INTERFAZ
		void FormLicenciaLoad(object sender, EventArgs e){
			getCargarDato();
		}
		#region CARGAR_MODIFICAR_DATOS_DE_LA_LISTA
		private void getCargarDato(){
			txtNumero.Text=lista[indice].numero;
			cmbClase.SelectedItem=lista[indice].clase;
			cmbTipo.SelectedItem=lista[indice].tipo;
			int[] fecha=new Interfaz.Operador.Operacion().getDivisionFecha(lista[indice].vigencia);
			try{
				dateVigencia.Value = new DateTime (fecha[2],fecha[1],fecha[0]);
			}catch{
				dateVigencia.Value = new DateTime (fecha[0],fecha[1],fecha[2]);
			}
		}
		
		private void getCargarModificar(){
			lista[indice].numero=txtNumero.Text;
			lista[indice].clase=cmbClase.Text;
			lista[indice].tipo=cmbTipo.Text;
			lista[indice].vigencia=dateVigencia.Value.ToString("dd-MM-yyyy");
		}
		#endregion
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Operador.Modificar.FormLicencia formLicencia){
			formLicencia.txtNumero.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formLicencia.cmbClase.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formLicencia.cmbTipo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		
		void TxtNumeroTextChanged(object sender, EventArgs e){
			txtNumero.Text=(txtNumero.Text==" ")?"":txtNumero.Text;
			if(cmbClase.Text==" "){
				cmbClase.SelectedIndex=0;
			}
			if(cmbTipo.Text==" "){
				cmbTipo.SelectedIndex=0;
			}
		}
		#endregion
		
		#region EVENTO_DE_LOS_BOTONES:(ACEPTAR - CANCELAR)
		void BtnAgregarClick(object sender, EventArgs e){
			if(txtNumero.Text!="" && cmbClase.Text!="" && cmbTipo.Text!=""){
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
