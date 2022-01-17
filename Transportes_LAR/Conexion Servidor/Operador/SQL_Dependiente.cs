using System;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Operador
{
	public class SQL_Dependiente:Conexion_Servidor.SQL_Conexion
	{
		String A;
		public SQL_Dependiente():base()
		{
		}
		
		#region INSERTAR-ACTUALIZAR_LICENCIA
		public void getInsertarDependiente(string sentencia){
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region OBTENER_LICENCIAS_DEL_OPERADOR
		public List<Interfaz.Operador.Dato.Dependiente> getListDependiente(string idOperador){
			List<Interfaz.Operador.Dato.Dependiente> listDependiente=new List<Transportes_LAR.Interfaz.Operador.Dato.Dependiente>();
			base.getAbrirConexion("select ID,Sexo,Fecha_Nacimiento,Parentesco from DEPENDIENTE where ID_Chofer="+idOperador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Operador.Dato.Dependiente dependiente=new Transportes_LAR.Interfaz.Operador.Dato.Dependiente();
				dependiente.id					=base.leer["ID"].ToString();
				dependiente.sexo				=base.leer["Sexo"].ToString();
				A=base.leer["Fecha_Nacimiento"].ToString();
				dependiente.fechaNacimiento		=A.Substring(0,10);
				dependiente.parentesco			=base.leer["Parentesco"].ToString();
				listDependiente.Add(dependiente);
			}
			base.conexion.Close();
			return (listDependiente.Count>0)?listDependiente:null;
		}
		#endregion
		
		#region ELIMINAR_DEPENDIENTE
		public void getEliminarDependiente(string idDependiente){
			base.getAbrirConexion("delete from DEPENDIENTE where id="+idDependiente);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
	}
}
