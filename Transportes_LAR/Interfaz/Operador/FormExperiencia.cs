using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormExperiencia : Form
	{
		#region VARIABLES
		String ID_OP = "";
		System.IO.MemoryStream ms = null;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		#endregion
		
		#region CONSTRUCTOR
		public FormExperiencia()
		{
			InitializeComponent();
		}
		
		public FormExperiencia(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region LOAD - CLOSING
		void FormExperienciaLoad(object sender, EventArgs e)
		{
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			Validar(this);
		}
		
		void FormExperienciaFormClosing(object sender, FormClosingEventArgs e)
		{
			//principal.experiencia =  false;
		}
		#endregion
		
		#region VALIDAR
		void Validar(Interfaz.Operador.FormExperiencia formExperiencia)
		{
			formExperiencia.txtAlias.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formExperiencia.txtNombre.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formExperiencia.cmbgiro.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formExperiencia.txtTiempo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyOtros);
		}
		#endregion
		
		#region AGREGAR
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(txtAlias.Text!=""&&txtNombre.Text!=""&&txtTiempo.Text!=""&&cmbgiro.Text!="")
			{
				new Conexion_Servidor.Operador.SQL_Operador().InsertarExperiencia(txtNombre.Text, cmbgiro.Text, txtTiempo.Text, ID_OP);
				txtNombre.Text = "";
				txtTiempo.Text = "";
				cmbgiro.Text = "";
				Adaptador();
			}
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador()
		{
			int contador = 0;
			dataIngreso.Rows.Clear();
			dataIngreso.ClearSelection();
			
			conn.getAbrirConexion("select ID, EMPRESA, GIRO, TIEMPO " +
			                      "from EXPERIENCIA_LABORAL " +
			                      "where ID_OPERADOR="+ID_OP);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataIngreso.Rows.Add();
				dataIngreso.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataIngreso.Rows[contador].Cells[1].Value = conn.leer["EMPRESA"].ToString();
				dataIngreso.Rows[contador].Cells[2].Value = conn.leer["GIRO"].ToString();
				dataIngreso.Rows[contador].Cells[3].Value = conn.leer["TIEMPO"].ToString();
				++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region DATOS_OPERADOR
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      {
				DatosOperador(txtAlias.Text);
			  }
		}

		void DatosOperador(String AliasOP)
		{
			ID_OP="";
			try
			{
			conn.getAbrirConexion("Select ID from OPERADOR where Alias='"+AliasOP+"'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				ID_OP = (Convert.ToInt32(conn.leer["ID"])).ToString();
			}
			catch{}
			conn.conexion.Close();
			
			ptbImagen.Image = null;
			ptbImagen.Image = System.Drawing.Image.FromFile(@"../debug/Nomina.jpg");
			try
			{
			conn.getAbrirConexion("select Imagen from operador where ID="+ID_OP);
			conn.leer = conn.comando.ExecuteReader();
			if(conn.leer.Read())
				{
				byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
	  			ms = new System.IO.MemoryStream(imageBuffer);
	  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			catch{}
			conn.conexion.Close();
			Adaptador();
		}
		#endregion
		
		#region EVENTOS
		void DataIngresoCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 4 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataIngreso.Rows[e.RowIndex].Cells[4] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		
		void DataIngresoCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DialogResult boton1 = MessageBox.Show("Estas seguro de eliminar este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Conexion_Servidor.Operador.SQL_Operador().EliminarExperiencia(dataIngreso.Rows[e.RowIndex].Cells[0].Value.ToString());
				}
				Adaptador();
		}
		#endregion
		
		#region Reporte Excel Experiencia
		void BtnExcelExperienciaClick(object sender, EventArgs e)
		{
			generaExcelReporteExperiencia();
		}
		
		private void generaExcelReporteExperiencia()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "EMPRESA";
			ExcelApp.Cells[i,  2] 	= "GIRO";
			ExcelApp.Cells[i,  3] 	= "TIEMPO";
			ExcelApp.Cells[i,  4] 	= "ALIAS";
			ExcelApp.Cells[i,  5]   = "Numero";
		
			String consulta = @"select el.EMPRESA, el.GIRO, el.TIEMPO, o.Alias, v.Numero from EXPERIENCIA_LABORAL el join OPERADOR o on el.ID_OPERADOR = o.id join ASIG_UNIDAD au on au.ID_OPERADOR = o.ID join VEHICULO v on v.ID = au.ID_UNIDAD";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["EMPRESA"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["GIRO"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["TIEMPO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["ALIAS"].ToString();
				ExcelApp.Cells[i,  5]   =   conn.leer["Numero"].ToString();
			}
			conn.conexion.Close();
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "REPORTE EXPERIENCIA"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		#endregion
	}
}
