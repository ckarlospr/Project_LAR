using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	/// </summary>
	public partial class FormPruebaRendimiento : Form
	{
		public FormPruebaRendimiento(Interfaz.Operaciones.FormPrin_Empresas refPrin)
		{
			InitializeComponent();
			refPrincipal=refPrin;
		}
		
		private Interfaz.Operaciones.FormPrin_Empresas refPrincipal = null;
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		
		void FormPruebaRendimientoLoad(object sender, EventArgs e)
		{
			txtMuestra.AutoCompleteCustomSource = autocomp.AutoOp();
			txtMuestra.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtMuestra.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtReconoce.AutoCompleteCustomSource = autocomp.AutoOp();
			txtReconoce.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtReconoce.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(txtMuestra.Text!="" && txtReconoce.Text!="")
			{
				MessageBox.Show(dtgRutas[0,dtgRutas.CurrentRow.Index].ToString());
				
				/*int idMuestra = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtMuestra.Text);
				int idReconoce = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtReconoce.Text);
				new Conexion_Servidor.Desapacho.SQL_Operaciones().pruebaRendimiento(refPrincipal.principal.idUsuario, idMuestra, idReconoce, dtgRutas[0,dtgRutas.SelectedRows], refPrincipal.fecha_despacho, refPrincipal.ConsTurno);
				this.Close();*/
			}
			else
			{
				MessageBox.Show("Ingrese todos los datos");
			}
		}
		
		
		void TxtMuestraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				refPrincipal.IDrutasOperador.Clear();
				refPrincipal.rutasOperador.Clear();
				refPrincipal.obtRutas(txtMuestra.Text);
				tablaRutas();
			}
		}
		
		public void tablaRutas()
		{
			if(refPrincipal.rutasOperador.Count>0)
			{
				while(dtgRutas.Rows.Count>0)
				{
					dtgRutas.Rows.RemoveAt(0);
				}
				
				for(int x=0; x<refPrincipal.rutasOperador.Count; x++)
				{
					dtgRutas.Rows.Add(refPrincipal.IDrutasOperador[x], refPrincipal.rutasOperador[x]);
					dtgRutas.ClearSelection();
				}
			}
			else
			{
				MessageBox.Show("Es necesario la asignacion de una ruta en el despacho.");
				this.Close();
			}
		}
	}
}
