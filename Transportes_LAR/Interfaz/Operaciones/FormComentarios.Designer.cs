/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 17/10/2012
 * Time: 11:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormComentarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComentarios));
			this.txtNota = new System.Windows.Forms.TextBox();
			this.cmdMinimizar = new System.Windows.Forms.Button();
			this.cmdNuevo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbltfecha = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblRealizado = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNota
			// 
			this.txtNota.Enabled = false;
			this.txtNota.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNota.Location = new System.Drawing.Point(8, 37);
			this.txtNota.Multiline = true;
			this.txtNota.Name = "txtNota";
			this.txtNota.Size = new System.Drawing.Size(460, 131);
			this.txtNota.TabIndex = 0;
			this.txtNota.Text = "Comentario...";
			// 
			// cmdMinimizar
			// 
			this.cmdMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimizar.Image")));
			this.cmdMinimizar.Location = new System.Drawing.Point(476, 35);
			this.cmdMinimizar.Name = "cmdMinimizar";
			this.cmdMinimizar.Size = new System.Drawing.Size(41, 35);
			this.cmdMinimizar.TabIndex = 1;
			this.cmdMinimizar.UseVisualStyleBackColor = true;
			this.cmdMinimizar.Click += new System.EventHandler(this.CmdMinimizarClick);
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Image")));
			this.cmdNuevo.Location = new System.Drawing.Point(476, 134);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(41, 34);
			this.cmdNuevo.TabIndex = 3;
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(209, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ultimo Mensaje";
			// 
			// lbltfecha
			// 
			this.lbltfecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltfecha.Location = new System.Drawing.Point(350, 175);
			this.lbltfecha.Name = "lbltfecha";
			this.lbltfecha.Size = new System.Drawing.Size(47, 16);
			this.lbltfecha.TabIndex = 5;
			this.lbltfecha.Text = "Fecha:";
			// 
			// lblFecha
			// 
			this.lblFecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(399, 175);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(70, 16);
			this.lblFecha.TabIndex = 6;
			this.lblFecha.Text = "fecha";
			// 
			// lblRealizado
			// 
			this.lblRealizado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRealizado.Location = new System.Drawing.Point(238, 173);
			this.lblRealizado.Name = "lblRealizado";
			this.lblRealizado.Size = new System.Drawing.Size(115, 18);
			this.lblRealizado.TabIndex = 7;
			this.lblRealizado.Text = "Usuario";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(134, 173);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(92, 18);
			this.lblUsuario.TabIndex = 8;
			this.lblUsuario.Text = "Guardado por:";
			// 
			// FormComentarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(526, 200);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblRealizado);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lbltfecha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdNuevo);
			this.Controls.Add(this.cmdMinimizar);
			this.Controls.Add(this.txtNota);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormComentarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormComentarios";
			this.Load += new System.EventHandler(this.FormComentariosLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblRealizado;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Label lbltfecha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdNuevo;
		private System.Windows.Forms.Button cmdMinimizar;
		private System.Windows.Forms.TextBox txtNota;
	}
}
