using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormFaltantesOtros : Form
	{
		#region CONSTRUCTOR		
		public FormFaltantesOtros(formPrincipalComb refPrinc)
		{
			InitializeComponent();	
			refPrincipal = refPrinc;			
		}
		#endregion
		
		#region INSTANCIAS
		public formPrincipalComb refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Combustible.SQL_Combustible conn= new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion
		
		#region INICIO - FIN 		
		void FormFaltantesOtrosLoad(object sender, EventArgs e)
		{
			datosAutocomplete();			
			txtOperador.Text=refPrincipal.txtOperadorValidacion.Text;
			txtUnidad.Text=refPrincipal.txtUnidadValidacion.Text;			
		}
		#endregion
		
		#region BOTONE		
		void BtnGuardaClick(object sender, EventArgs e)
		{
			if(validaDatos()){
				conn.otrosFaltantes(refPrincipal.dgAutorizacionValida[0,0].Value.ToString(), cmbTipo.Text, txtOperador.Text,txtUnidad.Text, txtEmpresa.Text,txtRuta.Text, cmbSentido.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), dtpHora.Value.ToString("HH:mm"), cmbTurno.Text, txtComentarios.Text, refPrincipal.refPrincipal.idUsuario);
				
				try{
					String datos = dtpFecha.Value.ToString("dd-MM-yyy")+"\t"+txtUnidad.Text+"\t"+txtOperador.Text+"\t"+cmbTurno.Text+"\t"+txtEmpresa.Text+"\t"+cmbTipo.Text+" "+txtRuta.Text+"\t"+cmbSentido.Text+"\t"+dtpHora.Value.ToString("HH:mm")+"\tFALTA\t"+refPrincipal.refPrincipal.lblDatoUsuario.Text;
					Clipboard.Clear();
				 	Clipboard.SetDataObject(datos);
				}catch(Exception ex){
					MessageBox.Show("Error al copiar información al portapapeles"+ex.Message+". La información de guardo correctamente en la base de datos", "Error al copiar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
					
			 	
			 	this.Close();
				refPrincipal.getOtrosValidacion2();				
			}else{
				MessageBox.Show("Completa todos los datos.");
			}
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
		
		#region VALIDACION
		bool validaDatos()
		{
			bool respuesta=true;
			
			if(txtUnidad.Text=="")
				respuesta=false;
			else if (txtEmpresa.Text=="")
				respuesta=false;
			else if (cmbTipo.SelectedIndex == 1 || cmbTipo.SelectedIndex == 3 || cmbTipo.SelectedIndex == 4){
				if(txtRuta.Text=="")
					respuesta=false;			
			}else if (cmbTipo.Text=="")
				respuesta=false;
			else if (cmbSentido.Text=="")
				respuesta=false;
			else if (cmbTurno.Text=="")
				respuesta=false;
			
			return respuesta;
		}
		#endregion	
		
		#region EVENTO COMBOBOX TIPO		
		void CmbTipoSelectionChangeCommitted(object sender, EventArgs e)
		{
			if(cmbTipo.Text == "Guardia" || cmbTipo.Text == "Reconocimiento" || cmbTipo.Text == "P. Rendimiento" )
				txtComentarios.Text = "N/A";							
		}
		#endregion
		
		void FormFaltantesOtrosKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
	}
}
