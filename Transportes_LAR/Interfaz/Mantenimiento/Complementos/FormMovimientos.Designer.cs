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
	partial class FormMovimientos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimientos));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNombreProd = new System.Windows.Forms.TextBox();
			this.btnBusquedaProd = new System.Windows.Forms.Button();
			this.txtIDProd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCampoAgrM = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.cmbSentidoOrdM = new System.Windows.Forms.ComboBox();
			this.cmbCAmpoAlM = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
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
			this.groupBox2.Location = new System.Drawing.Point(11, 121);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(740, 69);
			this.groupBox2.TabIndex = 158;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "FILTRADO";
			// 
			// txtNombreProd
			// 
			this.txtNombreProd.Location = new System.Drawing.Point(363, 39);
			this.txtNombreProd.Name = "txtNombreProd";
			this.txtNombreProd.Size = new System.Drawing.Size(227, 20);
			this.txtNombreProd.TabIndex = 152;
			// 
			// btnBusquedaProd
			// 
			this.btnBusquedaProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaProd.Image")));
			this.btnBusquedaProd.Location = new System.Drawing.Point(323, 38);
			this.btnBusquedaProd.Name = "btnBusquedaProd";
			this.btnBusquedaProd.Size = new System.Drawing.Size(34, 23);
			this.btnBusquedaProd.TabIndex = 151;
			this.btnBusquedaProd.UseVisualStyleBackColor = true;
			// 
			// txtIDProd
			// 
			this.txtIDProd.Location = new System.Drawing.Point(258, 39);
			this.txtIDProd.Name = "txtIDProd";
			this.txtIDProd.Size = new System.Drawing.Size(68, 20);
			this.txtIDProd.TabIndex = 150;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 16);
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
			this.label6.Location = new System.Drawing.Point(258, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 20);
			this.label6.TabIndex = 143;
			this.label6.Text = "Producto";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmbCampoAgrM);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(420, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(206, 69);
			this.groupBox1.TabIndex = 159;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "AGRUPACIÓN";
			// 
			// cmbCampoAgrM
			// 
			this.cmbCampoAgrM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCampoAgrM.FormattingEnabled = true;
			this.cmbCampoAgrM.Location = new System.Drawing.Point(10, 36);
			this.cmbCampoAgrM.Name = "cmbCampoAgrM";
			this.cmbCampoAgrM.Size = new System.Drawing.Size(172, 22);
			this.cmbCampoAgrM.TabIndex = 150;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 20);
			this.label4.TabIndex = 143;
			this.label4.Text = "Campo de agrupación";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.cmbSentidoOrdM);
			this.groupBox18.Controls.Add(this.cmbCAmpoAlM);
			this.groupBox18.Controls.Add(this.label2);
			this.groupBox18.Controls.Add(this.label10);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(11, 35);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(386, 69);
			this.groupBox18.TabIndex = 157;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "ORDENACIÓN";
			// 
			// cmbSentidoOrdM
			// 
			this.cmbSentidoOrdM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSentidoOrdM.FormattingEnabled = true;
			this.cmbSentidoOrdM.Location = new System.Drawing.Point(239, 36);
			this.cmbSentidoOrdM.Name = "cmbSentidoOrdM";
			this.cmbSentidoOrdM.Size = new System.Drawing.Size(128, 22);
			this.cmbSentidoOrdM.TabIndex = 150;
			// 
			// cmbCAmpoAlM
			// 
			this.cmbCAmpoAlM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCAmpoAlM.FormattingEnabled = true;
			this.cmbCAmpoAlM.Location = new System.Drawing.Point(7, 36);
			this.cmbCAmpoAlM.Name = "cmbCAmpoAlM";
			this.cmbCAmpoAlM.Size = new System.Drawing.Size(178, 22);
			this.cmbCAmpoAlM.TabIndex = 149;
			this.cmbCAmpoAlM.SelectedIndexChanged += new System.EventHandler(this.CmbCAmpoAlSelectedIndexChanged);
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
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Gainsboro;
			this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Weave;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(11, 196);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(740, 551);
			this.chart1.TabIndex = 155;
			this.chart1.Text = "chart1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(632, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 30);
			this.button1.TabIndex = 153;
			this.button1.Text = "Ver informe";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gray;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(980, 32);
			this.label1.TabIndex = 156;
			this.label1.Text = "Parametrizacion del informe";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(7, 39);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 153;
			// 
			// FormMovimientos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1039, 783);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chart1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMovimientos";
			this.Text = "FormMovimientos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormMovimientosLoad);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbCAmpoAlM;
		private System.Windows.Forms.ComboBox cmbSentidoOrdM;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbCampoAgrM;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIDProd;
		private System.Windows.Forms.Button btnBusquedaProd;
		private System.Windows.Forms.TextBox txtNombreProd;
		private System.Windows.Forms.GroupBox groupBox2;
		
		void CmbCAmpoAlSelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
