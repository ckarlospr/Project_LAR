/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 08/12/2015
 * Hora: 10:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormPagos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagos));
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.gbTipo = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.rbDeposito = new System.Windows.Forms.RadioButton();
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtComprobantePago = new System.Windows.Forms.TextBox();
			this.label77 = new System.Windows.Forms.Label();
			this.gbTipo.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtpFecha
			// 
			this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(19, 164);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(122, 21);
			this.dtpFecha.TabIndex = 5;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdGuardar.Location = new System.Drawing.Point(188, 152);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(77, 48);
			this.cmdGuardar.TabIndex = 14;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// gbTipo
			// 
			this.gbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gbTipo.Controls.Add(this.txtComprobantePago);
			this.gbTipo.Controls.Add(this.label77);
			this.gbTipo.Controls.Add(this.label1);
			this.gbTipo.Controls.Add(this.txtNumero);
			this.gbTipo.Controls.Add(this.rbDeposito);
			this.gbTipo.Controls.Add(this.rbEfectivo);
			this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTipo.Location = new System.Drawing.Point(4, 32);
			this.gbTipo.Name = "gbTipo";
			this.gbTipo.Size = new System.Drawing.Size(268, 114);
			this.gbTipo.TabIndex = 13;
			this.gbTipo.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Depositado a:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNumero
			// 
			this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumero.Location = new System.Drawing.Point(125, 51);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(124, 22);
			this.txtNumero.TabIndex = 2;
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rbDeposito
			// 
			this.rbDeposito.Checked = true;
			this.rbDeposito.Location = new System.Drawing.Point(145, 21);
			this.rbDeposito.Name = "rbDeposito";
			this.rbDeposito.Size = new System.Drawing.Size(104, 24);
			this.rbDeposito.TabIndex = 1;
			this.rbDeposito.TabStop = true;
			this.rbDeposito.Text = "DEPOSITO";
			this.rbDeposito.UseVisualStyleBackColor = true;
			this.rbDeposito.CheckedChanged += new System.EventHandler(this.RbDepositoCheckedChanged);
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.Location = new System.Drawing.Point(19, 21);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(104, 24);
			this.rbEfectivo.TabIndex = 0;
			this.rbEfectivo.Text = "EFECTIVO";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivoCheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Cantidad del Pago:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCantidad
			// 
			this.txtCantidad.BackColor = System.Drawing.Color.MediumTurquoise;
			this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(129, 4);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(123, 22);
			this.txtCantidad.TabIndex = 15;
			this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtComprobantePago
			// 
			this.txtComprobantePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComprobantePago.Location = new System.Drawing.Point(125, 79);
			this.txtComprobantePago.Name = "txtComprobantePago";
			this.txtComprobantePago.Size = new System.Drawing.Size(124, 22);
			this.txtComprobantePago.TabIndex = 181;
			// 
			// label77
			// 
			this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label77.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label77.Location = new System.Drawing.Point(19, 79);
			this.label77.Name = "label77";
			this.label77.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label77.Size = new System.Drawing.Size(86, 17);
			this.label77.TabIndex = 182;
			this.label77.Text = "Referencia:";
			this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormPagos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 204);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.gbTipo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPagos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pago";
			this.Load += new System.EventHandler(this.FormPagosLoad);
			this.gbTipo.ResumeLayout(false);
			this.gbTipo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label77;
		private System.Windows.Forms.TextBox txtComprobantePago;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbDeposito;
		private System.Windows.Forms.GroupBox gbTipo;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.RadioButton rbEfectivo;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label1;
	}
}
