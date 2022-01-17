/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 08/03/2016
 * Hora: 11:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormSeguimientoP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguimientoP));
			this.label4 = new System.Windows.Forms.Label();
			this.cbSeguimiento = new System.Windows.Forms.ComboBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 117;
			this.label4.Text = "Seguimiento";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbSeguimiento
			// 
			this.cbSeguimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSeguimiento.FormattingEnabled = true;
			this.cbSeguimiento.Items.AddRange(new object[] {
									"RENDIMIENTO ÓPTIMO",
									"REPARACIÓN TALLER",
									"OTRA PRUEBA"});
			this.cbSeguimiento.Location = new System.Drawing.Point(69, 6);
			this.cbSeguimiento.Name = "cbSeguimiento";
			this.cbSeguimiento.Size = new System.Drawing.Size(140, 21);
			this.cbSeguimiento.TabIndex = 116;
			this.cbSeguimiento.SelectedIndexChanged += new System.EventHandler(this.CbSeguimientoSelectedIndexChanged);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(120, 38);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(73, 36);
			this.btnCancelar.TabIndex = 119;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Enabled = false;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAceptar.Location = new System.Drawing.Point(30, 38);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(73, 36);
			this.btnAceptar.TabIndex = 118;
			this.btnAceptar.Text = "Guardar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// FormSeguimientoP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 80);
			this.Controls.Add(this.cbSeguimiento);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(220, 80);
			this.MinimumSize = new System.Drawing.Size(220, 80);
			this.Name = "FormSeguimientoP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormSeguimientoP";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.ComboBox cbSeguimiento;
		private System.Windows.Forms.Label label4;
	}
}
