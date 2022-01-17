/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 21/06/2013
 * Time: 03:06 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormDatosFactura
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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.txtRazon = new System.Windows.Forms.TextBox();
			this.lblRazon = new System.Windows.Forms.Label();
			this.lblCp = new System.Windows.Forms.Label();
			this.txtCp = new System.Windows.Forms.TextBox();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.lblColonia = new System.Windows.Forms.Label();
			this.txtCiudad = new System.Windows.Forms.TextBox();
			this.lblCiudad = new System.Windows.Forms.Label();
			this.txtRFC = new System.Windows.Forms.TextBox();
			this.lblRfc = new System.Windows.Forms.Label();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.lblDomicilio = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(443, 48);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "datos";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtRazon
			// 
			this.txtRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRazon.Enabled = false;
			this.txtRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRazon.Location = new System.Drawing.Point(126, 60);
			this.txtRazon.Name = "txtRazon";
			this.txtRazon.Size = new System.Drawing.Size(284, 20);
			this.txtRazon.TabIndex = 1;
			// 
			// lblRazon
			// 
			this.lblRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRazon.Location = new System.Drawing.Point(20, 58);
			this.lblRazon.Name = "lblRazon";
			this.lblRazon.Size = new System.Drawing.Size(100, 23);
			this.lblRazon.TabIndex = 2;
			this.lblRazon.Text = "Razon social:";
			this.lblRazon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCp
			// 
			this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCp.Location = new System.Drawing.Point(20, 109);
			this.lblCp.Name = "lblCp";
			this.lblCp.Size = new System.Drawing.Size(100, 23);
			this.lblCp.TabIndex = 3;
			this.lblCp.Text = "Codigo postal:";
			this.lblCp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCp
			// 
			this.txtCp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCp.Enabled = false;
			this.txtCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCp.Location = new System.Drawing.Point(126, 112);
			this.txtCp.MaxLength = 6;
			this.txtCp.Name = "txtCp";
			this.txtCp.Size = new System.Drawing.Size(93, 20);
			this.txtCp.TabIndex = 4;
			// 
			// txtColonia
			// 
			this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColonia.Enabled = false;
			this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(281, 112);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(129, 20);
			this.txtColonia.TabIndex = 6;
			// 
			// lblColonia
			// 
			this.lblColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColonia.Location = new System.Drawing.Point(222, 109);
			this.lblColonia.Name = "lblColonia";
			this.lblColonia.Size = new System.Drawing.Size(61, 23);
			this.lblColonia.TabIndex = 5;
			this.lblColonia.Text = "Colonia:";
			this.lblColonia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCiudad
			// 
			this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCiudad.Enabled = false;
			this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCiudad.Location = new System.Drawing.Point(126, 138);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(156, 20);
			this.txtCiudad.TabIndex = 8;
			// 
			// lblCiudad
			// 
			this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCiudad.Location = new System.Drawing.Point(20, 135);
			this.lblCiudad.Name = "lblCiudad";
			this.lblCiudad.Size = new System.Drawing.Size(100, 23);
			this.lblCiudad.TabIndex = 7;
			this.lblCiudad.Text = "Ciudad:";
			this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRFC
			// 
			this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRFC.Enabled = false;
			this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRFC.Location = new System.Drawing.Point(126, 164);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(156, 20);
			this.txtRFC.TabIndex = 10;
			// 
			// lblRfc
			// 
			this.lblRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRfc.Location = new System.Drawing.Point(20, 161);
			this.lblRfc.Name = "lblRfc";
			this.lblRfc.Size = new System.Drawing.Size(100, 23);
			this.lblRfc.TabIndex = 9;
			this.lblRfc.Text = "RFC:";
			this.lblRfc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Location = new System.Drawing.Point(302, 151);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(108, 33);
			this.cmdAceptar.TabIndex = 11;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// lblDomicilio
			// 
			this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDomicilio.Location = new System.Drawing.Point(20, 84);
			this.lblDomicilio.Name = "lblDomicilio";
			this.lblDomicilio.Size = new System.Drawing.Size(100, 23);
			this.lblDomicilio.TabIndex = 13;
			this.lblDomicilio.Text = "Domicilio:";
			this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDomicilio.Enabled = false;
			this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDomicilio.Location = new System.Drawing.Point(126, 86);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(284, 20);
			this.txtDomicilio.TabIndex = 12;
			// 
			// FormDatosFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 196);
			this.Controls.Add(this.lblDomicilio);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.txtRFC);
			this.Controls.Add(this.lblRfc);
			this.Controls.Add(this.txtCiudad);
			this.Controls.Add(this.lblCiudad);
			this.Controls.Add(this.txtColonia);
			this.Controls.Add(this.lblColonia);
			this.Controls.Add(this.txtCp);
			this.Controls.Add(this.lblCp);
			this.Controls.Add(this.lblRazon);
			this.Controls.Add(this.txtRazon);
			this.Controls.Add(this.lblTitulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDatosFactura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos de facturación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatosFacturaFormClosing);
			this.Load += new System.EventHandler(this.FormDatosFacturaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label lblDomicilio;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.Label lblRfc;
		private System.Windows.Forms.TextBox txtRFC;
		private System.Windows.Forms.Label lblCiudad;
		private System.Windows.Forms.TextBox txtCiudad;
		private System.Windows.Forms.Label lblColonia;
		private System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.TextBox txtCp;
		private System.Windows.Forms.Label lblCp;
		private System.Windows.Forms.Label lblRazon;
		private System.Windows.Forms.TextBox txtRazon;
		private System.Windows.Forms.Label lblTitulo;
	}
}
