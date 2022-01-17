using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormCancelarVehiculo : Form
	{
		#region VARIABLES
		Int64 id_re = 0;
		Int64 id_rs = 0;
		#endregion
		
		#region INSTANCIAS
		Interfaz.Libro_Nuevo.FormLibroViajes refLibro = null;
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region CONSTRUCTOR
		public FormCancelarVehiculo(FormLibroViajes libro, string desti, Int64 id_e, Int64 id_s)
		{
			InitializeComponent();
			refLibro = libro;
			txtDestino.Text = desti;
			id_re = id_e;
			id_rs = id_s;
		}		
		#endregion
				
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(connL.validaCancelados(id_re, id_rs, "Cancelado por: "+txtmotivo.Text)){
				MessageBox.Show("Se validó correctamente el vehículo cancelado con un costo de 0 pesos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}else{
				MessageBox.Show("Error al validar  el vehículo cancelado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		#endregion
	}
}
