using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Ruta.Complemento_Cambio_ruta
{
	public partial class FormExtraANormal : Form
	{
		#region CONSTRUCTORES
		public FormExtraANormal(Interfaz.Ruta.FormTipoRuta tipoRuta, int idruta, String nombre, String nempresa, String turnom, String tipoCobroo, int idusu)
		{
			InitializeComponent();
			this.tRuta = tipoRuta;
			this.idRutaExtra = idruta;
			this.nombreRuta = nombre;
			this.empresa = nempresa;
			this.turno = turnom;
			this.tipoCobro = tipoCobroo;
			this.idUsuario = idusu;
		}
		#endregion
				
		#region INSTANCIAS
		private Conexion_Servidor.Ruta.SQL_Ruta conn= new Conexion_Servidor.Ruta.SQL_Ruta();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.Ruta.FormTipoRuta tRuta = null;
		#endregion
		
		#region VARIABLES
		int idUsuario = 0;
		int idRutaExtra = 0;
		String nombreRuta;
		String empresa;
		String turno;
		String tipoCobro;
		
		int lunes = 0;
		int martes = 0;
		int miercoles = 0;
		int jueves = 0;
		int viernes = 0;
		int sabado = 0;
		int domingo = 0;
		#endregion
		
		#region INICIO - FIN		
		void FormExtraANormalLoad(object sender, EventArgs e)
		{
			lblIdRuta.Text = "ID: "+idRutaExtra;
			lblRuta.Text = "Nombre: "+nombreRuta;
			lblEmpresa.Text = "Empresa: "+empresa;
			lblTurno.Text = "Turno: "+turno;
			lblTipoVehicuo.Text = "T. Vehiculo: "+tipoCobro;		
			
			timeHoraInicio.Text = conn.horaInicio(idRutaExtra);			
			
			txtEmpresa.Enabled = false;			
			txtEmpresa.Text = conn.NombreCliente(empresa, tipoCobro);				
			//lblPruba.Text = conn.IDCliente(empresa, tipoCobro);
			
			txtKilometros.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);            
		}
		
		void FormExtraANormalFormClosing(object sender, FormClosingEventArgs e)
		{
			tRuta.estra_normal = false;
			tRuta.limpiarVariables();
			tRuta.dtRutaEXT.ClearSelection();
			tRuta.dtRutaNRM.ClearSelection();
		}
		#endregion
		
		#region BOTONES		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(txtKilometros.Text.Length > 0){
				DialogResult boton1 = MessageBox.Show("Desea cambiar esta ruta a Normal?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					//if(txtEmpresa.Text.Length > 0){
						dias();		
						conn.cambiar_extra_a_normal("1"+lunes+martes+miercoles+jueves+viernes+sabado+domingo, txtKilometros.Text, /*conn.IDCliente(empresa, tipoCobro),*/ timeHoraInicio.Value.ToString("HH:mm"), timeHoraFin.Value.ToString("HH:mm:ss"), idRutaExtra, idUsuario);
						this.Close();
					//}else{	
						//MessageBox.Show("Lo sentimos ocurrio un error al Relacional la empresa", "Error Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					//}				
				}
			}else{
				MessageBox.Show("Introduce el Kilometraje", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region METODOS
		public void dias(){
			if(cbLunes.Checked == true)
				lunes = 1;
			
			if(cbMartes.Checked == true)
				martes = 1;
			
			if(cbMiercoles.Checked == true)
				miercoles = 1;
					
			if(cbJueves.Checked == true)
				jueves = 1;
			
			if(cbViernes.Checked == true)
				viernes = 1;
			
			if(cbSábado.Checked == true)
				sabado = 1;
			
			if(cbDomingo.Checked == true)
				domingo = 1;
		}
		#endregion
		
	}
}
