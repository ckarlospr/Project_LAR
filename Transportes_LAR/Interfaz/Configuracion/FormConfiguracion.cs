using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Configuracion
{
	public partial class FormConfiguracion : Form
	{
		#region VARIABLE
		private string mensaje="";
		private int contador=0;
		#endregion
		
		#region INSTANCIAS
		private Interfaz.FormPrincipal principal=null;
		#endregion
		
		#region SOBRECARGA_DE_CONSTRUCTORES
		public FormConfiguracion(){
			InitializeComponent();
			this.mensaje="Conexión establecida";
		}
		
		public FormConfiguracion(FormPrincipal principal,string mensaje){
			InitializeComponent();
			this.mensaje=mensaje;
			this.principal=principal;
			getCargarConfiguracion();
		}
		
		#endregion
		
		#region EVENTOS_DE_LOS_BUTONES (ACEPTAR_CANCELAR)
		
		void BtnAceptarClick(object sender, EventArgs e){
			if(new Interfaz.Configuracion.Operacion(this).getCampoVacio()){//VALIDA CAMPOS
				MessageBox.Show("Para poder guardar la configuración es necesario llenar cada uno de los campos con los datos solicitados.","Campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}else{
				if(new Conexion_Servidor.SQL_Conexion().getPruebaConexion(txtDireccion.Text,txtInstancia.Text,txtBase.Text, txtUsuario.Text , txtContrasena.Text)){//PROBANDO_LOS_DATOS_DE_CONEXION
					new Interfaz.FormMensaje(mensaje).ShowDialog();//ENVIANDO_MENSAJE_AL_USUARIO
					new Archivo_Configuracion.Lectura_Escritura().getEscribir(txtDireccion.Text,txtInstancia.Text,txtBase.Text ,txtUsuario.Text,txtContrasena.Text);//ESCRIBE_LA_CONFIGURACION_DENTRO_DE_UN_TXT
					if(mensaje!="Conexión establecida"){
						this.principal.mostrar=false;
						MessageBox.Show("La aplicación se cerrara para cargar la nueva configuración.","Actualización de datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
						Application.Exit();
					}else{
						if(new Conexion_Servidor.Usuario.SQL_Usuario().getCantidadUsuario()=="0"){
							DialogResult result=MessageBox.Show("Actualmente no se pude iniciar el sistema debido a que no se encuentra registrado un usuario dentro de la base de datos\n¿Desea registrar un nuevo usuario dentro de la base de datos?","Base de datos sin usuarios registrados",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
							if(DialogResult.Yes==result){
								new Interfaz.Usuario.FormUsuario(0).Show();
								this.Close();
							}else if (DialogResult.No==result){
								MessageBox.Show("La aplicación se cerrara debido a que no existe un usuario para iniciar el sistema.\nPara poder registrar un usuario es necesario abrir de nuevo la aplicación.","Base de datos sin registros.",MessageBoxButtons.OK,MessageBoxIcon.Information);
								Application.Exit();
							}
						}else{
							new Interfaz.FormLogin().Show();
							this.Close();
						}
					}
				}else{
					txtContrasena.Text="";
					MessageBox.Show("El programa no se pudo conectar con el servidor de base de datos, verifique que los datos ingresados sean los correctos.","Conexión fallida",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		
		#endregion
			
		#region VERFIFICANDO_EXISTENCIA_DE_CONFIGURACION
		private bool getConfiguracion(){
			return (new Conexion_Servidor.Servidor().getServidor()!=null)?true:false;
		}
		#endregion
		
		#region EVENTO_DE_CIERRE_DE_VENTANA
		void FormConfiguracionFormClosing(object sender, FormClosingEventArgs e){
			if(mensaje=="Conexión establecida"){
				if(contador==0){
					if(!getConfiguracion()){
						DialogResult resul= MessageBox.Show("La aplicación se cerrara debido a que no existe ninguna configuración almacenada para conectar al servidor de base de datos.\n¿Desea continuar con el cierre?","Configuración no establecida",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
						if(resul==DialogResult.Cancel){
							contador=0;
							e.Cancel=true;
						}else{
							contador=1;
							Application.Exit();
						}
					}
				}else{
					Application.Exit();
				}	
			}
		}
		#endregion
		
		#region GET_CARGAR_CONFIGURACION _ANTIGUA
		private void getCargarConfiguracion(){
			if(new Archivo_Configuracion.Directorio().getValidacionArchivo()){
				txtDireccion.Text=(new Conexion_Servidor.Servidor().getServidor()!=null)?	new Conexion_Servidor.Servidor().getServidor():"";
				txtInstancia.Text=(new Conexion_Servidor.Servidor().getInstancia()!=null)?	new Conexion_Servidor.Servidor().getInstancia():"";
				txtBase.Text=	  (new Conexion_Servidor.Servidor().getBase()!=null)?		new Conexion_Servidor.Servidor().getBase():"";
				txtUsuario.Text=  (new Conexion_Servidor.Servidor().getUsuario()!=null)?	new Conexion_Servidor.Servidor().getUsuario():"";
				txtContrasena.Text="";
			}else{
				MessageBox.Show("La aplicación se cerrara debido a que los archivos de configuración no se encontraron en el destino predefinido.","Configuración no encontrada",MessageBoxButtons.OK,MessageBoxIcon.Error);
				Application.Exit();
			}
		}
		#endregion
		
		#region EVITANDO_QUE_SE_INICIE_CON_ESPACIO
		void TxtDireccionTextChanged(object sender, EventArgs e){
			txtDireccion.Text=(txtDireccion.Text==" ")?txtDireccion.Text="":txtDireccion.Text;
			txtInstancia.Text=(txtInstancia.Text==" ")?txtInstancia.Text="":txtInstancia.Text;
			txtBase.Text=(txtDireccion.Text==" ")?txtBase.Text="":txtBase.Text;
			txtUsuario.Text=(txtUsuario.Text==" ")?txtUsuario.Text="":txtUsuario.Text;
			txtContrasena.Text=(txtContrasena.Text==" ")?txtContrasena.Text="":txtDireccion.Text;
		}
		#endregion
		
		void FormConfiguracionLoad(object sender, EventArgs e)
		{
			//this.MdiParent=principal;
		}
	}
}
