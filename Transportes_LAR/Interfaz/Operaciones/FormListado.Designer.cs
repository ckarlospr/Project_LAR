/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 13/10/2014
 * Hora: 02:51 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormListado
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListado));
			this.dgListado = new System.Windows.Forms.DataGridView();
			this.id_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_o = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timerListado = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
			this.SuspendLayout();
			// 
			// dgListado
			// 
			this.dgListado.AllowUserToAddRows = false;
			this.dgListado.AllowUserToResizeRows = false;
			this.dgListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgListado.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_v,
									this.numero,
									this.vehiculo,
									this.id_o,
									this.operador,
									this.estado});
			this.dgListado.Location = new System.Drawing.Point(12, 39);
			this.dgListado.Name = "dgListado";
			this.dgListado.RowHeadersVisible = false;
			this.dgListado.Size = new System.Drawing.Size(420, 735);
			this.dgListado.TabIndex = 0;
			// 
			// id_v
			// 
			this.id_v.HeaderText = "ID_V";
			this.id_v.Name = "id_v";
			this.id_v.ReadOnly = true;
			this.id_v.Visible = false;
			// 
			// numero
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numero.DefaultCellStyle = dataGridViewCellStyle2;
			this.numero.HeaderText = "Numero";
			this.numero.Name = "numero";
			this.numero.ReadOnly = true;
			// 
			// vehiculo
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vehiculo.DefaultCellStyle = dataGridViewCellStyle3;
			this.vehiculo.HeaderText = "Vehiculo";
			this.vehiculo.Name = "vehiculo";
			this.vehiculo.ReadOnly = true;
			// 
			// id_o
			// 
			this.id_o.HeaderText = "ID_O";
			this.id_o.Name = "id_o";
			this.id_o.ReadOnly = true;
			this.id_o.Visible = false;
			// 
			// operador
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.operador.DefaultCellStyle = dataGridViewCellStyle4;
			this.operador.HeaderText = "Operador";
			this.operador.Name = "operador";
			this.operador.ReadOnly = true;
			// 
			// estado
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estado.DefaultCellStyle = dataGridViewCellStyle5;
			this.estado.HeaderText = "Estado";
			this.estado.Name = "estado";
			this.estado.ReadOnly = true;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(94, 12);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(258, 21);
			this.txtBusqueda.TabIndex = 1;
			this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusquedaKeyPress);
			this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusquedaKeyUp);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(358, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 20);
			this.label1.TabIndex = 2;
			// 
			// timerListado
			// 
			this.timerListado.Interval = 3000;
			this.timerListado.Tick += new System.EventHandler(this.TimerListadoTick);
			// 
			// FormListado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 786);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.dgListado);
			this.Name = "FormListado";
			this.Text = "Listado";
			this.Load += new System.EventHandler(this.FormListadoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer timerListado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn vehiculo;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.DataGridViewTextBoxColumn estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_o;
		private System.Windows.Forms.DataGridViewTextBoxColumn numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_v;
		private System.Windows.Forms.DataGridView dgListado;
	}
}
