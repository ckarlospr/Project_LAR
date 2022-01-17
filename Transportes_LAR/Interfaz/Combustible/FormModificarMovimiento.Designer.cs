/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 22/11/2016
 * Time: 9:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormModificarMovimiento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarMovimiento));
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.txtMovimiento = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMovimientoNuevo = new System.Windows.Forms.TextBox();
			this.btnGuarda = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.Enabled = false;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"TALLER",
									"ZONA",
									"EMPRESA",
									"RUTA",
									"OFICINA",
									"GASOLINERA",
									"VIVIENDA"});
			this.cmbTipo.Location = new System.Drawing.Point(6, 20);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(109, 21);
			this.cmbTipo.TabIndex = 1;
			// 
			// txtMovimiento
			// 
			this.txtMovimiento.Enabled = false;
			this.txtMovimiento.Location = new System.Drawing.Point(119, 21);
			this.txtMovimiento.Name = "txtMovimiento";
			this.txtMovimiento.Size = new System.Drawing.Size(130, 20);
			this.txtMovimiento.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(266, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nuevo:";
			// 
			// txtMovimientoNuevo
			// 
			this.txtMovimientoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMovimientoNuevo.Location = new System.Drawing.Point(308, 21);
			this.txtMovimientoNuevo.Name = "txtMovimientoNuevo";
			this.txtMovimientoNuevo.Size = new System.Drawing.Size(130, 20);
			this.txtMovimientoNuevo.TabIndex = 4;
			this.txtMovimientoNuevo.TextChanged += new System.EventHandler(this.TxtMovimientoNuevoTextChanged);
			// 
			// btnGuarda
			// 
			this.btnGuarda.Enabled = false;
			this.btnGuarda.Image = ((System.Drawing.Image)(resources.GetObject("btnGuarda.Image")));
			this.btnGuarda.Location = new System.Drawing.Point(463, 12);
			this.btnGuarda.Name = "btnGuarda";
			this.btnGuarda.Size = new System.Drawing.Size(33, 33);
			this.btnGuarda.TabIndex = 5;
			this.btnGuarda.UseVisualStyleBackColor = true;
			this.btnGuarda.Click += new System.EventHandler(this.BtnGuardaClick);
			// 
			// FormModificarMovimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 55);
			this.Controls.Add(this.btnGuarda);
			this.Controls.Add(this.txtMovimientoNuevo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMovimiento);
			this.Controls.Add(this.cmbTipo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormModificarMovimiento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar Movimiento";
			this.Load += new System.EventHandler(this.FormModificarMovimientoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnGuarda;
		private System.Windows.Forms.TextBox txtMovimientoNuevo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMovimiento;
		private System.Windows.Forms.ComboBox cmbTipo;
	}
}
