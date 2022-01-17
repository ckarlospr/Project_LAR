using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormInicializaComb : Form
	{
		public FormInicializaComb()
		{
			InitializeComponent();
		}
		
		#region VARIABLE
		#endregion
		
		#region INSTANCIAS
		#endregion
		
		#region EVENTO LOAD
		void FormInicializaCombLoad(object sender, EventArgs e)
		{
			getCargarValidacionCampos(this);
		}
		#endregion
		
		private void getCargarValidacionCampos(FormInicializaComb formRef)
		{
			formRef.txtFolio.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void TxtFolioClick(object sender, EventArgs e)
		{
			txtFolio.SelectAll();
		}
		
		void TxtFolioEnter(object sender, EventArgs e)
		{
			txtFolio.SelectAll();
		}
		
		void CmdGeneraClick(object sender, EventArgs e)
		{
			if(txtFolio.Text!="" && txtFolio.Text!="1")
			{
				Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
			
				String consulta ="execute INICIA_COMBUSTIBLE "+ txtFolio.Text;
									
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				MessageBox.Show("Evento inicializado");
				
				this.Close();
			}
			else
			{
				MessageBox.Show("Número de fólio invalido.");
			}
		}
	}
}
