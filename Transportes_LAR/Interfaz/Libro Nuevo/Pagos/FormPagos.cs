using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormPagos : Form
	{
		#region CONSTRUCTOR
		public FormPagos(FormPagoCobroEspecial refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
			id_usuario = refPrincipal.id_usuario;
			id_re = refPrincipal.id_re;
		}
		#endregion
		
		#region INSTANCIAS
		private FormPagoCobroEspecial refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN
		void FormPagosLoad(object sender, EventArgs e)
		{			
			this.txtCantidad.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			
			int vehiculosP = 0;
			for(int x=0; x<refPrincipal.dgDatos.Rows.Count; x++){
				if(refPrincipal.dgDatos[7,x].Value.ToString()=="NO")
					vehiculosP++;
			}
			
			txtCantidad.Text = (Convert.ToDouble(refPrincipal.txtSaldo.Text) / vehiculosP).ToString();
			
			if(refPrincipal.txtSaldo.Text == "0" || refPrincipal.txtSaldo.Text == "0.0" || refPrincipal.txtSaldo.Text == "0.00")
				txtCantidad.Text = "0";
		}
		#endregion
		
		#region VARIABLES
		Int32 id_usuario;
		Int32 id_re;
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{
			double anticipo_total = Convert.ToDouble(txtCantidad.Text) * refPrincipal.dgDatos.SelectedRows.Count;
			if(anticipo_total <= Convert.ToDouble(refPrincipal.txtSaldo.Text)){
				for(int x=0; x<refPrincipal.dgDatos.Rows.Count; x++){
					if(refPrincipal.dgDatos[2,x].Selected == true && refPrincipal.dgDatos[7,x].Value.ToString()=="NO"){
						if(Convert.ToDouble(txtCantidad.Text) <= Convert.ToDouble(refPrincipal.dgDatos[5,x].Value)){					
						// ***************************************************** REVISA DUPLICADO **********************************************************
							bool ingresa = true;
							String consult = "select * from ANTICIPOS_ESPECIALES where ID_COBRO = "+refPrincipal.dgDatos[0,x].Value.ToString();
							conn.getAbrirConexion(consult);
							conn.leer=conn.comando.ExecuteReader();
							if(conn.leer.Read()){
								ingresa = false;
							}						
							conn.conexion.Close();
							// *********************************************************************************************************************************
							// *********************************************************************************************************************************
							// *********************************************************************************************************************************
							
								if(txtCantidad.Text != "0" || txtCantidad.Text != "0.0" || txtCantidad.Text != "0.00"){
									if(ingresa == true){
										String sentencia = "";
										if(rbEfectivo.Checked == true)
											sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+id_re+", '"+txtCantidad.Text+"', '"+txtComprobantePago.Text+"', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+id_usuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', 'EFECTIVO', 'N/A', 'PAGO', '', '"+refPrincipal.dgDatos[0,x].Value.ToString()+"') ";
										else
											sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+id_re+", '"+txtCantidad.Text+"', '"+txtComprobantePago.Text+"', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+id_usuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', 'DEPOSITO', 'N/A', 'PAGO', '"+txtNumero.Text+"', '"+refPrincipal.dgDatos[0,x].Value.ToString()+"')";
																		
										conn.getAbrirConexion(sentencia);
										conn.comando.ExecuteNonQuery();
										conn.conexion.Close();
										new Conexion_Servidor.Libros.SQL_Libros().pagoEspecial(refPrincipal.dgDatos[0,x].Value.ToString());
										refPrincipal.realizado = true;
										sumaAnticipos(x);							
									}
								}else{
									if(refPrincipal.txtSaldo.Text == "0" || refPrincipal.txtSaldo.Text == "0.0"  || refPrincipal.txtSaldo.Text == "0.00" ){
										new Conexion_Servidor.Libros.SQL_Libros().pagoEspecial(refPrincipal.dgDatos[0,x].Value.ToString());
										refPrincipal.realizado = true;
									}else{
										DialogResult respuesta = MessageBox.Show("Se paga el servicio con un precio de 0 Pesos ¿Deseas continuar?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
										if(respuesta == DialogResult.Yes){
											new Conexion_Servidor.Libros.SQL_Libros().pagoEspecial(refPrincipal.dgDatos[0,x].Value.ToString());
											refPrincipal.realizado = true;
										}	
									}													
								}
							
						}else{
							MessageBox.Show("Error, no puedes ingresar una cantidad de pago mayor al saldo del vehículo", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
				this.Close();
			}else{
				MessageBox.Show("Error, Al sumar el pago de los vehículos seleccionados suma una cantidad mayor al saldo del servicio", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion
		
		#region METODOS
		public void sumaAnticipos(int x){
			if(rbEfectivo.Checked == true){
				refPrincipal.txtAnticipo.Text = (Convert.ToDouble(refPrincipal.txtAnticipo.Text) + Convert.ToDouble(txtCantidad.Text)).ToString();
				refPrincipal.refpagos.dgRelacion[14, refPrincipal.refpagos.dgRelacion.CurrentRow.Index].Value =
					(Convert.ToDouble(refPrincipal.refpagos.dgRelacion[14, refPrincipal.refpagos.dgRelacion.CurrentRow.Index].Value) + Convert.ToDouble(refPrincipal.dgDatos[5,x].Value)).ToString();
			}else{
				refPrincipal.txtAnticipo.Text = (Convert.ToDouble(refPrincipal.txtAnticipo.Text) + Convert.ToDouble(txtCantidad.Text)).ToString();
				refPrincipal.refpagos.dgRelacion[13, refPrincipal.refpagos.dgRelacion.CurrentRow.Index].Value =
					(Convert.ToDouble(refPrincipal.refpagos.dgRelacion[13, refPrincipal.refpagos.dgRelacion.CurrentRow.Index].Value) + Convert.ToDouble(refPrincipal.dgDatos[5,x].Value)).ToString();
			}
		}
		#endregion
		
		#region EVENTOS
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked == true){
				txtNumero.Text = "";
				txtNumero.Enabled = false;
			}
		}
		
		void RbDepositoCheckedChanged(object sender, EventArgs e)
		{
			if(rbDeposito.Checked == true){
				txtNumero.Enabled = true;
			}
		}		
		#endregion			
	}
}
