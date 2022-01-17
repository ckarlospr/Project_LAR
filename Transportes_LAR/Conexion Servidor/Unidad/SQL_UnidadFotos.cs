using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Transportes_LAR.Conexion_Servidor.Unidad
{
	public class SQL_UnidadFotos:Conexion_Servidor.SQL_Conexion
	{
		#region CONSTRUCTOR
		public SQL_UnidadFotos():base(){
		}
		#endregion
		
		public void getEliminarFoto(string idunidad,string idfoto){
			base.getAbrirConexion("execute eliminar_foto " + 
			                 		idfoto + "," +
			                 		idunidad
			                	 );
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		                             
		}
		
		public void getModificarFoto(string idfoto,string idu,string descripcion){
			base.getAbrirConexion("exec modificar_foto " + 
			     	              	idfoto+ "," + 
			     	              	idu+",'" + 
			     	              	descripcion +"'"
			     	             );
			
			base.comando.ExecuteNonQuery();
			base.conexion.Close();
		                             
		}
		
		public void getInsertarFoto(String id,String descripcion,Image foto){
			try{
				System.IO.MemoryStream ms = new System.IO.MemoryStream();
            	foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
	            base.comando = new SqlCommand();
	            base.comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            	base.comando.Parameters["@foto"].Value = ms.GetBuffer();
            	String ejecutar = "execute insertar_foto " +
				                 id + ",'" + 
				                 descripcion + "'," +
				                 "@foto";
            	base.getAbrirConexion(ejecutar);
				base.comando.ExecuteNonQuery();
				base.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show(ex.ToString(),"error insertar foto");
			}
		}
		
		public void getInsertarFoto(String id,List<Interfaz.Unidad.FotografiaU> foto){
			int aguardar = 0;
			int cont = 0;
			while(cont<foto.Count){
				if(foto[cont].ID_Foto==0){
					try{
						base.conexion= new SqlConnection();
			            base.comando = new SqlCommand();
			            System.IO.MemoryStream ms = new System.IO.MemoryStream();
						foto[cont].image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
		            	base.comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
		            	base.comando.Parameters["@foto"].Value = ms.GetBuffer();
						
		            	string ejecutar = "execute insertar_foto " +
						                 	id + ",'" + 
		            						foto[cont].Descripcion + "'," +
						                  "@foto";
		            	getAbrirConexion(ejecutar);
						comando.ExecuteNonQuery();
						conexion.Close();
						aguardar++;
					}catch(Exception ex){
						MessageBox.Show(ex.ToString(),"ERROR insertar foto",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
					
				}	
				cont++;
			}
			if(aguardar==1){
				new Interfaz.FormMensaje("Nueva Fotografia almacenada");
			}if(aguardar>1){
				new Interfaz.FormMensaje("Nuevas Fotografias Almacenadas");
			}
		}
		
		public List<Interfaz.Unidad.FotografiaU> getDatosFotos(String id){
			getAbrirConexion("select ID, ID_UNIDAD, Descripcion, Foto FROM FOTOSUNIDAD where ID_UNIDAD = "+ id );
			leer = comando.ExecuteReader();
			List<Interfaz.Unidad.FotografiaU> foto = new List<Interfaz.Unidad.FotografiaU>();
			while(leer.Read()){

      			try{
      				byte[] imageBuffer = (byte[]) leer["Foto"];
      				int i = Convert.ToInt32(leer["ID"].ToString());
      				int idu = Convert.ToInt32(leer["ID_UNIDAD"].ToString());
      				String Descripcion = leer["Descripcion"].ToString();
      			
          			Image imagen= Image.FromStream(new System.IO.MemoryStream(imageBuffer));
          			foto.Add(new Interfaz.Unidad.FotografiaU(i,
          			                              idu,
          			                              Descripcion,imagen));
          		
				}catch(Exception ex){
					MessageBox.Show("Error al obtener fotografias:\n" + ex.ToString(),"Error al obtener fotografias",MessageBoxButtons.OK,MessageBoxIcon.Error);
            	}
			}
			conexion.Close();
			return foto;
		}
	}
}
