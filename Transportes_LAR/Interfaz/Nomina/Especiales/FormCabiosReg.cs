using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormCabiosReg : Form
	{
		public FormCabiosReg(int fila, FormCuentasEsp refCuent, int cant)
		{
			InitializeComponent();
			FILA=fila;
			refCuentas=refCuent;
			cantidad=cant;
		}
		
		#region VARIABLES
		int FILA;
		int cantidad=0;
		#endregion
		
		#region INSTANCIA
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		FormCuentasEsp refCuentas;
		#endregion
		
		#region EVENTO LOAD
		void FormCabiosRegLoad(object sender, EventArgs e)
		{
			txtDestino.Text = refCuentas.dgRelacion[6,FILA].Value.ToString();
			getDatos();
			
			txtUbica.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select UBICA dato from ANTICIPOS_ESPECIALES");
			txtUbica.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtUbica.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region GETDATOS
		void getDatos()
		{
			String consulta = "Select * from RUTA_ESPECIAL where ID_RE="+refCuentas.dgRelacion[0,FILA].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			//int x=0;
			while(conn.leer.Read())
			{
				//txtSaldo.Text=conn.leer["PRECIO"].ToString();
				//cantidad=Convert.ToInt16(conn.leer["CANT_UNIDADES"]);
				if(conn.leer["FACTURADO"].ToString()!="0")
				{
					txtTotal_p.Text=((Convert.ToDouble(conn.leer["PRECIO"])*Convert.ToDouble(conn.leer["CANT_UNIDADES"]))*1.16).ToString();
					txtSaldo.Text=((Convert.ToDouble(conn.leer["PRECIO"]))*1.16).ToString();
				}
				else
				{
					txtTotal_p.Text=(Convert.ToDecimal(conn.leer["PRECIO"])*Convert.ToDecimal(conn.leer["CANT_UNIDADES"])).ToString();
					txtSaldo.Text=(Convert.ToDecimal(conn.leer["PRECIO"])).ToString();
				}
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		#region VALIDACION Y CALCULO DE DATOS
		void TxtRecibidoKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!(Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar==46 && !(txtRecibido.Text.Contains(".")))))
			{
				e.Handled=true;	
			}
		}
		
		void TxtRecibidoKeyUp(object sender, KeyEventArgs e)
		{
			if(txtRecibido.Text=="")
			{
				txtTotal_R.Text="0.00";
			}
			else
			{
				txtTotal_R.Text=(Convert.ToDouble(txtRecibido.Text)*cantidad).ToString();
			}
		}
		
		void TxtTotal_RKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!(Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar==46 && !(txtRecibido.Text.Contains(".")))))
			{
				e.Handled=true;	
			}
		}
		
		void TxtTotal_RKeyUp(object sender, KeyEventArgs e)
		{
			if(txtTotal_R.Text=="")
			{
				txtRecibido.Text="0.00";
			}
			else
			{
				txtRecibido.Text=(Convert.ToDouble(txtTotal_R.Text)/cantidad).ToString();
			}
		}
		
		void TxtRecibidoLeave(object sender, EventArgs e)
		{
			if(txtRecibido.Text=="")
			{
				txtRecibido.Text="0.00";
			}
			else 
			{
				if(Convert.ToDouble(txtRecibido.Text)>Convert.ToDouble(txtSaldo.Text))
				{
					MessageBox.Show("La cantidad es invalida");
					txtRecibido.Focus();
				}
			}
		}
		#endregion
		
		#region ABONO
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked==true)
			{
				txtUbica.Text="";
				txtUbica.Enabled=false;
			}
			else
			{
				txtUbica.Enabled=true;
			}
		}
		
		
		void CmdGuardaAbonoClick(object sender, EventArgs e)
		{
			if(txtComentario.Text!="" && txtComentario.Text!="Comentario...")
			{
				if(Convert.ToDouble(txtRecibido.Text)<=Convert.ToDouble(txtSaldo.Text))
				{
					string tipo="";
					
					if(rbEfectivo.Checked==true)
						tipo="EFECTIVO";
					else if(rbDeposito.Checked==true)
						tipo="DEPOSITO";
					
					for(int x=0; x<refCuentas.dgRelacion.Rows.Count; x++)
					{
						if(refCuentas.dgRelacion.Rows[x].Selected==true)
						{
							String senten = "update COBRO_ESPECIAL set SALDO='"+(Convert.ToDouble(refCuentas.dgRelacion[5,x].Value)-Convert.ToDouble(txtRecibido.Text))+"', OBSERVACIONES='"+txtComentario.Text+"' where ID="+refCuentas.dgRelacion[16,x].Value.ToString();
							conn.getAbrirConexion(senten);
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
						}
					}
					
					String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+refCuentas.dgRelacion[0,FILA].Value.ToString()+", '"+txtTotal_R.Text+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refCuentas.formPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', '"+tipo+"', '"+txtComentario.Text+"', 'ABONO', '"+txtUbica.Text+"', '"+refCuentas.dgRelacion[16,FILA].Value.ToString()+"') ";
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
							
					setDatos();
					Close();
				}
				else
				{
					MessageBox.Show("La cantidad recuperada que ingreso no es correcta");
					txtRecibido.SelectAll();
				}
			}
			else
			{
				MessageBox.Show("Ingrese en comentarios la razon.");
				txtComentario.SelectAll();
			}
		}
		
		void setDatos()
		{
			for(int x=0; x<refCuentas.dgRelacion.Rows.Count; x++)
			{
				if(refCuentas.dgRelacion.Rows[x].Selected==true)
				{
					refCuentas.dgRelacion[5,x].Value=(Convert.ToDouble(refCuentas.dgRelacion[5,x].Value)-Convert.ToDouble(txtRecibido.Text)).ToString();
				}
			}
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdGuardarClick(object sender, EventArgs e)
		{
			/*if(valida()==true)
			{*/
				String sentencia = "update COBRO_ESPECIAL set SALDO='"+txtNuevoPrecio.Text+"', OBSERVACIONES='"+txtNuevoComent.Text+"' where ID="+refCuentas.dgRelacion[16,FILA].Value.ToString();
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				refCuentas.dgRelacion[5,FILA].Value=txtNuevoPrecio.Text;
				this.Close();
			//}
		}
		
		bool valida()
		{
			bool respuesta=false;
			
			if(txtRecibido.Text!="")
			{
				if(Convert.ToDouble(txtNuevoPrecio.Text)<Convert.ToDouble(txtTotal_p.Text) && txtNuevoPrecio.Text!="0")
				{
					if(txtComentario.Text!="")
					{
						respuesta=true;
					}
					else
					{
						MessageBox.Show("Para completar el cambio es necesario comentar la razon del mismo.");
					}
				}
				else
				{
					MessageBox.Show("Monto recibido invalido");
				}
			}
			else
			{
				MessageBox.Show("Ingrese monto recibido.");
			}
			
			return respuesta;
		}
		#endregion
	}
}
