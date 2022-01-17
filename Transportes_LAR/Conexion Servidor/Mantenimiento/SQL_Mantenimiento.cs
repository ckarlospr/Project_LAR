using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Threading;


namespace Transportes_LAR.Conexion_Servidor.Mantenimiento
{
	public class SQL_Mantenimiento:SQL_Conexion
	{
		public SQL_Mantenimiento()
		{
		}			
		// * Modificar metodos actuales >> Reducir codigo duplicado
		// * Añadir descriptores: (/// <summary>) a los metodos
		
		#region ALMACEN
			
			#region INSERTAR
			
				#region AGRUPACION
				public void InsertarAgrupacion(String Nombre, String Descripcion)
				{
					string sentencia = "";
					sentencia = "INSERT INTO GRUPO_PRODUCTO VALUES('"+Nombre+"', '"+Descripcion+"', 'Activo')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron insertados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region INTERVENCION
				public void InsertarIntervencion(String Nombre, String Descripcion)
				{
					string sentencia = "";
					sentencia = "INSERT INTO TIPO_INTERVENCION (Nombre , Descripcion) VALUES ('"+Nombre+"', '"+Descripcion+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron insertados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region PROVEEDOR
				public void InsertarProveedores(String Clave, String Nombre, String NombreCom, String Atencion, String PlazoC, String Clase, String Telefono, String Contacto, String Direccion, String RFC, String Descripcion, String Email)
				{
					string sentencia = "";
					sentencia = "INSERT INTO PROVEEDOR_ALMACEN (Clave, Nombre, NombreCom, Atencion, PlazoCredito, Clase, Telefono, Contacto, Direccion, RFC, Descripcion, Correo, Estatus) values ('"+Clave+"', '"+Nombre+"', '"+NombreCom+"', '"+Atencion+"', '"+PlazoC+"', '"+Clase+"', '"+Telefono+"', '"+Contacto+"', '"+Direccion+"', '"+RFC+"', '"+Descripcion+"', '"+Email+"', 'Activo')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ENTRADA
				public void InsertarEntrada(String Fecha, Int32 OrdenCompra)
				{
					String sentencia = "INSERT INTO ENTRADA_PRODUCTO_ALMACEN VALUES ('"+Fecha+"', '"+OrdenCompra+"');";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
				
				public void InsertarDetalleEntrada(Int32 Entrada, String Cantidad, String Origen)
				{
					String sentencia = "INSERT INTO DETALLE_ENTRADA_PRAL VALUES ('"+Entrada+"', '"+Cantidad+"', '"+Origen+"');";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					/// <summary>
					/// 
					/// a
					/// sdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// asdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
					/// </summary>
					/// <param name="Entrada"></param>
					/// <param name="FechaRegistro"></param>
					/// <param name="Usuario"></param>
				}
				
				public void InsertarHistorialEntrada(Int32 Entrada, String FechaRegistro, String Usuario)
				{
//					String sentencia = "INSERT INTO HISTORIAL_ENTRADA_PRAL VALUES ('"+Entrada+"', '"+FechaRegistro+"', '"+Usuario+"')";
//					base.getAbrirConexion(sentencia);
//					base.comando.ExecuteNonQuery();
//					base.conexion.Close();
				}
				#endregion
				
				#region SALIDA
				public void InsertarSalida(String ID_PRODUCTO, String CANTIDAD, String ID_ORDEN_TRABAJO, String id_usuario)
				{
					string sentencia = "";
					Decimal inventario = 00;	
					Decimal Canti = Convert.ToDecimal(CANTIDAD);
					base.getAbrirConexion("select EXISTENCIA from PRODUCTO_ALMACEN where id="+ID_PRODUCTO+"");
					base.leer=base.comando.ExecuteReader();
						if(base.leer.Read())
						{
							inventario =  Convert.ToInt16(base.leer["EXISTENCIA"]);
						}
					base.conexion.Close();
					
					if(inventario>0 && inventario>=Canti)
					{
						sentencia = "EXECUTE AltaSalidaProducto "+ ID_PRODUCTO +", "+ CANTIDAD +",  "+ID_ORDEN_TRABAJO +", "+id_usuario ;
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
						mensaje.Show();		
					}
					else
					{
						MessageBox.Show("No hay suficientes productos en el almacen", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}	
					
					#region Codigo anterior
					
					/*
					String id_salida="";
					string sentencia = "";
					int inventario = 0;
					int entrada = 0;
					int salida = 0;
					int total = 0;
					
					base.getAbrirConexion("select CANTIDAD from producto where id="+ID_PRODUCTO+"");
					base.leer=base.comando.ExecuteReader();
					if(base.leer.Read())
					{
						inventario =  Convert.ToInt16(base.leer["CANTIDAD"]);
					}
					base.conexion.Close();
					
					if(inventario>0&&inventario>=Convert.ToInt16(CANTIDAD))
					{
						sentencia = "insert into Salida (ID_PRODUCTO, CANTIDAD, ID_VEHICULO, ID_ORDENTRABAJO) values ('"+ID_PRODUCTO+"', '"+CANTIDAD+"', '"+ID_VEHICULO+"', '"+ID_ORDEN_TRABAJO+"')";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						base.getAbrirConexion("select max(ID) as total "+
		                               			"from Salida");
						base.leer=base.comando.ExecuteReader();
						while(base.leer.Read())
							id_salida = base.leer["total"].ToString();
						base.conexion.Close();
						
						sentencia = "insert into Historial_Salida (Id_Salida, Fecha_reg, Hora_reg, Cantidad, Id_u) values ('"+id_salida+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:MM:ss")+"', '"+CANTIDAD+"', '"+id_usuario+"')";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						base.getAbrirConexion("select sum(cantidad) as total from entrada where id_producto="+ID_PRODUCTO+"");
						base.leer=base.comando.ExecuteReader();
						if(base.leer.Read())
							entrada = Convert.ToInt16(base.leer["total"]);
						base.conexion.Close();
						
						base.getAbrirConexion("select sum(cantidad) as total from salida where id_producto="+ID_PRODUCTO+"");
						base.leer=base.comando.ExecuteReader();
						if(base.leer.Read())
						{
							if(base.leer["total"]!=null&&base.leer["total"].ToString()!="")
							{
								salida =  Convert.ToInt16(base.leer["total"]);
							}
						}
						base.conexion.Close();
						
						total = entrada - salida;
						
						sentencia = "UPDATE Producto SET Cantidad='"+total+"' WHERE ID="+ID_PRODUCTO;
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
						mensaje.Show();
					}
					else
					{
						MessageBox.Show("No hay suficientes productos en el almacen", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					
					*/
					#endregion
				}
				#endregion
				
				#region PRODUCTO
				public void InsertarProducto(String PIEZA, String MARCA, String MODELO, String APLICACION, String TIPOVEHICULO, float CANTIDAD, String MEDIDA, String ID_GRUPO, String NO_SERIE, String CODIGOBARRAS)
				{
					string sentencia = "";
					sentencia = "INSERT INTO PRODUCTO_ALMACEN (PIEZA, MARCA, MODELO, APLICACION, TIPOVEHICULO, EXISTENCIA, MEDICION, ESTATUS, ID_GRUPO, NO_SERIE, CODIGO_BARRAS) values ('"+PIEZA+"', '"+MARCA+"', '"+MODELO+"', '"+APLICACION+"', '"+TIPOVEHICULO+"', '"+CANTIDAD+"', '"+MEDIDA+"', 'Activado', '"+ID_GRUPO+"', '"+NO_SERIE+"', '"+CODIGOBARRAS+"');";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();					
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ORDEN_COMPRA		
				public void InsertarOrdenCompra(String Folio, String Fecha, String Factura, String Semana, String Vencimiento, int ID_Proveedor, String Subtotal_1, String Tipo_Desc1, String Descuento_1, String Tipo_IVA, String IVA, String Subtotal_2, String Tipo_Desc2, String Descuento_2, String Total, String Total_Letra, String Observaciones)
				{	
					String sentencia = "INSERT INTO ORDEN_COMPRA VALUES('"+Folio+"', '"+Fecha+"', '"+Factura+"', '"+Semana+"', '"+Vencimiento+"', '"+ID_Proveedor+"', '"+Subtotal_1+"', '"+Tipo_Desc1+"', '"+Descuento_1+"', '"+Tipo_IVA+"', '"+IVA+"', '"+Subtotal_2+"', '1"+Tipo_Desc2+"', '"+Descuento_2+"', '"+Total+"', '"+Total_Letra+"', '"+Observaciones+"' , 'Por Autorizar', '1');";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
					mensaje.Show();
				}
				
				public void InsertarListaCompra(int Orden_Compra, String Movimiento, String Cantidad, int ID_Producto, int ID_Carro, String Precio_U, String Subtotal)
				{
					String sentencia = "INSERT INTO LISTA_ORDENCOMPRA VALUES('"+Orden_Compra+"', '"+Movimiento+"', '"+Cantidad+"', '"+ID_Producto+"', '"+ID_Carro+"', '"+Precio_U+"', '"+Subtotal+"', 1);";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
				#endregion
				
			#endregion
			
			#region ELIMINAR
			
				#region ELIMINAR AGRUPACION
				public void AgrupacionActivDesact(String id, String estatus)
				{
					string sentencia = "";
					sentencia = "UPDATE GRUPO_PRODUCTO SET ESTATUS='"+estatus+"' WHERE ID="+id;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron actualizados correctamente");
					mensaje.Show();
				}
				#endregion

				#region ELIMINAR INTERVENCION
				public void EliminarIntervencion(String ID)
				{
					string sentencia = "";
					sentencia = "DELETE FROM TIPO_INTERVENCION WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron eliminados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ELIMINAR PROVEEDOR
				public void DesactivarProveedor(String ID)
				{
					string sentencia = "";
					sentencia = "UPDATE PROVEEDOR_ALMACEN SET ESTATUS='Inactivo' WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron actualizados correctamente");
					mensaje.Show();
				}
				
				public void ActivarProveedor(String ID)
				{
					string sentencia = "";
					sentencia = "UPDATE PROVEEDOR_ALMACEN SET ESTATUS='Activo' WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ELIMINAR ENTRADA
				public void EliminarEntrada(String ID)
				{
					string sentencia = "";
					sentencia = "DELETE FROM PROVEEDOR_ALMACEN WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					sentencia = "DELETE FROM PROVEEDOR_ALMACEN WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron eliminados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ELIMINAR SALIDA
				public void EliminarSalida(String ID)
				{
					string sentencia = "";
					sentencia = "DELETE FROM Salida WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					sentencia = "DELETE FROM Historial_Salida WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron eliminados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ELIMINAR PRODUCTO
				public void DesactivarProducto(String ID)
				{
					string sentencia = "";
					sentencia = "UPDATE PRODUCTO_ALMACEN SET ESTATUS='Desactivado' WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}
				
				public void ActivarProducto(String ID)
				{
					string sentencia = "";
					sentencia = "UPDATE PRODUCTO_ALMACEN SET ESTATUS='Activado' WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ELIMINAR LISTA_ORDENCOMPRA
				public void EliminarListaOrdenCompra(String ID)
				{
					string sentencia = "";
					sentencia = "DELETE FROM LISTA_ORDENCOMPRA WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
				#endregion
				
			#endregion
			
			#region ACTUALIZAR
			
				#region ACTUALIZAR AGRUPACION
				public void ActualizarAgrupacion(String Nombre,String Descripcion, int id)
				{
					string sentencia = "";
					sentencia = "UPDATE GRUPO_PRODUCTO SET NOMBRE='"+Nombre+"', DESCRIPCION ='"+Descripcion+"' WHERE ID="+ id;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ACTUALIZAR INTERVENCION
				public void ActualizarIntervencion(String Nombre,String Descripcion, int id)
				{
					string sentencia = "";
					sentencia = "UPDATE TIPO_INTERVENCION SET Nombre='"+Nombre+"', Descripcion ='"+Descripcion+"' where ID="+ id;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ACTUALIZAR PROVEEDOR
				public void ActualizarProveedores(int IDpa, String Clave, String Nombre, String NombreCom, String Atencion, String PlazoC, String Clase, String Telefono, String Contacto, String Direccion, String RFC, String Descripcion, String Email)
				{
					string sentencia = "";
					sentencia = "UPDATE PROVEEDOR_ALMACEN SET Clave = '"+Clave+"', Nombre = '"+Nombre+"', NombreCom ='"+NombreCom+"', Atencion = '"+Atencion+"', PlazoCredito = '"+PlazoC+"', Clase = '"+Clase+"', Telefono = '"+Telefono+"', Contacto = '"+Contacto+"', Direccion = '"+Direccion+"', RFC = '"+RFC+"', Descripcion = '"+Descripcion+"', Correo = '"+Email+"' where ID="+IDpa;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos se actualizaron correctamente");
					mensaje.Show();
				}
				#endregion
				
				#region ACTUALIZAR PRODUCTO
				public void ActualizarProducto(String PIEZA, String MARCA, String MODELO, String APLICACION, String TIPOVEHICULO, String MEDIDA, String ID_GRUPO, String NO_SERIE, String CODIGOBARRAS, int ID)
				{
					string sentencia = "";
					sentencia = "UPDATE PRODUCTO_ALMACEN SET PIEZA='"+PIEZA+"', MARCA='"+MARCA+"', MODELO='"+MODELO+"', APLICACION='"+APLICACION+"', TIPOVEHICULO='"+TIPOVEHICULO+"', MEDICION='"+MEDIDA+"', ESTATUS='Activado', ID_GRUPO="+ID_GRUPO+", NO_SERIE='"+NO_SERIE+"', CODIGO_BARRAS='"+CODIGOBARRAS+"' WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}
				
				public void ActualizaExistencias(String cantidad, Int32 idProd)
				{
					String sentencia = "UPDATE PRODUCTO_ALMACEN SET EXISTENCIA = EXISTENCIA + '"+cantidad+"' WHERE ID = '"+idProd+"';";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
					mensaje.Show();
				}
				#endregion				
				
				#region ACTUALIZAR ORDEN_COMPRA
				public void ActualizarOrdenCompra(int Id, String Folio, String Fecha, String Factura, String Semana, String Vencimiento, int ID_Proveedor, String Subtotal_1, String Tipo_Desc1, String Descuento_1, String Tipo_IVA, String IVA, String Subtotal_2, String Tipo_Desc2, String Descuento_2, String Total, String Total_Letra, String Observaciones)
				{	
					String sentencia = "UPDATE ORDEN_COMPRA SET FOLIO='"+Folio+"', FECHA='"+Fecha+"', FACTURA='"+Factura+"', SEMANA='"+Semana+"', VENCIMIENTO='"+Vencimiento+"', ID_PROVEE='"+ID_Proveedor+"', SUBTOTAL_1='"+Subtotal_1+"', TIPO_DESC1='"+Tipo_Desc1+"', DESCUENTO_1='"+Descuento_1+"', TIPO_IVA='"+Tipo_IVA+"', IVA='"+IVA+"', SUBTOTAL_2='"+Subtotal_2+"', TIPO_DESC2='"+Tipo_Desc2+"', DESCUENTO_2='"+Descuento_2+"', TOTAL='"+Total+"', TOTAL_LETRA='"+Total_Letra+"', OBSERVACIONES='"+Observaciones+"' WHERE ID="+Id;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
					mensaje.Show();
				}
				
				public void ActualizarListaCompra(int ID, String Movimiento, String Cantidad, int ID_Producto, int ID_Carro, String Precio_U, String Subtotal)
				{
					String sentencia = "UPDATE LISTA_ORDENCOMPRA SET MOVIMIENTO='"+Movimiento+"', CANTIDAD='"+Cantidad+"', ID_PROD='"+ID_Producto+"', ID_CARRO='"+ID_Carro+"', PRECIO_U='"+Precio_U+"', SUBTOTAL='"+Subtotal+"' WHERE ID="+ID;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
				#endregion
				
			#endregion
			
			#region OBTENER ID'S
				
				#region RETORNA ID DE VEHICULO
				public String IDVehiculo(String numero)
				{
					String ID = "";
					base.getAbrirConexion("SELECT ID FROM VEHICULO WHERE NUMERO ='"+numero+"'");
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						ID = base.leer["ID"].ToString();
					base.conexion.Close();
					return ID;
				}
				#endregion
				
				#region RETORNA ID DE AGRUPACION
				public String IDAgrupacion(String NOMBRE)
				{
					String ID = "";
					base.getAbrirConexion("SELECT ID FROM GRUPO_PRODUCTO WHERE NOMBRE='"+NOMBRE+"'");
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						ID = base.leer["ID"].ToString();
					base.conexion.Close();
					return ID;
				}
				#endregion
				
				#region RETORNA ID DEL PRODUCTO
				public String RetornaIdProducto(String campo, String valor)
				{
					String ID = "";
					base.getAbrirConexion("SELECT ID FROM PRODUCTO_ALMACEN WHERE "+campo+"='"+valor+"'");
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						ID = base.leer["ID"].ToString();
					base.conexion.Close();
					return ID;
				}
				
				public String IDCodigo()
				{
					String IDP = "";
					
					base.getAbrirConexion("SELECT MAX(ID+1) AS ID FROM PRODUCTO_ALMACEN");
					base.leer = base.comando.ExecuteReader();
					while(base.leer.Read())
							IDP = base.leer["ID"].ToString();
					base.conexion.Close();
					
					if(IDP != "")
					{
						return IDP;
					}
					else
					{
						return "1";
					}
				}
				#endregion
			
				#region RETORNA ID DEL PROVEEDOR
				public String IDProveedor(String nombre)
				{
					String ID = "";
					base.getAbrirConexion("select ID from PROVEEDOR_ALMACEN where nombre= '"+nombre+"'");
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						ID = base.leer["ID"].ToString();
					base.conexion.Close();
					return ID;
				}
				
				public String IDProveedor2(String campo, String valor)
				{
					String ID = "";
					base.getAbrirConexion("SELECT ID FROM PROVEEDOR_ALMACEN WHERE "+campo+"= '"+valor+"'");
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						ID = base.leer["ID"].ToString();
					base.conexion.Close();
					return ID;
				}
				#endregion
			
				#region RETORNA ID DE ORDEN_COMPRA
				public String IdOrdenC(String folio)
				{
					String ID = "";
					base.getAbrirConexion("SELECT ID FROM ORDEN_COMPRA WHERE FOLIO = '"+folio+"';");
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						ID = base.leer["ID"].ToString();
					base.conexion.Close();
					return ID;
				}
				
				// ULTIMO ID AGREGADO
				public String IDOrdenCompra()
				{	
					String ID = "";
					int x = 0;
					base.getAbrirConexion("SELECT TOP 1 * FROM ORDEN_COMPRA ORDER BY ID DESC");
					base.leer = base.comando.ExecuteReader();
					while(base.leer.Read())
						x = Convert.ToInt16(base.leer["ID"]);
					base.conexion.Close();
					return ID = (x != 0) ? Convert.ToString(x) : "1" ;
				}
				#endregion
				
				#region RETORNA ID DE ENTRADA
				public String IDEntradaTop()
				{
					String ID = "";
					int x = 0;
					base.getAbrirConexion("SELECT TOP 1 * FROM ENTRADA_PRODUCTO_ALMACEN ORDER BY ID DESC");
					base.leer = base.comando.ExecuteReader();
					while(base.leer.Read())
						x = Convert.ToInt16(base.leer["ID"]);
					base.conexion.Close();
					return ID = (x != 0) ? Convert.ToString(x) : "1" ;
				}
				#endregion
			
			#endregion
			
			#region OBTENER DATOS ESPECIFICOS
				
				#region RETORNA DATOS DEL PRODUCTO
				public String NombreProduc(String ID)
				{
					String Nombre = "";
					base.getAbrirConexion("select PIEZA FROM PRODUCTO_ALMACEN WHERE id="+ID);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						Nombre = base.leer["PIEZA"].ToString();
					base.conexion.Close();
					return Nombre;
				}
				
				public String CadenaProdOrdenC(String id)
				{
					String cadenaProd = "";
					base.getAbrirConexion("SELECT pa.PIEZA, pa.MARCA, pa.MODELO FROM PRODUCTO_ALMACEN pa WHERE pa.ID = " + id);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						cadenaProd = base.leer["Pieza"].ToString()+" - "+
							   		 base.leer["Marca"].ToString()+", "+
							   		 base.leer["Modelo"].ToString();
					base.conexion.Close();
					return cadenaProd;
				}
				#endregion
				
				#region RETORNA DATOS DEL VEHICULO
				public String NumeroVEHICULO(String ID)
				{
					String Numero = "";
					base.getAbrirConexion("select Numero from VEHICULO where id="+ID);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						Numero = base.leer["Numero"].ToString();
					base.conexion.Close();
					return Numero;
				}
				
				public String CadenaCarroOrdenC(String id)
				{
					String cadenaCarro = "";
					base.getAbrirConexion("SELECT v.Numero, v.Tipo_Unidad, v.Tipo_Servicio, v.Marca, v.Modelo FROM VEHICULO v WHERE v.ID = " + id);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						cadenaCarro = base.leer["Numero"].ToString()+" - "+
								      base.leer["Tipo_Unidad"].ToString()+" "+
								      base.leer["Tipo_Servicio"].ToString()+", "+
								      base.leer["Marca"].ToString()+" "+
								      base.leer["Modelo"].ToString();
					base.conexion.Close();
					return cadenaCarro;
				}
				#endregion
				
				#region RETORNA DATOS DEL PROVEEDOR
				public String DatosProveedor(String campo, String id)
				{
					String dato = "";
					base.getAbrirConexion("SELECT "+campo+" FROM PROVEEDOR_ALMACEN WHERE ID = "+id);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						dato = base.leer[campo].ToString();
					base.conexion.Close();
					return dato;
				}
				#endregion
										
				#region RETORNA SUMA DE EXISTENCIAS DE PRODUCTOS
				public int SumaProduc(String ID)
				{
					int cantidad = 0;
					base.getAbrirConexion("select SUM(EXISTENCIA) as EXISTENCIA "+
		                               "from PRODUCTO_ALMACEN where id="+ID);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						cantidad = Convert.ToInt32(base.leer["EXISTENCIA"]);
					base.conexion.Close();
					return cantidad;
				}
				#endregion
				
				#region RETORNA DATOS DE ORDEN_COMPRA
				/// <summary>
				/// Realiza una consulta con los valores proporcionados en los parametros de entrada 
				/// </summary>
				/// <param name="campo">Nombre de columna en la tabla a consultar</param>
				/// <param name="id">Identificador del registro a consultar</param>
				/// <returns>Devuelve una cadena tipo String con el resultado de la consulta</returns>
				public String DatosOrdenCompra(String campo, String id)
				{
					String dato = "";
					base.getAbrirConexion("SELECT " +campo+ " FROM ORDEN_COMPRA WHERE ID="+id);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						dato = base.leer[campo].ToString();
					base.conexion.Close();
					return dato;
				}
				#endregion
				
			#endregion
			
			#region CONTEO REGISTROS
				
				#region ENTRADA				
				public int TotalEntradasProds()
				{
					int cantidad = 0;
					base.getAbrirConexion("SELECT * FROM PRODUCTO_ALMACEN");
					base.leer = base.comando.ExecuteReader();
					while(base.leer.Read())
						cantidad++;
					base.conexion.Close();
					
					return cantidad;
				}
				
				public int TotalEntradasProdsActivados()
				{
					int cantidad = 0;
					base.getAbrirConexion("SELECT * FROM PRODUCTO_ALMACEN  WHERE ESTATUS = 'Activado' ORDER BY EXISTENCIA  DESC");
					base.leer = base.comando.ExecuteReader();
					while(base.leer.Read())
						cantidad++;
					base.conexion.Close();
					
					return cantidad;
				}
				#endregion
				
				#region PRODUCTO / PROVEEDOR
				public void ConteoProdProv(String bd, String estatus, Label etiqueta)
				{
					base.getAbrirConexion("SELECT COUNT(*) AS Cuenta FROM "+ bd +" WHERE ESTATUS = '" + estatus + "'");
					base.leer = base.comando.ExecuteReader();
					while(base.leer.Read())
							etiqueta.Text = base.leer["Cuenta"].ToString();
					base.conexion.Close();
				}
				#endregion
				
				#region ORDEN_COMPRA
				public String ConteoOrdenes()
				{
					String cuenta = "0";
					base.getAbrirConexion("SELECT COUNT(*) AS Conteo FROM ORDEN_COMPRA");
					base.leer =  base.comando.ExecuteReader();
					while(base.leer.Read())
						cuenta =  base.leer["Conteo"].ToString();
					base.conexion.Close();
					return cuenta;					
				}
				#endregion
				
			#endregion
			
			#region VALIDACIONES
			
				#region  AGRUPACION
				public Boolean ValidarExisteAgrupacion(String NOM)
				{
					string validar = ""; 
					base.getAbrirConexion("SELECT NOMBRE FROM GRUPO_PRODUCTO WHERE NOMBRE='"+NOM+"'");
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						validar = Convert.ToString(base.leer["NOMBRE"]);
					base.conexion.Close();
					
					if(validar != "")
					{
						return false;
					}
					else{
						return true;
					}
				}					
				#endregion	
				
				#region  PRODUCTO							
				public Boolean ValidarExisteProducto(String NOM, String opcional)
				{
					string validar = ""; 
					base.getAbrirConexion("select ID from PRODUCTO_ALMACEN where PIEZA='"+NOM+"' " + opcional);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						validar = Convert.ToString(base.leer["ID"]);
					base.conexion.Close();						
					if(validar!="")
					{
						return false;
					}
					else
					{
						return true;
					}
				}					
				#endregion					
				
				#region  INTERVENCION
				public Boolean ValidarExisteIntervencion(String NOM)
					{
						string validar = ""; 
						base.getAbrirConexion("select NOMBRE from TIPO_INTERVENCION where NOMBRE='"+NOM+"'");
						base.leer=base.comando.ExecuteReader();
						while(base.leer.Read())
							validar = Convert.ToString(base.leer["NOMBRE"]);						
						base.conexion.Close();
						
						if(validar!="")
						{
							return false;
						}
						else{
							return true;
						}
					}					
					
				public Boolean ValidarEliminarImtervencion(String id_intervencion)
					{
						string validar = ""; 
						base.getAbrirConexion("select ID from ORDEN_TRABAJO where ID_INTERVENCION="+id_intervencion);
						base.leer=base.comando.ExecuteReader();
						while(base.leer.Read())
							validar = Convert.ToString(base.leer["ID"]);
						
						base.conexion.Close();
						
						if(validar!="")
						{
							return false;
						}
						else{
							return true;
						}
					}					
				#endregion	
				
				#region SALIDA
				public Boolean ValidarExisteOrdenTrabajo(String ID)
					{
						string validar = ""; 
						base.getAbrirConexion("select ID from ORDEN_TRABAJO where ID = "+ ID);
						base.leer=base.comando.ExecuteReader();
						while(base.leer.Read())
							validar = Convert.ToString(base.leer["ID"]);
						
						base.conexion.Close();						
						if(validar!="")
						{
							return false;
						}
						else{
							return true;
						}
					}
				#endregion
				
				#region ORDEN COMPRA
				public Boolean ValidaOrdenCompra(String campo, String valor, String opcional)
				{
					string valida = ""; 
					base.getAbrirConexion("SELECT ID FROM ORDEN_COMPRA WHERE "+campo+" = '"+valor+"' " + opcional);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						valida = Convert.ToString(base.leer["ID"]);
					base.conexion.Close();						
					if(valida != "")
					{
						return false;
					}
					else
					{
						return true;
					}
				}		
				#endregion
				
				#region ENTRADA
				public Boolean ArticuloDeOrdenC(String idOrden, String idProducto)
				{
					String validar = "";
					String sentencia = "SELECT pa.ID FROM ORDEN_COMPRA oc, LISTA_ORDENCOMPRA lo, PRODUCTO_ALMACEN pa WHERE lo.ID_ORDENC = oc.ID AND lo.ID_PROD = pa.ID AND oc.ID = '"+idOrden+"' AND pa.ID = '"+idProducto+"';";
					base.getAbrirConexion(sentencia);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
						validar = Convert.ToString(base.leer["ID"]);
					base.conexion.Close();						
					if(validar!="")
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				#endregion
						
			#endregion
			
		#endregion
		
		#region ORDEN DE TRABAJO
		
			#region ORDEN TRABAJO
			
				#region INSERTAR				
				public void InsertarOrdenT(String TIPO_MANTENIMIENTO, String ID_VEHICULO, String ID_OPERADOR, Int32 ID_USUARIO, String CODIGO, String ESTATUS, String ARRIVO, String ORIGEN, String FECHA_REPORTE, String HORA_REPORTE, String HORA_TIRADO, String FECHA_PROGRAMADA, String HORA_PROGRAMADA)
				{
					string sentencia = "";					
					sentencia = "INSERT INTO ORDEN_TRABAJO(TIPO_MANTENIMIENTO, ID_VEHICULO, ID_OPERADOR, ID_USUARIO, CODIGO, FECHA_REPORTE, HORA_REPORTE, HORA_TIRADO, ESTATUS, FECHA_PROGRAMADA, HORA_PROGRAMADA, ARRIVO, FLUJO, ESTADO_ACTUAL, FECHA_REGISTRO, HORA_REGISTRO) "+
						 "VALUES('"+TIPO_MANTENIMIENTO+"',"+ID_VEHICULO+","+ID_OPERADOR+","+ID_USUARIO+", '"+CODIGO+"','"+FECHA_REPORTE+"','"+HORA_REPORTE+"','"+HORA_TIRADO+"','"+ESTATUS+"' ,'"+FECHA_PROGRAMADA+"','"+HORA_PROGRAMADA+"','"+ARRIVO+"',"+1+","+1+",'"+DateTime.Now.ToString("dd/MM/yyyy")+"','"+DateTime.Now.ToString("HH:MM:ss")+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();				
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
					mensaje.Show();
				}				
			
				public void InsertarEntrada(String FECHA_INGRESO, String HORA_INGRESO, String COMBUSTIBLE, String KILOMETRAJE, int idOrden)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDEN_TRABAJO  SET FECHA_INGRESO='"+FECHA_INGRESO+"', HORA_INGRESO ='"+HORA_INGRESO+"' ,KILOMETRAJE_ENTRADA ='"+KILOMETRAJE+"' , COMBUSTIBLE_ENTRADA ='"+COMBUSTIBLE+"', FLUJO ="+2+" WHERE ID =" +idOrden;
						
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}	

				public void InsertarSalida(String KILOMETRAJE_SALIDA, String COMBUSTIBLE_SALIDA, String COMENTARIOS, String FECHA_SALIDA, String HORA_SALIDA, int idOrden)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDEN_TRABAJO  SET KILOMETRAJE_SALIDA = "+KILOMETRAJE_SALIDA+", COMBUSTIBLE_SALIDA = '"+COMBUSTIBLE_SALIDA+"',  COMENTARIOS = '"+COMENTARIOS+"', FLUJO ="+4+", FECHA_SALIDA ='"+FECHA_SALIDA+"', HORA_SALIDA = '"+HORA_SALIDA+"' WHERE ID =" +idOrden;		
					
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se agrego la salida correctamente");
					mensaje.Show();
					//MOTIVOS='"+DateTime.Now.ToShortDateString()+"', HORA_ORDEN ='"+DateTime.Now.ToString("HH:MM:ss")+"',
				}	
				#endregion
				
				#region ACTUALIZAR
				public void ActualizarOrdenTrabajoEntrada(String TIPO_MANTENIMIENTO, String OPERADOR, String CODIGO, String FECHA_REPORTE, String HORA_REPORTE, String ESTATUS, String FECHA_PROGRAMADA, String HORA_TIRADO, int id)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDEN_TRABAJO SET TIPO_MANTENIMIENTO = '"+TIPO_MANTENIMIENTO+"', ID_OPERADOR ="+OPERADOR+", FECHA_REPORTE = '"+FECHA_REPORTE+"', HORA_REPORTE = '"+HORA_REPORTE+"', HORA_TIRADO = '"+HORA_TIRADO+"', ESTATUS = '"+ESTATUS+"', FECHA_PROGRAMADA = '"+FECHA_PROGRAMADA+"' WHERE  ID = "+id;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}	
			
				public void ActualizarOrdenTrabajo(String descripcion_t, String id_vehiculo, String id_operador, String id_mecanico, String id_intervencion, int id)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDEN_TRABAJO  SET FECHA_ORDEN='"+DateTime.Now.ToShortDateString()+"', HORA_ORDEN ='"+DateTime.Now.ToString("HH:MM:ss")+"', DESCRIPCION_TRABAJOS ='"+descripcion_t+"' ," +
						" ID_VEHICULO ="+id_vehiculo+ ", ID_OPERADOR ="+id_operador+" ,ID_MECANICO ="+id_mecanico+" ,ID_INTERVENCION =" +id_intervencion+ "WHERE ID =" +id;
		
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}		
				
				public void CambiarSalida(String FECHA_SALIDA, String MOTIVOS, int idOrden)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDEN_TRABAJO  SET FLUJO ="+3+", FECHA_SALIDA_ESTIMADA ='"+FECHA_SALIDA+"' ," +	" MOTIVOS_NOSALIDA ='"+MOTIVOS+"' WHERE ID =" +idOrden;
							
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se agrego la salida correctamente");
					mensaje.Show();
					//MOTIVOS='"+DateTime.Now.ToShortDateString()+"', HORA_ORDEN ='"+DateTime.Now.ToString("HH:MM:ss")+"',
				}	
				#endregion
				
				#region ELIMINAR
				public void EliminarOrdenTrabajo(int idOrden)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDEN_TRABAJO  SET ESTADO_ACTUAL = 0 WHERE ID =" +idOrden;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se Elimino la Orden de Trabajo correctamente");
					mensaje.Show();
				}	
				#endregion
			
				#region CANCELAR
				public void CancelarOrdenTrabajo(int idOrden, String FECHA_ANTERIOR, String HORA_ANTERIOR, String FECHA_NUEVA, String HORA_NUEVA, String PERSONA_CANCELO, String MOTIVOS_CANCELO)
				{
					string sentencia = "";
					sentencia = "INSERT INTO ORDENTRABAJO_CANCELADA (ID_ORDENTRABAJO, FECHA_ANTERIOR, HORA_ANTERIOR, FECHA_NUEVA, HORA_NUEVA, PERSONA_CANCELO, MOTIVOS_CANCELO) VALUES("+idOrden+", '"+FECHA_ANTERIOR+"',  '"+HORA_ANTERIOR+"',  '"+FECHA_NUEVA+"',  '"+HORA_NUEVA+"',  '"+PERSONA_CANCELO+"',  '"+MOTIVOS_CANCELO+"')"; 
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				
					sentencia = "UPDATE ORDEN_TRABAJO SET FECHA_PROGRAMADA = '"+FECHA_NUEVA+"', HORA_PROGRAMADA = '"+HORA_NUEVA+"' WHERE ID = "+idOrden;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se Cancelo la Orden de Trabajo correctamente");
					mensaje.Show();
				}	
				#endregion
				
			#endregion
			
			#region FALLAS
				#region INSERTAR
				public void InsertarEntradaFallas(String REPORTO_FALLA, String TIPO_FALLA, String DESCRIPCION_FALLA, String TIPO_TALLER, String NOMBRE_TALLER, String DESCRIPCION_REPARACION, int  FLUJO)
				{
					string sentencia = "";
					sentencia = "INSERT INTO ORDENTRABAJO_FALLA (ID_OREDENTRABAJO, REPORTO_FALLA, TIPO_FALLA, DESCRIPCION_FALLA, TIPO_TALLER, NOMBRE_TALLER, DESCRIPCION_REPARACION, ESTADO, FLUJO) VALUES ("+IDMaxOrdenTrabajo()+", '"+REPORTO_FALLA+"', '"+TIPO_FALLA+"', '"+DESCRIPCION_FALLA+"', '"+TIPO_TALLER+"', '"+NOMBRE_TALLER+"', '"+DESCRIPCION_REPARACION+"', 1, "+FLUJO+")";
						
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
				
				public void InsertarEntradaFallas1(int id_orden, String REPORTO_FALLA, String TIPO_FALLA, String DESCRIPCION_FALLA, String TIPO_TALLER, String NOMBRE_TALLER, String DESCRIPCION_REPARACION, int  FLUJO)
				{
					string sentencia = "";
					sentencia = "INSERT INTO ORDENTRABAJO_FALLA (ID_OREDENTRABAJO, REPORTO_FALLA, TIPO_FALLA, DESCRIPCION_FALLA, TIPO_TALLER, NOMBRE_TALLER, DESCRIPCION_REPARACION, ESTADO, FLUJO) VALUES ("+id_orden+", '"+REPORTO_FALLA+"', '"+TIPO_FALLA+"', '"+DESCRIPCION_FALLA+"', '"+TIPO_TALLER+"', '"+NOMBRE_TALLER+"', '"+DESCRIPCION_REPARACION+"', 1, "+FLUJO+")";
						
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}				
				
				#endregion
				
				#region ACTUALIZAR			
				public void ActualizarFalla(String TIPO_FALLA, String DESCRIPCION_FALLA, String NOMBRE_TALLER, String DESCRIPCION_REPARACION, String id)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDENTRABAJO_FALLA SET TIPO_FALLA = '"+TIPO_FALLA+"', DESCRIPCION_FALLA ='"+DESCRIPCION_FALLA+"', NOMBRE_TALLER = '"+NOMBRE_TALLER+"', DESCRIPCION_REPARACION = '"+DESCRIPCION_REPARACION+"' WHERE  ID = "+id;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}	
				#endregion
				
				#region ELIMINAR
				public void EliminarFalla(String idFalla)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDENTRABAJO_FALLA SET ESTADO_ACTUAL = 0 WHERE ID =" +idFalla;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se Elimino la Falla correctamente");
					mensaje.Show();
				}	
				#endregion
				
				#region 
				public void EstadoFalla(int EstadoFalla, String idFalla)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDENTRABAJO_FALLA SET ESTADO = "+EstadoFalla+" WHERE ID =" +idFalla;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}	
				#endregion
				
			#endregion
					
			#region MECANICOS
			
				#region INSERTAR
				public void InsertarMecanicoOrdenT(String TIPO_MECANICO, String ID_MECANICO, String HORAS_EXTRAS, String MOTIVOS, int ID_OREDENTRABAJO)
				{
					string sentencia = "";					
					sentencia = "INSERT INTO ORDENTRABAJO_MECANICO (TIPO_MECANICO, ID_MECANICO, HORAS_EXTRAS, MOTIVOS, ID_OREDENTRABAJO) VALUES ('"+TIPO_MECANICO+"', '"+ID_MECANICO+"', '"+HORAS_EXTRAS+"', '"+MOTIVOS+"', "+ID_OREDENTRABAJO+")";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();	
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se agrego la Entrada correctamente");
					mensaje.Show();					
				}				
				#endregion
				
				#region ACTUALIZAR																						
				public void ActualizarMecanico(String TIPO_MECANICO, String HORAS_EXTRAS, String MOTIVOS, String id)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDENTRABAJO_MECANICO  SET TIPO_MECANICO='"+TIPO_MECANICO+"', HORAS_EXTRAS ='"+HORAS_EXTRAS+"', MOTIVOS ='"+MOTIVOS+"'WHERE ID =" +id;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
					mensaje.Show();
				}					
				#endregion
				
				#region ELIMINAR
				public void EliminarMecanico(String idMecanico)
				{
					string sentencia = "";
					sentencia = "UPDATE ORDENTRABAJO_MECANICO SET ESTADO_ACTUAL = 0 WHERE ID =" +idMecanico;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se Elimino el mecánico correctamente");
					mensaje.Show();
				}	
				#endregion
				
			#endregion
			
			#region OBTENER FECHA DE ORDEN DE TRABAJO
			public String FechaOrdenTrabajo(int Id_ordentrabajo)
			{
				String FECHA = "";
				base.getAbrirConexion("select CONVERT(CHAR(10), FECHA_PROGRAMADA, 103) as FECHA from ORDEN_TRABAJO where ID = "+Id_ordentrabajo);
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					FECHA = base.leer["FECHA"].ToString();
				base.conexion.Close();
				return FECHA;
			}
			#endregion
			
			#region OBTENER HORA DE ORDEN DE TRABAJO
			public String HoraOrdenTrabajo(int Id_ordentrabajo)
			{
				String HORA = "";
				base.getAbrirConexion("select HORA_PROGRAMADA from ORDEN_TRABAJO where ID = "+Id_ordentrabajo);
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					HORA = base.leer["HORA_PROGRAMADA"].ToString();
				base.conexion.Close();
				return HORA;
			}
			#endregion
				
			#region OBTENER ID VEHICULO
			public String IDVehiculoNumero(String NUMERO)
			{
				String ID = "";
				base.getAbrirConexion("SELECT ID "+
	                               "FROM vehiculo WHERE NUMERO = '"+NUMERO+"'");
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					ID = base.leer["ID"].ToString();
				base.conexion.Close();
				return ID;
			}
			#endregion
			
			#region OBTENER ID MAXIMO DE ORDEN DE TRABAJO
			public String IDMaxOrdenTrabajo()
			{
				String ID = "";
				base.getAbrirConexion("SELECT MAX(ID) AS ID FROM ORDEN_TRABAJO");
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					ID = base.leer["ID"].ToString();
				base.conexion.Close();
				return ID;
			}
			#endregion
			
			#region OBTENER ID OPERADOR Y MECANICO
			public String IDMecanicoOperador(String ALIAS)
			{
				String ID = "";
				base.getAbrirConexion("SELECT ID "+
	                               "FROM OPERADOR WHERE ALIAS = '"+ALIAS+"'");
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					ID = base.leer["ID"].ToString();
				base.conexion.Close();
				return ID;
			}
			#endregion			
		
			#region OBTENER ID INTERVENCION
			public String IDIntervencion(String NOMBRE)
			{
				String ID = "";
				base.getAbrirConexion("SELECT ID "+
	                               "FROM tipo_intervencion WHERE Nombre='"+NOMBRE+"'");
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					ID = base.leer["ID"].ToString();
				base.conexion.Close();
				return ID;
			}
			#endregion
		#endregion
	}
}
