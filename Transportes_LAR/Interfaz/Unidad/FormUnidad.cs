using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Unidad
{
	public partial class FormUnidad : Form
	{
		private Interfaz.Unidad.FormEquipamiento formEquipamiento=null;
		public List<Interfaz.Unidad.Dato.Equipamiento> listEquipamiento=null;
		private Interfaz.FormPrincipal principal=null;
		
		public  string idUnidad="";
		public  bool equipamiento=false;
		public  bool fotosabierto=false;
		public  bool guardar=true;
		int id_usuario = 0;
		private Interfaz.Unidad.FormBusquedaUnidad formBusquedaUnidad=null;
		
		#region SOBRECARGA_DE_CONSTRUCTOR
		public FormUnidad(Interfaz.FormPrincipal principal, int id_usu){
			InitializeComponent();
			this.principal=principal;
			id_usuario = id_usu;
		}
		
		public FormUnidad(Interfaz.Unidad.FormBusquedaUnidad formBusquedaUnidad, int id_usu){
			InitializeComponent();
			this.formBusquedaUnidad=formBusquedaUnidad;
			id_usuario = id_usu;
		}
		
		public FormUnidad(Interfaz.Unidad.FormBusquedaUnidad formBusquedaUnidad, string idUnidad, int id_usu){
			InitializeComponent();
			this.idUnidad=idUnidad;
			this.formBusquedaUnidad=formBusquedaUnidad;
			id_usuario = id_usu;
		}
		#endregion
		
		#region EVENTO ( LOAD - CLOSING )
		void FormUnidadLoad(object sender, EventArgs e)
		{
			cargarValidacionCampos(this);
			if(idUnidad==""){
				this.tabControl1.TabPages.Remove(this.tabPageFotos);
			}else{
				this.guardar=false;
				getSelectUnidad();
				btnGuardarNuevo.Text="Modificar";
				this.listEquipamiento=new Conexion_Servidor.Unidad.SQL_Equipamiento().getEquipamientoUnidad(idUnidad);
			}
			this.MdiParent=principal;
		}
		
		void FormUnidadFormClosing(object sender, FormClosingEventArgs e)
		{
			if(principal==null)
			{
				formBusquedaUnidad.unidad=false;
			}
			else
			{
				principal.unidad=false;
			}
			//formBusquedaUnidad.consultaLista();
		}
		#endregion
		
		#region VALIDACIONES_DE_CAMPO
		void cargarValidacionCampos(FormUnidad fu){
			fu.txtAno.KeyPress 					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			fu.txtCapacidad.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			fu.txtNumAsiento.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			fu.txtMarcaCaja.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			fu.txtMarca.KeyPress 				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			fu.txtMarccaDiferencial.KeyPress 	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			fu.txtModelo.KeyPress 				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
			fu.txtModeloCaja.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
			fu.txtModeloMotor.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
			fu.txtNSerieMotor.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			fu.txtNumSerie.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			fu.txtNumUnidad.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
			fu.txtPasoDiferencial.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
			fu.txtPerimetroLlanta.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			fu.txtPlacaEstatal.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			fu.txtPlacaFederal.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			fu.txtPotencia.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			fu.txtRendimiento.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			fu.txtTipoLlanta.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			fu.txtTorque.KeyPress 				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			fu.txtURelacionCaja.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			fu.txtPropietario.KeyPress 			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);	
		}
		
		#endregion
		
		#region ToolEQUIPAMIENTO
		void ToolEquipamientoClick(object sender, EventArgs e){
			if(equipamiento){
				if(formEquipamiento.WindowState==FormWindowState.Minimized)
					formEquipamiento.WindowState = FormWindowState.Normal;
				else
					formEquipamiento.BringToFront();
			}else{
				this.formEquipamiento=new Transportes_LAR.Interfaz.Unidad.FormEquipamiento(this,idUnidad);
				formEquipamiento.Show();
				equipamiento=true;
			}
		}
		#endregion
	
		#region EVENTO_BOTON ( AGERGAR <> MODIFICAR - CANCELAR )
		void BtnGuardarNuevoClick(object sender, EventArgs e){
			error.SetError(this.txtNumUnidad,""); 
			if(new Interfaz.Unidad.Operacion(this).getValidarCampo()){
				MessageBox.Show("Para poder registrar un nuevo vehículo es necesario llenar todos los campos con los datos correspondientes","Agregar vehículo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}else{
				if(new Conexion_Servidor.Unidad.SQL_Unidad().getNumUnidad(txtNumUnidad.Text) && btnGuardarNuevo.Text=="Agregar" ){
					MessageBox.Show("El vehículo no puede ser registrado debido a que el número de unidad ya se encuentra registrado","Agregar vehículo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
					error.SetError(this.txtNumUnidad,"El numero de unidad ya existe"); 
				}else{
					if(btnGuardarNuevo.Text!="Agregar"){
						if(MessageBox.Show("¿Desea modificar el vehículo?","Modificar vehículo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
							getInsertUpdate();
							formBusquedaUnidad.unidad=false;
							this.Close();
						}
					}else{
						getInsertUpdate();
					}
				}
			}
		}
		void BtnCancelarNuevoClick(object sender, EventArgs e){
			if(principal==null)
			{
				formBusquedaUnidad.unidad=false;
			}
			else
			{
				principal.unidad=false;
			}
			this.Close();
		}
		#endregion
		
		#region VEHÍCULO( INSERTAR - MODIFICAR )
		private void getInsertUpdate()
		{
			getInsertUnidad();
			idUnidad=(idUnidad=="")?new Conexion_Servidor.Unidad.SQL_Unidad().getId(txtNumUnidad.Text) : idUnidad;
			string mensaje=(btnGuardarNuevo.Text=="Agregar")?"Vehículo almacenado exitosamente":"Vehículo modificado exitosamente";
			if(idUnidad=="")
			{
				if(MessageBox.Show("¿Desea agregar las imágenes de la unidad en este momento?","Agregar imagenes de la unidad",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					new Interfaz.Unidad.FormFotos(this).Show();
					new Interfaz.FormMensaje(mensaje).Show();	
				}else{
					new Interfaz.Unidad.Operacion(this).getLimpiarCampo();
					new Interfaz.FormMensaje(mensaje).Show();	
				}
			}else{
				new Interfaz.Unidad.Operacion(this).getLimpiarCampo();
				new Interfaz.FormMensaje(mensaje).Show();	
			}
			new Conexion_Servidor.Unidad.SQL_Equipamiento().getSentenciaEquipamiento("delete from EQUIPAMENTO where ID_Unidad="+idUnidad);
			new Thread(new ThreadStart(getInsertEquipamiento)).Start();
		}
		#endregion
		
		#region INSERTAR_OBTENER DATOS DE UNIDAD
		private void getInsertUnidad(){
			string tipoUnidad=		(rbTipoCamion.Checked==true)?"Camión":((rbTipoCamioneta.Checked==true)?"Camioneta":"Utilitario");
			string tipoServicio=	(rbForaneo.Checked==true)?"Foraneo":((rbLocal.Checked==true)?"Local":"Trabajo");
			
			
			new Conexion_Servidor.Unidad.SQL_Unidad().getInsertUnidad(  idUnidad,
		                            								  	txtNumUnidad.Text,
		                            									txtPlacaEstatal.Text,
											                            txtPlacaFederal.Text,
											                            tipoUnidad,
											                            tipoServicio,
											                            txtPropietario.Text,
											                            txtMarca.Text,
											                            txtModelo.Text,
											                            txtNumSerie.Text,
											                            txtAno.Text,
											                            txtMotor.Text,
											                            txtModeloMotor.Text,
											                            txtNSerieMotor.Text,
											                            txtMarccaDiferencial.Text,
											                            txtPasoDiferencial.Text,
											                            txtTipoLlanta.Text,
											                            txtPerimetroLlanta.Text,
											                            txtPotencia.Text,
											                            txtMarcaCaja.Text,
											                            txtModeloCaja.Text,
											                            txtURelacionCaja.Text,
											                            txtTorque.Text,
											                            txtCapacidad.Text,
											                            txtRendimiento.Text,
											                            txtNumAsiento.Text,
											                            id_usuario
											                         );
			
		}
		
		private void getSelectUnidad(){
			new Conexion_Servidor.Unidad.SQL_Unidad().getSelectUnidad(idUnidad,
		                            									txtNumUnidad,
		                           	 									txtPlacaEstatal,
		                            									txtPlacaFederal,
		                            									rbTipoCamioneta,
		                            									rbLocal,
		                            									txtPropietario,
		                            									txtMarca,
											                            txtModelo,
											                            txtAno,
											                            txtNumSerie,
											                            txtMotor,
											                            txtModeloMotor,
											                            txtNSerieMotor,
											                            txtMarccaDiferencial,
											                            txtPasoDiferencial,
											                            txtTipoLlanta,
											                            txtPerimetroLlanta,
											                            txtPotencia,
											                            txtMarcaCaja,
											                            txtModeloCaja,
											                            txtURelacionCaja,
											                            txtTorque,
											                            txtCapacidad,
											                            txtRendimiento,
											                            txtNumAsiento
											                          );
		}
		#endregion
		
		#region INVOCACION_DE_LIMPIEZA
		public void limpianuevo(){	
			new Interfaz.Unidad.Operacion(this).getLimpiarCampo();
		}
		#endregion
		
		#region CAMBIO_DE_INDICE_EN_EL_TABCONTROL
		void TabControl1SelectedIndexChanged(object sender, EventArgs e){
			if(tabControl1.SelectedTab.Name=="tabPageFotos"){
				tabControl1.SelectTab(0);
				if(!fotosabierto)
				new Interfaz.Unidad.FormFotos(this).Show();
			}
		}
		#endregion
		
		#region INSERTAR_EQUIPAMIENTO
		private void getInsertEquipamiento(){
			getSentenciaEquipamiento(0);
		}
		
		private object getSentenciaEquipamiento(int contador){
			if(listEquipamiento==null)
				return null;
			if(listEquipamiento.Count<=0)
				return null;
			new Conexion_Servidor.Unidad.SQL_Equipamiento().getSentenciaEquipamiento("insert into EQUIPAMENTO (ID_Unidad,ID_Categoria,Descripcion,Cantidad) values ("+idUnidad+","+listEquipamiento[contador].idCategoria+",'"+listEquipamiento[contador].descripcion+"',"+listEquipamiento[contador].cantidad+")");
			return (contador<listEquipamiento.Count-1)?getSentenciaEquipamiento(++contador):null;
		}
		#endregion
		
	}
}
