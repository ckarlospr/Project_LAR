/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 22/01/2013
 * Time: 12:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Incapacidad
{
	partial class FormIncapacidades
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncapacidades));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rSubsecuente = new System.Windows.Forms.RadioButton();
			this.rInicial = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rRiesgo = new System.Windows.Forms.RadioButton();
			this.rMaternidad = new System.Windows.Forms.RadioButton();
			this.rGeneral = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblFechaInicio = new System.Windows.Forms.Label();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardarEditar = new System.Windows.Forms.Button();
			this.dataIncapacidad = new System.Windows.Forms.DataGridView();
			this.ID_INCAPACIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_incapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Motivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.pPrincipal = new System.Windows.Forms.Panel();
			this.groupBox21 = new System.Windows.Forms.GroupBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txtNombreAnticipos = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataIncapacidad)).BeginInit();
			this.pPrincipal.SuspendLayout();
			this.groupBox21.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, -6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(869, 62);
			this.label1.TabIndex = 142;
			this.label1.Text = "Incapacidades";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 494);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1102, 62);
			this.label2.TabIndex = 143;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(242, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(57, 50);
			this.pictureBox1.TabIndex = 145;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(563, 1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(57, 50);
			this.pictureBox2.TabIndex = 146;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(9, 161);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(333, 324);
			this.panel1.TabIndex = 164;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.rSubsecuente);
			this.groupBox2.Controls.Add(this.rInicial);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(13, 113);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(310, 90);
			this.groupBox2.TabIndex = 144;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tipo de Incapacidad";
			// 
			// rSubsecuente
			// 
			this.rSubsecuente.Location = new System.Drawing.Point(115, 49);
			this.rSubsecuente.Name = "rSubsecuente";
			this.rSubsecuente.Size = new System.Drawing.Size(114, 24);
			this.rSubsecuente.TabIndex = 4;
			this.rSubsecuente.Text = "Subsecuente";
			this.rSubsecuente.UseVisualStyleBackColor = true;
			this.rSubsecuente.Enter += new System.EventHandler(this.RSubsecuenteEnter);
			// 
			// rInicial
			// 
			this.rInicial.Location = new System.Drawing.Point(115, 19);
			this.rInicial.Name = "rInicial";
			this.rInicial.Size = new System.Drawing.Size(144, 24);
			this.rInicial.TabIndex = 3;
			this.rInicial.Text = "Inicial";
			this.rInicial.UseVisualStyleBackColor = true;
			this.rInicial.Enter += new System.EventHandler(this.RInicialEnter);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.Controls.Add(this.rRiesgo);
			this.groupBox3.Controls.Add(this.rMaternidad);
			this.groupBox3.Controls.Add(this.rGeneral);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(13, 212);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(310, 90);
			this.groupBox3.TabIndex = 144;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Motivo de la Incapacidad";
			// 
			// rRiesgo
			// 
			this.rRiesgo.Location = new System.Drawing.Point(13, 49);
			this.rRiesgo.Name = "rRiesgo";
			this.rRiesgo.Size = new System.Drawing.Size(190, 24);
			this.rRiesgo.TabIndex = 2;
			this.rRiesgo.Text = "Probable Riesgo de Contagio";
			this.rRiesgo.UseVisualStyleBackColor = true;
			this.rRiesgo.Enter += new System.EventHandler(this.RRiesgoEnter);
			// 
			// rMaternidad
			// 
			this.rMaternidad.Location = new System.Drawing.Point(206, 19);
			this.rMaternidad.Name = "rMaternidad";
			this.rMaternidad.Size = new System.Drawing.Size(90, 24);
			this.rMaternidad.TabIndex = 1;
			this.rMaternidad.Text = "Maternidad";
			this.rMaternidad.UseVisualStyleBackColor = true;
			this.rMaternidad.Enter += new System.EventHandler(this.RMaternidadEnter);
			// 
			// rGeneral
			// 
			this.rGeneral.Location = new System.Drawing.Point(13, 19);
			this.rGeneral.Name = "rGeneral";
			this.rGeneral.Size = new System.Drawing.Size(144, 24);
			this.rGeneral.TabIndex = 0;
			this.rGeneral.Text = "Enfermedad General";
			this.rGeneral.UseVisualStyleBackColor = true;
			this.rGeneral.Enter += new System.EventHandler(this.RGeneralEnter);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.lblFechaInicio);
			this.groupBox1.Controls.Add(this.dtCorte);
			this.groupBox1.Controls.Add(this.lblFechaCorte);
			this.groupBox1.Controls.Add(this.dtInicio);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 90);
			this.groupBox1.TabIndex = 143;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fechas";
			// 
			// lblFechaInicio
			// 
			this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaInicio.Location = new System.Drawing.Point(22, 25);
			this.lblFechaInicio.Name = "lblFechaInicio";
			this.lblFechaInicio.Size = new System.Drawing.Size(95, 22);
			this.lblFechaInicio.TabIndex = 139;
			this.lblFechaInicio.Text = "Fecha Inicio:";
			// 
			// dtCorte
			// 
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(171, 50);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(125, 20);
			this.dtCorte.TabIndex = 142;
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(171, 25);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(88, 22);
			this.lblFechaCorte.TabIndex = 140;
			this.lblFechaCorte.Text = "Fecha Corte:";
			// 
			// dtInicio
			// 
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(22, 50);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(111, 20);
			this.dtInicio.TabIndex = 141;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(815, 454);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(36, 31);
			this.btnCancelar.TabIndex = 166;
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnGuardarEditar
			// 
			this.btnGuardarEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardarEditar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardarEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEditar.BackgroundImage")));
			this.btnGuardarEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardarEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarEditar.Location = new System.Drawing.Point(771, 454);
			this.btnGuardarEditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnGuardarEditar.Name = "btnGuardarEditar";
			this.btnGuardarEditar.Size = new System.Drawing.Size(39, 31);
			this.btnGuardarEditar.TabIndex = 165;
			this.btnGuardarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarEditar.UseVisualStyleBackColor = false;
			this.btnGuardarEditar.Click += new System.EventHandler(this.BtnGuardarEditarClick);
			// 
			// dataIncapacidad
			// 
			this.dataIncapacidad.AllowUserToAddRows = false;
			this.dataIncapacidad.AllowUserToResizeRows = false;
			this.dataIncapacidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataIncapacidad.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataIncapacidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataIncapacidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataIncapacidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataIncapacidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_INCAPACIDAD,
									this.Alias,
									this.Tipo_incapacidad,
									this.Fecha_Inicio,
									this.Fecha_Fin,
									this.Motivos,
									this.Eliminar});
			this.dataIncapacidad.Location = new System.Drawing.Point(359, 116);
			this.dataIncapacidad.Name = "dataIncapacidad";
			this.dataIncapacidad.RowHeadersVisible = false;
			this.dataIncapacidad.Size = new System.Drawing.Size(492, 332);
			this.dataIncapacidad.TabIndex = 167;
			this.dataIncapacidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataIncapacidadCellContentClick);
			// 
			// ID_INCAPACIDAD
			// 
			this.ID_INCAPACIDAD.DataPropertyName = "ID_INCAPACIDAD";
			this.ID_INCAPACIDAD.HeaderText = "ID_INCAPACIDAD";
			this.ID_INCAPACIDAD.Name = "ID_INCAPACIDAD";
			this.ID_INCAPACIDAD.Visible = false;
			// 
			// Alias
			// 
			this.Alias.DataPropertyName = "Alias";
			this.Alias.FillWeight = 113.9086F;
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			// 
			// Tipo_incapacidad
			// 
			this.Tipo_incapacidad.DataPropertyName = "Tipo_incapacidad";
			this.Tipo_incapacidad.FillWeight = 113.9086F;
			this.Tipo_incapacidad.HeaderText = "Tipo de incapacidad";
			this.Tipo_incapacidad.Name = "Tipo_incapacidad";
			// 
			// Fecha_Inicio
			// 
			this.Fecha_Inicio.DataPropertyName = "Fecha_Inicio";
			this.Fecha_Inicio.FillWeight = 113.9086F;
			this.Fecha_Inicio.HeaderText = "Fecha Inicio";
			this.Fecha_Inicio.Name = "Fecha_Inicio";
			// 
			// Fecha_Fin
			// 
			this.Fecha_Fin.DataPropertyName = "Fecha_Fin";
			this.Fecha_Fin.FillWeight = 113.9086F;
			this.Fecha_Fin.HeaderText = "Fecha Final";
			this.Fecha_Fin.Name = "Fecha_Fin";
			// 
			// Motivos
			// 
			this.Motivos.DataPropertyName = "Motivos";
			this.Motivos.FillWeight = 113.9086F;
			this.Motivos.HeaderText = "Motivo";
			this.Motivos.Name = "Motivos";
			// 
			// Eliminar
			// 
			this.Eliminar.FillWeight = 30.45685F;
			this.Eliminar.HeaderText = "X";
			this.Eliminar.Name = "Eliminar";
			// 
			// pPrincipal
			// 
			this.pPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pPrincipal.BackColor = System.Drawing.Color.MidnightBlue;
			this.pPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pPrincipal.BackgroundImage")));
			this.pPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pPrincipal.Controls.Add(this.groupBox21);
			this.pPrincipal.Location = new System.Drawing.Point(8, 69);
			this.pPrincipal.Name = "pPrincipal";
			this.pPrincipal.Size = new System.Drawing.Size(335, 89);
			this.pPrincipal.TabIndex = 168;
			// 
			// groupBox21
			// 
			this.groupBox21.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox21.BackColor = System.Drawing.Color.Transparent;
			this.groupBox21.Controls.Add(this.label28);
			this.groupBox21.Controls.Add(this.txtNombreAnticipos);
			this.groupBox21.Controls.Add(this.label22);
			this.groupBox21.Controls.Add(this.txtAlias);
			this.groupBox21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox21.Location = new System.Drawing.Point(11, 1);
			this.groupBox21.Name = "groupBox21";
			this.groupBox21.Size = new System.Drawing.Size(313, 75);
			this.groupBox21.TabIndex = 190;
			this.groupBox21.TabStop = false;
			this.groupBox21.Text = "Datos del Operador";
			// 
			// label28
			// 
			this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label28.BackColor = System.Drawing.Color.White;
			this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(5, 44);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(113, 22);
			this.label28.TabIndex = 187;
			this.label28.Text = "Nombre Completo:";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombreAnticipos
			// 
			this.txtNombreAnticipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombreAnticipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombreAnticipos.Enabled = false;
			this.txtNombreAnticipos.Location = new System.Drawing.Point(118, 44);
			this.txtNombreAnticipos.Name = "txtNombreAnticipos";
			this.txtNombreAnticipos.Size = new System.Drawing.Size(189, 20);
			this.txtNombreAnticipos.TabIndex = 1;
			// 
			// label22
			// 
			this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label22.BackColor = System.Drawing.Color.White;
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(79, 17);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(39, 22);
			this.label22.TabIndex = 185;
			this.label22.Text = "Nick:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAlias.Location = new System.Drawing.Point(118, 17);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(189, 20);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(359, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(492, 33);
			this.label3.TabIndex = 169;
			this.label3.Text = "Incapacidades Activas";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormIncapacidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(865, 555);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pPrincipal);
			this.Controls.Add(this.dataIncapacidad);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardarEditar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormIncapacidades";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Incapacidades";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIncapacidadesFormClosing);
			this.Load += new System.EventHandler(this.FormIncapacidadesLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataIncapacidad)).EndInit();
			this.pPrincipal.ResumeLayout(false);
			this.groupBox21.ResumeLayout(false);
			this.groupBox21.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtNombreAnticipos;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.GroupBox groupBox21;
		private System.Windows.Forms.Panel pPrincipal;
		private System.Windows.Forms.DataGridView dataIncapacidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Motivos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_incapacidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_INCAPACIDAD;
		private System.Windows.Forms.Button btnGuardarEditar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.RadioButton rInicial;
		private System.Windows.Forms.RadioButton rSubsecuente;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.Label lblFechaInicio;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rGeneral;
		private System.Windows.Forms.RadioButton rMaternidad;
		private System.Windows.Forms.RadioButton rRiesgo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
