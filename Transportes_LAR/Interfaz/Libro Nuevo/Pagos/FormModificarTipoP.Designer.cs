/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 09/02/2016
 * Hora: 10:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormModificarTipoP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarTipoP));
			this.lblConfirma = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.cbTipo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblConfirma
			// 
			this.lblConfirma.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirma.Location = new System.Drawing.Point(-4, 12);
			this.lblConfirma.Name = "lblConfirma";
			this.lblConfirma.Size = new System.Drawing.Size(81, 23);
			this.lblConfirma.TabIndex = 65;
			this.lblConfirma.Text = "Tipo cobro:";
			this.lblConfirma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.Location = new System.Drawing.Point(241, 6);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(55, 35);
			this.btnAceptar.TabIndex = 64;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// cbTipo
			// 
			this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipo.FormattingEnabled = true;
			this.cbTipo.Items.AddRange(new object[] {
									"COORDINADOR",
									"FACTURA",
									"PAGADO",
									"OPERADOR",
									"DEPOSITO"});
			this.cbTipo.Location = new System.Drawing.Point(83, 14);
			this.cbTipo.Name = "cbTipo";
			this.cbTipo.Size = new System.Drawing.Size(143, 21);
			this.cbTipo.TabIndex = 66;
			// 
			// FormModificarTipoP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 51);
			this.Controls.Add(this.cbTipo);
			this.Controls.Add(this.lblConfirma);
			this.Controls.Add(this.btnAceptar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(320, 90);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(320, 90);
			this.Name = "FormModificarTipoP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar Tipo de Cobro";
			this.Load += new System.EventHandler(this.FormModificarTipoPLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblConfirma;
	}
}
