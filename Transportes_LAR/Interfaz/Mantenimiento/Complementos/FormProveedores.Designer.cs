/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 02/01/2015
 * Hora: 06:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	partial class FormProveedores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedores));
			this.dataProveedores = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbActivos = new System.Windows.Forms.Label();
			this.lbInactivos = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
			this.txtBuscarComo = new System.Windows.Forms.TextBox();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.cmbClase = new System.Windows.Forms.ComboBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtContacto = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPlazoCredito = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAtencion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNombreCom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRFC = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tProveedores = new System.Windows.Forms.ToolStrip();
			this.btnNuevo = new System.Windows.Forms.ToolStripButton();
			this.btnAgregar = new System.Windows.Forms.ToolStripButton();
			this.btnModificar = new System.Windows.Forms.ToolStripButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataProveedores)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.tProveedores.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataProveedores
			// 
			this.dataProveedores.AllowUserToAddRows = false;
			this.dataProveedores.AllowUserToResizeRows = false;
			this.dataProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataProveedores.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Producto,
									this.Clave,
									this.Nombre,
									this.NombreComercial,
									this.Atencion,
									this.Plazo,
									this.Clase,
									this.Telefono,
									this.Contacto,
									this.Direccion,
									this.RFC,
									this.Descripcion,
									this.Email,
									this.Estatus,
									this.Eliminar,
									this.Quitar});
			this.dataProveedores.Location = new System.Drawing.Point(12, 223);
			this.dataProveedores.Name = "dataProveedores";
			this.dataProveedores.RowHeadersVisible = false;
			this.dataProveedores.Size = new System.Drawing.Size(933, 324);
			this.dataProveedores.TabIndex = 6;
			this.dataProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProveedoresCellClick);
			this.dataProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProveedoresCellContentClick);
			this.dataProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataProveedoresCellPainting);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.lbActivos);
			this.groupBox2.Controls.Add(this.lbInactivos);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.cmbBuscarPor);
			this.groupBox2.Controls.Add(this.txtBuscarComo);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(11, 172);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(934, 45);
			this.groupBox2.TabIndex = 157;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Busqueda de Proveedor";
			// 
			// lbActivos
			// 
			this.lbActivos.BackColor = System.Drawing.Color.Transparent;
			this.lbActivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbActivos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbActivos.Location = new System.Drawing.Point(726, 20);
			this.lbActivos.Name = "lbActivos";
			this.lbActivos.Size = new System.Drawing.Size(60, 15);
			this.lbActivos.TabIndex = 187;
			this.lbActivos.Text = "0";
			this.lbActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbInactivos
			// 
			this.lbInactivos.BackColor = System.Drawing.Color.Transparent;
			this.lbInactivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbInactivos.Location = new System.Drawing.Point(868, 20);
			this.lbInactivos.Name = "lbInactivos";
			this.lbInactivos.Size = new System.Drawing.Size(60, 15);
			this.lbInactivos.TabIndex = 185;
			this.lbInactivos.Text = "0";
			this.lbInactivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(802, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(60, 15);
			this.label15.TabIndex = 186;
			this.label15.Text = "Inactivos:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(660, 20);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 15);
			this.label16.TabIndex = 184;
			this.label16.Text = "Activos:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(177, 20);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(75, 15);
			this.label13.TabIndex = 147;
			this.label13.Text = "Buscar como:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(8, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(65, 15);
			this.label14.TabIndex = 146;
			this.label14.Text = "Buscar por:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbBuscarPor
			// 
			this.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBuscarPor.FormattingEnabled = true;
			this.cmbBuscarPor.Items.AddRange(new object[] {
									"Clave",
									"Proveedor",
									"Nombre Comercial",
									"Atencion",
									"Plazo de Credito",
									"Clase",
									"Telefono",
									"Contacto",
									"Direccion",
									"RFC",
									"E-mail"});
			this.cmbBuscarPor.Location = new System.Drawing.Point(78, 17);
			this.cmbBuscarPor.Name = "cmbBuscarPor";
			this.cmbBuscarPor.Size = new System.Drawing.Size(77, 22);
			this.cmbBuscarPor.TabIndex = 13;
			this.cmbBuscarPor.TabStop = false;
			this.cmbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.CmbBuscarProveedorSelectedIndexChanged);
			// 
			// txtBuscarComo
			// 
			this.txtBuscarComo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBuscarComo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscarComo.Location = new System.Drawing.Point(260, 18);
			this.txtBuscarComo.Name = "txtBuscarComo";
			this.txtBuscarComo.Size = new System.Drawing.Size(369, 20);
			this.txtBuscarComo.TabIndex = 14;
			this.txtBuscarComo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombreBusquedaKeyUp);
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.cmbClase);
			this.groupBox18.Controls.Add(this.txtEmail);
			this.groupBox18.Controls.Add(this.label12);
			this.groupBox18.Controls.Add(this.label11);
			this.groupBox18.Controls.Add(this.txtContacto);
			this.groupBox18.Controls.Add(this.label9);
			this.groupBox18.Controls.Add(this.txtPlazoCredito);
			this.groupBox18.Controls.Add(this.label8);
			this.groupBox18.Controls.Add(this.label7);
			this.groupBox18.Controls.Add(this.txtAtencion);
			this.groupBox18.Controls.Add(this.label6);
			this.groupBox18.Controls.Add(this.txtNombreCom);
			this.groupBox18.Controls.Add(this.label4);
			this.groupBox18.Controls.Add(this.txtClave);
			this.groupBox18.Controls.Add(this.label3);
			this.groupBox18.Controls.Add(this.txtDireccion);
			this.groupBox18.Controls.Add(this.label2);
			this.groupBox18.Controls.Add(this.txtTelefono);
			this.groupBox18.Controls.Add(this.label1);
			this.groupBox18.Controls.Add(this.txtRFC);
			this.groupBox18.Controls.Add(this.label10);
			this.groupBox18.Controls.Add(this.txtNombre);
			this.groupBox18.Controls.Add(this.txtDescripcion);
			this.groupBox18.Controls.Add(this.label5);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(12, 34);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(933, 136);
			this.groupBox18.TabIndex = 156;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Detalle Proveedor";
			// 
			// cmbClase
			// 
			this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClase.FormattingEnabled = true;
			this.cmbClase.Items.AddRange(new object[] {
									"Refacciones",
									"Servicio"});
			this.cmbClase.Location = new System.Drawing.Point(438, 42);
			this.cmbClase.Name = "cmbClase";
			this.cmbClase.Size = new System.Drawing.Size(190, 22);
			this.cmbClase.TabIndex = 6;
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Location = new System.Drawing.Point(694, 101);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(232, 20);
			this.txtEmail.TabIndex = 12;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(638, 102);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 15);
			this.label12.TabIndex = 162;
			this.label12.Text = "E-mail";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(638, 74);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(50, 15);
			this.label11.TabIndex = 161;
			this.label11.Text = "Contacto";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtContacto
			// 
			this.txtContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContacto.Location = new System.Drawing.Point(694, 71);
			this.txtContacto.Name = "txtContacto";
			this.txtContacto.Size = new System.Drawing.Size(232, 20);
			this.txtContacto.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(397, 45);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 15);
			this.label9.TabIndex = 159;
			this.label9.Text = "Clase";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPlazoCredito
			// 
			this.txtPlazoCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPlazoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPlazoCredito.Location = new System.Drawing.Point(314, 43);
			this.txtPlazoCredito.Name = "txtPlazoCredito";
			this.txtPlazoCredito.Size = new System.Drawing.Size(71, 20);
			this.txtPlazoCredito.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(223, 45);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 15);
			this.label8.TabIndex = 156;
			this.label8.Text = "Plazo de credito";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(18, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 15);
			this.label7.TabIndex = 155;
			this.label7.Text = "Atención";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAtencion
			// 
			this.txtAtencion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAtencion.Location = new System.Drawing.Point(77, 43);
			this.txtAtencion.Name = "txtAtencion";
			this.txtAtencion.Size = new System.Drawing.Size(140, 20);
			this.txtAtencion.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(522, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 15);
			this.label6.TabIndex = 153;
			this.label6.Text = "Nombre comercial";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNombreCom
			// 
			this.txtNombreCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombreCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombreCom.Location = new System.Drawing.Point(627, 16);
			this.txtNombreCom.Name = "txtNombreCom";
			this.txtNombreCom.Size = new System.Drawing.Size(300, 20);
			this.txtNombreCom.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 15);
			this.label4.TabIndex = 151;
			this.label4.Text = "Clave";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtClave
			// 
			this.txtClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClave.Location = new System.Drawing.Point(77, 16);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(67, 20);
			this.txtClave.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 149;
			this.label3.Text = "Dirreción";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDireccion.Location = new System.Drawing.Point(77, 71);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(308, 20);
			this.txtDireccion.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(640, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 147;
			this.label2.Text = "Telefono";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTelefono.Location = new System.Drawing.Point(694, 43);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(232, 20);
			this.txtTelefono.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(398, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 18);
			this.label1.TabIndex = 145;
			this.label1.Text = "RFC";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtRFC
			// 
			this.txtRFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRFC.Location = new System.Drawing.Point(438, 71);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(190, 20);
			this.txtRFC.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(154, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 15);
			this.label10.TabIndex = 143;
			this.label10.Text = "Proveedor";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Location = new System.Drawing.Point(215, 17);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(300, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcion.Location = new System.Drawing.Point(77, 98);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(551, 23);
			this.txtDescripcion.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 17);
			this.label5.TabIndex = 143;
			this.label5.Text = "Descripción";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tProveedores
			// 
			this.tProveedores.BackColor = System.Drawing.SystemColors.Menu;
			this.tProveedores.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tProveedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnNuevo,
									this.btnAgregar,
									this.btnModificar});
			this.tProveedores.Location = new System.Drawing.Point(0, 0);
			this.tProveedores.Name = "tProveedores";
			this.tProveedores.Size = new System.Drawing.Size(957, 25);
			this.tProveedores.TabIndex = 160;
			this.tProveedores.Text = "toolStrip1";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(61, 22);
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(72, 22);
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(78, 22);
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// ID_Producto
			// 
			this.ID_Producto.HeaderText = "ID_Proveedor";
			this.ID_Producto.Name = "ID_Producto";
			this.ID_Producto.Visible = false;
			this.ID_Producto.Width = 78;
			// 
			// Clave
			// 
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.Width = 59;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Proveedor";
			this.Nombre.Name = "Nombre";
			this.Nombre.Width = 82;
			// 
			// NombreComercial
			// 
			this.NombreComercial.HeaderText = "Nombre comercial";
			this.NombreComercial.Name = "NombreComercial";
			this.NombreComercial.Width = 108;
			// 
			// Atencion
			// 
			this.Atencion.HeaderText = "Atención";
			this.Atencion.Name = "Atencion";
			this.Atencion.Width = 75;
			// 
			// Plazo
			// 
			this.Plazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Plazo.HeaderText = "Plazo credito";
			this.Plazo.Name = "Plazo";
			this.Plazo.Width = 65;
			// 
			// Clase
			// 
			this.Clase.HeaderText = "Clase";
			this.Clase.Name = "Clase";
			this.Clase.Width = 59;
			// 
			// Telefono
			// 
			this.Telefono.HeaderText = "Télefono";
			this.Telefono.Name = "Telefono";
			this.Telefono.Width = 74;
			// 
			// Contacto
			// 
			this.Contacto.HeaderText = "Contacto";
			this.Contacto.Name = "Contacto";
			this.Contacto.Width = 75;
			// 
			// Direccion
			// 
			this.Direccion.HeaderText = "Dirección";
			this.Direccion.Name = "Direccion";
			this.Direccion.Width = 77;
			// 
			// RFC
			// 
			this.RFC.HeaderText = "RFC";
			this.RFC.Name = "RFC";
			this.RFC.Width = 52;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Width = 89;
			// 
			// Email
			// 
			this.Email.HeaderText = "E-mail";
			this.Email.Name = "Email";
			this.Email.Width = 60;
			// 
			// Estatus
			// 
			this.Estatus.HeaderText = "Estatus";
			this.Estatus.Name = "Estatus";
			this.Estatus.Visible = false;
			this.Estatus.Width = 68;
			// 
			// Eliminar
			// 
			this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Eliminar.HeaderText = "#";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Eliminar.Width = 38;
			// 
			// Quitar
			// 
			this.Quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Quitar.HeaderText = "#";
			this.Quitar.Name = "Quitar";
			this.Quitar.Width = 38;
			// 
			// FormProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(957, 559);
			this.Controls.Add(this.tProveedores);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.dataProveedores);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProveedores";
			this.Text = "FormProveedores";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormProveedoresLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataProveedores)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.tProveedores.ResumeLayout(false);
			this.tProveedores.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lbInactivos;
		private System.Windows.Forms.Label lbActivos;
		private System.Windows.Forms.DataGridViewButtonColumn Quitar;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbClase;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombreCom;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAtencion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPlazoCredito;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtContacto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
		private System.Windows.Forms.DataGridViewTextBoxColumn Plazo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Atencion;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreComercial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.ComboBox cmbBuscarPor;
		private System.Windows.Forms.ToolStripButton btnModificar;
		private System.Windows.Forms.ToolStripButton btnAgregar;
		private System.Windows.Forms.ToolStripButton btnNuevo;
		private System.Windows.Forms.ToolStrip tProveedores;
		private System.Windows.Forms.TextBox txtRFC;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.TextBox txtBuscarComo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
		private System.Windows.Forms.DataGridView dataProveedores;
	}
}
