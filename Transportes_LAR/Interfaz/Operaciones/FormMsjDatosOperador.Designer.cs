/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 26/11/2016
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormMsjDatosOperador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMsjDatosOperador));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblVehiculo = new System.Windows.Forms.Label();
			this.lblOtros = new System.Windows.Forms.Label();
			this.lblDomicilio = new System.Windows.Forms.Label();
			this.lblNumTelefono = new System.Windows.Forms.Label();
			this.lblNomAlias = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.lblVehiculo);
			this.panel1.Controls.Add(this.lblOtros);
			this.panel1.Controls.Add(this.lblDomicilio);
			this.panel1.Controls.Add(this.lblNumTelefono);
			this.panel1.Controls.Add(this.lblNomAlias);
			this.panel1.Location = new System.Drawing.Point(5, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(255, 129);
			this.panel1.TabIndex = 0;
			// 
			// lblVehiculo
			// 
			this.lblVehiculo.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVehiculo.Location = new System.Drawing.Point(125, 4);
			this.lblVehiculo.Name = "lblVehiculo";
			this.lblVehiculo.Size = new System.Drawing.Size(130, 18);
			this.lblVehiculo.TabIndex = 26;
			this.lblVehiculo.Text = "Vehiculo";
			this.lblVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOtros
			// 
			this.lblOtros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOtros.Location = new System.Drawing.Point(9, 53);
			this.lblOtros.Name = "lblOtros";
			this.lblOtros.Size = new System.Drawing.Size(237, 24);
			this.lblOtros.TabIndex = 25;
			this.lblOtros.Text = "Otros Teléfonos: ";
			this.lblOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDomicilio
			// 
			this.lblDomicilio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDomicilio.Location = new System.Drawing.Point(6, 84);
			this.lblDomicilio.Name = "lblDomicilio";
			this.lblDomicilio.Size = new System.Drawing.Size(237, 38);
			this.lblDomicilio.TabIndex = 24;
			this.lblDomicilio.Text = "Domicilio";
			this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumTelefono
			// 
			this.lblNumTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumTelefono.ForeColor = System.Drawing.Color.Red;
			this.lblNumTelefono.Location = new System.Drawing.Point(5, 31);
			this.lblNumTelefono.Name = "lblNumTelefono";
			this.lblNumTelefono.Size = new System.Drawing.Size(238, 19);
			this.lblNumTelefono.TabIndex = 23;
			this.lblNumTelefono.Text = "Teléfono";
			this.lblNumTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNomAlias
			// 
			this.lblNomAlias.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomAlias.Location = new System.Drawing.Point(6, 4);
			this.lblNomAlias.Name = "lblNomAlias";
			this.lblNomAlias.Size = new System.Drawing.Size(113, 18);
			this.lblNomAlias.TabIndex = 22;
			this.lblNomAlias.Text = "Alias";
			this.lblNomAlias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormMsjDatosOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(264, 139);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMsjDatosOperador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Datos Operador";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMsjDatosOperadorFormClosing);
			this.Load += new System.EventHandler(this.FormMsjDatosOperadorLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblVehiculo;
		private System.Windows.Forms.Label lblOtros;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNomAlias;
		private System.Windows.Forms.Label lblNumTelefono;
		private System.Windows.Forms.Label lblDomicilio;
	}
}
