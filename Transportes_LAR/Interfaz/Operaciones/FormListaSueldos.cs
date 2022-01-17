using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormListaSueldos : Form
	{
		public FormListaSueldos()
		{
			InitializeComponent();
		}
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Interfaz.Nomina.FormNomina refNomina = new Transportes_LAR.Interfaz.Nomina.FormNomina();
		#endregion
		
		void FormListaSueldosLoad(object sender, EventArgs e)
		{
			getOperadores();
		}
		
		#region GET OPERADORES
		public void getOperadores()
		{
			dgOperadores.Rows.Clear();
			
			String consulta = "select ID, Alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgOperadores.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString());
			}
			
			conn.conexion.Close();
			
			getSueldos();
		}
		#endregion
		
		#region GET SUELDOS
		void getSueldos()
		{
			for(int x=0; x<dgOperadores.Rows.Count; x++)
			{
				//MessageBox.Show(dgOperadores[1,x].Value.ToString());
				dgOperadores[3,x].Value=refNomina.RetornoSueldoAlias(dgOperadores[1,x].Value.ToString());
				dgOperadores[2,x].Value=refNomina.cuenta;
			}
			
			dgOperadores.Sort(dgOperadores.Columns[3], ListSortDirection.Ascending);
		}
		#endregion
	}
}
