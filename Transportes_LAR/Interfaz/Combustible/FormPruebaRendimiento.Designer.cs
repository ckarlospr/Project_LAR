/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 29/01/2016
 * Hora: 12:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormPruebaRendimiento
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPruebaRendimiento));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgPruebaRendimiento = new System.Windows.Forms.DataGridView();
			this.ID_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_ope = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADORP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PREVPRUEBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RENDIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_PRUEBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SEGUIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LITROS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KM_BASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.P5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuRendiemiento = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.nuebaPruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historialPruebasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnReporte = new System.Windows.Forms.Button();
			this.pbConfiguraciones = new System.Windows.Forms.PictureBox();
			this.cbTodas = new System.Windows.Forms.CheckBox();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.dgHistorial = new System.Windows.Forms.DataGridView();
			this.ID_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_O = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADORH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA_FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LITROS_CF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KM_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KM_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SEGUIMIENTOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COMENTARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.pnFiltros = new System.Windows.Forms.Panel();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.gbFiltros = new System.Windows.Forms.GroupBox();
			this.lblMostrar = new System.Windows.Forms.Label();
			this.btnImprimirHst = new System.Windows.Forms.Button();
			this.txtbusUnidad = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgPruebaRendimiento)).BeginInit();
			this.MenuRendiemiento.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).BeginInit();
			this.pnFiltros.SuspendLayout();
			this.gbFiltros.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgPruebaRendimiento
			// 
			this.dgPruebaRendimiento.AllowUserToAddRows = false;
			this.dgPruebaRendimiento.AllowUserToResizeRows = false;
			this.dgPruebaRendimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgPruebaRendimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPruebaRendimiento.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPruebaRendimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgPruebaRendimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPruebaRendimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_V,
									this.VEHICULO,
									this.id_ope,
									this.OPERADOR,
									this.ID,
									this.OPERADORP,
									this.PREVPRUEBA,
									this.RENDIMIENTO,
									this.FECHA_PRUEBA,
									this.SEGUIMIENTO,
									this.ID_RH,
									this.LITROS,
									this.ID0,
									this.KM_BASE,
									this.ID1,
									this.P1,
									this.ID2,
									this.P2,
									this.ID3,
									this.P3,
									this.ID4,
									this.P4,
									this.ID5,
									this.P5});
			this.dgPruebaRendimiento.ContextMenuStrip = this.MenuRendiemiento;
			this.dgPruebaRendimiento.Location = new System.Drawing.Point(12, 5);
			this.dgPruebaRendimiento.MultiSelect = false;
			this.dgPruebaRendimiento.Name = "dgPruebaRendimiento";
			this.dgPruebaRendimiento.RowHeadersVisible = false;
			this.dgPruebaRendimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPruebaRendimiento.Size = new System.Drawing.Size(887, 615);
			this.dgPruebaRendimiento.TabIndex = 76;
			this.dgPruebaRendimiento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPruebaRendimientoCellDoubleClick);
			// 
			// ID_V
			// 
			this.ID_V.HeaderText = "ID_V";
			this.ID_V.Name = "ID_V";
			this.ID_V.Visible = false;
			// 
			// VEHICULO
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VEHICULO.DefaultCellStyle = dataGridViewCellStyle2;
			this.VEHICULO.FillWeight = 25.2613F;
			this.VEHICULO.HeaderText = "UNIDAD";
			this.VEHICULO.Name = "VEHICULO";
			this.VEHICULO.ReadOnly = true;
			// 
			// id_ope
			// 
			this.id_ope.HeaderText = "id_ope";
			this.id_ope.Name = "id_ope";
			this.id_ope.ReadOnly = true;
			this.id_ope.Visible = false;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle3;
			this.OPERADOR.FillWeight = 22.73517F;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			// 
			// ID
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID.DefaultCellStyle = dataGridViewCellStyle4;
			this.ID.FillWeight = 30F;
			this.ID.HeaderText = "ID_R";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// OPERADORP
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.OPERADORP.DefaultCellStyle = dataGridViewCellStyle5;
			this.OPERADORP.FillWeight = 22F;
			this.OPERADORP.HeaderText = "OP. PRUEBA";
			this.OPERADORP.Name = "OPERADORP";
			this.OPERADORP.ReadOnly = true;
			// 
			// PREVPRUEBA
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.PREVPRUEBA.DefaultCellStyle = dataGridViewCellStyle6;
			this.PREVPRUEBA.FillWeight = 25.2613F;
			this.PREVPRUEBA.HeaderText = "PREVIO PRUEBA";
			this.PREVPRUEBA.Name = "PREVPRUEBA";
			// 
			// RENDIMIENTO
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RENDIMIENTO.DefaultCellStyle = dataGridViewCellStyle7;
			this.RENDIMIENTO.FillWeight = 22.73517F;
			this.RENDIMIENTO.HeaderText = "REND. PRUEBA";
			this.RENDIMIENTO.Name = "RENDIMIENTO";
			this.RENDIMIENTO.ReadOnly = true;
			// 
			// FECHA_PRUEBA
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.FECHA_PRUEBA.DefaultCellStyle = dataGridViewCellStyle8;
			this.FECHA_PRUEBA.FillWeight = 28.88896F;
			this.FECHA_PRUEBA.HeaderText = "FECHA_PRUEBA";
			this.FECHA_PRUEBA.Name = "FECHA_PRUEBA";
			this.FECHA_PRUEBA.ReadOnly = true;
			// 
			// SEGUIMIENTO
			// 
			this.SEGUIMIENTO.FillWeight = 50.5226F;
			this.SEGUIMIENTO.HeaderText = "SEGUIMIENTO";
			this.SEGUIMIENTO.Name = "SEGUIMIENTO";
			this.SEGUIMIENTO.ReadOnly = true;
			// 
			// ID_RH
			// 
			this.ID_RH.HeaderText = "ID_RH";
			this.ID_RH.Name = "ID_RH";
			this.ID_RH.Visible = false;
			// 
			// LITROS
			// 
			this.LITROS.HeaderText = "LITROS";
			this.LITROS.Name = "LITROS";
			this.LITROS.ReadOnly = true;
			this.LITROS.Visible = false;
			// 
			// ID0
			// 
			this.ID0.FillWeight = 20F;
			this.ID0.HeaderText = "ID1";
			this.ID0.Name = "ID0";
			this.ID0.Visible = false;
			// 
			// KM_BASE
			// 
			this.KM_BASE.FillWeight = 25F;
			this.KM_BASE.HeaderText = "C1";
			this.KM_BASE.Name = "KM_BASE";
			this.KM_BASE.ReadOnly = true;
			// 
			// ID1
			// 
			this.ID1.FillWeight = 20F;
			this.ID1.HeaderText = "ID2";
			this.ID1.Name = "ID1";
			this.ID1.Visible = false;
			// 
			// P1
			// 
			this.P1.FillWeight = 25F;
			this.P1.HeaderText = "C2";
			this.P1.Name = "P1";
			this.P1.ReadOnly = true;
			// 
			// ID2
			// 
			this.ID2.FillWeight = 20F;
			this.ID2.HeaderText = "ID3";
			this.ID2.Name = "ID2";
			this.ID2.Visible = false;
			// 
			// P2
			// 
			this.P2.FillWeight = 25F;
			this.P2.HeaderText = "C3";
			this.P2.Name = "P2";
			this.P2.ReadOnly = true;
			// 
			// ID3
			// 
			this.ID3.FillWeight = 20F;
			this.ID3.HeaderText = "ID4";
			this.ID3.Name = "ID3";
			this.ID3.Visible = false;
			// 
			// P3
			// 
			this.P3.FillWeight = 25F;
			this.P3.HeaderText = "C4";
			this.P3.Name = "P3";
			this.P3.ReadOnly = true;
			// 
			// ID4
			// 
			this.ID4.FillWeight = 20F;
			this.ID4.HeaderText = "ID5";
			this.ID4.Name = "ID4";
			this.ID4.Visible = false;
			// 
			// P4
			// 
			this.P4.FillWeight = 25F;
			this.P4.HeaderText = "C5";
			this.P4.Name = "P4";
			this.P4.ReadOnly = true;
			// 
			// ID5
			// 
			this.ID5.FillWeight = 20F;
			this.ID5.HeaderText = "ID_BASE";
			this.ID5.Name = "ID5";
			this.ID5.Visible = false;
			// 
			// P5
			// 
			this.P5.FillWeight = 25F;
			this.P5.HeaderText = "C5_BASE";
			this.P5.Name = "P5";
			this.P5.Visible = false;
			// 
			// MenuRendiemiento
			// 
			this.MenuRendiemiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.nuebaPruebaToolStripMenuItem,
									this.historialPruebasToolStripMenuItem});
			this.MenuRendiemiento.Name = "MenuRendiemiento";
			this.MenuRendiemiento.Size = new System.Drawing.Size(164, 48);
			// 
			// nuebaPruebaToolStripMenuItem
			// 
			this.nuebaPruebaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuebaPruebaToolStripMenuItem.Image")));
			this.nuebaPruebaToolStripMenuItem.Name = "nuebaPruebaToolStripMenuItem";
			this.nuebaPruebaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.nuebaPruebaToolStripMenuItem.Text = "Nueva Prueba";
			this.nuebaPruebaToolStripMenuItem.Click += new System.EventHandler(this.NuebaPruebaToolStripMenuItemClick);
			// 
			// historialPruebasToolStripMenuItem
			// 
			this.historialPruebasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialPruebasToolStripMenuItem.Image")));
			this.historialPruebasToolStripMenuItem.Name = "historialPruebasToolStripMenuItem";
			this.historialPruebasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.historialPruebasToolStripMenuItem.Text = "Historial Pruebas";
			this.historialPruebasToolStripMenuItem.Click += new System.EventHandler(this.HistorialPruebasToolStripMenuItemClick);
			// 
			// btnReporte
			// 
			this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
			this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReporte.Location = new System.Drawing.Point(907, 154);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(91, 43);
			this.btnReporte.TabIndex = 82;
			this.btnReporte.Text = "Imprimir";
			this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnReporte.UseVisualStyleBackColor = true;
			this.btnReporte.Click += new System.EventHandler(this.BtnReporteClick);
			// 
			// pbConfiguraciones
			// 
			this.pbConfiguraciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbConfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("pbConfiguraciones.Image")));
			this.pbConfiguraciones.Location = new System.Drawing.Point(932, 12);
			this.pbConfiguraciones.Name = "pbConfiguraciones";
			this.pbConfiguraciones.Size = new System.Drawing.Size(33, 32);
			this.pbConfiguraciones.TabIndex = 110;
			this.pbConfiguraciones.TabStop = false;
			this.pbConfiguraciones.Visible = false;
			this.pbConfiguraciones.Click += new System.EventHandler(this.PbConfiguracionesClick);
			// 
			// cbTodas
			// 
			this.cbTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTodas.Location = new System.Drawing.Point(434, 42);
			this.cbTodas.Name = "cbTodas";
			this.cbTodas.Size = new System.Drawing.Size(66, 24);
			this.cbTodas.TabIndex = 77;
			this.cbTodas.Text = "Todas";
			this.cbTodas.UseVisualStyleBackColor = true;
			this.cbTodas.CheckedChanged += new System.EventHandler(this.CbTodasCheckedChanged);
			// 
			// bntBuscar
			// 
			this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
			this.bntBuscar.Location = new System.Drawing.Point(506, 32);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(40, 40);
			this.bntBuscar.TabIndex = 76;
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.BntBuscarClick);
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
			this.cmdImprimir.Location = new System.Drawing.Point(587, 32);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.Size = new System.Drawing.Size(40, 40);
			this.cmdImprimir.TabIndex = 78;
			this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdImprimir.UseVisualStyleBackColor = true;
			this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
			// 
			// dgHistorial
			// 
			this.dgHistorial.AllowUserToAddRows = false;
			this.dgHistorial.AllowUserToResizeRows = false;
			this.dgHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgHistorial.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_R,
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.ID_O,
									this.OPERADORH,
									this.USUARIO,
									this.FACTOR,
									this.FECHAP,
									this.HORA_INICIO,
									this.HORA_FIN,
									this.LITROS_CF,
									this.KM_I,
									this.KM_F,
									this.SEGUIMIENTOA,
									this.COMENTARIO});
			this.dgHistorial.Location = new System.Drawing.Point(32, 76);
			this.dgHistorial.MultiSelect = false;
			this.dgHistorial.Name = "dgHistorial";
			this.dgHistorial.RowHeadersVisible = false;
			this.dgHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgHistorial.Size = new System.Drawing.Size(596, 531);
			this.dgHistorial.TabIndex = 78;
			this.dgHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgHistorialCellDoubleClick);
			// 
			// ID_R
			// 
			this.ID_R.HeaderText = "ID_R";
			this.ID_R.Name = "ID_R";
			this.ID_R.Visible = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID_H";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "UNIDAD";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 60;
			// 
			// ID_O
			// 
			this.ID_O.HeaderText = "ID_O";
			this.ID_O.Name = "ID_O";
			this.ID_O.Visible = false;
			// 
			// OPERADORH
			// 
			this.OPERADORH.HeaderText = "OPERADOR";
			this.OPERADORH.Name = "OPERADORH";
			this.OPERADORH.ReadOnly = true;
			this.OPERADORH.Width = 85;
			// 
			// USUARIO
			// 
			this.USUARIO.HeaderText = "USUARIO";
			this.USUARIO.Name = "USUARIO";
			this.USUARIO.ReadOnly = true;
			this.USUARIO.Width = 70;
			// 
			// FACTOR
			// 
			this.FACTOR.HeaderText = "REND.";
			this.FACTOR.Name = "FACTOR";
			this.FACTOR.ReadOnly = true;
			this.FACTOR.Width = 65;
			// 
			// FECHAP
			// 
			this.FECHAP.HeaderText = "FECHA PRUEBA";
			this.FECHAP.Name = "FECHAP";
			this.FECHAP.ReadOnly = true;
			this.FECHAP.Width = 75;
			// 
			// HORA_INICIO
			// 
			this.HORA_INICIO.HeaderText = "HORA INICIO";
			this.HORA_INICIO.Name = "HORA_INICIO";
			this.HORA_INICIO.ReadOnly = true;
			this.HORA_INICIO.Width = 65;
			// 
			// HORA_FIN
			// 
			this.HORA_FIN.HeaderText = "HORA FIN";
			this.HORA_FIN.Name = "HORA_FIN";
			this.HORA_FIN.ReadOnly = true;
			this.HORA_FIN.Width = 65;
			// 
			// LITROS_CF
			// 
			this.LITROS_CF.HeaderText = "LITROS CARGADOS";
			this.LITROS_CF.Name = "LITROS_CF";
			this.LITROS_CF.ReadOnly = true;
			this.LITROS_CF.Width = 85;
			// 
			// KM_I
			// 
			this.KM_I.HeaderText = "KM INICIAL";
			this.KM_I.Name = "KM_I";
			this.KM_I.ReadOnly = true;
			this.KM_I.Width = 70;
			// 
			// KM_F
			// 
			this.KM_F.HeaderText = "KM FINAL";
			this.KM_F.Name = "KM_F";
			this.KM_F.ReadOnly = true;
			this.KM_F.Width = 70;
			// 
			// SEGUIMIENTOA
			// 
			this.SEGUIMIENTOA.HeaderText = "SEGUIMIENTO";
			this.SEGUIMIENTOA.Name = "SEGUIMIENTOA";
			this.SEGUIMIENTOA.ReadOnly = true;
			// 
			// COMENTARIO
			// 
			this.COMENTARIO.HeaderText = "COMENTARIO";
			this.COMENTARIO.Name = "COMENTARIO";
			this.COMENTARIO.ReadOnly = true;
			this.COMENTARIO.Visible = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(620, 18);
			this.label2.TabIndex = 80;
			this.label2.Text = "HISTORIAL PRUEBAS";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnFiltros
			// 
			this.pnFiltros.Controls.Add(this.txtBusqueda);
			this.pnFiltros.Controls.Add(this.label1);
			this.pnFiltros.Controls.Add(this.dtpFin);
			this.pnFiltros.Controls.Add(this.dtpInicio);
			this.pnFiltros.Controls.Add(this.label8);
			this.pnFiltros.Enabled = false;
			this.pnFiltros.Location = new System.Drawing.Point(2, 35);
			this.pnFiltros.Name = "pnFiltros";
			this.pnFiltros.Size = new System.Drawing.Size(404, 37);
			this.pnFiltros.TabIndex = 81;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(87, 7);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
			this.txtBusqueda.TabIndex = 75;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 23);
			this.label1.TabIndex = 76;
			this.label1.Text = "VEHICULO";
			// 
			// dtpFin
			// 
			this.dtpFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(306, 8);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(90, 20);
			this.dtpFin.TabIndex = 72;
			// 
			// dtpInicio
			// 
			this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(195, 8);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(91, 20);
			this.dtpInicio.TabIndex = 71;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(284, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 14);
			this.label8.TabIndex = 73;
			this.label8.Text = "A";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// gbFiltros
			// 
			this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbFiltros.Controls.Add(this.lblMostrar);
			this.gbFiltros.Controls.Add(this.pnFiltros);
			this.gbFiltros.Controls.Add(this.label2);
			this.gbFiltros.Controls.Add(this.cmdImprimir);
			this.gbFiltros.Controls.Add(this.bntBuscar);
			this.gbFiltros.Controls.Add(this.cbTodas);
			this.gbFiltros.Controls.Add(this.dgHistorial);
			this.gbFiltros.Location = new System.Drawing.Point(363, 5);
			this.gbFiltros.Name = "gbFiltros";
			this.gbFiltros.Size = new System.Drawing.Size(634, 615);
			this.gbFiltros.TabIndex = 80;
			this.gbFiltros.TabStop = false;
			this.gbFiltros.Visible = false;
			// 
			// lblMostrar
			// 
			this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMostrar.Image = ((System.Drawing.Image)(resources.GetObject("lblMostrar.Image")));
			this.lblMostrar.Location = new System.Drawing.Point(0, 305);
			this.lblMostrar.Name = "lblMostrar";
			this.lblMostrar.Size = new System.Drawing.Size(31, 38);
			this.lblMostrar.TabIndex = 77;
			this.lblMostrar.Click += new System.EventHandler(this.LblMostrarClick);
			// 
			// btnImprimirHst
			// 
			this.btnImprimirHst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImprimirHst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimirHst.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirHst.Image")));
			this.btnImprimirHst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnImprimirHst.Location = new System.Drawing.Point(907, 220);
			this.btnImprimirHst.Name = "btnImprimirHst";
			this.btnImprimirHst.Size = new System.Drawing.Size(91, 43);
			this.btnImprimirHst.TabIndex = 113;
			this.btnImprimirHst.Text = "Historial";
			this.btnImprimirHst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnImprimirHst.UseVisualStyleBackColor = true;
			this.btnImprimirHst.Click += new System.EventHandler(this.BtnImprimirHstClick);
			// 
			// txtbusUnidad
			// 
			this.txtbusUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtbusUnidad.Location = new System.Drawing.Point(905, 105);
			this.txtbusUnidad.Name = "txtbusUnidad";
			this.txtbusUnidad.Size = new System.Drawing.Size(93, 20);
			this.txtbusUnidad.TabIndex = 111;
			this.txtbusUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtbusUnidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbusUnidadKeyUp);
			// 
			// label33
			// 
			this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.Location = new System.Drawing.Point(903, 87);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(91, 15);
			this.label33.TabIndex = 112;
			this.label33.Text = "Unidad";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormPruebaRendimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 626);
			this.Controls.Add(this.gbFiltros);
			this.Controls.Add(this.dgPruebaRendimiento);
			this.Controls.Add(this.btnReporte);
			this.Controls.Add(this.pbConfiguraciones);
			this.Controls.Add(this.txtbusUnidad);
			this.Controls.Add(this.label33);
			this.Controls.Add(this.btnImprimirHst);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPruebaRendimiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prueba Rendimiento";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPruebaRendimientoFormClosing);
			this.Load += new System.EventHandler(this.FormPruebaRendimientoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgPruebaRendimiento)).EndInit();
			this.MenuRendiemiento.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
			this.pnFiltros.ResumeLayout(false);
			this.pnFiltros.PerformLayout();
			this.gbFiltros.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnImprimirHst;
		private System.Windows.Forms.DataGridViewTextBoxColumn KM_BASE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID0;
		private System.Windows.Forms.DataGridViewTextBoxColumn SEGUIMIENTOA;
		private System.Windows.Forms.DataGridViewTextBoxColumn LITROS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RH;
		private System.Windows.Forms.DataGridViewTextBoxColumn P5;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID5;
		private System.Windows.Forms.DataGridViewTextBoxColumn P4;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID4;
		private System.Windows.Forms.DataGridViewTextBoxColumn P3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID3;
		private System.Windows.Forms.DataGridViewTextBoxColumn P2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
		private System.Windows.Forms.DataGridViewTextBoxColumn P1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox txtbusUnidad;
		private System.Windows.Forms.Label lblMostrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADORP;
		private System.Windows.Forms.DataGridViewTextBoxColumn SEGUIMIENTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PREVPRUEBA;
		private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIO;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbConfiguraciones;
		private System.Windows.Forms.Panel pnFiltros;
		private System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.ToolStripMenuItem historialPruebasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuebaPruebaToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuRendiemiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_R;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_O;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn KM_F;
		private System.Windows.Forms.DataGridViewTextBoxColumn KM_I;
		private System.Windows.Forms.DataGridViewTextBoxColumn LITROS_CF;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA_FIN;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA_INICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHAP;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADORH;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		public System.Windows.Forms.DataGridView dgHistorial;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.CheckBox cbTodas;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.Button cmdImprimir;
		private System.Windows.Forms.GroupBox gbFiltros;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_PRUEBA;
		private System.Windows.Forms.DataGridViewTextBoxColumn RENDIMIENTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_ope;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_V;
		public System.Windows.Forms.DataGridView dgPruebaRendimiento;
	}
}
