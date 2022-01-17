/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 04/03/2013
 * Time: 9:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormPruebasRend
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPruebasRend));
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.txtsuperv = new System.Windows.Forms.TextBox();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.lblOperador = new System.Windows.Forms.Label();
			this.lblRuta = new System.Windows.Forms.Label();
			this.lblSuperv = new System.Windows.Forms.Label();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtOperador
			// 
			this.txtOperador.Enabled = false;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(26, 20);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(145, 22);
			this.txtOperador.TabIndex = 0;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtsuperv
			// 
			this.txtsuperv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsuperv.Location = new System.Drawing.Point(177, 20);
			this.txtsuperv.Name = "txtsuperv";
			this.txtsuperv.Size = new System.Drawing.Size(145, 22);
			this.txtsuperv.TabIndex = 1;
			this.txtsuperv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRuta
			// 
			this.txtRuta.Enabled = false;
			this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRuta.Location = new System.Drawing.Point(26, 82);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(296, 22);
			this.txtRuta.TabIndex = 2;
			this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblOperador
			// 
			this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(26, 43);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(145, 23);
			this.lblOperador.TabIndex = 3;
			this.lblOperador.Text = "Operador";
			this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRuta
			// 
			this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRuta.Location = new System.Drawing.Point(26, 107);
			this.lblRuta.Name = "lblRuta";
			this.lblRuta.Size = new System.Drawing.Size(296, 23);
			this.lblRuta.TabIndex = 4;
			this.lblRuta.Text = "Ruta";
			this.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblSuperv
			// 
			this.lblSuperv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSuperv.Location = new System.Drawing.Point(177, 43);
			this.lblSuperv.Name = "lblSuperv";
			this.lblSuperv.Size = new System.Drawing.Size(145, 23);
			this.lblSuperv.TabIndex = 5;
			this.lblSuperv.Text = "Supervisa";
			this.lblSuperv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.Image")));
			this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancelar.Location = new System.Drawing.Point(343, 107);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(83, 22);
			this.cmdCancelar.TabIndex = 9;
			this.cmdCancelar.Text = "Cancelar";
			this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
			this.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAgregar.Location = new System.Drawing.Point(343, 68);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(83, 22);
			this.cmdAgregar.TabIndex = 8;
			this.cmdAgregar.Text = "Guardar";
			this.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// FormPruebasRend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 145);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdAgregar);
			this.Controls.Add(this.lblSuperv);
			this.Controls.Add(this.lblRuta);
			this.Controls.Add(this.lblOperador);
			this.Controls.Add(this.txtRuta);
			this.Controls.Add(this.txtsuperv);
			this.Controls.Add(this.txtOperador);
			this.Name = "FormPruebasRend";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pruebas de rendimiento";
			this.Load += new System.EventHandler(this.FormPruebasRendLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Label lblSuperv;
		private System.Windows.Forms.Label lblRuta;
		private System.Windows.Forms.Label lblOperador;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.TextBox txtsuperv;
		private System.Windows.Forms.TextBox txtOperador;
	}
}
