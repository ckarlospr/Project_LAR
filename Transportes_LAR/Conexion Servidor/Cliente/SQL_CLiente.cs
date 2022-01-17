using System;
using System.Data;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Cliente
{
	public class SQL_CLiente:Conexion_Servidor.SQL_Conexion
	{
		public SQL_CLiente():base(){
		}
		
		//--OBTENER_ADAPTADOR_DE_TABLA
		public DataTable getTabla(string consulta)
		{
			return base.getaAdaptadorTabla(consulta);
		}
		
		#region INSERTAR_CLIENTE
		public void getInsertarCliente(string idOperador,
		                                string empresa,
		                                string subNombre,
		                                string domicilio,
		                                string zonaReferencia,
		                                string municipio,
		                                string estado,
		                                string rumbo,
		                                string tipoCobro)
		{
			idOperador=(idOperador=="")?"null":idOperador;
			
			String consulta = "execute almacenar_modificar_cliente " +
			                        idOperador		+ ", '"+
									empresa			+"', '"+
									subNombre		+"', '"+
									domicilio		+"', '"+
									zonaReferencia	+"', '"+
									municipio		+"', '"+
									estado			+"', '"+
									rumbo			+"', '"+									
			                     	tipoCobro		+"'";
			
			base.getAbrirConexion(consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
		}
		#endregion
		
		#region OBTENER_ID_CLIENTE
		public string getIdCliente(string empresa,
		                                string subNombre,
		                                string domicilio,
		                                string zonaReferencia,
		                                string municipio,
		                                string estado,
		                                string rumbo
		                               ){
			string idCliente="";
			base.getAbrirConexion("select id from Cliente WHERE Empresa='"+empresa+"' and SubNombre='"+subNombre+"'  and Domicilio='"+domicilio+"' and ZonaReferencia='"+zonaReferencia+"' and Municipio='"+municipio+"' and Estado='"+estado+"' and Rumbo='"+rumbo+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				idCliente=base.leer["id"].ToString();
			}
			conexion.Close();
			return idCliente;
		}
		#endregion
		
		#region VALIDAR_EXISTENCIA_DE_CLIENTE POR: (EMPRESA - SUBNOMBRE)
		public bool getExistenciaCliente(string empresa,string subNombre){
			base.getAbrirConexion("select Empresa,SubNombre,Domicilio,ZonaReferencia,Municipio,Estado,Rumbo from Cliente where empresa='"+empresa+"' and subnombre='"+subNombre+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				MessageBox.Show("El cliente no puede ser almacenado ya que la empresa y sub nombre de la empresa se repiten con:\n" +
				                "Empresa: 			"+leer["Empresa"].ToString()+"\n"+
				                "Sub Nombre: 		"+leer["SubNombre"].ToString()+"\n"+
				                "Domicilio: 		"+leer["Domicilio"].ToString()+"\n"+
				                "Referencia: 		"+leer["ZonaReferencia"].ToString()+"\n"+
				                "Municipio: 		"+leer["Municipio"].ToString()+"\n"+
				                "Estado: 			"+leer["Estado"].ToString()+"\n"+
				                "Rumbo: 			"+leer["Rumbo"].ToString()
				                ,"Almacenar cliente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				base.conexion.Close();
				return true;
			}
			base.conexion.Close();
			return false;
		}
		#endregion
		
		#region OBTENER_DATOS_DE_CLIENTE
		public void getDatoCliente(string idCliente,
		                           TextBox empresa,
		                           TextBox subNombre,
		                           TextBox domicilio,
		                           TextBox zonaReferencia,
		                           TextBox municipio,
		                           TextBox estado,
		                           TextBox rumbo,
		                           ComboBox tipoCobro)
		{
			
			base.getAbrirConexion("select ID,Empresa,SubNombre,Domicilio,ZonaReferencia,Municipio,Estado,Rumbo,tipo_cobro from Cliente where ID="+idCliente);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				empresa.Text=			leer["Empresa"].ToString();
				subNombre.Text=			leer["SubNombre"].ToString();
				domicilio.Text=			leer["Domicilio"].ToString();
				zonaReferencia.Text=	leer["ZonaReferencia"].ToString();
				municipio.Text=			leer["Municipio"].ToString();
				estado.Text=			leer["Estado"].ToString();
				rumbo.Text=				leer["Rumbo"].ToString();
				tipoCobro.Text=			leer["tipo_cobro"].ToString();
			}
			base.conexion.Close();
		}
		#endregion
		
		#region MODIFICAR_CLIENTE
		public void getModificarCliente(string id,
		                                string empresa,
		                                string subNombre,
		                                string domicilio,
		                                string zonaReferencia,
		                                string municipio,
		                                string estado,
		                                string rumbo,
		                                string tipoCobro
		                               ){
			base.getAbrirConexion("almacenar_modificar_cliente "+id+",'"+
			                      empresa			+"','"+
			                      subNombre			+"','"+
			                      domicilio			+"','"+
			                      zonaReferencia	+"','"+
			                      municipio			+"','"+
			                      estado			+"','"+
			                      rumbo				+"', '"+									
			                      tipoCobro			+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
	
		
		#region ELIMINAR_CLIENTE_DE_LA_BASE_DE_DATOS
		/// <summary>
		/// FALTA PROCESO DE ELIMINAR AL LAS RUTAS QUE TIENE AGREGADAS
		/// </summary>
		public void getEliminarCliente(string idCliente){
			base.getAbrirConexion("exec [almacenar_clientesEliminados] @ID_cliente="+idCliente);
			base.comando.ExecuteNonQuery();
			base.comando.Clone();
		}
		#endregion
	}
}
