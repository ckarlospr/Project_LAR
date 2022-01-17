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
	partial class FormSalida
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
			this.dataSalida = new System.Windows.Forms.DataGridView();
			this.Id_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Medición = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado_Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Orden_Trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Intervención = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTotalProds = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTotalSal = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtIdProducto = new System.Windows.Forms.TextBox();
			this.txtOrdenTrabajo = new System.Windows.Forms.TextBox();
			this.txtCodigoBarras = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataSalida)).BeginInit();
			this.groupBox18.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataSalida
			// 
			this.dataSalida.AllowUserToAddRows = false;
			this.dataSalida.AllowUserToResizeRows = false;
			this.dataSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataSalida.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id_Salida,
									this.Cantidad,
									this.Medición,
									this.Pieza,
									this.Estado_Pieza,
									this.Codigo_Barras,
									this.Grupo,
									this.Orden_Trabajo,
									this.Fecha_Orden,
									this.Mecanico,
									this.Intervención,
									this.Vehiculo});
			this.dataSalida.Location = new System.Drawing.Point(13, 83);
			this.dataSalida.Name = "dataSalida";
			this.dataSalida.RowHeadersVisible = false;
			this.dataSalida.Size = new System.Drawing.Size(902, 262);
			this.dataSalida.TabIndex = 4;
			// 
			// Id_Salida
			// 
			this.Id_Salida.HeaderText = "Id_Salida";
			this.Id_Salida.Name = "Id_Salida";
			this.Id_Salida.Width = 76;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Width = 74;
			// 
			// Medición
			// 
			this.Medición.HeaderText = "Medición";
			this.Medición.Name = "Medición";
			this.Medición.Width = 75;
			// 
			// Pieza
			// 
			this.Pieza.HeaderText = "Pieza";
			this.Pieza.Name = "Pieza";
			this.Pieza.Width = 58;
			// 
			// Estado_Pieza
			// 
			this.Estado_Pieza.HeaderText = "Estado";
			this.Estado_Pieza.Name = "Estado_Pieza";
			this.Estado_Pieza.Width = 65;
			// 
			// Codigo_Barras
			// 
			this.Codigo_Barras.HeaderText = "CB";
			this.Codigo_Barras.Name = "Codigo_Barras";
			this.Codigo_Barras.Width = 46;
			// 
			// Grupo
			// 
			this.Grupo.HeaderText = "Grupo";
			this.Grupo.Name = "Grupo";
			this.Grupo.Width = 61;
			// 
			// Orden_Trabajo
			// 
			this.Orden_Trabajo.HeaderText = "Orden_Trabajo";
			this.Orden_Trabajo.Name = "Orden_Trabajo";
			this.Orden_Trabajo.Width = 103;
			// 
			// Fecha_Orden
			// 
			this.Fecha_Orden.HeaderText = "Fecha_Orden";
			this.Fecha_Orden.Name = "Fecha_Orden";
			this.Fecha_Orden.Width = 97;
			// 
			// Mecanico
			// 
			this.Mecanico.HeaderText = "Mecanico";
			this.Mecanico.Name = "Mecanico";
			this.Mecanico.Width = 79;
			// 
			// Intervención
			// 
			this.Intervención.HeaderText = "Intervención";
			this.Intervención.Name = "Intervención";
			this.Intervención.Width = 91;
			// 
			// Vehiculo
			// 
			this.Vehiculo.HeaderText = "Vehiculo";
			this.Vehiculo.Name = "Vehiculo";
			this.Vehiculo.Width = 73;
			// 
			// txtTotalProds
			// 
			this.txtTotalProds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalProds.Location = new System.Drawing.Point(766, 348);
			this.txtTotalProds.Name = "txtTotalProds";
			this.txtTotalProds.ReadOnly = true;
			this.txtTotalProds.Size = new System.Drawing.Size(81, 20);
			this.txtTotalProds.TabIndex = 163;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(840, 348);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 20);
			this.label4.TabIndex = 162;
			this.label4.Text = "productos";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(729, 348);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 20);
			this.label6.TabIndex = 161;
			this.label6.Text = "de";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTotalSal
			// 
			this.txtTotalSal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalSal.Location = new System.Drawing.Point(647, 348);
			this.txtTotalSal.Name = "txtTotalSal";
			this.txtTotalSal.ReadOnly = true;
			this.txtTotalSal.Size = new System.Drawing.Size(81, 20);
			this.txtTotalSal.TabIndex = 160;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(554, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 20);
			this.label3.TabIndex = 159;
			this.label3.Text = "Salidas totales:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.btnAgregar);
			this.groupBox18.Controls.Add(this.txtIdProducto);
			this.groupBox18.Controls.Add(this.txtOrdenTrabajo);
			this.groupBox18.Controls.Add(this.txtCodigoBarras);
			this.groupBox18.Controls.Add(this.label7);
			this.groupBox18.Controls.Add(this.label8);
			this.groupBox18.Controls.Add(this.txtCantidad);
			this.groupBox18.Controls.Add(this.label1);
			this.groupBox18.Controls.Add(this.label10);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(15, 4);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(899, 73);
			this.groupBox18.TabIndex = 5;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Salida de Productos";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.Location = new System.Drawing.Point(801, 23);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(59, 26);
			this.btnAgregar.TabIndex = 176;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtIdProducto
			// 
			this.txtIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdProducto.Location = new System.Drawing.Point(414, 19);
			this.txtIdProducto.Name = "txtIdProducto";
			this.txtIdProducto.Size = new System.Drawing.Size(176, 20);
			this.txtIdProducto.TabIndex = 6;
			// 
			// txtOrdenTrabajo
			// 
			this.txtOrdenTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOrdenTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOrdenTrabajo.Location = new System.Drawing.Point(130, 45);
			this.txtOrdenTrabajo.Name = "txtOrdenTrabajo";
			this.txtOrdenTrabajo.Size = new System.Drawing.Size(179, 20);
			this.txtOrdenTrabajo.TabIndex = 2;
			// 
			// txtCodigoBarras
			// 
			this.txtCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigoBarras.Location = new System.Drawing.Point(130, 19);
			this.txtCodigoBarras.Name = "txtCodigoBarras";
			this.txtCodigoBarras.Size = new System.Drawing.Size(179, 20);
			this.txtCodigoBarras.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(339, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 20);
			this.label7.TabIndex = 175;
			this.label7.Text = "ID Producto";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(26, 45);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 21);
			this.label8.TabIndex = 173;
			this.label8.Text = "Orden Trabajo";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCantidad.Location = new System.Drawing.Point(414, 46);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(176, 20);
			this.txtCantidad.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(343, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 172;
			this.label1.Text = "Cantidad";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(28, 23);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(95, 15);
			this.label10.TabIndex = 171;
			this.label10.Text = "Codigo de barras";
			// 
			// FormSalida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(926, 383);
			this.Controls.Add(this.txtTotalProds);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtTotalSal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.dataSalida);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormSalida";
			this.Text = "FormSalida";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormSalidaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataSalida)).EndInit();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Intervención;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mecanico;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Orden;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barras;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Pieza;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pieza;
		private System.Windows.Forms.DataGridViewTextBoxColumn Medición;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Salida;
		private System.Windows.Forms.TextBox txtCodigoBarras;
		private System.Windows.Forms.TextBox txtOrdenTrabajo;
		private System.Windows.Forms.TextBox txtIdProducto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Orden_Trabajo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTotalSal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTotalProds;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
		private System.Windows.Forms.DataGridView dataSalida;
	}
}
