using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormVacios : Form
	{
		public FormVacios(formPrincipalComb refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		formPrincipalComb refPrincipal;
		
		void FormVaciosLoad(object sender, EventArgs e)
		{
			txtTipo.AutoCompleteCustomSource = auto.AutoReconocimiento("select TIPO dato from RELACION_UBICACION where ESTATUS='1'");
			txtTipo.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtTipo.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtNombre.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from RELACION_UBICACION where ESTATUS='1'");
			txtNombre.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			if(refPrincipal.lblUltima.Text!="00/00/0000")
			{
				dtpFecha.Value=Convert.ToDateTime(refPrincipal.lblUltima.Text);
			}
			else
			{
				dtpFecha.Value=Convert.ToDateTime(refPrincipal.dgAutorizacionValida[4,0].Value);
			}
			
			getDatos();
		}
		
		void getDatos()
		{
			String consulta = "SELECT * FROM RELACION_UBICACION where ESTATUS='1' ORDER BY TIPO, NOMBRE";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgVacios.Rows.Add(conn.leer["ID"].ToString(), conn.leer["TIPO"].ToString(), conn.leer["NOMBRE"].ToString());
			}
			
			conn.conexion.Close();
			
			dgVacios.ClearSelection();
		}
		
		void getDatos2()
		{
			dgVacios.Rows.Clear();
			
			String consulta = "SELECT * FROM RELACION_UBICACION where ESTATUS='1' AND TIPO like '%"+txtTipo.Text+"%' and NOMBRE like '%"+txtNombre.Text+"%' ORDER BY TIPO, NOMBRE";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgVacios.Rows.Add(conn.leer["ID"].ToString(), conn.leer["TIPO"].ToString(), conn.leer["NOMBRE"].ToString());
			}
			
			conn.conexion.Close();
			
			dgVacios.ClearSelection();
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			for(int x=1; x<refPrincipal.dgValidado.Rows.Count-1; x++)
			{
				if(refPrincipal.dgValidado[0,x].Style.BackColor.Name!="Yellow")
				{
					String consult ="update RELACION_MOVIMIENTO set ORDEN='"+x+"' where ID="+refPrincipal.dgValidado[0,x].Value.ToString();
				
					conn.getAbrirConexion(consult); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
				}
			}
			
			refPrincipal.Valida(Convert.ToInt64(dgVacios[0,dgVacios.CurrentRow.Index].Value), Convert.ToInt64(refPrincipal.dgAutorizacionValida[11,refPrincipal.dgAutorizacionValida.CurrentRow.Index].Value), 
			                    ((dgVacios[1,dgVacios.CurrentRow.Index].Value.ToString() == "RUTA")? "VIAJE": dgVacios[1,dgVacios.CurrentRow.Index].Value.ToString() ), refPrincipal.txtComentario.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), "00:00");
			//refPrincipal.agregaValidado();
			refPrincipal.getValidado(Convert.ToInt64(refPrincipal.dgAutorizacionValida[11,0].Value), 3);
			//refPrincipal.getValidado(Convert.ToInt64(refPrincipal.dgAutorizacionValida[11,refPrincipal.dgAutorizacionValida.CurrentRow.Index].Value), 2);
			
			dgVacios.ClearSelection();
			
			for(int x=1; x<refPrincipal.dgValidado.Rows.Count-1; x++)
			{
				if(refPrincipal.dgValidado[0,x].Style.BackColor.Name!="Yellow")
				{
					String consult ="update RELACION_MOVIMIENTO set ORDEN='"+x+"' where ID="+refPrincipal.dgValidado[0,x].Value.ToString();
				
					conn.getAbrirConexion(consult); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
				}
			}
			
			//this.Close();
		}
		
		#region SELECCION FILTRO
		void TxtTipoKeyUp(object sender, KeyEventArgs e)
		{
			getDatos2();
			if(e.KeyCode.ToString()=="Return")
			{
				dgVacios.ClearSelection();
				
				for(int x=0; x<dgVacios.Rows.Count; x++)
				{
					if(txtTipo.Text==dgVacios[1,x].Value.ToString())
					{
						dgVacios.Rows[x].Selected = true;
						dgVacios.FirstDisplayedCell = dgVacios.Rows[x].Cells[1];
					}
				}
			}
		}
		
		void TxtNombreKeyUp(object sender, KeyEventArgs e)
		{
			getDatos2();
			if(e.KeyCode.ToString()=="Return")
			{
				dgVacios.ClearSelection();
				
				for(int x=0; x<dgVacios.Rows.Count; x++)
				{
					if(txtNombre.Text==dgVacios[2,x].Value.ToString())
					{
						dgVacios.Rows[x].Selected = true;
						dgVacios.FirstDisplayedCell = dgVacios.Rows[x].Cells[1];
					}
				}
			}
		}
		
		void TxtTipoEnter(object sender, EventArgs e)
		{
			/*dgVacios.ClearSelection();
				
			for(int x=0; x<dgVacios.Rows.Count; x++)
			{
				if(txtTipo.Text==dgVacios[1,x].Value.ToString())
				{
					dgVacios.Rows[x].Selected = true;
					dgVacios.FirstDisplayedCell = dgVacios.Rows[x].Cells[1];
				}
			}*/
		}
		
		void TxtNombreEnter(object sender, EventArgs e)
		{
			/*dgVacios.ClearSelection();
			
			for(int x=0; x<dgVacios.Rows.Count; x++)
			{
				if(txtNombre.Text==dgVacios[2,x].Value.ToString())
				{
					dgVacios.Rows[x].Selected = true;
					dgVacios.FirstDisplayedCell = dgVacios.Rows[x].Cells[1];
				}
			}*/
		}
		#endregion
	}
}
