/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 16/07/2012
 * Time: 12:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Cliente
{
	partial class FormBusquedaCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusquedaCliente));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnAgreagar = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.dataCliente = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnContactoServicio = new System.Windows.Forms.Button();
			this.txtRumbo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMunicipio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtZonaReferencia = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSubNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbTipoCobro = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAceptar.Location = new System.Drawing.Point(70, 6);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(82, 28);
			this.btnAceptar.TabIndex = 9;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(761, 53);
			this.panel1.TabIndex = 204;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(7, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(47, 38);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(74, 14);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(469, 14);
			this.label8.TabIndex = 2;
			this.label8.Text = "Control de clientes registrados en la base de datos:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnBuscar);
			this.panel2.Controls.Add(this.btnAgreagar);
			this.panel2.Controls.Add(this.btnRemover);
			this.panel2.Controls.Add(this.dataCliente);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(761, 388);
			this.panel2.TabIndex = 205;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(296, 352);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(70, 30);
			this.btnBuscar.TabIndex = 14;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// btnAgreagar
			// 
			this.btnAgreagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAgreagar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgreagar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgreagar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgreagar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgreagar.Image")));
			this.btnAgreagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgreagar.Location = new System.Drawing.Point(121, 352);
			this.btnAgreagar.Name = "btnAgreagar";
			this.btnAgreagar.Size = new System.Drawing.Size(78, 30);
			this.btnAgreagar.TabIndex = 12;
			this.btnAgreagar.Text = "Agregar";
			this.btnAgreagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgreagar.UseVisualStyleBackColor = false;
			this.btnAgreagar.Click += new System.EventHandler(this.BtnAgreagarClick);
			// 
			// btnRemover
			// 
			this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemover.BackColor = System.Drawing.Color.Transparent;
			this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemover.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
			this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRemover.Location = new System.Drawing.Point(205, 352);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(85, 30);
			this.btnRemover.TabIndex = 13;
			this.btnRemover.Text = "Remover";
			this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemover.UseVisualStyleBackColor = false;
			this.btnRemover.Click += new System.EventHandler(this.BtnRemoverClick);
			// 
			// dataCliente
			// 
			this.dataCliente.AllowUserToAddRows = false;
			this.dataCliente.AllowUserToDeleteRows = false;
			this.dataCliente.AllowUserToResizeRows = false;
			this.dataCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataCliente.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataCliente.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataCliente.Location = new System.Drawing.Point(11, 7);
			this.dataCliente.MultiSelect = false;
			this.dataCliente.Name = "dataCliente";
			this.dataCliente.ReadOnly = true;
			this.dataCliente.RowHeadersVisible = false;
			this.dataCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataCliente.Size = new System.Drawing.Size(355, 342);
			this.dataCliente.TabIndex = 15;
			this.dataCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClienteCellClick);
			this.dataCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClienteCellDoubleClick);
			this.dataCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataClienteKeyUp);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ID";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Empresa";
			this.Column2.HeaderText = "Empresa";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 175;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "SubNombre";
			this.Column3.HeaderText = "Sub Nombre";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 175;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.cmbTipoCobro);
			this.panel3.Controls.Add(this.checkBox1);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.txtRumbo);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.txtEstado);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.txtMunicipio);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.txtZonaReferencia);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.txtDomicilio);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txtSubNombre);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.txtEmpresa);
			this.panel3.Controls.Add(this.label48);
			this.panel3.Location = new System.Drawing.Point(387, 7);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(356, 342);
			this.panel3.TabIndex = 205;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(101, 243);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(111, 18);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Modificar datos";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Controls.Add(this.btnModificar);
			this.panel4.Controls.Add(this.btnContactoServicio);
			this.panel4.Controls.Add(this.btnAceptar);
			this.panel4.Location = new System.Drawing.Point(0, 273);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(356, 41);
			this.panel4.TabIndex = 143;
			// 
			// btnModificar
			// 
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Enabled = false;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(158, 6);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(85, 28);
			this.btnModificar.TabIndex = 10;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnContactoServicio
			// 
			this.btnContactoServicio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnContactoServicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContactoServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnContactoServicio.Image")));
			this.btnContactoServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnContactoServicio.Location = new System.Drawing.Point(249, 6);
			this.btnContactoServicio.Name = "btnContactoServicio";
			this.btnContactoServicio.Size = new System.Drawing.Size(93, 28);
			this.btnContactoServicio.TabIndex = 11;
			this.btnContactoServicio.Text = "Contactos";
			this.btnContactoServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnContactoServicio.UseVisualStyleBackColor = true;
			this.btnContactoServicio.Click += new System.EventHandler(this.BtnContactoServicioClick);
			// 
			// txtRumbo
			// 
			this.txtRumbo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRumbo.Location = new System.Drawing.Point(101, 185);
			this.txtRumbo.Name = "txtRumbo";
			this.txtRumbo.Size = new System.Drawing.Size(239, 20);
			this.txtRumbo.TabIndex = 7;
			this.txtRumbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresaKeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(52, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 14);
			this.label7.TabIndex = 142;
			this.label7.Text = "Rumbo:";
			// 
			// txtEstado
			// 
			this.txtEstado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstado.Location = new System.Drawing.Point(101, 159);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(239, 20);
			this.txtEstado.TabIndex = 6;
			this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresaKeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(52, 159);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 14);
			this.label6.TabIndex = 140;
			this.label6.Text = "Estado:";
			// 
			// txtMunicipio
			// 
			this.txtMunicipio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMunicipio.Location = new System.Drawing.Point(101, 133);
			this.txtMunicipio.Name = "txtMunicipio";
			this.txtMunicipio.Size = new System.Drawing.Size(239, 20);
			this.txtMunicipio.TabIndex = 5;
			this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresaKeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(41, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 14);
			this.label5.TabIndex = 138;
			this.label5.Text = "Municipio:";
			// 
			// txtZonaReferencia
			// 
			this.txtZonaReferencia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtZonaReferencia.Location = new System.Drawing.Point(101, 109);
			this.txtZonaReferencia.Name = "txtZonaReferencia";
			this.txtZonaReferencia.Size = new System.Drawing.Size(239, 20);
			this.txtZonaReferencia.TabIndex = 4;
			this.txtZonaReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresaKeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 14);
			this.label4.TabIndex = 136;
			this.label4.Text = "Zona referencia:";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDomicilio.Location = new System.Drawing.Point(101, 83);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(239, 20);
			this.txtDomicilio.TabIndex = 3;
			this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresaKeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 14);
			this.label3.TabIndex = 134;
			this.label3.Text = "Domicilio:";
			// 
			// txtSubNombre
			// 
			this.txtSubNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubNombre.Location = new System.Drawing.Point(101, 56);
			this.txtSubNombre.Name = "txtSubNombre";
			this.txtSubNombre.Size = new System.Drawing.Size(239, 20);
			this.txtSubNombre.TabIndex = 2;
			this.txtSubNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresaKeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 14);
			this.label2.TabIndex = 132;
			this.label2.Text = "Sub nombre:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 23);
			this.label1.TabIndex = 130;
			this.label1.Text = "Datos de la empresa:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpresa.Location = new System.Drawing.Point(101, 31);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(239, 20);
			this.txtEmpresa.TabIndex = 1;
			this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmpresaKeyPress);
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.BackColor = System.Drawing.Color.Transparent;
			this.label48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label48.Location = new System.Drawing.Point(44, 33);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(52, 14);
			this.label48.TabIndex = 120;
			this.label48.Text = "Empresa:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(18, 214);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 146;
			this.label9.Text = "Tipo de cobro:";
			// 
			// cmbTipoCobro
			// 
			this.cmbTipoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoCobro.FormattingEnabled = true;
			this.cmbTipoCobro.Items.AddRange(new object[] {
									"CAMION",
									"CAMIONETA",
									"ABIERTO"});
			this.cmbTipoCobro.Location = new System.Drawing.Point(101, 211);
			this.cmbTipoCobro.Name = "cmbTipoCobro";
			this.cmbTipoCobro.Size = new System.Drawing.Size(121, 21);
			this.cmbTipoCobro.TabIndex = 145;
			// 
			// FormBusquedaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(761, 459);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBusquedaCliente";
			this.Text = "Transportes LAR - Clientes registrados ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBusquedaClienteFormClosing);
			this.Load += new System.EventHandler(this.FormBusquedaClienteLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbTipoCobro;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox checkBox1;
		public System.Windows.Forms.Button btnBuscar;
		public System.Windows.Forms.Button btnAgreagar;
		public System.Windows.Forms.Button btnContactoServicio;
		public System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Label label48;
		public System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtSubNombre;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtZonaReferencia;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtMunicipio;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox txtRumbo;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataCliente;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Button btnAceptar;
	}
}
