using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Controles.Uber_Taxi
{
	public partial class FormCancela : Form
	{
		#region INSTANCIAS
		private FormUber_Taxi formUT;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Controles.SQL_Controles connC = new Conexion_Servidor.Controles.SQL_Controles();
		#endregion
		
		#region VARIABLES
		string idUsuario;
		Int64 idPedido;
		Int64 idUT;
		#endregion
		
		#region CONSTRUCTORES
		public FormCancela(FormUber_Taxi refUT, Int64 id_p, string id_usu, int x)
		{
			InitializeComponent();
			this.formUT = refUT;
			this.idUsuario = id_usu;
			this.idPedido = id_p;
		}
		
		public FormCancela(FormUber_Taxi refUT, Int64 id_UT, string id_usu)
		{
			InitializeComponent();
			this.formUT = refUT;
			this.idUsuario = id_usu;
			this.idUT = id_UT;
		}
		#endregion
		
		#region INICIO - FIN
		void FormCancelaLoad(object sender, EventArgs e)
		{
			cargaInicio();
		}
		
		void FormCancelaFormClosing(object sender, FormClosingEventArgs e)
		{
			if(idPedido == 0 && idUT > 0){
				formUT.filtros();
				formUT.gbProgramcion.Enabled = false;
				formUT.gbPedidos.Enabled = false;
			}else{
				formUT.obtenerDatosM();
			}
		}
		#endregion
		
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{			
			if(idUT > 0 && idPedido == 0){
				if(connC.cancelaUT_V("PEDIDO", idUT.ToString(), txtmotivo.Text, idUsuario))
				   	MessageBox.Show("Se cancelo correctamente el pedido", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
				   	MessageBox.Show("Error al cancelar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			if(idPedido > 0 && idUT == 0){
				if(connC.cancelaUT_V("VEHICULO", idPedido.ToString(), txtmotivo.Text, idUsuario))
				   	MessageBox.Show("Se cancelo correctamente el vehículo", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
				   	MessageBox.Show("Error al cancelar el vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Close();
		}
		#endregion
		
		#region METODOS
		private void cargaInicio(){
			if(idPedido > 0 && idUT == 0){
				lblCancela.Text = "Vehículo: ";
				txtCancela.Text = formUT.dgPedidos[2, formUT.dgPedidos.CurrentCell.RowIndex].Value +" - "+ formUT.dgPedidos[3, formUT.dgPedidos.CurrentCell.RowIndex].Value;
			}
			
			if(idUT > 0 && idPedido == 0){
				lblCancela.Text = "Pedido: ";
				txtCancela.Text = formUT.dgProgramados[2, formUT.dgProgramados.CurrentCell.RowIndex].Value +" - "+ formUT.dgProgramados[3, formUT.dgProgramados.CurrentCell.RowIndex].Value;
			}
		}
		#endregion
		
		#region EVENTOS
		void TxtmotivoTextChanged(object sender, EventArgs e)
		{
			if(txtmotivo.Text.Length > 0)
				btnAceptar.Enabled = true;
			else
				btnAceptar.Enabled = false;
		}
		#endregion
	}
}
