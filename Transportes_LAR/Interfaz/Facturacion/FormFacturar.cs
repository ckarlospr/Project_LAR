using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormFacturar : Form
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
		public FormFacturar(FormControl refControl, int idUsuario, Int64 idFactura, int rIndex)
		{
			InitializeComponent();
			formControl = refControl;
			id_usuario = idUsuario;
			id_factura = idFactura;
			index = rIndex;
		}
		#endregion
		
		#region INICIO - FIN
		void FormFacturarLoad(object sender, EventArgs e)
		{
			Inicio();
		}
		
		void FormFacturarFormClosing(object sender, FormClosingEventArgs e)
		{
			
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
			
			if(lblEmpresa.Text.Contains("FARMACIAS GUADALAJARA"))
				cmbContribuyentes.SelectedIndex = 5;
			else if(lblEmpresa.Text.Contains("COREY"))
				cmbContribuyentes.SelectedIndex = 1;
			else if(lblEmpresa.Text.Contains("LIVERPOOL"))
				cmbContribuyentes.SelectedIndex = 2;
			else
				cmbContribuyentes.SelectedIndex = 0;
			
			dtpVencimiento.Value = DateTime.Now;
			Vencimiento();
		}
		
		private void Vencimiento(){
			if(lblEmpresa.Text.Contains("CARESTREAM"))
				dtpVencimiento.Value = DateTime.Now.AddDays(60);
			if(lblEmpresa.Text.Contains("CIOSA"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("CONVER"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("COREY"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text == "FARMACIAS GUADALAJARA")
				dtpVencimiento.Value = DateTime.Now.AddDays(19);
			if(lblEmpresa.Text.Contains("FORSAC"))////////////////
				dtpVencimiento.Value = DateTime.Now.AddDays(0);
			if(lblEmpresa.Text.Contains("GRAN VITA"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("HENNIGES"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("JABIL"))////////////////
				dtpVencimiento.Value = DateTime.Now.AddDays(0);
			if(lblEmpresa.Text.Contains("LIVERPOOL"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("MARZAM"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("RIMSA"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text == "SUNNINGDALE")
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("TRACSA"))
				dtpVencimiento.Value = DateTime.Now.AddDays(15);
			if(lblEmpresa.Text.Contains("VITRO"))
				dtpVencimiento.Value = DateTime.Now.AddDays(30);
		}
		
		private void GuardaFactura(){
			errorProvider1.Clear();
			if(txtFactura.Text.Length > 0){
				if(connF.Facturar(id_factura, id_usuario, txtFactura.Text, dtpVencimiento.Value.ToString("yyyy-MM-dd"), txtObservaciones.Text, cmbContribuyentes.Text)){
					MessageBox.Show("Se guardó la factura correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
					formControl.filtros();
				}else{
					MessageBox.Show("ERROR AL GUARDAR LA FACTURA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}else{
				errorProvider1.SetError(txtFactura, "Ingresa la factura");
				txtFactura.Focus();
			}
		}
		#endregion		
		
		#region BOTONES
		void BtnGuardarClick(object sender, EventArgs e)
		{
			GuardaFactura();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region EVENTOS		
		void FormFacturarKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
		#endregion
	}
}
