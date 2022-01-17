/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 12/04/2013
 * Time: 09:47 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Aptomedico
{
	partial class FormReporteApto
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteApto));
			this.dataLicencia = new System.Windows.Forms.DataGridView();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.lblAlias = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataLicencia)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLicencia
			// 
			this.dataLicencia.AllowUserToAddRows = false;
			this.dataLicencia.AllowUserToDeleteRows = false;
			this.dataLicencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataLicencia.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataLicencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataLicencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataLicencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataLicencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Alias,
									this.Numero,
									this.Vigencia});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataLicencia.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataLicencia.Location = new System.Drawing.Point(12, 175);
			this.dataLicencia.Name = "dataLicencia";
			this.dataLicencia.ReadOnly = true;
			this.dataLicencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataLicencia.Size = new System.Drawing.Size(575, 312);
			this.dataLicencia.TabIndex = 15;
			// 
			// Alias
			// 
			this.Alias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Alias.DataPropertyName = "Alias";
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			// 
			// Numero
			// 
			this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Numero.DataPropertyName = "Numero";
			this.Numero.HeaderText = "Numero";
			this.Numero.Name = "Numero";
			this.Numero.ReadOnly = true;
			// 
			// Vigencia
			// 
			this.Vigencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Vigencia.DataPropertyName = "Vigencia";
			this.Vigencia.HeaderText = "Vigencia";
			this.Vigencia.Name = "Vigencia";
			this.Vigencia.ReadOnly = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.txtAlias);
			this.panel2.Controls.Add(this.lblAlias);
			this.panel2.Controls.Add(this.txtNumero);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 73);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(576, 96);
			this.panel2.TabIndex = 16;
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(69, 32);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(185, 20);
			this.txtAlias.TabIndex = 1;
			this.txtAlias.TextChanged += new System.EventHandler(this.TxtAliasTextChanged);
			// 
			// lblAlias
			// 
			this.lblAlias.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblAlias.AutoSize = true;
			this.lblAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlias.Location = new System.Drawing.Point(16, 35);
			this.lblAlias.Name = "lblAlias";
			this.lblAlias.Size = new System.Drawing.Size(34, 14);
			this.lblAlias.TabIndex = 48;
			this.lblAlias.Text = "Alias:";
			// 
			// txtNumero
			// 
			this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtNumero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(69, 62);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(185, 20);
			this.txtNumero.TabIndex = 2;
			this.txtNumero.TextChanged += new System.EventHandler(this.TxtNumeroTextChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 14);
			this.label4.TabIndex = 41;
			this.label4.Text = "Numero:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(577, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "Datos personales del usuario:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(-3, -3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(604, 98);
			this.label2.TabIndex = 19;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(65, 60);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(119, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(265, 14);
			this.label6.TabIndex = 20;
			this.label6.Text = "Ingrese los datos de para realizar la búsqueda:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormReporteApto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(599, 499);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataLicencia);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReporteApto";
			this.Text = "Transportes LAR - Reporte Apto Médico";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteAptoFormClosing);
			this.Load += new System.EventHandler(this.FormReporteAptoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataLicencia)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblAlias;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridView dataLicencia;
	}
}
