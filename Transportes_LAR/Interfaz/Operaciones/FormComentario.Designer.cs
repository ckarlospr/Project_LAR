/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 29/07/2014
 * Hora: 12:32 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormComentario
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
			this.cmdGuarda = new System.Windows.Forms.Button();
			this.txtComent = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdGuarda
			// 
			this.cmdGuarda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuarda.Location = new System.Drawing.Point(213, 86);
			this.cmdGuarda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cmdGuarda.Name = "cmdGuarda";
			this.cmdGuarda.Size = new System.Drawing.Size(103, 27);
			this.cmdGuarda.TabIndex = 0;
			this.cmdGuarda.Text = "Guardar";
			this.cmdGuarda.UseVisualStyleBackColor = true;
			this.cmdGuarda.Click += new System.EventHandler(this.CmdGuardaClick);
			// 
			// txtComent
			// 
			this.txtComent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComent.Location = new System.Drawing.Point(16, 14);
			this.txtComent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtComent.Multiline = true;
			this.txtComent.Name = "txtComent";
			this.txtComent.Size = new System.Drawing.Size(300, 66);
			this.txtComent.TabIndex = 1;
			// 
			// FormComentario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 127);
			this.Controls.Add(this.txtComent);
			this.Controls.Add(this.cmdGuarda);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormComentario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Comentario";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtComent;
		private System.Windows.Forms.Button cmdGuarda;
	}
}
