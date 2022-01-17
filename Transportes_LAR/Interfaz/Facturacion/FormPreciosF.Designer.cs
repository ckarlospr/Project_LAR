/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 09/09/2016
 * Hora: 11:05 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Facturacion
{
	partial class FormPreciosF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreciosF));
			this.panel4 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.dgPreciosRutas = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Velada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Foranea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.gbDatos = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblProgramacion = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.cbVelada = new System.Windows.Forms.CheckBox();
			this.cbForanea = new System.Windows.Forms.CheckBox();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbVehiculo = new System.Windows.Forms.ComboBox();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.Decremento = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDecremento = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtdecremento = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAumento = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAumento = new System.Windows.Forms.TextBox();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.cmbSentido = new System.Windows.Forms.ComboBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIdentificador = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnBusqueda = new System.Windows.Forms.Panel();
			this.cbEliminadas = new System.Windows.Forms.CheckBox();
			this.cmbTurnoBusqueda = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.cmbVehiculoBusqueda = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbSentidoBusqueda = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbEmpresa = new System.Windows.Forms.ComboBox();
			this.groupBox2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPreciosRutas)).BeginInit();
			this.gbDatos.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.Decremento.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.pnBusqueda.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel4.Location = new System.Drawing.Point(328, 44);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 662);
			this.panel4.TabIndex = 211;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.dgPreciosRutas);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(338, 37);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(620, 669);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel3.Controls.Add(this.label14);
			this.panel3.Location = new System.Drawing.Point(0, 7);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(620, 24);
			this.panel3.TabIndex = 196;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(17, 2);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(578, 20);
			this.label14.TabIndex = 0;
			this.label14.Text = "Rutas";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgPreciosRutas
			// 
			this.dgPreciosRutas.AllowUserToAddRows = false;
			this.dgPreciosRutas.AllowUserToResizeColumns = false;
			this.dgPreciosRutas.AllowUserToResizeRows = false;
			this.dgPreciosRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgPreciosRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPreciosRutas.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dgPreciosRutas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgPreciosRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPreciosRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.ID_CLIENTE,
									this.Nombre,
									this.Servicio,
									this.Vehiculo,
									this.Tipo,
									this.CTurno,
									this.Velada,
									this.Foranea,
									this.Importe,
									this.Comentarios,
									this.Eliminar});
			this.dgPreciosRutas.Location = new System.Drawing.Point(6, 39);
			this.dgPreciosRutas.Name = "dgPreciosRutas";
			this.dgPreciosRutas.RowHeadersVisible = false;
			this.dgPreciosRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPreciosRutas.Size = new System.Drawing.Size(607, 626);
			this.dgPreciosRutas.TabIndex = 24;
			this.dgPreciosRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPreciosRutasCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// ID_CLIENTE
			// 
			this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
			this.ID_CLIENTE.Name = "ID_CLIENTE";
			this.ID_CLIENTE.Visible = false;
			// 
			// Nombre
			// 
			this.Nombre.FillWeight = 132.3669F;
			this.Nombre.HeaderText = "Identificador";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Servicio
			// 
			this.Servicio.FillWeight = 85F;
			this.Servicio.HeaderText = "Sentido";
			this.Servicio.Name = "Servicio";
			this.Servicio.ReadOnly = true;
			// 
			// Vehiculo
			// 
			this.Vehiculo.FillWeight = 92F;
			this.Vehiculo.HeaderText = "Vehiculo";
			this.Vehiculo.Name = "Vehiculo";
			// 
			// Tipo
			// 
			this.Tipo.FillWeight = 85F;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// CTurno
			// 
			this.CTurno.FillWeight = 95.5677F;
			this.CTurno.HeaderText = "Turno";
			this.CTurno.Name = "CTurno";
			this.CTurno.ReadOnly = true;
			// 
			// Velada
			// 
			this.Velada.FillWeight = 50F;
			this.Velada.HeaderText = "VL";
			this.Velada.Name = "Velada";
			// 
			// Foranea
			// 
			this.Foranea.FillWeight = 50F;
			this.Foranea.HeaderText = "F";
			this.Foranea.Name = "Foranea";
			// 
			// Importe
			// 
			this.Importe.FillWeight = 95.5677F;
			this.Importe.HeaderText = "Importe";
			this.Importe.Name = "Importe";
			this.Importe.ReadOnly = true;
			// 
			// Comentarios
			// 
			this.Comentarios.FillWeight = 110F;
			this.Comentarios.HeaderText = "Comentarios";
			this.Comentarios.Name = "Comentarios";
			// 
			// Eliminar
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
			this.Eliminar.DefaultCellStyle = dataGridViewCellStyle1;
			this.Eliminar.FillWeight = 28.36434F;
			this.Eliminar.HeaderText = "X";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Text = "X";
			// 
			// gbDatos
			// 
			this.gbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.gbDatos.BackColor = System.Drawing.SystemColors.Control;
			this.gbDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gbDatos.Controls.Add(this.btnCancelar);
			this.gbDatos.Controls.Add(this.panel2);
			this.gbDatos.Controls.Add(this.panel1);
			this.gbDatos.Controls.Add(this.cbVelada);
			this.gbDatos.Controls.Add(this.cbForanea);
			this.gbDatos.Controls.Add(this.txtObservaciones);
			this.gbDatos.Controls.Add(this.label10);
			this.gbDatos.Controls.Add(this.cmbVehiculo);
			this.gbDatos.Controls.Add(this.txtImporte);
			this.gbDatos.Controls.Add(this.label12);
			this.gbDatos.Controls.Add(this.label13);
			this.gbDatos.Controls.Add(this.Decremento);
			this.gbDatos.Controls.Add(this.groupBox1);
			this.gbDatos.Controls.Add(this.cmbTurno);
			this.gbDatos.Controls.Add(this.label1);
			this.gbDatos.Controls.Add(this.btnInsertar);
			this.gbDatos.Controls.Add(this.cmbTipo);
			this.gbDatos.Controls.Add(this.cmbSentido);
			this.gbDatos.Controls.Add(this.btnModificar);
			this.gbDatos.Controls.Add(this.label9);
			this.gbDatos.Controls.Add(this.txtIdentificador);
			this.gbDatos.Controls.Add(this.label8);
			this.gbDatos.Controls.Add(this.label5);
			this.gbDatos.Enabled = false;
			this.gbDatos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDatos.Location = new System.Drawing.Point(7, 37);
			this.gbDatos.Name = "gbDatos";
			this.gbDatos.Size = new System.Drawing.Size(321, 669);
			this.gbDatos.TabIndex = 210;
			this.gbDatos.TabStop = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCancelar.Location = new System.Drawing.Point(220, 303);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(67, 42);
			this.btnCancelar.TabIndex = 201;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.lblProgramacion);
			this.panel2.Location = new System.Drawing.Point(0, 7);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(321, 24);
			this.panel2.TabIndex = 196;
			// 
			// lblProgramacion
			// 
			this.lblProgramacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblProgramacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProgramacion.Location = new System.Drawing.Point(17, 2);
			this.lblProgramacion.Name = "lblProgramacion";
			this.lblProgramacion.Size = new System.Drawing.Size(279, 20);
			this.lblProgramacion.TabIndex = 0;
			this.lblProgramacion.Text = "Datos Rutas";
			this.lblProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.label11);
			this.panel1.Location = new System.Drawing.Point(1, 366);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(324, 24);
			this.panel1.TabIndex = 197;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(17, 2);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(282, 20);
			this.label11.TabIndex = 0;
			this.label11.Text = "Controles Rutas";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbVelada
			// 
			this.cbVelada.Location = new System.Drawing.Point(95, 182);
			this.cbVelada.Name = "cbVelada";
			this.cbVelada.Size = new System.Drawing.Size(67, 24);
			this.cbVelada.TabIndex = 11;
			this.cbVelada.Text = "Velada";
			this.cbVelada.UseVisualStyleBackColor = true;
			// 
			// cbForanea
			// 
			this.cbForanea.Location = new System.Drawing.Point(196, 184);
			this.cbForanea.Name = "cbForanea";
			this.cbForanea.Size = new System.Drawing.Size(83, 24);
			this.cbForanea.TabIndex = 12;
			this.cbForanea.Text = "Foranea";
			this.cbForanea.UseVisualStyleBackColor = true;
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtObservaciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservaciones.Location = new System.Drawing.Point(89, 237);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(197, 53);
			this.txtObservaciones.TabIndex = 14;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(1, 236);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 22);
			this.label10.TabIndex = 200;
			this.label10.Text = "Obervaciones";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbVehiculo
			// 
			this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVehiculo.FormattingEnabled = true;
			this.cmbVehiculo.Items.AddRange(new object[] {
									"CAMION",
									"CAMIONETA",
									"N/A"});
			this.cmbVehiculo.Location = new System.Drawing.Point(90, 100);
			this.cmbVehiculo.Name = "cmbVehiculo";
			this.cmbVehiculo.Size = new System.Drawing.Size(197, 22);
			this.cmbVehiculo.TabIndex = 8;
			// 
			// txtImporte
			// 
			this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtImporte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporte.Location = new System.Drawing.Point(89, 212);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(197, 20);
			this.txtImporte.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(25, 100);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(58, 22);
			this.label12.TabIndex = 196;
			this.label12.Text = "Vehiculo";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(21, 209);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 22);
			this.label13.TabIndex = 197;
			this.label13.Text = "Importe";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Decremento
			// 
			this.Decremento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.Decremento.Controls.Add(this.label6);
			this.Decremento.Controls.Add(this.btnDecremento);
			this.Decremento.Controls.Add(this.label3);
			this.Decremento.Controls.Add(this.txtdecremento);
			this.Decremento.Location = new System.Drawing.Point(12, 501);
			this.Decremento.Name = "Decremento";
			this.Decremento.Size = new System.Drawing.Size(295, 91);
			this.Decremento.TabIndex = 20;
			this.Decremento.TabStop = false;
			this.Decremento.Text = "Decremento Global por Empresa";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(247, 17);
			this.label6.TabIndex = 194;
			this.label6.Text = "El porcentaje debe de ser en enteros ej.: 16";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnDecremento
			// 
			this.btnDecremento.Location = new System.Drawing.Point(190, 28);
			this.btnDecremento.Name = "btnDecremento";
			this.btnDecremento.Size = new System.Drawing.Size(75, 23);
			this.btnDecremento.TabIndex = 22;
			this.btnDecremento.Text = "Aceptar";
			this.btnDecremento.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(18, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 22);
			this.label3.TabIndex = 191;
			this.label3.Text = "Decremento %";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtdecremento
			// 
			this.txtdecremento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtdecremento.Enabled = false;
			this.txtdecremento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdecremento.HideSelection = false;
			this.txtdecremento.Location = new System.Drawing.Point(103, 28);
			this.txtdecremento.Name = "txtdecremento";
			this.txtdecremento.Size = new System.Drawing.Size(81, 20);
			this.txtdecremento.TabIndex = 21;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnAumento);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtAumento);
			this.groupBox1.Location = new System.Drawing.Point(13, 408);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(295, 79);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Aumento Global por Empresa";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(247, 17);
			this.label4.TabIndex = 193;
			this.label4.Text = "El porcentaje debe de ser en enteros ej.: 16";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAumento
			// 
			this.btnAumento.Location = new System.Drawing.Point(190, 23);
			this.btnAumento.Name = "btnAumento";
			this.btnAumento.Size = new System.Drawing.Size(75, 23);
			this.btnAumento.TabIndex = 19;
			this.btnAumento.Text = "Aceptar";
			this.btnAumento.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 22);
			this.label2.TabIndex = 191;
			this.label2.Text = "Aumento %";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAumento
			// 
			this.txtAumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAumento.Enabled = false;
			this.txtAumento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAumento.HideSelection = false;
			this.txtAumento.Location = new System.Drawing.Point(88, 23);
			this.txtAumento.Name = "txtAumento";
			this.txtAumento.Size = new System.Drawing.Size(96, 20);
			this.txtAumento.TabIndex = 18;
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno",
									"N/A"});
			this.cmbTurno.Location = new System.Drawing.Point(89, 157);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(197, 22);
			this.cmbTurno.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 156);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 22);
			this.label1.TabIndex = 188;
			this.label1.Text = "Turno";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnInsertar
			// 
			this.btnInsertar.BackColor = System.Drawing.Color.Transparent;
			this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInsertar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
			this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnInsertar.Location = new System.Drawing.Point(42, 303);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(67, 42);
			this.btnInsertar.TabIndex = 15;
			this.btnInsertar.Text = "Agregar";
			this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnInsertar.UseVisualStyleBackColor = false;
			this.btnInsertar.Click += new System.EventHandler(this.BtnInsertarClick);
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"NRM",
									"EXT",
									"ESP",
									"N/A"});
			this.cmbTipo.Location = new System.Drawing.Point(89, 129);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(197, 22);
			this.cmbTipo.TabIndex = 9;
			// 
			// cmbSentido
			// 
			this.cmbSentido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSentido.FormattingEnabled = true;
			this.cmbSentido.Items.AddRange(new object[] {
									"Sencillo",
									"Completo",
									"NA"});
			this.cmbSentido.Location = new System.Drawing.Point(89, 70);
			this.cmbSentido.Name = "cmbSentido";
			this.cmbSentido.Size = new System.Drawing.Size(198, 22);
			this.cmbSentido.TabIndex = 7;
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Enabled = false;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnModificar.Location = new System.Drawing.Point(130, 303);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(67, 42);
			this.btnModificar.TabIndex = 16;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(24, 70);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 22);
			this.label9.TabIndex = 145;
			this.label9.Text = "Sentido";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIdentificador
			// 
			this.txtIdentificador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdentificador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIdentificador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdentificador.Location = new System.Drawing.Point(89, 42);
			this.txtIdentificador.Name = "txtIdentificador";
			this.txtIdentificador.Size = new System.Drawing.Size(197, 20);
			this.txtIdentificador.TabIndex = 6;
			this.txtIdentificador.TextChanged += new System.EventHandler(this.TxtIdentificadorTextChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 22);
			this.label8.TabIndex = 142;
			this.label8.Text = "Identificador";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 22);
			this.label5.TabIndex = 140;
			this.label5.Text = "Tipo";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pnBusqueda
			// 
			this.pnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pnBusqueda.Controls.Add(this.cbEliminadas);
			this.pnBusqueda.Controls.Add(this.cmbTurnoBusqueda);
			this.pnBusqueda.Controls.Add(this.label17);
			this.pnBusqueda.Controls.Add(this.cmbVehiculoBusqueda);
			this.pnBusqueda.Controls.Add(this.label15);
			this.pnBusqueda.Controls.Add(this.cmbSentidoBusqueda);
			this.pnBusqueda.Controls.Add(this.label16);
			this.pnBusqueda.Controls.Add(this.label7);
			this.pnBusqueda.Controls.Add(this.cmbEmpresa);
			this.pnBusqueda.Location = new System.Drawing.Point(7, 3);
			this.pnBusqueda.Name = "pnBusqueda";
			this.pnBusqueda.Size = new System.Drawing.Size(951, 40);
			this.pnBusqueda.TabIndex = 212;
			// 
			// cbEliminadas
			// 
			this.cbEliminadas.Location = new System.Drawing.Point(862, 8);
			this.cbEliminadas.Name = "cbEliminadas";
			this.cbEliminadas.Size = new System.Drawing.Size(83, 24);
			this.cbEliminadas.TabIndex = 212;
			this.cbEliminadas.Text = "Eliminadas";
			this.cbEliminadas.UseVisualStyleBackColor = true;
			this.cbEliminadas.CheckedChanged += new System.EventHandler(this.CbEliminadasCheckedChanged);
			// 
			// cmbTurnoBusqueda
			// 
			this.cmbTurnoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurnoBusqueda.FormattingEnabled = true;
			this.cmbTurnoBusqueda.Items.AddRange(new object[] {
									"",
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno",
									"NA"});
			this.cmbTurnoBusqueda.Location = new System.Drawing.Point(620, 8);
			this.cmbTurnoBusqueda.Name = "cmbTurnoBusqueda";
			this.cmbTurnoBusqueda.Size = new System.Drawing.Size(119, 21);
			this.cmbTurnoBusqueda.TabIndex = 211;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(556, 8);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(58, 22);
			this.label17.TabIndex = 216;
			this.label17.Text = "Turno";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbVehiculoBusqueda
			// 
			this.cmbVehiculoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVehiculoBusqueda.FormattingEnabled = true;
			this.cmbVehiculoBusqueda.Items.AddRange(new object[] {
									"",
									"CAMION",
									"CAMIONETA"});
			this.cmbVehiculoBusqueda.Location = new System.Drawing.Point(439, 8);
			this.cmbVehiculoBusqueda.Name = "cmbVehiculoBusqueda";
			this.cmbVehiculoBusqueda.Size = new System.Drawing.Size(116, 21);
			this.cmbVehiculoBusqueda.TabIndex = 210;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(378, 8);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(58, 22);
			this.label15.TabIndex = 215;
			this.label15.Text = "Vehiculo";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbSentidoBusqueda
			// 
			this.cmbSentidoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSentidoBusqueda.FormattingEnabled = true;
			this.cmbSentidoBusqueda.Items.AddRange(new object[] {
									"",
									"Sencillo",
									"Completo",
									"NA"});
			this.cmbSentidoBusqueda.Location = new System.Drawing.Point(259, 8);
			this.cmbSentidoBusqueda.Name = "cmbSentidoBusqueda";
			this.cmbSentidoBusqueda.Size = new System.Drawing.Size(110, 21);
			this.cmbSentidoBusqueda.TabIndex = 209;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(198, 8);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(58, 22);
			this.label16.TabIndex = 214;
			this.label16.Text = "Sentido";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(4, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 22);
			this.label7.TabIndex = 213;
			this.label7.Text = "Empresa";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbEmpresa
			// 
			this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEmpresa.FormattingEnabled = true;
			this.cmbEmpresa.Location = new System.Drawing.Point(65, 8);
			this.cmbEmpresa.Name = "cmbEmpresa";
			this.cmbEmpresa.Size = new System.Drawing.Size(132, 21);
			this.cmbEmpresa.TabIndex = 208;
			this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.CmbEmpresaSelectedIndexChanged);
			// 
			// FormPreciosF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(965, 708);
			this.Controls.Add(this.pnBusqueda);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbDatos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPreciosF";
			this.Text = "Precios Facturación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPreciosFFormClosing);
			this.Load += new System.EventHandler(this.FormPreciosFLoad);
			this.groupBox2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPreciosRutas)).EndInit();
			this.gbDatos.ResumeLayout(false);
			this.gbDatos.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.Decremento.ResumeLayout(false);
			this.Decremento.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.pnBusqueda.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel pnBusqueda;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
		private System.Windows.Forms.DataGridViewTextBoxColumn Foranea;
		private System.Windows.Forms.DataGridViewTextBoxColumn Velada;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
		private System.Windows.Forms.CheckBox cbEliminadas;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cmbTurnoBusqueda;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cmbSentidoBusqueda;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cmbVehiculoBusqueda;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblProgramacion;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox cbForanea;
		private System.Windows.Forms.CheckBox cbVelada;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbEmpresa;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.ComboBox cmbVehiculo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn CTurno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
		private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgPreciosRutas;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtIdentificador;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.ComboBox cmbSentido;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.TextBox txtAumento;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAumento;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtdecremento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDecremento;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox Decremento;
		private System.Windows.Forms.GroupBox gbDatos;
	}
}
