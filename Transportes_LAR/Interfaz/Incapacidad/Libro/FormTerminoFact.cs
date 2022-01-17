using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormTerminoFact : Form
	{
		public FormTerminoFact(FormFacturaEsp formFact)
		{
			InitializeComponent();
			refPrincipal = formFact;
		}
		
		#region AUTOCOMPLETE Y EVENTO LOAD
		private FormFacturaEsp refPrincipal = null; 
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		
		void FormTerminoFactLoad(object sender, EventArgs e)
		{
			txtDato.AutoCompleteCustomSource = auto.AutoReconocimiento("select NUMERO_FACT dato from COBRO_ESPECIAL");
			txtDato.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtDato.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region VALIDACION DE COMPONENTES
		private void getCargarValidacionCampos(FormTerminoFact formDat)
		{
			formDat.txtDato.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdGuardrClick(object sender, EventArgs e)
		{
			refPrincipal.guardaDatos(txtDato.Text);
			this.Close();
		}
		#endregion
	}
}
