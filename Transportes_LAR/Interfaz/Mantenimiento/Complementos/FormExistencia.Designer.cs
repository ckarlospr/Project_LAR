/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 02/01/2015
 * Hora: 06:52 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	partial class FormExistencia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExistencia));
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.cmbSentidoOrd = new System.Windows.Forms.ComboBox();
			this.cmbCAmpoAl = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCampoAgr = new System.Windows.Forms.ComboBox();
			this.cmbTipInf = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txtNombreProd = new System.Windows.Forms.TextBox();
			this.btnBusquedaProd = new System.Windows.Forms.Button();
			this.txtIDProd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnVerInforme = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbGraficaOrient = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbColorBarras = new System.Windows.Forms.ComboBox();
			this.cbxVista3D = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox18.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Transparent;
			this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
			chartArea1.AxisX.Interval = 1D;
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(12, 196);
			this.chart1.Name = "chart1";
			this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
			series1.BorderColor = System.Drawing.Color.Gray;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series1.IsXValueIndexed = true;
			series1.Name = "Productos";
			series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(929, 551);
			this.chart1.TabIndex = 0;
			title1.BackColor = System.Drawing.Color.Transparent;
			title1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			title1.Name = "Title1";
			title1.Text = "Existencia de Productos Activados";
			title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Emboss;
			this.chart1.Titles.Add(title1);
			this.chart1.DoubleClick += new System.EventHandler(this.Chart1DoubleClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gray;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(980, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Parametrización del informe";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.cmbSentidoOrd);
			this.groupBox18.Controls.Add(this.cmbCAmpoAl);
			this.groupBox18.Controls.Add(this.label2);
			this.groupBox18.Controls.Add(this.label10);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(12, 35);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(386, 69);
			this.groupBox18.TabIndex = 153;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "ORDENACIÓN";
			// 
			// cmbSentidoOrd
			// 
			this.cmbSentidoOrd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSentidoOrd.FormattingEnabled = true;
			this.cmbSentidoOrd.Location = new System.Drawing.Point(239, 36);
			this.cmbSentidoOrd.Name = "cmbSentidoOrd";
			this.cmbSentidoOrd.Size = new System.Drawing.Size(128, 22);
			this.cmbSentidoOrd.TabIndex = 150;
			this.cmbSentidoOrd.SelectedIndexChanged += new System.EventHandler(this.CmbSentidoOrdSelectedIndexChanged);
			// 
			// cmbCAmpoAl
			// 
			this.cmbCAmpoAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCAmpoAl.FormattingEnabled = true;
			this.cmbCAmpoAl.Location = new System.Drawing.Point(7, 36);
			this.cmbCAmpoAl.Name = "cmbCAmpoAl";
			this.cmbCAmpoAl.Size = new System.Drawing.Size(178, 22);
			this.cmbCAmpoAl.TabIndex = 149;
			this.cmbCAmpoAl.SelectedIndexChanged += new System.EventHandler(this.CmbCAmpoAlSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 20);
			this.label2.TabIndex = 148;
			this.label2.Text = "Campo de alineación";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(239, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 20);
			this.label10.TabIndex = 143;
			this.label10.Text = "Sentido de ordenación";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbCampoAgr);
			this.groupBox1.Controls.Add(this.cmbTipInf);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(421, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(435, 69);
			this.groupBox1.TabIndex = 154;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "AGRUPACIÓN";
			// 
			// cmbCampoAgr
			// 
			this.cmbCampoAgr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampoAgr.FormattingEnabled = true;
			this.cmbCampoAgr.Location = new System.Drawing.Point(239, 36);
			this.cmbCampoAgr.Name = "cmbCampoAgr";
			this.cmbCampoAgr.Size = new System.Drawing.Size(172, 22);
			this.cmbCampoAgr.TabIndex = 150;
			// 
			// cmbTipInf
			// 
			this.cmbTipInf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipInf.FormattingEnabled = true;
			this.cmbTipInf.Location = new System.Drawing.Point(7, 36);
			this.cmbTipInf.Name = "cmbTipInf";
			this.cmbTipInf.Size = new System.Drawing.Size(178, 22);
			this.cmbTipInf.TabIndex = 149;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(178, 20);
			this.label3.TabIndex = 148;
			this.label3.Text = "Tipo de informe";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(239, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 20);
			this.label4.TabIndex = 143;
			this.label4.Text = "Campo de agrupación";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.txtNombreProd);
			this.groupBox2.Controls.Add(this.btnBusquedaProd);
			this.groupBox2.Controls.Add(this.txtIDProd);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 121);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(532, 69);
			this.groupBox2.TabIndex = 154;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "FILTRADO";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(7, 38);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
			this.dateTimePicker1.TabIndex = 154;
			// 
			// txtNombreProd
			// 
			this.txtNombreProd.Location = new System.Drawing.Point(314, 39);
			this.txtNombreProd.Name = "txtNombreProd";
			this.txtNombreProd.Size = new System.Drawing.Size(209, 20);
			this.txtNombreProd.TabIndex = 152;
			// 
			// btnBusquedaProd
			// 
			this.btnBusquedaProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaProd.Image")));
			this.btnBusquedaProd.Location = new System.Drawing.Point(274, 38);
			this.btnBusquedaProd.Name = "btnBusquedaProd";
			this.btnBusquedaProd.Size = new System.Drawing.Size(34, 23);
			this.btnBusquedaProd.TabIndex = 151;
			this.btnBusquedaProd.UseVisualStyleBackColor = true;
			// 
			// txtIDProd
			// 
			this.txtIDProd.Location = new System.Drawing.Point(209, 39);
			this.txtIDProd.Name = "txtIDProd";
			this.txtIDProd.Size = new System.Drawing.Size(68, 20);
			this.txtIDProd.TabIndex = 150;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 20);
			this.label5.TabIndex = 148;
			this.label5.Text = "Fecha";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(209, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 20);
			this.label6.TabIndex = 143;
			this.label6.Text = "Producto";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnVerInforme
			// 
			this.btnVerInforme.Location = new System.Drawing.Point(862, 51);
			this.btnVerInforme.Name = "btnVerInforme";
			this.btnVerInforme.Size = new System.Drawing.Size(119, 30);
			this.btnVerInforme.TabIndex = 1;
			this.btnVerInforme.Text = "Ver informe";
			this.btnVerInforme.UseVisualStyleBackColor = true;
			this.btnVerInforme.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(862, 133);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 35);
			this.button2.TabIndex = 155;
			this.button2.Text = "Guadar Grafica";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.cmbGraficaOrient);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.cmbColorBarras);
			this.groupBox3.Controls.Add(this.cbxVista3D);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(550, 121);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(306, 69);
			this.groupBox3.TabIndex = 156;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "GRAFICA";
			// 
			// cmbGraficaOrient
			// 
			this.cmbGraficaOrient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGraficaOrient.FormattingEnabled = true;
			this.cmbGraficaOrient.Location = new System.Drawing.Point(218, 36);
			this.cmbGraficaOrient.Name = "cmbGraficaOrient";
			this.cmbGraficaOrient.Size = new System.Drawing.Size(78, 22);
			this.cmbGraficaOrient.TabIndex = 153;
			this.cmbGraficaOrient.SelectedIndexChanged += new System.EventHandler(this.CmbGraficaOrientSelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(218, 13);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 20);
			this.label9.TabIndex = 152;
			this.label9.Text = "Orientacion";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(68, 13);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 20);
			this.label8.TabIndex = 151;
			this.label8.Text = "Colores";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbColorBarras
			// 
			this.cmbColorBarras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbColorBarras.FormattingEnabled = true;
			this.cmbColorBarras.Location = new System.Drawing.Point(68, 35);
			this.cmbColorBarras.Name = "cmbColorBarras";
			this.cmbColorBarras.Size = new System.Drawing.Size(126, 22);
			this.cmbColorBarras.TabIndex = 150;
			this.cmbColorBarras.SelectedIndexChanged += new System.EventHandler(this.CmbColorBarrasSelectedIndexChanged);
			// 
			// cbxVista3D
			// 
			this.cbxVista3D.Location = new System.Drawing.Point(6, 36);
			this.cbxVista3D.Name = "cbxVista3D";
			this.cbxVista3D.Size = new System.Drawing.Size(40, 24);
			this.cbxVista3D.TabIndex = 149;
			this.cbxVista3D.Text = "3D";
			this.cbxVista3D.UseVisualStyleBackColor = true;
			this.cbxVista3D.CheckedChanged += new System.EventHandler(this.CbxVista3DCheckedChanged);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 20);
			this.label7.TabIndex = 148;
			this.label7.Text = "Vista";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormExistencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1039, 783);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVerInforme);
			this.Controls.Add(this.chart1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormExistencia";
			this.Text = "FormExistencia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormExistenciaLoad);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox18.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbGraficaOrient;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox cbxVista3D;
		private System.Windows.Forms.ComboBox cmbColorBarras;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox txtIDProd;
		private System.Windows.Forms.Button btnBusquedaProd;
		private System.Windows.Forms.TextBox txtNombreProd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbTipInf;
		private System.Windows.Forms.ComboBox cmbCampoAgr;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbCAmpoAl;
		private System.Windows.Forms.ComboBox cmbSentidoOrd;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnVerInforme;
	}
}
