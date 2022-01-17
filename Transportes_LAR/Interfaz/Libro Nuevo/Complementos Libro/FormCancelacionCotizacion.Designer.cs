/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 15/10/2015
 * Time: 02:03 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormCancelacionCotizacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelacionCotizacion));
			this.rbNo = new System.Windows.Forms.RadioButton();
			this.label108 = new System.Windows.Forms.Label();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.lblDestino = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblServicioC = new System.Windows.Forms.Label();
			this.rbsi = new System.Windows.Forms.RadioButton();
			this.lblID = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbCantidadP = new System.Windows.Forms.RadioButton();
			this.cbPrecio = new System.Windows.Forms.RadioButton();
			this.cbFactorE = new System.Windows.Forms.RadioButton();
			this.cbClaveEspecial = new System.Windows.Forms.RadioButton();
			this.txtFactorE = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbNo
			// 
			this.rbNo.Location = new System.Drawing.Point(167, 3);
			this.rbNo.Name = "rbNo";
			this.rbNo.Size = new System.Drawing.Size(42, 24);
			this.rbNo.TabIndex = 127;
			this.rbNo.TabStop = true;
			this.rbNo.Text = "No";
			this.rbNo.UseVisualStyleBackColor = true;
			this.rbNo.CheckedChanged += new System.EventHandler(this.RbNoCheckedChanged);
			// 
			// label108
			// 
			this.label108.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label108.Location = new System.Drawing.Point(16, 81);
			this.label108.Name = "label108";
			this.label108.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label108.Size = new System.Drawing.Size(270, 4);
			this.label108.TabIndex = 121;
			this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(66, 21);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(217, 20);
			this.txtDestino.TabIndex = 118;
			// 
			// lblDestino
			// 
			this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDestino.Location = new System.Drawing.Point(21, 24);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDestino.Size = new System.Drawing.Size(47, 15);
			this.lblDestino.TabIndex = 119;
			this.lblDestino.Text = "Destino:";
			this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.Location = new System.Drawing.Point(179, 136);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(77, 34);
			this.btnAceptar.TabIndex = 122;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// lblServicioC
			// 
			this.lblServicioC.Location = new System.Drawing.Point(9, 6);
			this.lblServicioC.Name = "lblServicioC";
			this.lblServicioC.Size = new System.Drawing.Size(100, 23);
			this.lblServicioC.TabIndex = 120;
			this.lblServicioC.Text = "Servicio continua";
			this.lblServicioC.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// rbsi
			// 
			this.rbsi.Location = new System.Drawing.Point(123, 3);
			this.rbsi.Name = "rbsi";
			this.rbsi.Size = new System.Drawing.Size(42, 24);
			this.rbsi.TabIndex = 126;
			this.rbsi.TabStop = true;
			this.rbsi.Text = "Si";
			this.rbsi.UseVisualStyleBackColor = true;
			this.rbsi.CheckedChanged += new System.EventHandler(this.RbsiCheckedChanged);
			// 
			// lblID
			// 
			this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(12, 2);
			this.lblID.Name = "lblID";
			this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblID.Size = new System.Drawing.Size(273, 15);
			this.lblID.TabIndex = 128;
			this.lblID.Text = "ID:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbsi);
			this.panel1.Controls.Add(this.lblServicioC);
			this.panel1.Controls.Add(this.rbNo);
			this.panel1.Location = new System.Drawing.Point(20, 45);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(263, 32);
			this.panel1.TabIndex = 130;
			// 
			// cbCantidadP
			// 
			this.cbCantidadP.Location = new System.Drawing.Point(16, 117);
			this.cbCantidadP.Name = "cbCantidadP";
			this.cbCantidadP.Size = new System.Drawing.Size(112, 24);
			this.cbCantidadP.TabIndex = 131;
			this.cbCantidadP.TabStop = true;
			this.cbCantidadP.Text = "Cant de Pasajeros";
			this.cbCantidadP.UseVisualStyleBackColor = true;
			// 
			// cbPrecio
			// 
			this.cbPrecio.Location = new System.Drawing.Point(16, 146);
			this.cbPrecio.Name = "cbPrecio";
			this.cbPrecio.Size = new System.Drawing.Size(62, 24);
			this.cbPrecio.TabIndex = 132;
			this.cbPrecio.TabStop = true;
			this.cbPrecio.Text = "Precio";
			this.cbPrecio.UseVisualStyleBackColor = true;
			// 
			// cbFactorE
			// 
			this.cbFactorE.Location = new System.Drawing.Point(167, 88);
			this.cbFactorE.Name = "cbFactorE";
			this.cbFactorE.Size = new System.Drawing.Size(113, 24);
			this.cbFactorE.TabIndex = 133;
			this.cbFactorE.TabStop = true;
			this.cbFactorE.Text = "Factor Externo";
			this.cbFactorE.UseVisualStyleBackColor = true;
			this.cbFactorE.CheckedChanged += new System.EventHandler(this.CbFactorECheckedChanged);
			// 
			// cbClaveEspecial
			// 
			this.cbClaveEspecial.Location = new System.Drawing.Point(16, 88);
			this.cbClaveEspecial.Name = "cbClaveEspecial";
			this.cbClaveEspecial.Size = new System.Drawing.Size(123, 24);
			this.cbClaveEspecial.TabIndex = 134;
			this.cbClaveEspecial.TabStop = true;
			this.cbClaveEspecial.Text = "Servicio Contratado";
			this.cbClaveEspecial.UseVisualStyleBackColor = true;
			// 
			// txtFactorE
			// 
			this.txtFactorE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtFactorE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFactorE.Enabled = false;
			this.txtFactorE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFactorE.Location = new System.Drawing.Point(144, 109);
			this.txtFactorE.Name = "txtFactorE";
			this.txtFactorE.Size = new System.Drawing.Size(143, 20);
			this.txtFactorE.TabIndex = 135;
			// 
			// FormCancelacionCotizacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 174);
			this.Controls.Add(this.txtFactorE);
			this.Controls.Add(this.cbClaveEspecial);
			this.Controls.Add(this.cbFactorE);
			this.Controls.Add(this.cbPrecio);
			this.Controls.Add(this.cbCantidadP);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.label108);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.lblDestino);
			this.Controls.Add(this.btnAceptar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCancelacionCotizacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancelación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCancelacionCotizacionFormClosing);
			this.Load += new System.EventHandler(this.FormCancelacionCotizacionLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtFactorE;
		private System.Windows.Forms.RadioButton cbClaveEspecial;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.RadioButton cbCantidadP;
		private System.Windows.Forms.RadioButton cbPrecio;
		private System.Windows.Forms.RadioButton cbFactorE;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.RadioButton rbsi;
		private System.Windows.Forms.Label lblServicioC;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.Label label108;
		private System.Windows.Forms.RadioButton rbNo;
	}
}
