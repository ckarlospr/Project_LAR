using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.IO;


namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormPruebaRendimiento : Form
	{
		#region CONSTRUCTOR		
		public FormPruebaRendimiento(FormPrincipal refp)
		{
			InitializeComponent();
			refprincipal = refp;
		}
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal refprincipal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();	
		Conexion_Servidor.Combustible.SQL_Combustible connC = new Conexion_Servidor.Combustible.SQL_Combustible();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region VARIABLES
		public Int32 id_usuario;
		bool bandera = true;
		public bool respuesta = true;
		#endregion
		
		#region INICIO - FIN
		void FormPruebaRendimientoLoad(object sender, EventArgs e)
		{
			cargaInicio();
			adaptadorVehiculos();			
		}
		void FormPruebaRendimientoFormClosing(object sender, FormClosingEventArgs e)
		{
			refprincipal.pruebaRendimiento = false;	
		}
		#endregion
		
		#region ADAPTADOR VEHICULOS
		public void adaptadorVehiculos(){
			ColoresAlternadosRows(dgPruebaRendimiento);
			string consulta = "SELECT v.id, op.ID operador,  v.Numero, v.Tipo_Unidad, op.Alias FROM VEHICULO v JOIN  ASIGNACIONUNIDAD au on v.ID = au.ID_UNIDAD JOIN OPERADOR op on au.ID_OPERADOR = op.ID " +
								" WHERE v.Tipo_Unidad != 'Utilitario' ORDER BY V.Tipo_Unidad";
			dgPruebaRendimiento.Rows.Clear();
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgPruebaRendimiento.Rows.Add(conn.leer["id"].ToString(),
				                             conn.leer["Numero"].ToString(),
				                             conn.leer["operador"].ToString(),
				                             conn.leer["Alias"].ToString(),
				                             "SIN PRUEBA", // ID RENDIMIENTO
				                             "SIN PRUEBA", // OPERADOR DE PRUEBA
				                             "SIN PRUEBA", // PREVIO PRUEBA
				                             "SIN PRUEBA", // REDIMITNO PRUEBA
				                             "SIN PRUEBA", // FECHA PRUEBA 
				                             "SIN PRUEBA", // SEGUIMIENTO
				                             "SIN PRUEBA", // ID_RH
				                             "SIN PRUEBA", // LITROS
				                             "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
			}			
			conn.conexion.Close();

 			consulta = "SELECT * FROM VEHICULO WHERE estatus = 1 AND Tipo_Unidad != 'Utilitario' AND  ID NOT IN (select ID_UNIDAD from ASIGNACIONUNIDAD)";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgPruebaRendimiento.Rows.Add(conn.leer["id"].ToString(),
				                             conn.leer["Numero"].ToString(),
				                             
				                             "SIN OPERADOR",
				                             "SIN OPERADOR",
				                             "SIN PRUEBA", // ID RENDIMIENTO
				                             "SIN PRUEBA", // OPERADOR DE PRUEBA
				                             "SIN PRUEBA", // PREVIO PRUEBA
				                             "SIN PRUEBA", // REDIMITNO PRUEBA
				                             "SIN PRUEBA", // FECHA PRUEBA
				                             "SIN PRUEBA", // SEGUIMIENTO 
				                             "SIN PRUEBA", // ID_RH
				                             "SIN PRUEBA", // LITROS
				                             "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"); 
			}
			conn.conexion.Close();
			datosCompleta();			
			dgPruebaRendimiento.ClearSelection();			
		}
				
		private void datosCompleta(){
			Double sumaRendiemintos = 0.0;
			List<string> rendimientos = new List<string>();				
			string parametroPrueba = connC.obtenerParametroPrueba(1);	
			string consul = "";
			int banderacargas = 0;
			for(int x=0; x<dgPruebaRendimiento.Rows.Count; x++){
				try{
					consul = @"SELECT * FROM PRUEBA_RENDIMIENTO_NUEVO WHERE id_v = "+dgPruebaRendimiento[0,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read()){
						dgPruebaRendimiento[4,x].Value = conn.leer["ID"].ToString();
						dgPruebaRendimiento[7,x].Value = conn.leer["rendimiento"].ToString();
						dgPruebaRendimiento[8,x].Value = conn.leer["fecha"].ToString().Substring(0,10);
						dgPruebaRendimiento[9,x].Value = conn.leer["seguimiento"].ToString();
						dgPruebaRendimiento[10,x].Value = conn.leer["id_historial"].ToString();
						dgPruebaRendimiento[11,x].Value = (Convert.ToDouble(conn.leer["litros"])).ToString();
					}				
					conn.conexion.Close();
				}catch(Exception){
				}
					
				if(dgPruebaRendimiento[4,x].Value.ToString() != "SIN PRUEBA" && dgPruebaRendimiento[10,x].Value.ToString() != "SIN PRUEBA"){
					consul = @"SELECT Alias FROM OPERADOR where ID = (select id_operador  from HISTORIAL_PRUEBA_RENDIMIENTO where id = "+dgPruebaRendimiento[10,x].Value.ToString()+")";
					conn.getAbrirConexion(consul);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read()){
						dgPruebaRendimiento[5,x].Value = conn.leer["Alias"].ToString();
					}				
					conn.conexion.Close();					
					
					// aviso de prueba expire
					DateTime oldDate = Convert.ToDateTime(dgPruebaRendimiento[8,x].Value.ToString());
					DateTime newDate = DateTime.Now;		
					TimeSpan ts = newDate - oldDate;	
					int dias = ts.Days;
					if(dias <= Convert .ToInt32(parametroPrueba) && dias >= Convert .ToInt32(parametroPrueba) - 15)
     					dgPruebaRendimiento[8,x].Style.BackColor = Color.Yellow;
					
					//espiro prueba
					oldDate = Convert.ToDateTime(dgPruebaRendimiento[8,x].Value.ToString());
					newDate = DateTime.Now;		
					ts = newDate - oldDate;	
					int meses = ts.Days;
					if(meses >= Convert .ToInt32(parametroPrueba))
     					dgPruebaRendimiento[8,x].Style.BackColor = Color.Red; 

					// ID 5 CARGAS
					banderacargas = 12;
					consul = @"select * from AUTORIZACION where id in (select TOP(6) id from AUTORIZACION where HORA_CARGA is not null  and estatus = 2 and LITROS is not null and ID_V = "+dgPruebaRendimiento[0,x].Value+"  order by FECHA_REG DESC, KM DESC) order by FECHA_REG DESC, KM DESC"; //order by FECHA_REG;
					conn.getAbrirConexion(consul);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read()){
						dgPruebaRendimiento[banderacargas,x].Value = conn.leer["ID"].ToString();
						banderacargas = banderacargas + 2;
					}				
					conn.conexion.Close();					
					
					//5 cargas despues
					
					try{
						if(dgPruebaRendimiento[7,x].Value.ToString() == "0")
							dgPruebaRendimiento[7,x].Value = 1;
						
						if(dgPruebaRendimiento[14,x].Value.ToString() != "0"){							
							consul = @"SELECT ((KM - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[14,x].Value+"))/litros) rendimiento, (((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[14,x].Value+"))/litros) * 100)/"+dgPruebaRendimiento[7,x].Value
								+" eficiencia, (CAST(LITROS  AS FLOAT)) - ((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[14,x].Value+")) / "+dgPruebaRendimiento[7,x].Value+") as litross FROM AUTORIZACION WHERE ID = "+dgPruebaRendimiento[12,x].Value;
							conn.getAbrirConexion(consul);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read()){
								dgPruebaRendimiento[13,x].Value = "R: "+conn.leer["rendimiento"].ToString().Substring(0,5)+ ", %: "+conn.leer["eficiencia"].ToString().Substring(0,5)+ ", L: "+Math.Round(Convert.ToDouble(conn.leer["litross"]),2);
								rendimientos.Add(conn.leer["rendimiento"].ToString());
							}
							conn.conexion.Close();
						}
						
						if(dgPruebaRendimiento[16,x].Value.ToString() != "0"){
							consul = @"SELECT ((KM - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[16,x].Value+"))/litros) rendimiento, (((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[16,x].Value+"))/litros) * 100)/"+dgPruebaRendimiento[7,x].Value
								+" eficiencia, (CAST(LITROS  AS FLOAT)) - ((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[16,x].Value+")) / "+dgPruebaRendimiento[7,x].Value+") as litross FROM AUTORIZACION WHERE ID = "+dgPruebaRendimiento[14,x].Value;
							conn.getAbrirConexion(consul);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read()){
								dgPruebaRendimiento[15,x].Value = "R: "+conn.leer["rendimiento"].ToString().Substring(0,5)+ ", %: "+conn.leer["eficiencia"].ToString().Substring(0,5)+ ", L: "+Math.Round(Convert.ToDouble(conn.leer["litross"]),2);
								rendimientos.Add(conn.leer["rendimiento"].ToString());
							}
							conn.conexion.Close();
						}
						if(dgPruebaRendimiento[18,x].Value.ToString() != "0"){
							consul = @"SELECT ((KM - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[18,x].Value+"))/litros) rendimiento, (((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[18,x].Value+"))/litros) * 100)/"+dgPruebaRendimiento[7,x].Value
								+" eficiencia, (CAST(LITROS  AS FLOAT)) - ((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[18,x].Value+")) / "+dgPruebaRendimiento[7,x].Value+") as litross FROM AUTORIZACION WHERE ID = "+dgPruebaRendimiento[16,x].Value;
							conn.getAbrirConexion(consul);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read()){
								dgPruebaRendimiento[17,x].Value = "R: "+conn.leer["rendimiento"].ToString().Substring(0,5)+ ", %: "+conn.leer["eficiencia"].ToString().Substring(0,5)+ ", L: "+Math.Round(Convert.ToDouble(conn.leer["litross"]),2);
								rendimientos.Add(conn.leer["rendimiento"].ToString());
							}
							conn.conexion.Close();
						}
						if(dgPruebaRendimiento[20,x].Value.ToString() != "0"){
							consul = @"SELECT ((KM - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[20,x].Value+"))/litros) rendimiento, (((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[20,x].Value+"))/litros) * 100)/"+dgPruebaRendimiento[7,x].Value
								+" eficiencia, (CAST(LITROS  AS FLOAT)) - ((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[20,x].Value+")) / "+dgPruebaRendimiento[7,x].Value+") as litross FROM AUTORIZACION WHERE ID = "+dgPruebaRendimiento[18,x].Value;
							conn.getAbrirConexion(consul);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read()){
								dgPruebaRendimiento[19,x].Value = "R: "+conn.leer["rendimiento"].ToString().Substring(0,5)+ ", %: "+conn.leer["eficiencia"].ToString().Substring(0,5)+ ", L: "+Math.Round(Convert.ToDouble(conn.leer["litross"]),2);
								rendimientos.Add(conn.leer["rendimiento"].ToString());
							}
							conn.conexion.Close();
						}
						if(dgPruebaRendimiento[22,x].Value.ToString() != "0"){
							consul = @"SELECT ((KM - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[22,x].Value+"))/litros) rendimiento, (((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[22,x].Value+"))/litros) * 100)/"+dgPruebaRendimiento[7,x].Value
								+" eficiencia, (CAST(LITROS  AS FLOAT)) - ((km - (select KM from AUTORIZACION where id = "+dgPruebaRendimiento[22,x].Value+")) / "+dgPruebaRendimiento[7,x].Value+") as litross FROM AUTORIZACION WHERE ID = "+dgPruebaRendimiento[20,x].Value;
							conn.getAbrirConexion(consul);
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read()){
								dgPruebaRendimiento[21,x].Value = "R: "+conn.leer["rendimiento"].ToString().Substring(0,5)+ ", %: "+conn.leer["eficiencia"].ToString().Substring(0,5)+ ", L: "+Math.Round(Convert.ToDouble(conn.leer["litross"]),2);
								rendimientos.Add(conn.leer["rendimiento"].ToString());
							}
							conn.conexion.Close();
						}

						// promedio	
						
						for(int z = 0; z < rendimientos.Count; z++){	
							sumaRendiemintos = sumaRendiemintos + Convert.ToDouble(rendimientos[z]);
						}						
						dgPruebaRendimiento[6,x].Value = Math.Round(Convert.ToDouble(sumaRendiemintos/rendimientos.Count), 2);						
						sumaRendiemintos = 0.0;
						rendimientos.Clear();
						
					}catch(Exception){
						conn.conexion.Close();
					}
				}
									
				if(dgPruebaRendimiento[4,x].Value.ToString() == "SIN PRUEBA"){
					for(int y = 5; y < dgPruebaRendimiento.Columns.Count; y++){
						dgPruebaRendimiento[y,x].Style.BackColor = Color.Red;
					}					
				}
			}
		}
		#endregion
		
		#region ADAPTADOR BUSQUEDAS
		private void adaptadorHistorial(string id_r){
			int contador = 0;
			ColoresAlternadosRows(dgHistorial);
			string consulta = @"select h.*, o.Alias, o.ID as id_operador, p.id_historial from HISTORIAL_PRUEBA_RENDIMIENTO h JOIN OPERADOR o on h.id_operador = o.ID 
								 JOIN PRUEBA_RENDIMIENTO_NUEVO p on p.id = h.id_rendimiento where h.id_rendimiento = '"+id_r+"'";
			dgHistorial.Rows.Clear();
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgHistorial.Rows.Add(conn.leer["id_rendimiento"].ToString(), 
				                     conn.leer["ID"].ToString(), //ID HISTORIAL
				                     dgPruebaRendimiento[1,dgPruebaRendimiento.CurrentRow.Index].Value.ToString(),
				                     conn.leer["id_operador"].ToString(),
				                     conn.leer["Alias"].ToString(),
				                     conn.leer["usuario_prueba"].ToString(), //5
				                     conn.leer["rendimiento"].ToString(),
				                     conn.leer["fecha_prueba"].ToString().Substring(0,10),
				                     conn.leer["hora_inicio_prueba"].ToString(),
				                     conn.leer["hora_fin_prueba"].ToString(),
				                     conn.leer["litros_carga"].ToString(),
				                     conn.leer["km_inicial_prueba"].ToString(),
				                     conn.leer["km_fin_prueba"].ToString(),
				                     conn.leer["seguimiento"].ToString(),
				                     conn.leer["comentario"].ToString());
				
				if(conn.leer["id_historial"].ToString() == conn.leer["ID"].ToString())
					dgHistorial[7,contador].Style.BackColor = Color.LightGreen;
				++contador;					
			}
			conn.conexion.Close();		
			dgHistorial.ClearSelection();			
		}

		private void adaptadorHistorialCompleto(){
			int contador = 0;
			ColoresAlternadosRows(dgHistorial);
			string consulta = @"SELECT P.ID ID_R, p.id_historial, H.*, V.Numero FROM PRUEBA_RENDIMIENTO_NUEVO P JOIN HISTORIAL_PRUEBA_RENDIMIENTO H ON P.ID = H.id_rendimiento JOIN VEHICULO V ON P.id_v = V.ID
								WHERE V.Numero LIKE '%"+txtBusqueda.Text+"%' AND H.fecha_prueba BETWEEN '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"'";
			dgHistorial.Rows.Clear();
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgHistorial.Rows.Add(conn.leer["ID_R"].ToString(), 
				                     conn.leer["ID"].ToString(), 
				                     conn.leer["Numero"].ToString(),
				                     conn.leer["id_operador"].ToString(),
				                     "",
				                     conn.leer["usuario_prueba"].ToString(), //5
				                     conn.leer["rendimiento"].ToString(),
				                     conn.leer["fecha_prueba"].ToString().Substring(0,10),
				                     conn.leer["hora_inicio_prueba"].ToString(),
				                     conn.leer["hora_fin_prueba"].ToString(),
				                     conn.leer["litros_carga"].ToString(),
				                     conn.leer["km_inicial_prueba"].ToString(),
				                     conn.leer["km_fin_prueba"].ToString(),
				                     conn.leer["seguimiento"].ToString(),
				                     conn.leer["comentario"].ToString());
				if(conn.leer["id_historial"].ToString() == conn.leer["ID"].ToString())
					dgHistorial[7,contador].Style.BackColor = Color.LightGreen;
				++contador;		
			}
			conn.conexion.Close();
			
			for(int x=0; x<dgHistorial.Rows.Count; x++){
				consulta = @"SELECT Alias FROM OPERADOR WHERE ID = "+dgHistorial[3,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgHistorial[4,x].Value = conn.leer["Alias"].ToString();
				}				
				conn.conexion.Close();
			}
			dgHistorial.ClearSelection();			
		}		
		#endregion
		
		#region METODOS	
		private void reporteHistorial(){
			btnImprimirHst.Enabled = false;
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();	
			ExcelApp = new nmExcel.ApplicationClass();				
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			nmExcel.Worksheet newWorksheet;
			newWorksheet = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			newWorksheet.Name = "Historial de Pruebas";
			nmExcel.Range cells =  newWorksheet.Cells;
							
			int i = 1;
			cells[i,  1] = "UNIDAD";
			cells[i,  2] = "OPERADOR ACTUAL";
			cells[i,  3] = "OPERADOR PRUEBA";
			cells[i,  4] = "USUARIO";
			cells[i,  5] = "RENDIMIENTO";
			cells[i,  6] = "FECHA PRUEBA";
			cells[i,  7] = "HORA DE INICIO";
			cells[i,  8] = "HORA DE FIN";
			cells[i,  9] = "LITROS CARGADOS";
			cells[i,  10] = "KM INICIAL";
			cells[i,  11] = "KM FINAL";
			cells[i,  12] = "SEGUIMEINTO";			
			cells[i,  13] = "COMENTARIOS";
			
			for(int x=0; x<dgPruebaRendimiento.Rows.Count; x++){
				try{
					string consulta = @"select h.*, o.Alias, o.ID as id_operador, p.id_historial from HISTORIAL_PRUEBA_RENDIMIENTO h JOIN OPERADOR o on h.id_operador = o.ID 
									 JOIN PRUEBA_RENDIMIENTO_NUEVO p on p.id = h.id_rendimiento where h.id_rendimiento = '"+dgPruebaRendimiento[4,x].Value+"'";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();		
					while(conn.leer.Read()){
						++i;
						try{cells[i,  1] = dgPruebaRendimiento[1,x].Value; }catch (Exception){cells[i,  1] = "";}
						try{cells[i,  2] = dgPruebaRendimiento[3,x].Value; }catch (Exception){cells[i,  2] = "";}
						try{cells[i,  3] = conn.leer["Alias"].ToString(); }catch (Exception){cells[i,  3] = "";}
						try{cells[i,  4] = conn.leer["usuario_prueba"].ToString(); }catch (Exception){cells[i,  4] = "";}
						try{cells[i,  5] = conn.leer["rendimiento"].ToString(); }catch (Exception){cells[i,  5] = "";}
						try{cells[i,  6] = conn.leer["fecha_prueba"].ToString().Substring(0,10); }catch (Exception){cells[i,  6] = "";}
						try{cells[i,  7] = conn.leer["hora_inicio_prueba"].ToString(); }catch (Exception){cells[i,  7] = "";}
						try{cells[i,  8] = conn.leer["hora_fin_prueba"].ToString(); }catch (Exception){cells[i,  8] = "";}
						try{cells[i,  9] = conn.leer["litros_carga"].ToString(); }catch (Exception){cells[i,  9] = "";}
						try{cells[i,  10] = conn.leer["km_inicial_prueba"].ToString(); }catch (Exception){cells[i,  10] = "";}
						try{cells[i,  11] = conn.leer["km_fin_prueba"].ToString(); }catch (Exception){cells[i,  11] = "";}
						try{cells[i,  12] = conn.leer["seguimiento"].ToString(); }catch (Exception){cells[i,  12] = "";}
						try{cells[i,  13] = conn.leer["comentario"].ToString(); }catch (Exception){cells[i,  13] = "";}
					}
					conn.conexion.Close();
				}catch(Exception){
					if(conn.conexion != null)						
						conn.conexion.Close();	
				}
			}
				
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte Pruebas de Rendimiento "+DateTime.Now.ToString("dd-MM-yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK){
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
				
				Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Reporte Pruebas de Rendimiento "+DateTime.Now.ToString("dd-MM-yyyy")+".xlsx");
				
				btnImprimirHst.Enabled = true;
			}else{
				MessageBox.Show("No Genero el Reporte ... ");
				btnImprimirHst.Enabled = true;
			}
		}
		
		private void reporteHistorialPruebas(){			
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			ExcelApp.Cells[i,  1] = "UNIDAD";
			ExcelApp.Cells[i,  2] = "OPERADOR";
			ExcelApp.Cells[i,  3] = "USUARIO";
			ExcelApp.Cells[i,  4] = "RENDIMIENTO";
			ExcelApp.Cells[i,  5] = "FECHA PRUEBA";
			ExcelApp.Cells[i,  6] = "HORA DE INICIO";
			ExcelApp.Cells[i,  7] = "HORA DE FIN";
			ExcelApp.Cells[i,  8] = "LITROS CARGADOS";
			ExcelApp.Cells[i,  9] = "KM INICIAL";
			ExcelApp.Cells[i,  10] = "KM FINAL";
			ExcelApp.Cells[i,  11] = "SEGUIMEINTO";			
			ExcelApp.Cells[i,  12] = "COMENTARIOS";
			
			for(int x=0; x<dgHistorial.Rows.Count; x++){
				++i;				
				try{ExcelApp.Cells[i,  1] = dgHistorial[2,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  1] = "";}
				try{ExcelApp.Cells[i,  2] = dgHistorial[4,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  3] = dgHistorial[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  3] = "";}
				try{ExcelApp.Cells[i,  4] = dgHistorial[6,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  4] = "";}
				try{ExcelApp.Cells[i,  5] = dgHistorial[7,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  5] = "";}
				try{ExcelApp.Cells[i,  6] = dgHistorial[8,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
				try{ExcelApp.Cells[i,  7] = dgHistorial[9,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  7] = "";}
				try{ExcelApp.Cells[i,  8] = dgHistorial[10,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  8] = "";}
				try{ExcelApp.Cells[i,  9] = dgHistorial[11,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  9] = "";}
				try{ExcelApp.Cells[i,  10] = dgHistorial[12,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 10 ] = "";}				
				try{ExcelApp.Cells[i,  11] = dgHistorial[13,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 6 ] = "";}				
				try{ExcelApp.Cells[i,  12] = dgHistorial[14,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}
				
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte Historial Pruebas de Rendimeinto "+DateTime.Now.ToString("dd-MM-yyyy");
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
		}
		
		private void reporteOperadoresPruebas(){
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			ExcelApp.Cells[i,  1] = "UNIDAD";
			ExcelApp.Cells[i,  2] = "OPERADOR";
			ExcelApp.Cells[i,  3] = "OPERADOR PRUEBA";
			ExcelApp.Cells[i,  4] = "FECHA PRUEBA";
			ExcelApp.Cells[i,  5] = "RENDIMIENTO";
			ExcelApp.Cells[i,  6] = "SEGUIMEINTO";
			ExcelApp.Cells[i,  7] = "CARGA 1";		
			ExcelApp.Cells[i,  8] = "CARGA 2";		
			ExcelApp.Cells[i,  9] = "CARGA 3";		
			ExcelApp.Cells[i,  10] = "CARGA 4";
			ExcelApp.Cells[i,  11] = "CARGA 5";
			
			for(int x=0; x<dgPruebaRendimiento.Rows.Count; x++){
				++i;				
				try{ExcelApp.Cells[i,  1] = dgPruebaRendimiento[1,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  1] = "";}
				try{ExcelApp.Cells[i,  2] = dgPruebaRendimiento[3,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  3] = dgPruebaRendimiento[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  4] = dgPruebaRendimiento[8,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  3] = "";}
				try{ExcelApp.Cells[i,  5] = dgPruebaRendimiento[7,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  4] = "";}
				try{ExcelApp.Cells[i,  6] = dgPruebaRendimiento[9,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  5] = "";}
				try{ExcelApp.Cells[i,  7] = dgPruebaRendimiento[13,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
				try{ExcelApp.Cells[i,  8] = dgPruebaRendimiento[15,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  7] = "";}
				try{ExcelApp.Cells[i,  9] = dgPruebaRendimiento[17,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  8] = "";}
				try{ExcelApp.Cells[i,  10] = dgPruebaRendimiento[19,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  9] = "";}
				try{ExcelApp.Cells[i,  11] = dgPruebaRendimiento[21,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 10 ] = "";}
				
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte Pruebas de Rendimeinto "+DateTime.Now.ToString("dd-MM-yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK){
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}else{
				MessageBox.Show("No Genero el Reporte ... ");
			}
			
		}
		
		public void cargaInicio(){			
			txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT Numero FROM VEHICULO WHERE estatus = 1", "Numero");
           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtbusUnidad.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT Numero FROM VEHICULO WHERE estatus = 1", "Numero");
           	txtbusUnidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtbusUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			id_usuario = refprincipal.idUsuario;
			
			if(refprincipal.lblDatoNivel.Text == "GERENCIAL" || refprincipal.lblDatoNivel.Text == "MASTER")
				pbConfiguraciones.Visible = true;		
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		
		private bool agregarPrueba(int bandera){			
			if(dgPruebaRendimiento[2,dgPruebaRendimiento.CurrentRow.Index].Value.ToString() != "SIN OPERADOR"){			
				if(bandera == 1){
					new FormAgregarPruebaR(this, 1, id_usuario).ShowDialog();
				}
				if(bandera == 2){
					new FormAgregarPruebaR(this, 2, id_usuario).ShowDialog();
				}
			}else{
				DialogResult resultado = MessageBox.Show("El vehiculo no tiene asignado un operador ¿Deseas continuar? ", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(resultado == DialogResult.Yes){
					if(bandera == 1)
						new FormAgregarPruebaR(this, 1, id_usuario).ShowDialog();					
					if(bandera == 2)
						new FormAgregarPruebaR(this, 2, id_usuario).ShowDialog();					
				}else{					
					respuesta = false;
				}
			}
			return respuesta;
		}
		
		public void limpiar(){
			adaptadorVehiculos();
			gbFiltros.Visible = false;
			bandera = true;
			cbTodas.Checked = false;
			dgHistorial.Rows.Clear();
		}		
		#endregion
		
		#region EVENTOS
		void TxtbusUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Return"){
				dgPruebaRendimiento.ClearSelection();				
				for(int x=0; x<dgPruebaRendimiento.Rows.Count; x++){
					if(txtbusUnidad.Text == dgPruebaRendimiento[1,x].Value.ToString()){
						dgPruebaRendimiento.Rows[x].Selected = true;
						dgPruebaRendimiento.FirstDisplayedCell = dgPruebaRendimiento.Rows[x].Cells[1];
					}
				}
			}else if(txtbusUnidad.Text.Length == 3){
				dgPruebaRendimiento.ClearSelection();				
				for(int x=0; x<dgPruebaRendimiento.Rows.Count; x++){
					if(txtbusUnidad.Text == dgPruebaRendimiento[1,x].Value.ToString()){
						dgPruebaRendimiento.Rows[x].Selected = true;
						dgPruebaRendimiento.FirstDisplayedCell = dgPruebaRendimiento.Rows[x].Cells[1];
					}
				}
			}
		}
		
		void DgHistorialCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgHistorial.SelectedRows.Count == 1){
				new FormAgregarPruebaR(this, 3, id_usuario).ShowDialog();
				if(respuesta)
					limpiar();
			}
		}
		
		void DgPruebaRendimientoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex >-1 && e.ColumnIndex != 9){
				if(dgPruebaRendimiento[7,e.RowIndex].Value.ToString() != "SIN PRUEBA"){
				if(dgPruebaRendimiento[8,e.RowIndex].Style.BackColor == Color.Red){
					DialogResult res = MessageBox.Show("El vehículo que seleccionaste ya expiro su ultima prueba de rendimiento. ¿Deseas agregar una nueva prueba?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(res == DialogResult.Yes){
						if(agregarPrueba(2))
							limpiar();
					}else{
						gbFiltros.Visible = true;
						bandera = false;
						adaptadorHistorial(dgPruebaRendimiento[4, dgPruebaRendimiento.CurrentRow.Index].Value.ToString());
					}
				}else{
					if(bandera == true){
						gbFiltros.Visible = true;
						bandera = false;
						adaptadorHistorial(dgPruebaRendimiento[4, dgPruebaRendimiento.CurrentRow.Index].Value.ToString());
					}else{	
						gbFiltros.Visible = false;
						bandera = true;
					}
				}
				}else{
					DialogResult res = MessageBox.Show("El vehículo que seleccionaste no tiene ninguna prueba de rendimiento registrada. ¿Deseas agregar una nueva prueba?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(res == DialogResult.Yes){
						if(agregarPrueba(1))
							limpiar();
					}
				}
			}
			
			if(e.ColumnIndex >-1 && e.ColumnIndex == 9 && dgPruebaRendimiento[4, e.RowIndex].Value.ToString() != "SIN PRUEBA")
				new FormSeguimientoP(this, dgPruebaRendimiento[4, e.RowIndex].Value.ToString(), dgPruebaRendimiento[9, e.RowIndex].Value.ToString(), 
				                     dgPruebaRendimiento[10, e.RowIndex].Value.ToString(), id_usuario.ToString()).ShowDialog();
			
			if(e.ColumnIndex >-1 && e.ColumnIndex == 9 && dgPruebaRendimiento[4, e.RowIndex].Value.ToString() == "SIN PRUEBA"){
				DialogResult res = MessageBox.Show("El vehículo que seleccionaste no tiene ninguna prueba de rendimiento registrada. ¿Deseas agregar una nueva prueba?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(res == DialogResult.Yes){
					if(agregarPrueba(1))
						limpiar();
				}
			}
		}
		
		void CbTodasCheckedChanged(object sender, EventArgs e)
		{
			if(cbTodas.Checked == true){
				pnFiltros.Enabled = true;
				adaptadorHistorialCompleto();
			}else{
				pnFiltros.Enabled = false;
				if(dgPruebaRendimiento.SelectedRows.Count == 1)
					adaptadorHistorial(dgPruebaRendimiento[4, dgPruebaRendimiento.CurrentRow.Index].Value.ToString());
				else
					limpiar();
			}
		}
		
		void NuebaPruebaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgPruebaRendimiento.SelectedRows.Count == 1){
				if(agregarPrueba(2))
					limpiar();
			}
		}
		
		void HistorialPruebasToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(dgPruebaRendimiento.SelectedRows.Count == 1){
				if(dgPruebaRendimiento[4, dgPruebaRendimiento.CurrentRow.Index].Value.ToString() == "SIN PRUEBA"){
					DialogResult res = MessageBox.Show("El vehículo que seleccionaste no tiene ninguna prueba de rendimiento registrada. ¿Deseas agregar una nueva prueba?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(res == DialogResult.Yes){
						if(agregarPrueba(1))
							limpiar();
					}				
				}else{
					if(bandera == true){
						gbFiltros.Visible = true;
						bandera = false;
						adaptadorHistorial(dgPruebaRendimiento[4, dgPruebaRendimiento.CurrentRow.Index].Value.ToString());
					}else{	
						gbFiltros.Visible = false;
						bandera = true;
					}
				}
			}
		}
		#endregion
				
		#region BOTONES
		void PbConfiguracionesClick(object sender, EventArgs e)
		{
			new FormParametrosCombu(this, id_usuario).ShowDialog();
		}
		
		void BntBuscarClick(object sender, EventArgs e)
		{
			adaptadorHistorialCompleto();
		}
		
		void LblMostrarClick(object sender, EventArgs e)
		{
			gbFiltros.Visible = false;
			bandera = true;
		}
		
		void BtnReporteClick(object sender, EventArgs e)
		{
			reporteOperadoresPruebas();
		}
		
		void CmdImprimirClick(object sender, EventArgs e)
		{
			reporteHistorialPruebas();
		}		
		
		void BtnImprimirHstClick(object sender, EventArgs e)
		{
			reporteHistorial();
		}
		#endregion		
	}
}
