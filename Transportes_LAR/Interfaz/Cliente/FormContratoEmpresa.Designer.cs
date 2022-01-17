namespace Transportes_LAR.Interfaz.Cliente
{
	partial class FormContratoEmpresa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContratoEmpresa));
			this.dtEmpresa = new System.Windows.Forms.DataGridView();
			this.Alias_Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblEmpresa = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtEmpresa)).BeginInit();
			this.SuspendLayout();
			// 
			// dtEmpresa
			// 
			this.dtEmpresa.AllowUserToAddRows = false;
			this.dtEmpresa.AllowUserToResizeColumns = false;
			this.dtEmpresa.AllowUserToResizeRows = false;
			this.dtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.dtEmpresa.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Alias_Op});
			this.dtEmpresa.Location = new System.Drawing.Point(10, 48);
			this.dtEmpresa.MultiSelect = false;
			this.dtEmpresa.Name = "dtEmpresa";
			this.dtEmpresa.RowHeadersVisible = false;
			this.dtEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtEmpresa.Size = new System.Drawing.Size(249, 496);
			this.dtEmpresa.TabIndex = 141;
			this.dtEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtEmpresaCellDoubleClick);
			// 
			// Alias_Op
			// 
			this.Alias_Op.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Alias_Op.DataPropertyName = "NombreEmpresa";
			this.Alias_Op.HeaderText = "Empresa";
			this.Alias_Op.MinimumWidth = 130;
			this.Alias_Op.Name = "Alias_Op";
			this.Alias_Op.ReadOnly = true;
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblEmpresa.BackColor = System.Drawing.Color.White;
			this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEmpresa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpresa.Location = new System.Drawing.Point(-3, -5);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(276, 38);
			this.lblEmpresa.TabIndex = 142;
			this.lblEmpresa.Text = "Contrato Empresarial";
			this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormContratoEmpresa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(271, 556);
			this.Controls.Add(this.lblEmpresa);
			this.Controls.Add(this.dtEmpresa);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormContratoEmpresa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Contrato Empresa";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormValidaFacturaFormClosing);
			this.Load += new System.EventHandler(this.FormValidaFacturaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtEmpresa)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias_Op;
		private System.Windows.Forms.DataGridView dtEmpresa;
	}
}
