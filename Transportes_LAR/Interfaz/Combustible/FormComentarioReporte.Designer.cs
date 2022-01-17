/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 19/11/2015
 * Time: 12:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormComentarioReporte
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComentarioReporte));
			this.bnSalirProgramcion = new System.Windows.Forms.Button();
			this.txtGuardar = new System.Windows.Forms.Button();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bnSalirProgramcion
			// 
			this.bnSalirProgramcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnSalirProgramcion.Image = ((System.Drawing.Image)(resources.GetObject("bnSalirProgramcion.Image")));
			this.bnSalirProgramcion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bnSalirProgramcion.Location = new System.Drawing.Point(29, 131);
			this.bnSalirProgramcion.Name = "bnSalirProgramcion";
			this.bnSalirProgramcion.Size = new System.Drawing.Size(82, 44);
			this.bnSalirProgramcion.TabIndex = 124;
			this.bnSalirProgramcion.Text = "Salir";
			this.bnSalirProgramcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bnSalirProgramcion.UseVisualStyleBackColor = true;
			this.bnSalirProgramcion.Click += new System.EventHandler(this.BnSalirProgramcionClick);
			// 
			// txtGuardar
			// 
			this.txtGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("txtGuardar.Image")));
			this.txtGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.txtGuardar.Location = new System.Drawing.Point(165, 131);
			this.txtGuardar.Name = "txtGuardar";
			this.txtGuardar.Size = new System.Drawing.Size(82, 44);
			this.txtGuardar.TabIndex = 123;
			this.txtGuardar.Text = "Grabar";
			this.txtGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtGuardar.UseVisualStyleBackColor = true;
			this.txtGuardar.Click += new System.EventHandler(this.TxtGuardarClick);
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(15, 36);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtComentario.Size = new System.Drawing.Size(252, 80);
			this.txtComentario.TabIndex = 121;
			this.txtComentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(-3, 9);
			this.label40.Name = "label40";
			this.label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label40.Size = new System.Drawing.Size(47, 15);
			this.label40.TabIndex = 126;
			this.label40.Text = "Folio:";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFolio
			// 
			this.txtFolio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtFolio.Enabled = false;
			this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(44, 6);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(141, 24);
			this.txtFolio.TabIndex = 125;
			// 
			// FormComentarioReporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 187);
			this.Controls.Add(this.label40);
			this.Controls.Add(this.txtFolio);
			this.Controls.Add(this.bnSalirProgramcion);
			this.Controls.Add(this.txtGuardar);
			this.Controls.Add(this.txtComentario);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(289, 226);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(289, 226);
			this.Name = "FormComentarioReporte";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Comentario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormComentarioReporteFormClosing);
			this.Load += new System.EventHandler(this.FormComentarioReporteLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Button txtGuardar;
		private System.Windows.Forms.Button bnSalirProgramcion;
	}
}
