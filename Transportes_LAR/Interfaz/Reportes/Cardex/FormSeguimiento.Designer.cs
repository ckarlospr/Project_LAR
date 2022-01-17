/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 01/11/2014
 * Hora: 11:50 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes.Cardex
{
	partial class FormSeguimiento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguimiento));
			this.label1 = new System.Windows.Forms.Label();
			this.txtmedida = new System.Windows.Forms.TextBox();
			this.btnSeguimiento = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Medida tomada para solucionar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtmedida
			// 
			this.txtmedida.Location = new System.Drawing.Point(12, 20);
			this.txtmedida.Multiline = true;
			this.txtmedida.Name = "txtmedida";
			this.txtmedida.Size = new System.Drawing.Size(271, 67);
			this.txtmedida.TabIndex = 1;
			// 
			// btnSeguimiento
			// 
			this.btnSeguimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguimiento.Image")));
			this.btnSeguimiento.Location = new System.Drawing.Point(257, 90);
			this.btnSeguimiento.Name = "btnSeguimiento";
			this.btnSeguimiento.Size = new System.Drawing.Size(27, 23);
			this.btnSeguimiento.TabIndex = 2;
			this.btnSeguimiento.UseVisualStyleBackColor = true;
			this.btnSeguimiento.Click += new System.EventHandler(this.BtnSeguimientoClick);
			// 
			// FormSeguimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(292, 119);
			this.Controls.Add(this.btnSeguimiento);
			this.Controls.Add(this.txtmedida);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSeguimiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Seguimiento";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSeguimiento;
		private System.Windows.Forms.TextBox txtmedida;
		private System.Windows.Forms.Label label1;
	}
}
