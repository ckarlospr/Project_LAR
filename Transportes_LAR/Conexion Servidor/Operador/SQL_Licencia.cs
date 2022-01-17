using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Operador
{
	public class SQL_Licencia : Conexion_Servidor.SQL_Conexion
	{
		String A;
		public SQL_Licencia():base(){
		}
		
		public DataTable getTabla(string consulta)
		{
			return base.getaAdaptadorTabla(consulta);
		}
		
		#region INSERTAR-ACTUALIZAR_LICENCIA
		public void getInsertarLicencia(string sentencia)
		{
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void getInsertarLicenciaOperador(string id_op, string descripcion, string vigencia, string tipo, string numero)
		{
			base.getAbrirConexion("insert into licencia (Descripcion,Numero,Vigencia,Tipo,ID_Chofer) values ('"+descripcion+"','"+numero+"','"+vigencia+"','"+tipo+"','"+id_op+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region OBTENER_LICENCIAS_DEL_OPERADOR
		public List<Interfaz.Operador.Dato.Licencia> getListLicencia(string idOperador){
			List<Interfaz.Operador.Dato.Licencia> listlicencia=new List<Transportes_LAR.Interfaz.Operador.Dato.Licencia>();
			base.getAbrirConexion("select ID,Descripcion,Numero,Vigencia,Tipo from LICENCIA where ID_Chofer="+idOperador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Operador.Dato.Licencia licencia=new Transportes_LAR.Interfaz.Operador.Dato.Licencia();
				licencia.id			=base.leer["ID"].ToString();
				licencia.numero		=base.leer["Numero"].ToString();
				licencia.clase		=base.leer["Descripcion"].ToString();
				A=base.leer["VIGENCIA"].ToString();
				licencia.vigencia	=A.Substring(0,10);
				licencia.tipo		=base.leer["Tipo"].ToString();
				listlicencia.Add(licencia);
			}
			base.conexion.Close();
			return (listlicencia.Count>0)?listlicencia:null;
		}
		#endregion
		
		#region ELIMINAR_LICENCIA
		public void getEliminarLicencia(string idLicencia){
			base.getAbrirConexion("delete from LICENCIA where id="+idLicencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region CARGAR_DATOS_DE_LA_LICENCIA
		public void getDatosLicencia(string id,TextBox clase,TextBox numero,TextBox tipo,DateTimePicker dateFecha){
			int [] fecha=null;
			getAbrirConexion("select Descripcion,Numero,Tipo,Vigencia from LICENCIA where ID="+id);
			leer=comando.ExecuteReader();
			if(leer.Read()){
				clase.Text=		leer["Descripcion"].ToString();
				numero.Text=	leer["Numero"].ToString();
				tipo.Text=		leer["Tipo"].ToString();
				fecha=getFecha(leer["Vigencia"].ToString());
				try{
					dateFecha.Value=new DateTime(Convert.ToInt16(fecha[0]),Convert.ToInt16(fecha[1]),Convert.ToInt16(fecha[2]));
				}catch{
					dateFecha.Value=new DateTime(Convert.ToInt16(fecha[2]),Convert.ToInt16(fecha[1]),Convert.ToInt16(fecha[0]));
				}
			}
			conexion.Close();
		}
		#endregion
		
		#region SEPARAR_FECHA
		private int [] getFecha(String dato){
			int[] fecha=new int[3];
			try{
				fecha[0]=Convert.ToInt32(dato.Substring(0,2));
				fecha[1]=Convert.ToInt32(dato.Substring(3,2));
				fecha[2]=Convert.ToInt32(dato.Substring(6,4));
			}catch{
				fecha[0]=Convert.ToInt32(dato.Substring(0,4));
				fecha[1]=Convert.ToInt32(dato.Substring(5,2));
				fecha[2]=Convert.ToInt32(dato.Substring(8,2));
			}
			
			return fecha;
		}
		#endregion
		
		#region CAMBIAR_FECHA_LICENCIA
		public void getCambiarFechaLicencia(string idLicencia,string fecha){
			A=fecha.Substring(0,10);
			getAbrirConexion("update LICENCIA set Vigencia='"+A+"' where ID="+idLicencia);
			comando.ExecuteNonQuery();
			conexion.Close();
		}
		#endregion
	}
}
