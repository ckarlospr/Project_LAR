/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 10/04/2013
 * Time: 02:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Aptomedico
{
	partial class FormAptoMedico
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAptoMedico));
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnAgregarLicencia = new System.Windows.Forms.Button();
			this.dateVigencia = new System.Windows.Forms.DateTimePicker();
			this.label45 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.btnRemoverLicencia = new System.Windows.Forms.Button();
			this.dataApto = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataFaltantes = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataOperador = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnReportes = new System.Windows.Forms.Button();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ptbImagen = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnReporte = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataApto)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataFaltantes)).BeginInit();
			this.tabPage1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataOperador)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnReporte);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.btnRemoverLicencia);
			this.panel2.Controls.Add(this.dataApto);
			this.panel2.Controls.Add(this.tabControl1);
			this.panel2.Controls.Add(this.btnReportes);
			this.panel2.Controls.Add(this.txtApellidoM);
			this.panel2.Controls.Add(this.txtApellidoP);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.txtAlias);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.ptbImagen);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(795, 489);
			this.panel2.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnModificar);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNumero);
			this.groupBox1.Controls.Add(this.btnAgregarLicencia);
			this.groupBox1.Controls.Add(this.dateVigencia);
			this.groupBox1.Controls.Add(this.label45);
			this.groupBox1.Controls.Add(this.label50);
			this.groupBox1.Location = new System.Drawing.Point(559, 178);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(223, 153);
			this.groupBox1.TabIndex = 44;
			this.groupBox1.TabStop = false;
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(123, 109);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(92, 33);
			this.btnModificar.TabIndex = 44;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 23);
			this.label1.TabIndex = 39;
			this.label1.Text = "Datos de la Apto médico:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(83, 50);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(132, 20);
			this.txtNumero.TabIndex = 31;
			// 
			// btnAgregarLicencia
			// 
			this.btnAgregarLicencia.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregarLicencia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarLicencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarLicencia.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLicencia.Image")));
			this.btnAgregarLicencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarLicencia.Location = new System.Drawing.Point(9, 109);
			this.btnAgregarLicencia.Name = "btnAgregarLicencia";
			this.btnAgregarLicencia.Size = new System.Drawing.Size(92, 33);
			this.btnAgregarLicencia.TabIndex = 35;
			this.btnAgregarLicencia.Text = "Agregar";
			this.btnAgregarLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregarLicencia.UseVisualStyleBackColor = false;
			this.btnAgregarLicencia.Click += new System.EventHandler(this.BtnAgregarLicenciaClick);
			// 
			// dateVigencia
			// 
			this.dateVigencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateVigencia.Location = new System.Drawing.Point(83, 77);
			this.dateVigencia.Name = "dateVigencia";
			this.dateVigencia.Size = new System.Drawing.Size(132, 20);
			this.dateVigencia.TabIndex = 34;
			// 
			// label45
			// 
			this.label45.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label45.Location = new System.Drawing.Point(17, 52);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(56, 18);
			this.label45.TabIndex = 43;
			this.label45.Text = "Numero:";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label50
			// 
			this.label50.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label50.Location = new System.Drawing.Point(17, 79);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(57, 20);
			this.label50.TabIndex = 42;
			this.label50.Text = "Vigencia:";
			this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRemoverLicencia
			// 
			this.btnRemoverLicencia.BackColor = System.Drawing.Color.Transparent;
			this.btnRemoverLicencia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemoverLicencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoverLicencia.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverLicencia.Image")));
			this.btnRemoverLicencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemoverLicencia.Location = new System.Drawing.Point(568, 441);
			this.btnRemoverLicencia.Name = "btnRemoverLicencia";
			this.btnRemoverLicencia.Size = new System.Drawing.Size(94, 33);
			this.btnRemoverLicencia.TabIndex = 36;
			this.btnRemoverLicencia.Text = "Remover";
			this.btnRemoverLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverLicencia.UseVisualStyleBackColor = false;
			this.btnRemoverLicencia.Click += new System.EventHandler(this.BtnRemoverLicenciaClick);
			// 
			// dataApto
			// 
			this.dataApto.AllowUserToAddRows = false;
			this.dataApto.AllowUserToDeleteRows = false;
			this.dataApto.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataApto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataApto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataApto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataApto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn3,
									this.Column3,
									this.dataGridViewTextBoxColumn4});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataApto.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataApto.Location = new System.Drawing.Point(231, 178);
			this.dataApto.Name = "dataApto";
			this.dataApto.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataApto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataApto.RowHeadersVisible = false;
			this.dataApto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataApto.Size = new System.Drawing.Size(321, 296);
			this.dataApto.TabIndex = 38;
			this.dataApto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataAptoCellEnter);
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn3.HeaderText = "ID";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Visible = false;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "numero";
			this.Column3.HeaderText = "Numero";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "vigencia";
			this.dataGridViewTextBoxColumn4.HeaderText = "Vigencia";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(3, 6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(217, 479);
			this.tabControl1.TabIndex = 30;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Controls.Add(this.dataFaltantes);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(209, 453);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "AptosMedicos Faltantes";
			// 
			// dataFaltantes
			// 
			this.dataFaltantes.AllowUserToAddRows = false;
			this.dataFaltantes.AllowUserToDeleteRows = false;
			this.dataFaltantes.AllowUserToResizeColumns = false;
			this.dataFaltantes.AllowUserToResizeRows = false;
			this.dataFaltantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataFaltantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataFaltantes.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataFaltantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFaltantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataFaltantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataFaltantes.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataFaltantes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataFaltantes.Location = new System.Drawing.Point(3, 3);
			this.dataFaltantes.MultiSelect = false;
			this.dataFaltantes.Name = "dataFaltantes";
			this.dataFaltantes.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataFaltantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataFaltantes.RowHeadersVisible = false;
			this.dataFaltantes.Size = new System.Drawing.Size(203, 447);
			this.dataFaltantes.TabIndex = 11;
			this.dataFaltantes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFaltantesCellEnter);
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
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.panel4);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(209, 453);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Aptos Medicos";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Tan;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.dataOperador);
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 444);
			this.panel4.TabIndex = 24;
			// 
			// dataOperador
			// 
			this.dataOperador.AllowUserToAddRows = false;
			this.dataOperador.AllowUserToDeleteRows = false;
			this.dataOperador.AllowUserToResizeColumns = false;
			this.dataOperador.AllowUserToResizeRows = false;
			this.dataOperador.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataOperador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column5,
									this.Column1,
									this.Vigencia});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataOperador.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataOperador.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataOperador.Location = new System.Drawing.Point(0, 0);
			this.dataOperador.MultiSelect = false;
			this.dataOperador.Name = "dataOperador";
			this.dataOperador.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataOperador.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataOperador.RowHeadersVisible = false;
			this.dataOperador.Size = new System.Drawing.Size(198, 442);
			this.dataOperador.TabIndex = 7;
			this.dataOperador.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOperadorCellEnter);
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "ID";
			this.Column5.HeaderText = "ID";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Visible = false;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.DataPropertyName = "Alias";
			this.Column1.HeaderText = "Alias";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Vigencia
			// 
			this.Vigencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Vigencia.HeaderText = "Vigencia";
			this.Vigencia.Name = "Vigencia";
			this.Vigencia.ReadOnly = true;
			// 
			// btnReportes
			// 
			this.btnReportes.BackColor = System.Drawing.Color.Transparent;
			this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReportes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
			this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReportes.Location = new System.Drawing.Point(668, 441);
			this.btnReportes.Name = "btnReportes";
			this.btnReportes.Size = new System.Drawing.Size(109, 33);
			this.btnReportes.TabIndex = 5;
			this.btnReportes.Text = "Apto Médico";
			this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReportes.UseVisualStyleBackColor = false;
			this.btnReportes.Click += new System.EventHandler(this.BtnReportesClick);
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoM.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoM.Location = new System.Drawing.Point(451, 114);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(326, 20);
			this.txtApellidoM.TabIndex = 4;
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtApellidoP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoP.Location = new System.Drawing.Point(451, 87);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(326, 20);
			this.txtApellidoP.TabIndex = 3;
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(451, 62);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(326, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtAlias
			// 
			this.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(451, 36);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(326, 20);
			this.txtAlias.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(359, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 14);
			this.label4.TabIndex = 29;
			this.label4.Text = "Apellido paterno:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(357, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 14);
			this.label3.TabIndex = 28;
			this.label3.Text = "Apellido materno:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(387, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 14);
			this.label5.TabIndex = 27;
			this.label5.Text = "Nombre(s):";
			// 
			// ptbImagen
			// 
			this.ptbImagen.BackColor = System.Drawing.SystemColors.Menu;
			this.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ptbImagen.Location = new System.Drawing.Point(226, 36);
			this.ptbImagen.Name = "ptbImagen";
			this.ptbImagen.Size = new System.Drawing.Size(97, 103);
			this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbImagen.TabIndex = 26;
			this.ptbImagen.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(413, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 14);
			this.label6.TabIndex = 25;
			this.label6.Text = "Alias:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(229, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(553, 18);
			this.label7.TabIndex = 21;
			this.label7.Text = "Apto médico del operador:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(226, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(556, 18);
			this.label2.TabIndex = 18;
			this.label2.Text = "Datos del operador:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnReporte
			// 
			this.btnReporte.BackColor = System.Drawing.Color.Transparent;
			this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReporte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
			this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReporte.Location = new System.Drawing.Point(609, 337);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(132, 41);
			this.btnReporte.TabIndex = 45;
			this.btnReporte.Text = "Aptos Medicos";
			this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReporte.UseVisualStyleBackColor = false;
			this.btnReporte.Click += new System.EventHandler(this.BtnReporteClick);
			// 
			// FormAptoMedico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 491);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAptoMedico";
			this.Text = "Transportes LAR - Apto médico";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAptoMedicoFormClosing);
			this.Load += new System.EventHandler(this.FormAptoMedicoLoad);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataApto)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataFaltantes)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataOperador)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.DataGridView dataApto;
		public System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		public System.Windows.Forms.Button btnAgregarLicencia;
		public System.Windows.Forms.Button btnRemoverLicencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateVigencia;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label45;
		public System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox ptbImagen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.Button btnReportes;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dataFaltantes;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		public System.Windows.Forms.DataGridView dataOperador;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
