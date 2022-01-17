/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 28/01/2016
 * Hora: 10:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormIncobrable
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncobrable));
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCantDeposito = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCanEfect = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.txtRecuperado = new System.Windows.Forms.TextBox();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtmontoPerdido = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.Image")));
			this.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAceptar.Location = new System.Drawing.Point(278, 216);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(96, 53);
			this.cmdAceptar.TabIndex = 15;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(138, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Monto recuperado";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Saldo a cobrar";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCantDeposito);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtCanEfect);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(28, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(338, 64);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Forma de pago del monto Recuperado";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Efectivo";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCantDeposito
			// 
			this.txtCantDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantDeposito.Location = new System.Drawing.Point(255, 27);
			this.txtCantDeposito.Name = "txtCantDeposito";
			this.txtCantDeposito.Size = new System.Drawing.Size(69, 22);
			this.txtCantDeposito.TabIndex = 6;
			this.txtCantDeposito.Text = "0";
			this.txtCantDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCantDeposito.TextChanged += new System.EventHandler(this.TxtCantDepositoTextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(174, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Deposito";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCanEfect
			// 
			this.txtCanEfect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCanEfect.Location = new System.Drawing.Point(86, 27);
			this.txtCanEfect.Name = "txtCanEfect";
			this.txtCanEfect.Size = new System.Drawing.Size(69, 22);
			this.txtCanEfect.TabIndex = 5;
			this.txtCanEfect.Text = "0";
			this.txtCanEfect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCanEfect.TextChanged += new System.EventHandler(this.TxtCanEfectTextChanged);
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(9, 209);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(247, 67);
			this.txtComentario.TabIndex = 7;
			this.txtComentario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRecuperado
			// 
			this.txtRecuperado.Enabled = false;
			this.txtRecuperado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecuperado.Location = new System.Drawing.Point(142, 74);
			this.txtRecuperado.Name = "txtRecuperado";
			this.txtRecuperado.Size = new System.Drawing.Size(131, 22);
			this.txtRecuperado.TabIndex = 11;
			this.txtRecuperado.Text = "0";
			this.txtRecuperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtImporte
			// 
			this.txtImporte.BackColor = System.Drawing.Color.LightBlue;
			this.txtImporte.Enabled = false;
			this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporte.Location = new System.Drawing.Point(9, 74);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(126, 22);
			this.txtImporte.TabIndex = 10;
			this.txtImporte.Text = "0";
			this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(93, 11);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(283, 22);
			this.txtDestino.TabIndex = 9;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Destino:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(71, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "Comentario";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(274, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 23);
			this.label7.TabIndex = 20;
			this.label7.Text = "Monto Perdido";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtmontoPerdido
			// 
			this.txtmontoPerdido.Enabled = false;
			this.txtmontoPerdido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtmontoPerdido.Location = new System.Drawing.Point(279, 74);
			this.txtmontoPerdido.Name = "txtmontoPerdido";
			this.txtmontoPerdido.Size = new System.Drawing.Size(95, 22);
			this.txtmontoPerdido.TabIndex = 19;
			this.txtmontoPerdido.Text = "0";
			this.txtmontoPerdido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormIncobrable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 281);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtmontoPerdido);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.txtImporte);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtRecuperado);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(409, 320);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(409, 320);
			this.Name = "FormIncobrable";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Incobrable";
			this.Load += new System.EventHandler(this.FormIncobrableLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtmontoPerdido;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.TextBox txtRecuperado;
		private System.Windows.Forms.TextBox txtCanEfect;
		private System.Windows.Forms.TextBox txtCantDeposito;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmdAceptar;
	}
}
