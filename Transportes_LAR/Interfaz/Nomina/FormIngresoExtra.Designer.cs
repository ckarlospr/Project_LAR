/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 12/07/2013
 * Time: 01:18 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina
{
	partial class FormIngresoExtra
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoExtra));
			this.dataIngreso = new System.Windows.Forms.DataGridView();
			this.ID_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.B = new System.Windows.Forms.DataGridViewButtonColumn();
			this.pOperador = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtFiniquito = new System.Windows.Forms.TextBox();
			this.ckFiniquito = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExtras = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtImporteIng = new System.Windows.Forms.TextBox();
			this.txtDetalleIng = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataIngreso)).BeginInit();
			this.pOperador.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataIngreso
			// 
			this.dataIngreso.AllowUserToAddRows = false;
			this.dataIngreso.AllowUserToResizeColumns = false;
			this.dataIngreso.AllowUserToResizeRows = false;
			this.dataIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
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
									this.Indicador,
									this.Sentido,
									this.Costo,
									this.B});
			this.dataIngreso.Location = new System.Drawing.Point(286, 49);
			this.dataIngreso.Name = "dataIngreso";
			this.dataIngreso.RowHeadersVisible = false;
			this.dataIngreso.Size = new System.Drawing.Size(319, 386);
			this.dataIngreso.TabIndex = 1;
			this.dataIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataIngresoCellContentClick);
			// 
			// ID_R
			// 
			this.ID_R.DataPropertyName = "ID_R";
			this.ID_R.HeaderText = "ID";
			this.ID_R.Name = "ID_R";
			this.ID_R.ReadOnly = true;
			this.ID_R.Visible = false;
			this.ID_R.Width = 40;
			// 
			// Indicador
			// 
			this.Indicador.DataPropertyName = "Indicador";
			this.Indicador.HeaderText = "ID Nomina";
			this.Indicador.Name = "Indicador";
			this.Indicador.ReadOnly = true;
			this.Indicador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Indicador.Width = 50;
			// 
			// Sentido
			// 
			this.Sentido.DataPropertyName = "Sentido";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Sentido.DefaultCellStyle = dataGridViewCellStyle2;
			this.Sentido.HeaderText = "Detalle";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			this.Sentido.Width = 150;
			// 
			// Costo
			// 
			this.Costo.DataPropertyName = "Costo";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Costo.DefaultCellStyle = dataGridViewCellStyle3;
			this.Costo.HeaderText = "$";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			this.Costo.Width = 60;
			// 
			// B
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
			this.B.DefaultCellStyle = dataGridViewCellStyle4;
			this.B.HeaderText = "B";
			this.B.Name = "B";
			this.B.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.B.Text = "X";
			this.B.ToolTipText = "Eliminar Ingreso";
			this.B.Width = 20;
			// 
			// pOperador
			// 
			this.pOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pOperador.BackColor = System.Drawing.Color.MidnightBlue;
			this.pOperador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pOperador.BackgroundImage")));
			this.pOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperador.Controls.Add(this.groupBox3);
			this.pOperador.Controls.Add(this.groupBox1);
			this.pOperador.Controls.Add(this.groupBox2);
			this.pOperador.Location = new System.Drawing.Point(12, 12);
			this.pOperador.Name = "pOperador";
			this.pOperador.Size = new System.Drawing.Size(268, 423);
			this.pOperador.TabIndex = 144;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox3.Controls.Add(this.txtFiniquito);
			this.groupBox3.Controls.Add(this.ckFiniquito);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(14, 205);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(235, 56);
			this.groupBox3.TabIndex = 186;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ingresos Predeterminados";
			// 
			// txtFiniquito
			// 
			this.txtFiniquito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFiniquito.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFiniquito.Location = new System.Drawing.Point(109, 21);
			this.txtFiniquito.Name = "txtFiniquito";
			this.txtFiniquito.Size = new System.Drawing.Size(93, 20);
			this.txtFiniquito.TabIndex = 184;
			this.txtFiniquito.Text = "140.37";
			this.txtFiniquito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFiniquito.TextChanged += new System.EventHandler(this.TxtFiniquitoTextChanged);
			this.txtFiniquito.Enter += new System.EventHandler(this.TxtFiniquitoEnter);
			// 
			// ckFiniquito
			// 
			this.ckFiniquito.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckFiniquito.Location = new System.Drawing.Point(15, 19);
			this.ckFiniquito.Name = "ckFiniquito";
			this.ckFiniquito.Size = new System.Drawing.Size(104, 24);
			this.ckFiniquito.TabIndex = 0;
			this.ckFiniquito.Text = "Finiquito";
			this.ckFiniquito.UseVisualStyleBackColor = true;
			this.ckFiniquito.CheckedChanged += new System.EventHandler(this.CkFiniquitoCheckedChanged);
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
			this.groupBox1.Location = new System.Drawing.Point(14, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 189);
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
			this.ptbImagen.Location = new System.Drawing.Point(58, 19);
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
			this.txtAlias.Location = new System.Drawing.Point(86, 154);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(91, 22);
			this.txtAlias.TabIndex = 164;
			this.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(58, 152);
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
			this.groupBox2.Controls.Add(this.btnExtras);
			this.groupBox2.Controls.Add(this.label35);
			this.groupBox2.Controls.Add(this.label36);
			this.groupBox2.Controls.Add(this.txtDetalleIng);
			this.groupBox2.Controls.Add(this.txtImporteIng);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(14, 267);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(235, 142);
			this.groupBox2.TabIndex = 173;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ingreso";
			// 
			// btnExtras
			// 
			this.btnExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExtras.BackColor = System.Drawing.Color.Transparent;
			this.btnExtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExtras.BackgroundImage")));
			this.btnExtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExtras.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExtras.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExtras.Location = new System.Drawing.Point(176, 73);
			this.btnExtras.Name = "btnExtras";
			this.btnExtras.Size = new System.Drawing.Size(26, 22);
			this.btnExtras.TabIndex = 187;
			this.btnExtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExtras.UseVisualStyleBackColor = false;
			this.btnExtras.Click += new System.EventHandler(this.BtnExtrasClick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(286, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(319, 26);
			this.label1.TabIndex = 145;
			this.label1.Text = "Ingresos de la quincena";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtImporteIng
			// 
			this.txtImporteIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtImporteIng.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporteIng.Location = new System.Drawing.Point(110, 47);
			this.txtImporteIng.Name = "txtImporteIng";
			this.txtImporteIng.Size = new System.Drawing.Size(92, 20);
			this.txtImporteIng.TabIndex = 183;
			this.txtImporteIng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtImporteIng.TextChanged += new System.EventHandler(this.TxtImporteIngTextChanged);
			// 
			// txtDetalleIng
			// 
			this.txtDetalleIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDetalleIng.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDetalleIng.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDetalleIng.Location = new System.Drawing.Point(109, 18);
			this.txtDetalleIng.Name = "txtDetalleIng";
			this.txtDetalleIng.Size = new System.Drawing.Size(93, 20);
			this.txtDetalleIng.TabIndex = 181;
			this.txtDetalleIng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label36
			// 
			this.label36.BackColor = System.Drawing.Color.White;
			this.label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(15, 17);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(67, 22);
			this.label36.TabIndex = 182;
			this.label36.Text = "Detalle";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.White;
			this.label35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(16, 47);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(59, 17);
			this.label35.TabIndex = 184;
			this.label35.Text = "Importe";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormIngresoExtra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(617, 447);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pOperador);
			this.Controls.Add(this.dataIngreso);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormIngresoExtra";
			this.Text = "Transportes LAR - Ingresos Extras";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngresoExtraFormClosing);
			this.Load += new System.EventHandler(this.FormIngresoExtraLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataIngreso)).EndInit();
			this.pOperador.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dataIngreso;
		private System.Windows.Forms.DataGridViewButtonColumn B;
		private System.Windows.Forms.Button btnExtras;
		private System.Windows.Forms.CheckBox ckFiniquito;
		private System.Windows.Forms.TextBox txtFiniquito;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtImporteIng;
		private System.Windows.Forms.TextBox txtDetalleIng;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.Panel pOperador;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_R;
	}
}
