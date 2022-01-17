using System;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Operador
{
	public class SQL_Telefono:Conexion_Servidor.SQL_Conexion
	{
		public SQL_Telefono():base()
		{
		}
		
		#region INSERTAR-ACTUALIZAR_LICENCIA
		public void getInsertarTelefono(string sentencia){
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region OBTENER_TELEFONO_DEL_OPERADOR
		public List<Interfaz.Operador.Dato.Telefono> getListTelefono(string idOperador){
			List<Interfaz.Operador.Dato.Telefono> listTelefono=new List<Transportes_LAR.Interfaz.Operador.Dato.Telefono>();
			base.getAbrirConexion("select ID,Tipo,Numero,Descripcion from TELEFONOCHOFER where ID_Chofer="+idOperador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Operador.Dato.Telefono telefono=new Transportes_LAR.Interfaz.Operador.Dato.Telefono();
				telefono.id				=base.leer["ID"].ToString();
				telefono.tipo			=base.leer["Tipo"].ToString();
				telefono.numero			=base.leer["Numero"].ToString();
				telefono.descripcion	=base.leer["Descripcion"].ToString();
				listTelefono.Add(telefono);
			}
			base.conexion.Close();
			return (listTelefono.Count>0)?listTelefono:null;
		}
		#endregion
		
		#region ELIMINAR_TELEFONO
		public void getEliminarTelefono(string idTelefono){
			base.getAbrirConexion("delete from TELEFONOCHOFER where id="+idTelefono);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void getEliminarTelefonoBaja(string idOperador){
			base.getAbrirConexion("delete from TELEFONOCHOFER where ID_Chofer="+idOperador);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
	}
}
