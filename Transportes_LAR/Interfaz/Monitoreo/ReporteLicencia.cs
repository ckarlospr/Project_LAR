using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Monitoreo
{
	public partial class ReporteLicencia : Form
	{	
		#region INSTANCIAS
		private Interfaz.FormPrincipal principal=null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region CONSTRUCTORES
		public ReporteLicencia()
		{
			InitializeComponent();
		}
		
			public ReporteLicencia(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion 
		
		#region EVENTO CERRADO - VENTANA
		void ReporteLicenciaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.reportelicencia=false;
		}
		
		void ReporteLicenciaLoad(object sender, EventArgs e)
		{
			dataLicencia.DataSource=new Conexion_Servidor.Operador.SQL_Licencia().getTabla("select O.Alias, L.Numero, L.Tipo, L.Vigencia, L.Descripcion from LICENCIA L, OPERADOR O where L.ID_Chofer=O.ID AND O.Estatus='1'and O.Alias!='Admvo'and O.tipo_empleado!='Externo'");
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR WHERE tipo_empleado='OPERADOR'", "Alias");
           	txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region EVENTOS
		void TxtAliasTextChanged(object sender, EventArgs e)
		{
			dataLicencia.DataSource=new Conexion_Servidor.Operador.SQL_Licencia().getTabla("select O.Alias, L.Numero, L.Tipo, L.Vigencia, L.Descripcion from LICENCIA L, OPERADOR O where L.ID_Chofer=O.ID AND O.Estatus='1'and O.Alias!='Admvo'and O.tipo_empleado!='Externo' and alias like '"+txtAlias.Text+"%'");
		}
		
		void TxtNumeroTextChanged(object sender, EventArgs e)
		{
			dataLicencia.DataSource=new Conexion_Servidor.Operador.SQL_Licencia().getTabla("select O.Alias, L.Numero, L.Tipo, L.Vigencia, L.Descripcion from LICENCIA L, OPERADOR O where L.ID_Chofer=O.ID AND O.Estatus='1'and O.Alias!='Admvo'and O.tipo_empleado!='Externo' and Numero like '"+txtNumero.Text+"%'");
		}
		#endregion
		
		#region GENERADOR DE REPORTES
		void BtnExcelClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
				for (int i = -1; i < dataLicencia.Rows.Count; i++)
				{
					if(i==-1)
					{
						ExcelApp.Cells[i + 2,  2] = "ALIAS";
						ExcelApp.Cells[i + 2,  3] = "NUMERO";
						ExcelApp.Cells[i + 2,  4] = "TIPO";
						ExcelApp.Cells[i + 2,  5] = "VIGENCIA";
						ExcelApp.Cells[i + 2,  6] = "DESCRIPCION";
					}
					else
					{
						for (int j = 0; j < dataLicencia.Columns.Count; j++)
						{
								if(dataLicencia.Rows[i].Cells[j].Value.ToString().Equals(""))
								{
									ExcelApp.Cells[i + 2, j + 2]="null";
								}
								else
								{	
						   			ExcelApp.Cells[i +2, j +2 ] = dataLicencia.Rows[i].Cells[j].Value.ToString();	
								}
						}
					}
				}
								// ---------- cuadro de dialogo para Guardar
								SaveFileDialog CuadroDialogo = new SaveFileDialog();
								CuadroDialogo.DefaultExt = "xlsx";
								CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
								CuadroDialogo.AddExtension = true;
								CuadroDialogo.RestoreDirectory = true;
								CuadroDialogo.Title = "Guardar";
								CuadroDialogo.InitialDirectory = @"c:\";
								if (CuadroDialogo.ShowDialog() == DialogResult.OK)
								{
								ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
								ExcelApp.ActiveWorkbook.Saved = true;
								CuadroDialogo.Dispose();
								CuadroDialogo = null;
								ExcelApp.Quit();
								MessageBox.Show("Se exportaron los datos Correctamente ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
								}
								else
								{
								MessageBox.Show("No Genero el Reporte ... ", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
								}
						}
		#endregion	
	}
}
