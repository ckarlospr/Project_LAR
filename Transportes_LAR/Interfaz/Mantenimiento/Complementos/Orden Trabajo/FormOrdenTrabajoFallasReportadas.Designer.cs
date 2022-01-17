/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 23/07/2015
 * Time: 9:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	partial class FormOrdenTrabajoFallasReportadas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenTrabajoFallasReportadas));
			this.lblordent = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataFallas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnagregarFalla = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOrigen = new System.Windows.Forms.TextBox();
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
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblordent
			// 
			this.lblordent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblordent.Location = new System.Drawing.Point(12, 9);
			this.lblordent.Name = "lblordent";
			this.lblordent.Size = new System.Drawing.Size(143, 23);
			this.lblordent.TabIndex = 241;
			this.lblordent.Text = "Orden de Trabajo:";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(479, 265);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(93, 34);
			this.btnGuardar.TabIndex = 2;
			this.btnGuardar.Text = "Salir";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(292, 265);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 34);
			this.button1.TabIndex = 243;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
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
									this.ID,
									this.Tipo_falla,
									this.Origen1,
									this.Descripcion_Falla,
									this.Origen,
									this.Nombre_Taller,
									this.Descripcion_Reparacion});
			this.dataFallas.Location = new System.Drawing.Point(353, 43);
			this.dataFallas.Name = "dataFallas";
			this.dataFallas.RowHeadersVisible = false;
			this.dataFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallas.Size = new System.Drawing.Size(535, 216);
			this.dataFallas.TabIndex = 250;
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
			this.btnagregarFalla.Location = new System.Drawing.Point(155, 193);
			this.btnagregarFalla.Name = "btnagregarFalla";
			this.btnagregarFalla.Size = new System.Drawing.Size(40, 25);
			this.btnagregarFalla.TabIndex = 249;
			this.btnagregarFalla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnagregarFalla.UseVisualStyleBackColor = true;
			this.btnagregarFalla.Click += new System.EventHandler(this.BtnagregarFallaClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtOrigen);
			this.groupBox1.Controls.Add(this.btnagregarFalla);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtTipoFalla);
			this.groupBox1.Controls.Add(this.cmbTipoTaller);
			this.groupBox1.Controls.Add(this.txtDescripcionReparacion);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtDescripcionFalla);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.txtNombreTaller);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(335, 224);
			this.groupBox1.TabIndex = 251;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fallas Reportadas";
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(218, 23);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.Size = new System.Drawing.Size(108, 20);
			this.txtOrigen.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(177, 26);
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
			this.txtTipoFalla.Size = new System.Drawing.Size(103, 20);
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
			this.txtDescripcionReparacion.Size = new System.Drawing.Size(254, 43);
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
			this.txtDescripcionFalla.Size = new System.Drawing.Size(254, 37);
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
			// FormOrdenTrabajoFallasReportadas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 305);
			this.Controls.Add(this.dataFallas);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblordent);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOrdenTrabajoFallasReportadas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Fallas Reportadas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenTrabajoFallasReportadasFormClosing);
			this.Load += new System.EventHandler(this.FormOrdenTrabajoFallasReportadasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
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
		private System.Windows.Forms.TextBox txtOrigen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnagregarFalla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataFallas;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Falla;
		private System.Windows.Forms.Label lblordent;
	}
}
