using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	public partial class FormConfiguracion : Form
	{
		#region INSTANCIAS
		private FormUber_Taxi formUT = null;
		private FormUber_TaxiExtra formUTE = null;
		private Conexion_Servidor.Controles.SQL_Controles connC = new Conexion_Servidor.Controles.SQL_Controles();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region VARIABLES
		string idUsuario;
		string idResponsable;
		bool respuesta = false;
		Int64 id_usuV;
		#endregion
		
		#region CONSTRUCTOR
		public FormConfiguracion(FormUber_Taxi refUT, string id_usu)
		{
			InitializeComponent();
			this.formUT = refUT;
			this.idUsuario = id_usu;
		}
		
		public FormConfiguracion(FormUber_TaxiExtra refUT, string id_usu)
		{
			InitializeComponent();
			this.formUTE = refUT;
			this.idUsuario = id_usu;
		}
		#endregion
		
		#region INICIO - FIN
		void FormConfiguracionLoad(object sender, EventArgs e)
		{
			cargaInicio();
		}
		
		void FormConfiguracionFormClosing(object sender, FormClosingEventArgs e)
		{
			if(formUTE == null){
				if(respuesta){
					formUT.txtResponsable.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT O.Alias FROM OPERADOR O JOIN CUENTAS_UBER_TAXI CU ON CU.ID_USUARIO = O.ID WHERE O.Estatus = '1' AND CU.ESTATUS = 'Activo'", "Alias");
		           	formUT.txtResponsable.AutoCompleteMode = AutoCompleteMode.Suggest;
		            formUT.txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;            
				}
			}else{
				if(formUT == null){
					if(respuesta){
						formUTE.txtResponsable.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT O.Alias FROM OPERADOR O JOIN CUENTAS_UBER_TAXI CU ON CU.ID_USUARIO = O.ID WHERE O.Estatus = '1' AND CU.ESTATUS = 'Activo'", "Alias");
			           	formUTE.txtResponsable.AutoCompleteMode = AutoCompleteMode.Suggest;
			            formUTE.txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;            
					}
				}
			}
		}
		#endregion
		
		#region METODOS
		private void cargaInicio(){
			txtOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT Alias FROM OPERADOR WHERE TIPO_EMPLEADO NOT IN ('OPERADOR') AND Estatus = '1'", "Alias");
           	txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            this.txtNumero.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
            
            cmbTipo.SelectedIndex = 0; 

            adaptador();
		}
		
		private void adaptador(){		
			///////////////////////////////////////////////////// CUENTAS UBER - TAXI /////////////////////////////////////////////////////			
			string  Consulta = "SELECT CUB.*, O.Alias FROM CUENTAS_UBER_TAXI CUB JOIN OPERADOR O ON O.ID = CUB.ID_USUARIO WHERE CUB.ESTATUS = 'Activo'";	
			try{
				dgUsuarios.Rows.Clear();	
				conn.getAbrirConexion(Consulta);
				conn.leer = conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgUsuarios.Rows.Add(conn.leer["ID"].ToString(),
					                      		conn.leer["Alias"].ToString(),
					                      		((conn.leer["TARJETA"].ToString()=="SI")? conn.leer["NUMERO_TARJETA"].ToString() : "N/A"),
					                      		((conn.leer["TARJETA"].ToString()=="SI")? conn.leer["TIPO_TARJETA"].ToString() : "N/A"));
				}
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error al obtener las cuentas (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			dgUsuarios.ClearSelection();
			
			////////////////////////////////////////////////////////// CORREOS  /////////////////////////////////////////////////////////			
			try{		
				string sentencia = "select PARAMETRO1, PARAMETRO2, PARAMETRO3, PARAMETRO4, PARAMETRO5, PARAMETRO6 from PARAMETROS_GENERALES where id = 4";
				conn.getAbrirConexion(sentencia);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(!(string.IsNullOrEmpty(conn.leer["PARAMETRO1"].ToString())))
						txtCorreo1.Text = conn.leer["PARAMETRO1"].ToString();
					if(!(string.IsNullOrEmpty(conn.leer["PARAMETRO2"].ToString())))
						txtCorreo2.Text = conn.leer["PARAMETRO2"].ToString();
					if(!(string.IsNullOrEmpty(conn.leer["PARAMETRO3"].ToString())))
						txtCorreo3.Text = conn.leer["PARAMETRO3"].ToString();
					if(!(string.IsNullOrEmpty(conn.leer["PARAMETRO4"].ToString())))
						txtCorreo4.Text = conn.leer["PARAMETRO4"].ToString();
					if(!(string.IsNullOrEmpty(conn.leer["PARAMETRO6"].ToString())))
						txtTiempo.Text = conn.leer["PARAMETRO6"].ToString();		
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
			
		}
		
		private void limpiar(){					
			txtOperador.Enabled = true;
			btnAgregar.Text = "Agregar";
			lblLimpiar.Enabled = false;
			txtOperador.Text = "";
			txtOperador.BackColor = Color.White;
			txtNumero.Text = "";
			cmbTarjeta.SelectedIndex = -1;
			cmbTipo.SelectedIndex = 0;
		}
		
		private bool validaCorreos(){
			bool respuesta = true;
			if(txtCorreo1.BackColor == Color.Red){
				errorProvider1.SetError(txtCorreo1, "Ingresa un correo corecto");
				respuesta = false;
			}			
			if(txtCorreo2.BackColor == Color.Red){
				errorProvider1.SetError(txtCorreo2, "Ingresa un correo corecto");
				respuesta = false;
			}
			if(txtCorreo3.BackColor == Color.Red){
				errorProvider1.SetError(txtCorreo3, "Ingresa un correo corecto");
				respuesta = false;
			}
			if(txtCorreo4.BackColor == Color.Red){
				errorProvider1.SetError(txtCorreo4, "Ingresa un correo corecto");
				respuesta = false;
			}
			return respuesta;
		}
		#endregion
		
		#region BOTONES
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(txtOperador.BackColor.Name == "LightGreen"){
				if(cmbTarjeta.SelectedIndex > -1){
					if(btnAgregar.Text == "Agregar"){
						respuesta = connC.insertarCuentaUT(id_usuV.ToString(), cmbTarjeta.Text, txtNumero.Text, cmbTipo.Text);
						if(respuesta){
							MessageBox.Show("Se inserto correctamente la cuenta", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
							limpiar();
						}else{
							MessageBox.Show("Error al insertar la cuenta", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
						}
            			adaptador();
					}else{
						respuesta = connC.modificarCuentaUT(cmbTarjeta.Text, txtNumero.Text, cmbTipo.Text, idResponsable);
						if(respuesta){
							MessageBox.Show("Se modifico correctamente la cuenta", "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);
							limpiar();
						}else{
							MessageBox.Show("Error al modificar la cuenta", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
						}
            			adaptador();
					}
				}else{
					MessageBox.Show("Seleccione si el usuario cuenta con tarjeta", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}else{
				MessageBox.Show("Inserta un usuario valido", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}
		
		void LblLimpiarClick(object sender, EventArgs e)
		{	
			limpiar();
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			try{
				if(validaCorreos()){
					connC.modificarParametrosCorreo(txtCorreo1.Text, txtCorreo2.Text, txtCorreo3.Text, txtCorreo4.Text, txtTiempo.Text, 4);
					MessageBox.Show("Se guardaron Parámetros", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}catch(Exception ex){
				MessageBox.Show("Error al guardar Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);			
			}
		}
		#endregion

		#region EVENTOS
		void TxtOperadorTextChanged(object sender, EventArgs e)
		{
			if(txtOperador.Text.Length == 0){
				txtOperador.BackColor = Color.White;
			}
			if(txtOperador.Text.Length > 0){
				id_usuV = connC.validaUsuarioOperador(txtOperador.Text);
				if(id_usuV > 0)
					txtOperador.BackColor = Color.LightGreen;
				else
					txtOperador.BackColor = Color.Red;
			}
		}
			
		void CmbTarjetaSelectedIndexChanged(object sender, EventArgs e)
		{
			btnAgregar.Enabled = true;
			if(cmbTarjeta.SelectedIndex == 0){
				cmbTipo.Enabled = true;
				txtNumero.Enabled = true;
			}else{
				cmbTipo.Enabled = false;
				txtNumero.Enabled = false;
			}
		}
		
		void DgUsuariosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				idResponsable = dgUsuarios[0,e.RowIndex].Value.ToString();
				try{
					conn.getAbrirConexion("select * from CUENTAS_UBER_TAXI where ID = "+idResponsable);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){						
						txtOperador.Text = dgUsuarios[1,e.RowIndex].Value.ToString();
						cmbTarjeta.Text = conn.leer["TARJETA"].ToString();	
						txtNumero.Text = conn.leer["NUMERO_TARJETA"].ToString();	
						cmbTipo.Text = conn.leer["TIPO_TARJETA"].ToString();
					}
					conn.conexion.Close();
					txtOperador.Enabled = false;
					btnAgregar.Text = "Guardar";
					lblLimpiar.Enabled = true;
				}catch(Exception){
					MessageBox.Show("Error al obtener datos (error al llenar los campos)", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}
		}
		
		void TxtCorreo1TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtCorreo1.Text.Length > 0){
				if(Proceso.ValidarCampo.email_bien_escrito(txtCorreo1.Text)){
					txtCorreo1.BackColor = Color.LightGreen;
				}else{
					errorProvider1.SetError(txtCorreo1, "Ingresa un correo corecto");
					txtCorreo1.BackColor = Color.Red;
				}
			}else{
				txtCorreo1.BackColor = Color.White;
			}				
		}
		
		void TxtCorreo2TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtCorreo2.Text.Length > 0){
				if(Proceso.ValidarCampo.email_bien_escrito(txtCorreo2.Text)){
					txtCorreo2.BackColor = Color.LightGreen;
				}else{
					errorProvider1.SetError(txtCorreo2, "Ingresa un correo corecto");
					txtCorreo2.BackColor = Color.Red;
				}
			}else{
				txtCorreo2.BackColor = Color.White;
			}
		}
		
		void TxtCorreo3TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtCorreo3.Text.Length > 0){
				if(Proceso.ValidarCampo.email_bien_escrito(txtCorreo3.Text)){
					txtCorreo3.BackColor = Color.LightGreen;
				}else{
					errorProvider1.SetError(txtCorreo3, "Ingresa un correo corecto");
					txtCorreo3.BackColor = Color.Red;
				}
			}else{
				txtCorreo3.BackColor = Color.White;
			}
		}
		
		void TxtCorreo4TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtCorreo4.Text.Length > 0){
				if(Proceso.ValidarCampo.email_bien_escrito(txtCorreo4.Text)){
					txtCorreo4.BackColor = Color.LightGreen;
				}else{
					errorProvider1.SetError(txtCorreo4, "Ingresa un correo corecto");
					txtCorreo4.BackColor = Color.Red;
				}
			}else{
				txtCorreo4.BackColor = Color.White;
			}
		}
		
		void TxtTiempoTextChanged(object sender, EventArgs e)
		{
			if(txtTiempo.Text.Length == 0){
				txtTiempo.Text = "0";
			}
		}
		
		void FormConfiguracionKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion				
	}
}
