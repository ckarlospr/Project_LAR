using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormReporteOperaciones : Form
	{
		#region CONSTRUCTOR
		public FormReporteOperaciones(Interfaz.FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		#endregion
		
		#region VARIABLES
		Interfaz.FormPrincipal refPrincipal=null;
		#endregion
		
		#region REFERENCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD - CLOSING
		void FormReporteOperacionesLoad(object sender, EventArgs e)
		{
			ingresaFechas();
			getDatos();
		}
		
		void FormReporteOperacionesFormClosing(object sender, FormClosingEventArgs e)
		{
		  //refPrincipal.reporteOperaciones = false;	
		}
		#endregion
		
		#region CAMBIO DE FECHA
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			dtpFin.Value=dtpInicio.Value;
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			ingresaFechas();
			getDatos();
		}
		#endregion
		
		#region ORDEN DE FECHAS EN DATAGRID
		public void ingresaFechas()
		{
			dgDatos.Rows.Clear();
			String consulta = "select O.fecha, O.turno from OPERACION O, RUTA R where O.id_ruta=R.ID and O.fecha between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' and O.estatus='1' group by O.fecha, O.turno order by O.fecha";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["fecha"].ToString().Substring(0,10),conn.leer["turno"].ToString(),"","","","");
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		#region GET DATOS
		public void getDatos()
		{
			if(dgDatos.Rows.Count>0)
			{
				for(int x=0; x<dgDatos.Rows.Count; x++)
				{
					// *********************** group by R.Nombre, O.turno order by R.Nombre **************************
					int cuenta = 0;
					String consulta = "select * from CARDEX where DIA='"+dgDatos[0,x].Value.ToString()+"' and TURNO='"+dgDatos[1,x].Value.ToString()+"' ";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						cuenta = cuenta + Convert.ToInt16(conn.leer["VIAJES"]);
					}
					conn.conexion.Close();
					dgDatos[2,x].Value=cuenta;
					// ***********************************************************************************************
					
					// ************************ Número promedio de unidades disponibles por turno ********************
					cuenta = 0;
					consulta = "select * from CARDEX where DIA='"+dgDatos[0,x].Value.ToString()+"' AND TURNO='"+dgDatos[1,x].Value.ToString()+"' and ESTATUS!='T' and ESTATUS!='P'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						cuenta++;
					}
					conn.conexion.Close();
					dgDatos[3,x].Value=cuenta;					
					// ***********************************************************************************************
					
					// ******************************* Número de incidencias reportadas ******************************
					cuenta = 0;
					consulta = "select * from HISTORIAL_EMPRESAS where DIA='"+dgDatos[0,x].Value.ToString()+"' and TURNO='"+dgDatos[1,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						cuenta++;
					}
					conn.conexion.Close();
					dgDatos[4,x].Value=cuenta;	
					// ***********************************************************************************************
					
					// ******************************** Número de rutas no cubiertas *********************************
					cuenta = 0;
					consulta = "SELECT O.id_operacion ,O.confirmada ,V.Tipo_Unidad, R.ID, R.IdSubEmpresa, C.Empresa, C.SubNombre, O.fecha, R.turno, R.Nombre, R.Sentido, R.HoraInicio, OP.Alias, V.Numero, O.llegada, O.pasajeros, U.usuario, O.estatus, R.TIPO  FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V WHERE U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo  and O.estatus='1' AND O.fecha = '"+dgDatos[0,x].Value.ToString()+"' AND O.turno='"+dgDatos[1,x].Value.ToString()+"' AND OP.Alias like '%ADMVO%' ORDER BY O.fecha, O.turno, R.Nombre ";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						cuenta++;
					}
					conn.conexion.Close();
					dgDatos[5,x].Value=cuenta;	
					// ***********************************************************************************************
					
					// ******************************* Viajes realizados por externos ********************************
					cuenta = 0;
					consulta = "SELECT O.id_operacion ,O.confirmada ,V.Tipo_Unidad, R.ID, R.IdSubEmpresa, C.Empresa, C.SubNombre, O.fecha, R.turno, R.Nombre, R.Sentido, R.HoraInicio, OP.Alias, V.Numero, O.llegada, O.pasajeros, U.usuario, O.estatus, R.TIPO  FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V WHERE U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo  and O.estatus='1' AND O.fecha = '"+dgDatos[0,x].Value.ToString()+"' AND O.turno='"+dgDatos[1,x].Value.ToString()+"'  and OP.tipo_empleado like '%Externo%' ORDER BY O.fecha, O.turno, R.Nombre ";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						cuenta++;
					}
					conn.conexion.Close();
					dgDatos[6,x].Value=cuenta;	
					// ***********************************************************************************************
				}
			}
		}
		#endregion
		
		#region EVENTO DOUBLE CLICK DEL DATAGRID
		void DgDatosDoubleClick(object sender, EventArgs e)
		{
			if(dgDatos.CurrentCell.ColumnIndex==4 && dgDatos[4,dgDatos.CurrentRow.Index].Value.ToString()!="0")
			{
				new Interfaz.Reportes.FormIncidencias(this, refPrincipal.idUsuario).ShowDialog();
			}
			else if(dgDatos.CurrentCell.ColumnIndex==5 && dgDatos[5,dgDatos.CurrentRow.Index].Value.ToString()!="0")
			{
				new Interfaz.Reportes.Dato.FormRutasFaltantes(this).ShowDialog();
			}
			else if(dgDatos.CurrentCell.ColumnIndex==6 && dgDatos[6,dgDatos.CurrentRow.Index].Value.ToString()!="0")
			{
				new Interfaz.Reportes.FormViajesExternos(this).ShowDialog();
			}
		}
		#endregion
	}
}
