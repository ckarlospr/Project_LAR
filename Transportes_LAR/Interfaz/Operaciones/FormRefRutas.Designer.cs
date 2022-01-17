/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 25/09/2012
 * Time: 09:33 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormRefRutas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRefRutas));
			this.lblAlias = new System.Windows.Forms.Label();
			this.datRefRutas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.datRefRutas)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAlias
			// 
			this.lblAlias.BackColor = System.Drawing.Color.White;
			this.lblAlias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlias.Location = new System.Drawing.Point(23, 19);
			this.lblAlias.Name = "lblAlias";
			this.lblAlias.Size = new System.Drawing.Size(135, 22);
			this.lblAlias.TabIndex = 0;
			// 
			// datRefRutas
			// 
			this.datRefRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datRefRutas.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.datRefRutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.datRefRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datRefRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Ruta});
			this.datRefRutas.Location = new System.Drawing.Point(23, 59);
			this.datRefRutas.Name = "datRefRutas";
			this.datRefRutas.Size = new System.Drawing.Size(397, 158);
			this.datRefRutas.TabIndex = 1;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// Ruta
			// 
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			// 
			// FormRefRutas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(446, 238);
			this.Controls.Add(this.datRefRutas);
			this.Controls.Add(this.lblAlias);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(462, 276);
			this.MinimumSize = new System.Drawing.Size(462, 276);
			this.Name = "FormRefRutas";
			this.Text = "Transportes LAR - Referencias de las Rutas";
			((System.ComponentModel.ISupportInitialize)(this.datRefRutas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView datRefRutas;
		private System.Windows.Forms.Label lblAlias;
	}
}
