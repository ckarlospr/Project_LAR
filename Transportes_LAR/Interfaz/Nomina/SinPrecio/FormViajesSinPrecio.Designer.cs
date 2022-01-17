/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 08/02/2013
 * Time: 10:04 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.SinPrecio
{
	partial class FormViajesSinPrecio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViajesSinPrecio));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataViajesNormales = new System.Windows.Forms.DataGridView();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.lblFechaInicio = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Kilometrajes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataViajesNormales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataViajesNormales
			// 
			this.dataViajesNormales.AllowUserToAddRows = false;
			this.dataViajesNormales.AllowUserToDeleteRows = false;
			this.dataViajesNormales.AllowUserToResizeColumns = false;
			this.dataViajesNormales.AllowUserToResizeRows = false;
			this.dataViajesNormales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataViajesNormales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataViajesNormales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataViajesNormales.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataViajesNormales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataViajesNormales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataViajesNormales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataViajesNormales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Fecha,
									this.HoraInicio,
									this.Empresa,
									this.Ruta,
									this.Sentido,
									this.Turno,
									this.Vehiculo,
									this.Kilometrajes,
									this.Costo,
									this.Costo2,
									this.Alias});
			this.dataViajesNormales.Location = new System.Drawing.Point(12, 91);
			this.dataViajesNormales.Name = "dataViajesNormales";
			this.dataViajesNormales.RowHeadersVisible = false;
			this.dataViajesNormales.Size = new System.Drawing.Size(1168, 326);
			this.dataViajesNormales.TabIndex = 1;
			this.dataViajesNormales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViajesNormalesCellClick);
			this.dataViajesNormales.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataViajesNormalesColumnHeaderMouseClick);
			// 
			// dtCorte
			// 
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(265, 64);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(93, 20);
			this.dtCorte.TabIndex = 142;
			this.dtCorte.ValueChanged += new System.EventHandler(this.DtCorteValueChanged);
			// 
			// dtInicio
			// 
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(90, 64);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(92, 20);
			this.dtInicio.TabIndex = 141;
			this.dtInicio.ValueChanged += new System.EventHandler(this.DtInicioValueChanged);
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(185, 66);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(100, 22);
			this.lblFechaCorte.TabIndex = 140;
			this.lblFechaCorte.Text = "Fecha Corte:";
			// 
			// lblFechaInicio
			// 
			this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaInicio.Location = new System.Drawing.Point(12, 66);
			this.lblFechaInicio.Name = "lblFechaInicio";
			this.lblFechaInicio.Size = new System.Drawing.Size(95, 22);
			this.lblFechaInicio.TabIndex = 139;
			this.lblFechaInicio.Text = "Fecha Inicio:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1193, 56);
			this.label1.TabIndex = 143;
			this.label1.Text = "Rutas sin precios o Sin kilometrajes";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(230, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 50);
			this.pictureBox1.TabIndex = 145;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(938, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(55, 50);
			this.pictureBox2.TabIndex = 146;
			this.pictureBox2.TabStop = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
			this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(1141, 425);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(39, 33);
			this.btnAceptar.TabIndex = 165;
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 22;
			// 
			// Fecha
			// 
			this.Fecha.DataPropertyName = "Fecha";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			this.Fecha.Width = 62;
			// 
			// HoraInicio
			// 
			this.HoraInicio.DataPropertyName = "HoraInicio";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.HoraInicio.DefaultCellStyle = dataGridViewCellStyle3;
			this.HoraInicio.HeaderText = "Hora";
			this.HoraInicio.Name = "HoraInicio";
			this.HoraInicio.ReadOnly = true;
			this.HoraInicio.Width = 55;
			// 
			// Empresa
			// 
			this.Empresa.DataPropertyName = "Empresa";
			this.Empresa.HeaderText = "Empresa";
			this.Empresa.Name = "Empresa";
			this.Empresa.ReadOnly = true;
			this.Empresa.Width = 74;
			// 
			// Ruta
			// 
			this.Ruta.DataPropertyName = "Ruta";
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			this.Ruta.Width = 54;
			// 
			// Sentido
			// 
			this.Sentido.DataPropertyName = "Sentido";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Sentido.DefaultCellStyle = dataGridViewCellStyle4;
			this.Sentido.HeaderText = "Sentido";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			this.Sentido.Width = 68;
			// 
			// Turno
			// 
			this.Turno.DataPropertyName = "Turno";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Turno.DefaultCellStyle = dataGridViewCellStyle5;
			this.Turno.HeaderText = "Turno";
			this.Turno.Name = "Turno";
			this.Turno.ReadOnly = true;
			this.Turno.Width = 60;
			// 
			// Vehiculo
			// 
			this.Vehiculo.DataPropertyName = "Vehiculo";
			this.Vehiculo.HeaderText = "Vehiculo";
			this.Vehiculo.Name = "Vehiculo";
			this.Vehiculo.ReadOnly = true;
			this.Vehiculo.Width = 73;
			// 
			// Kilometrajes
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = "0";
			this.Kilometrajes.DefaultCellStyle = dataGridViewCellStyle6;
			this.Kilometrajes.HeaderText = "Kilometrajes";
			this.Kilometrajes.Name = "Kilometrajes";
			this.Kilometrajes.Width = 90;
			// 
			// Costo
			// 
			this.Costo.DataPropertyName = "Costo";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.Format = "N2";
			dataGridViewCellStyle7.NullValue = null;
			this.Costo.DefaultCellStyle = dataGridViewCellStyle7;
			this.Costo.HeaderText = "$ Sencillo";
			this.Costo.Name = "Costo";
			this.Costo.Width = 78;
			// 
			// Costo2
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.Format = "N2";
			dataGridViewCellStyle8.NullValue = null;
			this.Costo2.DefaultCellStyle = dataGridViewCellStyle8;
			this.Costo2.HeaderText = "$ Completo";
			this.Costo2.Name = "Costo2";
			this.Costo2.Width = 85;
			// 
			// Alias
			// 
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			this.Alias.Width = 56;
			// 
			// FormViajesSinPrecio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1192, 468);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtCorte);
			this.Controls.Add(this.dtInicio);
			this.Controls.Add(this.lblFechaCorte);
			this.Controls.Add(this.lblFechaInicio);
			this.Controls.Add(this.dataViajesNormales);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormViajesSinPrecio";
			this.Text = "Transportes LAR - Viajes sin precio";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViajesSinPrecioFormClosing);
			this.Load += new System.EventHandler(this.FormViajesSinPrecioLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataViajesNormales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Kilometrajes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo2;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblFechaInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridView dataViajesNormales;
	}
}
