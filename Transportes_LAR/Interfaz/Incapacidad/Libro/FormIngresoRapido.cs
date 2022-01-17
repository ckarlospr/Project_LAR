using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormIngresoRapido : Form
	{
		public FormIngresoRapido()
		{
			InitializeComponent();
		}
		
		#region VARIABLES
		String fecha = "";
		Int64 ID_U;
		
		String NumHoraPlanton="00";
		String NumMinPlanton="00";
		
		bool GUARDA = false;
		#endregion
		
		#region REFERENCIAS
		Interfaz.Operaciones.FormPrincEspeciales refPrincEsp = null;
		#endregion
		
		#region EVENTO LOAD
		void FormIngresoRapidoLoad(object sender, EventArgs e)
		{
			getCargarValidacionCampos(this);
			dtFechaRegreso.Value=DateTime.Now;
		}
		#endregion
		
		#region VALIDACIONES
		private void getCargarValidacionCampos(FormIngresoRapido formIngreso)
		{
			formIngreso.cmbUnidades.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			formIngreso.txtPagoOperador.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formIngreso.txtAnticipos.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formIngreso.txtPrecio.KeyPress 		  	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formIngreso.NumKms.Text 				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		public bool camposVacios()
		{
			bool respuesta = true;
			
			if(txtDestino.Text=="")
			{
				MessageBox.Show("Ingrese destino");
				respuesta = false;
			}
			else if(txtResponsable.Text=="")
			{
				MessageBox.Show("Ingrese responsable");
				respuesta = false;
			}
			else if(txtCliente.Text=="")
			{
				MessageBox.Show("Ingrese cliente");
				respuesta = false;
			}
			else if(txtDomicilio.Text=="")
			{
				MessageBox.Show("Ingrese domicilio");
				respuesta = false;
			}
			else if(txtTelefono.Text=="")
			{
				MessageBox.Show("Ingrese telefono");
				respuesta = false;
			}
			
			return respuesta;
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(camposVacios())
			{
				new FormAsignOperadores(this).ShowDialog();
				
				if(GUARDA==true)
				{
					
				}
			}
		}
		
		void CmdModificarClick(object sender, EventArgs e)
		{
			
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			
		}
		
		void CmdUsuariosClick(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region EVENTO FECHA
		void DtFechaValueChanged(object sender, EventArgs e)
		{
			dtFechaRegreso.Value=Convert.ToDateTime(dtFecha.Value.ToString("dd-MM-yyyy"));
		}
		#endregion
		
		#region
		void NumHoraServicioTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumHoraServicio.Text))>59)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton = "00";
				}
				else
				{
					cambiaPlanton();
				}
			}
			catch(Exception)
			{
				NumHoraPlanton = "00";
			}
		}
		
		void NumMinServicioTextChanged(object sender, EventArgs e)
		{
			try
			{
				if((Convert.ToInt32(NumMinServicio.Text))>59)
				{
					MessageBox.Show("El Número ingresado es mayor al permitido... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Error);
					NumHoraPlanton = "00";
				}
				else
				{
					cambiaPlanton();
				}
			}
			catch(Exception)
			{
				NumHoraPlanton = "00";
			}
		}
			
		public void cambiaPlanton()
		{
			if((Convert.ToInt32(NumMinServicio.Text))>29)
			{
				NumHoraPlanton=NumHoraServicio.Text;
				NumMinPlanton=(((Convert.ToInt32(NumMinServicio.Text)-30)<10)?"0"+(Convert.ToInt32(NumMinServicio.Text)-30).ToString():(Convert.ToInt32(NumMinServicio.Text)-30).ToString());
			}
			else
			{
				if((Convert.ToInt32(NumHoraServicio.Text)-1)>0)
				{
					NumHoraPlanton=(((Convert.ToInt32(NumHoraServicio.Text)-1)<10)?"0"+(Convert.ToInt32(NumHoraServicio.Text)-1):(Convert.ToInt32(NumHoraServicio.Text)-1).ToString());
					//if()
					NumMinPlanton=(60+(Convert.ToInt32(NumMinServicio.Text)-30)).ToString();
				}
				else
				{
					NumHoraPlanton="23";
					NumMinPlanton=(60+(Convert.ToInt32(NumMinServicio.Text)-30)).ToString();
				}
			}
		}
		#endregion
		
		#region EVENTO PARA ALMACENAR UN VIAJE REPENTINO
		public void almacenarViaje()
		{
			new Conexion_Servidor.Libros.SQL_Libros().almacenarRepentino(0, dtFecha.Value.ToString("dd/MM/yyyy"), dtFechaRegreso.Value.ToString("dd/MM/yyyy"), NumHoraRegreso.Text, NumMinServicio.Text, NumHoraPlanton, NumMinPlanton, NumHoraRegreso.Text, NumMinRegreso.Text, txtConfirma.Text, txtDestino.Text, txtResponsable.Text, txtCliente.Text, txtDomicilio.Text, txtCruces.Text, txtColonia.Text, txtRefVisual.Text, txtCorreo.Text, txtTelefono.Text, txtDatosFactura.Text, txtObservaciones.Text, Convert.ToInt16(NumUnidad.Text), Convert.ToInt16(nudPasajeros.Text), cmbUnidades.Text, NumKms.Text, txtCasetas.Text, txtPagoOperador.Text, txtPrecio.Text, txtAnticipos.Text, ID_U, "ALMACENAR");
		}
		#endregion
		
		
	}
}
