using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormMsjDatosOperador : Form
	{		
		#region CONSTRUCTOR
		public FormMsjDatosOperador()
		{
			InitializeComponent();
		}
		#endregion
		
		#region VARIABLES
		private Interfaz.Operaciones.Dato.Operador dOperador = null;
		private Interfaz.Operaciones.FormOperacionesOperador refOperador = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormMsjDatosOperadorLoad(object sender, EventArgs e)
		{
		} 
		#endregion
		
		#region GETOPERADOR
		public void getDatosOpe(int id_Operador, FormOperacionesOperador refPrincipal){
			refOperador = refPrincipal;
			dOperador = new Conexion_Servidor.Desapacho.SQL_Operaciones().getDatosOperador(id_Operador);			
			lblNomAlias.Text = dOperador.alias;
			lblNumTelefono.Text ="LAR: "+dOperador.telefono;
			lblDomicilio.Text = dOperador.domicilio;
			lblVehiculo.Text = "Unidad: "+dOperador.numeroV;
			getOtros(id_Operador);
		}
		
		void getOtros(int id_Operador)
		{
			lblOtros.Text = "";
			conn.getAbrirConexion("select Numero, Descripcion from TELEFONOCHOFER where TIPO!='LAR' and ID_Chofer="+id_Operador);			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				lblOtros.Text += " ("+conn.leer["Descripcion"].ToString()+":--"+conn.leer["Numero"].ToString()+"--)";			
			conn.conexion.Close();
		}
		#endregion
		
		void FormMsjDatosOperadorFormClosing(object sender, FormClosingEventArgs e)
		{
			if(refOperador.msj == 1)
				e.Cancel = true;
			refOperador.datosOp.Visible = false;
			refOperador.msj = 0;
		}
	}
}
