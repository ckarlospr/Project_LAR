namespace Transportes_LAR.Interfaz.Chat
{
	partial class Cliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.txtPuerto = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.btnConectar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.btnDesconectar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtChat = new System.Windows.Forms.TextBox();
			this.lblConectado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Mensaje";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Usuario";
			// 
			// txtMensaje
			// 
			this.txtMensaje.Location = new System.Drawing.Point(84, 89);
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(120, 20);
			this.txtMensaje.TabIndex = 12;
			this.txtMensaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMensajeKeyUp);
			// 
			// txtPuerto
			// 
			this.txtPuerto.Enabled = false;
			this.txtPuerto.Location = new System.Drawing.Point(210, 9);
			this.txtPuerto.Name = "txtPuerto";
			this.txtPuerto.Size = new System.Drawing.Size(35, 20);
			this.txtPuerto.TabIndex = 11;
			this.txtPuerto.Text = "8888";
			this.txtPuerto.Visible = false;
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(84, 64);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(102, 20);
			this.txtNombre.TabIndex = 10;
			this.txtNombre.Text = "Xavi";
			// 
			// btnEnviar
			// 
			this.btnEnviar.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
			this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.btnEnviar.FlatAppearance.BorderSize = 5;
			this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
			this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
			this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEnviar.Location = new System.Drawing.Point(210, 89);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(28, 23);
			this.btnEnviar.TabIndex = 9;
			this.btnEnviar.UseVisualStyleBackColor = false;
			this.btnEnviar.Click += new System.EventHandler(this.BtnEnviarClick);
			// 
			// btnConectar
			// 
			this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnConectar.Image = ((System.Drawing.Image)(resources.GetObject("btnConectar.Image")));
			this.btnConectar.Location = new System.Drawing.Point(130, 311);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(51, 49);
			this.btnConectar.TabIndex = 8;
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.BtnConectarClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Dirección IP (Server)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtIP
			// 
			this.txtIP.Enabled = false;
			this.txtIP.Location = new System.Drawing.Point(3, 36);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(242, 20);
			this.txtIP.TabIndex = 16;
			this.txtIP.Text = "192.168.0.122";
			this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnDesconectar
			// 
			this.btnDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDesconectar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesconectar.Image")));
			this.btnDesconectar.Location = new System.Drawing.Point(187, 311);
			this.btnDesconectar.Name = "btnDesconectar";
			this.btnDesconectar.Size = new System.Drawing.Size(51, 49);
			this.btnDesconectar.TabIndex = 18;
			this.btnDesconectar.UseVisualStyleBackColor = true;
			this.btnDesconectar.Click += new System.EventHandler(this.BtnDesconectarClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "Chat";
			// 
			// txtChat
			// 
			this.txtChat.Location = new System.Drawing.Point(84, 116);
			this.txtChat.Multiline = true;
			this.txtChat.Name = "txtChat";
			this.txtChat.Size = new System.Drawing.Size(154, 189);
			this.txtChat.TabIndex = 19;
			// 
			// lblConectado
			// 
			this.lblConectado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConectado.Location = new System.Drawing.Point(3, 141);
			this.lblConectado.Name = "lblConectado";
			this.lblConectado.Size = new System.Drawing.Size(74, 23);
			this.lblConectado.TabIndex = 21;
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(249, 365);
			this.Controls.Add(this.lblConectado);
			this.Controls.Add(this.txtPuerto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtChat);
			this.Controls.Add(this.btnDesconectar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMensaje);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.btnConectar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cliente";
			this.Text = "Cliente";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClienteFormClosing);
			this.Load += new System.EventHandler(this.ClienteLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblConectado;
		private System.Windows.Forms.TextBox txtChat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.Button btnDesconectar;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMensaje;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtPuerto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}
