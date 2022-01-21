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
			this.numeroParte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.lblAgregaGrupo = new System.Windows.Forms.Label();
			this.cmbGrupo = new System.Windows.Forms.ComboBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtNumeroParte = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
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
			this.gbfiltros = new System.Windows.Forms.GroupBox();
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
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.cmdModificar = new System.Windows.Forms.Button();
			this.cmdNuevo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataProducto)).BeginInit();
			this.groupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gbfiltros.SuspendLayout();
			this.tProducto.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataProducto
			// 
			this.dataProducto.AllowUserToAddRows = false;
			this.dataProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
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
									this.c_activar,
									this.numeroParte,
									this.Codigo});
			this.dataProducto.Location = new System.Drawing.Point(346, 112);
			this.dataProducto.Name = "dataProducto";
			this.dataProducto.RowHeadersVisible = false;
			this.dataProducto.Size = new System.Drawing.Size(785, 462);
			this.dataProducto.TabIndex = 17;
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
			this.noserie.Visible = false;
			this.noserie.Width = 104;
			// 
			// Codigo_Barras
			// 
			this.Codigo_Barras.HeaderText = "Codigo de barras";
			this.Codigo_Barras.Name = "Codigo_Barras";
			this.Codigo_Barras.ReadOnly = true;
			this.Codigo_Barras.Visible = false;
			this.Codigo_Barras.Width = 105;
			// 
			// Eliminar
			// 
			this.Eliminar.HeaderText = "#";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Eliminar.Visible = false;
			this.Eliminar.Width = 38;
			// 
			// c_activar
			// 
			this.c_activar.HeaderText = "#";
			this.c_activar.Name = "c_activar";
			this.c_activar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.c_activar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.c_activar.Visible = false;
			this.c_activar.Width = 38;
			// 
			// numeroParte
			// 
			this.numeroParte.HeaderText = "Numero Parte";
			this.numeroParte.Name = "numeroParte";
			this.numeroParte.ReadOnly = true;
			this.numeroParte.Width = 89;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			this.Codigo.Width = 65;
			// 
			// groupBox18
			// 
			this.groupBox18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.lblAgregaGrupo);
			this.groupBox18.Controls.Add(this.cmbGrupo);
			this.groupBox18.Controls.Add(this.txtCodigo);
			this.groupBox18.Controls.Add(this.label12);
			this.groupBox18.Controls.Add(this.txtNumeroParte);
			this.groupBox18.Controls.Add(this.label5);
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
			this.groupBox18.Size = new System.Drawing.Size(241, 545);
			this.groupBox18.TabIndex = 153;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Detalle Producto";
			// 
			// lblAgregaGrupo
			// 
			this.lblAgregaGrupo.BackColor = System.Drawing.Color.Transparent;
			this.lblAgregaGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblAgregaGrupo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAgregaGrupo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblAgregaGrupo.Location = new System.Drawing.Point(133, 358);
			this.lblAgregaGrupo.Name = "lblAgregaGrupo";
			this.lblAgregaGrupo.Size = new System.Drawing.Size(92, 15);
			this.lblAgregaGrupo.TabIndex = 209;
			this.lblAgregaGrupo.Text = "Agregar grupo";
			this.lblAgregaGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblAgregaGrupo.Enter += new System.EventHandler(this.LblAgregaGrupoEnter);
			this.lblAgregaGrupo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblAgregaGrupoMouseClick);
			this.lblAgregaGrupo.MouseEnter += new System.EventHandler(this.LblAgregaGrupoMouseEnter);
			this.lblAgregaGrupo.MouseLeave += new System.EventHandler(this.LblAgregaGrupoMouseLeave);
			// 
			// cmbGrupo
			// 
			this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbGrupo.FormattingEnabled = true;
			this.cmbGrupo.Location = new System.Drawing.Point(133, 334);
			this.cmbGrupo.Name = "cmbGrupo";
			this.cmbGrupo.Size = new System.Drawing.Size(92, 22);
			this.cmbGrupo.TabIndex = 154;
			this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.CmbGrupoSelectedIndexChanged);
			// 
			// txtCodigo
			// 
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigo.Location = new System.Drawing.Point(11, 428);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(214, 20);
			this.txtCodigo.TabIndex = 8;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(11, 412);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 15);
			this.label12.TabIndex = 208;
			this.label12.Text = "Codigo:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNumeroParte
			// 
			this.txtNumeroParte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNumeroParte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumeroParte.Location = new System.Drawing.Point(11, 389);
			this.txtNumeroParte.Name = "txtNumeroParte";
			this.txtNumeroParte.Size = new System.Drawing.Size(214, 20);
			this.txtNumeroParte.TabIndex = 7;
			this.txtNumeroParte.TextChanged += new System.EventHandler(this.TxtNumeroParteTextChanged);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 373);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(143, 15);
			this.label5.TabIndex = 206;
			this.label5.Text = "Numero de Parte:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtGrupo
			// 
			this.txtGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtGrupo.Location = new System.Drawing.Point(152, 481);
			this.txtGrupo.Name = "txtGrupo";
			this.txtGrupo.Size = new System.Drawing.Size(92, 20);
			this.txtGrupo.TabIndex = 6;
			this.txtGrupo.Leave += new System.EventHandler(this.TxtGrupoLeave);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 511);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 15);
			this.label4.TabIndex = 204;
			this.label4.Text = "Codigo:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.Visible = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 461);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 203;
			this.label2.Text = "No. Serie:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Visible = false;
			// 
			// txtNoSerie
			// 
			this.txtNoSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNoSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNoSerie.Location = new System.Drawing.Point(8, 479);
			this.txtNoSerie.Name = "txtNoSerie";
			this.txtNoSerie.Size = new System.Drawing.Size(138, 20);
			this.txtNoSerie.TabIndex = 187;
			this.txtNoSerie.Visible = false;
			this.txtNoSerie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNoSerieKeyUp);
			// 
			// lbCod6
			// 
			this.lbCod6.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod6.Location = new System.Drawing.Point(197, 517);
			this.lbCod6.Name = "lbCod6";
			this.lbCod6.Size = new System.Drawing.Size(20, 12);
			this.lbCod6.TabIndex = 201;
			this.lbCod6.Text = "00";
			this.lbCod6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbCod6.Visible = false;
			// 
			// lbCod5
			// 
			this.lbCod5.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod5.Location = new System.Drawing.Point(173, 517);
			this.lbCod5.Name = "lbCod5";
			this.lbCod5.Size = new System.Drawing.Size(20, 12);
			this.lbCod5.TabIndex = 200;
			this.lbCod5.Text = "00";
			this.lbCod5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbCod5.Visible = false;
			// 
			// lbCod4
			// 
			this.lbCod4.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod4.Location = new System.Drawing.Point(148, 517);
			this.lbCod4.Name = "lbCod4";
			this.lbCod4.Size = new System.Drawing.Size(20, 12);
			this.lbCod4.TabIndex = 199;
			this.lbCod4.Text = "00";
			this.lbCod4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbCod4.Visible = false;
			// 
			// lbCod3
			// 
			this.lbCod3.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod3.Location = new System.Drawing.Point(122, 517);
			this.lbCod3.Name = "lbCod3";
			this.lbCod3.Size = new System.Drawing.Size(20, 12);
			this.lbCod3.TabIndex = 198;
			this.lbCod3.Text = "00";
			this.lbCod3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbCod3.Visible = false;
			// 
			// lbCod2
			// 
			this.lbCod2.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod2.Location = new System.Drawing.Point(96, 517);
			this.lbCod2.Name = "lbCod2";
			this.lbCod2.Size = new System.Drawing.Size(20, 12);
			this.lbCod2.TabIndex = 197;
			this.lbCod2.Text = "00";
			this.lbCod2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbCod2.Visible = false;
			// 
			// lbCod1
			// 
			this.lbCod1.BackColor = System.Drawing.SystemColors.Window;
			this.lbCod1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCod1.Location = new System.Drawing.Point(65, 517);
			this.lbCod1.Name = "lbCod1";
			this.lbCod1.Size = new System.Drawing.Size(26, 12);
			this.lbCod1.TabIndex = 196;
			this.lbCod1.Text = "000";
			this.lbCod1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbCod1.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(60, 507);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 22);
			this.pictureBox1.TabIndex = 195;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
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
									"Milímetro",
									"Unidad"});
			this.cmbMetrica.Location = new System.Drawing.Point(11, 332);
			this.cmbMetrica.Name = "cmbMetrica";
			this.cmbMetrica.Size = new System.Drawing.Size(102, 22);
			this.cmbMetrica.TabIndex = 5;
			this.cmbMetrica.SelectedIndexChanged += new System.EventHandler(this.CmbMetricaSelectedIndexChanged);
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
			this.cmbTipoVehiculo.Location = new System.Drawing.Point(11, 230);
			this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
			this.cmbTipoVehiculo.Size = new System.Drawing.Size(214, 22);
			this.cmbTipoVehiculo.TabIndex = 3;
			this.cmbTipoVehiculo.Leave += new System.EventHandler(this.CmbTipoVehiculoLeave);
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservaciones.Location = new System.Drawing.Point(11, 91);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(214, 62);
			this.txtObservaciones.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 214);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 15);
			this.label9.TabIndex = 194;
			this.label9.Text = "Tipo de vehiculo:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(11, 73);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 15);
			this.label8.TabIndex = 193;
			this.label8.Text = "Descripción:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(11, 316);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 15);
			this.label11.TabIndex = 192;
			this.label11.Text = "U. Metrica:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtModelo
			// 
			this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtModelo.Location = new System.Drawing.Point(11, 283);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(214, 20);
			this.txtModelo.TabIndex = 4;
			this.txtModelo.Leave += new System.EventHandler(this.TxtModeloLeave);
			// 
			// txtArticulo
			// 
			this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtArticulo.Location = new System.Drawing.Point(11, 43);
			this.txtArticulo.Name = "txtArticulo";
			this.txtArticulo.Size = new System.Drawing.Size(214, 20);
			this.txtArticulo.TabIndex = 0;
			this.txtArticulo.TabStop = false;
			this.txtArticulo.Leave += new System.EventHandler(this.TxtArticuloLeave);
			// 
			// txtMarca
			// 
			this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMarca.Location = new System.Drawing.Point(11, 181);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(214, 20);
			this.txtMarca.TabIndex = 2;
			this.txtMarca.Leave += new System.EventHandler(this.TxtMarcaLeave);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(11, 267);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 15);
			this.label7.TabIndex = 190;
			this.label7.Text = "Modelo:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 165);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 15);
			this.label6.TabIndex = 189;
			this.label6.Text = "Marca:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(133, 316);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 15);
			this.label1.TabIndex = 188;
			this.label1.Text = "Grupo:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(11, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 15);
			this.label10.TabIndex = 187;
			this.label10.Text = "Articulo";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbfiltros
			// 
			this.gbfiltros.BackColor = System.Drawing.Color.Transparent;
			this.gbfiltros.Controls.Add(this.lbActivos);
			this.gbfiltros.Controls.Add(this.lbInactivos);
			this.gbfiltros.Controls.Add(this.label15);
			this.gbfiltros.Controls.Add(this.label14);
			this.gbfiltros.Controls.Add(this.label13);
			this.gbfiltros.Controls.Add(this.label3);
			this.gbfiltros.Controls.Add(this.radioButtonMayor);
			this.gbfiltros.Controls.Add(this.radioButtonMenor);
			this.gbfiltros.Controls.Add(this.cmbBuscarPor);
			this.gbfiltros.Controls.Add(this.txtBuscarComo);
			this.gbfiltros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbfiltros.Location = new System.Drawing.Point(346, 30);
			this.gbfiltros.Name = "gbfiltros";
			this.gbfiltros.Size = new System.Drawing.Size(785, 76);
			this.gbfiltros.TabIndex = 12;
			this.gbfiltros.TabStop = false;
			this.gbfiltros.Text = "Filtro de Productos";
			// 
			// lbActivos
			// 
			this.lbActivos.BackColor = System.Drawing.Color.Transparent;
			this.lbActivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbActivos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbActivos.Location = new System.Drawing.Point(452, 52);
			this.lbActivos.Name = "lbActivos";
			this.lbActivos.Size = new System.Drawing.Size(38, 15);
			this.lbActivos.TabIndex = 183;
			this.lbActivos.Text = "0";
			this.lbActivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbInactivos
			// 
			this.lbInactivos.BackColor = System.Drawing.Color.Transparent;
			this.lbInactivos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbInactivos.Location = new System.Drawing.Point(601, 52);
			this.lbInactivos.Name = "lbInactivos";
			this.lbInactivos.Size = new System.Drawing.Size(24, 15);
			this.lbInactivos.TabIndex = 181;
			this.lbInactivos.Text = "0";
			this.lbInactivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(513, 52);
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
			this.label14.Location = new System.Drawing.Point(386, 52);
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
			this.label13.Location = new System.Drawing.Point(12, 49);
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
			this.label3.Location = new System.Drawing.Point(22, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 144;
			this.label3.Text = "Buscar por:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radioButtonMayor
			// 
			this.radioButtonMayor.Font = new System.Drawing.Font("Arial", 8.25F);
			this.radioButtonMayor.Location = new System.Drawing.Point(499, 17);
			this.radioButtonMayor.Name = "radioButtonMayor";
			this.radioButtonMayor.Size = new System.Drawing.Size(65, 20);
			this.radioButtonMayor.TabIndex = 16;
			this.radioButtonMayor.TabStop = true;
			this.radioButtonMayor.Text = "Mayor a";
			this.radioButtonMayor.UseVisualStyleBackColor = true;
			this.radioButtonMayor.CheckedChanged += new System.EventHandler(this.RadioButtonMayorCheckedChanged);
			// 
			// radioButtonMenor
			// 
			this.radioButtonMenor.Font = new System.Drawing.Font("Arial", 8.25F);
			this.radioButtonMenor.Location = new System.Drawing.Point(428, 16);
			this.radioButtonMenor.Name = "radioButtonMenor";
			this.radioButtonMenor.Size = new System.Drawing.Size(65, 20);
			this.radioButtonMenor.TabIndex = 15;
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
			this.cmbBuscarPor.Location = new System.Drawing.Point(93, 19);
			this.cmbBuscarPor.Name = "cmbBuscarPor";
			this.cmbBuscarPor.Size = new System.Drawing.Size(233, 22);
			this.cmbBuscarPor.TabIndex = 13;
			this.cmbBuscarPor.TabStop = false;
			this.cmbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.CmbBuscarProductoSelectedIndexChanged);
			// 
			// txtBuscarComo
			// 
			this.txtBuscarComo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscarComo.Location = new System.Drawing.Point(93, 47);
			this.txtBuscarComo.Name = "txtBuscarComo";
			this.txtBuscarComo.Size = new System.Drawing.Size(233, 20);
			this.txtBuscarComo.TabIndex = 14;
			this.txtBuscarComo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusquedanombreKeyUp);
			// 
			// tProducto
			// 
			this.tProducto.BackColor = System.Drawing.SystemColors.Menu;
			this.tProducto.Enabled = false;
			this.tProducto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnNuevo,
									this.btnAgregar,
									this.btnModificar});
			this.tProducto.Location = new System.Drawing.Point(0, 0);
			this.tProducto.Name = "tProducto";
			this.tProducto.Size = new System.Drawing.Size(1138, 25);
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
			// cmdAgregar
			// 
			this.cmdAgregar.Location = new System.Drawing.Point(265, 491);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
			this.cmdAgregar.TabIndex = 9;
			this.cmdAgregar.Text = "Agregar";
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// cmdModificar
			// 
			this.cmdModificar.Location = new System.Drawing.Point(265, 287);
			this.cmdModificar.Name = "cmdModificar";
			this.cmdModificar.Size = new System.Drawing.Size(75, 23);
			this.cmdModificar.TabIndex = 10;
			this.cmdModificar.Text = "Modificar";
			this.cmdModificar.UseVisualStyleBackColor = true;
			this.cmdModificar.Click += new System.EventHandler(this.CmdModificarClick);
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.Location = new System.Drawing.Point(265, 70);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
			this.cmdNuevo.TabIndex = 11;
			this.cmdNuevo.Text = "Nuevo";
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// FormProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1138, 587);
			this.Controls.Add(this.cmdNuevo);
			this.Controls.Add(this.tProducto);
			this.Controls.Add(this.cmdModificar);
			this.Controls.Add(this.gbfiltros);
			this.Controls.Add(this.cmdAgregar);
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
			this.gbfiltros.ResumeLayout(false);
			this.gbfiltros.PerformLayout();
			this.tProducto.ResumeLayout(false);
			this.tProducto.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblAgregaGrupo;
		private System.Windows.Forms.ComboBox cmbGrupo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroParte;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNumeroParte;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Button cmdNuevo;
		private System.Windows.Forms.Button cmdModificar;
		private System.Windows.Forms.Button cmdAgregar;
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
		private System.Windows.Forms.GroupBox gbfiltros;
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
