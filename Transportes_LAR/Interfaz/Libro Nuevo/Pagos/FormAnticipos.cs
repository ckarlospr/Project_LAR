using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class Anticipos : Form
	{
		#region CONSTRUCTOS
		public Anticipos(String id_re, PrivilegiosPagos rep, int tipo)
		{
			InitializeComponent();
			refReporte = rep;
			ID = id_re;
			TIPO = tipo;
		}
		
		public Anticipos(String id_re, Libro_Nuevo.Validacion_Final.FormValidarServicios rep, int tipo)
		{
			InitializeComponent();
			redValidacion = rep;
			ID = id_re;
			TIPO = tipo;
		}
		#endregion
		
		#region VARIABLES
		String ID;
		int TIPO;
		String consulta;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		PrivilegiosPagos refReporte;
		Libro_Nuevo.Validacion_Final.FormValidarServicios  redValidacion;
		#endregion
		
		#region EVENTO INICIO
		void FormAnticiposLoad(object sender, EventArgs e)
		{
			if(TIPO == 1){
				consulta="select ID, CANTIDAD, NUMERO, FECHA, ESTATUS, ID_U, ETIQUETA, cometario from ANTICIPOS_ESPECIALES where TIPO!='DEPOSITO' and ID_RE = "+ID;
			}else{
				lblTitulo.Text = "Pagos Depositados";
				consulta = "select ID, CANTIDAD, NUMERO, FECHA, ESTATUS, ID_U, ETIQUETA, cometario from ANTICIPOS_ESPECIALES where TIPO='DEPOSITO' and ID_RE = "+ID;
			}
			getDatos();
		}
		#endregion
		
		#region GETDATOS
		void getDatos()
		{
			Double suma = 0.0;			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(), 
				                 conn.leer["FECHA"].ToString().Substring(0,10),
				                 conn.leer["CANTIDAD"].ToString(), 
				                 conn.leer["NUMERO"].ToString(), 
				                 ((conn.leer["ESTATUS"].ToString()=="0")?"NO":"SI"), 
				                 "NULL", 
				                 conn.leer["ID_U"].ToString(),
				                 conn.leer["ETIQUETA"].ToString(), 
				                 conn.leer["cometario"].ToString());
			}
			conn.conexion.Close();
			
			for(int x=0;  x<dgDatos.Rows.Count; x++){
				if(dgDatos[6,x].Value.ToString()!=""){
					string cons="select usuario from usuario where id_usuario = "+dgDatos[6,x].Value.ToString();
					conn.getAbrirConexion(cons);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgDatos[5,x].Value=conn.leer["usuario"].ToString().ToUpper();
					}else{
						dgDatos[5,x].Value="NULL";
					}
					conn.conexion.Close();
					
					if(dgDatos[4,x].Value.ToString() == "SI")	{
						dgDatos[5,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
				
				if(dgDatos[4,x].Value.ToString() == "SI")
					dgDatos[2,x].Style.BackColor = Color.MediumSpringGreen;
				
				suma = suma+Convert.ToDouble(dgDatos[2,x].Value);
			}			
			txtTotal.Text = suma.ToString("C");
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CmdModificarClick(object sender, EventArgs e)
		{
			if(dgDatos.SelectedRows.Count == 1 && cmbTipo.Text != ""){				
				try{
					String sentencia = "UPDATE ANTICIPOS_ESPECIALES set FECHA = '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', TIPO = '"+cmbTipo.Text+"' WHERE ID = "+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();			
					dgDatos[1,dgDatos.CurrentRow.Index].Value=dtpFecha.Value.ToString("dd/MM/yyyy");
					if(refReporte != null){
						if(cmbTipo.SelectedIndex == 0){
							refReporte.dgRelacion[13, refReporte.dgRelacion.CurrentRow.Index].Value = "0";
							refReporte.dgRelacion[14, refReporte.dgRelacion.CurrentRow.Index].Value = dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString();
						}else{
							refReporte.dgRelacion[14, refReporte.dgRelacion.CurrentRow.Index].Value = "0";
							refReporte.dgRelacion[13, refReporte.dgRelacion.CurrentRow.Index].Value = dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString();
						}
					}else{
						if(cmbTipo.SelectedIndex == 0){
							redValidacion.dgReporte[13, redValidacion.dgReporte.CurrentRow.Index].Value = "0";
							redValidacion.dgReporte[14, redValidacion.dgReporte.CurrentRow.Index].Value = dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString();
						}else{
							redValidacion.dgReporte[14, redValidacion.dgReporte.CurrentRow.Index].Value = "0";
							redValidacion.dgReporte[13, redValidacion.dgReporte.CurrentRow.Index].Value = dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString();
						}
					}
					
					MessageBox.Show("Se modifico correctamente el anticipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}catch(Exception ex){
					MessageBox.Show("Error al modificar el anticipo :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}else{				
				MessageBox.Show("Selecciona un anticipo a modificar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion
		
		#region EVENTOS		
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			dtpFecha.Value=Convert.ToDateTime(dgDatos[1,e.RowIndex].Value.ToString());
			
			if(TIPO == 1)
				cmbTipo.SelectedIndex = 0;
			else				
				cmbTipo.SelectedIndex =	1;			
		}
		#endregion
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			int id_uus = 0;
			if(refReporte != null){
				id_uus = refReporte.id_usuario;
			}else{
				id_uus = redValidacion.refPrincipal.idUsuario;
			}
			
			if(dgDatos.SelectedRows.Count == 1){
			   if(id_uus==15 || id_uus==118 || id_uus==119){
					//MessageBox.Show("eliminado");
					
					String sentencia = "insert into ANTICIPOS_ESPECIALES_ELIMINADOS values ('"+ID+"','"+dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString()+"','"+dgDatos[3,dgDatos.CurrentRow.Index].Value.ToString()+"','"+dgDatos[1,dgDatos.CurrentRow.Index].Value.ToString()+"','1','"+dgDatos[6,dgDatos.CurrentRow.Index].Value.ToString()+"',getdate(),"+((TIPO == 1)?"'EFECTIVO'":"'DEPOSITO'")+",'"+dgDatos[8,dgDatos.CurrentRow.Index].Value.ToString()+" Deleted by id_user="+id_uus+" ','"+dgDatos[7,dgDatos.CurrentRow.Index].Value.ToString()+"','', null)";
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					sentencia = "delete from ANTICIPOS_ESPECIALES where ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					Double suma=0.0;
					for(int x=0;  x<dgDatos.Rows.Count; x++){
						suma = suma+Convert.ToDouble(dgDatos[2,x].Value);
					}
					txtTotal.Text = suma.ToString("C");
					dgDatos.Rows.RemoveAt(dgDatos.CurrentRow.Index);
					dgDatos.ClearSelection();
				}else{
					MessageBox.Show("Ususario sin premisos de eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}else{				
				MessageBox.Show("Selecciona un anticipo a eliminar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		void CmdRegresarClick(object sender, EventArgs e)
		{
			int id_uus = 0;
			if(refReporte != null){
				id_uus = refReporte.id_usuario;
			}else{
				id_uus = redValidacion.refPrincipal.idUsuario;
			}
			
			if(dgDatos.SelectedRows.Count == 1){
			   if(id_uus==15 || id_uus==118 || id_uus==119){
					
					String sentencia = "Update ANTICIPOS_ESPECIALES set ESTATUS=0 where ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					Double suma=0.0;
					for(int x=0;  x<dgDatos.Rows.Count; x++){
						suma = suma+Convert.ToDouble(dgDatos[2,x].Value);
					}
					txtTotal.Text = suma.ToString("C");
					dgDatos.Rows.RemoveAt(dgDatos.CurrentRow.Index);
					dgDatos.ClearSelection();
				}else{
					MessageBox.Show("Ususario sin premisos de regresa", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}else{				
				MessageBox.Show("Selecciona un anticipo a regresar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}
	}
}
