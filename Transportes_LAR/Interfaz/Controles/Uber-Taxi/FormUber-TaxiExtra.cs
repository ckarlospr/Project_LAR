using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	public partial class FormUber_TaxiExtra : Form
	{
		#region INSTANCIAS
		private FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Controles.SQL_Controles connC = new Conexion_Servidor.Controles.SQL_Controles();
		#endregion
				
		#region VARIABLES
		string id_usuario = "0";
		Int64 id_usuPedido;
		Int64 id_responsable;
		Int64 id_responsableAdaptador;
		#endregion
				
		#region CONSTRUCTOR
		public FormUber_TaxiExtra(FormPrincipal principal, int id_u)
		{
			InitializeComponent();
			refPrincipal = principal;
			id_usuario = id_u.ToString();
		}
		#endregion
		
		#region INICIO - FIN
		void FormUber_TaxiExtraLoad(object sender, EventArgs e)
		{			
			inicio();
		}
				
		void FormUber_TaxiExtraFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.ubertaxiExtra = false;
		}
		#endregion			
		
		#region METODOS
		private void inicio(){
			txtUsuario.Text = refPrincipal.lblDatoUsuario.Text;
			autoCompleta();		
			
			if(refPrincipal.lblDatoNivel.Text == "GERENCIAL" || refPrincipal.lblDatoNivel.Text  == "MASTER"){				
				pbConfiguraciones1.Visible = true;
				cbTodos.Enabled = true;
			}
			
			id_responsableAdaptador = connC.obtenerOperadorCuenta(id_responsable);
			filtros();
		}
		
		private void autoCompleta(){
			txtUsuario.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT Alias FROM OPERADOR WHERE TIPO_EMPLEADO  != 'OPERADOR' AND Estatus = '1'", "Alias");
           	txtUsuario.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtResponsable.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT O.Alias FROM OPERADOR O JOIN CUENTAS_UBER_TAXI CU ON CU.ID_USUARIO = O.ID WHERE O.Estatus = '1' AND CU.ESTATUS = 'Activo'", "Alias");
           	txtResponsable.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        
			txtItinerarioA.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT ITINERARIO_A FROM UBER_TAXI", "ITINERARIO_A");
           	txtItinerarioA.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtItinerarioA.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			txtItinerarioB.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT ITINERARIO_B FROM UBER_TAXI", "ITINERARIO_B");
           	txtItinerarioB.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtItinerarioB.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		private bool validaExtra(){
			bool respuesta = true;
			
			errorProvider1.Clear();
			if(txtMotivo.Text.Length == 0){
				errorProvider1.SetError(txtMotivo, "Ingresa un motivo");
				txtMotivo.Focus();
				respuesta = false;
			}
			
			if(txtUsuario.BackColor == Color.Red){
				errorProvider1.SetError(txtUsuario, "Ingresa un usuario valido");
				txtUsuario.Focus();
				respuesta = false;
			}
			
			if(txtResponsable.BackColor == Color.Red){
				errorProvider1.SetError(txtResponsable, "Ingresa un responsable valido");
				txtUsuario.Focus();
				respuesta = false;
			}
			
			if(cmbTipoUnidad.SelectedIndex == -1){
				errorProvider1.SetError(cmbTipoUnidad, "Selecciona el tipo de unidad para el pedido");
				cmbTipoUnidad.Focus();
				respuesta = false;
			}
			
			if(cmbTraslado.SelectedIndex == -1){
				errorProvider1.SetError(cmbTraslado, "Selecciona el traslado");
				cmbTraslado.Focus();
				respuesta = false;
			}			
			
			if(txtItinerarioA.Text.Length == 0){
				errorProvider1.SetError(txtItinerarioA, "Ingresa el punto A");
				txtItinerarioA.Focus();
				respuesta = false;
			}
			
			if(txtItinerarioB.Text.Length == 0){
				errorProvider1.SetError(txtItinerarioB, "Ingresa el punto B");
				txtItinerarioB.Focus();
				respuesta = false;
			}
			
			return respuesta;
		}
		
		private void limpiar(){
			errorProvider1.Clear();
			txtMotivo.Text = "";
			cmbTipoUnidad.SelectedIndex = -1;
			cmbTraslado.SelectedIndex = -1;
			dtpHoraPedido.Value = DateTime.Now;
			dtpFechaPedido.Value = DateTime.Now;
			txtItinerarioA.Text = "PUNTO A";
			txtItinerarioB.Text = "PUNTO B";			
		}
		
		#endregion
		
		#region BOTONES		
		void PbConfiguraciones1Click(object sender, EventArgs e)
		{
			new FormConfiguracion(this, id_usuario).ShowDialog();
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(validaExtra()){
				if(connC.insertarUberTaxiExtra(id_usuPedido.ToString(), id_usuario.ToString(), txtMotivo.Text, dtpFechaPedido.Value.ToString("yyyy-MM-dd"), 
				                               dtpHoraPedido.Value.ToString("HH:mm"), id_responsable.ToString(), cmbTipoUnidad.Text, cmbTraslado.Text, txtItinerarioA.Text, txtItinerarioB.Text)){
					MessageBox.Show("Se guardo correctamente el Uber-Taxi", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					limpiar();
					filtros();
				}else{
					MessageBox.Show("Error al guardar el uber o taxi", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
				}
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void TxtUsuarioTextChanged(object sender, EventArgs e)
		{
			if(txtUsuario.Text.Length == 0){
				txtUsuario.BackColor = Color.White;
			}
			if(txtUsuario.Text.Length > 0){
				id_usuPedido = connC.validaUsuarioAdministrativo(txtUsuario.Text);
				if(id_usuPedido > 0)
					txtUsuario.BackColor = Color.LightGreen;
				else
					txtUsuario.BackColor = Color.Red;
			}
			
			txtResponsable.Text = txtUsuario.Text;
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
				
		void TxtItinerarioAEnter(object sender, EventArgs e)
		{
			if(txtItinerarioA.Text == "PUNTO A")
				txtItinerarioA.Text = "";
		}
		
		void TxtItinerarioBEnter(object sender, EventArgs e)
		{			
			if(txtItinerarioB.Text == "PUNTO B")
				txtItinerarioB.Text = "";
		}
		
		void TxtItinerarioALeave(object sender, EventArgs e)
		{			
			if(txtItinerarioA.Text == "")
				txtItinerarioA.Text = "PUNTO A";
		}
		
		void TxtItinerarioBLeave(object sender, EventArgs e)
		{
			if(txtItinerarioB.Text == "")
				txtItinerarioB.Text = "PUNTO B";
		}
		#endregion
		
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//////////////////////////////////////////////////////// REPORTES /////////////////////////////////////////////////////////
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
		
		#region ADAPTADOR
		public void filtros(){
			string  Consulta = "";
			if(cbTodos.Checked == true){
				Consulta = @"select UT.ID ID_UT, UT.ID_OPERADOR, UT.MOTIVO, UT.FECHA_PLANEACION, UT.HORA_PANEACION, UT.ESTADO, UT.ESTATUS, UT.TIPO, UTP.ID ID_PEDIDO, UTP.TIPO_UNIDAD, 
							UTP.USUARIOS, UTP.COSTO, UTP.FOLIO, O.Alias from UBER_TAXI UT JOIN UBER_TAXI_PEDIDO UTP ON UTP.ID_PEDIDO = UT.ID JOIN CUENTAS_UBER_TAXI CUT 
							ON CUT.ID = UTP.ID_CUENTA JOIN OPERADOR O ON O.ID = CUT.ID_USUARIO where UT.TIPO = 'EXTRA' AND UT.ESTATUS = 'Activo' AND UT.FECHA_PLANEACION BETWEEN '"+
							dtpIncio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			}else{
				Consulta = @"select UT.ID ID_UT, UT.ID_OPERADOR, UT.MOTIVO, UT.FECHA_PLANEACION, UT.HORA_PANEACION, UT.ESTADO, UT.ESTATUS, UT.TIPO, UTP.ID ID_PEDIDO,  UTP.TIPO_UNIDAD, 
							UTP.USUARIOS, UTP.COSTO, UTP.FOLIO, O.Alias from UBER_TAXI UT JOIN UBER_TAXI_PEDIDO UTP ON UTP.ID_PEDIDO = UT.ID JOIN CUENTAS_UBER_TAXI CUT 
							ON CUT.ID = UTP.ID_CUENTA JOIN OPERADOR O ON O.ID = CUT.ID_USUARIO where UT.TIPO = 'EXTRA' AND UT.ESTATUS = 'Activo' AND UT.FECHA_PLANEACION BETWEEN '"+
							dtpIncio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' AND CUT.ID_USUARIO = "+id_responsableAdaptador;
			}			
			adaptador(Consulta);
		}
		
		private void adaptador(string Consulta){				
			int contador = 0;
			try{
				dgReporte.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgReporte.Rows.Add(conn.leer["ID_UT"].ToString(),
			                      		conn.leer["ID_PEDIDO"].ToString(),
			                      		conn.leer["ID_OPERADOR"].ToString(),
			                      		conn.leer["FOLIO"].ToString(),
			                      		conn.leer["MOTIVO"].ToString(),
			                      		conn.leer["FECHA_PLANEACION"].ToString().Substring(0,10),
			                      		"",//operador
			                      		conn.leer["TIPO"].ToString(),
			                      		conn.leer["Alias"].ToString(),
			                      		conn.leer["USUARIOS"].ToString(),
			                      		conn.leer["COSTO"].ToString(),
			                      		conn.leer["ESTADO"].ToString());
					if(conn.leer["ESTATUS"].ToString() == "INACTIVO"){
						for(int y=0; y<dgReporte.Columns.Count; y++)
							dgReporte[y,contador].Style.BackColor = Color.Red;
					}		                        
					contador++;	
				}
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los datos (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			completaDatos();
			dgReporte.ClearSelection();
		}
		
		private void completaDatos(){
			string consulta = "";
			
			for(int x=0; x<dgReporte.Rows.Count; x++){					
				try{
					consulta = @"SELECT Alias FROM OPERADOR WHERE ID = "+dgReporte[2,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						dgReporte[6,x].Value = conn.leer["Alias"].ToString();		
					conn.conexion.Close();
				}catch(Exception){					
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
				folio(x);
			}
		}
		private void folio(int x){			
			string folio = "E-";
			Int64 numero = 0;	
			string NuevoNumero = "";
			
			conn.getAbrirConexion("select FOLIO NUMERO from UBER_TAXI_PEDIDO where ID ="+dgReporte[1,x].Value.ToString());
			conn.leer = conn.comando.ExecuteReader();
			if(conn.leer.Read()){					
				try{ numero = Convert.ToInt32(conn.leer["NUMERO"]); }catch (Exception){ numero = 0; }
			}
			conn.conexion.Close();			
				
			if(numero == 0)
				NuevoNumero= "01";
			else if(numero.ToString().Length == 1)
				NuevoNumero = "000"+numero;
			else if(numero.ToString().Length == 2)
				NuevoNumero = "00"+numero;
			else if(numero.ToString().Length == 3)
				NuevoNumero = "0"+numero;
			else
				NuevoNumero	= numero.ToString();
			
			dgReporte[3,x].Value = folio += NuevoNumero;	
				
		}
		#endregion		
		
		#region EVENTOS
		void DtpIncioValueChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void CbTodosCheckedChanged(object sender, EventArgs e)
		{
			filtros();
		}
		#endregion
		
		#region CIERRE
		void DgReporteCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && dgReporte.SelectedRows.Count == 1){
				new FormCierreUTextra(this, id_usuario, dgReporte[0,e.RowIndex].Value.ToString(), dgReporte[1,e.RowIndex].Value.ToString(), dgReporte[3,e.RowIndex].Value.ToString()).ShowDialog();
			}
		}
		#endregion
	}
}
