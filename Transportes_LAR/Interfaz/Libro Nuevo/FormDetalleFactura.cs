using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo
{
	public partial class FormDetalleFactura : Form
	{
		#region INSTANCIAS		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region CONSTRUCTOR	
		public FormDetalleFactura()
		{
			InitializeComponent();
		}		
		#endregion
		
		#region METODOS
		public void muestrarMsj(String dato)
		{
			String Consulta = @"select VPN.CONTACTO, R.CONF_CLIENTE, R.ID_RE, VPN.ID AS ID_COTIZACION, VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable as Responsable,  
				R.fecha_salida, R.Tipovehiculo, R.cant_unidades, R.domicilio, DS.TELEFONO_R,R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, 
				R.correo,  R.fecha_regreso , R.estado as Estado_especial,  R.CONF_CLIENTE, R.ENCUESTA from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL, 
				VIAJE_PROSPECTO_NUEVO VPN, DETALLE_SERVICIO DS, FACTURA_RUTA_ESPECIAL FRE where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID  and 
				VPN.ID_RE = r.ID_RE and DS.ID_COTIZACION = VPN.ID and RT.Sentido='Entrada' AND FRE.ID_RE = R.ID_RE AND FRE.ID_FACTURA = "+dato
			    +" group by R.CONF_CLIENTE, VPN.CONTACTO, R.ID_RE, VPN.ID , VPN.FOLIO, VPN.NUMERO, R.destino, R.responsable,  R.fecha_salida, R.Tipovehiculo, "+
			    " R.cant_unidades, R.domicilio, DS.TELEFONO_R, R.precio, R.FACTURADO , R.anticipo, RT.CompletoCamioneta, R.observaciones, R.correo,  R.fecha_regreso , R.estado,  R.CONF_CLIENTE, R.ENCUESTA";
			string numero;			
			try{
				dgControlPRE.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{			
					if(Convert.ToInt64(conn.leer["NUMERO"]) == 0)
						numero= "01";				
					else if(conn.leer["NUMERO"].ToString().Length==1)
						numero= "0"+conn.leer["NUMERO"].ToString();
					else
						numero= conn.leer["NUMERO"].ToString();				
							 				
					dgControlPRE.Rows.Add(conn.leer["ID_RE"].ToString(),
 	                      						conn.leer["ID_COTIZACION"].ToString(),
					                      		conn.leer["FOLIO"].ToString()+numero,
					                      		conn.leer["destino"].ToString(),
					                      		conn.leer["CONTACTO"].ToString(),
						                        Convert.ToDateTime(conn.leer["fecha_salida"].ToString().Substring(0,10)).ToShortDateString(),
						                        Convert.ToDateTime(conn.leer["fecha_regreso"].ToString().Substring(0,10)).ToShortDateString(),
						                        conn.leer["Tipovehiculo"].ToString(),
						                        conn.leer["cant_unidades"].ToString(),     
												conn.leer["domicilio"].ToString(),
												conn.leer["TELEFONO_R"].ToString(),
												conn.leer["precio"].ToString(),
												conn.leer["FACTURADO"].ToString(),
												"", // precio facturado												 
												"", // Datos factura
												conn.leer["anticipo"].ToString(),
												conn.leer["CompletoCamioneta"].ToString(),												 
												conn.leer["observaciones"].ToString(),
												conn.leer["correo"].ToString(),												 
						                        conn.leer["Estado_especial"].ToString(),
						                        conn.leer["ENCUESTA"].ToString());					
				
				}				
				conn.conexion.Close();			
				dgControlPRE.ClearSelection();
			}catch(Exception ex){
				MessageBox.Show("Error al Obtener Servicios de la factura: "+ex.Message);
			}finally{				
				conn.conexion.Close();	
			}			
		}				
		#endregion
		
		#region EVENTOS
		void DgControlPREClick(object sender, EventArgs e)
		{
			
		}		
		#endregion
		
		void Label1Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}
	}
}
