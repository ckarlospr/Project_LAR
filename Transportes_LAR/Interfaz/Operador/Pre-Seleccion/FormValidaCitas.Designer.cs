/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 13/02/2017
 * Hora: 11:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormValidaCitas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidaCitas));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnValida = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtEstadoManejo = new System.Windows.Forms.ComboBox();
			this.txtEstadoMedico = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.AutoSize = true;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(52, 71);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(65, 30);
			this.btnCancelar.TabIndex = 310;
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnValida
			// 
			this.btnValida.AutoSize = true;
			this.btnValida.Enabled = false;
			this.btnValida.Image = ((System.Drawing.Image)(resources.GetObject("btnValida.Image")));
			this.btnValida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnValida.Location = new System.Drawing.Point(125, 71);
			this.btnValida.Name = "btnValida";
			this.btnValida.Size = new System.Drawing.Size(70, 30);
			this.btnValida.TabIndex = 309;
			this.btnValida.Text = "Aceptar";
			this.btnValida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnValida.UseVisualStyleBackColor = true;
			this.btnValida.Click += new System.EventHandler(this.BtnValidaClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 303;
			this.label2.Text = "Exámen Médico";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 301;
			this.label1.Text = "Exámen Manejo";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(12, 59);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(200, 3);
			this.label12.TabIndex = 308;
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEstadoManejo
			// 
			this.txtEstadoManejo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtEstadoManejo.FormattingEnabled = true;
			this.txtEstadoManejo.Items.AddRange(new object[] {
									"APTO",
									"NO APTO"});
			this.txtEstadoManejo.Location = new System.Drawing.Point(100, 8);
			this.txtEstadoManejo.Name = "txtEstadoManejo";
			this.txtEstadoManejo.Size = new System.Drawing.Size(100, 21);
			this.txtEstadoManejo.TabIndex = 311;
			this.txtEstadoManejo.SelectedIndexChanged += new System.EventHandler(this.TxtEstadoManejoSelectedIndexChanged);
			// 
			// txtEstadoMedico
			// 
			this.txtEstadoMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.txtEstadoMedico.FormattingEnabled = true;
			this.txtEstadoMedico.Items.AddRange(new object[] {
									"APTO",
									"NO APTO"});
			this.txtEstadoMedico.Location = new System.Drawing.Point(100, 34);
			this.txtEstadoMedico.Name = "txtEstadoMedico";
			this.txtEstadoMedico.Size = new System.Drawing.Size(100, 21);
			this.txtEstadoMedico.TabIndex = 312;
			this.txtEstadoMedico.SelectedIndexChanged += new System.EventHandler(this.TxtEstadoMedicoSelectedIndexChanged);
			// 
			// FormValidaCitas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(219, 106);
			this.Controls.Add(this.txtEstadoMedico);
			this.Controls.Add(this.txtEstadoManejo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnValida);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(235, 145);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(235, 145);
			this.Name = "FormValidaCitas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Valida Citas";
			this.Load += new System.EventHandler(this.FormValidaCitasLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormValidaCitasKeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox txtEstadoManejo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox txtEstadoMedico;
		private System.Windows.Forms.Button btnValida;
		private System.Windows.Forms.Button btnCancelar;
	}
}
