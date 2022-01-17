/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 07/11/2012
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormDatosOperador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosOperador));
			this.lblNumeroDeVehiculo = new System.Windows.Forms.Label();
			this.lblNumTelefono = new System.Windows.Forms.Label();
			this.lblTipoDeVehicuclo = new System.Windows.Forms.Label();
			this.lblNomAlias = new System.Windows.Forms.Label();
			this.pbDOperador = new System.Windows.Forms.PictureBox();
			this.lblDomicilio = new System.Windows.Forms.Label();
			this.lblTelAlt = new System.Windows.Forms.Label();
			this.cmdModificar = new System.Windows.Forms.Button();
			this.lblPatron = new System.Windows.Forms.Label();
			this.lblTarjeta = new System.Windows.Forms.Label();
			this.cmdRutas = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbDOperador)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNumeroDeVehiculo
			// 
			this.lblNumeroDeVehiculo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumeroDeVehiculo.Location = new System.Drawing.Point(256, 22);
			this.lblNumeroDeVehiculo.Name = "lblNumeroDeVehiculo";
			this.lblNumeroDeVehiculo.Size = new System.Drawing.Size(116, 18);
			this.lblNumeroDeVehiculo.TabIndex = 8;
			this.lblNumeroDeVehiculo.Text = "Vehiculo";
			this.lblNumeroDeVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumTelefono
			// 
			this.lblNumTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumTelefono.ForeColor = System.Drawing.Color.Red;
			this.lblNumTelefono.Location = new System.Drawing.Point(151, 40);
			this.lblNumTelefono.Name = "lblNumTelefono";
			this.lblNumTelefono.Size = new System.Drawing.Size(221, 19);
			this.lblNumTelefono.TabIndex = 7;
			this.lblNumTelefono.Text = "Telefono";
			this.lblNumTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTipoDeVehicuclo
			// 
			this.lblTipoDeVehicuclo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTipoDeVehicuclo.Location = new System.Drawing.Point(151, 22);
			this.lblTipoDeVehicuclo.Name = "lblTipoDeVehicuclo";
			this.lblTipoDeVehicuclo.Size = new System.Drawing.Size(99, 18);
			this.lblTipoDeVehicuclo.TabIndex = 6;
			this.lblTipoDeVehicuclo.Text = "Tipo vehiculo";
			this.lblTipoDeVehicuclo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNomAlias
			// 
			this.lblNomAlias.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomAlias.Location = new System.Drawing.Point(151, 1);
			this.lblNomAlias.Name = "lblNomAlias";
			this.lblNomAlias.Size = new System.Drawing.Size(221, 18);
			this.lblNomAlias.TabIndex = 5;
			this.lblNomAlias.Text = "Alias";
			this.lblNomAlias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pbDOperador
			// 
			this.pbDOperador.BackColor = System.Drawing.SystemColors.Menu;
			this.pbDOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbDOperador.Location = new System.Drawing.Point(1, 1);
			this.pbDOperador.Name = "pbDOperador";
			this.pbDOperador.Size = new System.Drawing.Size(141, 155);
			this.pbDOperador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDOperador.TabIndex = 9;
			this.pbDOperador.TabStop = false;
			// 
			// lblDomicilio
			// 
			this.lblDomicilio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDomicilio.Location = new System.Drawing.Point(4, 179);
			this.lblDomicilio.Name = "lblDomicilio";
			this.lblDomicilio.Size = new System.Drawing.Size(294, 41);
			this.lblDomicilio.TabIndex = 10;
			this.lblDomicilio.Text = "Vehiculo";
			this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTelAlt
			// 
			this.lblTelAlt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelAlt.Location = new System.Drawing.Point(151, 59);
			this.lblTelAlt.Name = "lblTelAlt";
			this.lblTelAlt.Size = new System.Drawing.Size(221, 59);
			this.lblTelAlt.TabIndex = 11;
			// 
			// cmdModificar
			// 
			this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdModificar.Location = new System.Drawing.Point(304, 199);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(68, 22);
			this.cmdModificar.TabIndex = 12;
			this.cmdModificar.Text = "Modificar";
			this.cmdModificar.UseVisualStyleBackColor = true;
			this.cmdModificar.Click += new System.EventHandler(this.CmdModificarClick);
			// 
			// lblPatron
			// 
			this.lblPatron.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPatron.Location = new System.Drawing.Point(4, 158);
			this.lblPatron.Name = "lblPatron";
			this.lblPatron.Size = new System.Drawing.Size(179, 18);
			this.lblPatron.TabIndex = 13;
			this.lblPatron.Text = "Patron";
			this.lblPatron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTarjeta
			// 
			this.lblTarjeta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTarjeta.ForeColor = System.Drawing.Color.Blue;
			this.lblTarjeta.Location = new System.Drawing.Point(193, 118);
			this.lblTarjeta.Name = "lblTarjeta";
			this.lblTarjeta.Size = new System.Drawing.Size(179, 58);
			this.lblTarjeta.TabIndex = 14;
			this.lblTarjeta.Text = "Tarjeta";
			this.lblTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdRutas
			// 
			this.cmdRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRutas.Location = new System.Drawing.Point(304, 178);
			this.cmdRutas.Name = "cmdRutas";
			this.cmdRutas.Size = new System.Drawing.Size(68, 22);
			this.cmdRutas.TabIndex = 15;
			this.cmdRutas.Text = "Rutas";
			this.cmdRutas.UseVisualStyleBackColor = true;
			this.cmdRutas.Click += new System.EventHandler(this.CmdRutasClick);
			// 
			// FormDatosOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(375, 221);
			this.Controls.Add(this.cmdRutas);
			this.Controls.Add(this.lblTarjeta);
			this.Controls.Add(this.lblPatron);
			this.Controls.Add(this.cmdModificar);
			this.Controls.Add(this.lblTelAlt);
			this.Controls.Add(this.lblDomicilio);
			this.Controls.Add(this.pbDOperador);
			this.Controls.Add(this.lblNumeroDeVehiculo);
			this.Controls.Add(this.lblNumTelefono);
			this.Controls.Add(this.lblTipoDeVehicuclo);
			this.Controls.Add(this.lblNomAlias);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDatosOperador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos Operador";
			this.Load += new System.EventHandler(this.FormDatosOperadorLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbDOperador)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdRutas;
		private System.Windows.Forms.Label lblTarjeta;
		private System.Windows.Forms.Label lblPatron;
		private System.Windows.Forms.Button cmdModificar;
		private System.Windows.Forms.Label lblTelAlt;
		private System.Windows.Forms.Label lblDomicilio;
		private System.Windows.Forms.PictureBox pbDOperador;
		private System.Windows.Forms.Label lblNomAlias;
		private System.Windows.Forms.Label lblTipoDeVehicuclo;
		private System.Windows.Forms.Label lblNumTelefono;
		private System.Windows.Forms.Label lblNumeroDeVehiculo;
	}
}
