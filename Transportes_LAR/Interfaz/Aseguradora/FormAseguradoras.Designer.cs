/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 09/08/2012
 * Time: 9:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Aseguradora
{
	partial class FormAseguradoras
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAseguradoras));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvAseguradora = new System.Windows.Forms.DataGridView();
			this.aID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.aTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cancelar = new System.Windows.Forms.Button();
			this.btnAgregarModificar = new System.Windows.Forms.Button();
			this.btnAnadirSeguros = new System.Windows.Forms.Button();
			this.ListaImagenes = new System.Windows.Forms.ImageList(this.components);
			this.TimeImage = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAseguradora)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDomicilio);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(6, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(281, 101);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Aseguradora";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Enabled = false;
			this.txtTelefono.Location = new System.Drawing.Point(109, 70);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(157, 20);
			this.txtTelefono.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Telefono:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Enabled = false;
			this.txtDomicilio.Location = new System.Drawing.Point(109, 43);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(157, 20);
			this.txtDomicilio.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Domicilio:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombre
			// 
			this.txtNombre.Enabled = false;
			this.txtNombre.Location = new System.Drawing.Point(108, 17);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(157, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.groupBox2.Controls.Add(this.dgvAseguradora);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(6, 150);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 449);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lista de aseguradoras";
			// 
			// dgvAseguradora
			// 
			this.dgvAseguradora.AllowUserToAddRows = false;
			this.dgvAseguradora.AllowUserToDeleteRows = false;
			this.dgvAseguradora.AllowUserToOrderColumns = true;
			this.dgvAseguradora.AllowUserToResizeRows = false;
			this.dgvAseguradora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAseguradora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAseguradora.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dgvAseguradora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvAseguradora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
			this.dgvAseguradora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvAseguradora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAseguradora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.aID,
									this.aNombre,
									this.aDir,
									this.aTel});
			this.dgvAseguradora.EnableHeadersVisualStyles = false;
			this.dgvAseguradora.Location = new System.Drawing.Point(7, 16);
			this.dgvAseguradora.MultiSelect = false;
			this.dgvAseguradora.Name = "dgvAseguradora";
			this.dgvAseguradora.ReadOnly = true;
			this.dgvAseguradora.RowHeadersVisible = false;
			this.dgvAseguradora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAseguradora.Size = new System.Drawing.Size(267, 417);
			this.dgvAseguradora.TabIndex = 7;
			this.dgvAseguradora.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAseguradoraCellEnter);
			// 
			// aID
			// 
			this.aID.DataPropertyName = "dataID";
			this.aID.HeaderText = "ID";
			this.aID.Name = "aID";
			this.aID.ReadOnly = true;
			this.aID.Visible = false;
			// 
			// aNombre
			// 
			this.aNombre.DataPropertyName = "dataNombre";
			this.aNombre.HeaderText = "Nombre";
			this.aNombre.Name = "aNombre";
			this.aNombre.ReadOnly = true;
			// 
			// aDir
			// 
			this.aDir.DataPropertyName = "dataDir";
			this.aDir.HeaderText = "Direccion";
			this.aDir.Name = "aDir";
			this.aDir.ReadOnly = true;
			this.aDir.Visible = false;
			// 
			// aTel
			// 
			this.aTel.DataPropertyName = "dataTel";
			this.aTel.HeaderText = "Telefono";
			this.aTel.Name = "aTel";
			this.aTel.ReadOnly = true;
			this.aTel.Visible = false;
			// 
			// Cancelar
			// 
			this.Cancelar.BackColor = System.Drawing.Color.Transparent;
			this.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
			this.Cancelar.FlatAppearance.BorderSize = 2;
			this.Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
			this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
			this.Cancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
			this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Cancelar.Location = new System.Drawing.Point(198, 116);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(88, 28);
			this.Cancelar.TabIndex = 6;
			this.Cancelar.Text = "Cancelar";
			this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Cancelar.UseVisualStyleBackColor = false;
			this.Cancelar.Click += new System.EventHandler(this.CancelarClick);
			// 
			// btnAgregarModificar
			// 
			this.btnAgregarModificar.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregarModificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarModificar.Image")));
			this.btnAgregarModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarModificar.Location = new System.Drawing.Point(106, 116);
			this.btnAgregarModificar.Name = "btnAgregarModificar";
			this.btnAgregarModificar.Size = new System.Drawing.Size(82, 28);
			this.btnAgregarModificar.TabIndex = 5;
			this.btnAgregarModificar.Text = "Nuevo";
			this.btnAgregarModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregarModificar.UseVisualStyleBackColor = false;
			this.btnAgregarModificar.Click += new System.EventHandler(this.BtnAgregarModificarClick);
			// 
			// btnAnadirSeguros
			// 
			this.btnAnadirSeguros.BackColor = System.Drawing.Color.Transparent;
			this.btnAnadirSeguros.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnadirSeguros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnadirSeguros.Image = ((System.Drawing.Image)(resources.GetObject("btnAnadirSeguros.Image")));
			this.btnAnadirSeguros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAnadirSeguros.Location = new System.Drawing.Point(7, 116);
			this.btnAnadirSeguros.Name = "btnAnadirSeguros";
			this.btnAnadirSeguros.Size = new System.Drawing.Size(85, 28);
			this.btnAnadirSeguros.TabIndex = 4;
			this.btnAnadirSeguros.Text = "Seguros";
			this.btnAnadirSeguros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAnadirSeguros.UseVisualStyleBackColor = false;
			this.btnAnadirSeguros.Click += new System.EventHandler(this.BtnAnadirSegurosClick);
			// 
			// ListaImagenes
			// 
			this.ListaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListaImagenes.ImageStream")));
			this.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent;
			this.ListaImagenes.Images.SetKeyName(0, "Cancelar.png");
			this.ListaImagenes.Images.SetKeyName(1, "Guardar_opt.png");
			this.ListaImagenes.Images.SetKeyName(2, "kword_24x24-32.gif");
			this.ListaImagenes.Images.SetKeyName(3, "kthememgr_32x32-32.gif");
			// 
			// TimeImage
			// 
			this.TimeImage.Enabled = true;
			this.TimeImage.Tick += new System.EventHandler(this.TimeImageTick);
			// 
			// FormAseguradoras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(294, 615);
			this.Controls.Add(this.btnAnadirSeguros);
			this.Controls.Add(this.btnAgregarModificar);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAseguradoras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Transportes LAR - Aseguradoras";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAseguradorasFormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAseguradora)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer TimeImage;
		private System.Windows.Forms.ImageList ListaImagenes;
		private System.Windows.Forms.Button btnAnadirSeguros;
		private System.Windows.Forms.DataGridViewTextBoxColumn aTel;
		private System.Windows.Forms.DataGridViewTextBoxColumn aDir;
		private System.Windows.Forms.DataGridView dgvAseguradora;
		public System.Windows.Forms.TextBox txtTelefono;
		public System.Windows.Forms.TextBox txtDomicilio;
		public System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnAgregarModificar;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn aNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn aID;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
