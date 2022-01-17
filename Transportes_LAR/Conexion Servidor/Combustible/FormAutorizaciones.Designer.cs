/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 29/07/2014
 * Hora: 02:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormAutorizaciones
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgAutorizaciones = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgAutorizaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// dgAutorizaciones
			// 
			this.dgAutorizaciones.AllowUserToAddRows = false;
			this.dgAutorizaciones.AllowUserToResizeRows = false;
			this.dgAutorizaciones.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgAutorizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgAutorizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAutorizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.numero,
									this.fecha,
									this.UNIDAD});
			this.dgAutorizaciones.Location = new System.Drawing.Point(12, 12);
			this.dgAutorizaciones.Name = "dgAutorizaciones";
			this.dgAutorizaciones.RowHeadersVisible = false;
			this.dgAutorizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAutorizaciones.Size = new System.Drawing.Size(241, 276);
			this.dgAutorizaciones.TabIndex = 0;
			this.dgAutorizaciones.DoubleClick += new System.EventHandler(this.DgAutorizacionesDoubleClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// numero
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numero.DefaultCellStyle = dataGridViewCellStyle2;
			this.numero.HeaderText = "Folio";
			this.numero.Name = "numero";
			this.numero.ReadOnly = true;
			// 
			// fecha
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fecha.DefaultCellStyle = dataGridViewCellStyle3;
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			// 
			// UNIDAD
			// 
			this.UNIDAD.HeaderText = "UNIDAD";
			this.UNIDAD.Name = "UNIDAD";
			this.UNIDAD.ReadOnly = true;
			this.UNIDAD.Visible = false;
			// 
			// FormAutorizaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 300);
			this.Controls.Add(this.dgAutorizaciones);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAutorizaciones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autorizaciones";
			this.Load += new System.EventHandler(this.FormAutorizacionesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgAutorizaciones)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn UNIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgAutorizaciones;
	}
}
