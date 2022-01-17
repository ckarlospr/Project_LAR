using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{	
	public partial class FormMotivoBT : Form
	{
		#region INSTANCIAS
		FormLlamada refLlamdas;
		FormContratacion refContrataciones;
		#endregion
		
		#region CONSTRUCTORES		
		public FormMotivoBT(FormLlamada refLlamada)
		{
			InitializeComponent();
			refLlamdas = refLlamada;
		}
		
		public FormMotivoBT(FormContratacion refContratacion)
		{
			InitializeComponent();
			refContrataciones = refContratacion;
		}
		#endregion
				
		#region INICIO - FIN
		void FormMotivoBTLoad(object sender, EventArgs e)
		{
			char delimiter = ';';
			String[] datos = null;
			
			if(refLlamdas != null){
				datos = refLlamdas.cmbMotivoSinCita.Text.Split(delimiter);
				foreach(var dato in datos){
					for(int x=0; x<clbMotivos.Items.Count; x++){
						if(dato == clbMotivos.Items[x].ToString())
							clbMotivos.SetItemChecked(x, true);
					}
				}
				txtMotivo.Text = refLlamdas.cmbMotivoSinCita.Text;
				refLlamdas.flagMotivo = true;
			}else if (refContrataciones != null){
				setMotivosContratacion();
				datos = refContrataciones.cmbMotivoSinCita.Text.Split(delimiter);
				foreach(var dato in datos){
					for(int x=0; x<clbMotivos.Items.Count; x++){
						if(dato == clbMotivos.Items[x].ToString())
							clbMotivos.SetItemChecked(x, true);
					}
				}
				txtMotivo.Text = refContrataciones.cmbMotivoSinCita.Text;
			}
		}
		
		void FormMotivoBTFormClosing(object sender, FormClosingEventArgs e)
		{
			if(refLlamdas != null)
				refLlamdas.flagMotivo = false;			
		}
		#endregion
		
		#region METODOS
		private void getMotivos(){
			txtMotivo.Text = "";
			for(int x=0; x<clbMotivos.Items.Count; x++){
				if(clbMotivos.GetItemChecked(x)){
					if(txtMotivo.Text.Length == 0)
						txtMotivo.Text = clbMotivos.Items[x].ToString();
					else
						txtMotivo.Text = txtMotivo.Text +";"+clbMotivos.Items[x].ToString();
				}
			}
		}
		
		private void setMotivosContratacion(){
			clbMotivos.Items.Clear();
			clbMotivos.Items.Add("ZONA", false);
			clbMotivos.Items.Add("INFONAVIT", false);
			clbMotivos.Items.Add("EDAD", false);
			clbMotivos.Items.Add("TATUAJES", false);
			clbMotivos.Items.Add("PIERCING", false);
			clbMotivos.Items.Add("IMAGEN", false);
			clbMotivos.Items.Add("EXPERIENCIA", false);
			clbMotivos.Items.Add("LICENCIA", false);
			clbMotivos.Items.Add("NO SE RECONTRATA", false);
			clbMotivos.Items.Add("NO LE INTERESO", false);
		}
		#endregion
		
		#region EVENTOS
		void ClbMotivosSelectedIndexChanged(object sender, EventArgs e)
		{
			getMotivos();
		}
		
		void FormMotivoBTKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
				
		#region BOTONES		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(txtMotivo.Text.Length > -1){
				if(refLlamdas != null)
					refLlamdas.cmbMotivoSinCita.Text = txtMotivo.Text;
				else if(refContrataciones != null)
					refContrataciones.cmbMotivoSinCita.Text = txtMotivo.Text;
				this.Close();
			}
		}
		#endregion		
	}
}
