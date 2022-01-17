using System;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormExistencia : Form
	{
		#region VARIABLES		
			String[]  nombreProductos = null;
			int [] cantidadProductos = null;
			String sentencia = "select P.*, G.NOMBRE AS GRUPO, PR.NOMBRE AS PROVEEDOR from Producto P, GRUPO_PRODUCTO G, PROVEEDOR PR where G.ID=P.ID_GRUPO AND P.ID_PROVEEDOR=PR.ID ";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
        System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		#endregion
		
		#region CONSTRUCTORES
		public FormExistencia()
		{
			InitializeComponent();
		}
		#endregion
		
		#region ADAPTADOR
		void AdaptadorGrafica(String Sentencia)
		{		
			int contador = 0;			 		
			nombreProductos = new String[new Transportes_LAR.Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().TotalEntradasProdsActivados()];
			cantidadProductos = new int[new Transportes_LAR.Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().TotalEntradasProdsActivados()];
			
			conn.getAbrirConexion(Sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{			
				nombreProductos[contador] = conn.leer["PIEZA"].ToString();
				cantidadProductos[contador] = Convert.ToInt32(conn.leer["CANTIDAD"]);
				++contador;
			}
			conn.conexion.Close();
		}
				
		void LlenadoCmbSinConsultas()
		{		
			cmbCAmpoAl.Items.Clear();
			cmbCAmpoAl.Items.Add("ID");
			cmbCAmpoAl.Items.Add("PIEZA");
			cmbCAmpoAl.Items.Add("PRECIO UNITARIO");
			cmbCAmpoAl.Items.Add("CANTIDAD");
			cmbCAmpoAl.Items.Add("GRUPO");
			cmbCAmpoAl.Items.Add("ESTADO");
			cmbCAmpoAl.Items.Add("PROVEEDOR");

			
			cmbSentidoOrd.Items.Clear();
			cmbSentidoOrd.Items.Add("ASCENDENTE");
			cmbSentidoOrd.Items.Add("DESCENDENTE");
			
			cmbTipInf.Items.Clear();
			cmbTipInf.Items.Add("DETALLADO");
			cmbTipInf.Items.Add("TOTALIZADO");
			
			cmbColorBarras.Items.Clear();
			cmbColorBarras.Items.Add("Verde Mar");
			cmbColorBarras.Items.Add("Chocolate");
			cmbColorBarras.Items.Add("Escala Gris");
			cmbColorBarras.Items.Add("Excel");
			cmbColorBarras.Items.Add("Pastel");
			
			cmbGraficaOrient.Items.Clear();
			cmbGraficaOrient.Items.Add("Horizontal");
			cmbGraficaOrient.Items.Add("Vertical");
			
		}
		
		void LlenadoCmbGrupo()
		{		
			cmbCampoAgr.Items.Clear();
			conn.getAbrirConexion("select NOMBRE from Grupo_Producto");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				cmbCampoAgr.Items.Add(conn.leer["NOMBRE"].ToString());
			conn.conexion.Close();
		}
		#endregion

		#region INICIO		
		void FormExistenciaLoad(object sender, EventArgs e)
		{
			LlenadoCmbSinConsultas();
			LlenadoCmbGrupo();
			AdaptadorGrafica("SELECT * FROM PRODUCTO  WHERE ESTADO = 'Activado' ORDER BY CANTIDAD  DESC");
	
			
			chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
			chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 12, System.Drawing.FontStyle.Bold);
		    chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 12, System.Drawing.FontStyle.Bold);
		   	
			for (int i = 0; i < nombreProductos.Length; i++)
			{
				this.chart1.Series["Productos"].Points.AddXY(nombreProductos[i], cantidadProductos[i]);
								
				//series1 = chart1.Series.Add(nombreProductos[i]);
				//series1.Points.AddXY(nombreProductos[i], cantidadProductos[i]);
				//series1.Points.AddY(nombreProductos[i]);
				//series1.Points.Add(cantidadProductos[i]);
			} 			
			
			#region CODIGO ANTERIOR GRAFICAS
			//ejemplo 1
            /*
		var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Pie
            };
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart1.Series.Add(series1);
            
            for (int i=0; i < 10; i++)
            {
                series1.Points.AddXY(i, f(i));
            }
            chart1.Invalidate();*/
			
			//ejemplo 2
			// Data arrays.
		    /*string[] seriesArray = { "Cats", "Dogs" };
		    int[] pointsArray = { 1, 2 };
		    // Set palette.
		    this.chart1.Palette = ChartColorPalette.SeaGreen;
		    // Set title.
		    this.chart1.Titles.Add("Pets");
		    // Add series.
		    for (int i = 0; i < seriesArray.Length; i++)
		    {
				// Add series.
				Series series = this.chart1.Series.Add(seriesArray[i]);
				// Add point.
				series.Points.Add(pointsArray[i]);
	    	}*/
		    
		    //hecho por xavi    
		    
		    /*
		    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
		    Title tt =  new Title();
		    tt.Text = "Productos";
		    tt.Font = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold);
		    tt.TextStyle = TextStyle.Embed;
		    this.chart1.Titles.Add(tt);
		    series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
		    chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
		    chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 12, System.Drawing.FontStyle.Bold);
		    chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 12, System.Drawing.FontStyle.Bold);
		    
		   series1.Points.DataBindXY(new[] { 100, 200, 90, 150 }, new[] { 2001, 3002, 2503, 4004 });
					/*	    
				for (int i = 0; i < nombreProductos.Capacity; i++)
				{
				 // Aqui se agregan las series o Categorias.
				 series1 = chart1.Series.Add(Convert.ToString(nombreProductos[i]));
				  } 
				
				for (int i = 0; i < 2; i++)
				{
 					// Aqui se agregan las series o Categorias.
 				 	series1 = chart1.Series.Add(nombreProductos[i]);
					 // Aqui se agregan los Valores.
					series1.Points.Add(cantidadProductos[i]);
				} 
				
		    series1.IsValueShownAsLabel =  true;
		    chart1.Series.Add(series1);
		    //Etiquetas puntos
		    /*chart1.Series["Series1"].Points[0].AxisLabel = "2001";
			chart1.Series["Series1"].Points[1].AxisLabel = "2002";
			chart1.Series["Series1"].Points[2].AxisLabel = "2003";
			chart1.Series["Series1"].Points[3].AxisLabel = "2004";
		    valores x and y en Texto
			chart1.Series["Series1"].Label = "#VALY";
		    chart1.Series["Series1"].SmartLabelStyle.Enabled = true;
		    */
		    #endregion
						
		}
		
		#endregion
		
		#region BOTONES
		
		void Button1Click(object sender, EventArgs e)
		{
		   // PDF();
		   To_pdf();
		}
		
		#endregion
		
		#region METODOS
		
		private Byte[] Chart()
		{
			  using (var chartimage = new MemoryStream())
			  {
			    chart1.SaveImage(chartimage, ChartImageFormat.Png);
			    return chartimage.GetBuffer();
			  }
		}
		
		 void GuardarGraficaImagen()
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "JPeg Imagen|*.jpg|Bitmap Imagen|*.bmp|PNG Imagen|*.png";
			saveFileDialog1.Title = "Guardar Grafico en Imagen";
			saveFileDialog1.ShowDialog();
			if (saveFileDialog1.FileName != "")
			{
				System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
				switch (saveFileDialog1.FilterIndex)
				{
					case 1:
						this.chart1.SaveImage(fs, ChartImageFormat.Jpeg);
					  break;
					case 2:
						this.chart1.SaveImage(fs, ChartImageFormat.Bmp);
					  break;
					case 3:
						this.chart1.SaveImage(fs, ChartImageFormat.Png);
					break;
				}
				fs.Close();
			}
		}
		#endregion
		
		#region PDF
		void PDF()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Orden "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{	
				Document doc = new Document(PageSize.LETTER, 10, 10 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Orden "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Orden de Compra.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				var image = iTextSharp.text.Image.GetInstance(Chart());
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Orden "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Orden de Compra.pdf"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			/*
			 
							Console.WriteLine("Se empezará a crear el Archivo PDF");
				 
				//Creamos un tipo de archivo que solo se cargará en la memoria principal
				Document documento = new Document();
				//Creamos la instancia para generar el archivo PDF
				//Le pasamos el documento creado arriba y con capacidad para abrir o Crear y de nombre Mi_Primer_PDF
				PdfWriter.GetInstance(documento, new FileStream("Mi_Primer_PDF.pdf", FileMode.OpenOrCreate));
				 
				//Abrimos el documento
				documento.Open();
				 
				//Le agregamos un párrafo
				documento.Add(new Paragraph("Este es mi primer PDF"));
				 
				//Le agregamos un segundo párrafo
				documento.Add(new Paragraph("Segundo párrafo"));
				 
				//Cerramos el documento
				documento.Close();
				 
				 
				Console.WriteLine("El archivo ha sido creado");
				            
				//Para que no se cierre la cónsola, hasta que presionemos alguna tecla
				Console.ReadLine();
			 
			 
			 * */
		}
		#endregion		
		
		#region EVENTOS PARA LA GRAFICA
			void Button2Click(object sender, EventArgs e)
			{
				GuardarGraficaImagen();
			}
			
			void Chart1DoubleClick(object sender, EventArgs e)
			{
				GuardarGraficaImagen();
			}
		#endregion	
		
		#region VISTA DE LA GRAFICA		
		void CbxVista3DCheckedChanged(object sender, EventArgs e)
		{
			if(cbxVista3D.Checked == true)
			{
		    	chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
		    	AdaptadorGrafica("SELECT * FROM PRODUCTO  WHERE ESTADO = 'Activado' ORDER BY CANTIDAD  DESC");
			}
			else
			{
				chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
				AdaptadorGrafica("SELECT * FROM PRODUCTO  WHERE ESTADO = 'Activado' ORDER BY CANTIDAD  DESC");
			}
		}
		
		void CmbColorBarrasSelectedIndexChanged(object sender, EventArgs e)
		{
			chart1.Update();		   
			//AdaptadorGrafica("SELECT * FROM PRODUCTO  WHERE ESTADO = 'Activado' ORDER BY CANTIDAD  DESC");
								
			switch(cmbColorBarras.SelectedIndex)
			{
				case 0:
					chart1.Update();	
					chart1.Series["Productos"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
					break;
				case 1:
					chart1.Update();	
					chart1.Series["Productos"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
					break;
				case 2:
					chart1.Update();
					chart1.Series["Productos"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
					break;					
				case 3:
					chart1.Update();
					chart1.Series["Productos"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
					break;					
				case 4:
					chart1.Update();
					chart1.Series["Productos"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
					break;						
			}
			
		}
		
		void CmbGraficaOrientSelectedIndexChanged(object sender, EventArgs e)
		{
			chart1.Update();		   
			AdaptadorGrafica("SELECT * FROM PRODUCTO  WHERE ESTADO = 'Activado' ORDER BY CANTIDAD  DESC");
								
			switch(cmbGraficaOrient.SelectedIndex)
			{
				case 0:
					chart1.Series["Productos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
					break;
				case 1:
					chart1.Series["Productos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
					break;					
			}
			
		}
		#endregion
	
		#region CREAR PDF
        private void To_pdf()
        {
        	String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Orden "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
	       
	        Document doc = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Orden "+DateTime.Now.ToString("dd-MM-yyyy");
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "Informe de Productos";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename,
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite,
                FileShare.ReadWrite);
            	
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string remito = "Autorizo: ---- ";
                string envio = "Fecha:" + DateTime.Now.ToString();
             
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Transportes LAR - Slim\Transportes_LAR\bin\Debug\LAR.JPG");
                
				imagen.BorderWidth = 0;
				imagen.Alignment = Element.ALIGN_LEFT;
				float percentage = 0.0f;
				percentage = 250 / imagen.Width;
				imagen.ScalePercent(percentage * 100);
				doc.Add(imagen);

                Chunk chunk = new Chunk("\n\nReporte de General Productos", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("Guadalajara, Jalisco"));
                      
                doc.Add(new Paragraph(remito));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
      
                doc.Close();
                Process.Start(filename);
                cmbCAmpoAl.Text = null;
                cmbSentidoOrd.Text = null;
                
               
                
                
               
            }
      
        }
	        
        public void GenerarDocumento(Document document)
        {
			PdfPTable table = new PdfPTable(8);
			table.TotalWidth = 750f;
			table.LockedWidth = true;
			
			 
			float[] widths = new float[] { 2f, 7f, 10f, 6f, 6f, 4f, 6f, 8f };
			table.SetWidths(widths);
			table.HorizontalAlignment = 1;
			//leave a gap before and after the table
			table.SpacingBefore = 20f;
			table.SpacingAfter = 30f;
			 
		
		
			
			PdfPCell cell2 = new PdfPCell(new Phrase("ID", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell2.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell2.HorizontalAlignment = 1;
			table.AddCell(cell2);
			
			PdfPCell cell3 = new PdfPCell(new Phrase("NOMBRE", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell3.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell3.HorizontalAlignment = 1;
			table.AddCell(cell3);
			
			PdfPCell cell4 = new PdfPCell(new Phrase("DESCRIPCION", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell4.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell4.HorizontalAlignment = 1;
			table.AddCell(cell4);
			
			PdfPCell cell5 = new PdfPCell(new Phrase("PRECIO UNITARIO", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell5.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell5.HorizontalAlignment = 1;
			table.AddCell(cell5);
			
			PdfPCell cell6 = new PdfPCell(new Phrase("CANTIDAD", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell6.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell6.HorizontalAlignment = 1;
			table.AddCell(cell6);
			
			PdfPCell cell7 = new PdfPCell(new Phrase("GRUPO", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell7.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell7.HorizontalAlignment = 1;
			table.AddCell(cell7);
			
			PdfPCell cell8 = new PdfPCell(new Phrase("ESTADO", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell8.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell8.HorizontalAlignment = 1;
			table.AddCell(cell8);
			
			PdfPCell cell9 = new PdfPCell(new Phrase("PROVEEDOR", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.NORMAL)));
			cell9.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#008000"));            
			cell9.HorizontalAlignment = 1;
			table.AddCell(cell9);
			
			/*
			table.AddCell("ID");			
			table.AddCell("NOMBRE");
			table.AddCell("DESCRIPCION");
			table.AddCell("PRECIO UNITARIO");
			table.AddCell("CANTIDAD");
			table.AddCell("GRUPO");
			table.AddCell("ESTADO");
			table.AddCell("PROVEEDOR");	
			*/		
			
			conn.getAbrirConexion(sentencia);
			conn.leer  = conn.comando.ExecuteReader();
			   while (conn.leer.Read())
			    {
			   		
			   	/*
			   		int i = 0;
			   		if (i % 2 != 0)
		            {
			   			PdfPCell Cell2 = new PdfPCell(new Phrase(conn.leer["ID"].ToString()));
		                cell.BackgroundColor = new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#C2D69B"));
		            	table.AddCell(Cell2);
		            	i++;
			   		}
			   		*/
					
			       table.AddCell(conn.leer["ID"].ToString());
			       table.AddCell(conn.leer["Nombre"].ToString());
			       table.AddCell(conn.leer["DESCRIPCION"].ToString());
			       table.AddCell(conn.leer["PrecioUnitario"].ToString());
			       table.AddCell(conn.leer["cantidad"].ToString());
			       table.AddCell(conn.leer["GRUPO"].ToString());
			       table.AddCell(conn.leer["Estado"].ToString());
			       table.AddCell(conn.leer["PROVEEDOR"].ToString());			       
			   	   
			       
			     }
			    conn.conexion.Close();
			 
			  document.Add(table);
			
        }
        #endregion
		
        #region EVENTOS PARA COMBOBOX
        void CmbCAmpoAlSelectedIndexChanged(object sender, EventArgs e)
		{
			sentencia = "select P.*, G.NOMBRE AS GRUPO, PR.NOMBRE AS PROVEEDOR from Producto P, GRUPO_PRODUCTO G, PROVEEDOR PR where G.ID=P.ID_GRUPO AND P.ID_PROVEEDOR=PR.ID order by P." +cmbCAmpoAl.Text;
		
			if (cmbCAmpoAl.Text == "GRUPO")
				sentencia = "select P.*, G.NOMBRE AS GRUPO, PR.NOMBRE AS PROVEEDOR from Producto P, GRUPO_PRODUCTO G, PROVEEDOR PR where G.ID=P.ID_GRUPO AND P.ID_PROVEEDOR=PR.ID order by P.ID_GRUPO";
			
			if (cmbCAmpoAl.Text == "PRECIO UNITARIO")
				sentencia = "select P.*, G.NOMBRE AS GRUPO, PR.NOMBRE AS PROVEEDOR from Producto P, GRUPO_PRODUCTO G, PROVEEDOR PR where G.ID=P.ID_GRUPO AND P.ID_PROVEEDOR=PR.ID order by P.PRECIOUNITARIO";
			
			if (cmbCAmpoAl.Text == "PROVEEDOR")
				sentencia = "select P.*, G.NOMBRE AS GRUPO, PR.NOMBRE AS PROVEEDOR from Producto P, GRUPO_PRODUCTO G, PROVEEDOR PR where G.ID=P.ID_GRUPO AND P.ID_PROVEEDOR=PR.ID order by P.ID_PROVEEDOR";
		}
		
		void CmbSentidoOrdSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbSentidoOrd.Text == "DESCENDENTE")
				sentencia = sentencia + " desc";
		}
        #endregion
	}
}
