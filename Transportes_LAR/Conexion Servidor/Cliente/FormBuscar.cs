using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Cliente
{
	public partial class FormBuscar : Form
	{
		#region INSTANCIAS
		private Interfaz.Cliente.FormBusquedaCliente formBuscarCliente=null;
		#endregion
		
		#region VARIABLE COMPONENTES
		private DataGridView tabla=null;
		#endregion 
		
		#region LISTA
		private List<string> lista=null;
		#endregion 
		
		#region CONSTRUCTOR
		public FormBuscar(Interfaz.Cliente.FormBusquedaCliente formBuscarCliente,DataGridView tabla){
			InitializeComponent();
			this.formBuscarCliente=formBuscarCliente;
			this.tabla=tabla;
		}
		#endregion
		
		#region EVENTO (LOAD - CLOSING)
		void FormBuscarLoad(object sender, EventArgs e){
			formBuscarCliente.buscar=true;
		}
		
		void FormBuscarFormClosing(object sender, FormClosingEventArgs e){
			getColorDefault(0);
			formBuscarCliente.buscar=false;
		}
		#endregion
		
		#region EVENTO_BOTONES (TODO - SIGUIENTE - CERRAR)	
		void BtnTodoClick(object sender, EventArgs e){
			getColorDefault(0);
			lista=new List<string>();
			if(txtEmpresa.Text!="" || txtSubNombre.Text!=""){
				List<string> result=(List<string>)((txtEmpresa.Text!="" && txtSubNombre.Text!="")?(List<string>)getBusqueda(txtEmpresa.Text,txtSubNombre.Text,0): (txtEmpresa.Text!="" && txtSubNombre.Text=="")?getBusqueda(txtEmpresa.Text,0):getBusqueda(txtSubNombre.Text,0));
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
		private object getBusqueda(string empresa,int contador){
			if(txtEmpresa.Text!=""){
				if(tabla[1,contador].Value.ToString().ToUpper().Trim() == txtEmpresa.Text.ToUpper().Trim()){
					lista.Add(tabla[0,contador].Value.ToString());
				}
			}else if(txtSubNombre.Text!=""){
				if(tabla[2,contador].Value.ToString().ToUpper().Trim() == txtSubNombre.Text.ToUpper().Trim()){
					lista.Add(tabla[0,contador].Value.ToString());
				}
			}
			
			return (contador<(tabla.Rows.Count-1))?getBusqueda(empresa,++contador):(lista.Count>0)?lista:null ;
		}
		
		private List<string> getBusqueda(string empresa,string subNombre,int contador){
			if(tabla[1,contador].Value.ToString().ToUpper().Trim()==txtEmpresa.Text.ToUpper().Trim()  && tabla[2,contador].Value.ToString().ToUpper().Trim()==txtSubNombre.Text.ToUpper().Trim() ){
				lista.Add(tabla[0,contador].Value.ToString());
			}
			return (contador<(tabla.Rows.Count-1))?(List<string>)getBusqueda(empresa,subNombre,++contador):lista ;
		}
		#endregion
		
		#region SELECCIONAR_DATOS_DE_LA_TABLA
		private object getSeleccionarDato(List<string> cliente, int contador){
			if(cliente==null){
				return null;
			}
			for(int x=0;x<tabla.Rows.Count;x++){
				if(cliente[contador].ToString().ToUpper().Trim() == tabla[0,x].Value.ToString().ToUpper().Trim()){
					tabla.Rows[x].DefaultCellStyle.BackColor = Color.Red;
				}
			}	
			return (contador<cliente.Count-1)?getSeleccionarDato(cliente,++contador):null;
		}
		#endregion
		
		#region ELIMINAR_ESPACIO_EN_BLANCO
		void TxtEmpresaTextChanged(object sender, EventArgs e){
			if(txtEmpresa.Text==" "){
				txtEmpresa.Text="";
			}
		}
		
		void TxtSubNombreTextChanged(object sender, EventArgs e){
			if(txtSubNombre.Text==" "){
				txtSubNombre.Text="";	
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
