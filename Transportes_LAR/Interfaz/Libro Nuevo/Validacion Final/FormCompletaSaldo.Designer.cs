/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 30/01/2016
 * Hora: 11:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Validacion_Final
{
	partial class FormCompletaSaldo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompletaSaldo));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUbica = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cbAbono = new System.Windows.Forms.CheckBox();
			this.rbDeposito = new System.Windows.Forms.RadioButton();
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.lblRecuperdao = new System.Windows.Forms.Label();
			this.txtRecuperado = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.lblFaltante = new System.Windows.Forms.Label();
			this.txtFaltante = new System.Windows.Forms.TextBox();
			this.cmdGuarda = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtUbica);
			this.groupBox1.Controls.Add(this.dtpFecha);
			this.groupBox1.Controls.Add(this.cbAbono);
			this.groupBox1.Controls.Add(this.rbDeposito);
			this.groupBox1.Controls.Add(this.rbEfectivo);
			this.groupBox1.Controls.Add(this.lblRecuperdao);
			this.groupBox1.Controls.Add(this.txtRecuperado);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(10, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(286, 138);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Nombre a quien depositó:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUbica
			// 
			this.txtUbica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUbica.Enabled = false;
			this.txtUbica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUbica.Location = new System.Drawing.Point(167, 104);
			this.txtUbica.Name = "txtUbica";
			this.txtUbica.Size = new System.Drawing.Size(101, 24);
			this.txtUbica.TabIndex = 13;
			this.txtUbica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(158, 21);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(110, 21);
			this.dtpFecha.TabIndex = 12;
			// 
			// cbAbono
			// 
			this.cbAbono.Location = new System.Drawing.Point(14, 21);
			this.cbAbono.Name = "cbAbono";
			this.cbAbono.Size = new System.Drawing.Size(70, 24);
			this.cbAbono.TabIndex = 11;
			this.cbAbono.Text = "Abono";
			this.cbAbono.UseVisualStyleBackColor = true;
			this.cbAbono.CheckedChanged += new System.EventHandler(this.CbAbonoCheckedChanged);
			// 
			// rbDeposito
			// 
			this.rbDeposito.Location = new System.Drawing.Point(14, 75);
			this.rbDeposito.Name = "rbDeposito";
			this.rbDeposito.Size = new System.Drawing.Size(104, 19);
			this.rbDeposito.TabIndex = 10;
			this.rbDeposito.Text = "DEPOSITO";
			this.rbDeposito.UseVisualStyleBackColor = true;
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.Checked = true;
			this.rbEfectivo.Location = new System.Drawing.Point(14, 48);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(104, 19);
			this.rbEfectivo.TabIndex = 9;
			this.rbEfectivo.TabStop = true;
			this.rbEfectivo.Text = "EFECTIVO";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivoCheckedChanged);
			// 
			// lblRecuperdao
			// 
			this.lblRecuperdao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecuperdao.Location = new System.Drawing.Point(158, 48);
			this.lblRecuperdao.Name = "lblRecuperdao";
			this.lblRecuperdao.Size = new System.Drawing.Size(110, 23);
			this.lblRecuperdao.TabIndex = 8;
			this.lblRecuperdao.Text = "Recuperado";
			this.lblRecuperdao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtRecuperado
			// 
			this.txtRecuperado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRecuperado.Enabled = false;
			this.txtRecuperado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRecuperado.Location = new System.Drawing.Point(158, 73);
			this.txtRecuperado.Name = "txtRecuperado";
			this.txtRecuperado.Size = new System.Drawing.Size(110, 24);
			this.txtRecuperado.TabIndex = 7;
			this.txtRecuperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtRecuperado.Click += new System.EventHandler(this.TxtRecuperadoClick);
			this.txtRecuperado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecuperadoKeyPress);
			// 
			// txtComentario
			// 
			this.txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentario.Location = new System.Drawing.Point(12, 193);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(180, 82);
			this.txtComentario.TabIndex = 15;
			this.txtComentario.Text = "COMENTARIO...";
			this.txtComentario.Click += new System.EventHandler(this.TxtComentarioClick);
			// 
			// lblFaltante
			// 
			this.lblFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFaltante.Location = new System.Drawing.Point(114, -2);
			this.lblFaltante.Name = "lblFaltante";
			this.lblFaltante.Size = new System.Drawing.Size(78, 23);
			this.lblFaltante.TabIndex = 14;
			this.lblFaltante.Text = "Faltante";
			this.lblFaltante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtFaltante
			// 
			this.txtFaltante.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtFaltante.Enabled = false;
			this.txtFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFaltante.Location = new System.Drawing.Point(94, 24);
			this.txtFaltante.Name = "txtFaltante";
			this.txtFaltante.Size = new System.Drawing.Size(112, 24);
			this.txtFaltante.TabIndex = 13;
			this.txtFaltante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdGuarda
			// 
			this.cmdGuarda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuarda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuarda.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuarda.Image")));
			this.cmdGuarda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdGuarda.Location = new System.Drawing.Point(211, 207);
			this.cmdGuarda.Name = "cmdGuarda";
			this.cmdGuarda.Size = new System.Drawing.Size(75, 54);
			this.cmdGuarda.TabIndex = 12;
			this.cmdGuarda.Text = "Guardar";
			this.cmdGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdGuarda.UseVisualStyleBackColor = true;
			this.cmdGuarda.Click += new System.EventHandler(this.CmdGuardaClick);
			// 
			// FormCompletaSaldo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 283);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.lblFaltante);
			this.Controls.Add(this.txtFaltante);
			this.Controls.Add(this.cmdGuarda);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(319, 322);
			this.MinimumSize = new System.Drawing.Size(319, 322);
			this.Name = "FormCompletaSaldo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Completa";
			this.Load += new System.EventHandler(this.FormCompletaSaldoLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdGuarda;
		private System.Windows.Forms.TextBox txtFaltante;
		private System.Windows.Forms.Label lblFaltante;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.TextBox txtRecuperado;
		private System.Windows.Forms.Label lblRecuperdao;
		private System.Windows.Forms.RadioButton rbEfectivo;
		private System.Windows.Forms.RadioButton rbDeposito;
		private System.Windows.Forms.CheckBox cbAbono;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtUbica;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
