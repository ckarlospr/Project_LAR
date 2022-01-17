using System;
using System.Data;
using System.Windows.Forms;

namespace Transportes_LAR.Conexion_Servidor.Usuario
{
	public class SQL_Usuario :Conexion_Servidor.SQL_Conexion 
	{
		private string[] privilegio=null;
		private String[] usuarioPrivilegio=null;
		public SQL_Usuario():base(){
		}
	
		//--OBTENER_ADAPTADOR
		public DataTable getTabla(string consulta){
			return base.getaAdaptadorTabla(consulta);
		}
		
		//--CONTANDO_DE_USUARIOS_REGISTRADOS
       	public string getCantidadUsuario(){
       		string cantidad="";
       		try
       		{
       			base.getAbrirConexion("select cantidad from (SELECT COUNT(id_usuario)as cantidad from usuario) as tabla");
       			base.leer = base.comando.ExecuteReader();
            	if(base.leer.Read()){
            		cantidad = (base.leer["cantidad"].ToString());
           	 	}
            	base.conexion.Close();
       		}catch{
       			return "Error";
       		}
            return cantidad;
       	}
		
		//--INSERTANDO_UN_USUARIO_NUEVO_CON_PRIVILEGIOS
       	public void getInsertarUsuario(string id_usuario,string nombre,string apellido_p,string apellido_mat, string usuario,string contrasena, string[,] matriz, ComboBox cmbNivelUsuario){
       		string sentencia="execute almacenar_usuario '"+id_usuario+"','"+nombre+"','"+apellido_p+"','"+apellido_mat+"','"+usuario+"','"+contrasena+"','"+matriz[1,0]+matriz[1,1]+matriz[1,2]+"','"+matriz[0,0]+matriz[0,1]+matriz[0,2]+"','"+matriz[2,0]+matriz[2,1]+matriz[2,2]+"','"+matriz[3,0]+matriz[3,1]+matriz[3,2]+"','"+matriz[4,0]+matriz[4,1]+matriz[4,2]+"','"+matriz[5,0]+matriz[5,1]+matriz[5,2]+"','"+matriz[6,0]+matriz[6,1]+matriz[6,2]+"','"+cmbNivelUsuario.Text+"'";
       		base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       	}
       	
       	//--VERIFICANDO_QUE_EL_USUARIO_NO_EXISTA
       	public bool getPersonaExistencia(string nombre,string apellido_pat,string apellido_mat)
       	{
       		Boolean resultado=true;
       		base.getAbrirConexion("select nombre,apellido_pat,apellido_mat from usuario where nombre='"+nombre+"' and apellido_pat='"+apellido_pat+"' and apellido_mat='"+apellido_mat+"'");
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	if(nombre == (base.leer["nombre"].ToString()) && apellido_pat == (base.leer["apellido_pat"].ToString()) && apellido_mat == (base.leer["apellido_mat"].ToString()) )
            	{
            		resultado= false;
            	}
            }
            base.conexion.Close();
            return resultado;
       	}
       	
       	//--VALIDANDO_EL_NOMBRE_DE_USUARIO_DE_EXISTENCIA
       	public Boolean getUsuarioExistencia(String usuario){
       		Boolean resultado=true;
       		base.getAbrirConexion("select usuario from usuario where usuario='"+usuario+"'");
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read()){
            	if(usuario == (base.leer["usuario"].ToString())){
            		resultado= false;
            	}
            }
            base.conexion.Close();
            return resultado;
       	}
       	
       	//--VALIDANDO_LOS_DATOS_DEL_USUARIO
		public bool getValidacionUsuario(String usuario,String contrasena){
			bool validar=false;
       		base.getAbrirConexion("select usuario,contrasena,privilegio from usuario where usuario ='"+usuario+"' and contrasena='"+contrasena+"'");
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read()){
            	if(usuario == (leer["usuario"].ToString()) && contrasena == (leer["contrasena"].ToString())&&(leer["privilegio"].ToString())!="N/A")
            		validar = true;
            	else
            		validar = false;
            }
            conexion.Close();
            return validar;
		}
       	
       	
       	#region PRIVILEGIOS
       	
       	public string[] getCargarPrivilegio(string derecho,string usuario){
       		base.getAbrirConexion("select "+derecho+" from usuario where usuario='"+usuario+"'");
       		base.leer=base.comando.ExecuteReader();
       		if(base.leer.Read()){
       			this.privilegio=getDividirCadena(leer[derecho].ToString());
       		}
       		conexion.Close();
       		return this.privilegio;
       	}
       	
       	private string[] getDividirCadena(string cadena){
       		this.privilegio=new String[cadena.Length];
       		this.privilegio[0]=cadena.Substring(0,1);
       		this.privilegio[1]=cadena.Substring(1,1);
       		this.privilegio[2]=cadena.Substring(2,1);
       		return this.privilegio;
       	}
       	
       	public String[] getPrilvilegios(string usuario){
       		getAbrirConexion("select derecho_unidad,derecho_operador,derecho_ruta,derecho_aseguradora,derecho_cliente,derecho_usuario,derecho_servidor from usuario where id_usuario="+usuario);
       		leer=comando.ExecuteReader();
       		if(leer.Read()){
       			this.usuarioPrivilegio=new String[7];
       			usuarioPrivilegio[0]=leer["derecho_unidad"].ToString();
       			usuarioPrivilegio[1]=leer["derecho_operador"].ToString();
       			usuarioPrivilegio[2]=leer["derecho_ruta"].ToString();
       			usuarioPrivilegio[3]=leer["derecho_aseguradora"].ToString();
       			usuarioPrivilegio[4]=leer["derecho_cliente"].ToString();
       			usuarioPrivilegio[5]=leer["derecho_usuario"].ToString();
       			usuarioPrivilegio[6]=leer["derecho_servidor"].ToString();
       		}
       		conexion.Close();
       		return usuarioPrivilegio;
       	}
       	
       	#endregion
       	
       	//--CARGAR_DATOS_DEL_USUARIO
       	public void getCargarDatos(TextBox nombre,TextBox apellido_p,TextBox apellido_m,TextBox usuario,TextBox contrasena,string id_user, ComboBox cmbNivelUsuario){
       		base.getAbrirConexion("select nombre,apellido_pat,apellido_mat,usuario,contrasena, privilegio from usuario where id_usuario='"+id_user+"'");
       		base.leer=base.comando.ExecuteReader();
       		if(leer.Read()){
       			nombre.Text=			base.leer["nombre"].ToString();
       			apellido_p.Text=		base.leer["apellido_pat"].ToString();
       			apellido_m.Text=		base.leer["apellido_mat"].ToString();
       			usuario.Text=			base.leer["usuario"].ToString();
       			contrasena.Text=		base.leer["contrasena"].ToString();
       			cmbNivelUsuario.Text=	base.leer["privilegio"].ToString();
       		}
       		conexion.Close();
       	}
       		
       	//--ELIMINAR_USUARIO_DE_LA_BASE_DE_DATOS
       	public void getEliminarUsuario(string usuario){
       		base.getAbrirConexion("delete from usuario where id_usuario="+usuario);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       	}
       	
       	private string getContrasenaUsuario(string usuario){
       		string contrasena="";
       		base.getAbrirConexion("select contrasena from usuario where usuario='"+usuario+"'");
       		base.leer=base.comando.ExecuteReader();
       		if(base.leer.Read()){
       			contrasena=base.leer["contrasena"].ToString();
       		}
       		conexion.Close();
       		return contrasena;
       	}
       	
       	//--ACTUALIZACION _DE_USUARIO_O_CONTRASEÑA_POR_EL_USUARIO
		public bool getActualizarUsuario(string usuario,string contrasena,string nuevoUsuario,string nuevaContrasena, ComboBox cmbNivelUsuario)
		{
       		if(contrasena== getContrasenaUsuario(usuario)){
       			base.getAbrirConexion("UPDATE usuario SET usuario='"+nuevoUsuario+"',contrasena='"+nuevaContrasena+"',privilegio='"+cmbNivelUsuario.Text+"' WHERE usuario='"+usuario+"'");
	       		base.comando.ExecuteNonQuery();
	       		conexion.Close();
	       		return true;
       		}else{
       			return false;
       		}
		}
		
		public void getActualizarEstatus(string ID, string Estado)
		{
   			base.getAbrirConexion("UPDATE usuario SET ESTATUS='"+Estado+"' WHERE ID_USUARIO='"+ID+"'");
       		base.comando.ExecuteNonQuery();
       		conexion.Close();
		}
       	
       	public String getIdUsuario(String usuario,String contrasena)
		{
			 String ID="";
			 base.getAbrirConexion("select id_usuario from usuario where usuario='"+usuario+"' and contrasena='"+contrasena+"'");
		     base.leer = base.comando.ExecuteReader();
		     if(base.leer.Read())
		     {
		        ID=(leer["id_usuario"].ToString());
		     }
		        
		     conexion.Close();
		     return ID;
		}
       	
       	public String getNivelUsuario(String id_usuario)
       	{
			String Nivel="";
       		base.getAbrirConexion("select privilegio from usuario where id_usuario ='"+id_usuario+"'");
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	Nivel = (leer["privilegio"].ToString());
            }
            conexion.Close();
            return Nivel;
		}
       	
       	public String getUsuario(String id_usuario)
       	{
			String Nivel="";
       		base.getAbrirConexion("select usuario from usuario where id_usuario ='"+id_usuario+"'");
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	Nivel = (leer["usuario"].ToString());
            }
            conexion.Close();
            return Nivel;
		}
       	
       	
       	public String getNombreCompleto(String id_usuario)
       	{
			String Nombre="";
       		base.getAbrirConexion("select nombre,apellido_pat,apellido_mat from usuario where id_usuario ='"+id_usuario+"'");
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	Nombre = (leer["nombre"].ToString()+" "+leer["apellido_pat"].ToString()+" "+leer["apellido_mat"].ToString());
            }
            conexion.Close();
            return Nombre;
		}
       	
       	#region CHECADOR
       	public void ingreso(String ID_U)
       	{
       		bool sigue = true;
       		
       		String consulta = "select * from ASISTENCIA where ID_U ='"+ID_U+"' and tipo='ENTRADA' and FECHA=(SELECT CONVERT (DATE, SYSDATETIME()))";
       		base.getAbrirConexion(consulta);
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	sigue = false;
            }
            else
            {
            	sigue = true;
            }
            conexion.Close();
            
            if(sigue==true)
            {
            	consulta = "INSERT INTO ASISTENCIA VALUES ("+ID_U+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), 'ENTRADA', '1');";
            	base.getAbrirConexion(consulta);
	       		base.comando.ExecuteNonQuery();
	       		conexion.Close();
            }
       	}
       	
       	public void salida(String ID_U)
       	{
       		bool sigue = true;
       		
       		String consulta = "select * from ASISTENCIA where ID_U ='"+ID_U+"' and tipo='SALIDA' and FECHA=(SELECT CONVERT (DATE, SYSDATETIME()))";
       		base.getAbrirConexion(consulta);
            base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
            	sigue = false;
            }
            else
            {
            	sigue = true;
            }
            conexion.Close();
            
            if(sigue==true)
            {
            	consulta = "INSERT INTO ASISTENCIA VALUES ("+ID_U+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), 'SALIDA', '1');";
            	base.getAbrirConexion(consulta);
	       		base.comando.ExecuteNonQuery();
	       		conexion.Close();
            }
            else
            {
            	consulta = "UPDATE ASISTENCIA SET HORA=(SELECT CONVERT (TIME, SYSDATETIME())) WHERE ID_U="+ID_U+" and TIPO='SALIDA' and FECHA=(SELECT CONVERT (DATE, SYSDATETIME()))";
            	base.getAbrirConexion(consulta);
	       		base.comando.ExecuteNonQuery();
	       		conexion.Close();
            }
       	}
       	#endregion
	}
}
