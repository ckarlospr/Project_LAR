/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 16/07/2012
 * Time: 11:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Cliente
{
	partial class FormCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtRumbo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMunicipio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtZonaReferencia = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSubNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolContacto = new System.Windows.Forms.ToolStripButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbTipoCobro = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.cmbTipoCobro);
			this.panel1.Controls.Add(this.txtRumbo);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtEstado);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtMunicipio);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtZonaReferencia);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtDomicilio);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtSubNombre);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtEmpresa);
			this.panel1.Controls.Add(this.label48);
			this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(12, 86);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(356, 260);
			this.panel1.TabIndex = 0;
			// 
			// txtRumbo
			// 
			this.txtRumbo.Location = new System.Drawing.Point(103, 196);
			this.txtRumbo.Name = "txtRumbo";
			this.txtRumbo.Size = new System.Drawing.Size(239, 20);
			this.txtRumbo.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(54, 199);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 14);
			this.label7.TabIndex = 142;
			this.label7.Text = "Rumbo:";
			// 
			// txtEstado
			// 
			this.txtEstado.Location = new System.Drawing.Point(103, 170);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(239, 20);
			this.txtEstado.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(55, 173);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 14);
			this.label6.TabIndex = 140;
			this.label6.Text = "Estado:";
			// 
			// txtMunicipio
			// 
			this.txtMunicipio.Location = new System.Drawing.Point(103, 144);
			this.txtMunicipio.Name = "txtMunicipio";
			this.txtMunicipio.Size = new System.Drawing.Size(239, 20);
			this.txtMunicipio.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(44, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 14);
			this.label5.TabIndex = 138;
			this.label5.Text = "Municipio:";
			// 
			// txtZonaReferencia
			// 
			this.txtZonaReferencia.Location = new System.Drawing.Point(103, 118);
			this.txtZonaReferencia.Name = "txtZonaReferencia";
			this.txtZonaReferencia.Size = new System.Drawing.Size(239, 20);
			this.txtZonaReferencia.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(10, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 14);
			this.label4.TabIndex = 136;
			this.label4.Text = "Zona referencia:";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(103, 92);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(239, 20);
			this.txtDomicilio.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(47, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 14);
			this.label3.TabIndex = 134;
			this.label3.Text = "Domicilio:";
			// 
			// txtSubNombre
			// 
			this.txtSubNombre.Location = new System.Drawing.Point(103, 66);
			this.txtSubNombre.Name = "txtSubNombre";
			this.txtSubNombre.Size = new System.Drawing.Size(239, 20);
			this.txtSubNombre.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(29, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 14);
			this.label2.TabIndex = 132;
			this.label2.Text = "Sub nombre:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 20);
			this.label1.TabIndex = 130;
			this.label1.Text = "Datos de la empresa:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(103, 40);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(239, 20);
			this.txtEmpresa.TabIndex = 1;
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.BackColor = System.Drawing.Color.Transparent;
			this.label48.Location = new System.Drawing.Point(44, 43);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(52, 14);
			this.label48.TabIndex = 120;
			this.label48.Text = "Empresa:";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.White;
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label18.Location = new System.Drawing.Point(0, 25);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(379, 69);
			this.label18.TabIndex = 188;
			this.label18.Text = "     Ingrese los datos correspondientes del cliente:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(281, 354);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(87, 33);
			this.btnCancelar.TabIndex = 9;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(188, 354);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(87, 33);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.MidnightBlue;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolContacto});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(381, 25);
			this.toolStrip1.TabIndex = 201;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolContacto
			// 
			this.toolContacto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolContacto.ForeColor = System.Drawing.Color.White;
			this.toolContacto.Image = ((System.Drawing.Image)(resources.GetObject("toolContacto.Image")));
			this.toolContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolContacto.Name = "toolContacto";
			this.toolContacto.Size = new System.Drawing.Size(83, 22);
			this.toolContacto.Text = "Contactos";
			this.toolContacto.Click += new System.EventHandler(this.ToolContactoClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(12, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 37);
			this.pictureBox1.TabIndex = 202;
			this.pictureBox1.TabStop = false;
			// 
			// cmbTipoCobro
			// 
			this.cmbTipoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoCobro.FormattingEnabled = true;
			this.cmbTipoCobro.Items.AddRange(new object[] {
									"CAMION",
									"CAMIONETA",
									"ABIERTO"});
			this.cmbTipoCobro.Location = new System.Drawing.Point(103, 222);
			this.cmbTipoCobro.Name = "cmbTipoCobro";
			this.cmbTipoCobro.Size = new System.Drawing.Size(121, 22);
			this.cmbTipoCobro.TabIndex = 143;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(20, 225);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 14);
			this.label8.TabIndex = 144;
			this.label8.Text = "Tipo de cobro:";
			// 
			// FormCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(381, 399);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label18);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormCliente";
			this.Text = "Transportes LAR - Cliente";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClienteFormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbTipoCobro;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripButton toolContacto;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtSubNombre;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtZonaReferencia;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtMunicipio;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtRumbo;
		private System.Windows.Forms.Label label48;
		public System.Windows.Forms.TextBox txtEmpresa;
		public System.Windows.Forms.Button btnAgregar;
		public System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Panel panel1;
	}
}
