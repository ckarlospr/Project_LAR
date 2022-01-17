/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 08/01/2013
 * Time: 13:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormDatosDia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosDia));
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.txtLitros = new System.Windows.Forms.TextBox();
			this.txtRendimiento = new System.Windows.Forms.TextBox();
			this.txtHora = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.txtGasolinera = new System.Windows.Forms.TextBox();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFecha
			// 
			this.txtFecha.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtFecha.Enabled = false;
			this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha.ForeColor = System.Drawing.Color.Red;
			this.txtFecha.Location = new System.Drawing.Point(21, 2);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(90, 22);
			this.txtFecha.TabIndex = 0;
			this.txtFecha.Text = "00/00/0000";
			this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtLitros
			// 
			this.txtLitros.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtLitros.Enabled = false;
			this.txtLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLitros.Location = new System.Drawing.Point(452, 1);
			this.txtLitros.Name = "txtLitros";
			this.txtLitros.Size = new System.Drawing.Size(80, 21);
			this.txtLitros.TabIndex = 4;
			this.txtLitros.Text = "0";
			this.txtLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRendimiento
			// 
			this.txtRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRendimiento.ForeColor = System.Drawing.Color.Red;
			this.txtRendimiento.Location = new System.Drawing.Point(113, 15);
			this.txtRendimiento.Name = "txtRendimiento";
			this.txtRendimiento.Size = new System.Drawing.Size(50, 21);
			this.txtRendimiento.TabIndex = 5;
			this.txtRendimiento.Text = "0";
			this.txtRendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtHora
			// 
			this.txtHora.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtHora.Enabled = false;
			this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHora.Location = new System.Drawing.Point(117, 2);
			this.txtHora.Name = "txtHora";
			this.txtHora.Size = new System.Drawing.Size(50, 21);
			this.txtHora.TabIndex = 2;
			this.txtHora.Text = "00:00";
			this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtKm
			// 
			this.txtKm.Enabled = false;
			this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKm.Location = new System.Drawing.Point(371, 1);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(80, 21);
			this.txtKm.TabIndex = 3;
			this.txtKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtComentario
			// 
			this.txtComentario.Enabled = false;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(594, 1);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(250, 21);
			this.txtComentario.TabIndex = 7;
			this.txtComentario.Text = "Problemas...";
			// 
			// txtPrecio
			// 
			this.txtPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtPrecio.Enabled = false;
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(538, 1);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(50, 21);
			this.txtPrecio.TabIndex = 6;
			this.txtPrecio.Text = "0";
			this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.Image")));
			this.cmdAceptar.Location = new System.Drawing.Point(847, -1);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(32, 23);
			this.cmdAceptar.TabIndex = 8;
			this.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Visible = false;
			// 
			// txtGasolinera
			// 
			this.txtGasolinera.Enabled = false;
			this.txtGasolinera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGasolinera.Location = new System.Drawing.Point(265, 1);
			this.txtGasolinera.Name = "txtGasolinera";
			this.txtGasolinera.Size = new System.Drawing.Size(100, 21);
			this.txtGasolinera.TabIndex = 1;
			this.txtGasolinera.Text = "GASOLINERA";
			this.txtGasolinera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtOperador
			// 
			this.txtOperador.Enabled = false;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(173, 1);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(90, 21);
			this.txtOperador.TabIndex = 10;
			this.txtOperador.Text = "OPERADOR";
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Reportado:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(173, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Calculado:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.Red;
			this.textBox1.Location = new System.Drawing.Point(280, 15);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(50, 21);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtRendimiento);
			this.groupBox1.Enabled = false;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(21, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(388, 45);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rendimiento";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Enabled = false;
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(415, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 45);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kilometraje recorrido";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(168, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "Calculado:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.Red;
			this.textBox2.Location = new System.Drawing.Point(275, 15);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(50, 21);
			this.textBox2.TabIndex = 13;
			this.textBox2.Text = "0";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Reportado:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.ForeColor = System.Drawing.Color.Red;
			this.textBox3.Location = new System.Drawing.Point(113, 15);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(50, 21);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "0";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormDatosDia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(885, 79);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtOperador);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.txtKm);
			this.Controls.Add(this.txtGasolinera);
			this.Controls.Add(this.txtHora);
			this.Controls.Add(this.txtLitros);
			this.Controls.Add(this.txtFecha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDatosDia";
			this.Text = "FormDatosDia";
			this.Load += new System.EventHandler(this.FormDatosDiaLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.TextBox txtRendimiento;
		private System.Windows.Forms.TextBox txtLitros;
		private System.Windows.Forms.TextBox txtHora;
		private System.Windows.Forms.TextBox txtGasolinera;
		private System.Windows.Forms.TextBox txtKm;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.TextBox txtFecha;
	}
}
