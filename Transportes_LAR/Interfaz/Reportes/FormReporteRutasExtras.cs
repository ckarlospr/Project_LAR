using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{	
	public partial class FormReporteRutasExtras : Form
	{		
		#region INSTANCIAS		
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Reportes.SQL_Reportes connr = new Conexion_Servidor.Reportes.SQL_Reportes();
		Interfaz.FormPrincipal principal = null;
		
		#endregion
		
		#region CONTRUCTOR		
		public FormReporteRutasExtras(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}		
		#endregion				
		
		#region INICIO Y FIN		
		void FormReporteRutasExtrasLoad(object sender, EventArgs e)
		{
			adaptador();
		}
				
		void FormReporteRutasExtrasFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.reporteRutaExtra=false;
		}
		#endregion
		
		#region ADAPTADOR		
		public void adaptador()
		{			
			ColoresAlternadosRows(dgRutas);
			int contador = 0; 
			dgRutas.Rows.Clear();			
			String sentencia = @"select R.id, C.Empresa, C.SubNombre, O.NOMBRE, R.Nombre RUTA, R.Turno, R.Sentido, Kilometros, R.HoraInicio, R.Dia, R.TIPO, HORA_LLEGADA , R.foranea, R.VELADA 
								from Cliente C, RUTA R , ORDEN_EMPRESAS O where O.ID=C.ID_ORDEN and C.ID=R.IdSubEmpresa
 								and (R.TIPO='EXT' or R.TIPO='DOM') and r.extra between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtFin.Value.ToString("yyyy-MM-dd")+"'  order by C.Empresa, R.Nombre";
				
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgRutas.Rows.Add(conn.leer["id"].ToString(), conn.leer["NOMBRE"].ToString(), conn.leer["RUTA"].ToString(), conn.leer["Turno"].ToString(), conn.leer["Sentido"].ToString(),  conn.leer["TIPO"].ToString(), conn.leer["Kilometros"].ToString(), conn.leer["HoraInicio"].ToString(), conn.leer["HORA_LLEGADA"].ToString(), conn.leer["foranea"].ToString(), conn.leer["VELADA"].ToString());
					
				++contador;
			}
			conn.conexion.Close();					
			dgRutas.ClearSelection();
			txtContador.Text = contador.ToString();
		}
		#endregion
		
		#region EVENTO DE DATATIEPICKER
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			adaptador();
		}
		
		void DtFinValueChanged(object sender, EventArgs e)
		{
			adaptador();
		}
		#endregion
		
		#region BOTONES	
		void CmdGuardarClick(object sender, EventArgs e)
		{			
			int bandera = 0;
			for(int x=0; x<dgRutas.Rows.Count; x++){
				try
				{			
					if(dgRutas[8,x].Value.ToString()!=null && dgRutas[8,x].Value.ToString()!="")
					{
						String consul = "update RUTA set Kilometros='"+dgRutas[6,x].Value.ToString()+"', HoraInicio='"+dgRutas[7,x].Value.ToString()+"', HORA_LLEGADA='"+dgRutas[8,x].Value.ToString()+"' , foranea='"+dgRutas[9,x].Value.ToString()+"' , VELADA='"+dgRutas[10,x].Value.ToString()+"' where ID="+dgRutas[0,x].Value.ToString();
						conn.getAbrirConexion(consul); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();
						bandera = 1;						
					}
				}
				catch(Exception)
				{					
				}
			}
			if(bandera == 1){
				connr.auditoriaRuta(principal.idUsuario, "Extra");
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se actualizaron los datos");
				mensaje.Show();
			}			
			adaptador();
		}
		#endregion
		
		#region VALIDACION DE DATAGRID
		void DgRutasEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress -= new KeyPressEventHandler(Proceso.ValidarCampo.solo0y1);
			if (dgRutas.CurrentCell.ColumnIndex == 9 || dgRutas.CurrentCell.ColumnIndex == 10) //Desired Column
	        {		    
	            TextBox tb = e.Control as TextBox;
	            if (tb != null)
	            {
	            	tb.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.solo0y1);
	            	tb.MaxLength = 1;
	            }
    		}					 
		}
		
		public int banderaa = 0;
		
		void DgRutasCellLeave(object sender, DataGridViewCellEventArgs e)
		{			
			banderaa = 0;
		}
		
		void DgRutasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			banderaa = 0;
		}
		
		void DgRutasKeyPress(object sender, KeyPressEventArgs e)
		{
			if(dgRutas.CurrentCell.ColumnIndex == 7 || dgRutas.CurrentCell.ColumnIndex == 8){
				if(Char.IsNumber(e.KeyChar)){
					if(banderaa == 0){
						if(Convert.ToInt16(e.KeyChar.ToString()) < 3){
							dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = e.KeyChar.ToString();
						}else if(Convert.ToInt16(e.KeyChar.ToString()) > 2){
							dgRutas.CurrentRow.Cells[dgRutas.CurrentCell.ColumnIndex].Value = "0"+e.KeyChar.ToString();
						}
						banderaa = 1;
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
					banderaa=0;
				}
			}else{
				e.Handled = true;
			}
		}
		#endregion
		
		#region METODOS
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		#endregion		
	}
}
