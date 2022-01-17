using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Usuario
{
	public partial class FormDetallePrivilegio : Form
	{
		private String[] privilegio =null;
		
		//--CONSTRUCTOR_DE_LA_CLASE
		public FormDetallePrivilegio(string usuario,string nombreUsusario){
			InitializeComponent();
			this.privilegio=new Conexion_Servidor.Usuario.SQL_Usuario().getPrilvilegios(usuario);
			this.label6.Text+=nombreUsusario;
		}
		
		//--EVENTO_DE_INICIO_DE_VENTANA
		void FormDetallePrivilegioLoad(object sender, EventArgs e){
			getContenidoPrivilegio();
		}
		
		#region CARGANDO_LISTA_DE_LOS_PRIVILEGIOS
		
		private void getContenidoPrivilegio(){
			dataPrivilegio.Rows.Add(false,"OPERADOR");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"UNIDAD");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"RUTA");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"ASEGURADORA");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"CLIENTE - EMPRESA");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"USUARIOS");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"SERVIDOR");
			dataPrivilegio.Rows.Add(false,"    Ver configuración");
			dataPrivilegio.Rows.Add(false,"    Modificar configuración");
			getCargarEstilo(0);
			getCargarPrivilegio();
		}
		
		private Object getCargarEstilo(int contador){
			contador=(contador==4)?3:contador;
			dataPrivilegio.Rows[contador].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
			dataPrivilegio.Rows[contador].DefaultCellStyle.ForeColor=Color.DarkBlue;
			dataPrivilegio.Rows[contador].DefaultCellStyle.BackColor = Color.LightSteelBlue;
			return (4+contador<=23)?getCargarEstilo(4+contador):null;
		}
		
		#endregion
		
		//--CARGAR_PRIVILEGIOS_DEL_USUARIO_ALMACENADO
		private void getCargarPrivilegio(){
			dataPrivilegio[0,0].Value=(privilegio[1].Substring(0,1)=="1" && privilegio[1].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,1].Value=(privilegio[1].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,2].Value=(privilegio[1].Substring(1,1)=="2")?true:false;
			
			dataPrivilegio[0,3].Value=(privilegio[0].Substring(0,1)=="1" && privilegio[0].Substring(1,1)=="2" && privilegio[0].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,4].Value=(privilegio[0].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,5].Value=(privilegio[0].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,6].Value=(privilegio[0].Substring(2,1)=="3")?true:false;
		
			dataPrivilegio[0,7].Value=(privilegio[2].Substring(0,1)=="1" && privilegio[2].Substring(1,1)=="2" && privilegio[2].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,8].Value=(privilegio[2].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,9].Value=(privilegio[2].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,10].Value=(privilegio[2].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,11].Value=(privilegio[3].Substring(0,1)=="1" && privilegio[3].Substring(1,1)=="2" && privilegio[3].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,12].Value=(privilegio[3].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,13].Value=(privilegio[3].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,14].Value=(privilegio[3].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,15].Value=(privilegio[4].Substring(0,1)=="1" && privilegio[4].Substring(1,1)=="2" && privilegio[4].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,16].Value=(privilegio[4].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,17].Value=(privilegio[4].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,18].Value=(privilegio[4].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,19].Value=(privilegio[5].Substring(0,1)=="1" && privilegio[5].Substring(1,1)=="2" && privilegio[5].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,20].Value=(privilegio[5].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,21].Value=(privilegio[5].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,22].Value=(privilegio[5].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,23].Value=(privilegio[6].Substring(0,1)=="1" && privilegio[6].Substring(1,1)=="2" && privilegio[6].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,24].Value=(privilegio[6].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,25].Value=(privilegio[6].Substring(1,1)=="2")?true:false;
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
