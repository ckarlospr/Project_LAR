/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 26/12/2012
 * Time: 11:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormReconRutas
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReconRutas));
			this.lblRuta = new System.Windows.Forms.Label();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.txtMuestra = new System.Windows.Forms.TextBox();
			this.txtReconoce = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblRuta
			// 
			this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRuta.Location = new System.Drawing.Point(12, 63);
			this.lblRuta.Name = "lblRuta";
			this.lblRuta.Size = new System.Drawing.Size(43, 17);
			this.lblRuta.TabIndex = 0;
			this.lblRuta.Text = "Ruta";
			this.lblRuta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtRuta
			// 
			this.txtRuta.Enabled = false;
			this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRuta.Location = new System.Drawing.Point(61, 60);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(278, 22);
			this.txtRuta.TabIndex = 1;
			this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
			this.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAgregar.Location = new System.Drawing.Point(360, 29);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(83, 22);
			this.cmdAgregar.TabIndex = 2;
			this.cmdAgregar.Text = "Guardar";
			this.cmdAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// txtMuestra
			// 
			this.txtMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMuestra.Location = new System.Drawing.Point(12, 28);
			this.txtMuestra.Name = "txtMuestra";
			this.txtMuestra.Size = new System.Drawing.Size(146, 22);
			this.txtMuestra.TabIndex = 3;
			this.txtMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtReconoce
			// 
			this.txtReconoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReconoce.Location = new System.Drawing.Point(193, 28);
			this.txtReconoce.Name = "txtReconoce";
			this.txtReconoce.Size = new System.Drawing.Size(146, 22);
			this.txtReconoce.TabIndex = 4;
			this.txtReconoce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Maneja";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.Image")));
			this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancelar.Location = new System.Drawing.Point(359, 60);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(83, 22);
			this.cmdCancelar.TabIndex = 7;
			this.cmdCancelar.Text = "Cancelar";
			this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
			// 
			// FormReconRutas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 94);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtReconoce);
			this.Controls.Add(this.txtMuestra);
			this.Controls.Add(this.cmdAgregar);
			this.Controls.Add(this.txtRuta);
			this.Controls.Add(this.lblRuta);
			this.Name = "FormReconRutas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reconocimiento de rutas";
			this.Load += new System.EventHandler(this.FormReconRutasLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtReconoce;
		private System.Windows.Forms.TextBox txtMuestra;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Label lblRuta;
	}
}
