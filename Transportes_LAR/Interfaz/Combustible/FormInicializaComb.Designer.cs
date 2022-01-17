/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 07/07/2014
 * Time: 07:06 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormInicializaComb
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
			this.cmdGenera = new System.Windows.Forms.Button();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdGenera
			// 
			this.cmdGenera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGenera.Location = new System.Drawing.Point(161, 10);
			this.cmdGenera.Name = "cmdGenera";
			this.cmdGenera.Size = new System.Drawing.Size(75, 23);
			this.cmdGenera.TabIndex = 1;
			this.cmdGenera.Text = "Inicia";
			this.cmdGenera.UseVisualStyleBackColor = true;
			this.cmdGenera.Click += new System.EventHandler(this.CmdGeneraClick);
			// 
			// txtFolio
			// 
			this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(12, 12);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(143, 20);
			this.txtFolio.TabIndex = 0;
			this.txtFolio.Text = "0";
			this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFolio.Click += new System.EventHandler(this.TxtFolioClick);
			this.txtFolio.Enter += new System.EventHandler(this.TxtFolioEnter);
			// 
			// FormInicializaComb
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(248, 41);
			this.Controls.Add(this.txtFolio);
			this.Controls.Add(this.cmdGenera);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(264, 79);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(264, 79);
			this.Name = "FormInicializaComb";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inicia combustible";
			this.Load += new System.EventHandler(this.FormInicializaCombLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Button cmdGenera;
	}
}
