/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 24/07/2013
 * Time: 02:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Asignacion
{
	partial class FormValidacionCardex
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
			this.dgValidacion = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Insistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgValidacion)).BeginInit();
			this.SuspendLayout();
			// 
			// dgValidacion
			// 
			this.dgValidacion.AllowUserToAddRows = false;
			this.dgValidacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgValidacion.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgValidacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgValidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgValidacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id,
									this.Operador,
									this.Insistencia});
			this.dgValidacion.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgValidacion.Location = new System.Drawing.Point(12, 12);
			this.dgValidacion.MultiSelect = false;
			this.dgValidacion.Name = "dgValidacion";
			this.dgValidacion.RowHeadersVisible = false;
			this.dgValidacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgValidacion.Size = new System.Drawing.Size(271, 358);
			this.dgValidacion.TabIndex = 0;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// Operador
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Operador.DefaultCellStyle = dataGridViewCellStyle2;
			this.Operador.HeaderText = "Operador";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			this.Operador.Width = 150;
			// 
			// Insistencia
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Insistencia.DefaultCellStyle = dataGridViewCellStyle3;
			this.Insistencia.HeaderText = "Incistencias";
			this.Insistencia.Name = "Insistencia";
			this.Insistencia.ReadOnly = true;
			this.Insistencia.Width = 90;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Location = new System.Drawing.Point(208, 377);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(75, 27);
			this.cmdAceptar.TabIndex = 1;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(11, 377);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(75, 27);
			this.cmdEliminar.TabIndex = 2;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// FormValidacionCardex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 416);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.dgValidacion);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(311, 454);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(311, 454);
			this.Name = "FormValidacionCardex";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Validación dormidas";
			this.Load += new System.EventHandler(this.FormValidacionCardexLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgValidacion)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Insistencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridView dgValidacion;
	}
}
