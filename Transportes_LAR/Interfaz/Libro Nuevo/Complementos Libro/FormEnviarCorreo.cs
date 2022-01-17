using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Linq.Expressions;
using Transportes_LAR.Interfaz.Libro_Nuevo.Pagos;
using Transportes_LAR.Proceso;
using System.ComponentModel;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormEnviarCorreo : Form
	{
		#region VARIABLES    
        Int64 ID_RE;        
        string correoDe= "";
        string passDe = "";
        string contacto = "";
        Thread hiloEnviar = null;
		#endregion 
		
		#region INSTANCIAS		
		public FormLibroViajes Libro = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();		
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region CONSTRUCTOR
		public FormEnviarCorreo(FormLibroViajes refLibro, string correo, string evento, string cot,Int64 ID)
		{
			InitializeComponent();
			Libro = refLibro;
			ID_RE = ID;
			txtPara.Text = correo;
			txtDestino.Text = evento;
			contacto = cot;
		}
		#endregion
		
		#region INICIO - FIN
		void FormEnviarCorreoLoad(object sender, EventArgs e)
		{
			txtPara.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CORREO from RUTA_ESPECIAL", "CORREO");
           	txtPara.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPara.AutoCompleteSource = AutoCompleteSource.CustomSource;     

			txtDe.Text =  connL.obtenerParametro1(2);	
			correoDe = connL.obtenerParametro1(2);			
			passDe = connL.obtenerParametro2(2);			
		}
		
		void FormEnviarCorreoFormClosing(object sender, FormClosingEventArgs e)
		{
			Stop();
		}
		#endregion		
			
		#region BOTONES
		void BtnExaminarClick(object sender, EventArgs e)
		{
			bool respuesta = true;
			openFileDialog1.ShowDialog();
			
			for(int x = 0; x<dgAdjuntos.Rows.Count; x++){
				if(dgAdjuntos[1,x].Value.ToString() == openFileDialog1.SafeFileName)
					respuesta = false;
			}
			
			if(respuesta){
				if(openFileDialog1.SafeFileName.ToString() != "openFileDialog1"){
					dgAdjuntos.Rows.Add(openFileDialog1.FileName, openFileDialog1.SafeFileName);
		     		dgAdjuntos.ClearSelection();
				}
			}else{
				MessageBox.Show("El archivo que seleccionaste ya esta adjuntado, no puedes tener dos archivos iguales adjuntos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
				
		void BtnEnviarClick(object sender, EventArgs e)
		{
			if(txtAsunto.Text.Length > 0){				
				if(!(txtDe.Text.Trim() == "") && !(txtPara.Text.Trim() == "")){
					if(Proceso.ValidarCampo.email_bien_escrito(txtPara.Text))
						Start();				    		
					else
						MessageBox.Show("El correo destinatario esta mal escrito","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}else{
					MessageBox.Show("No puedes enviar el correo sin destinatario","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			}else{
				MessageBox.Show("No puedes enviar el correo sin asunto","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				txtAsunto.Focus();
			}			
		}		
	
		    
 		void BtnCancelarEnvioClick(object sender, EventArgs e)
		{
			Stop();
		} 
    
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region METODOS			
		private void StatusEnvio(bool status){			
			btnEnviar.Enabled = status;
			btnCancelar.Enabled = status;
			btnExaminar.Enabled = status;
			txtPara.Enabled = status;
			txtAsunto.Enabled = status;
			txtCuerpo.Enabled = status;
			lblEnviado.Visible = (!status);
			dgAdjuntos.Enabled = status;
		}
		
		private void Start(){
		  if (hiloEnviar == null){
				StatusEnvio(false);
		        hiloEnviar = new System.Threading.Thread(enviarCorreo);
		        hiloEnviar.Name = "Enviando_Correo";
		        hiloEnviar.Start();
		       	hiloEnviar.Join();
		        	if(hiloEnviar.ThreadState.ToString() == "Stopped"){
						DialogResult respuesta = MessageBox.Show("Mensaje enviado Exitosamente ¿Deseas  enviar otro correo?", "Enviado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
						if(respuesta == DialogResult.OK){
							txtCuerpo.Text = "";
							txtAsunto.Text = "";	         			
							StatusEnvio(true);
							dgAdjuntos.Rows.Clear();
							hiloEnviar = null;
						}else{
							this.Close();
						}	
					}		        
		      }
		}
		 
	    private void Stop(){
	        if (hiloEnviar != null){
	            hiloEnviar.Abort();
	            StatusEnvio(true);
	            hiloEnviar = null;
	        }
	    }
		
		public void enviarCorreo(){			
			string to = txtPara.Text;
			string from = correoDe;
			string subject = txtAsunto.Text;
			string body = txtCuerpo.Text;
			
			MailMessage message = new MailMessage(from, to, subject, body);
	 		if (dgAdjuntos.Rows.Count >-1){
				for(int x = 0; x<dgAdjuntos.Rows.Count; x++){
					 if(System.IO.File.Exists(dgAdjuntos[0,x].Value.ToString()))
					 	message.Attachments.Add(new Attachment(dgAdjuntos[0,x].Value.ToString()));	 
				}						 
            }
	 		
			//message.Body = "Aqui escribo mi código e incluyo las etiquetas HTML <img src="imagen.jpg">... etc"  
		//	message.BodyFormat = MailFormat.Html
				
			SmtpClient smtpclient = new SmtpClient("mail.lar.com.mx");
			smtpclient.Port = 587;
			smtpclient.UseDefaultCredentials = false;
			smtpclient.Credentials = new System.Net.NetworkCredential(correoDe, passDe);
			smtpclient.EnableSsl = false;
         	message.Priority = MailPriority.High;
         	message.IsBodyHtml = false;         	
         	try{
         		smtpclient.Send(message);
         	}catch(Exception ex){
         		MessageBox.Show("Mensaje no se envio : "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         		Stop();
         	}
		}		
		#endregion					
		
		#region EVNTOS
		void DgAdjuntosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 2 && e.RowIndex > -1){
				dgAdjuntos.Rows.RemoveAt(e.RowIndex);
				dgAdjuntos.ClearSelection();
			}
		}
		#endregion		
	}
}
