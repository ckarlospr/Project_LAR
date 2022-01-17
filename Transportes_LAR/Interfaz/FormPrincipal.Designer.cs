/*
 * Created by SharpDevelop.
 * User: Equipo
 * Date: 11/07/2012
 * Time: 7:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Transportes_LAR.Interfaz
{
	partial class FormPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblDatoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblNivelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblDatoNivel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.progressbarPrin = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolAptoMedico = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolContrato = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolLicencia = new System.Windows.Forms.ToolStripSplitButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tlUsuario = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAgregarCuenta = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuBusquedaUsuario = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCambioPwd = new System.Windows.Forms.ToolStripMenuItem();
			this.tlEmpleado = new System.Windows.Forms.ToolStripMenuItem();
			this.contratacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controlDeLlamadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarCandidatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.controlDeSelecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemNuevoAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemBuscarAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOperador = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarOperadorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rutaOperadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOperadorExterno = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuPuesto = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuExperienciaLaboral = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCuentaBancaria = new System.Windows.Forms.ToolStripMenuItem();
			this.tlDirectorio = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCaras = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTelefonico = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemDirectorioTelefonicoExcel = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemDirectorioTelefonicoPDF = new System.Windows.Forms.ToolStripMenuItem();
			this.tlCliente = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCatalogoEmpresa = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuContratoEmpresa = new System.Windows.Forms.ToolStripMenuItem();
			this.tlVehiculo = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAseguradora = new System.Windows.Forms.ToolStripMenuItem();
			this.aseguradoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.seguroVehicularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuVehiculo = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemAgregarVehiculo = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemBusquedaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOperadorVehiculo = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemHistorialOperadorVehículo = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemOperadorVehículo = new System.Windows.Forms.ToolStripMenuItem();
			this.gestoríaVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.revisiónDePlacasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlRuta = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuRutaSin = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOperadorRuta = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCostoRutaFactura = new System.Windows.Forms.ToolStripMenuItem();
			this.itemforsac = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuRutas = new System.Windows.Forms.ToolStripMenuItem();
			this.tlEspeciales = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteEspeciales = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteFacturacion = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSueldoEspeciales = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteValidacion = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuEspecialPendiente = new System.Windows.Forms.ToolStripMenuItem();
			this.revisiónEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlModulos = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCaja = new System.Windows.Forms.ToolStripMenuItem();
			this.ModuloChecador = new System.Windows.Forms.ToolStripMenuItem();
			this.ModuloCombustible = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuPrincipalCombustible = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCombustibleComplementos = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuExtrasComb = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuDatosComb = new System.Windows.Forms.ToolStripMenuItem();
			this.validarOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pruebaRendimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ModuloDespacho = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuDespacho = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuMensajesDespacho = new System.Windows.Forms.ToolStripMenuItem();
			this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reporteViajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ModuloFacturacion = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuFacturacion = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuPrecioFactura = new System.Windows.Forms.ToolStripMenuItem();
			this.preciosFacturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controlFactutaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuOrdenTrabajo = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteDiario = new System.Windows.Forms.ToolStripMenuItem();
			this.entregaYRecepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bitácoraDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuESVehiculos = new System.Windows.Forms.ToolStripMenuItem();
			this.ModuloNomina = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuBono = new System.Windows.Forms.ToolStripMenuItem();
			this.Menuanticipos = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuControlDescuentos = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTaxi = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuNomina = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuIncapacidad = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuPercepcionesDeducciones = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSueldoOperador = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSueldoAdministrativo = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTelcel = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuImporteNomina = new System.Windows.Forms.ToolStripMenuItem();
			this.reporteRutasNominalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nominaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuVentas = new System.Windows.Forms.ToolStripMenuItem();
			this.ventas2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.libroVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cobroEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.validaciónEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controlDeGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uberTaxiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reporteUberTaxiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlReportes = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCardex = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteCombustible = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteGerencial = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteOperaciones = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteNomina = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuReporteBonificaiones = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuHorarioRutas = new System.Windows.Forms.ToolStripMenuItem();
			this.horarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viajesPorOperadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.altasBajaOperadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlSoftware = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuUnir = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAdobe = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuGrafico = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuChat = new System.Windows.Forms.ToolStripMenuItem();
			this.tlArchivo = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuServidor = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarConfiguraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuCambiarUser = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuConsulta = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenu = new System.Windows.Forms.ToolStrip();
			this.tsbVentas = new System.Windows.Forms.ToolStripButton();
			this.tsbOperadorVehiculo = new System.Windows.Forms.ToolStripButton();
			this.tsbDespacho = new System.Windows.Forms.ToolStripButton();
			this.tsbLlamadaCandidato = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Tan;
			this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.statusStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel3,
									this.toolStripStatusLabel2,
									this.lblUsuario,
									this.toolStripStatusLabel4,
									this.lblDatoUsuario,
									this.lblNivelUsuario,
									this.lblDatoNivel,
									this.toolStripStatusLabel1,
									this.progressbarPrin,
									this.toolStripStatusLabel5,
									this.toolAptoMedico,
									this.toolContrato,
									this.toolLicencia});
			this.statusStrip1.Location = new System.Drawing.Point(0, 724);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStrip1.Size = new System.Drawing.Size(1360, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(22, 17);
			this.toolStripStatusLabel3.Text = "     ";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 17);
			this.toolStripStatusLabel2.Text = "     ";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(13, 17);
			this.lblUsuario.Text = "*";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
			// 
			// lblDatoUsuario
			// 
			this.lblDatoUsuario.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatoUsuario.Name = "lblDatoUsuario";
			this.lblDatoUsuario.Size = new System.Drawing.Size(13, 17);
			this.lblDatoUsuario.Text = "*";
			// 
			// lblNivelUsuario
			// 
			this.lblNivelUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNivelUsuario.Name = "lblNivelUsuario";
			this.lblNivelUsuario.Size = new System.Drawing.Size(13, 17);
			this.lblNivelUsuario.Text = "*";
			// 
			// lblDatoNivel
			// 
			this.lblDatoNivel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatoNivel.Name = "lblDatoNivel";
			this.lblDatoNivel.Size = new System.Drawing.Size(13, 17);
			this.lblDatoNivel.Text = "*";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
			this.toolStripStatusLabel1.Text = "   ";
			// 
			// progressbarPrin
			// 
			this.progressbarPrin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.progressbarPrin.BackColor = System.Drawing.Color.MidnightBlue;
			this.progressbarPrin.Name = "progressbarPrin";
			this.progressbarPrin.Size = new System.Drawing.Size(200, 16);
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(16, 17);
			this.toolStripStatusLabel5.Text = "   ";
			// 
			// toolAptoMedico
			// 
			this.toolAptoMedico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolAptoMedico.Image = ((System.Drawing.Image)(resources.GetObject("toolAptoMedico.Image")));
			this.toolAptoMedico.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolAptoMedico.Name = "toolAptoMedico";
			this.toolAptoMedico.Size = new System.Drawing.Size(116, 20);
			this.toolAptoMedico.Text = "Apto Médico";
			this.toolAptoMedico.Visible = false;
			this.toolAptoMedico.Click += new System.EventHandler(this.ToolAptoMedicoClick);
			// 
			// toolContrato
			// 
			this.toolContrato.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolContrato.Image = ((System.Drawing.Image)(resources.GetObject("toolContrato.Image")));
			this.toolContrato.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolContrato.Name = "toolContrato";
			this.toolContrato.Size = new System.Drawing.Size(97, 20);
			this.toolContrato.Text = "Contratos";
			this.toolContrato.Visible = false;
			this.toolContrato.Click += new System.EventHandler(this.ToolContratoClick);
			// 
			// toolLicencia
			// 
			this.toolLicencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolLicencia.Image = ((System.Drawing.Image)(resources.GetObject("toolLicencia.Image")));
			this.toolLicencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolLicencia.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolLicencia.Name = "toolLicencia";
			this.toolLicencia.Size = new System.Drawing.Size(100, 20);
			this.toolLicencia.Text = "Licencias";
			this.toolLicencia.Visible = false;
			this.toolLicencia.ButtonClick += new System.EventHandler(this.ToolLicenciaButtonClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Tan;
			this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tlUsuario,
									this.tlEmpleado,
									this.tlDirectorio,
									this.tlCliente,
									this.tlVehiculo,
									this.tlRuta,
									this.tlEspeciales,
									this.tlModulos,
									this.tlReportes,
									this.tlSoftware,
									this.tlArchivo});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(1360, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tlUsuario
			// 
			this.tlUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuAgregarCuenta,
									this.MenuBusquedaUsuario,
									this.MenuCambioPwd});
			this.tlUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tlUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tlUsuario.Image")));
			this.tlUsuario.Name = "tlUsuario";
			this.tlUsuario.Size = new System.Drawing.Size(79, 20);
			this.tlUsuario.Text = "Usuario";
			// 
			// MenuAgregarCuenta
			// 
			this.MenuAgregarCuenta.Image = ((System.Drawing.Image)(resources.GetObject("MenuAgregarCuenta.Image")));
			this.MenuAgregarCuenta.Name = "MenuAgregarCuenta";
			this.MenuAgregarCuenta.Size = new System.Drawing.Size(290, 22);
			this.MenuAgregarCuenta.Text = "Agregar cuenta";
			this.MenuAgregarCuenta.Click += new System.EventHandler(this.AgregarCuentaToolStripMenuItemClick);
			// 
			// MenuBusquedaUsuario
			// 
			this.MenuBusquedaUsuario.Image = ((System.Drawing.Image)(resources.GetObject("MenuBusquedaUsuario.Image")));
			this.MenuBusquedaUsuario.Name = "MenuBusquedaUsuario";
			this.MenuBusquedaUsuario.Size = new System.Drawing.Size(290, 22);
			this.MenuBusquedaUsuario.Text = "Busqueda usuario (Modificar/Eliminar)";
			this.MenuBusquedaUsuario.Click += new System.EventHandler(this.ModificarCuentaToolStripMenuItemClick);
			// 
			// MenuCambioPwd
			// 
			this.MenuCambioPwd.Image = ((System.Drawing.Image)(resources.GetObject("MenuCambioPwd.Image")));
			this.MenuCambioPwd.Name = "MenuCambioPwd";
			this.MenuCambioPwd.Size = new System.Drawing.Size(290, 22);
			this.MenuCambioPwd.Text = "Cambiar usuario o contraseña";
			this.MenuCambioPwd.Click += new System.EventHandler(this.ConfigurarMiCuentaToolStripMenuItemClick);
			// 
			// tlEmpleado
			// 
			this.tlEmpleado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.contratacionToolStripMenuItem,
									this.MenuAdministrativo,
									this.MenuOperador,
									this.MenuOperadorExterno,
									this.MenuPuesto,
									this.MenuExperienciaLaboral,
									this.MenuCuentaBancaria});
			this.tlEmpleado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tlEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("tlEmpleado.Image")));
			this.tlEmpleado.Name = "tlEmpleado";
			this.tlEmpleado.Size = new System.Drawing.Size(91, 20);
			this.tlEmpleado.Text = "Empleado";
			// 
			// contratacionToolStripMenuItem
			// 
			this.contratacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.controlDeLlamadasToolStripMenuItem,
									this.registrarCandidatoToolStripMenuItem1,
									this.controlDeSelecciónToolStripMenuItem});
			this.contratacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contratacionToolStripMenuItem.Image")));
			this.contratacionToolStripMenuItem.Name = "contratacionToolStripMenuItem";
			this.contratacionToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.contratacionToolStripMenuItem.Text = "Proceso de Selección";
			// 
			// controlDeLlamadasToolStripMenuItem
			// 
			this.controlDeLlamadasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlDeLlamadasToolStripMenuItem.Image")));
			this.controlDeLlamadasToolStripMenuItem.Name = "controlDeLlamadasToolStripMenuItem";
			this.controlDeLlamadasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.controlDeLlamadasToolStripMenuItem.Text = "Registro de Llamadas";
			this.controlDeLlamadasToolStripMenuItem.Click += new System.EventHandler(this.ControlDeLlamadasToolStripMenuItemClick);
			// 
			// registrarCandidatoToolStripMenuItem1
			// 
			this.registrarCandidatoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("registrarCandidatoToolStripMenuItem1.Image")));
			this.registrarCandidatoToolStripMenuItem1.Name = "registrarCandidatoToolStripMenuItem1";
			this.registrarCandidatoToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
			this.registrarCandidatoToolStripMenuItem1.Text = "Registrar Candidato";
			this.registrarCandidatoToolStripMenuItem1.Click += new System.EventHandler(this.RegistrarCandidatoToolStripMenuItem1Click);
			// 
			// controlDeSelecciónToolStripMenuItem
			// 
			this.controlDeSelecciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlDeSelecciónToolStripMenuItem.Image")));
			this.controlDeSelecciónToolStripMenuItem.Name = "controlDeSelecciónToolStripMenuItem";
			this.controlDeSelecciónToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.controlDeSelecciónToolStripMenuItem.Text = "Control de Selección";
			this.controlDeSelecciónToolStripMenuItem.Click += new System.EventHandler(this.ControlDeSelecciónToolStripMenuItemClick);
			// 
			// MenuAdministrativo
			// 
			this.MenuAdministrativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ItemNuevoAdmin,
									this.ItemBuscarAdmin});
			this.MenuAdministrativo.Image = ((System.Drawing.Image)(resources.GetObject("MenuAdministrativo.Image")));
			this.MenuAdministrativo.Name = "MenuAdministrativo";
			this.MenuAdministrativo.Size = new System.Drawing.Size(198, 22);
			this.MenuAdministrativo.Text = "Administrativo";
			// 
			// ItemNuevoAdmin
			// 
			this.ItemNuevoAdmin.Image = ((System.Drawing.Image)(resources.GetObject("ItemNuevoAdmin.Image")));
			this.ItemNuevoAdmin.Name = "ItemNuevoAdmin";
			this.ItemNuevoAdmin.Size = new System.Drawing.Size(171, 22);
			this.ItemNuevoAdmin.Text = "Agregar nuevo...";
			this.ItemNuevoAdmin.Click += new System.EventHandler(this.ItemNuevoAdminClick);
			// 
			// ItemBuscarAdmin
			// 
			this.ItemBuscarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("ItemBuscarAdmin.Image")));
			this.ItemBuscarAdmin.Name = "ItemBuscarAdmin";
			this.ItemBuscarAdmin.Size = new System.Drawing.Size(171, 22);
			this.ItemBuscarAdmin.Text = "Buscar/Modificar";
			this.ItemBuscarAdmin.Click += new System.EventHandler(this.ItemBuscarAdminClick);
			// 
			// MenuOperador
			// 
			this.MenuOperador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.agregarOperadorToolStrip,
									this.buscarModificarToolStripMenuItem,
									this.rutaOperadorToolStripMenuItem});
			this.MenuOperador.Image = ((System.Drawing.Image)(resources.GetObject("MenuOperador.Image")));
			this.MenuOperador.Name = "MenuOperador";
			this.MenuOperador.Size = new System.Drawing.Size(198, 22);
			this.MenuOperador.Text = "Operador";
			// 
			// agregarOperadorToolStrip
			// 
			this.agregarOperadorToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("agregarOperadorToolStrip.Image")));
			this.agregarOperadorToolStrip.Name = "agregarOperadorToolStrip";
			this.agregarOperadorToolStrip.Size = new System.Drawing.Size(171, 22);
			this.agregarOperadorToolStrip.Text = "Agregar nuevo...";
			this.agregarOperadorToolStrip.Click += new System.EventHandler(this.AgregarOperadorToolStripClick);
			// 
			// buscarModificarToolStripMenuItem
			// 
			this.buscarModificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarModificarToolStripMenuItem.Image")));
			this.buscarModificarToolStripMenuItem.Name = "buscarModificarToolStripMenuItem";
			this.buscarModificarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.buscarModificarToolStripMenuItem.Text = "Buscar/Modificar";
			this.buscarModificarToolStripMenuItem.Click += new System.EventHandler(this.BuscarModificarToolStripMenuItemClick);
			// 
			// rutaOperadorToolStripMenuItem
			// 
			this.rutaOperadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rutaOperadorToolStripMenuItem.Image")));
			this.rutaOperadorToolStripMenuItem.Name = "rutaOperadorToolStripMenuItem";
			this.rutaOperadorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.rutaOperadorToolStripMenuItem.Text = "Ruta-Operador";
			this.rutaOperadorToolStripMenuItem.Click += new System.EventHandler(this.RutaOperadorToolStripMenuItemClick);
			// 
			// MenuOperadorExterno
			// 
			this.MenuOperadorExterno.Image = ((System.Drawing.Image)(resources.GetObject("MenuOperadorExterno.Image")));
			this.MenuOperadorExterno.Name = "MenuOperadorExterno";
			this.MenuOperadorExterno.Size = new System.Drawing.Size(198, 22);
			this.MenuOperadorExterno.Text = "Operador Externo";
			this.MenuOperadorExterno.Click += new System.EventHandler(this.OperadorExternoToolStripMenuItemClick);
			// 
			// MenuPuesto
			// 
			this.MenuPuesto.Image = ((System.Drawing.Image)(resources.GetObject("MenuPuesto.Image")));
			this.MenuPuesto.Name = "MenuPuesto";
			this.MenuPuesto.Size = new System.Drawing.Size(198, 22);
			this.MenuPuesto.Text = "Puesto";
			this.MenuPuesto.Click += new System.EventHandler(this.MenuPuestoClick);
			// 
			// MenuExperienciaLaboral
			// 
			this.MenuExperienciaLaboral.Image = ((System.Drawing.Image)(resources.GetObject("MenuExperienciaLaboral.Image")));
			this.MenuExperienciaLaboral.Name = "MenuExperienciaLaboral";
			this.MenuExperienciaLaboral.Size = new System.Drawing.Size(198, 22);
			this.MenuExperienciaLaboral.Text = "Experiencia Laboral";
			this.MenuExperienciaLaboral.Click += new System.EventHandler(this.MenuExperienciaLaboralClick);
			// 
			// MenuCuentaBancaria
			// 
			this.MenuCuentaBancaria.Image = ((System.Drawing.Image)(resources.GetObject("MenuCuentaBancaria.Image")));
			this.MenuCuentaBancaria.Name = "MenuCuentaBancaria";
			this.MenuCuentaBancaria.Size = new System.Drawing.Size(198, 22);
			this.MenuCuentaBancaria.Text = "Cuenta Bancaria";
			this.MenuCuentaBancaria.Click += new System.EventHandler(this.MenuCuentaBancariaClick);
			// 
			// tlDirectorio
			// 
			this.tlDirectorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuCaras,
									this.MenuTelefonico});
			this.tlDirectorio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tlDirectorio.ForeColor = System.Drawing.Color.Black;
			this.tlDirectorio.Image = ((System.Drawing.Image)(resources.GetObject("tlDirectorio.Image")));
			this.tlDirectorio.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.tlDirectorio.Name = "tlDirectorio";
			this.tlDirectorio.Size = new System.Drawing.Size(91, 20);
			this.tlDirectorio.Text = "Directorio";
			// 
			// MenuCaras
			// 
			this.MenuCaras.Image = ((System.Drawing.Image)(resources.GetObject("MenuCaras.Image")));
			this.MenuCaras.Name = "MenuCaras";
			this.MenuCaras.Size = new System.Drawing.Size(181, 22);
			this.MenuCaras.Text = "Operador ilustrado";
			this.MenuCaras.Click += new System.EventHandler(this.MenuCarasClick);
			// 
			// MenuTelefonico
			// 
			this.MenuTelefonico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ItemDirectorioTelefonicoExcel,
									this.ItemDirectorioTelefonicoPDF});
			this.MenuTelefonico.Image = ((System.Drawing.Image)(resources.GetObject("MenuTelefonico.Image")));
			this.MenuTelefonico.Name = "MenuTelefonico";
			this.MenuTelefonico.Size = new System.Drawing.Size(181, 22);
			this.MenuTelefonico.Text = "Telefónico";
			// 
			// ItemDirectorioTelefonicoExcel
			// 
			this.ItemDirectorioTelefonicoExcel.Image = ((System.Drawing.Image)(resources.GetObject("ItemDirectorioTelefonicoExcel.Image")));
			this.ItemDirectorioTelefonicoExcel.Name = "ItemDirectorioTelefonicoExcel";
			this.ItemDirectorioTelefonicoExcel.Size = new System.Drawing.Size(105, 22);
			this.ItemDirectorioTelefonicoExcel.Text = "Excel";
			this.ItemDirectorioTelefonicoExcel.Click += new System.EventHandler(this.MenuDirectorioTelefonicoExcelClick);
			// 
			// ItemDirectorioTelefonicoPDF
			// 
			this.ItemDirectorioTelefonicoPDF.Image = ((System.Drawing.Image)(resources.GetObject("ItemDirectorioTelefonicoPDF.Image")));
			this.ItemDirectorioTelefonicoPDF.Name = "ItemDirectorioTelefonicoPDF";
			this.ItemDirectorioTelefonicoPDF.Size = new System.Drawing.Size(105, 22);
			this.ItemDirectorioTelefonicoPDF.Text = "PDF";
			this.ItemDirectorioTelefonicoPDF.Click += new System.EventHandler(this.MenuDirectorioTelefonicoPDFClick);
			// 
			// tlCliente
			// 
			this.tlCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuCatalogoEmpresa,
									this.MenuContratoEmpresa});
			this.tlCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tlCliente.ForeColor = System.Drawing.Color.Black;
			this.tlCliente.Image = ((System.Drawing.Image)(resources.GetObject("tlCliente.Image")));
			this.tlCliente.Name = "tlCliente";
			this.tlCliente.Size = new System.Drawing.Size(74, 20);
			this.tlCliente.Text = "Cliente";
			// 
			// MenuCatalogoEmpresa
			// 
			this.MenuCatalogoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("MenuCatalogoEmpresa.Image")));
			this.MenuCatalogoEmpresa.Name = "MenuCatalogoEmpresa";
			this.MenuCatalogoEmpresa.Size = new System.Drawing.Size(196, 22);
			this.MenuCatalogoEmpresa.Text = "Catalogo Empresarial";
			this.MenuCatalogoEmpresa.Click += new System.EventHandler(this.ClienteEmpresaToolStripMenuItemClick);
			// 
			// MenuContratoEmpresa
			// 
			this.MenuContratoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("MenuContratoEmpresa.Image")));
			this.MenuContratoEmpresa.Name = "MenuContratoEmpresa";
			this.MenuContratoEmpresa.Size = new System.Drawing.Size(196, 22);
			this.MenuContratoEmpresa.Text = "Contrato Empresa";
			this.MenuContratoEmpresa.Click += new System.EventHandler(this.MenuContratoEmpresaClick);
			// 
			// tlVehiculo
			// 
			this.tlVehiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuAseguradora,
									this.MenuVehiculo,
									this.MenuOperadorVehiculo,
									this.gestoríaVehículoToolStripMenuItem,
									this.revisiónDePlacasToolStripMenuItem});
			this.tlVehiculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tlVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("tlVehiculo.Image")));
			this.tlVehiculo.Name = "tlVehiculo";
			this.tlVehiculo.Size = new System.Drawing.Size(83, 20);
			this.tlVehiculo.Text = "Vehiculo";
			// 
			// MenuAseguradora
			// 
			this.MenuAseguradora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aseguradoraToolStripMenuItem1,
									this.seguroVehicularToolStripMenuItem});
			this.MenuAseguradora.Image = ((System.Drawing.Image)(resources.GetObject("MenuAseguradora.Image")));
			this.MenuAseguradora.Name = "MenuAseguradora";
			this.MenuAseguradora.Size = new System.Drawing.Size(186, 22);
			this.MenuAseguradora.Text = "Aseguradora";
			// 
			// aseguradoraToolStripMenuItem1
			// 
			this.aseguradoraToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("aseguradoraToolStripMenuItem1.Image")));
			this.aseguradoraToolStripMenuItem1.Name = "aseguradoraToolStripMenuItem1";
			this.aseguradoraToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
			this.aseguradoraToolStripMenuItem1.Text = "Aseguradora";
			this.aseguradoraToolStripMenuItem1.Click += new System.EventHandler(this.AseguradoraToolStripMenuItem1Click);
			// 
			// seguroVehicularToolStripMenuItem
			// 
			this.seguroVehicularToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seguroVehicularToolStripMenuItem.Image")));
			this.seguroVehicularToolStripMenuItem.Name = "seguroVehicularToolStripMenuItem";
			this.seguroVehicularToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.seguroVehicularToolStripMenuItem.Text = "Seguros";
			this.seguroVehicularToolStripMenuItem.Click += new System.EventHandler(this.SeguroVehicularToolStripMenuItemClick);
			// 
			// MenuVehiculo
			// 
			this.MenuVehiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ItemAgregarVehiculo,
									this.ItemBusquedaVehiculo});
			this.MenuVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("MenuVehiculo.Image")));
			this.MenuVehiculo.Name = "MenuVehiculo";
			this.MenuVehiculo.Size = new System.Drawing.Size(186, 22);
			this.MenuVehiculo.Text = "Vehículo";
			// 
			// ItemAgregarVehiculo
			// 
			this.ItemAgregarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("ItemAgregarVehiculo.Image")));
			this.ItemAgregarVehiculo.Name = "ItemAgregarVehiculo";
			this.ItemAgregarVehiculo.Size = new System.Drawing.Size(171, 22);
			this.ItemAgregarVehiculo.Text = "Agregar nuevo...";
			this.ItemAgregarVehiculo.Click += new System.EventHandler(this.AgregarToolStripMenuItem1Click);
			// 
			// ItemBusquedaVehiculo
			// 
			this.ItemBusquedaVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("ItemBusquedaVehiculo.Image")));
			this.ItemBusquedaVehiculo.Name = "ItemBusquedaVehiculo";
			this.ItemBusquedaVehiculo.Size = new System.Drawing.Size(171, 22);
			this.ItemBusquedaVehiculo.Text = "Buscar/Modificar";
			this.ItemBusquedaVehiculo.Click += new System.EventHandler(this.BuscarModificarToolStripMenuItem1Click);
			// 
			// MenuOperadorVehiculo
			// 
			this.MenuOperadorVehiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ItemHistorialOperadorVehículo,
									this.ItemOperadorVehículo});
			this.MenuOperadorVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("MenuOperadorVehiculo.Image")));
			this.MenuOperadorVehiculo.Name = "MenuOperadorVehiculo";
			this.MenuOperadorVehiculo.Size = new System.Drawing.Size(186, 22);
			this.MenuOperadorVehiculo.Text = "Operador - Vehículo";
			// 
			// ItemHistorialOperadorVehículo
			// 
			this.ItemHistorialOperadorVehículo.Image = ((System.Drawing.Image)(resources.GetObject("ItemHistorialOperadorVehículo.Image")));
			this.ItemHistorialOperadorVehículo.Name = "ItemHistorialOperadorVehículo";
			this.ItemHistorialOperadorVehículo.Size = new System.Drawing.Size(230, 22);
			this.ItemHistorialOperadorVehículo.Text = "Historial Operador-Vehículo";
			this.ItemHistorialOperadorVehículo.Click += new System.EventHandler(this.HistorialOperadorVehículoToolStripMenuItemClick);
			// 
			// ItemOperadorVehículo
			// 
			this.ItemOperadorVehículo.Image = ((System.Drawing.Image)(resources.GetObject("ItemOperadorVehículo.Image")));
			this.ItemOperadorVehículo.Name = "ItemOperadorVehículo";
			this.ItemOperadorVehículo.Size = new System.Drawing.Size(230, 22);
			this.ItemOperadorVehículo.Text = "Operador - Vehículo";
			this.ItemOperadorVehículo.Click += new System.EventHandler(this.OperadorVehículoToolStripMenuItemClick);
			// 
			// gestoríaVehículoToolStripMenuItem
			// 
			this.gestoríaVehículoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestoríaVehículoToolStripMenuItem.Image")));
			this.gestoríaVehículoToolStripMenuItem.Name = "gestoríaVehículoToolStripMenuItem";
			this.gestoríaVehículoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.gestoríaVehículoToolStripMenuItem.Text = "Gestoría Vehículo";
			this.gestoríaVehículoToolStripMenuItem.Click += new System.EventHandler(this.GestoríaVehículoToolStripMenuItemClick);
			// 
			// revisiónDePlacasToolStripMenuItem
			// 
			this.revisiónDePlacasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("revisiónDePlacasToolStripMenuItem.Image")));
			this.revisiónDePlacasToolStripMenuItem.Name = "revisiónDePlacasToolStripMenuItem";
			this.revisiónDePlacasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.revisiónDePlacasToolStripMenuItem.Text = "Revisión de Placas";
			this.revisiónDePlacasToolStripMenuItem.Click += new System.EventHandler(this.RevisiónDePlacasToolStripMenuItemClick);
			// 
			// tlRuta
			// 
			this.tlRuta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuRutaSin,
									this.MenuOperadorRuta,
									this.MenuCostoRutaFactura,
									this.itemforsac,
									this.MenuRutas});
			this.tlRuta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tlRuta.Image = ((System.Drawing.Image)(resources.GetObject("tlRuta.Image")));
			this.tlRuta.Name = "tlRuta";
			this.tlRuta.Size = new System.Drawing.Size(61, 20);
			this.tlRuta.Text = "Ruta";
			// 
			// MenuRutaSin
			// 
			this.MenuRutaSin.Image = ((System.Drawing.Image)(resources.GetObject("MenuRutaSin.Image")));
			this.MenuRutaSin.Name = "MenuRutaSin";
			this.MenuRutaSin.Size = new System.Drawing.Size(272, 22);
			this.MenuRutaSin.Text = "Viajes sin precio o sin kilometrajes";
			this.MenuRutaSin.Click += new System.EventHandler(this.RutasItemClick);
			// 
			// MenuOperadorRuta
			// 
			this.MenuOperadorRuta.Image = ((System.Drawing.Image)(resources.GetObject("MenuOperadorRuta.Image")));
			this.MenuOperadorRuta.Name = "MenuOperadorRuta";
			this.MenuOperadorRuta.Size = new System.Drawing.Size(272, 22);
			this.MenuOperadorRuta.Text = "Relación Operador - Ruta";
			this.MenuOperadorRuta.Click += new System.EventHandler(this.MenuOperadorRutaClick);
			// 
			// MenuCostoRutaFactura
			// 
			this.MenuCostoRutaFactura.Image = ((System.Drawing.Image)(resources.GetObject("MenuCostoRutaFactura.Image")));
			this.MenuCostoRutaFactura.Name = "MenuCostoRutaFactura";
			this.MenuCostoRutaFactura.Size = new System.Drawing.Size(272, 22);
			this.MenuCostoRutaFactura.Text = "Costo Ruta Factura";
			this.MenuCostoRutaFactura.Click += new System.EventHandler(this.MenuCostoRutaFacturaClick);
			// 
			// itemforsac
			// 
			this.itemforsac.Image = ((System.Drawing.Image)(resources.GetObject("itemforsac.Image")));
			this.itemforsac.Name = "itemforsac";
			this.itemforsac.Size = new System.Drawing.Size(272, 22);
			this.itemforsac.Text = "Rutas Forsac";
			this.itemforsac.Click += new System.EventHandler(this.itemforsac_Click);
			// 
			// MenuRutas
			// 
			this.MenuRutas.Image = ((System.Drawing.Image)(resources.GetObject("MenuRutas.Image")));
			this.MenuRutas.Name = "MenuRutas";
			this.MenuRutas.Size = new System.Drawing.Size(272, 22);
			this.MenuRutas.Text = "Rutas";
			this.MenuRutas.Click += new System.EventHandler(this.MenuRutasClick);
			// 
			// tlEspeciales
			// 
			this.tlEspeciales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuReporteEspeciales,
									this.MenuReporteFacturacion,
									this.MenuSueldoEspeciales,
									this.MenuReporteValidacion,
									this.MenuReporteVentas,
									this.MenuEspecialPendiente,
									this.revisiónEspecialesToolStripMenuItem});
			this.tlEspeciales.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tlEspeciales.ForeColor = System.Drawing.Color.Black;
			this.tlEspeciales.Image = ((System.Drawing.Image)(resources.GetObject("tlEspeciales.Image")));
			this.tlEspeciales.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.tlEspeciales.Name = "tlEspeciales";
			this.tlEspeciales.Size = new System.Drawing.Size(135, 20);
			this.tlEspeciales.Text = "Viajes Especiales";
			// 
			// MenuReporteEspeciales
			// 
			this.MenuReporteEspeciales.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteEspeciales.Image")));
			this.MenuReporteEspeciales.Name = "MenuReporteEspeciales";
			this.MenuReporteEspeciales.Size = new System.Drawing.Size(275, 22);
			this.MenuReporteEspeciales.Text = "Detalle Cobro";
			this.MenuReporteEspeciales.Click += new System.EventHandler(this.MenuReporteEspecialesClick);
			// 
			// MenuReporteFacturacion
			// 
			this.MenuReporteFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteFacturacion.Image")));
			this.MenuReporteFacturacion.Name = "MenuReporteFacturacion";
			this.MenuReporteFacturacion.Size = new System.Drawing.Size(275, 22);
			this.MenuReporteFacturacion.Text = "Facturación Especiales";
			this.MenuReporteFacturacion.Click += new System.EventHandler(this.MenuReporteFacturacionClick);
			// 
			// MenuSueldoEspeciales
			// 
			this.MenuSueldoEspeciales.Image = ((System.Drawing.Image)(resources.GetObject("MenuSueldoEspeciales.Image")));
			this.MenuSueldoEspeciales.Name = "MenuSueldoEspeciales";
			this.MenuSueldoEspeciales.Size = new System.Drawing.Size(275, 22);
			this.MenuSueldoEspeciales.Text = "Servicios Especiales";
			this.MenuSueldoEspeciales.Click += new System.EventHandler(this.MenuSueldoEspecialesClick);
			// 
			// MenuReporteValidacion
			// 
			this.MenuReporteValidacion.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteValidacion.Image")));
			this.MenuReporteValidacion.Name = "MenuReporteValidacion";
			this.MenuReporteValidacion.Size = new System.Drawing.Size(275, 22);
			this.MenuReporteValidacion.Text = "Validación Especiales";
			this.MenuReporteValidacion.Click += new System.EventHandler(this.MenuReporteValidacionClick);
			// 
			// MenuReporteVentas
			// 
			this.MenuReporteVentas.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteVentas.Image")));
			this.MenuReporteVentas.Name = "MenuReporteVentas";
			this.MenuReporteVentas.Size = new System.Drawing.Size(275, 22);
			this.MenuReporteVentas.Text = "Ventas (Asignados - Desasignados)";
			this.MenuReporteVentas.Click += new System.EventHandler(this.MenuReporteVentasClick);
			// 
			// MenuEspecialPendiente
			// 
			this.MenuEspecialPendiente.Image = ((System.Drawing.Image)(resources.GetObject("MenuEspecialPendiente.Image")));
			this.MenuEspecialPendiente.Name = "MenuEspecialPendiente";
			this.MenuEspecialPendiente.Size = new System.Drawing.Size(275, 22);
			this.MenuEspecialPendiente.Text = "Especiales Pendientes";
			this.MenuEspecialPendiente.Click += new System.EventHandler(this.MenuEspecialPendienteClick);
			// 
			// revisiónEspecialesToolStripMenuItem
			// 
			this.revisiónEspecialesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("revisiónEspecialesToolStripMenuItem.Image")));
			this.revisiónEspecialesToolStripMenuItem.Name = "revisiónEspecialesToolStripMenuItem";
			this.revisiónEspecialesToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
			this.revisiónEspecialesToolStripMenuItem.Text = "Revisión Especiales";
			this.revisiónEspecialesToolStripMenuItem.Visible = false;
			this.revisiónEspecialesToolStripMenuItem.Click += new System.EventHandler(this.RevisiónEspecialesToolStripMenuItemClick);
			// 
			// tlModulos
			// 
			this.tlModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuCaja,
									this.ModuloChecador,
									this.ModuloCombustible,
									this.ModuloDespacho,
									this.ModuloFacturacion,
									this.MenuMantenimiento,
									this.ModuloNomina,
									this.MenuVentas,
									this.ventas2ToolStripMenuItem,
									this.controlToolStripMenuItem});
			this.tlModulos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tlModulos.ForeColor = System.Drawing.Color.Black;
			this.tlModulos.Image = ((System.Drawing.Image)(resources.GetObject("tlModulos.Image")));
			this.tlModulos.Name = "tlModulos";
			this.tlModulos.Size = new System.Drawing.Size(83, 20);
			this.tlModulos.Text = "Módulos";
			// 
			// MenuCaja
			// 
			this.MenuCaja.Image = ((System.Drawing.Image)(resources.GetObject("MenuCaja.Image")));
			this.MenuCaja.Name = "MenuCaja";
			this.MenuCaja.Size = new System.Drawing.Size(174, 22);
			this.MenuCaja.Text = "Caja";
			this.MenuCaja.Visible = false;
			this.MenuCaja.Click += new System.EventHandler(this.CajaToolStripMenuItemClick);
			// 
			// ModuloChecador
			// 
			this.ModuloChecador.Image = ((System.Drawing.Image)(resources.GetObject("ModuloChecador.Image")));
			this.ModuloChecador.Name = "ModuloChecador";
			this.ModuloChecador.Size = new System.Drawing.Size(174, 22);
			this.ModuloChecador.Text = "Checador";
			this.ModuloChecador.Click += new System.EventHandler(this.ModuloChecadorClick);
			// 
			// ModuloCombustible
			// 
			this.ModuloCombustible.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuPrincipalCombustible,
									this.MenuCombustibleComplementos,
									this.MenuExtrasComb,
									this.MenuDatosComb,
									this.validarOperacionesToolStripMenuItem,
									this.pruebaRendimientoToolStripMenuItem});
			this.ModuloCombustible.Image = ((System.Drawing.Image)(resources.GetObject("ModuloCombustible.Image")));
			this.ModuloCombustible.Name = "ModuloCombustible";
			this.ModuloCombustible.Size = new System.Drawing.Size(174, 22);
			this.ModuloCombustible.Text = "Combustible";
			// 
			// MenuPrincipalCombustible
			// 
			this.MenuPrincipalCombustible.Image = ((System.Drawing.Image)(resources.GetObject("MenuPrincipalCombustible.Image")));
			this.MenuPrincipalCombustible.Name = "MenuPrincipalCombustible";
			this.MenuPrincipalCombustible.Size = new System.Drawing.Size(189, 22);
			this.MenuPrincipalCombustible.Text = "Principal";
			this.MenuPrincipalCombustible.Click += new System.EventHandler(this.MenuPrincipalCombustibleClick);
			// 
			// MenuCombustibleComplementos
			// 
			this.MenuCombustibleComplementos.Image = ((System.Drawing.Image)(resources.GetObject("MenuCombustibleComplementos.Image")));
			this.MenuCombustibleComplementos.Name = "MenuCombustibleComplementos";
			this.MenuCombustibleComplementos.Size = new System.Drawing.Size(189, 22);
			this.MenuCombustibleComplementos.Text = "Complementos";
			this.MenuCombustibleComplementos.Click += new System.EventHandler(this.MenuCombustibleComplementosClick);
			// 
			// MenuExtrasComb
			// 
			this.MenuExtrasComb.Image = ((System.Drawing.Image)(resources.GetObject("MenuExtrasComb.Image")));
			this.MenuExtrasComb.Name = "MenuExtrasComb";
			this.MenuExtrasComb.Size = new System.Drawing.Size(189, 22);
			this.MenuExtrasComb.Text = "Extras";
			this.MenuExtrasComb.Click += new System.EventHandler(this.MenuExtrasCombClick);
			// 
			// MenuDatosComb
			// 
			this.MenuDatosComb.Image = ((System.Drawing.Image)(resources.GetObject("MenuDatosComb.Image")));
			this.MenuDatosComb.Name = "MenuDatosComb";
			this.MenuDatosComb.Size = new System.Drawing.Size(189, 22);
			this.MenuDatosComb.Text = "Datos";
			this.MenuDatosComb.Click += new System.EventHandler(this.MenuDatosCombClick);
			// 
			// validarOperacionesToolStripMenuItem
			// 
			this.validarOperacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("validarOperacionesToolStripMenuItem.Image")));
			this.validarOperacionesToolStripMenuItem.Name = "validarOperacionesToolStripMenuItem";
			this.validarOperacionesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.validarOperacionesToolStripMenuItem.Text = "Validar Operaciones";
			this.validarOperacionesToolStripMenuItem.Click += new System.EventHandler(this.ValidarOperacionesToolStripMenuItemClick);
			// 
			// pruebaRendimientoToolStripMenuItem
			// 
			this.pruebaRendimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pruebaRendimientoToolStripMenuItem.Image")));
			this.pruebaRendimientoToolStripMenuItem.Name = "pruebaRendimientoToolStripMenuItem";
			this.pruebaRendimientoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.pruebaRendimientoToolStripMenuItem.Text = "Prueba Rendimiento";
			this.pruebaRendimientoToolStripMenuItem.Click += new System.EventHandler(this.PruebaRendimientoToolStripMenuItemClick);
			// 
			// ModuloDespacho
			// 
			this.ModuloDespacho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuDespacho,
									this.MenuMensajesDespacho,
									this.pasajerosToolStripMenuItem,
									this.reporteViajesToolStripMenuItem});
			this.ModuloDespacho.Image = ((System.Drawing.Image)(resources.GetObject("ModuloDespacho.Image")));
			this.ModuloDespacho.Name = "ModuloDespacho";
			this.ModuloDespacho.Size = new System.Drawing.Size(174, 22);
			this.ModuloDespacho.Text = "Despacho";
			// 
			// MenuDespacho
			// 
			this.MenuDespacho.Image = ((System.Drawing.Image)(resources.GetObject("MenuDespacho.Image")));
			this.MenuDespacho.Name = "MenuDespacho";
			this.MenuDespacho.Size = new System.Drawing.Size(157, 22);
			this.MenuDespacho.Text = "Despacho";
			this.MenuDespacho.Click += new System.EventHandler(this.MenuDespachoClick);
			// 
			// MenuMensajesDespacho
			// 
			this.MenuMensajesDespacho.Image = ((System.Drawing.Image)(resources.GetObject("MenuMensajesDespacho.Image")));
			this.MenuMensajesDespacho.Name = "MenuMensajesDespacho";
			this.MenuMensajesDespacho.Size = new System.Drawing.Size(157, 22);
			this.MenuMensajesDespacho.Text = "Mensajes";
			this.MenuMensajesDespacho.Click += new System.EventHandler(this.MenuMensajesDespachoClick);
			// 
			// pasajerosToolStripMenuItem
			// 
			this.pasajerosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasajerosToolStripMenuItem.Image")));
			this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
			this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.pasajerosToolStripMenuItem.Text = "Pasajeros";
			this.pasajerosToolStripMenuItem.Click += new System.EventHandler(this.PasajerosToolStripMenuItemClick);
			// 
			// reporteViajesToolStripMenuItem
			// 
			this.reporteViajesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteViajesToolStripMenuItem.Image")));
			this.reporteViajesToolStripMenuItem.Name = "reporteViajesToolStripMenuItem";
			this.reporteViajesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.reporteViajesToolStripMenuItem.Text = "Reporte Viajes";
			this.reporteViajesToolStripMenuItem.Click += new System.EventHandler(this.ReporteViajesToolStripMenuItemClick);
			// 
			// ModuloFacturacion
			// 
			this.ModuloFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuFacturacion,
									this.MenuPrecioFactura,
									this.preciosFacturaciónToolStripMenuItem,
									this.controlFactutaciónToolStripMenuItem});
			this.ModuloFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("ModuloFacturacion.Image")));
			this.ModuloFacturacion.Name = "ModuloFacturacion";
			this.ModuloFacturacion.Size = new System.Drawing.Size(174, 22);
			this.ModuloFacturacion.Text = "Facturación";
			// 
			// MenuFacturacion
			// 
			this.MenuFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("MenuFacturacion.Image")));
			this.MenuFacturacion.Name = "MenuFacturacion";
			this.MenuFacturacion.Size = new System.Drawing.Size(188, 22);
			this.MenuFacturacion.Text = "Facturación";
			this.MenuFacturacion.Click += new System.EventHandler(this.MenuFacturacionClick);
			// 
			// MenuPrecioFactura
			// 
			this.MenuPrecioFactura.Image = ((System.Drawing.Image)(resources.GetObject("MenuPrecioFactura.Image")));
			this.MenuPrecioFactura.Name = "MenuPrecioFactura";
			this.MenuPrecioFactura.Size = new System.Drawing.Size(188, 22);
			this.MenuPrecioFactura.Text = "Precios Factura";
			this.MenuPrecioFactura.Visible = false;
			this.MenuPrecioFactura.Click += new System.EventHandler(this.MenuFacturaHennigesClick);
			// 
			// preciosFacturaciónToolStripMenuItem
			// 
			this.preciosFacturaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("preciosFacturaciónToolStripMenuItem.Image")));
			this.preciosFacturaciónToolStripMenuItem.Name = "preciosFacturaciónToolStripMenuItem";
			this.preciosFacturaciónToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.preciosFacturaciónToolStripMenuItem.Text = "Precios Facturación";
			this.preciosFacturaciónToolStripMenuItem.Click += new System.EventHandler(this.PreciosFacturaciónToolStripMenuItemClick);
			// 
			// controlFactutaciónToolStripMenuItem
			// 
			this.controlFactutaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlFactutaciónToolStripMenuItem.Image")));
			this.controlFactutaciónToolStripMenuItem.Name = "controlFactutaciónToolStripMenuItem";
			this.controlFactutaciónToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.controlFactutaciónToolStripMenuItem.Text = "Control Facturación";
			this.controlFactutaciónToolStripMenuItem.Click += new System.EventHandler(this.ControlFactutaciónToolStripMenuItemClick);
			// 
			// MenuMantenimiento
			// 
			this.MenuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuAlmacen,
									this.MenuOrdenTrabajo,
									this.MenuMantenimientos,
									this.MenuReporteDiario,
									this.entregaYRecepciónToolStripMenuItem,
									this.bitácoraDeMantenimientoToolStripMenuItem,
									this.MenuESVehiculos});
			this.MenuMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("MenuMantenimiento.Image")));
			this.MenuMantenimiento.Name = "MenuMantenimiento";
			this.MenuMantenimiento.Size = new System.Drawing.Size(174, 22);
			this.MenuMantenimiento.Text = "Mantenimiento";
			// 
			// MenuAlmacen
			// 
			this.MenuAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("MenuAlmacen.Image")));
			this.MenuAlmacen.Name = "MenuAlmacen";
			this.MenuAlmacen.Size = new System.Drawing.Size(235, 22);
			this.MenuAlmacen.Text = "Almacen";
			this.MenuAlmacen.Click += new System.EventHandler(this.MenuAlmacenClick);
			// 
			// MenuOrdenTrabajo
			// 
			this.MenuOrdenTrabajo.Image = ((System.Drawing.Image)(resources.GetObject("MenuOrdenTrabajo.Image")));
			this.MenuOrdenTrabajo.Name = "MenuOrdenTrabajo";
			this.MenuOrdenTrabajo.Size = new System.Drawing.Size(235, 22);
			this.MenuOrdenTrabajo.Text = "Orden de Trabajo";
			this.MenuOrdenTrabajo.Click += new System.EventHandler(this.MenuOrdenTrabajoClick);
			// 
			// MenuMantenimientos
			// 
			this.MenuMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("MenuMantenimientos.Image")));
			this.MenuMantenimientos.Name = "MenuMantenimientos";
			this.MenuMantenimientos.Size = new System.Drawing.Size(235, 22);
			this.MenuMantenimientos.Text = "Mantenimientos Preventivos";
			this.MenuMantenimientos.Click += new System.EventHandler(this.MenuMantenimientosClick);
			// 
			// MenuReporteDiario
			// 
			this.MenuReporteDiario.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteDiario.Image")));
			this.MenuReporteDiario.Name = "MenuReporteDiario";
			this.MenuReporteDiario.Size = new System.Drawing.Size(235, 22);
			this.MenuReporteDiario.Text = "Reporte Diario";
			// 
			// entregaYRecepciónToolStripMenuItem
			// 
			this.entregaYRecepciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entregaYRecepciónToolStripMenuItem.Image")));
			this.entregaYRecepciónToolStripMenuItem.Name = "entregaYRecepciónToolStripMenuItem";
			this.entregaYRecepciónToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.entregaYRecepciónToolStripMenuItem.Text = "Entrega y Recepción";
			this.entregaYRecepciónToolStripMenuItem.Click += new System.EventHandler(this.EntregaYRecepciónToolStripMenuItemClick);
			// 
			// bitácoraDeMantenimientoToolStripMenuItem
			// 
			this.bitácoraDeMantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bitácoraDeMantenimientoToolStripMenuItem.Image")));
			this.bitácoraDeMantenimientoToolStripMenuItem.Name = "bitácoraDeMantenimientoToolStripMenuItem";
			this.bitácoraDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
			this.bitácoraDeMantenimientoToolStripMenuItem.Text = "Bitácora de Mantenimiento";
			// 
			// MenuESVehiculos
			// 
			this.MenuESVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("MenuESVehiculos.Image")));
			this.MenuESVehiculos.Name = "MenuESVehiculos";
			this.MenuESVehiculos.Size = new System.Drawing.Size(235, 22);
			this.MenuESVehiculos.Text = "E/S Vehiculos";
			this.MenuESVehiculos.Click += new System.EventHandler(this.MenuESVehiculosClick);
			// 
			// ModuloNomina
			// 
			this.ModuloNomina.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuBono,
									this.Menuanticipos,
									this.MenuNomina,
									this.MenuIncapacidad,
									this.MenuPercepcionesDeducciones,
									this.MenuTelcel,
									this.MenuImporteNomina,
									this.reporteRutasNominalToolStripMenuItem,
									this.nominaFiscalToolStripMenuItem});
			this.ModuloNomina.Image = ((System.Drawing.Image)(resources.GetObject("ModuloNomina.Image")));
			this.ModuloNomina.Name = "ModuloNomina";
			this.ModuloNomina.Size = new System.Drawing.Size(174, 22);
			this.ModuloNomina.Text = "Nomina";
			// 
			// MenuBono
			// 
			this.MenuBono.Image = ((System.Drawing.Image)(resources.GetObject("MenuBono.Image")));
			this.MenuBono.Name = "MenuBono";
			this.MenuBono.Size = new System.Drawing.Size(239, 22);
			this.MenuBono.Text = "Bono Viaje";
			this.MenuBono.Click += new System.EventHandler(this.MenuBonoClick);
			// 
			// Menuanticipos
			// 
			this.Menuanticipos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuControlDescuentos,
									this.MenuTaxi});
			this.Menuanticipos.Image = ((System.Drawing.Image)(resources.GetObject("Menuanticipos.Image")));
			this.Menuanticipos.Name = "Menuanticipos";
			this.Menuanticipos.Size = new System.Drawing.Size(239, 22);
			this.Menuanticipos.Text = "Descuento Operador";
			// 
			// MenuControlDescuentos
			// 
			this.MenuControlDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("MenuControlDescuentos.Image")));
			this.MenuControlDescuentos.Name = "MenuControlDescuentos";
			this.MenuControlDescuentos.Size = new System.Drawing.Size(186, 22);
			this.MenuControlDescuentos.Text = "Control Descuentos";
			this.MenuControlDescuentos.Click += new System.EventHandler(this.MenuControlDescuentosClick);
			// 
			// MenuTaxi
			// 
			this.MenuTaxi.Image = ((System.Drawing.Image)(resources.GetObject("MenuTaxi.Image")));
			this.MenuTaxi.Name = "MenuTaxi";
			this.MenuTaxi.Size = new System.Drawing.Size(186, 22);
			this.MenuTaxi.Text = "Taxis";
			this.MenuTaxi.Click += new System.EventHandler(this.MenuTaxiClick);
			// 
			// MenuNomina
			// 
			this.MenuNomina.Image = ((System.Drawing.Image)(resources.GetObject("MenuNomina.Image")));
			this.MenuNomina.Name = "MenuNomina";
			this.MenuNomina.Size = new System.Drawing.Size(239, 22);
			this.MenuNomina.Text = "Control Nominal";
			this.MenuNomina.Click += new System.EventHandler(this.MenuNominaClick);
			// 
			// MenuIncapacidad
			// 
			this.MenuIncapacidad.Image = ((System.Drawing.Image)(resources.GetObject("MenuIncapacidad.Image")));
			this.MenuIncapacidad.Name = "MenuIncapacidad";
			this.MenuIncapacidad.Size = new System.Drawing.Size(239, 22);
			this.MenuIncapacidad.Text = "Incapacidad Operador";
			this.MenuIncapacidad.Click += new System.EventHandler(this.MenuIncapacidadClick);
			// 
			// MenuPercepcionesDeducciones
			// 
			this.MenuPercepcionesDeducciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuSueldoOperador,
									this.MenuSueldoAdministrativo});
			this.MenuPercepcionesDeducciones.Image = ((System.Drawing.Image)(resources.GetObject("MenuPercepcionesDeducciones.Image")));
			this.MenuPercepcionesDeducciones.Name = "MenuPercepcionesDeducciones";
			this.MenuPercepcionesDeducciones.Size = new System.Drawing.Size(239, 22);
			this.MenuPercepcionesDeducciones.Text = "Percepciones y Deducciones";
			// 
			// MenuSueldoOperador
			// 
			this.MenuSueldoOperador.Image = ((System.Drawing.Image)(resources.GetObject("MenuSueldoOperador.Image")));
			this.MenuSueldoOperador.Name = "MenuSueldoOperador";
			this.MenuSueldoOperador.Size = new System.Drawing.Size(156, 22);
			this.MenuSueldoOperador.Text = "Operador";
			this.MenuSueldoOperador.Click += new System.EventHandler(this.MenuSueldoOperadorClick);
			// 
			// MenuSueldoAdministrativo
			// 
			this.MenuSueldoAdministrativo.Image = ((System.Drawing.Image)(resources.GetObject("MenuSueldoAdministrativo.Image")));
			this.MenuSueldoAdministrativo.Name = "MenuSueldoAdministrativo";
			this.MenuSueldoAdministrativo.Size = new System.Drawing.Size(156, 22);
			this.MenuSueldoAdministrativo.Text = "Administrativo";
			this.MenuSueldoAdministrativo.Click += new System.EventHandler(this.MenuSueldoAdministrativoClick);
			// 
			// MenuTelcel
			// 
			this.MenuTelcel.Image = ((System.Drawing.Image)(resources.GetObject("MenuTelcel.Image")));
			this.MenuTelcel.Name = "MenuTelcel";
			this.MenuTelcel.Size = new System.Drawing.Size(239, 22);
			this.MenuTelcel.Text = "Telcel";
			this.MenuTelcel.Click += new System.EventHandler(this.MenuTelcelClick);
			// 
			// MenuImporteNomina
			// 
			this.MenuImporteNomina.Image = ((System.Drawing.Image)(resources.GetObject("MenuImporteNomina.Image")));
			this.MenuImporteNomina.Name = "MenuImporteNomina";
			this.MenuImporteNomina.Size = new System.Drawing.Size(239, 22);
			this.MenuImporteNomina.Text = "Importes Nomina";
			this.MenuImporteNomina.Click += new System.EventHandler(this.MenuImporteNominaClick);
			// 
			// reporteRutasNominalToolStripMenuItem
			// 
			this.reporteRutasNominalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteRutasNominalToolStripMenuItem.Image")));
			this.reporteRutasNominalToolStripMenuItem.Name = "reporteRutasNominalToolStripMenuItem";
			this.reporteRutasNominalToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.reporteRutasNominalToolStripMenuItem.Text = "Reporte Rutas Nominal";
			this.reporteRutasNominalToolStripMenuItem.Click += new System.EventHandler(this.ReporteRutasNominalToolStripMenuItemClick);
			// 
			// nominaFiscalToolStripMenuItem
			// 
			this.nominaFiscalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nominaFiscalToolStripMenuItem.Image")));
			this.nominaFiscalToolStripMenuItem.Name = "nominaFiscalToolStripMenuItem";
			this.nominaFiscalToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
			this.nominaFiscalToolStripMenuItem.Text = "Nomina Fiscal";
			this.nominaFiscalToolStripMenuItem.Click += new System.EventHandler(this.NominaFiscalToolStripMenuItemClick);
			// 
			// MenuVentas
			// 
			this.MenuVentas.Image = ((System.Drawing.Image)(resources.GetObject("MenuVentas.Image")));
			this.MenuVentas.Name = "MenuVentas";
			this.MenuVentas.Size = new System.Drawing.Size(174, 22);
			this.MenuVentas.Text = "Ventas";
			this.MenuVentas.Click += new System.EventHandler(this.LibroDeViajesToolStripMenuItemClick);
			// 
			// ventas2ToolStripMenuItem
			// 
			this.ventas2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.libroVentasToolStripMenuItem,
									this.cobroEspecialesToolStripMenuItem,
									this.validaciónEspecialesToolStripMenuItem,
									this.reportesToolStripMenuItem,
									this.controlDeGastosToolStripMenuItem});
			this.ventas2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventas2ToolStripMenuItem.Image")));
			this.ventas2ToolStripMenuItem.Name = "ventas2ToolStripMenuItem";
			this.ventas2ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.ventas2ToolStripMenuItem.Text = "Viajes Especiales";
			// 
			// libroVentasToolStripMenuItem
			// 
			this.libroVentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("libroVentasToolStripMenuItem.Image")));
			this.libroVentasToolStripMenuItem.Name = "libroVentasToolStripMenuItem";
			this.libroVentasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.libroVentasToolStripMenuItem.Text = "Libro Ventas";
			this.libroVentasToolStripMenuItem.Click += new System.EventHandler(this.LibroVentasToolStripMenuItemClick);
			// 
			// cobroEspecialesToolStripMenuItem
			// 
			this.cobroEspecialesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cobroEspecialesToolStripMenuItem.Image")));
			this.cobroEspecialesToolStripMenuItem.Name = "cobroEspecialesToolStripMenuItem";
			this.cobroEspecialesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.cobroEspecialesToolStripMenuItem.Text = "Cobro Especiales";
			this.cobroEspecialesToolStripMenuItem.Click += new System.EventHandler(this.CobroEspecialesToolStripMenuItemClick);
			// 
			// validaciónEspecialesToolStripMenuItem
			// 
			this.validaciónEspecialesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("validaciónEspecialesToolStripMenuItem.Image")));
			this.validaciónEspecialesToolStripMenuItem.Name = "validaciónEspecialesToolStripMenuItem";
			this.validaciónEspecialesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.validaciónEspecialesToolStripMenuItem.Text = "Validación Especiales";
			this.validaciónEspecialesToolStripMenuItem.Click += new System.EventHandler(this.ValidaciónEspecialesToolStripMenuItemClick);
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.reportesToolStripMenuItem.Text = "Reportes";
			this.reportesToolStripMenuItem.Click += new System.EventHandler(this.ReportesToolStripMenuItemClick);
			// 
			// controlDeGastosToolStripMenuItem
			// 
			this.controlDeGastosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlDeGastosToolStripMenuItem.Image")));
			this.controlDeGastosToolStripMenuItem.Name = "controlDeGastosToolStripMenuItem";
			this.controlDeGastosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.controlDeGastosToolStripMenuItem.Text = "Control de Gastos";
			this.controlDeGastosToolStripMenuItem.Click += new System.EventHandler(this.ControlDeGastosToolStripMenuItemClick);
			// 
			// controlToolStripMenuItem
			// 
			this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.uberTaxiToolStripMenuItem,
									this.reporteUberTaxiToolStripMenuItem});
			this.controlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("controlToolStripMenuItem.Image")));
			this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
			this.controlToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.controlToolStripMenuItem.Text = "Control";
			// 
			// uberTaxiToolStripMenuItem
			// 
			this.uberTaxiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uberTaxiToolStripMenuItem.Image")));
			this.uberTaxiToolStripMenuItem.Name = "uberTaxiToolStripMenuItem";
			this.uberTaxiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.uberTaxiToolStripMenuItem.Text = "Uber-Taxi";
			this.uberTaxiToolStripMenuItem.Click += new System.EventHandler(this.UberTaxiToolStripMenuItemClick);
			// 
			// reporteUberTaxiToolStripMenuItem
			// 
			this.reporteUberTaxiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteUberTaxiToolStripMenuItem.Image")));
			this.reporteUberTaxiToolStripMenuItem.Name = "reporteUberTaxiToolStripMenuItem";
			this.reporteUberTaxiToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.reporteUberTaxiToolStripMenuItem.Text = "Reporte Uber-Taxi";
			this.reporteUberTaxiToolStripMenuItem.Click += new System.EventHandler(this.ReporteUberTaxiToolStripMenuItemClick);
			// 
			// tlReportes
			// 
			this.tlReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuCardex,
									this.MenuReporteCombustible,
									this.MenuReporteGerencial,
									this.MenuReporteOperaciones,
									this.MenuReporteNomina,
									this.MenuReporteBonificaiones,
									this.MenuHorarioRutas,
									this.horarToolStripMenuItem,
									this.viajesPorOperadorToolStripMenuItem,
									this.altasBajaOperadorToolStripMenuItem});
			this.tlReportes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tlReportes.Image = ((System.Drawing.Image)(resources.GetObject("tlReportes.Image")));
			this.tlReportes.Name = "tlReportes";
			this.tlReportes.Size = new System.Drawing.Size(87, 20);
			this.tlReportes.Text = "Reportes";
			// 
			// MenuCardex
			// 
			this.MenuCardex.Image = ((System.Drawing.Image)(resources.GetObject("MenuCardex.Image")));
			this.MenuCardex.Name = "MenuCardex";
			this.MenuCardex.Size = new System.Drawing.Size(221, 22);
			this.MenuCardex.Text = "Cardex";
			this.MenuCardex.Click += new System.EventHandler(this.MenuCardexClick);
			// 
			// MenuReporteCombustible
			// 
			this.MenuReporteCombustible.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteCombustible.Image")));
			this.MenuReporteCombustible.Name = "MenuReporteCombustible";
			this.MenuReporteCombustible.Size = new System.Drawing.Size(221, 22);
			this.MenuReporteCombustible.Text = "Combustible";
			this.MenuReporteCombustible.Click += new System.EventHandler(this.CombustibleToolStripMenuItemClick);
			// 
			// MenuReporteGerencial
			// 
			this.MenuReporteGerencial.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteGerencial.Image")));
			this.MenuReporteGerencial.Name = "MenuReporteGerencial";
			this.MenuReporteGerencial.Size = new System.Drawing.Size(221, 22);
			this.MenuReporteGerencial.Text = "Viajes (Totales - Directivo)";
			this.MenuReporteGerencial.Click += new System.EventHandler(this.MenuReporteGerencialClick);
			// 
			// MenuReporteOperaciones
			// 
			this.MenuReporteOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteOperaciones.Image")));
			this.MenuReporteOperaciones.Name = "MenuReporteOperaciones";
			this.MenuReporteOperaciones.Size = new System.Drawing.Size(221, 22);
			this.MenuReporteOperaciones.Text = "Operaciones";
			this.MenuReporteOperaciones.Click += new System.EventHandler(this.MenuReporteOperacionesClick);
			// 
			// MenuReporteNomina
			// 
			this.MenuReporteNomina.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteNomina.Image")));
			this.MenuReporteNomina.Name = "MenuReporteNomina";
			this.MenuReporteNomina.Size = new System.Drawing.Size(221, 22);
			this.MenuReporteNomina.Text = "Gerencial Nomina";
			this.MenuReporteNomina.Click += new System.EventHandler(this.MenuReporteNominaClick);
			// 
			// MenuReporteBonificaiones
			// 
			this.MenuReporteBonificaiones.Image = ((System.Drawing.Image)(resources.GetObject("MenuReporteBonificaiones.Image")));
			this.MenuReporteBonificaiones.Name = "MenuReporteBonificaiones";
			this.MenuReporteBonificaiones.Size = new System.Drawing.Size(221, 22);
			this.MenuReporteBonificaiones.Text = "Historial Bonificaciones";
			this.MenuReporteBonificaiones.Click += new System.EventHandler(this.MenuReporteBonificaionesClick);
			// 
			// MenuHorarioRutas
			// 
			this.MenuHorarioRutas.Image = ((System.Drawing.Image)(resources.GetObject("MenuHorarioRutas.Image")));
			this.MenuHorarioRutas.Name = "MenuHorarioRutas";
			this.MenuHorarioRutas.Size = new System.Drawing.Size(221, 22);
			this.MenuHorarioRutas.Text = "Horarios Rutas";
			this.MenuHorarioRutas.Click += new System.EventHandler(this.HorariosRutasToolStripMenuItemClick);
			// 
			// horarToolStripMenuItem
			// 
			this.horarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("horarToolStripMenuItem.Image")));
			this.horarToolStripMenuItem.Name = "horarToolStripMenuItem";
			this.horarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.horarToolStripMenuItem.Text = "Horario Rutas Extras";
			this.horarToolStripMenuItem.Click += new System.EventHandler(this.HorarToolStripMenuItemClick);
			// 
			// viajesPorOperadorToolStripMenuItem
			// 
			this.viajesPorOperadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viajesPorOperadorToolStripMenuItem.Image")));
			this.viajesPorOperadorToolStripMenuItem.Name = "viajesPorOperadorToolStripMenuItem";
			this.viajesPorOperadorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.viajesPorOperadorToolStripMenuItem.Text = "Viajes por Operador";
			this.viajesPorOperadorToolStripMenuItem.Click += new System.EventHandler(this.ViajesPorOperadorToolStripMenuItemClick);
			// 
			// altasBajaOperadorToolStripMenuItem
			// 
			this.altasBajaOperadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("altasBajaOperadorToolStripMenuItem.Image")));
			this.altasBajaOperadorToolStripMenuItem.Name = "altasBajaOperadorToolStripMenuItem";
			this.altasBajaOperadorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.altasBajaOperadorToolStripMenuItem.Text = "Altas - Baja Operador";
			this.altasBajaOperadorToolStripMenuItem.Click += new System.EventHandler(this.AltasBajaOperadorToolStripMenuItemClick);
			// 
			// tlSoftware
			// 
			this.tlSoftware.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuUnir,
									this.MenuAdobe,
									this.MenuGrafico,
									this.MenuChat});
			this.tlSoftware.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tlSoftware.Image = ((System.Drawing.Image)(resources.GetObject("tlSoftware.Image")));
			this.tlSoftware.Name = "tlSoftware";
			this.tlSoftware.Size = new System.Drawing.Size(87, 20);
			this.tlSoftware.Text = "Software";
			// 
			// MenuUnir
			// 
			this.MenuUnir.Image = ((System.Drawing.Image)(resources.GetObject("MenuUnir.Image")));
			this.MenuUnir.Name = "MenuUnir";
			this.MenuUnir.Size = new System.Drawing.Size(168, 22);
			this.MenuUnir.Text = "Unir PDF";
			this.MenuUnir.Click += new System.EventHandler(this.ToolUnirClick);
			// 
			// MenuAdobe
			// 
			this.MenuAdobe.Image = ((System.Drawing.Image)(resources.GetObject("MenuAdobe.Image")));
			this.MenuAdobe.Name = "MenuAdobe";
			this.MenuAdobe.Size = new System.Drawing.Size(168, 22);
			this.MenuAdobe.Text = "Instalar Adobe";
			this.MenuAdobe.Click += new System.EventHandler(this.InstalarAdobeToolStripMenuItemClick);
			// 
			// MenuGrafico
			// 
			this.MenuGrafico.Image = ((System.Drawing.Image)(resources.GetObject("MenuGrafico.Image")));
			this.MenuGrafico.Name = "MenuGrafico";
			this.MenuGrafico.Size = new System.Drawing.Size(168, 22);
			this.MenuGrafico.Text = "Instalar Gráficos";
			this.MenuGrafico.Click += new System.EventHandler(this.MenuGraficoClick);
			// 
			// MenuChat
			// 
			this.MenuChat.Image = ((System.Drawing.Image)(resources.GetObject("MenuChat.Image")));
			this.MenuChat.Name = "MenuChat";
			this.MenuChat.Size = new System.Drawing.Size(168, 22);
			this.MenuChat.Text = "Chat";
			this.MenuChat.Click += new System.EventHandler(this.MenuChatClick);
			// 
			// tlArchivo
			// 
			this.tlArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MenuServidor,
									this.MenuCambiarUser,
									this.MenuSalir,
									this.MenuConsulta});
			this.tlArchivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tlArchivo.ForeColor = System.Drawing.Color.Black;
			this.tlArchivo.Image = ((System.Drawing.Image)(resources.GetObject("tlArchivo.Image")));
			this.tlArchivo.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.tlArchivo.Name = "tlArchivo";
			this.tlArchivo.Size = new System.Drawing.Size(88, 20);
			this.tlArchivo.Text = "Conexión";
			// 
			// MenuServidor
			// 
			this.MenuServidor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cambiarConfiguraciónToolStripMenuItem,
									this.verDetallesToolStripMenuItem});
			this.MenuServidor.Image = ((System.Drawing.Image)(resources.GetObject("MenuServidor.Image")));
			this.MenuServidor.Name = "MenuServidor";
			this.MenuServidor.Size = new System.Drawing.Size(152, 22);
			this.MenuServidor.Text = "Servidor";
			// 
			// cambiarConfiguraciónToolStripMenuItem
			// 
			this.cambiarConfiguraciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarConfiguraciónToolStripMenuItem.Image")));
			this.cambiarConfiguraciónToolStripMenuItem.Name = "cambiarConfiguraciónToolStripMenuItem";
			this.cambiarConfiguraciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.cambiarConfiguraciónToolStripMenuItem.Text = "Cambiar configuración";
			this.cambiarConfiguraciónToolStripMenuItem.Click += new System.EventHandler(this.CambiarConfiguraciónToolStripMenuItemClick);
			// 
			// verDetallesToolStripMenuItem
			// 
			this.verDetallesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verDetallesToolStripMenuItem.Image")));
			this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
			this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.verDetallesToolStripMenuItem.Text = "Ver detalles...";
			this.verDetallesToolStripMenuItem.Click += new System.EventHandler(this.VerDetallesToolStripMenuItemClick);
			// 
			// MenuCambiarUser
			// 
			this.MenuCambiarUser.Image = ((System.Drawing.Image)(resources.GetObject("MenuCambiarUser.Image")));
			this.MenuCambiarUser.Name = "MenuCambiarUser";
			this.MenuCambiarUser.Size = new System.Drawing.Size(152, 22);
			this.MenuCambiarUser.Text = "Cerrar sesión";
			this.MenuCambiarUser.Click += new System.EventHandler(this.MenuCambiarUserClick);
			// 
			// MenuSalir
			// 
			this.MenuSalir.Image = ((System.Drawing.Image)(resources.GetObject("MenuSalir.Image")));
			this.MenuSalir.Name = "MenuSalir";
			this.MenuSalir.Size = new System.Drawing.Size(152, 22);
			this.MenuSalir.Text = "Salir";
			this.MenuSalir.Click += new System.EventHandler(this.ToolStripSalirClick);
			// 
			// MenuConsulta
			// 
			this.MenuConsulta.Image = ((System.Drawing.Image)(resources.GetObject("MenuConsulta.Image")));
			this.MenuConsulta.Name = "MenuConsulta";
			this.MenuConsulta.Size = new System.Drawing.Size(152, 22);
			this.MenuConsulta.Text = "Consultas";
			this.MenuConsulta.Click += new System.EventHandler(this.MenuConsultaClick);
			// 
			// toolMenu
			// 
			this.toolMenu.BackColor = System.Drawing.Color.MidnightBlue;
			this.toolMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbVentas,
									this.tsbOperadorVehiculo,
									this.tsbDespacho,
									this.tsbLlamadaCandidato});
			this.toolMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolMenu.Location = new System.Drawing.Point(0, 24);
			this.toolMenu.Name = "toolMenu";
			this.toolMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolMenu.Size = new System.Drawing.Size(1360, 27);
			this.toolMenu.TabIndex = 3;
			this.toolMenu.Text = "toolStrip1";
			// 
			// tsbVentas
			// 
			this.tsbVentas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsbVentas.ForeColor = System.Drawing.Color.White;
			this.tsbVentas.Image = ((System.Drawing.Image)(resources.GetObject("tsbVentas.Image")));
			this.tsbVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbVentas.Name = "tsbVentas";
			this.tsbVentas.Size = new System.Drawing.Size(70, 24);
			this.tsbVentas.Text = "Ventas";
			this.tsbVentas.ToolTipText = "Libro de Viajes";
			this.tsbVentas.Click += new System.EventHandler(this.ToolStripMenuLibrosClick);
			// 
			// tsbOperadorVehiculo
			// 
			this.tsbOperadorVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tsbOperadorVehiculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsbOperadorVehiculo.ForeColor = System.Drawing.Color.White;
			this.tsbOperadorVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("tsbOperadorVehiculo.Image")));
			this.tsbOperadorVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsbOperadorVehiculo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOperadorVehiculo.Name = "tsbOperadorVehiculo";
			this.tsbOperadorVehiculo.Size = new System.Drawing.Size(143, 24);
			this.tsbOperadorVehiculo.Text = "Operador - Vehículo";
			this.tsbOperadorVehiculo.Click += new System.EventHandler(this.operadorVehiculoClick);
			// 
			// tsbDespacho
			// 
			this.tsbDespacho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tsbDespacho.ForeColor = System.Drawing.Color.White;
			this.tsbDespacho.Image = ((System.Drawing.Image)(resources.GetObject("tsbDespacho.Image")));
			this.tsbDespacho.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDespacho.Name = "tsbDespacho";
			this.tsbDespacho.Size = new System.Drawing.Size(88, 24);
			this.tsbDespacho.Text = "Despacho";
			this.tsbDespacho.Click += new System.EventHandler(this.TsbDespachoClick);
			// 
			// tsbLlamadaCandidato
			// 
			this.tsbLlamadaCandidato.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tsbLlamadaCandidato.ForeColor = System.Drawing.Color.White;
			this.tsbLlamadaCandidato.Image = ((System.Drawing.Image)(resources.GetObject("tsbLlamadaCandidato.Image")));
			this.tsbLlamadaCandidato.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLlamadaCandidato.Name = "tsbLlamadaCandidato";
			this.tsbLlamadaCandidato.Size = new System.Drawing.Size(133, 24);
			this.tsbLlamadaCandidato.Text = "Llamada Cadidato";
			this.tsbLlamadaCandidato.Click += new System.EventHandler(this.TsbLlamadaCandidatoClick);
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1360, 746);
			this.Controls.Add(this.toolMenu);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormPrincipal";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transportes LAR ";
			this.TransparencyKey = System.Drawing.Color.LightGray;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalFormClosing);
			this.Load += new System.EventHandler(this.FormPrincipalLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolMenu.ResumeLayout(false);
			this.toolMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem controlDeSelecciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarCandidatoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem controlDeLlamadasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem revisiónDePlacasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem controlDeGastosToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tsbLlamadaCandidato;
		private System.Windows.Forms.ToolStripMenuItem controlFactutaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem altasBajaOperadorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preciosFacturaciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contratacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reporteUberTaxiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uberTaxiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nominaFiscalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reporteViajesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reporteRutasNominalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gestoríaVehículoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pruebaRendimientoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viajesPorOperadorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem validaciónEspecialesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cobroEspecialesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem libroVentasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ventas2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bitácoraDeMantenimientoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entregaYRecepciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem revisiónEspecialesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem horarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem validarOperacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MenuHorarioRutas;
		private System.Windows.Forms.ToolStripMenuItem MenuRutas;
		private System.Windows.Forms.ToolStripMenuItem MenuOrdenTrabajo;
		private System.Windows.Forms.ToolStripMenuItem MenuDatosComb;
		private System.Windows.Forms.ToolStripMenuItem MenuGrafico;
		private System.Windows.Forms.ToolStripMenuItem MenuExtrasComb;
		private System.Windows.Forms.ToolStripMenuItem MenuCuentaBancaria;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteBonificaiones;
		private System.Windows.Forms.ToolStripMenuItem MenuEspecialPendiente;
		private System.Windows.Forms.ToolStripMenuItem MenuCaja;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteNomina;
		private System.Windows.Forms.ToolStripMenuItem ModuloChecador;
		private System.Windows.Forms.ToolStripMenuItem MenuCostoRutaFactura;
		private System.Windows.Forms.ToolStripMenuItem MenuContratoEmpresa;
		private System.Windows.Forms.ToolStripMenuItem MenuExperienciaLaboral;
		private System.Windows.Forms.ToolStripMenuItem MenuPrincipalCombustible;
		private System.Windows.Forms.ToolStripMenuItem MenuCombustibleComplementos;
		private System.Windows.Forms.ToolStripMenuItem MenuESVehiculos;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteOperaciones;
		private System.Windows.Forms.ToolStripMenuItem MenuMensajesDespacho;
		private System.Windows.Forms.ToolStripMenuItem MenuDespacho;
		private System.Windows.Forms.ToolStripMenuItem MenuPrecioFactura;
		private System.Windows.Forms.ToolStripMenuItem MenuConsulta;
		private System.Windows.Forms.ToolStripMenuItem MenuImporteNomina;
		private System.Windows.Forms.ToolStripMenuItem MenuTelcel;
		private System.Windows.Forms.ToolStripMenuItem MenuOperadorRuta;
		private System.Windows.Forms.ToolStripMenuItem MenuTaxi;
		private System.Windows.Forms.ToolStripMenuItem MenuControlDescuentos;
		private System.Windows.Forms.ToolStripMenuItem ItemDirectorioTelefonicoPDF;
		private System.Windows.Forms.ToolStripMenuItem ItemDirectorioTelefonicoExcel;
		private System.Windows.Forms.ToolStripMenuItem tlEspeciales;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteDiario;
		private System.Windows.Forms.ToolStripMenuItem MenuMantenimientos;
		private System.Windows.Forms.ToolStripMenuItem MenuAlmacen;
		private System.Windows.Forms.ToolStripMenuItem MenuFacturacion;
		private System.Windows.Forms.ToolStripMenuItem MenuNomina;
		private System.Windows.Forms.ToolStripMenuItem MenuPuesto;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteEspeciales;
		private System.Windows.Forms.ToolStripMenuItem MenuSueldoAdministrativo;
		private System.Windows.Forms.ToolStripMenuItem MenuSueldoOperador;
		private System.Windows.Forms.ToolStripMenuItem MenuTelefonico;
		private System.Windows.Forms.ToolStripMenuItem MenuCaras;
		private System.Windows.Forms.ToolStripMenuItem tlDirectorio;
		private System.Windows.Forms.ToolStripMenuItem MenuChat;
		private System.Windows.Forms.ToolStripMenuItem MenuSueldoEspeciales;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteValidacion;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteFacturacion;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteGerencial;
		private System.Windows.Forms.ToolStripMenuItem tlUsuario;
		private System.Windows.Forms.ToolStripMenuItem MenuMantenimiento;
		private System.Windows.Forms.ToolStripButton tsbOperadorVehiculo;
		private System.Windows.Forms.ToolStripButton tsbVentas;
		private System.Windows.Forms.ToolStripMenuItem MenuOperador;
		private System.Windows.Forms.ToolStripMenuItem MenuVehiculo;
		private System.Windows.Forms.ToolStripMenuItem MenuOperadorVehiculo;
		private System.Windows.Forms.ToolStripMenuItem ModuloDespacho;
		private System.Windows.Forms.ToolStripMenuItem ModuloCombustible;
		private System.Windows.Forms.ToolStripMenuItem ModuloNomina;
		private System.Windows.Forms.ToolStripMenuItem MenuSalir;
		private System.Windows.Forms.ToolStripMenuItem MenuCambiarUser;
		private System.Windows.Forms.ToolStripMenuItem MenuCatalogoEmpresa;
		private System.Windows.Forms.ToolStripMenuItem MenuServidor;
		private System.Windows.Forms.ToolStripMenuItem MenuAseguradora;
		private System.Windows.Forms.ToolStripMenuItem MenuVentas;
		private System.Windows.Forms.ToolStripMenuItem ModuloFacturacion;
		private System.Windows.Forms.ToolStripMenuItem MenuBono;
		private System.Windows.Forms.ToolStripMenuItem MenuIncapacidad;
		private System.Windows.Forms.ToolStripMenuItem MenuOperadorExterno;
		private System.Windows.Forms.ToolStripMenuItem MenuPercepcionesDeducciones;
		private System.Windows.Forms.ToolStripMenuItem MenuRutaSin;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteVentas;
		private System.Windows.Forms.ToolStripMenuItem MenuReporteCombustible;
		private System.Windows.Forms.ToolStripMenuItem Menuanticipos;
		private System.Windows.Forms.ToolStripMenuItem MenuUnir;
		private System.Windows.Forms.ToolStripMenuItem MenuAdobe;
		private System.Windows.Forms.ToolStripMenuItem MenuCardex;
		private System.Windows.Forms.ToolStripMenuItem tlArchivo;
		private System.Windows.Forms.ToolStripMenuItem tlCliente;
		private System.Windows.Forms.ToolStripMenuItem tlModulos;
		private System.Windows.Forms.ToolStripMenuItem tlEmpleado;
		private System.Windows.Forms.ToolStripMenuItem tlVehiculo;
		private System.Windows.Forms.ToolStripMenuItem tlRuta;
		private System.Windows.Forms.ToolStripMenuItem tlReportes;
		private System.Windows.Forms.ToolStripMenuItem tlSoftware;
		public System.Windows.Forms.ToolStripStatusLabel lblDatoNivel;
		public System.Windows.Forms.ToolStripStatusLabel lblDatoUsuario;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		public System.Windows.Forms.ToolStripStatusLabel lblNivelUsuario;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		public System.Windows.Forms.ToolStripDropDownButton toolAptoMedico;
		private System.Windows.Forms.ToolStripMenuItem rutaOperadorToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tsbDespacho;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		public System.Windows.Forms.ToolStripProgressBar progressbarPrin;
		public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
		public System.Windows.Forms.ToolStripMenuItem ItemNuevoAdmin;
		private System.Windows.Forms.ToolStripMenuItem ItemBuscarAdmin;
		private System.Windows.Forms.ToolStripMenuItem MenuAdministrativo;
		private System.Windows.Forms.ToolStrip toolMenu;
		private System.Windows.Forms.ToolStripMenuItem ItemHistorialOperadorVehículo;
		private System.Windows.Forms.ToolStripMenuItem ItemOperadorVehículo;
		private System.Windows.Forms.ToolStripMenuItem seguroVehicularToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aseguradoraToolStripMenuItem1;
		public System.Windows.Forms.ToolStripSplitButton toolLicencia;
		private System.Windows.Forms.ToolStripMenuItem cambiarConfiguraciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MenuCambioPwd;
		private System.Windows.Forms.ToolStripMenuItem MenuAgregarCuenta;
		private System.Windows.Forms.ToolStripMenuItem MenuBusquedaUsuario;
		public System.Windows.Forms.ToolStripMenuItem agregarOperadorToolStrip;
		private System.Windows.Forms.ToolStripMenuItem ItemAgregarVehiculo;
		private System.Windows.Forms.ToolStripMenuItem ItemBusquedaVehiculo;
		private System.Windows.Forms.ToolStripMenuItem buscarModificarToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		public System.Windows.Forms.ToolStripDropDownButton toolContrato;
        private System.Windows.Forms.ToolStripMenuItem itemforsac;
	}
}
