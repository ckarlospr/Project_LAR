
using System;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Controles
{
	public class SQL_Controles:SQL_Conexion
	{
		public SQL_Controles()
		{
		}
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////// UBER-TAXI ////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region INSERTAR PEDIDO
		public Boolean insertarUberTaxi(string ID_RUTA, string ID_OPERADOR, string ID_USUARIO, string TIPO_UNIDAD, string MOTIVO, string FECHA_PLANEACION,
		                                    string TURNO, string HORA_INICIO, string USUARIOS_APROX, string UNIDADES_APROX, string ESTADO, DataGridView dgResponsables)
		{	
			bool respuesta = true;
			String sentencia = "";
			try{
				sentencia = @"insert into UBER_TAXI (ID_RUTA, ID_OPERADOR, ID_USUARIO, TIPO_UNIDAD, MOTIVO, FECHA_PLANEACION, TURNO, HORA_INICIO, HORA_PANEACION, 
									USUARIOS_APROX, UNIDADES_APROX, ESTADO, TIPO, ESTATUS) values ('"+ID_RUTA+"', '"+ID_OPERADOR+"', '"+ID_USUARIO+"', '"+TIPO_UNIDAD
									+"', '"+MOTIVO+"', '"+FECHA_PLANEACION+"', '"+TURNO+"', '"+HORA_INICIO+"', (SELECT CONVERT (TIME, SYSDATETIME())), '"+
									USUARIOS_APROX+"', '"+UNIDADES_APROX+"', '"+ESTADO+"', 'RUTA', 'Activo')";				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				respuesta = true;
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			if(ESTADO == "PEDIDO"){
				try{
					if(respuesta){
						Int64 ID_UT = obtenerIdMaxUT();
						if(ID_UT > 0){
							for(int x=0; x<dgResponsables.Rows.Count; x++){
								sentencia = @"insert into UBER_TAXI_PEDIDO (ID_PEDIDO, ID_CUENTA, TIPO_UNIDAD, FECHA_PEDIDO, HORA_PEDIDO, ID_USUARIO, ESTADO, TIPO, ESTATUS) values ('"
											+ID_UT+"', '"+dgResponsables[1,x].Value+"', '"+dgResponsables[2,x].Value+@"', (SELECT CONVERT (DATE, SYSDATETIME())), 
											(SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"', 'SIN VALIDAR', 'RUTA', 'Activo')";				
								base.getAbrirConexion(sentencia);
								base.comando.ExecuteNonQuery();
								base.conexion.Close();
							}
						}
					}
				}catch(Exception){
					
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}
			
			return respuesta;
		}
		#endregion
		
		#region MODIFICAR PEDIDO
		public Boolean modificarProgramacion(string id, string ID_OPERADOR, string ID_USUARIO, string MOTIVO, string ESTADO, DataGridView dgResponsables )
		{	
			bool respuesta = true;
			String sentencia = "";	
			try{		
				sentencia = "UPDATE UBER_TAXI SET ID_OPERADOR = '"+ID_OPERADOR+"', MOTIVO = '"+MOTIVO+"', ESTADO = '"+ESTADO+"' where ID = "+id;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
				respuesta = true;
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			try{
				if(respuesta){
					for(int x=0; x<dgResponsables.Rows.Count; x++){
						if(dgResponsables[0,x].Value.ToString() == "0"){
							sentencia = @"insert into UBER_TAXI_PEDIDO (ID_PEDIDO, ID_CUENTA, TIPO_UNIDAD, FECHA_PEDIDO, HORA_PEDIDO, ID_USUARIO, ESTADO, TIPO, ESTATUS) values ('"
										+id+"', '"+dgResponsables[1,x].Value+"', '"+dgResponsables[2,x].Value+@"', (SELECT CONVERT (DATE, SYSDATETIME())), 
										(SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"', 'SIN VALIDAR', 'RUTA', 'Activo')";				
							base.getAbrirConexion(sentencia);
							base.comando.ExecuteNonQuery();
							base.conexion.Close();
						}
					}
					
				}
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}			
			
			return respuesta;
		}
		#endregion
		
		#region VALIDA EXISTE RESPONSABLE
		public Int64 validaResponsable(string Alias){	
			Int64 id = 0;
			try{		
				String sentencia = @"SELECT CUT.ID FROM OPERADOR O JOIN CUENTAS_UBER_TAXI CUT ON CUT.ID_USUARIO = O.ID WHERE O.Estatus = '1' AND CUT.ESTATUS = 'Activo' and O.Alias = '"+Alias+"'";
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();				
	            if(base.leer.Read())
					id = Convert.ToInt64(base.leer["ID"]);
	            else
					id = 0;
				base.conexion.Close();
			}catch(Exception){
				id = 0;				
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return id;
		}
		#endregion	
		
		#region OBTENER SI TIENE TARJETA
		public string obtenerTarjeta(Int64 id_responsable){	
			string tarjeta = "";
			try{		
				String sentencia = @"SELECT TARJETA FROM CUENTAS_UBER_TAXI WHERE ID_USUARIO = "+id_responsable;
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();				
	            if(base.leer.Read())
	            	tarjeta = base.leer["TARJETA"].ToString();
	            else
					tarjeta = "";
				base.conexion.Close();
			}catch(Exception){
				tarjeta = "";				
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return tarjeta;
		}
		#endregion	
		
		#region OBTENER ID MAXIMO DE UBER-TAXI		
		public Int64 obtenerIdMaxUT(){
			Int64 id = 0;
			try{	
				base.getAbrirConexion("select MAX(ID) ID From UBER_TAXI WHERE ESTATUS = 'Activo'");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read()){
					id = Convert.ToInt64(base.leer["ID"]);
				}
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR DE BD AL OBTENER EL ID MÁXIMO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}	
			return id;
		}
		#endregion
		
		#region CANCELAR UT O VEHÍCULO
		public Boolean cancelaUT_V(string TIPO, string ID_CANCELA, string MOTIVO, string ID_USUARIO)
		{	
			bool respuesta = true;
			String sentencia = "";	
			try{
				if(TIPO == "PEDIDO"){
					sentencia = "UPDATE UBER_TAXI SET ESTATUS = 'INACTIVO' where ID = "+ID_CANCELA;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();				
					respuesta = true;
				}else{
					sentencia = "UPDATE UBER_TAXI_PEDIDO SET ESTATUS = 'INACTIVO' where ID = "+ID_CANCELA;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();				
					respuesta = true;
				}					
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			try{
				if(respuesta){
					sentencia = @"insert into UBER_TAXI_CANCELA (TIPO, ID_CANCELA, MOTIVO, FECHA_CANCELO, HORA_CANCELO, ID_USUARIO) values ('"+TIPO+"', '"
								+ID_CANCELA+"', '"+MOTIVO+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		#endregion	
		
		#region CIERRE VEHICULO
		public Boolean cierreVechiculo(string USUARIOS, string COSTO, string FOLIO, string ID_USUARIO, string ID)
		{	
			bool respuesta = true;
			String sentencia = "";	
			try{
				sentencia = "UPDATE UBER_TAXI_PEDIDO SET USUARIOS = '"+USUARIOS+"', COSTO = '"+COSTO+"', FOLIO = '"+FOLIO+"', ESTADO = 'VALIDADO' where ID = "+ID;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
				respuesta = true;				
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		#endregion			
		
		#region CIERRE UBER - TAXI
		public Boolean cierreUT(string ID_USUARIO, string ID)
		{	
			bool respuesta = true;
			String sentencia = "";	
			try{
				sentencia = "UPDATE UBER_TAXI SET ESTADO = 'CIERRE', FECHA_CIERRE = (SELECT CONVERT (DATE, SYSDATETIME())) , HORA_CIERRE = (SELECT CONVERT (TIME, SYSDATETIME())) where ID = "+ID;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
				respuesta = true;				
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		#endregion	
		
		#region VALIDA EXISTE PEDIDO DE LA RUTA
		public Int64 validaPedido(string Alias){	
			Int64 id = 0;
			try{
				String sentencia = "";			
				sentencia = "SELECT ID FROM OPERADOR WHERE Estatus = '1' AND Alias LIKE '%"+Alias+"%'";
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();				
	            if(base.leer.Read())
					id = Convert.ToInt64(base.leer["ID"]);
	            else
					id = 0;
				base.conexion.Close();
			}catch(Exception){
				id = 0;				
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return id;
		}
		#endregion				
		
		#region PARAMETROS
		public String obtenerParametroTiempo() {
			string parametro = "";
			try{
				base.getAbrirConexion("select PARAMETRO6 from PARAMETROS_GENERALES where ID = 4");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
					parametro = base.leer["PARAMETRO6"].ToString();
				base.conexion.Close();
			}catch(Exception){
				parametro = "00:00";
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return parametro;			
		}
		public String obtenerParametroEmail(Int16 id, int correo){			
			string parametro = "";			
			base.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				if(correo == 1)
					parametro = base.leer["PARAMETRO1"].ToString();
				if(correo == 2)
					parametro = base.leer["PARAMETRO2"].ToString();
				if(correo == 3)
					parametro = base.leer["PARAMETRO3"].ToString();
				if(correo == 4)
					parametro = base.leer["PARAMETRO4"].ToString();
			}
			base.conexion.Close();			
			return parametro;			
		}
		#endregion		
		
		
		//////////////////////////////////////////////////////////  UBER-TAXI EXTRA  ///////////////////////////////////////////////////////////
		
		#region OBTENER ID OPERADOR DEPIENDE DE CUENTA
		public Int64 obtenerOperadorCuenta(Int64 id_responsable){	
			Int64 ID_OP = 0;
			try{		
				String sentencia = @"SELECT O.ID FROM CUENTAS_UBER_TAXI CUT JOIN OPERADOR O ON O.ID = CUT.ID_USUARIO WHERE CUT.ID = "+id_responsable;
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();				
	            if(base.leer.Read())
	            	ID_OP = Convert.ToInt64( base.leer["ID"] );
	            else
					ID_OP = 0;
				base.conexion.Close();
			}catch(Exception){
				ID_OP = 0;				
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return ID_OP;
		}
		#endregion	
		
		#region CIERRE VEHICULO - UBER- TAXI
		public Boolean cierreVechiculoUT(string USUARIOS, string COSTO, string ID_USUARIO, string ID_UT, string ID_PEDIDO)
		{	
			bool respuesta = true;
			String sentencia = "";	
			try{
				sentencia = "UPDATE UBER_TAXI_PEDIDO SET USUARIOS = '"+USUARIOS+"', COSTO = '"+COSTO+"', ESTADO = 'VALIDADO' where ID = "+ID_PEDIDO;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
				respuesta = true;				
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			if(respuesta){
				try{
					sentencia = "UPDATE UBER_TAXI SET ESTADO = 'CIERRE', FECHA_CIERRE = (SELECT CONVERT (DATE, SYSDATETIME())) , HORA_CIERRE = (SELECT CONVERT (TIME, SYSDATETIME())) where ID = "+ID_UT;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();				
					respuesta = true;				
				}catch(Exception){				
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}			
			return respuesta;
		}
		#endregion	
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////// CONFIGURACION PARAMETROS UBER-TAXI ///////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region INSERTAR CUENTA
		public Boolean insertarCuentaUT(string ID_USUARIO, string TARJETA, string NUMERO_TARJETA, string TIPO_TARJETA)
		{	
			bool respuesta = true;
			try{
				String sentencia = "insert into CUENTAS_UBER_TAXI (ID_USUARIO, TARJETA, NUMERO_TARJETA, TIPO_TARJETA, ESTATUS) values ('"+ID_USUARIO+"', '"
								+TARJETA+"', '"+NUMERO_TARJETA+"', '"+TIPO_TARJETA+"', 'Activo')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				respuesta = true;
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		#endregion
		
		#region MODIFICAR CUENTA
		public Boolean modificarCuentaUT(string TARJETA, string NUMERO_TARJETA, string TIPO_TARJETA, string id)
		{	
			bool respuesta = true;
			try{
				String sentencia = "";			
				sentencia = "UPDATE CUENTAS_UBER_TAXI SET TARJETA = '"+TARJETA+"', NUMERO_TARJETA = '"+NUMERO_TARJETA+"', TIPO_TARJETA = '"+TIPO_TARJETA+"' where ID = "+id;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
				respuesta = true;
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		#endregion
		
		#region VALIDA EXISTE USUARIO
		public Int64 validaUsuarioOperador(string Alias){	
			Int64 id = 0;
			try{
				String sentencia = "";			
				sentencia = "SELECT ID FROM OPERADOR WHERE Estatus = '1' AND Alias = '"+Alias+"'";
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();				
	            if(base.leer.Read())
					id = Convert.ToInt64(base.leer["ID"]);
	            else
					id = 0;
				base.conexion.Close();
			}catch(Exception){
				id = 0;				
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return id;
		}
		#endregion		
		
		#region CORREOS
		public void modificarParametrosCorreo(string parametro1, string parametro2, string parametro3, string parametro4, string parametro6, Int16 id){		
			string consulta = "update PARAMETROS_GENERALES set  PARAMETRO1 = '"+parametro1+"', PARAMETRO2 = '"+parametro2
								+"', PARAMETRO3 = '"+parametro3+"' , PARAMETRO4 = '"+parametro4+"' , PARAMETRO6 = '"+parametro6+"'  where ID = "+id;
			base.getAbrirConexion(consulta); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();	
		}
		#endregion
				
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///////////////////////////////////////////////////// UBER-TAXI EXTRA /////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region VALIDA EXISTE USUARIO ADMINISTRATIVO
		public Int64 validaUsuarioAdministrativo(string Alias){	
			Int64 id = 0;
			try{
				String sentencia = "";			
				sentencia = "SELECT ID FROM OPERADOR WHERE TIPO_EMPLEADO != 'OPERADOR' AND Estatus = '1' AND Alias = '"+Alias+"'";
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();				
	            if(base.leer.Read())
					id = Convert.ToInt64(base.leer["ID"]);
	            else
					id = 0;
				base.conexion.Close();
			}catch(Exception){
				id = 0;				
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return id;
		}
		#endregion	
		
		#region INSERTAR PEDIDO EXTRA 
		public Boolean insertarUberTaxiExtra(string ID_OPERADOR, string ID_USUARIO, string MOTIVO, string FECHA_PLANEACION, string HORA_PANEACION, 
		                                    string ID_responsable, string TIPO_UNIDAD, string TRASLADO, string ITINERARIO_A, string ITINERARIO_B)
		{	
			bool respuesta = true;
			String sentencia = "";
			
			///////////////////////////////////////////////////////////////  FOLIO  ///////////////////////////////////////////////////////////////
			string folio = obtenerFolio();			
			
			try{
				sentencia = @"insert into UBER_TAXI ( ID_OPERADOR, ID_USUARIO, TRASLADO, ITINERARIO_A, ITINERARIO_B, MOTIVO, FECHA_PLANEACION, 
							HORA_PANEACION, ESTADO, TIPO, ESTATUS) values ('"+ID_OPERADOR+"', '"+ID_USUARIO+"', '"+TRASLADO+"', '"+ITINERARIO_A
							+"', '"+ITINERARIO_B+"', '"+MOTIVO+"', '"+FECHA_PLANEACION+"', '"+HORA_PANEACION+"', 'PEDIDO', 'EXTRA', 'Activo')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				respuesta = true;
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			try{
				if(respuesta){
					Int64 ID_UT = obtenerIdMaxUT();
					if(ID_UT > 0){
						sentencia = @"insert into UBER_TAXI_PEDIDO (ID_PEDIDO, ID_CUENTA, TIPO_UNIDAD, FECHA_PEDIDO, HORA_PEDIDO, ID_USUARIO, ESTADO, TIPO, ESTATUS, FOLIO) values ('"
									+ID_UT+"', '"+ID_responsable+"', '"+TIPO_UNIDAD+"',  (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())),'"
									+ID_USUARIO+"', 'SIN VALIDAR', 'EXTRA', 'Activo', '"+folio+"')";
						base.getAbrirConexion(sentencia);
						base.comando.ExecuteNonQuery();
						base.conexion.Close();
					}
				}
			}catch(Exception){
				
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		
		public string obtenerFolio(){
			Int64 numero = 0;			
			
			base.getAbrirConexion("select MAX(FOLIO) NUMERO from UBER_TAXI_PEDIDO");
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){					
				try{ numero = Convert.ToInt32(base.leer["NUMERO"]); }catch (Exception){ numero = 0; }
			}
			base.conexion.Close();			
			numero++;		
			return numero.ToString();
		}
		#endregion
				
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////// SUELDO REAL ///////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region OBTENER TIPO DE EMPLEADO
		public string ObtenerTipoEmpledo(Int64 id_operador){	
			string tipo = "";
			try{		
				String sentencia = @"SELECT tipo_empleado from  OPERADOR WHERE ID = "+id_operador;
				base.getAbrirConexion(sentencia);
				base.leer = base.comando.ExecuteReader();				
	            if(base.leer.Read())
	            	tipo = base.leer["tipo_empleado"].ToString();
	            else
					tipo = "";
				base.conexion.Close();
			}catch(Exception){
				tipo = "";		
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return tipo;
		}
		#endregion
		
		#region INSERTAR SUELDO
		public Boolean InsertarSueldo(string ID_OPERADOR, string SUELDO, string TIPO_EMPLEADO, string TIPO_SUELDO)
		{	
			bool respuesta = true;
			try{
				String sentencia = "insert into SUELDO_REAL (ID_OPERADOR, SUELDO, TIPO_EMPLEADO, TIPO_SUELDO, ESTATUS) values ('"+ID_OPERADOR+"', '"
								+SUELDO+"', '"+TIPO_EMPLEADO+"', '"+TIPO_SUELDO+"', 'Activo')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				respuesta = true;
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}
		#endregion
		
		#region MODIFICAR SUELDO
		public Boolean ModificarSueldo(string ID_SUELDO, string SUELDO, string TIPO_EMPLEADO, string TIPO_SUELDO, string ID_USUARIO, string SUELDO_OLD, string TIPO_EMPLEADO_OLD, string TIPO_SUELDO_OLD)
		{	
			bool respuesta = true;
			string sentencia = "";
			try{
				sentencia = "UPDATE SUELDO_REAL SET SUELDO = '"+SUELDO+"', TIPO_EMPLEADO = '"+TIPO_EMPLEADO+"', TIPO_SUELDO = '"+TIPO_SUELDO+"' WHERE ID = "+ID_SUELDO;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				respuesta = true;
			}catch(Exception){				
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			if(respuesta){
				try{
					sentencia = @"insert into HTS_SUELDO_REAL (ID_SUELDO, SUELDO_OLD, TIPO_EMPLEADO_OLD, TIPO_SUELDO_OLD, FECHA_REG, HORA_REG, ID_USUARIO) values ('"+ID_SUELDO
						+"', '"+SUELDO_OLD+"', '"+TIPO_EMPLEADO_OLD+"', '"+TIPO_SUELDO_OLD+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					respuesta = true;
				}catch(Exception){				
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}				
			return respuesta;
		}
		#endregion
		
		#region RETORNA SUELDO
		public string RetornaSueldo(string id_operador){
			string sueldo = "0";			
			try{
				base.getAbrirConexion("select SUELDO from SUELDO_REAL where ID_OPERADOR = "+id_operador);
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read())					
					sueldo = base.leer["SUELDO"].ToString();			
				base.conexion.Close();
			}catch(Exception){
				sueldo = "0";
			}
			return sueldo;
		}
		#endregion
		
	}
}
