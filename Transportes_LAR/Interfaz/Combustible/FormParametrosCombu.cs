using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormParametrosCombu : Form
	{
		#region CONSTRUCTOR
		public FormParametrosCombu(FormPruebaRendimiento refp, Int32 idU)
		{
			InitializeComponent();
			this.principal = refp;
			id_u = idU;
		}
		
		public FormParametrosCombu(FormReporteBonos refp, Int32 idU)
		{
			InitializeComponent();
			this.ReporteBonos = refp;
			id_u = idU;
		}		
		#endregion
		
		#region INSTANCIAS
		FormPruebaRendimiento principal = null;
		FormReporteBonos ReporteBonos = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Combustible.SQL_Combustible connC = new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion
		
		#region INICIO - FIN
		void FormParametrosCombuLoad(object sender, EventArgs e)
		{			
			adaptador();
		}
		
		void FormParametrosCombuFormClosing(object sender, FormClosingEventArgs e)
		{
			if(respuesta && principal != null)
				principal.limpiar();
			
			if(respuesta && ReporteBonos != null)
				ReporteBonos.adaptadorOperadorBonos();
		}
		#endregion
		
		#region VARIABLES
		bool respuesta = false;
		Int32 id_u;
		#endregion
		
		#region ADAPTADOR
		public void adaptador(){			
			try{		
				string sentencia = "select PARAMETRO1 from PARAMETROS_GENERALES where id = 1";
				conn.getAbrirConexion(sentencia);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
					nudDiasPrueba.Text = conn.leer["PARAMETRO1"].ToString();			
				conn.conexion.Close();
				
				sentencia = "select PARAMETRO1 from PARAMETROS_GENERALES where id = 2";
				conn.getAbrirConexion(sentencia);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
					nudCantidadBono.Text = conn.leer["PARAMETRO1"].ToString();			
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
		}
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{	
			try{
				if(validaGuadado()){
					connC.modificarParametrosCombu(nudDiasPrueba.Text, 1, id_u);
					connC.modificarParametrosCombu(nudCantidadBono.Text, 2, id_u);
					respuesta = true;
				}
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("Error al guardar Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
			if(respuesta){
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se actualizaron los datos");
				mensaje.Show();
			}
		}		
		#endregion
		
		#region METODOS
		private bool validaGuadado(){
			respuesta = true;
			errorProvider1.Clear();
			if(nudCantidadBono.Text.Length == 0){				
				errorProvider1.SetError(nudCantidadBono, "Ingresa la cantidad");
				respuesta = false;
			}
			if(nudDiasPrueba.Text.Length == 0){				
				errorProvider1.SetError(nudDiasPrueba, "Ingresa los días");
				respuesta = false;
			}
			return respuesta;
		}
		#endregion
		
	}
}
