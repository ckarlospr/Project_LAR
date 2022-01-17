using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormModificaAnticipo : Form
	{
		#region CONSTRUCTOR
		public FormModificaAnticipo(PrivilegiosPagos refpricipal, string id, string id_usu)
		{
			InitializeComponent();
			principal = refpricipal;
			id_anticipo = id;
			id_usuario = id_usu;
		}		
		#endregion
		
		#region INSTANCIAS
		PrivilegiosPagos principal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region VARIABLES
		string id_anticipo = "0";
		string id_usuario = "0";
		#endregion
		
		#region INICIO - FIN
		void FormModificaAnticipoLoad(object sender, EventArgs e)
		{			
			txtcantidad.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			obtenerAnticipo(id_anticipo);
		}
		
		void FormModificaAnticipoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.cbMostrarValidadosAnticipos.Checked = false;
			principal.AdaptadorAnticipos(Convert.ToInt64(principal.dgServiciosAnt[0, principal.dgServiciosAnt.CurrentRow.Index].Value));
		}
		#endregion
		
		#region BOTONES
		void BtnModificarClick(object sender, EventArgs e)
		{
			connL.actualizarActicipo(id_anticipo, txtcantidad.Text, txtNumero.Text, dtpFecha.Value.ToString("yyyy-MM-dd"), 
			                         cmbTipo.Text, txtComentario.Text, txtubica.Text, id_usuario);
			this.Close();
		}
		#endregion
		
		#region METODOS
		public void obtenerAnticipo(string id){
			try{
				conn.getAbrirConexion("select * from ANTICIPOS_ESPECIALES where ID = "+id);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{										
					dtpFecha.Value = Convert.ToDateTime(conn.leer["FECHA"]);	
					txtNumero.Text = conn.leer["NUMERO"].ToString();
					cmbTipo.Text = conn.leer["TIPO"].ToString();
					txtcantidad.Text = conn.leer["CANTIDAD"].ToString();
					txtComentario.Text = conn.leer["cometario"].ToString();
					txtubica.Text = conn.leer["UBICA"].ToString();	
					
					if(conn.leer["TIPO"].ToString() == "EFECTIVO")
						txtubica.Enabled = false;
					
				}
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}				
		}
		#endregion		
	}
}
