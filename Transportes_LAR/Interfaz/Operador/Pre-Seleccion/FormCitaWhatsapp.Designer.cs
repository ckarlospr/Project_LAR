/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 06/06/2017
 * Time: 12:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormCitaWhatsapp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitaWhatsapp));
			this.label1 = new System.Windows.Forms.Label();
			this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
			this.btnWhatsappAI = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 14);
			this.label1.TabIndex = 302;
			this.label1.Text = "Cita:";
			// 
			// dtpHoraCita
			// 
			this.dtpHoraCita.CustomFormat = "HH:mm";
			this.dtpHoraCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraCita.Location = new System.Drawing.Point(128, 9);
			this.dtpHoraCita.Name = "dtpHoraCita";
			this.dtpHoraCita.ShowUpDown = true;
			this.dtpHoraCita.Size = new System.Drawing.Size(50, 20);
			this.dtpHoraCita.TabIndex = 301;
			// 
			// dtpFechaCita
			// 
			this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaCita.Location = new System.Drawing.Point(32, 9);
			this.dtpFechaCita.Name = "dtpFechaCita";
			this.dtpFechaCita.Size = new System.Drawing.Size(91, 20);
			this.dtpFechaCita.TabIndex = 300;
			// 
			// btnWhatsappAI
			// 
			this.btnWhatsappAI.AutoSize = true;
			this.btnWhatsappAI.Image = ((System.Drawing.Image)(resources.GetObject("btnWhatsappAI.Image")));
			this.btnWhatsappAI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnWhatsappAI.Location = new System.Drawing.Point(194, 3);
			this.btnWhatsappAI.Name = "btnWhatsappAI";
			this.btnWhatsappAI.Size = new System.Drawing.Size(30, 31);
			this.btnWhatsappAI.TabIndex = 304;
			this.btnWhatsappAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnWhatsappAI.UseVisualStyleBackColor = true;
			this.btnWhatsappAI.Click += new System.EventHandler(this.BtnWhatsappAIClick);
			// 
			// FormCitaWhatsapp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 41);
			this.Controls.Add(this.btnWhatsappAI);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpHoraCita);
			this.Controls.Add(this.dtpFechaCita);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(255, 70);
			this.MinimumSize = new System.Drawing.Size(255, 70);
			this.Name = "FormCitaWhatsapp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormCitaWhatsappLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCitaWhatsappKeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnWhatsappAI;
		private System.Windows.Forms.DateTimePicker dtpFechaCita;
		private System.Windows.Forms.DateTimePicker dtpHoraCita;
		private System.Windows.Forms.Label label1;
	}
}
