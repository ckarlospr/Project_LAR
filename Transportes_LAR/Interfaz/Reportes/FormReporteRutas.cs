using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormReporteRutas : Form
	{
		#region CONSTRUCTO
		public FormReporteRutas(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();			
			this.principal=principal;
		}
		#endregion		
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Reportes.SQL_Reportes connr = new Conexion_Servidor.Reportes.SQL_Reportes();
		#endregion
		
		#region INICIO
		void FormReporteRutasLoad(object sender, EventArgs e)
		{
			cargaInicio();
		}
		#endregion
		
		#region ADAPTADOR
		public void getDatos()
		{			
			ColoresAlternadosRows(dgRutas);
			dgRutas.Rows.Clear();
			
			String sentencia = @"select R.id, C.Empresa, C.SubNombre, O.NOMBRE, R.Nombre RUTA, R.Turno, R.Sentido, Kilometros, R.HoraInicio, R.Dia, R.TIPO, 
								HORA_LLEGADA, R.foranea, R.VELADA  from Cliente C, RUTA R , ORDEN_EMPRESAS O where O.ID=C.ID_ORDEN and C.ID=R.IdSubEmpresa
								 and (R.TIPO='NRM' or R.TIPO='DIF' or R.TIPO='VL' or R.TIPO='RI') and R.Dia!='10000000' and R.Dia!='1000000' ";			
			if(cbEmpresa.SelectedIndex != -1)
				sentencia = sentencia + " and c.empresa = '"+cbEmpresa.Text+"' ";
			if(cbTurno.SelectedIndex != -1 )
				sentencia = sentencia + "and r.turno = '"+cbTurno.Text+"' ";
			
			sentencia = sentencia + " order by C.Empresa, R.Nombre";
			
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgRutas.Rows.Add(conn.leer["id"].ToString(), 
				                 conn.leer["NOMBRE"].ToString(), 
				                 conn.leer["RUTA"].ToString(), 
				                 conn.leer["Turno"].ToString(), 
				                 conn.leer["Sentido"].ToString(), 
				                 conn.leer["Kilometros"].ToString(), 
				                 conn.leer["HoraInicio"].ToString(), 
				                 conn.leer["HORA_LLEGADA"].ToString(), 
				                 conn.leer["foranea"].ToString(), 
				                 conn.leer["VELADA"].ToString());
			}
			conn.conexion.Close();			
			dgRutas.ClearSelection();
		}
		#endregion
		
		#region BOTONES		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			int bandera = 0;
			for(int x=0; x<dgRutas.Rows.Count; x++){
				try{
					if(dgRutas[7,x].Value.ToString() != null && dgRutas[7,x].Value.ToString() != ""){
						String consul = "update RUTA set Kilometros='"+dgRutas[5,x].Value.ToString()+"',  HoraInicio='"+dgRutas[6,x].Value.ToString()+"', HORA_LLEGADA='"+dgRutas[7,x].Value.ToString()+"', foranea='"+dgRutas[8,x].Value.ToString()+"', VELADA='"+dgRutas[9,x].Value.ToString()+"' where ID="+dgRutas[0,x].Value.ToString();
						conn.getAbrirConexion(consul); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();	
						bandera = 1;	
					}
				}catch(Exception){					
				}
			}
			
			if(bandera == 1){
				connr.auditoriaRuta(principal.idUsuario, "Normal");
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se actualizaron los datos");
				mensaje.Show();
				getDatos();
			}
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			getDatos();
		}				
		#endregion
		
		#region VALIDACION DE DATAGRID		
		void DgRutasEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{			
			e.Control.KeyPress -= new KeyPressEventHandler(Proceso.ValidarCampo.solo0y1);
			if (dgRutas.CurrentCell.ColumnIndex == 8 || dgRutas.CurrentCell.ColumnIndex == 9){
		            TextBox tb = e.Control as TextBox;
		            if (tb != null){
		            	tb.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.solo0y1);
		            	tb.MaxLength = 1;		            	
		            }
        		}				
		}
		#endregion
		
		#region METODOS
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		
		private void cargaInicio(){		
			string consulta = "SELECT Empresa FROM Cliente GROUP BY Empresa order by empresa";
			cbEmpresa.Items.Clear();			
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				cbEmpresa.Items.Add(conn.leer["Empresa"].ToString());
			}
			conn.conexion.Close();
			cbEmpresa.Items.Add("");
			cbTurno.Items.Add("");
		}
		#endregion
		
		#region EVENTOS
		void CbEmpresaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbEmpresa.Text == "")
				cbEmpresa.SelectedIndex = -1;
		}
		
		void CbTurnoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbTurno.Text == "")
				cbTurno.SelectedIndex = -1;
		}
		
		public int bandera = 0;
		
		void DgRutasCellClick(object sender, DataGridViewCellEventArgs e)
		{			
			bandera = 0;
		}
		
		void DgRutasCellLeave(object sender, DataGridViewCellEventArgs e)
		{			
			bandera = 0;
		}
		
		void DgRutasKeyPress(object sender, KeyPressEventArgs e)
		{
			if(dgRutas.CurrentCell.ColumnIndex == 6 || dgRutas.CurrentCell.ColumnIndex == 7){
				if(Char.IsNumber(e.KeyChar)){
					if(bandera == 0){
						if(Convert.ToInt16(e.KeyChar.ToString()) < 3){
							dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = e.KeyChar.ToString();
						}else if(Convert.ToInt16(e.KeyChar.ToString()) > 2){
							dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = "0"+e.KeyChar.ToString();
						}
						bandera = 1;
					}else if(dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString().Length == 1){
						if(dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString() == "1" || dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString() == "0"){
							dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
						}else if(dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString() == "2" && Convert.ToInt16(e.KeyChar.ToString())<4){
							dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
						}else{
							e.Handled=true;
						}
					}else if(dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString().Length == 2 && Convert.ToInt16(e.KeyChar.ToString()) < 6){
						dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString()+":"+e.KeyChar.ToString();
					}else if(dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString().Length == 4){
						dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
					}
				}else if(e.KeyChar == (char)Keys.Back){
					dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = "";
					bandera=0;
				}
			}else{
				e.Handled = true;
			}
		}
		#endregion
	}
}
