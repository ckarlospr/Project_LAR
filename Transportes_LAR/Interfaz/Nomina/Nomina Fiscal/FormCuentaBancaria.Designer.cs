/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 20/05/2016
 * Hora: 13:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	partial class FormCuentaBancaria
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuentaBancaria));
			this.pOperador = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCuentaBancaria2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblOperador = new System.Windows.Forms.Label();
			this.txtCuentaBancaria1 = new System.Windows.Forms.TextBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pOperador.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// pOperador
			// 
			this.pOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pOperador.BackColor = System.Drawing.SystemColors.Menu;
			this.pOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperador.Controls.Add(this.label2);
			this.pOperador.Controls.Add(this.ptbImagen);
			this.pOperador.Controls.Add(this.label1);
			this.pOperador.Controls.Add(this.txtCuentaBancaria2);
			this.pOperador.Controls.Add(this.label3);
			this.pOperador.Controls.Add(this.txtNombre);
			this.pOperador.Controls.Add(this.lblOperador);
			this.pOperador.Controls.Add(this.txtCuentaBancaria1);
			this.pOperador.Controls.Add(this.btnActualizar);
			this.pOperador.Location = new System.Drawing.Point(5, 4);
			this.pOperador.Name = "pOperador";
			this.pOperador.Size = new System.Drawing.Size(254, 340);
			this.pOperador.TabIndex = 146;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 256);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 14);
			this.label2.TabIndex = 246;
			this.label2.Text = "VUELVE INGRESA:";
			// 
			// ptbImagen
			// 
			this.ptbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ptbImagen.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ptbImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptbImagen.Image")));
			this.ptbImagen.Location = new System.Drawing.Point(65, 49);
			this.ptbImagen.Name = "ptbImagen";
			this.ptbImagen.Size = new System.Drawing.Size(121, 127);
			this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagen.TabIndex = 165;
			this.ptbImagen.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 14);
			this.label1.TabIndex = 245;
			this.label1.Text = "INGRESA:";
			// 
			// txtCuentaBancaria2
			// 
			this.txtCuentaBancaria2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCuentaBancaria2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCuentaBancaria2.Location = new System.Drawing.Point(105, 251);
			this.txtCuentaBancaria2.Name = "txtCuentaBancaria2";
			this.txtCuentaBancaria2.Size = new System.Drawing.Size(133, 22);
			this.txtCuentaBancaria2.TabIndex = 2;
			this.txtCuentaBancaria2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(-2, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(279, 20);
			this.label3.TabIndex = 243;
			this.label3.Text = "CUENTA BANCARIA";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(20, 23);
			this.txtNombre.MaximumSize = new System.Drawing.Size(218, 22);
			this.txtNombre.MinimumSize = new System.Drawing.Size(218, 22);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(218, 22);
			this.txtNombre.TabIndex = 241;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblOperador
			// 
			this.lblOperador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(-2, 0);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(254, 20);
			this.lblOperador.TabIndex = 242;
			this.lblOperador.Text = "OPERADOR";
			this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCuentaBancaria1
			// 
			this.txtCuentaBancaria1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCuentaBancaria1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCuentaBancaria1.Location = new System.Drawing.Point(105, 222);
			this.txtCuentaBancaria1.Name = "txtCuentaBancaria1";
			this.txtCuentaBancaria1.Size = new System.Drawing.Size(133, 22);
			this.txtCuentaBancaria1.TabIndex = 1;
			this.txtCuentaBancaria1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
			this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
			this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActualizar.Location = new System.Drawing.Point(105, 287);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(47, 45);
			this.btnActualizar.TabIndex = 3;
			this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormCuentaBancaria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 349);
			this.Controls.Add(this.pOperador);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(277, 388);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(277, 388);
			this.Name = "FormCuentaBancaria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cuenta Bancaria";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCuentaBancariaFormClosing);
			this.Load += new System.EventHandler(this.FormCuentaBancariaLoad);
			this.pOperador.ResumeLayout(false);
			this.pOperador.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblOperador;
		public System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCuentaBancaria2;
		private System.Windows.Forms.Button btnActualizar;
		public System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.TextBox txtCuentaBancaria1;
		private System.Windows.Forms.Panel pOperador;
	}
}
