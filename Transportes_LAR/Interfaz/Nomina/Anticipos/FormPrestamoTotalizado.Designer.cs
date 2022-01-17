/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 02/08/2013
 * Time: 02:23 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	partial class FormPrestamoTotalizado
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamoTotalizado));
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataPrestamos1 = new System.Windows.Forms.DataGridView();
			this.ID_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataPrestamos2 = new System.Windows.Forms.DataGridView();
			this.ID_Si = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblAlias = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataAnticipos = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAnticipos = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.dataDetallePrestamos = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label32 = new System.Windows.Forms.Label();
			this.txtDescNominal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtImporteNo = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtImporteSi = new System.Windows.Forms.TextBox();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPrestamos1)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPrestamos2)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataAnticipos)).BeginInit();
			this.groupBox19.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataDetallePrestamos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Controls.Add(this.dataPrestamos1);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(12, 59);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(266, 385);
			this.panel4.TabIndex = 143;
			// 
			// dataPrestamos1
			// 
			this.dataPrestamos1.AllowUserToAddRows = false;
			this.dataPrestamos1.AllowUserToResizeColumns = false;
			this.dataPrestamos1.AllowUserToResizeRows = false;
			this.dataPrestamos1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataPrestamos1.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataPrestamos1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataPrestamos1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataPrestamos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPrestamos1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_No,
									this.dataGridViewTextBoxColumn31,
									this.dataGridViewTextBoxColumn34,
									this.tipo_prestamo,
									this.dataGridViewTextBoxColumn40});
			this.dataPrestamos1.Location = new System.Drawing.Point(7, 73);
			this.dataPrestamos1.Name = "dataPrestamos1";
			this.dataPrestamos1.RowHeadersVisible = false;
			this.dataPrestamos1.Size = new System.Drawing.Size(247, 302);
			this.dataPrestamos1.TabIndex = 192;
			// 
			// ID_No
			// 
			this.ID_No.HeaderText = "ID";
			this.ID_No.Name = "ID_No";
			this.ID_No.ReadOnly = true;
			this.ID_No.Visible = false;
			this.ID_No.Width = 50;
			// 
			// dataGridViewTextBoxColumn31
			// 
			this.dataGridViewTextBoxColumn31.DataPropertyName = "ID_descuento";
			this.dataGridViewTextBoxColumn31.HeaderText = "ID_Desc";
			this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn31.ReadOnly = true;
			this.dataGridViewTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn31.Visible = false;
			this.dataGridViewTextBoxColumn31.Width = 25;
			// 
			// dataGridViewTextBoxColumn34
			// 
			this.dataGridViewTextBoxColumn34.DataPropertyName = "Fecha";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn34.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn34.HeaderText = "Fecha";
			this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
			this.dataGridViewTextBoxColumn34.ReadOnly = true;
			this.dataGridViewTextBoxColumn34.Width = 70;
			// 
			// tipo_prestamo
			// 
			this.tipo_prestamo.HeaderText = "Pago";
			this.tipo_prestamo.Name = "tipo_prestamo";
			this.tipo_prestamo.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn40
			// 
			this.dataGridViewTextBoxColumn40.DataPropertyName = "Destino";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn40.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn40.HeaderText = "Desc.";
			this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
			this.dataGridViewTextBoxColumn40.ReadOnly = true;
			this.dataGridViewTextBoxColumn40.Width = 50;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 50);
			this.label2.TabIndex = 152;
			this.label2.Text = "Pagos de los prestamos no efectuados";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Controls.Add(this.dataPrestamos2);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(284, 59);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(274, 385);
			this.panel3.TabIndex = 148;
			// 
			// dataPrestamos2
			// 
			this.dataPrestamos2.AllowUserToAddRows = false;
			this.dataPrestamos2.AllowUserToResizeColumns = false;
			this.dataPrestamos2.AllowUserToResizeRows = false;
			this.dataPrestamos2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataPrestamos2.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataPrestamos2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataPrestamos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataPrestamos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPrestamos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_Si,
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn6});
			this.dataPrestamos2.Location = new System.Drawing.Point(10, 73);
			this.dataPrestamos2.Name = "dataPrestamos2";
			this.dataPrestamos2.RowHeadersVisible = false;
			this.dataPrestamos2.Size = new System.Drawing.Size(252, 302);
			this.dataPrestamos2.TabIndex = 193;
			// 
			// ID_Si
			// 
			this.ID_Si.HeaderText = "ID";
			this.ID_Si.Name = "ID_Si";
			this.ID_Si.ReadOnly = true;
			this.ID_Si.Visible = false;
			this.ID_Si.Width = 50;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_descuento";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID_Desc";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 25;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 70;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Pago";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Destino";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn6.HeaderText = "Desc.";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 50;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(234, 45);
			this.label3.TabIndex = 153;
			this.label3.Text = "Pagos de los prestamos  ya efectuados";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-93, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(993, 48);
			this.label1.TabIndex = 149;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(-149, 458);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(1107, 60);
			this.label4.TabIndex = 150;
			this.label4.Text = "label4";
			// 
			// lblAlias
			// 
			this.lblAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblAlias.BackColor = System.Drawing.Color.White;
			this.lblAlias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAlias.Location = new System.Drawing.Point(225, 4);
			this.lblAlias.Name = "lblAlias";
			this.lblAlias.Size = new System.Drawing.Size(373, 37);
			this.lblAlias.TabIndex = 151;
			this.lblAlias.Text = "Alias";
			this.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.dataAnticipos);
			this.panel1.Controls.Add(this.btnAnticipos);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.groupBox19);
			this.panel1.Controls.Add(this.label32);
			this.panel1.Controls.Add(this.txtDescNominal);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtImporteNo);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.txtTotal);
			this.panel1.Controls.Add(this.label23);
			this.panel1.Controls.Add(this.txtImporteSi);
			this.panel1.Location = new System.Drawing.Point(564, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(227, 385);
			this.panel1.TabIndex = 194;
			// 
			// dataAnticipos
			// 
			this.dataAnticipos.AllowUserToAddRows = false;
			this.dataAnticipos.AllowUserToResizeColumns = false;
			this.dataAnticipos.AllowUserToResizeRows = false;
			this.dataAnticipos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dataAnticipos.BackgroundColor = System.Drawing.SystemColors.Menu;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataAnticipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataAnticipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataAnticipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn17,
									this.dataGridViewTextBoxColumn18,
									this.dataGridViewTextBoxColumn21,
									this.dataGridViewTextBoxColumn22,
									this.dataGridViewTextBoxColumn23});
			this.dataAnticipos.Location = new System.Drawing.Point(177, 27);
			this.dataAnticipos.Name = "dataAnticipos";
			this.dataAnticipos.RowHeadersVisible = false;
			this.dataAnticipos.Size = new System.Drawing.Size(10, 10);
			this.dataAnticipos.TabIndex = 196;
			this.dataAnticipos.Visible = false;
			// 
			// dataGridViewTextBoxColumn17
			// 
			this.dataGridViewTextBoxColumn17.DataPropertyName = "ID_RE";
			this.dataGridViewTextBoxColumn17.HeaderText = "ID";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn17.ReadOnly = true;
			this.dataGridViewTextBoxColumn17.Visible = false;
			this.dataGridViewTextBoxColumn17.Width = 25;
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.DataPropertyName = "ID_descuento";
			this.dataGridViewTextBoxColumn18.HeaderText = "ID_Desc";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.ReadOnly = true;
			this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn18.Visible = false;
			this.dataGridViewTextBoxColumn18.Width = 25;
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.DataPropertyName = "Fecha";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTextBoxColumn21.HeaderText = "Fecha";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn21.ReadOnly = true;
			this.dataGridViewTextBoxColumn21.Width = 75;
			// 
			// dataGridViewTextBoxColumn22
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTextBoxColumn22.HeaderText = "Nomclatura";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.DataPropertyName = "Destino";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Format = "N2";
			dataGridViewCellStyle10.NullValue = null;
			this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewTextBoxColumn23.HeaderText = "Descuento";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			// 
			// btnAnticipos
			// 
			this.btnAnticipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAnticipos.BackColor = System.Drawing.Color.Transparent;
			this.btnAnticipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAnticipos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnticipos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnticipos.Image = ((System.Drawing.Image)(resources.GetObject("btnAnticipos.Image")));
			this.btnAnticipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAnticipos.Location = new System.Drawing.Point(75, 174);
			this.btnAnticipos.Name = "btnAnticipos";
			this.btnAnticipos.Size = new System.Drawing.Size(93, 30);
			this.btnAnticipos.TabIndex = 195;
			this.btnAnticipos.Text = "Aceptar";
			this.btnAnticipos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAnticipos.UseVisualStyleBackColor = false;
			this.btnAnticipos.Click += new System.EventHandler(this.BtnAnticiposClick);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 24);
			this.label5.TabIndex = 194;
			this.label5.Text = "Totales";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox19
			// 
			this.groupBox19.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox19.BackColor = System.Drawing.Color.Transparent;
			this.groupBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox19.Controls.Add(this.dataDetallePrestamos);
			this.groupBox19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox19.Location = new System.Drawing.Point(16, 210);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Size = new System.Drawing.Size(197, 154);
			this.groupBox19.TabIndex = 183;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "Detalles";
			// 
			// dataDetallePrestamos
			// 
			this.dataDetallePrestamos.AllowUserToAddRows = false;
			this.dataDetallePrestamos.AllowUserToResizeColumns = false;
			this.dataDetallePrestamos.AllowUserToResizeRows = false;
			this.dataDetallePrestamos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dataDetallePrestamos.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataDetallePrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataDetallePrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dataDetallePrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataDetallePrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn48,
									this.dataGridViewTextBoxColumn49});
			this.dataDetallePrestamos.Location = new System.Drawing.Point(29, 19);
			this.dataDetallePrestamos.Name = "dataDetallePrestamos";
			this.dataDetallePrestamos.RowHeadersVisible = false;
			this.dataDetallePrestamos.Size = new System.Drawing.Size(142, 119);
			this.dataDetallePrestamos.TabIndex = 188;
			// 
			// dataGridViewTextBoxColumn48
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn48.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridViewTextBoxColumn48.HeaderText = "No.";
			this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
			this.dataGridViewTextBoxColumn48.ReadOnly = true;
			this.dataGridViewTextBoxColumn48.Width = 30;
			// 
			// dataGridViewTextBoxColumn49
			// 
			this.dataGridViewTextBoxColumn49.DataPropertyName = "Destino";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.Format = "N2";
			dataGridViewCellStyle13.NullValue = null;
			this.dataGridViewTextBoxColumn49.DefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewTextBoxColumn49.HeaderText = "Descuento";
			this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
			this.dataGridViewTextBoxColumn49.ReadOnly = true;
			this.dataGridViewTextBoxColumn49.Width = 80;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.White;
			this.label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(19, 147);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(121, 18);
			this.label32.TabIndex = 182;
			this.label32.Text = "Descuento nominal";
			// 
			// txtDescNominal
			// 
			this.txtDescNominal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescNominal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescNominal.Location = new System.Drawing.Point(146, 145);
			this.txtDescNominal.Name = "txtDescNominal";
			this.txtDescNominal.Size = new System.Drawing.Size(67, 20);
			this.txtDescNominal.TabIndex = 181;
			this.txtDescNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtDescNominal.TextChanged += new System.EventHandler(this.TxtDescNominalTextChanged);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(134, 18);
			this.label6.TabIndex = 180;
			this.label6.Text = "Importe no efectuado";
			// 
			// txtImporteNo
			// 
			this.txtImporteNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtImporteNo.Enabled = false;
			this.txtImporteNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporteNo.Location = new System.Drawing.Point(146, 68);
			this.txtImporteNo.Name = "txtImporteNo";
			this.txtImporteNo.Size = new System.Drawing.Size(66, 20);
			this.txtImporteNo.TabIndex = 179;
			this.txtImporteNo.Text = "0.0";
			this.txtImporteNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(99, 122);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(33, 18);
			this.label13.TabIndex = 178;
			this.label13.Text = "Total";
			// 
			// txtTotal
			// 
			this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(146, 120);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(66, 20);
			this.txtTotal.TabIndex = 177;
			this.txtTotal.Text = "0.00";
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.White;
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(8, 97);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(134, 22);
			this.label23.TabIndex = 176;
			this.label23.Text = "Importe ya efectuado";
			// 
			// txtImporteSi
			// 
			this.txtImporteSi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtImporteSi.Enabled = false;
			this.txtImporteSi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporteSi.Location = new System.Drawing.Point(146, 94);
			this.txtImporteSi.Name = "txtImporteSi";
			this.txtImporteSi.Size = new System.Drawing.Size(66, 20);
			this.txtImporteSi.TabIndex = 175;
			this.txtImporteSi.Text = "0.0";
			this.txtImporteSi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormPrestamoTotalizado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(803, 517);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblAlias);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPrestamoTotalizado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Préstamo Totalizado";
			this.Load += new System.EventHandler(this.FormPrestamoTotalizadoLoad);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataPrestamos1)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataPrestamos2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataAnticipos)).EndInit();
			this.groupBox19.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataDetallePrestamos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private System.Windows.Forms.DataGridView dataAnticipos;
		private System.Windows.Forms.Button btnAnticipos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
		private System.Windows.Forms.DataGridView dataDetallePrestamos;
		private System.Windows.Forms.GroupBox groupBox19;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtImporteSi;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtImporteNo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDescNominal;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_Si;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_No;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_prestamo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
		private System.Windows.Forms.DataGridView dataPrestamos1;
		private System.Windows.Forms.Label lblAlias;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dataPrestamos2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
	}
}
