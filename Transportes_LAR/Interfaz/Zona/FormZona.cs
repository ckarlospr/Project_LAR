using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Zona
{
	public partial class FormZona : Form
	{
		private string id_zona="";
		private String[,] zona=null;
		private Interfaz.FormPrincipal principal=null;
		
		#region CONSTRUCTOR
		public FormZona(Interfaz.FormPrincipal principal){
			InitializeComponent();
			this.principal=principal;			
		}
		#endregion
		
		#region EVENTOS_FORM ( LOAD - CLOSING)
		void FormZonaLoad(object sender, EventArgs e){
			getCargarProceso();
			this.MdiParent=principal;
		}
		
		void FormZonaFormClosing(object sender, FormClosingEventArgs e){
			principal.zona=false;
		}
		#endregion
		
		#region CARGAR_LAS_COLINDANCIAS_DE_CADA_ZONA
		private object getBuscarColindancia(string cadena,int contador){
			//--CARGAR_COLINDANCIAS
			if(cadena=="")
				return null;
			if(cadena.Substring(contador,1)!="-"){
				this.id_zona+=cadena.Substring(contador,1);
				getSeleccionarColindancia(this.id_zona,Convert.ToInt32(dataZonaColindancia.Rows.Count.ToString()),0);
			}else
				this.id_zona="";
			return (contador<cadena.Length-1)?getBuscarColindancia(cadena,++contador): null;
		}
		
		private object getSeleccionarColindancia(String id_zona,int fila,int contador){
			//--SELECCIONADOR_DE_COLINDANCIAS_EN_LA_TABLA
			if(dataZonaColindancia[0,contador].Value.ToString()==id_zona)
				dataZonaColindancia[1,contador].Value=true;
			return (contador<fila-1)?getSeleccionarColindancia(id_zona,fila,++contador):null;
		}
		#endregion
		
		#region PROCESO_CARGAR_ZONAS_EN_LA_TABLA
		private object getCargarZona1(int contador){
			//--CARGAR_TABLA_1
			dataZonaRegistrada.Rows.Add(zona[contador,0],zona[contador,1]);
			return ((zona.Length/4)>contador+1)?getCargarZona1(++contador):null;
		}
		
		private object getCargarZona2(int contador){
			//--CARGAR_TABLA_2
			if(zona.Length>0){
				if(dataZonaRegistrada[0,dataZonaRegistrada.CurrentRow.Index].Value.ToString()!= zona[contador,0]){
					dataZonaColindancia.Rows.Add(zona[contador,0],false,zona[contador,1]);
				}	
			}
			return ((zona.Length/4)>contador+1)?getCargarZona2(++contador):null;
		}
		#endregion
		
		#region REMOVER_DATOS_DE_LAS_TABLAS
		private object getLimpiarColindancia(int fila,int contador){
			//--LIMPIAR_TABLA_1
			if(fila==0)
				return null;
			dataZonaColindancia.Rows.RemoveAt(0);
			return(contador<fila-1)?getLimpiarColindancia(fila,contador+1):null;
		}
		
		private object getLimpiarZona(int fila,int contador){
			//--LIMPIAR_TABLA_2
			if(fila==0)
				return null;
			dataZonaRegistrada.Rows.RemoveAt(0);
			return(contador<fila-1)?getLimpiarZona(fila,contador+1):null;
		}
		#endregion
		
		#region	EVENTO_CLICK_EN_LA_CELDA
		void DataZonaRegistradaCellClick(object sender, DataGridViewCellEventArgs e){
			getLimpiarColindancia(Convert.ToInt32(dataZonaColindancia.Rows.Count.ToString()),0);
			getCargarZona2(0);
			if(zona.Length>0){
				txtZonaDescripcion.Text=zona[dataZonaRegistrada.CurrentRow.Index,3];
				getBuscarColindancia(zona[getPunteroZona(dataZonaRegistrada[0,dataZonaRegistrada.CurrentRow.Index].Value.ToString(),0),2],0);
			}
		}
		
		void DataZonaColindanciaCellClick(object sender, DataGridViewCellEventArgs e){
			//--ALMACENANDO_LAS_ZONAS_EN_EL_ARRAY
			if(e.RowIndex>=0){
				if(zona.Length>0){
					if(dataZonaColindancia.CurrentCell.ColumnIndex==1){
						dataZonaColindancia[1,dataZonaColindancia.CurrentRow.Index].Value=(dataZonaColindancia[1,dataZonaColindancia.CurrentRow.Index].Value.ToString()=="True")?false:true;
						int puntero=getPunteroZona(dataZonaRegistrada[0,dataZonaRegistrada.CurrentRow.Index].Value.ToString(),0);
						zona[puntero,2]="";//BORANDO_LAS_COLINDANCIAS
						getCargarColindancia(Convert.ToInt32(dataZonaColindancia.Rows.Count.ToString()), 0,puntero);//RECARGANDO_LAS_COLINDANCIAS_A_LA_MISMA_ZONA
					}
				}	
			}
		}
		
		private int getPunteroZona(string id_zona,int contador){
			//--OBTENER_LA_POSICION_DENTRO_DEL_ARRAY
			return (zona[contador,0]==id_zona)?contador: getPunteroZona(id_zona,++contador);
		}
		
		private object getCargarColindancia(int fila, int contador,int puntero){
			//--GENERA_LA_CADENA_DE_COLINDANCIAS
			zona[puntero,2]=(dataZonaColindancia[1,contador].Value.ToString()=="True")?zona[puntero,2]+dataZonaColindancia[0,contador].Value.ToString()+"-":zona[puntero,2];
			return (contador<fila-1)? getCargarColindancia(fila,++contador,puntero):new Conexion_Servidor.Zona.SQL_Zona().getInsertarZona(zona[puntero,0],zona[puntero,1],zona[puntero,2],zona[puntero,3]);//--FALTA_INSERTAR_COLINDANCIAS
		}
		#endregion
		
		#region EVENTO_DE_TECLAS (FLUJO_DE_SELECCION)
		void DataZonaRegistradaKeyUp(object sender, KeyEventArgs e){
			if(zona.Length>0){
				if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter){
					getLimpiarColindancia(Convert.ToInt32(dataZonaColindancia.Rows.Count.ToString()),0);
					getCargarZona2(0);
					txtZonaDescripcion.Text=zona[dataZonaRegistrada.CurrentRow.Index,3];
					getBuscarColindancia(zona[getPunteroZona(dataZonaRegistrada[0,dataZonaRegistrada.CurrentRow.Index].Value.ToString(),0),2],0);
	      		}
			}
		}
		#endregion
		
		#region MODIFICAR_LOS_DATOS_DE_DESCRIPCION_DE_LA_ZONA
		void TxtZonaDescripcionTextChanged(object sender, EventArgs e){
			try{
				if(zona.Length>0){
					int puntero=getPunteroZona(dataZonaRegistrada[0,dataZonaRegistrada.CurrentRow.Index].Value.ToString(),0);
					zona[puntero,3]=txtZonaDescripcion.Text;
					new Conexion_Servidor.Zona.SQL_Zona().getInsertarZona(zona[puntero,0],zona[puntero,1],zona[puntero,2],zona[puntero,3]);	
				}
			}catch{
				txtZonaDescripcion.Text="";				
			}
		}
		#endregion
		
		#region CARGAR_PROCESO
		private void getCargarProceso(){
			this.zona=new Conexion_Servidor.Zona.SQL_Zona().getModelo();
			if(zona.Length>0){
				getLimpiarColindancia(Convert.ToInt32(dataZonaColindancia.Rows.Count.ToString()),0);
				getLimpiarZona(Convert.ToInt32(dataZonaRegistrada.Rows.Count.ToString()),0);
				getCargarZona1(0);
				getCargarZona2(0);
				getBuscarColindancia(zona[getPunteroZona(dataZonaRegistrada[0,dataZonaRegistrada.CurrentRow.Index].Value.ToString(),0),2],0);
				txtZonaDescripcion.Text=zona[dataZonaRegistrada.CurrentRow.Index,3];
			}else{
				getLimpiarColindancia(Convert.ToInt32(dataZonaColindancia.Rows.Count.ToString()),0);
				getLimpiarZona(Convert.ToInt32(dataZonaRegistrada.Rows.Count.ToString()),0);
				txtZonaDescripcion.Text="";
			}
		}
		#endregion
		
		#region EVENTO_BOTONES ( AGREGAR - REMOVER - ACEPTAR )
		void BtnAgregarClick(object sender, EventArgs e){
			new Interfaz.Zona.FormAgregar().ShowDialog();
			getCargarProceso();
		}
		
		void BtnRemoverClick(object sender, EventArgs e){
			new Interfaz.Zona.FormRemover(zona).ShowDialog();
			getCargarProceso();
			if(new Conexion_Servidor.Zona.SQL_Zona().getVerificarZona()){
				MessageBox.Show("Existen operadores o rutas sin zona, para poder continuar es necesario que seleccione la zona a la cual pertenecen.","Clasificar zona",MessageBoxButtons.OK,MessageBoxIcon.Question);
				new Interfaz.Zona.FormRelacion().ShowDialog();
				getCargarProceso();
			}
		}
		
		void BtnAceptarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
	
	}
}
