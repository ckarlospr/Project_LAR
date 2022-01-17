/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 14/02/2017
 * Hora: 13:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormRechazar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRechazar));
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnValida = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMotivo
			// 
			this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMotivo.Location = new System.Drawing.Point(50, 12);
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(154, 20);
			this.txtMotivo.TabIndex = 5;
			this.txtMotivo.TextChanged += new System.EventHandler(this.TxtMotivoTextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Motivo:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.AutoSize = true;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(42, 41);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(65, 30);
			this.btnCancelar.TabIndex = 301;
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnValida
			// 
			this.btnValida.AutoSize = true;
			this.btnValida.Enabled = false;
			this.btnValida.Image = ((System.Drawing.Image)(resources.GetObject("btnValida.Image")));
			this.btnValida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnValida.Location = new System.Drawing.Point(115, 41);
			this.btnValida.Name = "btnValida";
			this.btnValida.Size = new System.Drawing.Size(70, 30);
			this.btnValida.TabIndex = 300;
			this.btnValida.Text = "Aceptar";
			this.btnValida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnValida.UseVisualStyleBackColor = true;
			this.btnValida.Click += new System.EventHandler(this.BtnValidaClick);
			// 
			// FormRechazar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(211, 76);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnValida);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRechazar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rechazar Candidato";
			this.Load += new System.EventHandler(this.FormRechazarLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormRechazarKeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnValida;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMotivo;
	}
}
