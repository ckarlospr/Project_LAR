/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 14/08/2017
 * Time: 11:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormMotivoBT
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotivoBT));
			this.clbMotivos = new System.Windows.Forms.CheckedListBox();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// clbMotivos
			// 
			this.clbMotivos.BackColor = System.Drawing.SystemColors.Control;
			this.clbMotivos.FormattingEnabled = true;
			this.clbMotivos.Items.AddRange(new object[] {
									"ZONA",
									"EDAD",
									"TATUAJES",
									"PIERCING",
									"EXPERIENCIA",
									"LICENCIA",
									"NO SE RECONTRATA",
									"NO LE INTERESO"});
			this.clbMotivos.Location = new System.Drawing.Point(3, 2);
			this.clbMotivos.Name = "clbMotivos";
			this.clbMotivos.Size = new System.Drawing.Size(166, 154);
			this.clbMotivos.TabIndex = 0;
			this.clbMotivos.SelectedIndexChanged += new System.EventHandler(this.ClbMotivosSelectedIndexChanged);
			// 
			// txtMotivo
			// 
			this.txtMotivo.Location = new System.Drawing.Point(3, 106);
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.ReadOnly = true;
			this.txtMotivo.Size = new System.Drawing.Size(166, 20);
			this.txtMotivo.TabIndex = 1;
			this.txtMotivo.Visible = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.AutoSize = true;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(50, 159);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(77, 31);
			this.btnGuardar.TabIndex = 15;
			this.btnGuardar.Text = "Aceptar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// FormMotivoBT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(172, 192);
			this.Controls.Add(this.clbMotivos);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.btnGuardar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMotivoBT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Motivo Bolsa Trabajo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMotivoBTFormClosing);
			this.Load += new System.EventHandler(this.FormMotivoBTLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMotivoBTKeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtMotivo;
		private System.Windows.Forms.CheckedListBox clbMotivos;
	}
}
