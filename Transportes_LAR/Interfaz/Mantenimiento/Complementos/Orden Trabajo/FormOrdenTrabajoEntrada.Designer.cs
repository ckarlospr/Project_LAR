/*
 * Created by SharpDevelop.
 * User: lalo
 * Date: 30/06/2015
 * Time: 01:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	partial class FormOrdenTrabajoEntrada
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenTrabajoEntrada));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtKilometros = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.timeHoraEntrada = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblordent = new System.Windows.Forms.Label();
			this.btnagregarMecanico = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtHorasExtras = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtMotivosMecanico = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtMecanicoAgregar = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtTipoMecanico = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.MenuMecanico = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.eliminarMecánicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataMecanicos = new System.Windows.Forms.DataGridView();
			this.id_mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tiempo_Extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Motivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuFalla = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.eliminarfALLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataFallas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnagregarFalla = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOrigen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtTipoFalla = new System.Windows.Forms.TextBox();
			this.cmbTipoTaller = new System.Windows.Forms.ComboBox();
			this.txtDescripcionReparacion = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtDescripcionFalla = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtNombreTaller = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.cmbCombustible = new System.Windows.Forms.ComboBox();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.MenuMecanico.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataMecanicos)).BeginInit();
			this.MenuFalla.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.cmbCombustible);
			this.groupBox2.Controls.Add(this.txtKilometros);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.timeHoraEntrada);
			this.groupBox2.Controls.Add(this.dtpFechaEntrada);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(9, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(234, 146);
			this.groupBox2.TabIndex = 232;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Entrada de Vehiculo";
			// 
			// txtKilometros
			// 
			this.txtKilometros.Location = new System.Drawing.Point(85, 111);
			this.txtKilometros.Name = "txtKilometros";
			this.txtKilometros.Size = new System.Drawing.Size(135, 20);
			this.txtKilometros.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 18);
			this.label5.TabIndex = 246;
			this.label5.Text = "Kilometraje";
			// 
			// timeHoraEntrada
			// 
			this.timeHoraEntrada.CustomFormat = "HH:mm";
			this.timeHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraEntrada.Location = new System.Drawing.Point(87, 53);
			this.timeHoraEntrada.Name = "timeHoraEntrada";
			this.timeHoraEntrada.ShowUpDown = true;
			this.timeHoraEntrada.Size = new System.Drawing.Size(133, 20);
			this.timeHoraEntrada.TabIndex = 2;
			this.timeHoraEntrada.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// dtpFechaEntrada
			// 
			this.dtpFechaEntrada.CustomFormat = "dd/MM/yyyy";
			this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFechaEntrada.Location = new System.Drawing.Point(86, 27);
			this.dtpFechaEntrada.Name = "dtpFechaEntrada";
			this.dtpFechaEntrada.Size = new System.Drawing.Size(134, 20);
			this.dtpFechaEntrada.TabIndex = 1;
			this.dtpFechaEntrada.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 88);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 18);
			this.label14.TabIndex = 190;
			this.label14.Text = "Combustible";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(1, 28);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 20);
			this.label9.TabIndex = 187;
			this.label9.Text = "Fecha Ingreso";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(5, 55);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 20);
			this.label11.TabIndex = 185;
			this.label11.Text = "Hora Ingreso";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(135, 291);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(94, 34);
			this.btnCancelar.TabIndex = 18;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(15, 291);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(93, 34);
			this.btnAceptar.TabIndex = 17;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// lblordent
			// 
			this.lblordent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblordent.Location = new System.Drawing.Point(15, 6);
			this.lblordent.Name = "lblordent";
			this.lblordent.Size = new System.Drawing.Size(909, 23);
			this.lblordent.TabIndex = 238;
			this.lblordent.Text = "OT";
			// 
			// btnagregarMecanico
			// 
			this.btnagregarMecanico.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarMecanico.Image")));
			this.btnagregarMecanico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnagregarMecanico.Location = new System.Drawing.Point(819, 201);
			this.btnagregarMecanico.Name = "btnagregarMecanico";
			this.btnagregarMecanico.Size = new System.Drawing.Size(40, 25);
			this.btnagregarMecanico.TabIndex = 16;
			this.btnagregarMecanico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnagregarMecanico.UseVisualStyleBackColor = true;
			this.btnagregarMecanico.Click += new System.EventHandler(this.BtnagregarMecanicoClick);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.txtHorasExtras);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.txtMotivosMecanico);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.txtMecanicoAgregar);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.txtTipoMecanico);
			this.groupBox4.Controls.Add(this.label23);
			this.groupBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(657, 32);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(359, 163);
			this.groupBox4.TabIndex = 241;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Mecánicos";
			// 
			// txtHorasExtras
			// 
			this.txtHorasExtras.Location = new System.Drawing.Point(82, 76);
			this.txtHorasExtras.Name = "txtHorasExtras";
			this.txtHorasExtras.Size = new System.Drawing.Size(172, 20);
			this.txtHorasExtras.TabIndex = 14;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(6, 78);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(82, 18);
			this.label19.TabIndex = 217;
			this.label19.Text = "Horas Extras";
			// 
			// txtMotivosMecanico
			// 
			this.txtMotivosMecanico.Location = new System.Drawing.Point(82, 104);
			this.txtMotivosMecanico.Multiline = true;
			this.txtMotivosMecanico.Name = "txtMotivosMecanico";
			this.txtMotivosMecanico.Size = new System.Drawing.Size(271, 53);
			this.txtMotivosMecanico.TabIndex = 15;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(7, 108);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(85, 18);
			this.label18.TabIndex = 215;
			this.label18.Text = "Motivos";
			// 
			// txtMecanicoAgregar
			// 
			this.txtMecanicoAgregar.Location = new System.Drawing.Point(82, 51);
			this.txtMecanicoAgregar.Name = "txtMecanicoAgregar";
			this.txtMecanicoAgregar.Size = new System.Drawing.Size(172, 20);
			this.txtMecanicoAgregar.TabIndex = 13;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(6, 54);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(85, 18);
			this.label20.TabIndex = 213;
			this.label20.Text = "Mecánicos";
			// 
			// txtTipoMecanico
			// 
			this.txtTipoMecanico.Location = new System.Drawing.Point(82, 25);
			this.txtTipoMecanico.Name = "txtTipoMecanico";
			this.txtTipoMecanico.Size = new System.Drawing.Size(271, 20);
			this.txtTipoMecanico.TabIndex = 12;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(5, 21);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(66, 36);
			this.label23.TabIndex = 209;
			this.label23.Text = "Tipo Mecánicos";
			// 
			// MenuMecanico
			// 
			this.MenuMecanico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.eliminarMecánicoToolStripMenuItem});
			this.MenuMecanico.Name = "contextMenuStrip1";
			this.MenuMecanico.Size = new System.Drawing.Size(173, 26);
			// 
			// eliminarMecánicoToolStripMenuItem
			// 
			this.eliminarMecánicoToolStripMenuItem.Name = "eliminarMecánicoToolStripMenuItem";
			this.eliminarMecánicoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.eliminarMecánicoToolStripMenuItem.Text = "Eliminar Mecánico";
			this.eliminarMecánicoToolStripMenuItem.Click += new System.EventHandler(this.EliminarMecánicoToolStripMenuItemClick);
			// 
			// dataMecanicos
			// 
			this.dataMecanicos.AllowUserToAddRows = false;
			this.dataMecanicos.AllowUserToResizeRows = false;
			this.dataMecanicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataMecanicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataMecanicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataMecanicos.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataMecanicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataMecanicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataMecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataMecanicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_mecanico,
									this.Tipo_Mecanico,
									this.Mecanico,
									this.Tiempo_Extra,
									this.Motivos});
			this.dataMecanicos.ContextMenuStrip = this.MenuMecanico;
			this.dataMecanicos.Location = new System.Drawing.Point(664, 232);
			this.dataMecanicos.Name = "dataMecanicos";
			this.dataMecanicos.RowHeadersVisible = false;
			this.dataMecanicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataMecanicos.Size = new System.Drawing.Size(352, 232);
			this.dataMecanicos.TabIndex = 15;
			this.dataMecanicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMecanicosCellClick);
			// 
			// id_mecanico
			// 
			this.id_mecanico.HeaderText = "id_mecanico";
			this.id_mecanico.Name = "id_mecanico";
			this.id_mecanico.ReadOnly = true;
			this.id_mecanico.Visible = false;
			this.id_mecanico.Width = 73;
			// 
			// Tipo_Mecanico
			// 
			this.Tipo_Mecanico.HeaderText = "Tipo_Mecánico";
			this.Tipo_Mecanico.Name = "Tipo_Mecanico";
			this.Tipo_Mecanico.ReadOnly = true;
			this.Tipo_Mecanico.Width = 106;
			// 
			// Mecanico
			// 
			this.Mecanico.HeaderText = "Mecánico";
			this.Mecanico.Name = "Mecanico";
			this.Mecanico.ReadOnly = true;
			this.Mecanico.Width = 79;
			// 
			// Tiempo_Extra
			// 
			this.Tiempo_Extra.HeaderText = "Tiempo_Extra";
			this.Tiempo_Extra.Name = "Tiempo_Extra";
			this.Tiempo_Extra.ReadOnly = true;
			this.Tiempo_Extra.Width = 97;
			// 
			// Motivos
			// 
			this.Motivos.HeaderText = "Motivos";
			this.Motivos.Name = "Motivos";
			this.Motivos.ReadOnly = true;
			this.Motivos.Width = 69;
			// 
			// MenuFalla
			// 
			this.MenuFalla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.eliminarfALLAToolStripMenuItem});
			this.MenuFalla.Name = "contextMenuStrip1";
			this.MenuFalla.Size = new System.Drawing.Size(145, 26);
			// 
			// eliminarfALLAToolStripMenuItem
			// 
			this.eliminarfALLAToolStripMenuItem.Name = "eliminarfALLAToolStripMenuItem";
			this.eliminarfALLAToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.eliminarfALLAToolStripMenuItem.Text = "Eliminar Falla";
			this.eliminarfALLAToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// dataFallas
			// 
			this.dataFallas.AllowUserToAddRows = false;
			this.dataFallas.AllowUserToResizeRows = false;
			this.dataFallas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataFallas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataFallas.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataFallas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Tipo_falla,
									this.Origen1,
									this.Descripcion_Falla,
									this.Origen,
									this.Nombre_Taller,
									this.Descripcion_Reparacion});
			this.dataFallas.ContextMenuStrip = this.MenuFalla;
			this.dataFallas.Location = new System.Drawing.Point(240, 263);
			this.dataFallas.Name = "dataFallas";
			this.dataFallas.RowHeadersVisible = false;
			this.dataFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallas.Size = new System.Drawing.Size(411, 190);
			this.dataFallas.TabIndex = 247;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 24;
			// 
			// Tipo_falla
			// 
			this.Tipo_falla.HeaderText = "Falla";
			this.Tipo_falla.Name = "Tipo_falla";
			this.Tipo_falla.ReadOnly = true;
			this.Tipo_falla.Width = 54;
			// 
			// Origen1
			// 
			this.Origen1.HeaderText = "Origen";
			this.Origen1.Name = "Origen1";
			this.Origen1.ReadOnly = true;
			this.Origen1.Width = 63;
			// 
			// Descripcion_Falla
			// 
			this.Descripcion_Falla.HeaderText = "Descripción";
			this.Descripcion_Falla.Name = "Descripcion_Falla";
			this.Descripcion_Falla.ReadOnly = true;
			this.Descripcion_Falla.Width = 88;
			// 
			// Origen
			// 
			this.Origen.HeaderText = "Tipo Taller";
			this.Origen.Name = "Origen";
			this.Origen.ReadOnly = true;
			this.Origen.Width = 82;
			// 
			// Nombre_Taller
			// 
			this.Nombre_Taller.HeaderText = "Nombre_Taller";
			this.Nombre_Taller.Name = "Nombre_Taller";
			this.Nombre_Taller.ReadOnly = true;
			this.Nombre_Taller.Width = 101;
			// 
			// Descripcion_Reparacion
			// 
			this.Descripcion_Reparacion.HeaderText = "Descripción_Rep.";
			this.Descripcion_Reparacion.Name = "Descripcion_Reparacion";
			this.Descripcion_Reparacion.ReadOnly = true;
			this.Descripcion_Reparacion.Width = 117;
			// 
			// btnagregarFalla
			// 
			this.btnagregarFalla.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarFalla.Image")));
			this.btnagregarFalla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnagregarFalla.Location = new System.Drawing.Point(420, 232);
			this.btnagregarFalla.Name = "btnagregarFalla";
			this.btnagregarFalla.Size = new System.Drawing.Size(40, 25);
			this.btnagregarFalla.TabIndex = 11;
			this.btnagregarFalla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnagregarFalla.UseVisualStyleBackColor = true;
			this.btnagregarFalla.Click += new System.EventHandler(this.BtnagregarFallaClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtOrigen);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtTipoFalla);
			this.groupBox1.Controls.Add(this.cmbTipoTaller);
			this.groupBox1.Controls.Add(this.txtDescripcionReparacion);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtDescripcionFalla);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.txtNombreTaller);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(249, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(402, 202);
			this.groupBox1.TabIndex = 248;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fallas Reportadas";
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(242, 23);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.Size = new System.Drawing.Size(134, 20);
			this.txtOrigen.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(201, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 18);
			this.label2.TabIndex = 253;
			this.label2.Text = "Origen";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(6, 97);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 18);
			this.label15.TabIndex = 186;
			this.label15.Text = "Tipo Taller";
			// 
			// txtTipoFalla
			// 
			this.txtTipoFalla.Location = new System.Drawing.Point(72, 23);
			this.txtTipoFalla.Name = "txtTipoFalla";
			this.txtTipoFalla.Size = new System.Drawing.Size(121, 20);
			this.txtTipoFalla.TabIndex = 5;
			// 
			// cmbTipoTaller
			// 
			this.cmbTipoTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoTaller.FormattingEnabled = true;
			this.cmbTipoTaller.Items.AddRange(new object[] {
									"Interno",
									"Externo"});
			this.cmbTipoTaller.Location = new System.Drawing.Point(72, 93);
			this.cmbTipoTaller.Name = "cmbTipoTaller";
			this.cmbTipoTaller.Size = new System.Drawing.Size(170, 22);
			this.cmbTipoTaller.TabIndex = 8;
			// 
			// txtDescripcionReparacion
			// 
			this.txtDescripcionReparacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcionReparacion.Location = new System.Drawing.Point(72, 144);
			this.txtDescripcionReparacion.Multiline = true;
			this.txtDescripcionReparacion.Name = "txtDescripcionReparacion";
			this.txtDescripcionReparacion.Size = new System.Drawing.Size(304, 43);
			this.txtDescripcionReparacion.TabIndex = 10;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(6, 148);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 50);
			this.label17.TabIndex = 251;
			this.label17.Text = "Descripción de Reparación";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(5, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(61, 18);
			this.label10.TabIndex = 249;
			this.label10.Text = "Tipo Falla";
			// 
			// txtDescripcionFalla
			// 
			this.txtDescripcionFalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcionFalla.Location = new System.Drawing.Point(72, 50);
			this.txtDescripcionFalla.Multiline = true;
			this.txtDescripcionFalla.Name = "txtDescripcionFalla";
			this.txtDescripcionFalla.Size = new System.Drawing.Size(304, 37);
			this.txtDescripcionFalla.TabIndex = 7;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(5, 52);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(66, 37);
			this.label22.TabIndex = 248;
			this.label22.Text = "Descripción de Falla";
			// 
			// txtNombreTaller
			// 
			this.txtNombreTaller.Location = new System.Drawing.Point(72, 118);
			this.txtNombreTaller.Name = "txtNombreTaller";
			this.txtNombreTaller.Size = new System.Drawing.Size(170, 20);
			this.txtNombreTaller.TabIndex = 9;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(8, 118);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(54, 36);
			this.label16.TabIndex = 250;
			this.label16.Text = "Nombre de Taller";
			// 
			// cmbCombustible
			// 
			this.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCombustible.FormattingEnabled = true;
			this.cmbCombustible.Items.AddRange(new object[] {
									"Lleno",
									"vacío"});
			this.cmbCombustible.Location = new System.Drawing.Point(85, 83);
			this.cmbCombustible.Name = "cmbCombustible";
			this.cmbCombustible.Size = new System.Drawing.Size(135, 22);
			this.cmbCombustible.TabIndex = 253;
			// 
			// FormOrdenTrabajoEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1023, 476);
			this.Controls.Add(this.dataFallas);
			this.Controls.Add(this.btnagregarFalla);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataMecanicos);
			this.Controls.Add(this.btnagregarMecanico);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.lblordent);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOrdenTrabajoEntrada";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Entrada de Vehiculo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenTrabajoEntradaFormClosing);
			this.Load += new System.EventHandler(this.FormOrdenTrabajoEntradaLoad);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.MenuMecanico.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataMecanicos)).EndInit();
			this.MenuFalla.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbCombustible;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOrigen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.ComboBox cmbTipoTaller;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.ToolStripMenuItem eliminarfALLAToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuFalla;
		private System.Windows.Forms.Button btnagregarFalla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_falla;
		private System.Windows.Forms.DataGridView dataFallas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtKilometros;
		private System.Windows.Forms.DataGridViewTextBoxColumn Motivos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo_Extra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mecanico;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Mecanico;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_mecanico;
		private System.Windows.Forms.DataGridView dataMecanicos;
		private System.Windows.Forms.ToolStripMenuItem eliminarMecánicoToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuMecanico;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtTipoMecanico;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtMecanicoAgregar;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtMotivosMecanico;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtHorasExtras;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnagregarMecanico;
		private System.Windows.Forms.Label lblordent;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
		private System.Windows.Forms.DateTimePicker timeHoraEntrada;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtDescripcionFalla;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtTipoFalla;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtNombreTaller;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtDescripcionReparacion;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
