using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using DPUruNet;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace Transportes_LAR.Interfaz.Lector
{
	public partial class FormMain : Form
	{
		#region VARIABLES
		bool Automatico = false;
		private const int PROBABILITY_ONE = 0x7fffffff;
        private bool reset = false;
        private Thread verifyThreadHandle;
        bool validador = false;
        String Huella = "";
        int row = 0;
        String[,] Hoja = new String[1000,3];
        String id_user = "";
        System.IO.MemoryStream ms = null;
        String diasemana = "";
        String tipo = "";
        #endregion
        
        #region INSTANCIAS
        private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		Interfaz.Lector.FormVerification verificacion = null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
        private FormMain _sender;
        
	        #region INSTANCIAS WEBCAM
	        private bool ExistenDispositivos = false;
	        private FilterInfoCollection DispositivosDeVideo;
	        private VideoCaptureDevice FuenteDeVideo = null;
	        #endregion
	        
        #endregion

        #region GET - SET
        public FormMain Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }
        #endregion
		
		#region MAIN
		public Dictionary<int, Fmd> Fmds
        {
            get { return fmds; }
            set { fmds = value; }
        }
        private Dictionary<int, Fmd> fmds = new Dictionary<int, Fmd>();
        
      	public FormMain(bool Automatic)
		{
			InitializeComponent();
			//tpConfiguracion.Parent = null;
			tpHorarios.Parent = null;
			tpConfiguracion.Parent = null;
			this.Automatico = Automatic;
			diasemana = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(refPrincipal).DiaFactura(DateTime.Now.ToShortDateString());
			AdaptadorConfigUsuario();
			AdaptadorInicio();
			BuscarDispositivos();
		}
        
		public FormMain(Interfaz.FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
			diasemana = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(refPrincipal).DiaFactura(DateTime.Now.ToShortDateString());
			AdaptadorConfigUsuario();
			AdaptadorInicio();
			BuscarDispositivos();
		}
		
		public Reader CurrentReader
        {
            get { return currentReader; }
            set
            {
                currentReader = value;
                SendMessage(Action.UpdateReaderState, value);
            }
        }
		
        private Reader currentReader;
        private FormReader_Select _readerSelection;
        
        void BtnReaderSelectClick(object sender, EventArgs e)
		{
			getSeleccion();
		}
        
        void getSeleccion()
        {
        	if(Automatico==true)
        	{
	            _readerSelection = new FormReader_Select(1);
	            _readerSelection.Sender = this;
	            _readerSelection.ShowDialog();
        	}
        	else
        	{
        		if (_readerSelection == null)
	            {
	                _readerSelection = new FormReader_Select();
	                _readerSelection.Sender = this;
	            }
	
	            _readerSelection.ShowDialog();
        	}
        }
        
        // Whether streaming or capture was chosen.	
		
        public bool streamingOn;
		private FormCapture_Stream _captureStream;
		
		void BtnStreamingClick(object sender, EventArgs e)
		{
			streamingOn = true;

            if (_captureStream == null)
            {
                _captureStream = new FormCapture_Stream();
                _captureStream.Sender = this;
            }

            _captureStream.ShowDialog();
            
            _captureStream.Dispose();
            _captureStream = null;
		}
		
		/*****************************************************************************************************************************************************/
		
		public bool CaptureFinger(ref Fid fid)
        {
            try
            {
                Constants.ResultCode result = currentReader.GetStatus();

                if ((result != Constants.ResultCode.DP_SUCCESS))
                {
                    MessageBox.Show("Get Status Error:  " + result);
                    if (CurrentReader != null)
                    {
                        CurrentReader.Dispose();
                        CurrentReader = null;
                    }
                    return false;
                }

                if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_BUSY))
                {
                    Thread.Sleep(50);
                    return true;
                }
                else if ((currentReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_NEED_CALIBRATION))
                {
                    currentReader.Calibrate();
                }
                else if ((currentReader.Status.Status != Constants.ReaderStatuses.DP_STATUS_READY))
                {
                    MessageBox.Show("Get Status:  " + currentReader.Status.Status);
                    if (CurrentReader != null)
                    {
                        CurrentReader.Dispose();
                        CurrentReader = null;
                    }
                    return false;
                }

                CaptureResult captureResult = currentReader.Capture(Constants.Formats.Fid.ANSI, Constants.CaptureProcessing.DP_IMG_PROC_DEFAULT, 5000, currentReader.Capabilities.Resolutions[0]);
                //Enrollment.CreateEnrollmentFmd(Enrollment.CreateEnrollmentFmd(Constants.Formats.Fmd.ANSI, IEnumerable);
                
                
                
                
                /*******/
                //MessageBox.Show("* "+currentReader.da+" *");

                if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    MessageBox.Show("Error:  " + captureResult.ResultCode);
                    if (CurrentReader != null)
                    {
                        CurrentReader.Dispose();
                        CurrentReader = null;
                    }
                    return false;
                }

                if (captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_CANCELED)
                {
                    return false;
                }

                if ((captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_NO_FINGER || captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_TIMED_OUT))
                {
                    return true;
                }

                if ((captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_FAKE_FINGER))
                {
                    MessageBox.Show("Quality Error:  " + captureResult.Quality);
                    return true;
                }

                fid = captureResult.Data;
                
                

                return true;
            }
            catch
            {
                MessageBox.Show("An error has occurred.");
                if (CurrentReader != null)
                {
                    CurrentReader.Dispose();
                    CurrentReader = null;
                }
                return false;
            }
        }
		
		private enum Action
        {
           UpdateReaderState 
        }

        private delegate void SendMessageCallback(Action state, object payload);
        private delegate void SendMessageVerCallback(string payload);
        private delegate void SendMessageEqualsCallback(string payload);
		
        private void SendMessage(Action state, object payload)
        {
            if(this.txtReaderSelected.InvokeRequired)
            {
                SendMessageCallback d = new SendMessageCallback(SendMessage);
                this.Invoke(d, new object[] { state, payload });
            }
            else
            {
                switch (state)
                {
                    case Action.UpdateReaderState:
                        if ((Reader)payload != null)
                        {
                            txtReaderSelected.Text = ((Reader)payload).Description.SerialNumber;
                            //btnCapture.Enabled = true;
                            btnStreaming.Enabled = true;
                            btnVerify.Enabled = true;
                            btnGuardar.Enabled = true;
                            //btnIdentify.Enabled = true;
                            //btnEnroll.Enabled = true;
                            //btnEnrollmentControl.Enabled = true;
                            if (fmds.Count > 0)
                            {
                               // btnIdentificationControl.Enabled = true;
                            }
                        }
                        else
                        {
                            txtReaderSelected.Text = String.Empty;
                            //btnCapture.Enabled = false;
                            btnStreaming.Enabled = false;
                            btnVerify.Enabled = false;
                            btnGuardar.Enabled = false;
                            //btnIdentify.Enabled = false;
                            //btnEnroll.Enabled = false;
                            //btnEnrollmentControl.Enabled = false;
                            //btnIdentificationControl.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }

            }
        }
        
        
        
		void BtnVerifyClick(object sender, EventArgs e)
		{
			Closed();
			/*if (verificacion == null)
            {
                verificacion = new FormVerification(this);
                verificacion.Sender = this;
            }
			verificacion.FormVerificationLoad(verificacion, new System.EventArgs());*/
			//verificacion.ShowDialog();
			
			reset = false;
            verifyThreadHandle = new Thread(VerifyThread);
            verifyThreadHandle.IsBackground = true;
            verifyThreadHandle.Start();
            lbl1.Image = null;
            lbl2.Image = null;
            txtMensaje.Text="";
		}
		#endregion
		
		/****************************************************************************************************************************************/
		/****************************************************************************************************************************************/
		/****************************************************************************************************************************************/
		
		#region REFERECIAS
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal refPrincipal;
		#endregion
		
		#region LOAD - CLOSING
		void FormMainLoad(object sender, EventArgs e)
		{
			lblFecha.Text = DateTime.Now.ToLongDateString();
			getSeleccion();
			datosAutocomplete();
			getUsuarios_H();
			
			#region
			try
			{
			if (_enrollmentControl == null)
            {
                /*_enrollmentControl = new DPCtlUruNet.EnrollmentControl(CurrentReader, Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);
                _enrollmentControl.BackColor = System.Drawing.SystemColors.Window;
                _enrollmentControl.Location = new System.Drawing.Point(3, 3);
                _enrollmentControl.Name = "ctlEnrollmentControl";
                _enrollmentControl.Size = new System.Drawing.Size(482, 346);
                _enrollmentControl.TabIndex = 0;*/
                //_enrollmentControl.OnCancel += new DPCtlUruNet.EnrollmentControl.CancelEnrollment(this.enrollment_OnCancel);
                _enrollmentControl.OnCaptured += new DPCtlUruNet.EnrollmentControl.FingerprintCaptured(this.enrollment_OnCaptured);
                // _enrollmentControl.OnDelete += new DPCtlUruNet.EnrollmentControl.DeleteEnrollment(this.enrollment_OnDelete);
                _enrollmentControl.OnEnroll += new DPCtlUruNet.EnrollmentControl.FinishEnrollment(this.enrollment_OnEnroll);
                //_enrollmentControl.OnStartEnroll += new DPCtlUruNet.EnrollmentControl.StartEnrollment(this.enrollment_OnStartEnroll);
            }
            else
            {
                _enrollmentControl.Reader = CurrentReader;
            }
			}catch{}

            this.Controls.Add(_enrollmentControl);
			#endregion
			
			this.WindowState = FormWindowState.Maximized;
			Closed();
			if(txtReaderSelected2.Text!="")
			{
				reset = false;
	            verifyThreadHandle = new Thread(ComparacionThread);
	            verifyThreadHandle.IsBackground = true;
	            verifyThreadHandle.Start();
			}
		}
		
		void FormMainFormClosing(object sender, FormClosingEventArgs e)
		{
			if(refPrincipal!=null)
				refPrincipal.checador = false;
		}
		
		void FormMainFormClosed(object sender, FormClosedEventArgs e)
		{
			Closed();
            //capture stream
            /*if (_sender.CurrentReader != null)
            {
                if (streamingOn)
                {
                    // Waits until reader is open and streaming is on before resetting.
                    int count = 0;
                    while (!backEnabled && count++ < 30)
                    {
                        Thread.Sleep(250);
                        Application.DoEvents();
                    }

                    reset = true;

                    // Waits until thread is unlocked before continuing.
                    count = 0;
                    while (threadHandle_lock && count++ < 100)
                    {
                        Thread.Sleep(50);
                        Application.DoEvents();
                    }
                }
                else
                {
                    reset = true;
                    _sender.CurrentReader.CancelCapture();

                    if (threadHandle != null)
                    {
                        threadHandle.Join(5000);
                    }
                }
            }

            // Disable flags in this thread.
            backEnabled = false;
            threadHandle_lock = false;*/
		}
		
		void Closed()
		{
			_sender = this;
			
			if (_sender.CurrentReader != null)
            {
                reset = true;
                _sender.CurrentReader.CancelCapture();

                if (verifyThreadHandle != null)
                {
                    verifyThreadHandle.Join(5000);
                }
            }

            txtMensaje.Text = string.Empty;
            txtInicio.Text = string.Empty;
		}
		#endregion
		
		#region AUTOCOMPLETE
		void datosAutocomplete()
		{
			txtNombre_Horario.AutoCompleteCustomSource = auto.AutoReconocimiento("select UPPER(usuario) dato from USUARIO where Estatus='1'");
			txtNombre_Horario.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtNombre_Horario.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		/***************************/
		/***** INICIA HORARIOS *****/
		/***************************/
		
		#region [ HORARIOS ]
		void TxtNombre_HorarioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				dgHorarios.ClearSelection();
				
				for(int x=0; x<dgHorarios.Rows.Count; x++)
				{
					if(txtNombre_Horario.Text==dgHorarios[1,x].Value.ToString())
					{
						txtNombreCompleto.Text=dgHorarios[2,x].Value.ToString();
						dgHorarios.Rows[x].Selected = true;
						dgHorarios.FirstDisplayedCell = dgHorarios.Rows[x].Cells[1];
						
						getDatosSeleccion(x);
					}
				}
			}
		}
			
		#region GET DATOS DG HORARIOS
		
		#region GET DATOS USUARIOS
		void getUsuarios_H()
		{
			dgHorarios.Rows.Clear();
			
			String consulta = "SELECT * FROM usuario WHERE estatus='1' order by usuario ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgHorarios.Rows.Add(conn.leer["id_usuario"].ToString(), conn.leer["usuario"].ToString().ToUpper(), conn.leer["nombre"].ToString().ToUpper()+" "+conn.leer["apellido_pat"].ToString().ToUpper()+" "+conn.leer["apellido_mat"].ToString().ToUpper());
			}
			conn.conexion.Close();
			
			getHorarios_H();
			
			dgHorarios.ClearSelection();
		}
		#endregion
		
		void getHorarios_H()
		{
			String consulta = "";
			
			for(int x=0; x<dgHorarios.Rows.Count; x++)
			{
				consulta = "SELECT * FROM HORARIO_USUARIO R, HORARIO H WHERE R.ID_HR=H.ID AND H.ESTATUS=1 AND R.ID_U="+dgHorarios[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgHorarios[3,x].Value=conn.leer["ID_HR"].ToString();
				}
				else
				{
					dgHorarios[3,x].Value="0";
				}
				conn.conexion.Close();
			}
			
			for(int x=0; x<dgHorarios.Rows.Count; x++)
			{
				if(dgHorarios[3,x].Value!="0")
				{
					consulta = "SELECT * FROM DIAS WHERE ID_H="+dgHorarios[3,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						if(conn.leer["DIA"].ToString()=="LUNES" && conn.leer["ESTATUS"].ToString()=="1")
							dgHorarios[4,x].Value = conn.leer["HR_ENTRADA"].ToString().Substring(0,5) + "-" + conn.leer["HR_SALIDA"].ToString().Substring(0,5);
						else if(conn.leer["DIA"].ToString()=="LUNES" && conn.leer["ESTATUS"].ToString()=="0")
							dgHorarios[4,x].Value = "N/A";
						
						if(conn.leer["DIA"].ToString()=="MARTES" && conn.leer["ESTATUS"].ToString()=="1")
							dgHorarios[5,x].Value = conn.leer["HR_ENTRADA"].ToString().Substring(0,5) + "-" + conn.leer["HR_SALIDA"].ToString().Substring(0,5);
						else if(conn.leer["DIA"].ToString()=="MARTES" && conn.leer["ESTATUS"].ToString()=="0")
							dgHorarios[5,x].Value = "N/A";
						
						if(conn.leer["DIA"].ToString()=="MIÉRCOLES" && conn.leer["ESTATUS"].ToString()=="1")
							dgHorarios[6,x].Value = conn.leer["HR_ENTRADA"].ToString().Substring(0,5) + "-" + conn.leer["HR_SALIDA"].ToString().Substring(0,5);
						else if(conn.leer["DIA"].ToString()=="MIÉRCOLES" && conn.leer["ESTATUS"].ToString()=="0")
							dgHorarios[6,x].Value = "N/A";
						
						if(conn.leer["DIA"].ToString()=="JUEVES" && conn.leer["ESTATUS"].ToString()=="1")
							dgHorarios[7,x].Value = conn.leer["HR_ENTRADA"].ToString().Substring(0,5) + "-" + conn.leer["HR_SALIDA"].ToString().Substring(0,5);
						else if(conn.leer["DIA"].ToString()=="JUEVES" && conn.leer["ESTATUS"].ToString()=="0")
							dgHorarios[7,x].Value = "N/A";
						
						if(conn.leer["DIA"].ToString()=="VIERNES" && conn.leer["ESTATUS"].ToString()=="1")
							dgHorarios[8,x].Value = conn.leer["HR_ENTRADA"].ToString().Substring(0,5) + "-" + conn.leer["HR_SALIDA"].ToString().Substring(0,5);
						else if(conn.leer["DIA"].ToString()=="VIERNES" && conn.leer["ESTATUS"].ToString()=="0")
							dgHorarios[8,x].Value = "N/A";
						
						if(conn.leer["DIA"].ToString()=="SÁBADO" && conn.leer["ESTATUS"].ToString()=="1")
							dgHorarios[9,x].Value = conn.leer["HR_ENTRADA"].ToString().Substring(0,5) + "-" + conn.leer["HR_SALIDA"].ToString().Substring(0,5);
						else if(conn.leer["DIA"].ToString()=="SÁBADO" && conn.leer["ESTATUS"].ToString()=="0")
							dgHorarios[9,x].Value = "N/A";
						
						if(conn.leer["DIA"].ToString()=="DOMINGO" && conn.leer["ESTATUS"].ToString()=="1")
							dgHorarios[10,x].Value = conn.leer["HR_ENTRADA"].ToString().Substring(0,5) + "-" + conn.leer["HR_SALIDA"].ToString().Substring(0,5);
						else if(conn.leer["DIA"].ToString()=="DOMINGO" && conn.leer["ESTATUS"].ToString()=="0")
							dgHorarios[10,x].Value = "N/A";
					}
					conn.conexion.Close();
				}
				else
				{
					dgHorarios[4,x].Value = "Sin registrar";
					dgHorarios[5,x].Value = "Sin registrar";
					dgHorarios[6,x].Value = "Sin registrar";
					dgHorarios[7,x].Value = "Sin registrar";
					dgHorarios[8,x].Value = "Sin registrar";
					dgHorarios[9,x].Value = "Sin registrar";
					dgHorarios[10,x].Value = "Sin registrar";
				}
			}
		}
		#endregion
		
		#region EVENTO BOTONES
		void BtnGuardar_HorariosClick(object sender, EventArgs e)
		{
			if(txtNombre_Horario.Text=="")
			{
				MessageBox.Show("Ingrese nombre.");
			}
			else if(cbLunes.Checked==false && cbMartes.Checked==false && cbMiercoles.Checked==false && cbJueves.Checked==false && cbViernes.Checked==false && cbSabado.Checked==false && cbDomingo.Checked==false)
			{
				MessageBox.Show("Elija dias laborales");
			}
			else if(dgHorarios.SelectedRows.Count==1 && dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()!="0")
			{
				modificaHorarios();
				getUsuarios_H();
				limpiaDatos();
			}
			else 
			{
				guardaHorarios();
				getUsuarios_H();
				limpiaDatos();
			}
		}
		
		void BtnNuevo_HorariosClick(object sender, EventArgs e)
		{
			getUsuarios_H();
			limpiaDatos();
		}
		
		void BtnEliminar_HorariosClick(object sender, EventArgs e)
		{
			eliminarHorarios();
			getUsuarios_H();
			limpiaDatos();
		}
		#endregion
		
		#region LIMPIA DATOS
		void limpiaDatos()
		{
			txtNombre_Horario.Text="";
			txtNombreCompleto.Text="";
			cbLunes.Checked=false;
			cbMartes.Checked=false;
			cbMiercoles.Checked=false;
			cbJueves.Checked=false;
			cbViernes.Checked=false;
			cbSabado.Checked=false;
			cbDomingo.Checked=false;
			//dgHorarios.ClearSelection();
		}
		#endregion
		
		#region CAMBIOS EN DATOS
		void guardaHorarios()
		{
			int ID_H = 0;
			
			String consulta = "INSERT INTO HORARIO VALUES ('1', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATETIME, SYSDATETIME())))";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "SELECT MAX(ID) as ID FROM HORARIO  ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				ID_H = Convert.ToInt16(conn.leer["ID"]);
			}
			conn.conexion.Close();
			
			consulta = "INSERT INTO HORARIO_USUARIO VALUES ( "+dgHorarios[0,dgHorarios.CurrentRow.Index].Value.ToString()+", "+ID_H+")";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+ID_H+", 'LUNES', '"+dtpLuE.Value.ToString("HH:mm")+"', '"+dtpLuS.Value.ToString("HH:mm")+"', '"+((cbLunes.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+ID_H+", 'MARTES', '"+dtpMaE.Value.ToString("HH:mm")+"', '"+dtpMaS.Value.ToString("HH:mm")+"', '"+((cbMartes.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+ID_H+", 'MIÉRCOLES', '"+dtpMiE.Value.ToString("HH:mm")+"', '"+dtpMiS.Value.ToString("HH:mm")+"', '"+((cbMiercoles.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+ID_H+", 'JUEVES', '"+dtpJuE.Value.ToString("HH:mm")+"', '"+dtpJuS.Value.ToString("HH:mm")+"', '"+((cbJueves.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+ID_H+", 'VIERNES', '"+dtpViE.Value.ToString("HH:mm")+"', '"+dtpViS.Value.ToString("HH:mm")+"', '"+((cbViernes.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+ID_H+", 'SÁBADO', '"+dtpSaE.Value.ToString("HH:mm")+"', '"+dtpSaS.Value.ToString("HH:mm")+"', '"+((cbSabado.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+ID_H+", 'DOMINGO', '"+dtpDoE.Value.ToString("HH:mm")+"', '"+dtpDoS.Value.ToString("HH:mm")+"', '"+((cbDomingo.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		
		void modificaHorarios()
		{
			String consulta = "EXECUTE GUARDA_DIAS "+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()+", 'LUNES', '"+dtpLuE.Value.ToString("HH:mm")+"', '"+dtpLuS.Value.ToString("HH:mm")+"', '"+((cbLunes.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()+", 'MARTES', '"+dtpMaE.Value.ToString("HH:mm")+"', '"+dtpMaS.Value.ToString("HH:mm")+"', '"+((cbMartes.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()+", 'MIÉRCOLES', '"+dtpMiE.Value.ToString("HH:mm")+"', '"+dtpMiS.Value.ToString("HH:mm")+"', '"+((cbMiercoles.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()+", 'JUEVES', '"+dtpJuE.Value.ToString("HH:mm")+"', '"+dtpJuS.Value.ToString("HH:mm")+"', '"+((cbJueves.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()+", 'VIERNES', '"+dtpViE.Value.ToString("HH:mm")+"', '"+dtpViS.Value.ToString("HH:mm")+"', '"+((cbViernes.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()+", 'SÁBADO', '"+dtpSaE.Value.ToString("HH:mm")+"', '"+dtpSaS.Value.ToString("HH:mm")+"', '"+((cbSabado.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consulta = "EXECUTE GUARDA_DIAS "+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString()+", 'DOMINGO', '"+dtpDoE.Value.ToString("HH:mm")+"', '"+dtpDoS.Value.ToString("HH:mm")+"', '"+((cbDomingo.Checked==true)?"1":"0")+"'";
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		
		void eliminarHorarios()
		{
			string consulta = "UPDATE HORARIO SET ESTATUS='0' WHERE ID="+dgHorarios[3,dgHorarios.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTOS CHECHED
		void CbLunesCheckedChanged(object sender, EventArgs e)
		{
			if(cbLunes.Checked==true)
			{
				dtpLuE.Enabled=true;
				dtpLuS.Enabled=true;
				cbLunes.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				dtpLuE.Enabled=false;
				dtpLuS.Enabled=false;
				cbLunes.BackColor=Color.Silver;
			}
		}
		
		void CbMartesCheckedChanged(object sender, EventArgs e)
		{
			if(cbMartes.Checked==true)
			{
				dtpMaE.Enabled=true;
				dtpMaS.Enabled=true;
				cbMartes.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				dtpMaE.Enabled=false;
				dtpMaS.Enabled=false;
				cbMartes.BackColor=Color.Silver;
			}
		}
		
		void CbMiercolesCheckedChanged(object sender, EventArgs e)
		{
			if(cbMiercoles.Checked==true)
			{
				dtpMiE.Enabled=true;
				dtpMiS.Enabled=true;
				cbMiercoles.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				dtpMiE.Enabled=false;
				dtpMiS.Enabled=false;
				cbMiercoles.BackColor=Color.Silver;
			}
		}
		
		void CbJuevesCheckedChanged(object sender, EventArgs e)
		{
			if(cbJueves.Checked==true)
			{
				dtpJuE.Enabled=true;
				dtpJuS.Enabled=true;
				cbJueves.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				dtpJuE.Enabled=false;
				dtpJuS.Enabled=false;
				cbJueves.BackColor=Color.Silver;
			}
		}
		
		void CbViernesCheckedChanged(object sender, EventArgs e)
		{
			if(cbViernes.Checked==true)
			{
				dtpViE.Enabled=true;
				dtpViS.Enabled=true;
				cbViernes.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				dtpViE.Enabled=false;
				dtpViS.Enabled=false;
				cbViernes.BackColor=Color.Silver;
			}
		}
		
		void CbSabadoCheckedChanged(object sender, EventArgs e)
		{
			if(cbSabado.Checked==true)
			{
				dtpSaE.Enabled=true;
				dtpSaS.Enabled=true;
				cbSabado.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				dtpSaE.Enabled=false;
				dtpSaS.Enabled=false;
				cbSabado.BackColor=Color.Silver;
			}
		}
		
		void CbDomingoCheckedChanged(object sender, EventArgs e)
		{
			if(cbDomingo.Checked==true)
			{
				dtpDoE.Enabled=true;
				dtpDoS.Enabled=true;
				cbDomingo.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				dtpDoE.Enabled=true;
				dtpDoS.Enabled=true;
				cbDomingo.BackColor=Color.Silver;
			}
		}
		#endregion
		
		#region EVENTOS DTP
		void DtpLuEValueChanged(object sender, EventArgs e)
		{
			dtpMaE.Value=dtpLuE.Value;
			dtpMiE.Value=dtpLuE.Value;
			dtpJuE.Value=dtpLuE.Value;
			dtpViE.Value=dtpLuE.Value;
			dtpSaE.Value=dtpLuE.Value;
			dtpDoE.Value=dtpLuE.Value;
		}
		
		void DtpLuSValueChanged(object sender, EventArgs e)
		{
			dtpMaS.Value=dtpLuS.Value;
			dtpMiS.Value=dtpLuS.Value;
			dtpJuS.Value=dtpLuS.Value;
			dtpViS.Value=dtpLuS.Value;
			dtpSaS.Value=dtpLuS.Value;
			dtpDoS.Value=dtpLuS.Value;
		}
		#endregion
		
		#region SELECCION EN DGHORARIOS
		void DgHorariosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				limpiaDatos();
				getDatosSeleccion(e.RowIndex);
				txtNombre_Horario.Text=dgHorarios[1,e.RowIndex].Value.ToString();
				txtNombreCompleto.Text=dgHorarios[2,e.RowIndex].Value.ToString();
			}
		}
		
		void getDatosSeleccion(int x)
		{
			String consulta = "SELECT * " +
							  "FROM DIAS " +
				              "where ESTATUS='1' and ID_H="+dgHorarios[3,x].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["DIA"].ToString()=="LUNES")
				{
					cbLunes.Checked=true;
					dtpLuE.Text = conn.leer["HR_ENTRADA"].ToString().Substring(0,5);
					dtpLuS.Text = conn.leer["HR_SALIDA"].ToString().Substring(0,5);
				}

				if(conn.leer["DIA"].ToString()=="MARTES")
				{
					cbMartes.Checked=true;
					dtpMaE.Text = conn.leer["HR_ENTRADA"].ToString().Substring(0,5);
					dtpMaS.Text = conn.leer["HR_SALIDA"].ToString().Substring(0,5);
				}
				
				if(conn.leer["DIA"].ToString()=="MIÉRCOLES")
				{
					cbMiercoles.Checked=true;
					dtpMiE.Text = conn.leer["HR_ENTRADA"].ToString().Substring(0,5);
					dtpMiS.Text = conn.leer["HR_SALIDA"].ToString().Substring(0,5);
				}
				
				if(conn.leer["DIA"].ToString()=="JUEVES")
				{
					cbJueves.Checked=true;
					dtpJuE.Text = conn.leer["HR_ENTRADA"].ToString().Substring(0,5);
					dtpJuS.Text = conn.leer["HR_SALIDA"].ToString().Substring(0,5);
				}
				
				if(conn.leer["DIA"].ToString()=="VIERNES")
				{
					cbViernes.Checked=true;
					dtpViE.Text = conn.leer["HR_ENTRADA"].ToString().Substring(0,5);
					dtpViS.Text = conn.leer["HR_SALIDA"].ToString().Substring(0,5);
				}
				
				if(conn.leer["DIA"].ToString()=="SÁBADO")
				{
					cbSabado.Checked=true;
					dtpSaE.Text = conn.leer["HR_ENTRADA"].ToString().Substring(0,5);
					dtpSaS.Text = conn.leer["HR_SALIDA"].ToString().Substring(0,5);
				}
				
				if(conn.leer["DIA"].ToString()=="DOMINGO")
				{
					cbDomingo.Checked=true;
					dtpDoE.Text = conn.leer["HR_ENTRADA"].ToString().Substring(0,5);
					dtpDoS.Text = conn.leer["HR_SALIDA"].ToString().Substring(0,5);
				}
			}
			conn.conexion.Close();
		}
		#endregion
		
		#endregion
		
		/****************************/
		/***** TERMINA HORARIOS *****/
		/****************************/
		
		#region ENROLAMIENTO
		private DPCtlUruNet.EnrollmentControl _enrollmentControl;
		
		private void enrollment_OnCaptured(DPCtlUruNet.EnrollmentControl enrollmentControl, CaptureResult captureResult, int fingerPosition)
        {
            if (enrollmentControl.Reader != null)
            {
                ShowMessage("OnCaptured:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition + ", quality " + captureResult.Quality.ToString());
            }
            else
            {
                ShowMessage("OnCaptured:  No Reader Connected, finger " + fingerPosition);
            }

            if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
            {
                if (CurrentReader != null)
                {
                    CurrentReader.Dispose();
                    CurrentReader = null;
                }

                // Disconnect reader from enrollment control.
                _enrollmentControl.Reader = null; 
                MessageBox.Show("Error:  " + captureResult.ResultCode);
                //btnCancel.Enabled = false;
            }
            else
            {
                if (pbFingerprint.Image != null)
                {
                    pbFingerprint.Image.Dispose();
                    pbFingerprint.Image = null;
                }

                foreach (Fid.Fiv fiv in captureResult.Data.Views)
                {
                    pbFingerprint.Image = CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height);
                }
            }
        }
		
		private void ShowMessage(string message)
        {
            verificacion.txtVerify.Text += message + "\r\n\r\n";
            verificacion.txtVerify.SelectionStart = verificacion.txtVerify.TextLength;
            verificacion.txtVerify.ScrollToCaret();
        }
		
		public Bitmap CreateBitmap(byte[] bytes, int width, int height)
        {
            byte[] rgbBytes = new byte[bytes.Length * 3];

            for (int i = 0; i <= bytes.Length - 1; i++)
            {
                rgbBytes[(i * 3)] = bytes[i];
                rgbBytes[(i * 3) + 1] = bytes[i];
                rgbBytes[(i * 3) + 2] = bytes[i];
            }
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            for (int i = 0; i <= bmp.Height - 1; i++)
            {
                IntPtr p = new IntPtr(data.Scan0.ToInt32() + data.Stride * i);
                System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3);
            }

            bmp.UnlockBits(data);

            return bmp;
        }
		
		private void enrollment_OnEnroll(DPCtlUruNet.EnrollmentControl enrollmentControl, DataResult<Fmd> result, int fingerPosition)
        {
            if (enrollmentControl.Reader != null)
            {
                ShowMessage("OnEnroll:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition);
            }
            else
            {
                ShowMessage("OnEnroll:  No Reader Connected, finger " + fingerPosition);
            }

            if (result != null && result.Data != null)
            {
                Fmds.Add(fingerPosition, result.Data);
            }

            //btnCancel.Enabled = false;

           // btnIdentificationControl.Enabled = true;
        }
		
		 private void enrollment_OnStartEnroll(DPCtlUruNet.EnrollmentControl enrollmentControl, Constants.ResultCode result, int fingerPosition)
        {
            if (enrollmentControl.Reader != null)
            {
                ShowMessage("OnStartEnroll:  " + enrollmentControl.Reader.Description.Name + ", finger " + fingerPosition);
            }
            else
            {
                ShowMessage("OnStartEnroll:  No Reader Connected, finger " + fingerPosition);
            }


            //btnCancel.Enabled = true;
        }
		 #endregion
		
		#region VERFICACION
		public void VerifyThread()
        {
			_sender = this;
			
            Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;
            
            result = this.CurrentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

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
            Fmd fmd3 = null;

            SendMessageVer("Coloque un dedo en el lector.");
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

                //SendMessageVer("Un dedo fue capturado.");
                lbl1.Image = imageChecador.Images[0];
                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(fid, Constants.Formats.Fmd.ANSI);
                
                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    break; 
                }

                if (count == 0)
                {
                    fmd1 = resultConversion.Data;
                    count += 1;
                    SendMessageVer("Ahora coloque el mismo en el lector.");
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
                    
                    //SendMessageVer("La comparación resultó en una puntuación de "+compareResult.Score.ToString() + " diferencias " +  (compareResult.Score < (PROBABILITY_ONE/100000) ? " (Las huellas dactilares coinciden)" : " (Las huellas dactilares no coinciden)"));
					//SendMessageVer(Fmd.SerializeXml(fmd1)+"<----[[[]]]---->*********  La comparación resultó en una puntuación de "+compareResult.Score.ToString() + " diferencias " +  (compareResult.Score < (PROBABILITY_ONE/100000) ? " (Las huellas dactilares coinciden)" : " (Las huellas dactilares no coinciden)"));
					String resultado = Fmd.SerializeXml(fmd2);
					Huella = resultado;
					Fmd recuperaFmd = Fmd.DeserializeXml(resultado);
					
					compareResult = Comparison.Compare(fmd1, 0, recuperaFmd, 0);
					
					SendMessageVer("El resultado de la comparación es de "+compareResult.Score.ToString()+ " diferencias " + (compareResult.Score < (PROBABILITY_ONE/100000) ? " (Las huellas dactilares coinciden)" : " (Las huellas dactilares no coinciden)"));
					//new Transportes_LAR.Interfaz.FormMensaje("El resultado de la comparación es de "+compareResult.Score.ToString()+ " diferencias " + (compareResult.Score < (PROBABILITY_ONE/100000) ? " (Las huellas dactilares coinciden)" : " (Las huellas dactilares no coinciden)")).ShowDialog();
					
					if(compareResult.Score < (PROBABILITY_ONE/100000))
					{
						lbl2.Image = imageChecador.Images[0];
						validador = true;
					}
					else
						lbl2.Image = imageChecador.Images[1];
					
					break;
                }
            }

            if (_sender.CurrentReader != null)
                _sender.CurrentReader.Dispose();
        }
		
		public void SendMessageVer(string payload)
        {
            if (this.txtMensaje.InvokeRequired)
            {
                SendMessageVerCallback d = new SendMessageVerCallback(SendMessageVer);
                this.Invoke(d, new object[] { payload });
            }
            else
            {
                txtMensaje.Text += payload + "\r\n\r\n";
                txtMensaje.SelectionStart = txtMensaje.TextLength;
                txtMensaje.ScrollToCaret();
            }
        }
		#endregion
		
		#region COMPARACION ACCESO
		public void ComparacionThread()
        {
			_sender = this;
			validador = false;
            Constants.ResultCode result = Constants.ResultCode.DP_DEVICE_FAILURE;
            
            result = this.CurrentReader.Open(Constants.CapturePriority.DP_PRIORITY_COOPERATIVE);

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
            SendMessageEquals("Coloque un dedo en el lector.");
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

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(fid, Constants.Formats.Fmd.ANSI);
                
                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    break; 
                }
                    fmd1 = resultConversion.Data;
					CompareResult compareResult = null;
						
					for(int x=0; x<999; x++)
					{
							if(Hoja[x,1]!=null&&Hoja[x,1]!="")
							{
								Fmd recuperaFmd = Fmd.DeserializeXml(Hoja[x,1]);
								compareResult = Comparison.Compare(fmd1, 0, recuperaFmd, 0);
								if(compareResult.Score < (PROBABILITY_ONE/100000))
								{
									SendMessageEquals("Hola Bienvenido "+Hoja[x,0]);
									//new Transportes_LAR.Interfaz.FormMensaje("Hola Bienvenido "+Hoja[x,0]).ShowDialog();
									id_user = Hoja[x,2];
									if(new Conexion_Servidor.Lector.SQL_Lector().GetTipo(id_user)==false)
									{
										DetenerWebcam();
					                	new Conexion_Servidor.Usuario.SQL_Usuario().ingreso(id_user);
					                	tipo = "ENTRADA";
									}
					                else
					                {
					                	DetenerWebcam();
					                	new Conexion_Servidor.Usuario.SQL_Usuario().salida(id_user);
					                	tipo = "SALIDA";
					                }
									validador = true;
									break;
								}
							}
					}
				if(validador==true)
					break;
            }

           if (_sender.CurrentReader != null)
                _sender.CurrentReader.Dispose();
        }
		
		public void SendMessageEquals(string payload)
        {
            if (this.txtInicio.InvokeRequired)
            {
                SendMessageEqualsCallback d = new SendMessageEqualsCallback(SendMessageEquals);
                this.Invoke(d, new object[] { payload });
            }
            else
            {
                txtInicio.Text += payload + "\r\n\r\n";
                txtInicio.SelectionStart = txtInicio.TextLength;
                txtInicio.ScrollToCaret();
            }
        }
		#endregion
		
		#region BOTONES
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(validador==true && txtNombre.Text!="")
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de guardarlas huellas?", "Las huellas son idénticas!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Transportes_LAR.Conexion_Servidor.Lector.SQL_Lector().AlmacenarHuella(dtConfigUsuario.Rows[row].Cells[0].Value.ToString(), Huella);
				}
			}
			else
				MessageBox.Show("Las huellas no son idénticas, favor de volver a intentarlo. Gracias ");
			
			AdaptadorConfigUsuario();
		}
		
		/*void BtnChecadorClick(object sender, EventArgs e)
		{
			Closed();
			reset = false;
            verifyThreadHandle = new Thread(ComparacionThread);
            verifyThreadHandle.IsBackground = true;
            verifyThreadHandle.Start();
            //txtInicio.Text="";
		}*/
		#endregion
		
		#region TIMER 
		void TimeTick(object sender, EventArgs e)
		{
			bool interruptor =  false;
			TimeChecador.Value = DateTime.Now;
			if(validador==true)
			{
				txtUsuario.Text =  new Transportes_LAR.Conexion_Servidor.Usuario.SQL_Usuario().getUsuario(id_user);
				lblNombreCompleto.Text = new Transportes_LAR.Conexion_Servidor.Usuario.SQL_Usuario().getNombreCompleto(id_user).ToUpper();
				lblHora.Text = DateTime.Now.ToString("HH:mm");
				lblTipo.Text = tipo;
				//try
				//{
				conn.getAbrirConexion("select O.Imagen from operador O, USUARIO_OPERADOR UO, USUARIO U where O.ID=UO.ID_O AND UO.ID_U=U.ID_USUARIO AND U.ID_USUARIO="+id_user);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					{
					byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
		  			ms = new System.IO.MemoryStream(imageBuffer);
		  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
					}
				//}
				//catch{}
				conn.conexion.Close();
				AdaptadorInicio();
				interruptor = true;
			}
			
			if(tabControl1.SelectedIndex==0)
				validador=false;
			
			if(interruptor==true)
			{
				Closed();
				reset = false;
	            verifyThreadHandle = new Thread(ComparacionThread);
	            verifyThreadHandle.IsBackground = true;
	            verifyThreadHandle.Start();
	           
			}
		}
		#endregion
		
		#region ADAPTADORES
		void AdaptadorConfigUsuario()
		{
			int contador = 0;
			dtConfigUsuario.Rows.Clear();
			dtConfigUsuario.ClearSelection();
			conn.getAbrirConexion("select id_usuario, usuario, huella " +
			                      "from usuario " +
			                      "where estatus='1' " +
			                      "order by usuario");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtConfigUsuario.Rows.Add();
				dtConfigUsuario.Rows[contador].Cells[0].Value = conn.leer["id_usuario"].ToString();
				dtConfigUsuario.Rows[contador].Cells[1].Value = conn.leer["usuario"].ToString().ToUpper();
				Hoja[contador, 0] = conn.leer["usuario"].ToString().ToUpper();
				Hoja[contador, 1] = conn.leer["huella"].ToString();
				Hoja[contador, 2] = conn.leer["id_usuario"].ToString();
				if(conn.leer["huella"]==null||conn.leer["huella"].ToString()=="")
				{
					dtConfigUsuario.Rows[contador].Cells[2].Style.BackColor = Color.Red;
					dtConfigUsuario.Rows[contador].Cells[2].Value = "X";
				}
				else
				{
					dtConfigUsuario.Rows[contador].Cells[2].Style.BackColor = Color.LightGreen;
					dtConfigUsuario.Rows[contador].Cells[2].Value = "✓";
				}
				++contador;
			}
			conn.conexion.Close();
		}
		
		void AdaptadorInicio()
		{
			int contador = 0;
			System.TimeSpan tiempo;
			String hora = "";
			dgInicio.Rows.Clear();
			dgInicio.ClearSelection();
			String consulta = 	"select A.ID, U.usuario, A.TIPO, A.HORA, D.HR_ENTRADA, D.HR_SALIDA " +
								"from ASISTENCIA A, usuario U, DIAS D, HORARIO H, HORARIO_USUARIO HU " +
				"where A.ID_U=U.id_usuario AND A.ID_U=HU.ID_U AND HU.ID_HR=H.ID AND H.ID=D.ID_H and D.DIA='"+diasemana.ToUpper()+"' and A.fecha='"+DateTime.Now.ToShortDateString()+"' "+
								"order by A.ID";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgInicio.Rows.Add();
				dgInicio.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dgInicio.Rows[contador].Cells[1].Value = conn.leer["usuario"].ToString().ToUpper();
				dgInicio.Rows[contador].Cells[2].Value = conn.leer["TIPO"].ToString();
				dgInicio.Rows[contador].Cells[3].Value = conn.leer["HORA"].ToString().Substring(0,8);
				dgInicio.Rows[contador].Cells[6].Value = DateTime.Now.ToShortDateString();
				if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="ENTRADA")
				{
					dgInicio.Rows[contador].Cells[4].Value = conn.leer["HR_ENTRADA"].ToString();
					hora = conn.leer["HR_ENTRADA"].ToString();
				}
				else
				{
					dgInicio.Rows[contador].Cells[4].Value = conn.leer["HR_SALIDA"].ToString();
					hora = conn.leer["HR_SALIDA"].ToString();
				}
				tiempo =  Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8)) - Convert.ToDateTime(hora);
				dgInicio.Rows[contador].Cells[5].Value = tiempo;
				
				if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="ENTRADA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))< Convert.ToDateTime(hora)))
				{
					dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.LightGreen;
				}
				else if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="ENTRADA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))> Convert.ToDateTime(hora)))
				{
					dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.Red;
				}
				else if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="SALIDA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))< Convert.ToDateTime(hora)))
				{
					dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.Red;
				}
				else if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="SALIDA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))> Convert.ToDateTime(hora)))
				{
					dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.LightGreen;
				}
				
				++contador;
			}
			conn.conexion.Close();
		}
		
		void AdaptadorInicio(DateTimePicker dtInicio, DateTimePicker dtCorte)
		{
			int contador = 0;
			System.TimeSpan tiempo;
			String hora = "";
			int condia = 0;

			dgInicio.Rows.Clear();
			dgInicio.ClearSelection();
			while(dtInicio.Value.AddDays(condia)<=dtCorte.Value)
			{
				diasemana = new Transportes_LAR.Interfaz.Facturacion.FormFacturacion(refPrincipal).DiaFactura(dtInicio.Value.AddDays(condia).ToShortDateString());
				String consulta = 	"select A.ID, U.usuario, A.TIPO, A.HORA, D.HR_ENTRADA, D.HR_SALIDA " +
									"from ASISTENCIA A, usuario U, DIAS D, HORARIO H, HORARIO_USUARIO HU " +
									"where A.ID_U=U.id_usuario AND A.ID_U=HU.ID_U AND HU.ID_HR=H.ID AND H.ID=D.ID_H and D.DIA='"+diasemana.ToUpper()+"' and A.fecha='"+dtInicio.Value.AddDays(condia).ToShortDateString()+"' "+
									"order by A.ID";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgInicio.Rows.Add();
					dgInicio.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dgInicio.Rows[contador].Cells[1].Value = conn.leer["usuario"].ToString().ToUpper();
					dgInicio.Rows[contador].Cells[2].Value = conn.leer["TIPO"].ToString();
					dgInicio.Rows[contador].Cells[3].Value = conn.leer["HORA"].ToString().Substring(0,8);
					dgInicio.Rows[contador].Cells[6].Value = dtInicio.Value.AddDays(condia).ToShortDateString();
					if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="ENTRADA")
					{
						dgInicio.Rows[contador].Cells[4].Value = conn.leer["HR_ENTRADA"].ToString();
						hora = conn.leer["HR_ENTRADA"].ToString();
					}
					else
					{
						dgInicio.Rows[contador].Cells[4].Value = conn.leer["HR_SALIDA"].ToString();
						hora = conn.leer["HR_SALIDA"].ToString();
					}
					tiempo =  Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8)) - Convert.ToDateTime(hora);
					dgInicio.Rows[contador].Cells[5].Value = tiempo;
					
					if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="ENTRADA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))< Convert.ToDateTime(hora)))
					{
						dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.LightGreen;
					}
					else if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="ENTRADA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))> Convert.ToDateTime(hora)))
					{
						dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.Red;
					}
					else if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="SALIDA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))< Convert.ToDateTime(hora)))
					{
						dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.Red;
					}
					else if(dgInicio.Rows[contador].Cells[2].Value.ToString()=="SALIDA"&&(Convert.ToDateTime(conn.leer["HORA"].ToString().Substring(0,8))> Convert.ToDateTime(hora)))
					{
						dgInicio.Rows[contador].Cells[5].Style.BackColor = Color.LightGreen;
					}
					++contador;
				}
				conn.conexion.Close();
				++condia;
			}
		}
		#endregion
		
		#region EVENTOS
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			Closed();
			lbl1.Image = null;
            lbl2.Image = null;
            txtMensaje.Text="";
            txtInicio.Text="";
            
            if(tabControl1.SelectedIndex==0)
			{
            	time.Start();
				Closed();
				if(txtReaderSelected2.Text!="")
				{
					reset = false;
		            verifyThreadHandle = new Thread(ComparacionThread);
		            verifyThreadHandle.IsBackground = true;
		            verifyThreadHandle.Start();
				}
			}
            else
            {
            	time.Stop();
            }
            
            if(tabControl1.SelectedIndex==2)
			{
				btnReportes.Enabled = false;
			}
            else
            {
            	btnReportes.Enabled = true;
            }
		}
		
		void TxtReaderSelectedTextChanged(object sender, EventArgs e)
		{
			txtReaderSelected2.Text = txtReaderSelected.Text;
		}
		
		void DtConfigUsuarioCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1 && dtConfigUsuario.Rows[e.RowIndex].Cells[1].Value != null)
			{
				txtNombre.Text = dtConfigUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
				row = e.RowIndex;
			}
		}
		#endregion
		
		void BtnReportesClick(object sender, EventArgs e)
		{
			if(tabControl1.SelectedIndex==0)
			{
				AdaptadorInicio(dtInicio, dtCorte);
				Excels.ReporteLLEGADA_SALIDA(dgInicio);
				AdaptadorInicio();
			}
			else if(tabControl1.SelectedIndex==1)
			{
				Excels.ReporteHORARIO(dgHorarios);
			}
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			String id_usuario = (new Conexion_Servidor.Usuario.SQL_Usuario().getIdUsuario(txtUsuario.Text,txtContrasena.Text));
			if(txtUsuario.Text!="" && txtContrasena.Text!="")
			{
				if(new Conexion_Servidor.Usuario.SQL_Usuario().getValidacionUsuario(txtUsuario.Text,txtContrasena.Text))
				{
					if(new Conexion_Servidor.Lector.SQL_Lector().GetTipo(id_usuario)==false)
					{
						DetenerWebcam();
	                	new Conexion_Servidor.Usuario.SQL_Usuario().ingreso(id_usuario);
	                	tipo = "ENTRADA";
					}
	                else
	                {
	                	DetenerWebcam();
	                	new Conexion_Servidor.Usuario.SQL_Usuario().salida(id_usuario);
	                	tipo = "SALIDA";
	                }
	               //try
					//{
					conn.getAbrirConexion("select O.Imagen from operador O, USUARIO_OPERADOR UO, USUARIO U where O.ID=UO.ID_O AND UO.ID_U=U.ID_USUARIO AND U.ID_USUARIO="+id_usuario);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						{
						byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
			  			ms = new System.IO.MemoryStream(imageBuffer);
			  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
						}
					//}
					//catch{}
					//finally
					//{
					conn.conexion.Close();
					//}
	                AdaptadorInicio();
				}
				else
				{
					new FormMensaje("Error en los datos").Show();
					txtUsuario.Focus();
				}
			}
			txtUsuario.Text = "";
			txtContrasena.Text = "";
			txtUsuario.Focus();
		}
		
		void TxtContrasenaKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(txtUsuario.Text!="" && txtContrasena.Text!="")
					btnAceptar.PerformClick();
	      	}
		}
		
		#region WEBCAM
		public void IniciarWebCam()
		{
			 if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    cboDispositivos.Enabled = false;
                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();
                }
               /* else
                    MessageBox.Show("Error: No se encuentra dispositivo.");*/
		}
		
		public void DetenerWebcam()
		{
			/*if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    cboDispositivos.Enabled = true;
                }*/
		}
		
		public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
                IniciarWebCam();
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            ptbWebCam.Image = Imagen; //pbFotoUser es nuestro pictureBox
        }
		#endregion
	}
}
