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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosFactura));
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
			this.cmdModificar = new System.Windows.Forms.Button();
			this.lblCorreo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(0, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(528, 48);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Datos";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtRazon
			// 
			this.txtRazon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtRazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRazon.Location = new System.Drawing.Point(126, 60);
			this.txtRazon.Name = "txtRazon";
			this.txtRazon.Size = new System.Drawing.Size(369, 20);
			this.txtRazon.TabIndex = 1;
			this.txtRazon.Click += new System.EventHandler(this.TxtRazonClick);
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
			this.txtCp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCp.Location = new System.Drawing.Point(126, 112);
			this.txtCp.MaxLength = 6;
			this.txtCp.Name = "txtCp";
			this.txtCp.Size = new System.Drawing.Size(241, 20);
			this.txtCp.TabIndex = 3;
			this.txtCp.Click += new System.EventHandler(this.TxtCpClick);
			// 
			// txtColonia
			// 
			this.txtColonia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(126, 138);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(241, 20);
			this.txtColonia.TabIndex = 4;
			this.txtColonia.Click += new System.EventHandler(this.TxtColoniaClick);
			// 
			// lblColonia
			// 
			this.lblColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColonia.Location = new System.Drawing.Point(67, 135);
			this.lblColonia.Name = "lblColonia";
			this.lblColonia.Size = new System.Drawing.Size(61, 23);
			this.lblColonia.TabIndex = 5;
			this.lblColonia.Text = "Colonia:";
			this.lblColonia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCiudad
			// 
			this.txtCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCiudad.Location = new System.Drawing.Point(126, 190);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(241, 20);
			this.txtCiudad.TabIndex = 5;
			this.txtCiudad.Click += new System.EventHandler(this.TxtCiudadClick);
			// 
			// lblCiudad
			// 
			this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCiudad.Location = new System.Drawing.Point(20, 187);
			this.lblCiudad.Name = "lblCiudad";
			this.lblCiudad.Size = new System.Drawing.Size(100, 23);
			this.lblCiudad.TabIndex = 7;
			this.lblCiudad.Text = "Ciudad:";
			this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRFC
			// 
			this.txtRFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRFC.Location = new System.Drawing.Point(126, 86);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(241, 20);
			this.txtRFC.TabIndex = 6;
			this.txtRFC.Click += new System.EventHandler(this.TxtRFCClick);
			// 
			// lblRfc
			// 
			this.lblRfc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRfc.Location = new System.Drawing.Point(20, 83);
			this.lblRfc.Name = "lblRfc";
			this.lblRfc.Size = new System.Drawing.Size(100, 23);
			this.lblRfc.TabIndex = 9;
			this.lblRfc.Text = "RFC:";
			this.lblRfc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Location = new System.Drawing.Point(388, 165);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(107, 45);
			this.cmdAceptar.TabIndex = 7;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// lblDomicilio
			// 
			this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDomicilio.Location = new System.Drawing.Point(20, 162);
			this.lblDomicilio.Name = "lblDomicilio";
			this.lblDomicilio.Size = new System.Drawing.Size(100, 23);
			this.lblDomicilio.TabIndex = 15;
			this.lblDomicilio.Text = "Domicilio:";
			this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDomicilio.Location = new System.Drawing.Point(126, 164);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(241, 20);
			this.txtDomicilio.TabIndex = 2;
			this.txtDomicilio.Click += new System.EventHandler(this.TxtDomicilioClick);
			// 
			// cmdModificar
			// 
			this.cmdModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdModificar.Enabled = false;
			this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdModificar.Location = new System.Drawing.Point(388, 98);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(107, 45);
			this.cmdModificar.TabIndex = 8;
			this.cmdModificar.Text = "Modificar";
			this.cmdModificar.UseVisualStyleBackColor = true;
			this.cmdModificar.Click += new System.EventHandler(this.CmdModificarClick);
			// 
			// lblCorreo
			// 
			this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorreo.Location = new System.Drawing.Point(20, 215);
			this.lblCorreo.Name = "lblCorreo";
			this.lblCorreo.Size = new System.Drawing.Size(100, 21);
			this.lblCorreo.TabIndex = 16;
			this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(126, 216);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(241, 20);
			this.textBox1.TabIndex = 17;
			this.textBox1.Click += new System.EventHandler(this.TextBox1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Correo:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormDatosFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 241);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblCorreo);
			this.Controls.Add(this.cmdModificar);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDatosFactura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos de Facturación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatosFacturaFormClosing);
			this.Load += new System.EventHandler(this.FormDatosFacturaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblCorreo;
		private System.Windows.Forms.Button cmdModificar;
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
