/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 04/02/2016
 * Hora: 10:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormAgregarPruebaR
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarPruebaR));
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.lblusuario = new System.Windows.Forms.Label();
			this.dtpFechaPrueba = new System.Windows.Forms.DateTimePicker();
			this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
			this.lblOperador = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
			this.txtLitrosFin = new System.Windows.Forms.TextBox();
			this.txtKmInicio = new System.Windows.Forms.TextBox();
			this.txtKmFin = new System.Windows.Forms.TextBox();
			this.txtusuario = new System.Windows.Forms.TextBox();
			this.gbPrueba = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbSeguimiento = new System.Windows.Forms.ComboBox();
			this.txtFactor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCometario = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbPrueba.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.Enabled = false;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAceptar.Location = new System.Drawing.Point(97, 290);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(73, 52);
			this.btnAceptar.TabIndex = 13;
			this.btnAceptar.Text = "Guardar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtOperador
			// 
			this.txtOperador.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(69, 34);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(119, 20);
			this.txtOperador.TabIndex = 3;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.TextChanged += new System.EventHandler(this.TxtOperadorTextChanged);
			// 
			// lblusuario
			// 
			this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblusuario.Location = new System.Drawing.Point(3, 14);
			this.lblusuario.Name = "lblusuario";
			this.lblusuario.Size = new System.Drawing.Size(215, 15);
			this.lblusuario.TabIndex = 80;
			this.lblusuario.Text = "Usuario que realizo prueba: ";
			this.lblusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpFechaPrueba
			// 
			this.dtpFechaPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaPrueba.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaPrueba.Location = new System.Drawing.Point(56, 69);
			this.dtpFechaPrueba.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFechaPrueba.Name = "dtpFechaPrueba";
			this.dtpFechaPrueba.Size = new System.Drawing.Size(88, 20);
			this.dtpFechaPrueba.TabIndex = 5;
			this.dtpFechaPrueba.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// dtpHoraInicio
			// 
			this.dtpHoraInicio.CustomFormat = "HH:mm";
			this.dtpHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraInicio.Location = new System.Drawing.Point(197, 70);
			this.dtpHoraInicio.Name = "dtpHoraInicio";
			this.dtpHoraInicio.ShowUpDown = true;
			this.dtpHoraInicio.Size = new System.Drawing.Size(55, 20);
			this.dtpHoraInicio.TabIndex = 6;
			// 
			// lblOperador
			// 
			this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(1, 35);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(71, 15);
			this.lblOperador.TabIndex = 85;
			this.lblOperador.Text = "Operador";
			this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(150, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 29);
			this.label1.TabIndex = 86;
			this.label1.Text = "Hora Inicio ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 15);
			this.label2.TabIndex = 87;
			this.label2.Text = "KM Inicio";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(267, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 39);
			this.label3.TabIndex = 88;
			this.label3.Text = "Litros cargados fin";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(257, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 30);
			this.label6.TabIndex = 90;
			this.label6.Text = "Hora Fin";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(164, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 15);
			this.label7.TabIndex = 91;
			this.label7.Text = "KM Fin";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(4, 63);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 32);
			this.label8.TabIndex = 92;
			this.label8.Text = "Fecha Prueba";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpHoraFin
			// 
			this.dtpHoraFin.CustomFormat = "HH:mm";
			this.dtpHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraFin.Location = new System.Drawing.Point(304, 69);
			this.dtpHoraFin.Name = "dtpHoraFin";
			this.dtpHoraFin.ShowUpDown = true;
			this.dtpHoraFin.Size = new System.Drawing.Size(57, 20);
			this.dtpHoraFin.TabIndex = 7;
			// 
			// txtLitrosFin
			// 
			this.txtLitrosFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLitrosFin.Location = new System.Drawing.Point(256, 126);
			this.txtLitrosFin.Name = "txtLitrosFin";
			this.txtLitrosFin.Size = new System.Drawing.Size(92, 20);
			this.txtLitrosFin.TabIndex = 10;
			this.txtLitrosFin.Text = "0";
			this.txtLitrosFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtLitrosFin.TextChanged += new System.EventHandler(this.TxtLitrosFinTextChanged);
			// 
			// txtKmInicio
			// 
			this.txtKmInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKmInicio.Location = new System.Drawing.Point(20, 126);
			this.txtKmInicio.Name = "txtKmInicio";
			this.txtKmInicio.Size = new System.Drawing.Size(92, 20);
			this.txtKmInicio.TabIndex = 8;
			this.txtKmInicio.Text = "0";
			this.txtKmInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKmInicio.TextChanged += new System.EventHandler(this.TxtKmInicioTextChanged);
			// 
			// txtKmFin
			// 
			this.txtKmFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKmFin.Location = new System.Drawing.Point(132, 126);
			this.txtKmFin.Name = "txtKmFin";
			this.txtKmFin.Size = new System.Drawing.Size(104, 20);
			this.txtKmFin.TabIndex = 9;
			this.txtKmFin.Text = "0";
			this.txtKmFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKmFin.TextChanged += new System.EventHandler(this.TxtKmFinTextChanged);
			// 
			// txtusuario
			// 
			this.txtusuario.BackColor = System.Drawing.Color.DarkGray;
			this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtusuario.ForeColor = System.Drawing.SystemColors.Window;
			this.txtusuario.Location = new System.Drawing.Point(207, 12);
			this.txtusuario.Name = "txtusuario";
			this.txtusuario.Size = new System.Drawing.Size(186, 22);
			this.txtusuario.TabIndex = 1;
			this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// gbPrueba
			// 
			this.gbPrueba.Controls.Add(this.label4);
			this.gbPrueba.Controls.Add(this.cbSeguimiento);
			this.gbPrueba.Controls.Add(this.txtFactor);
			this.gbPrueba.Controls.Add(this.label9);
			this.gbPrueba.Controls.Add(this.txtCometario);
			this.gbPrueba.Controls.Add(this.label5);
			this.gbPrueba.Controls.Add(this.txtUnidad);
			this.gbPrueba.Controls.Add(this.label11);
			this.gbPrueba.Controls.Add(this.label10);
			this.gbPrueba.Controls.Add(this.dtpHoraInicio);
			this.gbPrueba.Controls.Add(this.txtKmFin);
			this.gbPrueba.Controls.Add(this.dtpFechaPrueba);
			this.gbPrueba.Controls.Add(this.txtKmInicio);
			this.gbPrueba.Controls.Add(this.txtOperador);
			this.gbPrueba.Controls.Add(this.txtLitrosFin);
			this.gbPrueba.Controls.Add(this.lblOperador);
			this.gbPrueba.Controls.Add(this.dtpHoraFin);
			this.gbPrueba.Controls.Add(this.label1);
			this.gbPrueba.Controls.Add(this.label2);
			this.gbPrueba.Controls.Add(this.label8);
			this.gbPrueba.Controls.Add(this.label3);
			this.gbPrueba.Controls.Add(this.label7);
			this.gbPrueba.Controls.Add(this.label6);
			this.gbPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.gbPrueba.Location = new System.Drawing.Point(12, 41);
			this.gbPrueba.Name = "gbPrueba";
			this.gbPrueba.Size = new System.Drawing.Size(381, 243);
			this.gbPrueba.TabIndex = 2;
			this.gbPrueba.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(267, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 115;
			this.label4.Text = "Seguimiento";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbSeguimiento
			// 
			this.cbSeguimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSeguimiento.FormattingEnabled = true;
			this.cbSeguimiento.Items.AddRange(new object[] {
									"RENDIMIENTO ÓPTIMO",
									"REPARACIÓN TALLER",
									"OTRA PRUEBA"});
			this.cbSeguimiento.Location = new System.Drawing.Point(230, 170);
			this.cbSeguimiento.Name = "cbSeguimiento";
			this.cbSeguimiento.Size = new System.Drawing.Size(131, 21);
			this.cbSeguimiento.TabIndex = 11;
			// 
			// txtFactor
			// 
			this.txtFactor.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtFactor.Enabled = false;
			this.txtFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFactor.Location = new System.Drawing.Point(256, 213);
			this.txtFactor.Name = "txtFactor";
			this.txtFactor.Size = new System.Drawing.Size(104, 22);
			this.txtFactor.TabIndex = 15;
			this.txtFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFactor.TextChanged += new System.EventHandler(this.TxtFactorTextChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(285, 194);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 15);
			this.label9.TabIndex = 114;
			this.label9.Text = "Factor";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCometario
			// 
			this.txtCometario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCometario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCometario.Location = new System.Drawing.Point(56, 163);
			this.txtCometario.Multiline = true;
			this.txtCometario.Name = "txtCometario";
			this.txtCometario.Size = new System.Drawing.Size(168, 75);
			this.txtCometario.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(1, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 15);
			this.label5.TabIndex = 112;
			this.label5.Text = "Cometario";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtUnidad
			// 
			this.txtUnidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidad.Enabled = false;
			this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.Location = new System.Drawing.Point(269, 34);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(92, 22);
			this.txtUnidad.TabIndex = 4;
			this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label11.BackColor = System.Drawing.Color.Turquoise;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(0, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(381, 18);
			this.label11.TabIndex = 107;
			this.label11.Text = "Datos de la Prueba";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(203, 38);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 110;
			this.label10.Text = "Unidad";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(230, 290);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(73, 52);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormAgregarPruebaR
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 346);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.gbPrueba);
			this.Controls.Add(this.txtusuario);
			this.Controls.Add(this.lblusuario);
			this.Controls.Add(this.btnAceptar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(415, 385);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(415, 385);
			this.Name = "FormAgregarPruebaR";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Prueba";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgregarPruebaRFormClosing);
			this.Load += new System.EventHandler(this.FormAgregarPruebaRLoad);
			this.gbPrueba.ResumeLayout(false);
			this.gbPrueba.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbSeguimiento;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtFactor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCometario;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.GroupBox gbPrueba;
		public System.Windows.Forms.TextBox txtusuario;
		private System.Windows.Forms.TextBox txtKmFin;
		private System.Windows.Forms.TextBox txtKmInicio;
		private System.Windows.Forms.TextBox txtLitrosFin;
		private System.Windows.Forms.DateTimePicker dtpHoraFin;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpHoraInicio;
		private System.Windows.Forms.DateTimePicker dtpFechaPrueba;
		private System.Windows.Forms.Label lblOperador;
		private System.Windows.Forms.Label lblusuario;
		public System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.Button btnAceptar;
	}
}
