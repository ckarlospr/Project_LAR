using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormVerOperador : Form
	{
		#region CONSTRUCTOR
		public FormVerOperador(PrivilegiosPagos Principal, string id_r)
		{
			InitializeComponent();
			formPrincipal = Principal;
			ID_RE = id_r;
		}
		#endregion
		
		#region INSTANCIAS	
		public PrivilegiosPagos formPrincipal;			
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
				
		#region VARIABLE	
		string ID_RE;
		#endregion		
		
		#region INICIO - FIN
		void FormVerOperadorLoad(object sender, EventArgs e)
		{
			adaptadorPrincipal();
		}		
		#endregion
		
		#region METODOS		
		private void adaptadorPrincipal(){
			string consulta = "select co.ID_RE, o.Alias from COBRO_ESPECIAL co join OPERADOR o on o.ID = co.ID_OP where co.ID_RE = "+ID_RE;
			dtOperador.Rows.Clear();					
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read())
				dtOperador.Rows.Add(conn.leer["Alias"].ToString());				
			
			conn.conexion.Close();
			dtOperador.ClearSelection();
			dtOperador.AutoSize = true;
			this.AutoSize = true;
		}
		#endregion
	}
}
