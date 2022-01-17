/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 12/07/2012
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador
{
	partial class FormBusquedaOperador
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusquedaOperador));
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbTodos = new System.Windows.Forms.CheckBox();
			this.dataEmpleado = new System.Windows.Forms.DataGridView();
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataOperador = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataOperador)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.cbTodos);
			this.panel2.Controls.Add(this.dataEmpleado);
			this.panel2.Controls.Add(this.btnExcel);
			this.panel2.Controls.Add(this.btnNuevo);
			this.panel2.Controls.Add(this.btnModificar);
			this.panel2.Controls.Add(this.txtAlias);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.txtApellidoP);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtApellidoM);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(695, 152);
			this.panel2.TabIndex = 10;
			// 
			// cbTodos
			// 
			this.cbTodos.AutoSize = true;
			this.cbTodos.Location = new System.Drawing.Point(331, 40);
			this.cbTodos.Name = "cbTodos";
			this.cbTodos.Size = new System.Drawing.Size(89, 17);
			this.cbTodos.TabIndex = 5;
			this.cbTodos.Text = "Mostrar Todo";
			this.cbTodos.UseVisualStyleBackColor = true;
			this.cbTodos.CheckedChanged += new System.EventHandler(this.CbTodosCheckedChanged);
			// 
			// dataEmpleado
			// 
			this.dataEmpleado.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dataEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataEmpleado.Location = new System.Drawing.Point(677, 3);
			this.dataEmpleado.Name = "dataEmpleado";
			this.dataEmpleado.Size = new System.Drawing.Size(11, 12);
			this.dataEmpleado.TabIndex = 47;
			this.dataEmpleado.Visible = false;
			// 
			// btnExcel
			// 
			this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcel.Location = new System.Drawing.Point(569, 107);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(114, 25);
			this.btnExcel.TabIndex = 8;
			this.btnExcel.Text = "Reporte Excel";
			this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcel.UseVisualStyleBackColor = true;
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNuevo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(569, 49);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(114, 23);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo...";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(569, 78);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(114, 23);
			this.btnModificar.TabIndex = 7;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// txtAlias
			// 
			this.txtAlias.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAlias.Location = new System.Drawing.Point(112, 37);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(185, 20);
			this.txtAlias.TabIndex = 1;
			this.txtAlias.TextChanged += new System.EventHandler(this.TxtAliasTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(74, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 14);
			this.label4.TabIndex = 41;
			this.label4.Text = "Alias:";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(112, 63);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(185, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.TextChanged += new System.EventHandler(this.TxtAliasTextChanged);
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoP.Location = new System.Drawing.Point(112, 89);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(185, 20);
			this.txtApellidoP.TabIndex = 3;
			this.txtApellidoP.TextChanged += new System.EventHandler(this.TxtAliasTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(48, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 14);
			this.label2.TabIndex = 35;
			this.label2.Text = "Nombre(s):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 14);
			this.label3.TabIndex = 39;
			this.label3.Text = "Apellido paterno:";
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoM.Location = new System.Drawing.Point(112, 115);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(185, 20);
			this.txtApellidoM.TabIndex = 4;
			this.txtApellidoM.TextChanged += new System.EventHandler(this.TxtAliasTextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 14);
			this.label5.TabIndex = 37;
			this.label5.Text = "Apellido materno:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(693, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "Datos personales del usuario:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataOperador
			// 
			this.dataOperador.AllowUserToAddRows = false;
			this.dataOperador.AllowUserToDeleteRows = false;
			this.dataOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataOperador.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOperador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column6});
			this.dataOperador.Location = new System.Drawing.Point(12, 223);
			this.dataOperador.Name = "dataOperador";
			this.dataOperador.ReadOnly = true;
			this.dataOperador.RowHeadersVisible = false;
			this.dataOperador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataOperador.Size = new System.Drawing.Size(696, 313);
			this.dataOperador.TabIndex = 9;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "dataID";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.DataPropertyName = "dataAlias";
			this.Column2.HeaderText = "Alias";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "dataNombre";
			this.Column3.HeaderText = "Nombre(s)";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "dataApellidoPat";
			this.Column4.HeaderText = "Apellido pat.";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 150;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "dataApellidoMat";
			this.Column5.HeaderText = "Apellido mat.";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 150;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "dataEstado";
			this.Column6.HeaderText = "Estado";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column6.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(-4, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(733, 86);
			this.panel1.TabIndex = 15;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(18, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(70, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(322, 14);
			this.label6.TabIndex = 11;
			this.label6.Text = "Ingrese los datos del operador para realizar la búsqueda:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormBusquedaOperador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(725, 541);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataOperador);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBusquedaOperador";
			this.Text = "Transportes LAR - Busqueda de Operador";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBusquedaOperadorFormClosing);
			this.Load += new System.EventHandler(this.FormBusquedaOperadorLoad);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataOperador)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox cbTodos;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataEmpleado;
		private System.Windows.Forms.Button btnExcel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.DataGridViewButtonColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataOperador;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
	}
}
