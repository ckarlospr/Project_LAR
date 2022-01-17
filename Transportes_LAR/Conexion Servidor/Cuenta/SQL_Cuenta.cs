using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Threading;

namespace Transportes_LAR.Conexion_Servidor.Cuenta
{
	public class SQL_Cuenta:SQL_Conexion
	{
		public SQL_Cuenta()
		{
		}
		
			
		#region MODIFICAR DATOS OPERADOR PARA CUENTA
		public Boolean modificarDatosCuenta(String ID_OPERADOR, String nombre, String apellido_mat, String apellido_pat, String curp, String rfc, String nss, String numeroInfonavit, 
		                              String correo, String lugar, String estado, String municipio, String fecha_na, String ID_SUELDO, String sueldo_base, String isr, String imss, String infonavit, String aguinaldo, String retener, 
		                              String compensacion, String primaVacacional, String ID_USUARIO)
		{	
			bool respuesta = true;
			String sentencia = "";
			
			String nombreOLD = "";
			String apellido_matOLD = "";
			String apellido_patOLD = "";
			String curpOLD = "";
			String rfcOLD = "";
			String nssOLD = "";
			String numeroInfonavitOLD = "";
			String correoOLD = "";
			String lugarOLD = "";
			String estadoOLD = "";
			String municipioOLD = "";
			String fechaNacimientoOLD = "";
			
			String sueldo_baseOLD = "";
			String isrOLD = "";
			String imssOLD = "";
			String infonavitOLD = "";
			String aguinaldoOLD = "";
			String retenerOLD = "";
			String compensacionOLD = "";
			String primaVacacionalOLD = "";
			
			try{			
				base.getAbrirConexion("select * from OPERADOR where ID = "+ID_OPERADOR);
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read()){
					nombreOLD = (base.leer["Nombre"].ToString());
					apellido_matOLD = (base.leer["Apellido_Mat"].ToString());
					apellido_patOLD = (base.leer["Apellido_Pat"].ToString());
					curpOLD = (base.leer["CURP"].ToString());
					rfcOLD = (base.leer["RFC"].ToString());
					nssOLD = (base.leer["IMSS"].ToString());
					numeroInfonavitOLD = (base.leer["NUM_INFONAVIT"].ToString());
					correoOLD = (base.leer["CORREO"].ToString());
					lugarOLD = (base.leer["Lugar_Nacimiento"].ToString());
					estadoOLD = (base.leer["Estado_Nacimiento"].ToString());
					municipioOLD = (base.leer["Municipio_Nacimiento"].ToString());
					fechaNacimientoOLD = (base.leer["Fecha_Nacimiento"].ToString());
				}
				base.conexion.Close();
				
				base.getAbrirConexion("select * from SUELDO where ID_OPERADOR = "+ID_OPERADOR+" and ID_SUELDO = "+ID_SUELDO);
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read()){
					sueldo_baseOLD = (base.leer["SUELDO_BASE"].ToString());
					isrOLD = (base.leer["ISR"].ToString());
					imssOLD = (base.leer["IMSS"].ToString());
					infonavitOLD = (base.leer["INFONAVIT"].ToString());
					aguinaldoOLD = (base.leer["aguinaldo"].ToString());
					retenerOLD = (base.leer["Retener"].ToString());
					compensacionOLD = (base.leer["Compensacion"].ToString());
					primaVacacionalOLD = (base.leer["prima_v"].ToString());
				}
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}

			if(respuesta){
				try{
					sentencia = "";			
					sentencia = "update OPERADOR set Nombre = '"+nombre+"', Apellido_Mat = '"+apellido_mat+"', Apellido_Pat = '"+apellido_pat+"', CURP = '"+curp+"', RFC = '"+rfc
									+"', IMSS = '"+nss+"', NUM_INFONAVIT = '"+numeroInfonavit+"', CORREO = '"+correo+"'  where ID = "+ID_OPERADOR;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception){
					respuesta = false;
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}
			
			if(respuesta){
				try{
					if(ID_SUELDO != "0"){
						sentencia = "update SUELDO set SUELDO_BASE = '"+sueldo_base+"', ISR = '"+isr+"', IMSS = '"+imss+"', INFONAVIT = '"+infonavit+"', aguinaldo = '"+aguinaldo
									+"', Retener = '"+retener+"', Compensacion = '"+compensacion+"', prima_v = '"+primaVacacional+"' where ID_SUELDO = "+ID_SUELDO+" and ID_OPERADOR = "+ID_OPERADOR;
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
			}
			
			if(respuesta){
				try{				
					sentencia = "INSERT INTO AUDITORIA_GENERAL VALUES('MODIFICO OPERADOR Y SUELDO', 'ID_OPERADOR :"+ID_OPERADOR+", nombre OLD :"+nombreOLD
								+", apellido mat OLD = "+apellido_matOLD+", apellido pat OLD = "+apellido_patOLD+", curp OLD = "+curpOLD+", rfc OLD = "+rfcOLD
								+", nss OLD = "+nssOLD+", numero Infonavit OLD = "+numeroInfonavitOLD+", correo OLD = "+correoOLD+", lugar OLD = "+lugarOLD
								+", estado OLD = "+estadoOLD+", municipio OLD = "+municipioOLD+", fecha Nacimiento OLD = "+fechaNacimientoOLD
								+", TABLA SUELDO: ID_SUELDO = "+ID_SUELDO+", sueldo base OLD = "+sueldo_baseOLD+", isr OLD = "+isrOLD+", imss OLD = "+imssOLD
								+", infonavit OLD = "+infonavitOLD+", aguinaldo OLD = "+aguinaldoOLD+", retener OLD = "+retenerOLD+", compensacion OLD = "+compensacionOLD
								+", prima Vacacional OLD = "+primaVacacionalOLD+"',(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"
								+ID_USUARIO+", 'OPERADOR Y SUELDO')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
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
		
		#region VALIDA CUENTA
		public Boolean ValidaCuenta(String ID_USUARIO, String ID_CUENTA)
		{	
			bool respuesta = true;
			try{
				String sentencia = "";			
				sentencia = "UPDATE CUENTA_BANCARIA SET VALIDA = 'VALIDADA', FECHA_VALIDACION  = (SELECT CONVERT (DATE, SYSDATETIME())) ,ID_USUARIO_VALIDACION = '"+ID_USUARIO+"'  where ID = "+ID_CUENTA;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				sentencia = "INSERT INTO AUDITORIA_GENERAL VALUES('VALIDO CUENTA', 'ID_CUENTA :"+ID_CUENTA+"',(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+ID_USUARIO+", 'CUENTA_BANCARIA')";
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
		
		#region INSERTAR CUENTA
		public Boolean insertarCuenta(String NUMERO, String ID_USUARIO, String ID_OPERADOR)
		{	
			bool respuesta = true;
			try{
				String sentencia = "insert into CUENTA_BANCARIA (NUMERO, FECHA, HORA, ID_USUARIO, ID_OPERADOR, VALIDA, ESTADO) values ('"+NUMERO+"', '"
								+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("hh:mm:ss")+"', "+ID_USUARIO+", "+ID_OPERADOR+", 'SIN VALIDAR', '1')";
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
		public Boolean modificarCuenta(String NUMERO, String ID_USUARIO, String ID_CUENTA, String NUMEROOLD)
		{	
			bool respuesta = true;
			try{
				String sentencia = "";			
				sentencia = "UPDATE CUENTA_BANCARIA SET Numero = '"+NUMERO+"', VALIDA = 'SIN VALIDAR' where ID = "+ID_CUENTA;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
				
				sentencia = "INSERT INTO AUDITORIA_GENERAL VALUES('MODIFICO CUENTA BANCARIA', 'ID_CUENTA :"+ID_CUENTA+", NUMERO DE CUENTA ANTERIOR: "+NUMEROOLD
							+"',(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+ID_USUARIO+", 'CUENTA_BANCARIA')";
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
	
		#region TRAER FECHA INGRESO OPERADOR
		public String FechaIngreso(String id_operador)
		{
			String Fecha = "";
			base.getAbrirConexion(@"select min(OC.FechaInicioContrato) as Ingreso from OperadorContrato OC where IdOperador ="+id_operador);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
				Fecha = base.leer["Ingreso"].ToString().Substring(0,10);
			else
				Fecha = "";				
			base.conexion.Close();			
			return Fecha;
		}
		#endregion
		
		#region TRAER ID CUENTA
		public string ReturnIdCuenta(String id)
		{
			string id_cuenta="";
			
			base.getAbrirConexion("select ID from CUENTA_BANCARIA WHERE ID_OPERADOR="+id);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
				id_cuenta = (base.leer["ID"].ToString());
            else
				id_cuenta = "0";
			base.conexion.Close();
			
			return id_cuenta;
		}
		#endregion
		
		#region TRAER NUMERO DE CUENTA BANCARIA
		public string ReturnNumero(String id){
			string numero = "";			
			base.getAbrirConexion("select NUMERO from CUENTA_BANCARIA WHERE ID_OPERADOR = "+id);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				numero = (base.leer["NUMERO"].ToString());
				if(numero.Length == 0)
					numero = "Vacío";
			}
            else
				numero = "Vacío";
			base.conexion.Close();
			
			return numero;
		}
		#endregion
		
		#region TRAER VALIDACION CUENTA
		public string ReturnValidaCuenta(String id)
		{
			string valida = "";			
			base.getAbrirConexion("select VALIDA from CUENTA_BANCARIA WHERE ID_OPERADOR="+id);
			base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
				valida = (base.leer["VALIDA"].ToString());
            else
				valida = "SIN VALIDAR";
			base.conexion.Close();	
			
			if(valida == null || valida == "" || valida == " " || valida == "0")
				valida = "SIN VALIDAR";
			return valida;
		}
		#endregion
		
	}
}
