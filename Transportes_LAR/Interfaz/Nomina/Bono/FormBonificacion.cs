using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Bono
{
	public partial class FormBonificacion : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		Interfaz.FormPrincipal principal = null;
		DateTimePicker dtInicio = new DateTimePicker();
		DateTimePicker dtCorte = new DateTimePicker();
		DataGridView dataBonos = new DataGridView();
		Interfaz.Nomina.FormNomina fnomina = null;
		#endregion
		
		#region VARIABLES
		String idO = "0";
		String ID = "0";
		String nombre = "";
		bool swicth = false;
		int row;
		String Alias = "";
		String id_usuario = "";
		#endregion
		
		#region CONSTRUCTORES
		public FormBonificacion()
		{
			InitializeComponent();
		}
		
		public FormBonificacion(String Usuario, String ID_O, bool apagador, 
		                   Interfaz.FormPrincipal principal, String ID,
		                   DateTimePicker dtInicio, DateTimePicker dtCorte, 
		                   DataGridView dataBonos, int row, String Alias, String id_usuario)
		{
			InitializeComponent();
			this.nombre = Usuario;
			this.idO = ID_O;
			this.ID = ID;
			this.swicth = apagador;
			this.principal=principal;
			this.dtInicio = dtInicio;
			this.dtCorte = dtCorte;
			this.dataBonos = dataBonos;
			this.row = row;
			this.Alias = Alias;
			this.id_usuario = id_usuario;
			Interfaz.Nomina.FormNomina formnomina = new Interfaz.Nomina.FormNomina(principal, id_usuario);
			this.fnomina = formnomina;
			fnomina.AdaptadorOperador();
		}
		#endregion
		
		#region EVENTOS BOTONES
		void CmdNuevoClick(object sender, EventArgs e)
		{
			if(Convert.ToDouble(txtResultado.Text)>0)
			{
				conn.getAbrirConexion("UPDATE NUEVO_HISTORIAL_BONO_OPERADOR SET Porcentaje='"+(Convert.ToDouble(txtPorcentaje.Text)/100)+"', ID_USUARIO='"+principal.idUsuario+"' where FECHA_INICIO='"+dtInicio.Value.ToString("dd-MM-yyyy")+"' and FECHA_FIN='"+dtCorte.Value.ToString("dd-MM-yyyy")+"' and ID_O="+idO);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();	
				this.Hide();
			}
			else
				MessageBox.Show("Faltan Campos por llenar!!!", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		#endregion
		
		#region VALIDAR
		void Validar()
		{
			this.txtDinero.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			this.txtPorcentaje.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		#region METODOS OPCIONES
		void CkPorcentajeCheckedChanged(object sender, EventArgs e)
		{
			txtPorcentaje.Enabled = true;
			ckDinero.Checked = false;
			txtDinero.Enabled = false;
		}
		
		void CkDineroCheckedChanged(object sender, EventArgs e)
		{
			txtDinero.Enabled = true;
			ckPorcentaje.Checked = false;
			txtPorcentaje.Enabled = false;
		}
		
		void TxtPorcentajeTextChanged(object sender, EventArgs e)
		{
			if(txtPorcentaje.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			
			if(ckPorcentaje.Checked == true)
			{
				if(txtPorcentaje.Text != "" && txtPorcentaje.Text != ".")
				{
					if ((Convert.ToDouble(txtPorcentaje.Text))>100)
					{
		               txtPorcentaje.Text= "0";
		               MessageBox.Show("El porcentaje no debe ser mayor a 100 % ", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		            }
					else if((Convert.ToDouble(txtPorcentaje.Text)>0 && Convert.ToDouble(txtTotalBono.Text)>0))
					{
						txtResultado.Text = ((Convert.ToDouble(txtTotalBono.Text) / 100) * Convert.ToDouble(txtPorcentaje.Text)).ToString();
						txtDinero.Text = txtResultado.Text;
					}
				}
			}
		}
		
		void TxtDineroTextChanged(object sender, EventArgs e)
		{
			if(txtDinero.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			
			if(ckDinero.Checked == true)
			{
				if(txtDinero.Text != "" && txtDinero.Text != ".")
				{
					if ((Convert.ToDouble(txtTotalBono.Text))<(Convert.ToDouble(txtDinero.Text)))
					{
		               txtDinero.Text= "0";
		               MessageBox.Show("El dinero a regresar no debe ser mayor al total del Bono ganado", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		            }
					else if(Convert.ToDouble(txtDinero.Text)>0 && Convert.ToDouble(txtTotalBono.Text)>0)
					{
						txtPorcentaje.Text = ((Convert.ToDouble(txtDinero.Text) / Convert.ToDouble(txtTotalBono.Text)) * 100).ToString();
						txtResultado.Text = txtDinero.Text;
					}
				}
			}
		}
		#endregion
		
		#region INICIO
		void FormBonificacionLoad(object sender, EventArgs e)
		{
			Validar();
			txtTotalBono.Text = (fnomina.RetornoNumeroViajes(Alias) * 15).ToString();
		}
		#endregion
		
	}
}
