using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Cliente
{
	public partial class FormCliente : Form
	{
		#region INSTANCIAS
		public  List<Interfaz.Cliente.Dato.Contacto> listContacto=null; 
		private Interfaz.Cliente.FormContacto formContacto=null;
		private Interfaz.Cliente.FormBusquedaCliente formBusquedaCliente=null;
		#endregion
		
		#region VARIABLES COMPONENTES
		private DataGridView tabla=null;
		#endregion
		
		#region VARIABLES
		public static bool contacto=false;
		public static bool mostrarMsmCierre=true;
		private string idCliente="";
		private int variable=0;
		#endregion 
		
		#region CONSTRUCTOR_DE_LA_CLASE
		public FormCliente(DataGridView tabla,Interfaz.Cliente.FormBusquedaCliente formBusquedaCliente){
			InitializeComponent();
			this.tabla=tabla;
			this.formBusquedaCliente=formBusquedaCliente;
		}
		#endregion 
	
		#region VALIDAR_CAMPOS_VACIOS
		private bool getValidarCampo(){
			txtEmpresa.BackColor		=(txtEmpresa.Text=="")?Color.LightPink:Color.White;
			txtSubNombre.BackColor		=(txtSubNombre.Text=="")?Color.LightPink:Color.White;
			txtDomicilio.BackColor		=(txtDomicilio.Text=="")?Color.LightPink:Color.White;
			txtZonaReferencia.BackColor	=(txtZonaReferencia.Text=="")?Color.LightPink:Color.White;
			txtMunicipio.BackColor		=(txtMunicipio.Text=="")?Color.LightPink:Color.White;
			txtEstado.BackColor			=(txtEstado.Text=="")?Color.LightPink:Color.White;
			txtRumbo.BackColor			=(txtRumbo.Text=="")?Color.LightPink:Color.White;
			cmbTipoCobro.BackColor		=(cmbTipoCobro.Text=="")?Color.LightPink:Color.White;
			return (txtEmpresa.Text==""  ||
			       	txtSubNombre.Text==""||
			       	txtDomicilio.Text==""		||
			       	txtZonaReferencia.Text==""  ||
			       	txtMunicipio.Text==""||
			       	txtEstado.Text==""||
			       	txtRumbo.Text==""
			       )?true:false;
		}
		#endregion
		
		#region LIMPIAR CAMPOS_DEL_FORMULARIO
		private void getLimpiarCampo(){
			txtEmpresa.Text="";
			txtSubNombre.Text="";
			txtDomicilio.Text="";
			txtZonaReferencia.Text="";
			txtMunicipio.Text="";
			txtEstado.Text="";
			txtRumbo.Text="";
		}
		#endregion 
		
		#region EVENTO_DE_BOTON: (AGREGAR - CANCELAR)
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(getValidarCampo())
			{
				MessageBox.Show("Para poder almacenar al cliente es necesario tener todos los campos llenos.","Agregar cliente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else
			{
				if(!new Conexion_Servidor.Cliente.SQL_CLiente().getExistenciaCliente(txtEmpresa.Text,txtSubNombre.Text))
				{//VALIDA_SI_ESTA_REGISTRADO
					if(listContacto==null || listContacto.Count==0)
					{
						if(MessageBox.Show("Aun no se registran contactos de servicio para el cliente.\n¿Desea registrar contactos antes de almacenar al cliente?","Agregar cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
						{
							getContactoServicio();
						}
						else
						{
							getAlmacenarCliente();
						}
					}
					else
					{
						getAlmacenarCliente();
					}
				}	
			}
		}
		#endregion
		
		#region EVENTO_CIERRE_DE_VENTANA
		void FormClienteFormClosing(object sender, FormClosingEventArgs e)
		{
			if(variable==0)
			{
				this.variable=1;
				if(!getValidarCampo())
				{
					if(DialogResult.No== (MessageBox.Show("¿Dese cerrar la ventana sin guardar al cliente nuevo?","Agregar cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question)))
					{
						e.Cancel=true;
						this.variable=0;
					}
					else
					{
						if(contacto)
						{
							formContacto.Close();
						}
					}
				}
				else
				{
					if(contacto)
					{
						formContacto.Close();
					}
				}
			}	
		}
		#endregion 
		
		#region HERRAMIENTA_CONTACTO
		void ToolContactoClick(object sender, EventArgs e){
			getContactoServicio();
		}
		#endregion 
		
		#region INSERTAR_CLIENTE_NUEVO
		private void getInsertarCliente()
		{
			new Conexion_Servidor.Cliente.SQL_CLiente().getInsertarCliente("",
				                                                               txtEmpresa.Text,
				                                                               txtSubNombre.Text,
				                                                               txtDomicilio.Text,
				                                                               txtZonaReferencia.Text,
				                                                               txtMunicipio.Text,
				                                                               txtEstado.Text,
				                                                               txtRumbo.Text,
				                                                               cmbTipoCobro.Text
				                                                               );
			idCliente = new Conexion_Servidor.Cliente.SQL_CLiente().getIdCliente(txtEmpresa.Text,
			                                                               		txtSubNombre.Text,
			                                                               		txtDomicilio.Text,
			                                                              		txtZonaReferencia.Text,
			                                                               		txtMunicipio.Text,
			                                                               		txtEstado.Text,
			                                                               		txtRumbo.Text	
																			    );
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
		
		#region INTERFAZ_CONTACTO_DE_SERVICIO
		private void getContactoServicio(){
			if(contacto){
				if(formContacto.WindowState==FormWindowState.Minimized)
					formContacto.WindowState = FormWindowState.Normal;
				else
					formContacto.BringToFront();
			}else{
				this.formContacto=new Transportes_LAR.Interfaz.Cliente.FormContacto(this);
				formContacto.Show();
				contacto=true;
			}
		}
		#endregion
		
		#region INSERTAR_CLIENTE
		private void getAlmacenarCliente()
		{
			getInsertarCliente();
			getInsertarContacto(0);
			listContacto=null;
			getLimpiarCampo();
			if(contacto)
			{
				formContacto.Close();
			}
			new Interfaz.FormMensaje("Cliente almacenado exitosamente").Show();
			if(tabla!=null)
			{
				tabla.DataSource=new Conexion_Servidor.Cliente.SQL_CLiente().getTabla("select ID,Empresa,SubNombre FROM Cliente");
				formBusquedaCliente.getDatoCliente();
			}
		}
		#endregion
	}
}
