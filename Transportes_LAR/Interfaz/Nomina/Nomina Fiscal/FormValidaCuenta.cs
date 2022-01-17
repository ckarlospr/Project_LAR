using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	public partial class FormValidaCuenta : Form
	{
		#region CONSTRUCTOR
		public FormValidaCuenta(FormNominaFiscal refNominaF, string id_cuent, string Ncuenta, string ID_op, string id_usu)
		{
			InitializeComponent();
			nominaFiscal = refNominaF;
			id_cuenta = id_cuent;
			id_usuario = id_usu;
			numero_Cuenta = Ncuenta;
			id_operador = ID_op;
		}
		#endregion
		
		#region VARIABLES
		string id_cuenta = "0";
		string id_usuario = "0";
		string numero_Cuenta = "0";
		string id_operador = "0";
		#endregion
		
		#region INSTANCIAS
		private FormNominaFiscal nominaFiscal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Cuenta.SQL_Cuenta conC = new Conexion_Servidor.Cuenta.SQL_Cuenta();
		#endregion
		
		#region INICIO - FIN
		void FormValidaCuentaLoad(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region BOTONES
		void BtnActualizarClick(object sender, EventArgs e)
		{
			if(validaNumeroCuenta()){
				if(conC.ValidaCuenta(id_usuario, id_cuenta)){
					this.Close();
					MessageBox.Show("Se valido correctamente la cuenta", "Validado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					nominaFiscal.dgOperadoresDatos[15, nominaFiscal.dgOperadoresDatos.CurrentCell.RowIndex].Value = "VALIDADA";
					nominaFiscal.dgOperadoresDatos[15, nominaFiscal.dgOperadoresDatos.CurrentCell.RowIndex].Style.BackColor = Color.LightGreen;
				}
			}else{
				errorProvider1.Clear();
				errorProvider1.SetError(txtCuentaBancaria1, "Lo sentimos la cuenta que introdujo no corresponde a la que el operador tiene asignada");
				txtCuentaBancaria1.Focus();
			}	
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region METODOS
		private bool validaNumeroCuenta(){
			if(conC.ReturnNumero(id_operador) == txtCuentaBancaria1.Text)
				return true;
			else
				return false;
		}
		#endregion		
	}
}
