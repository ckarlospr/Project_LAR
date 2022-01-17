using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using iTextSharp.text;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class PrivilegiosPagos : Form
	{			
		#region CONSTRUCTOR
		public PrivilegiosPagos(FormPrincipal refPrinc)
		{
			InitializeComponent();
			formPrincipal = refPrinc;
			id_usuario = refPrinc.idUsuario;		
		}
		#endregion		
		
		#region VARIABLES
		public int msj=0;
		public FormDetalleFactura msjGlobo = new FormDetalleFactura();
		public bool realizado = false;
		public Int32 id_usuario;
		private bool filtrosV = true;		
		#endregion
		
		#region INSTANCIAS	
		public FormPrincipal formPrincipal;	
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();	
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();		
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();	
		//private FormVerOperador formOperador = null;	
		#endregion
		
		#region INICIO - FIN
		void PrivilegiosPagosLoad(object sender, EventArgs e)
		{
			filtrosV = true;
			/////////////////////////////////////////////////////// ESPECIALES ////////////////////////////////////////////////////////			
			dtpIncio.Value = Convert.ToDateTime("01/12/2015");
			dtpFin.Value = DateTime.Now;
			cbBusqueda.SelectedIndex = 2;
			filtros();
			
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento(@"select Alias dato from OPERADOR where Estatus='1' and tipo_empleado in
																		 ('AUX. COORDINADOR', 'AUXILIAR COORDINADOR', 'COORDINADOR', 'Externo', 'OPERADOR')");
			txtOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			cbEmpresariales.SelectedIndex = 0;
			//////////////////////////////////////////////////// CONTROL DE PAGOS //////////////////////////////////////////////////////
			AdaptadorServiciosAnticipos();			
			/////////////////////////////////////////////////// ORDENES DE FACTURA /////////////////////////////////////////////////////
			cmbBusquedaOrdenFactura.SelectedIndex = 3;			
			dtpInicioOrdenFactura.Value = DateTime.Now;
			dtpFinOrdenFactura.Value = DateTime.Now;
			filtrosOrden();
			filtrosV = false;
			
			
			if(formPrincipal.lblDatoNivel.Text=="VENTAS")
			{
				btnPagarServicio.Visible=false;
				btnIncobrable.Visible=false;
				tcCobros.TabPages.RemoveAt(1);
				tcCobros.TabPages.RemoveAt(1);
			}
		}		
		
		void PrivilegiosPagosFormClosing(object sender, FormClosingEventArgs e)
		{
			formPrincipal.cobroVenta = false;
		}
		#endregion
				
		#region EVENTOS
		void TcCobrosSelectedIndexChanged(object sender, EventArgs e)
		{
			if(tcCobros.SelectedIndex == 0)
				dgRelacion.ClearSelection();
			
			if(tcCobros.SelectedIndex == 1){
				dgServiciosAnt.ClearSelection();
				dgAnticipos.ClearSelection();
			}
			
			if(tcCobros.SelectedIndex == 2){
				dgOrdenFactura.ClearSelection();
				avisaPagosServiciofactura();
			}
		}
		#endregion
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////////// ESPECIALES ////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region FILTROS	
		public void filtros(){
			string consulta = "";
			
			if(cbEmpresariales.SelectedIndex == 1)
				consulta = @"select re.*, cs.*, c.* from RUTA_ESPECIAL RE, ContactoServicio CS, Cliente C, VIAJE_PROSPECTO_NUEVO vpn where re.ID_RE = vpn.ID_RE and RE.ID_C = C.ID  And vpn.EMPRESARIAL = 1 And (RE.PAGADO = '0'";
			else if(cbEmpresariales.SelectedIndex == 2)
				consulta = @"select re.*, cs.*, c.* from RUTA_ESPECIAL RE, ContactoServicio CS, Cliente C, VIAJE_PROSPECTO_NUEVO vpn where re.ID_RE = vpn.ID_RE and RE.ID_C = C.ID  And (vpn.EMPRESARIAL = 0 or vpn.EMPRESARIAL is null) And (RE.PAGADO = '0'";
			else
				consulta = @"select * from RUTA_ESPECIAL RE, ContactoServicio CS, Cliente C where RE.ID_C = C.ID And (RE.PAGADO = '0'";
			
			if(cbPagados.Checked == true)
				consulta = consulta + " or RE.PAGADO = '1' or  RE.PAGADO = '2' or  RE.PAGADO = '3' )";
			else
				consulta = consulta +" ) ";
			
			consulta = consulta + "  AND C.ID = CS.IdCliente AND RE.ID_RE in (select ID_RE from COBRO_ESPECIAL ";
				
			if(cbTipo.SelectedIndex > -1){
				if(cbTipo.Text == "OPERADOR" || cbTipo.Text == "COORDINADOR")
					consulta = consulta + " where TIPO = '"+cbTipo.Text+"' and COBRO like '%"+txtOperador.Text+"%' )";
				else					
					consulta = consulta + " where TIPO = '"+cbTipo.Text+"')";
			}else{
				consulta = consulta + ") ";
			}
							
			if(cbBusqueda.SelectedIndex > -1){
				string busca = cbBusqueda.Text;
				if(cbBusqueda.Text == "RAZÓN SOCIAL")
					busca = "FACTURA";	
				if(cbBusqueda.Text == "CONTACTO")
					busca = "RESPONSABLE";
				if(cbBusqueda.Text == "FACTURA")
					busca = "NUMERO_ANTI";
				consulta = consulta + " and "+busca+ " like '%"+txtBusqueda.Text+"%'";				
			}			
			consulta = consulta + " and RE.FECHA_SALIDA between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"'";
			adaptadorPrincipal(consulta);
		}
		#endregion		
		
		#region ADAPTADOR
		public void adaptadorPrincipal(string consulta){
			int contador = 0;
			dgRelacion.Rows.Clear();					
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(),
				                 conn.leer["ID_C"].ToString(),
				                "", //tipo de cobro
				                 "",// contacto
				                 "", // cliente
				                 conn.leer["DESTINO"].ToString(),
				                 conn.leer["FECHA_SALIDA"].ToString().Substring(0,10),
				                 conn.leer["FECHA_REGRESO"].ToString().Substring(0,10),				                
				                 conn.leer["CANT_UNIDADES"].ToString(),
				                 ((conn.leer["FACTURADO"].ToString() == "0")?(Convert.ToDouble(conn.leer["PRECIO"]) * Convert.ToDouble(conn.leer["CANT_UNIDADES"])).ToString() : ( (Convert.ToDouble(conn.leer["PRECIO"]) * Convert.ToDouble(conn.leer["CANT_UNIDADES"]) )* 1.16).ToString()),
				                 ((conn.leer["FACTURADO"].ToString() == "0")?"NO":"SI"),
				                 conn.leer["FACTURA"].ToString(),				                 
				                 "0", // precio a cobrar
				                 "0", //anticipos DEPOSITO
				                 "0", //anticipos EFECTIVO
				                 "0",
				                conn.leer["NUMERO_ANTI"].ToString()); //precio que falta a cobrar
				if(conn.leer["PAGADO"].ToString() == "1" || conn.leer["PAGADO"].ToString() == "2" || conn.leer["PAGADO"].ToString() == "3"){
					for(int y=0; y < dgRelacion.Columns.Count; y++){
						dgRelacion[y,contador].Style.BackColor = Color.LightGreen;
					}
				}
				contador++;
			}
			conn.conexion.Close();
			datosCompleta();
			dgRelacion.ClearSelection();
			lblPagar.Text = "SERVICIOS POR PAGAR: " + contador;
		}
		#endregion
		
		#region METODOS
		public void datosCompleta(){
			for(int x=0; x<dgRelacion.Rows.Count; x++){				
				if(dgRelacion[10,x].Value.ToString() == "SI"  && (dgRelacion[16,x].Value.ToString() == "" || dgRelacion[16,x].Value.ToString() == " " || dgRelacion[16,x].Value.ToString() == "0" ))
					dgRelacion[16,x].Value = "FACTURABLE";
					
				String consul = @"select TIPO from COBRO_ESPECIAL where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					if(conn.leer["TIPO"].ToString().Equals("PADAGO"))
						dgRelacion[2,x].Value = dgRelacion[2,x].Value.ToString() + " " + "PAGO ANTICIPADO";
					else
						dgRelacion[2,x].Value = dgRelacion[2,x].Value.ToString() + " " + conn.leer["TIPO"].ToString();
				}				
				conn.conexion.Close();
				
				consul = @"select CONTACTO, COMPANIA_NOMBRE, TOTAL_IVA from VIAJE_PROSPECTO_NUEVO where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[3,x].Value = conn.leer["CONTACTO"].ToString();
					dgRelacion[4,x].Value = conn.leer["COMPANIA_NOMBRE"].ToString();
					dgRelacion[9,x].Value = conn.leer["TOTAL_IVA"].ToString();		           	
				}				
				conn.conexion.Close();

				
				if(dgRelacion[3,x].Value.ToString() == "" && dgRelacion[4,x].Value.ToString() == ""){
					consul = @"select cs.Nombre, re.RESPONSABLE, re.PRECIO, re.FACTURADO, re.CANT_UNIDADES from ContactoServicio cs, RUTA_ESPECIAL re where cs.IdCliente = re.ID_C and re.ID_RE = "+dgRelacion[0,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgRelacion[3,x].Value = conn.leer["RESPONSABLE"].ToString();
						dgRelacion[4,x].Value = conn.leer["Nombre"].ToString();
						dgRelacion[9,x].Value =  ((conn.leer["FACTURADO"].ToString() == "0")?(Convert.ToDouble(conn.leer["PRECIO"]) * Convert.ToDouble(conn.leer["CANT_UNIDADES"])).ToString() : ( (Convert.ToDouble(conn.leer["PRECIO"]) * Convert.ToDouble(conn.leer["CANT_UNIDADES"]) )* 1.16).ToString());
				    }				
					conn.conexion.Close();
				}
					
				consul = @"select SUM(SALDO) AS COSTO from COBRO_ESPECIAL where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[12,x].Value = conn.leer["COSTO"].ToString();
				}				
				conn.conexion.Close();
							
				consul = @"select PRECIO_ITINERARIO from VIAJE_PROSPECTO_NUEVO where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
					dgRelacion[12,x].Value = Convert.ToDouble(dgRelacion[12,x].Value) + ((Convert.ToString(conn.leer["PRECIO_ITINERARIO"])=="")?0:Convert.ToDouble(conn.leer["PRECIO_ITINERARIO"]));
				conn.conexion.Close();
				
				consul = @"select SUM(CANTIDAD) AS CANTIDAD from ANTICIPOS_ESPECIALES where estatus != '0'  AND tipo = 'DEPOSITO' and ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(conn.leer["CANTIDAD"].ToString() != "")
						dgRelacion[13,x].Value = conn.leer["CANTIDAD"].ToString();
					else
						dgRelacion[13,x].Value = 0;
				}	
				conn.conexion.Close();				
				
				consul = @"select SUM(CANTIDAD) AS CANTIDAD from ANTICIPOS_ESPECIALES where estatus != '0' AND tipo != 'DEPOSITO' and ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(conn.leer["CANTIDAD"].ToString() != "")
						dgRelacion[14,x].Value = conn.leer["CANTIDAD"].ToString();
					else
						dgRelacion[14,x].Value = 0;
				}	
				conn.conexion.Close();
				
				
				if(dgRelacion[12,x].Value.ToString() != "" && dgRelacion[13,x].Value.ToString() != "" && dgRelacion[14,x].Value.ToString() != "")
					dgRelacion[15,x].Value = (Convert.ToDouble(dgRelacion[12,x].Value) - (Convert.ToDouble(dgRelacion[13,x].Value) + Convert.ToDouble(dgRelacion[14,x].Value))).ToString();
			
				consul = @"select ID from RUTA where PAGO = 0 and IdSubEmpresa = "+dgRelacion[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[12,x].Style.BackColor = Color.Yellow;
				}				
				conn.conexion.Close();

				consul = @"select CANTIDAD from ANTICIPOS_ESPECIALES where estatus = '0' AND tipo = 'DEPOSITO'  and ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[13,x].Style.BackColor = Color.Yellow;
				}				
				conn.conexion.Close();	
				
				consul = @"select CANTIDAD from ANTICIPOS_ESPECIALES where estatus = '0' AND tipo != 'DEPOSITO'  and ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					dgRelacion[14,x].Style.BackColor = Color.Yellow;
				}				
				conn.conexion.Close();
				
				consul = @"select INCOBRABLE from RUTA_ESPECIAL where ID_RE = "+dgRelacion[0,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(conn.leer["INCOBRABLE"].ToString() == "1")
						dgRelacion[2,x].Value = "Incobrable";
				}				
				conn.conexion.Close();
				
				
				if(dgRelacion[0,x].Style.BackColor.Name != "LightGreen"){
					consul = @"select ID_RE from COBRO_ESPECIAL where PAGO = 1 and id_re = "+dgRelacion[0,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						for(int y=0; y < dgRelacion.Columns.Count; y++){
							dgRelacion[y,x].Style.BackColor = Color.LightPink;
						}
					}				
					conn.conexion.Close();
				}				
			
				if(dgRelacion[0,x].Style.BackColor.Name != "LightGreen"){					
				consul = @"select ID_RE from COBRO_ESPECIAL where PAGO = 0 and id_re = "+dgRelacion[0,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgRelacion[17,x].Style.BackColor = Color.White;
						dgRelacion[16,x].Style.BackColor = Color.White;
						dgRelacion[15,x].Style.BackColor = Color.White;
						dgRelacion[14,x].Style.BackColor = Color.White;					
						dgRelacion[13,x].Style.BackColor = Color.White;
					}				
					conn.conexion.Close();
				}
			}
		}
		
		public void pagarServicio(){
			bool respuesta = true;
			if(validaPagoVarios()){
				DialogResult rs2 = MessageBox.Show("Los(El) servicios se pagaran ¿Deseas continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes == rs2){
					for(int x=0; x<dgRelacion.Rows.Count; x++){
						if(dgRelacion[1,x].Selected == true && dgRelacion[1,x].Style.BackColor.Name != "LightGreen"){
							if(connL.pagaServicio(Convert.ToInt64(dgRelacion[0, x].Value), id_usuario)){						
								dgRelacion.Rows.RemoveAt(x);
							}else{
								respuesta = false;
								x = dgRelacion.Rows.Count-1;
							}
						}
					}
				}
			}else{
				respuesta = false;
			}
			
			if(respuesta)
				MessageBox.Show("Los servicios se pagaron corretamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("Error al pagar los servicios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	
			/*
			if(dgRelacion.SelectedRows.Count > 0){
				if(dgRelacion[1, dgRelacion.CurrentRow.Index].Style.BackColor.Name != "LightGreen"){
					if(dgRelacion[15,dgRelacion.CurrentRow.Index].Value.ToString() == "0" || dgRelacion[15,dgRelacion.CurrentRow.Index].Value.ToString() == "0.0"){
						DialogResult rs2 = MessageBox.Show("El servicio se pagara ¿Deseas continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (DialogResult.Yes == rs2){
							if(connL.pagaServicio(Convert.ToInt64(dgRelacion[0, dgRelacion.CurrentRow.Index].Value), id_usuario)){							
								dgRelacion.Rows.RemoveAt(dgRelacion.CurrentRow.Index);
								dgRelacion.ClearSelection();
								MessageBox.Show("El servicio se pago corretamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}		
						}										
					}else{
						MessageBox.Show("Para validar un registro es necesario que se pagen todos los VEHICULOS del viaje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}			
				}else{
					MessageBox.Show("Selecciona un servicio valido a pagar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}				
			}
			*/
		}
		
		private bool validaPagoVarios(){
			bool respuesta = true;
			for(int x=0; x<dgRelacion.Rows.Count; x++){
				if(dgRelacion[1,x].Selected == true){
					if(dgRelacion[1,x].Style.BackColor.Name == "LightGreen" || dgRelacion[1,x].Value.ToString().Contains("Incobrable") || dgRelacion[1,x].Value.ToString().Contains("INCOBRABLE")){
						respuesta = false;
						MessageBox.Show("Selecciona servicios validos a pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						x = dgRelacion.Rows.Count-1;
					}else{
						if(dgRelacion[15,x].Value.ToString() == "0" || dgRelacion[15,x].Value.ToString() == "0.0" || dgRelacion[15,x].Value.ToString() == "0.00"){
							respuesta = true;
						}else{
							MessageBox.Show("Para validar los servicios es necesario que se pagen todos los VEHICULOS de cada servicio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							x = dgRelacion.Rows.Count-1;			
							respuesta = false;
						}
					}
				}					
			}			
			return respuesta;
		}
		
		public void IncobrableServicio(){
			if(dgRelacion[1, dgRelacion.CurrentRow.Index].Style.BackColor.Name != "LightGreen"){
				new FormIncobrable(this, id_usuario, Convert.ToInt64(dgRelacion[0, dgRelacion.CurrentRow.Index].Value)).ShowDialog();
			}else{
				MessageBox.Show("Selecciona un servicio valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}	
		
		void PDFFormatoIncobrable()
		{
			string idCliente = "0", cliente = "", destino = "", responsable = "", telefono = "", domicilio = "", Fecha = "", NumHoraPlanton = "", NumMinPlanton = "", 
					NumHoraRegreso = "", NumMinRegreso = "", NumUnidad = "", nudPasajeros = "", Colonia = "", Cruces = "", Saldo = "", Anticipos = "", Precio = "",
					FechaRegreso = "", Observaciones = "", consulta = "";
				
			try{
				consulta = @"select R.ID_C, C.Nombre, responsable as Responsable, R.fecha_salida, R.cant_unidades, R.domicilio, R.destino, R.precio, C.Telefono As Telefono, R.h_planton,
				R.observaciones, R.fecha_regreso, R.anticipo, CL.Rumbo, CL.Estado, R.SALDO, R.cantidad_usuarios	from RUTA_ESPECIAL R, ContactoServicio C, Cliente CL where 
				R.ID_C=C.idCliente and R.ID_C=CL.ID and R.ID_RE ='"+dgRelacion[0, dgRelacion.CurrentRow.Index].Value.ToString()+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					idCliente = conn.leer["ID_C"].ToString();
					cliente = conn.leer["Nombre"].ToString();
					responsable = conn.leer["Responsable"].ToString();				
					Fecha = conn.leer["fecha_salida"].ToString();
					NumUnidad = conn.leer["cant_unidades"].ToString();
					domicilio = conn.leer["domicilio"].ToString();
					destino = conn.leer["destino"].ToString();
					Precio = conn.leer["precio"].ToString();
					telefono = conn.leer["Telefono"].ToString();
					Observaciones = conn.leer["observaciones"].ToString();
					FechaRegreso = conn.leer["fecha_regreso"].ToString().Substring(0,10);
					Anticipos = conn.leer["anticipo"].ToString();				
					Cruces = conn.leer["Rumbo"].ToString();
					Colonia = conn.leer["Estado"].ToString();
					nudPasajeros = conn.leer["cantidad_usuarios"].ToString();
					NumHoraPlanton = conn.leer["h_planton"].ToString().Substring(0,2);
					NumMinPlanton = conn.leer["h_planton"].ToString().Substring(3,2);
					Saldo = conn.leer["SALDO"].ToString();
				}
				conn.conexion.Close();				
			}catch(Exception ex){				
				MessageBox.Show(ex.Message);
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			try{
				consulta = "select HoraInicio from RUTA WHERE Sentido='Salida' and IdSubEmpresa='"+idCliente+"'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					NumHoraRegreso = conn.leer["HoraInicio"].ToString().Substring(0,2);
					NumMinRegreso = conn.leer["HoraInicio"].ToString().Substring(3,2);
				}
				conn.conexion.Close();
			}catch(Exception ex){				
				MessageBox.Show(ex.Message);
				if(conn.conexion != null)
					conn.conexion.Close();
			}				
				
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Formato Precios "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Formato precios "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+cliente+ " " +destino+".pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				FormatoPdf.FormatoFormatoPrecios2(doc, writer, responsable, telefono, domicilio, destino, Fecha.Substring(0,10), NumHoraPlanton+":"+NumMinPlanton+" hrs", NumHoraRegreso+":"+NumMinRegreso+" hrs", 
				                                  NumUnidad, nudPasajeros, Colonia, Cruces, Saldo, Anticipos, Precio, FechaRegreso.Substring(0,10), cliente, Observaciones, dgRelacion[0, dgRelacion.CurrentRow.Index].Value.ToString());
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Formato precios "+DateTime.Now.ToString("dd-MM-yyyy")+@"\"+cliente+ " " +destino+".pdf"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		
		#region EVENTOS
		void CbBusquedaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbBusqueda.SelectedIndex == 0){
				txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral("select ID_RE from RUTA_ESPECIAL", "ID_RE");
	           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
			if(cbBusqueda.SelectedIndex == 1){
				txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral("select RESPONSABLE from RUTA_ESPECIAL", "RESPONSABLE");
	           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
			if(cbBusqueda.SelectedIndex == 2){
				txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral("select DESTINO from RUTA_ESPECIAL", "DESTINO");
	           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
			if(cbBusqueda.SelectedIndex == 3){
				txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral("select FACTURA from RUTA_ESPECIAL", "FACTURA");
	           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
			if(cbBusqueda.SelectedIndex == 4){
				txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral("select NUMERO_ANTI from RUTA_ESPECIAL", "NUMERO_ANTI");
	           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;  
			}
		}
		
		void CbTipoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbTipo.Text == "OPERADOR" || cbTipo.Text == "COORDINADOR"){
				txtOperador.Visible = true;
				txtOperador.Text = "";
			}else{				
				txtOperador.Visible = false;
				txtOperador.Text = "";
			}
		}
		
		void DgRelacionDoubleClick(object sender, EventArgs e)
		{
			
			if(formPrincipal.lblDatoNivel.Text=="VENTAS")
			{
			
			}
			else
			{
				if(dgRelacion.CurrentCell.ColumnIndex == 17 && dgRelacion.CurrentRow.Index > -1 && dgRelacion.SelectedRows.Count == 1){
					Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgRelacion[0,dgRelacion.CurrentRow.Index].Value));
					formDatos.FormBorderStyle = FormBorderStyle.FixedSingle;
					formDatos.ShowDialog();			
				}
				if(dgRelacion.CurrentCell.ColumnIndex == 13 && dgRelacion.CurrentRow.Index > -1 && dgRelacion[13,dgRelacion.CurrentRow.Index].Value.ToString() != "0" && dgRelacion.SelectedRows.Count == 1)
					new Anticipos(dgRelacion[0,dgRelacion.CurrentRow.Index].Value.ToString(), this, 2).ShowDialog();			
				if(dgRelacion.CurrentCell.ColumnIndex == 14 && dgRelacion.CurrentRow.Index > -1 && dgRelacion[14,dgRelacion.CurrentRow.Index].Value.ToString() != "0" && dgRelacion.SelectedRows.Count == 1)
					new Anticipos(dgRelacion[0,dgRelacion.CurrentRow.Index].Value.ToString(), this, 1).ShowDialog();
				if(dgRelacion.CurrentCell.ColumnIndex != 13 && dgRelacion.CurrentCell.ColumnIndex != 14 && dgRelacion.CurrentCell.ColumnIndex != 17 && dgRelacion.CurrentRow.Index > -1 && dgRelacion.SelectedRows.Count == 1)
					new FormPagoCobroEspecial(Convert.ToInt32(dgRelacion[0,dgRelacion.CurrentRow.Index].Value), this).ShowDialog();			
			}
		}
		
		void DgRelacionCellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{/*
			if(e.ColumnIndex == 2 && e.RowIndex != -1){
				if(dgRelacion[2 ,e.RowIndex].Value.ToString().Contains("OPERADOR")){
					formOperador = new FormVerOperador(this, dgRelacion[0, dgRelacion.CurrentRow.Index].Value.ToString());
					if(formOperador != null){						
						formOperador.Show();
						formOperador.Location  = new System.Drawing.Point(Control.MousePosition.X, Control.MousePosition.Y);
					}
				}
			}*/
		}
		
		void DgRelacionCellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{/*
			if(e.ColumnIndex == 2 && e.RowIndex != -1){
				if(formOperador != null){					
					formOperador.Close();
					formOperador = null;
				}
			}*/
		}				
		#endregion
				
		#region BOTONES		
		void LblLimpiarClick(object sender, EventArgs e)
		{
			cbPagados.Checked = false;
			cbValidados.Checked = false;
			cbTipo.SelectedIndex = -1;
			txtOperador.Text = "";
			txtBusqueda.Text = "";
			dtpIncio.Value = Convert.ToDateTime("01/01/2015");
			dtpFin.Value = DateTime.Now;
			cbBusqueda.SelectedIndex = 2;
			filtros();	
		}
		
		void BntBuscarClick(object sender, EventArgs e)
		{
			filtros();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			new ReportesPrivilegiosPagos(this).ShowDialog();
		}
		
		void BtnPagarServicioClick(object sender, EventArgs e)
		{		
			if(dgRelacion.SelectedRows.Count > 0)
				pagarServicio();
			else
				MessageBox.Show("Selecciona un servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			dgRelacion.ClearSelection();
		}
		
		
		void BtnIncobrableClick(object sender, EventArgs e)
		{
			if(dgRelacion.SelectedRows.Count == 1)
				IncobrableServicio();
			else
				MessageBox.Show("Selecciona solo un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			dgRelacion.ClearSelection();
		}
		#endregion
				
		#region MENU
		void PagadoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgRelacion.SelectedRows.Count == 1)
				pagarServicio();
			else
				MessageBox.Show("Selecciona solo un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			dgRelacion.ClearSelection();
		}
		
		void IncobrableToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgRelacion.SelectedRows.Count == 1)	
				IncobrableServicio();
			else
				MessageBox.Show("Selecciona solo un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			dgRelacion.ClearSelection();
		}
		
		void ImprimirIncobrableToolStripMenuItemClick(object sender, EventArgs e)
		{		
			if(dgRelacion.SelectedRows.Count == 1)
				PDFFormatoIncobrable();
		}
		#endregion		
		
		#region AVISO FACTURA PAGADA		
		private FormAvisoFacturaP formAviso = null;
		public bool aviso = false;
		
		private void avisaPagosServiciofactura(){
			String consul = @"select count(*) cont from RUTA_ESPECIAL where (FACTURADO = '2' or FACTURADO = '1')  and ID_RE in (select ID_RE from ANTICIPOS_ESPECIALES where tipo = 'EFECTIVO')";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				if(Convert.ToInt32(conn.leer["cont"]) > 0){
					timer1.Start(); 
				}else{
					timer1.Stop(); 		
					lblAlerta.Visible = false;	
				}			
			}				
			conn.conexion.Close();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			try{
			 	lblAlerta.Visible = !lblAlerta.Visible;
			}catch(Exception ex){
				MessageBox.Show("Error en aviso: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblAlerta.Visible = false;
			}
		}
		
		void LblAlertaClick(object sender, EventArgs e)
		{
			if(this.aviso == true){
				if(formAviso.WindowState==FormWindowState.Minimized)
					formAviso.WindowState = FormWindowState.Normal;
				else
					formAviso.BringToFront();
			}else{
				this.formAviso = new FormAvisoFacturaP(this);
				this.formAviso.BringToFront();
				this.formAviso.Show();
				this.aviso = true;
			}
		}
		#endregion			
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////// CONTROL DE PAGOS /////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
		#region EVENTOS
		void DgAnticiposDoubleClick(object sender, EventArgs e)
		{
			if(dgAnticipos.SelectedRows.Count > 0){
				new FormModificaAnticipo(this, dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString(), id_usuario.ToString()).ShowDialog();
			}
		}
		
		void RbDepositosCheckedChanged(object sender, EventArgs e)
		{
			AdaptadorServiciosAnticipos();
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			AdaptadorServiciosAnticipos();
		}
		
		void DgServiciosAntCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1){
				cbMostrarValidadosAnticipos.Checked = false;
				AdaptadorAnticipos(Convert.ToInt64(dgServiciosAnt[0,e.RowIndex].Value));
			}
		}
		
		void CbMostrarValidadosAnticiposCheckedChanged(object sender, EventArgs e)
		{
			if(dgServiciosAnt.SelectedRows.Count != 0){
				if(cbMostrarValidadosAnticipos.Checked == true)
					AdaptadorAnticiposValidados(Convert.ToInt64(dgServiciosAnt[0,dgServiciosAnt.CurrentRow.Index].Value));
				else
					AdaptadorAnticipos(Convert.ToInt64(dgServiciosAnt[0,dgServiciosAnt.CurrentRow.Index].Value));
			}else{
				cbMostrarValidadosAnticipos.Checked = false;
			}
		}
		
		void DgServiciosAntDoubleClick(object sender, EventArgs e)
		{
			if(dgServiciosAnt.Rows.Count>0)
			{
				if(dgServiciosAnt.CurrentCell.ColumnIndex == 3 && dgServiciosAnt[3,dgServiciosAnt.CurrentRow.Index].Value.ToString() == "Si")
				{
					new Interfaz.Libro.FormDatosFactura(3,dgServiciosAnt[4,dgServiciosAnt.CurrentRow.Index].Value.ToString()).ShowDialog();
				}
			}
		}
		#endregion
		
		#region ADAPTADORES 
		public void AdaptadorServiciosAnticipos()
		{
			int contador = 0;
			String consulta = "";
			dgServiciosAnt.Rows.Clear();
			dgAnticipos.Rows.Clear();		
			
			if(rbEfectivo.Checked==true){
				consulta = "select * from RUTA_ESPECIAL where ID_RE IN (select ID_RE from ANTICIPOS_ESPECIALES where TIPO='EFECTIVO' and ESTATUS='0') AND estado='Activo'";
			}else{
				consulta = "select * from RUTA_ESPECIAL where ID_RE IN (select ID_RE from ANTICIPOS_ESPECIALES where TIPO='DEPOSITO' and ESTATUS='0') AND estado='Activo'";
			}
			try{
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgServiciosAnt.Rows.Add(conn.leer["ID_RE"].ToString(), 
					                        conn.leer["DESTINO"].ToString(), 
					                        conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), 
					                        ((conn.leer["FACTURADO"].ToString()!="0")?"Si":"No"), 
					                        conn.leer["FACTURA"].ToString(), 					                        
					                        ((conn.leer["FACTURADO"].ToString()!="0")?conn.leer["NUMERO_ANTI"].ToString():"N/A"),
					                        conn.leer["SALDO"].ToString());
					if(conn.leer["FACTURADO"].ToString() != "0"){
						dgServiciosAnt[3,contador].Style.BackColor = Color.LightGreen;
					}else{						
						dgServiciosAnt[3,contador].Style.BackColor = Color.White;
					}
					contador++;
				}			
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los servicios que tienen anticipos por validar (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
			dgServiciosAnt.ClearSelection();
			
			
			conn.getAbrirConexion("select COUNT(*) contador from RUTA_ESPECIAL where ID_RE IN (select ID_RE from ANTICIPOS_ESPECIALES where  ESTATUS='0') AND estado = 'Activo'");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				if(conn.leer["contador"].ToString() != "0"){
					lblAvisoAnticipos.Visible = true;
				}else{					
					lblAvisoAnticipos.Visible = false;
				}
			}			
			conn.conexion.Close();
		}
		
		public void AdaptadorAnticiposValidados(Int64 id)
		{		
			String consulta = "";
			int conta = 0;
			dgAnticipos.Rows.Clear();	
			
			if(rbEfectivo.Checked == true)
				consulta =  "select * from ANTICIPOS_ESPECIALES where TIPO = 'EFECTIVO'  and ID_RE = "+id;
			else
				consulta =  "select * from ANTICIPOS_ESPECIALES where TIPO = 'DEPOSITO'  and ID_RE = "+id;
				
			try{
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgAnticipos.Rows.Add(conn.leer["ID"].ToString(),
					                     conn.leer["FECHA"].ToString().Substring(0,10),
					                     conn.leer["CANTIDAD"].ToString(),	                     
				                   		 conn.leer["NUMERO"].ToString(),
					                   //((conn.leer["TIPO"].ToString()=="EFECTIVO")?"N/A":conn.leer["NUMERO"].ToString()), 
					                     conn.leer["UBICA"].ToString(),
					                     conn.leer["cometario"].ToString());
					if(conn.leer["ESTATUS"].ToString() != "0"){
						for(int y = 0; y<dgAnticipos.Columns.Count; y++)
							dgAnticipos[y,conta].Style.BackColor = Color.LightGreen;
					}
					conta++;
				}
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los anticipos del servicio seleccionado (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}			
			conn.conexion.Close();
			dgAnticipos.ClearSelection();
		}
		
		public void AdaptadorAnticipos(Int64 id)
		{
			dgAnticipos.Rows.Clear();			
			String consulta = "";
			
			if(rbEfectivo.Checked==true){
				consulta =  "select * from ANTICIPOS_ESPECIALES where TIPO = 'EFECTIVO' and ESTATUS = '0' and ID_RE = "+id;
			}else{
				consulta =  "select * from ANTICIPOS_ESPECIALES where TIPO = 'DEPOSITO' and ESTATUS = '0' and ID_RE = "+id;
			}	
			try{
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgAnticipos.Rows.Add(conn.leer["ID"].ToString(),
					                     conn.leer["FECHA"].ToString().Substring(0,10),
					                     conn.leer["CANTIDAD"].ToString(),             
				                   		 conn.leer["NUMERO"].ToString(),       
				                   		//((conn.leer["TIPO"].ToString()=="EFECTIVO")?"N/A":conn.leer["NUMERO"].ToString()), 
					                     conn.leer["UBICA"].ToString(),
					                     conn.leer["cometario"].ToString());
				}
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los anticipos del servicio seleccionado (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}			
			conn.conexion.Close();
			dgAnticipos.ClearSelection();
		}
		#endregion	
		
		#region BOTONES
		void CmdConfirmarClick(object sender, EventArgs e)
		{
			if(dgAnticipos.SelectedRows.Count > 0 && dgAnticipos[2,dgAnticipos.CurrentRow.Index].Style.BackColor.Name != "LightGreen"){
				String consulta = "update ANTICIPOS_ESPECIALES set ESTATUS='1', ID_U='"+id_usuario+"', FECHA_CONFIRMADO = (SELECT CONVERT (DATE, SYSDATETIME())) where ID="+dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				dgAnticipos.Rows.RemoveAt(dgAnticipos.CurrentRow.Index);				
				dgAnticipos.ClearSelection();				
				if(dgAnticipos.Rows.Count==0){
					validaPagoCompleto(dgServiciosAnt[0,dgServiciosAnt.CurrentRow.Index].Value.ToString());
					AdaptadorServiciosAnticipos();
				}
			}else{
				MessageBox.Show("Selecciona un anticipo valido", "Aviso Anticipos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}		
		#endregion
		
		#region METODOS
		void validaPagoCompleto(String ID_RE)
		{
			String consDato = "EXECUTE COSTO_VIAJE "+ID_RE;
			String dato = "";
			bool valida = false;
			
			conn.getAbrirConexion(consDato);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				if(conn.leer["SALDO"].ToString() == conn.leer["TOTAL"].ToString()){
					dato="EL SERVICIO SE HA PAGADO COMPLETAMENTE  COSTO:"+conn.leer["SALDO"].ToString()+"    TOTAL DE ANTICIPOS:"+conn.leer["TOTAL"].ToString();
					MessageBox.Show(dato+" VALIDACION COMPLETA", "Servicio pagado", MessageBoxButtons.OK,MessageBoxIcon.Information);
					valida=true;
				}
			}			
			conn.conexion.Close();
			if(valida==true){
				String consDat = "update COBRO_ESPECIAL set PAGO = '1' where ID_RE = "+ID_RE;						
				conn.getAbrirConexion(consDat);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
		}
		#endregion
				
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////// ORDENES DE FACTURA ////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
				
		#region FILTROS
		public void filtrosOrden(){
			int parametro = Convert.ToInt16(connL.obtenerParametro1(4));
			string fecha = DateTime.Now.AddDays(parametro).ToString("yyyy-MM-dd");
			String consulta = "";
			if(cbEliminadasOrdenFactura.Checked == false){
				consulta = @"select o.ID, o.ID_RES, o.FECHAS, o.IMPORTE, o.IVA, o.TOTAL, o.VEHICULO, o.CANTIDAD_VEHICULO, o.FORMA_FACTURACION, o.ESTATUS, o.FLUJO, fre.ID_FACTURA,
							o.RFC_CLIENTE, o.CONTRIBUYENTE, o.OBSERVACIONES, o.ORDEN_COMPRA, FORMA_FACTURACION, o.FACTURA, m.METODO
							from ORDEN_FACTURA o 
		inner join FACTURA_RUTA_ESPECIAL fre on o.ID = fre.ID_FACTURA  
		inner join RUTA_ESPECIAL re on fre.ID_RE = re.ID_RE
		inner join VIAJE_PROSPECTO_NUEVO vpn on re.ID_RE = vpn.ID_RE
		left join METODO_FACTURA m on m.ID_RE=re.ID_RE
	where o.ESTATUS = 1 and o.FLUJO = 1 and vpn.FECHA_FACTURA between '2012-01-01' AND '"+fecha+"' ";								
			}else{
				consulta = @"select o.ID, o.ID_RES, o.FECHAS, o.IMPORTE, o.IVA, o.TOTAL, o.VEHICULO, o.CANTIDAD_VEHICULO, o.FORMA_FACTURACION, o.ESTATUS, o.FLUJO, fre.ID_FACTURA,
							o.RFC_CLIENTE, o.CONTRIBUYENTE, o.OBSERVACIONES, o.ORDEN_COMPRA, FORMA_FACTURACION, o.FACTURA, m.METODO
							from ORDEN_FACTURA o 
		inner join FACTURA_RUTA_ESPECIAL fre on o.ID = fre.ID_FACTURA  
		inner join RUTA_ESPECIAL re on fre.ID_RE = re.ID_RE
		inner join VIAJE_PROSPECTO_NUEVO vpn on re.ID_RE = vpn.ID_RE
		left join METODO_FACTURA m on m.ID_RE=re.ID_RE
	where o.ESTATUS != -1 and vpn.FECHA_FACTURA between '"+dtpInicioOrdenFactura.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFinOrdenFactura.Value.ToString("yyyy-MM-dd")+"' and VPN."+cmbBusquedaOrdenFactura.Text+" like '%"+txtBusquedaOrdenFactura.Text+"%'";
			}
			if(consulta != ""){
				consulta = consulta +@"group by  o.FACTURA, o.ID, o.ID_RES, o.FECHAS, o.IMPORTE, o.IVA, o.TOTAL, o.VEHICULO, o.CANTIDAD_VEHICULO, o.FORMA_FACTURACION, o.ESTATUS, o.FLUJO, fre.ID_FACTURA,
									o.RFC_CLIENTE, o.CONTRIBUYENTE, o.OBSERVACIONES, o.ORDEN_COMPRA, FORMA_FACTURACION, m.METODO "; 
				AdaptadorOrdenFactura(consulta);	
			}						
		}
		#endregion
		
		#region ADAPTADOR
		private void AdaptadorOrdenFactura(string consulta){
		int contador = 0;			
			try{
				dgOrdenFactura.Rows.Clear();	
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){		 				
					dgOrdenFactura.Rows.Add(conn.leer["ID"].ToString(),
					                        conn.leer["FACTURA"].ToString(),
 	                      					conn.leer["ID_RES"].ToString(),
 	                      					conn.leer["FECHAS"].ToString(),
				                      		"",
				                      		conn.leer["VEHICULO"].ToString(),
					                        conn.leer["CANTIDAD_VEHICULO"].ToString(),
					                        conn.leer["IMPORTE"].ToString(),     
											conn.leer["IVA"].ToString(),
											conn.leer["TOTAL"].ToString(),
											conn.leer["RFC_CLIENTE"].ToString(),
											conn.leer["CONTRIBUYENTE"].ToString(),
											conn.leer["OBSERVACIONES"].ToString(),
											conn.leer["ORDEN_COMPRA"].ToString(),												 
											conn.leer["FORMA_FACTURACION"].ToString(),
											conn.leer["METODO"].ToString());
				if(conn.leer["ESTATUS"].ToString().Equals("0")){
						for(int y=0; y<dgOrdenFactura.Columns.Count; y++){
							dgOrdenFactura[y,contador].Style.BackColor = Color.Red;
						}
					}					
				if(conn.leer["FLUJO"].ToString().Equals("2") && conn.leer["ESTATUS"].ToString().Equals("1")){
						for(int y=0; y<dgOrdenFactura.Columns.Count; y++){
							dgOrdenFactura[y,contador].Style.BackColor = Color.LightGreen;
						}
					}						
					contador++;	
				}					
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las ordenes de facturas  (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);	
		}finally{
			if(conn.conexion != null)
				conn.conexion.Close();
		}
			avisoFacturaEliminada(contador);
			completaDatos();
			if(dgOrdenFactura.Rows.Count > 0 && cbEliminadasOrdenFactura.Checked == false){
				lblAvisoFactura.Visible = true;
				tabPage1.ImageIndex = 0;
			}else{
				lblAvisoFactura.Visible = false;
				tabPage1.ImageIndex = -1;
			}
			lblFacturas.Text = "ACTURAS PENDIENTES: " + contador;			
		}		
		
		private void completaDatos(){
			int contador1 = 1;
			int contador = 1;
			string consulta = "";
			for(int x=0; x<dgOrdenFactura.Rows.Count; x++){
				contador1 = 1;
				contador = 1;
				try{
					
				/////////////////////////////////////////////////////////////////////////// IMPORTES ///////////////////////////////////////////////////////////////////////////
					if(dgOrdenFactura[14,x].Value.ToString() == "UNIFICADA"){
						consulta = @"SELECT CANT_UNIDADES, SUM( CONVERT(INT, CANT_UNIDADES) ) uTotal, PRECIO, SUM( CONVERT(FLOAT, PRECIO) ) pTotal FROM RUTA_ESPECIAL WHERE ID_RE in (select fr.ID_RE 
									from ORDEN_FACTURA o JOIN FACTURA_RUTA_ESPECIAL fr on o.ID = fr.ID_FACTURA where o.ID = "+dgOrdenFactura[0,x].Value.ToString()+") GROUP BY CANT_UNIDADES, PRECIO";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						while(conn.leer.Read()){
							if(contador == 1)
								dgOrdenFactura[7,x].Value = conn.leer["uTotal"].ToString()+"="+conn.leer["PRECIO"].ToString();						
							
							if(contador > 1)
								dgOrdenFactura[7,x].Value = dgOrdenFactura[7,x].Value + "; "+conn.leer["uTotal"].ToString()+"="+conn.leer["PRECIO"].ToString();
							contador++;
						}			
						conn.conexion.Close();						
					}else{
						string precio = dgOrdenFactura[7,x].Value.ToString();
						dgOrdenFactura[7,x].Value = dgOrdenFactura[6,x].Value +"="+dgOrdenFactura[7,x].Value;
					}
						
				/////////////////////////////////////////////////////////////////////////// METODO ///////////////////////////////////////////////////////////////////////////
						consulta = @" SELECT CLAVE, METODO, CUENTA, sum(CONVERT(decimal(10,2), monto)) monto FROM METODO_FACTURA WHERE ESTATUS = '1' AND ID_RE in (select fr.ID_RE from ORDEN_FACTURA o JOIN 
										FACTURA_RUTA_ESPECIAL fr on o.ID = fr.ID_FACTURA where o.ID = "+dgOrdenFactura[0,x].Value.ToString()+") GROUP BY CLAVE, METODO, CUENTA ORDER BY MONTO DESC";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						while(conn.leer.Read()){
							if(contador1 == 1){
								if(conn.leer["METODO"].ToString() == "Transferencia" || conn.leer["METODO"].ToString() == "Cheque")
									dgOrdenFactura[15,x].Value = conn.leer["CLAVE"].ToString()+" "+conn.leer["METODO"].ToString()+" Cuenta:"+conn.leer["CUENTA"].ToString()+" "+conn.leer["monto"].ToString();
								else
									dgOrdenFactura[15,x].Value = conn.leer["CLAVE"].ToString()+" "+conn.leer["METODO"].ToString()+" "+conn.leer["monto"].ToString();
							}
							if(contador1 > 1){
								if(conn.leer["METODO"].ToString() == "Transferencia" || conn.leer["METODO"].ToString() == "Cheque")
									dgOrdenFactura[15,x].Value += "; "+conn.leer["CLAVE"].ToString()+" "+conn.leer["METODO"].ToString()+" Cuenta:"+conn.leer["CUENTA"].ToString()+" "+conn.leer["monto"].ToString();
								else
									dgOrdenFactura[15,x].Value += "; "+conn.leer["CLAVE"].ToString()+" "+conn.leer["METODO"].ToString()+" "+conn.leer["monto"].ToString();
							}
							contador1++;
						}			
						conn.conexion.Close();				
				}catch(Exception ex){
					MessageBox.Show("Error al obtener Metodos y importes  (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);	
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}
			
			#region DESTINO
			/*
			for(int x=0; x<dgOrdenFactura.Rows.Count; x++){
				try{
					string consul = @"select DESTINO from RUTA_ESPECIAL where ID_RE in (select fr.ID_RE from ORDEN_FACTURA o JOIN FACTURA_RUTA_ESPECIAL fr on o.ID = fr.ID_FACTURA where o.ID = "
						+dgOrdenFactura[0,x].Value.ToString()+")";
					conn.getAbrirConexion(consul);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read())
						dgOrdenFactura[15,x].Value = dgOrdenFactura[15,x].Value + conn.leer["DESTINO"].ToString()+ " - ";				
					conn.conexion.Close();
				}catch(Exception){
				}				
			}*/
			#endregion
		}
		
		private void avisoFacturaEliminada(int con){	
		int contador = con;
		string consulta = @"select o.ID, o.ID_RES, o.FECHAS, o.IMPORTE, o.IVA, o.TOTAL, o.VEHICULO, o.CANTIDAD_VEHICULO, o.FORMA_FACTURACION, o.ESTATUS, o.FLUJO, fre.ID_FACTURA,
							o.RFC_CLIENTE, o.CONTRIBUYENTE, o.OBSERVACIONES, o.ORDEN_COMPRA, FORMA_FACTURACION, o.FACTURA
							from ORDEN_FACTURA o, FACTURA_RUTA_ESPECIAL fre, RUTA_ESPECIAL re, VIAJE_PROSPECTO_NUEVO vpn where o.ESTATUS = -1 and o.ID = fre.ID_FACTURA and fre.ID_RE = re.ID_RE and re.ID_RE = vpn.ID_RE";
			try{
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{		 				
					dgOrdenFactura.Rows.Add(conn.leer["ID"].ToString(),
					                        conn.leer["FACTURA"].ToString(),
 	                      					conn.leer["ID_RES"].ToString(),
	                      					Convert.ToDateTime(conn.leer["FECHAS"].ToString().Substring(0,5)).ToShortDateString(),
				                      		"",
				                      		conn.leer["VEHICULO"].ToString(),
					                        conn.leer["CANTIDAD_VEHICULO"].ToString(),
					                        conn.leer["IMPORTE"].ToString(),     
											conn.leer["IVA"].ToString(),
											conn.leer["TOTAL"].ToString(),
											conn.leer["RFC_CLIENTE"].ToString(),
											conn.leer["CONTRIBUYENTE"].ToString(),
											conn.leer["OBSERVACIONES"].ToString(),
											conn.leer["ORDEN_COMPRA"].ToString(),												 
											conn.leer["FORMA_FACTURACION"].ToString(),
											"");
				if(conn.leer["ESTATUS"].ToString().Equals("-1")){
						for(int y=0; y<dgOrdenFactura.Columns.Count; y++){
							dgOrdenFactura[y,contador].Style.BackColor = Color.LightPink;
						}
					}									
					contador++;	
				}					
				conn.conexion.Close();
				dgOrdenFactura.ClearSelection();				
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las facturas eliminadas  (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);	
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
		}		
		#endregion
		
		#region EVENTOS
		void CopiarDetalleDeFacturaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgOrdenFactura.SelectedRows.Count == 1){
				String datos = "";
				try{
					conn.getAbrirConexion(@"select 'Del '+ CONVERT(VARCHAR(10), FECHA_SALIDA, 103)+' - Destino:  '+DESTINO detalle from
										 RUTA_ESPECIAL where ID_RE in (select fr.ID_RE from ORDEN_FACTURA o JOIN FACTURA_RUTA_ESPECIAL fr on o.ID = fr.ID_FACTURA where
										 o.id = "+dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString()+")");
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read()){
						datos = datos + conn.leer["detalle"].ToString();
						datos = datos + " \n\t";						
					}
					conn.conexion.Close();	
				}catch(Exception ex){
					MessageBox.Show("Error al copiar los detalles de la factura: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
				}
				Clipboard.Clear();
			 	Clipboard.SetDataObject(datos);
			}
		}
		
		void CancelarFacturaYRegresarAFlujoEnVentasToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Selected == true && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "Red"
			  && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "LightPink" && dgOrdenFactura.SelectedRows.Count == 1){
				DialogResult respuesta = MessageBox.Show("¿Deseas Eliminar la factura? Estará pendiente por facturar hasta que la vuelva a liberar ventas" + dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString() , "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(respuesta == DialogResult.Yes){
					connL.EliminarFactura1(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString(), dgOrdenFactura[2,dgOrdenFactura.CurrentRow.Index].Value.ToString(), id_usuario.ToString());
					filtrosOrden();
				}
			}
		}
		
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			if(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Selected == true && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "Red"
			  && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "LightPink" && dgOrdenFactura.SelectedRows.Count == 1){
				DialogResult respuesta = MessageBox.Show("¿Deseas Eliminar la factura sin regresar a flujo de ventas?" + dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString() , "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(respuesta == DialogResult.Yes){
					connL.EliminarFactura3(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString(), id_usuario.ToString());
					filtrosOrden();
				}
			}
		}
		
		void DgOrdenFacturaDoubleClick(object sender, EventArgs e)
		{
			if(dgOrdenFactura.CurrentCell.ColumnIndex != 16 && dgOrdenFactura.CurrentCell.ColumnIndex != 1 && dgOrdenFactura[1,dgOrdenFactura.CurrentRow.Index].Selected == true && dgOrdenFactura[1,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name == "LightPink"){
				if(dgOrdenFactura.SelectedRows.Count == 1){
						connL.QuitaAvisoFactuta(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString(), id_usuario);
						filtrosOrden();
					}
				}			
		}
				
		void DgOrdenFacturaCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 16 && e.RowIndex != -1){
				msjGlobo.muestrarMsj(dgOrdenFactura[0,e.RowIndex].Value.ToString());
				msjGlobo.Location  = new System.Drawing.Point(300, Control.MousePosition.Y);
				msjGlobo.Visible=true;
				msj=1;				
			}else if(msj==1){
				msjGlobo.Visible=false;
				msj=0;
			}
		}		
		
		void DtpInicioOrdenFacturaValueChanged(object sender, EventArgs e)
		{
			if(!filtrosV)
				filtrosOrden();
		}
		
		void DtpFinOrdenFacturaValueChanged(object sender, EventArgs e)
		{
			if(!filtrosV)
				filtrosOrden();
		}
		
		void CmbBusquedaOrdenFacturaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(!filtrosV)
				filtrosOrden();
		}
		
		void TxtBusquedaOrdenFacturaTextChanged(object sender, EventArgs e)
		{
			if(!filtrosV)
				filtrosOrden();
		}
		
		void CbEliminadasOrdenFacturaCheckedChanged(object sender, EventArgs e)
		{
			if(!filtrosV)
				filtrosOrden();
		}
		
		void DgOrdenFacturaCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 10 && e.RowIndex != -1 && dgOrdenFactura[1,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "LightPink")				
				new Interfaz.Libro.FormDatosFactura(4, dgOrdenFactura[10,dgOrdenFactura.CurrentRow.Index].Value.ToString(), ObtenerCorreoFactura(dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Value.ToString())).ShowDialog();
			
			if(e.ColumnIndex == 1 && e.RowIndex != -1 && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "Red"
			  && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "LightPink")			
				new FormIngresaFactura(this, dgOrdenFactura[1,dgOrdenFactura.CurrentRow.Index].Value.ToString()).ShowDialog();
		}
		
		private string ObtenerCorreoFactura(string id_fa){
			String correo = "";
			try{
				conn.getAbrirConexion(@"SELECT TOP 1 CORREO FROM RUTA_ESPECIAL RE JOIN FACTURA_RUTA_ESPECIAL FR ON FR.ID_RE = RE.ID_RE JOIN ORDEN_FACTURA F ON F.ID = FR.ID_FACTURA 
									WHERE ID_FACTURA = "+id_fa);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					correo = conn.leer["CORREO"].ToString();				
				conn.conexion.Close();	
			}catch(Exception){					
			}
			return correo;
		}
		#endregion	

		#region BOTONES
		void Button2Click(object sender, EventArgs e)
		{
			if(dgOrdenFactura.SelectedRows.Count > 0 && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "Red"
			  && dgOrdenFactura[0,dgOrdenFactura.CurrentRow.Index].Style.BackColor.Name != "LightPink")
				new FormIngresaFactura(this, dgOrdenFactura[1,dgOrdenFactura.CurrentRow.Index].Value.ToString()).ShowDialog();
			else
				MessageBox.Show("Selecciona una orden de factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion													
		
		void MenuEspecialesOpening(object sender, CancelEventArgs e)
		{
			
		}
	}
}	
		