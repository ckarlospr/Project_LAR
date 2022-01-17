using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Asignacion
{
	public partial class FormOperadorVehiculo : Form
	{
		#region VARIABLES
		String id_usuario = "";
		#endregion
		
		#region INSTANCIAS CLASES
		private Interfaz.FormPrincipal principal =null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region CONSTRUCTOR_DE_LA_CLASE
		public FormOperadorVehiculo(Interfaz.FormPrincipal principal, String id_usuario)
		{
			InitializeComponent();
			this.principal = principal;
			this.id_usuario =  id_usuario;
		}
		#endregion
		
		#region EVENTO (LOAD - CLOSING)
		void FormOperadorVehiculoLoad(object sender, EventArgs e)
		{
			getDatosTabla();
		}
		
		void FormOperadorVehiculoFormClosing(object sender, FormClosingEventArgs e)
		{
			this.principal.operadorVehiculo=false;
		}
		#endregion
				
		#region PRIVILEGIOS_DE_USUARIO
		private void getValidacionPrivilegio()
		{
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_operador",principal.login.usuario))[0]=="0")
			{
				btnAsignarOperador.Visible=false;
				btnDesignarOperador.Visible=false;
			}
			else
			{
				btnAsignarOperador.Visible=true;
				btnDesignarOperador.Visible=true;
			}
			if((new Conexion_Servidor.Usuario.SQL_Usuario().getCargarPrivilegio("derecho_operador",principal.login.usuario))[1]=="0")
			{
				btnAsignarOperador.Visible=false;
				btnDesignarOperador.Visible=false;
			}
			else
			{
				btnAsignarOperador.Visible=true;
				btnDesignarOperador.Visible=true;
			}
		}
		#endregion
		
		#region CARGAR_DATOS_DATAGRIDVIEW
		private void getDatosTabla()
		{
			String consulta = "select id, alias, tipo_empleado tipo from OPERADOR where tipo_empleado"+((rbOperador.Checked==true)?"='OPERADOR'":"!='Externo'")+" and Estatus=1 and ID not in (select ID_OPERADOR from ASIGNACIONUNIDAD) order by tipo_empleado, Alias";
			
			dataOperador.DataSource=	new Conexion_Servidor.Operador.SQL_Operador().getTabla(consulta);
			dataCamion.DataSource=		new Conexion_Servidor.Unidad.SQL_Unidad().getTabla("select id, numero, Marca from VEHICULO where Tipo_Unidad='Camión' and id not in (select ID_UNIDAD from ASIGNACIONUNIDAD)");
			dataCamioneta.DataSource= 	new Conexion_Servidor.Unidad.SQL_Unidad().getTabla("select id, numero, Marca from VEHICULO where Tipo_Unidad='Camioneta' and id not in (select ID_UNIDAD from ASIGNACIONUNIDAD)");
			dataUtilitario.DataSource= 	new Conexion_Servidor.Unidad.SQL_Unidad().getTabla("select id, numero, Marca from VEHICULO where Tipo_Unidad='Utilitario' and id not in (select ID_UNIDAD from ASIGNACIONUNIDAD)");
			
			dataOperadorVehiculo.DataSource=new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getTabla("select V.ID ID_UNIDAD, O.ID ID_OPERADOR, O.Alias OPERADOR, V.Numero UNIDAD, A.estatus, V.Marca MARCA  from ASIGNACIONUNIDAD A, VEHICULO V, OPERADOR O where A.ID_OPERADOR=O.ID and A.ID_UNIDAD=V.ID and  O.tipo_empleado"+((rbOperador.Checked==true)?"='OPERADOR'":"!='Externo'")+" order by OPERADOR");
		}
		#endregion
		
		#region EVENTO_BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion 
		
		#region EVENTO_BOTONES (ASIGNAR - DESASIGNAR)
		void BtnAsignarOperadorClick(object sender, EventArgs e)
		{
			bool unidad=false;
			if(dataOperador.Rows.Count>0 && (unidad=(tabVehiculo.SelectedIndex==0)?(dataCamion.Rows.Count>0)?true:false:(dataCamioneta.Rows.Count>0)?true:false))
			{
				// ID_UNIDAD - ID_OPERADOR	
				string idUnidad=(tabVehiculo.SelectedIndex==0)?dataCamion[0,dataCamion.CurrentRow.Index].Value.ToString():((tabVehiculo.SelectedIndex==1)?dataCamioneta[0,dataCamioneta.CurrentRow.Index].Value.ToString():dataUtilitario[0,dataUtilitario.CurrentRow.Index].Value.ToString());
				//MessageBox.Show(idUnidad);
				new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getInsertarAsignacionUnidad(idUnidad,dataOperador[0,dataOperador.CurrentRow.Index].Value.ToString(), id_usuario);
				new Interfaz.FormMensaje("Asignación establecida").Show();
				getDatosTabla();
			}
			else
			{
				string mensaje=(dataOperador.Rows.Count==0)?"No existen operadores sin vehículo.":"No existen unidades disponibles actualmente.";
				MessageBox.Show(mensaje,"Asiganción de vehículo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		
		void BtnDesignarOperadorClick(object sender, EventArgs e)
		{
			if(dataOperadorVehiculo.Rows.Count>0)
			{	
				new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getEliminarAsignacionUnidad(dataOperadorVehiculo[0,dataOperadorVehiculo.CurrentRow.Index].Value.ToString(),dataOperadorVehiculo[1,dataOperadorVehiculo.CurrentRow.Index].Value.ToString(), id_usuario);
				new Interfaz.FormMensaje("Desasignación establecida").Show();
				getDatosTabla();
			}
			else
			{
				string mensaje=(dataOperador.Rows.Count==0)?"No existen asignaciones.":"Realice una asignación operador vehiculo.";
				MessageBox.Show(mensaje,"Asiganción de vehículo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
		}
		#endregion
		
		#region EVENTO_CELDA:DOUBLE_CLICK
		void DataOperadorVehiculoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0 & dataOperadorVehiculo.Rows.Count>0){
				///ID_UNIDAD
				///ID_OPERADOR
				new Interfaz.Asignacion.FormModificarFecha(dataOperadorVehiculo[1,e.RowIndex].Value.ToString(),
				                                           dataOperadorVehiculo[0,e.RowIndex].Value.ToString()).ShowDialog();
				getDatosTabla();
			}
		}
		#endregion
		
		void RbOperadorCheckedChanged(object sender, EventArgs e)
		{
			getDatosTabla();
		}
		
		void RbTodosCheckedChanged(object sender, EventArgs e)
		{
			getDatosTabla();
		}
		
		void BtnExcelClick(object sender, EventArgs e)
		{
			Excels.ReporteO_V(dataOperadorVehiculo, dataCamion, dataCamioneta, dataUtilitario, dataOperador);
		}
	}
}
