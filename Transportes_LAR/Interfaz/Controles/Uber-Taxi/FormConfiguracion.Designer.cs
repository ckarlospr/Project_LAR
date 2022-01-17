/*
 * Creado por SharpDevelop.
 * Usuario: Sistemas
 * Fecha: 23/07/2016
 * Hora: 11:40 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	partial class FormConfiguracion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblLimpiar = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgUsuarios = new System.Windows.Forms.DataGridView();
			this.ID_Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TARJETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.cmbTarjeta = new System.Windows.Forms.ComboBox();
			this.lblMotivo = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblCuentas = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.gbCorreos = new System.Windows.Forms.GroupBox();
			this.txtTiempo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.txtCorreo4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCorreo3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCorreo2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCorreo1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
			this.panel2.SuspendLayout();
			this.gbCorreos.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblLimpiar);
			this.groupBox2.Controls.Add(this.txtNumero);
			this.groupBox2.Controls.Add(this.cmbTipo);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.dgUsuarios);
			this.groupBox2.Controls.Add(this.txtOperador);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnAgregar);
			this.groupBox2.Controls.Add(this.cmbTarjeta);
			this.groupBox2.Controls.Add(this.lblMotivo);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Location = new System.Drawing.Point(4, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(478, 195);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// lblLimpiar
			// 
			this.lblLimpiar.Enabled = false;
			this.lblLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("lblLimpiar.Image")));
			this.lblLimpiar.Location = new System.Drawing.Point(9, 149);
			this.lblLimpiar.Name = "lblLimpiar";
			this.lblLimpiar.Size = new System.Drawing.Size(40, 31);
			this.lblLimpiar.TabIndex = 7;
			this.lblLimpiar.Click += new System.EventHandler(this.LblLimpiarClick);
			// 
			// txtNumero
			// 
			this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumero.Enabled = false;
			this.txtNumero.Location = new System.Drawing.Point(111, 82);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(70, 20);
			this.txtNumero.TabIndex = 3;
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.Enabled = false;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"SANTANDER",
									"BANORTE",
									"BANCOMER",
									"BANAMEX",
									"HSBC"});
			this.cmbTipo.Location = new System.Drawing.Point(56, 111);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(125, 21);
			this.cmbTipo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(9, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 23);
			this.label3.TabIndex = 149;
			this.label3.Text = "Tipo:";
			// 
			// dgUsuarios
			// 
			this.dgUsuarios.AllowUserToAddRows = false;
			this.dgUsuarios.AllowUserToDeleteRows = false;
			this.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Responsable,
									this.Usuario,
									this.TARJETA,
									this.Tipo});
			this.dgUsuarios.Location = new System.Drawing.Point(187, 48);
			this.dgUsuarios.MultiSelect = false;
			this.dgUsuarios.Name = "dgUsuarios";
			this.dgUsuarios.ReadOnly = true;
			this.dgUsuarios.RowHeadersVisible = false;
			this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgUsuarios.Size = new System.Drawing.Size(281, 132);
			this.dgUsuarios.TabIndex = 6;
			this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgUsuariosCellClick);
			// 
			// ID_Responsable
			// 
			this.ID_Responsable.HeaderText = "ID_Responsable";
			this.ID_Responsable.Name = "ID_Responsable";
			this.ID_Responsable.ReadOnly = true;
			this.ID_Responsable.Visible = false;
			// 
			// Usuario
			// 
			this.Usuario.HeaderText = "Usuario";
			this.Usuario.Name = "Usuario";
			this.Usuario.ReadOnly = true;
			// 
			// TARJETA
			// 
			this.TARJETA.HeaderText = "N. Tarjeta";
			this.TARJETA.Name = "TARJETA";
			this.TARJETA.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo Tarjera";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Location = new System.Drawing.Point(56, 55);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(125, 20);
			this.txtOperador.TabIndex = 1;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.TextChanged += new System.EventHandler(this.TxtOperadorTextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 145;
			this.label2.Text = "Usuario:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.Location = new System.Drawing.Point(92, 148);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(89, 31);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// cmbTarjeta
			// 
			this.cmbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTarjeta.FormattingEnabled = true;
			this.cmbTarjeta.Items.AddRange(new object[] {
									"SI",
									"NO"});
			this.cmbTarjeta.Location = new System.Drawing.Point(56, 82);
			this.cmbTarjeta.Name = "cmbTarjeta";
			this.cmbTarjeta.Size = new System.Drawing.Size(49, 21);
			this.cmbTarjeta.TabIndex = 2;
			this.cmbTarjeta.SelectedIndexChanged += new System.EventHandler(this.CmbTarjetaSelectedIndexChanged);
			// 
			// lblMotivo
			// 
			this.lblMotivo.Location = new System.Drawing.Point(6, 85);
			this.lblMotivo.Name = "lblMotivo";
			this.lblMotivo.Size = new System.Drawing.Size(47, 23);
			this.lblMotivo.TabIndex = 130;
			this.lblMotivo.Text = "Tarjerta:";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.lblCuentas);
			this.panel2.Location = new System.Drawing.Point(0, 7);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(478, 35);
			this.panel2.TabIndex = 129;
			// 
			// lblCuentas
			// 
			this.lblCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCuentas.Location = new System.Drawing.Point(111, 5);
			this.lblCuentas.Name = "lblCuentas";
			this.lblCuentas.Size = new System.Drawing.Size(270, 23);
			this.lblCuentas.TabIndex = 0;
			this.lblCuentas.Text = "Cuentas Uber - Taxi";
			this.lblCuentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSalir
			// 
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.Location = new System.Drawing.Point(418, 448);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(64, 43);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// gbCorreos
			// 
			this.gbCorreos.Controls.Add(this.txtTiempo);
			this.gbCorreos.Controls.Add(this.label9);
			this.gbCorreos.Controls.Add(this.label13);
			this.gbCorreos.Controls.Add(this.panel5);
			this.gbCorreos.Controls.Add(this.cmdGuardar);
			this.gbCorreos.Controls.Add(this.txtCorreo4);
			this.gbCorreos.Controls.Add(this.label6);
			this.gbCorreos.Controls.Add(this.txtCorreo3);
			this.gbCorreos.Controls.Add(this.label8);
			this.gbCorreos.Controls.Add(this.txtCorreo2);
			this.gbCorreos.Controls.Add(this.label1);
			this.gbCorreos.Controls.Add(this.txtCorreo1);
			this.gbCorreos.Controls.Add(this.label4);
			this.gbCorreos.Controls.Add(this.label5);
			this.gbCorreos.Controls.Add(this.panel1);
			this.gbCorreos.Location = new System.Drawing.Point(4, 198);
			this.gbCorreos.Name = "gbCorreos";
			this.gbCorreos.Size = new System.Drawing.Size(478, 242);
			this.gbCorreos.TabIndex = 151;
			this.gbCorreos.TabStop = false;
			// 
			// txtTiempo
			// 
			this.txtTiempo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTiempo.Location = new System.Drawing.Point(104, 163);
			this.txtTiempo.Name = "txtTiempo";
			this.txtTiempo.Size = new System.Drawing.Size(64, 20);
			this.txtTiempo.TabIndex = 181;
			this.txtTiempo.TextChanged += new System.EventHandler(this.TxtTiempoTextChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(174, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(301, 33);
			this.label9.TabIndex = 180;
			this.label9.Text = "TIEMPO PARA QUE EL SISTEMA AVISE QUE HAY PROGRAMCIONES DE UBER O TAXI (MINUTOS)";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(17, 166);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 179;
			this.label13.Text = "Tiempo de Aviso:";
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel5.Location = new System.Drawing.Point(9, 146);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(460, 5);
			this.panel5.TabIndex = 177;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdGuardar.Location = new System.Drawing.Point(203, 205);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(89, 31);
			this.cmdGuardar.TabIndex = 176;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// txtCorreo4
			// 
			this.txtCorreo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCorreo4.Location = new System.Drawing.Point(64, 119);
			this.txtCorreo4.Name = "txtCorreo4";
			this.txtCorreo4.Size = new System.Drawing.Size(161, 20);
			this.txtCorreo4.TabIndex = 174;
			this.txtCorreo4.TextChanged += new System.EventHandler(this.TxtCorreo4TextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 175;
			this.label6.Text = "Correo 4:";
			// 
			// txtCorreo3
			// 
			this.txtCorreo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCorreo3.Location = new System.Drawing.Point(64, 95);
			this.txtCorreo3.Name = "txtCorreo3";
			this.txtCorreo3.Size = new System.Drawing.Size(161, 20);
			this.txtCorreo3.TabIndex = 173;
			this.txtCorreo3.TextChanged += new System.EventHandler(this.TxtCorreo3TextChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(14, 95);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 172;
			this.label8.Text = "Correo 3:";
			// 
			// txtCorreo2
			// 
			this.txtCorreo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCorreo2.Location = new System.Drawing.Point(64, 71);
			this.txtCorreo2.Name = "txtCorreo2";
			this.txtCorreo2.Size = new System.Drawing.Size(161, 20);
			this.txtCorreo2.TabIndex = 170;
			this.txtCorreo2.TextChanged += new System.EventHandler(this.TxtCorreo2TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 171;
			this.label1.Text = "Correo 2:";
			// 
			// txtCorreo1
			// 
			this.txtCorreo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCorreo1.Location = new System.Drawing.Point(64, 47);
			this.txtCorreo1.Name = "txtCorreo1";
			this.txtCorreo1.Size = new System.Drawing.Size(161, 20);
			this.txtCorreo1.TabIndex = 169;
			this.txtCorreo1.TextChanged += new System.EventHandler(this.TxtCorreo1TextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(231, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(241, 33);
			this.label4.TabIndex = 168;
			this.label4.Text = "CORREOS PARA ENVIAR NOTIFICACIONES DE AVISOS\r\n";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 167;
			this.label5.Text = "Correo 1:";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.label7);
			this.panel1.Location = new System.Drawing.Point(0, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(478, 35);
			this.panel1.TabIndex = 129;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(111, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(270, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Correos - Otros";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormConfiguracion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 503);
			this.Controls.Add(this.gbCorreos);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConfiguracion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configuración";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfiguracionFormClosing);
			this.Load += new System.EventHandler(this.FormConfiguracionLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormConfiguracionKeyUp);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
			this.panel2.ResumeLayout(false);
			this.gbCorreos.ResumeLayout(false);
			this.gbCorreos.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtTiempo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCorreo1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCorreo2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCorreo3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCorreo4;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox gbCorreos;
		private System.Windows.Forms.Label lblLimpiar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TARJETA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Responsable;
		private System.Windows.Forms.DataGridView dgUsuarios;
		private System.Windows.Forms.Label lblCuentas;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblMotivo;
		private System.Windows.Forms.ComboBox cmbTarjeta;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
