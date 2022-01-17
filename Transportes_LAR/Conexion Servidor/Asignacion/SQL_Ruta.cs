using System;
using System.Collections.Generic;
using System.Data;

namespace Transportes_LAR.Conexion_Servidor.Asignacion
{
	public class SQL_Ruta:Conexion_Servidor.SQL_Conexion
	{
		#region CONSTRUCTOR
		public SQL_Ruta():base(){
		}
		#endregion
		
		#region ADAPTADOR
		public DataTable getTabla(string consulta){
			return base.getaAdaptadorTabla(consulta);
		}
		#endregion
		
		#region CARGAR_EMPRESAS
		public List<Interfaz.Asignacion.Dato.Empresa> getEmpresa(){
			List<Interfaz.Asignacion.Dato.Empresa> listEmpresa=new List<Transportes_LAR.Interfaz.Asignacion.Dato.Empresa>();
			base.getAbrirConexion("select ID,SubNombre from Cliente");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Asignacion.Dato.Empresa empresa=new Interfaz.Asignacion.Dato.Empresa();
				empresa.idEmpresa=base.leer["ID"].ToString();
				empresa.subNombre=base.leer["SubNombre"].ToString();
				listEmpresa.Add(empresa);
			}
			base.conexion.Close();
			return listEmpresa;
		}
		#endregion
		
	}
}
