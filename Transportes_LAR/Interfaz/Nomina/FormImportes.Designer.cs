/*
 * Created by SharpDevelop.
 * User: Xavi_Ochoa
 * Date: 20/11/2013
 * Time: 02:40 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina
{
	partial class FormImportes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportes));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabViajes = new System.Windows.Forms.TabControl();
			this.tabValores = new System.Windows.Forms.TabPage();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.dataImpuestos = new System.Windows.Forms.DataGridView();
			this.ID_OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblImporte = new System.Windows.Forms.Label();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataValorImporte = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabViajes.SuspendLayout();
			this.tabValores.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataImpuestos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataValorImporte)).BeginInit();
			this.SuspendLayout();
			// 
			// tabViajes
			// 
			this.tabViajes.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabViajes.Controls.Add(this.tabValores);
			this.tabViajes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabViajes.HotTrack = true;
			this.tabViajes.Location = new System.Drawing.Point(12, 12);
			this.tabViajes.Multiline = true;
			this.tabViajes.Name = "tabViajes";
			this.tabViajes.SelectedIndex = 0;
			this.tabViajes.Size = new System.Drawing.Size(1088, 569);
			this.tabViajes.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabViajes.TabIndex = 135;
			// 
			// tabValores
			// 
			this.tabValores.BackColor = System.Drawing.Color.White;
			this.tabValores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabValores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabValores.Controls.Add(this.cmdGuardar);
			this.tabValores.Controls.Add(this.groupBox12);
			this.tabValores.Controls.Add(this.btnNuevo);
			this.tabValores.Controls.Add(this.groupBox18);
			this.tabValores.Controls.Add(this.dataImpuestos);
			this.tabValores.Controls.Add(this.btnGuardar);
			this.tabValores.Controls.Add(this.cmbTipo);
			this.tabValores.Controls.Add(this.label2);
			this.tabValores.Controls.Add(this.lblImporte);
			this.tabValores.Controls.Add(this.txtImporte);
			this.tabValores.Controls.Add(this.label22);
			this.tabValores.Controls.Add(this.txtNombre);
			this.tabValores.Controls.Add(this.label1);
			this.tabValores.Controls.Add(this.dataValorImporte);
			this.tabValores.ImageIndex = 1;
			this.tabValores.Location = new System.Drawing.Point(23, 4);
			this.tabValores.Name = "tabValores";
			this.tabValores.Padding = new System.Windows.Forms.Padding(3);
			this.tabValores.Size = new System.Drawing.Size(1061, 561);
			this.tabValores.TabIndex = 15;
			this.tabValores.Text = "Control Importes";
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.BackgroundImage")));
			this.cmdGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdGuardar.Location = new System.Drawing.Point(1011, 9);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(40, 35);
			this.cmdGuardar.TabIndex = 207;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// groupBox12
			// 
			this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox12.BackColor = System.Drawing.Color.Transparent;
			this.groupBox12.Controls.Add(this.label20);
			this.groupBox12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox12.Location = new System.Drawing.Point(16, 195);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(300, 354);
			this.groupBox12.TabIndex = 206;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Nota:";
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(8, 16);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(286, 335);
			this.label20.TabIndex = 3;
			this.label20.Text = resources.GetString("label20.Text");
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
			this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnNuevo.Location = new System.Drawing.Point(166, 138);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(64, 51);
			this.btnNuevo.TabIndex = 195;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.txtAlias);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(737, 2);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(268, 45);
			this.groupBox18.TabIndex = 152;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Busqueda del Operador por Nick";
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAlias.Location = new System.Drawing.Point(6, 16);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(252, 20);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// dataImpuestos
			// 
			this.dataImpuestos.AllowUserToAddRows = false;
			this.dataImpuestos.AllowUserToResizeRows = false;
			this.dataImpuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataImpuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataImpuestos.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_OPERADOR,
									this.Alias});
			this.dataImpuestos.Location = new System.Drawing.Point(737, 50);
			this.dataImpuestos.Name = "dataImpuestos";
			this.dataImpuestos.RowHeadersVisible = false;
			this.dataImpuestos.Size = new System.Drawing.Size(314, 496);
			this.dataImpuestos.TabIndex = 5;
			this.dataImpuestos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataImpuestosColumnHeaderMouseClick);
			// 
			// ID_OPERADOR
			// 
			this.ID_OPERADOR.HeaderText = "ID_OPERADOR";
			this.ID_OPERADOR.Name = "ID_OPERADOR";
			this.ID_OPERADOR.Visible = false;
			// 
			// Alias
			// 
			this.Alias.DataPropertyName = "Alias";
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alias.DefaultCellStyle = dataGridViewCellStyle1;
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			this.Alias.Width = 56;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnGuardar.Location = new System.Drawing.Point(236, 138);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(80, 51);
			this.btnGuardar.TabIndex = 194;
			this.btnGuardar.Text = "Agregar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// cmbTipo
			// 
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"Descuento",
									"Bono",
									"Extra",
									"Variable"});
			this.cmbTipo.Location = new System.Drawing.Point(221, 104);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(95, 22);
			this.cmbTipo.TabIndex = 193;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(182, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 29);
			this.label2.TabIndex = 192;
			this.label2.Text = "Tipo:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblImporte
			// 
			this.lblImporte.BackColor = System.Drawing.Color.White;
			this.lblImporte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImporte.Location = new System.Drawing.Point(16, 104);
			this.lblImporte.Name = "lblImporte";
			this.lblImporte.Size = new System.Drawing.Size(58, 22);
			this.lblImporte.TabIndex = 191;
			this.lblImporte.Text = "Importe:";
			this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtImporte
			// 
			this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtImporte.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporte.Location = new System.Drawing.Point(80, 103);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(96, 25);
			this.txtImporte.TabIndex = 189;
			this.txtImporte.TextChanged += new System.EventHandler(this.TxtImporteTextChanged);
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.White;
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(16, 69);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(58, 22);
			this.label22.TabIndex = 190;
			this.label22.Text = "Nombre:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(80, 68);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(236, 25);
			this.txtNombre.TabIndex = 188;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 54);
			this.label1.TabIndex = 3;
			this.label1.Text = "Importes";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataValorImporte
			// 
			this.dataValorImporte.AllowUserToAddRows = false;
			this.dataValorImporte.AllowUserToResizeRows = false;
			this.dataValorImporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataValorImporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataValorImporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataValorImporte.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataValorImporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataValorImporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataValorImporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataValorImporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn50,
									this.dataGridViewTextBoxColumn53,
									this.dataGridViewTextBoxColumn62,
									this.Tipo_Importe});
			this.dataValorImporte.Location = new System.Drawing.Point(332, 6);
			this.dataValorImporte.Name = "dataValorImporte";
			this.dataValorImporte.RowHeadersVisible = false;
			this.dataValorImporte.Size = new System.Drawing.Size(399, 540);
			this.dataValorImporte.TabIndex = 2;
			this.dataValorImporte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataValorImporteCellClick);
			// 
			// dataGridViewTextBoxColumn50
			// 
			this.dataGridViewTextBoxColumn50.DataPropertyName = "Empresa";
			this.dataGridViewTextBoxColumn50.HeaderText = "ID";
			this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
			this.dataGridViewTextBoxColumn50.ReadOnly = true;
			this.dataGridViewTextBoxColumn50.Width = 41;
			// 
			// dataGridViewTextBoxColumn53
			// 
			this.dataGridViewTextBoxColumn53.DataPropertyName = "Numero";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn53.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn53.HeaderText = "Detalle";
			this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
			this.dataGridViewTextBoxColumn53.ReadOnly = true;
			this.dataGridViewTextBoxColumn53.Width = 64;
			// 
			// dataGridViewTextBoxColumn62
			// 
			this.dataGridViewTextBoxColumn62.DataPropertyName = "Dinero";
			this.dataGridViewTextBoxColumn62.HeaderText = "$";
			this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
			this.dataGridViewTextBoxColumn62.Width = 38;
			// 
			// Tipo_Importe
			// 
			this.Tipo_Importe.HeaderText = "Tipo";
			this.Tipo_Importe.Name = "Tipo_Importe";
			this.Tipo_Importe.ReadOnly = true;
			this.Tipo_Importe.Width = 52;
			// 
			// FormImportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1112, 591);
			this.Controls.Add(this.tabViajes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormImportes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Importes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImportesFormClosing);
			this.Load += new System.EventHandler(this.FormImportesLoad);
			this.tabViajes.ResumeLayout(false);
			this.tabValores.ResumeLayout(false);
			this.tabValores.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataImpuestos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataValorImporte)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdGuardar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_OPERADOR;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		public System.Windows.Forms.DataGridView dataImpuestos;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Importe;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.Label lblImporte;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
		private System.Windows.Forms.DataGridView dataValorImporte;
		private System.Windows.Forms.TabPage tabValores;
		private System.Windows.Forms.TabControl tabViajes;
	}
}
