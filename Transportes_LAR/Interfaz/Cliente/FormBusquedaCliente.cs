using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Cliente
{
	public partial class FormBusquedaCliente : Form
	{
		#region INSTANCIAS
		private Interfaz.FormPrincipal principal=null;
		private Interfaz.Cliente.FormBuscar formBuscar=null;
		#endregion
		
		#region VARIABLES
		public bool buscar=false;
		#endregion
		
		#region CONSTRUCTOR
		public FormBusquedaCliente(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region EVENTO (LOAD - CLOSING)
		void FormBusquedaClienteLoad(object sender, EventArgs e)
		{
			dataCliente.DataSource=new Conexion_Servidor.Cliente.SQL_CLiente().getTabla("select ID,Empresa,SubNombre FROM Cliente where Empresa!='Especiales' and ID not in (select ID_cliente from clientesEliminados) order by Empresa");
			getDatoCliente();
		}
		
		void FormBusquedaClienteFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.busquedaCliente=false;
			if(buscar)
				formBuscar.Close();
		}
		#endregion
		
		#region EVENTOS_BOTTON (AGREGAR - REMOVER - BUSCAR) Cliente
		void BtnAgreagarClick(object sender, EventArgs e)
		{
			checkBox1.Checked=false;
			new Interfaz.Cliente.FormCliente(dataCliente,this).ShowDialog();
			dataCliente.DataSource=new Conexion_Servidor.Cliente.SQL_CLiente().getTabla("select ID,Empresa,SubNombre FROM Cliente where Empresa!='Especiales' and ID not in (select ID_cliente from clientesEliminados) order by Empresa");
			getDatoCliente();
		}
		
		void BtnRemoverClick(object sender, EventArgs e)
		{
			checkBox1.Checked=false;
			if(dataCliente.Rows.Count>0)
			{
				if(MessageBox.Show("Al eliminar al cliente se eliminara todas sus rutas.\n¿Desea continuar con la eliminación?","Eliminar cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					new Conexion_Servidor.Cliente.SQL_CLiente().getEliminarCliente(dataCliente[0,dataCliente.CurrentRow.Index].Value.ToString());
					new Interfaz.FormMensaje("Cliente eliminado exitosamente").Show();
					dataCliente.DataSource=new Conexion_Servidor.Cliente.SQL_CLiente().getTabla("select ID,Empresa,SubNombre FROM Cliente where Empresa!='Especiales' and ID not in (select ID_cliente from clientesEliminados) order by Empresa");
					getDatoCliente();
				}
			}
			
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			if(dataCliente.Rows.Count>0)
			{
				if(buscar)
					formBuscar.BringToFront();
				else
				{
					formBuscar=new Interfaz.Cliente.FormBuscar(this,dataCliente);
					formBuscar.Show();
				}	
			}
		}
		#endregion
		
		#region EVENTO_CLICK_EN_LA_CELDA
		void DataClienteCellClick(object sender, DataGridViewCellEventArgs e)
		{
			checkBox1.Checked=false;
			if(e.RowIndex>=0)
				getDatoCliente();
		}
		
		void DataClienteCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			new Interfaz.Ruta.FormBusquedaRuta(dataCliente[0,e.RowIndex].Value.ToString(),
			                                   dataCliente[1,e.RowIndex].Value.ToString(),
			                                   dataCliente[2,e.RowIndex].Value.ToString(), 
			                                   principal
			                                  ).Show();
			principal.busquedaRuta = true;
		}
		#endregion
		
		#region EVENTOS_PARA_PODER_MODIFICAR_DATOS (CHECK BOX - KEYPRESS)
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(dataCliente.Rows.Count==0)
			{
				checkBox1.Checked=false;
			}
			else
			{
				if(checkBox1.Checked==true)
				{
					btnModificar.Enabled=true;
				}
				else
				{
					btnModificar.Enabled=false;
					getDatoCliente();
					getValidarCampo();
				}
			}	
		}
		
		
		void TxtEmpresaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(checkBox1.Checked==true)
				e.Handled=false;
			else
				e.Handled=true;
		}
		#endregion
		
		#region SQL_OPERACIONES
		public void getDatoCliente(){
			if(dataCliente.Rows.Count>0)
			{
				new Conexion_Servidor.Cliente.SQL_CLiente().getDatoCliente(dataCliente[0,dataCliente.CurrentRow.Index].Value.ToString(),
			                                                           txtEmpresa,
			                                                           txtSubNombre,
			                                                           txtDomicilio,
			                                                           txtZonaReferencia,
			                                                           txtMunicipio,
			                                                           txtEstado,
			                                                           txtRumbo,
			                                                           cmbTipoCobro);	
			}
			else
				getLimpiarCampo();
		}
		
		private void getModificarCliente()
		{
			new Conexion_Servidor.Cliente.SQL_CLiente().getModificarCliente(dataCliente[0,dataCliente.CurrentRow.Index].Value.ToString(),
			                                                                txtEmpresa.Text,
			                                                                txtSubNombre.Text,
			                                                                txtDomicilio.Text,
			                                                                txtZonaReferencia.Text,
			                                                                txtMunicipio.Text,
			                                                                txtEstado.Text,
			                                                                txtRumbo.Text,
				                                                            cmbTipoCobro.Text
				                                                            );
		}
		#endregion
		
		#region EVENTOS_BOTONES (MODIFICAR - CONTACTOS - ACEPTAR)
		void BtnModificarClick(object sender, EventArgs e)
		{
			if(getValidarCampo())
			{
				MessageBox.Show("Para poder modificar al cliente es necesario tener todos los campos llenos.","Modificar cliente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else
			{
				if(MessageBox.Show("¿Desea modificar al cliente "+txtEmpresa.Text+" "+txtSubNombre.Text+"?","Modificar cliente",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					getModificarCliente();
					new Interfaz.FormMensaje("Cliente modificado exitosamente").Show();
					checkBox1.Checked=false;
					dataCliente.DataSource=new Conexion_Servidor.Cliente.SQL_CLiente().getTabla("select ID,Empresa,SubNombre FROM Cliente where Empresa!='Especiales' and ID not in (select ID_cliente from clientesEliminados) order by Empresa");
					getDatoCliente();
					
				}	
			}
		}
		
		void BtnContactoServicioClick(object sender, EventArgs e)
		{
			checkBox1.Checked=false;
			if(dataCliente.Rows.Count>0)
				new Interfaz.Cliente.FormContacto(Convert.ToInt32(dataCliente[0,dataCliente.CurrentRow.Index].Value.ToString())).ShowDialog();
			else
				MessageBox.Show("Error en la busque de contactos, actualmente no se encuentra registrado un cliente en la base de datos.","Contactos de servicio",MessageBoxButtons.OK,MessageBoxIcon.Stop);
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region LIMPIAR_CAMPOS_DEL_FORMULARIO
		private void getLimpiarCampo()
		{
			txtEmpresa.Text="";
			txtSubNombre.Text="";
			txtDomicilio.Text="";
			txtDomicilio.Text="";
			txtZonaReferencia.Text="";
			txtMunicipio.Text="";
			txtEstado.Text="";
			txtRumbo.Text="";
		}
		#endregion
		
		#region CAMBIO_CON_TECLAS_LA_SELECCION_DE_LA_TABLA
		void DataClienteKeyUp(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter)
			{
				if(dataCliente.Rows.Count>0)
					getDatoCliente();
			}
		}
		#endregion
		
		#region VALIDAR_CAMPOS_VACIOS
		private bool getValidarCampo(){
			txtEmpresa.BackColor		=(txtEmpresa.Text=="")?Color.LightPink:Color.White;
			txtSubNombre.BackColor		=(txtSubNombre.Text=="")?Color.LightPink:Color.White;
			txtDomicilio.BackColor		=(txtDomicilio.Text=="")?Color.LightPink:Color.White;
			txtZonaReferencia.BackColor	=(txtZonaReferencia.Text=="")?Color.LightPink:Color.White;
			txtMunicipio.BackColor		=(txtMunicipio.Text=="")?Color.LightPink:Color.White;
			txtEstado.BackColor			=(txtEstado.Text=="")?Color.LightPink:Color.White;
			txtRumbo.BackColor			=(txtRumbo.Text=="")?Color.LightPink:Color.White;
			return (txtEmpresa.Text==""  ||
			       	txtSubNombre.Text==""||
			       	txtDomicilio.Text==""		||
			       	txtZonaReferencia.Text==""  ||
			       	txtMunicipio.Text==""||
			       	txtEstado.Text==""||
			       	txtRumbo.Text==""
			       )?true:false;
		}
		#endregion
		
		void CmdRelacionClick(object sender, EventArgs e)
		{
			new FormOrdenEmpresas().ShowDialog();
		}
	}
}
