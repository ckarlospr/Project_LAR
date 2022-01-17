using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	public partial class FormReporteUT : Form
	{
		#region INSTANCIAS
		private FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		string id_usuario = "0";
		#endregion
		
		#region CONSTRUCTOR
		public FormReporteUT(FormPrincipal principal, int id_u)
		{
			InitializeComponent();
			refPrincipal = principal;
			id_usuario = id_u.ToString();
		}
		#endregion
		
		#region INICIO - FIN		
		void FormReporteUTLoad(object sender, EventArgs e)
		{
			inicio();
		}
		
		void FormReporteUTFormClosing(object sender, FormClosingEventArgs e)
		{			
			refPrincipal.reporteUT = false;
		}
		#endregion
		
		#region METODOS
		private void inicio(){
			dtpIncio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;
			filtros();	
			
			if(refPrincipal.lblDatoNivel.Text == "GERENCIAL" || refPrincipal.lblDatoNivel.Text  == "MASTER"){	
				cbTodos.Enabled = true;
				cmbTurno.Enabled = true;
			}
		}
		#endregion
				
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////// REPORTES /////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
		
		#region METODOS
		public void filtros(){
			string  Consulta = "";
			if(cbTodos.Checked == true){
				Consulta = @"select UT.*, UTP.ID ID_PEDIDO, UTP.ID_USUARIO, UTP.ID_CUENTA, UTP.TIPO_UNIDAD UNIDAD, UTP.USUARIOS, UTP.COSTO, UTP.FECHA_PEDIDO, 
							UTP.HORA_PEDIDO, UTP.FECHA_CIERRE, UTP.HORA_CIERRE, UTP.FOLIO, UTP.ESTADO ESTADOP, UTP. ESTATUS ESTATUSP 
							from UBER_TAXI_PEDIDO UTP JOIN UBER_TAXI UT ON UT.ID = UTP.ID_PEDIDO WHERE UT.FECHA_PLANEACION BETWEEN '"+
							dtpIncio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			}else{
				Consulta = @"select UT.*, UTP.ID ID_PEDIDO, UTP.ID_USUARIO, UTP.ID_CUENTA, UTP.TIPO_UNIDAD UNIDAD, UTP.USUARIOS, UTP.COSTO, UTP.FECHA_PEDIDO, 
							UTP.HORA_PEDIDO, UTP.FECHA_CIERRE, UTP.HORA_CIERRE, UTP.FOLIO, UTP.ESTADO ESTADOP, UTP. ESTATUS ESTATUSP 
							from UBER_TAXI_PEDIDO UTP JOIN UBER_TAXI UT ON UT.ID = UTP.ID_PEDIDO WHERE UT.TIPO = 'EXTRA' AND UT.FECHA_PLANEACION BETWEEN '"+
							dtpIncio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			}
				
	
			if(cmbTurno.SelectedIndex > 0)
				Consulta = Consulta + " and UT.TURNO = '"+cmbTurno.Text+"' ";
			
			adaptador(Consulta);
		}
		
		private void adaptador(string Consulta){				
			int contador = 0;
			try{
				dgReporte.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgReporte.Rows.Add(conn.leer["ID"].ToString(),
			                      		conn.leer["ID_PEDIDO"].ToString(),
			                      		conn.leer["ID_RUTA"].ToString(),
			                      		conn.leer["ID_OPERADOR"].ToString(),
			                      		conn.leer["TIPO"].ToString(),
			                      		conn.leer["MOTIVO"].ToString(),
			                      		conn.leer["FECHA_PLANEACION"].ToString().Substring(0,10),
			                      		conn.leer["TURNO"].ToString(),
			                      		"",//empresa
			                      		"",//ruta
			                      		"",//sentido
			                      		"",//arranque
			                      		conn.leer["TIPO_UNIDAD"].ToString(),
			                      		"",//operador
			                      		conn.leer["ID_CUENTA"].ToString(),
			                      		conn.leer["UNIDAD"].ToString(),
			                      		"",//RESPONBLE
			                      		conn.leer["USUARIOS"].ToString(),
			                      		conn.leer["COSTO"].ToString(),
			                      		conn.leer["FOLIO"].ToString(),
			                      		conn.leer["ESTADO"].ToString(),
			                      		conn.leer["ESTATUS"].ToString(),
			                      		conn.leer["ESTATUSP"].ToString());
					if(conn.leer["ESTATUS"].ToString() == "INACTIVO"){
						for(int y=0; y<dgReporte.Columns.Count; y++)
							dgReporte[y,contador].Style.BackColor = Color.Red;
					}	
					if(conn.leer["ESTATUSP"].ToString() == "INACTIVO"){
						for(int y=15; y<dgReporte.Columns.Count; y++)
							dgReporte[y,contador].Style.BackColor = Color.Red;
					}					                        
					contador++;	
				}
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los datos (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			completaDatos();
			dgReporte.ClearSelection();
		}
		
		private void completaDatos(){
			string consulta = "";
			for(int x=0; x<dgReporte.Rows.Count; x++){
				try{
					if(dgReporte[4,x].Value.ToString() == "RUTA"){
						consulta = @"SELECT C.Empresa, R.Nombre, R.Sentido, R.HoraInicio  FROM RUTA R JOIN Cliente C ON C.ID = R.IdSubEmpresa WHERE r.ID="+dgReporte[2,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							dgReporte[8,x].Value = conn.leer["Empresa"].ToString();
							dgReporte[9,x].Value = conn.leer["Nombre"].ToString();
							dgReporte[10,x].Value = conn.leer["Sentido"].ToString();
							dgReporte[11,x].Value = conn.leer["HoraInicio"].ToString();
						}				
						conn.conexion.Close();
					}
				}catch(Exception){
					
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
					
				try{
					if(dgReporte[3,x].Value.ToString() == "0" || dgReporte[4,x].Value.ToString() == ""){
						dgReporte[13,x].Value = "N/A";
					}else{
						consulta = @"SELECT Alias FROM OPERADOR WHERE ID = "+dgReporte[3,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read())
							dgReporte[13,x].Value = conn.leer["Alias"].ToString();		
						conn.conexion.Close();
					}
				}catch(Exception){
					
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
					
				try{
					consulta = @"SELECT O.Alias FROM CUENTAS_UBER_TAXI CUT JOIN OPERADOR O ON O.ID = CUT.ID_USUARIO WHERE CUT.ID = "+dgReporte[14,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						dgReporte[16,x].Value = conn.leer["Alias"].ToString();
					conn.conexion.Close();
				}catch(Exception){
					
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
				
				if(dgReporte[4,x].Value.ToString() == "EXTRA"){
					dgReporte[7,x].Value = "N/A";
					dgReporte[8,x].Value = "N/A";
					dgReporte[9,x].Value = "N/A";
					dgReporte[10,x].Value = "N/A";
					dgReporte[11,x].Value = "N/A";	
					dgReporte[12,x].Value = "N/A";			
				}
			}
		}
		
		private void ReporteUT(){
			if(dgReporte.Rows.Count>0){
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
				string nombreA = "REPORTE DE UBER-TAXI DEL "+dtpIncio.Value.ToString("dd-MM-yyyy")+" AL "+dtpFin.Value.ToString("dd-MM-yyyy");
					
				ExcelApp.Cells[2,  4] 	= nombreA;
				
				int i = 4;
				ExcelApp.Cells[i,  1] 	= "MOTIVO";
				ExcelApp.Cells[i,  2] 	= "DIA";
				ExcelApp.Cells[i,  3] 	= "TURNO";
				ExcelApp.Cells[i,  4] 	= "EMPRESA";
				ExcelApp.Cells[i,  5] 	= "RUTA";
				ExcelApp.Cells[i,  6] 	= "SENTIDO";
				ExcelApp.Cells[i,  7] 	= "ARRANQUE";
				ExcelApp.Cells[i,  8] 	= "UNIDAD";
				ExcelApp.Cells[i,  9] 	= "OPERADOR";
				ExcelApp.Cells[i,  10] 	= "TIPO";
				ExcelApp.Cells[i,  11] 	= "RESPONSABLE";
				ExcelApp.Cells[i,  12] 	= "USUARIOS";
				ExcelApp.Cells[i,  13] 	= "COSTO";
				ExcelApp.Cells[i,  14] 	= "FOLIO";
				ExcelApp.Cells[i,  15] 	= "ESTADO";
				ExcelApp.Cells[i,  16] 	= "ESTATUS";
							
				int pb = (int) 100 / dgReporte.Rows.Count;
				refPrincipal.progressbarPrin.Value = 0;
				
				for(int y=0; y<dgReporte.Rows.Count; y++){
						++i;	
						if (refPrincipal.progressbarPrin.Value<100)					
	                		refPrincipal.progressbarPrin.Value += pb;
											
						ExcelApp.Cells[i,  1]	= dgReporte[3,y].Value.ToString();
						ExcelApp.Cells[i,  2]	= dgReporte[4,y].Value.ToString();
						ExcelApp.Cells[i,  3]	= dgReporte[5,y].Value.ToString();
						ExcelApp.Cells[i,  4]	= dgReporte[6,y].Value.ToString();
						ExcelApp.Cells[i,  5]	= dgReporte[7,y].Value.ToString();						
						ExcelApp.Cells[i,  6]	= dgReporte[8,y].Value.ToString();	
						ExcelApp.Cells[i,  7]	= dgReporte[9,y].Value.ToString();
						ExcelApp.Cells[i,  8]	= dgReporte[10,y].Value.ToString();
						ExcelApp.Cells[i,  9]	= dgReporte[11,y].Value.ToString();						
						ExcelApp.Cells[i,  10]	= dgReporte[13,y].Value.ToString();
						ExcelApp.Cells[i,  11]	= dgReporte[14,y].Value.ToString();
						ExcelApp.Cells[i,  12]	= dgReporte[15,y].Value.ToString();
						ExcelApp.Cells[i,  13]	= dgReporte[16,y].Value.ToString();
						ExcelApp.Cells[i,  14]	= dgReporte[17,y].Value.ToString();						
						ExcelApp.Cells[i,  15]	= dgReporte[18,y].Value.ToString();						
						ExcelApp.Cells[i,  16]	= ((dgReporte[19,y].Value.ToString()=="INACTIVO" || dgReporte[20,y].Value.ToString()=="INACTIVO")? "El vehículo fue cancelado" : "Activo");
					
				}				
				refPrincipal.progressbarPrin.Value = 100;
				refPrincipal.progressbarPrin.Value = 0;	
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xlsx";
				CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = nombreA;
				if (CuadroDialogo.ShowDialog() == DialogResult.OK){
					ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
					ExcelApp.ActiveWorkbook.Saved = true;
					CuadroDialogo.Dispose();
					CuadroDialogo = null;
					ExcelApp.Quit();
					MessageBox.Show("Se exportaron los datos Correctamente ... ");
				}else{
					MessageBox.Show("No Genero el Reporte ... ");
					refPrincipal.progressbarPrin.Value = 0;
				}
			}
		}
		
		#endregion
		
		#region EVENTOS		
		void DtpIncioValueChanged(object sender, EventArgs e)
		{
			dtpFin.MinDate = dtpIncio.Value;
		}
		
		void CmbTurnoSelectedIndexChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			filtros();
		}
		#endregion
		
		#region BOTONES
		void BtnReporteEClick(object sender, EventArgs e)
		{			
			ReporteUT();
		}
		#endregion		
		
		void DgReporteCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && dgReporte.SelectedRows.Count == 1){
				if(dgReporte[4,e.RowIndex].Value.ToString().Equals("EXTRA")){
					new FormCierreUTextra(this, id_usuario, dgReporte[0,e.RowIndex].Value.ToString(), dgReporte[1,e.RowIndex].Value.ToString(), dgReporte[19,e.RowIndex].Value.ToString()).ShowDialog();
				}
			}
		}
	}
}
