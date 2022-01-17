/*
 * Creado por SharpDevelop.
 * Usuario: Xavi
 * Fecha: 13/10/2014
 * Hora: 08:36 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormReporteBonificaciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteBonificaciones));
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.txtAlias = new System.Windows.Forms.TextBox();
			this.dataBonos = new System.Windows.Forms.DataGridView();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ap_pat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ap_mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnExcel = new System.Windows.Forms.ToolStripButton();
			this.groupBox12.SuspendLayout();
			this.groupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBonos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox12
			// 
			this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox12.BackColor = System.Drawing.Color.Transparent;
			this.groupBox12.Controls.Add(this.dtInicio);
			this.groupBox12.Controls.Add(this.label13);
			this.groupBox12.Controls.Add(this.dtCorte);
			this.groupBox12.Controls.Add(this.lblFechaCorte);
			this.groupBox12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox12.Location = new System.Drawing.Point(437, 28);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(286, 46);
			this.groupBox12.TabIndex = 154;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Periodo de Reporte";
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(64, 17);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(76, 20);
			this.dtInicio.TabIndex = 142;
			this.dtInicio.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dtInicio.ValueChanged += new System.EventHandler(this.DtInicioValueChanged);
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(26, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 22);
			this.label13.TabIndex = 140;
			this.label13.Text = "Inicio:";
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(186, 17);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(83, 20);
			this.dtCorte.TabIndex = 143;
			this.dtCorte.ValueChanged += new System.EventHandler(this.DtCorteValueChanged);
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(143, 19);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(47, 18);
			this.lblFechaCorte.TabIndex = 141;
			this.lblFechaCorte.Text = "Corte:";
			// 
			// groupBox18
			// 
			this.groupBox18.BackColor = System.Drawing.Color.Transparent;
			this.groupBox18.Controls.Add(this.txtAlias);
			this.groupBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(5, 28);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(253, 45);
			this.groupBox18.TabIndex = 153;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Busqueda del Operador por Nick";
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtAlias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAlias.Enabled = false;
			this.txtAlias.Location = new System.Drawing.Point(6, 16);
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(237, 20);
			this.txtAlias.TabIndex = 0;
			this.txtAlias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtAliasKeyUp);
			// 
			// dataBonos
			// 
			this.dataBonos.AllowUserToAddRows = false;
			this.dataBonos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataBonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataBonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataBonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataBonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Fecha,
									this.Alias,
									this.Nombre,
									this.Ap_pat,
									this.Ap_mat,
									this.Tipo,
									this.Motivo,
									this.Usuario});
			this.dataBonos.Location = new System.Drawing.Point(8, 80);
			this.dataBonos.Name = "dataBonos";
			this.dataBonos.RowHeadersVisible = false;
			this.dataBonos.Size = new System.Drawing.Size(717, 366);
			this.dataBonos.TabIndex = 156;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// Alias
			// 
			this.Alias.HeaderText = "Alias";
			this.Alias.Name = "Alias";
			this.Alias.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Ap_pat
			// 
			this.Ap_pat.HeaderText = "Apellido Paterno";
			this.Ap_pat.Name = "Ap_pat";
			this.Ap_pat.ReadOnly = true;
			// 
			// Ap_mat
			// 
			this.Ap_mat.HeaderText = "Apellido Materno";
			this.Ap_mat.Name = "Ap_mat";
			this.Ap_mat.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// Motivo
			// 
			this.Motivo.HeaderText = "Motivo";
			this.Motivo.Name = "Motivo";
			this.Motivo.ReadOnly = true;
			// 
			// Usuario
			// 
			this.Usuario.HeaderText = "Usuario";
			this.Usuario.Name = "Usuario";
			this.Usuario.ReadOnly = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Enabled = false;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnExcel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(732, 25);
			this.toolStrip1.TabIndex = 157;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnExcel
			// 
			this.btnExcel.Enabled = false;
			this.btnExcel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
			this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(113, 22);
			this.btnExcel.Text = "Exportar a Excel";
			this.btnExcel.Click += new System.EventHandler(this.BtnExcelClick);
			// 
			// FormReporteBonificaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(732, 458);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dataBonos);
			this.Controls.Add(this.groupBox12);
			this.Controls.Add(this.groupBox18);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReporteBonificaciones";
			this.Text = "Transportes LAR - Reporte Bonificaciones";
			this.Load += new System.EventHandler(this.FormReporteBonificacionesLoad);
			this.groupBox12.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBonos)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ap_mat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ap_pat;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
		private System.Windows.Forms.ToolStripButton btnExcel;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.DataGridView dataBonos;
		private System.Windows.Forms.TextBox txtAlias;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.GroupBox groupBox12;
	}
}
