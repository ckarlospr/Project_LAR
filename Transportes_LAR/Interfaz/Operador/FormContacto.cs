using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormContacto : Form
	{
		private Interfaz.Operador.FormOperador operador=null;//MEMORIA_INTERFAZ_OPERADOR
		private Interfaz.Operador.Dato.Contacto contacto=null;//MOMORIA_INTERFAZ_MODIFICAR_DATO_DE_LICENCIA
		
		//-CONSTRUCTOR_DE_LA_CLASE
		public FormContacto(Interfaz.Operador.FormOperador operador){
			InitializeComponent();
			this.operador=operador;
			getCargarValidacionCampos(this);
		}
		
		//-EVENTO_CIERRE_DE_VENTANA
		void FormContactoFormClosing(object sender, FormClosingEventArgs e){
			this.operador.contacto=false;
			operador.BringToFront();
		}
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Operador.FormContacto formContato){
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
		
		//--EVEMTO_INICIO_DE_VENTANA
		void FormContactoLoad(object sender, EventArgs e){
			if(operador.listContacto==null){
				this.operador.listContacto=new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Contacto>();
			}else{
				dataContacto.DataSource=this.operador.listContacto;
			}
		}
		
		
		#region EVENTO_BOTONES (AGREGAR - REMOVER)
		void BtnAgregarClick(object sender, EventArgs e){
			if(!getValidarCampo()){
				getCargarLista();
				getLimpiarCampo();
				dataContacto.DataSource= this.operador.listContacto;
				((CurrencyManager)dataContacto.BindingContext[operador.listContacto]).Refresh();
			}else{
				MessageBox.Show("Para poder agregar contacto es necesario llenar todos los campos con los datos correspondientes.","Agregar licencia",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		
		void BtnRemoverClick(object sender, EventArgs e){
			if(dataContacto.Rows.Count>0){
				if(DialogResult.Yes==MessageBox.Show("¿Desea remover al contacto seleccionada de la tabla?","Remover licencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question)){
					if(operador.listContacto[dataContacto.CurrentRow.Index].id !=null){
						new Conexion_Servidor.Operador.SQL_Contacto().getEliminarContacto(operador.listContacto[dataContacto.CurrentRow.Index].id);
					}
					this.operador.listContacto.RemoveAt(dataContacto.CurrentRow.Index);
					dataContacto.DataSource= this.operador.listContacto;
					((CurrencyManager)dataContacto.BindingContext[operador.listContacto]).Refresh();
				}	
			}
		}
		#endregion
		
		//--LIMPIAR_CAMPOS_DEL_FORMULARIO
		private void getLimpiarCampo(){
			txtNombre.Text			="";
			txtApellidoPat.Text		="";
			txtApellidoMat.Text		="";
			txtTelefono.Text		="";
			txtCalle.Text			="";
			txtNumInterior.Text		="";
			txtNumExterior.Text		="";
			txtColonia.Text			="";
			txtNumInterior.Text		="";
			txtNumExterior.Text		="";
			txtColonia.Text			="";
			txtMunicipio.Text		="";
			txtEstado.Text			="";
			txtCP.Text				="";
		}
		
		//--CARGAR_LICENCIA_A_LA_LISTA
		private void getCargarLista(){
			this.contacto=new Transportes_LAR.Interfaz.Operador.Dato.Contacto();
			contacto.nombre=txtNombre.Text;
			contacto.apellidoPat=txtApellidoPat.Text;
			contacto.apellidoMat=txtApellidoMat.Text;
			contacto.telefono=txtTelefono.Text;
			contacto.calle=txtCalle.Text;
			contacto.numInterior=txtNumInterior.Text;
			contacto.numExterior=txtNumExterior.Text;
			contacto.colonia=txtColonia.Text;
			contacto.municipio=txtMunicipio.Text;
			contacto.estado=txtEstado.Text;
			contacto.cp=txtCP.Text;
			this.operador.listContacto.Add(contacto);
		}
		
		
		private bool getValidarCampo()
		{
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
		
		//--EVENTO_BOTON_ACEPTAR
		void BtnAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//--EVENTO_DOBLE_CLICK_A_LA_CELDA
		void DataContactoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0){
				new Interfaz.Operador.Modificar.FormContacto(e.RowIndex,this.operador.listContacto).ShowDialog();
				dataContacto.DataSource= this.operador.listContacto;
				((CurrencyManager)dataContacto.BindingContext[operador.listContacto]).Refresh();				
			}
		}
	}
}
