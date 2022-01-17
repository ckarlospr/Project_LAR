using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormModificarTipoP : Form
	{
		#region CONSTRUCTOR
		public FormModificarTipoP(FormPagoCobroEspecial refp, Int32 id_u)
		{
			InitializeComponent();
			referenciaP = refp;
			id_usuario = id_u;
		}
		#endregion		
		
		#region INSTANCIAS
		FormPagoCobroEspecial referenciaP;
		Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region VARIABLES
		Int32 id_usuario;
		bool respuesta = true;
		#endregion
		
		#region INICIO- FIN
		void FormModificarTipoPLoad(object sender, EventArgs e)
		{
			cbTipo.Text = referenciaP.dgDatos[1, referenciaP.dgDatos.CurrentRow.Index].Value.ToString();
		}		
		#endregion
				
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{			
			if(referenciaP.dgDatos.SelectedRows.Count > 0){
				for(int x=0; x<referenciaP.dgDatos.Rows.Count; x++){
					if(referenciaP.dgDatos[1,x].Selected == true && referenciaP.dgDatos[1,x].Style.BackColor.Name != "LightGreen"){
						modificarTipo(Convert.ToInt64(referenciaP.dgDatos[0,x].Value.ToString()));
					}
				}
			}
			if(respuesta){
				referenciaP.dgDatos.Rows.Clear();
				referenciaP.adaptador();
				this.Close();
			}
		}
		#endregion
		
		#region METODOS
		public void modificarTipo(Int64 id_CE){
			if(cbTipo.SelectedIndex > -1){
				if(connL.modificarTipoCobroVehiculo(id_CE, cbTipo.Text, id_usuario) == false){
					respuesta = false;
				}
			}
		}
		#endregion
	}
}
