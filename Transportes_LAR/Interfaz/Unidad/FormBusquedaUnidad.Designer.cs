/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 26/07/2012
 * Time: 8:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Unidad
{
	partial class FormBusquedaUnidad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusquedaUnidad));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtBusquedaMarca = new System.Windows.Forms.TextBox();
			this.cmbBusquedaTipoServ = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbBusquedaTipoUnidad = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBusquedaFederal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBusquedaEstatal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBusquedaNumero = new System.Windows.Forms.TextBox();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewUnidad = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnidadNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnidadServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlacaEstatal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlacaFederal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_num_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_nombre_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_motor_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_num_serie_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_diferencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_paso_diferencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_tipo_llanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_perimetro_llanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_caja_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_caja_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_u_relacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_torque = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_cap_tanque = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unidad_capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidad)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 33);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(54, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(317, 14);
			this.label6.TabIndex = 15;
			this.label6.Text = "Ingrese los datos de la unidad para realizar la búsqueda:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.btnNuevo);
			this.panel2.Controls.Add(this.btnModificar);
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(9, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(823, 159);
			this.panel2.TabIndex = 14;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtBusquedaMarca);
			this.groupBox2.Controls.Add(this.cmbBusquedaTipoServ);
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.cmbBusquedaTipoUnidad);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(260, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(242, 108);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filtro detalles de unidad";
			// 
			// txtBusquedaMarca
			// 
			this.txtBusquedaMarca.Location = new System.Drawing.Point(84, 47);
			this.txtBusquedaMarca.Name = "txtBusquedaMarca";
			this.txtBusquedaMarca.Size = new System.Drawing.Size(147, 20);
			this.txtBusquedaMarca.TabIndex = 1;
			this.txtBusquedaMarca.TextChanged += new System.EventHandler(this.TxtBusquedaNumeroTextChanged);
			// 
			// cmbBusquedaTipoServ
			// 
			this.cmbBusquedaTipoServ.FormattingEnabled = true;
			this.cmbBusquedaTipoServ.Items.AddRange(new object[] {
									"Local",
									"Foraneo"});
			this.cmbBusquedaTipoServ.Location = new System.Drawing.Point(84, 73);
			this.cmbBusquedaTipoServ.Name = "cmbBusquedaTipoServ";
			this.cmbBusquedaTipoServ.Size = new System.Drawing.Size(147, 22);
			this.cmbBusquedaTipoServ.TabIndex = 2;
			this.cmbBusquedaTipoServ.TextChanged += new System.EventHandler(this.TxtBusquedaNumeroTextChanged);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(6, 76);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(72, 14);
			this.label29.TabIndex = 8;
			this.label29.Text = "Tipo Servicio:";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 14);
			this.label5.TabIndex = 2;
			this.label5.Text = "Marca:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbBusquedaTipoUnidad
			// 
			this.cmbBusquedaTipoUnidad.FormattingEnabled = true;
			this.cmbBusquedaTipoUnidad.Items.AddRange(new object[] {
									"Camión",
									"Camioneta"});
			this.cmbBusquedaTipoUnidad.Location = new System.Drawing.Point(84, 23);
			this.cmbBusquedaTipoUnidad.Name = "cmbBusquedaTipoUnidad";
			this.cmbBusquedaTipoUnidad.Size = new System.Drawing.Size(147, 22);
			this.cmbBusquedaTipoUnidad.TabIndex = 0;
			this.cmbBusquedaTipoUnidad.TextChanged += new System.EventHandler(this.TxtBusquedaNumeroTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 14);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tipo Unidad:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtBusquedaFederal);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtBusquedaEstatal);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtBusquedaNumero);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(242, 109);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtro detalles de registro";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "Placa Federal:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBusquedaFederal
			// 
			this.txtBusquedaFederal.Location = new System.Drawing.Point(84, 74);
			this.txtBusquedaFederal.Name = "txtBusquedaFederal";
			this.txtBusquedaFederal.Size = new System.Drawing.Size(147, 20);
			this.txtBusquedaFederal.TabIndex = 2;
			this.txtBusquedaFederal.TextChanged += new System.EventHandler(this.TxtBusquedaNumeroTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "Placa Estatal:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBusquedaEstatal
			// 
			this.txtBusquedaEstatal.Location = new System.Drawing.Point(84, 48);
			this.txtBusquedaEstatal.Name = "txtBusquedaEstatal";
			this.txtBusquedaEstatal.Size = new System.Drawing.Size(147, 20);
			this.txtBusquedaEstatal.TabIndex = 1;
			this.txtBusquedaEstatal.TextChanged += new System.EventHandler(this.TxtBusquedaNumeroTextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 14);
			this.label7.TabIndex = 1;
			this.label7.Text = "Numero:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBusquedaNumero
			// 
			this.txtBusquedaNumero.Location = new System.Drawing.Point(84, 23);
			this.txtBusquedaNumero.Name = "txtBusquedaNumero";
			this.txtBusquedaNumero.Size = new System.Drawing.Size(147, 20);
			this.txtBusquedaNumero.TabIndex = 0;
			this.txtBusquedaNumero.TextChanged += new System.EventHandler(this.TxtBusquedaNumeroTextChanged);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(529, 109);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(88, 32);
			this.btnNuevo.TabIndex = 3;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(623, 109);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(88, 32);
			this.btnModificar.TabIndex = 4;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(717, 108);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(88, 32);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(826, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "Datos del vehículo:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridViewUnidad
			// 
			this.dataGridViewUnidad.AllowUserToAddRows = false;
			this.dataGridViewUnidad.AllowUserToDeleteRows = false;
			this.dataGridViewUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewUnidad.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataGridViewUnidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewUnidad.CausesValidation = false;
			this.dataGridViewUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUnidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.UnidadNumero,
									this.Unidad_estatus,
									this.Unidad_Tipo,
									this.UnidadServicio,
									this.Unidad_Marca,
									this.Unidad_Modelo,
									this.Unidad_Ano,
									this.PlacaEstatal,
									this.PlacaFederal,
									this.Unidad_num_serie,
									this.Unidad_nombre_motor,
									this.Unidad_motor_modelo,
									this.Unidad_num_serie_motor,
									this.Unidad_diferencial,
									this.Unidad_paso_diferencial,
									this.Unidad_tipo_llanta,
									this.Unidad_perimetro_llanta,
									this.Unidad_potencia,
									this.Unidad_caja_nombre,
									this.Unidad_caja_modelo,
									this.Unidad_u_relacion,
									this.Unidad_torque,
									this.Unidad_cap_tanque,
									this.Unidad_capacidad});
			this.dataGridViewUnidad.Location = new System.Drawing.Point(9, 218);
			this.dataGridViewUnidad.MultiSelect = false;
			this.dataGridViewUnidad.Name = "dataGridViewUnidad";
			this.dataGridViewUnidad.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewUnidad.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewUnidad.Size = new System.Drawing.Size(823, 371);
			this.dataGridViewUnidad.StandardTab = true;
			this.dataGridViewUnidad.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(845, 58);
			this.label8.TabIndex = 18;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.DataPropertyName = "ID";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// UnidadNumero
			// 
			this.UnidadNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.UnidadNumero.DataPropertyName = "UnidadNumero";
			this.UnidadNumero.HeaderText = "Numero";
			this.UnidadNumero.Name = "UnidadNumero";
			this.UnidadNumero.ReadOnly = true;
			// 
			// Unidad_estatus
			// 
			this.Unidad_estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_estatus.DataPropertyName = "Unidad_estatus";
			this.Unidad_estatus.HeaderText = "Estatus";
			this.Unidad_estatus.Name = "Unidad_estatus";
			this.Unidad_estatus.ReadOnly = true;
			// 
			// Unidad_Tipo
			// 
			this.Unidad_Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_Tipo.DataPropertyName = "Unidad_tipo";
			this.Unidad_Tipo.HeaderText = "Tipo";
			this.Unidad_Tipo.Name = "Unidad_Tipo";
			this.Unidad_Tipo.ReadOnly = true;
			this.Unidad_Tipo.Width = 53;
			// 
			// UnidadServicio
			// 
			this.UnidadServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.UnidadServicio.DataPropertyName = "UnidadServicio";
			this.UnidadServicio.HeaderText = "Servicio";
			this.UnidadServicio.Name = "UnidadServicio";
			this.UnidadServicio.ReadOnly = true;
			this.UnidadServicio.Width = 70;
			// 
			// Unidad_Marca
			// 
			this.Unidad_Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_Marca.DataPropertyName = "Unidad_Marca";
			this.Unidad_Marca.HeaderText = "Marca";
			this.Unidad_Marca.Name = "Unidad_Marca";
			this.Unidad_Marca.ReadOnly = true;
			this.Unidad_Marca.Width = 62;
			// 
			// Unidad_Modelo
			// 
			this.Unidad_Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_Modelo.DataPropertyName = "Unidad_Modelo";
			this.Unidad_Modelo.HeaderText = "Modelo";
			this.Unidad_Modelo.Name = "Unidad_Modelo";
			this.Unidad_Modelo.ReadOnly = true;
			this.Unidad_Modelo.Width = 67;
			// 
			// Unidad_Ano
			// 
			this.Unidad_Ano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_Ano.DataPropertyName = "Unidad_Ano";
			this.Unidad_Ano.HeaderText = "Año";
			this.Unidad_Ano.Name = "Unidad_Ano";
			this.Unidad_Ano.ReadOnly = true;
			this.Unidad_Ano.Width = 51;
			// 
			// PlacaEstatal
			// 
			this.PlacaEstatal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PlacaEstatal.DataPropertyName = "Unidad_Estatal";
			this.PlacaEstatal.HeaderText = "Placa Estatal";
			this.PlacaEstatal.Name = "PlacaEstatal";
			this.PlacaEstatal.ReadOnly = true;
			this.PlacaEstatal.Width = 94;
			// 
			// PlacaFederal
			// 
			this.PlacaFederal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PlacaFederal.DataPropertyName = "Unidad_Federal";
			this.PlacaFederal.HeaderText = "Placa Federal";
			this.PlacaFederal.Name = "PlacaFederal";
			this.PlacaFederal.ReadOnly = true;
			this.PlacaFederal.Width = 97;
			// 
			// Unidad_num_serie
			// 
			this.Unidad_num_serie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_num_serie.DataPropertyName = "Unidad_num_serie";
			this.Unidad_num_serie.HeaderText = "Num de serie";
			this.Unidad_num_serie.Name = "Unidad_num_serie";
			this.Unidad_num_serie.ReadOnly = true;
			this.Unidad_num_serie.Width = 94;
			// 
			// Unidad_nombre_motor
			// 
			this.Unidad_nombre_motor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_nombre_motor.DataPropertyName = "Unidad_nom_motor";
			this.Unidad_nombre_motor.HeaderText = "Nombre motor";
			this.Unidad_nombre_motor.Name = "Unidad_nombre_motor";
			this.Unidad_nombre_motor.ReadOnly = true;
			this.Unidad_nombre_motor.Width = 98;
			// 
			// Unidad_motor_modelo
			// 
			this.Unidad_motor_modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_motor_modelo.DataPropertyName = "Unidad_mod_motor";
			this.Unidad_motor_modelo.HeaderText = "Modelo motor";
			this.Unidad_motor_modelo.Name = "Unidad_motor_modelo";
			this.Unidad_motor_modelo.ReadOnly = true;
			this.Unidad_motor_modelo.Width = 96;
			// 
			// Unidad_num_serie_motor
			// 
			this.Unidad_num_serie_motor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_num_serie_motor.DataPropertyName = "Unidad_num_motor";
			this.Unidad_num_serie_motor.HeaderText = "Num serie motor";
			this.Unidad_num_serie_motor.Name = "Unidad_num_serie_motor";
			this.Unidad_num_serie_motor.ReadOnly = true;
			this.Unidad_num_serie_motor.Width = 99;
			// 
			// Unidad_diferencial
			// 
			this.Unidad_diferencial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_diferencial.DataPropertyName = "Unidad_diferencial";
			this.Unidad_diferencial.HeaderText = "Diferencial";
			this.Unidad_diferencial.Name = "Unidad_diferencial";
			this.Unidad_diferencial.ReadOnly = true;
			this.Unidad_diferencial.Width = 82;
			// 
			// Unidad_paso_diferencial
			// 
			this.Unidad_paso_diferencial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_paso_diferencial.DataPropertyName = "Paso_dif";
			this.Unidad_paso_diferencial.HeaderText = "Paso diferencial";
			this.Unidad_paso_diferencial.Name = "Unidad_paso_diferencial";
			this.Unidad_paso_diferencial.ReadOnly = true;
			this.Unidad_paso_diferencial.Width = 98;
			// 
			// Unidad_tipo_llanta
			// 
			this.Unidad_tipo_llanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_tipo_llanta.DataPropertyName = "Tipo_llanta";
			this.Unidad_tipo_llanta.HeaderText = "Tipo llanta";
			this.Unidad_tipo_llanta.Name = "Unidad_tipo_llanta";
			this.Unidad_tipo_llanta.ReadOnly = true;
			this.Unidad_tipo_llanta.Width = 75;
			// 
			// Unidad_perimetro_llanta
			// 
			this.Unidad_perimetro_llanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_perimetro_llanta.DataPropertyName = "Peri_llanta";
			this.Unidad_perimetro_llanta.HeaderText = "Perimetro llanta";
			this.Unidad_perimetro_llanta.Name = "Unidad_perimetro_llanta";
			this.Unidad_perimetro_llanta.ReadOnly = true;
			this.Unidad_perimetro_llanta.Width = 96;
			// 
			// Unidad_potencia
			// 
			this.Unidad_potencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_potencia.DataPropertyName = "Unidad_potencia";
			this.Unidad_potencia.HeaderText = "Potencia";
			this.Unidad_potencia.Name = "Unidad_potencia";
			this.Unidad_potencia.ReadOnly = true;
			this.Unidad_potencia.Width = 74;
			// 
			// Unidad_caja_nombre
			// 
			this.Unidad_caja_nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_caja_nombre.DataPropertyName = "Unidad_nom_caja";
			this.Unidad_caja_nombre.HeaderText = "Nombre caja";
			this.Unidad_caja_nombre.Name = "Unidad_caja_nombre";
			this.Unidad_caja_nombre.ReadOnly = true;
			this.Unidad_caja_nombre.Width = 85;
			// 
			// Unidad_caja_modelo
			// 
			this.Unidad_caja_modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_caja_modelo.DataPropertyName = "Modelo_caja";
			this.Unidad_caja_modelo.HeaderText = "Modelo caja";
			this.Unidad_caja_modelo.Name = "Unidad_caja_modelo";
			this.Unidad_caja_modelo.ReadOnly = true;
			this.Unidad_caja_modelo.Width = 83;
			// 
			// Unidad_u_relacion
			// 
			this.Unidad_u_relacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_u_relacion.DataPropertyName = "U_rel";
			this.Unidad_u_relacion.HeaderText = "U relación";
			this.Unidad_u_relacion.Name = "Unidad_u_relacion";
			this.Unidad_u_relacion.ReadOnly = true;
			this.Unidad_u_relacion.Width = 74;
			// 
			// Unidad_torque
			// 
			this.Unidad_torque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_torque.DataPropertyName = "Unidad_torque";
			this.Unidad_torque.HeaderText = "Torque";
			this.Unidad_torque.Name = "Unidad_torque";
			this.Unidad_torque.ReadOnly = true;
			this.Unidad_torque.Width = 66;
			// 
			// Unidad_cap_tanque
			// 
			this.Unidad_cap_tanque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_cap_tanque.DataPropertyName = "Cap_tanque";
			this.Unidad_cap_tanque.HeaderText = "Capacidad tanque";
			this.Unidad_cap_tanque.Name = "Unidad_cap_tanque";
			this.Unidad_cap_tanque.ReadOnly = true;
			this.Unidad_cap_tanque.Width = 109;
			// 
			// Unidad_capacidad
			// 
			this.Unidad_capacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Unidad_capacidad.DataPropertyName = "Unidad_cap";
			this.Unidad_capacidad.HeaderText = "Capacidad";
			this.Unidad_capacidad.Name = "Unidad_capacidad";
			this.Unidad_capacidad.ReadOnly = true;
			this.Unidad_capacidad.Width = 83;
			// 
			// FormBusquedaUnidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(844, 601);
			this.Controls.Add(this.dataGridViewUnidad);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBusquedaUnidad";
			this.Text = "Transportes LAR - Busqueda de la Unidad";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBusquedaUnidadFormClosing);
			this.Load += new System.EventHandler(this.FormBusquedaUnidadLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_estatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_capacidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_cap_tanque;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_torque;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_u_relacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_caja_modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_caja_nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_potencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_perimetro_llanta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_tipo_llanta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_paso_diferencial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_diferencial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_num_serie_motor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_motor_modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_nombre_motor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_num_serie;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlacaFederal;
		private System.Windows.Forms.DataGridViewTextBoxColumn PlacaEstatal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_Ano;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_Modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_Marca;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnidadServicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnidadNumero;
		public System.Windows.Forms.DataGridView dataGridViewUnidad;
		public System.Windows.Forms.TextBox txtBusquedaNumero;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtBusquedaEstatal;
		public System.Windows.Forms.TextBox txtBusquedaFederal;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.ComboBox cmbBusquedaTipoUnidad;
		private System.Windows.Forms.Label label29;
		public System.Windows.Forms.ComboBox cmbBusquedaTipoServ;
		public System.Windows.Forms.TextBox txtBusquedaMarca;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
