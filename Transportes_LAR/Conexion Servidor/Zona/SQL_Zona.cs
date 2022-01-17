using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Zona
{
	public class SQL_Zona:Conexion_Servidor.SQL_Conexion
	{
		private String[,] zonas=null;
		
		public SQL_Zona():base()
		{
		
		}
		
		#region GET_NOMBRE_ZONA
		public bool getNombreZona(ComboBox zona){
			bool estado=false;
			base.getAbrirConexion("select NOMBRE from ZONA  group by NOMBRE");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				zona.Items.Add(leer["NOMBRE"].ToString());
				estado=true;
				zona.SelectedIndex=0;
			}
			base.conexion.Close();
			return estado;
		}
		
		public string getNombreZona(string zona){
			base.getAbrirConexion("select Nombre from ZONA where ID_ZONA="+zona);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				zona=leer["Nombre"].ToString();
			}
			return zona;
		}
		#endregion
		
		#region GET_ID_ZONA
		public string getIdZona(string nombre){
			string idZona="";
			base.getAbrirConexion("select id_zona from zona where nombre='"+nombre+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				idZona=base.leer["id_zona"].ToString();
			}
			base.conexion.Close();
			return idZona;
		}
		#endregion	
		
		#region CONSULTANR_LA_EXISTENCIA_DENTRO_DE_LA_BASE
		public bool getExistencia(String nombre){
			base.getAbrirConexion("select nombre from zona where nombre='"+nombre+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
				return true;
			base.conexion.Close();
			return false;
		}
		#endregion
		
		#region REGISTRAR_ZONA
		public object getInsertarZona(string id_zona,string nombre,string colindancia,string descripcion){
			base.getAbrirConexion("execute almacenar_zona '"+id_zona+"','"+nombre+"','"+colindancia+"','"+descripcion+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			return null;
		}
		#endregion
		
		#region CARGAR_CONSULTA_DE_ZONAS
		private void getZonaRegistrada(){
			int contador=0;
			base.getAbrirConexion("select ID_ZONA,NOMBRE,COLINDANCIA,DESCRIPCION from ZONA");
			base.leer=base.comando.ExecuteReader();
			while(leer.Read()){
				zonas[contador,0]=base.leer["ID_ZONA"].ToString();
				zonas[contador,1]=base.leer["NOMBRE"].ToString();
				zonas[contador,2]=base.leer["COLINDANCIA"].ToString();
				zonas[contador,3]=base.leer["DESCRIPCION"].ToString();
				contador++;
			}
			base.conexion.Close();
		}
		#endregion
		
		#region CONTAR_CUANTOS_REGISTROS_EXISTEN_EN_LA_BASE_DE_DATOS
		private void getCantidadZona(){
			base.getAbrirConexion("SELECT COUNT(*)AS CANTIDAD FROM ZONA");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				zonas=new String[Convert.ToUInt32(base.leer["CANTIDAD"].ToString()),4];
			}
			base.conexion.Close();
		}
		
		public string[,] getModelo(){
			getCantidadZona();
			getZonaRegistrada();
			return zonas;
		}
		#endregion
		
		#region ELIMINA_Y_ACTUALIZA_LAS_ZONAS
		public void getModificarZona(string id_zona , string nombre , string colindancia , string descripcion){
			base.getAbrirConexion("execute modificar_zona '"+id_zona+"','"+nombre+"','"+colindancia+"','"+descripcion+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public int getNumeroZona(){
			base.getAbrirConexion("select COUNT(*)as cantidad from ZONA");
			base.leer=comando.ExecuteReader();
			if(leer.Read()){
				return Convert.ToInt32(leer["cantidad"].ToString());
			}
			return 0;
		}
		#endregion
		
		#region ELIMINAR_LA_ZONA_DEL_OPERADOR_Y_DE_LA_RUTA
		public void getEliminarClasificacion(string id){
			base.getAbrirConexion("update OPERADOR set zona=NULL WHERE ZONA='"+id+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			base.getAbrirConexion("update RUTA set zona=NULL WHERE ZONA='"+id+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
			
		#region GENERANDO_OBJETO_DE_ZONAS
		public List<Interfaz.Zona.Dato.Zona> getGenerarZona(){
			List<Interfaz.Zona.Dato.Zona> lista=new List<Interfaz.Zona.Dato.Zona>();
			base.getAbrirConexion("select id_ZONA, NOMBRE as dataZona from ZONA");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Zona.Dato.Zona objectZona=new Interfaz.Zona.Dato.Zona();
				objectZona.id_Zona=Convert.ToInt32(leer["id_Zona"].ToString());
				objectZona.dataZona=leer["dataZona"].ToString();
				lista.Add(objectZona);
			}
			return lista;
		}
		#endregion
		
		#region CARGAR_DATOS_DEL_OPERADOR
		public List<Interfaz.Zona.Dato.Operador> getListaOperador(){
			List<Interfaz.Zona.Dato.Operador> lista=new List<Interfaz.Zona.Dato.Operador>();
			base.getAbrirConexion("select ID as id_Operador , Alias as dataAlias , Nombre as dataNombre   from OPERADOR where zona is NULL");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Zona.Dato.Operador objectZona=new Interfaz.Zona.Dato.Operador();
				objectZona.id_Operador = Convert.ToInt32(leer["id_Operador"]);
				objectZona.dataAlias = leer["dataAlias"].ToString();
				objectZona.dataNombre = leer["dataNombre"].ToString();
				lista.Add(objectZona);
			}
			conexion.Close();
			return lista;
		}
		#endregion
		
		#region CARGAR_DATOS_DE_RUTA
		public List<Interfaz.Zona.Dato.Ruta> getListaRuta(){
			List<Interfaz.Zona.Dato.Ruta> lista=new List<Interfaz.Zona.Dato.Ruta>();
			base.getAbrirConexion("select ID as id_Ruta , Nombre as dataNombre,(select CLIENTE.SubNombre from CLIENTE where CLIENTE.ID=RUTA.IdSubEmpresa)AS dataEmpresa from RUTA where ZONA is NULL");
			leer=comando.ExecuteReader();
			while(leer.Read()){
				Interfaz.Zona.Dato.Ruta objectZona	=new Interfaz.Zona.Dato.Ruta();
				objectZona.idRuta			=Convert.ToInt32(base.leer["id_Ruta"]);
				objectZona.dataNombre		=base.leer["dataNombre"].ToString();
				objectZona.dataEmpresa		=base.leer["dataEmpresa"].ToString();
				lista.Add(objectZona);
			}
			base.conexion.Close();
			return lista;
		}
		#endregion
		
		#region ACTUALIZAR_ZONA_OPERADOR
		public object getActualizarOperador(int contador,string[,] operador){
			if(operador.Length==0)
				return null;
			base.getAbrirConexion("update operador set zona="+operador[contador,1]+" where ID="+operador[contador,0]);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			return ((1+contador)<(operador.Length/2))? getActualizarOperador(++contador,operador):null;
		}
		#endregion
		
		#region ACTUALIZAR_ZONA_RUTA
		public object getActualizarRuta(int contador,string[,] ruta){
			if(ruta.Length==0)
				return null;
			base.getAbrirConexion("update ruta set zona="+ruta[contador,1]+" where ID="+ruta[contador,0]);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			return ((1+contador)<(ruta.Length/2))? getActualizarRuta(++contador,ruta):null;
		}
		#endregion
		
		#region VERIFICA_SI_UN_OPERADOR_O_RUTA_TIENE_NULL_LA_ZONA
		public bool getVerificarZona(){
			base.getAbrirConexion("select id from operador where zona is null");
			base.leer=comando.ExecuteReader();
			if(base.leer.Read()){
				base.conexion.Close();
				return true;
			}
			base.conexion.Close();
			base.getAbrirConexion("select id from ruta where zona is null");
			base.leer=comando.ExecuteReader();
			if(base.leer.Read()){
				base.conexion.Close();
				return true;
			}
			base.conexion.Close();
			return false;
		}
		#endregion
	}
}
