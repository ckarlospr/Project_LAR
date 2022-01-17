using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormHistorialValidacion : Form
	{
		public FormHistorialValidacion(formPrincipalComb refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		bool inicio=false;
		#endregion
		
		#region INSTACIAS
		formPrincipalComb refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormHistorialValidacionLoad(object sender, EventArgs e)
		{
			inicio=true;
			//geDatos();
			dtpInicio.Value=DateTime.Now.AddDays(-2);
			dtpFin.Value=DateTime.Now;
			inicio=false;
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			dgAutorizacionValida.Rows.Clear();
			int contt = 0;
			
			String consulta = "select A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and ESTATUS='1' and ID_V in (select ID from VEHICULO where Numero='"+refPrincipal.txtUnidadValidacion.Text+"') and FECHA_BASE <= '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' order by FECHA_BASE";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				/*if(contt==0)
				{
					contt++;
				}
				else
				{*/
					dgAutorizacionValida.Rows.Add(conn.leer["ID"].ToString(), refPrincipal.getNumeroValidacion(Convert.ToInt64(conn.leer["NUMERO"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), ((conn.leer["FECHA_BASE"].ToString()=="")?"":conn.leer["FECHA_BASE"].ToString().Substring(0,10)), conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5), conn.leer["ID_G"].ToString(), ((conn.leer["LITROS"].ToString()=="")?"0.00":conn.leer["LITROS"].ToString()), ((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString()), ((conn.leer["HORA_CARGA"].ToString()=="")?"00:00":conn.leer["HORA_CARGA"].ToString()), conn.leer["ID_COM"].ToString(), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), conn.leer["ID_G"].ToString(), conn.leer["ID_COM"].ToString(), conn.leer["ESTATUS"].ToString());
				//}
			}
			
			conn.conexion.Close();
			dgAutorizacionValida.ClearSelection();
			
			for(int x=0; x<dgAutorizacionValida.Rows.Count; x++)
			{
				if(dgAutorizacionValida[6,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from GASOLINERA where ID='"+dgAutorizacionValida[6,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[6,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[3,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgAutorizacionValida[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[3,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[2,x].Value.ToString()!="")
				{
					consulta = "select Numero from VEHICULO where ID='"+dgAutorizacionValida[2,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[2,x].Value=conn.leer["Numero"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[10,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from TIPOS_COMB where ID='"+dgAutorizacionValida[10,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[10,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
			}
			
			//dgAutorizacionValida.Rows[0].ReadOnly=true;
			
			colorEstatus();
		}
		#endregion
		
		#region VALIDA DATOS DEL DTGRID
		void DgAutorizacionValidaCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(inicio==false)
			{
				if(e.RowIndex!=-1 && e.RowIndex!=0)
				{
					if(e.ColumnIndex==3)// VALIDO OPERADOR
					{
						Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
						String consulta = "SELECT * FROM OPERADOR WHERE Alias='"+dgAutorizacionValida[3,e.RowIndex].Value.ToString()+"'";
						
						connex.getAbrirConexion(consulta);
						connex.leer=connex.comando.ExecuteReader();
						if(connex.leer.Read())
						{
							dgAutorizacionValida[3,e.RowIndex].Value=connex.leer["Alias"].ToString();
							dgAutorizacionValida[11,0].Value=connex.leer["ID"].ToString();
							dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
						}
						else
						{
							dgAutorizacionValida[3,e.RowIndex].Value="OPERADOR";
							dgAutorizacionValida[11,0].Value="0";
							dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
						}
						
						connex.conexion.Close();
					}
					if(e.ColumnIndex==4)// VALIDO FECHA 
					{
						try{Convert.ToDateTime(dgAutorizacionValida[4,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
						catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value=DateTime.Now.ToString("dd/MM/yyyy");dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
					}
					if(e.ColumnIndex==5)// VALIDO HORA 
					{
						try{Convert.ToDateTime(dgAutorizacionValida[5,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
						catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value=DateTime.Now.ToString("HH:mm:ss");dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
					}
					if(e.ColumnIndex==6)// VALIDO GASOLINERA
					{
						Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
						String consulta = "SELECT * FROM GASOLINERA WHERE NOMBRE='"+dgAutorizacionValida[6,e.RowIndex].Value.ToString()+"'";
						
						connex.getAbrirConexion(consulta);
						connex.leer=connex.comando.ExecuteReader();
						if(connex.leer.Read())
						{
							dgAutorizacionValida[6,e.RowIndex].Value=connex.leer["NOMBRE"].ToString();
							dgAutorizacionValida[13,0].Value=connex.leer["ID"].ToString();
							dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
						}
						else
						{
							dgAutorizacionValida[3,e.RowIndex].Value="GASOLINERA";
							dgAutorizacionValida[13,0].Value="0";
							dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
						}
						
						connex.conexion.Close();
					}
					if(e.ColumnIndex==7)// VALIDO DECIMAL
					{
						try{Convert.ToDouble(dgAutorizacionValida[7,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
						catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value="0.00";dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
					}
					if(e.ColumnIndex==8)// VALIDO DECIMAL
					{
						try{Convert.ToDouble(dgAutorizacionValida[8,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
						catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value="0.00";dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
					}
					if(e.ColumnIndex==9)// VALIDO HORA 
					{
						try{Convert.ToDateTime(dgAutorizacionValida[9,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
						catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value=DateTime.Now.ToString("HH:mm:ss");dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
					}
					if(e.ColumnIndex==10)// VALIDO HORA 
					{
						Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
						String consulta = "SELECT * FROM TIPOS_COMB WHERE NOMBRE='"+dgAutorizacionValida[10,e.RowIndex].Value.ToString()+"'";
						
						connex.getAbrirConexion(consulta);
						connex.leer=connex.comando.ExecuteReader();
						if(connex.leer.Read())
						{
							dgAutorizacionValida[10,e.RowIndex].Value=connex.leer["NOMBRE"].ToString();
							dgAutorizacionValida[14,0].Value=connex.leer["ID"].ToString();
							dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
						}
						else
						{
							dgAutorizacionValida[10,e.RowIndex].Value="DIESEL";
							dgAutorizacionValida[14,0].Value="1";
							dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
						}
						
						connex.conexion.Close();
					}
				}
			}
		}
		#endregion
		
		#region COLOR ESTATUS
		void colorEstatus()
		{
			for(int x=0; x<dgAutorizacionValida.Rows.Count; x++)
			{
				if(dgAutorizacionValida[15,x].Value.ToString()=="2")
				{
					for(int y=3; y<dgAutorizacionValida.Columns.Count; y++)
					{
						dgAutorizacionValida[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
		}
		#endregion
		
		#region REVISA TERMINO
		void FormHistorialValidacionFormClosing(object sender, FormClosingEventArgs e)
		{
			if(revisaTermino()==true)
			{
				/*refPrincipal.cmdGuardaCarga.Enabled=false;
				refPrincipal.cmdHistorial.Enabled=true;*/
			}
			else
			{
				/*refPrincipal.cmdGuardaCarga.Enabled=true;
				refPrincipal.cmdHistorial.Enabled=false;*/
			}
		}
		
		bool revisaTermino()
		{
			bool respuesta = false;
			for(int x=1; x<dgAutorizacionValida.Rows.Count; x++)
			{
				if(dgAutorizacionValida[4,x].Style.BackColor.Name!="MediumSpringGreen")
				{
					respuesta=true;
				}
			}
			
			return respuesta;
		}
		#endregion
		
		#region	CAMBIOS DE FECHAS
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			if(inicio==false)
				dtpFin.Value=dtpInicio.Value;
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion	
		
		#region	GUARDADO
		void CmdGuardaClick(object sender, EventArgs e)
		{
			for(int x=0; x<dgAutorizacionValida.Rows.Count; x++)
			{
				for(int y=0; y<dgAutorizacionValida.Columns.Count; y++)
				{
					if(dgAutorizacionValida[y,x].Style.BackColor.Name=="Yellow")
					{
						MessageBox.Show("Rows="+x+", Columns="+y);
						/*String consulta ="UPDATE AUTORIZACION SET ID_COM="+((dgAutorizacionValida[14,x].Value.ToString()=="0")?"null":dgAutorizacionValida[14,x].Value.ToString())+", ID_G="+((dgAutorizacionValida[13,x].Value.ToString()=="0")?"null":dgAutorizacionValida[13,x].Value.ToString())+", ID_O="+((dgAutorizacionValida[12,x].Value.ToString()=="0")?"null":dgAutorizacionValida[12,x].Value.ToString())+", FECHA_BASE='"+dgAutorizacionValida[4,x].Value.ToString()+"', HORA_AUTORIZACION='"+dgAutorizacionValida[5,x].Value.ToString()+"', LITROS='"+dgAutorizacionValida[7,x].Value.ToString()+"', KM='"+dgAutorizacionValida[8,x].Value.ToString()+"', HORA_CARGA='"+dgAutorizacionValida[9,x].Value.ToString()+"', ESTATUS='2' WHERE NUMERO='"+dgAutorizacionValida[1,x].Value.ToString()+"'";
			
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();*/
					}
				}
			}	
				
			for(int x=0; x<dgAutorizacionValida.Columns.Count; x++)
			{
				dgAutorizacionValida[x,0].Style.BackColor=Color.White;
			}
			getDatos();
		}
		#endregion		
		
		void DgAutorizacionValidaDoubleClick(object sender, EventArgs e)
		{
			if(dgAutorizacionValida.CurrentRow.Index==0)
			{
				refPrincipal.getTodo(Convert.ToString(dgAutorizacionValida[2,dgAutorizacionValida.CurrentRow.Index].Value), Convert.ToInt64(dgAutorizacionValida[0,dgAutorizacionValida.CurrentRow.Index].Value));
				this.Close();
			}
		}
	}
}
