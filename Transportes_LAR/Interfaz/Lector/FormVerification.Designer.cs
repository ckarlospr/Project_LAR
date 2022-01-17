/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 16/02/2015
 * Hora: 10:30 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Lector
{
	partial class FormVerification
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
			this.txtVerify = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtVerify
			// 
			this.txtVerify.BackColor = System.Drawing.SystemColors.Menu;
			this.txtVerify.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtVerify.Location = new System.Drawing.Point(0, 0);
			this.txtVerify.Multiline = true;
			this.txtVerify.Name = "txtVerify";
			this.txtVerify.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtVerify.Size = new System.Drawing.Size(284, 262);
			this.txtVerify.TabIndex = 0;
			// 
			// FormVerification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.txtVerify);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "FormVerification";
			this.Text = "FormVerification";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVerificationFormClosed);
			this.Load += new System.EventHandler(this.FormVerificationLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.TextBox txtVerify;
	}
}
