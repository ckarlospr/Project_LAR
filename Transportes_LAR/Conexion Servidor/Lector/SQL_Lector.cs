using System;

namespace Transportes_LAR.Conexion_Servidor.Lector
{
	public class SQL_Lector:SQL_Conexion
	{
		public SQL_Lector()
		{
		}
		
		#region MODIFICAR HUELLA
		public void AlmacenarHuella(String id, String Dp)
		{
			string sentencia = "";
			sentencia = "UPDATE USUARIO SET HUELLA='"+Dp+"' where id_usuario="+id;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("La huella fue almacenada correctamente");
			mensaje.Show();
		}
		#endregion
		
		#region TRAER IDENTIDAD
		public string TraerIdentidad(String HUELLA)
		{
			string USUARIO = "";
			base.getAbrirConexion("select USUARIO from USUARIO WHERE HUELLA='"+HUELLA+"'");
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
				USUARIO = (base.leer["USUARIO"].ToString());
			base.conexion.Close();
			
			return USUARIO;
		}
		#endregion
		
		#region TRAER IDENTIDAD
		public bool GetTipo(String ID_U)
       	{
       		bool sigue;
       		
       		String consulta = "select * from ASISTENCIA where ID_U ='"+ID_U+"' and tipo='ENTRADA' and FECHA=(SELECT CONVERT (DATE, SYSDATETIME()))";
       		base.getAbrirConexion(consulta);
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	sigue = true;
            }
            else
            {
            	sigue = false;
            }
            conexion.Close();
            
            return sigue;
       	}
		#endregion
	}
}
