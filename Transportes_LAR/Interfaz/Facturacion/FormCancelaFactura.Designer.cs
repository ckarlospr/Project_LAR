/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 28/12/2016
 * Hora: 11:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Facturacion
{
	partial class FormCancelaFactura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelaFactura));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIVA = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpInicioOrdenFactura = new System.Windows.Forms.DateTimePicker();
			this.dtpFinOrdenFactura = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Location = new System.Drawing.Point(286, 150);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 31);
			this.btnCancelar.TabIndex = 119;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.Location = new System.Drawing.Point(102, 150);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 31);
			this.btnAceptar.TabIndex = 118;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(84, 91);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(360, 50);
			this.txtObservaciones.TabIndex = 117;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 94);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 18);
			this.label9.TabIndex = 131;
			this.label9.Text = "Observaciones";
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(350, 36);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 113;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(317, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 18);
			this.label4.TabIndex = 128;
			this.label4.Text = "Total";
			// 
			// txtIVA
			// 
			this.txtIVA.Enabled = false;
			this.txtIVA.Location = new System.Drawing.Point(198, 36);
			this.txtIVA.Name = "txtIVA";
			this.txtIVA.Size = new System.Drawing.Size(100, 20);
			this.txtIVA.TabIndex = 112;
			this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(171, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 18);
			this.label3.TabIndex = 127;
			this.label3.Text = "IVA";
			// 
			// txtImporte
			// 
			this.txtImporte.Enabled = false;
			this.txtImporte.Location = new System.Drawing.Point(53, 36);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(100, 20);
			this.txtImporte.TabIndex = 111;
			this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(10, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 18);
			this.label2.TabIndex = 126;
			this.label2.Text = "Importe";
			// 
			// dtpInicioOrdenFactura
			// 
			this.dtpInicioOrdenFactura.Enabled = false;
			this.dtpInicioOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicioOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicioOrdenFactura.Location = new System.Drawing.Point(270, 7);
			this.dtpInicioOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpInicioOrdenFactura.Name = "dtpInicioOrdenFactura";
			this.dtpInicioOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpInicioOrdenFactura.TabIndex = 109;
			this.dtpInicioOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// dtpFinOrdenFactura
			// 
			this.dtpFinOrdenFactura.Enabled = false;
			this.dtpFinOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinOrdenFactura.Location = new System.Drawing.Point(367, 7);
			this.dtpFinOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFinOrdenFactura.Name = "dtpFinOrdenFactura";
			this.dtpFinOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpFinOrdenFactura.TabIndex = 110;
			this.dtpFinOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Red;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(353, 11);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 12);
			this.label10.TabIndex = 125;
			this.label10.Text = "al";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Red;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(248, 11);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 124;
			this.label11.Text = "Del";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.BackColor = System.Drawing.Color.Red;
			this.lblEmpresa.Location = new System.Drawing.Point(59, 10);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(100, 18);
			this.lblEmpresa.TabIndex = 123;
			this.lblEmpresa.Text = "ERROR";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 19);
			this.label1.TabIndex = 122;
			this.label1.Text = "Empresa:";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Red;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(450, 59);
			this.label5.TabIndex = 120;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 18);
			this.label6.TabIndex = 121;
			this.label6.Text = "Motivo";
			// 
			// txtMotivo
			// 
			this.txtMotivo.Location = new System.Drawing.Point(84, 67);
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(360, 20);
			this.txtMotivo.TabIndex = 114;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormCancelaFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 186);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtObservaciones);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtIVA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtImporte);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpInicioOrdenFactura);
			this.Controls.Add(this.dtpFinOrdenFactura);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lblEmpresa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(472, 225);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(472, 225);
			this.Name = "FormCancelaFactura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancelar Factura";
			this.Load += new System.EventHandler(this.FormCancelaFacturaLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCancelaFacturaKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtMotivo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpFinOrdenFactura;
		private System.Windows.Forms.DateTimePicker dtpInicioOrdenFactura;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIVA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
	}
}
