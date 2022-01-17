using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Unidad
{
	public class SQL_Unidad:Conexion_Servidor.SQL_Conexion
	{
		#region CONSTRUCTOR
		public SQL_Unidad():base(){
		}
		#endregion
		
		#region ADAPTADOR_DE_TABLA
		public DataTable getTabla(string consulta){
			return base.getaAdaptadorTabla(consulta);
		}
		#endregion
		
		#region CARGAR_CATEGORIAS
		public List<Interfaz.Unidad.Dato.Categoria> getCategoria(){
			List<Interfaz.Unidad.Dato.Categoria> categoria=new List<Transportes_LAR.Interfaz.Unidad.Dato.Categoria>();
			base.getAbrirConexion("select ID,Nombre from CATEGORIAEQUIPO");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read()){
				Interfaz.Unidad.Dato.Categoria datoCategoria=new Interfaz.Unidad.Dato.Categoria();
				datoCategoria.idCategoria	=base.leer["ID"].ToString();
				datoCategoria.nombre		=base.leer["Nombre"].ToString();
				categoria.Add(datoCategoria);
			}
			return categoria;
		}
		#endregion
		
		#region BUSCA_SI_EXISTE_EL_NUMERO_DE_UNIDAD_REGISTRADO
		public bool getNumUnidad(string numUnidad){
			base.getAbrirConexion("select Numero from VEHICULO where Numero='"+numUnidad+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				base.conexion.Close();
				return true;
			}
			base.conexion.Close();
			return false;				
		}
		#endregion
		
		#region INSERTAR_CONSULTAR ( UNIDAD )
		public void getInsertUnidad(string id,
		                            string numero,
		                            string estatal,
		                            string federal,
		                            string tipoUnidad,
		                            string tipoServicio,
		                            string propietario,
		                            string marca,
		                            string modelo,
		                            string numSerie,
		                            string ano,
		                            string nombreMotor,
		                            string modeloMotor,
		                            string numSerieMotor,
		                            string diferencial,
		                            string pasoDiferencial,
		                            string tipoLlanta,
		                            string perimetroLlanta,
		                            string potenciaVehiculo,
		                            string cajaNombre,
		                            string cajaModelo,
		                            string uRelacion,
		                            string torqueVehiculo,
		                            string capacidadTanque,
		                            string redimientoOptimo,
		                            string capacidad, 
		                            int USU
		                           ){
			id=(id=="")?"NULL":id;
						
			if(id != "" && id != "NULL"){
				try{
					string placaE =  "";
					string placaF =  "";
					base.getAbrirConexion("select * from VEHICULO where ID = "+id);
					base.leer = base.comando.ExecuteReader();
					if(base.leer.Read()){										
						placaE = base.leer["Placa_Estatal"].ToString();
						placaF = base.leer["Placa_Federal"].ToString();
					}
					base.conexion.Close();	
					
					base.getAbrirConexion(@"INSERT INTO AUDITORIA_GENERAL VALUES('UPDATE', 'MODIFICO PLACAS DE UNIDAD ESTATAL:"+estatal+", FEDERAL = "+federal+" ID_V ="+id
					                      +"' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+USU+", 'VEHICULO')");
					base.comando.ExecuteNonQuery();
					base.conexion.Close();					
				}catch(Exception ){
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}			
			
			base.getAbrirConexion("execute almacenar_modificar_unidad "+id+","+
			                      "'"+numero			+"',"+
			                      "'"+federal			+"',"+
			                      "'"+estatal			+"',"+
			                      "'"+tipoUnidad		+"',"+
			                      "'"+tipoServicio		+"',"+
			                      "'"+propietario		+"',"+
			                      "'"+marca				+"',"+
			                      "'"+modelo			+"',"+
			                      "'"+numSerie			+"',"+
			                      "'"+ano				+"',"+
			                      "'"+nombreMotor		+"',"+
			                      "'"+modeloMotor		+"',"+
			                      "'"+numSerieMotor		+"',"+
			                      "'"+diferencial		+"',"+
			                      "'"+pasoDiferencial	+"',"+
			                      "'"+tipoLlanta		+"',"+
			                      "'"+perimetroLlanta	+"',"+
			                      "'"+potenciaVehiculo	+"',"+
			                      "'"+cajaNombre		+"',"+
			                      "'"+cajaModelo		+"',"+
			                      "'"+uRelacion			+"',"+ 
			                      "'"+torqueVehiculo	+"',"+
			                      "'"+capacidadTanque 	+"',"+
			                      "'"+redimientoOptimo	+"',"+
			                      "'"+capacidad			+"'" 
			                     );
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void getSelectUnidad(string idUnidad,
		                            TextBox numero,
		                            TextBox placaEstatal,
		                            TextBox placaFederal,
		                            RadioButton tipoUnidad,
		                            RadioButton tipoServicio,
		                            TextBox propietario,
		                            TextBox marca,
		                            TextBox modelo,
		                            TextBox ano,
		                            TextBox numSerie,
		                            TextBox nombreMotor,
		                            TextBox modeloMotor,
		                            TextBox numSerieMotor,
		                            TextBox diferencia,
		                            TextBox pasoDiferencial,
		                            TextBox tipoLLanta,
		                            TextBox perimetroLlanta,
		                            TextBox potenciaVehiculo,
		                            TextBox cajaNombre,
		                            TextBox cajaModelo,
		                            TextBox uRelacion,
		                            TextBox torqueVehiculo,
		                            TextBox capacidadTanque,
		                            TextBox rendimientoOptimo,
		                            TextBox capacidad
		                           ){
			base.getAbrirConexion("select Numero," 		+
			                      "Placa_Estatal," 		+
			                      "Placa_Federal," 		+
			                      "Tipo_Unidad," 		+
			                      "Tipo_Servicio," 		+
			                      "Propietario," 		+
			                      "Marca," 				+
			                      "Modelo," 			+
			                      "Ano," 				+
			                      "Numero_Serie," 		+
			                      "Motor_Nombre," 		+
			                      "Motor_Modelo," 		+
			                      "Motor_Num_Serie," 	+
			                      "Diferencial," 		+
			                      "Paso_Diferencial," 	+
			                      "Tipo_Llanta," 		+
			                      "Perimetro_Llanta," 	+
			                      "Potencia_Vehiculo," 	+
			                      "Caja_Nombre," 		+
			                      "Caja_Modelo," 		+
			                      "U_Relacion," 		+
			                      "Torque_Vehiculo," 	+
			                      "Capacidad_Tantque," 	+
			                      "Rendimiento_Optimo," +
			                      "Capacidad " 			+
								  "from VEHICULO where ID="+idUnidad);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				numero.Text					=leer["Numero"].ToString();
		        placaEstatal.Text			=leer["Placa_Estatal"].ToString();
		        placaFederal.Text			=leer["Placa_Federal"].ToString();
		        
		        tipoUnidad.Checked			=(leer["Tipo_Unidad"].ToString()=="Camioneta")?true:false;
		      	tipoServicio.Checked		=(leer["Tipo_Servicio"].ToString()=="Local")?true:false;
		        
		      	propietario.Text			=leer["Propietario"].ToString();
		        marca.Text					=leer["Marca"].ToString();
		        modelo.Text					=leer["Modelo"].ToString();
		        ano.Text					=leer["Ano"].ToString();
		        numSerie.Text				=leer["Numero_Serie"].ToString();
		        nombreMotor.Text			=leer["Motor_Nombre"].ToString();
		        modeloMotor.Text			=leer["Motor_Modelo"].ToString();
		        numSerieMotor.Text			=leer["Motor_Num_Serie"].ToString();
		        diferencia.Text				=leer["Diferencial"].ToString();
		        pasoDiferencial.Text		=leer["Paso_Diferencial"].ToString();
		        tipoLLanta.Text				=leer["Tipo_Llanta"].ToString();
		        perimetroLlanta.Text		=leer["Perimetro_Llanta"].ToString();
		        potenciaVehiculo.Text		=leer["Potencia_Vehiculo"].ToString();
		        cajaNombre.Text				=leer["Caja_Nombre"].ToString();
		        cajaModelo.Text				=leer["Caja_Modelo"].ToString();
		        uRelacion.Text				=leer["U_Relacion"].ToString();
		        torqueVehiculo.Text			=leer["Torque_Vehiculo"].ToString();
		        capacidadTanque.Text		=leer["Capacidad_Tantque"].ToString();
		        rendimientoOptimo.Text		=leer["Rendimiento_Optimo"].ToString();
		        capacidad.Text				=leer["Capacidad"].ToString();
			}
			base.conexion.Close();
			return;
		}
		
		#endregion
		
	 	#region OBTENER_ID_DEL_VEHÍCULO
	 	public string getId(string numUnidad){
	 		base.getAbrirConexion("select ID from VEHICULO where Numero='"+numUnidad+"'");
	 		base.leer=comando.ExecuteReader();
	 		if(base.leer.Read()){
	 			numUnidad=base.leer["ID"].ToString();
	 		}
	 		base.conexion.Close();
	 		return numUnidad;
	 	}
		#endregion
		
		/////////////////////////////////////////////////////////////  VERIFICACIONES  ////////////////////////////////////////////////////////////////
		
		#region VEHICULO VERIFICACIONES	
		public bool InsertarPeriodos(string ID_VEHICULO, string PLACA_ACTUAL, string VERIFICACION_PERIODO1, string VERIFICACION_PERIODO2, string FISICO_MECANICO_PERIODO){
			string sentencia ="";
			bool respuesta = true;
			try{
				sentencia = "INSERT INTO VEHICULOS_PERIODOS (ID_VEHICULO, PLACA_ACTUAL, VERIFICACION_PERIODO1, VERIFICACION_PERIODO2, FISICO_MECANICO_PERIODO, ESTATUS)" +
							"VALUES('"+ID_VEHICULO+"','"+PLACA_ACTUAL+"','"+VERIFICACION_PERIODO1+"','"+VERIFICACION_PERIODO2+"','"+FISICO_MECANICO_PERIODO+"','1')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}
			return respuesta;
		}
		
		public bool InsertarPeriodos2(string REFRENDO_PERIODO, string PERMISO_PERIODO, string POLIZA_PERIODO1, string POLIZA_PERIODO2, string CASETA1, string CASETA2 ){
			string sentencia ="";
			bool respuesta = true;
			try{
				sentencia ="INSERT INTO VEHICULOS_PERIODOS (REFRENDO_PERIODO, PERMISO_PERIODO, POLIZA_PERIODO1, POLIZA_PERIODO2, CASETA1, CASETA2)" +
						   "VALUES('"+REFRENDO_PERIODO+"','"+PERMISO_PERIODO+"', '"+POLIZA_PERIODO1+"', '"+POLIZA_PERIODO2+"', '"+CASETA1+"', '"+CASETA2+"')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception){
				respuesta = false ;
			}
			return respuesta;
		}
		
		public void insertarValidacion1(string ID_VEHICULO, string PERIODO1, string PERIODO2, string tipoP){
			string sentencia ="";
			try{		
				if(tipoP == "E")				
				sentencia = "INSERT INTO Vehiculos_Verificacion (ID_VEHICULO, PERIODO1, PERIODO2, ESTATUS) " +
					"VALUES('"+ID_VEHICULO+"','"+PERIODO1+"','"+PERIODO2+"', Placa_Estatal = '1',  Placa_Federal = '0', '1')";
				if(tipoP == "F")
					sentencia = "INSERT INTO Vehiculos_Verificacion (ID_VEHICULO, PERIODO1, PERIODO2, ESTATUS) " +
					"VALUES('"+ID_VEHICULO+"','"+PERIODO1+"','"+PERIODO2+"', Placa_Estatal = '0',  Placa_Federal = '1', '1')";
				
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR EN Vehiculos_Verificacion: "+ex.Message);
			}
		}
	
		public bool modificaVerificacion(string periodo1, string periodo2, string ID, string tipoP){			
			bool respuesta = true;
			string sentencia = "";
			try{
				sentencia =  "update VEHICULOS_PERIODOS set VERIFICACION_PERIODO1 = '"+periodo1+"', VERIFICACION_PERIODO2 = '"+periodo2+"', PLACA_ACTUAL = '"+tipoP+"' where ID_VEHICULO ="+ID;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}
			return respuesta;
		}
		
		public bool modificaVerificacionCampo(string Campo, string VCampo, string ID){			
			bool respuesta = true;
			string sentencia = "";
			try{
				sentencia =  "update VEHICULOS_PERIODOS set "+Campo+" = '"+VCampo+"' where ID_VEHICULO ="+ID;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}
			return respuesta;
		}
		
		#endregion
		
		#region INSERTAR VALIDACIÓN	
		public bool insertarValidacion(string ID_VEHICULOS_PERIODOS, string FECHA_VALIDACION, string DETALLE, string ID_USUARIO, string TIPO_GESTION ){
			string sentencia ="";
			bool respuesta = true;
			try{								
				sentencia = "INSERT INTO HISTORIAL_PERIODOS (ID_VEHICULOS_PERIODOS, FECHA_VALIDACION, DETALLE, ID_USUARIO, FECHA_REGISTRO, HORA_REGISTRO, TIPO_GESTION, ESTATUS) VALUES('"
				+ID_VEHICULOS_PERIODOS+"','"+FECHA_VALIDACION+"','"+DETALLE+"', '"+ID_USUARIO+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+TIPO_GESTION+"', '1')";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR AL INSERTAR LA VALIDACIÓN: "+ex.Message);
				respuesta = false;
			}
			return respuesta;
		}
		#endregion
		
		public string obtenerTipoU(string numUnidad){
	 		base.getAbrirConexion("select Tipo_Unidad from VEHICULO where Numero='"+numUnidad+"'");
	 		base.leer=comando.ExecuteReader();
	 		if(base.leer.Read()){
	 			numUnidad = base.leer["Tipo_Unidad"].ToString();
	 		}
	 		base.conexion.Close();
	 		return numUnidad;
	 	}
		
		
		#region PARAMETROS		
		public void modificarParametrosGestoria(string parametro, Int16 id){			
			String consul = "update PARAMETROS_GESTORIA_V set  PARAMETRO1 = '"+parametro+"' where ID = "+id;
			base.getAbrirConexion(consul); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();	
		}
		
		public String obtenerParametro1(string nombre){			
			string parametro = "0";			
			base.getAbrirConexion("select PARAMETRO1 from PARAMETROS_GESTORIA_V where NOMBRE LIKE '%"+nombre+"%'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametro = base.leer["PARAMETRO1"].ToString();
			}
			base.conexion.Close();			
			return parametro;			
		}
		
		public String obtenerParametro2(string nombre){			
			string parametro = "";			
			base.getAbrirConexion("select PARAMETRO1 from PARAMETROS_GESTORIA_V where NOMBRE LIKE '%"+nombre+"%'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametro = base.leer["PARAMETRO1"].ToString();
			}
			base.conexion.Close();			
			return parametro;			
		}
		
		public void modificarParametros(string nombre, string parametro1, string parametro2,  string observ, Int16 id, Int32 id_usuario){
			string nombreOLD = "";
			string parametroOLD = "";
			string observacionOLD = "";
			
			base.getAbrirConexion("select * from PARAMETROS_GESTORIA_V where ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				nombreOLD = base.leer["NOMBRE"].ToString();
				parametroOLD = base.leer["PARAMETRO1"].ToString();
				parametroOLD = base.leer["PARAMETRO2"].ToString();
				observacionOLD = base.leer["OBSERVACIONES"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo los parametros. Parametros Viejos NOMBRE: "+nombreOLD+", PARAMETRO 1: "+parametroOLD+", PARAMETRO 2: "+parametroOLD+", OBSERVACIONES: "+observacionOLD+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'PARAMETROS_GESTORIA_V')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
			
			String consul = "update PARAMETROS_VENTAS set NOMBRE = '"+nombre+"', PARAMETRO1 = '"+parametro1+"', PARAMETRO2 = '"+parametro2+"', OBSERVACIONES = '"+observ+"' where ID = "+id;
			base.getAbrirConexion(consul); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();	
		}
		#endregion
		
		
		#region ELIMINAR UNIDAD
		public void eliminaUnidad(Int32 id_u, Int32 id_usuario){
			try{
				string consul = "INSERT INTO AUDITORIA_GENERAL  VALUES('DELETE', 'ELIMINO LA UNIDAD : "+id_u+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+id_usuario+", 'VEHICULO')";
				base.getAbrirConexion(consul);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();			
				
				consul = "update VEHICULO set estatus = '0', estado = '0' where ID = "+id_u;
				base.getAbrirConexion(consul); 
				base.comando.ExecuteNonQuery(); 
				base.conexion.Close();	
			}catch(Exception){
			        	
			}				
		}
		#endregion
	}
}
