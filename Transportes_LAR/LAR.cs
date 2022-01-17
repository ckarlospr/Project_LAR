using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR
{
	public partial class LAR : Form
	{
		#region CONSTRUCTOR
		public LAR(){
			InitializeComponent();
			tmrContador.Enabled = true;
		}
		#endregion
		
		#region TMRCONTADOR
		void TmrContadorTick(object sender, EventArgs e)
		{
            if (progressBar.Value<100){
                progressBar.Value +=1;
            }
            else{
                tmrContador.Enabled = false;
                if(!new Archivo_Configuracion.Directorio().getValidacionArchivo())
                {
                	MessageBox.Show("Para poder iniciar el sistema es necesario que ingrese en la siguiente ventana la configuración de la conectividad al servidor.", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                	new Interfaz.Configuracion.FormConfiguracion().Show();
                }else if(new Conexion_Servidor.Usuario.SQL_Usuario().getCantidadUsuario()=="0"){
                	MessageBox.Show("Para poder ingresar al sistema es necesario registrar un nuevo usuario debido a que aun no se encuentra registrado alguno en la base de datos.", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                	new Interfaz.Usuario.FormUsuario(0).Show();
                }else if(new Conexion_Servidor.Usuario.SQL_Usuario().getCantidadUsuario()=="Error"){
                	DialogResult result=MessageBox.Show("Se ha creado una falla durante la conexión al servidor, verifique que la conexión a su servidor se encuentre establecida y que sea correcta, o de lo contrario para poder iniciar el sistema es necesario que reconfigure la conectividad al servidor o si no el sistema se cerrara por falla de conectividad.\n\n¿Desea llevar a cabo la configuración en este momento?","Error durante la conexión al servidor.",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                	if(DialogResult.OK==result)
                		new Interfaz.Configuracion.FormConfiguracion().Show();
                	else
                		Application.Exit();
                }else{
                	new Interfaz.FormLogin().Show();
                }
                this.Visible=false;
            }
		}
		#endregion
	}
}
