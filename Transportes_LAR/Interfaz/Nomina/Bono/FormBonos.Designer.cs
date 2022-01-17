namespace Transportes_LAR.Interfaz.Nomina.Bono
{
	partial class FormBonos
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBonos));
			this.dataBonos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id_operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BonoNormal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BonoExtra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BonoEspecial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Apoyo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Bonificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.dtFechaActual = new System.Windows.Forms.DateTimePicker();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataBonos)).BeginInit();
			this.groupBox18.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataBonos
			// 
			this.dataBonos.AllowUserToAddRows = false;
			this.dataBonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataBonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataBonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataBonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataBonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Id_operador,
									this.Alias,
									this.BonoNormal,
									this.BonoExtra,
									this.BonoEspecial,
									this.Apoyo,
									this.Cantidad,
									this.Bonificacion});
			this.dataBonos.Location = new System.Drawing.Point(11, 102);
			this.dataBonos.Name = "dataBonos";
			this.dataBonos.RowHeadersVisible = false;
			this.dataBonos.Size = new System.Drawing.Size(717, 433);
			this.dataBonos.TabIndex = 0;
			this.dataBonos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBonosCellContentClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// Id_operador
			// 
			this.Id_operador.HeaderText = "ID_O";
			this.Id_operador.Name = "Id_operador";
			this.Id_operador.Visible = false;
			// 
			// Alias
			// 
			this.Alias.DataPropertyName = "Alias";
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alias.DefaultCellStyle = dataGridViewCellStyle1;
			this.Alias.HeaderText = "Nick";
			this.Alias.Name = "Alias";
			// 
			// BonoNormal
			// 
			this.BonoNormal.DataPropertyName = "BonoNormal";
			this.BonoNormal.HeaderText = "Bono Normal";
			this.BonoNormal.Name = "BonoNormal";
			this.BonoNormal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.BonoNormal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// BonoExtra
			// 
			this.BonoExtra.DataPropertyName = "BonoExtra";
			this.BonoExtra.FalseValue = "";
			this.BonoExtra.HeaderText = "Bono Extra (Rendimiento)";
			this.BonoExtra.Name = "BonoExtra";
			// 
			// BonoEspecial
			// 
			this.BonoEspecial.DataPropertyName = "BonoEspecial";
			this.BonoEspecial.HeaderText = "Bono Especial";
			this.BonoEspecial.Name = "BonoEspecial";
			// 
			// Apoyo
			// 
			this.Apoyo.HeaderText = "Apoyo Coordinación";
			this.Apoyo.Name = "Apoyo";
			this.Apoyo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Apoyo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Apoyo.Visible = false;
			// 
			// Cantidad
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
			this.Cantidad.HeaderText = "Cantidad A.Coordinación";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Visible = false;
			// 
			// Bonificacion
			// 
			this.Bonificacion.HeaderText = "Bonificación";
			this.Bonificacion.Name = "Bonificacion";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(-2, -22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(747, 67);
			this.label1.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(-2, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(747, 36);
			this.label3.TabIndex = 5;
			this.label3.Text = "Control de Bonos";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 500;
			this.toolTip.ReshowDelay = 100;
			this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.txtAlias);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(11, 51);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(253, 45);
			this.groupBox18.TabIndex = 150;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Busqueda del Operador por Nick";
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAlias.Location = new System.Drawing.Point(6, 16);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(237, 20);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// groupBox13
			// 
			this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox13.BackColor = System.Drawing.Color.Transparent;
			this.groupBox13.Controls.Add(this.dtFechaActual);
			this.groupBox13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox13.Location = new System.Drawing.Point(623, 51);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(105, 46);
			this.groupBox13.TabIndex = 152;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Fecha Actual";
			// 
			// dtFechaActual
			// 
			this.dtFechaActual.CustomFormat = "yyyy-MM-dd";
			this.dtFechaActual.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaActual.Location = new System.Drawing.Point(4, 20);
			this.dtFechaActual.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtFechaActual.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtFechaActual.Name = "dtFechaActual";
			this.dtFechaActual.Size = new System.Drawing.Size(96, 20);
			this.dtFechaActual.TabIndex = 200;
			this.dtFechaActual.ValueChanged += new System.EventHandler(this.DtFechaActualValueChanged);
			// 
			// groupBox12
			// 
			this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox12.BackColor = System.Drawing.Color.Transparent;
			this.groupBox12.Controls.Add(this.dtInicio);
			this.groupBox12.Controls.Add(this.label13);
			this.groupBox12.Controls.Add(this.dtCorte);
			this.groupBox12.Controls.Add(this.lblFechaCorte);
			this.groupBox12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox12.Location = new System.Drawing.Point(370, 51);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(248, 46);
			this.groupBox12.TabIndex = 151;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Periodo de Quincena";
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Enabled = false;
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(41, 19);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(76, 20);
			this.dtInicio.TabIndex = 142;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(3, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 22);
			this.label13.TabIndex = 140;
			this.label13.Text = "Inicio:";
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Enabled = false;
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(163, 19);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(78, 20);
			this.dtCorte.TabIndex = 143;
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(120, 21);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(47, 18);
			this.lblFechaCorte.TabIndex = 141;
			this.lblFechaCorte.Text = "Corte:";
			// 
			// FormBonos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(740, 559);
			this.Controls.Add(this.groupBox13);
			this.Controls.Add(this.groupBox12);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataBonos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBonos";
			this.Text = "Transportes LAR - Bonos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBonosFormClosing);
			this.Load += new System.EventHandler(this.FormBonosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataBonos)).EndInit();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.groupBox13.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewCheckBoxColumn Bonificacion;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.DateTimePicker dtFechaActual;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Apoyo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_operador;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BonoNormal;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BonoEspecial;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BonoExtra;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataBonos;
	}
}
