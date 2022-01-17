using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Transportes_LAR.Archivo_Configuracion
{
	public class Directorio
	{
		#region ATRIBUTOS
		private DirectoryInfo DIR_Configuracion = new DirectoryInfo(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Dropbox\TrasportesLar_Configuracion");
		private DirectoryInfo DIR_Servidor = new DirectoryInfo(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Dropbox\TrasportesLar_Configuracion\Servidor");
		private DirectoryInfo DIR_Imagen = new DirectoryInfo(System.Environment.SystemDirectory.Substring(0, 3) +@"\Imagenes"); 
		private string path = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Dropbox\TrasportesLar_Configuracion\Servidor\Configuracion.txt";
		#endregion
		
		#region CONSTRUCTOR
		public Directorio()
		{
			
		}
		#endregion
		
		#region DIRECTORIO_CONFIGURACION
		private	 Boolean getCarpeta(){
			if(DIR_Configuracion.Exists){
				return true;
			}else{
				DIR_Configuracion.Create();
				return false;
			}
	    }
		
		private Boolean getSubCarpeta(){
			if (DIR_Servidor.Exists){
		        return true;
			}else{
				DIR_Servidor.Create();
		        return false;
			}
		}
		
		private Boolean getArchivo(){
			if(File.Exists(path)){
				return true;
			}else{
				using (File.Create(path)){
					return false;
				}
			}
		}
		#endregion
		
		#region VALIDANDO_DATOS_DE_CONFIGURACION
		public Boolean getExistencia()
		{
			StreamReader objReader = new StreamReader(path);
			string sLine="";
			sLine = objReader.ReadLine();
			objReader.Close();
			return (sLine!=null)?true:false;
		}
		#endregion
		
		#region EVALUANDO_EXISTENCIA_DE_ARCHIVOS
		public Boolean getValidacionArchivo()
		{
			bool estado=true;
			if(!getCarpeta())
				estado = false;

			if(!getSubCarpeta())
				estado = false;
			
			if(!getArchivo())
				estado = false;
			
			if(!getExistencia())
				estado = false;

			return estado;
        }
		#endregion
		
	}
}
