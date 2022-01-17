using System;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Collections.Generic;
using Transportes_LAR.Interfaz.Operador.Dato;

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
		                        string estado, string tipoVehiculo, int cant_pasajeros, string refVisual, bool mixto, DataGridView data,
		                        int fact, String tipoPago, string saldo, string numeroAntic, bool chkAnt, DataGridView dgAnticipos, int OpCobra, 
		                        String comentario, String encuesta)
		{
			string sentencia = "";
			sentencia = "execute almacenar_viaje_especial '" + colonia + "','" + cruces  + "','" + cliente  + "','" + telefono + "'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			double pago_sencillo=0;
			if(Convert.ToDouble(pago_operador)>0)
				pago_sencillo=(Convert.ToDouble(pago_operador)/2);
			
			
			int ID_C=0;
			base.getAbrirConexion("select MAX(ID) ID From cliente");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				ID_C=Convert.ToInt16(base.leer["ID"]);
			}
			base.conexion.Close();
			
			for(int x=0; x<Convert.ToInt16(unidades); x++)
			{
				sentencia = "execute almacenar_rutas_especial '"+ h_salida + "','" + h_regreso +
			                         "','"+ tipo +
			                         "','" + domicilio + "','"+ destino +
			                         "','"+ km +
			                         "','"+ pago_operador+"', '"+pago_sencillo+"','"+dia+"','"+foranea+"','"+sentido+"', "+ID_C;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			
			sentencia = "execute almacenar_datos_especial '" +fecha + "','"+h_planton +"','"+respnsable+"','"+unidades+"','"+domicilio+"','"+destino+"','"+casetas+"','"+precio+"','"+datos+"','"+observaciones+"','"+idus+"','"+correo+"','"+fechaR+"','"+Convert.ToDouble(anticipos)+"','"+estado+"', '"+((mixto==true)?"MIXTO":tipoVehiculo)+"', '"+cant_pasajeros+"', '"+ refVisual+"', '"+fact+"', '"+tipoPago+"', '"+saldo+"', '"+numeroAntic+"', '"+OpCobra+"', '"+comentario+"', '"+encuesta+"'";
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
			
			if(chkAnt==true && dgAnticipos.Rows.Count>0)
			{
				for(int y=0; y<dgAnticipos.Rows.Count; y++)
				{
					if(dgAnticipos[3,y].Value.ToString()=="1")
					{
						sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ((SELECT MAX(ID_RE) FROM RUTA_ESPECIAL), '"+dgAnticipos[0,y].Value.ToString()+"', '"+dgAnticipos[1,y].Value.ToString()+"', '"+dgAnticipos[2,y].Value.ToString()+"', '0', null, null, '"+dgAnticipos[4,y].Value.ToString()+"', '', 'ANTICIPO', '', NULL) ";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}
			}
			
			Int64 IDD=0;
			base.getAbrirConexion("select MAX(ID_RE) ID from ruta_especial");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				IDD = Convert.ToInt64(base.leer["ID"]);
			}
			base.conexion.Close();
			
			base.getAbrirConexion("execute AUDITA_GRAL	'RUTA_ESPECIAL', "+IDD+", 'INSERT', "+idus);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region ACTUALIZAR VIAJE
		List<string> IDSE = new List<string>();
		List<string> IDSS = new List<string>();
		
		List<string> IDSE2 = new List<string>();
		List<string> IDSS2 = new List<string>();
		
		public void getActualizarRutaEspecial(string fecha, string h_salida, string h_planton, string h_regreso, 
		                        string respnsable, string cliente, string unidades, string tipo,
		                        string domicilio,
		                        string cruces, string colonia, string destino, string casetas, 
		                        string precio, string km, string telefono, string datos, 
		                        string observaciones, string pago_operador, string dia, string foranea, int idus, String sentido, int IDRE, int IDC, string correo, string fechaR, string anticipos, string estado,
		                        string refVisual, int cantUsuarios, bool mixto, DataGridView data, String CAMBIO, Int64 cant,
		                        int fact, String tipoPago, string saldo, string numeroAntic, bool chkAnt, DataGridView dgAnticipos, int OpCobra,
		                        String comentario, String encuesta)
		{
			string sentencia = "";
			bool continuar=true;
			double pago_sencillo=0;
			
			if(Convert.ToDouble(pago_operador)>0)
			{
				pago_sencillo=(Convert.ToDouble(pago_operador)/2);
			}
			
			if(CAMBIO=="MAS")
			{
				for(int x=0; x<cant; x++)
				{
					sentencia = "execute almacenar_rutas_especial '"+ h_salida + "','" + h_regreso +
				                         "','"+ tipo +
				                         "','" + domicilio + "','"+ destino +
				                         "','"+ km +
				                         "','"+ pago_operador+"', '"+pago_sencillo+"','"+dia+"','"+foranea+"','"+sentido+"',"+IDC;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					continuar=true;
				}
			}
			else if(CAMBIO=="MENOS")
			{
				// Obtengo IDS de ruta de entrada
				
				base.getAbrirConexion("select ID from RUTA R, OPERACION O where O.estatus='0' and R.ID=O.id_ruta and R.sentido='Entrada' and IdSubEmpresa='"+IDC+"'");
				
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
				{
					IDSE.Add(base.leer["ID"].ToString());
				}
				base.conexion.Close();
				
				// Obtengo IDS de ruta de entrada
				
				String datt = "select ID from RUTA R, OPERACION O where O.estatus='0' and R.ID=O.id_ruta and R.sentido='Salida' and R.IdSubEmpresa='"+IDC+"'";
				//String datt = "Select R.ID from RUTA R, Operacion O where O.id_ruta=R.id and O.estatus='0' and R.idsubempresa="
				base.getAbrirConexion(datt);
				
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
				{
					IDSS.Add(base.leer["ID"].ToString());
				}
				base.conexion.Close();
				// ************************************************
				
				if(IDSE.Count>=cant && IDSS.Count>=cant)
				{
					for(int x=0; x<cant; x++)
					{
						sentencia = "UPDATE RUTA set idsubempresa='33', Nombre=Nombre+' "+IDC+"' where ID='"+IDSE[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						sentencia = "UPDATE RUTA set idsubempresa='33', Nombre=Nombre+' "+IDC+"' where ID='"+IDSS[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
					continuar=true;
				}
				else if(revisaOperacion(IDC)==true)
				{
					for(int x=0; x<cant; x++)
					{
						sentencia = "delete from RUTA where ID='"+IDSE[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						sentencia = "delete from RUTA where ID='"+IDSS[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}
				else if(revisaOperacion2(IDC, cant)==true)
				{
					for(int x=0; x<cant; x++)
					{
						sentencia = "delete from RUTA where ID='"+IDSE2[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						sentencia = "delete from RUTA where ID='"+IDSS2[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}
				else
				{
					MessageBox.Show("Servcios ya asignados en coordinación. No se podra modificar...!!!");
					continuar=false;
				}
			}
				
			if(estado=="Cancelado" && revisaAsignacion(IDRE)==false)
			{
				MessageBox.Show("Para cancelar es necesario liberar en operaciones.");
			}
			else
			{
				if(continuar==true)
				{
					sentencia = "UPDATE RUTA SET foranea='"+foranea+"', Nombre='"+destino+"', HoraInicio='" +h_salida + "', HORA_FIN='"+h_regreso+"', Kilometros='"+km +"',  SencilloCamioneta='"+pago_sencillo+"', CompletoCamioneta='"+pago_operador+"', SencilloCamion='"+pago_sencillo+"', CompletoCamion='"+pago_operador+"', SencilloForaneo='"+pago_sencillo+"', CompletoForaneo='"+pago_operador+"' WHERE Sentido='Entrada' and  IdSubEmpresa='"+IDC+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					sentencia = "UPDATE RUTA SET foranea='"+foranea+"', Nombre='"+destino+"', HoraInicio='" +h_regreso + "', HORA_FIN='"+h_regreso+"', Kilometros='"+km +"',  SencilloCamioneta='"+pago_sencillo+"', CompletoCamioneta='"+pago_operador+"', SencilloCamion='"+pago_sencillo+"', CompletoCamion='"+pago_operador+"', SencilloForaneo='"+pago_sencillo+"', CompletoForaneo='"+pago_operador+"' WHERE Sentido='Salida' and IdSubEmpresa='"+IDC+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					sentencia = "UPDATE ContactoServicio SET Nombre='" +cliente + "', Telefono='"+telefono+"' WHERE IdCliente='"+IDC+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					sentencia = "UPDATE Cliente SET Estado='"+colonia+"', Rumbo='"+cruces+"' where ID="+IDC;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					//*******************
					
					//bool facturado=false;
					//bool entraFact=false;
					base.getAbrirConexion("select * from RUTA_ESPECIAL where ID_RE="+IDRE);
					
					base.leer=base.comando.ExecuteReader();
					if(base.leer.Read())
					{
						//if(base.leer["FACTURADO"].ToString()=="1")
							//facturado=true;		
						/*
						if(base.leer["FACTURADO"].ToString()=="3" || base.leer["FACTURADO"].ToString()=="2")
							facturado=true;		
						else if(base.leer["FACTURADO"].ToString()=="0")
						{
							entraFact=true;
						}
						*/
					}
					base.conexion.Close();
					
					base.getAbrirConexion("execute AUDITA_GRAL 'RUTA_ESPECIAL', "+IDRE+", 'UPDATE', "+idus);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
										
//					if(facturado==true)
//					{
						sentencia = "UPDATE RUTA_ESPECIAL SET COMENTARIO='"+comentario+"', ENCUESTA='"+encuesta+"', OP_COBRA='"+OpCobra+"', ref_Visual='"+refVisual+"', cantidad_usuarios="+cantUsuarios+", tipoVehiculo='"+tipo+"', FECHA_SALIDA='" +fecha + "', H_PLANTON='"+h_planton +"', RESPONSABLE='"+respnsable+"', CANT_UNIDADES='"+unidades+"', DOMICILIO='"+domicilio+"', DESTINO='"+destino+"', CASETAS='"+casetas+"', PRECIO='"+precio+"',  FACTURA='"+datos+"', OBSERVACIONES='"+observaciones+"', correo='"+correo+"', fecha_regreso='"+fechaR+"', anticipo='"+Convert.ToDouble(anticipos)+"', estado='"+estado+"', FACTURADO='"+fact+"', NUMERO_ANTI='0', TIPO_PAGO='"+tipoPago+"', SALDO='"+saldo+"' WHERE ID_RE='"+IDRE+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						//MessageBox.Show("El servicio ya fue facturado por tal motivo no se modifico la razon social.");
//					}
//					else
//					{
//						sentencia = "UPDATE RUTA_ESPECIAL SET COMENTARIO='"+comentario+"', ENCUESTA='"+encuesta+"', OP_COBRA='"+OpCobra+"', ref_Visual='"+refVisual+"', cantidad_usuarios="+cantUsuarios+", tipoVehiculo='"+tipo+"', FECHA_SALIDA='" +fecha + "', H_PLANTON='"+h_planton +"', RESPONSABLE='"+respnsable+"', CANT_UNIDADES='"+unidades+"', DOMICILIO='"+domicilio+"', DESTINO='"+destino+"', CASETAS='"+casetas+"', PRECIO='"+precio+"',  FACTURA='"+datos+"', OBSERVACIONES='"+observaciones+"', correo='"+correo+"', fecha_regreso='"+fechaR+"', anticipo='"+Convert.ToDouble(anticipos)+"', estado='"+estado+"', FACTURADO='0', TIPO_PAGO='"+tipoPago+"', SALDO='"+saldo+"', NUMERO_ANTI='"+numeroAntic+"' WHERE ID_RE='"+IDRE+"'";
//						base.getAbrirConexion(sentencia);
//						base.comando.ExecuteNonQuery();
//						base.conexion.Close();
//					}
						
					/*
					if(facturado==true)
					{
						sentencia = "UPDATE RUTA_ESPECIAL SET COMENTARIO='"+comentario+"', ENCUESTA='"+encuesta+"', OP_COBRA='"+OpCobra+"', ref_Visual='"+refVisual+"', cantidad_usuarios="+cantUsuarios+", tipoVehiculo='"+tipo+"', FECHA_SALIDA='" +fecha + "', H_PLANTON='"+h_planton +"', RESPONSABLE='"+respnsable+"', CANT_UNIDADES='"+unidades+"', DOMICILIO='"+domicilio+"', DESTINO='"+destino+"', CASETAS='"+casetas+"', PRECIO='"+precio+"',  FACTURA='"+datos+"', OBSERVACIONES='"+observaciones+"', correo='"+correo+"', fecha_regreso='"+fechaR+"', anticipo='"+Convert.ToDouble(anticipos)+"', estado='"+estado+"', FACTURADO='1', NUMERO_ANTI='0', TIPO_PAGO='"+tipoPago+"', SALDO='"+saldo+"' WHERE ID_RE='"+IDRE+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						MessageBox.Show("El servicio ya fue facturado por tal motivo no se modifico la razon social.");
					}
					else //(entraFact==true)
					{
						sentencia = "UPDATE RUTA_ESPECIAL SET COMENTARIO='"+comentario+"', ENCUESTA='"+encuesta+"', OP_COBRA='"+OpCobra+"', ref_Visual='"+refVisual+"', cantidad_usuarios="+cantUsuarios+", tipoVehiculo='"+tipo+"', FECHA_SALIDA='" +fecha + "', H_PLANTON='"+h_planton +"', RESPONSABLE='"+respnsable+"', CANT_UNIDADES='"+unidades+"', DOMICILIO='"+domicilio+"', DESTINO='"+destino+"', CASETAS='"+casetas+"', PRECIO='"+precio+"',  FACTURA='"+datos+"', OBSERVACIONES='"+observaciones+"', correo='"+correo+"', fecha_regreso='"+fechaR+"', anticipo='"+Convert.ToDouble(anticipos)+"', estado='"+estado+"', FACTURADO='"+fact+"', TIPO_PAGO='"+tipoPago+"', SALDO='"+saldo+"', NUMERO_ANTI='"+numeroAntic+"' WHERE ID_RE='"+IDRE+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
					
					*/
					//********************
					
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
					
					if(chkAnt==true && dgAnticipos.Rows.Count>0)
					{
						for(int y=0; y<dgAnticipos.Rows.Count; y++)
						{
							if(dgAnticipos[3,y].Value.ToString()=="1")
							{
								sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+IDRE+", '"+dgAnticipos[0,y].Value.ToString()+"', '"+dgAnticipos[1,y].Value.ToString()+"', '"+dgAnticipos[2,y].Value.ToString()+"', '0', null, null, '"+dgAnticipos[4,y].Value.ToString()+"', '', 'ANTICIPO', '', NULL) ";
								base.getAbrirConexion(sentencia);
								base.comando.ExecuteNonQuery();
								base.conexion.Close();
							}
						}
					}
				}
			}
		}
		
		bool revisaOperacion2(int id_c, Int64 cant)
		{
			IDSE2.Clear();
			IDSS2.Clear();
			bool respuesta=true;
			
			String datt = "select ID " +
				"from RUTA " +
				"where sentido='Entrada' and ID not in" +
					"(select r.id " +
					"from OPERACION O, RUTA R, Cliente C " +
					"where O.id_ruta=R.ID and R.IdSubEmpresa=C.ID and C.ID="+id_c+") and IdSubEmpresa='"+id_c+"'";
			
			base.getAbrirConexion(datt);			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				IDSE2.Add(base.leer["ID"].ToString());
			}
			base.conexion.Close();
			
			datt = "select ID " +
				"from RUTA " +
				"where sentido='Salida' and ID not in" +
					"(select r.id " +
					"from OPERACION O, RUTA R, Cliente C " +
					"where O.id_ruta=R.ID and R.IdSubEmpresa=C.ID and C.ID="+id_c+") and IdSubEmpresa='"+id_c+"'";
			
			base.getAbrirConexion(datt);			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				IDSS2.Add(base.leer["ID"].ToString());
			}
			base.conexion.Close();
			
			if(cant<=IDSE2.Count && cant<=IDSS2.Count)
			{
				respuesta=true;
			}
			else
			{
				respuesta=false;
			}
			
			return respuesta;
		}
		
		bool revisaOperacion(int id_c)
		{
			bool respuesta=true;
			String datt = "select ID from RUTA R, OPERACION O where R.ID=O.id_ruta and R.IdSubEmpresa='"+id_c+"'";
			base.getAbrirConexion(datt);
			
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				respuesta=false;
			}
			base.conexion.Close();
			
			if(respuesta==true)
			{
				datt = "select ID from RUTA where sentido='Entrada' and IdSubEmpresa='"+id_c+"'";
				base.getAbrirConexion(datt);
				
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
				{
					IDSE.Add(base.leer["ID"].ToString());
				}
				base.conexion.Close();
				
				datt = "select ID from RUTA where sentido='Salida' and IdSubEmpresa='"+id_c+"'";
				base.getAbrirConexion(datt);
				
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
				{
					IDSS.Add(base.leer["ID"].ToString());
				}
				base.conexion.Close();
			}
			return respuesta;
		}
		
		bool revisaAsignacion(Int64 ID_RE)
		{
			bool respuesta=true;
			
			base.getAbrirConexion("select * from OPERACION O, RUTA R, RUTA_ESPECIAL E where O.estatus='1' and O.id_ruta=R.ID and R.IdSubEmpresa=E.ID_C and E.ID_RE="+ID_RE);
			base.leer=base.comando.ExecuteReader();
			
			if(base.leer.Read())
				respuesta=false;
			else
				respuesta=true;
					
			base.conexion.Close();
			
			return respuesta;
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
		
		#region PAGO Y FACTURACION DE ESPECIAL
		public void borradoTotalEsp(String ID_RE)
		{
			String sentencia = "update RUTA_ESPECIAL set PAGADO='2' where ID_RE='"+ID_RE+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
			
			sentencia = "update COBRO_ESPECIAL set BORRADO='1' where ID_RE='"+ID_RE+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		
		public void borradoEsp(String IDENTIFICADOR)
		{
			/*String sentencia = "update COBRO_ESPECIAL set BORRADO='1' where IDENTIFICADOR='"+IDENTIFICADOR+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();*/
		}
		
		public void pagoEsp(String IDENTIFICADOR)
		{
			String sentencia = "update COBRO_ESPECIAL set PAGO = '1' where IDENTIFICADOR='"+IDENTIFICADOR+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		
		public void pagoEspecial(String id)
		{			
			String sentencia = "update COBRO_ESPECIAL set PAGO = '1' where ID = '"+id+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();			
			base.conexion.Close();
		}
			
		public void pagoEsp2(String ID)
		{
			String sentencia = "update COBRO_ESPECIAL set PAGO='1' where ID='"+ID+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		
		public void facturaEsp(String IDENTIFICADOR, String DATO)
		{
			String sentencia = "update COBRO_ESPECIAL set FACTURA='1', NUMERO_FACT='"+DATO+"' where IDENTIFICADOR='"+IDENTIFICADOR+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		
		public void IncobraEsp(String IDENTIFICADOR)
		{
			String sentencia = "update COBRO_ESPECIAL set INCOBRABLE='1' where IDENTIFICADOR='"+IDENTIFICADOR+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		
		
		// ****************************final******************************************************
		public void IncobraEspCompleto(String ID_RE)
		{
			String sentencia = "update ruta_especial set INCOBRABLE='1' where ID_RE="+ID_RE;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		
		
		public void borradoEspCompleto(String ID_RE)
		{
			String sentencia = "update COBRO_ESPECIAL set BORRADO='1' where ID_RE="+ID_RE;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
			
			sentencia = "update ruta_especial set PAGADO='3' where ID_RE="+ID_RE;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
			
			sentencia = "update ANTICIPOS_ESPECIALES set ESTATUS='3' where ID_RE="+ID_RE;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		//***************************************************************************************
		
		public void guardaDatosInc(Int64 ID_RE, String recuperado, string efectivo, string deposito, string comentario, Int64 id_u, string perdido)
		{
			String sentencia = "insert into PAGO_INCOBRO values ('"+ID_RE+"', '"+recuperado+"', '"+efectivo+"', '"+deposito+"', '"+comentario+"', '"+id_u+"', (SELECT CONVERT (varchar, SYSDATETIME())), '"+perdido+"')";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			
			base.conexion.Close();
		}
		#endregion
		
		
		// *****************************************
		
		public List<Interfaz.Libro.Dato.datosViajes> getIdsSalidas()
		{
			List<Interfaz.Libro.Dato.datosViajes> datos = new List<Interfaz.Libro.Dato.datosViajes>();
			
			base.getAbrirConexion("select R.ID, RE.ID_RE, RE.DESTINO from RUTA R, Cliente C, RUTA_ESPECIAL RE where R.IdSubEmpresa=C.ID and C.ID=RE.ID_C AND R.Sentido='SALIDA' and FECHA_SALIDA>='2013/02/12' and R.PAGO='0' ORDER BY C.ID");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Libro.Dato.datosViajes dat = new Interfaz.Libro.Dato.datosViajes();
				
				dat.dato1 	 =base.leer["ID"].ToString();
				dat.dato2	 =base.leer["ID_RE"].ToString();
				dat.dato3	 =base.leer["DESTINO"].ToString();
				datos.Add(dat);
			}
			base.conexion.Close();
			
			return (datos.Count>0)?datos:null;
		}
		
		// *****************************************ESPECIALES REPENTINOS********************************************
		
		#region ALMACENAR VIAJE
		public void almacenarRepentino(Int64 ID_rep, String FECHA_SALIDA, String FECHA_REGRESO, String HORA_SERVICIO, String MIN_SERVICIO, String HORA_PLANTON, String MIN_PLANTON,  String HORA_REGRESO, String MIN_REGRESO,
									   String CONFIRMACION, String DESTINO, String RESPONSABLE, String CLIENTE, String DOMICILIO, String CRUCES, String COLONIA, String REF_VISUAL, String CORREO, String TELEFONO, String FACTURA,
									   String OBSERVACIONES, int CANT_UNIDADES, int CANT_PASAJEROS, String TIPO_UNIDADES, String KILOMETROS, String CASETAS, String PAGO_OPERADOR,
									   String PRECIO, String ANTICIPO, Int64 ID_U, String ACCION)
		{
			String sentencia = "execute ALMACENAR_MODIFICAR_REPENTINOS '"+ID_rep+"', '"+FECHA_SALIDA+"', '"+FECHA_REGRESO+"', '"+HORA_SERVICIO+"', '"+MIN_SERVICIO+"', '"+HORA_PLANTON+"', '"+MIN_PLANTON+"', '"+HORA_REGRESO+"', '"+MIN_REGRESO+"', '"+CONFIRMACION+"', '"+DESTINO+"', '"+RESPONSABLE+"', '"+CLIENTE+"', '"+DOMICILIO+"', '"+CRUCES+"', '"+COLONIA+"', '"+REF_VISUAL+"', '"+CORREO+"', '"+TELEFONO+"', '"+FACTURA+
																"', '"+OBSERVACIONES+"', '"+CANT_UNIDADES+"', '"+CANT_PASAJEROS+"', '"+TIPO_UNIDADES+"', '"+KILOMETROS+"', '"+CASETAS+"', '"+PAGO_OPERADOR+"', '"+PRECIO+"', '"+ANTICIPO+"', '"+ID_U+"', 'ALMACENAR'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void almacenarOperadores(Int64 ID_VR, Int64 ID_O)
		{
			String sentencia = "INSERT INTO ASIGNACION_REPENTINOS VALUES ("+ID_VR+", "+ID_O+")";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion		
	
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////// LIBRO NUEVO ///////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region PROSPECTOS
		public int obtenerNumero(){			
			int numero = 0;
			base.getAbrirConexion("select MAX(NUMERO) NUMERO from VIAJE_PROSPECTO_NUEVO WHERE FECHA_REGISTRO = '"+DateTime.Today.ToString("yyyy-MM-dd")+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){					
				try{
					numero = Convert.ToInt32(base.leer["NUMERO"]);
				}catch (Exception){
					numero = 0;
				}
			}
			base.conexion.Close();			 
			return numero+1;
		}
		
		public void insertarProspecto(string FOLIO, string NUMERO, string CONTACTO, string CORREO, string COMPANIA, string TELEFONO, string EXT, string FORANEO, string EVENTO, string DETALLE, string TIPO_CLIENTE, string KM_SERVICIO, 
		                              string CASETAS_SERVICIO, string DIESEL_SERVICIO, string OTROS_SERVICIO, string TIPO_TRANSPOTE, string CANTIDAD, string USUARIOS, string BANIO, string AC, string TV, string FECHA_SALIDA, string HORA_SALIDA, string FECHA_REGRESO, 
		                              string HORA_REGRESO, string HORA_PLANTON, string DIAS, string UBICACION_PARTIDA, string DE_CAMINO, string LLEVARLOS, string REGRESARLOS, string ITINERARIO, string KM_ITINERARIO, string CASETAS_ITINERARIO,
										string PRECIO_ITINERARIO, string SUELDO_OPERADOR, string PRECIO_UNITARIO, string TOTAL, string FACTURA, string TOTAL_IVA, string FLUJO, string ID_USUARIO, string FECHA_ACUERDO, string PAGO_DIFERENTE, 
										string PRECIO_DIFERENTE, string FECHA_FACTURA,  string COMPANIA_NOMBRE, String ruta, string entero, string empresarial)
		{	
			try{						
				string sentencia = "";
				sentencia = @"INSERT INTO VIAJE_PROSPECTO_NUEVO(FOLIO, NUMERO, CONTACTO, CORREO, COMPANIA, TELEFONO, EXT, FORANEO, EVENTO, DETALLE, TIPO_CLIENTE, KM_SERVICIO, CASETAS_SERVICIO, DIESEL_SERVICIO, OTROS_SERVICIO, TIPO_TRANSPOTE, CANTIDAD, USUARIOS,
							 BANIO, AC, TV, FECHA_SALIDA, HORA_SALIDA, FECHA_REGRESO, HORA_REGRESO, HORA_PLANTON, DIAS, UBICACION_PARTIDA, DE_CAMINO, LLEVARLOS, REGRESARLOS, ITINERARIO, KM_ITINERARIO, CASETAS_ITINERARIO, PRECIO_ITINERARIO, 
								SUELDO_OPERADOR, PRECIO_UNITARIO, TOTAL, FACTURA, TOTAL_IVA, FECHA_ACUERDO, ESTADO, FLUJO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO, PAGO_DIFERENTE, PRECIO_DIFERENTE, FECHA_FACTURA, COMPANIA_NOMBRE, LINK_RUTA, MEDIO_ENTERO, EMPRESARIAL)
									VALUES('"+FOLIO+"', '"+NUMERO+"', '"+CONTACTO+"', '"+CORREO+"', '"+COMPANIA+"', '"+TELEFONO+"', '"+EXT+"', '"+FORANEO+"', '"+EVENTO+"', '"+DETALLE+"', '"+TIPO_CLIENTE+"', '"+KM_SERVICIO+"', '"+CASETAS_SERVICIO+"', '"+DIESEL_SERVICIO+"', '"+OTROS_SERVICIO
											+"', '"+TIPO_TRANSPOTE+"', '"+CANTIDAD+"', '"+USUARIOS+"', '"+BANIO+"', '"+AC+"', '"+TV+"', '"+FECHA_SALIDA+"', '"+HORA_SALIDA+"', '"+FECHA_REGRESO+"', '"+HORA_REGRESO+"', '"+HORA_PLANTON+"', '"+DIAS+"', '"+UBICACION_PARTIDA+"', '"+DE_CAMINO
											+"', '"+LLEVARLOS+"', '"+REGRESARLOS+"', '"+ITINERARIO+"', '"+KM_ITINERARIO+"', '"+CASETAS_ITINERARIO+"', '"+PRECIO_ITINERARIO+"', '"+SUELDO_OPERADOR+"', '"+PRECIO_UNITARIO+"', '"+TOTAL+"', '"+FACTURA+"', '"+TOTAL_IVA+"', '"+FECHA_ACUERDO
											+"',  'Activo', '"+FLUJO+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"', '"+PAGO_DIFERENTE+"', '"+PRECIO_DIFERENTE+"', '"+FECHA_FACTURA+"', '"+COMPANIA_NOMBRE+"', '"+ruta+"', '"+entero+"', '"+empresarial+"')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EL PROSPECTO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void eliminaCotizaicon(int id)
		{	
			try{						
				string sentencia = "";
				sentencia = @"delete VIAJE_PROSPECTO_NUEVO where id = " +id;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR AL CANCELAR UNA COTIZACION POR ERROR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		public void actualizarProspecto(string FOLIO, string NUMERO, string CONTACTO, string CORREO, string COMPANIA, string TELEFONO, string EXT, string FORANEO, string EVENTO, string DETALLE, string TIPO_CLIENTE, string KM_SERVICIO, 
		                              string CASETAS_SERVICIO, string DIESEL_SERVICIO, string OTROS_SERVICIO, string TIPO_TRANSPOTE, string CANTIDAD, string USUARIOS, string BANIO, string AC, string TV, string FECHA_SALIDA, string HORA_SALIDA, string FECHA_REGRESO, 
		                              string HORA_REGRESO, string HORA_PLANTON, string DIAS, string UBICACION_PARTIDA, string DE_CAMINO, string LLEVARLOS, string REGRESARLOS, string ITINERARIO, string KM_ITINERARIO, string CASETAS_ITINERARIO,
										string PRECIO_ITINERARIO, string SUELDO_OPERADOR, string PRECIO_UNITARIO, string TOTAL, string FACTURA, string TOTAL_IVA, string FLUJO, string ID_USUARIO, string id, string PAGO_DIFERENTE, 
										string PRECIO_DIFERENTE, string FECHA_FACTURA, string COMPANIA_NOMBRE, String ruta, string entero, string empresarial)
		{	
			try{		
				string sentencia = "";
				sentencia = @"UPDATE VIAJE_PROSPECTO_NUEVO SET  NUMERO = '"+NUMERO+"', CONTACTO = '"+CONTACTO+"', CORREO = '"+CORREO+"', COMPANIA = '"+COMPANIA+"', TELEFONO = '"+TELEFONO+"', EXT = '"+EXT+"', FORANEO = '"+FORANEO+"', EVENTO = '"+EVENTO+"', DETALLE = '"+DETALLE+
					"', TIPO_CLIENTE = '"+TIPO_CLIENTE+"', KM_SERVICIO = '"+KM_SERVICIO+"', CASETAS_SERVICIO = '"+CASETAS_SERVICIO+"', DIESEL_SERVICIO = '"+CASETAS_SERVICIO+"', OTROS_SERVICIO = '"+OTROS_SERVICIO+"', TIPO_TRANSPOTE = '"+TIPO_TRANSPOTE+"', CANTIDAD = '"+CANTIDAD+
					"', USUARIOS = '"+USUARIOS+"', BANIO = '"+BANIO+"',AC = '"+AC+"' , TV = '"+TV+"', FECHA_SALIDA = '"+FECHA_SALIDA+"', HORA_SALIDA = '"+HORA_SALIDA+"', FECHA_REGRESO = '"+FECHA_REGRESO+"', HORA_REGRESO = '"+HORA_REGRESO+
					"', HORA_PLANTON = '"+HORA_PLANTON+"', DIAS = '"+DIAS+"', UBICACION_PARTIDA = '"+UBICACION_PARTIDA+"', DE_CAMINO = '"+DE_CAMINO+"', LLEVARLOS = '"+LLEVARLOS+"', REGRESARLOS = '"+REGRESARLOS+"', ITINERARIO = '"+ITINERARIO+
					"', KM_ITINERARIO = '"+KM_ITINERARIO+"', CASETAS_ITINERARIO = '"+CASETAS_ITINERARIO+"', PRECIO_ITINERARIO = '"+PRECIO_ITINERARIO+"', SUELDO_OPERADOR = '"+SUELDO_OPERADOR+"', PRECIO_UNITARIO = '"+PRECIO_UNITARIO+
					"', TOTAL = '"+TOTAL+"', FACTURA = '"+FACTURA+"', TOTAL_IVA= '"+TOTAL_IVA+"', FLUJO = '"+FLUJO+"', PAGO_DIFERENTE = '"+PAGO_DIFERENTE+"', PRECIO_DIFERENTE = '"+PRECIO_DIFERENTE+"', FECHA_FACTURA = '"+FECHA_FACTURA
					+"', COMPANIA_NOMBRE = '"+COMPANIA_NOMBRE+"', LINK_RUTA = '"+ruta+"', MEDIO_ENTERO = '"+entero+"', EMPRESARIAL = '"+empresarial+"' WHERE ID = '"+id+"'";
				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();									
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR EL PROSPECTO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}

		public void cancelarProspecto(int id, int usuario, string servicio, string observaciones)
		{		
			try{
				string sentencia = "";
				sentencia = @"UPDATE VIAJE_PROSPECTO_NUEVO SET ESTADO = 'Cancelado' where ID = "+id;
				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("ERROR AL CANCELAR EL PROSPECTO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			try{				
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('DELETE', 'ID COTIZACION:"+id+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+usuario+", 'VIAJE_PROSPECTO')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();					
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EN AUDITORIA_GENERAL: "+ex.Message);
			}
			
			try{
				string sentencia1 = @"INSERT INTO CANCELACION_COTIZACION(ID_COTIZACION, SERVICIO_C, OBSERVACIONES, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO)
										VALUES('"+id+"', '"+servicio+"', '"+observaciones+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), "+usuario+")";				
				base.getAbrirConexion(sentencia1);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EN CANCELACION_COTIZACION: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void cambiarFechaAcuerdo(int id, string fecha)
		{		
			try{			
				string sentencia = "";
				sentencia = @"UPDATE VIAJE_PROSPECTO_NUEVO SET FECHA_ACUERDO = '"+fecha+"' where ID = "+id;
				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR LA FECHA DEL ACUERDO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}					
		#endregion
		
		#region VIAJE
		public Int32 obtenerIdMaxCotizacion(){
			Int32 id = 0;
			try{	
				base.getAbrirConexion("select MAX(ID) ID From VIAJE_PROSPECTO_NUEVO");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					id = Convert.ToInt16(base.leer["ID"]);
				}
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR DE BD AL OBTENER EL MÁXIMO ID DEL PROSPECTOS: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}	
			return id;
		}
		
		public Int32 obtenerCantidadVehiculos(string id_re){
			Int32 cantidad = 0;
			try{	
				base.getAbrirConexion("select COUNT(*) c from RUTA where Sentido = 'Entrada' and IdSubEmpresa = (select id_c from RUTA_ESPECIAL where ID_RE = "+id_re+")");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
					cantidad = Convert.ToInt16(base.leer["C"]);
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR AL OBTENER LA CANTIDAD DE UNIDADES DEL SERVICIO"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cantidad = 0;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}	
			return cantidad;
		}
		
		public Int32 insertarDetalleViaje(string id_cotizacion, string ciudadS, string coloniaS, string calleS, string crucesS, string referenciaS, string contacto,
		                                 string Telefono, string ciudadD, string coloniaD, string calleD, string crucesD, string referenciaD, string observaciones, string cliente, string telefonoC){
			string sentencia = "";
			bool respuesta = true;
			int ID_C = 0;
			try{				
				sentencia = "insert into CLIENTE values ('Especiales', 'Especiales', 'N/A', 'N/A', 'N/A', '"+coloniaS+"', '"+crucesS+"', (select MAX(ID)+1 from CLIENTE), 'ABIERTO', 'A', 37, 'ESPECIAL')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EL CLIENTE: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}
			if(respuesta){
				try{	
					base.getAbrirConexion("select MAX(ID) ID From cliente");
					base.leer=base.comando.ExecuteReader();
					if(base.leer.Read()){
						ID_C = Convert.ToInt16(base.leer["ID"]);
					}
					base.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("ERROR AL OBTENER EL ID CLIENTE: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					respuesta = false;
				}
				if(respuesta){
					try{
						sentencia = "insert into ContactoServicio values ('"+contacto+"', '"+telefonoC+"', 'N/A', 'N/A','N/A', "+ID_C+")";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();				
					}catch(Exception ex){
						MessageBox.Show("ERROR AL INSERTAR EL CONTACTO DEL SERVICIO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						respuesta = false;
					}
				}
				if(respuesta){
					try{				
						sentencia = "insert into DETALLE_SERVICIO values('"+id_cotizacion+"', '"+ciudadS+"', '"+coloniaS+"', '"+calleS+"', '"+crucesS+"', '"+referenciaS+"', '"+contacto+"', '"+Telefono+"', '"+
																			ciudadD+"', '"+coloniaD+"', '"+calleD+"', '"+crucesD+"', '"+referenciaD+"', '"+observaciones+"', '"+ID_C+"')";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();				
					}catch(Exception ex){
						MessageBox.Show("ERROR AL INSERTAR EL DETALLE DEL SERVICIO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			return ID_C;
		}
		
		public void actualizarDetalleViaje(int id_cliente, int id_Detalle_Servicio, string ciudadS, string coloniaS, string calleS, string crucesS, string referenciaS, string contacto,
		                                   string Telefono, string ciudadD, string coloniaD, string calleD, string crucesD, string referenciaD, string observaciones, Int32 ID_RE, string razon_social, string fecha_factura, String LINK_RUTA){
			string sentencia = "";
			
			try{
				sentencia = "update VIAJE_PROSPECTO_NUEVO set FECHA_FACTURA = '"+fecha_factura+"', PRECIO_DIFERENTE = '"+razon_social+"', LINK_INICIO_RUTA = '"+LINK_RUTA+"' where ID_RE = "+ID_RE;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR EN VIAJE_PROSPECTO_NUEVO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			
			try{										
				sentencia = "update CLIENTE set Estado = '"+coloniaS+"', Rumbo = '"+crucesS+"' where ID = "+id_cliente;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR EN CLIENTE: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			try{				
				sentencia = @"UPDATE DETALLE_SERVICIO SET CIUDAD_S = '"+ciudadS+"', COLONIA_S = '"+coloniaS+"', CALLE_S = '"+calleS+"', CRUCES_S = '"+crucesS+"', REFERENCIA_S = '"+referenciaS+"', RESPONSABLE = '"+contacto+"', TELEFONO_R = '"+
							Telefono+"', CIUDAD_D = '"+ciudadD+"', COLONIA_D = '"+coloniaD+"', CALLE_D = '"+calleD+"', CRUCES_D = '"+crucesD+"', REFERENCIA_D = '"+referenciaD+"', OBSERVACIONES = '"+observaciones+"' WHERE ID = "+id_Detalle_Servicio;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR EN DETALLE DEL SERVICIO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			string domici = calleS+" Col. "+coloniaS+" "+ciudadS+" Cruces " +crucesS;											
											
			try{				
				sentencia = @"UPDATE RUTA_ESPECIAL SET ref_Visual='"+referenciaS+"',  DOMICILIO='"+domici+"', OBSERVACIONES='"+observaciones+"', RESPONSABLE ='"+contacto+"', FACTURA = '"+razon_social+"' WHERE ID_RE='"+ID_RE+"'";				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR LA RUTA ESPECIAL: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
			
			try{				
				sentencia = "UPDATE ContactoServicio SET Nombre='" +contacto + "', Telefono='"+Telefono+"' WHERE IdCliente='"+id_cliente+"'";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR CONTACTOSERVICIO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}
		
		public Int64 insertarViaje(string UNIDADES, string HORA_SALIDA, string HORA_REGRESO, string DESTINO, string KM, string SUELDO_OPERADOR, string DIA, string FORANEA, string SENTIDO, 
		                          int id, Int32 idusuario, Int32 id_cliente, string razon_social, string fecha_factura)
		{
			string sentencia = "";			
			int ID_C = id_cliente;
			Int64 IDD = 0;
			/*
			try{	
				base.getAbrirConexion("select MAX(ID) ID From cliente");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					ID_C = Convert.ToInt16(base.leer["ID"]);
				}
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR OBTENER EL ID DEL CLIENTE: "+ex.Message);
			}
			*/
			double pago_sencillo=0;
			if(Convert.ToDouble(SUELDO_OPERADOR)>0)
				pago_sencillo=(Convert.ToDouble(SUELDO_OPERADOR)/2);
			
			for(int x=0; x<Convert.ToInt16(UNIDADES); x++)
			{
				try{
					sentencia = "execute almacenar_rutas_especial '"+HORA_SALIDA+ "','" +HORA_REGRESO+ "','N/A','N/A','" +DESTINO+ "','" +KM+ "','" +SUELDO_OPERADOR+ "', '" +pago_sencillo+ "','" +DIA+ "','" +FORANEA+ "','" +SENTIDO+ "', " +ID_C;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("ERROR AL INSERTAR EN ALMACENAR_RUTAS_ESPECIAL (TABLA RUTA): "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		//	try{		
				base.getAbrirConexion(@"select vp.CASETAS_SERVICIO, CONVERT(CHAR(10), vp.FECHA_SALIDA, 103) as FECHA_SALIDA, vp.HORA_PLANTON, ds.RESPONSABLE, vp.CANTIDAD, (''+ds.CALLE_S +', Col. '+ds.COLONIA_S +', '+ds.CIUDAD_S +', Cruces'+ds.CRUCES_S) as DOMICILIO, VP.EVENTO, vp.CASETAS_ITINERARIO,
										vp.PRECIO_UNITARIO, vp.TOTAL, ds.OBSERVACIONES, vp.ID_USUARIO, vp.CORREO,  vp.TOTAL_IVA, CONVERT(CHAR(10), vp.FECHA_REGRESO, 103) as FECHA_REGRESO, vp.ESTADO, vp.TIPO_TRANSPOTE, vp.USUARIOS, ds.REFERENCIA_S, vp.FACTURA  from VIAJE_PROSPECTO_NUEVO vp, DETALLE_SERVICIO ds 
											where vp.ID = ds.ID_COTIZACION and vp.ID ="+id);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{				
					string fecha = base.leer["FECHA_SALIDA"].ToString();
					string h_planton = base.leer["HORA_PLANTON"].ToString();
					string respnsable = base.leer["RESPONSABLE"].ToString();
					string unidades = base.leer["CANTIDAD"].ToString();
					string domicilio = base.leer["DOMICILIO"].ToString();
					string destino = base.leer["EVENTO"].ToString();
					string casetas = base.leer["CASETAS_SERVICIO"].ToString();
					string precio = base.leer["PRECIO_UNITARIO"].ToString();
					string observaciones = base.leer["OBSERVACIONES"].ToString();
					string correo = base.leer["CORREO"].ToString();
					string fechaR = base.leer["FECHA_REGRESO"].ToString();
					string estado = base.leer["ESTADO"].ToString();
					string tipoVehiculo = base.leer["TIPO_TRANSPOTE"].ToString();
					string cant_pasajeros = base.leer["USUARIOS"].ToString();
					string refVisual = base.leer["REFERENCIA_S"].ToString();
					string fact = base.leer["FACTURA"].ToString();
					string saldo = base.leer["TOTAL_IVA"].ToString();
					string anticipos = "0.0";
					string tipoPago = "";
					//string numeroAntic = "";
					string OpCobra = "0";
					string comentario = "";
					//string encuesta = "";
					base.conexion.Close();
					try{
						/*sentencia = "execute almacenar_datos_especial '" +fecha + "','"+h_planton +"','"+respnsable+"','"+unidades+"','"+domicilio+"','"+destino+"','"+casetas+"','"+precio+"','"+datos+"','"
									+observaciones+"','"+idusuario+"','"+correo+"','"+fechaR+"','"+Convert.ToDouble(anticipos)+"','"+estado+"', '"+tipoVehiculo+"','"+cant_pasajeros+"', '"+ refVisual+"', '"+
									fact+"', '"+tipoPago+"', '"+saldo+"', '"+numeroAntic+"', '"+OpCobra+"', '"+comentario+"', '"+encuesta+"'";*/
						
						sentencia =	@"insert into RUTA_ESPECIAL values ('"+ID_C+"', '"+respnsable+"', (SELECT CONVERT (varchar, SYSDATETIME())), (SELECT CONVERT(VARCHAR,getdate(),108)), '"+fecha+"', '"+h_planton
										+"', '"+unidades+"', '"+casetas+"', '"+precio+"', '"+razon_social+"' ,'"+observaciones+"', '"+idusuario+"','"+domicilio+"','"+destino+"', '"+correo+"','"+fechaR+"', '"+cant_pasajeros
										+"', '"+anticipos+"', '"+estado+"', '"+tipoVehiculo+"', '"+refVisual+"', NULL, NULL, NULL, '0', '0', '0', '"+fact+"' , '"+tipoPago+"', '"+saldo+"', '', '', '0', '0', '"+OpCobra
										+"', '"+comentario+"', '"+comentario+"', '', '', '')";	
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();	
					}catch(Exception ex){
						MessageBox.Show("ERROR AL INSERTAR EN ALMACENAR DATOS ESPECIAL (TABLA RUTA ESPECIAL) llama a lalo: "+ex.Message);
					}
					
						IDD = 0;
					try{
						base.getAbrirConexion("select MAX(ID_RE) ID from ruta_especial");
						base.leer=base.comando.ExecuteReader();
						while(base.leer.Read())
						{
							IDD = Convert.ToInt64(base.leer["ID"]);
						}
						base.conexion.Close();
						
						base.getAbrirConexion("UPDATE VIAJE_PROSPECTO_NUEVO set id_re = "+IDD+", FECHA_FACTURA = '"+fecha_factura+"', PRECIO_DIFERENTE = '"+razon_social+"' WHERE ID = "+id);
						base.comando.ExecuteNonQuery();
						base.conexion.Close(); 
													
						base.getAbrirConexion("execute AUDITA_GRAL	'RUTA_ESPECIAL', "+IDD+", 'INSERT', "+idusuario);
						base.comando.ExecuteNonQuery();
						base.conexion.Close(); 
					}catch(Exception ex){
							MessageBox.Show("ERROR EN AUDITORIA GENERAL: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}	
		//	}catch(Exception ex){
		//		MessageBox.Show("ERROR AL INSERTAR EN RUTA_ESPECIAL: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
			return IDD;
		}
		
		public void modificarViaje(string UNIDADES, string HORA_SALIDA, string HORA_REGRESO, string DESTINO, string KM, string SUELDO_OPERADOR, string DIA, string FORANEA, string SENTIDO, Int32 idusuario, String CAMBIO, Int64 cant, Int32 ID_RE)
		{	
			string sentencia = "";
			bool continuar = true;
			double pago_sencillo = 0;	
			try{		
				base.getAbrirConexion(@"select CONVERT(CHAR(10), vp.FECHA_SALIDA, 103) as FECHA_SALIDA, vp.HORA_PLANTON, ds.RESPONSABLE, vp.CANTIDAD, (''+ds.CALLE_S +', Col. '+ds.COLONIA_S +', '+ds.CIUDAD_S +', Cruces '+ds.CRUCES_S) as DOMICILIO, VP.EVENTO, vp.CASETAS_ITINERARIO, vp.PRECIO_UNITARIO, 
										 vp.CASETAS_SERVICIO, vp.TOTAL, vp.TOTAL_IVA, ds.OBSERVACIONES, vp.ID_USUARIO, vp.CORREO, CONVERT(CHAR(10), vp.FECHA_REGRESO, 103) as FECHA_REGRESO, vp.ESTADO, vp.TIPO_TRANSPOTE, vp.USUARIOS, ds.REFERENCIA_S, vp.FACTURA  from VIAJE_PROSPECTO_NUEVO vp, DETALLE_SERVICIO ds 
											where vp.ID = ds.ID_COTIZACION and vp.ID_RE = "+ID_RE);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{					
					string fecha = base.leer["FECHA_SALIDA"].ToString();
					string h_planton = base.leer["HORA_PLANTON"].ToString();
					string respnsable = base.leer["RESPONSABLE"].ToString();
					string unidades = base.leer["CANTIDAD"].ToString();
					string domicilio = base.leer["DOMICILIO"].ToString();
					string destino = base.leer["EVENTO"].ToString();
					string casetas = base.leer["CASETAS_SERVICIO"].ToString();
					string precio = base.leer["PRECIO_UNITARIO"].ToString();
					string observaciones = base.leer["OBSERVACIONES"].ToString();
					string idus = base.leer["ID_USUARIO"].ToString();
					string correo = base.leer["CORREO"].ToString();
					string fechaR = base.leer["FECHA_REGRESO"].ToString();
					string anticipos = "0";
					string estado = base.leer["ESTADO"].ToString();
					string tipoVehiculo = base.leer["TIPO_TRANSPOTE"].ToString();
					string cant_pasajeros = base.leer["USUARIOS"].ToString();
					string refVisual = base.leer["REFERENCIA_S"].ToString();
					string fact = base.leer["FACTURA"].ToString();
					string tipoPago = "";
					string saldo = base.leer["TOTAL_IVA"].ToString();
					string comentario = "";
					string encuesta = "";
					base.conexion.Close();
				
					base.getAbrirConexion("execute AUDITA_GRAL	'RUTA_ESPECIAL', "+ID_RE+", 'UPDATE', "+idusuario);
					base.comando.ExecuteNonQuery();
					base.conexion.Close(); 
						
					sentencia = "UPDATE RUTA_ESPECIAL SET COMENTARIO='"+comentario+"', ENCUESTA='"+encuesta+"', ref_Visual='"+refVisual+"', cantidad_usuarios="+cant_pasajeros+", tipoVehiculo='"+tipoVehiculo+"', FECHA_SALIDA='" +
						fecha + "', H_PLANTON='"+h_planton +"', RESPONSABLE='"+respnsable+"', CANT_UNIDADES='"+unidades+"', DOMICILIO='"+domicilio+"', DESTINO='"+destino+"', CASETAS='"+casetas+"', PRECIO='"+precio+
						"', OBSERVACIONES='"+observaciones+"', correo='"+correo+"', fecha_regreso='"+fechaR+"', anticipo='"+Convert.ToDouble(anticipos)+"', facturado = '"+fact+"', estado='"+estado+"', TIPO_PAGO='"+tipoPago+
						"', SALDO='"+saldo+"' WHERE ID_RE='"+ID_RE+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();		
				}	
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR EN RUTA_ESPECIAL: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
				
			int ID_C=0;
			try{	
				//base.getAbrirConexion("select ds.IdCliente from VIAJE_PROSPECTO_NUEVO vpn, DETALLE_SERVICIO ds where vpn.ID = ds.ID_COTIZACION and vpn.ID_RE = "+ID_RE);
				base.getAbrirConexion("select ID_C from RUTA_ESPECIAL where ID_RE = "+ID_RE);				
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					ID_C=Convert.ToInt16(base.leer["ID_C"]);
				}
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR OBTENER EL ID DEL CLIENTE: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
								
			
			if(Convert.ToDouble(SUELDO_OPERADOR)>0)
				pago_sencillo=(Convert.ToDouble(SUELDO_OPERADOR)/2);
			
			if(CAMBIO=="MAS")
			{
				for(int x=0; x<cant; x++)
				{
					sentencia = "execute almacenar_rutas_especial '"+HORA_SALIDA+ "','" +HORA_REGRESO+ "','N/A','N/A','" +DESTINO+ "','" +KM+ "','" +SUELDO_OPERADOR+ "', '" +
									pago_sencillo+ "','" +DIA+ "','" +FORANEA+ "','" +SENTIDO+ "', " +ID_C;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();					
					continuar=true;
				}
			}
			if(CAMBIO=="MENOS")
			{
				// Obtengo IDS de ruta de entrada				
				base.getAbrirConexion("select ID from RUTA R, OPERACION O where O.estatus='0' and R.ID=O.id_ruta and R.sentido='Entrada' and IdSubEmpresa='"+ID_C+"'");				
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
				{
					IDSE.Add(base.leer["ID"].ToString());
				}
				base.conexion.Close();
				
				// Obtengo IDS de ruta de salida
				String datt = "select ID from RUTA R, OPERACION O where O.estatus='0' and R.ID=O.id_ruta and R.sentido='Salida' and R.IdSubEmpresa='"+ID_C+"'";
				base.getAbrirConexion(datt);
				
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
				{
					IDSS.Add(base.leer["ID"].ToString());
				}
				base.conexion.Close();
				// ************************************************
				
				if(IDSE.Count>=cant && IDSS.Count>=cant)
				{
					for(int x=0; x<cant; x++)
					{
						sentencia = "UPDATE RUTA set idsubempresa='33', Nombre=Nombre+' "+ID_C+"' where ID='"+IDSE[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						sentencia = "UPDATE RUTA set idsubempresa='33', Nombre=Nombre+' "+ID_C+"' where ID='"+IDSS[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
					continuar=true;
				}
				else if(revisaOperacion(ID_C)==true)
				{
					for(int x=0; x<cant; x++)
					{
						sentencia = "delete from RUTA where ID='"+IDSE[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						sentencia = "delete from RUTA where ID='"+IDSS[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}
				else if(revisaOperacion2(ID_C, cant)==true)
				{
					for(int x=0; x<cant; x++)
					{
						sentencia = "delete from RUTA where ID='"+IDSE2[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						sentencia = "delete from RUTA where ID='"+IDSS2[x]+"'";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}
				else
				{
					MessageBox.Show("Servcios ya asignados en coordinación. No se podra modificar...!!!");
					continuar=false;
				}
			}		
			
				if(continuar==true)
				{									
					sentencia = "UPDATE RUTA SET foranea='"+FORANEA+"', Nombre='"+DESTINO+"', HoraInicio='" +HORA_SALIDA + "', HORA_FIN='"+HORA_REGRESO+"', Kilometros='"+KM +"',  SencilloCamioneta='"+pago_sencillo+"', CompletoCamioneta='"+SUELDO_OPERADOR+"', SencilloCamion='"+pago_sencillo+"', CompletoCamion='"+SUELDO_OPERADOR+"', SencilloForaneo='"+pago_sencillo+"', CompletoForaneo='"+SUELDO_OPERADOR+"' WHERE Sentido='Entrada' and  IdSubEmpresa='"+ID_C+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					sentencia = "UPDATE RUTA SET foranea='"+FORANEA+"', Nombre='"+DESTINO+"', HoraInicio='" +HORA_SALIDA + "', HORA_FIN='"+HORA_REGRESO+"', Kilometros='"+KM +"',  SencilloCamioneta='"+pago_sencillo+"', CompletoCamioneta='"+SUELDO_OPERADOR+"', SencilloCamion='"+pago_sencillo+"', CompletoCamion='"+SUELDO_OPERADOR+"', SencilloForaneo='"+pago_sencillo+"', CompletoForaneo='"+SUELDO_OPERADOR+"' WHERE Sentido='Salida' and IdSubEmpresa='"+ID_C+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();				
			}	
		}
		
		public void cancelarServicio(int usuario, string servicio, string observaciones, Int32 id_re, Int32 id_cotizacion){			
			string sentencia = "";
			if(revisaAsignacion(id_re)==false)
			{
				MessageBox.Show("Para cancelar es necesario liberar en operaciones.");
			}
			else
			{ 
				try{
								
					base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('DELETE', 'ID COTIZACION:"+id_cotizacion+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+usuario+", 'VIAJE_PROSPECTO')");
					base.comando.ExecuteNonQuery();
					base.conexion.Close();	
					
					string sentencia1 = @"INSERT INTO CANCELACION_COTIZACION(ID_COTIZACION, SERVICIO_C, OBSERVACIONES, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO)
										VALUES('"+id_cotizacion+"', '"+servicio+"', '"+observaciones+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), "+usuario+")";				
					base.getAbrirConexion(sentencia1);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();		
					
					sentencia = "UPDATE RUTA_ESPECIAL SET estado = 'Cancelado' WHERE ID_RE='"+id_re+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					sentencia = "UPDATE VIAJE_PROSPECTO_NUEVO SET ESTADO = 'Cancelado'  WHERE ID='"+id_cotizacion+"'";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al cancelar el servicio "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		public void insertaInicioRuta(String LINK_INICIO_RUTA, Int64 id_re)
		{	
			string sentencia = "";
			
			try{
				sentencia = "update VIAJE_PROSPECTO_NUEVO set LINK_INICIO_RUTA = '"+LINK_INICIO_RUTA+"' where ID_RE = "+id_re;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL MODIFICAR EN VIAJE_PROSPECTO_NUEVO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			
		}
		
		
		#region OBTIENE ID_RE MAXIMO
		public Int32 obtenerIdMaxServicio(){
			Int32 id = 0;
			try{	
				base.getAbrirConexion("select MAX(ID_RE) ID From RUTA_ESPECIAL");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					id = Convert.ToInt16(base.leer["ID"]);
				}
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR DE BD AL OBTENER EL MÁXIMO ID DE LOS SERVICIOS: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				base.conexion.Close();
			}	
			return id;
		}
		#endregion
		
		#endregion
		
		#region PARAMETROS
		public String obtenerParametro(Int16 id){			
			string parametro = "";			
			base.getAbrirConexion("select CONVERT(CHAR(10),PARAMETRO1, 103) as PARAMETRO from PARAMETROS_VENTAS where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				parametro = base.leer["PARAMETRO"].ToString();
			}
			base.conexion.Close();
			
			return parametro;			
		}
		
		public String obtenerParametro1(Int16 id){			
			string parametro = "";			
			base.getAbrirConexion("select PARAMETRO1 from PARAMETROS_VENTAS where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				parametro = base.leer["PARAMETRO1"].ToString();
			}
			base.conexion.Close();
			
			return parametro;			
		}
		
		public String obtenerParametro2(Int16 id){			
			string parametro = "";			
			base.getAbrirConexion("select PARAMETRO2 from PARAMETROS_VENTAS where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				parametro = base.leer["PARAMETRO2"].ToString();
			}
			base.conexion.Close();
			
			return parametro;			
		}
		
		public void modificarParametros(string nombre, string parametro1, string parametro2,  string observ, Int16 id, Int32 id_usuario){
			
			string nombreOLD = "";
			string parametroOLD = "";
			string parametroOLD2 = "";
			string observacionOLD = "";
			
			base.getAbrirConexion("select * from PARAMETROS_VENTAS where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				nombreOLD = base.leer["NOMBRE"].ToString();
				parametroOLD = base.leer["PARAMETRO1"].ToString();
				parametroOLD2 = base.leer["PARAMETRO2"].ToString();
				observacionOLD = base.leer["OBSERVACIONES"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo el parametro id: "+id+". Parametros Viejos NOMBRE: "+nombreOLD+", PARAMETRO 1: "+parametroOLD+", PARAMETRO 2: "+parametroOLD2+", OBSERVACIONES: "+observacionOLD+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'PARAMETROS_VENTAS')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
			
			String consul = "update PARAMETROS_VENTAS set NOMBRE = '"+nombre+"', PARAMETRO1 = '"+parametro1+"', PARAMETRO2 = '"+parametro2+"', OBSERVACIONES = '"+observ+"' where ID = "+id;
			base.getAbrirConexion(consul); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();	
		}
		#endregion
		
		///////////////////////////////////////////////////////// SERVICOS ////////////////////////////////////////////////////////	
		
		#region CONFIRMACION NUEVA
		public void confirmaViajeNuevo(string clienteConf, int ID_usuario, Int64 id_re)
		{
			try{
				string sentencia =  "update RUTA_ESPECIAL set CONF_CLIENTE='"+clienteConf+"', CONF_FECHA=(SELECT CONVERT (date, SYSDATETIME())), CONF_USUARIO='"+ID_usuario+"' where ID_RE="+id_re;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR DE BD AL CONFIRMAR EL SERVICIO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		
		#region AUDITORIA
		public void cambiosRealizados(Int32 ID_RE, Int32 ID_USUARIO){
			try{				
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'CAMBIO EL PRECIO O FACTURA DE UN SERVICIO YA VALIDADO ID DEL SERVICIO: "+ID_RE+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+ID_USUARIO+", 'RUTA_ESPECIAL')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();					
			}catch(Exception ex){
				MessageBox.Show("ERROR DE BD AL INSERTAR EN AUDITORIA_GENERAL: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion				
		
		#region PAGOS
		public void insertarProgramacionPago(Int64 id_re, string fecha, string tipo_pago, string metodo, string importe, string cometarios, int id_usuario){
			try{
				string sentencia =  @"INSERT INTO PROGRAMACION_PAGOS(ID_RE, FECHA, TIPO_PAGO, METODO, IMPORTE, COMENTARIOS, ESTADO, FLUJO, ID_USUARIO, FECHA_REGISTRO, HORA_REGISTRO)
										VALUES("+id_re+" , '"+fecha+"' , '"+tipo_pago+"' , '"+metodo+"' , '"+importe+"' , '"+cometarios+"', 1 , 1, "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al guardar la programación de pago "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			try{
				if(metodo == "AL OPERADOR"){				
					string sentencia = "update RUTA_ESPECIAL set OP_COBRA = 1 where ID_RE ="+id_re;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
			}catch(Exception ex){
				MessageBox.Show("Error al escribir que el operador cobra: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void actualizarProgramacionPago(Int32 id, string fecha, string tipo_pago, string metodo, string importe, string cometarios){
			string sentencia  = "";
			try{
				sentencia =  @"UPDATE PROGRAMACION_PAGOS SET FECHA = '"+fecha+"', TIPO_PAGO = '"+tipo_pago+"', METODO = '"+metodo+"', IMPORTE = '"+importe+"', COMENTARIOS = '' WHERE ID = "+id;				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al modificar la programación de pago "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			Int64 id_re = 0;
			try{	
				base.getAbrirConexion("select ID_RE from PROGRAMACION_PAGOS WHERE ID = "+id);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read()){
					id_re = Convert.ToInt16(base.leer["ID_RE"]);
				}
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR AL OBTENER EL ID_RE: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				id_re = 0;
			}
			
			if(id_re != 0){
				try{
					if(metodo == "AL OPERADOR"){		
						sentencia = "update RUTA_ESPECIAL set OP_COBRA = 1 where ID_RE ="+id_re;
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}else{
						sentencia = "update RUTA_ESPECIAL set OP_COBRA = 0 where ID_RE ="+id_re;
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}catch(Exception ex){
					MessageBox.Show("Error al modificar el operador cobra: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}			
		}
		
		public void confirmarProgramacionPago(Int32 id){
			try{
				string sentencia = @"UPDATE PROGRAMACION_PAGOS SET FLUJO = '2' WHERE ID = "+id;				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al confirmar la programación de pago "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void insertarPago(Int32 id_re, string fecha, string tipo_pago, string comprobante, string folio, string importe, string cometarios, int id_usuario, string etiqueta, string ubica, string comentario, string cobra_o){
			try{
				string sentencia =  @"INSERT INTO CONTROL_PAGOS(ID_RE, FECHA, TIPO_PAGO, COMPROBANTE, FOLIO, IMPORTE, COMENTARIOS, ESTADO, FLUJO, ID_USUARIO, FECHA_REGISTRO, HORA_REGISTRO, ETIQUETA, UBICA, ID_COBRO, COMENTARIO, COBRA_OPERADOR)	
									VALUES("+id_re+", '"+fecha+"', '"+tipo_pago+"', '"+comprobante+"', '"+folio+"', '"+importe+"' , '' , 1, 1, "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), '"+etiqueta+"', '"+ubica+"', null, '"+comentario+"', '"+cobra_o+"')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al guardar el pago "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
					
		public void insertarPago2(Int64 id_re, string fecha, string tipo_pago, string comprobante, string importe, string etiqueta, string ubica, string comentario, Int32 id_usu){
			string sentencia = "";
			sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ("+id_re+", '"+importe+"', '"+comprobante+"', '"+fecha+"', '0', null, null, '"+tipo_pago+"', '"+comentario+"', '"+etiqueta+"', '"+ubica+"', NULL)";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion(@"INSERT INTO AUDITORIA_GENERAL  VALUES('INSERT', 'REGISTRO UN ANCTIPO DESDE VENTAS ID_RE: "+id_re+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usu+", 'ANTICIPO_ESPECIAL')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
		}
		
		public void insertarPago3(Int32 id_re, string cantidad, string NUMERO, string FECHA, string ID_U, string FECHA_CONFIRMADO, string TIPO, string cometario, string ETIQUETA, string UBICA){		
			try{
				string sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ("+id_re+", '"+cantidad+"', '"+NUMERO+"', '"+FECHA+"', '1', '"+ID_U+"', '"+FECHA_CONFIRMADO+"', '"+TIPO+"', '"+cometario+"', '"+ETIQUETA+"', '"+UBICA+"', NULL)";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al insertar el anticipo :"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}						
		}
		
		
		public void actualizarActicipo(String id, string CANTIDAD, string NUMERO, string FECHA, string TIPO,  string cometario, string UBICA, string USU){
			
			try{
				string fech =  "";
				string num=  "";
				string tip =  "";
				string cant =  "";
				string comentari =  "";
				string ubic =  "";					
				base.getAbrirConexion("select * from ANTICIPOS_ESPECIALES where ID = "+id);
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read())
				{										
					fech = base.leer["FECHA"].ToString();
					num= base.leer["NUMERO"].ToString();
					tip = base.leer["TIPO"].ToString();
					cant = base.leer["CANTIDAD"].ToString();
					comentari = base.leer["cometario"].ToString();
					ubic = base.leer["UBICA"].ToString();
				}
				base.conexion.Close();	
				
				base.getAbrirConexion(@"INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'CAMBIOS EN UN ANTICIO DE UN SERVICIO, DATOS MODIFICADOS: CANTIDAD = "+cant+", NUMERO = "+num+", FECHA = "+fech+", TIPO = "+tip
									+",cometario = "+comentari+", UBICA = "+ubic+" ID DE ANTICIPO = "+id+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+USU+", 'ANTICIPO_ESPECIAL')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();					
			}catch(Exception ex){
				MessageBox.Show("ERROR DE BD AL INSERTAR EN AUDITORIA_GENERAL: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			
			try{
				string sentencia =  @"UPDATE ANTICIPOS_ESPECIALES SET CANTIDAD = '"+CANTIDAD+"', NUMERO = '"+NUMERO+"', FECHA = '"+FECHA+"', TIPO = '"+TIPO
									+"',cometario = '"+cometario+"', UBICA = '"+UBICA+"' WHERE ID = "+id;				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al modificar el anticipo: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		
		//////////////////////////////////////////////////////// IMPRESION ////////////////////////////////////////////////////////		
				
		#region INSERTAR REGISTRO DE IMPRESION
		public void insertarImpresion(string id_re,  string ID_USUARIO)
		{	
			try{						
				string sentencia = "";
				sentencia = @"INSERT INTO CONTROL_IMPRESION_CONTRATOS(ID_RE, CONTADOR, ESTADO, ID_USUARIO, FECHA_REGISTRO, HORA_REGISTRO)VALUES(
								"+id_re+", 1, 1, "+ID_USUARIO+" , (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())))";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EN IMPRESIÓN CONTRATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				base.conexion.Close();
			}
		}
		#endregion
		
		#region ACTUALIZAR CONTADOR DE IMPRESION
		public void actualizarImpresion(string id_re)
		{	
			try{						
				string sentencia = "";
				sentencia = @"UPDATE CONTROL_IMPRESION_CONTRATOS SET CONTADOR = (select CONTADOR+1 FROM CONTROL_IMPRESION_CONTRATOS where ID_RE = "+id_re+") WHERE ID_RE = "+id_re;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL AUMENTAR EL CONTADOR DE IMPRESION CONTRATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				base.conexion.Close();
			}
		}
		#endregion	
		
		////////////////////////////////////////////////////// ORDEN FACTURA //////////////////////////////////////////////////////
		
		#region FACTURACION
		public void recuperarFactura(string id_re){	
			string sentencia = "";
			int facturado;
			string fact = "";
			try{
				sentencia = @"select o.FLUJO, fre.ID_RE, o.RFC_CLIENTE  from ORDEN_FACTURA o join FACTURA_RUTA_ESPECIAL fre on fre.ID_FACTURA = o.ID where o.ESTATUS = '1' and fre.ID_RE = "+id_re;
				base.getAbrirConexion(sentencia);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read()){
					facturado = Convert.ToInt32(base.leer["FLUJO"]);
					fact = base.leer["RFC_CLIENTE"].ToString();
				}else{
					facturado = 0;
				}
				base.conexion.Close();
				
				if(facturado == 1 || facturado == 2){
					if(facturado == 1)
						sentencia = @"update RUTA_ESPECIAL set FACTURADO  = '2', FACTURA = '"+fact+"' where ID_RE = " +id_re;
					if(facturado == 2)
						sentencia = @"update RUTA_ESPECIAL set FACTURADO  = '3', FACTURA = '"+fact+"' where ID_RE = " +id_re;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();	
				}							
			}catch(Exception ex){
				MessageBox.Show("ERROR AL recuperar LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}	
		
		public void insertarOrdenFactura(string id_res,  string fechas, string vehiculo, string cant, string importe, string iva, string total,
		                           string razon_social, string contribuyente, string comentario, string orden_compra, string forma_facturacion, string id_usu){	
			string sentencia = "";
			bool respuesta = true;
			try{
				sentencia = @"INSERT INTO ORDEN_FACTURA(ID_RES,FECHAS, IMPORTE, IVA, TOTAL, VEHICULO, CANTIDAD_VEHICULO, FORMA_FACTURACION, ORDEN_COMPRA, OBSERVACIONES, ESTATUS, FLUJO, ID_USUARIO, FECHA_REGISTRO, HORA_REGISTRO, RFC_CLIENTE, CONTRIBUYENTE)
							VALUES('"+id_res+"', '"+fechas+"', '"+importe+"', '"+iva+"', '"+total+"', '"+vehiculo+"', '"+cant+"', '"+forma_facturacion+"', '"+orden_compra+"', '"+comentario+"', 1, 1, "+id_usu+
							", (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+razon_social+"', '"+contribuyente+"')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}
			
			if(respuesta){
				int ID_F = 0;
				try{	
					base.getAbrirConexion("select MAX(ID) ID From ORDEN_FACTURA");
					base.leer=base.comando.ExecuteReader();
					if(base.leer.Read())
					{
						ID_F = Convert.ToInt16(base.leer["ID"]);
					}
					base.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("ERROR AL OBTENER EL ID DE LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				if(ID_F != 0){
					string[] datos = id_res.Split('-');
					string minuto = datos[0];
					
					for(int x = 0; x < datos.Length; x++){
						sentencia = @"INSERT INTO FACTURA_RUTA_ESPECIAL(ID_FACTURA, ID_RE)VALUES( "+ID_F+", "+datos[x]+")";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();					
							
						sentencia = @"update RUTA_ESPECIAL set FACTURADO = '2' where ID_RE = "+datos[x];
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}		
			}
		}	
		
		public void insertarMetodoFactura(string id_re,  string clave, string metodo, string cuenta, string monto){	
			string sentencia = "";
			try{
				sentencia = @"INSERT INTO METODO_FACTURA(ID_RE, CLAVE, METODO, CUENTA, MONTO, ESTATUS)VALUES('"+id_re+"', '"+clave+"', '"+metodo+"', '"+cuenta+"', '"+monto+"', '1')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EL MÉTODO DE PAGO EN LA FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
		}	
		
		public bool eliminarMetodoFactura(string id){	
			string sentencia = "";
			bool respuesta = true;
			try{
				sentencia = @"UPDATE METODO_FACTURA set ESTATUS = '0' where id = "+id;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
				respuesta = true;			
			}catch(Exception ex){
				MessageBox.Show("ERROR AL ELIMINAR EL MÉTODO DE PAGO EN LA FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta; 
		}	
		
		
		
		public string validarFactura(string razon_social, int tipo ){
			string id = "0";
			string sentencia = "";
			
			if(tipo == 0){				
				sentencia = @"select * from DATOS_FACTURA where RAZON_SOCIAL = '"+razon_social+"'";
			}
				
			if(tipo == 1){
				sentencia = @"select DF.ID, DF.RAZON_SOCIAL as Dato from MAS_DATOS_FACTURACION MDF, DATOS_FACTURA DF WHERE ID_DATOS_F = DF.ID AND MDF.TIPO = 'CONTRIBUYENTE' and df.RAZON_SOCIAL = '"+razon_social+"'";
			}
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				id = base.leer["ID"].ToString();
			}
			base.conexion.Close();
			return id;
		}
		
		public void EliminarFactura1(string id_factura, string id_res, string id_usu){	
			string sentencia = "";
			bool respuesta = true;
			try{
				sentencia = @"UPDATE ORDEN_FACTURA SET ESTATUS = '-1' WHERE ID = "+id_factura;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL ELIMINAR LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			if(respuesta){			
					string[] datos = id_res.Split('-');
					string minuto = datos[0];
						for(int x = 0; x < datos.Length; x++){							
							sentencia = @"update RUTA_ESPECIAL set FACTURADO = '1', NUMERO_ANTI = '' where ID_RE = "+datos[x];
							base.getAbrirConexion(sentencia);
							base.comando.ExecuteNonQuery();
							base.conexion.Close();
							base.getAbrirConexion("update COBRO_ESPECIAL set FACTURA = '0', NUMERO_FACT='' where ID_RE="+datos[x]);
							base.comando.ExecuteNonQuery();	
							base.conexion.Close();
						}
			}
		}	
		
		public void EliminarFactura3(string id_factura, string id_usu){	
			string sentencia = "";
			try{
				sentencia = @"UPDATE ORDEN_FACTURA SET ESTATUS = '0' WHERE ID = "+id_factura;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL ELIMINAR LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void QuitaAvisoFactuta(string id_factura, int id_usuario){	
			string sentencia = "";
			try{
				sentencia = @"UPDATE ORDEN_FACTURA SET ESTATUS = '0' WHERE ID = "+id_factura;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();

				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('DELETE', 'Elimino el aviso de la factura: "+id_factura+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'ORDEN_FACTURA')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			
			}catch(Exception ex){
				MessageBox.Show("ERROR AL QUITAR EL AVISO DE LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}	
		
		public void EliminarFactura2(string id_re, string validaFactura){	
			string sentencia = "";
			bool respuesta = true;
			
			Int32 id_f = 0;
			string observaciones = "";
			try{
				sentencia = @"select ID_FACTURA, ofa.OBSERVACIONES from FACTURA_RUTA_ESPECIAL fre, ORDEN_FACTURA ofa where fre.ID_FACTURA = ofa.ID and ofa.ESTATUS != '0' and fre.ID_RE = "+id_re;
				base.getAbrirConexion(sentencia);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					id_f  = Convert.ToInt32(base.leer["ID_FACTURA"]);
					observaciones = base.leer["OBSERVACIONES"].ToString();
				}
				base.conexion.Close();		
			}catch(Exception ex){
				MessageBox.Show("ERROR AL OBTENER ID DE LA FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
				respuesta = false;			
			}
			
			if(respuesta){
				try{
				sentencia = @"UPDATE ORDEN_FACTURA SET ESTATUS = '-1', OBSERVACIONES = 'CANCELARON LA FACTURA,  "+observaciones+"' WHERE ID = "+id_f;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
				}catch(Exception ex){
					MessageBox.Show("ERROR AL ELIMINAR LA ORDEN DE FACTURA: "+ex.Message);					
					respuesta = false;
				}
			}			
			
			if(respuesta){
				List<string> ID_REs = new List<string>();				
				try{
					
					sentencia = @"select ID_RE from FACTURA_RUTA_ESPECIAL where ID_FACTURA = "+id_f;
					base.getAbrirConexion(sentencia);
					base.leer=base.comando.ExecuteReader();
					while(base.leer.Read())
					{
						ID_REs.Add(base.leer["ID_RE"].ToString());
					}
					base.conexion.Close();	
				}catch(Exception ex){
					MessageBox.Show("ERROR AL OBTENER ID DE LOS SERVICIO PARA PODER ELIMINAR LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					respuesta = false;
				}
					if(respuesta){
						for(int x = 0; x < ID_REs.Count; x++){		
								sentencia = @"update RUTA_ESPECIAL set FACTURADO = '"+validaFactura+"', NUMERO_ANTI = '' where ID_RE = "+ID_REs[x];														
							base.getAbrirConexion(sentencia);
							base.comando.ExecuteNonQuery();
							base.conexion.Close();							
							
							base.getAbrirConexion("update COBRO_ESPECIAL set FACTURA='0', NUMERO_FACT='' where ID_RE = "+ID_REs[x]);
							base.comando.ExecuteNonQuery();	
							base.conexion.Close();
						}
					}
			}
		}	
		
		public void insertaDatoFactura(string id_f, string id_res, string DATO, string usuario){	
			string sentencia = "";
			bool respuesta = true;
			try{
				sentencia = @"update ORDEN_FACTURA set FLUJO = '2', ESTATUS = '1', FACTURA= '"+DATO+"' where ID = "+id_f;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EL DATO DE LA ORDEN DE FACTURA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}
			if(respuesta){					
					string[] datos = id_res.Split('-');
					string minuto = datos[0];					
					for(int x = 0; x < datos.Length; x++){		
						
						base.getAbrirConexion("UPDATE RUTA_ESPECIAL SET FACTURADO='3', NUMERO_ANTI='"+DATO+"' WHERE ID_RE="+datos[x]);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						base.getAbrirConexion("update COBRO_ESPECIAL set FACTURA='1', NUMERO_FACT='"+DATO+"' where ID_RE="+datos[x]);
						base.comando.ExecuteNonQuery();	
						base.conexion.Close();
							
						base.getAbrirConexion("INSERT INTO AUDITA_COBRO_ESP VALUES ('"+id_f+"', 'FACTURA', '"+DATO+"', '"+usuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))");
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}					
			}
		}	
		
		#endregion
		
		///////////////////////////////////////////////////////  VALIDACION  ////////////////////////////////////////////////////////

		#region VALIDACIONES
		public bool validarAsignaciones(Int32 id_re){
			bool respuesta = false;
			string consulta = @"select o.* from RUTA_ESPECIAL re join Cliente c on c.ID = re.ID_C join RUTA r on r.IdSubEmpresa = c.ID 
								join OPERACION o on o.id_ruta = r.ID  where o.estatus = '1' and ID_RE = " +id_re;
				base.getAbrirConexion(consulta);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
					respuesta = true;				
				base.conexion.Close();			
			return respuesta;
		}
		
		public void cancelacionPunto(Int64 id_Operacion, Int64 id_Op, Int64 id_ruta, Int64 id_usuario, String Turno, String Fecha){
			base.getAbrirConexion("update OPERACION SET ESTATUS = '0' where id_operacion="+id_Operacion);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("insert into CANCELACION_PUNTO values ("+id_Op+", "+id_ruta+", "+id_usuario+", '"+Turno+"', '"+Fecha+"');");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		public bool validarConfirmacion(Int32 id_re){
			bool respuesta = false;
			
				base.getAbrirConexion("select CONF_CLIENTE FROM RUTA_ESPECIAL where CONF_CLIENTE is null and ID_RE = "+id_re);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read()){
					respuesta = true;
				}
				base.conexion.Close();
			
			return respuesta;
		}
		
		public bool validarCambios(Int32 id_re){
			bool respuesta = false;
			
				base.getAbrirConexion("select ID from COBRO_ESPECIAL where ID_RE = "+id_re);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					respuesta = true;
				}
				base.conexion.Close();
			
			return respuesta;
		}
		
		public bool validarImpresion(string id_re){
			bool respuesta = false;
			
				base.getAbrirConexion("select ID_RE FROM CONTROL_IMPRESION_CONTRATOS where ID_RE = "+id_re);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read()){
					respuesta = true;
				}
				base.conexion.Close();			
			return respuesta;
		}
		#endregion
		
		#region OBTENER ID DE SALIDA
		public List<Interfaz.Libro_Nuevo.Dato.datosViajes> obtenerIdsSalidas()
		{
			List<Interfaz.Libro_Nuevo.Dato.datosViajes> datos = new List<Interfaz.Libro_Nuevo.Dato.datosViajes>();
			
			base.getAbrirConexion("select R.ID, RE.ID_RE, RE.DESTINO from RUTA R, Cliente C, RUTA_ESPECIAL RE where R.IdSubEmpresa=C.ID and C.ID=RE.ID_C AND R.Sentido='SALIDA' and FECHA_SALIDA>='2013/02/12' and R.PAGO='0' ORDER BY C.ID, R.ID ");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Libro_Nuevo.Dato.datosViajes dat = new Interfaz.Libro_Nuevo.Dato.datosViajes();
				
				dat.dato1 	 =base.leer["ID"].ToString();
				dat.dato2	 =base.leer["ID_RE"].ToString();
				dat.dato3	 =base.leer["DESTINO"].ToString();
				datos.Add(dat);
			}
			base.conexion.Close();
			
			return (datos.Count>0)?datos:null;
		}
		#endregion	
		
		#region OBTENER ID DE SALIDA FULL
		public List<Interfaz.Libro_Nuevo.Dato.datosViajes> obtenerIdsSalidasFull()
		{
			List<Interfaz.Libro_Nuevo.Dato.datosViajes> datos = new List<Interfaz.Libro_Nuevo.Dato.datosViajes>();
			
			base.getAbrirConexion("select R.ID, RE.ID_RE, RE.DESTINO from RUTA R, Cliente C, RUTA_ESPECIAL RE where R.IdSubEmpresa=C.ID and C.ID=RE.ID_C AND R.Sentido='SALIDA' and FECHA_SALIDA>='2013/02/12'  ORDER BY C.ID");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Libro_Nuevo.Dato.datosViajes dat = new Interfaz.Libro_Nuevo.Dato.datosViajes();
				
				dat.dato1 	 =base.leer["ID"].ToString();
				dat.dato2	 =base.leer["ID_RE"].ToString();
				dat.dato3	 =base.leer["DESTINO"].ToString();
				datos.Add(dat);
			}
			base.conexion.Close();
			
			return (datos.Count>0)?datos:null;
		}
		#endregion			
		
		#region CACELACIÓN DE RUTA (VEHICULO)
		public Boolean validaCancelados(Int64 id_r1, Int64 id_r2, string MOTIVO)
		{
			bool respuesta = true;
			try{
				base.getAbrirConexion("update RUTA set PAGO = '1', DESCRIPCION = '"+MOTIVO+"' where ID = "+id_r1);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				base.getAbrirConexion("update RUTA set PAGO = '1', DESCRIPCION = '"+MOTIVO+"' where ID = "+id_r2);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al cancelar el vehiculo: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}
			return respuesta;
		}
		#endregion	
		
		/////////////////////////////////////////////////////////  ENCUESTA  ////////////////////////////////////////////////////////
		
		#region VALIDA EXISTE ENCUSTA
		public bool validarExisteEncuesta(Int32 id_re){
			bool respuesta = false;
			base.getAbrirConexion("select * from ENCUESTA where ID_RE = "+id_re);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				respuesta = true;
			}
			base.conexion.Close();			
			return respuesta;
		}
		
		public bool validarExisteEncuestaVenta(Int32 id_re){
			bool respuesta = false;
			base.getAbrirConexion("select * from ENCUESTA_VENTAS where ESTATUS = 'Activo' and ID_RE = "+id_re+" ORDER BY ID DESC");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
				respuesta = true;			
			base.conexion.Close();			
			return respuesta;
		}
		#endregion		
		
		#region INSERTA ENCUESTA
		public void guardaEncuestaVenta(Int32 id_re, Int32 id_usu, string operador1, string operadorComentario1, string operador2, string operadorComentario2, string operador3, string operadorComentario3, string unidad1, 
		                                string unidadComentario1, string unidad2, string unidadComentario2, string unidad3, string unidadComentario3, string atencion1, string atencionComentario1, string atencion2, 
		                                string atencionComentario2, string atencion3, string atencionComentario3, string precio1, string precioComentario1, string precio2, string precioComentario2, string precio3, 
		                                string precioComentario3, string servicio1, string servicioComentario1, string servicio2, string servicioComentario2, string servicio3,	string servicioComentario3, string calificacion, 
		                                string seguimientoPagoOperador, string seguimientoCuanto, string seguimientoViajeProgramado, string seguimientoViajeDonde, string seguimientoViajeMes, string seguimientoVolveria, String comentario, string genteAjena)
		{
			try{
				String consulta = "EXECUTE guarda_encuesta_post "+id_re+",'"+id_usu+"', '"+operador1+"', '"+operadorComentario1+"', '"+operador2+"', '"+operadorComentario2+"', '"+operador3
				                      +"', '"+operadorComentario3+"', '"+unidad1+"', '"+unidadComentario1+"', '"+unidad2+"', '"+unidadComentario2+"', '"+unidad3+"', '"+unidadComentario3
				                      +"', '"+atencion1+"', '"+atencionComentario1+"', '"+atencion2+"', '"+atencionComentario2+"', '"+atencion3+"', '"+atencionComentario3+"', '"+precio1
				                      +"', '"+precioComentario1+"', '"+precio2+"', '"+precioComentario2+"', '"+precio3+"', '"+precioComentario3+"', '"+servicio1+"', '"+servicioComentario1
				                      +"', '"+servicio2+"', '"+servicioComentario2+"', '"+servicio3+"', '"+servicioComentario3+"', '"+calificacion+"', '"+seguimientoPagoOperador+"', '"+seguimientoCuanto
				                      +"', '"+seguimientoViajeProgramado+"', '"+seguimientoViajeDonde+"', '"+seguimientoViajeMes+"', '"+seguimientoVolveria+"', '"+comentario+"','"+genteAjena+"'";
				
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al insertar la encuesta: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(base.conexion != null)
					base.conexion.Close();	
			}
		}		
		#endregion		
		
		///////////////////////////////////////////////////////  COBRO ESPECIALES  ////////////////////////////////////////////////////////
		
		#region COBRO DE VEHICULOS Y SERVICIOS
		public bool pagaServicio(Int64 id_re, Int32 id_usu){
			bool respuesta = true;
			string consulta = "update ruta_especial set PAGADO = '1' where ID_RE = "+id_re;
			try{
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al pagar el SERVICIO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;				
			}
			
			if(respuesta){
				consulta = "update COBRO_ESPECIAL set PAGO = '1' where ID_RE = '"+id_re+"'";
				try{
					base.getAbrirConexion(consulta);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al pagar los VEHICULOS: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					respuesta = false;				
				}
			}
			
			if(respuesta == true){
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL VALUES('PAGA SERVICIO', 'ID_RE :"+id_re+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usu+", 'RUTA_ESPECIAL')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			return respuesta;
		}
		
		public bool IncibrableServicio(Int64 id_re, string recuperado, string efectivo, string deposito, string comentario, Int32 id_u, string perdido){
			bool respuesta = true;
			String sentencia = "";
			try{
				sentencia = "insert into PAGO_INCOBRO values ('"+id_re+"', '"+recuperado+"', '"+efectivo+"', '"+deposito+"', '"+comentario+"', '"+id_u+"', (SELECT CONVERT (varchar, SYSDATETIME())), '"+perdido+"')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();				
				base.conexion.Close();
				respuesta = true;
			}catch(Exception ex){
				respuesta = false;				
				MessageBox.Show("Error en insert PAGO_INCOBRO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			if(respuesta){
				sentencia = "update ruta_especial set INCOBRABLE = '1',  PAGADO = '1' where ID_RE = "+id_re;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();			
				base.conexion.Close();
			}
			return respuesta;
		}
		#endregion
		
		#region MODIFICACIONES
		public bool modificarTipoCobroVehiculo(Int64 id, string tipo, Int32 id_usu){
			bool respuesta = true;
			String sentencia = "";
			try{
				sentencia = "update COBRO_ESPECIAL set TIPO = '"+tipo+"' where ID = "+id;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();				
				base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;				
				MessageBox.Show("Error al modificar en COBRO_ESPECIAL: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return respuesta;
		}
		#endregion		
	}
}
