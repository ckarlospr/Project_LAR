/*
 * Creado por SharpDevelop.
 * Usuario: Estandar
 * Fecha: 14/01/2022
 * Hora: 9:48 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.CardexAdmin
{
	partial class FormCardexAdmin
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblbusqueda = new System.Windows.Forms.Label();
			this.ID_O = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.ID_Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aliasOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_Cardex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seguimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(101, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(128, 20);
			this.textBox1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_O,
									this.Alias,
									this.Nombre});
			this.dataGridView1.Location = new System.Drawing.Point(12, 49);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(235, 462);
			this.dataGridView1.TabIndex = 1;
			// 
			// lblbusqueda
			// 
			this.lblbusqueda.Location = new System.Drawing.Point(30, 21);
			this.lblbusqueda.Name = "lblbusqueda";
			this.lblbusqueda.Size = new System.Drawing.Size(65, 23);
			this.lblbusqueda.TabIndex = 2;
			this.lblbusqueda.Text = "Busqueda:";
			this.lblbusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ID_O
			// 
			this.ID_O.HeaderText = "ID_O";
			this.ID_O.Name = "ID_O";
			this.ID_O.ReadOnly = true;
			this.ID_O.Visible = false;
			// 
			// Alias
			// 
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Op,
									this.aliasOp,
									this.ID_Cardex,
									this.fecha,
									this.Tipo,
									this.Descripcion,
									this.Estatus,
									this.Seguimiento});
			this.dataGridView2.Location = new System.Drawing.Point(253, 49);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(430, 462);
			this.dataGridView2.TabIndex = 3;
			// 
			// ID_Op
			// 
			this.ID_Op.HeaderText = "ID_Operador";
			this.ID_Op.Name = "ID_Op";
			this.ID_Op.ReadOnly = true;
			this.ID_Op.Visible = false;
			// 
			// aliasOp
			// 
			this.aliasOp.HeaderText = "Alias";
			this.aliasOp.Name = "aliasOp";
			this.aliasOp.ReadOnly = true;
			// 
			// ID_Cardex
			// 
			this.ID_Cardex.HeaderText = "IDCardex";
			this.ID_Cardex.Name = "ID_Cardex";
			this.ID_Cardex.ReadOnly = true;
			this.ID_Cardex.Visible = false;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Estatus
			// 
			this.Estatus.HeaderText = "Estatus";
			this.Estatus.Name = "Estatus";
			this.Estatus.ReadOnly = true;
			this.Estatus.Visible = false;
			// 
			// Seguimiento
			// 
			this.Seguimiento.HeaderText = "Seguimiento";
			this.Seguimiento.Name = "Seguimiento";
			this.Seguimiento.ReadOnly = true;
			this.Seguimiento.Visible = false;
			// 
			// FormCardexAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 523);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.lblbusqueda);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox1);
			this.Name = "FormCardexAdmin";
			this.Text = "Cardex Administrativos ";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Seguimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cardex;
		private System.Windows.Forms.DataGridViewTextBoxColumn aliasOp;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Op;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label lblbusqueda;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_O;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
