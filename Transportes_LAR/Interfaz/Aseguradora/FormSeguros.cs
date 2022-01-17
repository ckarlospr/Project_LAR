using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Aseguradora
{
	public partial class FormSeguros : Form
	{
		private Interfaz.FormPrincipal principal =null;
		
		public List<Dato.Aseguradora> laseguradora = new List<Dato.Aseguradora>();
		public string idaseguradora = "0"; 
		public string idunidad = "0";
		public string idseguro = "0";
		public bool editable = false;
		public bool guardar = true;
		public bool habilitado = true;
		public int paso =0;
		public int step = 0;
		public String vencimiento;
	
		#region CONSTRUCTORES	
		public FormSeguros(Interfaz.FormPrincipal principal){
			InitializeComponent();
			cargarListaAseguradora();
			habilitardeshaboilitar();
			cargarValidacionCampos();
			this.principal = principal;
			this.dtpVencimiento.MinDate =  DateTime.Today;
			txtCobertura.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCobertura.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtCobertura.AutoCompleteCustomSource = new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getListaAutocompletar();
		}
		#endregion
		
		#region manejoBotones
		public void manejoBotones()
		{
			if((!editable) && (!guardar))
			{ //se puede modificar
				btnGuardarEditar.Text = "Modificar";
			}
			else if((editable) && (!guardar))
			{
				btnGuardarEditar.Text = "Guardar";
			}
			else
			btnGuardarEditar.Text = "Guardar";
			btnCancelar.Text = (editable)? "Cancelar" : "Aceptar";
		}
		#endregion
		
		#region cargarListaAseguradora
		public void cargarListaAseguradora()
		{
			dgvSinAsegurar.DataSource = new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getTabla(4);
			new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getListaAseguradora(this);
			dgvAsegurados.DataSource = new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getTabla(1);

		}
		#endregion
		
		#region limpiarCamposUnidad
		public void limpiarCamposUnidad()
		{
			txtUPE.Text="";
			txtUPF.Text="";
			txtUTipo.Text="";
		}
		#endregion		
		
		#region limpiarCamposAseguradora
		public void limpiarCamposAseguradora()
		{
			cmbAseguradoras.Text="";
			txtCobertura.Text="";
			txtNumeroSeguro.Text="";
		}
		#endregion
		
		#region CmbAseguradorasTextChanged
		void CmbAseguradorasTextChanged(object sender, EventArgs e)
		{
			habilitado = false;
			txtDomicilio.Text="";
			txtTelefono.Text="";
			idaseguradora ="0";
			if(cmbAseguradoras.Text.Length>0){
				idaseguradora = "0";
				for(int c = 0; c<laseguradora.Count;c++){
					if(cmbAseguradoras.Text.Equals(laseguradora[c].nombre)){
						txtDomicilio.Text = laseguradora[c].domicilio;
						txtTelefono.Text = laseguradora[c].telefono;
						idaseguradora = laseguradora[c].ID;
						break;
					}
				}
				habilitado =true;
			}
			habilitardeshaboilitar();
		}
		#endregion
		
		#region habilitardeshabilitar
		public void habilitardeshaboilitar()
		{
			if(cmbAseguradoras.Text.Length>0 && editable)
			{
				gbSeguro.Enabled = true;
				gbPoliza.Enabled = true;
				if(txtDomicilio.Text.Equals("")&&txtTelefono.Text.Equals(""))
				{
					txtDomicilio.Enabled = true;
					txtTelefono.Enabled = true;
				}
				else
				{
					txtDomicilio.Enabled = false;
					txtTelefono.Enabled = false;
				}
			}
			else
			{
				gbSeguro.Enabled = false;
				gbPoliza.Enabled = false;
				gbAseguradora.Enabled = false;
			}
			if((txtUNum.Text.Length>0)&&
			   (txtUPE.Text.Length>0)&&
			   (txtUPF.Text.Length>0)&&
			   (txtUTipo.Text.Length>0)){
				paso++;
				gbAseguradora.Enabled = editable;
				
			}
				manejoBotones();
				btnGuardarEditar.Enabled = (guardar)? habilitado : true;
		}
		#endregion 
		
		#region TxtUNumTextChanged
		void TxtUNumTextChanged(object sender, EventArgs e)
		{
			btnEliminar.Visible= false;
			guardar = true;
			habilitado = false;
			limpiarCamposUnidad();
			limpiarCamposAseguradora();
			new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getDatosUnidad(this);
			if(!idunidad.Equals("0"))
			{
				new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getseguroUnidadVigente(this);
				if(!idunidad.Equals("0"))
				{
					if(txtNumeroSeguro.Text.Length!=0)
							btnEliminar.Visible = true;
					habilitado = true;
					guardar = false;
				}
			}
			else
				limpiarCamposUnidad();
			
			habilitardeshaboilitar();
			if(!idaseguradora.Equals("0"))
				manejoBotones();
		}
		#endregion
		
		#region DgvSinAsegurarCellEnter
		void DgvSinAsegurarCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			dgvSinAsegurar.Rows[e.RowIndex].Selected = true;
			DataGridViewRow	fila = dgvSinAsegurar.CurrentRow;
			txtUNum.Text = Convert.ToString(fila.Cells[0].Value);
			habilitado = false;
			guardar=true;
			habilitardeshaboilitar();
			manejoBotones();
		}
		#endregion
		
		#region FormSeguros  ( Load - Closing )
		void FormSegurosLoad(object sender, EventArgs e)
		{
			limpiarCamposUnidad();
			vencimiento = dtpVencimiento.Value.ToString("yyyy-MM-dd");;
		}
		
		void FormSegurosFormClosing(object sender, FormClosingEventArgs e)
		{	
			principal.seguro=false;
		}
		#endregion
		
		#region guardarSeguro - BtnGuardarEditarClick	
		public void guardarSeguro()
		{
			try{	
				if(idaseguradora.Equals("0"))
				{
				new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getInsertarAseguradora(cmbAseguradoras.Text,txtDomicilio.Text,txtTelefono.Text);
				new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getListaAseguradora(this);
				}
				string tem = cmbAseguradoras.Text;
				cmbAseguradoras.Text="";
				cmbAseguradoras.Text = tem;
				new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().GuardarSeguro(this);
				cargarListaAseguradora();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Verifique que los campos sean correctos.\n" + ex.ToString(),"Error al Guardar",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnGuardarEditarClick(object sender, EventArgs e)
		{
			
			if((!editable) && (!guardar))
				editable=true;
			else if((editable) && (!guardar))
			{
				if(new Proceso.LimpiarCampo.SegurosAseguradoras().validarCamposSeguro(this)&&(txtDomicilio.Text.Length>0))
				{
					guardarSeguro();
					editable=false;
					guardar=false;
				}
			}
			else if(editable && guardar && gbUnidad.Enabled && gbAseguradora.Enabled && gbSeguro.Enabled && gbPoliza.Enabled)
			{
				if(new Proceso.LimpiarCampo.SegurosAseguradoras().validarCamposSeguro(this)&&(txtDomicilio.Text.Length>0))
					guardarSeguro();
			}
			manejoBotones();
			habilitardeshaboilitar();
		}
		#endregion
		
		#region DgvAseguradosCellEnter
		void DgvAseguradosCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			dgvAsegurados.Rows[e.RowIndex].Selected = true;
			DataGridViewRow	fila = dgvAsegurados.CurrentRow;
			txtUNum.Text = Convert.ToString(fila.Cells[0].Value);
		}
		#endregion

		#region cargarValidacionCampos
		void cargarValidacionCampos()
		{
			this.txtUNum.KeyPress += new KeyPressEventHandler( Proceso.ValidarCampo.soloLetrasNumerosGuion);
			this.cmbAseguradoras.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			this.txtCobertura.KeyPress += new KeyPressEventHandler( Proceso.ValidarCampo.soloLetras);
			this.txtNumeroSeguro.KeyPress += new KeyPressEventHandler( Proceso.ValidarCampo.soloNumeros);
			this.txtTelefono.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
			this.txtDomicilio.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyOtros);
		}
		#endregion
		
		#region BtnCancelarClick
		void BtnCancelarClick(object sender, EventArgs e)
		{
			if((editable) && (!guardar))
			{
				editable=false;
				guardar=false;
				habilitardeshaboilitar();
			}
			else
			{
				if(editable && guardar && gbUnidad.Enabled && gbAseguradora.Enabled && gbSeguro.Enabled && gbPoliza.Enabled)
				{
					limpiarCamposUnidad();
					limpiarCamposAseguradora();
					editable = true;
					guardar = true;
				}
				else
				{
					this.Close();
				}
			}
		}
		#endregion
		
		#region BtnEliminarClick
		void BtnEliminarClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().eliminarSeguroUnidad(idunidad);
			cargarListaAseguradora();
			limpiarCamposUnidad();
		}
		#endregion
		
		
		void DtpVencimientoValueChanged(object sender, EventArgs e)
		{
			vencimiento = dtpVencimiento.Value.ToString("yyyy-MM-dd");
		}
		
		void TimeImageTick(object sender, EventArgs e)
		{
			if(btnGuardarEditar.Text == "Modificar")
				btnGuardarEditar.Image = ListaImagenes.Images[3];
			else
				btnGuardarEditar.Image = ListaImagenes.Images[2];
			
			if(btnCancelar.Text == "Cancelar")
				btnCancelar.Image = ListaImagenes.Images[1];
			else
				btnCancelar.Image = ListaImagenes.Images[0];
		}
	}
}
