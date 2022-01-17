/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 26/12/2012
 * Time: 11:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormPruebaRendimiento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPruebaRendimiento));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.txtMuestra = new System.Windows.Forms.TextBox();
			this.txtReconoce = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtgRutas = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.BackgroundImage")));
			this.cmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdAgregar.Location = new System.Drawing.Point(371, 116);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(34, 32);
			this.cmdAgregar.TabIndex = 2;
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// txtMuestra
			// 
			this.txtMuestra.Location = new System.Drawing.Point(230, 12);
			this.txtMuestra.Name = "txtMuestra";
			this.txtMuestra.Size = new System.Drawing.Size(175, 20);
			this.txtMuestra.TabIndex = 3;
			this.txtMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtMuestra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMuestraKeyUp);
			// 
			// txtReconoce
			// 
			this.txtReconoce.Location = new System.Drawing.Point(33, 12);
			this.txtReconoce.Name = "txtReconoce";
			this.txtReconoce.Size = new System.Drawing.Size(175, 20);
			this.txtReconoce.TabIndex = 4;
			this.txtReconoce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(230, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Operador";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Supervisor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dtgRutas
			// 
			this.dtgRutas.AllowUserToAddRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgRutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2});
			this.dtgRutas.Location = new System.Drawing.Point(3, 4);
			this.dtgRutas.Name = "dtgRutas";
			this.dtgRutas.RowHeadersVisible = false;
			this.dtgRutas.Size = new System.Drawing.Size(240, 70);
			this.dtgRutas.TabIndex = 7;
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
			this.Column2.HeaderText = "Ruta";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 220;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.dtgRutas);
			this.panel1.Location = new System.Drawing.Point(104, 71);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(246, 77);
			this.panel1.TabIndex = 8;
			// 
			// FormPruebaRendimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 170);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtReconoce);
			this.Controls.Add(this.txtMuestra);
			this.Controls.Add(this.cmdAgregar);
			this.MaximizeBox = false;
			this.Name = "FormPruebaRendimiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prueba de rendimiento";
			this.Load += new System.EventHandler(this.FormPruebaRendimientoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dtgRutas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtReconoce;
		private System.Windows.Forms.TextBox txtMuestra;
		private System.Windows.Forms.Button cmdAgregar;
	}
}