/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 22/07/2015
 * Time: 10:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos.Orden_Trabajo
{
	partial class FormCancelarOrdenTrabajo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCancelarOrdenTrabajo));
			this.lblordent = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnCambiar = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtPersona = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timeHoraNueva = new System.Windows.Forms.DateTimePicker();
			this.dtpFechanNueva = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtMotivos = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblordent
			// 
			this.lblordent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblordent.Location = new System.Drawing.Point(12, 9);
			this.lblordent.Name = "lblordent";
			this.lblordent.Size = new System.Drawing.Size(397, 23);
			this.lblordent.TabIndex = 241;
			this.lblordent.Text = "Orden de Trabajo:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(240, 185);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 34);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnCambiar
			// 
			this.btnCambiar.Location = new System.Drawing.Point(106, 185);
			this.btnCambiar.Name = "btnCambiar";
			this.btnCambiar.Size = new System.Drawing.Size(75, 34);
			this.btnCambiar.TabIndex = 5;
			this.btnCambiar.Text = "Aceptar";
			this.btnCambiar.UseVisualStyleBackColor = true;
			this.btnCambiar.Click += new System.EventHandler(this.BtnCambiarClick);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.txtPersona);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.timeHoraNueva);
			this.groupBox3.Controls.Add(this.dtpFechanNueva);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.txtMotivos);
			this.groupBox3.Controls.Add(this.label27);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 35);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(397, 144);
			this.groupBox3.TabIndex = 238;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Reprogramar la Reparacion";
			// 
			// txtPersona
			// 
			this.txtPersona.Location = new System.Drawing.Point(78, 51);
			this.txtPersona.Multiline = true;
			this.txtPersona.Name = "txtPersona";
			this.txtPersona.Size = new System.Drawing.Size(311, 21);
			this.txtPersona.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 216;
			this.label1.Text = "Motivos";
			// 
			// timeHoraNueva
			// 
			this.timeHoraNueva.CustomFormat = "HH:mm";
			this.timeHoraNueva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeHoraNueva.Location = new System.Drawing.Point(280, 19);
			this.timeHoraNueva.Name = "timeHoraNueva";
			this.timeHoraNueva.ShowUpDown = true;
			this.timeHoraNueva.Size = new System.Drawing.Size(109, 20);
			this.timeHoraNueva.TabIndex = 2;
			this.timeHoraNueva.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// dtpFechanNueva
			// 
			this.dtpFechanNueva.CustomFormat = "dd/MM/yyyy";
			this.dtpFechanNueva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFechanNueva.Location = new System.Drawing.Point(78, 19);
			this.dtpFechanNueva.Name = "dtpFechanNueva";
			this.dtpFechanNueva.Size = new System.Drawing.Size(109, 20);
			this.dtpFechanNueva.TabIndex = 1;
			this.dtpFechanNueva.Tag = "1";
			this.dtpFechanNueva.Value = new System.DateTime(2015, 6, 29, 0, 0, 0, 0);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(2, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 20);
			this.label9.TabIndex = 215;
			this.label9.Text = "Fecha Nueva";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(212, 21);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 20);
			this.label11.TabIndex = 214;
			this.label11.Text = "Hora Nueva";
			// 
			// txtMotivos
			// 
			this.txtMotivos.Location = new System.Drawing.Point(78, 78);
			this.txtMotivos.Multiline = true;
			this.txtMotivos.Name = "txtMotivos";
			this.txtMotivos.Size = new System.Drawing.Size(311, 50);
			this.txtMotivos.TabIndex = 4;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(6, 54);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(66, 17);
			this.label27.TabIndex = 211;
			this.label27.Text = "Persona ";
			// 
			// FormCancelarOrdenTrabajo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 228);
			this.Controls.Add(this.lblordent);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnCambiar);
			this.Controls.Add(this.groupBox3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCancelarOrdenTrabajo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Reprogramación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCancelarOrdenTrabajoFormClosing);
			this.Load += new System.EventHandler(this.FormCancelarOrdenTrabajoLoad);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPersona;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtpFechanNueva;
		private System.Windows.Forms.DateTimePicker timeHoraNueva;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtMotivos;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnCambiar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblordent;
	}
}
