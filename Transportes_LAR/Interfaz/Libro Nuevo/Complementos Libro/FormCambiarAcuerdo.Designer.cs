/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 30/09/2015
 * Time: 10:50 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormCambiarAcuerdo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambiarAcuerdo));
			this.lblId = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.label70 = new System.Windows.Forms.Label();
			this.lblContacto = new System.Windows.Forms.Label();
			this.label67 = new System.Windows.Forms.Label();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.dtpFechaAcuerdo = new System.Windows.Forms.DateTimePicker();
			this.label60 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblId
			// 
			this.lblId.Location = new System.Drawing.Point(12, 110);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(120, 23);
			this.lblId.TabIndex = 113;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.Location = new System.Drawing.Point(150, 110);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(72, 34);
			this.btnAceptar.TabIndex = 112;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// label70
			// 
			this.label70.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label70.Location = new System.Drawing.Point(12, 27);
			this.label70.Name = "label70";
			this.label70.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label70.Size = new System.Drawing.Size(217, 3);
			this.label70.TabIndex = 111;
			this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblContacto
			// 
			this.lblContacto.Location = new System.Drawing.Point(12, 11);
			this.lblContacto.Name = "lblContacto";
			this.lblContacto.Size = new System.Drawing.Size(219, 23);
			this.lblContacto.TabIndex = 110;
			this.lblContacto.Text = "Jose Antonio Ramirez Ruiz Velaco";
			this.lblContacto.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label67
			// 
			this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label67.Location = new System.Drawing.Point(12, 36);
			this.label67.Name = "label67";
			this.label67.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label67.Size = new System.Drawing.Size(47, 15);
			this.label67.TabIndex = 109;
			this.label67.Text = "Destino:";
			this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(12, 54);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(217, 20);
			this.txtDestino.TabIndex = 108;
			// 
			// dtpFechaAcuerdo
			// 
			this.dtpFechaAcuerdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaAcuerdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaAcuerdo.Location = new System.Drawing.Point(124, 80);
			this.dtpFechaAcuerdo.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFechaAcuerdo.Name = "dtpFechaAcuerdo";
			this.dtpFechaAcuerdo.Size = new System.Drawing.Size(105, 20);
			this.dtpFechaAcuerdo.TabIndex = 106;
			this.dtpFechaAcuerdo.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label60
			// 
			this.label60.BackColor = System.Drawing.Color.Transparent;
			this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label60.Location = new System.Drawing.Point(12, 84);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(106, 12);
			this.label60.TabIndex = 107;
			this.label60.Text = "Fecha de Acuerdo";
			this.label60.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// FormCambiarAcuerdo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 151);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.label70);
			this.Controls.Add(this.lblContacto);
			this.Controls.Add(this.label67);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.dtpFechaAcuerdo);
			this.Controls.Add(this.label60);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(252, 190);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(252, 190);
			this.Name = "FormCambiarAcuerdo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acuerdo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCambiarAcuerdoFormClosing);
			this.Load += new System.EventHandler(this.FormCambiarAcuerdoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.DateTimePicker dtpFechaAcuerdo;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.Label label67;
		private System.Windows.Forms.Label lblContacto;
		private System.Windows.Forms.Label label70;
		private System.Windows.Forms.Button btnAceptar;
	}
}
