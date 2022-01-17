using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Incapacidad
{
	public partial class FormValidaFact : Form
	{
		public FormValidaFact(int id_u)
		{
			InitializeComponent();
			id_Us=id_u;
		}
		
		#region VARIABLES
		String consulta = "";
		int id_Us=0;
		#endregion
		
		#region INSTANCIAS
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormValidaFactLoad(object sender, EventArgs e)
		{
			txtFactura.AutoCompleteCustomSource = auto.AutoReconocimiento("select FACTURA dato from MENSAJE_FACTURACION_ESP");
			txtFactura.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtFactura.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			obtenerConsulta();
			consulta=consulta+" and RE.FACTURADO='1' ";
			getDatos();
			getComentario();
		}
		#endregion
		
		#region CARGA DATOS EN DATAGRID
		void obtenerConsulta()
		{
			consulta="select RE.ID_RE, RE.FACTURA, RE.FECHA_SALIDA, RE.DESTINO, CS.Nombre, RE.RESPONSABLE, RE.CANT_UNIDADES, RE.tipoVehiculo, RE.FACTURADO from RUTA_ESPECIAL RE, ContactoServicio CS where estado='Activo' and RE.ID_C=CS.IdCliente and RE.ID_C in (select IdSubEmpresa from RUTA) ";
		}
		
		public void getDatos()
		{
			dgEspeciales.Rows.Clear();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				dgEspeciales.Rows.Add(conn.leer["ID_RE"].ToString(),conn.leer["FACTURA"].ToString(),conn.leer["DESTINO"].ToString(),conn.leer["FECHA_SALIDA"].ToString().Substring(0,10),conn.leer["Nombre"].ToString(), conn.leer["RESPONSABLE"].ToString(), conn.leer["CANT_UNIDADES"].ToString(), conn.leer["tipoVehiculo"].ToString(), conn.leer["FACTURADO"].ToString());
			}
			
			conn.conexion.Close();
			dgEspeciales.ClearSelection();
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdFacturarClick(object sender, EventArgs e)
		{
			if(dgEspeciales.CurrentRow.Index>-1)
			{
				conn.getAbrirConexion("UPDATE RUTA_ESPECIAL SET FACTURADO='2' WHERE ID_RE="+dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value.ToString());
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				conn.getAbrirConexion("insert into MENSAJE_FACTURACION_ESP values ("+dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value.ToString()+", "+id_Us+", '"+txtFactura.Text+"', '"+txtMsjServicio.Text+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (time, SYSDATETIME())))");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				dgEspeciales.Rows.RemoveAt(dgEspeciales.CurrentRow.Index);
				dgEspeciales.ClearSelection();
				txtMsjServicio.Text="";
			}
		}
		#endregion
		
		#region COMENTARIO GUARDADO Y CONSULTA
		void getComentario()
		{
			Int64 IDM = 0 ;
			conn.getAbrirConexion("select MAX(ID_MENSAJE) ID from MENSAJE_FACTURACION");
			conn.leer=conn.comando.ExecuteReader();
			
			if(conn.leer.Read())
			{
				IDM=Convert.ToInt64(conn.leer["ID"]);
			}
			conn.conexion.Close();
			
			String consult ="select * from MENSAJE_FACTURACION WHERE ID_MENSAJE="+IDM;
			
			conn.getAbrirConexion(consult);
			conn.leer=conn.comando.ExecuteReader();
			
			if(conn.leer.Read())
			{
				txtMsj.Text=conn.leer["MENSAJE"].ToString();
			}
			else
			{
				txtMsj.Text="Comentario";
			}
			
			conn.conexion.Close();
		}
		
		void CmdGuardaMsjClick(object sender, EventArgs e)
		{
			if(txtMsj.Text!="")
			{
				conn.getAbrirConexion("insert into MENSAJE_FACTURACION values ('"+id_Us+"', '"+txtMsj.Text+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (time, SYSDATETIME())));");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
			else
			{
				MessageBox.Show("Ingrese mensaje.");
			}
		}
		#endregion
	}
}
