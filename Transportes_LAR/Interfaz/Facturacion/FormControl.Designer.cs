/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 22/12/2016
 * Hora: 10:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Facturacion
{
	partial class FormControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControl));
			this.dgOrdenFactura = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Factura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pagado = new System.Windows.Forms.DataGridViewImageColumn();
			this.cMenuFactura = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmFacturar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmPagada = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmElimina = new System.Windows.Forms.ToolStripMenuItem();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtFactura = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbPagadas = new System.Windows.Forms.CheckBox();
			this.cbEliminadas = new System.Windows.Forms.CheckBox();
			this.txtBusquedaOrdenFactura = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpInicioOrdenFactura = new System.Windows.Forms.DateTimePicker();
			this.cbEliminadasOrdenFactura = new System.Windows.Forms.CheckBox();
			this.dtpFinOrdenFactura = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgOrdenFactura)).BeginInit();
			this.cMenuFactura.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgOrdenFactura
			// 
			this.dgOrdenFactura.AllowUserToAddRows = false;
			this.dgOrdenFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOrdenFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgOrdenFactura.BackgroundColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOrdenFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgOrdenFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOrdenFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn4,
									this.Estado,
									this.dataGridViewTextBoxColumn54,
									this.FechaR,
									this.Fecha,
									this.Factura1,
									this.ID_RES,
									this.dataGridViewTextBoxColumn53,
									this.dataGridViewTextBoxColumn56,
									this.IVA,
									this.TOTAL,
									this.Dia,
									this.Vencimiento,
									this.dataGridViewTextBoxColumn5,
									this.Usuario,
									this.Pagado});
			this.dgOrdenFactura.ContextMenuStrip = this.cMenuFactura;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgOrdenFactura.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgOrdenFactura.Location = new System.Drawing.Point(3, 57);
			this.dgOrdenFactura.MultiSelect = false;
			this.dgOrdenFactura.Name = "dgOrdenFactura";
			this.dgOrdenFactura.RowHeadersVisible = false;
			this.dgOrdenFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgOrdenFactura.Size = new System.Drawing.Size(1062, 414);
			this.dgOrdenFactura.TabIndex = 8;
			this.dgOrdenFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrdenFacturaCellDoubleClick);
			this.dgOrdenFactura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgOrdenFacturaMouseDown);
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.FillWeight = 40F;
			this.dataGridViewTextBoxColumn4.HeaderText = "ID";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// Estado
			// 
			this.Estado.FillWeight = 70F;
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			// 
			// dataGridViewTextBoxColumn54
			// 
			this.dataGridViewTextBoxColumn54.FillWeight = 150F;
			this.dataGridViewTextBoxColumn54.HeaderText = "CLIENTE";
			this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
			this.dataGridViewTextBoxColumn54.ReadOnly = true;
			// 
			// FechaR
			// 
			this.FechaR.FillWeight = 75.69741F;
			this.FechaR.HeaderText = "Reporte";
			this.FechaR.Name = "FechaR";
			// 
			// Fecha
			// 
			this.Fecha.FillWeight = 75.69741F;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			// 
			// Factura1
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Factura1.DefaultCellStyle = dataGridViewCellStyle5;
			this.Factura1.FillWeight = 52.98819F;
			this.Factura1.HeaderText = "Factura";
			this.Factura1.Name = "Factura1";
			this.Factura1.ReadOnly = true;
			// 
			// ID_RES
			// 
			this.ID_RES.FillWeight = 60.55793F;
			this.ID_RES.HeaderText = "Inicio";
			this.ID_RES.Name = "ID_RES";
			this.ID_RES.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn53
			// 
			this.dataGridViewTextBoxColumn53.FillWeight = 75.69741F;
			this.dataGridViewTextBoxColumn53.HeaderText = "Fin";
			this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
			this.dataGridViewTextBoxColumn53.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn56
			// 
			this.dataGridViewTextBoxColumn56.FillWeight = 65F;
			this.dataGridViewTextBoxColumn56.HeaderText = "IMPORTE";
			this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
			this.dataGridViewTextBoxColumn56.ReadOnly = true;
			// 
			// IVA
			// 
			this.IVA.FillWeight = 50F;
			this.IVA.HeaderText = "IVA";
			this.IVA.Name = "IVA";
			this.IVA.ReadOnly = true;
			// 
			// TOTAL
			// 
			this.TOTAL.FillWeight = 60.55793F;
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			// 
			// Dia
			// 
			this.Dia.FillWeight = 85F;
			this.Dia.HeaderText = "Día Cobro";
			this.Dia.Name = "Dia";
			// 
			// Vencimiento
			// 
			this.Vencimiento.FillWeight = 70F;
			this.Vencimiento.HeaderText = "Vencimiento";
			this.Vencimiento.Name = "Vencimiento";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Observaciones";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// Usuario
			// 
			this.Usuario.FillWeight = 60F;
			this.Usuario.HeaderText = "Usuario";
			this.Usuario.Name = "Usuario";
			// 
			// Pagado
			// 
			this.Pagado.FillWeight = 35F;
			this.Pagado.HeaderText = "Pagar";
			this.Pagado.Image = ((System.Drawing.Image)(resources.GetObject("Pagado.Image")));
			this.Pagado.Name = "Pagado";
			// 
			// cMenuFactura
			// 
			this.cMenuFactura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsmFacturar,
									this.tsmPagada,
									this.tsmElimina});
			this.cMenuFactura.Name = "cMenuFactura";
			this.cMenuFactura.Size = new System.Drawing.Size(160, 70);
			// 
			// tsmFacturar
			// 
			this.tsmFacturar.Image = ((System.Drawing.Image)(resources.GetObject("tsmFacturar.Image")));
			this.tsmFacturar.Name = "tsmFacturar";
			this.tsmFacturar.Size = new System.Drawing.Size(159, 22);
			this.tsmFacturar.Text = "Facturar";
			this.tsmFacturar.Click += new System.EventHandler(this.TsmFacturarClick);
			// 
			// tsmPagada
			// 
			this.tsmPagada.Image = ((System.Drawing.Image)(resources.GetObject("tsmPagada.Image")));
			this.tsmPagada.Name = "tsmPagada";
			this.tsmPagada.Size = new System.Drawing.Size(159, 22);
			this.tsmPagada.Text = "Pagada";
			this.tsmPagada.Click += new System.EventHandler(this.TsmPagadaClick);
			// 
			// tsmElimina
			// 
			this.tsmElimina.Image = ((System.Drawing.Image)(resources.GetObject("tsmElimina.Image")));
			this.tsmElimina.Name = "tsmElimina";
			this.tsmElimina.Size = new System.Drawing.Size(159, 22);
			this.tsmElimina.Text = "Eliminar Factura";
			this.tsmElimina.Click += new System.EventHandler(this.TsmEliminaClick);
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel6.Controls.Add(this.txtFactura);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Controls.Add(this.cbPagadas);
			this.panel6.Controls.Add(this.cbEliminadas);
			this.panel6.Controls.Add(this.txtBusquedaOrdenFactura);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.dtpInicioOrdenFactura);
			this.panel6.Controls.Add(this.cbEliminadasOrdenFactura);
			this.panel6.Controls.Add(this.dtpFinOrdenFactura);
			this.panel6.Controls.Add(this.label10);
			this.panel6.Controls.Add(this.label11);
			this.panel6.Location = new System.Drawing.Point(2, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1063, 49);
			this.panel6.TabIndex = 149;
			// 
			// txtFactura
			// 
			this.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFactura.Location = new System.Drawing.Point(532, 22);
			this.txtFactura.Name = "txtFactura";
			this.txtFactura.Size = new System.Drawing.Size(82, 20);
			this.txtFactura.TabIndex = 4;
			this.txtFactura.TextChanged += new System.EventHandler(this.TxtFacturaTextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(482, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 15);
			this.label3.TabIndex = 154;
			this.label3.Text = "Factura";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cbPagadas
			// 
			this.cbPagadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbPagadas.Location = new System.Drawing.Point(828, 15);
			this.cbPagadas.Name = "cbPagadas";
			this.cbPagadas.Size = new System.Drawing.Size(68, 24);
			this.cbPagadas.TabIndex = 5;
			this.cbPagadas.Text = "Pagadas";
			this.cbPagadas.UseVisualStyleBackColor = true;
			this.cbPagadas.CheckedChanged += new System.EventHandler(this.CbPagadasCheckedChanged);
			// 
			// cbEliminadas
			// 
			this.cbEliminadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbEliminadas.Location = new System.Drawing.Point(901, 15);
			this.cbEliminadas.Name = "cbEliminadas";
			this.cbEliminadas.Size = new System.Drawing.Size(78, 24);
			this.cbEliminadas.TabIndex = 6;
			this.cbEliminadas.Text = "Eliminadas";
			this.cbEliminadas.UseVisualStyleBackColor = true;
			this.cbEliminadas.CheckedChanged += new System.EventHandler(this.CbEliminadasCheckedChanged);
			// 
			// txtBusquedaOrdenFactura
			// 
			this.txtBusquedaOrdenFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusquedaOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusquedaOrdenFactura.Location = new System.Drawing.Point(287, 22);
			this.txtBusquedaOrdenFactura.Name = "txtBusquedaOrdenFactura";
			this.txtBusquedaOrdenFactura.Size = new System.Drawing.Size(187, 20);
			this.txtBusquedaOrdenFactura.TabIndex = 3;
			this.txtBusquedaOrdenFactura.Click += new System.EventHandler(this.TxtBusquedaOrdenFacturaClick);
			this.txtBusquedaOrdenFactura.TextChanged += new System.EventHandler(this.TxtBusquedaOrdenFacturaTextChanged);
			this.txtBusquedaOrdenFactura.Enter += new System.EventHandler(this.TxtBusquedaOrdenFacturaEnter);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(237, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 15);
			this.label2.TabIndex = 152;
			this.label2.Text = "Empresa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(75, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 151;
			this.label1.Text = "Fecha Factura";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dtpInicioOrdenFactura
			// 
			this.dtpInicioOrdenFactura.Enabled = false;
			this.dtpInicioOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicioOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicioOrdenFactura.Location = new System.Drawing.Point(32, 22);
			this.dtpInicioOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpInicioOrdenFactura.Name = "dtpInicioOrdenFactura";
			this.dtpInicioOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpInicioOrdenFactura.TabIndex = 1;
			this.dtpInicioOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			this.dtpInicioOrdenFactura.ValueChanged += new System.EventHandler(this.DtpInicioOrdenFacturaValueChanged);
			// 
			// cbEliminadasOrdenFactura
			// 
			this.cbEliminadasOrdenFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbEliminadasOrdenFactura.Location = new System.Drawing.Point(987, 15);
			this.cbEliminadasOrdenFactura.Name = "cbEliminadasOrdenFactura";
			this.cbEliminadasOrdenFactura.Size = new System.Drawing.Size(58, 24);
			this.cbEliminadasOrdenFactura.TabIndex = 7;
			this.cbEliminadasOrdenFactura.Text = "Todas";
			this.cbEliminadasOrdenFactura.UseVisualStyleBackColor = true;
			this.cbEliminadasOrdenFactura.CheckedChanged += new System.EventHandler(this.CbEliminadasOrdenFacturaCheckedChanged);
			// 
			// dtpFinOrdenFactura
			// 
			this.dtpFinOrdenFactura.Enabled = false;
			this.dtpFinOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinOrdenFactura.Location = new System.Drawing.Point(137, 22);
			this.dtpFinOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFinOrdenFactura.Name = "dtpFinOrdenFactura";
			this.dtpFinOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpFinOrdenFactura.TabIndex = 2;
			this.dtpFinOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			this.dtpFinOrdenFactura.ValueChanged += new System.EventHandler(this.DtpFinOrdenFacturaValueChanged);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(117, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 12);
			this.label10.TabIndex = 17;
			this.label10.Text = "al";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(5, 26);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 14;
			this.label11.Text = "Del";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// FormControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 474);
			this.Controls.Add(this.dgOrdenFactura);
			this.Controls.Add(this.panel6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormControl";
			this.Text = "Control Facturación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormControlFormClosing);
			this.Load += new System.EventHandler(this.FormControlLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgOrdenFactura)).EndInit();
			this.cMenuFactura.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFactura;
		private System.Windows.Forms.DataGridViewImageColumn Pagado;
		private System.Windows.Forms.CheckBox cbEliminadas;
		private System.Windows.Forms.CheckBox cbPagadas;
		private System.Windows.Forms.ToolStripMenuItem tsmPagada;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.ToolStripMenuItem tsmElimina;
		private System.Windows.Forms.ToolStripMenuItem tsmFacturar;
		private System.Windows.Forms.ContextMenuStrip cMenuFactura;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpFinOrdenFactura;
		private System.Windows.Forms.CheckBox cbEliminadasOrdenFactura;
		private System.Windows.Forms.DateTimePicker dtpInicioOrdenFactura;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBusquedaOrdenFactura;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RES;
		private System.Windows.Forms.DataGridViewTextBoxColumn Factura1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaR;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		public System.Windows.Forms.DataGridView dgOrdenFactura;
	}
}
