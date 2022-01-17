using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormEncuestaPost : Form
	{
		#region CONSTRUCTOR			
		public FormEncuestaPost(FormLibroViajes refLibro, Int32 ID)
		{
			InitializeComponent();
			libro = refLibro;
			ID_RE = ID;
		}
		#endregion
		
		#region VARIABLES 
		bool validaExiste = false;
		Int32 ID_RE = 0;
		#endregion
		
		#region INSTANCIAS
		FormLibroViajes libro = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region INICIO - FIN
		void FormEncuestaPostLoad(object sender, EventArgs e)
		{
			obtenerDatos();
			this.txtprecio.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto2);
			validaExiste = connL.validarExisteEncuesta(ID_RE);
			
			if(validaExiste){
				ObtenerEncuesta();
				btnGuardaEncuesta.Enabled = false;
			}
		}
		
		void FormEncuestaPostFormClosing(object sender, FormClosingEventArgs e)
		{
			//libro.filtrosEncuesta();
		}
		#endregion
		
		#region METODOS
		void obtenerDatos(){
			try{
				String consulta = "select usuario from usuario where id_usuario = "+libro.id_usuario;
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtUsu1.Text = conn.leer["usuario"].ToString();
					txtUsu2.Text = conn.leer["usuario"].ToString();
				}
				conn.conexion.Close();
				
				consulta = @"select R.tipoVehiculo, R.ID_RE, C.Nombre, responsable as Responsable, R.fecha, RT.HoraInicio, R.fecha_salida, R.h_planton, R.cant_unidades, 
									R.domicilio, R.destino, CL.Estado, CL.Rumbo,  R.casetas, R.precio, C.Telefono As Telefono, R.factura, R.observaciones,  R.correo, 
									R.fecha_regreso, R.anticipo, R.estado as Estado_especial, RT.CompletoCamioneta, R.CONF_CLIENTE from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, 
									Cliente CL where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID and RT.Sentido='ENTRADA' and R.ID_RE="+ID_RE;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtCliente.Text = conn.leer["Responsable"].ToString();
					txtTell.Text = conn.leer["Telefono"].ToString();
				}
				conn.conexion.Close();
				
				consulta = @"select MEDIO_ENTERO from VIAJE_PROSPECTO_NUEVO where ID_RE = "+ID_RE;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					cbComo.Text = conn.leer["MEDIO_ENTERO"].ToString();
				}
				conn.conexion.Close();
				
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los datos para la encuesta: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}				
		}	
		
		void ObtenerEncuesta(){
			try{
				String consulta = "select * from ENCUESTA where ID_RE = "+ID_RE;
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dupCalificaion.Text = conn.leer["CALIFICACION"].ToString();
					txtEncuesta.Text = conn.leer["COMETARIO"].ToString();
					txtprecio.Text =  conn.leer["Precio_Pagado"].ToString();
					cbComo.Text =  conn.leer["MEDIO_ENTERADO"].ToString();
					cbLimpieza.Checked =  ((conn.leer["LIMPIEZA"].ToString()=="1")? true : false);
					cbImagen.Checked =  ((conn.leer["IMAGEN"].ToString()=="1")? true : false);
					cbActitud.Checked =  ((conn.leer["ACTITUD"].ToString()=="1")? true : false);
					cbPuntualidad.Checked =  ((conn.leer["PUNTUALIDAD"].ToString()=="1")? true : false);
					cbVelocidad.Checked =  ((conn.leer["VELOCIDAD"].ToString()=="1")? true : false);
					cbFalla.Checked =  ((conn.leer["FALLA"].ToString()=="1")? true : false);
				}
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener la encuesta: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				conn.conexion.Close();	
			}	
		}
		#endregion
		
		#region EVENTOS
		void DupCalificaionSelectedItemChanged(object sender, EventArgs e)
		{
			if(dupCalificaion.Text != ""){				
				if(Convert.ToInt16(dupCalificaion.Text)==10)
					gbMenor.Enabled = false;
				else
					gbMenor.Enabled = true;
			}
		}
		#endregion
		
		#region BOTONES
		void BtnGuardaEncuestaClick(object sender, EventArgs e)
		{
			bool valida = true;
			String miconsult = "insert into ENCUESTA values ('"+ID_RE+"','"+libro.id_usuario+"','1', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), '"+
																dupCalificaion.Text+"', '"+txtEncuesta.Text+"', '"+((cbLimpieza.Checked==true)?1:0)+"', '"+((cbImagen.Checked==true)?1:0)+"', '"+
																((cbActitud.Checked==true)?1:0)+"', '"+((cbPuntualidad.Checked==true)?1:0)+"', '"+((cbVelocidad.Checked==true)?1:0)+"', '"+
																((cbFalla.Checked==true)?1:0)+"', '"+txtprecio.Text+"', '"+cbComo.Text+"')";
			try{
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al guardar la encuesta: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				valida = false;
				conn.conexion.Close();
			}
			if(valida == true){
				libro.filtrosEncuesta();
				this.Close();
			}
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}
