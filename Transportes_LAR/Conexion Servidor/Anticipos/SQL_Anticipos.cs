using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Threading;


namespace Transportes_LAR.Conexion_Servidor.Anticipos
{
	public class SQL_Anticipos:SQL_Conexion
	{
		#region CONSTRUCTOR
		public SQL_Anticipos()
		{
			
		}
		#endregion
		
		#region TRAER ID DESCUENTO
		public string MaxID()
		{
			string id_descuento="";
			
			base.getAbrirConexion("select max(ID) ID from DESCUENTO");
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            {
				id_descuento = (base.leer["ID"].ToString());
				if(id_descuento=="")
				{
					id_descuento="0";
				}
			}
			base.conexion.Close();
			
			return id_descuento;
		}
		#endregion
		
		#region EXISTENCIA HISTORIAL
		public bool TraerExistencia(String ID_OPERADOR, String FechaInicio, String FechaFin)
		{
			bool existencia=false;
			
				base.getAbrirConexion("select HS.ID from SALDO_ANTICIPOS S, HISTORIAL_SALDO HS WHERE HS.ID_SALDO=S.ID AND FECHAINICIO ='"+FechaInicio.ToString().Substring(0,10)+"' and FECHAFIN ='"+FechaFin.ToString().Substring(0,10)+"' AND S.ID_OPERADOR="+ID_OPERADOR);
				base.leer=base.comando.ExecuteReader();
	            if(base.leer.Read())
	            {
					if((base.leer["ID"].ToString())=="")
					{
						existencia=false;
					}
					else
					{
						existencia=true;
					}
				}
				base.conexion.Close();
			
			return existencia;
		}
		#endregion
		
		#region TRAER FECHA INGRESO
		public string MinFecha(int id, string fechaI, string fechaF)
		{
			string booleano="";
			
			base.getAbrirConexion("select min(FechaInicioContrato) fecha from OPERADOR O, OperadorContrato OC WHERE O.ID=OC.IdOperador and OC.ID not in (select ID from OperadorContrato where FechaInicioContrato BETWEEN '"+fechaI.ToString().Substring(0,10)+"' and '"+fechaF.ToString().Substring(0,10)+"') and O.ID="+id);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            {
				booleano = (base.leer["fecha"].ToString());
				if(booleano!="")
					booleano="20";
				else
					booleano="0";
			}
			base.conexion.Close();
			
			return booleano;
		}
		
		public string FechaIngreso(String id)
		{
			string booleano="";
			
			base.getAbrirConexion("select min(FechaInicioContrato) fecha from OPERADOR O, OperadorContrato OC WHERE O.ID=OC.IdOperador and O.ID="+id);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	booleano = (base.leer["fecha"].ToString().Substring(0,10));
			}
			base.conexion.Close();
			
			return booleano;
		}
		#endregion
		
		#region INSERTAR DESCUENTO
		public void InsertarDescuento(long ID, String DESCRIPCION, String TIPO, double IMPORTE_TOTAL, int id_User, String Observacion)
		{
			base.getAbrirConexion("insert into DESCUENTO (ID_OPERADOR, DESCRIPCION, TIPO, IMPORTE_TOTAL, ID_USUARIO, OBSERVACION) values ("+ID+", '"+DESCRIPCION+"', '"+TIPO+"', '"+IMPORTE_TOTAL+"', "+id_User+", '"+Observacion+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Insertados correctamente");
			mensaje.Show();
		}
		
		public void InsertarDescuentoDetalle(String ID, String Fecha, String NOMENCLATURA, double IMPORTE)
		{
			base.getAbrirConexion("insert into DESCUENTO_DETALLE (ID_DESCUENTO, FECHA, NOMENCLATURA, IMPORTE, FLUJO) values ("+ID+", '"+Fecha+"', '"+NOMENCLATURA+"', '"+IMPORTE+"', '0')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void InsertarDescuentoEmpresa(String ID, String EMPRESA, String TIPO)
		{
			base.getAbrirConexion("insert into DESCUENTO_EMPRESA (ID_DESCUENTO, EMPRESA, TIPO) values ("+ID+", '"+EMPRESA+"', '"+TIPO+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region ELIMINAR DESCUENTO
		public void EliminarDescuento(String ID, String ID_USUARIO, String MOTIVO)
		{
			base.getAbrirConexion("delete from HISTORIAL_TOTALIZADO where ID_DESCUENTO="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("UPDATE DESCUENTO_DETALLE SET FLUJO='5' where ID_DESCUENTO="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("UPDATE DESCUENTO SET ID_USUARIO='"+ID_USUARIO+"', OBSERVACION='El motivo de la eliminacion es : "+MOTIVO+"' where ID="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron eliminados correctamente");
			mensaje.Show();
		}
		#endregion
		
	 	#region ANTICIPOS - NOMINA 
		public void UpdateAnticipos(String ID_OPERADOR, String FechaInicio, String FechaFin, String Anticipo)
		{
			string sentencia = "";
			sentencia = "UPDATE NOMINA SET Anticipos='"+Anticipo+"' where fecha_inicio='"+FechaInicio+"' AND fecha_fin='"+FechaFin+"' and IdOperador="+ID_OPERADOR;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
		}
		
		public String ExistenciaNomina(String ID_OPERADOR, String FechaInicio, String FechaFin)
		{
			String IDNOMINA="";
			string sentencia = "";
			sentencia = "SELECT ID FROM NOMINA where fecha_inicio='"+FechaInicio+"' AND fecha_fin='"+FechaFin+"' and IdOperador="+ID_OPERADOR;
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
	            if(base.leer.Read())
					IDNOMINA = (base.leer["ID"].ToString());

			base.conexion.Close();
				
			return IDNOMINA;
		}
		#endregion
		
		#region MODIFICAR DESCUENTOS
		public void UpdateFechaAnticipos(String Fecha, String id, String id_usuario)
		{
			string sentencia = "";
			sentencia = "UPDATE DESCUENTO_DETALLE SET FECHA='"+Fecha+"', NOMENCLATURA=NOMENCLATURA+' Sig' "+id_usuario+" where ID="+id;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
			mensaje.Show();
		}
		#endregion
		
		#region MOVER PAGO
		public void InsertarCancelacionPago(String id_descuento, String id_usuario)
		{
			string sentencia = "";
			sentencia = "insert into HISTORIAL_CANCELACION_PAGO values("+id_descuento+","+id_usuario+",'"+DateTime.Now.ToShortDateString()+"')";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
		}
		#endregion
		
		#region TRAER DESCUENTO NOMINAL - DESCUENTO
		public double TraerDescuentoNominal(String FechaInicio, String ID_D, String tipo)
		{
			double saldo = 0.00;
			string sentencia = "";
			if(tipo=="PRESTAMO" || tipo=="CHOQUE")
			{
			sentencia = "select DT.IMPORTE " +
						"from DESCUENTO D, DESCUENTO_DETALLE DT " +
						"where D.ID=DT.ID_DESCUENTO "+
						"and DT.FECHA>'"+(Convert.ToDateTime(FechaInicio).AddDays(1).ToShortDateString())+"' and DT.ID_DESCUENTO="+ID_D;
			}
			else
			{
			sentencia = "select DT.IMPORTE " +
						"from DESCUENTO D, DESCUENTO_DETALLE DT " +
						"where D.ID=DT.ID_DESCUENTO "+
						"and DT.FECHA>'"+(Convert.ToDateTime(FechaInicio).AddDays(1).ToShortDateString())+"' and DT.ID_DESCUENTO="+ID_D;
			}
			
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
		    while(base.leer.Read())
            {
		    	saldo =  saldo + (Convert.ToDouble(base.leer["IMPORTE"].ToString()));
			}
			base.conexion.Close();
			
			return saldo;
		}
		#endregion
		
		#region EXISTENCIA TRAMITE ACTIVO
		public bool TraerTramite(String ID, String FechaInicio, String FechaFin, String TIPO)
		{
			bool tramite = false;
			string sentencia = "";
			string dato = "";
			
			sentencia = "select D.ID_OPERADOR from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                    "and FLUJO!='5' and DT.FECHA between '"+FechaInicio+"' AND '"+FechaFin+"' and D.ID_OPERADOR="+ID+" and D.tipo='"+TIPO+"'";
			
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
            {
				dato = (base.leer["ID_OPERADOR"].ToString());
				
				if(dato!="")
					tramite = true;
				else
					tramite = false;

			}
			base.conexion.Close();
			
			return tramite;
		}
		#endregion
		
		#region EXISTENCIA DESCUENTO RETROCESO
		public bool TraerRetrocesoDescuento(String ID_operador, String FechaInicio, String FechaFin, String ID_DESCUENTO)
		{
			bool descuento = false;
			string sentencia = "";
			string dato = "";
			
			sentencia = "select D.ID_OPERADOR from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                    "and DT.FECHA between '"+FechaInicio+"' AND '"+FechaFin+"' and D.ID_OPERADOR="+ID_operador+" and D.ID="+ID_DESCUENTO;
			
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
            {
				dato = (base.leer["ID_OPERADOR"].ToString());
				
				if(dato!="")
					descuento = true;
				else
					descuento = false;

			}
			base.conexion.Close();
			
			return descuento;
		}
		#endregion
		
		#region FECHA DISPONIBLE UNIFORME
		public String TraerFechaDisponibleUniforme(String ID)
		{
			string sentencia = "";
			string fecha = "";
			
			sentencia = "select MAX(DT.FECHA) AS FECHADESCUENTO " +
						"from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O " +
						"where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                    "and D.ID_OPERADOR="+ID+" and D.tipo='U'";
			
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
            {
		    	fecha = (Convert.ToDateTime(base.leer["FECHADESCUENTO"]).AddDays(14)).ToString("dd-MM-yyyy");
			}
			base.conexion.Close();
			
			return fecha;
		}
		#endregion
		
		#region MODIFICAR IMPORTE - DESCUENTOS
		public void ActualizarValores(String ID, String SALDO)
		{
			string sentencia = "";
			sentencia = "UPDATE VALOR_IMPORTE SET SALDO='"+SALDO+"' where ID="+ID;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
			mensaje.Show();
		}
		#endregion
		
		#region TOTALIZADO DESCUENTOS
		public void ActualizarTotalizadoDescuento(String ID)
		{
			string sentencia = "";
			sentencia = "UPDATE DESCUENTO_DETALLE SET FLUJO='3' where ID="+ID;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void InsertarHistorialTotalizado(String id_totalizado, String id_descuento)
		{
			string sentencia = "";
			sentencia = "insert into HISTORIAL_TOTALIZADO values("+id_totalizado+","+id_descuento+")";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
		}
		#endregion
		
		#region AUDITORIA DESCUENTOS
		public String TraerAyuda(String id_descuento)
		{
			String Dato = "";
			
			base.getAbrirConexion("select FECHA, HORA " +
			                      "from AUDITORIA_DESCUENTOS " +
			                      "WHERE ID_DESCUENTO="+id_descuento);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	Dato = "Fecha: "+base.leer["FECHA"].ToString().Substring(0,10)+" Hora: "+base.leer["HORA"];
			}
			base.conexion.Close();
			
			return Dato;
		}
		#endregion
		
		#region INSERTAR DETALLE_TAXI
		public void InsertarDescuentoTaxi(String ID, String Fecha_Pago, String Fecha_Taxi, String Empresa, String Ruta, String Turno, double IMPORTE, String Id_unidad, String Estado)
		{
			base.getAbrirConexion("insert into DESCUENTO_TAXI(ID_DESCUENTO, FECHA_PAGO, FECHA_TAXI, EMPRESA, RUTA, TURNO, IMPORTE_TAXI, ID_UNIDAD, ESTADO) " +
			                      "values ("+ID+", '"+Fecha_Pago+"', '"+Fecha_Taxi+"', '"+Empresa+"', '"+Ruta+"', '"+Turno+"', '"+IMPORTE+"', '"+Id_unidad+"', '"+Estado+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region ELIMINAR TAXI
		public void EliminarDetalleTaxi(String ID)
		{
			base.getAbrirConexion("delete from DESCUENTO_TAXI  where ID="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron eliminados correctamente");
			mensaje.Show();
		}
		#endregion
		
		#region MODIFICAR ESTADO TAXI
		public void ModificarEstadoTaxi(String ID, String Estado)
		{
			string sentencia = "";
			sentencia = "UPDATE DESCUENTO_TAXI SET ESTADO='"+Estado+"' where ID="+ID;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
			mensaje.Show();
		}
		#endregion
		
		#region MODIFICAR CANTIDAD TAXI
		public void ModificarCantidadTaxi(String ID, String Cantidad)
		{
			string sentencia = "";
			sentencia = "UPDATE DESCUENTO SET IMPORTE_TOTAL='"+Cantidad+"' where ID="+ID;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
			mensaje.Show();
		}
		#endregion
		
		#region RETORNO INFONAVIT
		public String Infonavit(String Id_Operador)
		{
			String infonavit="";
			
			base.getAbrirConexion("Select S.INFONAVIT from OPERADOR O, SUELDO S where O.ID=S.ID_OPERADOR AND O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				infonavit = base.leer["INFONAVIT"].ToString();
			}
			base.conexion.Close();
			
			return infonavit;
		}
		#endregion
		
		#region RETORNO IMSS
		public String IMSS(String Id_Operador)
		{
			String imss="";
			
			base.getAbrirConexion("Select S.IMSS from OPERADOR O, SUELDO S where O.ID=S.ID_OPERADOR AND O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				imss = base.leer["IMSS"].ToString();
			}
			base.conexion.Close();
			
			return imss;
		}
		#endregion
		
		#region RETORNO ISR
		public String ISR(String Id_Operador)
		{
			String ISR="";
			
			base.getAbrirConexion("Select S.ISR from OPERADOR O, SUELDO S where O.ID=S.ID_OPERADOR AND O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				ISR = base.leer["ISR"].ToString();
			}
			base.conexion.Close();
			
			return ISR;
		}
		#endregion
		
		#region RETORNO TELCEL
		public String TELCEL(String Id_Operador)
		{
			String TELCEL="";
			
			base.getAbrirConexion("Select S.TELCEL from OPERADOR O, SUELDO S where O.ID=S.ID_OPERADOR AND O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				TELCEL = base.leer["TELCEL"].ToString();
			}
			base.conexion.Close();
			
			return TELCEL;
		}
		#endregion
		
		#region RETORNO OTROS
		public String OTROS(String Id_Operador)
		{
			String OTROS="";
			
			base.getAbrirConexion("select V.SALDO, V.NOMBRE, E.ESTATUS "+
	                               "from ESTADO_IMPORTE E, VALOR_IMPORTE V, OPERADOR O "+
	                               "where V.ID=E.ID_VALOR_IMPORTE and O.ID=E.ID_OPERADOR and V.Tipo='Extra' "+
	                               "and E.ID_OPERADOR="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				if(base.leer["ESTATUS"].ToString()=="1"&&base.leer["SALDO"].ToString()!="")
				{
					OTROS = (base.leer["SALDO"]).ToString();
				}
			}
			base.conexion.Close();
			
			return OTROS;
		}
		#endregion
	}
}
