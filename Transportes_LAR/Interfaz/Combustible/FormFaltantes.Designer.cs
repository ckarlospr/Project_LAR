/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 12/03/2015
 * Hora: 01:15 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormFaltantes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaltantes));
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.dtpHora = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnGuarda = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpresa.Location = new System.Drawing.Point(12, 72);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(175, 22);
			this.txtEmpresa.TabIndex = 2;
			this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Empresa";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(193, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ruta";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtRuta
			// 
			this.txtRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRuta.Location = new System.Drawing.Point(193, 72);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(175, 22);
			this.txtRuta.TabIndex = 3;
			this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(193, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 14);
			this.label4.TabIndex = 9;
			this.label4.Text = "Unidad";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtUnidad
			// 
			this.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.Location = new System.Drawing.Point(193, 26);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(175, 22);
			this.txtUnidad.TabIndex = 1;
			this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 14);
			this.label5.TabIndex = 7;
			this.label5.Text = "Operador";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Enabled = false;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(12, 26);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(175, 22);
			this.txtOperador.TabIndex = 0;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(12, 171);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(100, 22);
			this.dtpFecha.TabIndex = 6;
			// 
			// dtpHora
			// 
			this.dtpHora.CustomFormat = "HH:mm";
			this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpHora.Location = new System.Drawing.Point(118, 171);
			this.dtpHora.Name = "dtpHora";
			this.dtpHora.ShowUpDown = true;
			this.dtpHora.Size = new System.Drawing.Size(69, 22);
			this.dtpHora.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(118, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 14);
			this.label7.TabIndex = 15;
			this.label7.Text = "Hr.";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 154);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 14);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fecha";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"ENTRADA",
									"SALIDA",
									"COMPLETO"});
			this.cmbTipo.Location = new System.Drawing.Point(12, 120);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(175, 24);
			this.cmbTipo.TabIndex = 4;
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"MAÑANA",
									"MEDIO DÍA",
									"VESPERTINO",
									"NOCTURNO"});
			this.cmbTurno.Location = new System.Drawing.Point(193, 120);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(175, 24);
			this.cmbTurno.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 14);
			this.label3.TabIndex = 20;
			this.label3.Text = "Tipo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(193, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(175, 14);
			this.label6.TabIndex = 21;
			this.label6.Text = "Turno";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnGuarda
			// 
			this.btnGuarda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuarda.Image = ((System.Drawing.Image)(resources.GetObject("btnGuarda.Image")));
			this.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuarda.Location = new System.Drawing.Point(240, 154);
			this.btnGuarda.Name = "btnGuarda";
			this.btnGuarda.Size = new System.Drawing.Size(94, 39);
			this.btnGuarda.TabIndex = 8;
			this.btnGuarda.Text = "Guardar";
			this.btnGuarda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuarda.UseVisualStyleBackColor = true;
			this.btnGuarda.Click += new System.EventHandler(this.BtnGuardaClick);
			// 
			// FormFaltantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 205);
			this.Controls.Add(this.btnGuarda);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbTurno);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dtpHora);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUnidad);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtOperador);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRuta);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEmpresa);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormFaltantes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Viajes faltantes";
			this.Load += new System.EventHandler(this.FormFaltantesLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormFaltantesKeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnGuarda;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpHora;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmpresa;
	}
}
