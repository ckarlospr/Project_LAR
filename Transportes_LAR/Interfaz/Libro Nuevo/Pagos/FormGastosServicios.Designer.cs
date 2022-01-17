/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 28/03/2017
 * Time: 02:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormGastosServicios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGastosServicios));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.cmbBusqueda = new System.Windows.Forms.ComboBox();
			this.cbTodos = new System.Windows.Forms.CheckBox();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpIncio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgRelacion = new System.Windows.Forms.DataGridView();
			this.id_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONTACTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Foraneo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_REGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD_UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIOU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_COTIZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CASETAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OTROS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtOtros = new System.Windows.Forms.TextBox();
			this.txtDinero = new System.Windows.Forms.TextBox();
			this.txtCasetas = new System.Windows.Forms.TextBox();
			this.txtViajes = new System.Windows.Forms.TextBox();
			this.txtDiesel = new System.Windows.Forms.TextBox();
			this.txtViajesValidados = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtGastos = new System.Windows.Forms.TextBox();
			this.btnExcel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Controls.Add(this.bntBuscar);
			this.groupBox1.Controls.Add(this.cmbBusqueda);
			this.groupBox1.Controls.Add(this.cbTodos);
			this.groupBox1.Controls.Add(this.dtpFin);
			this.groupBox1.Controls.Add(this.dtpIncio);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1086, 62);
			this.groupBox1.TabIndex = 72;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(139, 24);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(147, 20);
			this.txtBusqueda.TabIndex = 65;
			// 
			// bntBuscar
			// 
			this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
			this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bntBuscar.Location = new System.Drawing.Point(985, 10);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(95, 45);
			this.bntBuscar.TabIndex = 60;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.BntBuscarClick);
			// 
			// cmbBusqueda
			// 
			this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBusqueda.FormattingEnabled = true;
			this.cmbBusqueda.Items.AddRange(new object[] {
									"ID_RE",
									"CONTACTO",
									"COMPANIA",
									"EVENTO"});
			this.cmbBusqueda.Location = new System.Drawing.Point(6, 22);
			this.cmbBusqueda.Name = "cmbBusqueda";
			this.cmbBusqueda.Size = new System.Drawing.Size(128, 24);
			this.cmbBusqueda.TabIndex = 62;
			this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CmbBusquedaSelectedIndexChanged);
			// 
			// cbTodos
			// 
			this.cbTodos.Location = new System.Drawing.Point(674, 24);
			this.cbTodos.Name = "cbTodos";
			this.cbTodos.Size = new System.Drawing.Size(92, 24);
			this.cbTodos.TabIndex = 0;
			this.cbTodos.Text = "Todos";
			this.cbTodos.UseVisualStyleBackColor = true;
			this.cbTodos.CheckedChanged += new System.EventHandler(this.CbTodosCheckedChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Enabled = false;
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(553, 24);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 22);
			this.dtpFin.TabIndex = 3;
			// 
			// dtpIncio
			// 
			this.dtpIncio.Enabled = false;
			this.dtpIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIncio.Location = new System.Drawing.Point(424, 24);
			this.dtpIncio.Name = "dtpIncio";
			this.dtpIncio.Size = new System.Drawing.Size(100, 22);
			this.dtpIncio.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(527, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 19);
			this.label5.TabIndex = 19;
			this.label5.Text = "al";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(311, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 15);
			this.label6.TabIndex = 18;
			this.label6.Text = "Salida del Viaje:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
									this.ID_C,
									this.OP,
									this.CONTACTO,
									this.CLIENTE,
									this.DESTINO,
									this.Foraneo,
									this.FECHA_SALIDA,
									this.FECHA_REGRESO,
									this.fAC,
									this.CANTIDAD_UNIDAD,
									this.PRECIOU,
									this.PRECIO_COTIZADO,
									this.CASETAS,
									this.DIESEL,
									this.OTROS,
									this.TOTAL,
									this.ENTRADA,
									this.SALIR});
			this.dgRelacion.Location = new System.Drawing.Point(8, 69);
			this.dgRelacion.Name = "dgRelacion";
			this.dgRelacion.ReadOnly = true;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRelacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgRelacion.RowHeadersVisible = false;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgRelacion.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgRelacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgRelacion.Size = new System.Drawing.Size(1082, 421);
			this.dgRelacion.TabIndex = 71;
			// 
			// id_re
			// 
			this.id_re.FillWeight = 18.14305F;
			this.id_re.HeaderText = "ID_RE";
			this.id_re.Name = "id_re";
			this.id_re.ReadOnly = true;
			// 
			// ID_C
			// 
			this.ID_C.HeaderText = "ID_C";
			this.ID_C.Name = "ID_C";
			this.ID_C.ReadOnly = true;
			this.ID_C.Visible = false;
			// 
			// OP
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OP.DefaultCellStyle = dataGridViewCellStyle2;
			this.OP.FillWeight = 50F;
			this.OP.HeaderText = "TIPO COBRO";
			this.OP.Name = "OP";
			this.OP.ReadOnly = true;
			this.OP.Visible = false;
			// 
			// CONTACTO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.CONTACTO.DefaultCellStyle = dataGridViewCellStyle3;
			this.CONTACTO.FillWeight = 50F;
			this.CONTACTO.HeaderText = "CONTACTO";
			this.CONTACTO.Name = "CONTACTO";
			this.CONTACTO.ReadOnly = true;
			// 
			// CLIENTE
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle4;
			this.CLIENTE.FillWeight = 50F;
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			// 
			// DESTINO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.DESTINO.DefaultCellStyle = dataGridViewCellStyle5;
			this.DESTINO.FillWeight = 90F;
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			// 
			// Foraneo
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Foraneo.DefaultCellStyle = dataGridViewCellStyle6;
			this.Foraneo.FillWeight = 15F;
			this.Foraneo.HeaderText = "F";
			this.Foraneo.Name = "Foraneo";
			this.Foraneo.ReadOnly = true;
			// 
			// FECHA_SALIDA
			// 
			this.FECHA_SALIDA.FillWeight = 30F;
			this.FECHA_SALIDA.HeaderText = "FECHA SALIDA";
			this.FECHA_SALIDA.Name = "FECHA_SALIDA";
			this.FECHA_SALIDA.ReadOnly = true;
			// 
			// FECHA_REGRESO
			// 
			this.FECHA_REGRESO.FillWeight = 30F;
			this.FECHA_REGRESO.HeaderText = "FECHA REGRESO";
			this.FECHA_REGRESO.Name = "FECHA_REGRESO";
			this.FECHA_REGRESO.ReadOnly = true;
			// 
			// fAC
			// 
			this.fAC.FillWeight = 35F;
			this.fAC.HeaderText = "FACTURA";
			this.fAC.Name = "fAC";
			this.fAC.ReadOnly = true;
			// 
			// CANTIDAD_UNIDAD
			// 
			this.CANTIDAD_UNIDAD.FillWeight = 14.68944F;
			this.CANTIDAD_UNIDAD.HeaderText = "C.U";
			this.CANTIDAD_UNIDAD.Name = "CANTIDAD_UNIDAD";
			this.CANTIDAD_UNIDAD.ReadOnly = true;
			// 
			// PRECIOU
			// 
			this.PRECIOU.FillWeight = 36F;
			this.PRECIOU.HeaderText = "PRECIO UNITARIO";
			this.PRECIOU.Name = "PRECIOU";
			this.PRECIOU.ReadOnly = true;
			// 
			// PRECIO_COTIZADO
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.PRECIO_COTIZADO.DefaultCellStyle = dataGridViewCellStyle7;
			this.PRECIO_COTIZADO.FillWeight = 36.72361F;
			this.PRECIO_COTIZADO.HeaderText = "TOTAL";
			this.PRECIO_COTIZADO.Name = "PRECIO_COTIZADO";
			this.PRECIO_COTIZADO.ReadOnly = true;
			// 
			// CASETAS
			// 
			this.CASETAS.FillWeight = 40F;
			this.CASETAS.HeaderText = "CASETAS";
			this.CASETAS.Name = "CASETAS";
			this.CASETAS.ReadOnly = true;
			// 
			// DIESEL
			// 
			this.DIESEL.FillWeight = 40F;
			this.DIESEL.HeaderText = "DIESEL";
			this.DIESEL.Name = "DIESEL";
			this.DIESEL.ReadOnly = true;
			// 
			// OTROS
			// 
			this.OTROS.FillWeight = 40F;
			this.OTROS.HeaderText = "OTROS";
			this.OTROS.Name = "OTROS";
			this.OTROS.ReadOnly = true;
			// 
			// TOTAL
			// 
			this.TOTAL.FillWeight = 50F;
			this.TOTAL.HeaderText = "TOTAL GASTOS";
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			// 
			// ENTRADA
			// 
			this.ENTRADA.HeaderText = "ENTRADA";
			this.ENTRADA.Name = "ENTRADA";
			this.ENTRADA.ReadOnly = true;
			this.ENTRADA.Visible = false;
			// 
			// SALIR
			// 
			this.SALIR.HeaderText = "SALIDA";
			this.SALIR.Name = "SALIR";
			this.SALIR.ReadOnly = true;
			this.SALIR.Visible = false;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(11, 513);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 20);
			this.label7.TabIndex = 85;
			this.label7.Text = "Totales:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(298, 493);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 84;
			this.label1.Text = "$";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(404, 493);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 18);
			this.label2.TabIndex = 83;
			this.label2.Text = "Gasto Casetas";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(510, 493);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 18);
			this.label4.TabIndex = 82;
			this.label4.Text = "Gasto Diesel";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(616, 494);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 18);
			this.label3.TabIndex = 81;
			this.label3.Text = "Gasto Otros";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(192, 493);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 18);
			this.label8.TabIndex = 80;
			this.label8.Text = "Viajes Validados";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(86, 493);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 18);
			this.label9.TabIndex = 79;
			this.label9.Text = "Viajes";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtOtros
			// 
			this.txtOtros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOtros.Location = new System.Drawing.Point(616, 515);
			this.txtOtros.Name = "txtOtros";
			this.txtOtros.Size = new System.Drawing.Size(100, 20);
			this.txtOtros.TabIndex = 78;
			this.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDinero
			// 
			this.txtDinero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDinero.Location = new System.Drawing.Point(298, 515);
			this.txtDinero.Name = "txtDinero";
			this.txtDinero.Size = new System.Drawing.Size(100, 20);
			this.txtDinero.TabIndex = 77;
			this.txtDinero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCasetas
			// 
			this.txtCasetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtCasetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCasetas.Location = new System.Drawing.Point(404, 515);
			this.txtCasetas.Name = "txtCasetas";
			this.txtCasetas.Size = new System.Drawing.Size(100, 20);
			this.txtCasetas.TabIndex = 76;
			this.txtCasetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtViajes
			// 
			this.txtViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtViajes.Location = new System.Drawing.Point(86, 515);
			this.txtViajes.Name = "txtViajes";
			this.txtViajes.Size = new System.Drawing.Size(100, 20);
			this.txtViajes.TabIndex = 73;
			this.txtViajes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDiesel
			// 
			this.txtDiesel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiesel.Location = new System.Drawing.Point(510, 515);
			this.txtDiesel.Name = "txtDiesel";
			this.txtDiesel.Size = new System.Drawing.Size(100, 20);
			this.txtDiesel.TabIndex = 75;
			this.txtDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtViajesValidados
			// 
			this.txtViajesValidados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtViajesValidados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtViajesValidados.Location = new System.Drawing.Point(192, 515);
			this.txtViajesValidados.Name = "txtViajesValidados";
			this.txtViajesValidados.Size = new System.Drawing.Size(100, 20);
			this.txtViajesValidados.TabIndex = 74;
			this.txtViajesValidados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(722, 494);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 18);
			this.label10.TabIndex = 87;
			this.label10.Text = "Gastos";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtGastos
			// 
			this.txtGastos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGastos.Location = new System.Drawing.Point(722, 515);
			this.txtGastos.Name = "txtGastos";
			this.txtGastos.Size = new System.Drawing.Size(100, 20);
			this.txtGastos.TabIndex = 86;
			this.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.AutoSize = true;
			this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.Location = new System.Drawing.Point(1047, 496);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(39, 44);
			this.btnExcel.TabIndex = 66;
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// FormGastosServicios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 542);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtGastos);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtOtros);
			this.Controls.Add(this.txtDinero);
			this.Controls.Add(this.txtCasetas);
			this.Controls.Add(this.txtViajes);
			this.Controls.Add(this.txtDiesel);
			this.Controls.Add(this.txtViajesValidados);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgRelacion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormGastosServicios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gastos de Servicios";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGastosServiciosFormClosing);
			this.Load += new System.EventHandler(this.FormGastosServiciosLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.TextBox txtGastos;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtViajesValidados;
		private System.Windows.Forms.TextBox txtDiesel;
		private System.Windows.Forms.TextBox txtViajes;
		private System.Windows.Forms.TextBox txtCasetas;
		private System.Windows.Forms.TextBox txtDinero;
		private System.Windows.Forms.TextBox txtOtros;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridViewTextBoxColumn fAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIOU;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALIR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ENTRADA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Foraneo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn OTROS;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIESEL;
		private System.Windows.Forms.DataGridViewTextBoxColumn CASETAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_UNIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COTIZADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGRESO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONTACTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OP;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_C;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_re;
		public System.Windows.Forms.DataGridView dgRelacion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIncio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.CheckBox cbTodos;
		private System.Windows.Forms.ComboBox cmbBusqueda;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
