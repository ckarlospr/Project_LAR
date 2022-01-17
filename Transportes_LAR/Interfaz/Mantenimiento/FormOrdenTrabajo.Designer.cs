/*
 * Created by SharpDevelop.
 * User: lar002
 * Date: 20/05/2015
 * Time: 09:13 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento
{
	partial class FormOrdenTrabajo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenTrabajo));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.MenuSalidaVehiculo = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.salidaVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mecánicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimirOrdenTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuFallaVehiculo = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuEntradaVehiculo = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fallasReportadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarMecanicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataFallas = new System.Windows.Forms.DataGridView();
			this.Tipo_falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnagregarFalla = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOrigen = new System.Windows.Forms.TextBox();
			this.timeHoraProgramada = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbHoraTirado = new System.Windows.Forms.CheckBox();
			this.timetHoraTirado = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaProgramda = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
			this.timeHoraReporte = new System.Windows.Forms.DateTimePicker();
			this.label41 = new System.Windows.Forms.Label();
			this.txtArrivo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEstatusReporte = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.cmbTipoMantenimiento = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtOperadorAgregar = new System.Windows.Forms.TextBox();
			this.txtVehiculo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.dataGenerada = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Programda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora_Programda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.dataOrdenTQuedan = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora_Ingreso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCambiarSalida = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dataOrdenTDIA = new System.Windows.Forms.DataGridView();
			this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataFallasPendientes = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vehiculo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora_Ingreso12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreTaller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Reparacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Flujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuFallasPendientes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.reprogramarFallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.txtUnidadFiltro = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbReparadas = new System.Windows.Forms.CheckBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.MenuSalidaVehiculo.SuspendLayout();
			this.MenuFallaVehiculo.SuspendLayout();
			this.MenuEntradaVehiculo.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGenerada)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataOrdenTQuedan)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataOrdenTDIA)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFallasPendientes)).BeginInit();
			this.MenuFallasPendientes.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuSalidaVehiculo
			// 
			this.MenuSalidaVehiculo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salidaVehiculoToolStripMenuItem,
									this.mecánicosToolStripMenuItem,
									this.modificarToolStripMenuItem,
									this.imprimirOrdenTToolStripMenuItem});
			this.MenuSalidaVehiculo.Name = "contextMenuStrip1";
			this.MenuSalidaVehiculo.Size = new System.Drawing.Size(218, 92);
			// 
			// salidaVehiculoToolStripMenuItem
			// 
			this.salidaVehiculoToolStripMenuItem.Name = "salidaVehiculoToolStripMenuItem";
			this.salidaVehiculoToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.salidaVehiculoToolStripMenuItem.Text = "Salida Vehiculo";
			this.salidaVehiculoToolStripMenuItem.Click += new System.EventHandler(this.SalidaVehiculoToolStripMenuItemClick);
			// 
			// mecánicosToolStripMenuItem
			// 
			this.mecánicosToolStripMenuItem.Name = "mecánicosToolStripMenuItem";
			this.mecánicosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.mecánicosToolStripMenuItem.Text = "Agregar Fallas y Mecánicos";
			this.mecánicosToolStripMenuItem.Click += new System.EventHandler(this.MecánicosToolStripMenuItemClick);
			// 
			// modificarToolStripMenuItem
			// 
			this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
			this.modificarToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.modificarToolStripMenuItem.Text = "Modificar Orden";
			this.modificarToolStripMenuItem.Click += new System.EventHandler(this.ModificarToolStripMenuItemClick);
			// 
			// imprimirOrdenTToolStripMenuItem
			// 
			this.imprimirOrdenTToolStripMenuItem.Name = "imprimirOrdenTToolStripMenuItem";
			this.imprimirOrdenTToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.imprimirOrdenTToolStripMenuItem.Text = "Imprimir Orden T";
			this.imprimirOrdenTToolStripMenuItem.Click += new System.EventHandler(this.ImprimirOrdenTToolStripMenuItemClick);
			// 
			// MenuFallaVehiculo
			// 
			this.MenuFallaVehiculo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem3});
			this.MenuFallaVehiculo.Name = "contextMenuStrip1";
			this.MenuFallaVehiculo.Size = new System.Drawing.Size(145, 26);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 22);
			this.toolStripMenuItem3.Text = "Eliminar Falla";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click);
			// 
			// MenuEntradaVehiculo
			// 
			this.MenuEntradaVehiculo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.entradaToolStripMenuItem,
									this.modificarOTToolStripMenuItem,
									this.fallasReportadasToolStripMenuItem,
									this.eliminarToolStripMenuItem});
			this.MenuEntradaVehiculo.Name = "contextMenuStrip1";
			this.MenuEntradaVehiculo.Size = new System.Drawing.Size(166, 92);
			// 
			// entradaToolStripMenuItem
			// 
			this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
			this.entradaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.entradaToolStripMenuItem.Text = "Entrada Vehiculo";
			this.entradaToolStripMenuItem.Click += new System.EventHandler(this.EntradaToolStripMenuItemClick);
			// 
			// modificarOTToolStripMenuItem
			// 
			this.modificarOTToolStripMenuItem.Name = "modificarOTToolStripMenuItem";
			this.modificarOTToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.modificarOTToolStripMenuItem.Text = "Modificar OT";
			this.modificarOTToolStripMenuItem.Click += new System.EventHandler(this.ModificarOTToolStripMenuItemClick);
			// 
			// fallasReportadasToolStripMenuItem
			// 
			this.fallasReportadasToolStripMenuItem.Name = "fallasReportadasToolStripMenuItem";
			this.fallasReportadasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.fallasReportadasToolStripMenuItem.Text = "Fallas Reportadas";
			this.fallasReportadasToolStripMenuItem.Click += new System.EventHandler(this.FallasReportadasToolStripMenuItemClick);
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.eliminarToolStripMenuItem.Text = "Reprogramar OT";
			this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItemClick);
			// 
			// modificarMecanicosToolStripMenuItem
			// 
			this.modificarMecanicosToolStripMenuItem.Name = "modificarMecanicosToolStripMenuItem";
			this.modificarMecanicosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.modificarMecanicosToolStripMenuItem.Text = "Mecánicos";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.LightGray;
			this.tabPage2.Controls.Add(this.dataFallas);
			this.tabPage2.Controls.Add(this.btnagregarFalla);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.btnCancelar);
			this.tabPage2.Controls.Add(this.btnAgregar);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Controls.Add(this.groupBox18);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1076, 450);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Agregar OT";
			// 
			// dataFallas
			// 
			this.dataFallas.AllowUserToAddRows = false;
			this.dataFallas.AllowUserToResizeRows = false;
			this.dataFallas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataFallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataFallas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataFallas.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataFallas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Tipo_falla,
									this.Descripcion_Falla,
									this.Origen,
									this.Nombre_Taller,
									this.Descripcion_Reparacion});
			this.dataFallas.ContextMenuStrip = this.MenuFallaVehiculo;
			this.dataFallas.Location = new System.Drawing.Point(531, 274);
			this.dataFallas.Name = "dataFallas";
			this.dataFallas.RowHeadersVisible = false;
			this.dataFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallas.Size = new System.Drawing.Size(455, 163);
			this.dataFallas.TabIndex = 20;
			this.dataFallas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFallasCellClick);
			// 
			// Tipo_falla
			// 
			this.Tipo_falla.HeaderText = "Falla";
			this.Tipo_falla.Name = "Tipo_falla";
			this.Tipo_falla.ReadOnly = true;
			this.Tipo_falla.Width = 54;
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
			this.btnagregarFalla.Location = new System.Drawing.Point(747, 232);
			this.btnagregarFalla.Name = "btnagregarFalla";
			this.btnagregarFalla.Size = new System.Drawing.Size(40, 25);
			this.btnagregarFalla.TabIndex = 19;
			this.btnagregarFalla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnagregarFalla.UseVisualStyleBackColor = true;
			this.btnagregarFalla.Click += new System.EventHandler(this.BtnagregarFallaClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.txtTipoFalla);
			this.groupBox2.Controls.Add(this.cmbTipoTaller);
			this.groupBox2.Controls.Add(this.txtDescripcionReparacion);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtDescripcionFalla);
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.txtNombreTaller);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(531, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(446, 202);
			this.groupBox2.TabIndex = 245;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fallas Reportadas por Telefono";
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
			this.txtTipoFalla.Size = new System.Drawing.Size(175, 20);
			this.txtTipoFalla.TabIndex = 14;
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
			this.cmbTipoTaller.TabIndex = 16;
			// 
			// txtDescripcionReparacion
			// 
			this.txtDescripcionReparacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcionReparacion.Location = new System.Drawing.Point(72, 144);
			this.txtDescripcionReparacion.Multiline = true;
			this.txtDescripcionReparacion.Name = "txtDescripcionReparacion";
			this.txtDescripcionReparacion.Size = new System.Drawing.Size(304, 43);
			this.txtDescripcionReparacion.TabIndex = 18;
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
			this.txtDescripcionFalla.TabIndex = 15;
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
			this.txtNombreTaller.TabIndex = 17;
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
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(280, 354);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(101, 39);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAgregar.Location = new System.Drawing.Point(108, 354);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(101, 39);
			this.btnAgregar.TabIndex = 21;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtOrigen);
			this.groupBox1.Controls.Add(this.timeHoraProgramada);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cbHoraTirado);
			this.groupBox1.Controls.Add(this.timetHoraTirado);
			this.groupBox1.Controls.Add(this.dtpFechaProgramda);
			this.groupBox1.Controls.Add(this.dtpFechaReporte);
			this.groupBox1.Controls.Add(this.timeHoraReporte);
			this.groupBox1.Controls.Add(this.label41);
			this.groupBox1.Controls.Add(this.txtArrivo);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtEstatusReporte);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(24, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 206);
			this.groupBox1.TabIndex = 230;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Reporte";
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(274, 53);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.Size = new System.Drawing.Size(170, 20);
			this.txtOrigen.TabIndex = 6;
			// 
			// timeHoraProgramada
			// 
			this.timeHoraProgramada.CustomFormat = "HH:mm";
			this.timeHoraProgramada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraProgramada.Location = new System.Drawing.Point(102, 141);
			this.timeHoraProgramada.Name = "timeHoraProgramada";
			this.timeHoraProgramada.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.timeHoraProgramada.ShowUpDown = true;
			this.timeHoraProgramada.Size = new System.Drawing.Size(127, 20);
			this.timeHoraProgramada.TabIndex = 13;
			this.timeHoraProgramada.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(3, 146);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(101, 18);
			this.label14.TabIndex = 184;
			this.label14.Text = "Hora Programada";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(225, 58);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 18);
			this.label11.TabIndex = 182;
			this.label11.Text = "Origen";
			// 
			// cbHoraTirado
			// 
			this.cbHoraTirado.Location = new System.Drawing.Point(432, 113);
			this.cbHoraTirado.Name = "cbHoraTirado";
			this.cbHoraTirado.Size = new System.Drawing.Size(23, 24);
			this.cbHoraTirado.TabIndex = 11;
			this.cbHoraTirado.UseVisualStyleBackColor = true;
			this.cbHoraTirado.CheckedChanged += new System.EventHandler(this.CbHoraTiradoCheckedChanged);
			// 
			// timetHoraTirado
			// 
			this.timetHoraTirado.CustomFormat = "HH:mm";
			this.timetHoraTirado.Enabled = false;
			this.timetHoraTirado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timetHoraTirado.Location = new System.Drawing.Point(307, 115);
			this.timetHoraTirado.Name = "timetHoraTirado";
			this.timetHoraTirado.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.timetHoraTirado.ShowUpDown = true;
			this.timetHoraTirado.Size = new System.Drawing.Size(119, 20);
			this.timetHoraTirado.TabIndex = 12;
			this.timetHoraTirado.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// dtpFechaProgramda
			// 
			this.dtpFechaProgramda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaProgramda.Location = new System.Drawing.Point(102, 115);
			this.dtpFechaProgramda.Name = "dtpFechaProgramda";
			this.dtpFechaProgramda.Size = new System.Drawing.Size(127, 20);
			this.dtpFechaProgramda.TabIndex = 10;
			this.dtpFechaProgramda.Value = new System.DateTime(2015, 7, 21, 0, 0, 0, 0);
			// 
			// dtpFechaReporte
			// 
			this.dtpFechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaReporte.Location = new System.Drawing.Point(102, 85);
			this.dtpFechaReporte.Name = "dtpFechaReporte";
			this.dtpFechaReporte.Size = new System.Drawing.Size(127, 20);
			this.dtpFechaReporte.TabIndex = 8;
			this.dtpFechaReporte.Value = new System.DateTime(2015, 7, 21, 0, 0, 0, 0);
			// 
			// timeHoraReporte
			// 
			this.timeHoraReporte.CustomFormat = "HH:mm";
			this.timeHoraReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraReporte.Location = new System.Drawing.Point(307, 85);
			this.timeHoraReporte.Name = "timeHoraReporte";
			this.timeHoraReporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.timeHoraReporte.ShowUpDown = true;
			this.timeHoraReporte.Size = new System.Drawing.Size(137, 20);
			this.timeHoraReporte.TabIndex = 9;
			this.timeHoraReporte.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			this.timeHoraReporte.Leave += new System.EventHandler(this.TimeHoraReporteLeave);
			// 
			// label41
			// 
			this.label41.BackColor = System.Drawing.Color.Transparent;
			this.label41.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(235, 120);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(66, 18);
			this.label41.TabIndex = 181;
			this.label41.Text = "Hora Tirado";
			// 
			// txtArrivo
			// 
			this.txtArrivo.Location = new System.Drawing.Point(50, 55);
			this.txtArrivo.Name = "txtArrivo";
			this.txtArrivo.Size = new System.Drawing.Size(168, 20);
			this.txtArrivo.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 18);
			this.label7.TabIndex = 179;
			this.label7.Text = "Arrivo";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 18);
			this.label3.TabIndex = 177;
			this.label3.Text = "Fecha Programada";
			// 
			// txtEstatusReporte
			// 
			this.txtEstatusReporte.Location = new System.Drawing.Point(274, 29);
			this.txtEstatusReporte.Name = "txtEstatusReporte";
			this.txtEstatusReporte.Size = new System.Drawing.Size(170, 20);
			this.txtEstatusReporte.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(225, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 175;
			this.label2.Text = "Estatus";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 18);
			this.label6.TabIndex = 173;
			this.label6.Text = "Fecha Reporte";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(50, 29);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(168, 20);
			this.txtCodigo.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(233, 87);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 18);
			this.label12.TabIndex = 160;
			this.label12.Text = "Hora Reporte";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(9, 32);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(58, 18);
			this.label13.TabIndex = 157;
			this.label13.Text = "Código ";
			// 
			// groupBox18
			// 
			this.groupBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.cmbTipoMantenimiento);
			this.groupBox18.Controls.Add(this.label4);
			this.groupBox18.Controls.Add(this.txtOperadorAgregar);
			this.groupBox18.Controls.Add(this.txtVehiculo);
			this.groupBox18.Controls.Add(this.label1);
			this.groupBox18.Controls.Add(this.label8);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(24, 19);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(456, 87);
			this.groupBox18.TabIndex = 229;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Mantenimientos";
			// 
			// cmbTipoMantenimiento
			// 
			this.cmbTipoMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoMantenimiento.FormattingEnabled = true;
			this.cmbTipoMantenimiento.Items.AddRange(new object[] {
									"Correctivo",
									"Preventivo"});
			this.cmbTipoMantenimiento.Location = new System.Drawing.Point(99, 26);
			this.cmbTipoMantenimiento.Name = "cmbTipoMantenimiento";
			this.cmbTipoMantenimiento.Size = new System.Drawing.Size(139, 22);
			this.cmbTipoMantenimiento.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 37);
			this.label4.TabIndex = 171;
			this.label4.Text = "Tipo de mantenimiento";
			// 
			// txtOperadorAgregar
			// 
			this.txtOperadorAgregar.Location = new System.Drawing.Point(99, 54);
			this.txtOperadorAgregar.Name = "txtOperadorAgregar";
			this.txtOperadorAgregar.Size = new System.Drawing.Size(139, 20);
			this.txtOperadorAgregar.TabIndex = 3;
			// 
			// txtVehiculo
			// 
			this.txtVehiculo.Location = new System.Drawing.Point(290, 28);
			this.txtVehiculo.Name = "txtVehiculo";
			this.txtVehiculo.Size = new System.Drawing.Size(154, 20);
			this.txtVehiculo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 18);
			this.label1.TabIndex = 160;
			this.label1.Text = "Operador";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(242, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 18);
			this.label8.TabIndex = 157;
			this.label8.Text = "Vehiculo";
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.LightGray;
			this.tabPage1.Controls.Add(this.groupBox9);
			this.tabPage1.Controls.Add(this.groupBox6);
			this.tabPage1.Controls.Add(this.btnCambiarSalida);
			this.tabPage1.Controls.Add(this.groupBox5);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1076, 450);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Control OT";
			// 
			// groupBox9
			// 
			this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox9.Controls.Add(this.dataGenerada);
			this.groupBox9.Location = new System.Drawing.Point(3, 3);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(498, 439);
			this.groupBox9.TabIndex = 156;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Orden  de Trabjo";
			// 
			// dataGenerada
			// 
			this.dataGenerada.AllowUserToAddRows = false;
			this.dataGenerada.AllowUserToResizeRows = false;
			this.dataGenerada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGenerada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGenerada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGenerada.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataGenerada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGenerada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGenerada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGenerada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn8,
									this.dataGridViewTextBoxColumn9,
									this.Codigoo,
									this.dataGridViewTextBoxColumn10,
									this.dataGridViewTextBoxColumn11,
									this.Fecha_Programda,
									this.Hora_Programda});
			this.dataGenerada.ContextMenuStrip = this.MenuEntradaVehiculo;
			this.dataGenerada.Location = new System.Drawing.Point(6, 19);
			this.dataGenerada.Name = "dataGenerada";
			this.dataGenerada.RowHeadersVisible = false;
			this.dataGenerada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGenerada.Size = new System.Drawing.Size(486, 415);
			this.dataGenerada.TabIndex = 155;
			this.dataGenerada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGeneradaCellClick);
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Orden";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Width = 62;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.HeaderText = "Mant.";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Width = 58;
			// 
			// Codigoo
			// 
			this.Codigoo.HeaderText = "Codigo";
			this.Codigoo.Name = "Codigoo";
			this.Codigoo.ReadOnly = true;
			this.Codigoo.Width = 65;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.HeaderText = "Operador";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Width = 78;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.HeaderText = "Vehiculo";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 73;
			// 
			// Fecha_Programda
			// 
			this.Fecha_Programda.HeaderText = "Fecha_P";
			this.Fecha_Programda.Name = "Fecha_Programda";
			this.Fecha_Programda.ReadOnly = true;
			this.Fecha_Programda.Width = 74;
			// 
			// Hora_Programda
			// 
			this.Hora_Programda.HeaderText = "Hora_P";
			this.Hora_Programda.Name = "Hora_Programda";
			this.Hora_Programda.ReadOnly = true;
			this.Hora_Programda.Width = 67;
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.dataOrdenTQuedan);
			this.groupBox6.Location = new System.Drawing.Point(520, 245);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(548, 193);
			this.groupBox6.TabIndex = 156;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Vehiculos Que se quedan";
			// 
			// dataOrdenTQuedan
			// 
			this.dataOrdenTQuedan.AllowUserToAddRows = false;
			this.dataOrdenTQuedan.AllowUserToResizeRows = false;
			this.dataOrdenTQuedan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dataOrdenTQuedan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataOrdenTQuedan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataOrdenTQuedan.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataOrdenTQuedan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataOrdenTQuedan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataOrdenTQuedan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOrdenTQuedan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn5,
									this.dataGridViewTextBoxColumn6,
									this.Hora_Ingreso1,
									this.Fecha_Estimada});
			this.dataOrdenTQuedan.ContextMenuStrip = this.MenuSalidaVehiculo;
			this.dataOrdenTQuedan.Location = new System.Drawing.Point(7, 20);
			this.dataOrdenTQuedan.Name = "dataOrdenTQuedan";
			this.dataOrdenTQuedan.RowHeadersVisible = false;
			this.dataOrdenTQuedan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataOrdenTQuedan.Size = new System.Drawing.Size(535, 168);
			this.dataOrdenTQuedan.TabIndex = 155;
			this.dataOrdenTQuedan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOrdenTQuedanCellClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Orden";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 62;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Operador";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 78;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Vehiculo";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 73;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Codigo";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 65;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Fecha_Ingreso";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 104;
			// 
			// Hora_Ingreso1
			// 
			this.Hora_Ingreso1.HeaderText = "Hora_Ingreso";
			this.Hora_Ingreso1.Name = "Hora_Ingreso1";
			this.Hora_Ingreso1.ReadOnly = true;
			this.Hora_Ingreso1.Width = 97;
			// 
			// Fecha_Estimada
			// 
			this.Fecha_Estimada.HeaderText = "Fecha_Estimada";
			this.Fecha_Estimada.Name = "Fecha_Estimada";
			this.Fecha_Estimada.ReadOnly = true;
			this.Fecha_Estimada.Width = 111;
			// 
			// btnCambiarSalida
			// 
			this.btnCambiarSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCambiarSalida.Location = new System.Drawing.Point(739, 201);
			this.btnCambiarSalida.Name = "btnCambiarSalida";
			this.btnCambiarSalida.Size = new System.Drawing.Size(145, 37);
			this.btnCambiarSalida.TabIndex = 157;
			this.btnCambiarSalida.Text = "Cambiar Salida";
			this.btnCambiarSalida.UseVisualStyleBackColor = true;
			this.btnCambiarSalida.Click += new System.EventHandler(this.BtnCambiarSalidaClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.dataOrdenTDIA);
			this.groupBox5.Location = new System.Drawing.Point(520, 1);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(547, 194);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Vehiculos al Dia";
			// 
			// dataOrdenTDIA
			// 
			this.dataOrdenTDIA.AllowUserToAddRows = false;
			this.dataOrdenTDIA.AllowUserToResizeRows = false;
			this.dataOrdenTDIA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataOrdenTDIA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataOrdenTDIA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataOrdenTDIA.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataOrdenTDIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataOrdenTDIA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataOrdenTDIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOrdenTDIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Producto,
									this.Tipo_Mantenimiento,
									this.Operador,
									this.Vehiculo,
									this.Codigo,
									this.Fecha_Orden,
									this.Hora_Ingreso});
			this.dataOrdenTDIA.ContextMenuStrip = this.MenuSalidaVehiculo;
			this.dataOrdenTDIA.Location = new System.Drawing.Point(6, 16);
			this.dataOrdenTDIA.Name = "dataOrdenTDIA";
			this.dataOrdenTDIA.RowHeadersVisible = false;
			this.dataOrdenTDIA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataOrdenTDIA.Size = new System.Drawing.Size(534, 172);
			this.dataOrdenTDIA.TabIndex = 155;
			this.dataOrdenTDIA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOrdenTDIACellClick);
			// 
			// ID_Producto
			// 
			this.ID_Producto.HeaderText = "Orden";
			this.ID_Producto.Name = "ID_Producto";
			this.ID_Producto.ReadOnly = true;
			this.ID_Producto.Width = 62;
			// 
			// Tipo_Mantenimiento
			// 
			this.Tipo_Mantenimiento.HeaderText = "Tipo_Mant.";
			this.Tipo_Mantenimiento.Name = "Tipo_Mantenimiento";
			this.Tipo_Mantenimiento.ReadOnly = true;
			this.Tipo_Mantenimiento.Width = 84;
			// 
			// Operador
			// 
			this.Operador.HeaderText = "Operador";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			this.Operador.Width = 78;
			// 
			// Vehiculo
			// 
			this.Vehiculo.HeaderText = "Vehiculo";
			this.Vehiculo.Name = "Vehiculo";
			this.Vehiculo.ReadOnly = true;
			this.Vehiculo.Width = 73;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			this.Codigo.Width = 65;
			// 
			// Fecha_Orden
			// 
			this.Fecha_Orden.HeaderText = "Fecha_Ingreso";
			this.Fecha_Orden.Name = "Fecha_Orden";
			this.Fecha_Orden.ReadOnly = true;
			this.Fecha_Orden.Width = 104;
			// 
			// Hora_Ingreso
			// 
			this.Hora_Ingreso.HeaderText = "Hora_Ingreso";
			this.Hora_Ingreso.Name = "Hora_Ingreso";
			this.Hora_Ingreso.ReadOnly = true;
			this.Hora_Ingreso.Width = 97;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(-5, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1084, 476);
			this.tabControl1.TabIndex = 158;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage3.Controls.Add(this.dataFallasPendientes);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1076, 450);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Fallas Pendientes";
			// 
			// dataFallasPendientes
			// 
			this.dataFallasPendientes.AllowUserToAddRows = false;
			this.dataFallasPendientes.AllowUserToResizeRows = false;
			this.dataFallasPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataFallasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataFallasPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataFallasPendientes.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataFallasPendientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFallasPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataFallasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFallasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Vehiculo1,
									this.Operador1,
									this.Fecha_Entrada,
									this.Hora_Ingreso12,
									this.Fecha_Salida,
									this.Hora_Salida,
									this.Falla,
									this.Origen1,
									this.Descripcion,
									this.Tipo_Taller,
									this.NombreTaller,
									this.Descripcion_Reparacion1,
									this.Flujo});
			this.dataFallasPendientes.ContextMenuStrip = this.MenuFallasPendientes;
			this.dataFallasPendientes.Location = new System.Drawing.Point(6, 101);
			this.dataFallasPendientes.Name = "dataFallasPendientes";
			this.dataFallasPendientes.RowHeadersVisible = false;
			this.dataFallasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallasPendientes.Size = new System.Drawing.Size(1061, 343);
			this.dataFallasPendientes.TabIndex = 250;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			this.ID.Width = 24;
			// 
			// Vehiculo1
			// 
			this.Vehiculo1.HeaderText = "Vehiculo";
			this.Vehiculo1.Name = "Vehiculo1";
			this.Vehiculo1.Width = 73;
			// 
			// Operador1
			// 
			this.Operador1.HeaderText = "Operador";
			this.Operador1.Name = "Operador1";
			this.Operador1.Visible = false;
			this.Operador1.Width = 76;
			// 
			// Fecha_Entrada
			// 
			this.Fecha_Entrada.HeaderText = "Fecha_Entrada";
			this.Fecha_Entrada.Name = "Fecha_Entrada";
			this.Fecha_Entrada.Width = 105;
			// 
			// Hora_Ingreso12
			// 
			this.Hora_Ingreso12.HeaderText = "Hora Entrada";
			this.Hora_Ingreso12.Name = "Hora_Ingreso12";
			this.Hora_Ingreso12.Width = 87;
			// 
			// Fecha_Salida
			// 
			this.Fecha_Salida.HeaderText = "Fecha_Salida";
			this.Fecha_Salida.Name = "Fecha_Salida";
			this.Fecha_Salida.Width = 97;
			// 
			// Hora_Salida
			// 
			this.Hora_Salida.HeaderText = "Hora Salida";
			this.Hora_Salida.Name = "Hora_Salida";
			this.Hora_Salida.Width = 80;
			// 
			// Falla
			// 
			this.Falla.HeaderText = "Falla";
			this.Falla.Name = "Falla";
			this.Falla.Width = 54;
			// 
			// Origen1
			// 
			this.Origen1.HeaderText = "Origen";
			this.Origen1.Name = "Origen1";
			this.Origen1.Width = 63;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Width = 88;
			// 
			// Tipo_Taller
			// 
			this.Tipo_Taller.HeaderText = "Tipo Taller";
			this.Tipo_Taller.Name = "Tipo_Taller";
			this.Tipo_Taller.Width = 76;
			// 
			// NombreTaller
			// 
			this.NombreTaller.HeaderText = "Nombre Taller";
			this.NombreTaller.Name = "NombreTaller";
			this.NombreTaller.Width = 90;
			// 
			// Descripcion_Reparacion1
			// 
			this.Descripcion_Reparacion1.HeaderText = "Descripcion Reparacion";
			this.Descripcion_Reparacion1.Name = "Descripcion_Reparacion1";
			this.Descripcion_Reparacion1.Width = 133;
			// 
			// Flujo
			// 
			this.Flujo.HeaderText = "Flujo";
			this.Flujo.Name = "Flujo";
			this.Flujo.Width = 54;
			// 
			// MenuFallasPendientes
			// 
			this.MenuFallasPendientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.reprogramarFallasToolStripMenuItem});
			this.MenuFallasPendientes.Name = "contextMenuStrip1";
			this.MenuFallasPendientes.Size = new System.Drawing.Size(176, 26);
			// 
			// reprogramarFallasToolStripMenuItem
			// 
			this.reprogramarFallasToolStripMenuItem.Name = "reprogramarFallasToolStripMenuItem";
			this.reprogramarFallasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.reprogramarFallasToolStripMenuItem.Text = "Reprogramar Fallas";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.groupBox8);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.groupBox7);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(6, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1061, 92);
			this.groupBox3.TabIndex = 249;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Filtros";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.txtUnidadFiltro);
			this.groupBox8.Controls.Add(this.label5);
			this.groupBox8.Location = new System.Drawing.Point(10, 15);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(240, 71);
			this.groupBox8.TabIndex = 10;
			this.groupBox8.TabStop = false;
			// 
			// txtUnidadFiltro
			// 
			this.txtUnidadFiltro.Location = new System.Drawing.Point(89, 28);
			this.txtUnidadFiltro.Name = "txtUnidadFiltro";
			this.txtUnidadFiltro.Size = new System.Drawing.Size(129, 20);
			this.txtUnidadFiltro.TabIndex = 250;
			this.txtUnidadFiltro.TextChanged += new System.EventHandler(this.TxtUnidadFiltroTextChanged);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 18);
			this.label5.TabIndex = 251;
			this.label5.Text = "Unidad";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cbReparadas);
			this.groupBox4.Location = new System.Drawing.Point(565, 15);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(161, 68);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			// 
			// cbReparadas
			// 
			this.cbReparadas.Location = new System.Drawing.Point(17, 30);
			this.cbReparadas.Name = "cbReparadas";
			this.cbReparadas.Size = new System.Drawing.Size(127, 18);
			this.cbReparadas.TabIndex = 1;
			this.cbReparadas.Text = "Reparadas";
			this.cbReparadas.UseVisualStyleBackColor = true;
			this.cbReparadas.CheckedChanged += new System.EventHandler(this.CbReparadasCheckedChanged);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.dtpInicio);
			this.groupBox7.Controls.Add(this.dtpFin);
			this.groupBox7.Location = new System.Drawing.Point(256, 15);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(303, 71);
			this.groupBox7.TabIndex = 6;
			this.groupBox7.TabStop = false;
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(25, 30);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(110, 20);
			this.dtpInicio.TabIndex = 4;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(157, 30);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(111, 20);
			this.dtpFin.TabIndex = 5;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// FormOrdenTrabajo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1078, 471);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1094, 509);
			this.Name = "FormOrdenTrabajo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Orden de Trabajo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenTrabajoFormClosing);
			this.Load += new System.EventHandler(this.FormOrdenTrabajoLoad);
			this.MenuSalidaVehiculo.ResumeLayout(false);
			this.MenuFallaVehiculo.ResumeLayout(false);
			this.MenuEntradaVehiculo.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGenerada)).EndInit();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataOrdenTQuedan)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataOrdenTDIA)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataFallasPendientes)).EndInit();
			this.MenuFallasPendientes.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem reprogramarFallasToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuFallasPendientes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Salida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Ingreso12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Flujo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion1;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreTaller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Salida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Entrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dataFallasPendientes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUnidadFiltro;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.CheckBox cbReparadas;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox txtOrigen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Ingreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Estimada;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Ingreso1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigoo;
		private System.Windows.Forms.ToolStripMenuItem fallasReportadasToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Programda;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Programda;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ContextMenuStrip MenuFallaVehiculo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DateTimePicker timeHoraProgramada;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtNombreTaller;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtDescripcionFalla;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtDescripcionReparacion;
		private System.Windows.Forms.ComboBox cmbTipoTaller;
		private System.Windows.Forms.TextBox txtTipoFalla;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnagregarFalla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_falla;
		private System.Windows.Forms.DataGridView dataFallas;
		private System.Windows.Forms.ToolStripMenuItem modificarOTToolStripMenuItem;
		private System.Windows.Forms.CheckBox cbHoraTirado;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuEntradaVehiculo;
		private System.Windows.Forms.DateTimePicker dtpFechaReporte;
		private System.Windows.Forms.DateTimePicker dtpFechaProgramda;
		private System.Windows.Forms.DateTimePicker timetHoraTirado;
		private System.Windows.Forms.DateTimePicker timeHoraReporte;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		public System.Windows.Forms.DataGridView dataGenerada;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.ToolStripMenuItem imprimirOrdenTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mecánicosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarMecanicosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salidaVehiculoToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuSalidaVehiculo;
		private System.Windows.Forms.Button btnCambiarSalida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Mantenimiento;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		public System.Windows.Forms.DataGridView dataOrdenTQuedan;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtVehiculo;
		private System.Windows.Forms.TextBox txtOperadorAgregar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbTipoMantenimiento;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEstatusReporte;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtArrivo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Orden;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
		public System.Windows.Forms.DataGridView dataOrdenTDIA;
		
		
	}
}
