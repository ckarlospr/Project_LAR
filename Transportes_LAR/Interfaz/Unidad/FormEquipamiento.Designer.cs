/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 26/07/2012
 * Time: 10:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Unidad
{
	partial class FormEquipamiento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipamiento));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.numCantidad = new System.Windows.Forms.NumericUpDown();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.btnRemover = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dataEquipamiento = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataEquipamiento)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(660, 51);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(65, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingrese el equipamiento del vehículo:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnAceptar);
			this.panel2.Controls.Add(this.btnAgregar);
			this.panel2.Controls.Add(this.numCantidad);
			this.panel2.Controls.Add(this.cmbCategoria);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label23);
			this.panel2.Controls.Add(this.txtDescripcion);
			this.panel2.Controls.Add(this.label26);
			this.panel2.Controls.Add(this.btnRemover);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dataEquipamiento);
			this.panel2.Location = new System.Drawing.Point(0, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(660, 278);
			this.panel2.TabIndex = 1;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(563, 232);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(87, 26);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(474, 232);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(87, 26);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// numCantidad
			// 
			this.numCantidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numCantidad.Location = new System.Drawing.Point(459, 84);
			this.numCantidad.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numCantidad.Name = "numCantidad";
			this.numCantidad.Size = new System.Drawing.Size(185, 20);
			this.numCantidad.TabIndex = 3;
			this.numCantidad.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.DisplayMember = "Nombre";
			this.cmbCategoria.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(459, 31);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(185, 22);
			this.cmbCategoria.TabIndex = 1;
			this.cmbCategoria.ValueMember = "Nombre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(401, 86);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 14);
			this.label6.TabIndex = 134;
			this.label6.Text = "Cantidad:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(387, 61);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(67, 14);
			this.label23.TabIndex = 133;
			this.label23.Text = "Descripción:";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(459, 58);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(185, 20);
			this.txtDescripcion.TabIndex = 2;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(398, 34);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(56, 14);
			this.label26.TabIndex = 132;
			this.label26.Text = "Categoria:";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRemover
			// 
			this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemover.BackColor = System.Drawing.Color.Transparent;
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
			this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemover.Location = new System.Drawing.Point(381, 232);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(92, 26);
			this.btnRemover.TabIndex = 4;
			this.btnRemover.Text = "Remover";
			this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemover.UseVisualStyleBackColor = false;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(396, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(251, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "Artículo:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataEquipamiento
			// 
			this.dataEquipamiento.AllowUserToAddRows = false;
			this.dataEquipamiento.AllowUserToDeleteRows = false;
			this.dataEquipamiento.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataEquipamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataEquipamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.dataCategoria,
									this.dataDescripcion,
									this.dataCantidad});
			this.dataEquipamiento.Location = new System.Drawing.Point(8, 5);
			this.dataEquipamiento.Name = "dataEquipamiento";
			this.dataEquipamiento.ReadOnly = true;
			this.dataEquipamiento.RowHeadersVisible = false;
			this.dataEquipamiento.RowHeadersWidth = 25;
			this.dataEquipamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataEquipamiento.Size = new System.Drawing.Size(364, 253);
			this.dataEquipamiento.TabIndex = 7;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "idUnidad";
			this.Column1.HeaderText = "IdUnidad";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "idCategoria";
			this.Column2.HeaderText = "IdCategoria";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Visible = false;
			// 
			// dataCategoria
			// 
			this.dataCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataCategoria.DataPropertyName = "Categoria";
			this.dataCategoria.HeaderText = "Categoria";
			this.dataCategoria.Name = "dataCategoria";
			this.dataCategoria.ReadOnly = true;
			// 
			// dataDescripcion
			// 
			this.dataDescripcion.DataPropertyName = "Descripcion";
			this.dataDescripcion.HeaderText = "Descripcion";
			this.dataDescripcion.Name = "dataDescripcion";
			this.dataDescripcion.ReadOnly = true;
			this.dataDescripcion.Width = 150;
			// 
			// dataCantidad
			// 
			this.dataCantidad.DataPropertyName = "Cantidad";
			this.dataCantidad.HeaderText = "Cantidad";
			this.dataCantidad.Name = "dataCantidad";
			this.dataCantidad.ReadOnly = true;
			// 
			// FormEquipamiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(657, 371);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.On;
			this.MaximizeBox = false;
			this.Name = "FormEquipamiento";
			this.Text = "Transportes LAR - Equipamiento";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEquipamientoFormClosing);
			this.Load += new System.EventHandler(this.FormEquipamientoLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataEquipamiento)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Button btnAceptar;
		public System.Windows.Forms.Button btnAgregar;
		public System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Label label26;
		public System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox cmbCategoria;
		public System.Windows.Forms.NumericUpDown numCantidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataCategoria;
		public System.Windows.Forms.DataGridView dataEquipamiento;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
