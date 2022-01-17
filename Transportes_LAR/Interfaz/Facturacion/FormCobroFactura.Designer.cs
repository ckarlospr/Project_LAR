/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 04/08/2014
 * Time: 03:38 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Facturacion
{
	partial class FormCobroFactura
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCobroFactura));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dtEmpresa = new System.Windows.Forms.DataGridView();
			this.Alias_Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtRuta = new System.Windows.Forms.DataGridView();
			this.pOperador = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtPagoExternoCompleto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnPrestamoAdicional = new System.Windows.Forms.Button();
			this.txtPagoExternoSencillo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtcsen = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtccom = new System.Windows.Forms.TextBox();
			this.txtctasen = new System.Windows.Forms.TextBox();
			this.txtctacom = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ckMedio = new System.Windows.Forms.CheckBox();
			this.ckNocturno = new System.Windows.Forms.CheckBox();
			this.ckVespertino = new System.Windows.Forms.CheckBox();
			this.ckMañana = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.validar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.c_Pago_Externo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pago_Externo_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtEmpresa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtRuta)).BeginInit();
			this.pOperador.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtEmpresa
			// 
			this.dtEmpresa.AllowUserToAddRows = false;
			this.dtEmpresa.AllowUserToResizeColumns = false;
			this.dtEmpresa.AllowUserToResizeRows = false;
			this.dtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dtEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtEmpresa.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Alias_Op});
			this.dtEmpresa.Location = new System.Drawing.Point(12, 42);
			this.dtEmpresa.MultiSelect = false;
			this.dtEmpresa.Name = "dtEmpresa";
			this.dtEmpresa.RowHeadersVisible = false;
			this.dtEmpresa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtEmpresa.Size = new System.Drawing.Size(242, 547);
			this.dtEmpresa.TabIndex = 141;
			this.dtEmpresa.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtEmpresaCellEnter);
			// 
			// Alias_Op
			// 
			this.Alias_Op.DataPropertyName = "Alias_Op";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alias_Op.DefaultCellStyle = dataGridViewCellStyle1;
			this.Alias_Op.HeaderText = "Empresa";
			this.Alias_Op.MinimumWidth = 100;
			this.Alias_Op.Name = "Alias_Op";
			this.Alias_Op.ReadOnly = true;
			// 
			// dtRuta
			// 
			this.dtRuta.AllowUserToAddRows = false;
			this.dtRuta.AllowUserToResizeColumns = false;
			this.dtRuta.AllowUserToResizeRows = false;
			this.dtRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtRuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtRuta.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dtRuta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.cTurno,
									this.validar,
									this.c_Pago_Externo,
									this.Pago_Externo_Completo});
			this.dtRuta.Location = new System.Drawing.Point(260, 157);
			this.dtRuta.MultiSelect = false;
			this.dtRuta.Name = "dtRuta";
			this.dtRuta.RowHeadersVisible = false;
			this.dtRuta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtRuta.Size = new System.Drawing.Size(499, 432);
			this.dtRuta.TabIndex = 142;
			this.dtRuta.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtRutaColumnHeaderMouseClick);
			// 
			// pOperador
			// 
			this.pOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOperador.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperador.Controls.Add(this.groupBox4);
			this.pOperador.Controls.Add(this.groupBox3);
			this.pOperador.Location = new System.Drawing.Point(765, 42);
			this.pOperador.Name = "pOperador";
			this.pOperador.Size = new System.Drawing.Size(275, 547);
			this.pOperador.TabIndex = 144;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox4.Controls.Add(this.txtPagoExternoCompleto);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.btnPrestamoAdicional);
			this.groupBox4.Controls.Add(this.txtPagoExternoSencillo);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(10, 130);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(254, 100);
			this.groupBox4.TabIndex = 146;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Precios";
			// 
			// txtPagoExternoCompleto
			// 
			this.txtPagoExternoCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPagoExternoCompleto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPagoExternoCompleto.Location = new System.Drawing.Point(176, 46);
			this.txtPagoExternoCompleto.Name = "txtPagoExternoCompleto";
			this.txtPagoExternoCompleto.Size = new System.Drawing.Size(65, 20);
			this.txtPagoExternoCompleto.TabIndex = 188;
			this.txtPagoExternoCompleto.Text = "0.00";
			this.txtPagoExternoCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 22);
			this.label6.TabIndex = 189;
			this.label6.Text = "Pago Externos Completos";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPrestamoAdicional
			// 
			this.btnPrestamoAdicional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrestamoAdicional.BackColor = System.Drawing.Color.Transparent;
			this.btnPrestamoAdicional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrestamoAdicional.BackgroundImage")));
			this.btnPrestamoAdicional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPrestamoAdicional.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrestamoAdicional.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrestamoAdicional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrestamoAdicional.Location = new System.Drawing.Point(223, 73);
			this.btnPrestamoAdicional.Name = "btnPrestamoAdicional";
			this.btnPrestamoAdicional.Size = new System.Drawing.Size(18, 18);
			this.btnPrestamoAdicional.TabIndex = 187;
			this.btnPrestamoAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrestamoAdicional.UseVisualStyleBackColor = false;
			this.btnPrestamoAdicional.Click += new System.EventHandler(this.BtnPrestamoAdicionalClick);
			// 
			// txtPagoExternoSencillo
			// 
			this.txtPagoExternoSencillo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPagoExternoSencillo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPagoExternoSencillo.Location = new System.Drawing.Point(176, 20);
			this.txtPagoExternoSencillo.Name = "txtPagoExternoSencillo";
			this.txtPagoExternoSencillo.Size = new System.Drawing.Size(65, 20);
			this.txtPagoExternoSencillo.TabIndex = 15;
			this.txtPagoExternoSencillo.Text = "0.00";
			this.txtPagoExternoSencillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(45, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 22);
			this.label7.TabIndex = 142;
			this.label7.Text = "Pago Externos Sencillo";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox3.Controls.Add(this.txtcsen);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txtccom);
			this.groupBox3.Controls.Add(this.txtctasen);
			this.groupBox3.Controls.Add(this.txtctacom);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(10, 5);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(254, 119);
			this.groupBox3.TabIndex = 145;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Precios";
			// 
			// txtcsen
			// 
			this.txtcsen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcsen.Enabled = false;
			this.txtcsen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcsen.Location = new System.Drawing.Point(177, 41);
			this.txtcsen.Name = "txtcsen";
			this.txtcsen.Size = new System.Drawing.Size(65, 20);
			this.txtcsen.TabIndex = 16;
			this.txtcsen.Text = "0.00";
			this.txtcsen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtcsen.TextChanged += new System.EventHandler(this.TxtcsenTextChanged);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(22, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(147, 22);
			this.label9.TabIndex = 145;
			this.label9.Text = "Camión Sencillo";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtccom
			// 
			this.txtccom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtccom.Enabled = false;
			this.txtccom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtccom.Location = new System.Drawing.Point(176, 16);
			this.txtccom.Name = "txtccom";
			this.txtccom.Size = new System.Drawing.Size(65, 20);
			this.txtccom.TabIndex = 15;
			this.txtccom.Text = "0.00";
			this.txtccom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtccom.TextChanged += new System.EventHandler(this.TxtccomTextChanged);
			// 
			// txtctasen
			// 
			this.txtctasen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtctasen.Enabled = false;
			this.txtctasen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtctasen.Location = new System.Drawing.Point(177, 91);
			this.txtctasen.Name = "txtctasen";
			this.txtctasen.Size = new System.Drawing.Size(65, 20);
			this.txtctasen.TabIndex = 18;
			this.txtctasen.Text = "0.00";
			this.txtctasen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtctasen.TextChanged += new System.EventHandler(this.TxtctasenTextChanged);
			// 
			// txtctacom
			// 
			this.txtctacom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtctacom.Enabled = false;
			this.txtctacom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtctacom.Location = new System.Drawing.Point(177, 66);
			this.txtctacom.Name = "txtctacom";
			this.txtctacom.Size = new System.Drawing.Size(65, 20);
			this.txtctacom.TabIndex = 3;
			this.txtctacom.Text = "0.00";
			this.txtctacom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtctacom.TextChanged += new System.EventHandler(this.TxtctacomTextChanged);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(45, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(124, 22);
			this.label8.TabIndex = 142;
			this.label8.Text = "Camión Completo";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 22);
			this.label5.TabIndex = 140;
			this.label5.Text = "Camioneta Sencilla";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(38, 63);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 22);
			this.label11.TabIndex = 143;
			this.label11.Text = "Camioneta Completa";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.ckMedio);
			this.groupBox1.Controls.Add(this.ckNocturno);
			this.groupBox1.Controls.Add(this.ckVespertino);
			this.groupBox1.Controls.Add(this.ckMañana);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(260, 85);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(499, 66);
			this.groupBox1.TabIndex = 146;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Turno";
			// 
			// ckMedio
			// 
			this.ckMedio.Checked = true;
			this.ckMedio.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckMedio.Location = new System.Drawing.Point(93, 17);
			this.ckMedio.Name = "ckMedio";
			this.ckMedio.Size = new System.Drawing.Size(104, 24);
			this.ckMedio.TabIndex = 3;
			this.ckMedio.Text = "Medio día";
			this.ckMedio.UseVisualStyleBackColor = true;
			this.ckMedio.CheckedChanged += new System.EventHandler(this.CkMedioCheckedChanged);
			// 
			// ckNocturno
			// 
			this.ckNocturno.Checked = true;
			this.ckNocturno.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckNocturno.Location = new System.Drawing.Point(93, 42);
			this.ckNocturno.Name = "ckNocturno";
			this.ckNocturno.Size = new System.Drawing.Size(104, 24);
			this.ckNocturno.TabIndex = 2;
			this.ckNocturno.Text = "Nocturno";
			this.ckNocturno.UseVisualStyleBackColor = true;
			this.ckNocturno.CheckedChanged += new System.EventHandler(this.CkNocturnoCheckedChanged);
			// 
			// ckVespertino
			// 
			this.ckVespertino.Checked = true;
			this.ckVespertino.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckVespertino.Location = new System.Drawing.Point(6, 42);
			this.ckVespertino.Name = "ckVespertino";
			this.ckVespertino.Size = new System.Drawing.Size(104, 24);
			this.ckVespertino.TabIndex = 1;
			this.ckVespertino.Text = "Vespertino";
			this.ckVespertino.UseVisualStyleBackColor = true;
			this.ckVespertino.CheckedChanged += new System.EventHandler(this.CkVespertinoCheckedChanged);
			// 
			// ckMañana
			// 
			this.ckMañana.Checked = true;
			this.ckMañana.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckMañana.Location = new System.Drawing.Point(6, 17);
			this.ckMañana.Name = "ckMañana";
			this.ckMañana.Size = new System.Drawing.Size(104, 24);
			this.ckMañana.TabIndex = 0;
			this.ckMañana.Text = "Mañana";
			this.ckMañana.UseVisualStyleBackColor = true;
			this.ckMañana.CheckedChanged += new System.EventHandler(this.CkMañanaCheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.cmbTipo);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(260, 42);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(499, 42);
			this.groupBox2.TabIndex = 147;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Turno";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ruta";
			// 
			// cmbTipo
			// 
			this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"Normales",
									"Extras"});
			this.cmbTipo.Location = new System.Drawing.Point(53, 13);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(440, 22);
			this.cmbTipo.TabIndex = 0;
			this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipoSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(242, 22);
			this.label2.TabIndex = 148;
			this.label2.Text = "1. Selecciona la empresa";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(260, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(497, 22);
			this.label3.TabIndex = 149;
			this.label3.Text = "2. Selecciona las rutas";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(765, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(273, 22);
			this.label4.TabIndex = 150;
			this.label4.Text = "3. Inserta los costos de las rutas para facturar";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID Ruta";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Alias_Op";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn2.HeaderText = "Ruta";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// cTurno
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cTurno.DefaultCellStyle = dataGridViewCellStyle4;
			this.cTurno.HeaderText = "Turno";
			this.cTurno.Name = "cTurno";
			this.cTurno.ReadOnly = true;
			// 
			// validar
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.NullValue = "False";
			this.validar.DefaultCellStyle = dataGridViewCellStyle5;
			this.validar.HeaderText = "Selecciona";
			this.validar.Name = "validar";
			// 
			// c_Pago_Externo
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = "0";
			this.c_Pago_Externo.DefaultCellStyle = dataGridViewCellStyle6;
			this.c_Pago_Externo.HeaderText = "Pago Externo Sencillo";
			this.c_Pago_Externo.Name = "c_Pago_Externo";
			this.c_Pago_Externo.ReadOnly = true;
			// 
			// Pago_Externo_Completo
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Format = "N2";
			dataGridViewCellStyle7.NullValue = "0";
			this.Pago_Externo_Completo.DefaultCellStyle = dataGridViewCellStyle7;
			this.Pago_Externo_Completo.HeaderText = "Pago Externo Completo";
			this.Pago_Externo_Completo.Name = "Pago_Externo_Completo";
			// 
			// FormCobroFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1052, 601);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pOperador);
			this.Controls.Add(this.dtRuta);
			this.Controls.Add(this.dtEmpresa);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormCobroFactura";
			this.Text = "Transportes LAR - Cobro Factura";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCobroFacturaFormClosing);
			this.Load += new System.EventHandler(this.FormCobroFacturaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtEmpresa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtRuta)).EndInit();
			this.pOperador.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Pago_Externo_Completo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPagoExternoCompleto;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_Pago_Externo;
		private System.Windows.Forms.Button btnPrestamoAdicional;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPagoExternoSencillo;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox ckMañana;
		private System.Windows.Forms.CheckBox ckVespertino;
		private System.Windows.Forms.CheckBox ckNocturno;
		private System.Windows.Forms.CheckBox ckMedio;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn validar;
		private System.Windows.Forms.DataGridViewTextBoxColumn cTurno;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtctacom;
		private System.Windows.Forms.TextBox txtctasen;
		private System.Windows.Forms.TextBox txtccom;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtcsen;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel pOperador;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dtRuta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias_Op;
		private System.Windows.Forms.DataGridView dtEmpresa;
	}
}
