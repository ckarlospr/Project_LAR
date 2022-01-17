/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 15/07/2012
 * Time: 18:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	partial class FormContacto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContacto));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.txtCP = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtColonia = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMunicipio = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNumExterior = new System.Windows.Forms.TextBox();
			this.txtNumInterior = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
			this.txtApellidoMat = new System.Windows.Forms.TextBox();
			this.txtApellidoPat = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblA_ApMatOperador = new System.Windows.Forms.Label();
			this.lblA_ApPatOperador = new System.Windows.Forms.Label();
			this.lblA_NombreOperador = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 51);
			this.panel1.TabIndex = 26;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(7, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modifique los datos del contacto:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCancelar);
			this.panel2.Controls.Add(this.btnAgregar);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.txtCP);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.txtEstado);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtColonia);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtMunicipio);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.txtNumExterior);
			this.panel2.Controls.Add(this.txtNumInterior);
			this.panel2.Controls.Add(this.txtCalle);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.txtTelefono);
			this.panel2.Controls.Add(this.txtApellidoMat);
			this.panel2.Controls.Add(this.txtApellidoPat);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.lblA_ApMatOperador);
			this.panel2.Controls.Add(this.lblA_ApPatOperador);
			this.panel2.Controls.Add(this.lblA_NombreOperador);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Location = new System.Drawing.Point(0, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(301, 408);
			this.panel2.TabIndex = 0;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(206, 373);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(82, 27);
			this.btnCancelar.TabIndex = 13;
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
			this.btnAgregar.Location = new System.Drawing.Point(121, 373);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(79, 27);
			this.btnAgregar.TabIndex = 12;
			this.btnAgregar.Text = "Aceptar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(68, 344);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 14);
			this.label11.TabIndex = 72;
			this.label11.Text = "CP:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCP
			// 
			this.txtCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCP.Location = new System.Drawing.Point(98, 341);
			this.txtCP.Name = "txtCP";
			this.txtCP.Size = new System.Drawing.Size(100, 20);
			this.txtCP.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(50, 318);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 14);
			this.label8.TabIndex = 71;
			this.label8.Text = "Estado:";
			// 
			// txtEstado
			// 
			this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEstado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstado.Location = new System.Drawing.Point(98, 315);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(100, 20);
			this.txtEstado.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(39, 292);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 14);
			this.label7.TabIndex = 70;
			this.label7.Text = "Municipio:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 14);
			this.label5.TabIndex = 68;
			this.label5.Text = "Numero Exterior:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtColonia
			// 
			this.txtColonia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtColonia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtColonia.Location = new System.Drawing.Point(99, 263);
			this.txtColonia.Name = "txtColonia";
			this.txtColonia.Size = new System.Drawing.Size(189, 20);
			this.txtColonia.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(47, 266);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 14);
			this.label6.TabIndex = 69;
			this.label6.Text = "Colonia:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 14);
			this.label4.TabIndex = 67;
			this.label4.Text = "Numero Interior:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMunicipio
			// 
			this.txtMunicipio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMunicipio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMunicipio.Location = new System.Drawing.Point(98, 289);
			this.txtMunicipio.Name = "txtMunicipio";
			this.txtMunicipio.Size = new System.Drawing.Size(190, 20);
			this.txtMunicipio.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(60, 188);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 14);
			this.label9.TabIndex = 66;
			this.label9.Text = "Calle:";
			// 
			// txtNumExterior
			// 
			this.txtNumExterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumExterior.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumExterior.Location = new System.Drawing.Point(100, 237);
			this.txtNumExterior.Name = "txtNumExterior";
			this.txtNumExterior.Size = new System.Drawing.Size(98, 20);
			this.txtNumExterior.TabIndex = 7;
			// 
			// txtNumInterior
			// 
			this.txtNumInterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumInterior.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumInterior.Location = new System.Drawing.Point(100, 211);
			this.txtNumInterior.Name = "txtNumInterior";
			this.txtNumInterior.Size = new System.Drawing.Size(98, 20);
			this.txtNumInterior.TabIndex = 6;
			// 
			// txtCalle
			// 
			this.txtCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCalle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalle.Location = new System.Drawing.Point(99, 185);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(189, 20);
			this.txtCalle.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(300, 23);
			this.label3.TabIndex = 65;
			this.label3.Text = "Domicilio del contacto:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(41, 117);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(51, 14);
			this.label14.TabIndex = 64;
			this.label14.Text = "Telefono:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefono.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(98, 114);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(190, 20);
			this.txtTelefono.TabIndex = 4;
			// 
			// txtApellidoMat
			// 
			this.txtApellidoMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtApellidoMat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoMat.Location = new System.Drawing.Point(98, 88);
			this.txtApellidoMat.Name = "txtApellidoMat";
			this.txtApellidoMat.Size = new System.Drawing.Size(190, 20);
			this.txtApellidoMat.TabIndex = 3;
			// 
			// txtApellidoPat
			// 
			this.txtApellidoPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtApellidoPat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoPat.Location = new System.Drawing.Point(99, 62);
			this.txtApellidoPat.Name = "txtApellidoPat";
			this.txtApellidoPat.Size = new System.Drawing.Size(189, 20);
			this.txtApellidoPat.TabIndex = 2;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(99, 35);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(189, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// lblA_ApMatOperador
			// 
			this.lblA_ApMatOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblA_ApMatOperador.AutoSize = true;
			this.lblA_ApMatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApMatOperador.Location = new System.Drawing.Point(3, 88);
			this.lblA_ApMatOperador.Name = "lblA_ApMatOperador";
			this.lblA_ApMatOperador.Size = new System.Drawing.Size(90, 14);
			this.lblA_ApMatOperador.TabIndex = 63;
			this.lblA_ApMatOperador.Text = "Apellido Materno:";
			this.lblA_ApMatOperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblA_ApPatOperador
			// 
			this.lblA_ApPatOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblA_ApPatOperador.AutoSize = true;
			this.lblA_ApPatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApPatOperador.Location = new System.Drawing.Point(6, 65);
			this.lblA_ApPatOperador.Name = "lblA_ApPatOperador";
			this.lblA_ApPatOperador.Size = new System.Drawing.Size(88, 14);
			this.lblA_ApPatOperador.TabIndex = 62;
			this.lblA_ApPatOperador.Text = "Apellido Paterno:";
			// 
			// lblA_NombreOperador
			// 
			this.lblA_NombreOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblA_NombreOperador.AutoSize = true;
			this.lblA_NombreOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_NombreOperador.Location = new System.Drawing.Point(34, 38);
			this.lblA_NombreOperador.Name = "lblA_NombreOperador";
			this.lblA_NombreOperador.Size = new System.Drawing.Size(61, 14);
			this.lblA_NombreOperador.TabIndex = 60;
			this.lblA_NombreOperador.Text = "Nombre(s):";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(-1, -1);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(301, 23);
			this.label10.TabIndex = 61;
			this.label10.Text = "Datos personales del contacto:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormContacto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(301, 502);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormContacto";
			this.Text = "Transportes LAR - Contacto";
			this.Load += new System.EventHandler(this.FormContactoLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblA_NombreOperador;
		private System.Windows.Forms.Label lblA_ApPatOperador;
		private System.Windows.Forms.Label lblA_ApMatOperador;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtApellidoPat;
		public System.Windows.Forms.TextBox txtApellidoMat;
		public System.Windows.Forms.MaskedTextBox txtTelefono;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtCalle;
		public System.Windows.Forms.TextBox txtNumInterior;
		public System.Windows.Forms.TextBox txtNumExterior;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.TextBox txtMunicipio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox txtColonia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.TextBox txtCP;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}
