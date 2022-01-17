/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 05/02/2016
 * Hora: 9:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormParametrosCombu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametrosCombu));
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nudCantidadBono = new System.Windows.Forms.NumericUpDown();
			this.nudDiasPrueba = new System.Windows.Forms.NumericUpDown();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadBono)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDiasPrueba)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.Location = new System.Drawing.Point(463, 24);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(87, 44);
			this.cmdGuardar.TabIndex = 146;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 147;
			this.label1.Text = "Perdida de Bono";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 148;
			this.label2.Text = "Prueba Rendimiento";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(183, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(227, 33);
			this.label3.TabIndex = 150;
			this.label3.Text = "CANTIDAD DE INCIDENCIAS  PARA PERDER EL BONO ";
			// 
			// nudCantidadBono
			// 
			this.nudCantidadBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudCantidadBono.Location = new System.Drawing.Point(105, 15);
			this.nudCantidadBono.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudCantidadBono.Name = "nudCantidadBono";
			this.nudCantidadBono.Size = new System.Drawing.Size(59, 20);
			this.nudCantidadBono.TabIndex = 151;
			this.nudCantidadBono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudCantidadBono.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// nudDiasPrueba
			// 
			this.nudDiasPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudDiasPrueba.Location = new System.Drawing.Point(105, 64);
			this.nudDiasPrueba.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudDiasPrueba.Name = "nudDiasPrueba";
			this.nudDiasPrueba.Size = new System.Drawing.Size(59, 20);
			this.nudDiasPrueba.TabIndex = 152;
			this.nudDiasPrueba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudDiasPrueba.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel5.Location = new System.Drawing.Point(0, 48);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(440, 5);
			this.panel5.TabIndex = 153;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(182, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(251, 33);
			this.label4.TabIndex = 154;
			this.label4.Text = "DÍAS DE EXPIRACIÓN DE UNA PRUEBA DE RENDIMIENTO";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Location = new System.Drawing.Point(437, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(5, 95);
			this.panel1.TabIndex = 154;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormParametrosCombu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 98);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.nudDiasPrueba);
			this.Controls.Add(this.nudCantidadBono);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdGuardar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(579, 137);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(579, 137);
			this.Name = "FormParametrosCombu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parámetros del Módulo de Combustible";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParametrosCombuFormClosing);
			this.Load += new System.EventHandler(this.FormParametrosCombuLoad);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidadBono)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDiasPrueba)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.NumericUpDown nudDiasPrueba;
		public System.Windows.Forms.NumericUpDown nudCantidadBono;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdGuardar;
	}
}
