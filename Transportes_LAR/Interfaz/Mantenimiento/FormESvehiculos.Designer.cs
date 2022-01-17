/*
 * Created by SharpDevelop.
 * User: Xavi_Ochoa
 * Date: 09/04/2014
 * Time: 12:33 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Mantenimiento
{
	partial class FormESvehiculos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormESvehiculos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pPrincipal = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtNumOperacion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtResponsable = new System.Windows.Forms.TextBox();
			this.txtOperacion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtIdOP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreAnticipos = new System.Windows.Forms.TextBox();
			this.txtAliasAnticipos = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtIdUnidad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTipoUnidad = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvHistorialOV = new System.Windows.Forms.DataGridView();
			this.DATAIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataIDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dataOperadorVehiculo = new System.Windows.Forms.DataGridView();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pPrincipal.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOV)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataOperadorVehiculo)).BeginInit();
			this.SuspendLayout();
			// 
			// pPrincipal
			// 
			this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pPrincipal.BackColor = System.Drawing.Color.White;
			this.pPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pPrincipal.Controls.Add(this.groupBox3);
			this.pPrincipal.Controls.Add(this.groupBox2);
			this.pPrincipal.Controls.Add(this.groupBox1);
			this.pPrincipal.Controls.Add(this.groupBox5);
			this.pPrincipal.Location = new System.Drawing.Point(12, 32);
			this.pPrincipal.Name = "pPrincipal";
			this.pPrincipal.Size = new System.Drawing.Size(995, 126);
			this.pPrincipal.TabIndex = 146;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.txtNumOperacion);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtResponsable);
			this.groupBox2.Controls.Add(this.txtOperacion);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(177, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(291, 113);
			this.groupBox2.TabIndex = 189;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Operación";
			// 
			// txtNumOperacion
			// 
			this.txtNumOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNumOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumOperacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumOperacion.Location = new System.Drawing.Point(102, 14);
			this.txtNumOperacion.Name = "txtNumOperacion";
			this.txtNumOperacion.Size = new System.Drawing.Size(183, 25);
			this.txtNumOperacion.TabIndex = 1;
			this.txtNumOperacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumOperacionKeyUp);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(2, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 22);
			this.label5.TabIndex = 201;
			this.label5.Text = "Num. Operacion:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtResponsable
			// 
			this.txtResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtResponsable.Enabled = false;
			this.txtResponsable.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResponsable.Location = new System.Drawing.Point(102, 73);
			this.txtResponsable.Name = "txtResponsable";
			this.txtResponsable.Size = new System.Drawing.Size(183, 25);
			this.txtResponsable.TabIndex = 197;
			// 
			// txtOperacion
			// 
			this.txtOperacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtOperacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperacion.Enabled = false;
			this.txtOperacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperacion.Location = new System.Drawing.Point(102, 43);
			this.txtOperacion.Name = "txtOperacion";
			this.txtOperacion.Size = new System.Drawing.Size(183, 25);
			this.txtOperacion.TabIndex = 196;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(32, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 22);
			this.label6.TabIndex = 198;
			this.label6.Text = "Operacion:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(17, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 22);
			this.label7.TabIndex = 199;
			this.label7.Text = "Responsable:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.txtIdOP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNombreAnticipos);
			this.groupBox1.Controls.Add(this.txtAliasAnticipos);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(718, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(265, 112);
			this.groupBox1.TabIndex = 189;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operador";
			// 
			// txtIdOP
			// 
			this.txtIdOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtIdOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIdOP.Enabled = false;
			this.txtIdOP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdOP.Location = new System.Drawing.Point(94, 16);
			this.txtIdOP.Name = "txtIdOP";
			this.txtIdOP.Size = new System.Drawing.Size(165, 25);
			this.txtIdOP.TabIndex = 3;
			this.txtIdOP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIdOPKeyUp);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 22);
			this.label1.TabIndex = 189;
			this.label1.Text = "ID Operador:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNombreAnticipos
			// 
			this.txtNombreAnticipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombreAnticipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombreAnticipos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombreAnticipos.Enabled = false;
			this.txtNombreAnticipos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreAnticipos.Location = new System.Drawing.Point(94, 76);
			this.txtNombreAnticipos.Name = "txtNombreAnticipos";
			this.txtNombreAnticipos.Size = new System.Drawing.Size(165, 25);
			this.txtNombreAnticipos.TabIndex = 26;
			// 
			// txtAliasAnticipos
			// 
			this.txtAliasAnticipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAliasAnticipos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAliasAnticipos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAliasAnticipos.Enabled = false;
			this.txtAliasAnticipos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAliasAnticipos.Location = new System.Drawing.Point(94, 45);
			this.txtAliasAnticipos.Name = "txtAliasAnticipos";
			this.txtAliasAnticipos.Size = new System.Drawing.Size(165, 25);
			this.txtAliasAnticipos.TabIndex = 25;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.White;
			this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(52, 49);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(39, 22);
			this.label22.TabIndex = 185;
			this.label22.Text = "Nick:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.White;
			this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(30, 77);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(58, 22);
			this.label28.TabIndex = 187;
			this.label28.Text = "Nombre:";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox5.Controls.Add(this.txtIdUnidad);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.txtTipoUnidad);
			this.groupBox5.Controls.Add(this.txtMarca);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(474, 3);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(240, 113);
			this.groupBox5.TabIndex = 188;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Unidad";
			// 
			// txtIdUnidad
			// 
			this.txtIdUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtIdUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIdUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIdUnidad.Enabled = false;
			this.txtIdUnidad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdUnidad.Location = new System.Drawing.Point(111, 16);
			this.txtIdUnidad.Name = "txtIdUnidad";
			this.txtIdUnidad.Size = new System.Drawing.Size(123, 25);
			this.txtIdUnidad.TabIndex = 2;
			this.txtIdUnidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtIdUnidadKeyUp);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 22);
			this.label2.TabIndex = 195;
			this.label2.Text = "Num. de Unidad:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTipoUnidad
			// 
			this.txtTipoUnidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTipoUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTipoUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTipoUnidad.Enabled = false;
			this.txtTipoUnidad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipoUnidad.Location = new System.Drawing.Point(111, 75);
			this.txtTipoUnidad.Name = "txtTipoUnidad";
			this.txtTipoUnidad.Size = new System.Drawing.Size(123, 25);
			this.txtTipoUnidad.TabIndex = 191;
			// 
			// txtMarca
			// 
			this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMarca.Enabled = false;
			this.txtMarca.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMarca.Location = new System.Drawing.Point(111, 45);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(123, 25);
			this.txtMarca.TabIndex = 190;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 22);
			this.label3.TabIndex = 192;
			this.label3.Text = "Marca:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 22);
			this.label4.TabIndex = 193;
			this.label4.Text = "Tipo de Unidad:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvHistorialOV
			// 
			this.dgvHistorialOV.AllowUserToAddRows = false;
			this.dgvHistorialOV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgvHistorialOV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvHistorialOV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvHistorialOV.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dgvHistorialOV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvHistorialOV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistorialOV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.DATAIDO,
									this.dataIDV,
									this.dataFecha,
									this.dataHora,
									this.dataNombre,
									this.dataTipo,
									this.dataNumero,
									this.dataDescripcion});
			this.dgvHistorialOV.Location = new System.Drawing.Point(12, 165);
			this.dgvHistorialOV.Name = "dgvHistorialOV";
			this.dgvHistorialOV.ReadOnly = true;
			this.dgvHistorialOV.RowHeadersVisible = false;
			this.dgvHistorialOV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistorialOV.Size = new System.Drawing.Size(539, 293);
			this.dgvHistorialOV.TabIndex = 147;
			// 
			// DATAIDO
			// 
			this.DATAIDO.DataPropertyName = "ido";
			this.DATAIDO.HeaderText = "ID Operador";
			this.DATAIDO.Name = "DATAIDO";
			this.DATAIDO.ReadOnly = true;
			this.DATAIDO.Visible = false;
			this.DATAIDO.Width = 71;
			// 
			// dataIDV
			// 
			this.dataIDV.DataPropertyName = "idv";
			this.dataIDV.HeaderText = "ID Vehiculo";
			this.dataIDV.Name = "dataIDV";
			this.dataIDV.ReadOnly = true;
			this.dataIDV.Visible = false;
			this.dataIDV.Width = 68;
			// 
			// dataFecha
			// 
			this.dataFecha.DataPropertyName = "fecha";
			this.dataFecha.HeaderText = "Fecha";
			this.dataFecha.Name = "dataFecha";
			this.dataFecha.ReadOnly = true;
			this.dataFecha.Width = 62;
			// 
			// dataHora
			// 
			this.dataHora.DataPropertyName = "hora";
			this.dataHora.HeaderText = "Hora";
			this.dataHora.Name = "dataHora";
			this.dataHora.ReadOnly = true;
			this.dataHora.Width = 55;
			// 
			// dataNombre
			// 
			this.dataNombre.DataPropertyName = "nombre";
			this.dataNombre.HeaderText = "Nick";
			this.dataNombre.Name = "dataNombre";
			this.dataNombre.ReadOnly = true;
			this.dataNombre.Width = 54;
			// 
			// dataTipo
			// 
			this.dataTipo.DataPropertyName = "tv";
			this.dataTipo.HeaderText = "Unidad";
			this.dataTipo.Name = "dataTipo";
			this.dataTipo.ReadOnly = true;
			this.dataTipo.Width = 66;
			// 
			// dataNumero
			// 
			this.dataNumero.DataPropertyName = "nv";
			this.dataNumero.HeaderText = "#";
			this.dataNumero.Name = "dataNumero";
			this.dataNumero.ReadOnly = true;
			this.dataNumero.Width = 39;
			// 
			// dataDescripcion
			// 
			this.dataDescripcion.DataPropertyName = "descripcion";
			this.dataDescripcion.HeaderText = "Descripción";
			this.dataDescripcion.Name = "dataDescripcion";
			this.dataDescripcion.ReadOnly = true;
			this.dataDescripcion.Width = 88;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnLimpiar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
			this.toolStrip1.TabIndex = 191;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
			this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(70, 22);
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(5, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(167, 113);
			this.groupBox3.TabIndex = 190;
			this.groupBox3.TabStop = false;
			this.groupBox3.Tag = "";
			this.groupBox3.Text = "Numeros de Operación";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(5, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(151, 22);
			this.label8.TabIndex = 201;
			this.label8.Text = "(1) Asignación de Unidad";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(5, 38);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(163, 22);
			this.label9.TabIndex = 198;
			this.label9.Text = "(2) Desasignación de Unidad";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(5, 82);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(120, 22);
			this.label10.TabIndex = 199;
			this.label10.Text = "(4) Salío del taller";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(5, 60);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(114, 22);
			this.label11.TabIndex = 202;
			this.label11.Text = "(3) Entró al taller";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataOperadorVehiculo
			// 
			this.dataOperadorVehiculo.AllowUserToAddRows = false;
			this.dataOperadorVehiculo.AllowUserToDeleteRows = false;
			this.dataOperadorVehiculo.AllowUserToResizeColumns = false;
			this.dataOperadorVehiculo.AllowUserToResizeRows = false;
			this.dataOperadorVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataOperadorVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataOperadorVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataOperadorVehiculo.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataOperadorVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataOperadorVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataOperadorVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOperadorVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column4,
									this.Column5,
									this.Column9,
									this.Column10,
									this.Column11,
									this.Marca});
			this.dataOperadorVehiculo.Location = new System.Drawing.Point(557, 165);
			this.dataOperadorVehiculo.MultiSelect = false;
			this.dataOperadorVehiculo.Name = "dataOperadorVehiculo";
			this.dataOperadorVehiculo.ReadOnly = true;
			this.dataOperadorVehiculo.RowHeadersVisible = false;
			this.dataOperadorVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataOperadorVehiculo.Size = new System.Drawing.Size(450, 293);
			this.dataOperadorVehiculo.TabIndex = 192;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "ID_UNIDAD";
			this.Column4.HeaderText = "ID_Unidad";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Visible = false;
			this.Column4.Width = 87;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "ID_OPERADOR";
			this.Column5.HeaderText = "ID_Operador";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Visible = false;
			this.Column5.Width = 103;
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "OPERADOR";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column9.FillWeight = 3.032139F;
			this.Column9.HeaderText = "Alias";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 68;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "UNIDAD";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column10.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column10.FillWeight = 27.89569F;
			this.Column10.HeaderText = "Numero";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 87;
			// 
			// Column11
			// 
			this.Column11.DataPropertyName = "ESTATUS";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column11.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column11.FillWeight = 269.0722F;
			this.Column11.HeaderText = "Estatus";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.Width = 84;
			// 
			// Marca
			// 
			this.Marca.DataPropertyName = "MARCA";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Marca.DefaultCellStyle = dataGridViewCellStyle5;
			this.Marca.HeaderText = "Marca";
			this.Marca.Name = "Marca";
			this.Marca.ReadOnly = true;
			this.Marca.Width = 76;
			// 
			// FormESvehiculos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1019, 470);
			this.Controls.Add(this.dataOperadorVehiculo);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dgvHistorialOV);
			this.Controls.Add(this.pPrincipal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormESvehiculos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Entradas - Salidas de vehiculos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormESvehiculosFormClosing);
			this.Load += new System.EventHandler(this.FormESvehiculosLoad);
			this.pPrincipal.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorialOV)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataOperadorVehiculo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridView dataOperadorVehiculo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnLimpiar;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNumero;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataHora;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataIDV;
		private System.Windows.Forms.DataGridViewTextBoxColumn DATAIDO;
		private System.Windows.Forms.DataGridView dgvHistorialOV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtTipoUnidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdUnidad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtOperacion;
		private System.Windows.Forms.TextBox txtResponsable;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNumOperacion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIdOP;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtAliasAnticipos;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtNombreAnticipos;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Panel pPrincipal;
	}
}
