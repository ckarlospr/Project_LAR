/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 12/02/2013
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormMsjGral
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMsjGral));
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// txtMensaje
			// 
			this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMensaje.Location = new System.Drawing.Point(12, 12);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(529, 124);
			this.txtMensaje.TabIndex = 0;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.BackgroundImage")));
			this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdGuardar.Location = new System.Drawing.Point(550, 12);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(44, 39);
			this.cmdGuardar.TabIndex = 1;
			this.toolTip1.SetToolTip(this.cmdGuardar, "Guardar");
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.BackgroundImage")));
			this.cmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdCancelar.Location = new System.Drawing.Point(550, 95);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(44, 41);
			this.cmdCancelar.TabIndex = 2;
			this.toolTip1.SetToolTip(this.cmdCancelar, "Cancelar");
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
			// 
			// FormMsjGral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(603, 148);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.txtMensaje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMsjGral";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMsjGral";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.TextBox txtMensaje;
	}
}
