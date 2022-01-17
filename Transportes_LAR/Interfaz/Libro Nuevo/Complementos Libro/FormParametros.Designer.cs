/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 05/11/2015
 * Time: 9:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormParametros
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametros));
			this.dgParametros = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PARAMETRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PARAMETRO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COMENTARIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgParametros)).BeginInit();
			this.SuspendLayout();
			// 
			// dgParametros
			// 
			this.dgParametros.AllowUserToAddRows = false;
			this.dgParametros.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgParametros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Nombre,
									this.PARAMETRO,
									this.PARAMETRO2,
									this.COMENTARIOS});
			this.dgParametros.Location = new System.Drawing.Point(12, 12);
			this.dgParametros.Name = "dgParametros";
			this.dgParametros.RowHeadersVisible = false;
			this.dgParametros.Size = new System.Drawing.Size(672, 214);
			this.dgParametros.TabIndex = 0;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 35;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "NOMBRE";
			this.Nombre.Name = "Nombre";
			this.Nombre.Width = 150;
			// 
			// PARAMETRO
			// 
			this.PARAMETRO.HeaderText = "PARAMETRO 1";
			this.PARAMETRO.Name = "PARAMETRO";
			this.PARAMETRO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.PARAMETRO.Width = 140;
			// 
			// PARAMETRO2
			// 
			this.PARAMETRO2.HeaderText = "PARAMETRO 2";
			this.PARAMETRO2.Name = "PARAMETRO2";
			this.PARAMETRO2.Width = 140;
			// 
			// COMENTARIOS
			// 
			this.COMENTARIOS.HeaderText = "OBSERVACIONES";
			this.COMENTARIOS.Name = "COMENTARIOS";
			this.COMENTARIOS.Width = 200;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.Location = new System.Drawing.Point(598, 232);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(87, 44);
			this.cmdGuardar.TabIndex = 2;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 229);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(130, 41);
			this.button1.TabIndex = 143;
			this.button1.Text = "Nuevo Contribuyente";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(148, 229);
			this.button2.Name = "button2";
			this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button2.Size = new System.Drawing.Size(130, 41);
			this.button2.TabIndex = 144;
			this.button2.Text = "Nueva Razon Social";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// FormParametros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 285);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.dgParametros);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(709, 324);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(709, 324);
			this.Name = "FormParametros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parámetros del Módulo de Ventas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormParametrosFormClosing);
			this.Load += new System.EventHandler(this.FormParametrosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgParametros)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn PARAMETRO2;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn COMENTARIOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn PARAMETRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgParametros;
	}
}
