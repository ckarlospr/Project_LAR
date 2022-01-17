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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExternos));
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
			this.txtPlacaNueva = new System.Windows.Forms.TextBox();
			this.cbPlacaMal = new System.Windows.Forms.CheckBox();
			this.txtPlacaF = new System.Windows.Forms.TextBox();
			this.txtPlacaE = new System.Windows.Forms.TextBox();
			this.label74 = new System.Windows.Forms.Label();
			this.label73 = new System.Windows.Forms.Label();
			this.label72 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtUnidad
			// 
			this.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.ForeColor = System.Drawing.Color.Red;
			this.txtUnidad.Location = new System.Drawing.Point(295, 26);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(81, 26);
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
			this.txtOperador.Location = new System.Drawing.Point(121, 26);
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
			this.txtGasolinera.Location = new System.Drawing.Point(380, 26);
			this.txtGasolinera.Name = "txtGasolinera";
			this.txtGasolinera.Size = new System.Drawing.Size(181, 26);
			this.txtGasolinera.TabIndex = 3;
			this.txtGasolinera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGasolinera.Enter += new System.EventHandler(this.TxtGasolineraEnter);
			this.txtGasolinera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtGasolineraKeyUp);
			this.txtGasolinera.Leave += new System.EventHandler(this.TxtGasolineraLeave);
			// 
			// txtKms
			// 
			this.txtKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKms.Location = new System.Drawing.Point(337, 76);
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
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Unidad";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(357, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Kms";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(446, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Gasolinera";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(174, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Operador";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Enabled = false;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(651, 45);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(78, 49);
			this.cmdGuardar.TabIndex = 12;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(42, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Folio";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtFolio
			// 
			this.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFolio.Enabled = false;
			this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(5, 26);
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
			this.dtpHora.Location = new System.Drawing.Point(566, 26);
			this.dtpHora.Name = "dtpHora";
			this.dtpHora.Size = new System.Drawing.Size(69, 26);
			this.dtpHora.TabIndex = 4;
			this.dtpHora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtpHoraKeyUp);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(582, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Hora";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmbTipoComb
			// 
			this.cmbTipoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoComb.FormattingEnabled = true;
			this.cmbTipoComb.Location = new System.Drawing.Point(6, 78);
			this.cmbTipoComb.Name = "cmbTipoComb";
			this.cmbTipoComb.Size = new System.Drawing.Size(171, 24);
			this.cmbTipoComb.TabIndex = 5;
			this.cmbTipoComb.SelectedIndexChanged += new System.EventHandler(this.CmbTipoCombSelectedIndexChanged);
			this.cmbTipoComb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbTipoCombKeyUp);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(59, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Combustible";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(235, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Usuario";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(181, 76);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(149, 26);
			this.txtUsuario.TabIndex = 6;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuarioEnter);
			this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUsuarioKeyUp);
			this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuarioLeave);
			// 
			// txtPlacaNueva
			// 
			this.txtPlacaNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPlacaNueva.Enabled = false;
			this.txtPlacaNueva.Location = new System.Drawing.Point(442, 103);
			this.txtPlacaNueva.Name = "txtPlacaNueva";
			this.txtPlacaNueva.Size = new System.Drawing.Size(194, 20);
			this.txtPlacaNueva.TabIndex = 11;
			// 
			// cbPlacaMal
			// 
			this.cbPlacaMal.AutoSize = true;
			this.cbPlacaMal.Location = new System.Drawing.Point(423, 107);
			this.cbPlacaMal.Name = "cbPlacaMal";
			this.cbPlacaMal.Size = new System.Drawing.Size(15, 14);
			this.cbPlacaMal.TabIndex = 10;
			this.cbPlacaMal.UseVisualStyleBackColor = true;
			this.cbPlacaMal.CheckedChanged += new System.EventHandler(this.CbPlacaMalCheckedChanged);
			// 
			// txtPlacaF
			// 
			this.txtPlacaF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPlacaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlacaF.Location = new System.Drawing.Point(548, 76);
			this.txtPlacaF.Name = "txtPlacaF";
			this.txtPlacaF.ReadOnly = true;
			this.txtPlacaF.Size = new System.Drawing.Size(87, 22);
			this.txtPlacaF.TabIndex = 9;
			this.txtPlacaF.Text = "0";
			this.txtPlacaF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPlacaF.Click += new System.EventHandler(this.TxtPlacaFClick);
			// 
			// txtPlacaE
			// 
			this.txtPlacaE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPlacaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlacaE.Location = new System.Drawing.Point(442, 76);
			this.txtPlacaE.Name = "txtPlacaE";
			this.txtPlacaE.ReadOnly = true;
			this.txtPlacaE.Size = new System.Drawing.Size(87, 22);
			this.txtPlacaE.TabIndex = 8;
			this.txtPlacaE.Text = "0";
			this.txtPlacaE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPlacaE.Click += new System.EventHandler(this.TxtPlacaEClick);
			// 
			// label74
			// 
			this.label74.AutoSize = true;
			this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label74.Location = new System.Drawing.Point(533, 79);
			this.label74.Name = "label74";
			this.label74.Size = new System.Drawing.Size(15, 15);
			this.label74.TabIndex = 131;
			this.label74.Text = "F";
			this.label74.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label73
			// 
			this.label73.AutoSize = true;
			this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label73.Location = new System.Drawing.Point(423, 79);
			this.label73.Name = "label73";
			this.label73.Size = new System.Drawing.Size(16, 15);
			this.label73.TabIndex = 130;
			this.label73.Text = "E";
			this.label73.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label72
			// 
			this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label72.Location = new System.Drawing.Point(427, 59);
			this.label72.Name = "label72";
			this.label72.Size = new System.Drawing.Size(208, 15);
			this.label72.TabIndex = 129;
			this.label72.Text = "Placas";
			this.label72.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// FormExternos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 130);
			this.Controls.Add(this.txtPlacaNueva);
			this.Controls.Add(this.cbPlacaMal);
			this.Controls.Add(this.txtPlacaF);
			this.Controls.Add(this.txtPlacaE);
			this.Controls.Add(this.label74);
			this.Controls.Add(this.label73);
			this.Controls.Add(this.label72);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormExternos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos externos";
			this.Load += new System.EventHandler(this.FormExternosLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label72;
		private System.Windows.Forms.Label label73;
		private System.Windows.Forms.Label label74;
		private System.Windows.Forms.TextBox txtPlacaE;
		private System.Windows.Forms.TextBox txtPlacaF;
		private System.Windows.Forms.CheckBox cbPlacaMal;
		private System.Windows.Forms.TextBox txtPlacaNueva;
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
