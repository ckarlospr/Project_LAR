
using System;

namespace Transportes_LAR.Conexion_Servidor.Aptomedico
{
	public class SQL_Aptomedico:SQL_Conexion
	{
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		public SQL_Aptomedico()
		{
		}
		
		public void InsertarApto(int ID, String NUMERO, String VIGENCIA)
		{
			base.getAbrirConexion("insert into APTOMEDICO (ID_OPERADOR, NUMERO, VIGENCIA) values ("+ID+", '"+NUMERO+"', '"+VIGENCIA+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void UpdateApto(int ID, String NUMERO, String VIGENCIA)
		{
			base.getAbrirConexion("Update APTOMEDICO set NUMERO='"+NUMERO+"', VIGENCIA='"+VIGENCIA+"' where ID="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void EliminarApto(int ID)
		{
			base.getAbrirConexion("delete from APTOMEDICO where ID="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
	}
}
