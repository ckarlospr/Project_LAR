/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 09/07/2012
 * Time: 13:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz
{
	partial class FormMensaje
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensaje));
			this.txtMensaje = new System.Windows.Forms.Label();
			this.timerMensaje = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// txtMensaje
			// 
			this.txtMensaje.BackColor = System.Drawing.Color.Transparent;
			this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensaje.Location = new System.Drawing.Point(12, 9);
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(406, 143);
			this.txtMensaje.TabIndex = 0;
			this.txtMensaje.Text = "Mensaje";
			this.txtMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timerMensaje
			// 
			this.timerMensaje.Interval = 200;
			this.timerMensaje.Tick += new System.EventHandler(this.TimerMensajeTick);
			// 
			// FormMensaje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(430, 161);
			this.Controls.Add(this.txtMensaje);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMensaje";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMensaje";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer timerMensaje;
		private System.Windows.Forms.Label txtMensaje;
	}
}
