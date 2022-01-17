using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormNuevaRuta : Form
	{
		public FormNuevaRuta(FormEmpresasOperaciones form, int ind)
		{
			InitializeComponent();
			refEmpresa=form;
			indicador=ind;
			if(ind==1)
			{
				cmdTemp.Enabled=true;
			}
			//tamanioPanel();
		}
		
		private FormEmpresasOperaciones refEmpresa = null;
		private int indicador=0;
		private int hieght=0;
		private int width=0;
		
		public void tamanioPanel()
		{
			hieght=refEmpresa.panel1.Size.Height;
			width=refEmpresa.panel1.Size.Width;
			refEmpresa.panel1.AutoSize=false;
			refEmpresa.panel1.Size = new System.Drawing.Size(width, hieght);
		}
		
		#region EVENTOS BOTONES
		void CmdApoyoClick(object sender, EventArgs e)
		{
			refEmpresa.nuevaruta(1);
			this.Close();
		}
		
		void CmdNuevaClick(object sender, EventArgs e)
		{
			refEmpresa.nuevaruta(2);
			this.Close();
		}
		
		void CmdTempClick(object sender, EventArgs e)
		{
			refEmpresa.indic2=1;
			this.Close();
		}
		#endregion
		
		void CmdExtraExtClick(object sender, EventArgs e)
		{
			refEmpresa.extendida=1;
			refEmpresa.indic2=1;
			this.Close();
		}
	}
}
