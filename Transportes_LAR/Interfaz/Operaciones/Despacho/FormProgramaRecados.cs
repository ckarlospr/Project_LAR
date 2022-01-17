using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones.Despacho
{
	public partial class FormProgramaRecados : Form
	{
		public FormProgramaRecados(Interfaz.FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		String repite = "2";
		int cant_Rep = 1;
		Int64 ID_O = 0;
		#endregion
		
		#region REFERENCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Interfaz.FormPrincipal refPrincipal;
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region EVENTO LOAD
		void FormProgramaRecadosLoad(object sender, EventArgs e)
		{
			getDatos();
			txtOperadro.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias dato from OPERADOR where tipo_empleado='OPERADOR' and Estatus='1'");
			txtOperadro.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtOperadro.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region LLENADO DEL DATAGRID
		void getDatos()
		{
			dgMsj.Rows.Clear();
			
			String consulta = "select * from MENSAJE_GERECIAL";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				String tipo = getTipo(conn.leer["TIPO"].ToString());
				dgMsj.Rows.Add(conn.leer["ID"].ToString(), conn.leer["MENSAJE"].ToString(), tipo, conn.leer["FECHA_INICIO"].ToString().Substring(0,10), conn.leer["ESTATUS"].ToString(), ((conn.leer["ID_O"].ToString()=="0")?"":conn.leer["ID_O"].ToString()));
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgMsj.Rows.Count; x++)
			{
				if(dgMsj[5,x].Value.ToString()!="")
				{
					consulta = "select * from OPERADOR where ID="+dgMsj[5,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgMsj[5,x].Value=conn.leer["Alias"].ToString();
					}
					
					conn.conexion.Close();
				}
			}
			
			dgMsj.ClearSelection();
		}
		
		String getTipo(String dato)
		{
			String respuesta = "Unico";
			
			if(dato=="1")
				respuesta="Unico";
			else if(dato=="2")
				respuesta="Todos los dias";	
			else if(dato=="3")
				respuesta="Todas las semanas";	
			else if(dato=="4")
				respuesta="Cada dos semanas";	
			else if(dato=="5")
				respuesta="Todos los meses";	
			else 
				respuesta="Todos los años";	
			
			return respuesta;
		}
		#endregion
		
		#region EVENTOS DE LOS BOTONES
		void CmdEliminarClick(object sender, EventArgs e)
		{
			if(dgMsj.SelectedRows.Count>0)
				eliminarDatos();
			else
				MessageBox.Show("Seleccione un registro.");
		}
		
		void CmdModificarClick(object sender, EventArgs e)
		{
			dgMsj.ClearSelection();
			limpiaCampos();
		}
		
		void AgregarClick(object sender, EventArgs e)
		{
			if(dgMsj.SelectedRows.Count>0)
			{
				modificarDatos();
			}
			else
			{
				guardaDatos();
				limpiaCampos();
				getDatos();
			}
		}
		#endregion
		
		#region GUARDAR
		void guardaDatos()
		{			
			if(txtMensaje.Text!="")
			{ 
				if( cbOperador.Checked==true && ID_O==0)
				{
					MessageBox.Show("Es necesario que ingrese el nick del operador.");
				}
				else
				{
					String sentencia = "insert into MENSAJE_GERECIAL values ('"+txtMensaje.Text+"','"+((cbActivar.Checked==false)?"0":"1")+"','"+repite+"','"+cant_Rep+"','OPERACIONES', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"','"+refPrincipal.idUsuario+"',(SELECT CONVERT (DATE, SYSDATETIME())),(SELECT CONVERT (TIME, SYSDATETIME())), "+ID_O+");";
							
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
			}
			else
			{
				MessageBox.Show("Es necesario que ingrese un mensaje.");
			}
		}
		#endregion
		
		#region MODIFICAR
		void modificarDatos()
		{
			if( cbOperador.Checked==true && ID_O==0)
			{
				MessageBox.Show("Es necesario que ingrese el nick del operador.");
			}
			else
			{
				String sentencia = "update MENSAJE_GERECIAL set ID_O='"+ID_O+"', MENSAJE='"+txtMensaje.Text+"', ESTATUS='"+((cbActivar.Checked==false)?"0":"1")+"', TIPO='"+repite+"', CANTIDAD='"+cant_Rep+"', FECHA_INICIO='"+dtpFecha.Value.ToString("dd/MM/yyyy")+"' where id="+dgMsj[0,dgMsj.CurrentRow.Index].Value.ToString();
				
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				dgMsj.ClearSelection();
				getDatos();
				limpiaCampos();	
			}
		}
		#endregion
		
		#region ELIMINAR
		void eliminarDatos()
		{
			String sentencia = "delete from MENSAJE_GERECIAL where id="+dgMsj[0,dgMsj.CurrentRow.Index].Value.ToString();
						
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			dgMsj.Rows.RemoveAt(dgMsj.CurrentRow.Index);
			limpiaCampos();
		}
		#endregion
		
		#region LIMPIA DATOS
		void limpiaCampos()
		{
			cbActivar.Checked=true;
			rbDias.Checked=true;
			txtMensaje.Text="";
			dtpFecha.Value=DateTime.Now;
			dgMsj.ClearSelection();
			ID_O=0;
			cbOperador.Checked=false;
		}
		#endregion
		
		#region TIPO DE REPETICION
		void RbUnicoCheckedChanged(object sender, EventArgs e)
		{
			repite="1";
			cant_Rep = 0;
		}
		
		void RbDiasCheckedChanged(object sender, EventArgs e)
		{
			repite="2";
			cant_Rep = 1;
		}
		
		void RbSemanalCheckedChanged(object sender, EventArgs e)
		{
			repite="3";
			cant_Rep = 7;
		}
		
		void RbDosSemCheckedChanged(object sender, EventArgs e)
		{
			repite="4";
			cant_Rep = 14;
		}
		
		void RbMesesCheckedChanged(object sender, EventArgs e)
		{
			repite="5";
			cant_Rep = 30;
		}
		
		void RbAnioCheckedChanged(object sender, EventArgs e)
		{
			repite="6";
			cant_Rep = 365;
		}
		#endregion
		
		#region CELLCLICK
		void DgMsjCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgMsj[4,e.RowIndex].Value.ToString()=="1")
				cbActivar.Checked=true;
			else
				cbActivar.Checked=false;
			
			if(dgMsj[2,e.RowIndex].Value.ToString()=="Unico")
				rbDias.Checked=true;
			else if(dgMsj[2,e.RowIndex].Value.ToString()=="Todos los dias")
				rbDias.Checked=true;
			else if(dgMsj[2,e.RowIndex].Value.ToString()=="Todas las semanas")
				rbSemanal.Checked=true;
			else if(dgMsj[2,e.RowIndex].Value.ToString()=="Cada dos semanas")
				rbDosSem.Checked=true;
			else if(dgMsj[2,e.RowIndex].Value.ToString()=="Todos los meses")
				rbMeses.Checked=true;
			else 
				rbAnio.Checked=true;
			
			dtpFecha.Value=Convert.ToDateTime(dgMsj[3,e.RowIndex].Value.ToString());
			txtMensaje.Text=dgMsj[1,e.RowIndex].Value.ToString();
		}
		#endregion
		
		#region BUSQUEDA DEL OPERADOR
		void TxtOperadroKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta = "select * from OPERADOR where Alias='"+txtOperadro.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_O=Convert.ToInt64(conn.leer["ID"]);
				}
				else
				{
					ID_O=0;
				}
				
				conn.conexion.Close();
			}
		}
		
		void CbOperadorCheckedChanged(object sender, EventArgs e)
		{
			if(cbOperador.Checked==true)
			{
				txtOperadro.Enabled=true;
			}
			else
			{
				txtOperadro.Enabled=false;
				txtOperadro.Text="";
				ID_O=0;
			}
		}
		#endregion
	}
}
