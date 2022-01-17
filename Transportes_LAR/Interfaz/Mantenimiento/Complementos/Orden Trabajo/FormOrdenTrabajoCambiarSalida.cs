using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	public partial class FormOrdenTrabajoCambiarSalida : Form
	{
		#region VARIABLES
		int idordenT;
		int contadorFalla = 0;
		#endregion
		
		#region INSTANCIAS
		Interfaz.Mantenimiento.FormOrdenTrabajo ordenTrabajo = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();		
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento connI= new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();	
		#endregion
		
		#region CONSTRUCTORES		
		public FormOrdenTrabajoCambiarSalida(int idOT, Interfaz.Mantenimiento.FormOrdenTrabajo OT)
		{
			InitializeComponent();
			ordenTrabajo = OT;
			idordenT = idOT;
		}
		#endregion
		
		#region ADAPTADOR		
		void AdaptadorDataFalla()
		{			
			dataFallas.ClearSelection();
			conn.getAbrirConexion("SELECT * FROM ORDENTRABAJO_FALLA  WHERE ESTADO = 1 AND ID_OREDENTRABAJO = " + idordenT);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataFallas.Rows.Add();
				dataFallas.Rows[contadorFalla].Cells[0].Value = conn.leer["ID"].ToString();
				dataFallas.Rows[contadorFalla].Cells[1].Value = conn.leer["TIPO_FALLA"].ToString();
				dataFallas.Rows[contadorFalla].Cells[2].Value = conn.leer["REPORTO_FALLA"].ToString();
				dataFallas.Rows[contadorFalla].Cells[3].Value = conn.leer["DESCRIPCION_FALLA"].ToString();
				dataFallas.Rows[contadorFalla].Cells[4].Value = conn.leer["TIPO_TALLER"].ToString();
				dataFallas.Rows[contadorFalla].Cells[5].Value = conn.leer["NOMBRE_TALLER"].ToString();
				dataFallas.Rows[contadorFalla].Cells[6].Value = conn.leer["DESCRIPCION_REPARACION"].ToString();
				++contadorFalla;				
				foreach (DataGridViewRow row in dataFallas.Rows)
				{
					if(Convert.ToString(row.Cells[0].Value).Length > 0)
						row.DefaultCellStyle.BackColor = Color.LightBlue;
				}
			}
			conn.conexion.Close();			
		}
		#endregion
		
		#region INICIO - TERMINO
		void FormOrdenTrabajoCambiarSalidaLoad(object sender, EventArgs e)
		{
			lblordent.Text = "Orden de trabajo: " + idordenT;
			dtpFechaEstimada.MinDate = DateTime.Now.Date;	
			dtpFechaEstimada.Value = dtpFechaEstimada.MinDate;	
			AdaptadorDataFalla();
		}
		
		void FormOrdenTrabajoCambiarSalidaFormClosing(object sender, FormClosingEventArgs e)
		{
			ordenTrabajo.cambiarsalida = false;	
			ordenTrabajo.LimpriarVariablesyTablasyCampos();	
			ordenTrabajo.dataFallasPendientes.ClearSelection();
			ordenTrabajo.dataGenerada.ClearSelection();
			ordenTrabajo.dataOrdenTDIA.ClearSelection();
			ordenTrabajo.dataOrdenTQuedan.ClearSelection();				
		}
		#endregion
		
		#region BOTONES
		void BtnCambiarClick(object sender, EventArgs e)
		{
			if(dtpFechaEstimada.Text.Length > 0 && txtMotivosSalida.Text.Length > 0){
				new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().CambiarSalida(dtpFechaEstimada.Text, txtMotivosSalida.Text, idordenT);
				for(int i = 0; i < dataFallas.RowCount; i++){
					if(Convert.ToString(dataFallas.Rows[i].Cells[0].Value).Length <= 0){
						connI.InsertarEntradaFallas1(idordenT, Convert.ToString(dataFallas.Rows[i].Cells[2].Value), Convert.ToString(dataFallas.Rows[i].Cells[1].Value), Convert.ToString(dataFallas.Rows[i].Cells[3].Value), Convert.ToString(dataFallas.Rows[i].Cells[4].Value), Convert.ToString(dataFallas.Rows[i].Cells[5].Value), Convert.ToString(dataFallas.Rows[i].Cells[6].Value), 3);
					}	
				}
				this.Close();				
			}
			else{
				MessageBox.Show("Ingresa Fecha estimada  y los motivos", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnagregarFallaClick(object sender, EventArgs e)
		{
			if(txtTipoFalla.Text.Length > 0 && txtNombreTaller.Text.Length > 0 && cmbTipoTaller.Text.Length > 0)
			{				
				dataFallas.Rows.Add();
				dataFallas.Rows[contadorFalla].Cells[1].Value = txtTipoFalla.Text;
				dataFallas.Rows[contadorFalla].Cells[2].Value = txtOrigen.Text;
				dataFallas.Rows[contadorFalla].Cells[3].Value = txtDescripcionFalla.Text;
				dataFallas.Rows[contadorFalla].Cells[4].Value = cmbTipoTaller.Text;
				dataFallas.Rows[contadorFalla].Cells[5].Value = txtNombreTaller.Text;
				dataFallas.Rows[contadorFalla].Cells[6].Value = txtDescripcionReparacion.Text;						
				contadorFalla++;
			}
		}
		#endregion
	}
}
