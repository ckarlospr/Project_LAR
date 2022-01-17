using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro;
using Transportes_LAR.Interfaz.Libro_Nuevo.Pagos;
using Transportes_LAR.Proceso;
using System.Linq.Expressions;
using System.ComponentModel;
using nmExcel = Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Threading;
using iTextSharp.text;
using System.IO;
using System.Collections.Generic;
using NumeroLetras;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Mail;
using System.Net.Mime;

namespace Transportes_LAR.Interfaz.Libro_Nuevo
{
	public partial class FormLibroViajes : Form
	{		
		#region CONSTRUCTOR
		public FormLibroViajes(FormPrincipal refPrincipal)
		{
			InitializeComponent();
			principal = refPrincipal;
		}
		#endregion
		
		#region INSTANCIAS		
		public Interfaz.FormPrincipal principal = null;	
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		private Conexion_Servidor.Desapacho.SQL_Operaciones connD = new Conexion_Servidor.Desapacho.SQL_Operaciones();
		#endregion
		
		#region VARIABLES
		public String ruta_inicio = "";
		private bool validaAdpatadores = true;
		public bool validarAcuerdo = false;
		public bool recuperaFactura = false;
		public bool validarViaje = false;
		public String fechaAcuerdo = "0";		
		String diasemana;
		String Fecha;
		String tipoV = "Camión";
		private String SentidoR="Completo";
		double  precioValidacion;
		int facturaValidacion;
		public int validaCambioFactura = 0;
		public Int32 id_usuario;
		int contadorA = 0; //contador para agregar en la primera pestalla con dos adaptadores
		public int idClienteNuevo = 0;
		public int idCotizacionNuevo = 0;
		public string fecha_facturaV = "";
		public string razon_socialV = "";
		private bool interruptor = false;
		public DataGridView dgMetodoFactura;
		#endregion		
				
		#region VARIABLES PARA VALIDAR MODIFICACIONES
		public bool cambioFlujo = false;		
		public bool modifcarCotizacion = false;
		public bool modifcarViaje = false;
		#endregion		
		
		#region INICIO - FIN
		void FormLibroViajesLoad(object sender, EventArgs e)
		{		
			//enviaAvisoProgramacionPago();
			AvisoValidacion();
			autoCompletar();
			validaCampo();
			cotizacionPendientesA();
			id_usuario = principal.idUsuario;			
						
			cbCompañia.SelectedIndex = 0;
			cbTipo.SelectedIndex = 0;			
			dtpFechaSalida.Value = DateTime.Now;
			dtpHoraSalida.Text = "00:00";
			dtpFechaRegreso.Value = DateTime.Now;
			dtpHoraRegreso.Value = DateTime.Now;	
			dtpFechaFactura.Value = DateTime.Now;
			
			/////////////////////////////////////////////////////////////////// COTIZACIONES ////////////////////////////////////////////////////////////////////
			cbBusquedaCotizacion.SelectedIndex = 3;
			dtpInicioCotizacion.Value = DateTime.Now;
			dtpFinCotizacion.Value = DateTime.Now;
			filtros();
			
			/////////////////////////////////////////////////////////////////// PRE-SERVICIOS ////////////////////////////////////////////////////////////////////
			cbBusquedaPRE.SelectedIndex = 3;
			dtpInicioPRE.Value = DateTime.Now;
			dtpFinPRE.Value = DateTime.Now;			
			filtrosPrincipales();
			
			///////////////////////////////////////////////////////////////// Pestaña IMPRESION /////////////////////////////////////////////////////////////////
			cmbImpresion.SelectedIndex = 3;
			dtpInicioImpresion.Value = DateTime.Now;
			dtpFinImpresion.Value = DateTime.Now;			
			filtrosImprimir();
			
			///////////////////////////////////////////////////////////////// Pestaña VALIDACION /////////////////////////////////////////////////////////////////		
			dtpInicio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;			
			//filtrosValidacion();
			
			///////////////////////////////////////////////////////////// Pestaña ORDEN DE FACTURA ///////////////////////////////////////////////////////////////		
			cmbBusquedaOrdenFactura.SelectedIndex = 3;
			cmbBusquedaSinOrden.SelectedIndex = 3;
			dtpInicioOrdenFactura.Value = DateTime.Now;
			dtpFinOrdenFactura.Value = DateTime.Now;
			dtpInicioSinOrden.Value = DateTime.Now;
			dtpFinSinOrden.Value = DateTime.Now;		
			filtrosSinOrden();
			filtrosOrden();			
			
			///////////////////////////////////////////////////////////////// Pestaña ENCUESTA //////////////////////////////////////////////////////////////////		
			cmbEncuesta.SelectedIndex = 3;
			dtpInicioEncuesta.Value =  DateTime.Now.AddDays(-7);
			dtpFinEncuesta.Value = DateTime.Now;
			//filtrosEncuesta();
			
			
			if(principal.lblDatoNivel.Text=="GERENCIAL" || principal.lblDatoNivel.Text=="MASTER")
				pbConfiguraciones.Visible = true;
			
			validaAdpatadores = false;
		}
		
		void FormLibroViajesFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.libroviajes2 = false;
		}
		#endregion
		
		#region ADAPTADORES
		public void ContizacionesPendientes(String Consulta){	
		string numero;			
			try{
				dgCotizacionesPendientes.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{			
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();						
				
					dgCotizacionesPendientes.Rows.Add(conn.leer["ID"].ToString(),
					                      		conn.leer["FOLIO"].ToString()+numero,
						                        "",
						                        Convert.ToDateTime(conn.leer["FECHA_ACUERDO"].ToString().Substring(0,10)).ToShortDateString(),
									            conn.leer["CONTACTO"].ToString(),
						                        Convert.ToDateTime(conn.leer["FECHA_REGISTRO"].ToString().Substring(0,10)).ToShortDateString(),
						                        Convert.ToDateTime(conn.leer["HORA_REGISTRO"].ToString().Substring(0,5)).ToShortTimeString(),
						                        conn.leer["EVENTO"].ToString(),
						                        conn.leer["CANTIDAD"].ToString(),     
												conn.leer["TIPO_TRANSPOTE"].ToString(),
												conn.leer["ID_USUARIO"].ToString());					
				}
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las cotizaciones pendientes (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}	
			dgCotizacionesPendientes.ClearSelection();
		}
		
		public void ContizacionesRealizadas(String Consulta){
			int contador= 0;
			string numero;			
			try{					
				dgCotizacionesRealizadas.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{				
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();				
				
					dgCotizacionesRealizadas.Rows.Add(conn.leer["ID"].ToString(),
					                                  conn.leer["FOLIO"].ToString()+numero,
					                                  Convert.ToDateTime(conn.leer["FECHA_ACUERDO"].ToString().Substring(0,10)).ToShortDateString(),
									                   conn.leer["CONTACTO"].ToString(),
									                   conn.leer["EVENTO"].ToString(),
									                   conn.leer["CANTIDAD"].ToString(),     
													   conn.leer["TIPO_TRANSPOTE"].ToString(),
													   conn.leer["TOTAL_IVA"].ToString());
					if(conn.leer["ESTADO"].ToString().Equals("Cancelado"))
					{
						for(int y=0; y<dgCotizacionesRealizadas.Columns.Count; y++)
						{
							dgCotizacionesRealizadas[y,contador].Style.BackColor = Color.Red;
						}
					}
					
					if(interruptor == true){
						for(int y=0; y<dgCotizacionesRealizadas.Columns.Count; y++)
						{
							dgCotizacionesRealizadas[y,contador].Style.BackColor = Color.SteelBlue;
						}
					}						
					contador++;
				}
				conn.conexion.Close();		
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las cotizaciones Realizadas (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(interruptor == false){
				if(cbcanceladosC.Checked == false)
					avisoCotizacion(contador);
			}				
			dgCotizacionesRealizadas.ClearSelection();
		
		}	
		#endregion
		
		#region VALIDACION DE CAMPOS
		public void validaCampo(){
			this.txtSueldoOperador.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtExt.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtKM.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtKmItinerario.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtPrecioCasetas.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtCasetas.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtDiesel.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtGastosOtros.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTotalCasetas.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtPrecioUnitario.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTotalSinIVA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtNeto.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTelefono.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);	
			this.txtPrecioDiferente.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
		
		#region BOTONES		
		void LblLimpiarClick(object sender, EventArgs e)
		{
			interruptor = false;
			cbBusquedaCotizacion.Text = "CONTACTO";
			txtBusquedaCotizacion.Text = "";
			dtpInicioCotizacion.Value = DateTime.Now;
			dtpFinCotizacion.Value = DateTime.Now;
				
			cbBusquedaPRE.Text = "CONTACTO";
			txtBusquedaPRE.Text = "";
			dtpInicioPRE.Value = DateTime.Now;
			dtpFinPRE.Value = DateTime.Now;
		}
		
		void LblAgregarRazonClick(object sender, EventArgs e)
		{
			new Libro_Nuevo.Pagos.FormContribuyentes(1).ShowDialog();
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(cambioFlujo == false && modifcarCotizacion == false){				
					if(validarCamposGuardar() == true){	
						if(txtFolio.Text.Length > 2){
							new Libro_Nuevo.Complementos_Libro.FormCambiarAcuerdo(this).ShowDialog();		
							if(validarAcuerdo == true && fechaAcuerdo != "0"){								
								connL.insertarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
															txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
															dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
															dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
															txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
															txtNeto.Text, "2", id_usuario.ToString(),fechaAcuerdo, ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
									filtros();
									validarAcuerdo = false;
									limpiar();							
								}
							}else{
							MessageBox.Show("No se pudo guardar la cotización, ingresa en nombre del contacto", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
							txtContacto.Focus();
							}
						}else{
							MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}										
			}else{
				if(cambioFlujo == true){	
						if(txtFolio.Text.Length > 2)
						{					
							if(validarCamposGuardar() == true){											
									connL.actualizarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
														txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
														dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
														dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
														txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
														txtNeto.Text, "2", id_usuario.ToString(), Convert.ToString(dgCotizacionesPendientes[0,dgCotizacionesPendientes.CurrentRow.Index].Value), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
									cambioFlujo = false;
									limpiar();
									filtros();
							}else{
								MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}								
						}else{
							MessageBox.Show("No se pudo guardar la cotización, ingresa en nombre del contacto", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
							txtContacto.Focus();
						}	
		           	}
				
				if(modifcarCotizacion == true){
					if(txtFolio.Text.Length > 2)
						{		
							if(validarCamposGuardar() == true){									
									connL.actualizarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
														txtCasetas.Text,  txtDiesel.Text, txtGastosOtros.Text,((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
														dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
														dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
														txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
														txtNeto.Text, "2", id_usuario.ToString(), Convert.ToString(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
									modifcarCotizacion = false;
									limpiar();
									filtros();
							}else{
								MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}						
						}else{
							MessageBox.Show("No se pudo guardar la cotización, ingresa en nombre del contacto", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
							txtContacto.Focus();
						}						
		          }					
				if(cambioFlujo == true && modifcarCotizacion == true){
					MessageBox.Show("Lo sentimos no se guardarón los datos hay multiseleccion");
				}
			}
		}		
		
		void BtnPendienteClick(object sender, EventArgs e)
		{
			if(cambioFlujo == false && modifcarCotizacion == false){
				if(validarCamposGuardar() == true)
				{		
						if(txtFolio.Text.Length > 2)
						{
							connL.insertarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
														txtCasetas.Text,  txtDiesel.Text, txtGastosOtros.Text,((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
														dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
														dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
														txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
														txtNeto.Text, "1", id_usuario.ToString(),DateTime.Today.ToString("yyyy-MM-dd"), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());									
								filtros();
								limpiar();					
						}else{
							MessageBox.Show("No se pudo guardar la cotización, ingresa en nombre del contacto", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
							txtContacto.Focus();
						}
				}else{
					MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}	
			}else{
					MessageBox.Show("Lo sentimos no puedes volver a poner esta cotización en pendiente","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		void BtnViajeClick(object sender, EventArgs e)
		{
			ruta_inicio = "";
			if(validarCamposGuardar() == true){
				if(modifcarViaje == false){
						if(modifcarCotizacion == false && cambioFlujo == false){
							validarViaje = false;
							int id_max_cotizacion = 0;
							connL.insertarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
																		txtCasetas.Text,  txtDiesel.Text, txtGastosOtros.Text,((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
																		dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
																		dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
																		txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
																		txtNeto.Text, "3", id_usuario.ToString(),DateTime.Today.ToString("yyyy-MM-dd"), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
							id_max_cotizacion = connL.obtenerIdMaxCotizacion();
							new Libro_Nuevo.Complementos_Libro.FormConfirmaServicio(this, id_max_cotizacion, txtContacto.Text, txtTelefono.Text).ShowDialog();
							if(validarViaje == true){								
								Int64 id_re =  connL.insertarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), idCotizacionNuevo, id_usuario, idClienteNuevo, razon_socialV, fecha_facturaV);
								connL.insertaInicioRuta(ruta_inicio, id_re);
								insertarMetodosPagoFactura(id_re.ToString());
								new Libro_Nuevo.Pagos.FormControlPagos(this, id_re, "1").ShowDialog();
								new Libro_Nuevo.Complementos_Libro.FormEnviarCorreo(this, txtCorreo.Text, txtEvento.Text, txtContacto.Text, id_re).ShowDialog();
								
								limpiar();
								filtros();
								filtrosPrincipales();
								//filtrosEncuesta();
								filtrosSinOrden();
								idClienteNuevo = 0;
								idCotizacionNuevo = 0;
							}else{
								if(id_max_cotizacion > 0)
									connL.eliminaCotizaicon(id_max_cotizacion);
							}
						}
					
						if(modifcarCotizacion == true){
							validarViaje = false;
							new Libro_Nuevo.Complementos_Libro.FormConfirmaServicio(this, Convert.ToInt32(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), txtContacto.Text, txtTelefono.Text).ShowDialog();						
							if(validarViaje == true){
								connL.actualizarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
																	txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
																	dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
																	dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
																	txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
																	txtNeto.Text, "3", id_usuario.ToString(), Convert.ToString(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
								//connL.insertarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), Convert.ToInt32(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), id_usuario);
								Int64 id_re =  connL.insertarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), Convert.ToInt32(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), id_usuario, idClienteNuevo, razon_socialV, fecha_facturaV);
								modifcarCotizacion = false;
								connL.insertaInicioRuta(ruta_inicio, id_re);
								insertarMetodosPagoFactura(id_re.ToString());								
								new Libro_Nuevo.Pagos.FormControlPagos(this, id_re, "1").ShowDialog();						
								new Libro_Nuevo.Complementos_Libro.FormEnviarCorreo(this, txtCorreo.Text, txtEvento.Text, txtContacto.Text, id_re).ShowDialog();
								limpiar();
								filtros();
								filtrosPrincipales();
								filtrosSinOrden();
								idClienteNuevo = 0;
								idCotizacionNuevo = 0;
							}
						}
						
						if(cambioFlujo == true){
							validarViaje = false;
							new Libro_Nuevo.Complementos_Libro.FormConfirmaServicio(this, Convert.ToInt32(dgCotizacionesPendientes[0,dgCotizacionesPendientes.CurrentRow.Index].Value), txtContacto.Text, txtTelefono.Text).ShowDialog();
							if(validarViaje == true){
								connL.actualizarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
																	txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
																	dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
																	dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
																	txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
																	txtNeto.Text, "3", id_usuario.ToString(), Convert.ToString(dgCotizacionesPendientes[0,dgCotizacionesPendientes.CurrentRow.Index].Value), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
								//connL.insertarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), Convert.ToInt32(dgCotizacionesPendientes[0,dgCotizacionesPendientes.CurrentRow.Index].Value), id_usuario, );
								Int64 id_re = connL.insertarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), Convert.ToInt32(dgCotizacionesPendientes[0,dgCotizacionesPendientes.CurrentRow.Index].Value), id_usuario, idClienteNuevo, razon_socialV, fecha_facturaV);
								cambioFlujo = false;
								connL.insertaInicioRuta(ruta_inicio, id_re);
								insertarMetodosPagoFactura(id_re.ToString());
								new Libro_Nuevo.Pagos.FormControlPagos(this, id_re, "1").ShowDialog();						
								new Libro_Nuevo.Complementos_Libro.FormEnviarCorreo(this, txtCorreo.Text, txtEvento.Text, txtContacto.Text, id_re).ShowDialog();
								limpiar();
								filtros();
								filtrosPrincipales();
								filtrosSinOrden();
								idClienteNuevo = 0;
								idCotizacionNuevo = 0;
							}
						}					
				}
				if(modifcarViaje == true){
					String cambio = "NO";
					Int64 cant = 0;
					int cantida = connL.obtenerCantidadVehiculos(dgControlPRE.Rows[dgControlPRE.CurrentRow.Index].Cells[0].Value.ToString());
					if( cantida != Convert.ToInt32(dgControlPRE.Rows[dgControlPRE.CurrentRow.Index].Cells[7].Value) ){
						if(nudCantidadtransporte.Text == (cantida).ToString()){
							cambio = "NO";
						}else if(Convert.ToInt64(nudCantidadtransporte.Text) > cantida ){
							cambio = "MAS";
							cant = Convert.ToInt64(nudCantidadtransporte.Text) - cantida;
						}else if(Convert.ToInt64(nudCantidadtransporte.Text) < cantida ){
							cambio = "MENOS";
							cant = cantida - Convert.ToInt64(nudCantidadtransporte.Text);
						}
					}else{
						if(nudCantidadtransporte.Text==dgControlPRE.Rows[dgControlPRE.CurrentRow.Index].Cells[7].Value.ToString()){
							cambio = "NO";
						}else if(Convert.ToInt64(nudCantidadtransporte.Text)>Convert.ToInt64(dgControlPRE.Rows[dgControlPRE.CurrentRow.Index].Cells[7].Value.ToString())){
							cambio = "MAS";
							cant=Convert.ToInt64(nudCantidadtransporte.Text)-Convert.ToInt64(dgControlPRE.Rows[dgControlPRE.CurrentRow.Index].Cells[7].Value.ToString());
						}else if(Convert.ToInt64(nudCantidadtransporte.Text)<Convert.ToInt64(dgControlPRE.Rows[dgControlPRE.CurrentRow.Index].Cells[7].Value.ToString())){
							cambio = "MENOS";
							cant=Convert.ToInt64(dgControlPRE.Rows[dgControlPRE.CurrentRow.Index].Cells[7].Value.ToString())-Convert.ToInt64(nudCantidadtransporte.Text);
						}
					}
					
					recuperaFactura = false;
					if(validaCambiosFinal(cambio)){
						if(validaCambiosFactura()){
							connL.actualizarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
																		txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
																		dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
																		dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
																		txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
																		txtNeto.Text, "3", id_usuario.ToString(), Convert.ToString(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Value), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
							connL.modificarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), id_usuario, cambio, cant,  Convert.ToInt32(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value));
							if(cbFactura.Checked == true)
								connL.recuperarFactura(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value.ToString());
							
							modifcarViaje = false;
							limpiaAccion();
							filtros();
							filtrosPrincipales();
							filtrosSinOrden();
						}else{
							DialogResult rs = MessageBox.Show("El servicio está en proceso de facturación, se eliminara la orden de factura ¿Desea continuar?", "Alerta Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
							if (DialogResult.Yes==rs){	
								connL.actualizarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
																		txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
																		dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
																		dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
																		txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
																		txtNeto.Text, "3", id_usuario.ToString(), Convert.ToString(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Value), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
								connL.modificarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), id_usuario, cambio, cant,  Convert.ToInt32(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value));
								if(cbForaneo.Checked == true)
									connL.recuperarFactura(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value.ToString());
								connL.cambiosRealizados(Convert.ToInt32(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value), id_usuario);
								connL.EliminarFactura2(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value.ToString(), ((cbFactura.Checked==true)?"1":"0"));
								modifcarViaje = false;						
								limpiaAccion();
								filtrosPrincipales();
								filtrosSinOrden();
							}else{							
								limpiaAccion();
							}
						}	
					}else{												
						limpiaAccion();
					}
				}				
			}else{
				MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}
		
		void BtnNuevoClick(object sender, EventArgs e)
		{
			cbcanceladosC.Checked = false;
			cbBusquedaCotizacion.SelectedIndex = 1;
			dtpInicioCotizacion.Value = DateTime.Now;
			dtpFinCotizacion.Value = DateTime.Now;
			filtros();			
			
			cbBusquedaPRE.SelectedIndex = 1;
			dtpInicioPRE.Value = DateTime.Now;
			dtpFinPRE.Value = DateTime.Now;			
			filtrosPrincipales();
			
			limpiar();
			cambioFlujo = false;
			modifcarCotizacion = false;
			validarViaje = false;
			modifcarViaje = false;
		}
			
		void BtnDuplicarClick(object sender, EventArgs e)
		{
			if(cambioFlujo == false && modifcarCotizacion == false){
				if(txtNeto.Text.Length > 0){
						if(validarCamposGuardar() == true){
						new Libro_Nuevo.Complementos_Libro.FormCambiarAcuerdo(this).ShowDialog();			
						if(validarAcuerdo == true && fechaAcuerdo != "0"){
							if(txtFolio.Text.Length > 2)
							{			
								connL.insertarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
															txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
															dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
															dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
															txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
															txtNeto.Text, "2", id_usuario.ToString(),fechaAcuerdo, ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
									filtros();
									obtenerFolio();
									limpiaAccion();
									validarAcuerdo = false;							
							}else{
								MessageBox.Show("No se pudo guardar la cotización, ingresa en nombre del contacto", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
								txtContacto.Focus();
							}	
						}
					}else{
						MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}else{
					if(validarCamposGuardar() == true){		
							if(txtFolio.Text.Length > 2){	
									connL.insertarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
																txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
																dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
																dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
																txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
																txtNeto.Text, "1", id_usuario.ToString(),DateTime.Today.ToString("yyyy-MM-dd"), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());								
									filtros();
									obtenerFolio();
									limpiaAccion();							
							}else{
								MessageBox.Show("No se pudo guardar la cotización, ingresa en nombre del contacto", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
								txtContacto.Focus();
							}
					}else{
						MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
						
				if(cambioFlujo == true){
					if(validarCamposGuardar() == true){		
						connL.insertarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
																	txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
																	dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
																	dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
																	txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
																	txtNeto.Text, "1", id_usuario.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString() );
						cambioFlujo = false;
						filtros();
						limpiar();
						limpiaAccion();
					}else{
						MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}					
				}
				
				if(modifcarCotizacion == true){
					if(validarCamposGuardar() == true){							
						connL.insertarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
													txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
													dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
													dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
													txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
													txtNeto.Text, "2", id_usuario.ToString(), (dgCotizacionesRealizadas[2,dgCotizacionesRealizadas.CurrentRow.Index].Value).ToString(), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
						modifcarCotizacion = false;
						filtros();
						limpiar();
						limpiaAccion();
					}else{
						MessageBox.Show("Llena los campos obligatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);						
					}
				}
		}
		#endregion
		
		#region METODOS		
		private void insertarMetodosPagoFactura(string id_re){
			try{
				if(dgMetodoFactura != null && dgMetodoFactura.Rows.Count > 0){
					for(int x=0; x<dgMetodoFactura.Rows.Count; x++){				
						connL.insertarMetodoFactura(id_re, dgMetodoFactura[1,x].Value.ToString(), dgMetodoFactura[2,x].Value.ToString(), dgMetodoFactura[3,x].Value.ToString(), dgMetodoFactura[4,x].Value.ToString());
					}
				}
			}catch(Exception){	}
		}
		
		private void cotizacionPendientesA(){
			string consul = @"select COUNT(*) num from VIAJE_PROSPECTO_NUEVO where  FLUJO = 1 and ESTADO = 'Activo'";
			try{
				conn.getAbrirConexion(consul);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(Convert.ToInt32(conn.leer["num"]) > 0)						
	     				timer1.Start(); 
					else
	      				timer1.Stop(); 						
				}				
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener aviso de cotizaciones Pendientes: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	      		timer1.Stop(); 	
			}			
		}
		
		public void limpiaAccion(){
			dgControlPRE.ClearSelection();
			dgCotizacionesPendientes.ClearSelection();
			dgCotizacionesRealizadas.ClearSelection();
			modifcarViaje = false;
			cambioFlujo = false;
			modifcarCotizacion = false;
			modifcarViaje = false;
			limpiar();	
		}
		
		public void autoCompletar(){			
			txtCompañia.AutoCompleteCustomSource = auto.AutocompleteGeneral("select COMPANIA_NOMBRE from VIAJE_PROSPECTO_NUEVO", "COMPANIA_NOMBRE");
           	txtCompañia.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCompañia.AutoCompleteSource = AutoCompleteSource.CustomSource;     

			txtContacto.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CONTACTO from VIAJE_PROSPECTO_NUEVO", "CONTACTO");
           	txtContacto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtContacto.AutoCompleteSource = AutoCompleteSource.CustomSource;                  
		           
			txtCorreo.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CORREO from VIAJE_PROSPECTO_NUEVO", "CORREO");
           	txtCorreo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCorreo.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
			txtEvento.AutoCompleteCustomSource = auto.AutocompleteGeneral("select EVENTO from VIAJE_PROSPECTO_NUEVO", "EVENTO");
           	txtEvento.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEvento.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
			txtUbicacionPartida.AutoCompleteCustomSource = auto.AutocompleteGeneral("select UBICACION_PARTIDA from VIAJE_PROSPECTO_NUEVO", "UBICACION_PARTIDA");
           	txtUbicacionPartida.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUbicacionPartida.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
            txtBusquedaCotizacion.AutoCompleteCustomSource = auto.AutocompleteGeneral("select FOLIO from VIAJE_PROSPECTO_NUEVO", "FOLIO");
            txtUbicacionPartida.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUbicacionPartida.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
			txtRazonSocial.AutoCompleteCustomSource = auto.AutocompleteGeneral("select RAZON_SOCIAL from DATOS_FACTURA", "RAZON_SOCIAL");
            txtRazonSocial.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource;             
		}	
			
		public String sentidoRuta()
		{
			if(cbLlevarlos.Checked==true && cbRegresarlos.Checked==true)
			{
				SentidoR="Completo";
			}
			if(cbLlevarlos.Checked==true && cbRegresarlos.Checked==false)
			{
				SentidoR="Entrada";
			}
			if(cbLlevarlos.Checked==false && cbRegresarlos.Checked==true)
			{
				SentidoR="Salida";
			}
			
			return SentidoR;
		}
		
		public Boolean validarCamposGuardar(){
			bool respuesta = true;
			
			int cant=Convert.ToInt16(nudCantidadtransporte.Value);
			if(txtContacto.Text.Length < 2){
				txtContacto.Focus();
				respuesta = false;
			}
			
			if( txtCasetas.Text == ""){
				txtCasetas.Focus();
				respuesta = false;
			}
			
			if(txtTelefono.Text == ""){
				txtTelefono.Focus();
				respuesta = false;
			}
			
			if(txtEvento.Text == ""){
				txtEvento.Focus();
				respuesta = false;
			}
			
			if(txtDetalleEvento.Text == ""){
				txtDetalleEvento.Focus();
				respuesta = false;
			}
			
			if(txtKM.Text == "" || txtKM.Text == "0"){
				txtKM.Focus();
				respuesta = false;
			}
			
			if(cant<=0){
				nudCantidadtransporte.Focus();
				respuesta = false;
			}
			
			if(cbLlevarlos.Checked == false){
				cbLlevarlos.Focus();
				respuesta = false;
			}
			
			if(txtTelefono.Text == ""){
				txtTelefono.Focus();
				respuesta = false;
			}
			
			if(dtpHoraSalida.Text == "00:00"){
				dtpHoraSalida.Focus();
				respuesta = false;
			}
			
			if(cbForaneo.Checked == true){
				if(cbWC.Checked == false && cbAireC.Checked == false && cbTV.Checked == false){
					cbWC.Focus();
					respuesta = false;					
				}
			}						
			return respuesta;
		}
		
		public Boolean validarCamposPendiente(){
			bool respuesta = true;
			
			if(txtContacto.Text.Length < 2){
				txtContacto.Focus();
				respuesta = false;
			}
			
			if(txtTelefono.Text == ""){
				txtTelefono.Focus();
				respuesta = false;
			}
			
			if(cbLlevarlos.Checked == false){
				cbLlevarlos.Focus();
				respuesta = false;
			}
			
			return respuesta;	
		}		
		
		public void limpiar(){
			txtCompañia.Text = "";
			txtFolio.Text = "";
			txtContacto.Text = "";
			txtCorreo.Text = "";
			cbCompañia.Text = "PARTICULAR";
			txtTelefono.Text = "";
			txtExt.Text = "";
			cbForaneo.Checked = false;
			txtEvento.Text = "";
			txtDetalleEvento.Text = "";
			cbTipo.SelectedIndex = 0;
			txtKM.Text = "";
			rbCamion.Checked = true;
			nudCantidadtransporte.Text = "1";
			nupCanUsuarios.Text = "40";
			cbWC.Checked = false;
			cbAireC.Checked = false;
			cbTV.Checked = false;
			cbEmpresarial.Checked = false;
			dtpFechaSalida.Value = DateTime.Now;
			dtpHoraSalida.Text = "00:00";
			dtpFechaRegreso.Value = DateTime.Now;
			dtpHoraRegreso.Value = DateTime.Now;
			dtpHoraPlanton.Value = DateTime.Now;
			nudDias.Text = "1";
			txtUbicacionPartida.Text = "GUADALAJARA";
			cbDeCamino.Checked = false;
			cbLlevarlos.Checked = true;
			cbRegresarlos.Checked = true;
			txtItinerarioAdicionales.Text = "Sin Movimientos";
			txtKmItinerario.Text = "0";
			txtCasetas.Text = "";
			txtDiesel.Text = "";
			txtGastosOtros.Text = "";
			txtPrecioCasetas.Text = "0";
			txtSueldoOperador.Text = "";
			txtPrecioUnitario.Text = "";
			txtTotalSinIVA.Text = "";
			txtNeto.Text = "";
			cbFactura.Checked = false;
			cbDiferente.Checked = false;
			txtPrecioDiferente.Text = "";
			txtPrecioDiferenteIVA.Text = "";
			txtTotalCasetas.Text = "0";
			
			btnPendiente.Enabled = false;
			btnViaje.Enabled = false;
			btnGuardar.Enabled = false;
			btnDuplicar.Enabled = false;
			//txtDatosFactura.Enabled = false;
			txtRuta.Text = "";
			cbComo.SelectedIndex = -1;
			
			interruptor = false;
		}
		
		public void obtenerFolio(){
			string folio;
			string numero;
			Int32 nfolio;
			if(txtContacto.Text.Length > 2){
				folio = txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd");
				
				nfolio = connL.obtenerNumero();
				if(nfolio == 0)
					numero= "01";				
				else if(nfolio.ToString().Length == 1)
					numero = "0"+nfolio;
				else
					numero = nfolio.ToString();				
				
				txtFolio.Text = folio+numero;
			}else{
				txtFolio.Text = "";				
			}
		}
		
		public void calculaPrecioTotal(){
			if(txtTotalCasetas.Text.Length > 0 && txtItinerarioAdicionales.Text.Length > 0){
				if(txtPrecioUnitario.Text.Length > 0 && nudCantidadtransporte.Text.Length > 0){
					btnDuplicar.Enabled = true;
					btnGuardar.Enabled = true;
					btnViaje.Enabled = true;
					btnPendiente.Enabled = false;
					txtTotalSinIVA.Text = ((Convert.ToInt64(txtPrecioUnitario.Text) * Convert.ToInt16(nudCantidadtransporte.Value)) + Convert.ToInt64(txtTotalCasetas.Text)).ToString();
										
					txtNeto.Text = txtTotalSinIVA.Text;
					
					if(cbFactura.Checked == true)
						txtNeto.Text = (Math.Round(Convert.ToInt64(txtTotalSinIVA.Text) * 1.16, 2)).ToString();
					
					if(cbFactura.Checked == true && cbDiferente.Checked == true &&txtPrecioDiferente.Text.Length > 0 ){
						if(Convert.ToDouble(txtPrecioDiferente.Text) <= Convert.ToDouble(txtTotalSinIVA.Text)){						
							txtPrecioDiferenteIVA.Text = (Convert.ToDouble(txtPrecioDiferente.Text) * 1.16).ToString();
							txtTotalSinIVA.Text = (Convert.ToDouble(txtTotalSinIVA.Text) - Convert.ToDouble(txtPrecioDiferente.Text)).ToString();
							
							txtNeto.Text = "";						
							txtNeto.Text = Math.Round(Convert.ToDecimal(txtTotalSinIVA.Text) + Convert.ToDecimal(txtPrecioDiferenteIVA.Text), 2).ToString();
						}
					}
				}
			}
				
			
			if(txtTotalCasetas.Text == "" && txtItinerarioAdicionales.Text == ""){				
				if(txtPrecioUnitario.Text.Length > 0 && nudCantidadtransporte.Text.Length > 0){
					btnDuplicar.Enabled = true;
					btnGuardar.Enabled = true;
					btnViaje.Enabled = true;
					btnPendiente.Enabled = false;
					
					
					if(txtPrecioDiferenteIVA.Text.Length <= 0){
						txtTotalSinIVA.Text = (Convert.ToInt64(txtPrecioUnitario.Text) * Convert.ToInt16(nudCantidadtransporte.Value)).ToString();						
					}
					
					txtNeto.Text = txtTotalSinIVA.Text;
						                        
					if(cbFactura.Checked == true)
						txtNeto.Text = (Math.Round(Convert.ToInt64(txtTotalSinIVA.Text) * 1.16, 2)).ToString();
					
					if(cbFactura.Checked == true && cbDiferente.Checked == true &&txtPrecioDiferente.Text.Length > 0 ){
						if(Convert.ToDouble(txtPrecioDiferente.Text) <= Convert.ToDouble(txtTotalSinIVA.Text)){						
							txtPrecioDiferenteIVA.Text = (Convert.ToDouble(txtPrecioDiferente.Text) * 1.16).ToString();
							txtTotalSinIVA.Text = (Convert.ToDouble(txtTotalSinIVA.Text) - Convert.ToDouble(txtPrecioDiferente.Text)).ToString();
							
							txtNeto.Text = "";						
							txtNeto.Text = Math.Round(Convert.ToDecimal(txtTotalSinIVA.Text) + Convert.ToDecimal(txtPrecioDiferenteIVA.Text), 2).ToString();
						}
					}
				}
			}
			
			if(txtTotalCasetas.Text != "" && txtItinerarioAdicionales.Text == ""){
				btnGuardar.Enabled = false;
				btnViaje.Enabled = false;
				btnPendiente.Enabled = true;
				txtTotalSinIVA.Text = "";
				txtNeto.Text = "";
			}
			
			if(txtTotalCasetas.Text == "" && txtItinerarioAdicionales.Text != ""){
				btnGuardar.Enabled = false;
				btnViaje.Enabled = false;
				btnPendiente.Enabled = true;
				txtTotalSinIVA.Text = "";
				txtNeto.Text = "";
			}
			
			if(txtPrecioUnitario.Text == ""){
				txtTotalSinIVA.Text = "";				
				txtNeto.Text = "";		
			}
		}
		
		public bool validaCambiosFactura(){
			bool respuesta = true;
			int f = 0;
			if(cbFactura.Checked == true)
				f = 1;
				
			if(validaCambioFactura > 1){			
				if(precioValidacion != Convert.ToDouble(txtNeto.Text))
					respuesta = false;

				if(facturaValidacion != f)
					respuesta = false;				
			}			
			
			/**
			if(connL.validarCambios(Convert.ToInt32(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value))){
				if(facturaValidacion != f){
					respuesta = false;
				}
			
				if(precioValidacion != Convert.ToDouble(txtNeto.Text)){
					respuesta = false;
				}
			}*/
			return respuesta;
		}
		
		public bool validaCambiosFinal(string cambioUnidades){
			bool respuesta = true;
			
			if(cambioUnidades == "MENOS"){
				if(connL.validarAsignaciones(Convert.ToInt32(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value))){
					respuesta = false;
					MessageBox.Show("El servicio ya fue asignado, para modificarlo debes de quitar la asignación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}else{				
				if(connL.validarCambios(Convert.ToInt32(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value))){
					respuesta = false;
				}
				
				if(respuesta == false && (principal.lblDatoNivel.Text == "GERENCIAL" || principal.lblDatoNivel.Text == "MASTER")){
					DialogResult respu = MessageBox.Show("El servicio ya fue validado por ventas, los cambios que realices serán bajo TU responsabilidad ¿Deseas continuar?" , "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if(respu == DialogResult.Yes)
						respuesta = true;			
				}
				
				if(respuesta == false && (principal.lblDatoNivel.Text != "GERENCIAL" && principal.lblDatoNivel.Text != "MASTER"))				
					MessageBox.Show("Ya validaste el servicio, ya no puedes modificarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);			
				
				recuperaFactura = respuesta;
			}
			return respuesta;
		}
		#endregion		
		
		#region FILTROS
		public void avisoCotizacion(int contado){
			String Consulta = "select * from VIAJE_PROSPECTO_NUEVO where FLUJO = 2 and ESTADO = 'Activo' and FECHA_ACUERDO < '"+DateTime.Now.ToString("yyyy-MM-dd")+"'";
			int contador = contado;
			string numero;
			txtCotizacionSinResolver.Text = "0";			
			try{					
				conn.getAbrirConexion(Consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{				
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();				
				
					dgCotizacionesRealizadas.Rows.Add(conn.leer["ID"].ToString(),
					                                  conn.leer["FOLIO"].ToString()+numero,
					                                  Convert.ToDateTime(conn.leer["FECHA_ACUERDO"].ToString().Substring(0,10)).ToShortDateString(),
									                   conn.leer["CONTACTO"].ToString(),
									                   conn.leer["EVENTO"].ToString(),
									                   conn.leer["CANTIDAD"].ToString(),     
													   conn.leer["TIPO_TRANSPOTE"].ToString(),
													   conn.leer["TOTAL_IVA"].ToString());										
					DateTime date1 = Convert.ToDateTime(conn.leer["FECHA_ACUERDO"].ToString().Substring(0,10));
 					DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
     				int result1 = DateTime.Compare(date1, date2);     				
     				if(result1 == -1 && dgCotizacionesRealizadas[2,contador].Style.BackColor.Name != "Red"){
     					dgCotizacionesRealizadas[2,contador].Style.BackColor = Color.Red;
     					txtCotizacionSinResolver.Text = (Convert.ToInt32(txtCotizacionSinResolver.Text) + 1).ToString();
     					txtCotizacionSinResolver.BackColor = Color.Red;
     				}
					contador++;
				}
				conn.conexion.Close();		
			}catch(Exception ex){
				MessageBox.Show("Error al obtener el aviso de las cotizaciones Realizadas (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{				
				conn.conexion.Close();	
			}	
		}
		
		public void filtros(){
			if(cbcanceladosC.Checked == true){
				String consulta = "select * from VIAJE_PROSPECTO_NUEVO where FLUJO = 2 and FECHA_ACUERDO between '"+dtpInicioCotizacion.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinCotizacion.Value.ToString("yyyy-MM-dd")+"' ";
				if(txtBusquedaCotizacion.Text.Length > 0){
					if(cbBusquedaCotizacion.Text == "DESTINO")
						consulta = consulta + "and EVENTO like '%"+txtBusquedaCotizacion.Text+"%'";						
					else
						consulta = consulta + "and "+cbBusquedaCotizacion.Text+" like '%"+txtBusquedaCotizacion.Text+"%'";		
				}
				ContizacionesRealizadas(consulta);			
			}else{
				String consulta = "select * from VIAJE_PROSPECTO_NUEVO where FLUJO = 1 and ESTADO = 'Activo' ";
				if(txtBusquedaCotizacion.Text.Length > 0){
					if(cbBusquedaCotizacion.Text == "DESTINO")
						consulta = consulta + "and EVENTO like '%"+txtBusquedaCotizacion.Text+"%'";	
					else
						consulta = consulta + "and "+cbBusquedaCotizacion.Text+" like '%"+txtBusquedaCotizacion.Text+"%'";	
				}
					ContizacionesPendientes(consulta);
						
				String consulta2 = "select * from VIAJE_PROSPECTO_NUEVO where FLUJO = 2 and ESTADO = 'Activo' and FECHA_ACUERDO between '"+dtpInicioCotizacion.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinCotizacion.Value.ToString("yyyy-MM-dd")+"' ";
				if(txtBusquedaCotizacion.Text.Length > 0){
					if(cbBusquedaCotizacion.Text == "DESTINO")
						consulta2 = consulta2 + "and EVENTO like '%"+txtBusquedaCotizacion.Text+"%'";	
					else
						consulta2 = consulta2 + "and "+cbBusquedaCotizacion.Text+" like '%"+txtBusquedaCotizacion.Text+"%'";	
				}
					ContizacionesRealizadas(consulta2);			
			}
			cotizacionPendientesA();			
		}		
		#endregion		
		
		#region EVENTOS CHANGER		
		void CbBusquedaCotizacionSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbBusquedaCotizacion.SelectedIndex == 1){
				txtBusquedaCotizacion.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CONTACTO from VIAJE_PROSPECTO_NUEVO", "CONTACTO");
	           	txtBusquedaCotizacion.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusquedaCotizacion.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
			if(cbBusquedaCotizacion.SelectedIndex == 2){
				txtBusquedaCotizacion.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CORREO from VIAJE_PROSPECTO_NUEVO", "CORREO");
	           	txtBusquedaCotizacion.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusquedaCotizacion.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
			if(cbBusquedaCotizacion.SelectedIndex == 3){
				txtBusquedaCotizacion.AutoCompleteCustomSource = auto.AutocompleteGeneral("select EVENTO from VIAJE_PROSPECTO_NUEVO", "EVENTO");
	           	txtBusquedaCotizacion.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusquedaCotizacion.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
		}
		
		void TxtCasetasTextChanged(object sender, EventArgs e)
		{
			//txtSueldoOperador.Text = (Convert.ToInt32(txtPrecioUnitario.Text) *.10).ToString();		
			if(txtCasetas.Text != ""){
				if(txtPrecioUnitario.Text != ""){
					if(cbForaneo.Checked == true){
						txtCasetas.Text=((txtCasetas.Text=="")?"0":txtCasetas.Text);
						txtSueldoOperador.Text = ((Convert.ToInt32(txtPrecioUnitario.Text) - Convert.ToInt32(txtCasetas.Text)) *.20).ToString();
					}
					else
						txtSueldoOperador.Text = ((rbCamion.Checked == true)? "180" : "130");									
				}
			}
		}
		
		void TxtCasetasEnter(object sender, EventArgs e)
		{
			txtCasetas.SelectAll();
		}
		
		void CbTipoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbTipo.Text == "3" || cbTipo.Text == "2")
				cbForaneo.Checked = true;
			else
				cbForaneo.Checked = false;
		}
		
		void TxtEventoTextChanged(object sender, EventArgs e)
		{
			if(txtEvento.Text.Length > 0){
				if(cambioFlujo == false && modifcarCotizacion == false && modifcarViaje == false){
					//try{
						conn.getAbrirConexion("select FORANEO, TIPO_CLIENTE, KM_SERVICIO, DETALLE from VIAJE_PROSPECTO_NUEVO where EVENTO  LIKE '%"+txtEvento.Text+"%'");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()){						
							cbForaneo.Checked = ((conn.leer["FORANEO"].ToString() == "1")? true : false);
							cbTipo.Text = conn.leer["TIPO_CLIENTE"].ToString();
							//txtKM.Text = conn.leer["KM_SERVICIO"].ToString();
							txtDetalleEvento.Text = conn.leer["DETALLE"].ToString();							
						}else{
							cbForaneo.Checked = false;
							cbTipo.SelectedIndex = -1;
							txtKM.Text = "";
							txtDetalleEvento.SelectedIndex = -1;
						}
						conn.conexion.Close();
				//	//}catch(Exception ex){
					//	MessageBox.Show("ERROR AL OBTENER DATOS DE LA COMPAÑIA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//	}
				}
			}else{
				cbForaneo.Checked = false;
				cbTipo.SelectedIndex = -1;
				txtKM.Text = "";
				txtDetalleEvento.SelectedIndex = -1;
			}
		}
		
		void TabSelectedIndexChanged(object sender, EventArgs e)
		{
			if(tab.SelectedIndex == 0)
				dgControlPRE.ClearSelection();
			
			if(tab.SelectedIndex == 1)
				dgImpresion.ClearSelection();
			
			if(tab.SelectedIndex == 2)
				dgSinOrden.ClearSelection();				
			
			if(tab.SelectedIndex == 3){
				filtrosValidacion();
				dgDatos.ClearSelection();	
			}
			
			if(tab.SelectedIndex == 4){
				filtrosEncuesta();
				dgEncuesta.ClearSelection();				
			}
		}
		
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			if(tabControl1.SelectedIndex == 1)
				dgOrdenFactura.ClearSelection();
		}
		
		void CbCompañiaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbCompañia.Text == "PARTICULAR"){
				txtCompañia.Enabled = false;
				txtCompañia.Text = txtContacto.Text;
			}else{
				txtCompañia.Enabled = true;
			}
		}
		
		void TxtPrecioUnitarioTextChanged(object sender, EventArgs e)
		{
			if(txtCasetas.Text == "")
				txtCasetas.Text = "";
			if(txtPrecioUnitario.Text != ""){
				if(cbForaneo.Checked == true){
					txtCasetas.Text=((txtCasetas.Text=="")?"0":txtCasetas.Text);
					txtSueldoOperador.Text = ((Convert.ToInt32(txtPrecioUnitario.Text) - Convert.ToInt32(txtCasetas.Text)) *.20).ToString();					
				}else{					
					//txtSueldoOperador.Text = (Convert.ToInt32(txtPrecioUnitario.Text) *.10).ToString();
					txtSueldoOperador.Text = ((rbCamion.Checked == true)? "180" : "130");
				}
			}else{
				txtSueldoOperador.Text = "0";
			}
			calculaPrecioTotal();
		}
					
		void TxtContactoLeave(object sender, EventArgs e)
		{
			obtenerFolio();
		}
		
		void DtpInicioCotizacionValueChanged(object sender, EventArgs e)
		{
			dtpFinCotizacion.Value = dtpInicioCotizacion.Value;
		}
		
		void DtpFinCotizacionValueChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtros();
		}
		
		void TxtBusquedaCotizacionTextChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtros();			
		}
				
		void CbFacturaCheckedChanged(object sender, EventArgs e)
		{
			calculaPrecioTotal();
			/*
			if(cbFactura.Checked == true){
				//cbDiferente.Visible = true;
			//	txtPrecioDiferente.Text = "";
				dtpFechaFactura.Enabled = true;
				txtRazonSocial.Visible = true;
				lblAgregarRazon.Visible = true;
				dtpFechaFactura.Value = DateTime.Now;
			}else{		
				//cbDiferente.Visible = false;
				//txtPrecioDiferente.Text = "";
				dtpFechaFactura.Enabled = false;
				txtRazonSocial.Visible = false;
				lblAgregarRazon.Visible = false;
			}
			*/
		}		
		
		void CbcanceladosCCheckedChanged(object sender, EventArgs e)
		{			
			if(validaAdpatadores == false)
				filtros();
		}
		
		void TxtFolioTextChanged(object sender, EventArgs e)
		{
			if(txtFolio.Text.Length > 0){
				btnPendiente.Enabled = true;
				btnDuplicar.Enabled = true;
			}else{
				btnPendiente.Enabled = false;
				btnDuplicar.Enabled = false;
				btnGuardar.Enabled = false;
				btnViaje.Enabled = false;
			}
		}
		
		void TxtItinerarioAdicionalesTextChanged(object sender, EventArgs e)
		{
			if(txtItinerarioAdicionales.Text == "SIN MOVIMIENTOS"){
				txtKmItinerario.Text = "0";
				txtPrecioCasetas.Text = "0";
				txtTotalCasetas.Text = "0";
			}else{
				txtKmItinerario.Text = "";
				txtPrecioCasetas.Text = "";
				txtTotalCasetas.Text = "";
			}
			calculaPrecioTotal();
		}
		
		void TxtTotalCasetasTextChanged(object sender, EventArgs e)
		{
			calculaPrecioTotal();
		}
		
		void NudCantidadtransporteValueChanged(object sender, EventArgs e)
		{			
		
			calculaPrecioTotal();
		}	

		void TxtUbicacionPartidaEnter(object sender, EventArgs e)
		{			
			txtUbicacionPartida.SelectAll();
		}
		
		void DtpFechaSalidaValueChanged(object sender, EventArgs e)
		{
			Fecha = dtpFechaSalida.Value.ToString("yyyy-MM-dd");
			String dia = dtpFechaSalida.Value.ToString("dd");;
			String mes = dtpFechaSalida.Value.ToString("MM");;
			String ano = dtpFechaSalida.Value.ToString("yyyy");;
			DateTime dateValue = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), Convert.ToInt32(dia));
			dia = dateValue.DayOfWeek.ToString();
			if(dia == "Monday")
			{
				diasemana = "11000000";
			}
			else if(dia == "Tuesday")
			{
				diasemana = "10100000";
			}
			else if(dia == "Wednesday")
			{
				diasemana = "10010000";
			}
			else if(dia == "Thursday")
			{
				diasemana = "10001000";
			}
			else if(dia == "Saturday")
			{
				diasemana = "10000010";
			}
			else if(dia == "Friday")
			{
				diasemana = "10000100";
			}
			else if(dia == "Sunday")
			{
				diasemana = "10000001";
			}		
			
			
			dtpFechaRegreso.Value = dtpFechaSalida.Value;
			
			if(dtpFechaSalida.Value.CompareTo(this.dtpFechaRegreso.Value) == 0){
				DateTime oldDate = dtpFechaSalida.Value;
				DateTime newDate = dtpFechaRegreso.Value;			
				TimeSpan ts = newDate - oldDate;				
				nudDias.Text = (ts.Days+1).ToString();					
			}
		}
		
		void DtpFechaRegresoValueChanged(object sender, EventArgs e)
		{
			if(dtpFechaSalida.Value.CompareTo(this.dtpFechaRegreso.Value) == 1){
			  	MessageBox.Show("La fecha de salida no debe de ser mayor a la fecha de regreso, no es el delorean", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}else{
				DateTime oldDate = dtpFechaSalida.Value;
				DateTime newDate = dtpFechaRegreso.Value;			
				TimeSpan ts = newDate - oldDate;				
				nudDias.Text = (ts.Days+1).ToString();					
			}
		}
		
		void RbCamionetaCheckedChanged(object sender, EventArgs e)
		{
			tipoV = rbCamioneta.Text;
			if(rbCamioneta.Checked == true){				
				nupCanUsuarios.Text = "12";
				cbWC.Enabled = false;
			}else{				
				cbWC.Enabled = true;
			}			
			
			if(txtPrecioUnitario.Text != ""){
				if(cbForaneo.Checked == false)
					txtSueldoOperador.Text = ((rbCamion.Checked == true)? "180" : "130");
			}else
				txtSueldoOperador.Text = "0";
		}
		
		void RbCamionCheckedChanged(object sender, EventArgs e)
		{
			tipoV = rbCamion.Text;
			if(rbCamion.Checked == true)
				nupCanUsuarios.Text = "40";
			
			if(txtPrecioUnitario.Text != ""){
				if(cbForaneo.Checked == false)
					txtSueldoOperador.Text = ((rbCamion.Checked == true)? "180" : "130");
			}else
				txtSueldoOperador.Text = "0";
			
		}
		
		void CbRegresarlosCheckedChanged(object sender, EventArgs e)
		{
			txtPrecioUnitario.Text = "";
			if(cbLlevarlos.Checked == false)
				cbRegresarlos.Checked=false;			
		}
		
		void CbLlevarlosCheckedChanged(object sender, EventArgs e)
		{
			txtPrecioUnitario.Text = "";
			if(cbLlevarlos.Checked == false)
				cbRegresarlos.Checked=false;	
		}
		
		void NudCantidadtransporteLeave(object sender, EventArgs e)
		{
			calculaPrecioTotal();
		}
		
		void CbDiferenteCheckedChanged(object sender, EventArgs e)
		{
			if(cbDiferente.Checked == true){				
				txtPrecioDiferente.Visible = true;
				txtPrecioDiferente.Text = "";				
				txtPrecioDiferenteIVA.Text = "";		
				txtPrecioDiferenteIVA.Visible = true;
			}else{			
				txtPrecioDiferente.Visible = false;
				txtPrecioDiferente.Text = "";
				txtPrecioDiferenteIVA.Text = "";						
				txtPrecioDiferenteIVA.Visible = false;
			}
		}
		
		void TxtPrecioDiferenteTextChanged(object sender, EventArgs e)
		{
			if(txtPrecioDiferente.Text.Length > 0 && txtPrecioUnitario.Text.Length > 0 ){					
				calculaPrecioTotal();
			}else{
				txtPrecioDiferente.Text = "";
				txtPrecioDiferenteIVA.Text = "";
				calculaPrecioTotal();
			}
		}
		
		void CbForaneoCheckedChanged(object sender, EventArgs e)
		{
			if(cbForaneo.Checked == true){
				cbTipo.SelectedIndex = 1;
				if(txtKM.Text.Length > 0){
					Int32 parametro = Convert.ToInt32(connL.obtenerParametro(3));
						if(Convert.ToInt32(txtKM.Text) > parametro)
							cbTipo.SelectedIndex = 2;
						else
							cbTipo.SelectedIndex = 1;
				}
			}else{
				cbTipo.SelectedIndex = 0;
			}
			
			if(txtCasetas.Text == "")
				txtCasetas.Text = "";
			
			if(txtPrecioUnitario.Text != ""){
				if(cbForaneo.Checked == true){
					txtCasetas.Text=((txtCasetas.Text=="")?"0":txtCasetas.Text);
					txtSueldoOperador.Text = ((Convert.ToInt32(txtPrecioUnitario.Text) - Convert.ToInt32(txtCasetas.Text)) *.20).ToString();
				}else{					
					//txtSueldoOperador.Text = (Convert.ToInt32(txtPrecioUnitario.Text) *.10).ToString();
					txtSueldoOperador.Text = ((rbCamion.Checked == true)? "180" : "130");
				}
			}
			
		}
		
		void TxtKMTextChanged(object sender, EventArgs e)
		{		
			/*
			if(txtKM.Text.Length > 0){
				if(Convert.ToInt32(txtKM.Text) <= 20){
					cbTipo.SelectedIndex = 0;
					cbForaneo.Checked = false;
				}else{					
					cbForaneo.Checked = true;
				}
			}			
			*/
			if(cbForaneo.Checked == true){
				if(txtKM.Text.Length > 0){
					Int32 parametro = Convert.ToInt32(connL.obtenerParametro(3));
						if(Convert.ToInt32(txtKM.Text) > parametro)
							cbTipo.SelectedIndex = 2;
						else
							cbTipo.SelectedIndex = 1;						
				}
			}else{
				cbTipo.SelectedIndex = 0;
			}
			
		}
		
		void TxtUbicacionPartidaTextChanged(object sender, EventArgs e)
		{
			if(txtUbicacionPartida.Text.Length > 0)
			{
				if(txtUbicacionPartida.Text.Equals("GUADALAJARA"))
					cbDeCamino.Enabled = false;
				else
					cbDeCamino.Enabled = true;
			}
		}
		
		void TxtContactoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return"){
				if(txtContacto.Text.Length > 0 && txtCompañia.Focused == false){
					if(cambioFlujo == false && modifcarCotizacion == false && modifcarViaje == false){
						try{
							conn.getAbrirConexion("select CORREO, COMPANIA, TELEFONO, EXT, COMPANIA_NOMBRE, MEDIO_ENTERO from VIAJE_PROSPECTO_NUEVO where CONTACTO LIKE '%"+txtContacto.Text+"%'");
							conn.leer=conn.comando.ExecuteReader();
							if(conn.leer.Read()){			
								txtCorreo.Text = conn.leer["CORREO"].ToString();
								txtTelefono.Text = conn.leer["TELEFONO"].ToString();
								txtExt.Text = conn.leer["EXT"].ToString();
								cbComo.Text = conn.leer["MEDIO_ENTERO"].ToString();
							}else{
								txtCorreo.Text = "";
								txtTelefono.Text = "";
								txtExt.Text = "";
								cbComo.SelectedIndex = -1;
							}
							conn.conexion.Close();
						}catch(Exception ex){
							MessageBox.Show("ERROR AL OBTENER DATOS DEL CONTACTO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);				
							conn.conexion.Close();
						}
					}
				}
			obtenerFolio();				
			}
		}
		
		void TxtContactoTextChanged(object sender, EventArgs e)
		{
			if(txtContacto.Text.Length > 0 && txtCompañia.Focused == false){
				if(cambioFlujo == false && modifcarCotizacion == false && modifcarViaje == false){
					if(cbCompañia.Text == "PARTICULAR")
						txtCompañia.Text = txtContacto.Text;
				}
			}
		}		
		
		void TxtCompañiaTextChanged(object sender, EventArgs e)
		{/*
			
			if(txtCompañia.Text.Length > 0 && cbCompañia.Text != "PARTICULAR"){
				if(cambioFlujo == false && modifcarCotizacion == false && modifcarViaje == false){
					try{
						conn.getAbrirConexion("select CONTACTO from VIAJE_PROSPECTO_NUEVO where COMPANIA_NOMBRE  LIKE '%"+txtCompañia.Text+"%'");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()){						
							txtContacto.Text = conn.leer["CONTACTO"].ToString();								
						}else{
							txtContacto.Text = "";
						}
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("ERROR AL OBTENER DATOS DE LA COMPAÑIA: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);				
						conn.conexion.Close();
					}
				}
			}else{
				//txtContacto.Text = "";
			}
			*/
		}
		
		void DtpHoraSalidaValueChanged(object sender, EventArgs e)
		{			
			dtpHoraPlanton.Value = dtpHoraSalida.Value.AddMinutes(-30);		
		}
		
		#endregion		
				
		#region TIMER
		void Timer1Tick(object sender, EventArgs e)
		{	
			if(dgCotizacionesPendientes.Rows.Count > 0){
				try{
					string parametro = connL.obtenerParametro(1);
					TimeSpan dif;			
					for(int x=0; x<dgCotizacionesPendientes.Rows.Count; x++){
							dif = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")) - Convert.ToDateTime(dgCotizacionesPendientes.Rows[x].Cells[6].Value);
							dgCotizacionesPendientes[2,x].Value = dif.ToString();
							
							DateTime date1 = Convert.ToDateTime(dgCotizacionesPendientes.Rows[x].Cells[5].Value);
		 					DateTime date2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
		     				int result1 = DateTime.Compare(date1, date2);
		     				
		     				if(result1 == 0){
		     					string horas = dif.ToString();
		     						string cadena = dif.ToString();
									string[] datos = cadena.Split(':');
									int hora = Convert.ToInt16(datos[0]);
									if(Convert.ToDateTime(horas) >= Convert.ToDateTime(parametro) ){
		     							for(int y=0; y<dgCotizacionesPendientes.Columns.Count; y++){
											dgCotizacionesPendientes[y,x].Style.BackColor = Color.Red;
										}
									}else{
										for(int y=0; y<dgCotizacionesPendientes.Columns.Count; y++){
											dgCotizacionesPendientes[y,x].Style.BackColor = Color.White;
										}
									}
		     				}else{
		     					for(int y=0; y<dgCotizacionesPendientes.Columns.Count; y++){
										dgCotizacionesPendientes[y,x].Style.BackColor = Color.Red;
									}
		     					timer1.Stop();
		     				}
						}
				}catch(Exception ex){
					MessageBox.Show("Error en aviso de tiempo de cotizaciones pendientes: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					timer1.Stop();
				}	
			}else{
				timer1.Stop();
			}							
		}
		#endregion					
				
		#region EVENTOS DATAGRID
		void DgCotizacionesPendientesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				modifcarCotizacion = false;		
				modifcarViaje = false;
				cambioFlujo = true;
				dgCotizacionesRealizadas.ClearSelection();
				dgControlPRE.ClearSelection();
				limpiar();					
				obtenerDatosModificaCotizacion(Convert.ToInt16(dgCotizacionesPendientes[0,dgCotizacionesPendientes.CurrentRow.Index].Value));
				btnDuplicar.Enabled = true;	
				btnPendiente.Enabled = true;						
			}
		}
		
		void DgCotizacionesRealizadasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				modifcarViaje = false;	
				cambioFlujo = false;			
				modifcarCotizacion = true;		
				dgCotizacionesPendientes.ClearSelection();
				dgControlPRE.ClearSelection();
				limpiar();	
				obtenerDatosModificaCotizacion(Convert.ToInt16(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value));
				btnDuplicar.Enabled = true;
				
				if(txtBusquedaCotizacion.Text.Length < 1){
					string contacto = dgCotizacionesRealizadas[3,dgCotizacionesRealizadas.CurrentRow.Index].Value.ToString();
					cbcanceladosC.Checked = false;
					interruptor = true;
					filtros();			
					filtrosPrincipales();					
					limpiar();
					interruptor = true;
					cambioFlujo = false;
					modifcarCotizacion = false;
					validarViaje = false;
					modifcarViaje = false;
			
					cbBusquedaCotizacion.Text = "CONTACTO";
					txtBusquedaCotizacion.Text = contacto;
					dtpInicioCotizacion.Value = DateTime.Now.AddDays(-20);
					dtpFinCotizacion.Value = DateTime.Now.AddDays(20);
					
					cbBusquedaPRE.Text = "CONTACTO";
					txtBusquedaPRE.Text = contacto;
					dtpInicioPRE.Value = DateTime.Now.AddDays(-20);
					dtpFinPRE.Value = DateTime.Now.AddDays(20);
					/*
					for(int x=0; x<dgCotizacionesRealizadas.Rows.Count; x++){
						if(dgCotizacionesRealizadas[1,dgCotizacionesRealizadas.CurrentRow.Index].Style.BackColor =! "Red"){
							
						}
					}*/
				}
			}
		}
		
		void DgCotizacionesRealizadasCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{/*
			dgCotizacionesRealizadas.ClearSelection();
			if (e.Button == MouseButtons.Right){
			    if (e.RowIndex > -1){
			        this.dgCotizacionesRealizadas.Rows[e.RowIndex].Selected = true;
			      	cambioFlujo = false;
					dgCotizacionesPendientes.ClearSelection();
					limpiar();			
					modifcarCotizacion = true;			
					obtenerDatosModificaCotizacion(Convert.ToInt16(dgCotizacionesRealizadas[0, e.RowIndex].Value));						
				}           
        	}*/
		}
		#endregion		
		
		#region MODIFICACIONES
		public void obtenerDatosModificaCotizacion(int id_Viaje){
			string numero;
			try{
				conn.getAbrirConexion("select * from VIAJE_PROSPECTO_NUEVO where ID = "+id_Viaje);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
							numero= "01";				
						else if(conn.leer["NUMERO"].ToString().Length==1)
							numero= "0"+conn.leer["NUMERO"].ToString();
						else
							numero= conn.leer["NUMERO"].ToString();		
					
					txtFolio.Text = conn.leer["FOLIO"].ToString()+numero;
					txtContacto.Text = conn.leer["CONTACTO"].ToString();
					txtCorreo.Text = conn.leer["CORREO"].ToString();
					cbCompañia.Text = conn.leer["COMPANIA"].ToString();
					txtTelefono.Text = conn.leer["TELEFONO"].ToString();
					txtExt.Text = conn.leer["EXT"].ToString();					
					cbForaneo.Checked = ((conn.leer["FORANEO"].ToString()=="1")? true : false);
					txtEvento.Text = conn.leer["EVENTO"].ToString();
					txtDetalleEvento.Text = conn.leer["DETALLE"].ToString();
					cbTipo.Text = conn.leer["TIPO_CLIENTE"].ToString();
					txtKM.Text = conn.leer["KM_SERVICIO"].ToString();						
					if(conn.leer["TIPO_TRANSPOTE"].ToString()=="Camión" || conn.leer["TIPO_TRANSPOTE"].ToString()=="Camion" )
						rbCamion.Checked = true;
					else
						rbCamioneta.Checked = true;				
					nudCantidadtransporte.Text = conn.leer["CANTIDAD"].ToString();
					nupCanUsuarios.Text = conn.leer["USUARIOS"].ToString();					
					cbWC.Checked = ((conn.leer["BANIO"].ToString()=="1")? true : false);
					cbAireC.Checked = ((conn.leer["AC"].ToString()=="1")? true : false);
					cbTV.Checked = ((conn.leer["TV"].ToString()=="1")? true : false);
					cbEmpresarial.Checked = ((conn.leer["EMPRESARIAL"].ToString()=="1")? true : false);
					dtpFechaSalida.Value = Convert.ToDateTime(conn.leer["FECHA_SALIDA"]);					
					dtpHoraSalida.Text = conn.leer["HORA_SALIDA"].ToString().Substring(0,5);
					dtpFechaRegreso.Value = Convert.ToDateTime(conn.leer["FECHA_REGRESO"]);
					dtpHoraRegreso.Text = conn.leer["HORA_REGRESO"].ToString().Substring(0,5);
					dtpHoraPlanton.Text = conn.leer["HORA_PLANTON"].ToString().Substring(0,5);
					nudDias.Text = conn.leer["DIAS"].ToString();
					txtUbicacionPartida.Text = conn.leer["UBICACION_PARTIDA"].ToString();					
					cbDeCamino.Checked = ((conn.leer["DE_CAMINO"].ToString()=="1")? true : false);
					cbLlevarlos.Checked = ((conn.leer["LLEVARLOS"].ToString()=="1")? true : false);
					cbRegresarlos.Checked = ((conn.leer["REGRESARLOS"].ToString()=="1")? true : false);
					txtItinerarioAdicionales.Text = conn.leer["ITINERARIO"].ToString();
					txtKmItinerario.Text = conn.leer["KM_ITINERARIO"].ToString();
					txtCasetas.Text = conn.leer["CASETAS_SERVICIO"].ToString();
					txtPrecioCasetas.Text = conn.leer["CASETAS_ITINERARIO"].ToString();
					txtPrecioUnitario.Text = conn.leer["PRECIO_UNITARIO"].ToString();
					txtTotalSinIVA.Text = conn.leer["TOTAL"].ToString();
					txtNeto.Text = conn.leer["TOTAL_IVA"].ToString();
					cbFactura.Checked = ((conn.leer["FACTURA"].ToString()=="1")? true : false);
					txtTotalCasetas.Text = conn.leer["PRECIO_ITINERARIO"].ToString();
					txtSueldoOperador.Text = conn.leer["SUELDO_OPERADOR"].ToString();					
					txtCompañia.Text = conn.leer["COMPANIA_NOMBRE"].ToString();
					facturaValidacion = ((conn.leer["FACTURA"].ToString()=="1")? 1 : 0);					
					txtRazonSocial.Text = conn.leer["PRECIO_DIFERENTE"].ToString();		
					if(conn.leer["TOTAL_IVA"].ToString() != "")
						precioValidacion = Convert.ToDouble(conn.leer["TOTAL_IVA"]);
					
					if(conn.leer["PAGO_DIFERENTE"].ToString() == "1" ){
						cbDiferente.Checked = ((conn.leer["PAGO_DIFERENTE"].ToString()=="1")? true : false);
						if(conn.leer["PRECIO_DIFERENTE"].ToString().Length > 0)
							txtPrecioDiferente.Text = (Convert.ToDouble(conn.leer["PRECIO_DIFERENTE"]) / 1.16).ToString();
					}					
					if(conn.leer["FECHA_FACTURA"].ToString() != "")
						dtpFechaFactura.Text = conn.leer["FECHA_FACTURA"].ToString().Substring(0,5);			
								
					txtRuta.Text = conn.leer["LINK_RUTA"].ToString();
					cbComo.Text = conn.leer["MEDIO_ENTERO"].ToString();
					txtDiesel.Text = conn.leer["DIESEL_SERVICIO"].ToString();
					txtGastosOtros.Text = conn.leer["OTROS_SERVICIO"].ToString();
				}
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				conn.conexion.Close();				
			}			
		}
		#endregion				
		
		#region MENU CONTIZACION REALIZADAS		
		void SdfToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(modifcarCotizacion == true && dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Style.BackColor.Name != "Red" && dgCotizacionesRealizadas.SelectedRows.Count == 1 ){
				new Libro_Nuevo.Complementos_Libro.FormCambiarAcuerdo(this, Convert.ToInt16(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value)).ShowDialog();
			}
		}	

		void SdfToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(modifcarCotizacion == true){
				new Libro_Nuevo.Complementos_Libro.FormCancelacionCotizacion(this, Convert.ToInt16(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value)).ShowDialog();
				modifcarCotizacion = false;					
				limpiar();
			}				
		}		
		
		void FdToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(modifcarCotizacion == true){
				validarViaje = false;
				new Libro_Nuevo.Complementos_Libro.FormConfirmaServicio(this, Convert.ToInt32(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), txtContacto.Text, txtTelefono.Text).ShowDialog();						
				if(validarViaje == true){
					connL.actualizarProspecto((txtContacto.Text.Substring(0,3) + DateTime.Today.ToString("yyyy").Substring(3,1) + DateTime.Today.ToString("MMdd")), Convert.ToString(connL.obtenerNumero()), txtContacto.Text, txtCorreo.Text, cbCompañia.Text, txtTelefono.Text, txtExt.Text,((cbForaneo.Checked==true)?1:0).ToString(),txtEvento.Text, txtDetalleEvento.Text, cbTipo.Text, txtKM.Text,
													txtCasetas.Text, txtDiesel.Text, txtGastosOtros.Text, ((rbCamion.Checked==true)?"Camión":"Camioneta"),nudCantidadtransporte.Text,nupCanUsuarios.Text, ((cbWC.Checked==true)?1:0).ToString(), ((cbAireC.Checked==true)?1:0).ToString(), ((cbTV.Checked==true)?1:0).ToString(),
													dtpFechaSalida.Value.ToString("yyyy-MM-dd"), dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpFechaRegreso.Value.ToString("yyyy-MM-dd"), dtpHoraRegreso.Value.ToString("HH:mm:ss"),
													dtpHoraPlanton.Value.ToString("HH:mm:ss"), nudDias.Text, txtUbicacionPartida.Text,((cbDeCamino.Checked==true)?"1":"0"),((cbLlevarlos.Checked==true)?"1":"0"), ((cbRegresarlos.Checked==true)?"1":"0"),
													txtItinerarioAdicionales.Text, txtKmItinerario.Text, txtPrecioCasetas.Text, txtTotalCasetas.Text, txtSueldoOperador.Text, txtPrecioUnitario.Text, txtTotalSinIVA.Text, ((cbFactura.Checked==true)?"1":"0"),
													txtNeto.Text, "3", id_usuario.ToString(), Convert.ToString(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), ((cbDiferente.Checked==true)?"1":"0"), txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtCompañia.Text, txtRuta.Text, cbComo.Text, ((cbEmpresarial.Checked==true)?1:0).ToString());
					//new Libro_Nuevo.Complementos_Libro.FormConfirmaServicio(this, Convert.ToInt32(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), txtContacto.Text, txtTelefono.Text).ShowDialog();						
					Int64 id_re = connL.insertarViaje(nudCantidadtransporte.Text, dtpHoraSalida.Value.ToString("HH:mm:ss"), dtpHoraRegreso.Value.ToString("HH:mm:ss"), txtEvento.Text, txtKM.Text, txtSueldoOperador.Text, diasemana, ((cbForaneo.Checked==true)?1:0).ToString(), sentidoRuta(), Convert.ToInt32(dgCotizacionesRealizadas[0,dgCotizacionesRealizadas.CurrentRow.Index].Value), id_usuario, idClienteNuevo, razon_socialV, fecha_facturaV);
					modifcarCotizacion = false;
					new Libro_Nuevo.Pagos.FormControlPagos(this, id_re, "1").ShowDialog();						
					new Libro_Nuevo.Complementos_Libro.FormEnviarCorreo(this, txtCorreo.Text, txtEvento.Text, txtContacto.Text, id_re).ShowDialog();
					limpiar();
					filtros();
					filtrosPrincipales();
					idClienteNuevo = 0;
					idCotizacionNuevo = 0;
					limpiaAccion();
				}					
		      }			
		}
		#endregion													
				
		#region BOTONES EXTRAS
		void PbConfiguracionesClick(object sender, EventArgs e)
		{
			new Libro_Nuevo.Complementos_Libro.FormParametros(this).ShowDialog();		
		}
		
		void CmdValidacionClick(object sender, EventArgs e)
		{
			new Libro_Nuevo.Complementos_Libro.FormValidacionServicios(this).ShowDialog();		
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			new Libro_Nuevo.Pagos.FormContribuyentes(2).ShowDialog();		
		}			
		#endregion			
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////// ORDEN DE SERVICIO /////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				
		#region FILTROS
		public void filtrosPrincipales(){			
			String consulta = "";
			string campoFiltro = "";
			if(cbBusquedaPRE.Text == "DESTINO")
				campoFiltro ="EVENTO";
			else
				campoFiltro = cbBusquedaPRE.Text;			
					
			if(cbCanceladosPRE.Checked == true){
				consulta = @"select VPN.HORA_REGRESO, R.SALDO, R.CONF_CLIENTE, VPN.CONTACTO, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
									R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA
									from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where
									 RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and R.FECHA_SALIDA 
									 between '"+dtpInicioPRE.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFinPRE.Value.ToString("yyyy-MM-dd")+"' and RT.Sentido='Entrada' and VPN."+campoFiltro+" like '%"+txtBusquedaPRE.Text+"%'";											
							
			}else{
				consulta = @"select VPN.HORA_REGRESO, R.SALDO, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
									R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA
									from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where
									 RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and R.CONF_CLIENTE is null   and R.FECHA_SALIDA 
									 between '"+dtpInicioPRE.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFinPRE.Value.ToString("yyyy-MM-dd")+"' and RT.Sentido='Entrada' and r.estado = 'Activo' and VPN."+campoFiltro+" like '%"+txtBusquedaPRE.Text+"%'";	
				
						
			}
			if(consulta != ""){
				consulta = consulta +@" group by VPN.HORA_REGRESO,  R.SALDO, R.CONF_CLIENTE, VPN.CONTACTO, R.ID_RE, VPN.ID , VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
										R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado,  R.CONF_CLIENTE, R.ENCUESTA"; 			
				AdaptadorPrincipal(consulta);	
			}		
		}	
		#endregion		
		
		#region ADAPTADORES
		public void AdaptadorPrincipal(String Consulta){	
			contadorA = 0;
			string numero;			
			try{
				dgControlPRE.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{			
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();				
							 				
					dgControlPRE.Rows.Add(conn.leer["ID_RE"].ToString(),
 	                      						conn.leer["ID_COTIZACION"].ToString(),
					                      		conn.leer["FOLIO"].ToString()+numero,
					                      		conn.leer["destino"].ToString(),
					                      		conn.leer["CONTACTO"].ToString(),
						                        Convert.ToDateTime(conn.leer["fecha_salida"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Tipovehiculo"].ToString(),
						                        conn.leer["cant_unidades"].ToString(),     
												conn.leer["domicilio"].ToString(),
												conn.leer["TELEFONO_R"].ToString(),
												conn.leer["precio"].ToString(),
												conn.leer["FACTURADO"].ToString(),
												"",
												conn.leer["SALDO"].ToString(), // precio facturado		R.SALDO,										 
												"", // Datos factura
												conn.leer["anticipo"].ToString(),
												conn.leer["CompletoCamioneta"].ToString(),												 
												conn.leer["observaciones"].ToString(),
												conn.leer["correo"].ToString(),												 
						                        Convert.ToDateTime(conn.leer["fecha_regreso"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["HORA_REGRESO"].ToString().Substring(0,8),
						                        conn.leer["Estado_especial"].ToString(),
						                        conn.leer["ENCUESTA"].ToString());
										
					if(conn.leer["CONF_CLIENTE"].ToString().Length > 0)
					{
						for(int y=0; y<dgControlPRE.Columns.Count; y++)
						{
							dgControlPRE[y,contadorA].Style.BackColor=Color.LightGreen;
						}
					}	
					if(conn.leer["Estado_especial"].ToString().Equals("Cancelado"))
					{
						for(int y=0; y<dgControlPRE.Columns.Count; y++)
						{
							dgControlPRE[y,contadorA].Style.BackColor=Color.Red;
						}
					}
					if(conn.leer["FACTURADO"].ToString().Equals("0"))					
						dgControlPRE[12,contadorA].Value = "N/A";					
					if(conn.leer["FACTURADO"].ToString().Equals("1"))					
						dgControlPRE[12,contadorA].Value = "FACTURA";				
					if(conn.leer["FACTURADO"].ToString().Equals("2"))						
						dgControlPRE[12,contadorA].Value = "PROCESO";					
					if(conn.leer["FACTURADO"].ToString().Equals("3"))					
						dgControlPRE[12,contadorA].Value = "TIMBRADO";					
					
					if(interruptor == true){
						for(int y=0; y<dgControlPRE.Columns.Count; y++)
						{
							dgControlPRE[y,contadorA].Style.BackColor = Color.SteelBlue;
						}
					}
					contadorA++;					
				}
				
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los servicos PRE-ORDEN(error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				conn.conexion.Close();	
			}	
			dgControlPRE.ClearSelection();
			if(interruptor == false)
				avisoProgramacionPagos();
		}
		
		public void avisoProgramacionPagos(){
			try{
				string consulta = @"select  VPN.HORA_REGRESO, R.SALDO, PP.FECHA AS FECHA_PROGRAMADA, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades,
									R.domicilio, DS.TELEFONO_R, R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA
									from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS, PROGRAMACION_PAGOS PP where r.PAGADO = '0' and PP.ID_RE = R.ID_RE AND VPN.estado = 'Activo' AND
									RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and RT.Sentido='Entrada' and PP.FLUJO = '1' AND PP.FECHA between '2014-01-01' and '"+DateTime.Today.ToString("yyyy-MM-dd")
									+"' group by  VPN.HORA_REGRESO, R.SALDO, PP.FECHA, R.CONF_CLIENTE, VPN.CONTACTO, R.ID_RE, VPN.ID , VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable,  R.fecha_salida, "+
									" R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R, R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado,  R.CONF_CLIENTE, R.ENCUESTA ";			
				string numero;
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{			
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();				
							 				
					dgControlPRE.Rows.Add(conn.leer["ID_RE"].ToString(),
		                      						conn.leer["ID_COTIZACION"].ToString(),
					                      		conn.leer["FOLIO"].ToString()+numero,
					                      		conn.leer["destino"].ToString(),
					                      		conn.leer["CONTACTO"].ToString(),
						                        Convert.ToDateTime(conn.leer["fecha_salida"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Tipovehiculo"].ToString(),
						                        conn.leer["cant_unidades"].ToString(),     
												conn.leer["domicilio"].ToString(),
												conn.leer["TELEFONO_R"].ToString(),
												conn.leer["precio"].ToString(),
												conn.leer["FACTURADO"].ToString(),
												"",
												conn.leer["SALDO"].ToString(), // precio facturado
												"", // Datos factura
												conn.leer["anticipo"].ToString(),
												conn.leer["CompletoCamioneta"].ToString(),												 
												conn.leer["observaciones"].ToString(),
												conn.leer["correo"].ToString(),												 
						                        Convert.ToDateTime(conn.leer["fecha_regreso"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["HORA_REGRESO"].ToString().Substring(0,8),
												conn.leer["Estado_especial"].ToString(),
												conn.leer["ENCUESTA"].ToString()); 							
							for(int y=0; y<dgControlPRE.Columns.Count; y++){
								dgControlPRE[y,contadorA].Style.BackColor = Color.LightPink;
							}
					
							if(conn.leer["FACTURADO"].ToString().Equals("0"))					
								dgControlPRE[12,contadorA].Value = "N/A";					
							if(conn.leer["FACTURADO"].ToString().Equals("1"))					
								dgControlPRE[12,contadorA].Value = "FACTURA";				
							if(conn.leer["FACTURADO"].ToString().Equals("2"))						
								dgControlPRE[12,contadorA].Value = "PROCESO";					
							if(conn.leer["FACTURADO"].ToString().Equals("3"))					
								dgControlPRE[12,contadorA].Value = "TIMBRADO";		
						contadorA++;						
				}				
				conn.conexion.Close();		
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los pagos Programados (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				conn.conexion.Close();			
			}
			dgControlPRE.ClearSelection();	
		}
		#endregion
					
		#region MENU VIAJES	
		void MenuConfirmcacionServicioClick(object sender, EventArgs e)
		{
			if(modifcarViaje == true && dgControlPRE[0,dgControlPRE.CurrentRow.Index].Style.BackColor.Name != "Red"){
				if(connL.validarConfirmacion(Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value))){
					if(dgControlPRE.SelectedRows.Count < 2){
						new Libro_Nuevo.Complementos_Libro.FormConfirmarServicio(this, Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value), txtContacto.Text).ShowDialog();		
						limpiar();
						modifcarViaje = false;
						dgControlPRE.ClearSelection();
					}else{
						MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}else{
					MessageBox.Show("Este servicio ya esta confirmado", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
					limpiar();
					modifcarViaje = false;
					dgControlPRE.ClearSelection();
				}
			}else{
				MessageBox.Show("Este servicio no puede ser confirmado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void MenuRegistrarPagoClick(object sender, EventArgs e)
		{
			if(modifcarViaje == true){
				if(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Selected == true && dgControlPRE[0,dgControlPRE.CurrentRow.Index].Style.BackColor.Name != "Red"){
					if(dgControlPRE.SelectedRows.Count < 2){
						new Libro_Nuevo.Pagos.FormControlPagos(this, Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value), "2").ShowDialog();	
						limpiar();
						modifcarViaje = false;
						dgControlPRE.ClearSelection();						
					}else{
						MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
						limpiar();
						modifcarViaje = false;
						dgControlPRE.ClearSelection();	
					}
				}
			}
		}
				
		void MenuCancelacionPREClick(object sender, EventArgs e)
		{
			if(modifcarViaje == true &&  dgControlPRE[0,dgControlPRE.CurrentRow.Index].Style.BackColor.Name != "Red"){
				if(dgControlPRE.SelectedRows.Count < 2){					
						new Libro_Nuevo.Complementos_Libro.FormCancelacionCotizacion(this, Convert.ToInt16(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Value), Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value)).ShowDialog();
						limpiar();
						modifcarViaje = false;
						dgControlPRE.ClearSelection();
				}else{
					MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}		
			}			
		}
		
		void MenuImprimeContratoClick(object sender, EventArgs e)
		{
			if(modifcarViaje == true ){
				if(dgControlPRE.SelectedRows.Count < 2){
					PDFContrato();
					limpiar();
					modifcarViaje = false;
					dgControlPRE.ClearSelection();
				}else{
					MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		
		void MenuReenviarCorreoClick(object sender, EventArgs e)
		{
			if(modifcarViaje == true){
				if(dgControlPRE.SelectedRows.Count < 2){
					new Libro_Nuevo.Complementos_Libro.FormEnviarCorreo(this, txtCorreo.Text, txtEvento.Text, txtContacto.Text, Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value)).Show();	
					limpiar();
					modifcarViaje = false;
					dgControlPRE.ClearSelection();					
				}else{
					MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);		
				}
			}		
		}		
		
		void CambiarDetalleDeServicioToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(modifcarViaje == true){
				if(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Selected == true && dgControlPRE[0,dgControlPRE.CurrentRow.Index].Style.BackColor.Name != "Red")	{
					if(dgControlPRE.SelectedRows.Count < 2)	{
						new Libro_Nuevo.Complementos_Libro.FormConfirmaServicio(this, Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value), Convert.ToInt16(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Value), 1).ShowDialog();		
						limpiar();
						modifcarViaje = false;
						dgControlPRE.ClearSelection();
					}else{
						MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}
		
		void ReToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(modifcarCotizacion == true){
				new Libro_Nuevo.Complementos_Libro.FormEnviarCorreo(this, txtCorreo.Text, txtEvento.Text, txtContacto.Text, Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value)).ShowDialog();												
				limpiar();
			}				
		}						
		
		void ImprimirIncobrableToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(dgControlPRE.SelectedRows.Count == 1)
				PDFFormatoIncobrable();
		}
		#endregion						
		
		#region EVENTOS
		void LbCopeaFolioClick(object sender, EventArgs e)
		{
			if(txtFolio.Text.Length > 0){				
				Clipboard.Clear();
			 	Clipboard.SetDataObject(txtFolio.Text);
			}
		}
		
		void TxtRutaDoubleClick(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetDataObject(txtRuta.Text);
			txtRuta.SelectAll();
		}
		
		void TxtCompañiaEnter(object sender, EventArgs e)
		{
			txtCompañia.SelectAll();
		}
		
		void TxtContactoEnter(object sender, EventArgs e)
		{
			txtContacto.SelectAll();
		}
		
		void TxtCorreoEnter(object sender, EventArgs e)
		{
			txtCorreo.SelectAll();
		}
		
		void TxtTelefonoEnter(object sender, EventArgs e)
		{
			txtTelefono.SelectAll();
		}
		
		void TxtExtEnter(object sender, EventArgs e)
		{
			txtExt.SelectAll();
		}
		
		void CbBusquedaPRESelectedIndexChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false){
				if(cbBusquedaPRE.SelectedIndex == 1){
					txtBusquedaPRE.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CONTACTO from VIAJE_PROSPECTO_NUEVO", "CONTACTO");
		           	txtBusquedaPRE.AutoCompleteMode = AutoCompleteMode.Suggest;
		            txtBusquedaPRE.AutoCompleteSource = AutoCompleteSource.CustomSource;  
				}
				if(cbBusquedaPRE.SelectedIndex == 2){
					txtBusquedaPRE.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CORREO from VIAJE_PROSPECTO_NUEVO", "CORREO");
		           	txtBusquedaPRE.AutoCompleteMode = AutoCompleteMode.Suggest;
		            txtBusquedaPRE.AutoCompleteSource = AutoCompleteSource.CustomSource;  
				}
				if(cbBusquedaPRE.SelectedIndex == 3){
					txtBusquedaPRE.AutoCompleteCustomSource = auto.AutocompleteGeneral("select EVENTO from VIAJE_PROSPECTO_NUEVO", "EVENTO");
		           	txtBusquedaPRE.AutoCompleteMode = AutoCompleteMode.Suggest;
		            txtBusquedaPRE.AutoCompleteSource = AutoCompleteSource.CustomSource;  
				}
				filtrosPrincipales();
			}
		}	
		
		void DtpInicioPREValueChanged(object sender, EventArgs e)
		{
			dtpFinPRE.Value = dtpInicioPRE.Value;
		}
		
		void DtpFinPREValueChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosPrincipales();	
		}		
		
		void TxtBusquedaPRETextChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosPrincipales();
		}
		
		void CbCanceladosPRECheckedChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosPrincipales();		
		}
		#endregion
		
		#region EVENTOS DATAGRID
		void DgControlPRECellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{/*
			dgControlPRE.ClearSelection();
			if (e.Button == MouseButtons.Right){
			        if (e.RowIndex > -1){
						//limpiar();	
			            this.dgControlPRE.Rows[e.RowIndex].Selected = true;
			         	//modifcarViaje = true;
						//btnGuardar.Enabled = false;				
						//obtenerDatosModificaCotizacion(Convert.ToInt16(dgControlPRE[1, e.RowIndex].Value));	
						this.dgControlPRE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgControlPRECellClick);	
					}           
        	}*/
		}
		
		void DgControlPRECellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				limpiar();			
				modifcarViaje = true;				
				cambioFlujo = false;
				modifcarCotizacion = false;			
				btnGuardar.Enabled = false;	
				obtenerDatosModificaCotizacion(Convert.ToInt16(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Value));
				validaCambioFactura = Convert.ToInt32(dgControlPRE[11,dgControlPRE.CurrentRow.Index].Value);

				dgCotizacionesPendientes.ClearSelection();
				dgCotizacionesRealizadas.ClearSelection();				
			}
		}		
		
		void DgControlPREDoubleClick(object sender, EventArgs e)
		{
			if(modifcarViaje == true){
				if(dgControlPRE[1,dgControlPRE.CurrentRow.Index].Selected == true && dgControlPRE[1,dgControlPRE.CurrentRow.Index].Style.BackColor.Name == "LightPink"){
					if(dgControlPRE.SelectedRows.Count < 2){
						new Libro_Nuevo.Pagos.FormControlPagos(this, Convert.ToInt16(dgControlPRE[0,dgControlPRE.CurrentRow.Index].Value), "2").ShowDialog();	
						limpiar();
						modifcarViaje = false;
						dgControlPRE.ClearSelection();						
					}else{
						MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}
		#endregion		
		
		#region METODOS		
		public void enviaAvisoProgramacionPago(){		
			DateTime DiaSemanaFacturacion;
			String DiaFacturacion = "";
			DiaSemanaFacturacion = DateTime.Now;
			DiaFacturacion = DiaSemanaFacturacion.DayOfWeek.ToString();								
			int dia = 1;	
				if(DiaFacturacion == "Saturday")									
					dia = 2;					
								
			string consulta = "SELECT * FROM PROGRAMACION_PAGOS WHERE FECHA between '2015-06-01' and '"+DateTime.Now.AddDays(dia).ToString("yyyy/MM/dd")+"' and FLUJO != '2'  and ID NOT IN (SELECT id_programacion FROM ENVIA_AVISOS_PAGOS)";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				MessageBox.Show("programacion enviada: "+conn.leer["ID"]);
			}
			conn.conexion.Close();
		}
		
		void PDFFormatoIncobrable()
		{
			string idCliente = "0", cliente = "", destino = "", responsable = "", telefono = "", domicilio = "", Fecha = "", NumHoraPlanton = "", NumMinPlanton = "", 
					NumHoraRegreso = "", NumMinRegreso = "", NumUnidad = "", nudPasajeros = "", Colonia = "", Cruces = "", Saldo = "", Anticipos = "", Precio = "",
					FechaRegreso = "", Observaciones = "", consulta = "";
				
			try{
				consulta = @"select R.ID_C, C.Nombre, responsable as Responsable, R.fecha_salida, R.cant_unidades, R.domicilio, R.destino, R.precio, C.Telefono As Telefono, R.h_planton,
				R.observaciones, R.fecha_regreso, R.anticipo, CL.Rumbo, CL.Estado, R.SALDO, R.cantidad_usuarios	from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where 
				R.ID_C=C.idCliente and R.ID_C=CL.ID and R.ID_RE ='"+dgControlPRE[0, dgControlPRE.CurrentRow.Index].Value.ToString()+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					idCliente = conn.leer["ID_C"].ToString();
					cliente = conn.leer["Nombre"].ToString();
					responsable = conn.leer["Responsable"].ToString();				
					Fecha = conn.leer["fecha_salida"].ToString();
					NumUnidad = conn.leer["cant_unidades"].ToString();
					domicilio = conn.leer["domicilio"].ToString();
					destino = conn.leer["destino"].ToString();
					Precio = conn.leer["precio"].ToString();
					telefono = conn.leer["Telefono"].ToString();
					Observaciones = conn.leer["observaciones"].ToString();
					FechaRegreso = conn.leer["fecha_regreso"].ToString().Substring(0,10);
					Anticipos = conn.leer["anticipo"].ToString();				
					Cruces = conn.leer["Rumbo"].ToString();
					Colonia = conn.leer["Estado"].ToString();
					nudPasajeros = conn.leer["cantidad_usuarios"].ToString();
					NumHoraPlanton = conn.leer["h_planton"].ToString().Substring(0,2);
					NumMinPlanton = conn.leer["h_planton"].ToString().Substring(3,2);
					Saldo = conn.leer["SALDO"].ToString();
				}
				conn.conexion.Close();				
			}catch(Exception ex){				
				MessageBox.Show(ex.Message);
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			try{
				consulta = "select HoraInicio from RUTA WHERE Sentido='Salida' and IdSubEmpresa='"+idCliente+"'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					NumHoraRegreso = conn.leer["HoraInicio"].ToString().Substring(0,2);
					NumMinRegreso = conn.leer["HoraInicio"].ToString().Substring(3,2);
				}
				conn.conexion.Close();
			}catch(Exception ex){				
				MessageBox.Show(ex.Message);
				if(conn.conexion != null)
					conn.conexion.Close();
			}				
				
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Formato Precios "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Formato precios "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+cliente+ " " +destino+".pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				FormatoPdf.FormatoFormatoPrecios2(doc, writer, responsable, telefono, domicilio, destino, Fecha.Substring(0,10), NumHoraPlanton+":"+NumMinPlanton+" hrs", NumHoraRegreso+":"+NumMinRegreso+" hrs", 
				                                  NumUnidad, nudPasajeros, Colonia, Cruces, Saldo, Anticipos, Precio, FechaRegreso.Substring(0,10), cliente, Observaciones, dgControlPRE[0, dgControlPRE.CurrentRow.Index].Value.ToString());
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Formato precios "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+cliente+ " " +destino+".pdf"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////// IMPRESIÓN DE CONTRATO //////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region FILTROS
		public void filtrosImprimir(){
		String consulta = "";
		string campoFiltro = "";
			if(cmbImpresion.Text == "DESTINO")
				campoFiltro ="EVENTO";
			else
				campoFiltro = cmbImpresion.Text;			
			
			if(cbImpresos.Checked == true){
				consulta = @"select R.SALDO, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
							R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA
							from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where 
							RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and RT.Sentido='Entrada' and r.estado = 'Activo' and R.CONF_CLIENTE is not null 
							and R.estado = 'Activo' and  R.FECHA_SALIDA between '"+dtpInicioImpresion.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFinImpresion.Value.ToString("yyyy-MM-dd")+"' and VPN."+campoFiltro+" like '%"+txtImpresion.Text+"%'";
							
			}else{
				consulta = @"select R.SALDO, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
							R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA
							from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where
							RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and R.estado = 'Activo' and  RT.Sentido='Entrada' and r.estado = 'Activo' and R.CONF_CLIENTE is not null AND r.ID_RE NOT IN(SELECT ID_RE FROM CONTROL_IMPRESION_CONTRATOS )
							and VPN."+campoFiltro+" like '%"+txtImpresion.Text+"%'";
							
						
			}
		
			if(consulta != ""){
				if(cbLocales.Checked == false)
					consulta = consulta + " and VPN.foraneo = '1'"; 
						
				consulta = consulta +@" group by  R.SALDO, R.CONF_CLIENTE, VPN.CONTACTO, R.ID_RE, VPN.ID , VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
										R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado,  R.CONF_CLIENTE, R.ENCUESTA"; 			
				AdaptadorImpresion(consulta);	
				ValidarImpresion();		//color de que ya se imprimieron

			dgImpresion.ClearSelection();						
			}		
		}
		#endregion
		
		#region ADAPTADOR
		public void AdaptadorImpresion(String Consulta){	
		int contador = 0;
		string numero;			
			try{
				dgImpresion.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{			
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();				
							 				
					dgImpresion.Rows.Add(conn.leer["ID_RE"].ToString(),
 	                      						conn.leer["ID_COTIZACION"].ToString(),
					                      		conn.leer["FOLIO"].ToString()+numero,
					                      		conn.leer["destino"].ToString(),
					                      		conn.leer["CONTACTO"].ToString(),
						                        Convert.ToDateTime(conn.leer["fecha_salida"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Tipovehiculo"].ToString(),
						                        conn.leer["cant_unidades"].ToString(),     
												conn.leer["domicilio"].ToString(),
												conn.leer["TELEFONO_R"].ToString(),
												conn.leer["precio"].ToString(),
												conn.leer["FACTURADO"].ToString(),
												conn.leer["SALDO"].ToString(),								 
												"", // Datos factura
												conn.leer["anticipo"].ToString(),
												conn.leer["CompletoCamioneta"].ToString(),												 
												conn.leer["observaciones"].ToString(),
												conn.leer["correo"].ToString(),												 
						                        Convert.ToDateTime(conn.leer["fecha_regreso"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Estado_especial"].ToString(),
						                        conn.leer["ENCUESTA"].ToString());
					if(conn.leer["Estado_especial"].ToString().Equals("Cancelado"))
					{
						for(int y=0; y<dgImpresion.Columns.Count; y++)
						{
							dgImpresion[y,contador].Style.BackColor=Color.Red;
						}
					}					
					contador++;					
				}				
				conn.conexion.Close();
				
				if(dgImpresion.Rows.Count > 0 && cbImpresos.Checked == false){
					lblAvisoImpresion.Visible = true;
				}else{					
					lblAvisoImpresion.Visible = false;
				}
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los servicios para imprimir (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				conn.conexion.Close();	
			}			
		}
		#endregion
		
		#region MENU
		void MenuImprimirIClick(object sender, EventArgs e)
		{			
			if(dgImpresion.SelectedRows.Count  > 0){
				if(dgImpresion.SelectedRows.Count < 2){
					PDFContrato();
					filtrosImprimir();
				}else{
					MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}			
		}
					
		void MenuRegistrarpagoIClick(object sender, EventArgs e)
		{
			if(dgImpresion[1,dgImpresion.CurrentRow.Index].Selected == true && dgImpresion[0,dgImpresion.CurrentRow.Index].Style.BackColor.Name != "Red"){
				if(dgImpresion.SelectedRows.Count < 2){
					new Libro_Nuevo.Pagos.FormControlPagos(this, Convert.ToInt16(dgImpresion[0,dgImpresion.CurrentRow.Index].Value), "2").ShowDialog();	
					dgImpresion.ClearSelection();						
				}else{
					MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgImpresion.ClearSelection();	
				}
			}			
		}				
		#endregion
		
		#region METODOS	
		void PDFContrato()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
	        string contacto = dgImpresion[4,dgImpresion.CurrentRow.Index].Value.ToString();
	        string destino = dgImpresion[3,dgImpresion.CurrentRow.Index].Value.ToString();
			try
			{		
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+contacto + " " + destino +".pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				FormatoPdf.FormatoContratoVentas2(doc, writer, Convert.ToInt16(dgImpresion[0,dgImpresion.CurrentRow.Index].Value));
		        doc.Close();
		        
		        if(!connL.validarImpresion(dgImpresion[0,dgImpresion.CurrentRow.Index].Value.ToString()))
		        	connL.insertarImpresion(dgImpresion[0,dgImpresion.CurrentRow.Index].Value.ToString(), id_usuario.ToString());
		        else
		        	connL.actualizarImpresion(dgImpresion[0,dgImpresion.CurrentRow.Index].Value.ToString());
		        	
		        
		        SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
				f.Serial = "XXXXX";
				f.OpenPdf(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+contacto + " " + destino +".pdf");
				if (f.PageCount > 0)
				{
					//f.ImageOptions.Dpi = 200;
					//f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
					//for (int page = 1; page <= f.PageCount; page++)
						//f.ToImage(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+contacto + " " + destino +".jpg", page);
					//Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+contacto + " " + destino+".jpg"));
					Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+contacto + " " + destino +".pdf");
				}
				/* recortar
				Rectangle cropRect = new Rectangle(0,10,120,120);
				Bitmap src = Image.FromFile(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+contacto + " " + destino +".jpg") as Bitmap;
				Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
				
				using(Graphics g = Graphics.FromImage(target))
				{
				   g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
				}
				*/
				
				/*
	        	try{
                	System.IO.File.Delete(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName +
	        	                       @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtContacto.Text + " " + txtEvento.Text+".pdf");  				
           		}catch (System.IO.IOException e){
					MessageBox.Show("Error al eliminar: "+e.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
          		}
				 */
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al crear el contrato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void ValidarImpresion()
		{
			for(int x=0; x<dgImpresion.Rows.Count; x++)
			{
				String conss = "select ID_RE from CONTROL_IMPRESION_CONTRATOS where ID_RE = "+dgImpresion[0,x].Value.ToString();
				conn.getAbrirConexion(conss);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					for(int y=0; y<dgImpresion.Columns.Count; y++){
						dgImpresion[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
				conn.conexion.Close();
			}	
		}
	
		#endregion
		
		#region EVENTOS
		void DgImpresionCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgImpresion.SelectedRows.Count == 1){
				PDFContrato();
				filtrosImprimir();
			}	
		}
		
		void CmbImpresionSelectedIndexChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosImprimir();
		}
		
		void TxtImpresionTextChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosImprimir();
		}
		
		void DtpInicioImpresionValueChanged(object sender, EventArgs e)
		{
			dtpFinImpresion.Value = dtpInicioImpresion.Value;
		}
		
		void DtpFinImpresionValueChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosImprimir();
		}
		
		void CbImpresosCheckedChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosImprimir();
		}
		
		void CbLocalesCheckedChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosImprimir();
		}
		#endregion
		
		#region EVENTOS DATAGRIDVIEW
		void DgImpresionCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{/*
			dgImpresion.ClearSelection();
			if (e.Button == MouseButtons.Right){
			      if (e.RowIndex > -1)
			         this.dgImpresion.Rows[e.RowIndex].Selected = true;	
        	}*/
		}
		#endregion
			
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////// ORDEN DE FACTURA /////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				
		#region FILTROS		
		////////////////////////////////////////////////// SIN ORDEN DE FACTURA ////////////////////////////////////////////////////
		public void filtrosSinOrden(){
			int parametro = Convert.ToInt16(connL.obtenerParametro1(4));
			string fecha = DateTime.Now.AddDays(parametro).ToString("yyyy-MM-dd");
			String consulta = "";
			string campoFiltro = "";
			if(cmbBusquedaSinOrden.Text == "DESTINO")
				campoFiltro ="EVENTO";
			else
				campoFiltro = cmbBusquedaSinOrden.Text;			
			
			if(cbSinOrden.Checked == false){
				consulta = @"select R.SALDO, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, VPN.PRECIO_DIFERENTE,
							R.domicilio, DS.TELEFONO_R,	R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA, VPN.FECHA_FACTURA
							from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  
							and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and RT.Sentido='Entrada' and r.FACTURADO = '1' and R.estado = 'Activo' and  VPN.FECHA_FACTURA between '2012-01-01' and '"+fecha+"' ";								
			}else{
				consulta = @"select R.SALDO, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, VPN.PRECIO_DIFERENTE,
							R.domicilio, DS.TELEFONO_R,	R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA, VPN.FECHA_FACTURA
							from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  
							and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and RT.Sentido='Entrada'  and r.FACTURADO != '0' and R.estado = 'Activo' and  VPN.FECHA_FACTURA between 
							'"+dtpInicioSinOrden.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFinSinOrden.Value.ToString("yyyy-MM-dd")+"' and VPN."+campoFiltro+" like '%"+txtBusquedaSinOrdem.Text+"%' ";
			}
			if(consulta != ""){
				consulta = consulta +@" group by R.SALDO, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable,  R.fecha_salida, R.Tipovehiculo, R.cant_unidades, VPN.PRECIO_DIFERENTE, R.domicilio, DS.TELEFONO_R,	
										R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado,  R.CONF_CLIENTE, R.ENCUESTA, VPN.FECHA_FACTURA"; 
				AdaptadorSinOrden(consulta);	
			}	
			dgSinOrden.ClearSelection();					
		}	
		
		////////////////////////////////////////////////// CON ORDEN DE FACTURA ////////////////////////////////////////////////////
		public void filtrosOrden(){
			int parametro = Convert.ToInt16(connL.obtenerParametro1(4));
			string fecha = DateTime.Now.AddDays(parametro).ToString("yyyy-MM-dd");
			String consulta = "";
			string campoFiltro = "";
			if(cmbBusquedaOrdenFactura.Text == "DESTINO")
				campoFiltro ="EVENTO";
			else
				campoFiltro = cmbBusquedaOrdenFactura.Text;	
			
			if(cbEliminadasOrdenFactura.Checked == false){
				consulta = @"select o.FACTURA, o.ID, o.ID_RES, o.FECHAS, o.IMPORTE, o.IVA, o.TOTAL, o.VEHICULO, o.CANTIDAD_VEHICULO, o.FORMA_FACTURACION, o.ESTATUS, o.FLUJO, fre.ID_FACTURA,
							o.RFC_CLIENTE, o.CONTRIBUYENTE, o.OBSERVACIONES, o.ORDEN_COMPRA, FORMA_FACTURACION 
							from ORDEN_FACTURA o, FACTURA_RUTA_ESPECIAL fre, RUTA_ESPECIAL re, VIAJE_PROSPECTO_NUEVO vpn where o.ESTATUS = 1 and o.FLUJO = 1 and o.ID = fre.ID_FACTURA and fre.ID_RE = re.ID_RE and re.ID_RE = vpn.ID_RE and
							vpn.FECHA_FACTURA between '2012-01-01' AND '"+fecha+"' ";								
			}else{
				consulta = @"select o.FACTURA, o.ID, o.ID_RES, o.FECHAS, o.IMPORTE, o.IVA, o.TOTAL, o.VEHICULO, o.CANTIDAD_VEHICULO, o.FORMA_FACTURACION, o.ESTATUS, o.FLUJO, fre.ID_FACTURA,
							o.RFC_CLIENTE, o.CONTRIBUYENTE, o.OBSERVACIONES, o.ORDEN_COMPRA, FORMA_FACTURACION 
							from ORDEN_FACTURA o, FACTURA_RUTA_ESPECIAL fre, RUTA_ESPECIAL re, VIAJE_PROSPECTO_NUEVO vpn where o.ID = fre.ID_FACTURA and fre.ID_RE = re.ID_RE and re.ID_RE = vpn.ID_RE and
							vpn.FECHA_FACTURA between '"+dtpInicioOrdenFactura.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFinOrdenFactura.Value.ToString("yyyy-MM-dd")+"' and VPN."+campoFiltro+" like '%"+txtBusquedaOrdenFactura.Text+"%'";
			}
			if(consulta != ""){
				consulta = consulta +@"group by o.FACTURA, o.ID, o.ID_RES, o.FECHAS, o.IMPORTE, o.IVA, o.TOTAL, o.VEHICULO, o.CANTIDAD_VEHICULO, o.FORMA_FACTURACION, o.ESTATUS, o.FLUJO, fre.ID_FACTURA,
									o.RFC_CLIENTE, o.CONTRIBUYENTE, o.OBSERVACIONES, o.ORDEN_COMPRA, FORMA_FACTURACION "; 
				AdaptadorOrdenFactura(consulta);	
			}						
		}				
		#endregion
		
		#region ADAPTADOR		
		////////////////////////////////////////////////// SIN ORDEN DE FACTURA ////////////////////////////////////////////////////
		public void AdaptadorSinOrden(String consultaSO){				
			string numero;
			int contador = 0;	
			try{
				dgSinOrden.Rows.Clear();	
				conn.getAbrirConexion(consultaSO);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{			
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();	
					
					dgSinOrden.Rows.Add(conn.leer["ID_RE"].ToString(),
 	                      						conn.leer["ID_COTIZACION"].ToString(),
					                      		conn.leer["FOLIO"].ToString()+numero,
					                      		Convert.ToDateTime(conn.leer["FECHA_FACTURA"].ToString().Substring(0,10)).ToShortDateString(),
					                      		conn.leer["destino"].ToString(),
					                      		conn.leer["CONTACTO"].ToString(),
						                        Convert.ToDateTime(conn.leer["fecha_salida"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Tipovehiculo"].ToString(),
						                        conn.leer["cant_unidades"].ToString(),     
												conn.leer["domicilio"].ToString(),
												conn.leer["TELEFONO_R"].ToString(),
												conn.leer["precio"].ToString(),
												conn.leer["FACTURADO"].ToString(),
												conn.leer["SALDO"].ToString(),
												conn.leer["PRECIO_DIFERENTE"].ToString(), // Datos factura
												conn.leer["anticipo"].ToString(),
												conn.leer["CompletoCamioneta"].ToString(),												 
												conn.leer["observaciones"].ToString(),
												conn.leer["correo"].ToString(),												 
						                        Convert.ToDateTime(conn.leer["fecha_regreso"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Estado_especial"].ToString(),
						                        conn.leer["ENCUESTA"].ToString());	
						if(conn.leer["FACTURADO"].ToString() == "2"){
							for(int y=0; y<dgSinOrden.Columns.Count; y++){
								dgSinOrden[y,contador].Style.BackColor = Color.LightGreen;
							}
						}
						if(conn.leer["FACTURADO"].ToString() == "3"){
							for(int y=0; y<dgSinOrden.Columns.Count; y++){
								dgSinOrden[y,contador].Style.BackColor = Color.LightGreen;
							}
						}							                        
					contador++;														                        
				}				
				conn.conexion.Close();
				if(dgSinOrden.Rows.Count > 0 && cbSinOrden.Checked == false){
					lblAvisoOrdenF.Visible = true;
				}else{					
					lblAvisoOrdenF.Visible = false;
				}				
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los servicios sin  orden de factura (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
		}
		
		////////////////////////////////////////////////// CON ORDEN DE FACTURA ////////////////////////////////////////////////////
		public void AdaptadorOrdenFactura(string consulta){	
			int contador = 0;			
			try{
				dgOrdenFactura.Rows.Clear();	
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{		 				
					dgOrdenFactura.Rows.Add(conn.leer["ID"].ToString(),
 	                      					conn.leer["ID_RES"].ToString(),
	                      					Convert.ToDateTime(conn.leer["FECHAS"].ToString().Substring(0,5)).ToShortDateString(),
				                      		"",
				                      		conn.leer["VEHICULO"].ToString(),
					                        conn.leer["CANTIDAD_VEHICULO"].ToString(),
					                        conn.leer["IMPORTE"].ToString(),     
											conn.leer["IVA"].ToString(),
											conn.leer["TOTAL"].ToString(),
											conn.leer["RFC_CLIENTE"].ToString(),
											conn.leer["CONTRIBUYENTE"].ToString(),
											conn.leer["OBSERVACIONES"].ToString(),
											conn.leer["ORDEN_COMPRA"].ToString(),												 
											conn.leer["FACTURA"].ToString());	
				if(conn.leer["ESTATUS"].ToString().Equals("0")){
						for(int y=0; y<dgOrdenFactura.Columns.Count; y++){
							dgOrdenFactura[y,contador].Style.BackColor = Color.Red;
						}
					}
										
				if(conn.leer["ESTATUS"].ToString().Equals("-1")){
						for(int y=0; y<dgOrdenFactura.Columns.Count; y++){
							dgOrdenFactura[y,contador].Style.BackColor = Color.LightPink;
						}
					}
				if(conn.leer["FLUJO"].ToString().Equals("2")  && conn.leer["ESTATUS"].ToString().Equals("1")){
						for(int y=0; y<dgOrdenFactura.Columns.Count; y++){
							dgOrdenFactura[y,contador].Style.BackColor = Color.LightGreen;
						}
					}					
					contador++;	
				}					
				conn.conexion.Close();		
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las ordenes de facturas  (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);	
			}finally{				
				conn.conexion.Close();	
			}
			dgOrdenFactura.ClearSelection();
		}		
		#endregion
		
		#region MENU		
		////////////////////////////////////////////////// SIN ORDEN DE FACTURA ////////////////////////////////////////////////////
		void MenuOrdenFacturaOFClick(object sender, EventArgs e)
		{
			if(validacionOrdenFactura()){
				new FormOrdenFactura(this, id_usuario.ToString()).ShowDialog();
			}else{
				MessageBox.Show("Lo sentimos no puedes seleccionar un registro que no está especificado como factura o seleccionaste un aviso de pago programado", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void MenuRegistrarPagoOFClick(object sender, EventArgs e)
		{
			if(dgSinOrden[1,dgSinOrden.CurrentRow.Index].Selected == true && dgSinOrden[0,dgSinOrden.CurrentRow.Index].Style.BackColor.Name != "Red"){
				if(dgSinOrden.SelectedRows.Count < 2){
					new Libro_Nuevo.Pagos.FormControlPagos(this, Convert.ToInt16(dgSinOrden[0,dgSinOrden.CurrentRow.Index].Value), "2").ShowDialog();	
					dgSinOrden.ClearSelection();						
				}else{
					MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgSinOrden.ClearSelection();	
				}
			}
		}
		
		void MenuCancelarOFClick(object sender, EventArgs e)
		{
			if(dgSinOrden[0,dgSinOrden.CurrentRow.Index].Style.BackColor.Name != "Red"){
				if(dgSinOrden.SelectedRows.Count < 2){					
					DialogResult respuesta = MessageBox.Show("¿Deseas Eliminar este servicio ? " + dgSinOrden[0,dgSinOrden.CurrentRow.Index].Value.ToString() , "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
						if(respuesta == DialogResult.Yes)
							new Libro_Nuevo.Complementos_Libro.FormCancelacionCotizacion(this, Convert.ToInt16(dgSinOrden[1,dgSinOrden.CurrentRow.Index].Value), Convert.ToInt16(dgSinOrden[0,dgSinOrden.CurrentRow.Index].Value)).ShowDialog();
							dgSinOrden.ClearSelection();
				}else{
					MessageBox.Show("Lo sentimos no puedes seleccionar más de un registro para esta opción", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}		
			}	
		}		
		////////////////////////////////////////////////// CON ORDEN DE FACTURA ////////////////////////////////////////////////////
		void MenuCancelaFClick(object sender, EventArgs e)
		{
			if(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Selected == true && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "Red"
			   && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "LightPink" && (principal.lblDatoNivel.Text == "GERENCIAL" || principal.lblDatoNivel.Text == "MASTER")){
				DialogResult respuesta = MessageBox.Show("¿Deseas Eliminar la factura ? " + dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString() , "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(respuesta == DialogResult.Yes){
					connL.EliminarFactura1(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString(), dgOrdenFactura[1,dgOrdenFactura.CurrentRow.Index].Value.ToString(), id_usuario.ToString());
					filtrosOrden();
					filtrosSinOrden();
					filtrosPrincipales();
				}else{
					dgOrdenFactura.ClearSelection();
				}
			   }else{
			   		MessageBox.Show("Lo sentimos no tienes los permisos necesarios para eliminar la factura, llama al gerente.", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			   }
		}
		#endregion
		
		#region METODOS		
		////////////////////////////////////////////////// SIN ORDEN DE FACTURA ////////////////////////////////////////////////////
		public bool validacionOrdenFactura(){
			bool respuesta = true;
			for(int i = 0; i < dgSinOrden.RowCount; i++){
				if( dgSinOrden[1,i].Selected == true){
					if(dgSinOrden[11,i].Value.ToString() == "0" )
						respuesta = false;
					if(dgSinOrden[0,i].Style.BackColor.Name == "LightPink")
						respuesta = false;
					if(dgSinOrden[0,i].Style.BackColor.Name == "LightGreen")
						respuesta = false;
				}
			}
			return respuesta;
		}
		
		////////////////////////////////////////////////// CON ORDEN DE FACTURA ////////////////////////////////////////////////////
		
		#endregion
		
		#region EVENTOS		
		////////////////////////////////////////////////// SIN ORDEN DE FACTURA ////////////////////////////////////////////////////
		void DgSinOrdenCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(validacionOrdenFactura()){
				new FormOrdenFactura(this, id_usuario.ToString()).ShowDialog();
			}else{
				MessageBox.Show("Lo sentimos no puedes seleccionar un registro que no está especificado como factura o seleccionaste un aviso de pago programado", "Aviso Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void DtpInicioSinOrdenValueChanged(object sender, EventArgs e)
		{			
			dtpFinSinOrden.Value = dtpInicioSinOrden.Value;
		}
		
		void DtpFinSinOrdenValueChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosSinOrden();
		}
		
		void CmbBusquedaSinOrdenSelectedIndexChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false){
				if(cmbBusquedaSinOrden.SelectedIndex == 1){
					txtBusquedaSinOrdem.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CONTACTO from VIAJE_PROSPECTO_NUEVO", "CONTACTO");
		           	txtBusquedaSinOrdem.AutoCompleteMode = AutoCompleteMode.Suggest;
		            txtBusquedaSinOrdem.AutoCompleteSource = AutoCompleteSource.CustomSource;  
				}
				if(cmbBusquedaSinOrden.SelectedIndex == 2){
					txtBusquedaSinOrdem.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CORREO from VIAJE_PROSPECTO_NUEVO", "CORREO");
		           	txtBusquedaSinOrdem.AutoCompleteMode = AutoCompleteMode.Suggest;
		            txtBusquedaSinOrdem.AutoCompleteSource = AutoCompleteSource.CustomSource;  
				}
				if(cmbBusquedaSinOrden.SelectedIndex == 3){
					txtBusquedaSinOrdem.AutoCompleteCustomSource = auto.AutocompleteGeneral("select EVENTO from VIAJE_PROSPECTO_NUEVO", "EVENTO");
		           	txtBusquedaSinOrdem.AutoCompleteMode = AutoCompleteMode.Suggest;
		            txtBusquedaSinOrdem.AutoCompleteSource = AutoCompleteSource.CustomSource;  
				}
				filtrosSinOrden();
			}
		}
		
		void CbSinOrdenCheckedChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosSinOrden();
		}
		
		void TxtBusquedaSinOrdemTextChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosSinOrden();
		}
		
		////////////////////////////////////////////////// CON ORDEN DE FACTURA ////////////////////////////////////////////////////
		public int msj=0;		
		public FormDetalleFactura msjGlobo = new FormDetalleFactura();				
		void DgOrdenFacturaCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 14 && e.RowIndex != -1){
				msjGlobo.muestrarMsj(dgOrdenFactura[0,e.RowIndex].Value.ToString());
				//msjGlobo.Location  = new System.Drawing.Point(Control.MousePosition.X, Control.MousePosition.Y);
				msjGlobo.Location  = new System.Drawing.Point(300, Control.MousePosition.Y);
				msjGlobo.Visible=true;
				msj=1;				
			}else if(msj==1){
				msjGlobo.Visible=false;
				msj=0;
			}
		}	
		
		 void DtpInicioOrdenFacturaValueChanged(object sender, EventArgs e)
		{		 	
			dtpFinOrdenFactura.Value = dtpInicioOrdenFactura.Value;
		}
		
		void DtpFinOrdenFacturaValueChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosOrden();
		}
		
		void CmbBusquedaOrdenFacturaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosOrden();
		}
		
		void CbEliminadasOrdenFacturaCheckedChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosOrden();
		}
		
		void TxtBusquedaOrdenFacturaTextChanged(object sender, EventArgs e)
		{
			if(validaAdpatadores == false)
				filtrosOrden();
		}		
		#endregion
		
		#region EVENTOS DATAGRIDVIEW
		void DgSinOrdenCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{/*
			if(dgSinOrden.SelectedRows.Count < 2){
				dgSinOrden.ClearSelection();
				if (e.Button == MouseButtons.Right){
				      if (e.RowIndex > -1)
				         this.dgSinOrden.Rows[e.RowIndex].Selected = true;	
	        	}
			}*/
		}
		
		void DgOrdenFacturaCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{/*
			dgOrdenFactura.ClearSelection();
			if (e.Button == MouseButtons.Right){
			      if (e.RowIndex > -1)
			         this.dgOrdenFactura.Rows[e.RowIndex].Selected = true;	
        	}*/
		}
		#endregion
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////  VALIDACION  ///////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region VARIABLES
		String consulta = "";
		public List<Dato.datosViajes> listRutaSalida = null;	
		#endregion		
			
		#region FILTROS	
		public void filtrosValidacion()
		{
			if(cbValidados.Checked == false){
				consulta = @"select R.ID, RE.ID_RE,  RE.CANT_UNIDADES, RE.DESTINO, RE.PRECIO, RE.tipoVehiculo, RE.anticipo, RE.SALDO, RE.FECHA_SALIDA, RE.estado, R.PAGO, RE.FACTURADO 
						from RUTA R, Cliente C, RUTA_ESPECIAL RE where R.IdSubEmpresa = C.ID and C.ID = RE.ID_C AND R.Sentido = 'ENTRADA' 
						and FECHA_SALIDA between '2013/02/12' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' and R.PAGO = '0' ";
			}else{
				consulta = @"select R.ID, RE.ID_RE, RE.CANT_UNIDADES, RE.DESTINO, RE.PRECIO, RE.tipoVehiculo, RE.anticipo, RE.SALDO, RE.FECHA_SALIDA, RE.estado, R.PAGO, RE.FACTURADO 
						from RUTA R, Cliente C, RUTA_ESPECIAL RE where R.IdSubEmpresa = C.ID and C.ID = RE.ID_C AND R.Sentido = 'ENTRADA' 
						 and FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy/MM/dd")+"' and '"+dtpFin.Value.ToString("yyyy/MM/dd")+"' and RE."+cbBusquedaValidacion.Text+" like '%"+txtValidacion.Text+"%' and (R.PAGO = '0' OR R.PAGO = '1') ";
			}			
			consulta = consulta +" ORDER BY RE.FECHA_SALIDA, C.ID ";				
			AdaptadorValidacion();		
		}	
		#endregion
		
		#region ADAPTADOR	
		public void AdaptadorValidacion(){
			dgDatos.Rows.Clear();					
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgDatos.Rows.Add(conn.leer["estado"].ToString(),
				                 conn.leer["ID"].ToString(),  // ID DE RUTA ENTRADA
				                 "0",// ID DE RUTA SALIDA
				                 conn.leer["ID_RE"].ToString(),
				                 conn.leer["DESTINO"].ToString(),
				                 ((conn.leer["FACTURADO"].ToString() == "0")?  conn.leer["PRECIO"].ToString() : (Convert.ToDouble(conn.leer["SALDO"].ToString()) /  Convert.ToDouble(conn.leer["CANT_UNIDADES"].ToString()) ).ToString()),// PRECIO POR VEHICULO
				                 conn.leer["FECHA_SALIDA"].ToString().Substring(0,10),
				                 "0", //Id Operador Entrada
				                 "0", //Id Vehiculo Entrada
				                 "0", //Tipo Vehiculo Entrada
				                 "OPERADOR", // OPERADOR DE RUTA DE ENTRADA 10
				                 "0",
				                 false,
				                 "0", //Id Operador Salida
				                 "0", //Id Vehiculo Salida
				                 "0", //Tipo Vehiculo Salida 15
				                 "OPERADOR", // OPERADOR DE RUTA DE SALIDA 
				                 "0",
				                 false,
				                 "OPERADOR", // OPERADOR QUE COBRO
				                 "000000000", // TELEFONO DEL OPERADOR QUE COBRO 20                 
				                 ((conn.leer["FACTURADO"].ToString() == "0")?"NO":"SI"),
				                 ((conn.leer["PAGO"].ToString() == "0")? "NO": "SI"),
				                 conn.leer["SALDO"].ToString(),
				                 "", // TIPO DE COBRO
				                 "", //FLUJO 25
				                 "Activo",
				                 "Activo",
				                 conn.leer["tipoVehiculo"].ToString(),
				                 "",
				                 "");
			}			
			conn.conexion.Close();
			if(cbValidados.Checked == false)
				listRutaSalida = new Conexion_Servidor.Libros.SQL_Libros().obtenerIdsSalidas();		
			else							
				listRutaSalida = new Conexion_Servidor.Libros.SQL_Libros().obtenerIdsSalidasFull();	
				
			for(int x=0; x<dgDatos.Rows.Count; x++){
				for(int y=0; y<listRutaSalida.Count; y++){
					if(dgDatos[2,x].Value.ToString() == "0" && dgDatos[3,x].Value.ToString()==listRutaSalida[y].dato2 && dgDatos[4,x].Value.ToString() == listRutaSalida[y].dato3 && Convert.ToInt32(dgDatos[1,x].Value)+1 == Convert.ToInt32(listRutaSalida[y].dato1)){
						dgDatos[2,x].Value = listRutaSalida[y].dato1;
						listRutaSalida.RemoveAt(y);
						//MessageBox.Show("ID_Ruta: "+listRutaSalida[y].dato1);
					}
				}
			}
			datosCompleta();
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region COMPLETA ADPTADOR	
		public void datosCompleta(){
			for(int x=0; x<dgDatos.Rows.Count; x++){
				String consul = @"select HORA_REGRESO, FECHA_REGRESO from VIAJE_PROSPECTO_NUEVO where ID_RE = "+dgDatos[3,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgDatos[29,x].Value = conn.leer["FECHA_REGRESO"].ToString().Substring(0,10);
					dgDatos[30,x].Value = conn.leer["HORA_REGRESO"].ToString().Substring(0,8);	           	
				}				
				conn.conexion.Close();
				
				consul = @"select OP.Alias, O.id_operacion, R.PAGO FLUJO, OO.id_vehiculo, OO.vehiculo, OP.ID from RUTA R, Cliente C, RUTA_ESPECIAL RE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP 
								where R.IdSubEmpresa = C.ID and C.ID = RE.ID_C and O.id_ruta = R.ID and O.id_operacion = OO.id_operacion and OO.id_operador = OP.ID and O.estatus = '1' and R.ID = "+dgDatos[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgDatos[10,x].Value = conn.leer["Alias"].ToString();
					dgDatos[11,x].Value = conn.leer["id_operacion"].ToString();
					dgDatos[19,x].Value = conn.leer["Alias"].ToString(); //OPERADOR COBRO
					dgDatos[7,x].Value = conn.leer["ID"].ToString();
					dgDatos[8,x].Value = conn.leer["id_vehiculo"].ToString();
					dgDatos[9,x].Value = conn.leer["vehiculo"].ToString();
		           	dgDatos[12,x].Value = true;
					dgDatos[12,x].Style.BackColor = Color.SpringGreen;
					dgDatos[10,x].Style.BackColor = Color.SpringGreen;		           	
				}				
				conn.conexion.Close();
				
				consul = @"select OP.Alias, O.id_operacion, R.PAGO FLUJO, OO.id_vehiculo, OO.vehiculo, OP.ID from RUTA R, Cliente C, RUTA_ESPECIAL RE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP 
							where R.IdSubEmpresa = C.ID and C.ID = RE.ID_C and O.id_ruta = R.ID and O.id_operacion = OO.id_operacion and OO.id_operador = OP.ID and O.estatus = '1' and R.ID = "+dgDatos[2,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgDatos[16,x].Value = conn.leer["Alias"].ToString();
					dgDatos[17,x].Value = conn.leer["id_operacion"].ToString();
					dgDatos[13,x].Value = conn.leer["ID"].ToString();
					dgDatos[14,x].Value = conn.leer["id_vehiculo"].ToString();
					dgDatos[15,x].Value = conn.leer["vehiculo"].ToString();
		           	dgDatos[18,x].Value = true;
					dgDatos[18,x].Style.BackColor = Color.SpringGreen;
					dgDatos[16,x].Style.BackColor = Color.SpringGreen;	
					
				}				
				conn.conexion.Close();								
				
				consul = @"select O.Alias, V.ID, V.Tipo_Unidad, O.ID ID_OP from CANCELACION_PUNTO C, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V WHERE O.ID = A.ID_OPERADOR and 
							A.ID_UNIDAD = V.ID and C.ID_OPERADOR = O.ID and ID_RUTA = "+dgDatos[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgDatos[0,x].Value = "C. PUNTO";
					if(dgDatos[11,x].Value.ToString() == "0"){		           	
						dgDatos[10,x].Value = conn.leer["Alias"].ToString();
						dgDatos[19,x].Value = conn.leer["Alias"].ToString();
						dgDatos[7,x].Value = conn.leer["ID_OP"].ToString();
						dgDatos[8,x].Value = conn.leer["ID"].ToString();
						dgDatos[9,x].Value = conn.leer["Tipo_Unidad"].ToString();
		           		dgDatos[12,x].Value = true;         
					}else{
						dgDatos[10,x].Value = "'Error' "+dgDatos[10,x].Value.ToString();
						dgDatos[10,x].Style.ForeColor = Color.White;
						dgDatos[7,x].Value = conn.leer["ID_OP"].ToString();
						dgDatos[8,x].Value = conn.leer["ID"].ToString();
						dgDatos[9,x].Value = conn.leer["Tipo_Unidad"].ToString();
		           		dgDatos[12,x].Value = true;         
					}
					if(dgDatos[17,x].Value.ToString() == "0"){
						dgDatos[16,x].Value = conn.leer["Alias"].ToString();
		           		dgDatos[18,x].Value = true;         
					}else{
						dgDatos[16,x].Value = "'Error' "+dgDatos[16,x].Value.ToString();
						dgDatos[16,x].Style.ForeColor = Color.White;
		           		dgDatos[18,x].Value = true;
					}
					dgDatos[5,x].Value = (Convert.ToDouble(dgDatos[5,x].Value) * .25).ToString();
				}				
				conn.conexion.Close();						
				
				consul = @"select O.Alias, V.ID, V.Tipo_Unidad, O.ID ID_OP from CANCELACION_PUNTO C, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V WHERE O.ID = A.ID_OPERADOR and 
							A.ID_UNIDAD = V.ID and C.ID_OPERADOR = O.ID and ID_RUTA = "+dgDatos[2,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgDatos[0,x].Value = "C. PUNTO";
					if(dgDatos[11,x].Value.ToString() == "0"){		           	
						dgDatos[10,x].Value = conn.leer["Alias"].ToString();
						dgDatos[19,x].Value = conn.leer["Alias"].ToString();
						dgDatos[7,x].Value = conn.leer["ID_OP"].ToString();
						dgDatos[8,x].Value = conn.leer["ID"].ToString();
						dgDatos[9,x].Value = conn.leer["Tipo_Unidad"].ToString();
		           		dgDatos[12,x].Value = true;         
					}else{
						dgDatos[10,x].Value = "'Error' "+dgDatos[10,x].Value.ToString();
						dgDatos[10,x].Style.ForeColor = Color.White;
						dgDatos[7,x].Value = conn.leer["ID_OP"].ToString();
						dgDatos[8,x].Value = conn.leer["ID"].ToString();
						dgDatos[9,x].Value = conn.leer["Tipo_Unidad"].ToString();
		           		dgDatos[12,x].Value = true;         
					}
					if(dgDatos[17,x].Value.ToString() == "0"){
						dgDatos[16,x].Value = conn.leer["Alias"].ToString();
		           		dgDatos[18,x].Value = true;         
					}else{
						dgDatos[16,x].Value = "'Error' "+dgDatos[16,x].Value.ToString();
						dgDatos[16,x].Style.ForeColor = Color.White;
		           		dgDatos[18,x].Value = true;
					}
					dgDatos[5,x].Value = (Convert.ToDouble(dgDatos[5,x].Value) * .25).ToString();
				}				
				conn.conexion.Close();
				
				if(dgDatos[0,x].Value.ToString() != "C. PUNTO"){
					consul = "select TIPO from RUTA where ID = "+dgDatos[1,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						if(conn.leer["TIPO"].ToString()=="Cancelada"){
							dgDatos[26,x].Style.BackColor = Color.Red;
							dgDatos[26,x].Value="CANCELADA";
							dgDatos[5,x].Value="0";
						}
					}				
					conn.conexion.Close();
									
					consul = "select TIPO from RUTA where ID="+dgDatos[2,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						if(conn.leer["TIPO"].ToString() == "Cancelada"){
							dgDatos[27,x].Style.BackColor = Color.Red;
							dgDatos[27,x].Value = "CANCELADA";
							dgDatos[5,x].Value = "0";
						}
					}				
					conn.conexion.Close();
				}
				
				if(dgDatos[16,x].Value.ToString() ==  "OPERADOR"){
					consul = "select T.Numero from TELEFONOCHOFER T, OPERADOR O where T.Tipo='LAR' and T.ID_Chofer = O.ID AND O.Alias = '"+
					((dgDatos[10,x].Value.ToString().Contains("Error")==true)?dgDatos[10,x].Value.ToString().Substring(8,(dgDatos[10,x].Value.ToString().Length-8)):dgDatos[10,x].Value.ToString())+"'";
				}else{
					consul = "select T.Numero from TELEFONOCHOFER T, OPERADOR O where T.Tipo='LAR' and T.ID_Chofer = O.ID AND O.Alias = '"+
					((dgDatos[16,x].Value.ToString().Contains("Error")==true)?dgDatos[16,x].Value.ToString().Substring(8,(dgDatos[16,x].Value.ToString().Length-8)):dgDatos[16,x].Value.ToString())+"'";
				}
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgDatos[20,x].Value=conn.leer["Numero"].ToString();
				}				
				conn.conexion.Close();
								
				if(dgDatos[26,x].Value.ToString() == "CANCELADA" && dgDatos[27,x].Value.ToString() == "CANCELADA"){
					dgDatos[0,x].Value = "CANCELADA";
					dgDatos[21,x].Value = "N/A";
					for(int y=0; y<dgDatos.Columns.Count; y++){
						dgDatos[y,x].Style.BackColor = Color.Yellow;
					}
				}else if(dgDatos[0,x].Value.ToString() == "Cancelado"){
					dgDatos[0,x].Value = "SIN CONF.";
					dgDatos[21,x].Value = "N/A";
					for(int y=0; y<dgDatos.Columns.Count; y++){
						dgDatos[y,x].Style.BackColor=Color.Yellow;
					}
				}else if(dgDatos[0,x].Value.ToString() == "C. PUNTO"){
					for(int y=0; y<dgDatos.Columns.Count; y++){
						if(y==10 && dgDatos[11,x].Value.ToString()!="0"){
							dgDatos[y,x].Style.BackColor=Color.Black;
						}else if(y==16 && dgDatos[17,x].Value.ToString()!="0"){
							dgDatos[y,x].Style.BackColor=Color.Black;
						}else{
							dgDatos[y,x].Style.BackColor=Color.Red;
						}
					}
				}	
				if(cbValidados.Checked == true){
					dgDatos[12,x].ReadOnly = true;
					dgDatos[18,x].ReadOnly = true;
				}else{
					if(dgDatos[10,x].Value.ToString() == "OPERADOR"){
						dgDatos[12,x].ReadOnly = true;
					}					
					if(dgDatos[16,x].Value.ToString() == "OPERADOR"){
						dgDatos[18,x].ReadOnly = true;
					}
				}								
				
				if(cbValidados.Checked == false){
					try{
						int result1 =DateTime.Compare(Convert.ToDateTime(dgDatos.Rows[x].Cells[29].Value), Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")));
		 				if(result1 == 0){
		 					TimeSpan dif = Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime(dgDatos.Rows[x].Cells[30].Value);
		 					if(Convert.ToDateTime(dif.ToString().Substring(0,8)) > Convert.ToDateTime("00:00:01"))
								dgDatos[30,x].Style.BackColor = Color.Red;
		 				}
						if(result1 < 0){
							dgDatos[30,x].Style.BackColor = Color.Red;
		 				}
					}catch(Exception){
					}
					if(dgDatos[30,x].Style.BackColor.Name.ToString() == "Red")
						lblAvisoValidacion.Visible = true;
				}
				validados(x);
			}
		}
		#endregion
		
		#region EVENTOS
		void CbBusquedaValidacionSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbBusquedaValidacion.SelectedIndex == 0){
				txtValidacion.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CONTACTO from VIAJE_PROSPECTO_NUEVO", "CONTACTO");
	           	txtValidacion.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtValidacion.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
			if(cbBusquedaValidacion.SelectedIndex == 1){
				txtValidacion.AutoCompleteCustomSource = auto.AutocompleteGeneral("select EVENTO from VIAJE_PROSPECTO_NUEVO", "EVENTO");
	           	txtValidacion.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtValidacion.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
		}
		
		void CbValidadosCheckedChanged(object sender, EventArgs e)
		{
			if(cbValidados.Checked == true){
				dtpInicio.Enabled = true;
				dtpFin.Enabled = true;
				cbBusquedaValidacion.Enabled = true;
				txtValidacion.Enabled = true;
				button1.Enabled = true;
				cbBusquedaValidacion.SelectedIndex = 1;
				dgDatos.Rows.Clear();
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Seleccione rango de fechas y algun filtro");
				mensaje.Show();
				dtpInicio.Show();
			}else if(cbValidados.Checked == false){
				dtpFin.Value = DateTime.Now;
				dtpInicio.Enabled = false;
				dtpFin.Enabled = false;
				button1.Enabled = false;
				cbBusquedaValidacion.Enabled = false;
				txtValidacion.Text = "";
				cbBusquedaValidacion.SelectedIndex = 1;
				txtValidacion.Enabled = false;
				filtrosValidacion();
			}
		}		
		#endregion
		
		#region MENU
		void CancelarToolStripMenuItemClick(object sender, EventArgs e){
			if(dgDatos.SelectedRows.Count == 1){
				if(dgDatos[1,dgDatos.CurrentRow.Index].Selected == true && cbValidados.Checked == false && dgDatos[0,dgDatos.CurrentRow.Index].Value.Equals("Activo")){
					if(dgDatos[10,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString() != "Black" && dgDatos[16,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString() != "Black"){
						DialogResult respuesta = MessageBox.Show("¿Deceas CANCELAR este vehiculo del servicio? ", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
						if(respuesta == DialogResult.Yes){	
							if(dgDatos[11,dgDatos.CurrentRow.Index].Value.ToString() != "0"){
								connD.deleteAsignacion2(Convert.ToInt64(dgDatos[11,dgDatos.CurrentRow.Index].Value), id_usuario);
							}
							
							if(dgDatos[17,dgDatos.CurrentRow.Index].Value.ToString() != "0"){
								connD.deleteAsignacion2(Convert.ToInt64(dgDatos[17,dgDatos.CurrentRow.Index].Value), id_usuario);
							}					
							connD.cancelaEspecial(dgDatos[1,dgDatos.CurrentRow.Index].Value.ToString());	
							connD.cancelaEspecial(dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString());		
							MessageBox.Show("El vehiculo se cancelo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtrosValidacion();
						}
					}else if(dgDatos[10,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString() == "Black" || dgDatos[16,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString() == "Black"){
						DialogResult rs2 = MessageBox.Show("Es necesario eliminar la asignación.", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
						if (DialogResult.OK==rs2){
							if(dgDatos[10, dgDatos.CurrentRow.Index].Style.BackColor.Name == "Black"){							
								connD.deleteAsignacion2(Convert.ToInt64(dgDatos[11,dgDatos.CurrentRow.Index].Value), id_usuario);
							}
							
							if(dgDatos[16, dgDatos.CurrentRow.Index].Style.BackColor.Name=="Black"){
								connD.deleteAsignacion2(Convert.ToInt64(dgDatos[17,dgDatos.CurrentRow.Index].Value), id_usuario);
							}				
						}
					}					
				}else{
					MessageBox.Show("No puedes validar si tienes el checkbox seleccionado o el vehiculo no esta activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}else{
				MessageBox.Show("Seleccione solo un registro de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}			
		}
		
		void CancelacionPuntoToolStripMenuItemClick(object sender, EventArgs e)
		{	
  			bool respuesta = false;
			if(dgDatos.SelectedRows.Count == 1){
				if(dgDatos[1,dgDatos.CurrentRow.Index].Selected == true && cbValidados.Checked == false  && dgDatos[0,dgDatos.CurrentRow.Index].Value.Equals("Activo")){
					DialogResult respues = MessageBox.Show("¿Confirma el CANCELADO EN EL PUNTO del vehiculo? ", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if(respues == DialogResult.Yes){
						if(dgDatos[11,dgDatos.CurrentRow.Index].Value.ToString() != "0" && dgDatos[17,dgDatos.CurrentRow.Index].Value.ToString() != "0"){
							if(dgDatos[11,dgDatos.CurrentRow.Index].Value.ToString() != "0"){
								if(dgDatos[7,dgDatos.CurrentRow.Index].Value.ToString() != "0"){					
									connL.cancelacionPunto(Convert.ToInt32(dgDatos[11,dgDatos.CurrentRow.Index].Value), Convert.ToInt32(dgDatos[7,dgDatos.CurrentRow.Index].Value), Convert.ToInt64(dgDatos[1,dgDatos.CurrentRow.Index].Value), id_usuario, "Mañana", dgDatos[6,dgDatos.CurrentRow.Index].Value.ToString().Substring(0,10));
									connD.cancelaEspecial(dgDatos[1,dgDatos.CurrentRow.Index].Value.ToString());	
									respuesta = true;
								}
							}
							if(dgDatos[17,dgDatos.CurrentRow.Index].Value.ToString()!="0"){
								if(dgDatos[13,dgDatos.CurrentRow.Index].Value.ToString() != "0"){						
									connL.cancelacionPunto(Convert.ToInt32(dgDatos[17,dgDatos.CurrentRow.Index].Value), Convert.ToInt32(dgDatos[13,dgDatos.CurrentRow.Index].Value), Convert.ToInt64(dgDatos[2,dgDatos.CurrentRow.Index].Value), id_usuario, "Mañana", dgDatos[6,dgDatos.CurrentRow.Index].Value.ToString().Substring(0,10));
									connD.cancelaEspecial(dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString());	
									respuesta = true;
								}
							}
						}else{
							MessageBox.Show("Es necesaria la asignación de un operador en la ENTARDA Y SALIDA para poder cancelar en el punto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						if(respuesta == true){
							MessageBox.Show("El vehiculo se cancelo en el punto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtrosValidacion();
						}
					}
				}else{
					MessageBox.Show("No puedes validar si tienes el checkbox seleccionado o el vehiculo no esta activo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}else{
				MessageBox.Show("Seleccione solo un registro de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}	
		}
		
		void EnviarRutaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgDatos.SelectedRows.Count == 1){
				if(dgDatos[7,dgDatos.CurrentRow.Index].Value.ToString() == dgDatos[13,dgDatos.CurrentRow.Index].Value.ToString()){
					enviaRuta(dgDatos[7,dgDatos.CurrentRow.Index].Value.ToString());
				}else{
					enviaRuta(dgDatos[7,dgDatos.CurrentRow.Index].Value.ToString());
					enviaRuta(dgDatos[13,dgDatos.CurrentRow.Index].Value.ToString());
				}
			}else{
				MessageBox.Show("Seleccione solo un registro de la tabla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		private void enviaRuta(string id_operad){
			string correo = "";
			try{
				conn.getAbrirConexion("SELECT CORREO FROM OPERADOR where id = "+id_operad);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
					correo = conn.leer["CORREO"].ToString();
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener el correo del operador: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				conn.conexion.Close();				
			}
			
			String ruta = "";
			try{
				conn.getAbrirConexion("SELECT LINK_RUTA FROM VIAJE_PROSPECTO_NUEVO WHERE ID_RE = "+dgDatos[3,dgDatos.CurrentRow.Index].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
					ruta = conn.leer["LINK_RUTA"].ToString();
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener la ruta del servicio: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				conn.conexion.Close();				
			}
			
			if(correo.Length > 8 & ruta != ""){
				MailMessage message = new MailMessage("ventas@lar.com.mx", "SISTEMAS@LAR.COM.MX", "RUTA  a: "+dgDatos[4,dgDatos.CurrentRow.Index].Value.ToString(), "VIAJE A: "
				                                      +dgDatos[4,dgDatos.CurrentRow.Index].Value.ToString()+" \n FECHA SALIDA: "+dgDatos[6,dgDatos.CurrentRow.Index].Value.ToString()+
				                                      ", \t FECHA DE REGRESO: "+ dgDatos[29,dgDatos.CurrentRow.Index].Value.ToString()+" \n\n RUTA: "+ruta);
				SmtpClient smtpclient = new SmtpClient("mail.lar.com.mx");
				smtpclient.Port = 587;
				smtpclient.UseDefaultCredentials = false;
				smtpclient.Credentials = new System.Net.NetworkCredential("ventas@lar.com.mx", "LAR1249.5");
				smtpclient.EnableSsl = false;
	         	message.Priority = MailPriority.High;
	         	message.IsBodyHtml = false;
	         	try{
	         		smtpclient.Send(message);
					MessageBox.Show("Mensaje enviado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
	         	}catch(Exception ex){
	         		MessageBox.Show("Mensaje no se envio : "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}else{
				MessageBox.Show("No se pudo enviar el correo puede que el operador no tenga asignado su CORREO o el servicio no tenga el link de GOOGLE MAPS", "ERROR AL ENVIAR",
				                MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		#endregion				
				
		#region METODOS
		private void AvisoValidacion(){
			bool respu = false;
			string consul = @"select count(vpn.ID) cont from RUTA_ESPECIAL re join ruta r on r.IdSubEmpresa = re.ID_C join VIAJE_PROSPECTO_NUEVO vpn on vpn.ID_RE = re.ID_RE 
							where R.Sentido = 'ENTRADA' and vpn.FECHA_REGRESO between '2013/02/12' and '"+dtpFin.Value.AddDays(-1).ToString("dd/MM/yyyy")+"' and R.PAGO = '0'";
			conn.getAbrirConexion(consul);
			conn.leer = conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				if(Convert.ToInt32(conn.leer["cont"]) > 0){						
					lblAvisoValidacion.Visible = true;
				}else{
					lblAvisoValidacion.Visible = false;
					respu = true;
				}
			}				
			conn.conexion.Close();
			
			if(respu){
				consul = @"select count(vpn.ID) cont from RUTA_ESPECIAL re join ruta r on r.IdSubEmpresa = re.ID_C join VIAJE_PROSPECTO_NUEVO vpn on vpn.ID_RE = re.ID_RE 
						where  R.Sentido = 'ENTRADA' and vpn.FECHA_REGRESO = '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' and R.PAGO = '0' and vpn.HORA_REGRESO <= (SELECT CONVERT (TIME, SYSDATETIME()))";
				conn.getAbrirConexion(consul);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(Convert.ToInt32(conn.leer["cont"]) > 0){						
						lblAvisoValidacion.Visible = true;
					}else{
						lblAvisoValidacion.Visible = false;
					}
				}				
				conn.conexion.Close();
			}
		}
		
		public void validados(int x)
		{
			if(dgDatos[22,x].Value.ToString() == "SI")
				dgDatos[22,x].Style.BackColor = Color.SpringGreen;
			
			if(dgDatos[10,x].Value.ToString() != "OPERADOR" && dgDatos[10,x].Style.BackColor.Name.ToString() != "Black"){
				dgDatos[10,x].Style.BackColor = Color.SpringGreen;
				dgDatos[12,x].Style.BackColor = Color.SpringGreen;
			}
			if(dgDatos[16,x].Value.ToString() != "OPERADOR" && dgDatos[16,x].Style.BackColor.Name.ToString() != "Black"){
				dgDatos[16,x].Style.BackColor = Color.SpringGreen;
				dgDatos[18,x].Style.BackColor = Color.SpringGreen;
			}
		}
			
		void asignacionViaje(Int64 id_ruta, Int64 id_operador, Int64 id_vehiculo, String tipo_vehiculo, string SENTIDO){			
			if(new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarViaje(0, id_ruta.ToString(), id_usuario, id_operador, "00:00", "00:00", 1, 
			                                                                    id_vehiculo, tipo_vehiculo, "Mañana", 0, " ", dgDatos[6,dgDatos.CurrentRow.Index].Value.ToString().Substring(0,10), "Espsciales")){
				conn.getAbrirConexion("select max(id_operacion) as id from OPERACION");
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(SENTIDO == "E")
						dgDatos[11, dgDatos.CurrentRow.Index].Value = conn.leer["ID"].ToString();
					else						
						dgDatos[17, dgDatos.CurrentRow.Index].Value = conn.leer["ID"].ToString();
				}
				conn.conexion.Close();
				MessageBox.Show("Se asigno el viaje correctamente", "ASIGNACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}			
		}		
			
		public void obtenerDatosEntrada(){
			int dato = 0;		
			String consul = "";
			int x = dgDatos.CurrentRow.Index;
			consul = "select ID from OPERADOR where Estatus = '1' and Alias = '"+dgDatos[10,dgDatos.CurrentRow.Index].Value.ToString()+"'";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				dgDatos[7,x].Value = Convert.ToInt64(conn.leer["ID"]);					
				dato = 1;
			}
			conn.conexion.Close();
			
			consul = "select Numero from TELEFONOCHOFER where Tipo='LAR' and ID_Chofer='"+dgDatos[7,x].Value.ToString()+"'";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				dgDatos[20,x].Value = conn.leer["Numero"].ToString();
			}
			conn.conexion.Close();
				
			if(dato == 1){
				consul = "select V.ID, V.Tipo_Unidad, O.tipo_empleado from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O where V.ID=A.ID_UNIDAD and O.ID=A.ID_OPERADOR and ID_OPERADOR='"+dgDatos[7,x].Value.ToString()+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
						if(conn.leer["tipo_empleado"].ToString()=="Externo"){
							dgDatos[8,x].Value = 109;
							dgDatos[9,x].Value = "Camión";
						}else{
							dgDatos[8,x].Value = Convert.ToInt64(conn.leer["ID"]);
							dgDatos[9,x].Value = conn.leer["Tipo_Unidad"].ToString();
						}
					}else{
						dgDatos[8,x].Value = 109;
						dgDatos[9,x].Value = "Camión";
					}
					conn.conexion.Close();
				}else{
					dgDatos[8,x].Value = 109;
					dgDatos[9,x].Value = "Camión";
				}
			if(dgDatos[7,x].Value.ToString() != "0" && dgDatos[8,x].Value.ToString() != "0" && dgDatos[9,x].Value.ToString() != "0"){
				dgDatos[10,dgDatos.CurrentRow.Index].Style.BackColor = Color.SpringGreen;
			}else{
				dgDatos[10,dgDatos.CurrentRow.Index].Style.BackColor = Color.Red;
			}
		}
		
		public void obtenerDatosSalida(){
			int dato = 0;		
			String consul = "";
			int x = dgDatos.CurrentRow.Index;
			consul = "select ID from OPERADOR where Estatus = '1' and Alias = '"+dgDatos[16,dgDatos.CurrentRow.Index].Value.ToString()+"'";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				dgDatos[13,x].Value = Convert.ToInt64(conn.leer["ID"]);					
				dato = 1;
			}
			conn.conexion.Close();
			
			consul = "select Numero from TELEFONOCHOFER where Tipo='LAR' and ID_Chofer = '"+dgDatos[13,x].Value.ToString()+"'";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				dgDatos[20,x].Value = conn.leer["Numero"].ToString();
			}
			conn.conexion.Close();
				
			if(dato == 1){
				consul = "select V.ID, V.Tipo_Unidad, O.tipo_empleado from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O where V.ID = A.ID_UNIDAD and O.ID = A.ID_OPERADOR and ID_OPERADOR = '"+dgDatos[13,x].Value.ToString()+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
						if(conn.leer["tipo_empleado"].ToString()=="Externo"){
							dgDatos[14,x].Value = 109;
							dgDatos[15,x].Value = "Camión";
						}else{
							dgDatos[14,x].Value = Convert.ToInt64(conn.leer["ID"]);
							dgDatos[15,x].Value = conn.leer["Tipo_Unidad"].ToString();
						}
					}else{
						dgDatos[14,x].Value = 109;
						dgDatos[15,x].Value = "Camión";
					}
					conn.conexion.Close();
				}else{
					dgDatos[14,x].Value = 109;
					dgDatos[15,x].Value = "Camión";
				}
			if(dgDatos[13,x].Value.ToString() != "0" && dgDatos[14,x].Value.ToString() != "0" && dgDatos[15,x].Value.ToString() != "0"){
				dgDatos[16,dgDatos.CurrentRow.Index].Style.BackColor = Color.SpringGreen;
			}else{
				dgDatos[16,dgDatos.CurrentRow.Index].Style.BackColor = Color.Red;
			}
		}		
		
		public void valida(){
			if(dgDatos.SelectedRows.Count > 1){
				new FormCobroValidacion(this,1).ShowDialog();
			}else if(dgDatos.SelectedRows.Count == 1){
				new FormCobroValidacion(this,2).ShowDialog();
			}		
		}		
		#endregion	
		
		#region EVENTO DATAGRIDVIEW
		void DgDatosDoubleClick(object sender, EventArgs e)
		{
			if(dgDatos.CurrentCell.ColumnIndex == 31 && dgDatos.CurrentRow.Index > -1){
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgDatos[3,dgDatos.CurrentRow.Index].Value));
				formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();			
			}
		}
		
		void DgDatosEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{			
			bool respues = true;
			if(dgDatos.CurrentCell.ColumnIndex == 10 || dgDatos.CurrentCell.ColumnIndex == 16 || dgDatos.CurrentCell.ColumnIndex == 19 && dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString() != "C. PUNTO"){
				dgDatos[19,dgDatos.CurrentRow.Index].ReadOnly = false;
				dgDatos[10,dgDatos.CurrentRow.Index].ReadOnly = false;
				dgDatos[16,dgDatos.CurrentRow.Index].ReadOnly = false;
					
				if(dgDatos.CurrentCell.ColumnIndex == 19){
					if (e.Control is DataGridViewTextBoxEditingControl){
						((TextBox)e.Control).AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias Dato from OPERADOR where (ID in (select ID from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR)) OR tipo_empleado='Externo'");
		                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;           
		            }
					respues = false;
				}
				
				if(dgDatos.CurrentCell.ColumnIndex == 10 && dgDatos[12,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString() != "SpringGreen"){
					if (e.Control is DataGridViewTextBoxEditingControl){		
						((TextBox)e.Control).AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias Dato from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR ");
		                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;		
		            }
					respues = false;
				}
				
				if(dgDatos.CurrentCell.ColumnIndex == 16 && dgDatos[18,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString() != "SpringGreen"){
		           	if (e.Control is DataGridViewTextBoxEditingControl ){
						((TextBox)e.Control).AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias Dato from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR");
		                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;
						respues = false;
		            }
				}			
				
				if(respues == true){
					if (e.Control is DataGridViewTextBoxEditingControl)
						((TextBox)e.Control).AutoCompleteCustomSource = null;
				}
				
			}else{
				if (e.Control is DataGridViewTextBoxEditingControl )
					((TextBox)e.Control).AutoCompleteCustomSource = null;		
			}			
		}
				
		void DgDatosCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >-1 && e.ColumnIndex == 10 && dgDatos[16, e.RowIndex].Style.BackColor.Name.ToString() != "SpringGreen"){
				dgDatos[16,e.RowIndex].Value = dgDatos[10,e.RowIndex].Value;
			}
		}
		
		void DgDatosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1 && dgDatos[0,e.RowIndex].Value.ToString() == "C. PUNTO"){
				dgDatos[12,e.RowIndex].ReadOnly = true;
				dgDatos[18,e.RowIndex].ReadOnly = true;
				dgDatos[12,e.RowIndex].Value = true;
				dgDatos[18,e.RowIndex].Value = true;
			}
			
			if(e.RowIndex>-1 && dgDatos[0,e.RowIndex].Value.ToString() != "C. PUNTO"){
				if(cbValidados.Checked == false){
					if(dgDatos[10,e.RowIndex].Value != null && dgDatos[12,e.RowIndex].Value != null){
						/*
					if(dgDatos[10,e.RowIndex].Value.ToString() == "OPERADOR")
						dgDatos[12,e.RowIndex].ReadOnly = true;	
					else					
						dgDatos[12,e.RowIndex].ReadOnly = false;													
					if(dgDatos[16,e.RowIndex].Value.ToString() == "OPERADOR")
						dgDatos[18,e.RowIndex].ReadOnly = true;
					else
						dgDatos[18,e.RowIndex].ReadOnly = false;
					*/
					}
					
					if(e.ColumnIndex == 12){
						if(dgDatos[12,e.RowIndex].Value.ToString() == "False" && dgDatos[10,e.RowIndex].Value.ToString() != "OPERADOR"){
							obtenerDatosEntrada();
							if(dgDatos[10,e.RowIndex].Style.BackColor.Name.ToString() == "SpringGreen" &&  dgDatos[10,e.RowIndex].Value.ToString() != "OPERADOR" && dgDatos[7,e.RowIndex].Value.ToString() != "0" && 
							   dgDatos[8,e.RowIndex].Value.ToString() != "0" && dgDatos[9,e.RowIndex].Value.ToString() != "0"){								
								asignacionViaje(Convert.ToInt64(dgDatos[1,dgDatos.CurrentRow.Index].Value), Convert.ToInt64(dgDatos[7,dgDatos.CurrentRow.Index].Value), Convert.ToInt64(dgDatos[8,dgDatos.CurrentRow.Index].Value), dgDatos[9,dgDatos.CurrentRow.Index].Value.ToString(), "E");
								dgDatos[12,e.RowIndex].Style.BackColor = Color.SpringGreen;
								dgDatos[12,e.RowIndex].Value = true;
							}else{
								MessageBox.Show("selecciona un operador valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
								dgDatos[12,e.RowIndex].Value = false;							
							}
						}else{
							if(dgDatos[12,e.RowIndex].Value.ToString() == "True"){			
								connD.deleteAsignacion2(Convert.ToInt64(dgDatos[11,dgDatos.CurrentRow.Index].Value), id_usuario);
								dgDatos[12,dgDatos.CurrentRow.Index].Style.BackColor = Color.White;
								dgDatos[11,dgDatos.CurrentRow.Index].Value = "0";
								dgDatos[7,dgDatos.CurrentRow.Index].Value  = "0";
								dgDatos[8,dgDatos.CurrentRow.Index].Value = "0";
								dgDatos[9,dgDatos.CurrentRow.Index].Value = "0";										
								dgDatos[12,e.RowIndex].Value = false;
								MessageBox.Show("Se quitó la asignación correctamente", "QUITAR ASIGNACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}						
					}				
					
					if(e.ColumnIndex == 18 ){
						if(dgDatos[18,e.RowIndex].Value.ToString() == "False" && dgDatos[16,e.RowIndex].Value.ToString() != "OPERADOR"){
							obtenerDatosSalida();
							if(dgDatos[16,e.RowIndex].Style.BackColor.Name.ToString() == "SpringGreen" &&  dgDatos[16,e.RowIndex].Value.ToString() != "OPERADOR" && dgDatos[13,e.RowIndex].Value.ToString() != "0" && 
							   dgDatos[14,e.RowIndex].Value.ToString() != "0" && dgDatos[15,e.RowIndex].Value.ToString() != "0"){								
								asignacionViaje(Convert.ToInt64(dgDatos[2,dgDatos.CurrentRow.Index].Value), Convert.ToInt64(dgDatos[13,dgDatos.CurrentRow.Index].Value), Convert.ToInt64(dgDatos[14,dgDatos.CurrentRow.Index].Value), dgDatos[15,dgDatos.CurrentRow.Index].Value.ToString(), "S");
								dgDatos[18,e.RowIndex].Style.BackColor = Color.SpringGreen;
								dgDatos[18,e.RowIndex].Value = true;							
							}else{
								MessageBox.Show("selecciona un operador valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
								dgDatos[12,e.RowIndex].Value = false;							
							}
						}else{
							if(dgDatos[18,e.RowIndex].Value.ToString() == "True"){			
								dgDatos[18,dgDatos.CurrentRow.Index].Style.BackColor = Color.White;
								connD.deleteAsignacion2(Convert.ToInt64(dgDatos[17,dgDatos.CurrentRow.Index].Value), id_usuario);
								dgDatos[17,dgDatos.CurrentRow.Index].Value = "0";
								dgDatos[13,dgDatos.CurrentRow.Index].Value  = "0";
								dgDatos[14,dgDatos.CurrentRow.Index].Value = "0";
								dgDatos[15,dgDatos.CurrentRow.Index].Value = "0";										
								dgDatos[18,e.RowIndex].Value = false;
								MessageBox.Show("Se quitó la asignación correctamente", "QUITAR ASIGNACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}						
					}			
					
				}
			}
		}		
		#endregion		
		
		#region BOTONES
		void Button1Click(object sender, EventArgs e)
		{			
			filtrosValidacion();
		}
		
			#region VALIDACION
			void CmdValidaClick(object sender, EventArgs e)
			{
				bool continua = true;
				bool error = false;
				bool entra = true;
				bool faltante = false;
				
				if(dgDatos.SelectedRows.Count > 0){
					for(int x=0; x<dgDatos.Rows.Count; x++){
						if(dgDatos.Rows[x].Selected == true){
							if(dgDatos[22,x].Value.ToString() == "SI")
								continua = false;
							
							if(dgDatos[10,x].Style.BackColor.Name.ToString() == "Black" || dgDatos[16,x].Style.BackColor.Name.ToString() == "Black")
								error = true;
						
							if((dgDatos[19,x].Value.ToString() == "OPERADOR") && dgDatos[19,x].Style.BackColor.Name.ToString() != "Yellow")
								faltante = true;					
						}
					}
						
					DialogResult rs = MessageBox.Show("Una vez validado el servicio nadie podrá hacer ningún cambio ¿Desea continuar?", "Alerta Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (DialogResult.Yes==rs){
							if(continua == true){
								for(int x=0; x<dgDatos.Rows.Count; x++){
									if(dgDatos.Rows[x].Selected == true){
										if(dgDatos[0,x].Value.ToString() == "CANCELADA" || dgDatos[0,x].Value.ToString() == "SIN CONF."){						
											new Libro_Nuevo.Complementos_Libro.FormCancelarVehiculo(this, dgDatos[4,x].Value.ToString(), Convert.ToInt64(dgDatos[1,x].Value),Convert.ToInt64(dgDatos[2,x].Value)).ShowDialog();
											filtrosValidacion();	
										}
										if(dgDatos[0,x].Value.ToString() == "Activo" || dgDatos[0,x].Value.ToString() == "C. PUNTO"){
											entra = false;
										}
									}
								}			
														
								if(faltante == true){
									MessageBox.Show("Es necesario ingresar quien a cobrado el servicio y telefono del mismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								}else if(error == true){
									DialogResult rs2 = MessageBox.Show("Existe un error de asignación. \n ¿Desea continuar?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
									if (DialogResult.OK==rs2){
										valida();
									}
								}else{
									if(entra == false){
										valida();
									}
								}				
							}else{
								MessageBox.Show("Selecciono un registro ya validado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}				
					}
				}else{
					MessageBox.Show("Seleccione un registro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}		
			#endregion
		
		#endregion
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////// ENCUESTA /////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region FILTROS
		public void filtrosEncuesta(){			
		String consulta = "";
		string campoFiltro = "";
			if(cmbEncuesta.Text == "DESTINO")
				campoFiltro ="EVENTO";
			else
				campoFiltro = cmbEncuesta.Text;	
			
			if(cbTodosEncuesta.Checked == true){
				consulta = @"select R.SALDO, R.CONF_CLIENTE, VPN.CONTACTO, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.FECHA_REGRESO, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
									R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA
									from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where
									 RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and R.estado = 'Activo' and R.FECHA_SALIDA 
									 between '"+dtpInicioEncuesta.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFinEncuesta.Value.ToString("yyyy-MM-dd")+"' and RT.Sentido='Entrada' and VPN."+campoFiltro+" like '%"+txtEncuesta.Text+"%'";	
			}else{
				consulta = @"select R.SALDO, VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  R.fecha_salida, R.FECHA_REGRESO, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
									R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA
									from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS where
									R.FECHA_SALIDA between '"+dtpInicioEncuesta.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFinEncuesta.Value.ToString("yyyy-MM-dd")+"' and RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and R.estado = 'Activo' and  r.id_re not in (select id_re from ENCUESTA) and r.id_re not in (select id_re from ENCUESTA_VENTAS)";				
			}
			if(consulta != ""){
				consulta = consulta +@" group by R.SALDO, R.CONF_CLIENTE, VPN.CONTACTO, R.ID_RE, VPN.ID , VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable,  R.fecha_salida, R.FECHA_REGRESO, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,
										R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado,  R.CONF_CLIENTE, R.ENCUESTA"; 			
				AdaptadorEncuesta(consulta);	
			}		
		}	
		#endregion		
		
		#region ADAPTADORES
		public void AdaptadorEncuesta(String Consulta){
			int contador = 0;
			string numero;			
			try{
				dgEncuesta.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{			
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();				
							 				
					dgEncuesta.Rows.Add(conn.leer["ID_RE"].ToString(),
 	                      						conn.leer["ID_COTIZACION"].ToString(),
					                      		conn.leer["FOLIO"].ToString()+numero,
					                      		conn.leer["destino"].ToString(),
					                      		conn.leer["CONTACTO"].ToString(),
						                        Convert.ToDateTime(conn.leer["fecha_salida"].ToString().Substring(0,10)).ToShortDateString(),
						                        Convert.ToDateTime(conn.leer["FECHA_REGRESO"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Tipovehiculo"].ToString(),
						                        conn.leer["cant_unidades"].ToString(),     
												conn.leer["domicilio"].ToString(),
												conn.leer["TELEFONO_R"].ToString(),
												conn.leer["precio"].ToString(),
												conn.leer["FACTURADO"].ToString(),
												conn.leer["SALDO"].ToString(), 
												"", // Datos factura
												conn.leer["anticipo"].ToString(),
												conn.leer["CompletoCamioneta"].ToString(), 
												conn.leer["observaciones"].ToString(),
												conn.leer["correo"].ToString(), 
						                        Convert.ToDateTime(conn.leer["fecha_regreso"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Estado_especial"].ToString(),
						                        conn.leer["ENCUESTA"].ToString());
					if(conn.leer["Estado_especial"].ToString().Equals("Cancelado"))
					{		
						for(int y=0; y<dgEncuesta.Columns.Count; y++)
						{
							dgEncuesta[y,contador].Style.BackColor=Color.Red;
						}
					}
					contador++;
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los servicios para la encuesta Post-venta (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{
				conn.conexion.Close();
			}
			obtieneCalificacion();
			dgEncuesta.ClearSelection();
		
			if(dgEncuesta.Rows.Count > 0 && cbTodosEncuesta.Checked == false){
				lblAvisoEncuesta.Visible = true;
			}else{
				lblAvisoEncuesta.Visible = false;
			}
		}
		#endregion
		
		#region METODOS
		public void obtieneCalificacion(){
			for(int x=0; x<dgEncuesta.Rows.Count; x++){
				String conss = "select id_re, CALIFICACION from encuesta where id_re ="+dgEncuesta[0,x].Value.ToString();
				conn.getAbrirConexion(conss);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgEncuesta[20,x].Value = conn.leer["CALIFICACION"].ToString();
					for(int y=0; y<dgEncuesta.Columns.Count; y++)
					{
						dgEncuesta[y,x].Style.BackColor=Color.LightGreen;
					}
				}else{
					dgEncuesta[20,x].Value = "0";
				}
				conn.conexion.Close();
				
				if(dgEncuesta[20,x].Value.ToString().Equals("0")){
					conss = "select calificacion from ENCUESTA_VENTAS where ESTATUS = 'Activo' and ID_RE = "+dgEncuesta[0,x].Value.ToString()+" ORDER BY ID DESC";
					conn.getAbrirConexion(conss);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgEncuesta[20,x].Value = conn.leer["calificacion"].ToString();
						for(int y=0; y<dgEncuesta.Columns.Count; y++)
							dgEncuesta[y,x].Style.BackColor=Color.LightGreen;				
					}
					conn.conexion.Close();
				}
			}
		}
		#endregion
		
		#region EVENTOS
		void DgEncuestaCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
				new FormEncuestaPost2(this, Convert.ToInt32(dgEncuesta[0,dgEncuesta.CurrentRow.Index].Value), id_usuario).ShowDialog();
		}
		
		
		void DgEncuestaCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{	
			if(e.RowIndex>-1)
				new FormEncuestaPost2(this, Convert.ToInt32(dgEncuesta[0,dgEncuesta.CurrentRow.Index].Value), id_usuario).ShowDialog();
		}
		
		void TxtEncuestaTextChanged(object sender, EventArgs e)
		{
			//if(validaAdpatadores == false)
			//	filtrosEncuesta();
		}
		
		void DtpInicioEncuestaValueChanged(object sender, EventArgs e)
		{			
			dtpFinEncuesta.Value = dtpInicioEncuesta.Value;
		}
		
		void DtpFinEncuestaValueChanged(object sender, EventArgs e)
		{
			//if(validaAdpatadores == false)
				//filtrosEncuesta();
		}
		
		void CbTodosEncuestaCheckedChanged(object sender, EventArgs e)
		{	
			if(cbTodosEncuesta.Checked == true){
				dtpInicioEncuesta.Enabled = true;
				dtpFinEncuesta.Enabled = true;
				cmbEncuesta.Enabled = true;
				txtEncuesta.Enabled = true;
				btnBuscarEncuestas.Enabled = true;
			}else{				
				dtpInicioEncuesta.Enabled = false;
				dtpFinEncuesta.Enabled = false;
				cmbEncuesta.Enabled = false;
				txtEncuesta.Enabled = false;
				btnBuscarEncuestas.Enabled = false;
				filtrosEncuesta();
			}
			//if(validaAdpatadores == false)
			//	filtrosEncuesta();
		}	

		void BtnBuscarEncuestasClick(object sender, EventArgs e)
		{
			filtrosEncuesta();
		}		
		#endregion										
		
		#region MENU
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			if(dgEncuesta.SelectedRows.Count == 1)
				new FormEncuestaPost(this, Convert.ToInt32(dgEncuesta[0,dgEncuesta.CurrentRow.Index].Value)).ShowDialog();
		}
		
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			
			if(dgEncuesta.SelectedRows.Count == 1)
				new FormEncuestaPost2(this, Convert.ToInt32(dgEncuesta[0,dgEncuesta.CurrentRow.Index].Value), id_usuario).ShowDialog();
		}
		#endregion
		
		void CmdExcelCotizadosClick(object sender, EventArgs e)
		{
			
		}
	}
}