using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz
{
	public partial class FormReporteCombustible : Form
	{
		#region INSTANCIAS
		private Interfaz.FormPrincipal principal = null;	
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
				
		#region CONSTRUCTOR
		public FormReporteCombustible()
		{
			InitializeComponent();
		}
		
		public FormReporteCombustible(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal = principal;
		}
		#endregion		
		
		#region INICIO - FIN
		void FormReporteCombustibleLoad(object sender, EventArgs e)
		{
			cmbHoraInicio.SelectedIndex = 0;
			cmbHoraTermino.SelectedIndex = 23;
			AdaptadorCombustible();
			getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
           	txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtUnidad.AutoCompleteCustomSource = auto.AutocompleteUnidad();
           	txtUnidad.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		void FormReporteCombustibleFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.CombustibleReport=false;
		}
		#endregion		
		
		#region METODOS
		void BtnImprimirClick(object sender, EventArgs e)
		{
			try
			{
		    nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
			int cell = 1;        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 15;
			ExcelApp.Cells[1,  1] = "ALIAS";
			ExcelApp.Cells[1,  2] = "UNIDAD";
			ExcelApp.Cells[1,  3] = "FECHA";
			ExcelApp.Cells[1,  4] = "HORA";
			ExcelApp.Cells[1,  5] = "EMPRESA";
			ExcelApp.Cells[1,  6] = "RUTA";
			ExcelApp.Cells[1,  7] = "TURNO";
			ExcelApp.Cells[1,  8] = "SENTIDO";
			ExcelApp.Cells[1,  9] = "KM";

			for (int x = 0; x<dataCombustible.Rows.Count-1; x++)
			{
				ExcelApp.Cells[cell + 1, 1] = dataCombustible.Rows[x].Cells[0].Value.ToString();
				ExcelApp.Cells[cell + 1, 2] = dataCombustible.Rows[x].Cells[1].Value.ToString();
				ExcelApp.Cells[cell + 1, 3] = dataCombustible.Rows[x].Cells[2].Value.ToString();
				ExcelApp.Cells[cell + 1, 4] = dataCombustible.Rows[x].Cells[3].Value.ToString();
				ExcelApp.Cells[cell + 1, 5] = dataCombustible.Rows[x].Cells[4].Value.ToString();
				ExcelApp.Cells[cell + 1, 6] = dataCombustible.Rows[x].Cells[5].Value.ToString();
				ExcelApp.Cells[cell + 1, 7] = dataCombustible.Rows[x].Cells[6].Value.ToString();
				ExcelApp.Cells[cell + 1, 8] = dataCombustible.Rows[x].Cells[7].Value.ToString();
				ExcelApp.Cells[cell + 1, 9] = dataCombustible.Rows[x].Cells[8].Value.ToString();
				cell = cell +1;
			}
			
			cell = 1; 
			for (int x = 0; x<dataOtros.Rows.Count; x++)
			{
				ExcelApp.Cells[1,  11] = "TIPO";
				ExcelApp.Cells[1,  12] = "FECHA";
				ExcelApp.Cells[1,  13] = "TURNO";
				ExcelApp.Cells[1,  14] = "RUTA";
				ExcelApp.Cells[1,  15] = "NICK";
	
				ExcelApp.Cells[cell + 1, 11] = dataOtros.Rows[x].Cells[0].Value.ToString();
				ExcelApp.Cells[cell + 1, 12] = dataOtros.Rows[x].Cells[1].Value.ToString();
				ExcelApp.Cells[cell + 1, 13] = dataOtros.Rows[x].Cells[2].Value.ToString();
				ExcelApp.Cells[cell + 1, 14] = dataOtros.Rows[x].Cells[3].Value.ToString();
				ExcelApp.Cells[cell + 1, 15] = dataOtros.Rows[x].Cells[4].Value.ToString();
				cell = cell +1;
			}
			// ---------- cuadro de dialogo para Guardar
					SaveFileDialog CuadroDialogo = new SaveFileDialog();
					CuadroDialogo.DefaultExt = "xlsx";
					CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
					CuadroDialogo.AddExtension = true;
					CuadroDialogo.RestoreDirectory = true;
					CuadroDialogo.Title = "Guardar";
					CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
					CuadroDialogo.FileName = "Combustible";
					if(CuadroDialogo.ShowDialog() == DialogResult.OK)
					{
					ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
					ExcelApp.ActiveWorkbook.Saved = true;
					CuadroDialogo.Dispose();
					CuadroDialogo = null;
					ExcelApp.Quit();
					}
					else
					{
					MessageBox.Show("No Genero el Reporte ... ");
					}
			}
					catch(Exception ex)
					{
						MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
		}
	
		#endregion
				
		#region ADAPTADORES
		void AdaptadorCombustible()
		{
			int contador = 0;
			
			dataCombustible.Rows.Clear();
			dataCombustible.ClearSelection();
			
			String conss = "select O.Alias, V.numero,  OP.fecha, R.HoraInicio, c.SubNombre, R.Nombre, OP.turno, R.Sentido, R.Kilometros " +
                                "from vehiculo V,  OPERADOR O, OPERACION_OPERADOR OO, OPERACION OP, RUTA R, Cliente C " +
                                "where OO.id_vehiculo=V.id and O.ID = OO.id_operador and OO.id_operacion = OP.id_operacion and V.Numero like '%"+txtUnidad.Text+"%' and R.Nombre like '%"+txtRuta.Text+"%' and O.Alias like '"+txtAlias.Text+"%' and OP.fecha between '"+dtFechaInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtFechaTermino.Value.ToString("yyyy-MM-dd")+"' AND R.ID = OP.id_ruta and C.ID= R.IdSubEmpresa and OP.estatus='1' " +
                                "ORDER BY OP.fecha";
			
			conn.getAbrirConexion(conss);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(((Convert.ToDateTime(dtFechaInicio.Value.ToString("yyyy-MM-dd")+" " +cmbHoraInicio.Text)<=Convert.ToDateTime(conn.leer["fecha"].ToString().Substring(0,10) +" " +conn.leer["HoraInicio"])))&&((Convert.ToDateTime(dtFechaTermino.Value.ToString("yyyy-MM-dd")+" " +cmbHoraTermino.Text)>=Convert.ToDateTime(conn.leer["fecha"].ToString().Substring(0,10) +" " +conn.leer["HoraInicio"]))))
				{
						dataCombustible.Rows.Add();
						dataCombustible.Rows[contador].Cells[0].Value = conn.leer["Alias"].ToString();
						dataCombustible.Rows[contador].Cells[1].Value = conn.leer["numero"].ToString();
						dataCombustible.Rows[contador].Cells[2].Value = conn.leer["fecha"].ToString().Substring(0,10);
						dataCombustible.Rows[contador].Cells[3].Value = conn.leer["HoraInicio"].ToString();
						dataCombustible.Rows[contador].Cells[4].Value = conn.leer["SubNombre"].ToString();
						dataCombustible.Rows[contador].Cells[5].Value = conn.leer["Nombre"].ToString();
						dataCombustible.Rows[contador].Cells[6].Value = conn.leer["turno"].ToString();
						dataCombustible.Rows[contador].Cells[7].Value = conn.leer["Sentido"].ToString();
						dataCombustible.Rows[contador].Cells[8].Value = conn.leer["Kilometros"].ToString();
						++contador;
				}
			}
			conn.conexion.Close();
		}
		
		public void getOtros(String alias, String ruta, String fecha_1, String fecha_2)
		{
			dataOtros.Rows.Clear();
			List<Interfaz.Reportes.ClassDatos> listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select G.DIA D1, G.TURNO D2, '(Empresa) '+C.Empresa D3, O.ALIAS D4  from GUARDIA G, Cliente C, OPERADOR O where G.ID_OPERADOR=O.ID and G.ID_SUBEMPRESA=C.ID and G.DIA between '"+fecha_1+"' and '"+fecha_2+"' and O.Alias='"+alias+"' ");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Guardia", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select RR.DIA D1,  R.Turno D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from RECONOCIMIENTO_RUTA RR, OPERADOR O, RUTA R where RR.ID_OPERADOR=O.ID and RR.ID_RUTA=R.ID and RR.DIA between '"+fecha_1+"' and '"+fecha_2+"' and O.Alias='"+alias+"' and R.Nombre like '%"+ruta+"%'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Reconocimiento", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select P.DIA D1,   P.TURNO D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from PRUEBA_RENDIMIENTO P, OPERADOR O, RUTA R where  P.ID_OP_SUPERVISOR=O.ID and P.ID_RUTA=R.ID and P.DIA between '"+fecha_1+"' and '"+fecha_2+"' and O.Alias='"+alias+"' and R.Nombre like '%"+ruta+"%'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("P. Rendimiento", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2( "select A.DIA D1,   A.TURNO D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from APOYOS A, OPERADOR O, RUTA R where  ID_OP_APOYO=O.ID and A.ID_RUTA=R.ID and A.DIA between '"+fecha_1+"' and '"+fecha_2+"' and O.Alias='"+alias+"' and R.Nombre like '%"+ruta+"%'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Apoyo", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select C.FECHA D1, C.TURNO D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from CANCELACION_PUNTO C, OPERADOR O, RUTA R where C.ID_OPERADOR=O.ID and C.ID_RUTA=R.ID and C.FECHA between '"+fecha_1+"' and '"+fecha_2+"' and O.Alias='"+alias+"' and R.Nombre like '%"+ruta+"%'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Cancelado P.", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			txtTotal.Text="0";
			for(int x=0; x<dataCombustible.Rows.Count; x++)
			{
				txtTotal.Text=(Convert.ToDouble(txtTotal.Text)+Convert.ToDouble(dataCombustible[8,x].Value)).ToString();
			}
			txtTotal.Text=txtTotal.Text+" kms";
		}
		
		public void getOtros2(String fecha_1, String fecha_2)
		{
			dataOtros.Rows.Clear();
			List<Interfaz.Reportes.ClassDatos> listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select G.DIA D1, G.TURNO D2, '(Empresa) '+C.Empresa D3, O.ALIAS D4 from GUARDIA G, Cliente C, OPERADOR O where G.ID_OPERADOR=O.ID and G.ID_SUBEMPRESA=C.ID and G.DIA between '"+fecha_1+"' and '"+fecha_2+"'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Guardia", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select RR.DIA D1,  R.Turno D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from RECONOCIMIENTO_RUTA RR, OPERADOR O, RUTA R where RR.ID_OPERADOR=O.ID and RR.ID_RUTA=R.ID and RR.DIA between '"+fecha_1+"' and '"+fecha_2+"'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Reconocimiento", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select P.DIA D1,   P.TURNO D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from PRUEBA_RENDIMIENTO P, OPERADOR O, RUTA R where  P.ID_OP_SUPERVISOR=O.ID and P.ID_RUTA=R.ID and P.DIA between '"+fecha_1+"' and '"+fecha_2+"'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("P. Rendimiento", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2( "select A.DIA D1,   A.TURNO D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from APOYOS A, OPERADOR O, RUTA R where  ID_OP_APOYO=O.ID and A.ID_RUTA=R.ID and A.DIA between '"+fecha_1+"' and '"+fecha_2+"'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Apoyo", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			listDatos = new Conexion_Servidor.Reportes.SQL_Reportes().getLisDatos2("select C.FECHA D1, C.TURNO D2, '(Ruta) '+R.Nombre D3, O.ALIAS D4  from CANCELACION_PUNTO C, OPERADOR O, RUTA R where C.ID_OPERADOR=O.ID and C.ID_RUTA=R.ID and C.FECHA between '"+fecha_1+"' and '"+fecha_2+"'");
			if(listDatos!=null)
			{
				for(int x=0; x<listDatos.Count; x++)
				{
					dataOtros.Rows.Add("Cancelado P.", listDatos[x].Dato0, listDatos[x].Dato1, listDatos[x].Dato2, listDatos[x].Dato3);
				}
			}
			
			txtTotal.Text="0";
			for(int x=0; x<dataCombustible.Rows.Count; x++)
			{
				txtTotal.Text=(Convert.ToDouble(txtTotal.Text)+Convert.ToDouble(dataCombustible[8,x].Value)).ToString();
			}
			txtTotal.Text=txtTotal.Text+" kms";
		}
		#endregion		
		
		#region EVENTOS
		void DtFechaValueChanged(object sender, EventArgs e)
		{
			dtFechaTermino.Value=dtFechaInicio.Value;
			//AdaptadorCombustible();
			//getOtros(txtAlias.Text, dtFecha.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
		}
		
		void TxtUnidadTextChanged(object sender, EventArgs e)
		{
			AdaptadorCombustible();
			if(txtAlias.Text.Length > 0)
				getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			else				
				getOtros2(dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
		}
				
		void TxtAliasTextChanged(object sender, EventArgs e)
		{
			AdaptadorCombustible();
			if(txtAlias.Text.Length > 0)
				getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			else				
				getOtros2(dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
		}
		
		void CmbHoraTerminoSelectedIndexChanged(object sender, EventArgs e)
		{
			AdaptadorCombustible();
			if(txtAlias.Text.Length > 0)
				getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			else				
				getOtros2(dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
		}
		
		void CmbHoraInicioSelectedIndexChanged(object sender, EventArgs e)
		{
			AdaptadorCombustible();
			if(txtAlias.Text.Length > 0)
				getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			else				
				getOtros2(dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
		}
		
		void DtFechaTerminoValueChanged(object sender, EventArgs e)
		{
			AdaptadorCombustible();
			if(txtAlias.Text.Length > 0)
				getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			else				
				getOtros2(dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			//getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
		}
		
		void TxtRutaTextChanged(object sender, EventArgs e)
		{
			AdaptadorCombustible();
			if(txtAlias.Text.Length > 0)
				getOtros(txtAlias.Text, txtRuta.Text, dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
			else				
				getOtros2(dtFechaInicio.Value.ToString("yyyy-MM-dd"), dtFechaTermino.Value.ToString("yyyy-MM-dd"));
		}		
		#endregion
	}
}
