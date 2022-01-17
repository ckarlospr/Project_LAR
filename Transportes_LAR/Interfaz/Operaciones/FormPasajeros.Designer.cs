/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 30/04/2016
 * Hora: 11:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormPasajeros
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasajeros));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cbEmpresa = new System.Windows.Forms.ComboBox();
			this.lblEmpresa = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.lblDel = new System.Windows.Forms.Label();
			this.lblA = new System.Windows.Forms.Label();
			this.lblServicios = new System.Windows.Forms.Label();
			this.dgServicios = new System.Windows.Forms.DataGridView();
			this.ID_OPERACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hora_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LLEGADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Update = new System.Windows.Forms.DataGridViewImageColumn();
			this.lblLimpiar = new System.Windows.Forms.Label();
			this.cbTurno = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.cbES = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgServicios)).BeginInit();
			this.SuspendLayout();
			// 
			// cbEmpresa
			// 
			this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEmpresa.FormattingEnabled = true;
			this.cbEmpresa.Location = new System.Drawing.Point(71, 23);
			this.cbEmpresa.Name = "cbEmpresa";
			this.cbEmpresa.Size = new System.Drawing.Size(121, 21);
			this.cbEmpresa.TabIndex = 2;
			this.cbEmpresa.SelectedIndexChanged += new System.EventHandler(this.CbEmpresaSelectedIndexChanged);
			// 
			// lblEmpresa
			// 
			this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpresa.Location = new System.Drawing.Point(8, 24);
			this.lblEmpresa.Name = "lblEmpresa";
			this.lblEmpresa.Size = new System.Drawing.Size(100, 23);
			this.lblEmpresa.TabIndex = 1;
			this.lblEmpresa.Text = "Empresa";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(852, 11);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(77, 42);
			this.btnBuscar.TabIndex = 13;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(573, 21);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(99, 20);
			this.dtpInicio.TabIndex = 10;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(696, 22);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(99, 20);
			this.dtpFin.TabIndex = 12;
			// 
			// lblDel
			// 
			this.lblDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDel.Location = new System.Drawing.Point(546, 22);
			this.lblDel.Name = "lblDel";
			this.lblDel.Size = new System.Drawing.Size(29, 23);
			this.lblDel.TabIndex = 9;
			this.lblDel.Text = "Del";
			// 
			// lblA
			// 
			this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA.Location = new System.Drawing.Point(676, 23);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(17, 23);
			this.lblA.TabIndex = 11;
			this.lblA.Text = "A";
			// 
			// lblServicios
			// 
			this.lblServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblServicios.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServicios.Location = new System.Drawing.Point(2, 61);
			this.lblServicios.Name = "lblServicios";
			this.lblServicios.Size = new System.Drawing.Size(929, 23);
			this.lblServicios.TabIndex = 14;
			this.lblServicios.Text = "Servicios";
			this.lblServicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgServicios
			// 
			this.dgServicios.AllowUserToAddRows = false;
			this.dgServicios.AllowUserToDeleteRows = false;
			this.dgServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_OPERACION,
									this.Empresa,
									this.Ruta,
									this.Sentido,
									this.Turno,
									this.KM,
									this.Hora_i,
									this.hora_F,
									this.Tipo,
									this.Operador,
									this.Pasajeros,
									this.LLEGADA,
									this.Update});
			this.dgServicios.Location = new System.Drawing.Point(2, 87);
			this.dgServicios.Name = "dgServicios";
			this.dgServicios.RowHeadersVisible = false;
			this.dgServicios.Size = new System.Drawing.Size(929, 344);
			this.dgServicios.TabIndex = 15;
			this.dgServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgServiciosCellClick);
			this.dgServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgServiciosCellContentClick);
			this.dgServicios.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgServiciosCellLeave);
			this.dgServicios.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgServiciosEditingControlShowing);
			this.dgServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgServiciosKeyPress);
			// 
			// ID_OPERACION
			// 
			this.ID_OPERACION.HeaderText = "ID_OPERACION";
			this.ID_OPERACION.Name = "ID_OPERACION";
			this.ID_OPERACION.Visible = false;
			// 
			// Empresa
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Empresa.DefaultCellStyle = dataGridViewCellStyle1;
			this.Empresa.FillWeight = 140F;
			this.Empresa.HeaderText = "Empresa";
			this.Empresa.Name = "Empresa";
			this.Empresa.ReadOnly = true;
			// 
			// Ruta
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Ruta.DefaultCellStyle = dataGridViewCellStyle2;
			this.Ruta.FillWeight = 160F;
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			// 
			// Sentido
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Sentido.DefaultCellStyle = dataGridViewCellStyle3;
			this.Sentido.HeaderText = "Sentido";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			// 
			// Turno
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Turno.DefaultCellStyle = dataGridViewCellStyle4;
			this.Turno.HeaderText = "Turno";
			this.Turno.Name = "Turno";
			this.Turno.ReadOnly = true;
			// 
			// KM
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.KM.DefaultCellStyle = dataGridViewCellStyle5;
			this.KM.HeaderText = "KM";
			this.KM.Name = "KM";
			this.KM.ReadOnly = true;
			// 
			// Hora_i
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Hora_i.DefaultCellStyle = dataGridViewCellStyle6;
			this.Hora_i.FillWeight = 110F;
			this.Hora_i.HeaderText = "Hora Inicio";
			this.Hora_i.Name = "Hora_i";
			this.Hora_i.ReadOnly = true;
			// 
			// hora_F
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.hora_F.DefaultCellStyle = dataGridViewCellStyle7;
			this.hora_F.HeaderText = "Hora Fin";
			this.hora_F.Name = "hora_F";
			this.hora_F.ReadOnly = true;
			// 
			// Tipo
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Tipo.DefaultCellStyle = dataGridViewCellStyle8;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// Operador
			// 
			this.Operador.HeaderText = "Operador";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			// 
			// Pasajeros
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
			this.Pasajeros.DefaultCellStyle = dataGridViewCellStyle9;
			this.Pasajeros.HeaderText = "Pasajeros";
			this.Pasajeros.Name = "Pasajeros";
			// 
			// LLEGADA
			// 
			this.LLEGADA.HeaderText = "Llegada";
			this.LLEGADA.Name = "LLEGADA";
			this.LLEGADA.ReadOnly = true;
			// 
			// Update
			// 
			this.Update.FillWeight = 40F;
			this.Update.HeaderText = "#";
			this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
			this.Update.Name = "Update";
			// 
			// lblLimpiar
			// 
			this.lblLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("lblLimpiar.Image")));
			this.lblLimpiar.Location = new System.Drawing.Point(801, 10);
			this.lblLimpiar.Name = "lblLimpiar";
			this.lblLimpiar.Size = new System.Drawing.Size(35, 42);
			this.lblLimpiar.TabIndex = 16;
			// 
			// cbTurno
			// 
			this.cbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTurno.FormattingEnabled = true;
			this.cbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio Día",
									"Nocturno",
									"Vespertino"});
			this.cbTurno.Location = new System.Drawing.Point(252, 23);
			this.cbTurno.Name = "cbTurno";
			this.cbTurno.Size = new System.Drawing.Size(121, 21);
			this.cbTurno.TabIndex = 18;
			this.cbTurno.SelectedIndexChanged += new System.EventHandler(this.CbTurnoSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(209, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Turno";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(844, 437);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(87, 42);
			this.btnGuardar.TabIndex = 19;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// cbES
			// 
			this.cbES.Location = new System.Drawing.Point(389, 20);
			this.cbES.Name = "cbES";
			this.cbES.Size = new System.Drawing.Size(125, 24);
			this.cbES.TabIndex = 20;
			this.cbES.Text = "Entradas - Salidas";
			this.cbES.UseVisualStyleBackColor = true;
			// 
			// FormPasajeros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 485);
			this.Controls.Add(this.cbES);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.cbTurno);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLimpiar);
			this.Controls.Add(this.dgServicios);
			this.Controls.Add(this.lblServicios);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.lblA);
			this.Controls.Add(this.lblDel);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.cbEmpresa);
			this.Controls.Add(this.lblEmpresa);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(931, 524);
			this.Name = "FormPasajeros";
			this.Text = "Pasajeros Servicios";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPasajerosFormClosing);
			this.Load += new System.EventHandler(this.FormPasajerosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgServicios)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox cbES;
		private System.Windows.Forms.DataGridViewTextBoxColumn LLEGADA;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTurno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.Label lblLimpiar;
		private System.Windows.Forms.DataGridViewImageColumn Update;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pasajeros;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn hora_F;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora_i;
		private System.Windows.Forms.DataGridViewTextBoxColumn KM;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERACION;
		private System.Windows.Forms.DataGridView dgServicios;
		private System.Windows.Forms.Label lblServicios;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblDel;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblEmpresa;
		private System.Windows.Forms.ComboBox cbEmpresa;
	}
}
