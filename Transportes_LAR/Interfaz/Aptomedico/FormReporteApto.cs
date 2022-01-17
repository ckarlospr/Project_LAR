using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Aptomedico
{
	public partial class FormReporteApto : Form
	{
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region CONSTRUCTOR
		public FormReporteApto()
		{
			InitializeComponent();
		}
		
		public FormReporteApto(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormReporteAptoLoad(object sender, EventArgs e)
		{
			dataLicencia.DataSource=new Conexion_Servidor.Operador.SQL_Licencia().getTabla("select O.Alias, A.Numero, A.Vigencia from APTOMEDICO A, OPERADOR O where A.ID_OPERADOR=O.ID AND O.Estatus='1'and O.Alias!='Admvo'and O.tipo_empleado!='Externo'");
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR WHERE tipo_empleado='OPERADOR'", "Alias");
           	txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		void FormReporteAptoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.aptomedico =  true;
		}
		#endregion
		
		#region BUSQUEDA
		void TxtAliasTextChanged(object sender, EventArgs e)
		{
			dataLicencia.DataSource=new Conexion_Servidor.Operador.SQL_Licencia().getTabla("select O.Alias, A.Numero, A.Vigencia from APTOMEDICO A, OPERADOR O where A.ID_OPERADOR=O.ID AND O.Estatus='1'and O.Alias!='Admvo'and O.tipo_empleado!='Externo' and O.alias like '"+txtAlias.Text+"%'");
		}
		
		void TxtNumeroTextChanged(object sender, EventArgs e)
		{
			dataLicencia.DataSource=new Conexion_Servidor.Operador.SQL_Licencia().getTabla("select O.Alias, A.Numero, A.Vigencia from APTOMEDICO A, OPERADOR O where A.ID_OPERADOR=O.ID AND O.Estatus='1'and O.Alias!='Admvo'and O.tipo_empleado!='Externo' and A.Numero like '"+txtNumero.Text+"%'");
		}
		#endregion
	}
}
