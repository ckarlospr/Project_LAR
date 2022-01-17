/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 15/02/2013
 * Time: 10:28 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormReporteVentas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVentas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label12 = new System.Windows.Forms.Label();
			this.dtFechaEspecialFin = new System.Windows.Forms.DateTimePicker();
			this.dtFechaEspecialInicio = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.dataViajesEspeciales = new System.Windows.Forms.DataGridView();
			this.btnExcel = new System.Windows.Forms.Button();
			this.tabControlReportes = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnExcel2 = new System.Windows.Forms.Button();
			this.dataViajesEspeciales2 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Carro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataViajesEspeciales)).BeginInit();
			this.tabControlReportes.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataViajesEspeciales2)).BeginInit();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(179, 45);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(39, 14);
			this.label12.TabIndex = 53;
			this.label12.Text = "Entre:";
			// 
			// dtFechaEspecialFin
			// 
			this.dtFechaEspecialFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaEspecialFin.Location = new System.Drawing.Point(224, 42);
			this.dtFechaEspecialFin.Name = "dtFechaEspecialFin";
			this.dtFechaEspecialFin.Size = new System.Drawing.Size(79, 20);
			this.dtFechaEspecialFin.TabIndex = 51;
			this.dtFechaEspecialFin.ValueChanged += new System.EventHandler(this.DtFechaEspecialFinValueChanged);
			// 
			// dtFechaEspecialInicio
			// 
			this.dtFechaEspecialInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaEspecialInicio.Location = new System.Drawing.Point(57, 42);
			this.dtFechaEspecialInicio.Name = "dtFechaEspecialInicio";
			this.dtFechaEspecialInicio.Size = new System.Drawing.Size(79, 20);
			this.dtFechaEspecialInicio.TabIndex = 50;
			this.dtFechaEspecialInicio.ValueChanged += new System.EventHandler(this.DtFechaEspecialInicioValueChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(9, 45);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 14);
			this.label10.TabIndex = 52;
			this.label10.Text = "Fecha:";
			// 
			// dataViajesEspeciales
			// 
			this.dataViajesEspeciales.AllowUserToAddRows = false;
			this.dataViajesEspeciales.AllowUserToDeleteRows = false;
			this.dataViajesEspeciales.AllowUserToResizeRows = false;
			this.dataViajesEspeciales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataViajesEspeciales.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataViajesEspeciales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataViajesEspeciales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataViajesEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataViajesEspeciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_RE,
									this.Nombre,
									this.Carro,
									this.Destino,
									this.Sentido,
									this.Precio,
									this.Fecha_salida,
									this.FACTURA,
									this.DOM,
									this.Observaciones});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataViajesEspeciales.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataViajesEspeciales.Location = new System.Drawing.Point(3, 6);
			this.dataViajesEspeciales.Name = "dataViajesEspeciales";
			this.dataViajesEspeciales.ReadOnly = true;
			this.dataViajesEspeciales.RowHeadersVisible = false;
			this.dataViajesEspeciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataViajesEspeciales.Size = new System.Drawing.Size(1006, 252);
			this.dataViajesEspeciales.TabIndex = 208;
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.BackColor = System.Drawing.Color.Transparent;
			this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(953, 264);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(56, 26);
			this.btnExcel.TabIndex = 209;
			this.btnExcel.Text = ".xls";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// tabControlReportes
			// 
			this.tabControlReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlReportes.Controls.Add(this.tabPage1);
			this.tabControlReportes.Controls.Add(this.tabPage2);
			this.tabControlReportes.Location = new System.Drawing.Point(9, 71);
			this.tabControlReportes.Name = "tabControlReportes";
			this.tabControlReportes.SelectedIndex = 0;
			this.tabControlReportes.Size = new System.Drawing.Size(1023, 322);
			this.tabControlReportes.TabIndex = 210;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataViajesEspeciales);
			this.tabPage1.Controls.Add(this.btnExcel);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1015, 296);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Viajes Especiales Asignados";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnExcel2);
			this.tabPage2.Controls.Add(this.dataViajesEspeciales2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1042, 296);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Viajes Especiales No Asignados";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnExcel2
			// 
			this.btnExcel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel2.BackColor = System.Drawing.Color.Transparent;
			this.btnExcel2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel2.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel2.Image")));
			this.btnExcel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel2.Location = new System.Drawing.Point(795, 261);
			this.btnExcel2.Name = "btnExcel2";
			this.btnExcel2.Size = new System.Drawing.Size(56, 29);
			this.btnExcel2.TabIndex = 210;
			this.btnExcel2.Text = ".xls";
			this.btnExcel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel2.UseVisualStyleBackColor = false;
			this.btnExcel2.Click += new System.EventHandler(this.BtnExcel2Click);
			// 
			// dataViajesEspeciales2
			// 
			this.dataViajesEspeciales2.AllowUserToAddRows = false;
			this.dataViajesEspeciales2.AllowUserToDeleteRows = false;
			this.dataViajesEspeciales2.AllowUserToResizeRows = false;
			this.dataViajesEspeciales2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataViajesEspeciales2.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataViajesEspeciales2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataViajesEspeciales2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataViajesEspeciales2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataViajesEspeciales2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Column1,
									this.Column2,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn5,
									this.Domicilio,
									this.dataGridViewTextBoxColumn6,
									this.Observacion});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataViajesEspeciales2.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataViajesEspeciales2.Location = new System.Drawing.Point(5, 3);
			this.dataViajesEspeciales2.Name = "dataViajesEspeciales2";
			this.dataViajesEspeciales2.ReadOnly = true;
			this.dataViajesEspeciales2.RowHeadersVisible = false;
			this.dataViajesEspeciales2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataViajesEspeciales2.Size = new System.Drawing.Size(848, 252);
			this.dataViajesEspeciales2.TabIndex = 209;
			this.dataViajesEspeciales2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViajesEspeciales2CellClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Alias";
			this.Column1.HeaderText = "Operador";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Numero";
			this.Column2.HeaderText = "Unidad";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "destino";
			this.dataGridViewTextBoxColumn3.HeaderText = "Destino";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 225;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
			this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 50;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_salida";
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn5.HeaderText = "Fecha Salida";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 70;
			// 
			// Domicilio
			// 
			this.Domicilio.DataPropertyName = "Domicilio";
			this.Domicilio.HeaderText = "Domicilio";
			this.Domicilio.Name = "Domicilio";
			this.Domicilio.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "FACTURA";
			this.dataGridViewTextBoxColumn6.HeaderText = "Factura";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 300;
			// 
			// Observacion
			// 
			this.Observacion.DataPropertyName = "Observacion";
			this.Observacion.HeaderText = "Observaciones";
			this.Observacion.Name = "Observacion";
			this.Observacion.ReadOnly = true;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(-3, -2);
			this.label3.MinimumSize = new System.Drawing.Size(435, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1045, 38);
			this.label3.TabIndex = 211;
			this.label3.Text = "Reporte de Ventas";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(-2, 424);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1044, 36);
			this.label1.TabIndex = 212;
			// 
			// ID_RE
			// 
			this.ID_RE.DataPropertyName = "ID_RE";
			this.ID_RE.HeaderText = "ID";
			this.ID_RE.Name = "ID_RE";
			this.ID_RE.ReadOnly = true;
			this.ID_RE.Width = 40;
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "Alias";
			this.Nombre.HeaderText = "Operador";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 120;
			// 
			// Carro
			// 
			this.Carro.DataPropertyName = "Numero";
			this.Carro.HeaderText = "Carro";
			this.Carro.Name = "Carro";
			this.Carro.ReadOnly = true;
			// 
			// Destino
			// 
			this.Destino.DataPropertyName = "destino";
			this.Destino.HeaderText = "Destino";
			this.Destino.Name = "Destino";
			this.Destino.ReadOnly = true;
			this.Destino.Width = 225;
			// 
			// Sentido
			// 
			this.Sentido.DataPropertyName = "Sentido";
			this.Sentido.HeaderText = "Sentido";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			this.Sentido.Width = 70;
			// 
			// Precio
			// 
			this.Precio.DataPropertyName = "Precio";
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			this.Precio.Width = 50;
			// 
			// Fecha_salida
			// 
			this.Fecha_salida.DataPropertyName = "fecha_salida";
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Fecha_salida.DefaultCellStyle = dataGridViewCellStyle2;
			this.Fecha_salida.HeaderText = "Fecha Salida";
			this.Fecha_salida.Name = "Fecha_salida";
			this.Fecha_salida.ReadOnly = true;
			this.Fecha_salida.Width = 70;
			// 
			// FACTURA
			// 
			this.FACTURA.DataPropertyName = "FACTURA";
			this.FACTURA.HeaderText = "Factura";
			this.FACTURA.Name = "FACTURA";
			this.FACTURA.ReadOnly = true;
			// 
			// DOM
			// 
			this.DOM.DataPropertyName = "DOMICILIO";
			this.DOM.HeaderText = "Domicilio";
			this.DOM.Name = "DOM";
			this.DOM.ReadOnly = true;
			// 
			// Observaciones
			// 
			this.Observaciones.DataPropertyName = "OBSERVACIONES";
			this.Observaciones.HeaderText = "Observaciones";
			this.Observaciones.Name = "Observaciones";
			this.Observaciones.ReadOnly = true;
			this.Observaciones.Width = 300;
			// 
			// FormReporteVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1041, 458);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tabControlReportes);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dtFechaEspecialFin);
			this.Controls.Add(this.dtFechaEspecialInicio);
			this.Controls.Add(this.label10);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(791, 404);
			this.Name = "FormReporteVentas";
			this.Text = "Reporte de Ventas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteVentasFormClosing);
			this.Load += new System.EventHandler(this.FormReporteVentasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataViajesEspeciales)).EndInit();
			this.tabControlReportes.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataViajesEspeciales2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn DOM;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
		private System.Windows.Forms.DataGridView dataViajesEspeciales2;
		public System.Windows.Forms.Button btnExcel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControlReportes;
		public System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Carro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_salida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridView dataViajesEspeciales;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtFechaEspecialInicio;
		private System.Windows.Forms.DateTimePicker dtFechaEspecialFin;
		private System.Windows.Forms.Label label12;
	}
}
