using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormJustifica : Form
	{
		public FormJustifica(formPrincipalComb refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		
		#region VARIABLES
		#endregion
		
		#region INSTANCIAS
		formPrincipalComb refPrincipal;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormJustificaLoad(object sender, EventArgs e)
		{
			txtRazon.AutoCompleteCustomSource = auto.AutoReconocimiento("SELECT CONCEPTO dato FROM REPORTE_CARGAS");
			txtRazon.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtRazon.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdGuardaClick(object sender, EventArgs e)
		{
			if(txtRazon.Text=="")
			{
				MessageBox.Show("Ingrese la razon por la cual no cargo combustible");
			}
			else
			{
				guardaDatos();
				refPrincipal.getHistorialAut();
				this.Close();
			}
		}
		#endregion
		
		#region EVENTO GUARDA DATOS
		void guardaDatos()
		{
			String consulta ="INSERT INTO REPORTE_CARGAS VALUES ('"+refPrincipal.refPrincipal.idUsuario+"',  '"+refPrincipal.dgHistorial[0,refPrincipal.dgHistorial.CurrentRow.Index].Value.ToString()+"','"+refPrincipal.dtpFechaHistorial.Value.ToString("dd/MM/yyyy")+"' ,'"+txtRazon.Text+"' ,'"+txtComentario.Text+"' );";
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();	
		}
		#endregion
	}
}
