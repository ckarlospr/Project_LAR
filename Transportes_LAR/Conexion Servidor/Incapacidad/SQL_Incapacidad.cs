using System;

namespace Transportes_LAR.Conexion_Servidor.Incapacidad
{
	public class SQL_Incapacidad:SQL_Conexion
	{
		public SQL_Incapacidad()
		{
		}
	
		public void InsertarIncapacidad(String ID_Operador, String Tipo, String FechaInicio, String FechaFin, String Motivo)
		{
		    string sentencia = "";
			sentencia = "INSERT INTO INCAPACIDAD (ID_OPERADOR, TIPO, FECHA_INICIO, FECHA_FIN, MOTIVO) values ("+ID_Operador+", '"+Tipo+"', '"+FechaInicio+"', '"+FechaFin+"', '"+Motivo+"')";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se registro correctamente");
			mensaje.Show();
			base.conexion.Close();
		}
		
		#region TRAER ID DESCUENTO
		public string ID(String Alias)
		{
			string id_operador="";
			base.getAbrirConexion("select ID from OPERADOR where Alias='"+Alias+"'");
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            {
				id_operador = (base.leer["ID"].ToString());
				if(id_operador=="")
				{
					id_operador="0";
				}
			}
			base.conexion.Close();
			
			return id_operador;
		}
		#endregion
		
		public void EliminarIncapacidad(int ID)
		{
			base.getAbrirConexion("delete from INCAPACIDAD where ID_INCAPACIDAD="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
  }
}
