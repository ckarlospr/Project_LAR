/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 11/07/2017
 * Time: 12:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormRegistar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistar));
			this.btnLimpiarAI = new System.Windows.Forms.Button();
			this.pnAspectosIniciales = new System.Windows.Forms.Panel();
			this.btnMessageZona = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbZona = new System.Windows.Forms.ComboBox();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.cmbEstadoFederal = new System.Windows.Forms.ComboBox();
			this.cmbEstadoEstatal = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNumLicFederal = new System.Windows.Forms.TextBox();
			this.lblFederal = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtNumLicEstatal = new System.Windows.Forms.TextBox();
			this.lblEstatal = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label44 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.gnExperiencia = new System.Windows.Forms.GroupBox();
			this.label55 = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.label60 = new System.Windows.Forms.Label();
			this.txtTransPersonalM = new System.Windows.Forms.TextBox();
			this.txtDirTraseraM = new System.Windows.Forms.TextBox();
			this.txtDualM = new System.Windows.Forms.TextBox();
			this.txtTransPersonalA = new System.Windows.Forms.TextBox();
			this.txtDirTraseraA = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDualA = new System.Windows.Forms.TextBox();
			this.lblTrasera = new System.Windows.Forms.Label();
			this.lblPersonal = new System.Windows.Forms.Label();
			this.lblTipoFederal = new System.Windows.Forms.Label();
			this.lblMedico = new System.Windows.Forms.Label();
			this.lblTipoEstatal = new System.Windows.Forms.Label();
			this.txtNumLicAptoMedico = new System.Windows.Forms.TextBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.cmbTipoLicEstatal = new System.Windows.Forms.ComboBox();
			this.cmbTipoLicFederal = new System.Windows.Forms.ComboBox();
			this.dtpVigenciaLicEstatal = new System.Windows.Forms.DateTimePicker();
			this.dtpVigenciaLicFederal = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpVigenciaLicAptoMedico = new System.Windows.Forms.DateTimePicker();
			this.lblA_NombreOperador = new System.Windows.Forms.Label();
			this.lblA_ApPatOperador = new System.Windows.Forms.Label();
			this.lblA_ApMatOperador = new System.Windows.Forms.Label();
			this.lblTodos = new System.Windows.Forms.Label();
			this.cmbTipoOperador = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.pnFondo = new System.Windows.Forms.Panel();
			this.lblIngreso = new System.Windows.Forms.Label();
			this.pnAspectosIniciales.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gnExperiencia.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.pnFondo.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLimpiarAI
			// 
			this.btnLimpiarAI.AutoSize = true;
			this.btnLimpiarAI.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarAI.Image")));
			this.btnLimpiarAI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLimpiarAI.Location = new System.Drawing.Point(316, 278);
			this.btnLimpiarAI.Name = "btnLimpiarAI";
			this.btnLimpiarAI.Size = new System.Drawing.Size(30, 31);
			this.btnLimpiarAI.TabIndex = 30;
			this.btnLimpiarAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLimpiarAI.UseVisualStyleBackColor = true;
			this.btnLimpiarAI.Click += new System.EventHandler(this.BtnLimpiarAIClick);
			// 
			// pnAspectosIniciales
			// 
			this.pnAspectosIniciales.Controls.Add(this.btnMessageZona);
			this.pnAspectosIniciales.Controls.Add(this.label8);
			this.pnAspectosIniciales.Controls.Add(this.cmbZona);
			this.pnAspectosIniciales.Controls.Add(this.txtColonia);
			this.pnAspectosIniciales.Controls.Add(this.label20);
			this.pnAspectosIniciales.Controls.Add(this.cmbEstadoFederal);
			this.pnAspectosIniciales.Controls.Add(this.btnLimpiarAI);
			this.pnAspectosIniciales.Controls.Add(this.cmbEstadoEstatal);
			this.pnAspectosIniciales.Controls.Add(this.label4);
			this.pnAspectosIniciales.Controls.Add(this.btnGuardar);
			this.pnAspectosIniciales.Controls.Add(this.txtNumLicFederal);
			this.pnAspectosIniciales.Controls.Add(this.lblFederal);
			this.pnAspectosIniciales.Controls.Add(this.txtNombre);
			this.pnAspectosIniciales.Controls.Add(this.txtNumLicEstatal);
			this.pnAspectosIniciales.Controls.Add(this.lblEstatal);
			this.pnAspectosIniciales.Controls.Add(this.panel1);
			this.pnAspectosIniciales.Controls.Add(this.gnExperiencia);
			this.pnAspectosIniciales.Controls.Add(this.lblTipoFederal);
			this.pnAspectosIniciales.Controls.Add(this.lblMedico);
			this.pnAspectosIniciales.Controls.Add(this.lblTipoEstatal);
			this.pnAspectosIniciales.Controls.Add(this.txtNumLicAptoMedico);
			this.pnAspectosIniciales.Controls.Add(this.txtApellidoP);
			this.pnAspectosIniciales.Controls.Add(this.txtApellidoM);
			this.pnAspectosIniciales.Controls.Add(this.cmbTipoLicEstatal);
			this.pnAspectosIniciales.Controls.Add(this.cmbTipoLicFederal);
			this.pnAspectosIniciales.Controls.Add(this.dtpVigenciaLicEstatal);
			this.pnAspectosIniciales.Controls.Add(this.dtpVigenciaLicFederal);
			this.pnAspectosIniciales.Controls.Add(this.label10);
			this.pnAspectosIniciales.Controls.Add(this.dtpVigenciaLicAptoMedico);
			this.pnAspectosIniciales.Controls.Add(this.lblA_NombreOperador);
			this.pnAspectosIniciales.Controls.Add(this.lblA_ApPatOperador);
			this.pnAspectosIniciales.Controls.Add(this.lblA_ApMatOperador);
			this.pnAspectosIniciales.Enabled = false;
			this.pnAspectosIniciales.Location = new System.Drawing.Point(3, 39);
			this.pnAspectosIniciales.Name = "pnAspectosIniciales";
			this.pnAspectosIniciales.Size = new System.Drawing.Size(436, 315);
			this.pnAspectosIniciales.TabIndex = 2;
			// 
			// btnMessageZona
			// 
			this.btnMessageZona.Enabled = false;
			this.btnMessageZona.Image = ((System.Drawing.Image)(resources.GetObject("btnMessageZona.Image")));
			this.btnMessageZona.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMessageZona.Location = new System.Drawing.Point(281, 121);
			this.btnMessageZona.Name = "btnMessageZona";
			this.btnMessageZona.Size = new System.Drawing.Size(147, 25);
			this.btnMessageZona.TabIndex = 12;
			this.btnMessageZona.Text = "Filtro por Zona";
			this.btnMessageZona.UseVisualStyleBackColor = true;
			this.btnMessageZona.Click += new System.EventHandler(this.BtnMessageZonaClick);
			this.btnMessageZona.Leave += new System.EventHandler(this.BtnMessageZonaLeave);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(275, 37);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Zona:";
			// 
			// cmbZona
			// 
			this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZona.FormattingEnabled = true;
			this.cmbZona.Items.AddRange(new object[] {
									"AMECA",
									"CENTRO",
									"EL SALTO",
									"GUADALAJARA",
									"IXTLAHUACAN",
									"LOMA DORADA",
									"NORTE",
									"OBLATOS",
									"PONCITLAN",
									"SABINOS",
									"SAUZ",
									"SUR",
									"TALA",
									"TLAJOMULCO",
									"TLAQUEPAQUE",
									"TONALA",
									"ZAPOPAN",
									"ZAPOTLANEJO"});
			this.cmbZona.Location = new System.Drawing.Point(312, 33);
			this.cmbZona.Name = "cmbZona";
			this.cmbZona.Size = new System.Drawing.Size(120, 21);
			this.cmbZona.TabIndex = 10;
			this.cmbZona.SelectedIndexChanged += new System.EventHandler(this.CmbZonaSelectedIndexChanged);
			this.cmbZona.Leave += new System.EventHandler(this.CmbZonaLeave);
			// 
			// txtColonia
			// 
			this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColonia.Location = new System.Drawing.Point(312, 8);
			this.txtColonia.MaxLength = 50;
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(120, 20);
			this.txtColonia.TabIndex = 8;
			this.txtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtColonia.TextChanged += new System.EventHandler(this.TxtColoniaTextChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(268, 10);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(45, 14);
			this.label20.TabIndex = 7;
			this.label20.Text = "Colonia:";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbEstadoFederal
			// 
			this.cmbEstadoFederal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstadoFederal.FormattingEnabled = true;
			this.cmbEstadoFederal.Items.AddRange(new object[] {
									"JAL",
									"AGS",
									"BC",
									"BCS",
									"CAM",
									"CHP",
									"CHH",
									"COA",
									"COL",
									"CMX",
									"DUR",
									"GUA",
									"GRO",
									"HID",
									"MEX",
									"MIC",
									"MOR",
									"NAY",
									"NLE",
									"OAX",
									"PUE",
									"QUE",
									"ROO",
									"SLP",
									"SIN",
									"SON",
									"TAB",
									"TAM",
									"TLA",
									"VER",
									"YUC",
									"ZAC"});
			this.cmbEstadoFederal.Location = new System.Drawing.Point(141, 234);
			this.cmbEstadoFederal.Name = "cmbEstadoFederal";
			this.cmbEstadoFederal.Size = new System.Drawing.Size(60, 21);
			this.cmbEstadoFederal.TabIndex = 23;
			// 
			// cmbEstadoEstatal
			// 
			this.cmbEstadoEstatal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstadoEstatal.FormattingEnabled = true;
			this.cmbEstadoEstatal.Items.AddRange(new object[] {
									"JAL",
									"AGS",
									"BC",
									"BCS",
									"CAM",
									"CHP",
									"CHH",
									"COA",
									"COL",
									"CMX",
									"DUR",
									"GUA",
									"GRO",
									"HID",
									"MEX",
									"MIC",
									"MOR",
									"NAY",
									"NLE",
									"OAX",
									"PUE",
									"QUE",
									"ROO",
									"SLP",
									"SIN",
									"SON",
									"TAB",
									"TAM",
									"TLA",
									"VER",
									"YUC",
									"ZAC"});
			this.cmbEstadoEstatal.Location = new System.Drawing.Point(141, 213);
			this.cmbEstadoEstatal.Name = "cmbEstadoEstatal";
			this.cmbEstadoEstatal.Size = new System.Drawing.Size(60, 21);
			this.cmbEstadoEstatal.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(433, 3);
			this.label4.TabIndex = 11;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnGuardar
			// 
			this.btnGuardar.AutoSize = true;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.Location = new System.Drawing.Point(352, 277);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(77, 31);
			this.btnGuardar.TabIndex = 29;
			this.btnGuardar.Text = "Aceptar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtNumLicFederal
			// 
			this.txtNumLicFederal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumLicFederal.Location = new System.Drawing.Point(201, 233);
			this.txtNumLicFederal.MaxLength = 30;
			this.txtNumLicFederal.Name = "txtNumLicFederal";
			this.txtNumLicFederal.Size = new System.Drawing.Size(150, 20);
			this.txtNumLicFederal.TabIndex = 24;
			this.txtNumLicFederal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblFederal
			// 
			this.lblFederal.AutoSize = true;
			this.lblFederal.Location = new System.Drawing.Point(8, 237);
			this.lblFederal.Name = "lblFederal";
			this.lblFederal.Size = new System.Drawing.Size(45, 13);
			this.lblFederal.TabIndex = 21;
			this.lblFederal.Text = "Federal:";
			this.lblFederal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Location = new System.Drawing.Point(102, 8);
			this.txtNombre.MaxLength = 40;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(165, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombreTextChanged);
			this.txtNombre.Leave += new System.EventHandler(this.TxtNombreLeave);
			// 
			// txtNumLicEstatal
			// 
			this.txtNumLicEstatal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumLicEstatal.Location = new System.Drawing.Point(201, 213);
			this.txtNumLicEstatal.MaxLength = 30;
			this.txtNumLicEstatal.Name = "txtNumLicEstatal";
			this.txtNumLicEstatal.Size = new System.Drawing.Size(150, 20);
			this.txtNumLicEstatal.TabIndex = 19;
			this.txtNumLicEstatal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblEstatal
			// 
			this.lblEstatal.AutoSize = true;
			this.lblEstatal.Location = new System.Drawing.Point(10, 216);
			this.lblEstatal.Name = "lblEstatal";
			this.lblEstatal.Size = new System.Drawing.Size(42, 13);
			this.lblEstatal.TabIndex = 16;
			this.lblEstatal.Text = "Estatal:";
			this.lblEstatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.label44);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Location = new System.Drawing.Point(10, 188);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(419, 25);
			this.panel1.TabIndex = 15;
			// 
			// label44
			// 
			this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label44.AutoSize = true;
			this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label44.Location = new System.Drawing.Point(107, 2);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(60, 20);
			this.label44.TabIndex = 5;
			this.label44.Text = "Estado";
			this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(54, 1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Tipo";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(344, 2);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(70, 20);
			this.label19.TabIndex = 4;
			this.label19.Text = "Vigencia";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(5, 1);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(38, 20);
			this.label18.TabIndex = 1;
			this.label18.Text = "Doc";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(223, 3);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 20);
			this.label17.TabIndex = 3;
			this.label17.Text = "Número";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gnExperiencia
			// 
			this.gnExperiencia.Controls.Add(this.label55);
			this.gnExperiencia.Controls.Add(this.label56);
			this.gnExperiencia.Controls.Add(this.label57);
			this.gnExperiencia.Controls.Add(this.label58);
			this.gnExperiencia.Controls.Add(this.label59);
			this.gnExperiencia.Controls.Add(this.label60);
			this.gnExperiencia.Controls.Add(this.txtTransPersonalM);
			this.gnExperiencia.Controls.Add(this.txtDirTraseraM);
			this.gnExperiencia.Controls.Add(this.txtDualM);
			this.gnExperiencia.Controls.Add(this.txtTransPersonalA);
			this.gnExperiencia.Controls.Add(this.txtDirTraseraA);
			this.gnExperiencia.Controls.Add(this.label9);
			this.gnExperiencia.Controls.Add(this.txtDualA);
			this.gnExperiencia.Controls.Add(this.lblTrasera);
			this.gnExperiencia.Controls.Add(this.lblPersonal);
			this.gnExperiencia.Location = new System.Drawing.Point(7, 89);
			this.gnExperiencia.Name = "gnExperiencia";
			this.gnExperiencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gnExperiencia.Size = new System.Drawing.Size(260, 90);
			this.gnExperiencia.TabIndex = 13;
			this.gnExperiencia.TabStop = false;
			this.gnExperiencia.Text = "Años de Experiencia";
			// 
			// label55
			// 
			this.label55.AutoSize = true;
			this.label55.Location = new System.Drawing.Point(203, 69);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(38, 13);
			this.label55.TabIndex = 15;
			this.label55.Text = "Meses";
			this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label56
			// 
			this.label56.AutoSize = true;
			this.label56.Location = new System.Drawing.Point(132, 69);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(31, 13);
			this.label56.TabIndex = 13;
			this.label56.Text = "Años";
			this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Location = new System.Drawing.Point(203, 45);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(38, 13);
			this.label57.TabIndex = 10;
			this.label57.Text = "Meses";
			this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label58
			// 
			this.label58.AutoSize = true;
			this.label58.Location = new System.Drawing.Point(132, 46);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(31, 13);
			this.label58.TabIndex = 8;
			this.label58.Text = "Años";
			this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label59
			// 
			this.label59.AutoSize = true;
			this.label59.Location = new System.Drawing.Point(203, 23);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(38, 13);
			this.label59.TabIndex = 5;
			this.label59.Text = "Meses";
			this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label60
			// 
			this.label60.AutoSize = true;
			this.label60.Location = new System.Drawing.Point(132, 21);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(31, 13);
			this.label60.TabIndex = 3;
			this.label60.Text = "Años";
			this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTransPersonalM
			// 
			this.txtTransPersonalM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTransPersonalM.Location = new System.Drawing.Point(170, 65);
			this.txtTransPersonalM.MaxLength = 2;
			this.txtTransPersonalM.Name = "txtTransPersonalM";
			this.txtTransPersonalM.Size = new System.Drawing.Size(32, 20);
			this.txtTransPersonalM.TabIndex = 14;
			this.txtTransPersonalM.Text = "0";
			this.txtTransPersonalM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTransPersonalM.TextChanged += new System.EventHandler(this.TxtTransPersonalMTextChanged);
			// 
			// txtDirTraseraM
			// 
			this.txtDirTraseraM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDirTraseraM.Location = new System.Drawing.Point(170, 42);
			this.txtDirTraseraM.MaxLength = 2;
			this.txtDirTraseraM.Name = "txtDirTraseraM";
			this.txtDirTraseraM.Size = new System.Drawing.Size(32, 20);
			this.txtDirTraseraM.TabIndex = 9;
			this.txtDirTraseraM.Text = "0";
			this.txtDirTraseraM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDirTraseraM.TextChanged += new System.EventHandler(this.TxtDirTraseraMTextChanged);
			// 
			// txtDualM
			// 
			this.txtDualM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDualM.Location = new System.Drawing.Point(170, 18);
			this.txtDualM.MaxLength = 2;
			this.txtDualM.Name = "txtDualM";
			this.txtDualM.Size = new System.Drawing.Size(32, 20);
			this.txtDualM.TabIndex = 4;
			this.txtDualM.Text = "0";
			this.txtDualM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDualM.TextChanged += new System.EventHandler(this.TxtDualMTextChanged);
			// 
			// txtTransPersonalA
			// 
			this.txtTransPersonalA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTransPersonalA.Location = new System.Drawing.Point(98, 65);
			this.txtTransPersonalA.Name = "txtTransPersonalA";
			this.txtTransPersonalA.Size = new System.Drawing.Size(34, 20);
			this.txtTransPersonalA.TabIndex = 12;
			this.txtTransPersonalA.Text = "0";
			this.txtTransPersonalA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTransPersonalA.TextChanged += new System.EventHandler(this.TxtTransPersonalATextChanged);
			// 
			// txtDirTraseraA
			// 
			this.txtDirTraseraA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDirTraseraA.Location = new System.Drawing.Point(98, 42);
			this.txtDirTraseraA.Name = "txtDirTraseraA";
			this.txtDirTraseraA.Size = new System.Drawing.Size(34, 20);
			this.txtDirTraseraA.TabIndex = 7;
			this.txtDirTraseraA.Text = "0";
			this.txtDirTraseraA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDirTraseraA.TextChanged += new System.EventHandler(this.TxtDirTraseraATextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(31, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 23);
			this.label9.TabIndex = 1;
			this.label9.Text = "Dual:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDualA
			// 
			this.txtDualA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDualA.Location = new System.Drawing.Point(98, 18);
			this.txtDualA.Name = "txtDualA";
			this.txtDualA.Size = new System.Drawing.Size(34, 20);
			this.txtDualA.TabIndex = 2;
			this.txtDualA.Text = "0";
			this.txtDualA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDualA.TextChanged += new System.EventHandler(this.TxtDualATextChanged);
			this.txtDualA.Leave += new System.EventHandler(this.TxtDualALeave);
			// 
			// lblTrasera
			// 
			this.lblTrasera.Location = new System.Drawing.Point(1, 38);
			this.lblTrasera.Name = "lblTrasera";
			this.lblTrasera.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTrasera.Size = new System.Drawing.Size(95, 23);
			this.lblTrasera.TabIndex = 6;
			this.lblTrasera.Text = "Direción Trasera:";
			this.lblTrasera.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPersonal
			// 
			this.lblPersonal.AutoSize = true;
			this.lblPersonal.Location = new System.Drawing.Point(1, 67);
			this.lblPersonal.Name = "lblPersonal";
			this.lblPersonal.Size = new System.Drawing.Size(96, 13);
			this.lblPersonal.TabIndex = 11;
			this.lblPersonal.Text = "Trans de Personal:";
			this.lblPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTipoFederal
			// 
			this.lblTipoFederal.AutoSize = true;
			this.lblTipoFederal.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblTipoFederal.Location = new System.Drawing.Point(56, 238);
			this.lblTipoFederal.Name = "lblTipoFederal";
			this.lblTipoFederal.Size = new System.Drawing.Size(0, 13);
			this.lblTipoFederal.TabIndex = 49;
			this.lblTipoFederal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblMedico
			// 
			this.lblMedico.AutoSize = true;
			this.lblMedico.Location = new System.Drawing.Point(129, 257);
			this.lblMedico.Name = "lblMedico";
			this.lblMedico.Size = new System.Drawing.Size(70, 13);
			this.lblMedico.TabIndex = 26;
			this.lblMedico.Text = "Apto Medico:";
			this.lblMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTipoEstatal
			// 
			this.lblTipoEstatal.AutoSize = true;
			this.lblTipoEstatal.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lblTipoEstatal.Location = new System.Drawing.Point(56, 217);
			this.lblTipoEstatal.Name = "lblTipoEstatal";
			this.lblTipoEstatal.Size = new System.Drawing.Size(0, 13);
			this.lblTipoEstatal.TabIndex = 43;
			this.lblTipoEstatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNumLicAptoMedico
			// 
			this.txtNumLicAptoMedico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumLicAptoMedico.Location = new System.Drawing.Point(201, 253);
			this.txtNumLicAptoMedico.MaxLength = 30;
			this.txtNumLicAptoMedico.Name = "txtNumLicAptoMedico";
			this.txtNumLicAptoMedico.Size = new System.Drawing.Size(150, 20);
			this.txtNumLicAptoMedico.TabIndex = 27;
			this.txtNumLicAptoMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoP.Location = new System.Drawing.Point(102, 33);
			this.txtApellidoP.MaxLength = 30;
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(165, 20);
			this.txtApellidoP.TabIndex = 4;
			this.txtApellidoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtApellidoP.TextChanged += new System.EventHandler(this.TxtApellidoPTextChanged);
			this.txtApellidoP.Leave += new System.EventHandler(this.TxtApellidoPLeave);
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoM.Location = new System.Drawing.Point(102, 58);
			this.txtApellidoM.MaxLength = 30;
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(165, 20);
			this.txtApellidoM.TabIndex = 6;
			this.txtApellidoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtApellidoM.TextChanged += new System.EventHandler(this.TxtApellidoMTextChanged);
			this.txtApellidoM.Leave += new System.EventHandler(this.TxtApellidoMLeave);
			// 
			// cmbTipoLicEstatal
			// 
			this.cmbTipoLicEstatal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoLicEstatal.FormattingEnabled = true;
			this.cmbTipoLicEstatal.Items.AddRange(new object[] {
									"-",
									"C4",
									"CHOFER",
									"C1",
									"C2",
									"C3",
									"C5",
									"COND SERV"});
			this.cmbTipoLicEstatal.Location = new System.Drawing.Point(53, 213);
			this.cmbTipoLicEstatal.Name = "cmbTipoLicEstatal";
			this.cmbTipoLicEstatal.Size = new System.Drawing.Size(88, 21);
			this.cmbTipoLicEstatal.TabIndex = 17;
			this.cmbTipoLicEstatal.SelectedIndexChanged += new System.EventHandler(this.CmbTipoLicEstatalSelectedIndexChanged);
			// 
			// cmbTipoLicFederal
			// 
			this.cmbTipoLicFederal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoLicFederal.FormattingEnabled = true;
			this.cmbTipoLicFederal.Items.AddRange(new object[] {
									"-",
									"A",
									"B",
									"E",
									"F"});
			this.cmbTipoLicFederal.Location = new System.Drawing.Point(53, 234);
			this.cmbTipoLicFederal.Name = "cmbTipoLicFederal";
			this.cmbTipoLicFederal.Size = new System.Drawing.Size(88, 21);
			this.cmbTipoLicFederal.TabIndex = 22;
			this.cmbTipoLicFederal.SelectedIndexChanged += new System.EventHandler(this.CmbTipoLicFederalSelectedIndexChanged);
			// 
			// dtpVigenciaLicEstatal
			// 
			this.dtpVigenciaLicEstatal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpVigenciaLicEstatal.Location = new System.Drawing.Point(351, 213);
			this.dtpVigenciaLicEstatal.Name = "dtpVigenciaLicEstatal";
			this.dtpVigenciaLicEstatal.Size = new System.Drawing.Size(78, 20);
			this.dtpVigenciaLicEstatal.TabIndex = 20;
			// 
			// dtpVigenciaLicFederal
			// 
			this.dtpVigenciaLicFederal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpVigenciaLicFederal.Location = new System.Drawing.Point(351, 233);
			this.dtpVigenciaLicFederal.Name = "dtpVigenciaLicFederal";
			this.dtpVigenciaLicFederal.Size = new System.Drawing.Size(78, 20);
			this.dtpVigenciaLicFederal.TabIndex = 25;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 181);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(433, 3);
			this.label10.TabIndex = 14;
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpVigenciaLicAptoMedico
			// 
			this.dtpVigenciaLicAptoMedico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpVigenciaLicAptoMedico.Location = new System.Drawing.Point(351, 253);
			this.dtpVigenciaLicAptoMedico.Name = "dtpVigenciaLicAptoMedico";
			this.dtpVigenciaLicAptoMedico.Size = new System.Drawing.Size(78, 20);
			this.dtpVigenciaLicAptoMedico.TabIndex = 28;
			// 
			// lblA_NombreOperador
			// 
			this.lblA_NombreOperador.AutoSize = true;
			this.lblA_NombreOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_NombreOperador.Location = new System.Drawing.Point(39, 11);
			this.lblA_NombreOperador.Name = "lblA_NombreOperador";
			this.lblA_NombreOperador.Size = new System.Drawing.Size(61, 14);
			this.lblA_NombreOperador.TabIndex = 0;
			this.lblA_NombreOperador.Text = "Nombre(s):";
			// 
			// lblA_ApPatOperador
			// 
			this.lblA_ApPatOperador.AutoSize = true;
			this.lblA_ApPatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApPatOperador.Location = new System.Drawing.Point(11, 37);
			this.lblA_ApPatOperador.Name = "lblA_ApPatOperador";
			this.lblA_ApPatOperador.Size = new System.Drawing.Size(88, 14);
			this.lblA_ApPatOperador.TabIndex = 3;
			this.lblA_ApPatOperador.Text = "Apellido Paterno:";
			// 
			// lblA_ApMatOperador
			// 
			this.lblA_ApMatOperador.AutoSize = true;
			this.lblA_ApMatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApMatOperador.Location = new System.Drawing.Point(10, 61);
			this.lblA_ApMatOperador.Name = "lblA_ApMatOperador";
			this.lblA_ApMatOperador.Size = new System.Drawing.Size(90, 14);
			this.lblA_ApMatOperador.TabIndex = 5;
			this.lblA_ApMatOperador.Text = "Apellido Materno:";
			this.lblA_ApMatOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTodos
			// 
			this.lblTodos.Image = ((System.Drawing.Image)(resources.GetObject("lblTodos.Image")));
			this.lblTodos.Location = new System.Drawing.Point(408, 5);
			this.lblTodos.Name = "lblTodos";
			this.lblTodos.Size = new System.Drawing.Size(24, 24);
			this.lblTodos.TabIndex = 58;
			this.lblTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblTodos.DoubleClick += new System.EventHandler(this.LblTodosDoubleClick);
			// 
			// cmbTipoOperador
			// 
			this.cmbTipoOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoOperador.FormattingEnabled = true;
			this.cmbTipoOperador.Items.AddRange(new object[] {
									"Seleccione Opción",
									"Nuevo Ingreso",
									"Reingreso"});
			this.cmbTipoOperador.Location = new System.Drawing.Point(5, 7);
			this.cmbTipoOperador.Name = "cmbTipoOperador";
			this.cmbTipoOperador.Size = new System.Drawing.Size(165, 21);
			this.cmbTipoOperador.TabIndex = 1;
			this.cmbTipoOperador.SelectedIndexChanged += new System.EventHandler(this.CmbTipoOperadorSelectedIndexChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// pnFondo
			// 
			this.pnFondo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pnFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.pnFondo.Controls.Add(this.lblIngreso);
			this.pnFondo.Controls.Add(this.lblTodos);
			this.pnFondo.Controls.Add(this.cmbTipoOperador);
			this.pnFondo.Location = new System.Drawing.Point(3, 4);
			this.pnFondo.Name = "pnFondo";
			this.pnFondo.Size = new System.Drawing.Size(436, 35);
			this.pnFondo.TabIndex = 1;
			// 
			// lblIngreso
			// 
			this.lblIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIngreso.BackColor = System.Drawing.Color.Transparent;
			this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIngreso.Location = new System.Drawing.Point(177, 7);
			this.lblIngreso.Name = "lblIngreso";
			this.lblIngreso.Size = new System.Drawing.Size(223, 21);
			this.lblIngreso.TabIndex = 2;
			this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblIngreso.DoubleClick += new System.EventHandler(this.LblIngresoDoubleClick);
			// 
			// FormRegistar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 355);
			this.Controls.Add(this.pnFondo);
			this.Controls.Add(this.pnAspectosIniciales);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(458, 394);
			this.MinimumSize = new System.Drawing.Size(458, 394);
			this.Name = "FormRegistar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registar Candidato";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistarFormClosing);
			this.Load += new System.EventHandler(this.FormRegistarLoad);
			this.pnAspectosIniciales.ResumeLayout(false);
			this.pnAspectosIniciales.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gnExperiencia.ResumeLayout(false);
			this.gnExperiencia.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.pnFondo.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnMessageZona;
		private System.Windows.Forms.Label label20;
		public System.Windows.Forms.TextBox txtColonia;
		public System.Windows.Forms.ComboBox cmbZona;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblIngreso;
		private System.Windows.Forms.Panel pnFondo;
		private System.Windows.Forms.Label lblTodos;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		public System.Windows.Forms.ComboBox cmbTipoOperador;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblA_ApMatOperador;
		private System.Windows.Forms.Label lblA_ApPatOperador;
		private System.Windows.Forms.Label lblA_NombreOperador;
		public System.Windows.Forms.DateTimePicker dtpVigenciaLicAptoMedico;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.DateTimePicker dtpVigenciaLicFederal;
		public System.Windows.Forms.DateTimePicker dtpVigenciaLicEstatal;
		public System.Windows.Forms.ComboBox cmbTipoLicFederal;
		public System.Windows.Forms.ComboBox cmbTipoLicEstatal;
		public System.Windows.Forms.TextBox txtApellidoM;
		public System.Windows.Forms.TextBox txtApellidoP;
		public System.Windows.Forms.TextBox txtNumLicAptoMedico;
		public System.Windows.Forms.Label lblTipoEstatal;
		private System.Windows.Forms.Label lblMedico;
		public System.Windows.Forms.Label lblTipoFederal;
		private System.Windows.Forms.Label lblPersonal;
		private System.Windows.Forms.Label lblTrasera;
		public System.Windows.Forms.TextBox txtDualA;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.TextBox txtDirTraseraA;
		public System.Windows.Forms.TextBox txtTransPersonalA;
		public System.Windows.Forms.TextBox txtDualM;
		public System.Windows.Forms.TextBox txtDirTraseraM;
		public System.Windows.Forms.TextBox txtTransPersonalM;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.GroupBox gnExperiencia;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblEstatal;
		public System.Windows.Forms.TextBox txtNumLicEstatal;
		public System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblFederal;
		public System.Windows.Forms.TextBox txtNumLicFederal;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.ComboBox cmbEstadoEstatal;
		public System.Windows.Forms.ComboBox cmbEstadoFederal;
		private System.Windows.Forms.Panel pnAspectosIniciales;
		private System.Windows.Forms.Button btnLimpiarAI;
	}
}
