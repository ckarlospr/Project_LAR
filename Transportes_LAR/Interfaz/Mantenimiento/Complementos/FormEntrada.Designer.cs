/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 02/01/2015
 * Hora: 06:25 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	partial class FormEntrada
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
			this.dataEntrada = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFolioOrdenC = new System.Windows.Forms.TextBox();
			this.dgOCompra = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FOLIO_OC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbValidados = new System.Windows.Forms.CheckBox();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.cmdValidar = new System.Windows.Forms.Button();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.art = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataEntrada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgOCompra)).BeginInit();
			this.SuspendLayout();
			// 
			// dataEntrada
			// 
			this.dataEntrada.AllowUserToAddRows = false;
			this.dataEntrada.AllowUserToResizeRows = false;
			this.dataEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataEntrada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataEntrada.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn41,
									this.no,
									this.art,
									this.marca,
									this.model,
									this.cantidad,
									this.codigo,
									this.proveedor,
									this.origen,
									this.fecha,
									this.flujo});
			this.dataEntrada.Location = new System.Drawing.Point(183, 80);
			this.dataEntrada.Name = "dataEntrada";
			this.dataEntrada.RowHeadersVisible = false;
			this.dataEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataEntrada.Size = new System.Drawing.Size(713, 522);
			this.dataEntrada.TabIndex = 5;
			this.dataEntrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEntradaCellClick);
			this.dataEntrada.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataEntradaEditingControlShowing);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(15, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 15);
			this.label7.TabIndex = 237;
			this.label7.Text = "Folio orden:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFolioOrdenC
			// 
			this.txtFolioOrdenC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFolioOrdenC.Location = new System.Drawing.Point(85, 54);
			this.txtFolioOrdenC.Name = "txtFolioOrdenC";
			this.txtFolioOrdenC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtFolioOrdenC.Size = new System.Drawing.Size(91, 20);
			this.txtFolioOrdenC.TabIndex = 100;
			this.txtFolioOrdenC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFolioOrdenCKeyUp);
			this.txtFolioOrdenC.Leave += new System.EventHandler(this.TxtFolioOrdenCLeave);
			// 
			// dgOCompra
			// 
			this.dgOCompra.AllowUserToAddRows = false;
			this.dgOCompra.AllowUserToResizeRows = false;
			this.dgOCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgOCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgOCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgOCompra.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgOCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgOCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.FOLIO_OC,
									this.fechaOC});
			this.dgOCompra.Location = new System.Drawing.Point(12, 80);
			this.dgOCompra.Name = "dgOCompra";
			this.dgOCompra.RowHeadersVisible = false;
			this.dgOCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgOCompra.Size = new System.Drawing.Size(164, 522);
			this.dgOCompra.TabIndex = 248;
			this.dgOCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOCompraCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 24;
			// 
			// FOLIO_OC
			// 
			this.FOLIO_OC.FillWeight = 110F;
			this.FOLIO_OC.HeaderText = "FOLIO";
			this.FOLIO_OC.Name = "FOLIO_OC";
			this.FOLIO_OC.ReadOnly = true;
			this.FOLIO_OC.Width = 63;
			// 
			// fechaOC
			// 
			this.fechaOC.HeaderText = "FECHA";
			this.fechaOC.Name = "fechaOC";
			this.fechaOC.ReadOnly = true;
			this.fechaOC.Width = 67;
			// 
			// cbValidados
			// 
			this.cbValidados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbValidados.Location = new System.Drawing.Point(48, 28);
			this.cbValidados.Name = "cbValidados";
			this.cbValidados.Size = new System.Drawing.Size(84, 20);
			this.cbValidados.TabIndex = 248;
			this.cbValidados.Text = "Validados";
			this.cbValidados.UseVisualStyleBackColor = true;
			this.cbValidados.CheckedChanged += new System.EventHandler(this.CbValidadosCheckedChanged);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdAgregar.Enabled = false;
			this.cmdAgregar.Location = new System.Drawing.Point(902, 463);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(92, 41);
			this.cmdAgregar.TabIndex = 249;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// cmdValidar
			// 
			this.cmdValidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdValidar.Enabled = false;
			this.cmdValidar.Location = new System.Drawing.Point(902, 555);
			this.cmdValidar.Name = "cmdValidar";
			this.cmdValidar.Size = new System.Drawing.Size(92, 47);
			this.cmdValidar.TabIndex = 250;
			this.cmdValidar.Text = "Validar Orden de Compra";
			this.cmdValidar.UseVisualStyleBackColor = true;
			this.cmdValidar.Click += new System.EventHandler(this.CmdValidarClick);
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtpEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEntrada.Location = new System.Drawing.Point(902, 381);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(92, 20);
			this.dtpEntrada.TabIndex = 251;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(902, 423);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(92, 20);
			this.txtCantidad.TabIndex = 252;
			this.txtCantidad.Text = "0";
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dataGridViewTextBoxColumn41
			// 
			this.dataGridViewTextBoxColumn41.DataPropertyName = "Empresa";
			this.dataGridViewTextBoxColumn41.HeaderText = "ID_Entrada";
			this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn41.ReadOnly = true;
			this.dataGridViewTextBoxColumn41.Visible = false;
			this.dataGridViewTextBoxColumn41.Width = 67;
			// 
			// no
			// 
			this.no.HeaderText = "ID_Lista";
			this.no.Name = "no";
			this.no.ReadOnly = true;
			this.no.Visible = false;
			this.no.Width = 52;
			// 
			// art
			// 
			this.art.HeaderText = "Articulo";
			this.art.Name = "art";
			this.art.ReadOnly = true;
			this.art.Width = 67;
			// 
			// marca
			// 
			this.marca.HeaderText = "Marca";
			this.marca.Name = "marca";
			this.marca.ReadOnly = true;
			this.marca.Width = 62;
			// 
			// model
			// 
			this.model.HeaderText = "Modelo";
			this.model.Name = "model";
			this.model.ReadOnly = true;
			this.model.Width = 67;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			this.cantidad.Width = 74;
			// 
			// codigo
			// 
			this.codigo.HeaderText = "Codigo";
			this.codigo.Name = "codigo";
			this.codigo.ReadOnly = true;
			this.codigo.Width = 65;
			// 
			// proveedor
			// 
			this.proveedor.HeaderText = "Proveedor";
			this.proveedor.Name = "proveedor";
			this.proveedor.ReadOnly = true;
			this.proveedor.Width = 81;
			// 
			// origen
			// 
			this.origen.HeaderText = "Origen";
			this.origen.Name = "origen";
			this.origen.ReadOnly = true;
			this.origen.Width = 63;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha Ingreso";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// flujo
			// 
			this.flujo.HeaderText = "flujo";
			this.flujo.Name = "flujo";
			this.flujo.ReadOnly = true;
			this.flujo.Visible = false;
			this.flujo.Width = 51;
			// 
			// FormEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1010, 614);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.dtpEntrada);
			this.Controls.Add(this.cmdValidar);
			this.Controls.Add(this.cmdAgregar);
			this.Controls.Add(this.cbValidados);
			this.Controls.Add(this.dgOCompra);
			this.Controls.Add(this.dataEntrada);
			this.Controls.Add(this.txtFolioOrdenC);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormEntrada";
			this.Text = "FormEntrada";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormEntradaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataEntrada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgOCompra)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.Button cmdValidar;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn flujo;
		private System.Windows.Forms.CheckBox cbValidados;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaOC;
		private System.Windows.Forms.DataGridViewTextBoxColumn FOLIO_OC;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgOCompra;
		private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn model;
		private System.Windows.Forms.DataGridViewTextBoxColumn marca;
		private System.Windows.Forms.DataGridViewTextBoxColumn art;
		private System.Windows.Forms.DataGridViewTextBoxColumn no;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFolioOrdenC;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
		private System.Windows.Forms.DataGridView dataEntrada;
	}
}
