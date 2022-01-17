using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class Foto : Form
	{		
		#region VARIABLES - INSTANCIAS
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
		#endregion
		
		#region CONSTRUCTOR
		public Foto(FormContratacion refContrata)
		{
			InitializeComponent();
            BuscarDispositivos();
		}
		#endregion
		
		
		#region INICIO - FIN
		void FotoLoad(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region METODOS
		private void BuscarDispositivos(){
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }
		
        private void CargarDispositivos(FilterInfoCollection Dispositivos){
            for (int i = 0; i < Dispositivos.Count; i++)
                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
        }
		
        private void TerminarFuenteDeVideo(){
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }
		
        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs){
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbFotoUser.Image = Imagen; //pbFotoUser es nuestro pictureBox
        }
		#endregion
		
		#region EVENTOS
		#endregion
		
		#region BOTONES
		void BtnIniciarClick(object sender, EventArgs e)
		{
			if (btnIniciar.Text == "Iniciar Camara"){
                if (ExistenDispositivos){
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnIniciar.Text = "Detener Camara";
                    cboDispositivos.Enabled = false;
                }else
                    MessageBox.Show("Error: No se encuentra dispositivo.");
            }else{
                if (FuenteDeVideo.IsRunning){
                    TerminarFuenteDeVideo();
                    btnIniciar.Text = "Iniciar Camara";
                    cboDispositivos.Enabled = true;
                }
            }
		}
		
		void BtnFotoClick(object sender, EventArgs e)
		{
        	pbFotoUser.Image.Save("Prueba.jpeg", ImageFormat.Jpeg);
		}		
		#endregion
	}
}
