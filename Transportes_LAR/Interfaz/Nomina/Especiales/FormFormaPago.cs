using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormFormaPago : Form
	{
		public FormFormaPago(FormCuentasEsp refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		
		#region INSTANCIAS
		private FormCuentasEsp refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(refPrincipal.dgRelacion.SelectedRows.Count>0)
			{
				for(int x=0; x<refPrincipal.dgRelacion.Rows.Count; x++)
				{
					if(refPrincipal.dgRelacion[2,x].Selected==true && refPrincipal.dgRelacion[13,x].Value.ToString()=="NO" && refPrincipal.dgRelacion[15,x].Value.ToString()=="NO")
					{
						// ***************************************************** REVISA DUPLICADO **********************************************************
						// *********************************************************************************************************************************
						// *********************************************************************************************************************************
						
						bool ingresa = true;
						double CANTIDAD = 0.0;
						double PRECIO = 0.0;
						double FACTURADO = 0.0;
						
						double ENTRADO = 0.0;
						
						String consult = "select * from ANTICIPOS_ESPECIALES where ID_COBRO="+refPrincipal.dgRelacion[16,x].Value.ToString();
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							ingresa = false;
						}
						
						conn.conexion.Close();
						
						consult = "select CANT_UNIDADES, PRECIO, FACTURADO from RUTA_ESPECIAL where ID_RE="+refPrincipal.dgRelacion[0,refPrincipal.dgRelacion.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							CANTIDAD = Convert.ToDouble(conn.leer["CANT_UNIDADES"]);
							PRECIO = Convert.ToDouble(conn.leer["PRECIO"]);
							FACTURADO = ((conn.leer["FACTURADO"].ToString()!="0")?1.16:1.0);
						}
						
						conn.conexion.Close();
						
						consult = "select * from ANTICIPOS_ESPECIALES where ID_RE="+refPrincipal.dgRelacion[0,refPrincipal.dgRelacion.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							ENTRADO = ENTRADO + Convert.ToDouble(conn.leer["CANTIDAD"]);
						}
						
						conn.conexion.Close();
						//*********************
						if(Convert.ToDouble(refPrincipal.dgRelacion[5,refPrincipal.dgRelacion.CurrentRow.Index].Value) - 0.01 > ((CANTIDAD*PRECIO*FACTURADO)-ENTRADO))
						{
							ingresa = false;
						}
						
						// *********************************************************************************************************************************
						// *********************************************************************************************************************************
						// *********************************************************************************************************************************
						
						if(rbEfectivo.Checked==true)
						{
							if(refPrincipal.dgRelacion[1,x].Value.ToString()=="PAGADO" || refPrincipal.dgRelacion[1,x].Value.ToString()=="0.00")
							{
								
							}
							else
							{
								if(ingresa==true)
								{
									String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+refPrincipal.dgRelacion[0,x].Value.ToString()+", '"+refPrincipal.dgRelacion[5,x].Value.ToString()+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refPrincipal.formPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', 'EFECTIVO', 'N/A', 'PAGO', '', '"+refPrincipal.dgRelacion[16,x].Value.ToString()+"') ";
									conn.getAbrirConexion(sentencia);
									conn.comando.ExecuteNonQuery();
									conn.conexion.Close();
								}
							}
							
							new Conexion_Servidor.Libros.SQL_Libros().pagoEsp(refPrincipal.dgRelacion[10,x].Value.ToString());
							refPrincipal.realizado=true;
							this.Close();
						}
						else
						{
							if(refPrincipal.dgRelacion[1,x].Value.ToString()=="PAGADO" || refPrincipal.dgRelacion[1,x].Value.ToString()=="0.00")
							{
								
							}
							else
							{
								if(ingresa==true)
								{
									String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+refPrincipal.dgRelacion[0,x].Value.ToString()+", '"+refPrincipal.dgRelacion[5,x].Value.ToString()+"', '', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refPrincipal.formPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', 'DEPOSITO', 'N/A', 'PAGO', '"+txtNumero.Text+"', '"+refPrincipal.dgRelacion[16,x].Value.ToString()+"') ";
									conn.getAbrirConexion(sentencia);
									conn.comando.ExecuteNonQuery();
									conn.conexion.Close();
								}
							}
								
							new Conexion_Servidor.Libros.SQL_Libros().pagoEsp(refPrincipal.dgRelacion[10,x].Value.ToString());
							refPrincipal.realizado=true;
							this.Close();
							//}
						}
					}
				}
			}
		}
		#endregion
		
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked==true)
			{
				txtNumero.Text="";
				txtNumero.Enabled=false;
			}
		}
		
		void RbDepositoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked==true)
			{
				txtNumero.Enabled=true;
			}
		}
	}
}
