using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormZonasFuentes : Form
	{		
		#region VARIABLES
		Int32 id_u;
		Operador.Dato.Zonas objZona = null;
		Operador.Dato.Fuentes objFuente = null;
		#endregion
		
		#region CONSTRUCTOR
		public FormZonasFuentes(FormParametros refp, Int32 idU)
		{
			InitializeComponent();
			parametros = refp;
			id_u = idU;
		}	
		#endregion
		
		#region INSTANCIAS
		FormParametros parametros = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region INICIO - FIN
		void FormZonasFuentesLoad(object sender, EventArgs e)
		{			
			adaptador();			
			dgZonas.Sort(dgZonas.Columns[1], ListSortDirection.Ascending);
			dgFuentes.Sort(dgFuentes.Columns[1], ListSortDirection.Ascending);
			dgZonas.ClearSelection();
			dgFuentes.ClearSelection();
		}
		#endregion
				
		#region ADAPTADOR
		public void adaptador(){
			if(parametros.listZonas != null && parametros.listFuentes != null){
				for (int i = 0; i < parametros.listZonas.Count; i++)
					dgZonas.Rows.Add(parametros.listZonas[i].id, parametros.listZonas[i].nombre, parametros.listZonas[i].estatus);
				
				for (int i = 0; i < parametros.listFuentes.Count; i++)
					dgFuentes.Rows.Add(parametros.listFuentes[i].id, parametros.listFuentes[i].nombre, parametros.listFuentes[i].estatus);
			}else{
				try{	
					string sentencia = "SELECT * FROM PRE_OPERADOR_ZONAS_FUENTES WHERE TIPO = 'ZONA' and ESTATUS = 'Activo'";
					conn.getAbrirConexion(sentencia);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
						dgZonas.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString(), conn.leer["ESTATUS"].ToString());					
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener las zonas : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);		
					if(conn.conexion != null)
						conn.conexion.Close();
				}
							
				try{	
					string sentencia = "SELECT * FROM PRE_OPERADOR_ZONAS_FUENTES WHERE TIPO = 'FUENTE'";
					conn.getAbrirConexion(sentencia);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
						dgFuentes.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString(), conn.leer["ESTATUS"].ToString());					
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener las zonas : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}
			colorInactivos();
		}
		
		private void colorInactivos(){
			if(dgZonas.Rows.Count > 0){
				for(int x=0; x<dgZonas.Rows.Count; x++){
					if(dgZonas[2,x].Value.ToString().Equals("Inactivo")){
						for(int y=0; y<dgZonas.ColumnCount; y++)
							dgZonas[y,x].Style.BackColor = Color.Red;
					}
				}
			}
			
			if(dgFuentes.Rows.Count > 0){
				for(int x=0; x<dgFuentes.Rows.Count; x++){
					if(dgFuentes[2,x].Value.ToString().Equals("Inactivo")){
						for(int y=0; y<dgFuentes.ColumnCount; y++)
							dgFuentes[y,x].Style.BackColor = Color.Red;
					}				
				}
			}
		}
		#endregion
		
		#region BOTONES
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(parametros.listZonas != null)
				parametros.listZonas = null;
			parametros.listZonas = new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Zonas>();
					
			for(int x=0; x<dgZonas.Rows.Count; x++){
				objZona = new Operador.Dato.Zonas();
				objZona.id = dgZonas[0,x].Value.ToString();
				objZona.tipo = "ZONA";
				objZona.nombre = dgZonas[1,x].Value.ToString();
				objZona.estatus = dgZonas[2,x].Value.ToString();				
				parametros.listZonas.Add(objZona);
				objZona = null;
			}
			parametros.txtZona.Text = dgZonas.Rows.Count.ToString();
			
			if(parametros.listFuentes != null)
				parametros.listFuentes = null;
			parametros.listFuentes = new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Fuentes>();
			
			for(int x=0; x<dgFuentes.Rows.Count; x++){
				objFuente = new Operador.Dato.Fuentes();
				objFuente.id = dgFuentes[0,x].Value.ToString();
				objFuente.tipo = "FUENTE";
				objFuente.nombre = dgFuentes[1,x].Value.ToString();
				objFuente.estatus = dgFuentes[2,x].Value.ToString();
				parametros.listFuentes.Add(objFuente);
				objFuente = null;
			}
			parametros.txtFuente.Text = dgFuentes.Rows.Count.ToString();
			this.Close();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}

		void BtnAddZonaClick(object sender, EventArgs e)
		{
			if(txtZonas.Text.Length > 0){
				dgZonas.Rows.Add("0", txtZonas.Text, "Activo");
				txtZonas.Text = "";
				dgZonas.ClearSelection();
				dgZonas.Sort(dgZonas.Columns[1], ListSortDirection.Ascending);
			}
			else
				txtZonas.Focus();
		}
		
		void BtnAddFuenteClick(object sender, EventArgs e)
		{
			if(txtFuente.Text.Length > 0){
				dgFuentes.Rows.Add("0", txtFuente.Text, "Activo");
				txtFuente.Text = "";
				dgFuentes.ClearSelection();
				dgFuentes.Sort(dgFuentes.Columns[1], ListSortDirection.Ascending);
			}
			else
				txtFuente.Focus();
		}		
		#endregion		
		
		#region EVENTOS
		void FormZonasFuentesKeyUp(object sender, KeyEventArgs e)
		{			
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		
		void DgZonasCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 3 && e.RowIndex > -1){
				if(dgZonas[2,e.RowIndex].Value.ToString().Equals("Activo")){
					dgZonas[2,e.RowIndex].Value = "Inactivo";
					for(int y=0; y<dgZonas.ColumnCount; y++)
						dgZonas[y,e.RowIndex].Style.BackColor = Color.Red;
				}else{
					dgZonas[2,e.RowIndex].Value = "Activo";
					for(int y=0; y<dgZonas.ColumnCount; y++)
						dgZonas[y,e.RowIndex].Style.BackColor = Color.White;					
				}
				dgZonas.ClearSelection();
			}
		}
		
		void DgFuentesCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 3 && e.RowIndex > -1){
				if(dgFuentes[2,e.RowIndex].Value.ToString().Equals("Activo")){
					dgFuentes[2,e.RowIndex].Value = "Inactivo";
					for(int y=0; y<dgFuentes.ColumnCount; y++)
						dgFuentes[y,e.RowIndex].Style.BackColor = Color.Red;
				}else{
					dgFuentes[2,e.RowIndex].Value = "Activo";
					for(int y=0; y<dgFuentes.ColumnCount; y++)
						dgFuentes[y,e.RowIndex].Style.BackColor = Color.White;					
				}
				dgFuentes.ClearSelection();				
			}
		}
		#endregion
	}
}
