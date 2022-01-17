/*
 * Created by SharpDevelop.
 * User: Lalo
 * Date: 14/09/2015
 * Time: 12:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	partial class FormMalFlujo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMalFlujo));
			this.gbRango = new System.Windows.Forms.GroupBox();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dgRelacion = new System.Windows.Forms.DataGridView();
			this.id_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECH_VAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO_SERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PAGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INCOBRABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_COBRO_ESPECIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CASETAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OP_COBRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdPago = new System.Windows.Forms.Button();
			this.lblContador = new System.Windows.Forms.Label();
			this.gbRango.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).BeginInit();
			this.SuspendLayout();
			// 
			// gbRango
			// 
			this.gbRango.Controls.Add(this.dtpInicio);
			this.gbRango.Controls.Add(this.dtpFin);
			this.gbRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRango.Location = new System.Drawing.Point(12, 5);
			this.gbRango.Name = "gbRango";
			this.gbRango.Size = new System.Drawing.Size(259, 56);
			this.gbRango.TabIndex = 13;
			this.gbRango.TabStop = false;
			this.gbRango.Text = "Rango:";
			// 
			// dtpInicio
			// 
			this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicio.Location = new System.Drawing.Point(7, 22);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(100, 22);
			this.dtpInicio.TabIndex = 2;
			this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicioValueChanged);
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(123, 21);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 22);
			this.dtpFin.TabIndex = 3;
			this.dtpFin.ValueChanged += new System.EventHandler(this.DtpFinValueChanged);
			// 
			// dgRelacion
			// 
			this.dgRelacion.AllowUserToAddRows = false;
			this.dgRelacion.AllowUserToResizeRows = false;
			this.dgRelacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgRelacion.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRelacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgRelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRelacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_re,
									this.OP,
									this.Oper,
									this.UNI,
									this.TEL,
									this.SAL,
									this.DES,
									this.AGE,
									this.FECH,
									this.FACTURA,
									this.ID_VAL,
									this.FECH_VAL,
									this.TIPO_SERVICIO,
									this.PAGADO,
									this.FACT,
									this.INCOBRABLE,
									this.ID_COBRO_ESPECIAL,
									this.Ant,
									this.OBS,
									this.CASETAS,
									this.id_op,
									this.OP_COBRA});
			this.dgRelacion.Location = new System.Drawing.Point(12, 67);
			this.dgRelacion.Name = "dgRelacion";
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRelacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dgRelacion.RowHeadersVisible = false;
			this.dgRelacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgRelacion.Size = new System.Drawing.Size(1139, 447);
			this.dgRelacion.TabIndex = 15;
			this.dgRelacion.DoubleClick += new System.EventHandler(this.DgRelacionDoubleClick);
			// 
			// id_re
			// 
			this.id_re.HeaderText = "ID";
			this.id_re.Name = "id_re";
			this.id_re.ReadOnly = true;
			this.id_re.Width = 50;
			// 
			// OP
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OP.DefaultCellStyle = dataGridViewCellStyle2;
			this.OP.HeaderText = "COBRO";
			this.OP.Name = "OP";
			this.OP.ReadOnly = true;
			this.OP.Width = 120;
			// 
			// Oper
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Oper.DefaultCellStyle = dataGridViewCellStyle3;
			this.Oper.HeaderText = "OPERADOR";
			this.Oper.Name = "Oper";
			this.Oper.ReadOnly = true;
			// 
			// UNI
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UNI.DefaultCellStyle = dataGridViewCellStyle4;
			this.UNI.HeaderText = "UNID.";
			this.UNI.Name = "UNI";
			this.UNI.ReadOnly = true;
			this.UNI.Width = 60;
			// 
			// TEL
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TEL.DefaultCellStyle = dataGridViewCellStyle5;
			this.TEL.HeaderText = "CELULAR";
			this.TEL.Name = "TEL";
			this.TEL.ReadOnly = true;
			this.TEL.Width = 90;
			// 
			// SAL
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SAL.DefaultCellStyle = dataGridViewCellStyle6;
			this.SAL.HeaderText = "SALDO";
			this.SAL.Name = "SAL";
			this.SAL.ReadOnly = true;
			this.SAL.Width = 70;
			// 
			// DES
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DES.DefaultCellStyle = dataGridViewCellStyle7;
			this.DES.HeaderText = "DESTINO";
			this.DES.Name = "DES";
			this.DES.ReadOnly = true;
			this.DES.Width = 180;
			// 
			// AGE
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AGE.DefaultCellStyle = dataGridViewCellStyle8;
			this.AGE.HeaderText = "AGENCIA";
			this.AGE.Name = "AGE";
			this.AGE.ReadOnly = true;
			this.AGE.Width = 130;
			// 
			// FECH
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.Format = "d";
			dataGridViewCellStyle9.NullValue = null;
			this.FECH.DefaultCellStyle = dataGridViewCellStyle9;
			this.FECH.HeaderText = "F. SALIDA";
			this.FECH.Name = "FECH";
			this.FECH.ReadOnly = true;
			this.FECH.Width = 90;
			// 
			// FACTURA
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FACTURA.DefaultCellStyle = dataGridViewCellStyle10;
			this.FACTURA.HeaderText = "FACTURA";
			this.FACTURA.Name = "FACTURA";
			this.FACTURA.ReadOnly = true;
			this.FACTURA.Width = 80;
			// 
			// ID_VAL
			// 
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID_VAL.DefaultCellStyle = dataGridViewCellStyle11;
			this.ID_VAL.HeaderText = "NUMERO";
			this.ID_VAL.Name = "ID_VAL";
			this.ID_VAL.ReadOnly = true;
			this.ID_VAL.Visible = false;
			this.ID_VAL.Width = 70;
			// 
			// FECH_VAL
			// 
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.FECH_VAL.DefaultCellStyle = dataGridViewCellStyle12;
			this.FECH_VAL.HeaderText = "F. VALIDACION";
			this.FECH_VAL.Name = "FECH_VAL";
			this.FECH_VAL.ReadOnly = true;
			this.FECH_VAL.Visible = false;
			this.FECH_VAL.Width = 90;
			// 
			// TIPO_SERVICIO
			// 
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO_SERVICIO.DefaultCellStyle = dataGridViewCellStyle13;
			this.TIPO_SERVICIO.HeaderText = "T";
			this.TIPO_SERVICIO.Name = "TIPO_SERVICIO";
			this.TIPO_SERVICIO.ReadOnly = true;
			this.TIPO_SERVICIO.Visible = false;
			this.TIPO_SERVICIO.Width = 30;
			// 
			// PAGADO
			// 
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.PAGADO.DefaultCellStyle = dataGridViewCellStyle14;
			this.PAGADO.HeaderText = "$";
			this.PAGADO.Name = "PAGADO";
			this.PAGADO.ReadOnly = true;
			this.PAGADO.Width = 30;
			// 
			// FACT
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.FACT.DefaultCellStyle = dataGridViewCellStyle15;
			this.FACT.HeaderText = "F";
			this.FACT.Name = "FACT";
			this.FACT.ReadOnly = true;
			this.FACT.Width = 30;
			// 
			// INCOBRABLE
			// 
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.INCOBRABLE.DefaultCellStyle = dataGridViewCellStyle16;
			this.INCOBRABLE.HeaderText = "I";
			this.INCOBRABLE.Name = "INCOBRABLE";
			this.INCOBRABLE.ReadOnly = true;
			this.INCOBRABLE.Visible = false;
			this.INCOBRABLE.Width = 30;
			// 
			// ID_COBRO_ESPECIAL
			// 
			this.ID_COBRO_ESPECIAL.HeaderText = "ID_CE";
			this.ID_COBRO_ESPECIAL.Name = "ID_COBRO_ESPECIAL";
			this.ID_COBRO_ESPECIAL.Visible = false;
			// 
			// Ant
			// 
			this.Ant.HeaderText = "ANTICIPO";
			this.Ant.Name = "Ant";
			this.Ant.ReadOnly = true;
			this.Ant.Visible = false;
			this.Ant.Width = 80;
			// 
			// OBS
			// 
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OBS.DefaultCellStyle = dataGridViewCellStyle17;
			this.OBS.HeaderText = "OBSERVACIONES";
			this.OBS.Name = "OBS";
			this.OBS.ReadOnly = true;
			this.OBS.Width = 120;
			// 
			// CASETAS
			// 
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CASETAS.DefaultCellStyle = dataGridViewCellStyle18;
			this.CASETAS.HeaderText = "CASETAS";
			this.CASETAS.Name = "CASETAS";
			this.CASETAS.ReadOnly = true;
			this.CASETAS.Visible = false;
			this.CASETAS.Width = 80;
			// 
			// id_op
			// 
			this.id_op.HeaderText = "id_op";
			this.id_op.Name = "id_op";
			this.id_op.ReadOnly = true;
			this.id_op.Visible = false;
			// 
			// OP_COBRA
			// 
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OP_COBRA.DefaultCellStyle = dataGridViewCellStyle19;
			this.OP_COBRA.HeaderText = "OP. COBRÓ";
			this.OP_COBRA.Name = "OP_COBRA";
			this.OP_COBRA.ReadOnly = true;
			this.OP_COBRA.Width = 50;
			// 
			// cmdPago
			// 
			this.cmdPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdPago.Image = ((System.Drawing.Image)(resources.GetObject("cmdPago.Image")));
			this.cmdPago.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.cmdPago.Location = new System.Drawing.Point(316, 23);
			this.cmdPago.Name = "cmdPago";
			this.cmdPago.Size = new System.Drawing.Size(87, 31);
			this.cmdPago.TabIndex = 16;
			this.cmdPago.Text = "Pagado";
			this.cmdPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdPago.UseVisualStyleBackColor = true;
			this.cmdPago.Click += new System.EventHandler(this.CmdPagoClick);
			// 
			// lblContador
			// 
			this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblContador.Location = new System.Drawing.Point(1051, 23);
			this.lblContador.Name = "lblContador";
			this.lblContador.Size = new System.Drawing.Size(100, 23);
			this.lblContador.TabIndex = 17;
			// 
			// FormMalFlujo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1163, 526);
			this.Controls.Add(this.lblContador);
			this.Controls.Add(this.cmdPago);
			this.Controls.Add(this.dgRelacion);
			this.Controls.Add(this.gbRango);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1179, 564);
			this.Name = "FormMalFlujo";
			this.Text = "Revisión de Rutas Especiales";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMalFlujoFormClosing);
			this.Load += new System.EventHandler(this.FormMalFlujoLoad);
			this.gbRango.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblContador;
		private System.Windows.Forms.Button cmdPago;
		private System.Windows.Forms.DataGridViewTextBoxColumn OP_COBRA;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_op;
		private System.Windows.Forms.DataGridViewTextBoxColumn CASETAS;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ant;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_COBRO_ESPECIAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn INCOBRABLE;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACT;
		private System.Windows.Forms.DataGridViewTextBoxColumn PAGADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_SERVICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECH_VAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_VAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECH;
		private System.Windows.Forms.DataGridViewTextBoxColumn AGE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DES;
		private System.Windows.Forms.DataGridViewTextBoxColumn SAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn TEL;
		private System.Windows.Forms.DataGridViewTextBoxColumn UNI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Oper;
		private System.Windows.Forms.DataGridViewTextBoxColumn OP;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_re;
		public System.Windows.Forms.DataGridView dgRelacion;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.GroupBox gbRango;
	}
}
