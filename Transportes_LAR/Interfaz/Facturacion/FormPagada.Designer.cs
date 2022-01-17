/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 30/12/2016
 * Hora: 11:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Facturacion
{
	partial class FormPagada
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagada));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.dtpDia = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFactura = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Location = new System.Drawing.Point(188, 73);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 31);
			this.btnCancelar.TabIndex = 119;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(58, 73);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 31);
			this.btnGuardar.TabIndex = 118;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// dtpDia
			// 
			this.dtpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDia.Location = new System.Drawing.Point(225, 38);
			this.dtpDia.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpDia.Name = "dtpDia";
			this.dtpDia.Size = new System.Drawing.Size(81, 20);
			this.dtpDia.TabIndex = 115;
			this.dtpDia.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(170, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 18);
			this.label7.TabIndex = 129;
			this.label7.Text = "Día Cobro";
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblEmpresa.Location = new System.Drawing.Point(59, 11);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(100, 18);
			this.lblEmpresa.TabIndex = 123;
			this.lblEmpresa.Text = "ERROR";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 19);
			this.label1.TabIndex = 122;
			this.label1.Text = "Empresa:";
			// 
			// txtFactura
			// 
			this.txtFactura.Enabled = false;
			this.txtFactura.Location = new System.Drawing.Point(58, 38);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Size = new System.Drawing.Size(100, 20);
			this.txtFactura.TabIndex = 114;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 18);
			this.label6.TabIndex = 121;
			this.label6.Text = "Factura";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(333, 26);
			this.label5.TabIndex = 120;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormPagada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 106);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dtpDia);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblEmpresa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFactura);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(355, 145);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(355, 145);
			this.Name = "FormPagada";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pagar Factura";
			this.Load += new System.EventHandler(this.FormPagadaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFactura;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpDia;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCancelar;
	}
}
