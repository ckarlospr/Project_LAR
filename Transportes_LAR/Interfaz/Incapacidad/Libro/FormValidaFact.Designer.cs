/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 02/07/2013
 * Time: 02:36 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Incapacidad
{
	partial class FormValidaFact
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidaFact));
			this.dgEspeciales = new System.Windows.Forms.DataGridView();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdFacturar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgEspeciales)).BeginInit();
			this.SuspendLayout();
			// 
			// dgEspeciales
			// 
			this.dgEspeciales.AllowUserToAddRows = false;
			this.dgEspeciales.AllowUserToResizeRows = false;
			this.dgEspeciales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgEspeciales.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEspeciales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgEspeciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEspeciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_RE,
									this.RAZON,
									this.DESTINO,
									this.CLIENTE,
									this.RESPONSABLE,
									this.CANTIDAD,
									this.TIPO,
									this.FACTURADO});
			this.dgEspeciales.Location = new System.Drawing.Point(12, 12);
			this.dgEspeciales.MultiSelect = false;
			this.dgEspeciales.Name = "dgEspeciales";
			this.dgEspeciales.RowHeadersVisible = false;
			this.dgEspeciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEspeciales.Size = new System.Drawing.Size(780, 305);
			this.dgEspeciales.TabIndex = 1;
			// 
			// ID_RE
			// 
			this.ID_RE.HeaderText = "ID";
			this.ID_RE.Name = "ID_RE";
			this.ID_RE.ReadOnly = true;
			this.ID_RE.Width = 40;
			// 
			// RAZON
			// 
			this.RAZON.HeaderText = "RAZON SOCIAL";
			this.RAZON.Name = "RAZON";
			this.RAZON.ReadOnly = true;
			this.RAZON.Width = 150;
			// 
			// DESTINO
			// 
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			this.DESTINO.Width = 150;
			// 
			// CLIENTE
			// 
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			this.CLIENTE.Width = 120;
			// 
			// RESPONSABLE
			// 
			this.RESPONSABLE.HeaderText = "RESPONSABLE";
			this.RESPONSABLE.Name = "RESPONSABLE";
			this.RESPONSABLE.ReadOnly = true;
			this.RESPONSABLE.Width = 120;
			// 
			// CANTIDAD
			// 
			this.CANTIDAD.HeaderText = "CANT.";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			this.CANTIDAD.Width = 60;
			// 
			// TIPO
			// 
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			this.TIPO.Width = 70;
			// 
			// FACTURADO
			// 
			this.FACTURADO.HeaderText = "FACT";
			this.FACTURADO.Name = "FACTURADO";
			this.FACTURADO.ReadOnly = true;
			this.FACTURADO.Width = 40;
			// 
			// cmdFacturar
			// 
			this.cmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdFacturar.Image = ((System.Drawing.Image)(resources.GetObject("cmdFacturar.Image")));
			this.cmdFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdFacturar.Location = new System.Drawing.Point(698, 323);
			this.cmdFacturar.Name = "cmdFacturar";
			this.cmdFacturar.Size = new System.Drawing.Size(94, 36);
			this.cmdFacturar.TabIndex = 2;
			this.cmdFacturar.Text = "Facturar";
			this.cmdFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdFacturar.UseVisualStyleBackColor = true;
			this.cmdFacturar.Click += new System.EventHandler(this.CmdFacturarClick);
			// 
			// FormValidaFact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 367);
			this.Controls.Add(this.cmdFacturar);
			this.Controls.Add(this.dgEspeciales);
			this.Name = "FormValidaFact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormValidaFact";
			this.Load += new System.EventHandler(this.FormValidaFactLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgEspeciales)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdFacturar;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.DataGridView dgEspeciales;
	}
}
