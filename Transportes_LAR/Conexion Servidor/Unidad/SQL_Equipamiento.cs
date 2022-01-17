using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Unidad
{
	public class SQL_Equipamiento:Conexion_Servidor.SQL_Conexion
	{
		
		private string idCategoria="";
		private string nomCategoria="";
		
		#region CONSTRUCTOR
		public SQL_Equipamiento():base(){
		}
		#endregion
		
		#region LISTA_DE_EQUIPAMIENTO
		public List<Interfaz.Unidad.Dato.Equipamiento> getEquipamientoUnidad(string idUnidad){
			List<Interfaz.Unidad.Dato.Equipamiento> listEquipamiento=new List<Interfaz.Unidad.Dato.Equipamiento>();
			base.getAbrirConexion("select ID_Unidad,ID_Categoria,(select nombre from CATEGORIAEQUIPO where ID=ID_Categoria)AS Categoria,Descripcion,Cantidad from EQUIPAMENTO where ID_Unidad="+idUnidad);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Unidad.Dato.Equipamiento equipamiento=new Transportes_LAR.Interfaz.Unidad.Dato.Equipamiento();
				equipamiento.idUnidad=		base.leer["ID_Unidad"].ToString();
				equipamiento.idCategoria=	base.leer["ID_Categoria"].ToString();
				equipamiento.categoria=		base.leer["Categoria"].ToString();
				equipamiento.descripcion=	base.leer["Descripcion"].ToString();
				equipamiento.cantidad=		base.leer["Cantidad"].ToString();
				listEquipamiento.Add(equipamiento);
			}
			base.conexion.Close();
			return listEquipamiento;
		}
		#endregion
		
		#region BUSQUEDA_DEL_NOMBRE_DE_LA_CATEGORIA
		public string getExistenciaCategoria(string nomCategoria){
			base.getAbrirConexion("select ID from CATEGORIAEQUIPO where Nombre='"+nomCategoria+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				idCategoria=base.leer["ID"].ToString();
			}
			base.conexion.Close();
			return idCategoria;
		}
		#endregion
		
		#region INSERTAR_CATEGORIA
		public string getInsertCategoria(string nomCategoria){
			MessageBox.Show("insert into CATEGORIAEQUIPO (Nombre) values ('"+nomCategoria+"')");
			base.getAbrirConexion("insert into CATEGORIAEQUIPO (Nombre) values ('"+nomCategoria+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			return getExistenciaCategoria(nomCategoria);
		}
		#endregion
		
		#region OBTENER_NOMBRE_CATEGORIA
		public string getNombreCategoria(string idCategoria){
			base.getAbrirConexion("select Nombre from CATEGORIAEQUIPO where ID="+idCategoria);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				this.nomCategoria=base.leer["Nombre"].ToString();
			}
			base.conexion.Close();
			return nomCategoria;
		}
		#endregion
		
		#region SENTENCIA ( MODIFICACION_DE_EQUIPAMIENTO )
		public void getSentenciaEquipamiento(string consulta){
			base.getAbrirConexion(consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
	}
}
