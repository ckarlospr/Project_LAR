/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 10/07/2012
 * Time: 10:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Usuario
{
	partial class FormUsuario
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
									"Usuario"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
									"Privilegios"}, "Candado.png", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.listView = new System.Windows.Forms.ListView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.cmbNivelUsuario = new System.Windows.Forms.ComboBox();
			this.lblNivelUsuario = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtContrasenaRepeticion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
			this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblA_ApMatOperador = new System.Windows.Forms.Label();
			this.lblA_ApPatOperador = new System.Windows.Forms.Label();
			this.lblA_NombreOperador = new System.Windows.Forms.Label();
			this.dataPrivilegio = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.pnlPrivilegio = new System.Windows.Forms.Panel();
			this.groupBox9.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPrivilegio)).BeginInit();
			this.pnlPrivilegio.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView
			// 
			this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.listView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			listViewItem1.UseItemStyleForSubItems = false;
			listViewItem2.UseItemStyleForSubItems = false;
			this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1,
									listViewItem2});
			this.listView.LargeImageList = this.imageList;
			this.listView.Location = new System.Drawing.Point(-5, -4);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Scrollable = false;
			this.listView.Size = new System.Drawing.Size(132, 453);
			this.listView.SmallImageList = this.imageList;
			this.listView.TabIndex = 0;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewItemSelectionChanged);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "Usuario.png");
			this.imageList.Images.SetKeyName(1, "Candado.png");
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(369, 410);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(92, 26);
			this.btnCancelar.TabIndex = 21;
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
			this.btnAgregar.Location = new System.Drawing.Point(265, 410);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(92, 26);
			this.btnAgregar.TabIndex = 20;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Tan;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(142, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(312, 14);
			this.label3.TabIndex = 22;
			this.label3.Text = "Ingrese los datos correspondientes del nuevo usuario:";
			// 
			// groupBox9
			// 
			this.groupBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox9.BackgroundImage")));
			this.groupBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox9.Controls.Add(this.cmbNivelUsuario);
			this.groupBox9.Controls.Add(this.lblNivelUsuario);
			this.groupBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox9.Location = new System.Drawing.Point(142, 263);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(314, 54);
			this.groupBox9.TabIndex = 25;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Actividad";
			// 
			// cmbNivelUsuario
			// 
			this.cmbNivelUsuario.FormattingEnabled = true;
			this.cmbNivelUsuario.Items.AddRange(new object[] {
									"ADMINISTRATIVO",
									"COBRANZA",
									"COMBUSTIBLE",
									"COORDINADOR",
									"GERENCIAL",
									"MANTENIMIENTO",
									"MASTER",
									"NOMINA",
									"VENTAS",
									"RECEPCION",
									"OPERACION",
									"ENCUESTADOR"});
			this.cmbNivelUsuario.Location = new System.Drawing.Point(122, 19);
			this.cmbNivelUsuario.Name = "cmbNivelUsuario";
			this.cmbNivelUsuario.Size = new System.Drawing.Size(175, 22);
			this.cmbNivelUsuario.TabIndex = 13;
			// 
			// lblNivelUsuario
			// 
			this.lblNivelUsuario.AutoSize = true;
			this.lblNivelUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNivelUsuario.Location = new System.Drawing.Point(32, 22);
			this.lblNivelUsuario.Name = "lblNivelUsuario";
			this.lblNivelUsuario.Size = new System.Drawing.Size(73, 14);
			this.lblNivelUsuario.TabIndex = 12;
			this.lblNivelUsuario.Text = "Nivel Usuario:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.txtContrasenaRepeticion);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtContrasena);
			this.groupBox2.Controls.Add(this.txtUsuario);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(142, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(314, 96);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos de Usuario";
			// 
			// txtContrasenaRepeticion
			// 
			this.txtContrasenaRepeticion.Location = new System.Drawing.Point(122, 66);
			this.txtContrasenaRepeticion.Name = "txtContrasenaRepeticion";
			this.txtContrasenaRepeticion.PasswordChar = '*';
			this.txtContrasenaRepeticion.Size = new System.Drawing.Size(175, 20);
			this.txtContrasenaRepeticion.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 14);
			this.label1.TabIndex = 11;
			this.label1.Text = "Repita Contraseña:";
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(122, 41);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.Size = new System.Drawing.Size(175, 20);
			this.txtContrasena.TabIndex = 10;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(122, 16);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(175, 20);
			this.txtUsuario.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(39, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 14);
			this.label4.TabIndex = 7;
			this.label4.Text = "Contraseña:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 14);
			this.label5.TabIndex = 6;
			this.label5.Text = "Nombre Usuario:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.txtApellidoMaterno);
			this.groupBox1.Controls.Add(this.txtApellidoPaterno);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.lblA_ApMatOperador);
			this.groupBox1.Controls.Add(this.lblA_ApPatOperador);
			this.groupBox1.Controls.Add(this.lblA_NombreOperador);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(142, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(314, 94);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos personales del usuario";
			// 
			// txtApellidoMaterno
			// 
			this.txtApellidoMaterno.Location = new System.Drawing.Point(122, 66);
			this.txtApellidoMaterno.Name = "txtApellidoMaterno";
			this.txtApellidoMaterno.Size = new System.Drawing.Size(175, 20);
			this.txtApellidoMaterno.TabIndex = 11;
			// 
			// txtApellidoPaterno
			// 
			this.txtApellidoPaterno.Location = new System.Drawing.Point(122, 41);
			this.txtApellidoPaterno.Name = "txtApellidoPaterno";
			this.txtApellidoPaterno.Size = new System.Drawing.Size(175, 20);
			this.txtApellidoPaterno.TabIndex = 10;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(122, 18);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(175, 20);
			this.txtNombre.TabIndex = 9;
			// 
			// lblA_ApMatOperador
			// 
			this.lblA_ApMatOperador.AutoSize = true;
			this.lblA_ApMatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApMatOperador.Location = new System.Drawing.Point(16, 66);
			this.lblA_ApMatOperador.Name = "lblA_ApMatOperador";
			this.lblA_ApMatOperador.Size = new System.Drawing.Size(90, 14);
			this.lblA_ApMatOperador.TabIndex = 8;
			this.lblA_ApMatOperador.Text = "Apellido Materno:";
			// 
			// lblA_ApPatOperador
			// 
			this.lblA_ApPatOperador.AutoSize = true;
			this.lblA_ApPatOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_ApPatOperador.Location = new System.Drawing.Point(18, 44);
			this.lblA_ApPatOperador.Name = "lblA_ApPatOperador";
			this.lblA_ApPatOperador.Size = new System.Drawing.Size(88, 14);
			this.lblA_ApPatOperador.TabIndex = 7;
			this.lblA_ApPatOperador.Text = "Apellido Paterno:";
			// 
			// lblA_NombreOperador
			// 
			this.lblA_NombreOperador.AutoSize = true;
			this.lblA_NombreOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA_NombreOperador.Location = new System.Drawing.Point(47, 20);
			this.lblA_NombreOperador.Name = "lblA_NombreOperador";
			this.lblA_NombreOperador.Size = new System.Drawing.Size(61, 14);
			this.lblA_NombreOperador.TabIndex = 6;
			this.lblA_NombreOperador.Text = "Nombre(s):";
			// 
			// dataPrivilegio
			// 
			this.dataPrivilegio.AllowUserToAddRows = false;
			this.dataPrivilegio.AllowUserToDeleteRows = false;
			this.dataPrivilegio.AllowUserToResizeColumns = false;
			this.dataPrivilegio.AllowUserToResizeRows = false;
			this.dataPrivilegio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataPrivilegio.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataPrivilegio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataPrivilegio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataPrivilegio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPrivilegio.ColumnHeadersVisible = false;
			this.dataPrivilegio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataPrivilegio.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataPrivilegio.Location = new System.Drawing.Point(13, 30);
			this.dataPrivilegio.MultiSelect = false;
			this.dataPrivilegio.Name = "dataPrivilegio";
			this.dataPrivilegio.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataPrivilegio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataPrivilegio.RowHeadersVisible = false;
			this.dataPrivilegio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataPrivilegio.Size = new System.Drawing.Size(293, 354);
			this.dataPrivilegio.TabIndex = 1;
			this.dataPrivilegio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPrivilegioCellClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 30;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Interfaz";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 243;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(272, 14);
			this.label6.TabIndex = 7;
			this.label6.Text = "Seleccione los privilegios que tendrá el usuario:";
			// 
			// pnlPrivilegio
			// 
			this.pnlPrivilegio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pnlPrivilegio.BackColor = System.Drawing.Color.MidnightBlue;
			this.pnlPrivilegio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPrivilegio.BackgroundImage")));
			this.pnlPrivilegio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlPrivilegio.Controls.Add(this.label6);
			this.pnlPrivilegio.Controls.Add(this.dataPrivilegio);
			this.pnlPrivilegio.Location = new System.Drawing.Point(139, 7);
			this.pnlPrivilegio.Name = "pnlPrivilegio";
			this.pnlPrivilegio.Size = new System.Drawing.Size(322, 397);
			this.pnlPrivilegio.TabIndex = 27;
			this.pnlPrivilegio.Visible = false;
			// 
			// FormUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(468, 448);
			this.Controls.Add(this.pnlPrivilegio);
			this.Controls.Add(this.groupBox9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.listView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Usuario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsuarioFormClosing);
			this.Load += new System.EventHandler(this.FormUsuarioLoad);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPrivilegio)).EndInit();
			this.pnlPrivilegio.ResumeLayout(false);
			this.pnlPrivilegio.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.ComboBox cmbNivelUsuario;
		private System.Windows.Forms.Label lblNivelUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataPrivilegio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel pnlPrivilegio;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblA_NombreOperador;
		private System.Windows.Forms.Label lblA_ApPatOperador;
		private System.Windows.Forms.Label lblA_ApMatOperador;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtApellidoPaterno;
		public System.Windows.Forms.TextBox txtApellidoMaterno;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtUsuario;
		public System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtContrasenaRepeticion;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ListView listView;
	}
}
