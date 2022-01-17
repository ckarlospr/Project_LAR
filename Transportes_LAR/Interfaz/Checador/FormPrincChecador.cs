using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Checador
{
	public partial class FormPrincChecador : Form
	{
		public FormPrincChecador(Interfaz.FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		Interfaz.FormPrincipal refPrincipal;
		#endregion
		
		#region INSTANCAIS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region EVENTO LOAD
		void FormPrincChecadorLoad(object sender, EventArgs e)
		{
			getDatos();
			
			txtBusqueda.AutoCompleteCustomSource = auto.AutoReconocimiento("select usuario AS dato from usuario");
			txtBusqueda.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUsuario.AutoCompleteCustomSource = auto.AutoReconocimiento("select usuario AS dato from usuario");
			txtUsuario.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUsuario.Focus();
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			dgDatos.Rows.Clear();
			String consulta = 	"select A.ID, UPPER(U.nombre+' '+U.apellido_pat+' '+U.apellido_mat) as NOMBRE, A.FECHA, A.TIPO, A.HORA " +
				"from ASISTENCIA A, usuario U where A.ID_U=U.id_usuario and U.nombre LIKE '%"+txtBusqueda.Text+"%' and A.FECHA BETWEEN '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' order by A.ID";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString().ToUpper(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["TIPO"].ToString(), conn.leer["HORA"].ToString().Substring(0,8));
			}
			conn.conexion.Close();
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			dtpFin.Value=dtpInicio.Value.AddDays(7);
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion
		
		#region
		void TxtBusquedaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				getDatos();
			}
		}
		#endregion
		
		#region CHECADA
		void TxtUsuarioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtContra.SelectAll();
			}
		}
		
		void TxtUsuarioLeave(object sender, EventArgs e)
		{
			txtContra.SelectAll();
		}
		
		void TxtContraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String id_usuario = (new Conexion_Servidor.Usuario.SQL_Usuario().getIdUsuario(txtUsuario.Text,txtContra.Text));
			
				if(id_usuario=="")
				{
					new FormMensaje("Error en los datos").Show();
					txtContra.SelectAll();
				}
				else
				{
					if(getEntrada())
					{
						cmdSalida.Enabled=true;
						cmdSalida.Focus();
					}
					else
					{
						cmdEntrada.Enabled=true;
						cmdEntrada.Focus();
					}
				}
			}
		}
		
		void TxtContraLeave(object sender, EventArgs e)
		{
			String id_usuario = (new Conexion_Servidor.Usuario.SQL_Usuario().getIdUsuario(txtUsuario.Text,txtContra.Text));
			
			if(id_usuario=="")
			{
				new FormMensaje("Error en los datos").Show();
				txtContra.SelectAll();
			}
			else
			{
				if(getEntrada())
				{
					cmdSalida.Enabled=true;
					cmdSalida.Focus();
				}
				else
				{
					cmdEntrada.Enabled=true;
					cmdEntrada.Focus();				
				}	
			}
		}
		#endregion
		
		#region REVISA ENTRADA O SALIDA
		bool getEntrada()
		{
			bool respuesta = false;
			String id_usuario = (new Conexion_Servidor.Usuario.SQL_Usuario().getIdUsuario(txtUsuario.Text,txtContra.Text));
			
			String consulta = "select * from ASISTENCIA where ID_U ='"+id_usuario+"' and tipo='ENTRADA' and FECHA=(SELECT CONVERT (DATE, SYSDATETIME()))";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				respuesta=true;
			}
			conn.conexion.Close();
			
			return respuesta;
		}
		#endregion
		
		#region EVENTOS DE BOTONES
		void CmdEntradaClick(object sender, EventArgs e)
		{
			String id_usuario = (new Conexion_Servidor.Usuario.SQL_Usuario().getIdUsuario(txtUsuario.Text,txtContra.Text));
			if(txtUsuario.Text!="" && txtContra.Text!="")
			{
				if(new Conexion_Servidor.Usuario.SQL_Usuario().getValidacionUsuario(txtUsuario.Text,txtContra.Text))
				{
					new Conexion_Servidor.Usuario.SQL_Usuario().ingreso(id_usuario);
				}
				else
				{
					new FormMensaje("Error en los datos").Show();
					cmdEntrada.Enabled=false;
					txtUsuario.Focus();
				}
			}
			
			dtpInicio.Value=DateTime.Now;
			cmdEntrada.Enabled=false;
			txtUsuario.Focus();
			limpia();
		}
		
		void CmdSalidaClick(object sender, EventArgs e)
		{
			String id_usuario = (new Conexion_Servidor.Usuario.SQL_Usuario().getIdUsuario(txtUsuario.Text,txtContra.Text));
			new Conexion_Servidor.Usuario.SQL_Usuario().salida(id_usuario.ToString());
			dtpInicio.Value=DateTime.Now;
			cmdSalida.Enabled=false;
			txtUsuario.Focus();
			limpia();
		}
		#endregion
		
		void limpia()
		{
			txtContra.Text="";
			txtUsuario.Text="";
		}
		
		void TxtUsuarioEnter(object sender, EventArgs e)
		{
			txtUsuario.SelectAll();
		}
		
		void TxtContraEnter(object sender, EventArgs e)
		{
			txtContra.SelectAll();
		}
		
		void BtnChecarClick(object sender, EventArgs e)
		{
			/*byte[] a = new byte[1632]; 
			Template.Serialize(ref a);
			string basestring = Convert.ToBase64String(a);
			MessageBox.Show(basestring);*/
		}
	}
}
