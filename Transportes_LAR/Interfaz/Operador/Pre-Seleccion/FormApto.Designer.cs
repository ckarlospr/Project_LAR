/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 13/02/2017
 * Hora: 11:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormApto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApto));
			this.label1 = new System.Windows.Forms.Label();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rbSi = new System.Windows.Forms.RadioButton();
			this.rbNo = new System.Windows.Forms.RadioButton();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnValida = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpHoraCita = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.rbBTno = new System.Windows.Forms.RadioButton();
			this.rbBTsi = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pnBolsa = new System.Windows.Forms.Panel();
			this.pnBolsa.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(188, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Motivo:";
			// 
			// txtMotivo
			// 
			this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMotivo.Enabled = false;
			this.txtMotivo.Location = new System.Drawing.Point(231, 44);
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(80, 20);
			this.txtMotivo.TabIndex = 3;
			this.txtMotivo.TextChanged += new System.EventHandler(this.TxtMotivoTextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(65, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Contratar :";
			// 
			// rbSi
			// 
			this.rbSi.AutoSize = true;
			this.rbSi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.rbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSi.Location = new System.Drawing.Point(144, 11);
			this.rbSi.Name = "rbSi";
			this.rbSi.Size = new System.Drawing.Size(38, 19);
			this.rbSi.TabIndex = 1;
			this.rbSi.TabStop = true;
			this.rbSi.Text = "SI";
			this.rbSi.UseVisualStyleBackColor = false;
			this.rbSi.CheckedChanged += new System.EventHandler(this.RbSiCheckedChanged);
			// 
			// rbNo
			// 
			this.rbNo.AutoSize = true;
			this.rbNo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNo.Location = new System.Drawing.Point(189, 11);
			this.rbNo.Name = "rbNo";
			this.rbNo.Size = new System.Drawing.Size(45, 19);
			this.rbNo.TabIndex = 2;
			this.rbNo.TabStop = true;
			this.rbNo.Text = "NO";
			this.rbNo.UseVisualStyleBackColor = false;
			this.rbNo.CheckedChanged += new System.EventHandler(this.RbNoCheckedChanged);
			// 
			// btnCancelar
			// 
			this.btnCancelar.AutoSize = true;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(78, 115);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(65, 30);
			this.btnCancelar.TabIndex = 299;
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnValida
			// 
			this.btnValida.AutoSize = true;
			this.btnValida.Enabled = false;
			this.btnValida.Image = ((System.Drawing.Image)(resources.GetObject("btnValida.Image")));
			this.btnValida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnValida.Location = new System.Drawing.Point(151, 115);
			this.btnValida.Name = "btnValida";
			this.btnValida.Size = new System.Drawing.Size(70, 30);
			this.btnValida.TabIndex = 298;
			this.btnValida.Text = "Aceptar";
			this.btnValida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnValida.UseVisualStyleBackColor = true;
			this.btnValida.Click += new System.EventHandler(this.BtnValidaClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(315, 3);
			this.label4.TabIndex = 300;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 14);
			this.label2.TabIndex = 303;
			this.label2.Text = "Reagendar Cita:";
			// 
			// dtpHoraCita
			// 
			this.dtpHoraCita.CustomFormat = "HH:mm";
			this.dtpHoraCita.Enabled = false;
			this.dtpHoraCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraCita.Location = new System.Drawing.Point(191, 79);
			this.dtpHoraCita.Name = "dtpHoraCita";
			this.dtpHoraCita.ShowUpDown = true;
			this.dtpHoraCita.Size = new System.Drawing.Size(50, 20);
			this.dtpHoraCita.TabIndex = 302;
			// 
			// dtpFechaCita
			// 
			this.dtpFechaCita.Enabled = false;
			this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaCita.Location = new System.Drawing.Point(93, 78);
			this.dtpFechaCita.Name = "dtpFechaCita";
			this.dtpFechaCita.Size = new System.Drawing.Size(91, 20);
			this.dtpFechaCita.TabIndex = 301;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(182, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(3, 30);
			this.label5.TabIndex = 305;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rbBTno
			// 
			this.rbBTno.AutoSize = true;
			this.rbBTno.Location = new System.Drawing.Point(134, 4);
			this.rbBTno.Name = "rbBTno";
			this.rbBTno.Size = new System.Drawing.Size(41, 17);
			this.rbBTno.TabIndex = 307;
			this.rbBTno.TabStop = true;
			this.rbBTno.Text = "NO";
			this.rbBTno.UseVisualStyleBackColor = true;
			this.rbBTno.CheckedChanged += new System.EventHandler(this.RbBTnoCheckedChanged);
			// 
			// rbBTsi
			// 
			this.rbBTsi.AutoSize = true;
			this.rbBTsi.Location = new System.Drawing.Point(94, 4);
			this.rbBTsi.Name = "rbBTsi";
			this.rbBTsi.Size = new System.Drawing.Size(35, 17);
			this.rbBTsi.TabIndex = 306;
			this.rbBTsi.TabStop = true;
			this.rbBTsi.Text = "SI";
			this.rbBTsi.UseVisualStyleBackColor = true;
			this.rbBTsi.CheckedChanged += new System.EventHandler(this.RbBTsiCheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 13);
			this.label6.TabIndex = 308;
			this.label6.Text = "Bolsa de Trabajo:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(0, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(315, 3);
			this.label7.TabIndex = 309;
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(0, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(315, 3);
			this.label8.TabIndex = 310;
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(315, 36);
			this.label9.TabIndex = 311;
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnBolsa
			// 
			this.pnBolsa.Controls.Add(this.rbBTno);
			this.pnBolsa.Controls.Add(this.label6);
			this.pnBolsa.Controls.Add(this.rbBTsi);
			this.pnBolsa.Location = new System.Drawing.Point(0, 42);
			this.pnBolsa.Name = "pnBolsa";
			this.pnBolsa.Size = new System.Drawing.Size(182, 24);
			this.pnBolsa.TabIndex = 312;
			// 
			// FormApto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 151);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.pnBolsa);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpHoraCita);
			this.Controls.Add(this.dtpFechaCita);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnValida);
			this.Controls.Add(this.rbNo);
			this.Controls.Add(this.rbSi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label9);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormApto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Apto / No Apto";
			this.Load += new System.EventHandler(this.FormAptoLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormAptoKeyUp);
			this.pnBolsa.ResumeLayout(false);
			this.pnBolsa.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel pnBolsa;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rbBTsi;
		private System.Windows.Forms.RadioButton rbBTno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFechaCita;
		private System.Windows.Forms.DateTimePicker dtpHoraCita;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnValida;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.RadioButton rbNo;
		private System.Windows.Forms.RadioButton rbSi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMotivo;
		private System.Windows.Forms.Label label1;
	}
}
