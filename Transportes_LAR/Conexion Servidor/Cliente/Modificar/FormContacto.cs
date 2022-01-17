using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Cliente.Modificar
{
	public partial class FormContacto : Form
	{
		#region VARIABLES
		private int indice=0;
		#endregion
		
		#region LISTAS
		private List<Interfaz.Cliente.Dato.Contacto> lista=null;
		#endregion
		
		#region CONSTRUCTOR_DE_LA_CLASE
		public FormContacto(int indice,List<Interfaz.Cliente.Dato.Contacto> lista){
			InitializeComponent();
			this.indice=indice;
			this.lista=lista;
			getCargarValidacionCampos(this);
		}
		#endregion 
		
		#region EVENTO_INICIO_DE_INTERFAZ
		void FormContactoLoad(object sender, EventArgs e){
			getCargarDato();
		}
		#endregion 
		
		#region CARGAR_MODIFICAR_DATOS_DE_LA_LISTA
		private void getCargarDato(){
			txtNombre.Text=lista[indice].nombre;
			txtTelefono.Text=lista[indice].telefono;
			txtExtension.Text=lista[indice].extension;
			txtCelularNextel.Text=lista[indice].celularNextel;
			txtCorreo.Text=lista[indice].correo;
		}
		
		private void getCargarModificar(){
			lista[indice].nombre=txtNombre.Text;
			lista[indice].telefono=txtTelefono.Text;
			lista[indice].extension=txtExtension.Text;
			lista[indice].celularNextel=txtCelularNextel.Text;
			lista[indice].correo=txtCorreo.Text;
		}
		#endregion
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Cliente.Modificar.FormContacto formContacto){
			formContacto.txtNombre.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formContacto.txtTelefono.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formContacto.txtExtension.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formContacto.txtCelularNextel.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		#endregion
		
		#region EVENTO_DE_LOS_BOTONES:(ACEPTAR - CANCELAR)
		void BtnAceptarClick(object sender, EventArgs e){
			if(txtNombre.Text!="" && txtTelefono.Text!="" && txtExtension.Text!="" && txtCelularNextel.Text!="" && txtCorreo.Text!=""){
				getCargarModificar();
				this.Close();
			}else{
				MessageBox.Show("La actualización de los datos del contacto no se puede llevar a cabo porque existen campos aun sin completar.","Modificar licencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
	}
}
