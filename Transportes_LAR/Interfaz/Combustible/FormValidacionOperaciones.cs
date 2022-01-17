using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Combustible
{	
	public partial class FormValidacionOperaciones : Form
	{
		#region CONSTRUCTOR		
		public FormValidacionOperaciones(FormPrincipal formPrinc)
		{
			InitializeComponent();
			refPrincipal=formPrinc;
		}		
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Interfaz.Combustible.FormNoRealizoRevizado formmNoRealizo = null;		
		private Conexion_Servidor.Combustible.SQL_Combustible conn1= new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion	
				
		#region	CONTROL_DE_VENTANAS_ABIERTAS		
		public bool noRealizoRevizado = false;	
		#endregion				

		#region VARIABLES
		
		#endregion						
		
		#region INICIO - FIN
		void FormValidacionOperacionesFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.validacionOpeCombustible=false;
		}		
		
		void FormValidacionOperacionesLoad(object sender, EventArgs e)
		{		
			//				Pestaña Rutas
			txtOperadorFyN.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT OPERADOR FROM VIAJES_FALTANTES", "OPERADOR");
			txtOperadorFyN.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperadorFyN.AutoCompleteSource = AutoCompleteSource.CustomSource;			
			txtUnidadFyN.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT UNIDAD FROM VIAJES_FALTANTES", "UNIDAD");
			txtUnidadFyN.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidadFyN.AutoCompleteSource = AutoCompleteSource.CustomSource;
			dtpFechaInicioV.Value=DateTime.Now;
            dtpFechaTerminoV.MinDate = dtpFechaInicioV.Value;	
			filtros1();
			
			
			//				Pestaña Otros
			txtOperadorOtros.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT ALIAS FROM OPERADOR", "ALIAS");
			txtOperadorOtros.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperadorOtros.AutoCompleteSource = AutoCompleteSource.CustomSource;	
		}
		#endregion		
			
		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////   Rutas  //////////////////////////////////////////////////////////////// 
		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
		
		#region ADAPTADOR	
		public void viajesValidados(String consulta){
			dgViajesValidados.Rows.Clear();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
						dgViajesValidados.Rows.Add(conn.leer["id_operacion"].ToString(),
					                         conn.leer["Alias"].ToString(),
					                         conn.leer["numero"].ToString(),
					                         Convert.ToDateTime(conn.leer["fecha"].ToString().Substring(0,10)).ToShortDateString(),
					                         conn.leer["HoraInicio"].ToString(),
					                         conn.leer["HORA_LLEGADA"].ToString(),
					                         conn.leer["Kilometros"].ToString(),
											 conn.leer["SubNombre"].ToString(),
											 conn.leer["Nombre"].ToString(),
											 conn.leer["turno"].ToString(),
											 conn.leer["Sentido"].ToString());
				
			}
			conn.conexion.Close();			
			dgViajesValidados.ClearSelection();
			estatusViajes();			
		}
		
		public void viajesFaltantes(String Cons){
			dgFaltantesV.Rows.Clear();	
			conn.getAbrirConexion(Cons);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{				
						dgFaltantesV.Rows.Add(conn.leer["ID"].ToString(),
				                      		conn.leer["ID_A"].ToString(),
					                         conn.leer["OPERADOR"].ToString(),
					                         conn.leer["UNIDAD"].ToString(),
					                         conn.leer["EMPRESA"].ToString(),
					                         conn.leer["RUTA"].ToString(),
					                         Convert.ToDateTime(conn.leer["FECHA"].ToString().Substring(0,10)).ToShortDateString(),
					                         conn.leer["HORA"].ToString(),		
											 conn.leer["TURNO"].ToString(),
											 conn.leer["TIPO"].ToString());
				
			}
			conn.conexion.Close();			
			dgFaltantesV.ClearSelection();
		}
		#endregion
		
		#region FILTROS
		public void filtros1(){		
			if(txtOperadorFyN.Text.Length > 0 ){
				viajesFaltantes("SELECT * FROM VIAJES_FALTANTES where ESTATUS = 1 AND FECHA between '"+dtpFechaInicioV.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFechaTerminoV.Value.ToString("yyyy-MM-dd")+"' and OPERADOR like '%"+txtOperadorFyN.Text+"%'");
			}
			if(txtUnidadFyN.Text.Length > 0){
				viajesFaltantes("SELECT * FROM VIAJES_FALTANTES where ESTATUS = 1 AND FECHA between '"+dtpFechaInicioV.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFechaTerminoV.Value.ToString("yyyy-MM-dd")+"' and UNIDAD like '%"+txtUnidadFyN.Text+"%'");
			}
			if(txtUnidadFyN.Text == "" && txtOperadorFyN.Text == ""){
				viajesFaltantes("SELECT * FROM VIAJES_FALTANTES where ESTATUS = 1 AND FECHA between '"+dtpFechaInicioV.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFechaTerminoV.Value.ToString("yyyy-MM-dd")+"'");
			}
			
			if(txtUnidadFyN.Text != "" && txtOperadorFyN.Text != ""){
				MessageBox.Show("No puedes buscar por operador y unidad", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);			
			}				
		}
		
		public void filtros2(){						
			String consulta = @"select R.VELADA, OP.id_operacion, O.Alias, V.numero,  OP.fecha, R.HoraInicio, c.SubNombre, R.Nombre, OP.turno, R.Sentido, R.HoraInicio, R.HORA_LLEGADA, R.Kilometros
							from vehiculo V,  OPERADOR O, OPERACION_OPERADOR OO, OPERACION OP, RUTA R, Cliente C
							where OO.id_vehiculo=V.id and O.ID = OO.id_operador and OO.id_operacion = OP.id_operacion AND R.ID = OP.id_ruta and C.ID= R.IdSubEmpresa and OP.estatus='1' 
							and OP.fecha between '"+dtpFechaInicioV.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFechaTerminoV.Value.ToString("yyyy-MM-dd")+"'";
			
			if(txtOperadorFyN.Text.Length >= 0)
				consulta = consulta + " and O.Alias like '"+txtOperadorFyN.Text+"%'";				
			
			if (txtUnidadFyN.Text.Length >= 0)
				consulta = consulta + " and V.Numero like '%"+txtUnidadFyN.Text+"%'";
						
			consulta = consulta + " ORDER BY OP.fecha";			
			viajesValidados(consulta);			
		}
		#endregion
		
		#region BOTONES		
		void CbSinValidarCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnImprimirVClick(object sender, EventArgs e)
		{
			generarReporteRevizar();
		}
		
		void BtnValidaRutaClick(object sender, EventArgs e)
		{
			for(int x=0; x<dgViajesValidados.Rows.Count; x++)
			{
				if(dgViajesValidados.Rows[x].Selected==true && dgViajesValidados[11,x].Value.ToString()=="0")
				{
					String consul = "INSERT INTO CIERRE_VIAJES VALUES ('"+dgViajesValidados[0,x].Value.ToString()+"', '1', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
					conn.getAbrirConexion(consul);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
			}					
			filtros2();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			filtros1();
			filtros2();
		}
		#endregion
		
		#region EVENTOS
		void DtpFechaInicioVValueChanged(object sender, EventArgs e)
		{
			dtpFechaTerminoV.MinDate = dtpFechaInicioV.Value;				
		}		
		#endregion
		
		#region METODOS			
			#region REPORTE
			public void generarReporteRevizar()
			{
				int i = 0;				
				if(dgViajesValidados.Rows.Count>0)
				{
					nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
						        
					ExcelApp.Application.Workbooks.Add(Type.Missing);
					ExcelApp.Columns.ColumnWidth = 20;
					try{
						++i;
						ExcelApp.Cells[i,  1] = "ID";
						ExcelApp.Cells[i,  2] = "OPERADOR";
						ExcelApp.Cells[i,  3] = "UNIDAD";
						ExcelApp.Cells[i,  4] = "FECHA";
						ExcelApp.Cells[i,  5] = "HORA INICIO";
						ExcelApp.Cells[i,  6] = "HORA FIN";
						ExcelApp.Cells[i,  7] = "KM";
						ExcelApp.Cells[i,  8] = "EMPRESA";
						ExcelApp.Cells[i,  9] = "RUTA";
						ExcelApp.Cells[i,  10] = "TURNO";
						ExcelApp.Cells[i,  11] = "SENTIDO";
						ExcelApp.Cells[i,  12] = "ESTATUS";
						
						for(int y=0; y<dgViajesValidados.Rows.Count; y++)
						{
							++i;
							
							ExcelApp.Cells[i,  1]	= dgViajesValidados[0,y].Value.ToString();
							ExcelApp.Cells[i,  2]	= dgViajesValidados[1,y].Value.ToString();
							ExcelApp.Cells[i,  3]	= dgViajesValidados[2,y].Value.ToString();
							ExcelApp.Cells[i,  4]	= dgViajesValidados[3,y].Value.ToString();
							ExcelApp.Cells[i,  5]	= dgViajesValidados[4,y].Value.ToString();
							ExcelApp.Cells[i,  6]	= dgViajesValidados[5,y].Value.ToString();
							ExcelApp.Cells[i,  7]	= dgViajesValidados[6,y].Value.ToString();
							ExcelApp.Cells[i,  8]	= dgViajesValidados[7,y].Value.ToString();
							ExcelApp.Cells[i,  9]	= dgViajesValidados[8,y].Value.ToString();
							ExcelApp.Cells[i,  10]	= dgViajesValidados[9,y].Value.ToString();
							ExcelApp.Cells[i,  11]	= dgViajesValidados[10,y].Value.ToString();
							ExcelApp.Cells[i,  12]	= ((dgViajesValidados[11,y].Value.ToString()=="0")?"FALTANTE":"VALIDADO");
						}	
						
						if(dgFaltantesV.Rows.Count > 0)
						{	
							i = i+2;
							ExcelApp.Cells[i,  5] = "RUTAS FALTANTES";
							i++;
							ExcelApp.Cells[i,  1] = "OPERADOR";
							ExcelApp.Cells[i,  2] = "UNIDAD";
							ExcelApp.Cells[i,  3] = "EMPRESA";
							ExcelApp.Cells[i,  4] = "RUTA";
							ExcelApp.Cells[i,  5] = "FECHA";
							ExcelApp.Cells[i,  6] = "HORA";
							ExcelApp.Cells[i,  7] = "TURNO";
							ExcelApp.Cells[i,  8] = "SENTIDO";						
							for(int y=0; y<dgFaltantesV.Rows.Count; y++)
							{
								++i;
								
								ExcelApp.Cells[i,  1]	= dgFaltantesV[2,y].Value.ToString();
								ExcelApp.Cells[i,  2]	= dgFaltantesV[3,y].Value.ToString();
								ExcelApp.Cells[i,  3]	= dgFaltantesV[4,y].Value.ToString();
								ExcelApp.Cells[i,  4]	= dgFaltantesV[5,y].Value.ToString();
								ExcelApp.Cells[i,  5]	= dgFaltantesV[6,y].Value.ToString();
								ExcelApp.Cells[i,  6]	= dgFaltantesV[7,y].Value.ToString();
								ExcelApp.Cells[i,  7]	= dgFaltantesV[8,y].Value.ToString();
								ExcelApp.Cells[i,  8]	= dgFaltantesV[9,y].Value.ToString();								
							}	
						}
						
						SaveFileDialog CuadroDialogo = new SaveFileDialog();
						CuadroDialogo.DefaultExt = "xls";
						CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
						CuadroDialogo.AddExtension = true;
						CuadroDialogo.RestoreDirectory = true;
						CuadroDialogo.Title = "Guardar";
						CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
						CuadroDialogo.FileName = "RESUMEN_VIAJES_"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
						if (CuadroDialogo.ShowDialog() == DialogResult.OK)
						{
							ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
							ExcelApp.ActiveWorkbook.Saved = true;
							CuadroDialogo.Dispose();
							CuadroDialogo = null;
							ExcelApp.Quit();
							MessageBox.Show("Se exportaron los datos Correctamente ... ");
						}
						else
						{
							MessageBox.Show("No Genero el Reporte ... ");
						}
					
				}catch(Exception e){
					MessageBox.Show(e.Message);
					ExcelApp.Quit();
				}
			}
				
			
			}
			#endregion
			
			#region ESTATUS			
			void estatusViajes()
			{
				int vSinA = 0;
				for(int x=0; x<dgViajesValidados.Rows.Count; x++)
				{
					String conss = "select * from CIERRE_VIAJES where ESTATUS!='0' and ID_OP="+dgViajesValidados[0,x].Value.ToString();
					conn.getAbrirConexion(conss);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgViajesValidados[11,x].Value = conn.leer["ESTATUS"].ToString();
						dgViajesValidados[13,x].Value = "SI";
						for(int y=0; y<dgViajesValidados.Columns.Count; y++)
						{
							dgViajesValidados[y,x].Style.BackColor=Color.MediumSpringGreen;
						}
						++vSinA;
					}
					else
					{
						dgViajesValidados[11,x].Value = "0";
					}
					conn.conexion.Close();	
					
					conss = "SELECT * FROM RELACION_MOVIMIENTO where TIPO='VIAJE' and ESTATUS!='0' and ID_R="+dgViajesValidados[0,x].Value.ToString();
					conn.getAbrirConexion(conss);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgViajesValidados[2,x].Style.BackColor = Color.MediumSpringGreen;						
						dgViajesValidados[13,x].Value = "SI";
						if(dgViajesValidados[1,x].Style.BackColor != Color.MediumSpringGreen){
							++vSinA;
						}
					}
					conn.conexion.Close();
					txtSinValidar.Text = Convert.ToString(x - vSinA  + 1);
					
					conss = "select * from REVISION_VIAJES where ID_O="+dgViajesValidados[0,x].Value.ToString();
					conn.getAbrirConexion(conss);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgViajesValidados[1,x].Style.BackColor=Color.Red;
						dgViajesValidados[13,x].Value = "VIAJE NO REALIZADO";
						dgViajesValidados[12,x].Value =  conn.leer["ID"].ToString();					
					}
					conn.conexion.Close();
					
					if(dgViajesValidados[2,x].Style.BackColor.Name != "MediumSpringGreen" && dgViajesValidados[1,x].Style.BackColor.Name != "Red")
						dgViajesValidados[13,x].Value = "NO";						
				}
				txtValidadosAutorizacion.Text = Convert.ToString(vSinA);
			}
		
			#endregion
			
		#endregion
		
		#region MENU´S		
		void RevizadoToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(tabFaltantes.SelectedTab == tabPage1){					
				if(dgViajesValidados.SelectedRows.Count==1)	{
					if(dgViajesValidados.CurrentRow.Index!=-1){
						if(dgViajesValidados[1,dgViajesValidados.CurrentRow.Index].Style.BackColor == Color.Red)
						{
							if(this.noRealizoRevizado==true)
							{
								if(formmNoRealizo.WindowState==FormWindowState.Minimized)
									formmNoRealizo.WindowState = FormWindowState.Normal;
								else
									formmNoRealizo.BringToFront();
							}
							else
							{
								this.formmNoRealizo = new Transportes_LAR.Interfaz.Combustible.FormNoRealizoRevizado(this, dgViajesValidados[12,dgViajesValidados.CurrentRow.Index].Value.ToString());
								this.formmNoRealizo.BringToFront();
								this.formmNoRealizo.Show();
								this.noRealizoRevizado=true;				
							}	
						}
					}
				}
				else
				{
					MessageBox.Show("Seleccione un solo registro.");
				}
			}
			else
			{
				if(dgMovimientosOtros.SelectedRows.Count == 1){
					if(dgMovimientosOtros.SelectedRows.Count==1){
						if(dgMovimientosOtros.CurrentRow.Index!=-1){
							if(dgMovimientosOtros[1,dgMovimientosOtros.CurrentRow.Index].Style.BackColor == Color.Red)
							{
								if(this.noRealizoRevizado==true)
								{
									if(formmNoRealizo.WindowState==FormWindowState.Minimized)
										formmNoRealizo.WindowState = FormWindowState.Normal;
									else
										formmNoRealizo.BringToFront();
								}
								else
								{
									this.formmNoRealizo = new Transportes_LAR.Interfaz.Combustible.FormNoRealizoRevizado(this, dgMovimientosOtros[0,dgMovimientosOtros.CurrentRow.Index].Value.ToString());
									this.formmNoRealizo.BringToFront();
									this.formmNoRealizo.Show();
									this.noRealizoRevizado=true;				
								}	
							}
					}
				}
			}
			}
		}
		
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{	
			if(tabFaltantes.SelectedTab == tabPage1){
				if(dgFaltantesV.SelectedRows.Count==1)
				{
					DialogResult rs2 = MessageBox.Show("Revisión Completa de ruta", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		            if (DialogResult.Yes == rs2)
		            {
		                if(dgFaltantesV.CurrentRow.Index!=-1){				
							conn1.revizaFaltantes(dgFaltantesV[0,dgFaltantesV.CurrentRow.Index].Value.ToString(), refPrincipal.idUsuario);	
							filtros1();						
		            	}
		            }
		            dgFaltantesV.ClearSelection();
				}
				else
				{
					MessageBox.Show("Seleccione un solo registro");
				}	
			}
			else{
				if(dgFaltantesO.SelectedRows.Count==1)
				{
					DialogResult rs2 = MessageBox.Show("Revisión Completa de Otros", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		            if (DialogResult.Yes == rs2)
		            {
		                if(dgFaltantesO.CurrentRow.Index!=-1){				
							conn1.revizaOtrosFaltantes(dgFaltantesO[0,dgFaltantesO.CurrentRow.Index].Value.ToString(), refPrincipal.idUsuario, dgFaltantesO[9,dgFaltantesO.CurrentRow.Index].Value.ToString());	
							OtrosFaltantes();						
		            	}
		            }
		            dgFaltantesO.ClearSelection();
				}
				else
				{
					MessageBox.Show("Seleccione un solo registro.");
				}	
			}
		}
		#endregion
				
		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////////////// Otros  ///////////////////////////////////////////////////////////////// 
		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		#region ADAPTADOR
		public void otros(){
		dgMovimientosOtros.Rows.Clear();
			String consulta = "";		
			// GUARDIAS  
			if(txtOperadorOtros.Text.Length > 0){
				 consulta = @"select G.ID D1, O.Alias D2, C.Empresa D3, G.TURNO D4, CONVERT(CHAR(10),G.DIA, 103) D5 from GUARDIA G, Cliente C, OPERADOR O where G.ID_OPERADOR=O.ID and G.ID_SUBEMPRESA=C.ID and G.DIA 
									between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"'and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"' and O.Alias='"+txtOperadorOtros.Text+"' ";
			}else{
				 consulta = @"select G.ID D1, O.Alias D2, C.Empresa D3, G.TURNO D4, CONVERT(CHAR(10),G.DIA, 103) D5 from GUARDIA G, Cliente C, OPERADOR O where G.ID_OPERADOR=O.ID and G.ID_SUBEMPRESA=C.ID and G.DIA 
									between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"'and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"'";
			}
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())	{
					dgMovimientosOtros.Rows.Add(conn.leer["D1"].ToString(), "Guardia", conn.leer["D2"].ToString(), "N/A", conn.leer["D3"].ToString(), "N/A", "N/A", conn.leer["D4"].ToString(),conn.leer["D5"].ToString(), "N/A", "N/A");
			
				}
				conn.conexion.Close();
				
			//RECONOCIMIENTOS	
			if(txtOperadorOtros.Text.Length > 0){
				consulta = @"select RR.ID D1, O.Alias D2, R.Nombre D3, R.Sentido D4, R.Turno D5, CONVERT(CHAR(10),RR.DIA, 103) D6, R.HoraInicio D7 from RECONOCIMIENTO_RUTA RR, OPERADOR O, RUTA R 
					where RR.ID_OPERADOR=O.ID and RR.ID_RUTA=R.ID and RR.DIA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"' and O.Alias='"+txtOperadorOtros.Text+"'";
			}else{
				consulta = @"select RR.ID D1, O.Alias D2, R.Nombre D3, R.Sentido D4, R.Turno D5, CONVERT(CHAR(10),RR.DIA, 103) D6, R.HoraInicio D7 from RECONOCIMIENTO_RUTA RR, OPERADOR O, RUTA R 
					where RR.ID_OPERADOR=O.ID and RR.ID_RUTA=R.ID and RR.DIA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"'";
			}
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())	{
					dgMovimientosOtros.Rows.Add(conn.leer["D1"].ToString(), "Reconocimiento", conn.leer["D2"].ToString(), "N/A", "N/A", conn.leer["D3"].ToString(), conn.leer["D4"].ToString(), conn.leer["D5"].ToString(),conn.leer["D6"].ToString(), conn.leer["D7"].ToString(), "N/A");
			
				}
				conn.conexion.Close();
				
			//RENDIMIENTO
			if(txtOperadorOtros.Text.Length > 0){
				consulta = @"select P.ID_PR D1, O.Alias D2, R.Nombre D3, R.Sentido D4, P.TURNO D5, CONVERT(CHAR(10),P.DIA, 103) D6, R.HoraInicio D7 from PRUEBA_RENDIMIENTO P, OPERADOR O, RUTA R 
								where  P.ID_OP_SUPERVISOR=O.ID and P.ID_RUTA=R.ID and P.DIA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"' and O.Alias='"+txtOperadorOtros.Text+"'";
			}else{
				consulta = @"select P.ID_PR D1, O.Alias D2, R.Nombre D3, R.Sentido D4, P.TURNO D5, CONVERT(CHAR(10),P.DIA, 103) D6, R.HoraInicio D7 from PRUEBA_RENDIMIENTO P, OPERADOR O, RUTA R 
								where  P.ID_OP_SUPERVISOR=O.ID and P.ID_RUTA=R.ID and P.DIA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"'";
			}			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())	{
					dgMovimientosOtros.Rows.Add(conn.leer["D1"].ToString(), "P. Rendimiento", conn.leer["D2"].ToString(), "N/A", "N/A", conn.leer["D3"].ToString(), conn.leer["D4"].ToString(), conn.leer["D5"].ToString(),conn.leer["D6"].ToString(), conn.leer["D7"].ToString(), "N/A");
			
				}
				conn.conexion.Close();
			
			//APOYOS
			if(txtOperadorOtros.Text.Length > 0){
				consulta = @"select A.ID D1, O.Alias D2, R.Nombre D3, R.Sentido D4, A.TURNO D5, CONVERT(CHAR(10),A.DIA, 103 ) D6, A.COMENTARIOS D7, R.HoraInicio D8 from APOYOS A, OPERADOR O, RUTA R 
							where ID_OP_APOYO=O.ID and A.ID_RUTA=R.ID and A.DIA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"' and O.Alias='"+txtOperadorOtros.Text+"'";
			}else{
				consulta = @"select A.ID D1, O.Alias D2, R.Nombre D3, R.Sentido D4, A.TURNO D5, CONVERT(CHAR(10),A.DIA, 103 ) D6, A.COMENTARIOS D7, R.HoraInicio D8 from APOYOS A, OPERADOR O, RUTA R 
							where ID_OP_APOYO=O.ID and A.ID_RUTA=R.ID and A.DIA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"'";
			}
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())	{
					dgMovimientosOtros.Rows.Add(conn.leer["D1"].ToString(), "Apoyo", conn.leer["D2"].ToString(), "N/A", "N/A", conn.leer["D3"].ToString(), conn.leer["D4"].ToString(), conn.leer["D5"].ToString(),conn.leer["D6"].ToString(), conn.leer["D8"].ToString(), conn.leer["D7"].ToString());
			
				}
				conn.conexion.Close();		
			
			//CANCELACION P.
			if(txtOperadorOtros.Text.Length > 0){
				consulta = @"select C.ID D1, O.Alias D2, R.Nombre D3, R.Sentido D4, C.TURNO D5, CONVERT(CHAR(10), C.FECHA, 103) D6, R.HoraInicio D7 from CANCELACION_PUNTO C, OPERADOR O, RUTA R 
					where C.ID_OPERADOR=O.ID and C.ID_RUTA=R.ID and C.FECHA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"' and O.Alias='"+txtOperadorOtros.Text+"'";
			}else{
				consulta = @"select C.ID D1, O.Alias D2, R.Nombre D3, R.Sentido D4, C.TURNO D5, CONVERT(CHAR(10), C.FECHA, 103) D6, R.HoraInicio D7 from CANCELACION_PUNTO C, OPERADOR O, RUTA R 
					where C.ID_OPERADOR=O.ID and C.ID_RUTA=R.ID and C.FECHA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"'";
			}
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())	{
					//ID, tipo, operador, unidad, empresa, ruta, sentido, turno, fecha
					dgMovimientosOtros.Rows.Add(conn.leer["D1"].ToString(), "Cancelado P.", conn.leer["D2"].ToString(), "N/A", "N/A", conn.leer["D3"].ToString(), conn.leer["D4"].ToString(), conn.leer["D5"].ToString(),conn.leer["D6"].ToString(),conn.leer["D7"].ToString(), "N/A");
				}
				conn.conexion.Close();							
			
			colorValidadoOtros();
			dgMovimientosOtros.ClearSelection();
		}
		
		public void OtrosFaltantes()
		{
			dgFaltantesO.Rows.Clear();
			String conss = "";
			if(txtOperadorOtros.Text.Length>0){
				conss = "SELECT * FROM OTROS_FALTANTES where ESTATUS = 1 AND FECHA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"' and OPERADOR like '%"+txtOperadorOtros.Text+"%'";
			}else{
				conss = "SELECT * FROM OTROS_FALTANTES where ESTATUS = 1 AND FECHA between '"+dtpInicioOtros.Value.ToString("yyyy-MM-dd")+"' and '"+dtpCorteOtros.Value.ToString("yyyy-MM-dd")+"'";
			}
			conn.getAbrirConexion(conss);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{				
					dgFaltantesO.Rows.Add(conn.leer["ID"].ToString(),
				                      		conn.leer["ID_A"].ToString(),
				                      		conn.leer["TIPO"].ToString(),
				                      		conn.leer["OPERADOR"].ToString(),
				                      		conn.leer["EMPRESA"].ToString(),  
											conn.leer["RUTA"].ToString(),	
											conn.leer["TURNO"].ToString(),											
				                      		Convert.ToDateTime(conn.leer["FECHA"].ToString().Substring(0,10)).ToShortDateString(),
				                      		conn.leer["UNIDAD"].ToString(),
					                        conn.leer["HORA"].ToString());
				}			
			conn.conexion.Close();			
			dgFaltantesO.ClearSelection();
		}
		#endregion
		
		#region BOTONES
		void BtnConsultarOtrosClick(object sender, EventArgs e)
		{
			otros();
			OtrosFaltantes();
		}
		
		void BtnValidarOtrosClick(object sender, EventArgs e)
		{
			validaOtros();
		}		
		
		void validaOtros()
		{
			int bandera = 0;
			for(int x=0; x<dgMovimientosOtros.Rows.Count; x++)
			{
				if(dgMovimientosOtros.Rows[x].Selected==true && dgMovimientosOtros[11,x].Value.ToString()=="0")
				{
					String consul = "INSERT INTO CIERRE_OTROS VALUES ('"+dgMovimientosOtros[1,x].Value.ToString()+"', '"+dgMovimientosOtros[0,x].Value.ToString()+"', '1', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
					conn.getAbrirConexion(consul);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					bandera = 1;
				}
			}
			if(bandera == 1)
				otros();
		}
		#endregion
		
		#region METODOS
		public void colorValidadoOtros(){						
			for(int x = 0; x < dgMovimientosOtros.Rows.Count; x++){
				
				String conss = "select * from CIERRE_OTROS where ESTATUS!='0' and ID_TIPO = "+dgMovimientosOtros[0,x].Value.ToString() +" AND TIPO = '"+dgMovimientosOtros[1,x].Value.ToString()+"'";
				conn.getAbrirConexion(conss);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgMovimientosOtros[11,x].Value = conn.leer["ESTATUS"].ToString();
					for(int y=0; y<dgMovimientosOtros.Columns.Count; y++)
					{
						dgMovimientosOtros[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
				else
				{
					dgMovimientosOtros[11,x].Value = "0";
				}
				conn.conexion.Close();
				
				String consulta = "SELECT * FROM RELACION_MOVIMIENTO where TIPO != 'VIAJE' and ESTATUS!='0' and ID_R="+dgMovimientosOtros[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					for(int y=0; y<dgMovimientosOtros.Columns.Count; y++)
						{
							dgMovimientosOtros[y,x].Style.BackColor=Color.MediumSpringGreen;
						}
				}
				conn.conexion.Close();
				
				conss = "select * from REVISION_OTROS where ID_TIPO = "+dgMovimientosOtros[0,x].Value.ToString()+" AND TIPO = '"+dgMovimientosOtros[1,x].Value.ToString()+"'";
				conn.getAbrirConexion(conss);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgMovimientosOtros[1,x].Style.BackColor=Color.Red;
				}
				conn.conexion.Close();	
			}
		}
		#endregion
		
		#region EVENTOS
		void DtpInicioOtrosValueChanged(object sender, EventArgs e)
		{
			dtpCorteOtros.MinDate = dtpInicioOtros.Value;
		}
		#endregion	
	}
}
