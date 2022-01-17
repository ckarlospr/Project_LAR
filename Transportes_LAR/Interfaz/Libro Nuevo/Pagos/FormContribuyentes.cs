using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormContribuyentes : Form
	{
		#region VARIABLES
		int tipo = 0;
		bool modificaciones = false;
		#endregion
		
		#region CONSTRUCTOR
		public FormContribuyentes(int tipoo)
		{
			InitializeComponent();
			tipo = tipoo;
		}		
		#endregion
		
		#region INSTANCIAS
		public FormLibroViajes refLibro = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region INICIO - FIN  
		void FormContribuyentesLoad(object sender, EventArgs e)
		{
			txtCliente.AutoCompleteCustomSource = autocomp.AutocompleteGeneral("select CLIENTE from DATOS_FACTURA", "CLIENTE");
           	txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;     
            
			this.txtCP.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			if(tipo == 1){
				cbTipo.SelectedIndex = 0;				
				cbEstado.Text = "JALISCO";
				this.Text = "DATOS CLIENTES";
				txtCliente.Visible = true;
				adaptador1();
			}
			
			if(tipo == 2){				
				this.Text = "DATOS CONSTRIBUYENTES";
				adaptador2();				
				cbEstado.Text = "JALISCO";
				cbTipo.Visible = false;
				//txtCliente.Visible = true;
			}
		}
		#endregion
		
		#region ADAPTADOR
		public void adaptador1(){
			ColoresAlternadosRows(dgDatos);
			string sentencia  = "select * from DATOS_FACTURA where ID  not in (select ID_DATOS_F from MAS_DATOS_FACTURACION where TIPO = 'CONTRIBUYENTE')";
			dgDatos.Rows.Clear();
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();			
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(),
			                      "",
			                      conn.leer["CLIENTE"].ToString(),
			                      conn.leer["RAZON_SOCIAL"].ToString(), 
			                      conn.leer["DOMICILIO"].ToString(), 
			                      "", 
								  "");
			}
			conn.conexion.Close();
			dgDatos.ClearSelection();
			masDatos1();
		}			
		
		void masDatos1(){
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				String conss = "select * from MAS_DATOS_FACTURACION where TIPO = 'CLIENTE' and ID_DATOS_F ="+dgDatos[0,x].Value.ToString();
				conn.getAbrirConexion(conss);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[1,x].Value = conn.leer["ID"].ToString();		
					dgDatos[5,x].Value = conn.leer["CORREO"].ToString();		
					dgDatos[6,x].Value = conn.leer["TELEFONO"].ToString();					
				}
				conn.conexion.Close();	
			}
			dgDatos.ClearSelection();			
		}
		
		public void adaptador2(){
			ColoresAlternadosRows(dgDatos);
			string sentencia  = @"select DF.ID, MDF.ID AS IDMAS, DF.CLIENTE, DF.RAZON_SOCIAL, DF.DOMICILIO, MDF.CORREO, MDF.TELEFONO from DATOS_FACTURA DF, 
									MAS_DATOS_FACTURACION MDF WHERE DF.ID = MDF.ID_DATOS_F AND TIPO = 'CONTRIBUYENTE'";
			dgDatos.Rows.Clear();
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();			
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(),
			                      conn.leer["IDMAS"].ToString(),
			                      "N/A",
			                      conn.leer["RAZON_SOCIAL"].ToString(), 
			                      conn.leer["DOMICILIO"].ToString(), 
			                      conn.leer["CORREO"].ToString(),
								  conn.leer["TELEFONO"].ToString());
			}
			conn.conexion.Close();
			dgDatos.ClearSelection();
		}		
		#endregion
		
		#region BOTONES
		void BtnGuardarClick(object sender, EventArgs e)
		{
			String CONSULT = "";
			int bandera = 0;	
			int ID_F = 0;
			if(modificaciones == false){
				if(tipo == 2){
					try{
						CONSULT = "insert into DATOS_FACTURA values ('"+txtCliente.Text+"', '"+txtRazonSocial.Text+"', '"+txtDomicilio.Text+"', '"+txtCP.Text+"','"+txtColinia.Text+"', '"+txtCiudad.Text+"', '"+txtRFC.Text+"');";
						conn.getAbrirConexion(CONSULT);
						bandera = 1;
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al insertar en DATOS_FACTURA "+ex.Message);
						if(conn.conexion != null)
							conn.conexion.Close();
					}
					
					if(bandera == 1){
						conn.getAbrirConexion("SELECT MAX(ID) ID FROM DATOS_FACTURA");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							ID_F=Convert.ToInt16(conn.leer["ID"]);
						}			
						conn.conexion.Close();				
						
						try{
							CONSULT = @"INSERT INTO MAS_DATOS_FACTURACION (ID_DATOS_F, TIPO, PERSONA, BANCO, CORREO, CUENTA, CLABE, ESTADO_DOMICILIO, TELEFONO)
										VALUES('"+ID_F+"', 'CONTRIBUYENTE', 'N/A', '"+txtBanco.Text+"', '"+txtCorreo.Text+"', '"+txtCuenta.Text+"', '"+txtClabe.Text+"', '"+cbEstado.Text+"', '"+txtTelefono.Text+"');";
							conn.getAbrirConexion(CONSULT);
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
						}catch(Exception ex){
							MessageBox.Show("Error al insertar en MAS_DATOS_FACTURACION "+ex.Message);
							if(conn.conexion != null)
								conn.conexion.Close();							
						}
					}
					limpiar();
					adaptador2();
				}
				
				if(tipo == 1){
					try{
						CONSULT = "insert into DATOS_FACTURA values ('"+txtCliente.Text+"', '"+txtRazonSocial.Text+"', '"+txtDomicilio.Text+"', '"+txtCP.Text+"','"+txtColinia.Text+"', '"+txtCiudad.Text+"', '"+txtRFC.Text+"');";
						conn.getAbrirConexion(CONSULT);
						bandera = 1;
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al insertar en DATOS_FACTURA "+ex.Message);
						if(conn.conexion != null)
							conn.conexion.Close();
					}
					
					if(bandera == 1){
						conn.getAbrirConexion("SELECT MAX(ID) ID FROM DATOS_FACTURA");
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							ID_F=Convert.ToInt16(conn.leer["ID"]);
						}			
						conn.conexion.Close();				
						
						try{
							CONSULT = @"INSERT INTO MAS_DATOS_FACTURACION (ID_DATOS_F, TIPO, PERSONA, BANCO, CORREO, CUENTA, CLABE, ESTADO_DOMICILIO, TELEFONO)
										VALUES('"+ID_F+"', 'CLIENTE', '"+cbTipo.Text+"', '"+txtBanco.Text+"', '"+txtCorreo.Text+"', '"+txtCuenta.Text+"', '"+txtClabe.Text+"', '"+cbEstado.Text+"', '"+txtTelefono.Text+"');";
							conn.getAbrirConexion(CONSULT);
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
						}catch(Exception ex){
							MessageBox.Show("Error al insertar en MAS_DATOS_FACTURACION "+ex.Message);	
							if(conn.conexion != null)
								conn.conexion.Close();	
						}
					}
					limpiar();
					adaptador1();
				}
			}
			
			if(modificaciones == true){
				if(tipo == 2){
					try{
						CONSULT = @"update DATOS_FACTURA set RAZON_SOCIAL='"+txtRazonSocial.Text+"', DOMICILIO='"+txtDomicilio.Text+"', CP='"+txtCP.Text+"', COLONIA='"+txtColinia.Text+"', CIUDAD='"+
							txtCiudad.Text+"', RFC='"+txtRFC.Text+"' CLIENTE = '"+txtCliente.Text+"' where ID="+ dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(CONSULT);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al modificar en DATOS_FACTURA "+ex.Message);
						if(conn.conexion != null)
							conn.conexion.Close();
					}
					
					try{
						CONSULT = @"UPDATE MAS_DATOS_FACTURACION SET PERSONA = '"+cbTipo.Text+"', BANCO = '"+txtBanco.Text+"', CORREO = '"+txtCorreo.Text+"', CUENTA = '"+txtCuenta.Text+
									"', CLABE = '"+txtClabe.Text+"', ESTADO_DOMICILIO = '"+cbEstado.Text+"', TELEFONO = '"+txtTelefono.Text+"' WHERE ID = "+ dgDatos[1,dgDatos.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(CONSULT);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al modificar en MAS_DATOS_FACTURACION "+ex.Message);
						if(conn.conexion != null)
							conn.conexion.Close();
					}
					modificaciones = false;					
					limpiar();
					adaptador2();
				}
				
				if(tipo == 1){
					try{
						CONSULT = @"update DATOS_FACTURA set RAZON_SOCIAL='"+txtRazonSocial.Text+"', DOMICILIO='"+txtDomicilio.Text+"', CP='"+txtCP.Text+"', COLONIA='"+txtColinia.Text+"', CIUDAD='"+
							txtCiudad.Text+"', RFC='"+txtRFC.Text+"', CLIENTE = '"+txtCliente.Text+"' where ID="+ dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(CONSULT);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al modificar en DATOS_FACTURA "+ex.Message);
						if(conn.conexion != null)
							conn.conexion.Close();
					}
					
					try{
						CONSULT = @"UPDATE MAS_DATOS_FACTURACION SET PERSONA = '"+cbTipo.Text+"', BANCO = '"+txtBanco.Text+"', CORREO = '"+txtCorreo.Text+"', CUENTA = '"+txtCuenta.Text+
									"', CLABE = '"+txtClabe.Text+"', ESTADO_DOMICILIO = '"+cbEstado.Text+"', TELEFONO = '"+txtTelefono.Text+"' WHERE ID = "+ dgDatos[1,dgDatos.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(CONSULT);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}catch(Exception ex){
						MessageBox.Show("Error al modificar en MAS_DATOS_FACTURACION "+ex.Message);
						if(conn.conexion != null)
							conn.conexion.Close();
					}
					modificaciones = false;					
					limpiar();
					adaptador1();
				}
			}
			
		}
		
		void LblLimpiarClick(object sender, EventArgs e)
		{
			limpiar();
			modificaciones = false;
		}
		#endregion
		
		#region EVENTOS DATAGRID
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){			
				limpiar();		
				try{	
					modificaciones = true;					
					obtenerDatos(Convert.ToInt32(dgDatos[0,dgDatos.CurrentRow.Index].Value));
					if(txtRazonSocial.Text == "")
						obtenerDatos2(Convert.ToInt32(dgDatos[0,dgDatos.CurrentRow.Index].Value));
						
					btnGuardar.Text = "Modificar";
				}catch(Exception ex){
					MessageBox.Show("Error: "+ex.Message);
				}		
			}
		}		
		#endregion
		
		#region METODOS
		public void limpiar(){
			btnGuardar.Text = "Guardar";
			txtRazonSocial.Text = "";
			txtRFC.Text = "";
			txtBanco.Text = "";
			txtCorreo.Text = "";
			cbTipo.Text = "FISICA";
			txtCuenta.Text = "";
			txtClabe.Text = "";
			txtDomicilio.Text = "";
			txtCP.Text = "";
			txtColinia.Text = "";
			txtCiudad.Text = "";
			cbEstado.Text = "JALISCO";
			txtTelefono.Text = "";
			txtCliente.Text = "";
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		
		public void obtenerDatos(Int32 idM){
			conn.getAbrirConexion(@"select DF.RAZON_SOCIAL, DF.RFC, MDF.BANCO, MDF.CORREO, MDF.CUENTA, MDF.CLABE, DF.CLIENTE, DF.DOMICILIO, DF.CP, DF.COLONIA, DF.CIUDAD, MDF.ESTADO_DOMICILIO,
									 MDF.TELEFONO, mdf.TIPO, mdf.PERSONA from DATOS_FACTURA DF, MAS_DATOS_FACTURACION MDF WHERE DF.ID = MDF.ID_DATOS_F and DF.ID = "+idM);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{						
					txtCliente.Text = conn.leer["CLIENTE"].ToString();	
					txtRazonSocial.Text = conn.leer["RAZON_SOCIAL"].ToString();
					txtRFC.Text = conn.leer["RFC"].ToString();
					txtBanco.Text = conn.leer["BANCO"].ToString();					
					txtCorreo.Text = conn.leer["CORREO"].ToString();
					cbTipo.Text = conn.leer["PERSONA"].ToString();
					txtCuenta.Text = conn.leer["CUENTA"].ToString();
					txtClabe.Text = conn.leer["CLABE"].ToString();
					txtDomicilio.Text = conn.leer["DOMICILIO"].ToString();
					txtCP.Text = conn.leer["CP"].ToString();
					txtColinia.Text = conn.leer["COLONIA"].ToString();
					txtCiudad.Text = conn.leer["CIUDAD"].ToString();
					cbEstado.Text = conn.leer["ESTADO_DOMICILIO"].ToString();
					txtTelefono.Text = conn.leer["TELEFONO"].ToString();			
				}else{
					txtRazonSocial.Text = "";
				}
				conn.conexion.Close();				
		}
		
		public void obtenerDatos2(Int32 idM){
			conn.getAbrirConexion(@"select ID, CLIENTE, RAZON_SOCIAL, DOMICILIO, CP, COLONIA, CIUDAD, RFC from DATOS_FACTURA WHERE ID = "+idM);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){						
					txtRazonSocial.Text = conn.leer["RAZON_SOCIAL"].ToString();
					txtRFC.Text = conn.leer["RFC"].ToString();
					txtDomicilio.Text = conn.leer["DOMICILIO"].ToString();
					txtCP.Text = conn.leer["CP"].ToString();
					txtColinia.Text = conn.leer["COLONIA"].ToString();
					txtCiudad.Text = conn.leer["CIUDAD"].ToString();
					txtCliente.Text = conn.leer["CLIENTE"].ToString();			
				}
				conn.conexion.Close();				
		}
		#endregion		
	}
}
