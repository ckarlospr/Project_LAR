/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 11/12/2015
 * Hora: 9:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormCobroValidacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCobroValidacion));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbincobrable = new System.Windows.Forms.RadioButton();
			this.rbPagoAnt = new System.Windows.Forms.RadioButton();
			this.rbFactCobro = new System.Windows.Forms.RadioButton();
			this.rbDeposito = new System.Windows.Forms.RadioButton();
			this.rbCoordinador = new System.Windows.Forms.RadioButton();
			this.rbOperador = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCobro = new System.Windows.Forms.TextBox();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtFolio);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtComentario);
			this.groupBox2.Controls.Add(this.txtSaldo);
			this.groupBox2.Controls.Add(this.lblSaldo);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(230, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(286, 133);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			// 
			// txtFolio
			// 
			this.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFolio.Enabled = false;
			this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(55, 105);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(102, 22);
			this.txtFolio.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 15);
			this.label4.TabIndex = 17;
			this.label4.Text = "Folio:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Enabled = false;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(7, 60);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(271, 41);
			this.txtComentario.TabIndex = 14;
			this.txtComentario.TextChanged += new System.EventHandler(this.TxtComentarioTextChanged);
			// 
			// txtSaldo
			// 
			this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaldo.Location = new System.Drawing.Point(127, 11);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(151, 22);
			this.txtSaldo.TabIndex = 8;
			this.txtSaldo.TextChanged += new System.EventHandler(this.TxtSaldoTextChanged);
			// 
			// lblSaldo
			// 
			this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaldo.Location = new System.Drawing.Point(1, 14);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(128, 15);
			this.lblSaldo.TabIndex = 9;
			this.lblSaldo.Text = "Precio Servicio:";
			this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(249, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "Comentario por Cambio de Precio:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(225, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Teléfono:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTelefono
			// 
			this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(314, 38);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(146, 22);
			this.txtTelefono.TabIndex = 17;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbincobrable);
			this.groupBox1.Controls.Add(this.rbPagoAnt);
			this.groupBox1.Controls.Add(this.rbFactCobro);
			this.groupBox1.Controls.Add(this.rbDeposito);
			this.groupBox1.Controls.Add(this.rbCoordinador);
			this.groupBox1.Controls.Add(this.rbOperador);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(218, 214);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo:";
			// 
			// rbincobrable
			// 
			this.rbincobrable.Location = new System.Drawing.Point(13, 177);
			this.rbincobrable.Name = "rbincobrable";
			this.rbincobrable.Size = new System.Drawing.Size(199, 24);
			this.rbincobrable.TabIndex = 5;
			this.rbincobrable.Text = "Incobrable";
			this.rbincobrable.UseVisualStyleBackColor = true;
			this.rbincobrable.CheckedChanged += new System.EventHandler(this.RbincobrableCheckedChanged);
			// 
			// rbPagoAnt
			// 
			this.rbPagoAnt.Location = new System.Drawing.Point(13, 146);
			this.rbPagoAnt.Name = "rbPagoAnt";
			this.rbPagoAnt.Size = new System.Drawing.Size(199, 24);
			this.rbPagoAnt.TabIndex = 4;
			this.rbPagoAnt.Text = "Pago anticipado";
			this.rbPagoAnt.UseVisualStyleBackColor = true;
			this.rbPagoAnt.CheckedChanged += new System.EventHandler(this.RbPagoAntCheckedChanged);
			// 
			// rbFactCobro
			// 
			this.rbFactCobro.Location = new System.Drawing.Point(13, 114);
			this.rbFactCobro.Name = "rbFactCobro";
			this.rbFactCobro.Size = new System.Drawing.Size(199, 24);
			this.rbFactCobro.TabIndex = 3;
			this.rbFactCobro.Text = "Factura a cobro";
			this.rbFactCobro.UseVisualStyleBackColor = true;
			this.rbFactCobro.CheckedChanged += new System.EventHandler(this.RbFactCobroCheckedChanged);
			// 
			// rbDeposito
			// 
			this.rbDeposito.Location = new System.Drawing.Point(13, 81);
			this.rbDeposito.Name = "rbDeposito";
			this.rbDeposito.Size = new System.Drawing.Size(199, 24);
			this.rbDeposito.TabIndex = 2;
			this.rbDeposito.Text = "Deposito o transferencia";
			this.rbDeposito.UseVisualStyleBackColor = true;
			this.rbDeposito.CheckedChanged += new System.EventHandler(this.RbDepositoCheckedChanged);
			// 
			// rbCoordinador
			// 
			this.rbCoordinador.Location = new System.Drawing.Point(14, 49);
			this.rbCoordinador.Name = "rbCoordinador";
			this.rbCoordinador.Size = new System.Drawing.Size(199, 24);
			this.rbCoordinador.TabIndex = 1;
			this.rbCoordinador.Text = "Coordinador";
			this.rbCoordinador.UseVisualStyleBackColor = true;
			this.rbCoordinador.CheckedChanged += new System.EventHandler(this.RbCoordinadorCheckedChanged);
			// 
			// rbOperador
			// 
			this.rbOperador.Checked = true;
			this.rbOperador.Location = new System.Drawing.Point(14, 19);
			this.rbOperador.Name = "rbOperador";
			this.rbOperador.Size = new System.Drawing.Size(199, 24);
			this.rbOperador.TabIndex = 0;
			this.rbOperador.TabStop = true;
			this.rbOperador.Text = "Operador";
			this.rbOperador.UseVisualStyleBackColor = true;
			this.rbOperador.CheckedChanged += new System.EventHandler(this.RbOperadorCheckedChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(230, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Cobró:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCobro
			// 
			this.txtCobro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCobro.Location = new System.Drawing.Point(314, 12);
			this.txtCobro.Name = "txtCobro";
			this.txtCobro.Size = new System.Drawing.Size(146, 22);
			this.txtCobro.TabIndex = 12;
			this.txtCobro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCobroKeyUp);
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAceptar.Image")));
			this.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAceptar.Location = new System.Drawing.Point(418, 182);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(92, 39);
			this.cmdAceptar.TabIndex = 11;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// FormCobroValidacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 223);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCobro);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCobroValidacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cobro Validación";
			this.Load += new System.EventHandler(this.FormCobroValidacionLoad);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.RadioButton rbincobrable;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.TextBox txtCobro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbOperador;
		private System.Windows.Forms.RadioButton rbCoordinador;
		private System.Windows.Forms.RadioButton rbDeposito;
		private System.Windows.Forms.RadioButton rbFactCobro;
		private System.Windows.Forms.RadioButton rbPagoAnt;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.Label lblSaldo;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
