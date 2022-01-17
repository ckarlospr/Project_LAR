using System.Linq.Expressions;
using System.ComponentModel;
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
		FormDatosFactura formDatosFact = null;
		FormValidacionEsp formValida = null;
		#endregion
		
		#region VARIABLES
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
				Insertar();
			else
				MessageBox.Show("La captura de cantidad de unidades es erronea");
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
			formValida = new FormValidacionEsp(this);
			getCargarValidacionCampos(this);
			dtFecha.Value = DateTime.Now;
			dtFechaRegreso.Value = DateTime.Now;
			Hoy = DateTime.Now.ToString("yyyy-MM-dd");
			Fecha = dtFecha.Value.ToString("yyyy-MM-dd");
			
			Adaptador();
			
			dtFechaEspecialInicio.Value = DateTime.Now.AddDays(-15);
			dtFechaEspecialFin.Value = DateTime.Now;
			
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
			
			btnImprimir.Enabled = false;
			
			cmbEstado.SelectedIndex = 0;
			cmbUnidades.SelectedIndex = 0;
			cmbTipoPago.SelectedIndex = 0;
			
			dtFecha.Focus();
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
			}
			else
			{
				foranea = "0";
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
			Modificar();
		}
		
		void DataViajesEspecialesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				lblConfirma.Visible=true;
				txtConfirma.Visible=true;
				cmdConfirma.Visible=true;
				txtConfirma.Enabled=true;
				cmdConfirma.Enabled=true;
				
				this.IDRE = Convert.ToInt16(dataViajesEspeciales[21,dataViajesEspeciales.CurrentRow.Index].Value);
				
				conn.getAbrirConexion("select ID_C from RUTA_ESPECIAL where ID_RE="+IDRE);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					this.IDC = Convert.ToInt16(conn.leer["ID_C"]);
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
				txtDatosFactura.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[14].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[14].Value.ToString());
				txtObservaciones.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[15].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[15].Value.ToString());
				//NumHoraPlanton.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(0,2));
				//NumMinPlanton.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value==null)?"":dataViajesEspeciales.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(3,2));
				txtAnticipos.Text 		= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[18].Value==null)?"0":dataViajesEspeciales.Rows[e.RowIndex].Cells[18].Value.ToString());
				cmbEstado.Text 			= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[19].Value==null)?"Activo":dataViajesEspeciales.Rows[e.RowIndex].Cells[19].Value.ToString());
				txtPagoOperador.Text 	= ((dataViajesEspeciales.Rows[e.RowIndex].Cells[20].Value==null)?"Activo":dataViajesEspeciales.Rows[e.RowIndex].Cells[20].Value.ToString());
				
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
				
				String consults = "select CL.Estado, CL.Rumbo, R.ref_Visual, R.tipoVehiculo, R.cantidad_usuarios, R.FACTURADO, R.TIPO_PAGO, R.anticipo, R.NUMERO_ANTI, R.SALDO from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and R.ID_RE ='"+IDRE+"'";
				conn.getAbrirConexion(consults);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					txtCruces.Text = conn.leer["Rumbo"].ToString();
					txtColonia.Text = conn.leer["Estado"].ToString();
					txtRefVisual.Text = conn.leer["ref_Visual"].ToString();
					nudPasajeros.Text = conn.leer["cantidad_usuarios"].ToString();
					cmbUnidades.Text = conn.leer["tipoVehiculo"].ToString();
					
					if(conn.leer["FACTURADO"].ToString()=="1")
					{
						rbFacturar.Checked=true;
						txtDatosFactura.Enabled=true;
						cmbTipoPago.Enabled=true;
						cmdIngresar.Enabled=true;
						cmdRevisar.Enabled=true;
						cmbTipoPago.Text=conn.leer["TIPO_PAGO"].ToString();
					}
					else
					{
						rbFacturar.Checked=false;
						txtDatosFactura.Enabled=false;
						cmbTipoPago.Enabled=false;
						cmdIngresar.Enabled=false;
						cmdRevisar.Enabled=false;
						cmbTipoPago.SelectedItem = 0;
					}
					
					if(Convert.ToInt64(conn.leer["anticipo"])>0)
					{
						cbAnticipos.Checked=true;
						txtAnticipos.Text=conn.leer["anticipo"].ToString();
						txtSaldo.Text=conn.leer["SALDO"].ToString();
					}
					else
					{
						cbAnticipos.Checked=false;
						txtAnticipos.Text="0.00";
						txtSaldo.Text=conn.leer["SALDO"].ToString();
					}
				}
				conn.conexion.Close();
				
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
				btnImprimir.Enabled = true;
			
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
																				  ((rbFacturar.Checked==true)?cmbTipoPago.Text:""),
																				  ((txtSaldo.Text=="")?"0":txtSaldo.Text),
																				  ((cbAnticipos.Checked==true)?txtNumeroRef.Text:"0"));
				
				
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
																				  ((rbFacturar.Checked==true)?cmbTipoPago.Text:""),
																				  txtSaldo.Text,
																				  ((cbAnticipos.Checked==true)?txtNumeroRef.Text:""));
				
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
						txtDatosFactura.Text = conn.leer["factura"].ToString();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();
				
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
						txtDatosFactura.Text = conn.leer["factura"].ToString();
						
						aurocompleteDomicilio();
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();
				
				NumUnidad.Focus();
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
				cmbUnidades.Focus();
			}
		}
		
		void CmbUnidadesKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtDomicilio.Focus();
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
				
				txtColonia.Focus();
			}
		}
		
		void TxtCrucesKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtCruces.Focus();
			}
		}
		
		void TxtColoniaKeyUp(object sender, KeyEventArgs e)
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
				txtPrecio.Focus();
			}
		}
		
		void TxtPrecioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtPagoOperador.Focus();
			}
			else
			{
				txtSaldo.Text=((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
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
				txtCasetas.Focus();
			}
		}
		
		void TxtPagoOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtAnticipos.Focus();
			}
		}
		
		void TxtCasetasKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtTelefono.Focus();
			}
		}
		
		void TxtTelefonoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtDatosFactura.Focus();
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
					cmbTipoPago.Enabled=true;
					cmdRevisar.Enabled=true;
				}
				conn.conexion.Close();
				
			}
		}
		
		void TxtObservacionesKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				btnAgregar.Focus();
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
		void BtnImprimirClick(object sender, EventArgs e)
		{
			ImprimirPDF();
		}
		
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
		
		void CkRepeticionViajesCheckedChanged(object sender, EventArgs e)
		{
			/*if(ckRepeticionViajes.Checked==true)
			{
				dtFecha.Enabled = false;
				dtFechaRegreso.Enabled = false;
				mthViajes.Enabled = true;
			}
			else
			{
				dtFecha.Enabled = true;
				dtFechaRegreso.Enabled = true;
				mthViajes.Enabled = false;
			}*/
		}
		
		void Adaptador() 
		{
			dataViajesEspeciales.Rows.Clear();
			int cont = 0;
		
			String consulta = "select R.ID_RE, C.Nombre, responsable as Responsable, R.fecha, R.hora, R.fecha_salida, R.h_planton, R.cant_unidades, R.domicilio, R.destino, CL.Estado, CL.Rumbo,  R.casetas, R.precio, C.Telefono As Telefono, R.factura, R.observaciones,  R.correo, R.fecha_regreso, R.anticipo, R.estado as Estado_especial, RT.CompletoCamioneta, R.CONF_CLIENTE from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID and R.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and RT.Sentido='Entrada' and responsable like '"+txtResp.Text+"%' and R.ID_C in (select idCliente from ContactoServicio where Nombre like '"+txtClienteBusqueda.Text+"%')  group by R.ID_RE, C.Nombre, responsable, R.fecha, R.hora, R.fecha_salida, R.h_planton, R.cant_unidades, R.domicilio, R.destino, CL.Estado, CL.Rumbo, R.casetas, R.precio, C.Telefono, R.factura, R.observaciones, R.correo, R.fecha_regreso, R.anticipo, R.estado, RT.CompletoCamioneta, R.CONF_CLIENTE ";
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
			txtDomicilio.AutoCompleteCustomSource = auto.AutoReconocimiento("select R.DOMICILIO dato from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where R.ID_C=C.idCliente and R.ID_C=CL.ID and C.Nombre ='"+txtCliente.Text+"'");
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
				cmdIngresar.Enabled=true;
			}
			else
			{
				txtDatosFactura.Enabled=false;
				txtDatosFactura.Text="";
				cmbTipoPago.Text="";
				cmdIngresar.Enabled=false;
				cmdRevisar.Enabled=false;
				cmbTipoPago.Enabled=false;
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
				conn.getAbrirConexion("select ID from DATOS_FACTURA where RAZON_SOCIAL ='"+txtCliente.Text+"'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					idFact = Convert.ToInt16(conn.leer["ID"]);
				}
				conn.conexion.Close();
				
				new FormDatosFactura(2, this, idFact).ShowDialog();
			}
		}
		#endregion
		
		void CbAnticiposCheckedChanged(object sender, EventArgs e)
		{
			if(cbAnticipos.Checked==true)
			{
				txtAnticipos.Enabled=true;
				txtNumeroRef.Enabled=true;
			}
			else
			{
				txtAnticipos.Text="0";
				txtSaldo.Text=((Convert.ToDouble(txtPrecio.Text)*Convert.ToDouble(NumUnidad.Text))-Convert.ToDouble(txtAnticipos.Text)).ToString();
				txtAnticipos.Enabled=false;
				txtNumeroRef.Enabled=false;
			}
		}
		
		void CmdFactClick(object sender, EventArgs e)
		{
			new Incapacidad.FormValidaFact().ShowDialog();
		}
	}			
}
