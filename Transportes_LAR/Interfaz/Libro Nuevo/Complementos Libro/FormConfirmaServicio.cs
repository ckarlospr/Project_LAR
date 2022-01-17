using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Complementos_Libro
{
	public partial class FormConfirmaServicio : Form
	{
		#region VARIABLES
		int idCotizacion = 0;
		int idViaje = 0;
		int idCliente = 0;
		int idServiciodetalle = 0;
		int tipoConfirmacion = 0;
		string client = "";
		string telefon = "";
		int idClienteObtener = 0;
		#endregion
		
		#region INSTANCIAS
		Interfaz.Libro_Nuevo.FormLibroViajes refLibro = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();		
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTOR
		public FormConfirmaServicio(Interfaz.Libro_Nuevo.FormLibroViajes libroViajes, int id_ruta_especial, int id_cotizacion, int tipo)
		{
			InitializeComponent();
			this.refLibro = libroViajes;
			this.idViaje = id_ruta_especial;
			idCotizacion = id_cotizacion;
			tipoConfirmacion = tipo;		
		}		
		
		public FormConfirmaServicio(FormLibroViajes libroViajes, int id, string cliente, string telefono)
		{
			InitializeComponent();
			this.refLibro = libroViajes;
			this.idCotizacion = id;
			client = cliente;
			telefon = telefono;
			refLibro.idCotizacionNuevo = id;
		}
		#endregion			
		
		#region INICIO - FIN
		void FormConfirmaServicioLoad(object sender, EventArgs e)
		{
			CargarInicio();
		}
		
		void FormConfirmaServicioFormClosing(object sender, FormClosingEventArgs e)
		{
			refLibro.filtrosPrincipales();
		}		
		#endregion
		
		#region BOTON	
		void LblAgregarRazonClick(object sender, EventArgs e)
		{
			new Libro_Nuevo.Pagos.FormContribuyentes(1).ShowDialog();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(validarCampos()){
				if(tipoConfirmacion == 0){
					refLibro.idClienteNuevo = connL.insertarDetalleViaje(idCotizacion.ToString(), txtCiudadS.Text, txtColoniaS.Text, txtCalleS.Text, txtCrucesS.Text, txtReferenciaS.Text, txtContacto.Text, txtTelefono.Text, txtCiudadD.Text, txtColoniaD.Text,
				                          txtCalleD.Text, txtCrucesD.Text, txtReferenciaD.Text, txtObservaciones.Text, client, telefon);
					refLibro.validarViaje = true;
					refLibro.fecha_facturaV = dtpFechaFactura.Value.ToString("yyyy-MM-dd");
					refLibro.razon_socialV = txtRazonSocial.Text;
					refLibro.ruta_inicio = txtRuta.Text;
					refLibro.dgMetodoFactura = dgMetodosF;
					this.Close();					
				}
				if(tipoConfirmacion == 1 && idServiciodetalle > 0){
					connL.actualizarDetalleViaje(idCliente, idServiciodetalle, txtCiudadS.Text, txtColoniaS.Text, txtCalleS.Text, txtCrucesS.Text, txtReferenciaS.Text, txtContacto.Text, txtTelefono.Text, txtCiudadD.Text, txtColoniaD.Text,
					                             txtCalleD.Text, txtCrucesD.Text, txtReferenciaD.Text, txtObservaciones.Text, idViaje, txtRazonSocial.Text, dtpFechaFactura.Value.ToString("yyyy-MM-dd"), txtRuta.Text);
					if(idViaje > 0)
						insertarMetodosPagoFactura(idViaje.ToString());
					
					this.Close();
				}
			}
		}		
		
		void LblAgregarMetodoClick(object sender, EventArgs e)
		{
			if(cbMetodo.SelectedIndex > -1){
				if(validaMetodo()){
					if(cbMetodo.SelectedIndex == 1 || cbMetodo.SelectedIndex == 2)
						dgMetodosF.Rows.Add("0", obtenerClaveMetodo(cbMetodo.Text), cbMetodo.Text, txtCuenta.Text, txtMonto.Text);
					else
						dgMetodosF.Rows.Add("0", obtenerClaveMetodo(cbMetodo.Text), cbMetodo.Text, "N/A", txtMonto.Text);
					cbMetodo.SelectedIndex = -1;
					txtCuenta.Text = "";
					txtMonto.Text = "";
				}
			}
		}	
		#endregion	
	
		#region EVENTOS			
		void CbMetodoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbMetodo.SelectedIndex == 2)
				txtCuenta.Enabled = true;

			if(cbMetodo.SelectedIndex == 1)
				txtCuenta.Enabled = true;
			
			if(cbMetodo.SelectedIndex != 1 && cbMetodo.SelectedIndex != 2)
				txtCuenta.Enabled = false;				
		}
		
		void TimerTick(object sender, EventArgs e)
		{			
			this.Width = this.Width + 80;
			if(this.Width >= 620){
				timer.Stop();
			}
		}
		
		void TxtRutaDoubleClick(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetDataObject(txtRuta.Text);
			txtRuta.SelectAll();
		}
		#endregion
		
		#region METODOS
		private bool validaMetodo(){
			bool respuesta = true;
			double monto = 0.0;
			for(int x=0; x<dgMetodosF.Rows.Count; x++){
				if(cbMetodo.SelectedIndex == 2){					
					if(dgMetodosF[2,x].Value.ToString() == cbMetodo.Text && dgMetodosF[3,x].Value.ToString() == txtCuenta.Text && txtMonto.Text != "" && txtMonto.Text != "0" && txtMonto.Text != "0.0")
						respuesta = false;
				}else{					
					if(dgMetodosF[2,x].Value.ToString() == cbMetodo.Text && txtMonto.Text != "" && txtMonto.Text != "0"  && txtMonto.Text != "0.0")
						respuesta = false;
				}
				monto = monto + Convert.ToDouble(dgMetodosF[4,x].Value);
			}
			
			monto = monto + Convert.ToDouble(txtMonto.Text);
			
			if(monto > Convert.ToDouble(refLibro.txtNeto.Text))
				respuesta = false;
			
			return respuesta;
		}
		
		private void insertarMetodosPagoFactura(string id_re){
			try{
				if(dgMetodosF.Rows.Count > 0){
					for(int x=0; x<dgMetodosF.Rows.Count; x++){
						if(dgMetodosF[0,x].Value.ToString() == "0")
							connL.insertarMetodoFactura(id_re, dgMetodosF[1,x].Value.ToString(), dgMetodosF[2,x].Value.ToString(), dgMetodosF[3,x].Value.ToString(), dgMetodosF[4,x].Value.ToString());
					}
				}
			}catch(Exception){	}
		}
				
		private void CargarInicio(){
			txtRazonSocial.AutoCompleteCustomSource = auto.AutocompleteGeneral("select RAZON_SOCIAL from DATOS_FACTURA", "RAZON_SOCIAL");
            txtRazonSocial.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource;  
            
			this.Width = 0; 
			timer.Start();
					
			if(tipoConfirmacion == 1){
				obtenerDatos();	
			}else{				
				txtContacto.Text = client;
				txtTelefono.Text = telefon;
				if(refLibro.cbFactura.Checked == true){
					gbFactura.Enabled = true;
					dtpFechaFactura.Value = DateTime.Now.AddDays(-1);
				}
				txtMonto.Text = refLibro.txtNeto.Text;
			}
		}		
		
		public void obtenerDatos(){
			try{
				conn.getAbrirConexion(@"select ds.*, vp.FACTURA, vp.FECHA_FACTURA, vp.PRECIO_DIFERENTE, vp.LINK_INICIO_RUTA from VIAJE_PROSPECTO_NUEVO vp, 
										DETALLE_SERVICIO ds where vp.ID = ds.ID_COTIZACION and vp.ID_RE = "+idViaje);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){					
					txtCiudadS.Text = conn.leer["CIUDAD_S"].ToString();
					txtColoniaS.Text = conn.leer["COLONIA_S"].ToString();
					txtCalleS.Text = conn.leer["CALLE_S"].ToString();
					txtCrucesS.Text = conn.leer["CRUCES_S"].ToString();
					txtReferenciaS.Text = conn.leer["REFERENCIA_S"].ToString();
					txtContacto.Text = conn.leer["RESPONSABLE"].ToString();
					txtTelefono.Text = conn.leer["TELEFONO_R"].ToString();
					txtCiudadD.Text = conn.leer["CIUDAD_D"].ToString();
					txtColoniaD.Text = conn.leer["COLONIA_D"].ToString();
					txtCalleD.Text = conn.leer["CALLE_D"].ToString();
					txtCrucesD.Text = conn.leer["CRUCES_D"].ToString();
					txtReferenciaD.Text = conn.leer["REFERENCIA_D"].ToString();
					txtObservaciones.Text = conn.leer["OBSERVACIONES"].ToString();
					txtRuta.Text = conn.leer["LINK_INICIO_RUTA"].ToString();					
					idCliente = Convert.ToInt32(conn.leer["IdCliente"]);
					idServiciodetalle = Convert.ToInt32(conn.leer["ID"]);
					if(conn.leer["FACTURA"].ToString() == "1"){
						gbFactura.Enabled = true;					
						txtRazonSocial.Enabled = true;
						dtpFechaFactura.Enabled = true;
						lblAgregarRazon.Enabled = true;
						dtpFechaFactura.Text = conn.leer["FECHA_FACTURA"].ToString();
						txtRazonSocial.Text = conn.leer["PRECIO_DIFERENTE"].ToString();
					}else{
						gbFactura.Enabled = false;						
						txtRazonSocial.Enabled = false;
						dtpFechaFactura.Enabled = false;
						lblAgregarRazon.Enabled = false;						
						dtpFechaFactura.Value = DateTime.Now.AddDays(-1);
					}
				}
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los datos del servicos: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();	
			}

			try{
				conn.getAbrirConexion(@"SELECT * FROM METODO_FACTURA WHERE ESTATUS = '1' AND ID_RE = "+idViaje);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgMetodosF.Rows.Add(conn.leer["ID"].ToString(), conn.leer["CLAVE"].ToString(), conn.leer["METODO"].ToString(), conn.leer["CUENTA"].ToString(), conn.leer["MONTO"].ToString());
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los metodos de pago para la facturación: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();	
			}
			dgMetodosF.ClearSelection();
			calculoMonto();
		}
		
		private void calculoMonto(){
			double monto = 0.0;
			for(int x=0; x<dgMetodosF.Rows.Count; x++){
				if(dgMetodosF[4,x].Value.ToString() != "")
					monto = monto + Convert.ToDouble(dgMetodosF[4,x].Value);
			}
			txtMonto.Text =  ( Convert.ToDouble(refLibro.txtNeto.Text) - monto).ToString();
		}
		
		public Boolean validarCampos(){
			bool validar = true;
			errorProvider1.Clear();
			if(txtContacto.Text == ""){
				validar = false;
				txtContacto.Focus();
				errorProvider1.SetError(txtContacto, "Ingresa el contacto");
			}
			
			if(txtTelefono.Text == ""){
				validar = false;
				txtTelefono.Focus();
				errorProvider1.SetError(txtTelefono, "Ingresa el contacto");
			}
			
			if(dtpFechaFactura.Value.AddDays(1) < DateTime.Now && dtpFechaFactura.Enabled == true){
				validar = false;
				dtpFechaFactura.Focus();
				errorProvider1.SetError(dtpFechaFactura, "Ingresa una fecha valida");
			}
			return validar;
		}
		
		public void  obtenerIDCliente(){			
			try{	
				conn.getAbrirConexion("select MAX(ID) ID From cliente");
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					idClienteObtener = Convert.ToInt16(conn.leer["ID"]);
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("ERROR OBTENER EL ID DEL CLIENTE: "+ex.Message);
			}
		}
		
		private string obtenerClaveMetodo(string metodo){
			string claveM = "";
			
			if(cbMetodo.SelectedIndex == 0)
				claveM = "01";
			if(cbMetodo.SelectedIndex == 1)
				claveM = "02";
			if(cbMetodo.SelectedIndex == 2)
				claveM = "03";
			if(cbMetodo.SelectedIndex == 3)
				claveM = "04";
			if(cbMetodo.SelectedIndex == 4)
				claveM = "05";
			if(cbMetodo.SelectedIndex == 5)
				claveM = "06";
			if(cbMetodo.SelectedIndex == 6)
				claveM = "07";
			if(cbMetodo.SelectedIndex == 7)
				claveM = "08";
			if(cbMetodo.SelectedIndex == 8)
				claveM = "09";
			if(cbMetodo.SelectedIndex == 9)
				claveM = "10";
			if(cbMetodo.SelectedIndex == 10)
				claveM = "11";
			if(cbMetodo.SelectedIndex == 11)
				claveM = "12";
			if(cbMetodo.SelectedIndex == 12)
				claveM = "13";
			if(cbMetodo.SelectedIndex == 13)
				claveM = "14";
			if(cbMetodo.SelectedIndex == 14)
				claveM = "15";
			if(cbMetodo.SelectedIndex == 15)
				claveM = "16";
			if(cbMetodo.SelectedIndex == 16)
				claveM = "17";
			if(cbMetodo.SelectedIndex == 17)
				claveM = "98";
			if(cbMetodo.SelectedIndex == 18)
				claveM = "99";
			
			return claveM;
		}
		
		void DgMetodosFCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && e.ColumnIndex == 5 && gbFactura.Enabled == true){
				if(dgMetodosF[0, e.RowIndex].Value.ToString() == "0"){
					dgMetodosF.Rows.RemoveAt(e.RowIndex);
				}else{
					if(idViaje > 0 && dgMetodosF[0,e.RowIndex].Value.ToString() != "0"){
						if(connL.eliminarMetodoFactura(dgMetodosF[0,e.RowIndex].Value.ToString())){
							dgMetodosF.Rows.RemoveAt(e.RowIndex);
							MessageBox.Show("EL MÉTODO SE ELIMINO CORRECTAMENTE","LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}				
			}
		}			
		#endregion
	}
}
