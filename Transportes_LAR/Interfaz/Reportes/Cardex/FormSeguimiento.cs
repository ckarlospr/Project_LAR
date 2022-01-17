using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes.Cardex
{
	public partial class FormSeguimiento : Form
	{
		#region INSTANCIAS
		public FormCardex refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		String id = "";
		#endregion
		
		#region CONSTRUCTORES
		public FormSeguimiento(String id, FormCardex refPrincipal)
		{
			InitializeComponent();
			this.id=id;
			this.refPrincipal=refPrincipal;
		}
		#endregion
		
		#region MODIFICAR
		void BtnSeguimientoClick(object sender, EventArgs e)
		{
			String sentencia = "UPDATE DETALLE_CARDEX SET SEGUIMIENTO='"+txtmedida.Text+"', ESTADO='CERRADO' where ID_H="+id;
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			refPrincipal.obternerConsulta();
			this.Close();
		}
		#endregion
		
	}
}
