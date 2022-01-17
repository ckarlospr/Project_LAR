using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormPruebasRend : Form
	{
		public FormPruebasRend(Interfaz.Operaciones.FormPrin_Empresas refPrin, Interfaz.Operaciones.FormCancelCambio refEmp)
		{
			InitializeComponent();
			refPrincipal = refPrin;
			refEmpresa=refEmp;
			
			txtsuperv.AutoCompleteCustomSource = autocomp.AutoOp();
			txtsuperv.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtsuperv.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		private Interfaz.Operaciones.FormCancelCambio refEmpresa = null;
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		private Interfaz.Operaciones.FormPrin_Empresas refPrincipal = null;
		private int IDOP_PRUEBA=0;
		private int ID_RUTA=0;
		
		
		
		void FormPruebasRendLoad(object sender, EventArgs e)
		{
			txtsuperv.Focus();
			if(refEmpresa.indexCol<9)
			{
				txtOperador.Text=refEmpresa.refEmpOper.dtgEmpresas[3,refEmpresa.indexFil].Value.ToString();
				IDOP_PRUEBA=Convert.ToInt16(refEmpresa.refEmpOper.dtgEmpresas[18,refEmpresa.indexFil].Value);
				txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[6,refEmpresa.indexFil].Value.ToString();
				ID_RUTA=Convert.ToInt16(refEmpresa.refEmpOper.dtgEmpresas[2,refEmpresa.indexFil].Value);
			}
			else
			{
				txtOperador.Text=refEmpresa.refEmpOper.dtgEmpresas[11,refEmpresa.indexFil].Value.ToString();
				IDOP_PRUEBA=Convert.ToInt16(refEmpresa.refEmpOper.dtgEmpresas[22,refEmpresa.indexFil].Value);
				txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[14,refEmpresa.indexFil].Value.ToString();
				ID_RUTA=Convert.ToInt16(refEmpresa.refEmpOper.dtgEmpresas[10,refEmpresa.indexFil].Value);
			}
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(txtsuperv.Text!="")
			{
				int idSupervisa = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtsuperv.Text);
				if(idSupervisa!=0)
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().pruebaRendimiento(refEmpresa.refEmpOper.refPrincipal.principal.idUsuario, IDOP_PRUEBA, idSupervisa, ID_RUTA, refEmpresa.refEmpOper.refPrincipal.fecha_Base_Datos, refEmpresa.refEmpOper.refPrincipal.ConsTurno);
					refPrincipal.recPruebasRend();
					this.Close();
				}
				else if(idSupervisa==0)
				{
					MessageBox.Show("Operador no encontrado");
				}
			}
			else
			{
				MessageBox.Show("Ingrese el operador que supervisara la prueba de rendimiento.");
			}
		}
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
