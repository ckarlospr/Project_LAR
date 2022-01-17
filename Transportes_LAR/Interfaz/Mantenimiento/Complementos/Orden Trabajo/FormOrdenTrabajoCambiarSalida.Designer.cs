/*
 * Created by SharpDevelop.
 * User: lalo
 * Date: 26/06/2015
 * Time: 01:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	partial class FormOrdenTrabajoCambiarSalida
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenTrabajoCambiarSalida));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dtpFechaEstimada = new System.Windows.Forms.DateTimePicker();
			this.txtMotivosSalida = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.btnCambiar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblordent = new System.Windows.Forms.Label();
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
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.dtpFechaEstimada);
			this.groupBox3.Controls.Add(this.txtMotivosSalida);
			this.groupBox3.Controls.Add(this.label27);
			this.groupBox3.Controls.Add(this.label28);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 40);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(254, 145);
			this.groupBox3.TabIndex = 234;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Salida de Vehiculo";
			// 
			// dtpFechaEstimada
			// 
			this.dtpFechaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaEstimada.Location = new System.Drawing.Point(65, 21);
			this.dtpFechaEstimada.Name = "dtpFechaEstimada";
			this.dtpFechaEstimada.Size = new System.Drawing.Size(171, 20);
			this.dtpFechaEstimada.TabIndex = 238;
			this.dtpFechaEstimada.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// txtMotivosSalida
			// 
			this.txtMotivosSalida.Location = new System.Drawing.Point(65, 57);
			this.txtMotivosSalida.Multiline = true;
			this.txtMotivosSalida.Name = "txtMotivosSalida";
			this.txtMotivosSalida.Size = new System.Drawing.Size(171, 80);
			this.txtMotivosSalida.TabIndex = 20;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(10, 57);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(66, 17);
			this.label27.TabIndex = 211;
			this.label27.Text = "Motivos";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(10, 21);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(66, 36);
			this.label28.TabIndex = 209;
			this.label28.Text = "Fecha Estimada";
			// 
			// btnCambiar
			// 
			this.btnCambiar.Location = new System.Drawing.Point(41, 270);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(75, 34);
			this.btnCambiar.TabIndex = 235;
			this.btnCambiar.Text = "Cambiar";
			this.btnCambiar.UseVisualStyleBackColor = true;
			this.btnCambiar.Click += new System.EventHandler(this.BtnCambiarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(160, 270);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 34);
			this.btnCancelar.TabIndex = 236;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// lblordent
			// 
			this.lblordent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblordent.Location = new System.Drawing.Point(12, 9);
			this.lblordent.Name = "lblordent";
			this.lblordent.Size = new System.Drawing.Size(143, 23);
			this.lblordent.TabIndex = 237;
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
			this.dataFallas.Location = new System.Drawing.Point(272, 251);
			this.dataFallas.Name = "dataFallas";
			this.dataFallas.RowHeadersVisible = false;
			this.dataFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallas.Size = new System.Drawing.Size(402, 152);
			this.dataFallas.TabIndex = 250;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			this.ID.Width = 24;
			// 
			// Tipo_falla
			// 
			this.Tipo_falla.HeaderText = "Falla";
			this.Tipo_falla.Name = "Tipo_falla";
			this.Tipo_falla.Width = 54;
			// 
			// Origen1
			// 
			this.Origen1.HeaderText = "Origen";
			this.Origen1.Name = "Origen1";
			this.Origen1.Width = 63;
			// 
			// Descripcion_Falla
			// 
			this.Descripcion_Falla.HeaderText = "Descripción";
			this.Descripcion_Falla.Name = "Descripcion_Falla";
			this.Descripcion_Falla.Width = 88;
			// 
			// Origen
			// 
			this.Origen.HeaderText = "Tipo Taller";
			this.Origen.Name = "Origen";
			this.Origen.Width = 82;
			// 
			// Nombre_Taller
			// 
			this.Nombre_Taller.HeaderText = "Nombre_Taller";
			this.Nombre_Taller.Name = "Nombre_Taller";
			this.Nombre_Taller.Width = 101;
			// 
			// Descripcion_Reparacion
			// 
			this.Descripcion_Reparacion.HeaderText = "Descripción_Rep.";
			this.Descripcion_Reparacion.Name = "Descripcion_Reparacion";
			this.Descripcion_Reparacion.Width = 117;
			// 
			// btnagregarFalla
			// 
			this.btnagregarFalla.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarFalla.Image")));
			this.btnagregarFalla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnagregarFalla.Location = new System.Drawing.Point(453, 220);
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
			this.groupBox1.Location = new System.Drawing.Point(272, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(402, 202);
			this.groupBox1.TabIndex = 251;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fallas Reportadas";
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(242, 23);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.Size = new System.Drawing.Size(134, 20);
			this.txtOrigen.TabIndex = 252;
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
			this.txtTipoFalla.TabIndex = 14;
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
			this.cmbTipoTaller.TabIndex = 16;
			// 
			// txtDescripcionReparacion
			// 
			this.txtDescripcionReparacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcionReparacion.Location = new System.Drawing.Point(72, 144);
			this.txtDescripcionReparacion.Multiline = true;
			this.txtDescripcionReparacion.Name = "txtDescripcionReparacion";
			this.txtDescripcionReparacion.Size = new System.Drawing.Size(304, 43);
			this.txtDescripcionReparacion.TabIndex = 18;
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
			this.txtDescripcionFalla.TabIndex = 15;
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
			this.txtNombreTaller.TabIndex = 17;
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
			// FormOrdenTrabajoCambiarSalida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(682, 415);
			this.Controls.Add(this.dataFallas);
			this.Controls.Add(this.btnagregarFalla);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblordent);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCambiar);
			this.Controls.Add(this.groupBox3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOrdenTrabajoCambiarSalida";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Cambiar Salida";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenTrabajoCambiarSalidaFormClosing);
			this.Load += new System.EventHandler(this.FormOrdenTrabajoCambiarSalidaLoad);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataFallas;
		private System.Windows.Forms.Label lblordent;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnCambiar;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.DateTimePicker dtpFechaEstimada;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtMotivosSalida;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}
