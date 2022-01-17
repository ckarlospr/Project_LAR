/*
 * Created by SharpDevelop.
 * User: Estandar
 * Date: 04/03/2016
 * Time: 9:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Unidad.Gestoria
{
	partial class FormParametrosGestoria
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametrosGestoria));
			this.btnGuardar = new System.Windows.Forms.Button();
			this.nudPermiso = new System.Windows.Forms.NumericUpDown();
			this.nudRefrendo = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.nudPoliza = new System.Windows.Forms.NumericUpDown();
			this.nudVerifixcacion = new System.Windows.Forms.NumericUpDown();
			this.nudFisico = new System.Windows.Forms.NumericUpDown();
			this.nudcasetas = new System.Windows.Forms.NumericUpDown();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nudCaseta2 = new System.Windows.Forms.NumericUpDown();
			this.panel2 = new System.Windows.Forms.Panel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nudPermiso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRefrendo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPoliza)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVerifixcacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFisico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudcasetas)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCaseta2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(68, 268);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(82, 44);
			this.btnGuardar.TabIndex = 3;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// nudPermiso
			// 
			this.nudPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudPermiso.Location = new System.Drawing.Point(112, 68);
			this.nudPermiso.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.nudPermiso.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudPermiso.Name = "nudPermiso";
			this.nudPermiso.Size = new System.Drawing.Size(60, 20);
			this.nudPermiso.TabIndex = 160;
			this.nudPermiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudPermiso.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// nudRefrendo
			// 
			this.nudRefrendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudRefrendo.Location = new System.Drawing.Point(112, 38);
			this.nudRefrendo.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.nudRefrendo.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudRefrendo.Name = "nudRefrendo";
			this.nudRefrendo.Size = new System.Drawing.Size(60, 20);
			this.nudRefrendo.TabIndex = 159;
			this.nudRefrendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudRefrendo.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 23);
			this.label3.TabIndex = 158;
			this.label3.Text = "UNIDAD DE MEDIDA POR MES";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 23);
			this.label2.TabIndex = 157;
			this.label2.Text = "PERMISO:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 156;
			this.label1.Text = "REFRENDO:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(11, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 23);
			this.label5.TabIndex = 164;
			this.label5.Text = "CASETAS1:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(11, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 23);
			this.label6.TabIndex = 165;
			this.label6.Text = "FISICOMECANICO:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(11, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 23);
			this.label7.TabIndex = 166;
			this.label7.Text = "VERIFICACIÓN:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(11, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 23);
			this.label8.TabIndex = 167;
			this.label8.Text = "POLIZA:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 229);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 23);
			this.label9.TabIndex = 168;
			this.label9.Text = "CASETAS2:";
			// 
			// nudPoliza
			// 
			this.nudPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudPoliza.Location = new System.Drawing.Point(112, 100);
			this.nudPoliza.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.nudPoliza.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudPoliza.Name = "nudPoliza";
			this.nudPoliza.Size = new System.Drawing.Size(60, 20);
			this.nudPoliza.TabIndex = 170;
			this.nudPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudPoliza.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// nudVerifixcacion
			// 
			this.nudVerifixcacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudVerifixcacion.Location = new System.Drawing.Point(112, 130);
			this.nudVerifixcacion.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.nudVerifixcacion.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudVerifixcacion.Name = "nudVerifixcacion";
			this.nudVerifixcacion.Size = new System.Drawing.Size(60, 20);
			this.nudVerifixcacion.TabIndex = 173;
			this.nudVerifixcacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudVerifixcacion.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// nudFisico
			// 
			this.nudFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudFisico.Location = new System.Drawing.Point(112, 162);
			this.nudFisico.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.nudFisico.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudFisico.Name = "nudFisico";
			this.nudFisico.Size = new System.Drawing.Size(60, 20);
			this.nudFisico.TabIndex = 176;
			this.nudFisico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudFisico.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// nudcasetas
			// 
			this.nudcasetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudcasetas.Location = new System.Drawing.Point(112, 194);
			this.nudcasetas.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.nudcasetas.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudcasetas.Name = "nudcasetas";
			this.nudcasetas.Size = new System.Drawing.Size(60, 20);
			this.nudcasetas.TabIndex = 179;
			this.nudcasetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudcasetas.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel6.Controls.Add(this.panel1);
			this.panel6.Location = new System.Drawing.Point(0, 258);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(220, 5);
			this.panel6.TabIndex = 183;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Location = new System.Drawing.Point(0, -47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(220, 5);
			this.panel1.TabIndex = 184;
			// 
			// nudCaseta2
			// 
			this.nudCaseta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudCaseta2.Location = new System.Drawing.Point(112, 227);
			this.nudCaseta2.Maximum = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.nudCaseta2.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudCaseta2.Name = "nudCaseta2";
			this.nudCaseta2.Size = new System.Drawing.Size(60, 20);
			this.nudCaseta2.TabIndex = 182;
			this.nudCaseta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudCaseta2.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Location = new System.Drawing.Point(-3, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(220, 5);
			this.panel2.TabIndex = 184;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormParametrosGestoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 315);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.nudCaseta2);
			this.Controls.Add(this.nudcasetas);
			this.Controls.Add(this.nudFisico);
			this.Controls.Add(this.nudVerifixcacion);
			this.Controls.Add(this.nudPoliza);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudPermiso);
			this.Controls.Add(this.nudRefrendo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label9);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(230, 354);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(230, 354);
			this.Name = "FormParametrosGestoria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parametros";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParametrosGestoriaFormClosing);
			this.Load += new System.EventHandler(this.FormParametrosGestoriaLoad);
			((System.ComponentModel.ISupportInitialize)(this.nudPermiso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRefrendo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPoliza)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudVerifixcacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFisico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudcasetas)).EndInit();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudCaseta2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.NumericUpDown nudCaseta2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		public System.Windows.Forms.NumericUpDown nudcasetas;
		public System.Windows.Forms.NumericUpDown nudFisico;
		public System.Windows.Forms.NumericUpDown nudVerifixcacion;
		public System.Windows.Forms.NumericUpDown nudPoliza;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.NumericUpDown nudRefrendo;
		public System.Windows.Forms.NumericUpDown nudPermiso;
		private System.Windows.Forms.Button btnGuardar;
	}
}
