/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 07/09/2015
 * Time: 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormNoRealizoRevizado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoRealizoRevizado));
			this.txtComentarios = new System.Windows.Forms.TextBox();
			this.lblComentarios = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtComentarios
			// 
			this.txtComentarios.Location = new System.Drawing.Point(12, 35);
			this.txtComentarios.Multiline = true;
			this.txtComentarios.Name = "txtComentarios";
			this.txtComentarios.Size = new System.Drawing.Size(260, 96);
			this.txtComentarios.TabIndex = 0;
			// 
			// lblComentarios
			// 
			this.lblComentarios.Location = new System.Drawing.Point(12, 9);
			this.lblComentarios.Name = "lblComentarios";
			this.lblComentarios.Size = new System.Drawing.Size(100, 23);
			this.lblComentarios.TabIndex = 1;
			this.lblComentarios.Text = "Comentarios:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(12, 149);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(100, 32);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(172, 149);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(100, 32);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(182, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Comentarios:";
			// 
			// FormNoRealizoRevizado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 190);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.lblComentarios);
			this.Controls.Add(this.txtComentarios);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(300, 228);
			this.MinimumSize = new System.Drawing.Size(300, 228);
			this.Name = "FormNoRealizoRevizado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Revizado";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNoRealizoRevizadoFormClosing);
			this.Load += new System.EventHandler(this.FormNoRealizoRevizadoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblComentarios;
		private System.Windows.Forms.TextBox txtComentarios;
	}
}
