using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text;
using System.Net.NetworkInformation;

namespace Transportes_LAR.Interfaz
{
	public partial class FormLogin : Form
	{
		#region VARIABLES
		public int contador=0;
		public string usuario="";
		public string id_usuario="";
		private Point mouseOffset;
		private bool isMouseDown = false;
		#endregion
		
		#region CONSTRUCTOR_DE_LA_CLASE
		public FormLogin()
		{
			InitializeComponent();
		}
		#endregion
		
		#region EVENTO_BOTONES (ACEPTAR-CANCELAR)
		void BtnIniciarClick(object sender, EventArgs e)
		{
			//MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
			Inicio();
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnChecadorClick(object sender, EventArgs e)
		{
			new Transportes_LAR.Interfaz.Lector.FormMain(true).ShowDialog();
		}
		#endregion
		
		#region EVENTO_INICIO_CIERRE_DE_VENTANA
		void FormLoginLoad(object sender, EventArgs e)
		{
			txtUsuario.Focus();
			/*try{
				System.IO.File.Delete(System.Environment.SystemDirectory.Substring(0, 3) + @"\Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Documents\LAR\Debug\Unidad.vbs");
				System.IO.File.Copy(@"X:\Sistema_LAR\Unidad.vbs",  System.Environment.SystemDirectory.Substring(0, 3) + @"\Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Documents\LAR\Debug\Unidad.vbs");
			}catch{}	
			try{
				System.Diagnostics.Process.Start("Unidad.vbs");				
			}catch{}
			try{
				System.Diagnostics.Process.Start("Llave.vbs");				
			}catch{}
			try{
				System.IO.File.Delete(System.Environment.SystemDirectory.Substring(0, 3) + @"\Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Documents\LAR\Debug\Actualizar.vbs");
				System.IO.File.Copy(@"X:\Sistema_LAR\Actualizar.vbs",  System.Environment.SystemDirectory.Substring(0, 3) + @"\Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Documents\LAR\Debug\Actualizar.vbs");
			}catch{}	*/				
			/*try{
				if(Environment.MachineName!="LINUX" && Environment.MachineName!="ACER" && Environment.MachineName!="DARIO-PC" && Environment.MachineName!="LAREQUIPO-PC")
					System.Diagnostics.Process.Start("EjecutarAdministrador.vbs");				
			}catch{}*/					
			try{
				System.IO.File.Delete(System.Environment.SystemDirectory.Substring(0, 3) + @"\Users\" + System.Windows.Forms.SystemInformation.UserName + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\Transportes_LAR.Ink");
				System.IO.File.Delete(System.Environment.SystemDirectory.Substring(0, 3) + @"\Users\" + System.Windows.Forms.SystemInformation.UserName + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\Transportes_LAR.exe");
			}catch{}
		}
		
		void FormLoginFormClosing(object sender, FormClosingEventArgs e){
			if(this.Visible==true){
				if(contador==0)
				{
					DialogResult rs2 = MessageBox.Show("¿Desea salir del sistema?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs2)
					{
						contador=1;
						/*try{
							System.Diagnostics.Process.Start("Unidad.vbs");
							System.Diagnostics.Process.Start("Actualizar.vbs");
						}catch{}*/
						try{
							System.Diagnostics.Process.Start("AccesoDirecto.vbs");
						}catch{}
						Application.Exit();	
					}
					else if(DialogResult.No==rs2)
					{
						contador=0;
						e.Cancel=true;
					}
				}
				else
				{
					try{
							System.Diagnostics.Process.Start("AccesoDirecto.vbs");
						}catch{}
						Application.Exit();	
				}
			}
		}
		#endregion
		
		#region VALIDANDO_ENTER_DENTRO_DE_LOS_CAMPOS_DE_ESCRITURA
		void TxtUsuarioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				txtContrasena.Focus();
		}
		
		void TxtContrasenaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(txtUsuario.Text!="" && txtContrasena.Text!="")
					btnIniciar.PerformClick();
	      	}
		}
		#endregion
		
		#region VALIDADOR CONTRASEÑA	
		public void ContrasenaProgressVal()
		{
			pbvalidando.Visible = true;
    		pbvalidando.Minimum = 1;
    		pbvalidando.Maximum = 100; 		
    		for (int x = 1; x <= pbvalidando.Maximum; x++)
    			{
	    			pbvalidando.Increment(x);
	    			pbvalidando.Value=x;
	   				Thread.Sleep(1);
    			}
		}
		
		public void ContrasenaProgressError()
		{
			pbvalidando.Visible = true;
    		pbvalidando.Minimum = 1;
    		pbvalidando.Maximum = 100; 		
    		for (int x = 100; x >= pbvalidando.Minimum; x--)
    			{
	    			pbvalidando.Increment(x);
	    			pbvalidando.Value=x;
	   				Thread.Sleep(1);
    			}
		}
		#endregion
		
		#region INICIO
		void Inicio()
		{
			this.id_usuario=(new Conexion_Servidor.Usuario.SQL_Usuario().getIdUsuario(txtUsuario.Text,txtContrasena.Text));
			if(txtUsuario.Text!="" && txtContrasena.Text!="")
			{
				if(new Conexion_Servidor.Usuario.SQL_Usuario().getValidacionUsuario(txtUsuario.Text,txtContrasena.Text))
				{
					//new Conexion_Servidor.Usuario.SQL_Usuario().ingreso(id_usuario);
					guardaInicio();
					this.usuario=txtUsuario.Text;
					txtUsuario.Text="";
					txtContrasena.Text="";
					ContrasenaProgressVal();
					new Interfaz.FormPrincipal(this).Show();
					this.Visible=false;
					pbvalidando.Value = pbvalidando.Minimum;
					txtUsuario.Focus();
				}
				else
				{
					ContrasenaProgressVal();
					ContrasenaProgressError();
					MessageBox.Show("El usuario o contraseña son incorrectos, verifique sus datos e ingreselos de nuevo.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else
				MessageBox.Show("Para poder iniciar la aplicación es necesario llenar los campos correspondientes.","Campos vacíos",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			txtContrasena.Text="";
		}
		#endregion
		
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private void guardaInicio(){
			try{
				NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
				String sMacAddress = string.Empty;
				foreach (NetworkInterface adapter in nics){
				    if (sMacAddress == String.Empty) {// only return MAC Address from first card 				   
				        IPInterfaceProperties properties = adapter.GetIPProperties();
				        sMacAddress = adapter.GetPhysicalAddress().ToString();
				    }
				}
				conn.getAbrirConexion("INSERT INTO INICIO_SESION VALUES ("+id_usuario+", '"+Environment.MachineName+"', '"+Environment.UserName+"', '"+sMacAddress+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}catch(Exception){	}
		}
		
		#region MOVIMIENTO - EFECTO
		void FormLoginMouseUp(object sender, MouseEventArgs e)
		{
			 if (e.Button == MouseButtons.Left) 
		        isMouseDown = false;
		}
		
		void FormLoginMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown) 
		    {
		        Point mousePos = Control.MousePosition;
		        mousePos.Offset(mouseOffset.X, mouseOffset.Y);
		        Location = mousePos;
		    }
		}
		
		void FormLoginMouseDown(object sender, MouseEventArgs e)
		{
			int xOffset;
		    int yOffset;
		
		    if (e.Button == MouseButtons.Left) 
		    {
		        xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
		        yOffset = -e.Y - SystemInformation.CaptionHeight - 
		            SystemInformation.FrameBorderSize.Height;
		        mouseOffset = new Point(xOffset, yOffset);
		        isMouseDown = true;
		    }   
		}
		
		void BtnCancelarMouseLeave(object sender, EventArgs e)
		{
			try{
			btnCancelar.BackgroundImage = new Bitmap("Cerrar.png");
			}catch{}
		}
		
		void BtnCancelarMouseEnter(object sender, EventArgs e)
		{
			try{
			btnCancelar.BackgroundImage = new Bitmap("Enter.png");
			}catch{}
		}
		
		void BtnIniciarMouseEnter(object sender, EventArgs e)
		{
			try{
			btnIniciar.BackgroundImage = new Bitmap("Entrar.png");
			}catch{}
		}
		
		void BtnIniciarMouseLeave(object sender, EventArgs e)
		{
			try{
			btnIniciar.BackgroundImage = new Bitmap("Play.png");
			}catch{}
		}
		#endregion
		
		#region SELECT TODO
		void TxtUsuarioEnter(object sender, EventArgs e)
		{
			txtUsuario.SelectAll();
		}
		
		void TxtContrasenaEnter(object sender, EventArgs e)
		{
			txtContrasena.SelectAll();
		}
		
		void TxtUsuarioClick(object sender, EventArgs e)
		{
			txtUsuario.SelectAll();
		}
		
		void TxtContrasenaClick(object sender, EventArgs e)
		{
			txtContrasena.SelectAll();
		}
		#endregion
		
	}
}
