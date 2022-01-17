/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 10/09/2013
 * Time: 12:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormPuesto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPuesto));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pOperador = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.cmbPuesto = new System.Windows.Forms.ComboBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dtOperador = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias_Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pOperador.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtOperador)).BeginInit();
			this.SuspendLayout();
			// 
			// pOperador
			// 
			this.pOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pOperador.BackColor = System.Drawing.SystemColors.Menu;
			this.pOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperador.Controls.Add(this.groupBox1);
			this.pOperador.Controls.Add(this.cmbPuesto);
			this.pOperador.Controls.Add(this.btnActualizar);
			this.pOperador.Controls.Add(this.label1);
			this.pOperador.Controls.Add(this.dtOperador);
			this.pOperador.Location = new System.Drawing.Point(1, 0);
			this.pOperador.Name = "pOperador";
			this.pOperador.Size = new System.Drawing.Size(445, 548);
			this.pOperador.TabIndex = 144;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.ptbImagen);
			this.groupBox1.Controls.Add(this.txtAlias);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(186, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 189);
			this.groupBox1.TabIndex = 186;
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
			// pictureBox3
			// 
			this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(58, 152);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(22, 24);
			this.pictureBox3.TabIndex = 147;
			this.pictureBox3.TabStop = false;
			// 
			// cmbPuesto
			// 
			this.cmbPuesto.FormattingEnabled = true;
			this.cmbPuesto.Items.AddRange(new object[] {
									"ADMINISTRATIVO",
									"AUXILIAR ADMINISTRATIVO",
									"AUXILIAR CONTABLE",
									"ARRIAGA",
									"COMBUSTIBLE",
									"CONTABILIDAD",
									"COORDINADOR",
									"DOCTOR",
									"OPERADOR",
									"VENTAS",
									"MECANICO",
									"SISTEMAS",
									"CAPTURISTA",
									"ENCARGADO COMBUSTIBLE"});
			this.cmbPuesto.Location = new System.Drawing.Point(185, 229);
			this.cmbPuesto.Name = "cmbPuesto";
			this.cmbPuesto.Size = new System.Drawing.Size(236, 21);
			this.cmbPuesto.TabIndex = 169;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
			this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
			this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActualizar.Location = new System.Drawing.Point(279, 254);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(47, 45);
			this.btnActualizar.TabIndex = 168;
			this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(185, 201);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 25);
			this.label1.TabIndex = 167;
			this.label1.Text = "Puesto:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtOperador
			// 
			this.dtOperador.AllowUserToAddRows = false;
			this.dtOperador.AllowUserToResizeColumns = false;
			this.dtOperador.AllowUserToResizeRows = false;
			this.dtOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtOperador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dtOperador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dtOperador.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dtOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtOperador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Alias_Op,
									this.tipo_empleado});
			this.dtOperador.Location = new System.Drawing.Point(9, 9);
			this.dtOperador.MultiSelect = false;
			this.dtOperador.Name = "dtOperador";
			this.dtOperador.RowHeadersVisible = false;
			this.dtOperador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtOperador.Size = new System.Drawing.Size(156, 523);
			this.dtOperador.TabIndex = 140;
			this.dtOperador.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtOperadorCellEnter);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.ID.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			this.ID.Width = 80;
			// 
			// Alias_Op
			// 
			this.Alias_Op.DataPropertyName = "Alias_Op";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alias_Op.DefaultCellStyle = dataGridViewCellStyle3;
			this.Alias_Op.HeaderText = "Nick";
			this.Alias_Op.MinimumWidth = 100;
			this.Alias_Op.Name = "Alias_Op";
			this.Alias_Op.ReadOnly = true;
			// 
			// tipo_empleado
			// 
			this.tipo_empleado.DataPropertyName = "foraneo";
			this.tipo_empleado.HeaderText = "Foraneo";
			this.tipo_empleado.Name = "tipo_empleado";
			this.tipo_empleado.Visible = false;
			// 
			// FormPuesto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(447, 550);
			this.Controls.Add(this.pOperador);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPuesto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Puesto de los empleados";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPuestoFormClosing);
			this.Load += new System.EventHandler(this.FormPuestoLoad);
			this.pOperador.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtOperador)).EndInit();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.ComboBox cmbPuesto;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_empleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias_Op;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dtOperador;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pOperador;
	}
}
