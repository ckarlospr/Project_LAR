using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Ruta
{
	public partial class FormBuscar : Form
	{
		
		private Interfaz.Ruta.FormBusquedaRuta formBuscarRuta=null;
		private DataGridView tabla=null;
		private List<string> lista=null;
		private Interfaz.FormPrincipal principal=null;
		
		public FormBuscar(Interfaz.Ruta.FormBusquedaRuta formBuscarRuta,DataGridView tabla){
			InitializeComponent();
			this.formBuscarRuta=formBuscarRuta;
			this.tabla=tabla;
		}
		
		#region EVENTO (LOAD - CLOSING)
		void FormBuscarLoad(object sender, EventArgs e){
			formBuscarRuta.buscar=true;
			this.MdiParent=principal;
		}
		
		void FormBuscarFormClosing(object sender, FormClosingEventArgs e){
			getColorDefault(0);
			formBuscarRuta.buscar=false;
		}
		#endregion
		
		#region EVENTO_BOTONES (BUSCAR- CERRAR)	
		void BtnTodoClick(object sender, EventArgs e){
			getColorDefault(0);
			lista=new List<string>();
			if(txtRuta.Text!=""){
				List<string> result=(List<string>)getBusqueda(0);
				if(result !=null && result.Count>0){
					getSeleccionarDato(result, 0);
				}else{
					MessageBox.Show("La búsqueda no arrojo ningún resultado","Buscar cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}	
			}else{
				MessageBox.Show("Para realizar la búsqueda es necesario ingresar datos.","Buscar cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		
		void TxtRutaEnter(object sender, EventArgs e)
		{
			getColorDefault(0);
			lista=new List<string>();
			if(txtRuta.Text!=""){
				List<string> result=(List<string>)getBusqueda(0);
				if(result !=null && result.Count>0){
					getSeleccionarDato(result, 0);
				}else{
					MessageBox.Show("La búsqueda no arrojo ningún resultado","Buscar cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}	
			}else{
				MessageBox.Show("Para realizar la búsqueda es necesario ingresar datos.","Buscar cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		void BtnCerrarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
		#region OBTENER_ID
		private object getBusqueda(int contador){
			if(txtRuta.Text!=""){
				if(tabla[1,contador].Value.ToString().ToUpper().Trim() == txtRuta.Text.ToUpper().Trim()){
					lista.Add(tabla[0,contador].Value.ToString());
				}
			}
			return (contador<(tabla.Rows.Count-1))?getBusqueda(++contador):(lista.Count>0)?lista:null ;
		}
		#endregion
		
		#region SELECCIONAR_DATOS_DE_LA_TABLA
		private object getSeleccionarDato(List<string> ruta, int contador){
			if(ruta==null){
				return null;
			}
			for(int x=0;x<tabla.Rows.Count;x++){
				if(ruta[contador].ToString().ToUpper().Trim() == tabla[0,x].Value.ToString().ToUpper().Trim()){
					tabla.Rows[x].DefaultCellStyle.BackColor = Color.Red;
				}
			}	
			return (contador<ruta.Count-1)?getSeleccionarDato(ruta,++contador):null;
		}
		#endregion
		
		#region ELIMINAR_ESPACIO_EN_BLANCO
		void TxtRutaTextChanged(object sender, EventArgs e){
			if(txtRuta.Text==" "){
				txtRuta.Text="";
			}
		}
		#endregion
		
		#region RETOMAR_COLOR
		private object getColorDefault(int contador){
			if(tabla.Rows.Count==0){
				return null;
			}else{
				tabla.Rows[contador].DefaultCellStyle.BackColor = Color.White;
			}
			return(contador<(tabla.Rows.Count-1))?getColorDefault(++contador):null;
		}
		#endregion

		
	}
}
