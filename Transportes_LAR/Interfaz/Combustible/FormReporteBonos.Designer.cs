/*
 * Creado por SharpDevelop.
 * Usuario: Lalo
 * Fecha: 10/02/2016
 * Hora: 11:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Transportes_LAR.Interfaz.Combustible
{
	partial class FormReporteBonos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteBonos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.dgOperadores = new System.Windows.Forms.DataGridView();
			this.ID_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FOLIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_AUTORIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HORA_AUTORIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PERMISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnPerdida = new System.Windows.Forms.Button();
			this.dgPerdidaBono = new System.Windows.Forms.DataGridView();
			this.id_o = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AUTORIZACIONT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QUITABONO = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbPeriodo = new System.Windows.Forms.CheckBox();
			this.cbNPD = new System.Windows.Forms.CheckBox();
			this.cbSR = new System.Windows.Forms.CheckBox();
			this.cbPDT = new System.Windows.Forms.CheckBox();
			this.cbAT = new System.Windows.Forms.CheckBox();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpIncio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.pbConfiguraciones = new System.Windows.Forms.PictureBox();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.lblOperador = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgPerdidaBono)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdImprimir.BackColor = System.Drawing.Color.Transparent;
			this.cmdImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.BackgroundImage")));
			this.cmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdImprimir.Location = new System.Drawing.Point(716, 9);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.Size = new System.Drawing.Size(41, 39);
			this.cmdImprimir.TabIndex = 11;
			this.cmdImprimir.UseVisualStyleBackColor = false;
			this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
			// 
			// bntBuscar
			// 
			this.bntBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
			this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bntBuscar.Location = new System.Drawing.Point(493, 8);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(92, 41);
			this.bntBuscar.TabIndex = 9;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.BntBuscarClick);
			// 
			// dgOperadores
			// 
			this.dgOperadores.AllowUserToAddRows = false;
			this.dgOperadores.AllowUserToResizeRows = false;
			this.dgOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgOperadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgOperadores.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOperadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOperadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_A,
									this.FOLIO,
									this.OPERADOR,
									this.UNIDAD,
									this.CONCEPTO,
									this.FECHA_AUTORIZACION,
									this.HORA_AUTORIZACION,
									this.HRD,
									this.PERMISO});
			this.dgOperadores.Location = new System.Drawing.Point(12, 69);
			this.dgOperadores.Name = "dgOperadores";
			this.dgOperadores.RowHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			this.dgOperadores.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgOperadores.Size = new System.Drawing.Size(752, 583);
			this.dgOperadores.TabIndex = 12;
			// 
			// ID_A
			// 
			this.ID_A.HeaderText = "ID_A";
			this.ID_A.Name = "ID_A";
			this.ID_A.ReadOnly = true;
			this.ID_A.Visible = false;
			// 
			// FOLIO
			// 
			this.FOLIO.FillWeight = 50F;
			this.FOLIO.HeaderText = "FOLIO";
			this.FOLIO.Name = "FOLIO";
			this.FOLIO.ReadOnly = true;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle2;
			this.OPERADOR.FillWeight = 60F;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			// 
			// UNIDAD
			// 
			this.UNIDAD.FillWeight = 46.90355F;
			this.UNIDAD.HeaderText = "UNIDAD";
			this.UNIDAD.Name = "UNIDAD";
			this.UNIDAD.ReadOnly = true;
			// 
			// CONCEPTO
			// 
			this.CONCEPTO.FillWeight = 90F;
			this.CONCEPTO.HeaderText = "CONCEPTO";
			this.CONCEPTO.Name = "CONCEPTO";
			this.CONCEPTO.ReadOnly = true;
			// 
			// FECHA_AUTORIZACION
			// 
			this.FECHA_AUTORIZACION.FillWeight = 60F;
			this.FECHA_AUTORIZACION.HeaderText = "FECH_AUT.";
			this.FECHA_AUTORIZACION.Name = "FECHA_AUTORIZACION";
			this.FECHA_AUTORIZACION.ReadOnly = true;
			// 
			// HORA_AUTORIZACION
			// 
			this.HORA_AUTORIZACION.FillWeight = 50F;
			this.HORA_AUTORIZACION.HeaderText = "HR_AUT.";
			this.HORA_AUTORIZACION.Name = "HORA_AUTORIZACION";
			this.HORA_AUTORIZACION.ReadOnly = true;
			// 
			// HRD
			// 
			this.HRD.HeaderText = "HR DATOS";
			this.HRD.Name = "HRD";
			this.HRD.ReadOnly = true;
			// 
			// PERMISO
			// 
			this.PERMISO.FillWeight = 115F;
			this.PERMISO.HeaderText = "PERMISO";
			this.PERMISO.Name = "PERMISO";
			this.PERMISO.ReadOnly = true;
			// 
			// btnPerdida
			// 
			this.btnPerdida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPerdida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPerdida.Image = ((System.Drawing.Image)(resources.GetObject("btnPerdida.Image")));
			this.btnPerdida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPerdida.Location = new System.Drawing.Point(601, 7);
			this.btnPerdida.Name = "btnPerdida";
			this.btnPerdida.Size = new System.Drawing.Size(92, 41);
			this.btnPerdida.TabIndex = 10;
			this.btnPerdida.Text = "Quitar Bonos";
			this.btnPerdida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPerdida.UseVisualStyleBackColor = true;
			this.btnPerdida.Click += new System.EventHandler(this.BtnPerdidaClick);
			// 
			// dgPerdidaBono
			// 
			this.dgPerdidaBono.AllowUserToAddRows = false;
			this.dgPerdidaBono.AllowUserToResizeRows = false;
			this.dgPerdidaBono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgPerdidaBono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPerdidaBono.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPerdidaBono.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgPerdidaBono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPerdidaBono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_o,
									this.dataGridViewTextBoxColumn2,
									this.AUTORIZACIONT,
									this.PDT,
									this.NPD,
									this.SR,
									this.TOTAL,
									this.QUITABONO});
			this.dgPerdidaBono.Location = new System.Drawing.Point(771, 95);
			this.dgPerdidaBono.Name = "dgPerdidaBono";
			this.dgPerdidaBono.RowHeadersVisible = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			this.dgPerdidaBono.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgPerdidaBono.Size = new System.Drawing.Size(426, 557);
			this.dgPerdidaBono.TabIndex = 14;
			// 
			// id_o
			// 
			this.id_o.HeaderText = "id_o";
			this.id_o.Name = "id_o";
			this.id_o.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn2.FillWeight = 80F;
			this.dataGridViewTextBoxColumn2.HeaderText = "OPERADOR";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// AUTORIZACIONT
			// 
			this.AUTORIZACIONT.FillWeight = 60F;
			this.AUTORIZACIONT.HeaderText = "AUTORIZ. TARDE";
			this.AUTORIZACIONT.Name = "AUTORIZACIONT";
			this.AUTORIZACIONT.ReadOnly = true;
			// 
			// PDT
			// 
			this.PDT.FillWeight = 60F;
			this.PDT.HeaderText = "PASO DATOS TARDE";
			this.PDT.Name = "PDT";
			this.PDT.ReadOnly = true;
			// 
			// NPD
			// 
			this.NPD.FillWeight = 60F;
			this.NPD.HeaderText = "NO PASO DATOS";
			this.NPD.Name = "NPD";
			this.NPD.ReadOnly = true;
			// 
			// SR
			// 
			this.SR.FillWeight = 85F;
			this.SR.HeaderText = "SIN REPORTARSE";
			this.SR.Name = "SR";
			this.SR.ReadOnly = true;
			// 
			// TOTAL
			// 
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.Name = "TOTAL";
			// 
			// QUITABONO
			// 
			this.QUITABONO.FillWeight = 25F;
			this.QUITABONO.HeaderText = "#";
			this.QUITABONO.Image = ((System.Drawing.Image)(resources.GetObject("QUITABONO.Image")));
			this.QUITABONO.Name = "QUITABONO";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbPeriodo);
			this.panel1.Controls.Add(this.cbNPD);
			this.panel1.Controls.Add(this.cbSR);
			this.panel1.Controls.Add(this.cbPDT);
			this.panel1.Controls.Add(this.cbAT);
			this.panel1.Controls.Add(this.dtpFin);
			this.panel1.Controls.Add(this.dtpIncio);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(20, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 59);
			this.panel1.TabIndex = 1;
			// 
			// cbPeriodo
			// 
			this.cbPeriodo.Location = new System.Drawing.Point(41, 8);
			this.cbPeriodo.Name = "cbPeriodo";
			this.cbPeriodo.Size = new System.Drawing.Size(109, 22);
			this.cbPeriodo.TabIndex = 2;
			this.cbPeriodo.Text = "Periodo Nominal";
			this.cbPeriodo.UseVisualStyleBackColor = true;
			this.cbPeriodo.CheckedChanged += new System.EventHandler(this.CbPeriodoCheckedChanged);
			// 
			// cbNPD
			// 
			this.cbNPD.Checked = true;
			this.cbNPD.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbNPD.Location = new System.Drawing.Point(349, 5);
			this.cbNPD.Name = "cbNPD";
			this.cbNPD.Size = new System.Drawing.Size(120, 24);
			this.cbNPD.TabIndex = 7;
			this.cbNPD.Text = "NO PASO DATOS";
			this.cbNPD.UseVisualStyleBackColor = true;
			// 
			// cbSR
			// 
			this.cbSR.Checked = true;
			this.cbSR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSR.Location = new System.Drawing.Point(349, 27);
			this.cbSR.Name = "cbSR";
			this.cbSR.Size = new System.Drawing.Size(128, 24);
			this.cbSR.TabIndex = 8;
			this.cbSR.Text = "SIN REPORTARSE";
			this.cbSR.UseVisualStyleBackColor = true;
			// 
			// cbPDT
			// 
			this.cbPDT.Checked = true;
			this.cbPDT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbPDT.Location = new System.Drawing.Point(196, 27);
			this.cbPDT.Name = "cbPDT";
			this.cbPDT.Size = new System.Drawing.Size(147, 24);
			this.cbPDT.TabIndex = 6;
			this.cbPDT.Text = "PASO DATOS TARDE";
			this.cbPDT.UseVisualStyleBackColor = true;
			// 
			// cbAT
			// 
			this.cbAT.Checked = true;
			this.cbAT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAT.Location = new System.Drawing.Point(196, 3);
			this.cbAT.Name = "cbAT";
			this.cbAT.Size = new System.Drawing.Size(147, 24);
			this.cbAT.TabIndex = 5;
			this.cbAT.Text = "AUTORIZACION TARDE";
			this.cbAT.UseVisualStyleBackColor = true;
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(107, 37);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(79, 20);
			this.dtpFin.TabIndex = 4;
			// 
			// dtpIncio
			// 
			this.dtpIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIncio.Location = new System.Drawing.Point(5, 37);
			this.dtpIncio.Name = "dtpIncio";
			this.dtpIncio.Size = new System.Drawing.Size(79, 20);
			this.dtpIncio.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(81, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 19);
			this.label5.TabIndex = 79;
			this.label5.Text = "al";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbConfiguraciones
			// 
			this.pbConfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("pbConfiguraciones.Image")));
			this.pbConfiguraciones.Location = new System.Drawing.Point(7, 4);
			this.pbConfiguraciones.Name = "pbConfiguraciones";
			this.pbConfiguraciones.Size = new System.Drawing.Size(33, 32);
			this.pbConfiguraciones.TabIndex = 111;
			this.pbConfiguraciones.TabStop = false;
			this.pbConfiguraciones.Visible = false;
			this.pbConfiguraciones.Click += new System.EventHandler(this.PbConfiguracionesClick);
			// 
			// txtOperador
			// 
			this.txtOperador.Location = new System.Drawing.Point(834, 69);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(124, 20);
			this.txtOperador.TabIndex = 13;
			this.txtOperador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtOperadorKeyUp);
			// 
			// lblOperador
			// 
			this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOperador.Location = new System.Drawing.Point(771, 72);
			this.lblOperador.Name = "lblOperador";
			this.lblOperador.Size = new System.Drawing.Size(80, 17);
			this.lblOperador.TabIndex = 81;
			this.lblOperador.Text = "Operador:";
			// 
			// FormReporteBonos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 663);
			this.Controls.Add(this.bntBuscar);
			this.Controls.Add(this.pbConfiguraciones);
			this.Controls.Add(this.txtOperador);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgPerdidaBono);
			this.Controls.Add(this.btnPerdida);
			this.Controls.Add(this.cmdImprimir);
			this.Controls.Add(this.dgOperadores);
			this.Controls.Add(this.lblOperador);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(785, 702);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(785, 702);
			this.Name = "FormReporteBonos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reportes Perdida Bonos";
			this.Load += new System.EventHandler(this.FormReporteBonosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgOperadores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgPerdidaBono)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbConfiguraciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn id_o;
		private System.Windows.Forms.DataGridViewTextBoxColumn HRD;
		private System.Windows.Forms.DataGridViewTextBoxColumn FOLIO;
		private System.Windows.Forms.PictureBox pbConfiguraciones;
		private System.Windows.Forms.Label lblOperador;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.CheckBox cbPeriodo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewImageColumn QUITABONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn SR;
		private System.Windows.Forms.DataGridViewTextBoxColumn NPD;
		private System.Windows.Forms.DataGridViewTextBoxColumn PDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn AUTORIZACIONT;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridView dgPerdidaBono;
		private System.Windows.Forms.Button btnPerdida;
		private System.Windows.Forms.CheckBox cbNPD;
		private System.Windows.Forms.CheckBox cbSR;
		private System.Windows.Forms.CheckBox cbPDT;
		private System.Windows.Forms.CheckBox cbAT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_A;
		private System.Windows.Forms.DataGridViewTextBoxColumn PERMISO;
		private System.Windows.Forms.DataGridViewTextBoxColumn UNIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn HORA_AUTORIZACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_AUTORIZACION;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridView dgOperadores;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIncio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.Button cmdImprimir;
	}
}
