using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	public partial class FormModificaOperador : Form
	{
		#region CONSTRUCTOR
		public FormModificaOperador(FormNominaFiscal refnominaF, string id_opera, string id_cuent, string id_sueld, string id_usu)
		{
			InitializeComponent();
			nominaFiscal = refnominaF;
			ID_operador = id_opera;
		 	ID_cuenta = id_cuent;
			ID_sueldo = id_sueld;
			ID_usuario = id_usu;
		}		
		#endregion
		
		#region INSTANCIAS		
		System.IO.MemoryStream ms = null;
		private FormNominaFiscal nominaFiscal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Cuenta.SQL_Cuenta conC = new Conexion_Servidor.Cuenta.SQL_Cuenta();
		#endregion
		
		#region VARIABLES
		string ID_operador = "0";
		string ID_cuenta = "0";
		string ID_sueldo = "0";
		string ID_usuario = "0";
		#endregion
		
		#region INICIO - FIN
		void FormModificaOperadorLoad(object sender, EventArgs e)
		{
			ValidacionCampos();
			ObtenerDatos();
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
						txtCurp.Text = conn.leer["CURP"].ToString();
						txtRFC.Text = conn.leer["RFC"].ToString();
						txtNSS.Text = conn.leer["IMSS"].ToString();
						txtNumInfonavit.Text = conn.leer["NUM_INFONAVIT"].ToString();
						txtCorreo.Text = conn.leer["CORREO"].ToString();
												
						txtLugarNacimiento.Text = conn.leer["Lugar_Nacimiento"].ToString();
						txtEstadoNacimiento.Text = conn.leer["Estado_Nacimiento"].ToString();						
						txtMunicipioNacimiento.Text = conn.leer["Municipio_Nacimiento"].ToString();
						dateFechaNacimiento.Text = conn.leer["Fecha_Nacimiento"].ToString();
						dateFechaNacimiento.Value = new DateTime (Convert.ToInt32((conn.leer["Fecha_Nacimiento"].ToString()).Substring(6,4)),
            	                                      Convert.ToInt32((conn.leer["Fecha_Nacimiento"].ToString()).Substring(3,2)),
            	                                      Convert.ToInt32((conn.leer["Fecha_Nacimiento"].ToString()).Substring(0,2)));

						byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
			  			ms = new System.IO.MemoryStream(imageBuffer);
			  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);			  			
					}
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener datos del operador (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}
			
			if(ID_sueldo != "0"){
				try{
					consulta = "select * from SUELDO where ID_SUELDO = "+ID_sueldo;
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){						
						txtSueldoBase.Text = conn.leer["SUELDO_BASE"].ToString();
						txtISR.Text = conn.leer["ISR"].ToString();
						txtIMSS.Text = conn.leer["IMSS"].ToString();
						txtInfonavis.Text = conn.leer["INFONAVIT"].ToString();
						txtAguinaldo.Text = conn.leer["aguinaldo"].ToString();
						txtRetener.Text = conn.leer["Compensacion"].ToString();
						txtCompensacion.Text = conn.leer["Retener"].ToString();
						txtPrimaVacacional.Text = conn.leer["prima_v"].ToString();
					}
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener datos del sueldo del operador (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}
			
			if(ID_cuenta != "0"){
				try{
					consulta = "select * from CUENTA_BANCARIA where ID = "+ID_cuenta;
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						txtCuentaBancaria1.Text = conn.leer["NUMERO"].ToString();
						txtCuentaBancaria2.Text = conn.leer["NUMERO"].ToString();
						if(conn.leer["VALIDA"].ToString() == "VALIDADA"){
							txtCuentaBancaria1.BackColor = Color.LightGreen;
							txtCuentaBancaria2.BackColor = Color.LightGreen;
						}else{							
							txtCuentaBancaria1.BackColor = Color.Red;
							txtCuentaBancaria2.BackColor = Color.Red;
						}
							
					}
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener datos de la cuenta del operador (error al llenar los campos): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}else{
				txtCuentaBancaria1.Text = "Vacío";
				txtCuentaBancaria2.Text = "Vacío";
			}		
		}
		
		private void ValidacionCampos(){
			txtNombre.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			txtApellidoPat.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			txtApellidoMat.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			txtCurp.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			txtRFC.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			txtNSS.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtNumInfonavit.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			txtSueldoBase.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			txtISR.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			txtIMSS.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			txtInfonavis.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			txtAguinaldo.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			txtCompensacion.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			txtPrimaVacacional.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			
			txtCuentaBancaria1.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtCuentaBancaria2.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		private Boolean validaCuenta(){
			bool respuesta = true;
			if(txtCuentaBancaria1.Text.Length == 0 && txtCuentaBancaria1.Text.Length == 0){
				respuesta = true;
			}else{
				if(txtCuentaBancaria1.Text == txtCuentaBancaria2.Text)
					respuesta = true;
				else
					respuesta = false;			
			}
			return respuesta;	
		}
		#endregion
		
		#region BOTONES
		void BtnAgregarClick(object sender, EventArgs e)
		{
			Boolean respuesta = true;
				if(validaCuenta()){
					if(ID_operador != "0"){
						if(conC.modificarDatosCuenta(ID_operador, txtNombre.Text, txtApellidoMat.Text, txtApellidoPat.Text, txtCurp.Text, txtRFC.Text, txtNSS.Text, txtNumInfonavit.Text,
												txtCorreo.Text, txtLugarNacimiento.Text, txtEstadoNacimiento.Text, txtMunicipioNacimiento.Text, dateFechaNacimiento.Value.ToString("dd-MM-yyyy"),
												ID_sueldo, txtSueldoBase.Text, txtISR.Text, txtIMSS.Text, txtInfonavis.Text, txtAguinaldo.Text, txtRetener.Text, txtCompensacion.Text,
												txtPrimaVacacional.Text, ID_usuario))
							respuesta = true;
						else
							respuesta = false;
					}
				
					if(ID_cuenta != "0"){
							if(respuesta){
								if(conC.modificarCuenta(txtCuentaBancaria1.Text, ID_usuario, ID_cuenta, conC.ReturnNumero(ID_operador)))
									respuesta = true;
								else					
									respuesta = false;
							}
						}else{
							if(respuesta){
								if(txtCuentaBancaria1.Text != "" && txtCuentaBancaria2.Text != "" && txtCuentaBancaria2.Text != "Vacío"){
									if(conC.insertarCuenta(txtCuentaBancaria1.Text, ID_usuario, ID_operador))
										respuesta = true;
									else						
										respuesta = false;
								}
							}
						}				
					if(respuesta){
							MessageBox.Show("LOS DATOS SE MODIFICARON CORRECTAMENTE", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
							this.Close();
							nominaFiscal.operadorInicio();
					}else{						
						MessageBox.Show("ERROR AL MODIFICAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}	
				}else{
					errorProvider1.SetError(txtCuentaBancaria1, "LOS SENTIMOS LAS CUENTAS DEBEN COINCIDIR");
					errorProvider1.SetError(txtCuentaBancaria2, "LOS SENTIMOS LAS CUENTAS DEBEN COINCIDIR");
					txtCuentaBancaria1.Focus();
				}		
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion	
	}
}
