using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormDetalleBaja : Form
	{
		private string idOperador="";
		String Contrato = "";
		String Recomendacion = "";
		
		public FormDetalleBaja(string idOperador,string nombre,string apellidoPat,string apellidoMat)
		{
			InitializeComponent();
			this.idOperador=idOperador;
		}
		
		//--EVENTO_BOTON ( ACEPTAR )
		void BtnAceptarClick(object sender, EventArgs e)
		{
			//if(txtDescripcion.Text!="")
			//{
				new Conexion_Servidor.Operador.SQL_Operador().getBajaOperador(idOperador,txtDescripcion.Text, Contrato, Recomendacion);
				this.Close();
			//}
			//else
			//	MessageBox.Show("¿Necesita escribir el motivo de la baja del operador","Baja del operador",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
		}
		
		void RContratableCheckedChanged(object sender, EventArgs e)
		{
			if(rContratable.Checked==true)
				Contrato = rContratable.Text;
			else if(rNoRecontratable.Checked==true)
				Contrato = rNoRecontratable.Text;
			else if (rReconsiderable.Checked==true)
				Contrato = rReconsiderable.Text;	
		}
		
		void RRecomendableCheckedChanged(object sender, EventArgs e)
		{
			if(rRecomendable.Checked==true)
				Recomendacion = rRecomendable.Text;
			else if(rNoRecomendable.Checked==true)
				Recomendacion = rNoRecomendable.Text;
		}
	}
}
