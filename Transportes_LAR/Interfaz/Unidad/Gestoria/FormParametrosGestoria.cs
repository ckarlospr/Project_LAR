using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Unidad.Gestoria
{
	public partial class FormParametrosGestoria : Form
	{
		
	#region CONSTRUCTOR
	public FormParametrosGestoria(Gestoria refg)
	{
		InitializeComponent();
		principal = refg;
		
	}
   #endregion

    #region INSTANCIAS
    Gestoria principal = null;
   	private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
	private Conexion_Servidor.Unidad.SQL_Unidad connU = new Conexion_Servidor.Unidad.SQL_Unidad();
     #endregion

  	#region INICIO - FIN
	void FormParametrosGestoriaLoad(object sender, EventArgs e)
	{
		adaptador();
	}
	
	void FormParametrosGestoriaFormClosing(object sender, FormClosingEventArgs e)
	{
		principal.PrevisionPeriodos();
	}
	
	#endregion
		
	#region ADAPTADOR
	public void adaptador()
	{			
		try{		
			string sentencia = "select PARAMETRO1 from PARAMETROS_GESTORIA_V where id = 1";
			
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				nudRefrendo.Text = conn.leer["PARAMETRO1"].ToString();			
			conn.conexion.Close();
			
			sentencia = "select PARAMETRO1 from PARAMETROS_GESTORIA_V where id = 2";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				nudPermiso.Text = conn.leer["PARAMETRO1"].ToString();			
			conn.conexion.Close();
			
			
			sentencia = "select PARAMETRO1 from PARAMETROS_GESTORIA_V where id = 3";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				nudPoliza.Text = conn.leer["PARAMETRO1"].ToString();			
			conn.conexion.Close();
			
			sentencia = "select PARAMETRO1 from PARAMETROS_GESTORIA_V where id = 4";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				nudVerifixcacion.Text = conn.leer["PARAMETRO1"].ToString();			
			conn.conexion.Close();
			
			
			sentencia = "select PARAMETRO1 from PARAMETROS_GESTORIA_V where id = 5";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				nudFisico.Text = conn.leer["PARAMETRO1"].ToString();			
			conn.conexion.Close();
			
			sentencia = "select PARAMETRO1 from PARAMETROS_GESTORIA_V where id = 6";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				nudcasetas.Text = conn.leer["PARAMETRO1"].ToString();		
			conn.conexion.Close();
						
			sentencia = "select PARAMETRO1 from PARAMETROS_GESTORIA_V where id = 7";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				nudCaseta2.Text = conn.leer["PARAMETRO1"].ToString();			
			conn.conexion.Close();	
			
		}catch(Exception ex){
			MessageBox.Show("Error al obtener los Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
		}
	}
    #endregion	
		
	#region BOTONES
	void BtnGuardarClick(object sender, EventArgs e)
	{
		bool respuesta = true;
		try{
			connU.modificarParametrosGestoria(nudRefrendo.Text, 1);
			connU.modificarParametrosGestoria(nudPermiso.Text, 2);
			connU.modificarParametrosGestoria(nudPoliza.Text, 3);
			connU.modificarParametrosGestoria(nudVerifixcacion.Text, 4);
			connU.modificarParametrosGestoria(nudFisico.Text, 5);
			connU.modificarParametrosGestoria(nudcasetas.Text, 6);
			connU.modificarParametrosGestoria(nudCaseta2.Text, 7);
			respuesta = true;			
		}catch(Exception ex){
			respuesta = false;
			MessageBox.Show("Error al guardar Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
		}
		if(respuesta){
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se actualizaron los datos");
			mensaje.Show();
		}
	}
    #endregion				
	}
}
