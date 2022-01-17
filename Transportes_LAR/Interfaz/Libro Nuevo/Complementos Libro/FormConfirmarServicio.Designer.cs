/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 14/11/2015
 * Time: 13:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormConfirmarServicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirmarServicio));
			this.lblConfirma = new System.Windows.Forms.Label();
			this.txtConfirma = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblConfirma
			// 
			this.lblConfirma.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirma.Location = new System.Drawing.Point(2, 16);
			this.lblConfirma.Name = "lblConfirma";
			this.lblConfirma.Size = new System.Drawing.Size(102, 23);
			this.lblConfirma.TabIndex = 62;
			this.lblConfirma.Text = "Confirmado por:";
			this.lblConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtConfirma
			// 
			this.txtConfirma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtConfirma.Location = new System.Drawing.Point(107, 17);
			this.txtConfirma.Name = "txtConfirma";
			this.txtConfirma.Size = new System.Drawing.Size(188, 20);
			this.txtConfirma.TabIndex = 63;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.Location = new System.Drawing.Point(311, 10);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(55, 35);
			this.btnAceptar.TabIndex = 61;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// FormConfirmarServicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 57);
			this.Controls.Add(this.lblConfirma);
			this.Controls.Add(this.txtConfirma);
			this.Controls.Add(this.btnAceptar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(401, 96);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(401, 96);
			this.Name = "FormConfirmarServicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Confirmar Servicio";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfirmarServicioFormClosing);
			this.Load += new System.EventHandler(this.FormConfirmarServicioLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtConfirma;
		private System.Windows.Forms.Label lblConfirma;
	}
}
