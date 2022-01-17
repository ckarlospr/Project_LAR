/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 10/09/2012
 * Time: 01:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Contrato
{
	partial class FormHistorialContrato
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialContrato));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ptcontrato = new System.Windows.Forms.PictureBox();
			this.dataContrato = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaInicioContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombrePatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NacionalidadPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EdadPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SexoPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EstadoCivilPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DomicilioPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TiempoCelebracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServicioPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LugarDesempeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DuracionJornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImpuestoRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LugarPaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoFirmaPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Elaboro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnReporte = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnModificar = new System.Windows.Forms.Button();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ptcontrato)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataContrato)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ptcontrato
			// 
			this.ptcontrato.BackColor = System.Drawing.Color.White;
			this.ptcontrato.Image = ((System.Drawing.Image)(resources.GetObject("ptcontrato.Image")));
			this.ptcontrato.Location = new System.Drawing.Point(15, 3);
			this.ptcontrato.Name = "ptcontrato";
			this.ptcontrato.Size = new System.Drawing.Size(63, 54);
			this.ptcontrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptcontrato.TabIndex = 17;
			this.ptcontrato.TabStop = false;
			// 
			// dataContrato
			// 
			this.dataContrato.AllowUserToAddRows = false;
			this.dataContrato.AllowUserToDeleteRows = false;
			this.dataContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataContrato.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataContrato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataContrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Column1,
									this.Alias,
									this.FechaInicioContrato,
									this.Fecha,
									this.Hora,
									this.NombrePatron,
									this.NacionalidadPatron,
									this.EdadPatron,
									this.SexoPatron,
									this.EstadoCivilPatron,
									this.DomicilioPatron,
									this.Nacionalidad,
									this.Sexo,
									this.TiempoCelebracion,
									this.ServicioPersonal,
									this.LugarDesempeno,
									this.DuracionJornada,
									this.Tarifa,
									this.ImpuestoRenta,
									this.DiasPago,
									this.LugarPaga,
									this.Vacaciones,
									this.LoFirmaPor,
									this.Elaboro,
									this.TipoContrato});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataContrato.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataContrato.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataContrato.Location = new System.Drawing.Point(12, 233);
			this.dataContrato.Name = "dataContrato";
			this.dataContrato.ReadOnly = true;
			this.dataContrato.RowHeadersVisible = false;
			this.dataContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataContrato.Size = new System.Drawing.Size(1338, 451);
			this.dataContrato.TabIndex = 8;
			this.dataContrato.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataContratoCellEnter);
			this.dataContrato.Click += new System.EventHandler(this.DataContratoClick);
			this.dataContrato.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataContratoMouseClick);
			this.dataContrato.MouseLeave += new System.EventHandler(this.DataContratoMouseLeave);
			this.dataContrato.MouseHover += new System.EventHandler(this.DataContratoMouseHover);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "IdOperador";
			this.Column1.HeaderText = "Id_O";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Alias
			// 
			this.Alias.DataPropertyName = "Alias";
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			// 
			// FechaInicioContrato
			// 
			this.FechaInicioContrato.DataPropertyName = "FechaInicioContrato";
			this.FechaInicioContrato.HeaderText = "Fecha Inicio Contrato";
			this.FechaInicioContrato.Name = "FechaInicioContrato";
			this.FechaInicioContrato.ReadOnly = true;
			// 
			// Fecha
			// 
			this.Fecha.DataPropertyName = "Fecha";
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			this.Fecha.Visible = false;
			// 
			// Hora
			// 
			this.Hora.DataPropertyName = "Hora";
			this.Hora.HeaderText = "Hora";
			this.Hora.Name = "Hora";
			this.Hora.ReadOnly = true;
			this.Hora.Visible = false;
			// 
			// NombrePatron
			// 
			this.NombrePatron.DataPropertyName = "NombrePatron";
			this.NombrePatron.HeaderText = "Nombre Patrón";
			this.NombrePatron.Name = "NombrePatron";
			this.NombrePatron.ReadOnly = true;
			this.NombrePatron.Visible = false;
			// 
			// NacionalidadPatron
			// 
			this.NacionalidadPatron.DataPropertyName = "NacionalidadPatron";
			this.NacionalidadPatron.HeaderText = "Nacionalidad Patrón";
			this.NacionalidadPatron.Name = "NacionalidadPatron";
			this.NacionalidadPatron.ReadOnly = true;
			this.NacionalidadPatron.Visible = false;
			// 
			// EdadPatron
			// 
			this.EdadPatron.DataPropertyName = "EdadPatron";
			this.EdadPatron.HeaderText = "Edad Patrón";
			this.EdadPatron.Name = "EdadPatron";
			this.EdadPatron.ReadOnly = true;
			this.EdadPatron.Visible = false;
			// 
			// SexoPatron
			// 
			this.SexoPatron.DataPropertyName = "SexoPatron";
			this.SexoPatron.HeaderText = "Sexo del Patrón";
			this.SexoPatron.Name = "SexoPatron";
			this.SexoPatron.ReadOnly = true;
			this.SexoPatron.Visible = false;
			// 
			// EstadoCivilPatron
			// 
			this.EstadoCivilPatron.DataPropertyName = "EstadoCivilPatron";
			this.EstadoCivilPatron.HeaderText = "Estado Civil Patrón";
			this.EstadoCivilPatron.Name = "EstadoCivilPatron";
			this.EstadoCivilPatron.ReadOnly = true;
			this.EstadoCivilPatron.Visible = false;
			// 
			// DomicilioPatron
			// 
			this.DomicilioPatron.DataPropertyName = "DomicilioPatron";
			this.DomicilioPatron.HeaderText = "Domicilio Patrón";
			this.DomicilioPatron.Name = "DomicilioPatron";
			this.DomicilioPatron.ReadOnly = true;
			this.DomicilioPatron.Visible = false;
			// 
			// Nacionalidad
			// 
			this.Nacionalidad.DataPropertyName = "Nacionalidad";
			this.Nacionalidad.HeaderText = "Nacionalidad";
			this.Nacionalidad.Name = "Nacionalidad";
			this.Nacionalidad.ReadOnly = true;
			// 
			// Sexo
			// 
			this.Sexo.DataPropertyName = "Sexo";
			this.Sexo.HeaderText = "Sexo";
			this.Sexo.Name = "Sexo";
			this.Sexo.ReadOnly = true;
			// 
			// TiempoCelebracion
			// 
			this.TiempoCelebracion.DataPropertyName = "TiempoCelebracion";
			this.TiempoCelebracion.HeaderText = "Tiempo Celebración";
			this.TiempoCelebracion.Name = "TiempoCelebracion";
			this.TiempoCelebracion.ReadOnly = true;
			// 
			// ServicioPersonal
			// 
			this.ServicioPersonal.DataPropertyName = "ServicioPersonal";
			this.ServicioPersonal.HeaderText = "Servicio Personal";
			this.ServicioPersonal.Name = "ServicioPersonal";
			this.ServicioPersonal.ReadOnly = true;
			// 
			// LugarDesempeno
			// 
			this.LugarDesempeno.DataPropertyName = "LugarDesempeno";
			this.LugarDesempeno.HeaderText = "Lugar Desempeno";
			this.LugarDesempeno.Name = "LugarDesempeno";
			this.LugarDesempeno.ReadOnly = true;
			// 
			// DuracionJornada
			// 
			this.DuracionJornada.DataPropertyName = "DuracionJornada";
			this.DuracionJornada.HeaderText = "Duracion Jornada";
			this.DuracionJornada.Name = "DuracionJornada";
			this.DuracionJornada.ReadOnly = true;
			// 
			// Tarifa
			// 
			this.Tarifa.DataPropertyName = "Tarifa";
			this.Tarifa.HeaderText = "Tarifa";
			this.Tarifa.Name = "Tarifa";
			this.Tarifa.ReadOnly = true;
			// 
			// ImpuestoRenta
			// 
			this.ImpuestoRenta.DataPropertyName = "ImpuestoRenta";
			this.ImpuestoRenta.HeaderText = "Impuesto Renta";
			this.ImpuestoRenta.Name = "ImpuestoRenta";
			this.ImpuestoRenta.ReadOnly = true;
			// 
			// DiasPago
			// 
			this.DiasPago.DataPropertyName = "DiasPago";
			this.DiasPago.HeaderText = "Días Pago";
			this.DiasPago.Name = "DiasPago";
			this.DiasPago.ReadOnly = true;
			// 
			// LugarPaga
			// 
			this.LugarPaga.DataPropertyName = "LugarPaga";
			this.LugarPaga.HeaderText = "Tipo Pago";
			this.LugarPaga.Name = "LugarPaga";
			this.LugarPaga.ReadOnly = true;
			// 
			// Vacaciones
			// 
			this.Vacaciones.DataPropertyName = "Vacaciones";
			this.Vacaciones.HeaderText = "Vacaciones";
			this.Vacaciones.Name = "Vacaciones";
			this.Vacaciones.ReadOnly = true;
			// 
			// LoFirmaPor
			// 
			this.LoFirmaPor.DataPropertyName = "LoFirmaPor";
			this.LoFirmaPor.HeaderText = "Lo Firma ";
			this.LoFirmaPor.Name = "LoFirmaPor";
			this.LoFirmaPor.ReadOnly = true;
			// 
			// Elaboro
			// 
			this.Elaboro.DataPropertyName = "LugarFirma";
			this.Elaboro.HeaderText = "Elaboró";
			this.Elaboro.Name = "Elaboro";
			this.Elaboro.ReadOnly = true;
			// 
			// TipoContrato
			// 
			this.TipoContrato.DataPropertyName = "TipoContrato";
			this.TipoContrato.HeaderText = "Tipo Contrato";
			this.TipoContrato.Name = "TipoContrato";
			this.TipoContrato.ReadOnly = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(86, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(322, 14);
			this.label6.TabIndex = 15;
			this.label6.Text = "Ingrese los datos del operador para realizar la búsqueda:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Controls.Add(this.btnReporte);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.txtApellidoP);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtApellidoM);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.btnModificar);
			this.panel2.Controls.Add(this.txtAlias);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 63);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1338, 164);
			this.panel2.TabIndex = 14;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(1234, 124);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(84, 28);
			this.btnEliminar.TabIndex = 56;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnReporte
			// 
			this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReporte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
			this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReporte.Location = new System.Drawing.Point(1000, 124);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(116, 28);
			this.btnReporte.TabIndex = 5;
			this.btnReporte.Text = "Reporte Excel";
			this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReporte.UseVisualStyleBackColor = true;
			this.btnReporte.Click += new System.EventHandler(this.BtnReporteClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(112, 54);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(185, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombreTextChanged);
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoP.Location = new System.Drawing.Point(112, 84);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(185, 20);
			this.txtApellidoP.TabIndex = 3;
			this.txtApellidoP.TextChanged += new System.EventHandler(this.TxtApellidoPTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(48, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 14);
			this.label2.TabIndex = 47;
			this.label2.Text = "Nombre(s):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 14);
			this.label5.TabIndex = 51;
			this.label5.Text = "Apellido paterno:";
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoM.Location = new System.Drawing.Point(112, 115);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(185, 20);
			this.txtApellidoM.TabIndex = 4;
			this.txtApellidoM.TextChanged += new System.EventHandler(this.TxtApellidoMTextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(18, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 14);
			this.label7.TabIndex = 49;
			this.label7.Text = "Apellido materno:";
			// 
			// btnModificar
			// 
			this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(1129, 124);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(94, 28);
			this.btnModificar.TabIndex = 7;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// txtAlias
			// 
			this.txtAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(112, 28);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(185, 20);
			this.txtAlias.TabIndex = 1;
			this.txtAlias.TextChanged += new System.EventHandler(this.TxtAliasTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(74, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 14);
			this.label4.TabIndex = 41;
			this.label4.Text = "Alias:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1337, 16);
			this.label1.TabIndex = 34;
			this.label1.Text = "Datos personales del usuario:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1376, 81);
			this.label3.TabIndex = 18;
			// 
			// FormHistorialContrato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1362, 696);
			this.Controls.Add(this.ptcontrato);
			this.Controls.Add(this.dataContrato);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormHistorialContrato";
			this.Text = "Transportes LAR - Historial del Contrato";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHistorialContratoFormClosing);
			this.Load += new System.EventHandler(this.FormHistorialContratoLoad);
			((System.ComponentModel.ISupportInitialize)(this.ptcontrato)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataContrato)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		//private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dataContrato;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoContrato;
		private System.Windows.Forms.DataGridViewTextBoxColumn Elaboro;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoFirmaPor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vacaciones;
		private System.Windows.Forms.DataGridViewTextBoxColumn LugarPaga;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiasPago;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImpuestoRenta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
		private System.Windows.Forms.DataGridViewTextBoxColumn DuracionJornada;
		private System.Windows.Forms.DataGridViewTextBoxColumn LugarDesempeno;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServicioPersonal;
		private System.Windows.Forms.DataGridViewTextBoxColumn TiempoCelebracion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioPatron;
		private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivilPatron;
		private System.Windows.Forms.DataGridViewTextBoxColumn SexoPatron;
		private System.Windows.Forms.DataGridViewTextBoxColumn EdadPatron;
		private System.Windows.Forms.DataGridViewTextBoxColumn NacionalidadPatron;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombrePatron;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioContrato;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox ptcontrato;
	}
}
