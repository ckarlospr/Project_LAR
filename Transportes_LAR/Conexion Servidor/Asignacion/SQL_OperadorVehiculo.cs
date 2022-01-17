using System;
using System.Data;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Asignacion
{
	public class SQL_OperadorVehiculo:Conexion_Servidor.SQL_Conexion
	{
		#region CONSTRUCTOR_DE_LA_CLASS
		public SQL_OperadorVehiculo():base() 
		{
		}
		#endregion
		
		#region GET_TABLA_OPERADOR
		public  DataTable getTabla(string consulta)
		{
			return base.getaAdaptadorTabla(consulta);
		}
		#endregion
		
		#region INSERTAR_ASIGNACION : UNIDAD
		public void getInsertarAsignacionUnidad(string id_Unidad , string id_Operador, string id_Usuario)
		{
			base.getAbrirConexion("execute ALMACENAR_ASIGNACIONUNIDAD "+id_Unidad+","+id_Operador);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("update ASIG_UNIDAD set ID_OPERADOR="+id_Operador+", estatus='A' where ID_UNIDAD in ("+id_Unidad+")");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO HISTORIALOPERADORVEHICULO VALUES ("+id_Unidad+", "+id_Operador+", (SELECT CONVERT (date, SYSDATETIME())), (SELECT CONVERT(VARCHAR,getdate(),108)),'SE ASIGNO UNIDAD', "+id_Usuario+")");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region PROCESOS_DE_DESASIGNACION_DE_UNIDAD_AL_OPERADOR
		//--ELIMINAR_ASIGNACION:UNIDAD
		public void getEliminarAsignacionUnidad(string id_Unidad , string id_Operador, string id_Usuario)
		{
			base.getAbrirConexion("delete from ASIGNACIONUNIDAD where ID_UNIDAD="+id_Unidad+" and ID_OPERADOR="+id_Operador);
			base.comando.ExecuteNonQuery();
			new Interfaz.FormMensaje("Desasignación establecida").Show();
			base.conexion.Close();
			
			base.getAbrirConexion("update ASIG_UNIDAD set ID_OPERADOR=null, estatus='T' where ID_UNIDAD in ("+id_Unidad+")");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO HISTORIALOPERADORVEHICULO VALUES ("+id_Unidad+", "+id_Operador+", (SELECT CONVERT (date, SYSDATETIME())), (SELECT CONVERT(VARCHAR,getdate(),108)),'SE DESASIGNO UNIDAD', "+id_Usuario+")");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void getEliminarAsignacionUnidad2(string id_Operador)
		{
			try{
			base.getAbrirConexion("delete from ASIGNACIONUNIDAD where ID_OPERADOR="+id_Operador);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			}
			catch{}
		}
		
		//--PROCESO_DESASIGNAR_VEHICULO_DEL_OPERADOR
		public void getGenerarHistoriaOperadorVehiculo(string id_Unidad , string id_Operador , string descripcion, string id_Usuario)
		{
			base.getAbrirConexion("execute almacenar_Historial_Operador_Vehiculo "+id_Unidad+","+id_Operador+",'"+descripcion+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			getEliminarAsignacionUnidad(id_Unidad , id_Operador, id_Usuario);
		}
		
		//--GENERAR_HISTORIAL_DE_VEHICULO
		public void getGenerarHistorialVehiculo(string id_Unidad,string id_Operador,string estatus , string descripcion, string id_Usuario)
		{
			base.getAbrirConexion("execute almacenar_Historial_Vehiculo "+id_Unidad+",'"+estatus+"', 'TALLER', '"+descripcion+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			if(estatus=="T")
			{
				getCambiarEstadoVehiculo(id_Unidad);
			}
			getEliminarAsignacionUnidad(id_Unidad,id_Operador, id_Usuario);
			getModificarEstado(estatus,id_Unidad,id_Operador);
		}
		
		//--CAMBIAR_ESTADO_DEL_VEHICULO
		private void getCambiarEstadoVehiculo(string id_Unidad)
		{
			base.getAbrirConexion("update VEHICULO set Estado=0 where ID="+id_Unidad);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
	
		#region OBTENER_DATOS (ASIGNACIONUNIDAD)
		public string getDatosAsignacion(string consulta,string result){
			string dato="";
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				dato=leer[result].ToString();
			}
			base.conexion.Close();
			return dato;
		}
		
		#endregion
		
		#region CARGAR_FECHA
		public void getFecha(string idOperador,string idUnidad,System.Windows.Forms.DateTimePicker dateFecha)
		{
			base.getAbrirConexion("select FECHA from HISTORIALOPERADORVEHICULO where ID_OPERADOR="+idOperador+" and ID_UNIDAD="+idUnidad);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				dateFecha.Value = new DateTime (Convert.ToInt32((base.leer["FECHA"].ToString()).Substring(6,4)),
            	                                Convert.ToInt32((base.leer["FECHA"].ToString()).Substring(3,2)),
            	                                Convert.ToInt32((base.leer["FECHA"].ToString()).Substring(0,2)));
			}
			base.conexion.Close();
		}
		#endregion
		
		#region MODIFICAR_ASIGNACION
		public void getModificarFecha(string fecha,string idOperador,string idUnidad){
			base.getAbrirConexion("UPDATE ASIGNACIONUNIDAD set FECHA ='"+fecha+"' WHERE ID_OPERADOR="+idOperador+" AND ID_UNIDAD="+idUnidad);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void getModificarEstado(string Estatus,string idOperador,string idUnidad){
			base.getAbrirConexion("UPDATE ASIGNACIONUNIDAD set Estatus ='"+Estatus+"' WHERE ID_OPERADOR="+idOperador+" AND ID_UNIDAD="+idUnidad);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region TRAER UNIDAD - OPERADOR
		public String getTraerUnidad(string Operador)
		{
			String Unidad="";
			base.getAbrirConexion("select V.NUMERO from VEHICULO V, OPERADOR O, ASIGNACIONUNIDAD A where A.ID_UNIDAD=V.ID AND O.ID=A.ID_OPERADOR AND O.Alias='"+Operador+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
				Unidad =  base.leer["NUMERO"].ToString();
			else
				Unidad = "";
			base.conexion.Close();
			
			return Unidad;
		}
		
		public String getTraerOperador(string Unidad)
		{
			String alias="";
			base.getAbrirConexion("select O.alias from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where A.ID_UNIDAD=V.ID AND O.ID=A.ID_OPERADOR AND V.NUMERO='"+Unidad+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
				alias = base.leer["alias"].ToString();
			else
				alias = "";
			base.conexion.Close();
			
			return alias;
		}
		#endregion
		
	}
}
