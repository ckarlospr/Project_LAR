/*
 * Created by SharpDevelop.
 * User: Estandar
 * Date: 14/11/2015
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	partial class PrivilegiosPagos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivilegiosPagos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdExcel = new System.Windows.Forms.Button();
			this.tcCobros = new System.Windows.Forms.TabControl();
			this.tpEspeciales = new System.Windows.Forms.TabPage();
			this.lblPagar = new System.Windows.Forms.Label();
			this.btnIncobrable = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbEmpresariales = new System.Windows.Forms.ComboBox();
			this.lblLimpiar = new System.Windows.Forms.Label();
			this.txtOperador = new System.Windows.Forms.TextBox();
			this.cbValidados = new System.Windows.Forms.CheckBox();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.cbBusqueda = new System.Windows.Forms.ComboBox();
			this.cbTipo = new System.Windows.Forms.ComboBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbPagados = new System.Windows.Forms.CheckBox();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.dtpIncio = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgRelacion = new System.Windows.Forms.DataGridView();
			this.id_re = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONTACTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_REGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD_UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_COTIZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AGENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO_COBRAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ANTICIPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D = new System.Windows.Forms.DataGridViewImageColumn();
			this.MenuEspeciales = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.pagadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.incobrableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imprimirIncobrableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnPagarServicio = new System.Windows.Forms.Button();
			this.tpAnticipos = new System.Windows.Forms.TabPage();
			this.cbMostrarValidadosAnticipos = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbEfectivo = new System.Windows.Forms.RadioButton();
			this.rbDepositos = new System.Windows.Forms.RadioButton();
			this.cmdConfirmar = new System.Windows.Forms.Button();
			this.dgAnticipos = new System.Windows.Forms.DataGridView();
			this.ID_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UBICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgServiciosAnt = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SERVICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FACTURAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.factura_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblFacturas = new System.Windows.Forms.Label();
			this.dgOrdenFactura = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Factura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_RES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cant1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RAZON_SOCIAL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CONTRIBUYENTE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ORDEN_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FORMA_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DESTINOF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
			this.MenuFactura = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copiarDetalleDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lblAlerta = new System.Windows.Forms.Label();
			this.dtpInicioOrdenFactura = new System.Windows.Forms.DateTimePicker();
			this.cbEliminadasOrdenFactura = new System.Windows.Forms.CheckBox();
			this.cmbBusquedaOrdenFactura = new System.Windows.Forms.ComboBox();
			this.dtpFinOrdenFactura = new System.Windows.Forms.DateTimePicker();
			this.txtBusquedaOrdenFactura = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lblAvisoAnticipos = new System.Windows.Forms.Label();
			this.lblAvisoFactura = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tcCobros.SuspendLayout();
			this.tpEspeciales.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).BeginInit();
			this.MenuEspeciales.SuspendLayout();
			this.tpAnticipos.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAnticipos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgServiciosAnt)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgOrdenFactura)).BeginInit();
			this.MenuFactura.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdExcel
			// 
			this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdExcel.Image = ((System.Drawing.Image)(resources.GetObject("cmdExcel.Image")));
			this.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdExcel.Location = new System.Drawing.Point(1134, 29);
			this.cmdExcel.Name = "cmdExcel";
			this.cmdExcel.Size = new System.Drawing.Size(79, 27);
			this.cmdExcel.TabIndex = 24;
			this.cmdExcel.Text = "Excel";
			this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.cmdExcel.UseVisualStyleBackColor = true;
			// 
			// tcCobros
			// 
			this.tcCobros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tcCobros.Controls.Add(this.tpEspeciales);
			this.tcCobros.Controls.Add(this.tpAnticipos);
			this.tcCobros.Controls.Add(this.tabPage1);
			this.tcCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcCobros.ImageList = this.imageList1;
			this.tcCobros.Location = new System.Drawing.Point(-2, 12);
			this.tcCobros.Name = "tcCobros";
			this.tcCobros.SelectedIndex = 0;
			this.tcCobros.Size = new System.Drawing.Size(1108, 527);
			this.tcCobros.TabIndex = 25;
			this.tcCobros.SelectedIndexChanged += new System.EventHandler(this.TcCobrosSelectedIndexChanged);
			// 
			// tpEspeciales
			// 
			this.tpEspeciales.BackColor = System.Drawing.Color.White;
			this.tpEspeciales.Controls.Add(this.lblPagar);
			this.tpEspeciales.Controls.Add(this.btnIncobrable);
			this.tpEspeciales.Controls.Add(this.button1);
			this.tpEspeciales.Controls.Add(this.groupBox1);
			this.tpEspeciales.Controls.Add(this.dgRelacion);
			this.tpEspeciales.Controls.Add(this.btnPagarServicio);
			this.tpEspeciales.Location = new System.Drawing.Point(4, 23);
			this.tpEspeciales.Name = "tpEspeciales";
			this.tpEspeciales.Padding = new System.Windows.Forms.Padding(3);
			this.tpEspeciales.Size = new System.Drawing.Size(1100, 500);
			this.tpEspeciales.TabIndex = 0;
			this.tpEspeciales.Text = "Control de Pagos";
			// 
			// lblPagar
			// 
			this.lblPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPagar.Location = new System.Drawing.Point(877, 481);
			this.lblPagar.Name = "lblPagar";
			this.lblPagar.Size = new System.Drawing.Size(215, 15);
			this.lblPagar.TabIndex = 65;
			this.lblPagar.Text = "SERVICIOS POR PAGAR: ";
			this.lblPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnIncobrable
			// 
			this.btnIncobrable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIncobrable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIncobrable.Image = ((System.Drawing.Image)(resources.GetObject("btnIncobrable.Image")));
			this.btnIncobrable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnIncobrable.Location = new System.Drawing.Point(871, 23);
			this.btnIncobrable.Name = "btnIncobrable";
			this.btnIncobrable.Size = new System.Drawing.Size(95, 45);
			this.btnIncobrable.TabIndex = 69;
			this.btnIncobrable.Text = "Incobrable";
			this.btnIncobrable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnIncobrable.UseVisualStyleBackColor = true;
			this.btnIncobrable.Click += new System.EventHandler(this.BtnIncobrableClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(988, 26);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 35);
			this.button1.TabIndex = 68;
			this.button1.Text = "Reportes";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbEmpresariales);
			this.groupBox1.Controls.Add(this.lblLimpiar);
			this.groupBox1.Controls.Add(this.txtOperador);
			this.groupBox1.Controls.Add(this.cbValidados);
			this.groupBox1.Controls.Add(this.bntBuscar);
			this.groupBox1.Controls.Add(this.cbBusqueda);
			this.groupBox1.Controls.Add(this.cbTipo);
			this.groupBox1.Controls.Add(this.txtBusqueda);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbPagados);
			this.groupBox1.Controls.Add(this.dtpFin);
			this.groupBox1.Controls.Add(this.dtpIncio);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(780, 78);
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros";
			// 
			// cbEmpresariales
			// 
			this.cbEmpresariales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEmpresariales.FormattingEnabled = true;
			this.cbEmpresariales.Items.AddRange(new object[] {
									"Seleccione Opción",
									"Empresariales",
									"Especiales"});
			this.cbEmpresariales.Location = new System.Drawing.Point(506, 47);
			this.cbEmpresariales.Name = "cbEmpresariales";
			this.cbEmpresariales.Size = new System.Drawing.Size(161, 24);
			this.cbEmpresariales.TabIndex = 68;
			// 
			// lblLimpiar
			// 
			this.lblLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("lblLimpiar.Image")));
			this.lblLimpiar.Location = new System.Drawing.Point(12, 39);
			this.lblLimpiar.Name = "lblLimpiar";
			this.lblLimpiar.Size = new System.Drawing.Size(40, 31);
			this.lblLimpiar.TabIndex = 66;
			this.lblLimpiar.Click += new System.EventHandler(this.LblLimpiarClick);
			// 
			// txtOperador
			// 
			this.txtOperador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOperador.Location = new System.Drawing.Point(220, 21);
			this.txtOperador.Name = "txtOperador";
			this.txtOperador.Size = new System.Drawing.Size(147, 20);
			this.txtOperador.TabIndex = 65;
			this.txtOperador.Visible = false;
			// 
			// cbValidados
			// 
			this.cbValidados.Location = new System.Drawing.Point(567, 47);
			this.cbValidados.Name = "cbValidados";
			this.cbValidados.Size = new System.Drawing.Size(92, 24);
			this.cbValidados.TabIndex = 64;
			this.cbValidados.Text = "Validados";
			this.cbValidados.UseVisualStyleBackColor = true;
			this.cbValidados.Visible = false;
			// 
			// bntBuscar
			// 
			this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
			this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bntBuscar.Location = new System.Drawing.Point(676, 21);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(95, 45);
			this.bntBuscar.TabIndex = 60;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.BntBuscarClick);
			// 
			// cbBusqueda
			// 
			this.cbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBusqueda.FormattingEnabled = true;
			this.cbBusqueda.Items.AddRange(new object[] {
									"ID_RE",
									"CONTACTO",
									"DESTINO",
									"RAZÓN SOCIAL",
									"FACTURA"});
			this.cbBusqueda.Location = new System.Drawing.Point(54, 46);
			this.cbBusqueda.Name = "cbBusqueda";
			this.cbBusqueda.Size = new System.Drawing.Size(161, 24);
			this.cbBusqueda.TabIndex = 60;
			this.cbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CbBusquedaSelectedIndexChanged);
			// 
			// cbTipo
			// 
			this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTipo.FormattingEnabled = true;
			this.cbTipo.Items.AddRange(new object[] {
									"COORDINADOR",
									"FACTURA",
									"C. PUNTO",
									"PAGADO",
									"OPERADOR",
									"DEPOSITO",
									"INCOBRABLE"});
			this.cbTipo.Location = new System.Drawing.Point(86, 19);
			this.cbTipo.Name = "cbTipo";
			this.cbTipo.Size = new System.Drawing.Size(128, 24);
			this.cbTipo.TabIndex = 62;
			this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.CbTipoSelectedIndexChanged);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusqueda.Location = new System.Drawing.Point(220, 49);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(185, 20);
			this.txtBusqueda.TabIndex = 61;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 23);
			this.label4.TabIndex = 63;
			this.label4.Text = "Tipo Pago:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbPagados
			// 
			this.cbPagados.Location = new System.Drawing.Point(409, 47);
			this.cbPagados.Name = "cbPagados";
			this.cbPagados.Size = new System.Drawing.Size(92, 24);
			this.cbPagados.TabIndex = 0;
			this.cbPagados.Text = "Pagados";
			this.cbPagados.UseVisualStyleBackColor = true;
			// 
			// dtpFin
			// 
			this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFin.Location = new System.Drawing.Point(529, 22);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(100, 22);
			this.dtpFin.TabIndex = 3;
			// 
			// dtpIncio
			// 
			this.dtpIncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIncio.Location = new System.Drawing.Point(403, 21);
			this.dtpIncio.Name = "dtpIncio";
			this.dtpIncio.Size = new System.Drawing.Size(100, 22);
			this.dtpIncio.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(503, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 19);
			this.label5.TabIndex = 19;
			this.label5.Text = "al";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(373, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 18);
			this.label6.TabIndex = 18;
			this.label6.Text = "Del";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dgRelacion
			// 
			this.dgRelacion.AllowUserToAddRows = false;
			this.dgRelacion.AllowUserToResizeRows = false;
			this.dgRelacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgRelacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgRelacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRelacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgRelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRelacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_re,
									this.ID_C,
									this.OP,
									this.CONTACTO,
									this.CLIENTE,
									this.DESTINO,
									this.FECHA_SALIDA,
									this.FECHA_REGRESO,
									this.CANTIDAD_UNIDAD,
									this.PRECIO_COTIZADO,
									this.FACTURA,
									this.AGENCIA,
									this.PRECIO_COBRAR,
									this.ANTICIPOS,
									this.EFECTIVO,
									this.SALDO,
									this.FACTURADO,
									this.D});
			this.dgRelacion.ContextMenuStrip = this.MenuEspeciales;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgRelacion.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgRelacion.Location = new System.Drawing.Point(10, 85);
			this.dgRelacion.Name = "dgRelacion";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgRelacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgRelacion.RowHeadersVisible = false;
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgRelacion.RowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dgRelacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgRelacion.Size = new System.Drawing.Size(1082, 394);
			this.dgRelacion.TabIndex = 22;
			this.dgRelacion.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRelacionCellMouseEnter);
			this.dgRelacion.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRelacionCellMouseLeave);
			this.dgRelacion.DoubleClick += new System.EventHandler(this.DgRelacionDoubleClick);
			// 
			// id_re
			// 
			this.id_re.FillWeight = 24.70217F;
			this.id_re.HeaderText = "ID_RE";
			this.id_re.Name = "id_re";
			this.id_re.ReadOnly = true;
			// 
			// ID_C
			// 
			this.ID_C.HeaderText = "ID_C";
			this.ID_C.Name = "ID_C";
			this.ID_C.Visible = false;
			// 
			// OP
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OP.DefaultCellStyle = dataGridViewCellStyle2;
			this.OP.FillWeight = 70.57762F;
			this.OP.HeaderText = "TIPO COBRO";
			this.OP.Name = "OP";
			this.OP.ReadOnly = true;
			// 
			// CONTACTO
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.CONTACTO.DefaultCellStyle = dataGridViewCellStyle3;
			this.CONTACTO.FillWeight = 70.57762F;
			this.CONTACTO.HeaderText = "CONTACTO";
			this.CONTACTO.Name = "CONTACTO";
			this.CONTACTO.ReadOnly = true;
			// 
			// CLIENTE
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.CLIENTE.DefaultCellStyle = dataGridViewCellStyle4;
			this.CLIENTE.FillWeight = 70.57762F;
			this.CLIENTE.HeaderText = "CLIENTE";
			this.CLIENTE.Name = "CLIENTE";
			this.CLIENTE.ReadOnly = true;
			// 
			// DESTINO
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.DESTINO.DefaultCellStyle = dataGridViewCellStyle5;
			this.DESTINO.FillWeight = 141.1552F;
			this.DESTINO.HeaderText = "DESTINO";
			this.DESTINO.Name = "DESTINO";
			this.DESTINO.ReadOnly = true;
			// 
			// FECHA_SALIDA
			// 
			this.FECHA_SALIDA.FillWeight = 35.28881F;
			this.FECHA_SALIDA.HeaderText = "FECHA SALIDA";
			this.FECHA_SALIDA.Name = "FECHA_SALIDA";
			this.FECHA_SALIDA.ReadOnly = true;
			// 
			// FECHA_REGRESO
			// 
			this.FECHA_REGRESO.FillWeight = 35F;
			this.FECHA_REGRESO.HeaderText = "FECHA REGRESO";
			this.FECHA_REGRESO.Name = "FECHA_REGRESO";
			this.FECHA_REGRESO.ReadOnly = true;
			// 
			// CANTIDAD_UNIDAD
			// 
			this.CANTIDAD_UNIDAD.FillWeight = 20F;
			this.CANTIDAD_UNIDAD.HeaderText = "C.U";
			this.CANTIDAD_UNIDAD.Name = "CANTIDAD_UNIDAD";
			this.CANTIDAD_UNIDAD.ReadOnly = true;
			// 
			// PRECIO_COTIZADO
			// 
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			this.PRECIO_COTIZADO.DefaultCellStyle = dataGridViewCellStyle6;
			this.PRECIO_COTIZADO.FillWeight = 50F;
			this.PRECIO_COTIZADO.HeaderText = "PRECIO COTIZADO";
			this.PRECIO_COTIZADO.Name = "PRECIO_COTIZADO";
			this.PRECIO_COTIZADO.ReadOnly = true;
			// 
			// FACTURA
			// 
			this.FACTURA.FillWeight = 25F;
			this.FACTURA.HeaderText = "FACT";
			this.FACTURA.Name = "FACTURA";
			this.FACTURA.ReadOnly = true;
			// 
			// AGENCIA
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.AGENCIA.DefaultCellStyle = dataGridViewCellStyle7;
			this.AGENCIA.FillWeight = 90F;
			this.AGENCIA.HeaderText = "RAZON SOCIAL";
			this.AGENCIA.Name = "AGENCIA";
			this.AGENCIA.ReadOnly = true;
			// 
			// PRECIO_COBRAR
			// 
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			this.PRECIO_COBRAR.DefaultCellStyle = dataGridViewCellStyle8;
			this.PRECIO_COBRAR.FillWeight = 50F;
			this.PRECIO_COBRAR.HeaderText = "PRECIO A COBRAR";
			this.PRECIO_COBRAR.Name = "PRECIO_COBRAR";
			this.PRECIO_COBRAR.ReadOnly = true;
			// 
			// ANTICIPOS
			// 
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			this.ANTICIPOS.DefaultCellStyle = dataGridViewCellStyle9;
			this.ANTICIPOS.FillWeight = 60F;
			this.ANTICIPOS.HeaderText = "ANT. DEPOSITO";
			this.ANTICIPOS.Name = "ANTICIPOS";
			this.ANTICIPOS.ReadOnly = true;
			// 
			// EFECTIVO
			// 
			this.EFECTIVO.FillWeight = 60F;
			this.EFECTIVO.HeaderText = "ANT. EFECTIVO";
			this.EFECTIVO.Name = "EFECTIVO";
			this.EFECTIVO.ReadOnly = true;
			// 
			// SALDO
			// 
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SALDO.DefaultCellStyle = dataGridViewCellStyle10;
			this.SALDO.FillWeight = 50F;
			this.SALDO.HeaderText = "SALDO";
			this.SALDO.Name = "SALDO";
			this.SALDO.ReadOnly = true;
			// 
			// FACTURADO
			// 
			this.FACTURADO.FillWeight = 60F;
			this.FACTURADO.HeaderText = "FACTURA";
			this.FACTURADO.Name = "FACTURADO";
			// 
			// D
			// 
			this.D.FillWeight = 20F;
			this.D.HeaderText = "D";
			this.D.Image = ((System.Drawing.Image)(resources.GetObject("D.Image")));
			this.D.Name = "D";
			// 
			// MenuEspeciales
			// 
			this.MenuEspeciales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pagadoToolStripMenuItem,
									this.incobrableToolStripMenuItem,
									this.imprimirIncobrableToolStripMenuItem});
			this.MenuEspeciales.Name = "MenuEspeciales";
			this.MenuEspeciales.Size = new System.Drawing.Size(180, 92);
			this.MenuEspeciales.Opening += new System.ComponentModel.CancelEventHandler(this.MenuEspecialesOpening);
			// 
			// pagadoToolStripMenuItem
			// 
			this.pagadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagadoToolStripMenuItem.Image")));
			this.pagadoToolStripMenuItem.Name = "pagadoToolStripMenuItem";
			this.pagadoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.pagadoToolStripMenuItem.Text = "Pagado";
			this.pagadoToolStripMenuItem.Click += new System.EventHandler(this.PagadoToolStripMenuItemClick);
			// 
			// incobrableToolStripMenuItem
			// 
			this.incobrableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("incobrableToolStripMenuItem.Image")));
			this.incobrableToolStripMenuItem.Name = "incobrableToolStripMenuItem";
			this.incobrableToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.incobrableToolStripMenuItem.Text = "Incobrable";
			this.incobrableToolStripMenuItem.Click += new System.EventHandler(this.IncobrableToolStripMenuItemClick);
			// 
			// imprimirIncobrableToolStripMenuItem
			// 
			this.imprimirIncobrableToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirIncobrableToolStripMenuItem.Image")));
			this.imprimirIncobrableToolStripMenuItem.Name = "imprimirIncobrableToolStripMenuItem";
			this.imprimirIncobrableToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.imprimirIncobrableToolStripMenuItem.Text = "Imprimir Incobrable";
			this.imprimirIncobrableToolStripMenuItem.Click += new System.EventHandler(this.ImprimirIncobrableToolStripMenuItemClick);
			// 
			// btnPagarServicio
			// 
			this.btnPagarServicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPagarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPagarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnPagarServicio.Image")));
			this.btnPagarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPagarServicio.Location = new System.Drawing.Point(770, 23);
			this.btnPagarServicio.Name = "btnPagarServicio";
			this.btnPagarServicio.Size = new System.Drawing.Size(95, 45);
			this.btnPagarServicio.TabIndex = 70;
			this.btnPagarServicio.Tag = "Pagar Servicio";
			this.btnPagarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPagarServicio.UseVisualStyleBackColor = true;
			this.btnPagarServicio.Click += new System.EventHandler(this.BtnPagarServicioClick);
			// 
			// tpAnticipos
			// 
			this.tpAnticipos.Controls.Add(this.cbMostrarValidadosAnticipos);
			this.tpAnticipos.Controls.Add(this.label2);
			this.tpAnticipos.Controls.Add(this.label49);
			this.tpAnticipos.Controls.Add(this.groupBox2);
			this.tpAnticipos.Controls.Add(this.cmdConfirmar);
			this.tpAnticipos.Controls.Add(this.dgAnticipos);
			this.tpAnticipos.Controls.Add(this.dgServiciosAnt);
			this.tpAnticipos.Location = new System.Drawing.Point(4, 23);
			this.tpAnticipos.Name = "tpAnticipos";
			this.tpAnticipos.Padding = new System.Windows.Forms.Padding(3);
			this.tpAnticipos.Size = new System.Drawing.Size(1100, 500);
			this.tpAnticipos.TabIndex = 1;
			this.tpAnticipos.Text = "Control de Anticipos";
			this.tpAnticipos.UseVisualStyleBackColor = true;
			// 
			// cbMostrarValidadosAnticipos
			// 
			this.cbMostrarValidadosAnticipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbMostrarValidadosAnticipos.Location = new System.Drawing.Point(852, 462);
			this.cbMostrarValidadosAnticipos.Name = "cbMostrarValidadosAnticipos";
			this.cbMostrarValidadosAnticipos.Size = new System.Drawing.Size(127, 24);
			this.cbMostrarValidadosAnticipos.TabIndex = 66;
			this.cbMostrarValidadosAnticipos.Text = "Mostrar Validados";
			this.cbMostrarValidadosAnticipos.UseVisualStyleBackColor = true;
			this.cbMostrarValidadosAnticipos.CheckedChanged += new System.EventHandler(this.CbMostrarValidadosAnticiposCheckedChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(617, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 438);
			this.label2.TabIndex = 16;
			this.label2.Text = "Anticipos";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label49
			// 
			this.label49.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label49.Location = new System.Drawing.Point(10, 6);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(601, 23);
			this.label49.TabIndex = 0;
			this.label49.Text = "Servicios con anticipos sin validar";
			this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.rbEfectivo);
			this.groupBox2.Controls.Add(this.rbDepositos);
			this.groupBox2.Location = new System.Drawing.Point(146, 445);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(178, 47);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// rbEfectivo
			// 
			this.rbEfectivo.Checked = true;
			this.rbEfectivo.Location = new System.Drawing.Point(6, 13);
			this.rbEfectivo.Name = "rbEfectivo";
			this.rbEfectivo.Size = new System.Drawing.Size(79, 24);
			this.rbEfectivo.TabIndex = 1;
			this.rbEfectivo.TabStop = true;
			this.rbEfectivo.Text = "Efectivo";
			this.rbEfectivo.UseVisualStyleBackColor = true;
			this.rbEfectivo.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// rbDepositos
			// 
			this.rbDepositos.Location = new System.Drawing.Point(87, 13);
			this.rbDepositos.Name = "rbDepositos";
			this.rbDepositos.Size = new System.Drawing.Size(85, 24);
			this.rbDepositos.TabIndex = 0;
			this.rbDepositos.Text = "Depositos";
			this.rbDepositos.UseVisualStyleBackColor = true;
			this.rbDepositos.CheckedChanged += new System.EventHandler(this.RbDepositosCheckedChanged);
			// 
			// cmdConfirmar
			// 
			this.cmdConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("cmdConfirmar.Image")));
			this.cmdConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdConfirmar.Location = new System.Drawing.Point(1000, 452);
			this.cmdConfirmar.Name = "cmdConfirmar";
			this.cmdConfirmar.Size = new System.Drawing.Size(94, 42);
			this.cmdConfirmar.TabIndex = 2;
			this.cmdConfirmar.Text = "Confirmar";
			this.cmdConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdConfirmar.UseVisualStyleBackColor = true;
			this.cmdConfirmar.Click += new System.EventHandler(this.CmdConfirmarClick);
			// 
			// dgAnticipos
			// 
			this.dgAnticipos.AllowUserToAddRows = false;
			this.dgAnticipos.AllowUserToResizeRows = false;
			this.dgAnticipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgAnticipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgAnticipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgAnticipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgAnticipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAnticipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID_F,
									this.FECHA_A,
									this.CANTIDAD,
									this.NUMERO,
									this.UBICA,
									this.Comentario});
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgAnticipos.DefaultCellStyle = dataGridViewCellStyle16;
			this.dgAnticipos.Location = new System.Drawing.Point(638, 6);
			this.dgAnticipos.MultiSelect = false;
			this.dgAnticipos.Name = "dgAnticipos";
			this.dgAnticipos.RowHeadersVisible = false;
			this.dgAnticipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAnticipos.Size = new System.Drawing.Size(456, 438);
			this.dgAnticipos.TabIndex = 1;
			this.dgAnticipos.DoubleClick += new System.EventHandler(this.DgAnticiposDoubleClick);
			// 
			// ID_F
			// 
			this.ID_F.HeaderText = "ID_Anticipo";
			this.ID_F.Name = "ID_F";
			this.ID_F.ReadOnly = true;
			this.ID_F.Visible = false;
			// 
			// FECHA_A
			// 
			this.FECHA_A.HeaderText = "FECHA";
			this.FECHA_A.Name = "FECHA_A";
			this.FECHA_A.ReadOnly = true;
			// 
			// CANTIDAD
			// 
			this.CANTIDAD.HeaderText = "ANTICIPO";
			this.CANTIDAD.Name = "CANTIDAD";
			this.CANTIDAD.ReadOnly = true;
			// 
			// NUMERO
			// 
			this.NUMERO.HeaderText = "COMPROBANTE";
			this.NUMERO.Name = "NUMERO";
			this.NUMERO.ReadOnly = true;
			// 
			// UBICA
			// 
			this.UBICA.HeaderText = "UBICA";
			this.UBICA.Name = "UBICA";
			this.UBICA.ReadOnly = true;
			// 
			// Comentario
			// 
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Comentario.DefaultCellStyle = dataGridViewCellStyle15;
			this.Comentario.HeaderText = "COMENTARIO";
			this.Comentario.Name = "Comentario";
			this.Comentario.ReadOnly = true;
			// 
			// dgServiciosAnt
			// 
			this.dgServiciosAnt.AllowUserToAddRows = false;
			this.dgServiciosAnt.AllowUserToResizeRows = false;
			this.dgServiciosAnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dgServiciosAnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgServiciosAnt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgServiciosAnt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.dgServiciosAnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgServiciosAnt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.SERVICIO,
									this.FECHA,
									this.FACTURAD,
									this.RAZON_SOCIAL,
									this.factura_d,
									this.PRECIO});
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgServiciosAnt.DefaultCellStyle = dataGridViewCellStyle20;
			this.dgServiciosAnt.Location = new System.Drawing.Point(6, 32);
			this.dgServiciosAnt.MultiSelect = false;
			this.dgServiciosAnt.Name = "dgServiciosAnt";
			this.dgServiciosAnt.RowHeadersVisible = false;
			this.dgServiciosAnt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgServiciosAnt.Size = new System.Drawing.Size(605, 412);
			this.dgServiciosAnt.TabIndex = 0;
			this.dgServiciosAnt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgServiciosAntCellClick);
			this.dgServiciosAnt.DoubleClick += new System.EventHandler(this.DgServiciosAntDoubleClick);
			// 
			// ID
			// 
			this.ID.FillWeight = 27.67531F;
			this.ID.HeaderText = "ID_RE";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// SERVICIO
			// 
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SERVICIO.DefaultCellStyle = dataGridViewCellStyle18;
			this.SERVICIO.FillWeight = 123.0178F;
			this.SERVICIO.HeaderText = "SERVICIO";
			this.SERVICIO.Name = "SERVICIO";
			this.SERVICIO.ReadOnly = true;
			// 
			// FECHA
			// 
			this.FECHA.FillWeight = 76.657F;
			this.FECHA.HeaderText = "FECHA SERVICIO";
			this.FECHA.Name = "FECHA";
			this.FECHA.ReadOnly = true;
			// 
			// FACTURAD
			// 
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FACTURAD.DefaultCellStyle = dataGridViewCellStyle19;
			this.FACTURAD.FillWeight = 22.15365F;
			this.FACTURAD.HeaderText = "F";
			this.FACTURAD.Name = "FACTURAD";
			this.FACTURAD.ReadOnly = true;
			// 
			// RAZON_SOCIAL
			// 
			this.RAZON_SOCIAL.FillWeight = 80F;
			this.RAZON_SOCIAL.HeaderText = "RAZON_SOCIAL";
			this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
			this.RAZON_SOCIAL.ReadOnly = true;
			// 
			// factura_d
			// 
			this.factura_d.FillWeight = 45.05693F;
			this.factura_d.HeaderText = "FACTURA";
			this.factura_d.Name = "factura_d";
			this.factura_d.ReadOnly = true;
			// 
			// PRECIO
			// 
			this.PRECIO.FillWeight = 63.29614F;
			this.PRECIO.HeaderText = "PRECIO";
			this.PRECIO.Name = "PRECIO";
			this.PRECIO.ReadOnly = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lblFacturas);
			this.tabPage1.Controls.Add(this.dgOrdenFactura);
			this.tabPage1.Controls.Add(this.panel6);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1100, 500);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Ordenes de Factura";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lblFacturas
			// 
			this.lblFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblFacturas.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFacturas.Location = new System.Drawing.Point(6, 452);
			this.lblFacturas.Name = "lblFacturas";
			this.lblFacturas.Size = new System.Drawing.Size(215, 15);
			this.lblFacturas.TabIndex = 148;
			this.lblFacturas.Text = "FACTURAS PENDIENTES:  ";
			this.lblFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgOrdenFactura
			// 
			this.dgOrdenFactura.AllowUserToAddRows = false;
			this.dgOrdenFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgOrdenFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgOrdenFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgOrdenFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
			this.dgOrdenFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgOrdenFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn4,
									this.Factura1,
									this.ID_RES,
									this.dataGridViewTextBoxColumn53,
									this.dataGridViewTextBoxColumn54,
									this.dataGridViewTextBoxColumn55,
									this.cant1,
									this.dataGridViewTextBoxColumn56,
									this.IVA,
									this.TOTAL,
									this.RAZON_SOCIAL1,
									this.CONTRIBUYENTE1,
									this.dataGridViewTextBoxColumn5,
									this.ORDEN_COMPRA,
									this.FORMA_F,
									this.DESTINOF,
									this.Column8});
			this.dgOrdenFactura.ContextMenuStrip = this.MenuFactura;
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgOrdenFactura.DefaultCellStyle = dataGridViewCellStyle22;
			this.dgOrdenFactura.Location = new System.Drawing.Point(6, 61);
			this.dgOrdenFactura.MultiSelect = false;
			this.dgOrdenFactura.Name = "dgOrdenFactura";
			this.dgOrdenFactura.RowHeadersVisible = false;
			this.dgOrdenFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgOrdenFactura.Size = new System.Drawing.Size(1088, 385);
			this.dgOrdenFactura.TabIndex = 147;
			this.dgOrdenFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrdenFacturaCellClick);
			this.dgOrdenFactura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgOrdenFacturaCellDoubleClick);
			this.dgOrdenFactura.DoubleClick += new System.EventHandler(this.DgOrdenFacturaDoubleClick);
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.FillWeight = 40F;
			this.dataGridViewTextBoxColumn4.HeaderText = "ID_F";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// Factura1
			// 
			this.Factura1.FillWeight = 70F;
			this.Factura1.HeaderText = "FACTURA";
			this.Factura1.Name = "Factura1";
			this.Factura1.ReadOnly = true;
			// 
			// ID_RES
			// 
			this.ID_RES.FillWeight = 80F;
			this.ID_RES.HeaderText = "ID_RES";
			this.ID_RES.Name = "ID_RES";
			this.ID_RES.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn53
			// 
			this.dataGridViewTextBoxColumn53.HeaderText = "FECHAS";
			this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
			this.dataGridViewTextBoxColumn53.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn54
			// 
			this.dataGridViewTextBoxColumn54.HeaderText = "CLIENTE";
			this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
			this.dataGridViewTextBoxColumn54.ReadOnly = true;
			this.dataGridViewTextBoxColumn54.Visible = false;
			// 
			// dataGridViewTextBoxColumn55
			// 
			this.dataGridViewTextBoxColumn55.HeaderText = "VEHICULO";
			this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
			this.dataGridViewTextBoxColumn55.ReadOnly = true;
			// 
			// cant1
			// 
			this.cant1.FillWeight = 50F;
			this.cant1.HeaderText = "CANT";
			this.cant1.Name = "cant1";
			this.cant1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn56
			// 
			this.dataGridViewTextBoxColumn56.HeaderText = "IMPORTE";
			this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
			this.dataGridViewTextBoxColumn56.ReadOnly = true;
			// 
			// IVA
			// 
			this.IVA.FillWeight = 80F;
			this.IVA.HeaderText = "IVA";
			this.IVA.Name = "IVA";
			this.IVA.ReadOnly = true;
			// 
			// TOTAL
			// 
			this.TOTAL.FillWeight = 80F;
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			// 
			// RAZON_SOCIAL1
			// 
			this.RAZON_SOCIAL1.FillWeight = 120F;
			this.RAZON_SOCIAL1.HeaderText = "RAZON_SOCIAL";
			this.RAZON_SOCIAL1.Name = "RAZON_SOCIAL1";
			this.RAZON_SOCIAL1.ReadOnly = true;
			// 
			// CONTRIBUYENTE1
			// 
			this.CONTRIBUYENTE1.FillWeight = 135F;
			this.CONTRIBUYENTE1.HeaderText = "CONTRIBUYENTE";
			this.CONTRIBUYENTE1.Name = "CONTRIBUYENTE1";
			this.CONTRIBUYENTE1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.FillWeight = 120F;
			this.dataGridViewTextBoxColumn5.HeaderText = "COMENTARIO";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// ORDEN_COMPRA
			// 
			this.ORDEN_COMPRA.HeaderText = "ORDEN COMPRA";
			this.ORDEN_COMPRA.Name = "ORDEN_COMPRA";
			this.ORDEN_COMPRA.ReadOnly = true;
			// 
			// FORMA_F
			// 
			this.FORMA_F.HeaderText = "FORMA_F";
			this.FORMA_F.Name = "FORMA_F";
			this.FORMA_F.ReadOnly = true;
			this.FORMA_F.Visible = false;
			// 
			// DESTINOF
			// 
			this.DESTINOF.FillWeight = 200F;
			this.DESTINOF.HeaderText = "METODO";
			this.DESTINOF.Name = "DESTINOF";
			// 
			// Column8
			// 
			this.Column8.FillWeight = 30F;
			this.Column8.HeaderText = "Ver";
			this.Column8.Image = ((System.Drawing.Image)(resources.GetObject("Column8.Image")));
			this.Column8.Name = "Column8";
			// 
			// MenuFactura
			// 
			this.MenuFactura.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem2,
									this.cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem,
									this.copiarDetalleDeFacturaToolStripMenuItem});
			this.MenuFactura.Name = "MenuEspeciales";
			this.MenuFactura.Size = new System.Drawing.Size(311, 70);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(310, 22);
			this.toolStripMenuItem2.Text = "Cancelar Factura";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
			// 
			// cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem
			// 
			this.cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem.Image")));
			this.cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem.Name = "cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem";
			this.cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
			this.cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem.Text = "Cancelar Factura y Regresar a Flujo en Ventas";
			this.cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem.Click += new System.EventHandler(this.CancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItemClick);
			// 
			// copiarDetalleDeFacturaToolStripMenuItem
			// 
			this.copiarDetalleDeFacturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarDetalleDeFacturaToolStripMenuItem.Image")));
			this.copiarDetalleDeFacturaToolStripMenuItem.Name = "copiarDetalleDeFacturaToolStripMenuItem";
			this.copiarDetalleDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(310, 22);
			this.copiarDetalleDeFacturaToolStripMenuItem.Text = "Copiar Detalle de Factura";
			this.copiarDetalleDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.CopiarDetalleDeFacturaToolStripMenuItemClick);
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel6.Controls.Add(this.lblAlerta);
			this.panel6.Controls.Add(this.dtpInicioOrdenFactura);
			this.panel6.Controls.Add(this.cbEliminadasOrdenFactura);
			this.panel6.Controls.Add(this.cmbBusquedaOrdenFactura);
			this.panel6.Controls.Add(this.dtpFinOrdenFactura);
			this.panel6.Controls.Add(this.txtBusquedaOrdenFactura);
			this.panel6.Controls.Add(this.label10);
			this.panel6.Controls.Add(this.label11);
			this.panel6.Location = new System.Drawing.Point(6, 6);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1091, 49);
			this.panel6.TabIndex = 146;
			// 
			// lblAlerta
			// 
			this.lblAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAlerta.Image = ((System.Drawing.Image)(resources.GetObject("lblAlerta.Image")));
			this.lblAlerta.Location = new System.Drawing.Point(947, 5);
			this.lblAlerta.Name = "lblAlerta";
			this.lblAlerta.Size = new System.Drawing.Size(43, 40);
			this.lblAlerta.TabIndex = 60;
			this.lblAlerta.Tag = "Servicios con factura pagados en efectivo ";
			this.lblAlerta.Visible = false;
			this.lblAlerta.Click += new System.EventHandler(this.LblAlertaClick);
			// 
			// dtpInicioOrdenFactura
			// 
			this.dtpInicioOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicioOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInicioOrdenFactura.Location = new System.Drawing.Point(32, 18);
			this.dtpInicioOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpInicioOrdenFactura.Name = "dtpInicioOrdenFactura";
			this.dtpInicioOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpInicioOrdenFactura.TabIndex = 57;
			this.dtpInicioOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			this.dtpInicioOrdenFactura.ValueChanged += new System.EventHandler(this.DtpInicioOrdenFacturaValueChanged);
			// 
			// cbEliminadasOrdenFactura
			// 
			this.cbEliminadasOrdenFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbEliminadasOrdenFactura.Location = new System.Drawing.Point(998, 15);
			this.cbEliminadasOrdenFactura.Name = "cbEliminadasOrdenFactura";
			this.cbEliminadasOrdenFactura.Size = new System.Drawing.Size(84, 24);
			this.cbEliminadasOrdenFactura.TabIndex = 59;
			this.cbEliminadasOrdenFactura.Text = "Todas";
			this.cbEliminadasOrdenFactura.UseVisualStyleBackColor = true;
			this.cbEliminadasOrdenFactura.CheckedChanged += new System.EventHandler(this.CbEliminadasOrdenFacturaCheckedChanged);
			// 
			// cmbBusquedaOrdenFactura
			// 
			this.cmbBusquedaOrdenFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBusquedaOrdenFactura.FormattingEnabled = true;
			this.cmbBusquedaOrdenFactura.Items.AddRange(new object[] {
									"ID_RE",
									"FOLIO",
									"CONTACTO",
									"CORREO",
									"EVENTO"});
			this.cmbBusquedaOrdenFactura.Location = new System.Drawing.Point(284, 17);
			this.cmbBusquedaOrdenFactura.Name = "cmbBusquedaOrdenFactura";
			this.cmbBusquedaOrdenFactura.Size = new System.Drawing.Size(113, 21);
			this.cmbBusquedaOrdenFactura.TabIndex = 55;
			this.cmbBusquedaOrdenFactura.SelectedIndexChanged += new System.EventHandler(this.CmbBusquedaOrdenFacturaSelectedIndexChanged);
			// 
			// dtpFinOrdenFactura
			// 
			this.dtpFinOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinOrdenFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinOrdenFactura.Location = new System.Drawing.Point(137, 18);
			this.dtpFinOrdenFactura.MinDate = new System.DateTime(2012, 10, 26, 0, 0, 0, 0);
			this.dtpFinOrdenFactura.Name = "dtpFinOrdenFactura";
			this.dtpFinOrdenFactura.Size = new System.Drawing.Size(81, 20);
			this.dtpFinOrdenFactura.TabIndex = 58;
			this.dtpFinOrdenFactura.Value = new System.DateTime(2012, 11, 7, 0, 0, 0, 0);
			this.dtpFinOrdenFactura.ValueChanged += new System.EventHandler(this.DtpFinOrdenFacturaValueChanged);
			// 
			// txtBusquedaOrdenFactura
			// 
			this.txtBusquedaOrdenFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBusquedaOrdenFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBusquedaOrdenFactura.Location = new System.Drawing.Point(414, 17);
			this.txtBusquedaOrdenFactura.Name = "txtBusquedaOrdenFactura";
			this.txtBusquedaOrdenFactura.Size = new System.Drawing.Size(187, 20);
			this.txtBusquedaOrdenFactura.TabIndex = 56;
			this.txtBusquedaOrdenFactura.TextChanged += new System.EventHandler(this.TxtBusquedaOrdenFacturaTextChanged);
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(117, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 12);
			this.label10.TabIndex = 17;
			this.label10.Text = "al";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(5, 22);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 12);
			this.label11.TabIndex = 14;
			this.label11.Text = "Del";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(985, 452);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 39);
			this.button2.TabIndex = 6;
			this.button2.Text = "Realizado";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "exclamation.png");
			// 
			// lblAvisoAnticipos
			// 
			this.lblAvisoAnticipos.Image = ((System.Drawing.Image)(resources.GetObject("lblAvisoAnticipos.Image")));
			this.lblAvisoAnticipos.Location = new System.Drawing.Point(100, 0);
			this.lblAvisoAnticipos.Name = "lblAvisoAnticipos";
			this.lblAvisoAnticipos.Size = new System.Drawing.Size(90, 15);
			this.lblAvisoAnticipos.TabIndex = 26;
			// 
			// lblAvisoFactura
			// 
			this.lblAvisoFactura.Image = ((System.Drawing.Image)(resources.GetObject("lblAvisoFactura.Image")));
			this.lblAvisoFactura.Location = new System.Drawing.Point(207, 0);
			this.lblAvisoFactura.Name = "lblAvisoFactura";
			this.lblAvisoFactura.Size = new System.Drawing.Size(90, 15);
			this.lblAvisoFactura.TabIndex = 27;
			// 
			// timer1
			// 
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// PrivilegiosPagos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1104, 539);
			this.Controls.Add(this.lblAvisoFactura);
			this.Controls.Add(this.lblAvisoAnticipos);
			this.Controls.Add(this.tcCobros);
			this.Controls.Add(this.cmdExcel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PrivilegiosPagos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control de Pagos de Servicios";
			this.TransparencyKey = System.Drawing.Color.Silver;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrivilegiosPagosFormClosing);
			this.Load += new System.EventHandler(this.PrivilegiosPagosLoad);
			this.tcCobros.ResumeLayout(false);
			this.tpEspeciales.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgRelacion)).EndInit();
			this.MenuEspeciales.ResumeLayout(false);
			this.tpAnticipos.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgAnticipos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgServiciosAnt)).EndInit();
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgOrdenFactura)).EndInit();
			this.MenuFactura.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cbEmpresariales;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripMenuItem imprimirIncobrableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copiarDetalleDeFacturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINOF;
		public System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblAlerta;
		private System.Windows.Forms.Label lblLimpiar;
		private System.Windows.Forms.TextBox txtOperador;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ContextMenuStrip MenuFactura;
		private System.Windows.Forms.Label lblFacturas;
		private System.Windows.Forms.Label lblPagar;
		private System.Windows.Forms.CheckBox cbValidados;
		private System.Windows.Forms.Label lblAvisoFactura;
		private System.Windows.Forms.Label lblAvisoAnticipos;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
		private System.Windows.Forms.ToolStripMenuItem incobrableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pagadoToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuEspeciales;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
		public System.Windows.Forms.CheckBox cbMostrarValidadosAnticipos;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURADO;
		private System.Windows.Forms.Button btnPagarServicio;
		private System.Windows.Forms.Button btnIncobrable;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn EFECTIVO;
		private System.Windows.Forms.DataGridViewImageColumn D;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_C;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn AGENCIA;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SALDO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ANTICIPOS;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COBRAR;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COTIZADO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_UNIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_REGRESO;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SALIDA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONTACTO;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpIncio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.ComboBox cbBusqueda;
		private System.Windows.Forms.DataGridViewTextBoxColumn UBICA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.DataGridViewTextBoxColumn Factura1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBusquedaOrdenFactura;
		private System.Windows.Forms.DateTimePicker dtpFinOrdenFactura;
		private System.Windows.Forms.ComboBox cmbBusquedaOrdenFactura;
		private System.Windows.Forms.CheckBox cbEliminadasOrdenFactura;
		private System.Windows.Forms.DateTimePicker dtpInicioOrdenFactura;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.DataGridViewImageColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn FORMA_F;
		private System.Windows.Forms.DataGridViewTextBoxColumn ORDEN_COMPRA;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn CONTRIBUYENTE1;
		private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
		private System.Windows.Forms.DataGridViewTextBoxColumn cant1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_RES;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		public System.Windows.Forms.DataGridView dgOrdenFactura;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridViewTextBoxColumn factura_d;
		private System.Windows.Forms.DataGridViewTextBoxColumn FACTURAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
		private System.Windows.Forms.DataGridViewTextBoxColumn SERVICIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dgServiciosAnt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_A;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_F;
		private System.Windows.Forms.DataGridView dgAnticipos;
		private System.Windows.Forms.Button cmdConfirmar;
		private System.Windows.Forms.RadioButton rbDepositos;
		private System.Windows.Forms.RadioButton rbEfectivo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TabPage tpAnticipos;
		private System.Windows.Forms.CheckBox cbPagados;
		private System.Windows.Forms.DataGridViewTextBoxColumn OP;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_re;
		public System.Windows.Forms.DataGridView dgRelacion;
		private System.Windows.Forms.TabPage tpEspeciales;
		private System.Windows.Forms.TabControl tcCobros;
		private System.Windows.Forms.Button cmdExcel;
		
	
	}
}
