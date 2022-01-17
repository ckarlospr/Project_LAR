using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using System.Windows;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace Transportes_LAR.Conexion_Servidor
{

	public class Servidor
	{
		//--ATRIBUTOS
		private string cadena="";
		private Object[] arreglo=null;
		
		//--CONSTRUCTOR
		public Servidor(){
			arreglo=new Archivo_Configuracion.Lectura_Escritura().getLeer();
		}
		
		//--CADENA_DE_CONEXION_AL_SERVIDOR
		public string getCadenaConexion(){
			cadena="server="+		new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[0]));
			cadena+="\\"+			new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[1]));
			cadena+=";user="+		new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[3]));
			cadena+=";password="+	new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[4]));
			cadena+=";database="+	new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[2]));
			return cadena;
		}
		
		
		//--DESENCRIPTACION_DE_DATOS_DE_CONFIGURACIÓN
		public string getServidor(){
			return (arreglo.Length==0)?null:new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[0]));
		}
		
		public string getInstancia(){
			return (arreglo.Length==0)?null:new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[1]));
		}
		
		public string getBase(){
			return (arreglo.Length==0)?null:new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[2]));
		}
		
		public string getUsuario(){
			return (arreglo.Length==0)?null:new Archivo_Configuracion.EncriptarDato().Desencriptar(Convert.ToString(arreglo[3]));
		}
	}
}
