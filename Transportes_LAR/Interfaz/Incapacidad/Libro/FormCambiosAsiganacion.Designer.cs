/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 14/06/2013
 * Time: 09:42 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormCambiosAsiganacion
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
			this.cmdCancelPunto = new System.Windows.Forms.Button();
			this.txtDestino = new System.Windows.Forms.TextBox();
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.txtSalida = new System.Windows.Forms.TextBox();
			this.cmdCancelAnt = new System.Windows.Forms.Button();
			this.cmdCambioOp = new System.Windows.Forms.Button();
			this.lblDestino = new System.Windows.Forms.Label();
			this.lblEnt = new System.Windows.Forms.Label();
			this.lblSal = new System.Windows.Forms.Label();
			this.cmdAtciva = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmdCancelPunto
			// 
			this.cmdCancelPunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCancelPunto.Location = new System.Drawing.Point(115, 101);
			this.cmdCancelPunto.Name = "cmdCancelPunto";
			this.cmdCancelPunto.Size = new System.Drawing.Size(75, 38);
			this.cmdCancelPunto.TabIndex = 0;
			this.cmdCancelPunto.Text = "Cancelado en el punto";
			this.cmdCancelPunto.UseVisualStyleBackColor = true;
			this.cmdCancelPunto.Click += new System.EventHandler(this.CmdCancelPuntoClick);
			// 
			// txtDestino
			// 
			this.txtDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDestino.Enabled = false;
			this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(12, 28);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(281, 21);
			this.txtDestino.TabIndex = 1;
			this.txtDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtEntrada
			// 
			this.txtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEntrada.Enabled = false;
			this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEntrada.Location = new System.Drawing.Point(12, 66);
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(130, 21);
			this.txtEntrada.TabIndex = 2;
			this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtEntrada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEntradaKeyUp);
			// 
			// txtSalida
			// 
			this.txtSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSalida.Enabled = false;
			this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalida.Location = new System.Drawing.Point(163, 66);
			this.txtSalida.Name = "txtSalida";
			this.txtSalida.Size = new System.Drawing.Size(130, 21);
			this.txtSalida.TabIndex = 3;
			this.txtSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSalida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSalidaKeyUp);
			// 
			// cmdCancelAnt
			// 
			this.cmdCancelAnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCancelAnt.Location = new System.Drawing.Point(218, 101);
			this.cmdCancelAnt.Name = "cmdCancelAnt";
			this.cmdCancelAnt.Size = new System.Drawing.Size(75, 38);
			this.cmdCancelAnt.TabIndex = 4;
			this.cmdCancelAnt.Text = "Cancelado anticipado";
			this.cmdCancelAnt.UseVisualStyleBackColor = true;
			this.cmdCancelAnt.Click += new System.EventHandler(this.CmdCancelAntClick);
			// 
			// cmdCambioOp
			// 
			this.cmdCambioOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCambioOp.Location = new System.Drawing.Point(12, 101);
			this.cmdCambioOp.Name = "cmdCambioOp";
			this.cmdCambioOp.Size = new System.Drawing.Size(75, 38);
			this.cmdCambioOp.TabIndex = 5;
			this.cmdCambioOp.Text = "Cambiar operador";
			this.cmdCambioOp.UseVisualStyleBackColor = true;
			this.cmdCambioOp.Click += new System.EventHandler(this.CmdCambioOpClick);
			// 
			// lblDestino
			// 
			this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDestino.Location = new System.Drawing.Point(12, 9);
			this.lblDestino.Name = "lblDestino";
			this.lblDestino.Size = new System.Drawing.Size(281, 16);
			this.lblDestino.TabIndex = 6;
			this.lblDestino.Text = "Destino";
			this.lblDestino.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblEnt
			// 
			this.lblEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnt.Location = new System.Drawing.Point(12, 49);
			this.lblEnt.Name = "lblEnt";
			this.lblEnt.Size = new System.Drawing.Size(130, 14);
			this.lblEnt.TabIndex = 7;
			this.lblEnt.Text = "Entrada";
			this.lblEnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblSal
			// 
			this.lblSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSal.Location = new System.Drawing.Point(163, 49);
			this.lblSal.Name = "lblSal";
			this.lblSal.Size = new System.Drawing.Size(130, 14);
			this.lblSal.TabIndex = 8;
			this.lblSal.Text = "Salida";
			this.lblSal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmdAtciva
			// 
			this.cmdAtciva.Enabled = false;
			this.cmdAtciva.Location = new System.Drawing.Point(330, 20);
			this.cmdAtciva.Name = "cmdAtciva";
			this.cmdAtciva.Size = new System.Drawing.Size(53, 38);
			this.cmdAtciva.TabIndex = 9;
			this.cmdAtciva.Text = "Activar Viaje";
			this.cmdAtciva.UseVisualStyleBackColor = true;
			this.cmdAtciva.Click += new System.EventHandler(this.CmdAtcivaClick);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(320, 82);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(75, 58);
			this.cmdGuardar.TabIndex = 10;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(304, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(6, 131);
			this.label2.TabIndex = 11;
			// 
			// FormCambiosAsiganacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 151);
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCambiosAsiganacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambios en la asignación";
			this.Load += new System.EventHandler(this.FormCambiosAsiganacionLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Button cmdAtciva;
		private System.Windows.Forms.Label lblSal;
		private System.Windows.Forms.Label lblEnt;
		private System.Windows.Forms.Label lblDestino;
		private System.Windows.Forms.Button cmdCambioOp;
		private System.Windows.Forms.Button cmdCancelAnt;
		private System.Windows.Forms.TextBox txtSalida;
		private System.Windows.Forms.TextBox txtEntrada;
		private System.Windows.Forms.TextBox txtDestino;
		private System.Windows.Forms.Button cmdCancelPunto;
	}
}
