/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 22/07/2012
 * Time: 21:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Monitoreo
{
	partial class FormMonitoreoContrato
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonitoreoContrato));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gbDatosOP = new System.Windows.Forms.GroupBox();
			this.cmbTipo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnHistorial = new System.Windows.Forms.Button();
			this.btnGenerarContrato = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataFaltante = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataVencimiento = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_empleado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.gbDatosOP.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFaltante)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataVencimiento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.gbDatosOP);
			this.panel2.Controls.Add(this.btnAceptar);
			this.panel2.Controls.Add(this.btnHistorial);
			this.panel2.Controls.Add(this.btnGenerarContrato);
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Controls.Add(this.ptbImagen);
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 65);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(639, 406);
			this.panel2.TabIndex = 5;
			// 
			// gbDatosOP
			// 
			this.gbDatosOP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbDatosOP.BackgroundImage")));
			this.gbDatosOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gbDatosOP.Controls.Add(this.cmbTipo);
			this.gbDatosOP.Controls.Add(this.label6);
			this.gbDatosOP.Controls.Add(this.label3);
			this.gbDatosOP.Controls.Add(this.label7);
			this.gbDatosOP.Controls.Add(this.label5);
			this.gbDatosOP.Controls.Add(this.label4);
			this.gbDatosOP.Controls.Add(this.txtAlias);
			this.gbDatosOP.Controls.Add(this.txtNombre);
			this.gbDatosOP.Controls.Add(this.txtApellidoP);
			this.gbDatosOP.Controls.Add(this.txtApellidoM);
			this.gbDatosOP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDatosOP.ForeColor = System.Drawing.Color.Black;
			this.gbDatosOP.Location = new System.Drawing.Point(273, 183);
			this.gbDatosOP.Name = "gbDatosOP";
			this.gbDatosOP.Size = new System.Drawing.Size(302, 172);
			this.gbDatosOP.TabIndex = 57;
			this.gbDatosOP.TabStop = false;
			this.gbDatosOP.Text = "Datos del Operador";
			// 
			// cmbTipo
			// 
			this.cmbTipo.Enabled = false;
			this.cmbTipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo.Location = new System.Drawing.Point(107, 134);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(181, 20);
			this.cmbTipo.TabIndex = 56;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(64, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 14);
			this.label6.TabIndex = 45;
			this.label6.Text = "Alias:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 14);
			this.label3.TabIndex = 48;
			this.label3.Text = "Apellido materno:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 139);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 18);
			this.label7.TabIndex = 55;
			this.label7.Text = "Tipo de Contrato:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(37, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 14);
			this.label5.TabIndex = 47;
			this.label5.Text = "Nombre(s):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 14);
			this.label4.TabIndex = 49;
			this.label4.Text = "Apellido paterno:";
			// 
			// txtAlias
			// 
			this.txtAlias.Enabled = false;
			this.txtAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(107, 29);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(181, 20);
			this.txtAlias.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(108, 56);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(181, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Enabled = false;
			this.txtApellidoP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoP.Location = new System.Drawing.Point(107, 82);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(181, 20);
			this.txtApellidoP.TabIndex = 3;
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Enabled = false;
			this.txtApellidoM.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoM.Location = new System.Drawing.Point(108, 108);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(181, 20);
			this.txtApellidoM.TabIndex = 4;
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(226, 369);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(78, 25);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// btnHistorial
			// 
			this.btnHistorial.BackColor = System.Drawing.Color.Transparent;
			this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHistorial.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
			this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHistorial.Location = new System.Drawing.Point(447, 368);
			this.btnHistorial.Name = "btnHistorial";
			this.btnHistorial.Size = new System.Drawing.Size(182, 25);
			this.btnHistorial.TabIndex = 9;
			this.btnHistorial.Text = "Ver historial de contratos";
			this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnHistorial.UseVisualStyleBackColor = false;
			this.btnHistorial.Click += new System.EventHandler(this.BtnHistorialClick);
			// 
			// btnGenerarContrato
			// 
			this.btnGenerarContrato.BackColor = System.Drawing.Color.Transparent;
			this.btnGenerarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGenerarContrato.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarContrato.Image")));
			this.btnGenerarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGenerarContrato.Location = new System.Drawing.Point(310, 368);
			this.btnGenerarContrato.Name = "btnGenerarContrato";
			this.btnGenerarContrato.Size = new System.Drawing.Size(131, 25);
			this.btnGenerarContrato.TabIndex = 8;
			this.btnGenerarContrato.Text = "Generar contrato";
			this.btnGenerarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGenerarContrato.UseVisualStyleBackColor = false;
			this.btnGenerarContrato.Click += new System.EventHandler(this.BtnGenerarContratoClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(217, 396);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.dataFaltante);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(209, 370);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Contratos faltantes";
			// 
			// dataFaltante
			// 
			this.dataFaltante.AllowUserToAddRows = false;
			this.dataFaltante.AllowUserToDeleteRows = false;
			this.dataFaltante.AllowUserToResizeColumns = false;
			this.dataFaltante.AllowUserToResizeRows = false;
			this.dataFaltante.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataFaltante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFaltante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataFaltante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFaltante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.tipo_empleado});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataFaltante.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataFaltante.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataFaltante.Location = new System.Drawing.Point(3, 3);
			this.dataFaltante.MultiSelect = false;
			this.dataFaltante.Name = "dataFaltante";
			this.dataFaltante.ReadOnly = true;
			this.dataFaltante.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.dataFaltante.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataFaltante.Size = new System.Drawing.Size(203, 364);
			this.dataFaltante.TabIndex = 10;
			this.dataFaltante.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFaltanteCellEnter);
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn3.FillWeight = 50F;
			this.dataGridViewTextBoxColumn3.HeaderText = "ID";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn3.Visible = false;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "alias";
			this.dataGridViewTextBoxColumn4.HeaderText = "Operador - alias";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn4.Width = 172;
			// 
			// tipo_empleado
			// 
			this.tipo_empleado.DataPropertyName = "tipo_empleado";
			this.tipo_empleado.HeaderText = "Tipo";
			this.tipo_empleado.Name = "tipo_empleado";
			this.tipo_empleado.ReadOnly = true;
			this.tipo_empleado.Visible = false;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Controls.Add(this.dataVencimiento);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(209, 370);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Contratos por vencer";
			// 
			// dataVencimiento
			// 
			this.dataVencimiento.AllowUserToAddRows = false;
			this.dataVencimiento.AllowUserToDeleteRows = false;
			this.dataVencimiento.AllowUserToResizeColumns = false;
			this.dataVencimiento.AllowUserToResizeRows = false;
			this.dataVencimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataVencimiento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataVencimiento.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataVencimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataVencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataVencimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.tipo_empleado2,
									this.Fecha_Vencimiento});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataVencimiento.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataVencimiento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataVencimiento.Location = new System.Drawing.Point(3, 3);
			this.dataVencimiento.MultiSelect = false;
			this.dataVencimiento.Name = "dataVencimiento";
			this.dataVencimiento.ReadOnly = true;
			this.dataVencimiento.RowHeadersVisible = false;
			this.dataVencimiento.Size = new System.Drawing.Size(203, 364);
			this.dataVencimiento.TabIndex = 11;
			this.dataVencimiento.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVencimientoCellEnter);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.FillWeight = 50F;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Alias";
			this.dataGridViewTextBoxColumn2.HeaderText = "Alias";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// tipo_empleado2
			// 
			this.tipo_empleado2.DataPropertyName = "tipo_empleado";
			this.tipo_empleado2.HeaderText = "Tipo";
			this.tipo_empleado2.Name = "tipo_empleado2";
			this.tipo_empleado2.ReadOnly = true;
			this.tipo_empleado2.Visible = false;
			// 
			// Fecha_Vencimiento
			// 
			this.Fecha_Vencimiento.DataPropertyName = "fecha_vencimiento";
			this.Fecha_Vencimiento.HeaderText = "Fecha_Vencimiento";
			this.Fecha_Vencimiento.Name = "Fecha_Vencimiento";
			this.Fecha_Vencimiento.ReadOnly = true;
			// 
			// ptbImagen
			// 
			this.ptbImagen.BackColor = System.Drawing.SystemColors.Menu;
			this.ptbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ptbImagen.Location = new System.Drawing.Point(337, 5);
			this.ptbImagen.Name = "ptbImagen";
			this.ptbImagen.Size = new System.Drawing.Size(172, 172);
			this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbImagen.TabIndex = 46;
			this.ptbImagen.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(639, 65);
			this.panel1.TabIndex = 4;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(573, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(61, 55);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(404, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contratos faltantes y vencidos de los operadores:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormMonitoreoContrato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(638, 507);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMonitoreoContrato";
			this.Text = "Transportes LAR - Monitoreo de Contrato";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMonitoreoContratoFormClosing);
			this.Load += new System.EventHandler(this.FormMonitoreoContratoLoad);
			this.panel2.ResumeLayout(false);
			this.gbDatosOP.ResumeLayout(false);
			this.gbDatosOP.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataFaltante)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataVencimiento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Vencimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_empleado2;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_empleado;
		private System.Windows.Forms.TextBox cmbTipo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox gbDatosOP;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnGenerarContrato;
		private System.Windows.Forms.Button btnHistorial;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dataVencimiento;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		public System.Windows.Forms.DataGridView dataFaltante;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}
