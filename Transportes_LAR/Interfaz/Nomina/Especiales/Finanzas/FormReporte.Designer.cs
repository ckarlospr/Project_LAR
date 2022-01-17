/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 08/08/2013
 * Time: 09:32 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	partial class FormReporte
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
			this.panel2 = new System.Windows.Forms.Panel();
			this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Recuperado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Deposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Anticipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgReporte = new System.Windows.Forms.DataGridView();
			this.txtAnticipo = new System.Windows.Forms.TextBox();
			this.tvFiltros = new System.Windows.Forms.TreeView();
			this.txtCobrar = new System.Windows.Forms.TextBox();
			this.cmdIncobrable = new System.Windows.Forms.Button();
			this.cmdValidar = new System.Windows.Forms.Button();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.txtCaja = new System.Windows.Forms.TextBox();
			this.txtDeposito = new System.Windows.Forms.TextBox();
			this.txtRecuperado = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmdRelacion = new System.Windows.Forms.Button();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.cbValidados = new System.Windows.Forms.CheckBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgReporte)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.tvFiltros);
			this.panel2.Location = new System.Drawing.Point(4, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(164, 441);
			this.panel2.TabIndex = 22;
			// 
			// razon
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.razon.DefaultCellStyle = dataGridViewCellStyle1;
			this.razon.HeaderText = "RAZON SOCIAL";
			this.razon.Name = "razon";
			this.razon.ReadOnly = true;
			this.razon.Width = 130;
			// 
			// flujo
			// 
			this.flujo.HeaderText = "Flujo";
			this.flujo.Name = "flujo";
			this.flujo.ReadOnly = true;
			this.flujo.Visible = false;
			this.flujo.Width = 40;
			// 
			// INCO
			// 
			this.INCO.HeaderText = "INCO";
			this.INCO.Name = "INCO";
			this.INCO.ReadOnly = true;
			this.INCO.Visible = false;
			this.INCO.Width = 30;
			// 
			// fact
			// 
			this.fact.HeaderText = "fact";
			this.fact.Name = "fact";
			this.fact.ReadOnly = true;
			this.fact.Visible = false;
			this.fact.Width = 30;
			// 
			// PAGO
			// 
			this.PAGO.HeaderText = "PAGO";
			this.PAGO.Name = "PAGO";
			this.PAGO.ReadOnly = true;
			this.PAGO.Visible = false;
			// 
			// Factura
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Factura.DefaultCellStyle = dataGridViewCellStyle2;
			this.Factura.HeaderText = "Factura";
			this.Factura.Name = "Factura";
			this.Factura.ReadOnly = true;
			// 
			// Recuperado
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Recuperado.DefaultCellStyle = dataGridViewCellStyle3;
			this.Recuperado.HeaderText = "Recuperado";
			this.Recuperado.Name = "Recuperado";
			this.Recuperado.ReadOnly = true;
			this.Recuperado.Width = 85;
			// 
			// Cobrar
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cobrar.DefaultCellStyle = dataGridViewCellStyle4;
			this.Cobrar.HeaderText = "XCobrar";
			this.Cobrar.Name = "Cobrar";
			this.Cobrar.ReadOnly = true;
			this.Cobrar.Width = 85;
			// 
			// Pagado
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pagado.DefaultCellStyle = dataGridViewCellStyle5;
			this.Pagado.HeaderText = "Cobrado";
			this.Pagado.Name = "Pagado";
			this.Pagado.ReadOnly = true;
			this.Pagado.Width = 65;
			// 
			// Deposito
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Deposito.DefaultCellStyle = dataGridViewCellStyle6;
			this.Deposito.HeaderText = "Deposito";
			this.Deposito.Name = "Deposito";
			this.Deposito.ReadOnly = true;
			this.Deposito.Width = 80;
			// 
			// Anticipo
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anticipo.DefaultCellStyle = dataGridViewCellStyle7;
			this.Anticipo.HeaderText = "Efectivo";
			this.Anticipo.Name = "Anticipo";
			this.Anticipo.ReadOnly = true;
			this.Anticipo.Width = 80;
			// 
			// Costo
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Costo.DefaultCellStyle = dataGridViewCellStyle8;
			this.Costo.HeaderText = "Costo";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			this.Costo.Width = 55;
			// 
			// FECHA_SALIDA
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA_SALIDA.DefaultCellStyle = dataGridViewCellStyle9;
			this.FECHA_SALIDA.HeaderText = "Fecha";
			this.FECHA_SALIDA.Name = "FECHA_SALIDA";
			this.FECHA_SALIDA.ReadOnly = true;
			// 
			// Viaje
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Viaje.DefaultCellStyle = dataGridViewCellStyle10;
			this.Viaje.HeaderText = "Viaje";
			this.Viaje.Name = "Viaje";
			this.Viaje.ReadOnly = true;
			this.Viaje.Width = 180;
			// 
			// RESPONSABLE
			// 
			this.RESPONSABLE.HeaderText = "RESPONSABLE";
			this.RESPONSABLE.Name = "RESPONSABLE";
			this.RESPONSABLE.ReadOnly = true;
			this.RESPONSABLE.Visible = false;
			// 
			// ID
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID.DefaultCellStyle = dataGridViewCellStyle11;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 45;
			// 
			// dgReporte
			// 
			this.dgReporte.AllowUserToAddRows = false;
			this.dgReporte.AllowUserToResizeRows = false;
			this.dgReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgReporte.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
			this.dgReporte.Location = new System.Drawing.Point(172, 12);
			this.dgReporte.MultiSelect = false;
			this.dgReporte.Name = "dgReporte";
			this.dgReporte.RowHeadersVisible = false;
			this.dgReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgReporte.Size = new System.Drawing.Size(865, 397);
			this.dgReporte.TabIndex = 0;
			this.dgReporte.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgReporteCellMouseUp);
			this.dgReporte.DoubleClick += new System.EventHandler(this.DgReporteDoubleClick);
			// 
			// txtAnticipo
			// 
			this.txtAnticipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnticipo.Location = new System.Drawing.Point(448, 432);
			this.txtAnticipo.Name = "txtAnticipo";
			this.txtAnticipo.Size = new System.Drawing.Size(100, 20);
			this.txtAnticipo.TabIndex = 5;
			this.txtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tvFiltros
			// 
			this.tvFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tvFiltros.CheckBoxes = true;
			this.tvFiltros.Location = new System.Drawing.Point(3, 3);
			this.tvFiltros.Name = "tvFiltros";
			this.tvFiltros.Size = new System.Drawing.Size(158, 435);
			this.tvFiltros.TabIndex = 0;
			this.tvFiltros.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TvFiltrosAfterCheck);
			// 
			// txtCobrar
			// 
			this.txtCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCobrar.Location = new System.Drawing.Point(766, 432);
			this.txtCobrar.Name = "txtCobrar";
			this.txtCobrar.Size = new System.Drawing.Size(100, 20);
			this.txtCobrar.TabIndex = 6;
			this.txtCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdIncobrable
			// 
			this.cmdIncobrable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdIncobrable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdIncobrable.Image = ((System.Drawing.Image)(resources.GetObject("cmdIncobrable.Image")));
			this.cmdIncobrable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdIncobrable.Location = new System.Drawing.Point(1055, 289);
			this.cmdIncobrable.Name = "cmdIncobrable";
			this.cmdIncobrable.Size = new System.Drawing.Size(91, 50);
			this.cmdIncobrable.TabIndex = 1;
			this.cmdIncobrable.Text = "Incobrable";
			this.cmdIncobrable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdIncobrable.UseVisualStyleBackColor = true;
			this.cmdIncobrable.Click += new System.EventHandler(this.CmdIncobrableClick);
			// 
			// cmdValidar
			// 
			this.cmdValidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdValidar.Image = ((System.Drawing.Image)(resources.GetObject("cmdValidar.Image")));
			this.cmdValidar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdValidar.Location = new System.Drawing.Point(1055, 359);
			this.cmdValidar.Name = "cmdValidar";
			this.cmdValidar.Size = new System.Drawing.Size(91, 50);
			this.cmdValidar.TabIndex = 2;
			this.cmdValidar.Text = "Validar";
			this.cmdValidar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdValidar.UseVisualStyleBackColor = true;
			this.cmdValidar.Click += new System.EventHandler(this.CmdValidarClick);
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
			this.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdImprimir.Location = new System.Drawing.Point(1055, 196);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.Size = new System.Drawing.Size(91, 43);
			this.cmdImprimir.TabIndex = 3;
			this.cmdImprimir.Text = "Imprimir";
			this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdImprimir.UseVisualStyleBackColor = true;
			this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
			// 
			// txtCosto
			// 
			this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCosto.Location = new System.Drawing.Point(342, 432);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(100, 20);
			this.txtCosto.TabIndex = 4;
			this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCaja
			// 
			this.txtCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCaja.Location = new System.Drawing.Point(660, 432);
			this.txtCaja.Name = "txtCaja";
			this.txtCaja.Size = new System.Drawing.Size(100, 20);
			this.txtCaja.TabIndex = 7;
			this.txtCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDeposito
			// 
			this.txtDeposito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDeposito.Location = new System.Drawing.Point(554, 432);
			this.txtDeposito.Name = "txtDeposito";
			this.txtDeposito.Size = new System.Drawing.Size(100, 20);
			this.txtDeposito.TabIndex = 8;
			this.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRecuperado
			// 
			this.txtRecuperado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtRecuperado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecuperado.Location = new System.Drawing.Point(872, 433);
			this.txtRecuperado.Name = "txtRecuperado";
			this.txtRecuperado.Size = new System.Drawing.Size(100, 20);
			this.txtRecuperado.TabIndex = 9;
			this.txtRecuperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(342, 411);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Costo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(448, 411);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Efectivo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(872, 412);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 18);
			this.label3.TabIndex = 12;
			this.label3.Text = "Recuperado";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(766, 411);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 18);
			this.label4.TabIndex = 13;
			this.label4.Text = "X Cobrar";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(660, 411);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 14;
			this.label5.Text = "Cobrado";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(554, 411);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 18);
			this.label6.TabIndex = 15;
			this.label6.Text = "Deposito";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(247, 411);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 41);
			this.label7.TabIndex = 16;
			this.label7.Text = "Totales:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cmdRelacion
			// 
			this.cmdRelacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRelacion.Image = ((System.Drawing.Image)(resources.GetObject("cmdRelacion.Image")));
			this.cmdRelacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdRelacion.Location = new System.Drawing.Point(1055, 127);
			this.cmdRelacion.Name = "cmdRelacion";
			this.cmdRelacion.Size = new System.Drawing.Size(91, 43);
			this.cmdRelacion.TabIndex = 17;
			this.cmdRelacion.Text = "Relación";
			this.cmdRelacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdRelacion.UseVisualStyleBackColor = true;
			this.cmdRelacion.Click += new System.EventHandler(this.CmdRelacionClick);
			// 
			// dtpInicio
			// 
			this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(1055, 69);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(91, 20);
			this.dtpInicio.TabIndex = 18;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(1055, 95);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(91, 20);
			this.dtpFin.TabIndex = 19;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(1055, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 14);
			this.label8.TabIndex = 20;
			this.label8.Text = "Rango";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cbValidados
			// 
			this.cbValidados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbValidados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbValidados.Location = new System.Drawing.Point(1061, 18);
			this.cbValidados.Name = "cbValidados";
			this.cbValidados.Size = new System.Drawing.Size(91, 24);
			this.cbValidados.TabIndex = 21;
			this.cbValidados.Text = "Validados";
			this.cbValidados.UseVisualStyleBackColor = true;
			this.cbValidados.CheckedChanged += new System.EventHandler(this.CbValidadosCheckedChanged);
			// 
			// FormReporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1158, 461);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.cbValidados);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dtpInicio);
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
			this.Controls.Add(this.txtCobrar);
			this.Controls.Add(this.txtAnticipo);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.cmdImprimir);
			this.Controls.Add(this.cmdValidar);
			this.Controls.Add(this.cmdIncobrable);
			this.Controls.Add(this.dgReporte);
			this.Name = "FormReporte";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reporte general de servicios realizados";
			this.Load += new System.EventHandler(this.FormReporteLoad);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgReporte)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TreeView tvFiltros;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn razon;
		private System.Windows.Forms.DataGridViewTextBoxColumn flujo;
		private System.Windows.Forms.CheckBox cbValidados;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.Button cmdRelacion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRecuperado;
		private System.Windows.Forms.TextBox txtDeposito;
		private System.Windows.Forms.TextBox txtCaja;
		private System.Windows.Forms.TextBox txtCobrar;
		private System.Windows.Forms.TextBox txtAnticipo;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Button cmdImprimir;
		private System.Windows.Forms.DataGridViewTextBoxColumn INCO;
		private System.Windows.Forms.DataGridViewTextBoxColumn fact;
		private System.Windows.Forms.DataGridViewTextBoxColumn PAGO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
		private System.Windows.Forms.Button cmdValidar;
		private System.Windows.Forms.Button cmdIncobrable;
		private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
		private System.Windows.Forms.DataGridViewTextBoxColumn Recuperado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cobrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Deposito;
		private System.Windows.Forms.DataGridViewTextBoxColumn Anticipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Viaje;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dgReporte;
	}
}
