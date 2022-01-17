/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 12/07/2012
 * Time: 6:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Usuario
{
	partial class FormModificarCuenta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarCuenta));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmbNivelUsuario = new System.Windows.Forms.ComboBox();
			this.lblNivelUsuario = new System.Windows.Forms.Label();
			this.txtNuevaContrasena2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContrasenaActual = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.label44 = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Datos personales de inicio de sesión:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.cmbNivelUsuario);
			this.panel1.Controls.Add(this.lblNivelUsuario);
			this.panel1.Controls.Add(this.txtNuevaContrasena2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtNuevaContrasena);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtContrasenaActual);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtNombreUsuario);
			this.panel1.Controls.Add(this.label44);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(356, 197);
			this.panel1.TabIndex = 1;
			// 
			// cmbNivelUsuario
			// 
			this.cmbNivelUsuario.FormattingEnabled = true;
			this.cmbNivelUsuario.Items.AddRange(new object[] {
									"ADMINISTRATIVO",
									"COMBUSTIBLE",
									"COORDINADOR",
									"GERENCIAL",
									"MANTENIMIENTO",
									"NOMINA",
									"VENTAS",
									"RECEPCION",
									"OPERACION"});
			this.cmbNivelUsuario.Location = new System.Drawing.Point(145, 165);
			this.cmbNivelUsuario.Name = "cmbNivelUsuario";
			this.cmbNivelUsuario.Size = new System.Drawing.Size(194, 21);
			this.cmbNivelUsuario.TabIndex = 16;
			// 
			// lblNivelUsuario
			// 
			this.lblNivelUsuario.AutoSize = true;
			this.lblNivelUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblNivelUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNivelUsuario.Location = new System.Drawing.Point(66, 168);
			this.lblNivelUsuario.Name = "lblNivelUsuario";
			this.lblNivelUsuario.Size = new System.Drawing.Size(73, 14);
			this.lblNivelUsuario.TabIndex = 15;
			this.lblNivelUsuario.Text = "Nivel Usuario:";
			// 
			// txtNuevaContrasena2
			// 
			this.txtNuevaContrasena2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNuevaContrasena2.Location = new System.Drawing.Point(145, 139);
			this.txtNuevaContrasena2.Name = "txtNuevaContrasena2";
			this.txtNuevaContrasena2.PasswordChar = '*';
			this.txtNuevaContrasena2.Size = new System.Drawing.Size(194, 20);
			this.txtNuevaContrasena2.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 14);
			this.label4.TabIndex = 14;
			this.label4.Text = "Repita constraseña nueva:";
			// 
			// txtNuevaContrasena
			// 
			this.txtNuevaContrasena.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNuevaContrasena.Location = new System.Drawing.Point(145, 110);
			this.txtNuevaContrasena.Name = "txtNuevaContrasena";
			this.txtNuevaContrasena.PasswordChar = '*';
			this.txtNuevaContrasena.Size = new System.Drawing.Size(194, 20);
			this.txtNuevaContrasena.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 14);
			this.label3.TabIndex = 12;
			this.label3.Text = "Constraseña nueva:";
			// 
			// txtContrasenaActual
			// 
			this.txtContrasenaActual.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasenaActual.Location = new System.Drawing.Point(145, 81);
			this.txtContrasenaActual.Name = "txtContrasenaActual";
			this.txtContrasenaActual.PasswordChar = '*';
			this.txtContrasenaActual.Size = new System.Drawing.Size(194, 20);
			this.txtContrasenaActual.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 14);
			this.label2.TabIndex = 10;
			this.label2.Text = "Contraseña actual:";
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.Location = new System.Drawing.Point(145, 52);
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(194, 20);
			this.txtNombreUsuario.TabIndex = 7;
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.BackColor = System.Drawing.Color.White;
			this.label44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label44.Location = new System.Drawing.Point(44, 55);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(101, 14);
			this.label44.TabIndex = 8;
			this.label44.Text = "Nombre de usuario:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(186, 207);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(84, 31);
			this.btnAceptar.TabIndex = 21;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(284, 207);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(84, 31);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// FormModificarCuenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(379, 242);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(395, 274);
			this.MinimizeBox = false;
			this.Name = "FormModificarCuenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Usuario";
			this.Load += new System.EventHandler(this.FormModificarCuentaLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblNivelUsuario;
		public System.Windows.Forms.ComboBox cmbNivelUsuario;
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.TextBox txtNombreUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtContrasenaActual;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNuevaContrasena;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNuevaContrasena2;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}
