using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Usuario
{
	public class Operacion
	{
		private Interfaz.Usuario.FormUsuario usuario=null;
		
		public Operacion(Interfaz.Usuario.FormUsuario usuario){
			this.usuario=usuario;
		}
		
		public bool getValidarCampo(){
			usuario.txtNombre.BackColor					=(usuario.txtNombre.Text=="")?Color.LightPink:Color.White;
			usuario.txtApellidoPaterno.BackColor		=(usuario.txtApellidoPaterno.Text=="")?Color.LightPink:Color.White;	
			usuario.txtApellidoMaterno.BackColor		=(usuario.txtApellidoMaterno.Text=="")?Color.LightPink:Color.White;
			usuario.txtUsuario.BackColor				=(usuario.txtUsuario.Text=="")?Color.LightPink:Color.White;				
			usuario.txtContrasena.BackColor				=(usuario.txtContrasena.Text=="")?Color.LightPink:Color.White;
			usuario.txtContrasenaRepeticion.BackColor	=(usuario.txtContrasenaRepeticion.Text=="")?Color.LightPink:Color.White;				
			return (usuario.txtNombre.Text=="" || usuario.txtApellidoPaterno.Text=="" || usuario.txtApellidoMaterno.Text=="" || usuario.txtUsuario.Text=="" || usuario.txtContrasena.Text=="" || usuario.txtContrasenaRepeticion.Text=="")?false:true;
		}
		
		public void getLimpiarCampo(DataGridView tabla){
			usuario.txtNombre.Text="";
			usuario.txtApellidoPaterno.Text="";
			usuario.txtApellidoMaterno.Text="";
			usuario.txtUsuario.Text="";
			usuario.txtContrasena.Text="";
			usuario.txtContrasenaRepeticion.Text="";
			usuario.txtNombre.BackColor					=Color.White;
			usuario.txtApellidoPaterno.BackColor		=Color.White;	
			usuario.txtApellidoMaterno.BackColor		=Color.White;
			usuario.txtUsuario.BackColor				=Color.White;				
			usuario.txtContrasena.BackColor				=Color.White;
			usuario.txtContrasenaRepeticion.BackColor	=Color.White;			
			getLimpiarPrivilegio(tabla,0);
		}
		
		private object getLimpiarPrivilegio(DataGridView tabla, int contador){
			tabla[0,contador].Value=false;
			return (contador<Convert.ToInt32(tabla.Rows.Count.ToString())-1)? getLimpiarPrivilegio(tabla,++contador):null;
		}
		
		public bool getCampoLleno(){				
			return (usuario.txtNombre.Text!="" || usuario.txtApellidoPaterno.Text!="" || usuario.txtApellidoMaterno.Text!="" || usuario.txtUsuario.Text!="" || usuario.txtContrasena.Text!="" || usuario.txtContrasenaRepeticion.Text!="")?true:false;
		}
	}
}
