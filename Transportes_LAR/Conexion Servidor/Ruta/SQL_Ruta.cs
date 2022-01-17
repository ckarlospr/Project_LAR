using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Conexion_Servidor.Ruta
{
	public class SQL_Ruta:Conexion_Servidor.SQL_Conexion
	{
		private string[] formatoHora=new string[3];
		
		public SQL_Ruta():base(){
		}
		
		//--OBENTER_ADAPTADOR_DE_TABLA
		public DataTable getTabla(string consulta){
			return base.getaAdaptadorTabla(consulta);
		}
		
		#region INSERTAR_RUTA
		public void getInsertar(string idRuta,
								string idSubEmpresa,
		                        string nombre,
		                        string turno,
		                        string sentido,
		                        string kilometros,
		                        string horaInicio,
		                        string zona,
		                        string sencilloCamion,
		                        string completoCamion,
		                        string sencilloCamioneta,
		                        string completoCamioneta,
		                        string sencilloForaneo,
		                        string completoForaneo,
		                        string intinerario,
		                        string dia,
		                        int foranea
		                       ){
			idRuta=(idRuta=="")?"NULL":idRuta;
			base.getAbrirConexion("execute almacenar_modificar_ruta "+idRuta+",'"+nombre+"'" +
			                      ",'"+turno+"'"+
			                      ",'"+sentido+"'"+
			                      ",'"+kilometros+"'"+
			                      ",'"+horaInicio+"'"+
			                      ",'"+intinerario+"'"+
			                      ",'"+sencilloCamioneta+"'"+
			                      ",'"+completoCamioneta+"'"+
			                      ",'"+sencilloCamion+"'"+
			                      ",'"+completoCamion+"'"+
			                      ",'"+sencilloForaneo+"'"+
			                      ",'"+completoForaneo+"'"+
			                      ","+idSubEmpresa+
			                      ","+zona+
			                      ",'"+dia+"'"+
			                      ", "+foranea
			                     );
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void getInsertarApoyo(string idRuta,
								string idSubEmpresa,
		                        string nombre,
		                        string turno,
		                        string sentido,
		                        string kilometros,
		                        string horaInicio,
		                        string zona,
		                        string intinerario,
		                        int foranea,
		                        String fecha,
		                        string sencilloCamion,
		                        string completoCamion,
		                        string sencilloCamioneta,
		                        string completoCamioneta,
		                        string sencilloForaneo,
		                        string completoForaneo
		                       ){
			idRuta=(idRuta=="")?"NULL":idRuta;
			try
			{
				base.getAbrirConexion("execute almacenar_ruta_apoyo '"+nombre+"'" +
				                      ",'"+turno+"'"+
				                      ",'"+sentido+"'"+
				                      ",'"+kilometros+"'"+
				                      ",'"+horaInicio+"'"+
				                      ",'"+intinerario+"'"+
				                      ",'"+sencilloCamioneta+"'"+
				                      ",'"+completoCamioneta+"'"+
				                      ",'"+sencilloCamion+"'"+
				                      ",'"+completoCamion+"'"+
				                      ",'"+sencilloForaneo+"'"+
				                      ",'"+completoForaneo+"'"+
				                      ","+idSubEmpresa+
				                      ","+zona+
				                      ","+foranea+
				                      ",'"+fecha+"'");
				base.comando.ExecuteNonQuery();
			}
				catch(Exception)
			{
				base.conexion.Close();
			}
		}
		
		public bool getInsertarExt(string idRuta,
		                            string idSubEmpresa,
		                            string nombre,
		                        	string turno,
		                        	string sentido,
		                        	string kilometros,
		                        	string horaInicio,
		                        	string zona,
		                        	string intinerario,
		                        	int foranea,
		                        	string fecha,
		                        	string sencilloCamion,
		                        	string completoCamion,
		                        	string sencilloCamioneta,
		                        	string completoCamioneta,
		                        	string sencilloForaneo,
		                        	string completoForaneo,
		                        	string tipo,
		                        	int velada,
		                        	int factura,
		                        	string descripcion)
		{
			bool respuesta=false;
			
			idRuta=(idRuta=="")?"NULL":idRuta;
			//try
			//{
				base.getAbrirConexion("execute almacenar_ruta_extra2 '"+nombre+"'" +
				                      ",'"+turno+"'"+
				                      ",'"+sentido+"'"+
				                      ",'"+kilometros+"'"+
				                      ",'"+horaInicio+"'"+
				                      ",'"+intinerario+"'"+
				                      ",'"+sencilloCamioneta+"'"+
				                      ",'"+completoCamioneta+"'"+
				                      ",'"+sencilloCamion+"'"+
				                      ",'"+completoCamion+"'"+
				                      ",'"+sencilloForaneo+"'"+
				                      ",'"+completoForaneo+"'"+
				                      ","+idSubEmpresa+
				                      ","+zona+
				                      ","+foranea+
				                      ",'"+fecha+"'"+
				                      ",'"+tipo+"'"+
				                      ",'"+velada+"'"+
				                      ",'"+factura+"'"+
									  ",'"+descripcion+"'");
				base.comando.ExecuteNonQuery();
			//}
			//	catch(Exception)
			//{
				base.conexion.Close();
				respuesta=false;
			//}
			//finally
			//{
			//	base.conexion.Close();
			//}
			return respuesta;
		}
		
		public bool getInsertarDom(string idRuta,
		                            string idSubEmpresa,
		                            string nombre,
		                        	string turno,
		                        	string sentido,
		                        	string kilometros,
		                        	string horaInicio,
		                        	string zona,
		                        	string intinerario,
		                        	int foranea,
		                        	string fecha,
		                        	string sencilloCamion,
		                        	string completoCamion,
		                        	string sencilloCamioneta,
		                        	string completoCamioneta,
		                        	string sencilloForaneo,
		                        	string completoForaneo,
		                        	string tipo,
		                        	string autoriza,
		                        	string usuario,
		                        	string domicilio,
		                        	string colonia,
		                        	string telefono,
		                        	string comentario,
		                            int ID_USUARIO,
		                        	int velada,
		                        	int factura)
		{
			bool respuesta=true;
			
			idRuta=(idRuta=="")?"NULL":idRuta;
			try
			{
				base.getAbrirConexion("execute almacenar_ruta_dom '"+nombre+"'" +
				                      ",'"+turno+"'"+
				                      ",'"+sentido+"'"+
				                      ",'"+kilometros+"'"+
				                      ",'"+horaInicio+"'"+
				                      ",'"+intinerario+"'"+
				                      ",'"+sencilloCamioneta+"'"+
				                      ",'"+completoCamioneta+"'"+
				                      ",'"+sencilloCamion+"'"+
				                      ",'"+completoCamion+"'"+
				                      ",'"+sencilloForaneo+"'"+
				                      ",'"+completoForaneo+"'"+
				                      ","+idSubEmpresa+
				                      ","+zona+
				                      ","+foranea+
				                      ",'"+fecha+"'"+
				                      ",'"+tipo+"'"+
				                      ",'"+autoriza+"'"+
				                      ",'"+usuario+"'"+
				                      ",'"+domicilio+"'"+
				                      ",'"+colonia+"'"+
				                      ",'"+telefono+"'"+
				                      ",'"+comentario+"'"+
				                      ",'"+ID_USUARIO+"'"+
				                      ",'"+velada+"'"+
				                      ",'"+factura+"'");
				base.comando.ExecuteNonQuery();
			}
				catch(Exception)
			{
				base.conexion.Close();
				respuesta=false;
			}
			finally
			{
				base.conexion.Close();
			}
			return respuesta;
		}
		#endregion
		
		#region OBTENER_DATOS_DE_LA_RUTA
		public void getDatoRuta(string idRuta,
		                       	TextBox nombre,
		                       	ComboBox turno,
		                       	ComboBox sentido,
		                       	TextBox kilometro,
		                       	NumericUpDown hora,
		                       	NumericUpDown minuto,
		                       	ComboBox zona,
		                       	TextBox sencilloCamion,
		                       	TextBox completoCamion,
		                       	TextBox sencilloCamioneta,
		                       	TextBox completoCamioneta,
		                       	TextBox sencilloForaneo,
		                       	TextBox completoForaneo,
		                       	TextBox intinerario,
		                       	CheckBox cbxL,
		                       	CheckBox cbxM,
		                       	CheckBox cbxMi,
		                       	CheckBox cbxJ,
		                       	CheckBox cbxV,
		                       	CheckBox cbxS,
		                       	CheckBox cbxD,
		                        CheckBox cbxForaneo){
			base.getAbrirConexion("select " +
			                      "Nombre," +
			                      "Turno," +
			                      "SENTIDO," +
			                      "Kilometros," +
			                      "HoraInicio," +
			                      "Intinerario," +
			                      "SencilloCamioneta," +
			                      "CompletoCamioneta," +
			                      "SencilloCamion," +
			                      "CompletoCamion," +
			                      "sencilloForaneo," +
			                      "completoForaneo," +
			                      "Zona, " +
			                      "Dia, "+
			                      "Foranea "+
			                      "from RUTA where ID="+idRuta);
			base.leer=comando.ExecuteReader();
			if(base.leer.Read()){
				if(leer["Foranea"].ToString()=="1")
			 		cbxForaneo.Checked=true;
				else
					cbxForaneo.Checked=false;
				
				nombre.Text				=leer["Nombre"].ToString();
				turno.SelectedItem		=leer["Turno"].ToString();
				sentido.Text			=leer["SENTIDO"].ToString();
				kilometro.Text			=leer["Kilometros"].ToString();
				intinerario.Text		=leer["Intinerario"].ToString();
				sencilloCamioneta.Text	=leer["SencilloCamioneta"].ToString();
				completoCamioneta.Text	=leer["CompletoCamioneta"].ToString();
				sencilloCamion.Text		=leer["SencilloCamion"].ToString();
				completoCamion.Text		=leer["CompletoCamion"].ToString();
				sencilloForaneo.Text	=leer["SencilloForaneo"].ToString();
				completoForaneo.Text	=leer["CompletoForaneo"].ToString();
				zona.SelectedItem=new Conexion_Servidor.Zona.SQL_Zona().getNombreZona(leer["Zona"].ToString());
				hora.Value				=((leer["HoraInicio"].ToString().Length==5)?Convert.ToDecimal(leer["HoraInicio"].ToString().Substring(0,2)):Convert.ToDecimal(leer["HoraInicio"].ToString().Substring(0,1)));
				minuto.Value			=Convert.ToDecimal(leer["HoraInicio"].ToString().Substring(3,2));
				String dia = leer["Dia"].ToString();
				for(int x=1; x<8; x++)
				{
					String sel = dia.Substring(x,1);
					if(x==1)
					{
						if(sel=="1"&&x==1)
							cbxL.Checked=true;
						else
							cbxL.Checked=false;
					}
					if(x==2)
					{
						if(sel=="1"&&x==2)
							cbxM.Checked=true;
						else
							cbxM.Checked=false;
					}
					if(x==3)
					{
						if(sel=="1"&&x==3)
							cbxMi.Checked=true;
						else
							cbxMi.Checked=false;
					}
					if(x==4)
					{
						if(sel=="1"&&x==4)
							cbxJ.Checked=true;
						else
							cbxJ.Checked=false;
					}
					if(x==5)
					{
						if(sel=="1"&&x==5)
							cbxV.Checked=true;
						else
							cbxV.Checked=false;
					}
					if(x==6)
					{
						if(sel=="1"&&x==6)
							cbxS.Checked=true;
						else
							cbxS.Checked=false;
					}
					if(x==7)
					{
						if(sel=="1"&&x==7)
							cbxD.Checked=true;
						else
							cbxD.Checked=false;
					}
				}
			}
			base.conexion.Close();
		}
		#endregion
		
		public Int64 getIDRuta()
		{
			Int64 respuesta=0;
			base.getAbrirConexion("select MAX(ID) id from RUTA");
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				respuesta=Convert.ToInt64(base.leer["id"]);
			}
			base.conexion.Close();
			return respuesta;
		}
		
		#region ELIMINAR_CLIENTE_DE_LA_BASE_DE_DATOS
		public void getEliminarRuta(string idRuta){
			try
			{
				base.getAbrirConexion("update RUTA set Dia='10000000', extra='1' where ID="+idRuta);
				base.comando.ExecuteNonQuery();
				base.comando.Clone();
			}
			catch
			{
				
			}
		}
		#endregion
		
		#region DATOS PARA RECONOCIMIENTO DE RUTAS
		public List<Interfaz.Operador.Dato.Reconocimiento> getDatosRec(String Consulta)
		{
			List<Interfaz.Operador.Dato.Reconocimiento> listaDatos=new List<Transportes_LAR.Interfaz.Operador.Dato.Reconocimiento>();
			
			base.getAbrirConexion(Consulta);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operador.Dato.Reconocimiento Datos = new Transportes_LAR.Interfaz.Operador.Dato.Reconocimiento();
				Datos.ID1			=base.leer["ID"].ToString();
				Datos.Nombre1		=base.leer["Nombre"].ToString();
				Datos.ID2			=base.leer["ID2"].ToString();
				Datos.Nombre2		=base.leer["Nombre2"].ToString();
				
				listaDatos.Add(Datos);
			}
			base.conexion.Close();
			return (listaDatos.Count>0)?listaDatos:null;
		}
		
		public List<Interfaz.Operador.Dato.Reconocimiento> getDatosRecEmp(String Consulta)
		{
			List<Interfaz.Operador.Dato.Reconocimiento> listaDatos=new List<Transportes_LAR.Interfaz.Operador.Dato.Reconocimiento>();
			
			base.getAbrirConexion(Consulta);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operador.Dato.Reconocimiento Datos = new Transportes_LAR.Interfaz.Operador.Dato.Reconocimiento();
				Datos.Nombre1	=base.leer["Nombre"].ToString();
				
				listaDatos.Add(Datos);
			}
			base.conexion.Close();
			return (listaDatos.Count>0)?listaDatos:null;
		}
		
		public List<Interfaz.Operador.Dato.Reconocimiento> getDatosRutasRec(String int_Op)
		{
			List<Interfaz.Operador.Dato.Reconocimiento> listaDatos=new List<Transportes_LAR.Interfaz.Operador.Dato.Reconocimiento>();
			
			base.getAbrirConexion("SELECT ID_GUIA ID, RUTA Nombre FROM GUIA_RUTA_OPERADOR where ID_OPERADOR="+int_Op);
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operador.Dato.Reconocimiento Datos = new Transportes_LAR.Interfaz.Operador.Dato.Reconocimiento();
				Datos.ID1			=base.leer["ID"].ToString();
				Datos.Nombre1		=base.leer["Nombre"].ToString();
				
				listaDatos.Add(Datos);
			}
			base.conexion.Close();
			return (listaDatos.Count>0)?listaDatos:null;
		}
		
		public void guardaReconocimiento(int idOp, String ruta)
		{
			base.getAbrirConexion("INSERT INTO GUIA_RUTA_OPERADOR VALUES ("+idOp+",'"+ruta+"')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void eliminarRec(int idGuia)
		{
			base.getAbrirConexion("delete from GUIA_RUTA_OPERADOR where ID_Guia="+idGuia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		#region ACTUALIZAR RUTA
		public void cambiar_extra_a_normal(String dias, String kilometros,/* String idSubEmpresa, */String hicio, String hFin, int idruta, int idUsuario){
			
			String tipo = "";
			String extra = "";
			String dia = "";
			String kilometro = "";
			String IdSubE= "";
			String horaInicio= "";
			String horaLlegada= "";
			
			base.getAbrirConexion("select * from RUTA where id = "+idruta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				tipo = base.leer["TIPO"].ToString();
				extra = base.leer["extra"].ToString();
				dia = base.leer["Dia"].ToString();
				kilometro = base.leer["Kilometros"].ToString();
				IdSubE = base.leer["IdSubEmpresa"].ToString();
				horaInicio = base.leer["HoraInicio"].ToString(); 
				horaLlegada = base.leer["HORA_LLEGADA"].ToString();					
			}
			base.conexion.Close();

			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'ID Ruta: "+idruta+", TIPO: "+tipo+", extra: "+extra+", Kilometros: "+kilometro+", Hora Inicio ="+horaInicio+", Hora LLegada = "+horaLlegada+"',(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idUsuario+", 'RUTA')");
			//base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'ID Ruta: "+idruta+", TIPO: "+tipo+", extra: "+extra+", Kilometros: "+kilometro+", IdSubEmpresa:"+IdSubE+", Hora Inicio ="+horaInicio+", Hora LLegada = "+horaLlegada+"',(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idUsuario+", 'RUTA')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();			
			
			string sentencia = "";
			sentencia = "UPDATE RUTA SET TIPO = 'NRM', extra = 0, Dia = '"+dias+"', Kilometros = '"+kilometros+"', HoraInicio = '"+hicio+"', HORA_LLEGADA = '"+hFin+"' where ID = "+idruta;			
			//sentencia = "UPDATE RUTA SET TIPO = 'NRM', extra = 0, Dia = '"+dias+"', Kilometros = '"+kilometros+"', IdSubEmpresa = "+idSubEmpresa+", HoraInicio = '"+hicio+"', HORA_LLEGADA = '"+hFin+"' where ID = "+idruta;			
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron Actualizados correctamente");
			mensaje.Show();
		}
		#endregion
		
		#region ELIMINAR RUTA NORMAL
		public void eliminarRuta(int idruta, int idUsuario){
			
			String dia= "";			
			base.getAbrirConexion("select DIA from RUTA where id = "+idruta);
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				dia = base.leer["DIA"].ToString();			
			}
			base.conexion.Close();
			
			base.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('ELIMINO', 'ID RUTA: "+idruta+", DIA: "+dia+" ', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+idUsuario+", 'RUTA')");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			string sentencia = "";
			sentencia = "UPDATE RUTA SET Dia = '10000000' where ID = "+idruta;
			base.getAbrirConexion(sentencia);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se elimino Correctamente la Ruta");
			mensaje.Show();
			
		}
		#endregion
		
		#region OBTENER ID CLIENTE POR EMPRESA
		public String IDCliente(String dato, String tVehiculo)
			{
				String ID = "";
				base.getAbrirConexion("select * from Cliente where DATO NOT LIKE '&EXTRA&' and tipo_cobro = '"+tVehiculo+"' and DATO = '"+dato+"'");
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					ID = base.leer["ID"].ToString();
				base.conexion.Close();
				return ID;
			}
		#endregion
		
		#region OBTENER HORAINICIO DE RUTA
		public String horaInicio(int id)
			{
				String horainicio = "";
				base.getAbrirConexion("select HoraInicio, HORA_LLEGADA from  RUTA where ID = "+id);
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					horainicio = base.leer["HoraInicio"].ToString();
				base.conexion.Close();
				return horainicio;
			}
		#endregion
		
		#region OBTENER NOMBRE CLIENTE POR EMPRESA
		public String NombreCliente(String dato, String tVehiculo)
			{
				String nombre = "";
				base.getAbrirConexion("select * from Cliente where DATO NOT LIKE '&EXTRA&' and tipo_cobro = '"+tVehiculo+"' and  DATO = '"+dato+"'");
				base.leer=base.comando.ExecuteReader();
				while(base.leer.Read())
					nombre = base.leer["Empresa"].ToString();
				base.conexion.Close();
				return nombre;
			}
		#endregion
		
	}
}
