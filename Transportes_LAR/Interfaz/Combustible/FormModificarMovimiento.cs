using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormModificarMovimiento : Form
	{
	
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private FormCompCombustible formComplementos;
		#endregion
		
		#region VARIABLES
		string id_Movimiento;
		#endregion
		
		#region CONSTRUCTOR
		public FormModificarMovimiento(FormCompCombustible refPrincipal, string idM)
		{
			InitializeComponent();
			formComplementos = refPrincipal;
			id_Movimiento = idM;
		}
		#endregion
		
		#region INICIO - FIN		
		void FormModificarMovimientoLoad(object sender, EventArgs e)
		{			
			cargaDatos();
		}
		#endregion	
		
		#region BOTONES
		void BtnGuardaClick(object sender, EventArgs e)
		{
			if(txtMovimientoNuevo.BackColor == Color.LightGreen){
				if(modificaNombre()){
					for( int x=0; x < formComplementos.dgPuntosMuertos.ColumnCount; x++){
						if(formComplementos.dgPuntosMuertos.Columns[x].HeaderText.ToString().Equals(txtMovimiento.Text))
							formComplementos.dgPuntosMuertos.Columns[x].HeaderText = txtMovimientoNuevo.Text;						
					}
					formComplementos.dgPuntosMuertos[1, formComplementos.dgPuntosMuertos.CurrentRow.Index].Value = txtMovimientoNuevo.Text;
					MessageBox.Show("Se guardó correctamenta la modificación", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
		}
		#endregion
		
		#region EVENTOS		
		void TxtMovimientoNuevoTextChanged(object sender, EventArgs e)
		{
			validaMovimiento();
			if(txtMovimientoNuevo.Text.Length == 0)
				txtMovimientoNuevo.BackColor = Color.White;
		}
		#endregion
		
		#region METODOS
		private void cargaDatos(){
			string consulta = @"select * from RELACION_UBICACION where id = "+id_Movimiento;
			
			try{
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					cmbTipo.Text = conn.leer["TIPO"].ToString();
					txtMovimiento.Text = conn.leer["NOMBRE"].ToString();
				}
				conn.conexion.Close();
			}catch(Exception){		
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
		}
		
		private void validaMovimiento(){
			string consulta = @"select * from RELACION_UBICACION where id != "+id_Movimiento+" and ESTATUS = '1' and NOMBRE = '"+txtMovimientoNuevo.Text.Trim()+"'";
			try{
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					txtMovimientoNuevo.BackColor = Color.Red;
					btnGuarda.Enabled = false;
				}else{
					txtMovimientoNuevo.BackColor = Color.LightGreen;
					btnGuarda.Enabled = true;
				}
				conn.conexion.Close();
			}catch(Exception){
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
		}
		
		private bool modificaNombre(){
			bool respuesta = true;
			string consulta = @"update RELACION_UBICACION set nombre = '"+txtMovimientoNuevo.Text.Trim()+"' where id = "+id_Movimiento;			
			try{
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				respuesta = true;
			}catch(Exception){
				respuesta = false;
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			return respuesta;
		}
		#endregion				
	}
}
