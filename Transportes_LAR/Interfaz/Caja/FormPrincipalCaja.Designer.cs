/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 14/08/2014
 * Hora: 10:08 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Caja
{
	partial class FormPrincipalCaja
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalCaja));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtResponsable = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtConcepto = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAutoriza = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.rbEntrada = new System.Windows.Forms.RadioButton();
			this.rbSalida = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AUTORIZA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FLUJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.txtBusAut = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBusConc = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBusResp = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmdExcel = new System.Windows.Forms.Button();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtSalida = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.rbCierre = new System.Windows.Forms.RadioButton();
			this.txtInicio = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDisponible = new System.Windows.Forms.TextBox();
			this.lblDato = new System.Windows.Forms.Label();
			this.cmdModifica = new System.Windows.Forms.Button();
			this.cmdElimina = new System.Windows.Forms.Button();
			this.cmdNuevo = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1051, 25);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(76, 22);
			this.toolStripLabel1.Text = "Responsable";
			this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1Click);
			// 
			// txtResponsable
			// 
			this.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResponsable.Location = new System.Drawing.Point(14, 250);
			this.txtResponsable.Name = "txtResponsable";
			this.txtResponsable.Size = new System.Drawing.Size(172, 22);
			this.txtResponsable.TabIndex = 7;
			this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtResponsable.Enter += new System.EventHandler(this.TxtResponsableEnter);
			this.txtResponsable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtResponsableKeyUp);
			this.txtResponsable.Leave += new System.EventHandler(this.TxtResponsableLeave);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 270);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Responsable";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 308);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Concepto";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtConcepto
			// 
			this.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConcepto.Location = new System.Drawing.Point(14, 288);
			this.txtConcepto.Name = "txtConcepto";
			this.txtConcepto.Size = new System.Drawing.Size(172, 22);
			this.txtConcepto.TabIndex = 8;
			this.txtConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtConcepto.Enter += new System.EventHandler(this.TxtConceptoEnter);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 346);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Autoriza";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtAutoriza
			// 
			this.txtAutoriza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAutoriza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAutoriza.Location = new System.Drawing.Point(14, 326);
			this.txtAutoriza.Name = "txtAutoriza";
			this.txtAutoriza.Size = new System.Drawing.Size(172, 22);
			this.txtAutoriza.TabIndex = 9;
			this.txtAutoriza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAutoriza.Enter += new System.EventHandler(this.TxtAutorizaEnter);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 384);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Observación";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtObservacion
			// 
			this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacion.Location = new System.Drawing.Point(14, 364);
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(172, 22);
			this.txtObservacion.TabIndex = 10;
			this.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtObservacion.Enter += new System.EventHandler(this.TxtObservacionEnter);
			// 
			// rbEntrada
			// 
			this.rbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbEntrada.Location = new System.Drawing.Point(39, 12);
			this.rbEntrada.Name = "rbEntrada";
			this.rbEntrada.Size = new System.Drawing.Size(75, 18);
			this.rbEntrada.TabIndex = 3;
			this.rbEntrada.Text = "Entrada";
			this.rbEntrada.UseVisualStyleBackColor = true;
			// 
			// rbSalida
			// 
			this.rbSalida.Checked = true;
			this.rbSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSalida.Location = new System.Drawing.Point(39, 36);
			this.rbSalida.Name = "rbSalida";
			this.rbSalida.Size = new System.Drawing.Size(75, 18);
			this.rbSalida.TabIndex = 4;
			this.rbSalida.TabStop = true;
			this.rbSalida.Text = "Salida";
			this.rbSalida.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 232);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(172, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "Cantidad";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtCantidad
			// 
			this.txtCantidad.BackColor = System.Drawing.Color.Silver;
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(14, 212);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(172, 22);
			this.txtCantidad.TabIndex = 6;
			this.txtCantidad.Text = "0";
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantidad.Enter += new System.EventHandler(this.TxtCantidadEnter);
			this.txtCantidad.Leave += new System.EventHandler(this.TxtCantidadLeave);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.Location = new System.Drawing.Point(58, 418);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(86, 43);
			this.cmdGuardar.TabIndex = 11;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.FECHA,
									this.RESPONSABLE,
									this.CANTIDAD,
									this.CONCEPTO,
									this.AUTORIZA,
									this.OBSERVACIONES,
									this.SALIDA,
									this.FLUJO});
			this.dgDatos.Location = new System.Drawing.Point(201, 115);
			this.dgDatos.MultiSelect = false;
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(838, 420);
			this.dgDatos.TabIndex = 40;
			this.dgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatosCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// FECHA
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle2;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// RESPONSABLE
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RESPONSABLE.DefaultCellStyle = dataGridViewCellStyle3;
			this.RESPONSABLE.HeaderText = "RESPONSABLE";
			this.RESPONSABLE.Name = "RESPONSABLE";
			this.RESPONSABLE.ReadOnly = true;
			this.RESPONSABLE.Width = 150;
			// 
			// CANTIDAD
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle4;
			this.CANTIDAD.HeaderText = "CANTIDAD";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			// 
			// CONCEPTO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CONCEPTO.DefaultCellStyle = dataGridViewCellStyle5;
			this.CONCEPTO.HeaderText = "CONCEPTO";
			this.CONCEPTO.Name = "CONCEPTO";
			this.CONCEPTO.ReadOnly = true;
			this.CONCEPTO.Width = 150;
			// 
			// AUTORIZA
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AUTORIZA.DefaultCellStyle = dataGridViewCellStyle6;
			this.AUTORIZA.HeaderText = "AUTORIZA";
			this.AUTORIZA.Name = "AUTORIZA";
			this.AUTORIZA.ReadOnly = true;
			this.AUTORIZA.Width = 150;
			// 
			// OBSERVACIONES
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OBSERVACIONES.DefaultCellStyle = dataGridViewCellStyle7;
			this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
			this.OBSERVACIONES.Name = "OBSERVACIONES";
			this.OBSERVACIONES.ReadOnly = true;
			this.OBSERVACIONES.Width = 200;
			// 
			// SALIDA
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALIDA.DefaultCellStyle = dataGridViewCellStyle8;
			this.SALIDA.HeaderText = "TIPO";
			this.SALIDA.Name = "SALIDA";
			this.SALIDA.ReadOnly = true;
			this.SALIDA.Width = 90;
			// 
			// FLUJO
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FLUJO.DefaultCellStyle = dataGridViewCellStyle9;
			this.FLUJO.HeaderText = "FLUJO";
			this.FLUJO.Name = "FLUJO";
			this.FLUJO.ReadOnly = true;
			this.FLUJO.Visible = false;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(53, 82);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(91, 20);
			this.dtpFecha.TabIndex = 0;
			this.dtpFecha.ValueChanged += new System.EventHandler(this.DtpFechaValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(106, 9);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(91, 20);
			this.dtpFin.TabIndex = 15;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// dtpInicio
			// 
			this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(9, 9);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(91, 20);
			this.dtpInicio.TabIndex = 14;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// txtBusAut
			// 
			this.txtBusAut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusAut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusAut.Location = new System.Drawing.Point(547, 10);
			this.txtBusAut.Name = "txtBusAut";
			this.txtBusAut.Size = new System.Drawing.Size(166, 22);
			this.txtBusAut.TabIndex = 18;
			this.txtBusAut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBusAut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusAutKeyUp);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(375, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 15);
			this.label6.TabIndex = 19;
			this.label6.Text = "Concepto";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtBusConc
			// 
			this.txtBusConc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusConc.Location = new System.Drawing.Point(375, 10);
			this.txtBusConc.Name = "txtBusConc";
			this.txtBusConc.Size = new System.Drawing.Size(166, 22);
			this.txtBusConc.TabIndex = 17;
			this.txtBusConc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBusConc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusConcKeyUp);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(203, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(166, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "Responsable";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtBusResp
			// 
			this.txtBusResp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusResp.Location = new System.Drawing.Point(203, 9);
			this.txtBusResp.Name = "txtBusResp";
			this.txtBusResp.Size = new System.Drawing.Size(166, 22);
			this.txtBusResp.TabIndex = 16;
			this.txtBusResp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBusResp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusRespKeyUp);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(547, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(166, 15);
			this.label8.TabIndex = 20;
			this.label8.Text = "Autoriza";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.cmdExcel);
			this.panel1.Controls.Add(this.dtpInicio);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dtpFin);
			this.panel1.Controls.Add(this.txtBusAut);
			this.panel1.Controls.Add(this.txtBusResp);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtBusConc);
			this.panel1.Location = new System.Drawing.Point(201, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(838, 48);
			this.panel1.TabIndex = 19;
			// 
			// cmdExcel
			// 
			this.cmdExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdExcel.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.Image")));
			this.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdExcel.Location = new System.Drawing.Point(725, 7);
			this.cmdExcel.Name = "cmdExcel";
			this.cmdExcel.Size = new System.Drawing.Size(110, 34);
			this.cmdExcel.TabIndex = 21;
			this.cmdExcel.Text = "EXCEL";
			this.cmdExcel.UseVisualStyleBackColor = true;
			this.cmdExcel.Click += new System.EventHandler(this.CmdExcelClick);
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(873, 541);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(166, 22);
			this.txtTotal.TabIndex = 23;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(873, 561);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(166, 15);
			this.label9.TabIndex = 22;
			this.label9.Text = "Total";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtEntrada
			// 
			this.txtEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEntrada.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEntrada.Enabled = false;
			this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntrada.Location = new System.Drawing.Point(529, 541);
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(166, 22);
			this.txtEntrada.TabIndex = 25;
			this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(529, 561);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(166, 15);
			this.label10.TabIndex = 24;
			this.label10.Text = "Entrada";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtSalida
			// 
			this.txtSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSalida.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSalida.Enabled = false;
			this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalida.Location = new System.Drawing.Point(701, 541);
			this.txtSalida.Name = "txtSalida";
			this.txtSalida.Size = new System.Drawing.Size(166, 22);
			this.txtSalida.TabIndex = 27;
			this.txtSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(701, 561);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(166, 15);
			this.label11.TabIndex = 26;
			this.label11.Text = "Salida";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rbCierre
			// 
			this.rbCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCierre.Location = new System.Drawing.Point(39, 60);
			this.rbCierre.Name = "rbCierre";
			this.rbCierre.Size = new System.Drawing.Size(75, 18);
			this.rbCierre.TabIndex = 5;
			this.rbCierre.Text = "Cierre";
			this.rbCierre.UseVisualStyleBackColor = true;
			this.rbCierre.CheckedChanged += new System.EventHandler(this.RbCierreCheckedChanged);
			// 
			// txtInicio
			// 
			this.txtInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtInicio.Enabled = false;
			this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInicio.Location = new System.Drawing.Point(249, 85);
			this.txtInicio.Name = "txtInicio";
			this.txtInicio.Size = new System.Drawing.Size(166, 22);
			this.txtInicio.TabIndex = 29;
			this.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(186, 85);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 24);
			this.label12.TabIndex = 30;
			this.label12.Text = "Inicio:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbCierre);
			this.groupBox1.Controls.Add(this.rbSalida);
			this.groupBox1.Controls.Add(this.rbEntrada);
			this.groupBox1.Location = new System.Drawing.Point(14, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(172, 89);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(770, 85);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(97, 24);
			this.label13.TabIndex = 33;
			this.label13.Text = "Disponible:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDisponible
			// 
			this.txtDisponible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDisponible.Enabled = false;
			this.txtDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisponible.Location = new System.Drawing.Point(873, 85);
			this.txtDisponible.Name = "txtDisponible";
			this.txtDisponible.Size = new System.Drawing.Size(166, 22);
			this.txtDisponible.TabIndex = 32;
			this.txtDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblDato
			// 
			this.lblDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDato.Location = new System.Drawing.Point(421, 85);
			this.lblDato.Name = "lblDato";
			this.lblDato.Size = new System.Drawing.Size(343, 24);
			this.lblDato.TabIndex = 34;
			this.lblDato.Text = "Dato";
			this.lblDato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmdModifica
			// 
			this.cmdModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdModifica.Enabled = false;
			this.cmdModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdModifica.Image = ((System.Drawing.Image)(resources.GetObject("cmdModifica.Image")));
			this.cmdModifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdModifica.Location = new System.Drawing.Point(14, 504);
			this.cmdModifica.Name = "cmdModifica";
			this.cmdModifica.Size = new System.Drawing.Size(86, 31);
			this.cmdModifica.TabIndex = 12;
			this.cmdModifica.Text = "Modifica";
			this.cmdModifica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdModifica.UseVisualStyleBackColor = true;
			this.cmdModifica.Click += new System.EventHandler(this.CmdModificaClick);
			// 
			// cmdElimina
			// 
			this.cmdElimina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdElimina.Enabled = false;
			this.cmdElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdElimina.Image = ((System.Drawing.Image)(resources.GetObject("cmdElimina.Image")));
			this.cmdElimina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdElimina.Location = new System.Drawing.Point(100, 504);
			this.cmdElimina.Name = "cmdElimina";
			this.cmdElimina.Size = new System.Drawing.Size(86, 31);
			this.cmdElimina.TabIndex = 13;
			this.cmdElimina.Text = "Elimina";
			this.cmdElimina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdElimina.UseVisualStyleBackColor = true;
			this.cmdElimina.Click += new System.EventHandler(this.CmdEliminaClick);
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.Enabled = false;
			this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdNuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Image")));
			this.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdNuevo.Location = new System.Drawing.Point(58, 31);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(86, 36);
			this.cmdNuevo.TabIndex = 41;
			this.cmdNuevo.Text = "Nuevo";
			this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// FormPrincipalCaja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1051, 577);
			this.Controls.Add(this.cmdNuevo);
			this.Controls.Add(this.cmdElimina);
			this.Controls.Add(this.cmdModifica);
			this.Controls.Add(this.lblDato);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtDisponible);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtInicio);
			this.Controls.Add(this.txtSalida);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtEntrada);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.dgDatos);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtObservacion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAutoriza);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtConcepto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtResponsable);
			this.Controls.Add(this.toolStrip1);
			this.Name = "FormPrincipalCaja";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Caja";
			this.Load += new System.EventHandler(this.FormPrincipalCajaLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdNuevo;
		private System.Windows.Forms.Button cmdElimina;
		private System.Windows.Forms.Button cmdModifica;
		private System.Windows.Forms.Label lblDato;
		private System.Windows.Forms.TextBox txtDisponible;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtInicio;
		private System.Windows.Forms.RadioButton rbCierre;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSalida;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtEntrada;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Button cmdExcel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBusResp;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBusConc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBusAut;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FLUJO;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
		private System.Windows.Forms.DataGridViewTextBoxColumn AUTORIZA;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rbSalida;
		private System.Windows.Forms.RadioButton rbEntrada;
		private System.Windows.Forms.TextBox txtObservacion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAutoriza;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtConcepto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtResponsable;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
