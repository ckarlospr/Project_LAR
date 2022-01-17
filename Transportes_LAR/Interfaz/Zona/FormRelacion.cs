using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Zona
{
	public partial class FormRelacion : Form
	{
		private string [,] operador=null;
		private string [,] ruta=null;
		
		private DataGridViewComboBoxColumn comboboxColumn  =null;
		private DataGridViewComboBoxColumn comboboxColumn2 =null;
		private Interfaz.FormPrincipal principal=null;
		
		#region CONSTRUCTOR
		public FormRelacion(){
			InitializeComponent();
			this.comboboxColumn =(DataGridViewComboBoxColumn) dataClasificacionOperador.Columns[3] ;
			this.comboboxColumn2 =(DataGridViewComboBoxColumn) dataClasificacionRuta.Columns[3] ;
			
		}
		#endregion
		
		#region EVENTO ( LOAD - CLOSING )
		void FormRelacionLoad(object sender, EventArgs e){
			getCargarZona();
			if(dataClasificacionOperador.Rows.Count==0){
				this.tabControl1.TabPages.Remove(this.tabPage1);
			}
			if(dataClasificacionRuta.Rows.Count==0){
				this.tabControl1.TabPages.Remove(this.tabPage2);
			}
			this.MdiParent=principal;
		}
		void FormRelacionFormClosing(object sender, FormClosingEventArgs e){
			if(!getProcesoAlmacenar())
				e.Cancel=true;
		}
		#endregion

		#region CARGANDO_NUEVA_RELACIÓN_DE_OPERADOR
		private object getCargarOperador(int contador,int tamano){
			if(tamano==0)
				return null;
			operador[contador,0]=dataClasificacionOperador[1,contador].Value.ToString();
			operador[contador,1]=dataClasificacionOperador[0,contador].Value.ToString();
			return (contador<tamano-1)?getCargarOperador(++contador,tamano):null;
		}
		#endregion
		
		#region CARGANDO_NUEVA_RELACION_DE_RUTA
		private object getCargarRuta(int contador,int tamano){
			if(tamano==0)
				return null;
			ruta[contador,0]=dataClasificacionRuta[1,contador].Value.ToString();
			ruta[contador,1]=dataClasificacionRuta[0,contador].Value.ToString();
			return (contador<tamano-1)?getCargarRuta(++contador,tamano):null;
		}
		#endregion
		
		#region PROCESO_ALMACENAR
		private bool getProcesoAlmacenar(){
			try{
				getCargarOperador(0,Convert.ToInt32(dataClasificacionOperador.Rows.Count.ToString()));
				getCargarRuta(0,Convert.ToInt32(dataClasificacionRuta.Rows.Count.ToString()));
				new Conexion_Servidor.Zona.SQL_Zona().getActualizarOperador(0,operador);
				new Conexion_Servidor.Zona.SQL_Zona().getActualizarRuta(0,ruta);
				return true;
			}catch{
				MessageBox.Show("Para poder continuar es necesario seleccionar la zona del operador y de la ruta ya que su clasificación de zona la cual tenían asignada fue eliminada.","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return false;
			}
		}
		#endregion
		
		#region BOTON (ACEPTAR)
		void BtnAceptarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
		#region PROCESO_PARA_CARGAR_DATOS_EN_LA_TABLA
		private void getCargarZona(){
			comboboxColumn.DataSource =new Conexion_Servidor.Zona.SQL_Zona().getGenerarZona();
			comboboxColumn.DisplayMember = "dataZona";
			comboboxColumn.ValueMember = "id_Zona";
			dataClasificacionOperador.DataSource = new Conexion_Servidor.Zona.SQL_Zona().getListaOperador();
			
			comboboxColumn2.DataSource =new Conexion_Servidor.Zona.SQL_Zona().getGenerarZona();
			comboboxColumn2.DisplayMember = "dataZona";
			comboboxColumn2.ValueMember = "id_Zona";
			dataClasificacionRuta.DataSource = new Conexion_Servidor.Zona.SQL_Zona().getListaRuta();
			
			this.operador=new string[Convert.ToInt32(dataClasificacionOperador.Rows.Count.ToString()),2];
			this.ruta    =new string[Convert.ToInt32(dataClasificacionRuta.Rows.Count.ToString()),2];
		}
		#endregion
		
		#region EVENTO_BOTON (AGREGAR_ZONA)
		void BtnAgregarClick(object sender, EventArgs e){
			new Interfaz.Zona.FormAgregar().ShowDialog();
			comboboxColumn.DataSource =new Conexion_Servidor.Zona.SQL_Zona().getGenerarZona();
			comboboxColumn2.DataSource =new Conexion_Servidor.Zona.SQL_Zona().getGenerarZona();
		}
		#endregion
	}
}
