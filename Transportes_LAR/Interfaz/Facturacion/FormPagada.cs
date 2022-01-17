using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormPagada : Form
	{
		#region INSTANCIAS
		private FormControl formControl;			
		private Conexion_Servidor.Facturacion.SQL_Facturacion connF = new Conexion_Servidor.Facturacion.SQL_Facturacion();
		#endregion
				
		#region VARIABLES
		public Int32 id_usuario;
		public Int64 id_factura;
		public int index = 0;
		#endregion
		
		#region CONSTRUCTOR		
		public FormPagada(FormControl refControl, int idUsuario, Int64 idFactura, int rIndex)
		{
			InitializeComponent();
			formControl = refControl;
			id_usuario = idUsuario;
			id_factura = idFactura;
			index = rIndex;
		}
		#endregion
		
		#region INICIO - FIN
		void FormPagadaLoad(object sender, EventArgs e)
		{
			Inicio();
		}
		#endregion
		
		#region METODOS
		private void Inicio(){
			lblEmpresa.Text = formControl.dgOrdenFactura[2, index].Value.ToString();
			txtFactura.Text = formControl.dgOrdenFactura[5, index].Value.ToString();
			dtpDia.Value = DateTime.Now;
		}
				
		private void PagarFactura(){
			if(connF.Pagar(id_factura, id_usuario)){
				MessageBox.Show("Se pagó la factura correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
				formControl.filtros();
			}else{
				MessageBox.Show("ERROR AL PAGAR LA FACTURA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion		
		
		#region BOTONES
		void BtnGuardarClick(object sender, EventArgs e)
		{
			PagarFactura();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}
