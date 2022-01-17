/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 06/10/2016
 * Time: 11:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	partial class FormSueldoReal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSueldoReal));
			this.panel4 = new System.Windows.Forms.Panel();
			this.label49 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnTE = new System.Windows.Forms.Panel();
			this.rbToperador = new System.Windows.Forms.RadioButton();
			this.rbTadministrativo = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.pnTS = new System.Windows.Forms.Panel();
			this.rbTcatorcena = new System.Windows.Forms.RadioButton();
			this.rbTsemanal = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSueldo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgSueldos = new System.Windows.Forms.DataGridView();
			this.id_sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_opera = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ALIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnTE.SuspendLayout();
			this.pnTS.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgSueldos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel4.Controls.Add(this.label49);
			this.panel4.Location = new System.Drawing.Point(0, 6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(494, 27);
			this.panel4.TabIndex = 104;
			// 
			// label49
			// 
			this.label49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label49.BackColor = System.Drawing.Color.Transparent;
			this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label49.Location = new System.Drawing.Point(24, 5);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(451, 15);
			this.label49.TabIndex = 0;
			this.label49.Text = "Nuevo Sueldo FIJO";
			this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pnTE);
			this.groupBox1.Controls.Add(this.pnTS);
			this.groupBox1.Controls.Add(this.txtSueldo);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtEmpleado);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.panel4);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(494, 109);
			this.groupBox1.TabIndex = 105;
			this.groupBox1.TabStop = false;
			// 
			// pnTE
			// 
			this.pnTE.Controls.Add(this.rbToperador);
			this.pnTE.Controls.Add(this.rbTadministrativo);
			this.pnTE.Controls.Add(this.label8);
			this.pnTE.Enabled = false;
			this.pnTE.Location = new System.Drawing.Point(173, 75);
			this.pnTE.Name = "pnTE";
			this.pnTE.Size = new System.Drawing.Size(239, 25);
			this.pnTE.TabIndex = 114;
			// 
			// rbToperador
			// 
			this.rbToperador.Checked = true;
			this.rbToperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbToperador.Location = new System.Drawing.Point(163, 4);
			this.rbToperador.Name = "rbToperador";
			this.rbToperador.Size = new System.Drawing.Size(73, 19);
			this.rbToperador.TabIndex = 109;
			this.rbToperador.TabStop = true;
			this.rbToperador.Text = "Operador";
			this.rbToperador.UseVisualStyleBackColor = true;
			// 
			// rbTadministrativo
			// 
			this.rbTadministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTadministrativo.Location = new System.Drawing.Point(72, 5);
			this.rbTadministrativo.Name = "rbTadministrativo";
			this.rbTadministrativo.Size = new System.Drawing.Size(90, 15);
			this.rbTadministrativo.TabIndex = 108;
			this.rbTadministrativo.Text = "Administrativo";
			this.rbTadministrativo.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(4, 4);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 15);
			this.label8.TabIndex = 110;
			this.label8.Text = "Tipo de Emp:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnTS
			// 
			this.pnTS.Controls.Add(this.rbTcatorcena);
			this.pnTS.Controls.Add(this.rbTsemanal);
			this.pnTS.Controls.Add(this.label7);
			this.pnTS.Enabled = false;
			this.pnTS.Location = new System.Drawing.Point(173, 46);
			this.pnTS.Name = "pnTS";
			this.pnTS.Size = new System.Drawing.Size(239, 25);
			this.pnTS.TabIndex = 113;
			// 
			// rbTcatorcena
			// 
			this.rbTcatorcena.Checked = true;
			this.rbTcatorcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTcatorcena.Location = new System.Drawing.Point(162, 5);
			this.rbTcatorcena.Name = "rbTcatorcena";
			this.rbTcatorcena.Size = new System.Drawing.Size(76, 15);
			this.rbTcatorcena.TabIndex = 14;
			this.rbTcatorcena.TabStop = true;
			this.rbTcatorcena.Text = "Catorcenal";
			this.rbTcatorcena.UseVisualStyleBackColor = true;
			// 
			// rbTsemanal
			// 
			this.rbTsemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbTsemanal.Location = new System.Drawing.Point(89, 4);
			this.rbTsemanal.Name = "rbTsemanal";
			this.rbTsemanal.Size = new System.Drawing.Size(71, 15);
			this.rbTsemanal.TabIndex = 15;
			this.rbTsemanal.Text = "Semanal";
			this.rbTsemanal.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(5, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 15);
			this.label7.TabIndex = 107;
			this.label7.Text = "Tipo de Sueldo:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSueldo
			// 
			this.txtSueldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSueldo.Enabled = false;
			this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSueldo.Location = new System.Drawing.Point(61, 78);
			this.txtSueldo.Name = "txtSueldo";
			this.txtSueldo.Size = new System.Drawing.Size(106, 20);
			this.txtSueldo.TabIndex = 112;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 79);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 15);
			this.label9.TabIndex = 111;
			this.label9.Text = "Sueldo:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpleado.Location = new System.Drawing.Point(61, 46);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(106, 20);
			this.txtEmpleado.TabIndex = 106;
			this.txtEmpleado.TextChanged += new System.EventHandler(this.TxtEmpleadoTextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(2, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 15);
			this.label6.TabIndex = 105;
			this.label6.Text = "Empleado:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(418, 53);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(70, 40);
			this.btnAgregar.TabIndex = 29;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel3.Location = new System.Drawing.Point(0, 107);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(500, 11);
			this.panel3.TabIndex = 105;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.Location = new System.Drawing.Point(96, 731);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(136, 20);
			this.txtBuscar.TabIndex = 114;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 732);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 15);
			this.label1.TabIndex = 113;
			this.label1.Text = "Buscar por Alias:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgSueldos
			// 
			this.dgSueldos.AllowUserToAddRows = false;
			this.dgSueldos.AllowUserToDeleteRows = false;
			this.dgSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgSueldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgSueldos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_sueldo,
									this.id_opera,
									this.ALIAS,
									this.NOMBRE,
									this.TIPO_EMPLEADO,
									this.TIPO_SUELDO,
									this.SUELDO});
			this.dgSueldos.Location = new System.Drawing.Point(3, 122);
			this.dgSueldos.Name = "dgSueldos";
			this.dgSueldos.RowHeadersVisible = false;
			this.dgSueldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgSueldos.Size = new System.Drawing.Size(494, 603);
			this.dgSueldos.TabIndex = 115;
			this.dgSueldos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSueldosCellClick);
			// 
			// id_sueldo
			// 
			this.id_sueldo.HeaderText = "id_sueldo";
			this.id_sueldo.Name = "id_sueldo";
			this.id_sueldo.Visible = false;
			// 
			// id_opera
			// 
			this.id_opera.HeaderText = "id_opera";
			this.id_opera.Name = "id_opera";
			this.id_opera.Visible = false;
			// 
			// ALIAS
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ALIAS.DefaultCellStyle = dataGridViewCellStyle1;
			this.ALIAS.FillWeight = 80F;
			this.ALIAS.HeaderText = "ALIAS";
			this.ALIAS.Name = "ALIAS";
			this.ALIAS.ReadOnly = true;
			// 
			// NOMBRE
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle2;
			this.NOMBRE.FillWeight = 150F;
			this.NOMBRE.HeaderText = "NOMBRE";
			this.NOMBRE.Name = "NOMBRE";
			this.NOMBRE.ReadOnly = true;
			this.NOMBRE.Visible = false;
			// 
			// TIPO_EMPLEADO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TIPO_EMPLEADO.DefaultCellStyle = dataGridViewCellStyle3;
			this.TIPO_EMPLEADO.FillWeight = 70F;
			this.TIPO_EMPLEADO.HeaderText = "TIPO EMPLEADO";
			this.TIPO_EMPLEADO.Name = "TIPO_EMPLEADO";
			this.TIPO_EMPLEADO.ReadOnly = true;
			// 
			// TIPO_SUELDO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TIPO_SUELDO.DefaultCellStyle = dataGridViewCellStyle4;
			this.TIPO_SUELDO.FillWeight = 70F;
			this.TIPO_SUELDO.HeaderText = "TIPO SUELDO";
			this.TIPO_SUELDO.Name = "TIPO_SUELDO";
			this.TIPO_SUELDO.ReadOnly = true;
			// 
			// SUELDO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SUELDO.DefaultCellStyle = dataGridViewCellStyle5;
			this.SUELDO.FillWeight = 65.65144F;
			this.SUELDO.HeaderText = "SUELDO";
			this.SUELDO.Name = "SUELDO";
			this.SUELDO.ReadOnly = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Enabled = false;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.Location = new System.Drawing.Point(465, 731);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(24, 24);
			this.btnCancelar.TabIndex = 115;
			this.btnCancelar.Tag = "Cancelar modificación";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// FormSueldoReal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 756);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.dgSueldos);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(517, 795);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(517, 795);
			this.Name = "FormSueldoReal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sueldo Real";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSueldoRealFormClosing);
			this.Load += new System.EventHandler(this.FormSueldoRealLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormSueldoRealKeyUp);
			this.panel4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.pnTE.ResumeLayout(false);
			this.pnTS.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgSueldos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_opera;
		private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_SUELDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_EMPLEADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ALIAS;
		public System.Windows.Forms.DataGridView dgSueldos;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_sueldo;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pnTE;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rbTsemanal;
		private System.Windows.Forms.RadioButton rbTcatorcena;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RadioButton rbToperador;
		private System.Windows.Forms.RadioButton rbTadministrativo;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.TextBox txtSueldo;
		private System.Windows.Forms.Panel pnTS;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Panel panel4;
	}
}
