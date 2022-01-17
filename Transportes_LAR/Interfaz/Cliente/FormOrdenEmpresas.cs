using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Cliente
{
	public partial class FormOrdenEmpresas : Form
	{
		public FormOrdenEmpresas()
		{
			InitializeComponent();
		}
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormOrdenEmpresasLoad(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			conn.getAbrirConexion("select ID, NOMBRE from ORDEN_EMPRESAS order by NOMBRE");
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(),conn.leer["NOMBRE"].ToString());
			}
			
			conn.conexion.Close();
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region SELECCION DE DATOS
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				cmdGuardar.Enabled=true;
				gbDias.Enabled=true;
				gbTurnos.Enabled=true;
				getDatosSeleccion(Convert.ToInt64(dgDatos[0,dgDatos.CurrentRow.Index].Value));
			}
		}
		
		void DgDatosKeyUp(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter){
				if(dgDatos.Rows.Count>0)
				{
					getDatosSeleccion(Convert.ToInt64(dgDatos[0,dgDatos.CurrentRow.Index].Value));
				}
			}
		}
		
		void getDatosSeleccion(Int64 ID)
		{
			conn.getAbrirConexion("select * from ORDEN_EMPRESAS where ID!=37 and ID="+ID);
			conn.leer=conn.comando.ExecuteReader();
			
			if(conn.leer.Read())
			{
				if(conn.leer["T1"].ToString()=="1")
					cbMa.Checked=true;
				else
					cbMa.Checked=false;
					
				if(conn.leer["T2"].ToString()=="1")
					cbMe.Checked=true;
				else
					cbMe.Checked=false;
						
				if(conn.leer["T3"].ToString()=="1")
					cbVe.Checked=true;
				else
					cbVe.Checked=false;
							
				if(conn.leer["T4"].ToString()=="1")
					cbNo.Checked=true;
				else
					cbNo.Checked=false;			
				
				if(conn.leer["LU"].ToString()=="1")
					cbLunes.Checked=true;
				else
					cbLunes.Checked=false;
									
				if(conn.leer["MA"].ToString()=="1")
					cbMartes.Checked=true;
				else
					cbMartes.Checked=false;
										
				if(conn.leer["MI"].ToString()=="1")
					cbMiercoles.Checked=true;
				else
					cbMiercoles.Checked=false;
											
				if(conn.leer["JU"].ToString()=="1")
					cbJueves.Checked=true;
				else
					cbJueves.Checked=false;
												
				if(conn.leer["VI"].ToString()=="1")
					cbViernes.Checked=true;
				else
					cbViernes.Checked=false;
													
				if(conn.leer["SA"].ToString()=="1")
					cbSabado.Checked=true;
				else
					cbSabado.Checked=false;
														
				if(conn.leer["DO"].ToString()=="1")
					cbDomingo.Checked=true;
				else
					cbDomingo.Checked=false;				
			}
			else
			{
				cbMa.Checked=false;
				cbMe.Checked=false;
				cbVe.Checked=false;
				cbNo.Checked=false;			
				
				cbLunes.Checked=false;
				cbMartes.Checked=false;
				cbMiercoles.Checked=false;
				cbJueves.Checked=false;
				cbViernes.Checked=false;
				cbSabado.Checked=false;
				cbDomingo.Checked=false;
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		#region GUARDADO DE DATOS
		void CmdGuardarClick(object sender, EventArgs e)
		{
			guardaDatos();
		}
		
		void guardaDatos()
		{
			String miconsult="update ORDEN_EMPRESAS set T1='"+((cbMa.Checked==true)?1:0)+"', T2='"+((cbMe.Checked==true)?1:0)+"', T3='"+((cbVe.Checked==true)?1:0)+"', T4='"+((cbNo.Checked==true)?1:0)+"', LU='"+((cbLunes.Checked==true)?1:0)+"', MA='"+((cbMartes.Checked==true)?1:0)+"', MI='"+((cbMiercoles.Checked==true)?1:0)+"', JU='"+((cbJueves.Checked==true)?1:0)+"', VI='"+((cbViernes.Checked==true)?1:0)+"', SA='"+((cbSabado.Checked==true)?1:0)+"', DO='"+((cbDomingo.Checked==true)?1:0)+"' where ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();	//
			conn.getAbrirConexion(miconsult);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron guardados correctamente");
			mensaje.Show();
		}
		#endregion
	}
}
