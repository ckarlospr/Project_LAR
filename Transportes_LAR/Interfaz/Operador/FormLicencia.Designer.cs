/*
 * Created by SharpDevelop.
 * User: Rosy
 * Date: 12/07/2012
 * Time: 06:03 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormLicencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicencia));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.dateVigencia = new System.Windows.Forms.DateTimePicker();
			this.label47 = new System.Windows.Forms.Label();
			this.cmbClase = new System.Windows.Forms.ComboBox();
			this.label46 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRemoverLicencia = new System.Windows.Forms.Button();
			this.btnAgregarLicencia = new System.Windows.Forms.Button();
			this.dataLicencia = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataLicencia)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(757, 70);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(7, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(61, 60);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(74, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(404, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingrese los datos de las licencias con las cules cuenta el operador.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.btnAgregar);
			this.panel2.Controls.Add(this.txtNumero);
			this.panel2.Controls.Add(this.label45);
			this.panel2.Controls.Add(this.label50);
			this.panel2.Controls.Add(this.dateVigencia);
			this.panel2.Controls.Add(this.label47);
			this.panel2.Controls.Add(this.cmbClase);
			this.panel2.Controls.Add(this.label46);
			this.panel2.Controls.Add(this.cmbTipo);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnRemoverLicencia);
			this.panel2.Controls.Add(this.btnAgregarLicencia);
			this.panel2.Controls.Add(this.dataLicencia);
			this.panel2.Location = new System.Drawing.Point(0, 70);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(757, 289);
			this.panel2.TabIndex = 2;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(662, 241);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(86, 28);
			this.btnAgregar.TabIndex = 7;
			this.btnAgregar.Text = "Aceptar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(532, 36);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(211, 20);
			this.txtNumero.TabIndex = 1;
			this.txtNumero.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// label45
			// 
			this.label45.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label45.Location = new System.Drawing.Point(471, 36);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(56, 18);
			this.label45.TabIndex = 29;
			this.label45.Text = "Numero:";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label50
			// 
			this.label50.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label50.Location = new System.Drawing.Point(471, 117);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(57, 20);
			this.label50.TabIndex = 25;
			this.label50.Text = "Vigencia:";
			this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateVigencia
			// 
			this.dateVigencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateVigencia.Location = new System.Drawing.Point(532, 117);
			this.dateVigencia.Name = "dateVigencia";
			this.dateVigencia.Size = new System.Drawing.Size(211, 20);
			this.dateVigencia.TabIndex = 4;
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label47.Location = new System.Drawing.Point(471, 62);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(57, 18);
			this.label47.TabIndex = 24;
			this.label47.Text = "Clase:";
			this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbClase
			// 
			this.cmbClase.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbClase.FormattingEnabled = true;
			this.cmbClase.Items.AddRange(new object[] {
									"Estatal",
									"Federal"});
			this.cmbClase.Location = new System.Drawing.Point(532, 62);
			this.cmbClase.Name = "cmbClase";
			this.cmbClase.Size = new System.Drawing.Size(210, 22);
			this.cmbClase.TabIndex = 2;
			this.cmbClase.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// label46
			// 
			this.label46.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label46.Location = new System.Drawing.Point(489, 92);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(39, 23);
			this.label46.TabIndex = 23;
			this.label46.Text = "Tipo:";
			this.label46.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmbTipo
			// 
			this.cmbTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"A",
									"B",
									"C2",
									"C4"});
			this.cmbTipo.Location = new System.Drawing.Point(532, 89);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(211, 22);
			this.cmbTipo.TabIndex = 3;
			this.cmbTipo.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(463, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(282, 23);
			this.label2.TabIndex = 17;
			this.label2.Text = "Datos de la licencia:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRemoverLicencia
			// 
			this.btnRemoverLicencia.BackColor = System.Drawing.Color.Transparent;
			this.btnRemoverLicencia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemoverLicencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoverLicencia.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverLicencia.Image")));
			this.btnRemoverLicencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemoverLicencia.Location = new System.Drawing.Point(463, 241);
			this.btnRemoverLicencia.Name = "btnRemoverLicencia";
			this.btnRemoverLicencia.Size = new System.Drawing.Size(98, 28);
			this.btnRemoverLicencia.TabIndex = 6;
			this.btnRemoverLicencia.Text = "Remover";
			this.btnRemoverLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverLicencia.UseVisualStyleBackColor = false;
			this.btnRemoverLicencia.Click += new System.EventHandler(this.BtnRemoverLicenciaClick);
			// 
			// btnAgregarLicencia
			// 
			this.btnAgregarLicencia.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregarLicencia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarLicencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarLicencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLicencia.Image")));
			this.btnAgregarLicencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarLicencia.Location = new System.Drawing.Point(567, 241);
			this.btnAgregarLicencia.Name = "btnAgregarLicencia";
			this.btnAgregarLicencia.Size = new System.Drawing.Size(86, 28);
			this.btnAgregarLicencia.TabIndex = 5;
			this.btnAgregarLicencia.Text = "Agregar";
			this.btnAgregarLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregarLicencia.UseVisualStyleBackColor = false;
			this.btnAgregarLicencia.Click += new System.EventHandler(this.BtnAgregarLicenciaClick);
			// 
			// dataLicencia
			// 
			this.dataLicencia.AllowUserToAddRows = false;
			this.dataLicencia.AllowUserToDeleteRows = false;
			this.dataLicencia.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataLicencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataLicencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataLicencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataLicencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column3,
									this.Column2,
									this.Column4,
									this.Column5});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataLicencia.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataLicencia.Location = new System.Drawing.Point(11, 10);
			this.dataLicencia.Name = "dataLicencia";
			this.dataLicencia.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataLicencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataLicencia.RowHeadersVisible = false;
			this.dataLicencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataLicencia.Size = new System.Drawing.Size(446, 259);
			this.dataLicencia.TabIndex = 8;
			this.dataLicencia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLicenciaCellDoubleClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "id";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "numero";
			this.Column3.HeaderText = "Numero";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 150;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "clase";
			this.Column2.HeaderText = "Clase";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "tipo";
			this.Column4.HeaderText = "Tipo";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 40;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "vigencia";
			this.Column5.HeaderText = "Vigencia";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 150;
			// 
			// FormLicencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(757, 405);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(392, 260);
			this.Name = "FormLicencia";
			this.Text = "Transportes LAR - Licencias del operador";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLicenciaFormClosing);
			this.Load += new System.EventHandler(this.FormLicenciaLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataLicencia)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Label label45;
		public System.Windows.Forms.TextBox txtNumero;
		public System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label46;
		public System.Windows.Forms.ComboBox cmbClase;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.DateTimePicker dateVigencia;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataLicencia;
		public System.Windows.Forms.Button btnAgregarLicencia;
		public System.Windows.Forms.Button btnRemoverLicencia;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
