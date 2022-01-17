/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 25/05/2016
 * Hora: 12:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	partial class FormValidaCuenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidaCuenta));
			this.label1 = new System.Windows.Forms.Label();
			this.txtCuentaBancaria1 = new System.Windows.Forms.TextBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.lblOperador = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 14);
			this.label1.TabIndex = 248;
			this.label1.Text = "INGRESA:";
			// 
			// txtCuentaBancaria1
			// 
			this.txtCuentaBancaria1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCuentaBancaria1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCuentaBancaria1.Location = new System.Drawing.Point(67, 27);
			this.txtCuentaBancaria1.Name = "txtCuentaBancaria1";
			this.txtCuentaBancaria1.Size = new System.Drawing.Size(139, 22);
			this.txtCuentaBancaria1.TabIndex = 246;
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
			this.btnActualizar.Location = new System.Drawing.Point(36, 61);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(47, 45);
			this.btnActualizar.TabIndex = 247;
			this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// lblOperador
			// 
			this.lblOperador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(-1, 0);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(228, 20);
			this.lblOperador.TabIndex = 249;
			this.lblOperador.Text = "OPERADOR";
			this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(138, 61);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(47, 45);
			this.btnCancelar.TabIndex = 250;
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormValidaCuenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(227, 117);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.lblOperador);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCuentaBancaria1);
			this.Controls.Add(this.btnActualizar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(227, 117);
			this.MinimumSize = new System.Drawing.Size(227, 117);
			this.Name = "FormValidaCuenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormValidaCuenta";
			this.Load += new System.EventHandler(this.FormValidaCuentaLoad);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblOperador;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtCuentaBancaria1;
		private System.Windows.Forms.Label label1;
	}
}
