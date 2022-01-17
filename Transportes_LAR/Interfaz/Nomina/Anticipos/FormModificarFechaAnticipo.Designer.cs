/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 05/08/2013
 * Time: 12:32 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	partial class FormModificarFechaAnticipo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarFechaAnticipo));
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.btnFecha = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dtFecha
			// 
			this.dtFecha.CustomFormat = "yyyy-MM-dd";
			this.dtFecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFecha.Location = new System.Drawing.Point(34, 26);
			this.dtFecha.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(92, 20);
			this.dtFecha.TabIndex = 138;
			// 
			// btnFecha
			// 
			this.btnFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFecha.BackColor = System.Drawing.Color.Transparent;
			this.btnFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFecha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnFecha.Image")));
			this.btnFecha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFecha.Location = new System.Drawing.Point(11, 65);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(64, 51);
			this.btnFecha.TabIndex = 139;
			this.btnFecha.Text = "Guardar";
			this.btnFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFecha.UseVisualStyleBackColor = false;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 49);
			this.label1.TabIndex = 140;
			this.label1.Text = "Modificar Fecha";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(84, 65);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(66, 51);
			this.btnCancelar.TabIndex = 200;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// FormModificarFechaAnticipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(161, 125);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.dtFecha);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormModificarFechaAnticipo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Modificar Fecha";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFecha;
		private System.Windows.Forms.DateTimePicker dtFecha;
	}
}
