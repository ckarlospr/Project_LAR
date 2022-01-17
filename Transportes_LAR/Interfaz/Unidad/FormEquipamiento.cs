//((CurrencyManager)dataContacto.BindingContext[operador.listContacto]).Refresh();
//dataViewLicencia.Rows.RemoveAt remueve una fila
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Unidad
{
	public partial class FormEquipamiento : Form
	{
		
		private List<Interfaz.Unidad.Dato.Categoria> listCategoria=null;
		private Interfaz.Unidad.FormUnidad unidad=null;
		
		private string idUnidad=		"";
		private string idCategoria=		"";
		private string nomCategoria=	"";
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public FormEquipamiento(Interfaz.Unidad.FormUnidad unidad,string idUnidad){
			InitializeComponent();
			this.unidad=unidad;
			this.idUnidad=idUnidad;
		}
		
		#region EVENTO (LOAD - CLOSING)
		void FormEquipamientoLoad(object sender, EventArgs e){
			getCargarCategoria();
			if(unidad.listEquipamiento==null){
				unidad.listEquipamiento=new List<Transportes_LAR.Interfaz.Unidad.Dato.Equipamiento>();
			}else{
				dataEquipamiento.DataSource=unidad.listEquipamiento;
			}
		}
		
		void FormEquipamientoFormClosing(object sender, FormClosingEventArgs e){
			unidad.equipamiento=false;
		}
		#endregion
		
		private void getCargarCategoria(){
			listCategoria=new Conexion_Servidor.Unidad.SQL_Unidad().getCategoria();
			cmbCategoria.DataSource=listCategoria;
			((CurrencyManager)cmbCategoria.BindingContext[listCategoria]).Refresh();
		}
		
		#region EVENTO_BOTONES
		void BtnAgregarClick(object sender, EventArgs e){
			nomCategoria=cmbCategoria.Text;
			if(getBusquedaArticulo(0)==null){
				if(cmbCategoria.Text!="" && txtDescripcion.Text!="" && numCantidad.Text!=""){
					if((this.idCategoria=new Conexion_Servidor.Unidad.SQL_Equipamiento().getExistenciaCategoria(cmbCategoria.Text.Trim()))!=""){
						getInsertEquipamiento();
					}else{
						getInsertCategoria();
						getInsertEquipamiento();
					}		
				}else{
					MessageBox.Show("Para poder agregar un equipamiento es necesario llenar todos los campos con sus datos correspondientes.","Agregar equipamiento",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				}
			}
			getLimpiarCampo();
		}
		
		void BtnRemoverClick(object sender, EventArgs e){
			if(dataEquipamiento.Rows.Count>0){
				getEliminarEquipamiento(0,dataEquipamiento[2,dataEquipamiento.CurrentRow.Index].Value.ToString().ToUpper().Trim());
				getLimpiarCampo();
			}
		}
		
		void BtnAceptarClick(object sender, EventArgs e){
			this.Close();
		}
		#endregion
		
		
		private void getInsertEquipamiento(){
			Interfaz.Unidad.Dato.Equipamiento equipamiento=new Transportes_LAR.Interfaz.Unidad.Dato.Equipamiento();
			equipamiento.idCategoria=	this.idCategoria;
			equipamiento.categoria=		new Conexion_Servidor.Unidad.SQL_Equipamiento().getNombreCategoria(idCategoria);
			equipamiento.descripcion=	txtDescripcion.Text;
			equipamiento.cantidad=		numCantidad.Text;
			unidad.listEquipamiento.Add(equipamiento);
		}
		private void getInsertCategoria(){
			idCategoria=new Conexion_Servidor.Unidad.SQL_Equipamiento().getInsertCategoria(nomCategoria);
		}
		
		
		#region	LIMPIAR_CAMPOS
		private void getLimpiarCampo(){
			getCargarCategoria();
			if(cmbCategoria.Items.Count>0){
				cmbCategoria.SelectedIndex=0;
			}
			txtDescripcion.Text="";
			numCantidad.Value=1;
			dataEquipamiento.DataSource=unidad.listEquipamiento;
			((CurrencyManager)dataEquipamiento.BindingContext[unidad.listEquipamiento]).Refresh();
		}
		#endregion
		
		#region EVALUACION_DE_ELEMENTO_EXISTENTE
		private object getBusquedaArticulo(int contador){
			if(unidad.listEquipamiento.Count<=0)
				return null;
			if(unidad.listEquipamiento[contador].categoria.ToUpper().Trim()== cmbCategoria.Text.ToUpper().Trim()){
				unidad.listEquipamiento[contador].cantidad=(Convert.ToInt32(unidad.listEquipamiento[contador].cantidad)+Convert.ToInt32(numCantidad.Text)).ToString();
				return true;
			}
			return (contador<unidad.listEquipamiento.Count-1)?getBusquedaArticulo(++contador):null;
		}
		#endregion
		
		private object getEliminarEquipamiento(int contador,string cadena){
			if(unidad.listEquipamiento[contador].categoria.ToUpper().Trim()== cadena){
				unidad.listEquipamiento.RemoveAt(contador);
			}
			return (contador<unidad.listEquipamiento.Count-1)?getEliminarEquipamiento(++contador,cadena):null;
		}
	}
}
