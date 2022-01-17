/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 29/01/2016
 * Hora: 12:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Validacion_Final
{
	partial class FormValidarServicios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidarServicios));
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
			this.cbValidados = new System.Windows.Forms.CheckBox();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.cmdRelacion = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRecuperado = new System.Windows.Forms.TextBox();
			this.txtDeposito = new System.Windows.Forms.TextBox();
			this.txtCaja = new System.Windows.Forms.TextBox();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.cmdValidar = new System.Windows.Forms.Button();
			this.txtCobrar = new System.Windows.Forms.TextBox();
			this.txtAnticipo = new System.Windows.Forms.TextBox();
			this.dgReporte = new System.Windows.Forms.DataGridView();
			this.cbBusqueda = new System.Windows.Forms.ComboBox();
			this.txtBusquedaCotizacion = new System.Windows.Forms.TextBox();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.gbFiltros = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Anticipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Deposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Recuperado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
			this.gbFiltros.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbValidados
			// 
			this.cbValidados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbValidados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbValidados.Location = new System.Drawing.Point(557, 20);
			this.cbValidados.Name = "cbValidados";
			this.cbValidados.Size = new System.Drawing.Size(91, 24);
			this.cbValidados.TabIndex = 44;
			this.cbValidados.Text = "Validados";
			this.cbValidados.UseVisualStyleBackColor = true;
			this.cbValidados.CheckedChanged += new System.EventHandler(this.CbValidadosCheckedChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(442, 22);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(91, 20);
			this.dtpFin.TabIndex = 42;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// dtpInicio
			// 
			this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(325, 21);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(91, 20);
			this.dtpInicio.TabIndex = 41;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// cmdRelacion
			// 
			this.cmdRelacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRelacion.Image = ((System.Drawing.Image)(resources.GetObject("cmdRelacion.Image")));
			this.cmdRelacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdRelacion.Location = new System.Drawing.Point(1010, 15);
			this.cmdRelacion.Name = "cmdRelacion";
			this.cmdRelacion.Size = new System.Drawing.Size(91, 43);
			this.cmdRelacion.TabIndex = 40;
			this.cmdRelacion.Text = "Relación";
			this.cmdRelacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdRelacion.UseVisualStyleBackColor = true;
			this.cmdRelacion.Click += new System.EventHandler(this.CmdRelacionClick);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(29, 555);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 41);
			this.label7.TabIndex = 39;
			this.label7.Text = "Totales:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(336, 555);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 18);
			this.label6.TabIndex = 38;
			this.label6.Text = "Deposito";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(442, 555);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 37;
			this.label5.Text = "Cobrado";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(548, 555);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 18);
			this.label4.TabIndex = 36;
			this.label4.Text = "X Cobrar";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(654, 556);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 18);
			this.label3.TabIndex = 35;
			this.label3.Text = "Recuperado";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(230, 555);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 18);
			this.label2.TabIndex = 34;
			this.label2.Text = "Efectivo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(124, 555);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 33;
			this.label1.Text = "Costo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtRecuperado
			// 
			this.txtRecuperado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtRecuperado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecuperado.Location = new System.Drawing.Point(654, 577);
			this.txtRecuperado.Name = "txtRecuperado";
			this.txtRecuperado.Size = new System.Drawing.Size(100, 20);
			this.txtRecuperado.TabIndex = 32;
			this.txtRecuperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDeposito
			// 
			this.txtDeposito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDeposito.Location = new System.Drawing.Point(336, 576);
			this.txtDeposito.Name = "txtDeposito";
			this.txtDeposito.Size = new System.Drawing.Size(100, 20);
			this.txtDeposito.TabIndex = 31;
			this.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCaja
			// 
			this.txtCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCaja.Location = new System.Drawing.Point(442, 576);
			this.txtCaja.Name = "txtCaja";
			this.txtCaja.Size = new System.Drawing.Size(100, 20);
			this.txtCaja.TabIndex = 30;
			this.txtCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCosto
			// 
			this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCosto.Location = new System.Drawing.Point(124, 576);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(100, 20);
			this.txtCosto.TabIndex = 27;
			this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
			this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdImprimir.Location = new System.Drawing.Point(1109, 15);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.Size = new System.Drawing.Size(91, 43);
			this.cmdImprimir.TabIndex = 26;
			this.cmdImprimir.Text = "Imprimir";
			this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdImprimir.UseVisualStyleBackColor = true;
			this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
			// 
			// cmdValidar
			// 
			this.cmdValidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdValidar.Image = ((System.Drawing.Image)(resources.GetObject("cmdValidar.Image")));
			this.cmdValidar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdValidar.Location = new System.Drawing.Point(1109, 556);
			this.cmdValidar.Name = "cmdValidar";
			this.cmdValidar.Size = new System.Drawing.Size(91, 50);
			this.cmdValidar.TabIndex = 25;
			this.cmdValidar.Text = "Validar";
			this.cmdValidar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdValidar.UseVisualStyleBackColor = true;
			this.cmdValidar.Click += new System.EventHandler(this.CmdValidarClick);
			// 
			// txtCobrar
			// 
			this.txtCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCobrar.Location = new System.Drawing.Point(548, 576);
			this.txtCobrar.Name = "txtCobrar";
			this.txtCobrar.Size = new System.Drawing.Size(100, 20);
			this.txtCobrar.TabIndex = 29;
			this.txtCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtAnticipo
			// 
			this.txtAnticipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnticipo.Location = new System.Drawing.Point(230, 576);
			this.txtAnticipo.Name = "txtAnticipo";
			this.txtAnticipo.Size = new System.Drawing.Size(100, 20);
			this.txtAnticipo.TabIndex = 28;
			this.txtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dgReporte
			// 
			this.dgReporte.AllowUserToAddRows = false;
			this.dgReporte.AllowUserToResizeRows = false;
			this.dgReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgReporte.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.RESPONSABLE,
									this.Viaje,
									this.FECHA_SALIDA,
									this.Costo,
									this.Anticipo,
									this.Deposito,
									this.Pagado,
									this.Cobrar,
									this.Recuperado,
									this.Factura,
									this.PAGO,
									this.fact,
									this.INCO,
									this.flujo,
									this.razon});
			this.dgReporte.Location = new System.Drawing.Point(9, 71);
			this.dgReporte.MultiSelect = false;
			this.dgReporte.Name = "dgReporte";
			this.dgReporte.RowHeadersVisible = false;
			this.dgReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgReporte.Size = new System.Drawing.Size(1194, 472);
			this.dgReporte.TabIndex = 23;
			this.dgReporte.DoubleClick += new System.EventHandler(this.DgReporteDoubleClick);
			// 
			// cbBusqueda
			// 
			this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBusqueda.FormattingEnabled = true;
			this.cbBusqueda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbBusqueda.Items.AddRange(new object[] {
									"ID",
									"CONTACTO",
									"DESTINO",
									"FACTURA",
									"RAZÓN SOCIAL"});
			this.cbBusqueda.Location = new System.Drawing.Point(36, 19);
			this.cbBusqueda.Name = "cbBusqueda";
			this.cbBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbBusqueda.Size = new System.Drawing.Size(108, 21);
			this.cbBusqueda.TabIndex = 50;
			// 
			// txtBusquedaCotizacion
			// 
			this.txtBusquedaCotizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusquedaCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusquedaCotizacion.Location = new System.Drawing.Point(150, 20);
			this.txtBusquedaCotizacion.Name = "txtBusquedaCotizacion";
			this.txtBusquedaCotizacion.Size = new System.Drawing.Size(133, 20);
			this.txtBusquedaCotizacion.TabIndex = 51;
			// 
			// bntBuscar
			// 
			this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
			this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bntBuscar.Location = new System.Drawing.Point(806, 15);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(95, 45);
			this.bntBuscar.TabIndex = 61;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.BntBuscarClick);
			// 
			// gbFiltros
			// 
			this.gbFiltros.Controls.Add(this.cbBusqueda);
			this.gbFiltros.Controls.Add(this.txtBusquedaCotizacion);
			this.gbFiltros.Controls.Add(this.dtpFin);
			this.gbFiltros.Controls.Add(this.dtpInicio);
			this.gbFiltros.Controls.Add(this.cbValidados);
			this.gbFiltros.Controls.Add(this.label8);
			this.gbFiltros.Location = new System.Drawing.Point(9, 5);
			this.gbFiltros.Name = "gbFiltros";
			this.gbFiltros.Size = new System.Drawing.Size(791, 60);
			this.gbFiltros.TabIndex = 62;
			this.gbFiltros.TabStop = false;
			this.gbFiltros.Text = "Filtros";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(417, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 14);
			this.label8.TabIndex = 43;
			this.label8.Text = "A";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// ID
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID.FillWeight = 30F;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// RESPONSABLE
			// 
			this.RESPONSABLE.HeaderText = "RESPONSABLE";
			this.RESPONSABLE.Name = "RESPONSABLE";
			this.RESPONSABLE.ReadOnly = true;
			this.RESPONSABLE.Visible = false;
			// 
			// Viaje
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Viaje.DefaultCellStyle = dataGridViewCellStyle3;
			this.Viaje.FillWeight = 150F;
			this.Viaje.HeaderText = "Viaje";
			this.Viaje.Name = "Viaje";
			this.Viaje.ReadOnly = true;
			// 
			// FECHA_SALIDA
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA_SALIDA.DefaultCellStyle = dataGridViewCellStyle4;
			this.FECHA_SALIDA.FillWeight = 65.32995F;
			this.FECHA_SALIDA.HeaderText = "Fecha";
			this.FECHA_SALIDA.Name = "FECHA_SALIDA";
			this.FECHA_SALIDA.ReadOnly = true;
			// 
			// Costo
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Costo.DefaultCellStyle = dataGridViewCellStyle5;
			this.Costo.FillWeight = 65.32995F;
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			// 
			// Anticipo
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anticipo.DefaultCellStyle = dataGridViewCellStyle6;
			this.Anticipo.FillWeight = 65.32995F;
			this.Anticipo.HeaderText = "Efectivo";
			this.Anticipo.Name = "Anticipo";
			this.Anticipo.ReadOnly = true;
			// 
			// Deposito
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deposito.DefaultCellStyle = dataGridViewCellStyle7;
			this.Deposito.FillWeight = 65.32995F;
			this.Deposito.HeaderText = "Deposito";
			this.Deposito.Name = "Deposito";
			this.Deposito.ReadOnly = true;
			// 
			// Pagado
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pagado.DefaultCellStyle = dataGridViewCellStyle8;
			this.Pagado.FillWeight = 65.32995F;
			this.Pagado.HeaderText = "Cobrado";
			this.Pagado.Name = "Pagado";
			this.Pagado.ReadOnly = true;
			// 
			// Cobrar
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cobrar.DefaultCellStyle = dataGridViewCellStyle9;
			this.Cobrar.FillWeight = 65.32995F;
			this.Cobrar.HeaderText = "XCobrar";
			this.Cobrar.Name = "Cobrar";
			this.Cobrar.ReadOnly = true;
			// 
			// Recuperado
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Recuperado.DefaultCellStyle = dataGridViewCellStyle10;
			this.Recuperado.FillWeight = 65.32995F;
			this.Recuperado.HeaderText = "Recuperado";
			this.Recuperado.Name = "Recuperado";
			this.Recuperado.ReadOnly = true;
			// 
			// Factura
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Factura.DefaultCellStyle = dataGridViewCellStyle11;
			this.Factura.FillWeight = 65.32995F;
			this.Factura.HeaderText = "Factura";
			this.Factura.Name = "Factura";
			this.Factura.ReadOnly = true;
			// 
			// PAGO
			// 
			this.PAGO.HeaderText = "PAGO";
			this.PAGO.Name = "PAGO";
			this.PAGO.ReadOnly = true;
			this.PAGO.Visible = false;
			// 
			// fact
			// 
			this.fact.HeaderText = "fact";
			this.fact.Name = "fact";
			this.fact.ReadOnly = true;
			this.fact.Visible = false;
			// 
			// INCO
			// 
			this.INCO.HeaderText = "INCO";
			this.INCO.Name = "INCO";
			this.INCO.ReadOnly = true;
			this.INCO.Visible = false;
			// 
			// flujo
			// 
			this.flujo.HeaderText = "Flujo";
			this.flujo.Name = "flujo";
			this.flujo.ReadOnly = true;
			this.flujo.Visible = false;
			// 
			// razon
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.razon.DefaultCellStyle = dataGridViewCellStyle12;
			this.razon.FillWeight = 90F;
			this.razon.HeaderText = "RAZON SOCIAL";
			this.razon.Name = "razon";
			this.razon.ReadOnly = true;
			// 
			// FormValidarServicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1215, 611);
			this.Controls.Add(this.gbFiltros);
			this.Controls.Add(this.bntBuscar);
			this.Controls.Add(this.cmdRelacion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRecuperado);
			this.Controls.Add(this.txtDeposito);
			this.Controls.Add(this.txtCaja);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.cmdImprimir);
			this.Controls.Add(this.cmdValidar);
			this.Controls.Add(this.txtCobrar);
			this.Controls.Add(this.txtAnticipo);
			this.Controls.Add(this.dgReporte);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormValidarServicios";
			this.Text = "Validación de Servicios";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormValidarServiciosFormClosing);
			this.Load += new System.EventHandler(this.FormValidarServiciosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
			this.gbFiltros.ResumeLayout(false);
			this.gbFiltros.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox gbFiltros;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.TextBox txtBusquedaCotizacion;
		private System.Windows.Forms.ComboBox cbBusqueda;
		private System.Windows.Forms.DataGridViewTextBoxColumn razon;
		private System.Windows.Forms.DataGridViewTextBoxColumn flujo;
		private System.Windows.Forms.DataGridViewTextBoxColumn INCO;
		private System.Windows.Forms.DataGridViewTextBoxColumn fact;
		private System.Windows.Forms.DataGridViewTextBoxColumn PAGO;
		private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
		private System.Windows.Forms.DataGridViewTextBoxColumn Recuperado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cobrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Deposito;
		private System.Windows.Forms.DataGridViewTextBoxColumn Anticipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Viaje;
		private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dgReporte;
		private System.Windows.Forms.TextBox txtAnticipo;
		private System.Windows.Forms.TextBox txtCobrar;
		private System.Windows.Forms.Button cmdValidar;
		private System.Windows.Forms.Button cmdImprimir;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.TextBox txtCaja;
		private System.Windows.Forms.TextBox txtDeposito;
		private System.Windows.Forms.TextBox txtRecuperado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button cmdRelacion;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox cbValidados;
	}
}
