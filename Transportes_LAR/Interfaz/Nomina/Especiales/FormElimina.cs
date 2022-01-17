
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormElimina : Form
	{
		public FormElimina(FormCuentasEsp refPrincipal)
		{
			InitializeComponent();
			refPrinc = refPrincipal;
		}
		
		#region INSTANCIAS
		FormCuentasEsp refPrinc = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			List<int> rowsSelect = new List<int>();
			string tipo = ((rbPagado.Checked==true)?"PAGADO":((rbFact.Checked==true)?"FACTURADO":"OTRO"));
			
			if(tipo=="OTRO" && txtComentario.Text=="")
			{
				MessageBox.Show("Es necesario ingresar en comentarios los motivos.");
			}
			else
			{
				for(int x=0; x<refPrinc.dgRelacion.Rows.Count; x++)
				{
					if(refPrinc.dgRelacion[2,x].Selected==true)
					{
						guardaDatos(tipo, txtComentario.Text, refPrinc.dgRelacion[16,x].Value.ToString(), refPrinc.formPrincipal.idUsuario.ToString());
						rowsSelect.Add(x);
					}
				}
				
				for(int x=rowsSelect.Count-1; x>-1; x--)
				{
					refPrinc.dgRelacion.Rows.RemoveAt(rowsSelect[x]);
				}
				
				this.Close();
			}
		}
		
		#region 
		void guardaDatos(String tipo, String comentario, String id_c, String id_u)
		{
			String sentencia = "INSERT INTO RESUMEN_VENTAS VALUES ('"+tipo+"','"+comentario+"','"+id_c+"','"+id_u+"','"+DateTime.Now.ToString("dd/MM/yyyy")+"','"+DateTime.Now.ToString("HH:mm:ss")+"')";
					
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
	}
}
