using System;
using System.Drawing;

namespace Transportes_LAR.Interfaz.Configuracion
{
	public class Operacion
	{
		#region INSTANCIAS
		private Interfaz.Configuracion.FormConfiguracion c=null;
		#endregion
		
		#region CONSTRUCTOR
		public Operacion(Interfaz.Configuracion.FormConfiguracion c){
			this.c=c;
		}
		#endregion
		
		#region VALIDACION_DE_CAMPOS_VACIOS
		public bool getCampoVacio(){
			c.txtDireccion.BackColor	=(c.txtDireccion.Text=="")?Color.LightPink:Color.White;
			c.txtInstancia.BackColor	=(c.txtInstancia.Text=="")?Color.LightPink:Color.White;
			c.txtBase.BackColor			=(c.txtBase.Text=="")?Color.LightPink:Color.White;
			c.txtUsuario.BackColor		=(c.txtUsuario.Text=="")?Color.LightPink:Color.White;
			c.txtContrasena.BackColor	=(c.txtContrasena.Text=="")?Color.LightPink:Color.White;
			return (c.txtDireccion.Text=="" || c.txtInstancia.Text=="" || c.txtBase.Text=="" || c.txtUsuario.Text=="" || c.txtContrasena.Text=="" )? true : false;
		}
		#endregion
	}
}
