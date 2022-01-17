/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 15/07/2012
 * Time: 16:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	partial class FormDependiente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDependiente));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.cmbParentesco = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 51);
			this.panel1.TabIndex = 25;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(7, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modifique los datos del dependiente:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancelar);
			this.panel2.Controls.Add(this.label18);
			this.panel2.Controls.Add(this.btnAgregar);
			this.panel2.Controls.Add(this.dateNacimiento);
			this.panel2.Controls.Add(this.cmbSexo);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.cmbParentesco);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(0, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(301, 152);
			this.panel2.TabIndex = 26;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(197, 113);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(86, 30);
			this.btnCancelar.TabIndex = 28;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(4, 88);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(73, 14);
			this.label18.TabIndex = 29;
			this.label18.Text = "F. Nacimiento:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(108, 113);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(83, 30);
			this.btnAgregar.TabIndex = 27;
			this.btnAgregar.Text = "Aceptar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// dateNacimiento
			// 
			this.dateNacimiento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateNacimiento.Location = new System.Drawing.Point(85, 86);
			this.dateNacimiento.Name = "dateNacimiento";
			this.dateNacimiento.Size = new System.Drawing.Size(195, 20);
			this.dateNacimiento.TabIndex = 27;
			// 
			// cmbSexo
			// 
			this.cmbSexo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
									"Hombre",
									"Mujer"});
			this.cmbSexo.Location = new System.Drawing.Point(85, 58);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(195, 22);
			this.cmbSexo.TabIndex = 26;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(45, 61);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(35, 14);
			this.label17.TabIndex = 28;
			this.label17.Text = "Sexo:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(15, 34);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(65, 14);
			this.label16.TabIndex = 25;
			this.label16.Text = "Parentesco:";
			// 
			// cmbParentesco
			// 
			this.cmbParentesco.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbParentesco.FormattingEnabled = true;
			this.cmbParentesco.Items.AddRange(new object[] {
									"Abuelo",
									"Padre",
									"Tío",
									"Hermano",
									"Sobrino",
									"Conyuge",
									"Hijo",
									"Otro..."});
			this.cmbParentesco.Location = new System.Drawing.Point(85, 31);
			this.cmbParentesco.Name = "cmbParentesco";
			this.cmbParentesco.Size = new System.Drawing.Size(195, 22);
			this.cmbParentesco.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(-1, -3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(301, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Datos del dependiente:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormDependiente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(301, 245);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormDependiente";
			this.Text = "Transportes LAR - Dependiente";
			this.Load += new System.EventHandler(this.FormDependienteLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.ComboBox cmbParentesco;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		public System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.DateTimePicker dateNacimiento;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
