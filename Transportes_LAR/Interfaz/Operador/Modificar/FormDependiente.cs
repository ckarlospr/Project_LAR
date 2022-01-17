using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	public partial class FormDependiente : Form
	{
		private int indice=0;
		private List<Interfaz.Operador.Dato.Dependiente> lista=null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public FormDependiente(int indice,List<Interfaz.Operador.Dato.Dependiente> lista){
			InitializeComponent();
			this.indice=indice;
			this.lista=lista;
			getCargarValidacionCampos(this);
		}
		
		//--EVENTO_INICIO_DE_INTERFAZ
		void FormDependienteLoad(object sender, EventArgs e){
			getCargarDato();
		}
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Operador.Modificar.FormDependiente formDependiente){
			formDependiente.cmbParentesco.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formDependiente.cmbSexo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		#endregion
		
		#region CARGAR_MODIFICAR_DATOS_DE_LA_LISTA
		private void getCargarDato(){
			cmbParentesco.SelectedItem=lista[indice].parentesco;
			cmbSexo.SelectedItem=lista[indice].sexo;
			int[] fecha=new Interfaz.Operador.Operacion().getDivisionFecha(lista[indice].fechaNacimiento);
			dateNacimiento.Value = new DateTime (fecha[2],fecha[1],fecha[0]);
		}
		
		private void getCargarModificar(){
			lista[indice].parentesco=cmbParentesco.Text;
			lista[indice].sexo=cmbSexo.Text;
			lista[indice].fechaNacimiento=dateNacimiento.Value.ToString("dd-MM-yyyy");
		}
		#endregion
		
		
		#region EVENTO_DE_LOS_BOTONES:(ACEPTAR - CANCELAR)
		void BtnAgregarClick(object sender, EventArgs e){
			if(cmbSexo.Text!="" && cmbParentesco.Text!=""){
				getCargarModificar();
				this.Close();
			}else{
				MessageBox.Show("La actualización de los datos del dependiente no se puede llevar a cabo porque existen campos aun sin completar.","Modificar licencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
	}
}
