/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 27/07/2016
 * Hora: 02:14 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	partial class FormCancela
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancela));
			this.txtmotivo = new System.Windows.Forms.TextBox();
			this.lblMotivo = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtCancela = new System.Windows.Forms.TextBox();
			this.lblCancela = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtmotivo
			// 
			this.txtmotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtmotivo.Location = new System.Drawing.Point(64, 39);
			this.txtmotivo.Multiline = true;
			this.txtmotivo.Name = "txtmotivo";
			this.txtmotivo.Size = new System.Drawing.Size(212, 79);
			this.txtmotivo.TabIndex = 130;
			this.txtmotivo.TextChanged += new System.EventHandler(this.TxtmotivoTextChanged);
			// 
			// lblMotivo
			// 
			this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMotivo.Location = new System.Drawing.Point(9, 37);
			this.lblMotivo.Name = "lblMotivo";
			this.lblMotivo.Size = new System.Drawing.Size(49, 23);
			this.lblMotivo.TabIndex = 128;
			this.lblMotivo.Text = "Motivo:";
			this.lblMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Enabled = false;
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.Location = new System.Drawing.Point(199, 124);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(77, 34);
			this.btnAceptar.TabIndex = 129;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtCancela
			// 
			this.txtCancela.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtCancela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCancela.Enabled = false;
			this.txtCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCancela.Location = new System.Drawing.Point(64, 11);
			this.txtCancela.Name = "txtCancela";
			this.txtCancela.Size = new System.Drawing.Size(210, 20);
			this.txtCancela.TabIndex = 126;
			// 
			// lblCancela
			// 
			this.lblCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCancela.Location = new System.Drawing.Point(4, 12);
			this.lblCancela.Name = "lblCancela";
			this.lblCancela.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCancela.Size = new System.Drawing.Size(54, 15);
			this.lblCancela.TabIndex = 127;
			this.lblCancela.Text = "Ruta:";
			this.lblCancela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormCancela
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 163);
			this.Controls.Add(this.txtmotivo);
			this.Controls.Add(this.lblMotivo);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtCancela);
			this.Controls.Add(this.lblCancela);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCancela";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancelar";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCancelaFormClosing);
			this.Load += new System.EventHandler(this.FormCancelaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblCancela;
		private System.Windows.Forms.TextBox txtCancela;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblMotivo;
		private System.Windows.Forms.TextBox txtmotivo;
	}
}
