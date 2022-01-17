using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Asignacion
{
	public partial class FormValidacionCardex : Form
	{
		public FormValidacionCardex(Interfaz.Operaciones.FormPrin_Empresas RefEmp)
		{
			InitializeComponent();
			RefEmpresas = RefEmp;
		}
		
		#region
	 	Interfaz.Operaciones.FormPrin_Empresas RefEmpresas;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region
		void FormValidacionCardexLoad(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion
		
		#region
		void getDatos()
		{
			conn.getAbrirConexion("select H.ID_HO, O.Alias, COUNT(*) Insistencias from OPERADOR O, HISTORIALOPERADOR H, DETALLE_CARDEX D where O.ID=H.ID_O and H.ID_HO=D.ID_H and H.ESTATUS='D' and H.FECHA='"+RefEmpresas.fecha_Base_Datos+"' and H.TURNO='"+RefEmpresas.ConsTurno+"' group by H.ID_HO, O.Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgValidacion.Rows.Add(conn.leer["ID_HO"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Insistencias"].ToString());
			}
			conn.conexion.Close();
			
			dgValidacion.ClearSelection();
		}
		#endregion
		
		#region
		void CmdAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region
		void CmdEliminarClick(object sender, EventArgs e)
		{
			conn.getAbrirConexion("update HISTORIALOPERADOR set ESTATUS='DE' where ID_HO="+dgValidacion[0,dgValidacion.CurrentRow.Index].Value.ToString());
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			dgValidacion.Rows.RemoveAt(dgValidacion.CurrentRow.Index);
		}
		#endregion
	}
}
