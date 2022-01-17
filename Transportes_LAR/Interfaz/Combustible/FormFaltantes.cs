using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormFaltantes : Form
	{
		public FormFaltantes(formPrincipalComb refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		
		#region INSTANCIAS
		public formPrincipalComb refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormFaltantesLoad(object sender, EventArgs e)
		{
			datosAutocomplete();
			
			txtOperador.Text=refPrincipal.txtOperadorValidacion.Text;
			txtUnidad.Text=refPrincipal.txtUnidadValidacion.Text;
			cmbTipo.Text="Completo";
			cmbTurno.Text="Mañana";
		}
		#endregion
		
		#region AUTOCOMPLETE
		void datosAutocomplete()
		{
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtUnidad.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtEmpresa.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from ORDEN_EMPRESAS");
			txtEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtRuta.AutoCompleteCustomSource = auto.AutoReconocimiento("select R.Nombre dato from Cliente C, RUTA R , ORDEN_EMPRESAS O where O.ID=C.ID_ORDEN and C.ID=R.IdSubEmpresa and (R.TIPO='NRM' or R.TIPO='DIF' or R.TIPO='VL' or R.TIPO='RI') and R.Dia!='10000000' and R.Dia!='1000000' group by R.Nombre order by R.NOMBRE ");
			txtRuta.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtRuta.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion

		#region EVENTO BOTON
		void BtnGuardaClick(object sender, EventArgs e)
		{
			if(validaDatos()){
				String consulta = "INSERT INTO VIAJES_FALTANTES VALUES ('"+refPrincipal.dgAutorizacionValida[0,0].Value.ToString()+"', '"+txtOperador.Text+"', '"+txtUnidad.Text+"', '"+txtEmpresa.Text+"', '"+txtRuta.Text+"', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '"+dtpHora.Value.ToString("HH:mm")+"', '"+cmbTurno.Text+"', '"+cmbTipo.Text+"', '1', '"+refPrincipal.refPrincipal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())))";
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				String datos = dtpFecha.Value.ToString("dd-MM-yyy")+"\t"+txtUnidad.Text+"\t"+txtOperador.Text+"\t"+cmbTurno.Text+"\t"+txtEmpresa.Text+"\t"+txtRuta.Text+"\t"+cmbTipo.Text+"\t"+dtpHora.Value.ToString("HH:mm")+"\tFALTA\t"+refPrincipal.refPrincipal.lblDatoUsuario.Text;
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
				
				this.Close();
			}else{
				MessageBox.Show("Completa todos los datos.");
			}
		}
		#endregion
		
		#region VALIDACION
		bool validaDatos()
		{
			bool respuesta=true;
			
			if(txtUnidad.Text=="")
				respuesta=false;
			else if (txtEmpresa.Text=="")
				respuesta=false;
			else if (txtRuta.Text=="")
				respuesta=false;
			
			return respuesta;
		}
		#endregion
		
		void FormFaltantesKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
	}
}
