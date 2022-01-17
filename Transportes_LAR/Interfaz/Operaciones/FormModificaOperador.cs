using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormModificaOperador : Form
	{		
		#region CONSTRUCTOR
		public FormModificaOperador(FormOperacionesOperador refprincipal, string id_opera, string id_usu)
		{
			InitializeComponent();
			refOperador = refprincipal;
			ID_operador = id_opera;
			ID_usuario = id_usu;
		}		
		#endregion
		
		#region INSTANCIAS		
		System.IO.MemoryStream ms = null;
		private FormOperacionesOperador refOperador;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		string ID_operador = "0";
		string ID_usuario = "0";
		#endregion
		
		#region INICIO - FIN
		void FormModificaOperadorLoad(object sender, EventArgs e)
		{
			ValidacionCampos();
			ObtenerDatos();
			if(txtCorreo.Text.Length == 0)
				txtCorreo.Enabled = true;
			if(txtApellidoMat.Text.Length == 0)
				txtApellidoMat.Enabled = true;
			if(txtApellidoPat.Text.Length == 0)
				txtApellidoPat.Enabled = true;
			if(txtNombre.Text.Length == 0)
				txtNombre.Enabled = true;
		}
		
		void FormModificaOperadorFormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
		#endregion
		
		#region METODOS
		public void ObtenerDatos(){
			string consulta;
			if(ID_operador != "0"){
				try{
					ptbImagen.Image = System.Drawing.Image.FromFile(@"../debug/Nomina.jpg");
					
					consulta = "select * from OPERADOR where ID = "+ID_operador;
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){						
						groupBox1.Text = conn.leer["Alias"].ToString();
						txtNombre.Text = conn.leer["Nombre"].ToString();
						txtApellidoPat.Text = conn.leer["Apellido_Pat"].ToString();
						txtApellidoMat.Text = conn.leer["Apellido_Mat"].ToString();
						txtCorreo.Text = conn.leer["CORREO"].ToString();
						cbForaneo.Checked = ((conn.leer["foraneo"].ToString().Equals("1"))? true: false);
						
						byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
			  			ms = new System.IO.MemoryStream(imageBuffer);
			  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);	

						txtCalle.Text = conn.leer["Calle"].ToString();
						txtColonia.Text = conn.leer["Colonia"].ToString();	
						txtMunicipio.Text = conn.leer["Municipio"].ToString();
						txtEstado.Text = conn.leer["Estado"].ToString();
						txtReferencia1.Text = conn.leer["Referencia_Calle_Uno"].ToString();
						txtReferencia2.Text = conn.leer["Referencia_Calle_Dos"].ToString();	
						txtNumExterior.Text = conn.leer["Num_Exterior"].ToString();	
						txtNumInterior.Text = conn.leer["Num_Interior"].ToString();
						txtCP.Text = conn.leer["CP"].ToString();						
					}
					conn.conexion.Close();
					
					cargaTelefono();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener datos del operador (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}		
		}
		
		private void ValidacionCampos(){
			txtNombre.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			txtApellidoPat.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			txtApellidoMat.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);			
			txtCP.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);			
			txtNumero.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		private void limpiaTelefonos(){
			cmbTipo.SelectedIndex = -1 ;
			txtNumero.Text = "";
			txtDescripcion.Text = "";
			btnAgregarTelefono.Text = "Agregar";
			cargaTelefono();
		}
		
		private void cargaTelefono(){
			try{
				dataTelefono.Rows.Clear();
				string consulta = "select * from TELEFONOCHOFER where ID_Chofer = "+ID_operador;
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
					dataTelefono.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Tipo"].ToString(), conn.leer["Numero"].ToString(), conn.leer["Descripcion"].ToString());				
				conn.conexion.Close();
				dataTelefono.ClearSelection();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener datos del operador (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
		}
			
		private bool agregaTelefono(){
			bool respuesta = true;
			string consulta = "insert into TELEFONOCHOFER (Tipo, Numero, Descripcion, ID_Chofer) values ('"+cmbTipo.Text+"', '"+txtNumero.Text+"', '"+txtDescripcion.Text+"', '"+ID_operador+"' )";
			try{
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				respuesta = true;
			}catch(Exception ex){
				MessageBox.Show("Error al agregar el teléfono del operador error: "+ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			if(respuesta){				
				string id = "0";
				conn.getAbrirConexion("select MAX(ID) ID From TELEFONOCHOFER");
				conn.leer= conn.comando.ExecuteReader();
				if(conn.leer.Read())
					id = conn.leer["ID"].ToString();
				conn.conexion.Close();			
			
				consulta = "INSERT INTO AUDITORIA_GENERAL  VALUES('INSERT', 'AGREGÓ EL TELÉFONO ID: "+id+" OPERADOR ID: "+ID_operador+
				             "' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+ID_usuario+", 'OPERADOR - DESPACHO')";
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();	
			}
			return respuesta;
		}
		
		private bool modificaTelefono(string idTelefono){
			bool respuesta = true;
			string consulta = "UPDATE TELEFONOCHOFER SET Tipo = '"+cmbTipo.Text+"', Numero = '"+txtNumero.Text+"', Descripcion = '"+txtDescripcion.Text+"' WHERE ID = "+idTelefono;
			try{
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				respuesta = true;
			}catch(Exception ex){
				MessageBox.Show("Error al modificar el teléfono del operador error: "+ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			if(respuesta){
				consulta = "INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'ACTUALIZO EL TELÉFONO (ID: "+dataTelefono[0, dataTelefono.CurrentRow.Index].Value.ToString()
				                      +", TIPO: "+dataTelefono[1, dataTelefono.CurrentRow.Index].Value.ToString()+", NUMERO: "+dataTelefono[2, dataTelefono.CurrentRow.Index].Value.ToString()
				                      +", DESCRIPCIÓN: "+dataTelefono[3, dataTelefono.CurrentRow.Index].Value.ToString()+") OPERADOR ID: "+ID_operador+
				                      " ' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+ID_usuario+", 'OPERADOR - DESPACHO')";
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();	
			}
			return respuesta;
		}
		 
		private bool eliminaTelefono(string idTelefono){
			bool respuesta = true;
			string consulta = "delete from TELEFONOCHOFER where id="+idTelefono;
			try{
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				respuesta = true;
			}catch(Exception ex){
				MessageBox.Show("Error al eliminar el teléfono del operador error: "+ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
				respuesta = false;
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			if(respuesta){
				consulta = "INSERT INTO AUDITORIA_GENERAL  VALUES('DELETE', 'ELIMINÓ TELÉFONO (ID: "+dataTelefono[0, dataTelefono.CurrentRow.Index].Value.ToString()
				                      +" TIPO: "+dataTelefono[1, dataTelefono.CurrentRow.Index].Value.ToString()+" NUMERO: "+dataTelefono[2, dataTelefono.CurrentRow.Index].Value.ToString()
				                      +" DESCRIPCIÓN: "+dataTelefono[3, dataTelefono.CurrentRow.Index].Value.ToString()+") OPERADOR ID: "+ID_operador+
				                      " ' ,(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+ID_usuario+", 'OPERADOR - DESPACHO')";
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();	
			}
			return respuesta;
		}
				
		private bool modificaOperador(){
			bool respuesta = true;			
			string nombreOLD = "", ApOLD = "", AMOLD = "", correoOLD = "", tipoOLD = "", calleOLD = "", coloniaOLD = "", municipioOLD = "", estadoOLD = "", cruza1OLD = "", cruza2LD = "", numELD = "", NumIOLD = "", cpOLD = "";
			
			try{
				conn.getAbrirConexion("select * from OPERADOR where ID = "+ID_operador);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					nombreOLD = conn.leer["Nombre"].ToString();
					ApOLD = conn.leer["Apellido_Pat"].ToString();
					AMOLD = conn.leer["Apellido_Mat"].ToString();
					correoOLD = conn.leer["CORREO"].ToString();
					tipoOLD = ((conn.leer["foraneo"].ToString().Equals("1"))? "1": "0");				
					calleOLD = conn.leer["Calle"].ToString();
					coloniaOLD = conn.leer["Colonia"].ToString();	
					municipioOLD = conn.leer["Municipio"].ToString();
					estadoOLD = conn.leer["Estado"].ToString();
					cruza1OLD = conn.leer["Referencia_Calle_Uno"].ToString();
					cruza2LD = conn.leer["Referencia_Calle_Dos"].ToString();	
					numELD = conn.leer["Num_Exterior"].ToString();	
					NumIOLD = conn.leer["Num_Interior"].ToString();
					cpOLD = conn.leer["CP"].ToString();
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'ACTUALIZÓ DATOS DEL OPERADOR ID: "+ID_operador+" NOMBRE: "+nombreOLD+", AP: "+ApOLD+", AM: "+AMOLD+", CORREO: "+correoOLD
				                      +", TIPO: "+tipoOLD+", CALLE: "+calleOLD+", COLONIA: "+coloniaOLD+", MUNICIPIO; "+municipioOLD+", ESTADO = "+estadoOLD+", CRUZA 1: "+cruza1OLD+", CRUZA 2: "+cruza2LD
				                      +", NUMERO INT: "+NumIOLD+", NUMERO EXT: "+numELD+", CP: "+cpOLD+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+ID_usuario+", 'OPERADOR - DESPACHO')");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();	
				respuesta = true;
			}catch(Exception){
				respuesta = false;
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			
			if(respuesta){
				string consulta = @"UPDATE OPERADOR SET Nombre = '"+txtNombre.Text+"', Apellido_Pat = '"+txtApellidoPat.Text+"', Apellido_Mat = '"+txtApellidoMat.Text+"', CORREO = '"+txtCorreo.Text
									+"', foraneo = '"+((cbForaneo.Checked == true)? "1": "0")+"', Calle = '"+txtCalle.Text+"', Colonia = '"+txtColonia.Text+"', Municipio = '"+txtMunicipio.Text
									+"', Estado = '"+txtEstado.Text+"', Referencia_Calle_Uno = '"+txtReferencia1.Text+"', Referencia_Calle_Dos = '"+txtReferencia2.Text+"', Num_Exterior = '"+txtNumExterior.Text
									+"' , Num_Interior = '"+txtNumInterior.Text+"' , CP = '"+txtCP.Text+"' WHERE ID = "+ID_operador;
				try{
					conn.getAbrirConexion(consulta);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					respuesta = true;
				}catch(Exception ex){
					MessageBox.Show("Error al modificar datos del operador error: "+ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
					respuesta = false;
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}				
			return respuesta;
		}
		
		private bool validaTelefono(){
			bool respuesta = true;
			
			if(cmbTipo.SelectedIndex == -1){
				MessageBox.Show("Ingresa el tipo de teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				respuesta = false;
			}
			if(txtNumero.Text.Length == 0){
				MessageBox.Show("Ingresa el numero de teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				respuesta = false;
			}			
			return respuesta;
		}
		#endregion
	
		#region BOTONES
		void BtnAgregarClick(object sender, EventArgs e)
		{
			DialogResult rs = MessageBox.Show("¿Desea modificar los datos del operador?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (DialogResult.Yes==rs){
				if(modificaOperador()){
					MessageBox.Show("Se modificó correctamente el operador", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
				
		void LblLimpiarClick(object sender, EventArgs e)
		{
			limpiaTelefonos();
		}
				
		void BtnAgregarTelefonoClick(object sender, EventArgs e)
		{
			if(validaTelefono()){
				if(btnAgregarTelefono.Text == "Modificar" && dataTelefono.SelectedRows.Count == 1){				
					DialogResult rs = MessageBox.Show("¿Desea modificar el teléfono?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs){
						if(modificaTelefono(dataTelefono[0, dataTelefono.CurrentRow.Index].Value.ToString())){
							MessageBox.Show("Se modificó correctamente el teléfono", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							limpiaTelefonos();
						}
					}
				}else{				
					if(agregaTelefono()){
						MessageBox.Show("Se agregó correctamente el teléfono", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						limpiaTelefonos();
					}
				}
			}
		}
		
		void BtnRemoverTelefonoClick(object sender, EventArgs e)
		{
			if(btnAgregarTelefono.Text == "Modificar" && dataTelefono.SelectedRows.Count == 1){				
				DialogResult rs = MessageBox.Show("¿Desea Eliminar el teléfono  permanentemente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs){
					if(eliminaTelefono(dataTelefono[0, dataTelefono.CurrentRow.Index].Value.ToString())){
						MessageBox.Show("Se Eliminó correctamente el teléfono", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						limpiaTelefonos();
					}
				}
			}else{				
				MessageBox.Show("Selecciona un teléfono a eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		#endregion	
		
		#region EVENTOS
		void DataTelefonoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && dataTelefono.SelectedRows.Count == 1){
				cmbTipo.Text = dataTelefono[1, e.RowIndex].Value.ToString();
				txtNumero.Text = dataTelefono[2, e.RowIndex].Value.ToString();
				txtDescripcion.Text = dataTelefono[3, e.RowIndex].Value.ToString();
				btnAgregarTelefono.Text = "Modificar";
			}
		}
		#endregion
	}
}
