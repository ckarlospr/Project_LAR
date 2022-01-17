using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
public partial class FormIncobrable : Form
	{
		#region CONSTRUCTOR		
		public FormIncobrable(PrivilegiosPagos refP, Int32 id_u, Int64 id_r)
		{
			InitializeComponent();
			refPrincipal = refP;
			id_usuario = id_u;
			id_re = id_r;
		}
		#endregion
				
		#region VALIRABLES
		Int32 id_usuario;
		Int64 id_re;
		#endregion
		
		#region INSTANCIAS		
		private PrivilegiosPagos refPrincipal;
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
		
		#region INICIO - FIN
		void FormIncobrableLoad(object sender, EventArgs e)
		{
			validacionCampos();
			cargaDatos();
		}
		#endregion
		
		#region METODOS
		private void cargaDatos(){			
			txtDestino.Text = refPrincipal.dgRelacion[5, refPrincipal.dgRelacion.CurrentRow.Index].Value.ToString();
			txtImporte.Text = refPrincipal.dgRelacion[15, refPrincipal.dgRelacion.CurrentRow.Index].Value.ToString();
		}
		
		private void validacionCampos()
		{
			this.txtRecuperado.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			this.txtCanEfect.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			this.txtCantDeposito.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		
		private void calculaMonto(){
			if(txtCanEfect.Text.Length <= 0)
				txtCanEfect.Text = "0";			
			if(txtCantDeposito.Text.Length <= 0)
				txtCantDeposito.Text = "0";
			
			txtRecuperado.Text = (Convert.ToDouble(txtCanEfect.Text) + Convert.ToDouble(txtCantDeposito.Text)).ToString();
			txtmontoPerdido.Text = (Convert.ToDouble(txtImporte.Text) - Convert.ToDouble(txtRecuperado.Text)).ToString();
		}
		
		private void servicioIncobrable(){			
			DialogResult respuesta = MessageBox.Show("El servicio se pondra en estatus INCOBRABLE y PAGADO ¿Deseas continuar?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(respuesta == DialogResult.Yes){				
				if(connL.IncibrableServicio(id_re, txtRecuperado.Text, txtCanEfect.Text, txtCantDeposito.Text, txtComentario.Text, id_usuario, txtmontoPerdido.Text)){
					refPrincipal.dgRelacion.Rows.RemoveAt(refPrincipal.dgRelacion.CurrentRow.Index);
					refPrincipal.dgRelacion.ClearSelection();
					MessageBox.Show("El servicio esta en estatus INCOBRABLE y se PAGO corretamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}else{					
					MessageBox.Show("Ocurrio un error avisa a sistemas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		#endregion
		
		#region EVENTOS		
		void TxtCanEfectTextChanged(object sender, EventArgs e)
		{
			calculaMonto();
		}
		
		void TxtCantDepositoTextChanged(object sender, EventArgs e)
		{
			calculaMonto();			
		}		
		#endregion
		
		#region BOTONES
		void CmdAceptarClick(object sender, EventArgs e)
		{
			if(txtComentario.Text.Length > 0){
				if(Convert.ToDouble(txtmontoPerdido.Text) >= 0){					
					servicioIncobrable();
				}else{					
					errorProvider1.Clear();
					errorProvider1.SetError(txtmontoPerdido, "El monto perdido no debe de ser negativo");
	        		txtCanEfect.Focus();
				}					
			}else{
				errorProvider1.Clear();
				errorProvider1.SetError(txtComentario, "Ingresa el comentario");
        		txtComentario.Focus();
			}			
		}
		#endregion
	}
}
