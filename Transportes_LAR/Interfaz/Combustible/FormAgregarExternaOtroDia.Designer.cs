/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 02/02/2016
 * Hora: 9:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormAgregarExternaOtroDia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarExternaOtroDia));
			this.btnAgregarOtroDia = new System.Windows.Forms.Button();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.nudDias = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAgregarOtroDia
			// 
			this.btnAgregarOtroDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregarOtroDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarOtroDia.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarOtroDia.Image")));
			this.btnAgregarOtroDia.Location = new System.Drawing.Point(277, 4);
			this.btnAgregarOtroDia.Name = "btnAgregarOtroDia";
			this.btnAgregarOtroDia.Size = new System.Drawing.Size(62, 45);
			this.btnAgregarOtroDia.TabIndex = 118;
			this.btnAgregarOtroDia.Tag = "Generar Extras de dias anteriores";
			this.btnAgregarOtroDia.UseVisualStyleBackColor = true;
			this.btnAgregarOtroDia.Click += new System.EventHandler(this.BtnAgregarOtroDiaClick);
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(-891, 52);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(114, 20);
			this.dtpInicio.TabIndex = 117;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(38, 18);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(97, 20);
			this.dtpFecha.TabIndex = 119;
			// 
			// nudDias
			// 
			this.nudDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudDias.Location = new System.Drawing.Point(210, 18);
			this.nudDias.Name = "nudDias";
			this.nudDias.Size = new System.Drawing.Size(38, 20);
			this.nudDias.TabIndex = 120;
			this.nudDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 23);
			this.label1.TabIndex = 121;
			this.label1.Text = "DÍA:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(137, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 122;
			this.label2.Text = "CANTIDAD:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormAgregarExternaOtroDia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 56);
			this.Controls.Add(this.nudDias);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAgregarOtroDia);
			this.Controls.Add(this.dtpInicio);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(360, 95);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(360, 95);
			this.Name = "FormAgregarExternaOtroDia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Externa Otro Día";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAgregarExternaOtroDiaFormClosing);
			this.Load += new System.EventHandler(this.FormAgregarExternaOtroDiaLoad);
			((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudDias;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.Button btnAgregarOtroDia;
	}
}
