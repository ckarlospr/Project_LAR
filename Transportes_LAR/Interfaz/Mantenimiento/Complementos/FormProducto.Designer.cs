/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 02/01/2015
 * Hora: 06:25 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	partial class FormProducto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
			this.dataProducto = new System.Windows.Forms.DataGridView();
			this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pieza = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Medicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noserie = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.c_activar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.txtGrupo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNoSerie = new System.Windows.Forms.TextBox();
			this.lbCod6 = new System.Windows.Forms.Label();
			this.lbCod5 = new System.Windows.Forms.Label();
			this.lbCod4 = new System.Windows.Forms.Label();
			this.lbCod3 = new System.Windows.Forms.Label();
			this.lbCod2 = new System.Windows.Forms.Label();
			this.lbCod1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbMetrica = new System.Windows.Forms.ComboBox();
			this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtArticulo = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbActivos = new System.Windows.Forms.Label();
			this.lbInactivos = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButtonMayor = new System.Windows.Forms.RadioButton();
			this.radioButtonMenor = new System.Windows.Forms.RadioButton();
			this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
			this.txtBuscarComo = new System.Windows.Forms.TextBox();
			this.tProducto = new System.Windows.Forms.ToolStrip();
			this.btnNuevo = new System.Windows.Forms.ToolStripButton();
			this.btnAgregar = new System.Windows.Forms.ToolStripButton();
			this.btnModificar = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dataProducto)).BeginInit();
			this.groupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tProducto.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataProducto
			// 
			this.dataProducto.AllowUserToAddRows = false;
			this.dataProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataProducto.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Producto,
									this.Pieza,
									this.Marca,
									this.Modelo,
									this.Aplicacion,
									this.TipoVehiculo,
									this.Cantidad,
									this.Medicion,
									this.Estatus,
									this.Grupo,
									this.noserie,
									this.Codigo_Barras,
									this.Eliminar,
									this.c_activar});
			this.dataProducto.Location = new System.Drawing.Point(12, 161);
			this.dataProducto.Name = "dataProducto";
			this.dataProducto.RowHeadersVisible = false;
			this.dataProducto.Size = new System.Drawing.Size(1099, 344);
			this.dataProducto.TabIndex = 5;
			this.dataProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProductoCellContentClick);
			this.dataProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProductoCellDoubleClick);
			this.dataProducto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataProductoCellPainting);
			// 
			// ID_Producto
			// 
			this.ID_Producto.HeaderText = "ID";
			this.ID_Producto.Name = "ID_Producto";
			this.ID_Producto.Visible = false;
			this.ID_Producto.Width = 22;
			// 
			// Pieza
			// 
			this.Pieza.HeaderText = "Articulo";
			this.Pieza.Name = "Pieza";
			this.Pieza.ReadOnly = true;
			this.Pieza.Width = 69;
			// 
			// Marca
			// 
			this.Marca.HeaderText = "Marca";
			this.Marca.Name = "Marca";
			this.Marca.ReadOnly = true;
			this.Marca.Width = 62;
			// 
			// Modelo
			// 
			this.Modelo.HeaderText = "Modelo";
			this.Modelo.Name = "Modelo";
			this.Modelo.ReadOnly = true;
			this.Modelo.Width = 66;
			// 
			// Aplicacion
			// 
			this.Aplicacion.HeaderText = "Observaciones";
			this.Aplicacion.Name = "Aplicacion";
			this.Aplicacion.ReadOnly = true;
			this.Aplicacion.Width = 106;
			// 
			// TipoVehiculo
			// 
			this.TipoVehiculo.HeaderText = "Tipo de vehículo";
			this.TipoVehiculo.Name = "TipoVehiculo";
			this.TipoVehiculo.ReadOnly = true;
			this.TipoVehiculo.Width = 101;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Existencias";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Width = 87;
			// 
			// Medicion
			// 
			this.Medicion.HeaderText = "U. Metrica";
			this.Medicion.Name = "Medicion";
			this.Medicion.ReadOnly = true;
			this.Medicion.Width = 74;
			// 
			// Estatus
			// 
			this.Estatus.HeaderText = "Estatus";
			this.Estatus.Name = "Estatus";
			this.Estatus.ReadOnly = true;
			this.Estatus.Visible = false;
			this.Estatus.Width = 68;
			// 
			// Grupo
			// 
			this.Grupo.HeaderText = "Grupo";
			this.Grupo.Name = "Grupo";
			this.Grupo.ReadOnly = true;
			this.Grupo.Width = 62;
			// 
			// noserie
			// 
			this.noserie.HeaderText = "No. Serie original";
			this.noserie.Name = "noserie";
			this.noserie.ReadOnly = true;
			this.noserie.Width = 104;
			// 
			// Codigo_Barras
			// 
			this.Codigo_Barras.HeaderText = "Codigo de barras";
			this.Codigo_Barras.Name = "Codigo_Barras";
			this.Codigo_Barras.ReadOnly = true;
			this.Codigo_Barras.Width = 105;
			// 
			// Eliminar
			// 
			this.Eliminar.HeaderText = "#";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Eliminar.Width = 38;
			// 
			// c_activar
			// 
			this.c_activar.HeaderText = "#";
			this.c_activar.Name = "c_activar";
			this.c_activar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.c_activar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.c_activar.Width = 38;
			// 
			// groupBox18
			// 
			this.groupBox18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.txtGrupo);
			this.groupBox18.Controls.Add(this.label4);
			this.groupBox18.Controls.Add(this.label2);
			this.groupBox18.Controls.Add(this.txtNoSerie);
			this.groupBox18.Controls.Add(this.lbCod6);
			this.groupBox18.Controls.Add(this.lbCod5);
			this.groupBox18.Controls.Add(this.lbCod4);
			this.groupBox18.Controls.Add(this.lbCod3);
			this.groupBox18.Controls.Add(this.lbCod2);
			this.groupBox18.Controls.Add(this.lbCod1);
			this.groupBox18.Controls.Add(this.pictureBox1);
			this.groupBox18.Controls.Add(this.cmbMetrica);
			this.groupBox18.Controls.Add(this.cmbTipoVehiculo);
			this.groupBox18.Controls.Add(this.txtObservaciones);
			this.groupBox18.Controls.Add(this.label9);
			this.groupBox18.Controls.Add(this.label8);
			this.groupBox18.Controls.Add(this.label11);
			this.groupBox18.Controls.Add(this.txtModelo);
			this.groupBox18.Controls.Add(this.txtArticulo);
			this.groupBox18.Controls.Add(this.txtMarca);
			this.groupBox18.Controls.Add(this.label7);
			this.groupBox18.Controls.Add(this.label6);
			this.groupBox18.Controls.Add(this.label1);
			this.groupBox18.Controls.Add(this.label10);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(12, 30);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(1099, 74);
			this.groupBox18.TabIndex = 153;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Detalle Producto";
			// 
			// txtGrupo
			// 
			this.txtGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGrupo.Location = new System.Drawing.Point(795, 44);
			this.txtGrupo.Name = "txtGrupo";
			this.txtGrupo.Size = new System.Drawing.Size(78, 20);
			this.txtGrupo.TabIndex = 186;
			this.txtGrupo.Leave += new System.EventHandler(this.TxtGrupoLeave);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(882, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 15);
			this.label4.TabIndex = 204;
			this.label4.Text = "Codigo:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(878, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 203;
			this.label2.Text = "No. Serie:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNoSerie
			// 
			this.txtNoSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNoSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNoSerie.Location = new System.Drawing.Point(934, 15);
			this.txtNoSerie.Name = "txtNoSerie";
			this.txtNoSerie.Size = new System.Drawing.Size(160, 20);
			this.txtNoSerie.TabIndex = 187;
			this.txtNoSerie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNoSerieKeyUp);
			// 
			// lbCod6
			// 
			this.lbCod6.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod6.Location = new System.Drawing.Point(1071, 53);
			this.lbCod6.Name = "lbCod6";
			this.lbCod6.Size = new System.Drawing.Size(20, 12);
			this.lbCod6.TabIndex = 201;
			this.lbCod6.Text = "00";
			this.lbCod6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCod5
			// 
			this.lbCod5.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod5.Location = new System.Drawing.Point(1047, 53);
			this.lbCod5.Name = "lbCod5";
			this.lbCod5.Size = new System.Drawing.Size(20, 12);
			this.lbCod5.TabIndex = 200;
			this.lbCod5.Text = "00";
			this.lbCod5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCod4
			// 
			this.lbCod4.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod4.Location = new System.Drawing.Point(1022, 53);
			this.lbCod4.Name = "lbCod4";
			this.lbCod4.Size = new System.Drawing.Size(20, 12);
			this.lbCod4.TabIndex = 199;
			this.lbCod4.Text = "00";
			this.lbCod4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCod3
			// 
			this.lbCod3.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod3.Location = new System.Drawing.Point(996, 53);
			this.lbCod3.Name = "lbCod3";
			this.lbCod3.Size = new System.Drawing.Size(20, 12);
			this.lbCod3.TabIndex = 198;
			this.lbCod3.Text = "00";
			this.lbCod3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCod2
			// 
			this.lbCod2.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod2.Location = new System.Drawing.Point(970, 53);
			this.lbCod2.Name = "lbCod2";
			this.lbCod2.Size = new System.Drawing.Size(20, 12);
			this.lbCod2.TabIndex = 197;
			this.lbCod2.Text = "00";
			this.lbCod2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbCod1
			// 
			this.lbCod1.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod1.Location = new System.Drawing.Point(939, 53);
			this.lbCod1.Name = "lbCod1";
			this.lbCod1.Size = new System.Drawing.Size(26, 12);
			this.lbCod1.TabIndex = 196;
			this.lbCod1.Text = "000";
			this.lbCod1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(934, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 22);
			this.pictureBox1.TabIndex = 195;
			this.pictureBox1.TabStop = false;
			// 
			// cmbMetrica
			// 
			this.cmbMetrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMetrica.FormattingEnabled = true;
			this.cmbMetrica.Items.AddRange(new object[] {
									"Galón",
									"Litro",
									"Mililitro",
									"Kilogramo",
									"Gramo",
									"Pulgada",
									"Metro",
									"Centímetro",
									"Milímetro"});
			this.cmbMetrica.Location = new System.Drawing.Point(641, 44);
			this.cmbMetrica.Name = "cmbMetrica";
			this.cmbMetrica.Size = new System.Drawing.Size(102, 22);
			this.cmbMetrica.TabIndex = 185;
			// 
			// cmbTipoVehiculo
			// 
			this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoVehiculo.FormattingEnabled = true;
			this.cmbTipoVehiculo.Items.AddRange(new object[] {
									"Opvo. Ligero (Camioneta)",
									"Opvo. Pesado (Camion)",
									"Admin./Utilit. Familia",
									"Admin./Utilit. Empresa"});
			this.cmbTipoVehiculo.Location = new System.Drawing.Point(387, 43);
			this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
			this.cmbTipoVehiculo.Size = new System.Drawing.Size(182, 22);
			this.cmbTipoVehiculo.TabIndex = 184;
			this.cmbTipoVehiculo.Leave += new System.EventHandler(this.CmbTipoVehiculoLeave);
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservaciones.Location = new System.Drawing.Point(102, 44);
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(185, 20);
			this.txtObservaciones.TabIndex = 183;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(293, 46);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 15);
			this.label9.TabIndex = 194;
			this.label9.Text = "Tipo de vehiculo:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(11, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 15);
			this.label8.TabIndex = 193;
			this.label8.Text = "Observaciones:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(575, 46);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 15);
			this.label11.TabIndex = 192;
			this.label11.Text = "U. Metrica:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtModelo
			// 
			this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModelo.Location = new System.Drawing.Point(641, 15);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(232, 20);
			this.txtModelo.TabIndex = 182;
			this.txtModelo.Leave += new System.EventHandler(this.TxtModeloLeave);
			// 
			// txtArticulo
			// 
			this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtArticulo.Location = new System.Drawing.Point(77, 15);
			this.txtArticulo.Name = "txtArticulo";
			this.txtArticulo.Size = new System.Drawing.Size(210, 20);
			this.txtArticulo.TabIndex = 180;
			this.txtArticulo.TabStop = false;
			this.txtArticulo.Leave += new System.EventHandler(this.TxtArticuloLeave);
			// 
			// txtMarca
			// 
			this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMarca.Location = new System.Drawing.Point(359, 15);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(210, 20);
			this.txtMarca.TabIndex = 181;
			this.txtMarca.Leave += new System.EventHandler(this.TxtMarcaLeave);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(575, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 15);
			this.label7.TabIndex = 190;
			this.label7.Text = "Modelo:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(293, 17);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 15);
			this.label6.TabIndex = 189;
			this.label6.Text = "Marca:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(749, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 15);
			this.label1.TabIndex = 188;
			this.label1.Text = "Grupo:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(11, 17);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 15);
			this.label10.TabIndex = 187;
			this.label10.Text = "Articulo:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.lbActivos);
			this.groupBox2.Controls.Add(this.lbInactivos);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.radioButtonMayor);
			this.groupBox2.Controls.Add(this.radioButtonMenor);
			this.groupBox2.Controls.Add(this.cmbBuscarPor);
			this.groupBox2.Controls.Add(this.txtBuscarComo);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 110);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1099, 45);
			this.groupBox2.TabIndex = 155;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filtro de Productos";
			// 
			// lbActivos
			// 
			this.lbActivos.BackColor = System.Drawing.Color.Transparent;
			this.lbActivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbActivos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbActivos.Location = new System.Drawing.Point(879, 17);
			this.lbActivos.Name = "lbActivos";
			this.lbActivos.Size = new System.Drawing.Size(60, 15);
			this.lbActivos.TabIndex = 183;
			this.lbActivos.Text = "0";
			this.lbActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbInactivos
			// 
			this.lbInactivos.BackColor = System.Drawing.Color.Transparent;
			this.lbInactivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbInactivos.Location = new System.Drawing.Point(1033, 17);
			this.lbInactivos.Name = "lbInactivos";
			this.lbInactivos.Size = new System.Drawing.Size(60, 15);
			this.lbInactivos.TabIndex = 181;
			this.lbInactivos.Text = "0";
			this.lbInactivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(950, 17);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(78, 15);
			this.label15.TabIndex = 182;
			this.label15.Text = "Desactivados:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(813, 17);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 15);
			this.label14.TabIndex = 181;
			this.label14.Text = "Activados:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(177, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(75, 15);
			this.label13.TabIndex = 145;
			this.label13.Text = "Buscar como:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 144;
			this.label3.Text = "Buscar por:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radioButtonMayor
			// 
			this.radioButtonMayor.Font = new System.Drawing.Font("Arial", 8.25F);
			this.radioButtonMayor.Location = new System.Drawing.Point(636, 17);
			this.radioButtonMayor.Name = "radioButtonMayor";
			this.radioButtonMayor.Size = new System.Drawing.Size(65, 20);
			this.radioButtonMayor.TabIndex = 12;
			this.radioButtonMayor.TabStop = true;
			this.radioButtonMayor.Text = "Mayor a";
			this.radioButtonMayor.UseVisualStyleBackColor = true;
			this.radioButtonMayor.CheckedChanged += new System.EventHandler(this.RadioButtonMayorCheckedChanged);
			// 
			// radioButtonMenor
			// 
			this.radioButtonMenor.Font = new System.Drawing.Font("Arial", 8.25F);
			this.radioButtonMenor.Location = new System.Drawing.Point(557, 17);
			this.radioButtonMenor.Name = "radioButtonMenor";
			this.radioButtonMenor.Size = new System.Drawing.Size(65, 20);
			this.radioButtonMenor.TabIndex = 11;
			this.radioButtonMenor.TabStop = true;
			this.radioButtonMenor.Text = "Menor a";
			this.radioButtonMenor.UseVisualStyleBackColor = true;
			this.radioButtonMenor.CheckedChanged += new System.EventHandler(this.RadioButtonMenorCheckedChanged);
			// 
			// cmbBuscarPor
			// 
			this.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBuscarPor.FormattingEnabled = true;
			this.cmbBuscarPor.Items.AddRange(new object[] {
									"Articulo",
									"Marca",
									"Modelo",
									"Tipo de vehiculo",
									"Existencias",
									"Grupo",
									"No de serie"});
			this.cmbBuscarPor.Location = new System.Drawing.Point(79, 16);
			this.cmbBuscarPor.Name = "cmbBuscarPor";
			this.cmbBuscarPor.Size = new System.Drawing.Size(88, 22);
			this.cmbBuscarPor.TabIndex = 11;
			this.cmbBuscarPor.TabStop = false;
			this.cmbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.CmbBuscarProductoSelectedIndexChanged);
			// 
			// txtBuscarComo
			// 
			this.txtBuscarComo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBuscarComo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscarComo.Location = new System.Drawing.Point(258, 17);
			this.txtBuscarComo.Name = "txtBuscarComo";
			this.txtBuscarComo.Size = new System.Drawing.Size(284, 20);
			this.txtBuscarComo.TabIndex = 12;
			this.txtBuscarComo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusquedanombreKeyUp);
			// 
			// tProducto
			// 
			this.tProducto.BackColor = System.Drawing.SystemColors.Menu;
			this.tProducto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnNuevo,
									this.btnAgregar,
									this.btnModificar});
			this.tProducto.Location = new System.Drawing.Point(0, 0);
			this.tProducto.Name = "tProducto";
			this.tProducto.Size = new System.Drawing.Size(1123, 25);
			this.tProducto.TabIndex = 7;
			this.tProducto.Text = "toolStrip1";
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
			// FormProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1123, 517);
			this.Controls.Add(this.tProducto);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox18);
			this.Controls.Add(this.dataProducto);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProducto";
			this.Text = "FormProducto";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormProductoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataProducto)).EndInit();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tProducto.ResumeLayout(false);
			this.tProducto.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtGrupo;
		private System.Windows.Forms.DataGridViewTextBoxColumn noserie;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNoSerie;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbCod6;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lbInactivos;
		private System.Windows.Forms.Label lbActivos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lbCod1;
		private System.Windows.Forms.Label lbCod2;
		private System.Windows.Forms.Label lbCod3;
		private System.Windows.Forms.Label lbCod4;
		private System.Windows.Forms.Label lbCod5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cmbTipoVehiculo;
		private System.Windows.Forms.ComboBox cmbMetrica;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barras;
		private System.Windows.Forms.DataGridViewTextBoxColumn Medicion;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Aplicacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pieza;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton radioButtonMenor;
		private System.Windows.Forms.RadioButton radioButtonMayor;
		private System.Windows.Forms.ComboBox cmbBuscarPor;
		private System.Windows.Forms.DataGridViewButtonColumn c_activar;
		private System.Windows.Forms.ToolStripButton btnModificar;
		private System.Windows.Forms.ToolStripButton btnAgregar;
		private System.Windows.Forms.ToolStripButton btnNuevo;
		private System.Windows.Forms.ToolStrip tProducto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuscarComo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtArticulo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
		private System.Windows.Forms.DataGridView dataProducto;
	}
}
