/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 29/10/2014
 * Hora: 08:21 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Nomina
{
	partial class FormEfectivoCheque
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEfectivoCheque));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rCheque = new System.Windows.Forms.RadioButton();
			this.rEfectivo = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rCheque);
			this.groupBox1.Controls.Add(this.rEfectivo);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(167, 68);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de pago en la nomina";
			// 
			// rCheque
			// 
			this.rCheque.Location = new System.Drawing.Point(49, 38);
			this.rCheque.Name = "rCheque";
			this.rCheque.Size = new System.Drawing.Size(70, 24);
			this.rCheque.TabIndex = 1;
			this.rCheque.TabStop = true;
			this.rCheque.Text = "Cheque";
			this.rCheque.UseVisualStyleBackColor = true;
			this.rCheque.CheckedChanged += new System.EventHandler(this.RChequeCheckedChanged);
			// 
			// rEfectivo
			// 
			this.rEfectivo.Location = new System.Drawing.Point(49, 16);
			this.rEfectivo.Name = "rEfectivo";
			this.rEfectivo.Size = new System.Drawing.Size(70, 24);
			this.rEfectivo.TabIndex = 0;
			this.rEfectivo.TabStop = true;
			this.rEfectivo.Text = "Efectivo";
			this.rEfectivo.UseVisualStyleBackColor = true;
			this.rEfectivo.CheckedChanged += new System.EventHandler(this.REfectivoCheckedChanged);
			// 
			// FormEfectivoCheque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(178, 75);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormEfectivoCheque";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FormEfectivoChequeLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton rEfectivo;
		private System.Windows.Forms.RadioButton rCheque;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
