/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 15/07/2012
 * Time: 4:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	partial class FormLicencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicencia));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.dateVigencia = new System.Windows.Forms.DateTimePicker();
			this.label47 = new System.Windows.Forms.Label();
			this.cmbClase = new System.Windows.Forms.ComboBox();
			this.label46 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
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
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 51);
			this.panel1.TabIndex = 0;
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
			this.label1.Location = new System.Drawing.Point(52, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modifique los datos de la licencia:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancelar);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnAgregar);
			this.panel2.Controls.Add(this.txtNumero);
			this.panel2.Controls.Add(this.label45);
			this.panel2.Controls.Add(this.label50);
			this.panel2.Controls.Add(this.dateVigencia);
			this.panel2.Controls.Add(this.label47);
			this.panel2.Controls.Add(this.cmbClase);
			this.panel2.Controls.Add(this.label46);
			this.panel2.Controls.Add(this.cmbTipo);
			this.panel2.Location = new System.Drawing.Point(0, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(301, 185);
			this.panel2.TabIndex = 3;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(203, 144);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(80, 28);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(-1, -3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(301, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Datos de la licencia:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(120, 144);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(77, 28);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Aceptar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(85, 31);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(195, 20);
			this.txtNumero.TabIndex = 1;
			this.txtNumero.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// label45
			// 
			this.label45.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label45.Location = new System.Drawing.Point(24, 31);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(56, 18);
			this.label45.TabIndex = 47;
			this.label45.Text = "Numero:";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label50
			// 
			this.label50.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label50.Location = new System.Drawing.Point(24, 112);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(57, 20);
			this.label50.TabIndex = 45;
			this.label50.Text = "Vigencia:";
			this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateVigencia
			// 
			this.dateVigencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateVigencia.Location = new System.Drawing.Point(85, 112);
			this.dateVigencia.Name = "dateVigencia";
			this.dateVigencia.Size = new System.Drawing.Size(195, 20);
			this.dateVigencia.TabIndex = 4;
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label47.Location = new System.Drawing.Point(24, 57);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(57, 18);
			this.label47.TabIndex = 44;
			this.label47.Text = "Clase:";
			this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbClase
			// 
			this.cmbClase.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbClase.FormattingEnabled = true;
			this.cmbClase.Items.AddRange(new object[] {
									"Estatal",
									"Federal"});
			this.cmbClase.Location = new System.Drawing.Point(85, 57);
			this.cmbClase.Name = "cmbClase";
			this.cmbClase.Size = new System.Drawing.Size(194, 22);
			this.cmbClase.TabIndex = 2;
			this.cmbClase.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// label46
			// 
			this.label46.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label46.Location = new System.Drawing.Point(42, 87);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(39, 23);
			this.label46.TabIndex = 43;
			this.label46.Text = "Tipo:";
			this.label46.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmbTipo
			// 
			this.cmbTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"A",
									"B"});
			this.cmbTipo.Location = new System.Drawing.Point(85, 84);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(195, 22);
			this.cmbTipo.TabIndex = 3;
			this.cmbTipo.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// FormLicencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(301, 284);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormLicencia";
			this.Text = "Transportes LAR - Licencia";
			this.Load += new System.EventHandler(this.FormLicenciaLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label46;
		public System.Windows.Forms.ComboBox cmbClase;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.DateTimePicker dateVigencia;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label45;
		public System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
