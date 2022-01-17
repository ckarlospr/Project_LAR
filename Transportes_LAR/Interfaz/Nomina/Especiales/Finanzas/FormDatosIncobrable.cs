using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	public partial class FormDatosIncobrable : Form
	{
		public FormDatosIncobrable(Int64 id_re)
		{
			InitializeComponent();
			ID = id_re;
		}
		
		#region 
		Int64 ID = 0;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		void FormDatosIncobrableLoad(object sender, EventArgs e)
		{
			getDatos();
		}
		
		void getDatos()
		{
			String consulta = "select * from PAGO_INCOBRO where ID_RE = "+ID;
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtEfectivo.Text=conn.leer["EFECTIVO"].ToString();
				txtDeposito.Text=conn.leer["DEPOSITO"].ToString();
				txtTotal.Text=conn.leer["MONTO_RECUPERADO"].ToString();
				txtPerdido.Text=conn.leer["MONTO_PERDIDO"].ToString();
			}
			
			conn.conexion.Close();
		}
	}
}
