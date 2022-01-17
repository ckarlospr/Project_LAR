/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 22/04/2013
 * Time: 03:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormCardex
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCardex));
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dgCardex = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.cbOperador = new System.Windows.Forms.CheckBox();
			this.cbD = new System.Windows.Forms.CheckBox();
			this.cbP = new System.Windows.Forms.CheckBox();
			this.cbT = new System.Windows.Forms.CheckBox();
			this.cbO = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmTurno4 = new System.Windows.Forms.CheckBox();
			this.cmTurno3 = new System.Windows.Forms.CheckBox();
			this.cmTurno2 = new System.Windows.Forms.CheckBox();
			this.cmTurno1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnExcel = new System.Windows.Forms.ToolStripButton();
			this.cmdMas = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seguimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.botonseguimiento = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Id_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgCardex)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(54, 8);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(100, 20);
			this.dtpInicio.TabIndex = 0;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(191, 9);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 20);
			this.dtpFin.TabIndex = 1;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// dgCardex
			// 
			this.dgCardex.AllowUserToAddRows = false;
			this.dgCardex.AllowUserToResizeColumns = false;
			this.dgCardex.AllowUserToResizeRows = false;
			this.dgCardex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgCardex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgCardex.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgCardex.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCardex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgCardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column8,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6,
									this.Column7,
									this.Seguimiento,
									this.Medida,
									this.botonseguimiento,
									this.Id_h});
			this.dgCardex.GridColor = System.Drawing.Color.Black;
			this.dgCardex.Location = new System.Drawing.Point(12, 175);
			this.dgCardex.Name = "dgCardex";
			this.dgCardex.RowHeadersVisible = false;
			this.dgCardex.Size = new System.Drawing.Size(817, 288);
			this.dgCardex.TabIndex = 3;
			this.dgCardex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCardexCellContentClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Inicio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(155, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Fin";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtOperador
			// 
			this.txtOperador.Enabled = false;
			this.txtOperador.Location = new System.Drawing.Point(623, 9);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(136, 20);
			this.txtOperador.TabIndex = 9;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.TextChanged += new System.EventHandler(this.TxtOperadorTextChanged);
			// 
			// cbOperador
			// 
			this.cbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbOperador.Location = new System.Drawing.Point(513, 10);
			this.cbOperador.Name = "cbOperador";
			this.cbOperador.Size = new System.Drawing.Size(104, 20);
			this.cbOperador.TabIndex = 10;
			this.cbOperador.Text = "Operador";
			this.cbOperador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cbOperador.UseVisualStyleBackColor = true;
			this.cbOperador.CheckedChanged += new System.EventHandler(this.CbOperadorCheckedChanged);
			// 
			// cbD
			// 
			this.cbD.Checked = true;
			this.cbD.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbD.Location = new System.Drawing.Point(6, 21);
			this.cbD.Name = "cbD";
			this.cbD.Size = new System.Drawing.Size(96, 21);
			this.cbD.TabIndex = 11;
			this.cbD.Text = "Dormidas";
			this.cbD.UseVisualStyleBackColor = true;
			this.cbD.CheckedChanged += new System.EventHandler(this.CbDCheckedChanged);
			// 
			// cbP
			// 
			this.cbP.Checked = true;
			this.cbP.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbP.Location = new System.Drawing.Point(108, 21);
			this.cbP.Name = "cbP";
			this.cbP.Size = new System.Drawing.Size(84, 21);
			this.cbP.TabIndex = 12;
			this.cbP.Text = "Permiso";
			this.cbP.UseVisualStyleBackColor = true;
			this.cbP.CheckedChanged += new System.EventHandler(this.CbPCheckedChanged);
			// 
			// cbT
			// 
			this.cbT.Checked = true;
			this.cbT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbT.Location = new System.Drawing.Point(198, 21);
			this.cbT.Name = "cbT";
			this.cbT.Size = new System.Drawing.Size(71, 21);
			this.cbT.TabIndex = 13;
			this.cbT.Text = "Taller";
			this.cbT.UseVisualStyleBackColor = true;
			this.cbT.CheckedChanged += new System.EventHandler(this.CbTCheckedChanged);
			// 
			// cbO
			// 
			this.cbO.Checked = true;
			this.cbO.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbO.Location = new System.Drawing.Point(275, 21);
			this.cbO.Name = "cbO";
			this.cbO.Size = new System.Drawing.Size(67, 21);
			this.cbO.TabIndex = 14;
			this.cbO.Text = "Otros";
			this.cbO.UseVisualStyleBackColor = true;
			this.cbO.CheckedChanged += new System.EventHandler(this.CbOCheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbO);
			this.groupBox1.Controls.Add(this.cbT);
			this.groupBox1.Controls.Add(this.cbP);
			this.groupBox1.Controls.Add(this.cbD);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(346, 46);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmTurno4);
			this.groupBox2.Controls.Add(this.cmTurno3);
			this.groupBox2.Controls.Add(this.cmTurno2);
			this.groupBox2.Controls.Add(this.cmTurno1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(355, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(404, 46);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tipo:";
			// 
			// cmTurno4
			// 
			this.cmTurno4.Checked = true;
			this.cmTurno4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cmTurno4.Location = new System.Drawing.Point(300, 19);
			this.cmTurno4.Name = "cmTurno4";
			this.cmTurno4.Size = new System.Drawing.Size(96, 21);
			this.cmTurno4.TabIndex = 14;
			this.cmTurno4.Text = "Nocturno";
			this.cmTurno4.UseVisualStyleBackColor = true;
			this.cmTurno4.CheckedChanged += new System.EventHandler(this.CmTurno4CheckedChanged);
			// 
			// cmTurno3
			// 
			this.cmTurno3.Checked = true;
			this.cmTurno3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cmTurno3.Location = new System.Drawing.Point(184, 19);
			this.cmTurno3.Name = "cmTurno3";
			this.cmTurno3.Size = new System.Drawing.Size(110, 21);
			this.cmTurno3.TabIndex = 13;
			this.cmTurno3.Text = "Vespertino";
			this.cmTurno3.UseVisualStyleBackColor = true;
			this.cmTurno3.CheckedChanged += new System.EventHandler(this.CmTurno3CheckedChanged);
			// 
			// cmTurno2
			// 
			this.cmTurno2.Checked = true;
			this.cmTurno2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cmTurno2.Location = new System.Drawing.Point(100, 19);
			this.cmTurno2.Name = "cmTurno2";
			this.cmTurno2.Size = new System.Drawing.Size(78, 21);
			this.cmTurno2.TabIndex = 12;
			this.cmTurno2.Text = "Medio día";
			this.cmTurno2.UseVisualStyleBackColor = true;
			this.cmTurno2.CheckedChanged += new System.EventHandler(this.CmTurno2CheckedChanged);
			// 
			// cmTurno1
			// 
			this.cmTurno1.Checked = true;
			this.cmTurno1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cmTurno1.Location = new System.Drawing.Point(12, 19);
			this.cmTurno1.Name = "cmTurno1";
			this.cmTurno1.Size = new System.Drawing.Size(82, 21);
			this.cmTurno1.TabIndex = 11;
			this.cmTurno1.Text = "Mañana";
			this.cmTurno1.UseVisualStyleBackColor = true;
			this.cmTurno1.CheckedChanged += new System.EventHandler(this.CmTurno1CheckedChanged);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(817, 53);
			this.label3.TabIndex = 17;
			this.label3.Text = "Cardex operador";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnExcel,
									this.cmdMas});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(848, 25);
			this.toolStrip1.TabIndex = 170;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnExcel
			// 
			this.btnExcel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(109, 22);
			this.btnExcel.Text = "Imprimir Excel";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// cmdMas
			// 
			this.cmdMas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdMas.Image = ((System.Drawing.Image)(resources.GetObject("cmdMas.Image")));
			this.cmdMas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdMas.Name = "cmdMas";
			this.cmdMas.Size = new System.Drawing.Size(117, 22);
			this.cmdMas.Text = "Agregar Cardex";
			this.cmdMas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdMas.Click += new System.EventHandler(this.CmdMasClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.dtpInicio);
			this.panel1.Controls.Add(this.dtpFin);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbOperador);
			this.panel1.Controls.Add(this.txtOperador);
			this.panel1.Location = new System.Drawing.Point(12, 87);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(817, 82);
			this.panel1.TabIndex = 171;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Alias";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 55;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Vehículo";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 72;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Fecha";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 59;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Hora";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 54;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Turno";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 59;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Estatus";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 65;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Descripcion";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 87;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Usuario";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 68;
			// 
			// Seguimiento
			// 
			this.Seguimiento.DataPropertyName = "ESTADO";
			this.Seguimiento.HeaderText = "Seguimiento";
			this.Seguimiento.Name = "Seguimiento";
			this.Seguimiento.Width = 90;
			// 
			// Medida
			// 
			this.Medida.DataPropertyName = "SEGUIMIENTO";
			this.Medida.HeaderText = "Medida";
			this.Medida.Name = "Medida";
			this.Medida.Width = 65;
			// 
			// botonseguimiento
			// 
			this.botonseguimiento.HeaderText = "#";
			this.botonseguimiento.Name = "botonseguimiento";
			this.botonseguimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.botonseguimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.botonseguimiento.Width = 37;
			// 
			// Id_h
			// 
			this.Id_h.HeaderText = "id";
			this.Id_h.Name = "Id_h";
			this.Id_h.Width = 41;
			// 
			// FormCardex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(848, 475);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dgCardex);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(858, 507);
			this.Name = "FormCardex";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Cardex operador";
			this.Load += new System.EventHandler(this.FormCardexLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgCardex)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_h;
		private System.Windows.Forms.DataGridViewButtonColumn botonseguimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Seguimiento;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripButton btnExcel;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton cmdMas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cmTurno1;
		private System.Windows.Forms.CheckBox cmTurno2;
		private System.Windows.Forms.CheckBox cmTurno3;
		private System.Windows.Forms.CheckBox cmTurno4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbO;
		private System.Windows.Forms.CheckBox cbT;
		private System.Windows.Forms.CheckBox cbP;
		private System.Windows.Forms.CheckBox cbD;
		private System.Windows.Forms.CheckBox cbOperador;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgCardex;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
	}
}
