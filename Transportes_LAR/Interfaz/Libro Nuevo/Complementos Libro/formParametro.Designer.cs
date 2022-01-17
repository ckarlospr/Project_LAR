/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 07/03/2016
 * Hora: 12:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class formParametro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formParametro));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtCorreo2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Location = new System.Drawing.Point(461, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(0, 95);
			this.panel1.TabIndex = 162;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel5.Location = new System.Drawing.Point(0, 57);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(450, 5);
			this.panel5.TabIndex = 161;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(223, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(227, 33);
			this.label3.TabIndex = 158;
			this.label3.Text = "CORREOS PARA ENVIAR SERVICIOS REGISTRADOS";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 156;
			this.label1.Text = "Correo 1";
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.Location = new System.Drawing.Point(467, 15);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(87, 44);
			this.cmdGuardar.TabIndex = 155;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(50, 6);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(161, 20);
			this.txtCorreo.TabIndex = 164;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtCorreo2
			// 
			this.txtCorreo2.Location = new System.Drawing.Point(50, 28);
			this.txtCorreo2.Name = "txtCorreo2";
			this.txtCorreo2.Size = new System.Drawing.Size(161, 20);
			this.txtCorreo2.TabIndex = 165;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 166;
			this.label2.Text = "Correo 2";
			// 
			// formParametro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 71);
			this.Controls.Add(this.txtCorreo2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdGuardar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(579, 110);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(579, 110);
			this.Name = "formParametro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parámetros del Módulo de Reportes Ventas";
			this.Load += new System.EventHandler(this.FormParametroLoad);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCorreo2;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel1;
	}
}
