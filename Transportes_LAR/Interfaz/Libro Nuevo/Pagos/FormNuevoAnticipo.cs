using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormNuevoAnticipo : Form
	{
		#region VARIABLES
		Int32 id_usuario;
		Int32 id_re;
		#endregion
		
		#region CONSTRUCTOR
		public FormNuevoAnticipo(FormPagoCobroEspecial refpagoscob, Int32 id_usua, Int32 id_r)
		{
			InitializeComponent();
			id_usuario = id_usua;
			id_re = id_r;
			refPagosCopbro = refpagoscob;
		}
		#endregion
		
		#region INSTANCIAS
		FormPagoCobroEspecial refPagosCopbro  = null;		
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		#endregion
				
		#region INICIO - FIN
		void FormNuevoAnticipoLoad(object sender, EventArgs e)
		{
			cbTipoPago.SelectedIndex = 0;
			dtpFechaPago.Value = DateTime.Now;
			this.txtImportePago.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			obtenerDatos();
		} 
		#endregion
		
		#region METODOS
		public void obtenerDatos(){
			try{
				txtDestinoServicio.Text = refPagosCopbro.txtDestino.Text;
				txtImporteSevicio.Text = refPagosCopbro.txtPrecioP.Text;
				txtSaldo.Text = refPagosCopbro.txtSaldo.Text;
				txtImporteTotalPago.Text = "0";
				string consulta = "select * from ANTICIPOS_ESPECIALES  where id_re = "+id_re;
				dgPagos.Rows.Clear();	
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					dgPagos.Rows.Add(conn.leer["ID"].ToString(),
				                     Convert.ToDateTime(conn.leer["FECHA"].ToString().Substring(0,10)).ToShortDateString(),
						            "",//folio
						            conn.leer["CANTIDAD"].ToString(),
				                    conn.leer["TIPO"].ToString(),
				                    conn.leer["NUMERO"].ToString());						
					txtImporteTotalPago.Text = (Convert.ToInt32(txtImporteTotalPago.Text) + Convert.ToInt32(conn.leer["CANTIDAD"])).ToString();
				}
				conn.conexion.Close();			
			}catch(Exception ex){
				MessageBox.Show("Error: "+ex.Message);				
			}
			dgPagos.ClearSelection();			
		}
		
		public bool validacionCamposPagos(){
			bool respuesta = true;
							
			if(txtComprobantePago.Text == ""){
				errorProvider1.SetError(txtComprobantePago, "Captura el campo");
        		txtComprobantePago.Focus();
        		respuesta = false;
			}			
			if(txtImportePago.Text == ""){
				errorProvider1.SetError(txtImportePago, "Captura el campo");
        		txtImportePago.Focus();
        		respuesta = false;
			}			
			if(cbTipoPago.Text == ""){
				errorProvider1.SetError(cbTipoPago, "Captura el campo");
        		cbTipoPago.Focus();
        		respuesta = false;
			}
			if(Convert.ToDouble(txtSaldo.Text) < Convert.ToDouble(txtImportePago.Text)){
				errorProvider1.SetError(txtImportePago, "El importe no puede ser mayor al saldo del servicio");
        		txtImportePago.Focus();
        		respuesta = false;
			}			
			return respuesta;			
		}
		
		public void limpiarPagos(){			
			obtenerDatos();
			dgPagos.ClearSelection();
			dtpFechaPago.Value = DateTime.Now;			
			cbTipoPago.SelectedIndex = 0;
			txtComprobantePago.Text = "";
			txtImportePago.Text = "";
			txtComentario.Text = "";
		}
		
		public void cambiosSaldos(){
			refPagosCopbro.txtAnticipo.Text = (Convert.ToDouble(refPagosCopbro.txtAnticipo.Text) + Convert.ToDouble(txtImportePago.Text)).ToString();
			refPagosCopbro.txtSaldo.Text = (Convert.ToDouble(refPagosCopbro.txtPrecioP.Text) - Convert.ToDouble(refPagosCopbro.txtAnticipo.Text)).ToString();
			
			if(cbTipoPago.Text == "EFECTIVO")
				refPagosCopbro.refpagos.dgRelacion[14,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value =
					(Convert.ToDouble(refPagosCopbro.refpagos.dgRelacion[14,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value) + Convert.ToDouble(txtImportePago.Text));
			else
				refPagosCopbro.refpagos.dgRelacion[13,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value =
					(Convert.ToDouble(refPagosCopbro.refpagos.dgRelacion[13,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value) + Convert.ToDouble(txtImportePago.Text));
				
			
			refPagosCopbro.refpagos.dgRelacion[15,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value = (Convert.ToDouble(refPagosCopbro.refpagos.dgRelacion[12,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value) -
			                                                                                        (Convert.ToDouble(refPagosCopbro.refpagos.dgRelacion[13,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value) +
			                                                                                         Convert.ToDouble(refPagosCopbro.refpagos.dgRelacion[14,refPagosCopbro.refpagos.dgRelacion.CurrentRow.Index].Value))).ToString();	
		}
		
		#endregion
		
		#region BOTONES		
		void BtnGuardarPagoClick(object sender, EventArgs e)
		{					
			if(validacionCamposPagos()){
				DialogResult respuesta = MessageBox.Show("Al guardar este pago no se podrá modificar ¿Deseas continuar? ", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(respuesta == DialogResult.Yes){
					connL.insertarPago3(id_re, txtImportePago.Text, txtComprobantePago.Text, DateTime.Now.ToString("yyyy-MM-dd"), id_usuario.ToString(), dtpFechaPago.Value.ToString("yyyy-MM-dd"),
					                    ((cbTipoPago.Text == "EFECTIVO")? "EFECTIVO" : "DEPOSITO" ), txtComentario.Text, "ANTICIPO", txtubica.Text);
					cambiosSaldos();
					limpiarPagos();
				}
			}
		}		
		#endregion
		
		#region EVENTOS
		void CbTipoPagoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbTipoPago.SelectedIndex == 1){
				lblUbica.Visible = true;
				txtubica.Visible = true;
				txtubica.Text = "";				
			}else if(cbTipoPago.SelectedIndex == 2){
				lblUbica.Visible = true;
				txtubica.Visible = true;
				txtubica.Text = "";				
			}else{
				lblUbica.Visible = false;
				txtubica.Visible = false;	
				txtubica.Text = "N/A";			
			}
		}

		void TxtImportePagoEnter(object sender, EventArgs e)
		{
			if(txtImportePago.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtImportePagoLeave(object sender, EventArgs e)
		{
			Proceso.ValidarCampo.punto = false;
		}
		
		void TxtImportePagoTextChanged(object sender, EventArgs e)
		{			
			if(txtImportePago.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}		
		#endregion		
	}
}
