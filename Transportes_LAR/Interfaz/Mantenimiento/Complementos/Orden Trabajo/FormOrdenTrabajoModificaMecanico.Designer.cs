/*
 * Created by SharpDevelop.
 * User: lalo
 * Date: 26/06/2015
 * Time: 01:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	partial class FormOrdenTrabajoModificaMecanico
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenTrabajoModificaMecanico));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descricion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblordent = new System.Windows.Forms.Label();
			this.dataFallas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtOrigen = new System.Windows.Forms.TextBox();
			this.btnagregarFalla = new System.Windows.Forms.Button();
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
			this.dataMecanicos = new System.Windows.Forms.DataGridView();
			this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Horas_Ext = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Motivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Elimina = new System.Windows.Forms.DataGridViewButtonColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataMecanicos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(616, 519);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(93, 34);
			this.btnGuardar.TabIndex = 235;
			this.btnGuardar.Text = "Cancelar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// Falla
			// 
			this.Falla.HeaderText = "Falla";
			this.Falla.Name = "Falla";
			this.Falla.Width = 54;
			// 
			// Descricion
			// 
			this.Descricion.HeaderText = "Descrición";
			this.Descricion.Name = "Descricion";
			this.Descricion.Width = 83;
			// 
			// Taller
			// 
			this.Taller.HeaderText = "Taller";
			this.Taller.Name = "Taller";
			this.Taller.Width = 57;
			// 
			// Descripcion_Reparacion
			// 
			this.Descripcion_Reparacion.HeaderText = "Descripción_Reparación";
			this.Descripcion_Reparacion.Name = "Descripcion_Reparacion";
			this.Descripcion_Reparacion.Width = 150;
			// 
			// lblordent
			// 
			this.lblordent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblordent.Location = new System.Drawing.Point(12, 9);
			this.lblordent.Name = "lblordent";
			this.lblordent.Size = new System.Drawing.Size(143, 23);
			this.lblordent.TabIndex = 240;
			this.lblordent.Text = "Orden de Trabajo:";
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Tipo_falla,
									this.Origen1,
									this.Descripcion_Falla,
									this.Origen,
									this.Nombre_Taller,
									this.dataGridViewTextBoxColumn1});
			this.dataFallas.Location = new System.Drawing.Point(413, 39);
			this.dataFallas.Name = "dataFallas";
			this.dataFallas.RowHeadersVisible = false;
			this.dataFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallas.Size = new System.Drawing.Size(535, 241);
			this.dataFallas.TabIndex = 252;
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
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Descripción_Rep.";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 117;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtOrigen);
			this.groupBox2.Controls.Add(this.btnagregarFalla);
			this.groupBox2.Controls.Add(this.label2);
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
			this.groupBox2.Location = new System.Drawing.Point(5, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(402, 233);
			this.groupBox2.TabIndex = 253;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fallas Reportadas";
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(242, 23);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.Size = new System.Drawing.Size(134, 20);
			this.txtOrigen.TabIndex = 6;
			// 
			// btnagregarFalla
			// 
			this.btnagregarFalla.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarFalla.Image")));
			this.btnagregarFalla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnagregarFalla.Location = new System.Drawing.Point(182, 200);
			this.btnagregarFalla.Name = "btnagregarFalla";
			this.btnagregarFalla.Size = new System.Drawing.Size(40, 25);
			this.btnagregarFalla.TabIndex = 249;
			this.btnagregarFalla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnagregarFalla.UseVisualStyleBackColor = true;
			this.btnagregarFalla.Click += new System.EventHandler(this.BtnagregarFallaClick);
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
			// dataMecanicos
			// 
			this.dataMecanicos.AllowUserToAddRows = false;
			this.dataMecanicos.AllowUserToResizeRows = false;
			this.dataMecanicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataMecanicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataMecanicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataMecanicos.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataMecanicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataMecanicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataMecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataMecanicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Producto,
									this.Tipo_Mecanico,
									this.Mecanico,
									this.Horas_Ext,
									this.Motivos,
									this.Elimina});
			this.dataMecanicos.Location = new System.Drawing.Point(413, 286);
			this.dataMecanicos.Name = "dataMecanicos";
			this.dataMecanicos.RowHeadersVisible = false;
			this.dataMecanicos.Size = new System.Drawing.Size(535, 209);
			this.dataMecanicos.TabIndex = 254;
			// 
			// ID_Producto
			// 
			this.ID_Producto.HeaderText = "ID";
			this.ID_Producto.Name = "ID_Producto";
			this.ID_Producto.ReadOnly = true;
			this.ID_Producto.Visible = false;
			this.ID_Producto.Width = 22;
			// 
			// Tipo_Mecanico
			// 
			this.Tipo_Mecanico.HeaderText = "Tipo_Mecanico";
			this.Tipo_Mecanico.Name = "Tipo_Mecanico";
			this.Tipo_Mecanico.Width = 104;
			// 
			// Mecanico
			// 
			this.Mecanico.HeaderText = "Mecanico";
			this.Mecanico.Name = "Mecanico";
			this.Mecanico.ReadOnly = true;
			this.Mecanico.Width = 78;
			// 
			// Horas_Ext
			// 
			this.Horas_Ext.HeaderText = "Horas_Ext";
			this.Horas_Ext.Name = "Horas_Ext";
			this.Horas_Ext.Width = 82;
			// 
			// Motivos
			// 
			this.Motivos.HeaderText = "Motivos";
			this.Motivos.Name = "Motivos";
			this.Motivos.Width = 69;
			// 
			// Elimina
			// 
			this.Elimina.HeaderText = "#";
			this.Elimina.Name = "Elimina";
			this.Elimina.Width = 19;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(300, 519);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 34);
			this.button1.TabIndex = 255;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// FormOrdenTrabajoModificaMecanico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(956, 565);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataMecanicos);
			this.Controls.Add(this.dataFallas);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblordent);
			this.Controls.Add(this.btnGuardar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOrdenTrabajoModificaMecanico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Fallas y  Mecánico";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenTrabajoModificaMecanicoFormClosing);
			this.Load += new System.EventHandler(this.FormOrdenTrabajoModificaMecanicoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataMecanicos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnagregarFalla;
		private System.Windows.Forms.TextBox txtOrigen;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataFallas;
		private System.Windows.Forms.DataGridViewButtonColumn Elimina;
		private System.Windows.Forms.Label lblordent;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descricion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Falla;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Motivos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Horas_Ext;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mecanico;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Mecanico;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
		private System.Windows.Forms.DataGridView dataMecanicos;
	}
}
