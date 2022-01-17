/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 19/11/2016
 * Time: 11:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormReportesAltaBajaOperador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportesAltaBajaOperador));
			this.lblPeriodo = new System.Windows.Forms.Label();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.btnPostventa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPeriodo
			// 
			this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
			this.lblPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeriodo.Location = new System.Drawing.Point(12, 31);
			this.lblPeriodo.Name = "lblPeriodo";
			this.lblPeriodo.Size = new System.Drawing.Size(43, 20);
			this.lblPeriodo.TabIndex = 149;
			this.lblPeriodo.Text = "Periodo";
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(178, 29);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(96, 20);
			this.dtCorte.TabIndex = 152;
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(163, 30);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(11, 22);
			this.lblFechaCorte.TabIndex = 150;
			this.lblFechaCorte.Text = "-";
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(56, 29);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(104, 20);
			this.dtInicio.TabIndex = 151;
			this.dtInicio.ValueChanged += new System.EventHandler(this.DtInicioValueChanged);
			// 
			// btnPostventa
			// 
			this.btnPostventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPostventa.Image = ((System.Drawing.Image)(resources.GetObject("btnPostventa.Image")));
			this.btnPostventa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPostventa.Location = new System.Drawing.Point(287, 8);
			this.btnPostventa.Name = "btnPostventa";
			this.btnPostventa.Size = new System.Drawing.Size(92, 51);
			this.btnPostventa.TabIndex = 153;
			this.btnPostventa.Tag = "Reporte para obtener encuesta de los servicios realizados";
			this.btnPostventa.Text = "Reporte";
			this.btnPostventa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPostventa.UseVisualStyleBackColor = true;
			this.btnPostventa.Click += new System.EventHandler(this.BtnPostventaClick);
			// 
			// FormReportesAltaBajaOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 69);
			this.Controls.Add(this.lblPeriodo);
			this.Controls.Add(this.dtCorte);
			this.Controls.Add(this.lblFechaCorte);
			this.Controls.Add(this.dtInicio);
			this.Controls.Add(this.btnPostventa);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(399, 108);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(399, 108);
			this.Name = "FormReportesAltaBajaOperador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alta-Baja Operador";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportesAltaBajaOperadorFormClosing);
			this.Load += new System.EventHandler(this.FormReportesAltaBajaOperadorLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnPostventa;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.Label lblPeriodo;
	}
}
