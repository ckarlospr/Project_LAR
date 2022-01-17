/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 08/02/2013
 * Time: 9:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormGloboMsj
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGloboMsj));
			this.lblMensaje = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblMensaje
			// 
			this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
			this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensaje.Location = new System.Drawing.Point(22, 9);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(428, 155);
			this.lblMensaje.TabIndex = 0;
			this.lblMensaje.Text = "label1";
			this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMensaje.MouseEnter += new System.EventHandler(this.Label1MouseEnter);
			// 
			// FormGloboMsj
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(474, 173);
			this.Controls.Add(this.lblMensaje);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormGloboMsj";
			this.Text = "FormGloboMsj";
			this.MouseEnter += new System.EventHandler(this.FormGloboMsjMouseEnter);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblMensaje;
	}
}
