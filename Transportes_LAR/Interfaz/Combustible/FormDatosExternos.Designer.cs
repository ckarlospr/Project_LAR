/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 06/05/2014
 * Hora: 07:11 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormDatosExternos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosExternos));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblKms = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKms = new System.Windows.Forms.TextBox();
			this.lblOperador = new System.Windows.Forms.Label();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtGasolinera = new System.Windows.Forms.TextBox();
			this.txtNumUnidad = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpFechaBase = new System.Windows.Forms.DateTimePicker();
			this.dtpAutorizacion = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbTipoComb = new System.Windows.Forms.ComboBox();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.lblKms);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtKms);
			this.panel1.Controls.Add(this.lblOperador);
			this.panel1.Controls.Add(this.txtOperador);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtGasolinera);
			this.panel1.Location = new System.Drawing.Point(12, 54);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(676, 62);
			this.panel1.TabIndex = 75;
			// 
			// lblKms
			// 
			this.lblKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKms.Location = new System.Drawing.Point(551, 4);
			this.lblKms.Name = "lblKms";
			this.lblKms.Size = new System.Drawing.Size(111, 23);
			this.lblKms.TabIndex = 77;
			this.lblKms.Text = "Kms";
			this.lblKms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 16);
			this.label2.TabIndex = 69;
			this.label2.Text = "Unidad";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtKms
			// 
			this.txtKms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKms.Location = new System.Drawing.Point(551, 28);
			this.txtKms.Name = "txtKms";
			this.txtKms.Size = new System.Drawing.Size(111, 26);
			this.txtKms.TabIndex = 6;
			this.txtKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKms.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtKmsKeyUp);
			this.txtKms.Leave += new System.EventHandler(this.TxtKmsLeave);
			// 
			// lblOperador
			// 
			this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(104, 9);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(159, 16);
			this.lblOperador.TabIndex = 70;
			this.lblOperador.Text = "Solicita";
			this.lblOperador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(104, 28);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(159, 26);
			this.txtOperador.TabIndex = 4;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.Enter += new System.EventHandler(this.TxtOperadorEnter);
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			this.txtOperador.Leave += new System.EventHandler(this.TxtOperadorLeave);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(269, 11);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(276, 16);
			this.label3.TabIndex = 71;
			this.label3.Text = "Gasolinera";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtGasolinera
			// 
			this.txtGasolinera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtGasolinera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGasolinera.Location = new System.Drawing.Point(269, 28);
			this.txtGasolinera.Name = "txtGasolinera";
			this.txtGasolinera.Size = new System.Drawing.Size(276, 26);
			this.txtGasolinera.TabIndex = 5;
			this.txtGasolinera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGasolinera.Enter += new System.EventHandler(this.TxtGasolineraEnter);
			this.txtGasolinera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtGasolineraKeyUp);
			this.txtGasolinera.Leave += new System.EventHandler(this.TxtGasolineraLeave);
			// 
			// txtNumUnidad
			// 
			this.txtNumUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumUnidad.ForeColor = System.Drawing.Color.Red;
			this.txtNumUnidad.Location = new System.Drawing.Point(703, 18);
			this.txtNumUnidad.Name = "txtNumUnidad";
			this.txtNumUnidad.Size = new System.Drawing.Size(79, 26);
			this.txtNumUnidad.TabIndex = 3;
			this.txtNumUnidad.Text = "000";
			this.txtNumUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNumUnidad.Enter += new System.EventHandler(this.TxtNumUnidadEnter);
			this.txtNumUnidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumUnidadKeyUp);
			this.txtNumUnidad.Leave += new System.EventHandler(this.TxtNumUnidadLeave);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Enabled = false;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdGuardar.Location = new System.Drawing.Point(703, 62);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(84, 46);
			this.cmdGuardar.TabIndex = 7;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// txtNumero
			// 
			this.txtNumero.Enabled = false;
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(77, 22);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(136, 26);
			this.txtNumero.TabIndex = 72;
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 72;
			this.label1.Text = "Folio:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(219, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 15);
			this.label4.TabIndex = 81;
			this.label4.Text = "Fecha";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpFechaBase
			// 
			this.dtpFechaBase.Enabled = false;
			this.dtpFechaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaBase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaBase.Location = new System.Drawing.Point(219, 22);
			this.dtpFechaBase.Name = "dtpFechaBase";
			this.dtpFechaBase.Size = new System.Drawing.Size(112, 26);
			this.dtpFechaBase.TabIndex = 0;
			// 
			// dtpAutorizacion
			// 
			this.dtpAutorizacion.CalendarMonthBackground = System.Drawing.Color.White;
			this.dtpAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpAutorizacion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpAutorizacion.Location = new System.Drawing.Point(346, 21);
			this.dtpAutorizacion.Name = "dtpAutorizacion";
			this.dtpAutorizacion.ShowUpDown = true;
			this.dtpAutorizacion.Size = new System.Drawing.Size(72, 26);
			this.dtpAutorizacion.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(337, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 15);
			this.label5.TabIndex = 80;
			this.label5.Text = "Hora";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(446, 3);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(166, 16);
			this.label15.TabIndex = 83;
			this.label15.Text = "Tipo";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmbTipoComb
			// 
			this.cmbTipoComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoComb.FormattingEnabled = true;
			this.cmbTipoComb.Items.AddRange(new object[] {
									"DIESEL",
									"GAOLINA PREMIUM",
									"GASOLINA MAGNA"});
			this.cmbTipoComb.Location = new System.Drawing.Point(446, 20);
			this.cmbTipoComb.Name = "cmbTipoComb";
			this.cmbTipoComb.Size = new System.Drawing.Size(166, 28);
			this.cmbTipoComb.TabIndex = 2;
			this.cmbTipoComb.SelectedIndexChanged += new System.EventHandler(this.CmbTipoCombSelectedIndexChanged);
			// 
			// txtUnidad
			// 
			this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.Location = new System.Drawing.Point(624, 20);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(64, 26);
			this.txtUnidad.TabIndex = 84;
			this.txtUnidad.Text = "000";
			this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormDatosExternos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 120);
			this.Controls.Add(this.txtUnidad);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.cmbTipoComb);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpFechaBase);
			this.Controls.Add(this.dtpAutorizacion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtNumUnidad);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDatosExternos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Validacion externa";
			this.Load += new System.EventHandler(this.FormDatosExternosLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.TextBox txtKms;
		private System.Windows.Forms.Label lblKms;
		private System.Windows.Forms.ComboBox cmbTipoComb;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpAutorizacion;
		private System.Windows.Forms.DateTimePicker dtpFechaBase;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.TextBox txtNumUnidad;
		private System.Windows.Forms.TextBox txtGasolinera;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.Label lblOperador;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
	}
}
