
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormAutorizaciones : Form
	{
		public FormAutorizaciones(formPrincipalComb refPrinc, Int64 ID_Unidad)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
			vehiculo = ID_Unidad;
		}
		
		formPrincipalComb refPrincipal;
		Int64 vehiculo = 0;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		void getDatos()
		{
			String consulta = "select A.ID, A.NUMERO, A.FECHA_BASE, V.Numero UNIDAD from AUTORIZACION A, VEHICULO V where A.ID_V=V.ID and A.ID_V="+vehiculo+" order by A.FECHA_BASE desc";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgAutorizaciones.Rows.Add(conn.leer["ID"].ToString(), refPrincipal.getNumeroValidacion(Convert.ToInt64(conn.leer["NUMERO"].ToString()), Convert.ToDateTime(conn.leer["FECHA_BASE"])), conn.leer["FECHA_BASE"].ToString().Substring(0,10), conn.leer["UNIDAD"].ToString());
			}
			
			conn.conexion.Close();
		}
		
		void DgAutorizacionesDoubleClick(object sender, EventArgs e)
		{
			//refPrincipal.getAutorizacionesValidacionAlt(Convert.ToInt64(dgAutorizaciones[0,dgAutorizaciones.CurrentRow.Index].Value));
			refPrincipal.getTodo(Convert.ToString(dgAutorizaciones[3,dgAutorizaciones.CurrentRow.Index].Value), Convert.ToInt64(dgAutorizaciones[0,dgAutorizaciones.CurrentRow.Index].Value));
			this.Close();
		}
		
		void FormAutorizacionesLoad(object sender, EventArgs e)
		{
			getDatos();
		}
	}
}
