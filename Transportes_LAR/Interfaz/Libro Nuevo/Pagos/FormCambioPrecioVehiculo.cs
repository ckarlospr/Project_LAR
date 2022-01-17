using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormCambioPrecioVehiculo : Form
	{
		#region CONSTRUCTOR
		public FormCambioPrecioVehiculo(FormPagoCobroEspecial referencia)
		{
			InitializeComponent();
			refpagos = referencia;
		}
		#endregion
		
		#region INSTANCIAS
		public FormPagoCobroEspecial refpagos;		
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN
		void FormCambioPrecioVehiculoLoad(object sender, EventArgs e)
		{			
			this.txtNuevoPrecio.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			obtenerDatos();
		}
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtNuevoPrecio.Text != ""){
				if(txtNuevoComent.Text != ""){
					guarda();
				}else{
					MessageBox.Show("Ingresa el comentario ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}				
			}else{
				MessageBox.Show("Ingresa el nuevo precio ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion
		
		#region METODOS
		public void obtenerDatos(){
			txtDestino.Text = refpagos.txtDestino.Text;
			txtSaldo.Text = refpagos.dgDatos[5, refpagos.dgDatos.CurrentRow.Index].Value.ToString();
			txtTotal_p.Text = refpagos.txtPrecioP.Text;
		}
		
		public void guarda(){			
			conn.getAbrirConexion("INSERT INTO AUDITORIA_GENERAL  VALUES('UPDATE', 'Actualizo EL COSTO DEL VEHICULO QUE ANTES COSTABA : "+txtSaldo.Text+", ID COBRO ESPECIAL "+refpagos.dgDatos[0,refpagos.dgDatos.CurrentRow.Index].Value.ToString()
			                      +", ID_RE: "+refpagos.id_re+"', (SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+refpagos.id_usuario+", 'COBRO_ESPECIAL')");
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			String sentencia = "update COBRO_ESPECIAL set SALDO = '"+txtNuevoPrecio.Text+"', OBSERVACIONES='"+txtNuevoComent.Text+"' where ID = "+refpagos.dgDatos[0,refpagos.dgDatos.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
						
			refpagos.dgDatos[5,refpagos.dgDatos.CurrentRow.Index].Value = txtNuevoPrecio.Text;
			refpagos.txtPrecioP.Text = "0";
			for(int x = 0; x<refpagos.dgDatos.Rows.Count; x++){
				refpagos.txtPrecioP.Text = (Convert.ToDouble(refpagos.txtPrecioP.Text) + Convert.ToDouble(refpagos.dgDatos[5,x].Value.ToString())).ToString();
			}
			refpagos.txtSaldo.Text = (Convert.ToDouble(refpagos.txtPrecioP.Text) - Convert.ToDouble(refpagos.txtAnticipo.Text)).ToString();
			
			sentencia = @"select SUM(SALDO) AS COSTO from COBRO_ESPECIAL where ID_RE = "+refpagos.refpagos.dgRelacion[0,refpagos.refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				refpagos.refpagos.dgRelacion[12,refpagos.refpagos.dgRelacion.CurrentRow.Index].Value = conn.leer["COSTO"].ToString();
			}
			refpagos.refpagos.dgRelacion[15,refpagos.refpagos.dgRelacion.CurrentRow.Index].Value = (Convert.ToDouble(refpagos.refpagos.dgRelacion[12,refpagos.refpagos.dgRelacion.CurrentRow.Index].Value) -
			                                                                                        (Convert.ToDouble(refpagos.refpagos.dgRelacion[13,refpagos.refpagos.dgRelacion.CurrentRow.Index].Value) +
			                                                                                         Convert.ToDouble(refpagos.refpagos.dgRelacion[14,refpagos.refpagos.dgRelacion.CurrentRow.Index].Value))).ToString();
			conn.conexion.Close();
				MessageBox.Show("Se guardo correctamente el nuevo precio ","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}
		#endregion

		#region EVENTOS		
		void TxtNuevoPrecioTextChanged(object sender, EventArgs e)
		{
			if(txtNuevoPrecio.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtNuevoPrecioEnter(object sender, EventArgs e)
		{			
			if(txtNuevoPrecio.Text.Contains("."))
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtNuevoPrecioLeave(object sender, EventArgs e)
		{
			Proceso.ValidarCampo.punto = false;
		}		
		#endregion
	}
}
