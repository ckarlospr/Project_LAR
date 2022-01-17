/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 21/01/2014
 * Hora: 02:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operaciones.Despacho
{
	partial class FormRecados
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtMsj = new System.Windows.Forms.TextBox();
			this.dgMsj = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MENSAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgMsj)).BeginInit();
			this.SuspendLayout();
			// 
			// txtMsj
			// 
			this.txtMsj.Enabled = false;
			this.txtMsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMsj.Location = new System.Drawing.Point(12, 201);
			this.txtMsj.Multiline = true;
			this.txtMsj.Name = "txtMsj";
			this.txtMsj.Size = new System.Drawing.Size(535, 169);
			this.txtMsj.TabIndex = 0;
			this.txtMsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dgMsj
			// 
			this.dgMsj.AllowUserToAddRows = false;
			this.dgMsj.AllowUserToResizeRows = false;
			this.dgMsj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgMsj.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgMsj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgMsj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMsj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.MENSAJE,
									this.TIPO,
									this.FECHA_INICIO,
									this.ESTATUS,
									this.Operador});
			this.dgMsj.Location = new System.Drawing.Point(12, 12);
			this.dgMsj.MultiSelect = false;
			this.dgMsj.Name = "dgMsj";
			this.dgMsj.RowHeadersVisible = false;
			this.dgMsj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgMsj.Size = new System.Drawing.Size(535, 183);
			this.dgMsj.TabIndex = 2;
			this.dgMsj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgMsjCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// MENSAJE
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MENSAJE.DefaultCellStyle = dataGridViewCellStyle2;
			this.MENSAJE.HeaderText = "MENSAJE";
			this.MENSAJE.Name = "MENSAJE";
			this.MENSAJE.ReadOnly = true;
			this.MENSAJE.Width = 300;
			// 
			// TIPO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO.DefaultCellStyle = dataGridViewCellStyle3;
			this.TIPO.HeaderText = "TIPO";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			// 
			// FECHA_INICIO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA_INICIO.DefaultCellStyle = dataGridViewCellStyle4;
			this.FECHA_INICIO.HeaderText = "FECHA";
			this.FECHA_INICIO.Name = "FECHA_INICIO";
			this.FECHA_INICIO.ReadOnly = true;
			// 
			// ESTATUS
			// 
			this.ESTATUS.HeaderText = "ESTATUS";
			this.ESTATUS.Name = "ESTATUS";
			this.ESTATUS.ReadOnly = true;
			this.ESTATUS.Visible = false;
			// 
			// Operador
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Operador.DefaultCellStyle = dataGridViewCellStyle5;
			this.Operador.HeaderText = "OPERADOR";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			this.Operador.Visible = false;
			// 
			// FormRecados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(559, 382);
			this.Controls.Add(this.dgMsj);
			this.Controls.Add(this.txtMsj);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRecados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recordatorios";
			this.Load += new System.EventHandler(this.FormRecadosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgMsj)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtMsj;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn MENSAJE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgMsj;
	}
}
