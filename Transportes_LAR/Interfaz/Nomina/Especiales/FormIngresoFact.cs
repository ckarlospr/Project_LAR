using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormIngresoFact : Form
	{
		public FormIngresoFact(FormCuentasEsp refCuent)
		{
			InitializeComponent();
			refCuentas=refCuent;
		}
		
		FormCuentasEsp refCuentas;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		private void getCargarValidacionCampos(FormIngresoFact formDat)
		{
			formDat.txtDato.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtDato.Text!="")
			{
				refCuentas.guardaDatosFact(txtDato.Text);
				this.Close();
			}
			else
			{
				MessageBox.Show("Ingrese los datos correspondientes.");
			}
		}
		
		void FormIngresoFactLoad(object sender, EventArgs e)
		{
			for(int x=0; x<refCuentas.dgRelacion.Rows.Count; x++)
			{
				if(refCuentas.dgRelacion.Rows[x].Selected==true)
				{
					String consulta = "select NUMERO_ANTI from RUTA_ESPECIAL where ID_RE="+refCuentas.dgRelacion[0,x].Value.ToString();
					
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					
					if(conn.leer.Read())
					{
						txtDato.Text=conn.leer["NUMERO_ANTI"].ToString();
					}
					else
					{
						txtDato.Text="";
					}
					
					conn.conexion.Close();
				}
			}
		}
	}
}
