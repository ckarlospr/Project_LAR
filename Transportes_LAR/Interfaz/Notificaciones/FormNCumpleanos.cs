using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Notificaciones
{
	public partial class FormNCumpleanos : Form
	{
		#region CONSTRUCTOR
		public FormNCumpleanos(string id_op, string usuario)
		{
			InitializeComponent();		
			ID_operador = id_op;
			lblUsuario.Text = usuario;			
		}
		#endregion
				
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		string ID_operador;
		#endregion
		
		#region INICIO
		void FormNCumpleanosLoad(object sender, EventArgs e)
		{
			NotificacionVista();
			BackColor = Color.Black;
			TransparencyKey = BackColor;			
		}
		#endregion
		
		#region METODOS
		private void NotificacionVista(){
			string miconsult = @" INSERT INTO NOTIFICACIONES_USUARIOS (ID_OPERADOR,ID_NOTIFICACION,TIPO,OBSERVACIONES,ESTATUS,FECHA,FECHA_NOT,HORA_NOT)VALUES("+ID_operador
				+" , NULL, 'CUMPLEAÑOS', '', '1', '"+DateTime.Now.ToString("yyyy-MM-dd")+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
			try{
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al guardar la notificacion de compleaños: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);				
			}
		}
		#endregion		
		
		#region BOTONES
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}
