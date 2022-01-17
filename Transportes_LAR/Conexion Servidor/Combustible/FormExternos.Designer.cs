/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 16/01/2015
 * Hora: 10:47 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormExternos
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
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.txtGasolinera = new System.Windows.Forms.TextBox();
			this.txtKms = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.dtpHora = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbTipoComb = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtUnidad
			// 
			this.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.ForeColor = System.Drawing.Color.Red;
			this.txtUnidad.Location = new System.Drawing.Point(315, 35);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(100, 26);
			this.txtUnidad.TabIndex = 2;
			this.txtUnidad.Text = "000";
			this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUnidad.Enter += new System.EventHandler(this.TxtUnidadEnter);
			this.txtUnidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUnidadKeyUp);
			this.txtUnidad.Leave += new System.EventHandler(this.TxtUnidadLeave);
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(139, 35);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(170, 26);
			this.txtOperador.TabIndex = 1;
			this.txtOperador.Text = "OPERADOR";
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.Enter += new System.EventHandler(this.TxtOperadorEnter);
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			this.txtOperador.Leave += new System.EventHandler(this.TxtOperadorLeave);
			// 
			// txtGasolinera
			// 
			this.txtGasolinera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtGasolinera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGasolinera.Location = new System.Drawing.Point(421, 35);
			this.txtGasolinera.Name = "txtGasolinera";
			this.txtGasolinera.Size = new System.Drawing.Size(230, 26);
			this.txtGasolinera.TabIndex = 3;
			this.txtGasolinera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGasolinera.Enter += new System.EventHandler(this.TxtGasolineraEnter);
			this.txtGasolinera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtGasolineraKeyUp);
			this.txtGasolinera.Leave += new System.EventHandler(this.TxtGasolineraLeave);
			// 
			// txtKms
			// 
			this.txtKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKms.Location = new System.Drawing.Point(462, 91);
			this.txtKms.Name = "txtKms";
			this.txtKms.Size = new System.Drawing.Size(72, 26);
			this.txtKms.TabIndex = 7;
			this.txtKms.Text = "0";
			this.txtKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKms.Enter += new System.EventHandler(this.TxtKmsEnter);
			this.txtKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKmsKeyPress);
			this.txtKms.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtKmsKeyUp);
			this.txtKms.Leave += new System.EventHandler(this.TxtKmsLeave);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(315, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Unidad";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(462, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 11);
			this.label2.TabIndex = 5;
			this.label2.Text = "Kms";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(421, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Gasolinera";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(139, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Operador";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Enabled = false;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(573, 68);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(78, 49);
			this.cmdGuardar.TabIndex = 8;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(21, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Folio";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtFolio
			// 
			this.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFolio.Enabled = false;
			this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(21, 35);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(112, 26);
			this.txtFolio.TabIndex = 0;
			this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtpHora
			// 
			this.dtpHora.CustomFormat = "HH:mm";
			this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHora.Location = new System.Drawing.Point(21, 91);
			this.dtpHora.Name = "dtpHora";
			this.dtpHora.Size = new System.Drawing.Size(69, 26);
			this.dtpHora.TabIndex = 4;
			this.dtpHora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtpHoraKeyUp);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(21, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 11);
			this.label6.TabIndex = 12;
			this.label6.Text = "Hora";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmbTipoComb
			// 
			this.cmbTipoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoComb.FormattingEnabled = true;
			this.cmbTipoComb.Location = new System.Drawing.Point(109, 92);
			this.cmbTipoComb.Name = "cmbTipoComb";
			this.cmbTipoComb.Size = new System.Drawing.Size(171, 24);
			this.cmbTipoComb.TabIndex = 5;
			this.cmbTipoComb.SelectedIndexChanged += new System.EventHandler(this.CmbTipoCombSelectedIndexChanged);
			this.cmbTipoComb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbTipoCombKeyUp);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(109, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 11);
			this.label7.TabIndex = 14;
			this.label7.Text = "Combustible";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(286, 77);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(170, 11);
			this.label8.TabIndex = 16;
			this.label8.Text = "Usuario";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(286, 91);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(170, 26);
			this.txtUsuario.TabIndex = 6;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuarioEnter);
			this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUsuarioKeyUp);
			this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuarioLeave);
			// 
			// FormExternos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 130);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbTipoComb);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtpHora);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFolio);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtKms);
			this.Controls.Add(this.txtGasolinera);
			this.Controls.Add(this.txtOperador);
			this.Controls.Add(this.txtUnidad);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormExternos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos externos";
			this.Load += new System.EventHandler(this.FormExternosLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbTipoComb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpHora;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKms;
		private System.Windows.Forms.TextBox txtGasolinera;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.TextBox txtUnidad;
	}
}
