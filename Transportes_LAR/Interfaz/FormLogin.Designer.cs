/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 11/07/2012
 * Time: 2:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.pbvalidando = new System.Windows.Forms.ProgressBar();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblL_Pass = new System.Windows.Forms.Label();
			this.lblL_Usuario = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnChecador = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pbvalidando
			// 
			resources.ApplyResources(this.pbvalidando, "pbvalidando");
			this.pbvalidando.Name = "pbvalidando";
			// 
			// btnIniciar
			// 
			this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.btnIniciar, "btnIniciar");
			this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnIniciar.FlatAppearance.BorderSize = 0;
			this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.UseVisualStyleBackColor = false;
			this.btnIniciar.Click += new System.EventHandler(this.BtnIniciarClick);
			this.btnIniciar.MouseEnter += new System.EventHandler(this.BtnIniciarMouseEnter);
			this.btnIniciar.MouseLeave += new System.EventHandler(this.BtnIniciarMouseLeave);
			// 
			// btnCancelar
			// 
			resources.ApplyResources(this.btnCancelar, "btnCancelar");
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			this.btnCancelar.MouseEnter += new System.EventHandler(this.BtnCancelarMouseEnter);
			this.btnCancelar.MouseLeave += new System.EventHandler(this.BtnCancelarMouseLeave);
			// 
			// txtContrasena
			// 
			this.txtContrasena.BackColor = System.Drawing.Color.WhiteSmoke;
			resources.ApplyResources(this.txtContrasena, "txtContrasena");
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Click += new System.EventHandler(this.TxtContrasenaClick);
			this.txtContrasena.Enter += new System.EventHandler(this.TxtContrasenaEnter);
			this.txtContrasena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtContrasenaKeyUp);
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
			resources.ApplyResources(this.txtUsuario, "txtUsuario");
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Click += new System.EventHandler(this.TxtUsuarioClick);
			this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuarioEnter);
			this.txtUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUsuarioKeyUp);
			// 
			// lblL_Pass
			// 
			this.lblL_Pass.BackColor = System.Drawing.Color.White;
			resources.ApplyResources(this.lblL_Pass, "lblL_Pass");
			this.lblL_Pass.Name = "lblL_Pass";
			// 
			// lblL_Usuario
			// 
			this.lblL_Usuario.BackColor = System.Drawing.Color.White;
			resources.ApplyResources(this.lblL_Usuario, "lblL_Usuario");
			this.lblL_Usuario.Name = "lblL_Usuario";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Name = "label2";
			// 
			// btnChecador
			// 
			resources.ApplyResources(this.btnChecador, "btnChecador");
			this.btnChecador.BackColor = System.Drawing.Color.Transparent;
			this.btnChecador.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChecador.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnChecador.FlatAppearance.BorderSize = 0;
			this.btnChecador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnChecador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnChecador.Name = "btnChecador";
			this.btnChecador.UseVisualStyleBackColor = false;
			this.btnChecador.Click += new System.EventHandler(this.BtnChecadorClick);
			// 
			// FormLogin
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.btnChecador);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.pbvalidando);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblL_Pass);
			this.Controls.Add(this.lblL_Usuario);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginFormClosing);
			this.Load += new System.EventHandler(this.FormLoginLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLoginMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLoginMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLoginMouseUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnChecador;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ProgressBar pbvalidando;
		private System.Windows.Forms.TextBox txtContrasena;
		public System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblL_Usuario;
		private System.Windows.Forms.Label lblL_Pass;
	}
}
