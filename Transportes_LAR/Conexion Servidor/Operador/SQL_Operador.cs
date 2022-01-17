using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Transportes_LAR.Interfaz;

namespace Transportes_LAR.Conexion_Servidor.Operador
{
	public class SQL_Operador:SQL_Conexion
	{
		Interfaz.FormPrincipal principal = null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public SQL_Operador():base()
		{
			
		}
		
		public SQL_Operador(Interfaz.FormPrincipal principal):base()
		{
			this.principal=principal;
		}

		//--OBTENER_ADAPTADOR_DE_TABLA
		public DataTable getTabla(string consulta)
		{
			return base.getaAdaptadorTabla(consulta);
		}
		
		#region INSERTAR_OPERADOR
		public void getInsertarOperador(string nombre,string apellido_pat,string apellido_mat,
		                                string calle,string colonia,string numInterior,
		                                string numExterior,string municipio,string referencia1,
		                                string referencia2,string cp,string fechaNacimiento,
		                                string lugarNacimiento,string estadoNacimiento,
		                                string municipioNacimiento,string rfc,string curp,
		                                string imss,string estadoCivil,string estado,
		                                PictureBox imagen,string alias,string id_zona,
		                                bool imagenCargada, int foraneo, string numinfonavit)
		{
			string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(id_zona);
			string sentencia="";
			if(imagenCargada)
			{
				System.IO.MemoryStream ms = new System.IO.MemoryStream();
            	imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            	base.comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            	base.comando.Parameters["@foto"].Value = ms.GetBuffer();
				sentencia="execute almacenar_operador '"+nombre+"','"+apellido_pat+"','"+apellido_mat+"','"+calle+"','"+colonia+"','"+numInterior+"','"+numExterior+"','"+municipio+"','"+referencia1+"','"+referencia2+"',"+cp+",1,'"+fechaNacimiento+"','"+lugarNacimiento+"','"+estadoNacimiento+"','"+municipioNacimiento+"','"+rfc+"','"+curp+"','"+imss+"','"+estadoCivil+"','"+estado+"',@foto,'"+alias+"','"+idZona+"', "+foraneo+",'"+numinfonavit+"'";
			}
			else
				sentencia="execute almacenar_operador '"+nombre+"','"+apellido_pat+"','"+apellido_mat+"','"+calle+"','"+colonia+"','"+numInterior+"','"+numExterior+"','"+municipio+"','"+referencia1+"','"+referencia2+"',"+cp+",1,'"+fechaNacimiento+"','"+lugarNacimiento+"','"+estadoNacimiento+"','"+municipioNacimiento+"','"+rfc+"','"+curp+"','"+imss+"','"+estadoCivil+"','"+estado+"',null,'"+alias+"','"+idZona+"', "+foraneo+",'"+numinfonavit+"'";
		
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       		
       		sentencia="execute AUDITA_GRAL 'OPERADOR','"+getIdOperador()+"','INSERT','"+principal.idUsuario+"'";
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
   
       	}
		
		public void getInsertarExt(string nombre, string apellido_pat,string apellido_mat,
		                                string curp,string rfc,string fechaNacimiento, string estadoCivil,string lugarNacimiento,
		                                string estado, string municipio,
		                                string alias)
		{
			string sentencia="";
			sentencia="execute almacenar_op_externo '"+alias+"','"+nombre+"','"+apellido_pat+"','"+apellido_mat+"','"+curp+"','"+rfc+"','"+fechaNacimiento+"','"+estadoCivil+"','"+lugarNacimiento+"', 'JALISCO' , 'Guadalajara'";
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       		
       		sentencia="execute AUDITA_GRAL 'OPERADOR','"+getIdOperador()+"','INSERT','"+principal.idUsuario+"'";
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       	}
		
		public void getInsertarAdmin(string nombre,string apellido_pat,string apellido_mat,
		                                string calle,string colonia,string numInterior,
		                                string numExterior,string municipio,string referencia1,
		                                string referencia2,string cp,string fechaNacimiento,
		                                string lugarNacimiento,string estadoNacimiento,
		                                string municipioNacimiento,string rfc,string curp,
		                                string imss,string estadoCivil,string estado,
		                                PictureBox imagen,string alias,string id_zona,bool imagenCargada, string numinfonavit)
		{
			string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(id_zona);
			string sentencia="";
			if(imagenCargada){
				System.IO.MemoryStream ms = new System.IO.MemoryStream();
            	imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            	base.comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            	base.comando.Parameters["@foto"].Value = ms.GetBuffer();
				sentencia="execute almacenar_Admin '"+nombre+"','"+apellido_pat+"','"+apellido_mat+"','"+calle+"','"+colonia+"','"+numInterior+"','"+numExterior+"','"+municipio+"','"+referencia1+"','"+referencia2+"',"+cp+",1,'"+fechaNacimiento+"','"+lugarNacimiento+"','"+estadoNacimiento+"','"+municipioNacimiento+"','"+rfc+"','"+curp+"',"+imss+",'"+estadoCivil+"','"+estado+"',@foto,'"+alias+"','"+idZona+"','"+numinfonavit+"' ";
			}
			else
				sentencia="execute almacenar_Admin '"+nombre+"','"+apellido_pat+"','"+apellido_mat+"','"+calle+"','"+colonia+"','"+numInterior+"','"+numExterior+"','"+municipio+"','"+referencia1+"','"+referencia2+"',"+cp+",1,'"+fechaNacimiento+"','"+lugarNacimiento+"','"+estadoNacimiento+"','"+municipioNacimiento+"','"+rfc+"','"+curp+"',"+imss+",'"+estadoCivil+"','"+estado+"',null,'"+alias+"','"+idZona+"','"+numinfonavit+"' ";
			
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       		
       		sentencia="execute AUDITA_GRAL 'OPERADOR','"+getIdOperador()+"','INSERT','"+principal.idUsuario+"'";
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       	}
		#endregion
		
		#region OBTENER_DATOS_DEL_OPERADOR
		public void getOperador(string id,
		                        TextBox Nombre,
		                        TextBox ApellidoPat,
		                        TextBox ApellidoMat,
		                        TextBox Calle,
		                        TextBox Colonia,
		                        TextBox NumInterior,
		                        TextBox NumExterior,
		                        TextBox Municipio,
		                        TextBox Referencia1,
		                        TextBox Referencia2,
		                        TextBox CP,
		                        DateTimePicker FechaNacimiento,
		                        TextBox NacimientoLugar,
		                        TextBox NacimientoEstado,
		                        TextBox NacimientoMunicipio,
		                        TextBox RFC,
		                        TextBox Curp,
		                        TextBox Nss,
		                        ComboBox EstadoCivil,
		                        PictureBox Imagen,
		                        TextBox Alias,
		                        TextBox Estado,
		                        ComboBox estatus,
		                        ComboBox zona,
		                        CheckBox cbforaneo,
		                        TextBox txtNumInfonavit,
		                        TextBox txtCorreo)
		{
			base.getAbrirConexion("select  Nombre, Apellido_Pat, Apellido_Mat, Calle, Colonia, Num_Interior, Num_Exterior, Municipio, Referencia_Calle_Uno, Referencia_Calle_Dos, CP, Estatus, Fecha_Nacimiento, Lugar_Nacimiento, Estado_Nacimiento, Municipio_Nacimiento, RFC, CURP, IMSS, Estado_Civil, Estado, Imagen, Alias,(select zona.nombre from zona where zona.ID_Zona=operador.zona) as ZONA, foraneo, NUM_INFONAVIT, CORREO from operador where ID="+id);
			base.leer = base.comando.ExecuteReader();
            if(base.leer.Read()){
            	Alias.Text=					(base.leer["Alias"].ToString());
            	Nombre.Text=				(base.leer["Nombre"].ToString());
            	ApellidoPat.Text=			(base.leer["Apellido_Pat"].ToString());
            	ApellidoMat.Text=			(base.leer["Apellido_Mat"].ToString());
            	Calle.Text=					(base.leer["Calle"].ToString());
            	Colonia.Text=				(base.leer["Colonia"].ToString());
            	Estado.Text=				(base.leer["Estado"].ToString());
            	NumInterior.Text=			(base.leer["Num_Interior"].ToString());
            	NumExterior.Text=			(base.leer["Num_Exterior"].ToString());
            	Municipio.Text=				(base.leer["Municipio"].ToString());
            	Referencia1.Text=			(base.leer["Referencia_Calle_Uno"].ToString());
            	Referencia2.Text=			(base.leer["Referencia_Calle_Dos"].ToString());
            	CP.Text=					(base.leer["CP"].ToString());
            	NacimientoLugar.Text=		(base.leer["Lugar_Nacimiento"].ToString());
            	NacimientoEstado.Text=		(base.leer["Estado_Nacimiento"].ToString());
            	NacimientoMunicipio.Text=	(base.leer["Municipio_Nacimiento"].ToString());
            	RFC.Text=					(base.leer["RFC"].ToString());
            	Curp.Text=					(base.leer["CURP"].ToString());
            	Nss.Text=					(base.leer["IMSS"].ToString());
            	EstadoCivil.SelectedItem=	(base.leer["Estado_Civil"].ToString());
            	txtNumInfonavit.Text =		(base.leer["NUM_INFONAVIT"].ToString());
            	txtCorreo.Text =		(base.leer["CORREO"].ToString());
            	if((base.leer["foraneo"].ToString())=="1")
            		cbforaneo.Checked=true;
            	else
            		cbforaneo.Checked=false;

            	FechaNacimiento.Value = new DateTime (Convert.ToInt32((base.leer["Fecha_Nacimiento"].ToString()).Substring(6,4)),
            	                                      Convert.ToInt32((base.leer["Fecha_Nacimiento"].ToString()).Substring(3,2)),
            	                                      Convert.ToInt32((base.leer["Fecha_Nacimiento"].ToString()).Substring(0,2)));
            	zona.SelectedItem=(base.leer["ZONA"].ToString());
            	estatus.SelectedItem=(base.leer["Estatus"].ToString()=="True")?"ACTIVO":"INACTIVO";
      			try
      			{
      				byte[] imageBuffer = (byte[]) base.leer["Imagen"];
          			System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
         			Imagen.Image = Image.FromStream(ms);
      			}
      			catch
      			{
					Imagen.Image=  Image.FromFile("Camara.png");            		
      			}
            	
			}
            conexion.Close();
		}
		
		
		public void getOperador(string id,PictureBox imagen, TextBox alias , TextBox nombre , TextBox apellidoP , TextBox apellidoM, TextBox tipo)
		{
			getAbrirConexion("select Imagen,Alias,Nombre,Apellido_Pat,Apellido_Mat,tipo_empleado from OPERADOR where id="+id);
			leer=comando.ExecuteReader();
			if(leer.Read()){
				alias.Text		=leer["Alias"].ToString();
				nombre.Text		=leer["Nombre"].ToString();
				apellidoP.Text	=leer["Apellido_Pat"].ToString();
				apellidoM.Text	=leer["Apellido_Mat"].ToString();
				tipo.Text = leer["tipo_empleado"].ToString();
      			try
      			{
					imagen.Image=null;
      				byte[] imageBuffer = (byte[]) leer["Imagen"];
          			System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
         			imagen.Image = Image.FromStream(ms);
      			}
      			catch
      			{
					imagen.Image=Image.FromFile("Camara.png");;
      			}
			}
			conexion.Close();
		}
		
		public void getOperador(string id,PictureBox imagen, TextBox alias , TextBox nombre , TextBox apellidoP , TextBox apellidoM)
		{
			getAbrirConexion("select Imagen,Alias,Nombre,Apellido_Pat,Apellido_Mat from OPERADOR where id="+id);
			leer=comando.ExecuteReader();
			if(leer.Read()){
				alias.Text		=leer["Alias"].ToString();
				nombre.Text		=leer["Nombre"].ToString();
				apellidoP.Text	=leer["Apellido_Pat"].ToString();
				apellidoM.Text	=leer["Apellido_Mat"].ToString();
      			try
      			{
					imagen.Image=null;
      				byte[] imageBuffer = (byte[]) leer["Imagen"];
          			System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
         			imagen.Image = Image.FromStream(ms);
      			}
				catch
				{
					imagen.Image=Image.FromFile("Camara.png");;
      			}
			}
			conexion.Close();
		}
		
		public String getOpAlias(string id)
		{
			String alias = "";
			getAbrirConexion("select Alias from OPERADOR where id="+id);
			leer=comando.ExecuteReader();
			if(leer.Read()){
				alias=leer["Alias"].ToString();
			}
			conexion.Close();
			return alias;
		}
		#endregion
		
		#region VALIDA_EXISTE(OPERADOR - ALIAS)
		public bool getValidarExistencia(string AliasExistente)
		{
			base.getAbrirConexion("select Alias from operador where Alias='"+AliasExistente+"'");
			base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
            {
				AliasExistente= base.leer["Alias"].ToString();
				if(AliasExistente!="")
				{
					base.conexion.Close();
					return true;
				}
				else
				{
					base.conexion.Close();
					return false;
				}
			}
			base.conexion.Close();
			return false;
		}
		#endregion
		
		#region MODIFICAR_OPERADOR
		public void getModificarOperador(string nombre,
		                                 string apellido_pat,
		                                 string apellido_mat, 
		                                 string calle,
		                                 string colonia,
		                                 string numInterior,
		                                 string numExterior,
		                                 string municipio,
		                                 string referencia1,
		                                 string referencia2,
		                                 string cp,
		                                 string fechaNacimiento,
		                                 string lugarNacimiento,
		                                 string estadoNacimiento,
		                                 string municipioNacimiento,
		                                 string rfc,
		                                 string curp,
		                                 string imss,
		                                 string estadoCivil,
		                                 string estado,
		                                 PictureBox imagen,
		                                 string alias,
		                                 string id,
		                                 string situacion,
		                                 string id_zona,
		                                 bool dirImagen, 
		                                 bool foraneo,
		                                string txtnuminfonavit)
		{
			string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(id_zona);
			string sentencia="";
			int f=0;
			
			sentencia="execute AUDITA_GRAL 'OPERADOR','"+id+"','UPDATE','"+principal.idUsuario+"'";
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       		
			if(foraneo==true)
				f=1;
			else
				f=0;
			if(dirImagen){
				System.IO.MemoryStream ms = new System.IO.MemoryStream();
            	imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            	comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            	comando.Parameters["@foto"].Value = ms.GetBuffer();
				sentencia="begin transaction begin try execute modificar_operador  "+id+",'"+nombre+"','"+apellido_pat+"','"+apellido_mat+"','"+calle+"','"+colonia+"','"+numInterior+"','"+numExterior+"','"+municipio+"','"+referencia1+"','"+referencia2+"',"+cp+","+situacion+",'"+fechaNacimiento+"','"+lugarNacimiento+"','"+estadoNacimiento+"','"+municipioNacimiento+"','"+rfc+"','"+curp+"','"+imss+"','"+estadoCivil+"','"+estado+"',@foto,'"+alias+"','"+idZona+"','"+f+"','"+txtnuminfonavit+"' commit end try begin catch rollback end catch";
			}
			else
				sentencia="begin transaction begin try execute modificar_operador  "+id+",'"+nombre+"','"+apellido_pat+"','"+apellido_mat+"','"+calle+"','"+colonia+"','"+numInterior+"','"+numExterior+"','"+municipio+"','"+referencia1+"','"+referencia2+"',"+cp+","+situacion+",'"+fechaNacimiento+"','"+lugarNacimiento+"','"+estadoNacimiento+"','"+municipioNacimiento+"','"+rfc+"','"+curp+"','"+imss+"','"+estadoCivil+"','"+estado+"',null,'"+alias+"','"+idZona+"','"+f+"','"+txtnuminfonavit+"'  commit end try begin catch rollback end catch";
			
			base.getAbrirConexion(sentencia);
       		base.comando.ExecuteNonQuery();
       		base.conexion.Close();
       	}
		#endregion
       	
		#region OBTENER_ID_OPERADOR_RECIEN_INSERTADO
		public string getIdOperador()
		{
			string id="";
			
			base.getAbrirConexion("select MAX(id) id from operador");
			
			base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
				id=(base.leer["id"].ToString());
			base.conexion.Close();
			return id;
		}
		
		public string getIdOperador2(string CURP , string NSS, String tipo)
		{
			string id="";
			
			base.getAbrirConexion("select id from operador where CURP='"+CURP+"'");
			
			base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
				id = (base.leer["id"].ToString());
			base.conexion.Close();
			return id;
		}
		
		public string getIdOperador(string alias)
		{
			string id="";
			
			base.getAbrirConexion("select id from operador where alias='"+alias+"'");
			
			base.leer = base.comando.ExecuteReader();
            if(base.leer.Read())
				id = (base.leer["id"].ToString());
			else
				id = "167";
			base.conexion.Close();
			return id;
		}
		#endregion
		
		#region HISTORIAL_BAJA_DEL_OPERADOR
		public void getBajaOperador(string idOperador,string descripcion, string recontrato, string recomendacion)
		{
			base.getAbrirConexion("execute almacenar_historial_bajaOperador "+idOperador+",'"+descripcion+"', '"+recontrato+"','"+recomendacion+"'");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("update operador set indicador='BAJA' where id="+idOperador);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
			
			base.getAbrirConexion("update operadorContrato set Reingreso=0 where IdOperador="+idOperador);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public DateTime getUltimaFechaBaja(string idOperador)
		{
			DateTime FechaBaja = DateTime.Now;
			
			base.getAbrirConexion("select MAX(Fecha) FechaBaja from OperadorAltaBaja where IdOperador ="+idOperador+" and Registro='INACTIVO'");
			
			base.leer = base.comando.ExecuteReader();
			
            if(base.leer.Read())
            	FechaBaja = (Convert.ToDateTime(base.leer["FechaBaja"]));
            
			base.conexion.Close();
			
			return FechaBaja;
		}
		
		
		public void ActualizarUltimaFechaBaja(string idOperador,string FechaBaja)
		{
			String FechaMax = getUltimaFechaBaja(idOperador).ToShortDateString();
				
			base.getAbrirConexion("update OperadorAltaBaja set Fecha='"+FechaBaja+"' where IdOperador="+idOperador+" and Fecha='"+FechaMax+"'" );
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		#endregion
		
		public string SalarioBase(String id)
		{
			string booleano="";
			
			base.getAbrirConexion("select SUELDO_BASE from SUELDO WHERE ID_OPERADOR="+id);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            	booleano = (base.leer["SUELDO_BASE"].ToString());
            
			base.conexion.Close();
			
			return booleano;
		}
		
		public string Puesto(String id)
		{
			string booleano="";
			
			base.getAbrirConexion("select tipo_empleado from OPERADOR WHERE ID="+id);
			base.leer=base.comando.ExecuteReader();
            if(base.leer.Read())
            	booleano = (base.leer["tipo_empleado"].ToString());
			
			base.conexion.Close();
			
			return booleano;
		}
		
		public string getTraerAliasBaja(String id)
		{
			string sentencia = "";
			string alias="";
			
			if(id=="")
				id = "0";
			
			sentencia = "select alias from OPERADOR where ID ="+id;
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
				alias=(base.leer["alias"].ToString());
				
			base.conexion.Close();
			
			return alias;			
		}
		
		public String OperadoresActivos()
		{
			string activos = "";
			string sentencia = "";
			
			sentencia = "select Count(ID) as ID_OPERADOR " +
						"from OPERADOR " +
						"where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' ";
			
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
				activos = (base.leer["ID_OPERADOR"].ToString());
			
			base.conexion.Close();
			
			return activos;
		}
		
		public String OperadoresAsignados()
		{
			string activos = "";
			string sentencia = "";
			
			sentencia = "select  Count(o.ID) as ID_OPERADOR from OPERADOR O, Vehiculo V, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR AND V.ID=A.ID_UNIDAD AND O.Estatus='1' AND O.tipo_empleado='OPERADOR' and O.Alias!='Admvo'";
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
				activos = (base.leer["ID_OPERADOR"].ToString());
			
			base.conexion.Close();
			
			return activos;
		}
		
		public int OperadoresSinAsignar()
		{
			int sinAsiganar = Convert.ToInt32(OperadoresActivos()) - Convert.ToInt32(OperadoresAsignados());			
			return sinAsiganar;
		}
		
				
		public int EstatusDocumentos(String id_d, String id_o)
		{
			int Switch = 0;
			base.getAbrirConexion("select estatus " +
									"from op_doc " +
									"where id_o="+id_o+" and id_D="+id_d);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
		    	Switch = (Convert.ToInt32(base.leer["estatus"]));
			
			base.conexion.Close();
			return Switch;
		}
		
		public void InsertarDocumentos(String id_d, String id_o, int estatus)
		{
			String Switch = "";
			base.getAbrirConexion("select id_D " +
									"from op_doc " +
									"where id_o="+id_o+" and id_D="+id_d);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
				Switch = (base.leer["id_D"].ToString());

			base.conexion.Close();
			if(Switch=="")
			{
				base.getAbrirConexion("insert into op_doc(id_o, id_D, estatus) values ("+id_o+", "+id_d+", '"+estatus+"')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
		}
		
		public void ModificarDocumentos(String id_d, String id_o, int estatus)
		{
			String Switch = "";
			base.getAbrirConexion("select id_D " +
									"from op_doc " +
									"where id_o="+id_o+" and id_D="+id_d);
			base.leer=base.comando.ExecuteReader();
		    if(base.leer.Read())
				Switch = (base.leer["id_D"].ToString());
			
		    base.conexion.Close();
		    if(Switch=="")
			{
				base.getAbrirConexion("insert into op_doc(id_o, id_D, estatus) values ("+id_o+", "+id_d+", '"+estatus+"')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
		    else
		    {
				base.getAbrirConexion("UPDATE op_doc set estatus='"+estatus+"' where id_o="+id_o+" and id_D="+id_d+" ");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
		}
		
		#region DATOS OPERADORES PARA DESPACHO
		public List<Interfaz.Operaciones.Dato.Operador> getOperadores()
		{
			List<Interfaz.Operaciones.Dato.Operador> listDatos=new List<Transportes_LAR.Interfaz.Operaciones.Dato.Operador>();
			
			base.getAbrirConexion("select ID, Alias from OPERADOR where Estatus='1' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo')");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Operador datos=new Transportes_LAR.Interfaz.Operaciones.Dato.Operador();
				
				datos.id		=base.leer["ID"].ToString();
				datos.alias		=base.leer["Alias"].ToString();
				listDatos.Add(datos);
			}
			
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		
		public List<Interfaz.Operaciones.Dato.Unidades> getUnidades()
		{
			List<Interfaz.Operaciones.Dato.Unidades> listDatos=new List<Transportes_LAR.Interfaz.Operaciones.Dato.Unidades>();
			
			base.getAbrirConexion("SELECT V.ID, O.ID ID_OP, V.Numero, A.estatus, V.Tipo_Unidad FROM VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O WHERE V.ID=A.ID_UNIDAD AND A.ID_OPERADOR=O.ID");
			
			base.leer=base.comando.ExecuteReader();
			while(base.leer.Read())
			{
				Interfaz.Operaciones.Dato.Unidades datos=new Transportes_LAR.Interfaz.Operaciones.Dato.Unidades();
				
				datos.ID_U			=base.leer["ID"].ToString();
				datos.ID_OP			=base.leer["ID_OP"].ToString();
				datos.NUMERO		=base.leer["Numero"].ToString();
				datos.ESTATUS		=base.leer["estatus"].ToString();
				datos.TIPO			=base.leer["Tipo_Unidad"].ToString();
				listDatos.Add(datos);
			}
			
			base.conexion.Close();
			
			return (listDatos.Count>0)?listDatos:null;
		}
		#endregion
		
		public void ValidacionDocumentos(String ID, String estatus)
		{       		
			base.getAbrirConexion("UPDATE OPERADOR set INDICADOR='"+estatus+"' where ID="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void InsertarExperiencia(String Empresa, String Giro, String Tiempo, String ID)
		{
			base.getAbrirConexion("insert into EXPERIENCIA_LABORAL(Empresa, Giro, Tiempo, ID_OPERADOR) values ('"+Empresa+"', '"+Giro+"', '"+Tiempo+"', "+ID+")");
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public void EliminarExperiencia(String ID)
		{
			base.getAbrirConexion("delete from EXPERIENCIA_LABORAL where ID="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		public string getCasa(String id)
		{
			string sentencia = "";
			string CASA="";
			
			sentencia = "select R.tipo from PROPIA_RENTADA R, OPERADOR O where R.ID_OPERADOR=O.ID AND O.ID ="+id;
			base.getAbrirConexion(sentencia);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read())
			{
				CASA=(base.leer["tipo"].ToString());
			}
			else
			{
				CASA = "";
			}
			base.conexion.Close();
			
			return CASA;			
		}
		
		public void InsertarTipoCasa(String ID, String Tipo)
		{
			if(getCasa(ID)=="")
			{
				base.getAbrirConexion("insert into PROPIA_RENTADA(id_operador, tipo) values ('"+ID+"', '"+Tipo+"')");
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}
		}
		
		public void ModificarTipoCasa(String ID, String estatus)
		{       		
			base.getAbrirConexion("UPDATE PROPIA_RENTADA set tipo='"+estatus+"' where ID_operador="+ID);
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		}
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////// CONTRATACION  //////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				
		#region PARAMETRO		
		public void modificarParametros(string parametro1, string parametro2, string parametro3, string parametro4, string parametro5, string parametro6, Int16 id, Int32 id_usuario){		
			string consul = "update PARAMETROS_GENERALES set  PARAMETRO1 = '"+parametro1+"', PARAMETRO2 = '"+parametro2+"', PARAMETRO3 = '"+parametro3+"', PARAMETRO4 = '"+parametro4
						+"', PARAMETRO5 = '"+parametro5+"', PARAMETRO6 = '"+parametro6+"' where ID = "+id;
			base.getAbrirConexion(consul); 
			base.comando.ExecuteNonQuery(); 
			base.conexion.Close();	
		}	
		
		public String obtenerParametroPrueba2(Int16 id){			
			string parametro = "";			
			base.getAbrirConexion("SELECT * FROM PARAMETROS_GENERALES WHERE ID = "+id);
			base.leer=base.comando.ExecuteReader();
			if(base.leer.Read()){
				parametro = base.leer["PARAMETRO2"].ToString();
			}
			base.conexion.Close();			
			return parametro;			
		}
		
		public void setZonasFuente( List <Interfaz.Operador.Dato.Zonas> listZonas, List <Interfaz.Operador.Dato.Fuentes> listFuentes, Int32 id_usuario){
			string sentencia = "";
			try{
	       		for(int x=0; x< listZonas.Count; x++){					
	       			sentencia = @"EXECUTE guarda_Zona_Fuente "+listZonas[x].id+",'"+listZonas[x].tipo+"', '"+listZonas[x].nombre+"', '"+listZonas[x].estatus+"'";	       			
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();				
	       		}
			}catch(Exception ex){
				MessageBox.Show("ERROR al modificar las zonas "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				if(conexion != null)
					base.conexion.Close();
			}
			
			try{
	       		for(int x=0; x< listFuentes.Count; x++){					
	       			sentencia = @"EXECUTE guarda_Zona_Fuente "+listFuentes[x].id+",'"+listFuentes[x].tipo+"', '"+listFuentes[x].nombre+"', '"+listFuentes[x].estatus+"'";	       			
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();				
	       		}
			}catch(Exception ex){
				MessageBox.Show("ERROR al modificar las fuentes: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				if(conexion != null)
					base.conexion.Close();
			}
		}	
		#endregion
		
		#region VALIDA EXISTENCIA DE CANDIDATO A OPERADOR
		public int getValidaOperador(string nombre, string apP, string amM, string FECHA_NACIMIENTO){
			int respuesta = 0;			
			//string consulta = "SELECT * FROM OPERADOR WHERE Nombre = '"+nombre+"' AND Apellido_Pat = '"+apP+"' AND Apellido_Mat = '"+amM+"' and FECHA_NACIMIENTO = '"+FECHA_NACIMIENTO+"' ";
			string consulta = "SELECT * FROM OPERADOR WHERE Nombre = '"+nombre+"' AND Apellido_Pat = '"+apP+"' AND Apellido_Mat = '"+amM+"' ";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				if(base.leer["Estatus"].ToString() == "0" || base.leer["Estatus"].ToString() == "False")
					respuesta = 1;
				else
					respuesta = 2;
			}
			base.conexion.Close();			
			return respuesta;
		}
		
		public int getValidaImagenOperador(string ID_PREOPERADOR, string FOLIO){
			int respuesta = 0;
			
			string consulta = "SELECT * FROM PRE_OPERADOR_IMAGEN WHERE ID_PREOPERADOR = '"+ID_PREOPERADOR+"' AND FOLIO = '"+FOLIO+"'";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read())
				respuesta = 1;
			base.conexion.Close();			
			return respuesta;
		}
		
		public int getValidaDescuentosCandidato(string ID_PREOPERADOR, string FOLIO){
			int respuesta = 0;			
			string consulta = "SELECT * FROM PRE_OPERADOR_DESCUENTOS WHERE ID_PREOPERADOR = '"+ID_PREOPERADOR+"' AND FOLIO = '"+FOLIO+"'";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read())
				respuesta = 1;
			base.conexion.Close();			
			return respuesta;
		}
		
		public int getValidaCandidato(string nombre, string apP, string amM, string FECHA_NACIMIENTO){
			int respuesta = 0;
			
			//string consulta = "SELECT * FROM PRE_OPERADOR WHERE NOMBRE = '"+nombre+"' AND APELLIDO_PAT = '"+apP+"' AND APELLIDO_MAT = '"+amM+"' and FECHA_NACIMIENTO = '"+FECHA_NACIMIENTO+"'";
			string consulta = "SELECT * FROM PRE_OPERADOR WHERE NOMBRE = '"+nombre+"' AND APELLIDO_PAT = '"+apP+"' AND APELLIDO_MAT = '"+amM+"' ";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				if(base.leer["FLUJO"].ToString() != "CERRADO" && base.leer["FLUJO"].ToString() != "LLAMADA")
					respuesta = 1;
				if(base.leer["FLUJO"].ToString() == "CERRADO" && base.leer["ESTATUS"].ToString() == "RECHAZADO")
					respuesta = 2;
				if(base.leer["FLUJO"].ToString() == "CERRADO" && base.leer["ESTATUS"].ToString() == "CONTRATADO")
					respuesta = 3;
				if(base.leer["FLUJO"].ToString() == "VALIDADO" && base.leer["ESTATUS"].ToString() == "NUEVO")
					respuesta = 3;
				if(base.leer["FLUJO"].ToString() == "LLAMADA" && base.leer["ESTATUS"].ToString() == "CANCELADA")
					respuesta = 4;
				if(base.leer["ESTATUS"].ToString() == "BOLSA" && base.leer["FLUJO"].ToString() != "LLAMADA")
					respuesta = 5;
				if(base.leer["TRAMITE"].ToString() == "BOLSA DE TRABAJO" && base.leer["FLUJO"].ToString() != "LLAMADA")
					respuesta = 6;
				if(base.leer["FLUJO"].ToString() == "LLAMADA" && base.leer["ESTATUS"].ToString() != "CANCELADA")
					respuesta = 7;
				if(base.leer["ESTATUS"].ToString() == "BOLSA" && base.leer["FLUJO"].ToString() == "LLAMADA")
					respuesta = 8;
				if(base.leer["ESTATUS"].ToString() == "BOLSA DE TRABAJO" && base.leer["FLUJO"].ToString() == "LLAMADA")
					respuesta = 9;
			}
			base.conexion.Close();			
			return respuesta;
		}
		#endregion		
		
		#region OBTENER FOLIO, ID, ESTATUS, FLUJO		
		public Int64 getIDCandidato(string nombre, string apP, string amM, string FECHA_NACIMIENTO){
			Int64 respuesta = 0;			
			//string consulta = "SELECT id FROM PRE_OPERADOR WHERE Nombre = '"+nombre+"' AND Apellido_Pat = '"+apP+"' AND Apellido_Mat = '"+amM+"' and FECHA_NACIMIENTO = '"+FECHA_NACIMIENTO+"' ";
			string consulta = "SELECT id FROM PRE_OPERADOR WHERE Nombre = '"+nombre+"' AND Apellido_Pat = '"+apP+"' AND Apellido_Mat = '"+amM+"'";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				try{
					respuesta = Convert.ToInt64(base.leer["id"]); 
				}catch(Exception){
					respuesta = 0;
					if(base.conexion != null)
						base.conexion.Close();	
				};
			}
			base.conexion.Close();			
			return respuesta;
		}
		
		public int getFolio(string nombre, string apP, string amM, string FECHA_NACIMIENTO){
			int respuesta = 0;			
			//string consulta = "SELECT MAX(folio) folio FROM PRE_OPERADOR WHERE Nombre = '"+nombre+"' AND Apellido_Pat = '"+apP+"' AND Apellido_Mat = '"+amM+"' and FECHA_NACIMIENTO = '"+FECHA_NACIMIENTO+"'";
			string consulta = "SELECT MAX(folio) folio FROM PRE_OPERADOR WHERE Nombre = '"+nombre+"' AND Apellido_Pat = '"+apP+"' AND Apellido_Mat = '"+amM+"'";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				try{
					respuesta = Convert.ToInt32(base.leer["folio"]); 
				}catch(Exception){
				 	respuesta = 0;
				};
			}
			base.conexion.Close();			
			return respuesta+1;
		}
		
		public int getFolio(Int64 ID_PreOperador){
			int respuesta = 0;			
			string consulta = "SELECT MAX(folio) FROM PRE_OPERADOR WHERE ID = "+ID_PreOperador;
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				try{
					respuesta = Convert.ToInt32(base.leer["folio"]); 
				}catch(Exception){
				 	respuesta = 1;
				};
			}
			base.conexion.Close();			
			return respuesta;
		}
		
		public string getEstatus(Int64 ID_PreOperador){
			string respuesta = "";			
			string consulta = "SELECT ESTATUS FROM PRE_OPERADOR WHERE ID = "+ID_PreOperador;
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				try{
					respuesta = base.leer["ESTATUS"].ToString();
				}catch(Exception){
				 	respuesta = "SOLICITUD";
				};
			}
			base.conexion.Close();			
			return respuesta;
		}		
		
		public string getFlujo(Int64 ID_PreOperador){
			string respuesta = "";			
			string consulta = "SELECT FLUJO FROM PRE_OPERADOR WHERE ID = "+ID_PreOperador;
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				try{
					respuesta = base.leer["FLUJO"].ToString();
				}catch(Exception){
				 	respuesta = "NUEVO";
				};
			}
			base.conexion.Close();			
			return respuesta;
		}
		#endregion
		
		#region OBTENER ID MAXIMO CANDIDADO
		public Int64 obtenerIDCandidato(){
			Int64 id = 0;
			try{	
				base.getAbrirConexion("select MAX(ID) ID From PRE_OPERADOR");
				base.leer=base.comando.ExecuteReader();
				if(base.leer.Read())
					id = Convert.ToInt64(base.leer["ID"]);
				base.conexion.Close();
			}catch(Exception){
				id = 0;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}	
			return id;
		}
		#endregion
				
		#region INSERTA CANDIDADO
		public bool insertarLlamada(string NOMBRE, string APELLIDO_PAT, string APELLIDO_MAT, string FECHA_NACIMIENTO, string FUENTE, string DETALLE_FUENTE, string DIA, string ZONA, string FECHA_CITA, 
		                            string HORA_CITA, string DUAL, string DUALM, string DIR_TRASERA, string DIR_TRASERAM, string TRANSP_PERSONAL, string TRANSP_PERSONALM, string TIPO_ESTATAL, 
		                            string TIPO_FEDERAL, Int32 ID_USUARIO, DataGridView dgContactos, string TRAMITE, string FLUJO, string ESTATUS, string TIPO, string COLONIA, string BT, string MOTIVO_BT){
			bool respuesta = true;
			string sentencia = "";
			int folio = getFolio(NOMBRE, APELLIDO_PAT, APELLIDO_MAT, FECHA_NACIMIENTO);
			try{	
				sentencia = @"INSERT INTO PRE_OPERADOR(FOLIO, NOMBRE, APELLIDO_PAT, APELLIDO_MAT, COLONIA, FECHA_NACIMIENTO, ZONA, FUENTE, DETALLE_FUENTE, DIA, DUAL, DUALM, DIR_TRASERA, DIR_TRASERAM, 
							TRANSP_PERSONAL, TRANSP_PERSONALM, TIPO_ESTATAL, TIPO_FEDERAL, TRAMITE, BT, MOTIVO_BT, FLUJO, ESTATUS, TIPO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO, ID_OPERADOR)
									VALUES('"+folio+"', '"+NOMBRE+"', '"+APELLIDO_PAT+"', '"+APELLIDO_MAT+"', '"+COLONIA+"', '"+FECHA_NACIMIENTO+"', '"+ZONA+"', '"+FUENTE+"', '"+DETALLE_FUENTE+"', '"+DIA
									+"', '"+DUAL+"', '"+DUALM+"', '"+DIR_TRASERA+"', '"+DIR_TRASERAM+"', '"+TRANSP_PERSONAL+"', '"+TRANSP_PERSONALM+"', '"+TIPO_ESTATAL+"', '"+TIPO_FEDERAL
									+"', '"+TRAMITE+"', '"+BT+"', '"+MOTIVO_BT+"', '"+FLUJO+"', '"+ESTATUS+"', '"+TIPO+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"', null)";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL INSERTAR LA LLAMADA DEL CANDIDATO A OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			
			// SAVE  THE PHONE NUMBERS BY CONTACTS
			Int64 id_candidato = id_candidato = obtenerIDCandidato();
			if(respuesta){
				try{
					if(id_candidato > 0){
						for(int x=0; x<dgContactos.Rows.Count; x++){
							if(dgContactos[0,x].Value.ToString() != "0")
								sentencia = @"UPDATE TELEFONOS_PRE_OPERADOR SET FOLIO = '"+folio+"', TIPO = '"+dgContactos[1,x].Value.ToString()+"',  NUMERO = '"+dgContactos[2,x].Value.ToString()+"', RELACION = '"+dgContactos[3,x].Value.ToString()+"', DESCRIPCION = '"+dgContactos[4,x].Value.ToString()+"' WHERE ID = "+dgContactos[0,x].Value.ToString();
							else{
								sentencia = @"Insert into TELEFONOS_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, NUMERO, RELACION, DESCRIPCION, ESTATUS) values('"+id_candidato+"', '"+folio+"', '"+dgContactos[1,x].Value+"','"
			       						+dgContactos[2,x].Value+"','"+dgContactos[3,x].Value+"','"+dgContactos[4,x].Value+"', 'Activo')";
							}
							base.getAbrirConexion(sentencia);
				       		base.comando.ExecuteNonQuery();
				       		base.conexion.Close();		
		       			}
					}else						
						MessageBox.Show("ERROR AL INSERTAR EL TELÉFONO(s) DEL CANDIDATO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR EL TELÉFONO(s) DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			
			// REGISTRO PARA AGENDAR A CITA AL CANDIDATO
			if(respuesta && BT != "SI"){
				try{
					if(id_candidato > 0){
						sentencia = @"Insert into CITA_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, FECHA, HORA, ESTADO, MOTIVO_ESTADO, COMENTARIO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values('"+id_candidato+"', '"+folio+"', 'LLAMADA',  '"
		       				+FECHA_CITA+"','"+HORA_CITA+"', 'ACTIVA', '', '', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
		       			base.getAbrirConexion(sentencia);
			       		base.comando.ExecuteNonQuery();
			       		base.conexion.Close();
					}else
						MessageBox.Show("ERROR AL INSERTAR LA CITA DEL CANDIDATO AL OPERADOR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		
		public bool insertarCandidato(string NOMBRE, string APELLIDO_PAT, string APELLIDO_MAT, string COLONIA, string ZONA, string TIPO_CASA, string INFONAVIT, string INFONAVIT_MONTO, string FECHA_NACIMIENTO, string IMAGEN_PERSONAL, string SEXO, 
		                              string TATUAJES, string PIERCING, string FUENTE, string DETALLE_FUENTE, string DIA, List <Interfaz.Operador.Dato.Telefonos> ListarTelefonos, string DUAL, string DUALM, string DIR_TRASERA, string DIR_TRASERAM, 
		                              string TRANSP_PERSONAL, string TRANSP_PERSONALM, string TIPO_ESTATAL, string ESTADO_ESTATAL, string NUM_ESTATAL, string VIGENCIA_ESTATAL, string TIPO_FEDERAL, string ESTADO_FEDERAL, string NUM_FEDERAL, 
		                              string VIGENCIA_FEDERAL, string NUM_APTO_MEDICO, string VIGENCIA_APTO_MEDICO, string TRAMITE, string AJUSTE_LIC, Interfaz.Operador.Dato.LicenciasAjuste licAjuste, Int32 ID_USUARIO, PictureBox imagen, bool imagenCargada, 
		                              string FLUJO, string ESTATUS, string TIPO, int peinado, int pelo, int manosCara, int rasurado, int ropa, int calzado, int vestimenta, int	pantalon, int zapato, int presentacionCamisa1,
		                              int presentacionCamisa2, int presentacionCamisa3, int presentacionPantalon1, string ALTURA, string PESO, string BT, string MOTIVO_BT){
			bool respuesta = true;	
			string sentencia = "";		
			int folio = getFolio(NOMBRE, APELLIDO_PAT, APELLIDO_MAT, FECHA_NACIMIENTO);
			try{						
				if(imagenCargada){
					System.IO.MemoryStream ms = new System.IO.MemoryStream();
	            	imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
	            	base.comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
	            	base.comando.Parameters["@foto"].Value = ms.GetBuffer();
				}			
				sentencia = @"INSERT INTO PRE_OPERADOR(FOLIO, NOMBRE, APELLIDO_PAT, APELLIDO_MAT, COLONIA, ZONA, TIPO_CASA, INFONAVIT, INFONAVIT_MONTO, FECHA_NACIMIENTO, IMAGEN_PERSONAL, SEXO, TATUAJES, PIERCING, ALTURA, PESO, FUENTE, DETALLE_FUENTE, DIA,
  							DUAL, DUALM, DIR_TRASERA, DIR_TRASERAM, TRANSP_PERSONAL, TRANSP_PERSONALM, TIPO_ESTATAL, ESTADO_ESTATAL, NUM_ESTATAL, VIGENCIA_ESTATAL, TIPO_FEDERAL, ESTADO_FEDERAL, NUM_FEDERAL, VIGENCIA_FEDERAL, NUM_APTO_MEDICO, 
							VIGENCIA_APTO_MEDICO, TRAMITE, BT, MOTIVO_BT, FLUJO, ESTATUS, TIPO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO, ID_OPERADOR, IMAGEN)VALUES('"+folio+"', '"+NOMBRE+"', '"+APELLIDO_PAT+"', '"+APELLIDO_MAT+"', '"+COLONIA+"', '"+ZONA+"', '"+TIPO_CASA
							+"', '"+INFONAVIT+"', '"+INFONAVIT_MONTO+"', '"+FECHA_NACIMIENTO+"', '"+IMAGEN_PERSONAL+"', '"+SEXO+"', '"+TATUAJES+"', '"+PIERCING+"', '"+ALTURA+"', '"+PESO+"', '"+FUENTE+"', '"+DETALLE_FUENTE+"',  '"+DIA+"', '"+DUAL+"', '"+DUALM+"', '"+DIR_TRASERA
							+"', '"+DIR_TRASERAM+"', '"+TRANSP_PERSONAL+"', '"+TRANSP_PERSONALM+"', '"+TIPO_ESTATAL+"', '"+ESTADO_ESTATAL+"', '"+NUM_ESTATAL+"', '"+VIGENCIA_ESTATAL+"', '"+TIPO_FEDERAL+"', '"+ESTADO_FEDERAL+"',  '"+NUM_FEDERAL
							+"',  '"+VIGENCIA_FEDERAL+"', '"+NUM_APTO_MEDICO+"', '"+VIGENCIA_APTO_MEDICO+"', '"+TRAMITE+"', '"+BT+"', '"+MOTIVO_BT+"', '"+FLUJO+"', '"+ESTATUS+"', '"+TIPO+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"', null, "+((imagenCargada)? "@foto": "null" )+")";
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();				
					
				if(imagenCargada)
					base.comando.Parameters.RemoveAt("@foto");
					
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL INSERTAR EL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			
			Int64 id_candidato = obtenerIDCandidato();	
			if(respuesta){
				try{
		       		for(int x=0; x< ListarTelefonos.Count; x++){
		       			sentencia = @"Insert into TELEFONOS_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, NUMERO, RELACION, DESCRIPCION, ESTATUS) values('"+id_candidato+"', '"+folio+"','"+ListarTelefonos[x].tipo+"', '"+ListarTelefonos[x].numero+"', '"+ListarTelefonos[x].relacion+"', '"+ListarTelefonos[x].nombre+"', 'Activo')";
		       			base.getAbrirConexion(sentencia);
			       		base.comando.ExecuteNonQuery();
			       		base.conexion.Close();				
		       		}
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR EL TELÉFONO DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
				
				if(AJUSTE_LIC == "SI"){					
					try{					      		
		       			sentencia = @"Insert into PRE_OPERADOR_DESCUENTOS(ID_PREOPERADOR, FOLIO, ESTATAL_DESC, ESTATAL_VENCE, FEDERAL_DESC, FEDERAL_VENCE, MEDICO_DESC, MEDICO_VENCE, OBSERVACIONES) values('"+id_candidato+"', '"+folio+"','"+licAjuste.estatal+"','"+licAjuste.estatal_vence+"','"+licAjuste.federal+"','"+
		       							licAjuste.federal_vence+"','"+licAjuste.medico+"','"+licAjuste.medico_vence+"','"+licAjuste.observaciones+"')";
		       			base.getAbrirConexion(sentencia);
			       		base.comando.ExecuteNonQuery();
			       		base.conexion.Close();
					}catch(Exception ex){
						respuesta = false;
						MessageBox.Show("ERROR AL INSERTAR LOS DESCUENTOS DE LAS LICENCIAS DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}finally{
						if(conexion != null)
							base.conexion.Close();
					}
				}
				
				try{					      		
	       			sentencia = @"Insert into PRE_OPERADOR_IMAGEN(ID_PREOPERADOR, FOLIO, PEINADO, PELO_CORTO, MANOS_LIMPIAS, RASURADO, ROPA_LIMPIA, ALINEADO, LIMPIEZA_CALZADO, VETIMENTA, CAMISA, PANTALON, ZAPATO, PRESENTACIONCAMISA1, PRESENTACIONCAMISA2, PRESENTACIONCAMISA3, PRESENTACIONPANTALON1, COMENTARIO ) values('"
	       				+id_candidato+"', '"+folio+"','"+peinado+"','"+pelo+"','"+manosCara+"','"+rasurado+"','"+ropa+"','0','"+calzado+"', '"+vestimenta+"', '0', '"+pantalon+"', '"+zapato+"', '"+presentacionCamisa1+"', '"+presentacionCamisa2+"', '"+presentacionCamisa3+"', '"+presentacionPantalon1+"', '')";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR LOS PARÁMETROS DE LA IMAGEN DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}			
			return respuesta;
		}
		
		#endregion						
		
		#region INSERTA CITA
		public bool insertarCita( Int64 ID_PREOPERADOR, string folio, string TIPO, string FECHA_CITA, string HORA_CITA, Int32 ID_USUARIO, string ESTADO){	
			bool respuesta = true;
			string sentencia = "";
						
			if(respuesta){
				try{						     		
	       			sentencia = @"Insert into CITA_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, FECHA, HORA, ESTADO, MOTIVO_ESTADO, COMENTARIO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values('"
	       			+ID_PREOPERADOR+"', '"+folio+"', '"+TIPO+"',  '"+FECHA_CITA+"','"+HORA_CITA+"', '"+ESTADO+"', '', '', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		#endregion
		
		#region OBTENER ID DE CITA
		public Int64 getIdCita(Int64 ID_PreOperador, string folio, string TIPO, string ESTADO){
			Int64 respuesta = 0;			
			string consulta = "SELECT ID FROM CITA_PRE_OPERADOR WHERE ID_PREOPERADOR = "+ID_PreOperador+" AND FOLIO = '"+folio+"' AND  TIPO = '"+TIPO+"' AND ESTADO = '"+ESTADO+"' ORDER BY FECHA, HORA DESC";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read()){
				try{
					respuesta = Convert.ToInt64(base.leer["ID"]);
				}catch(Exception){
				 	respuesta = 00;
				};
			}
			base.conexion.Close();			
			return respuesta;
		}
		#endregion
		
		#region REAGENDAR CITA
		public bool reagendarCita( Int64 ID_PREOPERADOR, string folio, string TIPO, string FECHA_CITA, string HORA_CITA, string ESTADO, string MOTIVO_ESTADO, Int32 ID_USUARIO){	
			bool respuesta = true;
			string sentencia = "";
			
			Int64 IDCita = getIdCita(ID_PREOPERADOR, folio, TIPO, "ACTIVA");			
			try{						     		
       			sentencia = @"UPDATE CITA_PRE_OPERADOR SET ESTADO = 'CANCELADA' WHERE ID = "+IDCita;
       			base.getAbrirConexion(sentencia);
	       		base.comando.ExecuteNonQuery();
	       		base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL REAGENDAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
				
			if(respuesta){
				try{						     		
	       			sentencia = @"Insert into CITA_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, FECHA, HORA, ESTADO, MOTIVO_ESTADO, COMENTARIO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values('"
	       			+ID_PREOPERADOR+"', '"+folio+"', '"+TIPO+"',  '"+FECHA_CITA+"','"+HORA_CITA+"', '"+ESTADO+"', '"+MOTIVO_ESTADO+"',  '', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR LA NUEVA  CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		
		public bool reagendarCitaID( Int64 ID_PREOPERADOR, Int64 id_cita, string folio, string TIPO, string FECHA_CITA, string HORA_CITA, string ESTADO, string MOTIVO_ESTADO, Int32 ID_USUARIO){	
			bool respuesta = true;
			string sentencia = "";						
			try{						     		
       			sentencia = @"UPDATE CITA_PRE_OPERADOR SET ESTADO = 'CANCELADA' WHERE ID = "+id_cita;
       			base.getAbrirConexion(sentencia);
	       		base.comando.ExecuteNonQuery();
	       		base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL REAGENDAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
				
			if(respuesta){
				try{						     		
	       			sentencia = @"Insert into CITA_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, FECHA, HORA, ESTADO, MOTIVO_ESTADO, COMENTARIO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values('"
	       			+ID_PREOPERADOR+"', '"+folio+"', '"+TIPO+"',  '"+FECHA_CITA+"','"+HORA_CITA+"', '"+ESTADO+"', '"+MOTIVO_ESTADO+"', '', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR LA NUEVA  CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}	
		#endregion
				
		#region CONFIRMA CITA
		public bool confirmarCita(Int64 ID_CITA, string MOTIVO_ESTADO, Int32 ID_USUARIO){	
			bool respuesta = true;
			string sentencia = "";						
			try{						     		
       			sentencia = @"UPDATE CITA_PRE_OPERADOR SET MOTIVO_ESTADO = '"+MOTIVO_ESTADO+"' WHERE ID = "+ID_CITA;
       			base.getAbrirConexion(sentencia);
	       		base.comando.ExecuteNonQuery();
	       		base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL CONFIRMAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}	
		#endregion
		
		#region VALIDA CITA
		public bool validaCita(Int64 ID_CITA, string COMENTARIO, Int32 ID_USUARIO){	
			bool respuesta = true;
			string sentencia = "";						
			try{						     		
       			sentencia = @"UPDATE CITA_PRE_OPERADOR SET MOTIVO_ESTADO = 'VALIDADA', COMENTARIO = '"+COMENTARIO+"' WHERE ID = "+ID_CITA;
       			base.getAbrirConexion(sentencia);
	       		base.comando.ExecuteNonQuery();
	       		base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL VALIDAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			return respuesta;
		}	
		#endregion
		
		#region HISTORIAL CANDIDATO
		public bool HST_CANDIDATO(Int64 ID_PREOPERADOR, Int64 ID_USUARIO, string tipo){
			string sentencia = "";
			bool respuesta = true;
			
			string FOLIO = "", NOMBRE = "", APELLIDO_PAT = "", APELLIDO_MAT = "", FECHA_NACIMIENTO = "", LUGAR_NACIMIENTO = "", MUNICIPIO_NACIMIENTO = "", ESTADO_NACIMIENTO = "", ZONA = "", FUENTE = "", DETALLE_FUENTE = "", DIA = "", 
			CORREO = "", TATUAJES = "", PIERCING = "",  IMAGEN_PERSONAL = "",  SEXO = "",  PESO = "",  ALTURA = "", CALLE = "", NUM_EXT = "", NUM_INT = "", MUNICIPIO = "",COLONIA = "", CP = "", ESTADO = "",	CRUCE1 = "", CRUCE2 = "", 
			TIPO_CASA = "",	INFONAVIT = "", INFONAVIT_MONTO = "", DUAL = "", DUALM = "", DIR_TRASERA = "", DIR_TRASERAM = "", TRANSP_PERSONAL = "", TRANSP_PERSONALM = "", AJUSTE_LIC = "", TIPO_ESTATAL = "", ESTADO_ESTATAL = "", NUM_ESTATAL = "", 
			VIGENCIA_ESTATAL = "", TIPO_FEDERAL = "", ESTADO_FEDERAL = "", NUM_FEDERAL = "", VIGENCIA_FEDERAL = "", NUM_APTO_MEDICO = "", VIGENCIA_APTO_MEDICO = "", TRAMITE = "", FLUJO = "", ESTATUS = "", TIPO2 = "",  ID_OPERADOR = "", BT = "", MOTIVO_BT = "";
 			 
			try{
				sentencia = "SELECT * FROM PRE_OPERADOR  WHERE id ="+ID_PREOPERADOR;
				base.getAbrirConexion(sentencia);			
				base.leer = base.comando.ExecuteReader();
				if(base.leer.Read()){
					FOLIO = (( base.leer["FOLIO"] != null)? base.leer["FOLIO"].ToString(): "");
					NOMBRE = (( base.leer["NOMBRE"] != null)? base.leer["NOMBRE"].ToString(): "");
					APELLIDO_PAT = (( base.leer["APELLIDO_PAT"] != null)? base.leer["APELLIDO_PAT"].ToString(): "");
					APELLIDO_MAT = (( base.leer["APELLIDO_MAT"] != null)? base.leer["APELLIDO_MAT"].ToString(): "");
					FECHA_NACIMIENTO = (( base.leer["FECHA_NACIMIENTO"] != null)? (( base.leer["FECHA_NACIMIENTO"].ToString().Length > 9)? base.leer["FECHA_NACIMIENTO"].ToString().Substring(0, 10): base.leer["FECHA_NACIMIENTO"].ToString() ): "");
					LUGAR_NACIMIENTO = (( base.leer["LUGAR_NACIMIENTO"] != null)? base.leer["LUGAR_NACIMIENTO"].ToString(): "");
					MUNICIPIO_NACIMIENTO = (( base.leer["MUNICIPIO_NACIMIENTO"] != null)? base.leer["MUNICIPIO_NACIMIENTO"].ToString(): "");
					ESTADO_NACIMIENTO = (( base.leer["ESTADO_NACIMIENTO"] != null)? base.leer["ESTADO_NACIMIENTO"].ToString(): "");
					ZONA = (( base.leer["ZONA"] != null)? base.leer["ZONA"].ToString(): "");
					FUENTE = (( base.leer["FUENTE"] != null)? base.leer["FUENTE"].ToString(): "");
					DETALLE_FUENTE = (( base.leer["DETALLE_FUENTE"] != null)? base.leer["DETALLE_FUENTE"].ToString(): "");
					DIA = (( base.leer["DIA"] != null)? base.leer["DIA"].ToString(): "");
					CORREO = (( base.leer["CORREO"] != null)? base.leer["CORREO"].ToString(): "");
					IMAGEN_PERSONAL = (( base.leer["IMAGEN_PERSONAL"] != null)? base.leer["IMAGEN_PERSONAL"].ToString(): "");
					SEXO = (( base.leer["SEXO"] != null)? base.leer["SEXO"].ToString(): "");
					PESO = (( base.leer["PESO"] != null)? base.leer["PESO"].ToString(): "");
					ALTURA = (( base.leer["ALTURA"] != null)? base.leer["ALTURA"].ToString(): "");
					TATUAJES = (( base.leer["TATUAJES"] != null)? base.leer["TATUAJES"].ToString(): "");
					PIERCING = (( base.leer["PIERCING"] != null)? base.leer["PIERCING"].ToString(): "");
					CALLE = (( base.leer["CALLE"] != null)? base.leer["CALLE"].ToString(): "");
					NUM_EXT = (( base.leer["NUM_EXT"] != null)? base.leer["NUM_EXT"].ToString(): "");
					NUM_INT = (( base.leer["NUM_INT"] != null)? base.leer["NUM_INT"].ToString(): "");
					MUNICIPIO = (( base.leer["MUNICIPIO"] != null)? base.leer["MUNICIPIO"].ToString(): "");
					COLONIA = (( base.leer["COLONIA"] != null)? base.leer["COLONIA"].ToString(): "");
					CP = (( base.leer["CP"] != null)? base.leer["CP"].ToString(): "");
					ESTADO = (( base.leer["ESTADO"] != null)? base.leer["ESTADO"].ToString(): "");
					CRUCE1 = (( base.leer["CRUCE1"] != null)? base.leer["CRUCE1"].ToString(): "");
					CRUCE2 = (( base.leer["CRUCE2"] != null)? base.leer["CRUCE2"].ToString(): "");
					TIPO_CASA = (( base.leer["TIPO_CASA"] != null)? base.leer["TIPO_CASA"].ToString(): "");
					INFONAVIT = (( base.leer["INFONAVIT"] != null)? base.leer["INFONAVIT"].ToString(): "");
					INFONAVIT_MONTO = (( base.leer["INFONAVIT_MONTO"] != null)? base.leer["INFONAVIT_MONTO"].ToString(): "");
					DUAL = (( base.leer["DUAL"] != null)? base.leer["DUAL"].ToString(): "");
					DUALM = (( base.leer["DUALM"] != null)? base.leer["DUALM"].ToString(): "");
					DIR_TRASERA = (( base.leer["DIR_TRASERA"] != null)? base.leer["DIR_TRASERA"].ToString(): "");
					DIR_TRASERAM = (( base.leer["DIR_TRASERAM"] != null)? base.leer["DIR_TRASERAM"].ToString(): "");
					TRANSP_PERSONAL = (( base.leer["TRANSP_PERSONAL"] != null)? base.leer["TRANSP_PERSONAL"].ToString(): "");
					TRANSP_PERSONALM = (( base.leer["TRANSP_PERSONALM"] != null)? base.leer["TRANSP_PERSONALM"].ToString(): "");
					AJUSTE_LIC = (( base.leer["AJUSTE_LIC"] != null)? base.leer["AJUSTE_LIC"].ToString(): "");
					
					TIPO_ESTATAL = (( base.leer["TIPO_ESTATAL"] != null)? base.leer["TIPO_ESTATAL"].ToString(): "");
					ESTADO_ESTATAL = (( base.leer["ESTADO_ESTATAL"] != null)? base.leer["ESTADO_ESTATAL"].ToString(): "");
					NUM_ESTATAL = (( base.leer["NUM_ESTATAL"] != null)? base.leer["NUM_ESTATAL"].ToString(): "");
					VIGENCIA_ESTATAL = (( base.leer["VIGENCIA_ESTATAL"] != null)? (( base.leer["VIGENCIA_ESTATAL"].ToString().Length > 9)? base.leer["VIGENCIA_ESTATAL"].ToString().Substring(0, 10): base.leer["VIGENCIA_ESTATAL"].ToString() ): "");
					TIPO_FEDERAL = (( base.leer["TIPO_FEDERAL"] != null)? base.leer["TIPO_FEDERAL"].ToString(): "");
					ESTADO_FEDERAL = (( base.leer["ESTADO_FEDERAL"] != null)? base.leer["ESTADO_FEDERAL"].ToString(): "");
					NUM_FEDERAL = (( base.leer["NUM_FEDERAL"] != null)? base.leer["NUM_FEDERAL"].ToString(): "");
					VIGENCIA_FEDERAL = (( base.leer["VIGENCIA_FEDERAL"] != null)? (( base.leer["VIGENCIA_FEDERAL"].ToString().Length > 9)? base.leer["VIGENCIA_FEDERAL"].ToString().Substring(0, 10): base.leer["VIGENCIA_FEDERAL"].ToString() ): "");
					NUM_APTO_MEDICO = (( base.leer["NUM_APTO_MEDICO"] != null)? base.leer["NUM_APTO_MEDICO"].ToString(): "");
					VIGENCIA_APTO_MEDICO = (( base.leer["VIGENCIA_APTO_MEDICO"] != null)? (( base.leer["VIGENCIA_APTO_MEDICO"].ToString().Length > 9)? base.leer["VIGENCIA_APTO_MEDICO"].ToString().Substring(0, 10): base.leer["VIGENCIA_APTO_MEDICO"].ToString() ): "");
					TRAMITE = (( base.leer["TRAMITE"] != null)? base.leer["TRAMITE"].ToString(): "");
					BT = (( base.leer["BT"] != null)? base.leer["BT"].ToString(): "");
					MOTIVO_BT = (( base.leer["MOTIVO_BT"] != null)? base.leer["MOTIVO_BT"].ToString(): "");
					FLUJO = (( base.leer["FLUJO"] != null)? base.leer["FLUJO"].ToString(): "");
					ESTATUS = (( base.leer["ESTATUS"] != null)? base.leer["ESTATUS"].ToString(): "");
					TIPO2 = (( base.leer["TIPO"] != null)? base.leer["TIPO"].ToString(): "");
					ID_OPERADOR = (( base.leer["ID_OPERADOR"] != null)? base.leer["ID_OPERADOR"].ToString(): "");
				}
				base.conexion.Close();
			}catch(Exception){
				respuesta = false;
			}finally{
				if(base.conexion != null)
					base.conexion.Close();
			}
			
			if(respuesta){
				try{
					sentencia = @"INSERT INTO HSTPRE_OPERADOR(ID_PREOPERADOR, TIPO, FOLIO, NOMBRE, APELLIDO_PAT, APELLIDO_MAT, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, MUNICIPIO_NACIMIENTO, ESTADO_NACIMIENTO, ZONA, FUENTE, DETALLE_FUENTE, DIA, CORREO, TATUAJES, PIERCING,
					IMAGEN_PERSONAL, SEXO, PESO, ALTURA, CALLE, NUM_EXT, NUM_INT, MUNICIPIO, COLONIA, CP, ESTADO, CRUCE1, CRUCE2, TIPO_CASA, INFONAVIT, INFONAVIT_MONTO, DUAL, DUALM, DIR_TRASERA, DIR_TRASERAM, TRANSP_PERSONAL, TRANSP_PERSONALM, AJUSTE_LIC, TIPO_ESTATAL, 
					ESTADO_ESTATAL, NUM_ESTATAL,	VIGENCIA_ESTATAL, TIPO_FEDERAL, ESTADO_FEDERAL,	NUM_FEDERAL, VIGENCIA_FEDERAL, NUM_APTO_MEDICO, VIGENCIA_APTO_MEDICO, TRAMITE, BT, MOTIVO_BT, FLUJO, ESTATUS, TIPO2, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO, ID_OPERADOR )VALUES(  '"
						+ID_PREOPERADOR+"', '"+tipo+"', '"+FOLIO+"', '"+NOMBRE+"', '"+APELLIDO_PAT+"', '"+APELLIDO_MAT+"', '"+FECHA_NACIMIENTO+"', '"+LUGAR_NACIMIENTO+"', '"+MUNICIPIO_NACIMIENTO+"', '"+ESTADO_NACIMIENTO+"', '"+ZONA+"', '"+FUENTE+"',  '"+DETALLE_FUENTE
						+"', '"+DIA+"', '"+CORREO+"', '"+TATUAJES+"', '"+PIERCING+"', '"+IMAGEN_PERSONAL+"', '"+SEXO+"', '"+PESO+"', '"+ALTURA+"', '"+CALLE+"', '"+NUM_EXT+"', '"+NUM_INT+"', '"+MUNICIPIO+"', '"+COLONIA+"', '"+CP+"', '"+ESTADO+"', '"+CRUCE1+"', '"+CRUCE2
						+"', '"+TIPO_CASA+"', '"+INFONAVIT+"', '"+INFONAVIT_MONTO+"',  '"+DUAL+"', '"+DUALM+"',  '"+DIR_TRASERA+"', '"+DIR_TRASERAM+"', '"+TRANSP_PERSONAL+"', '"+TRANSP_PERSONALM+"', '"+AJUSTE_LIC+"', '"+TIPO_ESTATAL+"', '"+ESTADO_ESTATAL+"', '"+NUM_ESTATAL
						+"', '"+VIGENCIA_ESTATAL+"', '"+TIPO_FEDERAL+"', '"+ESTADO_FEDERAL+"', '"+NUM_FEDERAL+"', '"+VIGENCIA_FEDERAL+"', '"+NUM_APTO_MEDICO+"', '"+VIGENCIA_APTO_MEDICO+"', '"+TRAMITE+"', '"+BT+"', '"+MOTIVO_BT+"', '"+FLUJO+"', '"+ESTATUS+"', '"+TIPO2
						+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), '"+ID_USUARIO+"', '"+ID_OPERADOR+"')";
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();				
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR al insertar en el historial del candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(base.conexion != null)
						base.conexion.Close();
				}
			}		
			return respuesta;
		}	
		#endregion	
		
		#region MODIFICA CANDIDATO
		public bool updateLlamada(string NOMBRE, string APELLIDO_PAT, string APELLIDO_MAT, string FECHA_NACIMIENTO, string FUENTE, string DETALLE_FUENTE, string DIA, string ZONA, string FECHA_CITA, 
		                            string HORA_CITA, string DUAL, string DUALM, string DIR_TRASERA, string DIR_TRASERAM, string TRANSP_PERSONAL, string TRANSP_PERSONALM, string TIPO_ESTATAL, 
		                            string TIPO_FEDERAL, Int32 ID_USUARIO, DataGridView dgContactos, string TRAMITE, string TIPO, string COLONIA, string BT, string MOTIVO_BT, Int64 ID_PREOPERADOR ){
			bool respuesta = true;
			string sentencia = "";
			int folio = getFolio(ID_PREOPERADOR);
			respuesta = HST_CANDIDATO(ID_PREOPERADOR, ID_USUARIO, "MODIFICACIÓN");
			try{	
				sentencia = @"UPDATE PRE_OPERADOR SET FOLIO = '"+folio+"', NOMBRE = '"+NOMBRE+"', APELLIDO_PAT = '"+APELLIDO_PAT+"', APELLIDO_MAT = '"+APELLIDO_MAT+"', COLONIA = '"+COLONIA+"', FECHA_NACIMIENTO = '"+FECHA_NACIMIENTO
					+"', ZONA = '"+ZONA+"', FUENTE = '"+FUENTE+"', DETALLE_FUENTE = '"+DETALLE_FUENTE+"', DIA = '"+DIA+"', DUAL = '"+DUAL+"', DUALM = '"+DUALM+"', DIR_TRASERA = '"+DIR_TRASERA+"', DIR_TRASERAM = '"+DIR_TRASERAM
					+"', TRANSP_PERSONAL = '"+TRANSP_PERSONAL+"', TRANSP_PERSONALM = '"+TRANSP_PERSONALM+"', TIPO_ESTATAL = '"+TIPO_ESTATAL+"', TIPO_FEDERAL = '"+TIPO_FEDERAL+"', TRAMITE = '"+TRAMITE+"', BT = '"+BT
					+"', MOTIVO_BT = '"+MOTIVO_BT+"' WHERE ID = "+ID_PREOPERADOR;
				base.getAbrirConexion(sentencia);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL MODIFICAR LA LLAMADA DEL CANDIDATO A OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			
			if(respuesta){
				try{
					if(ID_PREOPERADOR > 0){
						for(int x=0; x<dgContactos.Rows.Count; x++){
							if(dgContactos[0,x].Value.ToString() != "0")
								sentencia = @"UPDATE TELEFONOS_PRE_OPERADOR SET FOLIO = '"+folio+"', TIPO = '"+dgContactos[1,x].Value.ToString()+"',  NUMERO = '"+dgContactos[2,x].Value.ToString()+"', RELACION = '"+dgContactos[3,x].Value.ToString()+"', DESCRIPCION = '"+dgContactos[4,x].Value.ToString()+"' WHERE ID = "+dgContactos[0,x].Value.ToString();
							else{
								sentencia = @"Insert into TELEFONOS_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, NUMERO, RELACION, DESCRIPCION, ESTATUS) values('"+ID_PREOPERADOR+"', '"+folio+"', '"+dgContactos[1,x].Value+"','"
			       						+dgContactos[2,x].Value+"','"+dgContactos[3,x].Value+"','"+dgContactos[4,x].Value+"', 'Activo')";
							}
							base.getAbrirConexion(sentencia);
				       		base.comando.ExecuteNonQuery();
				       		base.conexion.Close();		
		       			}
					}else						
						MessageBox.Show("ERROR AL INSERTAR EL TELÉFONO(s) DEL CANDIDATO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR EL TELÉFONO(s) DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			
			// REGISTRO PARA AGENDAR A CITA AL CANDIDATO
			if(respuesta && BT != "SI"){				
				try{
					if(ID_PREOPERADOR > 0){
						reagendarCita( ID_PREOPERADOR, folio.ToString(), "LLAMADA", FECHA_CITA, HORA_CITA, "ACTIVA", "REAGENDAR", ID_USUARIO);
					}else
						MessageBox.Show("ERROR AL INSERTAR LA CITA DEL CANDIDATO AL OPERADOR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		
		
		
		public bool modificaCandidato(string NOMBRE, string APELLIDO_PAT, string APELLIDO_MAT, string COLONIA, string ZONA, string TIPO_CASA, string INFONAVIT, string INFONAVIT_MONTO, string FECHA_NACIMIENTO, string IMAGEN_PERSONAL, string SEXO, 
		                              string TATUAJES, string PIERCING, string FUENTE, string DETALLE_FUENTE, string DIA, List <Interfaz.Operador.Dato.Telefonos> ListarTelefonos, string DUAL, string DUALM, string DIR_TRASERA, string DIR_TRASERAM, 
		                              string TRANSP_PERSONAL, string TRANSP_PERSONALM, string TIPO_ESTATAL, string ESTADO_ESTATAL, string NUM_ESTATAL, string VIGENCIA_ESTATAL, string TIPO_FEDERAL, string ESTADO_FEDERAL, string NUM_FEDERAL, 
		                              string VIGENCIA_FEDERAL, string NUM_APTO_MEDICO, string VIGENCIA_APTO_MEDICO, string TRAMITE, string AJUSTE_LIC, Interfaz.Operador.Dato.LicenciasAjuste licAjuste, Int32 ID_USUARIO, PictureBox imagen, bool imagenCargada, 
		                              string ESTATUS, string TIPO, string flujo, int banderaFolio, Int64 ID_PREOPERADOR, int peinado, int pelo, int manosCara, int rasurado, int ropa, int calzado, int vestimenta, int	pantalon, int zapato, int presentacionCamisa1,
		                              int presentacionCamisa2, int presentacionCamisa3, int presentacionPantalon1, string ALTURA, string PESO, string BT, string MOTIVO_BT){
			bool respuesta = true;
			string sentencia = "";
			
			int folio = ((banderaFolio == 1)? getFolio(NOMBRE, APELLIDO_PAT, APELLIDO_MAT, FECHA_NACIMIENTO) : getFolio(ID_PREOPERADOR));
			respuesta = HST_CANDIDATO(ID_PREOPERADOR, ID_USUARIO, "MODIFICACIÓN");
			try{
				if(imagenCargada){
					System.IO.MemoryStream ms = new System.IO.MemoryStream();
	            	imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
	            	base.comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
	            	base.comando.Parameters["@foto"].Value = ms.GetBuffer();
				}				
			}catch(Exception ex){
				imagenCargada = false;
				MessageBox.Show("ERROR no se guardó la foto del candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if(respuesta){
				try{
						sentencia = @"UPDATE PRE_OPERADOR SET FOLIO = '"+folio+"', NOMBRE = '"+NOMBRE+"',  APELLIDO_PAT = '"+APELLIDO_PAT+"',  APELLIDO_MAT = '"+APELLIDO_MAT+"',  COLONIA = '"+COLONIA+"',  ZONA = '"+ZONA+"',  TIPO_CASA = '"+TIPO_CASA
							+"', INFONAVIT = '"+INFONAVIT+"',  INFONAVIT_MONTO = '"+INFONAVIT_MONTO+"',  FECHA_NACIMIENTO = '"+FECHA_NACIMIENTO+"', IMAGEN_PERSONAL = '"+IMAGEN_PERSONAL+"',  SEXO = '"+SEXO+"', TATUAJES = '"+TATUAJES+"',  PIERCING = '"+PIERCING
							+"', ALTURA = '"+ALTURA+"', PESO = '"+PESO+"',  FUENTE = '"+FUENTE+"', DETALLE_FUENTE = '"+DETALLE_FUENTE+"',  DIA = '"+DIA+"', DUAL = '"+DUAL+"', DUALM = '"+DUALM+"', DIR_TRASERA = '"+DIR_TRASERA+"', DIR_TRASERAM = '"+DIR_TRASERAM
							+"', TRANSP_PERSONAL = '"+TRANSP_PERSONAL+"', TRANSP_PERSONALM = '"+TRANSP_PERSONALM+"',  TIPO_ESTATAL = '"+TIPO_ESTATAL+"', ESTADO_ESTATAL = '"+ESTADO_ESTATAL+"',  NUM_ESTATAL = '"+NUM_ESTATAL+"',  VIGENCIA_ESTATAL = '"+VIGENCIA_ESTATAL
							+"', TIPO_FEDERAL = '"+TIPO_FEDERAL+"', ESTADO_FEDERAL = '"+ESTADO_FEDERAL+"',  NUM_FEDERAL = '"+NUM_FEDERAL+"', VIGENCIA_FEDERAL = '"+VIGENCIA_FEDERAL+"', NUM_APTO_MEDICO = '"+NUM_APTO_MEDICO+"', VIGENCIA_APTO_MEDICO = '"+VIGENCIA_APTO_MEDICO
							+"', TRAMITE = '"+TRAMITE+"', BT = '"+BT+"', MOTIVO_BT = '"+MOTIVO_BT+"', AJUSTE_LIC = '"+AJUSTE_LIC+"', IMAGEN = "+((imagenCargada)? "@foto": "null" )+", ESTATUS = '"+ESTATUS+"', FLUJO = '"+flujo+"', TIPO = '"+TIPO+"' WHERE ID = "+ID_PREOPERADOR;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
					if(imagenCargada)
						base.comando.Parameters.RemoveAt("@foto");
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR al modificar los datos del candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			
			if(respuesta){
				try{
		       		for(int x=0; x< ListarTelefonos.Count; x++){
						if(ListarTelefonos[x].id == "0")
		       				sentencia = @"Insert into TELEFONOS_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, NUMERO, RELACION, DESCRIPCION, ESTATUS) values('"+ID_PREOPERADOR+"', '"+folio+"','"+ListarTelefonos[x].tipo+"', '"+ListarTelefonos[x].numero+"', '"+ListarTelefonos[x].relacion+"', '"+ListarTelefonos[x].nombre+"', '"+ListarTelefonos[x].estatus+"')";
						else
							sentencia = @"UPDATE TELEFONOS_PRE_OPERADOR SET FOLIO = '"+folio+"', TIPO = '"+ListarTelefonos[x].tipo+"', NUMERO = '"+ListarTelefonos[x].numero+"', RELACION = '"+ListarTelefonos[x].relacion+"', DESCRIPCION = '"+ListarTelefonos[x].nombre+"', ESTATUS = '"+ListarTelefonos[x].estatus+"' WHERE ID = "+ListarTelefonos[x].id;
						base.getAbrirConexion(sentencia);
			       		base.comando.ExecuteNonQuery();
			       		base.conexion.Close();				
		       		}
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR EL TELÉFONO DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
				
				if(AJUSTE_LIC == "SI"){					
					try{
						int validaDescuentos = getValidaDescuentosCandidato(ID_PREOPERADOR.ToString(), folio.ToString());	

						if(validaDescuentos == 0){
							sentencia = @"Insert into PRE_OPERADOR_DESCUENTOS(ID_PREOPERADOR, FOLIO, ESTATAL_DESC, ESTATAL_VENCE, FEDERAL_DESC, FEDERAL_VENCE, MEDICO_DESC, MEDICO_VENCE, OBSERVACIONES) values('"+ID_PREOPERADOR+"', '"+folio+"','"+licAjuste.estatal
								+"','"+licAjuste.estatal_vence+"','"+licAjuste.federal+"','"+licAjuste.federal_vence+"','"+licAjuste.medico+"','"+licAjuste.medico_vence+"','"+licAjuste.observaciones+"')";
						}else{
							sentencia = @"UPDATE PRE_OPERADOR_DESCUENTOS SET FOLIO = '"+folio+"', ESTATAL_DESC = '"+licAjuste.estatal+"', ESTATAL_VENCE = '"+licAjuste.estatal_vence+"', FEDERAL_DESC = '"+licAjuste.federal+"', FEDERAL_VENCE = '"+licAjuste.federal_vence
								+"', MEDICO_DESC = '"+licAjuste.medico+"', MEDICO_VENCE = '"+licAjuste.medico_vence+"', OBSERVACIONES = '"+licAjuste.observaciones+"'  WHERE ID_PREOPERADOR = "+ID_PREOPERADOR +" AND FOLIO = "+folio;
						}
		       			base.getAbrirConexion(sentencia);
			       		base.comando.ExecuteNonQuery();
			       		base.conexion.Close();
					}catch(Exception ex){
						respuesta = false;
						MessageBox.Show("ERROR AL INSERTAR LOS DESCUENTOS DE LAS LICENCIAS DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}finally{
						if(conexion != null)
							base.conexion.Close();
					}
				}
				
				int validaImagen = getValidaImagenOperador(ID_PREOPERADOR.ToString(), folio.ToString());
				try{
					if(validaImagen == 1){
						sentencia = @"UPDATE PRE_OPERADOR_IMAGEN SET FOLIO = '"+folio+"', PEINADO = '"+peinado+"', PELO_CORTO = '"+pelo+"', MANOS_LIMPIAS = '"+manosCara+"', RASURADO = '"+rasurado+"', ROPA_LIMPIA = '"+ropa+"', LIMPIEZA_CALZADO = '"+calzado+"', VETIMENTA = '"+vestimenta
							+"', CAMISA = '0', PANTALON = '"+pantalon+"', ZAPATO = '"+zapato+"', PRESENTACIONCAMISA1 = '"+presentacionCamisa1+"', PRESENTACIONCAMISA2 = '"+presentacionCamisa2+"', PRESENTACIONCAMISA3 = '"+presentacionCamisa3+"', PRESENTACIONPANTALON1 = '"+presentacionPantalon1+"', COMENTARIO = '' WHERE ID_PREOPERADOR = "+ID_PREOPERADOR +" AND FOLIO = "+folio;
					}else{
						sentencia = @"Insert into PRE_OPERADOR_IMAGEN(ID_PREOPERADOR, FOLIO, PEINADO, PELO_CORTO, MANOS_LIMPIAS, RASURADO, ROPA_LIMPIA, ALINEADO, LIMPIEZA_CALZADO, VETIMENTA, CAMISA, PANTALON, ZAPATO, PRESENTACIONCAMISA1, PRESENTACIONCAMISA2, PRESENTACIONCAMISA3, PRESENTACIONPANTALON1, COMENTARIO ) values('"
	       				+ID_PREOPERADOR+"', '"+folio+"','"+peinado+"','"+pelo+"','"+manosCara+"','"+rasurado+"','"+ropa+"','0','"+calzado+"', '"+vestimenta+"', '0', '"+pantalon+"', '"+zapato+"', '"+presentacionCamisa1+"', '"+presentacionCamisa2+"', '"+presentacionCamisa3+"', '"+presentacionPantalon1+"', '')";
	       			}
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("ERROR AL MODIFICAR LOS PARÁMETROS DE LA IMAGEN DEL CANDIDATO: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
	
		public bool modificaCandidatoSolicitud(string CORREO, string FECHA_NACIMIENTO, string LUGAR_NACIMIENTO, string MUNICIPIO_NACIMIENTO, string ESTADO_NACIMIENTO, string CALLE, string NUM_EXT, string NUM_INT, string MUNICIPIO, string COLONIA, 
		                                       string CP, string ESTADO, string CRUCE1, string CRUCE2, string FLUJO, Int32 ID_USUARIO, Int64 ID_PREOPERADOR){
			bool respuesta = true;
			string sentencia = "";
			
			respuesta = HST_CANDIDATO(ID_PREOPERADOR, ID_USUARIO, "MODIFICACIÓN SOLICITUD");
			
			if(respuesta){
				try{
						sentencia = @"UPDATE PRE_OPERADOR SET CORREO = '"+CORREO+"', FECHA_NACIMIENTO = '"+FECHA_NACIMIENTO+"', LUGAR_NACIMIENTO = '"+LUGAR_NACIMIENTO+"', MUNICIPIO_NACIMIENTO = '"+MUNICIPIO_NACIMIENTO+"', ESTADO_NACIMIENTO = '"+ESTADO_NACIMIENTO
							+"', CALLE = '"+CALLE+"', NUM_EXT = '"+NUM_EXT+"', NUM_INT = '"+NUM_INT+"', MUNICIPIO = '"+MUNICIPIO+"', COLONIA = '"+COLONIA+"', CP = '"+CP+"', ESTADO = '"+ESTADO+"', CRUCE1 = '"+CRUCE1+"', CRUCE2 = '"+CRUCE2
							+"', FLUJO = '"+FLUJO+"' WHERE ID = "+ID_PREOPERADOR;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR al modificar los datos para la solicitud del candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			
			if(respuesta){				
					
			}
			return respuesta;
		}
		#endregion
		
		#region VALIDA CANDIDATO
		public bool validaCandidato( Int64 ID_PREOPERADOR, string FOLIO, string TIPO, string VALIDA, string FOLIO_VALIDA, string DESCRIPCION, string FLUJO, Int32 ID_USUARIO){
			bool respuesta = true;
			string sentencia = "";
			
			respuesta = HST_CANDIDATO(ID_PREOPERADOR, ID_USUARIO, "VALIDA DATOS");
			
			Int64 IDCita = getIdCita(ID_PREOPERADOR, FOLIO, "LLAMADA", "ACTIVA");			
			try{						     		
       			sentencia = @"UPDATE CITA_PRE_OPERADOR SET ESTADO = 'VALIDADO' WHERE ID = "+IDCita;
       			base.getAbrirConexion(sentencia);
	       		base.comando.ExecuteNonQuery();
	       		base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("ERROR AL REAGENDAR LA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			
			if(respuesta){
				try{
					sentencia = @"UPDATE PRE_OPERADOR SET FLUJO = 'VALIDADO' WHERE ID = "+ID_PREOPERADOR;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR al validar al candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}						
			
			if(respuesta){
				try{  		
		       		sentencia = @"Insert into PRE_OPERADOR_VALIDA(ID_PREOPERADOR, FOLIO, TIPO, VALIDA, FOLIO_VALIDA, DESCRIPCION, ESTATUS, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values
					('"+ID_PREOPERADOR+"', '"+FOLIO+"', '"+TIPO+"', '"+VALIDA+"', '"+FOLIO_VALIDA+"', '"+DESCRIPCION+"', 'Activo', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())), "+ID_USUARIO+")";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR al insertar la validación del candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		#endregion
				
		#region CANCELA LLAMADA
		public bool cancelaLlamda( Int64 ID_PREOPERADOR, int FOLIO, string FLUJO, string MOTIVO, string OBSERVACIONES, Int32 ID_USUARIO){	
			bool respuesta = true;
			string sentencia = "";
			string msj = "";
			
			
			Int64 IDCita = getIdCita(ID_PREOPERADOR, FOLIO.ToString(), "LLAMADA", "ACTIVA");
			
			try{						     		
       			sentencia = @"UPDATE CITA_PRE_OPERADOR SET MOTIVO_ESTADO = 'CANCELACIÓN DE CANDIDATO (LLAMADA)'  WHERE ID = "+IDCita;
       			base.getAbrirConexion(sentencia);
	       		base.comando.ExecuteNonQuery();
	       		base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				msj = "CANCELAR CITA: "+ex.Message;
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			
			if(respuesta){
				try{						     		
	       			sentencia = @"Insert into PRE_OPERADOR_CANCELA(ID_PREOPERADOR, FOLIO, FLUJO, MOTIVO, OBSERVACIONES, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values('"
	       			+ID_PREOPERADOR+"', '"+FOLIO+"', '"+FLUJO+"', '"+MOTIVO+"', '"+OBSERVACIONES+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					msj += "\nINSERTAR EN PRE_OPERADOR_CANCELA: "+ex.Message;
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			
			try{						     		
       			sentencia = @"UPDATE PRE_OPERADOR SET ESTATUS = 'CANCELADA' WHERE ID = "+ID_PREOPERADOR;
       			base.getAbrirConexion(sentencia);
	       		base.comando.ExecuteNonQuery();
	       		base.conexion.Close();
			}catch(Exception ex){
				respuesta = false;
				msj += "\nCANCELAR PRE_OPERADOR "+ex.Message;
			}finally{
				if(conexion != null)
					base.conexion.Close();
			}
			
			if(!respuesta)				
				MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			
			return respuesta;
		}	
		#endregion
				
		#region CONTRATAR CANDIDATO
		public bool contratarCandidato(Int64 ID_PREOPERADOR, string FOLIO, string FLUJO, string ESTATUS, string FECHA_CITA, string HORA_CITA, Int32 ID_USUARIO){
			bool respuesta = true;
			string sentencia = "";
			
			respuesta = HST_CANDIDATO(ID_PREOPERADOR, ID_USUARIO, "VALIDA DATOS");						
			if(respuesta){
				try{
					sentencia = @"UPDATE PRE_OPERADOR SET FLUJO = '"+FLUJO+"', ESTATUS = '"+ESTATUS+"' WHERE ID = "+ID_PREOPERADOR;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR al cerrar la contratación del candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}						
			
			if(respuesta){
				try{						     		
	       			sentencia = @"Insert into CITA_PRE_OPERADOR(ID_PREOPERADOR, FOLIO, TIPO, FECHA, HORA, ESTADO, MOTIVO_ESTADO, COMENTARIO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values('"
	       			+ID_PREOPERADOR+"', '"+FOLIO+"', 'DOCUMENTOS',  '"+FECHA_CITA+"','"+HORA_CITA+"', 'ACTIVA', '',  '', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR AL INSERTAR LA NUEVA CITA DEL CANDIDATO AL OPERADOR: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		#endregion
		
		#region NO CONTRATAR CANDIDATO
		public bool noContratarCandidato(Int64 ID_PREOPERADOR, string FOLIO, string FLUJO, string ESTATUS, string MOTIVO, Int32 ID_USUARIO){
			bool respuesta = true;
			string sentencia = "";
			
			respuesta = HST_CANDIDATO(ID_PREOPERADOR, ID_USUARIO, "VALIDA DATOS");						
			if(respuesta){
				try{
					sentencia = @"UPDATE PRE_OPERADOR SET FLUJO = '"+FLUJO+"', ESTATUS = '"+ESTATUS+"' WHERE ID = "+ID_PREOPERADOR;
					base.getAbrirConexion(sentencia);
					base.comando.ExecuteNonQuery();
					base.conexion.Close();
				}catch(Exception ex){
					respuesta = false;
					MessageBox.Show("ERROR al NO contratar al candidato: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}						
			
			if(respuesta){
				try{						     		
	       			sentencia = @"Insert into PRE_OPERADOR_CANCELA(ID_PREOPERADOR, FOLIO, FLUJO, MOTIVO, FECHA_REGISTRO, HORA_REGISTRO, ID_USUARIO) values('"
	       			+ID_PREOPERADOR+"', '"+FOLIO+"', '"+FLUJO+"', '"+MOTIVO+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),'"+ID_USUARIO+"')";
	       			base.getAbrirConexion(sentencia);
		       		base.comando.ExecuteNonQuery();
		       		base.conexion.Close();
				}catch(Exception){
					respuesta = false;
				}finally{
					if(conexion != null)
						base.conexion.Close();
				}
			}
			return respuesta;
		}
		#endregion
		
		#region VALIDA OPERADOR RECOMENDADO		
		public bool validaOperadorRecomendado(string alias){
			bool respuesta = false;			
			string consulta = "SELECT * FROM OPERADOR WHERE ALIAS = '"+alias+"'";
			base.getAbrirConexion(consulta);
			base.leer = base.comando.ExecuteReader();
			if(base.leer.Read())
				respuesta = true;
			base.conexion.Close();			
			return respuesta;
		}
		#endregion
	}
}
