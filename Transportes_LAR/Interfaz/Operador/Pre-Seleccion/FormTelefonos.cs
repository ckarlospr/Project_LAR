using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormTelefonos : Form
	{
		#region INSTANCIAS
		private Interfaz.Operador.Pre_Seleccion.FormContratacion contratacion = null;
		Operador.Dato.Telefonos telefono = null;
		#endregion
		
		#region CONSTRUCTOR
		public FormTelefonos(Interfaz.Operador.Pre_Seleccion.FormContratacion refContratacion)
		{
			contratacion = refContratacion;
			InitializeComponent();
		}
		#endregion
				
		#region INICIO - FIN		
		void FormTelefonosLoad(object sender, EventArgs e)
		{			
			this.txtNumeroContacto.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			limpiarContacto();
		}
		
		void FormTelefonosFormClosing(object sender, FormClosingEventArgs e)
		{
			try{
				if(contratacion.ListarTelefonos != null){
					if(contratacion.ListarTelefonos.Count > 0 && contratacion.txtNumCelular.Text.Length == 0){
						contratacion.txtNumCelular.Text = contratacion.ListarTelefonos[0].numero;
						contratacion.lblRelacionContacto.Text = contratacion.ListarTelefonos[0].relacion;
					}
				}
			}catch(Exception){
				
			}
		}
		#endregion
		
		#region BOTONES
		void BtnAgregarContactoClick(object sender, EventArgs e)
		{
			if(validaContacto()){
				if(btnAgregarContacto.Text == "Modificar" && dgContacto.SelectedRows.Count == 1){
					contratacion.ListarTelefonos[dgContacto.CurrentCell.RowIndex].tipo = cmbTipoContacto.Text;
					contratacion.ListarTelefonos[dgContacto.CurrentCell.RowIndex].numero = txtNumeroContacto.Text;
					contratacion.ListarTelefonos[dgContacto.CurrentCell.RowIndex].relacion = cmbRelacionContacto.Text;
					contratacion.ListarTelefonos[dgContacto.CurrentCell.RowIndex].nombre = txtNombreContacto.Text;
					
					if(cmbRelacionContacto.Text == "PROPIO")
						contratacion.txtNumCelular.Text = txtNumeroContacto.Text;
					limpiarContacto();
				}else{
					telefono = new Operador.Dato.Telefonos();
					telefono.id = "0";
					telefono.tipo = cmbTipoContacto.Text;
					telefono.numero = txtNumeroContacto.Text;
					telefono.relacion = cmbRelacionContacto.Text;
					telefono.nombre = txtNombreContacto.Text;		
					telefono.estatus = "Activo";					
					contratacion.ListarTelefonos.Add(telefono);	

					if(cmbRelacionContacto.Text == "PROPIO" && contratacion.txtNumCelular.Text.Length == 0)
						contratacion.txtNumCelular.Text = txtNumeroContacto.Text;
			
					limpiarContacto();
					//((CurrencyManager)dgContacto.BindingContext[contratacion.ListarTelefonos]).Refresh();
				}
			}
		}		
		
		void BtnCancelarContactoClick(object sender, EventArgs e)
		{
			if(btnAgregarContacto.Text == "Modificar" && dgContacto.SelectedRows.Count == 1)
				limpiarContacto();			
		}
		#endregion
		
		#region METODOS		
		private void ColoresAlternadosRows(DataGridView datag){
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		
		private bool validaContacto(){
			bool respuesta = true;
			
			errorProvider1.Clear();
			if(cmbTipoContacto.SelectedIndex == -1){
				errorProvider1.SetError(cmbTipoContacto, "Ingresa el tipo del numero de contacto");
				cmbTipoContacto.Focus();
				respuesta = false;
			}
			if(txtNumeroContacto.Text.Length < 9){
				errorProvider1.SetError(txtNumeroContacto, "Ingresa los 10 digitos del número de contacto");
				txtNumeroContacto.Focus();
				respuesta = false;
			}
			if(txtNombreContacto.Text.Length == 0){
				errorProvider1.SetError(txtNombreContacto, "Ingresa el nombre del dueño del número de contacto");
				txtNombreContacto.Focus();
				respuesta = false;
			}
			return respuesta;
		}
		
		private void limpiarContacto(){
			ColoresAlternadosRows(dgContacto);
			contratacion.lblRelacionContacto.Text = "";
			btnAgregarContacto.Text = "Agregar";
			cmbTipoContacto.SelectedIndex = 0;
			txtNumeroContacto.Text = "";
			cmbRelacionContacto.SelectedIndex = 0;
			txtNombreContacto.Text = "PROPIO";
			dgContacto.Rows.Clear();
			
			if(contratacion.ListarTelefonos == null)
				contratacion.ListarTelefonos = new System.Collections.Generic.List<Transportes_LAR.Interfaz.Operador.Dato.Telefonos>();						
			else{				
				for (int i = 0; i < contratacion.ListarTelefonos.Count; i++)
					dgContacto.Rows.Add(contratacion.ListarTelefonos[i].id, contratacion.ListarTelefonos[i].tipo, contratacion.ListarTelefonos[i].numero, contratacion.ListarTelefonos[i].relacion, contratacion.ListarTelefonos[i].nombre, contratacion.ListarTelefonos[i].estatus);
			}
			
			for (int x = 0; x < dgContacto.RowCount; x++){
				if(dgContacto[5, x].Value.ToString() == "Inactivo"){					
					for(int y=0; y<dgContacto.ColumnCount; y++)
						dgContacto[y, x].Style.BackColor = Color.Red;
				}
			}
					
			btnCancelarContacto.Enabled = false;
			dgContacto.ClearSelection();
			cmbTipoContacto.Focus();
		}
		#endregion
		
		#region EVENTOS
		void FormTelefonosKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}		
	
		void TxtNombreContactoClick(object sender, EventArgs e)
		{
			if(txtNombreContacto.Text == "PROPIO")
				txtNombreContacto.SelectAll();
		}		
				
		void DgContactoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && e.ColumnIndex != 6){
				cmbTipoContacto.Text = contratacion.ListarTelefonos[e.RowIndex].tipo;
				txtNumeroContacto.Text = contratacion.ListarTelefonos[e.RowIndex].numero;
				cmbRelacionContacto.Text = contratacion.ListarTelefonos[e.RowIndex].relacion;	
				txtNombreContacto.Text = contratacion.ListarTelefonos[e.RowIndex].nombre;				
				btnAgregarContacto.Text = "Modificar";				
				btnCancelarContacto.Enabled = true;
			}
		}		
		
		void DgContactoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1 && e.ColumnIndex == 6){
				if(dgContacto[5, e.RowIndex].Value.ToString() == "Inactivo")
					contratacion.ListarTelefonos[e.RowIndex].estatus = "Activo";
				else
					contratacion.ListarTelefonos[e.RowIndex].estatus = "Inactivo";				
				limpiarContacto();
			}
		}		
		
		void TxtNumeroContactoLeave(object sender, EventArgs e)
		{
			if(txtNumeroContacto.Text.Length == 10 && (!txtNumeroContacto.Text.Contains(" ")))
				txtNumeroContacto.Text = txtNumeroContacto.Text.Substring(0,3)+" "+txtNumeroContacto.Text.Substring(3,4)+" "+txtNumeroContacto.Text.Substring(7, 3);
			if(txtNumeroContacto.Text.Length == 8 && (!txtNumeroContacto.Text.Contains(" ")))
				txtNumeroContacto.Text = txtNumeroContacto.Text.Substring(0,2)+" "+txtNumeroContacto.Text.Substring(2,3)+" "+txtNumeroContacto.Text.Substring(5, 3);			
		}
		
		void TxtNumeroContactoEnter(object sender, EventArgs e)
		{
			txtNumeroContacto.Text = txtNumeroContacto.Text.Replace(" ", "");
		}
		#endregion
	}
}