using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormFacturaEsp : Form
	{
		public FormFacturaEsp()
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
		void FormFacturaEspLoad(object sender, EventArgs e)
		{
			obtenerConsulta();
			consulta=consulta+" and RE.FACTURADO='2' ";
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
		
		#region CBFACTURADO
		void CbFacturadosCheckedChanged(object sender, EventArgs e)
		{
			if(cbFacturados.Checked==true)
			{
				obtenerConsulta();
				consulta=consulta+" and RE.FACTURADO='3' ";
				getDatos();
			}
			else
			{
				obtenerConsulta();
				consulta=consulta+" and RE.FACTURADO='2' ";
				getDatos();
			}
		}
		#endregion
		
		#region BOTON REALIZADO
		void CmdRealizadoClick(object sender, EventArgs e)
		{
			if(dgEspeciales.SelectedRows.Count>0)
			{
				new FormTerminoFact(this).ShowDialog();
			}
		}
		#endregion
		
		#region GUARDA DATOS
		public void guardaDatos(String DATO)
		{
			if(dgEspeciales.CurrentRow.Index>-1)
			{
				conn.getAbrirConexion("UPDATE RUTA_ESPECIAL SET FACTURADO='3' WHERE ID_RE="+dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value.ToString());
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				conn.getAbrirConexion("update COBRO_ESPECIAL set NUMERO_FACT='"+DATO+"' where ID_RE="+dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value.ToString());
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				if(cbFacturados.Checked==false)
					dgEspeciales.Rows.RemoveAt(dgEspeciales.CurrentRow.Index);
			}
		}
		#endregion
		
		void DgEspecialesDoubleClick(object sender, EventArgs e)
		{
			new FormDatosFactura(3,dgEspeciales[1,dgEspeciales.CurrentRow.Index].Value.ToString()).ShowDialog();
		}
		
		void CmdDatosClick(object sender, EventArgs e)
		{
			if(dgEspeciales.SelectedRows.Count>0)
			{
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgEspeciales[1,dgEspeciales.CurrentRow.Index].Value));
				formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();
			}
		}
	}
}
