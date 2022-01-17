using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	public partial class FormAnticipos : Form
	{
		
		public FormAnticipos(String id_re, FormReporte rep, int tipo)
		{
			InitializeComponent();
			refReporte=rep;
			ID=id_re;
			TIPO=tipo;
		}
		
		#region VARIABLES
		String ID;
		int TIPO;
		String consulta;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		FormReporte refReporte;
		#endregion
		
		#region EVENTO LOAD
		void FormAnticiposLoad(object sender, EventArgs e)
		{
			if(TIPO==1)
			{
				consulta="select ID, CANTIDAD, NUMERO, FECHA, ESTATUS, ID_U, ETIQUETA, cometario from ANTICIPOS_ESPECIALES where TIPO!='DEPOSITO' and ID_RE="+ID;
			}
			else
			{
				lblTitulo.Text="Pagos depositados";
				consulta="select ID, CANTIDAD, NUMERO, FECHA, ESTATUS, ID_U, ETIQUETA, cometario from ANTICIPOS_ESPECIALES where TIPO='DEPOSITO' and ID_RE="+ID;
			}
			
			getDatos();
		}
		#endregion
		
		#region GETDATOS
		void getDatos()
		{
			Double suma=0.0;
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["CANTIDAD"].ToString(), conn.leer["NUMERO"].ToString(), ((conn.leer["ESTATUS"].ToString()=="0")?"NO":"SI"), "NULL", conn.leer["ID_U"].ToString(), conn.leer["ETIQUETA"].ToString(), conn.leer["cometario"].ToString());
			}
			
			conn.conexion.Close();
			
			for(int x=0;  x<dgDatos.Rows.Count; x++)
			{
				if(dgDatos[6,x].Value.ToString()!="")
				{
					string cons="select usuario from usuario where id_usuario="+dgDatos[6,x].Value.ToString();
					conn.getAbrirConexion(cons);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgDatos[5,x].Value=conn.leer["usuario"].ToString().ToUpper();
					}
					else
					{
						dgDatos[5,x].Value="NULL";
					}
					
					conn.conexion.Close();
					
					if(dgDatos[4,x].Value.ToString()=="SI")
					{
						dgDatos[5,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
				
				if(dgDatos[4,x].Value.ToString()=="SI")
					dgDatos[2,x].Style.BackColor=Color.MediumSpringGreen;
				
				suma=suma+Convert.ToDouble(dgDatos[2,x].Value);
			}
			
			txtTotal.Text=suma.ToString("C");
			
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CmdValidarClick(object sender, EventArgs e)
		{
			if(dgDatos.SelectedRows.Count>0)
			{
				if(dgDatos[4,dgDatos.CurrentRow.Index].Value.ToString()=="NO")
				{
					String miconsult="update ANTICIPOS_ESPECIALES set ESTATUS='1', ID_U='"+refReporte.refPrincipal.idUsuario+"', FECHA_CONFIRMADO=(SELECT CONVERT (DATE, SYSDATETIME())) where ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(miconsult);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					dgDatos[2,dgDatos.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					dgDatos[5,dgDatos.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					dgDatos[4,dgDatos.CurrentRow.Index].Value="SI";
					dgDatos[5,dgDatos.CurrentRow.Index].Value=refReporte.refPrincipal.nombreUsuario;
					
					if(TIPO==1)
					{
						refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value=(Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(dgDatos[2,dgDatos.CurrentRow.Index].Value)).ToString();
						bool cambia=false;
						for(int x=0; x<dgDatos.Rows.Count; x++)
						{
							if(dgDatos[4,x].Value.ToString()=="NO")
							{
								cambia=true;
							}
						}
						
						if(cambia==false)
						{
							refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
						}
						
						refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value);//+Convert.ToDouble(refReporte.dgReporte[11,refReporte.dgReporte.CurrentRow.Index].Value);
						
						refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value)-Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value);
					
						if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
						{
							refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
						}
						
						if(Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value)==Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value) && refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Red")
							refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
						else if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name=="Red" && refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
							refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					}
					else
					{
						refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value=(Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(dgDatos[2,dgDatos.CurrentRow.Index].Value)).ToString();
						bool cambia=false;
						for(int x=0; x<dgDatos.Rows.Count; x++)
						{
							if(dgDatos[4,x].Value.ToString()=="NO")
							{
								cambia=true;
							}
						}
						
						if(cambia==false)
						{
							refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
						}
						
						refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value);//+Convert.ToDouble(refReporte.dgReporte[11,refReporte.dgReporte.CurrentRow.Index].Value);
						
						refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value)-Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value);
					
						if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
						{
							refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
						}
						
						if(Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value)==Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value) && refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Red")
							refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
						else if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name=="Red" && refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
							refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					}
					
					dgDatos.ClearSelection();
				}
			}
		}
		#endregion
		
		void CmdModificarClick(object sender, EventArgs e)
		{
			String sentencia = "UPDATE ANTICIPOS_ESPECIALES set FECHA='"+dtpFecha.Value.ToString("dd/MM/yyyy")+"' WHERE ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
						
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			dgDatos[1,dgDatos.CurrentRow.Index].Value=dtpFecha.Value.ToString("dd/MM/yyyy");
		}
		
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			dtpFecha.Value=Convert.ToDateTime(dgDatos[1,e.RowIndex].Value.ToString());
		}
	}
}
