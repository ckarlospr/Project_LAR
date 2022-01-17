using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Monitoreo
{
	public partial class FormLicencia : Form
	{
		public bool licenciaCerrado=false;
		DateTime Fecha = DateTime.Now;
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		public Interfaz.Monitoreo.ReporteLicencia rlicencia=null;
		public Interfaz.FormLogin login=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONTRUCTORES
		public FormLicencia(Interfaz.FormPrincipal principal){
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region EVENTO (LOAD - CLOSING)
		void FormLicenciaLoad(object sender, EventArgs e){
			AdaptadorVigencia();
			getCargarConsulta();
			if(dataOperador.Rows.Count>0)
			{
			MessageBox.Show("Existen operadores registrados con licencias vencidas.","Actualizar licencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		
		public void FormLicenciaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.toolLicencia.Visible=true;
			principal.licencia=false;
			this.licenciaCerrado=true;
		}
		#endregion
		
		#region CARGAR_CONSULTA
		private void getCargarConsulta(){
			if(Convert.ToInt32(dataOperador.Rows.Count.ToString())>0 )
			{
				new Conexion_Servidor.Operador.SQL_Operador().getOperador(dataOperador[0,dataOperador.CurrentRow.Index].Value.ToString(),ptbImagen, txtAlias , txtNombre , txtApellidoP , txtApellidoM);
				dataLicencia.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID,Descripcion,Numero,Vigencia,Tipo from LICENCIA where ID_Chofer="+dataOperador[0,dataOperador.CurrentRow.Index].Value.ToString()+" and Vigencia < (SELECT CONVERT (date, SYSDATETIME()))");
			    dataFaltantes.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, Alias from OPERADOR where Estatus='1'and Alias!='Admvo'and tipo_empleado!='Externo' AND tipo_empleado='OPERADOR' and ID not in (select ID_Chofer from LICENCIA) order by Alias");
			}
			else
			{
				getLimpiarCampo();
			}
		}
		#endregion
		
		#region EVENTO (CLICK A LAS CELDAS)
		void DataOperadorCellClick(object sender, DataGridViewCellEventArgs e)
		{
			getCargarConsulta();
		}
		
		void DataLicenciaCellDoubleClick(object sender, DataGridViewCellEventArgs e){
			if(Convert.ToInt32(dataLicencia.Rows.Count.ToString())>0){
				new Interfaz.Monitoreo.FormDetalleLicencia(dataLicencia[0,dataLicencia.CurrentRow.Index].Value.ToString()).ShowDialog();
				AdaptadorVigencia();
				getCargarConsulta();
				if(Convert.ToInt32(dataOperador.Rows.Count.ToString())==0)
				{
					MessageBox.Show("La lista de operadores con licencias vencidas se ha actualizado de manera correcta con vigencias correctas.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Close();
				}
			}
		}
		#endregion
		
		#region LIMPIAR_CAMPOS
		private void getLimpiarCampo(){
			txtAlias.Text="";
			txtApellidoP.Text="";
			txtApellidoM.Text="";
			ptbImagen.Image=Image.FromFile("Camara.png");
			getLimpiarTabla();
		}
		
		private object getLimpiarTabla(){
			if(dataLicencia.Rows.Count==0)
				return null;
			dataLicencia.Rows.RemoveAt(0);
			return (dataLicencia.Rows.Count>0)?getLimpiarTabla():null;
		}
		#endregion
		
		#region EVENTO_DE_TECLAS (FLUJO_DE_SELECCION)
		void DataOperadorKeyUp(object sender, KeyEventArgs e){
			if(dataOperador.Rows.Count>0){
				if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter){
					getCargarConsulta();
	      		}
			}
		}
		#endregion
		
		#region VALIDACION_DE_TECLAS
		void TxtAliasKeyPress(object sender, KeyPressEventArgs e){
			e.Handled=true;
		}
		#endregion
		
		#region BOTONES
		void BtnAgregarClick(object sender, EventArgs e){
			this.Close();
		}	
		
		void BtnReportesClick(object sender, EventArgs e)
		{
			if(principal.reportelicencia==true)
			{
				MessageBox.Show("La ventana ya esta abierta.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else
			{
				rlicencia=new Transportes_LAR.Interfaz.Monitoreo.ReporteLicencia(principal);
				rlicencia.Show();
				rlicencia.MdiParent=principal;
				principal.reportelicencia=true;
			}
		}
		#endregion
		
		#region ADAPTADOR VIGENCIA
		void AdaptadorVigencia()
		{
			int contador = 0;
	
			dataOperador.Rows.Clear();
			dataOperador.ClearSelection();
			
			conn.getAbrirConexion("select O.ID, O.Alias, L.VIGENCIA from OPERADOR  O, LICENCIA L where L.ID_Chofer=O.ID AND O.Estatus='1' AND O.tipo_empleado='OPERADOR' and O.Alias!='Admvo' group by O.ID, O.Alias, L.VIGENCIA order by O.Alias, L.VIGENCIA");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataOperador.Rows.Add();
				dataOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataOperador.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dataOperador.Rows[contador].Cells[2].Value = Convert.ToDateTime(conn.leer["VIGENCIA"]);
				++contador;
			}
			conn.conexion.Close();
			
			for(int x=0; x<dataOperador.RowCount; x++)
			{
				if(dataOperador.RowCount-1>=x)
				{
					if((Convert.ToDateTime(dataOperador.Rows[x].Cells[2].Value))>(Convert.ToDateTime(Fecha.ToString().Substring(0,10))).AddDays(84))
					{
						dataOperador.Rows.RemoveAt(x);
						if(x>-1)
						{
							--x;
						}
					}
				}
			}
		}
		#endregion
		
		void DataOperadorDoubleClick(object sender, EventArgs e)
		{
			new Interfaz.Operador.FormOperador(principal,dataOperador[0,dataOperador.CurrentRow.Index].Value.ToString()).ShowDialog();
		}
		
		void DataFaltantesDoubleClick(object sender, EventArgs e)
		{
			new Interfaz.Operador.FormOperador(principal,dataFaltantes[0,dataFaltantes.CurrentRow.Index].Value.ToString()).ShowDialog();
			//new Interfaz.Operador.FormLicencia(Interfaz.Operador.FormOperador, dataOperador[0,dataOperador.CurrentRow.Index].Value.ToString()).ShowDialog();
		}
	}
}
