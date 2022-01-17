/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 11/08/2016
 * Hora: 12:54 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	partial class FormUber_TaxiExtra
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUber_TaxiExtra));
			this.gbProgramcion = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpHoraPedido = new System.Windows.Forms.DateTimePicker();
			this.lblInicio = new System.Windows.Forms.Label();
			this.txtResponsable = new System.Windows.Forms.TextBox();
			this.cmbTipoUnidad = new System.Windows.Forms.ComboBox();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblResponsable = new System.Windows.Forms.Label();
			this.txtItinerarioB = new System.Windows.Forms.TextBox();
			this.txtItinerarioA = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbTraslado = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblMotivo = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbConfiguraciones = new System.Windows.Forms.PictureBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbTodos = new System.Windows.Forms.CheckBox();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpIncio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgReporte = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.pbConfiguraciones1 = new System.Windows.Forms.PictureBox();
			this.gbProgramcion.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbProgramcion
			// 
			this.gbProgramcion.Controls.Add(this.pbConfiguraciones1);
			this.gbProgramcion.Controls.Add(this.label7);
			this.gbProgramcion.Controls.Add(this.btnCancelar);
			this.gbProgramcion.Controls.Add(this.dtpFechaPedido);
			this.gbProgramcion.Controls.Add(this.label1);
			this.gbProgramcion.Controls.Add(this.dtpHoraPedido);
			this.gbProgramcion.Controls.Add(this.lblInicio);
			this.gbProgramcion.Controls.Add(this.txtResponsable);
			this.gbProgramcion.Controls.Add(this.cmbTipoUnidad);
			this.gbProgramcion.Controls.Add(this.lblTipo);
			this.gbProgramcion.Controls.Add(this.lblResponsable);
			this.gbProgramcion.Controls.Add(this.txtItinerarioB);
			this.gbProgramcion.Controls.Add(this.txtItinerarioA);
			this.gbProgramcion.Controls.Add(this.label9);
			this.gbProgramcion.Controls.Add(this.cmbTraslado);
			this.gbProgramcion.Controls.Add(this.label8);
			this.gbProgramcion.Controls.Add(this.txtMotivo);
			this.gbProgramcion.Controls.Add(this.txtUsuario);
			this.gbProgramcion.Controls.Add(this.btnGuardar);
			this.gbProgramcion.Controls.Add(this.label3);
			this.gbProgramcion.Controls.Add(this.lblMotivo);
			this.gbProgramcion.Controls.Add(this.panel2);
			this.gbProgramcion.Location = new System.Drawing.Point(4, 0);
			this.gbProgramcion.Name = "gbProgramcion";
			this.gbProgramcion.Size = new System.Drawing.Size(426, 224);
			this.gbProgramcion.TabIndex = 2;
			this.gbProgramcion.TabStop = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(32, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(380, 3);
			this.label7.TabIndex = 164;
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Location = new System.Drawing.Point(292, 176);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(85, 45);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// dtpFechaPedido
			// 
			this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaPedido.Location = new System.Drawing.Point(319, 131);
			this.dtpFechaPedido.Name = "dtpFechaPedido";
			this.dtpFechaPedido.Size = new System.Drawing.Size(100, 20);
			this.dtpFechaPedido.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(239, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 18);
			this.label1.TabIndex = 162;
			this.label1.Text = "Fecha Pedido:";
			// 
			// dtpHoraPedido
			// 
			this.dtpHoraPedido.CustomFormat = "HH:mm";
			this.dtpHoraPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraPedido.Location = new System.Drawing.Point(185, 130);
			this.dtpHoraPedido.Name = "dtpHoraPedido";
			this.dtpHoraPedido.ShowUpDown = true;
			this.dtpHoraPedido.Size = new System.Drawing.Size(51, 20);
			this.dtpHoraPedido.TabIndex = 8;
			// 
			// lblInicio
			// 
			this.lblInicio.Location = new System.Drawing.Point(118, 132);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(84, 18);
			this.lblInicio.TabIndex = 161;
			this.lblInicio.Text = "Hora Pedido:";
			// 
			// txtResponsable
			// 
			this.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtResponsable.Location = new System.Drawing.Point(288, 15);
			this.txtResponsable.Name = "txtResponsable";
			this.txtResponsable.Size = new System.Drawing.Size(132, 20);
			this.txtResponsable.TabIndex = 2;
			this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtResponsable.TextChanged += new System.EventHandler(this.TxtResponsableTextChanged);
			// 
			// cmbTipoUnidad
			// 
			this.cmbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoUnidad.FormattingEnabled = true;
			this.cmbTipoUnidad.Items.AddRange(new object[] {
									"UBER",
									"TAXI"});
			this.cmbTipoUnidad.Location = new System.Drawing.Point(64, 128);
			this.cmbTipoUnidad.Name = "cmbTipoUnidad";
			this.cmbTipoUnidad.Size = new System.Drawing.Size(54, 21);
			this.cmbTipoUnidad.TabIndex = 7;
			// 
			// lblTipo
			// 
			this.lblTipo.Location = new System.Drawing.Point(32, 131);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(31, 19);
			this.lblTipo.TabIndex = 159;
			this.lblTipo.Text = "Tipo:";
			// 
			// lblResponsable
			// 
			this.lblResponsable.Location = new System.Drawing.Point(216, 18);
			this.lblResponsable.Name = "lblResponsable";
			this.lblResponsable.Size = new System.Drawing.Size(78, 19);
			this.lblResponsable.TabIndex = 160;
			this.lblResponsable.Text = "Responsable:";
			// 
			// txtItinerarioB
			// 
			this.txtItinerarioB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtItinerarioB.Location = new System.Drawing.Point(340, 46);
			this.txtItinerarioB.Name = "txtItinerarioB";
			this.txtItinerarioB.Size = new System.Drawing.Size(80, 20);
			this.txtItinerarioB.TabIndex = 5;
			this.txtItinerarioB.Text = "PUNTO B";
			this.txtItinerarioB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtItinerarioB.Enter += new System.EventHandler(this.TxtItinerarioBEnter);
			this.txtItinerarioB.Leave += new System.EventHandler(this.TxtItinerarioBLeave);
			// 
			// txtItinerarioA
			// 
			this.txtItinerarioA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtItinerarioA.Location = new System.Drawing.Point(255, 46);
			this.txtItinerarioA.Name = "txtItinerarioA";
			this.txtItinerarioA.Size = new System.Drawing.Size(80, 20);
			this.txtItinerarioA.TabIndex = 4;
			this.txtItinerarioA.Text = "PUNTO A";
			this.txtItinerarioA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtItinerarioA.Enter += new System.EventHandler(this.TxtItinerarioAEnter);
			this.txtItinerarioA.Leave += new System.EventHandler(this.TxtItinerarioALeave);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(206, 49);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 14);
			this.label9.TabIndex = 154;
			this.label9.Text = "Itinerario: ";
			// 
			// cmbTraslado
			// 
			this.cmbTraslado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTraslado.FormattingEnabled = true;
			this.cmbTraslado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmbTraslado.Items.AddRange(new object[] {
									"PERSONAL",
									"TRABAJO"});
			this.cmbTraslado.Location = new System.Drawing.Point(62, 44);
			this.cmbTraslado.Name = "cmbTraslado";
			this.cmbTraslado.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbTraslado.Size = new System.Drawing.Size(138, 21);
			this.cmbTraslado.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(11, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 16);
			this.label8.TabIndex = 153;
			this.label8.Text = "Traslado: ";
			// 
			// txtMotivo
			// 
			this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMotivo.Location = new System.Drawing.Point(63, 74);
			this.txtMotivo.Multiline = true;
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(357, 42);
			this.txtMotivo.TabIndex = 6;
			this.txtMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Location = new System.Drawing.Point(62, 15);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(138, 20);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuarioTextChanged);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(121, 176);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(77, 45);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 14);
			this.label3.TabIndex = 145;
			this.label3.Text = "Usuario:";
			// 
			// lblMotivo
			// 
			this.lblMotivo.Location = new System.Drawing.Point(19, 87);
			this.lblMotivo.Name = "lblMotivo";
			this.lblMotivo.Size = new System.Drawing.Size(44, 16);
			this.lblMotivo.TabIndex = 130;
			this.lblMotivo.Text = "Motivo:";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.pbConfiguraciones);
			this.panel2.Location = new System.Drawing.Point(5, 179);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(0, 40);
			this.panel2.TabIndex = 129;
			// 
			// pbConfiguraciones
			// 
			this.pbConfiguraciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pbConfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("pbConfiguraciones.Image")));
			this.pbConfiguraciones.Location = new System.Drawing.Point(-34, 4);
			this.pbConfiguraciones.Name = "pbConfiguraciones";
			this.pbConfiguraciones.Size = new System.Drawing.Size(33, 32);
			this.pbConfiguraciones.TabIndex = 151;
			this.pbConfiguraciones.TabStop = false;
			this.pbConfiguraciones.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.dgReporte);
			this.groupBox1.Location = new System.Drawing.Point(450, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(452, 225);
			this.groupBox1.TabIndex = 171;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbTodos);
			this.groupBox2.Controls.Add(this.dtpFin);
			this.groupBox2.Controls.Add(this.dtpIncio);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(6, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(440, 36);
			this.groupBox2.TabIndex = 172;
			this.groupBox2.TabStop = false;
			// 
			// cbTodos
			// 
			this.cbTodos.Enabled = false;
			this.cbTodos.Location = new System.Drawing.Point(278, 9);
			this.cbTodos.Name = "cbTodos";
			this.cbTodos.Size = new System.Drawing.Size(104, 24);
			this.cbTodos.TabIndex = 179;
			this.cbTodos.Text = "Todos";
			this.cbTodos.UseVisualStyleBackColor = true;
			this.cbTodos.CheckedChanged += new System.EventHandler(this.CbTodosCheckedChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(164, 11);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 20);
			this.dtpFin.TabIndex = 178;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// dtpIncio
			// 
			this.dtpIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIncio.Location = new System.Drawing.Point(38, 10);
			this.dtpIncio.Name = "dtpIncio";
			this.dtpIncio.Size = new System.Drawing.Size(100, 20);
			this.dtpIncio.TabIndex = 177;
			this.dtpIncio.ValueChanged += new System.EventHandler(this.DtpIncioValueChanged);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(138, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 19);
			this.label5.TabIndex = 181;
			this.label5.Text = "al";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 18);
			this.label6.TabIndex = 180;
			this.label6.Text = "Del";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dgReporte
			// 
			this.dgReporte.AllowDrop = true;
			this.dgReporte.AllowUserToAddRows = false;
			this.dgReporte.AllowUserToDeleteRows = false;
			this.dgReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn47,
									this.ID_PEDIDO,
									this.ID_OPERADOR,
									this.Folio,
									this.MOTIVO,
									this.DIA,
									this.OPERADOR,
									this.Tipo,
									this.Responsable,
									this.Usuarios,
									this.Costo,
									this.Estado});
			this.dgReporte.Location = new System.Drawing.Point(6, 50);
			this.dgReporte.Name = "dgReporte";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgReporte.RowHeadersVisible = false;
			this.dgReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgReporte.Size = new System.Drawing.Size(440, 171);
			this.dgReporte.TabIndex = 171;
			this.dgReporte.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgReporteCellDoubleClick);
			// 
			// dataGridViewTextBoxColumn47
			// 
			this.dataGridViewTextBoxColumn47.HeaderText = "ID_UBER_TAXI";
			this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
			this.dataGridViewTextBoxColumn47.Visible = false;
			this.dataGridViewTextBoxColumn47.Width = 120;
			// 
			// ID_PEDIDO
			// 
			this.ID_PEDIDO.HeaderText = "ID_PEDIDO";
			this.ID_PEDIDO.Name = "ID_PEDIDO";
			this.ID_PEDIDO.Visible = false;
			this.ID_PEDIDO.Width = 94;
			// 
			// ID_OPERADOR
			// 
			this.ID_OPERADOR.HeaderText = "ID_OPERADOR";
			this.ID_OPERADOR.Name = "ID_OPERADOR";
			this.ID_OPERADOR.Visible = false;
			this.ID_OPERADOR.Width = 122;
			// 
			// Folio
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			this.Folio.DefaultCellStyle = dataGridViewCellStyle2;
			this.Folio.HeaderText = "Folio";
			this.Folio.Name = "Folio";
			this.Folio.ReadOnly = true;
			this.Folio.Width = 68;
			// 
			// MOTIVO
			// 
			this.MOTIVO.FillWeight = 130F;
			this.MOTIVO.HeaderText = "Motivo";
			this.MOTIVO.Name = "MOTIVO";
			this.MOTIVO.ReadOnly = true;
			this.MOTIVO.Width = 79;
			// 
			// DIA
			// 
			this.DIA.FillWeight = 115F;
			this.DIA.HeaderText = "Fecha";
			this.DIA.Name = "DIA";
			this.DIA.ReadOnly = true;
			this.DIA.Width = 76;
			// 
			// OPERADOR
			// 
			this.OPERADOR.HeaderText = "Usuario";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 87;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Width = 65;
			// 
			// Responsable
			// 
			this.Responsable.HeaderText = "Responsable";
			this.Responsable.Name = "Responsable";
			this.Responsable.ReadOnly = true;
			this.Responsable.Width = 126;
			// 
			// Usuarios
			// 
			this.Usuarios.HeaderText = "Usuarios";
			this.Usuarios.Name = "Usuarios";
			this.Usuarios.ReadOnly = true;
			this.Usuarios.Width = 95;
			// 
			// Costo
			// 
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			this.Costo.Width = 73;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			this.Estado.Width = 82;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(435, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 224);
			this.label2.TabIndex = 172;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbConfiguraciones1
			// 
			this.pbConfiguraciones1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pbConfiguraciones1.Image = ((System.Drawing.Image)(resources.GetObject("pbConfiguraciones1.Image")));
			this.pbConfiguraciones1.Location = new System.Drawing.Point(8, 187);
			this.pbConfiguraciones1.Name = "pbConfiguraciones1";
			this.pbConfiguraciones1.Size = new System.Drawing.Size(33, 32);
			this.pbConfiguraciones1.TabIndex = 165;
			this.pbConfiguraciones1.TabStop = false;
			this.pbConfiguraciones1.Visible = false;
			this.pbConfiguraciones1.Click += new System.EventHandler(this.PbConfiguraciones1Click);
			// 
			// FormUber_TaxiExtra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 226);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbProgramcion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormUber_TaxiExtra";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Uber-Taxi Extra";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUber_TaxiExtraFormClosing);
			this.Load += new System.EventHandler(this.FormUber_TaxiExtraLoad);
			this.gbProgramcion.ResumeLayout(false);
			this.gbProgramcion.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pbConfiguraciones1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIncio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.CheckBox cbTodos;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuarios;
		private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIA;
		private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
		public System.Windows.Forms.DataGridView dgReporte;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblMotivo;
		private System.Windows.Forms.Label lblResponsable;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbTipoUnidad;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtUsuario;
		public System.Windows.Forms.TextBox txtResponsable;
		public System.Windows.Forms.TextBox txtMotivo;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.DateTimePicker dtpHoraPedido;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFechaPedido;
		private System.Windows.Forms.PictureBox pbConfiguraciones;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbTraslado;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtItinerarioA;
		private System.Windows.Forms.TextBox txtItinerarioB;
		public System.Windows.Forms.GroupBox gbProgramcion;
	}
}
