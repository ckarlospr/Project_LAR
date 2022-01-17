using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Net.Mail;
using System.Net.Mime;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{	public partial class FormReportes : Form
	{
		
		#region INSTANCIAS
		FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.SQL_Conexion conn2 = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Combustible.SQL_Combustible connC = new Conexion_Servidor.Combustible.SQL_Combustible();
		#endregion
		
		#region CONSTRUCTOR
		public FormReportes(FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}		
		#endregion
		
		#region INICIO - FIN
		void FormReportesLoad(object sender, EventArgs e)
		{
			dtInicio.Value = DateTime.Now;
			dtCorte.Value = DateTime.Now;
			if(refPrincipal.lblDatoNivel.Text == "GERENCIAL" || refPrincipal.lblDatoNivel.Text == "MASTER")
				pbConfiguraciones.Visible = true;	
		}
		
		void FormReportesFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.reportVentas = false;
		}		
		#endregion
		
		#region BOTONES
		void PbConfiguracionesClick(object sender, EventArgs e)
		{
			new formParametro(refPrincipal.idUsuario).ShowDialog();
		}
		
		void BtnReporteEnvioClick(object sender, EventArgs e)
		{
			string directorio = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string nombre = "Reporte de DIARIO - ENVIO "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy") + "A LAS "+DateTime.Now.ToString("HH.mm");			
			string correoPara = connC.obtenerParametroPrueba(3);
			string correoPara2 = connC.obtenerParametroPrueba2(3);
			generarReporteEnvio(directorio, nombre);
			if(respuestaEnvio){
				string archivo = directorio+"\\"+nombre+".xlsx";
				MailMessage message = new MailMessage("ventas@lar.com.mx", correoPara, "Reporte de especiales", "");
				if(correoPara2.Length > 5)
					message.To.Add(correoPara2);
		 		if(System.IO.File.Exists(archivo))
					 message.Attachments.Add(new Attachment(archivo));	
		 		 
				SmtpClient smtpclient = new SmtpClient("mail.lar.com.mx");
				smtpclient.Port = 587;
				smtpclient.UseDefaultCredentials = false;
				smtpclient.Credentials = new System.Net.NetworkCredential("ventas@lar.com.mx", "LAR1249.5");
				smtpclient.EnableSsl = false;
	         	message.Priority = MailPriority.High;
	         	message.IsBodyHtml = false;
	         	try{
	         		smtpclient.Send(message);
					MessageBox.Show("Mensaje enviado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					actualizaEnvio();
	         	}catch(Exception ex){
	         		MessageBox.Show("Mensaje no se envio : "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
					//System.IO.File.Delete(directorio+"\\"+nombre+".xlsx");
			}
		}	
		
		
		void BtnExcelReporteClick(object sender, EventArgs e)
		{
			generarReporteDiario();
		}		
		
		void BtnUsuariosClick(object sender, EventArgs e)
		{
			generarReportePOperador();
		}
		
		void BtnPostventaClick(object sender, EventArgs e)
		{		
			generarReportePostVenta();
		}
		
		void BtnCanceladosClick(object sender, EventArgs e)
		{
			generarReporteCancelado();
		}		
		
		void BtnReporteFullClick(object sender, EventArgs e)
		{
			generarReporteCompleto();
		}
			void Button1Click(object sender, EventArgs e)
		{
				generarReporteCombu();
		}
		#endregion
		
		#region METODOS		
		public void generarReporteCompleto(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "COMPAÑIA";
			ExcelApp.Cells[i,  2] 	= "NOMBRE COMPAÑIA";
			ExcelApp.Cells[i,  3] 	= "CONTACTO";
			ExcelApp.Cells[i,  4] 	= "DESTINO";
			ExcelApp.Cells[i,  5] 	= "LOCAL/FORÁNEO";
			ExcelApp.Cells[i,  6] 	= "TIPO DE VEHICULO";
			ExcelApp.Cells[i,  7] 	= "CANTIDAD VEHICULO";
			ExcelApp.Cells[i,  8] 	= "PRECIO POR VEHICULO";
			ExcelApp.Cells[i,  9] 	= "FACTURA";			
			ExcelApp.Cells[i,  10] 	= "PRECIO POR SERVICIO";
			ExcelApp.Cells[i,  11] 	= "FECHA SALIDA";			
			ExcelApp.Cells[i,  12] 	= "FECHA REGRESO";
			ExcelApp.Cells[i,  13] 	= "PAGO OPERADOR";
			ExcelApp.Cells[i,  14] 	= "OPERADOR";
			ExcelApp.Cells[i,  15] 	= "NUMERO DE VEHICULO";
			ExcelApp.Cells[i,  16]  = "KM_SERVICIO";
			ExcelApp.Cells[i,  17]  = "KM_ITINERARIO";
			ExcelApp.Cells[i,  18]  = "ITINERARIO";
			ExcelApp.Cells[i,  19]  = "TELEFONO";
			
 		
			String consulta = @"SELECT VPN.FORANEO, VPN.SUELDO_OPERADOR, VPN.COMPANIA, VPN.COMPANIA_NOMBRE, VPN.CONTACTO, RE.DESTINO, VPN.TIPO_TRANSPOTE, VPN.CANTIDAD, VPN.PRECIO_UNITARIO, VPN.TOTAL_IVA, VPN.FACTURA, RE.FECHA_SALIDA, RE.FECHA_REGRESO, OP.Alias, V.Numero, VPN.KM_ITINERARIO, VPN.KM_SERVICIO, VPN.ITINERARIO, VPN.TELEFONO FROM RUTA_ESPECIAL RE JOIN RUTA R 
								ON R.IdSubEmpresa = RE.ID_C JOIN VIAJE_PROSPECTO_NUEVO VPN ON VPN.ID_RE = RE.ID_RE JOIN OPERACION O ON O.id_ruta = R.ID JOIN OPERACION_OPERADOR OO ON OO.id_operacion 
								= O.id_operacion JOIN OPERADOR OP ON OP.ID = OO.id_operador JOIN VEHICULO V ON V.ID = OO.id_vehiculo WHERE O.estatus != '0' AND 
								RE.estado = 'Activo' AND  r.Sentido = 'Entrada' AND RE.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"'  ORDER BY RE.FECHA_SALIDA";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["COMPANIA"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["COMPANIA_NOMBRE"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["CONTACTO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["DESTINO"].ToString();
				ExcelApp.Cells[i,  5]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL");
				ExcelApp.Cells[i,  6]	= 	conn.leer["TIPO_TRANSPOTE"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["CANTIDAD"].ToString();
				ExcelApp.Cells[i,  8]	= 	conn.leer["PRECIO_UNITARIO"].ToString();
				ExcelApp.Cells[i,  9]	= 	((conn.leer["FACTURA"].ToString().Equals("1"))? "SI": "NO" );
				ExcelApp.Cells[i,  10]	= 	conn.leer["TOTAL_IVA"].ToString();
				ExcelApp.Cells[i,  11]	= 	Convert.ToDateTime(conn.leer["FECHA_SALIDA"]).ToString("dd/MM/yyyy");
				ExcelApp.Cells[i,  12]	= 	Convert.ToDateTime(conn.leer["FECHA_REGRESO"]).ToString("dd/MM/yyyy");
				ExcelApp.Cells[i,  13]	= 	conn.leer["SUELDO_OPERADOR"].ToString();		
				ExcelApp.Cells[i,  14]	= 	conn.leer["Alias"].ToString();		
				ExcelApp.Cells[i,  15]	= 	conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  16]  =   conn.leer["KM_SERVICIO"].ToString();
				ExcelApp.Cells[i,  17]  =   conn.leer["ITINERARIO"].ToString();
				ExcelApp.Cells[i,  18]  =   conn.leer["KM_ITINERARIO"].ToString();
				ExcelApp.Cells[i,  19]  =   conn.leer["TELEFONO"].ToString();
				
				
			}
			conn.conexion.Close();
					
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte VENTAS - OPERADOR "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;			
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		public void generarReportePostVenta(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "COMPAÑIA";
			ExcelApp.Cells[i,  2] 	= "NOMBRE COMPAÑIA";
			ExcelApp.Cells[i,  3] 	= "CONTACTO";
			ExcelApp.Cells[i,  4] 	= "DESTINO";
			ExcelApp.Cells[i,  5] 	= "FECHA SALIDA";			
			ExcelApp.Cells[i,  6] 	= "FECHA REGRESO";
			ExcelApp.Cells[i,  7] 	= "OPERADOR";
			ExcelApp.Cells[i,  8] 	= "NUMERO DE VEHICULO";
			//
			ExcelApp.Cells[i,  9] 	= "El trato directo  del operador de su unidad fue:";
			ExcelApp.Cells[i,  10] 	= "Comentario";
			ExcelApp.Cells[i,  11] 	= "La presentación personal del operador fue:";
			ExcelApp.Cells[i,  12] 	= "Comentario";
			ExcelApp.Cells[i,  13] 	= "El manejo del operador le pareció:";
			ExcelApp.Cells[i,  14] 	= "Comentario";
			ExcelApp.Cells[i,  15] 	= "La limpieza exterior de la unidad fue:";
			ExcelApp.Cells[i,  16] 	= "Comentario";
			ExcelApp.Cells[i,  17] 	= "La limpieza interior de la unidad fue:";
			ExcelApp.Cells[i,  18] 	= "Comentario";
			ExcelApp.Cells[i,  19] 	= "¿Tuvo problemas la unidad en el viaje?";
			ExcelApp.Cells[i,  20] 	= "Comentario";
			ExcelApp.Cells[i,  21] 	= "El tiempo de respuesta  a su cotización fue:";
			ExcelApp.Cells[i,  22] 	= "Comentario";
			ExcelApp.Cells[i,  23] 	= "La información que le brindo el personal de ventas le pareció:";
			ExcelApp.Cells[i,  24] 	= "Comentario";
			ExcelApp.Cells[i,  25] 	= "El seguimiento del personal de ventas respecto a su servicio fue:";
			ExcelApp.Cells[i,  26] 	= "Comentario";
			ExcelApp.Cells[i,  27] 	= "La relación precio-calidad de su servicio le pareció:";
			ExcelApp.Cells[i,  28] 	= "Comentario";
			ExcelApp.Cells[i,  29] 	= "Los opciones de prepago fueron:";
			ExcelApp.Cells[i,  30] 	= "Comentario";
			ExcelApp.Cells[i,  31] 	= "El trato del personal que le apoyo en el cobro del servicio fue:";
			ExcelApp.Cells[i,  32] 	= "Comentario";
			ExcelApp.Cells[i,  33] 	= "La puntualidad de su servicio fue:";
			ExcelApp.Cells[i,  34] 	= "Comentario";
			ExcelApp.Cells[i,  35] 	= "¿La unidad que le llegó es la que usted solicitó?";
			ExcelApp.Cells[i,  36] 	= "Comentario";
			ExcelApp.Cells[i,  37] 	= "La recomendación que daría de nuestro servicio sería:";
			ExcelApp.Cells[i,  38] 	= "Comentario";
			ExcelApp.Cells[i,  39] 	= "Realizo algún pago pendiente de su servicio al operador:";
			ExcelApp.Cells[i,  40] 	= "Cuanto:";
			ExcelApp.Cells[i,  41] 	= "Tiene algún viaje programado próximamente:";
			ExcelApp.Cells[i,  42] 	= "a donde:";
			ExcelApp.Cells[i,  43] 	= "Cuando:";
			ExcelApp.Cells[i,  44] 	= "Volvería a contratarnos para sus próximos viajes:";
			ExcelApp.Cells[i,  45] 	= "Observaciones:";
			ExcelApp.Cells[i,  46] 	= "Calificacion";
			String consulta = @"SELECT VPN.COMPANIA, VPN.COMPANIA_NOMBRE, VPN.CONTACTO, RE.DESTINO, RE.FECHA_SALIDA, RE.FECHA_REGRESO, OP.Alias, V.Numero, E.* FROM RUTA_ESPECIAL RE JOIN RUTA R 
								ON R.IdSubEmpresa = RE.ID_C JOIN VIAJE_PROSPECTO_NUEVO VPN ON VPN.ID_RE = RE.ID_RE JOIN OPERACION O ON O.id_ruta = R.ID JOIN OPERACION_OPERADOR OO ON OO.id_operacion 
								= O.id_operacion JOIN OPERADOR OP ON OP.ID = OO.id_operador JOIN VEHICULO V ON V.ID = OO.id_vehiculo JOIN ENCUESTA_VENTAS E ON E.ID_RE = RE.ID_RE WHERE O.estatus != '0' AND 
								RE.estado = 'Activo' AND  r.Sentido = 'Entrada' AND RE.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"'  ORDER BY RE.FECHA_SALIDA";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["COMPANIA"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["COMPANIA_NOMBRE"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["CONTACTO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["DESTINO"].ToString();
				ExcelApp.Cells[i,  5]	= 	Convert.ToDateTime(conn.leer["FECHA_SALIDA"]).ToString("dd/MM/yyyy");
				ExcelApp.Cells[i,  6]	= 	Convert.ToDateTime(conn.leer["FECHA_REGRESO"]).ToString("dd/MM/yyyy");
				ExcelApp.Cells[i,  7]	= 	conn.leer["Alias"].ToString();		
				ExcelApp.Cells[i,  8]	= 	conn.leer["Numero"].ToString();
				
				ExcelApp.Cells[i,  9]	= 	conn.leer["operador1"].ToString();
				ExcelApp.Cells[i,  10]	= 	conn.leer["operadorComentario1"].ToString();
				ExcelApp.Cells[i,  11]	= 	conn.leer["operador2"].ToString();
				ExcelApp.Cells[i,  12]	= 	conn.leer["operadorComentario2"].ToString();
				ExcelApp.Cells[i,  13]	= 	conn.leer["operador3"].ToString();
				ExcelApp.Cells[i,  14]	= 	conn.leer["operadorComentario3"].ToString();
				ExcelApp.Cells[i,  15]	= 	conn.leer["unidad1"].ToString();
				ExcelApp.Cells[i,  16]	= 	conn.leer["unidadComentario1"].ToString();
				ExcelApp.Cells[i,  17]	= 	conn.leer["unidad2"].ToString();
				ExcelApp.Cells[i,  18]	= 	conn.leer["unidadComentario2"].ToString();
				ExcelApp.Cells[i,  19]	= 	conn.leer["unidad3"].ToString();
				ExcelApp.Cells[i,  20]	= 	conn.leer["unidadComentario3"].ToString();
				ExcelApp.Cells[i,  21]	= 	conn.leer["atencion1"].ToString();
				ExcelApp.Cells[i,  22]	= 	conn.leer["atencionComentario1"].ToString();
				ExcelApp.Cells[i,  23]	= 	conn.leer["atencion2"].ToString();
				ExcelApp.Cells[i,  24]	= 	conn.leer["atencionComentario2"].ToString();
				ExcelApp.Cells[i,  25]	= 	conn.leer["atencion3"].ToString();
				ExcelApp.Cells[i,  26]	= 	conn.leer["atencionComentario3"].ToString();
				ExcelApp.Cells[i,  27]	= 	conn.leer["precio1"].ToString();
				ExcelApp.Cells[i,  28]	= 	conn.leer["precioComentario1"].ToString();
				ExcelApp.Cells[i,  29]	= 	conn.leer["precio2"].ToString();
				ExcelApp.Cells[i,  30]	= 	conn.leer["precioComentario2"].ToString();
				ExcelApp.Cells[i,  31]	= 	conn.leer["precio3"].ToString();
				ExcelApp.Cells[i,  32]	= 	conn.leer["precioComentario3"].ToString();
				ExcelApp.Cells[i,  33]	= 	conn.leer["servicio1"].ToString();
				ExcelApp.Cells[i,  34]	= 	conn.leer["servicioComentario1"].ToString();
				ExcelApp.Cells[i,  35]	= 	conn.leer["servicio2"].ToString();
				ExcelApp.Cells[i,  36]	= 	conn.leer["servicioComentario2"].ToString();
				ExcelApp.Cells[i,  37]	= 	conn.leer["servicio3"].ToString();
				ExcelApp.Cells[i,  38]	= 	conn.leer["servicioComentario3"].ToString();
				ExcelApp.Cells[i,  39]	= 	conn.leer["seguimientoPagoOperador"].ToString();
				ExcelApp.Cells[i,  40]	= 	conn.leer["seguimientoPagoCuanto"].ToString();
				ExcelApp.Cells[i,  41]	= 	conn.leer["seguimientoViajeProgramado"].ToString();
				ExcelApp.Cells[i,  42]	= 	conn.leer["seguimientoViajeDonde"].ToString();
				ExcelApp.Cells[i,  43]	= 	conn.leer["seguimientoViajeMes"].ToString();
				ExcelApp.Cells[i,  44]	= 	conn.leer["seguimientoVolveria"].ToString();
				ExcelApp.Cells[i,  45]	= 	conn.leer["comentario"].ToString();
				ExcelApp.Cells[i,  46]	= 	conn.leer["calificacion"].ToString();
			}
			conn.conexion.Close();
					
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte POST VENTA "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		public void generarReporteCancelado(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "TIPO";
			ExcelApp.Cells[i,  3] 	= "CLIENTE";
			ExcelApp.Cells[i,  4] 	= "DESTINO";
			ExcelApp.Cells[i,  5] 	= "FECHA COTIZACION";			
			ExcelApp.Cells[i,  6] 	= "FECHA CONTRATO VIAJE";
			ExcelApp.Cells[i,  7] 	= "FECHA SALIDA";
			ExcelApp.Cells[i,  8] 	= "LOCAL/FORÁNEO";
			ExcelApp.Cells[i,  9] 	= "TIPO DE VEHICULO";
			ExcelApp.Cells[i,  10] 	= "CANTIDAD VEHICULO";
			ExcelApp.Cells[i,  11] 	= "FACTURA";
			ExcelApp.Cells[i,  12] 	= "PRECIO UNITARIO";
			ExcelApp.Cells[i,  13] 	= "TOTAL";
			ExcelApp.Cells[i,  14] 	= "FECHA DE CANCELADO";
			ExcelApp.Cells[i,  15] 	= "MOTIVO";
		
			String consulta = @"select VPN.ID_RE, VPN.CONTACTO, VPN.EVENTO, VPN.FECHA_REGISTRO, RE.FECHA, RE.FECHA_SALIDA, VPN.FORANEO, RE.tipoVehiculo, RE.CANT_UNIDADES, VPN.FACTURA, VPN.PRECIO_UNITARIO, 
								VPN.TOTAL_IVA, CC.FECHA_REGISTRO FECHA_C, CC.OBSERVACIONES, CC.SERVICIO_C from VIAJE_PROSPECTO_NUEVO VPN JOIN RUTA_ESPECIAL RE ON RE.ID_RE = VPN.ID_RE 
								JOIN CANCELACION_COTIZACION CC ON CC.ID_COTIZACION = VPN.ID WHERE VPN.FLUJO = '3' 
								AND RE.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' ORDER BY RE.FECHA_SALIDA";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID_RE"].ToString();
				ExcelApp.Cells[i,  2]	= 	"VIAJE";
				ExcelApp.Cells[i,  3]	= 	conn.leer["CONTACTO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["EVENTO"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["FECHA_REGISTRO"].ToString().Substring(0,10);		
				ExcelApp.Cells[i,  6]	= 	conn.leer["FECHA"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  7]	= 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);		
				ExcelApp.Cells[i,  8]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL");
				ExcelApp.Cells[i,  9]	= 	conn.leer["tipoVehiculo"].ToString();
				ExcelApp.Cells[i,  10]	= 	conn.leer["CANT_UNIDADES"].ToString();				
				ExcelApp.Cells[i,  11]	= 	((conn.leer["FACTURA"].ToString() == "1")? "SI": "NO");	
				ExcelApp.Cells[i,  12]	= 	conn.leer["PRECIO_UNITARIO"].ToString();
				ExcelApp.Cells[i,  13]	= 	conn.leer["TOTAL_IVA"].ToString();
				ExcelApp.Cells[i,  14]	= 	conn.leer["FECHA_C"].ToString();
				ExcelApp.Cells[i,  15]	= 	((conn.leer["OBSERVACIONES"].ToString().Replace(",", "").Replace(" ", "").Length > 0)? conn.leer["OBSERVACIONES"].ToString().Replace(",", ""): "  Factor Externo");
			}
			conn.conexion.Close();
			
			consulta = @"select VPN.ID_RE, VPN.CONTACTO, VPN.EVENTO, VPN.FECHA_REGISTRO, VPN.FECHA_SALIDA, VPN.FORANEO, VPN.TIPO_TRANSPOTE, VPN.CANTIDAD, VPN.PRECIO_UNITARIO,
						VPN.FACTURA, VPN.TOTAL_IVA, CC.FECHA_REGISTRO FECHA_C, CC.OBSERVACIONES, CC.SERVICIO_C, VPN.FACTURA from VIAJE_PROSPECTO_NUEVO VPN JOIN CANCELACION_COTIZACION CC 
						ON CC.ID_COTIZACION = VPN.ID WHERE VPN.FLUJO != '3'
						 AND VPN.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' ORDER BY VPN.FECHA_SALIDA";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;			
				ExcelApp.Cells[i,  1]	= 	"N/A";
				ExcelApp.Cells[i,  2]	= 	"COTIZACION";
				ExcelApp.Cells[i,  3]	= 	conn.leer["CONTACTO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["EVENTO"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["FECHA_REGISTRO"].ToString().Substring(0,10);		
				ExcelApp.Cells[i,  6]	= 	"N/A";
				ExcelApp.Cells[i,  7]	= 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);		
				ExcelApp.Cells[i,  8]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL");
				ExcelApp.Cells[i,  9]	= 	conn.leer["TIPO_TRANSPOTE"].ToString();
				ExcelApp.Cells[i,  10]	= 	conn.leer["CANTIDAD"].ToString();				
				ExcelApp.Cells[i,  11]	= 	((conn.leer["FACTURA"].ToString() == "1")? "SI": "NO");	
				ExcelApp.Cells[i,  12]	= 	conn.leer["PRECIO_UNITARIO"].ToString();
				ExcelApp.Cells[i,  13]	= 	conn.leer["TOTAL_IVA"].ToString();	
				ExcelApp.Cells[i,  14]	= 	conn.leer["FECHA_C"].ToString();
				ExcelApp.Cells[i,  15]	= 	((conn.leer["OBSERVACIONES"].ToString().Replace(",", "").Replace(" ", "").Length > 0)? conn.leer["OBSERVACIONES"].ToString().Replace(",", ""): "  Factor Externo");   
			}
			conn.conexion.Close();
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte de CANCELACIONES "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		public void generarReportePOperador(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "CLIENTE";
			ExcelApp.Cells[i,  3] 	= "CONTACTO";
			ExcelApp.Cells[i,  4] 	= "DESTINO";
			ExcelApp.Cells[i,  5] 	= "FECHA SALIDA";
			ExcelApp.Cells[i,  6] 	= "LOCAL/FORÁNEO";
			ExcelApp.Cells[i,  7] 	= "TIPO DE VEHICULO";
			ExcelApp.Cells[i,  8] 	= "CANTIDAD VEHICULO";
			ExcelApp.Cells[i,  9] 	= "PRECIO SERVICIO";
			ExcelApp.Cells[i,  10] 	= "OPERADOR";
			ExcelApp.Cells[i,  11] 	= "CANTIDAD COBRO OPERADOR";
		
			String consulta = @"select re.ID_RE, vpn.COMPANIA, vpn.COMPANIA_NOMBRE, vpn.CONTACTO, vpn.FECHA_SALIDA, vpn.CANTIDAD, vpn.FORANEO, ce.TIPO, ce.COBRO, vpn.TOTAL_IVA, ce.SALDO, vpn.TIPO_TRANSPOTE, VPN.EVENTO
 								from COBRO_ESPECIAL ce join RUTA_ESPECIAL re on re.ID_RE = ce.ID_RE join VIAJE_PROSPECTO_NUEVO vpn on vpn.ID_RE = ce.ID_RE  where TIPO = 'OPERADOR' 
								and re.PAGADO = '0' and vpn.FECHA_SALIDA between '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' order by vpn.FECHA_SALIDA";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID_RE"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["COMPANIA_NOMBRE"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["CONTACTO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["EVENTO"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  6]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL");
				ExcelApp.Cells[i,  7]	= 	conn.leer["TIPO_TRANSPOTE"].ToString();				
				ExcelApp.Cells[i,  8]	= 	conn.leer["CANTIDAD"].ToString();
				ExcelApp.Cells[i,  9]	= 	conn.leer["TOTAL_IVA"].ToString();
				ExcelApp.Cells[i,  10]	= 	conn.leer["COBRO"].ToString();				
				ExcelApp.Cells[i,  11]	= 	conn.leer["SALDO"].ToString();
			}
			conn.conexion.Close();
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte de PAGO OPERADOR "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}	
		
		public void generarReporteDiario(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int contador = 0;
			int i = 1;		
			
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "ID_C";
			ExcelApp.Cells[i,  3] 	= "COMPAÑIA";
			ExcelApp.Cells[i,  4] 	= "CLIENTE";
			ExcelApp.Cells[i,  5] 	= "CONTACTO";
			ExcelApp.Cells[i,  6] 	= "DESTINO";
			ExcelApp.Cells[i,  7] 	= "TIPO SERVICIO";
			ExcelApp.Cells[i,  8] 	= "FECHA COTIZACION";			
			ExcelApp.Cells[i,  9] 	= "FECHA CONTRATO VIAJE";
			ExcelApp.Cells[i,  10] 	= "FECHA SALIDA";
			ExcelApp.Cells[i,  11] 	= "LOCAL/FORÁNEO";
			ExcelApp.Cells[i,  12] 	= "TIPO DE CLIENTE";
			ExcelApp.Cells[i,  13] 	= "TIPO DE VEHICULO";
			ExcelApp.Cells[i,  14] 	= "CANTIDAD VEHICULO";
			ExcelApp.Cells[i,  15] 	= "IMPORTE";
			ExcelApp.Cells[i,  16] 	= "FUENTE";
			ExcelApp.Cells[i,  17] 	= "KM";
			ExcelApp.Cells[i,  18] 	= "TELEFONO";
			
			String consulta = @"select vpn.MEDIO_ENTERO, vpn.ID_RE, r.ID_C, vpn.COMPANIA, vpn.COMPANIA_NOMBRE, vpn.FORANEO, vpn.CONTACTO, vpn.FECHA_REGISTRO FechaCotizacion, r.FECHA FechaViaje, r.FECHA_SALIDA, vpn.TIPO_CLIENTE, r.tipoVehiculo,
								 r.CANT_UNIDADES, vpn.TOTAL_IVA, vpn.EVENTO, vpn.DETALLE, vpn.KM_SERVICIO, vpn.TELEFONO  from VIAJE_PROSPECTO_NUEVO vpn join RUTA_ESPECIAL r on vpn.ID_RE = r.ID_RE 
								where r.estado = 'Activo' and vpn.FLUJO = '3' and r.FECHA_SALIDA between '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' order by r.FECHA_SALIDA";						
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;				
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID_RE"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["ID_C"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["COMPANIA"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["COMPANIA_NOMBRE"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["CONTACTO"].ToString();				
				ExcelApp.Cells[i,  6]	= 	conn.leer["EVENTO"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["DETALLE"].ToString();				
				ExcelApp.Cells[i,  8]	= 	conn.leer["FechaCotizacion"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  9]	= 	conn.leer["FechaViaje"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  10]	= 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);				
				ExcelApp.Cells[i,  11]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL");			
				ExcelApp.Cells[i,  12]	= 	conn.leer["TIPO_CLIENTE"].ToString();				
				ExcelApp.Cells[i,  13]	= 	conn.leer["tipoVehiculo"].ToString();
				ExcelApp.Cells[i,  14]	= 	conn.leer["CANT_UNIDADES"].ToString();		
				ExcelApp.Cells[i,  15]	= 	conn.leer["TOTAL_IVA"].ToString();		
				ExcelApp.Cells[i,  16]	= 	conn.leer["MEDIO_ENTERO"].ToString();
				ExcelApp.Cells[i,  17]	= 	conn.leer["KM_SERVICIO"].ToString();
				ExcelApp.Cells[i,  18]	= 	conn.leer["TELEFONO"].ToString();
				contador++;
			}
			conn.conexion.Close();
			/*
			for(int x = 1; x<=contador+1; x++){
				consulta = @"select op.Alias from  ruta r join OPERACION o on r.ID = o.id_ruta join OPERACION_OPERADOR oo on o.id_operacion = oo.id_operacion join OPERADOR op on oo.id_operador = op.ID
							where r.IdSubEmpresa = "+ExcelApp.Cells[x, 2].ToString()+" and o.estatus = 1 ";						
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(ExcelApp.Cells[x,  16].ToString() =="")
						ExcelApp.Cells[x,  16]	= 	ExcelApp.Cells[x,  16] +""+ conn.leer["Alias"].ToString();
					else						
						ExcelApp.Cells[x,  16]	= 	ExcelApp.Cells[x,  16] +", " +conn.leer["Alias"].ToString();
				}conn.conexion.Close();			
			}
				*/
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte de DIARIO "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		public void generarReporteEnvio(string directorio, string nombre){
			string fecha = "";
			string hora = "";
			string consulta = @"select TIPO, FECHA, FECHA_NOT, HORA_NOT from NOTIFICACIONES_ENVIOS_CORREO where  ESTATUS = '1' AND TIPO = 'RUTA ESPECIAL'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){		
				fecha =	conn.leer["FECHA_NOT"].ToString().Substring(0,10);
				hora =	conn.leer["HORA_NOT"].ToString();
			}
			conn.conexion.Close();
			
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "FECHA SERVICIO";
			ExcelApp.Cells[i,  2] 	= "HORA SERVICIO";
			ExcelApp.Cells[i,  3] 	= "TIPO DE VEHICULO";
			ExcelApp.Cells[i,  4] 	= "CAPACIDAD";
			ExcelApp.Cells[i,  5] 	= "LOCAL/FORÁNEO";
			ExcelApp.Cells[i,  6] 	= "DESTINO";
			ExcelApp.Cells[i,  7] 	= "TIPO SERVICIO";
			ExcelApp.Cells[i,  8] 	= "FECHA REGRESO";
			ExcelApp.Cells[i,  9] 	= "HORA REGRESO";			
			ExcelApp.Cells[i,  10] 	= "CANTIDAD VEHICULO";
			ExcelApp.Cells[i,  11] 	= "PRECIO UNITARIO";
			ExcelApp.Cells[i,  12] 	= "IMPORTE TOTAL";
			ExcelApp.Cells[i,  13] 	= "IMPORTE NETO";
		
			
			consulta = @"select re.FECHA_SALIDA, re.H_PLANTON, re.tipoVehiculo, re.cantidad_usuarios, CASE WHEN vpn.TIPO_CLIENTE = '1' THEN 'LOCAL' ELSE 'FORANEO' END tipo, re.DESTINO, 
						re.FECHA_REGRESO, vpn.HORA_REGRESO, vpn.PRECIO_UNITARIO, vpn.TOTAL, vpn.TOTAL_IVA, RE.CANT_UNIDADES, vpn.DETALLE from RUTA_ESPECIAL re JOIN VIAJE_PROSPECTO_NUEVO vpn 
						on vpn.ID_RE = re.ID_RE where re.estado = 'Activo' and vpn.FECHA_SALIDA >= '"+DateTime.Now.ToString("yyyy-MM-dd")+"' and vpn.FECHA_REGISTRO > '"+fecha
						+"' and vpn.HORA_REGISTRO > '"+hora+"' and re.estado = 'Activo' ORDER BY re.FECHA_SALIDA";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  2]	= 	conn.leer["H_PLANTON"].ToString().Substring(0,5);
				ExcelApp.Cells[i,  3]	= 	conn.leer["tipoVehiculo"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["cantidad_usuarios"].ToString();
				ExcelApp.Cells[i,  5]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL"); //aqui
				ExcelApp.Cells[i,  6]	= 	conn.leer["DESTINO"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["DETALLE"].ToString();
				ExcelApp.Cells[i,  8]	= 	conn.leer["FECHA_REGRESO"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  9]	= 	conn.leer["HORA_REGRESO"].ToString().Substring(0,5);
				ExcelApp.Cells[i,  10]	= 	conn.leer["CANT_UNIDADES"].ToString();
				ExcelApp.Cells[i,  11]	= 	conn.leer["PRECIO_UNITARIO"].ToString();
				ExcelApp.Cells[i,  12]	= 	conn.leer["TOTAL"].ToString();
				ExcelApp.Cells[i,  13]	= 	conn.leer["TOTAL_IVA"].ToString();
								
				if (refPrincipal.progressbarPrin.Value<100)
	               		refPrincipal.progressbarPrin.Value += 5;				
			}
			conn.conexion.Close();
			
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = directorio;
			CuadroDialogo.FileName = nombre;
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				respuestaEnvio = true;
			}else{
				respuestaEnvio = false;
			}
			refPrincipal.progressbarPrin.Value = 0;
		}
		
		private void actualizaEnvio(){
			string consulta = @"update  NOTIFICACIONES_ENVIOS_CORREO set FECHA_NOT = '"+DateTime.Now.ToString("yyyy-MM-dd")+"', HORA_NOT = '"+DateTime.Now.ToString("HH:mm")+"' where  id = 1";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();			
			conn.conexion.Close();
		}
		
		public void generarReporteCombu(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "COMPAÑIA";
			ExcelApp.Cells[i,  2] 	= "NOMBRE COMPAÑIA";
			ExcelApp.Cells[i,  3] 	= "DESTINO";
			ExcelApp.Cells[i,  4] 	= "TIPO DE VEHICULO";
			ExcelApp.Cells[i,  5] 	= "CANTIDAD VEHICULO";
			ExcelApp.Cells[i,  6] 	= "FECHA SALIDA";			
			ExcelApp.Cells[i,  7] 	= "FECHA REGRESO";
			ExcelApp.Cells[i,  8] 	= "OPERADOR";
			ExcelApp.Cells[i,  9] 	= "NUMERO DE VEHICULO";
			ExcelApp.Cells[i,  10]  = "KM_SERVICIO";
			ExcelApp.Cells[i,  11]  = "ITINERARIO";
			ExcelApp.Cells[i,  12]  = "KM_ITINERARIO";
			
 		
			String consulta = @"SELECT VPN.COMPANIA, VPN.COMPANIA_NOMBRE, RE.DESTINO, VPN.TIPO_TRANSPOTE, VPN.CANTIDAD, RE.FECHA_SALIDA, RE.FECHA_REGRESO, OP.Alias, V.Numero, VPN.KM_ITINERARIO, VPN.KM_SERVICIO, VPN.ITINERARIO FROM RUTA_ESPECIAL RE JOIN RUTA R 
								ON R.IdSubEmpresa = RE.ID_C JOIN VIAJE_PROSPECTO_NUEVO VPN ON VPN.ID_RE = RE.ID_RE JOIN OPERACION O ON O.id_ruta = R.ID JOIN OPERACION_OPERADOR OO ON OO.id_operacion 
								= O.id_operacion JOIN OPERADOR OP ON OP.ID = OO.id_operador JOIN VEHICULO V ON V.ID = OO.id_vehiculo WHERE O.estatus != '0' AND 
								RE.estado = 'Activo' AND  r.Sentido = 'Entrada' AND RE.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"'  ORDER BY RE.FECHA_SALIDA";

			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["COMPANIA"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["COMPANIA_NOMBRE"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["DESTINO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["TIPO_TRANSPOTE"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["CANTIDAD"].ToString();
				ExcelApp.Cells[i,  6]	= 	Convert.ToDateTime(conn.leer["FECHA_SALIDA"]).ToString("dd/MM/yyyy");
				ExcelApp.Cells[i,  7]	= 	Convert.ToDateTime(conn.leer["FECHA_REGRESO"]).ToString("dd/MM/yyyy");
				ExcelApp.Cells[i,  8]	= 	conn.leer["Alias"].ToString();		
				ExcelApp.Cells[i,  9]	= 	conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  10]  =   conn.leer["KM_SERVICIO"].ToString();
				ExcelApp.Cells[i,  11]  =   conn.leer["ITINERARIO"].ToString();
				ExcelApp.Cells[i,  12]  =   conn.leer["KM_ITINERARIO"].ToString();
				
				
			}
			conn.conexion.Close();
					
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte Especiales Combustible"+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		public void generarReporteApoyos(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "ID";
			ExcelApp.Cells[i,  2] 	= "Usuario";
			ExcelApp.Cells[i,  3] 	= "DIA";
			ExcelApp.Cells[i,  4] 	= "TURNO";
			ExcelApp.Cells[i,  5] 	= "TIPO";
			ExcelApp.Cells[i,  6] 	= "COMENTARIOS";
			ExcelApp.Cells[i,  7] 	= "NOMBRE";
			ExcelApp.Cells[i,  8] 	= "OPERADOR_APOYO";
			ExcelApp.Cells[i,  9] 	= "EMPRESA";
			ExcelApp.Cells[i,  10]  = "SALDO";
 		
			String consulta = @"select a.ID,u.usuario, a.DIA, a.TURNO, a.TIPO, a.COMENTARIOS, r.Nombre, o.Alias as Operador_Apoyo, c.Empresa, via.SALDO from APOYOS a, RUTA r, OPERADOR o, Cliente c, usuario u, VALOR_IMPORTE_APOYOS via 
							    WHERE via.TAMANO = a.TIPO and a.ID_U = u.id_usuario and a.ID_RUTA = r.ID and r.IdSubEmpresa = c.ID and a.ID_OP_APOYO = o.ID and  a.DIA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"'  ORDER BY a.DIA";

			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["USUARIO"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["DIA"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["TURNO"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["TIPO"].ToString();
				ExcelApp.Cells[i,  6]	= 	conn.leer["COMENTARIOS"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["NOMBRE"].ToString();
				ExcelApp.Cells[i,  8]   =   conn.leer["Operador_Apoyo"].ToString();
				ExcelApp.Cells[i,  9]   =   conn.leer["EMPRESA"].ToString();
				ExcelApp.Cells[i,  10]  =   conn.leer["SALDO"].ToString();
				
			}
			conn.conexion.Close();
					
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte Apoyos"+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}		
		#endregion	
		
		#region VARIABLES
		bool respuestaEnvio = true;		
		#endregion
		
		#region BotonTotal
		
		void BtnTotalClick(object sender, EventArgs e)
		{
			generarReporteTotal();
		}
		
		#endregion
		
		#region ReporteBotonTotal
		
		public void generarReporteTotal(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 40;			
			int contador = 0;
			int i = 1;				
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "ID_C";
			ExcelApp.Cells[i,  3] 	= "COMPAÑIA";
			ExcelApp.Cells[i,  4] 	= "COMPAÑIA NOMBRE";
			ExcelApp.Cells[i,  5] 	= "CONTACTO";
			ExcelApp.Cells[i,  6] 	= "CLIENTE";
			ExcelApp.Cells[i,  7] 	= "DESTINO";
			ExcelApp.Cells[i,  8] 	= "LOCAL/FORÁNEO";	
			ExcelApp.Cells[i,  9] 	= "FECHA COTIZACION";		
			ExcelApp.Cells[i,  10] 	= "FECHA CLIENTE";	
			ExcelApp.Cells[i,  11] 	= "FECHA SALIDA";
			ExcelApp.Cells[i,  12] 	= "FECHA REGRESO";	
			ExcelApp.Cells[i,  13] 	= "FECHA CANCELACIÓN";	
			ExcelApp.Cells[i,  14] 	= "TIPO DE VEHICULO";	
			ExcelApp.Cells[i,  15] 	= "CANTIDAD";
			ExcelApp.Cells[i,  16] 	= "PRECIO UNITARIO";
			ExcelApp.Cells[i,  17] 	= "TOTAL";
			ExcelApp.Cells[i,  18] 	= "FACTURA";
			ExcelApp.Cells[i,  19] 	= "NÚMERO ECONÓMICO";
			ExcelApp.Cells[i,  20] 	= "KM SERVICIO";
			ExcelApp.Cells[i,  21] 	= "KM ITINERARIO";
			ExcelApp.Cells[i,  22] 	= "OP OBRA";
			ExcelApp.Cells[i,  23] 	= "CALIFICACIÓN";
			ExcelApp.Cells[i,  24] 	= "LIMPIEZA";
			ExcelApp.Cells[i,  25] 	= "IMAGEN";
			ExcelApp.Cells[i,  26] 	= "ACTITUD";
			ExcelApp.Cells[i,  27] 	= "PUNTUALIDAD";
			ExcelApp.Cells[i,  28] 	= "FALLA";
			ExcelApp.Cells[i,  29] 	= "MEDIO ENTERO";
			ExcelApp.Cells[i,  30] 	= "OPERADOR";
			ExcelApp.Cells[i,  31] 	= "FECHA CONTRATACIÓN";
			ExcelApp.Cells[i,  32] 	= "PAGO OPERADOR";
			ExcelApp.Cells[i,  33] 	= "TIPO DE SERVICIO";
			ExcelApp.Cells[i,  34] 	= "TIPO DE EVENTO";
			ExcelApp.Cells[i,  35] 	= "FECHA ENCUESTA";
			ExcelApp.Cells[i,  36] 	= "APLICO ENCUESTA";
			
		
			String consulta = @"SELECT VPN.ID_RE, RE.ID_C, VPN.COMPANIA, VPN.COMPANIA_NOMBRE, VPN.CONTACTO, CS.Nombre, RE.DESTINO, vpn.FORANEO, VPN.FECHA_REGISTRO FECHA_COTIZACION, VPN.FECHA_SALIDA,VPN.FECHA_REGRESO, 
								VPN.TIPO_TRANSPOTE, VPN.CANTIDAD, VPN.PRECIO_UNITARIO, VPN.TOTAL_IVA, VPN.FACTURA, V.Numero, VPN.KM_SERVICIO, VPN.KM_ITINERARIO, RE.OP_COBRA, E.CALIFICACION, E.LIMPIEZA, E.IMAGEN, E.ACTITUD, 
								E.PUNTUALIDAD, E.FALLA, VPN.MEDIO_ENTERO, op.Alias OPERADOR, re.FECHA FECHA_CONTRATACION, vpn.SUELDO_OPERADOR PAGO_OPERADOR, vpn.TIPO_CLIENTE TIPO_SERVICIO, vpn.DETALLE TIPO_EVENTO, e.FECHA_REG FECHA_ENCUESTA, 
								u.usuario APLICO_ENCUESTA FROM RUTA_ESPECIAL RE JOIN RUTA R ON R.IdSubEmpresa = RE.ID_C JOIN VIAJE_PROSPECTO_NUEVO VPN ON VPN.ID_RE = RE.ID_RE JOIN OPERACION O ON O.id_ruta = R.ID JOIN OPERACION_OPERADOR OO
								ON OO.id_operacion = O.id_operacion JOIN OPERADOR OP ON OP.ID = OO.id_operador JOIN VEHICULO V ON V.ID = OO.id_vehiculo join ENCUESTA E on E.ID_RE = RE.ID_RE JOIN Cliente C ON C.ID = RE.ID_C JOIN ContactoServicio CS 
								ON CS.IdCliente = C.ID join usuario u on u.id_usuario = e.ID_U WHERE O.estatus != '0' AND RE.estado = 'Activo' AND  r.Sentido = 'Entrada' AND RE.FECHA_SALIDA BETWEEN '"
								+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"'  ORDER BY VPN.FECHA_SALIDA";						
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID_RE"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["ID_C"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["COMPANIA"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["COMPANIA_NOMBRE"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["CONTACTO"].ToString();				
				ExcelApp.Cells[i,  6]	= 	conn.leer["Nombre"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["DESTINO"].ToString();				
				ExcelApp.Cells[i,  8]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL");
				ExcelApp.Cells[i,  9]	= 	conn.leer["FECHA_COTIZACION"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  10]	= 	"";				
				ExcelApp.Cells[i,  11]	= 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);			
				ExcelApp.Cells[i,  12]	=   conn.leer["FECHA_REGRESO"].ToString().Substring(0,10);				
				ExcelApp.Cells[i,  13]	= 	"N/A";
				ExcelApp.Cells[i,  14]	= 	conn.leer["TIPO_TRANSPOTE"].ToString();				
				ExcelApp.Cells[i,  15]	= 	conn.leer["CANTIDAD"].ToString();
				ExcelApp.Cells[i,  16]	= 	conn.leer["PRECIO_UNITARIO"].ToString();
				ExcelApp.Cells[i,  17]	= 	conn.leer["TOTAL_IVA"].ToString();
				ExcelApp.Cells[i,  18]	= 	((conn.leer["FACTURA"].ToString() == "1")? "SI": "NO");
				ExcelApp.Cells[i,  19]	= 	conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  20]	= 	conn.leer["KM_SERVICIO"].ToString();
				ExcelApp.Cells[i,  21]	= 	conn.leer["KM_ITINERARIO"].ToString();
				ExcelApp.Cells[i,  22]	= 	((conn.leer["OP_COBRA"].ToString() == "1")? "SI": "NO");
				ExcelApp.Cells[i,  23]	= 	conn.leer["CALIFICACION"].ToString();
				ExcelApp.Cells[i,  24]	= 	conn.leer["LIMPIEZA"].ToString();
				ExcelApp.Cells[i,  25]	= 	conn.leer["IMAGEN"].ToString();
				ExcelApp.Cells[i,  26]	= 	conn.leer["ACTITUD"].ToString();
				ExcelApp.Cells[i,  27]	= 	conn.leer["PUNTUALIDAD"].ToString();
				ExcelApp.Cells[i,  28]	= 	conn.leer["FALLA"].ToString();
				ExcelApp.Cells[i,  29]	= 	conn.leer["MEDIO_ENTERO"].ToString();
				ExcelApp.Cells[i,  30]	= 	conn.leer["OPERADOR"].ToString();
				ExcelApp.Cells[i,  31]	= 	conn.leer["FECHA_CONTRATACION"].ToString();
				ExcelApp.Cells[i,  32]	= 	conn.leer["PAGO_OPERADOR"].ToString();
				ExcelApp.Cells[i,  33]	= 	conn.leer["TIPO_SERVICIO"].ToString();
				ExcelApp.Cells[i,  34]	= 	conn.leer["TIPO_EVENTO"].ToString();
				ExcelApp.Cells[i,  35]	= 	conn.leer["FECHA_ENCUESTA"].ToString();
				ExcelApp.Cells[i,  36]	= 	conn.leer["APLICO_ENCUESTA"].ToString();
				try{
					string consulta2 = @"SELECT MIN(RE.FECHA) FECHA FROM RUTA_ESPECIAL RE JOIN Cliente C ON C.ID = RE.ID_C JOIN ContactoServicio CS ON CS.IdCliente = C.ID WHERE CS.Nombre = '"+conn.leer["Nombre"].ToString()+"' ";						
					conn2.getAbrirConexion(consulta2);
					conn2.leer=conn2.comando.ExecuteReader();
					if(conn2.leer.Read()){
						if(conn2.leer["FECHA"] != null)
							ExcelApp.Cells[i,  10]	= 	conn2.leer["FECHA"].ToString().Substring(0,10);
					}
					conn2.conexion.Close();
				}catch(Exception){
					if(conn2.conexion != null)
						conn2.conexion.Close();
				}					
				contador++;
			}
			conn.conexion.Close();
			
			consulta = @"SELECT VPN.ID_RE, RE.ID_C, VPN.COMPANIA, VPN.COMPANIA_NOMBRE, VPN.CONTACTO, CS.Nombre, RE.DESTINO, vpn.FORANEO, VPN.FECHA_REGISTRO FECHA_COTIZACION, VPN.FECHA_SALIDA,VPN.FECHA_REGRESO, CC.FECHA_REGISTRO FECHA_CANCELACION,
						VPN.TIPO_TRANSPOTE, VPN.CANTIDAD, VPN.PRECIO_UNITARIO, VPN.TOTAL_IVA, VPN.FACTURA, VPN.KM_SERVICIO, VPN.KM_ITINERARIO, RE.OP_COBRA, VPN.MEDIO_ENTERO, re.FECHA FECHA_CONTRATACION, vpn.SUELDO_OPERADOR PAGO_OPERADOR, 
						vpn.TIPO_CLIENTE TIPO_SERVICIO, vpn.DETALLE TIPO_EVENTO FROM RUTA_ESPECIAL RE JOIN VIAJE_PROSPECTO_NUEVO VPN ON VPN.ID_RE = RE.ID_RE JOIN Cliente C ON C.ID = RE.ID_C JOIN ContactoServicio CS ON CS.IdCliente = C.ID JOIN 
						CANCELACION_COTIZACION CC ON CC.ID_COTIZACION = vpn.ID WHERE RE.estado != 'Activo' AND RE.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"'  ORDER BY VPN.FECHA_SALIDA";						
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID_RE"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["ID_C"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["COMPANIA"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["COMPANIA_NOMBRE"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["CONTACTO"].ToString();				
				ExcelApp.Cells[i,  6]	= 	conn.leer["Nombre"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["DESTINO"].ToString();				
				ExcelApp.Cells[i,  8]	= 	((conn.leer["FORANEO"].ToString() == "1")? "FORÁNEO": "LOCAL");
				ExcelApp.Cells[i,  9]	= 	conn.leer["FECHA_COTIZACION"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  10]	= 	"";				
				ExcelApp.Cells[i,  11]	= 	conn.leer["FECHA_SALIDA"].ToString().Substring(0,10);			
				ExcelApp.Cells[i,  12]	=   conn.leer["FECHA_REGRESO"].ToString().Substring(0,10);				
				ExcelApp.Cells[i,  13]	= 	conn.leer["FECHA_CANCELACION"].ToString().Substring(0,10);
				ExcelApp.Cells[i,  14]	= 	conn.leer["TIPO_TRANSPOTE"].ToString();				
				ExcelApp.Cells[i,  15]	= 	conn.leer["CANTIDAD"].ToString();
				ExcelApp.Cells[i,  16]	= 	conn.leer["PRECIO_UNITARIO"].ToString();
				ExcelApp.Cells[i,  17]	= 	conn.leer["TOTAL_IVA"].ToString();
				ExcelApp.Cells[i,  18]	= 	((conn.leer["FACTURA"].ToString() == "1")? "SI": "NO");
				ExcelApp.Cells[i,  19]	= 	"N/A";
				ExcelApp.Cells[i,  20]	= 	conn.leer["KM_SERVICIO"].ToString();
				ExcelApp.Cells[i,  21]	= 	conn.leer["KM_ITINERARIO"].ToString();
				ExcelApp.Cells[i,  22]	= 	((conn.leer["OP_COBRA"].ToString() == "1")? "SI": "NO");
				ExcelApp.Cells[i,  23]	= 	"N/A";
				ExcelApp.Cells[i,  24]	= 	"N/A";
				ExcelApp.Cells[i,  25]	= 	"N/A";
				ExcelApp.Cells[i,  26]	= 	"N/A";
				ExcelApp.Cells[i,  27]	= 	"N/A";
				ExcelApp.Cells[i,  28]	= 	"N/A";
				ExcelApp.Cells[i,  29]	= 	conn.leer["MEDIO_ENTERO"].ToString();
				ExcelApp.Cells[i,  30]	= 	"N/A";
				ExcelApp.Cells[i,  31]	= 	conn.leer["FECHA_CONTRATACION"].ToString();
				ExcelApp.Cells[i,  32]	= 	conn.leer["PAGO_OPERADOR"].ToString();
				ExcelApp.Cells[i,  33]	= 	conn.leer["TIPO_SERVICIO"].ToString();
				ExcelApp.Cells[i,  34]	= 	conn.leer["TIPO_EVENTO"].ToString();
				ExcelApp.Cells[i,  35]	= 	"N/A";
				ExcelApp.Cells[i,  36]	= 	"N/A";
				
				try{
					string consulta2 = @"SELECT MIN(RE.FECHA) FECHA FROM RUTA_ESPECIAL RE JOIN Cliente C ON C.ID = RE.ID_C JOIN ContactoServicio CS ON CS.IdCliente = C.ID WHERE CS.Nombre = '"+conn.leer["Nombre"].ToString()+"' ";						
					conn2.getAbrirConexion(consulta2);
					conn2.leer=conn2.comando.ExecuteReader();
					if(conn2.leer.Read()){
						if(conn2.leer["FECHA"] != null)
							ExcelApp.Cells[i,  10]	= 	conn2.leer["FECHA"].ToString().Substring(0,10);
					}
					conn2.conexion.Close();
				}catch(Exception){
					if(conn2.conexion != null)
						conn2.conexion.Close();
				}				
				contador++;
			}
			conn.conexion.Close();
							
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte TOTAL "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		#endregion
		
		#region Reporte_Apoyos
		void Button2Click(object sender, EventArgs e)
		{
			generarReporteApoyos();
		}
		#endregion
		
		void BtnCotizacionesClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "ID";
			ExcelApp.Cells[i,  2] 	= "FOLIO";
			ExcelApp.Cells[i,  3] 	= "CONTACTO";
			ExcelApp.Cells[i,  4] 	= "COMPAÑIA";
			ExcelApp.Cells[i,  5] 	= "CORREO";
			ExcelApp.Cells[i,  6] 	= "TELEFONO";
			ExcelApp.Cells[i,  7] 	= "EXT";
			ExcelApp.Cells[i,  8] 	= "FORANEO";
			ExcelApp.Cells[i,  9] 	= "EVENTO";
			ExcelApp.Cells[i,  10] 	= "DETALLE";
			ExcelApp.Cells[i,  11] 	= "TIPO_CLIENTE";
			ExcelApp.Cells[i,  12] 	= "CASETAS";
			ExcelApp.Cells[i,  13] 	= "TIPO DE UNIDAD";
			ExcelApp.Cells[i,  14] 	= "CANTIDAD";
			ExcelApp.Cells[i,  15] 	= "USUARIOS";
			ExcelApp.Cells[i,  16] 	= "BAÑO";
			ExcelApp.Cells[i,  17] 	= "AC";
			ExcelApp.Cells[i,  18] 	= "TV";
			ExcelApp.Cells[i,  19] 	= "FECHA_SALIDA";
			ExcelApp.Cells[i,  20] 	= "FECHA_REGRESO";
			ExcelApp.Cells[i,  21] 	= "DIAS";
			ExcelApp.Cells[i,  22] 	= "SALIDA";
			ExcelApp.Cells[i,  23] 	= "PRECIO";
			ExcelApp.Cells[i,  24] 	= "TOTAL";
			ExcelApp.Cells[i,  25] 	= "TOTAL_IVA";
			ExcelApp.Cells[i,  26] 	= "FACTURA";
			ExcelApp.Cells[i,  27] 	= "Estatus de Cotizacion";
			ExcelApp.Cells[i,  28] 	= "Viaje programado";
			ExcelApp.Cells[i,  29] 	= "FECHA_ACUERDO";
			ExcelApp.Cells[i,  30] 	= "FECHA_REGISTRO";
			ExcelApp.Cells[i,  31] 	= "usuario";
			ExcelApp.Cells[i,  32] 	= "ID_RE";
 		
			//String consulta = @"select ID, FOLIO, FECHA_ACUERDO as 'ACUERDO', CONTACTO, EVENTO, CANTIDAD, TIPO_TRANSPOTE, TOTAL_IVA
			//					from VIAJE_PROSPECTO_NUEVO where FLUJO = 2 and ESTADO = 'Activo' and FECHA_ACUERDO between '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' ";
			
			String consulta = @"select P.ID, P.FOLIO, P.CONTACTO, P.COMPANIA as 'COMPAÑIA', P.CORREO,  P.TELEFONO, P.EXT, P.FORANEO, P.EVENTO, P.DETALLE, P.TIPO_CLIENTE, P.CASETAS_SERVICIO as 'CASETAS', 
									P.TIPO_TRANSPOTE AS 'TIPO DE UNIDAD', P.CANTIDAD, P.USUARIOS, P.BANIO AS 'BAÑO', P.AC, P.TV, P.FECHA_SALIDA, P.FECHA_REGRESO, P.DIAS, P.UBICACION_PARTIDA AS 'SALIDA', 
									P.PRECIO_UNITARIO AS 'PRECIO', P.TOTAL, P.TOTAL_IVA, P.FACTURA, 
									CASE WHEN P.ESTADO = 'Activo' THEN 'Activo' ELSE 'Cancelado' END as 'Estatus de Cotizacion', 
									CASE WHEN P.FLUJO = 2 THEN 'No' ELSE 'Si' END as 'Viaje programado',
									P.FECHA_ACUERDO,
									P.FECHA_REGISTRO,
									U.usuario,
									P.ID_RE
								from dbo.VIAJE_PROSPECTO_NUEVO P with(nolock) 
									inner join usuario U with(nolock) on P.ID_USUARIO=U.id_usuario
								where FECHA_ACUERDO between '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' ";

			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["FOLIO"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["CONTACTO"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["COMPAÑIA"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["CORREO"].ToString();
				ExcelApp.Cells[i,  6]	= 	conn.leer["TELEFONO"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["EXT"].ToString();
				ExcelApp.Cells[i,  8]	= 	conn.leer["FORANEO"].ToString();
				ExcelApp.Cells[i,  9]	= 	conn.leer["EVENTO"].ToString();
				ExcelApp.Cells[i,  10]	= 	conn.leer["DETALLE"].ToString();
				ExcelApp.Cells[i,  11]	= 	conn.leer["TIPO_CLIENTE"].ToString();
				ExcelApp.Cells[i,  12]	= 	conn.leer["CASETAS"].ToString();
				ExcelApp.Cells[i,  13]	= 	conn.leer["TIPO DE UNIDAD"].ToString();
				ExcelApp.Cells[i,  14]	= 	conn.leer["CANTIDAD"].ToString();
				ExcelApp.Cells[i,  15]	= 	conn.leer["USUARIOS"].ToString();
				ExcelApp.Cells[i,  16]	= 	conn.leer["BAÑO"].ToString();
				ExcelApp.Cells[i,  17]	= 	conn.leer["AC"].ToString();
				ExcelApp.Cells[i,  18]	= 	conn.leer["TV"].ToString();
				ExcelApp.Cells[i,  19]	= 	conn.leer["FECHA_SALIDA"].ToString();
				ExcelApp.Cells[i,  20]	= 	conn.leer["FECHA_REGRESO"].ToString();
				ExcelApp.Cells[i,  21]	= 	conn.leer["DIAS"].ToString();
				ExcelApp.Cells[i,  22]	= 	conn.leer["SALIDA"].ToString();
				ExcelApp.Cells[i,  23]	= 	conn.leer["PRECIO"].ToString();
				ExcelApp.Cells[i,  24]	= 	conn.leer["TOTAL"].ToString();
				ExcelApp.Cells[i,  25]	= 	conn.leer["TOTAL_IVA"].ToString();
				ExcelApp.Cells[i,  26]	= 	conn.leer["FACTURA"].ToString();
				ExcelApp.Cells[i,  27]	= 	conn.leer["Estatus de Cotizacion"].ToString();
				ExcelApp.Cells[i,  28]	= 	conn.leer["Viaje programado"].ToString();
				ExcelApp.Cells[i,  29]	= 	conn.leer["FECHA_ACUERDO"].ToString();
				ExcelApp.Cells[i,  30]	= 	conn.leer["FECHA_REGISTRO"].ToString();
				ExcelApp.Cells[i,  31]	= 	conn.leer["usuario"].ToString();
				ExcelApp.Cells[i,  32]	= 	conn.leer["ID_RE"].ToString();
				
			}
			conn.conexion.Close();
					
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte COTIZACIONES "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
	}
}
