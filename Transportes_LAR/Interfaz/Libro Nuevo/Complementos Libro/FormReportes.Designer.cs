/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 22/12/2015
 * Hora: 13:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormReportes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
			this.lblPeriodo = new System.Windows.Forms.Label();
			this.btnDia = new System.Windows.Forms.Button();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.btnUsuarios = new System.Windows.Forms.Button();
			this.btnPostventa = new System.Windows.Forms.Button();
			this.btnCancelados = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCombuEspeciales = new System.Windows.Forms.Button();
			this.btnReporteFull = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbConfiguraciones = new System.Windows.Forms.PictureBox();
			this.btnReporteEnvio = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnTotal = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.ReporteApoyos = new System.Windows.Forms.Button();
			this.btnCotizaciones = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPeriodo
			// 
			this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
			this.lblPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeriodo.Location = new System.Drawing.Point(131, 14);
			this.lblPeriodo.Name = "lblPeriodo";
			this.lblPeriodo.Size = new System.Drawing.Size(43, 22);
			this.lblPeriodo.TabIndex = 143;
			this.lblPeriodo.Text = "Periodo";
			// 
			// btnDia
			// 
			this.btnDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDia.Image = ((System.Drawing.Image)(resources.GetObject("btnDia.Image")));
			this.btnDia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnDia.Location = new System.Drawing.Point(8, 40);
			this.btnDia.Name = "btnDia";
			this.btnDia.Size = new System.Drawing.Size(80, 51);
			this.btnDia.TabIndex = 76;
			this.btnDia.Tag = "Reporte para obtener informacion al dia de todas las cotizaciones y servicios";
			this.btnDia.Text = "General";
			this.btnDia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDia.UseVisualStyleBackColor = true;
			this.btnDia.Click += new System.EventHandler(this.BtnExcelReporteClick);
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(288, 14);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(11, 22);
			this.lblFechaCorte.TabIndex = 144;
			this.lblFechaCorte.Text = "-";
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(180, 14);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(104, 20);
			this.dtInicio.TabIndex = 145;
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(305, 14);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(96, 20);
			this.dtCorte.TabIndex = 146;
			// 
			// btnUsuarios
			// 
			this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
			this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUsuarios.Location = new System.Drawing.Point(178, 40);
			this.btnUsuarios.Name = "btnUsuarios";
			this.btnUsuarios.Size = new System.Drawing.Size(80, 51);
			this.btnUsuarios.TabIndex = 147;
			this.btnUsuarios.Tag = "Reporte de los servicios que seran pagados por el operador";
			this.btnUsuarios.Text = "P Operador";
			this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnUsuarios.UseVisualStyleBackColor = true;
			this.btnUsuarios.Click += new System.EventHandler(this.BtnUsuariosClick);
			// 
			// btnPostventa
			// 
			this.btnPostventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPostventa.Image = ((System.Drawing.Image)(resources.GetObject("btnPostventa.Image")));
			this.btnPostventa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPostventa.Location = new System.Drawing.Point(265, 40);
			this.btnPostventa.Name = "btnPostventa";
			this.btnPostventa.Size = new System.Drawing.Size(80, 51);
			this.btnPostventa.TabIndex = 148;
			this.btnPostventa.Tag = "Reporte para obtener encuesta de los servicios realizados";
			this.btnPostventa.Text = "Post Venta";
			this.btnPostventa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPostventa.UseVisualStyleBackColor = true;
			this.btnPostventa.Click += new System.EventHandler(this.BtnPostventaClick);
			// 
			// btnCancelados
			// 
			this.btnCancelados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelados.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelados.Image")));
			this.btnCancelados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelados.Location = new System.Drawing.Point(352, 40);
			this.btnCancelados.Name = "btnCancelados";
			this.btnCancelados.Size = new System.Drawing.Size(80, 51);
			this.btnCancelados.TabIndex = 149;
			this.btnCancelados.Tag = "Reporte para obtener servicios cancelados y porque";
			this.btnCancelados.Text = "Cancelados";
			this.btnCancelados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelados.UseVisualStyleBackColor = true;
			this.btnCancelados.Click += new System.EventHandler(this.BtnCanceladosClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCombuEspeciales);
			this.groupBox1.Controls.Add(this.btnReporteFull);
			this.groupBox1.Controls.Add(this.btnDia);
			this.groupBox1.Controls.Add(this.lblPeriodo);
			this.groupBox1.Controls.Add(this.btnCancelados);
			this.groupBox1.Controls.Add(this.dtCorte);
			this.groupBox1.Controls.Add(this.lblFechaCorte);
			this.groupBox1.Controls.Add(this.btnUsuarios);
			this.groupBox1.Controls.Add(this.dtInicio);
			this.groupBox1.Controls.Add(this.btnPostventa);
			this.groupBox1.Location = new System.Drawing.Point(4, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(531, 100);
			this.groupBox1.TabIndex = 150;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rerpotes";
			// 
			// btnCombuEspeciales
			// 
			this.btnCombuEspeciales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCombuEspeciales.Image = ((System.Drawing.Image)(resources.GetObject("btnCombuEspeciales.Image")));
			this.btnCombuEspeciales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCombuEspeciales.Location = new System.Drawing.Point(441, 40);
			this.btnCombuEspeciales.Name = "btnCombuEspeciales";
			this.btnCombuEspeciales.Size = new System.Drawing.Size(80, 51);
			this.btnCombuEspeciales.TabIndex = 151;
			this.btnCombuEspeciales.Tag = "Reporte para obtener servicios cancelados y porque";
			this.btnCombuEspeciales.Text = "CEspeciales";
			this.btnCombuEspeciales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCombuEspeciales.UseVisualStyleBackColor = true;
			this.btnCombuEspeciales.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnReporteFull
			// 
			this.btnReporteFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporteFull.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteFull.Image")));
			this.btnReporteFull.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReporteFull.Location = new System.Drawing.Point(93, 40);
			this.btnReporteFull.Name = "btnReporteFull";
			this.btnReporteFull.Size = new System.Drawing.Size(80, 51);
			this.btnReporteFull.TabIndex = 150;
			this.btnReporteFull.Tag = "Reporte de los servicios realizados con operador y vehiculo";
			this.btnReporteFull.Text = "Completo";
			this.btnReporteFull.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnReporteFull.UseVisualStyleBackColor = true;
			this.btnReporteFull.Click += new System.EventHandler(this.BtnReporteFullClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCotizaciones);
			this.groupBox2.Controls.Add(this.pbConfiguraciones);
			this.groupBox2.Controls.Add(this.btnReporteEnvio);
			this.groupBox2.Location = new System.Drawing.Point(184, 131);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(351, 78);
			this.groupBox2.TabIndex = 151;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Envio de Rerpotes";
			// 
			// pbConfiguraciones
			// 
			this.pbConfiguraciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pbConfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("pbConfiguraciones.Image")));
			this.pbConfiguraciones.Location = new System.Drawing.Point(314, 7);
			this.pbConfiguraciones.Name = "pbConfiguraciones";
			this.pbConfiguraciones.Size = new System.Drawing.Size(33, 32);
			this.pbConfiguraciones.TabIndex = 111;
			this.pbConfiguraciones.TabStop = false;
			this.pbConfiguraciones.Visible = false;
			this.pbConfiguraciones.Click += new System.EventHandler(this.PbConfiguracionesClick);
			// 
			// btnReporteEnvio
			// 
			this.btnReporteEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporteEnvio.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteEnvio.Image")));
			this.btnReporteEnvio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReporteEnvio.Location = new System.Drawing.Point(35, 19);
			this.btnReporteEnvio.Name = "btnReporteEnvio";
			this.btnReporteEnvio.Size = new System.Drawing.Size(92, 51);
			this.btnReporteEnvio.TabIndex = 76;
			this.btnReporteEnvio.Tag = "Reporte de viajes especiales para enviar";
			this.btnReporteEnvio.Text = "Envio";
			this.btnReporteEnvio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnReporteEnvio.UseVisualStyleBackColor = true;
			this.btnReporteEnvio.Click += new System.EventHandler(this.BtnReporteEnvioClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel4.Location = new System.Drawing.Point(12, 110);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(523, 11);
			this.panel4.TabIndex = 152;
			// 
			// btnTotal
			// 
			this.btnTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTotal.Image = ((System.Drawing.Image)(resources.GetObject("btnTotal.Image")));
			this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTotal.Location = new System.Drawing.Point(12, 137);
			this.btnTotal.Name = "btnTotal";
			this.btnTotal.Size = new System.Drawing.Size(80, 51);
			this.btnTotal.TabIndex = 153;
			this.btnTotal.Tag = "Reporte para obtener informacion al dia de todas las cotizaciones y servicios";
			this.btnTotal.Text = "Total";
			this.btnTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTotal.UseVisualStyleBackColor = true;
			this.btnTotal.Click += new System.EventHandler(this.BtnTotalClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(12, 172);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 37);
			this.button1.TabIndex = 154;
			this.button1.Tag = "Reporte para obtener informacion al dia de todas las cotizaciones y servicios";
			this.button1.Text = "Reporte Especiales";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// ReporteApoyos
			// 
			this.ReporteApoyos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ReporteApoyos.Image = ((System.Drawing.Image)(resources.GetObject("ReporteApoyos.Image")));
			this.ReporteApoyos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.ReporteApoyos.Location = new System.Drawing.Point(98, 137);
			this.ReporteApoyos.Name = "ReporteApoyos";
			this.ReporteApoyos.Size = new System.Drawing.Size(80, 51);
			this.ReporteApoyos.TabIndex = 155;
			this.ReporteApoyos.Tag = "Reporte para obtener informacion de los apoyos";
			this.ReporteApoyos.Text = "Apoyos";
			this.ReporteApoyos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.ReporteApoyos.UseVisualStyleBackColor = true;
			this.ReporteApoyos.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnCotizaciones
			// 
			this.btnCotizaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCotizaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCotizaciones.Location = new System.Drawing.Point(172, 19);
			this.btnCotizaciones.Name = "btnCotizaciones";
			this.btnCotizaciones.Size = new System.Drawing.Size(92, 51);
			this.btnCotizaciones.TabIndex = 112;
			this.btnCotizaciones.Tag = "Reporte de viajes especiales para enviar";
			this.btnCotizaciones.Text = "Cotizaciones";
			this.btnCotizaciones.UseVisualStyleBackColor = true;
			this.btnCotizaciones.Click += new System.EventHandler(this.BtnCotizacionesClick);
			// 
			// FormReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 216);
			this.Controls.Add(this.ReporteApoyos);
			this.Controls.Add(this.btnTotal);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(563, 255);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(563, 255);
			this.Name = "FormReportes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reportes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportesFormClosing);
			this.Load += new System.EventHandler(this.FormReportesLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCotizaciones;
		private System.Windows.Forms.Button ReporteApoyos;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnTotal;
		private System.Windows.Forms.Button btnCombuEspeciales;
		private System.Windows.Forms.Button btnReporteFull;
		private System.Windows.Forms.PictureBox pbConfiguraciones;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnReporteEnvio;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCancelados;
		private System.Windows.Forms.Button btnPostventa;
		private System.Windows.Forms.Button btnUsuarios;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.Button btnDia;
		private System.Windows.Forms.Label lblPeriodo;
	}
}
