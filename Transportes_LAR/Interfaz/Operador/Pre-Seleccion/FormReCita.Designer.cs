/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 07/02/2017
 * Hora: 14:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormReCita
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReCita));
			this.label1 = new System.Windows.Forms.Label();
			this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
			this.btnAgenda = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 14);
			this.label1.TabIndex = 7;
			this.label1.Text = "Reagendar Cita:";
			// 
			// dtpHoraCita
			// 
			this.dtpHoraCita.CustomFormat = "HH:mm";
			this.dtpHoraCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraCita.Location = new System.Drawing.Point(192, 9);
			this.dtpHoraCita.Name = "dtpHoraCita";
			this.dtpHoraCita.ShowUpDown = true;
			this.dtpHoraCita.Size = new System.Drawing.Size(50, 20);
			this.dtpHoraCita.TabIndex = 6;
			// 
			// dtpFechaCita
			// 
			this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaCita.Location = new System.Drawing.Point(94, 9);
			this.dtpFechaCita.Name = "dtpFechaCita";
			this.dtpFechaCita.Size = new System.Drawing.Size(91, 20);
			this.dtpFechaCita.TabIndex = 5;
			// 
			// btnAgenda
			// 
			this.btnAgenda.AutoSize = true;
			this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
			this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgenda.Location = new System.Drawing.Point(253, 4);
			this.btnAgenda.Name = "btnAgenda";
			this.btnAgenda.Size = new System.Drawing.Size(30, 30);
			this.btnAgenda.TabIndex = 299;
			this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgenda.UseVisualStyleBackColor = true;
			this.btnAgenda.Click += new System.EventHandler(this.BtnAgendaClick);
			// 
			// FormReCita
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 37);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpHoraCita);
			this.Controls.Add(this.dtpFechaCita);
			this.Controls.Add(this.btnAgenda);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormReCita";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reagendar Cita:";
			this.Load += new System.EventHandler(this.FormReCitaLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormReCitaKeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAgenda;
		private System.Windows.Forms.DateTimePicker dtpFechaCita;
		private System.Windows.Forms.DateTimePicker dtpHoraCita;
		private System.Windows.Forms.Label label1;
	}
}
