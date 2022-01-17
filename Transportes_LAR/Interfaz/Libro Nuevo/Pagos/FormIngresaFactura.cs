using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormIngresaFactura : Form
	{		
		#region CONSTRUCTOR
		public FormIngresaFactura(PrivilegiosPagos refPrivilegion, string datoF)
		{
			InitializeComponent();
			refPrincipal = refPrivilegion;
			txtDato.Text = datoF;
		}		
		#endregion
		
		#region INSTANCIAS		
		private PrivilegiosPagos refPrincipal = null; 
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region VERIABLES
		Int32 id_usu;
		#endregion
		
		#region INICIO - FIN
		void FormIngresaFacturaLoad(object sender, EventArgs e)
		{			
			autoCompleta();
			ValidacionCampo();
			id_usu = refPrincipal.id_usuario;
		}
		
		void FormIngresaFacturaFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.filtrosOrden();
		}
		#endregion	
	
		#region METODOS
		public void autoCompleta(){
			txtDato.AutoCompleteCustomSource = auto.AutoReconocimiento("select NUMERO_FACT dato from COBRO_ESPECIAL");
			txtDato.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtDato.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		private void ValidacionCampo()
		{
			this.txtDato.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
		}
		#endregion	
		
		#region BOTONES
		void CmdGuardrClick(object sender, EventArgs e)
		{
			if(txtDato.Text != ""){
				connL.insertaDatoFactura(refPrincipal.dgOrdenFactura[0,refPrincipal.dgOrdenFactura.CurrentRow.Index].Value.ToString(), 
				                         refPrincipal.dgOrdenFactura[2,refPrincipal.dgOrdenFactura.CurrentRow.Index].Value.ToString(), txtDato.Text, id_usu.ToString());
				refPrincipal.filtrosOrden();			
				this.Close();
			}else{
				MessageBox.Show("Ingrese dato de factura.");
			}
		}
		#endregion
	}
}
