using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Chat
{
	public partial class Cliente : Form
	{
		#region VARIABLES        
        // La clase TcpClient proporciona métodos sencillos para conectar, enviar y recibir flujos de datos a través de una red en modo de bloqueo sincrónico.
        TcpClient cliente;
        // La clase NetworkStream proporciona métodos para enviar y recibir datos a través de sockets de Stream en modo de bloqueo
        NetworkStream streamServidor;
        // Mensaje que se envia a la pantalla del chat
        string _mensajeChat;
        #endregion
        
        #region INSTANCIAS
        Interfaz.FormPrincipal principal = null;
        #endregion
        
        #region CONSTRUCTORES
		public Cliente()
		{
			InitializeComponent();
		}
		
		public Cliente(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region BOTONES  
        // Conecta al cliente con el servidor de chat
        void BtnConectarClick(object sender, EventArgs e)
		{
        	Conectar();
		}

        // Envía un mensaje al servidor
        void BtnEnviarClick(object sender, EventArgs e)
		{
        	Enviar();
		}

        // Desconecta nuestra sesion.
        void BtnDesconectarClick(object sender, EventArgs e)
		{
        	Desconectar();
		}
        #endregion
        
        #region METODOS
        // Cicla indefinidamente el proceso de espera de mensajes por parte del servidor
        void Chat()
        {
        	try
            { 
	            while (true)
	            {
	                streamServidor = cliente.GetStream();
	                //int buffSize = 0;
	                byte[] bytes = new byte[1000];
	                //Leemos el mensaje enviado por el servidor
	                streamServidor.Read(bytes, 0, bytes.Length);
	                //Y lo enviamos a la pantalla del chat
	                _mensajeChat = Encoding.ASCII.GetString(bytes); 
	                Mensaje();
	            }
        	}
        	catch{}
        }

        // Envia el mensaje al TextBox del Chat
        private void Mensaje()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Mensaje));
            else
                txtChat.Text = txtChat.Text + Environment.NewLine + " -> " + _mensajeChat;
        }
        
        void Conectar()
        {
        	 try
            {              
                this.Text = string.Format("Cliente: {0}", txtNombre.Text);

                lblConectado.Text = "Conectando al servidor...";
                Mensaje();
                //Abrimos la conexion con el servidor
                cliente = new TcpClient(txtIP.Text, int.Parse("8888"));
                //Incializamos el stream
                streamServidor = cliente.GetStream();
                //Transformamos el string en un arreglo de bytes para poder ser enviado mediante el NetworkStream
                Byte[] datos = System.Text.Encoding.ASCII.GetBytes(txtNombre.Text + "$");
                //Enviamos los datos al servidor
                streamServidor.Write(datos, 0, datos.Length);
                streamServidor.Flush();
                //Ciclamos el proceso de escuchar respuestas del servidor, en esta caso cada que un cliente envía un mensaje.
                Thread ctThread = new Thread(Chat);
                ctThread.Start();

                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                btnEnviar.Enabled = true;
            }
            catch (Exception ex)
            {
                txtChat.Text = ex.ToString();

                if (MessageBox.Show("¿Conectar de nuevo?") == System.Windows.Forms.DialogResult.Yes)
                    BtnConectarClick(null, null);
                else
                    this.Close();
            }
        }
        
        void Desconectar()
        {
        	try
        	{
	        	if (cliente != null && cliente.Connected)
	            {
	                cliente.Close();
	                btnConectar.Enabled = true;
	                btnDesconectar.Enabled = false;
	                btnEnviar.Enabled = false;
	                txtChat.Text = "";
	            }
        	}
            catch{}
        }
        
        void Enviar()
        {
        	try
            {
                //Incializamos el NetworkStream
                streamServidor = cliente.GetStream();
                //Transformamos el string en un arreglo de bytes para poder ser enviado mediante el NetworkStream
                Byte[] datos = Encoding.ASCII.GetBytes(txtMensaje.Text + "$" + txtNombre.Text);
                //Enviamos los datos al servidor
                streamServidor.Write(datos, 0, datos.Length);
                streamServidor.Flush();
            }
            catch (Exception ex)
            {
                txtChat.Text = ex.ToString();
            }
        }
        #endregion
		
        #region INICIO - CERRADO
		void ClienteLoad(object sender, EventArgs e)
		{
			txtNombre.Text = principal.lblDatoUsuario.Text;
		}
		
		void ClienteFormClosing(object sender, FormClosingEventArgs e)
		{
			//principal.CHAT =  false;
		}
		#endregion
		
		
		void TxtMensajeKeyUp(object sender, KeyEventArgs e)
		{
			 if (e.KeyCode == Keys.Enter)
		      {
				Enviar();
			 }
		}
	}
}
