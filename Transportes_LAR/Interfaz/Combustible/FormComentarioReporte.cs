using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormComentarioReporte : Form
	{
		#region INSTANCIAS
		public formPrincipalComb combustible = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		Int32 ID_A;
		#endregion
		
		#region CONTRUCTOR
		public FormComentarioReporte(formPrincipalComb refCombustible, Int32 id_A, string folio_a)
		{
			InitializeComponent();
			combustible = refCombustible;
			ID_A = id_A;
			txtFolio.Text = folio_a;
		}		
		#endregion
		
		#region INICIO - FIN
		void FormComentarioReporteLoad(object sender, EventArgs e)
		{
			obtenerComentario();
		}
		
		void FormComentarioReporteFormClosing(object sender, FormClosingEventArgs e)
		{			
			combustible.getReporte();
		}
		#endregion
		
		#region BOTONES
		void BnSalirProgramcionClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TxtGuardarClick(object sender, EventArgs e)
		{
			try{
				string sentencia = @"update AUTORIZACION set COMENTARIO = '"+txtComentario.Text+"' where ID = "+ID_A;				
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();		
				this.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al guardar el comentario " +ex.Message);
			}finally{				
				conn.conexion.Close();		
				this.Close();		
			}
			
		}
		#endregion
		
		#region METODOS
		public void obtenerComentario(){
			string consulta = "select COMENTARIO from AUTORIZACION where ID = " +ID_A;			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){						
				txtComentario.Text = conn.leer["COMENTARIO"].ToString();	
			}
			conn.conexion.Close();			
		}
		#endregion
	}
}
