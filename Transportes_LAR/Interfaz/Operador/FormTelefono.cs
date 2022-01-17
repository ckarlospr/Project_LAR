using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormTelefono : Form
	{
		private Interfaz.Operador.FormOperador operador=null;//MEMORIA_INTERFAZ_OPERADOR
		private Interfaz.Operador.Dato.Telefono telefono=null;//MOMORIA_INTERFAZ_MODIFICAR_DATO_DE_LICENCIA
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		String id_operador= "";
		
		//-CONSTRUCTOR_DE_LA_CLASE
		public FormTelefono(Interfaz.Operador.FormOperador operador, String id_operador){
			InitializeComponent();
			this.operador=operador;
			this.id_operador = id_operador;
			getCargarValidacionCampos(this);
		}
		
		//--EVENTO_CIERRE_DE_VENTANA
		void FormTelefonoFormClosing(object sender, FormClosingEventArgs e){
			this.operador.telefono=false;
			operador.BringToFront();
		}
		
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Operador.FormTelefono formTelefono){
			formTelefono.cmbTipo.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			formTelefono.txtNumero.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formTelefono.txtDescripcion.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
		}
		#endregion
		
		//--EVENTO_INICIO_DE_VENTANA
		void FormTelefonoLoad(object sender, EventArgs e){
			cmbTipo.SelectedIndex=0;
			if(operador.listTelefono==null){
				this.operador.listTelefono=new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Telefono>();
			}else{
				dataTelefono.DataSource=this.operador.listTelefono;
			}
		}
		
		#region EVENTO_BOTONES (AGREGAR - CANCELAR)
		void BtnAgregarTelefonoClick(object sender, EventArgs e){
			if(cmbTipo.Text!="" && txtNumero.Text!="" && txtDescripcion.Text!="")
			{
				conn.getAbrirConexion("insert into TELEFONOCHOFER (Tipo, Numero, Descripcion, ID_Chofer) values ('"+cmbTipo.Text+"', '"+txtNumero.Text+"', '"+txtDescripcion.Text+"', '"+id_operador+"' )");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				getCargarLista();
				getLimpiarCAmpo();
				dataTelefono.DataSource= this.operador.listTelefono;
				((CurrencyManager)dataTelefono.BindingContext[operador.listTelefono]).Refresh();
			}
			else
			{
				MessageBox.Show("Para poder agregar el telefono del operador es necesario llenar todos los campos con los datos correspondientes.","Agregar licencia",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		
		void BtnRemoverTelefonoClick(object sender, EventArgs e){
			if(dataTelefono.Rows.Count>0){
				if(DialogResult.Yes==MessageBox.Show("¿Desea remover el teléfono seleccionada de la tabla?","Remover teléfono",MessageBoxButtons.YesNo,MessageBoxIcon.Question)){
					if(operador.listTelefono[dataTelefono.CurrentRow.Index].id!= null){
						new Conexion_Servidor.Operador.SQL_Telefono().getEliminarTelefono(operador.listTelefono[dataTelefono.CurrentRow.Index].id);	
					}
					this.operador.listTelefono.RemoveAt(dataTelefono.CurrentRow.Index);	
					dataTelefono.DataSource= this.operador.listTelefono;
					((CurrencyManager)dataTelefono.BindingContext[operador.listTelefono]).Refresh();
				}	
			}
		}
		#endregion
		
		
		//--CARGAR_LICENCIA_A_LA_LISTA
		private void getCargarLista(){
			this.telefono=new Transportes_LAR.Interfaz.Operador.Dato.Telefono();
			telefono.tipo=cmbTipo.Text;
			telefono.numero=txtNumero.Text;
			telefono.descripcion=txtDescripcion.Text;
			this.operador.listTelefono.Add(telefono);
		}
		
		//--LIMPIAR_CAMPOS_DE_TEXTO
		private void getLimpiarCAmpo(){
			cmbTipo.SelectedIndex=0;
			txtNumero.Text="";
			txtDescripcion.Text="";
		}
		
		
		void BtnAgregarClick(object sender, EventArgs e){
			this.Close();
		}
		
		//--DOUBLE_CLICK_CELDA
		void DataTelefonoCellDoubleClick(object sender, DataGridViewCellEventArgs e){
			if(e.RowIndex>=0){
				new Interfaz.Operador.Modificar.FormTelefono(e.RowIndex,this.operador.listTelefono).ShowDialog();
				dataTelefono.DataSource= this.operador.listTelefono;
				((CurrencyManager)dataTelefono.BindingContext[operador.listTelefono]).Refresh();				
			}
		}
	}
}
