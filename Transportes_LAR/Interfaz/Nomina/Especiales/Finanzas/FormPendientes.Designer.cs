/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 08/10/2014
 * Hora: 11:42 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	partial class FormPendientes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPendientes));
			this.dgPendiente = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OP_COBRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hora_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdRefresca = new System.Windows.Forms.Button();
			this.cmdExcel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.cmdListo = new System.Windows.Forms.Button();
			this.cbMostrar = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbPagados = new System.Windows.Forms.RadioButton();
			this.rbIncobrable = new System.Windows.Forms.RadioButton();
			this.rbPendiente = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgPendiente)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgPendiente
			// 
			this.dgPendiente.AllowUserToAddRows = false;
			this.dgPendiente.AllowUserToResizeRows = false;
			this.dgPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgPendiente.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPendiente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPendiente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.OPERADOR,
									this.SALDO,
									this.DESTINO,
									this.FECHA,
									this.REGRESO,
									this.HORAS,
									this.OP_COBRA,
									this.TIPO_PAGO,
									this.REGISTRO,
									this.hora_regreso,
									this.dato,
									this.factura});
			this.dgPendiente.Location = new System.Drawing.Point(12, 63);
			this.dgPendiente.Name = "dgPendiente";
			this.dgPendiente.RowHeadersVisible = false;
			this.dgPendiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPendiente.Size = new System.Drawing.Size(1296, 667);
			this.dgPendiente.TabIndex = 0;
			this.dgPendiente.DoubleClick += new System.EventHandler(this.DgPendienteDoubleClick);
			// 
			// ID
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 40;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle3;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 110;
			// 
			// SALDO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALDO.DefaultCellStyle = dataGridViewCellStyle4;
			this.SALDO.HeaderText = "SALDO";
			this.SALDO.Name = "SALDO";
			this.SALDO.ReadOnly = true;
			// 
			// DESTINO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DESTINO.DefaultCellStyle = dataGridViewCellStyle5;
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			this.DESTINO.Width = 200;
			// 
			// FECHA
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle6;
			this.FECHA.HeaderText = "SALIDA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// REGRESO
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.REGRESO.DefaultCellStyle = dataGridViewCellStyle7;
			this.REGRESO.HeaderText = "REGRESO";
			this.REGRESO.Name = "REGRESO";
			this.REGRESO.ReadOnly = true;
			// 
			// HORAS
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HORAS.DefaultCellStyle = dataGridViewCellStyle8;
			this.HORAS.HeaderText = "HORAS";
			this.HORAS.Name = "HORAS";
			this.HORAS.ReadOnly = true;
			// 
			// OP_COBRA
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OP_COBRA.DefaultCellStyle = dataGridViewCellStyle9;
			this.OP_COBRA.HeaderText = "OP. COBRA";
			this.OP_COBRA.Name = "OP_COBRA";
			this.OP_COBRA.ReadOnly = true;
			// 
			// TIPO_PAGO
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO_PAGO.DefaultCellStyle = dataGridViewCellStyle10;
			this.TIPO_PAGO.HeaderText = "TIPO PAGO";
			this.TIPO_PAGO.Name = "TIPO_PAGO";
			this.TIPO_PAGO.ReadOnly = true;
			this.TIPO_PAGO.Width = 110;
			// 
			// REGISTRO
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.REGISTRO.DefaultCellStyle = dataGridViewCellStyle11;
			this.REGISTRO.HeaderText = "REGISTRO";
			this.REGISTRO.Name = "REGISTRO";
			this.REGISTRO.ReadOnly = true;
			// 
			// hora_regreso
			// 
			this.hora_regreso.HeaderText = "HORA_REGRESO";
			this.hora_regreso.Name = "hora_regreso";
			this.hora_regreso.ReadOnly = true;
			this.hora_regreso.Visible = false;
			// 
			// dato
			// 
			this.dato.HeaderText = "dato";
			this.dato.Name = "dato";
			this.dato.ReadOnly = true;
			this.dato.Visible = false;
			// 
			// factura
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.factura.DefaultCellStyle = dataGridViewCellStyle12;
			this.factura.HeaderText = "DATOS FACTURA";
			this.factura.Name = "factura";
			this.factura.Width = 200;
			// 
			// cmdRefresca
			// 
			this.cmdRefresca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRefresca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRefresca.BackgroundImage")));
			this.cmdRefresca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdRefresca.Location = new System.Drawing.Point(1268, 12);
			this.cmdRefresca.Name = "cmdRefresca";
			this.cmdRefresca.Size = new System.Drawing.Size(40, 40);
			this.cmdRefresca.TabIndex = 1;
			this.cmdRefresca.UseVisualStyleBackColor = true;
			this.cmdRefresca.Click += new System.EventHandler(this.CmdRefrescaClick);
			// 
			// cmdExcel
			// 
			this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcel.BackgroundImage")));
			this.cmdExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdExcel.Location = new System.Drawing.Point(1222, 12);
			this.cmdExcel.Name = "cmdExcel";
			this.cmdExcel.Size = new System.Drawing.Size(40, 40);
			this.cmdExcel.TabIndex = 2;
			this.cmdExcel.UseVisualStyleBackColor = true;
			this.cmdExcel.Click += new System.EventHandler(this.CmdExcelClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpInicio);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 53);
			this.groupBox1.TabIndex = 66;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inicio";
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(9, 20);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(114, 20);
			this.dtpInicio.TabIndex = 6;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// cmdListo
			// 
			this.cmdListo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdListo.BackgroundImage")));
			this.cmdListo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdListo.Location = new System.Drawing.Point(174, 24);
			this.cmdListo.Name = "cmdListo";
			this.cmdListo.Size = new System.Drawing.Size(40, 33);
			this.cmdListo.TabIndex = 67;
			this.cmdListo.UseVisualStyleBackColor = true;
			this.cmdListo.Click += new System.EventHandler(this.CmdListoClick);
			// 
			// cbMostrar
			// 
			this.cbMostrar.Checked = true;
			this.cbMostrar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMostrar.Location = new System.Drawing.Point(162, 4);
			this.cbMostrar.Name = "cbMostrar";
			this.cbMostrar.Size = new System.Drawing.Size(72, 18);
			this.cbMostrar.TabIndex = 69;
			this.cbMostrar.Text = "Mostrar";
			this.cbMostrar.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbPagados);
			this.groupBox2.Controls.Add(this.rbIncobrable);
			this.groupBox2.Controls.Add(this.rbPendiente);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(265, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 53);
			this.groupBox2.TabIndex = 70;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Muestra";
			// 
			// rbPagados
			// 
			this.rbPagados.Location = new System.Drawing.Point(203, 19);
			this.rbPagados.Name = "rbPagados";
			this.rbPagados.Size = new System.Drawing.Size(84, 24);
			this.rbPagados.TabIndex = 2;
			this.rbPagados.Text = "Pagados";
			this.rbPagados.UseVisualStyleBackColor = true;
			this.rbPagados.CheckedChanged += new System.EventHandler(this.RbPagadosCheckedChanged);
			// 
			// rbIncobrable
			// 
			this.rbIncobrable.Location = new System.Drawing.Point(103, 19);
			this.rbIncobrable.Name = "rbIncobrable";
			this.rbIncobrable.Size = new System.Drawing.Size(94, 24);
			this.rbIncobrable.TabIndex = 1;
			this.rbIncobrable.Text = "Incobrables";
			this.rbIncobrable.UseVisualStyleBackColor = true;
			this.rbIncobrable.CheckedChanged += new System.EventHandler(this.RbIncobrableCheckedChanged);
			// 
			// rbPendiente
			// 
			this.rbPendiente.Checked = true;
			this.rbPendiente.Location = new System.Drawing.Point(9, 19);
			this.rbPendiente.Name = "rbPendiente";
			this.rbPendiente.Size = new System.Drawing.Size(88, 24);
			this.rbPendiente.TabIndex = 0;
			this.rbPendiente.TabStop = true;
			this.rbPendiente.Text = "Pendientes";
			this.rbPendiente.UseVisualStyleBackColor = true;
			this.rbPendiente.CheckedChanged += new System.EventHandler(this.RbPendienteCheckedChanged);
			// 
			// FormPendientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1320, 742);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.cbMostrar);
			this.Controls.Add(this.cmdListo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdExcel);
			this.Controls.Add(this.cmdRefresca);
			this.Controls.Add(this.dgPendiente);
			this.Name = "FormPendientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Viajes especiales";
			this.Load += new System.EventHandler(this.FormPendientesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgPendiente)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton rbPendiente;
		private System.Windows.Forms.RadioButton rbIncobrable;
		private System.Windows.Forms.RadioButton rbPagados;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox cbMostrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn factura;
		private System.Windows.Forms.Button cmdListo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dato;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn hora_regreso;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn REGRESO;
		private System.Windows.Forms.Button cmdRefresca;
		private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PAGO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OP_COBRA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgPendiente;
		
	}
}
