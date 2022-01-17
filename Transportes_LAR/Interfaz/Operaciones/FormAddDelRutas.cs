using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormAddDelRutas : Form
	{
		public Interfaz.Operaciones.FormEmpresasOperaciones refTabla ;
		String Borrado;
		public String rutaUno;
		public String rutaDos;
		public String IDrutaUno="";
		public String IDrutaDos="";
		
		
		public FormAddDelRutas(Interfaz.Operaciones.FormEmpresasOperaciones refOperaciones, String tipo)
		{
			InitializeComponent();
			refTabla=refOperaciones;
			Borrado=tipo;
		}
		
		public void modRuta(String Mensaje)
		{
			lblMensajeAddDel.Text=Mensaje;
		}
		
		void BtnOpcUnoClick(object sender, EventArgs e)
		{
			if(validando("temporalmente")==true)
			{
				new Interfaz.FormMensaje("Ruta eliminada temporlamente").Show();
				this.Close();
			}
		}
		
		void BtnOpcDosClick(object sender, EventArgs e)
		{
			if(validando("permanentemente")==true)
			{
				if(IDrutaUno!="" && IDrutaDos!="")
				{
					new Conexion_Servidor.Ruta.SQL_Ruta().getEliminarRuta(IDrutaUno);
					new Conexion_Servidor.Ruta.SQL_Ruta().getEliminarRuta(IDrutaDos);
					new Interfaz.FormMensaje("Ruta eliminada permanentemente").Show();
					refTabla.indic=0;
					this.Close();
				}
				else
				{
					if(IDrutaUno!="")
					{
						new Conexion_Servidor.Ruta.SQL_Ruta().getEliminarRuta(IDrutaUno);
						new Interfaz.FormMensaje("Ruta eliminada permanentemente").Show();
						refTabla.indic=0;
						this.Close();
					}
					else
					{
						if(IDrutaDos!="")
						{
							new Conexion_Servidor.Ruta.SQL_Ruta().getEliminarRuta(IDrutaDos);
							new Interfaz.FormMensaje("Ruta eliminada permanentemente").Show();
							refTabla.indic=0;
							this.Close();
						}
					}
				}
			}
		}
		
		void BtnOpcTresClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void FormAddDelRutasLoad(object sender, EventArgs e)
		{
			if(Borrado=="E"||Borrado=="S")
			{
				rbSalida.Visible=false;
				rbEntrada.Visible=false;
				gbSentido.Visible=false;
			}
		}
		
		public bool validando(String tipo)
		{
			Boolean respuesta=false;
			if(rbEntrada.Checked==true && rbSalida.Checked==true)
			{
				rutaUno=refTabla.dtgEmpresas[6,refTabla.rutaSelected].Value.ToString();
				rutaDos=refTabla.dtgEmpresas[14,refTabla.rutaSelected].Value.ToString();
				IDrutaUno=refTabla.dtgEmpresas[2,refTabla.rutaSelected].Value.ToString();
				IDrutaDos=refTabla.dtgEmpresas[10,refTabla.rutaSelected].Value.ToString();
				if(MessageBox.Show("¿Desea eliminar "+tipo+" \n las rutas de entrada y salida "+rutaUno+"?","Eliminar ruta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
				{
					refTabla.dtgEmpresas.Rows.RemoveAt(refTabla.rutaSelected);
					respuesta=true;
				}
			}
			else
			{
				if(rbEntrada.Checked==true || Borrado=="E")
				{
					if(refTabla.dtgEmpresas[14,refTabla.rutaSelected].Value.ToString()!=" ")
					{
						rutaUno=refTabla.dtgEmpresas[6,refTabla.rutaSelected].Value.ToString();
						IDrutaUno=refTabla.dtgEmpresas[2,refTabla.rutaSelected].Value.ToString();
						if(MessageBox.Show("¿Desea eliminar "+tipo+" la ruta de entrada "+rutaUno+"?","Eliminar ruta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
						{
							
							refTabla.dtgEmpresas[0,refTabla.rutaSelected].Value="0";
							for(int x=2; x<8; x++)
							{
								refTabla.dtgEmpresas.Rows[refTabla.rutaSelected].Cells[x].Value="";
							}
							refTabla.dtgEmpresas[8,refTabla.rutaSelected].Value=false;
							respuesta=true;
						}
					}
					else
					{
						respuesta = opcionBorrado(tipo);
					}
				}
				else
				{
					if(rbSalida.Checked==true || Borrado=="S")
					{
						if(refTabla.dtgEmpresas[6,refTabla.rutaSelected].Value.ToString()!=" ")
						{
							rutaDos=refTabla.dtgEmpresas[14,refTabla.rutaSelected].Value.ToString();
							IDrutaDos=refTabla.dtgEmpresas[10,refTabla.rutaSelected].Value.ToString();
							if(MessageBox.Show("¿Desea eliminar "+tipo+" las ruta de salida "+rutaDos+"?","Eliminar ruta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
							{
								refTabla.dtgEmpresas[9,refTabla.rutaSelected].Value="0";
								for(int x=10; x<16; x++)
								{
									refTabla.dtgEmpresas.Rows[refTabla.rutaSelected].Cells[x].Value="";
								}
								refTabla.dtgEmpresas[16,refTabla.rutaSelected].Value=false;
								respuesta=true;
							}
						}
						else
						{
							respuesta = opcionBorrado(tipo);
						}
					}
					else
					{
						if(Borrado=="E"||Borrado=="S")
						{
							respuesta = opcionBorrado(tipo);
						}
						else
						{
							MessageBox.Show("Seleccione el sentido de la ruta que desea eliminar");
							rbEntrada.BackColor=Color.Pink;
							rbSalida.BackColor=Color.Pink;
						}
					}
				}
			}
			return respuesta;
		}
		
		public bool opcionBorrado(String tipo)
		{
			bool resp=false;
			rutaUno=refTabla.dtgEmpresas[6,refTabla.rutaSelected].Value.ToString();
			rutaDos=refTabla.dtgEmpresas[14,refTabla.rutaSelected].Value.ToString();
			IDrutaUno=refTabla.dtgEmpresas[2,refTabla.rutaSelected].Value.ToString();
			IDrutaDos=refTabla.dtgEmpresas[10,refTabla.rutaSelected].Value.ToString();
			if(MessageBox.Show("¿Desea eliminar "+tipo+" la ruta "+rutaUno+rutaDos+"?","Eliminar ruta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
			{
				refTabla.dtgEmpresas.Rows.RemoveAt(refTabla.rutaSelected);
				resp=true;
			}
			return resp;
		}
	}
}
