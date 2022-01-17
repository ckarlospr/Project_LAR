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


namespace Transportes_LAR.Interfaz.Aptomedico
{
	public partial class FormAptoMedico : Form
	{
		#region VARIABLES
		DateTime Fecha = DateTime.Now;
		int ID_OP = 0;
		#endregion
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();		
		#endregion
		
		#region CONTRUCTORES
		public FormAptoMedico()
		{
			InitializeComponent();
		}
		
		public FormAptoMedico(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region ADAPTADORES
		void AdaptadorVigencia()
		{
			int contador = 0;
	
			dataOperador.Rows.Clear();
			dataOperador.ClearSelection();
			
			conn.getAbrirConexion("select O.ID, O.Alias, A.VIGENCIA from OPERADOR  O, APTOMEDICO A where A.ID_OPERADOR=O.ID AND O.Estatus='1' AND O.tipo_empleado='OPERADOR' and O.Alias!='Admvo' group by O.ID, O.Alias, A.VIGENCIA order by O.Alias, A.VIGENCIA");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataOperador.Rows.Add();
				dataOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataOperador.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dataOperador.Rows[contador].Cells[2].Value = conn.leer["VIGENCIA"].ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();
			
			for(int x=0; x<dataOperador.RowCount; x++)
			{
				if(dataOperador.RowCount-1>=x)
				{
					if((Convert.ToDateTime(dataOperador.Rows[x].Cells[2].Value))>(Convert.ToDateTime(Fecha.ToString().Substring(0,10))).AddDays(84))
					{
						dataOperador.Rows.RemoveAt(x);
						if(x>-1)
						{
							--x;
						}
					}
				}
			}
		}
		
		void AdaptadorApto()
		{
			int contador = 0;
	
			dataApto.Rows.Clear();
			dataApto.ClearSelection();
			
			conn.getAbrirConexion("Select A.ID, A.NUMERO, A.VIGENCIA from OPERADOR  O, APTOMEDICO A where A.ID_OPERADOR=O.ID AND O.tipo_empleado='OPERADOR' AND O.Estatus='1' and O.Alias!='Admvo' AND O.ID="+ID_OP);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataApto.Rows.Add();
				dataApto.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataApto.Rows[contador].Cells[1].Value = conn.leer["NUMERO"].ToString();
				dataApto.Rows[contador].Cells[2].Value = conn.leer["VIGENCIA"].ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();
		}
		
		private void reporteAptosMedicos(){
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();	
			ExcelApp = new nmExcel.ApplicationClass();				
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			nmExcel.Worksheet newWorksheet;
			newWorksheet = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
			newWorksheet.Name = DateTime.Now.ToString("dd-MM-yyyy");
			nmExcel.Range cells =  newWorksheet.Cells;
							
			int i = 1;
			cells[i,  1] = "Alias";
			cells[i,  2] = "Numero";
			cells[i,  3] = "Vigencia";
			
			try{
				string consulta = @"select am.*, o.Alias from APTOMEDICO am join OPERADOR o on o.id = am.ID_OPERADOR where o.Estatus = '1' order by o.Alias";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();		
				while(conn.leer.Read()){
					++i;
					try{cells[i,  1] = conn.leer["Alias"].ToString(); }catch (Exception){cells[i,  1] = "";}
					try{cells[i,  2] = conn.leer["Numero"].ToString(); }catch (Exception){cells[i,  2] = "";}
					try{cells[i,  3] = conn.leer["VIGENCIA"].ToString().Substring(0,10); }catch (Exception){cells[i, 3] = "";}
				}
				conn.conexion.Close();
			}catch(Exception){
				if(conn.conexion != null)						
					conn.conexion.Close();	
			}
				
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte Aptos Medicos "+DateTime.Now.ToString("dd-MM-yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK){
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
				
				Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Reporte Aptos Medicos "+DateTime.Now.ToString("dd-MM-yyyy")+".xlsx");
			}else{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormAptoMedicoLoad(object sender, EventArgs e)
		{
			tabControl1.SelectedIndex = 1;
			tabControl1.SelectedIndex = 0;
			AdaptadorVigencia();
			dataFaltantes.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, Alias from OPERADOR where Estatus='1'and Alias!='Admvo'and tipo_empleado!='Externo' AND tipo_empleado='OPERADOR' and ID not in (select ID_OPERADOR from APTOMEDICO) order by Alias");
			btnModificar.Enabled = false;
			btnRemoverLicencia.Enabled = false;
		}
		
		void FormAptoMedicoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.aptomedico = false;
			principal.toolAptoMedico.Enabled = true;
			principal.toolAptoMedico.Visible = true;
		}
		#endregion
		
		#region DATOS
		void DataOperadorCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			ID_OP = 0;
			txtNumero.Text="";
			if(dataOperador.RowCount>-1 && dataOperador.Rows[e.RowIndex].Cells[0].Value!=null)
			{
				if(e.RowIndex>-1)
				{
					ID_OP = (Convert.ToInt32(dataOperador.Rows[e.RowIndex].Cells[0].Value));
					new Conexion_Servidor.Operador.SQL_Operador().getOperador(dataOperador.Rows[e.RowIndex].Cells[0].Value.ToString(), ptbImagen, txtAlias , txtNombre , txtApellidoP , txtApellidoM);
					AdaptadorApto();
					btnModificar.Enabled = false;
					btnRemoverLicencia.Enabled = false;
				}
			}
		}
		
		void DataFaltantesCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			ID_OP = 0;
			txtNumero.Text = "";
			if(e.RowIndex>-1 && dataFaltantes.Rows[e.RowIndex].Cells[0].Value!=null)
			{
				ID_OP = (Convert.ToInt32(dataFaltantes.Rows[e.RowIndex].Cells[0].Value));
				new Conexion_Servidor.Operador.SQL_Operador().getOperador(dataFaltantes[0,dataFaltantes.CurrentRow.Index].Value.ToString(),ptbImagen, txtAlias , txtNombre , txtApellidoP , txtApellidoM);
				AdaptadorApto();
				btnModificar.Enabled = false;
				btnRemoverLicencia.Enabled = false;
			}
			
		}
		
		void DataAptoCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			int ID = 0;
			txtNumero.Text="";
			
			if(e.RowIndex>-1 && dataApto.Rows[e.RowIndex].Cells[0].Value!=null)
			{
				ID = (Convert.ToInt32(dataApto.Rows[e.RowIndex].Cells[0].Value));
				txtNumero.Text = dataApto.Rows[e.RowIndex].Cells[1].Value.ToString();
				dateVigencia.Text = dataApto.Rows[e.RowIndex].Cells[2].Value.ToString();
				btnModificar.Enabled = true;
				btnRemoverLicencia.Enabled = true;
			}
		}
		#endregion
		
		#region BOTONES
		void BtnReportesClick(object sender, EventArgs e)
		{
			if(principal.reporteApto==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				principal.formReporteAptomedico = new Transportes_LAR.Interfaz.Aptomedico.FormReporteApto(principal);
				principal.formReporteAptomedico.BringToFront();
				principal.formReporteAptomedico.Show();
				principal.formReporteAptomedico.MdiParent=principal;
				principal.reporteApto=true;
			}
		}
		
		void BtnRemoverLicenciaClick(object sender, EventArgs e)
		{
			if(txtNumero.Text!="")
			{
				new Conexion_Servidor.Aptomedico.SQL_Aptomedico().EliminarApto((Convert.ToInt32(dataApto[0,dataApto.CurrentRow.Index].Value)));
				AdaptadorVigencia();
				dataFaltantes.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, Alias from OPERADOR where Estatus='1'and Alias!='Admvo'and tipo_empleado!='Externo' AND tipo_empleado='OPERADOR' and ID not in (select ID_OPERADOR from APTOMEDICO) order by Alias");
			}
			AdaptadorApto();
		}
		
		void BtnAgregarLicenciaClick(object sender, EventArgs e)
		{
			if(txtNumero.Text!="")
			{
				new Conexion_Servidor.Aptomedico.SQL_Aptomedico().InsertarApto(ID_OP, txtNumero.Text, dateVigencia.Value.ToString("yyyy-MM-dd").Substring(0,10));
				AdaptadorVigencia();
				dataFaltantes.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, Alias from OPERADOR where Estatus='1'and Alias!='Admvo'and tipo_empleado!='Externo' AND tipo_empleado='OPERADOR' and ID not in (select ID_OPERADOR from APTOMEDICO) order by Alias");
			}
			else
				MessageBox.Show("Es Necesario llenar los campos ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if(txtNumero.Text!="")
			{
				new Conexion_Servidor.Aptomedico.SQL_Aptomedico().UpdateApto((Convert.ToInt32(dataApto.Rows[dataApto.CurrentRow.Index].Cells[0].Value)), txtNumero.Text, dateVigencia.Value.ToString("yyyy-MM-dd").Substring(0,10));
				AdaptadorApto();
			}
			else
				MessageBox.Show("Es Necesario llenar los campos ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void BtnReporteClick(object sender, EventArgs e)
		{
			reporteAptosMedicos();
		}
		#endregion
	}
}
