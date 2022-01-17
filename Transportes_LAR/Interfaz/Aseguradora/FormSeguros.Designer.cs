namespace Transportes_LAR.Interfaz.Aseguradora
{
	partial class FormSeguros
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguros));
			this.gbAseguradora = new System.Windows.Forms.GroupBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbAseguradoras = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbSeguro = new System.Windows.Forms.GroupBox();
			this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCobertura = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbPoliza = new System.Windows.Forms.GroupBox();
			this.txtNumeroSeguro = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnGuardarEditar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.dgvSinAsegurar = new System.Windows.Forms.DataGridView();
			this.cNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbUnidad = new System.Windows.Forms.GroupBox();
			this.txtUPF = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtUPE = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtUTipo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUNum = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvAsegurados = new System.Windows.Forms.DataGridView();
			this.vNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label13 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.TimeImage = new System.Windows.Forms.Timer(this.components);
			this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
			this.gbAseguradora.SuspendLayout();
			this.gbSeguro.SuspendLayout();
			this.gbPoliza.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinAsegurar)).BeginInit();
			this.gbUnidad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsegurados)).BeginInit();
			this.SuspendLayout();
			// 
			// gbAseguradora
			// 
			this.gbAseguradora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAseguradora.BackgroundImage")));
			this.gbAseguradora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gbAseguradora.Controls.Add(this.txtTelefono);
			this.gbAseguradora.Controls.Add(this.label3);
			this.gbAseguradora.Controls.Add(this.txtDomicilio);
			this.gbAseguradora.Controls.Add(this.label2);
			this.gbAseguradora.Controls.Add(this.cmbAseguradoras);
			this.gbAseguradora.Controls.Add(this.label1);
			this.gbAseguradora.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAseguradora.ForeColor = System.Drawing.Color.Black;
			this.gbAseguradora.Location = new System.Drawing.Point(361, 148);
			this.gbAseguradora.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbAseguradora.Name = "gbAseguradora";
			this.gbAseguradora.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbAseguradora.Size = new System.Drawing.Size(282, 104);
			this.gbAseguradora.TabIndex = 4;
			this.gbAseguradora.TabStop = false;
			this.gbAseguradora.Text = "2.- Aseguradora";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Enabled = false;
			this.txtTelefono.Location = new System.Drawing.Point(98, 72);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(168, 20);
			this.txtTelefono.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 74);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Telefono:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Enabled = false;
			this.txtDomicilio.Location = new System.Drawing.Point(98, 46);
			this.txtDomicilio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(168, 20);
			this.txtDomicilio.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 48);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Domicilio:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbAseguradoras
			// 
			this.cmbAseguradoras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbAseguradoras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAseguradoras.FormattingEnabled = true;
			this.cmbAseguradoras.ItemHeight = 14;
			this.cmbAseguradoras.Location = new System.Drawing.Point(98, 19);
			this.cmbAseguradoras.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cmbAseguradoras.Name = "cmbAseguradoras";
			this.cmbAseguradoras.Size = new System.Drawing.Size(168, 22);
			this.cmbAseguradoras.TabIndex = 1;
			this.cmbAseguradoras.TextChanged += new System.EventHandler(this.CmbAseguradorasTextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbSeguro
			// 
			this.gbSeguro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbSeguro.BackgroundImage")));
			this.gbSeguro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gbSeguro.Controls.Add(this.dtpVencimiento);
			this.gbSeguro.Controls.Add(this.label5);
			this.gbSeguro.Controls.Add(this.txtCobertura);
			this.gbSeguro.Controls.Add(this.label4);
			this.gbSeguro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbSeguro.ForeColor = System.Drawing.Color.Black;
			this.gbSeguro.Location = new System.Drawing.Point(361, 259);
			this.gbSeguro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbSeguro.Name = "gbSeguro";
			this.gbSeguro.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbSeguro.Size = new System.Drawing.Size(281, 77);
			this.gbSeguro.TabIndex = 5;
			this.gbSeguro.TabStop = false;
			this.gbSeguro.Text = "3.- Detalle deSeguro";
			// 
			// dtpVencimiento
			// 
			this.dtpVencimiento.Location = new System.Drawing.Point(98, 49);
			this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dtpVencimiento.Name = "dtpVencimiento";
			this.dtpVencimiento.Size = new System.Drawing.Size(167, 20);
			this.dtpVencimiento.TabIndex = 7;
			this.dtpVencimiento.ValueChanged += new System.EventHandler(this.DtpVencimientoValueChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 45);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Vencimiento:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCobertura
			// 
			this.txtCobertura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.txtCobertura.Location = new System.Drawing.Point(98, 19);
			this.txtCobertura.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtCobertura.Name = "txtCobertura";
			this.txtCobertura.Size = new System.Drawing.Size(168, 20);
			this.txtCobertura.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 19);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cobertura:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbPoliza
			// 
			this.gbPoliza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbPoliza.BackgroundImage")));
			this.gbPoliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gbPoliza.Controls.Add(this.txtNumeroSeguro);
			this.gbPoliza.Controls.Add(this.label9);
			this.gbPoliza.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPoliza.ForeColor = System.Drawing.Color.Black;
			this.gbPoliza.Location = new System.Drawing.Point(361, 342);
			this.gbPoliza.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbPoliza.Name = "gbPoliza";
			this.gbPoliza.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbPoliza.Size = new System.Drawing.Size(281, 49);
			this.gbPoliza.TabIndex = 6;
			this.gbPoliza.TabStop = false;
			this.gbPoliza.Text = "4.- Poliza de Seguro";
			// 
			// txtNumeroSeguro
			// 
			this.txtNumeroSeguro.Location = new System.Drawing.Point(98, 19);
			this.txtNumeroSeguro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtNumeroSeguro.Name = "txtNumeroSeguro";
			this.txtNumeroSeguro.Size = new System.Drawing.Size(84, 20);
			this.txtNumeroSeguro.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(20, 19);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 20);
			this.label9.TabIndex = 8;
			this.label9.Text = "Numero:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnGuardarEditar
			// 
			this.btnGuardarEditar.BackColor = System.Drawing.Color.Transparent;
			this.btnGuardarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardarEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarEditar.Image")));
			this.btnGuardarEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarEditar.Location = new System.Drawing.Point(459, 400);
			this.btnGuardarEditar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnGuardarEditar.Name = "btnGuardarEditar";
			this.btnGuardarEditar.Size = new System.Drawing.Size(84, 31);
			this.btnGuardarEditar.TabIndex = 10;
			this.btnGuardarEditar.Text = "Guardar";
			this.btnGuardarEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarEditar.UseVisualStyleBackColor = false;
			this.btnGuardarEditar.Click += new System.EventHandler(this.BtnGuardarEditarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(560, 400);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(84, 31);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Aceptar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(183, 16);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(158, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "Unidades no Aseguradas:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvSinAsegurar
			// 
			this.dgvSinAsegurar.AllowUserToAddRows = false;
			this.dgvSinAsegurar.AllowUserToDeleteRows = false;
			this.dgvSinAsegurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgvSinAsegurar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSinAsegurar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvSinAsegurar.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dgvSinAsegurar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvSinAsegurar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvSinAsegurar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSinAsegurar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.cNumero});
			this.dgvSinAsegurar.Location = new System.Drawing.Point(183, 39);
			this.dgvSinAsegurar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dgvSinAsegurar.MultiSelect = false;
			this.dgvSinAsegurar.Name = "dgvSinAsegurar";
			this.dgvSinAsegurar.ReadOnly = true;
			this.dgvSinAsegurar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvSinAsegurar.RowHeadersVisible = false;
			this.dgvSinAsegurar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dgvSinAsegurar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSinAsegurar.Size = new System.Drawing.Size(158, 389);
			this.dgvSinAsegurar.StandardTab = true;
			this.dgvSinAsegurar.TabIndex = 13;
			this.dgvSinAsegurar.TabStop = false;
			this.dgvSinAsegurar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSinAsegurarCellEnter);
			// 
			// cNumero
			// 
			this.cNumero.DataPropertyName = "Numero";
			this.cNumero.HeaderText = "Numero";
			this.cNumero.Name = "cNumero";
			this.cNumero.ReadOnly = true;
			this.cNumero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// gbUnidad
			// 
			this.gbUnidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbUnidad.BackgroundImage")));
			this.gbUnidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gbUnidad.Controls.Add(this.txtUPF);
			this.gbUnidad.Controls.Add(this.label11);
			this.gbUnidad.Controls.Add(this.txtUPE);
			this.gbUnidad.Controls.Add(this.label10);
			this.gbUnidad.Controls.Add(this.txtUTipo);
			this.gbUnidad.Controls.Add(this.label8);
			this.gbUnidad.Controls.Add(this.txtUNum);
			this.gbUnidad.Controls.Add(this.label7);
			this.gbUnidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbUnidad.ForeColor = System.Drawing.Color.Black;
			this.gbUnidad.Location = new System.Drawing.Point(361, 12);
			this.gbUnidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbUnidad.Name = "gbUnidad";
			this.gbUnidad.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.gbUnidad.Size = new System.Drawing.Size(282, 130);
			this.gbUnidad.TabIndex = 3;
			this.gbUnidad.TabStop = false;
			this.gbUnidad.Text = "1.- Detalle de Unidad";
			// 
			// txtUPF
			// 
			this.txtUPF.Enabled = false;
			this.txtUPF.Location = new System.Drawing.Point(98, 99);
			this.txtUPF.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtUPF.Name = "txtUPF";
			this.txtUPF.Size = new System.Drawing.Size(84, 20);
			this.txtUPF.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(20, 99);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 20);
			this.label11.TabIndex = 6;
			this.label11.Text = "Placa Federal";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUPE
			// 
			this.txtUPE.Enabled = false;
			this.txtUPE.Location = new System.Drawing.Point(98, 73);
			this.txtUPE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtUPE.Name = "txtUPE";
			this.txtUPE.Size = new System.Drawing.Size(84, 20);
			this.txtUPE.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(20, 73);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 20);
			this.label10.TabIndex = 4;
			this.label10.Text = "Placa Estatal:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUTipo
			// 
			this.txtUTipo.Enabled = false;
			this.txtUTipo.Location = new System.Drawing.Point(98, 47);
			this.txtUTipo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtUTipo.Name = "txtUTipo";
			this.txtUTipo.Size = new System.Drawing.Size(84, 20);
			this.txtUTipo.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(20, 47);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Tipo:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUNum
			// 
			this.txtUNum.Location = new System.Drawing.Point(98, 20);
			this.txtUNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtUNum.Name = "txtUNum";
			this.txtUNum.Size = new System.Drawing.Size(84, 20);
			this.txtUNum.TabIndex = 1;
			this.txtUNum.TextChanged += new System.EventHandler(this.TxtUNumTextChanged);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(20, 20);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Numero:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvAsegurados
			// 
			this.dgvAsegurados.AllowUserToAddRows = false;
			this.dgvAsegurados.AllowUserToDeleteRows = false;
			this.dgvAsegurados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgvAsegurados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAsegurados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dgvAsegurados.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dgvAsegurados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvAsegurados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.vNumero,
									this.Fecha});
			this.dgvAsegurados.Location = new System.Drawing.Point(12, 39);
			this.dgvAsegurados.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dgvAsegurados.MultiSelect = false;
			this.dgvAsegurados.Name = "dgvAsegurados";
			this.dgvAsegurados.ReadOnly = true;
			this.dgvAsegurados.RowHeadersVisible = false;
			this.dgvAsegurados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAsegurados.Size = new System.Drawing.Size(158, 392);
			this.dgvAsegurados.TabIndex = 12;
			this.dgvAsegurados.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAseguradosCellEnter);
			// 
			// vNumero
			// 
			this.vNumero.DataPropertyName = "vNumero";
			this.vNumero.FillWeight = 52.79188F;
			this.vNumero.HeaderText = "Numero";
			this.vNumero.Name = "vNumero";
			this.vNumero.ReadOnly = true;
			// 
			// Fecha
			// 
			this.Fecha.DataPropertyName = "sVencimiento";
			this.Fecha.FillWeight = 77.20812F;
			this.Fecha.HeaderText = "Vencimiento";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(12, 16);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(158, 23);
			this.label13.TabIndex = 0;
			this.label13.Text = "Unidades Aseguradas:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(363, 400);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(78, 31);
			this.btnEliminar.TabIndex = 9;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// TimeImage
			// 
			this.TimeImage.Enabled = true;
			this.TimeImage.Tick += new System.EventHandler(this.TimeImageTick);
			// 
			// ListaImagenes
			// 
			this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
			this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
			this.ListaImagenes.Images.SetKeyName(0, "Aceptar.png");
			this.ListaImagenes.Images.SetKeyName(1, "Cancelar.png");
			this.ListaImagenes.Images.SetKeyName(2, "Guardar_opt.png");
			this.ListaImagenes.Images.SetKeyName(3, "kword_24x24-32.gif");
			this.ListaImagenes.Images.SetKeyName(4, "core_24x24-32.gif");
			// 
			// FormSeguros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(657, 440);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.dgvAsegurados);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dgvSinAsegurar);
			this.Controls.Add(this.gbUnidad);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardarEditar);
			this.Controls.Add(this.gbPoliza);
			this.Controls.Add(this.gbSeguro);
			this.Controls.Add(this.gbAseguradora);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "FormSeguros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Seguro Vehicular";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSegurosFormClosing);
			this.Load += new System.EventHandler(this.FormSegurosLoad);
			this.gbAseguradora.ResumeLayout(false);
			this.gbAseguradora.PerformLayout();
			this.gbSeguro.ResumeLayout(false);
			this.gbSeguro.PerformLayout();
			this.gbPoliza.ResumeLayout(false);
			this.gbPoliza.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinAsegurar)).EndInit();
			this.gbUnidad.ResumeLayout(false);
			this.gbUnidad.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsegurados)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ImageList ListaImagenes;
		private System.Windows.Forms.Timer TimeImage;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridViewTextBoxColumn vNumero;
		private System.Windows.Forms.DataGridView dgvAsegurados;
		private System.Windows.Forms.Button btnGuardarEditar;
		private System.Windows.Forms.GroupBox gbAseguradora;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.GroupBox gbSeguro;
		private System.Windows.Forms.GroupBox gbPoliza;
		private System.Windows.Forms.GroupBox gbUnidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn cNumero;
		public System.Windows.Forms.TextBox txtCobertura;
		public System.Windows.Forms.DateTimePicker dtpVencimiento;
		public System.Windows.Forms.TextBox txtNumeroSeguro;
		public System.Windows.Forms.TextBox txtUNum;
		public System.Windows.Forms.TextBox txtUPE;
		public System.Windows.Forms.TextBox txtUTipo;
		public System.Windows.Forms.TextBox txtUPF;
		public System.Windows.Forms.ComboBox cmbAseguradoras;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dgvSinAsegurar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label1;
	}
}
