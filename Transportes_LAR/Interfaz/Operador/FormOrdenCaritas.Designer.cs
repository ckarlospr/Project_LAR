/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 08/09/2013
 * Time: 09:49 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormOrdenCaritas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenCaritas));
			this.btnVehiculo = new System.Windows.Forms.Button();
			this.btnCamioneta = new System.Windows.Forms.Button();
			this.btnAlfabetico = new System.Windows.Forms.Button();
			this.btnventas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVehiculo
			// 
			this.btnVehiculo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculo.Image")));
			this.btnVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVehiculo.Location = new System.Drawing.Point(12, 14);
			this.btnVehiculo.Name = "btnVehiculo";
			this.btnVehiculo.Size = new System.Drawing.Size(100, 33);
			this.btnVehiculo.TabIndex = 0;
			this.btnVehiculo.Text = "Camiones";
			this.btnVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVehiculo.UseVisualStyleBackColor = true;
			this.btnVehiculo.Click += new System.EventHandler(this.BtnVehiculoClick);
			// 
			// btnCamioneta
			// 
			this.btnCamioneta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("btnCamioneta.Image")));
			this.btnCamioneta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCamioneta.Location = new System.Drawing.Point(118, 14);
			this.btnCamioneta.Name = "btnCamioneta";
			this.btnCamioneta.Size = new System.Drawing.Size(114, 32);
			this.btnCamioneta.TabIndex = 1;
			this.btnCamioneta.Text = "Camionetas";
			this.btnCamioneta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCamioneta.UseVisualStyleBackColor = true;
			this.btnCamioneta.Click += new System.EventHandler(this.BtnCamionetaClick);
			// 
			// btnAlfabetico
			// 
			this.btnAlfabetico.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlfabetico.Image = ((System.Drawing.Image)(resources.GetObject("btnAlfabetico.Image")));
			this.btnAlfabetico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlfabetico.Location = new System.Drawing.Point(238, 14);
			this.btnAlfabetico.Name = "btnAlfabetico";
			this.btnAlfabetico.Size = new System.Drawing.Size(99, 32);
			this.btnAlfabetico.TabIndex = 2;
			this.btnAlfabetico.Text = "Alfabético";
			this.btnAlfabetico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAlfabetico.UseVisualStyleBackColor = true;
			this.btnAlfabetico.Click += new System.EventHandler(this.BtnAlfabeticoClick);
			// 
			// btnventas
			// 
			this.btnventas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnventas.Image = ((System.Drawing.Image)(resources.GetObject("btnventas.Image")));
			this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnventas.Location = new System.Drawing.Point(343, 14);
			this.btnventas.Name = "btnventas";
			this.btnventas.Size = new System.Drawing.Size(83, 32);
			this.btnventas.TabIndex = 3;
			this.btnventas.Text = "Ventas";
			this.btnventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnventas.UseVisualStyleBackColor = true;
			this.btnventas.Click += new System.EventHandler(this.BtnventasClick);
			// 
			// FormOrdenCaritas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(441, 63);
			this.Controls.Add(this.btnventas);
			this.Controls.Add(this.btnAlfabetico);
			this.Controls.Add(this.btnCamioneta);
			this.Controls.Add(this.btnVehiculo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormOrdenCaritas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Directorio por vehiculo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdenCaritasFormClosing);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnventas;
		private System.Windows.Forms.Button btnAlfabetico;
		private System.Windows.Forms.Button btnCamioneta;
		private System.Windows.Forms.Button btnVehiculo;
	}
}
