using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones.Actializacion
{
	public partial class FormActualizacion : Form
	{
		public FormActualizacion(Interfaz.FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		
		#region VARIABLES
		public int cuenta = 0;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		public Interfaz.FormPrincipal refPrincipal;
		#endregion
		
		#region EVENTO LOAD
		void FormActualizacionLoad(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion
		
		#region GETDATOS
		void getDatos()
		{
			dgOperador.Rows.Clear();
			//WHERE ID NOT IN (SELECT ID_O FROM ACTUALIZA_OPERADOR WHERE FECHA='"+"12/12/2013"+"')
			String consulta = "SELECT * FROM OPERADOR WHERE tipo_empleado='OPERADOR' AND Estatus='1' AND NOT ID IN (SELECT ID_O FROM ACTUALIZA_OPERADOR WHERE FECHA_REG='"+DateTime.Now.ToString("dd/MM/yyyy")+"')";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgOperador.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Nombre"].ToString().ToUpper()+" "+conn.leer["Apellido_Pat"].ToString().ToUpper()+" "+conn.leer["Apellido_Mat"].ToString().ToUpper());
			}
			conn.conexion.Close();
			dgOperador.ClearSelection();
		}
		#endregion
		
				/*String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+refReporte.dgReporte[0,refReporte.dgReporte.CurrentRow.Index].Value.ToString()+", '"+dgCobros[4,dgCobros.CurrentRow.Index].Value.ToString()+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refReporte.refPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', 'EFECTIVO', 'N/A', 'PAGO') ";
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();*/ 
		
		
		#region EVENTOS BOTONES
		void CmdModificarClick(object sender, EventArgs e)
		{
			if(dgOperador.SelectedRows.Count>0)
			{
				new Interfaz.Operador.FormOperador(refPrincipal,dgOperador[0,dgOperador.CurrentRow.Index].Value.ToString()).ShowDialog();
			}
			else
			{
				MessageBox.Show("Selecciones un operador.");
			}
		}
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			if(cuenta<5)
			{
				DialogResult rs2 = MessageBox.Show("No se han realizado las 5 actualizaciones del día. \n ¿Desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs2)
				{
					String consulta = "";

					conn.getAbrirConexion(consulta); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
					this.Close();
				}
			}
		}
		#endregion
	}
}
