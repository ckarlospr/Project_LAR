/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 18/07/2015
 * Time: 12:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Ruta
{
	partial class FormTipoRuta
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoRuta));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPeriodo = new System.Windows.Forms.Label();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.cbEliminadasNRM = new System.Windows.Forms.CheckBox();
			this.cbTurnoRuta = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNombreRuta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtRutaEXT = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_tipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Cobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubNombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDesignarOperador = new System.Windows.Forms.Button();
			this.dtRutaNRM = new System.Windows.Forms.DataGridView();
			this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_km = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmpresaNRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuEliminarRuta = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.eliminarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtRutaEXT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtRutaNRM)).BeginInit();
			this.MenuEliminarRuta.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.dtRutaEXT);
			this.panel2.Controls.Add(this.btnDesignarOperador);
			this.panel2.Controls.Add(this.dtRutaNRM);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1337, 705);
			this.panel2.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.txtEmpresa);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblPeriodo);
			this.panel1.Controls.Add(this.lblFechaCorte);
			this.panel1.Controls.Add(this.dtInicio);
			this.panel1.Controls.Add(this.dtCorte);
			this.panel1.Controls.Add(this.cbEliminadasNRM);
			this.panel1.Controls.Add(this.cbTurnoRuta);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtNombreRuta);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(14, 39);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(684, 63);
			this.panel1.TabIndex = 209;
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpresa.Location = new System.Drawing.Point(367, 7);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(242, 20);
			this.txtEmpresa.TabIndex = 143;
			this.txtEmpresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEmpresaKeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(315, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 14);
			this.label1.TabIndex = 144;
			this.label1.Text = "Empresa:";
			// 
			// lblPeriodo
			// 
			this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
			this.lblPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeriodo.Location = new System.Drawing.Point(241, 37);
			this.lblPeriodo.Name = "lblPeriodo";
			this.lblPeriodo.Size = new System.Drawing.Size(43, 22);
			this.lblPeriodo.TabIndex = 139;
			this.lblPeriodo.Text = "Periodo";
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(367, 35);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(11, 22);
			this.lblFechaCorte.TabIndex = 140;
			this.lblFechaCorte.Text = "-";
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(291, 34);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(75, 20);
			this.dtInicio.TabIndex = 141;
			this.dtInicio.ValueChanged += new System.EventHandler(this.DtInicioValueChanged);
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(379, 34);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(76, 20);
			this.dtCorte.TabIndex = 142;
			this.dtCorte.ValueChanged += new System.EventHandler(this.DtCorteValueChanged);
			// 
			// cbEliminadasNRM
			// 
			this.cbEliminadasNRM.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cbEliminadasNRM.Location = new System.Drawing.Point(505, 34);
			this.cbEliminadasNRM.Name = "cbEliminadasNRM";
			this.cbEliminadasNRM.Size = new System.Drawing.Size(104, 24);
			this.cbEliminadasNRM.TabIndex = 50;
			this.cbEliminadasNRM.Text = "Eliminadas NRM";
			this.cbEliminadasNRM.UseVisualStyleBackColor = true;
			this.cbEliminadasNRM.CheckedChanged += new System.EventHandler(this.CbEliminadasNRMCheckedChanged);
			// 
			// cbTurnoRuta
			// 
			this.cbTurnoRuta.FormattingEnabled = true;
			this.cbTurnoRuta.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno"});
			this.cbTurnoRuta.Location = new System.Drawing.Point(60, 34);
			this.cbTurnoRuta.Name = "cbTurnoRuta";
			this.cbTurnoRuta.Size = new System.Drawing.Size(147, 21);
			this.cbTurnoRuta.TabIndex = 48;
			this.cbTurnoRuta.SelectedIndexChanged += new System.EventHandler(this.CbTurnoRutaSelectedIndexChanged);
			this.cbTurnoRuta.TextChanged += new System.EventHandler(this.CbTurnoRutaTextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 14);
			this.label5.TabIndex = 47;
			this.label5.Text = "Turno:";
			// 
			// txtNombreRuta
			// 
			this.txtNombreRuta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreRuta.Location = new System.Drawing.Point(60, 8);
			this.txtNombreRuta.Name = "txtNombreRuta";
			this.txtNombreRuta.Size = new System.Drawing.Size(242, 20);
			this.txtNombreRuta.TabIndex = 42;
			this.txtNombreRuta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNombreRutaKeyUp);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 14);
			this.label4.TabIndex = 45;
			this.label4.Text = "Nombre:";
			// 
			// dtRutaEXT
			// 
			this.dtRutaEXT.AllowUserToAddRows = false;
			this.dtRutaEXT.AllowUserToDeleteRows = false;
			this.dtRutaEXT.AllowUserToResizeColumns = false;
			this.dtRutaEXT.AllowUserToResizeRows = false;
			this.dtRutaEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtRutaEXT.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dtRutaEXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtRutaEXT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtRutaEXT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtRutaEXT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn5,
									this.c_tipo2,
									this.Empresa,
									this.Tipo_Cobro,
									this.SubNombreE});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtRutaEXT.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtRutaEXT.Location = new System.Drawing.Point(733, 35);
			this.dtRutaEXT.MultiSelect = false;
			this.dtRutaEXT.Name = "dtRutaEXT";
			this.dtRutaEXT.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtRutaEXT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dtRutaEXT.RowHeadersVisible = false;
			this.dtRutaEXT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtRutaEXT.Size = new System.Drawing.Size(599, 665);
			this.dtRutaEXT.TabIndex = 208;
			this.dtRutaEXT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtRutaEXTCellClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 93;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Turno";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 92;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Sentido";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 93;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Kilometros";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 92;
			// 
			// c_tipo2
			// 
			this.c_tipo2.HeaderText = "Fecha";
			this.c_tipo2.Name = "c_tipo2";
			this.c_tipo2.ReadOnly = true;
			this.c_tipo2.Width = 93;
			// 
			// Empresa
			// 
			this.Empresa.HeaderText = "Empresa";
			this.Empresa.Name = "Empresa";
			this.Empresa.ReadOnly = true;
			this.Empresa.Width = 92;
			// 
			// Tipo_Cobro
			// 
			this.Tipo_Cobro.HeaderText = "Tipo Cobro";
			this.Tipo_Cobro.Name = "Tipo_Cobro";
			this.Tipo_Cobro.ReadOnly = true;
			this.Tipo_Cobro.Width = 93;
			// 
			// SubNombreE
			// 
			this.SubNombreE.HeaderText = "SubNombre";
			this.SubNombreE.Name = "SubNombreE";
			this.SubNombreE.ReadOnly = true;
			// 
			// btnDesignarOperador
			// 
			this.btnDesignarOperador.BackColor = System.Drawing.Color.Transparent;
			this.btnDesignarOperador.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDesignarOperador.Image = ((System.Drawing.Image)(resources.GetObject("btnDesignarOperador.Image")));
			this.btnDesignarOperador.Location = new System.Drawing.Point(702, 341);
			this.btnDesignarOperador.Name = "btnDesignarOperador";
			this.btnDesignarOperador.Size = new System.Drawing.Size(27, 52);
			this.btnDesignarOperador.TabIndex = 207;
			this.btnDesignarOperador.UseVisualStyleBackColor = false;
			this.btnDesignarOperador.Click += new System.EventHandler(this.BtnDesignarOperadorClick);
			// 
			// dtRutaNRM
			// 
			this.dtRutaNRM.AllowUserToAddRows = false;
			this.dtRutaNRM.AllowUserToDeleteRows = false;
			this.dtRutaNRM.AllowUserToResizeColumns = false;
			this.dtRutaNRM.AllowUserToResizeRows = false;
			this.dtRutaNRM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dtRutaNRM.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dtRutaNRM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtRutaNRM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dtRutaNRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtRutaNRM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.c_id,
									this.c_nombre,
									this.c_turno,
									this.INICIO,
									this.FIN,
									this.DIA,
									this.c_sentido,
									this.c_km,
									this.c_Tipo,
									this.EmpresaNRM,
									this.TipoCobro,
									this.Subempresa});
			this.dtRutaNRM.ContextMenuStrip = this.MenuEliminarRuta;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtRutaNRM.DefaultCellStyle = dataGridViewCellStyle5;
			this.dtRutaNRM.Location = new System.Drawing.Point(10, 108);
			this.dtRutaNRM.MultiSelect = false;
			this.dtRutaNRM.Name = "dtRutaNRM";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtRutaNRM.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dtRutaNRM.RowHeadersVisible = false;
			this.dtRutaNRM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtRutaNRM.Size = new System.Drawing.Size(688, 592);
			this.dtRutaNRM.TabIndex = 206;
			this.dtRutaNRM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtRutaNRMCellClick);
			// 
			// c_id
			// 
			this.c_id.HeaderText = "id";
			this.c_id.Name = "c_id";
			this.c_id.Visible = false;
			// 
			// c_nombre
			// 
			this.c_nombre.FillWeight = 88.55048F;
			this.c_nombre.HeaderText = "Nombre";
			this.c_nombre.Name = "c_nombre";
			this.c_nombre.Width = 75;
			// 
			// c_turno
			// 
			this.c_turno.FillWeight = 88.55048F;
			this.c_turno.HeaderText = "Turno";
			this.c_turno.Name = "c_turno";
			this.c_turno.Width = 65;
			// 
			// INICIO
			// 
			this.INICIO.FillWeight = 60F;
			this.INICIO.HeaderText = "Hr. Inicio";
			this.INICIO.Name = "INICIO";
			this.INICIO.Width = 50;
			// 
			// FIN
			// 
			this.FIN.FillWeight = 88.55048F;
			this.FIN.HeaderText = "Hr. Fin";
			this.FIN.Name = "FIN";
			this.FIN.Width = 50;
			// 
			// DIA
			// 
			this.DIA.FillWeight = 88.55048F;
			this.DIA.HeaderText = "DIA";
			this.DIA.Name = "DIA";
			this.DIA.Width = 55;
			// 
			// c_sentido
			// 
			this.c_sentido.FillWeight = 88.55048F;
			this.c_sentido.HeaderText = "Sentido";
			this.c_sentido.Name = "c_sentido";
			this.c_sentido.Width = 62;
			// 
			// c_km
			// 
			this.c_km.FillWeight = 60F;
			this.c_km.HeaderText = "KM";
			this.c_km.Name = "c_km";
			this.c_km.Width = 35;
			// 
			// c_Tipo
			// 
			this.c_Tipo.FillWeight = 80F;
			this.c_Tipo.HeaderText = "Tipo";
			this.c_Tipo.Name = "c_Tipo";
			this.c_Tipo.Width = 50;
			// 
			// EmpresaNRM
			// 
			this.EmpresaNRM.FillWeight = 90F;
			this.EmpresaNRM.HeaderText = "Empresa";
			this.EmpresaNRM.Name = "EmpresaNRM";
			this.EmpresaNRM.Width = 70;
			// 
			// TipoCobro
			// 
			this.TipoCobro.FillWeight = 88.55048F;
			this.TipoCobro.HeaderText = "Tipo Cobro";
			this.TipoCobro.Name = "TipoCobro";
			this.TipoCobro.Width = 66;
			// 
			// Subempresa
			// 
			this.Subempresa.HeaderText = "SubNombre";
			this.Subempresa.Name = "Subempresa";
			// 
			// MenuEliminarRuta
			// 
			this.MenuEliminarRuta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.eliminarRutaToolStripMenuItem});
			this.MenuEliminarRuta.Name = "MenuEliminarRuta";
			this.MenuEliminarRuta.Size = new System.Drawing.Size(145, 26);
			// 
			// eliminarRutaToolStripMenuItem
			// 
			this.eliminarRutaToolStripMenuItem.Name = "eliminarRutaToolStripMenuItem";
			this.eliminarRutaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.eliminarRutaToolStripMenuItem.Text = "Eliminar Ruta";
			this.eliminarRutaToolStripMenuItem.Click += new System.EventHandler(this.EliminarRutaToolStripMenuItemClick);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(733, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(599, 21);
			this.label2.TabIndex = 144;
			this.label2.Text = "Rutas Extras";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(688, 20);
			this.label3.TabIndex = 139;
			this.label3.Text = "Rutas Fijas o Normales";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormTipoRuta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1337, 705);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTipoRuta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Tipo de Ruta";
			this.Load += new System.EventHandler(this.FormTipoRutaLoad);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtRutaEXT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtRutaNRM)).EndInit();
			this.MenuEliminarRuta.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn SubNombreE;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subempresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FIN;
		private System.Windows.Forms.DataGridViewTextBoxColumn INICIO;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.Label lblPeriodo;
		private System.Windows.Forms.CheckBox cbEliminadasNRM;
		private System.Windows.Forms.ToolStripMenuItem eliminarRutaToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuEliminarRuta;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoCobro;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaNRM;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Cobro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.ComboBox cbTurnoRuta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombreRuta;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_tipo2;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_km;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_turno;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
		private System.Windows.Forms.Button btnDesignarOperador;
		public System.Windows.Forms.DataGridView dtRutaNRM;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.DataGridView dtRutaEXT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
	}
}
