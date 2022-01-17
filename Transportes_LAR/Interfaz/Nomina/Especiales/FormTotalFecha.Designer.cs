/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 16/07/2013
 * Time: 10:49 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormTotalFecha
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTotalFecha));
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmdMostrar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdGuardar.Location = new System.Drawing.Point(250, 19);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(111, 46);
			this.cmdGuardar.TabIndex = 0;
			this.cmdGuardar.Text = "Confirmar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// txtImporte
			// 
			this.txtImporte.Enabled = false;
			this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporte.Location = new System.Drawing.Point(137, 39);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(100, 26);
			this.txtImporte.TabIndex = 1;
			this.txtImporte.Text = "0.00";
			this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Fecha";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Enabled = false;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(137, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Importe";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Enabled = false;
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(9, 40);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(122, 22);
			this.dtpFecha.TabIndex = 4;
			// 
			// cmdMostrar
			// 
			this.cmdMostrar.Location = new System.Drawing.Point(30, 20);
			this.cmdMostrar.Name = "cmdMostrar";
			this.cmdMostrar.Size = new System.Drawing.Size(122, 23);
			this.cmdMostrar.TabIndex = 5;
			this.cmdMostrar.Text = "Mostrar";
			this.cmdMostrar.UseVisualStyleBackColor = true;
			this.cmdMostrar.Click += new System.EventHandler(this.CmdMostrarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpFecha);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtImporte);
			this.groupBox1.Controls.Add(this.cmdGuardar);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(367, 76);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Entraga de caja";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdMostrar);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 94);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(180, 52);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Servicios sin cobrrar";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmdImprimir);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(198, 94);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(181, 52);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Reporte de servicios";
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.Location = new System.Drawing.Point(30, 20);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.Size = new System.Drawing.Size(122, 23);
			this.cmdImprimir.TabIndex = 5;
			this.cmdImprimir.Text = "Imprimir";
			this.cmdImprimir.UseVisualStyleBackColor = true;
			this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
			// 
			// FormTotalFecha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 162);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(350, 110);
			this.Name = "FormTotalFecha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Total";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTotalFechaFormClosing);
			this.Load += new System.EventHandler(this.FormTotalFechaLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdImprimir;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdMostrar;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.Button cmdGuardar;
	}
}
