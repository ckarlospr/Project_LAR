/*
 * Created by SharpDevelop.
 * User: Xavi_Ochoa
 * Date: 22/10/2013
 * Time: 10:31 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	partial class FormTaxi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaxi));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gpDatos = new System.Windows.Forms.GroupBox();
			this.btnExcel = new System.Windows.Forms.Button();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtFechaCobro = new System.Windows.Forms.DateTimePicker();
			this.lblFechaInicio = new System.Windows.Forms.Label();
			this.dtFechaTaxi = new System.Windows.Forms.DateTimePicker();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.txtRuta = new System.Windows.Forms.TextBox();
			this.txtImporteTaxi = new System.Windows.Forms.TextBox();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.pDatos = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.gpFecha = new System.Windows.Forms.GroupBox();
			this.dtFechaActual = new System.Windows.Forms.DateTimePicker();
			this.label23 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.tabTaxis = new System.Windows.Forms.TabControl();
			this.tabListado = new System.Windows.Forms.TabPage();
			this.dataListado = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EstadoTaxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ID_DESC_LIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabInvestigar = new System.Windows.Forms.TabPage();
			this.dataInvestigar = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno_invetigar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Investigado = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Investigado2 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ID_DESC_INV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabCobrables = new System.Windows.Forms.TabPage();
			this.dataCobrar = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno_Cobrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cobrar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ID_DESC_TAXI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EstadoCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gpDatos.SuspendLayout();
			this.pDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.gpFecha.SuspendLayout();
			this.tabTaxis.SuspendLayout();
			this.tabListado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
			this.tabInvestigar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataInvestigar)).BeginInit();
			this.tabCobrables.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataCobrar)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(325, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(62, 47);
			this.pictureBox1.TabIndex = 204;
			this.pictureBox1.TabStop = false;
			// 
			// gpDatos
			// 
			this.gpDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.gpDatos.BackColor = System.Drawing.Color.Transparent;
			this.gpDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gpDatos.Controls.Add(this.btnExcel);
			this.gpDatos.Controls.Add(this.cmbEstado);
			this.gpDatos.Controls.Add(this.label8);
			this.gpDatos.Controls.Add(this.cmbTurno);
			this.gpDatos.Controls.Add(this.label6);
			this.gpDatos.Controls.Add(this.label7);
			this.gpDatos.Controls.Add(this.dtFechaCobro);
			this.gpDatos.Controls.Add(this.lblFechaInicio);
			this.gpDatos.Controls.Add(this.dtFechaTaxi);
			this.gpDatos.Controls.Add(this.label36);
			this.gpDatos.Controls.Add(this.label35);
			this.gpDatos.Controls.Add(this.txtRuta);
			this.gpDatos.Controls.Add(this.txtImporteTaxi);
			this.gpDatos.Controls.Add(this.txtEmpresa);
			this.gpDatos.Controls.Add(this.label2);
			this.gpDatos.Controls.Add(this.txtOperador);
			this.gpDatos.Controls.Add(this.label4);
			this.gpDatos.Controls.Add(this.txtUnidad);
			this.gpDatos.Controls.Add(this.label3);
			this.gpDatos.Controls.Add(this.btnAgregar);
			this.gpDatos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpDatos.Location = new System.Drawing.Point(17, 144);
			this.gpDatos.Name = "gpDatos";
			this.gpDatos.Size = new System.Drawing.Size(196, 342);
			this.gpDatos.TabIndex = 203;
			this.gpDatos.TabStop = false;
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.BackColor = System.Drawing.Color.Transparent;
			this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnExcel.Location = new System.Drawing.Point(15, 279);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(75, 53);
			this.btnExcel.TabIndex = 204;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// cmbEstado
			// 
			this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Items.AddRange(new object[] {
									"Investigar",
									"Cobrar",
									"Incobrable"});
			this.cmbEstado.Location = new System.Drawing.Point(86, 208);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(100, 22);
			this.cmbEstado.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(14, 213);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 17);
			this.label8.TabIndex = 203;
			this.label8.Text = "Estado";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbTurno
			// 
			this.cmbTurno.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio Día",
									"Vespertino",
									"Nocturno"});
			this.cmbTurno.Location = new System.Drawing.Point(86, 180);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(100, 22);
			this.cmbTurno.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 22);
			this.label6.TabIndex = 200;
			this.label6.Text = "Fecha Taxi";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(14, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 17);
			this.label7.TabIndex = 201;
			this.label7.Text = "Turno";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtFechaCobro
			// 
			this.dtFechaCobro.CustomFormat = "yyyy-MM-dd";
			this.dtFechaCobro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaCobro.Location = new System.Drawing.Point(86, 41);
			this.dtFechaCobro.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtFechaCobro.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtFechaCobro.Name = "dtFechaCobro";
			this.dtFechaCobro.Size = new System.Drawing.Size(100, 20);
			this.dtFechaCobro.TabIndex = 2;
			// 
			// lblFechaInicio
			// 
			this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaInicio.Location = new System.Drawing.Point(13, 41);
			this.lblFechaInicio.Name = "lblFechaInicio";
			this.lblFechaInicio.Size = new System.Drawing.Size(51, 20);
			this.lblFechaInicio.TabIndex = 135;
			this.lblFechaInicio.Text = "Fecha $";
			// 
			// dtFechaTaxi
			// 
			this.dtFechaTaxi.CustomFormat = "yyyy-MM-dd";
			this.dtFechaTaxi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaTaxi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaTaxi.Location = new System.Drawing.Point(86, 14);
			this.dtFechaTaxi.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtFechaTaxi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtFechaTaxi.Name = "dtFechaTaxi";
			this.dtFechaTaxi.Size = new System.Drawing.Size(100, 20);
			this.dtFechaTaxi.TabIndex = 1;
			this.dtFechaTaxi.ValueChanged += new System.EventHandler(this.DtFechaTaxiValueChanged);
			// 
			// label36
			// 
			this.label36.BackColor = System.Drawing.Color.White;
			this.label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(12, 68);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(67, 16);
			this.label36.TabIndex = 186;
			this.label36.Text = "Unidad";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.White;
			this.label35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(13, 97);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(59, 17);
			this.label35.TabIndex = 188;
			this.label35.Text = "Nick";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRuta
			// 
			this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRuta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRuta.Location = new System.Drawing.Point(87, 154);
			this.txtRuta.Name = "txtRuta";
			this.txtRuta.Size = new System.Drawing.Size(100, 20);
			this.txtRuta.TabIndex = 6;
			this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtImporteTaxi
			// 
			this.txtImporteTaxi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtImporteTaxi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporteTaxi.Location = new System.Drawing.Point(121, 238);
			this.txtImporteTaxi.Name = "txtImporteTaxi";
			this.txtImporteTaxi.Size = new System.Drawing.Size(67, 20);
			this.txtImporteTaxi.TabIndex = 9;
			this.txtImporteTaxi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtImporteTaxi.TextChanged += new System.EventHandler(this.TxtImporteTaxiTextChanged);
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmpresa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpresa.Location = new System.Drawing.Point(87, 126);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtEmpresa.TabIndex = 5;
			this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEmpresaKeyUp);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 190;
			this.label2.Text = "Importe por Taxi";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtOperador
			// 
			this.txtOperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOperador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(87, 96);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(100, 20);
			this.txtOperador.TabIndex = 4;
			this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 16);
			this.label4.TabIndex = 194;
			this.label4.Text = "Empresa";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUnidad
			// 
			this.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUnidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUnidad.Location = new System.Drawing.Point(87, 67);
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(100, 20);
			this.txtUnidad.TabIndex = 3;
			this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUnidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUnidadKeyUp);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 196;
			this.label3.Text = "Ruta";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAgregar.Location = new System.Drawing.Point(123, 279);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(67, 53);
			this.btnAgregar.TabIndex = 10;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// pDatos
			// 
			this.pDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pDatos.BackColor = System.Drawing.Color.MidnightBlue;
			this.pDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pDatos.BackgroundImage")));
			this.pDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pDatos.Controls.Add(this.gpFecha);
			this.pDatos.Controls.Add(this.tabTaxis);
			this.pDatos.Controls.Add(this.gpDatos);
			this.pDatos.Location = new System.Drawing.Point(14, 74);
			this.pDatos.Name = "pDatos";
			this.pDatos.Size = new System.Drawing.Size(1245, 507);
			this.pDatos.TabIndex = 301;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(862, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(62, 47);
			this.pictureBox2.TabIndex = 252;
			this.pictureBox2.TabStop = false;
			// 
			// gpFecha
			// 
			this.gpFecha.BackColor = System.Drawing.Color.Transparent;
			this.gpFecha.Controls.Add(this.dtFechaActual);
			this.gpFecha.Controls.Add(this.label23);
			this.gpFecha.Controls.Add(this.label13);
			this.gpFecha.Controls.Add(this.dtCorte);
			this.gpFecha.Controls.Add(this.dtInicio);
			this.gpFecha.Controls.Add(this.lblFechaCorte);
			this.gpFecha.Location = new System.Drawing.Point(17, 3);
			this.gpFecha.Name = "gpFecha";
			this.gpFecha.Size = new System.Drawing.Size(195, 140);
			this.gpFecha.TabIndex = 251;
			this.gpFecha.TabStop = false;
			// 
			// dtFechaActual
			// 
			this.dtFechaActual.CustomFormat = "yyyy-MM-dd";
			this.dtFechaActual.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaActual.Location = new System.Drawing.Point(105, 18);
			this.dtFechaActual.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtFechaActual.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtFechaActual.Name = "dtFechaActual";
			this.dtFechaActual.Size = new System.Drawing.Size(81, 20);
			this.dtFechaActual.TabIndex = 13;
			this.dtFechaActual.ValueChanged += new System.EventHandler(this.DtFechaActualValueChanged);
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(18, 21);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(81, 18);
			this.label23.TabIndex = 206;
			this.label23.Text = "Fecha Actual";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(38, 47);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(115, 16);
			this.label13.TabIndex = 140;
			this.label13.Text = "Periodo Quincenal";
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Enabled = false;
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(60, 110);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(81, 20);
			this.dtCorte.TabIndex = 143;
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Enabled = false;
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(60, 66);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(78, 20);
			this.dtInicio.TabIndex = 250;
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(86, 89);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(10, 18);
			this.lblFechaCorte.TabIndex = 141;
			this.lblFechaCorte.Text = "a";
			// 
			// tabTaxis
			// 
			this.tabTaxis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabTaxis.Controls.Add(this.tabListado);
			this.tabTaxis.Controls.Add(this.tabInvestigar);
			this.tabTaxis.Controls.Add(this.tabCobrables);
			this.tabTaxis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabTaxis.Location = new System.Drawing.Point(218, 13);
			this.tabTaxis.Multiline = true;
			this.tabTaxis.Name = "tabTaxis";
			this.tabTaxis.SelectedIndex = 0;
			this.tabTaxis.Size = new System.Drawing.Size(1007, 472);
			this.tabTaxis.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabTaxis.TabIndex = 14;
			// 
			// tabListado
			// 
			this.tabListado.BackColor = System.Drawing.Color.White;
			this.tabListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabListado.Controls.Add(this.dataListado);
			this.tabListado.Location = new System.Drawing.Point(4, 23);
			this.tabListado.Name = "tabListado";
			this.tabListado.Padding = new System.Windows.Forms.Padding(3);
			this.tabListado.Size = new System.Drawing.Size(999, 445);
			this.tabListado.TabIndex = 1;
			this.tabListado.Text = "Listado";
			// 
			// dataListado
			// 
			this.dataListado.AllowUserToAddRows = false;
			this.dataListado.AllowUserToResizeColumns = false;
			this.dataListado.AllowUserToResizeRows = false;
			this.dataListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataListado.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn9,
									this.dataGridViewTextBoxColumn10,
									this.FechaC,
									this.dataGridViewTextBoxColumn11,
									this.dataGridViewTextBoxColumn12,
									this.dataGridViewTextBoxColumn13,
									this.dataGridViewTextBoxColumn14,
									this.TURNO,
									this.dataGridViewTextBoxColumn16,
									this.dataGridViewTextBoxColumn15,
									this.EstadoTaxi,
									this.Eliminar,
									this.ID_DESC_LIST});
			this.dataListado.Location = new System.Drawing.Point(1, 1);
			this.dataListado.Name = "dataListado";
			this.dataListado.RowHeadersVisible = false;
			this.dataListado.Size = new System.Drawing.Size(993, 439);
			this.dataListado.TabIndex = 10;
			this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListadoCellContentClick);
			this.dataListado.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataListadoCellPainting);
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_R";
			this.dataGridViewTextBoxColumn9.HeaderText = "ID";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Visible = false;
			this.dataGridViewTextBoxColumn9.Width = 40;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Fecha";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn10.HeaderText = "Fecha Taxi";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Width = 62;
			// 
			// FechaC
			// 
			this.FechaC.HeaderText = "Fecha $";
			this.FechaC.Name = "FechaC";
			this.FechaC.Width = 62;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.HeaderText = "Unidad";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Width = 40;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.HeaderText = "Operador";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "Empresa";
			this.dataGridViewTextBoxColumn13.HeaderText = "Empresa";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Width = 155;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.DataPropertyName = "Ruta";
			this.dataGridViewTextBoxColumn14.HeaderText = "Ruta";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Width = 210;
			// 
			// TURNO
			// 
			this.TURNO.HeaderText = "Turno";
			this.TURNO.Name = "TURNO";
			this.TURNO.ReadOnly = true;
			this.TURNO.Width = 70;
			// 
			// dataGridViewTextBoxColumn16
			// 
			this.dataGridViewTextBoxColumn16.HeaderText = "Importe Taxi";
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn16.ReadOnly = true;
			this.dataGridViewTextBoxColumn16.Width = 60;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.DataPropertyName = "Cargo Operador";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn15.HeaderText = "Cargo Operador";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.ReadOnly = true;
			this.dataGridViewTextBoxColumn15.Width = 60;
			// 
			// EstadoTaxi
			// 
			this.EstadoTaxi.HeaderText = "Estado";
			this.EstadoTaxi.Name = "EstadoTaxi";
			this.EstadoTaxi.ReadOnly = true;
			this.EstadoTaxi.Width = 80;
			// 
			// Eliminar
			// 
			this.Eliminar.HeaderText = "Eliminar";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Width = 60;
			// 
			// ID_DESC_LIST
			// 
			this.ID_DESC_LIST.HeaderText = "ID_DESC";
			this.ID_DESC_LIST.Name = "ID_DESC_LIST";
			this.ID_DESC_LIST.ReadOnly = true;
			this.ID_DESC_LIST.Visible = false;
			// 
			// tabInvestigar
			// 
			this.tabInvestigar.BackColor = System.Drawing.Color.White;
			this.tabInvestigar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabInvestigar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabInvestigar.Controls.Add(this.dataInvestigar);
			this.tabInvestigar.Location = new System.Drawing.Point(4, 23);
			this.tabInvestigar.Name = "tabInvestigar";
			this.tabInvestigar.Padding = new System.Windows.Forms.Padding(3);
			this.tabInvestigar.Size = new System.Drawing.Size(999, 445);
			this.tabInvestigar.TabIndex = 2;
			this.tabInvestigar.Text = "Investigar";
			// 
			// dataInvestigar
			// 
			this.dataInvestigar.AllowUserToAddRows = false;
			this.dataInvestigar.AllowUserToResizeColumns = false;
			this.dataInvestigar.AllowUserToResizeRows = false;
			this.dataInvestigar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataInvestigar.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataInvestigar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataInvestigar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataInvestigar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataInvestigar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn5,
									this.dataGridViewTextBoxColumn6,
									this.Turno_invetigar,
									this.dataGridViewTextBoxColumn8,
									this.Investigado,
									this.Investigado2,
									this.ID_DESC_INV});
			this.dataInvestigar.Location = new System.Drawing.Point(1, 1);
			this.dataInvestigar.Name = "dataInvestigar";
			this.dataInvestigar.RowHeadersVisible = false;
			this.dataInvestigar.Size = new System.Drawing.Size(1012, 439);
			this.dataInvestigar.TabIndex = 10;
			this.dataInvestigar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataInvestigarCellContentClick);
			this.dataInvestigar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataInvetigarCellPainting);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_R";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 40;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Taxi";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 62;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Unidad";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 40;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Operador";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Empresa";
			this.dataGridViewTextBoxColumn5.HeaderText = "Empresa";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 155;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Ruta";
			this.dataGridViewTextBoxColumn6.HeaderText = "Ruta";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 210;
			// 
			// Turno_invetigar
			// 
			this.Turno_invetigar.HeaderText = "Turno";
			this.Turno_invetigar.Name = "Turno_invetigar";
			this.Turno_invetigar.ReadOnly = true;
			this.Turno_invetigar.Width = 70;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.HeaderText = "Importe Taxi";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Width = 60;
			// 
			// Investigado
			// 
			this.Investigado.HeaderText = "Investigado cobrable";
			this.Investigado.Name = "Investigado";
			this.Investigado.Width = 60;
			// 
			// Investigado2
			// 
			this.Investigado2.HeaderText = "Investigado No cobrable";
			this.Investigado2.Name = "Investigado2";
			this.Investigado2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Investigado2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Investigado2.Width = 60;
			// 
			// ID_DESC_INV
			// 
			this.ID_DESC_INV.HeaderText = "ID_DESC";
			this.ID_DESC_INV.Name = "ID_DESC_INV";
			this.ID_DESC_INV.Visible = false;
			// 
			// tabCobrables
			// 
			this.tabCobrables.BackColor = System.Drawing.Color.White;
			this.tabCobrables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabCobrables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabCobrables.Controls.Add(this.dataCobrar);
			this.tabCobrables.Location = new System.Drawing.Point(4, 23);
			this.tabCobrables.Name = "tabCobrables";
			this.tabCobrables.Padding = new System.Windows.Forms.Padding(3);
			this.tabCobrables.Size = new System.Drawing.Size(999, 445);
			this.tabCobrables.TabIndex = 6;
			this.tabCobrables.Text = "Cobrables";
			// 
			// dataCobrar
			// 
			this.dataCobrar.AllowUserToAddRows = false;
			this.dataCobrar.AllowUserToResizeColumns = false;
			this.dataCobrar.AllowUserToResizeRows = false;
			this.dataCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataCobrar.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataCobrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataCobrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataCobrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn7,
									this.dataGridViewTextBoxColumn19,
									this.dataGridViewTextBoxColumn20,
									this.dataGridViewTextBoxColumn24,
									this.dataGridViewTextBoxColumn25,
									this.dataGridViewTextBoxColumn26,
									this.dataGridViewTextBoxColumn27,
									this.Turno_Cobrar,
									this.dataGridViewTextBoxColumn28,
									this.Cobrar,
									this.ID_DESC_TAXI,
									this.EstadoCobro});
			this.dataCobrar.Location = new System.Drawing.Point(1, 1);
			this.dataCobrar.Name = "dataCobrar";
			this.dataCobrar.RowHeadersVisible = false;
			this.dataCobrar.Size = new System.Drawing.Size(993, 439);
			this.dataCobrar.TabIndex = 11;
			this.dataCobrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCobrarCellContentClick);
			this.dataCobrar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataCobrarCellPainting);
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_R";
			this.dataGridViewTextBoxColumn7.HeaderText = "ID";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Visible = false;
			this.dataGridViewTextBoxColumn7.Width = 40;
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.DataPropertyName = "Fecha";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTextBoxColumn19.HeaderText = "Fecha Taxi";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn19.ReadOnly = true;
			this.dataGridViewTextBoxColumn19.Width = 62;
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.HeaderText = "Fecha $";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn20.Width = 62;
			// 
			// dataGridViewTextBoxColumn24
			// 
			this.dataGridViewTextBoxColumn24.HeaderText = "Unidad";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn24.ReadOnly = true;
			this.dataGridViewTextBoxColumn24.Width = 40;
			// 
			// dataGridViewTextBoxColumn25
			// 
			this.dataGridViewTextBoxColumn25.HeaderText = "Operador";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn25.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn26
			// 
			this.dataGridViewTextBoxColumn26.DataPropertyName = "Empresa";
			this.dataGridViewTextBoxColumn26.HeaderText = "Empresa";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn26.ReadOnly = true;
			this.dataGridViewTextBoxColumn26.Width = 155;
			// 
			// dataGridViewTextBoxColumn27
			// 
			this.dataGridViewTextBoxColumn27.DataPropertyName = "Ruta";
			this.dataGridViewTextBoxColumn27.HeaderText = "Ruta";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn27.ReadOnly = true;
			this.dataGridViewTextBoxColumn27.Width = 210;
			// 
			// Turno_Cobrar
			// 
			this.Turno_Cobrar.HeaderText = "Turno";
			this.Turno_Cobrar.Name = "Turno_Cobrar";
			this.Turno_Cobrar.ReadOnly = true;
			this.Turno_Cobrar.Width = 70;
			// 
			// dataGridViewTextBoxColumn28
			// 
			this.dataGridViewTextBoxColumn28.HeaderText = "Importe Taxi";
			this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
			this.dataGridViewTextBoxColumn28.ReadOnly = true;
			this.dataGridViewTextBoxColumn28.Width = 60;
			// 
			// Cobrar
			// 
			this.Cobrar.HeaderText = "Cobrar";
			this.Cobrar.Name = "Cobrar";
			this.Cobrar.Width = 60;
			// 
			// ID_DESC_TAXI
			// 
			this.ID_DESC_TAXI.HeaderText = "ID_DESC";
			this.ID_DESC_TAXI.Name = "ID_DESC_TAXI";
			this.ID_DESC_TAXI.ReadOnly = true;
			this.ID_DESC_TAXI.Visible = false;
			// 
			// EstadoCobro
			// 
			this.EstadoCobro.HeaderText = "Estado";
			this.EstadoCobro.Name = "EstadoCobro";
			this.EstadoCobro.Visible = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(-8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1282, 58);
			this.label5.TabIndex = 164;
			this.label5.Text = "Taxis del Periodo";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormTaxi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1269, 597);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pDatos);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTaxi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Transportes LAR - Control Descuento Taxis";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTaxiFormClosing);
			this.Load += new System.EventHandler(this.FormTaxiLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gpDatos.ResumeLayout(false);
			this.gpDatos.PerformLayout();
			this.pDatos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.gpFecha.ResumeLayout(false);
			this.tabTaxis.ResumeLayout(false);
			this.tabListado.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
			this.tabInvestigar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataInvestigar)).EndInit();
			this.tabCobrables.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataCobrar)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.GroupBox gpDatos;
		private System.Windows.Forms.GroupBox gpFecha;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCobro;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_DESC_TAXI;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_DESC_INV;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_DESC_LIST;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno_Cobrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno_invetigar;
		private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
		private System.Windows.Forms.DataGridViewButtonColumn Investigado2;
		private System.Windows.Forms.ComboBox cmbEstado;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.DataGridView dataInvestigar;
		private System.Windows.Forms.DataGridViewButtonColumn Cobrar;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.DataGridView dataCobrar;
		private System.Windows.Forms.DataGridViewButtonColumn Investigado;
		private System.Windows.Forms.DataGridView dataListado;
		private System.Windows.Forms.TabPage tabCobrables;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.TabPage tabInvestigar;
		private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTaxi;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaC;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.TabPage tabListado;
		private System.Windows.Forms.TabControl tabTaxis;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.DateTimePicker dtFechaCobro;
		private System.Windows.Forms.DateTimePicker dtFechaTaxi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.DateTimePicker dtFechaActual;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Panel pDatos;
		private System.Windows.Forms.TextBox txtRuta;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtImporteTaxi;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblFechaInicio;
	}
}
