
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Unidad
{
	public partial class FormPlacasRevision : Form
	{		
		#region CONSTRUCTOR
		public FormPlacasRevision(FormPrincipal refPrinc)
		{
			InitializeComponent();
			formPrincipal = refPrinc;
			id_usuario = refPrinc.idUsuario;		
		}
		#endregion		
		
		#region VARIABLES
		public Int32 id_usuario;	
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal formPrincipal;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN
		void FormPlacasRevisionLoad(object sender, EventArgs e)
		{
			dtpIncio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;
			
			txtVehiculo.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Numero from VEHICULO", "Numero");
           	txtVehiculo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtVehiculo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
			filtros();
		}		
		
		void FormPlacasRevisionFormClosing(object sender, FormClosingEventArgs e)
		{
			formPrincipal.placasRevision = false;
		}
		#endregion
		
		#region FILTROS	
		public void filtros(){
			string consulta = "";			
			consulta = @"select md.id idmas, o.Alias, a.id, v.Numero, v.Placa_Estatal, v.Placa_Federal, a.ID_O, a.ID_V, a.FECHA_REG, md.PLACAS_AUTORIZACION, md.TIPO_PLACAS, 
					md.PLACA_ESTATUS, md.PLACA_REVISION, md.PLACA_REVISION from AUTORIZACION a join MAS_DATOS_AUTORIZACION md on md.ID_A = a.ID join VEHICULO v 
					on v.ID = a.ID_V join OPERADOR o on o.ID = a.ID_O where a.ESTATUS != '0' and v.Numero like '%"+txtVehiculo.Text+"%' ";			
			if(cbTodos.Checked == true)
				consulta += " and FECHA_REG between '"+dtpIncio.Value.ToString("yyyy-MM-dd")+"' and '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			else
				consulta += " and md.PLACA_ESTATUS = 'INCORRECTO' and PLACA_REVISION = 'NO' ";
			
			adaptador(consulta);				
		}
		#endregion		
		
		#region ADAPTADOR
		public void adaptador(string consulta){
			dgDatos.Rows.Clear();					
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();		
			while(conn.leer.Read()){
				dgDatos.Rows.Add(conn.leer["id"].ToString(),
				                 conn.leer["ID_V"].ToString(),
				                 conn.leer["Numero"].ToString(),
				                 "",
				                 conn.leer["Placa_Estatal"].ToString(),
				                 conn.leer["Placa_Federal"].ToString(),
				                 conn.leer["Alias"].ToString(),
				                 conn.leer["FECHA_REG"].ToString(),
				                 conn.leer["TIPO_PLACAS"].ToString(),
				                 conn.leer["PLACAS_AUTORIZACION"].ToString(),			                
				                 conn.leer["PLACA_ESTATUS"].ToString(),
				                // conn.leer["PLACA_REVISION"].ToString(),
				                 (( conn.leer["PLACA_ESTATUS"].ToString() == "INCORRECTO" )? conn.leer["PLACA_REVISION"].ToString() : "N/A"),
				                 conn.leer["idmas"].ToString());
			}
			conn.conexion.Close();
			datosCompleta();
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region METODOS
		public void datosCompleta(){
			for(int x=0; x<dgDatos.Rows.Count; x++){
				String consulta = @"select o.Alias from VEHICULO v join ASIGNACIONUNIDAD A on a.ID_UNIDAD = v.ID join OPERADOR o on o.ID = a.ID_OPERADOR 
								where v.id = "+dgDatos[1,x].Value.ToString()+" group by O.alias";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					dgDatos[3,x].Value = conn.leer["Alias"].ToString();
				conn.conexion.Close();
				
				try{
					consulta = "select PLACA_ACTUAL from VEHICULOS_PERIODOS where ID_VEHICULO = "+dgDatos[1,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						if(conn.leer["PLACA_ACTUAL"].ToString().Equals("E")){
							dgDatos[4,x].Style.BackColor = Color.LightGreen;
							dgDatos[5,x].Style.BackColor = Color.White;
						}else if(conn.leer["PLACA_ACTUAL"].ToString().Equals("F")){
							dgDatos[5,x].Style.BackColor = Color.LightGreen;
							dgDatos[4,x].Style.BackColor = Color.White;
						}else{
							dgDatos[4,x].Style.BackColor = Color.White;
							dgDatos[5,x].Style.BackColor = Color.White;
						}
					}else{
						dgDatos[4,x].Style.BackColor = Color.White;
						dgDatos[5,x].Style.BackColor = Color.White;
					}					
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener las placas de la unidad: "+ex.Message, "Error de Placas", MessageBoxButtons.OK, MessageBoxIcon.Error);
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}
		}
		#endregion
		
		#region EVENTOS
		void CbTodosCheckedChanged(object sender, EventArgs e)
		{
			if(cbTodos.Checked){
				dtpIncio.Enabled = true;
				dtpFin.Enabled = true;
			}else{		
				dtpIncio.Enabled = false;
				dtpFin.Enabled = false;
			}
		}
		
		void FormPlacasRevisionKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}		
		#endregion
				
		#region BOTONES		
		void BntBuscarClick(object sender, EventArgs e)
		{
			filtros();
		}		
		#endregion
				
		void DgDatosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string consulta = "";
			/*
			if( e.RowIndex > -1 (e.ColumnIndex == 4 || e.ColumnIndex == 5)){
				if(dgDatos[10, e.RowIndex].Value.ToString() == "NO" && dgDatos[9, e.RowIndex].Value.ToString() == "INCORRECTO"){
					if(dgDatos[8, e.RowIndex].Value.ToString() == "E" || dgDatos[8, e.RowIndex].Value.ToString() == "F" ){
						if(e.ColumnIndex == 4){
							
						}
						consulta = "update ANTICIPOS_ESPECIALES set ESTATUS='1', ID_U='"+id_usuario+"', FECHA_CONFIRMADO = (SELECT CONVERT (DATE, SYSDATETIME())) where ID="+dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
			}*/
			
			if( e.RowIndex > -1 && e.ColumnIndex == 11){
				if(dgDatos[11, e.RowIndex].Value.ToString() == "NO" && dgDatos[10, e.RowIndex].Value.ToString() == "INCORRECTO"){
					consulta = "update MAS_DATOS_AUTORIZACION set PLACA_REVISION = 'SI' where id = "+dgDatos[12,e.RowIndex].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					dgDatos[11, e.RowIndex].Value = "SI";
					filtros();
				}
			}
			
		}
	}
}
