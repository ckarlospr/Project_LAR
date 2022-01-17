/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 08/12/2015
 * Hora: 11:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo
{
	partial class FormDetalleFactura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleFactura));
			this.lblMensaje = new System.Windows.Forms.Label();
			this.dgControlPRE = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_COTIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_REGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOMICILIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DATOS_FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ANTICIPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PAGO_OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ENCUESTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgControlPRE)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMensaje
			// 
			this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
			this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensaje.Location = new System.Drawing.Point(260, 193);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(530, 27);
			this.lblMensaje.TabIndex = 1;
			this.lblMensaje.Text = "Para quitar esta ventana da clic sobre el ojo   ----------------------->";
			this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgControlPRE
			// 
			this.dgControlPRE.AllowUserToAddRows = false;
			this.dgControlPRE.AllowUserToDeleteRows = false;
			this.dgControlPRE.AllowUserToResizeRows = false;
			this.dgControlPRE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgControlPRE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgControlPRE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgControlPRE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgControlPRE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgControlPRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgControlPRE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.ID_COTIZACION,
									this.dataGridViewTextBoxColumn6,
									this.DESTINO1,
									this.RESPONSABLE,
									this.FECHA_SALIDA,
									this.FECHA_REGRESO,
									this.VEHICULO,
									this.CANTIDAD,
									this.DOMICILIO,
									this.TELEFONO,
									this.PRECIO,
									this.FACTURA,
									this.PRECIO_FACTURA,
									this.DATOS_FACTURA,
									this.ANTICIPOS,
									this.PAGO_OPERADOR,
									this.OBSERVACIONES,
									this.CORREO,
									this.ESTADO,
									this.ENCUESTA});
			this.dgControlPRE.Location = new System.Drawing.Point(11, 11);
			this.dgControlPRE.Margin = new System.Windows.Forms.Padding(2);
			this.dgControlPRE.Name = "dgControlPRE";
			this.dgControlPRE.ReadOnly = true;
			this.dgControlPRE.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgControlPRE.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgControlPRE.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgControlPRE.RowTemplate.Height = 24;
			this.dgControlPRE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgControlPRE.Size = new System.Drawing.Size(1006, 180);
			this.dgControlPRE.TabIndex = 61;
			this.dgControlPRE.Click += new System.EventHandler(this.DgControlPREClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.FillWeight = 35F;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// ID_COTIZACION
			// 
			this.ID_COTIZACION.HeaderText = "ID_COTIZACION";
			this.ID_COTIZACION.Name = "ID_COTIZACION";
			this.ID_COTIZACION.ReadOnly = true;
			this.ID_COTIZACION.Visible = false;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.FillWeight = 72.27154F;
			this.dataGridViewTextBoxColumn6.HeaderText = "FOLIO";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// DESTINO1
			// 
			this.DESTINO1.FillWeight = 84.0575F;
			this.DESTINO1.HeaderText = "DESTINO";
			this.DESTINO1.Name = "DESTINO1";
			this.DESTINO1.ReadOnly = true;
			// 
			// RESPONSABLE
			// 
			this.RESPONSABLE.FillWeight = 76.41591F;
			this.RESPONSABLE.HeaderText = "CONTACTO";
			this.RESPONSABLE.Name = "RESPONSABLE";
			this.RESPONSABLE.ReadOnly = true;
			// 
			// FECHA_SALIDA
			// 
			this.FECHA_SALIDA.FillWeight = 72.27154F;
			this.FECHA_SALIDA.HeaderText = "FECHA SALIDA";
			this.FECHA_SALIDA.Name = "FECHA_SALIDA";
			this.FECHA_SALIDA.ReadOnly = true;
			// 
			// FECHA_REGRESO
			// 
			this.FECHA_REGRESO.FillWeight = 72.27154F;
			this.FECHA_REGRESO.HeaderText = "FECHA_REGRESO";
			this.FECHA_REGRESO.Name = "FECHA_REGRESO";
			this.FECHA_REGRESO.ReadOnly = true;
			// 
			// VEHICULO
			// 
			this.VEHICULO.FillWeight = 72.27154F;
			this.VEHICULO.HeaderText = "VEHICULO";
			this.VEHICULO.Name = "VEHICULO";
			this.VEHICULO.ReadOnly = true;
			// 
			// CANTIDAD
			// 
			this.CANTIDAD.FillWeight = 26.74557F;
			this.CANTIDAD.HeaderText = "#";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			// 
			// DOMICILIO
			// 
			this.DOMICILIO.FillWeight = 94.57655F;
			this.DOMICILIO.HeaderText = "DOMICILIO";
			this.DOMICILIO.Name = "DOMICILIO";
			this.DOMICILIO.ReadOnly = true;
			this.DOMICILIO.Visible = false;
			// 
			// TELEFONO
			// 
			this.TELEFONO.FillWeight = 85F;
			this.TELEFONO.HeaderText = "TELEFONO";
			this.TELEFONO.Name = "TELEFONO";
			this.TELEFONO.ReadOnly = true;
			this.TELEFONO.Visible = false;
			// 
			// PRECIO
			// 
			this.PRECIO.FillWeight = 64.95352F;
			this.PRECIO.HeaderText = "PRECIO";
			this.PRECIO.Name = "PRECIO";
			this.PRECIO.ReadOnly = true;
			// 
			// FACTURA
			// 
			this.FACTURA.FillWeight = 50F;
			this.FACTURA.HeaderText = "FACT";
			this.FACTURA.Name = "FACTURA";
			this.FACTURA.ReadOnly = true;
			this.FACTURA.Visible = false;
			// 
			// PRECIO_FACTURA
			// 
			this.PRECIO_FACTURA.FillWeight = 90F;
			this.PRECIO_FACTURA.HeaderText = "PRECIO FACTURA";
			this.PRECIO_FACTURA.Name = "PRECIO_FACTURA";
			this.PRECIO_FACTURA.ReadOnly = true;
			this.PRECIO_FACTURA.Visible = false;
			// 
			// DATOS_FACTURA
			// 
			this.DATOS_FACTURA.FillWeight = 94.57655F;
			this.DATOS_FACTURA.HeaderText = "DATOS FACTURA";
			this.DATOS_FACTURA.Name = "DATOS_FACTURA";
			this.DATOS_FACTURA.ReadOnly = true;
			this.DATOS_FACTURA.Visible = false;
			// 
			// ANTICIPOS
			// 
			this.ANTICIPOS.FillWeight = 90F;
			this.ANTICIPOS.HeaderText = "ANTICIPOS";
			this.ANTICIPOS.Name = "ANTICIPOS";
			this.ANTICIPOS.ReadOnly = true;
			this.ANTICIPOS.Visible = false;
			// 
			// PAGO_OPERADOR
			// 
			this.PAGO_OPERADOR.FillWeight = 90F;
			this.PAGO_OPERADOR.HeaderText = "PAGO OPERADOR";
			this.PAGO_OPERADOR.Name = "PAGO_OPERADOR";
			this.PAGO_OPERADOR.ReadOnly = true;
			this.PAGO_OPERADOR.Visible = false;
			// 
			// OBSERVACIONES
			// 
			this.OBSERVACIONES.FillWeight = 115F;
			this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
			this.OBSERVACIONES.Name = "OBSERVACIONES";
			this.OBSERVACIONES.ReadOnly = true;
			// 
			// CORREO
			// 
			this.CORREO.FillWeight = 94.57655F;
			this.CORREO.HeaderText = "CORREO";
			this.CORREO.Name = "CORREO";
			this.CORREO.ReadOnly = true;
			// 
			// ESTADO
			// 
			this.ESTADO.FillWeight = 94.57655F;
			this.ESTADO.HeaderText = "ESTADO";
			this.ESTADO.Name = "ESTADO";
			this.ESTADO.ReadOnly = true;
			// 
			// ENCUESTA
			// 
			this.ENCUESTA.FillWeight = 40F;
			this.ENCUESTA.HeaderText = "ENCUESTA";
			this.ENCUESTA.Name = "ENCUESTA";
			this.ENCUESTA.ReadOnly = true;
			this.ENCUESTA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ENCUESTA.Visible = false;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(754, 193);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 30);
			this.label1.TabIndex = 62;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// FormDetalleFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1028, 225);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgControlPRE);
			this.Controls.Add(this.lblMensaje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDetalleFactura";
			this.Text = "FormDetalleFactura";
			((System.ComponentModel.ISupportInitialize)(this.dgControlPRE)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ENCUESTA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
		private System.Windows.Forms.DataGridViewTextBoxColumn PAGO_OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ANTICIPOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn DATOS_FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn DOMICILIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGRESO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn RESPONSABLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COTIZACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		public System.Windows.Forms.DataGridView dgControlPRE;
		private System.Windows.Forms.Label lblMensaje;
	}
}
