/* 
 Flujo de orden de compra
 1 : Genera Orden T
 2 : Entrada de Vehiculo
 3 : Prestamos
 4 : Salida de vehiculo
 0 : Cancelada o eliminada
 */
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Linq.Expressions;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace Transportes_LAR.Interfaz.Mantenimiento
{	
	public partial class FormOrdenTrabajo : Form
	{		
		#region VARIABLES		
		int contadorFalla = 0;		
		int idOrdenTrabajo = 0 ;					
		int indexFallaEliminar = 0;		
		int idOrdenTrabajoCambiaSalida = 0 ;
		int idOrdentrabajoEliminaryEntrada = 0;
		String fechecarpeta = "";
		String consultaFiltros = "SELECT V.Numero AS VEHICULO, O.Alias AS OPERADOR, OT.TIPO_MANTENIMIENTO AS MANTENIEMINTO, ot.FECHA_INGRESO AS INGRESO, OT.HORA_INGRESO AS HORAINGRESO, OT.FECHA_SALIDA AS SALIDA," +
								 "OT.HORA_SALIDA AS HORASALIDA, OTF.ID AS FALLA, OTF.REPORTO_FALLA AS ORIGEN, OTF.TIPO_FALLA AS TIPOFALLA, OTF.DESCRIPCION_FALLA AS DESFALLA, OTF.TIPO_TALLER AS TIPOTALLER, " + 
								 "OTF.NOMBRE_TALLER AS TALLER, OTF.DESCRIPCION_REPARACION AS DESREPARACION, OTF.ESTADO AS ESTADO FROM VEHICULO V, OPERADOR O, ORDEN_TRABAJO OT, ORDENTRABAJO_FALLA OTF WHERE " +
								 "OT.ID_OPERADOR = O.ID and OT.ID_VEHICULO = V.ID and OT.ID = OTF.ID_OREDENTRABAJO";
		Boolean validarEliminarFalla = false;	
		#endregion
			
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento connM = new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		
		Interfaz.FormPrincipal principal = null;		
		private Proceso.FormatosPDF PDFs= new Transportes_LAR.Proceso.FormatosPDF();
		private Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormCancelarOrdenTrabajo formcancelarot = null;
		private Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoSalida formsalidavehiculo = null;
		private Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoEntrada formentradavehiculo = null;	
		private Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoCambiarSalida formcambiarsalida = null;			
		private Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoFallasReportadas formfallasreportadas = null;	
		private Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoModificaMecanico formmodificarmecanico = null;
		
		#endregion
		
		#region	CONTROL_DE_VENTANAS_ABIERTAS		
		public bool cambiarsalida = false;
		public bool salidavehiculo = false;
		public bool entradavehiculo = false;
		public bool fallasreportadas = false;
		public bool modificarmecanico = false;	
		public bool cancelarordentrabajo = false;		
		#endregion				
		
		#region CONSTRUCTORES
		public FormOrdenTrabajo(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;			
		}		
		#endregion
		
		#region ADAPTADOR
		public void LlenarTabla1()
		{				
			ColoresAlternadosRows(dataGenerada);
			int contador = 0;
			dataGenerada.Rows.Clear();
			dataGenerada.ClearSelection();
			conn.getAbrirConexion("SELECT ot.*, CONVERT(CHAR(10),ot.FECHA_PROGRAMADA, 103) as FECHA,  v.Numero, o.alias AS NombreOperador from ORDEN_TRABAJO ot, VEHICULO v, OPERADOR o where ot.ID_VEHICULO = v.ID  AND ot.ID_OPERADOR = o.ID AND ot.flujo = 1 AND ot.ESTADO_ACTUAL = 1");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataGenerada.Rows.Add();
				dataGenerada.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataGenerada.Rows[contador].Cells[1].Value = conn.leer["TIPO_MANTENIMIENTO"].ToString();
				dataGenerada.Rows[contador].Cells[2].Value = conn.leer["CODIGO"].ToString();
				dataGenerada.Rows[contador].Cells[3].Value = conn.leer["NombreOperador"].ToString();
				dataGenerada.Rows[contador].Cells[4].Value = conn.leer["Numero"].ToString();
				dataGenerada.Rows[contador].Cells[5].Value = conn.leer["FECHA"].ToString();
				dataGenerada.Rows[contador].Cells[6].Value = conn.leer["HORA_PROGRAMADA"].ToString();
				++contador;	
				foreach (DataGridViewRow row in dataGenerada.Rows)
				{
					if(Convert.ToDateTime(row.Cells[5].Value) < DateTime.Now.Date)
						row.DefaultCellStyle.BackColor = Color.Gray;
				}
			}
			conn.conexion.Close();
		}	
		
		public void LlenarTabla2()
		{				
			ColoresAlternadosRows(dataOrdenTDIA);
			int contador = 0;
			dataOrdenTDIA.Rows.Clear();
			dataOrdenTDIA.ClearSelection();
			conn.getAbrirConexion("select ot.*, v.Numero, o.alias AS NombreOperador from ORDEN_TRABAJO ot, VEHICULO v, OPERADOR o where ot.ID_VEHICULO = v.ID  AND ot.ID_OPERADOR = o.ID AND ot.flujo = 2 AND ot.ESTADO_ACTUAL = 1");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataOrdenTDIA.Rows.Add();
				dataOrdenTDIA.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataOrdenTDIA.Rows[contador].Cells[1].Value = conn.leer["TIPO_MANTENIMIENTO"].ToString();
				dataOrdenTDIA.Rows[contador].Cells[2].Value = conn.leer["NombreOperador"].ToString();
				dataOrdenTDIA.Rows[contador].Cells[3].Value = conn.leer["Numero"].ToString();
				dataOrdenTDIA.Rows[contador].Cells[4].Value = conn.leer["CODIGO"].ToString();
				dataOrdenTDIA.Rows[contador].Cells[5].Value = conn.leer["FECHA_INGRESO"].ToString();
				dataOrdenTDIA.Rows[contador].Cells[6].Value = conn.leer["HORA_INGRESO"].ToString();
				++contador;	
			}
			conn.conexion.Close();
		}	

		public void LlenarTabla3()
		{				
			ColoresAlternadosRows(dataOrdenTQuedan);
			int contador = 0;
			dataOrdenTQuedan.Rows.Clear();
			dataOrdenTQuedan.ClearSelection();
			conn.getAbrirConexion("select ot.*, v.Numero, o.alias AS NombreOperador from ORDEN_TRABAJO ot, VEHICULO v, OPERADOR o where ot.ID_VEHICULO = v.ID  AND ot.ID_OPERADOR = o.ID AND ot.flujo = 3 AND ot.ESTADO_ACTUAL = 1");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataOrdenTQuedan.Rows.Add();
				dataOrdenTQuedan.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataOrdenTQuedan.Rows[contador].Cells[1].Value = conn.leer["NombreOperador"].ToString();
				dataOrdenTQuedan.Rows[contador].Cells[2].Value = conn.leer["Numero"].ToString();
				dataOrdenTQuedan.Rows[contador].Cells[3].Value = conn.leer["CODIGO"].ToString();
				dataOrdenTQuedan.Rows[contador].Cells[4].Value = conn.leer["FECHA_INGRESO"].ToString();
				dataOrdenTQuedan.Rows[contador].Cells[5].Value = conn.leer["HORA_INGRESO"].ToString();
				dataOrdenTQuedan.Rows[contador].Cells[6].Value = conn.leer["FECHA_SALIDA_ESTIMADA"].ToString();
				++contador;	
			}
			conn.conexion.Close();
		}				
			
		public void LlenarFallasPendientes(String consulta)
		{		
			int contador = 0;	
			dataFallasPendientes.Rows.Clear();
			dataFallasPendientes.ClearSelection();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{								 	
				dataFallasPendientes.Rows.Add();
				dataFallasPendientes.Rows[contador].Cells[0].Value = conn.leer["FALLA"].ToString();
				dataFallasPendientes.Rows[contador].Cells[1].Value = conn.leer["VEHICULO"].ToString();
				dataFallasPendientes.Rows[contador].Cells[2].Value = conn.leer["OPERADOR"].ToString();
				dataFallasPendientes.Rows[contador].Cells[3].Value = conn.leer["INGRESO"].ToString();
				dataFallasPendientes.Rows[contador].Cells[4].Value = conn.leer["HORAINGRESO"].ToString();
				dataFallasPendientes.Rows[contador].Cells[5].Value = conn.leer["SALIDA"].ToString();
				dataFallasPendientes.Rows[contador].Cells[6].Value = conn.leer["HORASALIDA"].ToString();
				dataFallasPendientes.Rows[contador].Cells[7].Value = conn.leer["TIPOFALLA"].ToString();
				dataFallasPendientes.Rows[contador].Cells[8].Value = conn.leer["ORIGEN"].ToString();
				dataFallasPendientes.Rows[contador].Cells[9].Value = conn.leer["DESFALLA"].ToString();
				dataFallasPendientes.Rows[contador].Cells[10].Value = conn.leer["TIPOTALLER"].ToString();
				dataFallasPendientes.Rows[contador].Cells[11].Value = conn.leer["TALLER"].ToString();
				dataFallasPendientes.Rows[contador].Cells[12].Value = conn.leer["DESREPARACION"].ToString();
				if(conn.leer["ESTADO"].ToString() == "3"){
					dataFallasPendientes.Rows[contador].Cells[13].Value = "Pendiente";	
				}else{
					dataFallasPendientes.Rows[contador].Cells[13].Value = "Reparada";	
				}
				foreach (DataGridViewRow row in dataFallasPendientes.Rows)
				{
					if(Convert.ToString(row.Cells[13].Value) == "Reparada")
						row.DefaultCellStyle.BackColor = Color.LightBlue;
					if(Convert.ToString(row.Cells[13].Value) == "Pendiente")
						row.DefaultCellStyle.BackColor = Color.LightGray;
				}			
				++contador;	
			}
			conn.conexion.Close();
		}						
		#endregion
		
		#region INICIO - TERMINO
		void FormOrdenTrabajoLoad(object sender, EventArgs e)
		{
			LimpriarVariablesyTablasyCampos();
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 
			dataFallas.ClearSelection();
			dataFallasPendientes.ClearSelection();
		
			txtVehiculo.AutoCompleteCustomSource = auto.AutocompleteUnidad();
           	txtVehiculo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtVehiculo.AutoCompleteSource = AutoCompleteSource.CustomSource;	
            
            txtOperadorAgregar.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado like 'OPERADOR%' ", "Alias");
           	txtOperadorAgregar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOperadorAgregar.AutoCompleteSource = AutoCompleteSource.CustomSource;	 

			txtUnidadFiltro.AutoCompleteCustomSource = auto.AutocompleteUnidad();
           	txtUnidadFiltro.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUnidadFiltro.AutoCompleteSource = AutoCompleteSource.CustomSource;	           
          
            fechecarpeta = DateTime.Now.ToString("dd-MM-yyyy");   
            dtpFechaProgramda.Value=DateTime.Now;
            dtpFechaReporte.Value=DateTime.Now;           
            timeHoraProgramada.Value = Convert.ToDateTime("08:00");
		}
		
		void FormOrdenTrabajoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.ordenT = false;
		}
		#endregion		
		
		#region BOTONES	
		void BtnAgregarClick(object sender, EventArgs e)
		{					
			if(txtCodigo.Text.Length < 1){
				txtCodigo.Text = dtpFechaReporte.Value.ToString(".dd.M")+"."+timeHoraReporte.Value.ToString("HH:mm");
			}	
			if(connM.IDVehiculoNumero(txtVehiculo.Text) != ""){
				if(connM.IDMecanicoOperador(txtOperadorAgregar.Text) != ""){
					String IDVehiculo = connM.IDVehiculoNumero(txtVehiculo.Text);
					String IDOperador = connM.IDMecanicoOperador(txtOperadorAgregar.Text);			
					if(IDVehiculo.Length > 0 && IDOperador.Length > 0 && cmbTipoMantenimiento.Text.Length > 0){
						if(Convert.ToDateTime(dtpFechaProgramda.Text) >= DateTime.Now.Date){
							if(cbHoraTirado.Checked){			
								connM.InsertarOrdenT(cmbTipoMantenimiento.Text, IDVehiculo, IDOperador, principal.idUsuario, txtCodigo.Text, txtEstatusReporte.Text, txtArrivo.Text, txtOrigen.Text, dtpFechaReporte.Value.ToString("dd/MM/yyyy"), timeHoraReporte.Value.ToString("HH:mm:ss"), timetHoraTirado.Value.ToString("HH:mm:ss"), dtpFechaProgramda.Value.ToString("dd/MM/yyyy"), timeHoraProgramada.Value.ToString("HH:mm:ss"));
								for(int i = 0; i < dataFallas.RowCount; i++){
									connM.InsertarEntradaFallas(txtOrigen.Text, Convert.ToString(dataFallas.Rows[i].Cells[0].Value), Convert.ToString(dataFallas.Rows[i].Cells[1].Value), Convert.ToString(dataFallas.Rows[i].Cells[2].Value), Convert.ToString(dataFallas.Rows[i].Cells[3].Value), Convert.ToString(dataFallas.Rows[i].Cells[4].Value), 1);
								}
								tabControl1.SelectedTab  = tabPage1;
								LimpriarVariablesyTablasyCampos();
							}else{
								connM.InsertarOrdenT(cmbTipoMantenimiento.Text, IDVehiculo, IDOperador, principal.idUsuario, txtCodigo.Text, txtEstatusReporte.Text, txtArrivo.Text, txtOrigen.Text, dtpFechaReporte.Value.ToString("dd/MM/yyyy"), timeHoraReporte.Value.ToString("HH:mm:ss"), "00:00:00" , dtpFechaProgramda.Value.ToString("dd/MM/yyyy"), timeHoraProgramada.Value.ToString("HH:mm:ss"));
								for(int i = 0; i < dataFallas.RowCount; i++){
									connM.InsertarEntradaFallas(txtOrigen.Text, Convert.ToString(dataFallas.Rows[i].Cells[0].Value), Convert.ToString(dataFallas.Rows[i].Cells[1].Value), Convert.ToString(dataFallas.Rows[i].Cells[2].Value), Convert.ToString(dataFallas.Rows[i].Cells[3].Value), Convert.ToString(dataFallas.Rows[i].Cells[4].Value), 1);
								}
								tabControl1.SelectedTab  = tabPage1;
								LimpriarVariablesyTablasyCampos();
							}
						}else{
							dtpFechaProgramda.Focus();
						}
					}else{
						MessageBox.Show("Tienes que agregar el vehiculo, el operador y tipo de mantenieminto ","Error Orden de Trabajo*",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
					}
				}else{
				MessageBox.Show("El operador no existe","Error Orden de Trabajo*",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
				txtOperadorAgregar.Focus();
				txtOperadorAgregar.Text = "";
			}
			}else{
				MessageBox.Show("El vehiculo no existe","Error Orden de Trabajo*",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
				txtVehiculo.Focus();
				txtVehiculo.Text = "";
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			tabControl1.SelectedTab  = tabPage1;
			LimpriarVariablesyTablasyCampos();
		}
				
		void BtnCambiarSalidaClick(object sender, EventArgs e)
		{
			if(idOrdenTrabajo > 0)
			{
				if(this.cambiarsalida==true)
				{
					if(formcambiarsalida.WindowState==FormWindowState.Minimized)
						formcambiarsalida.WindowState = FormWindowState.Normal;
					else
						formcambiarsalida.BringToFront();
				}
				else
				{
					this.formcambiarsalida = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoCambiarSalida(idOrdenTrabajo, this);
					this.formcambiarsalida.BringToFront();
					this.formcambiarsalida.Show();
					this.cambiarsalida=true;				
				}							
			}
			else{
				MessageBox.Show("Selecciona una Orden de trabajo", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 
		}
				
		void BtnagregarFallaClick(object sender, EventArgs e)
		{
			if(txtTipoFalla.Text.Length > 0 && txtNombreTaller.Text.Length > 0 && cmbTipoTaller.Text.Length > 0)
			{				
				dataFallas.Rows.Add();
				dataFallas.Rows[contadorFalla].Cells[0].Value = txtTipoFalla.Text;
				dataFallas.Rows[contadorFalla].Cells[1].Value = txtDescripcionFalla.Text;
				dataFallas.Rows[contadorFalla].Cells[2].Value = cmbTipoTaller.Text;
				dataFallas.Rows[contadorFalla].Cells[3].Value = txtNombreTaller.Text;
				dataFallas.Rows[contadorFalla].Cells[4].Value = txtDescripcionReparacion.Text;						
				contadorFalla++;
				dataFallas.ClearSelection();
				LimpiarCamposFallas();
			}
		}
		
		#endregion
		
		#region METODOS			
		public void Filtros(){
			if(txtUnidadFiltro.Text.Length > 0)
				if(cbReparadas.Checked==true)
					LlenarFallasPendientes(consultaFiltros + " and OTF.ESTADO = 2 and v.numero = '"+txtUnidadFiltro.Text+"' AND OT.FECHA_SALIDA between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"'");							
				else
					LlenarFallasPendientes(consultaFiltros + " and OTF.ESTADO = 3 and v.numero = '"+txtUnidadFiltro.Text+"' AND OT.FECHA_SALIDA between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"'");	
			else
				if(cbReparadas.Checked==true)
					LlenarFallasPendientes(consultaFiltros + " and OTF.ESTADO = 2" +" AND OT.FECHA_SALIDA between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"'");						
				else
					LlenarFallasPendientes(consultaFiltros + " and OTF.ESTADO = 3" +" AND OT.FECHA_SALIDA between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"'");
			dataFallasPendientes.ClearSelection();
		}
		
		public void LimpriarVariablesyTablasyCampos()
		{
			contadorFalla = 0;
			idOrdenTrabajo = 0;	
			indexFallaEliminar = 0;		
			idOrdenTrabajoCambiaSalida = 0;
			idOrdentrabajoEliminaryEntrada = 0;
			LlenarTabla1();
			LlenarTabla2();
			LlenarTabla3();
			LlenarFallasPendientes(consultaFiltros + "  and OTF.ESTADO = 3");
			cmbTipoMantenimiento.Text = null;
			txtVehiculo.Text = "";
			txtOperadorAgregar.Text = "";			
			txtArrivo.Text = "";
			txtCodigo.Text = "";
			txtEstatusReporte.Text = "";
			txtOrigen.Text = "";
			timetHoraTirado.Text = "00:00:00";
		    dataFallas.Rows.Clear();
			timetHoraTirado.Enabled = false;
			cbHoraTirado.Checked = false;		
		}
		
		public void LimpiarCamposFallas()
		{
			txtTipoFalla.Text = "";
			txtDescripcionFalla.Text = "";
			cmbTipoTaller.Text = null;
		    txtNombreTaller.Text = "";
		    txtDescripcionReparacion.Text = "";						    
		}
		
		public void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}		
		
		#region OBTENER CODIGO DE ORDEN DE TRANAJO		
		void TimeHoraReporteLeave(object sender, EventArgs e)
		{
			txtCodigo.Text = dtpFechaReporte.Value.ToString(".dd.M")+"."+timeHoraReporte.Value.ToString("HH:mm");
		}
		#endregion
			
		#region CREAR PDF
		void PDF()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Orden de Trabajo "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);        
			try
			{		
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Orden de Trabajo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Orden de Trabajo "+idOrdenTrabajo+".pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();								
				PDFs.OrdenTrabajo(doc, writer, idOrdenTrabajo);
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Orden de Trabajo "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Orden de Trabajo "+idOrdenTrabajo+".pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}	
        }
	#endregion		
			
		#endregion	
		
		#region MENUS TOOLSTRIP´s			
			
			#region MENU ENTRADA
			void EliminarToolStripMenuItemClick(object sender, EventArgs e)
			{
				if(idOrdentrabajoEliminaryEntrada > 0)
				{
					if(this.cancelarordentrabajo==true)
					{
						if(formcancelarot.WindowState==FormWindowState.Minimized)
							formcancelarot.WindowState = FormWindowState.Normal;
						else
							formcancelarot.BringToFront();
					}
					else
					{
						this.formcancelarot = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormCancelarOrdenTrabajo(idOrdentrabajoEliminaryEntrada, this);
						this.formcancelarot.BringToFront();
						this.formcancelarot.Show();
						this.cancelarordentrabajo=true;
					}							
				}
				else{
					MessageBox.Show("Seleccione la Orden de trabajo a Cancelar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}	
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 			
			}
			
			void EntradaToolStripMenuItemClick(object sender, EventArgs e)
			{
				if(idOrdentrabajoEliminaryEntrada > 0)
				{
					if(this.entradavehiculo==true)
					{
						if(formentradavehiculo.WindowState==FormWindowState.Minimized)
							formentradavehiculo.WindowState = FormWindowState.Normal;
						else
							formentradavehiculo.BringToFront();
					}
					else
					{
						this.formentradavehiculo = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoEntrada(idOrdentrabajoEliminaryEntrada, this);
						this.formentradavehiculo.BringToFront();
						this.formentradavehiculo.Show();
						this.entradavehiculo=true;
					}							
				}
				else{
					MessageBox.Show("Selecciona una Orden de trabajo para ingresar Entrada", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}	
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 			
			}
			
			void ModificarOTToolStripMenuItemClick(object sender, EventArgs e)
			{
				
				
				dataGenerada.ClearSelection(); 
				dataOrdenTDIA.ClearSelection(); 
				dataOrdenTQuedan.ClearSelection(); 
			}
			
			void FallasReportadasToolStripMenuItemClick(object sender, EventArgs e)
			{
				if(idOrdentrabajoEliminaryEntrada > 0)
					{
						if(this.fallasreportadas==true)
						{
							if(formfallasreportadas.WindowState==FormWindowState.Minimized)
								formfallasreportadas.WindowState = FormWindowState.Normal;
							else
								formfallasreportadas.BringToFront();
						}
						else
						{
							this.formfallasreportadas = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoFallasReportadas(idOrdentrabajoEliminaryEntrada, this);
							this.formfallasreportadas.BringToFront();
							this.formfallasreportadas.Show();
							this.fallasreportadas=true;
						}							
					}
					else{
						MessageBox.Show("Seleccione la Orden de trabajo a Cancelar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}	
				dataGenerada.ClearSelection(); 
				dataOrdenTDIA.ClearSelection(); 
				dataOrdenTQuedan.ClearSelection(); 			
				
			}			
			#endregion
			
			#region MENU SALIDA
			void SalidaVehiculoToolStripMenuItemClick(object sender, EventArgs e)
			{
				if(idOrdenTrabajoCambiaSalida > 0)
				{
					idOrdenTrabajo = idOrdenTrabajoCambiaSalida;
				}
				if(idOrdenTrabajo > 0)
				{
					if(this.salidavehiculo==true)
					{
						if(formsalidavehiculo.WindowState==FormWindowState.Minimized)
							formsalidavehiculo.WindowState = FormWindowState.Normal;
						else
							formsalidavehiculo.BringToFront();
					}
					else
					{
						this.formsalidavehiculo = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoSalida(idOrdenTrabajo, this);
						this.formsalidavehiculo.BringToFront();
						this.formsalidavehiculo.Show();
						this.salidavehiculo=true;
					}							
				}
				else{
					MessageBox.Show("Selecciona una Orden de trabajo", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}	
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 
			}
			
			void MecánicosToolStripMenuItemClick(object sender, EventArgs e)
			{
			if(idOrdenTrabajoCambiaSalida > 0)
				{
					idOrdenTrabajo = idOrdenTrabajoCambiaSalida;
				}			
			if(idOrdenTrabajo > 0)
				{
					if(this.modificarmecanico==true)
					{
						if(formmodificarmecanico.WindowState==FormWindowState.Minimized)
							formmodificarmecanico.WindowState = FormWindowState.Normal;
						else
							formmodificarmecanico.BringToFront();
					}
					else
					{
						this.formmodificarmecanico = new Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo.FormOrdenTrabajoModificaMecanico(idOrdenTrabajo, this);
						this.formmodificarmecanico.BringToFront();
						this.formmodificarmecanico.Show();
						this.modificarmecanico=true;
					}							
				}
				else{
					MessageBox.Show("Selecciona una Orden de trabajo", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 
			}
			
			void ModificarToolStripMenuItemClick(object sender, EventArgs e)
			{
				
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 
			}
			
			void ImprimirOrdenTToolStripMenuItemClick(object sender, EventArgs e)
			{
				if(idOrdenTrabajoCambiaSalida > 0)
				{
					idOrdenTrabajo = idOrdenTrabajoCambiaSalida;
				}			
				if(idOrdenTrabajo > 0)
				{
					PDF();
				}
				else{
					MessageBox.Show("Selecciona una Orden de trabajo", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}	
			dataGenerada.ClearSelection(); 
			dataOrdenTDIA.ClearSelection(); 
			dataOrdenTQuedan.ClearSelection(); 
			}
			#endregion
			
			#region MENU FALLAS
			void ToolStripMenuItem3Click(object sender, EventArgs e)
			{
			if(validarEliminarFalla == true)
				{
					dataFallas.Rows.RemoveAt(indexFallaEliminar);
					contadorFalla--;
					validarEliminarFalla = false;
					dataFallas.ClearSelection(); 
				}					
			}
			#endregion			
		
		#endregion			
				
		#region EVENTOS
		
			#region TAB CONTROL OT
					#region EVENTOS DE TABLAS				
					void DataOrdenTDIACellClick(object sender, DataGridViewCellEventArgs e)
					{
						if(e.RowIndex >=0)
							idOrdenTrabajo = Convert.ToInt32(dataOrdenTDIA.Rows[e.RowIndex].Cells[0].Value);	
					}
					
					void DataOrdenTQuedanCellClick(object sender, DataGridViewCellEventArgs e)
					{
						if(e.RowIndex >=0)
							idOrdenTrabajoCambiaSalida = Convert.ToInt32(dataOrdenTQuedan.Rows[e.RowIndex].Cells[0].Value);		
					}
					
					void DataGeneradaCellClick(object sender, DataGridViewCellEventArgs e)
					{
						if(e.RowIndex >=0)
							idOrdentrabajoEliminaryEntrada = Convert.ToInt32(dataGenerada.Rows[e.RowIndex].Cells[0].Value);	
					}	
					
					#endregion		
			#endregion

			#region TAB AGREGAR OT
				
				#region EVENTOS DE TABLAS
					void DataFallasCellClick(object sender, DataGridViewCellEventArgs e)
					{
						indexFallaEliminar = e.RowIndex;
						validarEliminarFalla = true;		
					}
					#endregion		
					
				#region CHECKLIST
				void CbHoraTiradoCheckedChanged(object sender, EventArgs e)
				{
					if(cbHoraTirado.Checked){
						timetHoraTirado.Enabled = true;
					}else{
						timetHoraTirado.Enabled = false;
					}
				}
				#endregion					
			
			#endregion
			
			#region TAB FALLAS PENDIENTES
			
				#region EVENTOS DATA TIME PICKERS 
				void DtpInicioValueChanged(object sender, EventArgs e){			
					Filtros();				
				}
				
				void DtpFinValueChanged(object sender, EventArgs e){
					Filtros();
				}
				#endregion
				
				#region CHECKBOX
				void CbReparadasCheckedChanged(object sender, EventArgs e){
					Filtros();
				}
				
				void TxtUnidadFiltroTextChanged(object sender, EventArgs e){
					Filtros();
				}	
				#endregion
				
			#endregion
			
		#endregion
	}
}
