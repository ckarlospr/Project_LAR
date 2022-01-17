/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 20/04/2016
 * Hora: 12:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormVerOperador
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
			this.dtOperador = new System.Windows.Forms.DataGridView();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtOperador)).BeginInit();
			this.SuspendLayout();
			// 
			// dtOperador
			// 
			this.dtOperador.AllowUserToAddRows = false;
			this.dtOperador.AllowUserToDeleteRows = false;
			this.dtOperador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dtOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.OPERADOR});
			this.dtOperador.Location = new System.Drawing.Point(4, 5);
			this.dtOperador.Name = "dtOperador";
			this.dtOperador.ReadOnly = true;
			this.dtOperador.RowHeadersVisible = false;
			this.dtOperador.Size = new System.Drawing.Size(148, 21);
			this.dtOperador.TabIndex = 0;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle1;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 145;
			// 
			// FormVerOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(157, 31);
			this.Controls.Add(this.dtOperador);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormVerOperador";
			this.Text = "FormVerOperador";
			this.Load += new System.EventHandler(this.FormVerOperadorLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtOperador)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridView dtOperador;
	}
}
