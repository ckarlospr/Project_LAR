/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 10/11/2015
 * Time: 9:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormContribuyentes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContribuyentes));
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblLimpiar = new System.Windows.Forms.Label();
			this.cbTipo = new System.Windows.Forms.ComboBox();
			this.txtBanco = new System.Windows.Forms.TextBox();
			this.label102 = new System.Windows.Forms.Label();
			this.txtClabe = new System.Windows.Forms.TextBox();
			this.label101 = new System.Windows.Forms.Label();
			this.txtCuenta = new System.Windows.Forms.TextBox();
			this.label100 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnAsignar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnMas = new System.Windows.Forms.Button();
			this.txtCiudad = new System.Windows.Forms.TextBox();
			this.label78 = new System.Windows.Forms.Label();
			this.txtColinia = new System.Windows.Forms.TextBox();
			this.label82 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label84 = new System.Windows.Forms.Label();
			this.txtRFC = new System.Windows.Forms.TextBox();
			this.txtCP = new System.Windows.Forms.TextBox();
			this.label94 = new System.Windows.Forms.Label();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label95 = new System.Windows.Forms.Label();
			this.label96 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label97 = new System.Windows.Forms.Label();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.label98 = new System.Windows.Forms.Label();
			this.label99 = new System.Windows.Forms.Label();
			this.label93 = new System.Windows.Forms.Label();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_MAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToDeleteRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.ID_MAS,
									this.CLIENTE,
									this.dataGridViewTextBoxColumn16,
									this.dataGridViewTextBoxColumn18,
									this.dataGridViewTextBoxColumn27,
									this.TELEFONO});
			this.dgDatos.Location = new System.Drawing.Point(6, 209);
			this.dgDatos.MultiSelect = false;
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.ReadOnly = true;
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDatos.Size = new System.Drawing.Size(934, 346);
			this.dgDatos.TabIndex = 18;
			this.dgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgDatosCellClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.txtCliente);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblLimpiar);
			this.panel1.Controls.Add(this.cbTipo);
			this.panel1.Controls.Add(this.txtBanco);
			this.panel1.Controls.Add(this.label102);
			this.panel1.Controls.Add(this.txtClabe);
			this.panel1.Controls.Add(this.label101);
			this.panel1.Controls.Add(this.txtCuenta);
			this.panel1.Controls.Add(this.label100);
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.btnAsignar);
			this.panel1.Controls.Add(this.btnGuardar);
			this.panel1.Controls.Add(this.btnMas);
			this.panel1.Controls.Add(this.txtCiudad);
			this.panel1.Controls.Add(this.label78);
			this.panel1.Controls.Add(this.txtColinia);
			this.panel1.Controls.Add(this.label82);
			this.panel1.Controls.Add(this.txtTelefono);
			this.panel1.Controls.Add(this.label84);
			this.panel1.Controls.Add(this.txtRFC);
			this.panel1.Controls.Add(this.txtCP);
			this.panel1.Controls.Add(this.label94);
			this.panel1.Controls.Add(this.cbEstado);
			this.panel1.Controls.Add(this.txtCorreo);
			this.panel1.Controls.Add(this.label95);
			this.panel1.Controls.Add(this.label96);
			this.panel1.Controls.Add(this.txtDomicilio);
			this.panel1.Controls.Add(this.label97);
			this.panel1.Controls.Add(this.txtRazonSocial);
			this.panel1.Controls.Add(this.label98);
			this.panel1.Controls.Add(this.label99);
			this.panel1.Controls.Add(this.label93);
			this.panel1.Location = new System.Drawing.Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(944, 201);
			this.panel1.TabIndex = 176;
			// 
			// txtCliente
			// 
			this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCliente.Location = new System.Drawing.Point(89, 1);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(248, 20);
			this.txtCliente.TabIndex = 176;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(7, 4);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(79, 17);
			this.label1.TabIndex = 208;
			this.label1.Text = " :Cliente";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLimpiar
			// 
			this.lblLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("lblLimpiar.Image")));
			this.lblLimpiar.Location = new System.Drawing.Point(467, 170);
			this.lblLimpiar.Name = "lblLimpiar";
			this.lblLimpiar.Size = new System.Drawing.Size(42, 31);
			this.lblLimpiar.TabIndex = 191;
			this.lblLimpiar.Tag = "Limpiar";
			// 
			// cbTipo
			// 
			this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTipo.FormattingEnabled = true;
			this.cbTipo.Items.AddRange(new object[] {
									"FISICA",
									"MORAL"});
			this.cbTipo.Location = new System.Drawing.Point(409, 53);
			this.cbTipo.Margin = new System.Windows.Forms.Padding(2);
			this.cbTipo.Name = "cbTipo";
			this.cbTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbTipo.Size = new System.Drawing.Size(87, 21);
			this.cbTipo.TabIndex = 181;
			// 
			// txtBanco
			// 
			this.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBanco.Location = new System.Drawing.Point(90, 53);
			this.txtBanco.Name = "txtBanco";
			this.txtBanco.Size = new System.Drawing.Size(121, 20);
			this.txtBanco.TabIndex = 179;
			// 
			// label102
			// 
			this.label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label102.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label102.Location = new System.Drawing.Point(37, 56);
			this.label102.Name = "label102";
			this.label102.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label102.Size = new System.Drawing.Size(52, 17);
			this.label102.TabIndex = 207;
			this.label102.Text = ": Banco";
			this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtClabe
			// 
			this.txtClabe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtClabe.Location = new System.Drawing.Point(262, 78);
			this.txtClabe.Name = "txtClabe";
			this.txtClabe.Size = new System.Drawing.Size(136, 20);
			this.txtClabe.TabIndex = 183;
			// 
			// label101
			// 
			this.label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label101.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label101.Location = new System.Drawing.Point(214, 81);
			this.label101.Name = "label101";
			this.label101.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label101.Size = new System.Drawing.Size(50, 17);
			this.label101.TabIndex = 206;
			this.label101.Text = ": Clabe";
			this.label101.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCuenta
			// 
			this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCuenta.Location = new System.Drawing.Point(90, 78);
			this.txtCuenta.Name = "txtCuenta";
			this.txtCuenta.Size = new System.Drawing.Size(121, 20);
			this.txtCuenta.TabIndex = 182;
			// 
			// label100
			// 
			this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label100.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label100.Location = new System.Drawing.Point(37, 81);
			this.label100.Name = "label100";
			this.label100.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label100.Size = new System.Drawing.Size(52, 17);
			this.label100.TabIndex = 205;
			this.label100.Text = ": Cuenta";
			this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(242, 170);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSalir.Size = new System.Drawing.Size(96, 28);
			this.btnSalir.TabIndex = 192;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// btnAsignar
			// 
			this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsignar.Location = new System.Drawing.Point(404, 78);
			this.btnAsignar.Name = "btnAsignar";
			this.btnAsignar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnAsignar.Size = new System.Drawing.Size(96, 19);
			this.btnAsignar.TabIndex = 204;
			this.btnAsignar.Text = "Asignar";
			this.btnAsignar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Location = new System.Drawing.Point(344, 170);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnGuardar.Size = new System.Drawing.Size(96, 28);
			this.btnGuardar.TabIndex = 190;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnMas
			// 
			this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMas.Location = new System.Drawing.Point(388, 112);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(31, 23);
			this.btnMas.TabIndex = 203;
			this.btnMas.Text = "+";
			this.btnMas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMas.UseVisualStyleBackColor = true;
			// 
			// txtCiudad
			// 
			this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCiudad.Location = new System.Drawing.Point(262, 138);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(100, 20);
			this.txtCiudad.TabIndex = 187;
			// 
			// label78
			// 
			this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label78.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label78.Location = new System.Drawing.Point(217, 140);
			this.label78.Name = "label78";
			this.label78.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label78.Size = new System.Drawing.Size(47, 17);
			this.label78.TabIndex = 202;
			this.label78.Text = ": Ciudad";
			this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtColinia
			// 
			this.txtColinia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColinia.Location = new System.Drawing.Point(90, 137);
			this.txtColinia.Name = "txtColinia";
			this.txtColinia.Size = new System.Drawing.Size(121, 20);
			this.txtColinia.TabIndex = 186;
			// 
			// label82
			// 
			this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label82.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label82.Location = new System.Drawing.Point(10, 141);
			this.label82.Name = "label82";
			this.label82.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label82.Size = new System.Drawing.Size(79, 17);
			this.label82.TabIndex = 201;
			this.label82.Text = ": Colonia";
			this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTelefono
			// 
			this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelefono.Location = new System.Drawing.Point(90, 161);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(121, 20);
			this.txtTelefono.TabIndex = 189;
			// 
			// label84
			// 
			this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label84.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label84.Location = new System.Drawing.Point(5, 164);
			this.label84.Name = "label84";
			this.label84.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label84.Size = new System.Drawing.Size(79, 17);
			this.label84.TabIndex = 200;
			this.label84.Text = ": Telefono";
			this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRFC
			// 
			this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRFC.Location = new System.Drawing.Point(379, 26);
			this.txtRFC.Name = "txtRFC";
			this.txtRFC.Size = new System.Drawing.Size(121, 20);
			this.txtRFC.TabIndex = 178;
			// 
			// txtCP
			// 
			this.txtCP.Location = new System.Drawing.Point(446, 111);
			this.txtCP.Name = "txtCP";
			this.txtCP.Size = new System.Drawing.Size(56, 20);
			this.txtCP.TabIndex = 185;
			this.txtCP.Text = "44260";
			// 
			// label94
			// 
			this.label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label94.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label94.Location = new System.Drawing.Point(409, 114);
			this.label94.Name = "label94";
			this.label94.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label94.Size = new System.Drawing.Size(36, 17);
			this.label94.TabIndex = 199;
			this.label94.Text = ": Cp";
			this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbEstado
			// 
			this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Items.AddRange(new object[] {
									"AGUASCALIENTES",
									"BAJA CALIFORNIA",
									"BAJA CALIFORNIA SUR",
									"CAMPECHE",
									"CHIAPAS",
									"CHIHUAHUA",
									"COAHUILA",
									"COLIMA",
									"DISTRITO FEDERAL",
									"DURANGO",
									"ESTADO DE MÉXICO",
									"GUANAJUATO",
									"GUERRERO",
									"HIDALGO",
									"JALISCO",
									"MICHOACÁN",
									"MORELOS",
									"NAYARIT",
									"NUEVO LEÓN",
									"OAXACA",
									"PUEBLA",
									"QUERÉTARO",
									"QUINTANA ROO",
									"SAN LUIS POTOSÍ",
									"SINALOA",
									"SONORA",
									"TABASCO",
									"TAMAULIPAS",
									"TLAXCALA",
									"VERACRUZ",
									"YUCATÁN",
									"ZACATECAS"});
			this.cbEstado.Location = new System.Drawing.Point(415, 136);
			this.cbEstado.Margin = new System.Windows.Forms.Padding(2);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbEstado.Size = new System.Drawing.Size(87, 21);
			this.cbEstado.TabIndex = 188;
			this.cbEstado.Text = "JALISCO";
			// 
			// txtCorreo
			// 
			this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCorreo.Location = new System.Drawing.Point(262, 52);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(136, 20);
			this.txtCorreo.TabIndex = 180;
			// 
			// label95
			// 
			this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label95.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label95.Location = new System.Drawing.Point(210, 53);
			this.label95.Name = "label95";
			this.label95.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label95.Size = new System.Drawing.Size(52, 17);
			this.label95.TabIndex = 198;
			this.label95.Text = ": e-mail";
			this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label96
			// 
			this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label96.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label96.Location = new System.Drawing.Point(357, 138);
			this.label96.Name = "label96";
			this.label96.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label96.Size = new System.Drawing.Size(58, 17);
			this.label96.TabIndex = 196;
			this.label96.Text = ": Estado";
			this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDomicilio.Location = new System.Drawing.Point(89, 113);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(287, 20);
			this.txtDomicilio.TabIndex = 184;
			// 
			// label97
			// 
			this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label97.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label97.Location = new System.Drawing.Point(8, 118);
			this.label97.Name = "label97";
			this.label97.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label97.Size = new System.Drawing.Size(79, 17);
			this.label97.TabIndex = 195;
			this.label97.Text = ": Domicilio";
			this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRazonSocial.Location = new System.Drawing.Point(90, 27);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(248, 20);
			this.txtRazonSocial.TabIndex = 177;
			// 
			// label98
			// 
			this.label98.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label98.Location = new System.Drawing.Point(10, 105);
			this.label98.Name = "label98";
			this.label98.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label98.Size = new System.Drawing.Size(492, 3);
			this.label98.TabIndex = 193;
			this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label99
			// 
			this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label99.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label99.Location = new System.Drawing.Point(8, 30);
			this.label99.Name = "label99";
			this.label99.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label99.Size = new System.Drawing.Size(79, 17);
			this.label99.TabIndex = 194;
			this.label99.Text = ": Razon Social";
			this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label93
			// 
			this.label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label93.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label93.Location = new System.Drawing.Point(298, 28);
			this.label93.Name = "label93";
			this.label93.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label93.Size = new System.Drawing.Size(79, 17);
			this.label93.TabIndex = 197;
			this.label93.Text = ": RFC";
			this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 60;
			// 
			// ID_MAS
			// 
			this.ID_MAS.HeaderText = "ID_MAS";
			this.ID_MAS.Name = "ID_MAS";
			this.ID_MAS.ReadOnly = true;
			this.ID_MAS.Visible = false;
			this.ID_MAS.Width = 60;
			// 
			// CLIENTE
			// 
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			this.CLIENTE.Width = 170;
			// 
			// dataGridViewTextBoxColumn16
			// 
			this.dataGridViewTextBoxColumn16.HeaderText = "RAZON SOCIAL";
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn16.ReadOnly = true;
			this.dataGridViewTextBoxColumn16.Width = 380;
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.HeaderText = "DOMICILIO";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.ReadOnly = true;
			this.dataGridViewTextBoxColumn18.Width = 150;
			// 
			// dataGridViewTextBoxColumn27
			// 
			this.dataGridViewTextBoxColumn27.HeaderText = "E MAIL";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn27.ReadOnly = true;
			this.dataGridViewTextBoxColumn27.Width = 130;
			// 
			// TELEFONO
			// 
			this.TELEFONO.HeaderText = "TELEFONO";
			this.TELEFONO.Name = "TELEFONO";
			this.TELEFONO.ReadOnly = true;
			// 
			// FormContribuyentes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(951, 561);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgDatos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormContribuyentes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormContribuyentes";
			this.Load += new System.EventHandler(this.FormContribuyentesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label lblLimpiar;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.Label label93;
		private System.Windows.Forms.Label label99;
		private System.Windows.Forms.Label label98;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.Label label97;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label96;
		private System.Windows.Forms.Label label95;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.ComboBox cbEstado;
		private System.Windows.Forms.Label label94;
		private System.Windows.Forms.TextBox txtCP;
		private System.Windows.Forms.TextBox txtRFC;
		private System.Windows.Forms.Label label84;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label82;
		private System.Windows.Forms.TextBox txtColinia;
		private System.Windows.Forms.Label label78;
		private System.Windows.Forms.TextBox txtCiudad;
		private System.Windows.Forms.Button btnMas;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnAsignar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label100;
		private System.Windows.Forms.TextBox txtCuenta;
		private System.Windows.Forms.Label label101;
		private System.Windows.Forms.TextBox txtClabe;
		private System.Windows.Forms.Label label102;
		private System.Windows.Forms.TextBox txtBanco;
	}
}
