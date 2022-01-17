/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 25/09/2012
 * Time: 12:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormAddDelRutas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDelRutas));
			this.lblMensajeAddDel = new System.Windows.Forms.Label();
			this.btnOpcUno = new System.Windows.Forms.Button();
			this.btnOpcDos = new System.Windows.Forms.Button();
			this.btnOpcTres = new System.Windows.Forms.Button();
			this.rbSalida = new System.Windows.Forms.CheckBox();
			this.rbEntrada = new System.Windows.Forms.CheckBox();
			this.gbSentido = new System.Windows.Forms.GroupBox();
			this.gbSentido.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMensajeAddDel
			// 
			this.lblMensajeAddDel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensajeAddDel.Location = new System.Drawing.Point(12, 9);
			this.lblMensajeAddDel.Name = "lblMensajeAddDel";
			this.lblMensajeAddDel.Size = new System.Drawing.Size(392, 19);
			this.lblMensajeAddDel.TabIndex = 0;
			this.lblMensajeAddDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOpcUno
			// 
			this.btnOpcUno.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpcUno.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcUno.Image")));
			this.btnOpcUno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpcUno.Location = new System.Drawing.Point(180, 57);
			this.btnOpcUno.Name = "btnOpcUno";
			this.btnOpcUno.Size = new System.Drawing.Size(94, 28);
			this.btnOpcUno.TabIndex = 1;
			this.btnOpcUno.Text = "Aceptar";
			this.btnOpcUno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOpcUno.UseVisualStyleBackColor = true;
			this.btnOpcUno.Click += new System.EventHandler(this.BtnOpcUnoClick);
			// 
			// btnOpcDos
			// 
			this.btnOpcDos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpcDos.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcDos.Image")));
			this.btnOpcDos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpcDos.Location = new System.Drawing.Point(229, 84);
			this.btnOpcDos.Name = "btnOpcDos";
			this.btnOpcDos.Size = new System.Drawing.Size(103, 28);
			this.btnOpcDos.TabIndex = 2;
			this.btnOpcDos.Text = "Permanente";
			this.btnOpcDos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOpcDos.UseVisualStyleBackColor = true;
			this.btnOpcDos.Visible = false;
			this.btnOpcDos.Click += new System.EventHandler(this.BtnOpcDosClick);
			// 
			// btnOpcTres
			// 
			this.btnOpcTres.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpcTres.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcTres.Image")));
			this.btnOpcTres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOpcTres.Location = new System.Drawing.Point(293, 57);
			this.btnOpcTres.Name = "btnOpcTres";
			this.btnOpcTres.Size = new System.Drawing.Size(94, 28);
			this.btnOpcTres.TabIndex = 3;
			this.btnOpcTres.Text = "Cancelar";
			this.btnOpcTres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOpcTres.UseVisualStyleBackColor = true;
			this.btnOpcTres.Click += new System.EventHandler(this.BtnOpcTresClick);
			// 
			// rbSalida
			// 
			this.rbSalida.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbSalida.Location = new System.Drawing.Point(6, 38);
			this.rbSalida.Name = "rbSalida";
			this.rbSalida.Size = new System.Drawing.Size(67, 24);
			this.rbSalida.TabIndex = 5;
			this.rbSalida.Text = "Salida";
			this.rbSalida.UseVisualStyleBackColor = true;
			// 
			// rbEntrada
			// 
			this.rbEntrada.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbEntrada.Location = new System.Drawing.Point(6, 19);
			this.rbEntrada.Name = "rbEntrada";
			this.rbEntrada.Size = new System.Drawing.Size(68, 24);
			this.rbEntrada.TabIndex = 6;
			this.rbEntrada.Text = "Entrada";
			this.rbEntrada.UseVisualStyleBackColor = true;
			// 
			// gbSentido
			// 
			this.gbSentido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbSentido.BackgroundImage")));
			this.gbSentido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gbSentido.Controls.Add(this.rbEntrada);
			this.gbSentido.Controls.Add(this.rbSalida);
			this.gbSentido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbSentido.Location = new System.Drawing.Point(45, 38);
			this.gbSentido.Name = "gbSentido";
			this.gbSentido.Size = new System.Drawing.Size(129, 68);
			this.gbSentido.TabIndex = 7;
			this.gbSentido.TabStop = false;
			this.gbSentido.Text = "Sentido de la Ruta";
			// 
			// FormAddDelRutas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(422, 116);
			this.Controls.Add(this.gbSentido);
			this.Controls.Add(this.btnOpcTres);
			this.Controls.Add(this.btnOpcDos);
			this.Controls.Add(this.btnOpcUno);
			this.Controls.Add(this.lblMensajeAddDel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(432, 148);
			this.MinimumSize = new System.Drawing.Size(432, 148);
			this.Name = "FormAddDelRutas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Agregar Ruta";
			this.Load += new System.EventHandler(this.FormAddDelRutasLoad);
			this.gbSentido.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox gbSentido;
		private System.Windows.Forms.CheckBox rbSalida;
		private System.Windows.Forms.CheckBox rbEntrada;
		private System.Windows.Forms.Button btnOpcTres;
		private System.Windows.Forms.Button btnOpcDos;
		private System.Windows.Forms.Button btnOpcUno;
		private System.Windows.Forms.Label lblMensajeAddDel;
	}
}
