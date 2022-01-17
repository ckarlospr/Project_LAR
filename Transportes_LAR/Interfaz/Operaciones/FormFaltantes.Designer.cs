/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 16/04/2013
 * Time: 11:22 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormFaltantes
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtDiaToma = new System.Windows.Forms.TextBox();
			this.txtUsuarioToma = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHoraToma = new System.Windows.Forms.TextBox();
			this.txtUsuarioConf = new System.Windows.Forms.TextBox();
			this.txtAtendioConf = new System.Windows.Forms.TextBox();
			this.txtHoraConf = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "El servicio fue tomado por:";
			// 
			// txtDiaToma
			// 
			this.txtDiaToma.Enabled = false;
			this.txtDiaToma.Location = new System.Drawing.Point(106, 34);
			this.txtDiaToma.Name = "txtDiaToma";
			this.txtDiaToma.Size = new System.Drawing.Size(125, 20);
			this.txtDiaToma.TabIndex = 1;
			this.txtDiaToma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtUsuarioToma
			// 
			this.txtUsuarioToma.Enabled = false;
			this.txtUsuarioToma.Location = new System.Drawing.Point(256, 8);
			this.txtUsuarioToma.Name = "txtUsuarioToma";
			this.txtUsuarioToma.Size = new System.Drawing.Size(160, 20);
			this.txtUsuarioToma.TabIndex = 3;
			this.txtUsuarioToma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "El día:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(245, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "A las:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Confirmado por:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(39, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 19);
			this.label5.TabIndex = 7;
			this.label5.Text = "Día y Hora:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(59, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 19);
			this.label6.TabIndex = 8;
			this.label6.Text = "Atendio:";
			// 
			// txtHoraToma
			// 
			this.txtHoraToma.Enabled = false;
			this.txtHoraToma.Location = new System.Drawing.Point(292, 34);
			this.txtHoraToma.Name = "txtHoraToma";
			this.txtHoraToma.Size = new System.Drawing.Size(124, 20);
			this.txtHoraToma.TabIndex = 9;
			this.txtHoraToma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtUsuarioConf
			// 
			this.txtUsuarioConf.Enabled = false;
			this.txtUsuarioConf.Location = new System.Drawing.Point(134, 24);
			this.txtUsuarioConf.Name = "txtUsuarioConf";
			this.txtUsuarioConf.Size = new System.Drawing.Size(231, 20);
			this.txtUsuarioConf.TabIndex = 10;
			this.txtUsuarioConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtAtendioConf
			// 
			this.txtAtendioConf.Enabled = false;
			this.txtAtendioConf.Location = new System.Drawing.Point(134, 48);
			this.txtAtendioConf.Name = "txtAtendioConf";
			this.txtAtendioConf.Size = new System.Drawing.Size(231, 20);
			this.txtAtendioConf.TabIndex = 11;
			this.txtAtendioConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtHoraConf
			// 
			this.txtHoraConf.Enabled = false;
			this.txtHoraConf.Location = new System.Drawing.Point(134, 72);
			this.txtHoraConf.Name = "txtHoraConf";
			this.txtHoraConf.Size = new System.Drawing.Size(231, 20);
			this.txtHoraConf.TabIndex = 12;
			this.txtHoraConf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtHoraConf);
			this.groupBox1.Controls.Add(this.txtAtendioConf);
			this.groupBox1.Controls.Add(this.txtUsuarioConf);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(39, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 104);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Confirmación de viaje:";
			// 
			// FormFaltantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(464, 176);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtHoraToma);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsuarioToma);
			this.Controls.Add(this.txtDiaToma);
			this.Controls.Add(this.label1);
			this.Name = "FormFaltantes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Información especiales";
			this.Load += new System.EventHandler(this.FormFaltantesLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtHoraConf;
		private System.Windows.Forms.TextBox txtAtendioConf;
		private System.Windows.Forms.TextBox txtUsuarioConf;
		private System.Windows.Forms.TextBox txtHoraToma;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsuarioToma;
		private System.Windows.Forms.TextBox txtDiaToma;
		private System.Windows.Forms.Label label1;
	}
}
