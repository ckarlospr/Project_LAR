/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 04/12/2012
 * Time: 10:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormOrdenEmpresas
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenEmpresas));
			this.pOrdenEmp = new System.Windows.Forms.Panel();
			this.dgEmpOrd = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdAnt = new System.Windows.Forms.Button();
			this.cmdDesp = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.pOrdenEmp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEmpOrd)).BeginInit();
			this.SuspendLayout();
			// 
			// pOrdenEmp
			// 
			this.pOrdenEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOrdenEmp.Controls.Add(this.dgEmpOrd);
			this.pOrdenEmp.Location = new System.Drawing.Point(12, 12);
			this.pOrdenEmp.Name = "pOrdenEmp";
			this.pOrdenEmp.Size = new System.Drawing.Size(531, 723);
			this.pOrdenEmp.TabIndex = 0;
			// 
			// dgEmpOrd
			// 
			this.dgEmpOrd.AllowUserToAddRows = false;
			this.dgEmpOrd.AllowUserToResizeRows = false;
			this.dgEmpOrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgEmpOrd.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEmpOrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgEmpOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmpOrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4});
			this.dgEmpOrd.Location = new System.Drawing.Point(3, 3);
			this.dgEmpOrd.Name = "dgEmpOrd";
			this.dgEmpOrd.RowHeadersVisible = false;
			this.dgEmpOrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEmpOrd.Size = new System.Drawing.Size(525, 717);
			this.dgEmpOrd.TabIndex = 0;
			this.dgEmpOrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgEmpOrdCellClick);
			this.dgEmpOrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgEmpOrdKeyDown);
			this.dgEmpOrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgEmpOrdKeyPress);
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
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column2.HeaderText = "Empresa";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 95;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Orden";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Visible = false;
			// 
			// Column4
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column4.HeaderText = "Abreviación";
			this.Column4.Name = "Column4";
			// 
			// cmdAnt
			// 
			this.cmdAnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAnt.Location = new System.Drawing.Point(546, 12);
			this.cmdAnt.Name = "cmdAnt";
			this.cmdAnt.Size = new System.Drawing.Size(27, 23);
			this.cmdAnt.TabIndex = 0;
			this.cmdAnt.Text = "/\\";
			this.cmdAnt.UseVisualStyleBackColor = true;
			this.cmdAnt.Click += new System.EventHandler(this.CmdAntClick);
			// 
			// cmdDesp
			// 
			this.cmdDesp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdDesp.Location = new System.Drawing.Point(546, 41);
			this.cmdDesp.Name = "cmdDesp";
			this.cmdDesp.Size = new System.Drawing.Size(27, 23);
			this.cmdDesp.TabIndex = 1;
			this.cmdDesp.Text = "\\/";
			this.cmdDesp.UseVisualStyleBackColor = true;
			this.cmdDesp.Click += new System.EventHandler(this.CmdDespClick);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.BackgroundImage")));
			this.cmdGuardar.Location = new System.Drawing.Point(552, 712);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(24, 23);
			this.cmdGuardar.TabIndex = 3;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// FormOrdenEmpresas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 747);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.cmdDesp);
			this.Controls.Add(this.cmdAnt);
			this.Controls.Add(this.pOrdenEmp);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(358, 581);
			this.Name = "FormOrdenEmpresas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Orden de empresas";
			this.Load += new System.EventHandler(this.FormOrdenEmpresasLoad);
			this.pOrdenEmp.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgEmpOrd)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button cmdDesp;
		private System.Windows.Forms.Button cmdAnt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgEmpOrd;
		private System.Windows.Forms.Panel pOrdenEmp;
	}
}
