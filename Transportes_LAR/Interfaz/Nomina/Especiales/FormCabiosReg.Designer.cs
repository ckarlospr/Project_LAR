/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 05/09/2013
 * Time: 11:41 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormCabiosReg
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
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRecibido = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtUbica = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.rbDeposito = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.txtTotal_R = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTotal_p = new System.Windows.Forms.TextBox();
			this.tcCambios = new System.Windows.Forms.TabControl();
			this.tpAbonos = new System.Windows.Forms.TabPage();
			this.cmdGuardaAbono = new System.Windows.Forms.Button();
			this.tpPrecio = new System.Windows.Forms.TabPage();
			this.txtNuevoComent = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.tcCambios.SuspendLayout();
			this.tpAbonos.SuspendLayout();
			this.tpPrecio.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Destino:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDestino
			// 
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(77, 11);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(250, 20);
			this.txtDestino.TabIndex = 1;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSaldo
			// 
			this.txtSaldo.Enabled = false;
			this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaldo.Location = new System.Drawing.Point(78, 37);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(88, 20);
			this.txtSaldo.TabIndex = 2;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Precio:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRecibido
			// 
			this.txtRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecibido.Location = new System.Drawing.Point(6, 67);
			this.txtRecibido.Name = "txtRecibido";
			this.txtRecibido.Size = new System.Drawing.Size(100, 20);
			this.txtRecibido.TabIndex = 4;
			this.txtRecibido.Text = "0.00";
			this.txtRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecibidoKeyPress);
			this.txtRecibido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtRecibidoKeyUp);
			this.txtRecibido.Leave += new System.EventHandler(this.TxtRecibidoLeave);
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(6, 160);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(325, 57);
			this.txtComentario.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Comentario:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(219, 13);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 32);
			this.cmdGuardar.TabIndex = 8;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtUbica);
			this.groupBox1.Controls.Add(this.dtpFecha);
			this.groupBox1.Controls.Add(this.rbDeposito);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.rbEfectivo);
			this.groupBox1.Controls.Add(this.txtTotal_R);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtRecibido);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(325, 129);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recibido";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(155, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Nombre a quien depositó:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUbica
			// 
			this.txtUbica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUbica.Enabled = false;
			this.txtUbica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUbica.Location = new System.Drawing.Point(171, 93);
			this.txtUbica.Name = "txtUbica";
			this.txtUbica.Size = new System.Drawing.Size(145, 24);
			this.txtUbica.TabIndex = 15;
			this.txtUbica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(224, 67);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(92, 20);
			this.dtpFecha.TabIndex = 14;
			// 
			// rbDeposito
			// 
			this.rbDeposito.Location = new System.Drawing.Point(167, 19);
			this.rbDeposito.Name = "rbDeposito";
			this.rbDeposito.Size = new System.Drawing.Size(104, 19);
			this.rbDeposito.TabIndex = 13;
			this.rbDeposito.Text = "DEPOSITO";
			this.rbDeposito.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(110, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "TOTAL";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.Checked = true;
			this.rbEfectivo.Location = new System.Drawing.Point(67, 19);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(104, 19);
			this.rbEfectivo.TabIndex = 12;
			this.rbEfectivo.TabStop = true;
			this.rbEfectivo.Text = "EFECTIVO";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivoCheckedChanged);
			// 
			// txtTotal_R
			// 
			this.txtTotal_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal_R.Location = new System.Drawing.Point(110, 67);
			this.txtTotal_R.Name = "txtTotal_R";
			this.txtTotal_R.Size = new System.Drawing.Size(100, 20);
			this.txtTotal_R.TabIndex = 11;
			this.txtTotal_R.Text = "0.00";
			this.txtTotal_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTotal_R.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotal_RKeyPress);
			this.txtTotal_R.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTotal_RKeyUp);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "C/U";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(170, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Total:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTotal_p
			// 
			this.txtTotal_p.Enabled = false;
			this.txtTotal_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal_p.Location = new System.Drawing.Point(220, 36);
			this.txtTotal_p.Name = "txtTotal_p";
			this.txtTotal_p.Size = new System.Drawing.Size(107, 20);
			this.txtTotal_p.TabIndex = 10;
			this.txtTotal_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tcCambios
			// 
			this.tcCambios.Controls.Add(this.tpAbonos);
			this.tcCambios.Controls.Add(this.tpPrecio);
			this.tcCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcCambios.Location = new System.Drawing.Point(12, 72);
			this.tcCambios.Name = "tcCambios";
			this.tcCambios.SelectedIndex = 0;
			this.tcCambios.Size = new System.Drawing.Size(347, 286);
			this.tcCambios.TabIndex = 12;
			// 
			// tpAbonos
			// 
			this.tpAbonos.Controls.Add(this.cmdGuardaAbono);
			this.tpAbonos.Controls.Add(this.groupBox1);
			this.tpAbonos.Controls.Add(this.txtComentario);
			this.tpAbonos.Controls.Add(this.label4);
			this.tpAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpAbonos.Location = new System.Drawing.Point(4, 24);
			this.tpAbonos.Name = "tpAbonos";
			this.tpAbonos.Padding = new System.Windows.Forms.Padding(3);
			this.tpAbonos.Size = new System.Drawing.Size(339, 258);
			this.tpAbonos.TabIndex = 0;
			this.tpAbonos.Text = "Abonos";
			this.tpAbonos.UseVisualStyleBackColor = true;
			// 
			// cmdGuardaAbono
			// 
			this.cmdGuardaAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardaAbono.Location = new System.Drawing.Point(258, 222);
			this.cmdGuardaAbono.Name = "cmdGuardaAbono";
			this.cmdGuardaAbono.Size = new System.Drawing.Size(75, 32);
			this.cmdGuardaAbono.TabIndex = 9;
			this.cmdGuardaAbono.Text = "Guardar";
			this.cmdGuardaAbono.UseVisualStyleBackColor = true;
			this.cmdGuardaAbono.Click += new System.EventHandler(this.CmdGuardaAbonoClick);
			// 
			// tpPrecio
			// 
			this.tpPrecio.Controls.Add(this.txtNuevoComent);
			this.tpPrecio.Controls.Add(this.label9);
			this.tpPrecio.Controls.Add(this.label8);
			this.tpPrecio.Controls.Add(this.cmdGuardar);
			this.tpPrecio.Controls.Add(this.txtNuevoPrecio);
			this.tpPrecio.Location = new System.Drawing.Point(4, 24);
			this.tpPrecio.Name = "tpPrecio";
			this.tpPrecio.Padding = new System.Windows.Forms.Padding(3);
			this.tpPrecio.Size = new System.Drawing.Size(339, 258);
			this.tpPrecio.TabIndex = 1;
			this.tpPrecio.Text = "Precio";
			this.tpPrecio.UseVisualStyleBackColor = true;
			// 
			// txtNuevoComent
			// 
			this.txtNuevoComent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNuevoComent.Location = new System.Drawing.Point(6, 62);
			this.txtNuevoComent.Multiline = true;
			this.txtNuevoComent.Name = "txtNuevoComent";
			this.txtNuevoComent.Size = new System.Drawing.Size(325, 57);
			this.txtNuevoComent.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 41);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 18);
			this.label9.TabIndex = 16;
			this.label9.Text = "Comentario:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(24, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Nuevo precio:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNuevoPrecio
			// 
			this.txtNuevoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNuevoPrecio.Location = new System.Drawing.Point(125, 21);
			this.txtNuevoPrecio.Name = "txtNuevoPrecio";
			this.txtNuevoPrecio.Size = new System.Drawing.Size(88, 20);
			this.txtNuevoPrecio.TabIndex = 13;
			this.txtNuevoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormCabiosReg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 365);
			this.Controls.Add(this.tcCambios);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtTotal_p);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCabiosReg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambios";
			this.Load += new System.EventHandler(this.FormCabiosRegLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tcCambios.ResumeLayout(false);
			this.tpAbonos.ResumeLayout(false);
			this.tpAbonos.PerformLayout();
			this.tpPrecio.ResumeLayout(false);
			this.tpPrecio.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNuevoComent;
		private System.Windows.Forms.TextBox txtNuevoPrecio;
		private System.Windows.Forms.Button cmdGuardaAbono;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tpPrecio;
		private System.Windows.Forms.TabPage tpAbonos;
		private System.Windows.Forms.TabControl tcCambios;
		private System.Windows.Forms.TextBox txtUbica;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.RadioButton rbEfectivo;
		private System.Windows.Forms.RadioButton rbDeposito;
		private System.Windows.Forms.TextBox txtTotal_R;
		private System.Windows.Forms.TextBox txtTotal_p;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.TextBox txtRecibido;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.Label label1;
	}
}
