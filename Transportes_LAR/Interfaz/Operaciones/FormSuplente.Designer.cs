/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 11/10/2012
 * Time: 8:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormSuplente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuplente));
			this.lblPregunta = new System.Windows.Forms.Label();
			this.cmdCambio = new System.Windows.Forms.Button();
			this.cmdSuplir = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPregunta
			// 
			this.lblPregunta.BackColor = System.Drawing.Color.White;
			this.lblPregunta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPregunta.Location = new System.Drawing.Point(166, 9);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(146, 21);
			this.lblPregunta.TabIndex = 0;
			this.lblPregunta.Text = "¿Qué desea hacer?";
			// 
			// cmdCambio
			// 
			this.cmdCambio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCambio.Image = ((System.Drawing.Image)(resources.GetObject("cmdCambio.Image")));
			this.cmdCambio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCambio.Location = new System.Drawing.Point(43, 77);
			this.cmdCambio.Name = "cmdCambio";
			this.cmdCambio.Size = new System.Drawing.Size(142, 27);
			this.cmdCambio.TabIndex = 1;
			this.cmdCambio.Text = "Cambiar operador";
			this.cmdCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCambio.UseVisualStyleBackColor = true;
			this.cmdCambio.Click += new System.EventHandler(this.CmdCambioClick);
			// 
			// cmdSuplir
			// 
			this.cmdSuplir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSuplir.Image = ((System.Drawing.Image)(resources.GetObject("cmdSuplir.Image")));
			this.cmdSuplir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdSuplir.Location = new System.Drawing.Point(199, 77);
			this.cmdSuplir.Name = "cmdSuplir";
			this.cmdSuplir.Size = new System.Drawing.Size(119, 27);
			this.cmdSuplir.TabIndex = 2;
			this.cmdSuplir.Text = "Suplir operador";
			this.cmdSuplir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdSuplir.UseVisualStyleBackColor = true;
			this.cmdSuplir.Click += new System.EventHandler(this.CmdSuplirClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(335, 77);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(87, 27);
			this.button3.TabIndex = 3;
			this.button3.Text = "Cancelar";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(457, 45);
			this.label1.TabIndex = 4;
			// 
			// FormSuplente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(451, 132);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.cmdSuplir);
			this.Controls.Add(this.cmdCambio);
			this.Controls.Add(this.lblPregunta);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(461, 164);
			this.MinimumSize = new System.Drawing.Size(461, 164);
			this.Name = "FormSuplente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Cambio Operador-Ruta";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button cmdSuplir;
		private System.Windows.Forms.Button cmdCambio;
		private System.Windows.Forms.Label lblPregunta;
	}
}
