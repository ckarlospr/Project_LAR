using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{	
	public partial class FormOrdenTrabajoModificaMecanico : Form
	{		
		#region VARIABLES
		int idordenT;
		int contadorFalla = 0;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento connI= new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();	
		Interfaz.Mantenimiento.FormOrdenTrabajo ordenTrabajo = null;				
		#endregion
		
		#region CONSTRUCTOR
		public FormOrdenTrabajoModificaMecanico(int idOT, Interfaz.Mantenimiento.FormOrdenTrabajo OT)
		{			
			InitializeComponent();
			idordenT = idOT;
			ordenTrabajo = OT;
		}
		#endregion		
		
		#region ADAPTADOR
		void AdaptadorDataMecanico()
		{		
			int contador = 0;
			dataMecanicos.Rows.Clear();
			dataMecanicos.ClearSelection();
			conn.getAbrirConexion("SELECT OM.*, O.ALIAS AS MECANICO FROM ORDENTRABAJO_MECANICO OM, OPERADOR O WHERE  OM.ID_MECANICO = O.ID AND ESTADO_ACTUAL = 1 AND OM.ID_OREDENTRABAJO = " + idordenT);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataMecanicos.Rows.Add();
				dataMecanicos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataMecanicos.Rows[contador].Cells[1].Value = conn.leer["TIPO_MECANICO"].ToString();
				dataMecanicos.Rows[contador].Cells[2].Value = conn.leer["MECANICO"].ToString();
				dataMecanicos.Rows[contador].Cells[3].Value = conn.leer["HORAS_EXTRAS"].ToString();
				dataMecanicos.Rows[contador].Cells[4].Value = conn.leer["MOTIVOS"].ToString();
				++contador;
			}
			conn.conexion.Close();			
		}
		
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
		void FormOrdenTrabajoModificaMecanicoLoad(object sender, EventArgs e)
		{
			lblordent.Text = "Orden de trabajo: " + idordenT;
			dataMecanicos.ClearSelection();
			dataFallas.ClearSelection();
			AdaptadorDataFalla();			
			AdaptadorDataMecanico();	
			
			}
		
		void FormOrdenTrabajoModificaMecanicoFormClosing(object sender, FormClosingEventArgs e)
		{			
			ordenTrabajo.modificarmecanico = false;	
			ordenTrabajo.LimpriarVariablesyTablasyCampos();
			ordenTrabajo.dataGenerada.ClearSelection();
			ordenTrabajo.dataOrdenTDIA.ClearSelection();
			ordenTrabajo.dataOrdenTQuedan.ClearSelection();	
			ordenTrabajo.dataFallasPendientes.ClearSelection();				
		}
		#endregion				
		
		#region METODOS
		void LimpiarCamposFallas(){
        txtTipoFalla.Text = "";
        txtOrigen.Text = "";
        txtDescripcionFalla.Text = "";
        cmbTipoTaller.Text = null;
        txtNombreTaller.Text = "";
        txtDescripcionReparacion.Text = "";            
		dataMecanicos.ClearSelection(); 
		dataFallas.ClearSelection();
		}
		#endregion			
		
		#region BOTONES		
		void BtnGuardarClick(object sender, EventArgs e)
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
				LimpiarCamposFallas();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{			
			for(int i = 0; i < dataFallas.RowCount; i++){
				if(Convert.ToString(dataFallas.Rows[i].Cells[0].Value).Length <= 0){
					connI.InsertarEntradaFallas1(idordenT, Convert.ToString(dataFallas.Rows[i].Cells[2].Value), Convert.ToString(dataFallas.Rows[i].Cells[1].Value), Convert.ToString(dataFallas.Rows[i].Cells[3].Value), Convert.ToString(dataFallas.Rows[i].Cells[4].Value), Convert.ToString(dataFallas.Rows[i].Cells[5].Value), Convert.ToString(dataFallas.Rows[i].Cells[6].Value), 3);
				}	
			}
			this.Close();
		}		
		#endregion
						
		#region Eventos DE TABLAS	
		
			#region FALLAS
			void DataMecanicosCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
			{
				if (e.ColumnIndex == 5 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataMecanicos.Rows[e.RowIndex].Cells[5] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
			}
			
			void DataMecanicosCellContentClick(object sender, DataGridViewCellEventArgs e)
			{
				if (e.ColumnIndex == 5 && e.RowIndex >= 0)
	  			{
					new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().EliminarMecanico(dataMecanicos.Rows[e.RowIndex].Cells[0].Value.ToString());
					AdaptadorDataFalla();			
					AdaptadorDataMecanico();
				}
			}
			
			void DatafallasCellEndEdit(object sender, DataGridViewCellEventArgs e)
			{
				new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().ActualizarFalla(Convert.ToString(dataFallas.Rows[e.RowIndex].Cells[1].Value), Convert.ToString(dataFallas.Rows[e.RowIndex].Cells[2].Value), Convert.ToString(dataFallas.Rows[e.RowIndex].Cells[3].Value), Convert.ToString(dataFallas.Rows[e.RowIndex].Cells[4].Value), Convert.ToString(dataFallas.Rows[e.RowIndex].Cells[0].Value));
			
			}
			#endregion	
			
			#region MECANICOS
			void DatafallasCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
			{
				
				if (e.ColumnIndex == 5 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataMecanicos.Rows[e.RowIndex].Cells[5] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
			}	
			
			void DatafallasCellContentClick(object sender, DataGridViewCellEventArgs e)
			{
				if (e.ColumnIndex == 5 && e.RowIndex >= 0)
	  			{
					new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().EliminarFalla(dataFallas.Rows[e.RowIndex].Cells[0].Value.ToString());
					AdaptadorDataFalla();			
					AdaptadorDataMecanico();
				}
			}
			
			void DataMecanicosCellEndEdit(object sender, DataGridViewCellEventArgs e)
			{
				new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().ActualizarMecanico(Convert.ToString(dataMecanicos.Rows[e.RowIndex].Cells[1].Value), Convert.ToString(dataMecanicos.Rows[e.RowIndex].Cells[3].Value), Convert.ToString(dataMecanicos.Rows[e.RowIndex].Cells[4].Value), Convert.ToString(dataMecanicos.Rows[e.RowIndex].Cells[0].Value));
			}
			#endregion				
		#endregion	
	}
}
