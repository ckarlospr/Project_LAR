using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Aseguradora
{
	public partial class FormAseguradoras : Form
	{
		private Interfaz.FormPrincipal principal = null;
		
		private bool habilitado = false;
		private bool Guardar = true;
		private string idAseguradora = "0";
		private bool seleccion = false;
		
		public FormAseguradoras()
		{
			InitializeComponent();
			cargarLista();
			prepararNuevo();
		}
		
		public FormAseguradoras(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			cargarLista();
			prepararNuevo();
			this.principal = principal;
		}
		
		void BtnAgregarModificarClick(object sender, EventArgs e)
		{
			if(habilitado)
			{
				if(new Dato.SegurosAseguradoras().validarCamposAseguradora(this))
				{
					bool ok = false;
					try{
						if(Guardar)
						{	// PARA GUARDAR
							if(new Proceso.LimpiarCampo.LimpiarAseguradora(this).getValidarCampos())
							{
								if(!new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getExistenciaAseguradora(txtNombre.Text)){
									new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getInsertarAseguradora(txtNombre.Text,txtDomicilio.Text,txtTelefono.Text);
									ok = true;
								}
								else
									MessageBox.Show("Ya se encuentra almacenado un registo de nombre '"+ txtNombre.Text+"'.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
							}
						}
						else
						{			// PARA MODIFICAR
							new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getModificarAseguradora(idAseguradora,txtNombre.Text,txtDomicilio.Text,txtTelefono.Text);
							ok = true;
						}
						
					}catch{
						MessageBox.Show("Error de acceso a la base de datos, verifique que la conexión del servidor se encuentre establecida y que la configuración sea la correcta.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					}
					if(ok)
					{
						cargarLista();
						new Dato.SegurosAseguradoras().limpiarCamposAseguradora(this);
						habilitardeshabilitar();
						manejarEstados();
					}
				}
			}
			else
				limpiarCampos();
			
			habilitardeshabilitar();
			manejarEstados();
		}
		
		public void cargarLista()
		{
			dgvAseguradora.DataSource = new Conexion_Servidor.SegurosAseguradora.ConexionSegurosAseguradoras().getTabla(3);
		}
		
		public void habilitardeshabilitar()
		{
			habilitado = !habilitado;
			txtNombre.Enabled = habilitado;
			txtDomicilio.Enabled = habilitado;
			txtTelefono.Enabled = habilitado;
			Cancelar.Enabled = habilitado;
		}
		public void prepararNuevo()
		{
			Guardar= true;
			habilitado = true;	
			habilitardeshabilitar();
		//	limpiarCampos();
			manejarEstados();
		}

		public void manejarEstados()
		{
			btnAgregarModificar.Text = 
				(habilitado) ?	"Guardar":
				(Guardar) ? 	"Nuevo" : 
				"Nuevo";
			if(!habilitado)
			{
				if(seleccion)
				{
					Cancelar.Enabled =true;
					Cancelar.Text = "Modificar";
					btnAnadirSeguros.Visible = true;
					btnAnadirSeguros.Text = "Seguros";
				}
				else
					btnAnadirSeguros.Visible = false;
			}
			else
			{
				Cancelar.Text = "Cancelar";
				btnAnadirSeguros.Enabled = true;
				btnAnadirSeguros.Text = "Eliminar";
					
			}
		btnAnadirSeguros.Visible =(!Cancelar.Enabled || seleccion);
		if(!Cancelar.Enabled) btnAnadirSeguros.Text = "Seguros";
		seleccion = false;
		}
		
		
		void CancelarClick(object sender, EventArgs e)
		{
			if(habilitado) 
			{
				prepararNuevo();
				manejarEstados();
			MessageBox.Show("Listo para insertar una nueva Aseguradora","");
			}
			else
			{
				Guardar = false;
				habilitado = false;
				habilitardeshabilitar();
				manejarEstados();
			}
		}
		
		public void limpiarCampos()
		{
			new Proceso.LimpiarCampo.SegurosAseguradoras().limpiarCamposAseguradora(this);
		}
		
		void DgvAseguradoraCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			
			limpiarCampos();
			seleccion = true;
			dgvAseguradora.Rows[e.RowIndex].Selected = seleccion;
			DataGridViewRow	fila = dgvAseguradora.CurrentRow;
			this.idAseguradora = Convert.ToString(fila.Cells[0].Value);
			this.txtNombre.Text=Convert.ToString(fila.Cells[1].Value);
			this.txtDomicilio.Text=Convert.ToString(fila.Cells[2].Value);
			this.txtTelefono.Text=Convert.ToString(fila.Cells[3].Value);
			habilitado = true;
			
			if(txtNombre.Text.Length!=0)
			{
				habilitardeshabilitar();
				manejarEstados();
			}
			else
			{
				seleccion = false;
				prepararNuevo();
			}
				
		}
		
		void DgvAseguradoraCellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void BtnAnadirSegurosClick(object sender, EventArgs e)
		{
			if(principal.seguro)
			{
				if(principal.formSeguro.WindowState==FormWindowState.Minimized)
					principal.formSeguro.WindowState = FormWindowState.Normal;
				else
					principal.formSeguro.BringToFront();
			}
			else
			{
				principal.formSeguro=new Transportes_LAR.Interfaz.Aseguradora.FormSeguros(principal);
				principal.formSeguro.BringToFront();
				principal.formSeguro.Show();
				principal.formSeguro.MdiParent=principal;
				principal.seguro=true;
			}
		}
		
		void FormAseguradorasFormClosing(object sender, FormClosingEventArgs e)
		{
			this.principal.aseguradora = false;
		}
		
		void TimeImageTick(object sender, EventArgs e)
		{
			if(btnAgregarModificar.Text == "Nuevo")
				btnAgregarModificar.Image = ListaImagenes.Images[3];
			else
				btnAgregarModificar.Image = ListaImagenes.Images[1];
			
			if(Cancelar.Text == "Cancelar")
				Cancelar.Image = ListaImagenes.Images[0];
			else
				Cancelar.Image = ListaImagenes.Images[2];
		}
	}
}
