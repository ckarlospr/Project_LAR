using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormCancelaLlamada : Form
	{
		#region VARIABLES
		int id_usuario;
		Int64 ID_PREOPERADOR;
		string folio;
		bool bandera;
		#endregion
		
		#region INSTANCIAS
		private FormContratacion contratacion = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region CONSTRUCTORES
		public FormCancelaLlamada(FormContratacion refprincipal, int id_usu, Int64 PREOPERADOR, string folio, bool flat)
		{
			InitializeComponent();
			this.contratacion = refprincipal;
			id_usuario = id_usu;
			this.folio = folio;
			ID_PREOPERADOR = PREOPERADOR;
			this.bandera = flat;
		}
		#endregion
		
		#region INICIO - FIN
		void FormCancelaLlamadaLoad(object sender, EventArgs e)
		{
			if(bandera){
				txtObservacion.AutoCompleteCustomSource = auto.AutocompleteGeneral("select OBSERVACIONES from PRE_OPERADOR_CANCELA", "OBSERVACIONES");
	           	txtObservacion.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtObservacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
			}else{
				try{
					conn.getAbrirConexion(@"SELECT * FROM PRE_OPERADOR_CANCELA WHERE FOLIO = '"+folio+"' AND ID_PREOPERADOR = "+ID_PREOPERADOR);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){					
						cmbMotivio.Text = conn.leer["MOTIVO"].ToString();
						txtObservacion.Text = conn.leer["OBSERVACIONES"].ToString();
					}
					conn.conexion.Close();	
				}catch(Exception ex){
					MessageBox.Show("Error al obtener los datos de la cancelación: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();	
				}
				cmbMotivio.Enabled = false;
				txtObservacion.Enabled = false;
				btnValida.Enabled = true;
			}
		}
		#endregion
		
		#region EVENTOS
		void FormCancelaLlamadaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}		
		
		void CmbMotivioSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbMotivio.SelectedIndex > -1)
				btnValida.Enabled = true;
			else
				btnValida.Enabled = false;
		}
		#endregion
		
		#region BOTONES	
		void BtnValidaClick(object sender, EventArgs e)
		{
			if(bandera){
				if(cmbMotivio.SelectedIndex > -1){
					if(connO.cancelaLlamda(ID_PREOPERADOR, Convert.ToInt16(folio), "LLAMADA", cmbMotivio.Text, txtObservacion.Text, id_usuario )){
						contratacion.filtrosLlamadas();
						contratacion.limpiarCamposAI();
						contratacion.limpiaFiltrosOperador();
						this.Close();
						MessageBox.Show("Se canceló correctamente la llamada del candidato al operador", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}else{
					MessageBox.Show("Selecciona el motivo de la cancelación", "Completa los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}else{
				this.Close();
			}
		}
		#endregion
	}
}
