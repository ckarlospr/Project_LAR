using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormReporteBonos : Form
	{
		#region CONSTRUCTOR
		public FormReporteBonos(formPrincipalComb refc)
		{
			InitializeComponent();
			refCombustible = refc;
		}
		#endregion
		
		#region INSTANCIAS
		private formPrincipalComb refCombustible = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();			
		Conexion_Servidor.Combustible.SQL_Combustible connC = new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion		
		
		#region VARIABLES
		#endregion
		
		#region INICIO - FIN
		void FormReporteBonosLoad(object sender, EventArgs e)
		{	
			cargaInicio();
		}
		#endregion
				
		#region BOTONES
		void BntBuscarClick(object sender, EventArgs e)
		{
			adaptador();
		}	
		
		void CmdImprimirClick(object sender, EventArgs e)
		{
			if(dgOperadores.Rows.Count > 0)
				exportaExcel();
		}
		
		void BtnPerdidaClick(object sender, EventArgs e)
		{
			if(dgOperadores.Rows.Count > 0){
				perdidaBono();
			}		
		}
		
		void PbConfiguracionesClick(object sender, EventArgs e)
		{			
			new FormParametrosCombu(this, refCombustible.refPrincipal.idUsuario).ShowDialog();
		}
		
		#endregion
				
		#region METODOS
		private void cargaInicio(){
			txtOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT alias FROM operador WHERE estatus = 1 and tipo_empleado = 'OPERADOR' AND Alias != 'ADMVO'", "alias");
           	txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			dtpIncio.Value = DateTime.Now.AddDays(-1);
			dtpFin.Value = DateTime.Now.AddDays(-1);
			dtpIncio.MaxDate = DateTime.Now;
			dtpFin.MaxDate = DateTime.Now;
			
			if(refCombustible.refPrincipal.lblDatoNivel.Text == "GERENCIAL" || refCombustible.refPrincipal.lblDatoNivel.Text == "MASTER")
				pbConfiguraciones.Visible = true;
		}
		
		private void perdidaBono(){
			if(this.Width == 785){
					this.MaximumSize = new System.Drawing.Size(1220, 702);
					this.Width = 1220;
					panel1.Enabled = false;
					bntBuscar.Enabled = false;  
					this.CenterToScreen();
					adaptadorOperadorBonos();
				}else{				
					this.MaximumSize = new System.Drawing.Size(1220, 785);
					this.Width = 785;
					panel1.Enabled = true;
					bntBuscar.Enabled = true;
					this.CenterToScreen();
				}
		}
		
		private String getNumeroValidacion(Int64 numero, DateTime fecha){
			String dato = "";			
			String numReg = "";			
			
			if(numero == 0){
				numReg = "01";
			}else if(numero.ToString().Length == 1){
				numReg = "0"+numero;
			}else{
				numReg = numero.ToString();
			}

			if(fecha.ToString("MMM") == "may"){
				dato = fecha.ToString("yyyy").Substring(3,1)+"Y"+fecha.ToString("dd")+numReg;
			}else if(fecha.ToString("MMM") == "jul"){
				dato = fecha.ToString("yyyy").Substring(3,1)+"L"+fecha.ToString("dd")+numReg;
			}else if(fecha.ToString("MMM") == "ago"){
				dato = fecha.ToString("yyyy").Substring(3,1)+"G"+fecha.ToString("dd")+numReg;
			}else{
				dato = fecha.ToString("yyyy").Substring(3,1)+fecha.ToString("MMMMM").Substring(0,1).ToUpper()+fecha.ToString("dd")+numReg;
			}			
			return dato;
		}
			
		private void adaptador(){
			dgOperadores.Rows.Clear();
			string consulta = "";
			
			if(cbAT.Checked == true){
				consulta = @"select a.HR_DATOS, a.Numero, a.FECHA_BASE, a.id as id_a, o.Alias, v.Numero, a.FECHA_REG, a.HORA_AUTORIZACION, a.PERMISO from AUTORIZACION a join OPERADOR o on a.ID_O = o.ID JOIN 
								VEHICULO v on v.ID = a.ID_V where a.FECHA_REG between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")
								+"' and a.TIPO_AUTORIZACION = 'FUERA DE HORARIO' and  a.ESTATUS != '0'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();		
				while(conn.leer.Read()){
					dgOperadores.Rows.Add(conn.leer["id_a"].ToString(),
					                 getNumeroValidacion(Convert.ToInt64(conn.leer["Numero"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), 
						             conn.leer["Alias"].ToString(),
					                 conn.leer["Numero"].ToString(),
					                 "AUTORIZACION TARDE",
					                 conn.leer["FECHA_REG"].ToString().Substring(0,10),
					                 conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,8),
					                 conn.leer["HR_DATOS"].ToString(),
					                 conn.leer["PERMISO"].ToString());
				}
				conn.conexion.Close();
			}
			
			if(cbPDT.Checked == true){
				consulta = @"select a.HR_DATOS, a.Numero, a.FECHA_BASE, a.id as id_a, o.Alias, v.Numero, a.FECHA_REG, a.HORA_AUTORIZACION, a.PERMISO from AUTORIZACION a join OPERADOR o on a.ID_O = o.ID JOIN 
								VEHICULO v on v.ID = a.ID_V where a.FECHA_REG between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")
								+"' and a.TIPO_AUTORIZACION = 'EN HORARIO' and a.HR_DATOS >= '11:00' and a.PERMISO is null and a.ESTATUS != '0'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgOperadores.Rows.Add(conn.leer["id_a"].ToString(),
						                 getNumeroValidacion(Convert.ToInt64(conn.leer["Numero"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), 
							             conn.leer["Alias"].ToString(),
						                 conn.leer["Numero"].ToString(),
						                 "PASO DATOS TARDE",
						                 conn.leer["FECHA_REG"].ToString().Substring(0,10),
						                 conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,8),
						                 conn.leer["HR_DATOS"].ToString(),
						                 conn.leer["PERMISO"].ToString());
				}
				conn.conexion.Close();
			}
			
			if(cbNPD.Checked == true){
				consulta = @"select a.HR_DATOS, a.Numero, a.FECHA_BASE, a.id as id_a, o.Alias, v.Numero, a.FECHA_REG, a.HORA_AUTORIZACION, a.PERMISO from AUTORIZACION a join OPERADOR o on a.ID_O = o.ID JOIN 
								VEHICULO v on v.ID = a.ID_V where a.FECHA_REG between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")
								+"' and a.TIPO_AUTORIZACION != 'EXTERNA' and a.TIPO_AUTORIZACION != 'FUERA DE HORARIO' and a.HR_DATOS is null and a.PERMISO is null and a.ESTATUS != '0'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();		
				while(conn.leer.Read()){
					dgOperadores.Rows.Add(conn.leer["id_a"].ToString(),
						                 getNumeroValidacion(Convert.ToInt64(conn.leer["Numero"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), 
							             conn.leer["Alias"].ToString(),
						                 conn.leer["Numero"].ToString(),
						                 "NO PASO DATOS",
						                 conn.leer["FECHA_REG"].ToString().Substring(0,10),
						                 conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,8),
						                 conn.leer["HR_DATOS"].ToString(),
						                 conn.leer["PERMISO"].ToString());
				}
				conn.conexion.Close();
			}
			completaDatos();
			dgOperadores.Sort(dgOperadores.Columns[2], ListSortDirection.Ascending);
		}
		
		public void adaptadorOperadorBonos(){
			dgPerdidaBono.Rows.Clear();
			string consulta = @"select Alias, id from OPERADOR where tipo_empleado = 'OPERADOR' and Estatus = '1' and id != 167";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgPerdidaBono.Rows.Add(conn.leer["id"].ToString(),
					                       conn.leer["Alias"].ToString(),
					                		"0", "0",  "0",  "0", "0");
				}
				conn.conexion.Close();
				for(int x=0; x<dgPerdidaBono.Rows.Count; x++){
					for(int z=0; z<dgOperadores.Rows.Count; z++){
						if(dgPerdidaBono[1,x].Value.ToString() == dgOperadores[2,z].Value.ToString()){
							if(dgOperadores[4,z].Value.ToString() == "AUTORIZACION TARDE")
								dgPerdidaBono[2,x].Value = (Convert.ToInt32(dgPerdidaBono[2,x].Value) + 1).ToString();
							if(dgOperadores[4,z].Value.ToString() == "PASO DATOS TARDE")
								dgPerdidaBono[3,x].Value = (Convert.ToInt32(dgPerdidaBono[3,x].Value) + 1).ToString();
							if(dgOperadores[4,z].Value.ToString() == "NO PASO DATOS")
								dgPerdidaBono[4,x].Value = (Convert.ToInt32(dgPerdidaBono[4,x].Value) + 1).ToString();
							if(dgOperadores[4,z].Value.ToString() == "SIN REPORTARSE")
								dgPerdidaBono[5,x].Value = (Convert.ToInt32(dgPerdidaBono[5,x].Value) + 1).ToString();
						}
						dgPerdidaBono[6,x].Value = (Convert.ToInt32(dgPerdidaBono[2,x].Value) + Convert.ToInt32(dgPerdidaBono[3,x].Value) +
						                           Convert.ToInt32(dgPerdidaBono[4,x].Value) + Convert.ToInt32(dgPerdidaBono[5,x].Value)).ToString();
					}
					dgPerdidaBono[1,x].Style.BackColor = Color.LightGray;		
		
					string parametroPrueba = connC.obtenerParametroPrueba(2);
					if(Convert.ToInt32(dgPerdidaBono[6,x].Value) >= Convert.ToInt32(parametroPrueba))
							dgPerdidaBono[6,x].Style.BackColor = Color.Red;					
				}				
			dgPerdidaBono.Sort(dgPerdidaBono.Columns[1], ListSortDirection.Ascending);
		}
		
		private void completaDatos(){	
			string consul;		
			if(cbSR.Checked == true){
				int dias;
				TimeSpan ts = Convert.ToDateTime(dtpFin.Value) - Convert.ToDateTime(dtpIncio.Value);
				dias = ts.Days;
				
				for(int x=0; x<dias+1; x++){
					if(dtpIncio.Value.AddDays(x).DayOfWeek.ToString() != "Sunday"){
						consul = @"select * from OPERADOR where estatus = '1' and Alias!='ADMVO' and tipo_empleado='OPERADOR' and ID not in (select ID_O from 
										AUTORIZACION where FECHA_REG = '"+dtpIncio.Value.AddDays(x).ToString("yyyy-MM-dd")+"')";
						conn.getAbrirConexion(consul);
						conn.leer = conn.comando.ExecuteReader();		
						while(conn.leer.Read()){
							dgOperadores.Rows.Add("SIN REPORTARSE",
							                    "N/A",
												conn.leer["Alias"].ToString(),
							                 	"N/A",
							                 	"SIN REPORTARSE",
							                 	dtpIncio.Value.AddDays(x).ToString("dd/MM/yyyy"),
							                 	"N/A",
							                 	"N/A",
							                 	"N/A");
						}
						conn.conexion.Close();
					}
				}
			}
			
			for(int x = 0; x<dgOperadores.Rows.Count; x++){
				consul = @"select TOP(1) o.Alias, FechaInicioContrato from OperadorContrato oc join OPERADOR o on o.ID = oc.IdOperador where o.Alias = '"+dgOperadores[2,x].Value.ToString()+"' ORDER BY FechaInicioContrato DESC";
				conn.getAbrirConexion(consul);
				conn.leer = conn.comando.ExecuteReader();		
				if(conn.leer.Read()){
					if(Convert.ToDateTime(dgOperadores[5,x].Value) < Convert.ToDateTime(conn.leer["FechaInicioContrato"])){
						dgOperadores.Rows.RemoveAt(x);
						if(x > 0)
							x--;
					}						
				}
				conn.conexion.Close();
				
				consul = @"select * from AUTORIZACION a join OPERADOR o on a.ID_O = o.ID where (a.PERMISO = 'CARGA MAS TARDE') and a.HORA_AUTORIZACION  <= '11:00' and a.TIPO_AUTORIZACION != 'EXTERNA' and 
							a.TIPO_AUTORIZACION = 'EN HORARIO' and a.HORA_CARGA is null	and FECHA_REG = '"+Convert.ToDateTime(dgOperadores[5,x].Value).ToString("yyyy-MM-dd")+"' and o.Alias like '%"+dgOperadores[2,x].Value.ToString()+"%'";
				conn.getAbrirConexion(consul);
				conn.leer = conn.comando.ExecuteReader();		
				if(conn.leer.Read()){
					dgOperadores.Rows.RemoveAt(x);
					x--;
				}
				conn.conexion.Close();			
					
				if(x > -1){					
					dgOperadores[2,x].Style.BackColor = Color.LightGray;
					dgOperadores[4,x].Style.BackColor = Color.LightGray;
					if(dgOperadores[8,x].Value.ToString() == "ESPECIAL" || dgOperadores[8,x].Value.ToString() == "LLAMADA"){
						dgOperadores.Rows.RemoveAt(x);						
						x--;
					}
				}
			}			
			dgOperadores.ClearSelection();
		}
		
		private void exportaExcel(){
			if(dgOperadores.Rows.Count>0){					
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;	
				
				int i = 1;
				ExcelApp.Cells[i,  1] = "FOLIO";
				ExcelApp.Cells[i,  2] = "OPERADOR";
				ExcelApp.Cells[i,  3] = "UNIDAD";
				ExcelApp.Cells[i,  4] = "CONCEPTO";
				ExcelApp.Cells[i,  5] = "FECHA AUTORIZACION";
				ExcelApp.Cells[i,  6] = "HORA AUTORIZACION";
				ExcelApp.Cells[i,  7] = "HORA DATOS";
				ExcelApp.Cells[i,  8] = "PERMISO";
				
				for(int x=0; x<dgOperadores.Rows.Count; x++){
					++i;				
					try{ExcelApp.Cells[i,  1] = dgOperadores[1,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  1] = "";}
					try{ExcelApp.Cells[i,  2] = dgOperadores[2,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
					try{ExcelApp.Cells[i,  3] = dgOperadores[3,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  3] = "";}
					try{ExcelApp.Cells[i,  4] = dgOperadores[4,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  4] = "";}
					try{ExcelApp.Cells[i,  5] = dgOperadores[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  5] = "";}
					try{ExcelApp.Cells[i,  6] = dgOperadores[6,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
					try{ExcelApp.Cells[i,  7] = dgOperadores[7,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
					try{ExcelApp.Cells[i,  8] = dgOperadores[8,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
				}
				
				i = 1;
				ExcelApp.Cells[i,  10] = "OPERADOR";
				ExcelApp.Cells[i,  11] = "AUTORIZACION TARDE";
				ExcelApp.Cells[i,  12] = "PASO DATOS TARDE";
				ExcelApp.Cells[i,  13] = "NO PASO DATOS";
				ExcelApp.Cells[i,  14] = "SIN REPORTARSE";
				ExcelApp.Cells[i,  15] = "TOTAL";
				
				for(int x=0; x<dgPerdidaBono.Rows.Count; x++){
					++i;				
					try{ExcelApp.Cells[i,  10] = dgPerdidaBono[1,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  10] = "";}
					try{ExcelApp.Cells[i,  11] = dgPerdidaBono[2,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}
					try{ExcelApp.Cells[i,  12] = dgPerdidaBono[3,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  12] = "";}
					try{ExcelApp.Cells[i,  13] = dgPerdidaBono[4,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  13] = "";}
					try{ExcelApp.Cells[i,  14] = dgPerdidaBono[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  14] = "";}
					try{ExcelApp.Cells[i,  15] = dgPerdidaBono[6,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  15] = "";}
				}				
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "Viajes por Operador "+dtpIncio.Value.ToString("dd-MM-yyyy") +" A "+dtpFin.Value.ToString("dd-MM-yyyy");
				if (CuadroDialogo.ShowDialog() == DialogResult.OK){
					ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
					ExcelApp.ActiveWorkbook.Saved = true;
					CuadroDialogo.Dispose();
					CuadroDialogo = null;
					ExcelApp.Workbooks.Close();
					ExcelApp.Quit();
					MessageBox.Show("Se exportaron los datos Correctamente ... ");
				}else{
					MessageBox.Show("No Genero el Reporte ... ");
					ExcelApp.Application.Workbooks.Close();
					ExcelApp.Quit();
				}
			}
		}
		#endregion		
		
		#region EVENTOS
		void CbPeriodoCheckedChanged(object sender, EventArgs e)
		{
			if(cbPeriodo.Checked == true){
				dtpIncio.MaxDate = Convert.ToDateTime("01/01/2090");
				dtpFin.MaxDate =  Convert.ToDateTime("01/01/2090");				
				dtpIncio.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO()));
				//dtpFin.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN()));
				dtpFin.Value = DateTime.Now;
			}else{				
				dtpIncio.MaxDate = DateTime.Now;
				dtpFin.MaxDate = DateTime.Now;
				dtpIncio.Value = DateTime.Now.AddDays(-1);
				dtpFin.Value = DateTime.Now.AddDays(-1);
			}
		}
		
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Return"){
				dgPerdidaBono.ClearSelection();
				for(int x=0; x<dgPerdidaBono.Rows.Count; x++){
					if(txtOperador.Text == dgPerdidaBono[0,x].Value.ToString()){
						dgPerdidaBono.Rows[x].Selected = true;
						dgPerdidaBono.FirstDisplayedCell = dgPerdidaBono.Rows[x].Cells[1];
					}
				}
			}
			else if(txtOperador.Text.Length == 3){
				dgPerdidaBono.ClearSelection();
				for(int x=0; x<dgPerdidaBono.Rows.Count; x++){
					if(txtOperador.Text==dgPerdidaBono[0,x].Value.ToString()){
						dgPerdidaBono.Rows[x].Selected = true;
						dgPerdidaBono.FirstDisplayedCell = dgPerdidaBono.Rows[x].Cells[1];
					}
				}
			}
		}
		#endregion
		
		
		
		#region otro Metodo
		/*
		 * 
		 * void exportaExcel(){
			if(dgOperadores.Rows.Count>0){
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;					
				
				int i = 1;
				for(int x = 1; x<dgOperadores.Columns.Count; x++){	
					ExcelApp.Cells[i, x] = dgOperadores.Columns[x].HeaderText.ToString();
				}
				
				for(int y = 0; y < dgOperadores.Rows.Count; y++){
					++i;
					for(int z = 1; z<dgOperadores.Columns.Count; z++)
						ExcelApp.Cells[i,  z]	= dgOperadores[z,y].Value.ToString();
				}			
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "Viajes por Operador "+dtpIncio.Value.ToString("dd-MM-yyyy") +" A "+dtpFin.Value.ToString("dd-MM-yyyy");
				if (CuadroDialogo.ShowDialog() == DialogResult.OK){
					ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
					ExcelApp.ActiveWorkbook.Saved = true;
					CuadroDialogo.Dispose();
					CuadroDialogo = null;
					ExcelApp.Workbooks.Close();
					ExcelApp.Quit();
					MessageBox.Show("Se exportaron los datos Correctamente ... ");
				}else{
					MessageBox.Show("No Genero el Reporte ... ");
					ExcelApp.Application.Workbooks.Close();
					ExcelApp.Quit();
				}
			}
		}
		
		void limpiar(){
			dgOperadores.Rows.Clear();
			dgOperadores.Columns.Clear();
			DataGridViewTextBoxColumn columnID =  new DataGridViewTextBoxColumn();
			columnID.Name = "ID";
		 	columnID.HeaderText = "ID";
		 	columnID.Visible = false;
		 	columnID.ReadOnly = true;
			dgOperadores.Columns.Add(columnID);
			DataGridViewTextBoxColumn columnOperador =  new DataGridViewTextBoxColumn();
			columnOperador.Name = "OPERADOR";
		 	columnOperador.HeaderText = "OPERADOR";
		 	columnOperador.ReadOnly = true;
			dgOperadores.Columns.Add(columnOperador);			
			obtenerOperador();
		}		
		
		#region GET OPERADORES
		public void obtenerOperador(){
			int contador = 0;
			dgOperadores.Rows.Clear();			
			String consulta = "select ID, Alias from OPERADOR where Estatus = '1' and tipo_empleado = 'OPERADOR'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgOperadores.Rows.Add(conn.leer["ID"].ToString(), 
				                    conn.leer["Alias"].ToString());				
					dgOperadores[1,contador].Style.BackColor = Color.LightGray;
					contador++;
			}
			conn.conexion.Close();	
		}
		#endregion
		
		void obtenerDias(){
			limpiar();			
			TimeSpan ts = Convert.ToDateTime(dtpFin.Value) - Convert.ToDateTime(dtpIncio.Value);
			dias = ts.Days;
			if(Convert.ToDateTime(dtpIncio.Value) < Convert.ToDateTime(dtpFin.Value))
				dias++;
		}
		
		private void sinreportarse(){
			string consulta = "";
			for(int y = 2; y<dgOperadores.Columns.Count; y++){
				for(int x=0; x<dgOperadores.Rows.Count; x++){
					consulta = 	@"select * from AUTORIZACION where ESTATUS = '2' and TIPO_AUTORIZACION in ('DEFASADA','EN HORARIO','EXTERNA') 
								and FECHA_REG = '"+Convert.ToDateTime(dgOperadores.Columns[y].HeaderText).ToString("yyyy-MM-dd")
								+"' and ID_O = "+dgOperadores[0,x].Value.ToString();			
					
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgOperadores[y,x].Value = "EN HORARIO";				
					}
					conn.conexion.Close();
					
					if(dgOperadores[y,x].Value.ToString() != "EN HORARIO"){
						consulta = 	@"select * from AUTORIZACION where ESTATUS = '2' and TIPO_AUTORIZACION in ('DEFASADA','EN HORARIO','EXTERNA') 
								and FECHA_REG = '"+Convert.ToDateTime(dgOperadores.Columns[y].HeaderText).ToString("yyyy-MM-dd")
								+"' and ID_O = "+dgOperadores[0,x].Value.ToString();			
					
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							dgOperadores[y,x].Value = "EN HORARIO";				
						}
						conn.conexion.Close();
					}
				}					
			}
		
			
		}
		*/
		#endregion				
	}
}
