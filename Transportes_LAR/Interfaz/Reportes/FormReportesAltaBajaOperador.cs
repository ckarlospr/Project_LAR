using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormReportesAltaBajaOperador : Form
	{		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.SQL_Conexion conn2 = new Conexion_Servidor.SQL_Conexion();
		Interfaz.FormPrincipal principal = null;
		#endregion
		
		#region VARIABLES
		//int acumulador = 0;
		//int progreso = 1;
		#endregion
		
		#region CONSTRUCTOR
		public FormReportesAltaBajaOperador(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INICIO - FIN
		void FormReportesAltaBajaOperadorLoad(object sender, EventArgs e)
		{
			
		}
		
		void FormReportesAltaBajaOperadorFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.ABOperador = false;
		}
		#endregion
		
		#region EVENTOS
		void BtnPostventaClick(object sender, EventArgs e)
		{
			reporteAB();
		}
		
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			dtCorte.MinDate = dtInicio.Value;
		}
		#endregion
		
		#region METODOS
		private void reporteAB(){
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			nmExcel.Worksheet newWorksheet;
			newWorksheet = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			newWorksheet.Name = "Altas - Bajas";
			nmExcel.Range cells =  newWorksheet.Cells;
				
			cells[1,  1] = "ALIAS";
			cells[1,  2] = "NOMBRE";
			cells[1,  3] = "FECHA DE ALTA";
			cells[1,  4] = "FECHA DE BAJA";
			
			int i = 1;
			string consulta = @"SELECT * FROM OPERADOR WHERE tipo_empleado = 'OPERADOR' AND Estatus = '1' and Alias!='Admvo' and Alias!='ADMINOO'  AND ID IN (SELECT IdOperador FROM OperadorAltaBaja OP WHERE op.Registro = 'ACTIVO' and OP.Fecha between '"
								+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"')";
			
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				cells[i,  1]	= 	conn.leer["alias"].ToString();
				cells[i,  2]	= 	conn.leer["Apellido_Pat"].ToString() +" "+ conn.leer["Apellido_Mat"].ToString() +" "+conn.leer["Nombre"].ToString();
				cells[i,  3]	= 	Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(conn.leer["id"].ToString())).ToString("dd-MM-yyyy");
				cells[i,  4]	= 	( (FechaBaja(conn.leer["id"].ToString()) != "")? Convert.ToDateTime(FechaBaja(conn.leer["id"].ToString())).ToString("dd-MM-yyyy"): "");
			}
			conn.conexion.Close();			
			
			
			consulta = @"SELECT * FROM OPERADOR WHERE tipo_empleado = 'OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' AND ID IN (SELECT IdOperador FROM OperadorAltaBaja OP WHERE op.Registro != 'ACTIVO' and OP.Fecha between '"
								+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"')";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				cells[i,  1]	= 	conn.leer["alias"].ToString();
				cells[i,  2]	= 	conn.leer["Apellido_Pat"].ToString() +" "+ conn.leer["Apellido_Mat"].ToString() +" "+conn.leer["Nombre"].ToString();
				cells[i,  3]	= 	Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso2(conn.leer["id"].ToString())).ToString("dd-MM-yyyy");
				cells[i,  4]	= 	( (FechaBaja(conn.leer["id"].ToString()) != "")? Convert.ToDateTime(FechaBaja(conn.leer["id"].ToString())).ToString("dd-MM-yyyy"): "");
			}
			conn.conexion.Close();
			
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte de ALTAS - BAJAS Operadores "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
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
		
		private string FechaBaja(String id_operador)
		{
			string Fecha = "";
			conn2.getAbrirConexion(" select * from OperadorAltaBaja where Fecha between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"'  and " +
			                       "Registro != 'ACTIVO' and IdOperador = '"+id_operador+"' order by Fecha desc");
			conn2.leer=conn2.comando.ExecuteReader();
			if(conn2.leer.Read())
				Fecha = conn2.leer["Fecha"].ToString();
			conn2.conexion.Close();			
			return Fecha;
		}
		#endregion
	}
}
