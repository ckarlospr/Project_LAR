using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Usuario
{
	public partial class FormBusquedaUsuario : Form
	{
		private Interfaz.FormPrincipal principal =null;	
		
		public FormBusquedaUsuario(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		
		//--EVENTO_INICIO_DE_INTERFAZ
		void FormBusquedaUsuarioLoad(object sender, EventArgs e)
		{
			getValidacionPrivilegio();
			if(cbTodos.Checked){
				dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
			}else{
				dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE Estatus='1' and usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
			}
		}
		
		//--EVENTO_BUSQUEDAS_LIKE
		void TxtUsuarioNombreTextChanged(object sender, EventArgs e)
		{
			if(cbTodos.Checked){
				dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
			}else{
				dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE Estatus='1' and usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
			}
		}
		
		//--EVENTOS_CIERRE_DE_VENTANA
		void FormBusquedaUsuarioFormClosing(object sender, FormClosingEventArgs e)
		{
			this.principal.busquedaUsuario=false;
		}
		
		#region EVENTO_DE_BOTONES (ACEPTAR_CANCELAR)
		void BtnModificarClick(object sender, EventArgs e){
			if(this.principal.usuario)
			{
				MessageBox.Show("En este momento no se pude llevar a cabo la modificación debido a que se encuentra abierta la ventana de agregar usuario.\nPara poder continuar es necesario que cierre la interfaz.","Moficar usuario del sistema",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
			else
			{
				try
				{
					try
					{
						new Interfaz.Usuario.FormUsuario(2,principal,dataUsuario[0,dataUsuario.CurrentRow.Index].Value.ToString()).ShowDialog();
					}
					catch{}
					if(cbTodos.Checked){
						dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
					}else{
						dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE Estatus='1' and usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
					}
					getValidacionPrivilegio();
				}
				catch
				{
					MessageBox.Show("Para poder modificar a un usuario es necesario que previamente seleccione un elemento de la búsqueda.","Modificar usuario",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				}
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Desea eliminar al usuario "+dataUsuario[2,dataUsuario.CurrentRow.Index].Value.ToString()+" "+dataUsuario[3,dataUsuario.CurrentRow.Index].Value.ToString()+" "+dataUsuario[4,dataUsuario.CurrentRow.Index].Value.ToString()+" de los registros de la base de datos?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				if(principal.nombreUsuario==dataUsuario[1,dataUsuario.CurrentRow.Index].Value.ToString())
				{//COMPARANDO QUE EL PRESENTE USUARIO NO ELIMINE SU REGISTRO
					MessageBox.Show("El usuario no puede ser eliminado ya que es la persona la cual está usando el sistema.","Eliminando usuario",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				}
				else
				{
					new Conexion_Servidor.Usuario.SQL_Usuario().getEliminarUsuario(dataUsuario[0,dataUsuario.CurrentRow.Index].Value.ToString());
					new Interfaz.FormMensaje("Usuario eliminado correctamente").Show();	
				}
			}
		}
		
		#endregion
		
		//--EVENTO_DOBLE_CLICK_AL_CONTENIDO_DE_LA_TABLA
		void DataUsuarioCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string texto=dataUsuario[2,dataUsuario.CurrentRow.Index].Value.ToString()+" "+dataUsuario[3,dataUsuario.CurrentRow.Index].Value.ToString()+" "+dataUsuario[4,dataUsuario.CurrentRow.Index].Value.ToString();
				new Interfaz.Usuario.FormDetallePrivilegio(dataUsuario[0,dataUsuario.CurrentRow.Index].Value.ToString(),texto).ShowDialog();
			}
			catch{}
		}
		
		//--EVALUACION_DE_PRIVILEGIOS_DEL_USUARIO
		private void getValidacionPrivilegio()
		{
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_usuario",principal.login.usuario))[1]=="0")
			{
				btnModificar.Visible=false;
			}
			else
			{
				btnModificar.Visible=true;
			}
			
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_usuario",principal.login.usuario))[2]=="0")
			{
				btnEliminar.Visible=false;
			}
			else
			{
				btnEliminar.Visible=true;
			}
		}
		
		
		void DataUsuarioCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==5&&dataUsuario.Rows[e.RowIndex].Cells[5].Value.ToString()=="ACTIVO")
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro que deseas desactivar este Usuario?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Transportes_LAR.Conexion_Servidor.Usuario.SQL_Usuario().getActualizarEstatus(dataUsuario.Rows[e.RowIndex].Cells[0].Value.ToString(), "0");
					if(cbTodos.Checked){
						dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
					}else{
						dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE Estatus='1' and usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
					}
				}
				
			}
			else if(e.ColumnIndex==5&&dataUsuario.Rows[e.RowIndex].Cells[5].Value.ToString()=="INACTIVO")
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro que deseas activar este Usuario?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Transportes_LAR.Conexion_Servidor.Usuario.SQL_Usuario().getActualizarEstatus(dataUsuario.Rows[e.RowIndex].Cells[0].Value.ToString(), "1");
					if(cbTodos.Checked){
						dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
					}else{
						dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE Estatus='1' and usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
					}
				}
			}
		}
		
		void CbTodosCheckedChanged(object sender, EventArgs e)
		{
			if(cbTodos.Checked){
				dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
			}else{
				dataUsuario.DataSource= new Conexion_Servidor.Usuario.SQL_Usuario().getTabla("SELECT id_usuario as dataID,usuario as dataUsuario,nombre as dataNombre, apellido_pat as dataApellidoP, apellido_mat as dataApellidoM, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as Estado FROM usuario WHERE Estatus='1' and usuario like '"+txtUsuario.Text+"%' and nombre like '"+txtUsuarioNombre.Text+"%' and apellido_pat like '"+txtUsuarioApellidoP.Text+"%' and apellido_mat like '"+txtUsuarioApellidoM.Text+"%'");
			}
		}
	}
}
