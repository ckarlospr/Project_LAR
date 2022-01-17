/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 09/11/2015
 * Time: 11:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	partial class FormValidacionServicios
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValidacionServicios));
			this.cmdCambios = new System.Windows.Forms.Button();
			this.cmdValida = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbValidados = new System.Windows.Forms.CheckBox();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.pDatos = new System.Windows.Forms.Panel();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_SERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ANTICIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OP_ENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OP_SAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_COBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FLUJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rbDefault = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.pDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdCambios
			// 
			this.cmdCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCambios.Location = new System.Drawing.Point(12, 384);
			this.cmdCambios.Name = "cmdCambios";
			this.cmdCambios.Size = new System.Drawing.Size(95, 41);
			this.cmdCambios.TabIndex = 18;
			this.cmdCambios.Text = "CAMBIOS";
			this.cmdCambios.UseVisualStyleBackColor = true;
			this.cmdCambios.Click += new System.EventHandler(this.CmdCambiosClick);
			// 
			// cmdValida
			// 
			this.cmdValida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdValida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdValida.Location = new System.Drawing.Point(424, 384);
			this.cmdValida.Name = "cmdValida";
			this.cmdValida.Size = new System.Drawing.Size(95, 41);
			this.cmdValida.TabIndex = 3;
			this.cmdValida.Text = "VALIDADO";
			this.cmdValida.UseVisualStyleBackColor = true;
			this.cmdValida.Click += new System.EventHandler(this.CmdValidaClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cbValidados);
			this.groupBox1.Controls.Add(this.dtpInicio);
			this.groupBox1.Controls.Add(this.dtpFin);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 67);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros";
			// 
			// cbValidados
			// 
			this.cbValidados.Location = new System.Drawing.Point(99, 11);
			this.cbValidados.Name = "cbValidados";
			this.cbValidados.Size = new System.Drawing.Size(83, 15);
			this.cbValidados.TabIndex = 0;
			this.cbValidados.Text = "Validados";
			this.cbValidados.UseVisualStyleBackColor = true;
			this.cbValidados.CheckedChanged += new System.EventHandler(this.CbValidadosCheckedChanged);
			// 
			// dtpInicio
			// 
			this.dtpInicio.Enabled = false;
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(36, 32);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(100, 20);
			this.dtpInicio.TabIndex = 4;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Enabled = false;
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(142, 32);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 20);
			this.dtpFin.TabIndex = 5;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Location = new System.Drawing.Point(897, 384);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(95, 41);
			this.cmdAceptar.TabIndex = 14;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// pDatos
			// 
			this.pDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pDatos.AutoScroll = true;
			this.pDatos.Controls.Add(this.dgDatos);
			this.pDatos.Location = new System.Drawing.Point(12, 75);
			this.pDatos.Name = "pDatos";
			this.pDatos.Size = new System.Drawing.Size(980, 293);
			this.pDatos.TabIndex = 13;
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ESTADO,
									this.ID_RE,
									this.ID_RS,
									this.ID_SERVICIO,
									this.SERVICIO,
									this.PRECIO,
									this.ANTICIPO,
									this.SALDO,
									this.FECHA,
									this.OPERADOR,
									this.ID_OP_ENT,
									this.SALIDA,
									this.ID_OP_SAL,
									this.COBRO,
									this.TELEFONO,
									this.VL,
									this.FACTURA,
									this.VLS,
									this.FACTS,
									this.ID_COBRO,
									this.FLUJO,
									this.id_v,
									this.tipo_v,
									this.FACTURADO,
									this.ID_OPERADOR});
			this.dgDatos.Location = new System.Drawing.Point(3, 3);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(974, 287);
			this.dgDatos.TabIndex = 0;
			this.dgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatosCellClick);
			this.dgDatos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgDatosCellMouseUp);
			this.dgDatos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgDatosEditingControlShowing);
			this.dgDatos.DoubleClick += new System.EventHandler(this.DgDatosDoubleClick);
			this.dgDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgDatosKeyUp);
			// 
			// ESTADO
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ESTADO.DefaultCellStyle = dataGridViewCellStyle2;
			this.ESTADO.HeaderText = "ESTADO";
			this.ESTADO.Name = "ESTADO";
			this.ESTADO.ReadOnly = true;
			this.ESTADO.Width = 70;
			// 
			// ID_RE
			// 
			this.ID_RE.HeaderText = "ID_RE";
			this.ID_RE.Name = "ID_RE";
			this.ID_RE.ReadOnly = true;
			this.ID_RE.Visible = false;
			this.ID_RE.Width = 50;
			// 
			// ID_RS
			// 
			this.ID_RS.HeaderText = "ID_RS";
			this.ID_RS.Name = "ID_RS";
			this.ID_RS.ReadOnly = true;
			this.ID_RS.Visible = false;
			this.ID_RS.Width = 50;
			// 
			// ID_SERVICIO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID_SERVICIO.DefaultCellStyle = dataGridViewCellStyle3;
			this.ID_SERVICIO.HeaderText = "ID";
			this.ID_SERVICIO.Name = "ID_SERVICIO";
			this.ID_SERVICIO.ReadOnly = true;
			this.ID_SERVICIO.Width = 50;
			// 
			// SERVICIO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SERVICIO.DefaultCellStyle = dataGridViewCellStyle4;
			this.SERVICIO.HeaderText = "SERVICIO";
			this.SERVICIO.Name = "SERVICIO";
			this.SERVICIO.ReadOnly = true;
			this.SERVICIO.Width = 200;
			// 
			// PRECIO
			// 
			this.PRECIO.HeaderText = "PRECIO";
			this.PRECIO.Name = "PRECIO";
			this.PRECIO.ReadOnly = true;
			this.PRECIO.Visible = false;
			this.PRECIO.Width = 70;
			// 
			// ANTICIPO
			// 
			this.ANTICIPO.HeaderText = "ANTICIPO";
			this.ANTICIPO.Name = "ANTICIPO";
			this.ANTICIPO.ReadOnly = true;
			this.ANTICIPO.Visible = false;
			this.ANTICIPO.Width = 70;
			// 
			// SALDO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALDO.DefaultCellStyle = dataGridViewCellStyle5;
			this.SALDO.HeaderText = "SALDO";
			this.SALDO.Name = "SALDO";
			this.SALDO.ReadOnly = true;
			this.SALDO.Width = 80;
			// 
			// FECHA
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle6;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			this.FECHA.Width = 80;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle7;
			this.OPERADOR.HeaderText = "ENTRADA";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 110;
			// 
			// ID_OP_ENT
			// 
			this.ID_OP_ENT.HeaderText = "ID_OP_ENT";
			this.ID_OP_ENT.Name = "ID_OP_ENT";
			this.ID_OP_ENT.ReadOnly = true;
			this.ID_OP_ENT.Visible = false;
			// 
			// SALIDA
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALIDA.DefaultCellStyle = dataGridViewCellStyle8;
			this.SALIDA.HeaderText = "SALIDA";
			this.SALIDA.Name = "SALIDA";
			this.SALIDA.ReadOnly = true;
			this.SALIDA.Width = 110;
			// 
			// ID_OP_SAL
			// 
			this.ID_OP_SAL.HeaderText = "ID_OP_SAL";
			this.ID_OP_SAL.Name = "ID_OP_SAL";
			this.ID_OP_SAL.ReadOnly = true;
			this.ID_OP_SAL.Visible = false;
			// 
			// COBRO
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COBRO.DefaultCellStyle = dataGridViewCellStyle9;
			this.COBRO.HeaderText = "COBRÓ";
			this.COBRO.Name = "COBRO";
			this.COBRO.Width = 110;
			// 
			// TELEFONO
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TELEFONO.DefaultCellStyle = dataGridViewCellStyle10;
			this.TELEFONO.HeaderText = "TELEFONO";
			this.TELEFONO.Name = "TELEFONO";
			this.TELEFONO.ReadOnly = true;
			this.TELEFONO.Width = 90;
			// 
			// VL
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VL.DefaultCellStyle = dataGridViewCellStyle11;
			this.VL.HeaderText = "VL";
			this.VL.Name = "VL";
			this.VL.ReadOnly = true;
			this.VL.Width = 40;
			// 
			// FACTURA
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FACTURA.DefaultCellStyle = dataGridViewCellStyle12;
			this.FACTURA.HeaderText = "FACT.";
			this.FACTURA.Name = "FACTURA";
			this.FACTURA.ReadOnly = true;
			this.FACTURA.Visible = false;
			this.FACTURA.Width = 40;
			// 
			// VLS
			// 
			this.VLS.HeaderText = "VLS";
			this.VLS.Name = "VLS";
			this.VLS.ReadOnly = true;
			this.VLS.Visible = false;
			// 
			// FACTS
			// 
			this.FACTS.HeaderText = "FACTS";
			this.FACTS.Name = "FACTS";
			this.FACTS.ReadOnly = true;
			this.FACTS.Visible = false;
			// 
			// ID_COBRO
			// 
			this.ID_COBRO.HeaderText = "TIPO_COBRO";
			this.ID_COBRO.Name = "ID_COBRO";
			this.ID_COBRO.ReadOnly = true;
			this.ID_COBRO.Visible = false;
			// 
			// FLUJO
			// 
			this.FLUJO.HeaderText = "FLUJO";
			this.FLUJO.Name = "FLUJO";
			this.FLUJO.ReadOnly = true;
			this.FLUJO.Visible = false;
			this.FLUJO.Width = 50;
			// 
			// id_v
			// 
			this.id_v.HeaderText = "vehiculo";
			this.id_v.Name = "id_v";
			this.id_v.ReadOnly = true;
			this.id_v.Visible = false;
			this.id_v.Width = 50;
			// 
			// tipo_v
			// 
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tipo_v.DefaultCellStyle = dataGridViewCellStyle13;
			this.tipo_v.HeaderText = "TIPO";
			this.tipo_v.Name = "tipo_v";
			this.tipo_v.ReadOnly = true;
			this.tipo_v.Visible = false;
			this.tipo_v.Width = 80;
			// 
			// FACTURADO
			// 
			this.FACTURADO.HeaderText = "FACTURADO";
			this.FACTURADO.Name = "FACTURADO";
			this.FACTURADO.ReadOnly = true;
			this.FACTURADO.Visible = false;
			this.FACTURADO.Width = 30;
			// 
			// ID_OPERADOR
			// 
			this.ID_OPERADOR.HeaderText = "ID_OP";
			this.ID_OPERADOR.Name = "ID_OPERADOR";
			this.ID_OPERADOR.ReadOnly = true;
			this.ID_OPERADOR.Visible = false;
			this.ID_OPERADOR.Width = 60;
			// 
			// rbDefault
			// 
			this.rbDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbDefault.Location = new System.Drawing.Point(331, 393);
			this.rbDefault.Name = "rbDefault";
			this.rbDefault.Size = new System.Drawing.Size(75, 24);
			this.rbDefault.TabIndex = 19;
			this.rbDefault.Text = "Default";
			this.rbDefault.UseVisualStyleBackColor = true;
			// 
			// FormValidacionServicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 437);
			this.Controls.Add(this.rbDefault);
			this.Controls.Add(this.cmdValida);
			this.Controls.Add(this.cmdCambios);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.pDatos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormValidacionServicios";
			this.Text = "Validación Servicios";
			this.Load += new System.EventHandler(this.FormValidacionServiciosLoad);
			this.groupBox1.ResumeLayout(false);
			this.pDatos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox rbDefault;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_v;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_v;
		private System.Windows.Forms.DataGridViewTextBoxColumn FLUJO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COBRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTS;
		private System.Windows.Forms.DataGridViewTextBoxColumn VLS;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn VL;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn COBRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OP_SAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OP_ENT;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ANTICIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SERVICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_SERVICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
		public System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.Panel pDatos;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		public System.Windows.Forms.CheckBox cbValidados;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdValida;
		private System.Windows.Forms.Button cmdCambios;
	}
}
