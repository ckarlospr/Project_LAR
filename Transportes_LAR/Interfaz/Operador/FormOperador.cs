using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
 
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormOperador : Form
	{
		#region VARIABLES
		public string direccionImagen="";
		private int edadOperador=0;
		private string idOperador="";
		private bool mostrar=true;
		private string idOperadorNuevo="";
		public String TIPO=""; 
		#endregion
		
		#region INSTANCIAS_DE_LAS_VENTANAS_SECUNDARIAS
		private Interfaz.Operador.FormLicencia formLicencia=null;
		private Interfaz.Operador.FormTelefono formTelefono=null;
		private Interfaz.Operador.FormDependiente formDependiente=null;
		private Interfaz.Operador.FormContacto formContacto=null;
		private Interfaz.FormPrincipal principal=null;
		private Proceso.PDF PDFs = new Transportes_LAR.Proceso.PDF();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONTROL_DE_VENTANAS_SECUNDARIAS
		public bool licencia=false;
		public bool telefono=false;
		public bool dependiente=false;
		public bool contacto=false;
		#endregion
		
		#region MANEJO_DE_DATOS_SECUNDARIO_AL_OPERADOR (LICENCIA - TELEFONOS - DEPENDIENTES - CONTACTOS)
		public List<Interfaz.Operador.Dato.Licencia> listLicencia=null;
		public List<Interfaz.Operador.Dato.Telefono> listTelefono=null;
		public List<Interfaz.Operador.Dato.Dependiente> listDependiente=null;
		public List<Interfaz.Operador.Dato.Contacto> listContacto=null;
		#endregion
		
		#region SOBRECARGA_DE_CONSTRUCTORES
		public FormOperador(Interfaz.FormPrincipal principal){//AGREGAR_OPERADOR
			InitializeComponent();
			this.principal=principal;
		}
		
		public FormOperador(Interfaz.FormPrincipal principal,string idOperador){//ACTUALIZAR_OPERADOR
			InitializeComponent();
			this.principal=principal;
			this.idOperador=idOperador;
			btnAgregar.Text="Modificar";
		}
		
		public FormOperador(Interfaz.FormPrincipal principal,string idOperador, string tipo){//ACTUALIZAR_OPERADOR
			InitializeComponent();
			this.principal=principal;
			this.idOperador=idOperador;
			this.TIPO=tipo;
			btnAgregar.Text="Modificar";
		}
		
		#endregion
		
		#region EVENTO_INICIO_DE_VENTANA
		void FormOperadorLoad(object sender, EventArgs e)
		{
			Cargar();
		}
		
		public void Cargar()
		{
			if(TIPO=="ADM")
			{
				getCargarValidacionCampos(this);
				cmbEstadoCivil.SelectedIndex=0;
				
				toolContacto.Visible=false;
				toolDependiente.Visible=false;
				toolLicencia.Visible=false;
				toolStripSeparator1.Visible=false;
				toolStripSeparator2.Visible=false;
				toolStripSeparator3.Visible=false;
				toolStripSeparator4.Visible=false;
				cbForaneo.Visible=false;
				
				if(new Conexion_Servidor.Zona.SQL_Zona().getNombreZona(cmbZona))
				{
						cmbZona.SelectedIndex=0;
				}
				if(idOperador!="")
				{
					lblEstado.Visible=true;
					lblSitaucion.Visible=true;
					cmbEstado.Visible=true;
					getSelectOperador();
					getSeleccionarTelefono();
					AdaptadorDocumento();
					
					if(cmbEstado.Text=="INACTIVO")
					{
						dateFechaBaja.Value = new Conexion_Servidor.Operador.SQL_Operador(principal).getUltimaFechaBaja(idOperador);
					}
				}
			}
			else if(TIPO=="EXT")
			{
				getCargarValidacionCampos(this);
				cmbEstadoCivil.SelectedIndex=0;
				
				toolContacto.Visible=false;
				toolDependiente.Visible=false;
				toolLicencia.Visible=false;
				toolStripSeparator1.Visible=false;
				toolStripSeparator2.Visible=false;
				toolStripSeparator3.Visible=false;
				toolStripSeparator4.Visible=false;
				cbForaneo.Visible=false;
				tabPage3.Enabled=false;
				tabControl2.TabPages.RemoveAt(1);
				
				if(new Conexion_Servidor.Zona.SQL_Zona().getNombreZona(cmbZona))
				{
						cmbZona.SelectedIndex=0;
				}
				if(idOperador!="")
				{
					lblEstado.Visible=true;
					lblSitaucion.Visible=true;
					cmbEstado.Visible=true;
					getSelectOperador();
					getSeleccionarTelefono();
				}
			}
			else
			{
				getCargarValidacionCampos(this);
				cmbEstadoCivil.SelectedIndex=0;
				if(new Conexion_Servidor.Zona.SQL_Zona().getNombreZona(cmbZona))
				{
						cmbZona.SelectedIndex=0;
				}
				if(idOperador!="")
				{
					lblEstado.Visible=true;
					lblSitaucion.Visible=true;
					cmbEstado.Visible=true;
					getSelectOperador();
					getSeleccionarLicencia();
					getSeleccionarTelefono();
					getSeleccionarDependiente();
					getSeleccionarContacto();
					AdaptadorDocumento();
					
					if(cmbEstado.Text=="INACTIVO")
					{
						dateFechaBaja.Value = new Conexion_Servidor.Operador.SQL_Operador(principal).getUltimaFechaBaja(idOperador);
					}
				}
			}
		}
		#endregion
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(FormOperador formOperador){
			formOperador.txtAlias.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formOperador.txtNombre.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formOperador.txtApellidoPat.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formOperador.txtApellidoMat.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formOperador.txtCurp.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formOperador.txtRFC.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formOperador.txtNSS.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formOperador.txtLugarNacimiento.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasPuntoEspacio);
			formOperador.txtEstadoNacimiento.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasPuntoEspacio);
			formOperador.txtMunicipioNacimiento.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasPuntoEspacio);
			formOperador.dateFechaNacimiento.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			formOperador.txtCalle.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formOperador.txtColonia.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formOperador.txtMunicipio.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formOperador.txtEstado.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formOperador.txtReferencia1.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formOperador.txtReferencia2.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formOperador.txtNumInterior.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
			formOperador.txtNumExterior.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
			formOperador.txtCP.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
		
		#region EVENTOS_DE_LA_BARRA_DE_MENU
		
		void ToolLicenciaClick(object sender, EventArgs e){
			if(this.licencia){
				if(formLicencia.WindowState==FormWindowState.Minimized)
					formLicencia.WindowState = FormWindowState.Normal;
				else
					formLicencia.BringToFront();
			}else{
				this.formLicencia=new Transportes_LAR.Interfaz.Operador.FormLicencia(this, idOperador);
				formLicencia.Show();
				licencia=true;
			}	
		}
		
		void ToolTelefonoClick(object sender, EventArgs e){
			if(this.telefono){
				if(formTelefono.WindowState==FormWindowState.Minimized)
					formTelefono.WindowState = FormWindowState.Normal;
				else
					formTelefono.BringToFront();
			}else{
				this.formTelefono=new Transportes_LAR.Interfaz.Operador.FormTelefono(this, idOperador);
				formTelefono.Show();
				telefono=true;
			}
		}
		
		void ToolDependienteClick(object sender, EventArgs e){
			if(this.dependiente){
				if(formDependiente.WindowState==FormWindowState.Minimized)
					formDependiente.WindowState = FormWindowState.Normal;
				else
					formDependiente.BringToFront();
			}else{
				this.formDependiente=new Transportes_LAR.Interfaz.Operador.FormDependiente(this);
				formDependiente.Show();
				dependiente=true;
			}
		}
		
		void ToolContactoClick(object sender, EventArgs e){
			if(this.contacto){
				if(formContacto.WindowState==FormWindowState.Minimized)
					formContacto.WindowState = FormWindowState.Normal;
				else
					formContacto.BringToFront();
			}else{
				this.formContacto=new Transportes_LAR.Interfaz.Operador.FormContacto(this);
				formContacto.Show();
				contacto=true;
			}
		}
		
		#endregion
		
		#region EVENTO_DE_LOS_BOTONES (AGREGAR-CANCELAR)
		void BtnAgregarClick(object sender, EventArgs e)
		{

			getAlmacenarOperador();
		}
		
		void BtnCancelarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
		#region CARGAR_IMAGEN
		void BtnImagenClick(object sender, EventArgs e){
			try{
				OpenFileDialog dlg = new OpenFileDialog();
				dlg.Title= "Operador";
				dlg.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*PNG|"+"All files (*.*)|*.*";
				DialogResult result=dlg.ShowDialog();
				if(result== DialogResult.OK){
					ptbImagen.Image = System.Drawing.Image.FromFile(dlg.FileName);
					direccionImagen = dlg.FileName;
					String nombre = dlg.SafeFileName;
					System.Drawing.Image image = System.Drawing.Image.FromFile(direccionImagen);
					image = new Proceso.RedimensionarImagen().Redimensionar(image);
					image.Save(System.Environment.SystemDirectory.Substring(0, 3) +@"\Imagenes\"+nombre);
					image.Dispose();
					ptbImagen.Image = System.Drawing.Image.FromFile(System.Environment.SystemDirectory.Substring(0, 3) +@"\Imagenes\"+nombre);
				}else{
					direccionImagen="";
					ptbImagen.Image = System.Drawing.Image.FromFile("Camara.png");
				}
			}catch{
				direccionImagen="";
				MessageBox.Show("Error durante la obtención de la imagen.","Cargarndo imagen",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		#endregion
		
		#region CALCULANDO_EDAD_DEL_OPERADOR
		void DateFechaNacimientoValueChanged(object sender, EventArgs e)
		{
			TimeSpan ts = DateTime.Today - dateFechaNacimiento.Value.Date;
			this.edadOperador= (ts.Days)/365;
			
		}
		#endregion
		
		#region EVENTO_CIERRE_DE_VENTANA
		void FormOperadorFormClosing(object sender, FormClosingEventArgs e)
		{
			if(mostrar){
				if(MessageBox.Show("¿Dese cerrar la ventana de almacenamiento de un nuevo operador?","Almacenar operador",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel){
					e.Cancel=true;
				}else{
					principal.operador=false;
					getCerrarVentana();
				}
			}else{
				principal.operador=false;
			}	
		}
		#endregion
		
		#region CERRAR_VENTANAS_SECUNDARIAS_EN_CASO_DE_ESTAR_ABIERTAS
		private void getCerrarVentana(){
			if(licencia){
				formLicencia.Close();
			}
			if(telefono){
				formTelefono.Close();
			}
			if(dependiente){
				formDependiente.Close();
			}
			if(contacto){
				formContacto.Close();
			}
		}
		#endregion
		
		#region ALMACENAR_OPERADOR
		private void getAlmacenarOperador()
		{
				if(edadOperador>=18)
				{
					if(!(new Interfaz.Operador.Operacion(this).getValidarCampo()) || TIPO=="EXT")
					{
						if(idOperador=="")
						{//INSERTAR_OPERADOR
							if(new Conexion_Servidor.Operador.SQL_Operador(principal).getValidarExistencia(txtAlias.Text)==true)//VERIFICANDO_SI_EXISTE_EL_ALIAS_DEL_OPERADOR
								MessageBox.Show("El Alias: "+txtAlias.Text+" no puede ser almacenado debido a que ya se encuentra registrado o ya hay uno Empleado con el mismo Alias.","Aviso Importante!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
							else
							{
								getInsertOperador();
								getInsertComplemento();
								new Interfaz.FormMensaje("Operador almaceado correctamente").Show();
								if(cmbCasa.Text=="PROPIA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().InsertarTipoCasa(idOperadorNuevo, "PROPIA");
								}
								else if(cmbCasa.Text=="RENTADA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().InsertarTipoCasa(idOperadorNuevo, "RENTADA");
								}
								if(cmbCasa.Text=="PROPIA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().ModificarTipoCasa(idOperadorNuevo, "PROPIA");
								}
								else if(cmbCasa.Text=="RENTADA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().ModificarTipoCasa(idOperadorNuevo, "RENTADA");
								}
								tabControl2.SelectedIndex = 0;
								new Interfaz.Operador.Operacion(this).getLimpiarCampos();
								InsertarDoc();								
							}
						}
						else
						{
							//PROCESO_DE_MODIFICAR_OPERADOR
							if(DialogResult.Yes==MessageBox.Show("¿Desea modificar al operador?","Modificar operador",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
							{
								if(cmbEstado.Text=="INACTIVO")
								{
									if(DialogResult.Yes==MessageBox.Show("El estado del operador esta marcado como inactivo. ¿Desea establecer al operador de esta manera?","Operador INACTIVO",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
									{
										new Interfaz.Operador.FormDetalleBaja(idOperador,txtNombre.Text,txtApellidoPat.Text,txtApellidoMat.Text).ShowDialog();
										new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getEliminarAsignacionUnidad2(idOperador);
										new Conexion_Servidor.Operador.SQL_Telefono().getEliminarTelefonoBaja(idOperador);
										new Conexion_Servidor.Operador.SQL_Operador().ActualizarUltimaFechaBaja(idOperador, dateFechaBaja.Value.ToShortDateString());
									}
									else
									{
										cmbEstado.SelectedIndex=0;
									}
								}
								getUpdateOperador();
								getUpdateComplemento();
								ModificarDoc();
								if(cmbCasa.Text=="PROPIA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().InsertarTipoCasa(idOperador, "PROPIA");
								}
								else if(cmbCasa.Text=="RENTADA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().InsertarTipoCasa(idOperador, "RENTADA");
								}
								if(cmbCasa.Text=="PROPIA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().ModificarTipoCasa(idOperador, "PROPIA");
								}
								else if(cmbCasa.Text=="RENTADA")
								{
									new Conexion_Servidor.Operador.SQL_Operador().ModificarTipoCasa(idOperador, "RENTADA");
								}
								new Interfaz.FormMensaje("Operador modificado correctamente").Show();
								mostrar=false;
								this.Close();
							}
							
						}
						
					}
					else
						MessageBox.Show("El operador no puede ser almacenado ya que faltan campos por llenar.","Almacenando operador",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
					MessageBox.Show("El proceso de almacenamiento no puede continuar debido a que la fecha de nacimiento es incorrecta ya que la edad del operador es de "+edadOperador+" años.","Almacenando datos del operador",MessageBoxButtons.OK,MessageBoxIcon.Stop);
		}
		#endregion
		
		#region SQL_SENTENCIAS
		private void getInsertOperador()
		{
			if(TIPO.Equals("OPE"))
			{
				new Conexion_Servidor.Operador.SQL_Operador(principal).getInsertarOperador(txtNombre.Text,
			                                                                  txtApellidoPat.Text,
			                                                                  txtApellidoMat.Text,
			                                                                  txtCalle.Text,
			                                                                  txtColonia.Text,
			                                                                  txtNumInterior.Text,
			                                                                  txtNumExterior.Text,
			                                                                  txtMunicipio.Text,
			                                                                  txtReferencia1.Text,
			                                                                  txtReferencia2.Text,
			                                                                  txtCP.Text,
			                                                                  dateFechaNacimiento.Value.ToString("dd-MM-yyyy"),
			                                                                  txtLugarNacimiento.Text,
			                                                                  txtEstadoNacimiento.Text,
			                                                                  txtMunicipioNacimiento.Text,
			                                                                  txtRFC.Text,
			                                                                  txtCurp.Text,
			                                                                  txtNSS.Text,
			                                                                  cmbEstadoCivil.Text,
			                                                                  txtEstado.Text,
			                                                                  ptbImagen,
			                                                                  txtAlias.Text,
			                                                                  cmbZona.Text,
			                                                                  (direccionImagen!="")?true:false,
 			                                                                  (cbForaneo.Checked==true)?1:0,
 			                                                                 txtNumInfonavit.Text);
	 		}
			else if(TIPO.Equals("EXT"))
			{
				new Conexion_Servidor.Operador.SQL_Operador(principal).getInsertarExt(txtNombre.Text,
			                                                                  txtApellidoPat.Text,
			                                                                  txtApellidoMat.Text,
			                                                                  txtCurp.Text,
			                                                                  txtRFC.Text,
			                                                                  dateFechaNacimiento.Value.ToString("yyyy-MM-dd"),
			                                                                  cmbEstadoCivil.Text,
			                                                                  txtLugarNacimiento.Text,
			                                                                  txtEstado.Text,
			                                                                  txtMunicipio.Text,
			                                                                  txtAlias.Text);
			}
			else if(TIPO.Equals("ADM"))
			{
			   	new Conexion_Servidor.Operador.SQL_Operador(principal).getInsertarAdmin(txtNombre.Text,
			                                                                  txtApellidoPat.Text,
			                                                                  txtApellidoMat.Text,
			                                                                  txtCalle.Text,
			                                                                  txtColonia.Text,
			                                                                  txtNumInterior.Text,
			                                                                  txtNumExterior.Text,
			                                                                  txtMunicipio.Text,
			                                                                  txtReferencia1.Text,
			                                                                  txtReferencia2.Text,
			                                                                  txtCP.Text,
			                                                                  dateFechaNacimiento.Value.ToString("dd-MM-yyyy"),
			                                                                  txtLugarNacimiento.Text,
			                                                                  txtEstadoNacimiento.Text,
			                                                                  txtMunicipioNacimiento.Text,
			                                                                  txtRFC.Text,
			                                                                  txtCurp.Text,
			                                                                  txtNSS.Text,
			                                                                  cmbEstadoCivil.Text,
			                                                                  txtEstado.Text,
			                                                                  ptbImagen,
			                                                                  txtAlias.Text,
			                                                                  cmbZona.Text,
			                                                                 (direccionImagen!="")?true:false,
			                                                                txtNumInfonavit.Text);
			}
		}
		
		private void getSelectOperador(){
		new Conexion_Servidor.Operador.SQL_Operador(principal).getOperador(idOperador,
			                                                    txtNombre,
			                                                    txtApellidoPat,
			                                                    txtApellidoMat,
			                                                    txtCalle,
			                                                    txtColonia,
			                                                    txtNumInterior,
			                                                    txtNumExterior,
			                                                    txtMunicipio,
			                                                    txtReferencia1,
			                                                    txtReferencia2,
			                                                    txtCP,
			                                                    dateFechaNacimiento,
			                                                    txtLugarNacimiento,
			                                                    txtEstadoNacimiento,
			                                                    txtMunicipioNacimiento,
			                                                    txtRFC,
			                                                    txtCurp,
			                                                    txtNSS,
			                                                    cmbEstadoCivil,
			                                                    ptbImagen,
			                                                    txtAlias,
			                                                    txtEstado,
			                                                    cmbEstado,
			                                                    cmbZona,
			                                                    cbForaneo,
			                                                    txtNumInfonavit,
			                                                    txtcorreo);
			if(new Conexion_Servidor.Operador.SQL_Operador().getCasa(idOperador)=="PROPIA")
			{
				cmbCasa.Text="PROPIA";
			}
			else
			{
				cmbCasa.Text="RENTADA";
			}
		}
		
		private void getUpdateOperador(){
			string estado=(cmbEstado.Text=="ACTIVO")?"1":"0";
			new Conexion_Servidor.Operador.SQL_Operador(principal).getModificarOperador(txtNombre.Text , 
			                                                                   txtApellidoPat.Text ,
			                                                                   txtApellidoMat.Text ,
			                                                                   txtCalle.Text ,
			                                                                   txtColonia.Text ,
			                                                                   txtNumInterior.Text ,
			                                                                   txtNumExterior.Text ,
			                                                                   txtMunicipio.Text ,
			                                                                   txtReferencia1.Text ,
			                                                                   txtReferencia2.Text ,
			                                                                   txtCP.Text ,
			                                                                   dateFechaNacimiento.Value.ToString("dd-MM-yyyy") ,
			                                                                   txtLugarNacimiento.Text , 
			                                                                   txtEstadoNacimiento.Text ,
			                                                                   txtMunicipioNacimiento.Text ,
			                                                                   txtRFC.Text ,
			                                                                   txtCurp.Text ,
			                                                                   txtNSS.Text ,
			                                                                   cmbEstadoCivil.Text ,
			                                                                   txtEstado.Text ,
			                                                                   ptbImagen ,
			                                                                   txtAlias.Text,
			                                                                   idOperador,
			                                                                   estado,
																			   cmbZona.Text,
			                                                                   true,
			                                                                   cbForaneo.Checked,
			                                                                   txtNumInfonavit.Text);
		}
		
		#endregion
		
		private void InsertaCorreo(string id_opE){
			try{				
				String consul = "update OPERADOR set CORREO = '"+txtcorreo.Text+"' WHERE ID = "+id_opE;
				conn.getAbrirConexion(consul);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al insertar el correo: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#region COMPLEMENTOS
		private void getInsertComplemento()
		{
			this.idOperadorNuevo=new Conexion_Servidor.Operador.SQL_Operador(principal).getIdOperador();
			getInsertarLicencia(0);
			getInsertarTelefono(0);
			getInsertarDependiente(0);
			getInsertarContacto(0);
			listLicencia=null;
			listTelefono=null;
			listDependiente=null;
			InsertaCorreo(idOperadorNuevo);
		}
		
		private void getUpdateComplemento()
		{
			this.idOperadorNuevo=new Conexion_Servidor.Operador.SQL_Operador(principal).getIdOperador2(txtCurp.Text,txtNSS.Text, TIPO);
			getInsertarLicencia(0);
			getInsertarTelefono(0);
			getInsertarDependiente(0);
			getInsertarContacto(0);
			listLicencia=null;
			listTelefono=null;
			listDependiente=null;
			InsertaCorreo(idOperadorNuevo);
		}
		#endregion
		
		#region INSERTAR:LICENCIA-TELEFONO-DEPENDIENTE-CONTACTO
		private object getInsertarLicencia(int contador){
			if(listLicencia!=null && listLicencia.Count>0){
				string id=(listLicencia[contador].id==null)?"null":listLicencia[contador].id;
				new Conexion_Servidor.Operador.SQL_Licencia().getInsertarLicencia(
					"execute almacenar_modificar_licencia "+id	+",'" +
					listLicencia[contador].clase  				+"','"+
					listLicencia[contador].numero 				+"','"+
					listLicencia[contador].vigencia				+"','"+
					listLicencia[contador].tipo					+"'," +
					idOperadorNuevo
				);
			}else{
				return null;
			}
			return (contador<(listLicencia.Count-1))?getInsertarLicencia(++contador):null;
		}
		
		private object getInsertarTelefono(int contador){
			if(listTelefono!=null && listTelefono.Count>0){
				string id=(listTelefono[contador].id==null)?"null":listTelefono[contador].id;
				new Conexion_Servidor.Operador.SQL_Telefono().getInsertarTelefono(
					"execute almacenar_modificar_telefonochofer "+id	+",'" +
					listTelefono[contador].tipo  						+"','"+
					listTelefono[contador].numero 						+"','"+
					listTelefono[contador].descripcion					+"',"+
					idOperadorNuevo
				);
			}else{
				return null;
			}
			return (contador<(listTelefono.Count-1))?getInsertarTelefono(++contador):null;
		}
		
		private object getInsertarDependiente(int contador){
			if(listDependiente!=null && listDependiente.Count>0){
				string id=(listDependiente[contador].id==null)?"null":listDependiente[contador].id;
				new Conexion_Servidor.Operador.SQL_Dependiente().getInsertarDependiente(
					"execute almacenar_modificar_dependiente "+id		+",'" +
					listDependiente[contador].sexo  					+"','"+
					listDependiente[contador].fechaNacimiento 			+"','"+
					listDependiente[contador].parentesco				+"',"+
					idOperadorNuevo
				);
			}else{
				return null;
			}
			return (contador<(listDependiente.Count-1))?getInsertarDependiente(++contador):null;
		}
		
		private object getInsertarContacto(int contador){
			if(listContacto!=null && listContacto.Count>0){
				string id=(listContacto[contador].id==null)?"null":listContacto[contador].id;
				new Conexion_Servidor.Operador.SQL_Contacto().getInsertarContacto(
					"execute almacenar_modificar_contacto "+id	+",'" +
					listContacto[contador].nombre  				+"','"+
					listContacto[contador].apellidoPat 			+"','"+
					listContacto[contador].apellidoMat 			+"','"+
					listContacto[contador].calle 				+"','"+
					listContacto[contador].numInterior 			+"','"+
					listContacto[contador].numExterior 			+"','"+
					listContacto[contador].colonia 				+"','"+
					listContacto[contador].municipio 			+"','"+
					listContacto[contador].estado 				+"'," +
					listContacto[contador].cp 					+ ",'"+
					listContacto[contador].telefono				+"'," +
					idOperadorNuevo
				);
			}else{
				return null;
			}
			return (contador<(listContacto.Count-1))?getInsertarContacto(++contador):null;
		}
		
		#endregion
		
		#region SELECCIONAR_COLECCION:LICENCIA-TELEFONO-DEPENDIENTE-CONTACTO
		private void getSeleccionarLicencia(){
			listLicencia=new Conexion_Servidor.Operador.SQL_Licencia().getListLicencia(idOperador);
		}
		private void getSeleccionarTelefono(){
			listTelefono=new Conexion_Servidor.Operador.SQL_Telefono().getListTelefono(idOperador);
		}
		private void getSeleccionarDependiente(){
			listDependiente=new Conexion_Servidor.Operador.SQL_Dependiente().getListDependiente(idOperador);
		}
		private void getSeleccionarContacto(){
			listContacto=new Conexion_Servidor.Operador.SQL_Contacto().getListContacto(idOperador);
		}
		#endregion
		
		#region ALIAS_BAJA
		void CmbEstadoSelectedIndexChanged(object sender, EventArgs e)
		{
			Random rnd = new Random(DateTime.Now.Millisecond);
			
			if(cmbEstado.Text=="INACTIVO")
			{
				txtAlias.Text = "BAJA_"+txtAlias.Text+"_"+rnd.Next(10, 99);
				lblFechaBaja.Visible = true;
				dateFechaBaja.Visible = true;
				dateFechaBaja.Value = Convert.ToDateTime(new Conexion_Servidor.Operador.SQL_Operador(principal).getUltimaFechaBaja(idOperador));
			}
			else
				txtAlias.Text = new Conexion_Servidor.Operador.SQL_Operador(principal).getTraerAliasBaja(idOperador);
		}
		#endregion
		
		#region DOCUMENTO
		void AdaptadorDocumento()
		{
			int contador = 0;
			dataDoc.Rows.Clear();
			dataDoc.ClearSelection();
			
			conn.getAbrirConexion("Select d.ID, d.Nombre, d.tipo, d.cantidad, d.Descripcion from Documento d");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataDoc.Rows.Add();
				dataDoc.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataDoc.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
				dataDoc.Rows[contador].Cells[2].Value = conn.leer["tipo"].ToString();
				dataDoc.Rows[contador].Cells[3].Value = conn.leer["cantidad"].ToString();
				dataDoc.Rows[contador].Cells[4].Value = conn.leer["Descripcion"].ToString();
				dataDoc.Rows[contador].Cells[5].Value = new Conexion_Servidor.Operador.SQL_Operador(principal).EstatusDocumentos(dataDoc.Rows[contador].Cells[0].Value.ToString(), idOperador);
				//dataDoc.Rows[contador].Cells[5].Value = 0;
				++contador;
			}
			conn.conexion.Close();
			//op_doc tabla, id_o e id_D estatus
		}
		
		void InsertarDoc()
		{
			String Estado = "COMPLETO";
			for(int a = 0; a<(dataDoc.RowCount);a++)
			{
				new Conexion_Servidor.Operador.SQL_Operador(principal).InsertarDocumentos(dataDoc.Rows[a].Cells[0].Value.ToString(), new Conexion_Servidor.Operador.SQL_Operador(principal).getIdOperador(), (Convert.ToInt32(dataDoc.Rows[a].Cells[5].Value)));
				if((Convert.ToInt32(dataDoc.Rows[a].Cells[5].Value))==0)
				{
					Estado = "INCOMPLETO";
				}
				new Conexion_Servidor.Operador.SQL_Operador(principal).ValidacionDocumentos(idOperador, Estado);
			}
		}
		
		void ModificarDoc()
		{
			String Estado = "COMPLETO";
			for(int a = 0; a<(dataDoc.RowCount);a++)
			{
				new Conexion_Servidor.Operador.SQL_Operador(principal).ModificarDocumentos(dataDoc.Rows[a].Cells[0].Value.ToString(), idOperador, (Convert.ToInt32(dataDoc.Rows[a].Cells[5].Value)));
				if((Convert.ToInt32(dataDoc.Rows[a].Cells[5].Value))==0)
				{
					Estado = "INCOMPLETO";
				}
				new Conexion_Servidor.Operador.SQL_Operador(principal).ValidacionDocumentos(idOperador, Estado);
			}
		}
		#endregion
		
		#region PDF
		void ToolInscripcionClick(object sender, EventArgs e)
		{
			PDF();
		}
		
		public void InscripcionPDF(Document document, PdfWriter writer)
		{
				FormatoPdf.FormatoDatosInscripcion(document, writer, txtNombre.Text, txtApellidoPat.Text, 
				                                   txtApellidoMat.Text, txtLugarNacimiento.Text, dateFechaNacimiento.Value.ToShortDateString(), 
				                                   "", txtCurp.Text, txtRFC.Text, txtNSS.Text, txtCalle.Text, txtColonia.Text, 
				                                   txtMunicipio.Text, txtEstado.Text, txtNumExterior.Text, txtCP.Text, 
				                                   txtReferencia1.Text, txtReferencia2.Text, idOperador, txtNumInfonavit.Text);
		}
		
		public void PDF()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Inscripción "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				Document doc = new Document(PageSize.LETTER, 30, 30 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Inscripción "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtAlias.Text+" Inscripción.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				InscripcionPDF(doc, writer);
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Inscripción "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtAlias.Text+" Inscripción.pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		
		#region VALIDACIONES
		void TxtNumInfonavitLeave(object sender, EventArgs e)
		{           
			if (Char.IsNumber(txtNumInfonavit.Text, 0))
			{
            	if(txtNumInfonavit.Text.Length == 9){
				txtNumInfonavit.Text = "0"+txtNumInfonavit.Text;
				}
				if(txtNumInfonavit.Text.Length >= 0 && txtNumInfonavit.Text.Length <=8){
					txtNumInfonavit.Focus();
				}
            }			
		}
		
		void TxtCurpLeave(object sender, EventArgs e)
		{
			if(txtCurp.Text.Length >= 0 && txtCurp.Text.Length <=17){
				txtCurp.Focus();
			}
		}
		
		void TxtNSSLeave(object sender, EventArgs e)
		{
			if(txtNSS.Text.Length == 10){
				txtNSS.Text = "0"+txtNSS.Text;
			}
			if(txtNSS.Text.Length >= 0 && txtNSS.Text.Length <=9){
				txtNSS.Focus();
			}
		}
		
		void TxtRFCLeave(object sender, EventArgs e)
		{
			if(txtRFC.Text.Length >= 0 && txtRFC.Text.Length <= 12){
				txtRFC.Focus();
			}
		}
		#endregion
	}
}
