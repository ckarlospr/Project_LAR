using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Validacion_Final
{
	public partial class FormCompletaSaldo : Form
	{
		#region CONSTRUCTOR
		public FormCompletaSaldo(String id_re, FormValidarServicios rep)
		{
			InitializeComponent();			
			refReporte = rep;
			ID = id_re;
		}
		#endregion
		
		#region VARIABLES
		String ID;
		#endregion
		
		#region INSTANCIAS
		FormValidarServicios refReporte;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region INICIO
		void FormCompletaSaldoLoad(object sender, EventArgs e)
		{
			txtFaltante.Text=refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
			txtRecuperado.Text=refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
			
			txtUbica.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select UBICA dato from ANTICIPOS_ESPECIALES");
			txtUbica.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtUbica.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region GUARDAR
		void CmdGuardaClick(object sender, EventArgs e)
		{
			if(txtComentario.Text != "" && txtComentario.Text != "Comentario..."){
				if(Convert.ToDouble(txtRecuperado.Text)<=Convert.ToDouble(txtFaltante.Text)){
					string tipo="";
					
					if(rbEfectivo.Checked == true)
						tipo = "EFECTIVO";
					else if(rbDeposito.Checked == true)
						tipo = "DEPOSITO";
					
					if(cbAbono.Checked == true){
						String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+ID+", '"+txtRecuperado.Text+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refReporte.refPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', '"+tipo+"', '"+txtComentario.Text+"', 'ABONO', '"+txtUbica.Text+"', null) ";
						conn.getAbrirConexion(sentencia);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}else{
						String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+ID+", '"+txtRecuperado.Text+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refReporte.refPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', '"+tipo+"', '"+txtComentario.Text+"', 'AJUSTE', '"+txtUbica.Text+"', null) ";
						conn.getAbrirConexion(sentencia);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
						
					if(rbEfectivo.Checked == true)
						refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value = (Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(txtRecuperado.Text)).ToString();
					else
						refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value = (Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(txtRecuperado.Text)).ToString();
						
					refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value = Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value);//+Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value);
					refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value = Convert.ToDouble(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value)-Convert.ToDouble(txtRecuperado.Text);
					
					if(Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value) == Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value) && refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Red")
						refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor = Color.MediumSpringGreen;
					else if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name == "Red" && refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
						refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor = Color.MediumSpringGreen;
					
					
					if(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value.ToString() == refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value.ToString())
						refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
					
					if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name == "OrangeRed")
						refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor = Color.White;										
					this.Close();
				}else{
					MessageBox.Show("La cantidad recuperada que ingreso no es correcta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtRecuperado.SelectAll();
				}
			}else{
				MessageBox.Show("Ingrese en comentarios la razón.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtComentario.SelectAll();
			}
		}
		#endregion
		
		#region EVENTOS
		void TxtComentarioClick(object sender, EventArgs e)
		{
			txtComentario.SelectAll();
		}
		
		void TxtRecuperadoKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || ((e.KeyChar==46) && !(txtComentario.Text.Contains("."))))
				e.Handled = false;
			else
				e.Handled = true;
		}
		
		void TxtRecuperadoClick(object sender, EventArgs e)
		{
			txtRecuperado.SelectAll();
		}
		
		void CbAbonoCheckedChanged(object sender, EventArgs e)
		{
			if(cbAbono.Checked == true){
				txtRecuperado.Enabled = true;
			}else{
				txtRecuperado.Enabled = false;
				txtRecuperado.Text = txtFaltante.Text;
			}
		}
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked == true){
				txtUbica.Text = "";
				txtUbica.Enabled = false;
			}else{
				txtUbica.Enabled = true;
			}
		}
		#endregion
	}
}
