/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 06/01/2015
 * Hora: 05:43 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	partial class FormAgrupación
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgrupación));
			this.dataAgrupación = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataAgrupación)).BeginInit();
			this.groupBox18.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataAgrupación
			// 
			this.dataAgrupación.AllowUserToAddRows = false;
			this.dataAgrupación.AllowUserToResizeRows = false;
			this.dataAgrupación.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataAgrupación.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataAgrupación.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataAgrupación.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataAgrupación.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataAgrupación.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataAgrupación.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataAgrupación.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn41,
									this.Nombre,
									this.Descripcion,
									this.estatus,
									this.Eliminar,
									this.Column2});
			this.dataAgrupación.Location = new System.Drawing.Point(12, 55);
			this.dataAgrupación.Name = "dataAgrupación";
			this.dataAgrupación.RowHeadersVisible = false;
			this.dataAgrupación.Size = new System.Drawing.Size(565, 383);
			this.dataAgrupación.TabIndex = 4;
			this.dataAgrupación.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAgrupaciónCellContentClick);
			this.dataAgrupación.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataAgrupaciónCellPainting);
			this.dataAgrupación.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataAgrupaciónKeyUp);
			// 
			// dataGridViewTextBoxColumn41
			// 
			this.dataGridViewTextBoxColumn41.DataPropertyName = "Empresa";
			this.dataGridViewTextBoxColumn41.HeaderText = "ID";
			this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn41.ReadOnly = true;
			this.dataGridViewTextBoxColumn41.Visible = false;
			this.dataGridViewTextBoxColumn41.Width = 22;
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Descripcion
			// 
			this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Width = 300;
			// 
			// estatus
			// 
			this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.estatus.HeaderText = "Estatus";
			this.estatus.Name = "estatus";
			// 
			// Eliminar
			// 
			this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Eliminar.HeaderText = "#";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Width = 30;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.HeaderText = "#";
			this.Column2.Name = "Column2";
			this.Column2.Width = 30;
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.label1);
			this.groupBox18.Controls.Add(this.txtDescripcion);
			this.groupBox18.Controls.Add(this.btnAgregar);
			this.groupBox18.Controls.Add(this.txtNombre);
			this.groupBox18.Controls.Add(this.label2);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(11, 4);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(566, 45);
			this.groupBox18.TabIndex = 153;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Sistemas y Elementos del Vehiculo";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(140, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 152;
			this.label1.Text = "Descripción";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcion.Location = new System.Drawing.Point(212, 16);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(321, 20);
			this.txtDescripcion.TabIndex = 2;
			this.txtDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDescripcionKeyUp);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
			this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregar.Location = new System.Drawing.Point(539, 14);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(21, 23);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Location = new System.Drawing.Point(62, 16);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(76, 20);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombreKeyUp);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 148;
			this.label2.Text = "Nombre";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormAgrupación
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(589, 450);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.dataAgrupación);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAgrupación";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAgrupación";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataAgrupación)).EndInit();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewButtonColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
		private System.Windows.Forms.DataGridView dataAgrupación;
	}
}
