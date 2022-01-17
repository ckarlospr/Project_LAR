/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 11/07/2012
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Usuario
{
	partial class FormBusquedaUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusquedaUsuario));
			this.label6 = new System.Windows.Forms.Label();
			this.dataUsuario = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estatus = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
			this.txtUsuarioApellidoP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUsuarioApellidoM = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbTodos = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(96, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(313, 14);
			this.label6.TabIndex = 8;
			this.label6.Text = "Ingrese los datos del usuario para realizar la búsqueda:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataUsuario
			// 
			this.dataUsuario.AllowUserToAddRows = false;
			this.dataUsuario.AllowUserToDeleteRows = false;
			this.dataUsuario.AllowUserToResizeRows = false;
			this.dataUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataUsuario.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.estatus});
			this.dataUsuario.Location = new System.Drawing.Point(17, 209);
			this.dataUsuario.Name = "dataUsuario";
			this.dataUsuario.ReadOnly = true;
			this.dataUsuario.RowHeadersVisible = false;
			this.dataUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataUsuario.Size = new System.Drawing.Size(1006, 457);
			this.dataUsuario.TabIndex = 7;
			this.dataUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUsuarioCellContentClick);
			this.dataUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUsuarioCellDoubleClick);
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
			this.Column2.DataPropertyName = "dataUsuario";
			this.Column2.HeaderText = "Usuario";
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
			this.Column4.DataPropertyName = "dataApellidoP";
			this.Column4.HeaderText = "Apellido paterno";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 130;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "dataApellidoM";
			this.Column5.HeaderText = "Apellido materno";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 130;
			// 
			// estatus
			// 
			this.estatus.DataPropertyName = "Estado";
			this.estatus.HeaderText = "Estado";
			this.estatus.Name = "estatus";
			this.estatus.ReadOnly = true;
			this.estatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.estatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.cbTodos);
			this.panel2.Controls.Add(this.btnModificar);
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Controls.Add(this.txtUsuario);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtUsuarioNombre);
			this.panel2.Controls.Add(this.txtUsuarioApellidoP);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtUsuarioApellidoM);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(17, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1006, 152);
			this.panel2.TabIndex = 9;
			// 
			// btnModificar
			// 
			this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModificar.Location = new System.Drawing.Point(815, 108);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(88, 30);
			this.btnModificar.TabIndex = 5;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(909, 108);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(88, 30);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(112, 37);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(185, 20);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuarioNombreTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 14);
			this.label4.TabIndex = 41;
			this.label4.Text = "Nombre usuario:";
			// 
			// txtUsuarioNombre
			// 
			this.txtUsuarioNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuarioNombre.Location = new System.Drawing.Point(112, 63);
			this.txtUsuarioNombre.Name = "txtUsuarioNombre";
			this.txtUsuarioNombre.Size = new System.Drawing.Size(185, 20);
			this.txtUsuarioNombre.TabIndex = 2;
			this.txtUsuarioNombre.TextChanged += new System.EventHandler(this.TxtUsuarioNombreTextChanged);
			// 
			// txtUsuarioApellidoP
			// 
			this.txtUsuarioApellidoP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuarioApellidoP.Location = new System.Drawing.Point(112, 89);
			this.txtUsuarioApellidoP.Name = "txtUsuarioApellidoP";
			this.txtUsuarioApellidoP.Size = new System.Drawing.Size(185, 20);
			this.txtUsuarioApellidoP.TabIndex = 3;
			this.txtUsuarioApellidoP.TextChanged += new System.EventHandler(this.TxtUsuarioNombreTextChanged);
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
			// txtUsuarioApellidoM
			// 
			this.txtUsuarioApellidoM.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuarioApellidoM.Location = new System.Drawing.Point(112, 115);
			this.txtUsuarioApellidoM.Name = "txtUsuarioApellidoM";
			this.txtUsuarioApellidoM.Size = new System.Drawing.Size(185, 20);
			this.txtUsuarioApellidoM.TabIndex = 4;
			this.txtUsuarioApellidoM.TextChanged += new System.EventHandler(this.TxtUsuarioNombreTextChanged);
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
			this.label1.Location = new System.Drawing.Point(-1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1004, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "Datos personales del usuario:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(18, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 42);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(1036, 76);
			this.label7.TabIndex = 12;
			// 
			// cbTodos
			// 
			this.cbTodos.AutoSize = true;
			this.cbTodos.Location = new System.Drawing.Point(322, 40);
			this.cbTodos.Name = "cbTodos";
			this.cbTodos.Size = new System.Drawing.Size(89, 17);
			this.cbTodos.TabIndex = 49;
			this.cbTodos.Text = "Mostrar Todo";
			this.cbTodos.UseVisualStyleBackColor = true;
			this.cbTodos.CheckedChanged += new System.EventHandler(this.CbTodosCheckedChanged);
			// 
			// FormBusquedaUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(1037, 672);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataUsuario);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBusquedaUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Busqueda de usuario";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBusquedaUsuarioFormClosing);
			this.Load += new System.EventHandler(this.FormBusquedaUsuarioLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataUsuario)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox cbTodos;
		private System.Windows.Forms.DataGridViewButtonColumn estatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataUsuario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsuarioApellidoM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsuarioApellidoP;
		private System.Windows.Forms.TextBox txtUsuarioNombre;
		private System.Windows.Forms.Label label6;
	}
}
