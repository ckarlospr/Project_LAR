using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Incapacidad
{
	public partial class FormValidaFact : Form
	{
		public FormValidaFact()
		{
			InitializeComponent();
		}
		
		#region VARIABLES
		String consulta = "";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormValidaFactLoad(object sender, EventArgs e)
		{
			obtenerConsulta();
			consulta=consulta+" and RE.FACTURADO='1' ";
			getDatos();
		}
		#endregion
		
		#region CARGA DATOS EN DATAGRID
		void obtenerConsulta()
		{
			consulta="select RE.ID_RE, RE.FACTURA, RE.DESTINO, CS.Nombre, RE.RESPONSABLE, RE.CANT_UNIDADES, RE.tipoVehiculo, RE.FACTURADO from RUTA_ESPECIAL RE, ContactoServicio CS where RE.ID_C=CS.IdCliente and RE.ID_C in (select IdSubEmpresa from RUTA) ";
		}
		
		public void getDatos()
		{
			dgEspeciales.Rows.Clear();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				dgEspeciales.Rows.Add(conn.leer["ID_RE"].ToString(),conn.leer["FACTURA"].ToString(),conn.leer["DESTINO"].ToString(),conn.leer["Nombre"].ToString(), conn.leer["RESPONSABLE"].ToString(), conn.leer["CANT_UNIDADES"].ToString(), conn.leer["tipoVehiculo"].ToString(), conn.leer["FACTURADO"].ToString());
			}
			
			conn.conexion.Close();
			dgEspeciales.ClearSelection();
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdFacturarClick(object sender, EventArgs e)
		{
			if(dgEspeciales.CurrentRow.Index>-1)
			{
				conn.getAbrirConexion("UPDATE RUTA_ESPECIAL SET FACTURADO='2' WHERE ID_RE="+dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value.ToString());
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				dgEspeciales.Rows.RemoveAt(dgEspeciales.CurrentRow.Index);
			}
		}
		#endregion
	}
}
