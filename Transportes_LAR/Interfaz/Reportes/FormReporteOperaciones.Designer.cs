/*
 * Creado por SharpDevelop.
 * Usuario: LarEquipo
 * Fecha: 06/03/2014
 * Hora: 10:26 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormReporteOperaciones
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgDatos = new System.Windows.Forms.DataGridView();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VIAJES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INCIDENTES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RUTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Externos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgDatos
			// 
			this.dgDatos.AllowUserToAddRows = false;
			this.dgDatos.AllowUserToResizeRows = false;
			this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgDatos.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.FECHA,
									this.TURNO,
									this.VIAJES,
									this.UNIDADES,
									this.INCIDENTES,
									this.RUTAS,
									this.Externos});
			this.dgDatos.Location = new System.Drawing.Point(12, 44);
			this.dgDatos.Name = "dgDatos";
			this.dgDatos.RowHeadersVisible = false;
			this.dgDatos.Size = new System.Drawing.Size(380, 340);
			this.dgDatos.TabIndex = 0;
			this.dgDatos.DoubleClick += new System.EventHandler(this.DgDatosDoubleClick);
			// 
			// FECHA
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FECHA.DefaultCellStyle = dataGridViewCellStyle2;
			this.FECHA.HeaderText = "FECHA";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// TURNO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TURNO.DefaultCellStyle = dataGridViewCellStyle3;
			this.TURNO.HeaderText = "TURNO";
			this.TURNO.Name = "TURNO";
			this.TURNO.ReadOnly = true;
			// 
			// VIAJES
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VIAJES.DefaultCellStyle = dataGridViewCellStyle4;
			this.VIAJES.HeaderText = "V";
			this.VIAJES.Name = "VIAJES";
			this.VIAJES.ReadOnly = true;
			this.VIAJES.Width = 30;
			// 
			// UNIDADES
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UNIDADES.DefaultCellStyle = dataGridViewCellStyle5;
			this.UNIDADES.HeaderText = "U";
			this.UNIDADES.Name = "UNIDADES";
			this.UNIDADES.ReadOnly = true;
			this.UNIDADES.Width = 30;
			// 
			// INCIDENTES
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.INCIDENTES.DefaultCellStyle = dataGridViewCellStyle6;
			this.INCIDENTES.HeaderText = "I";
			this.INCIDENTES.Name = "INCIDENTES";
			this.INCIDENTES.ReadOnly = true;
			this.INCIDENTES.Width = 30;
			// 
			// RUTAS
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RUTAS.DefaultCellStyle = dataGridViewCellStyle7;
			this.RUTAS.HeaderText = "R";
			this.RUTAS.Name = "RUTAS";
			this.RUTAS.ReadOnly = true;
			this.RUTAS.Width = 30;
			// 
			// Externos
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Externos.DefaultCellStyle = dataGridViewCellStyle8;
			this.Externos.HeaderText = "E";
			this.Externos.Name = "Externos";
			this.Externos.ReadOnly = true;
			this.Externos.Width = 30;
			// 
			// dtpInicio
			// 
			this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(110, 12);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(101, 20);
			this.dtpInicio.TabIndex = 1;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(217, 12);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(101, 20);
			this.dtpFin.TabIndex = 2;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 387);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(380, 110);
			this.label1.TabIndex = 3;
			this.label1.Text = "V: Viajes realizados\r\nU: Unidades disponibles\r\n I: Incidentes\r\nR: Rutas no cubier" +
			"tas\r\nE: Viajes de operadores externos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FormReporteOperaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 506);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.dgDatos);
			this.MinimumSize = new System.Drawing.Size(402, 544);
			this.Name = "FormReporteOperaciones";
			this.Text = "Reporte operaciones";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteOperacionesFormClosing);
			this.Load += new System.EventHandler(this.FormReporteOperacionesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Externos;
		public System.Windows.Forms.DataGridView dgDatos;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn RUTAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn INCIDENTES;
		private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
		private System.Windows.Forms.DataGridViewTextBoxColumn VIAJES;
		private System.Windows.Forms.DataGridViewTextBoxColumn TURNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
	}
}
