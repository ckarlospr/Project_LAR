using System;

namespace Transportes_LAR.Conexion_Servidor
{
	public class Evaluacion:Conexion_Servidor.SQL_Conexion
	{
		public Evaluacion():base()
		{}
		
		//RETORNO_DE_NUMERO_DE_FILAS *RETORNO CANTIDAD
		public string getNumFila(string consulta)
		{
			string cantidad="";
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			if(leer.Read())
			{
				cantidad=base.leer["Cantidad"].ToString();
				base.conexion.Close();
				return cantidad;
			}
			base.conexion.Close();
			return "0";
		}
		
	}
}
