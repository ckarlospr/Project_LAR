//((CurrencyManager)dataLicencia.BindingContext[operador.listLicencia]).Refresh(); - REFRESCAR_TABLA
//this.dataLicencia.CurrentCell = this.dataLicencia[1,2]; - SELECCIONAR UNA CELDA EN ESPECIFICO DEL DATA

using System;
using System.Data.Sql;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormLicencia : Form
	{
		private Interfaz.Operador.FormOperador operador=null;//MEMORIA_INTERFAZ_OPERADOR
		private Interfaz.Operador.Dato.Licencia licencia=null;//MOMORIA_INTERFAZ_MODIFICAR_DATO_DE_LICENCIA
		
		String id_operador="0";
		
		//-CONSTRUCTOR_DE_LA_CLASE
		public FormLicencia(Interfaz.Operador.FormOperador operador){
			InitializeComponent();
			this.operador=operador;
			getCargarValidacionCampos(this);
		}
		
		public FormLicencia(Interfaz.Operador.FormOperador operador, String id_operador){
			InitializeComponent();
			this.operador=operador;
			this.id_operador=id_operador;
			getCargarValidacionCampos(this);
		}
		
		//-EVENTO_CIERRE_DE_VENTANA
		void FormLicenciaFormClosing(object sender, FormClosingEventArgs e){
			this.operador.licencia=false;
			operador.BringToFront();
		}
		
		//--EVEMTO_INICIO_DE_VENTANA
		void FormLicenciaLoad(object sender, EventArgs e){
			cmbClase.SelectedIndex=0;
			cmbTipo.SelectedIndex=0;
			if(operador.listLicencia==null){
				this.operador.listLicencia=new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Licencia>();
			}else{
				dataLicencia.DataSource=this.operador.listLicencia;
			}
		}
		
		#region EVENTO_BOTONES (AGREGAR - REMOVER)
		
		void BtnAgregarLicenciaClick(object sender, EventArgs e)
		{
			if(txtNumero.Text!="" && cmbClase.Text!="" && cmbTipo.Text!="")
			{
				new Conexion_Servidor.Operador.SQL_Licencia().getInsertarLicenciaOperador(id_operador, cmbClase.Text, dateVigencia.Value.ToString().Substring(0,10), cmbTipo.Text, txtNumero.Text);
				getCargarLista();
				getLimpiarCampo();
				dataLicencia.DataSource= this.operador.listLicencia;
				((CurrencyManager)dataLicencia.BindingContext[operador.listLicencia]).Refresh();
			}
			else
			{
				MessageBox.Show("Para poder agregar la licencia del operador es necesario llenar todos los campos con los datos correspondientes.","Agregar licencia",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		
		void BtnRemoverLicenciaClick(object sender, EventArgs e){
			if(dataLicencia.Rows.Count>0){
				if(DialogResult.Yes==MessageBox.Show("¿Desea remover la licencia seleccionada de la tabla?","Remover licencia",MessageBoxButtons.YesNo,MessageBoxIcon.Question)){
					if(operador.listLicencia[dataLicencia.CurrentRow.Index].id != null)
					{
						new Conexion_Servidor.Operador.SQL_Licencia().getEliminarLicencia(operador.listLicencia[dataLicencia.CurrentRow.Index].id);
					}
					this.operador.listLicencia.RemoveAt(dataLicencia.CurrentRow.Index);
					dataLicencia.DataSource= this.operador.listLicencia;
					((CurrencyManager)dataLicencia.BindingContext[operador.listLicencia]).Refresh();
				}	
			}
		}
		
		#endregion
	
		#region EVENTO_BOTONES (ACEPTAR)
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		#endregion
	
		//--LIMPIAR_CAMPOS_DEL_FORMULARIO
		private void getLimpiarCampo()
		{
			txtNumero.Text="";
			cmbClase.SelectedIndex=0;
			cmbTipo.SelectedIndex=0;
			dateVigencia.Value=DateTime.Today;
		}
		
		//--CARGAR_LICENCIA_A_LA_LISTA
		private void getCargarLista()
		{
			this.licencia=new Transportes_LAR.Interfaz.Operador.Dato.Licencia();
			licencia.numero=txtNumero.Text;
			licencia.clase=cmbClase.Text;
			licencia.tipo=cmbTipo.Text;
			licencia.vigencia=dateVigencia.Value.ToString("yyyy-MM-dd");
			this.operador.listLicencia.Add(licencia);
		}
		
		
		//--DOUBLE_CLICK_CELDA
		void DataLicenciaCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)
			{
				new Interfaz.Operador.Modificar.FormLicencia(e.RowIndex,this.operador.listLicencia).ShowDialog();
				dataLicencia.DataSource= this.operador.listLicencia;
				((CurrencyManager)dataLicencia.BindingContext[operador.listLicencia]).Refresh();				
			}
		}
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(Interfaz.Operador.FormLicencia formLicencia)
		{
			formLicencia.txtNumero.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formLicencia.cmbClase.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formLicencia.cmbTipo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		#endregion
		
		void TxtNumeroTextChanged(object sender, EventArgs e)
		{
			txtNumero.Text=(txtNumero.Text==" ")?"":txtNumero.Text;
			if(cmbClase.Text==" ")
			{
				cmbClase.SelectedIndex=0;
			}
			if(cmbTipo.Text==" ")
			{
				cmbTipo.SelectedIndex=0;
			}
		}
	}
}
