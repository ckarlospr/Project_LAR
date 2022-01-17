/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 13/07/2013
 * Time: 09:52 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormPrivilegioCobro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrivilegioCobro));
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.Image")));
			this.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAceptar.Location = new System.Drawing.Point(207, 9);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
			this.cmdAceptar.TabIndex = 1;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// txtClave
			// 
			this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtClave.Location = new System.Drawing.Point(12, 12);
			this.txtClave.Name = "txtClave";
			this.txtClave.PasswordChar = '*';
			this.txtClave.Size = new System.Drawing.Size(160, 20);
			this.txtClave.TabIndex = 0;
			this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtClave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtClaveKeyUp);
			// 
			// FormPrivilegioCobro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 44);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.cmdAceptar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(310, 82);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(310, 82);
			this.Name = "FormPrivilegioCobro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso cobro";
			this.Load += new System.EventHandler(this.FormPrivilegioCobroLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Button cmdAceptar;
	}
}
