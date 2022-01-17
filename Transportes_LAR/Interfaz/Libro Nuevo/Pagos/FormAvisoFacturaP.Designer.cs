/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 20/02/2016
 * Hora: 13:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormAvisoFacturaP
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvisoFacturaP));
			this.dgRelacion = new System.Windows.Forms.DataGridView();
			this.id_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONTACTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD_UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_COTIZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AGENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_COBRAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ANTICIPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).BeginInit();
			this.SuspendLayout();
			// 
			// dgRelacion
			// 
			this.dgRelacion.AllowUserToAddRows = false;
			this.dgRelacion.AllowUserToResizeRows = false;
			this.dgRelacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgRelacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgRelacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRelacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgRelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRelacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_re,
									this.CONTACTO,
									this.CLIENTE,
									this.DESTINO,
									this.FECHA_SALIDA,
									this.CANTIDAD_UNIDAD,
									this.PRECIO_COTIZADO,
									this.FACTURA,
									this.FACTURAA,
									this.AGENCIA,
									this.PRECIO_COBRAR,
									this.ANTICIPOS,
									this.EFECTIVO,
									this.SALDO});
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgRelacion.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgRelacion.Location = new System.Drawing.Point(1, 36);
			this.dgRelacion.Name = "dgRelacion";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRelacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dgRelacion.RowHeadersVisible = false;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgRelacion.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.dgRelacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgRelacion.Size = new System.Drawing.Size(1061, 216);
			this.dgRelacion.TabIndex = 23;
			// 
			// id_re
			// 
			this.id_re.FillWeight = 30F;
			this.id_re.HeaderText = "ID_RE";
			this.id_re.Name = "id_re";
			this.id_re.ReadOnly = true;
			// 
			// CONTACTO
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.CONTACTO.DefaultCellStyle = dataGridViewCellStyle2;
			this.CONTACTO.FillWeight = 70.57762F;
			this.CONTACTO.HeaderText = "CONTACTO";
			this.CONTACTO.Name = "CONTACTO";
			this.CONTACTO.ReadOnly = true;
			// 
			// CLIENTE
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle3;
			this.CLIENTE.FillWeight = 70.57762F;
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			// 
			// DESTINO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.DESTINO.DefaultCellStyle = dataGridViewCellStyle4;
			this.DESTINO.FillWeight = 120F;
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			// 
			// FECHA_SALIDA
			// 
			this.FECHA_SALIDA.FillWeight = 35.28881F;
			this.FECHA_SALIDA.HeaderText = "FECHA SALIDA";
			this.FECHA_SALIDA.Name = "FECHA_SALIDA";
			this.FECHA_SALIDA.ReadOnly = true;
			// 
			// CANTIDAD_UNIDAD
			// 
			this.CANTIDAD_UNIDAD.FillWeight = 30F;
			this.CANTIDAD_UNIDAD.HeaderText = "C.U";
			this.CANTIDAD_UNIDAD.Name = "CANTIDAD_UNIDAD";
			this.CANTIDAD_UNIDAD.ReadOnly = true;
			// 
			// PRECIO_COTIZADO
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.PRECIO_COTIZADO.DefaultCellStyle = dataGridViewCellStyle5;
			this.PRECIO_COTIZADO.FillWeight = 50F;
			this.PRECIO_COTIZADO.HeaderText = "PRECIO COTIZADO";
			this.PRECIO_COTIZADO.Name = "PRECIO_COTIZADO";
			this.PRECIO_COTIZADO.ReadOnly = true;
			// 
			// FACTURA
			// 
			this.FACTURA.FillWeight = 25F;
			this.FACTURA.HeaderText = "F";
			this.FACTURA.Name = "FACTURA";
			this.FACTURA.ReadOnly = true;
			// 
			// FACTURAA
			// 
			this.FACTURAA.FillWeight = 70F;
			this.FACTURAA.HeaderText = "FACTURA";
			this.FACTURAA.Name = "FACTURAA";
			// 
			// AGENCIA
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.AGENCIA.DefaultCellStyle = dataGridViewCellStyle6;
			this.AGENCIA.FillWeight = 90F;
			this.AGENCIA.HeaderText = "RAZON SOCIAL";
			this.AGENCIA.Name = "AGENCIA";
			this.AGENCIA.ReadOnly = true;
			// 
			// PRECIO_COBRAR
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.PRECIO_COBRAR.DefaultCellStyle = dataGridViewCellStyle7;
			this.PRECIO_COBRAR.FillWeight = 50F;
			this.PRECIO_COBRAR.HeaderText = "PRECIO A COBRAR";
			this.PRECIO_COBRAR.Name = "PRECIO_COBRAR";
			this.PRECIO_COBRAR.ReadOnly = true;
			// 
			// ANTICIPOS
			// 
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			this.ANTICIPOS.DefaultCellStyle = dataGridViewCellStyle8;
			this.ANTICIPOS.FillWeight = 60F;
			this.ANTICIPOS.HeaderText = "ANT. DEPOSITO";
			this.ANTICIPOS.Name = "ANTICIPOS";
			this.ANTICIPOS.ReadOnly = true;
			// 
			// EFECTIVO
			// 
			this.EFECTIVO.FillWeight = 60F;
			this.EFECTIVO.HeaderText = "ANT. EFECTIVO";
			this.EFECTIVO.Name = "EFECTIVO";
			this.EFECTIVO.ReadOnly = true;
			// 
			// SALDO
			// 
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALDO.DefaultCellStyle = dataGridViewCellStyle9;
			this.SALDO.FillWeight = 50F;
			this.SALDO.HeaderText = "SALDO";
			this.SALDO.Name = "SALDO";
			this.SALDO.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(504, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 34);
			this.label1.TabIndex = 24;
			this.label1.Tag = "Refrescar";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// FormAvisoFacturaP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1065, 256);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgRelacion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAvisoFacturaP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Aviso de factura pagada por efectivo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAvisoFacturaPFormClosing);
			this.Load += new System.EventHandler(this.FormAvisoFacturaPLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURAA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn EFECTIVO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ANTICIPOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COBRAR;
		private System.Windows.Forms.DataGridViewTextBoxColumn AGENCIA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COTIZADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_UNIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONTACTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_re;
		public System.Windows.Forms.DataGridView dgRelacion;
	}
}
