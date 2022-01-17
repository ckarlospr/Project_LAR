using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Cliente
{
	public partial class FormContacto : Form
	{
		#region DECLARACION_DE_INSTANCIAS
		private Interfaz.Cliente.FormCliente cliente=null;
		private Interfaz.Cliente.Dato.Contacto contacto=null;
		#endregion
		
		#region VARIABLES
		private int idCliente=0;
		#endregion
		
		#region LISTAS
		private List<Interfaz.Cliente.Dato.Contacto> listContacto=null;
		#endregion
		
		#region CONSTRUCTOR
		public FormContacto(Interfaz.Cliente.FormCliente cliente){//EVENTO_EJECUTADO_CUANDO_SE_REGISTRA_CONTACTO
			InitializeComponent();
			this.cliente=cliente;
			getCargarValidacionCampos(this);
		}
		
		public FormContacto(int idCliente){
			InitializeComponent();
			getCargarValidacionCampos(this);
			this.idCliente=idCliente;
		}
		#endregion
		
		#region METODO (LOAD - CLOSING)
		void FormContactoLoad(object sender, EventArgs e){
			if(idCliente==0){//EVENTO_EJECUTADO_CUANDO_SE_REGISTRA_CONTACTO
				if(cliente.listContacto==null){
					this.cliente.listContacto=new System.Collections.Generic.List<Transportes_LAR.Interfaz.Cliente.Dato.Contacto>();
				}else{
					dataContacto.DataSource= this.cliente.listContacto;
				}
			}else{
				listContacto=new Conexion_Servidor.Cliente.SQL_Contacto().getListContacto(idCliente.ToString());
				if(listContacto==null){
					listContacto=new List<Transportes_LAR.Interfaz.Cliente.Dato.Contacto>();
				}
				dataContacto.DataSource= this.listContacto;
			}
		}
		
		void FormContactoFormClosing(object sender, FormClosingEventArgs e){
			if(idCliente==0){
				Interfaz.Cliente.FormCliente.contacto=false;
			}
		}
		#endregion
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Cliente.FormContacto formContacto){
			formContacto.txtNombre.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formContacto.txtTelefono.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.numeroGuion);
			formContacto.txtExtension.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.numeroGuion);
			formContacto.txtCelularNextel.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.numeroGuion);
		}
		#endregion
		
		#region EVENTO_BOTON_AGREGAR
		void BtnAgregarClick(object sender, EventArgs e){
			if(txtNombre.Text!="" && txtTelefono.Text!="" && txtExtension.Text!="" && txtCelularNextel.Text!="" && txtCorreo.Text!=""){
				getCargarLista();
				getLimpiarCampo();
				if(idCliente==0){//EVENTO_EJECUTADO_CUANDO_SE_REGISTRA_CONTACTO
					dataContacto.DataSource=this.cliente.listContacto;
					((CurrencyManager)dataContacto.BindingContext[cliente.listContacto]).Refresh();	
				}else{
					dataContacto.DataSource=this.listContacto;
					((CurrencyManager)dataContacto.BindingContext[this.listContacto]).Refresh();	
				}
			}else{
				MessageBox.Show("Para poder agregar al contacto es necesario llenar todos los campos con los datos correspondientes.","Agregar contacto de servicio",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		#endregion
		
		#region CARGAR_ELEMENTOS_A_LA_LISTA
		private void getCargarLista(){
			this.contacto = new Transportes_LAR.Interfaz.Cliente.Dato.Contacto();
			contacto.nombre=txtNombre.Text;
			contacto.telefono=txtTelefono.Text;
			contacto.extension=txtExtension.Text;
			contacto.celularNextel=txtCelularNextel.Text;
			contacto.correo=txtCorreo.Text;
			if(idCliente==0){//EVENTO_EJECUTADO_CUANDO_SE_REGISTRA_CONTACTO
				cliente.listContacto.Add(contacto);	
			}else{
				listContacto.Add(contacto);
			}
		}
		#endregion
		
		#region LIMPIAR CAMPOS
		private void getLimpiarCampo(){
			txtNombre.Text="";
			txtTelefono.Text="";
			txtExtension.Text="";
			txtCelularNextel.Text="";
			txtCorreo.Text="";
		}
		#endregion
		
		#region REMOVER CONTACTO
		void BtnRemoverClick(object sender, EventArgs e){
			if(dataContacto.Rows.Count>0){
				if(DialogResult.Yes==MessageBox.Show("¿Desea remover al contacto de servicio seleccionada de la tabla?","Remover licencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question)){
					if(idCliente==0){//EVENTO_EJECUTADO_CUANDO_SE_REGISTRA_CONTACTO
						this.cliente.listContacto.RemoveAt(dataContacto.CurrentRow.Index);
						dataContacto.DataSource= this.cliente.listContacto;
						((CurrencyManager)dataContacto.BindingContext[cliente.listContacto]).Refresh();	
					}else{
						if(this.listContacto[dataContacto.CurrentRow.Index].id != null){
							new Conexion_Servidor.Cliente.SQL_Contacto().getEliminarContacto(listContacto[dataContacto.CurrentRow.Index].id);
 						}
						this.listContacto.RemoveAt(dataContacto.CurrentRow.Index);
						dataContacto.DataSource= this.listContacto;
						((CurrencyManager)dataContacto.BindingContext[this.listContacto]).Refresh();	
					}
				}	
			}
		}
		#endregion
		
		#region MODIFICAR CLIENTE
		void DataContactoCellDoubleClick(object sender, DataGridViewCellEventArgs e){
			if(e.RowIndex>=0){
				if(idCliente==0){//EVENTO_EJECUTADO_CUANDO_SE_REGISTRA_CONTACTO
					new Interfaz.Cliente.Modificar.FormContacto(e.RowIndex,this.cliente.listContacto).ShowDialog();
					dataContacto.DataSource= this.cliente.listContacto;
					((CurrencyManager)dataContacto.BindingContext[cliente.listContacto]).Refresh();		
				}else{
					new Interfaz.Cliente.Modificar.FormContacto(e.RowIndex,this.listContacto).ShowDialog();
					dataContacto.DataSource= this.listContacto;
					((CurrencyManager)dataContacto.BindingContext[listContacto]).Refresh();	
				}
			}
		}
		#endregion
		
		#region INSERTAR CONTACTO
		void BtnAceptarClick(object sender, EventArgs e){
			if(idCliente>0){//EVENTO_EJECUTADO_CUANDO_SE_REGISTRA_CONTACTO
				getInsertarContacto(0);
			}
			this.Close();
		}
		#endregion
		
		#region INSERTAR:CONTACTOS_DEL_CLIENTE
		private object getInsertarContacto(int contador){
			if(listContacto!=null && listContacto.Count>0){
				string id=(listContacto[contador].id==null)?"null":listContacto[contador].id;
				new Conexion_Servidor.Cliente.SQL_Contacto().getInsertarContacto(
					"almacenar_modificar_contactoServicio "+id	+",'" +
					listContacto[contador].nombre  				+"','"+
					listContacto[contador].telefono 			+"','"+
					listContacto[contador].extension			+"','"+
					listContacto[contador].celularNextel		+"','" +
					listContacto[contador].correo				+"'," +
					idCliente
				);
			}else{
				return null;
			}
			return (contador<(listContacto.Count-1))?getInsertarContacto(++contador):null;
		}
		#endregion
	}
}
