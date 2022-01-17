/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 03/06/2013
 * Time: 01:10 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormAsignOperadores
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
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgAsignados = new System.Windows.Forms.DataGridView();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgAsignados)).BeginInit();
			this.SuspendLayout();
			// 
			// txtOperador
			// 
			this.txtOperador.Location = new System.Drawing.Point(84, 58);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(168, 20);
			this.txtOperador.TabIndex = 0;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(1, 0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(263, 41);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Asignacion de operadores";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Operador:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgAsignados
			// 
			this.dgAsignados.AllowUserToAddRows = false;
			this.dgAsignados.AllowUserToResizeRows = false;
			this.dgAsignados.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgAsignados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Operador});
			this.dgAsignados.Location = new System.Drawing.Point(12, 120);
			this.dgAsignados.Name = "dgAsignados";
			this.dgAsignados.RowHeadersVisible = false;
			this.dgAsignados.Size = new System.Drawing.Size(240, 172);
			this.dgAsignados.TabIndex = 3;
			this.dgAsignados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAsignadosCellClick);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Enabled = false;
			this.cmdAgregar.Location = new System.Drawing.Point(177, 84);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(75, 30);
			this.cmdAgregar.TabIndex = 4;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Enabled = false;
			this.cmdEliminar.Location = new System.Drawing.Point(13, 84);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(75, 30);
			this.cmdEliminar.TabIndex = 5;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Location = new System.Drawing.Point(177, 298);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(75, 26);
			this.cmdCancelar.TabIndex = 6;
			this.cmdCancelar.Text = "Cancelar";
			this.cmdCancelar.UseVisualStyleBackColor = true;
			// 
			// lblCantidad
			// 
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(114, 81);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(38, 33);
			this.lblCantidad.TabIndex = 7;
			this.lblCantidad.Text = "1";
			this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Operador
			// 
			this.Operador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Operador.DefaultCellStyle = dataGridViewCellStyle2;
			this.Operador.HeaderText = "Operador";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			// 
			// FormAsignOperadores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 334);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdAgregar);
			this.Controls.Add(this.dgAsignados);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.txtOperador);
			this.Name = "FormAsignOperadores";
			this.Text = "Asignación de operador";
			this.Load += new System.EventHandler(this.FormAsignOperadoresLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgAsignados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Button cmdCancelar;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgAsignados;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.TextBox txtOperador;
	}
}
