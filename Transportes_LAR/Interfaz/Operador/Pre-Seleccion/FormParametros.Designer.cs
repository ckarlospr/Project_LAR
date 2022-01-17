/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 01/02/2017
 * Hora: 9:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormParametros
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametros));
			this.nudEdadMin = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.nudEdadMax = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbTatuajes = new System.Windows.Forms.ComboBox();
			this.txtTransPersonal = new System.Windows.Forms.TextBox();
			this.txtDirTrasera = new System.Windows.Forms.TextBox();
			this.txtDual = new System.Windows.Forms.TextBox();
			this.cmbTipoLicFederal = new System.Windows.Forms.ComboBox();
			this.cmbTipoLicEstatal = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txtVigenciaEstatal = new System.Windows.Forms.TextBox();
			this.txtVigenciaFederal = new System.Windows.Forms.TextBox();
			this.txtVigenciaMedico = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cmbPercing = new System.Windows.Forms.ComboBox();
			this.txtImagen = new System.Windows.Forms.TextBox();
			this.txtInfonavit = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label21 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.txtDescFederal = new System.Windows.Forms.TextBox();
			this.txtDescEstatal = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.txtContactoTaller = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txtNumeroTaller = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txtNumeroOficina = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtContactoOficina = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label18 = new System.Windows.Forms.Label();
			this.txtZona = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFuente = new System.Windows.Forms.TextBox();
			this.btnExcel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudEdadMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEdadMax)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// nudEdadMin
			// 
			this.nudEdadMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudEdadMin.Location = new System.Drawing.Point(156, 26);
			this.nudEdadMin.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudEdadMin.Name = "nudEdadMin";
			this.nudEdadMin.Size = new System.Drawing.Size(43, 20);
			this.nudEdadMin.TabIndex = 3;
			this.nudEdadMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudEdadMin.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.LightGray;
			this.label1.Location = new System.Drawing.Point(0, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Edad Entre:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.Location = new System.Drawing.Point(252, 507);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(72, 27);
			this.cmdGuardar.TabIndex = 49;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// nudEdadMax
			// 
			this.nudEdadMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudEdadMax.Location = new System.Drawing.Point(248, 26);
			this.nudEdadMax.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nudEdadMax.Name = "nudEdadMax";
			this.nudEdadMax.Size = new System.Drawing.Size(43, 20);
			this.nudEdadMax.TabIndex = 5;
			this.nudEdadMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudEdadMax.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(205, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "años  y";
			// 
			// cmbTatuajes
			// 
			this.cmbTatuajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTatuajes.FormattingEnabled = true;
			this.cmbTatuajes.Items.AddRange(new object[] {
									"SI",
									"NO"});
			this.cmbTatuajes.Location = new System.Drawing.Point(156, 68);
			this.cmbTatuajes.Name = "cmbTatuajes";
			this.cmbTatuajes.Size = new System.Drawing.Size(106, 21);
			this.cmbTatuajes.TabIndex = 10;
			// 
			// txtTransPersonal
			// 
			this.txtTransPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTransPersonal.Location = new System.Drawing.Point(156, 174);
			this.txtTransPersonal.MaxLength = 2;
			this.txtTransPersonal.Name = "txtTransPersonal";
			this.txtTransPersonal.Size = new System.Drawing.Size(71, 20);
			this.txtTransPersonal.TabIndex = 22;
			this.txtTransPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDirTrasera
			// 
			this.txtDirTrasera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDirTrasera.Location = new System.Drawing.Point(156, 153);
			this.txtDirTrasera.MaxLength = 2;
			this.txtDirTrasera.Name = "txtDirTrasera";
			this.txtDirTrasera.Size = new System.Drawing.Size(71, 20);
			this.txtDirTrasera.TabIndex = 19;
			this.txtDirTrasera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDual
			// 
			this.txtDual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDual.Location = new System.Drawing.Point(156, 132);
			this.txtDual.MaxLength = 2;
			this.txtDual.Name = "txtDual";
			this.txtDual.Size = new System.Drawing.Size(71, 20);
			this.txtDual.TabIndex = 16;
			this.txtDual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbTipoLicFederal
			// 
			this.cmbTipoLicFederal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoLicFederal.FormattingEnabled = true;
			this.cmbTipoLicFederal.Items.AddRange(new object[] {
									"TODAS",
									"A",
									"B",
									"E",
									"F"});
			this.cmbTipoLicFederal.Location = new System.Drawing.Point(156, 311);
			this.cmbTipoLicFederal.Name = "cmbTipoLicFederal";
			this.cmbTipoLicFederal.Size = new System.Drawing.Size(67, 21);
			this.cmbTipoLicFederal.TabIndex = 36;
			// 
			// cmbTipoLicEstatal
			// 
			this.cmbTipoLicEstatal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoLicEstatal.FormattingEnabled = true;
			this.cmbTipoLicEstatal.Items.AddRange(new object[] {
									"TODAS",
									"C4",
									"CHOFER",
									"C1",
									"C2",
									"C3",
									"C5"});
			this.cmbTipoLicEstatal.Location = new System.Drawing.Point(156, 289);
			this.cmbTipoLicEstatal.Name = "cmbTipoLicEstatal";
			this.cmbTipoLicEstatal.Size = new System.Drawing.Size(67, 21);
			this.cmbTipoLicEstatal.TabIndex = 33;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label19);
			this.panel2.Location = new System.Drawing.Point(0, 264);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(332, 25);
			this.panel2.TabIndex = 31;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(170, 5);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 15);
			this.label8.TabIndex = 66;
			this.label8.Text = "Tipo";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label19.Location = new System.Drawing.Point(207, 5);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(118, 15);
			this.label19.TabIndex = 68;
			this.label19.Text = "Vigencia (meses)";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtVigenciaEstatal
			// 
			this.txtVigenciaEstatal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtVigenciaEstatal.Location = new System.Drawing.Point(224, 290);
			this.txtVigenciaEstatal.MaxLength = 5;
			this.txtVigenciaEstatal.Name = "txtVigenciaEstatal";
			this.txtVigenciaEstatal.Size = new System.Drawing.Size(101, 20);
			this.txtVigenciaEstatal.TabIndex = 34;
			this.txtVigenciaEstatal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtVigenciaFederal
			// 
			this.txtVigenciaFederal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtVigenciaFederal.Location = new System.Drawing.Point(224, 312);
			this.txtVigenciaFederal.MaxLength = 5;
			this.txtVigenciaFederal.Name = "txtVigenciaFederal";
			this.txtVigenciaFederal.Size = new System.Drawing.Size(100, 20);
			this.txtVigenciaFederal.TabIndex = 37;
			this.txtVigenciaFederal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtVigenciaMedico
			// 
			this.txtVigenciaMedico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtVigenciaMedico.Location = new System.Drawing.Point(224, 332);
			this.txtVigenciaMedico.MaxLength = 5;
			this.txtVigenciaMedico.Name = "txtVigenciaMedico";
			this.txtVigenciaMedico.Size = new System.Drawing.Size(100, 20);
			this.txtVigenciaMedico.TabIndex = 39;
			this.txtVigenciaMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(332, 25);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(203, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 15);
			this.label2.TabIndex = 67;
			this.label2.Text = "Aspectos Iniciales";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(294, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "años";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.LightGray;
			this.label10.Location = new System.Drawing.Point(0, 47);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(155, 20);
			this.label10.TabIndex = 7;
			this.label10.Text = "Imagen Superior a:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.LightGray;
			this.label11.Location = new System.Drawing.Point(0, 110);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(155, 20);
			this.label11.TabIndex = 13;
			this.label11.Text = "Infonavit menor a:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.LightGray;
			this.label12.Location = new System.Drawing.Point(0, 89);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(155, 20);
			this.label12.TabIndex = 11;
			this.label12.Text = "Percing:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.LightGray;
			this.label14.Location = new System.Drawing.Point(0, 68);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(155, 20);
			this.label14.TabIndex = 9;
			this.label14.Text = "Tatuajes:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbPercing
			// 
			this.cmbPercing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPercing.FormattingEnabled = true;
			this.cmbPercing.Items.AddRange(new object[] {
									"SI",
									"NO"});
			this.cmbPercing.Location = new System.Drawing.Point(156, 89);
			this.cmbPercing.Name = "cmbPercing";
			this.cmbPercing.Size = new System.Drawing.Size(106, 21);
			this.cmbPercing.TabIndex = 12;
			// 
			// txtImagen
			// 
			this.txtImagen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtImagen.Location = new System.Drawing.Point(156, 47);
			this.txtImagen.MaxLength = 5;
			this.txtImagen.Name = "txtImagen";
			this.txtImagen.Size = new System.Drawing.Size(106, 20);
			this.txtImagen.TabIndex = 8;
			this.txtImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtInfonavit
			// 
			this.txtInfonavit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtInfonavit.Location = new System.Drawing.Point(156, 111);
			this.txtInfonavit.MaxLength = 10;
			this.txtInfonavit.Name = "txtInfonavit";
			this.txtInfonavit.Size = new System.Drawing.Size(106, 20);
			this.txtInfonavit.TabIndex = 14;
			this.txtInfonavit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.LightGray;
			this.label13.Location = new System.Drawing.Point(0, 131);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(155, 20);
			this.label13.TabIndex = 15;
			this.label13.Text = "Dual:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.LightGray;
			this.label15.Location = new System.Drawing.Point(0, 152);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(155, 20);
			this.label15.TabIndex = 18;
			this.label15.Text = "Direccion Trasera:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.LightGray;
			this.label16.Location = new System.Drawing.Point(0, 173);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(155, 20);
			this.label16.TabIndex = 21;
			this.label16.Text = "Trans de Personal:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(230, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "años";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(231, 157);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(30, 13);
			this.label17.TabIndex = 20;
			this.label17.Text = "años";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(231, 177);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(30, 13);
			this.label20.TabIndex = 23;
			this.label20.Text = "años";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel3.Controls.Add(this.label21);
			this.panel3.Location = new System.Drawing.Point(0, 195);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(332, 25);
			this.panel3.TabIndex = 24;
			// 
			// label21
			// 
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(71, 5);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(256, 15);
			this.label21.TabIndex = 67;
			this.label21.Text = "Descuento para Licencias (Catorcenal)";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(230, 225);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(61, 13);
			this.label23.TabIndex = 27;
			this.label23.Text = "Catorcenas";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.LightGray;
			this.label24.Location = new System.Drawing.Point(0, 221);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(155, 20);
			this.label24.TabIndex = 25;
			this.label24.Text = "Estatal:";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.LightGray;
			this.label25.Location = new System.Drawing.Point(0, 242);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(155, 20);
			this.label25.TabIndex = 28;
			this.label25.Text = "Federal / Medico:";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescFederal
			// 
			this.txtDescFederal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDescFederal.Location = new System.Drawing.Point(156, 242);
			this.txtDescFederal.MaxLength = 3;
			this.txtDescFederal.Name = "txtDescFederal";
			this.txtDescFederal.Size = new System.Drawing.Size(71, 20);
			this.txtDescFederal.TabIndex = 29;
			this.txtDescFederal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDescEstatal
			// 
			this.txtDescEstatal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDescEstatal.Location = new System.Drawing.Point(156, 221);
			this.txtDescEstatal.MaxLength = 3;
			this.txtDescEstatal.Name = "txtDescEstatal";
			this.txtDescEstatal.Size = new System.Drawing.Size(71, 20);
			this.txtDescEstatal.TabIndex = 26;
			this.txtDescEstatal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(230, 247);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(61, 13);
			this.label22.TabIndex = 30;
			this.label22.Text = "Catorcenas";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel4.Controls.Add(this.label26);
			this.panel4.Location = new System.Drawing.Point(0, 354);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(332, 25);
			this.panel4.TabIndex = 40;
			// 
			// label26
			// 
			this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(170, 5);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(154, 15);
			this.label26.TabIndex = 67;
			this.label26.Text = "Impresión Autorización";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.LightGray;
			this.label27.Location = new System.Drawing.Point(0, 381);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(155, 20);
			this.label27.TabIndex = 41;
			this.label27.Text = "Contacto Taller:";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContactoTaller
			// 
			this.txtContactoTaller.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtContactoTaller.Location = new System.Drawing.Point(156, 381);
			this.txtContactoTaller.MaxLength = 100;
			this.txtContactoTaller.Name = "txtContactoTaller";
			this.txtContactoTaller.Size = new System.Drawing.Size(168, 20);
			this.txtContactoTaller.TabIndex = 42;
			this.txtContactoTaller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.LightGray;
			this.label28.Location = new System.Drawing.Point(0, 402);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(155, 20);
			this.label28.TabIndex = 43;
			this.label28.Text = "Número:";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNumeroTaller
			// 
			this.txtNumeroTaller.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumeroTaller.Location = new System.Drawing.Point(156, 402);
			this.txtNumeroTaller.MaxLength = 50;
			this.txtNumeroTaller.Name = "txtNumeroTaller";
			this.txtNumeroTaller.Size = new System.Drawing.Size(168, 20);
			this.txtNumeroTaller.TabIndex = 44;
			this.txtNumeroTaller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.LightGray;
			this.label29.Location = new System.Drawing.Point(0, 444);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(155, 20);
			this.label29.TabIndex = 47;
			this.label29.Text = "Número";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNumeroOficina
			// 
			this.txtNumeroOficina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumeroOficina.Location = new System.Drawing.Point(156, 444);
			this.txtNumeroOficina.MaxLength = 50;
			this.txtNumeroOficina.Name = "txtNumeroOficina";
			this.txtNumeroOficina.Size = new System.Drawing.Size(168, 20);
			this.txtNumeroOficina.TabIndex = 48;
			this.txtNumeroOficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.LightGray;
			this.label30.Location = new System.Drawing.Point(0, 423);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(155, 20);
			this.label30.TabIndex = 45;
			this.label30.Text = "Contacto Oficina:";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtContactoOficina
			// 
			this.txtContactoOficina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtContactoOficina.Location = new System.Drawing.Point(156, 423);
			this.txtContactoOficina.MaxLength = 100;
			this.txtContactoOficina.Name = "txtContactoOficina";
			this.txtContactoOficina.Size = new System.Drawing.Size(168, 20);
			this.txtContactoOficina.TabIndex = 46;
			this.txtContactoOficina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.LightGray;
			this.label6.Location = new System.Drawing.Point(0, 290);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 20);
			this.label6.TabIndex = 32;
			this.label6.Text = "Estatal:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.LightGray;
			this.label7.Location = new System.Drawing.Point(0, 311);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(155, 20);
			this.label7.TabIndex = 35;
			this.label7.Text = "Federal / Medico:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.LightGray;
			this.label31.Location = new System.Drawing.Point(0, 332);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(223, 20);
			this.label31.TabIndex = 38;
			this.label31.Text = "Apto Medico:";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel5.Location = new System.Drawing.Point(0, 466);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(332, 13);
			this.panel5.TabIndex = 50;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.LightGray;
			this.label18.Location = new System.Drawing.Point(0, 481);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(70, 20);
			this.label18.TabIndex = 51;
			this.label18.Text = "Zonas:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtZona
			// 
			this.txtZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtZona.Location = new System.Drawing.Point(71, 481);
			this.txtZona.MaxLength = 100;
			this.txtZona.Name = "txtZona";
			this.txtZona.ReadOnly = true;
			this.txtZona.Size = new System.Drawing.Size(90, 20);
			this.txtZona.TabIndex = 52;
			this.txtZona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtZona.Click += new System.EventHandler(this.TxtZonaClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LightGray;
			this.label4.Location = new System.Drawing.Point(162, 481);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 20);
			this.label4.TabIndex = 53;
			this.label4.Text = "Fuentes:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFuente
			// 
			this.txtFuente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFuente.Location = new System.Drawing.Point(233, 481);
			this.txtFuente.MaxLength = 100;
			this.txtFuente.Name = "txtFuente";
			this.txtFuente.ReadOnly = true;
			this.txtFuente.Size = new System.Drawing.Size(90, 20);
			this.txtFuente.TabIndex = 54;
			this.txtFuente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFuente.Click += new System.EventHandler(this.TxtFuenteClick);
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(4, 506);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(85, 29);
			this.btnExcel.TabIndex = 55;
			this.btnExcel.Text = "Reporte";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// FormParametros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(329, 537);
			this.Controls.Add(this.btnExcel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFuente);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.txtZona);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.txtNumeroOficina);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.txtContactoOficina);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.txtNumeroTaller);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.txtContactoTaller);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.txtDescFederal);
			this.Controls.Add(this.txtDescEstatal);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.txtInfonavit);
			this.Controls.Add(this.txtImagen);
			this.Controls.Add(this.cmbPercing);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtVigenciaMedico);
			this.Controls.Add(this.txtVigenciaFederal);
			this.Controls.Add(this.txtVigenciaEstatal);
			this.Controls.Add(this.txtTransPersonal);
			this.Controls.Add(this.txtDirTrasera);
			this.Controls.Add(this.txtDual);
			this.Controls.Add(this.cmbTipoLicFederal);
			this.Controls.Add(this.cmbTipoLicEstatal);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.cmbTatuajes);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nudEdadMax);
			this.Controls.Add(this.nudEdadMin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdGuardar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(345, 535);
			this.Name = "FormParametros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parámetros de Configuración";
			this.Load += new System.EventHandler(this.FormParametrosLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormParametrosKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.nudEdadMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudEdadMax)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.TextBox txtZona;
		private System.Windows.Forms.Label label18;
		public System.Windows.Forms.TextBox txtFuente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.ComboBox cmbPercing;
		public System.Windows.Forms.TextBox txtImagen;
		public System.Windows.Forms.TextBox txtInfonavit;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.TextBox txtDescEstatal;
		public System.Windows.Forms.TextBox txtDescFederal;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.TextBox txtContactoTaller;
		private System.Windows.Forms.Label label27;
		public System.Windows.Forms.TextBox txtNumeroTaller;
		private System.Windows.Forms.Label label28;
		public System.Windows.Forms.TextBox txtContactoOficina;
		private System.Windows.Forms.Label label30;
		public System.Windows.Forms.TextBox txtNumeroOficina;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox cmbTipoLicEstatal;
		public System.Windows.Forms.ComboBox cmbTipoLicFederal;
		public System.Windows.Forms.TextBox txtVigenciaEstatal;
		public System.Windows.Forms.TextBox txtVigenciaFederal;
		public System.Windows.Forms.TextBox txtVigenciaMedico;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		public System.Windows.Forms.TextBox txtDual;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.TextBox txtDirTrasera;
		public System.Windows.Forms.TextBox txtTransPersonal;
		private System.Windows.Forms.Label label13;
		public System.Windows.Forms.ComboBox cmbTatuajes;
		public System.Windows.Forms.NumericUpDown nudEdadMax;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.NumericUpDown nudEdadMin;
	}
}
