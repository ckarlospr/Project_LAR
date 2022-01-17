using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Nomina
{
	public class SQL_Aguinaldo : SQL_Conexion
	{
		public SQL_Aguinaldo():base()
		{
			
		}
		
		public double RetornoAguinaldo(String id_operador, int DiasTrabajados)
		{
			double aguinaldo = 0.0;
			/*double compensacion = 0.0;
			double retenido = 0.0;
			double SDI = 0.0;
			double SD = 0.0;
			double excento = 0.0;*/
			String Fecha;
			double Sueldo;
			
			Fecha = new Nomina.SQL_Recibo().FechaIngreso(id_operador);
			Sueldo = new Nomina.SQL_Recibo().Sueldo(id_operador);
			
			return aguinaldo;
		}
	}
}
