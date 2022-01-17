using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Unidad
{
	/// <summary>
	/// REPORTES DE LA UNIDAD
	/// </summary>
	public partial class FormOperadorVehiculoHistorial : Form
	{
		private Interfaz.FormPrincipal principal = null;
		public FormOperadorVehiculoHistorial()
		{
			InitializeComponent();
		}
		public FormOperadorVehiculoHistorial(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal = principal;
		}
		
		void FormOperadorVehiculoHistorialLoad(object sender, EventArgs e)
		{
			consultaLista();
		}
		
		void TextBoxTextChanged(object sender, EventArgs e)
		{
			dgvHistorialOV.DataSource=new Conexion_Servidor.Unidad.SQL_Unidad().getTabla("select O.ID ido, V.ID idv, H.FECHA fecha, H.HORA hora, O.Nombre nombre, O.Apellido_Pat app, O.Apellido_Mat apm, V.Tipo_Unidad tv, V.Numero nv, V.Motor_Num_Serie ns, H.DATO descripcion, upper(u.usuario) Usuario from HISTORIALOPERADORVEHICULO H, VEHICULO V, OPERADOR O, usuario u where H.ID_OPERADOR=O.ID and H.ID_UNIDAD=V.ID and u.id_usuario = h.ID_U and O.Alias like '" + txtNombre.Text + "%'");
		}
		
		#region CONSULTA
		public void consultaLista()
		{
			dgvHistorialOV.DataSource=new Conexion_Servidor.Unidad.SQL_Unidad().getTabla("select O.ID ido, V.ID idv, H.FECHA fecha, H.HORA hora, O.Nombre nombre, O.Apellido_Pat app, O.Apellido_Mat apm, V.Tipo_Unidad tv, V.Numero nv, V.Motor_Num_Serie ns, H.DATO descripcion, upper(u.usuario) Usuario from HISTORIALOPERADORVEHICULO H, VEHICULO V, OPERADOR O, usuario u where H.ID_OPERADOR=O.ID and H.ID_UNIDAD=V.ID and u.id_usuario = h.ID_U");
		}
		#endregion
		
		void FormOperadorVehiculoHistorialFormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
	}
}
