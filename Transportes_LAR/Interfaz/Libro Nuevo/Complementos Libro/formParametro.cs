using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class formParametro : Form
	{		
		#region CONSTRUCTOR
		public formParametro(Int32 idU)
		{
			InitializeComponent();
			id_u = idU;
		}
		#endregion
		
		#region VARIABLES
		bool respuesta = false;
		Int32 id_u;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Combustible.SQL_Combustible connC = new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion
		
		#region INICIO - FIN
		void FormParametroLoad(object sender, EventArgs e)
		{			
			adaptador();
		}
		#endregion
				
		#region ADAPTADOR
		public void adaptador(){			
			try{		
				string sentencia = "select PARAMETRO1,PARAMETRO2 from PARAMETROS_GENERALES where id = 3";
				conn.getAbrirConexion(sentencia);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					txtCorreo.Text = conn.leer["PARAMETRO1"].ToString();
					txtCorreo2.Text = conn.leer["PARAMETRO2"].ToString();	
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
		}
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{	
			errorProvider1.Clear();
			try{
				if(Proceso.ValidarCampo.email_bien_escrito(txtCorreo.Text)){					
					connC.modificarParametrosCombu2(txtCorreo.Text, txtCorreo2.Text, 3, id_u);
					respuesta = true;
				}else{
					errorProvider1.SetError(txtCorreo, "Ingresa un correo corecto");						
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
	}
}
