/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 11/07/2012
 * Time: 14:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Usuario
{
	partial class FormDetallePrivilegio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallePrivilegio));
			this.label6 = new System.Windows.Forms.Label();
			this.dataPrivilegio = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAceptar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataPrivilegio)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(20, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(180, 14);
			this.label6.TabIndex = 9;
			this.label6.Text = "Lista de privilegios del usuario:";
			// 
			// dataPrivilegio
			// 
			this.dataPrivilegio.AllowUserToAddRows = false;
			this.dataPrivilegio.AllowUserToDeleteRows = false;
			this.dataPrivilegio.AllowUserToResizeColumns = false;
			this.dataPrivilegio.AllowUserToResizeRows = false;
			this.dataPrivilegio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataPrivilegio.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataPrivilegio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPrivilegio.ColumnHeadersVisible = false;
			this.dataPrivilegio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2});
			this.dataPrivilegio.Location = new System.Drawing.Point(20, 34);
			this.dataPrivilegio.MultiSelect = false;
			this.dataPrivilegio.Name = "dataPrivilegio";
			this.dataPrivilegio.ReadOnly = true;
			this.dataPrivilegio.RowHeadersVisible = false;
			this.dataPrivilegio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataPrivilegio.Size = new System.Drawing.Size(293, 352);
			this.dataPrivilegio.TabIndex = 8;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 30;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Interfaz";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 243;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(230, 394);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(83, 29);
			this.btnAceptar.TabIndex = 21;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// FormDetallePrivilegio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(332, 429);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataPrivilegio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDetallePrivilegio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Privilegio de usuario";
			this.Load += new System.EventHandler(this.FormDetallePrivilegioLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataPrivilegio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataPrivilegio;
		private System.Windows.Forms.Label label6;
	}
}
