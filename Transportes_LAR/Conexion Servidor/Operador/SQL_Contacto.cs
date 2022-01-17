using System;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Operador
{
	public class SQL_Contacto:Conexion_Servidor.SQL_Conexion
	{
		public SQL_Contacto():base()
		{
		}
		
		#region INSERTAR-ACTUALIZAR_LICENCIA
		public void getInsertarContacto(string sentencia){
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region OBTENER_LICENCIAS_DEL_OPERADOR
		public List<Interfaz.Operador.Dato.Contacto> getListContacto(string idOperador){
			List<Interfaz.Operador.Dato.Contacto> listContacto=new List<Transportes_LAR.Interfaz.Operador.Dato.Contacto>();
			base.getAbrirConexion("select ID,Nombre,Apellido_Pat,Apellido_Mat,Calle,Num_Interior,Num_Exterior,Colonia,Municipio,Estado,CP,Telefono from CONTACTOS where ID_OPERADOR="+idOperador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Operador.Dato.Contacto contacto=new Transportes_LAR.Interfaz.Operador.Dato.Contacto();
				contacto.id				=base.leer["ID"].ToString();
				contacto.nombre			=base.leer["Nombre"].ToString();
				contacto.apellidoPat	=base.leer["Apellido_Pat"].ToString();
				contacto.apellidoMat	=base.leer["Apellido_Mat"].ToString();
				contacto.telefono		=base.leer["Telefono"].ToString();
				contacto.calle			=base.leer["Calle"].ToString();
				contacto.numInterior	=base.leer["Num_Interior"].ToString();
				contacto.numExterior	=base.leer["Num_Exterior"].ToString();
				contacto.colonia		=base.leer["Colonia"].ToString();
				contacto.municipio		=base.leer["Municipio"].ToString();
				contacto.estado			=base.leer["Estado"].ToString();
				contacto.cp				=base.leer["CP"].ToString();
				listContacto.Add(contacto);
			}
			base.conexion.Close();
			return (listContacto.Count>0)?listContacto:null;
		}
		#endregion
		
		#region ELIMINAR_CONTACTO
		public void getEliminarContacto(string idContacto){
			base.getAbrirConexion("delete from CONTACTOS where id="+idContacto);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
	}
}
