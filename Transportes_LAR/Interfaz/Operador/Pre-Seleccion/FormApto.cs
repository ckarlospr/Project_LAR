using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Ink;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormApto : Form
	{		
		#region VARIABLES
		int id_usuario;
		Int64 id_CitaManejo;
		Int64 id_CitaMedica;
		Int64 ID_PREOPERADOR;
		string folio;
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES
		public FormApto(FormContratacion refprincipal, int id_usu, Int64 PREOPERADOR, Int64 CitaManejo, Int64 CitaMedica, string folio)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			id_CitaManejo = CitaManejo;
			id_CitaMedica = CitaMedica;
			this.folio = folio;
			ID_PREOPERADOR = PREOPERADOR;
		}
		#endregion
		
		#region INICIO - FIN
		void FormAptoLoad(object sender, EventArgs e)
		{
			txtMotivo.AutoCompleteCustomSource = auto.AutocompleteGeneral("select COMENTARIO from CITA_PRE_OPERADOR", "COMENTARIO");
           	txtMotivo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMotivo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			dtpFechaCita.Value = DateTime.Now.AddDays(1);
			dtpHoraCita.Text = "09:00";
		}		
		#endregion
		
		#region BOTONES	
		void BtnValidaClick(object sender, EventArgs e)
		{
			if(rbSi.Checked == true){
				if(connO.contratarCandidato(ID_PREOPERADOR, folio, "CERRADO", "CONTRATADO", dtpFechaCita.Value.ToString("yyyy-MM-dd"), dtpHoraCita.Value.ToString("HH:mm"), id_usuario)){
					if(connO.confirmarCita(id_CitaManejo, "CONTRATADO", id_usuario)){
						if(connO.confirmarCita(id_CitaMedica, "CONTRATADO", id_usuario)){
							contratacion.filtrosSolicitudes();
							contratacion.limpiarCamposAI();
							contratacion.limpiaFiltrosOperador();
							this.Close();
							MessageBox.Show("Se agendó la nueva cita del candidato para la entrega de documentos", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}else{
				bool res = false;
				
				if(rbBTsi.Checked == true){
					res = connO.noContratarCandidato(ID_PREOPERADOR, folio, "CERRADO", "BOLSA", txtMotivo.Text, id_usuario);
					res = connO.confirmarCita(id_CitaManejo, "NO CONTRATADO", id_usuario);				
					res = connO.confirmarCita(id_CitaMedica, "NO CONTRATADO", id_usuario);				
				}
				else if(rbBTno.Checked == true){
					res = connO.noContratarCandidato(ID_PREOPERADOR, folio, "CERRADO", "RECHAZADO", txtMotivo.Text, id_usuario);
					res = connO.confirmarCita(id_CitaManejo, "NO CONTRATADO", id_usuario);				
					res = connO.confirmarCita(id_CitaMedica, "NO CONTRATADO", id_usuario);					
				}			
				
				if(res){
					contratacion.filtrosSolicitudes();
					contratacion.limpiarCamposAI();
					contratacion.limpiaFiltrosOperador();
					this.Close();
					MessageBox.Show("Se rechazo correctamente al candidato", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void RbNoCheckedChanged(object sender, EventArgs e)
		{
			SiNo();
		}
		
		void RbSiCheckedChanged(object sender, EventArgs e)
		{
			SiNo();					
		}
		
		void FormAptoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		
		void RbBTsiCheckedChanged(object sender, EventArgs e)
		{	
			btnValida.Enabled = true;
			if(txtMotivo.Text.Length == 0)	
				btnValida.Enabled = false;
			if(rbBTsi.Checked == false && rbBTno.Checked == false)
				btnValida.Enabled = false;
		}
		
		void RbBTnoCheckedChanged(object sender, EventArgs e)
		{	
			btnValida.Enabled = true;
			if(txtMotivo.Text.Length == 0)	
				btnValida.Enabled = false;
			if(rbBTsi.Checked == false && rbBTno.Checked == false)
				btnValida.Enabled = false;
		}
		
		void TxtMotivoTextChanged(object sender, EventArgs e)
		{	
			btnValida.Enabled = true;
			if(txtMotivo.Text.Length == 0)	
				btnValida.Enabled = false;
			if(rbBTsi.Checked == false && rbBTno.Checked == false)
				btnValida.Enabled = false;
		}
		#endregion
		
		#region METODOS
		private void SiNo(){			
			btnValida.Enabled = true;
			if(rbNo.Checked == true){
				txtMotivo.Enabled = true;
				dtpFechaCita.Enabled = false;
				dtpHoraCita.Enabled = false;				
				pnBolsa.Enabled = true;
				rbBTsi.Checked = false;
				rbBTno.Checked = false;				
				if(txtMotivo.Text.Length == 0)	
					btnValida.Enabled = false;
				if(rbBTsi.Checked == false && rbBTno.Checked == false)
					btnValida.Enabled = false;
			}else{
				pnBolsa.Enabled = false;
				rbBTsi.Checked = false;
				rbBTno.Checked = false;
				txtMotivo.Enabled = false;
				dtpFechaCita.Enabled = true;
				dtpHoraCita.Enabled = true;	
			}
		}
		#endregion
	}
}
