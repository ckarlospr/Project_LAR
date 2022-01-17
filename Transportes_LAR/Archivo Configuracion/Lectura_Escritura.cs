using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Archivo_Configuracion
{
	public class Lectura_Escritura
	{	
		#region ATRIBUTO
		private string archivo="";
		private String[] arreglo=null;
		#endregion
		
		#region CONSTRUCTOR
		public Lectura_Escritura()
		{
			this.archivo=System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Dropbox\TrasportesLar_Configuracion\Servidor\Configuracion.txt";
			//this.archivo=System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\TrasportesLar_Configuracion\Servidor\Configuracion.txt";
			arreglo=new String[10];
		}
		#endregion
		
		#region ESCRIBIR_CONFIGURACION
		public void getEscribir(string direccion,string instancia,string baseD ,string usuario,string contrasena)
		{
			try
			{
				FileStream stream = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
    			StreamWriter writer = new StreamWriter(stream);
    			writer.WriteLine(new Archivo_Configuracion.EncriptarDato().Encriptar(direccion));
    			writer.WriteLine(new Archivo_Configuracion.EncriptarDato().Encriptar(instancia));
    			writer.WriteLine(new Archivo_Configuracion.EncriptarDato().Encriptar(baseD));
    			writer.WriteLine(new Archivo_Configuracion.EncriptarDato().Encriptar(usuario));
    			writer.WriteLine(new Archivo_Configuracion.EncriptarDato().Encriptar(contrasena));
    			writer.Close();
			}
			catch
			{
				MessageBox.Show("Error de acceso de escritura a los archivos de configuración, verifique que el archivo de configuración no se encuentre abierto o utilizado por otra aplicación.", "Error 001 Conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		#endregion
		
		#region LEER_CONFIGURACION
		public Object[] getLeer()
		{
			try
			{
				arreglo=File.ReadAllLines(archivo);	
			}
			catch
			{
				MessageBox.Show("Error de acceso de escritura a los archivos de configuración, verifique que el archivo de configuración no se encuentre abierto o utilizado por otra aplicación.", "Error 002",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return arreglo;
		}
		#endregion
	}
}
