/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 26/09/2012
 * Time: 10:40 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormOperadores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperadores));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pOperadorExterno = new System.Windows.Forms.Panel();
			this.pOperadorCam = new System.Windows.Forms.Panel();
			this.pOperadorInt = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpHoy = new System.Windows.Forms.TabPage();
			this.pHoy = new System.Windows.Forms.Panel();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.dgHoy = new System.Windows.Forms.DataGridView();
			this.ID_MSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpTodos = new System.Windows.Forms.TabPage();
			this.pTodos = new System.Windows.Forms.Panel();
			this.cmdDeleteTodos = new System.Windows.Forms.Button();
			this.dgTodos = new System.Windows.Forms.DataGridView();
			this.IDMSJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.tcOperadores = new System.Windows.Forms.TabControl();
			this.tpTurno1 = new System.Windows.Forms.TabPage();
			this.cmdExportaExcel = new System.Windows.Forms.Button();
			this.tpTurno2 = new System.Windows.Forms.TabPage();
			this.dgAlias = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.pOperadorCam2 = new System.Windows.Forms.Panel();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.pOperadorExterno2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.pOperadorInt2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpHoy.SuspendLayout();
			this.pHoy.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgHoy)).BeginInit();
			this.tpTodos.SuspendLayout();
			this.pTodos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgTodos)).BeginInit();
			this.tcOperadores.SuspendLayout();
			this.tpTurno1.SuspendLayout();
			this.tpTurno2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAlias)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// pOperadorExterno
			// 
			this.pOperadorExterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOperadorExterno.AutoScroll = true;
			this.pOperadorExterno.BackColor = System.Drawing.SystemColors.Control;
			this.pOperadorExterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperadorExterno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperadorExterno.Location = new System.Drawing.Point(6, 19);
			this.pOperadorExterno.Name = "pOperadorExterno";
			this.pOperadorExterno.Size = new System.Drawing.Size(746, 80);
			this.pOperadorExterno.TabIndex = 39;
			// 
			// pOperadorCam
			// 
			this.pOperadorCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOperadorCam.AutoScroll = true;
			this.pOperadorCam.BackColor = System.Drawing.SystemColors.Control;
			this.pOperadorCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperadorCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperadorCam.Location = new System.Drawing.Point(-4, 15);
			this.pOperadorCam.Name = "pOperadorCam";
			this.pOperadorCam.Size = new System.Drawing.Size(755, 172);
			this.pOperadorCam.TabIndex = 37;
			// 
			// pOperadorInt
			// 
			this.pOperadorInt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOperadorInt.AutoScroll = true;
			this.pOperadorInt.BackColor = System.Drawing.SystemColors.Control;
			this.pOperadorInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperadorInt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperadorInt.Location = new System.Drawing.Point(-1, 17);
			this.pOperadorInt.Name = "pOperadorInt";
			this.pOperadorInt.Size = new System.Drawing.Size(750, 472);
			this.pOperadorInt.TabIndex = 36;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pOperadorCam);
			this.groupBox1.Location = new System.Drawing.Point(3, 512);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(751, 167);
			this.groupBox1.TabIndex = 42;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pOperadorExterno);
			this.groupBox2.Location = new System.Drawing.Point(2, 694);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(752, 85);
			this.groupBox2.TabIndex = 43;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pOperadorInt);
			this.groupBox3.Location = new System.Drawing.Point(2, 23);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(749, 473);
			this.groupBox3.TabIndex = 44;
			this.groupBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 493);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 19);
			this.label1.TabIndex = 45;
			this.label1.Text = "Camionetas";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 46;
			this.label2.Text = "Camiones";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 674);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 47;
			this.label3.Text = "Externos";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpHoy);
			this.tabControl1.Controls.Add(this.tpTodos);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(3, 783);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(748, 135);
			this.tabControl1.TabIndex = 51;
			// 
			// tpHoy
			// 
			this.tpHoy.Controls.Add(this.pHoy);
			this.tpHoy.Location = new System.Drawing.Point(4, 22);
			this.tpHoy.Name = "tpHoy";
			this.tpHoy.Padding = new System.Windows.Forms.Padding(3);
			this.tpHoy.Size = new System.Drawing.Size(740, 109);
			this.tpHoy.TabIndex = 1;
			this.tpHoy.Text = "Hoy";
			this.tpHoy.UseVisualStyleBackColor = true;
			// 
			// pHoy
			// 
			this.pHoy.Controls.Add(this.cmdEliminar);
			this.pHoy.Controls.Add(this.cmdAgregar);
			this.pHoy.Controls.Add(this.dgHoy);
			this.pHoy.Location = new System.Drawing.Point(0, 0);
			this.pHoy.Name = "pHoy";
			this.pHoy.Size = new System.Drawing.Size(737, 136);
			this.pHoy.TabIndex = 0;
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.BackgroundImage")));
			this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdEliminar.Location = new System.Drawing.Point(691, 59);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(31, 28);
			this.cmdEliminar.TabIndex = 2;
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.BackgroundImage")));
			this.cmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAgregar.Location = new System.Drawing.Point(691, 3);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(31, 28);
			this.cmdAgregar.TabIndex = 1;
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// dgHoy
			// 
			this.dgHoy.AllowUserToAddRows = false;
			this.dgHoy.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgHoy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_MSJ,
									this.usuario,
									this.hora,
									this.mensaje});
			this.dgHoy.Location = new System.Drawing.Point(0, 0);
			this.dgHoy.Name = "dgHoy";
			this.dgHoy.RowHeadersVisible = false;
			this.dgHoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgHoy.Size = new System.Drawing.Size(685, 121);
			this.dgHoy.TabIndex = 0;
			// 
			// ID_MSJ
			// 
			this.ID_MSJ.HeaderText = "ID";
			this.ID_MSJ.Name = "ID_MSJ";
			this.ID_MSJ.ReadOnly = true;
			this.ID_MSJ.Visible = false;
			// 
			// usuario
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usuario.DefaultCellStyle = dataGridViewCellStyle2;
			this.usuario.HeaderText = "Usuario";
			this.usuario.Name = "usuario";
			this.usuario.ReadOnly = true;
			// 
			// hora
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hora.DefaultCellStyle = dataGridViewCellStyle3;
			this.hora.HeaderText = "Hora";
			this.hora.Name = "hora";
			this.hora.ReadOnly = true;
			// 
			// mensaje
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mensaje.DefaultCellStyle = dataGridViewCellStyle4;
			this.mensaje.HeaderText = "Mensaje";
			this.mensaje.Name = "mensaje";
			this.mensaje.ReadOnly = true;
			this.mensaje.Width = 450;
			// 
			// tpTodos
			// 
			this.tpTodos.Controls.Add(this.pTodos);
			this.tpTodos.Location = new System.Drawing.Point(4, 22);
			this.tpTodos.Name = "tpTodos";
			this.tpTodos.Padding = new System.Windows.Forms.Padding(3);
			this.tpTodos.Size = new System.Drawing.Size(740, 124);
			this.tpTodos.TabIndex = 0;
			this.tpTodos.Text = "Todos";
			this.tpTodos.UseVisualStyleBackColor = true;
			// 
			// pTodos
			// 
			this.pTodos.Controls.Add(this.cmdDeleteTodos);
			this.pTodos.Controls.Add(this.dgTodos);
			this.pTodos.Location = new System.Drawing.Point(0, 0);
			this.pTodos.Name = "pTodos";
			this.pTodos.Size = new System.Drawing.Size(740, 130);
			this.pTodos.TabIndex = 1;
			// 
			// cmdDeleteTodos
			// 
			this.cmdDeleteTodos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDeleteTodos.BackgroundImage")));
			this.cmdDeleteTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdDeleteTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDeleteTodos.Location = new System.Drawing.Point(644, 93);
			this.cmdDeleteTodos.Name = "cmdDeleteTodos";
			this.cmdDeleteTodos.Size = new System.Drawing.Size(31, 28);
			this.cmdDeleteTodos.TabIndex = 5;
			this.cmdDeleteTodos.UseVisualStyleBackColor = true;
			// 
			// dgTodos
			// 
			this.dgTodos.AllowUserToAddRows = false;
			this.dgTodos.BackgroundColor = System.Drawing.Color.White;
			this.dgTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.IDMSJ,
									this.dataGridViewTextBoxColumn1,
									this.dia,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3});
			this.dgTodos.GridColor = System.Drawing.Color.White;
			this.dgTodos.Location = new System.Drawing.Point(0, 0);
			this.dgTodos.Name = "dgTodos";
			this.dgTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgTodos.Size = new System.Drawing.Size(638, 127);
			this.dgTodos.TabIndex = 3;
			// 
			// IDMSJ
			// 
			this.IDMSJ.HeaderText = "ID";
			this.IDMSJ.Name = "IDMSJ";
			this.IDMSJ.ReadOnly = true;
			this.IDMSJ.Visible = false;
			this.IDMSJ.Width = 60;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dia
			// 
			this.dia.HeaderText = "Fecha";
			this.dia.Name = "dia";
			this.dia.ReadOnly = true;
			this.dia.Width = 80;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Hora";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 60;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Mensaje";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 400;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardar.Location = new System.Drawing.Point(332, -1);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(61, 23);
			this.cmdGuardar.TabIndex = 52;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// tcOperadores
			// 
			this.tcOperadores.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tcOperadores.Controls.Add(this.tpTurno1);
			this.tcOperadores.Controls.Add(this.tpTurno2);
			this.tcOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcOperadores.Location = new System.Drawing.Point(-4, 1);
			this.tcOperadores.Multiline = true;
			this.tcOperadores.Name = "tcOperadores";
			this.tcOperadores.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tcOperadores.SelectedIndex = 0;
			this.tcOperadores.Size = new System.Drawing.Size(781, 933);
			this.tcOperadores.TabIndex = 53;
			// 
			// tpTurno1
			// 
			this.tpTurno1.Controls.Add(this.cmdExportaExcel);
			this.tpTurno1.Controls.Add(this.label2);
			this.tpTurno1.Controls.Add(this.cmdGuardar);
			this.tpTurno1.Controls.Add(this.groupBox1);
			this.tpTurno1.Controls.Add(this.tabControl1);
			this.tpTurno1.Controls.Add(this.groupBox2);
			this.tpTurno1.Controls.Add(this.label3);
			this.tpTurno1.Controls.Add(this.groupBox3);
			this.tpTurno1.Controls.Add(this.label1);
			this.tpTurno1.Location = new System.Drawing.Point(23, 4);
			this.tpTurno1.Name = "tpTurno1";
			this.tpTurno1.Padding = new System.Windows.Forms.Padding(3);
			this.tpTurno1.Size = new System.Drawing.Size(754, 925);
			this.tpTurno1.TabIndex = 0;
			this.tpTurno1.Text = "tabPage1";
			this.tpTurno1.UseVisualStyleBackColor = true;
			// 
			// cmdExportaExcel
			// 
			this.cmdExportaExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdExportaExcel.Image = ((System.Drawing.Image)(resources.GetObject("cmdExportaExcel.Image")));
			this.cmdExportaExcel.Location = new System.Drawing.Point(705, -2);
			this.cmdExportaExcel.Name = "cmdExportaExcel";
			this.cmdExportaExcel.Size = new System.Drawing.Size(39, 29);
			this.cmdExportaExcel.TabIndex = 53;
			this.cmdExportaExcel.UseVisualStyleBackColor = true;
			this.cmdExportaExcel.Click += new System.EventHandler(this.CmdExportaExcelClick);
			// 
			// tpTurno2
			// 
			this.tpTurno2.Controls.Add(this.dgAlias);
			this.tpTurno2.Controls.Add(this.label4);
			this.tpTurno2.Controls.Add(this.groupBox4);
			this.tpTurno2.Controls.Add(this.groupBox5);
			this.tpTurno2.Controls.Add(this.label5);
			this.tpTurno2.Controls.Add(this.groupBox6);
			this.tpTurno2.Controls.Add(this.label6);
			this.tpTurno2.Location = new System.Drawing.Point(23, 4);
			this.tpTurno2.Name = "tpTurno2";
			this.tpTurno2.Padding = new System.Windows.Forms.Padding(3);
			this.tpTurno2.Size = new System.Drawing.Size(754, 925);
			this.tpTurno2.TabIndex = 1;
			this.tpTurno2.Text = "tabPage2";
			this.tpTurno2.UseVisualStyleBackColor = true;
			// 
			// dgAlias
			// 
			this.dgAlias.AllowUserToAddRows = false;
			this.dgAlias.AllowUserToResizeRows = false;
			this.dgAlias.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgAlias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgAlias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAlias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Alias});
			this.dgAlias.Location = new System.Drawing.Point(8, 767);
			this.dgAlias.Name = "dgAlias";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgAlias.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgAlias.RowHeadersVisible = false;
			this.dgAlias.Size = new System.Drawing.Size(193, 150);
			this.dgAlias.TabIndex = 54;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID_O";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Alias
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alias.DefaultCellStyle = dataGridViewCellStyle6;
			this.Alias.HeaderText = "ALIAS";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			this.Alias.Width = 150;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 52;
			this.label4.Text = "Camiones";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.pOperadorCam2);
			this.groupBox4.Location = new System.Drawing.Point(-1, 512);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(726, 167);
			this.groupBox4.TabIndex = 48;
			this.groupBox4.TabStop = false;
			// 
			// pOperadorCam2
			// 
			this.pOperadorCam2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOperadorCam2.AutoScroll = true;
			this.pOperadorCam2.BackColor = System.Drawing.SystemColors.Control;
			this.pOperadorCam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperadorCam2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperadorCam2.Location = new System.Drawing.Point(3, 15);
			this.pOperadorCam2.Name = "pOperadorCam2";
			this.pOperadorCam2.Size = new System.Drawing.Size(718, 172);
			this.pOperadorCam2.TabIndex = 37;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.pOperadorExterno2);
			this.groupBox5.Location = new System.Drawing.Point(3, 698);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(722, 63);
			this.groupBox5.TabIndex = 49;
			this.groupBox5.TabStop = false;
			// 
			// pOperadorExterno2
			// 
			this.pOperadorExterno2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOperadorExterno2.AutoScroll = true;
			this.pOperadorExterno2.BackColor = System.Drawing.SystemColors.Control;
			this.pOperadorExterno2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperadorExterno2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperadorExterno2.Location = new System.Drawing.Point(5, 19);
			this.pOperadorExterno2.Name = "pOperadorExterno2";
			this.pOperadorExterno2.Size = new System.Drawing.Size(710, 58);
			this.pOperadorExterno2.TabIndex = 39;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 681);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 53;
			this.label5.Text = "Externos";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.pOperadorInt2);
			this.groupBox6.Location = new System.Drawing.Point(-1, 20);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(726, 473);
			this.groupBox6.TabIndex = 50;
			this.groupBox6.TabStop = false;
			// 
			// pOperadorInt2
			// 
			this.pOperadorInt2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pOperadorInt2.AutoScroll = true;
			this.pOperadorInt2.BackColor = System.Drawing.SystemColors.Control;
			this.pOperadorInt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperadorInt2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperadorInt2.Location = new System.Drawing.Point(3, 17);
			this.pOperadorInt2.Name = "pOperadorInt2";
			this.pOperadorInt2.Size = new System.Drawing.Size(716, 472);
			this.pOperadorInt2.TabIndex = 36;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(5, 495);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 51;
			this.label6.Text = "Camionetas";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormOperadores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(776, 935);
			this.ControlBox = false;
			this.Controls.Add(this.tcOperadores);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(1132, 0);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormOperadores";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Operadores";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOperadoresFormClosing);
			this.Load += new System.EventHandler(this.FormOperadoresLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tpHoy.ResumeLayout(false);
			this.pHoy.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgHoy)).EndInit();
			this.tpTodos.ResumeLayout(false);
			this.pTodos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgTodos)).EndInit();
			this.tcOperadores.ResumeLayout(false);
			this.tpTurno1.ResumeLayout(false);
			this.tpTurno2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgAlias)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdExportaExcel;
		private System.Windows.Forms.TabControl tcOperadores;
		private System.Windows.Forms.TabPage tpTurno1;
		private System.Windows.Forms.TabPage tpTurno2;
		private System.Windows.Forms.DataGridView dgAlias;
		public System.Windows.Forms.Panel pOperadorCam2;
		public System.Windows.Forms.Panel pOperadorExterno2;
		public System.Windows.Forms.Panel pOperadorInt2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn dia;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDMSJ;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_MSJ;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dgTodos;
		private System.Windows.Forms.Button cmdDeleteTodos;
		private System.Windows.Forms.Panel pTodos;
		private System.Windows.Forms.TabPage tpTodos;
		private System.Windows.Forms.DataGridViewTextBoxColumn mensaje;
		private System.Windows.Forms.DataGridViewTextBoxColumn hora;
		private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
		private System.Windows.Forms.DataGridView dgHoy;
		private System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.Button cmdEliminar;
		private System.Windows.Forms.Panel pHoy;
		private System.Windows.Forms.TabPage tpHoy;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Panel pOperadorExterno;
		public System.Windows.Forms.Panel pOperadorCam;
		public System.Windows.Forms.Panel pOperadorInt;
	}
}
