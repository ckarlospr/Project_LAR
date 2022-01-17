/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 20/07/2012
 * Time: 23:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Zona
{
	partial class FormZona
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZona));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataZonaColindancia = new System.Windows.Forms.DataGridView();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataZonaRegistrada = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtZonaDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataZonaColindancia)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataZonaRegistrada)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.btnAceptar);
			this.panel1.Controls.Add(this.btnRemover);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Location = new System.Drawing.Point(13, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 485);
			this.panel1.TabIndex = 0;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(339, 442);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(83, 28);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnRemover
			// 
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
			this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemover.Location = new System.Drawing.Point(104, 291);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(93, 27);
			this.btnRemover.TabIndex = 237;
			this.btnRemover.Text = "Remover";
			this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(9, 291);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(89, 27);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dataZonaColindancia);
			this.groupBox2.Location = new System.Drawing.Point(220, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(204, 273);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Colindancia";
			// 
			// dataZonaColindancia
			// 
			this.dataZonaColindancia.AllowUserToAddRows = false;
			this.dataZonaColindancia.AllowUserToDeleteRows = false;
			this.dataZonaColindancia.AllowUserToResizeColumns = false;
			this.dataZonaColindancia.AllowUserToResizeRows = false;
			this.dataZonaColindancia.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataZonaColindancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataZonaColindancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataZonaColindancia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column3,
									this.Column5,
									this.Column4});
			this.dataZonaColindancia.Location = new System.Drawing.Point(6, 19);
			this.dataZonaColindancia.MultiSelect = false;
			this.dataZonaColindancia.Name = "dataZonaColindancia";
			this.dataZonaColindancia.ReadOnly = true;
			this.dataZonaColindancia.RowHeadersVisible = false;
			this.dataZonaColindancia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataZonaColindancia.Size = new System.Drawing.Size(187, 242);
			this.dataZonaColindancia.TabIndex = 238;
			this.dataZonaColindancia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataZonaColindanciaCellClick);
			// 
			// Column3
			// 
			this.Column3.HeaderText = "ID";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column3.Visible = false;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 20;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Zona colindante";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column4.Width = 162;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dataZonaRegistrada);
			this.groupBox1.Location = new System.Drawing.Point(11, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(203, 273);
			this.groupBox1.TabIndex = 236;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Zonas registradas";
			// 
			// dataZonaRegistrada
			// 
			this.dataZonaRegistrada.AllowUserToAddRows = false;
			this.dataZonaRegistrada.AllowUserToDeleteRows = false;
			this.dataZonaRegistrada.AllowUserToResizeColumns = false;
			this.dataZonaRegistrada.AllowUserToResizeRows = false;
			this.dataZonaRegistrada.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataZonaRegistrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataZonaRegistrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataZonaRegistrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2});
			this.dataZonaRegistrada.Location = new System.Drawing.Point(10, 17);
			this.dataZonaRegistrada.MultiSelect = false;
			this.dataZonaRegistrada.Name = "dataZonaRegistrada";
			this.dataZonaRegistrada.ReadOnly = true;
			this.dataZonaRegistrada.RowHeadersVisible = false;
			this.dataZonaRegistrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataZonaRegistrada.Size = new System.Drawing.Size(187, 242);
			this.dataZonaRegistrada.TabIndex = 8;
			this.dataZonaRegistrada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataZonaRegistradaCellClick);
			this.dataZonaRegistrada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataZonaRegistradaKeyUp);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Nombre zona";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column2.Width = 182;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.txtZonaDescripcion);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Location = new System.Drawing.Point(9, 332);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(413, 104);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			// 
			// txtZonaDescripcion
			// 
			this.txtZonaDescripcion.BackColor = System.Drawing.SystemColors.Menu;
			this.txtZonaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtZonaDescripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtZonaDescripcion.Location = new System.Drawing.Point(7, 26);
			this.txtZonaDescripcion.Multiline = true;
			this.txtZonaDescripcion.Name = "txtZonaDescripcion";
			this.txtZonaDescripcion.Size = new System.Drawing.Size(401, 70);
			this.txtZonaDescripcion.TabIndex = 9;
			this.txtZonaDescripcion.TextChanged += new System.EventHandler(this.TxtZonaDescripcionTextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(413, 20);
			this.label2.TabIndex = 233;
			this.label2.Text = "Descripción de la zona";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(54, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Seleccione la zona y marque sus colindancias:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(-3, -7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(478, 75);
			this.label3.TabIndex = 8;
			// 
			// FormZona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(465, 556);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormZona";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Zona";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormZonaFormClosing);
			this.Load += new System.EventHandler(this.FormZonaLoad);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataZonaColindancia)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataZonaRegistrada)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtZonaDescripcion;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataZonaRegistrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridView dataZonaColindancia;
		private System.Windows.Forms.Panel panel1;
	}
}
