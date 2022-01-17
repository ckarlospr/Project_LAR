using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormDependiente : Form
	{
		private Interfaz.Operador.FormOperador operador=null;//MEMORIA_INTERFAZ_OPERADOR
		private Interfaz.Operador.Dato.Dependiente dependiente=null;//MOMORIA_INTERFAZ_MODIFICAR_DATO_DE_LICENCIA
		
		//-CONSTRUCTOR_DE_LA_CLASE
		public FormDependiente(Interfaz.Operador.FormOperador operador){
			InitializeComponent();
			this.operador=operador;
			getCargarValidacionCampos(this);
		}
		
		//--EVENTO_CIERRE_DE_VENTANA
		void FormDependienteFormClosing(object sender, FormClosingEventArgs e){
			this.operador.dependiente=false;
			operador.BringToFront();
		}
	
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Operador.FormDependiente formDependiente){
			formDependiente.cmbParentesco.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formDependiente.cmbSexo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		#endregion
	
		//--EVENTO_INICIO_DE_VENTANA
		void FormDependienteLoad(object sender, EventArgs e){
			cmbParentesco.SelectedIndex=0;
			cmbSexo.SelectedIndex=0;
			if(operador.listDependiente==null){
				this.operador.listDependiente=new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Dependiente>();
			}else{
				dataDependiente.DataSource=this.operador.listDependiente;
			}
		}
		
		#region EVENTO_BOTONES: (AGREGAR - CANCELAR)
		void BtnAgregarClick(object sender, EventArgs e){
			if(cmbParentesco.Text!="" && cmbSexo.Text!=""){
			    getCargarLista();
				getLimpiarCampo();
				dataDependiente.DataSource= this.operador.listDependiente;
				((CurrencyManager)dataDependiente.BindingContext[operador.listDependiente]).Refresh();
			}else{
				MessageBox.Show("Para poder agregar la licencia del operador es necesario llenar todos los campos con los datos correspondientes.","Agregar licencia",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		
		void BtnRemoverClick(object sender, EventArgs e){
			if(dataDependiente.Rows.Count>0){
				if(DialogResult.Yes==MessageBox.Show("¿Desea remover al dependiente seleccionada de la tabla?","Remover licencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question)){
					if(operador.listDependiente[dataDependiente.CurrentRow.Index].id !=null){
						new Conexion_Servidor.Operador.SQL_Dependiente().getEliminarDependiente(operador.listDependiente[dataDependiente.CurrentRow.Index].id);
					}
					this.operador.listDependiente.RemoveAt(dataDependiente.CurrentRow.Index);
					dataDependiente.DataSource= this.operador.listDependiente;
					((CurrencyManager)dataDependiente.BindingContext[operador.listDependiente]).Refresh();
				}	
			}
		}
		#endregion
	
		//--CARGAR_LICENCIA_A_LA_LISTA
		private void getCargarLista(){
			this.dependiente=new Transportes_LAR.Interfaz.Operador.Dato.Dependiente();
			dependiente.parentesco=cmbParentesco.Text;
			dependiente.sexo=cmbSexo.Text;
			dependiente.fechaNacimiento=dateNacimiento.Value.ToString("dd-MM-yyyy");
			this.operador.listDependiente.Add(dependiente);
		}
		
		//--LIMPIAR_CAMPOS_DEL_FORMULARIO
		private void getLimpiarCampo(){
			cmbParentesco.SelectedIndex=0;
			cmbSexo.SelectedIndex=0;
			dateNacimiento.Value=DateTime.Today;
		}
	
		//--EVENTO_BOTON_ACEPTAR
		void BtnAceptarClick(object sender, EventArgs e){
			this.Close();
		}
		
		//--EVENTO_DOBLE_CLICK_A_LA_CELDA
		void DataDependienteCellDoubleClick(object sender, DataGridViewCellEventArgs e){
			if(e.RowIndex>=0){
				new Interfaz.Operador.Modificar.FormDependiente(e.RowIndex,this.operador.listDependiente).ShowDialog();
				dataDependiente.DataSource= this.operador.listDependiente;
				((CurrencyManager)dataDependiente.BindingContext[operador.listDependiente]).Refresh();				
			}
		}
	}
}
