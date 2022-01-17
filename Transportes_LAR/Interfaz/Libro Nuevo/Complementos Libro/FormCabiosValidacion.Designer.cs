/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 18/11/2015
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormCabiosValidacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCabiosValidacion));
			this.label2 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdAtciva = new System.Windows.Forms.Button();
			this.lblSal = new System.Windows.Forms.Label();
			this.lblEnt = new System.Windows.Forms.Label();
			this.lblDestino = new System.Windows.Forms.Label();
			this.cmdCambioOp = new System.Windows.Forms.Button();
			this.cmdCancelAnt = new System.Windows.Forms.Button();
			this.txtSalida = new System.Windows.Forms.TextBox();
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.cmdCancelPunto = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(299, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(6, 131);
			this.label2.TabIndex = 23;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdGuardar.Location = new System.Drawing.Point(311, 46);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 56);
			this.cmdGuardar.TabIndex = 22;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// cmdAtciva
			// 
			this.cmdAtciva.Enabled = false;
			this.cmdAtciva.Location = new System.Drawing.Point(346, 9);
			this.cmdAtciva.Name = "cmdAtciva";
			this.cmdAtciva.Size = new System.Drawing.Size(34, 21);
			this.cmdAtciva.TabIndex = 21;
			this.cmdAtciva.Text = "Activar Viaje";
			this.cmdAtciva.UseVisualStyleBackColor = true;
			this.cmdAtciva.Visible = false;
			this.cmdAtciva.Click += new System.EventHandler(this.CmdAtcivaClick);
			// 
			// lblSal
			// 
			this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSal.Location = new System.Drawing.Point(163, 51);
			this.lblSal.Name = "lblSal";
			this.lblSal.Size = new System.Drawing.Size(130, 14);
			this.lblSal.TabIndex = 20;
			this.lblSal.Text = "Salida";
			this.lblSal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblEnt
			// 
			this.lblEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnt.Location = new System.Drawing.Point(12, 51);
			this.lblEnt.Name = "lblEnt";
			this.lblEnt.Size = new System.Drawing.Size(130, 14);
			this.lblEnt.TabIndex = 19;
			this.lblEnt.Text = "Entrada";
			this.lblEnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblDestino
			// 
			this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDestino.Location = new System.Drawing.Point(12, 5);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.Size = new System.Drawing.Size(281, 16);
			this.lblDestino.TabIndex = 18;
			this.lblDestino.Text = "Destino";
			this.lblDestino.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmdCambioOp
			// 
			this.cmdCambioOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCambioOp.Image = ((System.Drawing.Image)(resources.GetObject("cmdCambioOp.Image")));
			this.cmdCambioOp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCambioOp.Location = new System.Drawing.Point(35, 95);
			this.cmdCambioOp.Name = "cmdCambioOp";
			this.cmdCambioOp.Size = new System.Drawing.Size(83, 38);
			this.cmdCambioOp.TabIndex = 17;
			this.cmdCambioOp.Text = "Cambiar operador";
			this.cmdCambioOp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCambioOp.UseVisualStyleBackColor = true;
			this.cmdCambioOp.Click += new System.EventHandler(this.CmdCambioOpClick);
			// 
			// cmdCancelAnt
			// 
			this.cmdCancelAnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCancelAnt.Location = new System.Drawing.Point(132, 103);
			this.cmdCancelAnt.Name = "cmdCancelAnt";
			this.cmdCancelAnt.Size = new System.Drawing.Size(45, 22);
			this.cmdCancelAnt.TabIndex = 16;
			this.cmdCancelAnt.Text = "Cancelado anticipado";
			this.cmdCancelAnt.UseVisualStyleBackColor = true;
			this.cmdCancelAnt.Visible = false;
			this.cmdCancelAnt.Click += new System.EventHandler(this.CmdCancelAntClick);
			// 
			// txtSalida
			// 
			this.txtSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSalida.Enabled = false;
			this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalida.Location = new System.Drawing.Point(163, 68);
			this.txtSalida.Name = "txtSalida";
			this.txtSalida.Size = new System.Drawing.Size(130, 21);
			this.txtSalida.TabIndex = 15;
			this.txtSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSalida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSalidaKeyUp);
			// 
			// txtEntrada
			// 
			this.txtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEntrada.Enabled = false;
			this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntrada.Location = new System.Drawing.Point(12, 68);
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(130, 21);
			this.txtEntrada.TabIndex = 14;
			this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtEntrada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEntradaKeyUp);
			// 
			// txtDestino
			// 
			this.txtDestino.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(12, 24);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(281, 21);
			this.txtDestino.TabIndex = 13;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmdCancelPunto
			// 
			this.cmdCancelPunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCancelPunto.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelPunto.Image")));
			this.cmdCancelPunto.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.cmdCancelPunto.Location = new System.Drawing.Point(190, 95);
			this.cmdCancelPunto.Name = "cmdCancelPunto";
			this.cmdCancelPunto.Size = new System.Drawing.Size(83, 38);
			this.cmdCancelPunto.TabIndex = 12;
			this.cmdCancelPunto.Text = "Cancelado en el punto";
			this.cmdCancelPunto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancelPunto.UseVisualStyleBackColor = true;
			this.cmdCancelPunto.Click += new System.EventHandler(this.CmdCancelPuntoClick);
			// 
			// FormCabiosValidacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 153);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.cmdAtciva);
			this.Controls.Add(this.lblSal);
			this.Controls.Add(this.lblEnt);
			this.Controls.Add(this.lblDestino);
			this.Controls.Add(this.cmdCambioOp);
			this.Controls.Add(this.cmdCancelAnt);
			this.Controls.Add(this.txtSalida);
			this.Controls.Add(this.txtEntrada);
			this.Controls.Add(this.txtDestino);
			this.Controls.Add(this.cmdCancelPunto);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(408, 192);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(408, 192);
			this.Name = "FormCabiosValidacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambios";
			this.Load += new System.EventHandler(this.FormCabiosValidacionLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cmdCancelPunto;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.TextBox txtEntrada;
		private System.Windows.Forms.TextBox txtSalida;
		private System.Windows.Forms.Button cmdCancelAnt;
		private System.Windows.Forms.Button cmdCambioOp;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.Label lblEnt;
		private System.Windows.Forms.Label lblSal;
		private System.Windows.Forms.Button cmdAtciva;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label2;
	}
}
