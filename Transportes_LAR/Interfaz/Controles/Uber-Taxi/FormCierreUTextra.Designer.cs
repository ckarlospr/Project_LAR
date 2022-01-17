/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 10/08/2016
 * Hora: 01:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	partial class FormCierreUTextra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCierreUTextra));
			this.gbCierre = new System.Windows.Forms.GroupBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblCerrar = new System.Windows.Forms.Label();
			this.lblProgramacion = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbCierre.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbCierre
			// 
			this.gbCierre.BackColor = System.Drawing.SystemColors.Control;
			this.gbCierre.Controls.Add(this.btnGuardar);
			this.gbCierre.Controls.Add(this.txtFolio);
			this.gbCierre.Controls.Add(this.label1);
			this.gbCierre.Controls.Add(this.panel2);
			this.gbCierre.Controls.Add(this.txtCosto);
			this.gbCierre.Controls.Add(this.label9);
			this.gbCierre.Controls.Add(this.txtUsuario);
			this.gbCierre.Controls.Add(this.label8);
			this.gbCierre.Location = new System.Drawing.Point(6, 5);
			this.gbCierre.Name = "gbCierre";
			this.gbCierre.Size = new System.Drawing.Size(289, 112);
			this.gbCierre.TabIndex = 154;
			this.gbCierre.TabStop = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(208, 46);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(74, 45);
			this.btnGuardar.TabIndex = 4;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtFolio
			// 
			this.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFolio.Enabled = false;
			this.txtFolio.Location = new System.Drawing.Point(59, 83);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(121, 20);
			this.txtFolio.TabIndex = 3;
			this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 14);
			this.label1.TabIndex = 161;
			this.label1.Text = "Folio:";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.lblCerrar);
			this.panel2.Controls.Add(this.lblProgramacion);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(289, 25);
			this.panel2.TabIndex = 159;
			// 
			// lblCerrar
			// 
			this.lblCerrar.Image = ((System.Drawing.Image)(resources.GetObject("lblCerrar.Image")));
			this.lblCerrar.Location = new System.Drawing.Point(261, 1);
			this.lblCerrar.Name = "lblCerrar";
			this.lblCerrar.Size = new System.Drawing.Size(24, 24);
			this.lblCerrar.TabIndex = 5;
			this.lblCerrar.Click += new System.EventHandler(this.LblCerrarClick);
			// 
			// lblProgramacion
			// 
			this.lblProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblProgramacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProgramacion.Location = new System.Drawing.Point(0, 4);
			this.lblProgramacion.Name = "lblProgramacion";
			this.lblProgramacion.Size = new System.Drawing.Size(289, 17);
			this.lblProgramacion.TabIndex = 1;
			this.lblProgramacion.Text = "Cierre Uber Extra";
			this.lblProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCosto
			// 
			this.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCosto.Location = new System.Drawing.Point(59, 59);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(121, 20);
			this.txtCosto.TabIndex = 2;
			this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(20, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 14);
			this.label9.TabIndex = 157;
			this.label9.Text = "Costo:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUsuario.Location = new System.Drawing.Point(59, 35);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(121, 20);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 14);
			this.label8.TabIndex = 155;
			this.label8.Text = "Usuarios:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormCierreUTextra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(301, 123);
			this.Controls.Add(this.gbCierre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "FormCierreUTextra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cierre Uber-Taxi";
			this.Load += new System.EventHandler(this.FormCierreUTextraLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCierreUTextraKeyUp);
			this.gbCierre.ResumeLayout(false);
			this.gbCierre.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label lblCerrar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblProgramacion;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.GroupBox gbCierre;
	}
}
