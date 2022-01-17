/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 15/08/2013
 * Time: 03:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	partial class FormXCobrar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXCobrar));
			this.dgCobros = new System.Windows.Forms.DataGridView();
			this.ID_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OPERADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CAJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cobro_op = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.COBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdPagado = new System.Windows.Forms.Button();
			this.gbPago = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUbica = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.rbDeposito = new System.Windows.Forms.RadioButton();
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.gbDinero = new System.Windows.Forms.GroupBox();
			this.cmdAplica = new System.Windows.Forms.Button();
			this.gbCambio = new System.Windows.Forms.GroupBox();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.cmdCambio = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgCobros)).BeginInit();
			this.gbPago.SuspendLayout();
			this.gbDinero.SuspendLayout();
			this.gbCambio.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgCobros
			// 
			this.dgCobros.AllowUserToAddRows = false;
			this.dgCobros.AllowUserToResizeRows = false;
			this.dgCobros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgCobros.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgCobros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCobros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_C,
									this.ID_RE,
									this.OPERADOR,
									this.UNIDAD,
									this.SALDO,
									this.CAJA,
									this.OBSERVACION,
									this.TIPO,
									this.cobro_op,
									this.COBRO});
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgCobros.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgCobros.Location = new System.Drawing.Point(12, 12);
			this.dgCobros.MultiSelect = false;
			this.dgCobros.Name = "dgCobros";
			this.dgCobros.RowHeadersVisible = false;
			this.dgCobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgCobros.Size = new System.Drawing.Size(702, 193);
			this.dgCobros.TabIndex = 0;
			this.dgCobros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCobrosCellClick);
			// 
			// ID_C
			// 
			this.ID_C.HeaderText = "ID_C";
			this.ID_C.Name = "ID_C";
			this.ID_C.ReadOnly = true;
			this.ID_C.Visible = false;
			// 
			// ID_RE
			// 
			this.ID_RE.HeaderText = "ID_RE";
			this.ID_RE.Name = "ID_RE";
			this.ID_RE.ReadOnly = true;
			this.ID_RE.Visible = false;
			// 
			// OPERADOR
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OPERADOR.DefaultCellStyle = dataGridViewCellStyle2;
			this.OPERADOR.HeaderText = "OPERADOR";
			this.OPERADOR.Name = "OPERADOR";
			this.OPERADOR.ReadOnly = true;
			this.OPERADOR.Width = 120;
			// 
			// UNIDAD
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UNIDAD.DefaultCellStyle = dataGridViewCellStyle3;
			this.UNIDAD.HeaderText = "UNIDAD";
			this.UNIDAD.Name = "UNIDAD";
			this.UNIDAD.ReadOnly = true;
			this.UNIDAD.Width = 70;
			// 
			// SALDO
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALDO.DefaultCellStyle = dataGridViewCellStyle4;
			this.SALDO.HeaderText = "SALDO";
			this.SALDO.Name = "SALDO";
			this.SALDO.ReadOnly = true;
			this.SALDO.Width = 60;
			// 
			// CAJA
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CAJA.DefaultCellStyle = dataGridViewCellStyle5;
			this.CAJA.HeaderText = "CAJA";
			this.CAJA.Name = "CAJA";
			this.CAJA.ReadOnly = true;
			this.CAJA.Width = 55;
			// 
			// OBSERVACION
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OBSERVACION.DefaultCellStyle = dataGridViewCellStyle6;
			this.OBSERVACION.HeaderText = "OBSERVACION";
			this.OBSERVACION.Name = "OBSERVACION";
			this.OBSERVACION.ReadOnly = true;
			this.OBSERVACION.Width = 170;
			// 
			// TIPO
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TIPO.DefaultCellStyle = dataGridViewCellStyle7;
			this.TIPO.HeaderText = "TIPO_VIAJE";
			this.TIPO.Name = "TIPO";
			this.TIPO.ReadOnly = true;
			// 
			// cobro_op
			// 
			this.cobro_op.HeaderText = "OP. COBRA";
			this.cobro_op.Name = "cobro_op";
			this.cobro_op.ReadOnly = true;
			this.cobro_op.Visible = false;
			// 
			// COBRO
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.COBRO.DefaultCellStyle = dataGridViewCellStyle8;
			this.COBRO.HeaderText = "COBRO";
			this.COBRO.Name = "COBRO";
			this.COBRO.ReadOnly = true;
			// 
			// cmdPagado
			// 
			this.cmdPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdPagado.Image = ((System.Drawing.Image)(resources.GetObject("cmdPagado.Image")));
			this.cmdPagado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdPagado.Location = new System.Drawing.Point(330, 12);
			this.cmdPagado.Name = "cmdPagado";
			this.cmdPagado.Size = new System.Drawing.Size(73, 51);
			this.cmdPagado.TabIndex = 2;
			this.cmdPagado.Text = "PAGADO";
			this.cmdPagado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdPagado.UseVisualStyleBackColor = true;
			this.cmdPagado.Click += new System.EventHandler(this.CmdPagadoClick);
			// 
			// gbPago
			// 
			this.gbPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gbPago.Controls.Add(this.label3);
			this.gbPago.Controls.Add(this.label2);
			this.gbPago.Controls.Add(this.label1);
			this.gbPago.Controls.Add(this.txtUbica);
			this.gbPago.Controls.Add(this.dtpFecha);
			this.gbPago.Controls.Add(this.txtNumero);
			this.gbPago.Controls.Add(this.rbDeposito);
			this.gbPago.Controls.Add(this.rbEfectivo);
			this.gbPago.Controls.Add(this.cmdPagado);
			this.gbPago.Enabled = false;
			this.gbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbPago.Location = new System.Drawing.Point(303, 211);
			this.gbPago.Name = "gbPago";
			this.gbPago.Size = new System.Drawing.Size(411, 69);
			this.gbPago.TabIndex = 3;
			this.gbPago.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(107, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 10);
			this.label3.TabIndex = 12;
			this.label3.Text = "Ubica";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 10);
			this.label2.TabIndex = 11;
			this.label2.Text = "Numero";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(218, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 19);
			this.label1.TabIndex = 10;
			this.label1.Text = "Fecha de ingreso";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtUbica
			// 
			this.txtUbica.Location = new System.Drawing.Point(107, 32);
			this.txtUbica.Name = "txtUbica";
			this.txtUbica.Size = new System.Drawing.Size(100, 20);
			this.txtUbica.TabIndex = 9;
			this.txtUbica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(218, 34);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(106, 21);
			this.dtpFecha.TabIndex = 8;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(6, 32);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(95, 20);
			this.txtNumero.TabIndex = 5;
			this.txtNumero.Text = "0";
			this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// rbDeposito
			// 
			this.rbDeposito.Checked = true;
			this.rbDeposito.Location = new System.Drawing.Point(112, 11);
			this.rbDeposito.Name = "rbDeposito";
			this.rbDeposito.Size = new System.Drawing.Size(100, 24);
			this.rbDeposito.TabIndex = 4;
			this.rbDeposito.TabStop = true;
			this.rbDeposito.Text = "DEPOSITO";
			this.rbDeposito.UseVisualStyleBackColor = true;
			this.rbDeposito.CheckedChanged += new System.EventHandler(this.RbDepositoCheckedChanged);
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.Location = new System.Drawing.Point(11, 11);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(95, 24);
			this.rbEfectivo.TabIndex = 3;
			this.rbEfectivo.Text = "EFECTIVO";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RbEfectivoCheckedChanged);
			// 
			// gbDinero
			// 
			this.gbDinero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gbDinero.Controls.Add(this.cmdAplica);
			this.gbDinero.Enabled = false;
			this.gbDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDinero.Location = new System.Drawing.Point(12, 211);
			this.gbDinero.Name = "gbDinero";
			this.gbDinero.Size = new System.Drawing.Size(126, 69);
			this.gbDinero.TabIndex = 4;
			this.gbDinero.TabStop = false;
			this.gbDinero.Text = "Op. no trae dinero";
			// 
			// cmdAplica
			// 
			this.cmdAplica.Image = ((System.Drawing.Image)(resources.GetObject("cmdAplica.Image")));
			this.cmdAplica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdAplica.Location = new System.Drawing.Point(23, 27);
			this.cmdAplica.Name = "cmdAplica";
			this.cmdAplica.Size = new System.Drawing.Size(79, 28);
			this.cmdAplica.TabIndex = 2;
			this.cmdAplica.Text = "Aplicar ";
			this.cmdAplica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdAplica.UseVisualStyleBackColor = true;
			this.cmdAplica.Click += new System.EventHandler(this.CmdAplicaClick);
			// 
			// gbCambio
			// 
			this.gbCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.gbCambio.Controls.Add(this.txtCambio);
			this.gbCambio.Controls.Add(this.cmdCambio);
			this.gbCambio.Enabled = false;
			this.gbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCambio.Location = new System.Drawing.Point(144, 211);
			this.gbCambio.Name = "gbCambio";
			this.gbCambio.Size = new System.Drawing.Size(153, 69);
			this.gbCambio.TabIndex = 5;
			this.gbCambio.TabStop = false;
			this.gbCambio.Text = "Cambio de cantidad";
			// 
			// txtCambio
			// 
			this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCambio.Location = new System.Drawing.Point(6, 30);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.Size = new System.Drawing.Size(107, 22);
			this.txtCambio.TabIndex = 3;
			this.txtCambio.Text = "0";
			this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtCambio.Leave += new System.EventHandler(this.TxtCambioLeave);
			// 
			// cmdCambio
			// 
			this.cmdCambio.Image = ((System.Drawing.Image)(resources.GetObject("cmdCambio.Image")));
			this.cmdCambio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCambio.Location = new System.Drawing.Point(119, 27);
			this.cmdCambio.Name = "cmdCambio";
			this.cmdCambio.Size = new System.Drawing.Size(28, 28);
			this.cmdCambio.TabIndex = 2;
			this.cmdCambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCambio.UseVisualStyleBackColor = true;
			this.cmdCambio.Click += new System.EventHandler(this.CmdCambioClick);
			// 
			// FormXCobrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 292);
			this.Controls.Add(this.gbCambio);
			this.Controls.Add(this.gbDinero);
			this.Controls.Add(this.gbPago);
			this.Controls.Add(this.dgCobros);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormXCobrar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Por Cobrar";
			this.Load += new System.EventHandler(this.FormXCobrarLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgCobros)).EndInit();
			this.gbPago.ResumeLayout(false);
			this.gbPago.PerformLayout();
			this.gbDinero.ResumeLayout(false);
			this.gbCambio.ResumeLayout(false);
			this.gbCambio.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdCambio;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.GroupBox gbCambio;
		private System.Windows.Forms.Button cmdAplica;
		private System.Windows.Forms.GroupBox gbDinero;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUbica;
		private System.Windows.Forms.DataGridViewTextBoxColumn cobro_op;
		private System.Windows.Forms.DataGridViewTextBoxColumn COBRO;
		private System.Windows.Forms.GroupBox gbPago;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.RadioButton rbDeposito;
		private System.Windows.Forms.RadioButton rbEfectivo;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACION;
		private System.Windows.Forms.Button cmdPagado;
		private System.Windows.Forms.DataGridViewTextBoxColumn CAJA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn UNIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn OPERADOR;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RE;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_C;
		private System.Windows.Forms.DataGridView dgCobros;
	}
}
