/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 29/07/2015
 * Hora: 9:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	partial class FormReprogramarFallas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReprogramarFallas));
			this.dataFallas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Tipo_falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Falla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre_Taller = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion_Reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOrigen = new System.Windows.Forms.TextBox();
			this.timeHoraProgramada = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dtpFechaProgramda = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaReporte = new System.Windows.Forms.DateTimePicker();
			this.timeHoraReporte = new System.Windows.Forms.DateTimePicker();
			this.txtArrivo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEstatusReporte = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.cmbTipoMantenimiento = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtOperadorAgregar = new System.Windows.Forms.TextBox();
			this.txtVehiculo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.SuspendLayout();
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
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFallas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataFallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Estado,
									this.Tipo_falla,
									this.Origen1,
									this.Descripcion_Falla,
									this.Origen,
									this.Nombre_Taller,
									this.Descripcion_Reparacion});
			this.dataFallas.Location = new System.Drawing.Point(474, 51);
			this.dataFallas.Name = "dataFallas";
			this.dataFallas.RowHeadersVisible = false;
			this.dataFallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataFallas.Size = new System.Drawing.Size(517, 239);
			this.dataFallas.TabIndex = 256;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			this.ID.Width = 24;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "*";
			this.Estado.Name = "Estado";
			this.Estado.Width = 17;
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
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(264, 343);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(94, 34);
			this.btnCancelar.TabIndex = 253;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(78, 343);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(93, 34);
			this.btnAceptar.TabIndex = 252;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtOrigen);
			this.groupBox1.Controls.Add(this.timeHoraProgramada);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.dtpFechaProgramda);
			this.groupBox1.Controls.Add(this.dtpFechaReporte);
			this.groupBox1.Controls.Add(this.timeHoraReporte);
			this.groupBox1.Controls.Add(this.txtArrivo);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtEstatusReporte);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtCodigo);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 209);
			this.groupBox1.TabIndex = 258;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Reporte";
			// 
			// txtOrigen
			// 
			this.txtOrigen.Location = new System.Drawing.Point(274, 53);
			this.txtOrigen.Name = "txtOrigen";
			this.txtOrigen.Size = new System.Drawing.Size(170, 20);
			this.txtOrigen.TabIndex = 6;
			// 
			// timeHoraProgramada
			// 
			this.timeHoraProgramada.CustomFormat = "HH:mm";
			this.timeHoraProgramada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraProgramada.Location = new System.Drawing.Point(102, 141);
			this.timeHoraProgramada.Name = "timeHoraProgramada";
			this.timeHoraProgramada.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.timeHoraProgramada.ShowUpDown = true;
			this.timeHoraProgramada.Size = new System.Drawing.Size(127, 20);
			this.timeHoraProgramada.TabIndex = 13;
			this.timeHoraProgramada.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(3, 146);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(101, 18);
			this.label14.TabIndex = 184;
			this.label14.Text = "Hora Programada";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(225, 58);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 18);
			this.label11.TabIndex = 182;
			this.label11.Text = "Origen";
			// 
			// dtpFechaProgramda
			// 
			this.dtpFechaProgramda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaProgramda.Location = new System.Drawing.Point(102, 115);
			this.dtpFechaProgramda.Name = "dtpFechaProgramda";
			this.dtpFechaProgramda.Size = new System.Drawing.Size(127, 20);
			this.dtpFechaProgramda.TabIndex = 10;
			this.dtpFechaProgramda.Value = new System.DateTime(2015, 7, 21, 0, 0, 0, 0);
			// 
			// dtpFechaReporte
			// 
			this.dtpFechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaReporte.Location = new System.Drawing.Point(102, 85);
			this.dtpFechaReporte.Name = "dtpFechaReporte";
			this.dtpFechaReporte.Size = new System.Drawing.Size(127, 20);
			this.dtpFechaReporte.TabIndex = 8;
			this.dtpFechaReporte.Value = new System.DateTime(2015, 7, 21, 0, 0, 0, 0);
			// 
			// timeHoraReporte
			// 
			this.timeHoraReporte.CustomFormat = "HH:mm";
			this.timeHoraReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraReporte.Location = new System.Drawing.Point(307, 85);
			this.timeHoraReporte.Name = "timeHoraReporte";
			this.timeHoraReporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.timeHoraReporte.ShowUpDown = true;
			this.timeHoraReporte.Size = new System.Drawing.Size(137, 20);
			this.timeHoraReporte.TabIndex = 9;
			this.timeHoraReporte.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// txtArrivo
			// 
			this.txtArrivo.Location = new System.Drawing.Point(50, 55);
			this.txtArrivo.Name = "txtArrivo";
			this.txtArrivo.Size = new System.Drawing.Size(168, 20);
			this.txtArrivo.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 18);
			this.label7.TabIndex = 179;
			this.label7.Text = "Arrivo";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 18);
			this.label3.TabIndex = 177;
			this.label3.Text = "Fecha Programada";
			// 
			// txtEstatusReporte
			// 
			this.txtEstatusReporte.Location = new System.Drawing.Point(274, 29);
			this.txtEstatusReporte.Name = "txtEstatusReporte";
			this.txtEstatusReporte.Size = new System.Drawing.Size(170, 20);
			this.txtEstatusReporte.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(225, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 175;
			this.label2.Text = "Estatus";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 18);
			this.label6.TabIndex = 173;
			this.label6.Text = "Fecha Reporte";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Enabled = false;
			this.txtCodigo.Location = new System.Drawing.Point(50, 29);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(168, 20);
			this.txtCodigo.TabIndex = 4;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(233, 87);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 18);
			this.label12.TabIndex = 160;
			this.label12.Text = "Hora Reporte";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(9, 32);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(58, 18);
			this.label13.TabIndex = 157;
			this.label13.Text = "Código ";
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.cmbTipoMantenimiento);
			this.groupBox18.Controls.Add(this.label4);
			this.groupBox18.Controls.Add(this.txtOperadorAgregar);
			this.groupBox18.Controls.Add(this.txtVehiculo);
			this.groupBox18.Controls.Add(this.label1);
			this.groupBox18.Controls.Add(this.label8);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(9, 12);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(456, 87);
			this.groupBox18.TabIndex = 257;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Mantenimientos";
			// 
			// cmbTipoMantenimiento
			// 
			this.cmbTipoMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoMantenimiento.FormattingEnabled = true;
			this.cmbTipoMantenimiento.Items.AddRange(new object[] {
									"Correctivo",
									"Preventivo"});
			this.cmbTipoMantenimiento.Location = new System.Drawing.Point(99, 26);
			this.cmbTipoMantenimiento.Name = "cmbTipoMantenimiento";
			this.cmbTipoMantenimiento.Size = new System.Drawing.Size(139, 22);
			this.cmbTipoMantenimiento.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 37);
			this.label4.TabIndex = 171;
			this.label4.Text = "Tipo de mantenimiento";
			// 
			// txtOperadorAgregar
			// 
			this.txtOperadorAgregar.Location = new System.Drawing.Point(99, 54);
			this.txtOperadorAgregar.Name = "txtOperadorAgregar";
			this.txtOperadorAgregar.Size = new System.Drawing.Size(139, 20);
			this.txtOperadorAgregar.TabIndex = 3;
			// 
			// txtVehiculo
			// 
			this.txtVehiculo.Location = new System.Drawing.Point(290, 28);
			this.txtVehiculo.Name = "txtVehiculo";
			this.txtVehiculo.Size = new System.Drawing.Size(154, 20);
			this.txtVehiculo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 18);
			this.label1.TabIndex = 160;
			this.label1.Text = "Operador";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(242, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 18);
			this.label8.TabIndex = 157;
			this.label8.Text = "Vehiculo";
			// 
			// FormReprogramarFallas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1003, 473);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.dataFallas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReprogramarFallas";
			this.Text = "Transportes LAR -  Reprogramar Fallas";
			((System.ComponentModel.ISupportInitialize)(this.dataFallas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtVehiculo;
		private System.Windows.Forms.TextBox txtOperadorAgregar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbTipoMantenimiento;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEstatusReporte;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtArrivo;
		private System.Windows.Forms.DateTimePicker timeHoraReporte;
		private System.Windows.Forms.DateTimePicker dtpFechaReporte;
		private System.Windows.Forms.DateTimePicker dtpFechaProgramda;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker timeHoraProgramada;
		private System.Windows.Forms.TextBox txtOrigen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Reparacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Taller;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Falla;
		private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_falla;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataFallas;
	}
}
