using System;
using System.Text;
using System.Drawing;
using System.Net.Mail;
 using System.Net.Mime;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;

namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	public partial class FormUber_Taxi : Form
	{
		#region INSTANCIAS
		private Interfaz.Operaciones.FormCancelCambio formCambios = null;
		private Interfaz.Operaciones.FormPrin_Empresas formPrincipalD = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Controles.SQL_Controles connC = new Conexion_Servidor.Controles.SQL_Controles();
		#endregion
		
		#region VARIABLES
		string fecha_despacho;
		Int64 id_responsable;
		Int64 id_operador;
		Int64 id_pedido;
		string id_usuario;
		string turno;
		string id_ruta;
		#endregion
		
		#region CONTRUCTOR
		public FormUber_Taxi(Interfaz.Operaciones.FormCancelCambio refOpc, string id_r, string id_usu, string tur, string fechaD)
		{
			InitializeComponent();
			this.formCambios = refOpc;
			this.id_usuario = id_usu;
			this.id_ruta = id_r;
			this.turno = tur;
			this.fecha_despacho = fechaD;
		}
		public FormUber_Taxi(Interfaz.Operaciones.FormPrin_Empresas refOpc, string id_usu, string tur, string fechaD)
		{
			InitializeComponent();
			this.formPrincipalD = refOpc;
			this.id_usuario = id_usu;
			this.turno = tur;
			this.fecha_despacho = fechaD;
		}
		#endregion
		
		#region INICIO - FIN		
		void GbProgramacionLoad(object sender, EventArgs e)
		{
			cargaInformacion();
			validaCampos();
			autoCompleta();
			
			if(formPrincipalD == null){
				if(formCambios.refEmpOper.refPrincipal.principal.lblDatoNivel.Text == "GERENCIAL" || formCambios.refEmpOper.refPrincipal.principal.lblDatoNivel.Text == "MASTER")
					pbConfiguraciones.Visible = true;
				
				txtResponsable.Text = formCambios.refEmpOper.refPrincipal.principal.lblDatoUsuario.Text;
			}else if(formCambios == null){
				if(formPrincipalD.principal.lblDatoNivel.Text == "GERENCIAL" || formPrincipalD.principal.lblDatoNivel.Text  == "MASTER")
					pbConfiguraciones.Visible = true;
			}
		}
		
		void GbProgramacionFormClosing(object sender, FormClosingEventArgs e)
		{
			if(formPrincipalD == null){
				formCambios.refEmpOper.refPrincipal.UberTaxiPendientes();
			}else if(formCambios == null){
				formPrincipalD.UberTaxiPendientes();
			}
		}
		#endregion
		
		#region METODOS
		private void cargaInformacion(){
			bool respuesta = true;
			string consulta;
			if(id_ruta == "" || id_ruta == null){
				gbProgramcion.Enabled = false;
				gbPedidos.Enabled = false;
			}else{				
				lblHoraPlaneacion.Text = DateTime.Now.ToString("HH:mm");
				try{
					if(formCambios.indexCol < 9){
						if(formCambios.refEmpOper.dtgEmpresas[0,formCambios.indexFil].Style.BackColor.Name == "MediumSpringGreen")
							txtOperador.Text = formCambios.refEmpOper.dtgEmpresas[3,formCambios.indexFil].Value.ToString();
						else
							txtOperador.Text = "";
					}else{
						if(formCambios.refEmpOper.dtgEmpresas[9,formCambios.indexFil].Style.BackColor.Name == "MediumSpringGreen")
							txtOperador.Text = formCambios.refEmpOper.dtgEmpresas[11,formCambios.indexFil].Value.ToString();
						else
							txtOperador.Text = "";
					}
				}catch(Exception){
					respuesta = false;
				}
				
				if(respuesta){
					try{
						consulta = @"SELECT r.Nombre, R.SENTIDO, R.HoraInicio, R.TIPO, C.Empresa, C.tipo_cobro FROM RUTA R JOIN CLIENTE C ON C.ID = R.IDSUBEMPRESA 
									WHERE R.ID = "+id_ruta;
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							txtEmpresa.Text = conn.leer["Empresa"].ToString();
							txtRuta.Text = conn.leer["Nombre"].ToString();
							txtSentido.Text = conn.leer["SENTIDO"].ToString();
							dtpHoraArranque.Text = conn.leer["HoraInicio"].ToString();
							txtUnidad.Text = conn.leer["tipo_cobro"].ToString();					
						}
						conn.conexion.Close();	
					}catch(Exception){
						respuesta = false;				
					}finally{
						if(conn.conexion != null)
							conn.conexion.Close();
					}
				}
					
				if(respuesta){
					try{
						consulta = @"SELECT PASAJEROS FROM OPERACION O WHERE PASAJEROS != '0'  AND  ID_RUTA = "+id_ruta+"  ORDER BY PASAJEROS DESC";
						conn.getAbrirConexion(consulta);
						conn.leer = conn.comando.ExecuteReader();
						if(conn.leer.Read()){
							txtUsuario.Text = conn.leer["PASAJEROS"].ToString();				
						}else{
							txtUsuario.Text = "0";
						}
						conn.conexion.Close();	
					}catch(Exception){
						respuesta = false;				
					}finally{
						if(conn.conexion != null)
							conn.conexion.Close();
					}
					lblUnidadA.Text = (Convert.ToInt32(txtUsuario.Text)/4).ToString();
				}
				if(!respuesta){
					MessageBox.Show("Error al obtener datos (error al llenar los campos) ", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);				
				}
			}
			filtros();
		}
		
		private void validaCampos(){
			this.txtResponsable.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			this.txtOperador.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		
		private void autoCompleta(){
			txtOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT Alias FROM OPERADOR WHERE TIPO_EMPLEADO IN ('OPERADOR', 'COORDINADOR', 'TALLER', 'AUXILIAR COORDINADOR' ) 
																			AND Estatus = '1'", "Alias");
           	txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtResponsable.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT O.Alias FROM OPERADOR O JOIN CUENTAS_UBER_TAXI CU ON CU.ID_USUARIO = O.ID WHERE O.Estatus = '1' AND CU.ESTATUS = 'Activo'", "Alias");
           	txtResponsable.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		private bool validacion(){
			bool respuesta = true;
			
			if(cbMotivo.SelectedIndex == 0 || cbMotivo.SelectedIndex == 1){
				if(txtOperador.BackColor != Color.LightGreen){
					errorProvider1.SetError(txtOperador, "Inserta un operador valido");
					txtOperador.Focus();
					respuesta = false;
				}
			}				
			return respuesta;
		}
		
		private bool validacionPedido(){
			bool respuesta = true;
			
			if(cbMotivo.SelectedIndex == 0 || cbMotivo.SelectedIndex == 1){
				if(txtOperador.BackColor != Color.LightGreen){
					errorProvider1.SetError(txtOperador, "Inserta un operador valido");
					txtOperador.Focus();
					respuesta = false;
				}
			}
			
			if(dgPedidos.Rows.Count == 0){
				errorProvider1.SetError(dgPedidos, "Ingresa mínimo un vehículo para realizar el pedido");
				cmbTipoUnidad.Focus();
				respuesta = false;
			}				
			return respuesta;
		}
		
		private bool validaResponsables(){
			bool respuesta = true;
			
			if(cmbTipoUnidad.SelectedIndex == -1){
				errorProvider1.SetError(cmbTipoUnidad, "Selecciona el tipo de vehículo");
				cmbTipoUnidad.Focus();
				respuesta = false;
			}
			if(txtResponsable.BackColor != Color.LightGreen){
				errorProvider1.SetError(txtResponsable, "Selecciona un responsable valido");
				txtResponsable.Focus();
				respuesta = false;
			}
			
			return respuesta;
		}
				
		public void filtros(){
			string  Consulta = @"SELECT UT.*, R.Nombre, R.HoraInicio, C.Empresa FROM UBER_TAXI UT JOIN RUTA R ON UT.ID_RUTA = R.ID JOIN Cliente C ON C.ID = R.IdSubEmpresa
							 WHERE UT.TIPO = 'RUTA' AND UT.FECHA_PLANEACION = '"+fecha_despacho+"' and R.Nombre LIKE '%"+txtBusqueda.Text+"%' ";
			if(cbcancelados.Checked == false)
				Consulta = Consulta + " and UT.ESTATUS = 'Activo' ";		
			if(cmbBusqueda.SelectedIndex == -1 || cmbBusqueda.SelectedIndex == 0)
				Consulta = Consulta + " and UT.TURNO = '"+turno+"' ";
			else
				Consulta = Consulta + " and UT.TURNO = '"+cmbBusqueda.Text+"' ";
			Consulta = Consulta + " ORDER BY R.HoraInicio, UT.ESTADO ";			
			adaptadorProgramados(Consulta);
		}
		
		private void adaptadorProgramados(string Consulta){				
			int contador = 0;
			try{
				dgProgramados.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgProgramados.Rows.Add(conn.leer["ID"].ToString(),
					                      		conn.leer["HoraInicio"].ToString(),
					                      		conn.leer["Empresa"].ToString(),
					                      		conn.leer["Nombre"].ToString(),
					                      		conn.leer["MOTIVO"].ToString(),
					                      		conn.leer["ID_OPERADOR"].ToString(),
					                      		conn.leer["ESTADO"].ToString(),
					                      		"UNIDADES",
					                      		"COSTO");
					if(conn.leer["ESTADO"].ToString() == "CIERRE"){
						for(int y=0; y<dgProgramados.Columns.Count; y++)
							dgProgramados[y,contador].Style.BackColor = Color.LightGreen;
					}	
					if(conn.leer["ESTATUS"].ToString() != "Activo"){
						for(int y=0; y<dgProgramados.Columns.Count; y++)
							dgProgramados[y,contador].Style.BackColor = Color.Red;
					}					                        
					contador++;	
				}
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los uber/taxi programados (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			completaDatos();
			dgProgramados.ClearSelection();
		}
		
		private void completaDatos(){
			string consulta = "";
			for(int x=0; x<dgProgramados.Rows.Count; x++){
				if(dgProgramados[5,x].Value.ToString() == "0"){
					dgProgramados[5,x].Value = "N/A";
				}else{
					consulta = @"SELECT Alias FROM OPERADOR WHERE ID = "+dgProgramados[5,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						dgProgramados[5,x].Value = conn.leer["Alias"].ToString();		
					conn.conexion.Close();
				}
				
				if(dgProgramados[6,x].Value.ToString() == "PROGRAMADA"){
					dgProgramados[7,x].Value = "N/A";
					dgProgramados[8,x].Value = "N/A";
				}else{
					consulta = @"SELECT COUNT(*) NV,  SUM( CONVERT(FLOAT, COSTO) ) costo FROM UBER_TAXI_PEDIDO WHERE ESTATUS = 'Activo' and ID_PEDIDO = "+dgProgramados[0,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgProgramados[7,x].Value = conn.leer["NV"].ToString();
						try{
							dgProgramados[8,x].Value = conn.leer["costo"].ToString();
						}catch(Exception){ 
							dgProgramados[8,x].Value = "0"; 
						}
					}				
					conn.conexion.Close();
				}
			}
		}
		
		private void privilegioCerrar(int e){		
			if(dgProgramados.SelectedRows.Count == 1){
				if(dgProgramados[6,e].Value.ToString() == "PEDIDO"){
					if(dgProgramados[6,e].Style.BackColor.Name != "LightGreen"){
						btnProgramar.Enabled = false;
						btnPedido.Enabled = true;
						btnGuardar.Enabled = true;
					}else{
						btnProgramar.Enabled = false;
						btnPedido.Enabled = false;
						btnGuardar.Enabled = false;
					}
				}else if(dgProgramados[6,e].Value.ToString() == "PROGRAMADA"){
					btnProgramar.Enabled = false;
					btnPedido.Enabled = true;
					btnGuardar.Enabled = true;
				}else if(dgProgramados[6,e].Value.ToString() == "CIERRE"){
					btnProgramar.Enabled = false;
					btnPedido.Enabled = false;
					btnGuardar.Enabled = false;		
				}
			}else{
				btnProgramar.Enabled = false;
				btnPedido.Enabled = true;
				btnGuardar.Enabled = true;
			}		
		}
		
		public void obtenerDatosM(){
			string consulta = "";				
			gbProgramcion.Enabled = true;
			gbPedidos.Enabled = true;
			
			txtOperador.Enabled = false;
			btnProgramar.Enabled = false;
			cbMotivo.Enabled = false;
							
			consulta = @"SELECT UT.*, R.Nombre, R.SENTIDO,  R.HoraInicio, C.Empresa FROM UBER_TAXI UT JOIN RUTA R ON UT.ID_RUTA = R.ID JOIN Cliente C ON C.ID = R.IdSubEmpresa
						 WHERE UT.TIPO = 'RUTA' AND UT.ID = "+id_pedido;
			try{
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					lblHoraPlaneacion.Text = conn.leer["HORA_PANEACION"].ToString().Substring(0,5);
					cbMotivo.Text = conn.leer["MOTIVO"].ToString();						
					txtEmpresa.Text = conn.leer["Empresa"].ToString();	
					txtRuta.Text = conn.leer["Nombre"].ToString();						
					txtSentido.Text = conn.leer["SENTIDO"].ToString();							
					dtpHoraArranque.Text = conn.leer["HORA_INICIO"].ToString().Substring(0,5);						
					txtUsuario.Text = conn.leer["USUARIOS_APROX"].ToString();	
					txtUnidad.Text = conn.leer["TIPO_UNIDAD"].ToString();	
					lblUnidadA.Text = conn.leer["UNIDADES_APROX"].ToString();
					txtOperador.Text = conn.leer["ID_OPERADOR"].ToString();
					
				}
				conn.conexion.Close();	
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			try{
				if(txtOperador.Text.Length > 0){
					consulta = @"SELECT Alias FROM OPERADOR WHERE ID = "+txtOperador.Text;
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						txtOperador.Text = conn.leer["Alias"].ToString();
					else
						txtOperador.Text = "";
					conn.conexion.Close();
				}
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			try{
				int contadorV = 0;
				dgPedidos.Rows.Clear();			
				consulta = @"SELECT U.*, O.ALIAS, C.TARJETA FROM UBER_TAXI_PEDIDO U JOIN CUENTAS_UBER_TAXI C ON C.ID = U.ID_CUENTA JOIN OPERADOR O ON O.ID = C.ID_USUARIO WHERE U.ESTATUS = 'Activo' and U.ID_PEDIDO = "+id_pedido;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgPedidos.Rows.Add(conn.leer["ID"].ToString(), 
					                   conn.leer["ID_CUENTA"].ToString(), 
					                   conn.leer["TIPO_UNIDAD"].ToString(),
					                   conn.leer["ALIAS"].ToString(),
					                   ((conn.leer["TARJETA"].ToString()=="SI")? "SI TIENE" : "NO TIENE"),
					                   conn.leer["USUARIOS"].ToString(),
					                   conn.leer["COSTO"].ToString(),
					                   conn.leer["FOLIO"].ToString());
					if(conn.leer["ESTADO"].ToString() == "VALIDADO"){
						for(int y=0; y<dgPedidos.Columns.Count; y++){
							dgPedidos[y,contadorV].Style.BackColor = Color.LightGreen;
						}
							dgPedidos[9,contadorV].Value = true;
					}					                        
					contadorV++;	
				}
				conn.conexion.Close();
				dgPedidos.ClearSelection();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			calculaVehiculosValidados();
		}
		
		private void cierreVehiculo(int index){
			if(dgPedidos[5, index].Value.ToString().Length > 0){
				if(dgPedidos[6, index].Value.ToString().Length > 0){
					if(dgPedidos[7, index].Value.ToString().Length > 0){
						if(connC.cierreVechiculo(dgPedidos[5, index].Value.ToString(), dgPedidos[6, index].Value.ToString(), dgPedidos[7, index].Value.ToString(), id_usuario, dgPedidos[0, index].Value.ToString())){
							MessageBox.Show("Se valido correctamente el vehículo", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							obtenerDatosM();
						}
					}else{
						MessageBox.Show("Ingresa el folio del vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}else{
					MessageBox.Show("Ingresa el costo del vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}else{
				MessageBox.Show("Ingresa los usuario del vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);					
				//DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgPedidos.Rows[index].Cells[9];
	            //chk.Selected = false;
			}
		}
		
		private void calculaVehiculosValidados(){
			bool respuesta = true;
			if(dgProgramados[6,dgProgramados.CurrentCell.RowIndex].Value.ToString() == "PEDIDO"){
				for(int x=0; x<dgPedidos.Rows.Count; x++){
					if(dgPedidos[2,x].Style.BackColor.Name != "LightGreen"){
						respuesta = false;
					}
				}
				if(dgProgramados.Rows.Count == 0)
					respuesta = false;
				if(respuesta){
					DialogResult resp = MessageBox.Show("Los vehículos de este servicio estan completamente validados ¿Deseas Cerrar el servicio?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if(resp == DialogResult.Yes){
						if(connC.cierreUT(id_usuario, id_pedido.ToString())){
						   	MessageBox.Show("El servicio de uber - taxi se cerro correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							filtros();
					   }else{
					   		MessageBox.Show("Error al cerrar el servicio de uber - taxi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					   }
					}	
				}
			}
		}
		
		private void limpiarAll(){
			id_ruta = null;
			cbMotivo.SelectedIndex = -1;
			txtOperador.Text = "";
			lblHoraPlaneacion.Text = "00:00";
			txtEmpresa.Text = "";
			txtRuta.Text = "";
			txtSentido.Text = "";
			dtpHoraArranque.Text = "00:00";
			txtUsuario.Text = "";
			txtUnidad.Text = "";
			
			cmbTipoUnidad.SelectedIndex = -1;
			txtResponsable.Text = "";
			cargaInformacion();
			privilegioCerrar(0);
			dgPedidos.Rows.Clear();
		}		
		#endregion
		
		#region EVENTOS
		void CbMotivoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbMotivo.SelectedIndex == 0 || cbMotivo.SelectedIndex == 1){
				btnProgramar.Enabled = true;
				btnPedido.Enabled = false;
				btnGuardar.Enabled = false;
				cmbTipoUnidad.SelectedIndex = -1;
				txtResponsable.Text = "";
			}else{
				btnProgramar.Enabled = false;
				btnPedido.Enabled = true;
				btnGuardar.Enabled = true;
			}
		}
		
		void TxtOperadorTextChanged(object sender, EventArgs e)
		{
			if(txtOperador.Text.Length == 0){
				txtOperador.BackColor = Color.White;
			}
			if(txtOperador.Text.Length > 0){
				id_operador = connC.validaUsuarioOperador(txtOperador.Text);
				if(id_operador > 0)
					txtOperador.BackColor = Color.LightGreen;
				else
					txtOperador.BackColor = Color.Red;
			}
		}
		
		void TxtResponsableTextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtResponsable.Text.Length == 0){
				txtResponsable.BackColor = Color.White;
			}
			if(txtResponsable.Text.Length > 0){
				id_responsable = connC.validaResponsable(txtResponsable.Text);
				if(id_responsable > 0)
					txtResponsable.BackColor = Color.LightGreen;
				else
					txtResponsable.BackColor = Color.Red;
			}				
		}
		
		void CmbTipoUnidadSelectedIndexChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}
		
		void DgProgramadosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				id_pedido = Convert.ToInt64(dgProgramados[0,e.RowIndex].Value);
				obtenerDatosM();
				privilegioCerrar(e.RowIndex);
			}
		}
		
		void DgPedidosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && e.ColumnIndex == 8){		
				if(dgPedidos[2, e.RowIndex].Style.BackColor.Name != "LightGreen"){
					if(dgPedidos[0, e.RowIndex].Value.ToString() != "0")
						new FormCancela(this, Convert.ToInt64(dgPedidos[0, e.RowIndex].Value), id_usuario, 0).ShowDialog();
					else
						dgPedidos.Rows.RemoveAt(e.RowIndex);
				}
			}
		}
		
		void DgPedidosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 9 && e.RowIndex > -1){
				if(dgPedidos[2, e.RowIndex].Style.BackColor.Name != "LightGreen"){
					if(dgPedidos[0, e.RowIndex].Value.ToString() != "0"){
	                	if (Convert.ToBoolean(dgPedidos.Rows[e.RowIndex].Cells[9].EditedFormattedValue) == true)
							cierreVehiculo(e.RowIndex);
					}
				}
			}	
		}
				
		void CbcanceladosCheckedChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void DgPedidosCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				if(e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 9){
					if(dgPedidos[0,e.RowIndex].Value.ToString() == "0"){
						dgPedidos[e.ColumnIndex,e.RowIndex].ReadOnly = true;
					}else{
						if(dgPedidos[2,e.RowIndex].Style.BackColor.Name == "LightGreen")
							dgPedidos[e.ColumnIndex,e.RowIndex].ReadOnly = true;	
						else
							dgPedidos[e.ColumnIndex,e.RowIndex].ReadOnly = false;
					}
				}
			}
		}
		
		void DgPedidosCellLeave(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				if(e.ColumnIndex == 5){
					if(dgPedidos[5,e.RowIndex].Value.ToString().Length > 0){
						try{ 
							Convert.ToInt32(dgPedidos[5,e.RowIndex].Value); 
						}catch{  
							MessageBox.Show("Ingresa un numero valido de usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
							dgPedidos[5,e.RowIndex].Value = "";
						}
					}else{
						dgPedidos[5,e.RowIndex].ReadOnly = true;
					}
				}
				if(e.ColumnIndex == 6){
					if(dgPedidos[6,e.RowIndex].Value.ToString().Length > 0){
						try{ 
							Convert.ToDouble(dgPedidos[6,e.RowIndex].Value); 
						}catch{  
							MessageBox.Show("Ingresa un costo valido 0.0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
							dgPedidos[6,e.RowIndex].Value = "";
						}
					}else{
						dgPedidos[6,e.RowIndex].ReadOnly = true;
					}
				}
				if(e.ColumnIndex == 7)
					dgPedidos[7,e.RowIndex].ReadOnly = true;
			}
				
		}
		
		void TxtBusquedaTextChanged(object sender, EventArgs e)
		{			
			filtros();
		}
		
		void CmbBusquedaSelectedIndexChanged(object sender, EventArgs e)
		{			
			filtros();
		}
		#endregion
		
		#region BOTONES
		void PbConfiguracionesClick(object sender, EventArgs e)
		{
			new FormConfiguracion(this, id_usuario).ShowDialog();
		}
		
		void BtnProgramarClick(object sender, EventArgs e)
		{
			if(validacion()){
				if(connC.insertarUberTaxi(id_ruta, id_operador.ToString(), id_usuario, txtUnidad.Text, cbMotivo.Text, fecha_despacho, turno, dtpHoraArranque.Text, txtUsuario.Text, lblUnidadA.Text, "PROGRAMADA", dgPedidos)){
					MessageBox.Show("Se Programo correctamente el uber o taxi", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);					
					limpiarAll();
				}else{
					MessageBox.Show("Error al Programar el uber o taxi", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
				}
			}
		}
		
		void BtnPedidoClick(object sender, EventArgs e)
		{
			if(validaResponsables()){
				dgPedidos.Rows.Add("0", id_responsable, cmbTipoUnidad.Text, txtResponsable.Text, ((connC.obtenerTarjeta(id_responsable) == "SI")? "SI TIENE" : "NO TIENE"), "", "", "");
				cmbTipoUnidad.SelectedIndex = -1;
				txtResponsable.Text = "";
				privilegioCerrar(0);
			}
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(id_pedido == 0){					
				if(validacionPedido()){
					if(connC.insertarUberTaxi(id_ruta, id_operador.ToString(), id_usuario, txtUnidad.Text, cbMotivo.Text, fecha_despacho, turno, dtpHoraArranque.Text, txtUsuario.Text, lblUnidadA.Text, "PEDIDO", dgPedidos)){
						enviarNotificaciones(cbMotivo.Text, txtRuta.Text, txtEmpresa.Text, turno, fecha_despacho, dtpHoraArranque.Value.ToString());
						MessageBox.Show("Se guardo correctamente el uber o taxi", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
						limpiarAll();
					}else{
						MessageBox.Show("Error al guardar el uber o taxi", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
					}
				}
			}else{		
				if(validacionPedido()){
					if(connC.modificarProgramacion(id_pedido.ToString(), id_operador.ToString(), id_usuario, cbMotivo.Text, "PEDIDO", dgPedidos)){
						enviarNotificaciones(cbMotivo.Text, txtRuta.Text, txtEmpresa.Text, turno, fecha_despacho, dtpHoraArranque.Value.ToString());
				    	MessageBox.Show("Se modifico correctamente el uber o taxi", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
				    	limpiarAll();
					}else{
						MessageBox.Show("Error al modificar el pedido del uber o taxi", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
					}
				}
			}
		}
		
		void LblLimpiarClick(object sender, EventArgs e)
		{
			limpiarAll();
		}
		#endregion	
		
		#region MENU
		void CancelarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgProgramados.SelectedRows.Count == 1)
				new FormCancela(this, Convert.ToInt64(dgProgramados[0, dgProgramados.CurrentCell.RowIndex].Value), id_usuario).ShowDialog();
		}
		#endregion		
		
		#region AVISO CORREO
		private void enviarNotificaciones(string motivo, string ruta, string empresa, string turno, string dia, string hora){
			string correoPara = connC.obtenerParametroEmail(4, 1);
			string correoPara2 = connC.obtenerParametroEmail(4, 2);
			string correoPara3 =  connC.obtenerParametroEmail(4, 3);
			string correoPara4 =  connC.obtenerParametroEmail(4, 4);
			
			 MailMessage mail = new MailMessage();
			 mail.From = new MailAddress("OPERACIONES@LAR.COM.MX");
		// Agregamos el destino del correo
			 mail.To.Add("LALO_00@LIVE.COM.MX");
			 
			 if(correoPara.Length > 5)
					mail.To.Add(correoPara);
			 if(correoPara2.Length > 5)
					mail.To.Add(correoPara2);
			 if(correoPara3.Length > 5)
					mail.To.Add(correoPara3);
			 if(correoPara4.Length > 5)
					mail.To.Add(correoPara4);
		// Titulo del correo	 
			 mail.Subject = "Ruta caida se mando servicio Uber-Taxi";

 		// Creamos la vista para clientes que sólo pueden acceder a texto plano.
			string text = "Motivo: "+motivo+" Ruta: "+ruta+" Empresa: "+empresa+" Turno: "+turno+" Día: "+dia+" Hora inicio: "+hora;
 			AlternateView plainView = AlternateView.CreateAlternateViewFromString(text, Encoding.UTF8, MediaTypeNames.Text.Plain);
	
		// Creamos la vista para clientes que pueden mostrar contenido HTML.
			string html = @"<h3>Motivo: "+motivo+"</h3> <br>" +
							"<h4>Ruta: "+ruta+" Empresa: "+ruta+" Turno: "+turno+"  Fecha: "+dia+" Hora Inicio: "+hora+" </h4> <br>" +
							"<br><hr /><img src='cid:imagen' />";
			 AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);

		// Creamos el recurso a incrustar. Observad que el ID que le asignamos (arbitrario) está referenciado desde el código HTML como origen
		// de la imagen (resaltado en amarillo).
			 LinkedResource img = new LinkedResource(@"../debug/LAR.jpg", MediaTypeNames.Image.Jpeg);
			 img.ContentId = "imagen";

 		// Lo incrustamos en la vista HTML.
			htmlView.LinkedResources.Add(img);

 		// Por último, vinculamos ambas vistas al mensaje.
			 mail.AlternateViews.Add(plainView);
			 mail.AlternateViews.Add(htmlView);

	 		SmtpClient smtpclient = new SmtpClient("mail.lar.com.mx");
			smtpclient.Port = 587;
			smtpclient.UseDefaultCredentials = false;
			smtpclient.Credentials = new System.Net.NetworkCredential("OPERACIONES@LAR.COM.MX", "LAR1249.5");
			smtpclient.EnableSsl = false;
	     	mail.Priority = MailPriority.High;
			try{
	     		smtpclient.Send(mail);
				MessageBox.Show("Mensaje enviado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
	     	}catch(Exception ex){
	     		MessageBox.Show("Mensaje no se envio : "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}		
		
		#endregion
		
		#region EVENTO CERRAR ESC
		void FormUber_TaxiKeyUp(object sender, KeyEventArgs e)
		{			
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
	}
}
