/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 26/12/2016
 * Hora: 11:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Facturacion
{
	partial class FormFacturar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturar));
			this.label5 = new System.Windows.Forms.Label();
			this.txtFactura = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
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
			this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.cmbContribuyentes = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(450, 59);
			this.label5.TabIndex = 89;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFactura
			// 
			this.txtFactura.Location = new System.Drawing.Point(85, 73);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Size = new System.Drawing.Size(69, 20);
			this.txtFactura.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 18);
			this.label6.TabIndex = 90;
			this.label6.Text = "Factura";
			// 
			// txtTotal
			// 
			this.txtTotal.Enabled = false;
			this.txtTotal.Location = new System.Drawing.Point(351, 37);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 5;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label4.Location = new System.Drawing.Point(318, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 18);
			this.label4.TabIndex = 102;
			this.label4.Text = "Total";
			// 
			// txtIVA
			// 
			this.txtIVA.Enabled = false;
			this.txtIVA.Location = new System.Drawing.Point(199, 37);
			this.txtIVA.Name = "txtIVA";
			this.txtIVA.Size = new System.Drawing.Size(100, 20);
			this.txtIVA.TabIndex = 4;
			this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Location = new System.Drawing.Point(172, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 18);
			this.label3.TabIndex = 100;
			this.label3.Text = "IVA";
			// 
			// txtImporte
			// 
			this.txtImporte.Enabled = false;
			this.txtImporte.Location = new System.Drawing.Point(54, 37);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(100, 20);
			this.txtImporte.TabIndex = 3;
			this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Location = new System.Drawing.Point(11, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 18);
			this.label2.TabIndex = 98;
			this.label2.Text = "Importe";
			// 
			// dtpInicioOrdenFactura
			// 
			this.dtpInicioOrdenFactura.Enabled = false;
			this.dtpInicioOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicioOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicioOrdenFactura.Location = new System.Drawing.Point(271, 8);
			this.dtpInicioOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpInicioOrdenFactura.Name = "dtpInicioOrdenFactura";
			this.dtpInicioOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpInicioOrdenFactura.TabIndex = 1;
			this.dtpInicioOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// dtpFinOrdenFactura
			// 
			this.dtpFinOrdenFactura.Enabled = false;
			this.dtpFinOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinOrdenFactura.Location = new System.Drawing.Point(368, 8);
			this.dtpFinOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFinOrdenFactura.Name = "dtpFinOrdenFactura";
			this.dtpFinOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpFinOrdenFactura.TabIndex = 2;
			this.dtpFinOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(354, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 12);
			this.label10.TabIndex = 95;
			this.label10.Text = "al";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(249, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 94;
			this.label11.Text = "Del";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblEmpresa.Location = new System.Drawing.Point(60, 11);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(100, 18);
			this.lblEmpresa.TabIndex = 93;
			this.lblEmpresa.Text = "ERROR";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 19);
			this.label1.TabIndex = 92;
			this.label1.Text = "Empresa:";
			// 
			// dtpVencimiento
			// 
			this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpVencimiento.Location = new System.Drawing.Point(368, 74);
			this.dtpVencimiento.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpVencimiento.Name = "dtpVencimiento";
			this.dtpVencimiento.Size = new System.Drawing.Size(83, 20);
			this.dtpVencimiento.TabIndex = 8;
			this.dtpVencimiento.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(304, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 18);
			this.label8.TabIndex = 107;
			this.label8.Text = "Vencimiento";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(85, 103);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(366, 39);
			this.txtObservaciones.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 106);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 18);
			this.label9.TabIndex = 108;
			this.label9.Text = "Observaciones";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(103, 148);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 31);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Location = new System.Drawing.Point(287, 148);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 31);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// cmbContribuyentes
			// 
			this.cmbContribuyentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbContribuyentes.FormattingEnabled = true;
			this.cmbContribuyentes.Items.AddRange(new object[] {
									"LUIS ARRIAGA RUIZ",
									"JUANA GARCIA GAMBOA",
									"RAY KENNY ARRIAGA GARCIA",
									"LUIS DARIO ARRIAGA GARCIA",
									"ALMA SELENE ARRIGA GARCIA",
									"LOGISTICA ACTITUD Y RESPONSABILIDAD EN EL TRANSPORTE EJECUTIVO S.A. DE C.V."});
			this.cmbContribuyentes.Location = new System.Drawing.Point(161, 73);
			this.cmbContribuyentes.Name = "cmbContribuyentes";
			this.cmbContribuyentes.Size = new System.Drawing.Size(137, 21);
			this.cmbContribuyentes.TabIndex = 109;
			// 
			// FormFacturar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 186);
			this.Controls.Add(this.cmbContribuyentes);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dtpVencimiento);
			this.Controls.Add(this.txtObservaciones);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
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
			this.Controls.Add(this.txtFactura);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(475, 225);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(475, 225);
			this.Name = "FormFacturar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Factura";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFacturarFormClosing);
			this.Load += new System.EventHandler(this.FormFacturarLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormFacturarKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cmbContribuyentes;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpVencimiento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFactura;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIVA;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpFinOrdenFactura;
		private System.Windows.Forms.DateTimePicker dtpInicioOrdenFactura;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.Label label1;
	}
}
