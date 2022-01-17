using System;
using System.Drawing;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace Transportes_LAR.Conexion_Servidor.Desapacho
{
	public class SQL_Operaciones:Conexion_Servidor.SQL_Conexion
	{
		List<String> ListaSubNombres = new List<String>();
		List<String> ListaRuta = new List<String>();
		List<String> listaIds = new List<String>();
		
		public SQL_Operaciones():base()
		{
			
		}
		
		#region LOGICA DE DATOS DE OPERACIONES (guardado etc.)
		public void almacenarHistorialOpe(int id, string status, string descrip, string fecha, string turno, int id_usuario)
		{
			Int64 id_h=0;
			
			id_h = estatusExistente(id, status, fecha, turno);
			
			/*if(id_h==0)
			{*/
				String consulta = "execute Historial_Operador_Operaciones2 "+id+",'"+status+"','"+descrip+"', '"+fecha+"', '"+turno+"', '"+id_usuario+"'";
				
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				base.getAbrirConexion("update ASIGNACIONUNIDAD set Estatus='"+status+"' where ID_OPERADOR="+id);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			/*}
			else
			{
				DialogResult rs2 = MessageBox.Show("Ya se ha registrado "+status+". ¿Desea modificar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs2)
				{
					base.getAbrirConexion("execute Historial_Operador_Operaciones2 "+id+",'"+status+"','"+descrip+"', '"+fecha+"', '"+turno+"', '"+id_usuario+"'");
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					base.getAbrirConexion("update ASIGNACIONUNIDAD set Estatus='"+status+"' where ID_OPERADOR="+id);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
			}*/
		}
		
		public void almacenarHistorialOpe2(Int64 id, string status, string descrip, string fecha, string turno, int id_usuario)
		{
			Int64 id_h=0;
			
			id_h = estatusExistente(id, status, fecha, turno);
			
			String conss = "execute Historial_Operador_Operaciones2 "+id+",'"+status+"','"+descrip+"', '"+fecha+"', '"+turno+"', '"+id_usuario+"'";
			base.getAbrirConexion(conss);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public Int64 estatusExistente(long id, string status, string fecha, string turno)
		{
			Int64 respuesta=0;
			
			base.getAbrirConexion("select ID_HO from HISTORIALOPERADOR where ID_O="+id+" and FECHA='"+fecha+"' and ESTATUS='"+status+"' and TURNO='"+turno+"'");
			
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				respuesta=Convert.ToInt64(base.leer["ID_HO"]);
			}
			base.conexion.Close();
			
			return respuesta;
		}
		
		public void almacenarHistorialVeh(int idVehiculo, string status, string descrip, string fecha, string turno, int id_usuario)
		{
			base.getAbrirConexion("execute Historial_Vehiculo_Operaciones2 "+idVehiculo+",'"+fecha+"','Taller', '"+descrip+"','"+turno+"','"+id_usuario+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("update ASIGNACIONUNIDAD set Estatus='"+status+"' where ID_UNIDAD="+idVehiculo);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		#region GUARDADO DE CONFIRMACION DE VIAJE
		public bool almacenarViaje(Int64 idoperacion, String idruta, Int64 idusuario, Int64 idoperador, String confirmada, String llegada, int tipoviaje, Int64 IDvehiculo, String tipoVehiculo, String turno, int pasajeros, String conf2, String fecha, String empresa)
		{
			bool respuesta=true;
		
			if(getidVehiculo(idoperador)!=0)
			{
				IDvehiculo=getidVehiculo(idoperador);
			}
			
			
			if(Repetido(idruta, fecha, turno, empresa))
			{
				if(tipoviaje==20)
				{	
					base.getAbrirConexion("execute ALMACENAR_VIAJE "+idoperacion+", "+idruta+", "+idusuario+", "+idoperador+", '"+confirmada+"', '"+llegada+"', "+tipoviaje+", "+IDvehiculo+", '"+tipoVehiculo+"', '"+turno+"', "+pasajeros+", '"+conf2+"', '"+fecha+"'");
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					
					NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
			
					String sMacAddress = string.Empty;
					foreach (NetworkInterface adapter in nics)
					{
					    if (sMacAddress == String.Empty)// only return MAC Address from first card  
					    {
					        IPInterfaceProperties properties = adapter.GetIPProperties();
					        sMacAddress = adapter.GetPhysicalAddress().ToString();
					    }
					}
					
					base.getAbrirConexion("INSERT INTO MAC_OPERACION VALUES ((select MAX(id_operacion) ID from OPERACION), '"+sMacAddress+"')");
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
				else
				{
					try
					{
						base.getAbrirConexion("execute ALMACENAR_VIAJE2 "+idoperacion+", "+idruta+", "+idusuario+", "+idoperador+", '"+confirmada+"', '"+llegada+"', "+tipoviaje+", "+IDvehiculo+", '"+tipoVehiculo+"', '"+turno+"', "+pasajeros+", '"+conf2+"', '"+fecha+"'");
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
						
						NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
			
						String sMacAddress = string.Empty;
						foreach (NetworkInterface adapter in nics)
						{
						    if (sMacAddress == String.Empty)// only return MAC Address from first card  
						    {
						        IPInterfaceProperties properties = adapter.GetIPProperties();
						        sMacAddress = adapter.GetPhysicalAddress().ToString();
						    }
						}
						
						base.getAbrirConexion("INSERT INTO MAC_OPERACION VALUES ((select MAX(id_operacion) ID from OPERACION), '"+sMacAddress+"')");
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
					catch (Exception)
					{
						
					}
				}
				
				if(empresa=="Especiales")
				{
					/*base.getAbrirConexion("execute ");
					base.comando.ExecuteNonQuery();
					base.conexion.Close();*/
				}
			}
			else
			{
				MessageBox.Show("Error de duplicidad. Alguien ya asigno esta ruta");
				respuesta=false;
			}
			
			return respuesta;
		}
		
		public bool Repetido(String id_ruta, String fecha, String turno, String empresa)
		{
			bool respuesta = true;
			
			String consulta;
			
			if(empresa=="ESPECIALES")
				consulta="select * from OPERACION where id_ruta='"+id_ruta+"' and estatus='1'";
			else 
				consulta="select * from OPERACION where id_ruta='"+id_ruta+"' and fecha='"+fecha+"' and turno='"+turno+"' and estatus='1'";
			
			base.getAbrirConexion(consulta);
			
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				respuesta=false;
			}
			
			base.conexion.Close();
			
			return respuesta;
		}
		
		Int64 getidVehiculo(Int64 ID_V)
		{
			Int64 ID = 0;
			String consulta="select V.ID from ASIGNACIONUNIDAD A, VEHICULO V where A.ID_UNIDAD=V.ID and A.ID_OPERADOR="+ID_V;
			
			base.getAbrirConexion(consulta);
			
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				ID=Convert.ToInt64(base.leer["ID"]);;
			}
			
			base.conexion.Close();
			
			return ID;
		}
		#endregion
		
		public void cambioOperadorViaje(int idOperadorCambio, int idVehiculo, String vehiculo, int idOperadorAnterior, int idViaje)
		{
			base.getAbrirConexion("update OPERACION_OPERADOR set id_operador="+idOperadorCambio+", id_vehiculo="+idVehiculo+", vehiculo='"+vehiculo+"' where id_operador="+idOperadorAnterior+" and id_operacion="+idViaje);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void modificarLlegada(Int64 idOperacion, String llegada, Int64 pas)
		{
			try
			{
				base.getAbrirConexion("update OPERACION set llegada='"+llegada+"', pasajeros="+pas+" where id_operacion="+idOperacion);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			catch(Exception)
			{
				//MessageBox.Show("Error");
			}
		}
		#endregion
		
		#region OBTENER_RUTAS_ENTRADA
		public List<Interfaz.Operaciones.Dato.Ruta> getListRutaEnt(String turno, String nom, String fecha)
		{
			List<Interfaz.Operaciones.Dato.Ruta> listRutas=new List<Transportes_LAR.Interfaz.Operaciones.Dato.Ruta>();
			if(nom=="Todos")
			{
				base.getAbrirConexion("select C.DATO, R.ID, C.SubNombre, R.Nombre, R.HoraInicio, R.Sentido, R.Dia, R.extra from Cliente C, RUTA R where C.ID=R.IdSubEmpresa and R.Sentido='Entrada'  and extra='0' group by C.DATO, R.Sentido, C.SubNombre, R.Nombre, R.HoraInicio, R.ID, R.Dia, R.extra order by R.HoraInicio");
			}
			else if(nom!="ESPECIALES")
			{
				base.getAbrirConexion("select C.DATO, R.ID, C.SubNombre, R.Nombre, R.HoraInicio, R.Sentido, R.Dia, R.extra from Cliente C, RUTA R where C.ID=R.IdSubEmpresa and R.Turno='"+turno+"' and R.Sentido='Entrada' and (R.TIPO='NRM' OR R.TIPO='DIF' OR R.TIPO='RI' OR R.TIPO='VL' OR ((R.TIPO='APO' or R.TIPO='DOM' or R.TIPO='EXT') and R.extra='"+fecha+"')) and C.ID_ORDEN in (select ID from ORDEN_EMPRESAS where Nombre='"+nom+"') group by C.DATO, R.Sentido, C.SubNombre, R.Nombre, R.HoraInicio, R.ID, R.Dia, R.extra order by R.HoraInicio");
			}
			else if(nom=="ESPECIALES")
			{
				base.getAbrirConexion("select C.DATO, R.ID, C.SubNombre, R.Nombre, RE.H_PLANTON HoraInicio, R.Sentido, R.Dia, R.extra, C.ID ID_E from RUTA_ESPECIAL RE, Cliente C, RUTA R where RE.ID_C=C.ID and C.ID=R.IdSubEmpresa and R.TIPO='ESP' and R.Sentido='Entrada' and RE.estado!='Cancelado' and C.SubNombre='Especiales' and RE.FECHA_SALIDA='"+fecha+"' group by C.DATO, R.Sentido, C.SubNombre, R.Nombre, RE.H_PLANTON, R.ID, R.Dia, R.extra, C.ID order by RE.H_PLANTON");
			}
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Ruta ruta=new Transportes_LAR.Interfaz.Operaciones.Dato.Ruta();
				ruta.id_ruta	=base.leer["ID"].ToString();
				ruta.empresa	=base.leer["SubNombre"].ToString();
				ruta.nombre		=base.leer["Nombre"].ToString().ToUpper();
				ruta.hora		=base.leer["HoraInicio"].ToString();
				ruta.sentido	=base.leer["Sentido"].ToString();
				ruta.dia		=base.leer["Dia"].ToString();
				ruta.extra		=base.leer["extra"].ToString();
				ruta.ID_C		=((nom=="ESPECIALES")?base.leer["ID_E"].ToString():"0");
				ruta.DATO		=base.leer["DATO"].ToString();
				listRutas.Add(ruta);
			}
			base.conexion.Close();
			if(nom=="ESPECIALES")
			{
				String miFecha="";
				
				if((Convert.ToInt16(fecha.Substring(8,2))<28  &&  Convert.ToInt16(fecha.Substring(5,2))==2) || 
				   (Convert.ToInt16(fecha.Substring(8,2))<31  &&  (Convert.ToInt16(fecha.Substring(5,2))==1 || Convert.ToInt16(fecha.Substring(5,2))==3 || Convert.ToInt16(fecha.Substring(5,2))==5 || Convert.ToInt16(fecha.Substring(5,2))==7 || Convert.ToInt16(fecha.Substring(5,2))==8 || Convert.ToInt16(fecha.Substring(5,2))==10 || Convert.ToInt16(fecha.Substring(5,2))==12)) ||
				   (Convert.ToInt16(fecha.Substring(8,2))<30  &&  (Convert.ToInt16(fecha.Substring(5,2))==4 || Convert.ToInt16(fecha.Substring(5,2))==6 || Convert.ToInt16(fecha.Substring(5,2))==9 || Convert.ToInt16(fecha.Substring(5,2))==11) ))
				{
					String diaExtra = (Convert.ToInt16(fecha.Substring(8,2))+1).ToString();
					
					miFecha = fecha.Substring(0,7)+"-"+diaExtra;
				}
				else
				{
					if((Convert.ToInt16(fecha.Substring(5,2))+1)==12)
					{
						String Mes  = (Convert.ToInt16(fecha.Substring(5,2))+1).ToString();
						String anio = fecha.Substring(0,5);
					
						miFecha = anio+Mes+"-01";
					}
					else
					{
						String Mes  = "01";
						String anio = (Convert.ToInt16(fecha.Substring(0,4))+1).ToString();
						
						miFecha = anio+"-"+Mes+"-01";
					}
				}
				
				//MessageBox.Show("Dia 2 especiales: "+ miFecha+" - "+fecha);
				base.getAbrirConexion("select C.DATO, R.ID, C.SubNombre, R.Nombre, RE.H_PLANTON HoraInicio, R.Sentido, R.Dia, R.extra, C.ID ID_E from RUTA_ESPECIAL RE, Cliente C, RUTA R where RE.ID_C=C.ID and C.ID=R.IdSubEmpresa and R.Sentido='Entrada' and RE.estado!='Cancelado' and C.SubNombre='Especiales' and RE.FECHA_SALIDA='"+miFecha+"'  and R.HoraInicio<'04:30' group by C.DATO, R.Sentido, C.SubNombre, R.Nombre, RE.H_PLANTON, R.ID, R.Dia, R.extra, C.ID order by RE.H_PLANTON");
				
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
				{
					Interfaz.Operaciones.Dato.Ruta ruta=new Transportes_LAR.Interfaz.Operaciones.Dato.Ruta();
					ruta.id_ruta	=base.leer["ID"].ToString();
					ruta.empresa	=base.leer["SubNombre"].ToString();
					ruta.nombre		=base.leer["Nombre"].ToString().ToUpper();
					ruta.hora		=base.leer["HoraInicio"].ToString();
					ruta.sentido	=base.leer["Sentido"].ToString();
					ruta.dia		=base.leer["Dia"].ToString();
					ruta.extra		=base.leer["extra"].ToString();
					ruta.ID_C		=((nom=="ESPECIALES")?base.leer["ID_E"].ToString():"0");
					ruta.DATO		=base.leer["DATO"].ToString();
					listRutas.Add(ruta);
				}
				base.conexion.Close();
			}
			
			return (listRutas.Count>0)?listRutas:null;
		}
		#endregion
		
		#region OBTENER_RUTAS_SALIDA
		public List<Interfaz.Operaciones.Dato.Ruta> getListRutaSal(String turno, String nom, String fecha)
		{
			List<Interfaz.Operaciones.Dato.Ruta> listRutas=new List<Transportes_LAR.Interfaz.Operaciones.Dato.Ruta>();
			
			if(nom=="Todos")
			{
				base.getAbrirConexion("select C.DATO, R.ID, C.SubNombre, R.Nombre, R.HoraInicio, R.Sentido, R.Dia, R.extra from Cliente C, RUTA R where C.ID=R.IdSubEmpresa and R.Sentido='Salida'  and extra='0' group by C.DATO, R.Sentido, C.SubNombre, R.Nombre, R.HoraInicio, R.ID, R.Dia, R.extra order by R.HoraInicio");
			}
			else if(nom!="ESPECIALES")
			{
				base.getAbrirConexion("select C.DATO, R.ID, C.SubNombre, R.Nombre, R.HoraInicio, R.Sentido, R.Dia, R.extra from Cliente C, RUTA R where C.ID=R.IdSubEmpresa and R.Turno='"+turno+"' and R.Sentido='Salida' and (R.TIPO='NRM' OR R.TIPO='DIF' OR R.TIPO='RI' OR R.TIPO='VL' OR ((R.TIPO='APO' or R.TIPO='DOM' or R.TIPO='EXT') and R.extra='"+fecha+"')) and C.ID_ORDEN in (select ID from ORDEN_EMPRESAS where Nombre='"+nom+"') group by C.DATO, R.Sentido, C.SubNombre, R.Nombre, R.HoraInicio, R.ID, R.Dia, R.extra order by R.HoraInicio");
			}
			else if(nom=="ESPECIALES")
			{
				base.getAbrirConexion("select C.DATO, R.ID, C.SubNombre, R.Nombre, RE.H_PLANTON HoraInicio, R.Sentido, R.Dia, R.extra, C.ID ID_E from RUTA_ESPECIAL RE, Cliente C, RUTA R where RE.ID_C=C.ID and C.ID=R.IdSubEmpresa and R.TIPO='ESP' and R.Sentido='Salida' and C.SubNombre='Especiales' and RE.estado!='Cancelado' and RE.FECHA_SALIDA='"+fecha+"' group by C.DATO, R.Sentido, C.SubNombre, R.Nombre, RE.H_PLANTON, R.ID, R.Dia, R.extra, C.ID order by RE.H_PLANTON");
			}
			
			
			
			//and RE.FECHA_SALIDA>=(SELECT CONVERT (date, SYSDATETIME()))
			//base.getAbrirConexion("select R.ID, C.SubNombre, R.Nombre, R.HoraInicio, R.Sentido from Cliente C, RUTA R where C.ID=R.IdSubEmpresa and R.Turno='Mañana' and R.Sentido='Entrada' and C.SubNombre='jabil'  group by R.Sentido, C.SubNombre, R.Nombre, R.HoraInicio, R.ID");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Ruta ruta=new Transportes_LAR.Interfaz.Operaciones.Dato.Ruta();
				ruta.id_ruta	=base.leer["ID"].ToString();
				ruta.empresa	=base.leer["SubNombre"].ToString();
				ruta.nombre		=base.leer["Nombre"].ToString().ToUpper();
				ruta.hora		=base.leer["HoraInicio"].ToString();
				ruta.sentido	=base.leer["Sentido"].ToString();
				ruta.dia		=base.leer["Dia"].ToString();
				ruta.extra		=base.leer["extra"].ToString();
				ruta.ID_C		=((nom=="ESPECIALES")?base.leer["ID_E"].ToString():"0");
				ruta.DATO		=base.leer["DATO"].ToString();
				listRutas.Add(ruta);
			}
			base.conexion.Close();
			
			return (listRutas.Count>0)?listRutas:null;
		}
		#endregion
		
		#region OBTENER NOMBRES DE SUBEMPRESAS
		public List<String> getSubEmpresas(String consulta)
		{
			//select SubNombre from cliente where subnombre in (select C.SubNombre from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and R.Turno='Mañana' group by C.SubNombre) ORDER BY orden
			//base.getAbrirConexion("select SubNombre from cliente where subnombre in (select C.SubNombre from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and R.Turno='"+turno+"' group by C.SubNombre) ORDER BY orden");
			//base.getAbrirConexion("select SubNombre from cliente where subnombre in (select C.SubNombre from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and R.Turno='"+turno+"' and R.ID not in (select ID from Cliente where SubNombre='Especiales') group by C.SubNombre) ORDER BY orden ");
			//base.getAbrirConexion("SELECT SubNombre FROM Cliente where ID not in (select ID from Cliente where SubNombre='Especiales') ORDER BY orden");
			
			base.getAbrirConexion(consulta);
			//base.getAbrirConexion("select SubNombre from cliente where subnombre in (select C.SubNombre from RUTA R, Cliente C where C.ID not in (select ID from Cliente where SubNombre='Especiales') and R.IdSubEmpresa=C.ID and R.Turno='"+turno+"' group by C.SubNombre) ORDER BY orden");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				ListaSubNombres.Add(base.leer["NOMBRE"].ToString());
			}
			base.conexion.Close();
			return (ListaSubNombres.Count>0)?ListaSubNombres:null;
		}
		#endregion
		
		#region OBTENER EMPRESAS PARA ORDEN
		public List<Interfaz.Operaciones.Dato.OrdenEmpresas> getEmpOrden(String CONSULTA)
		{
			List<Interfaz.Operaciones.Dato.OrdenEmpresas> listaOrdenEmp = new List<Transportes_LAR.Interfaz.Operaciones.Dato.OrdenEmpresas>();
			
			base.getAbrirConexion(CONSULTA);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.OrdenEmpresas empresas = new Transportes_LAR.Interfaz.Operaciones.Dato.OrdenEmpresas();
				
				empresas.id_e 		= base.leer["ID"].ToString();
				empresas.nombre 	= base.leer["NOMBRE"].ToString();
				empresas.orden 		= base.leer["NUMERO"].ToString();
				empresas.nomenc 	= base.leer["NOMENCLATURA"].ToString();
				
				listaOrdenEmp.Add(empresas);
			}
			base.conexion.Close();
			return (listaOrdenEmp.Count>0)?listaOrdenEmp:null;
		}
		#endregion
		
		#region GUARDAR NUEVO ORDEN EMPRESAS
		public void modificarOrden(int id_e, int numero, string nom)
		{
			
			base.getAbrirConexion("update ORDEN_EMPRESAS set NUMERO="+numero+", NOMENCLATURA='"+nom+"' where ID="+id_e);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region Guia Ruta Operadores
		public List<String> getRutaOp(int idOp)
		{
			base.getAbrirConexion("select C.Empresa, R.Nombre from Cliente C, RUTA R, OPERADOR OP, OPERACION O, OPERACION_OPERADOR OO where C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and OO.id_operador=OP.ID and OO.id_operacion=O.id_operacion  and OP.ID="+idOp+" and C.Empresa!='Especiales' group by C.Empresa, R.Nombre ");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				ListaRuta.Add(base.leer["RUTA"].ToString());
			}
			base.conexion.Close();
			return (ListaRuta.Count>0)?ListaRuta:null;
		}
		#endregion
		
		#region GUARDIAS
		public void almacenarGuardias(int ID_U, int ID_OPERADOR, int ID_SUBEMPRESA, String DIA, String TURNO, String TIPO, String status)
		{
			base.getAbrirConexion("execute historial_guardias "+ID_U+","+ ID_OPERADOR+","+ID_SUBEMPRESA+",'"+DIA+"','"+TURNO+"','"+TIPO+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("update ASIGNACIONUNIDAD set Estatus='"+status+"' where ID_OPERADOR="+ID_OPERADOR);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		#region GET ID DE GUARDIA
		public int getIDGuardia()
		{
			int respuesta=0;
			base.getAbrirConexion("select MAX(ID) ID from GUARDIA");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				respuesta=Convert.ToInt16(base.leer["ID"]);
			}
			base.conexion.Close();
			return respuesta;
		}
		#endregion
		
		#region GUARDIA CON VIAJE
		public void viajeGuardia(int id_guardia)
		{
			base.getAbrirConexion("update GUARDIA set TIPO='1' where ID="+id_guardia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region CAMBIO GUARDIA
		public void cambiarGuardia(int idOH, int idOP)
		{
			base.getAbrirConexion("update GUARDIA set  ID_O="+idOP+", tipo='0'  where ID="+idOH);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region CANCELAR GUARDIA
		public void cancelarGuardia(int id_guardia, int id_operador)
		{
			base.getAbrirConexion("delete from GUARDIA where ID="+id_guardia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("update ASIGNACIONUNIDAD set estatus='A' where ID_OPERADOR="+id_operador);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region  GET GUARDIAS
		public List<String> getGuardia(String consulta)
		{
			List<String> datos = new List<String>();
			try
			{
				base.getAbrirConexion(consulta);
			    base.leer = base.comando.ExecuteReader();
			    if(base.leer.Read())
			    {
			    	datos.Add(leer["ID_G"].ToString());
			    	datos.Add(leer["Alias"].ToString());
			    	datos.Add(leer["ID_O"].ToString());
			    }
			}
			catch(Exception)
			{
				datos.Clear();
			}
		    
		    conexion.Close();
		    return datos;
		}
		#endregion
		
		#endregion
		
		#region GUARDADO DE CUPOS BOTON ESPECIAL
		public void modificarLlegada2(Int64 idOperacion, String llegada, Int64 pas)
		{
			try
			{
				base.getAbrirConexion("execute AGREGA_CUPOS "+idOperacion+", '"+llegada+"', "+pas+"");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				base.getAbrirConexion("update OPERACION set llegada='"+llegada+"', pasajeros="+pas+" where id_operacion="+idOperacion);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			catch(Exception)
			{
				//MessageBox.Show("Error");
			}
		}
		#endregion
		
		#region GUARDADO ESTATUS
		public bool modifica=true;
		public void guardaEstatus(Int64 ID_OPERADOR, String ESTATUS, String DIA, String Turno, int viajes)
		{
			bool avanza = true;
			
			base.getAbrirConexion("select ESTATUS from CARDEX where ID_OPERADOR="+ID_OPERADOR+" and DIA='"+DIA+"' and TURNO='"+Turno+"'");
			
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				avanza=false;
			}
			base.conexion.Close();
			
			if(avanza)
			{
				base.getAbrirConexion("INSERT INTO CARDEX VALUES ("+ID_OPERADOR+", '"+ESTATUS+"', '"+DIA+"', '"+Turno+"', '"+viajes+"');");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			else
			{
				/*if(modifica)
				{
					DialogResult rs2 = MessageBox.Show("Ya estan registrados los estatus para cardex. \n de este turno ¿Desea cambiarlos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs2)
					{*/
						base.getAbrirConexion("update cardex set ESTATUS='"+ESTATUS+"', VIAJES='"+viajes+"' where id_operador='"+ID_OPERADOR+"' and dia='"+DIA+"' and turno='"+Turno+"'");
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					/*}
					modifica=false;
				}
				else
				{
					base.getAbrirConexion("update cardex set ESTATUS='"+ESTATUS+"' where id_operador='"+ID_OPERADOR+"' and dia='"+DIA+"' and turno='"+Turno+"'");
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}*/
			}
		}
		#endregion
		
		#region GET ID MAX DE TABLA OPERACIONES
		public Int64 getIdOperacionMax()
		{
			 Int64 ID=0;
			 try
			 {
				 base.getAbrirConexion("select MAX(id_operacion) id from OPERACION");
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			        ID=Convert.ToInt64(leer["id"].ToString());
			     }
			 }
			 catch(Exception)
			 {
			 	ID=0;
			 }
		    
		     conexion.Close();
		     return ID;
		}
		#endregion
		
		#region DATOS DE COMENTARIOS
		public List<String> getComentario(string fecha, string turno)
		{
			List<String> datos = new List<String>();
			 try
			 {
				 base.getAbrirConexion(" select U.nombre, N.fecha, N.comentario from USUARIO U, NOTA N where U.id_usuario=N.id_u and fecha='"+fecha+"' and turno='"+turno+"'");
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			     	datos.Add(leer["nombre"].ToString());
			     	datos.Add(leer["fecha"].ToString());
			     	datos.Add(leer["comentario"].ToString());
			     }
			 }
			 catch(Exception)
			 {
			 	datos.Clear();
			 }
		    
		     conexion.Close();
		     return datos;
		}
		
		
		
		public void setComentario(int id_usuario, String comentario, string turno, string fecha)
		{
			base.getAbrirConexion("execute insertar_comentarios "+id_usuario+", '"+comentario+"', '"+turno+"', '"+fecha+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void setMsjGral(String consulta)
		{
			base.getAbrirConexion(consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		public void updateRuta(String hora, Int64 idRuta)
		{
			String cons = "update RUTA set HoraInicio='"+hora+"' where ID="+idRuta;
			base.getAbrirConexion(cons);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		#region CANCELA VIAJE
		public void deleteAsignacion(Int64 idOp)
		{
			base.getAbrirConexion("delete from OPERACION_OPERADOR where id_operacion="+idOp);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("delete from OPERACION where id_operacion="+idOp);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void deleteAsignacion2(Int64 idOp, int id_usuario)
		{
			base.getAbrirConexion("execute AUDITA_GRAL 'OPERACION', "+idOp+", 'DESASIGNACION', "+id_usuario);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("update OPERACION SET ESTATUS='0' where id_operacion="+idOp);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		public int getIDEmpresa(String nom)
		{
			int respuesta=0;
			base.getAbrirConexion("select TOP 1 C.ID from Cliente C, ORDEN_EMPRESAS O where C.ID_ORDEN=O.ID and O.NOMBRE='"+nom+"'");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				respuesta=Convert.ToInt16(base.leer["ID"]);
			}
			base.conexion.Close();
			return respuesta;
		}
		
		#region OBTENER_RUTAS_SALIDA
		public List<Interfaz.Operaciones.Dato.Apoyo> getListApoyoRuta_Op(String turno, String dia)
		{
			List<Interfaz.Operaciones.Dato.Apoyo> listApoyo = new List<Transportes_LAR.Interfaz.Operaciones.Dato.Apoyo>();

			String Consulta = "select OE.NOMBRE, R.Nombre, R.Sentido, P.Alias from ORDEN_EMPRESAS OE, CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OP , OPERADOR P where C.ID_ORDEN=OE.ID AND C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and P.Estatus=1 and O.id_operacion=OP.id_operacion and OP.id_operador=P.ID and O.turno='"+turno+"'";
			
			//String Consulta = "select C.SubNombre, R.Nombre, R.Sentido, P.Alias, R.ID from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OP, OPERADOR P where C.SubNombre!='Especiales' and R.TIPO='NRM'  and P.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and P.Estatus=1 and O.id_operacion=OP.id_operacion and OP.id_operador=P.ID and O.turno='"+turno+"' order by C.SubNombre";
			
			base.getAbrirConexion(Consulta);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Apoyo apoyo = new Transportes_LAR.Interfaz.Operaciones.Dato.Apoyo();
				apoyo.Empresa	=base.leer["NOMBRE"].ToString();
				apoyo.Ruta		=base.leer["Nombre"].ToString().ToUpper();
				apoyo.Sentido	=base.leer["Sentido"].ToString();
				apoyo.Operador	=base.leer["Alias"].ToString();
				listApoyo.Add(apoyo);
			}
			base.conexion.Close();
			return (listApoyo.Count>0)?listApoyo:null;
		}
		#endregion
		
		#region GET DATOS ESPECIALES
		public Interfaz.Operaciones.Dato.Especial getDatosEspeciales(Int64 id_r)
		{
			Interfaz.Operaciones.Dato.Especial dEspcial = new Transportes_LAR.Interfaz.Operaciones.Dato.Especial();
			String cons = "select RE.OP_COBRA, RE.FACTURADO, RE.cantidad_usuarios, CS.Nombre, RE.FECHA_REGRESO, R.HORA_FIN, U.usuario, RE.FECHA, RE.HORA, RE.DESTINO, RE.H_PLANTON, RE.CANT_UNIDADES, RE.DOMICILIO, C.Estado COL, RE.RESPONSABLE, RE.PRECIO, CS.Telefono, R.Kilometros, RE.CASETAS, RE.FACTURA, RE.OBSERVACIONES, C.Rumbo, RE.FECHA_SALIDA, RE.tipoVehiculo, RE.SALDO, RE.anticipo from CLIENTE C, ContactoServicio CS, RUTA R, RUTA_ESPECIAL RE, USUARIO U WHERE C.ID=CS.IdCliente AND C.ID=R.IdSubEmpresa AND C.ID=RE.ID_C AND RE.ID_U=U.id_usuario AND RE.ID_RE="+id_r;
			base.getAbrirConexion(cons);

			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				dEspcial.usuario		=base.leer["usuario"].ToString();
				dEspcial.fecha			=base.leer["FECHA"].ToString();
				dEspcial.hora			=base.leer["HORA"].ToString();
				dEspcial.destino		=base.leer["DESTINO"].ToString();
				dEspcial.planton		=base.leer["H_PLANTON"].ToString();
				dEspcial.unidades		=base.leer["CANT_UNIDADES"].ToString();
				dEspcial.domicilio		=base.leer["DOMICILIO"].ToString();
				dEspcial.colonia		=base.leer["COL"].ToString();
				dEspcial.responsable	=base.leer["RESPONSABLE"].ToString();
				dEspcial.precio			=((base.leer["FACTURADO"].ToString()!="0")?(Convert.ToDouble(base.leer["PRECIO"])*1.16).ToString():base.leer["PRECIO"].ToString());
				dEspcial.telefono		=base.leer["telefono"].ToString();
				dEspcial.kilometros		=base.leer["kilometros"].ToString();
				dEspcial.casetas		=base.leer["CASETAS"].ToString();
				dEspcial.factura		=base.leer["FACTURA"].ToString();
				dEspcial.observaciones	=base.leer["OBSERVACIONES"].ToString();
				dEspcial.cruces			=base.leer["Rumbo"].ToString();
				dEspcial.fechaViaje		=base.leer["FECHA_SALIDA"].ToString();
				
				dEspcial.cliente		=base.leer["Nombre"].ToString();
				dEspcial.FechRegreso	=base.leer["FECHA_REGRESO"].ToString();
				dEspcial.HoraRegreso	=base.leer["HORA_FIN"].ToString();
				dEspcial.tipoUnidad		=base.leer["tipoVehiculo"].ToString();
				
				dEspcial.anticipo		=base.leer["anticipo"].ToString();
				dEspcial.saldo			=base.leer["SALDO"].ToString();
				dEspcial.cantUsu		=base.leer["cantidad_usuarios"].ToString();
				dEspcial.opCobra		=base.leer["OP_COBRA"].ToString();
				
			}
			base.conexion.Close();
			return dEspcial;
		}
		#endregion
		
		#region GET RELACION RUTAS ESPECIALES
		public List<Interfaz.Operaciones.Dato.RutasEspecial> getListRutaEsp()
		{
			List<Interfaz.Operaciones.Dato.RutasEspecial> listRutaEsp=new List<Transportes_LAR.Interfaz.Operaciones.Dato.RutasEspecial>();
			
			base.getAbrirConexion("select CS.Nombre, RE.DOMICILIO, RE.DESTINO from RUTA_ESPECIAL RE, CLIENTE C, ContactoServicio CS where RE.ID_C=C.ID and C.ID=CS.IdCliente");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.RutasEspecial ruta = new Transportes_LAR.Interfaz.Operaciones.Dato.RutasEspecial();
				ruta.cliente	=base.leer["Nombre"].ToString();
				ruta.destino	=base.leer["DOMICILIO"].ToString();
				ruta.domicilio	=base.leer["DESTINO"].ToString();
		
				listRutaEsp.Add(ruta);
			}
			base.conexion.Close();
			return (listRutaEsp.Count>0)?listRutaEsp:null;
		}
		#endregion
		
		#region GET RUTAS ASIGNADAS
		public List<String> getIdEspAsig(String turno, String dia)
		{
			List<String> datos = new List<String>();
			 try
			 {
				 base.getAbrirConexion("SELECT id_ruta FROM OPERACION O, RUTA R, CLIENTE C WHERE O.id_ruta=R.ID AND C.ID=R.IdSubEmpresa and O.fecha='"+dia+"' and O.turno='"+turno+"' and O.estatus='1' and C.Empresa!='Especiales'");
			     base.leer = base.comando.ExecuteReader();
			     while(base.leer.Read())
			     {
			     	datos.Add(leer["id_ruta"].ToString());
			     }
			 }
			 catch(Exception)
			 {
			 	datos.Clear();
			 }
		    
		     conexion.Close(); 
		     return datos;
		}
				     
		public List<String> getIdEspAsigEsp(String dia)
		{
			List<String> datos = new List<String>();
			 try
			 {
				 base.getAbrirConexion("SELECT id_ruta FROM OPERACION O, RUTA R, CLIENTE C WHERE O.id_ruta=R.ID AND C.ID=R.IdSubEmpresa and O.fecha='"+dia+"' and O.estatus='1' and C.Empresa='Especiales'");
				 //MessageBox.Show("SELECT id_ruta FROM OPERACION O, RUTA R, CLIENTE C WHERE O.id_ruta=R.ID AND C.ID=R.IdSubEmpresa and O.fecha='"+dia+"' and C.Empresa='Especiales'");
				 
			     base.leer = base.comando.ExecuteReader();
			     while(base.leer.Read())
			     {
			     	datos.Add(leer["id_ruta"].ToString());
			     }
			 }
			 catch(Exception)
			 {
			 	datos.Clear();
			 }
		    
		     conexion.Close(); 
		     return datos;
		}
				
		public Interfaz.Operaciones.Dato.Busqueda getOperador(String id, String Turno, String fecha, String tipo)
		{
			Interfaz.Operaciones.Dato.Busqueda datos = new Transportes_LAR.Interfaz.Operaciones.Dato.Busqueda();
			try
			{
				if(tipo!="ESPECIALES")
					 base.getAbrirConexion("SELECT OP.pasajeros, O.Alias, OP.confirmada, OP.llegada, OP.id_operacion, O.ID, OO.id_vehiculo, OO.vehiculo FROM OPERACION OP, OPERACION_OPERADOR OO, OPERADOR O where OP.id_operacion=OO.id_operacion and OP.estatus='1' and OO.id_operador=O.ID and OP.fecha='"+fecha+"' and OP.turno='"+Turno+"' and OP.id_ruta="+id);
				else if(tipo=="ESPECIALES")
				 	base.getAbrirConexion("SELECT OP.pasajeros, O.Alias, OP.confirmada, OP.llegada, OP.id_operacion, O.ID, OO.id_vehiculo, OO.vehiculo FROM OPERACION OP, OPERACION_OPERADOR OO, OPERADOR O where OP.id_operacion=OO.id_operacion and OP.estatus='1' and OO.id_operador=O.ID and OP.fecha='"+fecha+"' and OP.id_ruta="+id);
				 	
			    base.leer = base.comando.ExecuteReader();
			    while(base.leer.Read())
			    {
			        datos.Cantidad 		=leer["pasajeros"].ToString();
			        datos.nomOperador	=leer["Alias"].ToString();
			        datos.confirmada	=leer["confirmada"].ToString();
			        datos.llegada		=leer["llegada"].ToString();
			        datos.id_operacion	=leer["id_operacion"].ToString();
			        datos.id_operador	=leer["ID"].ToString();
			        datos.id_vehiculo	=leer["id_vehiculo"].ToString();
			        datos.vehiculo		=leer["vehiculo"].ToString();
			    }
			}
			catch(Exception)
			{
			 	datos=null;
			}
		    
		     conexion.Close();
		     return datos;
		}
		
		/*public Interfaz.Operaciones.Dato.Busqueda getOperador(String id, String Turno, String fecha)
		{
			Interfaz.Operaciones.Dato.Busqueda datos = new Transportes_LAR.Interfaz.Operaciones.Dato.Busqueda();
			 //try
			 //{
			 //if(tipo!="Especiales")
				 base.getAbrirConexion("SELECT OP.pasajeros, O.Alias, OP.confirmada, OP.llegada, OP.id_operacion, O.ID, OO.id_vehiculo, OO.vehiculo FROM OPERACION OP, OPERACION_OPERADOR OO, OPERADOR O where OP.id_operacion=OO.id_operacion and OO.id_operador=O.ID and OP.fecha='"+fecha+"' and OP.turno='"+Turno+"' and OP.id_ruta="+id);
			// else if(tipo=="Especiales")
			 	//base.getAbrirConexion("SELECT OP.pasajeros, O.Alias, OP.confirmada, OP.llegada, OP.id_operacion, O.ID, OO.id_vehiculo, OO.vehiculo FROM OPERACION OP, OPERACION_OPERADOR OO, OPERADOR O where OP.id_operacion=OO.id_operacion and OO.id_operador=O.ID and OP.fecha='"+fecha+"' and OP.id_ruta="+id);
			 	
			     base.leer = base.comando.ExecuteReader();
			     while(base.leer.Read())
			     {
			        datos.Cantidad 		=leer["pasajeros"].ToString();
			        datos.nomOperador	=leer["Alias"].ToString();
			        datos.confirmada	=leer["confirmada"].ToString();
			        datos.llegada		=leer["llegada"].ToString();
			        datos.id_operacion	=leer["id_operacion"].ToString();
			        datos.id_operador	=leer["ID"].ToString();
			        datos.id_vehiculo	=leer["id_vehiculo"].ToString();
			        datos.vehiculo		=leer["vehiculo"].ToString();
			     }
			}
			 catch(Exception)
			 {
			 	datos=null;
			 }
		    
		     conexion.Close();
		     return datos;
		}*/
		
		// ESPECIALES ALTERNO
		public List<String> getIdEspAsigEspAlt(String dia, String dia2)
		{
			List<String> datos = new List<String>();
			 try
			 {
				 base.getAbrirConexion("SELECT id_ruta FROM OPERACION O, RUTA R, CLIENTE C WHERE O.id_ruta=R.ID AND C.ID=R.IdSubEmpresa and O.fecha BETWEEN '"+dia+"' and '"+dia2+"' and C.Empresa='Especiales'");
				 //MessageBox.Show("SELECT id_ruta FROM OPERACION O, RUTA R, CLIENTE C WHERE O.id_ruta=R.ID AND C.ID=R.IdSubEmpresa and O.fecha='"+dia+"' and C.Empresa='Especiales'");
				 
			     base.leer = base.comando.ExecuteReader();
			     while(base.leer.Read())
			     {
			     	datos.Add(leer["id_ruta"].ToString());
			     }
			 }
			 catch(Exception)
			 {
			 	datos.Clear();
			 }
		    
		     conexion.Close(); 
		     return datos;
		}
		#endregion
		
		#region GET DATOS OPERADOR
		public Interfaz.Operaciones.Dato.Operador getDatosOperador(int id_o)
		{
			Interfaz.Operaciones.Dato.Operador Op = new Transportes_LAR.Interfaz.Operaciones.Dato.Operador();
			
			String cons = "select O.Alias, V.Tipo_Unidad, V.Numero, (O.Municipio+' Col. '+O.Colonia+' Calle: '+O.Calle+' Num.'+O.Num_Interior) dom, C.NombrePatron from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, OperadorContrato C where O.ID=C.IdOperador and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.ID="+id_o;
			
			base.getAbrirConexion(cons);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Op.alias 		=base.leer["Alias"].ToString();
				Op.tipoV 		=base.leer["Tipo_Unidad"].ToString();
				Op.numeroV 		=base.leer["Numero"].ToString();
				Op.domicilio 	=base.leer["dom"].ToString();
				Op.patron		=base.leer["NombrePatron"].ToString();
			}
			base.conexion.Close();
			
			
			base.getAbrirConexion("select Numero from TELEFONOCHOFER where TIPO='LAR' and ID_Chofer="+id_o);
			
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				Op.telefono =base.leer["Numero"].ToString();
			}
			else
			{
				Op.telefono = "No ingresado";
			}
			base.conexion.Close();
			
			return Op;	
		}
		
		public Interfaz.Operaciones.Dato.Operador getDatosOperadorExt(int id_o)
		{
			Interfaz.Operaciones.Dato.Operador Op = new Transportes_LAR.Interfaz.Operaciones.Dato.Operador();
			
			base.getAbrirConexion("select O.Alias, T.Numero from OPERADOR O, TELEFONOCHOFER T where T.ID_Chofer=O.ID and T.Descripcion='lar' and O.ID="+id_o);
			
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				Op.alias 		=base.leer["Alias"].ToString();
				Op.telefono 	=base.leer["Numero"].ToString();
			}
			base.conexion.Close();
			
			return Op; 		
		}
		#endregion
		
		#region GET IMAGEN OPERADOR
		public void getImagenOp(int id_o, PictureBox Imagen)
		{
			base.getAbrirConexion("select Imagen from operador where ID="+id_o);
			base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
				try
				{
		      		byte[] imageBuffer = (byte[]) base.leer["Imagen"];
		          	System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
		         	Imagen.Image = Image.FromStream(ms);
		      	}
				catch
				{
					Imagen.Image=  Image.FromFile("Camara.png");            		
		      	}
            }
            conexion.Close();
		}
		
		public String getTelefono(int id_O)
		{
			 String telefono="";
			 try
			 {
				 base.getAbrirConexion("select Numero from TELEFONOCHOFER where Descripcion='LAR' and ID_Chofer="+id_O);
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			     	telefono=leer["Numero"].ToString();
			     }
			 }
			 catch(Exception)
			 {
			 	telefono="";
			 }
		    
		     conexion.Close();
		     return telefono;
		}
		#endregion
		
		#region GUARDAR GUARDIA
		public void guardia(int id)
		{
			base.getAbrirConexion("update HISTORIALOPERADOR set DETALLE='viaje' where ID_O="+id+" and ID_HO in (select MAX(ID_HO) from HISTORIALOPERADOR where ID_O="+id+" and ESTATUS='G')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region APOYOS
		public void guardarApoyo(int id_u, int id_operador, int id_apoya, int id_ruta, String dia, String turno, String tipo, String comentarios)
		{
			try
			{
				base.getAbrirConexion("execute ALMACENA_APOYOS "+id_u+", "+id_operador+", "+id_apoya+", "+id_ruta+", '"+dia+"','"+turno+"','"+tipo+"','"+comentarios+"'");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			catch(Exception)
			{
				MessageBox.Show("Error en guardado de apoyo a ruta");
			}
		}
		
		public void guardarApoyoCoordinacion(String consulta)
		{
			try
			{
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			catch(Exception)
			{
				MessageBox.Show("Error en guardado apoyo.");
			}
		}
		
		public List<Interfaz.Operaciones.Dato.Operador> getapoyos(String dia, String turno)
		{
			List<Interfaz.Operaciones.Dato.Operador> datos = new List<Transportes_LAR.Interfaz.Operaciones.Dato.Operador>();
			
			base.getAbrirConexion("select RR.ID, OP.Alias, RR.TIPO, RR.COMENTARIOS from APOYOS RR, OPERADOR OP where RR.ID_OP_APOYO=OP.ID and RR.Dia='"+dia+"' and RR.TURNO='"+turno+"'");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Operador dat = new Transportes_LAR.Interfaz.Operaciones.Dato.Operador();
				dat.id 	  		=base.leer["ID"].ToString();
				dat.alias 		=base.leer["Alias"].ToString();
				dat.estatus 	=base.leer["COMENTARIOS"].ToString();
				dat.tipoV		=base.leer["TIPO"].ToString();
				
				datos.Add(dat);
			}
			base.conexion.Close();
			
			return (datos.Count>0)?datos:null;	
		}
		
		public void eliminarApoyo(String Consulta)
		{
			base.getAbrirConexion(Consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region PRUEBAS DE RENDIMIENTO
		public void pruebaRendimiento(int id_u, int id_muestra, int id_supervisa, int id_ruta, String dia, String turno)
		{
			try
			{
				base.getAbrirConexion("execute pruebas_rendimiento "+id_u+", "+id_muestra+", "+id_supervisa+", "+id_ruta+", '"+dia+"','"+turno+"'");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
			catch(Exception)
			{
				
			}
		}
		
		public List<Interfaz.Operaciones.Dato.Operador> getDatosPruebas(String dia, String turno)
		{
			List<Interfaz.Operaciones.Dato.Operador> datos = new List<Transportes_LAR.Interfaz.Operaciones.Dato.Operador>();
			
			base.getAbrirConexion("select RR.ID_PR, OP.Alias, R.Nombre from PRUEBA_RENDIMIENTO RR, OPERADOR OP, RUTA R where RR.ID_OPERADOR=OP.ID and RR.ID_RUTA=R.ID and RR.Dia='"+dia+"' and RR.TURNO='"+turno+"'");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Operador dat = new Transportes_LAR.Interfaz.Operaciones.Dato.Operador();
				dat.id 	  		=base.leer["ID_PR"].ToString();
				dat.alias 		=base.leer["Alias"].ToString();
				dat.estatus 	=base.leer["Nombre"].ToString();
				
				datos.Add(dat);
			}
			base.conexion.Close();
			
			return (datos.Count>0)?datos:null;	
		}
		
		public void eliminarPrubaRec(String Consulta)
		{
			base.getAbrirConexion(Consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region RECONOCIMIENTO DE RUTAS
		public void reconocimientoRutas(int id_u, int id_muestra, int id_reconoce, Int64 id_ruta, String dia, String turno)
		{
			String conss = "execute reconocimiento_rutas "+id_u+", "+id_muestra+", "+id_reconoce+", "+id_ruta+", '"+dia+"','"+turno+"'";
			base.getAbrirConexion(conss);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public List<Interfaz.Operaciones.Dato.Operador> getDatosRec(String dia, String turno)
		{
			List<Interfaz.Operaciones.Dato.Operador> datos = new List<Transportes_LAR.Interfaz.Operaciones.Dato.Operador>();
			
			base.getAbrirConexion("select RR.ID, OP.Alias, R.Nombre from RECONOCIMIENTO_RUTA RR, OPERADOR OP, RUTA R where RR.ID_OPERADOR=OP.ID and RR.ID_RUTA=R.ID and RR.Dia='"+dia+"' and RR.TURNO='"+turno+"'");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Operador dat = new Transportes_LAR.Interfaz.Operaciones.Dato.Operador();
				dat.id 	  		=base.leer["ID"].ToString();
				dat.alias 		=base.leer["Alias"].ToString();
				dat.estatus 	=base.leer["Nombre"].ToString();
				
				datos.Add(dat);
			}
			base.conexion.Close();
			
			return (datos.Count>0)?datos:null;	
		}
		
		public String getOpMuestra(int idRec)
		{
			 String ID="";
			 try
			 {
				 base.getAbrirConexion("select O.Alias from OPERADOR O, RECONOCIMIENTO_RUTA R where O.ID=R.ID_OP_MUESTRA and R.ID="+idRec);
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			        ID	=	leer["Alias"].ToString();
			     }
			 }
			 catch(Exception)
			 {
			 	ID="";
			 }
		    
		     conexion.Close();
		     return ID;
		}
		
		public String getOpMuestra2(int idRec)
		{
			 String ID="";
			 try
			 {
				 base.getAbrirConexion("select O.Alias from OPERADOR O, PRUEBA_RENDIMIENTO R where O.ID=R.ID_OP_SUPERVISOR and R.ID_PR="+idRec);
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			        ID	=	leer["Alias"].ToString();
			     }
			 }
			 catch(Exception)
			 {
			 	ID="";
			 }
		    
		     conexion.Close();
		     return ID;
		}
		#endregion
		
		#region GET ID DE OPERADOR
		public int getIdOpRec(String alias)
		{
			 int ID=0;
			 try
			 {
				 base.getAbrirConexion("select ID from OPERADOR where Alias='"+alias+"'");
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			        ID=Convert.ToInt16(leer["id"].ToString());
			     }
			 }
			 catch(Exception)
			 {
			 	ID=0;
			 }
		    
		     conexion.Close();
		     return ID;
		}
		#endregion
		
		#region GUARDADO MENSAJE EMPRESA
		public void guardarMsjEmp(int id_usuario, string mensaje, int id_empresa, string fecha, string turno)
		{
			base.getAbrirConexion("insert into MENSAJE_EMPRESA values ("+id_usuario+", '"+mensaje+"', "+id_empresa+", '"+fecha+"', '"+turno+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void modificarMsjEmp(int id_usuario, string mensaje, int id_msj)
		{
			base.getAbrirConexion("update MENSAJE_EMPRESA set ID_U="+id_usuario+", MENSAJE='"+mensaje+"' where ID_MENSAJE="+id_msj);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region MOSTRAR MENSAJE
		public int getMsjEmp(int id_empresa, string fecha, string turno, TextBox texto)
		{
			 int id_msj=-1;
			 try
			 {
				 base.getAbrirConexion("SELECT * FROM MENSAJE_EMPRESA WHERE ID_SUBEMPRESA="+id_empresa+" AND DIA='"+fecha+"' AND TURNO='"+turno+"'");
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			        id_msj=Convert.ToInt16(leer["ID_MENSAJE"].ToString());
			        texto.Text=leer["MENSAJE"].ToString();
			     }
			 }
			 catch(Exception)
			 {
			 	id_msj=-1;
			 }
		    
		     conexion.Close();
		     return id_msj;
		}
		#endregion
		
		#region CANCELACION EN EL PUNTO
		public void cancelaPunto(Int64 id_Op, Int64 id_ruta, Int64 id_usuario, String Turno, String Fecha)
		{
			base.getAbrirConexion("update OPERACION SET ESTATUS='5' where id_operacion="+id_Op);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("insert into CANCELACION_PUNTO values ("+id_Op+", "+id_ruta+", "+id_usuario+", '"+Turno+"', '"+Fecha+"');");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region MSJ POR RUTA
		public void msjRuta(int id_u, int id_ruta, String msj, String dia, String turno)
		{
			base.getAbrirConexion("insert into MENSAJE_RUTA values ("+id_u+", "+id_ruta+", '"+msj+"', '"+dia+"', '"+turno+"');");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public List<Interfaz.Operaciones.Dato.msjRuta> getMsjRuta(String dia, String turno)
		{
			List<Interfaz.Operaciones.Dato.msjRuta> listMsjRuta = new List<Interfaz.Operaciones.Dato.msjRuta>();
			
			base.getAbrirConexion("select ID_RUTA, MENSAJE from MENSAJE_RUTA where DIA='"+dia+"' and TURNO='"+turno+"'");
			//MessageBox.Show("select ID_RUTA, MENSAJE from MENSAJE_RUTA where DIA='"+dia+"' and TURNO='"+turno+"'");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.msjRuta apoyo = new Interfaz.Operaciones.Dato.msjRuta();
				apoyo.ID_RUTA	=base.leer["ID_RUTA"].ToString();
				apoyo.MENSAJE	=base.leer["MENSAJE"].ToString().ToUpper();
				listMsjRuta.Add(apoyo);
			}
			base.conexion.Close();
			return (listMsjRuta.Count>0)?listMsjRuta:null;
		}
		#endregion
		
		#region MSJ GENERAL
		public void msjGral(int id_u, String msj, String dia, String turno)
		{
			base.getAbrirConexion("insert into MENSAJE_GENERAL values ("+id_u+", '"+msj+"', '"+dia+"', (SELECT CONVERT (time, SYSDATETIME())), '"+turno+"');");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public List<Interfaz.Operaciones.Dato.msjGral> getMsjGral()
		{
			List<Interfaz.Operaciones.Dato.msjGral> listmsj=new List<Interfaz.Operaciones.Dato.msjGral>();
			base.getAbrirConexion("SELECT U.nombre, M.* FROM MENSAJE_GENERAL M, usuario U where M.ID_U=U.id_usuario");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.msjGral dato = new Interfaz.Operaciones.Dato.msjGral();
				
				dato.ID_MSJ		=base.leer["ID_MENSAJE"].ToString();
				dato.USUARIO	=base.leer["nombre"].ToString();
				dato.FECHA		=base.leer["DIA"].ToString();
				dato.HORA		=base.leer["HORA"].ToString();
				dato.MSJ		=base.leer["MENSAJE"].ToString();
				
				listmsj.Add(dato);
			}
			base.conexion.Close();
			return (listmsj.Count>0)?listmsj:null;
		}
		
		public void eliminarMsjGral(int id_msj)
		{
			base.getAbrirConexion("delete MENSAJE_GENERAL where ID_MENSAJE="+id_msj);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region MSJGRAL
		public String getMSJGRAL()
		{
			String datos = "";
			// try
			 //{
				 base.getAbrirConexion("SELECT MENSAJE FROM MENSAJE_GRAL");
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			     	datos = leer["MENSAJE"].ToString();
			     }
			 /*}
			 catch(Exception)
			 {
			 	datos = "";
			 }*/
		    
		     conexion.Close();
		     return datos;
		}
		
		public void msjGral2(String consulta)
		{
			base.getAbrirConexion(consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region AGREGA RUTAS EXITENTES
		public void rutasExistentes(int id_ruta, String dia, String Turno, int id_emp)
		{
			base.getAbrirConexion("EXECUTE RUTA_EXISTENTES "+id_ruta+",'"+dia+"', '"+Turno+"', "+id_emp);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void rutasExistentesExtendidas(int id_ruta, String dia, String Turno, int id_emp)
		{
			base.getAbrirConexion("EXECUTE RUTA_EXISTENTES_EXT "+id_ruta+",'"+dia+"', '"+Turno+"', "+id_emp);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public int getIdRutaAgregada()
		{
			 int ID=0;
			 try
			 {
				 base.getAbrirConexion("select MAX(ID) ID from RUTA");
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			        ID=Convert.ToInt16(leer["ID"].ToString());
			     }
			 }
			 catch(Exception)
			 {
			 	ID=0;
			 }
			 
		     conexion.Close();
		     return ID;
		}
		#endregion
		
		public void cancelaEspecial(String idRuta)
		{
			base.getAbrirConexion("update RUTA set tipo='Cancelada' where ID="+idRuta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public bool getEstatusOp(Int64 id_operador, String dia, String turno, TextBox texto)
		{
			bool respuesta=false;
			
			base.getAbrirConexion("select ESTATUS from cardex where ID_OPERADOR='"+id_operador+"' and DIA='"+dia+"' and TURNO='"+turno+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				texto.Text=base.leer["ESTATUS"].ToString();
				respuesta=true;
			}
			else
			{
				respuesta=false;
			}
			base.conexion.Close();
			return respuesta;
		}
				
		// ******************************FORMATO ESPECIALES*************************************
		
		#region OBTENER NOMBRES DE SUBEMPRESAS
		public List<String> idEspeciales(String consulta)
		{
			base.getAbrirConexion(consulta);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				ListaSubNombres.Add(base.leer["dato"].ToString());
			}
			base.conexion.Close();
			return (ListaSubNombres.Count>0)?ListaSubNombres:null;
		}
		#endregion
		
		#region OBTENER NUMERO DE UNIDAD
		public String getNumUnidad(String ID_UNIDAD)
		{
			String Numero="000";
			 try
			 {
				 base.getAbrirConexion("select Numero from VEHICULO where ID='"+ID_UNIDAD+"'");
			     base.leer = base.comando.ExecuteReader();
			     if(base.leer.Read())
			     {
			        Numero=leer["Numero"].ToString();
			     }
			 }
			 catch(Exception)
			 {
			 	Numero="000";
			 }
		    
		     conexion.Close();
		     return Numero;
		}
		#endregion
		
		#region MODIFICACION DE COMENTARIOS PARA CANCELADOS ESPECIALES
		public void deleteAsignacionESP(String CONSULTA)
		{
			base.getAbrirConexion(CONSULTA);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		// *************************************************************************************
		
		#region VALIDA EXISTENCIA DE DORMIDAS
		public bool getDormidas(String dia, String turno)
		{
			bool respuesta=false;
			
			base.getAbrirConexion("select * from cardex where ESTATUS='D' and DIA='"+dia+"' and TURNO='"+turno+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				respuesta=true;
			}
			
			return respuesta;
		}
		#endregion
		
		#region CONSULTA DE MENSAJES GERENCIALES
		/*public List<Interfaz.Operaciones.Dato.> getMensajes()
		{
			
		}*/
		#endregion
	}
}