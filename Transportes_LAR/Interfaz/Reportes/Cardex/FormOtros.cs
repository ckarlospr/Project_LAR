using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes.Cardex
{
	public partial class FormOtros : Form
	{
		public FormOtros(FormCardex refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		String TIPO = "C";
		Int64 ID_OPP = 0;
		#endregion
		
		#region INSTANCIAS
		public FormCardex refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region
		void FormOtrosLoad(object sender, EventArgs e)
		{
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR'");
			txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			getDatos();
			cmbTurno.SelectedIndex=0;
		}
		#endregion
		
		#region GUARDA DATOS
		void CmdGuardaClick(object sender, EventArgs e)
		{
			if(dgOperador.SelectedRows.Count>0)
			{
				if(cmbTurno.Text!="Turno")
				{
					if(txtComentario.Text!="")
					{
						guardaDatos();
						limpiaDatos();
					}
					else
					{
						MessageBox.Show("Ingrese comentario");
					}
				}
				else
				{
					MessageBox.Show("Seleccione un turno");
				}
			}
			else
			{
				MessageBox.Show("Seleccione un operador");
			}
		}
		
		void limpiaDatos()
		{
			dgOperador.ClearSelection();
			cmbTurno.SelectedIndex=0;
			txtComentario.Text="";
			txtOperador.Text="";
			txtOperador.Focus();
		}
		#endregion
		
		#region GUARDADO DE DATOS
		void guardaDatos()
		{
			new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe2(ID_OPP,TIPO,txtComentario.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), cmbTurno.Text, refPrincipal.refPrincipal.idUsuario);
						
			conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '"+cmbTurno.Text+"', '"+TIPO+"', '"+txtComentario.Text+"', "+refPrincipal.refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region	GET DATOS DG
		void getDatos()
		{
			dgOperador.Rows.Clear();
			
			String consulta = "select ID, Alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' and Alias like '%"+txtOperador.Text+"%'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgOperador.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString());
			}
			
			conn.conexion.Close();
			
			dgOperador.ClearSelection();
		}
		#endregion
		
		#region EVENTO CHECKED
		void RbDormidaCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "D";
		}
		
		void RbTallerCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "T";
		}
		
		void RbPermisoCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "P";
		}
		
		void RbIncapacidadCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "I";
		}
		
		void RbCombustibleCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "C";
		}
		
		void RbNoAutorizadoCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "N";
		}
		
		void RbExcesoCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "X";
		}
		
		void RbChoqueCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "H";
		}
		
		void RbVentasCheckedChanged(object sender, EventArgs e)
		{
			TIPO = "V";
		}
		#endregion
		
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				dgOperador.ClearSelection();
				
				for(int x=0; x<dgOperador.Rows.Count; x++)
				{
					if(txtOperador.Text==dgOperador[1,x].Value.ToString())
					{
						dgOperador.Rows[x].Selected = true;
						dgOperador.FirstDisplayedCell = dgOperador.Rows[x].Cells[1];
						
						ID_OPP = Convert.ToInt16(dgOperador[0,x].Value);
					}
				}
			}
		}
		
		
	}
}
