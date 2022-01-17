using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormDatosEspecial : Form
	{
		public FormDatosEspecial(FormPrincEspeciales refPrincEsp, Int64 id_ruta)
		{
			InitializeComponent();
			RUTA=id_ruta;
			refPrincEspecial=refPrincEsp;
		}
		
		#region REFERENCIAS
		Interfaz.Operaciones.Dato.Especial dEspcial = null;
		FormPrincEspeciales refPrincEspecial = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		private String USUARIO="";
		private String FECHA="";
		private String HORA="";
		
		public Int64 RUTA=0;
		#endregion
	
		public void getDatos()
		{
			
			dEspcial = new Conexion_Servidor.Desapacho.SQL_Operaciones().getDatosEspeciales(RUTA);
			
			if(dEspcial!=null)
			{
				USUARIO=dEspcial.usuario;
				FECHA=dEspcial.fecha;
				HORA=dEspcial.hora;
				
				txtPlanton.Text=dEspcial.planton;
				txtTelefono.Text=dEspcial.telefono;
				txtUnidades.Text=dEspcial.unidades;
				txtResponsable.Text=dEspcial.responsable;
				//txtCasetas.Text=dEspcial.casetas;
				txtObservaciones.Text=dEspcial.observaciones;
				//txtFactura.Text=dEspcial.factura;
				//txtKilometros.Text=dEspcial.kilometros;
				txtPrecio.Text=dEspcial.precio;
				txtDestino.Text=dEspcial.destino;
				txtColonia.Text=dEspcial.colonia;
				txtCruces.Text=dEspcial.cruces;
				txtDomicilio.Text=dEspcial.domicilio;
				try
				{
					txtFechaViaje.Text=dEspcial.fechaViaje.Substring(0,10);
				}
				catch
				{
					txtFechaViaje.Text=dEspcial.fechaViaje;
				}
				txtTipoUnidad.Text=dEspcial.tipoUnidad;
				try
				{
					txtFechaRegreso.Text=dEspcial.FechRegreso.Substring(0,10);
				}
				catch(Exception)
				{
					txtFechaRegreso.Text=dEspcial.FechRegreso;
				}
				txtHraRegreso.Text=dEspcial.HoraRegreso;
				txtCliente.Text=dEspcial.cliente;
				
				txtAnticipo.Text=dEspcial.anticipo;
				txtSaldo.Text=dEspcial.saldo;
				txtUsuarios.Text=dEspcial.cantUsu;
				
				lblCobro.Text=((dEspcial.opCobra=="0")?"OP. 'NO' COBRA":"OP. COBRA");
				if(lblCobro.Text=="OP. COBRA")
					lblCobro.BackColor=Color.MediumSpringGreen;										
				
				try{
					conn.getAbrirConexion(@"select (''+ds.CALLE_D+', Col. '+ds.COLONIA_D+', '+ds.CIUDAD_D+', Cruces: '+ds.CRUCES_D) as DOMICILIO, ds.REFERENCIA_S, ds.REFERENCIA_D
											from VIAJE_PROSPECTO_NUEVO vpn join DETALLE_SERVICIO ds on vpn.ID = ds.ID_COTIZACION where ID_RE ="+RUTA);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						txtdDestino.Text = conn.leer["DOMICILIO"].ToString();
						txtrefVisualS.Text = conn.leer["REFERENCIA_S"].ToString();
						txtrefVisualD.Text = conn.leer["REFERENCIA_D"].ToString();
					}
					conn.conexion.Close();	
				}catch(Exception){
					txtdDestino.Text = "Error";	
				}				
			}
		}
		
		void FormDatosEspecialLoad(object sender, EventArgs e)
		{
			if(refPrincEspecial!=null)
			{
				txtAnticipo.Visible=false;
				txtSaldo.Visible=false;
				lblCobro.Visible=true;
			}
			getDatos();
		}
		
		void CmdInformacionClick(object sender, EventArgs e)
		{
			new FormFaltantes(this).ShowDialog();
		}
	}
}
