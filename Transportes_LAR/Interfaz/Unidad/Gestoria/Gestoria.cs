using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Transportes_LAR.Interfaz.Unidad.Gestoria
{
	public partial class Gestoria : Form
	{
		
	////////////////////////////////////////CONTROL PERIODOS/////////////////////////////////////////////////	
		
	#region CONSTRUCTOR
	public Gestoria(FormPrincipal refp, int id_usu)
	{
		InitializeComponent();
		principal = refp;
		id_usuario = id_usu;
	}
	#endregion	
	
	#region VARIABLES
	int id_usuario;
	#endregion
	
	#region INSTANCIAS
	private FormPrincipal principal;
	private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
	private Conexion_Servidor.Unidad.SQL_Unidad connU = new Conexion_Servidor.Unidad.SQL_Unidad();
	private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();	
	private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
	#endregion
	
	#region INICIO
	void GestoriaLoad(object sender, EventArgs e)
		{
		txtUnidad.AutoCompleteCustomSource = auto.AutocompleteGeneral("select numero from vehiculo where estatus = 1", "numero");
		txtUnidad.AutoCompleteMode = AutoCompleteMode.Suggest;
		txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
		
		txtPlaca.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Placa_Estatal from VEHICULO where estatus = 1 UNION ALL select Placa_Federal from VEHICULO where estatus = 1","Placa_Estatal");
		txtPlaca.AutoCompleteMode = AutoCompleteMode.Suggest;
		txtPlaca.AutoCompleteSource = AutoCompleteSource.CustomSource;
		
			Mostrar();
			PrevisionPeriodos();
			validacionPeriodos();
			filtrosSeguros();
		}
	
	void GestoriaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.unidadGesto = false;
		}
	#endregion
		
	#region FILTROS
	public void Mostrar(){
	 	string consulta = "select * from VEHICULO where estatus = 1";
	 	AdaptadorPeriodos(consulta);
	}
	#endregion
	
	#region ADAPTADOR
	public void AdaptadorPeriodos(string consulta){
		dataGridViewPeriodos.Rows.Clear();
		conn.getAbrirConexion(consulta);
		conn.leer = conn.comando.ExecuteReader();
		while(conn.leer.Read()){
			dataGridViewPeriodos.Rows.Add(conn.leer["ID"].ToString(),
			                              conn.leer["Numero"].ToString(),
			                              conn.leer["Placa_Estatal"].ToString(),
			                              conn.leer["Placa_Federal"].ToString(),
			                              "SIN REGISTRO", //Placa Actual
										  "SIN REGISTRO", //Refrendo
										  "SIN REGISTRO", //Permiso
										  "SIN REGISTRO", //Verificacion1
										  "SIN REGISTRO", //Verificacion2
										  "SIN REGISTRO", //Fisico Mecanico
										  "CANCELADA", //Cobertura
										  "SIN REGISTRO", //Inicio
										  "SIN REGISTRO", //Vence
										  "SIN REGISTRO", //Poliza1
										  "SIN REGISTRO", //Poliza2
										  "SIN REGISTRO", //Caseta1
										  "SIN REGISTRO"); //Caseta2	
		}
		conn.conexion.Close();
		CompletaDatosPeriodos();
		dataGridViewPeriodos.ClearSelection();	
	}
	
	public void CompletaDatosPeriodos(){
		for(int X = 0; X < dataGridViewPeriodos.Rows.Count; X++){
			string consulta ="select * from VEHICULOS_PERIODOS where ID_VEHICULO  = " + dataGridViewPeriodos[0, X].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				dataGridViewPeriodos[4,X].Value = conn.leer["PLACA_ACTUAL"].ToString();
				dataGridViewPeriodos[5,X].Value = conn.leer["REFRENDO_PERIODO"].ToString();
				dataGridViewPeriodos[6,X].Value = conn.leer["PERMISO_PERIODO"].ToString();
				dataGridViewPeriodos[7,X].Value = conn.leer["VERIFICACION_PERIODO1"].ToString();
				dataGridViewPeriodos[8,X].Value = conn.leer["VERIFICACION_PERIODO2"].ToString();
				dataGridViewPeriodos[9,X].Value = conn.leer["FISICO_MECANICO_PERIODO"].ToString();
				dataGridViewPeriodos[10,X].Value = conn.leer["COBERTURA"].ToString();
				dataGridViewPeriodos[11,X].Value = conn.leer["INICIO_POLIZA"].ToString();
				dataGridViewPeriodos[12,X].Value = conn.leer["VENCE_POLIZA"].ToString();
				dataGridViewPeriodos[13,X].Value = conn.leer["POLIZA_PERIODO1"].ToString();
				dataGridViewPeriodos[14,X].Value = conn.leer["POLIZA_PERIODO2"].ToString();
				dataGridViewPeriodos[15,X].Value = conn.leer["CASETA1"].ToString();
				dataGridViewPeriodos[16,X].Value = conn.leer["CASETA2"].ToString();	
			}
			conn.conexion.Close();
			
			if(dataGridViewPeriodos[4,X].Value.ToString() != "SIN REGISTRO"){
				if(dataGridViewPeriodos[4,X].Value.ToString() == "E"){
					dataGridViewPeriodos[2,X].Style.BackColor = Color.LightGreen;					
					dataGridViewPeriodos[5,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[6,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[7,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[8,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[10,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[11,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[12,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[13,X].Style.BackColor = Color.LightGoldenrodYellow;			
					dataGridViewPeriodos[14,X].Style.BackColor = Color.LightGoldenrodYellow;			
					dataGridViewPeriodos[15,X].Style.BackColor = Color.LightGoldenrodYellow;			
					dataGridViewPeriodos[16,X].Style.BackColor = Color.LightGoldenrodYellow;
					
				}else{
					dataGridViewPeriodos[3,X].Style.BackColor = Color.LightGreen;				
					dataGridViewPeriodos[6,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[7,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[8,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[9,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[10,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[11,X].Style.BackColor = Color.LightGoldenrodYellow;				
					dataGridViewPeriodos[12,X].Style.BackColor = Color.LightGoldenrodYellow;			
					dataGridViewPeriodos[13,X].Style.BackColor = Color.LightGoldenrodYellow;			
					dataGridViewPeriodos[14,X].Style.BackColor = Color.LightGoldenrodYellow;			
					dataGridViewPeriodos[15,X].Style.BackColor = Color.LightGoldenrodYellow;			
					dataGridViewPeriodos[16,X].Style.BackColor = Color.LightGoldenrodYellow;	
				}				
			}	
		}
	}
	#endregion	
	
	#region BOTONES
	
	//OCULTAR CELDAS
	void BtnCategoriaClick(object sender, EventArgs e)
	{
		if(dataGridViewPeriodos[15,dataGridViewPeriodos.CurrentCell.RowIndex].Visible == false){
			dataGridViewPeriodos.Columns[15].Visible = true;
			dataGridViewPeriodos.Columns[16].Visible = true;
		}else{
			dataGridViewPeriodos.Columns[15].Visible = false;
			dataGridViewPeriodos.Columns[16].Visible = false;
		}
	}
	#endregion	
	
    ////////////////////////////////////////PREVISION//////////////////////////////////////////////////////////	
 
    #region ADAPTADOR
    public void AdaptadorPrevision(string consulta){
		conn.getAbrirConexion(consulta);
		conn.leer=conn.comando.ExecuteReader();
		while(conn.leer.Read()){
			dataGridViewPrevision.Rows.Add(conn.leer["tipoGestion"].ToString(),
			                               conn.leer["Numero"].ToString(),
			                               conn.leer["PlacaActual"],
			                               conn.leer["PLACA_ACTUAL"],
			                               conn.leer["Propietario"],
			                               conn.leer["Motor_Num_Serie"],
			                               conn.leer["Numero_Serie"]);
		}
		conn.conexion.Close();
		dataGridViewPrevision.ClearSelection();
	}
	#endregion	
	
	#region FILTROS
    public void PrevisionPeriodos(){
		dataGridViewPrevision.Rows.Clear();
			string mes = "";
			string consulta = "";
			int parametro = 0;
			 
			parametro = Convert.ToInt16(connU.obtenerParametro1("REFRENDO"));		
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "1")
				mes = "ENERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "2")
				mes = "FEBRERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "3")
				mes = "MARZO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "4")
				mes = "ABRIL";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "5")
				mes = "MAYO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "6")
				mes = "JUNIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "7")
				mes = "JULIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "8")
				mes = "AGOSTO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "9")
				mes = "SEPTIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "10")
				mes = "OCTUBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "11")
				mes = "NOVIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "12")
				mes = "DICIEMBRE";
			
			if(cmbBusquedaPeriodo.SelectedIndex > -1)
				mes = cmbBusquedaPeriodo.Text;
			
			consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'REFRENDO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.REFRENDO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.REFRENDO_PERIODO = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'REFRENDO' AND FECHA_REGISTRO = '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01"+"') order by vp.PLACA_ACTUAL";
								
			if(cbMostrarTipos.Checked == true){
				consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'REFRENDO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.REFRENDO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.REFRENDO_PERIODO = '"+mes+"' order by vp.PLACA_ACTUAL";
			}		
			AdaptadorPrevision(consulta);
			

			parametro = Convert.ToInt16(connU.obtenerParametro1("PERMISO"));
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "1")
				mes = "ENERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "2")
				mes = "FEBRERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "3")
				mes = "MARZO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "4")
				mes = "ABRIL";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "5")
				mes = "MAYO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "6")
				mes = "JUNIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "7")
				mes = "JULIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "8")
				mes = "AGOSTO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "9")
				mes = "SEPTIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "10")
				mes = "OCTUBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "11")
				mes = "NOVIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "12")
				mes = "DICIEMBRE";
			
			if(cmbBusquedaPeriodo.SelectedIndex > -1)
				mes = cmbBusquedaPeriodo.Text;
			
			consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario,  'PERMISO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.PERMISO_PERIODO = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'PERMISO' AND FECHA_REGISTRO = '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01"+"') order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTipos.Checked == true){
				consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario,  'PERMISO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.PERMISO_PERIODO = '"+mes+"' order by vp.PLACA_ACTUAL";
			}		
			AdaptadorPrevision(consulta);
			
			
			parametro = Convert.ToInt16(connU.obtenerParametro1("VERIFICACION"));
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "1")
				mes = "ENERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "2")
				mes = "FEBRERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "3")
				mes = "MARZO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "4")
				mes = "ABRIL";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "5")
				mes = "MAYO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "6")
				mes = "JUNIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "7")
				mes = "JULIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "8")
				mes = "AGOSTO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "9")
				mes = "SEPTIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "10")
				mes = "OCTUBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "11")
				mes = "NOVIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "12")
				mes = "DICIEMBRE";	
			
			if(cmbBusquedaPeriodo.SelectedIndex > -1)
				mes = cmbBusquedaPeriodo.Text;					
			
			consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'VERIFICACION' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where (vp.VERIFICACION_PERIODO1 = '"+mes+"' OR vp.VERIFICACION_PERIODO2 = '"+mes+"')and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'VERIFICACION' AND FECHA_REGISTRO = '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01"+"') order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTipos.Checked == true){
				consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'VERIFICACION' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where (vp.VERIFICACION_PERIODO1 = '"+mes+"' OR vp.VERIFICACION_PERIODO2 = '"+mes+"') order by vp.PLACA_ACTUAL";
			
			}		
			AdaptadorPrevision(consulta);
			
			
			parametro = Convert.ToInt16(connU.obtenerParametro1("FISICOMECANICO"));
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "1")
				mes = "ENERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "2")
				mes = "FEBRERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "3")
				mes = "MARZO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "4")
				mes = "ABRIL";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "5")
				mes = "MAYO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "6")
				mes = "JUNIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "7")
				mes = "JULIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "8")
				mes = "AGOSTO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "9")
				mes = "SEPTIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "10")
				mes = "OCTUBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "11")
				mes = "NOVIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "12")
				mes = "DICIEMBRE";	
			
			if(cmbBusquedaPeriodo.SelectedIndex > -1)
				mes = cmbBusquedaPeriodo.Text;					
			consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'FISICO MECANICO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.FISICO_MECANICO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.FISICO_MECANICO_PERIODO = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'FISICO MECANICO' AND FECHA_REGISTRO = '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01"+"') order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTipos.Checked == true){
				consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'FISICO MECANICO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.FISICO_MECANICO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.FISICO_MECANICO_PERIODO = '"+mes+"' order by vp.PLACA_ACTUAL";
			
			}		
			AdaptadorPrevision(consulta);
			
			
			parametro = Convert.ToInt16(connU.obtenerParametro1("POLIZA"));
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "1")
				mes = "ENERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "2")
				mes = "FEBRERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "3")
				mes = "MARZO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "4")
				mes = "ABRIL";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "5")
				mes = "MAYO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "6")
				mes = "JUNIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "7")
				mes = "JULIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "8")
				mes = "AGOSTO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "9")
				mes = "SEPTIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "10")
				mes = "OCTUBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "11")
				mes = "NOVIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "12")
				mes = "DICIEMBRE";
			
			if(cmbBusquedaPeriodo.SelectedIndex > -1)
				mes = cmbBusquedaPeriodo.Text;						
			consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'POLIZA' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where (vp.POLIZA_PERIODO1 = '"+mes+"' OR vp.POLIZA_PERIODO2 = '"+mes+"')and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'POLIZA' AND FECHA_REGISTRO = '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01"+"') order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTipos.Checked == true){
				consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'POLIZA' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where (vp.POLIZA_PERIODO1 = '"+mes+"' OR vp.POLIZA_PERIODO2 = '"+mes+"') order by vp.PLACA_ACTUAL";
			}		
			AdaptadorPrevision(consulta);
			
			
			parametro = Convert.ToInt16(connU.obtenerParametro1("CASETA1"));
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "1")
				mes = "ENERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "2")
				mes = "FEBRERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "3")
				mes = "MARZO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "4")
				mes = "ABRIL";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "5")
				mes = "MAYO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "6")
				mes = "JUNIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "7")
				mes = "JULIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "8")
				mes = "AGOSTO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "9")
				mes = "SEPTIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "10")
				mes = "OCTUBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "11")
				mes = "NOVIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "12")
				mes = "DICIEMBRE";	
			
			if(cmbBusquedaPeriodo.SelectedIndex > -1)
				mes = cmbBusquedaPeriodo.Text;					
			consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA1' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA1,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA1 = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'CASETA1' AND FECHA_REGISTRO = '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01"+"') order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTipos.Checked == true){
				consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA1' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA1,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA1 = '"+mes+"' order by vp.PLACA_ACTUAL";			
			}			
			AdaptadorPrevision(consulta);

			
			parametro = Convert.ToInt16(connU.obtenerParametro1("CASETA2"));
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "1")
				mes = "ENERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "2")
				mes = "FEBRERO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "3")
				mes = "MARZO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "4")
				mes = "ABRIL";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "5")
				mes = "MAYO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "6")
				mes = "JUNIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "7")
				mes = "JULIO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "8")
				mes = "AGOSTO";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "9")
				mes = "SEPTIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "10")
				mes = "OCTUBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "11")
				mes = "NOVIEMBRE";
			if(DateTime.Now.AddMonths(parametro).Month.ToString() == "12")
				mes = "DICIEMBRE";	
			
			if(cmbBusquedaPeriodo.SelectedIndex > -1)
				mes = cmbBusquedaPeriodo.Text;			
			
			consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA2' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA2,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA2 = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'CASETA2' AND FECHA_REGISTRO = '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01"+"') order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTipos.Checked == true){
				consulta = @"select v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA2' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA2,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA2 = '"+mes+"' order by vp.PLACA_ACTUAL";
			
			}		
			AdaptadorPrevision(consulta);		
			validaColoresP();
    }
	#endregion
    
    #region VALIDACIÓN COLORES
    private void validaColoresP(){
    	for(int x=0; x<dataGridViewPrevision.Rows.Count; x++){
    				
    		if(dataGridViewPrevision[0,x].Value.ToString() == "REFRENDO"){
    			for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.LightPink;
    		}		
    		if(dataGridViewPrevision[0,x].Value.ToString() == "PERMISO"){
    			for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.MediumPurple;
    		}		
    		if(dataGridViewPrevision[0,x].Value.ToString() == "VERIFICACION"){
    			if(dataGridViewPrevision[3,x].Value.ToString() == "E"){
    				for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.LightGoldenrodYellow;	
    			}else{
    				for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.LightGreen;
    			}
    		}
    		if(dataGridViewPrevision[0,x].Value.ToString() == "FISICO MECANICO"){
    			for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.LightBlue;
    		}
			if(dataGridViewPrevision[0,x].Value.ToString() == "POLIZA"){
    			if(dataGridViewPrevision[3,x].Value.ToString() == "E"){
    				for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.Orange;	
    			}else{
    				for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.Orange;
    			}
    		}
			if(dataGridViewPrevision[0,x].Value.ToString() == "CASETA1"){
    			for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.Gold;
    		}
			if(dataGridViewPrevision[0,x].Value.ToString() == "CASETA2"){
    			for(int y=0; y<dataGridViewPrevision.Columns.Count; y++)
    				dataGridViewPrevision[y,x].Style.BackColor = Color.Gold;
    	   	
   			}
    
   	}
}
    #endregion
    
    #region EVENTOS
    void CmbBusquedaPeriodoSelectedIndexChanged(object sender, EventArgs e)
	{
		PrevisionPeriodos();
	}
	
	void CbMostrarTiposCheckedChanged(object sender, EventArgs e)
	{
		PrevisionPeriodos();
	}
	
	void PictureBox2Click(object sender, EventArgs e)
	{
		cbMostrarTipos.Checked = false;
		cmbBusquedaPeriodo.SelectedIndex = -1;
	}		
    #endregion    
    
    #region ESCANER
    
    
    #endregion
    
	///////////////////////////////////////VALIDACIÓN//////////////////////////////////////////////////////////	
	
	#region ADAPTADOR
	public void AdaptadorValidacion(string consulta)
	{
		conn.getAbrirConexion(consulta);
		conn.leer=conn.comando.ExecuteReader();
		while(conn.leer.Read()){
			dataGridViewValidacion.Rows.Add(conn.leer["id"].ToString(),
										   conn.leer["tipoGestion"].ToString(),
			                               conn.leer["Numero"].ToString(),
			                               conn.leer["PlacaActual"],
			                               conn.leer["PLACA_ACTUAL"],
			                               "",
			                               "",
			                               conn.leer["Propietario"],
			                               conn.leer["Motor_Num_Serie"],
			                               conn.leer["Numero_Serie"]);
		}
		conn.conexion.Close();
		dataGridViewValidacion.ClearSelection();
	}
	
	public void validacionPeriodos(){		
		dataGridViewValidacion.Rows.Clear();
		string mes = "";
		string consulta = "";
		if(DateTime.Now.Month.ToString() == "1")
			mes = "ENERO";
		if(DateTime.Now.Month.ToString() == "2")
			mes = "FEBRERO";
		if(DateTime.Now.Month.ToString() == "3")
			mes = "MARZO";
		if(DateTime.Now.Month.ToString() == "4")
			mes = "ABRIL";
		if(DateTime.Now.Month.ToString() == "5")
			mes = "MAYO";
		if(DateTime.Now.Month.ToString() == "6")
			mes = "JUNIO";
		if(DateTime.Now.Month.ToString() == "7")
			mes = "JULIO";
		if(DateTime.Now.Month.ToString() == "8")
			mes = "AGOSTO";
		if(DateTime.Now.Month.ToString() == "9")
			mes = "SEPTIEMBRE";
		if(DateTime.Now.Month.ToString() == "10")
			mes = "OCTUBRE";
		if(DateTime.Now.Month.ToString() == "11")
			mes = "NOVIEMBRE";
		if(DateTime.Now.Month.ToString() == "12")
			mes = "DICIEMBRE";
		if(cmbTipo.SelectedIndex < 0 || cmbTipo.SelectedIndex == 0){		
			consulta = @"select vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'REFRENDO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.REFRENDO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.REFRENDO_PERIODO = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'REFRENDO' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01' AND FECHA_REGISTRO < '"
				+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTodo.Checked == true){
				consulta = @"select vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'REFRENDO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.REFRENDO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.REFRENDO_PERIODO != '0' and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			}
			
			AdaptadorValidacion(consulta);
		}
		
		
		if(cmbTipo.SelectedIndex < 0 || cmbTipo.SelectedIndex == 1){
			consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario,  'PERMISO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
			from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.PERMISO_PERIODO = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'PERMISO' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01' AND FECHA_REGISTRO < '"
			+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
		
			if(cbMostrarTodo.Checked == true){
				consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario,  'PERMISO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.PERMISO_PERIODO != '0' and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
		
			}		
			AdaptadorValidacion(consulta);
		}
		
		if(cmbTipo.SelectedIndex < 0 || cmbTipo.SelectedIndex == 2 || cmbTipo.SelectedIndex == 3){
			consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'VERIFICACION' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where (vp.VERIFICACION_PERIODO1 = '"+mes+"' OR vp.VERIFICACION_PERIODO2 = '"+mes+"')and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'VERIFICACION' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01' AND FECHA_REGISTRO < '"
				+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTodo.Checked == true){
				consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'VERIFICACION' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where (vp.VERIFICACION_PERIODO1 != '0' OR vp.VERIFICACION_PERIODO2 != '0') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			
			}		
			AdaptadorValidacion(consulta);
		}
		
		if(cmbTipo.SelectedIndex < 0 || cmbTipo.SelectedIndex == 4){
			consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'FISICO MECANICO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.FISICO_MECANICO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
					from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.FISICO_MECANICO_PERIODO = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'FISICO MECANICO' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01' AND FECHA_REGISTRO < '"
				+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
				
				if(cbMostrarTodo.Checked == true){
					consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'FISICO MECANICO' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.FISICO_MECANICO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
					from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.FISICO_MECANICO_PERIODO != '0' and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
					
				}		
				AdaptadorValidacion(consulta);
		}
		
		if(cmbTipo.SelectedIndex < 0 || cmbTipo.SelectedIndex == 5){
			consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'POLIZA' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where (vp.POLIZA_PERIODO1 = '"+mes+"' OR vp.POLIZA_PERIODO2 = '"+mes+"')and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'POLIZA' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01' AND FECHA_REGISTRO < '"
				+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTodo.Checked == true){
				consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'POLIZA' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.PERMISO_PERIODO,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.POLIZA_PERIODO1 != '0' and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL"; 
			}		
			AdaptadorValidacion(consulta);
		}
		
		if(cmbTipo.SelectedIndex < 0 || cmbTipo.SelectedIndex == 6){
			consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA1' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA1,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA1 = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'CASETA1' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01' AND FECHA_REGISTRO < '"
				+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTodo.Checked == true){
				consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA1' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA1,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA1 != '0' and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			}		
			AdaptadorValidacion(consulta);
		}

		if(cmbTipo.SelectedIndex < 0 || cmbTipo.SelectedIndex == 7){					
			consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA2' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA2,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA2 = '"+mes+"' and vp.id not in (select ID_VEHICULOS_PERIODOS from HISTORIAL_PERIODOS where TIPO_GESTION = 'CASETA2' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-01' AND FECHA_REGISTRO < '"
				+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ') and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
			
			if(cbMostrarTodo.Checked == true){
				consulta = @"select  vp.id, v.Numero_Serie, v.Motor_Num_Serie, v.Propietario, 'CASETA2' as tipoGestion, v.Numero, vp.PLACA_ACTUAL, vp.CASETA2,  CASE WHEN vp.PLACA_ACTUAL = 'E' THEN v.Placa_Estatal ELSE v.Placa_Federal END AS PlacaActual  
				from VEHICULOS_PERIODOS vp  join VEHICULO v on vp.ID_VEHICULO = v.ID where vp.CASETA2 != '0' and (v.Placa_Estatal like '%"+txtPlaca.Text+"%' or v.Placa_Federal like '%"+txtPlaca.Text+"%') and v.numero like '%"+txtUnidad.Text+"%' order by vp.PLACA_ACTUAL";
				
			}		
			AdaptadorValidacion(consulta);
		}
		validaColoresV();
	}
    	
    private void validaColoresV(){
    	for(int x=0; x<dataGridViewValidacion.Rows.Count; x++){  				
    		if(dataGridViewValidacion[1,x].Value.ToString() == "REFRENDO"){
    			for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.LightPink;
    		}		
    		if(dataGridViewValidacion[1,x].Value.ToString() == "PERMISO"){
    			for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.MediumPurple;
    		}		
    		if(dataGridViewValidacion[1,x].Value.ToString() == "VERIFICACION"){
    			if(dataGridViewValidacion[4,x].Value.ToString() == "E"){
    				for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.LightGoldenrodYellow;	
    			}else{
    				for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.LightGreen;
    			}
    		}
    		if(dataGridViewValidacion[1,x].Value.ToString() == "FISICO MECANICO"){
    			for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.LightBlue;
    		}
			if(dataGridViewValidacion[1,x].Value.ToString() == "POLIZA"){
    			if(dataGridViewValidacion[4,x].Value.ToString() == "E"){
    				for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.Orange;	
    			}else{
    				for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.Orange;
    			}
    		}
			if(dataGridViewValidacion[1,x].Value.ToString() == "CASETA1"){
    			for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.Gold;
    		}
			if(dataGridViewValidacion[1,x].Value.ToString() == "CASETA2"){
    			for(int y=0; y<dataGridViewValidacion.Columns.Count; y++)
    				dataGridViewValidacion[y,x].Style.BackColor = Color.Gold;
	   		} 
			dataGridViewValidacion[5,x].Style.BackColor = Color.LightYellow;	
			dataGridViewValidacion[6,x].Style.BackColor = Color.LightYellow;
			
			if(cbMostrarTodo.Checked == true){
				string consul = "";
				string mes = "";
				for(int z=1; z<=12; z++){					
					if(z<10)
						mes = "0"+z;
					else
						mes = z.ToString();
					consul = "select FECHA_VALIDACION, DETALLE from HISTORIAL_PERIODOS where TIPO_GESTION = '"+dataGridViewValidacion[1,x].Value+"' AND FECHA_REGISTRO >= '"+DateTime.Now.Year+"-"+mes+
						"-01' AND FECHA_REGISTRO <  '"+DateTime.Now.Year+"-"+DateTime.Now.AddMonths(1).Month+"-01 ' and ID_VEHICULOS_PERIODOS = "+dataGridViewValidacion[0,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dataGridViewValidacion[5,x].Value=conn.leer["FECHA_VALIDACION"].ToString().Substring(0,10);
						dataGridViewValidacion[6,x].Value=conn.leer["DETALLE"].ToString();
						for(int y=2; y<dataGridViewValidacion.Columns.Count; y++)
	    					dataGridViewValidacion[y,x].Style.BackColor = Color.White;
						
						dataGridViewValidacion[5,x].Style.BackColor = Color.LightGreen;
						dataGridViewValidacion[6,x].Style.BackColor = Color.LightGreen;
					}
					conn.conexion.Close();
				}
				
			}
			
	   	}
	}
	#endregion	
	
	#region VARIABLES
	//DateTimePicker dtp = null;
	#endregion
		
	#region FILTROS
	void TxtPlacaTextChanged(object sender, EventArgs e)
		{
			validacionPeriodos();
		}
		
		void TxtUnidadTextChanged(object sender, EventArgs e)
		{
			validacionPeriodos();
		}
		
		void CmbTipoSelectedIndexChanged(object sender, EventArgs e)
		{
			validacionPeriodos();
		}
		
		void CbMostrarTodoCheckedChanged(object sender, EventArgs e)
		{
			validacionPeriodos();
		}
		
		void CmbPeriodoSelectedIndexChanged(object sender, EventArgs e)
		{
			validacionPeriodos();
		}
	#endregion	
	
	#region REPORTE EXCEL
		void BtnExcelRefrendoClick(object sender, EventArgs e)
		{
			if(dataGridViewPrevision.Rows.Count>0)
				generaExcelReporteRefrendo();
		}
		
		private void generaExcelReporteRefrendo()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			int i = 1;
			
			ExcelApp.Cells[i,  1] 	= "UNIDAD";
			ExcelApp.Cells[i,  2] 	= "PLACA";
			ExcelApp.Cells[i,  3] 	= "PROPIETARIO";
			ExcelApp.Cells[i,  4] 	= "N. MOTOR";
			ExcelApp.Cells[i,  5] 	= "N SERIE";
			for(int y=0; y<dataGridViewPrevision.Rows.Count; y++){
				if(dataGridViewPrevision[0,y].Value.ToString() == "REFRENDO"){
					i++;
					ExcelApp.Cells[i,  1]	= dataGridViewPrevision[1,y].Value.ToString();
					ExcelApp.Cells[i,  2]	= dataGridViewPrevision[2,y].Value.ToString();
					ExcelApp.Cells[i,  3]	= dataGridViewPrevision[4,y].Value.ToString();
					ExcelApp.Cells[i,  4]	= dataGridViewPrevision[5,y].Value.ToString();
					ExcelApp.Cells[i,  5]	= dataGridViewPrevision[6,y].Value.ToString();
				}
			}
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "REPORTE REFRENDOS"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Archivo creado correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		#endregion

	#region AGREGAR PERIODOS
	void DataGridViewPeriodosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{			
			if(e.RowIndex != -1 && (e.ColumnIndex == 2 || e.ColumnIndex == 3) &&
			   dataGridViewPeriodos[e.ColumnIndex,e.RowIndex].Value.ToString().Length > 2 &&
			   dataGridViewPeriodos[e.ColumnIndex,e.RowIndex].Value.ToString() != "SOBREPUESTA" &&
			   dataGridViewPeriodos[e.ColumnIndex,e.RowIndex].Value.ToString() != "NOTIENE" &&
			   dataGridViewPeriodos[e.ColumnIndex,e.RowIndex].Value.ToString() != "NO TIENE"){
								 
				string P1 = "";
				string P2 = "";	
				string numero = "";
				string placa = dataGridViewPeriodos[e.ColumnIndex,e.RowIndex].Value.ToString();
				string tipoU = connU.obtenerTipoU(dataGridViewPeriodos[1, e.RowIndex].Value.ToString());
				if(tipoU == "Camión"){
					if(e.ColumnIndex == 2)
						numero = placa.Substring(placa.Length-1, 1);
					if(e.ColumnIndex == 3)
						numero = placa.Substring(2, 1);
					if(numero == "1" || numero == "2"){
						P1 = "ENERO";
						P2 = "JULIO";
					}
					if(numero == "3" || numero == "4"){						
						P1 = "FEBRERO";
						P2 = "AGOSTO";
					}
					if(numero == "5" || numero == "6"){
						P1 = "MARZO";
						P2 = "SEPTIEMBRE";						
					}
					if(numero == "7" || numero == "8"){
						P1 = "ABRIL";
						P2 = "OCTUBRE";
					}
					if(numero == "9" || numero == "0"){
						P1 = "MAYO";
						P2 = "NOVIEMBRE";
					}
				}else{
						numero = placa.Substring(placa.Length-1, 1);
						if(numero == "1")
							P1 = "ENERO";
						if(numero == "2")
							P1 = "FEBRERO";
						if(numero == "3")
							P1 = "MARZO";
						if(numero == "4")
							P1 = "ABRIL";
						if(numero == "5")
							P1 = "MAYO";
						if(numero == "6")
							P1 = "JULIO";
						if(numero == "7")
							P1 = "AGOSTO";
						if(numero == "8")
							P1 = "SEPTIEMBRE";
						if(numero == "9")
							P1 = "OCTUBRE";
						if(numero == "10")
							P1 = "NOVIEMBRE";
						
							P2 = "N/A";				
				}
				
				if(dataGridViewPeriodos.SelectedRows.Count < 2){
					if(dataGridViewPeriodos[4,e.RowIndex].Value.ToString() != "SIN REGISTRO"){
						if(e.ColumnIndex == 2){
							if(connU.modificaVerificacion(P1, P2, dataGridViewPeriodos[0, e.RowIndex].Value.ToString(), "E"))
								MessageBox.Show("Placa Estatal seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							else
								MessageBox.Show("Error al  modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
						}
						if(e.ColumnIndex == 3){
							if(connU.modificaVerificacion(P1, P2, dataGridViewPeriodos[0, e.RowIndex].Value.ToString(), "F"))
								MessageBox.Show("Placa Federal seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							else
								MessageBox.Show("Error al  modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
						}			
					}else{
						if(e.ColumnIndex == 2){
							if(connU.InsertarPeriodos(dataGridViewPeriodos[0, e.RowIndex].Value.ToString(), "E", P1, P2,"0"))
								MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							else
								MessageBox.Show("ERROR AL INSERTAR EN VEHICULOS_PERIODOS:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
						}
						if(e.ColumnIndex == 3){
							if(connU.InsertarPeriodos(dataGridViewPeriodos[0, e.RowIndex].Value.ToString(), "F", P1, P2,"1"))
								MessageBox.Show("Se agrego Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							else
								MessageBox.Show("ERROR AL INSERTAR EN VEHICULOS_PERIODOS:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}					
					}
					Mostrar();
				}			 	
			}
		}
		
	void DataGridViewPeriodosEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	{
		dataGridViewPeriodos[5, dataGridViewPeriodos.CurrentRow.Index].ReadOnly = false;
		dataGridViewPeriodos[9, dataGridViewPeriodos.CurrentRow.Index].ReadOnly = false;
		
		if(dataGridViewPeriodos.CurrentCell.ColumnIndex == 5){
			if(dataGridViewPeriodos[5, dataGridViewPeriodos.CurrentRow.Index].Style.BackColor.Name != "LightGoldenrodYellow")
				dataGridViewPeriodos[5, dataGridViewPeriodos.CurrentRow.Index].ReadOnly = true;
			else					
				dataGridViewPeriodos[5, dataGridViewPeriodos.CurrentRow.Index].ReadOnly = false;				
		}
		
		if(dataGridViewPeriodos.CurrentCell.ColumnIndex == 9){				
			if(dataGridViewPeriodos[9, dataGridViewPeriodos.CurrentRow.Index].Style.BackColor.Name != "LightGoldenrodYellow")
				dataGridViewPeriodos[9, dataGridViewPeriodos.CurrentRow.Index].ReadOnly = true;
			else					
				dataGridViewPeriodos[9, dataGridViewPeriodos.CurrentRow.Index].ReadOnly = false;	
		}
	}
		
	void DataGridViewPeriodosCellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if(e.ColumnIndex > 4){
			if(e.ColumnIndex == 5 && dataGridViewPeriodos[5, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("REFRENDO_PERIODO", dataGridViewPeriodos[5, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){
					MessageBox.Show("El refrendo fue modificado correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{						
					MessageBox.Show("Error al modificar el refrendo", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
				
			if(e.ColumnIndex == 6 && dataGridViewPeriodos[6, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("PERMISO_PERIODO", dataGridViewPeriodos[6, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){
					MessageBox.Show("El permiso fue modificado correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{						
					MessageBox.Show("Error al modificar el permiso", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
				
			if(e.ColumnIndex == 9 && dataGridViewPeriodos[9, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("FISICO_MECANICO_PERIODO", dataGridViewPeriodos[9, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){
					MessageBox.Show("El fisico mecanico fue modificado correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{						
					MessageBox.Show("Error al modificar el fisico mecanico", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
						
							
			if(e.ColumnIndex == 10 && dataGridViewPeriodos[10, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("COBERTURA", dataGridViewPeriodos[10, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){		
					if(dataGridViewPeriodos[10, e.RowIndex].Value.ToString() == "CANCELADA"){
						dataGridViewPeriodos[13, e.RowIndex].Value = "CANCELADA";
						dataGridViewPeriodos[14, e.RowIndex].Value = "CANCELADA";						
						connU.modificaVerificacionCampo("POLIZA_PERIODO1", dataGridViewPeriodos[13, e.RowIndex].Value.ToString(), dataGridViewPeriodos[0, e.RowIndex].Value.ToString());
						connU.modificaVerificacionCampo("POLIZA_PERIODO2", dataGridViewPeriodos[14, e.RowIndex].Value.ToString(), dataGridViewPeriodos[0, e.RowIndex].Value.ToString());
					}
				MessageBox.Show("La cobertura de poliza fue modificada correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{					
					MessageBox.Show("Error al modificar la cobertura de la poliza", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			
			if(e.ColumnIndex == 11 && dataGridViewPeriodos[11, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("INICIO_POLIZA", dataGridViewPeriodos[11, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){					
					dataGridViewPeriodos[12, e.RowIndex].Value = (Convert.ToDateTime(dataGridViewPeriodos[11, e.RowIndex].Value).AddYears(1).ToString().Substring(0,10));
					dataGridViewPeriodos[13, e.RowIndex].Value = (Convert.ToDateTime(dataGridViewPeriodos[11, e.RowIndex].Value).AddDays(30).ToString().Substring(0,10));
					dataGridViewPeriodos[14, e.RowIndex].Value = (Convert.ToDateTime(dataGridViewPeriodos[11, e.RowIndex].Value).AddMonths(5).ToString().Substring(0,10));
										
					connU.modificaVerificacionCampo("VENCE_POLIZA", dataGridViewPeriodos[12, e.RowIndex].Value.ToString(), dataGridViewPeriodos[0, e.RowIndex].Value.ToString());
					connU.modificaVerificacionCampo("POLIZA_PERIODO1", dataGridViewPeriodos[13, e.RowIndex].Value.ToString(), dataGridViewPeriodos[0, e.RowIndex].Value.ToString());
					connU.modificaVerificacionCampo("POLIZA_PERIODO2", dataGridViewPeriodos[14, e.RowIndex].Value.ToString(), dataGridViewPeriodos[0, e.RowIndex].Value.ToString());
					
					MessageBox.Show("La vigencia de poliza fue modificada correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{					
					MessageBox.Show("Error al modificar la vigencia de la poliza", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}			
				
			if(e.ColumnIndex == 13 && dataGridViewPeriodos[13, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("POLIZA_PERIODO1", dataGridViewPeriodos[13, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){
					MessageBox.Show("La poliza fue modificada correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{						
					MessageBox.Show("Error al modificar la poliza", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
				
			if(e.ColumnIndex == 14 && dataGridViewPeriodos[14, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("POLIZA_PERIODO2", dataGridViewPeriodos[14, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){
					MessageBox.Show("La poliza fue modificada correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{						
					MessageBox.Show("Error al modificar la poliza", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			
			if(e.ColumnIndex == 15 && dataGridViewPeriodos[15, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("CASETA1", dataGridViewPeriodos[15, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){
					MessageBox.Show("La CASETA1 fue modificada correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{						
					MessageBox.Show("Error al modificar la CASETA1", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			
			if(e.ColumnIndex == 16 && dataGridViewPeriodos[16, e.RowIndex].Style.BackColor.Name.ToString() == "LightGoldenrodYellow"){
				if(connU.modificaVerificacionCampo("CASETA2", dataGridViewPeriodos[16, e.RowIndex].Value.ToString(), 
				                                   dataGridViewPeriodos[0, e.RowIndex].Value.ToString())){
					MessageBox.Show("La CASETA2 fue modificada correctamente", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}else{						
					MessageBox.Show("Error al modificar la CASETA2", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			validacionPeriodos();
		}
	}
	#endregion
	
	#region BOTON PARAMETROS
	void PbConfiguracionesClick(object sender, EventArgs e)
	{
		new FormParametrosGestoria(this).ShowDialog();
	}
	#endregion
				
	#region INSERTAR
	void DataGridViewValidacionCellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if(e.RowIndex > -1 && e.ColumnIndex == 10){
			if(dataGridViewValidacion[5,e.RowIndex].Style.BackColor.Name != "WhiteSmoke"){
				if(dataGridViewValidacion[5, e.RowIndex].Value.ToString().Length >= 10){			
					if(connU.insertarValidacion(dataGridViewValidacion[0,e.RowIndex].Value.ToString(),dataGridViewValidacion[5,e.RowIndex].Value.ToString(),
					                            dataGridViewValidacion[6,e.RowIndex].Value.ToString(), id_usuario.ToString() , dataGridViewValidacion[1,e.RowIndex].Value.ToString())){
						dataGridViewValidacion.Rows.RemoveAt(e.RowIndex);
						MessageBox.Show("SE CONFIRMO CORRECTAMENTE","LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}else{
				MessageBox.Show("SELECCIONA UN REGISTRO VALIDO","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}
	}
	
	void BtnGuardarValidacionClick(object sender, EventArgs e)
	{
		if(dataGridViewValidacion.Rows.Count > 0){
			if(dataGridViewValidacion.CurrentCell.ColumnIndex > 0 && dataGridViewValidacion.CurrentCell.ColumnIndex < 8)
				dataGridViewValidacion.CurrentCell = dataGridViewValidacion.Rows[dataGridViewValidacion.CurrentCell.RowIndex].Cells[dataGridViewValidacion.CurrentCell.ColumnIndex+1];
		}
		if(dataGridViewValidacion.Rows.Count > 0){
			for(int x=0; x<dataGridViewValidacion.Rows.Count; x++){
				if(dataGridViewValidacion[5,x].Style.BackColor.Name != "White" && dataGridViewValidacion[5,x].Value.ToString().Length >= 10){
					if(connU.insertarValidacion(dataGridViewValidacion[0,x].Value.ToString(),dataGridViewValidacion[5,x].Value.ToString(),
					                            dataGridViewValidacion[6,x].Value.ToString(), id_usuario.ToString() , dataGridViewValidacion[1,x].Value.ToString())){
						dataGridViewValidacion.Rows.RemoveAt(x);
						x--;
					}
				}
			}		
		}
	}
	#endregion
	
	#region DATETIMEPICKER DATAGRID
	  private void dtp_OnTextChange(object sender, EventArgs e)
    {
       // dataGridViewValidacion.CurrentCell.Value = dtp.Text.ToString();
    }
	  
	 void DataGridViewValidacionCellEnter(object sender, DataGridViewCellEventArgs e)
	{
	 	/*
		if (e.ColumnIndex == 5){
           dtp = new DateTimePicker();
           dataGridViewValidacion.Controls.Add(dtp);
           dtp.Format = DateTimePickerFormat.Short;
           System.Drawing.Rectangle Rectangle = dataGridViewValidacion.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
           dtp.Size = new Size(Rectangle.Width, Rectangle.Height);
           dtp.Location = new Point(Rectangle.X, Rectangle.Y);

          	dtp.TextChanged += new EventHandler(dtp_OnTextChange);
            dtp.Visible = true;
    	}
	 	*/
	}
	 
	 void DataGridViewValidacionCellLeave(object sender, DataGridViewCellEventArgs e)
	{
	//	if(dtp != null)
   			//dtp.Visible = false;
		
		if(e.ColumnIndex == 5 && e.ColumnIndex == 6)
			txtPlaca.Focus();
			
	}
	 
	 void PictureBox1Click(object sender, EventArgs e)
	{
 		cmbPeriodo.SelectedIndex = -1;
		cbMostrarTodo.Checked = false;
		cmbTipo.SelectedIndex = -1;
		txtPlaca.Text = "";
		txtUnidad.Text = "";
	}
	#endregion	
	
	#region SCANNER
	void BtnScanClick(object sender, EventArgs e)
	{
		generaScanner();
	}
	
	private void generaScanner(){
		String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
		string newPath = System.IO.Path.Combine(activeDir, "SCANNER");
	    System.IO.Directory.CreateDirectory(newPath);        
		try
		{		
			Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
			FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\SCANNER\scanner.pdf",
			                                 FileMode.OpenOrCreate, 
			                                 FileAccess.ReadWrite,
			                                 FileShare.ReadWrite);
			PdfWriter writer = PdfWriter.GetInstance(doc, file);
			doc.Open();
			FormatoPdf.FormatoGestoriaScanner(doc, writer);
	        doc.Close();
	        //Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\DesktopSCANNERNomina \scanner.pdf"));
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}		
	 }
	#endregion


	
	#region FILTROS
	public void filtrosSeguros(){
	 	string consulta = "select v.Numero, v.Propietario, vp.* from VEHICULOS_PERIODOS vp join VEHICULO v on v.ID = vp.ID_VEHICULO where v.estatus = '1'";
	 	AdaptadorSeguros(consulta);
	}
	#endregion
	
	#region ADAPTADOR
	public void AdaptadorSeguros(string consulta){
		dgSeguros.Rows.Clear();
		conn.getAbrirConexion(consulta);
		conn.leer = conn.comando.ExecuteReader();
		while(conn.leer.Read()){
			dgSeguros.Rows.Add(conn.leer["ID"].ToString(),
                              conn.leer["Numero"].ToString(),
                              conn.leer["Propietario"].ToString(),
                              conn.leer["COBERTURA"].ToString(),
                              conn.leer["INICIO_POLIZA"].ToString(),
                              conn.leer["VENCE_POLIZA"].ToString(),
                              conn.leer["POLIZA_PERIODO1"].ToString(),
                              conn.leer["POLIZA_PERIODO2"].ToString());	
		}
		conn.conexion.Close();
		CompletaDatosSeguros();
		dgSeguros.ClearSelection();	
	}
	
	public void CompletaDatosSeguros(){
		for(int X = 0; X < dgSeguros.Rows.Count; X++)
		{
			if(dgSeguros[4,X].Value.ToString()!="")
			{
			try
			{
				dgSeguros[6,X].Value = (Convert.ToDateTime(dgSeguros[4,X].Value).AddDays(-20).ToString().Substring(0,10));
			}
			catch(Exception){ }
			try
			{
				dgSeguros[7,X].Value = (Convert.ToDateTime(dgSeguros[4,X].Value).AddDays(-172).ToString().Substring(0,10));
			}catch(Exception){ }
			//dataGridViewPeriodos[15,X].Style.BackColor = Color.LightGoldenrodYellow;	
			}
		}
	}
	#endregion	
   }
}

