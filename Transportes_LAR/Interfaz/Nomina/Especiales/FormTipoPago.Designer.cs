/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 20/06/2013
 * Time: 09:56 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormTipoPago
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoPago));
			this.label1 = new System.Windows.Forms.Label();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.txtRecuperado = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.txtCantDeposito = new System.Windows.Forms.TextBox();
			this.txtCanEfect = new System.Windows.Forms.TextBox();
			this.cbComentario = new System.Windows.Forms.CheckBox();
			this.cbDeposito = new System.Windows.Forms.CheckBox();
			this.cbEfectivo = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Destino:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDestino
			// 
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(93, 9);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(288, 22);
			this.txtDestino.TabIndex = 1;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtImporte
			// 
			this.txtImporte.Enabled = false;
			this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporte.Location = new System.Drawing.Point(12, 69);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(171, 22);
			this.txtImporte.TabIndex = 2;
			this.txtImporte.Text = "0";
			this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRecuperado
			// 
			this.txtRecuperado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecuperado.Location = new System.Drawing.Point(210, 69);
			this.txtRecuperado.Name = "txtRecuperado";
			this.txtRecuperado.Size = new System.Drawing.Size(171, 22);
			this.txtRecuperado.TabIndex = 3;
			this.txtRecuperado.Text = "0";
			this.txtRecuperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRecuperado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtRecuperadoKeyUp);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtComentario);
			this.groupBox1.Controls.Add(this.txtCantDeposito);
			this.groupBox1.Controls.Add(this.txtCanEfect);
			this.groupBox1.Controls.Add(this.cbComentario);
			this.groupBox1.Controls.Add(this.cbDeposito);
			this.groupBox1.Controls.Add(this.cbEfectivo);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 97);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(369, 96);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Forma de pago";
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Enabled = false;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(52, 59);
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(282, 22);
			this.txtComentario.TabIndex = 7;
			this.txtComentario.Text = "COMENTARIO";
			this.txtComentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCantDeposito
			// 
			this.txtCantDeposito.Enabled = false;
			this.txtCantDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantDeposito.Location = new System.Drawing.Point(265, 28);
			this.txtCantDeposito.Name = "txtCantDeposito";
			this.txtCantDeposito.Size = new System.Drawing.Size(69, 22);
			this.txtCantDeposito.TabIndex = 6;
			this.txtCantDeposito.Text = "0";
			this.txtCantDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantDeposito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCantDepositoKeyUp);
			// 
			// txtCanEfect
			// 
			this.txtCanEfect.Enabled = false;
			this.txtCanEfect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCanEfect.Location = new System.Drawing.Point(102, 28);
			this.txtCanEfect.Name = "txtCanEfect";
			this.txtCanEfect.Size = new System.Drawing.Size(69, 22);
			this.txtCanEfect.TabIndex = 5;
			this.txtCanEfect.Text = "0";
			this.txtCanEfect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCanEfect.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCanEfectKeyUp);
			// 
			// cbComentario
			// 
			this.cbComentario.Location = new System.Drawing.Point(27, 58);
			this.cbComentario.Name = "cbComentario";
			this.cbComentario.Size = new System.Drawing.Size(19, 24);
			this.cbComentario.TabIndex = 2;
			this.cbComentario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbComentario.UseVisualStyleBackColor = true;
			this.cbComentario.CheckedChanged += new System.EventHandler(this.CbComentarioCheckedChanged);
			// 
			// cbDeposito
			// 
			this.cbDeposito.Location = new System.Drawing.Point(190, 28);
			this.cbDeposito.Name = "cbDeposito";
			this.cbDeposito.Size = new System.Drawing.Size(80, 24);
			this.cbDeposito.TabIndex = 1;
			this.cbDeposito.Text = "Deposito";
			this.cbDeposito.UseVisualStyleBackColor = true;
			this.cbDeposito.CheckedChanged += new System.EventHandler(this.CbDepositoCheckedChanged);
			// 
			// cbEfectivo
			// 
			this.cbEfectivo.Location = new System.Drawing.Point(27, 28);
			this.cbEfectivo.Name = "cbEfectivo";
			this.cbEfectivo.Size = new System.Drawing.Size(78, 24);
			this.cbEfectivo.TabIndex = 0;
			this.cbEfectivo.Text = "Efectivo";
			this.cbEfectivo.UseVisualStyleBackColor = true;
			this.cbEfectivo.CheckedChanged += new System.EventHandler(this.CbEfectivoCheckedChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Importe";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(207, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Monto recuperado";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.Image")));
			this.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAceptar.Location = new System.Drawing.Point(301, 205);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(78, 23);
			this.cmdAceptar.TabIndex = 7;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// FormTipoPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 240);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtRecuperado);
			this.Controls.Add(this.txtImporte);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(411, 278);
			this.Name = "FormTipoPago";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Incobrable";
			this.Load += new System.EventHandler(this.FormTipoPagoLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbEfectivo;
		private System.Windows.Forms.CheckBox cbDeposito;
		private System.Windows.Forms.CheckBox cbComentario;
		private System.Windows.Forms.TextBox txtCanEfect;
		private System.Windows.Forms.TextBox txtCantDeposito;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtRecuperado;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.Label label1;
	}
}
