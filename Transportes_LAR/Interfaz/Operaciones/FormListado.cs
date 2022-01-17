using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormListado : Form
	{
		public FormListado(FormPrincipal formPrinc)
		{
			InitializeComponent();
			refPrincipal=formPrinc;
		}
		
		#region VARIABLES
		#endregion
		
		#region INSTACIAS
		public FormPrincipal refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormListadoLoad(object sender, EventArgs e)
		{
			getDatos();
			timerListado.Enabled=true;
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			dgListado.Rows.Clear();
			
			String consulta = 	" select * from VEHICULO order by Numero";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgListado.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString(), conn.leer["Marca"].ToString());
			}
			conn.conexion.Close();
			
			completa();
			dgListado.ClearSelection();
		}
		
		void completa()
		{
			for(int x=0; x<dgListado.Rows.Count; x++)
			{
				String consulta = "select O.ID, O.Alias, A.estatus, O.tipo_empleado from ASIG_UNIDAD A, OPERADOR O where A.ID_OPERADOR=O.ID and ID_UNIDAD="+dgListado[0,x].Value.ToString();
			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgListado[3,x].Value=conn.leer["ID"].ToString();
					dgListado[4,x].Value=conn.leer["Alias"].ToString();
					dgListado[5,x].Value=conn.leer["estatus"].ToString();
					if(conn.leer["tipo_empleado"].ToString()=="OPERADOR" && conn.leer["estatus"].ToString()=="A")
					{
						dgListado[4,x].Style.ForeColor=Color.Black;
						dgListado[4,x].Style.BackColor=Color.MediumSpringGreen;
					}
					else if(conn.leer["tipo_empleado"].ToString()!="OPERADOR")
					{
						dgListado[4,x].Style.ForeColor=Color.Black;
						dgListado[4,x].Style.BackColor=Color.Gray;
					}
					else
					{
						dgListado[4,x].Style.ForeColor=Color.Black;
						dgListado[4,x].Style.BackColor=Color.White;
					}
				}
				else
				{
					dgListado[4,x].Value="Sin asignar";
					dgListado[4,x].Style.ForeColor=Color.Red;
					dgListado[4,x].Style.BackColor=Color.White;
				}
				conn.conexion.Close();
				
				consulta = "select estatus from ASIG_UNIDAD where ID_UNIDAD="+dgListado[0,x].Value.ToString();
			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgListado[5,x].Value=conn.leer["estatus"].ToString();
				}
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region BUSQUEDA
		bool numeroo = false;
		
		void TxtBusquedaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar)==true)
			{
				numeroo = true;
			}
			else
			{
				numeroo = false;
			}
		}
		
		void TxtBusquedaKeyUp(object sender, KeyEventArgs e)
		{
			if(txtBusqueda.Text=="")
			{
				dgListado.FirstDisplayedCell = dgListado.Rows[0].Cells[1];
			}
			else
			{
				if(numeroo==true)
				{
					for(int x=0; x<dgListado.Rows.Count; x++)
					{
						if(dgListado[1,x].Value.ToString().Contains(txtBusqueda.Text))
						{
							dgListado.ClearSelection();
							dgListado.Rows[x].Selected = true;
							dgListado.FirstDisplayedCell = dgListado.Rows[x].Cells[1];
						}
					}
				}
				else
				{
					for(int x=0; x<dgListado.Rows.Count; x++)
					{
						if(dgListado[4,x].Value.ToString().Contains(txtBusqueda.Text))
						{
							dgListado.ClearSelection();
							dgListado.Rows[x].Selected = true;
							dgListado.FirstDisplayedCell = dgListado.Rows[x].Cells[4];
						}
					}
				}
			}
		}
		#endregion
		
		void TimerListadoTick(object sender, EventArgs e)
		{
			completa();
		}
	}
}
