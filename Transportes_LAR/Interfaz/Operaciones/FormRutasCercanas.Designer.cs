/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 05/10/2012
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormRutasCercanas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRutasCercanas));
			this.lblNombreOp = new System.Windows.Forms.Label();
			this.dtgRutas = new System.Windows.Forms.DataGridView();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNombreOp
			// 
			this.lblNombreOp.BackColor = System.Drawing.Color.White;
			this.lblNombreOp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreOp.Image = ((System.Drawing.Image)(resources.GetObject("lblNombreOp.Image")));
			this.lblNombreOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNombreOp.Location = new System.Drawing.Point(0, 0);
			this.lblNombreOp.Name = "lblNombreOp";
			this.lblNombreOp.Size = new System.Drawing.Size(367, 42);
			this.lblNombreOp.TabIndex = 1;
			this.lblNombreOp.Text = "Operador";
			this.lblNombreOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtgRutas
			// 
			this.dtgRutas.AllowUserToAddRows = false;
			this.dtgRutas.AllowUserToResizeRows = false;
			this.dtgRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtgRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgRutas.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dtgRutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Empresa,
									this.Ruta});
			this.dtgRutas.Location = new System.Drawing.Point(12, 49);
			this.dtgRutas.Name = "dtgRutas";
			this.dtgRutas.RowHeadersVisible = false;
			this.dtgRutas.Size = new System.Drawing.Size(338, 219);
			this.dtgRutas.TabIndex = 0;
			// 
			// Empresa
			// 
			this.Empresa.HeaderText = "Empresa";
			this.Empresa.Name = "Empresa";
			this.Empresa.ReadOnly = true;
			// 
			// Ruta
			// 
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(367, 46);
			this.label1.TabIndex = 3;
			// 
			// FormRutasCercanas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(362, 280);
			this.Controls.Add(this.dtgRutas);
			this.Controls.Add(this.lblNombreOp);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRutasCercanas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Rutas Cercanas";
			this.Load += new System.EventHandler(this.FormRutasCercanasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtgRutas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridView dtgRutas;
		public System.Windows.Forms.Label lblNombreOp;
	}
}
