/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 14/02/2015
 * Hora: 11:57 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Lector
{
	partial class FormCapture_Stream
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
			this.pbFingerprint = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
			this.SuspendLayout();
			// 
			// pbFingerprint
			// 
			this.pbFingerprint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pbFingerprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbFingerprint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbFingerprint.Location = new System.Drawing.Point(12, 12);
			this.pbFingerprint.Name = "pbFingerprint";
			this.pbFingerprint.Size = new System.Drawing.Size(225, 238);
			this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbFingerprint.TabIndex = 0;
			this.pbFingerprint.TabStop = false;
			// 
			// FormCapture_Stream
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 262);
			this.Controls.Add(this.pbFingerprint);
			this.Name = "FormCapture_Stream";
			this.Text = "FormCapture_Stream";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCapture_StreamFormClosed);
			this.Load += new System.EventHandler(this.FormCapture_StreamLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pbFingerprint;
	}
}
