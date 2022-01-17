using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormOrdenFactura : Form
	{
		#region CONSTRUTOR
		public FormOrdenFactura(FormLibroViajes Libro, string id_usu)
		{
			InitializeComponent();
			refLibro = Libro;
			id_usuario =  id_usu;
		}
		#endregion
		
		#region INSTANCIAS
		public FormLibroViajes refLibro = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Libros.SQL_Libros connL = new Conexion_Servidor.Libros.SQL_Libros();
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region VARIABLES
		public bool validacerrar = true;
		int contador = 0;
		string id_usuario;
		#endregion
		
		#region INICIO - FIN
		void FormOrdenFacturaLoad(object sender, EventArgs e)
		{
			cargarDatos();
		}
		
		void FormOrdenFacturaFormClosing(object sender, FormClosingEventArgs e)
		{			
			if(validacerrar == true){
				if(dgFactura.Rows.Count > -1){
					DialogResult result=MessageBox.Show("¿Desea salir, no se guardaran las ordenes de factura?","Cerrando la orden de facturación*",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
					if(DialogResult.OK==result)
					{					
						refLibro.filtrosSinOrden();
						refLibro.filtrosOrden();
						refLibro.filtrosPrincipales();
					}else{
						e.Cancel = true;
					}
				}
			}else{
				refLibro.filtrosSinOrden();
				refLibro.filtrosOrden();
				refLibro.filtrosPrincipales();
			}
		}
		#endregion
		
		#region ADAPATADOR
		public void cargarDatos(){			
			ColoresAlternadosRows(dgDatos);
			for(int i = 0; i < refLibro.dgSinOrden.RowCount; i++){
				if(refLibro.dgSinOrden[1,i].Selected == true){
					if(refLibro.dgSinOrden[12,i].Value.ToString() == "1" && refLibro.dgSinOrden[0,i].Style.BackColor.Name != "LightPink")
					{
						dgDatos.Rows.Add(refLibro.dgSinOrden[0,i].Value.ToString(),
					                	refLibro.dgSinOrden[6,i].Value.ToString(),
										refLibro.dgSinOrden[5,i].Value.ToString(),
										refLibro.dgSinOrden[4,i].Value.ToString(),
										refLibro.dgSinOrden[8,i].Value.ToString(),
										refLibro.dgSinOrden[7,i].Value.ToString(),
										(Convert.ToInt32(refLibro.dgSinOrden[11,i].Value) * Convert.ToInt32(refLibro.dgSinOrden[8,i].Value)).ToString(),
										refLibro.dgSinOrden[14,i].Value.ToString());
					}
				}
			}
			dgDatos.ClearSelection();
		}	
		
		#endregion		
		
		#region BOTONES
		void Button1Click(object sender, EventArgs e)
		{
			new Libro_Nuevo.Pagos.FormContribuyentes(1).ShowDialog();		
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnFacturarClick(object sender, EventArgs e)
		{
			if(dgFactura.Rows.Count > 0){
				if(validaFactura()){
					for(int x = 0; x < dgFactura.Rows.Count; x++){
						connL.insertarOrdenFactura(dgFactura[0,x].Value.ToString(), dgFactura[1,x].Value.ToString(), dgFactura[3,x].Value.ToString(), dgFactura[4,x].Value.ToString(),
						                      dgFactura[5,x].Value.ToString(), dgFactura[6,x].Value.ToString(), dgFactura[7,x].Value.ToString(), dgFactura[8,x].Value.ToString(),
						                      dgFactura[10,x].Value.ToString(), dgFactura[12,x].Value.ToString(), dgFactura[13,x].Value.ToString(), dgFactura[14,x].Value.ToString(),
						                     id_usuario);
						validacerrar = false;
						this.Close();
					}
				}else{
					MessageBox.Show("Lo sentimos una factura no se puede procesar sin los datos obligatorios", "Error al facturar", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}		
		#endregion
		
		#region EVENTOS
		void DgFacturaEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if(dgFactura.CurrentCell.ColumnIndex == 8){
				if (e.Control is DataGridViewTextBoxEditingControl){
					((TextBox)e.Control).AutoCompleteCustomSource = autocomp.AutoReconocimiento("select RAZON_SOCIAL as Dato from DATOS_FACTURA");
	                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
	                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;		              
	            }
			}				
			
			if(dgFactura.CurrentCell.ColumnIndex == 10){
				if (e.Control is DataGridViewTextBoxEditingControl){
					((TextBox)e.Control).AutoCompleteCustomSource = autocomp.AutoReconocimiento("select DF.RAZON_SOCIAL as Dato from MAS_DATOS_FACTURACION MDF, DATOS_FACTURA DF WHERE ID_DATOS_F = DF.ID AND MDF.TIPO = 'CONTRIBUYENTE'");
	                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
	                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;		              
	            }
			}		
		}		
		
		void DgFacturaCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				if(dgFactura.CurrentCell.ColumnIndex == 8){
					if(connL.validarFactura(dgFactura[8,dgFactura.CurrentRow.Index].Value.ToString(),0) != "0"){					
						dgFactura[9,dgFactura.CurrentRow.Index].Value = connL.validarFactura(dgFactura[8,dgFactura.CurrentRow.Index].Value.ToString(),0);
						dgFactura[8,dgFactura.CurrentRow.Index].Style.BackColor = Color.LightGreen;
					}else{
						dgFactura[9,dgFactura.CurrentRow.Index].Value = "0";
						dgFactura[8,dgFactura.CurrentRow.Index].Style.BackColor = Color.Red;
					}
				}
	
				if(dgFactura.CurrentCell.ColumnIndex == 10){
					if(connL.validarFactura(dgFactura[10,dgFactura.CurrentRow.Index].Value.ToString(),1) != "0"){				
						dgFactura[11,dgFactura.CurrentRow.Index].Value = connL.validarFactura(dgFactura[10,dgFactura.CurrentRow.Index].Value.ToString(),1);
						dgFactura[10,dgFactura.CurrentRow.Index].Style.BackColor = Color.LightGreen;
					}else{
						dgFactura[11,dgFactura.CurrentRow.Index].Value = "0";
						dgFactura[10,dgFactura.CurrentRow.Index].Style.BackColor = Color.Red;
					}
				}
			}
		}
		#endregion
		
		#region METODOS
		public void quitarFilas(){
			List<DataGridViewRow> list = new List<DataGridViewRow>();
			foreach (DataGridViewRow row in dgDatos.Rows){              
				DataGridViewTextBoxCell celdaseleccionada = row.Cells[1] as DataGridViewTextBoxCell;
			
				if (celdaseleccionada.Selected == true)
					list.Add(row);
			}
			
			foreach (DataGridViewRow row in list)	
			{
				dgDatos.Rows.Remove(row);
			} 		
		}
		
		public bool validaFactura(){
			bool respuesta = true;
			for(int x = 0; x < dgFactura.Rows.Count; x++){
				if(dgFactura[8,x].Style.BackColor.Name != "LightGreen"){
					respuesta = false;
				}
				if(dgFactura[10,x].Style.BackColor.Name != "LightGreen"){
					respuesta = false;
				}
			}
			return respuesta;
		}
		
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		#endregion		
		
		#region MENU		
		void RazónSocialToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(dgDatos.SelectedRows.Count > 0){
				String IDS = "";			
				String fechas = "";	
				String cantidad = "0";		
				String vehiculo = "";
				String importe = "0";
				String razon = "";					
				for(int i = 0; i < dgDatos.RowCount; i++){			
					if(dgDatos[1,i].Selected == true){
						if(IDS == "")
							IDS = dgDatos[0,i].Value.ToString();
						else
							IDS = IDS + "-"+ dgDatos[0,i].Value.ToString();
						
						if(fechas == "")
							fechas = dgDatos[1,i].Value.ToString();
						else
							fechas = fechas + "-"+ dgDatos[1,i].Value.ToString();
												
						cantidad = (Convert.ToInt16(cantidad) + Convert.ToInt16(dgDatos[4,i].Value)).ToString();										
						importe = (Convert.ToDouble(importe) + Convert.ToDouble(dgDatos[6,i].Value)).ToString();
						razon = dgDatos[7,i].Value.ToString();
					for(int x = i+1; x < dgDatos.RowCount; x++){				
							if(dgDatos[1,x].Selected == true){
								if(vehiculo != dgDatos[5,x].Value.ToString()){								
									x = dgDatos.RowCount - 1;
									vehiculo = "Mixto";
								}
							}				
					}
					}
					if(vehiculo == "")
						vehiculo = dgDatos[5,i].Value.ToString();		
				}
				dgFactura.Rows.Add(IDS, fechas, "", vehiculo, cantidad,	importe, (Convert.ToDouble(importe) * .16).ToString(), (Convert.ToDouble(importe) * 1.16).ToString(), razon, "", "", "", "", "", "UNIFICADA");		
				if(dgFactura[8, contador].Value.ToString() != "" && dgFactura[8, contador].Value.ToString() != " ")
					dgFactura[8,contador].Style.BackColor = Color.LightGreen;
				contador++;
				quitarFilas();
				dgDatos.ClearSelection();
				dgFactura.ClearSelection();
			}
		}
		
		
		void PorCantUnidadesToolStripMenuItemClick(object sender, EventArgs e)
		{	
			if(dgDatos.SelectedRows.Count > 0){							
				Int32 cantidad = 0;		
				Double importe = 0.0;	
				
				for(int i = 0; i < dgDatos.RowCount; i++){		
					if(dgDatos[1,i].Selected == true){
						cantidad =  Convert.ToInt16(dgDatos[4,i].Value);
						importe = System.Math.Round(Convert.ToDouble(dgDatos[6,i].Value) / cantidad , 2) ;
						for(int x = 0; x < cantidad; x++){
							dgFactura.Rows.Add(dgDatos[0,i].Value.ToString(), dgDatos[1,i].Value.ToString(), "", dgDatos[5,i].Value.ToString(), "1",  importe, 
							                   System.Math.Round((Convert.ToDouble(importe) * .16), 2), System.Math.Round((Convert.ToDouble(importe) * 1.16), 2), dgDatos[7,i].Value.ToString(), "", "", "", "", "", "CANTIDAD_UNIDADES");
							if(dgFactura[8, contador].Value.ToString() != "" && dgFactura[8, contador].Value.ToString() != " ")
								dgFactura[8,contador].Style.BackColor = Color.LightGreen;							
							contador++;
						}
					}
				}
				quitarFilas();
				
				dgDatos.ClearSelection();
				dgFactura.ClearSelection();
			}
		}
		#endregion						
	}
}
