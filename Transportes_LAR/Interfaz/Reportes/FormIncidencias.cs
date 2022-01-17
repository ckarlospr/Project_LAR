using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormIncidencias : Form
	{
		public FormIncidencias(Interfaz.Reportes.FormReporteOperaciones refRep, int id_u)
		{
			InitializeComponent();
			refReporte = refRep;
			id_usario=id_u;
		}
		
		#region VARIABLES
		int id_usario=0;
		#endregion
		
		#region REFERENCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		Interfaz.Reportes.FormReporteOperaciones refReporte = null;
		#endregion
		
		#region EVENTO LOAD
		void FormIncidenciasLoad(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion
		
		#region GETDATOS
		void getDatos()
		{
			String consulta = "select * from HISTORIAL_EMPRESAS H, usuario U, ORDEN_EMPRESAS O where  H.ID_OC=O.ID and H.ID_U=U.id_usuario and H.DIA='"+refReporte.dgDatos[0,refReporte.dgDatos.CurrentRow.Index].Value.ToString()+"' and H.TURNO='"+refReporte.dgDatos[1,refReporte.dgDatos.CurrentRow.Index].Value.ToString()+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgIncidencias.Rows.Add(conn.leer["ID"].ToString(), conn.leer["TIPO"].ToString(), conn.leer["NOMBRE"].ToString(), conn.leer["OBSERVACIONES"].ToString(), conn.leer["TURNO"].ToString(), conn.leer["DIA"].ToString().Substring(0,10), conn.leer["usuario"].ToString());
			}
			conn.conexion.Close();
			
			dgIncidencias.ClearSelection();
		}
		#endregion
		
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			if(dgIncidencias.SelectedRows.Count>0)
			{
				String consulta ="execute AUDITA_GRAL  'HISTORIAL_EMPRESAS', "+dgIncidencias[0,dgIncidencias.CurrentRow.Index].Value.ToString()+", 'DELETE', "+id_usario;
				
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				consulta ="delete from HISTORIAL_EMPRESAS where id="+dgIncidencias[0,dgIncidencias.CurrentRow.Index].Value.ToString();
				
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				dgIncidencias.Rows.RemoveAt(dgIncidencias.CurrentRow.Index);
				
				refReporte.ingresaFechas();
				refReporte.getDatos();
			}
		}
	}
}
