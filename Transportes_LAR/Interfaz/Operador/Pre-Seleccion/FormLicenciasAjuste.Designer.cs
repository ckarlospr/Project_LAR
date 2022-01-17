/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 11/05/2017
 * Time: 10:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormLicenciasAjuste
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLicenciasAjuste));
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.txtFederal = new System.Windows.Forms.TextBox();
			this.txtEstatal = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMedico = new System.Windows.Forms.TextBox();
			this.lblVenceEstatal = new System.Windows.Forms.Label();
			this.lblVenceFederal = new System.Windows.Forms.Label();
			this.lblVenceMedico = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.LightGray;
			this.label24.Location = new System.Drawing.Point(0, 25);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(106, 20);
			this.label24.TabIndex = 2;
			this.label24.Text = "Estatal: $";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.LightGray;
			this.label25.Location = new System.Drawing.Point(0, 45);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(106, 20);
			this.label25.TabIndex = 5;
			this.label25.Text = "Federal: $";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFederal
			// 
			this.txtFederal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFederal.Location = new System.Drawing.Point(107, 45);
			this.txtFederal.MaxLength = 10;
			this.txtFederal.Name = "txtFederal";
			this.txtFederal.Size = new System.Drawing.Size(71, 20);
			this.txtFederal.TabIndex = 6;
			this.txtFederal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtEstatal
			// 
			this.txtEstatal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEstatal.Location = new System.Drawing.Point(107, 25);
			this.txtEstatal.MaxLength = 10;
			this.txtEstatal.Name = "txtEstatal";
			this.txtEstatal.Size = new System.Drawing.Size(71, 20);
			this.txtEstatal.TabIndex = 3;
			this.txtEstatal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 25);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(130, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 16);
			this.label2.TabIndex = 67;
			this.label2.Text = "Tramite de Licencia";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(0, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Medico: $";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMedico
			// 
			this.txtMedico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMedico.Location = new System.Drawing.Point(107, 65);
			this.txtMedico.MaxLength = 10;
			this.txtMedico.Name = "txtMedico";
			this.txtMedico.Size = new System.Drawing.Size(71, 20);
			this.txtMedico.TabIndex = 9;
			this.txtMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblVenceEstatal
			// 
			this.lblVenceEstatal.BackColor = System.Drawing.Color.LightGray;
			this.lblVenceEstatal.Location = new System.Drawing.Point(178, 25);
			this.lblVenceEstatal.Name = "lblVenceEstatal";
			this.lblVenceEstatal.Size = new System.Drawing.Size(196, 20);
			this.lblVenceEstatal.TabIndex = 4;
			this.lblVenceEstatal.Text = "Vence en 1 Catorcena";
			this.lblVenceEstatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVenceFederal
			// 
			this.lblVenceFederal.BackColor = System.Drawing.Color.LightGray;
			this.lblVenceFederal.Location = new System.Drawing.Point(178, 45);
			this.lblVenceFederal.Name = "lblVenceFederal";
			this.lblVenceFederal.Size = new System.Drawing.Size(196, 20);
			this.lblVenceFederal.TabIndex = 7;
			this.lblVenceFederal.Text = "Vence en 1 Catorcena";
			this.lblVenceFederal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVenceMedico
			// 
			this.lblVenceMedico.BackColor = System.Drawing.Color.LightGray;
			this.lblVenceMedico.Location = new System.Drawing.Point(178, 65);
			this.lblVenceMedico.Name = "lblVenceMedico";
			this.lblVenceMedico.Size = new System.Drawing.Size(196, 20);
			this.lblVenceMedico.TabIndex = 10;
			this.lblVenceMedico.Text = "Vence en 1 Catorcena";
			this.lblVenceMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LightGray;
			this.label6.Location = new System.Drawing.Point(0, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Obs:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservaciones.Location = new System.Drawing.Point(40, 85);
			this.txtObservaciones.MaxLength = 3000;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(334, 20);
			this.txtObservaciones.TabIndex = 12;
			this.txtObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.Location = new System.Drawing.Point(299, 109);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(72, 27);
			this.cmdGuardar.TabIndex = 13;
			this.cmdGuardar.Text = "Aceptar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Location = new System.Drawing.Point(218, 109);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(72, 27);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// FormLicenciasAjuste
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 141);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.txtObservaciones);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblVenceMedico);
			this.Controls.Add(this.lblVenceFederal);
			this.Controls.Add(this.lblVenceEstatal);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMedico);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.txtFederal);
			this.Controls.Add(this.txtEstatal);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(390, 180);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(390, 180);
			this.Name = "FormLicenciasAjuste";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ajuste Licencias";
			this.Load += new System.EventHandler(this.FormLicenciasAjusteLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormLicenciasAjusteKeyUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button cmdGuardar;
		public System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblVenceMedico;
		private System.Windows.Forms.Label lblVenceFederal;
		private System.Windows.Forms.Label lblVenceEstatal;
		public System.Windows.Forms.TextBox txtMedico;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.TextBox txtEstatal;
		public System.Windows.Forms.TextBox txtFederal;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
	}
}
