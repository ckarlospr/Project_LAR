
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormDatosOperador : Form
	{
		public FormDatosOperador(int id, String tipo)
		{
			InitializeComponent();
			id_Ope=id;
			this.tipo=tipo;
		}
		
		#region VARIABLES
		private int id_Ope;
		private String tipo;
		private Interfaz.Operaciones.Dato.Operador dOperador = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormDatosOperadorLoad(object sender, EventArgs e)
		{
			getDatosOpe();
			new Conexion_Servidor.Desapacho.SQL_Operaciones().getImagenOp(id_Ope,pbDOperador);
			//lblNumTelefono.Text = new Conexion_Servidor.Desapacho.SQL_Operaciones().getTelefono(id_Ope);
		} 
		#endregion
		
		#region GETOPERADOR
		public void getDatosOpe()
		{
			if(tipo=="Operador")
			{
				dOperador = new Conexion_Servidor.Desapacho.SQL_Operaciones().getDatosOperador(id_Ope);
				
				lblNomAlias.Text=dOperador.alias;
				lblNumeroDeVehiculo.Text=dOperador.numeroV;
				lblTipoDeVehicuclo.Text=dOperador.tipoV;
				lblNumTelefono.Text="LAR: "+dOperador.telefono;
				lblDomicilio.Text=dOperador.domicilio;
				lblPatron.Text=dOperador.patron;
				getOtros();
			}
			else
			{
				dOperador = new Conexion_Servidor.Desapacho.SQL_Operaciones().getDatosOperadorExt(id_Ope);
				lblNomAlias.Text=dOperador.alias;
				lblNumeroDeVehiculo.Text=dOperador.numeroV;
				lblTipoDeVehicuclo.Text=dOperador.tipoV;
			}
		}
		
		void getOtros()
		{
			lblTelAlt.Text="";
			conn.getAbrirConexion("select Numero, Descripcion from TELEFONOCHOFER where TIPO!='LAR' and ID_Chofer="+id_Ope);
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				lblTelAlt.Text =lblTelAlt.Text+" ("+conn.leer["Descripcion"].ToString()+":--"+conn.leer["Numero"].ToString()+"--)";
			}
			conn.conexion.Close();
			
			String CONSS = "SELECT V.Numero, C.Nombre, O.Alias, O.ID, E.Descripcion FROM VEHICULO V, CATEGORIAEQUIPO C, EQUIPAMENTO E, OPERADOR O, ASIGNACIONUNIDAD A WHERE O.ID=A.ID_OPERADOR AND A.ID_UNIDAD=V.ID AND V.ID=E.ID_Unidad AND E.ID_Categoria=C.ID AND C.Nombre LIKE '%FGDL%' AND O.ID="+id_Ope;
			conn.getAbrirConexion(CONSS);
			
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				lblTarjeta.Text="CON TARJETA FGDL \n"+conn.leer["Descripcion"].ToString();
				lblTarjeta.ForeColor=Color.Blue;
			}
			else
			{
				lblTarjeta.Text="SIN TARJETA FGDL";
				lblTarjeta.ForeColor=Color.Red;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region MODIFICAR
		void CmdModificarClick(object sender, EventArgs e)
		{
			new Interfaz.Operador.Modificar.FormModificaOp(id_Ope).ShowDialog();
			getDatosOpe();
		}
		#endregion
		
		void CmdRutasClick(object sender, EventArgs e)
		{
			Interfaz.Operaciones.FormRutasCercanas rutaOperador = new Interfaz.Operaciones.FormRutasCercanas(id_Ope, lblNomAlias.Text);
			rutaOperador.ShowDialog();
		}
	}
}
