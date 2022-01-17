/*
 * Created by SharpDevelop.
 * User: Xavi_Ochoa
 * Date: 13/12/2013
 * Time: 09:47 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Consultas
{
	partial class FormConsultas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultas));
			this.dtConsultas = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSentencia = new System.Windows.Forms.TextBox();
			this.lblEjecutar = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).BeginInit();
			this.SuspendLayout();
			// 
			// dtConsultas
			// 
			this.dtConsultas.AllowUserToAddRows = false;
			this.dtConsultas.AllowUserToResizeColumns = false;
			this.dtConsultas.AllowUserToResizeRows = false;
			this.dtConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dtConsultas.BackgroundColor = System.Drawing.Color.White;
			this.dtConsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtConsultas.Location = new System.Drawing.Point(12, 131);
			this.dtConsultas.Name = "dtConsultas";
			this.dtConsultas.RowHeadersVisible = false;
			this.dtConsultas.Size = new System.Drawing.Size(783, 186);
			this.dtConsultas.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Consulta";
			// 
			// txtSentencia
			// 
			this.txtSentencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSentencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSentencia.Location = new System.Drawing.Point(12, 31);
			this.txtSentencia.Multiline = true;
			this.txtSentencia.Name = "txtSentencia";
			this.txtSentencia.Size = new System.Drawing.Size(679, 95);
			this.txtSentencia.TabIndex = 3;
			this.txtSentencia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSentenciaKeyUp);
			// 
			// lblEjecutar
			// 
			this.lblEjecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("lblEjecutar.Image")));
			this.lblEjecutar.Location = new System.Drawing.Point(697, 31);
			this.lblEjecutar.Name = "lblEjecutar";
			this.lblEjecutar.Size = new System.Drawing.Size(98, 95);
			this.lblEjecutar.TabIndex = 5;
			this.lblEjecutar.Click += new System.EventHandler(this.LblEjecutarClick);
			// 
			// FormConsultas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(807, 329);
			this.Controls.Add(this.lblEjecutar);
			this.Controls.Add(this.txtSentencia);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtConsultas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormConsultas";
			this.Text = "Transportes LAR - Consultas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultasFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dtConsultas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblEjecutar;
		private System.Windows.Forms.TextBox txtSentencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtConsultas;
	}
}
