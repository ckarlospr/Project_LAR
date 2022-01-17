using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormMensajeRend : Form
	{
		public FormMensajeRend(Interfaz.Combustible.formPrincipalComb principalC)
		{
			InitializeComponent();
			principalComb = principalC;
		}
		
		double factorEficiencia = 0.0;
		double factorLitros = 0.0;
		double factorKm = 0.0;
		double factorRend = 0.0;
		double factorMaximoEf = 0.0;
		double factorMaximoKm = 0.0;
		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		Interfaz.Combustible.formPrincipalComb principalComb;
		
		void FormMensajeRendLoad(object sender, EventArgs e)
		{
			getFactor();
			getDatos();
		}
		
		void getDatos()
		{
			lblUltima.Text 	 = principalComb.lblUltima.Text;
			lblHrUltima.Text = principalComb.lblHrUltima.Text;
			lblKmUltima.Text = principalComb.lblKmUltima.Text;
			
			lblKmHubo.Text = principalComb.lblKmHubo.Text;
			lblRendOp.Text = principalComb.lblRendOp.Text;
			lblFactor.Text = principalComb.lblFactor.Text;
			
			lblRendimiento.Text = principalComb.lblRendimiento.Text;
			lblEficiencia.Text 	= principalComb.lblEficiencia.Text;
			lblLitros.Text 		= principalComb.lblLitros.Text;
			
			colores();
		}
		
		void colores()
		{
			try
			{
				if(Convert.ToDouble(lblRendimiento.Text)<Convert.ToDouble(lblRendOp.Text)-(Convert.ToDouble(lblRendOp.Text)*(factorRend/100)))
					lblRendimiento.BackColor=Color.Red;
				else
					lblRendimiento.BackColor=Color.MediumSpringGreen;
				
				lblEficiencia.Text=decimales(((Convert.ToDouble(lblRendimiento.Text)*Convert.ToDouble(100))/Convert.ToDouble(lblRendOp.Text)).ToString());
				
				if(Convert.ToDouble(lblEficiencia.Text)<factorEficiencia || Convert.ToDouble(lblEficiencia.Text)>factorMaximoEf)
				{
					lblEficiencia.BackColor=Color.Red;
					lblSimboloPorcent.BackColor=Color.Red;
				}
				else
				{
					lblEficiencia.BackColor=Color.MediumSpringGreen;
					lblSimboloPorcent.BackColor=Color.MediumSpringGreen;
				}
					
				lblLitros.Text=decimales((Convert.ToDouble(principalComb.dgAutorizacionValida[7,0].Value.ToString())-(Convert.ToDouble(lblKmHubo.Text)/Convert.ToDouble(lblRendOp.Text))).ToString());
				
				if(Convert.ToDouble(lblLitros.Text)>factorLitros)
				{
					lblLitros.BackColor=Color.Red;
				}
				else
				{
					lblLitros.BackColor=Color.MediumSpringGreen;
				}
				
			}
			catch(Exception)
			{
				
			}
		}
		
		String decimales(String dato)
		{
			String respuesta = dato;
			int punto = 0;
			
			for(int x=0; x<dato.Length; x++)
			{
				if(dato.Substring(x, 1)==".")
				{
					punto = x;
				}
			}
			
			if(punto>0)
			{
				if(punto+3<dato.Length)
				{
					respuesta = dato.Substring(0,punto+3);
				}
				else if(punto+2<dato.Length)
				{
					respuesta = dato.Substring(0,punto+2);
				}
			}
			
			return respuesta;
		}
		
		void getFactor()
		{
			String consulta = "select * from FACTOR_COBRO where ESTATUS='1'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["NOMBRE"].ToString()=="LITROS")
					factorLitros=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="EFICIENCIA")
					factorEficiencia=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="RENDIMIENTO")
					factorRend=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="KM")
					factorKm=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="MAYOR_EFICIENCIA")
					factorMaximoEf=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="MAYOR_KM")
					factorMaximoKm=Convert.ToDouble(conn.leer["FACTOR"]);
			}
			
			conn.conexion.Close();
		}
	}
}
