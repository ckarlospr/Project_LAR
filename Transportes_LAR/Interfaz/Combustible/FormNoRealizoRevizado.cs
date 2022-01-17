using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormNoRealizoRevizado : Form
	{
		#region CONSTRUCTORES
		public FormNoRealizoRevizado(FormValidacionOperaciones formValidacion, String idNoRealizo)
		{
			InitializeComponent();
			refPrincipal = formValidacion;
			idNR = idNoRealizo;
		}
		#endregion
		
		#region INSTANCIAS
		public FormValidacionOperaciones refPrincipal;		
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Combustible.SQL_Combustible conn= new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion	

		#region VARIABLES
		String idNR = "";
		//String tipo = "";
		#endregion
		
		#region INICIO - FIN
		void FormNoRealizoRevizadoLoad(object sender, EventArgs e)
		{
			label1.Text = "ID :"+idNR;
			txtComentarios.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT COMENTARIO FROM REVISION_VIAJES", "COMENTARIO");
			txtComentarios.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtComentarios.AutoCompleteSource = AutoCompleteSource.CustomSource;		
		}
		
		void FormNoRealizoRevizadoFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.noRealizoRevizado = false;
			refPrincipal.dgViajesValidados.ClearSelection();
		}
		#endregion		
		
		#region BOTONES		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			try{
				//if (tipo.Length >0)
				//{
					conn.revizaNoRealizada(idNR, txtComentarios.Text, refPrincipal.refPrincipal.idUsuario );
					this.Close();
					refPrincipal.filtros1();
				//}
				//else{
					//conn.revizaOtrosNoRealizada(idNR, txtComentarios.Text, refPrincipal.refPrincipal.idUsuario, tipo );
					//this.Close();
					//refPrincipal.otros();
				//}
			}catch(Exception ex){
                MessageBox.Show("Ocurrió un error :"+ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();			
		}
		#endregion		
	}
}
