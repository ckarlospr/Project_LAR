using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Usuario
{
	public partial class FormModificarCuenta : Form
	{
		
		private Interfaz.FormPrincipal principal=null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public FormModificarCuenta(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		
		//--EVENTO_INICIO_DE_FORM
		void FormModificarCuentaLoad(object sender, EventArgs e)
		{
			txtNombreUsuario.Text=this.principal.nombreUsuario;
		}
		
		#region EVENTO_DE_LOS_BOTONES (ACEPTAR - CANCELAR)
		
		void BtnAceptarClick(object sender, EventArgs e){
			if(getCampoVacio())
			{
				MessageBox.Show("Para poder llevar a cabo la actualización de los datos es necesario llenar todos los campos.","Modificar cuenta de usuario",MessageBoxButtons.OK,MessageBoxIcon.Question);
			}
			else
			{
				if(txtNuevaContrasena.Text==txtNuevaContrasena2.Text)
				{
					error.SetError(this.txtNuevaContrasena2,"");
					DialogResult result=MessageBox.Show("Su cuenta será modificada con los nuevos datos ingresados ¿Desea continuar con la modificación?","Modificar cuenta de usuario",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
					if(result==DialogResult.Yes)
					{
						if(new Conexion_Servidor.Usuario.SQL_Usuario().getActualizarUsuario(this.principal.nombreUsuario,txtContrasenaActual.Text,txtNombreUsuario.Text,txtNuevaContrasena.Text, cmbNivelUsuario))
						{
							this.principal.mostrar=false;
							new Interfaz.FormMensaje("Datos del usuario modificados").ShowDialog();
							MessageBox.Show("Para almacenar y aplicar los cambios la aplicación se reiniciara.","Modificar cuenta de usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);
							Application.Restart();
						}
						else
						{
							MessageBox.Show("La contraseña que ingreso como actual no es correcta, veirifique los datos ingresados.","Error de contraseña del usuario",MessageBoxButtons.OK,MessageBoxIcon.Error);
						}
					}else if(result==DialogResult.Cancel){
						this.Close();
					}
				}else{
					MessageBox.Show("La confirmación de la nueva contraseña no coincide con la contraseña nueva ingresada, verifi que los datos ingresados en el aparatado de nueva contraseña sean identicos.","Cambio de contraseña incorrecta",MessageBoxButtons.OK,MessageBoxIcon.Error);
					error.SetError(this.txtNuevaContrasena2,"Confirmación de contraseña incorrecta.");
				}
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		
		#endregion
		
		//--VALIDACIONS_DE_CAMPOS_VACIOS
		private bool getCampoVacio()
		{
			txtNombreUsuario.BackColor		=(txtNombreUsuario.Text=="")?Color.LightPink:Color.White;
			txtContrasenaActual.BackColor	=(txtContrasenaActual.Text=="")?Color.LightPink:Color.White;
			txtNuevaContrasena.BackColor	=(txtNuevaContrasena.Text=="")?Color.LightPink:Color.White;
			txtNuevaContrasena2.BackColor	=(txtNuevaContrasena2.Text=="")?Color.LightPink:Color.White;
			return (txtNombreUsuario.Text=="" || txtContrasenaActual.Text=="" ||txtNuevaContrasena.Text=="" ||txtNuevaContrasena2.Text=="" )?true:false;
		}
		
	}
}
