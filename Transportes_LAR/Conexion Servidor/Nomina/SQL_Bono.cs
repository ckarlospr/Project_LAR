using System;

namespace Transportes_LAR.Conexion_Servidor.Nomina
{
	public class SQL_Bono : SQL_Conexion
	{
		#region CONSTRUCTOR
		public SQL_Bono():base()
		{
		}
		#endregion
		
		public Boolean ExistenciaBono(String Id_OP, String fecha_inicio, String fecha_Corte)
		{
			bool existencia = false;
			
			base.getAbrirConexion("select ID_O " +
			                      "from OPERADOR O, NUEVO_HISTORIAL_BONO_OPERADOR B " +
			                      "where O.Alias!='Admvo' and O.Estatus='1' and O.ID=B.ID_O " +
			                      "AND O.tipo_empleado='OPERADOR' and B.FECHA_INICIO='"+fecha_inicio+"' " +
			                      "and B.FECHA_FIN='"+fecha_Corte+"' and B.ID_O="+Id_OP);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				existencia = true;
			}
			
			return existencia;
		}
		
		public Boolean ExistenciaPerdida(String id_historial, String tipo)
		{
			bool existencia = false;
			
			base.getAbrirConexion("select * " +
			                      "from PERDIDA_BONO P "+
			                      "where P.Id_Historial='"+id_historial+"' " +
			                      "and P.Tipo='"+tipo+"'");
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				existencia = true;
			}
			
			return existencia;
		}
		
		public String Traer_ID(String Id_OP, String fecha_inicio, String fecha_Corte)
		{
			String id = "";
			
			base.getAbrirConexion("select B.ID " +
			                      "from OPERADOR O, NUEVO_HISTORIAL_BONO_OPERADOR B " +
			                      "where O.Alias!='Admvo' and O.Estatus='1' and O.ID=B.ID_O " +
			                      "AND O.tipo_empleado='OPERADOR' and B.FECHA_INICIO='"+fecha_inicio+"' " +
			                      "and B.FECHA_FIN='"+fecha_Corte+"' and B.ID_O="+Id_OP);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				id = base.leer["ID"].ToString();
			}
			
			return id;
		}
	}
}
