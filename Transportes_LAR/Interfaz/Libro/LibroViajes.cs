using System.Linq.Expressions;
using System.ComponentModel;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Threading;
using iTextSharp.text;
using System.Drawing;
using System.IO;
using System;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class LibroViajes : Form
	{
		#region INSTANCIAS DE LOS OBJETOS
		public Interfaz.FormPrincipal principal = null;	
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		FormDatosFactura formDatosFact = null;
		FormValidacionEsp formValida = null;
		#endregion
		
		#region VARIABLES
		private String datoFact = "";
		private bool IVA = false;
		
		public int idFact = 0;
		
		String Hoy;
		String Fecha;
		String horaP;
		String minP;
		String horaR;
		String minR;
		String horaS;
		String minS;
		String diasemana;
		String foranea = "0";
		String FechaInicio;
		String FechaCorte;
		private String SentidoR="Completo";
		
		int IDRE = 0;
		int IDC = 0;
		
		Thread hilo;
		#endregion
		
		#region CONSTRUCTORES
		public LibroViajes(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal = principal;
			hilo=null;
		}
		
		public LibroViajes()
		{
			InitializeComponent();
			hilo=null;
		}
		
		void FormLibroViajesFormClosing(object sender, FormClosingEventArgs e){
			this.principal.libroviajes=false;
			this.principal.BringToFront();
		} 
		
		#endregion
		
		#region METODOS BOTONES
		void CmdValidacionClick(object sender, EventArgs e)
		{
			formValida.ShowDialog();
			//mostrarValidacion(); // para el hilo de ejecucion
		}
		
		void DtFechaValueChanged(object sender, EventArgs e)
		{
			Fecha = dtFecha.Value.ToString("yyyy-MM-dd");
			String dia = dtFecha.Value.ToString("dd");;
			String mes = dtFecha.Value.ToString("MM");;
			String ano = dtFecha.Value.ToString("yyyy");;
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
			
			dtFechaRegreso.Value=Convert.ToDateTime(dtFecha.Value.ToString("dd-MM-yyyy"));
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			principal.libroviajes=false;
			this.Close();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			bool continua=true;
			if(mixto==true)
			{
				int TOTAL = 0;
				double PRECIO = 0;
				for(int x=0; x<dgMixto.Rows.Count; x++)
				{
					if(Convert.ToInt64(dgMixto[2,x].Value)<1)
					{
						continua=false;
						dgMixto[1,x].Selected=true;
					}
					TOTAL=TOTAL+(Convert.ToInt16(dgMixto[2,x].Value));
					PRECIO=PRECIO+(Convert.ToDouble(dgMixto[4,x].Value));
				}
				NumUnidad.Text=TOTAL.ToString();
				txtPrecio.Text=PRECIO.ToString();
			}
			
			if(continua)
			{
				if(rbFacturar.Checked==true && idFact==0)
				{
					DialogResult rs2 = MessageBox.Show("No fueron guardados los datos de facturación. ¿Desea continuar con el guardado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs2)
						Insertar();
					else
						txtDatosFactura.Text="";
				}
				else
				{
					Insertar();
				}
			}
			else
			{
				MessageBox.Show("La captura de cantidad de unidades es erronea");
			}
		}
		
		void BtnNuevoClick(object sender, EventArgs e)
		{
			principal.libroviajes=false;
			this.Close();
			Transportes_LAR.Interfaz.Libro.LibroViajes formViajes=new Transportes_LAR.Interfaz.Libro.LibroViajes(principal);
			formViajes.BringToFront();
			formViajes.WindowState = FormWindowState.Maximized;
			formViajes.Show();
			formViajes.MdiParent=principal;
			principal.libroviajes=true;
		}
		#endregion
		
		#region SENTIDO RUTA
		public String sentidoRuta()
		{
			if(ckEntrada.Checked==true && ckSalida.Checked==true)
			{
				SentidoR="Completo";
			}
			if(ckEntrada.Checked==true && ckSalida.Checked==false)
			{
				SentidoR="Entrada";
			}
			if(ckEntrada.Checked==false && ckSalida.Checked==true)
			{
				SentidoR="Salida";
			}
			
			return SentidoR;
		}
		#endregion
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Libro.LibroViajes formViajes)
		{
			formViajes.cmbUnidades.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			formViajes.txtPagoOperador.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formViajes.txtAnticipos.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formViajes.txtPrecio.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formViajes.txtAnticipos.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formViajes.NumKms.Text += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			formViajes.txtTel_p.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formViajes.txtKm_p.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formViajes.txtCas_p.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formViajes.txtPrec_p.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formViajes.txtPrecTotal_p.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formViajes.dudUnid_p.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			formViajes.txtDetalle.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		private Boolean espaciosBlanco()
		{
			int cant=Convert.ToInt16(NumUnidad.Value);
			if(txtResponsable.Text == "" || txtCliente.Text == "" || cmbUnidades.Text== "" || txtDomicilio.Text=="" || txtCruces.Text == "" || txtColonia.Text=="" || txtDestino.Text=="" || txtCasetas.Text=="" || txtPrecio.Text == "" || txtPagoOperador.Text=="")
			{
				MessageBox.Show("Existen campos Obligatorios vacios");
				if(txtResponsable.Text=="")
					txtResponsable.BackColor = Color.LightPink;
				if(txtCliente.Text=="")
					txtCliente.BackColor = Color.LightPink;
				if(mixto==false && cmbUnidades.Text=="")
				 	cmbUnidades.BackColor = Color.LightPink;
				if(txtDomicilio.Text=="")
					txtDomicilio.BackColor = Color.LightPink;
				if(txtCruces.Text=="")
					txtCruces.BackColor = Color.LightPink;
				if(txtColonia.Text=="")
					txtColonia.BackColor = Color.LightPink;
				if(txtDestino.Text=="")
				 	txtDestino.BackColor = Color.LightPink;
				if(txtCasetas.Text=="")
					txtCasetas.BackColor = Color.LightPink;
				if(txtPrecio.Text=="")
					txtPrecio.BackColor = Color.LightPink;
				if(txtPagoOperador.Text=="")
					txtPagoOperador.BackColor = Color.LightPink;
				if(txtRefVisual.Text=="")
					txtRefVisual.BackColor = Color.LightPink;
							
				return true;
			}
			else
			{
				if(ckSalida.Checked==true || ckEntrada.Checked==true)
				{
					if(cant>0)
					{
						txtResponsable.BackColor = Color.White;
						txtCliente.BackColor = Color.White;
						cmbUnidades.BackColor = Color.White;
						txtDomicilio.BackColor = Color.White;
						txtCruces.BackColor = Color.White;
						txtColonia.BackColor = Color.White;
						txtDestino.BackColor = Color.White;
						txtCasetas.BackColor = Color.White;
						txtPrecio.BackColor = Color.White;
						txtPagoOperador.BackColor = Color.White;
						txtRefVisual.BackColor = Color.White;
						return false;
					}
					else
					{
						MessageBox.Show("Elija cantidad de unidades");
						return true;
					}
				}
				else
				{
					MessageBox.Show("Seleccione sentido (Entrada, Salida o Ambos)");
					return true;
				}
			}
		}
		#endregion
		
		#region CARGAR FORMULARIO
		void LibroViajesLoad(object sender, EventArgs e)
		{			
			getViajesProspectos();
			
			formValida = new FormValidacionEsp(this);
			getCargarValidacionCampos(this);
			dtFecha.Value = DateTime.Now;
			dtFechaRegreso.Value = DateTime.Now;
			Hoy = DateTime.Now.ToString("yyyy-MM-dd");
			Fecha = dtFecha.Value.ToString("yyyy-MM-dd");
			dtpSal_p.Value=DateTime.Now;
			txtSal_p.Text=dtpSal_p.Value.ToString("dd/MM");
			
			Adaptador();
			
			txtResponsable.AutoCompleteCustomSource = auto.AutocompleterResponsable();
			txtResponsable.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtCliente.AutoCompleteCustomSource = auto.AutocompleteContactoCliente();
			txtCliente.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
						
			txtResp.AutoCompleteCustomSource = auto.AutocompleterResponsable();
			txtResp.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtResp.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtClienteBusqueda.AutoCompleteCustomSource = auto.AutocompleteContactoCliente();
			txtClienteBusqueda.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtClienteBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtDatosFactura.AutoCompleteCustomSource = auto.AutoReconocimiento("select RAZON_SOCIAL dato from DATOS_FACTURA");
			txtDatosFactura.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtDatosFactura.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtDestino.AutoCompleteCustomSource = auto.AutoReconocimiento("select DESTINO dato from RUTA_ESPECIAL");
			txtDestino.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtDestino.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			//**************
			txtResp_p.AutoCompleteCustomSource = auto.AutoReconocimiento("select RESPONSABLE dato from VIAJE_PROSPECTO");
			txtResp_p.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtResp_p.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtBusResp.AutoCompleteCustomSource = auto.AutoReconocimiento("select RESPONSABLE dato from VIAJE_PROSPECTO");
			txtBusResp.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtBusResp.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtBusCli.AutoCompleteCustomSource = auto.AutoReconocimiento("select CLIENTE dato from VIAJE_PROSPECTO");
			txtBusCli.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtBusCli.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtDes_p.AutoCompleteCustomSource = auto.AutoReconocimiento("select DESTINO dato from VIAJE_PROSPECTO");
			txtDes_p.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtDes_p.AutoCompleteSource = AutoCompleteSource.CustomSource;
			//**************
			
			cmbEstado.SelectedIndex = 0;
			cmbUnidades.SelectedIndex = 0;
			cmbTipoPago.SelectedIndex = 0;
			
			dtFecha.Focus();
		
			cbUsu_p.Items.Clear();
			cbUsu_p.Items.Add("40");
			cbUsu_p.Items.Add("41");
			cbUsu_p.Items.Add("42");
			cbUsu_p.Items.Add("43");
			cbUsu_p.Items.Add("44");
			cbUsu_p.Items.Add("45");
			cbUsu_p.Items.Add("46");
			cbUsu_p.Items.Add("47");
			cbUsu_p.Items.Add("48");
			cbUsu_p.Items.Add("49");
			cbUsu_p.Items.Add("50");
			cbUsu_p.Items.Add("51");
			cbUsu_p.Items.Add("52");
			cbUsu_p.Items.Add("53");
			cbUsu_p.Items.Add("54");
			cbUsu_p.Items.Add("55");
			cbUsu_p.Items.Add("56");
			
			cbUsu_p.SelectedIndex=0;
		}
		
		#endregion
	
		#region EVENTO - CERRADO
		void LibroViajesFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.libroviajes=false;
		}
		#endregion
		
		#region METODOS 
		public void Cero()
		{
			if(Convert.ToInt32(NumHoraPlanton.Text)<10)
			{
				horaP = "0" + NumHoraPlanton.Text;
			}
			else
			{
				horaP = NumHoraPlanton.Text.ToString();
			}
			if(Convert.ToInt32(NumMinPlanton.Text)<10)
			{
				minP = "0" + NumMinPlanton.Text;
			}
			else
			{
				minP = NumMinPlanton.Text.ToString();
			}
			if(Convert.ToInt32(NumHoraRegreso.Text)<10)
			{
				horaR = "0" + NumHoraRegreso.Text;
			}
			else
			{
				horaR = NumHoraRegreso.Text.ToString();
			}
			if(Convert.ToInt32(NumMinRegreso.Text)<10)
			{
				minR = "0" + NumMinRegreso.Text;
			}
			else
			{
				minR = NumMinRegreso.Text.ToString();
			}
			if(Convert.ToInt32(NumHoraServicio.Text)<10)
			{
				horaS = "0" + NumHoraServicio.Text;
			}
			else
			{
				horaS = NumHoraServicio.Text.ToString();
			}
			if(Convert.ToInt32(NumMinServicio.Text)<10)
			{
				minS = "0" + NumMinServicio.Text;
			}
			else
			{
				minS = NumMinServicio.Text.ToString();
			}
		}
		
		
		#endregion
		
		#region LIMPIAR
		private void Limpiar()
		{
			txtResponsable.Text = "";
			txtCliente.Text = "";
			cmbUnidades.Text = "";
			txtDomicilio.Text = "";
			txtCruces.Text = "";
			txtColonia.Text = "";
			txtDestino.Text = "";
			txtCasetas.Text = "";
			txtPrecio.Text = "";
			txtPagoOperador.Text = "";
			txtTelefono.Text = "";
			txtDatosFactura.Text = "";
			txtObservaciones.Text = "";
		}
		#endregion
		
		#region ADAPTADORES
		void TxtAliasTextChanged(object sender, EventArgs e)
		{
			FechaInicio = (dtFechaEspecialInicio.Value.ToShortDateString());
			FechaCorte = (dtFechaEspecialFin.Value.ToShortDateString());
			Adaptador();
		}
	
		void TxtClienteBusquedaTextChanged(object sender, EventArgs e)
		{
			FechaInicio = (dtFechaEspecialInicio.Value.ToShortDateString());
			FechaCorte = (dtFechaEspecialFin.Value.ToShortDateString());
			Adaptador();
		}
		
		#endregion
		
		#region FORANEO
		void CkforaneoCheckedChanged(object sender, EventArgs e)
		{
			if(ckforaneo.Checked == true)
			{
				foranea = "1";
				txtPagoOperador.Text=((Convert.ToDouble(txtPrecio.Text)-Convert.ToDouble(((txtCasetas.Text!="N/A")?txtCasetas.Text:"0")))*.20).ToString();
			}
			else
			{
				foranea = "0";
				
				if(cmbUnidades.Text=="Camion")
					{
						txtPagoOperador.Text="120";
						if(Convert.ToDouble(txtPrecio.Text)<120)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
					if(cmbUnidades.Text=="Camioneta")
					{
						txtPagoOperador.Text="100";
						if(Convert.ToDouble(txtPrecio.Text)<100)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
			}
		}
		#endregion
		
		#region EVENTOS
		void DtFechaEspecialInicioValueChanged(object sender, EventArgs e)
		{
			dtFechaEspecialFin.Value=Convert.ToDateTime(dtFechaEspecialInicio.Value.ToString("dd-MM-yyyy"));
			
			FechaInicio = (dtFechaEspecialInicio.Value.ToShortDateString());
			FechaCorte = (dtFechaEspecialFin.Value.ToShortDateString());
			Adaptador();
		}
		
		void DtFechaEspecialFinValueChanged(object sender, EventArgs e)
		{
			FechaInicio = (dtFechaEspecialInicio.Value.ToShortDateString());
			FechaCorte = (dtFechaEspecialFin.Value.ToShortDateString());
			Adaptador();
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if(revisaDuplicado(dataViajesEspeciales[8, dataViajesEspeciales.CurrentRow.Index].Value.ToString(), txtDestino.Text)==true)
			{
				if(revisaFactura(dataViajesEspeciales[21, dataViajesEspeciales.CurrentRow.Index].Value.ToString())==true && txtDatosFactura.Text!=dataViajesEspeciales[21, dataViajesEspeciales.CurrentRow.Index].Value.ToString())
				{
					Modificar();
				}
				else
				{
					DialogResult rs2 = MessageBox.Show("Servicio facturado avisar a Vanessa que regresara flujo. ¿Desea continuar con la modificación?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs2)
						Modificar();
				}
			}
		}
		
		bool revisaDuplicado(String destino1, String destino2)
		{
			bool respuesta=true;
			
			if(destino1!=destino2)
			{
				DialogResult rs2 = MessageBox.Show("El destino no coincide con el seleccionado. Posible sobreescriura de datos. ¿Desea continuar con la modificación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs2)
				{
					respuesta=true;
				}
				else
				{
					respuesta=false;
				}
			}
			
			return respuesta;
		}
		
		bool revisaFactura(string ID)
		{
			bool respuesta=true;
			String conss = "select * from RUTA_ESPECIAL where ID_RE='"+ID+"' and FACTURADO='3'";
			conn.getAbrirConexion(conss);
			conn.leer=conn.comando.ExecuteReader();
			
			if(conn.leer.Read())
				respuesta=false;
			else
				respuesta=true;
					
			conn.conexion.Close();
			
			return respuesta;
		}
		
		void DataViajesEspecialesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				dgAnticipos.Rows.Clear();
				ckforaneo.Checked=false;
				lblConfirma.Visible=true;
				txtConfirma.Visible=true;
				cmdConfirma.Visible=true;
				txtConfirma.Enabled=true;
				cmdConfirma.Enabled=true;
				rbFacturar.Checked=false;
				cbCobra.Checked=false;
				idFact=0;
				
				this.IDRE = Convert.ToInt16(dataViajesEspeciales[21,dataViajesEspeciales.CurrentRow.Index].Value);
				
				conn.getAbrirConexion("select ID_C from RUTA_ESPECIAL where ID_RE="+IDRE);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					this.IDC = Convert.ToInt16(conn.leer["ID_C"]);
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select HoraInicio, foranea, Kilometros from RUTA WHERE Sentido='Entrada' and IdSubEmpresa='"+this.IDC+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NumHoraServicio.Text = conn.leer["HoraInicio"].ToString().Substring(0,2);
					NumMinServicio.Text = conn.leer["HoraInicio"].ToString().Substring(3,2);
					NumKms.Text=conn.leer["Kilometros"].ToString();
					
					if(conn.leer["foranea"].ToString()=="1")
						ckforaneo.Checked=true;
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select HoraInicio from RUTA WHERE Sentido='Salida' and IdSubEmpresa='"+this.IDC+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NumHoraRegreso.Text = conn.leer["HoraInicio"].ToString().Substring(0,2);
					NumMinRegreso.Text = conn.leer["HoraInicio"].ToString().Substring(3,2);
				}
				conn.conexion.Close();
				
				btnModificar.Enabled 	= true;
				txtResponsable.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[1].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[1].Value.ToString());
				txtCliente.Text	 		= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[0].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[0].Value.ToString());
				dtFecha.Value 			= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[4].Value==null)?DateTime.Now:(Convert.ToDateTime(dataViajesEspeciales.Rows[e.RowIndex].Cells[4].Value)));
				dtFechaRegreso.Value 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[17].Value==null)?DateTime.Now:(Convert.ToDateTime(dataViajesEspeciales.Rows[e.RowIndex].Cells[17].Value)));
				txtCorreo.Text 			= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[16].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[16].Value.ToString());
				NumUnidad.Text 			= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[6].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[6].Value.ToString());
				txtDomicilio.Text 		= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[7].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[7].Value.ToString());
				txtDestino.Text 		= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[8].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[8].Value.ToString());
				txtCasetas.Text 		= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[11].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[11].Value.ToString());
				txtPrecio.Text 			= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[12].Value==null)?"0":dataViajesEspeciales.Rows[e.RowIndex].Cells[12].Value.ToString());
				txtTelefono.Text 		= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[13].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[13].Value.ToString());
				//txtDatosFactura.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[14].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[14].Value.ToString());
				txtObservaciones.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[15].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[15].Value.ToString());
				//NumHoraPlanton.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(0,2));
				//NumMinPlanton.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(3,2));
				txtAnticipos.Text 		= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[18].Value==null)?"0":dataViajesEspeciales.Rows[e.RowIndex].Cells[18].Value.ToString());
				cmbEstado.Text 			= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[19].Value==null)?"Activo":dataViajesEspeciales.Rows[e.RowIndex].Cells[19].Value.ToString());
				cmbEstado.Text 			= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[24].Value==null)?dataViajesEspeciales.Rows[e.RowIndex].Cells[24].Value.ToString():dataViajesEspeciales.Rows[e.RowIndex].Cells[24].Value.ToString());
				
				if(dataViajesEspeciales[22,dataViajesEspeciales.CurrentRow.Index].Value.ToString()!="")
				{
					txtConfirma.Text=dataViajesEspeciales[22,dataViajesEspeciales.CurrentRow.Index].Value.ToString();
					txtConfirma.Enabled=false;
					cmdConfirma.Enabled=false;
				}
				else
				{
					txtConfirma.Text="";
				}
				
				//bool antic=false;
				String consults = "select R.cantidad_usuarios, CL.Estado, CL.Rumbo, R.ref_Visual, R.tipoVehiculo, R.cantidad_usuarios, R.FACTURADO, R.TIPO_PAGO, R.anticipo, R.NUMERO_ANTI, R.SALDO, R.OP_COBRA, R.comentario from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and R.ID_RE ='"+IDRE+"'";
				conn.getAbrirConexion(consults);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					txtCruces.Text = conn.leer["Rumbo"].ToString();
					txtColonia.Text = conn.leer["Estado"].ToString();
					txtRefVisual.Text = conn.leer["ref_Visual"].ToString();
					cmbUnidades.Text  = conn.leer["tipoVehiculo"].ToString();
					nudPasajeros.Text = conn.leer["cantidad_usuarios"].ToString();
					txtComentario.Text = conn.leer["comentario"].ToString();
					
					if(conn.leer["OP_COBRA"].ToString()=="1")
					{
						cbCobra.Checked=true;
					}
					
					if(conn.leer["FACTURADO"].ToString()!="0")
					{
						rbFacturar.Checked=true;
						txtDatosFactura.Enabled=true;
						//cmbTipoPago.Enabled=true;
						cmdIngresar.Enabled=true;
						cmdRevisar.Enabled=true;
						cmbTipoPago.Text=conn.leer["TIPO_PAGO"].ToString();
					}
					else
					{
						rbFacturar.Checked=false;
						txtDatosFactura.Enabled=false;
						//cmbTipoPago.Enabled=false;
						cmdIngresar.Enabled=false;
						cmdRevisar.Enabled=false;
						//cmbTipoPago.SelectedItem = 0;
					}
					
					if(Convert.ToInt64(conn.leer["anticipo"])>0)
					{
						cbAnticipos.Checked=true;
						txtAnticipos.Text=conn.leer["anticipo"].ToString();
						txtSaldo.Text=conn.leer["SALDO"].ToString();
						
						//antic=true;
					}
					else
					{
						cbAnticipos.Checked=false;
						txtAnticipos.Text="0.00";
						txtSaldo.Text=conn.leer["SALDO"].ToString();
					}
				}
				conn.conexion.Close();
				
				txtDatosFactura.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[14].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[14].Value.ToString());
				
				//if(antic==true)
				//{
					String consulta="select * from ANTICIPOS_ESPECIALES where ID_RE="+IDRE;
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgAnticipos.Rows.Add(conn.leer["CANTIDAD"].ToString(), conn.leer["NUMERO"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), "0");
					}
					conn.conexion.Close();
					
					//if(txtPagoOperador.Text!="" ||)
				//}
				
				if(cmbUnidades.Text=="MIXTO")
				{
					dgMixto.Rows.Clear();
					cbMixto.Checked=true;
					
					conn.getAbrirConexion("SELECT * FROM VIAJES_MIXTOS WHERE ID_RE ='"+ ((dataViajesEspeciales.Rows[e.RowIndex].Cells[21].Value==null)?"Activo":dataViajesEspeciales.Rows[e.RowIndex].Cells[21].Value.ToString()) +"'");
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgMixto.Rows.Add(conn.leer["ID"].ToString(), conn.leer["TIPO"].ToString(), conn.leer["CANT_UNIDADES"].ToString(), conn.leer["USUARIOS"].ToString(), conn.leer["PRECIO_VIAJE"].ToString(), conn.leer["PAGO_OPERADOR"].ToString());
					}
					conn.conexion.Close();
				}
				else
				{
					dgMixto.Rows.Clear();
					cbMixto.Checked=false;
				}
				
				btnAgregar.Enabled = false;
			
				/*conn.getAbrirConexion("select ID_RE, ID_C from RUTA_ESPECIAL where responsable ='"+dataViajesEspeciales.Rows[e.RowIndex].Cells[1].Value.ToString()+"' and FECHA ='"+dataViajesEspeciales.Rows[e.RowIndex].Cells[2].Value.ToString().Substring(0,10)+"' and HORA ='"+dataViajesEspeciales.Rows[e.RowIndex].Cells[3].Value.ToString()+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					this.IDRE = (Convert.ToInt32(conn.leer["ID_RE"]));
					this.IDC = (Convert.ToInt32(conn.leer["ID_C"]));
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select HoraInicio from RUTA WHERE Sentido='Entrada' and IdSubEmpresa='"+this.IDC+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NumHoraServicio.Text = conn.leer["HoraInicio"].ToString().Substring(0,2);
					NumMinServicio.Text = conn.leer["HoraInicio"].ToString().Substring(3,2);
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select HoraInicio from RUTA WHERE Sentido='Salida' and IdSubEmpresa='"+this.IDC+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NumHoraRegreso.Text = conn.leer["HoraInicio"].ToString().Substring(0,2);
					NumMinRegreso.Text = conn.leer["HoraInicio"].ToString().Substring(3,2);
				}
				conn.conexion.Close();*/
				
				//cmbUnidades.SelectedIndex = 0;
				
				txtPagoOperador.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[20].Value==null)?"Activo":dataViajesEspeciales.Rows[e.RowIndex].Cells[20].Value.ToString());
			}
		}
		#endregion
		
		#region METODO MODIFICAR
		void Modificar()
		{
			if(espaciosBlanco()==false)
			{
				Cero();
				String cambio = "NO";
				Int64 cant = 0;
				//MessageBox.Show(NumUnidad.Text+"=="+dataViajesEspeciales.Rows[dataViajesEspeciales.CurrentRow.Index].Cells[6].Value.ToString());
				if(NumUnidad.Text==dataViajesEspeciales.Rows[dataViajesEspeciales.CurrentRow.Index].Cells[6].Value.ToString())
				{
					cambio = "NO";
				}
				else if(Convert.ToInt64(NumUnidad.Text)>Convert.ToInt64(dataViajesEspeciales.Rows[dataViajesEspeciales.CurrentRow.Index].Cells[6].Value.ToString()))
				{
					cambio = "MAS";
					cant=Convert.ToInt64(NumUnidad.Text)-Convert.ToInt64(dataViajesEspeciales.Rows[dataViajesEspeciales.CurrentRow.Index].Cells[6].Value.ToString());
				}
				else if(Convert.ToInt64(NumUnidad.Text)<Convert.ToInt64(dataViajesEspeciales.Rows[dataViajesEspeciales.CurrentRow.Index].Cells[6].Value.ToString()))
				{
					cambio = "MENOS";
					cant=Convert.ToInt64(dataViajesEspeciales.Rows[dataViajesEspeciales.CurrentRow.Index].Cells[6].Value.ToString())-Convert.ToInt64(NumUnidad.Text);
				}
					
				new Conexion_Servidor.Libros.SQL_Libros().getActualizarRutaEspecial(dtFecha.Value.ToString("yyyy-MM-dd"),
				                                                                  Convert.ToString(NumHoraServicio.Text + ":" + NumMinServicio.Text),
				                                                                  Convert.ToString(NumHoraPlanton.Text + ":" + NumMinPlanton.Text),
				                                                                  Convert.ToString(NumHoraRegreso.Text + ":" + NumMinRegreso.Text),
				                                                                  txtResponsable.Text,
				                                                                  txtCliente.Text,
				                                                                  Convert.ToString(NumUnidad.Value),
				                                                                  cmbUnidades.Text,
				                                                                  txtDomicilio.Text,
				                                                                  txtCruces.Text,
				                                                                  txtColonia.Text, 
				                                                                  txtDestino.Text,
				                                                                  Convert.ToString(txtCasetas.Text),
				                                                                  txtPrecio.Text,
				                                                                  Convert.ToString(NumKms.Value),
				                                                                  txtTelefono.Text,
				                                                                  txtDatosFactura.Text,
				                                                                  txtObservaciones.Text,
				                                                                  txtPagoOperador.Text,
				                                                                  diasemana,
																				  foranea,
																				  principal.idUsuario,
																				  sentidoRuta(),
																				  this.IDRE,
																				  this.IDC,
																				  txtCorreo.Text,
																				  dtFechaRegreso.Value.ToString("yyyy-MM-dd"), 
																				  txtAnticipos.Text,
																				  cmbEstado.Text,
																				  txtRefVisual.Text,
																				  Convert.ToInt16(nudPasajeros.Text),
																				  mixto,
																				  dgMixto,
																				  cambio,
																				  cant,
																				  ((rbFacturar.Checked==true)?1:0),
																				  cmbTipoPago.Text,
																				  ((txtSaldo.Text=="")?"0":txtSaldo.Text),
																				  ((cbAnticipos.Checked==true)?txtNumeroRef.Text:"0"),
																				  cbAnticipos.Checked,
																				  dgAnticipos, ((cbCobra.Checked==true)?1:0),
																				  txtComentario.Text,
																				  ((cbEncuesta.Checked==true)?"1":"0"));
				
				
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
				mensaje.Show();
				
				principal.libroviajes=false;
				this.Close();
				Transportes_LAR.Interfaz.Libro.LibroViajes formViajes=new Transportes_LAR.Interfaz.Libro.LibroViajes(principal);
				formViajes.BringToFront();
				formViajes.WindowState = FormWindowState.Maximized;
				formViajes.Show();
				formViajes.MdiParent=principal;
				principal.libroviajes=true;
			}
			else
			{
				MessageBox.Show("No se actualizaron los registros en la BD");
			} 
		}
		#endregion
		
		#region METODO INSERTAR
		void Insertar()
		{
			if(espaciosBlanco()==false)
			{
				Cero();
				new Conexion_Servidor.Libros.SQL_Libros().getInsertarRutaEspecial(dtFecha.Value.ToString("yyyy-MM-dd"),
				                                                                  Convert.ToString(NumHoraServicio.Text + ":" + NumMinServicio.Text),
				                                                                  Convert.ToString(NumHoraPlanton.Text + ":" + NumMinPlanton.Text),
				                                                                  Convert.ToString(NumHoraRegreso.Text + ":" + NumMinRegreso.Text),
				                                                                  txtResponsable.Text,
				                                                                  txtCliente.Text,
				                                                                  Convert.ToString(NumUnidad.Value),
				                                                                  cmbUnidades.Text,
				                                                                  txtDomicilio.Text,
				                                                                  txtCruces.Text,
				                                                                  txtColonia.Text, 
				                                                                  txtDestino.Text,
				                                                                  Convert.ToString(txtCasetas.Text),
				                                                                  txtPrecio.Text,
				                                                                  Convert.ToString(NumKms.Value),
				                                                                  txtTelefono.Text,
				                                                                  txtDatosFactura.Text,
				                                                                  txtObservaciones.Text,
				                                                                  txtPagoOperador.Text,
				                                                                  diasemana,
																				  foranea,
																				  principal.idUsuario,
																				  sentidoRuta(),
																				  txtCorreo.Text,
																				  dtFechaRegreso.Value.ToString("yyyy-MM-dd"),
																				  txtAnticipos.Text,
																				  cmbEstado.Text,
																				  cmbUnidades.Text,
																				  Convert.ToInt16(nudPasajeros.Text),
																				  txtRefVisual.Text,
																				  mixto,
																				  dgMixto,
																				  ((rbFacturar.Checked==true)?1:0),
																				  cmbTipoPago.Text,
																				  txtSaldo.Text,
																				  ((cbAnticipos.Checked==true)?txtNumeroRef.Text:""),
																				  cbAnticipos.Checked,
																				  dgAnticipos, ((cbCobra.Checked==true)?1:0),
																				  txtComentario.Text,
																				  ((cbEncuesta.Checked==true)?"1":"0"));
				
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron guardados correctamente");
				mensaje.Show();
				
				principal.libroviajes=false;
				this.Close();
				Transportes_LAR.Interfaz.Libro.LibroViajes formViajes=new Transportes_LAR.Interfaz.Libro.LibroViajes(principal);
				formViajes.BringToFront();
				formViajes.WindowState = FormWindowState.Maximized;
				formViajes.Show();
				formViajes.MdiParent=principal;
				principal.libroviajes=true;
				
				if(confirmada==true)
				{
					String sentencia = "UPDATE VIAJE_PROSPECTO SET ESTATUS='2' WHERE ID="+dgProspectos[0,dgProspectos.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					confirmada=false;
					
					dgProspectos.ClearSelection();
					limpiaDatos();
				}
			}
			else
			{
				MessageBox.Show("No se insertarón los registros en la BD");
			} 
		}
		#endregion
		
		#region EVENTOS KEYPRESS
		void NumHoraPlantonKeyPress(object sender, KeyPressEventArgs e)
		{
			 if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
		}
		
		void NumMinPlantonKeyPress(object sender, KeyPressEventArgs e)
		{
			 if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
		}
		
		void NumHoraServicioKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)))
            {
                
            }
		}
		
		void NumMinServicioKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
		}
		
		void NumHoraRegresoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
		}
		
		void NumMinRegresoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
		}
		
		void CmbUnidadesKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
		
		void CmbEstadoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
		#endregion
		
		#region DATOS (RESPONSABLE - CLIENTE)
		void TxtResponsableKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				
				try
				{
					conn.getAbrirConexion("select C.Nombre, C.Telefono, R.factura, R.domicilio, R.correo, CL.Estado, CL.Rumbo from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and R.responsable ='"+txtResponsable.Text+"'");
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						txtCliente.Text = conn.leer["Nombre"].ToString();
						txtDomicilio.Text = conn.leer["domicilio"].ToString();
						txtCruces.Text = conn.leer["Rumbo"].ToString();
						txtColonia.Text = conn.leer["Estado"].ToString();
						txtCorreo.Text = conn.leer["correo"].ToString();
						txtTelefono.Text = conn.leer["Telefono"].ToString();
						datoFact = conn.leer["factura"].ToString();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();
				
				getID_FACT(datoFact);
				
				txtCliente.Focus();
			}
		}
			
		void TxtClienteKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				try
				{
					conn.getAbrirConexion("select R.responsable, C.Telefono, R.factura, R.domicilio, R.correo, CL.Estado, CL.Rumbo from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and C.Nombre ='"+txtCliente.Text+"'");
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						txtResponsable.Text = conn.leer["responsable"].ToString();
						txtDomicilio.Text = conn.leer["domicilio"].ToString();
						txtCruces.Text = conn.leer["Rumbo"].ToString();
						txtColonia.Text = conn.leer["Estado"].ToString();
						txtCorreo.Text = conn.leer["correo"].ToString();
						txtTelefono.Text = conn.leer["Telefono"].ToString();
						datoFact = conn.leer["factura"].ToString();
						
						aurocompleteDomicilio();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();
				
				getID_FACT(datoFact);
				
				txtDomicilio.Focus();
			}
		}
		#endregion
		
		#region EVENTOS FOCUS
		void NumHoraPlantonKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumMinPlanton.Focus();
			}
		}
		
		void NumMinPlantonKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumHoraServicio.Focus();
			}
		}
		
		void NumHoraServicioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumMinServicio.Focus();
			}
		}
		
		void NumMinServicioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumHoraRegreso.Focus();
			}
		}
		
		void NumHoraRegresoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumMinRegreso.Focus();
			}
		}
		
		void NumMinRegresoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				dtFecha.Focus();
			}
		}
		
		void DtFechaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				dtFechaRegreso.Focus();
			}
		}
		
		void DtFechaRegresoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtResponsable.Focus();
			}
		}
		
		void NumUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				nudPasajeros.Focus();
			}
			
			if(NumUnidad.Text!="")
			{
				if(IVA==false)
				{
					txtSaldo.Text = ((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
				}
				else
				{
					double montoIva = (Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))*.16;
					txtSaldo.Text = (((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))+montoIva)-Convert.ToDouble(txtAnticipos.Text)).ToString();
				}
			}
		}
		
		void NudPasajerosKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				cmbUnidades.Focus();
			}
		}
		
		void CmbUnidadesKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumKms.Focus();
			}
		}
		
		void TxtDomicilioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				try
				{
					conn.getAbrirConexion("select C.Telefono, R.factura, R.correo, CL.Estado, CL.Rumbo from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and C.Nombre ='"+txtCliente.Text+"' and R.responsable ='"+txtResponsable.Text+"' and R.DOMICILIO='"+txtDomicilio.Text+"'");
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						txtCruces.Text = conn.leer["Rumbo"].ToString();
						txtColonia.Text = conn.leer["Estado"].ToString();
						txtCorreo.Text = conn.leer["correo"].ToString();
						txtTelefono.Text = conn.leer["Telefono"].ToString();
						txtDatosFactura.Text = conn.leer["factura"].ToString();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();
				
				txtCruces.Focus();
			}
		}
		
		void TxtCrucesKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtColonia.Focus();
			}
		}
		
		void TxtColoniaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtRefVisual.Focus();
			}
		}
		
		void TxtRefVisualKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtDestino.Focus();
			}
		}
		
		void TxtDestinoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtCorreo.Focus();
			}
		}
		
		void TxtCorreoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				ckEntrada.Focus();
			}
		}
		
		void CkEntradaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				ckSalida.Focus();
			}
		}
		
		void CkSalidaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				ckforaneo.Focus();
			}
		}
		
		void CkforaneoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				cmbEstado.Focus();
			}
		}
		
		void CmbEstadoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtTelefono.Focus();
			}
		}
		
		void TxtPrecioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtCasetas.Focus();
			}
			else
			{
				if(txtPrecio.Text=="")
					txtPrecio.Text="0";
				
				if(IVA==false)
				{
					txtSaldo.Text = ((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
				}
				else
				{
					double montoIva = (Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))*.16;
					txtSaldo.Text = (((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text)+montoIva)-Convert.ToDouble(txtAnticipos.Text))).ToString();
				}
				
				if(ckforaneo.Checked==true)
				{
					txtPagoOperador.Text=((Convert.ToDouble(txtPrecio.Text)-Convert.ToDouble(((txtCasetas.Text!="N/A")?txtCasetas.Text:"0")))*.20).ToString();
				}
				else
				{
					if(cmbUnidades.Text=="Camion")
					{
						txtPagoOperador.Text="120";
						if(Convert.ToDouble(txtPrecio.Text)<120)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
					if(cmbUnidades.Text=="Camioneta")
					{
						txtPagoOperador.Text="100";
						if(Convert.ToDouble(txtPrecio.Text)<100)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
				}
			}
		}
		
		void TxtAnticiposKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumKms.Focus();
			}
			else
			{
				if(txtAnticipos.Text=="")
				{
					txtAnticipos.Text="0";
				}
				txtSaldo.Text=((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
			}
		}
		
		void NumKmsKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtPrecio.Focus();
			}
		}
		
		void TxtPagoOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				cbAnticipos.Focus();
			}
			else
			{
				if(txtPagoOperador.Text=="")
				{
					txtPagoOperador.Text="0";
				}
				if(!(txtPrecio.Text=="0" && txtPagoOperador.Text=="0"))
				{
					if(Convert.ToDouble(txtPagoOperador.Text)>=Convert.ToDouble(txtPrecio.Text))
					{
						MessageBox.Show("Cantidad no valida.");
						txtPagoOperador.Text="0";
					}
				}
			}
		}
		
		void TxtCasetasKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtPagoOperador.Focus();
			}
			else
			{
				if(txtCasetas.Text=="")
					txtCasetas.Text="0";
				
				if(ckforaneo.Checked==true)
				{
					txtPagoOperador.Text=((Convert.ToDouble(txtPrecio.Text)-Convert.ToDouble(((txtCasetas.Text!="N/A")?txtCasetas.Text:"0")))*.20).ToString();
				}
				else
				{
					if(cmbUnidades.Text=="Camion")
					{
						txtPagoOperador.Text="120";
						if(Convert.ToDouble(txtPrecio.Text)<120)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
					if(cmbUnidades.Text=="Camioneta")
					{
						txtPagoOperador.Text="100";
						if(Convert.ToDouble(txtPrecio.Text)<100)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
				}
			}
		}
		
		void TxtTelefonoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtObservaciones.Focus();
			}
		}
		
		void TxtDatosFacturaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta = "select ID from DATOS_FACTURA where RAZON_SOCIAL='"+txtDatosFactura.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idFact = Convert.ToInt16(conn.leer["ID"]);
					txtObservaciones.Focus();
					//cmbTipoPago.Enabled=true;
					cmdRevisar.Enabled=true;
				}
				conn.conexion.Close();
			}
		}
		
		void getID_FACT(String dato)
		{
			String consulta = "select ID from DATOS_FACTURA where RAZON_SOCIAL='"+dato+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				idFact = Convert.ToInt16(conn.leer["ID"]);
			}
			conn.conexion.Close();
		}
		
		void TxtObservacionesKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				rbFacturar.Focus();
			}
		}
		
		void CbAnticiposKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				btnAgregar.Focus();
			}
		}
		
		void RbFacturarKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				NumUnidad.Focus();
			}
		}
		#endregion
		
		#region VALIDACION HORA
		void NumHoraPlantonTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumHoraPlanton.Text))>23)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton.Text = "00";
				}
			}
			catch(Exception)
			{
				NumHoraPlanton.Text = "00";
			}
		}
		
		void NumMinPlantonTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumMinPlanton.Text))>59)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton.Text = "00";
				}
			}
			catch(Exception)
			{
				NumHoraPlanton.Text = "00";
			}
		}
		
		void NumHoraServicioTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumHoraServicio.Text))>23)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton.Text = "00";
				}
				else
				{
					cambiaPlanton();
				}
			}
			catch(Exception)
			{
				NumHoraPlanton.Text = "00";
			}
		}
		
		void NumMinServicioTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumMinServicio.Text))>59)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton.Text = "00";
				}
				else
				{
					cambiaPlanton();
				}
			}
			catch(Exception)
			{
				NumHoraPlanton.Text = "00";
			}
		}
		
		void NumHoraRegresoTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumHoraRegreso.Text))>23)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton.Text = "00";
				}
			}
			catch(Exception)
			{
				NumHoraPlanton.Text = "00";
			}
		}
		
		void NumMinRegresoTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumMinRegreso.Text))>59)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton.Text = "00";
				}
			}
			catch(Exception)
			{
				NumHoraPlanton.Text = "00";
			}
		}
		
		public void cambiaPlanton()
		{
			if((Convert.ToInt32(NumMinServicio.Text))>29)
			{
				NumHoraPlanton.Text=NumHoraServicio.Text;
				NumMinPlanton.Text=(((Convert.ToInt32(NumMinServicio.Text)-30)<10)?"0"+(Convert.ToInt32(NumMinServicio.Text)-30).ToString():(Convert.ToInt32(NumMinServicio.Text)-30).ToString());
			}
			else
			{
				if((Convert.ToInt32(NumHoraServicio.Text)-1)>0)
				{
					NumHoraPlanton.Text=(((Convert.ToInt32(NumHoraServicio.Text)-1)<10)?"0"+(Convert.ToInt32(NumHoraServicio.Text)-1):(Convert.ToInt32(NumHoraServicio.Text)-1).ToString());
					//if()
					NumMinPlanton.Text=(60+(Convert.ToInt32(NumMinServicio.Text)-30)).ToString();
				}
				else
				{
					NumHoraPlanton.Text="23";
					NumMinPlanton.Text=(60+(Convert.ToInt32(NumMinServicio.Text)-30)).ToString();
				}
			}
		}
		#endregion
		
		#region PDF
		void ImprimirPDF()
		{
				String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
		        string newPath = System.IO.Path.Combine(activeDir, "Especiales "+Hoy);
		        System.IO.Directory.CreateDirectory(newPath);
			
				try
				{		
					Document doc = new Document(PageSize.LETTER, 10, 10 ,10, 10);
					FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Especiales "+Hoy+@"\"+Nombre+" Especiales.pdf",
					                                 FileMode.OpenOrCreate,
					                                 FileAccess.ReadWrite,
					                                 FileShare.ReadWrite);
					PdfWriter.GetInstance(doc, file);
					doc.Open();
					GenerarPDF(doc);
			        doc.Close();
			        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Especiales "+Hoy+@"\"+Nombre+" Especiales.pdf"));
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
		}
		
		void GenerarPDF(Document document)
		{
			iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"../debug/LAR.jpg");
			jpg.SetAbsolutePosition(350,725);
			jpg.Alignment = iTextSharp.text.Image.TEXTWRAP;
 			document.Add(jpg); 
 			
			Paragraph espacio = new Paragraph("                                                                                     ", FontFactory.GetFont("ARIAL", 5));
			Paragraph title = new Paragraph("LIBRO DE VIAJES", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLDITALIC));
			title.Alignment = Element.ALIGN_LEFT;
			document.Add(new Paragraph(title));
			document.Add(new Paragraph(espacio));
			//Falta agregar fechas
			document.Add(new Paragraph(espacio));
			
			for(int x=0; x<3; x++)
			{
			document.Add(new Paragraph(espacio));
			Paragraph titleFecha = new Paragraph("Fechas y Horarios", FontFactory.GetFont("ARIAL", 8, iTextSharp.text.Font.BOLDITALIC));
			titleFecha.Alignment = Element.ALIGN_LEFT;
			document.Add(new Paragraph(titleFecha));
			document.Add(new Paragraph(espacio));
			
			float[] widths1 = new float[] {10f, 6f, 10f, 6f, 10f, 6f, 10f, 16f, 10f, 16f};
			PdfPTable fechas = new PdfPTable(10);
			fechas.WidthPercentage = 100;
			fechas.SetWidths(widths1);
			
			fechas.AddCell(new Paragraph("Hora Plantón", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    fechas.AddCell(new Paragraph(NumHoraPlanton.Text+":"+NumMinPlanton.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    fechas.AddCell(new Paragraph("Hora Servicio", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    fechas.AddCell(new Paragraph(NumHoraServicio.Text+":"+NumMinServicio.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    fechas.AddCell(new Paragraph("Hora Regreso", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    fechas.AddCell(new Paragraph(NumHoraRegreso.Text+":"+NumMinRegreso.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    fechas.AddCell(new Paragraph("Fecha Salida", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    fechas.AddCell(new Paragraph(dtFecha.Value.ToString("yyyy-MM-dd"), FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    fechas.AddCell(new Paragraph("Fecha Regreso", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    fechas.AddCell(new Paragraph(dtFechaRegreso.Value.ToString("yyyy-MM-dd"), FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(fechas);
			
			Paragraph titleCliente = new Paragraph("Datos Cliente", FontFactory.GetFont("ARIAL", 8, iTextSharp.text.Font.BOLDITALIC));
			titleCliente.Alignment = Element.ALIGN_LEFT;
			document.Add(new Paragraph(titleCliente));
			document.Add(new Paragraph(espacio));
			
			float[] widths2 = new float[] {15f, 35f, 15f, 35f};
			PdfPTable Clientes = new PdfPTable(4);
			Clientes.WidthPercentage = 100;
			Clientes.SetWidths(widths2);
			
			Clientes.AddCell(new Paragraph("Responsable", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Clientes.AddCell(new Paragraph(txtResponsable.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    Clientes.AddCell(new Paragraph("Cliente o Escuela", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Clientes.AddCell(new Paragraph(txtCliente.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    Clientes.AddCell(new Paragraph("Datos Factura", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Clientes.AddCell(new Paragraph(txtDatosFactura.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    Clientes.AddCell(new Paragraph("Telefono", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Clientes.AddCell(new Paragraph(txtTelefono.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(Clientes);
			
			float[] widths20 = new float[] {15f, 85f};
			PdfPTable Rutas20 = new PdfPTable(2);
			Rutas20.WidthPercentage = 100;
			Rutas20.SetWidths(widths20);
			
			Rutas20.AddCell(new Paragraph("Correo", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Rutas20.AddCell(new Paragraph(txtCorreo.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(Rutas20);
			
			Paragraph titleDatos = new Paragraph("Datos Ruta", FontFactory.GetFont("ARIAL", 8, iTextSharp.text.Font.BOLDITALIC));
			titleDatos.Alignment = Element.ALIGN_LEFT;
			document.Add(new Paragraph(titleDatos));
			document.Add(new Paragraph(espacio));
			
			float[] widths3 = new float[] {15f, 85f};
			PdfPTable Rutas = new PdfPTable(2);
			Rutas.WidthPercentage = 100;
			Rutas.SetWidths(widths3);
			
			Rutas.AddCell(new Paragraph("Domicilio", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Rutas.AddCell(new Paragraph(txtDomicilio.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(Rutas);
			
			float[] widths30 = new float[] {15f, 35f, 15f, 35f};
			PdfPTable Rutas01 = new PdfPTable(4);
			Rutas01.WidthPercentage = 100;
			Rutas01.SetWidths(widths30);
			
			Rutas01.AddCell(new Paragraph("Colonia", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Rutas01.AddCell(new Paragraph(txtColonia.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    Rutas01.AddCell(new Paragraph("Cruces", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Rutas01.AddCell(new Paragraph(txtCruces.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(Rutas01);
			
			float[] widths31 = new float[] {15f, 85f};
			PdfPTable Rutas02 = new PdfPTable(2);
			Rutas02.WidthPercentage = 100;
			Rutas02.SetWidths(widths31);
			
			Rutas02.AddCell(new Paragraph("Destino", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Rutas02.AddCell(new Paragraph(txtDestino.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(Rutas02);
			
			Paragraph titleCostos = new Paragraph("Costos", FontFactory.GetFont("ARIAL", 8, iTextSharp.text.Font.BOLDITALIC));
			titleCostos.Alignment = Element.ALIGN_LEFT;
			document.Add(new Paragraph(titleCostos));
			document.Add(new Paragraph(espacio));
			
			float[] widths4 = new float[] {15f, 10f, 15f, 10f, 15f, 10f, 15f, 10f};
			PdfPTable Costos = new PdfPTable(8);
			Costos.WidthPercentage = 100;
			Costos.SetWidths(widths4);
			
			Costos.AddCell(new Paragraph("Precio", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Costos.AddCell(new Paragraph(txtPrecio.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    Costos.AddCell(new Paragraph("Pago Operador", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Costos.AddCell(new Paragraph(txtPagoOperador.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    Costos.AddCell(new Paragraph("Casetas", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Costos.AddCell(new Paragraph(txtCasetas.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
   		    Costos.AddCell(new Paragraph("Km", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.BOLD)));
   		    Costos.AddCell(new Paragraph(NumKms.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(Costos);
			
			Paragraph titleObservaciones = new Paragraph("Observaciones", FontFactory.GetFont("ARIAL", 8, iTextSharp.text.Font.BOLDITALIC));
			titleObservaciones.Alignment = Element.ALIGN_LEFT;
			document.Add(new Paragraph(titleObservaciones));
			document.Add(new Paragraph(espacio));
			
			float[] widths5 = new float[] {100f};
			PdfPTable Observaciones = new PdfPTable(1);
			Observaciones.WidthPercentage = 100;
			Observaciones.SetWidths(widths5);
			
			Observaciones.AddCell(new Paragraph(txtObservaciones.Text, FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(Observaciones);
			
			document.Add(new Paragraph(espacio));
			float[] widths6 = new float[] {100f};
			PdfPTable linea = new PdfPTable(1);
			linea.WidthPercentage = 100;
			linea.SetWidths(widths6);
		   
			linea.AddCell(new Paragraph("", FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.NORMAL)));
			document.Add(linea);
			document.Add(new Paragraph(espacio));
			}
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador() 
		{
			dataViajesEspeciales.Rows.Clear();
			int cont = 0;
		
			String consulta = "select R.ENCUESTA, R.ID_RE, C.Nombre, responsable as Responsable, R.fecha, R.hora, R.fecha_salida, R.h_planton, R.cant_unidades, R.domicilio, R.destino, CL.Estado, CL.Rumbo,  R.casetas, R.precio, C.Telefono As Telefono, R.factura, R.observaciones,  R.correo, R.fecha_regreso, R.anticipo, R.estado as Estado_especial, RT.CompletoCamioneta, R.CONF_CLIENTE, R.Tipovehiculo from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID and R.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and RT.Sentido='Entrada' and responsable like '%"+txtResp.Text+"%' and R.ID_C in (select idCliente from ContactoServicio where Nombre like '%"+txtClienteBusqueda.Text+"%')  group by R.ENCUESTA, R.ID_RE, C.Nombre, responsable, R.fecha, R.hora, R.fecha_salida, R.h_planton, R.cant_unidades, R.domicilio, R.destino, CL.Estado, CL.Rumbo, R.casetas, R.precio, C.Telefono, R.factura, R.observaciones, R.correo, R.fecha_regreso, R.anticipo, R.estado, RT.CompletoCamioneta, R.CONF_CLIENTE, R.Tipovehiculo ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataViajesEspeciales.Rows.Add();
				dataViajesEspeciales.Rows[cont].Cells[0].Value = conn.leer["Nombre"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[1].Value = conn.leer["Responsable"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[2].Value = conn.leer["fecha"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[3].Value = conn.leer["hora"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[4].Value = conn.leer["fecha_salida"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[5].Value = conn.leer["h_planton"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[6].Value = conn.leer["cant_unidades"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[7].Value = conn.leer["domicilio"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[8].Value = conn.leer["destino"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[9].Value = conn.leer["Estado"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[10].Value = conn.leer["Rumbo"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[11].Value = conn.leer["casetas"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[12].Value = conn.leer["precio"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[13].Value = conn.leer["Telefono"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[14].Value = conn.leer["factura"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[15].Value = conn.leer["observaciones"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[16].Value = conn.leer["correo"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[17].Value = conn.leer["fecha_regreso"].ToString().Substring(0,10);
				dataViajesEspeciales.Rows[cont].Cells[18].Value = conn.leer["anticipo"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[19].Value = conn.leer["Estado_especial"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[20].Value = conn.leer["CompletoCamioneta"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[21].Value = conn.leer["ID_RE"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[22].Value = conn.leer["CONF_CLIENTE"].ToString();
				dataViajesEspeciales.Rows[cont].Cells[23].Value = ((conn.leer["ENCUESTA"].ToString()=="1")?"SI":"NO");
				dataViajesEspeciales.Rows[cont].Cells[24].Value = conn.leer["Tipovehiculo"].ToString();
				cont++;
			}
			conn.conexion.Close();
			
			for(int x=0; x<dataViajesEspeciales.Rows.Count; x++)
			{
				if(dataViajesEspeciales[22,x].Value.ToString()!="")
				{
					for(int y=0; y<dataViajesEspeciales.Columns.Count; y++)
					{
						dataViajesEspeciales[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
				
				if(dataViajesEspeciales[19,x].Value.ToString()=="Cancelado")
				{
					for(int y=0; y<dataViajesEspeciales.Columns.Count; y++)
					{
						dataViajesEspeciales[y,x].Style.BackColor=Color.Red;
					}
				}
			}
		}
		#endregion
		
		#region EVENTO MIXTO
		public bool mixto=false;
		
		void CbMixtoCheckedChanged(object sender, EventArgs e)
		{
			if(cbMixto.Checked==true)
			{
				gbCostos.Size = new System.Drawing.Size(379, 335);
				NumUnidad.Enabled=false;
				nudPasajeros.Enabled=false;
				cmbUnidades.Enabled=false;
				txtPrecio.Enabled=false;
				txtPagoOperador.Enabled=false;
				mixto=true;
				cmbUnidades.Text="MIXTO";
				gbMixto.Enabled=true;
			}
			else if(cbMixto.Checked==false)
			{
				gbCostos.Size = new System.Drawing.Size(379, 168);
				NumUnidad.Enabled=true;
				nudPasajeros.Enabled=true;
				cmbUnidades.Enabled=true;
				txtPrecio.Enabled=true;
				txtPagoOperador.Enabled=true;
				mixto=false;
				gbMixto.Enabled=false;
			}
		}
		#endregion
		
		#region AGREGAR MIXTOS A DATAGRID
		void CmdAgregaMixtoCAMClick(object sender, EventArgs e)
		{
			dgMixto.Rows.Add(" ", "CAMION", "1", "40", "0.00", "0.00");
		}
		
		void CmdagregarMixtoCTAClick(object sender, EventArgs e)
		{
			dgMixto.Rows.Add(" ", "CAMIONETA", "1", "20", "0.00", "0.00");
		}
		#endregion
		
		#region VALIDACION DGMIXTO
		public int bandera=0;
		void DgMixtoKeyPress(object sender, KeyPressEventArgs e)
		{
			if(dgMixto.CurrentCell.ColumnIndex==2 || dgMixto.CurrentCell.ColumnIndex==3 || dgMixto.CurrentCell.ColumnIndex==4 || dgMixto.CurrentCell.ColumnIndex==5)
			{
				if(bandera==0)
				{
					if(dgMixto.CurrentCell.ColumnIndex==4 && (Char.IsNumber(e.KeyChar) || (e.KeyChar==46 && !(dgMixto[4,dgMixto.CurrentRow.Index].Value.ToString().Contains(".")))))
					{
						dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value = e.KeyChar.ToString();
						bandera=1;
					}
					else if(dgMixto.CurrentCell.ColumnIndex==5 && (Char.IsNumber(e.KeyChar) || (e.KeyChar==46 && !(dgMixto[5,dgMixto.CurrentRow.Index].Value.ToString().Contains(".")))))
					{
						dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value =  e.KeyChar.ToString();
						bandera=1;
					}
					else if(Char.IsNumber(e.KeyChar))
					{
						dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value = e.KeyChar.ToString();
						bandera=1;
					}
					else if(Char.IsControl(e.KeyChar))
					{
						if(dgMixto.CurrentCell.ColumnIndex==2)
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="1";
						if(dgMixto.CurrentCell.ColumnIndex==3) 
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="0";
						if(dgMixto.CurrentCell.ColumnIndex==4) 
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="0.00";
						if(dgMixto.CurrentCell.ColumnIndex==5)
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="0.00";
						
						bandera=0;
					}
					else
					{
						e.Handled=true;
					}
				}
				else if(bandera==1)
				{
					if(dgMixto.CurrentCell.ColumnIndex==4 && (Char.IsNumber(e.KeyChar) || (e.KeyChar==46 && !(dgMixto[4,dgMixto.CurrentRow.Index].Value.ToString().Contains(".")))))
					{
						dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value = dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value.ToString() + e.KeyChar.ToString();
					}
					else if(dgMixto.CurrentCell.ColumnIndex==5 && (Char.IsNumber(e.KeyChar) || (e.KeyChar==46 && !(dgMixto[5,dgMixto.CurrentRow.Index].Value.ToString().Contains(".")))))
					{
						dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value = dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value.ToString() + e.KeyChar.ToString();
					}
					else if(Char.IsNumber(e.KeyChar))
					{
						dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value = dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value.ToString() + e.KeyChar.ToString();
					}
					else if(Char.IsControl(e.KeyChar))
					{
						if(dgMixto.CurrentCell.ColumnIndex==2)
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="1";
						if(dgMixto.CurrentCell.ColumnIndex==3) 
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="0";
						if(dgMixto.CurrentCell.ColumnIndex==4) 
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="0.00";
						if(dgMixto.CurrentCell.ColumnIndex==5)
							dgMixto.CurrentRow.Cells[dgMixto.CurrentCell.ColumnIndex].Value="0.00";
						
						bandera=0;
					}
					else
					{
						e.Handled=true;
					}
				}
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void DgMixtoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			bandera=0;
		}
		
		void DgMixtoKeyDown(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Next)
			{
				bandera=0;
			}
		}
		
		void CmdEliminaMixtoClick(object sender, EventArgs e)
		{
			if(dgMixto.CurrentRow.Index!=-1)
			{
				dgMixto.Rows.RemoveAt(dgMixto.CurrentRow.Index);
			}
		}
		#endregion
		
		#region CONFIRMA VIAJE ESPECIAL
		void CmdConfirmaClick(object sender, EventArgs e)
		{
			if(txtConfirma.Text!="" && dataViajesEspeciales.CurrentRow.Index!=-1)
			{
				new Conexion_Servidor.Libros.SQL_Libros().confirmaViaje(txtConfirma.Text, principal.idUsuario, Convert.ToInt64(dataViajesEspeciales[21,dataViajesEspeciales.CurrentRow.Index].Value));
				for(int y=0; y<dataViajesEspeciales.Columns.Count; y++)
				{
					dataViajesEspeciales[y,dataViajesEspeciales.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
				}
			}
			else
			{
				txtConfirma.BackColor=Color.LightPink;
				MessageBox.Show("Ingrese el nombre de la persona que confirma");
				txtConfirma.BackColor=Color.White;
			}
		}
		#endregion
		
		#region PRUEBA DE HILO LLAMADO DE UN FORMULARIO
		public void mostrarValidacion()
		{
			ThreadStart ts = new ThreadStart(hiloEjecucion);
			hilo = new Thread(ts);
			hilo.Start();
		}
		
		public void hiloEjecucion()
		{
			new FormValidacionEsp(this).ShowDialog();
		}
		#endregion
		
		#region AUTOCOMPLETE PARA DIFERENTES DOMICILIOS DE CLIENTES
		void TxtClienteTextChanged(object sender, EventArgs e)
		{
			aurocompleteDomicilio();
		}
		
		public void aurocompleteDomicilio()
		{
			String conssT = "select R.DOMICILIO dato from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and C.Nombre ='"+txtCliente.Text+"'";
			txtDomicilio.AutoCompleteCustomSource = auto.AutoReconocimiento(conssT);
			txtDomicilio.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtDomicilio.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region DATOS FACTURA
		void RbFacturarCheckedChanged(object sender, EventArgs e)
		{
			if(rbFacturar.Checked==true)
			{
				txtDatosFactura.Enabled=true;
				txtDatosFactura.Text = datoFact;
				cmdIngresar.Enabled=true;
				IVA=true;
				cmdVarias.Enabled=true;
			}
			else
			{
				txtDatosFactura.Enabled=false;
				txtDatosFactura.Text="";
				//cmbTipoPago.Text="";
				cmdIngresar.Enabled=false;
				cmdRevisar.Enabled=false;
				//cmbTipoPago.Enabled=false;
				IVA=false;
				cmdVarias.Enabled=false;
			}
		}
		
		void CmdIngresarClick(object sender, EventArgs e)
		{
			if(txtCliente.Text!="")
			{
				formDatosFact = new FormDatosFactura(1, this, txtCliente.Text);
				formDatosFact.ShowDialog();
			}
			else
			{
				MessageBox.Show("Ingrese cliente");
			}
		}
		
		void CmdRevisarClick(object sender, EventArgs e)
		{
			if(idFact!=0)
			{
				new FormDatosFactura(2, this, idFact).ShowDialog();
			}
			else
			{
				String conss = "select ID from DATOS_FACTURA where RAZON_SOCIAL like '%"+txtDatosFactura.Text+"%'";
				conn.getAbrirConexion(conss);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idFact = Convert.ToInt16(conn.leer["ID"]);
				}
				conn.conexion.Close();
				
				new FormDatosFactura(2, this, idFact).ShowDialog();
			}
		}
		#endregion
		
		#region EVENTO BOTON FACTURA
		void CmdFactClick(object sender, EventArgs e)
		{
			new Incapacidad.FormValidaFact(principal.idUsuario).ShowDialog();
		}
		#endregion
		
		#region CAMBIOS PAGO OPERADOR
		void CmbUnidadesSelectedIndexChanged(object sender, EventArgs e)
		{
			if(ckforaneo.Checked==true)
			{
				txtPagoOperador.Text=((Convert.ToDouble(txtPrecio.Text)-Convert.ToDouble(((txtCasetas.Text!="N/A")?txtCasetas.Text:"0")))*.20).ToString();
			}
			else
			{
				if(cmbUnidades.Text=="Camion")
					{
						txtPagoOperador.Text="120";
						if(Convert.ToDouble(txtPrecio.Text)<120)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
					if(cmbUnidades.Text=="Camioneta")
					{
						txtPagoOperador.Text="100";
						if(Convert.ToDouble(txtPrecio.Text)<100)
						{
							txtPagoOperador.Text=txtPrecio.Text;
						}
					}
			}
			
			if(cmbUnidades.Text=="Camion")
				nudPasajeros.Text="40";
			if(cmbUnidades.Text=="Camioneta")
				nudPasajeros.Text="20";
		}
		
		void NumUnidadValueChanged(object sender, EventArgs e)
		{
			if(IVA==false)
			{
				txtSaldo.Text = ((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
			}
			else
			{
				double montoIva = (Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))*.16;
				txtSaldo.Text = (((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))+montoIva)-Convert.ToDouble(txtAnticipos.Text)).ToString();
			}
		}
		
		void CbAnticiposCheckedChanged(object sender, EventArgs e)
		{
			if(cbAnticipos.Checked==true)
			{
				//txtAnticipos.Enabled=true;
				//txtNumeroRef.Enabled=true;
				cmdAnticipos.Enabled=true;
				dgAnticipos.Enabled=true;
			}
			else
			{
				txtAnticipos.Text="0";
				if(IVA==false)
				{
					txtSaldo.Text = ((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
				}
				else
				{
					double montoIva = (Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))*.16;
					txtSaldo.Text = (((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))+montoIva)-Convert.ToDouble(txtAnticipos.Text)).ToString();
				}
				//txtAnticipos.Enabled=false;
				//txtNumeroRef.Enabled=false;
				cmdAnticipos.Enabled=false;
				dgAnticipos.Enabled=false;
			}
		}
		#endregion
		
		#region EVENTO BOTON ANTICIPOS
		void CmdAnticiposClick(object sender, EventArgs e)
		{
			new FormAnticipos(this).ShowDialog();
		}
		
		public void cuentaAnticipos()
		{
			txtAnticipos.Text="0";
			if(dgAnticipos.Rows.Count>0)
			{
				for(int x=0; x<dgAnticipos.Rows.Count; x++)
				{
					txtAnticipos.Text=(Convert.ToDouble(txtAnticipos.Text)+Convert.ToDouble(dgAnticipos[0,x].Value)).ToString();
				}
			}
		}
		#endregion
		
		#region EVENTO TXTANTICIPOS
		void TxtAnticiposTextChanged(object sender, EventArgs e)
		{
			if(IVA==false)
			{
				txtSaldo.Text = ((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
			}
			else
			{
				double montoIva = (Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))*.16;
				txtSaldo.Text = (((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text)+montoIva)-Convert.ToDouble(txtAnticipos.Text))).ToString();
			}
		}
		#endregion
		
		//***************************************************************************************************************************************************************//
		//*********************************************************************** PROSPECTOS ****************************************************************************//
		//***************************************************************************************************************************************************************//
		
		#region	EVENTO BOTONES PROSPECTOS
		void CmdNuevoClick(object sender, EventArgs e)
		{
			limpiaDatos();
			dgProspectos.ClearSelection();
		}
		
		void CmdConfirmaProspClick(object sender, EventArgs e)
		{
			confirmacion();
			tcViajesEsp.TabPages[0].Show();
		}
		
		void CmdGuardarProspClick(object sender, EventArgs e)
		{
			if(dgProspectos.SelectedRows.Count==0)
			{
				guardaDatos();
				getViajesProspectos();
				limpiaDatos();
			}
			else
			{
				modificaDatos();
				getViajesProspectos();
				limpiaDatos();
			}
		}
		#endregion
		
		#region CONFIRMACION DE VIAJE
		bool confirmada=false;
		void confirmacion()
		{
			nudPasajeros.Text=cbUsu_p.Text;
			txtResponsable.Text=txtResp_p.Text;
			txtCliente.Text=txtCli_p.Text;
			txtDomicilio.Text=txtDomicilio.Text;
			txtDestino.Text=txtDes_p.Text;
			dtFecha.Value=dtpSal_p.Value;
			
			txtSal_p.Text=dtpSal_p.Value.ToString("dd/MM");
			dtFechaRegreso.Value=dtpReg_p.Value;
			txtTelefono.Text=txtTel_p.Text;
			txtObservaciones.Text=txtAsunto_p.Text;
			NumUnidad.Text=dudUnid_p.Text;
			NumKms.Text=txtKm_p.Text;
			txtPrecio.Text=txtPrec_p.Text;
			txtCasetas.Text=txtCas_p.Text;
			
			for(int x=0; x<cmbUnidades.Items.Count; x++)
			{
				if(cmbUnidades.Items[x].ToString()==((rbCam_p.Checked==true)?"Camion":"Camioneta"))
				{
					cmbUnidades.SelectedIndex=x;
				}
			}
			
			try
			{
				conn.getAbrirConexion("select R.responsable, C.Telefono, R.factura, R.domicilio, R.correo, CL.Estado, CL.Rumbo from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and C.Nombre ='"+txtCliente.Text+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					txtResponsable.Text = conn.leer["responsable"].ToString();
					txtDomicilio.Text = conn.leer["domicilio"].ToString();
					txtCruces.Text = conn.leer["Rumbo"].ToString();
					txtColonia.Text = conn.leer["Estado"].ToString();
					txtCorreo.Text = conn.leer["correo"].ToString();
					txtTelefono.Text = conn.leer["Telefono"].ToString();
					datoFact = conn.leer["factura"].ToString();
					
					aurocompleteDomicilio();
				}
			}
			catch(Exception)
			{
				
			}
			conn.conexion.Close();
			
			String consul = "update VIAJE_PROSPECTO set ESTATUS='3' where ID="+dgProspectos[0,dgProspectos.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consul); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();	
			
			dgProspectos[3,dgProspectos.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
			
			confirmada=true;
		}
		#endregion
		
		#region EVENTO DE FECHA
		void DtpSal_pValueChanged(object sender, EventArgs e)
		{
			dtpReg_p.Value=dtpSal_p.Value;
		}
		#endregion
		
		#region EVENTOS DE PRECIOS
		void TxtPrec_pLeave(object sender, EventArgs e)
		{
			if(txtPrec_p.Text=="")
				txtPrec_p.Text="0";
		}
		
		void TxtCas_pLeave(object sender, EventArgs e)
		{
			if(txtCas_p.Text=="")
				txtCas_p.Text="0";
		}
		
		void TxtKm_pLeave(object sender, EventArgs e)
		{
			if(txtKm_p.Text=="")
				txtKm_p.Text="0";
		}
		
		void TxtPrec_pTextChanged(object sender, EventArgs e)
		{
			PrecioTotal();
		}
		
		void DudUnid_pTextChanged(object sender, EventArgs e)
		{
			PrecioTotal();
		}
		
		void PrecioTotal()
		{
			txtPrecTotal_p.Text=(Convert.ToDouble(txtPrec_p.Text)*Convert.ToInt16(dudUnid_p.Text)).ToString();
		}
		
		void DudUnid_pLeave(object sender, EventArgs e)
		{
			if(dudUnid_p.Text=="")
				dudUnid_p.Text="1";
		}
		#endregion
		
		#region GUARDADO DE DATOS
		void guardaDatos()
		{
			String sentencia = "INSERT INTO VIAJE_PROSPECTO VALUES ('"+txtResp_p.Text+"','"+txtTel_p.Text+"','"+txtDes_p.Text+"', '"+txtCli_p.Text+"','"+dtpSal_p.Value.ToString("dd/MM/yyyy")+"','"+dtpReg_p.Value.ToString("dd/MM/yyyy")+"','"+txtKm_p.Text+"','"+txtCas_p.Text+"','"+((rbCam_p.Checked==true)?"CAMION":"CAMIONETA")+"','"+dudUnid_p.Text+"','"+txtPrec_p.Text+"','"+txtPrecTotal_p.Text+"','"+((cbAc_p.Checked==true)?"1":"0")+"','"+((cbBanio_p.Checked==true)?"1":"0")+"','"+txtLugarSal_p.Text+"','"+txtAsunto_p.Text+"','1','"+principal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), '"+txtDetalle.Text+"', '"+cbUsu_p.Text+"', '')";
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region MODIFICACION DE DATOS
		void modificaDatos()
		{
			String sentencia = "UPDATE VIAJE_PROSPECTO SET RESPONSABLE='"+txtResp_p.Text+"', TELEFONO='"+txtTel_p.Text+"', DESTINO='"+txtDes_p.Text+"', CLIENTE='"+txtCli_p.Text+"', FECHA_SALIDA='"+dtpSal_p.Value.ToString("dd/MM/yyyy")+"', FECHA_REGRESO='"+dtpReg_p.Value.ToString("dd/MM/yyyy")+"', KILOMETROS='"+txtKm_p.Text+"', CASETAS='"+txtCas_p.Text+"', TIPO_UNIDADES='"+((rbCam_p.Checked==true)?"CAMION":"CAMIONETA")+"', CANT_UNIDADES='"+dudUnid_p.Text+"', PRECIO='"+txtPrec_p.Text+"', TOTAL='"+txtPrecTotal_p.Text+"', A_C='"+((cbAc_p.Checked==true)?"1":"0")+"', BANIO='"+((cbBanio_p.Checked==true)?"1":"0")+"', DOMICILIO='"+txtLugarSal_p.Text+"', ASUNTO='"+txtAsunto_p.Text+"', FECHA_APROX='"+txtDetalle.Text+"' WHERE ID="+dgProspectos[0,dgProspectos.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region GET DATOS A DATAGRID DE PROSPECTOS
		void getViajesProspectos()
		{
			dgProspectos.Rows.Clear();
			
			String consulta="";
			
			/*if(cbFechaReg.Checked==false)
			{
				consulta = "select * from VIAJE_PROSPECTO V, usuario U where V.ID_U=U.id_usuario and V.ESTATUS!='0' and RESPONSABLE like '%"+txtBusResp.Text+"%' and Cliente like '%"+txtBusCli.Text+"%' and FECHA_SALIDA between '"+dtpBusInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpBusFin.Value.ToString("dd/MM/yyyy")+"'";
			}
			else
			{*/
				consulta = "select * from VIAJE_PROSPECTO V, usuario U where V.ID_U=U.id_usuario and V.ESTATUS!='0' and RESPONSABLE like '%"+txtBusResp.Text+"%' and Cliente like '%"+txtBusCli.Text+"%' and FECHA_REG between '"+dtpBusInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpBusFin.Value.ToString("dd/MM/yyyy")+"'";
			//}
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgProspectos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["RESPONSABLE"].ToString(), conn.leer["TELEFONO"].ToString(), conn.leer["DESTINO"].ToString(), conn.leer["CLIENTE"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["FECHA_REGRESO"].ToString().Substring(0,10), conn.leer["KILOMETROS"].ToString(), conn.leer["CASETAS"].ToString(), conn.leer["TIPO_UNIDADES"].ToString(), conn.leer["CANT_UNIDADES"].ToString(), conn.leer["PRECIO"].ToString(), conn.leer["TOTAL"].ToString(), ((conn.leer["A_C"].ToString()=="1")?"SI":"NO"), ((conn.leer["BANIO"].ToString()=="1")?"SI":"NO"), conn.leer["DOMICILIO"].ToString(), conn.leer["ASUNTO"].ToString(), ((conn.leer["ESTATUS"].ToString()=="2")?"SI":"NO"), conn.leer["usuario"].ToString().ToUpper(), conn.leer["FECHA_REG"].ToString(), conn.leer["FECHA_APROX"].ToString(), conn.leer["CANT_USU"].ToString() , conn.leer["ESTATUS"].ToString());
			}
			conn.conexion.Close();
			//cambioColores();
			
			for(int x=0; x<dgProspectos.Rows.Count; x++)
			{
				if(dgProspectos[18,x].Value.ToString()!=principal.lblDatoUsuario.ToString())
				{
					dgProspectos[3,x].Style.BackColor=Color.Yellow;
				}
				
				if(dgProspectos[22,x].Value.ToString()=="2")
				{
					dgProspectos[3,x].Style.BackColor=Color.MediumSlateBlue;
				}
				
				if(dgProspectos[22,x].Value.ToString()=="3")
				{
					dgProspectos[3,x].Style.BackColor=Color.MediumSpringGreen;
				}
			}
			
			dgProspectos.ClearSelection();
		}
		#endregion
		
		#region CAMBIO DE COLORES
		void cambioColores()
		{
			for(int x=0; x<dgProspectos.Rows.Count; x++)
			{
				if(dgProspectos[17,x].Value.ToString()=="SI")
				{
					for(int y=0; y<dgProspectos.Columns.Count; y++)
					{
						dgProspectos[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
		}
		#endregion
		
		#region LIMPIA DATOS
		void limpiaDatos()
		{
			txtResp_p.Text="";
			txtTel_p.Text="";
			txtDes_p.Text="";
			txtCli_p.Text="";
			dtpSal_p.Value=DateTime.Now;
			dtpReg_p.Value=DateTime.Now;
			txtKm_p.Text="0";
			txtCas_p.Text="0";
			rbCam_p.Checked=true;
			dudUnid_p.Text="1";
			txtPrec_p.Text="0";
			txtPrecTotal_p.Text="0";
			cbAc_p.Checked=false;
			cbBanio_p.Checked=false;
			txtLugarSal_p.Text="";
			txtAsunto_p.Text="";
			txtDetalle.Text="";
		}
		#endregion
		
		#region LIMPIADO DE CLREAR SELECTION PARA DGPROSPECTOS INICIAL
		bool entra=true;
		bool entra2=true;
		void TcViajesEspSelectedIndexChanged(object sender, EventArgs e)
		{
			if(tcViajesEsp.SelectedIndex.ToString()=="0" && entra==true)
			{
				dataViajesEspeciales.ClearSelection();
				entra=false;
			}
			else if(entra2==true)
			{
				dgProspectos.ClearSelection();
				entra2=false;
			}
		}
		#endregion
		
		#region CAMBIOS
		void TxtResp_pKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta = "select * from VIAJE_PROSPECTO where RESPONSABLE='"+txtResp_p.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtCli_p.Text=conn.leer["CLIENTE"].ToString();
					txtTel_p.Text=conn.leer["TELEFONO"].ToString();
					txtLugarSal_p.Text=conn.leer["DOMICILIO"].ToString();
				}
				conn.conexion.Close();
			}
		}
		
		void TxtCli_pKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta = "select * from VIAJE_PROSPECTO where Cliente='"+txtCli_p.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtResp_p.Text=conn.leer["RESPONSABLE"].ToString();
					txtTel_p.Text=conn.leer["TELEFONO"].ToString();
					txtLugarSal_p.Text=conn.leer["DOMICILIO"].ToString();
				}
				conn.conexion.Close();
			}
		}
		
		//****************************************
		
		void TxtBusCliTextChanged(object sender, EventArgs e)
		{
			getViajesProspectos();
		}
		
		void TxtBusRespTextChanged(object sender, EventArgs e)
		{
			getViajesProspectos();
		}
		
		void DtpBusInicioValueChanged(object sender, EventArgs e)
		{
			dtpBusFin.Value=dtpBusInicio.Value;
		}
		
		void DtpBusFinValueChanged(object sender, EventArgs e)
		{
			getViajesProspectos();
		}
		#endregion
		
		#region EVENTO CELLCLICK DGPROSPECTOS 
		void DgProspectosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			cbUsu_p.Text = dgProspectos[21,dgProspectos.CurrentRow.Index].Value.ToString();
			txtResp_p.Text = dgProspectos[1,dgProspectos.CurrentRow.Index].Value.ToString();
			txtTel_p.Text = dgProspectos[2,dgProspectos.CurrentRow.Index].Value.ToString();
			txtDes_p.Text = dgProspectos[3,dgProspectos.CurrentRow.Index].Value.ToString();
			txtCli_p.Text = dgProspectos[4,dgProspectos.CurrentRow.Index].Value.ToString();
			dtpSal_p.Value = Convert.ToDateTime(dgProspectos[5,dgProspectos.CurrentRow.Index].Value);
			dtpReg_p.Value = Convert.ToDateTime(dgProspectos[6,dgProspectos.CurrentRow.Index].Value);
			txtKm_p.Text = dgProspectos[7,dgProspectos.CurrentRow.Index].Value.ToString();
			txtCas_p.Text = dgProspectos[8,dgProspectos.CurrentRow.Index].Value.ToString();
			
			if(dgProspectos[9,dgProspectos.CurrentRow.Index].Value.ToString()=="CAMION")
				rbCam_p.Checked=true;
			else 
				rbCta_p.Checked=true;
				
			dudUnid_p.Text=dgProspectos[10,dgProspectos.CurrentRow.Index].Value.ToString();
			txtPrec_p.Text=dgProspectos[11,dgProspectos.CurrentRow.Index].Value.ToString();
			txtPrecTotal_p.Text=dgProspectos[12,dgProspectos.CurrentRow.Index].Value.ToString();

			cbAc_p.Checked=((dgProspectos[13,dgProspectos.CurrentRow.Index].Value.ToString()=="SI")?true:false);
			cbBanio_p.Checked=((dgProspectos[14,dgProspectos.CurrentRow.Index].Value.ToString()=="SI")?true:false);
			
			txtLugarSal_p.Text=dgProspectos[15,dgProspectos.CurrentRow.Index].Value.ToString();
			txtAsunto_p.Text=dgProspectos[16,dgProspectos.CurrentRow.Index].Value.ToString();
			txtDetalle.Text=dgProspectos[20,dgProspectos.CurrentRow.Index].Value.ToString();
		}
		#endregion
		
		#region EVENTO CHECKBOX
		void CbFechaRegCheckedChanged(object sender, EventArgs e)
		{
			if(cbFechaReg.Checked==true)
			{
				dtpFechaReg.Enabled=true;
				gbRango.Enabled=false;
			}
			else
			{
				dtpFechaReg.Enabled=false;
				gbRango.Enabled=true;
			}
			
			getViajesProspectos();
		}
		
		void DtpFechaRegValueChanged(object sender, EventArgs e)
		{
			getViajesProspectos();
		}
		#endregion
		
		#region DIAS
		void TxtDetalleKeyUp(object sender, KeyEventArgs e)
		{
			if(txtDetalle.Text!="" && txtDetalle.Text!="0")
			{
				dtpReg_p.Value= dtpSal_p.Value.AddDays(Convert.ToInt16(txtDetalle.Text)-1);
			}
		}
		
		void TxtDetalleLeave(object sender, EventArgs e)
		{
			if(txtDetalle.Text=="" || txtDetalle.Text=="0")
			{
				txtDetalle.Text="0";
			}
		}
		
		#region 
		void TxtSal_pMouseClick(object sender, MouseEventArgs e)
		{
			txtSal_p.SelectAll();
		}
		
		void TxtSal_pKeyPress(object sender, KeyPressEventArgs e)
		{
			if(txtSal_p.Text!="" && txtSal_p.Text!="0")
			{
				//validaFechaMes(txtSal_p.Text, 1);
			}
		}
		
		void validaFechaMes(String dato, int tipo)
		{
			MessageBox.Show(Convert.ToDateTime(dato)+"");
		}
		#endregion
		#endregion
		
		#region	CAMBIO CAPACIDAD DE USUARIOS
		void RbCam_pCheckedChanged(object sender, EventArgs e)
		{
			if(rbCam_p.Checked==true)
			{
				cbUsu_p.Items.Clear();
				cbUsu_p.Items.Add("40");
				cbUsu_p.Items.Add("41");
				cbUsu_p.Items.Add("42");
				cbUsu_p.Items.Add("43");
				cbUsu_p.Items.Add("44");
				cbUsu_p.Items.Add("45");
				cbUsu_p.Items.Add("46");
				cbUsu_p.Items.Add("47");
				cbUsu_p.Items.Add("48");
				cbUsu_p.Items.Add("49");
				cbUsu_p.Items.Add("50");
				cbUsu_p.Items.Add("51");
				cbUsu_p.Items.Add("52");
				cbUsu_p.Items.Add("53");
				cbUsu_p.Items.Add("54");
				cbUsu_p.Items.Add("55");
				cbUsu_p.Items.Add("56");
				
				cbUsu_p.SelectedIndex=0;
			}
			else
			{
				cbUsu_p.Items.Clear();
				cbUsu_p.Items.Add("15");
				cbUsu_p.Items.Add("16");
				cbUsu_p.Items.Add("17");
				cbUsu_p.Items.Add("18");
				cbUsu_p.Items.Add("19");
				cbUsu_p.Items.Add("20");
				cbUsu_p.Items.Add("21");
				cbUsu_p.Items.Add("22");
				cbUsu_p.Items.Add("23");
				cbUsu_p.Items.Add("24");
				cbUsu_p.Items.Add("25");
				cbUsu_p.Items.Add("26");
				cbUsu_p.Items.Add("27");
				cbUsu_p.Items.Add("28");
				
				cbUsu_p.SelectedIndex=0;
			}
		}
		#endregion
		
		#region OTRA COTIZACION
		void CmdOtraClick(object sender, EventArgs e)
		{
			guardaDatos();
			getViajesProspectos();
			
			txtDes_p.Text	 = "";
			txtKm_p.Text 	 = "";
			txtPrec_p.Text 	 = "0";
			txtAsunto_p.Text = "";
		}
		#endregion
		
		#region EXPORTA EXCEL PROSPECTOS
		void CmdExportaExcelClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			++i;
			ExcelApp.Cells[i,  1] = "Nombre";
			ExcelApp.Cells[i,  2] = "Telefono";
			ExcelApp.Cells[i,  3] = "Destino";
			ExcelApp.Cells[i,  4] = "Cliente";
			ExcelApp.Cells[i,  5] = "Salida";
			ExcelApp.Cells[i,  6] = "Regreso";
			ExcelApp.Cells[i,  7] = "Km";
			ExcelApp.Cells[i,  8] = "Casetas";
			ExcelApp.Cells[i,  9] = "Tipo Unidades";
			ExcelApp.Cells[i,  10] = "Cantidad";
			ExcelApp.Cells[i,  11] = "Precio";
			ExcelApp.Cells[i,  12] = "Total";
			ExcelApp.Cells[i,  13] = "AC";
			ExcelApp.Cells[i,  14] = "Baño";
			ExcelApp.Cells[i,  15] = "Domicilio";
			ExcelApp.Cells[i,  16] = "Asunto";
			ExcelApp.Cells[i,  17] = "Confirmado";
			ExcelApp.Cells[i,  18] = "Usuario";
			ExcelApp.Cells[i,  19] = "Registro";
			ExcelApp.Cells[i,  20] = "D. Fecha";
			ExcelApp.Cells[i,  21] = "Cant. Usuarios";
			
			for(int x=0; x<dgProspectos.Rows.Count; x++)
			{
				++i;
				try{ExcelApp.Cells[i,  1] = dgProspectos[1,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  1] = "";}
				try{ExcelApp.Cells[i,  2] = dgProspectos[2,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  3] = dgProspectos[3,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  3] = "";}
				try{ExcelApp.Cells[i,  4] = dgProspectos[4,x].Value.ToString().Substring(0,10);}catch (Exception){ExcelApp.Cells[i,  4] = "";}
				try{ExcelApp.Cells[i,  5] = dgProspectos[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  5] = "";}
				try{ExcelApp.Cells[i,  6] = dgProspectos[6,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
				try{ExcelApp.Cells[i,  7] = dgProspectos[7,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  7] = "";}
				try{ExcelApp.Cells[i,  8] = dgProspectos[8,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  8] = "";}
				try{ExcelApp.Cells[i,  9] = dgProspectos[9,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  9] = "";}
				try{ExcelApp.Cells[i,  10] = dgProspectos[10,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 10 ] = "";}
				try{ExcelApp.Cells[i,  11] = dgProspectos[11,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}
				try{ExcelApp.Cells[i,  12] = dgProspectos[12,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  12] = "";}
				try{ExcelApp.Cells[i,  13] = dgProspectos[13,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  13] = "";}
				try{ExcelApp.Cells[i,  14] = dgProspectos[14,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  14] = "";}
				try{ExcelApp.Cells[i,  15] = dgProspectos[15,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  15] = "";}
				try{ExcelApp.Cells[i,  16] = dgProspectos[16,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  16] = "";}
				try{ExcelApp.Cells[i,  17] = dgProspectos[17,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  17] = "";}
				try{ExcelApp.Cells[i,  18] = dgProspectos[18,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  18] = "";}
				try{ExcelApp.Cells[i,  19] = dgProspectos[19,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  19] = "";}
				try{ExcelApp.Cells[i,  20] = dgProspectos[20,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  20] = "";}
				try{ExcelApp.Cells[i,  21] = dgProspectos[21,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  21] = "";}
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Prospectos "+DateTime.Now.ToString("dd-MM-yyyy");
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
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		#endregion		
		
		#region EXPORTACION DE DATOS 
		void CmdIndicadoresClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			++i;
			ExcelApp.Cells[i,  1] = "ID";
			ExcelApp.Cells[i,  2] = "FECHA";
			ExcelApp.Cells[i,  3] = "SEMANA";
			ExcelApp.Cells[i,  4] = "CLIENTE";
			ExcelApp.Cells[i,  5] = "PRECIO";
			ExcelApp.Cells[i,  6] = "CANT_UNIDADES";
			
			
			// ++++++++++++++++++OBTIENE EL NUMERO DE LA SEMANA EN CURSO RESPECTO A UN DATETIMEPICKER++++++++++++++++++++
			System.Globalization.CultureInfo norwCulture =	System.Globalization.CultureInfo.CreateSpecificCulture("es");
			System.Globalization.Calendar cal = norwCulture.Calendar;
			int weekNo = cal.GetWeekOfYear(dtFechaEspecialInicio.Value,norwCulture.DateTimeFormat.CalendarWeekRule,
			norwCulture.DateTimeFormat.FirstDayOfWeek);
			String SEMANA = weekNo.ToString();
			//  +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
			
			String consulta = "select R.ID_RE ID, R.FECHA_SALIDA FECHA, '15' as SEMANA, S.Nombre CLIENTE, R.PRECIO, " +
				"R.CANT_UNIDADES from RUTA_ESPECIAL R, Cliente C, ContactoServicio S, usuario U where R.ID_C=C.ID and " +
				"C.ID=S.IdCliente AND R.ID_U=U.id_usuario AND R.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtFechaEspecialFin.Value.ToString("dd/MM/yyyy")+"' and " +
				"R.estado!='Cancelado' order by R.FECHA_SALIDA, R.H_PLANTON";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;
				try{ExcelApp.Cells[i,  1] = conn.leer["ID"].ToString();				}catch (Exception){ExcelApp.Cells[i,  1] = "";}
				try{ExcelApp.Cells[i,  2] = conn.leer["FECHA"].ToString().Substring(0,10);			}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  3] = SEMANA;									}catch (Exception){ExcelApp.Cells[i,  3] = "";}
				try{ExcelApp.Cells[i,  4] = conn.leer["CLIENTE"].ToString();		}catch (Exception){ExcelApp.Cells[i,  4] = "";}
				try{ExcelApp.Cells[i,  5] = conn.leer["PRECIO"].ToString();			}catch (Exception){ExcelApp.Cells[i,  5] = "";}
				try{ExcelApp.Cells[i,  6] = conn.leer["CANT_UNIDADES"].ToString();	}catch (Exception){ExcelApp.Cells[i,  6] = "";}
			}
			
			conn.conexion.Close();
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Indicadores "+DateTime.Now.ToString("dd-MM-yyyy");
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
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		void CmdDatosClick(object sender, EventArgs e)
		{			
			String NumKms = ""; 
			String saldo = ""; 
			int IDCD = 0;
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			++i;
			ExcelApp.Cells[i,  1] = "ID";
			ExcelApp.Cells[i,  2] = "Cliente";
			ExcelApp.Cells[i,  3] = "Responsable";
			ExcelApp.Cells[i,  4] = "Salida";
			ExcelApp.Cells[i,  5] = "Hora Planton";
			ExcelApp.Cells[i,  6] = "Domicilio";
			ExcelApp.Cells[i,  7] = "Destino";
			ExcelApp.Cells[i,  8] = "Colonia";
			ExcelApp.Cells[i,  9] = "Cruces";
			ExcelApp.Cells[i,  10] = "Casetas";
			ExcelApp.Cells[i,  11] = "C/U";			
			ExcelApp.Cells[i,  12] = "Precio";
			ExcelApp.Cells[i,  13] = "Saldo";
			ExcelApp.Cells[i,  14] = "KM";
			ExcelApp.Cells[i,  15] = "Telefono";
			ExcelApp.Cells[i,  16] = "Datos Factura";
			ExcelApp.Cells[i,  17] = "Observaciones";
			ExcelApp.Cells[i,  18] = "Regreso";
			ExcelApp.Cells[i,  19] = "Anticipo";
			ExcelApp.Cells[i,  20] = "Encuestado";
			ExcelApp.Cells[i,  21] = "Estado";
			ExcelApp.Cells[i,  22] = "Vehiculo";
			
			for(int x=0; x<dataViajesEspeciales.Rows.Count; x++)
			{
				++i;
				
				conn.getAbrirConexion("select ID_C from RUTA_ESPECIAL where ID_RE="+dataViajesEspeciales[21,x].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					IDCD = Convert.ToInt16(conn.leer["ID_C"]);
				}
				conn.conexion.Close();				
				
				conn.getAbrirConexion("select Kilometros from RUTA WHERE Sentido='Entrada' and IdSubEmpresa='"+IDCD+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NumKms = conn.leer["Kilometros"].ToString();
				}
				conn.conexion.Close();		
				
				conn.getAbrirConexion("select SALDO from RUTA_ESPECIAL where ID_RE = "+dataViajesEspeciales[21,x].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					saldo = (Convert.ToDecimal(conn.leer["SALDO"])+Convert.ToDecimal(dataViajesEspeciales[18,x].Value)).ToString();
				}
				conn.conexion.Close();		
				
				try{ExcelApp.Cells[i,  1] = dataViajesEspeciales[21,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  1] = "";}
				try{ExcelApp.Cells[i,  2] = dataViajesEspeciales[0,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  3] = dataViajesEspeciales[1,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  3] = "";}
				try{ExcelApp.Cells[i,  4] = dataViajesEspeciales[4,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  4] = "";}
				try{ExcelApp.Cells[i,  5] = dataViajesEspeciales[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  5] = "";}
				try{ExcelApp.Cells[i,  6] = dataViajesEspeciales[7,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
				try{ExcelApp.Cells[i,  7] = dataViajesEspeciales[8,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  7] = "";}
				try{ExcelApp.Cells[i,  8] = dataViajesEspeciales[9,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  8] = "";}
				try{ExcelApp.Cells[i,  9] = dataViajesEspeciales[10,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  9] = "";}
				try{ExcelApp.Cells[i,  10] = dataViajesEspeciales[11,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 10 ] = "";}				
				try{ExcelApp.Cells[i,  11] = dataViajesEspeciales[6,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 6 ] = "";}				
				try{ExcelApp.Cells[i,  12] = dataViajesEspeciales[12,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}
				try{ExcelApp.Cells[i,  13] = saldo;}catch (Exception){ExcelApp.Cells[i,  13] = "";}
				try{ExcelApp.Cells[i,  14] = NumKms;}catch (Exception){ExcelApp.Cells[i,  14] = "";}				
				try{ExcelApp.Cells[i,  15] = dataViajesEspeciales[13,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  12] = "";}
				try{ExcelApp.Cells[i,  16] = dataViajesEspeciales[14,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  13] = "";}
				try{ExcelApp.Cells[i,  17] = dataViajesEspeciales[15,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  14] = "";}
				try{ExcelApp.Cells[i,  18] = dataViajesEspeciales[17,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  15] = "";}
				try{ExcelApp.Cells[i,  19] = dataViajesEspeciales[18,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  16] = "";}
				try{ExcelApp.Cells[i,  20] = dataViajesEspeciales[23,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  17] = "";}
				try{ExcelApp.Cells[i,  21] = dataViajesEspeciales[19,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  18] = "";}
				try{ExcelApp.Cells[i,  22] = dataViajesEspeciales[24,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  24] = "";}
				
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Datos "+DateTime.Now.ToString("dd-MM-yyyy");
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
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		#endregion
		
		void BtnContratoClick(object sender, EventArgs e)
		{
			PDFContrato();
		}
		
		void PDFContrato()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtCliente.Text + " " + txtDestino.Text +".pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				FormatoPdf.FormatoContratoVentas(doc, writer, txtResponsable.Text, txtTelefono.Text, txtDomicilio.Text, txtDestino.Text, dtFecha.Value.ToString().Substring(0,10), 
				                                 NumHoraPlanton.Text+":"+NumMinPlanton.Text+" hrs", NumHoraRegreso.Text+":"+NumMinRegreso.Text+" hrs", 
				                                 NumUnidad.Text, nudPasajeros.Text, txtColonia.Text, txtCruces.Text, txtSaldo.Text, txtAnticipos.Text, txtPrecio.Text, dtFechaRegreso.Value.ToString().Substring(0,10));
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contratos de Ventas "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtCliente.Text + " " + txtDestino.Text +".pdf"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void PDFFormatoPrecios()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Formato Precios "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Formato precios "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtCliente.Text + " " + txtDestino.Text +".pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				FormatoPdf.FormatoFormatoPrecios(doc, writer, txtResponsable.Text, txtTelefono.Text, txtDomicilio.Text, txtDestino.Text, dtFecha.Value.ToString().Substring(0,10), 
				                                 NumHoraPlanton.Text+":"+NumMinPlanton.Text+" hrs", NumHoraRegreso.Text+":"+NumMinRegreso.Text+" hrs", 
				                                 NumUnidad.Text, nudPasajeros.Text, txtColonia.Text, txtCruces.Text, txtSaldo.Text, txtAnticipos.Text, txtPrecio.Text, dtFechaRegreso.Value.ToString().Substring(0,10), txtCliente.Text, txtObservaciones.Text);
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Formato precios "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtCliente.Text + " " + txtDestino.Text +".pdf"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void CmdLlamadaClick(object sender, EventArgs e)
		{
			bool entra = true;
			
			conn.getAbrirConexion("SELECT * FROM VIAJE_PROSPECTO WHERE ID="+dgProspectos[0,dgProspectos.CurrentRow.Index].Value.ToString());
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["ESTATUS"].ToString()=="3")
				{
					entra=false;
				}
			}
			conn.conexion.Close();
			
			if(entra==true)
			{
				String consul = "update VIAJE_PROSPECTO set ESTATUS='2' where ID="+dgProspectos[0,dgProspectos.CurrentRow.Index].Value.ToString();
				conn.getAbrirConexion(consul); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();	
				
				dgProspectos[3,dgProspectos.CurrentRow.Index].Style.BackColor=Color.MediumSlateBlue;
			}
		}
		
		void TxtDes_pKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta = "select top 1 * from VIAJE_PROSPECTO where DESTINO='"+txtDes_p.Text+"' order by FECHA_REG desc";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(Convert.ToDateTime(conn.leer["FECHA_REG"]).AddDays(30)>DateTime.Now)
					{
						txtPrec_p.Text=conn.leer["PRECIO"].ToString();
						txtCas_p.Text=conn.leer["CASETAS"].ToString();
						txtKm_p.Text=conn.leer["KILOMETROS"].ToString();
					}
				}
				conn.conexion.Close();
			}
		}
		
		void BtnformatopresciosClick(object sender, EventArgs e)
		{
			PDFFormatoPrecios();
		}
		
		void NumUnidadMouseUp(object sender, MouseEventArgs e)
		{
			if(NumUnidad.Text!="")
			{
				if(IVA==false)
				{
					txtSaldo.Text = ((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
				}
				else
				{
					double montoIva = (Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))*.16;
					txtSaldo.Text = (((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))+montoIva)-Convert.ToDouble(txtAnticipos.Text)).ToString();
				}
			}
		}
	}			
}
