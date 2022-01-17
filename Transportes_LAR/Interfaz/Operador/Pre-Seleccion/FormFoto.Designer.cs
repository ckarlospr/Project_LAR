/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 17/01/2017
 * Hora: 9:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class Foto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foto));
			this.btnFoto = new System.Windows.Forms.Button();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.pbFotoUser = new System.Windows.Forms.PictureBox();
			this.cboDispositivos = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnFoto
			// 
			this.btnFoto.Location = new System.Drawing.Point(304, 372);
			this.btnFoto.Name = "btnFoto";
			this.btnFoto.Size = new System.Drawing.Size(96, 27);
			this.btnFoto.TabIndex = 7;
			this.btnFoto.Text = "Foto";
			this.btnFoto.UseVisualStyleBackColor = true;
			this.btnFoto.Click += new System.EventHandler(this.BtnFotoClick);
			// 
			// btnIniciar
			// 
			this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
			this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnIniciar.Location = new System.Drawing.Point(12, 388);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(227, 38);
			this.btnIniciar.TabIndex = 6;
			this.btnIniciar.Text = "Iniciar Camara";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.BtnIniciarClick);
			// 
			// pbFotoUser
			// 
			this.pbFotoUser.Location = new System.Drawing.Point(0, 26);
			this.pbFotoUser.Name = "pbFotoUser";
			this.pbFotoUser.Size = new System.Drawing.Size(570, 316);
			this.pbFotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbFotoUser.TabIndex = 5;
			this.pbFotoUser.TabStop = false;
			// 
			// cboDispositivos
			// 
			this.cboDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDispositivos.FormattingEnabled = true;
			this.cboDispositivos.Location = new System.Drawing.Point(106, 359);
			this.cboDispositivos.Name = "cboDispositivos";
			this.cboDispositivos.Size = new System.Drawing.Size(133, 21);
			this.cboDispositivos.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(570, 25);
			this.panel2.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(529, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 23);
			this.label2.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 360);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Selecciona Camara";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Location = new System.Drawing.Point(0, 343);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(570, 5);
			this.panel1.TabIndex = 9;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(435, 372);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 27);
			this.button2.TabIndex = 10;
			this.button2.Text = "Foto";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Foto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 434);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cboDispositivos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnFoto);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.pbFotoUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Foto";
			this.Text = "FormFoto";
			this.Load += new System.EventHandler(this.FotoLoad);
			((System.ComponentModel.ISupportInitialize)(this.pbFotoUser)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cboDispositivos;
		private System.Windows.Forms.PictureBox pbFotoUser;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Button btnFoto;
	}
}
