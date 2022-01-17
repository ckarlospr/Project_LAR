using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones.Despacho
{
	public partial class FormRecadoOperador : Form
	{
		public FormRecadoOperador(Int64 ID_OPERADOR)
		{
			InitializeComponent();
			ID_O=ID_OPERADOR;
		}
		
		#region VARIABLE
		List<Interfaz.Operaciones.Dato.msjGerencial> listMsj = new List<Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial>();
		Int64 ID_O=0;
		#endregion
		
		#region REFERENCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormRecadoOperadorLoad(object sender, EventArgs e)
		{
			getDatos();
			llenaDatagrid();
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			/*Mensajes unicos*/
			almacenaMensajes("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='1' and FECHA_INICIO=(SELECT CONVERT (DATE, SYSDATETIME())) and ID_O="+ID_O+"");
			
			/*Mensajes diarios*/
			almacenaMensajes("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='2' and ID_O="+ID_O+" ");
			
			/*Mensajes por semana*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='3' and ID_O="+ID_O+" ");
			
			/*Cada dos semanas*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='4' and ID_O="+ID_O+" ");
			
			/*Por mes*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='5' and ID_O="+ID_O+" ");
			
			/*Por año*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='6' and ID_O="+ID_O+" ");
		}
		
		void almacenaMensajes(String Consulta)
		{
			conn.getAbrirConexion(Consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial datos = new Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial();
				datos.ID		=conn.leer["ID"].ToString();
				datos.MENSAJE	=conn.leer["MENSAJE"].ToString();
				datos.ESTATUS	=conn.leer["ESTATUS"].ToString();
				datos.TIPO		=conn.leer["TIPO"].ToString();
				datos.CANTIDAD	=conn.leer["CANTIDAD"].ToString();
				datos.FECHA		=conn.leer["FECHA_REG"].ToString();
				datos.USUARIO	=conn.leer["ID_U"].ToString();
				
				listMsj.Add(datos);
			}
			conn.conexion.Close();
		}
		
		void almacenaMensajes2(String Consulta)
		{
			conn.getAbrirConexion(Consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				int x=0;
				int cantidad=0;
				DateTime fechaBase = Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString());
				
				do
				{
					x++;
					MessageBox.Show(fechaBase.AddDays(cantidad).ToString("dd/MM/yyyy")+"=="+DateTime.Now.ToString("dd/MM/yyyy"));
					if(fechaBase.AddDays(cantidad).ToString("dd/MM/yyyy")==DateTime.Now.ToString("dd/MM/yyyy"))
					{
						Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial datos = new Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial();
						datos.ID		=conn.leer["ID"].ToString();
						datos.MENSAJE	=conn.leer["MENSAJE"].ToString();
						datos.ESTATUS	=conn.leer["ESTATUS"].ToString();
						datos.TIPO		=conn.leer["TIPO"].ToString();
						datos.CANTIDAD	=conn.leer["CANTIDAD"].ToString();
						datos.FECHA		=conn.leer["FECHA_REG"].ToString();
						datos.USUARIO	=conn.leer["ID_U"].ToString();
						
						listMsj.Add(datos);
					}
					
					cantidad=Convert.ToInt16(conn.leer["CANTIDAD"])*x;
					MessageBox.Show(fechaBase.AddDays(cantidad)+">"+DateTime.Now);
				}while(fechaBase.AddDays(cantidad)<DateTime.Now);
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region LLENADO DE DATAGRID
		void llenaDatagrid()
		{
			if(listMsj.Count>0)
			{
				for(int x=0; x<listMsj.Count; x++)
				{
					dgMsj.Rows.Add(listMsj[x].ID, listMsj[x].MENSAJE, listMsj[x].TIPO, listMsj[x].FECHA.Substring(0,10), listMsj[x].ESTATUS);
				}
				
				dgMsj.ClearSelection();
			}
		}
		#endregion
		
		#region EVENTO CELLCLICK DGMSJ
		void DgMsjCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				txtMsj.Text=dgMsj[1, e.RowIndex].Value.ToString();
			}
		}
		#endregion
		
		void CmdAceptarClick(object sender, EventArgs e)
		{
			if(txtContra.Text=="3215")
			{
				String consulta ="UPDATE MENSAJE_GERECIAL SET ESTATUS='0' WHERE ID="+dgMsj[0,dgMsj.CurrentRow.Index].Value.ToString();
			
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				dgMsj.Rows.RemoveAt(dgMsj.CurrentRow.Index);
				txtMsj.Text="";
				dgMsj.ClearSelection();
			}
			else
			{
				MessageBox.Show("Contraseña incorrecta.");
				txtContra.Text="";
			}
		}
	}
}
