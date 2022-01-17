using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{	
	public partial class FormOrdenTrabajoEntrada : Form
	{
		#region VARIABLES
		int idordenT;
		int contadorFalla = 0;
		int contadorMecanico = 0;
		int indexFallaEliminar = 0;
		int indexMecanicoEliminar = 0;
		Boolean validarEliminarFalla = false;
		Boolean validarEliminarMEcanico = false;
		#endregion

		#region INSTANCIAS
		Interfaz.Mantenimiento.FormOrdenTrabajo ordenTrabajo = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento conn= new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();		
		#endregion
		
		#region CONSTRUCTOR		
		public FormOrdenTrabajoEntrada(int idOT, Interfaz.Mantenimiento.FormOrdenTrabajo OT)
		{			
			InitializeComponent();
			idordenT = idOT;
			ordenTrabajo = OT;
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
		void FormOrdenTrabajoEntradaLoad(object sender, EventArgs e)
		{
			AdaptadorDataFalla();
			
			lblordent.Text = "Orden de trabajo: " + idordenT;
			
			timeHoraEntrada.Text = DateTime.Now.ToString("HH:MM:ss");
			dtpFechaEntrada.MinDate = DateTime.Now.Date;	
			dtpFechaEntrada.Value = dtpFechaEntrada.MinDate;	
			
			txtMecanicoAgregar.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Alias from OPERADOR where Estatus='1' and tipo_empleado like 'MECANICO%' ", "Alias");
           	txtMecanicoAgregar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMecanicoAgregar.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
			dataMecanicos.ClearSelection();          
			dataFallas.ClearSelection();   
			
			this.txtKilometros.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			this.txtHorasExtras.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}		
		
		void FormOrdenTrabajoEntradaFormClosing(object sender, FormClosingEventArgs e)
		{
			ordenTrabajo.entradavehiculo = false;	
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
			if(txtKilometros.Text.Length > 0 &&  cmbCombustible.Text.Length > 0 )
			{				
				conn.InsertarEntrada(dtpFechaEntrada.Value.ToString("dd/MM/yyyy"), timeHoraEntrada.Value.ToString("HH:mm"), cmbCombustible.Text, txtKilometros.Text, idordenT);
				for(int i = 0; i < dataMecanicos.RowCount; i++){
					conn.InsertarMecanicoOrdenT(Convert.ToString(dataMecanicos.Rows[i].Cells[1].Value), Convert.ToString(dataMecanicos.Rows[i].Cells[0].Value), Convert.ToString(dataMecanicos.Rows[i].Cells[3].Value), Convert.ToString(dataMecanicos.Rows[i].Cells[4].Value), idordenT);
				}					
				for(int i = 0; i < dataFallas.RowCount; i++){
					if(Convert.ToString(dataFallas.Rows[i].Cells[0].Value).Length <= 0){
						conn.InsertarEntradaFallas1(idordenT, Convert.ToString(dataFallas.Rows[i].Cells[2].Value), Convert.ToString(dataFallas.Rows[i].Cells[1].Value), Convert.ToString(dataFallas.Rows[i].Cells[3].Value), Convert.ToString(dataFallas.Rows[i].Cells[4].Value), Convert.ToString(dataFallas.Rows[i].Cells[5].Value), Convert.ToString(dataFallas.Rows[i].Cells[6].Value), 2);
					}	
				}	
				ImprimirOrdenTrabajo();									
				this.Close();				
			}
			else{
				MessageBox.Show("Llena los campos obligatorios", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}									
		}
			
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();			
		}
		
		void BtnagregarMecanicoClick(object sender, EventArgs e)
		{
			if(txtTipoMecanico.Text.Length > 0 && txtMecanicoAgregar.Text.Length > 0 )
			{				
				if(conn.IDMecanicoOperador(txtMecanicoAgregar.Text) != ""){
					dataMecanicos.Rows.Add();
					dataMecanicos.Rows[contadorMecanico].Cells[0].Value = new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().IDMecanicoOperador(txtMecanicoAgregar.Text);
					dataMecanicos.Rows[contadorMecanico].Cells[1].Value = txtTipoMecanico.Text;
					dataMecanicos.Rows[contadorMecanico].Cells[2].Value = txtMecanicoAgregar.Text;
					if(txtHorasExtras.Text.Length > 0){
						dataMecanicos.Rows[contadorMecanico].Cells[3].Value = txtHorasExtras.Text;
						dataMecanicos.Rows[contadorMecanico].Cells[4].Value = txtMotivosMecanico.Text;
					}else{
						dataMecanicos.Rows[contadorMecanico].Cells[3].Value = 0;
						dataMecanicos.Rows[contadorMecanico].Cells[4].Value = "N/A";
					}				
					contadorMecanico++;
					LimpiarCamposMecanicos();
				}else{
					MessageBox.Show("El mecanico que decea ingresar no existe en la base de datos", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}else{
				txtTipoMecanico.Focus();
			}			
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
		#endregion
		
		#region EVENTO TABLAS
		void DataFallasCellClick(object sender, DataGridViewCellEventArgs e)
		{			
			indexFallaEliminar = e.RowIndex;
			validarEliminarFalla = true;		
		}
		
		void DataMecanicosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			indexMecanicoEliminar = e.RowIndex;
			validarEliminarMEcanico = true;		
		}
		#endregion
		
		#region METODOS
		void ImprimirOrdenTrabajo(){
			DialogResult result = MessageBox.Show("¿Desea Imprimir la orden de trabajo","Orden de Trabajo*",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
			if(DialogResult.OK==result)			{
				//ordenTrabajo.PDF();
			}
		}
		
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
		
		void LimpiarCamposMecanicos(){
            txtTipoMecanico.Text = "";
            txtMecanicoAgregar.Text = "";
            txtHorasExtras.Text = "";
            txtMotivosMecanico.Text = "";
            
			dataMecanicos.ClearSelection(); 
			dataFallas.ClearSelection();
		}
		
		void LimpiarCampos(){ 
			dtpFechaEntrada.Value = DateTime.Now.Date;
			timeHoraEntrada.Text = "80:00";
			cmbCombustible.Text = "";
			txtKilometros.Text = "";			
			dataMecanicos.ClearSelection(); 
			dataFallas.ClearSelection();
		}
		
		public void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}		
		
		#endregion
		
		#region MENU
		void EliminarMecánicoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(validarEliminarMEcanico == true)
			{
				dataMecanicos.Rows.RemoveAt(indexMecanicoEliminar);
				contadorMecanico--;
				validarEliminarMEcanico = false;
				dataMecanicos.ClearSelection(); 
				dataFallas.ClearSelection(); 
			}		
		}
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(Convert.ToString(dataFallas.Rows[indexFallaEliminar].Cells[0].Value).Length != 0 )
			{
				if(validarEliminarFalla == true)
				{
					dataFallas.Rows.RemoveAt(indexFallaEliminar);
					contadorFalla--;
					validarEliminarFalla = false;
					dataFallas.ClearSelection(); 
					dataMecanicos.ClearSelection(); 
				}	
			}else{
				MessageBox.Show("No puedes eliminar este tipo de fallas", "Error al eliminar falla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);				
			}
				
		}
		#endregion	
	}
}
