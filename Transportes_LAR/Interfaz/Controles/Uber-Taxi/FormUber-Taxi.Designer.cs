/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 21/07/2016
 * Hora: 10:06 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	partial class FormUber_Taxi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUber_Taxi));
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.dgPedidos = new System.Windows.Forms.DataGridView();
			this.ID_PEDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
			this.V = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnPedido = new System.Windows.Forms.Button();
			this.txtResponsable = new System.Windows.Forms.TextBox();
			this.lblResponsable = new System.Windows.Forms.Label();
			this.cmbTipoUnidad = new System.Windows.Forms.ComboBox();
			this.lblTipo = new System.Windows.Forms.Label();
			this.gbProgramcion = new System.Windows.Forms.GroupBox();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.dtpHoraArranque = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnProgramar = new System.Windows.Forms.Button();
			this.lblUnidadA = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuarios = new System.Windows.Forms.Label();
			this.lblInicio = new System.Windows.Forms.Label();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.txtSentido = new System.Windows.Forms.TextBox();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.lblRuta = new System.Windows.Forms.Label();
			this.lblSentido = new System.Windows.Forms.Label();
			this.lblTipounidad = new System.Windows.Forms.Label();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.cbMotivo = new System.Windows.Forms.ComboBox();
			this.lblMotivo = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblHoraPlaneacion = new System.Windows.Forms.Label();
			this.lblProgramacion = new System.Windows.Forms.Label();
			this.gbPedidos = new System.Windows.Forms.GroupBox();
			this.gbUberTaxi = new System.Windows.Forms.GroupBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblLimpiar = new System.Windows.Forms.Label();
			this.pbConfiguraciones = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.gbPlaneacion = new System.Windows.Forms.GroupBox();
			this.dgProgramados = new System.Windows.Forms.DataGridView();
			this.ID_PEDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuPedidos = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.cbcancelados = new System.Windows.Forms.CheckBox();
			this.cmbBusqueda = new System.Windows.Forms.ComboBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
			this.gbProgramcion.SuspendLayout();
			this.panel2.SuspendLayout();
			this.gbPedidos.SuspendLayout();
			this.gbUberTaxi.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).BeginInit();
			this.gbPlaneacion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgProgramados)).BeginInit();
			this.MenuPedidos.SuspendLayout();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(552, -91);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Enabled = false;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(486, 16);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(71, 31);
			this.btnGuardar.TabIndex = 16;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// dgPedidos
			// 
			this.dgPedidos.AllowUserToAddRows = false;
			this.dgPedidos.AllowUserToDeleteRows = false;
			this.dgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_PEDID,
									this.ID_CUENTA,
									this.Tipo,
									this.Responsable,
									this.Tarjeta,
									this.Unidades,
									this.Costoa,
									this.Folio,
									this.Eliminar,
									this.V});
			this.dgPedidos.Location = new System.Drawing.Point(10, 57);
			this.dgPedidos.Name = "dgPedidos";
			this.dgPedidos.RowHeadersVisible = false;
			this.dgPedidos.Size = new System.Drawing.Size(550, 110);
			this.dgPedidos.TabIndex = 17;
			this.dgPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPedidosCellContentClick);
			this.dgPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPedidosCellDoubleClick);
			this.dgPedidos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPedidosCellEnter);
			this.dgPedidos.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPedidosCellLeave);
			// 
			// ID_PEDID
			// 
			this.ID_PEDID.HeaderText = "ID_VEHICULO";
			this.ID_PEDID.Name = "ID_PEDID";
			this.ID_PEDID.Visible = false;
			// 
			// ID_CUENTA
			// 
			this.ID_CUENTA.HeaderText = "ID_CUENTA";
			this.ID_CUENTA.Name = "ID_CUENTA";
			this.ID_CUENTA.Visible = false;
			// 
			// Tipo
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Tipo.DefaultCellStyle = dataGridViewCellStyle2;
			this.Tipo.FillWeight = 60F;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// Responsable
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Responsable.DefaultCellStyle = dataGridViewCellStyle3;
			this.Responsable.FillWeight = 137.7587F;
			this.Responsable.HeaderText = "Responsable";
			this.Responsable.Name = "Responsable";
			this.Responsable.ReadOnly = true;
			// 
			// Tarjeta
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Tarjeta.DefaultCellStyle = dataGridViewCellStyle4;
			this.Tarjeta.FillWeight = 80F;
			this.Tarjeta.HeaderText = "Tarjeta";
			this.Tarjeta.Name = "Tarjeta";
			this.Tarjeta.ReadOnly = true;
			// 
			// Unidades
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.NullValue = "0";
			this.Unidades.DefaultCellStyle = dataGridViewCellStyle5;
			this.Unidades.FillWeight = 51.65951F;
			this.Unidades.HeaderText = "Usuarios";
			this.Unidades.Name = "Unidades";
			this.Unidades.ReadOnly = true;
			// 
			// Costoa
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.NullValue = "0.0";
			this.Costoa.DefaultCellStyle = dataGridViewCellStyle6;
			this.Costoa.FillWeight = 86.09918F;
			this.Costoa.HeaderText = "Costo";
			this.Costoa.Name = "Costoa";
			this.Costoa.ReadOnly = true;
			// 
			// Folio
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.NullValue = "0";
			this.Folio.DefaultCellStyle = dataGridViewCellStyle7;
			this.Folio.FillWeight = 80F;
			this.Folio.HeaderText = "Folio";
			this.Folio.Name = "Folio";
			this.Folio.ReadOnly = true;
			// 
			// Eliminar
			// 
			this.Eliminar.FillWeight = 30F;
			this.Eliminar.HeaderText = "#";
			this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// V
			// 
			this.V.FillWeight = 30F;
			this.V.HeaderText = "#";
			this.V.Name = "V";
			// 
			// btnPedido
			// 
			this.btnPedido.Enabled = false;
			this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
			this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPedido.Location = new System.Drawing.Point(407, 16);
			this.btnPedido.Name = "btnPedido";
			this.btnPedido.Size = new System.Drawing.Size(71, 31);
			this.btnPedido.TabIndex = 15;
			this.btnPedido.Text = "Agregar";
			this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPedido.UseVisualStyleBackColor = true;
			this.btnPedido.Click += new System.EventHandler(this.BtnPedidoClick);
			// 
			// txtResponsable
			// 
			this.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtResponsable.Location = new System.Drawing.Point(217, 22);
			this.txtResponsable.Name = "txtResponsable";
			this.txtResponsable.Size = new System.Drawing.Size(163, 20);
			this.txtResponsable.TabIndex = 14;
			this.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtResponsable.TextChanged += new System.EventHandler(this.TxtResponsableTextChanged);
			// 
			// lblResponsable
			// 
			this.lblResponsable.Location = new System.Drawing.Point(145, 23);
			this.lblResponsable.Name = "lblResponsable";
			this.lblResponsable.Size = new System.Drawing.Size(79, 19);
			this.lblResponsable.TabIndex = 109;
			this.lblResponsable.Text = "Responsable:";
			// 
			// cmbTipoUnidad
			// 
			this.cmbTipoUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoUnidad.FormattingEnabled = true;
			this.cmbTipoUnidad.Items.AddRange(new object[] {
									"UBER",
									"TAXI"});
			this.cmbTipoUnidad.Location = new System.Drawing.Point(65, 21);
			this.cmbTipoUnidad.Name = "cmbTipoUnidad";
			this.cmbTipoUnidad.Size = new System.Drawing.Size(65, 21);
			this.cmbTipoUnidad.TabIndex = 13;
			this.cmbTipoUnidad.SelectedIndexChanged += new System.EventHandler(this.CmbTipoUnidadSelectedIndexChanged);
			// 
			// lblTipo
			// 
			this.lblTipo.Location = new System.Drawing.Point(34, 24);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(31, 23);
			this.lblTipo.TabIndex = 106;
			this.lblTipo.Text = "Tipo:";
			// 
			// gbProgramcion
			// 
			this.gbProgramcion.Controls.Add(this.txtUnidad);
			this.gbProgramcion.Controls.Add(this.label5);
			this.gbProgramcion.Controls.Add(this.txtOperador);
			this.gbProgramcion.Controls.Add(this.dtpHoraArranque);
			this.gbProgramcion.Controls.Add(this.label1);
			this.gbProgramcion.Controls.Add(this.btnProgramar);
			this.gbProgramcion.Controls.Add(this.lblUnidadA);
			this.gbProgramcion.Controls.Add(this.label2);
			this.gbProgramcion.Controls.Add(this.txtUsuario);
			this.gbProgramcion.Controls.Add(this.lblUsuarios);
			this.gbProgramcion.Controls.Add(this.lblInicio);
			this.gbProgramcion.Controls.Add(this.txtEmpresa);
			this.gbProgramcion.Controls.Add(this.txtSentido);
			this.gbProgramcion.Controls.Add(this.txtRuta);
			this.gbProgramcion.Controls.Add(this.lblRuta);
			this.gbProgramcion.Controls.Add(this.lblSentido);
			this.gbProgramcion.Controls.Add(this.lblTipounidad);
			this.gbProgramcion.Controls.Add(this.lblEmpresa);
			this.gbProgramcion.Controls.Add(this.cbMotivo);
			this.gbProgramcion.Controls.Add(this.lblMotivo);
			this.gbProgramcion.Controls.Add(this.panel2);
			this.gbProgramcion.Location = new System.Drawing.Point(6, 4);
			this.gbProgramcion.Name = "gbProgramcion";
			this.gbProgramcion.Size = new System.Drawing.Size(567, 142);
			this.gbProgramcion.TabIndex = 1;
			this.gbProgramcion.TabStop = false;
			// 
			// txtUnidad
			// 
			this.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidad.Enabled = false;
			this.txtUnidad.Location = new System.Drawing.Point(268, 116);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(112, 20);
			this.txtUnidad.TabIndex = 8;
			this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(550, 3);
			this.label5.TabIndex = 148;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Location = new System.Drawing.Point(268, 55);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(112, 20);
			this.txtOperador.TabIndex = 2;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.TextChanged += new System.EventHandler(this.TxtOperadorTextChanged);
			// 
			// dtpHoraArranque
			// 
			this.dtpHoraArranque.CustomFormat = "HH:mm";
			this.dtpHoraArranque.Enabled = false;
			this.dtpHoraArranque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHoraArranque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHoraArranque.Location = new System.Drawing.Point(65, 116);
			this.dtpHoraArranque.Name = "dtpHoraArranque";
			this.dtpHoraArranque.ShowUpDown = true;
			this.dtpHoraArranque.Size = new System.Drawing.Size(54, 20);
			this.dtpHoraArranque.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(215, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 145;
			this.label1.Text = "Operador:";
			// 
			// btnProgramar
			// 
			this.btnProgramar.Enabled = false;
			this.btnProgramar.Image = ((System.Drawing.Image)(resources.GetObject("btnProgramar.Image")));
			this.btnProgramar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnProgramar.Location = new System.Drawing.Point(460, 46);
			this.btnProgramar.Name = "btnProgramar";
			this.btnProgramar.Size = new System.Drawing.Size(89, 31);
			this.btnProgramar.TabIndex = 11;
			this.btnProgramar.Text = "Programar";
			this.btnProgramar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProgramar.UseVisualStyleBackColor = true;
			this.btnProgramar.Click += new System.EventHandler(this.BtnProgramarClick);
			// 
			// lblUnidadA
			// 
			this.lblUnidadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUnidadA.Location = new System.Drawing.Point(521, 118);
			this.lblUnidadA.Name = "lblUnidadA";
			this.lblUnidadA.Size = new System.Drawing.Size(28, 18);
			this.lblUnidadA.TabIndex = 143;
			this.lblUnidadA.Text = "10";
			this.lblUnidadA.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(395, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Unidades Aprox.:";
			this.label2.Visible = false;
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Enabled = false;
			this.txtUsuario.Location = new System.Drawing.Point(171, 116);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(40, 20);
			this.txtUsuario.TabIndex = 7;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblUsuarios
			// 
			this.lblUsuarios.Location = new System.Drawing.Point(121, 119);
			this.lblUsuarios.Name = "lblUsuarios";
			this.lblUsuarios.Size = new System.Drawing.Size(62, 17);
			this.lblUsuarios.TabIndex = 140;
			this.lblUsuarios.Text = "Usuarios: ";
			// 
			// lblInicio
			// 
			this.lblInicio.Location = new System.Drawing.Point(13, 117);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(65, 18);
			this.lblInicio.TabIndex = 139;
			this.lblInicio.Text = "Arranque:";
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEmpresa.Enabled = false;
			this.txtEmpresa.Location = new System.Drawing.Point(65, 88);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(146, 20);
			this.txtEmpresa.TabIndex = 3;
			this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSentido
			// 
			this.txtSentido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSentido.Enabled = false;
			this.txtSentido.Location = new System.Drawing.Point(428, 91);
			this.txtSentido.Name = "txtSentido";
			this.txtSentido.Size = new System.Drawing.Size(121, 20);
			this.txtSentido.TabIndex = 5;
			this.txtSentido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRuta
			// 
			this.txtRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRuta.Enabled = false;
			this.txtRuta.Location = new System.Drawing.Point(268, 88);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(112, 20);
			this.txtRuta.TabIndex = 4;
			this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblRuta
			// 
			this.lblRuta.Location = new System.Drawing.Point(230, 93);
			this.lblRuta.Name = "lblRuta";
			this.lblRuta.Size = new System.Drawing.Size(65, 18);
			this.lblRuta.TabIndex = 136;
			this.lblRuta.Text = "Ruta:";
			// 
			// lblSentido
			// 
			this.lblSentido.Location = new System.Drawing.Point(385, 94);
			this.lblSentido.Name = "lblSentido";
			this.lblSentido.Size = new System.Drawing.Size(51, 23);
			this.lblSentido.TabIndex = 135;
			this.lblSentido.Text = "Sentido:";
			// 
			// lblTipounidad
			// 
			this.lblTipounidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipounidad.Location = new System.Drawing.Point(220, 118);
			this.lblTipounidad.Name = "lblTipounidad";
			this.lblTipounidad.Size = new System.Drawing.Size(44, 18);
			this.lblTipounidad.TabIndex = 134;
			this.lblTipounidad.Text = "Unidad:";
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.Location = new System.Drawing.Point(13, 89);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(65, 23);
			this.lblEmpresa.TabIndex = 133;
			this.lblEmpresa.Text = "Empresa: ";
			// 
			// cbMotivo
			// 
			this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMotivo.FormattingEnabled = true;
			this.cbMotivo.Items.AddRange(new object[] {
									"DORMIDA",
									"FALTA UNIDADES",
									"FALLA MECÁNICA",
									"CHOQUE",
									"TRAFICO",
									"USUARIO NO ABORDÓ"});
			this.cbMotivo.Location = new System.Drawing.Point(65, 53);
			this.cbMotivo.Name = "cbMotivo";
			this.cbMotivo.Size = new System.Drawing.Size(146, 21);
			this.cbMotivo.TabIndex = 1;
			this.cbMotivo.SelectedIndexChanged += new System.EventHandler(this.CbMotivoSelectedIndexChanged);
			// 
			// lblMotivo
			// 
			this.lblMotivo.Location = new System.Drawing.Point(21, 54);
			this.lblMotivo.Name = "lblMotivo";
			this.lblMotivo.Size = new System.Drawing.Size(44, 23);
			this.lblMotivo.TabIndex = 130;
			this.lblMotivo.Text = "Motivo:";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.lblHoraPlaneacion);
			this.panel2.Controls.Add(this.lblProgramacion);
			this.panel2.Location = new System.Drawing.Point(0, 7);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(567, 35);
			this.panel2.TabIndex = 129;
			// 
			// lblHoraPlaneacion
			// 
			this.lblHoraPlaneacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoraPlaneacion.Location = new System.Drawing.Point(466, 6);
			this.lblHoraPlaneacion.Name = "lblHoraPlaneacion";
			this.lblHoraPlaneacion.Size = new System.Drawing.Size(77, 23);
			this.lblHoraPlaneacion.TabIndex = 115;
			this.lblHoraPlaneacion.Text = "00:00";
			this.lblHoraPlaneacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblProgramacion
			// 
			this.lblProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblProgramacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProgramacion.Location = new System.Drawing.Point(166, 5);
			this.lblProgramacion.Name = "lblProgramacion";
			this.lblProgramacion.Size = new System.Drawing.Size(236, 23);
			this.lblProgramacion.TabIndex = 0;
			this.lblProgramacion.Text = "Programación de Servicio";
			this.lblProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbPedidos
			// 
			this.gbPedidos.Controls.Add(this.txtResponsable);
			this.gbPedidos.Controls.Add(this.dgPedidos);
			this.gbPedidos.Controls.Add(this.btnGuardar);
			this.gbPedidos.Controls.Add(this.cmbTipoUnidad);
			this.gbPedidos.Controls.Add(this.lblTipo);
			this.gbPedidos.Controls.Add(this.btnPedido);
			this.gbPedidos.Controls.Add(this.lblResponsable);
			this.gbPedidos.Location = new System.Drawing.Point(6, 147);
			this.gbPedidos.Name = "gbPedidos";
			this.gbPedidos.Size = new System.Drawing.Size(567, 175);
			this.gbPedidos.TabIndex = 12;
			this.gbPedidos.TabStop = false;
			// 
			// gbUberTaxi
			// 
			this.gbUberTaxi.Controls.Add(this.panel5);
			this.gbUberTaxi.Controls.Add(this.gbPlaneacion);
			this.gbUberTaxi.Controls.Add(this.groupBox10);
			this.gbUberTaxi.Location = new System.Drawing.Point(579, 5);
			this.gbUberTaxi.Name = "gbUberTaxi";
			this.gbUberTaxi.Size = new System.Drawing.Size(349, 319);
			this.gbUberTaxi.TabIndex = 18;
			this.gbUberTaxi.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel5.Controls.Add(this.lblLimpiar);
			this.panel5.Controls.Add(this.pbConfiguraciones);
			this.panel5.Controls.Add(this.lblTitulo);
			this.panel5.Location = new System.Drawing.Point(1, 5);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(343, 35);
			this.panel5.TabIndex = 112;
			// 
			// lblLimpiar
			// 
			this.lblLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("lblLimpiar.Image")));
			this.lblLimpiar.Location = new System.Drawing.Point(261, 3);
			this.lblLimpiar.Name = "lblLimpiar";
			this.lblLimpiar.Size = new System.Drawing.Size(40, 31);
			this.lblLimpiar.TabIndex = 25;
			this.lblLimpiar.Click += new System.EventHandler(this.LblLimpiarClick);
			// 
			// pbConfiguraciones
			// 
			this.pbConfiguraciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pbConfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("pbConfiguraciones.Image")));
			this.pbConfiguraciones.Location = new System.Drawing.Point(307, 2);
			this.pbConfiguraciones.Name = "pbConfiguraciones";
			this.pbConfiguraciones.Size = new System.Drawing.Size(33, 32);
			this.pbConfiguraciones.TabIndex = 109;
			this.pbConfiguraciones.TabStop = false;
			this.pbConfiguraciones.Visible = false;
			this.pbConfiguraciones.Click += new System.EventHandler(this.PbConfiguracionesClick);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(104, 6);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(125, 23);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Ubers / Taxis";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbPlaneacion
			// 
			this.gbPlaneacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbPlaneacion.Controls.Add(this.dgProgramados);
			this.gbPlaneacion.Location = new System.Drawing.Point(5, 85);
			this.gbPlaneacion.Name = "gbPlaneacion";
			this.gbPlaneacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbPlaneacion.Size = new System.Drawing.Size(339, 232);
			this.gbPlaneacion.TabIndex = 23;
			this.gbPlaneacion.TabStop = false;
			this.gbPlaneacion.Text = "Planeación";
			// 
			// dgProgramados
			// 
			this.dgProgramados.AllowUserToAddRows = false;
			this.dgProgramados.AllowUserToDeleteRows = false;
			this.dgProgramados.AllowUserToResizeRows = false;
			this.dgProgramados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgProgramados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgProgramados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgProgramados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_PEDI,
									this.HORA_P,
									this.EMPRESA,
									this.RUTA,
									this.MOTIVO,
									this.OPERADOR,
									this.Estado,
									this.Unidade,
									this.Costo});
			this.dgProgramados.ContextMenuStrip = this.MenuPedidos;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgProgramados.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgProgramados.Location = new System.Drawing.Point(5, 18);
			this.dgProgramados.Margin = new System.Windows.Forms.Padding(2);
			this.dgProgramados.MultiSelect = false;
			this.dgProgramados.Name = "dgProgramados";
			this.dgProgramados.ReadOnly = true;
			this.dgProgramados.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgProgramados.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgProgramados.RowHeadersVisible = false;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgProgramados.RowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dgProgramados.RowTemplate.Height = 24;
			this.dgProgramados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgProgramados.Size = new System.Drawing.Size(329, 206);
			this.dgProgramados.TabIndex = 24;
			this.dgProgramados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProgramadosCellClick);
			// 
			// ID_PEDI
			// 
			this.ID_PEDI.HeaderText = "ID_PEDIDO";
			this.ID_PEDI.Name = "ID_PEDI";
			this.ID_PEDI.ReadOnly = true;
			this.ID_PEDI.Visible = false;
			// 
			// HORA_P
			// 
			this.HORA_P.FillWeight = 50F;
			this.HORA_P.HeaderText = "Arranque";
			this.HORA_P.Name = "HORA_P";
			this.HORA_P.ReadOnly = true;
			this.HORA_P.Width = 80;
			// 
			// EMPRESA
			// 
			this.EMPRESA.HeaderText = "Empresa";
			this.EMPRESA.Name = "EMPRESA";
			this.EMPRESA.ReadOnly = true;
			this.EMPRESA.Width = 84;
			// 
			// RUTA
			// 
			this.RUTA.HeaderText = "Ruta";
			this.RUTA.Name = "RUTA";
			this.RUTA.ReadOnly = true;
			this.RUTA.Width = 80;
			// 
			// MOTIVO
			// 
			this.MOTIVO.HeaderText = "Motivo";
			this.MOTIVO.Name = "MOTIVO";
			this.MOTIVO.ReadOnly = true;
			this.MOTIVO.Width = 74;
			// 
			// OPERADOR
			// 
			this.OPERADOR.HeaderText = "Operador";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 93;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			// 
			// Unidade
			// 
			this.Unidade.HeaderText = "Unidades";
			this.Unidade.Name = "Unidade";
			this.Unidade.ReadOnly = true;
			// 
			// Costo
			// 
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			// 
			// MenuPedidos
			// 
			this.MenuPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cancelarToolStripMenuItem});
			this.MenuPedidos.Name = "MenuPedidos";
			this.MenuPedidos.Size = new System.Drawing.Size(121, 26);
			// 
			// cancelarToolStripMenuItem
			// 
			this.cancelarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarToolStripMenuItem.Image")));
			this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
			this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.cancelarToolStripMenuItem.Text = "Cancelar";
			this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.CancelarToolStripMenuItemClick);
			// 
			// groupBox10
			// 
			this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox10.Controls.Add(this.cbcancelados);
			this.groupBox10.Controls.Add(this.cmbBusqueda);
			this.groupBox10.Controls.Add(this.txtBusqueda);
			this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox10.Location = new System.Drawing.Point(5, 38);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox10.Size = new System.Drawing.Size(339, 46);
			this.groupBox10.TabIndex = 19;
			this.groupBox10.TabStop = false;
			// 
			// cbcancelados
			// 
			this.cbcancelados.Location = new System.Drawing.Point(248, 15);
			this.cbcancelados.Name = "cbcancelados";
			this.cbcancelados.Size = new System.Drawing.Size(85, 24);
			this.cbcancelados.TabIndex = 22;
			this.cbcancelados.Text = "Cancelados";
			this.cbcancelados.UseVisualStyleBackColor = true;
			this.cbcancelados.CheckedChanged += new System.EventHandler(this.CbcanceladosCheckedChanged);
			// 
			// cmbBusqueda
			// 
			this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBusqueda.FormattingEnabled = true;
			this.cmbBusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmbBusqueda.Items.AddRange(new object[] {
									"",
									"Mañana",
									"Medio Día",
									"Vespertino",
									"Nocturno"});
			this.cmbBusqueda.Location = new System.Drawing.Point(6, 17);
			this.cmbBusqueda.Name = "cmbBusqueda";
			this.cmbBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbBusqueda.Size = new System.Drawing.Size(93, 21);
			this.cmbBusqueda.TabIndex = 20;
			this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CmbBusquedaSelectedIndexChanged);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(108, 18);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(111, 20);
			this.txtBusqueda.TabIndex = 21;
			this.txtBusqueda.TextChanged += new System.EventHandler(this.TxtBusquedaTextChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormUber_Taxi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 331);
			this.Controls.Add(this.gbUberTaxi);
			this.Controls.Add(this.gbPedidos);
			this.Controls.Add(this.gbProgramcion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(950, 370);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(950, 370);
			this.Name = "FormUber_Taxi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Uber/Taxis";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GbProgramacionFormClosing);
			this.Load += new System.EventHandler(this.GbProgramacionLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormUber_TaxiKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
			this.gbProgramcion.ResumeLayout(false);
			this.gbProgramcion.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.gbPedidos.ResumeLayout(false);
			this.gbPedidos.PerformLayout();
			this.gbUberTaxi.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).EndInit();
			this.gbPlaneacion.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgProgramados)).EndInit();
			this.MenuPedidos.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblLimpiar;
		private System.Windows.Forms.DataGridViewImageColumn Eliminar;
		private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuPedidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDI;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_CUENTA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDID;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.GroupBox gbUberTaxi;
		public System.Windows.Forms.GroupBox gbPedidos;
		public System.Windows.Forms.GroupBox gbProgramcion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblProgramacion;
		private System.Windows.Forms.Label lblHoraPlaneacion;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblMotivo;
		private System.Windows.Forms.ComboBox cbMotivo;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.Label lblTipounidad;
		private System.Windows.Forms.Label lblSentido;
		private System.Windows.Forms.Label lblRuta;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.TextBox txtSentido;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.Label lblUsuarios;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUnidadA;
		private System.Windows.Forms.Button btnProgramar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpHoraArranque;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.ComboBox cmbTipoUnidad;
		private System.Windows.Forms.Label lblResponsable;
		public System.Windows.Forms.TextBox txtResponsable;
		private System.Windows.Forms.Button btnPedido;
		private System.Windows.Forms.DataGridViewCheckBoxColumn V;
		private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costoa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		public System.Windows.Forms.DataGridView dgPedidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO;
		private System.Windows.Forms.DataGridViewTextBoxColumn RUTA;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA_P;
		public System.Windows.Forms.DataGridView dgProgramados;
		private System.Windows.Forms.GroupBox gbPlaneacion;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox pbConfiguraciones;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.ComboBox cmbBusqueda;
		private System.Windows.Forms.CheckBox cbcancelados;
		private System.Windows.Forms.GroupBox groupBox10;
	}
}
