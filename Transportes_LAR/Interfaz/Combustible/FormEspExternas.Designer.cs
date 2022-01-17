/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 17/01/2015
 * Hora: 12:58 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormEspExternas
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
			this.btnEntre = new System.Windows.Forms.Button();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEntre
			// 
			this.btnEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntre.Location = new System.Drawing.Point(73, 12);
			this.btnEntre.Name = "btnEntre";
			this.btnEntre.Size = new System.Drawing.Size(104, 29);
			this.btnEntre.TabIndex = 0;
			this.btnEntre.Text = "Generar";
			this.btnEntre.UseVisualStyleBackColor = true;
			this.btnEntre.Click += new System.EventHandler(this.BtnEntreClick);
			// 
			// nudCantidad
			// 
			this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudCantidad.Location = new System.Drawing.Point(12, 12);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(55, 29);
			this.nudCantidad.TabIndex = 2;
			// 
			// FormEspExternas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(187, 49);
			this.Controls.Add(this.nudCantidad);
			this.Controls.Add(this.btnEntre);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormEspExternas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Folios externos";
			this.Load += new System.EventHandler(this.FormEspExternasLoad);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.Button btnEntre;
	}
}
