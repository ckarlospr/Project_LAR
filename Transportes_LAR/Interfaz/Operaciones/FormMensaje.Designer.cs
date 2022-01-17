/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 06/02/2013
 * Time: 12:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormMensaje
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
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.cmdBorrar = new System.Windows.Forms.Button();
			this.cmdSalir = new System.Windows.Forms.Button();
			this.lblEmp = new System.Windows.Forms.Label();
			this.lblRut = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMensaje
			// 
			this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMensaje.Location = new System.Drawing.Point(12, 100);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(530, 84);
			this.txtMensaje.TabIndex = 0;
			// 
			// cmdBorrar
			// 
			this.cmdBorrar.Enabled = false;
			this.cmdBorrar.Location = new System.Drawing.Point(305, 191);
			this.cmdBorrar.Name = "cmdBorrar";
			this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
			this.cmdBorrar.TabIndex = 2;
			this.cmdBorrar.Text = "Borrar";
			this.cmdBorrar.UseVisualStyleBackColor = true;
			this.cmdBorrar.Visible = false;
			this.cmdBorrar.Click += new System.EventHandler(this.CmdBorrarClick);
			// 
			// cmdSalir
			// 
			this.cmdSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdSalir.Location = new System.Drawing.Point(467, 191);
			this.cmdSalir.Name = "cmdSalir";
			this.cmdSalir.Size = new System.Drawing.Size(75, 23);
			this.cmdSalir.TabIndex = 3;
			this.cmdSalir.Text = "Salir";
			this.cmdSalir.UseVisualStyleBackColor = true;
			this.cmdSalir.Click += new System.EventHandler(this.CmdSalirClick);
			// 
			// lblEmp
			// 
			this.lblEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmp.Location = new System.Drawing.Point(1, 57);
			this.lblEmp.Name = "lblEmp";
			this.lblEmp.Size = new System.Drawing.Size(341, 17);
			this.lblEmp.TabIndex = 4;
			this.lblEmp.Text = "Empresa";
			this.lblEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRut
			// 
			this.lblRut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRut.Location = new System.Drawing.Point(1, 76);
			this.lblRut.Name = "lblRut";
			this.lblRut.Size = new System.Drawing.Size(341, 13);
			this.lblRut.TabIndex = 5;
			this.lblRut.Text = "Ruta";
			this.lblRut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(1, 1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(552, 56);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mensaje";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Location = new System.Drawing.Point(386, 191);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
			this.cmdGuardar.TabIndex = 7;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// FormMensaje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 226);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblRut);
			this.Controls.Add(this.lblEmp);
			this.Controls.Add(this.cmdSalir);
			this.Controls.Add(this.cmdBorrar);
			this.Controls.Add(this.txtMensaje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(554, 226);
			this.Name = "FormMensaje";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control de mensajes";
			this.Load += new System.EventHandler(this.FormMensajeLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblRut;
		private System.Windows.Forms.Label lblEmp;
		private System.Windows.Forms.Button cmdSalir;
		private System.Windows.Forms.Button cmdBorrar;
		private System.Windows.Forms.TextBox txtMensaje;
	}
}
