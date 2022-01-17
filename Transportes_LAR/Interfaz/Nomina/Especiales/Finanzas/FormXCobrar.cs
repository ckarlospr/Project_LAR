using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	public partial class FormXCobrar : Form
	{
		public FormXCobrar(String id_re, FormReporte rep)
		{
			InitializeComponent();
			refReporte=rep;
			ID=id_re;
		}
		
		#region VARIABLES
		String ID;
		String consulta;
		#endregion
		
		#region INSTANCIAS
		FormReporte refReporte;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region EVENTO LOAD
		void FormXCobrarLoad(object sender, EventArgs e)
		{
			getDatos();
			getCargarValidacionCampos(this);
			
			txtUbica.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select UBICA dato from ANTICIPOS_ESPECIALES");
			txtUbica.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtUbica.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region GETDATOS
		void getDatos()
		{
			consulta = "select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.OP_COBRA, C.TIPO from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and C.ESTATUS='1' AND C.ID_RE="+ID;
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgCobros.Rows.Add(conn.leer["IDCC"].ToString(), conn.leer["ID_RE"].ToString(), conn.leer["ALIAS"].ToString(), conn.leer["NUMERO"].ToString(), conn.leer["SALDO"].ToString(), ((conn.leer["PAGO"].ToString()=="1")?"SI":"NO"), conn.leer["OBSERVACIONES"].ToString(), conn.leer["TIPO_VIAJE"].ToString(), conn.leer["OP_COBRA"].ToString(), conn.leer["TIPO"].ToString());
			}
			
			conn.conexion.Close();
			
			dgCobros.ClearSelection();
			
			for(int x=0; x<dgCobros.Rows.Count; x++)
			{
				if(dgCobros[5,x].Value.ToString()=="SI")
					dgCobros[5,x].Style.BackColor=Color.MediumSpringGreen;
				
				if(dgCobros[7,x].Value.ToString()=="C. PUNTO")
					dgCobros[4,x].Style.BackColor=Color.Red;
				
				if(dgCobros[2,x].Value.ToString()=="ADMVO")
				{
					String consultOpera = "select O.Alias from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and V.Numero='"+dgCobros[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consultOpera);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgCobros[2,x].Value=conn.leer["Alias"].ToString();
					}
					
					conn.conexion.Close();
				}
			}
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CmdPagadoClick(object sender, EventArgs e)
		{
			if(dgCobros.SelectedRows.Count>0)
			{
				if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
				{
					MessageBox.Show("Servicio ya pagado.");
				}
				else
				{
					if(dgCobros[9,dgCobros.CurrentRow.Index].Value.ToString()=="PAGADO" || dgCobros[4,dgCobros.CurrentRow.Index].Value.ToString()=="0.00")
					{
						
					}
					else
					{
						pago();
					}
					
					new Conexion_Servidor.Libros.SQL_Libros().pagoEsp2(dgCobros[0,dgCobros.CurrentRow.Index].Value.ToString());
					
					dgCobros[5,dgCobros.CurrentRow.Index].Value="SI";
					dgCobros[5,dgCobros.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					
					if(dgCobros[5,dgCobros.CurrentRow.Index].Style.BackColor.Name!="MediumSpringGreen")
					{
						refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value=(Convert.ToDouble(refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value)-Convert.ToDouble(dgCobros[4,dgCobros.CurrentRow.Index].Value)).ToString();
						refReporte.dgReporte[11,refReporte.dgReporte.CurrentRow.Index].Value=(Convert.ToDouble(refReporte.dgReporte[11,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(dgCobros[4,dgCobros.CurrentRow.Index].Value)).ToString();
					}
					
					if(rbDeposito.Checked==true)
						refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value=dgCobros[4,dgCobros.CurrentRow.Index].Value.ToString();
					else
						refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value=dgCobros[4,dgCobros.CurrentRow.Index].Value.ToString();
					
					
					refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value);//+Convert.ToDouble(refReporte.dgReporte[11,refReporte.dgReporte.CurrentRow.Index].Value);
					refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value)-Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value);
					
					if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
					{
						refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
					}
					
					if(Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value)==Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value) && refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Red")
						refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					else if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name=="Red" && refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
						refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					
					
					dgCobros.ClearSelection();
				}
			}
			else
			{
				MessageBox.Show("Seleccione un registro.");
			}
		}
		#endregion
		
		#region TIPO DE PAGO
		void RbDepositoCheckedChanged(object sender, EventArgs e)
		{
			if(rbDeposito.Checked==true)
			{
				txtNumero.Enabled=true;
				txtUbica.Enabled=true;
			}
			else
			{
				txtUbica.Text="";
				txtUbica.Enabled=false;
			}
		}
		
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			/*if(rbEfectivo.Checked==true)
			{
				txtUbica.Text="";
				txtUbica.Enabled=false;
			}*/
		}
		#endregion
		
		void pago()
		{
			// ***************************************************** REVISA DUPLICADO **********************************************************
			// *********************************************************************************************************************************
			// *********************************************************************************************************************************
			
			bool ingresa = true;
			double CANTIDAD = 0.0;
			double PRECIO = 0.0;
			double FACTURADO = 0.0;
			
			double ENTRADO = 0.0;
			
			String consult = "select * from ANTICIPOS_ESPECIALES where ID_COBRO="+dgCobros[0,dgCobros.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consult);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ingresa = false;
			}
			
			conn.conexion.Close();
			
			consult = "select CANT_UNIDADES, PRECIO, FACTURADO from RUTA_ESPECIAL where ID_RE="+refReporte.dgReporte[0,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consult);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				CANTIDAD = Convert.ToDouble(conn.leer["CANT_UNIDADES"]);
				PRECIO = Convert.ToDouble(conn.leer["PRECIO"]);
				FACTURADO = ((conn.leer["FACTURADO"].ToString()!="0")?1.16:1.0);
			}
			
			conn.conexion.Close();
			
			consult = "select * from ANTICIPOS_ESPECIALES where ID_RE="+refReporte.dgReporte[0,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consult);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				ENTRADO = ENTRADO + Convert.ToDouble(conn.leer["CANTIDAD"]);
			}
			
			conn.conexion.Close();
			
			if(Convert.ToDouble(dgCobros[4,dgCobros.CurrentRow.Index].Value)>((CANTIDAD*PRECIO*FACTURADO)-ENTRADO))
			{
				ingresa = false;
			}
			
			// *********************************************************************************************************************************
			// *********************************************************************************************************************************
			// *********************************************************************************************************************************
			
			if(ingresa==true)
			{
				if(rbEfectivo.Checked==true)
				{
					String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+refReporte.dgReporte[0,refReporte.dgReporte.CurrentRow.Index].Value.ToString()+", '"+dgCobros[4,dgCobros.CurrentRow.Index].Value.ToString()+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refReporte.refPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', 'EFECTIVO', 'N/A', 'PAGO', 'N/A', '"+dgCobros[0,dgCobros.CurrentRow.Index].Value.ToString()+"') ";
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				else
				{
					String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+refReporte.dgReporte[0,refReporte.dgReporte.CurrentRow.Index].Value.ToString()+", '"+dgCobros[4,dgCobros.CurrentRow.Index].Value.ToString()+"', '"+txtNumero.Text+"', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refReporte.refPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', 'DEPOSITO', 'N/A', 'PAGO', '"+txtNumero.Text+"', '"+dgCobros[0,dgCobros.CurrentRow.Index].Value.ToString()+"') ";
					
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
			}
		}
		
		void DgCobrosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex==-1)
			{
				gbPago.Enabled=false;
				gbDinero.Enabled=false;
				gbCambio.Enabled=false;
				dgCobros.ClearSelection();
			}
			else
			{
				gbPago.Enabled=true;
				gbDinero.Enabled=true;
				gbCambio.Enabled=true;
				txtCambio.Text=dgCobros[4,dgCobros.CurrentRow.Index].Value.ToString();
			}
		}
		
		void CmdAplicaClick(object sender, EventArgs e)
		{
			if(dgCobros.SelectedRows.Count>0)
			{
				if(dgCobros[5,dgCobros.CurrentRow.Index].Value.ToString()=="SI")
				{
					MessageBox.Show("Servicio ya pagado.");
				}
				else
				{
					String sentencia = "update COBRO_ESPECIAL set PAGO='1', SALDO='0' where ID='"+dgCobros[0,dgCobros.CurrentRow.Index].Value.ToString()+"'";
					
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					dgCobros[5,dgCobros.CurrentRow.Index].Value="SI";
					dgCobros[5,dgCobros.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
				}
			}
		}
		
		void TxtCambioLeave(object sender, EventArgs e)
		{
			if(txtCambio.Text=="")
			{
				txtCambio.Text="0";
			}
		}
		
		#region VALIDACION
		void getCargarValidacionCampos(FormXCobrar formRef)
		{
			formRef.txtCambio.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
		
		void CmdCambioClick(object sender, EventArgs e)
		{
			if(dgCobros.SelectedRows.Count>0)
			{
				if(dgCobros[5,dgCobros.CurrentRow.Index].Value.ToString()=="SI")
				{
					MessageBox.Show("No se puede modificar.");
				}
				else
				{
					String sentencia = "update COBRO_ESPECIAL set SALDO='"+txtCambio.Text+"' where ID='"+dgCobros[0,dgCobros.CurrentRow.Index].Value.ToString()+"'";
					
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					dgCobros[4,dgCobros.CurrentRow.Index].Value=txtCambio.Text;
					//refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value=(Convert.ToDouble(refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value)-Convert.ToDouble(dgCobros[4,dgCobros.CurrentRow.Index].Value)).ToString();
				}
			}
		}
	}
}
