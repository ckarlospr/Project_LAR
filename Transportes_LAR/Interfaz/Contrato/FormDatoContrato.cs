using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Transportes_LAR.Conexion_Servidor.Operador;

namespace Transportes_LAR.Interfaz.Contrato
{
	public partial class FormDatoContrato : Form
	{
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		
		#region VARIABLES
		public string IDDato="";
		public string idOperador="";
		public string datopatron="";
		String tipocontrato = "";
		public Interfaz.FormPrincipal principal=null;
		Interfaz.Operador.FormOperador foperador = null;
		#endregion
		
		#region CONSTRUCTORES
		public FormDatoContrato()
		{
			InitializeComponent();
		}
		
		public FormDatoContrato(string idOperador)
		{
			InitializeComponent();
			this.idOperador=idOperador;
		}
		
		public FormDatoContrato(Interfaz.FormPrincipal principal){//ACTUALIZAR_OPERADOR
			InitializeComponent();
			this.principal=principal;
			
		}
		
		public FormDatoContrato(Interfaz.FormPrincipal principal, string idOperador){//ACTUALIZAR_OPERADOR
			InitializeComponent();
			this.principal=principal;
			this.idOperador=idOperador;
		}
		
		public FormDatoContrato(Interfaz.FormPrincipal principal,  string IDDato, string idOperador, String patron, String Date, String contrato){//ACTUALIZAR_OPERADOR
			InitializeComponent();
			this.principal=principal;
			this.IDDato=IDDato;
			this.idOperador=idOperador;
			this.datopatron=patron;
			this.dateFecha.Value = Convert.ToDateTime(Date);
			this.tipocontrato = contrato;
		}
		#endregion
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		void getCargarValidacionCampos(FormDatoContrato datoContrato){
			datoContrato.cmbPatron.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.txtNacionalidadPatron.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			datoContrato.txtEdadPatron.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			datoContrato.txtDomicilioPatron.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.cualquierCaracter);
			datoContrato.txtNacionalidad.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			datoContrato.txtCelebra.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			datoContrato.txtServicioPersonal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.txtLugarDesempeno.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.txtTarifa.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			datoContrato.txtImpuestoRenta.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			datoContrato.txtDiaPago.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.txtLugarPaga.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.txtVacaciones.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.txtFirmaPor.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.txtLugarFirma.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			datoContrato.cmbSexoPatron.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			datoContrato.cmbSexo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			datoContrato.cmbEstadoCivilPatron.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
		}
		#endregion
		
		#region EVENTO_LOAD
		void FormDatoContratoLoad(object sender, EventArgs e)
		{
			getListaPatron(0,new Conexion_Servidor.Contrato.SQL_Contrato().getNombrePatron());
			cmbPatron.AutoCompleteCustomSource = new Conexion_Servidor.Contrato.SQL_Contrato().LoadAutoComplete();
	        cmbPatron.AutoCompleteMode 		= AutoCompleteMode.Suggest;
	        cmbPatron.AutoCompleteSource 	= AutoCompleteSource.CustomSource;
	        getCargarDatoEmpleado();
	        getCargarContrato();
	        getCargarValidacionCampos(this);
	        
	        if(datopatron!="")
	        {
	       		Interfaz.Operador.Dato.Patron patron  =new Conexion_Servidor.Contrato.SQL_Contrato().getDatosPatron(datopatron);
				cmbPatron.Text                      =patron.Nombre;
				txtNacionalidadPatron.Text			=patron.nacionalidad;
				txtEdadPatron.Text					=patron.edad;
				cmbSexoPatron.SelectedItem			=patron.sexo;
				cmbEstadoCivilPatron.SelectedItem	=patron.estadoCivil;
				txtDomicilioPatron.Text				=patron.domicilio;
	       	}	        
			dateFechaFin.Value = dateFecha.Value.AddDays(27);
		}
		
		
		private object getListaPatron(int contador,List<string> patron)
		{
			if(patron.Count==0)
			return null;
			cmbPatron.Items.Add(patron[contador]);
			return (contador<(patron.Count-1))?getListaPatron(++contador,patron):null;
		}
		#endregion
		
		#region CARGAR_LOS_DATOS_DEL_EMPLEADO
		private void getCargarDatoEmpleado()
		{
			Interfaz.Operador.Dato.OperadorDato empleado=new Conexion_Servidor.Contrato.SQL_Contrato().getDatosEmpleado(idOperador);
			txtNombreEmpleado.Text		=empleado.nombre;
			txtEdad.Text				=empleado.edad;
			cmbEstadoCivil.Text	=empleado.estadoCivil;
			txtDomicilio.Text			=empleado.domicilio;
			cmbSexoPatron.SelectedItem			="Masculino";
			cmbSexo.SelectedItem = "Masculino";
		}
		#endregion
		
		#region CARGAR_DATOS_DEL_PATRON
		void CmbPatronTextChanged(object sender, EventArgs e)
		{
			Interfaz.Operador.Dato.Patron patron  =new Conexion_Servidor.Contrato.SQL_Contrato().getDatosPatron(cmbPatron.Text);
			if(patron!=null){
				txtNS.Text                          =patron.Ns;
				txtNacionalidadPatron.Text			=patron.nacionalidad;
				txtEdadPatron.Text					=patron.edad;
				cmbSexoPatron.SelectedItem			=patron.sexo;
				cmbEstadoCivilPatron.SelectedItem	=patron.estadoCivil;
				txtDomicilioPatron.Text				=patron.domicilio;
			}
			else
			{
				txtNS.Text 							="";
				txtNacionalidadPatron.Text			="";
				txtEdadPatron.Text					="";
				cmbSexoPatron.SelectedItem			="Masculino";
				cmbEstadoCivilPatron.SelectedItem	="Casado";
				txtDomicilioPatron.Text				="";
			}
		}
		#endregion
		
		#region EVENTO_ALMACENAR_CONTRATO
		public void getAlmacenarContrato(){
			string tipoContrato=(checkBox1.Checked==true)?"Planta":"Temporal";
			string Fecha_vencimiento = "";
			Fecha_vencimiento = (Convert.ToDateTime(dateFechaFin.Value.ToString("yyyy-MM-dd"))).ToString().Substring(0,10);
			//Fecha_vencimiento = (Convert.ToDateTime(dateFecha.Value.ToString("yyyy-MM-dd"))).ToString().Substring(0,10);
			new Conexion_Servidor.Contrato.SQL_Contrato().getAlmacenarContrato(
										 idOperador,
		                                 dateFecha.Value.ToString("yyyy-MM-dd"),
		                                 cmbPatron.Text,
		                                 txtNS.Text,
		                                 txtNacionalidadPatron.Text,
		                                 txtEdadPatron.Text,
		                                 cmbSexoPatron.Text,
		                                 cmbEstadoCivilPatron.Text,
		                                 txtDomicilioPatron.Text,
		                                 txtNacionalidad.Text,
		                                 cmbSexo.Text,
		                                 txtCelebra.Text,
		                                 txtServicioPersonal.Text,
		                                 txtLugarDesempeno.Text,
		                                 txtDuracionJornada.Text,
		                                 txtTarifa.Text,
		                                 txtImpuestoRenta.Text,
		                                 txtDiaPago.Text,
		                                 txtLugarPaga.Text,
		                                 txtVacaciones.Text,
		                                 txtFirmaPor.Text,
		                                 txtLugarFirma.Text,
		                                 principal.nombreUsuario,
		                                 tipoContrato,
		                                 Fecha_vencimiento);
			new Interfaz.FormMensaje("Contrato almacenado").Show();
		}
		
		#endregion 
		
		#region GET ACTUALIZAR CONTRATO
		public void getActualizarContrato(){
			string tipoContrato=(checkBox1.Checked==true)?"Planta":"Temporal";
			string Fecha_vencimiento = "";
			Fecha_vencimiento = (Convert.ToDateTime(dateFechaFin.Value.ToString("yyyy-MM-dd"))).ToString().Substring(0,10);
			//Fecha_vencimiento = (Convert.ToDateTime(dateFecha.Value.ToString("yyyy-MM-dd")).AddDays(28)).ToString().Substring(0,10);
			new Conexion_Servidor.Contrato.SQL_Contrato().getOperadorModificar(
										 IDDato,
										 dateFecha.Value.ToString("yyyy-MM-dd"),
		                                 cmbPatron.Text,
		                                 txtNS.Text,
		                                 txtNacionalidadPatron.Text,
		                                 txtEdadPatron.Text,
		                                 cmbSexoPatron.Text,
		                                 cmbEstadoCivilPatron.Text,
		                                 txtDomicilioPatron.Text,
		                                 txtNacionalidad.Text,
		                                 cmbSexo.Text,
		                                 txtCelebra.Text,
		                                 txtServicioPersonal.Text,
		                                 txtLugarDesempeno.Text,
		                                 txtDuracionJornada.Text,
		                                 txtTarifa.Text,
		                                 txtImpuestoRenta.Text,
		                                 txtDiaPago.Text,
		                                 txtLugarPaga.Text,
		                                 txtVacaciones.Text,
		                                 txtFirmaPor.Text,
		                                 txtLugarFirma.Text,
		                                 tipoContrato,
		                                 Fecha_vencimiento);
			new Interfaz.FormMensaje("Contrato Modificado").Show();
		}
		#endregion
		
		#region EVENTO_BOTONES ( ACEPTAR - CANCELAR )
		public void BtnAceptarClick(object sender, EventArgs e)
		{
			//Contrato();
			try
			{
				this.foperador = new Interfaz.Operador.FormOperador(principal,idOperador);
				this.foperador.Cargar();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ocurrio "+ex);
			}
			
			if(cmbPatron.Text.Equals("") && txtNacionalidadPatron.Text.Equals("") &&
			  txtEdadPatron.Text.Equals("") && cmbEstadoCivilPatron.Text.Equals("") &&
			  cmbSexoPatron.Text.Equals("") && txtDomicilioPatron.Text.Equals("") && 
			  txtNacionalidad.Text.Equals("") && cmbSexo.Text.Equals("") &&
			  txtCelebra.Text.Equals("") && txtServicioPersonal.Text.Equals("") &&
			  txtLugarDesempeno.Text.Equals("") && txtDuracionJornada.Text.Equals("") &&
			  txtTarifa.Text.Equals("") && txtDiaPago.Text.Equals("") &&
			  txtFirmaPor.Text.Equals("") && txtLugarFirma.Text.Equals("")
			  )
			{
				MessageBox.Show("¿Es necesario llenar todos los datos?","Error en los datos",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			}
			else
			{
				if(btnAceptar.Text.Equals("Modificar"))
				   {
						this.getActualizarContrato();
						ImprimirPDF();
				   }
				   else
				   {
						this.getAlmacenarContrato();
						ImprimirPDF();
				   }
			}
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			if(DialogResult.Yes==MessageBox.Show("¿Desea cancelar el contrato actual?","Contrato del operador",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
				{
					this.Close();
				}
		}
		#endregion
		
		#region EVENTO CERRADO
		void FormDatoContratoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.datoContrato=false;
		}
		#endregion
		
		#region CARGAR_CONTRATO
		private void getCargarContrato()
		{
			Interfaz.Operador.Dato.OperadorContrato empleado=new Conexion_Servidor.Contrato.SQL_Contrato().getContratoEmpleado(IDDato);
			if(empleado!=null){
				cmbSexo.SelectedItem.Equals("Masculino");
				txtNacionalidad.Text		=empleado.nacionalidad;
				cmbSexo.SelectedItem		=empleado.sexo;
				txtServicioPersonal.Text	=empleado.servicioPersonal;
				txtLugarDesempeno.Text		=empleado.lugarDesempeno;
				txtDuracionJornada.Text		=empleado.duracionJornada;
				txtTarifa.Text				=empleado.tarifa;
				txtImpuestoRenta.Text		=empleado.impuestoRenta;
				txtDiaPago.Text				=empleado.diaPago;
				txtLugarPaga.Text			=empleado.lugarPago;
				txtFirmaPor.Text			=empleado.firmaPor;
				txtLugarFirma.Text			=empleado.lugarFirma;
				txtCelebra.Text				=empleado.tiempoCelebracion;
				txtVacaciones.Text			=empleado.vacaciones;
			}
			if(tipocontrato=="Planta")
				checkBox1.Checked=true;
		}
		#endregion
		
		#region IMPRIMIR PDF
		void ImprimirPDF()
		{
			try
			{
				String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				string newPath = System.IO.Path.Combine(activeDir, "Contrato "+DateTime.Now.ToString("dd-MM-yyyy"));
		        System.IO.Directory.CreateDirectory(newPath);
				
				Document doc = new Document(PageSize.LETTER, 20, 20 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contrato "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtNombreEmpleado.Text+" Contrato.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				FormatoPdf.FormatoContrato(doc, writer, this);
				doc.NewPage();
				this.foperador.InscripcionPDF(doc, writer);
				doc.Close();
				Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Contrato "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+txtNombreEmpleado.Text+" Contrato.pdf");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.foperador = null;
			}
		}
		#endregion
		
		#region EVENTOS		
		void DateFechaValueChanged(object sender, EventArgs e)
		{
			dateFechaFin.Value = dateFecha.Value.AddDays(27);
		}
		#endregion
	}
}
