using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormPreciosF : Form
	{
		#region CONSTRUCTOR
		public FormPreciosF(FormPrincipal principal, int id_u)
		{
			InitializeComponent();
			refPrincipal = principal;
			id_usuario = id_u.ToString();
		}
		#endregion
						
		#region INSTANCIAS
		private FormPrincipal refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Facturacion.SQL_Facturacion connF = new Conexion_Servidor.Facturacion.SQL_Facturacion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region VARIABLES
		string id_usuario;
		//bool banderaValida = true;
		#endregion
		
		#region INICIO - FIN
		void FormPreciosFLoad(object sender, EventArgs e)
		{
			Inicio();
		}
		
		void FormPreciosFFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.preciosFacturacion = false;
		}
		#endregion
		
		#region METODOS
		public void filtros(){
			string consulta = "SELECT * FROM FACTURA_PRECIOS WHERE EMPRESA = '"+cmbEmpresa.Text+"' AND SENTIDO LIKE '%"+cmbSentidoBusqueda.Text
							+"%' AND VEHICULO LIKE '%"+cmbVehiculoBusqueda.Text+"%' AND TURNO LIKE '%"+cmbTurnoBusqueda.Text+"%' ";			
			if(cbEliminadas.Checked == false)
				consulta += " AND ESTATUS = 'Activo' ";		
			Adaptador(consulta);			
		}
		
		private void Adaptador(string consulta){
			int contador = 0;
			try{				
				ColoresAlternadosRows(dgPreciosRutas);
				dgPreciosRutas.Rows.Clear();	
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgPreciosRutas.Rows.Add(conn.leer["ID"].ToString(),
					                      		conn.leer["EMPRESA"].ToString(),
					                      		conn.leer["IDENTIFICADOR"].ToString(),
					                      		conn.leer["SENTIDO"].ToString(),
					                      		conn.leer["VEHICULO"].ToString(),
					                      		conn.leer["TIPO"].ToString(),
					                      		conn.leer["TURNO"].ToString(),
					                      		conn.leer["VELADA"].ToString(),
					                      		conn.leer["FORANEA"].ToString(),
					                      		conn.leer["PRECIO"].ToString(),
					                      		conn.leer["OBERVACIONES"].ToString());
					if(conn.leer["ESTATUS"].ToString() != "Activo"){
						for(int y=0; y<dgPreciosRutas.Columns.Count; y++)
							dgPreciosRutas[y,contador].Style.BackColor = Color.Red;
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
			dgPreciosRutas.ClearSelection();
		}
		
		private void Inicio(){
			string consulta = "Select Distinct(Empresa) As NombreEmpresa from Cliente where Empresa!='Especiales'";	
			
			this.txtIdentificador.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			this.txtImporte.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto2);
			this.txtAumento.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtdecremento.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
            
			txtIdentificador.AutoCompleteCustomSource = auto.AutocompleteGeneral(consulta, "NombreEmpresa");
           	txtIdentificador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIdentificador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			cmbEmpresa.Items.Clear();
			cmbEmpresa.Items.Add("");
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				cmbEmpresa.Items.Add(conn.leer["NombreEmpresa"].ToString());
			conn.conexion.Close();
		}
		
		public void Limpiar(){
			filtros();
			//txtIdentificador.Text = "";
			//cmbSentido.SelectedIndex = -1;
			//cmbVehiculo.SelectedIndex = -1;
			//cmbTipo.SelectedIndex = -1;
			//cmbTurno.SelectedIndex = -1;
			//cbVelada.Checked = false;
			//cbForanea.Checked = false;
			//txtImporte.Text = "";
			//txtObservaciones.Text = "";
			
			txtdecremento.Text = "";
			txtAumento.Text = "";
			dgPreciosRutas.ClearSelection();
			
			pnBusqueda.Enabled = true;
			btnInsertar.Enabled = true;
			btnCancelar.Enabled = false;
			btnModificar.Enabled = false;
		}
		
		public void LimpiarM(){
			txtIdentificador.Text = "";
			cmbSentido.SelectedIndex = 0;
			cmbVehiculo.SelectedIndex = 0;
			cmbTipo.SelectedIndex = 0;
			cmbTurno.SelectedIndex = 0;
			cbVelada.Checked = false;
			cbForanea.Checked = false;
			txtImporte.Text = "";
			txtObservaciones.Text = "";
			
			txtdecremento.Text = "";
			txtAumento.Text = "";
		}
		
		private bool validaPrecios(){
			bool respuesta = true;
			
			errorProvider1.Clear();
			if(cmbEmpresa.SelectedIndex == 0){
				errorProvider1.SetError(cmbEmpresa, "Selecciona la empresa");
				cmbEmpresa.Focus();
				respuesta = false;				
			}/*
			if(txtIdentificador.BackColor != Color.LightGreen){
				errorProvider1.SetError(txtIdentificador, "Ingresa un identificador valido");
				txtIdentificador.Focus();	
				respuesta = false;				
			}*/
			if(cmbSentido.SelectedIndex == -1){
				errorProvider1.SetError(cmbSentido, "Selecciona el sentido");
				cmbSentido.Focus();		
				respuesta = false;			
			}
			if(cmbVehiculo.SelectedIndex == -1){
				errorProvider1.SetError(cmbVehiculo, "Selecciona el tipo de vehiculo");
				cmbVehiculo.Focus();
				respuesta = false;				
			}
			if(txtImporte.Text.Length == 0){
				errorProvider1.SetError(txtImporte, "Ingresa el importe o costo del servicio");
				txtImporte.Focus();	
				respuesta = false;	
			}			
			return respuesta;
		}
				
		private void obtenerDatos(string ID_Datos){
			try{
				conn.getAbrirConexion("SELECT * FROM FACTURA_PRECIOS WHERE ID = "+ID_Datos);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){			
					txtIdentificador.Text = conn.leer["IDENTIFICADOR"].ToString();
					cmbSentido.Text = conn.leer["SENTIDO"].ToString();			
					cmbVehiculo.Text = conn.leer["VEHICULO"].ToString();			
					cmbTipo.Text = conn.leer["TIPO"].ToString();									
					cbVelada.Checked = ((conn.leer["VELADA"].ToString() == "SI")? true : false);
					cbForanea.Checked = ((conn.leer["FORANEA"].ToString() == "SI")? true : false);					
					txtImporte.Text = conn.leer["PRECIO"].ToString();
					cmbTurno.Text = conn.leer["TURNO"].ToString();
					txtObservaciones.Text = conn.leer["OBERVACIONES"].ToString();					
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				conn.conexion.Close();				
			}			
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		#endregion
		
		#region BOTONES		
		void BtnInsertarClick(object sender, EventArgs e)
		{    	
			bool respuesta = true;
			if(validaPrecios()){
				respuesta = connF.insertarPrecio(cmbEmpresa.Text, txtIdentificador.Text, cmbSentido.Text, cmbVehiculo.Text, cmbTipo.Text, 
				                                 ((cbVelada.Checked==true)?"SI":"NO"),  ((cbForanea.Checked==true)?"SI":"NO"), 
				                                 txtImporte.Text, cmbTurno.Text, txtObservaciones.Text);
				if(respuesta){
					MessageBox.Show("Se inserto correctamente el precio", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
					Limpiar();
				}else{
					MessageBox.Show("Error al insertar el precio", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
				}
			}
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{  	
			bool respuesta = true;
			
			if(dgPreciosRutas.SelectedRows.Count == 1){
				if(validaPrecios()){
					respuesta = connF.modificarPrecio(cmbEmpresa.Text, txtIdentificador.Text, cmbSentido.Text, cmbVehiculo.Text, cmbTipo.Text, 
					                                 ((cbVelada.Checked==true)?"SI":"NO"),  ((cbForanea.Checked==true)?"SI":"NO"), 
					                                 txtImporte.Text, cmbTurno.Text, txtObservaciones.Text, 
					                                 dgPreciosRutas[0, dgPreciosRutas.CurrentRow.Index].Value.ToString(), id_usuario);
					if(respuesta){
						MessageBox.Show("Se modifico correctamente el registro", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
						Limpiar();
					}else{
						MessageBox.Show("Error al modifico el precio", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
					}
				}
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Limpiar();
		}
		#endregion
		
		#region EVENTOS	
		void CmbSentidoBusquedaSelectedIndexChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void CmbVehiculoBusquedaSelectedIndexChanged(object sender, EventArgs e)
		{
			filtros();	
		}
		
		void CmbTurnoBusquedaSelectedIndexChanged(object sender, EventArgs e)
		{
			filtros();	
		}
		
		void CbEliminadasCheckedChanged(object sender, EventArgs e)
		{
			filtros();	
		}
		
		void CmbEmpresaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbEmpresa.SelectedIndex > 0)
				gbDatos.Enabled = true;
			else
				gbDatos.Enabled = false;
			
			filtros();
		}
		
		void TxtIdentificadorTextChanged(object sender, EventArgs e)
		{/*
			string sentencia = "SELECT * FROM FACTURA_PRECIOS WHERE EMPRESA = '"+cmbEmpresa.Text+"' AND IDENTIFICADOR = '"+txtIdentificador.Text+"'";
			if(txtIdentificador.Text.Length == 0){
				txtIdentificador.BackColor = Color.White;
			}
			if(banderaValida){
				if(txtIdentificador.Text.Length > 0){
					if(cmbEmpresa.SelectedIndex > 0){
						if(dgPreciosRutas.SelectedRows.Count == 1){
							sentencia = "SELECT * FROM FACTURA_PRECIOS WHERE EMPRESA = '"+cmbEmpresa.Text+"' AND IDENTIFICADOR = '"+txtIdentificador.Text
										+"' AND ID != "+dgPreciosRutas[0, dgPreciosRutas.CurrentRow.Index].Value;						
						}
						
						try{						
							conn.getAbrirConexion(sentencia);
							conn.leer = conn.comando.ExecuteReader();				
				            if(conn.leer.Read())
								txtIdentificador.BackColor = Color.Red;
				            else
								txtIdentificador.BackColor = Color.LightGreen;
							conn.conexion.Close();
						}catch(Exception){
							txtIdentificador.BackColor = Color.Red;			
						}finally{
							if(conn.conexion != null)
								conn.conexion.Close();
						}
					}
				}
			}*/
		}		
		
		void DgPreciosRutasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && e.ColumnIndex != 11 && dgPreciosRutas.SelectedRows.Count == 1){
				LimpiarM();	
				//banderaValida = false;
				obtenerDatos(dgPreciosRutas[0,e.RowIndex].Value.ToString());
				pnBusqueda.Enabled = false;
				btnCancelar.Enabled = true;
				btnModificar.Enabled = true;
				btnInsertar.Enabled = false;
				//banderaValida = true;
			}
			
			if(e.RowIndex > -1 && e.ColumnIndex == 11 && dgPreciosRutas.SelectedRows.Count == 1){
				DialogResult respuesta = MessageBox.Show("¿Deseas ELIMINAR el precio de esta empresa "+cmbEmpresa.Text+"? ", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(respuesta == DialogResult.Yes){
					if(connF.eliminaPrecio(dgPreciosRutas[0, dgPreciosRutas.CurrentRow.Index].Value.ToString(), id_usuario, 
					                       (( dgPreciosRutas[0, dgPreciosRutas.CurrentRow.Index].Style.BackColor.Name == "Red" )? 1 : 0) )){
						
						if(dgPreciosRutas[0, dgPreciosRutas.CurrentRow.Index].Style.BackColor.Name == "Red")
							MessageBox.Show("Se restauro correctamente el precio", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
						else							
							MessageBox.Show("Se elimino correctamente el precio", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
						Limpiar();
						filtros();
					}else{
						MessageBox.Show("Error al elimino el precio", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
					}
				}
			}
		}
		#endregion		
	}
}
