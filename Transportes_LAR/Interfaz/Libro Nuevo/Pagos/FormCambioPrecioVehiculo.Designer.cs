/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 13/01/2016
 * Hora: 13:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormCambioPrecioVehiculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambioPrecioVehiculo));
			this.txtNuevoComent = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTotal_p = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNuevoComent
			// 
			this.txtNuevoComent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNuevoComent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNuevoComent.Location = new System.Drawing.Point(13, 124);
			this.txtNuevoComent.Multiline = true;
			this.txtNuevoComent.Name = "txtNuevoComent";
			this.txtNuevoComent.Size = new System.Drawing.Size(208, 73);
			this.txtNuevoComent.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 103);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 18);
			this.label9.TabIndex = 23;
			this.label9.Text = "Comentario:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(2, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "Nuevo precio:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdGuardar.Location = new System.Drawing.Point(250, 124);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(92, 60);
			this.cmdGuardar.TabIndex = 19;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// txtNuevoPrecio
			// 
			this.txtNuevoPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNuevoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNuevoPrecio.Location = new System.Drawing.Point(103, 83);
			this.txtNuevoPrecio.Name = "txtNuevoPrecio";
			this.txtNuevoPrecio.Size = new System.Drawing.Size(118, 20);
			this.txtNuevoPrecio.TabIndex = 20;
			this.txtNuevoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNuevoPrecio.TextChanged += new System.EventHandler(this.TxtNuevoPrecioTextChanged);
			this.txtNuevoPrecio.Enter += new System.EventHandler(this.TxtNuevoPrecioEnter);
			this.txtNuevoPrecio.Leave += new System.EventHandler(this.TxtNuevoPrecioLeave);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtDestino);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtTotal_p);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtSaldo);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(346, 65);
			this.panel1.TabIndex = 25;
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(63, 8);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(269, 21);
			this.txtDestino.TabIndex = 30;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(167, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 23);
			this.label6.TabIndex = 29;
			this.label6.Text = "Total:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTotal_p
			// 
			this.txtTotal_p.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTotal_p.Enabled = false;
			this.txtTotal_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal_p.Location = new System.Drawing.Point(218, 36);
			this.txtTotal_p.Name = "txtTotal_p";
			this.txtTotal_p.Size = new System.Drawing.Size(114, 20);
			this.txtTotal_p.TabIndex = 28;
			this.txtTotal_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(2, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 27;
			this.label2.Text = "Precio:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSaldo
			// 
			this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSaldo.Enabled = false;
			this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaldo.Location = new System.Drawing.Point(63, 35);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(98, 20);
			this.txtSaldo.TabIndex = 26;
			this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 25;
			this.label1.Text = "Destino:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormCambioPrecioVehiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 202);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtNuevoComent);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.txtNuevoPrecio);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(379, 241);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(379, 241);
			this.Name = "FormCambioPrecioVehiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambio Precio Vehiculo";
			this.Load += new System.EventHandler(this.FormCambioPrecioVehiculoLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtNuevoPrecio;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNuevoComent;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTotal_p;
		private System.Windows.Forms.Label label6;
	}
}
