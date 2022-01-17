/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 12/12/2013
 * Hora: 10:57 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operaciones.Actializacion
{
	partial class FormActualizacion
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
			this.dgOperador = new System.Windows.Forms.DataGridView();
			this.d1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.d3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.cmdModificar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).BeginInit();
			this.SuspendLayout();
			// 
			// dgOperador
			// 
			this.dgOperador.AllowUserToAddRows = false;
			this.dgOperador.AllowUserToResizeRows = false;
			this.dgOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOperador.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOperador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.d1,
									this.d2,
									this.d3});
			this.dgOperador.Location = new System.Drawing.Point(12, 44);
			this.dgOperador.MultiSelect = false;
			this.dgOperador.Name = "dgOperador";
			this.dgOperador.RowHeadersVisible = false;
			this.dgOperador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgOperador.Size = new System.Drawing.Size(377, 439);
			this.dgOperador.TabIndex = 0;
			// 
			// d1
			// 
			this.d1.HeaderText = "ID";
			this.d1.Name = "d1";
			this.d1.ReadOnly = true;
			this.d1.Visible = false;
			// 
			// d2
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.d2.DefaultCellStyle = dataGridViewCellStyle2;
			this.d2.HeaderText = "ALIAS";
			this.d2.Name = "d2";
			this.d2.ReadOnly = true;
			this.d2.Width = 80;
			// 
			// d3
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.d3.DefaultCellStyle = dataGridViewCellStyle3;
			this.d3.HeaderText = "NOMBRE";
			this.d3.Name = "d3";
			this.d3.ReadOnly = true;
			this.d3.Width = 270;
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancelar.Location = new System.Drawing.Point(295, 500);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(94, 33);
			this.cmdCancelar.TabIndex = 1;
			this.cmdCancelar.Text = "Cancelar";
			this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
			// 
			// cmdModificar
			// 
			this.cmdModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdModificar.Location = new System.Drawing.Point(183, 500);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(94, 33);
			this.cmdModificar.TabIndex = 2;
			this.cmdModificar.Text = "Modificar";
			this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdModificar.UseVisualStyleBackColor = true;
			this.cmdModificar.Click += new System.EventHandler(this.CmdModificarClick);
			// 
			// FormActualizacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 545);
			this.Controls.Add(this.cmdModificar);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.dgOperador);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormActualizacion";
			this.Text = "Lista de actualizaciones";
			this.Load += new System.EventHandler(this.FormActualizacionLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgOperador)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Button cmdModificar;
		private System.Windows.Forms.DataGridView dgOperador;
		private System.Windows.Forms.DataGridViewTextBoxColumn d3;
		private System.Windows.Forms.DataGridViewTextBoxColumn d2;
		private System.Windows.Forms.DataGridViewTextBoxColumn d1;
	}
}
