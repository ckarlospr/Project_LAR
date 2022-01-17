/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 12/12/2015
 * Hora: 10:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormModificaAnticipo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificaAnticipo));
			this.label6 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label43 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtcantidad = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtubica = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(307, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Comentario:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// txtNumero
			// 
			this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumero.Location = new System.Drawing.Point(108, 36);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(141, 20);
			this.txtNumero.TabIndex = 3;
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnModificar
			// 
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.Location = new System.Drawing.Point(182, 122);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(91, 41);
			this.btnModificar.TabIndex = 7;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Location = new System.Drawing.Point(259, 62);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(188, 47);
			this.txtComentario.TabIndex = 6;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(108, 10);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(141, 20);
			this.dtpFecha.TabIndex = 1;
			// 
			// label43
			// 
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label43.Location = new System.Drawing.Point(12, 13);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(90, 15);
			this.label43.TabIndex = 81;
			this.label43.Text = "Fecha:";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 15);
			this.label1.TabIndex = 82;
			this.label1.Text = "Comprobante:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(41, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 15);
			this.label2.TabIndex = 83;
			this.label2.Text = "Tipo:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"EFECTIVO",
									"DEPOSITO"});
			this.cmbTipo.Location = new System.Drawing.Point(108, 62);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(141, 21);
			this.cmbTipo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 15);
			this.label3.TabIndex = 86;
			this.label3.Text = "Cantidad:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtcantidad
			// 
			this.txtcantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtcantidad.Location = new System.Drawing.Point(108, 89);
			this.txtcantidad.Name = "txtcantidad";
			this.txtcantidad.Size = new System.Drawing.Size(141, 20);
			this.txtcantidad.TabIndex = 5;
			this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(255, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 15);
			this.label4.TabIndex = 87;
			this.label4.Text = "Ubica:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtubica
			// 
			this.txtubica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtubica.Location = new System.Drawing.Point(304, 13);
			this.txtubica.Name = "txtubica";
			this.txtubica.Size = new System.Drawing.Size(141, 20);
			this.txtubica.TabIndex = 2;
			this.txtubica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormModificaAnticipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 175);
			this.Controls.Add(this.txtubica);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtcantidad);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label43);
			this.Controls.Add(this.dtpFecha);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormModificaAnticipo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modifica Anticipo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModificaAnticipoFormClosing);
			this.Load += new System.EventHandler(this.FormModificaAnticipoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtubica;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtcantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label6;
	}
}
