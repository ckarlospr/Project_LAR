/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 01/03/2016
 * Hora: 9:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Notificaciones
{
	partial class FormNCumpleanos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNCumpleanos));
			this.label1 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(621, 393);
			this.label1.TabIndex = 0;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(530, 405);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(103, 34);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblUsuario.Font = new System.Drawing.Font("Hobo Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.Color.White;
			this.lblUsuario.Location = new System.Drawing.Point(111, 365);
			this.lblUsuario.Margin = new System.Windows.Forms.Padding(0);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(407, 74);
			this.lblUsuario.TabIndex = 2;
			this.lblUsuario.Text = "USUARIO";
			this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormNCumpleanos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(643, 448);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormNCumpleanos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Feliz Cumpleaños";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.White;
			this.Load += new System.EventHandler(this.FormNCumpleanosLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label1;
	}
}
