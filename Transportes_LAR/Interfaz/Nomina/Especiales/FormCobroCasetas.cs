using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormCobroCasetas : Form
	{
		public FormCobroCasetas(Int64 id_re, Int64 id_o, String alias)
		{
			InitializeComponent();
			ID_RE=id_re;
			ID_O=id_o;
			Alias=alias;
		}
		
		#region VARIABLES
		Int64 ID_RE;
		String tipo="TICKET";
		Int64 ID_O=0;
		String Alias="";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		FormCuentasEsp refCuentas;
		#endregion
		
		#region EVENTO LOAD
		void FormCobroCasetasLoad(object sender, EventArgs e)
		{
			dtFecha.Value=DateTime.Now;
			getDatos();
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(Convert.ToDouble(txtCantidad.Text)<=Convert.ToDouble(refCuentas.dgRelacion[19,refCuentas.dgRelacion.CurrentRow.Index].Value))
			{
				String miconsult="insert into COBRO_CASETAS values ('"+ID_RE+"', '"+ID_O+"', '"+tipo+"', '"+txtCantidad.Text+"', '"+dtFecha.Value.ToString("dd/MM/yyyy")+"', '"+refCuentas.formPrincipal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())))";
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				miconsult="update RUTA_ESPECIAL set C_CASETAS=(select SUM(cantidad) from COBRO_CASETAS where id_re="+ID_RE+") where ID_RE="+ID_RE;
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				agregaDatagrid();
			}
			else
			{
				MessageBox.Show("Error en la cantidad.");
			}
		}
		#endregion
		
		#region EVECTOS RADIO BUTTONS
		void RbTicketCheckedChanged(object sender, EventArgs e)
		{
			if(rbTicket.Checked==true)
				tipo="TICKET";
		}
		
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked==true)
				tipo="EFECTIVO";
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			String consulta = "SELECT * FROM COBRO_CASETAS WHERE ID_O="+ID_O+" and ID_RE="+ID_RE;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgCobros.Rows.Add(conn.leer["ID"].ToString(), conn.leer["TIPO"].ToString(), conn.leer["CANTIDAD"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10));
			}
			
			conn.conexion.Close();
			
			dgCobros.ClearSelection();
			
			consulta = "SELECT * FROM OPERADOR WHERE Estatus='1' AND tipo_empleado='OPERADOR' order by alias ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgOperador.Rows.Add(conn.leer["ID"].ToString(), conn.leer["ALIAS"].ToString());
			}
			
			conn.conexion.Close();
			
			dgOperador.ClearSelection();
			
			txtOperador.Text=Alias;
			busqueda(Alias);
		}
		#endregion
		
		#region EVENTOS TXTCANTIDAD
		void TxtCantidadKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || ((e.KeyChar==46) && !txtCantidad.Text.Contains(".")))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		#endregion
		
		void agregaDatagrid()
		{
			dgCobros.Rows.Add("", tipo, txtCantidad.Text, dtFecha.Value.ToString("dd/MM/yyyy"));
			refCuentas.dgRelacion[19,refCuentas.dgRelacion.CurrentRow.Index].Value=(Convert.ToDouble(refCuentas.dgRelacion[19,refCuentas.dgRelacion.CurrentRow.Index].Value)-Convert.ToDouble(txtCantidad.Text)).ToString();
			dtFecha.Value=DateTime.Now;
			txtCantidad.Text="";
			rbTicket.Checked=true;
		}
		
		#region EVENTOS TXTOPERADOR
		void TxtOperadorKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Return)
			{
				busqueda(txtOperador.Text);
			}
		}
		
		void busqueda(String Op)
		{
			bool encuentra=false;
			int dato=0;
			for(int x=0; x<dgOperador.Rows.Count; x++)
			{
				if(dgOperador[1,x].Value.ToString()==Op)
				{
					encuentra=true;
					dato=x;
					ID_O=Convert.ToInt64(dgOperador[0,x].Value);
				}
			}
			
			if(encuentra==true)
			{
				dgOperador.Rows[dato].Selected=true;
				dgOperador.FirstDisplayedCell = dgOperador.Rows[dato].Cells[1];
				cmdAgregar.Enabled=true;
			}
		}
		#endregion
		
		#region CELCLICK DGOPERADOR
		void DgOperadorCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				txtOperador.Text=dgOperador[1,dgOperador.CurrentRow.Index].Value.ToString();
				ID_O=Convert.ToInt64(dgOperador[0,dgOperador.CurrentRow.Index].Value);
			}
		}
		#endregion
	}
}
