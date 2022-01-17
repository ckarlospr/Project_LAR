/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 05/09/2012
 * Time: 11:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormEmpresasOperaciones
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpresasOperaciones));
			this.dtgEmpresas = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONFIRMACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.idE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idOperadorE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idVehiculoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vehiculoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idOpS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idOperadorS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idVehiculoS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vehiculoS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horaCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.conf2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblSepara1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdGuardaCupos = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdInformacion = new System.Windows.Forms.Button();
			this.cmdAgregar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lblNombreEmp = new System.Windows.Forms.Label();
			this.lblIDO = new System.Windows.Forms.Label();
			this.lblG = new System.Windows.Forms.Label();
			this.lblIDG = new System.Windows.Forms.Label();
			this.lblGuardia = new System.Windows.Forms.Label();
			this.cmdGuardia = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dtgEmpresas)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtgEmpresas
			// 
			this.dtgEmpresas.AllowUserToResizeColumns = false;
			this.dtgEmpresas.AllowUserToResizeRows = false;
			this.dtgEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtgEmpresas.BackgroundColor = System.Drawing.Color.White;
			this.dtgEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtgEmpresas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.SubNombre,
									this.ID,
									this.Alias,
									this.HoraInicio,
									this.CONFIRMACION,
									this.Nombre,
									this.Column6,
									this.Column10,
									this.Column2,
									this.Column9,
									this.Column8,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column7,
									this.Column11,
									this.idE,
									this.idOperadorE,
									this.idVehiculoE,
									this.vehiculoE,
									this.idOpS,
									this.idOperadorS,
									this.idVehiculoS,
									this.vehiculoS,
									this.horaCambio,
									this.conf2,
									this.X});
			this.dtgEmpresas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dtgEmpresas.Location = new System.Drawing.Point(3, 35);
			this.dtgEmpresas.Name = "dtgEmpresas";
			this.dtgEmpresas.RowHeadersWidth = 30;
			this.dtgEmpresas.RowTemplate.Height = 25;
			this.dtgEmpresas.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dtgEmpresas.Size = new System.Drawing.Size(1076, 25);
			this.dtgEmpresas.TabIndex = 0;
			this.dtgEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgEmpresasCellClick);
			this.dtgEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgEmpresasCellContentClick);
			this.dtgEmpresas.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgEmpresasCellLeave);
			this.dtgEmpresas.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgEmpresasCellMouseEnter);
			this.dtgEmpresas.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgEmpresasCellMouseUp);
			this.dtgEmpresas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DtgEmpresasEditingControlShowing);
			this.dtgEmpresas.DoubleClick += new System.EventHandler(this.DtgEmpresasDoubleClick);
			this.dtgEmpresas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtgEmpresasKeyDown);
			this.dtgEmpresas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtgEmpresasKeyPress);
			this.dtgEmpresas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtgEmpresasKeyUp);
			this.dtgEmpresas.MouseEnter += new System.EventHandler(this.FormEmpresasOperacionesMouseEnter);
			// 
			// Column1
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column1.HeaderText = "US";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column1.ToolTipText = "Cantidad de usuarios";
			this.Column1.Width = 25;
			// 
			// SubNombre
			// 
			this.SubNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.SubNombre.DataPropertyName = "SubNombre";
			this.SubNombre.HeaderText = "Empresa";
			this.SubNombre.Name = "SubNombre";
			this.SubNombre.ReadOnly = true;
			this.SubNombre.Visible = false;
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID_R";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			this.ID.Width = 57;
			// 
			// Alias
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			this.Alias.DefaultCellStyle = dataGridViewCellStyle3;
			this.Alias.HeaderText = "Operador";
			this.Alias.Name = "Alias";
			// 
			// HoraInicio
			// 
			this.HoraInicio.DataPropertyName = "HoraInicio";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			this.HoraInicio.DefaultCellStyle = dataGridViewCellStyle4;
			this.HoraInicio.HeaderText = "Hora";
			this.HoraInicio.Name = "HoraInicio";
			this.HoraInicio.ReadOnly = true;
			this.HoraInicio.Width = 50;
			// 
			// CONFIRMACION
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.Format = "t";
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CONFIRMACION.DefaultCellStyle = dataGridViewCellStyle5;
			this.CONFIRMACION.HeaderText = "Conf";
			this.CONFIRMACION.Name = "CONFIRMACION";
			this.CONFIRMACION.ReadOnly = true;
			this.CONFIRMACION.Width = 50;
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "Nombre";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nombre.DefaultCellStyle = dataGridViewCellStyle6;
			this.Nombre.HeaderText = "Ruta";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 150;
			// 
			// Column6
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.Format = "t";
			this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
			this.Column6.HeaderText = "Llega";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.ToolTipText = "Hora de llegada";
			this.Column6.Width = 50;
			// 
			// Column10
			// 
			this.Column10.FalseValue = "0";
			this.Column10.HeaderText = "A";
			this.Column10.Name = "Column10";
			this.Column10.TrueValue = "1";
			this.Column10.Width = 30;
			// 
			// Column2
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column2.DefaultCellStyle = dataGridViewCellStyle8;
			this.Column2.HeaderText = "US";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column2.ToolTipText = "Cantidad de usuarios";
			this.Column2.Width = 25;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "ID_R";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Visible = false;
			this.Column9.Width = 57;
			// 
			// Column8
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column8.DefaultCellStyle = dataGridViewCellStyle9;
			this.Column8.HeaderText = "Operador";
			this.Column8.Name = "Column8";
			// 
			// Column3
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.Format = "t";
			dataGridViewCellStyle10.NullValue = null;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle10;
			this.Column3.HeaderText = "Hora";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 50;
			// 
			// Column4
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.Format = "t";
			dataGridViewCellStyle11.NullValue = null;
			this.Column4.DefaultCellStyle = dataGridViewCellStyle11;
			this.Column4.HeaderText = "Conf";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 50;
			// 
			// Column5
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column5.DefaultCellStyle = dataGridViewCellStyle12;
			this.Column5.HeaderText = "Ruta";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 150;
			// 
			// Column7
			// 
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle13.Format = "t";
			dataGridViewCellStyle13.NullValue = null;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle13;
			this.Column7.HeaderText = "Llega";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.ToolTipText = "Hora de llegada";
			this.Column7.Visible = false;
			this.Column7.Width = 50;
			// 
			// Column11
			// 
			this.Column11.FalseValue = "0";
			this.Column11.HeaderText = "B";
			this.Column11.Name = "Column11";
			this.Column11.TrueValue = "1";
			this.Column11.Width = 30;
			// 
			// idE
			// 
			this.idE.HeaderText = "idOsE";
			this.idE.Name = "idE";
			this.idE.ReadOnly = true;
			this.idE.Visible = false;
			// 
			// idOperadorE
			// 
			this.idOperadorE.HeaderText = "idOperadorE";
			this.idOperadorE.Name = "idOperadorE";
			this.idOperadorE.ReadOnly = true;
			this.idOperadorE.Visible = false;
			// 
			// idVehiculoE
			// 
			this.idVehiculoE.HeaderText = "idVehiculoE";
			this.idVehiculoE.Name = "idVehiculoE";
			this.idVehiculoE.ReadOnly = true;
			this.idVehiculoE.Visible = false;
			// 
			// vehiculoE
			// 
			this.vehiculoE.HeaderText = "vehiculoE";
			this.vehiculoE.Name = "vehiculoE";
			this.vehiculoE.ReadOnly = true;
			this.vehiculoE.Visible = false;
			// 
			// idOpS
			// 
			this.idOpS.HeaderText = "idOpS";
			this.idOpS.Name = "idOpS";
			this.idOpS.ReadOnly = true;
			this.idOpS.Visible = false;
			// 
			// idOperadorS
			// 
			this.idOperadorS.HeaderText = "idOperadorS";
			this.idOperadorS.Name = "idOperadorS";
			this.idOperadorS.ReadOnly = true;
			this.idOperadorS.Visible = false;
			// 
			// idVehiculoS
			// 
			this.idVehiculoS.HeaderText = "idVehiculoS";
			this.idVehiculoS.Name = "idVehiculoS";
			this.idVehiculoS.ReadOnly = true;
			this.idVehiculoS.Visible = false;
			// 
			// vehiculoS
			// 
			this.vehiculoS.HeaderText = "vehiculoS";
			this.vehiculoS.Name = "vehiculoS";
			this.vehiculoS.ReadOnly = true;
			this.vehiculoS.Visible = false;
			// 
			// horaCambio
			// 
			this.horaCambio.HeaderText = "horaCambio";
			this.horaCambio.Name = "horaCambio";
			this.horaCambio.Visible = false;
			// 
			// conf2
			// 
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.conf2.DefaultCellStyle = dataGridViewCellStyle14;
			this.conf2.HeaderText = "MSJ";
			this.conf2.Name = "conf2";
			this.conf2.Width = 50;
			// 
			// X
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.X.DefaultCellStyle = dataGridViewCellStyle15;
			this.X.HeaderText = "SubEmpresa";
			this.X.Name = "X";
			this.X.ReadOnly = true;
			this.X.Width = 125;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
			this.panel1.Controls.Add(this.lblSepara1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cmdGuardaCupos);
			this.panel1.Controls.Add(this.cmdDelete);
			this.panel1.Controls.Add(this.cmdInformacion);
			this.panel1.Controls.Add(this.cmdAgregar);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.dtgEmpresas);
			this.panel1.Controls.Add(this.lblNombreEmp);
			this.panel1.Controls.Add(this.lblIDO);
			this.panel1.Controls.Add(this.lblG);
			this.panel1.Controls.Add(this.lblIDG);
			this.panel1.Controls.Add(this.lblGuardia);
			this.panel1.Controls.Add(this.cmdGuardia);
			this.panel1.Location = new System.Drawing.Point(4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1083, 222);
			this.panel1.TabIndex = 1;
			// 
			// lblSepara1
			// 
			this.lblSepara1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSepara1.Location = new System.Drawing.Point(998, 5);
			this.lblSepara1.Name = "lblSepara1";
			this.lblSepara1.Size = new System.Drawing.Size(2, 23);
			this.lblSepara1.TabIndex = 15;
			this.lblSepara1.Visible = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(1077, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(2, 23);
			this.label1.TabIndex = 14;
			// 
			// cmdGuardaCupos
			// 
			this.cmdGuardaCupos.BackColor = System.Drawing.Color.Cyan;
			this.cmdGuardaCupos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGuardaCupos.BackgroundImage")));
			this.cmdGuardaCupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdGuardaCupos.Location = new System.Drawing.Point(8, 5);
			this.cmdGuardaCupos.Name = "cmdGuardaCupos";
			this.cmdGuardaCupos.Size = new System.Drawing.Size(34, 23);
			this.cmdGuardaCupos.TabIndex = 13;
			this.toolTip1.SetToolTip(this.cmdGuardaCupos, "Guardado de cupos");
			this.cmdGuardaCupos.UseVisualStyleBackColor = false;
			this.cmdGuardaCupos.Click += new System.EventHandler(this.CmdGuardaCuposClick);
			// 
			// cmdDelete
			// 
			this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.Image")));
			this.cmdDelete.Location = new System.Drawing.Point(1009, 5);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(27, 23);
			this.cmdDelete.TabIndex = 5;
			this.toolTip1.SetToolTip(this.cmdDelete, "Eliminar ruta");
			this.cmdDelete.UseVisualStyleBackColor = true;
			this.cmdDelete.Click += new System.EventHandler(this.CmdDeleteClick);
			// 
			// cmdInformacion
			// 
			this.cmdInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdInformacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdInformacion.BackgroundImage")));
			this.cmdInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdInformacion.Location = new System.Drawing.Point(963, 5);
			this.cmdInformacion.Name = "cmdInformacion";
			this.cmdInformacion.Size = new System.Drawing.Size(27, 23);
			this.cmdInformacion.TabIndex = 6;
			this.toolTip1.SetToolTip(this.cmdInformacion, "Interfaz completa de viajes especiales");
			this.cmdInformacion.UseVisualStyleBackColor = true;
			this.cmdInformacion.Visible = false;
			this.cmdInformacion.Click += new System.EventHandler(this.CmdInformacionClick);
			// 
			// cmdAgregar
			// 
			this.cmdAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
			this.cmdAgregar.Location = new System.Drawing.Point(1042, 5);
			this.cmdAgregar.Name = "cmdAgregar";
			this.cmdAgregar.Size = new System.Drawing.Size(27, 23);
			this.cmdAgregar.TabIndex = 4;
			this.toolTip1.SetToolTip(this.cmdAgregar, "Agregar ruta");
			this.cmdAgregar.UseVisualStyleBackColor = true;
			this.cmdAgregar.Click += new System.EventHandler(this.CmdAgregarClick);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(930, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(27, 23);
			this.button2.TabIndex = 3;
			this.toolTip1.SetToolTip(this.button2, "Minimizar");
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// lblNombreEmp
			// 
			this.lblNombreEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblNombreEmp.BackColor = System.Drawing.SystemColors.HotTrack;
			this.lblNombreEmp.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreEmp.ForeColor = System.Drawing.Color.Yellow;
			this.lblNombreEmp.Location = new System.Drawing.Point(3, 3);
			this.lblNombreEmp.Name = "lblNombreEmp";
			this.lblNombreEmp.Size = new System.Drawing.Size(1071, 27);
			this.lblNombreEmp.TabIndex = 1;
			this.lblNombreEmp.Text = "Empresa";
			this.lblNombreEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblIDO
			// 
			this.lblIDO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIDO.Location = new System.Drawing.Point(465, 7);
			this.lblIDO.Name = "lblIDO";
			this.lblIDO.Size = new System.Drawing.Size(75, 20);
			this.lblIDO.TabIndex = 12;
			this.lblIDO.Text = "IDO";
			this.lblIDO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblIDO.Visible = false;
			// 
			// lblG
			// 
			this.lblG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblG.Location = new System.Drawing.Point(121, 6);
			this.lblG.Name = "lblG";
			this.lblG.Size = new System.Drawing.Size(75, 20);
			this.lblG.TabIndex = 8;
			this.lblG.Text = "Guardia:";
			this.lblG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblG.Visible = false;
			// 
			// lblIDG
			// 
			this.lblIDG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIDG.Location = new System.Drawing.Point(384, 7);
			this.lblIDG.Name = "lblIDG";
			this.lblIDG.Size = new System.Drawing.Size(75, 20);
			this.lblIDG.TabIndex = 11;
			this.lblIDG.Text = "IDG";
			this.lblIDG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblIDG.Visible = false;
			// 
			// lblGuardia
			// 
			this.lblGuardia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGuardia.Location = new System.Drawing.Point(202, 6);
			this.lblGuardia.Name = "lblGuardia";
			this.lblGuardia.Size = new System.Drawing.Size(136, 20);
			this.lblGuardia.TabIndex = 9;
			this.lblGuardia.Text = "Operador";
			this.lblGuardia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGuardia.Visible = false;
			this.lblGuardia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblGuardiaMouseUp);
			// 
			// cmdGuardia
			// 
			this.cmdGuardia.Enabled = false;
			this.cmdGuardia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdGuardia.ForeColor = System.Drawing.Color.Maroon;
			this.cmdGuardia.Location = new System.Drawing.Point(44, 5);
			this.cmdGuardia.Name = "cmdGuardia";
			this.cmdGuardia.Size = new System.Drawing.Size(71, 23);
			this.cmdGuardia.TabIndex = 10;
			this.cmdGuardia.Text = "Guardia";
			this.cmdGuardia.UseVisualStyleBackColor = true;
			this.cmdGuardia.Click += new System.EventHandler(this.CmdGuardiaClick);
			// 
			// FormEmpresasOperaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PapayaWhip;
			this.ClientSize = new System.Drawing.Size(1087, 232);
			this.Controls.Add(this.panel1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormEmpresasOperaciones";
			this.Text = "FormEmpresas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmpresasOperacionesFormClosing);
			this.Load += new System.EventHandler(this.FormEmpresasOperacionesLoad);
			this.MouseEnter += new System.EventHandler(this.FormEmpresasOperacionesMouseEnter);
			((System.ComponentModel.ISupportInitialize)(this.dtgEmpresas)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn X;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSepara1;
		private System.Windows.Forms.Button cmdGuardaCupos;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
		public System.Windows.Forms.Label lblIDO;
		public System.Windows.Forms.Label lblIDG;
		public System.Windows.Forms.Label lblG;
		public System.Windows.Forms.Label lblGuardia;
		public System.Windows.Forms.Button cmdGuardia;
		public System.Windows.Forms.Button cmdInformacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn conf2;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaCambio;
		private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoS;
		private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoS;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOperadorS;
		private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoE;
		private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoE;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOperadorE;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOpS;
		private System.Windows.Forms.DataGridViewTextBoxColumn idE;
		public System.Windows.Forms.Label lblNombreEmp;
		public System.Windows.Forms.Button cmdDelete;
		public System.Windows.Forms.Button cmdAgregar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONFIRMACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dtgEmpresas;
	}
}
