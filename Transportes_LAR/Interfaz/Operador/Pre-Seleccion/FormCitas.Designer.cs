/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 03/02/2017
 * Hora: 11:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormCitas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitas));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnValida = new System.Windows.Forms.Button();
			this.gbCitas = new System.Windows.Forms.GroupBox();
			this.dtpHoraCitaMedico = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaCitaMedico = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpHoraCitaManejo = new System.Windows.Forms.DateTimePicker();
			this.label36 = new System.Windows.Forms.Label();
			this.dtpFechaCitaManejo = new System.Windows.Forms.DateTimePicker();
			this.gbCitas.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.AutoSize = true;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(299, 40);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(65, 31);
			this.btnCancelar.TabIndex = 297;
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnValida
			// 
			this.btnValida.AutoSize = true;
			this.btnValida.Image = ((System.Drawing.Image)(resources.GetObject("btnValida.Image")));
			this.btnValida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnValida.Location = new System.Drawing.Point(299, 3);
			this.btnValida.Name = "btnValida";
			this.btnValida.Size = new System.Drawing.Size(65, 31);
			this.btnValida.TabIndex = 296;
			this.btnValida.Text = "Valida";
			this.btnValida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnValida.UseVisualStyleBackColor = true;
			this.btnValida.Click += new System.EventHandler(this.BtnValidaClick);
			// 
			// gbCitas
			// 
			this.gbCitas.Controls.Add(this.dtpHoraCitaMedico);
			this.gbCitas.Controls.Add(this.dtpFechaCitaMedico);
			this.gbCitas.Controls.Add(this.label1);
			this.gbCitas.Controls.Add(this.dtpHoraCitaManejo);
			this.gbCitas.Controls.Add(this.label36);
			this.gbCitas.Controls.Add(this.dtpFechaCitaManejo);
			this.gbCitas.Location = new System.Drawing.Point(3, 1);
			this.gbCitas.Name = "gbCitas";
			this.gbCitas.Size = new System.Drawing.Size(291, 70);
			this.gbCitas.TabIndex = 298;
			this.gbCitas.TabStop = false;
			this.gbCitas.Text = "Citas";
			// 
			// dtpHoraCitaMedico
			// 
			this.dtpHoraCitaMedico.CustomFormat = "HH:mm";
			this.dtpHoraCitaMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraCitaMedico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraCitaMedico.Location = new System.Drawing.Point(228, 40);
			this.dtpHoraCitaMedico.Name = "dtpHoraCitaMedico";
			this.dtpHoraCitaMedico.ShowUpDown = true;
			this.dtpHoraCitaMedico.Size = new System.Drawing.Size(50, 20);
			this.dtpHoraCitaMedico.TabIndex = 9;
			this.dtpHoraCitaMedico.ValueChanged += new System.EventHandler(this.DtpHoraCitaMedicoValueChanged);
			// 
			// dtpFechaCitaMedico
			// 
			this.dtpFechaCitaMedico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaCitaMedico.Location = new System.Drawing.Point(131, 40);
			this.dtpFechaCitaMedico.Name = "dtpFechaCitaMedico";
			this.dtpFechaCitaMedico.Size = new System.Drawing.Size(91, 20);
			this.dtpFechaCitaMedico.TabIndex = 8;
			this.dtpFechaCitaMedico.ValueChanged += new System.EventHandler(this.DtpFechaCitaMedicoValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 14);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cita Examen Manejo:";
			// 
			// dtpHoraCitaManejo
			// 
			this.dtpHoraCitaManejo.CustomFormat = "HH:mm";
			this.dtpHoraCitaManejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraCitaManejo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraCitaManejo.Location = new System.Drawing.Point(228, 17);
			this.dtpHoraCitaManejo.Name = "dtpHoraCitaManejo";
			this.dtpHoraCitaManejo.ShowUpDown = true;
			this.dtpHoraCitaManejo.Size = new System.Drawing.Size(50, 20);
			this.dtpHoraCitaManejo.TabIndex = 6;
			this.dtpHoraCitaManejo.ValueChanged += new System.EventHandler(this.DtpHoraCitaManejoValueChanged);
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(22, 41);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(106, 14);
			this.label36.TabIndex = 4;
			this.label36.Text = "Cita Examen Medico:";
			// 
			// dtpFechaCitaManejo
			// 
			this.dtpFechaCitaManejo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaCitaManejo.Location = new System.Drawing.Point(131, 17);
			this.dtpFechaCitaManejo.Name = "dtpFechaCitaManejo";
			this.dtpFechaCitaManejo.Size = new System.Drawing.Size(91, 20);
			this.dtpFechaCitaManejo.TabIndex = 5;
			this.dtpFechaCitaManejo.ValueChanged += new System.EventHandler(this.DtpFechaCitaManejoValueChanged);
			// 
			// FormCitas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 76);
			this.Controls.Add(this.gbCitas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnValida);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(385, 115);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(385, 115);
			this.Name = "FormCitas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Citas";
			this.Load += new System.EventHandler(this.FormCitasLoad);
			this.gbCitas.ResumeLayout(false);
			this.gbCitas.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dtpFechaCitaManejo;
		private System.Windows.Forms.DateTimePicker dtpHoraCitaManejo;
		private System.Windows.Forms.DateTimePicker dtpFechaCitaMedico;
		private System.Windows.Forms.DateTimePicker dtpHoraCitaMedico;
		private System.Windows.Forms.Button btnValida;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbCitas;
		private System.Windows.Forms.Button btnCancelar;
	}
}
