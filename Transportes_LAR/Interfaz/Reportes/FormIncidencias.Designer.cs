/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 06/03/2014
 * Hora: 01:17 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormIncidencias
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
			this.dgIncidencias = new System.Windows.Forms.DataGridView();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgIncidencias)).BeginInit();
			this.SuspendLayout();
			// 
			// dgIncidencias
			// 
			this.dgIncidencias.AllowUserToAddRows = false;
			this.dgIncidencias.AllowUserToResizeRows = false;
			this.dgIncidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgIncidencias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgIncidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.TIPO,
									this.EMP,
									this.OBSERVACIONES,
									this.TURNO,
									this.DIA,
									this.USUARIO});
			this.dgIncidencias.Location = new System.Drawing.Point(12, 12);
			this.dgIncidencias.Name = "dgIncidencias";
			this.dgIncidencias.RowHeadersVisible = false;
			this.dgIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgIncidencias.Size = new System.Drawing.Size(763, 209);
			this.dgIncidencias.TabIndex = 0;
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(358, 227);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
			this.cmdEliminar.TabIndex = 1;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// TIPO
			// 
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			// 
			// EMP
			// 
			this.EMP.HeaderText = "EMPRESA";
			this.EMP.Name = "EMP";
			this.EMP.ReadOnly = true;
			// 
			// OBSERVACIONES
			// 
			this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
			this.OBSERVACIONES.Name = "OBSERVACIONES";
			this.OBSERVACIONES.ReadOnly = true;
			this.OBSERVACIONES.Width = 300;
			// 
			// TURNO
			// 
			this.TURNO.HeaderText = "TURNO";
			this.TURNO.Name = "TURNO";
			this.TURNO.ReadOnly = true;
			// 
			// DIA
			// 
			this.DIA.HeaderText = "DIA";
			this.DIA.Name = "DIA";
			this.DIA.ReadOnly = true;
			// 
			// USUARIO
			// 
			this.USUARIO.HeaderText = "USUARIO";
			this.USUARIO.Name = "USUARIO";
			this.USUARIO.ReadOnly = true;
			// 
			// FormIncidencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 262);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.dgIncidencias);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormIncidencias";
			this.Text = "Detalle de incidencias";
			this.Load += new System.EventHandler(this.FormIncidenciasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgIncidencias)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn EMP;
		private System.Windows.Forms.DataGridView dgIncidencias;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIA;
		private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
	}
}
