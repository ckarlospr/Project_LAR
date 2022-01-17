using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormParametros : Form
	{
		#region CONSTRUCTOR
		public FormParametros(FormLibroViajes principa)
		{
			InitializeComponent();
			this.principal = principa;
		}
		#endregion
		
		#region INSTANCIAS
		FormLibroViajes principal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region INICIO - FIN
		void FormParametrosLoad(object sender, EventArgs e)
		{
			adaptador();
		}
		
		void FormParametrosFormClosing(object sender, FormClosingEventArgs e)
		{
			if(respuesta){
				principal.filtros();
				principal.filtrosPrincipales();
				principal.filtrosSinOrden();
			}
		}
		#endregion
		
		#region ADAPTADOR
		public void adaptador()
		{			
			try{
			ColoresAlternadosRows(dgParametros);
				dgParametros.Rows.Clear();			
				String sentencia = "select * from PARAMETROS_VENTAS";
				conn.getAbrirConexion(sentencia);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgParametros.Rows.Add(conn.leer["id"].ToString(), 
					                      conn.leer["NOMBRE"].ToString(),
					                      conn.leer["PARAMETRO1"].ToString(),
					                      conn.leer["PARAMETRO2"].ToString(),
					                      conn.leer["OBSERVACIONES"].ToString());
				}
				conn.conexion.Close();		
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				conn.conexion.Close();	
			}					
			dgParametros.ClearSelection();
		}
		#endregion
		
		#region VARIABLES
		bool respuesta = false;
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{	
			for(int x=0; x<dgParametros.Rows.Count; x++){
				try{
					if(dgParametros[2,x].Value.ToString() != null && dgParametros[2,x].Value.ToString() != ""){
						connL.modificarParametros(dgParametros[1,x].Value.ToString(), dgParametros[2,x].Value.ToString(), dgParametros[3,x].Value.ToString(),  dgParametros[4,x].Value.ToString(), Convert.ToInt16(dgParametros[0,x].Value), principal.id_usuario);
						respuesta = true;
					}
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("Error al guardar Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
				}finally{
					conn.conexion.Close();	
				}	
			}
			if(respuesta){
				adaptador();
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se actualizaron los datos");
				mensaje.Show();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			new Libro_Nuevo.Pagos.FormContribuyentes(2).ShowDialog();	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			new Libro_Nuevo.Pagos.FormContribuyentes(1).ShowDialog();	
		}
		#endregion
		
		#region METODOS
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		#endregion		
	}
}
