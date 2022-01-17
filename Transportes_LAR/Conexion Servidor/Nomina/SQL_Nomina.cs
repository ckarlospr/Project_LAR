using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Nomina
{
	public partial class SQL_Nomina : SQL_Conexion
	{
		#region CONSTRUCTORES
		public SQL_Nomina():base()
		{

		}
		
		public DataTable getTabla(string consulta)
		{
			return base.getaAdaptadorTabla(consulta);
		}
		#endregion
		
		#region ACTUALIZAR RECIBO
		public void getActualizarRecibo(int id, double Infonavit, double Imss, double Isr, double Telcel, string Nombre1, double Importe1, double Especiales, double Empresas, double Bono, double Total, String fecha, long idnom, String Fecha_i, String Fecha_f, int ID_USUARIO, String DiasTrabajados, String ViajesRealizados, String Ingresos, String Cheque, String Efectivo, String Envio, double subtotalviajesneto)
		{
			string sentencia = "";
			sentencia = "UPDATE NOMINA SET INFONAVIT='"+Infonavit+"', IMSS='"+Imss+"', ISR='"+Isr+"', Telcel='"+Telcel+"', Nombre1='"+Nombre1+"', Importe1="+Importe1+", Especiales="+Especiales+", Empresas="+Empresas+", Bono="+Bono+", Sueldo_Total="+Total+", ID_USUARIO='"+ID_USUARIO+"', Dias_laborados='"+DiasTrabajados+"',	ViajesRealizados='"+ViajesRealizados+"', extras='"+Ingresos+"',	CHEQUE='"+Cheque+"', EFECTIVO='"+Efectivo+"', ENVIO='"+Envio+"', SUELDO_VIAJES='"+subtotalviajesneto+"' where IdOperador="+id+" and ID="+idnom;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
			
			if(idnom!=null&&idnom!=0)
			{
				String sentencia2 = "insert into HISTORIAL_IMPRESION_NOMINA values ("+idnom+", "+ID_USUARIO+", '"+DateTime.Now.ToString("yyyy-MM-dd")+"', '"+DateTime.Now.ToString("HH:mm:ss")+"', '"+((Total >= 0)? Total.ToString() : "0" )+"')";
				base.getAbrirConexion(sentencia2);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
		}
		#endregion
		
		#region INSERTAR NOMINA
		public void InsertarNomina(String id_op, String dtFechaActual, String dtInicio, String dtCorte)
		{
			string sentencia = "";
			sentencia = "insert into NOMINA (IdOperador, INFONAVIT, IMSS, ISR, Anticipos, Telcel, Nombre1, Importe1, Especiales, Empresas, Bono, Sueldo_Total, fecha, fecha_inicio, fecha_fin, Envio) values ("+id_op+", "+0+", "+0+", "+0+", "+0+", "+0+", '"+"Ajuste Nomina"+"', "+0+", "+0+", "+0+", "+0+", "+0+", '"+dtFechaActual+"', '"+dtInicio+"', '"+dtCorte+"', ' ')";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region INSERTAR INGRESOS
		public void InsertarExtra(String Detalle, String Importe, String id_usuario, String id_nomina)
		{
			string sentencia = "";
			sentencia = "insert into INGRESO_NOMINA values ('"+Detalle+"', '"+Importe+"', "+id_usuario+", "+id_nomina+")";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region ELIMINAR EXTRA
		public void EliminarExtra(String Detalle, String id_nomina)
		{
			string sentencia = "";
			sentencia = "delete from INGRESO_NOMINA where DETALLE like '%"+Detalle+"%' and ID_NOMINA ="+id_nomina;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region TRAER PERIODO
		public string INICIO()
		{
			string INICIO="";
			
			base.getAbrirConexion("select FECHAINICIO from PERIODO WHERE FECHAINICIO <= '"+DateTime.Now.ToString("dd-MM-yyyy")+"' and FECHAFIN >= '"+DateTime.Now.AddDays(-2).ToString("dd-MM-yyyy")+"'");
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            {
				INICIO = (base.leer["FECHAINICIO"].ToString());
			}
			base.conexion.Close();
			
			return INICIO;
		}
		
		public string FIN()
		{
			string FIN="";
			
			base.getAbrirConexion("select FECHAFIN from PERIODO WHERE FECHAINICIO <= '"+DateTime.Now.ToString("dd-MM-yyyy")+"' and FECHAFIN >= '"+DateTime.Now.AddDays(-2).ToString("dd-MM-yyyy")+"'");
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            {
				FIN = (base.leer["FECHAFIN"].ToString());
			}
			base.conexion.Close();
			
			return FIN;
		}
		#endregion
		
		public int validaVelada(string id_ruta){
			int velada = 0;
			try{
			base.getAbrirConexion("select VELADA from ruta where VELADA != ' ' and VELADA != 'NULL' and VELADA is not null and VELADA != '' and id = "+ id_ruta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				velada = Convert.ToInt32(base.leer["VELADA"]);
			}
			base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Avisa a sistemas, error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return velada;
		}
		
		public double PreciosRutas(String TipoRuta, String Vehiculo, double km, double tiempo, int domingo, int velada, int foranea)
		{
			double precio = 0.0;
			double extras = 0.0;
			
			String consulta = @"select P.PRECIO, P.DOMINGO, P.VELADA, P.FORANEA
									from PRECIO_RUTA P
									where P.TIPO='"+TipoRuta+"' AND P.VEHICULO='"+Vehiculo+"' AND P.KM_I<="+km+" AND P.KM_F>="+km+" AND P.TIEMPO_I<="+tiempo+" AND P.TIEMPO_F>="+tiempo+" ";
			
			base.getAbrirConexion(consulta);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				if(domingo==1)					
					extras = extras + Convert.ToDouble(base.leer["DOMINGO"]);
				if(velada==1)
					extras = extras + Convert.ToDouble(base.leer["VELADA"]);
				if(foranea==1)
					extras = extras + Convert.ToDouble(base.leer["FORANEA"]);
				
				precio = Convert.ToDouble(base.leer["PRECIO"]) + extras;
			}
			base.conexion.Close();
			
			return precio;
		}
		
		#region LIST DATOS RUTA
		public List<Interfaz.Nomina.Dato.Nomina> Operador(String Id_Operador)
		{
			List<Interfaz.Nomina.Dato.Nomina> listDatosNomina=new List<Interfaz.Nomina.Dato.Nomina>();
			
			Interfaz.Nomina.Dato.Nomina DatosNomina=new Interfaz.Nomina.Dato.Nomina();
			base.getAbrirConexion("select TOP 1 * " +
			                      "from Operador O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' and OC.Reingreso=1 and O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				DatosNomina.Ingreso = base.leer["FechaInicioContrato"].ToString().Substring(0,10);
			}
			base.conexion.Close();
			
			base.getAbrirConexion("select O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat " +
			                      "from Operador O " +
			                      "where O.Estatus='1' and O.Alias!='Admvo' and O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				DatosNomina.Alias = base.leer["Alias"].ToString();
				DatosNomina.Nombre = base.leer["Nombre"].ToString()+" "+base.leer["Apellido_Pat"].ToString()+" "+base.leer["Apellido_Mat"].ToString();
				DatosNomina.Nomb = base.leer["Nombre"].ToString();
				DatosNomina.Ape = base.leer["Apellido_Pat"].ToString()+" "+base.leer["Apellido_Mat"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("select T.Numero As Telefono " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='LAR' and O.Alias!='Admvo' and O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				DatosNomina.Celular = base.leer["Telefono"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("select V.Numero, V.Tipo_Unidad " +
			                      "from Operador O, vehiculo V, ASIGNACIONUNIDAD AU " +
			                      "where V.ID = AU.ID_UNIDAD and O.ID = AU.ID_OPERADOR and O.Estatus='1' and O.Alias!='Admvo' and O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				DatosNomina.Unidad = base.leer["Numero"].ToString();
				DatosNomina.TipoUnidad = base.leer["Tipo_Unidad"].ToString();
			}
			base.conexion.Close();
			
			base.getAbrirConexion("Select L.Numero, L.Vigencia " +
			                      "from Operador O, LICENCIA L " +
			                      "where O.ID=L.ID_Chofer AND L.Descripcion='Estatal' and O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				DatosNomina.Estatal = base.leer["Numero"].ToString();
				DatosNomina.VigEstatal = base.leer["Vigencia"].ToString().Substring(0,10);
			}
			base.conexion.Close();
			
			base.getAbrirConexion("Select L.Numero, L.Vigencia " +
			                      "from Operador O, LICENCIA L " +
			                      "where O.ID=L.ID_Chofer AND L.Descripcion='Federal' and O.ID ="+Id_Operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				DatosNomina.Federal = base.leer["Numero"].ToString();
				DatosNomina.VigFederal = base.leer["Vigencia"].ToString().Substring(0,10);
			}
			base.conexion.Close();
			
			listDatosNomina.Add(DatosNomina);
			
			return (listDatosNomina.Count>0)?listDatosNomina:null;
		}
		#endregion
		
		#region PERIODO RUTA
		/*void periodo()
		{
			FechaDesglose = dtFechaActual.Value;
			FechaDesglose2 = dtFechaActual.Value;
			int AumentoFechas = 0;
			int AumentoFechas2 = 0;
			
			for(int contador = 0; contador<=30000; contador++)
			{
				AumentoFechas2 = AumentoFechas + 13;
				conn.getAbrirConexion("insert into PERIODO (FECHAINICIO, FECHAFIN) values ('"+FechaDesglose.AddDays(AumentoFechas).ToString("yyyy/MM/dd").Substring(0,10)+"', '"+FechaDesglose2.AddDays(AumentoFechas2).ToString("yyyy/MM/dd").Substring(0,10)+"')");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				AumentoFechas = AumentoFechas2 + 1;
			}
		}*/
		#endregion
		
		#region ACTUALIZAR IMPORTE
		public void getActualizarImporte(String ID, String Detalle, String Importe, String Tipo)
		{
			string sentencia = "";
			sentencia = "UPDATE VALOR_IMPORTE SET Nombre='"+Detalle+"', Saldo='"+Importe+"', Tipo='"+Tipo+"' where ID="+ID;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
		}
		#endregion
		
		#region INSERTAR IMPORTE
		public void InsertarImporte(String Detalle, String Importe, String Tipo)
		{
			string sentencia = "";
			sentencia = "insert into VALOR_IMPORTE values ('"+Detalle+"', '"+Importe+"', '"+Tipo+"')";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region ESTADO IMPORTE
		public bool Estado_Importe(String id_operador, String id_valor)
		{
			bool Switch = false;
			base.getAbrirConexion("select ESTATUS from ESTADO_IMPORTE where ID_OPERADOR="+id_operador+" AND ID_VALOR_IMPORTE="+id_valor);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				if(base.leer["ESTATUS"].ToString()=="1")
				{
					Switch = true;
				}
			}
			base.conexion.Close();
			
			return Switch;
		}
		#endregion
		
		#region PROMEDIO DE SUELDO
		public double PROEMDIO_SUELDO(String id_operador)
		{
			double prom = 0.00;
			base.getAbrirConexion("select AVG(SUELDO_TOTAL) AS PROMEDIO from NOMINA where IDOPERADOR="+id_operador);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				prom = Convert.ToDouble(base.leer["PROMEDIO"]);
			}
			base.conexion.Close();
			
			return prom;
		}
		#endregion
		
		#region TIPO DE PAGO
		public String TraerTipoPago()
		{
			String Switch = "";
			base.getAbrirConexion("select NOMBRE " +
			                      "from TIPO_PAGO ");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Switch = base.leer["NOMBRE"].ToString();
			}
			base.conexion.Close();
			
			return Switch;
		}
		#endregion
		
		#region ACTUALIZAR TIPO PAGO
		public void ActualizarTipoPago(String Tipo)
		{
			string sentencia = "";
			sentencia = "UPDATE TIPO_PAGO SET NOMBRE='"+Tipo+"'";
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();	
		}
		#endregion
	}
}
