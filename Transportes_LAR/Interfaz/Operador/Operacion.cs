using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador
{
	public class Operacion
	{
		private Interfaz.Operador.FormOperador operador=null;
		
		#region SOBRECARGA_DE_CONSTRUCTORES
		public Operacion(){	
		}
		
		public Operacion(Interfaz.Operador.FormOperador operador){
			this.operador=operador;
		}
		#endregion
		
		public bool getValidarCampo(){
			operador.txtAlias.BackColor					=(operador.txtAlias.Text=="")?Color.LightPink:Color.White;
			operador.txtNombre.BackColor				=(operador.txtNombre.Text=="")?Color.LightPink:Color.White;
			operador.txtApellidoPat.BackColor			=(operador.txtApellidoPat.Text=="")?Color.LightPink:Color.White;
			operador.txtApellidoMat.BackColor			=(operador.txtApellidoMat.Text=="")?Color.LightPink:Color.White;
			operador.txtCurp.BackColor					=(operador.txtCurp.Text=="")?Color.LightPink:Color.White;
			operador.txtRFC.BackColor					=(operador.txtRFC.Text=="")?Color.LightPink:Color.White;
			operador.txtNSS.BackColor					=(operador.txtNSS.Text=="")?Color.LightPink:Color.White;
			operador.txtLugarNacimiento.BackColor		=(operador.txtLugarNacimiento.Text=="")?Color.LightPink:Color.White;
			operador.txtEstadoNacimiento.BackColor		=(operador.txtEstadoNacimiento.Text=="")?Color.LightPink:Color.White;
			operador.txtMunicipioNacimiento.BackColor	=(operador.txtMunicipioNacimiento.Text=="")?Color.LightPink:Color.White;
			operador.txtCalle.BackColor					=(operador.txtCalle.Text=="")?Color.LightPink:Color.White;
			operador.txtColonia.BackColor				=(operador.txtColonia.Text=="")?Color.LightPink:Color.White;
			operador.txtMunicipio.BackColor				=(operador.txtMunicipio.Text=="")?Color.LightPink:Color.White;
			operador.txtEstado.BackColor				=(operador.txtEstado.Text=="")?Color.LightPink:Color.White;
			operador.txtReferencia1.BackColor			=(operador.txtReferencia1.Text=="")?Color.LightPink:Color.White;
			operador.txtReferencia2.BackColor			=(operador.txtReferencia2.Text=="")?Color.LightPink:Color.White;
			operador.txtNumExterior.BackColor			=(operador.txtNumExterior.Text=="")?Color.LightPink:Color.White;
			operador.txtCP.BackColor					=(operador.txtCP.Text=="")?Color.LightPink:Color.White;
			
			return (operador.txtAlias.Text=="" || 
			        operador.txtNombre.Text=="" || 
			        operador.txtApellidoPat.Text=="" || 
			        operador.txtApellidoMat.Text=="" ||	
			        operador.txtCurp.Text=="" ||
			        operador.txtRFC.Text=="" ||  
			        operador.txtNSS.Text=="" ||	
			        operador.txtLugarNacimiento.Text=="" ||	
			        operador.txtEstadoNacimiento.Text=="" ||
			        operador.txtMunicipioNacimiento.Text=="" ||	
			        operador.dateFechaNacimiento.Text=="" || 
			        operador.txtCalle.Text=="" ||
			        operador.txtColonia.Text=="" ||
			        operador.txtMunicipio.Text=="" ||
			        operador.txtEstado.Text=="" ||
			        operador.txtReferencia1.Text=="" ||
			        operador.txtReferencia2.Text=="" ||
			        operador.txtNumExterior.Text=="" ||
			        operador.txtCP.Text=="" )?true:false ;
		}
		
		//--SEPARAR_FECHA
		public int[] getDivisionFecha(string fecha){
			int [] date=new int[3];
			try{
				date[0]=Convert.ToInt32(fecha.Substring(0,2));
				date[1]=Convert.ToInt32(fecha.Substring(3,2));
				date[2]=Convert.ToInt32(fecha.Substring(6,4));
			}catch{
				date[0]=Convert.ToInt32(fecha.Substring(0,4));
				date[1]=Convert.ToInt32(fecha.Substring(5,2));
				date[2]=Convert.ToInt32(fecha.Substring(8,2));
			}
			
			return date;
		}
		
		public void getLimpiarCampos(){
			operador.txtAlias.Text				="";
			operador.txtNombre.Text				="";
			operador.txtApellidoPat.Text		="";
			operador.txtApellidoMat.Text		="";
			operador.txtCurp.Text				="";
			operador.txtRFC.Text				="";
			operador.txtNSS.Text				="";
			operador.txtLugarNacimiento.Text	="";
			operador.txtEstadoNacimiento.Text	="";
			operador.txtMunicipioNacimiento.Text="";
			operador.txtCalle.Text				="";
			operador.txtColonia.Text			="";
			operador.txtMunicipio.Text			="";
			operador.txtEstado.Text				="";
			operador.txtReferencia1.Text		="";
			operador.txtReferencia2.Text		="";
			operador.txtNumInterior.Text		="";
			operador.txtNumExterior.Text		="";
			operador.txtCP.Text					="";
			operador.cmbEstado.SelectedIndex	 	=0;
			operador.cmbEstadoCivil.SelectedIndex	=0;
			operador.cmbZona.SelectedIndex		 	=0;
			operador.ptbImagen.Image=null;
			operador.ptbImagen.Image=Image.FromFile("Camara.png");
			operador.direccionImagen="";
			operador.dateFechaNacimiento.Value=DateTime.Today;
		}
	}
}
