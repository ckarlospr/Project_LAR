/*
 * Created by SharpDevelop.
 * User: Sistemas
 * Date: 03/05/2017
 * Time: 11:10 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	partial class FormTelefonos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelefonos));
			this.label6 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtNumeroContacto = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtNombreContacto = new System.Windows.Forms.TextBox();
			this.cmbTipoContacto = new System.Windows.Forms.ComboBox();
			this.dgContacto = new System.Windows.Forms.DataGridView();
			this.cmbRelacionContacto = new System.Windows.Forms.ComboBox();
			this.btnAgregarContacto = new System.Windows.Forms.Button();
			this.btnCancelarContacto = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RELACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.e = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgContacto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(478, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 78;
			this.label6.Text = ":Relación";
			// 
			// label26
			// 
			this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label26.Location = new System.Drawing.Point(478, 12);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(34, 18);
			this.label26.TabIndex = 74;
			this.label26.Text = ":Tipo";
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(478, 37);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(47, 13);
			this.label16.TabIndex = 76;
			this.label16.Text = ":Número";
			// 
			// txtNumeroContacto
			// 
			this.txtNumeroContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNumeroContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumeroContacto.Location = new System.Drawing.Point(365, 32);
			this.txtNumeroContacto.MaxLength = 15;
			this.txtNumeroContacto.Name = "txtNumeroContacto";
			this.txtNumeroContacto.Size = new System.Drawing.Size(110, 20);
			this.txtNumeroContacto.TabIndex = 75;
			this.txtNumeroContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNumeroContacto.Enter += new System.EventHandler(this.TxtNumeroContactoEnter);
			this.txtNumeroContacto.Leave += new System.EventHandler(this.TxtNumeroContactoLeave);
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(478, 81);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(47, 13);
			this.label15.TabIndex = 80;
			this.label15.Text = ":Nombre";
			// 
			// txtNombreContacto
			// 
			this.txtNombreContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombreContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombreContacto.Location = new System.Drawing.Point(365, 77);
			this.txtNombreContacto.MaxLength = 100;
			this.txtNombreContacto.Name = "txtNombreContacto";
			this.txtNombreContacto.Size = new System.Drawing.Size(110, 20);
			this.txtNombreContacto.TabIndex = 79;
			this.txtNombreContacto.Text = "PROPIO";
			this.txtNombreContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtNombreContacto.Click += new System.EventHandler(this.TxtNombreContactoClick);
			// 
			// cmbTipoContacto
			// 
			this.cmbTipoContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbTipoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoContacto.FormattingEnabled = true;
			this.cmbTipoContacto.Items.AddRange(new object[] {
									"CELULAR",
									"FIJO"});
			this.cmbTipoContacto.Location = new System.Drawing.Point(365, 9);
			this.cmbTipoContacto.Name = "cmbTipoContacto";
			this.cmbTipoContacto.Size = new System.Drawing.Size(110, 21);
			this.cmbTipoContacto.TabIndex = 73;
			this.cmbTipoContacto.Tag = "";
			// 
			// dgContacto
			// 
			this.dgContacto.AllowUserToAddRows = false;
			this.dgContacto.AllowUserToDeleteRows = false;
			this.dgContacto.AllowUserToResizeRows = false;
			this.dgContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgContacto.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dgContacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgContacto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.Tipo,
									this.Numero,
									this.RELACION,
									this.Descripcion,
									this.ESTATUS,
									this.e});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgContacto.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgContacto.Location = new System.Drawing.Point(6, 9);
			this.dgContacto.Margin = new System.Windows.Forms.Padding(2);
			this.dgContacto.MultiSelect = false;
			this.dgContacto.Name = "dgContacto";
			this.dgContacto.ReadOnly = true;
			this.dgContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgContacto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgContacto.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgContacto.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgContacto.RowTemplate.Height = 24;
			this.dgContacto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgContacto.Size = new System.Drawing.Size(353, 120);
			this.dgContacto.TabIndex = 82;
			this.dgContacto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgContactoCellClick);
			this.dgContacto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgContactoCellDoubleClick);
			// 
			// cmbRelacionContacto
			// 
			this.cmbRelacionContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbRelacionContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRelacionContacto.FormattingEnabled = true;
			this.cmbRelacionContacto.Items.AddRange(new object[] {
									"PROPIO",
									"ESPOSA(O)",
									"HIJO(A)",
									"FAMILIAR",
									"CONOCIDO"});
			this.cmbRelacionContacto.Location = new System.Drawing.Point(365, 54);
			this.cmbRelacionContacto.Name = "cmbRelacionContacto";
			this.cmbRelacionContacto.Size = new System.Drawing.Size(110, 21);
			this.cmbRelacionContacto.TabIndex = 77;
			// 
			// btnAgregarContacto
			// 
			this.btnAgregarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarContacto.Image")));
			this.btnAgregarContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregarContacto.Location = new System.Drawing.Point(365, 100);
			this.btnAgregarContacto.Name = "btnAgregarContacto";
			this.btnAgregarContacto.Size = new System.Drawing.Size(77, 31);
			this.btnAgregarContacto.TabIndex = 81;
			this.btnAgregarContacto.Text = "Agregar";
			this.btnAgregarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregarContacto.UseVisualStyleBackColor = true;
			this.btnAgregarContacto.Click += new System.EventHandler(this.BtnAgregarContactoClick);
			// 
			// btnCancelarContacto
			// 
			this.btnCancelarContacto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelarContacto.AutoSize = true;
			this.btnCancelarContacto.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarContacto.Image")));
			this.btnCancelarContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelarContacto.Location = new System.Drawing.Point(445, 100);
			this.btnCancelarContacto.Name = "btnCancelarContacto";
			this.btnCancelarContacto.Size = new System.Drawing.Size(30, 31);
			this.btnCancelarContacto.TabIndex = 83;
			this.btnCancelarContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelarContacto.UseVisualStyleBackColor = true;
			this.btnCancelarContacto.Click += new System.EventHandler(this.BtnCancelarContactoClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ID.Visible = false;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Tipo.Width = 65;
			// 
			// Numero
			// 
			this.Numero.HeaderText = "Número";
			this.Numero.Name = "Numero";
			this.Numero.ReadOnly = true;
			this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Numero.Width = 80;
			// 
			// RELACION
			// 
			this.RELACION.HeaderText = "Relación";
			this.RELACION.Name = "RELACION";
			this.RELACION.ReadOnly = true;
			this.RELACION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.RELACION.Width = 80;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Nombre";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// ESTATUS
			// 
			this.ESTATUS.HeaderText = "ESTATUS";
			this.ESTATUS.Name = "ESTATUS";
			this.ESTATUS.ReadOnly = true;
			this.ESTATUS.Visible = false;
			// 
			// e
			// 
			this.e.HeaderText = "#";
			this.e.Name = "e";
			this.e.ReadOnly = true;
			this.e.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.e.Width = 25;
			// 
			// FormTelefonos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 136);
			this.Controls.Add(this.btnCancelarContacto);
			this.Controls.Add(this.btnAgregarContacto);
			this.Controls.Add(this.cmbRelacionContacto);
			this.Controls.Add(this.dgContacto);
			this.Controls.Add(this.cmbTipoContacto);
			this.Controls.Add(this.txtNombreContacto);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtNumeroContacto);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(550, 175);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 175);
			this.Name = "FormTelefonos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Numeros de Contacto:";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTelefonosFormClosing);
			this.Load += new System.EventHandler(this.FormTelefonosLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormTelefonosKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.dgContacto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
		private System.Windows.Forms.DataGridViewImageColumn e;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnCancelarContacto;
		private System.Windows.Forms.Button btnAgregarContacto;
		private System.Windows.Forms.ComboBox cmbRelacionContacto;
		public System.Windows.Forms.DataGridView dgContacto;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn RELACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.ComboBox cmbTipoContacto;
		private System.Windows.Forms.TextBox txtNombreContacto;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtNumeroContacto;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label6;
	}
}
