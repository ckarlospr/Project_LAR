using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor
{
	public class SQL_Conexion
	{
		//--VARIABLES_SQLServer
        public SqlConnection conexion=null;
       	public SqlCommand comando=null;
       	protected DataTable tabla;
		protected SqlDataAdapter adaptar;
		public SqlDataReader leer=null;
		
		//--CONSTRUCTOR
		public SQL_Conexion(){		
			this.conexion= new SqlConnection();
            this.comando = new SqlCommand();
		}
		
		//--ABRIENDO_LA_CONEXION_AL_SERVIDOR
		public SqlCommand getAbrirConexion(String consulta){
			try{
				conexion.ConnectionString = new Conexion_Servidor.Servidor().getCadenaConexion();
            	comando.Connection = conexion;
            	comando.CommandText =consulta;
       			conexion.Open();
       			return comando;
			}catch{
				MessageBox.Show("Error de acceso a la base de datos, verifique que la conexión al servidor se encuentre establecida y que la configuración sea la correcta.", "Error 001.",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return null;
			}
		}
		
		//--ADAPTADOR_DE_CONSULTA
		public  DataTable getaAdaptadorTabla(string consulta)
		{
			try
			{
				conexion.ConnectionString = new Conexion_Servidor.Servidor().getCadenaConexion();
           		comando.Connection = conexion;
       			conexion.Open();
				tabla=new DataTable();
				adaptar=new SqlDataAdapter(consulta,conexion);
				adaptar.Fill(tabla);
				conexion.Close();
				return tabla;	
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error durante la generación del adaptador, verifique que la consulta sea correcta. "+ex.ToString().Substring(0,90),"Error 002",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return null;
			}
		}
		
		//--CADENA_CONEXION
		public bool getPruebaConexion(string servidor,string instancia,string dataBase, string usuario ,string contrasena)
		{
			string cadena="";
			cadena="server="+servidor;
			cadena+="\\"+instancia;
			cadena+=";user="+usuario;
			cadena+=";password="+contrasena;
			cadena+=";database="+dataBase;
			
			try
			{
				conexion.ConnectionString = cadena;
            	conexion.Open();
            	conexion.Close();
            	return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
