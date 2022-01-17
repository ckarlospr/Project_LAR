using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormXcobrar : Form
	{
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		public FormXcobrar()
		{
			InitializeComponent();
		}
		
		#region VARIABLES
		#endregion
		
		#region INSTANCIAS
		#endregion
		
		void FormXcobrarLoad(object sender, EventArgs e)
		{
			getDatos();
			getTotal();
		}
		
		void getDatos()
		{
			String consulta = "select C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID IDCC, C.OBSERVACIONES from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP WHERE C.ID_RUTA_SAL=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' and O.estatus='1' and (C.TIPO='COORDINADOR' OR C.TIPO='OPERADOR') and C.PAGO='0' and C.BORRADO='0' and C.INCOBRABLE='0' and C.FACTURA='0' ORDER BY RE.FECHA_SALIDA";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			int num = 0;
			while(conn.leer.Read())
			{
				num++;
				dgDatos.Rows.Add(conn.leer["ID_RE"].ToString(), num, conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["IDENTIFICADOR"].ToString(), conn.leer["COBRO"].ToString(), conn.leer["TELEFONO"].ToString(), conn.leer["SALDO"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(),  conn.leer["DESTINO"].ToString());
			}
			
			conn.conexion.Close();
			
			dgDatos.ClearSelection();
		}
		
		void getTotal()
		{
			Double total = 0.0;
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				total=total+Convert.ToDouble(dgDatos[6,x].Value);
			}
			
			txtTotal.Text="$"+total.ToString(); // concatenar 
		}
	}
}
