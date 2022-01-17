/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 06/06/2013
 * Time: 10:26 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro
{
	partial class FormValidacionEsp
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
			this.pDatos = new System.Windows.Forms.Panel();
			this.cmdAceptar = new System.Windows.Forms.Button();
			this.cmdValida = new System.Windows.Forms.Button();
			this.cmdFactura = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbCancPunto = new System.Windows.Forms.CheckBox();
			this.cbSinConf = new System.Windows.Forms.CheckBox();
			this.cbCancAnt = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbValidados = new System.Windows.Forms.CheckBox();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbDefault = new System.Windows.Forms.CheckBox();
			this.cmdCambios = new System.Windows.Forms.Button();
			this.lblSeleccion = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.pDatos.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
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
									this.FACTURADO});
			this.dgDatos.Location = new System.Drawing.Point(3, 3);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(970, 274);
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
			// pDatos
			// 
			this.pDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pDatos.AutoScroll = true;
			this.pDatos.Controls.Add(this.dgDatos);
			this.pDatos.Location = new System.Drawing.Point(12, 88);
			this.pDatos.Name = "pDatos";
			this.pDatos.Size = new System.Drawing.Size(976, 280);
			this.pDatos.TabIndex = 1;
			// 
			// cmdAceptar
			// 
			this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAceptar.Location = new System.Drawing.Point(893, 384);
			this.cmdAceptar.Name = "cmdAceptar";
			this.cmdAceptar.Size = new System.Drawing.Size(95, 41);
			this.cmdAceptar.TabIndex = 2;
			this.cmdAceptar.Text = "Aceptar";
			this.cmdAceptar.UseVisualStyleBackColor = true;
			this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
			// 
			// cmdValida
			// 
			this.cmdValida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdValida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdValida.Location = new System.Drawing.Point(87, 13);
			this.cmdValida.Name = "cmdValida";
			this.cmdValida.Size = new System.Drawing.Size(95, 41);
			this.cmdValida.TabIndex = 3;
			this.cmdValida.Text = "VALIDADO";
			this.cmdValida.UseVisualStyleBackColor = true;
			this.cmdValida.Click += new System.EventHandler(this.CmdValidaClick);
			// 
			// cmdFactura
			// 
			this.cmdFactura.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdFactura.Location = new System.Drawing.Point(509, 384);
			this.cmdFactura.Name = "cmdFactura";
			this.cmdFactura.Size = new System.Drawing.Size(95, 41);
			this.cmdFactura.TabIndex = 4;
			this.cmdFactura.Text = "FACTURADO";
			this.cmdFactura.UseVisualStyleBackColor = true;
			this.cmdFactura.Visible = false;
			this.cmdFactura.Click += new System.EventHandler(this.CmdFacturaClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(584, 83);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cbCancPunto);
			this.groupBox4.Controls.Add(this.cbSinConf);
			this.groupBox4.Controls.Add(this.cbCancAnt);
			this.groupBox4.Location = new System.Drawing.Point(302, 9);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(182, 68);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Visible = false;
			// 
			// cbCancPunto
			// 
			this.cbCancPunto.Checked = true;
			this.cbCancPunto.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCancPunto.Location = new System.Drawing.Point(15, 10);
			this.cbCancPunto.Name = "cbCancPunto";
			this.cbCancPunto.Size = new System.Drawing.Size(165, 18);
			this.cbCancPunto.TabIndex = 1;
			this.cbCancPunto.Text = "Cancelados en el punto";
			this.cbCancPunto.UseVisualStyleBackColor = true;
			// 
			// cbSinConf
			// 
			this.cbSinConf.Checked = true;
			this.cbSinConf.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSinConf.Location = new System.Drawing.Point(15, 44);
			this.cbSinConf.Name = "cbSinConf";
			this.cbSinConf.Size = new System.Drawing.Size(165, 18);
			this.cbSinConf.TabIndex = 8;
			this.cbSinConf.Text = "Sin confirmar";
			this.cbSinConf.UseVisualStyleBackColor = true;
			// 
			// cbCancAnt
			// 
			this.cbCancAnt.Checked = true;
			this.cbCancAnt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCancAnt.Location = new System.Drawing.Point(15, 27);
			this.cbCancAnt.Name = "cbCancAnt";
			this.cbCancAnt.Size = new System.Drawing.Size(165, 18);
			this.cbCancAnt.TabIndex = 7;
			this.cbCancAnt.Text = "Cancelada anticipada";
			this.cbCancAnt.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbValidados);
			this.groupBox2.Controls.Add(this.dtpInicio);
			this.groupBox2.Controls.Add(this.dtpFin);
			this.groupBox2.Location = new System.Drawing.Point(52, 9);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(244, 68);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// cbValidados
			// 
			this.cbValidados.Location = new System.Drawing.Point(83, 11);
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
			this.dtpInicio.Location = new System.Drawing.Point(20, 30);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(100, 20);
			this.dtpInicio.TabIndex = 4;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Enabled = false;
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(136, 29);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 20);
			this.dtpFin.TabIndex = 5;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.groupBox3.Controls.Add(this.rbDefault);
			this.groupBox3.Controls.Add(this.cmdValida);
			this.groupBox3.Location = new System.Drawing.Point(308, 371);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(188, 64);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			// 
			// rbDefault
			// 
			this.rbDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbDefault.Location = new System.Drawing.Point(11, 22);
			this.rbDefault.Name = "rbDefault";
			this.rbDefault.Size = new System.Drawing.Size(75, 24);
			this.rbDefault.TabIndex = 5;
			this.rbDefault.Text = "Default";
			this.rbDefault.UseVisualStyleBackColor = true;
			// 
			// cmdCambios
			// 
			this.cmdCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCambios.Location = new System.Drawing.Point(12, 384);
			this.cmdCambios.Name = "cmdCambios";
			this.cmdCambios.Size = new System.Drawing.Size(95, 41);
			this.cmdCambios.TabIndex = 10;
			this.cmdCambios.Text = "CAMBIOS";
			this.cmdCambios.UseVisualStyleBackColor = true;
			this.cmdCambios.Click += new System.EventHandler(this.CmdCambiosClick);
			// 
			// lblSeleccion
			// 
			this.lblSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeleccion.Location = new System.Drawing.Point(712, 385);
			this.lblSeleccion.Name = "lblSeleccion";
			this.lblSeleccion.Size = new System.Drawing.Size(94, 41);
			this.lblSeleccion.TabIndex = 11;
			this.lblSeleccion.Text = "0";
			this.lblSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblSeleccion.Visible = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(609, 393);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Seleccionadas:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Visible = false;
			// 
			// FormValidacionEsp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 437);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSeleccion);
			this.Controls.Add(this.cmdCambios);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmdFactura);
			this.Controls.Add(this.cmdAceptar);
			this.Controls.Add(this.pDatos);
			this.MinimumSize = new System.Drawing.Size(995, 468);
			this.Name = "FormValidacionEsp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Validación";
			this.Load += new System.EventHandler(this.FormValidacionEspLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.pDatos.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_v;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_v;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSeleccion;
		private System.Windows.Forms.Button cmdCambios;
		private System.Windows.Forms.CheckBox cbCancAnt;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox rbDefault;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridViewTextBoxColumn FLUJO;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COBRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTS;
		private System.Windows.Forms.DataGridViewTextBoxColumn VLS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OP_SAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OP_ENT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		public System.Windows.Forms.CheckBox cbValidados;
		private System.Windows.Forms.CheckBox cbCancPunto;
		private System.Windows.Forms.CheckBox cbSinConf;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ANTICIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
		private System.Windows.Forms.Button cmdFactura;
		private System.Windows.Forms.Button cmdValida;
		private System.Windows.Forms.Button cmdAceptar;
		private System.Windows.Forms.Panel pDatos;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn VL;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn COBRO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SERVICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_SERVICIO;
		public System.Windows.Forms.DataGridView dgDatos;
	}
}
