/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 20/03/2015
 * Hora: 09:57 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormCombOperaciones
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
			this.label5 = new System.Windows.Forms.Label();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKms = new System.Windows.Forms.TextBox();
			this.txtGasolinera = new System.Windows.Forms.TextBox();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(172, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "Folio";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtFolio
			// 
			this.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFolio.Enabled = false;
			this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(12, 304);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(172, 38);
			this.txtFolio.TabIndex = 17;
			this.txtFolio.Text = "0";
			this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Enabled = false;
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(59, 186);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(78, 49);
			this.cmdGuardar.TabIndex = 29;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Operador";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Gasolinera";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 11);
			this.label2.TabIndex = 24;
			this.label2.Text = "Kms";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Unidad";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtKms
			// 
			this.txtKms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKms.Location = new System.Drawing.Point(12, 154);
			this.txtKms.Name = "txtKms";
			this.txtKms.Size = new System.Drawing.Size(172, 26);
			this.txtKms.TabIndex = 27;
			this.txtKms.Text = "0";
			this.txtKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKms.Enter += new System.EventHandler(this.TxtKmsEnter);
			this.txtKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKmsKeyPress);
			this.txtKms.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtKmsKeyUp);
			this.txtKms.Leave += new System.EventHandler(this.TxtKmsLeave);
			// 
			// txtGasolinera
			// 
			this.txtGasolinera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtGasolinera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGasolinera.Location = new System.Drawing.Point(12, 115);
			this.txtGasolinera.Name = "txtGasolinera";
			this.txtGasolinera.Size = new System.Drawing.Size(172, 22);
			this.txtGasolinera.TabIndex = 20;
			this.txtGasolinera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGasolinera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtGasolineraKeyUp);
			this.txtGasolinera.Leave += new System.EventHandler(this.TxtGasolineraLeave);
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(12, 25);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(172, 26);
			this.txtOperador.TabIndex = 18;
			this.txtOperador.Text = "OPERADOR";
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			this.txtOperador.Leave += new System.EventHandler(this.TxtOperadorLeave);
			// 
			// txtUnidad
			// 
			this.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.ForeColor = System.Drawing.Color.Red;
			this.txtUnidad.Location = new System.Drawing.Point(12, 70);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(172, 26);
			this.txtUnidad.TabIndex = 19;
			this.txtUnidad.Text = "000";
			this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUnidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUnidadKeyUp);
			this.txtUnidad.Leave += new System.EventHandler(this.TxtUnidadLeave);
			// 
			// FormCombOperaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(196, 354);
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
			this.Name = "FormCombOperaciones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autorización";
			this.Load += new System.EventHandler(this.FormCombOperacionesLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.TextBox txtGasolinera;
		private System.Windows.Forms.TextBox txtKms;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label5;
	}
}
