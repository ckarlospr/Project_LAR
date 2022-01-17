using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormViajesOperador : Form
	{
		#region CONSTRUCTOR
		public FormViajesOperador(FormPrincipal principal)
		{
			InitializeComponent();			
			refPrincipal = principal;
		}		
		#endregion
		
		#region INSTANCIAS		
		public Interfaz.FormPrincipal refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private	Interfaz.Nomina.FormNomina refNomina = new Transportes_LAR.Interfaz.Nomina.FormNomina();
		#endregion		
		
		#region VARIABLES
		int dias;
		string consultaG = "";
		#endregion
		
		#region INICIO - FIN
		void FormViajesOperadorLoad(object sender, EventArgs e){
			dtpIncio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;
		}		
		
		void FormViajesOperadorFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.viajesOpe = false;
		}
		#endregion
		
		#region GET OPERADORES
		public void getOperadores(){
			int contador = 0;
			dgOperadores.Rows.Clear();			
			String consulta = "select ID, Alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgOperadores.Rows.Add(conn.leer["ID"].ToString(), 
				                    conn.leer["Alias"].ToString());				
					dgOperadores[1,contador].Style.BackColor = Color.LightGray;
					contador++;
			}
			conn.conexion.Close();
			
			if(cbInactivos.Checked == true){
				consultaG = @"SELECT O.ID, O.Alias, o.foraneo FROM OPERADOR O JOIN OperadorAltaBaja AB ON AB.IdOperador = O.ID 
							WHERE AB.Registro = 'INACTIVO' and ab.Fecha >= '"+dtpInactivos.Value.ToString("yyyy-MM-dd")+"' GROUP BY O.ID, O.Alias, o.foraneo";
				conn.getAbrirConexion(consultaG);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgOperadores.Rows.Add(conn.leer["ID"].ToString(), 
					                    conn.leer["Alias"].ToString());				
					dgOperadores[1,contador].Style.BackColor = Color.Red;
					contador++;
				}
				conn.conexion.Close();
			}
			
			for(int x = 0; x<(dgOperadores.RowCount-1); x++){
				for(int y = x+1; y<dgOperadores.RowCount; y++){
					if(dgOperadores[0,x].Value.ToString() == dgOperadores[0,y].Value.ToString()){
						dgOperadores.Rows.RemoveAt(y);
						if(x>0){
							--x;
							break;
						}
					}
				}
			}
		}
		#endregion
		
		#region GET SUELDOS
		void getSueldos(){
			if(cbInactivos.Checked == true)	
				refNomina.AdaptadorCalculo2(consultaG);
			else			
				refNomina.AdaptadorCalculo();
			for(int y = 2; y<dgOperadores.Columns.Count; y++){
				for(int x=0; x<dgOperadores.Rows.Count; x++){	
					if(dgOperadores.Columns[y].HeaderText == "Sueldo"){
						dgOperadores[y+4,x].Value = refNomina.RetornoSueldoAlias2(dgOperadores[1,x].Value.ToString(), Convert.ToDateTime(dgOperadores.Columns[y-1].HeaderText).ToString("yyyy-MM-dd"), Convert.ToDateTime(dgOperadores.Columns[y - 1].HeaderText).ToString("yyyy-MM-dd"));
						dgOperadores[y+3,x].Value = refNomina.cuenta;
						dgOperadores[y,x].Value = refNomina.SueldoLocal;
						dgOperadores[y-1,x].Value = refNomina.cuentaLocal;
						dgOperadores[y+1,x].Value = refNomina.cuentaForaneo;
						dgOperadores[y+2,x].Value = refNomina.SueldoForaneo;						
					}
					
					/*
					if(dgOperadores.Columns[y].HeaderText != "Sueldo"){
						dgOperadores[y,x].Value = refNomina.RetornoCantViajesOperador(dgOperadores[1,x].Value.ToString(), Convert.ToDateTime(dgOperadores.Columns[y].HeaderText).ToString("yyyy-MM-dd"), 
					                                                             		Convert.ToDateTime(dgOperadores.Columns[y].HeaderText).ToString("yyyy-MM-dd"));
					}else{
						dgOperadores[y,x].Value = refNomina.RetornoSueldoAlias2(dgOperadores[1,x].Value.ToString(), Convert.ToDateTime(dgOperadores.Columns[y-1].HeaderText).ToString("yyyy-MM-dd"), Convert.ToDateTime(dgOperadores.Columns[y - 1].HeaderText).ToString("yyyy-MM-dd"));
					}*/
				}					
			}
			getSueldosTotal();
			getTipo();
		}
		
		void getTipo(){
			string tipo = "";			
			for(int x=0; x<dgOperadores.Rows.Count; x++){				
				try{
					String consulta = @"select vpn.FORANEO from VIAJE_PROSPECTO_NUEVO vpn join RUTA_ESPECIAL re on vpn.ID_RE = re.ID_RE join RUTA r on r.IdSubEmpresa = re.ID_C join OPERACION o 
										on o.id_ruta = r.ID join OPERACION_OPERADOR oo on oo.id_operacion = o.id_operacion join OPERADOR op on op.ID = oo.id_operador where vpn.FORANEO = '1' 
										and TIPO_CLIENTE = '3' and r.Sentido = 'Entrada' and o.estatus != '0' and op.ID = "+dgOperadores[0,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
						tipo = "Foráneo";
					conn.conexion.Close();
	
					if(tipo == ""){
						consulta = @"select v.Tipo_Unidad from HISTORIALOPERADORVEHICULO h join VEHICULO v on v.ID = h.ID_UNIDAD where ID_OPERADOR = "+dgOperadores[0,x].Value.ToString()+"  order by h.FECHA desc";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							if(conn.leer["Tipo_Unidad"].ToString() == "Camión")
								tipo = "Camión";
							else
								tipo = "Camioneta";								
						}
						conn.conexion.Close();
					}	
				}catch(Exception ex){							
					tipo = ex.Message;
					if(conn.conexion != null)
						conn.conexion.Close();
				}									
				dgOperadores[0,x].Value	= ((tipo == "")? "Sin Dato" : tipo);
				tipo = "";
			}			
		}
		
		void getSueldosTotal(){
			DataGridViewTextBoxColumn columnID =  new DataGridViewTextBoxColumn();
			columnID.Name = "VIAJES";
			columnID.HeaderText = "VIAJES";
		 	columnID.ReadOnly = true;
		 	columnID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgOperadores.Columns.Add(columnID);
			DataGridViewTextBoxColumn columnSUALEDO =  new DataGridViewTextBoxColumn();
			columnSUALEDO.Name = "SUELDO";
			columnSUALEDO.HeaderText = "SUELDO";
		 	columnSUALEDO.ReadOnly = true;
		 	columnSUALEDO.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgOperadores.Columns.Add(columnSUALEDO);	
			
			for(int x=0; x<dgOperadores.Rows.Count; x++){				
				Double viajes = 0, sueldo = 0;
				for(int y = 2; y<dgOperadores.Columns.Count-2; y++){
					if(dgOperadores.Columns[y].HeaderText == "Sueldo"){
						sueldo += Convert.ToDouble(dgOperadores[y+4,x].Value);
						viajes += Convert.ToDouble(dgOperadores[y+3,x].Value);
					}
				}
				dgOperadores[dgOperadores.Columns.Count-1, x].Value = sueldo.ToString();
				dgOperadores[dgOperadores.Columns.Count-2, x].Value = viajes.ToString();
				dgOperadores[dgOperadores.Columns.Count-1,x].Style.BackColor = Color.LightGray;
				dgOperadores[dgOperadores.Columns.Count-2,x].Style.BackColor = Color.LightGray;
			}
			/*
			
			if(cbInactivos.Checked == true)	
				refNomina.AdaptadorCalculo2(consultaG);
			else			
				refNomina.AdaptadorCalculo();			
			
			for(int x=0; x<dgOperadores.Rows.Count; x++){
				dgOperadores[dgOperadores.Columns.Count-1,x].Value = refNomina.RetornoSueldoAlias2(dgOperadores[1,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd"));
				dgOperadores[dgOperadores.Columns.Count-2,x].Value = refNomina.cuenta;
				dgOperadores[dgOperadores.Columns.Count-1,x].Style.BackColor = Color.LightGray;
				dgOperadores[dgOperadores.Columns.Count-2,x].Style.BackColor = Color.LightGray;
			}	*/		
			dgOperadores.Sort(dgOperadores.Columns[dgOperadores.Columns.Count-1], ListSortDirection.Ascending);
			dgOperadores.ClearSelection();
		}
		#endregion
		
		#region BOTONES
		void BntBuscarClick(object sender, EventArgs e)
		{
			obtenerDias();
			for(int x = 0; x<=dias; x++){
				DataGridViewTextBoxColumn columnID =  new DataGridViewTextBoxColumn();
			    columnID.Name = "fecha" + x;
			    columnID.HeaderText = dtpIncio.Value.AddDays(x).ToString("dd/MM/yyyy");
		 		columnID.ReadOnly = true;
		 		columnID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgOperadores.Columns.Add(columnID);
				
				DataGridViewTextBoxColumn columnSueldo =  new DataGridViewTextBoxColumn();
			    columnSueldo.Name = "Sueldo " + x;
			    columnSueldo.HeaderText = "Sueldo";
		 		columnSueldo.ReadOnly = true;
		 		columnSueldo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgOperadores.Columns.Add(columnSueldo);
				
				DataGridViewTextBoxColumn columnIDF =  new DataGridViewTextBoxColumn();
			    columnIDF.Name = "# Foraneos";
			    columnIDF.HeaderText = "# Foraneos";
		 		columnIDF.ReadOnly = true;
		 		columnIDF.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgOperadores.Columns.Add(columnIDF);
				
				DataGridViewTextBoxColumn columnSueldoF =  new DataGridViewTextBoxColumn();
			    columnSueldoF.Name = "$ Foraneo" ;
			    columnSueldoF.HeaderText = "$ Foraneo";
		 		columnSueldoF.ReadOnly = true;
		 		columnSueldoF.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgOperadores.Columns.Add(columnSueldoF);
								
				DataGridViewTextBoxColumn columnIDF2 =  new DataGridViewTextBoxColumn();
			    columnIDF2.Name = "#";
			    columnIDF2.HeaderText = "#";
		 		columnIDF2.ReadOnly = true;
		 		columnIDF2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgOperadores.Columns.Add(columnIDF2);
				
				DataGridViewTextBoxColumn columnSueldoF2 =  new DataGridViewTextBoxColumn();
			    columnSueldoF2.Name = "$ " ;
			    columnSueldoF2.HeaderText = "$";
		 		columnSueldoF2.ReadOnly = true;
		 		columnSueldoF2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dgOperadores.Columns.Add(columnSueldoF2);
			}
			getSueldos();
		}	
		
		void CmdImprimirClick(object sender, EventArgs e)
		{
			exportaExcel();
		}	
		
		void Button1Click(object sender, EventArgs e)
		{			
			exportaExcel2();
		}
		#endregion
		
		#region METODOS		
		void obtenerDias(){
			limpiar();			
			TimeSpan ts = Convert.ToDateTime(dtpFin.Value) - Convert.ToDateTime(dtpIncio.Value);
			dias = ts.Days;
			//if(Convert.ToDateTime(dtpIncio.Value) < Convert.ToDateTime(dtpFin.Value))
				//dias++;
		}
		
		void limpiar(){
			dgOperadores.Rows.Clear();
			dgOperadores.Columns.Clear();
			DataGridViewTextBoxColumn columnID =  new DataGridViewTextBoxColumn();
			columnID.Name = "TIPO";
		 	columnID.HeaderText = "TIPO";
		 	//columnID.Visible = false;
		 	columnID.ReadOnly = true;
			dgOperadores.Columns.Add(columnID);
			DataGridViewTextBoxColumn columnOperador =  new DataGridViewTextBoxColumn();
			columnOperador.Name = "OPERADOR";
		 	columnOperador.HeaderText = "OPERADOR";
		 	columnOperador.ReadOnly = true;
			dgOperadores.Columns.Add(columnOperador);			
			getOperadores();
		}		
		
		void exportaExcel(){
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
				CuadroDialogo.DefaultExt = "xlsx";
				CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
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
		
		void exportaExcel2(){
			if(dgOperadores.Rows.Count>0){
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;					
				
				int i = 1;
				ExcelApp.Cells[i, 1] = "Operador";
				ExcelApp.Cells[i, 2] = "Tipo";
				ExcelApp.Cells[i, 3] = "Fecha";
				ExcelApp.Cells[i, 4] = "Viajes Locales";
				ExcelApp.Cells[i, 5] = "Sueldo Locales";
				ExcelApp.Cells[i, 6] = "Viajes Foraneo";
				ExcelApp.Cells[i, 7] = "Sueldo Foraneo";
							
				for(int x = 1; x<dgOperadores.Columns.Count; x++){
					if(dgOperadores.Columns[x].HeaderText == "Sueldo"){
						for(int y = 0; y < dgOperadores.Rows.Count; y++){
							++i;
							ExcelApp.Cells[i,  1]	= dgOperadores[1,y].Value.ToString();
							ExcelApp.Cells[i,  2]	= dgOperadores[0,y].Value.ToString();
							ExcelApp.Cells[i,  3]	= dgOperadores.Columns[x-1].HeaderText.ToString();
							ExcelApp.Cells[i,  4]	= dgOperadores[x-1,y].Value.ToString();
							ExcelApp.Cells[i,  5]	= dgOperadores[x,y].Value.ToString();
							ExcelApp.Cells[i,  6]	= dgOperadores[x+1,y].Value.ToString();
							ExcelApp.Cells[i,  7]	= dgOperadores[x+2,y].Value.ToString();
						}	
					}
				}
					
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xlsx";
				CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "Viajes por Operador Vertical "+dtpIncio.Value.ToString("dd-MM-yyyy") +" A "+dtpFin.Value.ToString("dd-MM-yyyy");
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
		void CbInactivosCheckedChanged(object sender, EventArgs e)
		{
			if(cbInactivos.Checked == true)
				dtpInactivos.Enabled = true;
			else				
				dtpInactivos.Enabled = false;
		}
		
		void DtpIncioValueChanged(object sender, EventArgs e)
		{
			dtpInactivos.Value = dtpIncio.Value;
		}
		#endregion
	}
}
