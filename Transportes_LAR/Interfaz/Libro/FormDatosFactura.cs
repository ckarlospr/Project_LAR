using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormDatosFactura : Form
	{
		public FormDatosFactura(int TIPO, LibroViajes formLibro, String cli)
		{
			InitializeComponent();
			refLibro = formLibro;
			tipo=TIPO;
			cliente=cli;
		}
		
		public FormDatosFactura(int TIPO, LibroViajes formLibro, int ID_datos)
		{
			InitializeComponent();
			refLibro = formLibro;
			tipo=TIPO;
			ID_dat=ID_datos;
		}
		
		public FormDatosFactura(int TIPO, String razon)
		{
			InitializeComponent();
			tipo=TIPO;
			razon_social=razon;
		}
		
		public FormDatosFactura(int TIPO, String razon, String correo)
		{
			InitializeComponent();
			tipo=TIPO;
			razon_social=razon;
			CORREO=correo;
		}
		
		#region VARIABLES
		String CORREO = "";
		int tipo = 1;
		String cliente = null;
		String razon_social = "";
		int ID_dat = 0;
		int ID_F=0;
		#endregion
		
		#region INSTANCIAS
		LibroViajes refLibro = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormDatosFacturaLoad(object sender, EventArgs e)
		{
			getCargarValidacionCampos(this);
			if(tipo==1)
			{
				txtRazon.Enabled=true;
				txtDomicilio.Enabled=true;
				txtRFC.Enabled=true;
				txtCp.Enabled=true;
				txtColonia.Enabled=true;
				txtCiudad.Enabled=true;
				lblTitulo.Text="Ingreso de "+lblTitulo.Text;
			}
			else if(tipo==2)
			{
				lblTitulo.Text="Revisión de "+lblTitulo.Text;
				getDatos();
				cmdModificar.Enabled=true;
			}
			else if(tipo==3)
			{
				lblTitulo.Text="Datos de "+lblTitulo.Text;
				getDatos2();
			}
			else if(tipo==4)
			{
				lblTitulo.Text="Datos de "+lblTitulo.Text;
				getDatos2();
				lblCorreo.Text=CORREO;
			}
		}
		#endregion
		
		#region GET DATOS A REVISAR
		void getDatos()
		{
			String consulta = "select * from DATOS_FACTURA where ID="+ID_dat;
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				txtRazon.Text=conn.leer["RAZON_SOCIAL"].ToString();
				txtDomicilio.Text=conn.leer["DOMICILIO"].ToString();
				txtRFC.Text=conn.leer["RFC"].ToString();
				txtCp.Text=conn.leer["CP"].ToString();
				txtColonia.Text=conn.leer["COLONIA"].ToString();
				txtCiudad.Text=conn.leer["CIUDAD"].ToString();
			}			
			conn.conexion.Close();
			textBox1.Text = CORREO;
		}
		
		void getDatos2()
		{
			String consulta = "select * from DATOS_FACTURA where RAZON_SOCIAL='"+razon_social+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				txtRazon.Text=conn.leer["RAZON_SOCIAL"].ToString();
				txtDomicilio.Text=conn.leer["DOMICILIO"].ToString();
				txtRFC.Text=conn.leer["RFC"].ToString();
				txtCp.Text=conn.leer["CP"].ToString();
				txtColonia.Text=conn.leer["COLONIA"].ToString();
				txtCiudad.Text=conn.leer["CIUDAD"].ToString();
			}			
			conn.conexion.Close();
			textBox1.Text = CORREO;
		}
		#endregion
		
		#region EVENTO BOTON ACEPTAR Y MODIFICAR
		void CmdAceptarClick(object sender, EventArgs e)
		{
			if(tipo==1)
			{
				if(espaciosVacios())
				{
					MessageBox.Show("Es necesario ingresar todos los datos para guardar el registro.");
				}
				else
				{
					guardaDatos(cliente, txtRazon.Text, txtCp.Text, txtColonia.Text, txtCiudad.Text, txtRFC.Text, txtDomicilio.Text);
					refLibro.txtDatosFactura.Text=txtRazon.Text;
					refLibro.idFact=ID_F;
					refLibro.cmdRevisar.Enabled=true;
					refLibro.cmbTipoPago.Enabled=true;
					this.Visible=false;
				}
			}
			else if(tipo==2)
			{
				this.Close();
			}
		}
		
		void CmdModificarClick(object sender, EventArgs e)
		{
			String consulta = "update DATOS_FACTURA set RAZON_SOCIAL='"+txtRazon.Text+"', DOMICILIO='"+txtDomicilio.Text+"', CP='"+txtCp.Text+"', COLONIA='"+txtColonia.Text+"', CIUDAD='"+txtCiudad.Text+"', RFC='' where ID="+ID_dat;
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
			
			conn.getAbrirConexion("SELECT MAX(ID) ID FROM DATOS_FACTURA");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_F=Convert.ToInt16(conn.leer["ID"]);
			}
			
			conn.conexion.Close();
			
			refLibro.txtDatosFactura.Text=txtRazon.Text;
			refLibro.idFact=ID_F;
			refLibro.cmdRevisar.Enabled=true;
			refLibro.cmbTipoPago.Enabled=true;
		}
		#endregion
		
		#region EVENTO CLOSING
		void FormDatosFacturaFormClosing(object sender, FormClosingEventArgs e)
		{
			/*if(tipo==1)
			{
				e.Cancel=true;
				this.Visible=false;
			}*/
		}
		#endregion
		
		#region	 VALIDACION ESPACIOS VACIOS
		bool espaciosVacios()
		{
			bool respuesta=false;
			if(txtRazon.Text=="" || txtRFC.Text=="" || txtCp.Text=="" || txtColonia.Text=="" || txtCiudad.Text=="")
			{
				respuesta=true;
			}
			
			return respuesta;
		}
		#endregion
		
		#region GUARDADO DE DATOS
		public bool guardaDatos(String cliente, String razon, String CP, String colonia, String ciudad, String RFC, string DOMICILIO)
		{		
			bool respuesta=true;
			
			String CONSULT = "insert into DATOS_FACTURA values ('"+cliente+"', '"+razon+"', '"+DOMICILIO+"', '"+CP+"','"+colonia+"', '"+ciudad+"', '"+RFC+"');";
			conn.getAbrirConexion(CONSULT);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			conn.getAbrirConexion("SELECT MAX(ID) ID FROM DATOS_FACTURA");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_F=Convert.ToInt16(conn.leer["ID"]);
			}
			
			conn.conexion.Close();
			
			return respuesta;
		}
		#endregion
		
		#region VALIDACION DE COMPONENTES
		private void getCargarValidacionCampos(FormDatosFactura formDat)
		{
			formDat.txtCp.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formDat.txtRFC.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosGuion);
		}
		#endregion
		
		#region EVENTO SELECCIONAR		
		void TxtRazonClick(object sender, EventArgs e)
		{
			txtRazon.Focus();
			txtRazon.SelectAll();
		}
		
		void TxtDomicilioClick(object sender, EventArgs e)
		{
			txtDomicilio.Focus();
			txtDomicilio.SelectAll();
		}
		
		void TxtCpClick(object sender, EventArgs e)
		{
			txtCp.Focus();
			txtCp.SelectAll();
		}
		
		void TxtColoniaClick(object sender, EventArgs e)
		{
			txtColonia.Focus();
			txtColonia.SelectAll();
		}
		
		void TxtCiudadClick(object sender, EventArgs e)
		{
			txtCiudad.Focus();
			txtCiudad.SelectAll();
		}
		
		void TxtRFCClick(object sender, EventArgs e)
		{
			txtRFC.Focus();
			txtRFC.SelectAll();
		}
		
		void TextBox1Click(object sender, EventArgs e)
		{
			textBox1.Focus();
			textBox1.SelectAll();
		}
		#endregion
	}
}
