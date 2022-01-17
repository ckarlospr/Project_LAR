/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 14/01/2016
 * Hora: 10:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormNuevoAnticipo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoAnticipo));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtImporteSevicio = new System.Windows.Forms.TextBox();
			this.label61 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.txtDestinoServicio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtImporteTotalPago = new System.Windows.Forms.TextBox();
			this.btnGuardarPago = new System.Windows.Forms.Button();
			this.label41 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.dgPagos = new System.Windows.Forms.DataGridView();
			this.ID_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COMPROBANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.txtubica = new System.Windows.Forms.TextBox();
			this.txtComprobantePago = new System.Windows.Forms.TextBox();
			this.txtImportePago = new System.Windows.Forms.TextBox();
			this.cbTipoPago = new System.Windows.Forms.ComboBox();
			this.label58 = new System.Windows.Forms.Label();
			this.label66 = new System.Windows.Forms.Label();
			this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
			this.label76 = new System.Windows.Forms.Label();
			this.label77 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblUbica = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSaldo
			// 
			this.txtSaldo.BackColor = System.Drawing.Color.PowderBlue;
			this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSaldo.Enabled = false;
			this.txtSaldo.Location = new System.Drawing.Point(378, 10);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtSaldo.Size = new System.Drawing.Size(77, 20);
			this.txtSaldo.TabIndex = 143;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(341, 13);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(44, 20);
			this.label3.TabIndex = 144;
			this.label3.Text = "Saldo:";
			// 
			// txtImporteSevicio
			// 
			this.txtImporteSevicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtImporteSevicio.Enabled = false;
			this.txtImporteSevicio.Location = new System.Drawing.Point(248, 11);
			this.txtImporteSevicio.Name = "txtImporteSevicio";
			this.txtImporteSevicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtImporteSevicio.Size = new System.Drawing.Size(77, 20);
			this.txtImporteSevicio.TabIndex = 136;
			// 
			// label61
			// 
			this.label61.Location = new System.Drawing.Point(206, 12);
			this.label61.Name = "label61";
			this.label61.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label61.Size = new System.Drawing.Size(44, 20);
			this.label61.TabIndex = 137;
			this.label61.Text = "Importe:";
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(12, 14);
			this.label40.Name = "label40";
			this.label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label40.Size = new System.Drawing.Size(47, 15);
			this.label40.TabIndex = 139;
			this.label40.Text = "Destino:";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDestinoServicio
			// 
			this.txtDestinoServicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestinoServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestinoServicio.Enabled = false;
			this.txtDestinoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestinoServicio.Location = new System.Drawing.Point(59, 11);
			this.txtDestinoServicio.Name = "txtDestinoServicio";
			this.txtDestinoServicio.Size = new System.Drawing.Size(141, 20);
			this.txtDestinoServicio.TabIndex = 138;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(221, 50);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(343, 17);
			this.label5.TabIndex = 164;
			this.label5.Text = "Pagos Realizados";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtImporteTotalPago
			// 
			this.txtImporteTotalPago.Enabled = false;
			this.txtImporteTotalPago.Location = new System.Drawing.Point(472, 246);
			this.txtImporteTotalPago.Name = "txtImporteTotalPago";
			this.txtImporteTotalPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtImporteTotalPago.Size = new System.Drawing.Size(77, 20);
			this.txtImporteTotalPago.TabIndex = 166;
			// 
			// btnGuardarPago
			// 
			this.btnGuardarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPago.Image")));
			this.btnGuardarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarPago.Location = new System.Drawing.Point(221, 252);
			this.btnGuardarPago.Name = "btnGuardarPago";
			this.btnGuardarPago.Size = new System.Drawing.Size(82, 44);
			this.btnGuardarPago.TabIndex = 158;
			this.btnGuardarPago.Text = "Guardar";
			this.btnGuardarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarPago.UseVisualStyleBackColor = true;
			this.btnGuardarPago.Click += new System.EventHandler(this.BtnGuardarPagoClick);
			// 
			// label41
			// 
			this.label41.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(16, 35);
			this.label41.Name = "label41";
			this.label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label41.Size = new System.Drawing.Size(550, 3);
			this.label41.TabIndex = 168;
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(400, 247);
			this.label17.Name = "label17";
			this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label17.Size = new System.Drawing.Size(74, 23);
			this.label17.TabIndex = 167;
			this.label17.Text = "Importe Total:";
			// 
			// dgPagos
			// 
			this.dgPagos.AllowUserToAddRows = false;
			this.dgPagos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_PAGO,
									this.dataGridViewTextBoxColumn13,
									this.Column13,
									this.Column12,
									this.dataGridViewTextBoxColumn15,
									this.COMPROBANTE});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgPagos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgPagos.Location = new System.Drawing.Point(220, 67);
			this.dgPagos.Name = "dgPagos";
			this.dgPagos.ReadOnly = true;
			this.dgPagos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgPagos.RowHeadersVisible = false;
			this.dgPagos.Size = new System.Drawing.Size(343, 174);
			this.dgPagos.TabIndex = 162;
			// 
			// ID_PAGO
			// 
			this.ID_PAGO.HeaderText = "ID";
			this.ID_PAGO.Name = "ID_PAGO";
			this.ID_PAGO.ReadOnly = true;
			this.ID_PAGO.Visible = false;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.HeaderText = "FECHA";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Width = 60;
			// 
			// Column13
			// 
			this.Column13.HeaderText = "FOLIO";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			this.Column13.Width = 40;
			// 
			// Column12
			// 
			this.Column12.HeaderText = "ANTICIPO";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			this.Column12.Width = 70;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.HeaderText = "TIPO";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.ReadOnly = true;
			this.dataGridViewTextBoxColumn15.Width = 70;
			// 
			// COMPROBANTE
			// 
			this.COMPROBANTE.HeaderText = "COMPROBANTE";
			this.COMPROBANTE.Name = "COMPROBANTE";
			this.COMPROBANTE.ReadOnly = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtComentario);
			this.groupBox1.Controls.Add(this.txtubica);
			this.groupBox1.Controls.Add(this.txtComprobantePago);
			this.groupBox1.Controls.Add(this.txtImportePago);
			this.groupBox1.Controls.Add(this.cbTipoPago);
			this.groupBox1.Controls.Add(this.label58);
			this.groupBox1.Controls.Add(this.label66);
			this.groupBox1.Controls.Add(this.dtpFechaPago);
			this.groupBox1.Controls.Add(this.label76);
			this.groupBox1.Controls.Add(this.label77);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lblUbica);
			this.groupBox1.Location = new System.Drawing.Point(12, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 233);
			this.groupBox1.TabIndex = 171;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Agregar Anticipo";
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Location = new System.Drawing.Point(12, 169);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(178, 55);
			this.txtComentario.TabIndex = 177;
			// 
			// txtubica
			// 
			this.txtubica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtubica.Location = new System.Drawing.Point(84, 125);
			this.txtubica.Name = "txtubica";
			this.txtubica.Size = new System.Drawing.Size(104, 20);
			this.txtubica.TabIndex = 176;
			this.txtubica.Text = "N/A";
			this.txtubica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtubica.Visible = false;
			// 
			// txtComprobantePago
			// 
			this.txtComprobantePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComprobantePago.Location = new System.Drawing.Point(84, 75);
			this.txtComprobantePago.Name = "txtComprobantePago";
			this.txtComprobantePago.Size = new System.Drawing.Size(104, 20);
			this.txtComprobantePago.TabIndex = 173;
			// 
			// txtImportePago
			// 
			this.txtImportePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtImportePago.Location = new System.Drawing.Point(84, 100);
			this.txtImportePago.Name = "txtImportePago";
			this.txtImportePago.Size = new System.Drawing.Size(104, 20);
			this.txtImportePago.TabIndex = 174;
			this.txtImportePago.TextChanged += new System.EventHandler(this.TxtImportePagoTextChanged);
			this.txtImportePago.Enter += new System.EventHandler(this.TxtImportePagoEnter);
			this.txtImportePago.Leave += new System.EventHandler(this.TxtImportePagoLeave);
			// 
			// cbTipoPago
			// 
			this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTipoPago.FormattingEnabled = true;
			this.cbTipoPago.Items.AddRange(new object[] {
									"EFECTIVO",
									"DEPOSITO",
									"TRANS ELECTRONICA",
									"CHEQUE"});
			this.cbTipoPago.Location = new System.Drawing.Point(84, 49);
			this.cbTipoPago.Margin = new System.Windows.Forms.Padding(2);
			this.cbTipoPago.Name = "cbTipoPago";
			this.cbTipoPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbTipoPago.Size = new System.Drawing.Size(104, 21);
			this.cbTipoPago.TabIndex = 172;
			this.cbTipoPago.SelectedIndexChanged += new System.EventHandler(this.CbTipoPagoSelectedIndexChanged);
			// 
			// label58
			// 
			this.label58.Location = new System.Drawing.Point(38, 102);
			this.label58.Name = "label58";
			this.label58.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label58.Size = new System.Drawing.Size(50, 23);
			this.label58.TabIndex = 181;
			this.label58.Text = "Importe:";
			// 
			// label66
			// 
			this.label66.Location = new System.Drawing.Point(4, 30);
			this.label66.Name = "label66";
			this.label66.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label66.Size = new System.Drawing.Size(43, 23);
			this.label66.TabIndex = 179;
			this.label66.Text = "Fecha:";
			// 
			// dtpFechaPago
			// 
			this.dtpFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaPago.Location = new System.Drawing.Point(47, 24);
			this.dtpFechaPago.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFechaPago.Name = "dtpFechaPago";
			this.dtpFechaPago.Size = new System.Drawing.Size(104, 20);
			this.dtpFechaPago.TabIndex = 171;
			this.dtpFechaPago.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label76
			// 
			this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label76.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label76.Location = new System.Drawing.Point(9, 51);
			this.label76.Name = "label76";
			this.label76.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label76.Size = new System.Drawing.Size(79, 17);
			this.label76.TabIndex = 178;
			this.label76.Text = "Tipo de pago:";
			this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label77
			// 
			this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label77.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label77.Location = new System.Drawing.Point(4, 76);
			this.label77.Name = "label77";
			this.label77.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label77.Size = new System.Drawing.Size(79, 17);
			this.label77.TabIndex = 180;
			this.label77.Text = "Num. Referec.:";
			this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(67, 151);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(66, 23);
			this.label4.TabIndex = 183;
			this.label4.Text = "Comentarios";
			// 
			// lblUbica
			// 
			this.lblUbica.Location = new System.Drawing.Point(45, 125);
			this.lblUbica.Name = "lblUbica";
			this.lblUbica.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblUbica.Size = new System.Drawing.Size(42, 23);
			this.lblUbica.TabIndex = 182;
			this.lblUbica.Text = "Ubica:";
			this.lblUbica.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormNuevoAnticipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 301);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtImporteTotalPago);
			this.Controls.Add(this.btnGuardarPago);
			this.Controls.Add(this.label41);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.dgPagos);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtImporteSevicio);
			this.Controls.Add(this.label61);
			this.Controls.Add(this.label40);
			this.Controls.Add(this.txtDestinoServicio);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormNuevoAnticipo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo Anticipo";
			this.Load += new System.EventHandler(this.FormNuevoAnticipoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblUbica;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label77;
		private System.Windows.Forms.Label label76;
		private System.Windows.Forms.DateTimePicker dtpFechaPago;
		private System.Windows.Forms.Label label66;
		private System.Windows.Forms.DataGridViewTextBoxColumn COMPROBANTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAGO;
		private System.Windows.Forms.DataGridView dgPagos;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.ComboBox cbTipoPago;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Button btnGuardarPago;
		private System.Windows.Forms.TextBox txtImportePago;
		private System.Windows.Forms.TextBox txtImporteTotalPago;
		private System.Windows.Forms.TextBox txtComprobantePago;
		private System.Windows.Forms.TextBox txtubica;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDestinoServicio;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label61;
		private System.Windows.Forms.TextBox txtImporteSevicio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSaldo;
	}
}
