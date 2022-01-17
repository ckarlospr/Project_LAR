using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using DPUruNet;
using iTextSharp.text.pdf.qrcode;

namespace Transportes_LAR.Interfaz.Lector
{
	public partial class FormVerification : Form
	{
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Interfaz.Lector.FormMain main = null;
		private const int PROBABILITY_ONE = 0x7fffffff;

        private bool reset = false;

        private Thread verifyThreadHandle;

        private FormMain _sender;

        public FormMain Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }
        
		public FormVerification(Interfaz.Lector.FormMain main)
		{
			InitializeComponent();
			this.main = main;
		}
		
		public void VerifyThread()
        {
            Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;
            
            result = _sender.CurrentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

            if (result != Constants.ResultCode.DP_SUCCESS)
            {
                MessageBox.Show("Error:  " + result);
                if (_sender.CurrentReader != null)
                {
                    _sender.CurrentReader.Dispose();
                    _sender.CurrentReader = null;
                }
                return;
            }

            Fmd fmd1 = null;
            Fmd fmd2 = null;
            //Fmd fmd3 = null;

            SendMessage("Place a finger on the reader.");

            int count = 0;
            while (!reset)
            {
                Fid fid = null;

                if (!_sender.CaptureFinger(ref fid))
                {
                    break;
                }

                if (fid == null)
                {
                    continue;
                }

                SendMessage("A finger was captured.");
                
                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(fid, Constants.Formats.Fmd.ANSI);
                
                
                
               

                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    break; 
                }

                if (count == 0)
                {
                    fmd1 = resultConversion.Data;
                    count += 1;
                    SendMessage("Now place the same or a different finger on the reader. <---->");
                    
                    #region ++++++++++++++++++++  GUARDA MAPEO DE BITS  +++++++++++++++++++++++++++
                    /*System.IO.MemoryStream ms = new System.IO.MemoryStream();
	            	imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
	            	conn.comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
	            	conn.comando.Parameters["@foto"].Value = ms.GetBuffer();
	            	
					sentencia="INSERT INTO MAPEO VALUES (@foto)";
					
					conn.getAbrirConexion(sentencia);
		       		conn.comando.ExecuteNonQuery();
		       		conn.conexion.Close();*/
		       		#endregion
		       		
                }
                else if (count == 1)
                {
                	fmd2 = resultConversion.Data;
                    CompareResult compareResult = Comparison.Compare(fmd1, 0, fmd2, 0);
                    

                    if (compareResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                    {
                        break;
                    }
                    
                    SendMessage(Fmd.SerializeXml(fmd1)+"<----[[[]]]---->*********  Comparison resulted in a dissimilarity score of "+compareResult.Score.ToString() + (compareResult.Score < (PROBABILITY_ONE/100000) ? " (fingerprints matched)" : " (fingerprints did not match)"));
					SendMessage("Place a finger on the reader.");
					
					String resultaddo = Fmd.SerializeXml(fmd2);
					
					Fmd recuperaFmd = Fmd.DeserializeXml(resultaddo);
					
					compareResult = Comparison.Compare(fmd1, 0, recuperaFmd, 0);
					
					SendMessage(recuperaFmd.ToString()+"Resultado de comparación"+compareResult.Score.ToString() + (compareResult.Score < (PROBABILITY_ONE/100000) ? " (fingerprints matched)" : " (fingerprints did not match)"));
					break;
                }
            }

            if (_sender.CurrentReader != null)
                _sender.CurrentReader.Dispose();
        }
		
		public delegate void SendMessageCallback(string payload);

        public void SendMessage(string payload)
        {
            if (this.txtVerify.InvokeRequired)
            {
                SendMessageCallback d = new SendMessageCallback(SendMessage);
                this.Invoke(d, new object[] { payload });
            }
            else
            {
                txtVerify.Text += payload + "\r\n\r\n";
                txtVerify.SelectionStart = txtVerify.TextLength;
                txtVerify.ScrollToCaret();
            }
        }
		
		public void FormVerificationLoad(object sender, EventArgs e)
		{
			reset = false;
            verifyThreadHandle = new Thread(VerifyThread);
            verifyThreadHandle.IsBackground = true;
            verifyThreadHandle.Start();
		}
		
		void FormVerificationFormClosed(object sender, FormClosedEventArgs e)
		{
			if (_sender.CurrentReader != null)
            {
                reset = true;
                _sender.CurrentReader.CancelCapture();

                if (verifyThreadHandle != null)
                {
                    verifyThreadHandle.Join(5000);
                }
            }

            txtVerify.Text = string.Empty;
		}
	}
}
