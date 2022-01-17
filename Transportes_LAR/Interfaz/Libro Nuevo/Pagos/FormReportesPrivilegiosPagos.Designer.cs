/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 09/01/2016
 * Hora: 13:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class ReportesPrivilegiosPagos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesPrivilegiosPagos));
			this.btnOperador = new System.Windows.Forms.Button();
			this.btnAdeudo = new System.Windows.Forms.Button();
			this.btnTabla = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOperador
			// 
			this.btnOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.btnOperador.Image = ((System.Drawing.Image)(resources.GetObject("btnOperador.Image")));
			this.btnOperador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOperador.Location = new System.Drawing.Point(126, 8);
			this.btnOperador.Name = "btnOperador";
			this.btnOperador.Padding = new System.Windows.Forms.Padding(3);
			this.btnOperador.Size = new System.Drawing.Size(110, 51);
			this.btnOperador.TabIndex = 155;
			this.btnOperador.Tag = "Reporte de las cotizaciones y servicios hechos por usuarios";
			this.btnOperador.Text = "Operador";
			this.btnOperador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnOperador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnOperador.UseVisualStyleBackColor = false;
			this.btnOperador.Click += new System.EventHandler(this.BtnOperadorClick);
			// 
			// btnAdeudo
			// 
			this.btnAdeudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdeudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.btnAdeudo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdeudo.Image")));
			this.btnAdeudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAdeudo.Location = new System.Drawing.Point(245, 8);
			this.btnAdeudo.Name = "btnAdeudo";
			this.btnAdeudo.Padding = new System.Windows.Forms.Padding(3);
			this.btnAdeudo.Size = new System.Drawing.Size(110, 51);
			this.btnAdeudo.TabIndex = 150;
			this.btnAdeudo.Tag = "Reporte para obtener informacion al dia de todas las cotizaciones y servicios";
			this.btnAdeudo.Text = "Adeudos";
			this.btnAdeudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdeudo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnAdeudo.UseVisualStyleBackColor = false;
			this.btnAdeudo.Click += new System.EventHandler(this.BtnAdeudoClick);
			// 
			// btnTabla
			// 
			this.btnTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
			this.btnTabla.Image = ((System.Drawing.Image)(resources.GetObject("btnTabla.Image")));
			this.btnTabla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTabla.Location = new System.Drawing.Point(6, 8);
			this.btnTabla.Name = "btnTabla";
			this.btnTabla.Padding = new System.Windows.Forms.Padding(3);
			this.btnTabla.Size = new System.Drawing.Size(110, 51);
			this.btnTabla.TabIndex = 156;
			this.btnTabla.Tag = "Imprimir datos de la tabla anterior";
			this.btnTabla.Text = "Imprimir Tabla";
			this.btnTabla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTabla.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnTabla.UseVisualStyleBackColor = false;
			this.btnTabla.Click += new System.EventHandler(this.BtnTablaClick);
			// 
			// ReportesPrivilegiosPagos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 66);
			this.Controls.Add(this.btnTabla);
			this.Controls.Add(this.btnOperador);
			this.Controls.Add(this.btnAdeudo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(380, 105);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(380, 105);
			this.Name = "ReportesPrivilegiosPagos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reportes Privilegios Pagos";
			this.Load += new System.EventHandler(this.ReportesPrivilegiosPagosLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnTabla;
		private System.Windows.Forms.Button btnAdeudo;
		private System.Windows.Forms.Button btnOperador;
	}
}
