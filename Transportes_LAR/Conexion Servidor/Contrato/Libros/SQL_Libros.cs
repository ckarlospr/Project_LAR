using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Libros
{
	public class SQL_Libros:SQL_Conexion
	{
		#region CONSTRUCTOR
		public SQL_Libros():base()
		{
			
		}
		#endregion
		
		#region ADAPTADOR
		public DataTable getTabla(string consulta)
		{
			return base.getaAdaptadorTabla(consulta);
		}
		#endregion
		
		#region INSERTAR VIAJE
		public void getInsertarRutaEspecial(string fecha, string h_salida, string h_planton, string h_regreso, 
		                        string respnsable, string cliente, string unidades, string tipo,
		                        string domicilio, string cruces, string colonia, string destino, string casetas, 
		                        string precio, string km, string telefono, string datos, 
		                        string observaciones, string pago_operador, string dia, string foranea, 
		                        int idus, String sentido, string correo, string fechaR, string anticipos, 
		                        string estado, string tipoVehiculo, int cant_pasajeros, string refVisual, bool mixto, DataGridView data)
		{
			
			string sentencia = "";
			sentencia = "execute almacenar_viaje_especial '" + colonia + "','" + cruces  + "','" + cliente  + "','" + telefono + "'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			double pago_sencillo=0;
			if(Convert.ToDouble(pago_operador)>0)
				pago_sencillo=(Convert.ToDouble(pago_operador)/2);
			
				
			for(int x=0; x<Convert.ToInt16(unidades); x++)
			{
				sentencia = "execute almacenar_rutas_especial3 '"+ h_salida + "','" + h_regreso +
			                         "','"+ tipo +
			                         "','" + domicilio + "','"+ destino +
			                         "','"+ km +
			                         "','"+ pago_operador+"', '"+pago_sencillo+"','"+dia+"','"+foranea+"','"+sentido+"', (select MAX(ID) From cliente)";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			
			sentencia = "";
			sentencia = "execute almacenar_datos_especial '" +fecha + "','"+h_planton +"','"+respnsable+"','"+unidades+"','"+domicilio+"','"+destino+"','"+casetas+"','"+precio+"','"+datos+"','"+observaciones+"','"+idus+"','"+correo+"','"+fechaR+"','"+Convert.ToDouble(anticipos)+"','"+estado+"', '"+((mixto==true)?"MIXTO":tipoVehiculo)+"', '"+cant_pasajeros+"', '"+ refVisual+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			if(mixto==true)
			{
				for(int x=0; x<data.Rows.Count; x++)
				{
					sentencia = "insert into VIAJES_MIXTOS VALUES ((select MAX(ID_RE) from RUTA_ESPECIAL),'"+data[1,x].Value.ToString()+"','"+data[2,x].Value.ToString()+"','"+data[3,x].Value.ToString()+"','"+data[4,x].Value.ToString()+"','"+data[5,x].Value.ToString()+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
			}
		}
		#endregion
		
		#region ACTUALIZAR VIAJE
		public void getActualizarRutaEspecial(string fecha, string h_salida, string h_planton, string h_regreso, 
		                        string respnsable, string cliente, string unidades, string tipo,
		                        string domicilio,
		                        string cruces, string colonia, string destino, string casetas, 
		                        string precio, string km, string telefono, string datos, 
		                        string observaciones, string pago_operador, string dia, string foranea, int idus, String sentido, int IDRE, int IDC, string correo, string fechaR, string anticipos, string estado,
		                        string refVisual, string cantUsuarios, bool mixto, DataGridView data)
		{
			string sentencia = "";
			
			/*sentencia = "UPDATE RUTA SET HoraInicio='" +h_salida + "', Kilometros='"+km +"',  SencilloCamioneta='"+pago_operador+"', CompletoCamioneta='"+pago_operador+"', SencilloCamion='"+pago_operador+"', CompletoCamion='"+pago_operador+"', SencilloForaneo='"+pago_operador+"', CompletoForaneo='"+pago_operador+"' WHERE Sentido='Entrada' and IdSubEmpresa='"+IDC+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();*/
			
			try
			{
				sentencia = "delete from ruta where IdSubEmpresa='"+IDC+"'";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				
			}
			catch(Exception)
			{
				base.conexion.Close();
				
				sentencia = "update RUTA set TIPO='Cancelada', Precio='0' where ID in (select ID from ruta where IdSubEmpresa='"+IDC+"')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
			}
			finally
			{
				base.conexion.Close();
			}
			
			double pago_sencillo=0;
			if(Convert.ToDouble(pago_operador)>0)
				pago_sencillo=(Convert.ToDouble(pago_operador)/2);
				
			
			for(int x=0; x<Convert.ToInt16(unidades); x++)
			{
				sentencia = "execute almacenar_rutas_especial3 '"+ h_salida + "','" + h_regreso +
			                         "','"+ tipo +
			                         "','" + domicilio + "','"+ destino +
			                         "','"+ km +
			                         "','"+ pago_operador+"', '"+pago_sencillo+"','"+dia+"','"+foranea+"','"+sentido+"',"+IDC;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			
			/*sentencia = "UPDATE RUTA SET HoraInicio='" +h_regreso + "', Kilometros='"+km +"',  SencilloCamioneta='"+pago_operador+"', CompletoCamioneta='"+pago_operador+"', SencilloCamion='"+pago_operador+"', CompletoCamion='"+pago_operador+"', SencilloForaneo='"+pago_operador+"', CompletoForaneo='"+pago_operador+"' WHERE Sentido='Salida' and IdSubEmpresa='"+IDC+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();*/

			sentencia = "UPDATE ContactoServicio SET Nombre='" +cliente + "', Telefono='"+telefono+"' WHERE IdCliente='"+IDC+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
			
			sentencia = "";
			sentencia = "UPDATE RUTA_ESPECIAL SET ref_Visual='"+refVisual+"', cantidad_usuarios='"+cantUsuarios+"', tipoVehiculo='"+tipo+"', FECHA_SALIDA='" +fecha + "', HORA='"+h_planton +"', RESPONSABLE='"+respnsable+"', CANT_UNIDADES='"+unidades+"', DOMICILIO='"+domicilio+"', DESTINO='"+destino+"', CASETAS='"+casetas+"', PRECIO='"+precio+"',  FACTURA='"+datos+"', OBSERVACIONES='"+observaciones+"', correo='"+correo+"', fecha_regreso='"+fechaR+"', anticipo='"+Convert.ToDouble(anticipos)+"', estado='"+estado+"' WHERE ID_RE='"+IDRE+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			if(mixto==true)
			{
				sentencia = "delete from viajes_mixtos where id_re='"+IDRE+"'";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
					
				for(int x=0; x<data.Rows.Count; x++)
				{
					sentencia = "insert into VIAJES_MIXTOS VALUES ('"+IDRE+"','"+data[1,x].Value.ToString()+"','"+data[2,x].Value.ToString()+"','"+data[3,x].Value.ToString()+"','"+data[4,x].Value.ToString()+"','"+data[5,x].Value.ToString()+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
			}
			else
			{
				sentencia = "delete from viajes_mixtos where id_re='"+IDRE+"'";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
		}
		#endregion
		
		#region GUARDA CONFIRMACION
		public void confirmaViaje(string clienteConf, int ID_usuario, Int64 id_re)
		{
			string sentencia =  "update RUTA_ESPECIAL set CONF_CLIENTE='"+clienteConf+"', CONF_FECHA=(SELECT CONVERT (date, SYSDATETIME())), CONF_USUARIO='"+ID_usuario+"' where ID_RE="+id_re;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
	}
}
