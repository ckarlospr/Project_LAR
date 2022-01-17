/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 13/02/2014
 * Hora: 01:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormListaSueldos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgOperadores = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD_V = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).BeginInit();
			this.SuspendLayout();
			// 
			// dgOperadores
			// 
			this.dgOperadores.AllowUserToAddRows = false;
			this.dgOperadores.AllowUserToResizeRows = false;
			this.dgOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOperadores.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOperadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.OPERADOR,
									this.CANTIDAD_V,
									this.CANTIDAD});
			this.dgOperadores.Location = new System.Drawing.Point(12, 12);
			this.dgOperadores.Name = "dgOperadores";
			this.dgOperadores.RowHeadersVisible = false;
			this.dgOperadores.Size = new System.Drawing.Size(371, 554);
			this.dgOperadores.TabIndex = 0;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle2;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 160;
			// 
			// CANTIDAD_V
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CANTIDAD_V.DefaultCellStyle = dataGridViewCellStyle3;
			this.CANTIDAD_V.HeaderText = "VIAJES";
			this.CANTIDAD_V.Name = "CANTIDAD_V";
			this.CANTIDAD_V.ReadOnly = true;
			this.CANTIDAD_V.Width = 80;
			// 
			// CANTIDAD
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle4;
			this.CANTIDAD.HeaderText = "CANTIDAD";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			// 
			// FormListaSueldos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 578);
			this.Controls.Add(this.dgOperadores);
			this.Name = "FormListaSueldos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lista Sueldos";
			this.Load += new System.EventHandler(this.FormListaSueldosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dgOperadores;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_V;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
	}
}
