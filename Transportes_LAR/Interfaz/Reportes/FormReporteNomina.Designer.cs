/*
 * Created by SharpDevelop.
 * User: Xavi
 * Date: 08/08/2014
 * Time: 12:03 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Reportes
{
	partial class FormReporteNomina
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteNomina));
			this.label23 = new System.Windows.Forms.Label();
			this.dtFechaActual = new System.Windows.Forms.DateTimePicker();
			this.dtCorte = new System.Windows.Forms.DateTimePicker();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			this.lblFechaCorte = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableEstandars = new System.Windows.Forms.TableLayoutPanel();
			this.datapercepccionesExtras = new System.Windows.Forms.DataGridView();
			this.dataPrestamosAdicionales = new System.Windows.Forms.DataGridView();
			this.dataAjustesNominales = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.dataBonosBonificados = new System.Windows.Forms.DataGridView();
			this.dataBonosPerdidos = new System.Windows.Forms.DataGridView();
			this.lblExtraEstandar = new System.Windows.Forms.Label();
			this.lblNormalesEstandar = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dataprestamosdia = new System.Windows.Forms.DataGridView();
			this.dataprestamosborrados = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.tableEstandars.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datapercepccionesExtras)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPrestamosAdicionales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataAjustesNominales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBonosBonificados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBonosPerdidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataprestamosdia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataprestamosborrados)).BeginInit();
			this.SuspendLayout();
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(12, 10);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(81, 18);
			this.label23.TabIndex = 212;
			this.label23.Text = "Fecha Actual";
			// 
			// dtFechaActual
			// 
			this.dtFechaActual.CustomFormat = "yyyy-MM-dd";
			this.dtFechaActual.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaActual.Location = new System.Drawing.Point(99, 7);
			this.dtFechaActual.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtFechaActual.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtFechaActual.Name = "dtFechaActual";
			this.dtFechaActual.Size = new System.Drawing.Size(99, 20);
			this.dtFechaActual.TabIndex = 211;
			this.dtFechaActual.ValueChanged += new System.EventHandler(this.DtFechaActualValueChanged);
			// 
			// dtCorte
			// 
			this.dtCorte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtCorte.CustomFormat = "yyyy-MM-dd";
			this.dtCorte.Enabled = false;
			this.dtCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtCorte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCorte.Location = new System.Drawing.Point(713, 8);
			this.dtCorte.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtCorte.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtCorte.Name = "dtCorte";
			this.dtCorte.Size = new System.Drawing.Size(93, 20);
			this.dtCorte.TabIndex = 210;
			// 
			// dtInicio
			// 
			this.dtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtInicio.CustomFormat = "yyyy-MM-dd";
			this.dtInicio.Enabled = false;
			this.dtInicio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(574, 8);
			this.dtInicio.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
			this.dtInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(96, 20);
			this.dtInicio.TabIndex = 209;
			// 
			// lblFechaCorte
			// 
			this.lblFechaCorte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFechaCorte.BackColor = System.Drawing.Color.Transparent;
			this.lblFechaCorte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaCorte.Location = new System.Drawing.Point(685, 9);
			this.lblFechaCorte.Name = "lblFechaCorte";
			this.lblFechaCorte.Size = new System.Drawing.Size(10, 18);
			this.lblFechaCorte.TabIndex = 208;
			this.lblFechaCorte.Text = "a";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(462, 10);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(115, 16);
			this.label13.TabIndex = 207;
			this.label13.Text = "Periodo Quincenal";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.Tan;
			this.panel1.Controls.Add(this.tableEstandars);
			this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(12, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 449);
			this.panel1.TabIndex = 213;
			// 
			// tableEstandars
			// 
			this.tableEstandars.AutoSize = true;
			this.tableEstandars.BackColor = System.Drawing.Color.Transparent;
			this.tableEstandars.ColumnCount = 1;
			this.tableEstandars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableEstandars.Controls.Add(this.dataprestamosdia, 0, 11);
			this.tableEstandars.Controls.Add(this.dataprestamosborrados, 0, 13);
			this.tableEstandars.Controls.Add(this.label4, 0, 10);
			this.tableEstandars.Controls.Add(this.label5, 0, 12);
			this.tableEstandars.Controls.Add(this.datapercepccionesExtras, 0, 5);
			this.tableEstandars.Controls.Add(this.dataPrestamosAdicionales, 0, 7);
			this.tableEstandars.Controls.Add(this.dataAjustesNominales, 0, 9);
			this.tableEstandars.Controls.Add(this.label1, 0, 8);
			this.tableEstandars.Controls.Add(this.dataBonosBonificados, 0, 3);
			this.tableEstandars.Controls.Add(this.dataBonosPerdidos, 0, 1);
			this.tableEstandars.Controls.Add(this.lblExtraEstandar, 0, 0);
			this.tableEstandars.Controls.Add(this.lblNormalesEstandar, 0, 2);
			this.tableEstandars.Controls.Add(this.label3, 0, 4);
			this.tableEstandars.Controls.Add(this.label2, 0, 6);
			this.tableEstandars.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableEstandars.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableEstandars.Location = new System.Drawing.Point(0, 0);
			this.tableEstandars.Name = "tableEstandars";
			this.tableEstandars.RowCount = 14;
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableEstandars.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableEstandars.Size = new System.Drawing.Size(794, 252);
			this.tableEstandars.TabIndex = 184;
			// 
			// datapercepccionesExtras
			// 
			this.datapercepccionesExtras.AllowUserToAddRows = false;
			this.datapercepccionesExtras.AllowUserToResizeColumns = false;
			this.datapercepccionesExtras.AllowUserToResizeRows = false;
			this.datapercepccionesExtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.datapercepccionesExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.datapercepccionesExtras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.datapercepccionesExtras.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.datapercepccionesExtras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.datapercepccionesExtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datapercepccionesExtras.Location = new System.Drawing.Point(3, 95);
			this.datapercepccionesExtras.Name = "datapercepccionesExtras";
			this.datapercepccionesExtras.RowHeadersVisible = false;
			this.datapercepccionesExtras.Size = new System.Drawing.Size(788, 10);
			this.datapercepccionesExtras.TabIndex = 185;
			// 
			// dataPrestamosAdicionales
			// 
			this.dataPrestamosAdicionales.AllowUserToAddRows = false;
			this.dataPrestamosAdicionales.AllowUserToResizeColumns = false;
			this.dataPrestamosAdicionales.AllowUserToResizeRows = false;
			this.dataPrestamosAdicionales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataPrestamosAdicionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataPrestamosAdicionales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataPrestamosAdicionales.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataPrestamosAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataPrestamosAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPrestamosAdicionales.Location = new System.Drawing.Point(3, 131);
			this.dataPrestamosAdicionales.Name = "dataPrestamosAdicionales";
			this.dataPrestamosAdicionales.RowHeadersVisible = false;
			this.dataPrestamosAdicionales.Size = new System.Drawing.Size(788, 10);
			this.dataPrestamosAdicionales.TabIndex = 186;
			// 
			// dataAjustesNominales
			// 
			this.dataAjustesNominales.AllowUserToAddRows = false;
			this.dataAjustesNominales.AllowUserToResizeColumns = false;
			this.dataAjustesNominales.AllowUserToResizeRows = false;
			this.dataAjustesNominales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataAjustesNominales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataAjustesNominales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataAjustesNominales.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataAjustesNominales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataAjustesNominales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataAjustesNominales.Location = new System.Drawing.Point(3, 167);
			this.dataAjustesNominales.Name = "dataAjustesNominales";
			this.dataAjustesNominales.RowHeadersVisible = false;
			this.dataAjustesNominales.Size = new System.Drawing.Size(788, 10);
			this.dataAjustesNominales.TabIndex = 187;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 20);
			this.label1.TabIndex = 214;
			this.label1.Text = "Ajustes Nominales";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataBonosBonificados
			// 
			this.dataBonosBonificados.AllowUserToAddRows = false;
			this.dataBonosBonificados.AllowUserToResizeColumns = false;
			this.dataBonosBonificados.AllowUserToResizeRows = false;
			this.dataBonosBonificados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataBonosBonificados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataBonosBonificados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataBonosBonificados.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataBonosBonificados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataBonosBonificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataBonosBonificados.Location = new System.Drawing.Point(3, 59);
			this.dataBonosBonificados.Name = "dataBonosBonificados";
			this.dataBonosBonificados.RowHeadersVisible = false;
			this.dataBonosBonificados.Size = new System.Drawing.Size(788, 10);
			this.dataBonosBonificados.TabIndex = 1;
			// 
			// dataBonosPerdidos
			// 
			this.dataBonosPerdidos.AllowUserToAddRows = false;
			this.dataBonosPerdidos.AllowUserToResizeColumns = false;
			this.dataBonosPerdidos.AllowUserToResizeRows = false;
			this.dataBonosPerdidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataBonosPerdidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataBonosPerdidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataBonosPerdidos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataBonosPerdidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataBonosPerdidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataBonosPerdidos.Location = new System.Drawing.Point(3, 23);
			this.dataBonosPerdidos.Name = "dataBonosPerdidos";
			this.dataBonosPerdidos.RowHeadersVisible = false;
			this.dataBonosPerdidos.Size = new System.Drawing.Size(788, 10);
			this.dataBonosPerdidos.TabIndex = 0;
			// 
			// lblExtraEstandar
			// 
			this.lblExtraEstandar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblExtraEstandar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblExtraEstandar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExtraEstandar.Location = new System.Drawing.Point(3, 0);
			this.lblExtraEstandar.Name = "lblExtraEstandar";
			this.lblExtraEstandar.Size = new System.Drawing.Size(788, 20);
			this.lblExtraEstandar.TabIndex = 3;
			this.lblExtraEstandar.Text = "Bonos Perdidos";
			this.lblExtraEstandar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNormalesEstandar
			// 
			this.lblNormalesEstandar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblNormalesEstandar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblNormalesEstandar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNormalesEstandar.Location = new System.Drawing.Point(3, 36);
			this.lblNormalesEstandar.Name = "lblNormalesEstandar";
			this.lblNormalesEstandar.Size = new System.Drawing.Size(788, 20);
			this.lblNormalesEstandar.TabIndex = 2;
			this.lblNormalesEstandar.Text = "Bonos Bonificados";
			this.lblNormalesEstandar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(788, 20);
			this.label3.TabIndex = 216;
			this.label3.Text = "Percepcciones Extras";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(788, 20);
			this.label2.TabIndex = 215;
			this.label2.Text = "Prestamos Adicionales";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(788, 20);
			this.label4.TabIndex = 215;
			this.label4.Text = "Prestamos del día de pago";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(788, 20);
			this.label5.TabIndex = 216;
			this.label5.Text = "Prestamos Borrados en la quincena";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataprestamosdia
			// 
			this.dataprestamosdia.AllowUserToAddRows = false;
			this.dataprestamosdia.AllowUserToResizeColumns = false;
			this.dataprestamosdia.AllowUserToResizeRows = false;
			this.dataprestamosdia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataprestamosdia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataprestamosdia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataprestamosdia.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataprestamosdia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataprestamosdia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataprestamosdia.Location = new System.Drawing.Point(3, 203);
			this.dataprestamosdia.Name = "dataprestamosdia";
			this.dataprestamosdia.RowHeadersVisible = false;
			this.dataprestamosdia.Size = new System.Drawing.Size(788, 10);
			this.dataprestamosdia.TabIndex = 214;
			// 
			// dataprestamosborrados
			// 
			this.dataprestamosborrados.AllowUserToAddRows = false;
			this.dataprestamosborrados.AllowUserToResizeColumns = false;
			this.dataprestamosborrados.AllowUserToResizeRows = false;
			this.dataprestamosborrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataprestamosborrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataprestamosborrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataprestamosborrados.BackgroundColor = System.Drawing.SystemColors.MenuBar;
			this.dataprestamosborrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataprestamosborrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataprestamosborrados.Location = new System.Drawing.Point(3, 239);
			this.dataprestamosborrados.Name = "dataprestamosborrados";
			this.dataprestamosborrados.RowHeadersVisible = false;
			this.dataprestamosborrados.Size = new System.Drawing.Size(788, 10);
			this.dataprestamosborrados.TabIndex = 215;
			// 
			// FormReporteNomina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(819, 496);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.dtFechaActual);
			this.Controls.Add(this.dtCorte);
			this.Controls.Add(this.dtInicio);
			this.Controls.Add(this.lblFechaCorte);
			this.Controls.Add(this.label13);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormReporteNomina";
			this.Text = "Transportes LAR - Reporte Gerencial Nomina";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporteNominaFormClosing);
			this.Load += new System.EventHandler(this.FormReporteNominaLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableEstandars.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.datapercepccionesExtras)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPrestamosAdicionales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataAjustesNominales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBonosBonificados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBonosPerdidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataprestamosdia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataprestamosborrados)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataprestamosborrados;
		private System.Windows.Forms.DataGridView dataprestamosdia;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataAjustesNominales;
		private System.Windows.Forms.DataGridView dataPrestamosAdicionales;
		private System.Windows.Forms.DataGridView datapercepccionesExtras;
		private System.Windows.Forms.Label lblNormalesEstandar;
		private System.Windows.Forms.Label lblExtraEstandar;
		private System.Windows.Forms.DataGridView dataBonosPerdidos;
		private System.Windows.Forms.DataGridView dataBonosBonificados;
		private System.Windows.Forms.TableLayoutPanel tableEstandars;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblFechaCorte;
		private System.Windows.Forms.DateTimePicker dtInicio;
		private System.Windows.Forms.DateTimePicker dtCorte;
		private System.Windows.Forms.DateTimePicker dtFechaActual;
		private System.Windows.Forms.Label label23;
	}
}
