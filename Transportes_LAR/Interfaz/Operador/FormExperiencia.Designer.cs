/*
 * Created by SharpDevelop.
 * User: Xavi_Ochoa
 * Date: 07/05/2014
 * Time: 07:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormExperiencia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExperiencia));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.pOperador = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbgiro = new System.Windows.Forms.ComboBox();
			this.lblGiro = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTiempo = new System.Windows.Forms.TextBox();
			this.dataIngreso = new System.Windows.Forms.DataGridView();
			this.ID_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Giro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.X = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnExcelExperiencia = new System.Windows.Forms.Button();
			this.pOperador.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataIngreso)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(331, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(326, 26);
			this.label1.TabIndex = 148;
			this.label1.Text = "Experiencia Laboral";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pOperador
			// 
			this.pOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pOperador.BackColor = System.Drawing.Color.MidnightBlue;
			this.pOperador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pOperador.BackgroundImage")));
			this.pOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperador.Controls.Add(this.groupBox1);
			this.pOperador.Controls.Add(this.groupBox2);
			this.pOperador.Location = new System.Drawing.Point(12, 12);
			this.pOperador.Name = "pOperador";
			this.pOperador.Size = new System.Drawing.Size(313, 465);
			this.pOperador.TabIndex = 147;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.ptbImagen);
			this.groupBox1.Controls.Add(this.txtAlias);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(279, 189);
			this.groupBox1.TabIndex = 185;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operador";
			// 
			// ptbImagen
			// 
			this.ptbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ptbImagen.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ptbImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptbImagen.Image")));
			this.ptbImagen.Location = new System.Drawing.Point(80, 21);
			this.ptbImagen.Name = "ptbImagen";
			this.ptbImagen.Size = new System.Drawing.Size(121, 127);
			this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagen.TabIndex = 165;
			this.ptbImagen.TabStop = false;
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAlias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(108, 154);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(91, 22);
			this.txtAlias.TabIndex = 1;
			this.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(80, 152);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 24);
			this.pictureBox1.TabIndex = 147;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.btnExcelExperiencia);
			this.groupBox2.Controls.Add(this.cmbgiro);
			this.groupBox2.Controls.Add(this.lblGiro);
			this.groupBox2.Controls.Add(this.btnAgregar);
			this.groupBox2.Controls.Add(this.label35);
			this.groupBox2.Controls.Add(this.label36);
			this.groupBox2.Controls.Add(this.txtNombre);
			this.groupBox2.Controls.Add(this.txtTiempo);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(16, 208);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(279, 231);
			this.groupBox2.TabIndex = 173;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Experiencia Laboral";
			// 
			// cmbgiro
			// 
			this.cmbgiro.FormattingEnabled = true;
			this.cmbgiro.Items.AddRange(new object[] {
									"CARGA",
									"PERSONAL"});
			this.cmbgiro.Location = new System.Drawing.Point(142, 45);
			this.cmbgiro.Name = "cmbgiro";
			this.cmbgiro.Size = new System.Drawing.Size(131, 22);
			this.cmbgiro.TabIndex = 3;
			// 
			// lblGiro
			// 
			this.lblGiro.BackColor = System.Drawing.Color.White;
			this.lblGiro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGiro.Location = new System.Drawing.Point(15, 50);
			this.lblGiro.Name = "lblGiro";
			this.lblGiro.Size = new System.Drawing.Size(59, 17);
			this.lblGiro.TabIndex = 189;
			this.lblGiro.Text = "Giro";
			this.lblGiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
			this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(247, 102);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(26, 22);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.White;
			this.label35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(15, 79);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(59, 17);
			this.label35.TabIndex = 184;
			this.label35.Text = "Tiempo";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label36
			// 
			this.label36.BackColor = System.Drawing.Color.White;
			this.label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(15, 17);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(121, 22);
			this.label36.TabIndex = 182;
			this.label36.Text = "Nombre de la Empresa";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(142, 17);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(131, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtTiempo
			// 
			this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTiempo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTiempo.Location = new System.Drawing.Point(142, 76);
			this.txtTiempo.Name = "txtTiempo";
			this.txtTiempo.Size = new System.Drawing.Size(131, 20);
			this.txtTiempo.TabIndex = 4;
			this.txtTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dataIngreso
			// 
			this.dataIngreso.AllowUserToAddRows = false;
			this.dataIngreso.AllowUserToResizeColumns = false;
			this.dataIngreso.AllowUserToResizeRows = false;
			this.dataIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataIngreso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataIngreso.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_R,
									this.NombreEmpresa,
									this.Giro,
									this.Tiempo,
									this.X});
			this.dataIngreso.Location = new System.Drawing.Point(331, 49);
			this.dataIngreso.Name = "dataIngreso";
			this.dataIngreso.RowHeadersVisible = false;
			this.dataIngreso.Size = new System.Drawing.Size(326, 428);
			this.dataIngreso.TabIndex = 146;
			this.dataIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataIngresoCellContentClick);
			this.dataIngreso.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataIngresoCellPainting);
			// 
			// ID_R
			// 
			this.ID_R.DataPropertyName = "ID_R";
			this.ID_R.HeaderText = "ID";
			this.ID_R.Name = "ID_R";
			this.ID_R.ReadOnly = true;
			this.ID_R.Visible = false;
			this.ID_R.Width = 22;
			// 
			// NombreEmpresa
			// 
			this.NombreEmpresa.HeaderText = "Nombre";
			this.NombreEmpresa.Name = "NombreEmpresa";
			this.NombreEmpresa.ReadOnly = true;
			this.NombreEmpresa.Width = 69;
			// 
			// Giro
			// 
			this.Giro.HeaderText = "Giro";
			this.Giro.Name = "Giro";
			this.Giro.ReadOnly = true;
			this.Giro.Width = 52;
			// 
			// Tiempo
			// 
			this.Tiempo.HeaderText = "Tiempo";
			this.Tiempo.Name = "Tiempo";
			this.Tiempo.ReadOnly = true;
			this.Tiempo.Width = 66;
			// 
			// X
			// 
			this.X.HeaderText = "";
			this.X.Name = "X";
			this.X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.X.Width = 19;
			// 
			// btnExcelExperiencia
			// 
			this.btnExcelExperiencia.BackColor = System.Drawing.SystemColors.Control;
			this.btnExcelExperiencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcelExperiencia.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExperiencia.Image")));
			this.btnExcelExperiencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcelExperiencia.Location = new System.Drawing.Point(6, 195);
			this.btnExcelExperiencia.Name = "btnExcelExperiencia";
			this.btnExcelExperiencia.Size = new System.Drawing.Size(79, 30);
			this.btnExcelExperiencia.TabIndex = 191;
			this.btnExcelExperiencia.Text = "Reporte";
			this.btnExcelExperiencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcelExperiencia.UseVisualStyleBackColor = false;
			this.btnExcelExperiencia.Click += new System.EventHandler(this.BtnExcelExperienciaClick);
			// 
			// FormExperiencia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(669, 489);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pOperador);
			this.Controls.Add(this.dataIngreso);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormExperiencia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Experiencia del Operador";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExperienciaFormClosing);
			this.Load += new System.EventHandler(this.FormExperienciaLoad);
			this.pOperador.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataIngreso)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnExcelExperiencia;
		private System.Windows.Forms.DataGridViewButtonColumn X;
		private System.Windows.Forms.ComboBox cmbgiro;
		private System.Windows.Forms.Label lblGiro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Giro;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_R;
		private System.Windows.Forms.DataGridView dataIngreso;
		private System.Windows.Forms.TextBox txtTiempo;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtAlias;
		public System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pOperador;
		private System.Windows.Forms.Label label1;
	}
}
