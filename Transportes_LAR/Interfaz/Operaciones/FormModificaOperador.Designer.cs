/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 24/11/2016
 * Time: 10:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormModificaOperador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificaOperador));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtApellidoMat = new System.Windows.Forms.TextBox();
			this.txtApellidoPat = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblA_ApMatOperador = new System.Windows.Forms.Label();
			this.lblA_ApPatOperador = new System.Windows.Forms.Label();
			this.lblA_NombreOperador = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.cbForaneo = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
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
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.dataTelefono = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnRemoverTelefono = new System.Windows.Forms.Button();
			this.btnAgregarTelefono = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.lblLimpiar = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTelefono)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.ptbImagen);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(312, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(133, 152);
			this.groupBox1.TabIndex = 323;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operador";
			// 
			// ptbImagen
			// 
			this.ptbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ptbImagen.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ptbImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptbImagen.Image")));
			this.ptbImagen.Location = new System.Drawing.Point(6, 19);
			this.ptbImagen.Name = "ptbImagen";
			this.ptbImagen.Size = new System.Drawing.Size(121, 127);
			this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagen.TabIndex = 165;
			this.ptbImagen.TabStop = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(238, 472);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(95, 45);
			this.btnCancelar.TabIndex = 300;
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
			this.btnAgregar.Location = new System.Drawing.Point(103, 472);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(95, 45);
			this.btnAgregar.TabIndex = 299;
			this.btnAgregar.Text = "Modificar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtCorreo
			// 
			this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCorreo.Enabled = false;
			this.txtCorreo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreo.Location = new System.Drawing.Point(97, 111);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(197, 20);
			this.txtCorreo.TabIndex = 284;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(45, 113);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(43, 14);
			this.label27.TabIndex = 314;
			this.label27.Text = "Correo:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 20);
			this.label1.TabIndex = 309;
			this.label1.Text = "Datos Personales";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtApellidoMat
			// 
			this.txtApellidoMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoMat.Enabled = false;
			this.txtApellidoMat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoMat.Location = new System.Drawing.Point(97, 85);
			this.txtApellidoMat.Name = "txtApellidoMat";
			this.txtApellidoMat.Size = new System.Drawing.Size(197, 20);
			this.txtApellidoMat.TabIndex = 279;
			// 
			// txtApellidoPat
			// 
			this.txtApellidoPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoPat.Enabled = false;
			this.txtApellidoPat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoPat.Location = new System.Drawing.Point(97, 59);
			this.txtApellidoPat.Name = "txtApellidoPat";
			this.txtApellidoPat.Size = new System.Drawing.Size(197, 20);
			this.txtApellidoPat.TabIndex = 278;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(97, 33);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(197, 20);
			this.txtNombre.TabIndex = 277;
			// 
			// lblA_ApMatOperador
			// 
			this.lblA_ApMatOperador.AutoSize = true;
			this.lblA_ApMatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApMatOperador.Location = new System.Drawing.Point(2, 88);
			this.lblA_ApMatOperador.Name = "lblA_ApMatOperador";
			this.lblA_ApMatOperador.Size = new System.Drawing.Size(90, 14);
			this.lblA_ApMatOperador.TabIndex = 303;
			this.lblA_ApMatOperador.Text = "Apellido Materno:";
			this.lblA_ApMatOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblA_ApPatOperador
			// 
			this.lblA_ApPatOperador.AutoSize = true;
			this.lblA_ApPatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApPatOperador.Location = new System.Drawing.Point(4, 62);
			this.lblA_ApPatOperador.Name = "lblA_ApPatOperador";
			this.lblA_ApPatOperador.Size = new System.Drawing.Size(88, 14);
			this.lblA_ApPatOperador.TabIndex = 302;
			this.lblA_ApPatOperador.Text = "Apellido Paterno:";
			// 
			// lblA_NombreOperador
			// 
			this.lblA_NombreOperador.AutoSize = true;
			this.lblA_NombreOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_NombreOperador.Location = new System.Drawing.Point(33, 36);
			this.lblA_NombreOperador.Name = "lblA_NombreOperador";
			this.lblA_NombreOperador.Size = new System.Drawing.Size(61, 14);
			this.lblA_NombreOperador.TabIndex = 301;
			this.lblA_NombreOperador.Text = "Nombre(s):";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(37, 137);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(51, 15);
			this.label16.TabIndex = 329;
			this.label16.Text = "Tipo:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbForaneo
			// 
			this.cbForaneo.Enabled = false;
			this.cbForaneo.Location = new System.Drawing.Point(97, 133);
			this.cbForaneo.Name = "cbForaneo";
			this.cbForaneo.Size = new System.Drawing.Size(104, 24);
			this.cbForaneo.TabIndex = 328;
			this.cbForaneo.Text = "Foraneo";
			this.cbForaneo.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(4, 162);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(441, 20);
			this.label2.TabIndex = 330;
			this.label2.Text = "Domicilio";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCP
			// 
			this.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCP.Location = new System.Drawing.Point(351, 261);
			this.txtCP.Name = "txtCP";
			this.txtCP.Size = new System.Drawing.Size(90, 20);
			this.txtCP.TabIndex = 339;
			// 
			// txtNumExterior
			// 
			this.txtNumExterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumExterior.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumExterior.Location = new System.Drawing.Point(97, 261);
			this.txtNumExterior.Name = "txtNumExterior";
			this.txtNumExterior.Size = new System.Drawing.Size(70, 20);
			this.txtNumExterior.TabIndex = 337;
			// 
			// txtNumInterior
			// 
			this.txtNumInterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumInterior.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumInterior.Location = new System.Drawing.Point(216, 261);
			this.txtNumInterior.Name = "txtNumInterior";
			this.txtNumInterior.Size = new System.Drawing.Size(90, 20);
			this.txtNumInterior.TabIndex = 338;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(320, 263);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 14);
			this.label11.TabIndex = 348;
			this.label11.Text = "CP:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(24, 262);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 14);
			this.label10.TabIndex = 347;
			this.label10.Text = "Numero Ext:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(171, 264);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 14);
			this.label13.TabIndex = 346;
			this.label13.Text = "Num Int:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(247, 238);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 14);
			this.label15.TabIndex = 345;
			this.label15.Text = "Cruza 2:";
			// 
			// txtReferencia2
			// 
			this.txtReferencia2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferencia2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferencia2.Location = new System.Drawing.Point(296, 235);
			this.txtReferencia2.Name = "txtReferencia2";
			this.txtReferencia2.Size = new System.Drawing.Size(145, 20);
			this.txtReferencia2.TabIndex = 336;
			// 
			// txtReferencia1
			// 
			this.txtReferencia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReferencia1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferencia1.Location = new System.Drawing.Point(97, 235);
			this.txtReferencia1.Name = "txtReferencia1";
			this.txtReferencia1.Size = new System.Drawing.Size(146, 20);
			this.txtReferencia1.TabIndex = 335;
			// 
			// txtEstado
			// 
			this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEstado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstado.Location = new System.Drawing.Point(296, 210);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(145, 20);
			this.txtEstado.TabIndex = 334;
			// 
			// txtColonia
			// 
			this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtColonia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(296, 185);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(145, 20);
			this.txtColonia.TabIndex = 332;
			// 
			// txtMunicipio
			// 
			this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMunicipio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMunicipio.Location = new System.Drawing.Point(97, 209);
			this.txtMunicipio.Name = "txtMunicipio";
			this.txtMunicipio.Size = new System.Drawing.Size(145, 20);
			this.txtMunicipio.TabIndex = 333;
			// 
			// txtCalle
			// 
			this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCalle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalle.Location = new System.Drawing.Point(97, 185);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(145, 20);
			this.txtCalle.TabIndex = 331;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 237);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 14);
			this.label3.TabIndex = 344;
			this.label3.Text = "Cruza 1:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(252, 213);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 14);
			this.label8.TabIndex = 343;
			this.label8.Text = "Estado:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(36, 211);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 14);
			this.label7.TabIndex = 342;
			this.label7.Text = "Municipio:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(251, 188);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 14);
			this.label9.TabIndex = 341;
			this.label9.Text = "Colonia:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(57, 188);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 14);
			this.label14.TabIndex = 340;
			this.label14.Text = "Calle:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 287);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(441, 20);
			this.label4.TabIndex = 349;
			this.label4.Text = "Teléfono";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(138, 315);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(93, 20);
			this.txtNumero.TabIndex = 352;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(233, 318);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 14);
			this.label5.TabIndex = 355;
			this.label5.Text = "Descripción:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(95, 317);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 14);
			this.label6.TabIndex = 354;
			this.label6.Text = "Numero:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(297, 315);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(111, 20);
			this.txtDescripcion.TabIndex = 353;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(5, 316);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(30, 14);
			this.label12.TabIndex = 350;
			this.label12.Text = "Tipo:";
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"Celular",
									"Nextel",
									"Fijo",
									"LAR"});
			this.cmbTipo.Location = new System.Drawing.Point(34, 313);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(60, 22);
			this.cmbTipo.TabIndex = 351;
			// 
			// dataTelefono
			// 
			this.dataTelefono.AllowUserToAddRows = false;
			this.dataTelefono.AllowUserToDeleteRows = false;
			this.dataTelefono.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataTelefono.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataTelefono.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataTelefono.Location = new System.Drawing.Point(5, 341);
			this.dataTelefono.MultiSelect = false;
			this.dataTelefono.Name = "dataTelefono";
			this.dataTelefono.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataTelefono.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataTelefono.RowHeadersVisible = false;
			this.dataTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataTelefono.Size = new System.Drawing.Size(343, 114);
			this.dataTelefono.TabIndex = 356;
			this.dataTelefono.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTelefonoCellClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "id";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "tipo";
			this.Column2.HeaderText = "Tipo";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 40;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "numero";
			this.Column3.HeaderText = "Numero";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "descripcion";
			this.Column4.HeaderText = "Descripcion";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 150;
			// 
			// btnRemoverTelefono
			// 
			this.btnRemoverTelefono.BackColor = System.Drawing.Color.Transparent;
			this.btnRemoverTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemoverTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoverTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverTelefono.Image")));
			this.btnRemoverTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemoverTelefono.Location = new System.Drawing.Point(352, 406);
			this.btnRemoverTelefono.Name = "btnRemoverTelefono";
			this.btnRemoverTelefono.Size = new System.Drawing.Size(94, 28);
			this.btnRemoverTelefono.TabIndex = 358;
			this.btnRemoverTelefono.Text = "Remover";
			this.btnRemoverTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverTelefono.UseVisualStyleBackColor = false;
			this.btnRemoverTelefono.Click += new System.EventHandler(this.BtnRemoverTelefonoClick);
			// 
			// btnAgregarTelefono
			// 
			this.btnAgregarTelefono.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregarTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTelefono.Image")));
			this.btnAgregarTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarTelefono.Location = new System.Drawing.Point(354, 365);
			this.btnAgregarTelefono.Name = "btnAgregarTelefono";
			this.btnAgregarTelefono.Size = new System.Drawing.Size(91, 28);
			this.btnAgregarTelefono.TabIndex = 357;
			this.btnAgregarTelefono.Text = "Agregar";
			this.btnAgregarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregarTelefono.UseVisualStyleBackColor = false;
			this.btnAgregarTelefono.Click += new System.EventHandler(this.BtnAgregarTelefonoClick);
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(2, 461);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(441, 5);
			this.label17.TabIndex = 359;
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLimpiar
			// 
			this.lblLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("lblLimpiar.Image")));
			this.lblLimpiar.Location = new System.Drawing.Point(415, 308);
			this.lblLimpiar.Name = "lblLimpiar";
			this.lblLimpiar.Size = new System.Drawing.Size(30, 31);
			this.lblLimpiar.TabIndex = 360;
			this.lblLimpiar.Click += new System.EventHandler(this.LblLimpiarClick);
			// 
			// FormModificaOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 519);
			this.Controls.Add(this.lblLimpiar);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.btnRemoverTelefono);
			this.Controls.Add(this.btnAgregarTelefono);
			this.Controls.Add(this.dataTelefono);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCP);
			this.Controls.Add(this.txtNumExterior);
			this.Controls.Add(this.txtNumInterior);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtReferencia2);
			this.Controls.Add(this.txtReferencia1);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtColonia);
			this.Controls.Add(this.txtMunicipio);
			this.Controls.Add(this.txtCalle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.cbForaneo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtApellidoMat);
			this.Controls.Add(this.txtApellidoPat);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblA_ApMatOperador);
			this.Controls.Add(this.lblA_ApPatOperador);
			this.Controls.Add(this.lblA_NombreOperador);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormModificaOperador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modifica Operador";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModificaOperadorFormClosing);
			this.Load += new System.EventHandler(this.FormModificaOperadorLoad);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTelefono)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblLimpiar;
		private System.Windows.Forms.Label label17;
		public System.Windows.Forms.Button btnAgregarTelefono;
		public System.Windows.Forms.Button btnRemoverTelefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataTelefono;
		public System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtCalle;
		public System.Windows.Forms.TextBox txtMunicipio;
		public System.Windows.Forms.TextBox txtColonia;
		public System.Windows.Forms.TextBox txtEstado;
		public System.Windows.Forms.TextBox txtReferencia1;
		public System.Windows.Forms.TextBox txtReferencia2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox txtNumInterior;
		public System.Windows.Forms.TextBox txtNumExterior;
		public System.Windows.Forms.TextBox txtCP;
		private System.Windows.Forms.CheckBox cbForaneo;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblA_NombreOperador;
		private System.Windows.Forms.Label lblA_ApPatOperador;
		private System.Windows.Forms.Label lblA_ApMatOperador;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtApellidoPat;
		public System.Windows.Forms.TextBox txtApellidoMat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label27;
		public System.Windows.Forms.TextBox txtCorreo;
		public System.Windows.Forms.Button btnAgregar;
		public System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
