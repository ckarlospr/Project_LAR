using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	public partial class FormContacto : Form
	{
		private int indice=0;
		private List<Interfaz.Operador.Dato.Contacto> lista=null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public FormContacto(int indice,List<Interfaz.Operador.Dato.Contacto> lista){
			InitializeComponent();
			this.indice=indice;
			this.lista=lista;
			getCargarValidacionCampos(this);
		}
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Operador.Modificar.FormContacto formContato){
			formContato.txtNombre.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formContato.txtApellidoPat.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formContato.txtApellidoMat.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formContato.txtTelefono.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formContato.txtCalle.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formContato.txtNumInterior.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formContato.txtNumExterior.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formContato.txtColonia.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formContato.txtMunicipio.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formContato.txtEstado.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formContato.txtCP.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
		
		//--EVENTO_INICIO_DE_INTERFAZ
		void FormContactoLoad(object sender, EventArgs e){
			getCargarDato();
		}
		
		#region CARGAR_MODIFICAR_DATOS_DE_LA_LISTA
		private void getCargarDato(){
			txtNombre.Text=lista[indice].nombre;
			txtApellidoPat.Text=lista[indice].apellidoPat;
			txtApellidoMat.Text=lista[indice].apellidoMat;
			txtTelefono.Text=lista[indice].telefono;
			txtCalle.Text=lista[indice].calle;
			txtNumInterior.Text=lista[indice].numInterior;
			txtNumExterior.Text=lista[indice].numExterior;
			txtColonia.Text=lista[indice].colonia;
			txtMunicipio.Text=lista[indice].municipio;
			txtEstado.Text=lista[indice].estado;
			txtCP.Text=lista[indice].cp;
		}
		
		private void getCargarModificar(){
			lista[indice].nombre=txtNombre.Text;
			lista[indice].apellidoPat=txtApellidoPat.Text;
			lista[indice].apellidoMat=txtApellidoMat.Text;
			lista[indice].telefono=txtTelefono.Text;
			lista[indice].calle=txtCalle.Text;
			lista[indice].numInterior=txtNumInterior.Text;
			lista[indice].numExterior=txtNumExterior.Text;
			lista[indice].colonia=txtColonia.Text;
			lista[indice].municipio=txtMunicipio.Text;
			lista[indice].estado=txtEstado.Text;
			lista[indice].cp=txtCP.Text;
		}
		#endregion
		
		#region EVENTO_DE_LOS_BOTONES:(ACEPTAR - CANCELAR)
		void BtnAgregarClick(object sender, EventArgs e){
			if(!getValidarCampo()){
				getCargarModificar();
				this.Close();
			}else{
				MessageBox.Show("La actualización de los datos del contacto no se puede llevar a cabo porque existen campos aun sin completar.","Modificar licencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			
		}
		#endregion
		
		private bool getValidarCampo(){
			txtNombre.BackColor			=(txtNombre.Text=="")?Color.LightPink:Color.White;
			txtApellidoPat.BackColor	=(txtApellidoPat.Text=="")?Color.LightPink:Color.White;	
			txtApellidoMat.BackColor	=(txtApellidoMat.Text=="")?Color.LightPink:Color.White;
			txtTelefono.BackColor		=(txtTelefono.Text=="")?Color.LightPink:Color.White;
			txtCalle.BackColor			=(txtCalle.Text=="")?Color.LightPink:Color.White;
			txtNumInterior.BackColor	=(txtNumInterior.Text=="")?Color.LightPink:Color.White;
			txtColonia.BackColor		=(txtColonia.Text=="")?Color.LightPink:Color.White;			
			txtMunicipio.BackColor		=(txtMunicipio.Text=="")?Color.LightPink:Color.White;
			txtEstado.BackColor			=(txtEstado.Text=="")?Color.LightPink:Color.White;
			return (txtNombre.Text=="" || txtApellidoPat.Text=="" || txtApellidoMat.Text=="" || txtTelefono.Text==""  || txtCalle.Text=="" || txtNumInterior.Text=="" || txtColonia.Text=="" || txtMunicipio.Text=="" || txtEstado.Text=="" || txtCP.Text=="" )?true:false;
		}
	}
}
