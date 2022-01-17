using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormViajesExternos : Form
	{
		public FormViajesExternos(Interfaz.Reportes.FormReporteOperaciones refRep)
		{
			InitializeComponent();
			refReporte = refRep;
		}
		
		#region REFERENCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		Interfaz.Reportes.FormReporteOperaciones refReporte = null;
		#endregion
		
		#region EVENTO LOAD
		void FormViajesExternosLoad(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			String consulta = "SELECT O.id_operacion ,O.confirmada ,V.Tipo_Unidad, R.ID, R.IdSubEmpresa, C.Empresa, C.SubNombre, O.fecha, R.turno, R.Nombre, R.Sentido, R.HoraInicio, OP.Alias, V.Numero, O.llegada, O.pasajeros, U.usuario, O.estatus, R.TIPO  FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V WHERE U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo  and O.estatus='1' AND O.fecha = '"+refReporte.dgDatos[0,refReporte.dgDatos.CurrentRow.Index].Value.ToString()+"' AND O.turno='"+refReporte.dgDatos[1,refReporte.dgDatos.CurrentRow.Index].Value.ToString()+"' and OP.tipo_empleado like '%Externo%' ORDER BY O.fecha, O.turno, R.Nombre ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgViajes.Rows.Add(conn.leer["id_operacion"].ToString(), conn.leer["SubNombre"].ToString(), conn.leer["fecha"].ToString().Substring(0,10), conn.leer["turno"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["Alias"].ToString());
			}
			conn.conexion.Close();
		}
		#endregion
		
		
	}
}
