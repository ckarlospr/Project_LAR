using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	public partial class FormNominaFiscal : Form
	{		
		#region CONSTRUCTOR
		public FormNominaFiscal(FormPrincipal principal, int id_u)
		{
			InitializeComponent();
			refPrincipal = principal;
			id_usuario = id_u.ToString();
		}
		#endregion
						
		#region INSTANCIAS
		private FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Cuenta.SQL_Cuenta conC = new Conexion_Servidor.Cuenta.SQL_Cuenta();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private	Interfaz.Nomina.FormNomina refNomina = new Transportes_LAR.Interfaz.Nomina.FormNomina();
		private Conexion_Servidor.Controles.SQL_Controles connCT = new Conexion_Servidor.Controles.SQL_Controles();
		#endregion
		
		#region VARIABLES
		string id_usuario = "0";
		#endregion
		
		#region INICIO -FIN
		void FormNominaFiscalLoad(object sender, EventArgs e)
		{
			cargaInicio();
		}
		
		void FormNominaFiscalFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.nominaF = false;
		}
		#endregion
		
		#region METODOS
		public void cargaInicio()
		{
		/////////////////////////////////////////////////////////////////////// DATOS OPERADOR ///////////////////////////////////////////////////////////////////////
			txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT ALIAS FROM OPERADOR WHERE tipo_empleado in ('OPERADOR', 'Externo') AND estatus = 1", "ALIAS");
           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;            
			operadorInicio();
			
		/////////////////////////////////////////////////////////////////////// NOMINA FISCAL ////////////////////////////////////////////////////////////////////////
			LlenadoDataEstatica();
			
		/////////////////////////////////////////////////////////////////////// NOMINA FISCAL ////////////////////////////////////////////////////////////////////////
			dtpIncio.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO()));
			dtpFin.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN()));
			txtAliasReporte.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT ALIAS FROM OPERADOR WHERE tipo_empleado in ('OPERADOR', 'Externo')", "ALIAS");
           	txtAliasReporte.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAliasReporte.AutoCompleteSource = AutoCompleteSource.CustomSource;     

		/////////////////////////////////////////////////////////////// NOMINA FISCAL ADMINISTRATIVOS/////////////////////////////////////////////////////////////////
			dtpInicioAdministrativos.Value = DateTime.Now.AddDays(1 - Convert.ToDouble(DateTime.Now.DayOfWeek));
			dtpFinAdministrativos.Value = DateTime.Now.AddDays(7 - Convert.ToDouble(DateTime.Now.DayOfWeek));
			
			txtAliasReporteAdministrativos.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT ALIAS FROM OPERADOR WHERE tipo_empleado not in ('OPERADOR', 'Externo')", "ALIAS");
           	txtAliasReporteAdministrativos.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAliasReporteAdministrativos.AutoCompleteSource = AutoCompleteSource.CustomSource;             
		}	
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		#endregion		
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////// DATOS //////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				
		#region EVENTOS
		void TxtBusquedaTextChanged(object sender, EventArgs e)
		{
			operadorInicio();
		}
		
		void DgOperadoresDatosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && dgOperadoresDatos.CurrentRow.Index > -1 && dgOperadoresDatos.SelectedRows.Count == 1 && (dgOperadoresDatos.CurrentCell.ColumnIndex != 14 && dgOperadoresDatos.CurrentCell.ColumnIndex != 15))
				new FormModificaOperador(this, dgOperadoresDatos[0, e.RowIndex].Value.ToString(), dgOperadoresDatos[13, e.RowIndex].Value.ToString(), dgOperadoresDatos[16, e.RowIndex].Value.ToString(), id_usuario).ShowDialog();
			
			if(dgOperadoresDatos.CurrentRow.Index > -1 && dgOperadoresDatos.CurrentCell.ColumnIndex == 14){
				if(dgOperadoresDatos[13, e.RowIndex].Value.ToString() == "0")
					new	FormCuentaBancaria(this, dgOperadoresDatos[0, e.RowIndex].Value.ToString(), id_usuario).ShowDialog();
				else					
					new	FormCuentaBancaria(this, dgOperadoresDatos[0, e.RowIndex].Value.ToString(), id_usuario, dgOperadoresDatos[13, e.RowIndex].Value.ToString()).ShowDialog();
			}
			
			if(dgOperadoresDatos.CurrentRow.Index > -1 && dgOperadoresDatos.CurrentCell.ColumnIndex == 15 && dgOperadoresDatos[15,e.RowIndex].Style.BackColor.Name == "Red"){
				new FormValidaCuenta(this, dgOperadoresDatos[13, e.RowIndex].Value.ToString(), dgOperadoresDatos[14, e.RowIndex].Value.ToString(), 
				                    dgOperadoresDatos[0, e.RowIndex].Value.ToString(), id_usuario).ShowDialog();
			}
		}
		
		void CbTipoAdministrativoCheckedChanged(object sender, EventArgs e)
		{
			if(cbTipoAdministrativo.Checked == true){
				txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT ALIAS FROM OPERADOR WHERE estatus = 1", "ALIAS");
	           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;    
			}else{
				txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT ALIAS FROM OPERADOR WHERE tipo_empleado in ('OPERADOR', 'Externo') AND estatus = 1", "ALIAS");
	           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;    
			}
			operadorInicio();
		}
		#endregion
				
		#region METODOS		
		public void operadorInicio(){
			
			String sentencia = @"select O.ID, O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.CURP, O.RFC, O.IMSS, O.NUM_INFONAVIT, O.CORREO, tipo_empleado, 
							O.Lugar_Nacimiento +', '+O.Estado_Nacimiento as lugar, O.Fecha_Nacimiento, S.ID_SUELDO, S.IMSS IMSS_S, S.INFONAVIT INFONAVIT_S, 
							S.ISR, S.prima_v, S.Retener, S.SUELDO_BASE, S.TELCEL, S.Compensacion, S.aguinaldo  from OPERADOR O JOIN SUELDO S ON S.ID_OPERADOR = O.ID  
							where (O.Alias!='Admvo') and O.Alias like '%"+txtBusqueda.Text+"%' and Estatus = '1' ";
			
			if(cbTipoAdministrativo.Checked == false)
				sentencia += " and tipo_empleado in ('OPERADOR', 'Externo') ";
			
			ColoresAlternadosRows(dgOperadoresDatos);
			dgOperadoresDatos.Rows.Clear();			
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgOperadoresDatos.Rows.Add(conn.leer["ID"].ToString(),
				                     conn.leer["Alias"].ToString(),
				                     conn.leer["Nombre"].ToString(),
				                     conn.leer["Apellido_Pat"].ToString()+" "+conn.leer["Apellido_Mat"].ToString(),
				                     conn.leer["CURP"].ToString(),
				                     conn.leer["RFC"].ToString(),
				                     conn.leer["IMSS"].ToString(),
				                     conn.leer["NUM_INFONAVIT"].ToString(),
				                     conn.leer["CORREO"].ToString(),
				                     conn.leer["Fecha_Nacimiento"].ToString().Substring(0,10),
				                     conn.leer["lugar"].ToString(),
				                     conn.leer["tipo_empleado"].ToString(),
				                     "N/A", //FECHA INGRESO
				                     "0", //ID_CUENTA 13
				                     "0", //NUMERO CUENTA
				                     "0", //VALIDACION CUENTA
				                     conn.leer["ID_SUELDO"].ToString(),
				                     conn.leer["SUELDO_BASE"].ToString(),
				                     conn.leer["ISR"].ToString(),
				                     conn.leer["IMSS_S"].ToString(),
				                     conn.leer["INFONAVIT_S"].ToString(),
				                     conn.leer["aguinaldo"].ToString(),
				                     conn.leer["Retener"].ToString(),
				                     conn.leer["Compensacion"].ToString(),
				                     conn.leer["prima_v"].ToString(),
				                     "N/A");//PATRON
				
				
			}
			conn.conexion.Close();
			datosCompleta();		
			dgOperadoresDatos.ClearSelection();		
		}
		
		private void datosCompleta(){			
			for(int x=0; x<dgOperadoresDatos.Rows.Count; x++){
				try{
				if(dgOperadoresDatos[11,x].Value.ToString() == "OPERADOR"){
					dgOperadoresDatos[12,x].Value = new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(dgOperadoresDatos[0,x].Value.ToString());
				}else{
					dgOperadoresDatos[12,x].Value = "N/A";
					dgOperadoresDatos[11,x].Style.BackColor = Color.LightGreen;
					dgOperadoresDatos[12,x].Value = new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(dgOperadoresDatos[0,x].Value.ToString());
				}
				dgOperadoresDatos[13,x].Value = conC.ReturnIdCuenta(dgOperadoresDatos[0,x].Value.ToString());
				dgOperadoresDatos[14,x].Value = conC.ReturnNumero(dgOperadoresDatos[0,x].Value.ToString());
				dgOperadoresDatos[15,x].Value = conC.ReturnValidaCuenta(dgOperadoresDatos[0,x].Value.ToString());
				dgOperadoresDatos[25,x].Value = Patron(dgOperadoresDatos[0,x].Value.ToString());					
									
					if(dgOperadoresDatos[15,x].Value.ToString() == "SIN VALIDAR" || dgOperadoresDatos[15,x].Value.ToString() == "" || dgOperadoresDatos[15,x].Value.ToString() == " ")
						dgOperadoresDatos[15,x].Style.BackColor = Color.Red;
					else
						dgOperadoresDatos[15,x].Style.BackColor = Color.LightGreen;
						
				}catch(Exception){
				}
				
				dgOperadoresDatos[16,x].Style.BackColor = Color.LightGray;
				dgOperadoresDatos[17,x].Style.BackColor = Color.LightGray;	
				dgOperadoresDatos[18,x].Style.BackColor = Color.LightGray;	
				dgOperadoresDatos[19,x].Style.BackColor = Color.LightGray;	
				dgOperadoresDatos[20,x].Style.BackColor = Color.LightGray;		
				dgOperadoresDatos[21,x].Style.BackColor = Color.LightGray;
				dgOperadoresDatos[22,x].Style.BackColor = Color.LightGray;
				dgOperadoresDatos[23,x].Style.BackColor = Color.LightGray;
				dgOperadoresDatos[24,x].Style.BackColor = Color.LightGray;				
			}
		}
		
		private string Patron(String id_operador){
			int booleano = 0;
			string NombrePatron = "";
			conn.getAbrirConexion(@"select TOP 1 NombrePatron, ns_patron from OperadorContrato WHERE TipoContrato!='Planta' and IdOperador ="+id_operador+"ORDER BY ID DESC");
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				NombrePatron = conn.leer["NombrePatron"].ToString();
				booleano = 1;
			}
			conn.conexion.Close();
			
			conn.getAbrirConexion("select * from OperadorContrato WHERE  TipoContrato = 'Planta'  and IdOperador ="+ id_operador);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				booleano = 0;
			conn.conexion.Close();		
			
			if(booleano!=1){
				conn.getAbrirConexion(@"select NombrePatron, ns_patron from OperadorContrato WHERE TipoContrato='Planta' and IdOperador ="+id_operador);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
					NombrePatron = conn.leer["NombrePatron"].ToString();
				conn.conexion.Close();
			}
			return NombrePatron;
		}		
		#endregion		
		
		////////////////////////////////////////////////////////// TABLA //////////////////////////////////////////////////////////
		
		#region METODOS
		private void LlenadoDataEstatica()
		{
			dataTarifas14.Rows.Clear();
			dataTarifas14.ClearSelection();			
			dataTarifas14.Rows.Add(0.01, 19.03, 0, 0.0192);
			dataTarifas14.Rows.Add(19.04, 161.52, 0.37, 0.0640);
			dataTarifas14.Rows.Add(161.53, 283.86, 9.48, 0.1088);
			dataTarifas14.Rows.Add(283.87, 329.97, 22.79, 0.16);
			dataTarifas14.Rows.Add(329.98, 395.06, 30.17, 0.1792);
			dataTarifas14.Rows.Add(395.07, 796.79, 41.84, 0.2136);
			dataTarifas14.Rows.Add(796.8, 1255.85, 127.65, 0.2352);
			dataTarifas14.Rows.Add(1255.86, 2397.62, 235.62, 0.3);
			dataTarifas14.Rows.Add(2397.63, 3196.82, 578.15, 0.32);
			dataTarifas14.Rows.Add(3196.83, 9590.46, 833.89, 0.34);
			dataTarifas14.Rows.Add(9590.47, 999999, 3007.73, 0.35);
			
			dataSubsidio14.Rows.Clear();
			dataSubsidio14.ClearSelection();
			dataSubsidio14.Rows.Add(0.01, 58.19, 13.39);
			dataSubsidio14.Rows.Add(58.20, 87.28, 13.38);
			dataSubsidio14.Rows.Add(87.29, 114.24, 13.38);
			dataSubsidio14.Rows.Add(114.39, 116.38, 12.92);
			dataSubsidio14.Rows.Add(116.39, 146.25, 12.58);
			dataSubsidio14.Rows.Add(146.26, 155.17, 11.65);
			dataSubsidio14.Rows.Add(155.18, 175.51, 10.69);
			dataSubsidio14.Rows.Add(175.52, 204.76, 9.69);
			dataSubsidio14.Rows.Add(204.77, 234.01, 8.34);
			dataSubsidio14.Rows.Add(234.02, 242.84, 7.16);
			dataSubsidio14.Rows.Add(242.85, 999999, 0);
			
			dataTotalesISPT14.Rows.Clear();
			dataTotalesISPT14.ClearSelection();
			dataTotalesISPT14.Rows.Add("Base Gravable", 0);
			dataTotalesISPT14.Rows.Add("Limite Inferior", 0);
			dataTotalesISPT14.Rows.Add("Exedente", 0);
			dataTotalesISPT14.Rows.Add("% ISR conforme a al Art. 113", 0);
			dataTotalesISPT14.Rows.Add("Impuesto Marginal", 0);
			dataTotalesISPT14.Rows.Add("Cuota Fija", 0);
			dataTotalesISPT14.Rows.Add("Impuesto según Art 113", 0);
			dataTotalesISPT14.Rows.Add("SPE de la Tabla", 0);
			dataTotalesISPT14.Rows.Add("ISR a Cargo", 0);
			dataTotalesISPT14.Rows.Add("Subsidio a Favor", 0);		

			
			///////////////////////////////////////////////// REPORTE ADMINISTRATIVOS /////////////////////////////////////////////////
			
			dataTarifas7.Rows.Clear();
			dataTarifas7.ClearSelection();
			dataTarifas7.Rows.Add(0.01, 133.21, 0, 0.0192);
			dataTarifas7.Rows.Add(133.22, 1130.64, 2.59, 0.064);
			dataTarifas7.Rows.Add(1130.65, 1987.02, 66.36, 0.1088);
			dataTarifas7.Rows.Add(1987.03, 2309.79, 159.53, 0.16);
			dataTarifas7.Rows.Add(2309.80, 2765.42, 211.19, 0.1792);
			dataTarifas7.Rows.Add(2765.43, 5577.53, 292.88, 0.2136);
			dataTarifas7.Rows.Add(5577.54, 8790.95, 893.55, 0.2352);
			dataTarifas7.Rows.Add(8790.96, 16783.34, 1649.34, 0.3);
			dataTarifas7.Rows.Add(16783.35, 22377.74, 4047.05, 0.32);
			dataTarifas7.Rows.Add(22377.75, 67133.22, 5837.23, 0.34);
			dataTarifas7.Rows.Add(67133.23, 999999, 21054.11, 0.35);
			
			dataGobierno7.Rows.Clear();
			dataGobierno7.ClearSelection();
			dataGobierno7.Rows.Add(0.01, 407.33, 93.73);
			dataGobierno7.Rows.Add(407.34, 610.96, 93.66);
			dataGobierno7.Rows.Add(610.97, 799.68, 93.66);
			dataGobierno7.Rows.Add(799.69, 814.66, 90.44);
			dataGobierno7.Rows.Add(814.67, 1023.75, 88.06);
			dataGobierno7.Rows.Add(1023.76, 1086.19, 81.55);
			dataGobierno7.Rows.Add(1086.20, 1228.57, 74.83);
			dataGobierno7.Rows.Add(1228.58, 1433.32, 67.83);
			dataGobierno7.Rows.Add(1433.33, 1638.07, 58.38);
			dataGobierno7.Rows.Add(1638.08, 1699.88, 50.12);
			dataGobierno7.Rows.Add(1699.89, 999999, 0);
			
			dataTotalesISPT7.Rows.Clear();
			dataTotalesISPT7.ClearSelection();
			dataTotalesISPT7.Rows.Add("Base Gravable", 0);
			dataTotalesISPT7.Rows.Add("Limite Inferior", 0);
			dataTotalesISPT7.Rows.Add("Exedente", 0);
			dataTotalesISPT7.Rows.Add("% ISR conforme a al Art. 113", 0);
			dataTotalesISPT7.Rows.Add("Impuesto Marginal", 0);
			dataTotalesISPT7.Rows.Add("Cuota Fija", 0);
			dataTotalesISPT7.Rows.Add("Impuesto según Art 113", 0);
			dataTotalesISPT7.Rows.Add("SPE de la Tabla", 0);
			dataTotalesISPT7.Rows.Add("Subsidio a Favor", 0);
			dataTotalesISPT7.Rows.Add("ISR a Cargo", 0);			
		}
		#endregion		
		
		#region BOTONES		
		void BtnSueldoClick(object sender, EventArgs e)
		{
			new Nomina.Nomina_Fiscal.FormSueldoReal(id_usuario).ShowDialog();
		}
		#endregion
			
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////// REPORTE OPERADORES ///////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
		
		#region EVENTOS
		void TxtAliasReporteKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Return"){
				dgReporte.ClearSelection();
				for(int x=0; x<dgReporte.Rows.Count; x++){
					if(txtAliasReporte.Text == dgReporte[30,x].Value.ToString()){
						dgReporte.Rows[x].Selected = true;
						dgReporte.FirstDisplayedCell = dgReporte.Rows[x].Cells[30];
					}
				}
			}
			else if(txtAliasReporte.Text.Length == 3){
				dgReporte.ClearSelection();
				for(int x=0; x<dgReporte.Rows.Count; x++){
					if(txtAliasReporte.Text == dgReporte[30,x].Value.ToString()){
						dgReporte.Rows[x].Selected = true;
						dgReporte.FirstDisplayedCell = dgReporte.Rows[x].Cells[30];
					}
				}
			}
		}
		
		void DgReporteCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
				calculoSUBEmpleado(e.RowIndex);
		}
		
		void LblReflescarClick(object sender, EventArgs e)
		{			
			AdaptadorReporte();
		}
		
		void LblZoomClick(object sender, EventArgs e)
		{
			if(pnTablas.Height == 350)
				pnTablas.Height = 30;
			else
				pnTablas.Height = 350;
		}
		
		void CbPeriodoCheckedChanged(object sender, EventArgs e)
		{
			if(cbPeriodo.Checked == true){	
				dtpIncio.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO()));
				dtpFin.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN()));
				dtpIncio.Enabled = false;
				dtpFin.Enabled = false;
			}else{
				dtpIncio.Enabled = true;
				dtpFin.Enabled = true;
			}
		}
		
		void DtpIncioValueChanged(object sender, EventArgs e)
		{
			dtpFin.MinDate = dtpIncio.Value;
			dtpFin.Value = dtpIncio.Value;
		}
		#endregion
		
		#region METODOS		
		public void AdaptadorReporte(){
			int contador = 0;
			List<string> ID_contrato = new List<string>();		
			// Que firmen contrato en periodo nominar
			//modificacion oscar para que aparezcan zuñiga (2101), sanchez ya se regularizo el contrato
			String sentencia = @"select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, "+ 
"o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, "+ 
"oc.NombrePatron, oc.TipoContrato "+ 
"from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado in ('Externo', 'OPERADOR')) "+ 
"and FechaInicioContrato between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' "+
/*"union select o.ID, OC.ID AS CONTRATO, " +
				"o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, " +
				"oc.fecha_vencimiento, oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc " +
				"on o.ID = oc.IdOperador where oc.ID = 2101 " +
				*/"union select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, " +
				"o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, oc.NombrePatron, " +
				"oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where oc.ID = 2133 order by nombre, FechaInicioContrato";
			//Quitar a Valdivia (2133) para el 17 de abril
			
			/*String sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado in ('Externo', 'OPERADOR')) and  
								FechaInicioContrato between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")+
								"' order by nombre, FechaInicioContrato";*/
			
			ColoresAlternadosRows(dgReporte);
			dgReporte.Rows.Clear();			
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				/*
				if(conn.leer["nombre"].ToString().Contains("FLORES"))
					MessageBox.Show("FLORES"+"\n"+sentencia+"\n"+contador+"\n"+conn.leer["nombre"].ToString());*/
				dgReporte.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10),
				                   conn.leer["TipoContrato"].ToString(),              
				                   "", //Sueldo base
				                   "",//DIAS              
				                   "",//SUELDO        
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				ID_contrato.Add(conn.leer["CONTRATO"].ToString());
				contador++;
			}
			conn.conexion.Close();
			
			String id_c = "";			
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// Que se termine el contrato en periodo nominar
			sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado in ('Externo', 'OPERADOR')) and  
								fecha_vencimiento between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")	
								+"' and oc.id not in("+id_c+") order by nombre, FechaInicioContrato";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporte.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),//(Convert.ToDateTime((conn.leer["fecha_vencimiento"].ToString()))).ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10), //(Convert.ToDateTime(conn.leer["fecha_vencimiento"].ToString()).AddDays(28)).ToString().Substring(0,10),//"yyyy-MM-dd"
				                   conn.leer["TipoContrato"].ToString(),     
				                   "", //Sueldo base
				                   "",//DIAS         
				                   "",//SUELDO             
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO				                 
				ID_contrato.Add(conn.leer["CONTRATO"].ToString());
				contador++;
			}
			conn.conexion.Close();
			
			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
				
			if(id_c == "")
			   id_c = "0";
			// Que inicio el contrato 13 dias antes del periodo nominar
			sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado in ('Externo', 'OPERADOR')) and  
								FechaInicioContrato between '"+dtpIncio.Value.AddDays(-14).ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")
								+"' and oc.id not in("+id_c+") order by nombre, FechaInicioContrato";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporte.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),//(Convert.ToDateTime((conn.leer["fecha_vencimiento"].ToString()))).ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10), //(Convert.ToDateTime(conn.leer["fecha_vencimiento"].ToString()).AddDays(28)).ToString().Substring(0,10),//"yyyy-MM-dd"
				                   conn.leer["TipoContrato"].ToString(),     
				                   "", //Sueldo base
				                   "",//DIAS            
				                   "",//SUELDO          
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO				                 
				ID_contrato.Add(conn.leer["CONTRATO"].ToString());
				contador++;
			}
			conn.conexion.Close();
			
			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// Que firmen contrato de planta antes del periodo nominal y esten activos
			sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado in ('Externo', 'OPERADOR')) and  
								oc.TipoContrato = 'Planta' and o.Estatus = '1' and FechaInicioContrato < '"+dtpIncio.Value.ToString("yyyy-MM-dd")+
								"' and oc.id not in("+id_c+") order by nombre, FechaInicioContrato";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporte.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),//(Convert.ToDateTime((conn.leer["fecha_vencimiento"].ToString()))).ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10), //(Convert.ToDateTime(conn.leer["fecha_vencimiento"].ToString()).AddDays(28)).ToString().Substring(0,10),//"yyyy-MM-dd"
				                   conn.leer["TipoContrato"].ToString(),     
				                   "", //Sueldo base
				                   "",//DIAS              
				                   "",//SUELDO              
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				contador++;
			}
			conn.conexion.Close();

			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// Operadores temporales que dan de baja en periodo nominal
			sentencia = @"select oa.Fecha, o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, 
						oc.fecha_vencimiento, oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador join OperadorAltaBaja oa on 
						oa.IdOperador = o.ID where (o.tipo_empleado in ('Externo', 'OPERADOR')) and oc.TipoContrato != 'Planta' and oa.Registro = 'INACTIVO' and oa.Fecha 
						between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' and FechaInicioContrato between '"+
						dtpIncio.Value.AddDays(-28).ToString("yyyy-MM-dd")+"' and '"+dtpIncio.Value.AddDays(-1).ToString("yyyy-MM-dd")+"' and oc.id not in("+id_c+") order by nombre, FechaInicioContrato";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporte.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),
				                   conn.leer["Fecha"].ToString().Substring(0,10),
				                   conn.leer["TipoContrato"].ToString(),
				                   "", //Sueldo base
				                   "",//DIAS
				                   "",//SUELDO
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS
				                   "", //PREMIO P
				                   "",//DESPENSA  
				                   "",// prestamo
				                   "",//d prestamo
				                   "",//d imss
				                   "",//d infonavit
				                   "",//d ISR
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				contador++;
			}
			conn.conexion.Close();			
			
			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// operadores de planta que se den de baja dentro del periodo nominal 
			sentencia = @"select oa.Fecha, o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, 
						oc.fecha_vencimiento, oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador join OperadorAltaBaja oa on 
						oa.IdOperador = o.ID where (o.tipo_empleado in ('Externo', 'OPERADOR')) and oc.TipoContrato = 'Planta' and oa.Registro = 'INACTIVO' and oa.Fecha 
						between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' and oc.id not in("+id_c+") order by nombre, FechaInicioContrato";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporte.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),
				                   conn.leer["Fecha"].ToString().Substring(0,10),
				                   conn.leer["TipoContrato"].ToString(),
				                   "", //Sueldo base
				                   "",//DIAS
				                   "",//SUELDO
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS
				                   "", //PREMIO P
				                   "",//DESPENSA  
				                   "",// prestamo
				                   "",//d prestamo
				                   "",//d imss
				                   "",//d infonavit
				                   "",//d ISR
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				contador++;
			}
			conn.conexion.Close();
			
			DatosCompletaReporte();		
			dgReporte.ClearSelection();
		}		
		
		private void DatosCompletaReporte(){			
			List<string> id_cancelados = new List<string>();
			
			string consulta = "";
			TimeSpan ti = Convert.ToDateTime(dtpFin.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy")) ;
			int diasT = ti.Days + 1;	
					
			refNomina.AdaptadorCalculo();
			
			for(int x=0; x<dgReporte.Rows.Count-1; x++){
				for(int y=1; y<dgReporte.Rows.Count; y++){
					if(dgReporte[8,x].Value.ToString() == dgReporte[8,y].Value.ToString() && dgReporte[3,x].Value.ToString() != dgReporte[3,y].Value.ToString()){
						dgReporte[31,x].Value = "2";
						dgReporte[31,y].Value = "2";
					}						
				}
				
				/*
				if(dgReporte[8,x].Value.ToString() == "GONZALEZ GUZMAN JUAN MANUEL"){			
					dgReporte[31,x].Value = "1";
					dgReporte[3,x].Value = "Luis Dario Arriaga Garcia";
					dgReporte[13,x].Value = "14";
					
					for(int y=1; y<dgReporte.Rows.Count; y++){
						if(dgReporte[8,x].Value.ToString() == "GONZALEZ GUZMAN JUAN MANUEL" && dgReporte[8,y].Value.ToString() == "GONZALEZ GUZMAN JUAN MANUEL" && x != y){						
							dgReporte[31,x].Value = "1";
							dgReporte[3,x].Value = "Luis Dario Arriaga Garcia";
							dgReporte[13,x].Value = "14";
							dgReporte[31,y].Value = "1";
							dgReporte[3,y].Value = "Luis Dario Arriaga Garcia";
							dgReporte[13,y].Value = "14";
							elimina = y;
						}
						if(dgReporte[8,x].Value.ToString() == dgReporte[8,y].Value.ToString() && dgReporte[3,x].Value.ToString() != dgReporte[3,y].Value.ToString()){
							dgReporte[31,x].Value = "2";
							dgReporte[31,y].Value = "2";
						}						
					}
				}*/
			}
			//if(elimina > 0)
				//dgReporte.Rows.RemoveAt(elimina);						
			
			//	dgReporte.Sort(dgReporte.Columns[9], ListSortDirection.Ascending);
			
			for(int x=0; x<dgReporte.Rows.Count; x++){
				//try{													
					///////////////////////////////////////////////////////////////  BAJAS  ////////////////////////////////////////////////////////////
					String id_operadoresBaja = "";			
					for(int c=0; c<id_cancelados.Count; c++){
						if(c==0)
							id_operadoresBaja = id_cancelados[c];
						if(c>0 && c<=id_cancelados.Count)
							id_operadoresBaja = id_operadoresBaja + ", "+ id_cancelados[c];
					}
					
					consulta = @"select Fecha from OperadorAltaBaja where Registro = 'INACTIVO' and Fecha between '"+dtpIncio.Value.AddDays(0).ToString("yyyy/MM/dd")
								+"' and '"+dtpFin.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and IdOperador = "+dgReporte[0,x].Value+" and IdOperador not in("+
						((id_operadoresBaja.Length == 0) ? "0": id_operadoresBaja)+") order by Fecha desc";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){					
						dgReporte[10,x].Value = conn.leer["Fecha"].ToString().Substring(0,10);
						dgReporte[11,x].Value = dgReporte[11,x].Value.ToString() +" BAJA";						
						
						id_cancelados.Add(dgReporte[0,x].Value.ToString());
					}
					conn.conexion.Close();					
					///////////////////////////////////////////////////////////  ESTATUS OPERADOR ///////////////////////////////////////////////////////////
					if(dgReporte[30,x].Value.ToString().Contains("BAJA"))
						dgReporte[4,x].Value = "BAJA";
					else
						dgReporte[4,x].Value = "ACTIVO";
										
					///////////////////////////////////////////////////////////////  TARJETA ///////////////////////////////////////////////////////////////
					dgReporte[6,x].Value = conC.ReturnNumero(dgReporte[0,x].Value.ToString());
					
					if(dgReporte[6,x].Value.ToString().Contains("Vacío")){						
						dgReporte[5,x].Value = "NO TIENE TARJETA";
						dgReporte[5,x].Style.BackColor = Color.LightPink;
					}else{						
						dgReporte[5,x].Value = "TARJETA";
					}
										
					//////////////////////////////////////////////////////////  SUELDO Y DESCUENTOS //////////////////////////////////////////////////////////
					consulta = @"select ISR, IMSS, INFONAVIT, SUELDO_BASE, TELCEL, aguinaldo, Retener, Compensacion, prima_v from SUELDO where ID_OPERADOR = "
								+dgReporte[0,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){					
							dgReporte[12,x].Value = conn.leer["SUELDO_BASE"].ToString();						
							//dgReporte[21,x].Value = conn.leer["IMSS"].ToString();
							dgReporte[22,x].Value = conn.leer["INFONAVIT"].ToString();								
							try{ dgReporte[21,x].Value = Math.Round(((Convert.ToDouble(conn.leer["IMSS"])/14) * (diasT) ), 2).ToString(); }	catch{}
							try{ dgReporte[23,x].Value = Math.Round(((Convert.ToDouble(conn.leer["ISR"])/14) * (diasT) ), 2).ToString(); }	catch{}
						}else{
							dgReporte[12,x].Value = "0";
							dgReporte[21,x].Value = "0";
							dgReporte[22,x].Value = "0";
							dgReporte[23,x].Value = "0";	
						}
					conn.conexion.Close();
					
					/////////////////////////////////////////////////////////////  CALCULO DIAS /////////////////////////////////////////////////////////////
					if(Convert.ToDateTime(dgReporte[9,x].Value) >= Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy")) && Convert.ToDateTime(dgReporte[9,x].Value) 
					   <= Convert.ToDateTime(dtpFin.Value.ToString("dd/MM/yyyy")) && (!dgReporte[11,x].Value.ToString().Contains("BAJA")) ){
						TimeSpan ts = Convert.ToDateTime(dtpFin.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(dgReporte[9,x].Value);
						int differenceInDays = ts.Days + 1;
						dgReporte[13,x].Value = differenceInDays.ToString();
						
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), (Convert.ToDateTime(dgReporte[9,x].Value)).ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd")));
								
					}						
					else if(Convert.ToDateTime(dgReporte[10,x].Value) > Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy")) && Convert.ToDateTime(dgReporte[10,x].Value) <= Convert.ToDateTime(dtpFin.Value.ToString("dd/MM/yyyy"))
					        && dgReporte[11,x].Value.ToString() != "Planta" && (!dgReporte[11,x].Value.ToString().Contains("BAJA")) && dgReporte[13,x].Value.ToString() == ""){
						TimeSpan ts = Convert.ToDateTime(dgReporte[10,x].Value) - Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy"));
						int differenceInDays = ts.Days + 1;
						dgReporte[13,x].Value = differenceInDays.ToString();
						/*
						if(dgReporte[8,x].Value.ToString() == "ASCENCIO HERNANDEZ JUAN CARLOS"){
							MessageBox.Show("Entro en la "+differenceInDays);
					
						}*/
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), (Convert.ToDateTime(dgReporte[10,x].Value)).ToString("yyyy-MM-dd") ));
					
					}				
					else if(Convert.ToDateTime(dgReporte[10,x].Value) == Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy")) && dgReporte[13,x].Value.ToString() == ""){
						dgReporte[13,x].Value =  "1";
						
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), (Convert.ToDateTime(dgReporte[10,x].Value)).ToString("yyyy-MM-dd"), (Convert.ToDateTime(dgReporte[10,x].Value)).ToString("yyyy-MM-dd")));
					
					}			
					else if(Convert.ToDateTime(dgReporte[9,x].Value) <= Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy")) && dgReporte[11,x].Value.ToString() == "Planta"
					       && dgReporte[13,x].Value.ToString() == ""){
						dgReporte[13,x].Value = diasT.ToString();
						
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd")));
					
					}				
					else if(dgReporte[11,x].Value.ToString().Contains("BAJA") && Convert.ToDateTime(dgReporte[9,x].Value) >= Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy")) &&
					       Convert.ToDateTime(dgReporte[9,x].Value) <= Convert.ToDateTime(dgReporte[10,x].Value) && dgReporte[13,x].Value.ToString() == ""){
						TimeSpan ts = Convert.ToDateTime(dgReporte[10,x].Value) - Convert.ToDateTime(dgReporte[9,x].Value);
						int differenceInDays = ts.Days + 1;
						dgReporte[13,x].Value = differenceInDays.ToString();
						
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), (Convert.ToDateTime(dgReporte[10,x].Value)).ToString("yyyy-MM-dd"), (Convert.ToDateTime(dgReporte[9,x].Value)).ToString("yyyy-MM-dd")));
					
					}					
					else if(dgReporte[11,x].Value.ToString().Contains("BAJA") && dgReporte[13,x].Value.ToString() == ""){
						TimeSpan ts = Convert.ToDateTime(dgReporte[10,x].Value) - Convert.ToDateTime(dtpIncio.Value.ToString("dd/MM/yyyy"));
						int differenceInDays = ts.Days + 1;
						dgReporte[13,x].Value = differenceInDays.ToString();
						
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), (Convert.ToDateTime(dgReporte[10,x].Value)).ToString("yyyy-MM-dd")));
					
					}			
					else if(dgReporte[13,x].Value.ToString() == ""){
						dgReporte[13,x].Value = diasT.ToString();
						
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd")));
					
					}
					/*
					if(dgReporte[8,x].Value.ToString() == "GONZALEZ GUZMAN JUAN MANUEL"){
						dgReporte[13,x].Value = diasT.ToString();
						
						if(dgReporte[31,x].Value.ToString() == "1")
							dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd")));
					
					}*/
					
					//////////////////////////////////////////////////////////  INCAPACIDADES //////////////////////////////////////////////////////////
					if(dgReporte[13,x].Value.ToString() != "" && dgReporte[13,x].Value.ToString() != " ")
						dgReporte[13,x].Value = Convert.ToInt32(dgReporte[13,x].Value) - DiasIncapacidades(dgReporte[0,x].Value.ToString(), dtpIncio.Value, dtpFin.Value);
					
					//////////////////////////////////////////////////////////  DESCUENTOS //////////////////////////////////////////////////////////
					consulta = @"select ISR, IMSS, INFONAVIT, SUELDO_BASE, TELCEL, aguinaldo, Retener, Compensacion, prima_v from SUELDO where ID_OPERADOR = "
								+dgReporte[0,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){							
							try{ dgReporte[21,x].Value = Math.Round(((Convert.ToDouble(conn.leer["IMSS"])/14) * (Convert.ToInt32(dgReporte[13,x].Value)) ), 2).ToString(); }	catch{}
							try{ dgReporte[22,x].Value = Math.Round(((Convert.ToDouble(conn.leer["INFONAVIT"])/14) * (Convert.ToInt32(dgReporte[13,x].Value)) ), 2).ToString(); }	catch{}
							try{ dgReporte[23,x].Value = Math.Round(((Convert.ToDouble(conn.leer["ISR"])/14) * (Convert.ToInt32(dgReporte[13,x].Value)) ),2).ToString(); }	catch{}
						}else{
							dgReporte[12,x].Value = "0";
							dgReporte[21,x].Value = "0";
							dgReporte[22,x].Value = "0";
							dgReporte[23,x].Value = "0";	
						}
					conn.conexion.Close();
					
					/////////////////////////////////////////////////////////////  PERCEPCIONES /////////////////////////////////////////////////////////////
					if(dgReporte[12,x].Value.ToString() != "" && dgReporte[13,x].Value.ToString() != "")	
						dgReporte[14,x].Value = Math.Round(((Convert.ToDouble(dgReporte[13,x].Value)) * ((Convert.ToDouble(dgReporte[12,x].Value))/Convert.ToDouble(txtIntegracion.Text))), 2); //SUELDO NOMINAL FISCAL
					else
						dgReporte[14,x].Value = "0";
					
					if(dgReporte[14,x].Value.ToString() != ""){
						dgReporte[15,x].Value = "0"; //SUBSIDIO EMPLEO
						dgReporte[16,x].Value = Math.Round(((Convert.ToDouble(dgReporte[14,x].Value) * 0.1)), 2); //PRMEIO A
						dgReporte[17,x].Value = Math.Round(((Convert.ToDouble(dgReporte[14,x].Value) * 0.1)), 2); //PREMIO P   		
						dgReporte[18,x].Value = Math.Round((Convert.ToDouble(txtSalariominimo.Text) * 0 * Convert.ToInt16(dgReporte[13,x].Value) ), 2); //DESPENSA
					}else{
						
					}
					///////////////////////////////////////////////////////////  CALCULO FISCAL ////////////////////////////////////////////////////////////
					calculoSUBEmpleado(x);
				
					////////////////////////////////////////////////////////////  SUELDO FISCAL ////////////////////////////////////////////////////////////
					if(dgReporte[14,x].Value.ToString() != "" && dgReporte[15,x].Value.ToString() != "" && dgReporte[16,x].Value.ToString() != "" && 
					   dgReporte[17,x].Value.ToString() != "" && dgReporte[18,x].Value.ToString() != ""){
						dgReporte[24,x].Value = (Math.Round(((Convert.ToDouble(dgReporte[14,x].Value) + Convert.ToDouble(dgReporte[15,x].Value) + Convert.ToDouble(dgReporte[16,x].Value) +
						                        Convert.ToDouble(dgReporte[17,x].Value) + Convert.ToDouble(dgReporte[18,x].Value)) - 
						                        (Convert.ToDouble(dgReporte[21,x].Value) + Convert.ToDouble(dgReporte[22,x].Value) + Convert.ToDouble(dgReporte[23,x].Value))),2)).ToString();
					}else{
						dgReporte[24,x].Value = "0";
					}		
															
					///////////////////////////////////////////////////////////////  PRESTAMOS  ////////////////////////////////////////////////////////////
					consulta = @"select DT.FECHA, D.DESCRIPCION, DT.IMPORTE, D.TIPO, d.IMPORTE_TOTAL from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O 
								where D.ID = DT.ID_DESCUENTO AND O.ID = D.ID_OPERADOR and FLUJO!='3' and FLUJO!='5' AND (DESCRIPCION like '%PRESTAMO%' 
								OR DESCRIPCION like '%CHOQUE%') and DT.FECHA between '"+dtpIncio.Value.AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+
								dtpFin.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR = "+dgReporte[0,x].Value+" order by DT.FECHA";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){					
							dgReporte[19,x].Value = conn.leer["IMPORTE_TOTAL"].ToString();						
							dgReporte[20,x].Value = conn.leer["IMPORTE"].ToString();	
						}else{
							dgReporte[19,x].Value = "0";
							dgReporte[20,x].Value = "0";
						}
					conn.conexion.Close();
					
					///////////////////////////////////////////////////////////////  SUELDO REAL ///////////////////////////////////////////////////////////////					
					if(dgReporte[31,x].Value.ToString() == "2")
						dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd")));
					
					//if(dgReporte[31,x].Value.ToString() == "1" && Convert.ToInt32(dgReporte[13,x].Value) == diasT && (!dgReporte[11,x].Value.ToString().Contains("BAJA")))
						//dgReporte[25,x].Value = (refNomina.RetornoSueldoAlias3(dgReporte[30,x].Value.ToString(), dtpIncio.Value.ToString("yyyy-MM-dd"), dtpFin.Value.ToString("yyyy-MM-dd")));
					//if(dgReporte[31,x].Value.ToString() == "2")
						//dgReporte[25,x].Value = "Proceso";			
					
									
				//}catch(Exception){
				//}
			}
			
			// Enumera y elimina Registros mal
			dgReporte.Sort(dgReporte.Columns[8], ListSortDirection.Ascending);
			dgReporte.Sort(dgReporte.Columns[3], ListSortDirection.Ascending);
			int o = 1;
			for(int x=0; x<dgReporte.Rows.Count; x++){
				try{				
													
					///////////////////////////////////////////////////////////////  BAJAS  ////////////////////////////////////////////////////////////
					consulta = @"select Fecha from OperadorAltaBaja where Registro = 'INACTIVO' and Fecha between '"+dtpIncio.Value.AddDays(-29).ToString("yyyy/MM/dd")
								+"' and '"+dtpIncio.Value.AddDays(-1).ToString("yyyy/MM/dd")+"' and IdOperador = "+dgReporte[0,x].Value+" order by Fecha desc";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgReporte.Rows.RemoveAt(x);				
					}			
					conn.conexion.Close();
					if(dgReporte[30,x].Value.ToString().Contains("GAMEZ") || dgReporte[30,x].Value.ToString().Contains("CISNEROS") || dgReporte[30,x].Value.ToString().Contains("LORENZO")){
						dgReporte[2,x].Value = "N/A";
					}else{
						dgReporte[2,x].Value = (o).ToString();
						o++;						
					}
				}catch(Exception){
				}
			}
			
			//////////////////////////////////////////////////////////////  DEPOSITOS  ////////////////////////////////////////////////////////////
			CalculosPago();
			
			dgReporte.ClearSelection();
		}
		
		private void CalculosPago(){
			for(int x=0; x<dgReporte.Rows.Count; x++){
				try{
					//////////////////////////////////////////////////  OPERADORES NO APLICAN //////////////////////////////////////////////////////////
					if(dgReporte[30,x].Value.ToString() == "GAMEZ" || dgReporte[30,x].Value.ToString() == "CISNEROS" || dgReporte[30,x].Value.ToString() == "LORENZO"){
						dgReporte[12,x].Value = "0";
						dgReporte[13,x].Value = "0";
						dgReporte[14,x].Value = "0";
						dgReporte[15,x].Value = "0";
						dgReporte[16,x].Value = "0";
						dgReporte[17,x].Value = "0";
						dgReporte[18,x].Value = "0";
						dgReporte[21,x].Value = "0";
						dgReporte[22,x].Value = "0";
						dgReporte[23,x].Value = "0";
						dgReporte[24,x].Value = "0";
						
						dgReporte[26,x].Value = "0";
						dgReporte[27,x].Value = "0";
						dgReporte[28,x].Value = "0";
						dgReporte[29,x].Value = "0";
					}	
	
					if(!dgReporte[6,x].Value.ToString().Contains("Vacío")){ // valida tiene tarjeta
						if(dgReporte[31,x].Value.ToString() == "1"){ // valida un patron
							if(Convert.ToDouble(dgReporte[25,x].Value) >= Convert.ToDouble(dgReporte[24,x].Value)){ // valida que el sueldo real sea => al suendo fiscal
								dgReporte[26,x].Value = dgReporte[24,x].Value.ToString();
								dgReporte[27,x].Value = (Convert.ToDouble(dgReporte[25,x].Value) - Convert.ToDouble(dgReporte[24,x].Value)).ToString();
								dgReporte[28,x].Value = "0";
								dgReporte[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporte[25,x].Value) < Convert.ToDouble(dgReporte[24,x].Value) && Convert.ToDouble(dgReporte[25,x].Value) > 0){ // valida que el sueldo real sea => al suendo fiscal
								dgReporte[26,x].Value = dgReporte[25,x].Value.ToString();
								dgReporte[27,x].Value = "0";
								dgReporte[28,x].Value = (Convert.ToDouble(dgReporte[24,x].Value) - Convert.ToDouble(dgReporte[25,x].Value)).ToString();
								dgReporte[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporte[25,x].Value) < Convert.ToDouble(dgReporte[24,x].Value) && Convert.ToDouble(dgReporte[25,x].Value) < 0){ // valida que el sueldo real sea => al suendo fiscal
								dgReporte[26,x].Value = "0";
								dgReporte[27,x].Value = "0";
								dgReporte[28,x].Value = (Convert.ToDouble(dgReporte[24,x].Value)).ToString();
								dgReporte[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporte[25,x].Value) == 0){ // valida que el sueldo real sea == 0
								dgReporte[26,x].Value = "0";
								dgReporte[27,x].Value = "0";
								dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
								dgReporte[29,x].Value = "0";
							}							
						}
						if(dgReporte[31,x].Value.ToString() == "2"){ // valida dos patron							
							for(int y = 0; y<dgReporte.Rows.Count; y++){
								if(dgReporte[8,x].Value.ToString() == dgReporte[8,y].Value.ToString() && dgReporte[3,x].Value.ToString() != dgReporte[3,y].Value.ToString()){
									if(Convert.ToDouble(dgReporte[25,x].Value) >= (Convert.ToDouble(dgReporte[24,x].Value) + Convert.ToDouble(dgReporte[24,y].Value))){ // valida que el sueldo real sea => al suendo fiscal
										if(dgReporte[29,x].Value.ToString() != "0" && dgReporte[29,y].Value.ToString() != "0"){
											dgReporte[25,x].Value = dgReporte[24,x].Value.ToString();
											dgReporte[26,x].Value = dgReporte[24,x].Value.ToString();
											dgReporte[27,x].Value = "0";
											dgReporte[28,x].Value = "0";
											dgReporte[29,x].Value = "0";
											
											dgReporte[25,y].Value = (Convert.ToDouble(dgReporte[25,y].Value) - Convert.ToDouble(dgReporte[24,x].Value)).ToString();
											dgReporte[26,y].Value = dgReporte[24,y].Value.ToString();
											dgReporte[27,y].Value = (Convert.ToDouble(dgReporte[25,y].Value) - (Convert.ToDouble(dgReporte[24,y].Value)  )).ToString();
											dgReporte[28,y].Value = "0";
											dgReporte[29,y].Value = "0";
										}
									}
									if(Convert.ToDouble(dgReporte[25,x].Value) < (Convert.ToDouble(dgReporte[24,x].Value) + Convert.ToDouble(dgReporte[24,y].Value))){ // valida que el sueldo real sea =< al suendo fiscal
										if(dgReporte[29,x].Value.ToString() != "0" && dgReporte[29,y].Value.ToString() != "0"){
											dgReporte[26,x].Value = "0";
											dgReporte[27,x].Value = "0";
											dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
											dgReporte[29,x].Value = "0";
											
											dgReporte[26,y].Value = "0";
											dgReporte[27,y].Value = "0";
											dgReporte[28,y].Value = dgReporte[24,y].Value.ToString();
											dgReporte[29,y].Value = "0";
										}
									}
								}
							}							
						}
					}
					
					if(dgReporte[6,x].Value.ToString().Contains("Vacío")){ // valida no tiene tarjeta
						if(dgReporte[31,x].Value.ToString() == "1"){ // valida un patron
							if(Convert.ToDouble(dgReporte[25,x].Value) >= Convert.ToDouble(dgReporte[24,x].Value)){ // valida que el sueldo real sea => al suendo fiscal
								dgReporte[26,x].Value = "0";
								dgReporte[27,x].Value = "0";
								dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
								dgReporte[29,x].Value = dgReporte[25,x].Value.ToString();
							}
							if(Convert.ToDouble(dgReporte[25,x].Value) < Convert.ToDouble(dgReporte[24,x].Value) && Convert.ToDouble(dgReporte[25,x].Value) > 0){ // valida que el sueldo real sea => al suendo fiscal
								dgReporte[26,x].Value = "0";
								dgReporte[27,x].Value = "0";
								dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
								dgReporte[29,x].Value = dgReporte[25,x].Value.ToString();
							}
							if(Convert.ToDouble(dgReporte[25,x].Value) < Convert.ToDouble(dgReporte[24,x].Value) && Convert.ToDouble(dgReporte[25,x].Value) < 0){ // valida que el sueldo real sea =< al suendo fiscal
								dgReporte[26,x].Value = "0";
								dgReporte[27,x].Value = "0";
								dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
								dgReporte[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporte[25,x].Value) == 0){ // valida que el sueldo real sea == 0
								dgReporte[26,x].Value = "0";
								dgReporte[27,x].Value = "0";
								dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
								dgReporte[29,x].Value = "0";
							}							
						}
						if(dgReporte[31,x].Value.ToString() == "2"){ // valida dos patron
							for(int y = 0; y<dgReporte.Rows.Count; y++){
								if(dgReporte[8,x].Value.ToString() == dgReporte[8,y].Value.ToString() && dgReporte[3,x].Value.ToString() != dgReporte[3,y].Value.ToString()){
									if(Convert.ToDouble(dgReporte[25,x].Value) >= (Convert.ToDouble(dgReporte[24,x].Value) + Convert.ToDouble(dgReporte[24,y].Value))){ // valida que el sueldo real sea => al suendo fiscal
										if(dgReporte[26,x].Value.ToString() != "0" && dgReporte[26,y].Value.ToString() != "0"){
											dgReporte[25,x].Value = "-";
											dgReporte[26,x].Value = "0";
											dgReporte[27,x].Value = "0";
											dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
											dgReporte[29,x].Value = "0";
											
											dgReporte[26,y].Value = "0";
											dgReporte[27,y].Value = "0";
											dgReporte[28,y].Value = dgReporte[24,y].Value.ToString();
											dgReporte[29,y].Value = dgReporte[25,y].Value.ToString();
											
										}
									}	
									if(Convert.ToDouble(dgReporte[25,x].Value) < (Convert.ToDouble(dgReporte[24,x].Value) + Convert.ToDouble(dgReporte[24,y].Value))){ // valida que el sueldo real sea =< al suendo fiscal
										if(dgReporte[26,x].Value.ToString() != "0" && dgReporte[26,y].Value.ToString() != "0"){											
											dgReporte[26,x].Value = "0";
											dgReporte[27,x].Value = "0";
											dgReporte[28,x].Value = dgReporte[24,x].Value.ToString();
											dgReporte[29,x].Value = "0";
											
											dgReporte[26,y].Value = "0";
											dgReporte[27,y].Value = "0";
											dgReporte[28,y].Value = dgReporte[24,y].Value.ToString();
											dgReporte[29,y].Value = "0";
											
										}
									}									
								}
							}					
						}
					}
				}catch(Exception){
				}
			}
		}
		
		private void calculoSUBEmpleado(int y){
			dataTotalesISPT14.Rows[0].Cells[1].Value = (Convert.ToDouble(dgReporte.Rows[y].Cells[14].Value) + Convert.ToDouble(dgReporte.Rows[y].Cells[16].Value) + 
			                                            Convert.ToDouble(dgReporte.Rows[y].Cells[17].Value) + Convert.ToDouble(dgReporte.Rows[y].Cells[18].Value))/
														(Convert.ToDouble(dgReporte.Rows[y].Cells[13].Value));
			
			double baseGravable = ((Convert.ToDouble(dgReporte.Rows[y].Cells[14].Value) + Convert.ToDouble(dgReporte.Rows[y].Cells[16].Value) + 
			                        Convert.ToDouble(dgReporte.Rows[y].Cells[17].Value) + Convert.ToDouble(dgReporte.Rows[y].Cells[18].Value)))/
									(Convert.ToDouble(dgReporte.Rows[y].Cells[13].Value));
					
				for(int x=0;x<dataTarifas14.Rows.Count;x++){
					if(((Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value))<=(baseGravable))&&((Convert.ToDouble(dataTarifas14.Rows[x].Cells[1].Value))>=(baseGravable))){
					   	dataTotalesISPT14.Rows[0].Cells[1].Value = (baseGravable);
					   	dataTotalesISPT14.Rows[1].Cells[1].Value = (Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value));
					   	dataTotalesISPT14.Rows[2].Cells[1].Value = (baseGravable)-(Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value));
					   	dataTotalesISPT14.Rows[3].Cells[1].Value = dataTarifas14.Rows[x].Cells[3].Value;
					    dataTotalesISPT14.Rows[4].Cells[1].Value =  (Convert.ToDouble(dataTarifas14.Rows[x].Cells[3].Value))*(Convert.ToDouble(dataTotalesISPT14.Rows[2].Cells[1].Value));
					    dataTotalesISPT14.Rows[5].Cells[1].Value = dataTarifas14.Rows[x].Cells[2].Value;
					   	dataTotalesISPT14.Rows[6].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[4].Cells[1].Value))	+ (Convert.ToDouble(dataTotalesISPT14.Rows[5].Cells[1].Value));
					   	break;
					}
				}
				
				for(int x=0;x<dataSubsidio14.Rows.Count;x++){
					if(((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[0].Value))<=(baseGravable))&&((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[1].Value))>=(baseGravable))){
					   	dataTotalesISPT14.Rows[7].Cells[1].Value = dataSubsidio14.Rows[x].Cells[2].Value;
					   	dataTotalesISPT14.Rows[8].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[6].Cells[1].Value)) - (Convert.ToDouble(dataTotalesISPT14.Rows[7].Cells[1].Value));
					  	
					   	if((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))>0)
					   		dataTotalesISPT14.Rows[9].Cells[1].Value = 0;
					  	else
					  		dataTotalesISPT14.Rows[9].Cells[1].Value = Math.Round((((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))*(Convert.ToDouble(dgReporte.Rows[y].Cells[13].Value)))*(-1)),2);
					  	
					  	if((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))>0)
					  		dataTotalesISPT14.Rows[8].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))*(Convert.ToDouble(dgReporte.Rows[y].Cells[13].Value));
					  	else
					  		dataTotalesISPT14.Rows[8].Cells[1].Value = 0; 
					  	break;
					}
				}
				dgReporte.Rows[y].Cells[15].Value = Math.Round((Convert.ToDouble(dataTotalesISPT14.Rows[9].Cells[1].Value)), 2);
				
				if(dgReporte.Rows[y].Cells[13].Value.ToString() == "0")
					dgReporte.Rows[y].Cells[15].Value = "0";
		}
		
		private void Reporte(){
			string[,] arrayOpNA = new string[4, 2];
			int contadorA = 0;
 
			if(dgReporte.Rows.Count>0){
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
				string nombreA = "NOMINA DEL "+dtpIncio.Value.ToString("dd")+" AL "+dtpFin.Value.ToString("dd")+" DE "+dtpFin.Value.ToString("MMMM").ToUpper()+" "+dtpFin.Value.ToString("yyyy");
					
				ExcelApp.Cells[2,  4] 	= nombreA;
				
				int i = 4;
				ExcelApp.Cells[i,  1] 	= "NUMERO";
				ExcelApp.Cells[i,  2] 	= "PATRON";
				ExcelApp.Cells[i,  3] 	= "ESTATUS";
				ExcelApp.Cells[i,  4] 	= "CON O SIN TARJETA";
				ExcelApp.Cells[i,  5] 	= "NO. CUENTA";
				ExcelApp.Cells[i,  6] 	= "PUESTO";
				ExcelApp.Cells[i,  7] 	= "NOMBRE";
				ExcelApp.Cells[i,  8] 	= "SUELDO BASE";
				ExcelApp.Cells[i,  9] 	= "DIAS";
				ExcelApp.Cells[i,  10] 	= "SUELDO";
				ExcelApp.Cells[i,  11] 	= "SUB. EMPLEO";
				ExcelApp.Cells[i,  12] 	= "PREMIO A.";
				ExcelApp.Cells[i,  13] 	= "PREMIO P.";
				ExcelApp.Cells[i,  14] 	= "DESPENSA";
				ExcelApp.Cells[i,  15] 	= "TOTAL PERCEPCIONES";
				ExcelApp.Cells[i,  16] 	= "DESC. PRESTAMO";
				ExcelApp.Cells[i,  17] 	= "IMSS";
				ExcelApp.Cells[i,  18] 	= "INFONAVIT";
				ExcelApp.Cells[i,  19] 	= "ISR";
				ExcelApp.Cells[i,  20] 	= "TOTAL DEDUCCIONES";
				ExcelApp.Cells[i,  21] 	= "NETO A PAGAR";
				ExcelApp.Cells[i,  22] 	= "NETO A PAGAR REAL";
				ExcelApp.Cells[i,  23] 	= "T.B.";
				ExcelApp.Cells[i,  24] 	= "DEPOSITO";
				ExcelApp.Cells[i,  25] 	= "CHEQUE";
				ExcelApp.Cells[i,  26] 	= "EFECTIVO";
				ExcelApp.Cells[i,  27] 	= "ALIAS";
				ExcelApp.Cells[i,  28] 	= "N° PATRONES";
				
				string patro = "";				
				int pb = (int) 100 / dgReporte.Rows.Count;
				refPrincipal.progressbarPrin.Value = 1;
				
				for(int y=0; y<dgReporte.Rows.Count; y++){
					if(dgReporte[30,y].Value.ToString().Contains("GAMEZ") || dgReporte[30,y].Value.ToString().Contains("CISNEROS") || dgReporte[30,y].Value.ToString().Contains("LORENZO")){
						arrayOpNA[contadorA,0] = dgReporte[30,y].Value.ToString();
						arrayOpNA[contadorA,1] = dgReporte[25,y].Value.ToString();
						contadorA++;
					}else{
						++i;	
						if (refPrincipal.progressbarPrin.Value<100)					
	                		refPrincipal.progressbarPrin.Value += pb;
						
						if(dgReporte[3,y].Value.ToString().Contains("Alma Selene Arriaga Garcia"))
							patro = "ALMA";
						if(dgReporte[3,y].Value.ToString().Contains("Juana Garcia Gamboa"))
							patro = "JUANA";
						if(dgReporte[3,y].Value.ToString().Contains("Luis Arriaga Ruiz"))
							patro = "LUIS";
						if(dgReporte[3,y].Value.ToString().Contains("Luis Dario Arriaga Garcia"))
							patro = "DARIO";
						if(dgReporte[3,y].Value.ToString().Contains("Ray Kenny Arriaga Garcia"))
							patro = "KENNY";
						if(dgReporte[3,y].Value.ToString().Contains("LOGISTICA ACTITUD Y RESPONSABILIDAD EN EL TRANSPORTE EJECUTIVO SA DE CV"))
							patro = "LOGISTICA";
											
						ExcelApp.Cells[i,  1]	= dgReporte[2,y].Value.ToString();
						ExcelApp.Cells[i,  2]	= patro;
						ExcelApp.Cells[i,  3]	= dgReporte[4,y].Value.ToString();
						ExcelApp.Cells[i,  4]	= dgReporte[5,y].Value.ToString();
						ExcelApp.Cells[i,  5]	= dgReporte[6,y].Value.ToString();					
						ExcelApp.Cells[i,  6]	= ((dgReporte[7,y].Value.ToString()=="OPERADOR")? "OP" : dgReporte[7,y].Value.ToString());
						ExcelApp.Cells[i,  7]	= dgReporte[8,y].Value.ToString();
						ExcelApp.Cells[i,  8]	= dgReporte[12,y].Value.ToString();
						ExcelApp.Cells[i,  9]	= dgReporte[13,y].Value.ToString();
						ExcelApp.Cells[i,  10]	= dgReporte[14,y].Value.ToString();
						ExcelApp.Cells[i,  11]	= dgReporte[15,y].Value.ToString();
						ExcelApp.Cells[i,  12]	= dgReporte[16,y].Value.ToString();
						ExcelApp.Cells[i,  13]	= dgReporte[17,y].Value.ToString();
						ExcelApp.Cells[i,  14]	= dgReporte[18,y].Value.ToString();
						ExcelApp.Cells[i,  15]	= (Convert.ToDouble(dgReporte[24,y].Value) + Convert.ToDouble(dgReporte[21,y].Value) + Convert.ToDouble(dgReporte[22,y].Value) + Convert.ToDouble(dgReporte[23,y].Value) ); // TOTAL P
						ExcelApp.Cells[i,  16]	= dgReporte[20,y].Value.ToString();
						ExcelApp.Cells[i,  17]	= dgReporte[21,y].Value.ToString();
						ExcelApp.Cells[i,  18]	= dgReporte[22,y].Value.ToString();
						ExcelApp.Cells[i,  19]	= dgReporte[23,y].Value.ToString();
						ExcelApp.Cells[i,  20]	= ( Convert.ToDouble(dgReporte[21,y].Value) + Convert.ToDouble(dgReporte[22,y].Value) + Convert.ToDouble(dgReporte[23,y].Value) ).ToString(); // TOTAL D
						ExcelApp.Cells[i,  21]	= Convert.ToDouble(dgReporte[24,y].Value).ToString(); // NOMINA FISCAL
						//ExcelApp.Cells[i,  21]	= ( Convert.ToDouble(dgReporte[24,y].Value) - ( Convert.ToDouble(dgReporte[21,y].Value) + Convert.ToDouble(dgReporte[22,y].Value) + Convert.ToDouble(dgReporte[23,y].Value) ) ).ToString(); // NOMINA FISCAL
						ExcelApp.Cells[i,  22]	= dgReporte[25,y].Value.ToString();
						ExcelApp.Cells[i,  23]	= dgReporte[26,y].Value.ToString();
						ExcelApp.Cells[i,  24]	= dgReporte[27,y].Value.ToString();
						ExcelApp.Cells[i,  25]	= dgReporte[28,y].Value.ToString();
						ExcelApp.Cells[i,  26]	= dgReporte[29,y].Value.ToString();
						ExcelApp.Cells[i,  27]	= dgReporte[30,y].Value.ToString();
						ExcelApp.Cells[i,  28]	= ((dgReporte[31,y].Value.ToString()=="2")? "DOS PATRONES" : "");
					}
				}
				
				++i;	
				++i;
				double suma = 0.0;
				try{
					for (int fil = 0; fil <= (arrayOpNA.Length/2)-1; fil++){
						++i;
							ExcelApp.Cells[i,  2]	= i-6;
							ExcelApp.Cells[i,  3]	= arrayOpNA[fil,0].ToString();
							ExcelApp.Cells[i,  4]	= "PAGO EFECTIVO";
							ExcelApp.Cells[i,  5]	= arrayOpNA[fil,1].ToString();
							suma = suma + Convert.ToDouble(arrayOpNA[fil,1]);
					}			
						++i;	
							ExcelApp.Cells[i,  5]	= suma.ToString();
				}catch(Exception){}
					
				
				refPrincipal.progressbarPrin.Value = 100;
				refPrincipal.progressbarPrin.Value = 0;	
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xlsx";
				CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "CARGA " + nombreA;
				if (CuadroDialogo.ShowDialog() == DialogResult.OK){
					ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
					ExcelApp.ActiveWorkbook.Saved = true;
					CuadroDialogo.Dispose();
					CuadroDialogo = null;
					ExcelApp.Quit();
					MessageBox.Show("Se exportaron los datos Correctamente ... ");
					Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\CARGA "+nombreA+".xlsx"));
	
				}else{
					MessageBox.Show("No Genero el Reporte ... ");
					refPrincipal.progressbarPrin.Value = 0;
				}
			}
		}
		
		private int DiasIncapacidades(string id_operador, DateTime FechaInicio, DateTime FechaCorte)
		{
			bool boolInicio = false;
			bool boolFin = false;
			bool boolAmbos = false;
			bool boolIncapacitado = false;
			
			DateTime FechaInicioIncapacidad;
			DateTime FechaCorteIncapacidad;
			TimeSpan tsI01 =  (FechaCorte - FechaInicio);
			TimeSpan tsI02 =  (FechaCorte - FechaInicio);
			TimeSpan tsI03 =  (FechaCorte - FechaInicio);
					
			string consulta = "select FECHA_INICIO from INCAPACIDAD WHERE FECHA_INICIO BETWEEN '"+
				                      FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+id_operador;
				
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				FechaInicioIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString().Substring(0,10)));
				tsI01 = FechaCorte - FechaInicioIncapacidad;
				boolInicio = true;
			}			
			conn.conexion.Close();
			
			consulta = "select FECHA_FIN from INCAPACIDAD WHERE FECHA_FIN BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)
						+"' and ID_OPERADOR ="+id_operador;
			
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				FechaCorteIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_FIN"].ToString().Substring(0,10)));
				tsI02 = FechaCorteIncapacidad - FechaInicio;
				boolFin = true;
			}		
			conn.conexion.Close();
			
			consulta = "select FECHA_FIN, FECHA_INICIO from INCAPACIDAD WHERE FECHA_FIN BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)
						+"' and FECHA_INICIO BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+id_operador;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				FechaCorteIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_FIN"].ToString().Substring(0,10)));
				FechaInicioIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString().Substring(0,10)));
				tsI03 = FechaCorteIncapacidad - FechaInicioIncapacidad;
				boolAmbos = true;
			}		
			conn.conexion.Close();
			
			consulta = "select FECHA_FIN, FECHA_INICIO from INCAPACIDAD WHERE FECHA_FIN >'"+FechaInicio.ToString().Substring(0,10)+"' and FECHA_INICIO <'"+
						FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+id_operador;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				boolIncapacitado = true;
			}	
			conn.conexion.Close();
				
			if((boolInicio == true)&&(boolFin == false))
				return Convert.ToInt32(tsI01.Days + 1);
			else if((boolInicio == false)&&(boolFin == true))
				return Convert.ToInt32(tsI02.Days + 1);
			else if(boolAmbos == true)
				return Convert.ToInt32(tsI03.Days + 1);
			else if(boolIncapacitado == true)
				return 14;
			else
				return 0;
		}
		
		#endregion		
		
		#region BOTONES		
		void BtnReporteEClick(object sender, EventArgs e)
		{
			Reporte();
		}	
		#endregion				
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///////////////////////////////////////////////// REPORTE ADMINISTRATIVOS /////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		#region EVENTOS
		void TxtAliasReporteAdministrativosKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Return"){
				dgReporteAdministrativos.ClearSelection();
				for(int x=0; x<dgReporteAdministrativos.Rows.Count; x++){
					if(txtAliasReporteAdministrativos.Text == dgReporteAdministrativos[30,x].Value.ToString()){
						dgReporteAdministrativos.Rows[x].Selected = true;
						dgReporteAdministrativos.FirstDisplayedCell = dgReporteAdministrativos.Rows[x].Cells[30];
					}
				}
			}
			else if(txtAliasReporteAdministrativos.Text.Length == 3){
				dgReporteAdministrativos.ClearSelection();
				for(int x=0; x<dgReporteAdministrativos.Rows.Count; x++){
					if(txtAliasReporteAdministrativos.Text == dgReporteAdministrativos[30,x].Value.ToString()){
						dgReporteAdministrativos.Rows[x].Selected = true;
						dgReporteAdministrativos.FirstDisplayedCell = dgReporteAdministrativos.Rows[x].Cells[30];
					}
				}
			}
		}
		
		void DgReporteAdministrativosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			//if(e.RowIndex > -1)
				//calculoSUBEmpleado(e.RowIndex);
		}		
				
		void LblReflescarAdministrativosClick(object sender, EventArgs e)
		{
			AdaptadorReporteAdministrativos();
		}
		
		void DtpInicioAdministrativosValueChanged(object sender, EventArgs e)
		{
			dtpFinAdministrativos.MinDate = dtpInicioAdministrativos.Value;
			dtpFinAdministrativos.Value = dtpInicioAdministrativos.Value;
		}		
			
		void CbPeriodoAdministrativosCheckedChanged(object sender, EventArgs e)
		{
			if(cbPeriodoAdministrativos.Checked == true){
				dtpInicioAdministrativos.Value = DateTime.Now.AddDays(1 - Convert.ToDouble(DateTime.Now.DayOfWeek));
				dtpFinAdministrativos.Value = DateTime.Now.AddDays(7 - Convert.ToDouble(DateTime.Now.DayOfWeek));
				dtpInicioAdministrativos.Enabled = false;
				dtpFinAdministrativos.Enabled = false;
			}else{
				dtpInicioAdministrativos.Enabled = true;
				dtpFinAdministrativos.Enabled = true;
			}
		}		
		#endregion
		
		#region METODOS
		public void AdaptadorReporteAdministrativos(){
			int contador = 0;
			List<string> ID_contrato = new List<string>();		
			// Que firmen contrato en periodo nominar
			String sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado not in ('Externo', 'OPERADOR')) and  
								FechaInicioContrato between '"+dtpInicioAdministrativos.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinAdministrativos.Value.ToString("yyyy-MM-dd")+
								"' order by nombre";
			
			ColoresAlternadosRows(dgReporteAdministrativos);
			dgReporteAdministrativos.Rows.Clear();			
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporteAdministrativos.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10),
				                   conn.leer["TipoContrato"].ToString(),              
				                   "", //Sueldo base
				                   "",//DIAS              
				                   "",//SUELDO        
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				ID_contrato.Add(conn.leer["CONTRATO"].ToString());
				contador++;
			}
			conn.conexion.Close();
			
			String id_c = "";			
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// Que se termine el contrato en periodo nominar
			sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado not in ('Externo', 'OPERADOR')) and  
								fecha_vencimiento between '"+dtpInicioAdministrativos.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinAdministrativos.Value.ToString("yyyy-MM-dd")	
								+"' and oc.id not in("+id_c+") order by nombre";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporteAdministrativos.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),//(Convert.ToDateTime((conn.leer["fecha_vencimiento"].ToString()))).ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10), //(Convert.ToDateTime(conn.leer["fecha_vencimiento"].ToString()).AddDays(28)).ToString().Substring(0,10),//"yyyy-MM-dd"
				                   conn.leer["TipoContrato"].ToString(),     
				                   "", //Sueldo base
				                   "",//DIAS         
				                   "",//SUELDO             
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO				                 
				ID_contrato.Add(conn.leer["CONTRATO"].ToString());
				contador++;
			}
			conn.conexion.Close();
			
			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
				
			if(id_c == "")
			   id_c = "0";
			// Que inicio el contrato 13 dias antes del periodo nominar
			sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado not in ('Externo', 'OPERADOR')) and  
								FechaInicioContrato between '"+dtpInicioAdministrativos.Value.AddDays(-14).ToString("yyyy-MM-dd")+"' and '"+dtpFinAdministrativos.Value.ToString("yyyy-MM-dd")
								+"' and oc.id not in("+id_c+") order by nombre";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporteAdministrativos.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),//(Convert.ToDateTime((conn.leer["fecha_vencimiento"].ToString()))).ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10), //(Convert.ToDateTime(conn.leer["fecha_vencimiento"].ToString()).AddDays(28)).ToString().Substring(0,10),//"yyyy-MM-dd"
				                   conn.leer["TipoContrato"].ToString(),     
				                   "", //Sueldo base
				                   "",//DIAS            
				                   "",//SUELDO          
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO				                 
				ID_contrato.Add(conn.leer["CONTRATO"].ToString());
				contador++;
			}
			conn.conexion.Close();
			
			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// Que firmen contrato de planta antes del periodo nominal y esten activos
			sentencia = @" select o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, oc.fecha_vencimiento, 
								oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador where (o.tipo_empleado not in ('Externo', 'OPERADOR')) and  
								oc.TipoContrato = 'Planta' and o.Estatus = '1' and FechaInicioContrato < '"+dtpInicioAdministrativos.Value.ToString("yyyy-MM-dd")+
								"' and oc.id not in("+id_c+") order by nombre";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporteAdministrativos.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),//(Convert.ToDateTime((conn.leer["fecha_vencimiento"].ToString()))).ToString().Substring(0,10),
				                   conn.leer["fecha_vencimiento"].ToString().Substring(0,10), //(Convert.ToDateTime(conn.leer["fecha_vencimiento"].ToString()).AddDays(28)).ToString().Substring(0,10),//"yyyy-MM-dd"
				                   conn.leer["TipoContrato"].ToString(),     
				                   "", //Sueldo base
				                   "",//DIAS              
				                   "",//SUELDO              
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS              
				                   "", //PREMIO P
				                   "",//DESPENSA				                   
				                   "",// prestamo				                   
				                   "",//d prestamo	                   
				                   "",//d imss	                   
				                   "",//d infonavit		                   
				                   "",//d ISR     
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				contador++;
			}
			conn.conexion.Close();

			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// Operadores temporales que dan de baja en periodo nominal
			sentencia = @"select oa.Fecha, o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, 
						oc.fecha_vencimiento, oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador join OperadorAltaBaja oa on 
						oa.IdOperador = o.ID where (o.tipo_empleado not in ('Externo', 'OPERADOR')) and oc.TipoContrato != 'Planta' and oa.Registro = 'INACTIVO' and oa.Fecha 
						between '"+dtpInicioAdministrativos.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinAdministrativos.Value.ToString("yyyy-MM-dd")+"' and FechaInicioContrato between '"+
						dtpInicioAdministrativos.Value.AddDays(-28).ToString("yyyy-MM-dd")+"' and '"+dtpInicioAdministrativos.Value.AddDays(-1).ToString("yyyy-MM-dd")+"' and oc.id not in("+id_c+") order by nombre";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporteAdministrativos.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),
				                   conn.leer["Fecha"].ToString().Substring(0,10),
				                   conn.leer["TipoContrato"].ToString(),
				                   "", //Sueldo base
				                   "",//DIAS
				                   "",//SUELDO
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS
				                   "", //PREMIO P
				                   "",//DESPENSA  
				                   "",// prestamo
				                   "",//d prestamo
				                   "",//d imss
				                   "",//d infonavit
				                   "",//d ISR
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				contador++;
			}
			conn.conexion.Close();			
			
			id_c = "";
			for(int x=0; x<ID_contrato.Count; x++){
				if(x==0)
					id_c = ID_contrato[x];
				if(x>0 && x<=ID_contrato.Count)
					id_c = id_c + ", "+ ID_contrato[x];
			}
			
			if(id_c == "")
			   id_c = "0";
				
			// operadores de planta que se den de baja dentro del periodo nominal 
			sentencia = @"select oa.Fecha, o.ID, OC.ID AS CONTRATO, o.tipo_empleado, o.Alias, o.Apellido_Pat +' '+ o.Apellido_Mat +' '+o.Nombre nombre, oc.FechaInicioContrato, 
						oc.fecha_vencimiento, oc.NombrePatron, oc.TipoContrato from OPERADOR o join OperadorContrato oc on o.ID = oc.IdOperador join OperadorAltaBaja oa on 
						oa.IdOperador = o.ID where (o.tipo_empleado not in ('Externo', 'OPERADOR')) and oc.TipoContrato = 'Planta' and oa.Registro = 'INACTIVO' and oa.Fecha 
						between '"+dtpInicioAdministrativos.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinAdministrativos.Value.ToString("yyyy-MM-dd")+"' and oc.id not in("+id_c+") order by nombre";
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgReporteAdministrativos.Rows.Add(conn.leer["ID"].ToString(),
				                   conn.leer["CONTRATO"].ToString(),
				                   contador+1,
				                   conn.leer["NombrePatron"].ToString(),
				                   "",// estatus
				                   "",
				                   "",//cuenta
				                   conn.leer["tipo_empleado"].ToString(),
				                   conn.leer["nombre"].ToString(),
				                   conn.leer["FechaInicioContrato"].ToString().Substring(0,10),
				                   conn.leer["Fecha"].ToString().Substring(0,10),
				                   conn.leer["TipoContrato"].ToString(),
				                   "", //Sueldo base
				                   "",//DIAS
				                   "",//SUELDO
				                   "", //SUBSIDIO EMPLEO
				                   "",//PREMIO ASIS
				                   "", //PREMIO P
				                   "",//DESPENSA  
				                   "",// prestamo
				                   "",//d prestamo
				                   "",//d imss
				                   "",//d infonavit
				                   "",//d ISR
				                   "", //neto a pagar
				                   "", //neto real
				                   "", //trasnfer
				                   "", //deposito
				                   "",//cheque
				                   "",//efectivo
				                   conn.leer["Alias"].ToString(),
				                   "1");//numero PATRO
				contador++;
			}
			conn.conexion.Close();
			
			DatosCompletaReporteAdministrativo();		
			dgReporteAdministrativos.ClearSelection();
		}	
		
		private void DatosCompletaReporteAdministrativo(){
			string consulta = "";
			TimeSpan ti = Convert.ToDateTime(dtpFinAdministrativos.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy")) ;
			int diasT = ti.Days + 1;	
						
			for(int x=0; x<dgReporteAdministrativos.Rows.Count-1; x++){
				for(int y=1; y<dgReporteAdministrativos.Rows.Count; y++){
					if(dgReporteAdministrativos[8,x].Value.ToString() == dgReporteAdministrativos[8,y].Value.ToString() && dgReporteAdministrativos[3,x].Value.ToString() != dgReporteAdministrativos[3,y].Value.ToString()){
						dgReporteAdministrativos[31,x].Value = "2";
						dgReporteAdministrativos[31,y].Value = "2";
					}						
				}
			}
			
			for(int x=0; x<dgReporteAdministrativos.Rows.Count; x++){
					///////////////////////////////////////////////////////////////  BAJAS  ////////////////////////////////////////////////////////////					
					consulta = @"select Fecha from OperadorAltaBaja where Registro = 'INACTIVO' and Fecha between '"+dtpInicioAdministrativos.Value.AddDays(1).ToString("yyyy/MM/dd")
								+"' and '"+dtpFinAdministrativos.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and IdOperador = "+dgReporteAdministrativos[0,x].Value+" order by Fecha desc";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){					
						dgReporteAdministrativos[10,x].Value = conn.leer["Fecha"].ToString().Substring(0,10);
						dgReporteAdministrativos[11,x].Value = dgReporteAdministrativos[11,x].Value.ToString() +" BAJA";
					}
					conn.conexion.Close();					
					
					///////////////////////////////////////////////////////////  ESTATUS OPERADOR ///////////////////////////////////////////////////////////
					if(dgReporteAdministrativos[30,x].Value.ToString().Contains("BAJA"))
						dgReporteAdministrativos[4,x].Value = "BAJA";
					else
						dgReporteAdministrativos[4,x].Value = "ACTIVO";
										
					///////////////////////////////////////////////////////////////  TARJETA ///////////////////////////////////////////////////////////////
					dgReporteAdministrativos[6,x].Value = conC.ReturnNumero(dgReporteAdministrativos[0,x].Value.ToString());
					
					if(dgReporteAdministrativos[6,x].Value.ToString().Contains("Vacío")){						
						dgReporteAdministrativos[5,x].Value = "NO TIENE TARJETA";
						dgReporteAdministrativos[5,x].Style.BackColor = Color.LightPink;
					}else{						
						dgReporteAdministrativos[5,x].Value = "TARJETA";
					}
					
					/////////////////////////////////////////////////////////////  CALCULO DIAS /////////////////////////////////////////////////////////////
					if(Convert.ToDateTime(dgReporteAdministrativos[9,x].Value) >= Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy")) && Convert.ToDateTime(dgReporteAdministrativos[9,x].Value) 
					   <= Convert.ToDateTime(dtpFinAdministrativos.Value.ToString("dd/MM/yyyy")) && (!dgReporteAdministrativos[11,x].Value.ToString().Contains("BAJA")) ){
						TimeSpan ts = Convert.ToDateTime(dtpFinAdministrativos.Value.ToString("dd/MM/yyyy")) -  Convert.ToDateTime(dgReporteAdministrativos[9,x].Value);
						int differenceInDays = ts.Days + 1;
						dgReporteAdministrativos[13,x].Value = differenceInDays.ToString();
					}						
					else if(Convert.ToDateTime(dgReporteAdministrativos[10,x].Value) > Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy")) && Convert.ToDateTime(dgReporteAdministrativos[10,x].Value) 
					        <= Convert.ToDateTime(dtpFinAdministrativos.Value.ToString("dd/MM/yyyy")) && dgReporteAdministrativos[11,x].Value.ToString() != "Planta" && (!dgReporteAdministrativos[11,x].Value.ToString().Contains("BAJA")) 
					        && dgReporteAdministrativos[13,x].Value.ToString() == ""){
						TimeSpan ts = Convert.ToDateTime(dgReporteAdministrativos[10,x].Value) - Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy"));
						int differenceInDays = ts.Days + 1;
						dgReporteAdministrativos[13,x].Value = differenceInDays.ToString();					
					}				
					else if(Convert.ToDateTime(dgReporteAdministrativos[10,x].Value) == Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy")) && dgReporteAdministrativos[13,x].Value.ToString() == ""){
						dgReporteAdministrativos[13,x].Value =  "1";
					
					}			
					else if(Convert.ToDateTime(dgReporteAdministrativos[9,x].Value) <= Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy")) && dgReporteAdministrativos[11,x].Value.ToString() == "Planta"
					       && dgReporteAdministrativos[13,x].Value.ToString() == ""){
						dgReporteAdministrativos[13,x].Value = diasT.ToString();					
					}				
					else if(dgReporteAdministrativos[11,x].Value.ToString().Contains("BAJA") && Convert.ToDateTime(dgReporteAdministrativos[9,x].Value) >= Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy")) &&
					       Convert.ToDateTime(dgReporteAdministrativos[9,x].Value) <= Convert.ToDateTime(dgReporteAdministrativos[10,x].Value) && dgReporteAdministrativos[13,x].Value.ToString() == ""){
						TimeSpan ts = Convert.ToDateTime(dgReporteAdministrativos[10,x].Value) - Convert.ToDateTime(dgReporteAdministrativos[9,x].Value);
						int differenceInDays = ts.Days + 1;
						dgReporteAdministrativos[13,x].Value = differenceInDays.ToString();
					
					}					
					else if(dgReporteAdministrativos[11,x].Value.ToString().Contains("BAJA") && dgReporteAdministrativos[13,x].Value.ToString() == ""){
						TimeSpan ts = Convert.ToDateTime(dgReporteAdministrativos[10,x].Value) - Convert.ToDateTime(dtpInicioAdministrativos.Value.ToString("dd/MM/yyyy"));
						int differenceInDays = ts.Days + 1;
						dgReporteAdministrativos[13,x].Value = differenceInDays.ToString();
					}			
					else if(dgReporteAdministrativos[13,x].Value.ToString() == ""){
						dgReporteAdministrativos[13,x].Value = diasT.ToString();
					}					
					//////////////////////////////////////////////////////////  INCAPACIDADES //////////////////////////////////////////////////////////
					if(dgReporteAdministrativos[13,x].Value.ToString() != "" && dgReporteAdministrativos[13,x].Value.ToString() != " ")
						dgReporteAdministrativos[13,x].Value = Convert.ToInt32(dgReporteAdministrativos[13,x].Value) - DiasIncapacidades(dgReporteAdministrativos[0,x].Value.ToString(), dtpInicioAdministrativos.Value, dtpFinAdministrativos.Value);
					
					//////////////////////////////////////////////////////////  DESCUENTOS //////////////////////////////////////////////////////////
					consulta = @"select ISR, IMSS, INFONAVIT, SUELDO_BASE, TELCEL, aguinaldo, Retener, Compensacion, prima_v from SUELDO where ID_OPERADOR = "
								+dgReporteAdministrativos[0,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){			
							dgReporteAdministrativos[12,x].Value = conn.leer["SUELDO_BASE"].ToString();				
							try{ dgReporteAdministrativos[21,x].Value = Math.Round(((Convert.ToDouble(conn.leer["IMSS"])/7) * (Convert.ToInt32(dgReporteAdministrativos[13,x].Value)) ), 2).ToString(); }	catch{}
							try{ dgReporteAdministrativos[22,x].Value = Math.Round(((Convert.ToDouble(conn.leer["INFONAVIT"])/7) * (Convert.ToInt32(dgReporteAdministrativos[13,x].Value)) ), 2).ToString(); }	catch{}
							try{ dgReporteAdministrativos[23,x].Value = Math.Round(((Convert.ToDouble(conn.leer["ISR"])/7) * (Convert.ToInt32(dgReporteAdministrativos[13,x].Value)) ),2).ToString(); }	catch{}
						}else{
							dgReporteAdministrativos[12,x].Value = "0";
							dgReporteAdministrativos[21,x].Value = "0";
							dgReporteAdministrativos[22,x].Value = "0";
							dgReporteAdministrativos[23,x].Value = "0";	
						}
					conn.conexion.Close();
					
					/////////////////////////////////////////////////////////////  PERCEPCIONES /////////////////////////////////////////////////////////////
					if(dgReporteAdministrativos[12,x].Value.ToString() != "" && dgReporteAdministrativos[13,x].Value.ToString() != "")	
						dgReporteAdministrativos[14,x].Value = Math.Round(((Convert.ToDouble(dgReporteAdministrativos[13,x].Value)) * ((Convert.ToDouble(dgReporteAdministrativos[12,x].Value))/Convert.ToDouble(txtIntegracion.Text))), 2); //SUELDO NOMINAL FISCAL
					else
						dgReporteAdministrativos[14,x].Value = "0";
					
					if(dgReporteAdministrativos[14,x].Value.ToString() != ""){
						dgReporteAdministrativos[15,x].Value = "0"; //SUBSIDIO EMPLEO
						dgReporteAdministrativos[16,x].Value = Math.Round(((Convert.ToDouble(dgReporteAdministrativos[14,x].Value) * 0.1)), 2); //PRMEIO A
						dgReporteAdministrativos[17,x].Value = Math.Round(((Convert.ToDouble(dgReporteAdministrativos[14,x].Value) * 0.1)), 2); //PREMIO P   		
						dgReporteAdministrativos[18,x].Value = Math.Round((Convert.ToDouble(txtSalariominimo.Text) * 0 * Convert.ToInt16(dgReporteAdministrativos[13,x].Value) ), 2); //DESPENSA
					}else{
						
					}
					///////////////////////////////////////////////////////////  CALCULO FISCAL ////////////////////////////////////////////////////////////
					calculoSUBEmpleadoAdministrativos(x);
				
					////////////////////////////////////////////////////////////  SUELDO FISCAL ////////////////////////////////////////////////////////////
					if(dgReporteAdministrativos[14,x].Value.ToString() != "" && dgReporteAdministrativos[15,x].Value.ToString() != "" && dgReporteAdministrativos[16,x].Value.ToString() != "" && 
					   dgReporteAdministrativos[17,x].Value.ToString() != "" && dgReporteAdministrativos[18,x].Value.ToString() != ""){
						dgReporteAdministrativos[24,x].Value = (Math.Round(((Convert.ToDouble(dgReporteAdministrativos[14,x].Value) + Convert.ToDouble(dgReporteAdministrativos[15,x].Value) + Convert.ToDouble(dgReporteAdministrativos[16,x].Value) +
						                        Convert.ToDouble(dgReporteAdministrativos[17,x].Value) + Convert.ToDouble(dgReporteAdministrativos[18,x].Value)) - 
						                        (Convert.ToDouble(dgReporteAdministrativos[21,x].Value) + Convert.ToDouble(dgReporteAdministrativos[22,x].Value) + Convert.ToDouble(dgReporteAdministrativos[23,x].Value))),2)).ToString();
					}else{
						dgReporteAdministrativos[24,x].Value = "0";
					}		
															
					///////////////////////////////////////////////////////////////  PRESTAMOS  ////////////////////////////////////////////////////////////
					consulta = @"select DT.FECHA, D.DESCRIPCION, DT.IMPORTE, D.TIPO, d.IMPORTE_TOTAL from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O 
								where D.ID = DT.ID_DESCUENTO AND O.ID = D.ID_OPERADOR and FLUJO!='3' and FLUJO!='5' AND (DESCRIPCION like '%PRESTAMO%' 
								OR DESCRIPCION like '%CHOQUE%') and DT.FECHA between '"+dtpInicioAdministrativos.Value.AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+
								dtpFinAdministrativos.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR = "+dgReporteAdministrativos[0,x].Value+" order by DT.FECHA";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){					
							dgReporteAdministrativos[19,x].Value = conn.leer["IMPORTE_TOTAL"].ToString();						
							dgReporteAdministrativos[20,x].Value = conn.leer["IMPORTE"].ToString();	
						}else{
							dgReporteAdministrativos[19,x].Value = "0";
							dgReporteAdministrativos[20,x].Value = "0";
						}
					conn.conexion.Close();
					
					///////////////////////////////////////////////////////////////  SUELDO REAL ///////////////////////////////////////////////////////////////					
					dgReporteAdministrativos[25,x].Value = (Convert.ToDouble(connCT.RetornaSueldo(dgReporteAdministrativos[0,x].Value.ToString())) / 7) * Convert.ToInt32(dgReporteAdministrativos[13,x].Value); //Sueldo Real
			}
			
			// Enumera y elimina Registros mal
			dgReporteAdministrativos.Sort(dgReporteAdministrativos.Columns[8], ListSortDirection.Ascending);
			dgReporteAdministrativos.Sort(dgReporteAdministrativos.Columns[3], ListSortDirection.Ascending);
			
			int o = 1;
			for(int x=0; x<dgReporteAdministrativos.Rows.Count; x++){
				try{				
													
					///////////////////////////////////////////////////////////////  BAJAS  ////////////////////////////////////////////////////////////
					consulta = @"select Fecha from OperadorAltaBaja where Registro = 'INACTIVO' and Fecha between '"+dtpInicioAdministrativos.Value.AddDays(-29).ToString("yyyy/MM/dd")
								+"' and '"+dtpInicioAdministrativos.Value.AddDays(-1).ToString("yyyy/MM/dd")+"' and IdOperador = "+dgReporteAdministrativos[0,x].Value+" order by Fecha desc";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgReporteAdministrativos.Rows.RemoveAt(x);				
					}			
					conn.conexion.Close();
					dgReporteAdministrativos[2,x].Value = (o).ToString();
					o++;
				}catch(Exception){
				}
			}
			
			//////////////////////////////////////////////////////////////  DEPOSITOS  ////////////////////////////////////////////////////////////
			CalculosPagoAdministrativos();
			
			dgReporteAdministrativos.ClearSelection();
		}
		
		private void calculoSUBEmpleadoAdministrativos(int y){
			dataTotalesISPT14.Rows[0].Cells[1].Value = (Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[14].Value) + Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[16].Value) + 
			                                            Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[17].Value) + Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[18].Value))/
														(Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[13].Value));
			
			double baseGravable = ((Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[14].Value) + Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[16].Value) + 
			                        Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[17].Value) + Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[18].Value)))/
									(Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[13].Value));
					
				for(int x=0;x<dataTarifas14.Rows.Count;x++){
					if(((Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value))<=(baseGravable))&&((Convert.ToDouble(dataTarifas14.Rows[x].Cells[1].Value))>=(baseGravable))){
					   	dataTotalesISPT14.Rows[0].Cells[1].Value = (baseGravable);
					   	dataTotalesISPT14.Rows[1].Cells[1].Value = (Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value));
					   	dataTotalesISPT14.Rows[2].Cells[1].Value = (baseGravable)-(Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value));
					   	dataTotalesISPT14.Rows[3].Cells[1].Value = dataTarifas14.Rows[x].Cells[3].Value;
					    dataTotalesISPT14.Rows[4].Cells[1].Value =  (Convert.ToDouble(dataTarifas14.Rows[x].Cells[3].Value))*(Convert.ToDouble(dataTotalesISPT14.Rows[2].Cells[1].Value));
					    dataTotalesISPT14.Rows[5].Cells[1].Value = dataTarifas14.Rows[x].Cells[2].Value;
					   	dataTotalesISPT14.Rows[6].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[4].Cells[1].Value))	+ (Convert.ToDouble(dataTotalesISPT14.Rows[5].Cells[1].Value));
					   	break;
					}
				}
				
				for(int x=0;x<dataSubsidio14.Rows.Count;x++){
					if(((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[0].Value))<=(baseGravable))&&((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[1].Value))>=(baseGravable))){
					   	dataTotalesISPT14.Rows[7].Cells[1].Value = dataSubsidio14.Rows[x].Cells[2].Value;
					   	dataTotalesISPT14.Rows[8].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[6].Cells[1].Value)) - (Convert.ToDouble(dataTotalesISPT14.Rows[7].Cells[1].Value));
					  	
					   	if((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))>0)
					   		dataTotalesISPT14.Rows[9].Cells[1].Value = 0;
					  	else
					  		dataTotalesISPT14.Rows[9].Cells[1].Value = Math.Round((((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))*(Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[13].Value)))*(-1)),2);
					  	
					  	if((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))>0)
					  		dataTotalesISPT14.Rows[8].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))*(Convert.ToDouble(dgReporteAdministrativos.Rows[y].Cells[13].Value));
					  	else
					  		dataTotalesISPT14.Rows[8].Cells[1].Value = 0; 
					  	break;
					}
				}
				dgReporteAdministrativos.Rows[y].Cells[15].Value = Math.Round((Convert.ToDouble(dataTotalesISPT14.Rows[9].Cells[1].Value)), 2);
				
				if(dgReporteAdministrativos.Rows[y].Cells[13].Value.ToString() == "0")
					dgReporteAdministrativos.Rows[y].Cells[15].Value = "0";
		}
		
		private void ReporteAdministrativos(){
			if(dgReporteAdministrativos.Rows.Count>0){
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
				string nombreA = "NOMINA DEL "+dtpInicioAdministrativos.Value.ToString("dd")+" AL "+dtpFinAdministrativos.Value.ToString("dd")+" DE "+
								dtpFinAdministrativos.Value.ToString("MMMM").ToUpper()+" "+dtpFinAdministrativos.Value.ToString("yyyy")+" ADMINISTRATIVOS";
					
				ExcelApp.Cells[2,  4] 	= nombreA;
				
				int i = 4;
				ExcelApp.Cells[i,  1] 	= "NUMERO";
				ExcelApp.Cells[i,  2] 	= "PATRON";
				ExcelApp.Cells[i,  3] 	= "ESTATUS";
				ExcelApp.Cells[i,  4] 	= "CON O SIN TARJETA";
				ExcelApp.Cells[i,  5] 	= "NO. CUENTA";
				ExcelApp.Cells[i,  6] 	= "PUESTO";
				ExcelApp.Cells[i,  7] 	= "NOMBRE";
				ExcelApp.Cells[i,  8] 	= "SUELDO BASE";
				ExcelApp.Cells[i,  9] 	= "DIAS";
				ExcelApp.Cells[i,  10] 	= "SUELDO";
				ExcelApp.Cells[i,  11] 	= "SUB. EMPLEO";
				ExcelApp.Cells[i,  12] 	= "PREMIO A.";
				ExcelApp.Cells[i,  13] 	= "PREMIO P.";
				ExcelApp.Cells[i,  14] 	= "DESPENSA";
				ExcelApp.Cells[i,  15] 	= "TOTAL PERCEPCIONES";
				ExcelApp.Cells[i,  16] 	= "DESC. PRESTAMO";
				ExcelApp.Cells[i,  17] 	= "IMSS";
				ExcelApp.Cells[i,  18] 	= "INFONAVIT";
				ExcelApp.Cells[i,  19] 	= "ISR";
				ExcelApp.Cells[i,  20] 	= "TOTAL DEDUCCIONES";
				ExcelApp.Cells[i,  21] 	= "NETO A PAGAR";
				ExcelApp.Cells[i,  22] 	= "NETO A PAGAR REAL";
				ExcelApp.Cells[i,  23] 	= "T.B.";
				ExcelApp.Cells[i,  24] 	= "DEPOSITO";
				ExcelApp.Cells[i,  25] 	= "CHEQUE";
				ExcelApp.Cells[i,  26] 	= "EFECTIVO";
				ExcelApp.Cells[i,  27] 	= "ALIAS";
				ExcelApp.Cells[i,  28] 	= "N° PATRONES";
				i++;
				string patro = "";				
				int pb = (int) 100 / dgReporteAdministrativos.Rows.Count;
				refPrincipal.progressbarPrin.Value = 1;
				
				for(int y=0; y<dgReporteAdministrativos.Rows.Count; y++){							
						if (refPrincipal.progressbarPrin.Value<100)					
	                		refPrincipal.progressbarPrin.Value += pb;
						
						if(dgReporteAdministrativos[3,y].Value.ToString().Contains("Alma Selene Arriaga Garcia"))
							patro = "ALMA";
						if(dgReporteAdministrativos[3,y].Value.ToString().Contains("Juana Garcia Gamboa"))
							patro = "JUANA";
						if(dgReporteAdministrativos[3,y].Value.ToString().Contains("Luis Arriaga Ruiz"))
							patro = "LUIS";
						if(dgReporteAdministrativos[3,y].Value.ToString().Contains("Luis Dario Arriaga Garcia"))
							patro = "DARIO";
						if(dgReporteAdministrativos[3,y].Value.ToString().Contains("Ray Kenny Arriaga Garcia"))
							patro = "KENNY";
											
						ExcelApp.Cells[i,  1]	= dgReporteAdministrativos[2,y].Value.ToString();
						ExcelApp.Cells[i,  2]	= patro;
						ExcelApp.Cells[i,  3]	= dgReporteAdministrativos[4,y].Value.ToString();
						ExcelApp.Cells[i,  4]	= dgReporteAdministrativos[5,y].Value.ToString();
						ExcelApp.Cells[i,  5]	= dgReporteAdministrativos[6,y].Value.ToString();					
						ExcelApp.Cells[i,  6]	= ((dgReporteAdministrativos[7,y].Value.ToString()=="OPERADOR")? "OP" : dgReporteAdministrativos[7,y].Value.ToString().ToUpper());
						ExcelApp.Cells[i,  7]	= dgReporteAdministrativos[8,y].Value.ToString();
						ExcelApp.Cells[i,  8]	= dgReporteAdministrativos[12,y].Value.ToString();
						ExcelApp.Cells[i,  9]	= dgReporteAdministrativos[13,y].Value.ToString();
						ExcelApp.Cells[i,  10]	= dgReporteAdministrativos[14,y].Value.ToString();
						ExcelApp.Cells[i,  11]	= dgReporteAdministrativos[15,y].Value.ToString();
						ExcelApp.Cells[i,  12]	= dgReporteAdministrativos[16,y].Value.ToString();
						ExcelApp.Cells[i,  13]	= dgReporteAdministrativos[17,y].Value.ToString();
						ExcelApp.Cells[i,  14]	= dgReporteAdministrativos[18,y].Value.ToString();
						ExcelApp.Cells[i,  15]	= (Convert.ToDouble(dgReporteAdministrativos[24,y].Value) + Convert.ToDouble(dgReporteAdministrativos[21,y].Value) + Convert.ToDouble(dgReporteAdministrativos[22,y].Value) + Convert.ToDouble(dgReporteAdministrativos[23,y].Value) ); // TOTAL P
						ExcelApp.Cells[i,  16]	= dgReporteAdministrativos[20,y].Value.ToString();
						ExcelApp.Cells[i,  17]	= dgReporteAdministrativos[21,y].Value.ToString();
						ExcelApp.Cells[i,  18]	= dgReporteAdministrativos[22,y].Value.ToString();
						ExcelApp.Cells[i,  19]	= dgReporteAdministrativos[23,y].Value.ToString();
						ExcelApp.Cells[i,  20]	= ( Convert.ToDouble(dgReporteAdministrativos[21,y].Value) + Convert.ToDouble(dgReporteAdministrativos[22,y].Value) + Convert.ToDouble(dgReporteAdministrativos[23,y].Value) ).ToString(); // TOTAL D
						ExcelApp.Cells[i,  21]	= Convert.ToDouble(dgReporteAdministrativos[24,y].Value).ToString(); // NOMINA FISCAL
						ExcelApp.Cells[i,  22]	= dgReporteAdministrativos[25,y].Value.ToString();
						ExcelApp.Cells[i,  23]	= dgReporteAdministrativos[26,y].Value.ToString();
						ExcelApp.Cells[i,  24]	= dgReporteAdministrativos[27,y].Value.ToString();
						ExcelApp.Cells[i,  25]	= dgReporteAdministrativos[28,y].Value.ToString();
						ExcelApp.Cells[i,  26]	= dgReporteAdministrativos[29,y].Value.ToString();
						ExcelApp.Cells[i,  27]	= dgReporteAdministrativos[30,y].Value.ToString();
						ExcelApp.Cells[i,  28]	= ((dgReporteAdministrativos[31,y].Value.ToString()=="2")? "DOS PATRONES" : "");
						i++;					
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
				CuadroDialogo.FileName = "CARGA " + nombreA;
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
	
		private void CalculosPagoAdministrativos(){
			for(int x=0; x<dgReporteAdministrativos.Rows.Count; x++){
				try{	
					if(!dgReporteAdministrativos[6,x].Value.ToString().Contains("Vacío")){ // valida tiene tarjeta
						if(dgReporteAdministrativos[31,x].Value.ToString() == "1"){ // valida un patron
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) >= Convert.ToDouble(dgReporteAdministrativos[24,x].Value)){ // valida que el sueldo real sea => al suendo fiscal
								dgReporteAdministrativos[26,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
								dgReporteAdministrativos[27,x].Value = (Convert.ToDouble(dgReporteAdministrativos[25,x].Value) - Convert.ToDouble(dgReporteAdministrativos[24,x].Value)).ToString();
								dgReporteAdministrativos[28,x].Value = "0";
								dgReporteAdministrativos[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < Convert.ToDouble(dgReporteAdministrativos[24,x].Value) && Convert.ToDouble(dgReporteAdministrativos[25,x].Value) > 0){ // valida que el sueldo real sea => al suendo fiscal
								dgReporteAdministrativos[26,x].Value = dgReporteAdministrativos[25,x].Value.ToString();
								dgReporteAdministrativos[27,x].Value = "0";
								dgReporteAdministrativos[28,x].Value = (Convert.ToDouble(dgReporteAdministrativos[24,x].Value) - Convert.ToDouble(dgReporteAdministrativos[25,x].Value)).ToString();
								dgReporteAdministrativos[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < Convert.ToDouble(dgReporteAdministrativos[24,x].Value) && Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < 0){ // valida que el sueldo real sea => al suendo fiscal
								dgReporteAdministrativos[26,x].Value = "0";
								dgReporteAdministrativos[27,x].Value = "0";
								dgReporteAdministrativos[28,x].Value = (Convert.ToDouble(dgReporteAdministrativos[24,x].Value)).ToString();
								dgReporteAdministrativos[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) == 0){ // valida que el sueldo real sea == 0
								dgReporteAdministrativos[26,x].Value = "0";
								dgReporteAdministrativos[27,x].Value = "0";
								dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
								dgReporteAdministrativos[29,x].Value = "0";
							}							
						}
						if(dgReporteAdministrativos[31,x].Value.ToString() == "2"){ // valida dos patron							
							for(int y = 0; y<dgReporteAdministrativos.Rows.Count; y++){
								if(dgReporteAdministrativos[8,x].Value.ToString() == dgReporteAdministrativos[8,y].Value.ToString() && dgReporteAdministrativos[3,x].Value.ToString() != dgReporteAdministrativos[3,y].Value.ToString()){
									if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) >= (Convert.ToDouble(dgReporteAdministrativos[24,x].Value) + Convert.ToDouble(dgReporteAdministrativos[24,y].Value))){ // valida que el sueldo real sea => al suendo fiscal
										if(dgReporteAdministrativos[29,x].Value.ToString() != "0" && dgReporteAdministrativos[29,y].Value.ToString() != "0"){
											dgReporteAdministrativos[25,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
											dgReporteAdministrativos[26,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
											dgReporteAdministrativos[27,x].Value = "0";
											dgReporteAdministrativos[28,x].Value = "0";
											dgReporteAdministrativos[29,x].Value = "0";
											
											dgReporteAdministrativos[25,y].Value = (Convert.ToDouble(dgReporteAdministrativos[25,y].Value) - Convert.ToDouble(dgReporteAdministrativos[24,x].Value)).ToString();
											dgReporteAdministrativos[26,y].Value = dgReporteAdministrativos[24,y].Value.ToString();
											dgReporteAdministrativos[27,y].Value = (Convert.ToDouble(dgReporteAdministrativos[25,y].Value) - (Convert.ToDouble(dgReporteAdministrativos[24,y].Value)  )).ToString();
											dgReporteAdministrativos[28,y].Value = "0";
											dgReporteAdministrativos[29,y].Value = "0";
										}
									}
									if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < (Convert.ToDouble(dgReporteAdministrativos[24,x].Value) + Convert.ToDouble(dgReporteAdministrativos[24,y].Value))){ // valida que el sueldo real sea =< al suendo fiscal
										if(dgReporteAdministrativos[29,x].Value.ToString() != "0" && dgReporteAdministrativos[29,y].Value.ToString() != "0"){
											dgReporteAdministrativos[26,x].Value = "0";
											dgReporteAdministrativos[27,x].Value = "0";
											dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
											dgReporteAdministrativos[29,x].Value = "0";
											
											dgReporteAdministrativos[26,y].Value = "0";
											dgReporteAdministrativos[27,y].Value = "0";
											dgReporteAdministrativos[28,y].Value = dgReporteAdministrativos[24,y].Value.ToString();
											dgReporteAdministrativos[29,y].Value = "0";
										}
									}
								}
							}							
						}
					}
					
					if(dgReporteAdministrativos[6,x].Value.ToString().Contains("Vacío")){ // valida no tiene tarjeta
						if(dgReporteAdministrativos[31,x].Value.ToString() == "1"){ // valida un patron
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) >= Convert.ToDouble(dgReporteAdministrativos[24,x].Value)){ // valida que el sueldo real sea => al suendo fiscal
								dgReporteAdministrativos[26,x].Value = "0";
								dgReporteAdministrativos[27,x].Value = "0";
								dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
								dgReporteAdministrativos[29,x].Value = dgReporteAdministrativos[25,x].Value.ToString();
							}
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < Convert.ToDouble(dgReporteAdministrativos[24,x].Value) && Convert.ToDouble(dgReporteAdministrativos[25,x].Value) > 0){ // valida que el sueldo real sea => al suendo fiscal
								dgReporteAdministrativos[26,x].Value = "0";
								dgReporteAdministrativos[27,x].Value = "0";
								dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
								dgReporteAdministrativos[29,x].Value = dgReporteAdministrativos[25,x].Value.ToString();
							}
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < Convert.ToDouble(dgReporteAdministrativos[24,x].Value) && Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < 0){ // valida que el sueldo real sea =< al suendo fiscal
								dgReporteAdministrativos[26,x].Value = "0";
								dgReporteAdministrativos[27,x].Value = "0";
								dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
								dgReporteAdministrativos[29,x].Value = "0";
							}
							if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) == 0){ // valida que el sueldo real sea == 0
								dgReporteAdministrativos[26,x].Value = "0";
								dgReporteAdministrativos[27,x].Value = "0";
								dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
								dgReporteAdministrativos[29,x].Value = "0";
							}							
						}
						if(dgReporteAdministrativos[31,x].Value.ToString() == "2"){ // valida dos patron
							for(int y = 0; y<dgReporteAdministrativos.Rows.Count; y++){
								if(dgReporteAdministrativos[8,x].Value.ToString() == dgReporteAdministrativos[8,y].Value.ToString() && dgReporteAdministrativos[3,x].Value.ToString() != dgReporteAdministrativos[3,y].Value.ToString()){
									if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) >= (Convert.ToDouble(dgReporteAdministrativos[24,x].Value) + Convert.ToDouble(dgReporteAdministrativos[24,y].Value))){ // valida que el sueldo real sea => al suendo fiscal
										if(dgReporteAdministrativos[26,x].Value.ToString() != "0" && dgReporteAdministrativos[26,y].Value.ToString() != "0"){
											dgReporteAdministrativos[25,x].Value = "-";
											dgReporteAdministrativos[26,x].Value = "0";
											dgReporteAdministrativos[27,x].Value = "0";
											dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
											dgReporteAdministrativos[29,x].Value = "0";
											
											dgReporteAdministrativos[26,y].Value = "0";
											dgReporteAdministrativos[27,y].Value = "0";
											dgReporteAdministrativos[28,y].Value = dgReporteAdministrativos[24,y].Value.ToString();
											dgReporteAdministrativos[29,y].Value = dgReporteAdministrativos[25,y].Value.ToString();
											
										}
									}	
									if(Convert.ToDouble(dgReporteAdministrativos[25,x].Value) < (Convert.ToDouble(dgReporteAdministrativos[24,x].Value) + Convert.ToDouble(dgReporteAdministrativos[24,y].Value))){ // valida que el sueldo real sea =< al suendo fiscal
										if(dgReporteAdministrativos[26,x].Value.ToString() != "0" && dgReporteAdministrativos[26,y].Value.ToString() != "0"){											
											dgReporteAdministrativos[26,x].Value = "0";
											dgReporteAdministrativos[27,x].Value = "0";
											dgReporteAdministrativos[28,x].Value = dgReporteAdministrativos[24,x].Value.ToString();
											dgReporteAdministrativos[29,x].Value = "0";
											
											dgReporteAdministrativos[26,y].Value = "0";
											dgReporteAdministrativos[27,y].Value = "0";
											dgReporteAdministrativos[28,y].Value = dgReporteAdministrativos[24,y].Value.ToString();
											dgReporteAdministrativos[29,y].Value = "0";											
										}
									}									
								}
							}					
						}
					}
				}catch(Exception){
				}
			}
		}
		#endregion
				
		#region BOTONES
		void BtnReporteAdministrativosClick(object sender, EventArgs e)
		{			
			ReporteAdministrativos();
		}
		#endregion					
		
		void DgReporteCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
