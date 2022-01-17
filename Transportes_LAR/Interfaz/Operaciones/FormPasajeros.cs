using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormPasajeros : Form
	{
		#region COSTRUCTOR
		public FormPasajeros(FormPrincipal principal)
		{
			InitializeComponent();
			refPrincipal = principal;
		}
		#endregion
				
		#region INSTANCIAS
		private FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO -FIN
		void FormPasajerosLoad(object sender, EventArgs e)
		{
			cargaInicio();
		}
		
		void FormPasajerosFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.pasajeros = false;
		}
		#endregion
		
		#region METODOS
		private void cargaInicio(){
			cbES.Checked = true;
			
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
		
		private void adaptador(){			
			String sentencia = @"select o.llegada, o.id_operacion, c.Empresa, r.Nombre, r.Turno, r.Sentido, r.Kilometros, r.TIPO, r.HoraInicio, r.HORA_LLEGADA, o.pasajeros, op.Alias, o.fecha 
								from OPERACION o join ruta r on r.ID = o.id_ruta join Cliente c on r.IdSubEmpresa = c.ID join OPERACION_OPERADOR oo on oo.id_operacion = o.id_operacion
 								join OPERADOR op on op.ID = oo.id_operador where o.estatus !='0' and o.fecha between '"+dtpInicio.Value.ToShortDateString()+"' and '"+dtpFin.Value.ToShortDateString()+"' ";
				
			if(cbEmpresa.SelectedIndex != -1)
				sentencia = sentencia + " and c.empresa = '"+cbEmpresa.Text+"' ";
			if(cbTurno.SelectedIndex != -1 )
				sentencia = sentencia + "and r.turno = '"+cbTurno.Text+"' ";
			
			sentencia = sentencia + " order by c.Empresa, r.Turno";
			
			if(cbES.Checked == true)
				sentencia += " ,r.sentido ";
			else				
				sentencia += " , r.Nombre ";
			
			ColoresAlternadosRows(dgServicios);
			dgServicios.Rows.Clear();
			
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgServicios.Rows.Add(conn.leer["id_operacion"].ToString(),
				                     conn.leer["Empresa"].ToString(),
				                     conn.leer["Nombre"].ToString(),
				                     conn.leer["Sentido"].ToString(),
				                     conn.leer["Turno"].ToString(),
				                     conn.leer["Kilometros"].ToString(),
				                     conn.leer["HoraInicio"].ToString(),
				                     conn.leer["HORA_LLEGADA"].ToString(),
				                     conn.leer["TIPO"].ToString(),
				                     conn.leer["Alias"].ToString(),
				                     conn.leer["pasajeros"].ToString(),
				                     conn.leer["llegada"].ToString());				
			}
			conn.conexion.Close();
			dgServicios.ClearSelection();				
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		#endregion				
				
		#region EVENTOS
		public int bandera = 0;		
		void DgServiciosCellLeave(object sender, DataGridViewCellEventArgs e)
		{			
			bandera = 0;
		}
		
		void DgServiciosKeyPress(object sender, KeyPressEventArgs e)
		{
			if(dgServicios.CurrentCell.ColumnIndex == 11){
				if(Char.IsNumber(e.KeyChar)){
					if(bandera == 0){
						if(Convert.ToInt16(e.KeyChar.ToString()) < 3){
							dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value = e.KeyChar.ToString();
						}else if(Convert.ToInt16(e.KeyChar.ToString()) > 2){
							dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value = "0"+e.KeyChar.ToString();
						}
						bandera = 1;
					}else if(dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString().Length == 1){
						if(dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString() == "1" || dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString() == "0"){
							dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value = dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
						}else if(dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString() == "2" && Convert.ToInt16(e.KeyChar.ToString())<4){
							dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value = dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
						}else{
							e.Handled=true;
						}
					}else if(dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString().Length == 2 && Convert.ToInt16(e.KeyChar.ToString()) < 6){
						dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value = dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString()+":"+e.KeyChar.ToString();
					}else if(dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString().Length == 4){
						dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value = dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
					}
				}else if(e.KeyChar == (char)Keys.Back){
					dgServicios.CurrentRow.Cells[dgServicios.CurrentCell.ColumnIndex].Value = "";
					bandera=0;
				}
			}else{
				e.Handled = true;
			}
		}
		
		void DgServiciosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			bandera=0;
		}
		
		void DgServiciosEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress -= new KeyPressEventHandler(Proceso.ValidarCampo.solo0y1);
			if (dgServicios.CurrentCell.ColumnIndex == 10 ){
	            TextBox tb = e.Control as TextBox;
	            if (tb != null){
	            	tb.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
	            	tb.MaxLength = 2;		            	
	            }
        	}
		}
		
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
					
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			dtpFin.Value = dtpInicio.Value;
		}
		
		void DgServiciosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 12 && e.RowIndex >= 0)
  			{
				try{
					String consul = "update OPERACION set pasajeros = '"+dgServicios[10,e.RowIndex].Value.ToString()
									+"', llegada = '"+dgServicios[11,e.RowIndex].Value.ToString()+"' where id_operacion = "+dgServicios[0,e.RowIndex].Value.ToString();
					conn.getAbrirConexion(consul); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
					MessageBox.Show("Se modificó  correctamente los pasajeros del servicio", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);	
				}catch(Exception ex){
					MessageBox.Show("Error al modificar los pasajeros del servicio "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);				
				}				
			}
		}
		#endregion	
		
		#region BOTONES
		void BtnBuscarClick(object sender, EventArgs e)
		{
			adaptador();			
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{			
			int bandera = 0;
			for(int x=0; x<dgServicios.Rows.Count; x++){
				try{
					if(dgServicios[10,x].Value.ToString() != null && dgServicios[10,x].Value.ToString() != "")
					{
						String consul = "update OPERACION set pasajeros = '"+dgServicios[10,x].Value.ToString()+"', llegada = '"
										+dgServicios[11,x].Value.ToString()+"'  where id_operacion = "+dgServicios[0,x].Value.ToString();
						conn.getAbrirConexion(consul); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();	
						bandera = 1;	
					}
				}catch(Exception){
					bandera = 0;
					x = dgServicios.Rows.Count-1;
				}
			}			
			if(bandera == 1){
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se actualizaron los datos");
				mensaje.Show();
			}			
		}
		#endregion		
	}
}
