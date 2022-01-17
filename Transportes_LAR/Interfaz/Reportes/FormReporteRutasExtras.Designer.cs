/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 25/08/2015
 * Time: 7:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormReporteRutasExtras
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteRutasExtras));
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.dgRutas = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Foranea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Velada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblPeriodo = new System.Windows.Forms.Label();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.dtFin = new System.Windows.Forms.DateTimePicker();
			this.txtContador = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
			this.cmdGuardar.Location = new System.Drawing.Point(855, 375);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(81, 45);
			this.cmdGuardar.TabIndex = 3;
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// dgRutas
			// 
			this.dgRutas.AllowUserToAddRows = false;
			this.dgRutas.AllowUserToResizeRows = false;
			this.dgRutas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgRutas.BackgroundColor = System.Drawing.Color.White;
			this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Tipo,
									this.Column6,
									this.Column7,
									this.Column8,
									this.Foranea,
									this.Velada});
			this.dgRutas.Location = new System.Drawing.Point(12, 34);
			this.dgRutas.Name = "dgRutas";
			this.dgRutas.RowHeadersVisible = false;
			this.dgRutas.Size = new System.Drawing.Size(924, 334);
			this.dgRutas.TabIndex = 2;
			this.dgRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRutasCellClick);
			this.dgRutas.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRutasCellLeave);
			this.dgRutas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgRutasEditingControlShowing);
			this.dgRutas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgRutasKeyPress);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Empresa";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Ruta";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Turno";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Sentido";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			this.Tipo.Width = 60;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "km";
			this.Column6.Name = "Column6";
			this.Column6.Width = 70;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Hr. inicio";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 80;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Hr. fin";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 80;
			// 
			// Foranea
			// 
			this.Foranea.HeaderText = "Foranea";
			this.Foranea.Name = "Foranea";
			this.Foranea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Foranea.Width = 60;
			// 
			// Velada
			// 
			this.Velada.HeaderText = "Velada";
			this.Velada.Name = "Velada";
			this.Velada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Velada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Velada.Width = 60;
			// 
			// lblPeriodo
			// 
			this.lblPeriodo.BackColor = System.Drawing.Color.Transparent;
			this.lblPeriodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeriodo.Location = new System.Drawing.Point(14, 11);
			this.lblPeriodo.Name = "lblPeriodo";
			this.lblPeriodo.Size = new System.Drawing.Size(43, 22);
			this.lblPeriodo.TabIndex = 143;
			this.lblPeriodo.Text = "Periodo";
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(140, 9);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(11, 22);
			this.lblFechaCorte.TabIndex = 144;
			this.lblFechaCorte.Text = "-";
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(64, 8);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(75, 20);
			this.dtInicio.TabIndex = 145;
			this.dtInicio.ValueChanged += new System.EventHandler(this.DtInicioValueChanged);
			// 
			// dtFin
			// 
			this.dtFin.CustomFormat = "yyyy-MM-dd";
			this.dtFin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFin.Location = new System.Drawing.Point(152, 8);
			this.dtFin.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtFin.Name = "dtFin";
			this.dtFin.Size = new System.Drawing.Size(76, 20);
			this.dtFin.TabIndex = 146;
			this.dtFin.ValueChanged += new System.EventHandler(this.DtFinValueChanged);
			// 
			// txtContador
			// 
			this.txtContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtContador.Enabled = false;
			this.txtContador.Location = new System.Drawing.Point(12, 375);
			this.txtContador.Name = "txtContador";
			this.txtContador.Size = new System.Drawing.Size(65, 20);
			this.txtContador.TabIndex = 147;
			// 
			// FormReporteRutasExtras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 431);
			this.Controls.Add(this.txtContador);
			this.Controls.Add(this.lblPeriodo);
			this.Controls.Add(this.lblFechaCorte);
			this.Controls.Add(this.dtInicio);
			this.Controls.Add(this.dtFin);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.dgRutas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReporteRutasExtras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Horarios Rutas Extras";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteRutasExtrasFormClosing);
			this.Load += new System.EventHandler(this.FormReporteRutasExtrasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Velada;
		private System.Windows.Forms.DataGridViewTextBoxColumn Foranea;
		private System.Windows.Forms.TextBox txtContador;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DateTimePicker dtFin;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.Label lblPeriodo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgRutas;
		private System.Windows.Forms.Button cmdGuardar;
	}
}
