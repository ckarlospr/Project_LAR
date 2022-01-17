using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormEncuestaPost2 : Form
	{				
		#region CONSTRUCTOR			
		public FormEncuestaPost2(FormLibroViajes refLibro, Int32 ID, Int32 ID_usu)
		{
			InitializeComponent();
			libro = refLibro;
			ID_RE = ID;
			ID_U = ID_usu;
		}
		#endregion
		
		#region VARIABLES 
		Int32 ID_RE = 0, ID_U = 0;
		double calOperador, calUnidad, calAtencion, calPrecio, calServicio;
		double valorMB = 33.333333333, valorB = 25.01, valorM = 16.67, valorMM = 8.34;
		#endregion
		
		#region INSTANCIAS
		FormLibroViajes libro = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region INICIO - FIN
		void FormEncuestaPost2Load(object sender, EventArgs e)
		{
			obtenerDatos();
			this.txtPagoOperador.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			if(connL.validarExisteEncuestaVenta(ID_RE))
				ObtenerEncuesta();
		}		
		#endregion
		
		#region METODOS	
		void calificacion(){
			calOperador = (  ((cbOpeMB1.Checked)? valorMB : ((cbOpeB1.Checked)? valorB : ((cbOpeM1.Checked)? valorM : ((cbOpeMM1.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbOpeMB2.Checked)? valorMB : ((cbOpeB2.Checked)? valorB : ((cbOpeM2.Checked)? valorM : ((cbOpeMM2.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbOpeMB3.Checked)? valorMB : ((cbOpeB3.Checked)? valorB : ((cbOpeM3.Checked)? valorM : ((cbOpeMM3.Checked)? valorMM : 0.0 ) ) ) )			                
			              );
			
			calUnidad = (  ((cbUniMB1.Checked)? valorMB : ((cbUniB1.Checked)? valorB : ((cbUniM1.Checked)? valorM : ((cbUniMM1.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbUniMB2.Checked)? valorMB : ((cbUniB2.Checked)? valorB : ((cbUniM2.Checked)? valorM : ((cbUniMM2.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbUniMB3.Checked)? valorMB : ((cbUniB3.Checked)? valorB : ((cbUniM3.Checked)? valorM : ((cbUniMM3.Checked)? valorMM : 0.0 ) ) ) )		                
			              );
			
			calAtencion = (  ((cbAteMB1.Checked)? valorMB : ((cbAteB1.Checked)? valorB : ((cbAteM1.Checked)? valorM : ((cbAteMM1.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbAteMB2.Checked)? valorMB : ((cbAteB2.Checked)? valorB : ((cbAteM2.Checked)? valorM : ((cbAteMM2.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbAteMB3.Checked)? valorMB : ((cbAteB3.Checked)? valorB : ((cbAteM3.Checked)? valorM : ((cbAteMM3.Checked)? valorMM : 0.0 ) ) ) )	                
			              );
			
			calPrecio = (  ((cbPreMB1.Checked)? valorMB : ((cbPreB1.Checked)? valorB : ((cbPreM1.Checked)? valorM : ((cbPreMM1.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbPreMB2.Checked)? valorMB : ((cbPreB2.Checked)? valorB : ((cbPreM2.Checked)? valorM : ((cbPreMM2.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbPreMB3.Checked)? valorMB : ((cbPreB3.Checked)? valorB : ((cbPreM3.Checked)? valorM : ((cbPreMM3.Checked)? valorMM : 0.0 ) ) ) )                
			              );
			
			calServicio = (  ((cbSerMB1.Checked)? valorMB : ((cbSerB1.Checked)? valorB : ((cbSerM1.Checked)? valorM : ((cbSerMM1.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbSerMB2.Checked)? valorMB : ((cbSerB2.Checked)? valorB : ((cbSerM2.Checked)? valorM : ((cbSerMM2.Checked)? valorMM : 0.0 ) ) ) )
			                + ((cbSerMB3.Checked)? valorMB : ((cbSerB3.Checked)? valorB : ((cbSerM3.Checked)? valorM : ((cbSerMM3.Checked)? valorMM : 0.0 ) ) ) )              
			              );
			lblOpeCal.Text = Math.Round(calOperador,2).ToString();
			lblUniCal.Text = Math.Round(calUnidad,2).ToString();
			lblAteCal.Text = Math.Round(calAtencion,2).ToString();
			lblPreCal.Text = Math.Round(calPrecio,2).ToString();
			lblSerCal.Text = Math.Round(calServicio,2).ToString();
			lblCalTotal.Text = (Math.Round( ((calOperador + calUnidad + calAtencion + calPrecio +  calServicio) / 5), 2)).ToString();
			//lblCalTotal.Text = (Math.Round( ((calOperador + calUnidad + calPrecio +  calServicio) / 4), 2)).ToString();
		}
				
		void obtenerDatos(){
			try{
				lblFechaE.Text = DateTime.Now.ToString("dd/MM/yyyy");
				
				string consulta = @"select vpn.EVENTO, vpn.FECHA_SALIDA, vpn.CANTIDAD, vpn.MEDIO_ENTERO, vpn.CONTACTO, vpn.TELEFONO  from VIAJE_PROSPECTO_NUEVO vpn where vpn.ID_RE = "+ID_RE;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					lblDestino.Text = conn.leer["EVENTO"].ToString();
					lblFechaV.Text = conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);
					lblCantidad.Text = conn.leer["CANTIDAD"].ToString();
					lblFuente.Text = conn.leer["MEDIO_ENTERO"].ToString();
					lblNombre.Text = conn.leer["CONTACTO"].ToString();
					lblTelefono.Text = conn.leer["TELEFONO"].ToString();
				}
				conn.conexion.Close();
				
				consulta = @"select op.Alias, v.Numero from RUTA_ESPECIAL re join RUTA r on r.IdSubEmpresa = re.ID_C join OPERACION o on o.id_ruta = r.ID join OPERACION_OPERADOR oo 
							on oo.id_operacion = o.id_operacion join OPERADOR op on op.ID = oo.id_operador join VEHICULO v on v.ID = oo.id_vehiculo where o.estatus != '0' and re.ID_RE = "+ID_RE+" group by op.Alias, v.Numero";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(lblOperador.Text.Length == 0)
						lblOperador.Text = conn.leer["Alias"].ToString();
					else
						lblOperador.Text = lblOperador.Text+ " - "+conn.leer["Alias"].ToString();
										
					if(lblUnidad.Text.Length == 0)
						lblUnidad.Text = conn.leer["Numero"].ToString();
					else
						lblUnidad.Text = lblUnidad.Text+ " - "+conn.leer["Numero"].ToString();
				}
				conn.conexion.Close();				
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los datos para la encuesta: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}				
		}	
		
		void ObtenerEncuesta(){
			try{
				String consulta = "select * from ENCUESTA_VENTAS where ESTATUS = 'Activo' and  ID_RE = "+ID_RE+" ORDER BY ID DESC";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(conn.leer["operador1"].ToString().Equals("MB"))
						cbOpeMB1.Checked = true;
					else if(conn.leer["operador1"].ToString().Equals("B"))
						cbOpeB1.Checked = true;
					else if(conn.leer["operador1"].ToString().Equals("M"))
						cbOpeM1.Checked = true;
					else
						cbOpeMM1.Checked = true;
					txtOpeObs1.Text = conn.leer["operadorComentario1"].ToString();
					
					if(conn.leer["operador2"].ToString().Equals("MB"))
						cbOpeMB2.Checked = true;
					else if(conn.leer["operador2"].ToString().Equals("B"))
						cbOpeB2.Checked = true;
					else if(conn.leer["operador2"].ToString().Equals("M"))
						cbOpeM2.Checked = true;
					else
						cbOpeMM2.Checked = true;
					txtOpeObs2.Text = conn.leer["operadorComentario2"].ToString();
					
					if(conn.leer["operador3"].ToString().Equals("MB"))
						cbOpeMB3.Checked = true;
					else if(conn.leer["operador3"].ToString().Equals("B"))
						cbOpeB3.Checked = true;
					else if(conn.leer["operador3"].ToString().Equals("M"))
						cbOpeM3.Checked = true;
					else
						cbOpeMM3.Checked = true;
					txtOpeObs3.Text = conn.leer["operadorComentario3"].ToString();
					
					if(conn.leer["unidad1"].ToString().Equals("MB"))
						cbUniMB1.Checked = true;
					else if(conn.leer["unidad1"].ToString().Equals("B"))
						cbUniB1.Checked = true;
					else if(conn.leer["unidad1"].ToString().Equals("M"))
						cbUniM1.Checked = true;
					else
						cbUniMM1.Checked = true;
					txtUniObs1.Text = conn.leer["unidadComentario1"].ToString();
					
					if(conn.leer["unidad2"].ToString().Equals("MB"))
						cbUniMB2.Checked = true;
					else if(conn.leer["unidad2"].ToString().Equals("B"))
						cbUniB2.Checked = true;
					else if(conn.leer["unidad2"].ToString().Equals("M"))
						cbUniM2.Checked = true;
					else
						cbUniMM2.Checked = true;
					txtUniObs2.Text = conn.leer["unidadComentario2"].ToString();
					
					if(conn.leer["unidad3"].ToString().Equals("MB"))
						cbUniMB3.Checked = true;
					else if(conn.leer["unidad3"].ToString().Equals("B"))
						cbUniB3.Checked = true;
					else if(conn.leer["unidad3"].ToString().Equals("M"))
						cbUniM3.Checked = true;
					else
						cbUniMM3.Checked = true;
					txtUniObs3.Text = conn.leer["unidadComentario3"].ToString();
					
					if(conn.leer["atencion1"].ToString().Equals("MB"))
						cbAteMB1.Checked = true;
					else if(conn.leer["atencion1"].ToString().Equals("B"))
						cbAteB1.Checked = true;
					else if(conn.leer["atencion1"].ToString().Equals("M"))
						cbAteM1.Checked = true;
					else
						cbAteMM1.Checked = true;
					txtAteObs1.Text = conn.leer["atencionComentario1"].ToString();
					
					if(conn.leer["atencion2"].ToString().Equals("MB"))
						cbAteMB2.Checked = true;
					else if(conn.leer["atencion2"].ToString().Equals("B"))
						cbAteB2.Checked = true;
					else if(conn.leer["atencion2"].ToString().Equals("M"))
						cbAteM2.Checked = true;
					else
						cbAteMM2.Checked = true;
					txtAteObs2.Text = conn.leer["atencionComentario2"].ToString();
					
					if(conn.leer["atencion3"].ToString().Equals("MB"))
						cbAteMB3.Checked = true;
					else if(conn.leer["atencion3"].ToString().Equals("B"))
						cbAteB3.Checked = true;
					else if(conn.leer["atencion3"].ToString().Equals("M"))
						cbAteM3.Checked = true;
					else
						cbAteMM3.Checked = true;
					txtAteObs3.Text = conn.leer["atencionComentario3"].ToString();
					
					if(conn.leer["precio1"].ToString().Equals("MB"))
						cbPreMB1.Checked = true;
					else if(conn.leer["precio1"].ToString().Equals("B"))
						cbPreB1.Checked = true;
					else if(conn.leer["precio1"].ToString().Equals("M"))
						cbPreM1.Checked = true;
					else
						cbPreMM1.Checked = true;
					txtPreObs1.Text = conn.leer["precioComentario1"].ToString();
					
					if(conn.leer["precio2"].ToString().Equals("MB"))
						cbPreMB2.Checked = true;
					else if(conn.leer["precio2"].ToString().Equals("B"))
						cbPreB2.Checked = true;
					else if(conn.leer["precio2"].ToString().Equals("M"))
						cbPreM2.Checked = true;
					else
						cbPreMM2.Checked = true;
					txtPreObs2.Text = conn.leer["precioComentario2"].ToString();
					
					if(conn.leer["precio3"].ToString().Equals("MB"))
						cbPreMB3.Checked = true;
					else if(conn.leer["precio3"].ToString().Equals("B"))
						cbPreB3.Checked = true;
					else if(conn.leer["precio3"].ToString().Equals("M"))
						cbPreM3.Checked = true;
					else
						cbPreMM3.Checked = true;
					txtPreObs3.Text = conn.leer["precioComentario3"].ToString();
										
					if(conn.leer["servicio1"].ToString().Equals("MB"))
						cbSerMB1.Checked = true;
					else if(conn.leer["servicio1"].ToString().Equals("B"))
						cbSerB1.Checked = true;
					else if(conn.leer["servicio1"].ToString().Equals("M"))
						cbSerM1.Checked = true;
					else
						cbSerMM1.Checked = true;
					txtSerObs1.Text = conn.leer["servicioComentario1"].ToString();
										
					if(conn.leer["servicio2"].ToString().Equals("MB"))
						cbSerMB2.Checked = true;
					else if(conn.leer["servicio2"].ToString().Equals("B"))
						cbSerB2.Checked = true;
					else if(conn.leer["servicio2"].ToString().Equals("M"))
						cbSerM2.Checked = true;
					else
						cbSerMM2.Checked = true;
					txtSerObs2.Text = conn.leer["servicioComentario2"].ToString();
										
					if(conn.leer["servicio3"].ToString().Equals("MB"))
						cbSerMB3.Checked = true;
					else if(conn.leer["servicio3"].ToString().Equals("B"))
						cbSerB3.Checked = true;
					else if(conn.leer["servicio3"].ToString().Equals("M"))
						cbSerM3.Checked = true;
					else
						cbSerMM3.Checked = true;
					txtSerObs3.Text = conn.leer["servicioComentario3"].ToString();
										
					if(conn.leer["seguimientoPagoOperador"].ToString().Equals("SI"))
						cbPagoOperadorSI.Checked = true;
					else
						cbPagoOperadorNO.Checked = true;
					txtPagoOperador.Text = conn.leer["seguimientoPagoCuanto"].ToString();
					
					if(conn.leer["seguimientoViajeProgramado"].ToString().Equals("SI"))
						cbViajeProgramadoSI.Checked = true;
					else
						cbViajeProgramadoNO.Checked = true;
					cmbDonde.Text = conn.leer["seguimientoViajeDonde"].ToString();
					cmbMes.Text = conn.leer["seguimientoViajeMes"].ToString();
					
					if(conn.leer["seguimientoVolveria"].ToString().Equals("SI"))
						cbVolveriaSI.Checked = true;
					else
						cbVolveriaNO.Checked = true;
					txtObservaciones.Text = conn.leer["comentario"].ToString();
					
					if(conn.leer["personaAjenaEnViaje"].ToString().Equals("SI"))
						cbGenteAjenaSi.Checked = true;
					else
						cbGenteAjenaNo.Checked = true;
				}
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener la encuesta: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();	
			}
		}
		
		bool validaInsertar(){
			bool response = true;
			
			if(cbOpeMB1.Checked == false && cbOpeB1.Checked == false && cbOpeM1.Checked == false && cbOpeMM1.Checked == false){
				errorProvider1.SetError(lblOperador1, "Selecciona una respuesta");
				cbOpeMB1.Focus();
				response = false;
			}
			if(cbOpeMB2.Checked == false && cbOpeB2.Checked == false && cbOpeM2.Checked == false && cbOpeMM2.Checked == false){
				errorProvider1.SetError(lblOperador2, "Selecciona una respuesta");
				cbOpeMB2.Focus();
				response = false;
			}
			if(cbOpeMB3.Checked == false && cbOpeB3.Checked == false && cbOpeM3.Checked == false && cbOpeMM3.Checked == false){
				errorProvider1.SetError(lblOperador3, "Selecciona una respuesta");
				cbOpeMB3.Focus();
				response = false;
			}
			
			if(cbUniMB1.Checked == false && cbUniB1.Checked == false && cbUniM1.Checked == false && cbUniMM1.Checked == false){
				errorProvider1.SetError(lblUnidad1, "Selecciona una respuesta");
				cbUniMB1.Focus();
				response = false;
			}
			if(cbUniMB2.Checked == false && cbUniB2.Checked == false && cbUniM2.Checked == false && cbUniMM2.Checked == false){
				errorProvider1.SetError(lblUnidad2, "Selecciona una respuesta");
				cbUniMB2.Focus();
				response = false;
			}
			if(cbUniMB3.Checked == false && cbUniB3.Checked == false && cbUniM3.Checked == false && cbUniMM3.Checked == false){
				errorProvider1.SetError(lblUnidad3, "Selecciona una respuesta");
				cbUniMB3.Focus();
				response = false;
			}
						
			if(cbAteMB1.Checked == false && cbAteB1.Checked == false && cbAteM1.Checked == false && cbAteMM1.Checked == false){
				errorProvider1.SetError(lblAtencion1, "Selecciona una respuesta");
				cbAteMB1.Focus();
				response = false;
			}		
			if(cbAteMB2.Checked == false && cbAteB2.Checked == false && cbAteM2.Checked == false && cbAteMM2.Checked == false){
				errorProvider1.SetError(lblAtencion2, "Selecciona una respuesta");
				cbAteMB2.Focus();
				response = false;
			}		
			if(cbAteMB3.Checked == false && cbAteB3.Checked == false && cbAteM3.Checked == false && cbAteMM3.Checked == false){
				errorProvider1.SetError(lblAtencion3, "Selecciona una respuesta");
				cbAteMB3.Focus();
				response = false;
			}
			
			if(cbPreMB1.Checked == false && cbPreB1.Checked == false && cbPreM1.Checked == false && cbPreMM1.Checked == false){
				errorProvider1.SetError(lblPrecio1, "Selecciona una respuesta");
				cbPreMB1.Focus();
				response = false;
			}
			if(cbPreMB2.Checked == false && cbPreB2.Checked == false && cbPreM2.Checked == false && cbPreMM2.Checked == false){
				errorProvider1.SetError(lblPrecio2, "Selecciona una respuesta");
				cbPreMB2.Focus();
				response = false;
			}
			if(cbPreMB3.Checked == false && cbPreB3.Checked == false && cbPreM3.Checked == false && cbPreMM3.Checked == false){
				errorProvider1.SetError(lblPrecio3, "Selecciona una respuesta");
				cbPreMB3.Focus();
				response = false;
			}
			
			if(cbSerMB1.Checked == false && cbSerB1.Checked == false && cbSerM1.Checked == false && cbSerMM1.Checked == false){
				errorProvider1.SetError(lblServicio1, "Selecciona una respuesta");
				cbSerMB1.Focus();
				response = false;
			}
			if(cbSerMB2.Checked == false && cbSerB2.Checked == false && cbSerM2.Checked == false && cbSerMM2.Checked == false){
				errorProvider1.SetError(lblServicio2, "Selecciona una respuesta");
				cbSerMB2.Focus();
				response = false;
			}
			if(cbSerMB3.Checked == false && cbSerB3.Checked == false && cbSerM3.Checked == false && cbSerMM3.Checked == false){
				errorProvider1.SetError(lblServicio3, "Selecciona una respuesta");
				cbSerMB3.Focus();
				response = false;
			}			
			
			if(cbPagoOperadorSI.Checked == false && cbPagoOperadorNO.Checked == false){
				errorProvider1.SetError(lblSeguimiento1, "Selecciona una respuesta");
				cbPagoOperadorSI.Focus();
				response = false;
			}else{
				if(cbPagoOperadorSI.Checked){
					if(txtPagoOperador.Text.Length == 0){
						errorProvider1.SetError(txtPagoOperador, "Ingresa el Monto");
						txtPagoOperador.Focus();
						response = false;
					}
				}
			}
			
			if(cbViajeProgramadoSI.Checked == false && cbViajeProgramadoNO.Checked == false){
				errorProvider1.SetError(lblSeguimiento2, "Selecciona una respuesta");
				cbViajeProgramadoSI.Focus();
				response = false;
			}else{
				if(cbViajeProgramadoSI.Checked){
					if(cmbDonde.SelectedIndex < 0){
						errorProvider1.SetError(cmbDonde, "Selecciona una respuesta");
						cmbDonde.Focus();
						response = false;
					}
				}
			}
						
			if(cbVolveriaSI.Checked == false && cbVolveriaNO.Checked == false){
				errorProvider1.SetError(lblSeguimiento3, "Selecciona una respuesta");
				cbVolveriaSI.Focus();
				response = false;
			}
			
			return response;
		}
						
		void insertaEncuesta(){
			connL.guardaEncuestaVenta(ID_RE, ID_U, 
			                          ((cbOpeMB1.Checked)? "MB" : ((cbOpeB1.Checked)? "B" : ((cbOpeM1.Checked)? "M" : "MM" ) ) ), txtOpeObs1.Text,
			                          ((cbOpeMB2.Checked)? "MB" : ((cbOpeB2.Checked)? "B" : ((cbOpeM2.Checked)? "M" : "MM" ) ) ), txtOpeObs2.Text,
			                          ((cbOpeMB3.Checked)? "MB" : ((cbOpeB3.Checked)? "B" : ((cbOpeM3.Checked)? "M" : "MM" ) ) ), txtOpeObs3.Text,
			                          ((cbUniMB1.Checked)? "MB" : ((cbUniB1.Checked)? "B" : ((cbUniM1.Checked)? "M" : "MM" ) ) ), txtUniObs1.Text,
			                          ((cbUniMB2.Checked)? "MB" : ((cbUniB2.Checked)? "B" : ((cbUniM2.Checked)? "M" : "MM" ) ) ), txtUniObs2.Text,
			                          ((cbUniMB3.Checked)? "MB" : ((cbUniB3.Checked)? "B" : ((cbUniM3.Checked)? "M" : "MM" ) ) ), txtUniObs3.Text,
			                          ((cbAteMB1.Checked)? "MB" : ((cbAteB1.Checked)? "B" : ((cbAteM1.Checked)? "M" : "MM" ) ) ), txtAteObs1.Text,
			                          ((cbAteMB2.Checked)? "MB" : ((cbAteB2.Checked)? "B" : ((cbAteM2.Checked)? "M" : "MM" ) ) ), txtAteObs2.Text,
			                          ((cbAteMB3.Checked)? "MB" : ((cbAteB3.Checked)? "B" : ((cbAteM3.Checked)? "M" : "MM" ) ) ), txtAteObs3.Text,
			                          ((cbPreMB1.Checked)? "MB" : ((cbPreB1.Checked)? "B" : ((cbPreM1.Checked)? "M" : "MM" ) ) ), txtPreObs1.Text,
			                          ((cbPreMB2.Checked)? "MB" : ((cbPreB2.Checked)? "B" : ((cbPreM2.Checked)? "M" : "MM" ) ) ), txtPreObs2.Text,
			                          ((cbPreMB3.Checked)? "MB" : ((cbPreB3.Checked)? "B" : ((cbPreM3.Checked)? "M" : "MM" ) ) ), txtPreObs3.Text,
			                          ((cbSerMB1.Checked)? "MB" : ((cbSerB1.Checked)? "B" : ((cbSerM1.Checked)? "M" : "MM" ) ) ), txtSerObs1.Text,
			                          ((cbSerMB2.Checked)? "MB" : ((cbSerB2.Checked)? "B" : ((cbSerM2.Checked)? "M" : "MM" ) ) ), txtSerObs2.Text,
			                          ((cbSerMB3.Checked)? "MB" : ((cbSerB3.Checked)? "B" : ((cbSerM3.Checked)? "M" : "MM" ) ) ), txtSerObs3.Text, lblCalTotal.Text,
			                          ((cbPagoOperadorSI.Checked)? "SI" : "NO" ), txtPagoOperador.Text, ((cbViajeProgramadoSI.Checked)? "SI" : "NO" ), 
			                          cmbDonde.Text, cmbMes.Text, ((cbVolveriaSI.Checked)? "SI" : "NO" ), txtObservaciones.Text, ((cbGenteAjenaSi.Checked)? "SI" : "NO" ));
			MessageBox.Show("Se guardó correctamente la encuesta", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			libro.dgEncuesta.Rows.RemoveAt(libro.dgEncuesta.CurrentRow.Index);
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void FormEncuestaPost2KeyUp(object sender, KeyEventArgs e)
		{			
			if(e.KeyCode == Keys.Escape){				
				DialogResult rs = MessageBox.Show("¿Deseas salir de la encuesta?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs)
					this.Close();
			}
		}
		
			#region OPERADOR			
			void CbOpeMB1CheckedChanged(object sender, EventArgs e)
			{
				cbOpeB1.Checked = false;
				cbOpeM1.Checked = false;
				cbOpeMM1.Checked = false;
				calificacion();
			}
			
			void CbOpeB1CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB1.Checked = false;
				cbOpeM1.Checked = false;
				cbOpeMM1.Checked = false;
				calificacion();
			}
			
			void CbOpeM1CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB1.Checked = false;
				cbOpeB1.Checked = false;
				cbOpeMM1.Checked = false;
				calificacion();
			}
			
			void CbOpeMM1CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB1.Checked = false;
				cbOpeB1.Checked = false;
				cbOpeM1.Checked = false;
				calificacion();
			}
			
			void CbOpeMB2CheckedChanged(object sender, EventArgs e)
			{
				cbOpeB2.Checked = false;
				cbOpeM2.Checked = false;
				cbOpeMM2.Checked = false;
				calificacion();
			}
			
			void CbOpeB2CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB2.Checked = false;
				cbOpeM2.Checked = false;
				cbOpeMM2.Checked = false;
				calificacion();
			}
			
			void CbOpeM2CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB2.Checked = false;
				cbOpeB2.Checked = false;
				cbOpeMM2.Checked = false;
				calificacion();
			}
			
			void CbOpeMM2CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB2.Checked = false;
				cbOpeB2.Checked = false;
				cbOpeM2.Checked = false;
				calificacion();
			}
			
			void CbOpeMB3CheckedChanged(object sender, EventArgs e)
			{
				cbOpeB3.Checked = false;
				cbOpeM3.Checked = false;
				cbOpeMM3.Checked = false;
				calificacion();
			}
			
			void CbOpeB3CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB3.Checked = false;
				cbOpeM3.Checked = false;
				cbOpeMM3.Checked = false;
				calificacion();
			}
			
			void CbOpeM3CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB3.Checked = false;
				cbOpeB3.Checked = false;
				cbOpeMM3.Checked = false;
				calificacion();
			}
			
			void CbOpeMM3CheckedChanged(object sender, EventArgs e)
			{
				cbOpeMB3.Checked = false;
				cbOpeB3.Checked = false;
				cbOpeM3.Checked = false;
				calificacion();
			}
			#endregion
		
			#region UNIDAD
			void CbUniMB1CheckedChanged(object sender, EventArgs e)
			{
				cbUniB1.Checked = false;
				cbUniM1.Checked = false;
				cbUniMM1.Checked = false;
				calificacion();
			}
			
			void CbUniB1CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB1.Checked = false;
				cbUniM1.Checked = false;
				cbUniMM1.Checked = false;
				calificacion();
			}
			
			void CbUniM1CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB1.Checked = false;
				cbUniB1.Checked = false;
				cbUniMM1.Checked = false;
				calificacion();
			}
			
			void CbUniMM1CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB1.Checked = false;
				cbUniB1.Checked = false;
				cbUniM1.Checked = false;
				calificacion();
			}
			
			void CbUniMB2CheckedChanged(object sender, EventArgs e)
			{
				cbUniB2.Checked = false;
				cbUniM2.Checked = false;
				cbUniMM2.Checked = false;
				calificacion();
			}
			
			void CbUniB2CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB2.Checked = false;
				cbUniM2.Checked = false;
				cbUniMM2.Checked = false;
				calificacion();
			}
			
			void CbUniM2CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB2.Checked = false;
				cbUniB2.Checked = false;
				cbUniMM2.Checked = false;
				calificacion();
			}
			
			void CbUniMM2CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB2.Checked = false;
				cbUniB2.Checked = false;
				cbUniM2.Checked = false;
				calificacion();
			}
			
			void CbUniMB3CheckedChanged(object sender, EventArgs e)
			{
				cbUniB3.Checked = false;
				cbUniM3.Checked = false;
				cbUniMM3.Checked = false;
				calificacion();
			}
			
			void CbUniB3CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB3.Checked = false;
				cbUniM3.Checked = false;
				cbUniMM3.Checked = false;
				calificacion();
			}
			
			void CbUniM3CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB3.Checked = false;
				cbUniB3.Checked = false;
				cbUniMM3.Checked = false;
				calificacion();
			}
			
			void CbUniMM3CheckedChanged(object sender, EventArgs e)
			{
				cbUniMB3.Checked = false;
				cbUniB3.Checked = false;
				cbUniM3.Checked = false;
				calificacion();
			}
			#endregion
			
			#region ATENCION A CLIENTES
			void CbAteMB1CheckedChanged(object sender, EventArgs e)
			{
				cbAteB1.Checked = false;
				cbAteM1.Checked = false;
				cbAteMM1.Checked = false;
				calificacion();
			}
			
			void CbAteB1CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB1.Checked = false;
				cbAteM1.Checked = false;
				cbAteMM1.Checked = false;
				calificacion();
			}
			
			void CbAteM1CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB1.Checked = false;
				cbAteB1.Checked = false;
				cbAteMM1.Checked = false;
				calificacion();
			}
			
			void CbAteMM1CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB1.Checked = false;
				cbAteB1.Checked = false;
				cbAteM1.Checked = false;
				calificacion();
			}
			
			void CbAteMB2CheckedChanged(object sender, EventArgs e)
			{
				cbAteB2.Checked = false;
				cbAteM2.Checked = false;
				cbAteMM2.Checked = false;
				calificacion();
			}
			
			void CbAteB2CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB2.Checked = false;
				cbAteM2.Checked = false;
				cbAteMM2.Checked = false;
				calificacion();
			}
			
			void CbAteM2CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB2.Checked = false;
				cbAteB2.Checked = false;
				cbAteMM2.Checked = false;
				calificacion();
			}
			
			void CbAteMM2CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB2.Checked = false;
				cbAteB2.Checked = false;
				cbAteM2.Checked = false;
				calificacion();
			}
			
			void CbAteMB3CheckedChanged(object sender, EventArgs e)
			{
				cbAteB3.Checked = false;
				cbAteM3.Checked = false;
				cbAteMM3.Checked = false;
				calificacion();
			}
			
			void CbAteB3CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB3.Checked = false;
				cbAteM3.Checked = false;
				cbAteMM3.Checked = false;
				calificacion();
			}
			
			void CbAteM3CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB3.Checked = false;
				cbAteB3.Checked = false;
				cbAteMM3.Checked = false;
				calificacion();
			}
			
			void CbAteMM3CheckedChanged(object sender, EventArgs e)
			{
				cbAteMB3.Checked = false;
				cbAteB3.Checked = false;
				cbAteM3.Checked = false;
				calificacion();
			}
			#endregion
			
			#region PRECIO
			void CbPreMB1CheckedChanged(object sender, EventArgs e)
			{
				cbPreB1.Checked = false;
				cbPreM1.Checked = false;
				cbPreMM1.Checked = false;
				calificacion();
			}
			
			void CbPreB1CheckedChanged(object sender, EventArgs e)
			{			
				cbPreMB1.Checked = false;
				cbPreM1.Checked = false;
				cbPreMM1.Checked = false;
				calificacion();
			}
			
			void CbPreM1CheckedChanged(object sender, EventArgs e)
			{			
				cbPreMB1.Checked = false;
				cbPreB1.Checked = false;
				cbPreMM1.Checked = false;
				calificacion();
			}
			
			void CbPreMM1CheckedChanged(object sender, EventArgs e)
			{
				cbPreMB1.Checked = false;
				cbPreB1.Checked = false;
				cbPreM1.Checked = false;
				calificacion();
			}
			
			void CbPreMB2CheckedChanged(object sender, EventArgs e)
			{
				cbPreB2.Checked = false;
				cbPreM2.Checked = false;
				cbPreMM2.Checked = false;
				calificacion();
			}
			
			void CbPreB2CheckedChanged(object sender, EventArgs e)
			{
				cbPreMB2.Checked = false;
				cbPreM2.Checked = false;
				cbPreMM2.Checked = false;
				calificacion();
			}
			
			void CbPreM2CheckedChanged(object sender, EventArgs e)
			{
				cbPreMB2.Checked = false;
				cbPreB2.Checked = false;
				cbPreMM2.Checked = false;
				calificacion();
			}
			
			void CbPreMM2CheckedChanged(object sender, EventArgs e)
			{
				cbPreMB2.Checked = false;
				cbPreB2.Checked = false;
				cbPreM2.Checked = false;
				calificacion();
			}
			
			void CbPreMB3CheckedChanged(object sender, EventArgs e)
			{
				cbPreB3.Checked = false;
				cbPreM3.Checked = false;
				cbPreMM3.Checked = false;
				calificacion();
			}
			
			void CbPreB3CheckedChanged(object sender, EventArgs e)
			{
				cbPreMB3.Checked = false;
				cbPreM3.Checked = false;
				cbPreMM3.Checked = false;
				calificacion();
			}
			
			void CbPreM3CheckedChanged(object sender, EventArgs e)
			{
				cbPreMB3.Checked = false;
				cbPreB3.Checked = false;
				cbPreMM3.Checked = false;
				calificacion();
			}
			
			void CbPreMM3CheckedChanged(object sender, EventArgs e)
			{
				cbPreMB3.Checked = false;
				cbPreB3.Checked = false;
				cbPreM3.Checked = false;
				calificacion();
			}
			#endregion
			
			#region SERVICIO
			void CbSerMB1CheckedChanged(object sender, EventArgs e)
			{
				cbSerB1.Checked = false;
				cbSerM1.Checked = false;
				cbSerMM1.Checked = false;
				calificacion();
			}
			
			void CbSerB1CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB1.Checked = false;
				cbSerM1.Checked = false;
				cbSerMM1.Checked = false;
				calificacion();
			}
			
			void CbSerM1CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB1.Checked = false;
				cbSerB1.Checked = false;
				cbSerMM1.Checked = false;
				calificacion();
			}
			
			void CbSerMM1CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB1.Checked = false;
				cbSerB1.Checked = false;
				cbSerM1.Checked = false;
				calificacion();
			}
			
			void CbSerMB2CheckedChanged(object sender, EventArgs e)
			{
				cbSerB2.Checked = false;
				cbSerM2.Checked = false;
				cbSerMM2.Checked = false;
				calificacion();
			}
			
			void CbSerB2CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB2.Checked = false;
				cbSerM2.Checked = false;
				cbSerMM2.Checked = false;
				calificacion();
			}
			
			void CbSerM2CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB2.Checked = false;
				cbSerB2.Checked = false;
				cbSerMM2.Checked = false;
				calificacion();
			}
			
			void CbSerMM2CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB2.Checked = false;
				cbSerB2.Checked = false;
				cbSerM2.Checked = false;
				calificacion();
			}
			
			void CbSerMB3CheckedChanged(object sender, EventArgs e)
			{
				cbSerB3.Checked = false;
				cbSerM3.Checked = false;
				cbSerMM3.Checked = false;
				calificacion();
			}
			
			void CbSerB3CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB3.Checked = false;
				cbSerM3.Checked = false;
				cbSerMM3.Checked = false;
				calificacion();
			}
			
			void CbSerM3CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB3.Checked = false;
				cbSerB3.Checked = false;
				cbSerMM3.Checked = false;
				calificacion();
			}
			
			void CbSerMM3CheckedChanged(object sender, EventArgs e)
			{
				cbSerMB3.Checked = false;
				cbSerB3.Checked = false;
				cbSerM3.Checked = false;
				calificacion();
			}
			#endregion	

			#region SEGUIMIENTO
			void CbPagoOperadorSICheckedChanged(object sender, EventArgs e)
			{
				cbPagoOperadorNO.Checked = false;
				txtPagoOperador.Enabled = true;
			}
			
			void CbPagoOperadorNOCheckedChanged(object sender, EventArgs e)
			{
				cbPagoOperadorSI.Checked = false;
				txtPagoOperador.Enabled = false;
				txtPagoOperador.Text = "";
			}
			
			void CbViajeProgramadoSICheckedChanged(object sender, EventArgs e)
			{
				cbViajeProgramadoNO.Checked = false;
				cmbDonde.Enabled = true;
				cmbMes.Enabled = true;
			}
			
			void CbViajeProgramadoNOCheckedChanged(object sender, EventArgs e)
			{
				cbViajeProgramadoSI.Checked = false;
				cmbDonde.Enabled = false;
				cmbMes.Enabled = false;
				cmbDonde.SelectedIndex = -1;
				cmbMes.SelectedIndex = -1;				
			}
			
			void CbVolveriaSICheckedChanged(object sender, EventArgs e)
			{
				cbVolveriaNO.Checked = false;
			}
			
			void CbVolveriaNOCheckedChanged(object sender, EventArgs e)
			{
				cbVolveriaSI.Checked = false;
			}
			
			void CbGenteAjenaSiCheckedChanged(object sender, EventArgs e)
			{
				cbGenteAjenaNo.Checked=false;
			}
			
			void CbGenteAjenaNoCheckedChanged(object sender, EventArgs e)
			{
				cbGenteAjenaSi.Checked=false;
			}
			#endregion
		
		#endregion
		
		#region BOTONES
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(validaInsertar()){
				if(connL.validarExisteEncuestaVenta(ID_RE)){
					DialogResult rs = MessageBox.Show("¿Deseas sobreescribir la encuesta?" , "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if(rs == DialogResult.Yes)
						insertaEncuesta();	
				}else
					insertaEncuesta();			
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		
	}
}
