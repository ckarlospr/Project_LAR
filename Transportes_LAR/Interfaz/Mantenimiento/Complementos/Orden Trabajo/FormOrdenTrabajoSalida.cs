using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{	
	public partial class FormOrdenTrabajoSalida : Form
	{		
		#region VARIABLES		
		int idordenT;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento conn= new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.Mantenimiento.FormOrdenTrabajo ordenTrabajo = null;	
		#endregion
		
		#region CONSTRUCTORES		
		public FormOrdenTrabajoSalida(int idOT, Interfaz.Mantenimiento.FormOrdenTrabajo OT)
		{
			InitializeComponent();
			idordenT = idOT;
			ordenTrabajo = OT;			
		}
		#endregion
		
		#region ADAPTADOR		
		void AdaptadorDataFalla()
		{				
			int contador = 0;				
			dataFallas.ClearSelection();
			conn.getAbrirConexion("SELECT * FROM ORDENTRABAJO_FALLA  WHERE ESTADO = 1  OR ESTADO = 3 AND ID_OREDENTRABAJO = " + idordenT);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataFallas.Rows.Add();
				dataFallas.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();				
				dataFallas.Rows[contador].Cells[2].Value = conn.leer["TIPO_FALLA"].ToString();
				dataFallas.Rows[contador].Cells[3].Value = conn.leer["REPORTO_FALLA"].ToString();
				dataFallas.Rows[contador].Cells[4].Value = conn.leer["DESCRIPCION_FALLA"].ToString();
				dataFallas.Rows[contador].Cells[5].Value = conn.leer["TIPO_TALLER"].ToString();
				dataFallas.Rows[contador].Cells[6].Value = conn.leer["NOMBRE_TALLER"].ToString();
				dataFallas.Rows[contador].Cells[7].Value = conn.leer["DESCRIPCION_REPARACION"].ToString();
				++contador;				
			}
			conn.conexion.Close();			
		}
		#endregion
		
		#region INICIO - TERMINO 
		void FormOrdenTrabajoSalidaLoad(object sender, EventArgs e)
		{
			lblordent.Text = "Orden de trabajo: " + idordenT;
			AdaptadorDataFalla();
			dtpFechaSalida.MinDate = DateTime.Now.Date;	
			dtpFechaSalida.Value = dtpFechaSalida.MinDate;	
			timeHoraSalida.Text = DateTime.Now.ToString("HH:MM:ss");
			this.txtKilometros.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		
		void FormOrdenTrabajoSalidaFormClosing(object sender, FormClosingEventArgs e)
		{
			ordenTrabajo.salidavehiculo = false;
			ordenTrabajo.LimpriarVariablesyTablasyCampos();
			ordenTrabajo.dataGenerada.ClearSelection();
			ordenTrabajo.dataOrdenTDIA.ClearSelection();
			ordenTrabajo.dataOrdenTQuedan.ClearSelection();
			ordenTrabajo.dataFallasPendientes.ClearSelection();	
		}
		#endregion		
		
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(cmbCombustible.Text.Length > 0 && txtKilometros.Text.Length > 0)
			{		
				new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().InsertarSalida(txtKilometros.Text, cmbCombustible.Text, txtComentarios.Text, dtpFechaSalida.Value.ToString("dd/MM/yyyy"), timeHoraSalida.Value.ToString("HH:mm"), idordenT);
				for(int i = 0; i < dataFallas.RowCount; i++){
					if (Convert.ToBoolean(dataFallas.Rows[i].Cells[1].EditedFormattedValue) == false)
	                {
	                	conn.EstadoFalla(3, dataFallas.Rows[i].Cells[0].Value.ToString());               	
	                }
				}	
				this.Close();				
			}
			else{
				MessageBox.Show("Ingresa Combustible y Kilometros", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
			
		#region EVENTOS		
		void DataFallasCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1 && e.RowIndex >= 0)
  			{
                if (Convert.ToBoolean(dataFallas.Rows[e.RowIndex].Cells[1].EditedFormattedValue) == true)
                {
                	conn.EstadoFalla(2, dataFallas.Rows[e.RowIndex].Cells[0].Value.ToString());                	
                }
			}	   
		}
		#endregion
		
	}
}