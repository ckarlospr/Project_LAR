using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	public partial class FormHistorialTotalizado : Form
	{
		#region VARIABLES
		String id;
		String [] id_desc = new String[20];
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTOR
		public FormHistorialTotalizado(String id)
		{
			InitializeComponent();
			this.id=id;
		}
		#endregion
		
		#region INICIO
		void FormHistorialTotalizadoLoad(object sender, EventArgs e)
		{
			int contador = 0;
			int conarray = -1;
			int conarray2 = 0;
			dtHistorial.Rows.Clear();
			dtHistorial.ClearSelection();
			
			conn.getAbrirConexion("select DISTINCT(ID_DESCUENTO) from HISTORIAL_TOTALIZADO D where ID_TOTALIZADO="+id);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++conarray;
				id_desc[conarray] = conn.leer["ID_DESCUENTO"].ToString();
			}
			conn.conexion.Close();
			
			while(conarray2<=conarray)
			{
				conn.getAbrirConexion("select D.DESCRIPCION, D.IMPORTE_TOTAL, D.OBSERVACION  from DESCUENTO D, HISTORIAL_TOTALIZADO H where D.ID=H.ID_DESCUENTO and H.ID_DESCUENTO="+id_desc[conarray2]);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dtHistorial.Rows.Add();
					dtHistorial.Rows[contador].Cells[0].Value = conn.leer["DESCRIPCION"].ToString();
					dtHistorial.Rows[contador].Cells[2].Value = conn.leer["IMPORTE_TOTAL"].ToString();
					dtHistorial.Rows[contador].Cells[1].Value = conn.leer["OBSERVACION"].ToString();
					++contador;
				}
				conn.conexion.Close();
				++conarray2;
			}
		}
		#endregion
		
	}
}
