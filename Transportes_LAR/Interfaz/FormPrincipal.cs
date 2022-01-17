using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using Transportes_LAR.Interfaz.Combustible;
using Transportes_LAR.Interfaz.Operaciones;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz
{
	public partial class FormPrincipal : Form
	{
		#region VARIABLES
		private int variable=0;
		private bool cambioUsuario=false;
		public 	string nombreUsuario="";
		public int idUsuario;
		public bool mostrar=true;
		public static Screen screen= Screen.PrimaryScreen;
		public String Usuario;
		public String Turno="";
		public String Fecha="";
		public String NivelUsuario="";
		#endregion
		
		#region INSTANCIAS_DE_OBJETOS		
		private Interfaz.Notificaciones.FormNCumpleanos formNCumple = null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		public Interfaz.FormLogin login=null;
		private Interfaz.Usuario.FormUsuario formUsuario=null;
		private Interfaz.Usuario.FormBusquedaUsuario formBusquedaUsuario=null;
		private Interfaz.Operador.FormBusquedaOperador formBusquedaOperador=null;
		private Interfaz.Operador.FormBusquedaAdmin formBusquedaAdmin=null;
		private Interfaz.Operador.FormOperador formOperador=null;
		private Interfaz.Cliente.FormBusquedaCliente formBusquedaCliente=null;
		private Interfaz.Zona.FormZona formZona=null;
		private Interfaz.Zona.FormRelacion formRelacion=null;
		private Interfaz.Monitoreo.FormLicencia formLicencia=null;
		private Interfaz.Monitoreo.FormMonitoreoContrato formContrato=null;
		private Interfaz.Unidad.FormBusquedaUnidad formBusquedaUnidad=null;
		private Interfaz.Incapacidad.FormIncapacidades formincapacidad = null;
		private Interfaz.Asignacion.FormOperadorVehiculo formOperadorVehiculo = null;
		private Interfaz.Unidad.FormOperadorVehiculoHistorial formOperadorVehiculoHistorial = null;
		public Interfaz.Aseguradora.FormSeguros formSeguro = null;
		private Interfaz.Aseguradora.FormAseguradoras formAseguradora = null;
		private Interfaz.Libro.LibroViajes formViajes=null;
		public Interfaz.Operaciones.FormOperadores formListaOperador=null;
		private Interfaz.Operaciones.Turno formTurno=null;
		private Interfaz.Unidad.FormUnidad formUnidad=null;
		public Interfaz.Operaciones.FormPrin_Empresas formPrincEmp=null;
		private Interfaz.Nomina.Recibo.FormSueldos formSueldos=null;
		private Interfaz.Contrato.FormDatoContrato formDatoContrato=null;
		private Interfaz.Nomina.FormNomina formNomina=null;
		public Interfaz.Nomina.Bono.FormBonos formBonos=null;
		private Interfaz.Facturacion.FormFacturacion formFacturacion = null;
		private  Interfaz.Reportes.FormReporteOperaciones formReportesOperacion = null;
		private Interfaz.Nomina.SinPrecio.FormViajesSinPrecio formSinPrecio = null;
		private Interfaz.Libro.FormReporteVentas formViajesEspecialesReportes = null;
		private Interfaz.FormReporteCombustible formReportesCombustible = null;
		public Interfaz.Nomina.Anticipos.FormPrincAnticipos formPrinAnticipo = null;
		private Interfaz.Aptomedico.FormAptoMedico formAptomedico = null;
		public Interfaz.Aptomedico.FormReporteApto formReporteAptomedico = null;
		private Interfaz.Reportes.FormReporteGerencial ReporteGerencial = null;
		private Interfaz.Operador.FormOrdenCaritas formordencaritas = null;
		private Interfaz.Mantenimiento.FormAlmacen formalmacen = null;
		private Interfaz.Mantenimiento.FormESvehiculos formESVehiculos = null;
		private Interfaz.Libro.FormFacturaEsp formFact = null;
		private Interfaz.Libro.formAuditacion formAudita = null;
		private Interfaz.Nomina.Especiales.FormPrivilegioCobro FormPrivilegio = null;
		private Interfaz.Nomina.Especiales.Finanzas.FormReporte formreporteServicios = null;
		private Interfaz.Operador.FormPuesto formpuesto = null;
		private Interfaz.Nomina.Anticipos.FormTaxi formtaxi = null;
		private Interfaz.Nomina.FormImpuestos formimpuestos= null;
		private Interfaz.Nomina.FormImportes formImportes= null;
		private Interfaz.Combustible.FormCompCombustible formCompComb = null;
		private Interfaz.Consultas.FormConsultas formconsulta = null;
		private Interfaz.Facturacion.FormFactHenniges formFacthenn = null;
		private Interfaz.Operaciones.Despacho.FormProgramaRecados formRecados= null;
		private Interfaz.Combustible.formPrincipalComb formprinCombustible = null;
		private Interfaz.Operador.FormExperiencia formExperiencia = null;
		private Interfaz.Cliente.FormContratoEmpresa formContratoEmpresa = null;
		private Interfaz.Lector.FormMain formChecador = null;
		private Interfaz.Facturacion.FormCobroFactura formCostoFactura = null;
		private Interfaz.Reportes.FormReporteNomina formReporteNomina = null;
		private Interfaz.Caja.FormPrincipalCaja formPrincipalCaja = null;
		private Interfaz.Nomina.Especiales.Finanzas.FormPendientes formPendientes = null;
		private Interfaz.Reportes.FormReporteBonificaciones formreportesBonificaciones = null;
		private Interfaz.Operador.FormCuentaBancaria formcuentabancaria = null;
		private Interfaz.Combustible.FormCombOperaciones formComOperaciones =  null;
		private Transportes_LAR.Interfaz.Combustible.EasyTrack.FormDatos formdatoscomb =  null;
		private Interfaz.Mantenimiento.FormOrdenTrabajo formordentrabajo = null;
		private Interfaz.Mantenimiento.FormEstadoUnidad formEstUni = null;
        private Interfaz.Ruta.FormProgramaRutas formprogramarutas = null;
        private Interfaz.Ruta.FormTipoRuta formtiporuta = null;        		
		private Interfaz.Combustible.FormValidacionOperaciones formValidacionOperaciones = null;
		private Interfaz.Reportes.FormReporteRutasExtras formRutasExtra = null;		
		private Interfaz.Nomina.Especiales.FormMalFlujo formMalFlujo = null;						
		private Interfaz.Libro_Nuevo.FormLibroViajes formViajes2 = null;
		private Interfaz.Libro_Nuevo.Pagos.PrivilegiosPagos cobroVentas = null;	
		private Interfaz.Libro_Nuevo.Pagos.FormGastosServicios gastosVentas = null;		
		private Interfaz.Libro_Nuevo.Complementos_Libro.FormReportes ReportesVentas = null;	
		private Interfaz.Libro_Nuevo.Validacion_Final.FormValidarServicios formvalidaVentas = null;	
		private Interfaz.Reportes.FormViajesOperador ViajesOperador = null;		
		private Interfaz.Combustible.FormPruebaRendimiento formPruebaRendimiento = null;
		private Interfaz.Unidad.Gestoria.Gestoria formUnidadGestoria = null;
		private Interfaz.Nomina.FormReporteNomina formReporteN = null;
		private Interfaz.Reportes.FormReporteViajesDespacho formReporteCuadreDespacho = null;
		private Interfaz.Operaciones.FormPasajeros formPasajero = null;
		private Interfaz.Nomina.Nomina_Fiscal.FormNominaFiscal formNominaFiscal = null;
		private Interfaz.Controles.Uber_Taxi.FormReporteUT formReporteUT = null;
		private Interfaz.Controles.Uber_Taxi.FormUber_TaxiExtra formUberTaxiExtra = null;
		private Interfaz.Operador.Pre_Seleccion.FormContratacion formContratacion = null;
		public Interfaz.Operador.Pre_Seleccion.FormRegistar formContratacionRegistrar = null;
		private Interfaz.Operador.Pre_Seleccion.FormLlamada formLlamadaContratacion = null;
		private Interfaz.Facturacion.FormPreciosF formPreciosF = null;
		private Interfaz.Reportes.FormReportesAltaBajaOperador formABOperador = null;
		private Interfaz.Facturacion.FormControl formControlF = null;
		private Interfaz.Unidad.FormPlacasRevision formPlacasRevision = null;
		#endregion
		
		#region	CONTROL_DE_VENTANAS_ABIERTAS
		public bool usuario=false;
		public bool busquedaUsuario=false;
		public bool busquedaOperador=false;
		public bool busquedaAdmin=false;
		public bool busquedaCliente=false;
		public bool operador=false;
		public bool cliente=false;
		public bool zona=false;
		public bool licencia=false;
		public bool contrato=false;
		public bool busquedaUnidad=false;
		public bool unidad=false;
		public bool operadorVehiculo = false;
		public bool operadorVehiculoHistorial = false;
		public bool seguro = false;
		public bool aseguradora = false;
		public bool busquedaRuta = false;
		public bool libroviajes = false;
		public bool operaciones = false;
		public bool prinOperador = false;
		public bool datoContrato=false;
		public bool historialContrato=false;
		public bool reportelicencia=false;
		public bool nomina=false;
		public bool prinEmpresas=false;
		public bool turno=false;
		public bool bonos=false;
		public bool Factura=false;
		public bool incapacidad=false;
		public bool sueldosbool=false;
		public bool rutas0=false;
		public bool RutaEspecialReporte=false;
		public bool CombustibleReport=false;
		public bool recibos = false;
		public bool anticipos = false;
		public bool aptomedico = false;
		public bool reporteApto = false;
		public bool OperadorExterno = false;
		public bool reportegerencial=false;
		public bool auditacion = false;
		public bool facturaEspeciales =  false;
		public bool validacionEspeciales = false;
		public bool extras = false;
		public bool cerrrado = false;
		public bool ordencaritas = false;
		public bool almacen = false;
		public bool taxi = false;
		public bool relacionZona = false;
		public bool puesto = false;
		public bool reporteServicios = false;
		public bool prestamos = false;
		public bool Facturahnn = false;
		public bool Consulta = false;
		public bool nocobra = false;
		public bool mensajeDes = false;
		public bool esVehiculos = false;
		public bool checador = false;
		public bool costofactura = false;
		public bool reportenomina = false;
		public bool PrincipalCaja = false;
		public bool EspecialesPendientes = false;
		public bool reporteBonificaciones =  false;
		public bool cuentabancaria = false;
		public bool combustible = false;
		public bool ordentrabajo = false;		
		public bool validacionOpeCombustible = false;
		public bool reporteRutaExtra = false;
		public bool revisionMalFlujo = false;		
		public bool ordenT = false;
		public bool estadoUnidad = false;			
		public bool libroviajes2 = false;
		public bool cobroVenta = false;
		public bool gastoVenta = false;
		public bool reportVentas = false;		
		public bool viajesOpe = false;
		public bool validaVentas = false;
		public bool pruebaRendimiento = false;
		public bool unidadGesto = false;
		public bool reporten = false;
		public bool reporteCuadreDespacho = false;
		public bool pasajeros = false;
		public bool nominaF = false;
		public bool reporteUT = false;
		public bool ubertaxiExtra = false;
		public bool contratacion = false;
		public bool contratacionRegistrar = false;
		public bool llamadaContratacion = false;
		public bool preciosFacturacion = false;
		public bool controlFacturacion = false;
		public bool ABOperador = false;		
		public bool placasRevision = false;		
		#endregion
		
		#region CONSTRUCTOR
		public FormPrincipal(Interfaz.FormLogin login)
		{
			InitializeComponent();
			this.login=login;
			this.nombreUsuario=login.usuario;
			this.idUsuario=Convert.ToInt16(login.id_usuario);
			
		}
		#endregion
		
		#region EVENTO_CIERRE_DE_VENTANA
		void FormPrincipalFormClosing(object sender, FormClosingEventArgs e)
		{
			if(operador == false && prinEmpresas == false){
				cerrrado=true;
				if(mostrar)
				{
					if(!(cambioUsuario))
					{
						if(variable==0)
						{
							this.variable=1;
							DialogResult result=MessageBox.Show("¿Desea salir del sistema?","Cerrando la aplicación*",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
							if(DialogResult.OK==result)
							{
								if(operaciones==true)
								{
									formListaOperador.cerrado();
									formPrincEmp.cerrado();
									formPrincEmp.revisionTerminado();
								}
								Application.Exit();
							}
							else if(DialogResult.Cancel==result)
							{
								e.Cancel=true;
								this.variable=0;
							}
						}
						else if(variable==1)
						{
							if(operaciones==true)
							{
								formListaOperador.cerrado();
								formPrincEmp.cerrado();
								formPrincEmp.revisionTerminado();
							}
							Application.Exit();
						}	
					}
				}	
			}else{
				MessageBox.Show("Lo sentimos no se pudo cerrar el sistema Lar, Cierra el modulo de Despacho", "Sistema Lar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion
		
		#region EVENTO (LOAD)
		void FormPrincipalLoad(object sender, EventArgs e)
		{				
			lblDatoUsuario.Text = nombreUsuario.ToUpper();
			lblDatoNivel.Text = new Conexion_Servidor.Usuario.SQL_Usuario().getNivelUsuario(idUsuario.ToString()).ToString();
			lblUsuario.Text="Sesión Iniciada por: ";
			lblNivelUsuario.Text = "  Nivel: ";
			Usuario = lblUsuario.Text;	
			//NivelEmpleado();
			tsbDespacho.Text=tsbDespacho.Text+" Alt+"+"&D";	
			tsbOperadorVehiculo.Text=tsbOperadorVehiculo.Text+" Alt+"+"&O";
			toolContrato.Visible=true;
			toolAptoMedico.Visible=true;
			toolLicencia.Visible=true;
						
			// privilegios NOMINA
			string fechaNomina = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN())).AddDays(2).ToString("dd/MM/yyyy");
			if(fechaNomina == DateTime.Now.ToString("dd/MM/yyyy") && idUsuario == 17){
				if( Convert.ToDateTime(DateTime.Now.ToString("HH:mm")) >= Convert.ToDateTime("08:00") && Convert.ToDateTime(DateTime.Now.ToString("HH:mm")) < Convert.ToDateTime("16:00"))
					lblDatoNivel.Text = "GERENCIAL";
			}
			
			if(lblDatoNivel.Text != "GERENCIAL" && lblDatoNivel.Text != "MASTER"){
				if(fechaNomina != DateTime.Now.ToString("dd/MM/yyyy"))
					MenuNomina.Visible = false;
			}
			if(lblDatoUsuario.Text == "PATY" )
				tsbOperadorVehiculo.Visible = false;			
			
			NivelEmpleado();
			notificaCumpleaños();
			alertaPlacas();
		}
		#endregion 
				
		#region HERRAMIENTAS_ALERTA
		void ToolContratoClick(object sender, EventArgs e)
		{
			if(Convert.ToInt32(new Conexion_Servidor.Evaluacion().getNumFila("select count(ID) as Cantidad from OPERADOR where Estatus='1' and ID not in (select IdOperador from OperadorContrato)"))>0)
			{
				getInterfazcontrato();	
			}
		}
		
		void ToolLicenciaButtonClick(object sender, EventArgs e)
		{
			if(Convert.ToInt32(new Conexion_Servidor.Evaluacion().getNumFila("SELECT count(ID) as Cantidad FROM OPERADOR WHERE ID IN(SELECT ID_Chofer FROM LICENCIA WHERE VIGENCIA < (SELECT CONVERT (date, SYSDATETIME())))"))>0)
			{
				getInterfazLicencia();	
			}	
		}
		#endregion

		#region EVENTOS_DEL_MENU_ARCHIVO
		
		//--EVENTO_CAMBIO_DE_USUARIO
		void MenuCambiarUserClick(object sender, EventArgs e)
		{
			CambioUsuario();
		}

		public void CambioUsuario()
		{
			this.cambioUsuario=true;
			this.Close();
			login.Visible=true;
			login.txtUsuario.Focus();
		}
		
		//--EVENTO_AGREGAR_UN_NUEVO_USUARIO
		void AgregarCuentaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_usuario",login.usuario))[0]=="1"){
				if(usuario)
				{
					if(formUsuario.WindowState==FormWindowState.Minimized)
						formUsuario.WindowState = FormWindowState.Normal;
					else
						formUsuario.BringToFront();
				}
				else
				{
					formUsuario= new Interfaz.Usuario.FormUsuario(1,this);
					formUsuario.Show();
					formUsuario.MdiParent=this;
					usuario=true;
				}
			}
			else
			{
				MessageBox.Show("Imposible acceder a la petición ya que actualmente no cuenta con el privilegio de crear un usuario nuevo.","Agregar usuario",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		
		//--MODIFICAR_USUARIO
		void ModificarCuentaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_usuario",login.usuario))[1]=="2" || (new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_usuario",login.usuario))[2]=="3")
			{
				if(this.busquedaUsuario)
				{
					if(formBusquedaUsuario.WindowState==FormWindowState.Minimized)
						formBusquedaUsuario.WindowState = FormWindowState.Normal;
					else
						formBusquedaUsuario.BringToFront();
				}
				else
				{
					this.formBusquedaUsuario=new Transportes_LAR.Interfaz.Usuario.FormBusquedaUsuario(this);
					formBusquedaUsuario.Show();
					formBusquedaUsuario.MdiParent=this;
					busquedaUsuario=true;
				}
			}
			else
			{
				MessageBox.Show("Imposible acceder a la petición ya que actualmente no cuenta con el privilegio de modificar o eliminar un usuario nuevo.","Agregar usuario",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		
		//--CAMBIAR_MI_USUARIO_Y_CONTRASEÑA
		void ConfigurarMiCuentaToolStripMenuItemClick(object sender, EventArgs e)
		{
			new Interfaz.Usuario.FormModificarCuenta(this).ShowDialog();
		}
		
		//--VER_CONFIGURACIÓN_DEL_SERVIDOR
		void VerDetallesToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Servidor:\t\t"  + new Conexion_Servidor.Servidor().getServidor()+"\n"+
			                "Instancia:\t" + new Conexion_Servidor.Servidor().getInstancia()+"\n"+
			                "Nombre B.D.\t"  + new Conexion_Servidor.Servidor().getBase()+"\n"+
			                "Usuario:\t\t"   + new Conexion_Servidor.Servidor().getUsuario(),"Configuración de conexión al servidor",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		//--CAMBIAR_CONFIGURACION_SERVIDOR
		void CambiarConfiguraciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			new Interfaz.Configuracion.FormConfiguracion(this,"Actualizar configuración").ShowDialog();
		}
		
		void ToolStripSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		#endregion
		
		#region OPERADOR
		public void getInterfazOperador(Interfaz.FormPrincipal principal, String tipo){
			if(this.operador)
			{
				if(formOperador.WindowState==FormWindowState.Minimized)
					formOperador.WindowState = FormWindowState.Normal;
				else
					formOperador.BringToFront();
			}
			else
			{
				this.formOperador=new Transportes_LAR.Interfaz.Operador.FormOperador(principal);
				formOperador.TIPO=tipo;
				formOperador.Show();
				formOperador.MdiParent=this;
				operador=true;
			}
		}
		
		void BuscarModificarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.busquedaOperador)
			{
				if(formBusquedaOperador.WindowState==FormWindowState.Minimized)
					formBusquedaOperador.WindowState = FormWindowState.Normal;
				else
					formBusquedaOperador.BringToFront();
			}
			else
			{
				this.formBusquedaOperador=new Transportes_LAR.Interfaz.Operador.FormBusquedaOperador(this);
				formBusquedaOperador.Show();
				formBusquedaOperador.MdiParent=this;
				busquedaOperador=true;
			}
		}
		
		void ItemBuscarAdminClick(object sender, EventArgs e)
		{
			if(this.busquedaAdmin)
			{
				if(formBusquedaAdmin.WindowState==FormWindowState.Minimized)
					formBusquedaAdmin.WindowState = FormWindowState.Normal;
				else
					formBusquedaAdmin.BringToFront();
			}
			else
			{
				this.formBusquedaAdmin=new Transportes_LAR.Interfaz.Operador.FormBusquedaAdmin(this);
				formBusquedaAdmin.Show();
				formBusquedaAdmin.MdiParent=this;
				busquedaAdmin=true;
			}
		}
		
		void AgregarOperadorToolStripClick(object sender, EventArgs e)
		{
			getInterfazOperador(this,"OPE");
		}
		
		void OperadorExternoToolStripMenuItemClick(object sender, EventArgs e)
		{
			getInterfazOperador(this,"EXT");
		}
		
		void MenuPuestoClick(object sender, EventArgs e)
		{
			this.formpuesto = new Interfaz.Operador.FormPuesto(this);
			this.formpuesto.BringToFront();
			this.formpuesto.Show();
			this.formpuesto.MdiParent=this;
			this.puesto=true;
		}
		void ItemNuevoAdminClick(object sender, EventArgs e)
		{
			getInterfazOperador(this,"ADM");
		}
		
		void MenuCuentaBancariaClick(object sender, EventArgs e)
		{
			if(this.cuentabancaria==true)
			{
				if(formcuentabancaria.WindowState==FormWindowState.Minimized)
					formcuentabancaria.WindowState = FormWindowState.Normal;
				else
					formcuentabancaria.BringToFront();
			}
			else
			{
				this.formcuentabancaria = new Transportes_LAR.Interfaz.Operador.FormCuentaBancaria(this, idUsuario);
				this.formcuentabancaria.BringToFront();
				this.formcuentabancaria.Show();
				this.formcuentabancaria.MdiParent = this;
				this.cuentabancaria = true;
			}
		}
		
		void MenuExperienciaLaboralClick(object sender, EventArgs e)
		{
			formExperiencia = new Interfaz.Operador.FormExperiencia(this);
			formExperiencia.MdiParent=this;
			formExperiencia.Show();
		}
		
		#endregion
		
		#region DIRECTORIO
		void MenuCarasClick(object sender, EventArgs e)
		{
			if(this.ordencaritas==true)
			{
				if(formordencaritas.WindowState==FormWindowState.Minimized)
					formordencaritas.WindowState = FormWindowState.Normal;
				else
					formordencaritas.BringToFront();
			}
			else
			{
				this.formordencaritas=new Transportes_LAR.Interfaz.Operador.FormOrdenCaritas(this, idUsuario.ToString());
				this.formordencaritas.BringToFront();
				this.formordencaritas.Show();
				this.formordencaritas.MdiParent=this;
				this.ordencaritas=true;
			}
		}
		
		void MenuDirectorioTelefonicoExcelClick(object sender, EventArgs e)
		{
			Excels.DirectorioTelefonicoExcel();
		}
		
		void MenuDirectorioTelefonicoPDFClick(object sender, EventArgs e)
		{
			Interfaz.Nomina.FormNomina fnomina = new Interfaz.Nomina.FormNomina(this, idUsuario.ToString());
			fnomina.DirectorioTelefonico();
		}
		#endregion
		
		#region CLIENTE
		void ClienteEmpresaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.busquedaCliente)
			{
				if(formBusquedaCliente.WindowState==FormWindowState.Minimized)
					formBusquedaCliente.WindowState = FormWindowState.Maximized;
				else
					formBusquedaCliente.BringToFront();
			}
			else
			{
				this.formBusquedaCliente=new Transportes_LAR.Interfaz.Cliente.FormBusquedaCliente(this);
				this.formBusquedaCliente.BringToFront();
				this.formBusquedaCliente.WindowState = FormWindowState.Maximized;
				this.formBusquedaCliente.Show();
				formBusquedaCliente.MdiParent=this;
				busquedaCliente=true;
			}
		}
		
		void MenuContratoEmpresaClick(object sender, EventArgs e)
		{
			formContratoEmpresa = new Interfaz.Cliente.FormContratoEmpresa(this);
			formContratoEmpresa.MdiParent=this;
			formContratoEmpresa.Show();
		}
		#endregion
		
		#region CARDEX
		void MenuCardexClick(object sender, EventArgs e)
		{
			Interfaz.Reportes.FormCardex ReporteCardex = new Interfaz.Reportes.FormCardex(this);
			ReporteCardex.MdiParent=this;
			ReporteCardex.Show();
		}
		#endregion
		
		#region RUTA - ZONA
		void ZonaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.zona)
			{
				if(formZona.WindowState==FormWindowState.Normal)
					formZona.WindowState = FormWindowState.Normal;
				else
					formZona.BringToFront();
			}
			else
			{
				this.formZona=new Transportes_LAR.Interfaz.Zona.FormZona(this);
				formZona.Show();
				formZona.MdiParent=this;
				zona=true;
			}
		}
		
		void MenuOperadorRutaClick(object sender, EventArgs e)
		{
			if(this.relacionZona==true)
			{
				if(formRelacion.WindowState==FormWindowState.Minimized)
					formRelacion.WindowState = FormWindowState.Normal;
				else
					formRelacion.BringToFront();
			}
			else
			{
				this.formRelacion = new Transportes_LAR.Interfaz.Zona.FormRelacion();
				this.formRelacion.BringToFront();
				this.formRelacion.Show();
				this.formRelacion.MdiParent=this;
				this.relacionZona=true;
			}
		}
		
				void RutaOperadorToolStripMenuItemClick(object sender, EventArgs e)
		{
			Interfaz.Operador.FormReconocimientoRuta formreconocimiento = new Interfaz.Operador.FormReconocimientoRuta();
			formreconocimiento.MdiParent=this;
			formreconocimiento.Show();
		}
		
		void RutasItemClick(object sender, EventArgs e)
		{
			if(this.rutas0==true)
			{
				if(formSinPrecio.WindowState==FormWindowState.Minimized)
					formSinPrecio.WindowState = FormWindowState.Maximized;
				else
					formSinPrecio.BringToFront();
			}
			else
			{
				this.formSinPrecio= new Transportes_LAR.Interfaz.Nomina.SinPrecio.FormViajesSinPrecio(this);
				this.formSinPrecio.BringToFront();
				this.formSinPrecio.Show();
				this.formSinPrecio.MdiParent=this;
				this.rutas0=true;
			}
		}
		
		private void itemforsac_Click(object sender, EventArgs e)
        {
            this.formprogramarutas = new Transportes_LAR.Interfaz.Ruta.FormProgramaRutas(this);
            this.formprogramarutas.WindowState = FormWindowState.Normal;
            this.formprogramarutas.BringToFront();
            this.formprogramarutas.Show();
            this.formprogramarutas.MdiParent = this;
        }
		
		void MenuRutasClick(object sender, EventArgs e)
		{
			this.formtiporuta = new Transportes_LAR.Interfaz.Ruta.FormTipoRuta(this);
            this.formtiporuta.WindowState = FormWindowState.Normal;
            this.formtiporuta.BringToFront();
            this.formtiporuta.Show();
            this.formtiporuta.MdiParent = this;
		}	
		#endregion 
		
		#region INTERFAZ (CONTRATO - LICENCIA - APTO)
		private void getInterfazcontrato()
		{
			if(this.contrato==false)
			{
					this.formContrato=new Interfaz.Monitoreo.FormMonitoreoContrato(this);
					this.formContrato.WindowState = FormWindowState.Normal;
					formContrato.Show();
					formContrato.MdiParent=this;
					formContrato.color();
					contrato=true;
					toolContrato.Visible=false;
			}
			else
			{
				if(formContrato.WindowState==FormWindowState.Minimized)
					formContrato.WindowState = FormWindowState.Normal;
				else
					formContrato.BringToFront();
			}
	}
		
		private void getInterfazApto()
		{
			if(this.aptomedico==false)
			{
				this.formAptomedico = new Transportes_LAR.Interfaz.Aptomedico.FormAptoMedico(this);
				this.formAptomedico.WindowState = FormWindowState.Normal;
				this.formAptomedico.BringToFront();
				this.formAptomedico.Show();
				this.formAptomedico.MdiParent=this;
				this.aptomedico=true;
				toolAptoMedico.Visible=false;
			}
			else
			{
				if(formAptomedico.WindowState==FormWindowState.Minimized)
					formAptomedico.WindowState = FormWindowState.Normal;
				else
					formAptomedico.BringToFront();
			}
		}
		
		private void getInterfazLicencia()
		{
			if(this.licencia==false)
			{
				this.formLicencia=new Interfaz.Monitoreo.FormLicencia(this);
				formLicencia.WindowState=FormWindowState.Normal;
				formLicencia.Show();
				formLicencia.MdiParent=this;
				licencia=true;
				toolLicencia.Visible=false;
			}
			else
			{
				if(formLicencia.WindowState==FormWindowState.Minimized)
					formLicencia.WindowState = FormWindowState.Normal;
				else
					formLicencia.BringToFront();
			}
		}
		
		void ToolAptoMedicoClick(object sender, EventArgs e)
		{
			getInterfazApto();
		}
		#endregion 
		
		#region VEHICULO
		void GestoríaVehículoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.unidadGesto == true)
			{
				if(formUnidadGestoria.WindowState==FormWindowState.Minimized)
					formUnidadGestoria.WindowState = FormWindowState.Maximized;
				else
					formUnidadGestoria.BringToFront();
			}else{
				this.formUnidadGestoria = new Transportes_LAR.Interfaz.Unidad.Gestoria.Gestoria(this, idUsuario);
				formUnidadGestoria.BringToFront();
				this.formUnidadGestoria.Show();
				this.formUnidadGestoria.MdiParent=this;
				this.unidadGesto = true;
			}
		}
		
		void BuscarModificarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			getFormBusquedaUnidad();
		}
		
		private void getFormBusquedaUnidad() 
		{
			if(this.busquedaUnidad==true)
			{
				if(formBusquedaUnidad.WindowState==FormWindowState.Minimized)
					formBusquedaUnidad.WindowState = FormWindowState.Maximized;
				else
					formBusquedaUnidad.BringToFront();
			}
			else
			{
				this.formBusquedaUnidad = new Transportes_LAR.Interfaz.Unidad.FormBusquedaUnidad(this, idUsuario);
				formBusquedaUnidad.Show();
				formBusquedaUnidad.consultaLista2();
				formBusquedaUnidad.MdiParent=this;
				busquedaUnidad=true;
			}
		}
		
		
		void operadorVehiculoClick(object sender, EventArgs e)
		{
			getOperadorVehiculo();
		}
		
		private void getOperadorVehiculo()
		{
			if(this.operadorVehiculo==true)
			{
				if(formOperadorVehiculo.WindowState==FormWindowState.Minimized)
					formOperadorVehiculo.WindowState = FormWindowState.Maximized;
				else
					formOperadorVehiculo.BringToFront();
			}
			else
			{
				this.formOperadorVehiculo=new Transportes_LAR.Interfaz.Asignacion.FormOperadorVehiculo(this, idUsuario.ToString());
				formOperadorVehiculo.WindowState = FormWindowState.Maximized;
				formOperadorVehiculo.Show();
				formOperadorVehiculo.MdiParent=this;
				operadorVehiculo=true;
			}
		}
		
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(unidad==true)
			{
				if(formUnidad.WindowState==FormWindowState.Minimized)
					formUnidad.WindowState = FormWindowState.Maximized;
				else
					formUnidad.BringToFront();
			}
			else
			{
				this.formUnidad = new Transportes_LAR.Interfaz.Unidad.FormUnidad(this, idUsuario);
				formUnidad.Show();
				unidad=true;
			}
		}
		
		void OperadorVehículoToolStripMenuItemClick(object sender, EventArgs e)
		{
			getOperadorVehiculo();
		}
		
		private void alertaPlacas(){
			if(lblDatoUsuario.Text == "MELISSA" ){
				if(Convert.ToInt32(new Conexion_Servidor.Evaluacion().getNumFila(@"select count(a.id) Cantidad from AUTORIZACION a join MAS_DATOS_AUTORIZACION md on md.ID_A = a.ID where a.ESTATUS != '0' AND md.PLACA_ESTATUS != 
								'CORRECTO' and PLACA_REVISION = 'NO' ")) > 0){
					if(this.placasRevision == true){
						if(formPlacasRevision.WindowState == FormWindowState.Minimized)
							formPlacasRevision.WindowState = FormWindowState.Normal;
						else
							formPlacasRevision.BringToFront();
					}else{
						this.formPlacasRevision = new Transportes_LAR.Interfaz.Unidad.FormPlacasRevision(this);
						formPlacasRevision.BringToFront();
						this.formPlacasRevision.Show();
						this.formPlacasRevision.MdiParent = this;
						this.placasRevision = true;
					}	
				}
			}
		}
		#endregion
		
		#region SEGURO
		void AccesoSeguroClick(object sender, EventArgs e)
		{
			getFormSeguros();
		}
		
		private void getFormSeguros () 
		{
			if(this.seguro)
			{
				if(formSeguro.WindowState==FormWindowState.Minimized)
					formSeguro.WindowState = FormWindowState.Normal;
				else
					formSeguro.BringToFront();
			}
			else
			{
				this.formSeguro=new Transportes_LAR.Interfaz.Aseguradora.FormSeguros(this);
				this.formSeguro.Show();
				this.formSeguro.MdiParent=this;
				this.seguro=true;
			}
		}
		
		
		void SeguroVehicularToolStripMenuItemClick(object sender, EventArgs e)
		{
			getFormSeguros();
		}
		
		void AseguradoraToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(this.aseguradora)
			{
				if(formAseguradora.WindowState==FormWindowState.Minimized)
					formAseguradora.WindowState = FormWindowState.Normal;
				else
					formAseguradora.BringToFront();
			}
			else
			{
				this.formAseguradora=new Transportes_LAR.Interfaz.Aseguradora.FormAseguradoras(this);
				this.formAseguradora.Show();
				this.formAseguradora.MdiParent=this;
				this.aseguradora =true;
			}
		}
		
		void HistorialOperadorVehículoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.operadorVehiculoHistorial==true)
			{
				if(formOperadorVehiculoHistorial.WindowState==FormWindowState.Minimized)
					formOperadorVehiculoHistorial.WindowState = FormWindowState.Maximized;
				else
					formOperadorVehiculoHistorial.BringToFront();
			}
			else
			{
				this.formOperadorVehiculoHistorial=new Transportes_LAR.Interfaz.Unidad.FormOperadorVehiculoHistorial(this);
				formOperadorVehiculoHistorial.Show();
				formOperadorVehiculoHistorial.MdiParent=this;
				operadorVehiculoHistorial=true;
			}
		}
		
		#endregion
		
		#region VIAJES ESPECIALES
		void ControlDeGastosToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.gastoVenta == true)
			{
				if(cobroVentas.WindowState==FormWindowState.Minimized)
					gastosVentas.WindowState = FormWindowState.Maximized;
				else
					gastosVentas.BringToFront();
			}
			else
			{
				this.gastosVentas = new Transportes_LAR.Interfaz.Libro_Nuevo.Pagos.FormGastosServicios(this);
				gastosVentas.BringToFront();
				gastosVentas.WindowState = FormWindowState.Maximized;
				this.gastosVentas.Show();
				this.gastosVentas.MdiParent=this;
				this.gastoVenta = true;
			}	
		}
		
		void LibroDeViajesToolStripMenuItemClick(object sender, EventArgs e)
		{
			getFormLibros();
		}
		
		void ToolStripMenuLibrosClick(object sender, EventArgs e)
		{
			//getFormLibros();
			
			if(this.libroviajes2==true)
			{
				if(formViajes2.WindowState==FormWindowState.Minimized)
					formViajes2.WindowState = FormWindowState.Maximized;
				else
					formViajes2.BringToFront();
			}
			else
			{
				this.formViajes2=new Transportes_LAR.Interfaz.Libro_Nuevo.FormLibroViajes(this);
				formViajes2.BringToFront();
				formViajes2.WindowState = FormWindowState.Maximized;
				this.formViajes2.Show();
				this.formViajes2.MdiParent=this;
				this.libroviajes2=true;
			}
			
		}
		
		private void getFormLibros () {			
			if(this.libroviajes==true)
			{
				if(formViajes.WindowState==FormWindowState.Minimized)
					formViajes.WindowState = FormWindowState.Maximized;
				else
					formViajes.BringToFront();
			}
			else
			{
				this.formViajes=new Transportes_LAR.Interfaz.Libro.LibroViajes(this);
				formViajes.BringToFront();
				formViajes.WindowState = FormWindowState.Maximized;
				this.formViajes.Show();
				this.formViajes.MdiParent=this;
				this.libroviajes=true;
			}
		}
		
		void MenuReporteValidacionClick(object sender, EventArgs e)
		{
			if(this.auditacion==true)
			{
				if(formAudita.WindowState==FormWindowState.Minimized)
					formAudita.WindowState = FormWindowState.Maximized;
				else
					formAudita.BringToFront();
			}
			else
			{
			Interfaz.Libro.formAuditacion formAudita = new Transportes_LAR.Interfaz.Libro.formAuditacion(this);
			formAudita.WindowState = FormWindowState.Maximized;
			formAudita.MdiParent = this;
			formAudita.Show();
			}
		}
		
		public void getCobroEspeciales(int tipo)
		{
			Interfaz.Nomina.Especiales.FormCuentasEsp cuentasEsp= new Interfaz.Nomina.Especiales.FormCuentasEsp(this, tipo);
			cuentasEsp.WindowState = FormWindowState.Maximized;
			cuentasEsp.BringToFront();
			cuentasEsp.Show();
			cuentasEsp.MdiParent=this;
			//this.almacen=true;
		}
		
		void MenuSueldoEspecialesClick(object sender, EventArgs e)
		{
			if(this.validacionEspeciales==true)
			{
				if(FormPrivilegio.WindowState==FormWindowState.Minimized)
					FormPrivilegio.WindowState = FormWindowState.Maximized;
				else
					FormPrivilegio.BringToFront();
			}
			else
			{
				Interfaz.Nomina.Especiales.FormPrivilegioCobro FormPrivilegio = new Interfaz.Nomina.Especiales.FormPrivilegioCobro(this);
				FormPrivilegio.ShowDialog();
			}
		}
		
		void MenuReporteVentasClick(object sender, EventArgs e)
		{
			if(this.RutaEspecialReporte==true)
			{
				if(formViajesEspecialesReportes.WindowState==FormWindowState.Minimized)
					formViajesEspecialesReportes.WindowState = FormWindowState.Maximized;
				else
					formViajesEspecialesReportes.BringToFront();
			}
			else
			{
				this.formViajesEspecialesReportes = new Transportes_LAR.Interfaz.Libro.FormReporteVentas(this);
				this.formViajesEspecialesReportes.BringToFront();
				this.formViajesEspecialesReportes.Show();
				this.formViajesEspecialesReportes.MdiParent=this;
				this.RutaEspecialReporte=true;
			}
		}	
		
		void RevisiónEspecialesToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.revisionMalFlujo==true)
			{
				if(formMalFlujo.WindowState==FormWindowState.Minimized)
					formMalFlujo.WindowState = FormWindowState.Normal;
				else
					formMalFlujo.BringToFront();
			}
			else
			{
				formMalFlujo = new Interfaz.Nomina.Especiales.FormMalFlujo(this);
				this.formMalFlujo.BringToFront();
				this.formMalFlujo.Show();
				formMalFlujo.MdiParent=this;
				formMalFlujo.Show();
				this.revisionMalFlujo=true;
			}
		}
	
		#endregion	
		
		#region CONTRATO
		public void getInterfazContratoClick(Interfaz.FormPrincipal principal)
		{
			if(this.datoContrato==true)
			{
				if(formDatoContrato.WindowState==FormWindowState.Minimized)
					formDatoContrato.WindowState = FormWindowState.Maximized;
				else
					formDatoContrato.BringToFront();
			}
			else
			{
				string idOperador=formContrato.dataFaltante[0,formContrato.dataFaltante.CurrentRow.Index].Value.ToString();
				formDatoContrato=new Interfaz.Contrato.FormDatoContrato(principal, idOperador);
				formDatoContrato.WindowState = FormWindowState.Maximized;
				formDatoContrato.Show();
				formDatoContrato.MdiParent=principal;
				datoContrato=true;	
			}
		}
		
		#endregion
		
		#region NOMINA
		void ReporteRutasNominalToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.reporten == true){
				if(formReporteN.WindowState==FormWindowState.Minimized)
					formReporteN.WindowState = FormWindowState.Maximized;
				else
					formReporteN.BringToFront();
			}else{
				this.formReporteN = new Transportes_LAR.Interfaz.Nomina.FormReporteNomina(this);
				formReporteN.BringToFront();
				formReporteN.WindowState = FormWindowState.Maximized;
				this.formReporteN.Show();
				this.formReporteN.MdiParent = this;
				this.reporten=true;
			}
		}
		
		void MenuNominaClick(object sender, EventArgs e)
		{
			if(this.nomina==true)
			{
				if(formNomina.WindowState==FormWindowState.Minimized)
					formNomina.WindowState = FormWindowState.Maximized;
				else
					formNomina.BringToFront();
			}
			else
			{
				this.formNomina=new Transportes_LAR.Interfaz.Nomina.FormNomina(this, idUsuario.ToString());
				this.formNomina.BringToFront();
				this.formNomina.WindowState = FormWindowState.Maximized;
				this.formNomina.Show();
				this.formNomina.MdiParent=this;
				this.nomina=true;
			}
		}
		
		void MenuIncapacidadClick(object sender, EventArgs e)
		{
			if(this.incapacidad==true)
			{
				if(formincapacidad.WindowState==FormWindowState.Minimized)
					formincapacidad.WindowState = FormWindowState.Normal;
				else
					formincapacidad.BringToFront();
			}
			else
			{
				this.formincapacidad=new Transportes_LAR.Interfaz.Incapacidad.FormIncapacidades(this);
				this.formincapacidad.BringToFront();
				this.formincapacidad.Show();
				this.formincapacidad.MdiParent=this;
				this.incapacidad=true;
			}
		}
		void MenuControlDescuentosClick(object sender, EventArgs e)
		{
			if(this.anticipos==true)
			{
				if(formPrinAnticipo.WindowState==FormWindowState.Minimized)
					formPrinAnticipo.WindowState = FormWindowState.Maximized;
				else
					formPrinAnticipo.BringToFront();
			}
			else
			{
				this.formPrinAnticipo = new Transportes_LAR.Interfaz.Nomina.Anticipos.FormPrincAnticipos(this, idUsuario.ToString());
				this.formPrinAnticipo.WindowState = FormWindowState.Maximized;
				this.formPrinAnticipo.BringToFront();
				this.formPrinAnticipo.Show();
				this.formPrinAnticipo.MdiParent=this;
				this.anticipos=true;
			}
		}
		
		void MenuBonoClick(object sender, EventArgs e)
		{
			if(this.bonos==true)
			{
				if(formBonos.WindowState==FormWindowState.Minimized)
					formBonos.WindowState = FormWindowState.Maximized;
				else
					formBonos.BringToFront();
			}
			else
			{
				formBonos=new Interfaz.Nomina.Bono.FormBonos(this, idUsuario.ToString());
				formBonos.WindowState = FormWindowState.Normal;
				formBonos.Show();
				formBonos.BringToFront();
				formBonos.MdiParent=this;
				bonos=true;	
			}
		}
		
		void MenuSueldoOperadorClick(object sender, EventArgs e)
		{
			if(this.sueldosbool==true)
			{
				if(formSueldos.WindowState==FormWindowState.Minimized)
					formSueldos.WindowState = FormWindowState.Maximized;
				else
					formSueldos.BringToFront();
			}
			else
			{
				this.formSueldos=new Transportes_LAR.Interfaz.Nomina.Recibo.FormSueldos(this, "OPERADOR");
				this.formSueldos.WindowState = FormWindowState.Maximized;
				this.formSueldos.BringToFront();
				this.formSueldos.Show();
				this.formSueldos.MdiParent=this;
				this.sueldosbool=true;
			}
		}
		
		void MenuSueldoAdministrativoClick(object sender, EventArgs e)
		{
			if(this.sueldosbool==true)
			{
				if(formSueldos.WindowState==FormWindowState.Minimized)
					formSueldos.WindowState = FormWindowState.Maximized;
				else
					formSueldos.BringToFront();
			}
			else
			{
				this.formSueldos=new Transportes_LAR.Interfaz.Nomina.Recibo.FormSueldos(this, "ADMINISTRATIVO");
				this.formSueldos.WindowState = FormWindowState.Maximized;
				this.formSueldos.BringToFront();
				this.formSueldos.Show();
				this.formSueldos.MdiParent=this;
				this.sueldosbool=true;
			}
		}
		
				void MenuTaxiClick(object sender, EventArgs e)
		{
			if(this.taxi==true)
			{
				if(formtaxi.WindowState==FormWindowState.Minimized)
					formtaxi.WindowState = FormWindowState.Normal;
				else
					formtaxi.BringToFront();
			}
			else
			{
				this.formtaxi = new Transportes_LAR.Interfaz.Nomina.Anticipos.FormTaxi(this, idUsuario.ToString());
				this.formtaxi.WindowState = FormWindowState.Maximized;
				this.formtaxi.BringToFront();
				this.formtaxi.Show();
				this.formtaxi.MdiParent=this;
				this.taxi=true;
			}
		}
		
		void MenuTelcelClick(object sender, EventArgs e)
		{
			if(this.prestamos==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				formimpuestos=new Interfaz.Nomina.FormImpuestos(this, "Telcel");
				formimpuestos.WindowState = FormWindowState.Maximized;
				formimpuestos.MdiParent = this;
				formimpuestos.Show();
				formimpuestos.BringToFront();
				this.prestamos=true;
			}
		}
		
		void MenuReporteNominaClick(object sender, EventArgs e)
		{
			if(this.reportenomina==true)
			{
				if(formReporteNomina.WindowState==FormWindowState.Minimized)
					formReporteNomina.WindowState = FormWindowState.Normal;
				else
					formReporteNomina.BringToFront();
			}
			else
			{
				this.formReporteNomina = new Transportes_LAR.Interfaz.Reportes.FormReporteNomina(this);
				this.formReporteNomina.BringToFront();
				this.formReporteNomina.Show();
				this.formReporteNomina.MdiParent=this;
				this.reportenomina=true;
			}
		}
		
		void MenuImporteNominaClick(object sender, EventArgs e)
		{
			this.formImportes = new Interfaz.Nomina.FormImportes(this);
			this.formImportes.WindowState = FormWindowState.Maximized;
			this.formImportes.MdiParent = this;
			this.formImportes.Show();
			this.formImportes.BringToFront();
		}	
		#endregion
		
		#region PROGRESSBAR
		public void ProgresoBar()
		{
			progressbarPrin.Visible = true;
    		progressbarPrin.Minimum = 1;
    		progressbarPrin.Maximum = 100;	
    		for (int x = 1; x <= progressbarPrin.Maximum; x++)
    			{
   					progressbarPrin.Increment(x);Thread.Sleep(1);
    			}
   					progressbarPrin.Value = progressbarPrin.Minimum;
		}
		
		public void ProgresoBarOperaciones(String turn, String fecha)
		{
			if(this.prinEmpresas==false)
			{
				this.formPrincEmp=new Transportes_LAR.Interfaz.Operaciones.FormPrin_Empresas(turn, this, fecha);
				this.formPrincEmp.Show();
				this.formPrincEmp.WindowState = FormWindowState.Normal;
				this.formPrincEmp.MdiParent=this;
				this.formPrincEmp.Location = new System.Drawing.Point(0,0);
				this.formPrincEmp.MaximizeBox = false;
				this.prinEmpresas=true;
			}	
		}
		#endregion
		
		//********************************** Logica Operaciones ***************************************
		
		#region OPERACIONES
		public String AliasOperador="";
		public Interfaz.Operaciones.FormOperacionesOperador datosOpAsi=null;
		public int RutaDatagris=-1;
		public String Empresa="";
		public int sent;
		public String guardia="";
		
		public System.Collections.Generic.List<Transportes_LAR.Interfaz.Operaciones.FormOperacionesOperador> RefOperadoresPrinc;
		public System.Collections.Generic.List<Transportes_LAR.Interfaz.Operaciones.FormEmpresasOperaciones> refEmpresasPrinc;
		
		public void datosAsignacion(Interfaz.Operaciones.FormOperacionesOperador datosOp)
		{
			datosOpAsi=datosOp;
		}
		
		public void contandoViajes(int incremento, String alias, String emp, String tipo)
		{
			for(int x=0; x<RefOperadoresPrinc.Count; x++)
			{
				if(RefOperadoresPrinc[x].txtAlias.Text.Equals(alias))
				{
						RefOperadoresPrinc[x].addRuta(incremento, emp);
						if(tipo=="C")
							RefOperadoresPrinc[x].envioDatos();
				}
			}
			if(tipo=="A")
				AliasOperador="";
		}
		
		public void apoyoDes(int incremento, int id, String emp, String tipo)
		{
			for(int x=0; x<RefOperadoresPrinc.Count; x++)
			{
				if(RefOperadoresPrinc[x].ID_OPERADOR.Equals(id))
				{
					RefOperadoresPrinc[x].addRuta(incremento, emp);
				}
			}
			if(tipo=="A")
				AliasOperador="";
		}
		
		public void asignandoViaje(String name)
		{
			for(int x=0; x<refEmpresasPrinc.Count; x++)
			{
				if(refEmpresasPrinc[x].lblNombreEmp.Text==Empresa)
				{
					refEmpresasPrinc[x].rutaOperador(sent,name,RutaDatagris);
				}
			}
			Empresa="";
			RutaDatagris=-1;
			sent=0;
		}
		
		public void imprimirDespacho()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			
			for(int x=0; x<formPrincEmp.refMOV.Count; x++)
			{
				if(formPrincEmp.refMOV[x].dtgEmpresas.Rows.Count>0)
				{
					++i;
					ExcelApp.Cells[i,  1] = formPrincEmp.refMOV[x].lblNombreEmp.Text;
					++i;
					ExcelApp.Cells[i,  1] = "Entradas";
					ExcelApp.Cells[i,  7] = "Salidas";
					++i;
					ExcelApp.Cells[i,  1] 	= "USUARIOS";
					ExcelApp.Cells[i,  2] 	= "OPERADOR";
					ExcelApp.Cells[i,  3] 	= "HORA";
					ExcelApp.Cells[i,  4] 	= "CONFIRMACION";
					ExcelApp.Cells[i,  5] 	= "RUTA";
					ExcelApp.Cells[i,  6] 	= "LLEGADA";
					ExcelApp.Cells[i,  7] 	= "USUARIOS";
					ExcelApp.Cells[i,  8] 	= "OPERADOR";
					ExcelApp.Cells[i,  9] 	= "HORA";
					ExcelApp.Cells[i,  10] 	= "CONFIRMACION";
					ExcelApp.Cells[i,  11] 	= "RUTA";
					for(int y=0; y<formPrincEmp.refMOV[x].dtgEmpresas.Rows.Count; y++)
					{
						++i;
						if(formPrincEmp.refMOV[x].dtgEmpresas[3,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[11,y].Style.BackColor.Name=="MediumSpringGreen")
						{
							ExcelApp.Cells[i,  1] 	= formPrincEmp.refMOV[x].dtgEmpresas[0,y].Value.ToString();
							ExcelApp.Cells[i,  2] 	= formPrincEmp.refMOV[x].dtgEmpresas[3,y].Value.ToString();
							ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							ExcelApp.Cells[i,  4] 	= formPrincEmp.refMOV[x].dtgEmpresas[5,y].Value.ToString();
							ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							ExcelApp.Cells[i,  6] 	= formPrincEmp.refMOV[x].dtgEmpresas[7,y].Value.ToString();
							ExcelApp.Cells[i,  7] 	= formPrincEmp.refMOV[x].dtgEmpresas[9,y].Value.ToString();
							ExcelApp.Cells[i,  8] 	= formPrincEmp.refMOV[x].dtgEmpresas[11,y].Value.ToString();
							ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							ExcelApp.Cells[i,  10] 	= formPrincEmp.refMOV[x].dtgEmpresas[13,y].Value.ToString();
							ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[3,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()!="")
						{
							ExcelApp.Cells[i,  1] 	= formPrincEmp.refMOV[x].dtgEmpresas[0,y].Value.ToString();
							ExcelApp.Cells[i,  2] 	= formPrincEmp.refMOV[x].dtgEmpresas[3,y].Value.ToString();
							ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							ExcelApp.Cells[i,  4] 	= formPrincEmp.refMOV[x].dtgEmpresas[5,y].Value.ToString();
							ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							ExcelApp.Cells[i,  6] 	= formPrincEmp.refMOV[x].dtgEmpresas[7,y].Value.ToString();
							ExcelApp.Cells[i,  7] 	= "0";
							ExcelApp.Cells[i,  8] 	= " ";
							ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							ExcelApp.Cells[i,  10] 	= " ";
							ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[11,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()!="")
						{
							ExcelApp.Cells[i,  1] 	= "0";
							ExcelApp.Cells[i,  2] 	= " ";
							ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							ExcelApp.Cells[i,  4] 	= " ";
							ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							ExcelApp.Cells[i,  6] 	= " ";
							ExcelApp.Cells[i,  7] 	= formPrincEmp.refMOV[x].dtgEmpresas[9,y].Value.ToString();
							ExcelApp.Cells[i,  8] 	= formPrincEmp.refMOV[x].dtgEmpresas[11,y].Value.ToString();
							ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							ExcelApp.Cells[i,  10] 	= formPrincEmp.refMOV[x].dtgEmpresas[13,y].Value.ToString();
							ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[3,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()=="")
						{
							ExcelApp.Cells[i,  1] 	= formPrincEmp.refMOV[x].dtgEmpresas[0,y].Value.ToString();
							ExcelApp.Cells[i,  2] 	= formPrincEmp.refMOV[x].dtgEmpresas[3,y].Value.ToString();
							ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							ExcelApp.Cells[i,  4] 	= formPrincEmp.refMOV[x].dtgEmpresas[5,y].Value.ToString();
							ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							ExcelApp.Cells[i,  6] 	= formPrincEmp.refMOV[x].dtgEmpresas[7,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[11,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()=="")
						{
							ExcelApp.Cells[i,  7] 	= formPrincEmp.refMOV[x].dtgEmpresas[9,y].Value.ToString();
							ExcelApp.Cells[i,  8] 	= formPrincEmp.refMOV[x].dtgEmpresas[11,y].Value.ToString();
							ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							ExcelApp.Cells[i,  10] 	= formPrincEmp.refMOV[x].dtgEmpresas[13,y].Value.ToString();
							ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()!="" && formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()!="")
						{
							ExcelApp.Cells[i,  1] 	= "0";
							ExcelApp.Cells[i,  2] 	= " ";
							ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							ExcelApp.Cells[i,  4] 	= " ";
							ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							ExcelApp.Cells[i,  6] 	= " ";
							ExcelApp.Cells[i,  7] 	= "0";
							ExcelApp.Cells[i,  8] 	= " ";
							ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							ExcelApp.Cells[i,  10] 	= " ";
							ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()!="")
						{
							ExcelApp.Cells[i,  1] 	= "0";
							ExcelApp.Cells[i,  2] 	= " ";
							ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							ExcelApp.Cells[i,  4] 	= " ";
							ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							ExcelApp.Cells[i,  6] 	= " ";
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()!="")
						{
							ExcelApp.Cells[i,  7] 	= "0";
							ExcelApp.Cells[i,  8] 	= " ";
							ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							ExcelApp.Cells[i,  10] 	= " ";
							ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
					}
				}
			}
			
			// ---------- cuadro de dialogo para Guardar
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Despacho "+"("+formPrincEmp.lblTurno.Text+")"+formPrincEmp.lblDia.Text.Substring(0,2)+"-"+formPrincEmp.lblDia.Text.Substring(3,2)+"-"+formPrincEmp.lblDia.Text.Substring(6,4);
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
				MessageBox.Show("No Genero el Reporte ... ");
		}
		
		public void seleccionOperador(String  alias)
		{
			int bandera=0;
			for(int x=0; x<RefOperadoresPrinc.Count; x++)
			{
				if(RefOperadoresPrinc[x].txtAlias.Text.Equals(alias))
				{
					RefOperadoresPrinc[x].selecOpe();
					//RefOperadoresPrinc[x].txtAlias.BackColor=Color.DodgerBlue;
					bandera=1;
				}
			}
			
			if(bandera==0)
				MessageBox.Show("No se encuentra");
		}
		
		void MenuMensajesDespachoClick(object sender, EventArgs e)
		{
			if(this.mensajeDes==true)
			{
				if(formRecados.WindowState==FormWindowState.Minimized)
					formRecados.WindowState = FormWindowState.Normal;
				else
					formRecados.BringToFront();
			}
			else
			{
				this.formRecados=new Transportes_LAR.Interfaz.Operaciones.Despacho.FormProgramaRecados(this);
				this.formRecados.Show();
				this.formRecados.MaximizeBox = false;
				this.formRecados.MdiParent=this;
				this.mensajeDes=true;
			}
		}
		
		void MenuDespachoClick(object sender, EventArgs e)
		{
			getFormTurno();
		}

		public void getFormTablasOperadores (String turno, String fecha) 
		{
			if(this.prinOperador==true)
			{
				if(formListaOperador.WindowState==FormWindowState.Minimized)
					formListaOperador.WindowState = FormWindowState.Normal;
				else
					formListaOperador.BringToFront();
			}
			else
			{
				Turno=turno;
				Fecha=fecha;
				this.formListaOperador=new Transportes_LAR.Interfaz.Operaciones.FormOperadores(this, fecha, turno);
				this.formListaOperador.Show();
				this.formListaOperador.MaximizeBox = false;
				this.formListaOperador.MdiParent=this;
				this.prinOperador=true;
			}
		}
		
		private void getFormTurno()
		{
			if(this.turno==true)
			{
				if(formTurno.WindowState==FormWindowState.Minimized)
					formTurno.WindowState = FormWindowState.Normal;
				else
					formTurno.BringToFront();
			}
			else
			{
				this.formTurno = new Transportes_LAR.Interfaz.Operaciones.Turno(this);
				this.formTurno.WindowState = FormWindowState.Normal;
				this.formTurno.Show();
				this.formTurno.MaximizeBox = false;
				this.formTurno.MdiParent = this;
				this.turno = true;
			}
			
		}
		
		public void princOperaciones(String turn, String fecha)
		{
			if(this.prinEmpresas==false)
			{
				this.formPrincEmp=new Transportes_LAR.Interfaz.Operaciones.FormPrin_Empresas(turn, this, fecha);
				this.formPrincEmp.Show();
				this.formPrincEmp.WindowState = FormWindowState.Normal;
				this.formPrincEmp.MdiParent=this;
				this.formPrincEmp.Location = new System.Drawing.Point(0,0);
				this.prinEmpresas=true;
			}
			else
			{
				if(formPrincEmp.WindowState==FormWindowState.Minimized)
					formPrincEmp.WindowState = FormWindowState.Normal;
				else
					formPrincEmp.BringToFront();
			}
		}
		
		void ReporteViajesToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(this.reporteCuadreDespacho==true)
			{
				if(formReporteCuadreDespacho.WindowState == FormWindowState.Minimized)
					formReporteCuadreDespacho.WindowState = FormWindowState.Normal;
				else
					formReporteCuadreDespacho.BringToFront();
			}
			else
			{
				formReporteCuadreDespacho = new Interfaz.Reportes.FormReporteViajesDespacho(this);
				this.formReporteCuadreDespacho.BringToFront();
				this.formReporteCuadreDespacho.Show();
				formReporteCuadreDespacho.MdiParent=this;
				formReporteCuadreDespacho.Show();
				formReporteCuadreDespacho.WindowState=FormWindowState.Maximized;
				this.reporteCuadreDespacho = true;
			}		
		}
		
		void PasajerosToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.pasajeros == true){
				if(formPasajero.WindowState == FormWindowState.Minimized)
					formPasajero.WindowState = FormWindowState.Normal;
				else
					formPasajero.BringToFront();
			}else{
				formPasajero = new Interfaz.Operaciones.FormPasajeros(this);
				this.formPasajero.BringToFront();
				//this.formPasajero.Show();
				formPasajero.MdiParent = this;
				formPasajero.Show();
				this.pasajeros = true;
			}
		}
		
		// *********************************************************************************************
		void TsbDespachoClick(object sender, EventArgs e)
		{
			getFormTurno();
		}
		#endregion
		
		//********************************** ****************** ***************************************
		
		#region MANTENIMIENTO
		void MenuAlmacenClick(object sender, EventArgs e)
		{
			if(this.almacen==true)
			{
				if(formalmacen.WindowState==FormWindowState.Minimized)
					formalmacen.WindowState = FormWindowState.Maximized;
				else
					formalmacen.BringToFront();
			}
			else
			{
				this.formalmacen = new Transportes_LAR.Interfaz.Mantenimiento.FormAlmacen(this);
				this.formalmacen.WindowState = FormWindowState.Maximized;
				this.formalmacen.BringToFront();
				this.formalmacen.Show();
				this.formalmacen.MdiParent=this;
				this.almacen=true;
			}
		}
		
		void MenuESVehiculosClick(object sender, EventArgs e)
		{
			if(this.esVehiculos==true)
			{
				if(formESVehiculos.WindowState==FormWindowState.Minimized)
					formESVehiculos.WindowState = FormWindowState.Maximized;
				else
					formESVehiculos.BringToFront();
			}
			else
			{
				this.formESVehiculos = new Transportes_LAR.Interfaz.Mantenimiento.FormESvehiculos(this, idUsuario.ToString());
				this.formESVehiculos.WindowState = FormWindowState.Maximized;
				this.formESVehiculos.BringToFront();
				this.formESVehiculos.Show();
				this.formESVehiculos.MdiParent=this;
				this.esVehiculos=true;
			}
		}
		
		
		void MenuOrdenTrabajoClick(object sender, EventArgs e)
		{
			if(this.ordentrabajo==true)
			{
				if(formordentrabajo.WindowState==FormWindowState.Minimized)
					formordentrabajo.WindowState = FormWindowState.Normal;
				else
					formordentrabajo.BringToFront();
			}
			else
			{
				this.formordentrabajo = new Transportes_LAR.Interfaz.Mantenimiento.FormOrdenTrabajo(this);
				this.formordentrabajo.BringToFront();
				this.formordentrabajo.Show();
				this.formordentrabajo.MdiParent = this;
				this.ordentrabajo = true;
			}
		}
		
		void MenuMantenimientosClick(object sender, EventArgs e)
		{
			
		}
		
		void EntregaYRecepciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.estadoUnidad==true)
			{
				if(formEstUni.WindowState==FormWindowState.Minimized)
					formEstUni.WindowState = FormWindowState.Maximized;
				else
					formEstUni.BringToFront();
			}
			else
			{
				this.formEstUni = new Transportes_LAR.Interfaz.Mantenimiento.FormEstadoUnidad(this);
				this.formEstUni.WindowState = FormWindowState.Maximized;
				this.formEstUni.BringToFront();
				this.formEstUni.Show();
				this.formEstUni.MdiParent=this;
				this.estadoUnidad=true;
			}
		}
		#endregion
		
		#region FACTURACION
		void MenuFacturacionClick(object sender, EventArgs e)
		{
			if(this.Factura==true)
			{
				if(formFacturacion.WindowState==FormWindowState.Minimized)
					formFacturacion.WindowState = FormWindowState.Maximized;
				else
					formFacturacion.BringToFront();
			}
			else
			{
				formFacturacion=new Interfaz.Facturacion.FormFacturacion(this);
				formFacturacion.WindowState = FormWindowState.Maximized;
				formFacturacion.Show();
				formFacturacion.BringToFront();
				formFacturacion.MdiParent=this;
				Factura=true;	
			}
		}
		
		void MenuEspecialPendienteClick(object sender, EventArgs e)
		{
			if(this.EspecialesPendientes==true)
			{
				if(formPendientes.WindowState==FormWindowState.Minimized)
					formPendientes.WindowState = FormWindowState.Normal;
				else
					formPendientes.BringToFront();
			}
			else
			{
				this.formPendientes = new Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas.FormPendientes(this);
				this.formPendientes.BringToFront();
				this.formPendientes.Show();
				this.formPendientes.MdiParent = this;
				this.EspecialesPendientes = true;
			}
		}
				
		void MenuReporteFacturacionClick(object sender, EventArgs e)
		{
			if(this.facturaEspeciales==true)
			{
				if(formFact.WindowState==FormWindowState.Minimized)
					formFact.WindowState = FormWindowState.Maximized;
				else
					formFact.BringToFront();
			}
			else
			{
			Interfaz.Libro.FormFacturaEsp formFact = new Transportes_LAR.Interfaz.Libro.FormFacturaEsp();
			formFact.WindowState = FormWindowState.Maximized;
			formFact.MdiParent = this;
			formFact.Show();
			}
		}
		
		void MenuFacturaHennigesClick(object sender, EventArgs e)
		{
			if(this.Facturahnn==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				formFacthenn = new Interfaz.Facturacion.FormFactHenniges(this);
				formFacthenn.WindowState = FormWindowState.Maximized;
				formFacthenn.MdiParent = this;
				formFacthenn.Show();
				formFacthenn.BringToFront();
				this.Facturahnn = true;
			}
		}
		
		void MenuCostoRutaFacturaClick(object sender, EventArgs e)
		{
			if(this.costofactura==true)
			{
				if(formCostoFactura.WindowState==FormWindowState.Minimized)
					formCostoFactura.WindowState = FormWindowState.Normal;
				else
					formCostoFactura.BringToFront();
			}
			else
			{
				this.formCostoFactura = new Transportes_LAR.Interfaz.Facturacion.FormCobroFactura(this);
				this.formCostoFactura.BringToFront();
				this.formCostoFactura.Show();
				this.formCostoFactura.MdiParent=this;
				this.costofactura=true;
			}
		}
		
		void PreciosFacturaciónToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(this.preciosFacturacion == true)
			{
				if(formPreciosF.WindowState==FormWindowState.Minimized)
					formPreciosF.WindowState = FormWindowState.Maximized;
				else
					formPreciosF.BringToFront();
			}
			else
			{
				this.formPreciosF = new Transportes_LAR.Interfaz.Facturacion.FormPreciosF(this, idUsuario);
				this.formPreciosF.Show();
				this.formPreciosF.MdiParent = this;
				this.formPreciosF.WindowState = FormWindowState.Maximized;
				this.preciosFacturacion = true;
			}
		}
		
		void ControlFactutaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.controlFacturacion == true)
			{
				if(formControlF.WindowState==FormWindowState.Minimized)
					formControlF.WindowState = FormWindowState.Maximized;
				else
					formControlF.BringToFront();
			}
			else
			{
				this.formControlF = new Transportes_LAR.Interfaz.Facturacion.FormControl(this, idUsuario);
				this.formControlF.Show();
				this.formControlF.MdiParent = this;
				this.formControlF.WindowState = FormWindowState.Maximized;
				this.controlFacturacion = true;
			}
		}
		
		#endregion
		
		#region CHECADOR
		void ModuloChecadorClick(object sender, EventArgs e)
		{
			if(this.checador==true)
			{
				if(formChecador.WindowState==FormWindowState.Minimized)
					formChecador.WindowState = FormWindowState.Normal;
				else
					formChecador.BringToFront();
			}
			else
			{
				this.formChecador = new Transportes_LAR.Interfaz.Lector.FormMain(this);
				this.formChecador.BringToFront();
				this.formChecador.Show();
				//this.formChecador.MdiParent=this;
				this.checador=true;
			}
		}
		#endregion
		
		#region CAJA
		void CajaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.PrincipalCaja==true)
			{
				if(formPrincipalCaja.WindowState==FormWindowState.Minimized)
					formPrincipalCaja.WindowState = FormWindowState.Normal;
				else
					formPrincipalCaja.BringToFront();
			}
			else
			{
				this.formPrincipalCaja = new Transportes_LAR.Interfaz.Caja.FormPrincipalCaja(this);
				this.formPrincipalCaja.BringToFront();
				this.formPrincipalCaja.Show();
				this.formPrincipalCaja.MdiParent=this;
				this.PrincipalCaja=true;
			}
		}
		#endregion
		
		#region COMBUSTIBLE
		void PruebaRendimientoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.pruebaRendimiento == true)
			{
				if(formPruebaRendimiento.WindowState == FormWindowState.Minimized)
					formPruebaRendimiento.WindowState = FormWindowState.Normal;
				else
					formPruebaRendimiento.BringToFront();
			}else{
				this.formPruebaRendimiento = new Transportes_LAR.Interfaz.Combustible.FormPruebaRendimiento(this);
				this.formPruebaRendimiento.BringToFront();
				this.formPruebaRendimiento.Show();
				this.formPruebaRendimiento.MdiParent = this;
				this.pruebaRendimiento = true;
			}	
		}
		
		void CombustibleToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.CombustibleReport==true)
			{
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				this.formReportesCombustible = new Transportes_LAR.Interfaz.FormReporteCombustible(this);
				this.formReportesCombustible.BringToFront();
				this.formReportesCombustible.Show();
				this.formReportesCombustible.MdiParent=this;
				this.CombustibleReport=true;
			}
		}
		
		void MenuPrincipalCombustibleClick(object sender, System.EventArgs e)
		{
			if(this.combustible==true)
			{
				if(formprinCombustible.WindowState==FormWindowState.Minimized)
					formprinCombustible.WindowState = FormWindowState.Maximized;
				else
					formprinCombustible.BringToFront();
			}
			else
			{
				formprinCombustible = new Interfaz.Combustible.formPrincipalComb(this);
				this.formprinCombustible.BringToFront();
				this.formprinCombustible.WindowState = FormWindowState.Maximized;
				this.formprinCombustible.Show();
				formprinCombustible.MdiParent=this;
				//formprinCombustible.Show();
				this.combustible=true;				
			}
		}
		
		void MenuExtrasCombClick(object sender, EventArgs e)
		{
			this.formComOperaciones = new Transportes_LAR.Interfaz.Combustible.FormCombOperaciones(this);
			this.formComOperaciones.WindowState = FormWindowState.Normal;
			this.formComOperaciones.BringToFront();
			this.formComOperaciones.Show();
			this.formComOperaciones.MdiParent=this;
		}
		
		void ComplementosToolStripMenuItemClick(object sender, EventArgs e)
		{
			formCompComb = new Interfaz.Combustible.FormCompCombustible(this);
			formCompComb.ShowDialog();
		}
		
		void MenuCombustibleComplementosClick(object sender, System.EventArgs e)
		{
			new Interfaz.Combustible.FormCompCombustible(this).ShowDialog();
		}
		
			
		void ValidarOperacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.validacionOpeCombustible==true)
			{
				if(formValidacionOperaciones.WindowState==FormWindowState.Minimized)
					formValidacionOperaciones.WindowState = FormWindowState.Normal;
				else
					formValidacionOperaciones.BringToFront();
			}
			else
			{
				formValidacionOperaciones = new Interfaz.Combustible.FormValidacionOperaciones(this);
				this.formValidacionOperaciones.BringToFront();
				this.formValidacionOperaciones.Show();
				formValidacionOperaciones.MdiParent=this;
				formValidacionOperaciones.Show();
				this.validacionOpeCombustible=true;
			}
		}
		
		void MenuDatosCombClick(object sender, EventArgs e)
		{
			this.formdatoscomb = new Transportes_LAR.Interfaz.Combustible.EasyTrack.FormDatos(this);
			this.formdatoscomb.WindowState = FormWindowState.Normal;
			this.formdatoscomb.BringToFront();
			this.formdatoscomb.Show();
			this.formdatoscomb.MdiParent=this;
		}		
		
		void RevisiónDePlacasToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.placasRevision == true){
				if(formPlacasRevision.WindowState == FormWindowState.Minimized)
					formPlacasRevision.WindowState = FormWindowState.Normal;
				else
					formPlacasRevision.BringToFront();
			}else{
				this.formPlacasRevision = new Transportes_LAR.Interfaz.Unidad.FormPlacasRevision(this);
				formPlacasRevision.BringToFront();
				this.formPlacasRevision.Show();
				this.formPlacasRevision.MdiParent = this;
				this.placasRevision = true;
			}
		}
		#endregion
		
		#region SOFTWARE EXTRA
		void ToolUnirClick(object sender, EventArgs e)
		{
			try{
			System.Diagnostics.Process.Start("Unir.exe");
			}catch{}
		}
		
		void InstalarAdobeToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
			System.Diagnostics.Process.Start("Adobe.exe");
			}catch{}
		}
		
		void MenuConsultaClick(object sender, EventArgs e)
		{
			if(this.Consulta==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				formconsulta = new Interfaz.Consultas.FormConsultas(this);
				formconsulta.WindowState = FormWindowState.Maximized;
				formconsulta.MdiParent = this;
				formconsulta.Show();
				formconsulta.BringToFront();
				this.Consulta=true;
			}
		}
		
		void MenuGraficoClick(object sender, EventArgs e)
		{
			try{
			System.Diagnostics.Process.Start("MSChart.exe");
			}catch{}
		}
		#endregion
		
		#region GET - BAJAS
		public void getBajas()
		{
			Interfaz.Reportes.FormAvisoBajas bajas = new Transportes_LAR.Interfaz.Reportes.FormAvisoBajas(this);
			bajas.getFechas();
			bajas.ShowDialog();
		}
		#endregion
		
		#region REPORTES
		void AltasBajaOperadorToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.ABOperador == true)
			{
				if(ReporteGerencial.WindowState==FormWindowState.Minimized)
					formABOperador.WindowState = FormWindowState.Normal;
				else
					formABOperador.BringToFront();
			}else{
				this.formABOperador = new Transportes_LAR.Interfaz.Reportes.FormReportesAltaBajaOperador(this);
				this.formABOperador.BringToFront();
				this.formABOperador.Show();
				this.formABOperador.MdiParent = this;
				this.ABOperador = true;
			}		
		}
		
		void ViajesPorOperadorToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.viajesOpe == true)
			{
				if(ViajesOperador.WindowState==FormWindowState.Minimized)
					ViajesOperador.WindowState = FormWindowState.Normal;
				else
					ViajesOperador.BringToFront();
			}else{
				this.ViajesOperador = new Transportes_LAR.Interfaz.Reportes.FormViajesOperador(this);
				this.ViajesOperador.BringToFront();
				this.ViajesOperador.Show();
				this.ViajesOperador.MdiParent = this;
				ViajesOperador.WindowState = FormWindowState.Maximized;
				this.viajesOpe = true;
			}		
		}
		
		void MenuReporteGerencialClick(object sender, EventArgs e)
		{
			if(this.reportegerencial==true)
			{
				if(ReporteGerencial.WindowState==FormWindowState.Minimized)
					ReporteGerencial.WindowState = FormWindowState.Normal;
				else
					ReporteGerencial.BringToFront();
			}
			else
			{
				this.ReporteGerencial = new Transportes_LAR.Interfaz.Reportes.FormReporteGerencial(this);
				this.ReporteGerencial.BringToFront();
				this.ReporteGerencial.Show();
				this.ReporteGerencial.MdiParent=this;
				this.reportegerencial=true;
			}
		}
		
		void HorariosRutasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Transportes_LAR.Interfaz.Reportes.FormReporteRutas formRutas  = new Transportes_LAR.Interfaz.Reportes.FormReporteRutas(this);
            formRutas.BringToFront();
            formRutas.Show();
            formRutas.MdiParent = this;
		}		
		
		void HorarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.reporteRutaExtra==true)
			{
				if(formRutasExtra.WindowState==FormWindowState.Minimized)
					formRutasExtra.WindowState = FormWindowState.Normal;
				else
					formRutasExtra.BringToFront();
			}
			else
			{
				formRutasExtra = new Interfaz.Reportes.FormReporteRutasExtras(this);
				this.formRutasExtra.BringToFront();
				this.formRutasExtra.Show();
				formRutasExtra.MdiParent=this;
				formRutasExtra.Show();
				this.reporteRutaExtra=true;
			}
			
			//Transportes_LAR.Interfaz.Reportes.FormReporteRutasExtras formRutasExtra  = new Transportes_LAR.Interfaz.Reportes.FormReporteRutasExtras();
            //formRutasExtra.BringToFront();
            //formRutasExtra.Show();
            //formRutasExtra.MdiParent = this;
		}
		
		void MenuReporteOperacionesClick(object sender, EventArgs e)
		{
			this.formReportesOperacion = new Transportes_LAR.Interfaz.Reportes.FormReporteOperaciones(this);
			this.formReportesOperacion.WindowState = FormWindowState.Normal;
			this.formReportesOperacion.BringToFront();
			this.formReportesOperacion.Show();
			this.formReportesOperacion.MdiParent=this;
		}
		
		void MenuReporteEspecialesClick(object sender, EventArgs e)
		{
			this.formreporteServicios = new Interfaz.Nomina.Especiales.Finanzas.FormReporte(this);
			this.formreporteServicios.WindowState = FormWindowState.Maximized;
			this.formreporteServicios.BringToFront();
			this.formreporteServicios.Show();
			this.formreporteServicios.MdiParent=this;
			this.reporteServicios=true;
		}	
		
		void MenuReporteBonificaionesClick(object sender, EventArgs e)
		{
			if(this.reporteBonificaciones==true)
			{
				if(formreportesBonificaciones.WindowState==FormWindowState.Minimized)
					formreportesBonificaciones.WindowState = FormWindowState.Normal;
				else
					formreportesBonificaciones.BringToFront();
			}
			else
			{
				this.formreportesBonificaciones = new Transportes_LAR.Interfaz.Reportes.FormReporteBonificaciones(this);
				this.formreportesBonificaciones.BringToFront();
				this.formreportesBonificaciones.Show();
				this.formreportesBonificaciones.MdiParent = this;
				this.EspecialesPendientes = true;
			}
		}
		#endregion
		
		#region PRIVILEGIOS
		void NivelEmpleado()
		{
			if(lblDatoNivel.Text=="ADMINISTRATIVO")
			{
				MenuReporteNomina.Visible=false;
				MenuReporteGerencial.Visible=false;
				MenuOperadorVehiculo.Visible=false;
				tlRuta.Visible=false;
				tlCliente.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuServidor.Visible=false;
				tsbDespacho.Visible=false;
				tsbVentas.Visible=false;
				ModuloCombustible.Visible=false;
				ModuloFacturacion.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuVentas.Visible=false;
				ModuloDespacho.Visible=false;
				tlUsuario.Visible=false;
				MenuReporteEspeciales.Visible=false;
				tlEspeciales.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				MenuBono.Visible=false;
				Menuanticipos.Visible=false;
				MenuReporteCombustible.Visible=false;
				MenuConsulta.Visible=false;
				ModuloChecador.Visible=false;
				ModuloChecador.Visible=false;
				MenuRutas.Visible=false;
				contratacionToolStripMenuItem.Visible = true;
				controlDeLlamadasToolStripMenuItem.Visible = true;
				tsbLlamadaCandidato.Visible = true;
				if(lblDatoUsuario.Text != "PATY" )
					getBajas();
				
				if(lblDatoUsuario.Text == "ELIZONDO" )
					ModuloCombustible.Visible = true;
			}
			if(lblDatoNivel.Text=="NOMINA")
			{
				tlRuta.Visible=false;
				ModuloCombustible.Visible=false;
				MenuDespacho.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuVentas.Visible=false;
				MenuServidor.Visible=false;
				tsbDespacho.Visible=false;
				tsbVentas.Visible=false;
				tlUsuario.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuReporteCombustible.Visible=false;
				MenuConsulta.Visible=false;
				ModuloChecador.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
				getBajas();
			}
			if(lblDatoNivel.Text=="OPERACION")
			{
				MenuAseguradora.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuVentas.Visible=false;
				toolAptoMedico.Visible=false;
				toolLicencia.Visible=false;
				toolContrato.Visible=false;
				toolAptoMedico.Enabled=false;
				toolLicencia.Enabled=false;
				toolContrato.Enabled=false;
				MenuServidor.Visible=false;
				tsbVentas.Visible=false;
				tlUsuario.Visible=false;
				MenuReporteEspeciales.Visible=false;
				tlEspeciales.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				Menuanticipos.Visible=false;
				MenuConsulta.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				tlEmpleado.Visible=false;
				MenuCatalogoEmpresa.Visible=false;
				MenuPrecioFactura.Visible=false;
				tlRuta.Visible=false;
				MenuPrincipalCombustible.Visible=false;
				MenuCombustibleComplementos.Visible=false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				nominaFiscalToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
				
				if(lblDatoUsuario.Text == "CESAR" || lblUsuario.Text == "CESAR"){
					MenuAdministrativo.Visible = false;
					tlEmpleado.Visible = true;
					MenuOperadorExterno.Visible = false;
					MenuPuesto.Visible = false;
					MenuExperienciaLaboral.Visible = false;
					MenuCuentaBancaria.Visible = false;
					agregarOperadorToolStrip.Visible = false;
					rutaOperadorToolStripMenuItem.Visible = false;
				}				
				getBajas();
			}
			if(lblDatoNivel.Text=="COORDINADOR")
			{
				tsbOperadorVehiculo.Visible=false;
				MenuAseguradora.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuVentas.Visible=false;
				toolAptoMedico.Visible=false;
				toolLicencia.Visible=false;
				toolContrato.Visible=false;
				toolAptoMedico.Enabled=false;
				toolLicencia.Enabled=false;
				toolContrato.Enabled=false;
				MenuServidor.Visible=false;
				tsbVentas.Visible=false;
				tlUsuario.Visible=false;
				MenuReporteEspeciales.Visible=false;
				tlEspeciales.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				Menuanticipos.Visible=false;
				MenuConsulta.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				tlEmpleado.Visible=false;
				MenuCatalogoEmpresa.Visible=false;
				ModuloFacturacion.Visible=false;
				tlRuta.Visible=false;
				MenuPrincipalCombustible.Visible=false;
				MenuCombustibleComplementos.Visible=false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				nominaFiscalToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
				getBajas();
			}
			if(lblDatoNivel.Text=="COMBUSTIBLE")
			{
				MenuAseguradora.Visible=false;
				tlEmpleado.Visible=false;
				tlRuta.Visible=false;
				tlCliente.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				ModuloFacturacion.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuVentas.Visible=false;
				toolAptoMedico.Visible=false;
				toolLicencia.Visible=false;
				toolContrato.Visible=false;
				toolAptoMedico.Enabled=false;
				toolLicencia.Enabled=false;
				toolContrato.Enabled=false;
				MenuServidor.Visible=false;
				tsbVentas.Visible=false;
				tlUsuario.Visible=false;
				MenuReporteEspeciales.Visible=false;
				tlEspeciales.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				MenuConsulta.Visible=false;
				ModuloChecador.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				nominaFiscalToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
			}
			if(lblDatoNivel.Text=="MANTENIMIENTO")
			{
				MenuReporteGerencial.Visible=false;
				MenuVehiculo.Visible=false;
				tlEmpleado.Visible=false;
				tlRuta.Visible=false;
				tlCliente.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				//ModuloCombustible.Visible=false;
				ModuloDespacho.Visible=false;
				ModuloFacturacion.Visible=false;
				MenuVentas.Visible=false;
				toolAptoMedico.Visible=false;
				toolLicencia.Visible=false;
				toolContrato.Visible=false;
				toolAptoMedico.Enabled=false;
				toolLicencia.Enabled=false;
				toolContrato.Enabled=false;
				MenuServidor.Visible=false;
				tsbDespacho.Visible=false;
				tsbVentas.Visible=false;
				tlUsuario.Visible=false;
				MenuReporteEspeciales.Visible=false;
				tlEspeciales.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				MenuBono.Visible=false;
				Menuanticipos.Visible=false;
				MenuReporteCombustible.Visible=false;
				MenuConsulta.Visible=false;
				ModuloChecador.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				ModuloNomina.Visible=false;
				MenuPrincipalCombustible.Visible=false;
				MenuCombustibleComplementos.Visible=false;
				MenuExtrasComb.Visible=false;
				tsbOperadorVehiculo.Visible=false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				nominaFiscalToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
				ventas2ToolStripMenuItem.Visible = false;
			}
			if(lblDatoNivel.Text=="VENTAS")
			{
				MenuReporteGerencial.Visible=false;
				tlEmpleado.Visible=false;
				tlRuta.Visible=false;
				tlVehiculo.Visible=false;
				tlCliente.Visible=false;
				ModuloCombustible.Visible=false;
				ModuloFacturacion.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				toolAptoMedico.Visible=false;
				toolLicencia.Visible=false;
				toolContrato.Visible=false;
				toolAptoMedico.Enabled=false;
				toolLicencia.Enabled=false;
				toolContrato.Enabled=false;
				MenuServidor.Visible=false;
				tlUsuario.Visible=false;
				tsbOperadorVehiculo.Visible=false;
				MenuReporteEspeciales.Visible=false;
				Menuanticipos.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuBono.Visible=false;
				MenuReporteCombustible.Visible=false;
				MenuConsulta.Visible=true;
				ModuloChecador.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = true;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				nominaFiscalToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = true;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
				
				MenuVentas.Visible=false;
			}
			if(lblDatoNivel.Text=="RECEPCION")
			{
				MenuReporteGerencial.Visible=false;
				tlEmpleado.Visible=false;
				tlRuta.Visible=false;
				tlVehiculo.Visible=false;
				tlCliente.Visible=false;
				ModuloCombustible.Visible=false;
				ModuloFacturacion.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				toolAptoMedico.Visible=false;
				toolLicencia.Visible=false;
				toolContrato.Visible=false;
				toolAptoMedico.Enabled=false;
				toolLicencia.Enabled=false;
				toolContrato.Enabled=false;
				MenuServidor.Visible=false;
				tlUsuario.Visible=false;
				tsbOperadorVehiculo.Visible=false;
				MenuReporteEspeciales.Visible=false;
				Menuanticipos.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuBono.Visible=false;
				MenuReporteCombustible.Visible=false;
				MenuConsulta.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				tlEspeciales.Visible = false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				nominaFiscalToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
			}
			if(lblDatoNivel.Text=="COBRANZA")
			{
				tlEmpleado.Visible=false;
				tlVehiculo.Visible=false;
				MenuIncapacidad.Visible=false;
				tlRuta.Visible=false;
				tlCliente.Visible=false;
				ModuloCombustible.Visible=false;
				ModuloDespacho.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuVentas.Visible=false;
				MenuServidor.Visible=false;
				tsbOperadorVehiculo.Visible=false;
				tsbDespacho.Visible=false;
				tsbVentas.Visible=false;
				tlUsuario.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				MenuBono.Visible=false;
				MenuReporteCombustible.Visible=false;
				MenuPrecioFactura.Visible=false;
				MenuConsulta.Visible=false;
				ModuloChecador.Visible=false;
				MenuReporteNomina.Visible=false;
				ModuloChecador.Visible=false;
				MenuRutas.Visible=false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
				getBajas();
			}
			if(lblDatoNivel.Text=="ENCUESTADOR")
			{
				MenuReporteNomina.Visible=false;
				MenuReporteGerencial.Visible=false;
				MenuOperadorVehiculo.Visible=false;
				tlRuta.Visible=false;
				tlCliente.Visible=false;
				MenuIncapacidad.Visible=false;
				MenuServidor.Visible=false;
				tsbDespacho.Visible=false;
				tsbVentas.Visible=false;
				ModuloCombustible.Visible=false;
				ModuloFacturacion.Visible=false;
				MenuMantenimiento.Visible=false;
				MenuVentas.Visible=false;
				ModuloDespacho.Visible=false;
				tlUsuario.Visible=false;
				MenuReporteEspeciales.Visible=false;
				MenuImporteNomina.Visible=false;
				MenuTelcel.Visible=false;
				MenuPercepcionesDeducciones.Visible=false;
				MenuBono.Visible=false;
				Menuanticipos.Visible=false;
				MenuReporteCombustible.Visible=false;
				MenuConsulta.Visible=false;
				ModuloChecador.Visible=false;
				tlEmpleado.Visible=false;
				tlModulos.Visible=false;
				tlVehiculo.Visible = false;
				tlReportes.Visible =  false;
				MenuReporteFacturacion.Visible=false;
				MenuSueldoEspeciales.Visible =false;
				MenuReporteVentas.Visible = false;
				tsbOperadorVehiculo.Visible=false;
				toolAptoMedico.Visible=false;
				toolLicencia.Visible=false;
				toolContrato.Visible=false;
				MenuRutas.Visible=false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				nominaFiscalToolStripMenuItem.Visible = false;
				cobroEspecialesToolStripMenuItem.Visible = false;
				validaciónEspecialesToolStripMenuItem.Visible = false;
				contratacionToolStripMenuItem.Visible = false;
				controlDeLlamadasToolStripMenuItem.Visible = false;
				tsbLlamadaCandidato.Visible = false;
			}
			if(lblDatoNivel.Text=="GERENCIAL")
			{
				getBajas();
				if(lblDatoUsuario.Text=="GLORIA" || lblDatoUsuario.Text=="VERO"|| lblDatoUsuario.Text=="Xavi" || lblDatoUsuario.Text=="ckarlos")
					MenuCaja.Visible=true;
			}
			if(lblDatoNivel.Text=="MASTER")
			{
				MenuCaja.Visible=true;
				ventas2ToolStripMenuItem.Visible = true;
				MenuPrecioFactura.Visible = true;
				
				if(lblDatoUsuario.Text=="Dario")
					getBajas();
			}
			if(lblDatoUsuario.Text=="VANESSA" || lblDatoUsuario.Text=="LALO")
			{
				revisiónEspecialesToolStripMenuItem.Visible = true;
			}
			
			if(lblDatoUsuario.Text=="GLORIA" || lblDatoUsuario.Text=="XAVI" || lblDatoUsuario.Text=="CKARLOS" ||  lblDatoUsuario.Text=="LALO")
				this.MenuEspecialPendiente.Visible = true;
			else
				this.MenuEspecialPendiente.Visible = false;
		}
		#endregion
		
		#region HORA_UNIVERSAL
		public String HoraUniversal()
		{
			String Hora = "";
			conn.getAbrirConexion("SELECT CONVERT (time, SYSDATETIME()) As Hora");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				Hora = conn.leer["Hora"].ToString().Substring(0,5);
			}
			conn.conexion.Close();
			return Hora;
		}
		#endregion	
		
		#region CHAT		
		void MenuChatClick(object sender, EventArgs e)
		{
			Interfaz.Chat.Cliente Comunicador= new Interfaz.Chat.Cliente(this);
			Comunicador.WindowState = FormWindowState.Normal;
			Comunicador.BringToFront();
			Comunicador.Show();
			Comunicador.MdiParent=this;
			//this.almacen=true;
		}
		#endregion		
			
		#region NUEVO MODULO VENTAS
		void LibroVentasToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.libroviajes2==true)
			{
				if(formViajes2.WindowState==FormWindowState.Minimized)
					formViajes2.WindowState = FormWindowState.Maximized;
				else
					formViajes2.BringToFront();
			}
			else
			{
				this.formViajes2=new Transportes_LAR.Interfaz.Libro_Nuevo.FormLibroViajes(this);
				formViajes2.BringToFront();
				formViajes2.WindowState = FormWindowState.Maximized;
				this.formViajes2.Show();
				this.formViajes2.MdiParent=this;
				this.libroviajes2=true;
			}
		}
		
		void ValidaciónEspecialesToolStripMenuItemClick(object sender, EventArgs e)
		{
 			if(this.validaVentas == true)
			{
				if(formvalidaVentas.WindowState == FormWindowState.Minimized)
					formvalidaVentas.WindowState = FormWindowState.Maximized;
				else
					formvalidaVentas.BringToFront();
			}else{
				this.formvalidaVentas = new Transportes_LAR.Interfaz.Libro_Nuevo.Validacion_Final.FormValidarServicios(this);
				formvalidaVentas.BringToFront();
				formvalidaVentas.WindowState = FormWindowState.Maximized;
				this.formvalidaVentas.Show();
				this.formvalidaVentas.MdiParent=this;
				this.validaVentas=true;
			}
		}
		
		void CobroEspecialesToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.cobroVenta == true)
			{
				if(cobroVentas.WindowState==FormWindowState.Minimized)
					cobroVentas.WindowState = FormWindowState.Maximized;
				else
					cobroVentas.BringToFront();
			}
			else
			{
				this.cobroVentas = new Transportes_LAR.Interfaz.Libro_Nuevo.Pagos.PrivilegiosPagos(this);
				cobroVentas.BringToFront();
				cobroVentas.WindowState = FormWindowState.Maximized;
				this.cobroVentas.Show();
				this.cobroVentas.MdiParent=this;
				this.cobroVenta = true;
			}	
		}
		
		void ReportesToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(this.reportVentas == true)
			{
				if(ReportesVentas.WindowState==FormWindowState.Minimized)
					ReportesVentas.WindowState = FormWindowState.Maximized;
				else
					ReportesVentas.BringToFront();
			}
			else
			{
				this.ReportesVentas = new Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro.FormReportes(this);
				//ReportesVentas.BringToFront();
				this.ReportesVentas.Show();
				this.ReportesVentas.MdiParent=this;
				this.reportVentas = true;
			}	
		}
		
		
		void NominaFiscalToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.nominaF == true)
			{
				if(formNominaFiscal.WindowState==FormWindowState.Minimized)
					formNominaFiscal.WindowState = FormWindowState.Maximized;
				else
					formNominaFiscal.BringToFront();
			}
			else
			{
				this.formNominaFiscal = new Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal.FormNominaFiscal(this, idUsuario);
				formNominaFiscal.BringToFront();
				formNominaFiscal.WindowState = FormWindowState.Maximized;
				this.formNominaFiscal.Show();
				this.formNominaFiscal.MdiParent=this;
				this.nominaF = true;
			}	
		}
		#endregion
		
		#region NOTIFICACIONES
		private void notificaCumpleaños(){
			string nombre = "";
			string aM = "";
			string aP = "";			
			string id_op = "0";
			
			string consulta = "";
			bool respuesta = false;
			
			try{
				consulta = "SELECT LTRIM(RTRIM(nombre)) nombre, LTRIM(RTRIM(apellido_mat)) apellido_mat, LTRIM(RTRIM(Apellido_Pat)) Apellido_Pat FROM usuario WHERE id_usuario ="+idUsuario;
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					nombre = conn.leer["nombre"].ToString().TrimEnd(' ');
					aM = conn.leer["apellido_mat"].ToString().TrimEnd(' ');
					aP = conn.leer["apellido_pat"].ToString().TrimEnd(' ');
					respuesta = true;
				}
				conn.conexion.Close();
				
				if(respuesta){				
					consulta = @"select id, Alias, Fecha_Nacimiento, tipo_empleado from OPERADOR where Estatus = '1' AND Nombre like '%"+nombre+"%' and Apellido_Mat like '%"+aM
					                      +"%' and  Apellido_Pat like '%"+aP+"%'AND day(Fecha_Nacimiento) = '"+DateTime.Now.Day+"' and month(Fecha_Nacimiento) = '"+DateTime.Now.Month
					                      +"' AND ID NOT IN	(select ID_OPERADOR from NOTIFICACIONES_USUARIOS WHERE TIPO = 'CUMPLEAÑOS' AND FECHA = '"+DateTime.Now.ToString("yyyy-MM-dd")+"' AND ESTATUS = '1')";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						id_op = conn.leer["id"].ToString();
					}
					conn.conexion.Close();
					
					if(id_op != "0"){
						formNCumple = new Notificaciones.FormNCumpleanos(id_op, nombreUsuario);
						if ((this.formNCumple != null)) {
						}
						this.formNCumple.ShowDialog();
					}
				}
			}catch(Exception ex){
				MessageBox.Show("Error al felicitar al compañero LAR :"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		#endregion
		
		#region CONTROL
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////// UBER-TAXI /////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
		void UberTaxiToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.ubertaxiExtra == true)
			{
				if(formUberTaxiExtra.WindowState==FormWindowState.Minimized)
					formUberTaxiExtra.WindowState = FormWindowState.Maximized;
				else
					formUberTaxiExtra.BringToFront();
			}
			else
			{
				this.formUberTaxiExtra = new Transportes_LAR.Interfaz.Controles.Uber_Taxi.FormUber_TaxiExtra(this, idUsuario);
				formUberTaxiExtra.BringToFront();
				this.formUberTaxiExtra.Show();
				this.formUberTaxiExtra.MdiParent=this;
				this.ubertaxiExtra = true;
			}
		}
		
		void ReporteUberTaxiToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(this.reporteUT == true)
			{
				if(formReporteUT.WindowState==FormWindowState.Minimized)
					formReporteUT.WindowState = FormWindowState.Maximized;
				else
					formReporteUT.BringToFront();
			}
			else
			{
				this.formReporteUT = new Transportes_LAR.Interfaz.Controles.Uber_Taxi.FormReporteUT(this, idUsuario);
				formReporteUT.BringToFront();
				this.formReporteUT.Show();
				this.formReporteUT.MdiParent=this;
				this.reporteUT = true;
			}
		}
		#endregion
		
		#region SELECCIÓN DE PERSONAL
		void ControlDeLlamadasToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(this.llamadaContratacion == true)
			{
				if(formLlamadaContratacion.WindowState==FormWindowState.Minimized)
					formLlamadaContratacion.WindowState = FormWindowState.Maximized;
				else
					formLlamadaContratacion.BringToFront();
			}
			else
			{
				this.formLlamadaContratacion = new Transportes_LAR.Interfaz.Operador.Pre_Seleccion.FormLlamada(this, idUsuario);
				this.formLlamadaContratacion.Show();
				this.formLlamadaContratacion.MdiParent = this;
				this.llamadaContratacion = true;
			}
		}
		
		void TsbLlamadaCandidatoClick(object sender, EventArgs e)
		{
			if(this.llamadaContratacion == true)
			{
				if(formLlamadaContratacion.WindowState==FormWindowState.Minimized)
					formLlamadaContratacion.WindowState = FormWindowState.Maximized;
				else
					formLlamadaContratacion.BringToFront();
			}
			else
			{
				this.formLlamadaContratacion = new Transportes_LAR.Interfaz.Operador.Pre_Seleccion.FormLlamada(this, idUsuario);
				this.formLlamadaContratacion.Show();
				this.formLlamadaContratacion.MdiParent = this;
				this.llamadaContratacion = true;
			}
		}		
		
		void ControlDeSelecciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			openContratacionesAll();
		}		
				
		void RegistrarCandidatoToolStripMenuItem1Click(object sender, EventArgs e)
		{
			openRegistrar();
		}
		
		public void openRegistrar()
		{
			if(contratacion){
				if(formContratacion.WindowState==FormWindowState.Minimized)
					formContratacion.WindowState = FormWindowState.Maximized;
				else
					formContratacion.BringToFront();
			}else{
				if(this.contratacionRegistrar == true){
					if(formContratacionRegistrar.WindowState==FormWindowState.Minimized)
						formContratacionRegistrar.WindowState = FormWindowState.Maximized;
					else
						formContratacionRegistrar.BringToFront();
				}else{
					this.formContratacionRegistrar = new Transportes_LAR.Interfaz.Operador.Pre_Seleccion.FormRegistar(this, idUsuario);
					this.formContratacionRegistrar.Show();
					this.formContratacionRegistrar.MdiParent = this;
					this.contratacionRegistrar = true;
				}
			}	
		}
				
		public void openContrataciones(Interfaz.Operador.Pre_Seleccion.FormRegistar registrar)
		{
			if(this.contratacion == true){
				if(formContratacion.WindowState==FormWindowState.Minimized)
					formContratacion.WindowState = FormWindowState.Maximized;
				else
					formContratacion.BringToFront();
			}else{
				this.formContratacion = new Transportes_LAR.Interfaz.Operador.Pre_Seleccion.FormContratacion(registrar, this, idUsuario);
				this.formContratacion.Show();
				this.formContratacion.MdiParent = this;
				this.contratacion = true;
			}	
		}	

		public void openContratacionesAll()
		{
			if(this.contratacion == true)
			{
				if(formContratacion.WindowState==FormWindowState.Minimized)
					formContratacion.WindowState = FormWindowState.Maximized;
				else
					formContratacion.BringToFront();
			}
			else
			{
				this.formContratacion = new Transportes_LAR.Interfaz.Operador.Pre_Seleccion.FormContratacion(this, idUsuario);
				this.formContratacion.Show();
				this.formContratacion.MdiParent = this;
				this.contratacion = true;
			}	
		}
		#endregion
		
	}
}
