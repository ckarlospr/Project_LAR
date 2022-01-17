using System;

namespace Transportes_LAR.Conexion_Servidor.Nomina
{
	public class SQL_Recibo : SQL_Conexion
	{
		public SQL_Recibo():base()
		{
		}
		
		public String FechaIngreso(String id_operador)
		{
			String Fecha = "";
			base.getAbrirConexion("select min(OC.FechaInicioContrato) as Ingreso " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' " +
			                      "and O.ID ="+id_operador);
			base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					Fecha = base.leer["Ingreso"].ToString().Substring(0,10);
				}
			base.conexion.Close();
			
			return Fecha;
		}
		
		public String FechaIngreso2(String id_operador)
		{
			String Fecha = "";
			base.getAbrirConexion("select min(OC.FechaInicioContrato) as Ingreso " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Alias!='Admvo' " +
			                      "and O.ID ="+id_operador);
			base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					//Fecha = base.leer["Ingreso"].ToString().Substring(0,10);
					try{ Fecha = base.leer["Ingreso"].ToString().Substring(0,10); }catch(Exception){ Fecha = "2000-01-01"; }
				}
			base.conexion.Close();
			
			return Fecha;
		}
		
		public void ISR(String id_operador, double isr)
		{
			base.getAbrirConexion("UPDATE SUELDO SET ISR='"+isr+"' WHERE ID_OPERADOR ="+id_operador);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}

		public double Sueldo(String id_operador)
		{
			double SueldoEmpleado = 0.0;
			
			base.getAbrirConexion("Select S.SUELDO_BASE " +
				                      "from OPERADOR O, SUELDO S " +
				                      "where O.ID=S.ID_OPERADOR AND O.ID ="+id_operador);
			base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					SueldoEmpleado = Convert.ToDouble(base.leer["SUELDO_BASE"]);
				}
			base.conexion.Close();
			
			return SueldoEmpleado;
		}
		
		public double PrimaVacacional()
		{
			double Prima = 0.0;
			
			base.getAbrirConexion("Select V.SALDO " +
				                      "from VALOR_IMPORTE V " +
				                      "where NOMBRE='PRIMA VACACIONAL' ");
			base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
				{
					Prima = Convert.ToDouble(base.leer["SALDO"]);
				}
			base.conexion.Close();
			
			return Prima;
		}
	}
}
