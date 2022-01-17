using System;
using System.Drawing;
using Transportes_LAR.Interfaz.Aseguradora;

namespace Transportes_LAR.Proceso.LimpiarCampo
{
	public class LimpiarAseguradora
	{
		private FormAseguradoras aseguradora=null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public LimpiarAseguradora(FormAseguradoras aseguradora)
		{
			this.aseguradora=aseguradora;
		}
		
		//--LIMPIANDO_LOS_CAMPOS_DE_AGREGADO
		public void getLimpiarCampo(){
			aseguradora.txtNombre.Text="";
			aseguradora.txtDomicilio.Text="";
			aseguradora.txtTelefono.Text="";
			//--REGRESANDO_EL_COLOR_BLANCO
			aseguradora.txtNombre.BackColor=Color.White;
			aseguradora.txtDomicilio.BackColor=Color.White;
			aseguradora.txtTelefono.BackColor=Color.White;
		}
		
		//--VALIDACION_DE_CAMPOS_VACIOS
		public Boolean getValidarCampos()
		{
			Boolean estado=true;
			if(aseguradora.txtNombre.Text=="")
			{
				estado=false;
				aseguradora.txtNombre.BackColor=Color.LightPink;
			}
			else
				aseguradora.txtNombre.BackColor=Color.White;
		
			if(aseguradora.txtDomicilio.Text=="")
			{
				estado=false;
				aseguradora.txtDomicilio.BackColor=Color.LightPink;
			}
			else
				aseguradora.txtDomicilio.BackColor=Color.White;

			if(aseguradora.txtTelefono.Text=="")
			{
				estado=false;
				aseguradora.txtTelefono.BackColor=Color.LightPink;
			}
			else
				aseguradora.txtTelefono.BackColor=Color.White;
			
			return estado;
		}
	}
}
