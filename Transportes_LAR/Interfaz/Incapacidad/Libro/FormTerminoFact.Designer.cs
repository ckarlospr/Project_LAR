/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 04/07/2013
 * Time: 03:00 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormTerminoFact
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
			this.cmdGuardr = new System.Windows.Forms.Button();
			this.txtDato = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdGuardr
			// 
			this.cmdGuardr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardr.Location = new System.Drawing.Point(243, 12);
			this.cmdGuardr.Name = "cmdGuardr";
			this.cmdGuardr.Size = new System.Drawing.Size(112, 40);
			this.cmdGuardr.TabIndex = 0;
			this.cmdGuardr.Text = "Guardar";
			this.cmdGuardr.UseVisualStyleBackColor = true;
			this.cmdGuardr.Click += new System.EventHandler(this.CmdGuardrClick);
			// 
			// txtDato
			// 
			this.txtDato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDato.Location = new System.Drawing.Point(12, 18);
			this.txtDato.Name = "txtDato";
			this.txtDato.Size = new System.Drawing.Size(203, 26);
			this.txtDato.TabIndex = 1;
			// 
			// FormTerminoFact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 66);
			this.Controls.Add(this.txtDato);
			this.Controls.Add(this.cmdGuardr);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormTerminoFact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos";
			this.Load += new System.EventHandler(this.FormTerminoFactLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtDato;
		private System.Windows.Forms.Button cmdGuardr;
	}
}
