using System;
using System.Collections.Generic;
using Transportes_LAR.Interfaz.Cliente.Dato;

namespace Transportes_LAR.Conexion_Servidor.Cliente
{
	public class SQL_Contacto:Conexion_Servidor.SQL_Conexion
	{
		public SQL_Contacto():base(){
		}
		
		#region INSERTAR-ACTUALIZAR_LICENCIA
		public void getInsertarContacto(string sentencia){
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region OBTENER_CONTACTOS_DEL_CLIENTE
		public List<Interfaz.Cliente.Dato.Contacto> getListContacto(string idCliente){
			List<Interfaz.Cliente.Dato.Contacto> listContacto=new List<Transportes_LAR.Interfaz.Cliente.Dato.Contacto>();
			base.getAbrirConexion("select ID,Nombre,Telefono,Extension,CelularNextel,Correo,IdCliente from ContactoServicio where IdCliente="+idCliente);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Cliente.Dato.Contacto contacto=new Transportes_LAR.Interfaz.Cliente.Dato.Contacto();
				contacto.id				=base.leer["ID"].ToString();
				contacto.nombre 		=base.leer["Nombre"].ToString();
				contacto.telefono		=base.leer["Telefono"].ToString();
				contacto.extension		=base.leer["Extension"].ToString();
				contacto.celularNextel	=base.leer["CelularNextel"].ToString();
				contacto.correo			=base.leer["Correo"].ToString();
				contacto.idCliente		=base.leer["IdCliente"].ToString();
				listContacto.Add(contacto);
			}
			base.conexion.Close();
			return (listContacto.Count>0)?listContacto:null;
		}
		#endregion
		
		#region ELIMINAR_CONTACTO_DE_SERVICIO
		public void getEliminarContacto(string id){
			base.getAbrirConexion("delete from ContactoServicio where ID="+id);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
	}
}
