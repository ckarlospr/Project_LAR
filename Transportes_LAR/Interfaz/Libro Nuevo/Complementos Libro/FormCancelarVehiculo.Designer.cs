/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 31/12/2015
 * Hora: 12:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormCancelarVehiculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelarVehiculo));
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.lblDestino = new System.Windows.Forms.Label();
			this.lblMotivo = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtmotivo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(55, 12);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(217, 20);
			this.txtDestino.TabIndex = 120;
			// 
			// lblDestino
			// 
			this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDestino.Location = new System.Drawing.Point(7, 13);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDestino.Size = new System.Drawing.Size(47, 15);
			this.lblDestino.TabIndex = 121;
			this.lblDestino.Text = "Destino:";
			this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblMotivo
			// 
			this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMotivo.Location = new System.Drawing.Point(5, 38);
			this.lblMotivo.Name = "lblMotivo";
			this.lblMotivo.Size = new System.Drawing.Size(49, 23);
			this.lblMotivo.TabIndex = 123;
			this.lblMotivo.Text = "Motivo:";
			this.lblMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.Location = new System.Drawing.Point(108, 125);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(77, 34);
			this.btnAceptar.TabIndex = 124;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtmotivo
			// 
			this.txtmotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtmotivo.Location = new System.Drawing.Point(55, 40);
			this.txtmotivo.Multiline = true;
			this.txtmotivo.Name = "txtmotivo";
			this.txtmotivo.Size = new System.Drawing.Size(217, 79);
			this.txtmotivo.TabIndex = 125;
			// 
			// FormCancelarVehiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 161);
			this.Controls.Add(this.txtmotivo);
			this.Controls.Add(this.lblMotivo);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.lblDestino);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(293, 200);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(293, 200);
			this.Name = "FormCancelarVehiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancelación de Vehiculo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtmotivo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblMotivo;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.TextBox txtDestino;
	}
}
