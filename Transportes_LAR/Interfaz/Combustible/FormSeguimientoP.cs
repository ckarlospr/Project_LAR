using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormSeguimientoP : Form
	{
		#region CONSTRUCTOR
		public FormSeguimientoP(FormPruebaRendimiento refPR, string id_r, string seguimiento, string id_h, string id_u)
		{
			InitializeComponent();
			refprincipal = refPR;
			id_rendimiento = id_r;
			cbSeguimiento.Text = seguimiento;
			id_historial = id_h;
			id_usuario = id_u;
		}
		#endregion
		
		#region INSTANCIAS
		private FormPruebaRendimiento refprincipal;
		Conexion_Servidor.Combustible.SQL_Combustible connC = new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion
		
		#region VALIABLES
		string id_rendimiento;
		string id_historial;
		string id_usuario;
		#endregion
		
		#region BOTONES
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{	
			if(modificaSeguimiento()){
				refprincipal.dgPruebaRendimiento[9,refprincipal.dgPruebaRendimiento.CurrentRow.Index].Value = cbSeguimiento.Text;				
				this.Close();
			}
		}
		
		void CbSeguimientoSelectedIndexChanged(object sender, EventArgs e)
		{
			btnAceptar.Enabled = true;
		}
		#endregion
		
		#region METODOS
		private bool modificaSeguimiento(){
			bool respues = connC.modificarSeguimiento(id_rendimiento, id_historial, cbSeguimiento.Text, id_usuario);
			return respues;
		}		
		#endregion		
	}
}
