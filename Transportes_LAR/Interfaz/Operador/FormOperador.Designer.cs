/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 12/07/2012
 * Time: 13:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormOperador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperador));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolLicencia = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolTelefono = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolDependiente = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolContacto = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolInscripcion = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolExperiencia = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dateFechaBaja = new System.Windows.Forms.DateTimePicker();
			this.lblFechaBaja = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.cmbZona = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtcorreo = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.txtNumInfonavit = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.cbForaneo = new System.Windows.Forms.CheckBox();
			this.txtMunicipioNacimiento = new System.Windows.Forms.TextBox();
			this.txtEstadoNacimiento = new System.Windows.Forms.TextBox();
			this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.txtRFC = new System.Windows.Forms.TextBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.txtNSS = new System.Windows.Forms.TextBox();
			this.txtCurp = new System.Windows.Forms.TextBox();
			this.txtApellidoMat = new System.Windows.Forms.TextBox();
			this.txtApellidoPat = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblA_ApMatOperador = new System.Windows.Forms.Label();
			this.lblA_ApPatOperador = new System.Windows.Forms.Label();
			this.lblA_NombreOperador = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.cmbCasa = new System.Windows.Forms.ComboBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txtCP = new System.Windows.Forms.TextBox();
			this.txtNumExterior = new System.Windows.Forms.TextBox();
			this.txtNumInterior = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtReferencia2 = new System.Windows.Forms.TextBox();
			this.txtReferencia1 = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.txtMunicipio = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tpDocumentos = new System.Windows.Forms.TabPage();
			this.dataDoc = new System.Windows.Forms.DataGridView();
			this.ID_Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Validacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblSitaucion = new System.Windows.Forms.Label();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.btnImagen = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtViajesEstandarExtras = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RutaExtraEstandar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SentidoExtraEstandar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VehiculoExtraEstandar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tpDocumentos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataDoc)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtViajesEstandarExtras)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.MidnightBlue;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolLicencia,
									this.toolStripSeparator3,
									this.toolTelefono,
									this.toolStripSeparator1,
									this.toolDependiente,
									this.toolStripSeparator2,
									this.toolContacto,
									this.toolStripSeparator4,
									this.toolInscripcion,
									this.toolStripSeparator5,
									this.toolExperiencia,
									this.toolStripSeparator6});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(614, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolLicencia
			// 
			this.toolLicencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolLicencia.ForeColor = System.Drawing.Color.White;
			this.toolLicencia.Image = ((System.Drawing.Image)(resources.GetObject("toolLicencia.Image")));
			this.toolLicencia.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolLicencia.Name = "toolLicencia";
			this.toolLicencia.Size = new System.Drawing.Size(79, 22);
			this.toolLicencia.Text = "Licencias";
			this.toolLicencia.Click += new System.EventHandler(this.ToolLicenciaClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolTelefono
			// 
			this.toolTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolTelefono.ForeColor = System.Drawing.Color.White;
			this.toolTelefono.Image = ((System.Drawing.Image)(resources.GetObject("toolTelefono.Image")));
			this.toolTelefono.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolTelefono.Name = "toolTelefono";
			this.toolTelefono.Size = new System.Drawing.Size(82, 22);
			this.toolTelefono.Text = "Teléfonos";
			this.toolTelefono.Click += new System.EventHandler(this.ToolTelefonoClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolDependiente
			// 
			this.toolDependiente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolDependiente.ForeColor = System.Drawing.Color.White;
			this.toolDependiente.Image = ((System.Drawing.Image)(resources.GetObject("toolDependiente.Image")));
			this.toolDependiente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolDependiente.Name = "toolDependiente";
			this.toolDependiente.Size = new System.Drawing.Size(104, 22);
			this.toolDependiente.Text = "Dependientes";
			this.toolDependiente.Click += new System.EventHandler(this.ToolDependienteClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolContacto
			// 
			this.toolContacto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolContacto.ForeColor = System.Drawing.Color.White;
			this.toolContacto.Image = ((System.Drawing.Image)(resources.GetObject("toolContacto.Image")));
			this.toolContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolContacto.Name = "toolContacto";
			this.toolContacto.Size = new System.Drawing.Size(83, 22);
			this.toolContacto.Text = "Contactos";
			this.toolContacto.Click += new System.EventHandler(this.ToolContactoClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolInscripcion
			// 
			this.toolInscripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolInscripcion.ForeColor = System.Drawing.Color.White;
			this.toolInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("toolInscripcion.Image")));
			this.toolInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolInscripcion.Name = "toolInscripcion";
			this.toolInscripcion.Size = new System.Drawing.Size(88, 22);
			this.toolInscripcion.Text = "Inscripción";
			this.toolInscripcion.Click += new System.EventHandler(this.ToolInscripcionClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolExperiencia
			// 
			this.toolExperiencia.Enabled = false;
			this.toolExperiencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolExperiencia.ForeColor = System.Drawing.Color.White;
			this.toolExperiencia.Image = ((System.Drawing.Image)(resources.GetObject("toolExperiencia.Image")));
			this.toolExperiencia.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolExperiencia.Name = "toolExperiencia";
			this.toolExperiencia.Size = new System.Drawing.Size(90, 22);
			this.toolExperiencia.Text = "Experiencia";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(513, 551);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(87, 27);
			this.btnCancelar.TabIndex = 26;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(420, 551);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(87, 27);
			this.btnAgregar.TabIndex = 25;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(12, 25);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(402, 23);
			this.label18.TabIndex = 187;
			this.label18.Text = "Ingrese los datos correspondientes al empleado:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.dateFechaBaja);
			this.panel1.Controls.Add(this.lblFechaBaja);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.cmbZona);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.tabControl2);
			this.panel1.Controls.Add(this.lblEstado);
			this.panel1.Controls.Add(this.lblSitaucion);
			this.panel1.Controls.Add(this.cmbEstado);
			this.panel1.Controls.Add(this.btnImagen);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(12, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(588, 494);
			this.panel1.TabIndex = 199;
			// 
			// dateFechaBaja
			// 
			this.dateFechaBaja.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dateFechaBaja.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
			this.dateFechaBaja.CustomFormat = "";
			this.dateFechaBaja.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFechaBaja.Location = new System.Drawing.Point(366, 403);
			this.dateFechaBaja.Name = "dateFechaBaja";
			this.dateFechaBaja.Size = new System.Drawing.Size(207, 20);
			this.dateFechaBaja.TabIndex = 210;
			this.dateFechaBaja.Visible = false;
			// 
			// lblFechaBaja
			// 
			this.lblFechaBaja.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblFechaBaja.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaBaja.Location = new System.Drawing.Point(366, 380);
			this.lblFechaBaja.Name = "lblFechaBaja";
			this.lblFechaBaja.Size = new System.Drawing.Size(207, 20);
			this.lblFechaBaja.TabIndex = 209;
			this.lblFechaBaja.Text = "Fecha última baja:";
			this.lblFechaBaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFechaBaja.Visible = false;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(366, 283);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(207, 20);
			this.label17.TabIndex = 208;
			this.label17.Text = "Zona del estado que pertenece:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbZona
			// 
			this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZona.FormattingEnabled = true;
			this.cmbZona.Location = new System.Drawing.Point(421, 306);
			this.cmbZona.Name = "cmbZona";
			this.cmbZona.Size = new System.Drawing.Size(152, 21);
			this.cmbZona.TabIndex = 23;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(380, 309);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(35, 14);
			this.label24.TabIndex = 207;
			this.label24.Text = "Zona:";
			// 
			// tabControl2
			// 
			this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl2.Controls.Add(this.tabPage2);
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tpDocumentos);
			this.tabControl2.ImageList = this.imageList1;
			this.tabControl2.Location = new System.Drawing.Point(16, 13);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(341, 464);
			this.tabControl2.TabIndex = 205;
			// 
			// tabPage2
			// 
			this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabPage2.Controls.Add(this.txtcorreo);
			this.tabPage2.Controls.Add(this.label27);
			this.tabPage2.Controls.Add(this.txtNumInfonavit);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label25);
			this.tabPage2.Controls.Add(this.cbForaneo);
			this.tabPage2.Controls.Add(this.txtMunicipioNacimiento);
			this.tabPage2.Controls.Add(this.txtEstadoNacimiento);
			this.tabPage2.Controls.Add(this.txtLugarNacimiento);
			this.tabPage2.Controls.Add(this.label22);
			this.tabPage2.Controls.Add(this.label21);
			this.tabPage2.Controls.Add(this.label20);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.dateFechaNacimiento);
			this.tabPage2.Controls.Add(this.txtRFC);
			this.tabPage2.Controls.Add(this.txtAlias);
			this.tabPage2.Controls.Add(this.txtNSS);
			this.tabPage2.Controls.Add(this.txtCurp);
			this.tabPage2.Controls.Add(this.txtApellidoMat);
			this.tabPage2.Controls.Add(this.txtApellidoPat);
			this.tabPage2.Controls.Add(this.txtNombre);
			this.tabPage2.Controls.Add(this.label19);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label23);
			this.tabPage2.Controls.Add(this.label48);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.cmbEstadoCivil);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.lblA_ApMatOperador);
			this.tabPage2.Controls.Add(this.lblA_ApPatOperador);
			this.tabPage2.Controls.Add(this.lblA_NombreOperador);
			this.tabPage2.ImageIndex = 0;
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(333, 437);
			this.tabPage2.TabIndex = 0;
			this.tabPage2.Text = "Persona";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtcorreo
			// 
			this.txtcorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtcorreo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcorreo.Location = new System.Drawing.Point(108, 287);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.Size = new System.Drawing.Size(193, 20);
			this.txtcorreo.TabIndex = 141;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(56, 289);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(43, 14);
			this.label27.TabIndex = 142;
			this.label27.Text = "Correo:";
			// 
			// txtNumInfonavit
			// 
			this.txtNumInfonavit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumInfonavit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumInfonavit.Location = new System.Drawing.Point(137, 262);
			this.txtNumInfonavit.Name = "txtNumInfonavit";
			this.txtNumInfonavit.Size = new System.Drawing.Size(164, 20);
			this.txtNumInfonavit.TabIndex = 139;
			this.txtNumInfonavit.Leave += new System.EventHandler(this.TxtNumInfonavitLeave);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(48, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 15);
			this.label5.TabIndex = 138;
			this.label5.Text = "Tipo:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(13, 266);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(118, 14);
			this.label25.TabIndex = 140;
			this.label25.Text = "Num. Cred. INFONAVIT:";
			// 
			// cbForaneo
			// 
			this.cbForaneo.Location = new System.Drawing.Point(108, 243);
			this.cbForaneo.Name = "cbForaneo";
			this.cbForaneo.Size = new System.Drawing.Size(104, 24);
			this.cbForaneo.TabIndex = 137;
			this.cbForaneo.Text = "Foraneo";
			this.cbForaneo.UseVisualStyleBackColor = true;
			// 
			// txtMunicipioNacimiento
			// 
			this.txtMunicipioNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMunicipioNacimiento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMunicipioNacimiento.Location = new System.Drawing.Point(110, 387);
			this.txtMunicipioNacimiento.Name = "txtMunicipioNacimiento";
			this.txtMunicipioNacimiento.Size = new System.Drawing.Size(196, 20);
			this.txtMunicipioNacimiento.TabIndex = 11;
			this.txtMunicipioNacimiento.Text = "N/A";
			// 
			// txtEstadoNacimiento
			// 
			this.txtEstadoNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEstadoNacimiento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstadoNacimiento.Location = new System.Drawing.Point(109, 359);
			this.txtEstadoNacimiento.Name = "txtEstadoNacimiento";
			this.txtEstadoNacimiento.Size = new System.Drawing.Size(196, 20);
			this.txtEstadoNacimiento.TabIndex = 10;
			this.txtEstadoNacimiento.Text = "N/A";
			// 
			// txtLugarNacimiento
			// 
			this.txtLugarNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtLugarNacimiento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLugarNacimiento.Location = new System.Drawing.Point(108, 334);
			this.txtLugarNacimiento.Name = "txtLugarNacimiento";
			this.txtLugarNacimiento.Size = new System.Drawing.Size(197, 20);
			this.txtLugarNacimiento.TabIndex = 9;
			this.txtLugarNacimiento.Text = "N/A";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(48, 395);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(54, 14);
			this.label22.TabIndex = 135;
			this.label22.Text = "Municipio:";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(60, 366);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(43, 14);
			this.label21.TabIndex = 134;
			this.label21.Text = "Estado:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(65, 337);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(38, 14);
			this.label20.TabIndex = 133;
			this.label20.Text = "Lugar:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 20);
			this.label1.TabIndex = 129;
			this.label1.Text = "Datos personales:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateFechaNacimiento
			// 
			this.dateFechaNacimiento.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dateFechaNacimiento.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
			this.dateFechaNacimiento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateFechaNacimiento.Location = new System.Drawing.Point(108, 413);
			this.dateFechaNacimiento.Name = "dateFechaNacimiento";
			this.dateFechaNacimiento.Size = new System.Drawing.Size(197, 20);
			this.dateFechaNacimiento.TabIndex = 12;
			this.dateFechaNacimiento.ValueChanged += new System.EventHandler(this.DateFechaNacimientoValueChanged);
			// 
			// txtRFC
			// 
			this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRFC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRFC.Location = new System.Drawing.Point(108, 168);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(197, 20);
			this.txtRFC.TabIndex = 6;
			this.txtRFC.Leave += new System.EventHandler(this.TxtRFCLeave);
			// 
			// txtAlias
			// 
			this.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(108, 32);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(197, 20);
			this.txtAlias.TabIndex = 1;
			// 
			// txtNSS
			// 
			this.txtNSS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNSS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNSS.Location = new System.Drawing.Point(109, 194);
			this.txtNSS.Name = "txtNSS";
			this.txtNSS.Size = new System.Drawing.Size(196, 20);
			this.txtNSS.TabIndex = 7;
			this.txtNSS.Leave += new System.EventHandler(this.TxtNSSLeave);
			// 
			// txtCurp
			// 
			this.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCurp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCurp.Location = new System.Drawing.Point(108, 141);
			this.txtCurp.Name = "txtCurp";
			this.txtCurp.Size = new System.Drawing.Size(197, 20);
			this.txtCurp.TabIndex = 5;
			this.txtCurp.Leave += new System.EventHandler(this.TxtCurpLeave);
			// 
			// txtApellidoMat
			// 
			this.txtApellidoMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoMat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoMat.Location = new System.Drawing.Point(108, 115);
			this.txtApellidoMat.Name = "txtApellidoMat";
			this.txtApellidoMat.Size = new System.Drawing.Size(197, 20);
			this.txtApellidoMat.TabIndex = 4;
			// 
			// txtApellidoPat
			// 
			this.txtApellidoPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoPat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoPat.Location = new System.Drawing.Point(108, 89);
			this.txtApellidoPat.Name = "txtApellidoPat";
			this.txtApellidoPat.Size = new System.Drawing.Size(197, 20);
			this.txtApellidoPat.TabIndex = 3;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(108, 62);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(197, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(62, 419);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(40, 14);
			this.label19.TabIndex = 125;
			this.label19.Text = "Fecha:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 311);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(289, 20);
			this.label4.TabIndex = 120;
			this.label4.Text = "Datos de nacimiento:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(71, 171);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(30, 14);
			this.label23.TabIndex = 119;
			this.label23.Text = "RFC:";
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label48.Location = new System.Drawing.Point(70, 35);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(34, 14);
			this.label48.TabIndex = 118;
			this.label48.Text = "Alias:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(37, 223);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 14);
			this.label12.TabIndex = 117;
			this.label12.Text = "Estado Civil:";
			// 
			// cmbEstadoCivil
			// 
			this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstadoCivil.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEstadoCivil.FormattingEnabled = true;
			this.cmbEstadoCivil.Items.AddRange(new object[] {
									"Casado",
									"Comprometido",
									"Divorciado",
									"Soltero",
									"Union Libre",
									"Viudo"});
			this.cmbEstadoCivil.Location = new System.Drawing.Point(108, 220);
			this.cmbEstadoCivil.Name = "cmbEstadoCivil";
			this.cmbEstadoCivil.Size = new System.Drawing.Size(197, 22);
			this.cmbEstadoCivil.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(70, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 14);
			this.label2.TabIndex = 116;
			this.label2.Text = "NSS:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(62, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 14);
			this.label3.TabIndex = 115;
			this.label3.Text = "CURP:";
			// 
			// lblA_ApMatOperador
			// 
			this.lblA_ApMatOperador.AutoSize = true;
			this.lblA_ApMatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApMatOperador.Location = new System.Drawing.Point(13, 118);
			this.lblA_ApMatOperador.Name = "lblA_ApMatOperador";
			this.lblA_ApMatOperador.Size = new System.Drawing.Size(90, 14);
			this.lblA_ApMatOperador.TabIndex = 109;
			this.lblA_ApMatOperador.Text = "Apellido Materno:";
			this.lblA_ApMatOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblA_ApPatOperador
			// 
			this.lblA_ApPatOperador.AutoSize = true;
			this.lblA_ApPatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApPatOperador.Location = new System.Drawing.Point(15, 92);
			this.lblA_ApPatOperador.Name = "lblA_ApPatOperador";
			this.lblA_ApPatOperador.Size = new System.Drawing.Size(88, 14);
			this.lblA_ApPatOperador.TabIndex = 107;
			this.lblA_ApPatOperador.Text = "Apellido Paterno:";
			// 
			// lblA_NombreOperador
			// 
			this.lblA_NombreOperador.AutoSize = true;
			this.lblA_NombreOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_NombreOperador.Location = new System.Drawing.Point(44, 65);
			this.lblA_NombreOperador.Name = "lblA_NombreOperador";
			this.lblA_NombreOperador.Size = new System.Drawing.Size(61, 14);
			this.lblA_NombreOperador.TabIndex = 105;
			this.lblA_NombreOperador.Text = "Nombre(s):";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.cmbCasa);
			this.tabPage3.Controls.Add(this.label26);
			this.tabPage3.Controls.Add(this.txtCP);
			this.tabPage3.Controls.Add(this.txtNumExterior);
			this.tabPage3.Controls.Add(this.txtNumInterior);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.txtReferencia2);
			this.tabPage3.Controls.Add(this.txtReferencia1);
			this.tabPage3.Controls.Add(this.txtEstado);
			this.tabPage3.Controls.Add(this.txtColonia);
			this.tabPage3.Controls.Add(this.txtMunicipio);
			this.tabPage3.Controls.Add(this.txtCalle);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.ImageIndex = 1;
			this.tabPage3.Location = new System.Drawing.Point(4, 23);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(333, 437);
			this.tabPage3.TabIndex = 1;
			this.tabPage3.Text = "Vivienda";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// cmbCasa
			// 
			this.cmbCasa.FormattingEnabled = true;
			this.cmbCasa.Items.AddRange(new object[] {
									"PROPIA",
									"RENTADA"});
			this.cmbCasa.Location = new System.Drawing.Point(135, 272);
			this.cmbCasa.Name = "cmbCasa";
			this.cmbCasa.Size = new System.Drawing.Size(169, 21);
			this.cmbCasa.TabIndex = 150;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(16, 273);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(114, 14);
			this.label26.TabIndex = 149;
			this.label26.Text = "Casa rentada o Propia";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCP
			// 
			this.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCP.Location = new System.Drawing.Point(136, 245);
			this.txtCP.Name = "txtCP";
			this.txtCP.Size = new System.Drawing.Size(94, 20);
			this.txtCP.TabIndex = 21;
			// 
			// txtNumExterior
			// 
			this.txtNumExterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumExterior.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumExterior.Location = new System.Drawing.Point(135, 193);
			this.txtNumExterior.Name = "txtNumExterior";
			this.txtNumExterior.Size = new System.Drawing.Size(94, 20);
			this.txtNumExterior.TabIndex = 19;
			// 
			// txtNumInterior
			// 
			this.txtNumInterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumInterior.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumInterior.Location = new System.Drawing.Point(135, 219);
			this.txtNumInterior.Name = "txtNumInterior";
			this.txtNumInterior.Size = new System.Drawing.Size(94, 20);
			this.txtNumInterior.TabIndex = 20;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(105, 248);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 14);
			this.label11.TabIndex = 147;
			this.label11.Text = "CP:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(43, 199);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(87, 14);
			this.label10.TabIndex = 146;
			this.label10.Text = "Numero Exterior:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(48, 225);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(83, 14);
			this.label13.TabIndex = 145;
			this.label13.Text = "Numero Interior:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(62, 170);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(69, 14);
			this.label15.TabIndex = 141;
			this.label15.Text = "Cruza con 2:";
			// 
			// txtReferencia2
			// 
			this.txtReferencia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferencia2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferencia2.Location = new System.Drawing.Point(135, 167);
			this.txtReferencia2.Name = "txtReferencia2";
			this.txtReferencia2.Size = new System.Drawing.Size(169, 20);
			this.txtReferencia2.TabIndex = 18;
			// 
			// txtReferencia1
			// 
			this.txtReferencia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferencia1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferencia1.Location = new System.Drawing.Point(136, 141);
			this.txtReferencia1.Name = "txtReferencia1";
			this.txtReferencia1.Size = new System.Drawing.Size(169, 20);
			this.txtReferencia1.TabIndex = 17;
			// 
			// txtEstado
			// 
			this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEstado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstado.Location = new System.Drawing.Point(136, 115);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(169, 20);
			this.txtEstado.TabIndex = 16;
			// 
			// txtColonia
			// 
			this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColonia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(136, 63);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(169, 20);
			this.txtColonia.TabIndex = 14;
			// 
			// txtMunicipio
			// 
			this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMunicipio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMunicipio.Location = new System.Drawing.Point(136, 89);
			this.txtMunicipio.Name = "txtMunicipio";
			this.txtMunicipio.Size = new System.Drawing.Size(169, 20);
			this.txtMunicipio.TabIndex = 15;
			// 
			// txtCalle
			// 
			this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCalle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalle.Location = new System.Drawing.Point(136, 37);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(169, 20);
			this.txtCalle.TabIndex = 13;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(62, 144);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(69, 14);
			this.label16.TabIndex = 140;
			this.label16.Text = "Cruza con 1:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(86, 118);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 14);
			this.label8.TabIndex = 136;
			this.label8.Text = "Estado:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(74, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 14);
			this.label7.TabIndex = 135;
			this.label7.Text = "Municipio:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(86, 66);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 14);
			this.label9.TabIndex = 134;
			this.label9.Text = "Colonia:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(96, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 14);
			this.label14.TabIndex = 130;
			this.label14.Text = "Calle:";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(16, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(289, 20);
			this.label6.TabIndex = 123;
			this.label6.Text = "Domicilio:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tpDocumentos
			// 
			this.tpDocumentos.Controls.Add(this.dataDoc);
			this.tpDocumentos.ImageIndex = 2;
			this.tpDocumentos.Location = new System.Drawing.Point(4, 23);
			this.tpDocumentos.Name = "tpDocumentos";
			this.tpDocumentos.Padding = new System.Windows.Forms.Padding(3);
			this.tpDocumentos.Size = new System.Drawing.Size(333, 437);
			this.tpDocumentos.TabIndex = 2;
			this.tpDocumentos.Text = "Documentos";
			this.tpDocumentos.UseVisualStyleBackColor = true;
			// 
			// dataDoc
			// 
			this.dataDoc.AllowUserToAddRows = false;
			this.dataDoc.AllowUserToResizeColumns = false;
			this.dataDoc.AllowUserToResizeRows = false;
			this.dataDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataDoc.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Doc,
									this.Documento,
									this.Tipo_doc,
									this.Cantidad,
									this.Descripcion,
									this.Validacion});
			this.dataDoc.Location = new System.Drawing.Point(3, 9);
			this.dataDoc.Name = "dataDoc";
			this.dataDoc.RowHeadersVisible = false;
			this.dataDoc.Size = new System.Drawing.Size(327, 425);
			this.dataDoc.TabIndex = 1;
			// 
			// ID_Doc
			// 
			this.ID_Doc.HeaderText = "ID";
			this.ID_Doc.Name = "ID_Doc";
			this.ID_Doc.Visible = false;
			// 
			// Documento
			// 
			this.Documento.FillWeight = 169.5432F;
			this.Documento.HeaderText = "Documento";
			this.Documento.Name = "Documento";
			// 
			// Tipo_doc
			// 
			this.Tipo_doc.HeaderText = "Tipo";
			this.Tipo_doc.Name = "Tipo_doc";
			this.Tipo_doc.ReadOnly = true;
			this.Tipo_doc.Visible = false;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			this.Cantidad.Visible = false;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Visible = false;
			// 
			// Validacion
			// 
			this.Validacion.FillWeight = 30.45685F;
			this.Validacion.HeaderText = "Check";
			this.Validacion.Name = "Validacion";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Operador_Icono.png");
			this.imageList1.Images.SetKeyName(1, "Hogar.png");
			this.imageList1.Images.SetKeyName(2, "casa-principal-de-la-carpeta-icono-9532-48.png");
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.BackColor = System.Drawing.Color.Transparent;
			this.lblEstado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstado.Location = new System.Drawing.Point(372, 362);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(43, 14);
			this.lblEstado.TabIndex = 199;
			this.lblEstado.Text = "Estado:";
			this.lblEstado.Visible = false;
			// 
			// lblSitaucion
			// 
			this.lblSitaucion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblSitaucion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSitaucion.Location = new System.Drawing.Point(366, 333);
			this.lblSitaucion.Name = "lblSitaucion";
			this.lblSitaucion.Size = new System.Drawing.Size(207, 20);
			this.lblSitaucion.TabIndex = 201;
			this.lblSitaucion.Text = "Situación actual:";
			this.lblSitaucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblSitaucion.Visible = false;
			// 
			// cmbEstado
			// 
			this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Items.AddRange(new object[] {
									"ACTIVO",
									"INACTIVO"});
			this.cmbEstado.Location = new System.Drawing.Point(421, 356);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(152, 21);
			this.cmbEstado.TabIndex = 24;
			this.cmbEstado.Visible = false;
			this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstadoSelectedIndexChanged);
			// 
			// btnImagen
			// 
			this.btnImagen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnImagen.Image")));
			this.btnImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImagen.Location = new System.Drawing.Point(366, 247);
			this.btnImagen.Name = "btnImagen";
			this.btnImagen.Size = new System.Drawing.Size(207, 23);
			this.btnImagen.TabIndex = 22;
			this.btnImagen.Text = "Cargar imagen...";
			this.btnImagen.UseVisualStyleBackColor = true;
			this.btnImagen.Click += new System.EventHandler(this.BtnImagenClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.dtViajesEstandarExtras);
			this.groupBox1.Controls.Add(this.ptbImagen);
			this.groupBox1.Location = new System.Drawing.Point(366, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(207, 208);
			this.groupBox1.TabIndex = 197;
			this.groupBox1.TabStop = false;
			// 
			// dtViajesEstandarExtras
			// 
			this.dtViajesEstandarExtras.AllowUserToAddRows = false;
			this.dtViajesEstandarExtras.AllowUserToResizeColumns = false;
			this.dtViajesEstandarExtras.AllowUserToResizeRows = false;
			this.dtViajesEstandarExtras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtViajesEstandarExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtViajesEstandarExtras.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dtViajesEstandarExtras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtViajesEstandarExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtViajesEstandarExtras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3,
									this.RutaExtraEstandar,
									this.SentidoExtraEstandar,
									this.VehiculoExtraEstandar});
			this.dtViajesEstandarExtras.Location = new System.Drawing.Point(-316, 89);
			this.dtViajesEstandarExtras.Name = "dtViajesEstandarExtras";
			this.dtViajesEstandarExtras.RowHeadersVisible = false;
			this.dtViajesEstandarExtras.Size = new System.Drawing.Size(270, 130);
			this.dtViajesEstandarExtras.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
			this.dataGridViewTextBoxColumn2.FillWeight = 10F;
			this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Turno";
			this.dataGridViewTextBoxColumn3.FillWeight = 10F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Turno";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// RutaExtraEstandar
			// 
			this.RutaExtraEstandar.FillWeight = 60F;
			this.RutaExtraEstandar.HeaderText = "Ruta";
			this.RutaExtraEstandar.Name = "RutaExtraEstandar";
			this.RutaExtraEstandar.ReadOnly = true;
			// 
			// SentidoExtraEstandar
			// 
			this.SentidoExtraEstandar.FillWeight = 10F;
			this.SentidoExtraEstandar.HeaderText = "Sentido";
			this.SentidoExtraEstandar.Name = "SentidoExtraEstandar";
			this.SentidoExtraEstandar.ReadOnly = true;
			// 
			// VehiculoExtraEstandar
			// 
			this.VehiculoExtraEstandar.FillWeight = 10F;
			this.VehiculoExtraEstandar.HeaderText = "Vehiculo";
			this.VehiculoExtraEstandar.Name = "VehiculoExtraEstandar";
			this.VehiculoExtraEstandar.ReadOnly = true;
			// 
			// ptbImagen
			// 
			this.ptbImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ptbImagen.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ptbImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptbImagen.Image")));
			this.ptbImagen.Location = new System.Drawing.Point(6, 12);
			this.ptbImagen.Name = "ptbImagen";
			this.ptbImagen.Size = new System.Drawing.Size(195, 190);
			this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagen.TabIndex = 70;
			this.ptbImagen.TabStop = false;
			// 
			// FormOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(614, 586);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOperador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Empleado";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOperadorFormClosing);
			this.Load += new System.EventHandler(this.FormOperadorLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tpDocumentos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataDoc)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtViajesEstandarExtras)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblFechaBaja;
		public System.Windows.Forms.DateTimePicker dateFechaBaja;
		private System.Windows.Forms.Label label27;
		public System.Windows.Forms.TextBox txtcorreo;
		private System.Windows.Forms.ComboBox cmbCasa;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton toolExperiencia;
		public System.Windows.Forms.TextBox txtNumInfonavit;
		private System.Windows.Forms.Label label25;
		public System.Windows.Forms.TabPage tpDocumentos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_doc;
		private System.Windows.Forms.DataGridView dataDoc;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Validacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Doc;
		private System.Windows.Forms.DataGridViewTextBoxColumn VehiculoExtraEstandar;
		private System.Windows.Forms.DataGridViewTextBoxColumn SentidoExtraEstandar;
		private System.Windows.Forms.DataGridViewTextBoxColumn RutaExtraEstandar;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridView dtViajesEstandarExtras;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton toolInscripcion;
		private System.Windows.Forms.CheckBox cbForaneo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label18;
		public System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnImagen;
		public System.Windows.Forms.ComboBox cmbEstado;
		private System.Windows.Forms.Label lblSitaucion;
		public System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label label24;
		public System.Windows.Forms.ComboBox cmbZona;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label16;
		public System.Windows.Forms.TextBox txtCalle;
		public System.Windows.Forms.TextBox txtNumInterior;
		public System.Windows.Forms.TextBox txtNumExterior;
		public System.Windows.Forms.TextBox txtMunicipio;
		public System.Windows.Forms.TextBox txtColonia;
		public System.Windows.Forms.TextBox txtEstado;
		public System.Windows.Forms.TextBox txtCP;
		public System.Windows.Forms.TextBox txtReferencia1;
		public System.Windows.Forms.TextBox txtReferencia2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lblA_NombreOperador;
		private System.Windows.Forms.Label lblA_ApPatOperador;
		private System.Windows.Forms.Label lblA_ApMatOperador;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox cmbEstadoCivil;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtApellidoPat;
		public System.Windows.Forms.TextBox txtApellidoMat;
		public System.Windows.Forms.TextBox txtCurp;
		public System.Windows.Forms.TextBox txtNSS;
		public System.Windows.Forms.TextBox txtAlias;
		public System.Windows.Forms.TextBox txtRFC;
		public System.Windows.Forms.TextBox txtLugarNacimiento;
		public System.Windows.Forms.TextBox txtEstadoNacimiento;
		public System.Windows.Forms.TextBox txtMunicipioNacimiento;
		public System.Windows.Forms.DateTimePicker dateFechaNacimiento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		public System.Windows.Forms.TabControl tabControl2;
		public System.Windows.Forms.Button btnAgregar;
		public System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.ToolStripButton toolContacto;
		private System.Windows.Forms.ToolStripButton toolDependiente;
		private System.Windows.Forms.ToolStripButton toolTelefono;
		public System.Windows.Forms.ToolStripButton toolLicencia;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
