namespace Transportes_LAR.Interfaz.Nomina.Recibo
{
	partial class FormSueldos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSueldos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataImpuestos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardarEditar = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbVista = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INFONAVIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telcel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IMSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sueldo_Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Aguinaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Compensacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Retener = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataImpuestos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataImpuestos
			// 
			this.dataImpuestos.AllowUserToAddRows = false;
			this.dataImpuestos.AllowUserToResizeRows = false;
			this.dataImpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataImpuestos.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Alias,
									this.INFONAVIT,
									this.Telcel,
									this.ISR,
									this.IMSS,
									this.Sueldo_Base,
									this.Clave,
									this.Aguinaldo,
									this.Compensacion,
									this.Retener});
			this.dataImpuestos.Location = new System.Drawing.Point(12, 92);
			this.dataImpuestos.Name = "dataImpuestos";
			this.dataImpuestos.RowHeadersVisible = false;
			this.dataImpuestos.Size = new System.Drawing.Size(1215, 458);
			this.dataImpuestos.TabIndex = 5;
			this.dataImpuestos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataImpuestosEditingControlShowing);
			this.dataImpuestos.Enter += new System.EventHandler(this.DataImpuestosEnter);
			this.dataImpuestos.MouseEnter += new System.EventHandler(this.DataImpuestosMouseEnter);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-4, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1246, 80);
			this.label1.TabIndex = 6;
			this.label1.Text = "Percepciones y Deduccciones del Periodo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(64, 28);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(305, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// txtAlias
			// 
			this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAlias.Location = new System.Drawing.Point(64, 3);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(158, 20);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "Nombre";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(1143, 556);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(84, 31);
			this.btnCancelar.TabIndex = 168;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnGuardarEditar
			// 
			this.btnGuardarEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardarEditar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardarEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarEditar.Image")));
			this.btnGuardarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarEditar.Location = new System.Drawing.Point(1055, 556);
			this.btnGuardarEditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnGuardarEditar.Name = "btnGuardarEditar";
			this.btnGuardarEditar.Size = new System.Drawing.Size(84, 31);
			this.btnGuardarEditar.TabIndex = 167;
			this.btnGuardarEditar.Text = "Guardar";
			this.btnGuardarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarEditar.UseVisualStyleBackColor = false;
			this.btnGuardarEditar.Click += new System.EventHandler(this.BtnGuardarEditarClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(821, 21);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(39, 34);
			this.pictureBox2.TabIndex = 170;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(375, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 34);
			this.pictureBox1.TabIndex = 171;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nick";
			// 
			// cmbVista
			// 
			this.cmbVista.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbVista.FormattingEnabled = true;
			this.cmbVista.Items.AddRange(new object[] {
									"Normal",
									"Aguinaldo"});
			this.cmbVista.Location = new System.Drawing.Point(64, 53);
			this.cmbVista.Name = "cmbVista";
			this.cmbVista.Size = new System.Drawing.Size(158, 22);
			this.cmbVista.TabIndex = 172;
			this.cmbVista.SelectedIndexChanged += new System.EventHandler(this.CmbVistaSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 19);
			this.label3.TabIndex = 173;
			this.label3.Text = "Vista";
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			dataGridViewCellStyle1.NullValue = "0";
			this.ID.DefaultCellStyle = dataGridViewCellStyle1;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// Alias
			// 
			this.Alias.DataPropertyName = "Alias";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alias.DefaultCellStyle = dataGridViewCellStyle2;
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			// 
			// INFONAVIT
			// 
			this.INFONAVIT.DataPropertyName = "INFONAVIT";
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = null;
			this.INFONAVIT.DefaultCellStyle = dataGridViewCellStyle3;
			this.INFONAVIT.HeaderText = "INFONAVIT";
			this.INFONAVIT.Name = "INFONAVIT";
			// 
			// Telcel
			// 
			this.Telcel.DataPropertyName = "Telcel";
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = null;
			this.Telcel.DefaultCellStyle = dataGridViewCellStyle4;
			this.Telcel.HeaderText = "Telcel";
			this.Telcel.Name = "Telcel";
			// 
			// ISR
			// 
			this.ISR.DataPropertyName = "ISR";
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = null;
			this.ISR.DefaultCellStyle = dataGridViewCellStyle5;
			this.ISR.HeaderText = "ISR";
			this.ISR.Name = "ISR";
			this.ISR.Visible = false;
			// 
			// IMSS
			// 
			this.IMSS.DataPropertyName = "IMSS";
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = null;
			this.IMSS.DefaultCellStyle = dataGridViewCellStyle6;
			this.IMSS.HeaderText = "IMSS";
			this.IMSS.Name = "IMSS";
			// 
			// Sueldo_Base
			// 
			this.Sueldo_Base.DataPropertyName = "Sueldo_Base";
			dataGridViewCellStyle7.Format = "N2";
			dataGridViewCellStyle7.NullValue = null;
			this.Sueldo_Base.DefaultCellStyle = dataGridViewCellStyle7;
			this.Sueldo_Base.HeaderText = "Sueldo Base";
			this.Sueldo_Base.Name = "Sueldo_Base";
			// 
			// Clave
			// 
			this.Clave.DataPropertyName = "Clave";
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.Visible = false;
			// 
			// Aguinaldo
			// 
			this.Aguinaldo.DataPropertyName = "Aguinaldo";
			this.Aguinaldo.HeaderText = "Aguinaldo";
			this.Aguinaldo.Name = "Aguinaldo";
			// 
			// Compensacion
			// 
			this.Compensacion.DataPropertyName = "Compensacion";
			this.Compensacion.HeaderText = "Compensacion";
			this.Compensacion.Name = "Compensacion";
			// 
			// Retener
			// 
			this.Retener.DataPropertyName = "Retener";
			this.Retener.HeaderText = "Retener";
			this.Retener.Name = "Retener";
			// 
			// FormSueldos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1238, 593);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbVista);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtAlias);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardarEditar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataImpuestos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormSueldos";
			this.Text = "Transportes LAR - Sueldos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSueldosFormClosing);
			this.Load += new System.EventHandler(this.FormSueldosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataImpuestos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbVista;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Retener;
		private System.Windows.Forms.DataGridViewTextBoxColumn Compensacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Aguinaldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo_Base;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Button btnGuardarEditar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn IMSS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ISR;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn INFONAVIT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dataImpuestos;		
	}
}
