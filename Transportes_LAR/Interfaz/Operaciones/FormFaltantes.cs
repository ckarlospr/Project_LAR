using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormFaltantes : Form
	{
		public FormFaltantes(FormDatosEspecial refDatos)
		{
			InitializeComponent();
			
			refDatosEsp = refDatos;
		}
		
		#region REFERENCIAS
		public FormDatosEspecial refDatosEsp = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		String idUsuarioConf="1";
		#endregion
		
		void FormFaltantesLoad(object sender, EventArgs e)
		{
			getDatos(refDatosEsp.RUTA);
		}
		
		public void getDatos(Int64 ID)
		{
			String consulta = "select U.nombre, RE.FECHA, RE.HORA, CONF_CLIENTE, RE.CONF_FECHA, CONF_USUARIO from RUTA_ESPECIAL RE, usuario U where RE.ID_U=U.id_usuario and ID_RE="+ID;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				txtUsuarioToma.Text= 	conn.leer["nombre"].ToString();
				txtDiaToma.Text    = 	conn.leer["FECHA"].ToString().Substring(0,10);
				txtHoraToma.Text   = 	conn.leer["HORA"].ToString();
				idUsuarioConf	   = 	conn.leer["CONF_USUARIO"].ToString();
				txtAtendioConf.Text= 	conn.leer["CONF_CLIENTE"].ToString();
				txtHoraConf.Text   = 	conn.leer["CONF_FECHA"].ToString();
			}
			conn.conexion.Close();
			
			if(idUsuarioConf!="")
			{
				consulta = "select * from usuario where id_usuario="+idUsuarioConf;
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtUsuarioConf.Text=conn.leer["nombre"].ToString();
				}
				conn.conexion.Close();
			}
		}
	}
}
