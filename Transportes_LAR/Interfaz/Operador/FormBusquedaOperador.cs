using System;
using System.Drawing;
using System.Windows.Forms;
 

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormBusquedaOperador : Form
	{
		#region INSTANCIAS DE CLASES
		private Interfaz.FormPrincipal principal =null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region CONSTRUCTORES
		public FormBusquedaOperador(Interfaz.FormPrincipal principal){
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INCIO_DE_INTERFAZ
		void FormBusquedaOperadorLoad(object sender, EventArgs e){
			getValidacionPrivilegio();
			//dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado from operador where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo') order by Alias");
			if(cbTodos.Checked)
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado from operador where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo') order by Alias");
			else
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado from operador where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo') and Estatus = '1' order by Alias");
			dataEmpleado.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select * from Operador where Estatus='1' AND (tipo_empleado='OPERADOR' or tipo_empleado='Externo') and Alias!='Admvo' order by alias");
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR WHERE (tipo_empleado='OPERADOR' or tipo_empleado='Externo')", "Alias");
           	txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region CONSULTAS_LIKE
		void TxtAliasTextChanged(object sender, EventArgs e)
		{
			if(cbTodos.Checked)
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado from operador where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo') order by Alias");
			else
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado from operador where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo') and Estatus = '1' order by Alias");
		}
		#endregion
		
		#region EVENTOS_DE_LOS_BOTONES
		void BtnNuevoClick(object sender, EventArgs e){
			if(principal.operador)
			{
				MessageBox.Show("La ventana para agregar un nuevo operador se encuentra abierta.","Agregar operador",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			principal.getInterfazOperador(principal, "OPE");
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			try
			{
			new Interfaz.Operador.FormOperador(principal,dataOperador[0,dataOperador.CurrentRow.Index].Value.ToString()).ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ocurrio "+ex);
			}
		}
				
		#endregion
		
		#region EVENTO_CIERRE_DE_VENTANA
		void FormBusquedaOperadorFormClosing(object sender, FormClosingEventArgs e)
		{
			this.principal.busquedaOperador=false;
		}
		#endregion
		
		#region VALIDACION_DE_PRIVILEGIOS_DEL_USUARIO
		private void getValidacionPrivilegio(){
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_operador",principal.login.usuario))[0]=="0")
				btnNuevo.Visible=false;
			else
				btnModificar.Visible=true;
			
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_operador",principal.login.usuario))[1]=="0")
				btnModificar.Visible=false;
			else
				btnModificar.Visible=true;
			
			if(principal.lblDatoUsuario.Text == "CESAR"){
				btnModificar.Visible = true;
				btnModificar.Visible = true;				
			}
		}
		#endregion
		
		#region REPORTE DE OPERADORES
		void BtnExcelClick(object sender, EventArgs e)
		{
			Excels.DatosOP(principal);
		}
		#endregion
		
		void CbTodosCheckedChanged(object sender, EventArgs e)
		{
			if(cbTodos.Checked)
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado from operador where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo') order by Alias");
			else
				dataOperador.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID as dataID,alias as dataAlias,nombre as dataNombre, apellido_pat as dataApellidoPat,apellido_mat as dataApellidoMat, (case when Estatus='1' then 'ACTIVO' else 'INACTIVO' end) as dataEstado from operador where nombre like '"+txtNombre.Text+"%' and apellido_pat like '"+txtApellidoP.Text+"%'  and apellido_mat like'"+txtApellidoM.Text+"%' and alias like '"+txtAlias.Text+"%' and (tipo_empleado='OPERADOR' or tipo_empleado='Externo') and Estatus = '1' order by Alias");
		}
	}
}
