/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 06/04/2013
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormCancelEsp
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
			this.cmdCancPunto = new System.Windows.Forms.Button();
			this.cmdCancAnt = new System.Windows.Forms.Button();
			this.cmdCancAsign = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdCancPunto
			// 
			this.cmdCancPunto.Location = new System.Drawing.Point(37, 12);
			this.cmdCancPunto.Name = "cmdCancPunto";
			this.cmdCancPunto.Size = new System.Drawing.Size(78, 62);
			this.cmdCancPunto.TabIndex = 0;
			this.cmdCancPunto.Text = "Cancelado en el punto";
			this.cmdCancPunto.UseVisualStyleBackColor = true;
			this.cmdCancPunto.Click += new System.EventHandler(this.CmdCancPuntoClick);
			// 
			// cmdCancAnt
			// 
			this.cmdCancAnt.Location = new System.Drawing.Point(138, 12);
			this.cmdCancAnt.Name = "cmdCancAnt";
			this.cmdCancAnt.Size = new System.Drawing.Size(78, 62);
			this.cmdCancAnt.TabIndex = 1;
			this.cmdCancAnt.Text = "Cancelado anticipado";
			this.cmdCancAnt.UseVisualStyleBackColor = true;
			this.cmdCancAnt.Click += new System.EventHandler(this.CmdCancAntClick);
			// 
			// cmdCancAsign
			// 
			this.cmdCancAsign.Location = new System.Drawing.Point(236, 12);
			this.cmdCancAsign.Name = "cmdCancAsign";
			this.cmdCancAsign.Size = new System.Drawing.Size(78, 62);
			this.cmdCancAsign.TabIndex = 2;
			this.cmdCancAsign.Text = "Cancelar asignación";
			this.cmdCancAsign.UseVisualStyleBackColor = true;
			this.cmdCancAsign.Click += new System.EventHandler(this.CmdCancAsignClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(41, 136);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(277, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(138, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "¿Quién cancela?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(122, 162);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(120, 23);
			this.cmdGuardar.TabIndex = 5;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCancelar.Location = new System.Drawing.Point(269, 82);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
			this.cmdCancelar.TabIndex = 6;
			this.cmdCancelar.Text = "Cancelar";
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
			// 
			// FormCancelEsp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(351, 108);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.cmdCancAsign);
			this.Controls.Add(this.cmdCancAnt);
			this.Controls.Add(this.cmdCancPunto);
			this.Name = "FormCancelEsp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancelar especial";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button cmdCancAsign;
		private System.Windows.Forms.Button cmdCancAnt;
		private System.Windows.Forms.Button cmdCancPunto;
	}
}
