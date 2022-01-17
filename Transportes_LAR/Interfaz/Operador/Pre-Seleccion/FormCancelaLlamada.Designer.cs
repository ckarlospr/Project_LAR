/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 25/03/2017
 * Time: 10:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormCancelaLlamada
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelaLlamada));
			this.btnValida = new System.Windows.Forms.Button();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMotivio = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnValida
			// 
			this.btnValida.AutoSize = true;
			this.btnValida.Enabled = false;
			this.btnValida.Image = ((System.Drawing.Image)(resources.GetObject("btnValida.Image")));
			this.btnValida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnValida.Location = new System.Drawing.Point(181, 127);
			this.btnValida.Name = "btnValida";
			this.btnValida.Size = new System.Drawing.Size(70, 30);
			this.btnValida.TabIndex = 5;
			this.btnValida.Text = "Aceptar";
			this.btnValida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnValida.UseVisualStyleBackColor = true;
			this.btnValida.Click += new System.EventHandler(this.BtnValidaClick);
			// 
			// txtObservacion
			// 
			this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservacion.Location = new System.Drawing.Point(73, 41);
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(181, 80);
			this.txtObservacion.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Observación:";
			// 
			// cmbMotivio
			// 
			this.cmbMotivio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMotivio.FormattingEnabled = true;
			this.cmbMotivio.Items.AddRange(new object[] {
									"NO SE PRESENTO",
									"NO LE INTERESO"});
			this.cmbMotivio.Location = new System.Drawing.Point(73, 13);
			this.cmbMotivio.Name = "cmbMotivio";
			this.cmbMotivio.Size = new System.Drawing.Size(181, 21);
			this.cmbMotivio.TabIndex = 2;
			this.cmbMotivio.SelectedIndexChanged += new System.EventHandler(this.CmbMotivioSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Motivo:";
			// 
			// FormCancelaLlamada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 161);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbMotivio);
			this.Controls.Add(this.btnValida);
			this.Controls.Add(this.txtObservacion);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCancelaLlamada";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cancelar Llamada";
			this.Load += new System.EventHandler(this.FormCancelaLlamadaLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCancelaLlamadaKeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbMotivio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtObservacion;
		private System.Windows.Forms.Button btnValida;
	}
}
