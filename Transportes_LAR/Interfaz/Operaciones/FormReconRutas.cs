using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormReconRutas : Form
	{
		public FormReconRutas(Interfaz.Operaciones.FormPrin_Empresas refPrin, Interfaz.Operaciones.FormCancelCambio refEmp)
		{
			InitializeComponent();
			refPrincipal = refPrin;
			refEmpresa=refEmp;
			
			txtReconoce.AutoCompleteCustomSource = autocomp.AutoOp();
			txtReconoce.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtReconoce.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtMuestra.AutoCompleteCustomSource = autocomp.AutoOp();
			txtMuestra.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtMuestra.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		private Interfaz.Operaciones.FormCancelCambio refEmpresa = null;
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		private Interfaz.Operaciones.FormPrin_Empresas refPrincipal = null;
		private int IDOP_MUESTRA=0;
		private Int64 ID_RUTA=0;
		
		
		void FormReconRutasLoad(object sender, EventArgs e)
		{
			if(refEmpresa.indexCol<9)
			{
				txtMuestra.Text=refEmpresa.refEmpOper.dtgEmpresas[3,refEmpresa.indexFil].Value.ToString();
				//IDOP_MUESTRA=Convert.ToInt16(refEmpresa.refEmpOper.dtgEmpresas[18,refEmpresa.indexFil].Value);
				txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[6,refEmpresa.indexFil].Value.ToString();
				ID_RUTA=Convert.ToInt64(refEmpresa.refEmpOper.dtgEmpresas[2,refEmpresa.indexFil].Value);
			}
			else
			{
				txtMuestra.Text=refEmpresa.refEmpOper.dtgEmpresas[11,refEmpresa.indexFil].Value.ToString();
				//IDOP_MUESTRA=Convert.ToInt16(refEmpresa.refEmpOper.dtgEmpresas[22,refEmpresa.indexFil].Value);
				txtRuta.Text=refEmpresa.refEmpOper.dtgEmpresas[14,refEmpresa.indexFil].Value.ToString();
				ID_RUTA=Convert.ToInt64(refEmpresa.refEmpOper.dtgEmpresas[10,refEmpresa.indexFil].Value);
			}
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			txtReconoce.Focus();
			if(txtMuestra.Text!="" && txtReconoce.Text!="" && txtRuta.Text!="")
			{
				int idReconoce = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtReconoce.Text);
				IDOP_MUESTRA = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtMuestra.Text);
				if(idReconoce!=0)
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().reconocimientoRutas(refEmpresa.refEmpOper.refPrincipal.principal.idUsuario, idReconoce,  IDOP_MUESTRA, ID_RUTA, refEmpresa.refEmpOper.refPrincipal.fecha_Base_Datos, refEmpresa.refEmpOper.refPrincipal.ConsTurno);
					refPrincipal.recRutas();
					this.Close();
				}
				else if(idReconoce==0)
				{
					MessageBox.Show("Operador no encontrado");
				}
			}
			else
			{
				MessageBox.Show("Ingrese todos los datos");
			}
		}
		
		
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
