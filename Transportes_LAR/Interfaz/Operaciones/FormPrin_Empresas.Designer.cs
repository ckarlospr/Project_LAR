/*
 * Created by SharpDevelop.
 * User: LarEquipo
 * Date: 11/09/2012
 * Time: 8:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz.Operaciones
{
	partial class FormPrin_Empresas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrin_Empresas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pPrincEmp = new System.Windows.Forms.Panel();
			this.txtBusqOper = new System.Windows.Forms.TextBox();
			this.lblBusqOpe = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTurno = new System.Windows.Forms.Label();
			this.lblDia = new System.Windows.Forms.Label();
			this.cmdOrden = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.cmdEliminaApoyo = new System.Windows.Forms.Button();
			this.cmdEliminarPrueb = new System.Windows.Forms.Button();
			this.cmdEliminarRec = new System.Windows.Forms.Button();
			this.cmdRepEmpresa = new System.Windows.Forms.Button();
			this.cmdSueldos = new System.Windows.Forms.Button();
			this.cmdRepCoord = new System.Windows.Forms.Button();
			this.cmdAutorizacion = new System.Windows.Forms.Button();
			this.btnUberTaXi = new System.Windows.Forms.Button();
			this.tcPrincipal = new System.Windows.Forms.TabControl();
			this.tpT1 = new System.Windows.Forms.TabPage();
			this.tpT2 = new System.Windows.Forms.TabPage();
			this.pSecundario = new System.Windows.Forms.Panel();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtMSJ = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dgApoyos = new System.Windows.Forms.DataGridView();
			this.id_apoyo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgPruebasRend = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgReconocimientos = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pListaEmp = new System.Windows.Forms.Panel();
			this.dgBusqueda = new System.Windows.Forms.DataGridView();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblAbrir = new System.Windows.Forms.Label();
			this.pOperadores = new System.Windows.Forms.Panel();
			this.cmdCerrar = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tcPrincipal.SuspendLayout();
			this.tpT1.SuspendLayout();
			this.tpT2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgApoyos)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPruebasRend)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgReconocimientos)).BeginInit();
			this.pListaEmp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).BeginInit();
			this.SuspendLayout();
			// 
			// pPrincEmp
			// 
			this.pPrincEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pPrincEmp.AutoScroll = true;
			this.pPrincEmp.Location = new System.Drawing.Point(0, 1);
			this.pPrincEmp.Name = "pPrincEmp";
			this.pPrincEmp.Size = new System.Drawing.Size(1111, 858);
			this.pPrincEmp.TabIndex = 0;
			// 
			// txtBusqOper
			// 
			this.txtBusqOper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBusqOper.BackColor = System.Drawing.SystemColors.Menu;
			this.txtBusqOper.Location = new System.Drawing.Point(981, 25);
			this.txtBusqOper.Name = "txtBusqOper";
			this.txtBusqOper.Size = new System.Drawing.Size(142, 20);
			this.txtBusqOper.TabIndex = 20;
			this.txtBusqOper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBusqOperMouseClick);
			this.txtBusqOper.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqOperKeyUp);
			// 
			// lblBusqOpe
			// 
			this.lblBusqOpe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBusqOpe.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBusqOpe.Location = new System.Drawing.Point(917, 25);
			this.lblBusqOpe.Name = "lblBusqOpe";
			this.lblBusqOpe.Size = new System.Drawing.Size(62, 19);
			this.lblBusqOpe.TabIndex = 7;
			this.lblBusqOpe.Text = "Operador:";
			this.lblBusqOpe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Location = new System.Drawing.Point(31, 1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(864, 45);
			this.label3.TabIndex = 8;
			this.label3.Text = "                  Operaciones";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTurno
			// 
			this.lblTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTurno.BackColor = System.Drawing.Color.White;
			this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTurno.Location = new System.Drawing.Point(651, 20);
			this.lblTurno.Name = "lblTurno";
			this.lblTurno.Size = new System.Drawing.Size(119, 23);
			this.lblTurno.TabIndex = 9;
			this.lblTurno.Text = "Turno";
			this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDia
			// 
			this.lblDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDia.BackColor = System.Drawing.Color.White;
			this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDia.Location = new System.Drawing.Point(776, 21);
			this.lblDia.Name = "lblDia";
			this.lblDia.Size = new System.Drawing.Size(119, 23);
			this.lblDia.TabIndex = 10;
			this.lblDia.Text = "Fecha";
			this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdOrden
			// 
			this.cmdOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdOrden.Location = new System.Drawing.Point(3, 3);
			this.cmdOrden.Name = "cmdOrden";
			this.cmdOrden.Size = new System.Drawing.Size(107, 23);
			this.cmdOrden.TabIndex = 11;
			this.cmdOrden.Text = "Orden";
			this.toolTip1.SetToolTip(this.cmdOrden, "Ordena las empresas");
			this.cmdOrden.UseVisualStyleBackColor = true;
			this.cmdOrden.Visible = false;
			this.cmdOrden.Click += new System.EventHandler(this.CmdOrdenClick);
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdImprimir.BackColor = System.Drawing.Color.Transparent;
			this.cmdImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.BackgroundImage")));
			this.cmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdImprimir.Location = new System.Drawing.Point(528, 3);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.Size = new System.Drawing.Size(49, 39);
			this.cmdImprimir.TabIndex = 25;
			this.toolTip1.SetToolTip(this.cmdImprimir, "Imprimir despacho completo");
			this.cmdImprimir.UseVisualStyleBackColor = false;
			this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
			// 
			// cmdEliminaApoyo
			// 
			this.cmdEliminaApoyo.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminaApoyo.Image")));
			this.cmdEliminaApoyo.Location = new System.Drawing.Point(431, 108);
			this.cmdEliminaApoyo.Name = "cmdEliminaApoyo";
			this.cmdEliminaApoyo.Size = new System.Drawing.Size(26, 23);
			this.cmdEliminaApoyo.TabIndex = 23;
			this.toolTip1.SetToolTip(this.cmdEliminaApoyo, "Eliminar registro");
			this.cmdEliminaApoyo.UseVisualStyleBackColor = true;
			this.cmdEliminaApoyo.Click += new System.EventHandler(this.CmdEliminaApoyoClick);
			// 
			// cmdEliminarPrueb
			// 
			this.cmdEliminarPrueb.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarPrueb.Image")));
			this.cmdEliminarPrueb.Location = new System.Drawing.Point(431, 108);
			this.cmdEliminarPrueb.Name = "cmdEliminarPrueb";
			this.cmdEliminarPrueb.Size = new System.Drawing.Size(27, 23);
			this.cmdEliminarPrueb.TabIndex = 24;
			this.toolTip1.SetToolTip(this.cmdEliminarPrueb, "Eliminar registro");
			this.cmdEliminarPrueb.UseVisualStyleBackColor = true;
			this.cmdEliminarPrueb.Click += new System.EventHandler(this.CmdEliminarPruebClick);
			// 
			// cmdEliminarRec
			// 
			this.cmdEliminarRec.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarRec.Image")));
			this.cmdEliminarRec.Location = new System.Drawing.Point(431, 108);
			this.cmdEliminarRec.Name = "cmdEliminarRec";
			this.cmdEliminarRec.Size = new System.Drawing.Size(26, 23);
			this.cmdEliminarRec.TabIndex = 23;
			this.toolTip1.SetToolTip(this.cmdEliminarRec, "Eliminar registro");
			this.cmdEliminarRec.UseVisualStyleBackColor = true;
			this.cmdEliminarRec.Click += new System.EventHandler(this.CmdEliminarRecClick);
			// 
			// cmdRepEmpresa
			// 
			this.cmdRepEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRepEmpresa.BackColor = System.Drawing.Color.Transparent;
			this.cmdRepEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRepEmpresa.BackgroundImage")));
			this.cmdRepEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdRepEmpresa.Location = new System.Drawing.Point(473, 3);
			this.cmdRepEmpresa.Name = "cmdRepEmpresa";
			this.cmdRepEmpresa.Size = new System.Drawing.Size(49, 39);
			this.cmdRepEmpresa.TabIndex = 26;
			this.toolTip1.SetToolTip(this.cmdRepEmpresa, "Reporte por empresa");
			this.cmdRepEmpresa.UseVisualStyleBackColor = false;
			this.cmdRepEmpresa.Click += new System.EventHandler(this.CmdRepEmpresaClick);
			// 
			// cmdSueldos
			// 
			this.cmdSueldos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdSueldos.BackColor = System.Drawing.Color.Transparent;
			this.cmdSueldos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSueldos.BackgroundImage")));
			this.cmdSueldos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdSueldos.Location = new System.Drawing.Point(418, 3);
			this.cmdSueldos.Name = "cmdSueldos";
			this.cmdSueldos.Size = new System.Drawing.Size(49, 39);
			this.cmdSueldos.TabIndex = 30;
			this.toolTip1.SetToolTip(this.cmdSueldos, "Tabla de salario hasta el momento");
			this.cmdSueldos.UseVisualStyleBackColor = false;
			this.cmdSueldos.Click += new System.EventHandler(this.CmdSueldosClick);
			// 
			// cmdRepCoord
			// 
			this.cmdRepCoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdRepCoord.BackColor = System.Drawing.Color.Transparent;
			this.cmdRepCoord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRepCoord.BackgroundImage")));
			this.cmdRepCoord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdRepCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdRepCoord.Location = new System.Drawing.Point(584, 3);
			this.cmdRepCoord.Name = "cmdRepCoord";
			this.cmdRepCoord.Size = new System.Drawing.Size(49, 39);
			this.cmdRepCoord.TabIndex = 31;
			this.toolTip1.SetToolTip(this.cmdRepCoord, "Imprimir despacho completo");
			this.cmdRepCoord.UseVisualStyleBackColor = false;
			this.cmdRepCoord.Click += new System.EventHandler(this.CmdRepCoordClick);
			// 
			// cmdAutorizacion
			// 
			this.cmdAutorizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAutorizacion.BackColor = System.Drawing.Color.Transparent;
			this.cmdAutorizacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdAutorizacion.BackgroundImage")));
			this.cmdAutorizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdAutorizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAutorizacion.Location = new System.Drawing.Point(363, 3);
			this.cmdAutorizacion.Name = "cmdAutorizacion";
			this.cmdAutorizacion.Size = new System.Drawing.Size(49, 39);
			this.cmdAutorizacion.TabIndex = 32;
			this.toolTip1.SetToolTip(this.cmdAutorizacion, "Autorizaciónes de Combustible");
			this.cmdAutorizacion.UseVisualStyleBackColor = false;
			this.cmdAutorizacion.Click += new System.EventHandler(this.CmdAutorizacionClick);
			// 
			// btnUberTaXi
			// 
			this.btnUberTaXi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUberTaXi.BackColor = System.Drawing.Color.Transparent;
			this.btnUberTaXi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUberTaXi.BackgroundImage")));
			this.btnUberTaXi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnUberTaXi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUberTaXi.Location = new System.Drawing.Point(308, 4);
			this.btnUberTaXi.Name = "btnUberTaXi";
			this.btnUberTaXi.Size = new System.Drawing.Size(49, 39);
			this.btnUberTaXi.TabIndex = 33;
			this.toolTip1.SetToolTip(this.btnUberTaXi, "Uber- Taxi");
			this.btnUberTaXi.UseVisualStyleBackColor = false;
			this.btnUberTaXi.Click += new System.EventHandler(this.BtnUberTaXiClick);
			// 
			// tcPrincipal
			// 
			this.tcPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.tcPrincipal.Controls.Add(this.tpT1);
			this.tcPrincipal.Controls.Add(this.tpT2);
			this.tcPrincipal.Controls.Add(this.tabPage1);
			this.tcPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tcPrincipal.Location = new System.Drawing.Point(9, 46);
			this.tcPrincipal.Name = "tcPrincipal";
			this.tcPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tcPrincipal.SelectedIndex = 0;
			this.tcPrincipal.Size = new System.Drawing.Size(1122, 885);
			this.tcPrincipal.TabIndex = 15;
			this.tcPrincipal.Tag = "";
			// 
			// tpT1
			// 
			this.tpT1.BackColor = System.Drawing.Color.Tan;
			this.tpT1.Controls.Add(this.pPrincEmp);
			this.tpT1.Location = new System.Drawing.Point(4, 4);
			this.tpT1.Name = "tpT1";
			this.tpT1.Padding = new System.Windows.Forms.Padding(3);
			this.tpT1.Size = new System.Drawing.Size(1114, 859);
			this.tpT1.TabIndex = 0;
			this.tpT1.Text = "Turno 1";
			// 
			// tpT2
			// 
			this.tpT2.BackColor = System.Drawing.Color.Tan;
			this.tpT2.Controls.Add(this.pSecundario);
			this.tpT2.Location = new System.Drawing.Point(4, 4);
			this.tpT2.Name = "tpT2";
			this.tpT2.Padding = new System.Windows.Forms.Padding(3);
			this.tpT2.Size = new System.Drawing.Size(1114, 859);
			this.tpT2.TabIndex = 1;
			this.tpT2.Text = "Turno 2";
			// 
			// pSecundario
			// 
			this.pSecundario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pSecundario.AutoScroll = true;
			this.pSecundario.Location = new System.Drawing.Point(0, 0);
			this.pSecundario.Name = "pSecundario";
			this.pSecundario.Size = new System.Drawing.Size(1112, 859);
			this.pSecundario.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Tan;
			this.tabPage1.Controls.Add(this.groupBox4);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1114, 859);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Mensajes";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.txtMSJ);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(6, 454);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(958, 185);
			this.groupBox4.TabIndex = 26;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Mensajes:";
			// 
			// txtMSJ
			// 
			this.txtMSJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMSJ.BackColor = System.Drawing.Color.Moccasin;
			this.txtMSJ.ForeColor = System.Drawing.Color.Tomato;
			this.txtMSJ.Location = new System.Drawing.Point(11, 21);
			this.txtMSJ.Multiline = true;
			this.txtMSJ.Name = "txtMSJ";
			this.txtMSJ.Size = new System.Drawing.Size(938, 149);
			this.txtMSJ.TabIndex = 0;
			this.txtMSJ.Text = "Mensaje";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmdEliminaApoyo);
			this.groupBox3.Controls.Add(this.panel4);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(6, 162);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(463, 140);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Apoyos:";
			// 
			// panel4
			// 
			this.panel4.AutoScroll = true;
			this.panel4.Controls.Add(this.dgApoyos);
			this.panel4.Location = new System.Drawing.Point(6, 21);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(422, 113);
			this.panel4.TabIndex = 22;
			// 
			// dgApoyos
			// 
			this.dgApoyos.AllowUserToAddRows = false;
			this.dgApoyos.AllowUserToResizeColumns = false;
			this.dgApoyos.AllowUserToResizeRows = false;
			this.dgApoyos.BackgroundColor = System.Drawing.Color.Tan;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgApoyos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgApoyos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgApoyos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id_apoyo,
									this.Operador,
									this.tipo,
									this.coment,
									this.Ruta,
									this.Usuario,
									this.Empresa});
			this.dgApoyos.Location = new System.Drawing.Point(3, 2);
			this.dgApoyos.Name = "dgApoyos";
			this.dgApoyos.RowHeadersVisible = false;
			this.dgApoyos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgApoyos.Size = new System.Drawing.Size(416, 108);
			this.dgApoyos.TabIndex = 0;
			// 
			// id_apoyo
			// 
			this.id_apoyo.HeaderText = "ID";
			this.id_apoyo.Name = "id_apoyo";
			this.id_apoyo.ReadOnly = true;
			this.id_apoyo.Visible = false;
			// 
			// Operador
			// 
			this.Operador.HeaderText = "OPERADOR";
			this.Operador.Name = "Operador";
			this.Operador.ReadOnly = true;
			// 
			// tipo
			// 
			this.tipo.HeaderText = "TIPO";
			this.tipo.Name = "tipo";
			this.tipo.ReadOnly = true;
			// 
			// coment
			// 
			this.coment.HeaderText = "COMENTARIOS";
			this.coment.Name = "coment";
			this.coment.ReadOnly = true;
			this.coment.Width = 200;
			// 
			// Ruta
			// 
			this.Ruta.HeaderText = "RUTA";
			this.Ruta.Name = "Ruta";
			// 
			// Usuario
			// 
			this.Usuario.HeaderText = "USUARIO";
			this.Usuario.Name = "Usuario";
			// 
			// Empresa
			// 
			this.Empresa.HeaderText = "EMPRESA";
			this.Empresa.Name = "Empresa";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmdEliminarPrueb);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(6, 308);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(463, 140);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pruebas de rendimiento:";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.dgPruebasRend);
			this.panel1.Location = new System.Drawing.Point(6, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(422, 113);
			this.panel1.TabIndex = 21;
			// 
			// dgPruebasRend
			// 
			this.dgPruebasRend.AllowUserToAddRows = false;
			this.dgPruebasRend.AllowUserToResizeColumns = false;
			this.dgPruebasRend.AllowUserToResizeRows = false;
			this.dgPruebasRend.BackgroundColor = System.Drawing.Color.Tan;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPruebasRend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgPruebasRend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPruebasRend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column3,
									this.Column4,
									this.Column6});
			this.dgPruebasRend.Location = new System.Drawing.Point(3, 3);
			this.dgPruebasRend.Name = "dgPruebasRend";
			this.dgPruebasRend.RowHeadersVisible = false;
			this.dgPruebasRend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPruebasRend.Size = new System.Drawing.Size(416, 107);
			this.dgPruebasRend.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID_R";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "OPERADOR";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "SUPERVISOR";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 150;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "RUTA";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 150;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmdEliminarRec);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(463, 140);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Reconocimiento de rutas:";
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.dgReconocimientos);
			this.panel2.Location = new System.Drawing.Point(6, 21);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(422, 113);
			this.panel2.TabIndex = 22;
			// 
			// dgReconocimientos
			// 
			this.dgReconocimientos.AllowUserToAddRows = false;
			this.dgReconocimientos.AllowUserToResizeColumns = false;
			this.dgReconocimientos.AllowUserToResizeRows = false;
			this.dgReconocimientos.BackgroundColor = System.Drawing.Color.Tan;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgReconocimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgReconocimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgReconocimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4,
									this.dataGridViewTextBoxColumn6});
			this.dgReconocimientos.Location = new System.Drawing.Point(3, 2);
			this.dgReconocimientos.Name = "dgReconocimientos";
			this.dgReconocimientos.RowHeadersVisible = false;
			this.dgReconocimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgReconocimientos.Size = new System.Drawing.Size(416, 108);
			this.dgReconocimientos.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "IDO1";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "RECONOCE";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "MUESTRA";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "RUTA";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 200;
			// 
			// pListaEmp
			// 
			this.pListaEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pListaEmp.BackColor = System.Drawing.Color.White;
			this.pListaEmp.Controls.Add(this.dgBusqueda);
			this.pListaEmp.Controls.Add(this.cmdOrden);
			this.pListaEmp.Location = new System.Drawing.Point(-2, 46);
			this.pListaEmp.Name = "pListaEmp";
			this.pListaEmp.Size = new System.Drawing.Size(12, 884);
			this.pListaEmp.TabIndex = 24;
			this.pListaEmp.MouseEnter += new System.EventHandler(this.PListaEmpMouseEnter);
			// 
			// dgBusqueda
			// 
			this.dgBusqueda.AllowUserToAddRows = false;
			this.dgBusqueda.AllowUserToResizeColumns = false;
			this.dgBusqueda.AllowUserToResizeRows = false;
			this.dgBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgBusqueda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column7,
									this.Column8});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgBusqueda.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgBusqueda.Location = new System.Drawing.Point(3, 32);
			this.dgBusqueda.Name = "dgBusqueda";
			this.dgBusqueda.RowHeadersVisible = false;
			this.dgBusqueda.Size = new System.Drawing.Size(6, 849);
			this.dgBusqueda.TabIndex = 0;
			this.dgBusqueda.Visible = false;
			this.dgBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgBusquedaCellClick);
			this.dgBusqueda.MouseEnter += new System.EventHandler(this.DgBusquedaMouseEnter);
			this.dgBusqueda.MouseLeave += new System.EventHandler(this.DgBusquedaMouseLeave);
			// 
			// Column7
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
			this.Column7.HeaderText = "Empresa";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "EMP";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Visible = false;
			// 
			// lblAbrir
			// 
			this.lblAbrir.BackColor = System.Drawing.SystemColors.Menu;
			this.lblAbrir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAbrir.Location = new System.Drawing.Point(3, 20);
			this.lblAbrir.Name = "lblAbrir";
			this.lblAbrir.Size = new System.Drawing.Size(22, 23);
			this.lblAbrir.TabIndex = 27;
			this.lblAbrir.Text = ">";
			this.lblAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblAbrir.Click += new System.EventHandler(this.LblAbrirClick);
			// 
			// pOperadores
			// 
			this.pOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pOperadores.Location = new System.Drawing.Point(1153, 46);
			this.pOperadores.Name = "pOperadores";
			this.pOperadores.Size = new System.Drawing.Size(33, 885);
			this.pOperadores.TabIndex = 28;
			// 
			// cmdCerrar
			// 
			this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.BackgroundImage")));
			this.cmdCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCerrar.ForeColor = System.Drawing.Color.Red;
			this.cmdCerrar.Location = new System.Drawing.Point(1099, 1);
			this.cmdCerrar.Name = "cmdCerrar";
			this.cmdCerrar.Size = new System.Drawing.Size(26, 23);
			this.cmdCerrar.TabIndex = 29;
			this.cmdCerrar.UseVisualStyleBackColor = true;
			this.cmdCerrar.Click += new System.EventHandler(this.CmdCerrarClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 7000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// FormPrin_Empresas
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1132, 935);
			this.Controls.Add(this.btnUberTaXi);
			this.Controls.Add(this.cmdAutorizacion);
			this.Controls.Add(this.cmdRepCoord);
			this.Controls.Add(this.cmdSueldos);
			this.Controls.Add(this.cmdCerrar);
			this.Controls.Add(this.pOperadores);
			this.Controls.Add(this.lblAbrir);
			this.Controls.Add(this.cmdRepEmpresa);
			this.Controls.Add(this.cmdImprimir);
			this.Controls.Add(this.pListaEmp);
			this.Controls.Add(this.tcPrincipal);
			this.Controls.Add(this.lblDia);
			this.Controls.Add(this.lblTurno);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblBusqOpe);
			this.Controls.Add(this.txtBusqOper);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormPrin_Empresas";
			this.Text = "Transportes LAR - Operaciones";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrin_EmpresasFormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrin_EmpresasFormClosed);
			this.Load += new System.EventHandler(this.FormPrin_EmpresasLoad);
			this.SizeChanged += new System.EventHandler(this.FormPrin_EmpresasSizeChanged);
			this.tcPrincipal.ResumeLayout(false);
			this.tpT1.ResumeLayout(false);
			this.tpT2.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgApoyos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPruebasRend)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgReconocimientos)).EndInit();
			this.pListaEmp.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgBusqueda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnUberTaXi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
		private System.Windows.Forms.Button cmdAutorizacion;
		private System.Windows.Forms.Button cmdRepCoord;
		private System.Windows.Forms.Button cmdSueldos;
		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.Panel pOperadores;
		private System.Windows.Forms.Label lblAbrir;
		private System.Windows.Forms.Button cmdRepEmpresa;
		private System.Windows.Forms.TextBox txtMSJ;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridViewTextBoxColumn coment;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_apoyo;
		private System.Windows.Forms.DataGridView dgApoyos;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button cmdEliminaApoyo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button cmdEliminarRec;
		private System.Windows.Forms.Button cmdEliminarPrueb;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button cmdImprimir;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridView dgBusqueda;
		private System.Windows.Forms.Panel pListaEmp;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView dgReconocimientos;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgPruebasRend;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel pSecundario;
		public System.Windows.Forms.TabPage tpT2;
		public System.Windows.Forms.TabPage tpT1;
		public System.Windows.Forms.TabControl tcPrincipal;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button cmdOrden;
		public System.Windows.Forms.Label lblDia;
		public System.Windows.Forms.Label lblTurno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblBusqOpe;
		public System.Windows.Forms.TextBox txtBusqOper;
		
		
		public System.Windows.Forms.Panel pPrincEmp;
	}
}
