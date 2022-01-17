/*
 * Created by SharpDevelop.
 * User: TI1
 * Date: 11/06/2013
 * Time: 08:55 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormReporteGerencial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteGerencial));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.lblFechaInicio = new System.Windows.Forms.Label();
			this.btnTotales = new System.Windows.Forms.Button();
			this.btnReporteD = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataViajesNormales = new System.Windows.Forms.DataGridView();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VeladaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Foranea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c_Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.btnNoCobrables = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataViajesNormales)).BeginInit();
			this.SuspendLayout();
			// 
			// dtCorte
			// 
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(194, 46);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2013, 2, 12, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(94, 20);
			this.dtCorte.TabIndex = 142;
			// 
			// dtInicio
			// 
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(56, 47);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2013, 2, 12, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(92, 20);
			this.dtInicio.TabIndex = 141;
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(151, 49);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(42, 17);
			this.lblFechaCorte.TabIndex = 140;
			this.lblFechaCorte.Text = "Corte";
			// 
			// lblFechaInicio
			// 
			this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaInicio.Location = new System.Drawing.Point(10, 50);
			this.lblFechaInicio.Name = "lblFechaInicio";
			this.lblFechaInicio.Size = new System.Drawing.Size(45, 16);
			this.lblFechaInicio.TabIndex = 139;
			this.lblFechaInicio.Text = "Inicio";
			// 
			// btnTotales
			// 
			this.btnTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTotales.BackColor = System.Drawing.Color.Transparent;
			this.btnTotales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTotales.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTotales.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTotales.Image = ((System.Drawing.Image)(resources.GetObject("btnTotales.Image")));
			this.btnTotales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTotales.Location = new System.Drawing.Point(15, 74);
			this.btnTotales.Name = "btnTotales";
			this.btnTotales.Size = new System.Drawing.Size(90, 45);
			this.btnTotales.TabIndex = 196;
			this.btnTotales.Text = "Totales";
			this.btnTotales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTotales.UseVisualStyleBackColor = false;
			this.btnTotales.Click += new System.EventHandler(this.BtnTotalesClick);
			// 
			// btnReporteD
			// 
			this.btnReporteD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReporteD.BackColor = System.Drawing.Color.Transparent;
			this.btnReporteD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnReporteD.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReporteD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporteD.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteD.Image")));
			this.btnReporteD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReporteD.Location = new System.Drawing.Point(111, 74);
			this.btnReporteD.Name = "btnReporteD";
			this.btnReporteD.Size = new System.Drawing.Size(95, 45);
			this.btnReporteD.TabIndex = 195;
			this.btnReporteD.Text = "Directivo";
			this.btnReporteD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReporteD.UseVisualStyleBackColor = false;
			this.btnReporteD.Click += new System.EventHandler(this.BtnReporteDClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.dataViajesNormales);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnNoCobrables);
			this.panel1.Controls.Add(this.lblFechaInicio);
			this.panel1.Controls.Add(this.lblFechaCorte);
			this.panel1.Controls.Add(this.btnTotales);
			this.panel1.Controls.Add(this.dtInicio);
			this.panel1.Controls.Add(this.btnReporteD);
			this.panel1.Controls.Add(this.dtCorte);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 131);
			this.panel1.TabIndex = 198;
			// 
			// dataViajesNormales
			// 
			this.dataViajesNormales.AllowUserToAddRows = false;
			this.dataViajesNormales.AllowUserToResizeRows = false;
			this.dataViajesNormales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataViajesNormales.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dataViajesNormales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataViajesNormales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataViajesNormales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Estado,
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.SubNombre,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn5,
									this.Viaje,
									this.Vehiculo,
									this.Extra,
									this.DatoColumn,
									this.VeladaColumn,
									this.Hora,
									this.HoraFin,
									this.dataGridViewTextBoxColumn6,
									this.Foranea,
									this.c_Importe,
									this.c_Semana,
									this.Operador});
			this.dataViajesNormales.Location = new System.Drawing.Point(328, 6);
			this.dataViajesNormales.Name = "dataViajesNormales";
			this.dataViajesNormales.RowHeadersVisible = false;
			this.dataViajesNormales.Size = new System.Drawing.Size(11, 13);
			this.dataViajesNormales.TabIndex = 200;
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "Estado";
			dataGridViewCellStyle2.NullValue = "Nulo";
			this.Estado.DefaultCellStyle = dataGridViewCellStyle2;
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.Width = 69;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 64;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Empresa";
			this.dataGridViewTextBoxColumn2.HeaderText = "Empresa";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 81;
			// 
			// SubNombre
			// 
			this.SubNombre.DataPropertyName = "SubNombre";
			this.SubNombre.HeaderText = "SubNombre";
			this.SubNombre.Name = "SubNombre";
			this.SubNombre.ReadOnly = true;
			this.SubNombre.Visible = false;
			this.SubNombre.Width = 97;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Ruta";
			this.dataGridViewTextBoxColumn3.HeaderText = "Ruta";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 56;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Sentido";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn4.HeaderText = "Sentido";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 74;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Turno";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn5.HeaderText = "Turno";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 64;
			// 
			// Viaje
			// 
			this.Viaje.DataPropertyName = "Viaje";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Viaje.DefaultCellStyle = dataGridViewCellStyle6;
			this.Viaje.HeaderText = "Vehiculo Contrato";
			this.Viaje.Name = "Viaje";
			this.Viaje.ReadOnly = true;
			this.Viaje.Width = 119;
			// 
			// Vehiculo
			// 
			this.Vehiculo.DataPropertyName = "Vehiculo";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Vehiculo.DefaultCellStyle = dataGridViewCellStyle7;
			this.Vehiculo.HeaderText = "Vehiculo Viaje";
			this.Vehiculo.Name = "Vehiculo";
			this.Vehiculo.ReadOnly = true;
			this.Vehiculo.Visible = false;
			// 
			// Extra
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Extra.DefaultCellStyle = dataGridViewCellStyle8;
			this.Extra.HeaderText = "Extra";
			this.Extra.Name = "Extra";
			this.Extra.ReadOnly = true;
			this.Extra.Width = 59;
			// 
			// DatoColumn
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.DatoColumn.DefaultCellStyle = dataGridViewCellStyle9;
			this.DatoColumn.HeaderText = "Dato";
			this.DatoColumn.Name = "DatoColumn";
			this.DatoColumn.ReadOnly = true;
			this.DatoColumn.Width = 56;
			// 
			// VeladaColumn
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.VeladaColumn.DefaultCellStyle = dataGridViewCellStyle10;
			this.VeladaColumn.HeaderText = "Velada";
			this.VeladaColumn.Name = "VeladaColumn";
			this.VeladaColumn.ReadOnly = true;
			this.VeladaColumn.Width = 68;
			// 
			// Hora
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Hora.DefaultCellStyle = dataGridViewCellStyle11;
			this.Hora.HeaderText = "Hora";
			this.Hora.Name = "Hora";
			this.Hora.Width = 57;
			// 
			// HoraFin
			// 
			this.HoraFin.HeaderText = "Hora Fin";
			this.HoraFin.Name = "HoraFin";
			// 
			// dataGridViewTextBoxColumn6
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridViewTextBoxColumn6.HeaderText = "KM";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 49;
			// 
			// Foranea
			// 
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Foranea.DefaultCellStyle = dataGridViewCellStyle13;
			this.Foranea.HeaderText = "Foranea";
			this.Foranea.Name = "Foranea";
			this.Foranea.ReadOnly = true;
			this.Foranea.Width = 76;
			// 
			// c_Importe
			// 
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.NullValue = "0";
			this.c_Importe.DefaultCellStyle = dataGridViewCellStyle14;
			this.c_Importe.HeaderText = "Importe";
			this.c_Importe.Name = "c_Importe";
			this.c_Importe.ReadOnly = true;
			this.c_Importe.Width = 76;
			// 
			// c_Semana
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.c_Semana.DefaultCellStyle = dataGridViewCellStyle15;
			this.c_Semana.HeaderText = "Semana";
			this.c_Semana.Name = "c_Semana";
			this.c_Semana.ReadOnly = true;
			this.c_Semana.Width = 76;
			// 
			// Operador
			// 
			this.Operador.HeaderText = "Alias";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			this.Operador.Width = 59;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 40);
			this.label1.TabIndex = 201;
			this.label1.Text = "Reportes";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNoCobrables
			// 
			this.btnNoCobrables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNoCobrables.BackColor = System.Drawing.Color.Transparent;
			this.btnNoCobrables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNoCobrables.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNoCobrables.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNoCobrables.Image = ((System.Drawing.Image)(resources.GetObject("btnNoCobrables.Image")));
			this.btnNoCobrables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNoCobrables.Location = new System.Drawing.Point(216, 72);
			this.btnNoCobrables.Name = "btnNoCobrables";
			this.btnNoCobrables.Size = new System.Drawing.Size(124, 45);
			this.btnNoCobrables.TabIndex = 200;
			this.btnNoCobrables.Text = "No Cobrables";
			this.btnNoCobrables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNoCobrables.UseVisualStyleBackColor = false;
			this.btnNoCobrables.Click += new System.EventHandler(this.BtnNoCobrablesClick);
			// 
			// FormReporteGerencial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(379, 156);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReporteGerencial";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR - Reporte Gerencial";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteGerencialFormClosing);
			this.Load += new System.EventHandler(this.FormReporteGerencialLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataViajesNormales)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_Semana;
		private System.Windows.Forms.DataGridViewTextBoxColumn c_Importe;
		private System.Windows.Forms.DataGridViewTextBoxColumn Foranea;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
		private System.Windows.Forms.DataGridViewTextBoxColumn VeladaColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatoColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Extra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Viaje;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn SubNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNoCobrables;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataViajesNormales;
		private System.Windows.Forms.Button btnTotales;
		private System.Windows.Forms.Button btnReporteD;
		private System.Windows.Forms.Label lblFechaInicio;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.DateTimePicker dtCorte;
	}
}
