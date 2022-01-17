using System;
using System.Drawing;
using System.Windows.Forms;
 

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormBusquedaAdmin : Form
	{
		#region INSTANCIAS DE CLASES
		private Interfaz.FormPrincipal principal =null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region VARIABLES
		String tipo="ADM";
		#endregion
		
		#region CONSTRUCTORES
		public FormBusquedaAdmin(Interfaz.FormPrincipal principal){
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INCIO_DE_INTERFAZ
		void FormBusquedaOperadorLoad(object sender, EventArgs e){
			getValidacionPrivilegio();			
			dataEmpleado.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select Alias, Nombre, Apellido_Pat, Apellido_Mat, Calle, Colonia, Num_Interior, Num_Exterior, Municipio, Estatus, Fecha_Nacimiento, RFC, CURP, IMSS, Estado_Civil, Zona, Tipo_Empleado " +
			                                                                               "from Operador " +
			                                                                               "where Alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			if(cbTodos.Checked){
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			}else{
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where Estatus = '1' and nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			}			
		}
		#endregion
		
		#region CONSULTAS_LIKE
		void TxtAliasTextChanged(object sender, EventArgs e){
			if(cbTodos.Checked){
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			}else{
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where Estatus = '1' and nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			}
			/*
			dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");*/
			dataEmpleado.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select Alias, Nombre, Apellido_Pat, Apellido_Mat, Calle, Colonia, Num_Interior, Num_Exterior, Municipio, Estatus, Fecha_Nacimiento, RFC, CURP, IMSS, Estado_Civil, Zona, Tipo_Empleado " +
			                                                                               "from Operador " +
			                                                                               "where Alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteActivoAdmin();
           	txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region EVENTOS_DE_LOS_BOTONES
		void BtnNuevoClick(object sender, EventArgs e){
			if(principal.operador)
			{
				MessageBox.Show("La ventana para agregar un nuevo ADMINISTRATIVO se encuentra abierta.","Agregar operador",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			principal.getInterfazOperador(principal, "ADM");
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			try
			{
				new Interfaz.Operador.FormOperador(principal,dataOperador[0,dataOperador.CurrentRow.Index].Value.ToString(), tipo).ShowDialog();
				if(cbTodos.Checked){
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
				}else{
					dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
				                                                                               "from operador " +
				                                                                               "where Estatus = '1' and nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
				                                                                               "order by Alias");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error:"+ex, "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
				
		#endregion
				
		#region DOUBLE_CLICK_AL_CONTENIDO_DE_LA_CELDA
		void DataOperadorCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0){
				
			}
		}
		#endregion
		
		#region EVENTO_CIERRE_DE_VENTANA
		void FormBusquedaOperadorFormClosing(object sender, FormClosingEventArgs e)
		{
			this.principal.busquedaAdmin=false;
		}
		#endregion
		
		#region VALIDACION_DE_PRIVILEGIOS_DEL_USUARIO
		private void getValidacionPrivilegio()
		{
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_operador",principal.login.usuario))[0]=="0"){
				btnNuevo.Visible=false;
			}else{
				btnModificar.Visible=true;
			}
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_operador",principal.login.usuario))[1]=="0"){
				btnModificar.Visible=false;
			}else{
				btnModificar.Visible=true;
			}
		}
		#endregion
		
		#region GENERADOR REPORTES
		void BtnExcelClick(object sender, EventArgs e)
		{
			Excels.DatosAdmin(principal);
		}
		#endregion
		
		void CbTodosCheckedChanged(object sender, EventArgs e)
		{
			if(cbTodos.Checked){
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			}else{
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado " +
			                                                                               "from operador " +
			                                                                               "where Estatus = '1' and nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and Tipo_Empleado !='OPERADOR' " +
			                                                                               "order by Alias");
			}
		}
	}
}
