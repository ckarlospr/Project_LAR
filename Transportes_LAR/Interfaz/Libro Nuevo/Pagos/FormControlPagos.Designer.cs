/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 09/11/2015
 * Time: 9:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class FormControlPagos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControlPagos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtImporteTotalProgramacion = new System.Windows.Forms.TextBox();
			this.cbMetodo2Programcion = new System.Windows.Forms.ComboBox();
			this.cbMetodo1Programacion = new System.Windows.Forms.ComboBox();
			this.bnSalirProgramcion = new System.Windows.Forms.Button();
			this.txtGuardarProgramcion = new System.Windows.Forms.Button();
			this.dgPagosProgramdos = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.METODOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuProgramacionPagos = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.confirmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label65 = new System.Windows.Forms.Label();
			this.dtpFechaProgramacion = new System.Windows.Forms.DateTimePicker();
			this.label63 = new System.Windows.Forms.Label();
			this.txtImporteProgramcion = new System.Windows.Forms.TextBox();
			this.cbTipoPagoProgramacion = new System.Windows.Forms.ComboBox();
			this.label64 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.txtubica = new System.Windows.Forms.TextBox();
			this.txtComprobantePago = new System.Windows.Forms.TextBox();
			this.btnGuardarPago = new System.Windows.Forms.Button();
			this.label41 = new System.Windows.Forms.Label();
			this.btnSalirPago = new System.Windows.Forms.Button();
			this.txtImporteTotalPago = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtImportePago = new System.Windows.Forms.TextBox();
			this.cbTipoPago = new System.Windows.Forms.ComboBox();
			this.label58 = new System.Windows.Forms.Label();
			this.dgPagos = new System.Windows.Forms.DataGridView();
			this.ID_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COMPROBANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label66 = new System.Windows.Forms.Label();
			this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
			this.label76 = new System.Windows.Forms.Label();
			this.label77 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblUbica = new System.Windows.Forms.Label();
			this.txtFolioPago = new System.Windows.Forms.TextBox();
			this.label73 = new System.Windows.Forms.Label();
			this.txtImporteSevicio = new System.Windows.Forms.TextBox();
			this.txtDestinoServicio = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPagosProgramdos)).BeginInit();
			this.MenuProgramacionPagos.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 49);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(558, 281);
			this.tabControl1.TabIndex = 133;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtImporteTotalProgramacion);
			this.tabPage1.Controls.Add(this.cbMetodo2Programcion);
			this.tabPage1.Controls.Add(this.cbMetodo1Programacion);
			this.tabPage1.Controls.Add(this.bnSalirProgramcion);
			this.tabPage1.Controls.Add(this.txtGuardarProgramcion);
			this.tabPage1.Controls.Add(this.dgPagosProgramdos);
			this.tabPage1.Controls.Add(this.label65);
			this.tabPage1.Controls.Add(this.dtpFechaProgramacion);
			this.tabPage1.Controls.Add(this.label63);
			this.tabPage1.Controls.Add(this.txtImporteProgramcion);
			this.tabPage1.Controls.Add(this.cbTipoPagoProgramacion);
			this.tabPage1.Controls.Add(this.label64);
			this.tabPage1.Controls.Add(this.label34);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(550, 255);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Programación de Pagos";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(373, 231);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(74, 23);
			this.label1.TabIndex = 145;
			this.label1.Text = "Importe Total:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 129);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(180, 3);
			this.label2.TabIndex = 144;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtImporteTotalProgramacion
			// 
			this.txtImporteTotalProgramacion.Enabled = false;
			this.txtImporteTotalProgramacion.Location = new System.Drawing.Point(447, 229);
			this.txtImporteTotalProgramacion.Name = "txtImporteTotalProgramacion";
			this.txtImporteTotalProgramacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtImporteTotalProgramacion.Size = new System.Drawing.Size(97, 20);
			this.txtImporteTotalProgramacion.TabIndex = 124;
			// 
			// cbMetodo2Programcion
			// 
			this.cbMetodo2Programcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMetodo2Programcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMetodo2Programcion.FormattingEnabled = true;
			this.cbMetodo2Programcion.Items.AddRange(new object[] {
									"LUIS ARRIAGA RUIZ",
									"JUANA GARCIA GAMBOA",
									"RAY KENNY ARRIAGA GARCIA",
									"LUIS DARIO ARRIAGA GARCIA",
									"ALMA SELENNE ARRIAGA GARCIA",
									"JESUS DANIEL ARRIAGA GARCIA"});
			this.cbMetodo2Programcion.Location = new System.Drawing.Point(78, 73);
			this.cbMetodo2Programcion.Margin = new System.Windows.Forms.Padding(2);
			this.cbMetodo2Programcion.Name = "cbMetodo2Programcion";
			this.cbMetodo2Programcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbMetodo2Programcion.Size = new System.Drawing.Size(97, 21);
			this.cbMetodo2Programcion.TabIndex = 3;
			this.cbMetodo2Programcion.SelectedIndexChanged += new System.EventHandler(this.CbMetodo2ProgramcionSelectedIndexChanged);
			this.cbMetodo2Programcion.Click += new System.EventHandler(this.CbMetodo2ProgramcionClick);
			// 
			// cbMetodo1Programacion
			// 
			this.cbMetodo1Programacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMetodo1Programacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMetodo1Programacion.FormattingEnabled = true;
			this.cbMetodo1Programacion.Items.AddRange(new object[] {
									"EN OFICINA",
									"AL OPERADOR",
									"COBRANZA DOMICILIADA"});
			this.cbMetodo1Programacion.Location = new System.Drawing.Point(78, 73);
			this.cbMetodo1Programacion.Margin = new System.Windows.Forms.Padding(2);
			this.cbMetodo1Programacion.Name = "cbMetodo1Programacion";
			this.cbMetodo1Programacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbMetodo1Programacion.Size = new System.Drawing.Size(97, 21);
			this.cbMetodo1Programacion.TabIndex = 122;
			this.cbMetodo1Programacion.SelectedIndexChanged += new System.EventHandler(this.CbMetodo1ProgramacionSelectedIndexChanged);
			// 
			// bnSalirProgramcion
			// 
			this.bnSalirProgramcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnSalirProgramcion.Location = new System.Drawing.Point(16, 187);
			this.bnSalirProgramcion.Name = "bnSalirProgramcion";
			this.bnSalirProgramcion.Size = new System.Drawing.Size(82, 44);
			this.bnSalirProgramcion.TabIndex = 5;
			this.bnSalirProgramcion.Text = "Salir";
			this.bnSalirProgramcion.UseVisualStyleBackColor = true;
			this.bnSalirProgramcion.Click += new System.EventHandler(this.BnSalirProgramcionClick);
			// 
			// txtGuardarProgramcion
			// 
			this.txtGuardarProgramcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuardarProgramcion.Image = ((System.Drawing.Image)(resources.GetObject("txtGuardarProgramcion.Image")));
			this.txtGuardarProgramcion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.txtGuardarProgramcion.Location = new System.Drawing.Point(113, 187);
			this.txtGuardarProgramcion.Name = "txtGuardarProgramcion";
			this.txtGuardarProgramcion.Size = new System.Drawing.Size(82, 44);
			this.txtGuardarProgramcion.TabIndex = 6;
			this.txtGuardarProgramcion.Text = "Grabar";
			this.txtGuardarProgramcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtGuardarProgramcion.UseVisualStyleBackColor = true;
			this.txtGuardarProgramcion.Click += new System.EventHandler(this.TxtGuardarProgramcionClick);
			// 
			// dgPagosProgramdos
			// 
			this.dgPagosProgramdos.AllowUserToAddRows = false;
			this.dgPagosProgramdos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPagosProgramdos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgPagosProgramdos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPagosProgramdos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Column8,
									this.Column9,
									this.METODOP,
									this.dataGridViewTextBoxColumn14});
			this.dgPagosProgramdos.ContextMenuStrip = this.MenuProgramacionPagos;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgPagosProgramdos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgPagosProgramdos.Location = new System.Drawing.Point(201, 9);
			this.dgPagosProgramdos.MultiSelect = false;
			this.dgPagosProgramdos.Name = "dgPagosProgramdos";
			this.dgPagosProgramdos.ReadOnly = true;
			this.dgPagosProgramdos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPagosProgramdos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgPagosProgramdos.RowHeadersVisible = false;
			this.dgPagosProgramdos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPagosProgramdos.Size = new System.Drawing.Size(343, 214);
			this.dgPagosProgramdos.TabIndex = 116;
			this.dgPagosProgramdos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPagosProgramdosCellClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 50;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "FECHA";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 80;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "TIPO";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 90;
			// 
			// METODOP
			// 
			this.METODOP.HeaderText = "METODO";
			this.METODOP.Name = "METODOP";
			this.METODOP.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.HeaderText = "IMPORTE";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Width = 70;
			// 
			// MenuProgramacionPagos
			// 
			this.MenuProgramacionPagos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.confirmarToolStripMenuItem});
			this.MenuProgramacionPagos.Name = "MenuProgramacionPagos";
			this.MenuProgramacionPagos.Size = new System.Drawing.Size(129, 26);
			// 
			// confirmarToolStripMenuItem
			// 
			this.confirmarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("confirmarToolStripMenuItem.Image")));
			this.confirmarToolStripMenuItem.Name = "confirmarToolStripMenuItem";
			this.confirmarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.confirmarToolStripMenuItem.Text = "Confirmar";
			this.confirmarToolStripMenuItem.Click += new System.EventHandler(this.ConfirmarToolStripMenuItemClick);
			// 
			// label65
			// 
			this.label65.Location = new System.Drawing.Point(30, 20);
			this.label65.Name = "label65";
			this.label65.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label65.Size = new System.Drawing.Size(43, 23);
			this.label65.TabIndex = 115;
			this.label65.Text = "Fecha:";
			// 
			// dtpFechaProgramacion
			// 
			this.dtpFechaProgramacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaProgramacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaProgramacion.Location = new System.Drawing.Point(78, 17);
			this.dtpFechaProgramacion.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFechaProgramacion.Name = "dtpFechaProgramacion";
			this.dtpFechaProgramacion.Size = new System.Drawing.Size(97, 20);
			this.dtpFechaProgramacion.TabIndex = 1;
			this.dtpFechaProgramacion.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label63
			// 
			this.label63.Location = new System.Drawing.Point(25, 99);
			this.label63.Name = "label63";
			this.label63.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label63.Size = new System.Drawing.Size(48, 23);
			this.label63.TabIndex = 111;
			this.label63.Text = "Importe:";
			// 
			// txtImporteProgramcion
			// 
			this.txtImporteProgramcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtImporteProgramcion.Location = new System.Drawing.Point(78, 99);
			this.txtImporteProgramcion.Name = "txtImporteProgramcion";
			this.txtImporteProgramcion.Size = new System.Drawing.Size(97, 20);
			this.txtImporteProgramcion.TabIndex = 4;
			// 
			// cbTipoPagoProgramacion
			// 
			this.cbTipoPagoProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoPagoProgramacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTipoPagoProgramacion.FormattingEnabled = true;
			this.cbTipoPagoProgramacion.Items.AddRange(new object[] {
									"EFECTIVO",
									"DEPOSITO",
									"TRANS ELECTRONICA",
									"CHEQUE"});
			this.cbTipoPagoProgramacion.Location = new System.Drawing.Point(78, 42);
			this.cbTipoPagoProgramacion.Margin = new System.Windows.Forms.Padding(2);
			this.cbTipoPagoProgramacion.Name = "cbTipoPagoProgramacion";
			this.cbTipoPagoProgramacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbTipoPagoProgramacion.Size = new System.Drawing.Size(97, 21);
			this.cbTipoPagoProgramacion.TabIndex = 2;
			this.cbTipoPagoProgramacion.SelectedIndexChanged += new System.EventHandler(this.CbTipoPagoProgramacionSelectedIndexChanged);
			// 
			// label64
			// 
			this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label64.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label64.Location = new System.Drawing.Point(6, 43);
			this.label64.Name = "label64";
			this.label64.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label64.Size = new System.Drawing.Size(79, 17);
			this.label64.TabIndex = 112;
			this.label64.Text = "Tipo de pago:";
			this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label34.Location = new System.Drawing.Point(22, 73);
			this.label34.Name = "label34";
			this.label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label34.Size = new System.Drawing.Size(51, 17);
			this.label34.TabIndex = 121;
			this.label34.Text = "Método:";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.txtComentario);
			this.tabPage2.Controls.Add(this.txtubica);
			this.tabPage2.Controls.Add(this.txtComprobantePago);
			this.tabPage2.Controls.Add(this.btnGuardarPago);
			this.tabPage2.Controls.Add(this.label41);
			this.tabPage2.Controls.Add(this.btnSalirPago);
			this.tabPage2.Controls.Add(this.txtImporteTotalPago);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.txtImportePago);
			this.tabPage2.Controls.Add(this.cbTipoPago);
			this.tabPage2.Controls.Add(this.label58);
			this.tabPage2.Controls.Add(this.dgPagos);
			this.tabPage2.Controls.Add(this.label66);
			this.tabPage2.Controls.Add(this.dtpFechaPago);
			this.tabPage2.Controls.Add(this.label76);
			this.tabPage2.Controls.Add(this.label77);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.lblUbica);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(550, 255);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Registro de pagos";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(201, 3);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(343, 17);
			this.label5.TabIndex = 136;
			this.label5.Text = "Pagos Realizados";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtComentario
			// 
			this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComentario.Location = new System.Drawing.Point(16, 178);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(178, 55);
			this.txtComentario.TabIndex = 7;
			// 
			// txtubica
			// 
			this.txtubica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtubica.Location = new System.Drawing.Point(86, 123);
			this.txtubica.Name = "txtubica";
			this.txtubica.Size = new System.Drawing.Size(104, 20);
			this.txtubica.TabIndex = 6;
			this.txtubica.Text = "N/A";
			this.txtubica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtubica.Visible = false;
			// 
			// txtComprobantePago
			// 
			this.txtComprobantePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtComprobantePago.Location = new System.Drawing.Point(86, 72);
			this.txtComprobantePago.Name = "txtComprobantePago";
			this.txtComprobantePago.Size = new System.Drawing.Size(104, 20);
			this.txtComprobantePago.TabIndex = 3;
			// 
			// btnGuardarPago
			// 
			this.btnGuardarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPago.Image")));
			this.btnGuardarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarPago.Location = new System.Drawing.Point(300, 200);
			this.btnGuardarPago.Name = "btnGuardarPago";
			this.btnGuardarPago.Size = new System.Drawing.Size(82, 44);
			this.btnGuardarPago.TabIndex = 8;
			this.btnGuardarPago.Text = "Guardar";
			this.btnGuardarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarPago.UseVisualStyleBackColor = true;
			this.btnGuardarPago.Click += new System.EventHandler(this.BtnGuardarPagoClick);
			// 
			// label41
			// 
			this.label41.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(11, 236);
			this.label41.Name = "label41";
			this.label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label41.Size = new System.Drawing.Size(185, 3);
			this.label41.TabIndex = 143;
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSalirPago
			// 
			this.btnSalirPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalirPago.Location = new System.Drawing.Point(200, 200);
			this.btnSalirPago.Name = "btnSalirPago";
			this.btnSalirPago.Size = new System.Drawing.Size(82, 44);
			this.btnSalirPago.TabIndex = 9;
			this.btnSalirPago.Text = "Salir";
			this.btnSalirPago.UseVisualStyleBackColor = true;
			this.btnSalirPago.Click += new System.EventHandler(this.BtnSalirPagoClick);
			// 
			// txtImporteTotalPago
			// 
			this.txtImporteTotalPago.Enabled = false;
			this.txtImporteTotalPago.Location = new System.Drawing.Point(467, 199);
			this.txtImporteTotalPago.Name = "txtImporteTotalPago";
			this.txtImporteTotalPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtImporteTotalPago.Size = new System.Drawing.Size(77, 20);
			this.txtImporteTotalPago.TabIndex = 139;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(395, 200);
			this.label17.Name = "label17";
			this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label17.Size = new System.Drawing.Size(74, 23);
			this.label17.TabIndex = 140;
			this.label17.Text = "Importe Total:";
			// 
			// txtImportePago
			// 
			this.txtImportePago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtImportePago.Location = new System.Drawing.Point(86, 98);
			this.txtImportePago.Name = "txtImportePago";
			this.txtImportePago.Size = new System.Drawing.Size(104, 20);
			this.txtImportePago.TabIndex = 4;
			// 
			// cbTipoPago
			// 
			this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbTipoPago.FormattingEnabled = true;
			this.cbTipoPago.Items.AddRange(new object[] {
									"EFECTIVO",
									"DEPOSITO",
									"TRANS ELECTRONICA",
									"CHEQUE"});
			this.cbTipoPago.Location = new System.Drawing.Point(86, 46);
			this.cbTipoPago.Margin = new System.Windows.Forms.Padding(2);
			this.cbTipoPago.Name = "cbTipoPago";
			this.cbTipoPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cbTipoPago.Size = new System.Drawing.Size(104, 21);
			this.cbTipoPago.TabIndex = 2;
			this.cbTipoPago.SelectedIndexChanged += new System.EventHandler(this.CbTipoPagoSelectedIndexChanged);
			// 
			// label58
			// 
			this.label58.Location = new System.Drawing.Point(38, 99);
			this.label58.Name = "label58";
			this.label58.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label58.Size = new System.Drawing.Size(50, 23);
			this.label58.TabIndex = 137;
			this.label58.Text = "Importe:";
			// 
			// dgPagos
			// 
			this.dgPagos.AllowUserToAddRows = false;
			this.dgPagos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_PAGO,
									this.dataGridViewTextBoxColumn13,
									this.Column13,
									this.Column12,
									this.dataGridViewTextBoxColumn15,
									this.COMPROBANTE});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgPagos.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgPagos.Location = new System.Drawing.Point(201, 20);
			this.dgPagos.Name = "dgPagos";
			this.dgPagos.ReadOnly = true;
			this.dgPagos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgPagos.RowHeadersVisible = false;
			this.dgPagos.Size = new System.Drawing.Size(343, 174);
			this.dgPagos.TabIndex = 133;
			// 
			// ID_PAGO
			// 
			this.ID_PAGO.HeaderText = "ID";
			this.ID_PAGO.Name = "ID_PAGO";
			this.ID_PAGO.ReadOnly = true;
			this.ID_PAGO.Visible = false;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.HeaderText = "FECHA";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Width = 60;
			// 
			// Column13
			// 
			this.Column13.HeaderText = "FOLIO";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			this.Column13.Width = 40;
			// 
			// Column12
			// 
			this.Column12.HeaderText = "ANTICIPO";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			this.Column12.Width = 70;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.HeaderText = "TIPO";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.ReadOnly = true;
			this.dataGridViewTextBoxColumn15.Width = 70;
			// 
			// COMPROBANTE
			// 
			this.COMPROBANTE.HeaderText = "COMPROBANTE";
			this.COMPROBANTE.Name = "COMPROBANTE";
			this.COMPROBANTE.ReadOnly = true;
			// 
			// label66
			// 
			this.label66.Location = new System.Drawing.Point(37, 20);
			this.label66.Name = "label66";
			this.label66.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label66.Size = new System.Drawing.Size(43, 23);
			this.label66.TabIndex = 132;
			this.label66.Text = "Fecha:";
			// 
			// dtpFechaPago
			// 
			this.dtpFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaPago.Location = new System.Drawing.Point(86, 20);
			this.dtpFechaPago.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFechaPago.Name = "dtpFechaPago";
			this.dtpFechaPago.Size = new System.Drawing.Size(104, 20);
			this.dtpFechaPago.TabIndex = 1;
			this.dtpFechaPago.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			// 
			// label76
			// 
			this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label76.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label76.Location = new System.Drawing.Point(10, 47);
			this.label76.Name = "label76";
			this.label76.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label76.Size = new System.Drawing.Size(79, 17);
			this.label76.TabIndex = 129;
			this.label76.Text = "Tipo de pago:";
			this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label77
			// 
			this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label77.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label77.Location = new System.Drawing.Point(9, 72);
			this.label77.Name = "label77";
			this.label77.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label77.Size = new System.Drawing.Size(79, 17);
			this.label77.TabIndex = 134;
			this.label77.Text = "Num. Referec.:";
			this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(71, 160);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(66, 23);
			this.label4.TabIndex = 150;
			this.label4.Text = "Comentarios";
			// 
			// lblUbica
			// 
			this.lblUbica.Location = new System.Drawing.Point(39, 124);
			this.lblUbica.Name = "lblUbica";
			this.lblUbica.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblUbica.Size = new System.Drawing.Size(42, 23);
			this.lblUbica.TabIndex = 147;
			this.lblUbica.Text = "Ubica:";
			this.lblUbica.Visible = false;
			// 
			// txtFolioPago
			// 
			this.txtFolioPago.Location = new System.Drawing.Point(447, 39);
			this.txtFolioPago.Name = "txtFolioPago";
			this.txtFolioPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtFolioPago.Size = new System.Drawing.Size(104, 20);
			this.txtFolioPago.TabIndex = 127;
			this.txtFolioPago.Visible = false;
			// 
			// label73
			// 
			this.label73.Location = new System.Drawing.Point(411, 38);
			this.label73.Name = "label73";
			this.label73.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label73.Size = new System.Drawing.Size(34, 23);
			this.label73.TabIndex = 128;
			this.label73.Text = "Folio:";
			this.label73.Visible = false;
			// 
			// txtImporteSevicio
			// 
			this.txtImporteSevicio.Enabled = false;
			this.txtImporteSevicio.Location = new System.Drawing.Point(250, 12);
			this.txtImporteSevicio.Name = "txtImporteSevicio";
			this.txtImporteSevicio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtImporteSevicio.Size = new System.Drawing.Size(77, 20);
			this.txtImporteSevicio.TabIndex = 107;
			// 
			// txtDestinoServicio
			// 
			this.txtDestinoServicio.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtDestinoServicio.Enabled = false;
			this.txtDestinoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestinoServicio.Location = new System.Drawing.Point(61, 12);
			this.txtDestinoServicio.Name = "txtDestinoServicio";
			this.txtDestinoServicio.Size = new System.Drawing.Size(141, 20);
			this.txtDestinoServicio.TabIndex = 118;
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(14, 15);
			this.label40.Name = "label40";
			this.label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label40.Size = new System.Drawing.Size(47, 15);
			this.label40.TabIndex = 119;
			this.label40.Text = "Destino:";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label61
			// 
			this.label61.Location = new System.Drawing.Point(208, 13);
			this.label61.Name = "label61";
			this.label61.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label61.Size = new System.Drawing.Size(44, 20);
			this.label61.TabIndex = 108;
			this.label61.Text = "Importe:";
			// 
			// txtSaldo
			// 
			this.txtSaldo.BackColor = System.Drawing.Color.PowderBlue;
			this.txtSaldo.Enabled = false;
			this.txtSaldo.Location = new System.Drawing.Point(380, 13);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtSaldo.Size = new System.Drawing.Size(77, 20);
			this.txtSaldo.TabIndex = 134;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(343, 16);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(44, 20);
			this.label3.TabIndex = 135;
			this.label3.Text = "Saldo:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormControlPagos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 333);
			this.Controls.Add(this.txtSaldo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.txtImporteSevicio);
			this.Controls.Add(this.label61);
			this.Controls.Add(this.label40);
			this.Controls.Add(this.txtDestinoServicio);
			this.Controls.Add(this.txtFolioPago);
			this.Controls.Add(this.label73);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(584, 372);
			this.MinimumSize = new System.Drawing.Size(584, 372);
			this.Name = "FormControlPagos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pagos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormControlPagosFormClosing);
			this.Load += new System.EventHandler(this.FormControlPagosLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPagosProgramdos)).EndInit();
			this.MenuProgramacionPagos.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label lblUbica;
		private System.Windows.Forms.TextBox txtubica;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.DataGridViewTextBoxColumn COMPROBANTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAGO;
		private System.Windows.Forms.ToolStripMenuItem confirmarToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuProgramacionPagos;
		private System.Windows.Forms.DataGridViewTextBoxColumn METODOP;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtImporteTotalProgramacion;
		private System.Windows.Forms.TextBox txtComprobantePago;
		private System.Windows.Forms.Button btnGuardarPago;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label64;
		private System.Windows.Forms.ComboBox cbTipoPagoProgramacion;
		private System.Windows.Forms.Label label61;
		private System.Windows.Forms.TextBox txtImporteProgramcion;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.DateTimePicker dtpFechaProgramacion;
		private System.Windows.Forms.Label label65;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridView dgPagosProgramdos;
		private System.Windows.Forms.Button txtGuardarProgramcion;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.TextBox txtDestinoServicio;
		private System.Windows.Forms.TextBox txtImporteSevicio;
		private System.Windows.Forms.Button bnSalirProgramcion;
		private System.Windows.Forms.ComboBox cbMetodo1Programacion;
		private System.Windows.Forms.ComboBox cbMetodo2Programcion;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label77;
		private System.Windows.Forms.Label label76;
		private System.Windows.Forms.Label label73;
		private System.Windows.Forms.DateTimePicker dtpFechaPago;
		private System.Windows.Forms.Label label66;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridView dgPagos;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.ComboBox cbTipoPago;
		private System.Windows.Forms.TextBox txtFolioPago;
		private System.Windows.Forms.TextBox txtImportePago;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtImporteTotalPago;
		private System.Windows.Forms.Button btnSalirPago;
		private System.Windows.Forms.Label label41;
	}
}
