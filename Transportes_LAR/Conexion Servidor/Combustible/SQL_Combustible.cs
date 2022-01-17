using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Combustible
{
	public class SQL_Combustible:Conexion_Servidor.SQL_Conexion
	{
		public SQL_Combustible():base(){
		}
		
		#region  GUARDAR DATOS GASOLINERA
		public void guardaGasolinera(String nombre, String subNombre, String Municipio, String Colonia, String Direccion)
		{
			String consulta = "insert into GASOLINERA values ('"+nombre+"','"+subNombre+"','"+Municipio+"','"+Colonia+"','"+Direccion+"', 'INTERNA')"; 
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();
		}
		
		public void guardaContacto(String Contacto, String Telefono)
		{
			String consulta = "insert into CONTACTO_GASOLINERA values ((select MAX(ID) from GASOLINERA),'"+Telefono+"','"+Contacto+"')"; 
			
			base.getAbrirConexion(consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region MODIFICA DATOS
		public void guardaContactoNuevo(String Contacto, String Telefono, int id)
		{			
			String consulta = "insert into CONTACTO_GASOLINERA values ("+id+",'"+Telefono+"','"+Contacto+"')"; 
			
			base.getAbrirConexion(consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void modificaGasolinera(String nombre, String subNombre, String Municipio, String Colonia, String Direccion, int ID)
		{
			String consulta = "update GASOLINERA set NOMBRE='"+nombre+"', SUBNOMBRE='"+subNombre+"', MUNICIPIO='"+Municipio+"', COLONIA='"+Colonia+"', DIRECCION='"+Direccion+"' WHERE ID="+ID; 
			
			base.getAbrirConexion(consulta);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void modificaContacto(String Contacto, String Telefono, int ID)
		{			
			String consulta = "UPDATE CONTACTO_GASOLINERA SET NUMERO='"+Telefono+"', CONTACTO='"+Contacto+"' WHERE ID="+ID; 
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close(); 
		}
		#endregion
		
		#region GUARDAR PRECIOS COMB.
		public void guardaPrecios(String nombre, String precio, int ID_U)
		{			
			String consulta = "insert into TIPOS_COMB values ('"+nombre+"')"; 
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close(); 
			
			consulta = "INSERT INTO PRECIOS_COMB VALUES ((SELECT MAX(ID) FROM TIPOS_COMB), '"+precio+"', '1', "+ID_U+")"; 
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close(); 
		}
		
		public void modificaPrecios(String nombre, String precio, int id, int ID_U)
		{			
			String consulta = "update PRECIOS_COMB set ESTATUS='0' WHERE ID_TC="+id;
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close(); 
			
			consulta = "INSERT INTO PRECIOS_COMB VALUES ("+id+", '"+precio+"', '1', "+ID_U+")";
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close(); 
		}
		#endregion
		
		#region AUTORIZACIONES
		public Int64 getNumAutorizacion(int id_u)
		{
			Int64 respuesta = 0;
			String consulta = "EXECUTE SP_AUTORIZACION "+id_u;
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				respuesta=Convert.ToInt64(base.leer["NUM"]);
			}
			base.conexion.Close();
			
			return respuesta;
		}
		
		public void modificaAutorizacion(Int64 id_g, Int64 id_o, Int64 id_v, Int64 id_c, String fecha, String hora_aut, double litros, double km, String hora_carga, Int64 NUMERO)
		{
			String consulta ="UPDATE AUTORIZACION SET ID_G="+((id_g==0)?"null":id_g.ToString())+", ID_O="+((id_o==0)?"null":id_o.ToString())+", ID_V="+((id_v==0)?"null":id_v.ToString())+", ID_COM="+((id_c==0)?"null":id_c.ToString())+", FECHA_BASE='"+fecha+"', HORA_AUTORIZACION='"+hora_aut+"', LITROS='"+litros+"', KM='"+km+"', HORA_CARGA='"+hora_carga+"', ESTATUS='2' WHERE NUMERO='"+NUMERO+"'";
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();
		}
		
		public void eliminaAutorizacion(Int64 numero)
		{
			String consulta ="UPDATE AUTORIZACION SET ESTATUS='0' where NUMERO='"+numero+"'";
			
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();
		}
		#endregion
		
		#region LISTA HISTORIAL AUTORIZACIONES
		public List<Interfaz.Combustible.Datos.Autorizaciones> getAutorizaciones(string fecha)
		{
			List<Interfaz.Combustible.Datos.Autorizaciones> listDatos = new List<Interfaz.Combustible.Datos.Autorizaciones>();
			
			String consulta = "SELECT * FROM AUTORIZACION where FECHA_BASE='"+fecha+"' and ESTATUS!='0'";
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Combustible.Datos.Autorizaciones DATOS = new Interfaz.Combustible.Datos.Autorizaciones();
				DATOS.ID_AUTORIZACION	=base.leer["ID"].ToString();
				DATOS.ID_UNIDAD			=base.leer["ID_V"].ToString();
				DATOS.GASOLINERA		=base.leer["ID_G"].ToString();
				DATOS.OPERADOR			=base.leer["ID_O"].ToString();
				DATOS.HORA_A			=base.leer["HORA_AUTORIZACION"].ToString();
				DATOS.LITROS			=base.leer["LITROS"].ToString();
				DATOS.KM				=base.leer["KM"].ToString();
				DATOS.HORA_C			=base.leer["HORA_CARGA"].ToString();
				DATOS.PERMISO			=base.leer["PERMISO"].ToString();
				listDatos.Add(DATOS);
			}
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		
		public List<Interfaz.Combustible.Datos.Autorizaciones> getAutorizacionesReporte(string fechaInicio, string fechaFin)
		{
			List<Interfaz.Combustible.Datos.Autorizaciones> listDatos = new List<Interfaz.Combustible.Datos.Autorizaciones>();
			
			String consulta = "SELECT * FROM AUTORIZACION where FECHA_BASE between '"+fechaInicio+"' and '"+fechaFin+"' and ESTATUS!='0'";
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Combustible.Datos.Autorizaciones DATOS = new Interfaz.Combustible.Datos.Autorizaciones();
				DATOS.ID_AUTORIZACION	=base.leer["ID"].ToString();
				DATOS.ID_UNIDAD			=base.leer["ID_V"].ToString();
				DATOS.GASOLINERA		=base.leer["ID_G"].ToString();
				DATOS.OPERADOR			=base.leer["ID_O"].ToString();
				DATOS.HORA_A			=base.leer["HORA_AUTORIZACION"].ToString();
				DATOS.LITROS			=base.leer["LITROS"].ToString();
				DATOS.KM				=base.leer["KM"].ToString();
				DATOS.HORA_C			=base.leer["HORA_CARGA"].ToString();
				listDatos.Add(DATOS);
			}
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		#endregion
		
		public List<Interfaz.Combustible.Datos.Kilometrajes> getKmrecorridos(String fecha)
		{
			int increm=0;
			List<String> listaIds = new List<String>();
			String consulta = "select ID from VEHICULO where ID not in (select ID_V from AUTORIZACION where FECHA_BASE='"+fecha+"')";
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				listaIds.Add(base.leer["ID"].ToString());
				increm++;
			}
			base.conexion.Close();
			
			List<Interfaz.Combustible.Datos.Kilometrajes> listKm = new List<Transportes_LAR.Interfaz.Combustible.Datos.Kilometrajes>();
			
			for(int x=0; x<listaIds.Count; x++)
			{
				Interfaz.Combustible.Datos.Kilometrajes kms = new Transportes_LAR.Interfaz.Combustible.Datos.Kilometrajes();
				
				
				// ****************************************************************
				consulta="SELECT sum(cast(R.Kilometros as DECIMAL(10,2))) total FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, " +
					"OPERADOR OP, VEHICULO V WHERE U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion " +
					"AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo  and O.estatus='1' and R.FACTURA='0' AND O.fecha BETWEEN (select top 1 FECHA_BASE " +
					"from AUTORIZACION WHERE ID_V="+listaIds[x]+"  and FECHA_BASE<'"+fecha+"' order by FECHA_BASE desc) AND '"+fecha+"' AND V.ID="+listaIds[x];
				
				base.getAbrirConexion(consulta);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					//dgHistorial[10,x].Value=conn.leer["total"].ToString();
					kms.ID_V=listaIds[x];
					kms.KM	=base.leer["total"].ToString();
				}
				base.conexion.Close();
				// ****************************************************************
				
				listKm.Add(kms);
			}
			
			return (listKm.Count>0)?listKm:null;
		}
	
		#region VALIDACION OPERACIONES		
		
			#region VALIDACION
				
			#endregion
			
			#region OTROS FALTANTES
			public void otrosFaltantes(String ID_A, String tipo, String operador, String unidad, String empresa, String ruta, String sentido, String fecha,
			                           String hora, String turno, String comentario, int ID_U){				
				
				String consulta = "INSERT INTO OTROS_FALTANTES values ('"+ID_A+"', '"+tipo+"', '"+operador+"', '"+unidad+"', '"+empresa+"', '"+ruta+"', '"+sentido+"', '"+fecha+"', '"+hora+"', '"+turno+"', '"+comentario+"', '1', "+ID_U+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
							
				base.getAbrirConexion(consulta); 
				base.comando.ExecuteNonQuery(); 
				base.conexion.Close(); 
				
			}
			#endregion
		
			#region REVICION DE RUTA NO REALIZADA
			public void revizaNoRealizada(String ID, String comentario, int idu)
			{
				String consulta = "update REVISION_VIAJES set ESTATUS= '0', COMENTARIO = 'Id Usuario Revizo: "+idu+ " , "+comentario+"'WHERE ID_O="+ID; 
				
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
						
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'REVIZO RUTA NO REALIZADA,  ID = "+ID+",  COMENTARIO:  "+comentario+"' , (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idu+", 'REVISION_VIAJES')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}
			
			#endregion
			
			#region REVICION DE OTROS NO REALIZADA
			public void revizaOtrosNoRealizada(String ID, String comentario, int idu, String tipo)
			{
				String consulta = "update REVISION_OTROS set ESTATUS= '0', COMENTARIO = 'Id Usuario Revizo: "+idu+ " , "+comentario+"' WHERE ID_TIPO="+ID+" and TIPO = '"+tipo+"'"; 
				
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
						
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL VALUES('UPDATE', 'REVIZO OTRO NO REALIZADO,  ID = "+ID+",  COMENTARIO:  "+comentario+"' , (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idu+", 'REVISION_VIAJES')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}
			
			#endregion
			
			#region REVICION DE RUTA FALTANTE
			public void revizaFaltantes(String ID, int idu)
			{
				String consulta = "update VIAJES_FALTANTES set ESTATUS= '0' WHERE ID="+ID; 
				
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'REVIZO RUTA FALTANTE,  ID = "+ID+"' , (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idu+", 'VIAJES_FALTANTES')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}
			
			#endregion		
			
			#region REVICION DE OTROS FALTANTE
			public void revizaOtrosFaltantes(String ID, int idu, String tipo)
			{
				String consulta = "update OTROS_FALTANTES set ESTATUS= '0' WHERE ID="+ID; 
				
				base.getAbrirConexion(consulta);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'REVIZO OTRO FALTANTE,  ID = "+ID+", TIPO = "+tipo+"' , (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idu+", 'VIAJES_FALTANTES')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();	
			}
			
			#endregion		
		
		#endregion
			
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///////////////////////////////////////////////// PRUEBAS DE RENDIMIENTO //////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region INSERTAR
		public Int32  insertarNuevaPrueba(string id_ve){		
			string sentencia = "";
			Int32  id_ren = 0;
			try{				
				sentencia = @"INSERT INTO PRUEBA_RENDIMIENTO_NUEVO (id_v, rendimiento, estatus)VALUES('"+id_ve+"', '0', 'Activo')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception){
				id_ren = -1;
			}
			
			if(id_ren == 0){
				base.getAbrirConexion("select MAX(ID) ID From PRUEBA_RENDIMIENTO_NUEVO");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read()){
					id_ren = Convert.ToInt32(base.leer["ID"]);
				}
				base.conexion.Close();				
			}			
			return id_ren;
		}
		
		public bool  insertarPrueba(string id_rendimiento, string id_vehiculo, string id_operador, string usuario_prueba, string fecha_prueba, string hora_inicio_prueba, string hora_fin_prueba, 
									string litros_carga, string km_inicial_prueba, string km_fin_prueba, string comentario, string rendimiento, string seguimiento, Int32 id_usuario, int bandera){
			string sentencia = "";
			bool respuesta = true;
			try{				
				sentencia = @"INSERT INTO HISTORIAL_PRUEBA_RENDIMIENTO (id_rendimiento, id_v, id_operador, usuario_prueba, fecha_prueba, hora_inicio_prueba, hora_fin_prueba, 
							litros_carga, km_inicial_prueba, km_fin_prueba, comentario, rendimiento, seguimiento, fecha_reg, hora_reg, id_usuario, estatus)
							VALUES( "+id_rendimiento+", "+id_vehiculo+" , "+id_operador+" ,'"+usuario_prueba+"','"+fecha_prueba+"','"+hora_inicio_prueba+"','"+hora_fin_prueba
							+"','"+litros_carga+"','"+km_inicial_prueba+"','"+km_fin_prueba+"', '"+comentario+"', '"+rendimiento
							+"', '"+seguimiento+"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), "+id_usuario+" ,'1')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
			}catch(Exception){
				respuesta = false;
			}
			
			if(respuesta){	
				try{	
					Int32  id_ren = 0;
					base.getAbrirConexion("select MAX(ID) ID From HISTORIAL_PRUEBA_RENDIMIENTO where id_rendimiento = "+id_rendimiento);
					base.leer=base.comando.ExecuteReader();
					if(base.leer.Read()){
						id_ren = Convert.ToInt32(base.leer["ID"]);
					}
					base.conexion.Close();	
					
					string  fecha = "";
					base.getAbrirConexion("SELECT prh.fecha_prueba FROM PRUEBA_RENDIMIENTO_NUEVO pr JOIN HISTORIAL_PRUEBA_RENDIMIENTO prh on prh.ID = pr.id_historial WHERE  id_rendimiento = "+id_rendimiento);
					base.leer=base.comando.ExecuteReader();
					if(base.leer.Read()){
						fecha = base.leer["fecha_prueba"].ToString();
					}
					base.conexion.Close();					
					double km = Convert.ToDouble(km_fin_prueba) - Convert.ToDouble(km_inicial_prueba);
					
					if(fecha != ""){
						if(Convert.ToDateTime(fecha_prueba) >= Convert.ToDateTime(fecha)){						
							sentencia = @"UPDATE PRUEBA_RENDIMIENTO_NUEVO SET rendimiento = '"+rendimiento+"', fecha = '"+fecha_prueba+"', litros = '"+litros_carga+"', km_recorridos = '"+km
										+"', seguimiento = '"+seguimiento+"', id_historial = '"+id_ren+"'  WHERE  ID = "+id_rendimiento;
							base.getAbrirConexion(sentencia);
							base.comando.ExecuteNonQuery();
							base.conexion.Close();
						}						
					}
					if(fecha == ""){
						if(bandera == 1){						
							sentencia = @"UPDATE PRUEBA_RENDIMIENTO_NUEVO SET rendimiento = '"+rendimiento+"', fecha = '"+fecha_prueba+"', litros = '"+litros_carga+"', km_recorridos = '"+km
										+"', seguimiento = '"+seguimiento+"', id_historial = '"+id_ren+"'  WHERE  ID = "+id_rendimiento;
							base.getAbrirConexion(sentencia);
							base.comando.ExecuteNonQuery();
							base.conexion.Close();
						}						
					}	
				}catch(Exception){
					respuesta = false;
				}
			}
			return respuesta;
		}	
		
		
		#endregion
		
		#region MODIFICAR
		public bool modificarSeguimiento(string id_rendimiento, string id_historial, string seguimiento, string id_usuario){
			bool respuesta = true;
			string sentencia = "";
			string seguimeintoOLD = "";
			try{		
				base.getAbrirConexion("select seguimiento from PRUEBA_RENDIMIENTO_NUEVO where ID = "+id_rendimiento);
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read()){
					seguimeintoOLD = base.leer["seguimiento"].ToString();
				}
				base.conexion.Close();
				
				base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo el seguiemiento de la prueba: "+id_rendimiento+". SEGUIMIENTO 1: "+seguimeintoOLD+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'PRUEBA_RENDIMIENTO_NUEVO')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
								
				sentencia = @"UPDATE PRUEBA_RENDIMIENTO_NUEVO SET seguimiento = '"+seguimiento+"'  WHERE  ID = "+id_rendimiento;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				sentencia = @"UPDATE HISTORIAL_PRUEBA_RENDIMIENTO SET seguimiento = '"+seguimiento+"'  WHERE  ID = "+id_historial;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}			
			return respuesta;
		}
		
		public bool  modificarPrueba(string ID_rh, string usuario_prueba, string fecha_prueba, string hora_inicio_prueba, string hora_fin_prueba, 
									string litros_carga, string km_inicial_prueba, string km_fin_prueba, string comentario, string rendimiento, string seguimiento, Int32 id_usuario, Int64 id_rendimeinto, string id_operador){
			string sentencia = "";
			bool respuesta = true;
			
			string  fecha = "";
			double km = Convert.ToDouble(km_fin_prueba) - Convert.ToDouble(km_inicial_prueba);
					
			string fecha_pruebaOLD = "";
			string factorOLD = "";
			string UsuarioOLD = "";
			string seguimientoLD = "";
			
			base.getAbrirConexion("SELECT fecha_prueba, rendimiento, usuario_prueba, seguimiento from HISTORIAL_PRUEBA_RENDIMIENTO  where ID = "+ID_rh);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				fecha_pruebaOLD = base.leer["fecha_prueba"].ToString();
				factorOLD = base.leer["rendimiento"].ToString();
				UsuarioOLD = base.leer["usuario_prueba"].ToString();
				seguimientoLD = base.leer["seguimiento"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo una prueba de rendimiento id: "+ID_rh+". VALORES CAMBIADOS. fecha de prueba: "+fecha_pruebaOLD+", Usaurio que realizo la prueba: "+UsuarioOLD
			                      +" factor: "+factorOLD+", Seguimiento: "+seguimientoLD+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'HISTORIAL_PRUEBA_RENDIMIENTO')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
			
			try{	
				sentencia = @"UPDATE HISTORIAL_PRUEBA_RENDIMIENTO SET usuario_prueba = '"+usuario_prueba+"', fecha_prueba = '"+fecha_prueba+"', hora_inicio_prueba = '"+hora_inicio_prueba+"' ,hora_fin_prueba = '"+hora_fin_prueba
					+"' , litros_carga = '"+litros_carga+"', km_inicial_prueba = '"+km_inicial_prueba+"', km_fin_prueba = '"+km_fin_prueba
					+"', comentario = '"+comentario+"', rendimiento = '"+rendimiento+"', seguimiento = '"+seguimiento+"', id_operador = '"+id_operador+"' WHERE ID = "+ID_rh;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				base.getAbrirConexion("SELECT prh.fecha_prueba FROM PRUEBA_RENDIMIENTO_NUEVO pr JOIN HISTORIAL_PRUEBA_RENDIMIENTO prh on prh.ID = pr.id_historial WHERE  id_rendimiento = "+id_rendimeinto);
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read()){
					fecha = base.leer["fecha_prueba"].ToString();
				}
				base.conexion.Close();	

				if(fecha != ""){
					if(Convert.ToDateTime(fecha_prueba) >= Convert.ToDateTime(fecha)){						
						sentencia = @"UPDATE PRUEBA_RENDIMIENTO_NUEVO SET rendimiento = '"+rendimiento+"', fecha = '"+fecha_prueba+"', litros = '"+litros_carga+"', km_recorridos = '"+km
									+"', seguimiento = '"+seguimiento+"', id_historial = '"+ID_rh+"'  WHERE  ID = "+id_rendimeinto;
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}
				
			}catch(Exception){
				respuesta = false;
			}			
			return respuesta;
		}	
		
		#endregion
		
		#region OBTENER LITROS		
		public String obtenerLitros(string id){			
			string parametro = "0";		
			base.getAbrirConexion("select litros from PRUEBA_RENDIMIENTO_NUEVO where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametro = base.leer["litros"].ToString();
			}
			base.conexion.Close();			
			return parametro;			
		}		
		#endregion
		
		#region PARAMETRO
		public void modificarParametrosCombu(string parametro, Int16 id, Int32 id_usuario){		
			string parametroOLD = "";			
			base.getAbrirConexion("select * from PARAMETROS_GENERALES where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametroOLD = base.leer["PARAMETRO1"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo el parametro: "+id+". PARAMETRO 1: "+parametroOLD+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'PARAMETROS_PRUEBA_R')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
			
			String consul = "update PARAMETROS_GENERALES set  PARAMETRO1 = '"+parametro+"' where ID = "+id;
			base.getAbrirConexion(consul); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();	
		}
		
		public void modificarParametrosCombu2(string parametro1, string parametro2, Int16 id, Int32 id_usuario){		
			string parametroOLD = "";	
			string parametroOLD2 = "";				
			base.getAbrirConexion("select * from PARAMETROS_GENERALES where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametroOLD = base.leer["PARAMETRO1"].ToString();
				parametroOLD2 = base.leer["PARAMETRO2"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo el parametro: "+id+". PARAMETRO 1: "+parametroOLD+", PARAMETRO 2: "+parametroOLD2+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'PARAMETROS_PRUEBA_R')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
			
			String consul = "update PARAMETROS_GENERALES set  PARAMETRO1 = '"+parametro1+"', PARAMETRO2 = '"+parametro2+"' where ID = "+id;
			base.getAbrirConexion(consul); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();	
		}
	
		public String obtenerParametroPrueba(Int16 id){			
			string parametro = "";			
			base.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametro = base.leer["PARAMETRO1"].ToString();
			}
			base.conexion.Close();			
			return parametro;			
		}
		public String obtenerParametroPrueba2(Int16 id){			
			string parametro = "";			
			base.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametro = base.leer["PARAMETRO2"].ToString();
			}
			base.conexion.Close();			
			return parametro;			
		}
		
		#endregion
		
	}
}
