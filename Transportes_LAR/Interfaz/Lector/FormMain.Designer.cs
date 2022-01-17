/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 14/02/2015
 * Hora: 11:56 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Lector
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tpConfiguracion = new System.Windows.Forms.TabPage();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtReaderSelected = new System.Windows.Forms.TextBox();
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.pbFingerprint = new System.Windows.Forms.PictureBox();
			this.dtConfigUsuario = new System.Windows.Forms.DataGridView();
			this.ID_OP_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HUELLA_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnVerify = new System.Windows.Forms.Button();
			this.btnStreaming = new System.Windows.Forms.Button();
			this.tpHorarios = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNombreCompleto = new System.Windows.Forms.TextBox();
			this.btnNuevo_Horarios = new System.Windows.Forms.Button();
			this.btnEliminar_Horarios = new System.Windows.Forms.Button();
			this.label28 = new System.Windows.Forms.Label();
			this.dgHorarios = new System.Windows.Forms.DataGridView();
			this.ID_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LUNES_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MARTES_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MIERCOLES_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.JUEVES_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VIERNES_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SABADO_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOMINGO_HR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNombre_Horario = new System.Windows.Forms.TextBox();
			this.btnGuardar_Horarios = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbDomingo = new System.Windows.Forms.CheckBox();
			this.cbSabado = new System.Windows.Forms.CheckBox();
			this.cbViernes = new System.Windows.Forms.CheckBox();
			this.cbJueves = new System.Windows.Forms.CheckBox();
			this.cbMiercoles = new System.Windows.Forms.CheckBox();
			this.cbMartes = new System.Windows.Forms.CheckBox();
			this.cbLunes = new System.Windows.Forms.CheckBox();
			this.label25 = new System.Windows.Forms.Label();
			this.dtpLuE = new System.Windows.Forms.DateTimePicker();
			this.label26 = new System.Windows.Forms.Label();
			this.dtpLuS = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpDoS = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpDoE = new System.Windows.Forms.DateTimePicker();
			this.dtpMaE = new System.Windows.Forms.DateTimePicker();
			this.label22 = new System.Windows.Forms.Label();
			this.dtpMaS = new System.Windows.Forms.DateTimePicker();
			this.label23 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dtpSaS = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpSaE = new System.Windows.Forms.DateTimePicker();
			this.dtpMiE = new System.Windows.Forms.DateTimePicker();
			this.label19 = new System.Windows.Forms.Label();
			this.dtpMiS = new System.Windows.Forms.DateTimePicker();
			this.label20 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.dtpViS = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpViE = new System.Windows.Forms.DateTimePicker();
			this.dtpJuE = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.dtpJuS = new System.Windows.Forms.DateTimePicker();
			this.label17 = new System.Windows.Forms.Label();
			this.tpPrincipal = new System.Windows.Forms.TabPage();
			this.cboDispositivos = new System.Windows.Forms.ComboBox();
			this.ptbWebCam = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtContrasena = new System.Windows.Forms.MaskedTextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblContrasena = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lblPeriodo = new System.Windows.Forms.Label();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.txtInicio = new System.Windows.Forms.TextBox();
			this.lblFecha = new System.Windows.Forms.Label();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.dgInicio = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HR_ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RETARDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblHora = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblNombreCompleto = new System.Windows.Forms.Label();
			this.TimeChecador = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.imageChecador = new System.Windows.Forms.ImageList(this.components);
			this.time = new System.Windows.Forms.Timer(this.components);
			this.tchecador = new System.Windows.Forms.ToolStrip();
			this.tlSelect = new System.Windows.Forms.ToolStripLabel();
			this.btnReaderSelect = new System.Windows.Forms.ToolStripButton();
			this.btnReportes = new System.Windows.Forms.ToolStripButton();
			this.txtReaderSelected2 = new System.Windows.Forms.ToolStripTextBox();
			this.ttip = new System.Windows.Forms.ToolTip(this.components);
			this.tpConfiguracion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtConfigUsuario)).BeginInit();
			this.tpHorarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).BeginInit();
			this.panel1.SuspendLayout();
			this.tpPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbWebCam)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInicio)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tchecador.SuspendLayout();
			this.SuspendLayout();
			// 
			// tpConfiguracion
			// 
			this.tpConfiguracion.Controls.Add(this.txtNombre);
			this.tpConfiguracion.Controls.Add(this.txtReaderSelected);
			this.tpConfiguracion.Controls.Add(this.txtMensaje);
			this.tpConfiguracion.Controls.Add(this.btnGuardar);
			this.tpConfiguracion.Controls.Add(this.lbl2);
			this.tpConfiguracion.Controls.Add(this.lbl1);
			this.tpConfiguracion.Controls.Add(this.pbFingerprint);
			this.tpConfiguracion.Controls.Add(this.dtConfigUsuario);
			this.tpConfiguracion.Controls.Add(this.btnVerify);
			this.tpConfiguracion.Controls.Add(this.btnStreaming);
			this.tpConfiguracion.Location = new System.Drawing.Point(4, 28);
			this.tpConfiguracion.Name = "tpConfiguracion";
			this.tpConfiguracion.Padding = new System.Windows.Forms.Padding(3);
			this.tpConfiguracion.Size = new System.Drawing.Size(1099, 614);
			this.tpConfiguracion.TabIndex = 1;
			this.tpConfiguracion.Text = "Configuración de Huella";
			this.tpConfiguracion.UseVisualStyleBackColor = true;
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(321, 215);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(258, 21);
			this.txtNombre.TabIndex = 12;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtReaderSelected
			// 
			this.txtReaderSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtReaderSelected.Enabled = false;
			this.txtReaderSelected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReaderSelected.Location = new System.Drawing.Point(321, 474);
			this.txtReaderSelected.Name = "txtReaderSelected";
			this.txtReaderSelected.Size = new System.Drawing.Size(258, 21);
			this.txtReaderSelected.TabIndex = 11;
			this.txtReaderSelected.Visible = false;
			this.txtReaderSelected.TextChanged += new System.EventHandler(this.TxtReaderSelectedTextChanged);
			// 
			// txtMensaje
			// 
			this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.txtMensaje.Enabled = false;
			this.txtMensaje.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensaje.Location = new System.Drawing.Point(321, 241);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(258, 227);
			this.txtMensaje.TabIndex = 10;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
			this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar.Location = new System.Drawing.Point(510, 538);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(69, 58);
			this.btnGuardar.TabIndex = 9;
			this.ttip.SetToolTip(this.btnGuardar, "Guardar");
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// lbl2
			// 
			this.lbl2.BackColor = System.Drawing.Color.Transparent;
			this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl2.Location = new System.Drawing.Point(457, 183);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(34, 28);
			this.lbl2.TabIndex = 7;
			// 
			// lbl1
			// 
			this.lbl1.BackColor = System.Drawing.Color.Transparent;
			this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl1.Location = new System.Drawing.Point(417, 183);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(34, 28);
			this.lbl1.TabIndex = 6;
			// 
			// pbFingerprint
			// 
			this.pbFingerprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFingerprint.BackgroundImage")));
			this.pbFingerprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbFingerprint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbFingerprint.Location = new System.Drawing.Point(376, 15);
			this.pbFingerprint.Name = "pbFingerprint";
			this.pbFingerprint.Size = new System.Drawing.Size(156, 165);
			this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbFingerprint.TabIndex = 5;
			this.pbFingerprint.TabStop = false;
			// 
			// dtConfigUsuario
			// 
			this.dtConfigUsuario.AllowUserToAddRows = false;
			this.dtConfigUsuario.AllowUserToResizeRows = false;
			this.dtConfigUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dtConfigUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtConfigUsuario.BackgroundColor = System.Drawing.Color.White;
			this.dtConfigUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtConfigUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_OP_C,
									this.USUARIO_C,
									this.HUELLA_C});
			this.dtConfigUsuario.Location = new System.Drawing.Point(17, 15);
			this.dtConfigUsuario.MultiSelect = false;
			this.dtConfigUsuario.Name = "dtConfigUsuario";
			this.dtConfigUsuario.RowHeadersVisible = false;
			this.dtConfigUsuario.Size = new System.Drawing.Size(279, 580);
			this.dtConfigUsuario.TabIndex = 4;
			this.dtConfigUsuario.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtConfigUsuarioCellEnter);
			// 
			// ID_OP_C
			// 
			this.ID_OP_C.HeaderText = "ID";
			this.ID_OP_C.Name = "ID_OP_C";
			this.ID_OP_C.ReadOnly = true;
			this.ID_OP_C.Visible = false;
			// 
			// USUARIO_C
			// 
			this.USUARIO_C.FillWeight = 162.4366F;
			this.USUARIO_C.HeaderText = "Usuario";
			this.USUARIO_C.MinimumWidth = 120;
			this.USUARIO_C.Name = "USUARIO_C";
			this.USUARIO_C.ReadOnly = true;
			// 
			// HUELLA_C
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.HUELLA_C.DefaultCellStyle = dataGridViewCellStyle1;
			this.HUELLA_C.FillWeight = 37.56345F;
			this.HUELLA_C.HeaderText = "Reg.";
			this.HUELLA_C.Name = "HUELLA_C";
			this.HUELLA_C.ReadOnly = true;
			this.HUELLA_C.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// btnVerify
			// 
			this.btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnVerify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerify.BackgroundImage")));
			this.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerify.Location = new System.Drawing.Point(438, 538);
			this.btnVerify.Name = "btnVerify";
			this.btnVerify.Size = new System.Drawing.Size(66, 57);
			this.btnVerify.TabIndex = 3;
			this.ttip.SetToolTip(this.btnVerify, "Verificar Huella");
			this.btnVerify.UseVisualStyleBackColor = true;
			this.btnVerify.Click += new System.EventHandler(this.BtnVerifyClick);
			// 
			// btnStreaming
			// 
			this.btnStreaming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStreaming.Enabled = false;
			this.btnStreaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStreaming.Location = new System.Drawing.Point(321, 502);
			this.btnStreaming.Name = "btnStreaming";
			this.btnStreaming.Size = new System.Drawing.Size(260, 23);
			this.btnStreaming.TabIndex = 1;
			this.btnStreaming.Text = "Lectura en Streaming";
			this.btnStreaming.UseVisualStyleBackColor = true;
			this.btnStreaming.Visible = false;
			this.btnStreaming.Click += new System.EventHandler(this.BtnStreamingClick);
			// 
			// tpHorarios
			// 
			this.tpHorarios.Controls.Add(this.label7);
			this.tpHorarios.Controls.Add(this.txtNombreCompleto);
			this.tpHorarios.Controls.Add(this.btnNuevo_Horarios);
			this.tpHorarios.Controls.Add(this.btnEliminar_Horarios);
			this.tpHorarios.Controls.Add(this.label28);
			this.tpHorarios.Controls.Add(this.dgHorarios);
			this.tpHorarios.Controls.Add(this.txtNombre_Horario);
			this.tpHorarios.Controls.Add(this.btnGuardar_Horarios);
			this.tpHorarios.Controls.Add(this.panel1);
			this.tpHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpHorarios.Location = new System.Drawing.Point(4, 28);
			this.tpHorarios.Name = "tpHorarios";
			this.tpHorarios.Size = new System.Drawing.Size(1099, 614);
			this.tpHorarios.TabIndex = 3;
			this.tpHorarios.Text = "Configuración de Horarios";
			this.tpHorarios.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(259, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 23);
			this.label7.TabIndex = 47;
			this.label7.Text = "NOMBRE:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombreCompleto
			// 
			this.txtNombreCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombreCompleto.Enabled = false;
			this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCompleto.Location = new System.Drawing.Point(348, 12);
			this.txtNombreCompleto.Name = "txtNombreCompleto";
			this.txtNombreCompleto.Size = new System.Drawing.Size(596, 26);
			this.txtNombreCompleto.TabIndex = 46;
			// 
			// btnNuevo_Horarios
			// 
			this.btnNuevo_Horarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevo_Horarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo_Horarios.BackgroundImage")));
			this.btnNuevo_Horarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNuevo_Horarios.Location = new System.Drawing.Point(934, 567);
			this.btnNuevo_Horarios.Name = "btnNuevo_Horarios";
			this.btnNuevo_Horarios.Size = new System.Drawing.Size(45, 42);
			this.btnNuevo_Horarios.TabIndex = 45;
			this.ttip.SetToolTip(this.btnNuevo_Horarios, "Nuevo");
			this.btnNuevo_Horarios.UseVisualStyleBackColor = true;
			this.btnNuevo_Horarios.Click += new System.EventHandler(this.BtnNuevo_HorariosClick);
			// 
			// btnEliminar_Horarios
			// 
			this.btnEliminar_Horarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar_Horarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar_Horarios.BackgroundImage")));
			this.btnEliminar_Horarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEliminar_Horarios.Location = new System.Drawing.Point(1036, 566);
			this.btnEliminar_Horarios.Name = "btnEliminar_Horarios";
			this.btnEliminar_Horarios.Size = new System.Drawing.Size(46, 42);
			this.btnEliminar_Horarios.TabIndex = 44;
			this.ttip.SetToolTip(this.btnEliminar_Horarios, "Eliminar");
			this.btnEliminar_Horarios.UseVisualStyleBackColor = true;
			this.btnEliminar_Horarios.Click += new System.EventHandler(this.BtnEliminar_HorariosClick);
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(13, 12);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(83, 23);
			this.label28.TabIndex = 43;
			this.label28.Text = "USUARIO:";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgHorarios
			// 
			this.dgHorarios.AllowUserToAddRows = false;
			this.dgHorarios.AllowUserToResizeRows = false;
			this.dgHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgHorarios.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_H,
									this.NOMBRE_HR,
									this.NOMBRE_H,
									this.ID_HORARIO,
									this.LUNES_HR,
									this.MARTES_HR,
									this.MIERCOLES_HR,
									this.JUEVES_HR,
									this.VIERNES_HR,
									this.SABADO_HR,
									this.DOMINGO_HR});
			this.dgHorarios.Location = new System.Drawing.Point(13, 123);
			this.dgHorarios.MultiSelect = false;
			this.dgHorarios.Name = "dgHorarios";
			this.dgHorarios.RowHeadersVisible = false;
			this.dgHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgHorarios.Size = new System.Drawing.Size(1069, 437);
			this.dgHorarios.TabIndex = 42;
			this.dgHorarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgHorariosCellClick);
			// 
			// ID_H
			// 
			this.ID_H.HeaderText = "ID_U";
			this.ID_H.Name = "ID_H";
			this.ID_H.ReadOnly = true;
			this.ID_H.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ID_H.Visible = false;
			this.ID_H.Width = 80;
			// 
			// NOMBRE_HR
			// 
			this.NOMBRE_HR.HeaderText = "USUARIO";
			this.NOMBRE_HR.Name = "NOMBRE_HR";
			this.NOMBRE_HR.ReadOnly = true;
			this.NOMBRE_HR.Width = 120;
			// 
			// NOMBRE_H
			// 
			this.NOMBRE_H.HeaderText = "NOMBRE";
			this.NOMBRE_H.Name = "NOMBRE_H";
			this.NOMBRE_H.ReadOnly = true;
			this.NOMBRE_H.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NOMBRE_H.Width = 350;
			// 
			// ID_HORARIO
			// 
			this.ID_HORARIO.HeaderText = "ID_H";
			this.ID_HORARIO.Name = "ID_HORARIO";
			this.ID_HORARIO.ReadOnly = true;
			this.ID_HORARIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ID_HORARIO.Visible = false;
			// 
			// LUNES_HR
			// 
			this.LUNES_HR.HeaderText = "LUNES";
			this.LUNES_HR.Name = "LUNES_HR";
			this.LUNES_HR.ReadOnly = true;
			this.LUNES_HR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// MARTES_HR
			// 
			this.MARTES_HR.HeaderText = "MARTES";
			this.MARTES_HR.Name = "MARTES_HR";
			this.MARTES_HR.ReadOnly = true;
			this.MARTES_HR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// MIERCOLES_HR
			// 
			this.MIERCOLES_HR.HeaderText = "MIERCOLES";
			this.MIERCOLES_HR.Name = "MIERCOLES_HR";
			this.MIERCOLES_HR.ReadOnly = true;
			this.MIERCOLES_HR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// JUEVES_HR
			// 
			this.JUEVES_HR.HeaderText = "JUEVES";
			this.JUEVES_HR.Name = "JUEVES_HR";
			this.JUEVES_HR.ReadOnly = true;
			this.JUEVES_HR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// VIERNES_HR
			// 
			this.VIERNES_HR.HeaderText = "VIERNES";
			this.VIERNES_HR.Name = "VIERNES_HR";
			this.VIERNES_HR.ReadOnly = true;
			this.VIERNES_HR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// SABADO_HR
			// 
			this.SABADO_HR.HeaderText = "SABADO";
			this.SABADO_HR.Name = "SABADO_HR";
			this.SABADO_HR.ReadOnly = true;
			this.SABADO_HR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// DOMINGO_HR
			// 
			this.DOMINGO_HR.HeaderText = "DOMINGO";
			this.DOMINGO_HR.Name = "DOMINGO_HR";
			this.DOMINGO_HR.ReadOnly = true;
			this.DOMINGO_HR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// txtNombre_Horario
			// 
			this.txtNombre_Horario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre_Horario.Location = new System.Drawing.Point(102, 12);
			this.txtNombre_Horario.Name = "txtNombre_Horario";
			this.txtNombre_Horario.Size = new System.Drawing.Size(142, 26);
			this.txtNombre_Horario.TabIndex = 41;
			this.txtNombre_Horario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombre_HorarioKeyUp);
			// 
			// btnGuardar_Horarios
			// 
			this.btnGuardar_Horarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar_Horarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar_Horarios.BackgroundImage")));
			this.btnGuardar_Horarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar_Horarios.Location = new System.Drawing.Point(985, 567);
			this.btnGuardar_Horarios.Name = "btnGuardar_Horarios";
			this.btnGuardar_Horarios.Size = new System.Drawing.Size(45, 42);
			this.btnGuardar_Horarios.TabIndex = 40;
			this.ttip.SetToolTip(this.btnGuardar_Horarios, "Guardar");
			this.btnGuardar_Horarios.UseVisualStyleBackColor = true;
			this.btnGuardar_Horarios.Click += new System.EventHandler(this.BtnGuardar_HorariosClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.cbDomingo);
			this.panel1.Controls.Add(this.cbSabado);
			this.panel1.Controls.Add(this.cbViernes);
			this.panel1.Controls.Add(this.cbJueves);
			this.panel1.Controls.Add(this.cbMiercoles);
			this.panel1.Controls.Add(this.cbMartes);
			this.panel1.Controls.Add(this.cbLunes);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Controls.Add(this.dtpLuE);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.dtpLuS);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dtpDoS);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.dtpDoE);
			this.panel1.Controls.Add(this.dtpMaE);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.dtpMaS);
			this.panel1.Controls.Add(this.label23);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.dtpSaS);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.dtpSaE);
			this.panel1.Controls.Add(this.dtpMiE);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.dtpMiS);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.dtpViS);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.dtpViE);
			this.panel1.Controls.Add(this.dtpJuE);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.dtpJuS);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Location = new System.Drawing.Point(15, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1067, 72);
			this.panel1.TabIndex = 39;
			// 
			// cbDomingo
			// 
			this.cbDomingo.BackColor = System.Drawing.Color.Silver;
			this.cbDomingo.Location = new System.Drawing.Point(795, 3);
			this.cbDomingo.Name = "cbDomingo";
			this.cbDomingo.Size = new System.Drawing.Size(126, 24);
			this.cbDomingo.TabIndex = 42;
			this.cbDomingo.Text = "Domingo";
			this.cbDomingo.UseVisualStyleBackColor = false;
			this.cbDomingo.CheckedChanged += new System.EventHandler(this.CbDomingoCheckedChanged);
			// 
			// cbSabado
			// 
			this.cbSabado.BackColor = System.Drawing.Color.Silver;
			this.cbSabado.Location = new System.Drawing.Point(663, 3);
			this.cbSabado.Name = "cbSabado";
			this.cbSabado.Size = new System.Drawing.Size(126, 24);
			this.cbSabado.TabIndex = 41;
			this.cbSabado.Text = "Sábado";
			this.cbSabado.UseVisualStyleBackColor = false;
			this.cbSabado.CheckedChanged += new System.EventHandler(this.CbSabadoCheckedChanged);
			// 
			// cbViernes
			// 
			this.cbViernes.BackColor = System.Drawing.Color.Silver;
			this.cbViernes.Location = new System.Drawing.Point(531, 3);
			this.cbViernes.Name = "cbViernes";
			this.cbViernes.Size = new System.Drawing.Size(126, 24);
			this.cbViernes.TabIndex = 40;
			this.cbViernes.Text = "Viernes";
			this.cbViernes.UseVisualStyleBackColor = false;
			this.cbViernes.CheckedChanged += new System.EventHandler(this.CbViernesCheckedChanged);
			// 
			// cbJueves
			// 
			this.cbJueves.BackColor = System.Drawing.Color.Silver;
			this.cbJueves.Location = new System.Drawing.Point(399, 3);
			this.cbJueves.Name = "cbJueves";
			this.cbJueves.Size = new System.Drawing.Size(126, 24);
			this.cbJueves.TabIndex = 39;
			this.cbJueves.Text = "Jueves";
			this.cbJueves.UseVisualStyleBackColor = false;
			this.cbJueves.CheckedChanged += new System.EventHandler(this.CbJuevesCheckedChanged);
			// 
			// cbMiercoles
			// 
			this.cbMiercoles.BackColor = System.Drawing.Color.Silver;
			this.cbMiercoles.Location = new System.Drawing.Point(267, 3);
			this.cbMiercoles.Name = "cbMiercoles";
			this.cbMiercoles.Size = new System.Drawing.Size(126, 24);
			this.cbMiercoles.TabIndex = 38;
			this.cbMiercoles.Text = "Miércoles";
			this.cbMiercoles.UseVisualStyleBackColor = false;
			this.cbMiercoles.CheckedChanged += new System.EventHandler(this.CbMiercolesCheckedChanged);
			// 
			// cbMartes
			// 
			this.cbMartes.BackColor = System.Drawing.Color.Silver;
			this.cbMartes.Location = new System.Drawing.Point(135, 3);
			this.cbMartes.Name = "cbMartes";
			this.cbMartes.Size = new System.Drawing.Size(126, 24);
			this.cbMartes.TabIndex = 37;
			this.cbMartes.Text = "Martes";
			this.cbMartes.UseVisualStyleBackColor = false;
			this.cbMartes.CheckedChanged += new System.EventHandler(this.CbMartesCheckedChanged);
			// 
			// cbLunes
			// 
			this.cbLunes.BackColor = System.Drawing.Color.Silver;
			this.cbLunes.Location = new System.Drawing.Point(3, 3);
			this.cbLunes.Name = "cbLunes";
			this.cbLunes.Size = new System.Drawing.Size(126, 24);
			this.cbLunes.TabIndex = 36;
			this.cbLunes.Text = "Lunes";
			this.cbLunes.UseVisualStyleBackColor = false;
			this.cbLunes.CheckedChanged += new System.EventHandler(this.CbLunesCheckedChanged);
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(861, 30);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(60, 16);
			this.label25.TabIndex = 35;
			this.label25.Text = "SAL";
			this.label25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpLuE
			// 
			this.dtpLuE.CustomFormat = "HH:mm";
			this.dtpLuE.Enabled = false;
			this.dtpLuE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpLuE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpLuE.Location = new System.Drawing.Point(3, 46);
			this.dtpLuE.Name = "dtpLuE";
			this.dtpLuE.ShowUpDown = true;
			this.dtpLuE.Size = new System.Drawing.Size(60, 22);
			this.dtpLuE.TabIndex = 1;
			this.dtpLuE.ValueChanged += new System.EventHandler(this.DtpLuEValueChanged);
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Location = new System.Drawing.Point(795, 30);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(60, 16);
			this.label26.TabIndex = 34;
			this.label26.Text = "ENT";
			this.label26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpLuS
			// 
			this.dtpLuS.CustomFormat = "HH:mm";
			this.dtpLuS.Enabled = false;
			this.dtpLuS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpLuS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpLuS.Location = new System.Drawing.Point(69, 46);
			this.dtpLuS.Name = "dtpLuS";
			this.dtpLuS.ShowUpDown = true;
			this.dtpLuS.Size = new System.Drawing.Size(60, 22);
			this.dtpLuS.TabIndex = 2;
			this.dtpLuS.ValueChanged += new System.EventHandler(this.DtpLuSValueChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(3, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "ENT";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpDoS
			// 
			this.dtpDoS.CustomFormat = "HH:mm";
			this.dtpDoS.Enabled = false;
			this.dtpDoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDoS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDoS.Location = new System.Drawing.Point(861, 46);
			this.dtpDoS.Name = "dtpDoS";
			this.dtpDoS.ShowUpDown = true;
			this.dtpDoS.Size = new System.Drawing.Size(60, 22);
			this.dtpDoS.TabIndex = 32;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(69, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 16);
			this.label9.TabIndex = 5;
			this.label9.Text = "SAL";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpDoE
			// 
			this.dtpDoE.CustomFormat = "HH:mm";
			this.dtpDoE.Enabled = false;
			this.dtpDoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDoE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDoE.Location = new System.Drawing.Point(795, 46);
			this.dtpDoE.Name = "dtpDoE";
			this.dtpDoE.ShowUpDown = true;
			this.dtpDoE.Size = new System.Drawing.Size(60, 22);
			this.dtpDoE.TabIndex = 31;
			// 
			// dtpMaE
			// 
			this.dtpMaE.CustomFormat = "HH:mm";
			this.dtpMaE.Enabled = false;
			this.dtpMaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMaE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMaE.Location = new System.Drawing.Point(135, 46);
			this.dtpMaE.Name = "dtpMaE";
			this.dtpMaE.ShowUpDown = true;
			this.dtpMaE.Size = new System.Drawing.Size(60, 22);
			this.dtpMaE.TabIndex = 6;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(729, 30);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(60, 16);
			this.label22.TabIndex = 30;
			this.label22.Text = "SAL";
			this.label22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpMaS
			// 
			this.dtpMaS.CustomFormat = "HH:mm";
			this.dtpMaS.Enabled = false;
			this.dtpMaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMaS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMaS.Location = new System.Drawing.Point(201, 46);
			this.dtpMaS.Name = "dtpMaS";
			this.dtpMaS.ShowUpDown = true;
			this.dtpMaS.Size = new System.Drawing.Size(60, 22);
			this.dtpMaS.TabIndex = 7;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Location = new System.Drawing.Point(663, 30);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(60, 16);
			this.label23.TabIndex = 29;
			this.label23.Text = "ENT";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(135, 30);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 16);
			this.label11.TabIndex = 9;
			this.label11.Text = "ENT";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpSaS
			// 
			this.dtpSaS.CustomFormat = "HH:mm";
			this.dtpSaS.Enabled = false;
			this.dtpSaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpSaS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSaS.Location = new System.Drawing.Point(729, 46);
			this.dtpSaS.Name = "dtpSaS";
			this.dtpSaS.ShowUpDown = true;
			this.dtpSaS.Size = new System.Drawing.Size(60, 22);
			this.dtpSaS.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(201, 30);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 16);
			this.label10.TabIndex = 10;
			this.label10.Text = "SAL";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpSaE
			// 
			this.dtpSaE.CustomFormat = "HH:mm";
			this.dtpSaE.Enabled = false;
			this.dtpSaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpSaE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSaE.Location = new System.Drawing.Point(663, 46);
			this.dtpSaE.Name = "dtpSaE";
			this.dtpSaE.ShowUpDown = true;
			this.dtpSaE.Size = new System.Drawing.Size(60, 22);
			this.dtpSaE.TabIndex = 26;
			// 
			// dtpMiE
			// 
			this.dtpMiE.CustomFormat = "HH:mm";
			this.dtpMiE.Enabled = false;
			this.dtpMiE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMiE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMiE.Location = new System.Drawing.Point(267, 46);
			this.dtpMiE.Name = "dtpMiE";
			this.dtpMiE.ShowUpDown = true;
			this.dtpMiE.Size = new System.Drawing.Size(60, 22);
			this.dtpMiE.TabIndex = 11;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(597, 30);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(60, 16);
			this.label19.TabIndex = 25;
			this.label19.Text = "SAL";
			this.label19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpMiS
			// 
			this.dtpMiS.CustomFormat = "HH:mm";
			this.dtpMiS.Enabled = false;
			this.dtpMiS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMiS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMiS.Location = new System.Drawing.Point(333, 46);
			this.dtpMiS.Name = "dtpMiS";
			this.dtpMiS.ShowUpDown = true;
			this.dtpMiS.Size = new System.Drawing.Size(60, 22);
			this.dtpMiS.TabIndex = 12;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(531, 30);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(60, 16);
			this.label20.TabIndex = 24;
			this.label20.Text = "ENT";
			this.label20.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(267, 30);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 16);
			this.label14.TabIndex = 14;
			this.label14.Text = "ENT";
			this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpViS
			// 
			this.dtpViS.CustomFormat = "HH:mm";
			this.dtpViS.Enabled = false;
			this.dtpViS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpViS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpViS.Location = new System.Drawing.Point(597, 46);
			this.dtpViS.Name = "dtpViS";
			this.dtpViS.ShowUpDown = true;
			this.dtpViS.Size = new System.Drawing.Size(60, 22);
			this.dtpViS.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(333, 30);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 16);
			this.label13.TabIndex = 15;
			this.label13.Text = "SAL";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpViE
			// 
			this.dtpViE.CustomFormat = "HH:mm";
			this.dtpViE.Enabled = false;
			this.dtpViE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpViE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpViE.Location = new System.Drawing.Point(531, 46);
			this.dtpViE.Name = "dtpViE";
			this.dtpViE.ShowUpDown = true;
			this.dtpViE.Size = new System.Drawing.Size(60, 22);
			this.dtpViE.TabIndex = 21;
			// 
			// dtpJuE
			// 
			this.dtpJuE.CustomFormat = "HH:mm";
			this.dtpJuE.Enabled = false;
			this.dtpJuE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpJuE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpJuE.Location = new System.Drawing.Point(399, 46);
			this.dtpJuE.Name = "dtpJuE";
			this.dtpJuE.ShowUpDown = true;
			this.dtpJuE.Size = new System.Drawing.Size(60, 22);
			this.dtpJuE.TabIndex = 16;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(465, 30);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 16);
			this.label16.TabIndex = 20;
			this.label16.Text = "SAL";
			this.label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// dtpJuS
			// 
			this.dtpJuS.CustomFormat = "HH:mm";
			this.dtpJuS.Enabled = false;
			this.dtpJuS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpJuS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpJuS.Location = new System.Drawing.Point(465, 46);
			this.dtpJuS.Name = "dtpJuS";
			this.dtpJuS.ShowUpDown = true;
			this.dtpJuS.Size = new System.Drawing.Size(60, 22);
			this.dtpJuS.TabIndex = 17;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(399, 30);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(60, 16);
			this.label17.TabIndex = 19;
			this.label17.Text = "ENT";
			this.label17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// tpPrincipal
			// 
			this.tpPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tpPrincipal.Controls.Add(this.cboDispositivos);
			this.tpPrincipal.Controls.Add(this.ptbWebCam);
			this.tpPrincipal.Controls.Add(this.groupBox2);
			this.tpPrincipal.Controls.Add(this.label2);
			this.tpPrincipal.Controls.Add(this.groupBox5);
			this.tpPrincipal.Controls.Add(this.txtInicio);
			this.tpPrincipal.Controls.Add(this.lblFecha);
			this.tpPrincipal.Controls.Add(this.ptbImagen);
			this.tpPrincipal.Controls.Add(this.dgInicio);
			this.tpPrincipal.Controls.Add(this.groupBox1);
			this.tpPrincipal.Controls.Add(this.TimeChecador);
			this.tpPrincipal.Controls.Add(this.menuStrip1);
			this.tpPrincipal.Location = new System.Drawing.Point(4, 28);
			this.tpPrincipal.Name = "tpPrincipal";
			this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
			this.tpPrincipal.Size = new System.Drawing.Size(1099, 614);
			this.tpPrincipal.TabIndex = 0;
			this.tpPrincipal.Text = "Inicio";
			// 
			// cboDispositivos
			// 
			this.cboDispositivos.FormattingEnabled = true;
			this.cboDispositivos.Location = new System.Drawing.Point(744, 8);
			this.cboDispositivos.Name = "cboDispositivos";
			this.cboDispositivos.Size = new System.Drawing.Size(217, 27);
			this.cboDispositivos.TabIndex = 7;
			// 
			// ptbWebCam
			// 
			this.ptbWebCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ptbWebCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ptbWebCam.Image = ((System.Drawing.Image)(resources.GetObject("ptbWebCam.Image")));
			this.ptbWebCam.Location = new System.Drawing.Point(194, 51);
			this.ptbWebCam.Name = "ptbWebCam";
			this.ptbWebCam.Size = new System.Drawing.Size(102, 66);
			this.ptbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbWebCam.TabIndex = 169;
			this.ptbWebCam.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtContrasena);
			this.groupBox2.Controls.Add(this.lblUsuario);
			this.groupBox2.Controls.Add(this.btnAceptar);
			this.groupBox2.Controls.Add(this.txtUsuario);
			this.groupBox2.Controls.Add(this.lblContrasena);
			this.groupBox2.Location = new System.Drawing.Point(188, 122);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(278, 142);
			this.groupBox2.TabIndex = 168;
			this.groupBox2.TabStop = false;
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(16, 76);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '$';
			this.txtContrasena.Size = new System.Drawing.Size(247, 26);
			this.txtContrasena.TabIndex = 1;
			this.txtContrasena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtContrasenaKeyUp);
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(16, 13);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(60, 16);
			this.lblUsuario.TabIndex = 1;
			this.lblUsuario.Text = "Usuario:";
			this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(168, 105);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(95, 30);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(16, 32);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(247, 22);
			this.txtUsuario.TabIndex = 0;
			// 
			// lblContrasena
			// 
			this.lblContrasena.AutoSize = true;
			this.lblContrasena.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContrasena.Location = new System.Drawing.Point(16, 57);
			this.lblContrasena.Name = "lblContrasena";
			this.lblContrasena.Size = new System.Drawing.Size(84, 16);
			this.lblContrasena.TabIndex = 165;
			this.lblContrasena.Text = "Contraseña:";
			this.lblContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.BackColor = System.Drawing.Color.Red;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 540);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(451, 65);
			this.label2.TabIndex = 166;
			this.label2.Text = "Nota: Si el Lector de huella no detecta tu dedo, favor de cerrar la ventana, desc" +
			"onectar el lector de huella y volverlo a conectar!!!";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox5.Controls.Add(this.lblPeriodo);
			this.groupBox5.Controls.Add(this.lblFechaCorte);
			this.groupBox5.Controls.Add(this.dtInicio);
			this.groupBox5.Controls.Add(this.dtCorte);
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(484, 1);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(254, 44);
			this.groupBox5.TabIndex = 163;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Fecha para reporte de Excel";
			// 
			// lblPeriodo
			// 
			this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
			this.lblPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeriodo.Location = new System.Drawing.Point(30, 20);
			this.lblPeriodo.Name = "lblPeriodo";
			this.lblPeriodo.Size = new System.Drawing.Size(43, 22);
			this.lblPeriodo.TabIndex = 135;
			this.lblPeriodo.Text = "Periodo";
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(156, 18);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(11, 22);
			this.lblFechaCorte.TabIndex = 136;
			this.lblFechaCorte.Text = "-";
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(80, 17);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(75, 20);
			this.dtInicio.TabIndex = 137;
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(168, 17);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(76, 20);
			this.dtCorte.TabIndex = 138;
			// 
			// txtInicio
			// 
			this.txtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.txtInicio.Enabled = false;
			this.txtInicio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInicio.Location = new System.Drawing.Point(17, 355);
			this.txtInicio.Multiline = true;
			this.txtInicio.Name = "txtInicio";
			this.txtInicio.Size = new System.Drawing.Size(450, 175);
			this.txtInicio.TabIndex = 11;
			this.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblFecha
			// 
			this.lblFecha.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(17, 8);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(450, 32);
			this.lblFecha.TabIndex = 7;
			this.lblFecha.Text = "Fecha";
			this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ptbImagen
			// 
			this.ptbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ptbImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptbImagen.Image")));
			this.ptbImagen.Location = new System.Drawing.Point(17, 51);
			this.ptbImagen.Name = "ptbImagen";
			this.ptbImagen.Size = new System.Drawing.Size(166, 214);
			this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagen.TabIndex = 6;
			this.ptbImagen.TabStop = false;
			// 
			// dgInicio
			// 
			this.dgInicio.AllowUserToAddRows = false;
			this.dgInicio.AllowUserToResizeRows = false;
			this.dgInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgInicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgInicio.BackgroundColor = System.Drawing.Color.White;
			this.dgInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgInicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.USUARIO,
									this.TIPO_column,
									this.HORA,
									this.HR_ENTRADA,
									this.RETARDO,
									this.Column1});
			this.dgInicio.Location = new System.Drawing.Point(484, 51);
			this.dgInicio.Name = "dgInicio";
			this.dgInicio.RowHeadersVisible = false;
			this.dgInicio.Size = new System.Drawing.Size(598, 557);
			this.dgInicio.TabIndex = 5;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// USUARIO
			// 
			this.USUARIO.HeaderText = "Usuario";
			this.USUARIO.Name = "USUARIO";
			this.USUARIO.ReadOnly = true;
			// 
			// TIPO_column
			// 
			this.TIPO_column.HeaderText = "Tipo";
			this.TIPO_column.Name = "TIPO_column";
			this.TIPO_column.ReadOnly = true;
			// 
			// HORA
			// 
			this.HORA.HeaderText = "Hr Llegada";
			this.HORA.Name = "HORA";
			this.HORA.ReadOnly = true;
			// 
			// HR_ENTRADA
			// 
			this.HR_ENTRADA.HeaderText = "Horario";
			this.HR_ENTRADA.Name = "HR_ENTRADA";
			this.HR_ENTRADA.ReadOnly = true;
			// 
			// RETARDO
			// 
			this.RETARDO.HeaderText = "Retardo o Salida Prematura";
			this.RETARDO.Name = "RETARDO";
			this.RETARDO.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Fecha";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblHora);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lblTipo);
			this.groupBox1.Controls.Add(this.lblNombreCompleto);
			this.groupBox1.Location = new System.Drawing.Point(16, 268);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(450, 78);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// lblHora
			// 
			this.lblHora.AutoSize = true;
			this.lblHora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.ForeColor = System.Drawing.Color.Blue;
			this.lblHora.Location = new System.Drawing.Point(273, 49);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(40, 16);
			this.lblHora.TabIndex = 3;
			this.lblHora.Text = "00:00";
			this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(194, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "A LAS:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipo.ForeColor = System.Drawing.Color.Blue;
			this.lblTipo.Location = new System.Drawing.Point(6, 49);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(39, 16);
			this.lblTipo.TabIndex = 1;
			this.lblTipo.Text = "TIPO";
			this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNombreCompleto
			// 
			this.lblNombreCompleto.AutoSize = true;
			this.lblNombreCompleto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreCompleto.Location = new System.Drawing.Point(5, 18);
			this.lblNombreCompleto.Name = "lblNombreCompleto";
			this.lblNombreCompleto.Size = new System.Drawing.Size(64, 16);
			this.lblNombreCompleto.TabIndex = 0;
			this.lblNombreCompleto.Text = "NOMBRE";
			this.lblNombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TimeChecador
			// 
			this.TimeChecador.CustomFormat = "HH:mm";
			this.TimeChecador.Enabled = false;
			this.TimeChecador.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeChecador.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.TimeChecador.Location = new System.Drawing.Point(302, 52);
			this.TimeChecador.Name = "TimeChecador";
			this.TimeChecador.ShowUpDown = true;
			this.TimeChecador.Size = new System.Drawing.Size(165, 62);
			this.TimeChecador.TabIndex = 3;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(3, 3);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tpPrincipal);
			this.tabControl1.Controls.Add(this.tpHorarios);
			this.tabControl1.Controls.Add(this.tpConfiguracion);
			this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 28);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1107, 646);
			this.tabControl1.TabIndex = 4;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
			// 
			// imageChecador
			// 
			this.imageChecador.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageChecador.ImageStream")));
			this.imageChecador.TransparentColor = System.Drawing.Color.Transparent;
			this.imageChecador.Images.SetKeyName(0, "Aceptar.png");
			this.imageChecador.Images.SetKeyName(1, "Cancelar.png");
			// 
			// time
			// 
			this.time.Enabled = true;
			this.time.Tick += new System.EventHandler(this.TimeTick);
			// 
			// tchecador
			// 
			this.tchecador.BackColor = System.Drawing.SystemColors.Control;
			this.tchecador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tchecador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tlSelect,
									this.btnReaderSelect,
									this.btnReportes,
									this.txtReaderSelected2});
			this.tchecador.Location = new System.Drawing.Point(0, 0);
			this.tchecador.Name = "tchecador";
			this.tchecador.Size = new System.Drawing.Size(1107, 25);
			this.tchecador.TabIndex = 6;
			this.tchecador.Text = "toolStrip1";
			// 
			// tlSelect
			// 
			this.tlSelect.Name = "tlSelect";
			this.tlSelect.Size = new System.Drawing.Size(119, 22);
			this.tlSelect.Text = "Selecciona el lector";
			// 
			// btnReaderSelect
			// 
			this.btnReaderSelect.BackColor = System.Drawing.SystemColors.Control;
			this.btnReaderSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnReaderSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnReaderSelect.Enabled = false;
			this.btnReaderSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderSelect.Image")));
			this.btnReaderSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReaderSelect.Name = "btnReaderSelect";
			this.btnReaderSelect.Size = new System.Drawing.Size(23, 22);
			this.btnReaderSelect.Click += new System.EventHandler(this.BtnReaderSelectClick);
			// 
			// btnReportes
			// 
			this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
			this.btnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReportes.Name = "btnReportes";
			this.btnReportes.Size = new System.Drawing.Size(130, 22);
			this.btnReportes.Text = "Reportes de Excel";
			this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnReportes.ToolTipText = "Reportes de Excel";
			this.btnReportes.Click += new System.EventHandler(this.BtnReportesClick);
			// 
			// txtReaderSelected2
			// 
			this.txtReaderSelected2.Enabled = false;
			this.txtReaderSelected2.Name = "txtReaderSelected2";
			this.txtReaderSelected2.Size = new System.Drawing.Size(300, 25);
			this.txtReaderSelected2.Visible = false;
			// 
			// ttip
			// 
			this.ttip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1107, 674);
			this.Controls.Add(this.tchecador);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Transportes LAR - Reloj Checador";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainFormClosed);
			this.Load += new System.EventHandler(this.FormMainLoad);
			this.tpConfiguracion.ResumeLayout(false);
			this.tpConfiguracion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtConfigUsuario)).EndInit();
			this.tpHorarios.ResumeLayout(false);
			this.tpHorarios.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgHorarios)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tpPrincipal.ResumeLayout(false);
			this.tpPrincipal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbWebCam)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgInicio)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tchecador.ResumeLayout(false);
			this.tchecador.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox cboDispositivos;
		private System.Windows.Forms.PictureBox ptbWebCam;
		private System.Windows.Forms.MaskedTextBox txtContrasena;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripButton btnReportes;
		private System.Windows.Forms.Label lblContrasena;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.Label lblPeriodo;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.ToolTip ttip;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.ToolStripTextBox txtReaderSelected2;
		private System.Windows.Forms.ToolStripButton btnReaderSelect;
		private System.Windows.Forms.TextBox txtReaderSelected;
		private System.Windows.Forms.ToolStripLabel tlSelect;
		private System.Windows.Forms.ToolStrip tchecador;
		private System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.TextBox txtInicio;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.Timer time;
		private System.Windows.Forms.ImageList imageChecador;
		public System.Windows.Forms.TextBox txtMensaje;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.DataGridViewTextBoxColumn HUELLA_C;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_C;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OP_C;
		private System.Windows.Forms.DataGridView dtConfigUsuario;
		private System.Windows.Forms.PictureBox pbFingerprint;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_HORARIO;
		private System.Windows.Forms.TextBox txtNombreCompleto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_H;
		private System.Windows.Forms.CheckBox cbLunes;
		private System.Windows.Forms.CheckBox cbMartes;
		private System.Windows.Forms.CheckBox cbMiercoles;
		private System.Windows.Forms.CheckBox cbJueves;
		private System.Windows.Forms.CheckBox cbViernes;
		private System.Windows.Forms.CheckBox cbSabado;
		private System.Windows.Forms.CheckBox cbDomingo;
		private System.Windows.Forms.Button btnNuevo_Horarios;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Button btnEliminar_Horarios;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.DateTimePicker dtpJuS;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DateTimePicker dtpJuE;
		private System.Windows.Forms.DateTimePicker dtpViE;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtpViS;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.DateTimePicker dtpMiS;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker dtpMiE;
		private System.Windows.Forms.DateTimePicker dtpSaE;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpSaS;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.DateTimePicker dtpMaS;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.DateTimePicker dtpMaE;
		private System.Windows.Forms.DateTimePicker dtpDoE;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtpDoS;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpLuS;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.DateTimePicker dtpLuE;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGuardar_Horarios;
		private System.Windows.Forms.TextBox txtNombre_Horario;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOMINGO_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn SABADO_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn VIERNES_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn JUEVES_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn MIERCOLES_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn MARTES_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn LUNES_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_HR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_H;
		private System.Windows.Forms.DataGridView dgHorarios;
		private System.Windows.Forms.DateTimePicker TimeChecador;
		private System.Windows.Forms.Label lblNombreCompleto;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblHora;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn RETARDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn HR_ENTRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_column;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgInicio;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TabPage tpConfiguracion;
		private System.Windows.Forms.TabPage tpHorarios;
		private System.Windows.Forms.TabPage tpPrincipal;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button btnVerify;
		private System.Windows.Forms.Button btnStreaming;
	}
}
