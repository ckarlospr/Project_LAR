using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormCancelaFactura : Form
	{		
		#region INSTANCIAS
		private FormControl formControl;			
		private Conexion_Servidor.Facturacion.SQL_Facturacion connF = new Conexion_Servidor.Facturacion.SQL_Facturacion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
				
		#region VARIABLES
		public Int32 id_usuario;
		public Int64 id_factura;
		public int index = 0;
		#endregion
		
		#region CONSTRUCTOR		
		public FormCancelaFactura(FormControl refControl, int idUsuario, Int64 idFactura, int rIndex)
		{
			InitializeComponent();
			formControl = refControl;
			id_usuario = idUsuario;
			id_factura = idFactura;
			index = rIndex;
		}
		#endregion
		
		#region INICIO - FIN
		void FormCancelaFacturaLoad(object sender, EventArgs e)
		{
			Inicio();
		}
		#endregion
		
		#region METODOS
		private void Inicio(){
			lblEmpresa.Text = formControl.dgOrdenFactura[2, index].Value.ToString();
			dtpInicioOrdenFactura.Value = Convert.ToDateTime(formControl.dgOrdenFactura[6, index].Value);
			dtpFinOrdenFactura.Value = Convert.ToDateTime(formControl.dgOrdenFactura[7, index].Value);		
			txtImporte.Text = formControl.dgOrdenFactura[8, index].Value.ToString();
			txtIVA.Text = formControl.dgOrdenFactura[9, index].Value.ToString();
			txtTotal.Text = formControl.dgOrdenFactura[10, index].Value.ToString();			
			
			txtMotivo.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"SELECT MOTIVO FROM CANCELA_CONTROL_FACTURACION", "MOTIVO");
			txtMotivo.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtMotivo.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		private void CancelaFactura(){
			errorProvider1.Clear();
			if(txtMotivo.Text.Length > 0){
				if(connF.CancelaFacturar(id_factura, id_usuario, txtMotivo.Text, txtObservaciones.Text)){
					MessageBox.Show("Se canceló la factura correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
					formControl.filtros();
				}else{
					MessageBox.Show("ERROR AL CANCELAR LA FACTURA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}else{
				errorProvider1.SetError(txtMotivo, "Ingresa el motivo de la cancelación");
				txtMotivo.Focus();
			}
		}
		#endregion		
		
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{
			CancelaFactura();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS
		void FormCancelaFacturaKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
	}
}
