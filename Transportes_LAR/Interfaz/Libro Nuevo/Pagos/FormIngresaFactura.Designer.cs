/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 11/12/2015
 * Hora: 14:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormIngresaFactura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresaFactura));
			this.label1 = new System.Windows.Forms.Label();
			this.txtDato = new System.Windows.Forms.TextBox();
			this.cmdGuardr = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Dato de factura:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDato
			// 
			this.txtDato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDato.Location = new System.Drawing.Point(118, 16);
			this.txtDato.Name = "txtDato";
			this.txtDato.Size = new System.Drawing.Size(108, 26);
			this.txtDato.TabIndex = 1;
			this.txtDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdGuardr
			// 
			this.cmdGuardr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardr.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardr.Image")));
			this.cmdGuardr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardr.Location = new System.Drawing.Point(232, 9);
			this.cmdGuardr.Name = "cmdGuardr";
			this.cmdGuardr.Size = new System.Drawing.Size(109, 38);
			this.cmdGuardr.TabIndex = 6;
			this.cmdGuardr.Text = "Guardar";
			this.cmdGuardr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardr.UseVisualStyleBackColor = true;
			this.cmdGuardr.Click += new System.EventHandler(this.CmdGuardrClick);
			// 
			// FormIngresaFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 58);
			this.Controls.Add(this.txtDato);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdGuardr);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(369, 97);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(369, 97);
			this.Name = "FormIngresaFactura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingresa Factura";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngresaFacturaFormClosing);
			this.Load += new System.EventHandler(this.FormIngresaFacturaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdGuardr;
		private System.Windows.Forms.TextBox txtDato;
		private System.Windows.Forms.Label label1;
	}
}
