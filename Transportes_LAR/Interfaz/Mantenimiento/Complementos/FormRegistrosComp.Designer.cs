/*
 * Created by SharpDevelop.
 * User: gqg_9_000
 * Date: 21/07/2015
 * Time: 01:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	partial class FormRegistrosComp
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
			this.dataRegistrosComp = new System.Windows.Forms.DataGridView();
			this.idoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.conceptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnDesplegar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataRegistrosComp)).BeginInit();
			this.SuspendLayout();
			// 
			// dataRegistrosComp
			// 
			this.dataRegistrosComp.AllowUserToAddRows = false;
			this.dataRegistrosComp.AllowUserToResizeRows = false;
			this.dataRegistrosComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataRegistrosComp.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataRegistrosComp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataRegistrosComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataRegistrosComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idoc,
									this.folio,
									this.fecha,
									this.factura,
									this.conceptos,
									this.total});
			this.dataRegistrosComp.Location = new System.Drawing.Point(12, 12);
			this.dataRegistrosComp.Name = "dataRegistrosComp";
			this.dataRegistrosComp.RowHeadersVisible = false;
			this.dataRegistrosComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataRegistrosComp.Size = new System.Drawing.Size(503, 252);
			this.dataRegistrosComp.TabIndex = 0;
			// 
			// idoc
			// 
			this.idoc.HeaderText = "IDorden";
			this.idoc.Name = "idoc";
			this.idoc.Visible = false;
			// 
			// folio
			// 
			this.folio.HeaderText = "Folio";
			this.folio.Name = "folio";
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			// 
			// factura
			// 
			this.factura.HeaderText = "Factura";
			this.factura.Name = "factura";
			// 
			// conceptos
			// 
			this.conceptos.HeaderText = "Conceptos";
			this.conceptos.Name = "conceptos";
			// 
			// total
			// 
			this.total.HeaderText = "Total";
			this.total.Name = "total";
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(303, 270);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(75, 25);
			this.btnCerrar.TabIndex = 1;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// btnDesplegar
			// 
			this.btnDesplegar.Location = new System.Drawing.Point(149, 270);
			this.btnDesplegar.Name = "btnDesplegar";
			this.btnDesplegar.Size = new System.Drawing.Size(75, 25);
			this.btnDesplegar.TabIndex = 2;
			this.btnDesplegar.Text = "Desplegar";
			this.btnDesplegar.UseVisualStyleBackColor = true;
			this.btnDesplegar.Click += new System.EventHandler(this.BtnDesplegarClick);
			// 
			// FormRegistrosComp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(527, 307);
			this.Controls.Add(this.btnDesplegar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.dataRegistrosComp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRegistrosComp";
			this.Text = "Total de Compras";
			this.Load += new System.EventHandler(this.FormRegistrosCompLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataRegistrosComp)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnDesplegar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
		private System.Windows.Forms.DataGridViewTextBoxColumn conceptos;
		private System.Windows.Forms.DataGridViewTextBoxColumn factura;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn folio;
		private System.Windows.Forms.DataGridViewTextBoxColumn idoc;
		private System.Windows.Forms.DataGridView dataRegistrosComp;
	}
}
