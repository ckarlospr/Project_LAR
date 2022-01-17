/*
 * Created by SharpDevelop.
 * User: Xavi_Ochoa
 * Date: 04/02/2014
 * Time: 02:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Facturacion
{
	partial class FormFactHenniges
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactHenniges));
			this.dtFactHennieges = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.Decremento = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtdecremento = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAumento = new System.Windows.Forms.TextBox();
			this.cmbTurno = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.cmbServicio = new System.Windows.Forms.ComboBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.cmbCliente = new System.Windows.Forms.ToolStripComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dtFactHennieges)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.Decremento.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtFactHennieges
			// 
			this.dtFactHennieges.AllowUserToAddRows = false;
			this.dtFactHennieges.AllowUserToResizeColumns = false;
			this.dtFactHennieges.AllowUserToResizeRows = false;
			this.dtFactHennieges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dtFactHennieges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtFactHennieges.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dtFactHennieges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dtFactHennieges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtFactHennieges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Nombre,
									this.Servicio,
									this.Importe,
									this.Tipo,
									this.CTurno,
									this.Eliminar});
			this.dtFactHennieges.Location = new System.Drawing.Point(293, 32);
			this.dtFactHennieges.Name = "dtFactHennieges";
			this.dtFactHennieges.RowHeadersVisible = false;
			this.dtFactHennieges.Size = new System.Drawing.Size(489, 691);
			this.dtFactHennieges.TabIndex = 1;
			this.dtFactHennieges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtFactHenniegesCellContentClick);
			this.dtFactHennieges.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtFactHenniegesCellEnter);
			this.dtFactHennieges.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DtFactHenniegesCellPainting);
			this.dtFactHennieges.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtFactHenniegesColumnHeaderMouseClick);
			this.dtFactHennieges.Enter += new System.EventHandler(this.DtFactHenniegesEnter);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Servicio
			// 
			this.Servicio.HeaderText = "Servicio";
			this.Servicio.Name = "Servicio";
			this.Servicio.ReadOnly = true;
			// 
			// Importe
			// 
			this.Importe.HeaderText = "Importe";
			this.Importe.Name = "Importe";
			this.Importe.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// CTurno
			// 
			this.CTurno.HeaderText = "Turno";
			this.CTurno.Name = "CTurno";
			this.CTurno.ReadOnly = true;
			// 
			// Eliminar
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
			this.Eliminar.DefaultCellStyle = dataGridViewCellStyle1;
			this.Eliminar.HeaderText = "Eliminar";
			this.Eliminar.Name = "Eliminar";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.BackColor = System.Drawing.Color.White;
			this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox3.Controls.Add(this.Decremento);
			this.groupBox3.Controls.Add(this.groupBox1);
			this.groupBox3.Controls.Add(this.cmbTurno);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.btnInsertar);
			this.groupBox3.Controls.Add(this.cmbTipo);
			this.groupBox3.Controls.Add(this.cmbServicio);
			this.groupBox3.Controls.Add(this.btnModificar);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txtNombre);
			this.groupBox3.Controls.Add(this.txtImporte);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(9, 33);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(278, 691);
			this.groupBox3.TabIndex = 146;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Datos de la  Ruta";
			// 
			// Decremento
			// 
			this.Decremento.Controls.Add(this.label6);
			this.Decremento.Controls.Add(this.button2);
			this.Decremento.Controls.Add(this.label3);
			this.Decremento.Controls.Add(this.txtdecremento);
			this.Decremento.Location = new System.Drawing.Point(9, 335);
			this.Decremento.Name = "Decremento";
			this.Decremento.Size = new System.Drawing.Size(259, 79);
			this.Decremento.TabIndex = 194;
			this.Decremento.TabStop = false;
			this.Decremento.Text = "Decremento Global por Empresa";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(4, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(247, 17);
			this.label6.TabIndex = 194;
			this.label6.Text = "El porcentaje debe de ser en enteros ej.: 16";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(178, 33);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 192;
			this.button2.Text = "Aceptar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 22);
			this.label3.TabIndex = 191;
			this.label3.Text = "Decremento %";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.DoubleClick += new System.EventHandler(this.Label3DoubleClick);
			// 
			// txtdecremento
			// 
			this.txtdecremento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtdecremento.Enabled = false;
			this.txtdecremento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdecremento.HideSelection = false;
			this.txtdecremento.Location = new System.Drawing.Point(91, 33);
			this.txtdecremento.Name = "txtdecremento";
			this.txtdecremento.Size = new System.Drawing.Size(81, 20);
			this.txtdecremento.TabIndex = 190;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtAumento);
			this.groupBox1.Location = new System.Drawing.Point(13, 226);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 79);
			this.groupBox1.TabIndex = 193;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Aumento Global por Empresa";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(247, 17);
			this.label4.TabIndex = 193;
			this.label4.Text = "El porcentaje debe de ser en enteros ej.: 16";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(178, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 192;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 22);
			this.label2.TabIndex = 191;
			this.label2.Text = "Aumento %";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.DoubleClick += new System.EventHandler(this.Label2DoubleClick);
			// 
			// txtAumento
			// 
			this.txtAumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAumento.Enabled = false;
			this.txtAumento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAumento.HideSelection = false;
			this.txtAumento.Location = new System.Drawing.Point(76, 33);
			this.txtAumento.Name = "txtAumento";
			this.txtAumento.Size = new System.Drawing.Size(96, 20);
			this.txtAumento.TabIndex = 190;
			this.txtAumento.Click += new System.EventHandler(this.TxtAumentoClick);
			// 
			// cmbTurno
			// 
			this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTurno.FormattingEnabled = true;
			this.cmbTurno.Items.AddRange(new object[] {
									"Mañana",
									"Medio día",
									"Vespertino",
									"Nocturno",
									"NA"});
			this.cmbTurno.Location = new System.Drawing.Point(70, 114);
			this.cmbTurno.Name = "cmbTurno";
			this.cmbTurno.Size = new System.Drawing.Size(197, 22);
			this.cmbTurno.TabIndex = 189;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 22);
			this.label1.TabIndex = 188;
			this.label1.Text = "Turno";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnInsertar
			// 
			this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInsertar.BackColor = System.Drawing.Color.Transparent;
			this.btnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInsertar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
			this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnInsertar.Location = new System.Drawing.Point(131, 632);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(67, 53);
			this.btnInsertar.TabIndex = 187;
			this.btnInsertar.Text = "Agregar";
			this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnInsertar.UseVisualStyleBackColor = false;
			this.btnInsertar.Click += new System.EventHandler(this.BtnInsertarClick);
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Items.AddRange(new object[] {
									"NRM",
									"EXT",
									"ESP"});
			this.cmbTipo.Location = new System.Drawing.Point(70, 89);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(197, 22);
			this.cmbTipo.TabIndex = 186;
			this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.CmbTipoSelectedValueChanged);
			// 
			// cmbServicio
			// 
			this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbServicio.FormattingEnabled = true;
			this.cmbServicio.Items.AddRange(new object[] {
									"Sencillo",
									"Completo",
									"NA"});
			this.cmbServicio.Location = new System.Drawing.Point(70, 41);
			this.cmbServicio.Name = "cmbServicio";
			this.cmbServicio.Size = new System.Drawing.Size(198, 22);
			this.cmbServicio.TabIndex = 147;
			// 
			// btnModificar
			// 
			this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnModificar.Location = new System.Drawing.Point(200, 632);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(67, 53);
			this.btnModificar.TabIndex = 185;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 22);
			this.label9.TabIndex = 145;
			this.label9.Text = "Servicio";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(70, 19);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(197, 20);
			this.txtNombre.TabIndex = 15;
			// 
			// txtImporte
			// 
			this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtImporte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporte.Location = new System.Drawing.Point(70, 67);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(197, 20);
			this.txtImporte.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 22);
			this.label8.TabIndex = 142;
			this.label8.Text = "Nombre";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 22);
			this.label5.TabIndex = 140;
			this.label5.Text = "Tipo";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 63);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 22);
			this.label11.TabIndex = 143;
			this.label11.Text = "Importe";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cmbCliente});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(791, 25);
			this.toolStrip1.TabIndex = 147;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// cmbCliente
			// 
			this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			this.cmbCliente.Items.AddRange(new object[] {
									"HENNIGES",
									"VITRO"});
			this.cmbCliente.Name = "cmbCliente";
			this.cmbCliente.Size = new System.Drawing.Size(121, 25);
			this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.CmbClienteSelectedIndexChanged);
			// 
			// FormFactHenniges
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(791, 747);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dtFactHennieges);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormFactHenniges";
			this.Text = "Transportes LAR - Importes  de Facturación";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFactHennigesFormClosing);
			this.Load += new System.EventHandler(this.FormFactHennigesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dtFactHennieges)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.Decremento.ResumeLayout(false);
			this.Decremento.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtdecremento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox Decremento;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAumento;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripComboBox cmbCliente;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbTurno;
		private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn CTurno;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.ComboBox cmbServicio;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
		private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dtFactHennieges;
	}
}
