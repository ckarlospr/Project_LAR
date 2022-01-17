using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormSuplente : Form
	{
		private Interfaz.Operaciones.FormEmpresasOperaciones refEmpresas = null;
		private int sentid;
		private	String aliasAn;
		private	int fil;
		private	String aliasSi;
		
		public FormSuplente(Interfaz.Operaciones.FormEmpresasOperaciones referEmp, int sentido,String aliasAnt,int fila,String aliasSig)
		{
			InitializeComponent();
			refEmpresas=referEmp;
			this.sentid=sentido;
			this.aliasAn=aliasAnt;
			this.fil=fila;
			this.aliasSi=aliasSig;
		}
		
		public void CmdCambioClick(object sender, EventArgs e)
		{
			refEmpresas.Revisando(sentid, aliasAn, fil, aliasSi, "cambiar");
			this.Close();
		}
		
		void CmdSuplirClick(object sender, EventArgs e)
		{
			refEmpresas.Revisando(sentid, aliasAn, fil, aliasSi, "suplir");
			this.Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
