/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 03/05/2013
 * Time: 08:43 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina
{
	partial class FormOperadorExterno
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperadorExterno));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pOperador = new System.Windows.Forms.Panel();
			this.dtEmpleado = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias_Op = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pDatos = new System.Windows.Forms.Panel();
			this.pExternos = new System.Windows.Forms.Panel();
			this.tableDeducciones = new System.Windows.Forms.TableLayoutPanel();
			this.dataViajesNormales = new System.Windows.Forms.DataGridView();
			this.dataApoyos = new System.Windows.Forms.DataGridView();
			this.ID_Apoyos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_ruta_apoyo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_OP_APOYO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha_Apoyos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno_apoyos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_apoyos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblApoyo = new System.Windows.Forms.Label();
			this.lblViajes = new System.Windows.Forms.Label();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.lblFechaInicio = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.btnExcel = new System.Windows.Forms.Button();
			this.ID_R = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sentido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado_Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Normales = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Km = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_Hora_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.C_HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Velada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pOperador.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtEmpleado)).BeginInit();
			this.pDatos.SuspendLayout();
			this.pExternos.SuspendLayout();
			this.tableDeducciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataViajesNormales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataApoyos)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pOperador
			// 
			this.pOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pOperador.BackColor = System.Drawing.SystemColors.Menu;
			this.pOperador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pOperador.Controls.Add(this.dtEmpleado);
			this.pOperador.Location = new System.Drawing.Point(12, 12);
			this.pOperador.Name = "pOperador";
			this.pOperador.Size = new System.Drawing.Size(180, 518);
			this.pOperador.TabIndex = 144;
			// 
			// dtEmpleado
			// 
			this.dtEmpleado.AllowUserToAddRows = false;
			this.dtEmpleado.AllowUserToResizeColumns = false;
			this.dtEmpleado.AllowUserToResizeRows = false;
			this.dtEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtEmpleado.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Alias_Op,
									this.tipo_empleado});
			this.dtEmpleado.Location = new System.Drawing.Point(14, 14);
			this.dtEmpleado.MultiSelect = false;
			this.dtEmpleado.Name = "dtEmpleado";
			this.dtEmpleado.RowHeadersVisible = false;
			this.dtEmpleado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtEmpleado.Size = new System.Drawing.Size(148, 490);
			this.dtEmpleado.TabIndex = 140;
			this.dtEmpleado.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtOperadorCellEnter);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.ID.DefaultCellStyle = dataGridViewCellStyle2;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// Alias_Op
			// 
			this.Alias_Op.DataPropertyName = "Alias_Op";
			this.Alias_Op.HeaderText = "Nick";
			this.Alias_Op.MinimumWidth = 130;
			this.Alias_Op.Name = "Alias_Op";
			this.Alias_Op.ReadOnly = true;
			this.Alias_Op.Width = 130;
			// 
			// tipo_empleado
			// 
			this.tipo_empleado.DataPropertyName = "tipo_empleado";
			this.tipo_empleado.HeaderText = "Tipo";
			this.tipo_empleado.Name = "tipo_empleado";
			this.tipo_empleado.Visible = false;
			this.tipo_empleado.Width = 56;
			// 
			// pDatos
			// 
			this.pDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pDatos.BackColor = System.Drawing.SystemColors.Menu;
			this.pDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pDatos.Controls.Add(this.pExternos);
			this.pDatos.Controls.Add(this.dtCorte);
			this.pDatos.Controls.Add(this.dtInicio);
			this.pDatos.Controls.Add(this.lblFechaCorte);
			this.pDatos.Controls.Add(this.lblFechaInicio);
			this.pDatos.Controls.Add(this.groupBox5);
			this.pDatos.Controls.Add(this.btnExcel);
			this.pDatos.Location = new System.Drawing.Point(198, 12);
			this.pDatos.Name = "pDatos";
			this.pDatos.Size = new System.Drawing.Size(810, 518);
			this.pDatos.TabIndex = 145;
			// 
			// pExternos
			// 
			this.pExternos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pExternos.AutoScroll = true;
			this.pExternos.Controls.Add(this.tableDeducciones);
			this.pExternos.Location = new System.Drawing.Point(3, 54);
			this.pExternos.Name = "pExternos";
			this.pExternos.Size = new System.Drawing.Size(800, 401);
			this.pExternos.TabIndex = 168;
			// 
			// tableDeducciones
			// 
			this.tableDeducciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tableDeducciones.AutoSize = true;
			this.tableDeducciones.BackColor = System.Drawing.Color.Transparent;
			this.tableDeducciones.ColumnCount = 1;
			this.tableDeducciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableDeducciones.Controls.Add(this.dataViajesNormales, 0, 1);
			this.tableDeducciones.Controls.Add(this.dataApoyos, 0, 3);
			this.tableDeducciones.Controls.Add(this.lblApoyo, 0, 2);
			this.tableDeducciones.Controls.Add(this.lblViajes, 0, 0);
			this.tableDeducciones.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableDeducciones.Location = new System.Drawing.Point(7, 3);
			this.tableDeducciones.Name = "tableDeducciones";
			this.tableDeducciones.RowCount = 4;
			this.tableDeducciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableDeducciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableDeducciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableDeducciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableDeducciones.Size = new System.Drawing.Size(787, 86);
			this.tableDeducciones.TabIndex = 167;
			// 
			// dataViajesNormales
			// 
			this.dataViajesNormales.AllowUserToAddRows = false;
			this.dataViajesNormales.AllowUserToResizeColumns = false;
			this.dataViajesNormales.AllowUserToResizeRows = false;
			this.dataViajesNormales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataViajesNormales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataViajesNormales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataViajesNormales.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataViajesNormales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataViajesNormales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataViajesNormales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataViajesNormales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_R,
									this.Fecha,
									this.Empresa,
									this.Ruta,
									this.Sentido,
									this.Turno,
									this.Vehiculo,
									this.Estado_Viaje,
									this.Costo,
									this.Tipo_Normales,
									this.Km,
									this.Tiempo,
									this.Tipo_Ruta,
									this.C_Hora_I,
									this.C_HoraFin,
									this.Velada});
			this.dataViajesNormales.Location = new System.Drawing.Point(3, 26);
			this.dataViajesNormales.Name = "dataViajesNormales";
			this.dataViajesNormales.RowHeadersVisible = false;
			this.dataViajesNormales.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataViajesNormales.Size = new System.Drawing.Size(781, 10);
			this.dataViajesNormales.TabIndex = 168;
			// 
			// dataApoyos
			// 
			this.dataApoyos.AllowUserToAddRows = false;
			this.dataApoyos.AllowUserToResizeRows = false;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataApoyos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dataApoyos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataApoyos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataApoyos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataApoyos.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataApoyos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataApoyos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataApoyos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataApoyos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Apoyos,
									this.ID_ruta_apoyo,
									this.ID_OP_APOYO,
									this.Fecha_Apoyos,
									this.dataGridViewTextBoxColumn22,
									this.Turno_apoyos,
									this.Tipo_apoyos,
									this.Comentarios});
			this.dataApoyos.Location = new System.Drawing.Point(3, 65);
			this.dataApoyos.Name = "dataApoyos";
			this.dataApoyos.RowHeadersVisible = false;
			this.dataApoyos.Size = new System.Drawing.Size(781, 18);
			this.dataApoyos.TabIndex = 168;
			// 
			// ID_Apoyos
			// 
			this.ID_Apoyos.HeaderText = "ID";
			this.ID_Apoyos.Name = "ID_Apoyos";
			this.ID_Apoyos.Visible = false;
			this.ID_Apoyos.Width = 22;
			// 
			// ID_ruta_apoyo
			// 
			this.ID_ruta_apoyo.HeaderText = "ID_RUTA";
			this.ID_ruta_apoyo.Name = "ID_ruta_apoyo";
			this.ID_ruta_apoyo.Visible = false;
			this.ID_ruta_apoyo.Width = 55;
			// 
			// ID_OP_APOYO
			// 
			this.ID_OP_APOYO.HeaderText = "ID_OP";
			this.ID_OP_APOYO.Name = "ID_OP_APOYO";
			this.ID_OP_APOYO.Visible = false;
			this.ID_OP_APOYO.Width = 42;
			// 
			// Fecha_Apoyos
			// 
			this.Fecha_Apoyos.HeaderText = "Fecha";
			this.Fecha_Apoyos.Name = "Fecha_Apoyos";
			this.Fecha_Apoyos.Width = 62;
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.DataPropertyName = "Ruta_Apoyo";
			this.dataGridViewTextBoxColumn22.HeaderText = "Ruta";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			this.dataGridViewTextBoxColumn22.Visible = false;
			this.dataGridViewTextBoxColumn22.Width = 54;
			// 
			// Turno_apoyos
			// 
			this.Turno_apoyos.HeaderText = "Turno";
			this.Turno_apoyos.Name = "Turno_apoyos";
			this.Turno_apoyos.Width = 60;
			// 
			// Tipo_apoyos
			// 
			this.Tipo_apoyos.HeaderText = "Tipo";
			this.Tipo_apoyos.Name = "Tipo_apoyos";
			this.Tipo_apoyos.Width = 52;
			// 
			// Comentarios
			// 
			this.Comentarios.HeaderText = "Comentarios";
			this.Comentarios.Name = "Comentarios";
			this.Comentarios.Width = 92;
			// 
			// lblApoyo
			// 
			this.lblApoyo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblApoyo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblApoyo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblApoyo.Location = new System.Drawing.Point(3, 39);
			this.lblApoyo.Name = "lblApoyo";
			this.lblApoyo.Size = new System.Drawing.Size(781, 23);
			this.lblApoyo.TabIndex = 3;
			this.lblApoyo.Text = "Apoyos";
			this.lblApoyo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblViajes
			// 
			this.lblViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblViajes.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblViajes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblViajes.Location = new System.Drawing.Point(3, 0);
			this.lblViajes.Name = "lblViajes";
			this.lblViajes.Size = new System.Drawing.Size(781, 23);
			this.lblViajes.TabIndex = 2;
			this.lblViajes.Text = "Viajes";
			this.lblViajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtCorte
			// 
			this.dtCorte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(699, 14);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(91, 20);
			this.dtCorte.TabIndex = 138;
			this.dtCorte.ValueChanged += new System.EventHandler(this.DtCorteValueChanged);
			// 
			// dtInicio
			// 
			this.dtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(522, 15);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(92, 20);
			this.dtInicio.TabIndex = 137;
			this.dtInicio.ValueChanged += new System.EventHandler(this.DtInicioValueChanged);
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(620, 16);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(100, 22);
			this.lblFechaCorte.TabIndex = 136;
			this.lblFechaCorte.Text = "Fecha Corte:";
			// 
			// lblFechaInicio
			// 
			this.lblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaInicio.Location = new System.Drawing.Point(442, 16);
			this.lblFechaInicio.Name = "lblFechaInicio";
			this.lblFechaInicio.Size = new System.Drawing.Size(95, 22);
			this.lblFechaInicio.TabIndex = 135;
			this.lblFechaInicio.Text = "Fecha Inicio:";
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.pictureBox2);
			this.groupBox5.Controls.Add(this.label24);
			this.groupBox5.Controls.Add(this.label26);
			this.groupBox5.Controls.Add(this.pictureBox4);
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(10, 6);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(176, 42);
			this.groupBox5.TabIndex = 166;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Acotaciones";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(10, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(22, 22);
			this.pictureBox2.TabIndex = 139;
			this.pictureBox2.TabStop = false;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.SystemColors.Menu;
			this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(33, 15);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(61, 22);
			this.label24.TabIndex = 142;
			this.label24.Text = "Completo";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.SystemColors.Menu;
			this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(123, 14);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(50, 22);
			this.label26.TabIndex = 146;
			this.label26.Text = "Sencillo";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox4.InitialImage = null;
			this.pictureBox4.Location = new System.Drawing.Point(98, 15);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(22, 22);
			this.pictureBox4.TabIndex = 145;
			this.pictureBox4.TabStop = false;
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExcel.BackColor = System.Drawing.Color.Transparent;
			this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
			this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(747, 461);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(46, 43);
			this.btnExcel.TabIndex = 165;
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// ID_R
			// 
			this.ID_R.DataPropertyName = "ID_R";
			this.ID_R.HeaderText = "ID";
			this.ID_R.Name = "ID_R";
			this.ID_R.ReadOnly = true;
			this.ID_R.Visible = false;
			this.ID_R.Width = 22;
			// 
			// Fecha
			// 
			this.Fecha.DataPropertyName = "Fecha";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Format = "d";
			dataGridViewCellStyle4.NullValue = null;
			this.Fecha.DefaultCellStyle = dataGridViewCellStyle4;
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			this.Fecha.Width = 62;
			// 
			// Empresa
			// 
			this.Empresa.DataPropertyName = "Empresa";
			this.Empresa.HeaderText = "Empresa";
			this.Empresa.Name = "Empresa";
			this.Empresa.ReadOnly = true;
			this.Empresa.Width = 74;
			// 
			// Ruta
			// 
			this.Ruta.DataPropertyName = "Ruta";
			this.Ruta.HeaderText = "Ruta";
			this.Ruta.Name = "Ruta";
			this.Ruta.ReadOnly = true;
			this.Ruta.Width = 54;
			// 
			// Sentido
			// 
			this.Sentido.DataPropertyName = "Sentido";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Sentido.DefaultCellStyle = dataGridViewCellStyle5;
			this.Sentido.HeaderText = "Sentido";
			this.Sentido.Name = "Sentido";
			this.Sentido.ReadOnly = true;
			this.Sentido.Width = 68;
			// 
			// Turno
			// 
			this.Turno.DataPropertyName = "Turno";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Turno.DefaultCellStyle = dataGridViewCellStyle6;
			this.Turno.HeaderText = "Turno";
			this.Turno.Name = "Turno";
			this.Turno.ReadOnly = true;
			this.Turno.Width = 60;
			// 
			// Vehiculo
			// 
			this.Vehiculo.DataPropertyName = "Vehiculo";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Vehiculo.DefaultCellStyle = dataGridViewCellStyle7;
			this.Vehiculo.HeaderText = "Vehiculo";
			this.Vehiculo.Name = "Vehiculo";
			this.Vehiculo.ReadOnly = true;
			this.Vehiculo.Width = 73;
			// 
			// Estado_Viaje
			// 
			this.Estado_Viaje.DataPropertyName = "Colum_fora";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Estado_Viaje.DefaultCellStyle = dataGridViewCellStyle8;
			this.Estado_Viaje.HeaderText = "T";
			this.Estado_Viaje.Name = "Estado_Viaje";
			this.Estado_Viaje.ReadOnly = true;
			this.Estado_Viaje.Visible = false;
			this.Estado_Viaje.Width = 38;
			// 
			// Costo
			// 
			this.Costo.DataPropertyName = "Costo";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Costo.DefaultCellStyle = dataGridViewCellStyle9;
			this.Costo.HeaderText = "$";
			this.Costo.Name = "Costo";
			this.Costo.ReadOnly = true;
			this.Costo.Width = 38;
			// 
			// Tipo_Normales
			// 
			this.Tipo_Normales.DataPropertyName = "Tipo_Normales";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			this.Tipo_Normales.DefaultCellStyle = dataGridViewCellStyle10;
			this.Tipo_Normales.HeaderText = "Tipo";
			this.Tipo_Normales.Name = "Tipo_Normales";
			this.Tipo_Normales.ReadOnly = true;
			this.Tipo_Normales.Width = 52;
			// 
			// Km
			// 
			this.Km.HeaderText = "Km";
			this.Km.Name = "Km";
			this.Km.ReadOnly = true;
			this.Km.Width = 47;
			// 
			// Tiempo
			// 
			this.Tiempo.HeaderText = "Tiempo";
			this.Tiempo.Name = "Tiempo";
			this.Tiempo.ReadOnly = true;
			this.Tiempo.Visible = false;
			this.Tiempo.Width = 66;
			// 
			// Tipo_Ruta
			// 
			this.Tipo_Ruta.HeaderText = "##";
			this.Tipo_Ruta.Name = "Tipo_Ruta";
			this.Tipo_Ruta.ReadOnly = true;
			this.Tipo_Ruta.Width = 44;
			// 
			// C_Hora_I
			// 
			this.C_Hora_I.HeaderText = "Hora Inicio";
			this.C_Hora_I.Name = "C_Hora_I";
			this.C_Hora_I.Width = 82;
			// 
			// C_HoraFin
			// 
			this.C_HoraFin.HeaderText = "Hora Fin";
			this.C_HoraFin.Name = "C_HoraFin";
			this.C_HoraFin.Width = 72;
			// 
			// Velada
			// 
			this.Velada.HeaderText = "Velada";
			this.Velada.Name = "Velada";
			this.Velada.Visible = false;
			this.Velada.Width = 65;
			// 
			// FormOperadorExterno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1020, 542);
			this.Controls.Add(this.pDatos);
			this.Controls.Add(this.pOperador);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormOperadorExterno";
			this.Text = "Transportes LAR - Operador Externos y Coordinadores";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOperadorExternoFormClosing);
			this.Load += new System.EventHandler(this.FormOperadorExternoLoad);
			this.pOperador.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtEmpleado)).EndInit();
			this.pDatos.ResumeLayout(false);
			this.pExternos.ResumeLayout(false);
			this.pExternos.PerformLayout();
			this.tableDeducciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataViajesNormales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataApoyos)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Velada;
		private System.Windows.Forms.DataGridViewTextBoxColumn C_HoraFin;
		private System.Windows.Forms.DataGridViewTextBoxColumn C_Hora_I;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Km;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Viaje;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
		private System.Windows.Forms.Panel pExternos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comentarios;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_apoyos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno_apoyos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Apoyos;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OP_APOYO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_ruta_apoyo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Apoyos;
		private System.Windows.Forms.DataGridView dataApoyos;
		private System.Windows.Forms.Label lblViajes;
		private System.Windows.Forms.Label lblApoyo;
		private System.Windows.Forms.TableLayoutPanel tableDeducciones;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Normales;
		private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sentido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_R;
		private System.Windows.Forms.DataGridView dataViajesNormales;
		private System.Windows.Forms.Label lblFechaInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.Panel pDatos;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_empleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias_Op;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dtEmpleado;
		private System.Windows.Forms.Panel pOperador;
	}
}
