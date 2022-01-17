/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 16/02/2013
 * Time: 10:00 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz
{
	partial class FormReporteCombustible
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteCombustible));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.dtFechaTermino = new System.Windows.Forms.DateTimePicker();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.dataOtros = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
			this.cmbHoraTermino = new System.Windows.Forms.ComboBox();
			this.dataCombustible = new System.Windows.Forms.DataGridView();
			this.ID_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataOtros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataCombustible)).BeginInit();
			this.SuspendLayout();
			// 
			// dtFechaInicio
			// 
			this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaInicio.Location = new System.Drawing.Point(57, 8);
			this.dtFechaInicio.Name = "dtFechaInicio";
			this.dtFechaInicio.Size = new System.Drawing.Size(78, 20);
			this.dtFechaInicio.TabIndex = 210;
			this.dtFechaInicio.ValueChanged += new System.EventHandler(this.DtFechaValueChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 11);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(39, 14);
			this.label10.TabIndex = 211;
			this.label10.Text = "Inicio:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(429, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 14);
			this.label1.TabIndex = 212;
			this.label1.Text = "Alias:";
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(472, 8);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(82, 20);
			this.txtAlias.TabIndex = 213;
			this.txtAlias.TextChanged += new System.EventHandler(this.TxtAliasTextChanged);
			// 
			// dtFechaTermino
			// 
			this.dtFechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaTermino.Location = new System.Drawing.Point(245, 9);
			this.dtFechaTermino.Name = "dtFechaTermino";
			this.dtFechaTermino.Size = new System.Drawing.Size(79, 20);
			this.dtFechaTermino.TabIndex = 214;
			this.dtFechaTermino.ValueChanged += new System.EventHandler(this.DtFechaTerminoValueChanged);
			// 
			// btnImprimir
			// 
			this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
			this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
			this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnImprimir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImprimir.Location = new System.Drawing.Point(969, 324);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(39, 33);
			this.btnImprimir.TabIndex = 215;
			this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
			// 
			// dataOtros
			// 
			this.dataOtros.AllowUserToAddRows = false;
			this.dataOtros.AllowUserToResizeRows = false;
			this.dataOtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataOtros.BackgroundColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataOtros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOtros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Nick});
			this.dataOtros.Location = new System.Drawing.Point(560, 35);
			this.dataOtros.Name = "dataOtros";
			this.dataOtros.RowHeadersVisible = false;
			this.dataOtros.Size = new System.Drawing.Size(448, 283);
			this.dataOtros.TabIndex = 216;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column1.HeaderText = "Tipo";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 53;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column2.HeaderText = "Fecha";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 62;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column3.HeaderText = "Turno";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 60;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column4.HeaderText = "Ruta";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 55;
			// 
			// Nick
			// 
			this.Nick.HeaderText = "Nick";
			this.Nick.Name = "Nick";
			this.Nick.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(756, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 16);
			this.label2.TabIndex = 217;
			this.label2.Text = "OTROS";
			// 
			// txtTotal
			// 
			this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(454, 324);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 218;
			this.txtTotal.Text = "0";
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtUnidad
			// 
			this.txtUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUnidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.Location = new System.Drawing.Point(392, 9);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(35, 20);
			this.txtUnidad.TabIndex = 219;
			this.txtUnidad.TextChanged += new System.EventHandler(this.TxtUnidadTextChanged);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(376, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 14);
			this.label3.TabIndex = 220;
			this.label3.Text = "#";
			// 
			// cmbHoraInicio
			// 
			this.cmbHoraInicio.FormattingEnabled = true;
			this.cmbHoraInicio.Items.AddRange(new object[] {
									"01:00",
									"02:00",
									"03:00",
									"04:00",
									"05:00",
									"06:00",
									"07:00",
									"08:00",
									"09:00",
									"10:00",
									"11:00",
									"12:00",
									"13:00",
									"14:00",
									"15:00",
									"16:00",
									"17:00",
									"18:00",
									"19:00",
									"20:00",
									"21:00",
									"22:00",
									"23:00"});
			this.cmbHoraInicio.Location = new System.Drawing.Point(138, 8);
			this.cmbHoraInicio.Name = "cmbHoraInicio";
			this.cmbHoraInicio.Size = new System.Drawing.Size(56, 21);
			this.cmbHoraInicio.TabIndex = 221;
			this.cmbHoraInicio.SelectedIndexChanged += new System.EventHandler(this.CmbHoraInicioSelectedIndexChanged);
			// 
			// cmbHoraTermino
			// 
			this.cmbHoraTermino.FormattingEnabled = true;
			this.cmbHoraTermino.Items.AddRange(new object[] {
									"01:00",
									"02:00",
									"03:00",
									"04:00",
									"05:00",
									"06:00",
									"07:00",
									"08:00",
									"09:00",
									"10:00",
									"11:00",
									"12:00",
									"13:00",
									"14:00",
									"15:00",
									"16:00",
									"17:00",
									"18:00",
									"19:00",
									"20:00",
									"21:00",
									"22:00",
									"23:00",
									"23:59"});
			this.cmbHoraTermino.Location = new System.Drawing.Point(330, 9);
			this.cmbHoraTermino.Name = "cmbHoraTermino";
			this.cmbHoraTermino.Size = new System.Drawing.Size(56, 21);
			this.cmbHoraTermino.TabIndex = 222;
			this.cmbHoraTermino.SelectedIndexChanged += new System.EventHandler(this.CmbHoraTerminoSelectedIndexChanged);
			// 
			// dataCombustible
			// 
			this.dataCombustible.AllowUserToAddRows = false;
			this.dataCombustible.AllowUserToResizeRows = false;
			this.dataCombustible.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataCombustible.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataCombustible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataCombustible.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataCombustible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_R,
									this.Indicador,
									this.Fecha,
									this.Hora,
									this.Empresa,
									this.Ruta,
									this.Turno,
									this.Sentido,
									this.Km});
			this.dataCombustible.Location = new System.Drawing.Point(12, 36);
			this.dataCombustible.Name = "dataCombustible";
			this.dataCombustible.RowHeadersVisible = false;
			this.dataCombustible.Size = new System.Drawing.Size(542, 282);
			this.dataCombustible.TabIndex = 223;
			// 
			// ID_R
			// 
			this.ID_R.DataPropertyName = "ID_R";
			this.ID_R.HeaderText = "Nick";
			this.ID_R.Name = "ID_R";
			this.ID_R.ReadOnly = true;
			this.ID_R.Width = 80;
			// 
			// Indicador
			// 
			this.Indicador.DataPropertyName = "Indicador";
			this.Indicador.HeaderText = "Unidad";
			this.Indicador.Name = "Indicador";
			this.Indicador.ReadOnly = true;
			this.Indicador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Indicador.Width = 40;
			// 
			// Fecha
			// 
			this.Fecha.DataPropertyName = "Fecha";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Fecha.DefaultCellStyle = dataGridViewCellStyle3;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			this.Fecha.Width = 70;
			// 
			// Hora
			// 
			this.Hora.HeaderText = "Hora";
			this.Hora.Name = "Hora";
			this.Hora.ReadOnly = true;
			this.Hora.Width = 40;
			// 
			// Empresa
			// 
			this.Empresa.DataPropertyName = "Empresa";
			this.Empresa.HeaderText = "Empresa";
			this.Empresa.Name = "Empresa";
			this.Empresa.ReadOnly = true;
			this.Empresa.Width = 260;
			// 
			// Ruta
			// 
			this.Ruta.DataPropertyName = "Ruta";
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			this.Ruta.Width = 180;
			// 
			// Turno
			// 
			this.Turno.DataPropertyName = "Turno";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Turno.DefaultCellStyle = dataGridViewCellStyle4;
			this.Turno.HeaderText = "Turno";
			this.Turno.Name = "Turno";
			this.Turno.ReadOnly = true;
			this.Turno.Width = 60;
			// 
			// Sentido
			// 
			this.Sentido.DataPropertyName = "Sentido";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Sentido.DefaultCellStyle = dataGridViewCellStyle5;
			this.Sentido.HeaderText = "Sentido";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			this.Sentido.Width = 50;
			// 
			// Km
			// 
			this.Km.HeaderText = "Km";
			this.Km.Name = "Km";
			this.Km.ReadOnly = true;
			this.Km.Width = 50;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(200, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 14);
			this.label4.TabIndex = 224;
			this.label4.Text = "Corte:";
			// 
			// txtRuta
			// 
			this.txtRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRuta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRuta.Location = new System.Drawing.Point(607, 8);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(82, 20);
			this.txtRuta.TabIndex = 226;
			this.txtRuta.TextChanged += new System.EventHandler(this.TxtRutaTextChanged);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(564, 11);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 14);
			this.label5.TabIndex = 225;
			this.label5.Text = "Ruta:";
			// 
			// FormReporteCombustible
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1020, 369);
			this.Controls.Add(this.txtRuta);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dataCombustible);
			this.Controls.Add(this.cmbHoraTermino);
			this.Controls.Add(this.cmbHoraInicio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUnidad);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataOtros);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.dtFechaTermino);
			this.Controls.Add(this.txtAlias);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtFechaInicio);
			this.Controls.Add(this.label10);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(879, 407);
			this.Name = "FormReporteCombustible";
			this.Text = "Transportes LAR - Reporte Combustible";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteCombustibleFormClosing);
			this.Load += new System.EventHandler(this.FormReporteCombustibleLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataOtros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataCombustible)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Nick;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Km;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_R;
		private System.Windows.Forms.DataGridView dataCombustible;
		private System.Windows.Forms.ComboBox cmbHoraTermino;
		private System.Windows.Forms.ComboBox cmbHoraInicio;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataOtros;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.DateTimePicker dtFechaTermino;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtFechaInicio;
	}
}
