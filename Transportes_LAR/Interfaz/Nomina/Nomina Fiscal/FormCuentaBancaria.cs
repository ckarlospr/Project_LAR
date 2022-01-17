using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	public partial class FormCuentaBancaria : Form
	{
		#region CONSTRUCTOR
		public FormCuentaBancaria(FormNominaFiscal refNominaF, string id_operado, string id_usua)
		{
			InitializeComponent();
			nominaFiscal = refNominaF;
			id_operador = id_operado;
			id_usuario = id_usua;
		}
		public FormCuentaBancaria(FormNominaFiscal refNominaF, string id_operado, string id_usua, string id_cuen)
		{
			InitializeComponent();
			nominaFiscal = refNominaF;
			id_operador = id_operado;
			id_usuario = id_usua;
			id_cuenta = id_cuen;
		}
		#endregion
				
		#region VALIARBLES		
		String id_operador = "0";
		String id_usuario = "0";
		String id_cuenta = "0";
		System.IO.MemoryStream ms = null;
		#endregion	
		
		#region INSTANCIAS
		private FormNominaFiscal nominaFiscal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Cuenta.SQL_Cuenta conC = new Conexion_Servidor.Cuenta.SQL_Cuenta();
		#endregion
				
		#region INICIO - FIN
		void FormCuentaBancariaLoad(object sender, EventArgs e)
		{
			Operador();
		}
		
		void FormCuentaBancariaFormClosing(object sender, FormClosingEventArgs e)
		{
			
		}		
		#endregion
		
		#region BOTONES
		void BtnActualizarClick(object sender, EventArgs e)
		{	
			if(validaCuenta()){
				if(id_cuenta == "0" || id_cuenta == null){
					if(conC.insertarCuenta(txtCuentaBancaria1.Text, id_usuario, id_operador)){
						MessageBox.Show("LOS DATOS FUERON INSERTADOS CORRECTAMENTE", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						nominaFiscal.dgOperadoresDatos[14, nominaFiscal.dgOperadoresDatos.CurrentCell.RowIndex].Value = txtCuentaBancaria1.Text;
						nominaFiscal.dgOperadoresDatos[13, nominaFiscal.dgOperadoresDatos.CurrentCell.RowIndex].Value = conC.ReturnIdCuenta(id_operador);						
						this.Close();
					}else{						
						MessageBox.Show("ERROR INSERTAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}					
				}
				else if(id_cuenta != "0" && id_cuenta != null)
				{
					if(conC.modificarCuenta(txtCuentaBancaria1.Text, id_usuario, id_cuenta, conC.ReturnNumero(id_operador))){
						MessageBox.Show("LOS DATOS FUERON INSERTADOS CORRECTAMENTE", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
						nominaFiscal.dgOperadoresDatos[14, nominaFiscal.dgOperadoresDatos.CurrentCell.RowIndex].Value = txtCuentaBancaria1.Text;
						nominaFiscal.dgOperadoresDatos[15, nominaFiscal.dgOperadoresDatos.CurrentCell.RowIndex].Value = "SIN VALIDAR";
						nominaFiscal.dgOperadoresDatos[15, nominaFiscal.dgOperadoresDatos.CurrentCell.RowIndex].Style.BackColor = Color.Red;
						this.Close();
					}else{						
						MessageBox.Show("ERROR INSERTAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}else{
				errorProvider1.SetError(txtCuentaBancaria1, "LOS SENTIMOS LAS CUENTAS DEBEN COINCIDIR");
				errorProvider1.SetError(txtCuentaBancaria2, "LOS SENTIMOS LAS CUENTAS DEBEN COINCIDIR");
				txtCuentaBancaria2.Focus();
			}
				
		}
		#endregion
		
		#region METODOS
		private Boolean validaCuenta(){
			if(txtCuentaBancaria1.Text == txtCuentaBancaria2.Text)
				return true;
			else
				return false;				
		}
		
		private void Operador(){
			if(id_operador != "0"){
				ptbImagen.Image = System.Drawing.Image.FromFile(@"../debug/Nomina.jpg");
				try{
					conn.getAbrirConexion("select Imagen, Alias, Apellido_Pat +' '+Apellido_Mat+' '+Nombre as nombre from operador where ID = "+id_operador);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read()){
						txtNombre.Text = conn.leer["nombre"].ToString();
						lblOperador.Text = conn.leer["Alias"].ToString();						
						byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
			  			ms = new System.IO.MemoryStream(imageBuffer);
			  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
					}
				}catch{}
				conn.conexion.Close();
				if(id_cuenta != "0"){
					txtCuentaBancaria1.Text = conC.ReturnNumero(id_operador);
					txtCuentaBancaria2.Text = conC.ReturnNumero(id_operador);			
				}
			}						
		}		
		#endregion		
	}
}
