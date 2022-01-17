using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Contrato
{
	public class SQL_Contrato:SQL_Conexion
	{
		public SQL_Contrato():base()
		{
		}
		
		public DataTable getTabla(string consulta){
			return base.getaAdaptadorTabla(consulta);
		}
		
		#region OBTENIENDO_PERSONAS_QUE_SE_HAN_REGISTRADO_COMO_PATRONES
		public List<string> getNombrePatron(){
			List<string> patron=new List<string>();
			getAbrirConexion("select NombrePatron from OperadorContrato group by NombrePatron");
			leer=comando.ExecuteReader();
			while(leer.Read()){
				patron.Add(leer["NombrePatron"].ToString());
			}
			conexion.Close();
			return patron;
		}
		#endregion
		
		#region OBTENER_DATOS_DEL_EMPLEADO
		public Interfaz.Operador.Dato.OperadorDato getDatosEmpleado(string empleado){
			Interfaz.Operador.Dato.OperadorDato objectEmpleado =new Interfaz.Operador.Dato.OperadorDato();
			getAbrirConexion("select (Nombre+' '+Apellido_Pat+' '+Apellido_Mat)as Nombre,((select DATEDIFF (DAY,(select Fecha_Nacimiento from OPERADOR WHERE ID="+empleado+"),(SELECT CONVERT (date, SYSDATETIME()))))/365) as Edad,Estado_Civil,Calle+' '+Num_Interior+' Col. '+Colonia+' '+Municipio+' C.P. '+CAST(CP as varchar) as Domicilio from OPERADOR where ID="+empleado);
			leer=comando.ExecuteReader();
			if(leer.Read()){
				objectEmpleado.nombre		=leer["Nombre"].ToString();
				objectEmpleado.edad			=leer["Edad"].ToString();
				objectEmpleado.estadoCivil	=leer["Estado_Civil"].ToString();
				objectEmpleado.domicilio	=leer["Domicilio"].ToString();
			}
			conexion.Close();
			return objectEmpleado;
		}
		#endregion
		
		#region OBTENER_DATOS_DE_EMPLEADO_ÚLTIMO_CONTRATO_CREADO
		public Interfaz.Operador.Dato.OperadorContrato getContratoEmpleado(string empleado){
			Interfaz.Operador.Dato.OperadorContrato objectEmpleado=new Transportes_LAR.Interfaz.Operador.Dato.OperadorContrato();
			getAbrirConexion("select Nacionalidad,Sexo,ServicioPersonal,LugarDesempeno,DuracionJornada,Tarifa,ImpuestoRenta,DiasPago,LugarPaga,LoFirmaPor,LugarFirma,TiempoCelebracion,Vacaciones from OperadorContrato where ID='"+empleado+"'");
			leer=comando.ExecuteReader();
			if(leer.Read()){
				objectEmpleado.nacionalidad			=leer["Nacionalidad"].ToString();
				objectEmpleado.sexo					=leer["Sexo"].ToString();
				objectEmpleado.servicioPersonal		=leer["ServicioPersonal"].ToString();
				objectEmpleado.lugarDesempeno		=leer["LugarDesempeno"].ToString();
				objectEmpleado.duracionJornada		=leer["DuracionJornada"].ToString();
				objectEmpleado.tarifa				=leer["Tarifa"].ToString();
				objectEmpleado.impuestoRenta		=leer["ImpuestoRenta"].ToString();
				objectEmpleado.diaPago				=leer["DiasPago"].ToString();
				objectEmpleado.lugarPago			=leer["LugarPaga"].ToString();
				objectEmpleado.firmaPor				=leer["LoFirmaPor"].ToString();
				objectEmpleado.lugarFirma			=leer["LugarFirma"].ToString();
				objectEmpleado.tiempoCelebracion	=leer["TiempoCelebracion"].ToString();
				objectEmpleado.vacaciones			=leer["Vacaciones"].ToString();
				conexion.Close();
				return objectEmpleado;
			}
			conexion.Close();
			return null;
		}
		
		#endregion
		
		#region GENERANDO_MODELO_PARA_CARGAR_EL_AUTOCOMPLETABLE
		public AutoCompleteStringCollection LoadAutoComplete(){
            DataTable tabla = getTabla("select NombrePatron from OperadorContrato group by NombrePatron");
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (DataRow row in tabla.Rows){
            	stringCol.Add(Convert.ToString(row["NombrePatron"]));
            }
            return stringCol;
        }
		#endregion
		
		#region OBTENER_DATOS_DEL_PATRON
		public Interfaz.Operador.Dato.Patron getDatosPatron(string patron){
			Interfaz.Operador.Dato.Patron objectPatron=new Transportes_LAR.Interfaz.Operador.Dato.Patron();
			getAbrirConexion("select NombrePatron, NS_Patron,NacionalidadPatron,EdadPatron,SexoPatron,EstadoCivilPatron,DomicilioPatron from OperadorContrato where NS_Patron='"+patron+"' or NombrePatron='"+patron+"'");
			leer=comando.ExecuteReader();
			if(leer.Read()){
				objectPatron.Nombre			=leer["NombrePatron"].ToString();
				objectPatron.Ns				=leer["NS_patron"].ToString();
				objectPatron.nacionalidad	=leer["NacionalidadPatron"].ToString();
				objectPatron.edad			=leer["EdadPatron"].ToString();
				objectPatron.sexo			=leer["SexoPatron"].ToString();
				objectPatron.estadoCivil	=leer["EstadoCivilPatron"].ToString();
				objectPatron.domicilio		=leer["DomicilioPatron"].ToString();
				conexion.Close();
				return objectPatron;
			}
			conexion.Close();
			return null;
		}
		 #endregion
		 
		#region ALMACENAR_CONTRATO_DE_OPERADOR
		public void getAlmacenarContrato(string IdOperador,
		                                 string FechaInicioContrato,
		                                 string NombrePatron,
		                                 string Ns,
		                                 string NacionalidadPatron,
		                                 string EdadPatron,
		                                 string SexoPatron,
		                                 string EstadoCivilPatron,
		                                 string DomicilioPatron,
		                                 string Nacionalidad,
		                                 string Sexo,
		                                 string TiempoCelebracion,
		                                 string ServicioPersonal,
		                                 string LugarDesempeno,
		                                 string DuracionJornada,
		                                 string Tarifa,
		                                 string ImpuestoRenta,
		                                 string DiasPago,
		                                 string LugarPaga,
		                                 string Vacaciones,
		                                 string LoFirmaPor,
		                                 string LugarFirma,
		                                 string Elaboro,
		                                 string TipoContrato,
		                                 string Fecha_vencimiento)
		{
			String A = FechaInicioContrato;
			FechaInicioContrato = A.Substring(0,10);
			getAbrirConexion("execute almacenar_Contrato "+IdOperador+" ,'"+FechaInicioContrato	+"','"
	                 													 +NombrePatron			+"','"
														                 +NacionalidadPatron	+"','"
														                 +EdadPatron			+"','"
														                 +SexoPatron			+"','"
														                 +EstadoCivilPatron		+"','"
														                 +DomicilioPatron		+"','"
														                 +Nacionalidad			+"','"
														                 +Sexo					+"','"
														                 +TiempoCelebracion		+"','"
														                 +ServicioPersonal		+"','"
														                 +LugarDesempeno		+"','"
														                 +DuracionJornada		+"','"
														                 +Tarifa				+"','"
														                 +ImpuestoRenta			+"','"
														                 +DiasPago				+"','"
														                 +LugarPaga				+"','"
														                 +Vacaciones			+"','"
														                 +LoFirmaPor			+"','"
														                 +LugarFirma			+"','"
														                 +Elaboro				+"','"
														                 +TipoContrato			+"','"
														                 +Ns          			+"','"
																		 +Fecha_vencimiento		+"'");
			comando.ExecuteNonQuery();
			conexion.Close();
		}
		#endregion
		
		#region ACTUALIZAR_DATOS_DEL_CONTRATO
		public void getOperadorModificar(string ID,
		                                 string FechaInicioContrato,
										 string NombrePatron,
										 string Ns,
		                                 string NacionalidadPatron,
		                                 string EdadPatron,
		                                 string SexoPatron,
		                                 string EstadoCivilPatron,
		                                 string DomicilioPatron,
		                                 string Nacionalidad,
		                                 string Sexo,
		                                 string TiempoCelebracion,
		                                 string ServicioPersonal,
		                                 string LugarDesempeno,
		                                 string DuracionJornada,
		                                 string Tarifa,
		                                 string ImpuestoRenta,
		                                 string DiasPago,
		                                 string LugarPaga,
		                                 string Vacaciones,
		                                 string LoFirmaPor,
		                                 string LugarFirma,
		                                 string TipoContrato,
		                                 string Fecha_vencimiento){
			String A = FechaInicioContrato;
			FechaInicioContrato = A.Substring(0,10);
			string sentencia="";
			sentencia = ("update Operadorcontrato set       NombrePatron=				'"+NombrePatron+
			             								"',  FechaInicioContrato =	   '"+FechaInicioContrato+
													    "',  NacionalidadPatron	=		'"+NacionalidadPatron+
													    "',  EdadPatron	=				'"+EdadPatron+
														"',  SexoPatron	=				'"+SexoPatron				+
														"',  EstadoCivilPatron	=		'"+EstadoCivilPatron		+
														"',  DomicilioPatron=			'"+DomicilioPatron		+
														"',  Nacionalidad=				'"+Nacionalidad			+
														"',  Sexo=						'"+Sexo					+
														"',  TiempoCelebracion=			'"+TiempoCelebracion		+
														"',  ServicioPersonal	=		'"+ServicioPersonal		+
														"',  LugarDesempeno		=		'"+LugarDesempeno			+
														"',  DuracionJornada	=		'"+DuracionJornada		+
														"',  Tarifa		=				'"+Tarifa					+
														"',  ImpuestoRenta	=			'"+ImpuestoRenta			+
														"',  DiasPago	=				'"+DiasPago				+
														"',  LugarPaga	=				'"+LugarPaga				+
														"',  Vacaciones	=				'"+Vacaciones				+
														"',	 LoFirmaPor	=				'"+LoFirmaPor				+
														"',  LugarFirma	=				'"+LugarFirma				+
														"',  TipoContrato=				'"+TipoContrato			+
														"',  NS_Patron=					'"+Ns			+
														"',  fecha_vencimiento=			'"+Fecha_vencimiento			+
														"'where ID = '"+ID+"'");
			                 	
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close(); 
		}
		#endregion
		
		public void EliminarContrato(int id)
		{
			base.getAbrirConexion("delete from OPERADORCONTRATO where ID="+id);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public String TipoContrato(String id_operador)
		{
			String Tipo = "";
			base.getAbrirConexion("select TipoContrato " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' and O.Alias!='ADMINOO' " +
			                      "and O.ID ="+id_operador);
			base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					Tipo = base.leer["TipoContrato"].ToString();
				}
			base.conexion.Close();
			
			return Tipo;
		}
		
	}
}
