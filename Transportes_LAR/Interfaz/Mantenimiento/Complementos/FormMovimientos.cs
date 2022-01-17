using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Linq.Expressions;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormMovimientos : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region CONSTRUCTORES
		public FormMovimientos()
		{
			InitializeComponent();
		}
		#endregion
		
		#region ADAPTADOR
		void LlenadoCmbSinConsultas()
		{		
			cmbCAmpoAlM.Items.Clear();
			cmbCAmpoAlM.Items.Add("ID");
			cmbCAmpoAlM.Items.Add("NOMBRE");
			cmbCAmpoAlM.Items.Add("PRECIO UNITARIO");
			cmbCAmpoAlM.Items.Add("ID_GRUPO");
			cmbCAmpoAlM.Items.Add("ESTADO");
			
			cmbSentidoOrdM.Items.Clear();
			cmbSentidoOrdM.Items.Add("ASCENDENTE");
			cmbSentidoOrdM.Items.Add("DESCENDENTE");
		}
		
		void LlenadoCmbGrupo()
		{		
			cmbCampoAgrM.Items.Clear();
			conn.getAbrirConexion("select Nombre from Grupo_Producto");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				cmbCampoAgrM.Items.Add(conn.leer["Nombre"].ToString());
			conn.conexion.Close();
		}
		#endregion
		
		#region BOTONES
		
		#endregion
		
		#region INICIO
		void FormMovimientosLoad(object sender, EventArgs e)
		{
			LlenadoCmbGrupo();
			LlenadoCmbSinConsultas();
			chart1.Series.Clear();			
		    var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                Color = System.Drawing.Color.Red,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Pyramid
            };
		    Title tt =  new Title();
		    tt.Text = "INFORME DE MOVIMIENTOS";
		    tt.Font = new System.Drawing.Font("Trebuchet MS", 20, System.Drawing.FontStyle.Bold);
		    tt.TextStyle = TextStyle.Embed;
		    this.chart1.Titles.Add(tt);
		    series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
		    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
		    chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 12, System.Drawing.FontStyle.Bold);
		    chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 12, System.Drawing.FontStyle.Bold);
		    series1.Points.DataBindXY(new[] { 2001, 2002, 2003, 2004 }, new[] { 100, 200, 90, 150 });
		    series1.IsValueShownAsLabel =  true;
		    chart1.Series.Add(series1);
		    //Etiquetas puntos
		    /*chart1.Series["Series1"].Points[0].AxisLabel = "2001";
			chart1.Series["Series1"].Points[1].AxisLabel = "2002";
			chart1.Series["Series1"].Points[2].AxisLabel = "2003";
			chart1.Series["Series1"].Points[3].AxisLabel = "2004";*/
		    //valores x and y en Texto
			chart1.Series["Series1"].Label = "#VALY";
		    chart1.Series["Series1"].SmartLabelStyle.Enabled = true;
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
		#endregion
		
	}
}
