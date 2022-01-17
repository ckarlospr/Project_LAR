using System;
using System.Drawing;
using System.Windows.Forms;
 

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormReporteVentas : Form
	{
		#region INSTANCIAS DE LOS OBJETOS
		private Interfaz.FormPrincipal principal = null;	
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region CONSTRUCTORES
		public FormReporteVentas(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal = principal;
		}
		
		public FormReporteVentas()
		{
			InitializeComponent();
		}
		#endregion
		
		#region INICIO CERRADO
		void FormReporteVentasLoad(object sender, EventArgs e)
		{
			dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT RE.ID_RE, OP.Alias, V.Numero, RE.DESTINO, R.Sentido, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V, RUTA_ESPECIAL RE WHERE RE.ID_C=C.ID and U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' AND O.fecha BETWEEN '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and C.Empresa like '%Especiales%' ORDER BY O.fecha, R.Nombre"); 
			dataViajesEspeciales2.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT R.ID, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES as Observacion FROM Cliente C, ContactoServicio CS, RUTA_ESPECIAL RE, RUTA R WHERE C.ID=CS.IdCliente AND C.ID=RE.ID_C AND C.ID=R.IdSubEmpresa AND RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' AND R.ID not in (select R2.ID from Cliente C2, RUTA R2, OPERACION O2, OPERACION_OPERADOR OO2, OPERADOR OP2  where C2.ID=R2.IdSubEmpresa and R2.ID=O2.id_ruta and O2.id_operacion=OO2.id_operacion and O2.estatus='1' and OO2.id_operador=OP2.ID and R2.Sentido='Entrada' and C2.Empresa='Especiales') ORDER BY RE.FECHA_SALIDA");
			cancelados();
		}
		
		void FormReporteVentasFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.RutaEspecialReporte = false;
		}
		#endregion
		
		#region DATETIME
		void DtFechaEspecialInicioValueChanged(object sender, EventArgs e)
		{
			dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT RE.ID_RE, OP.Alias, V.Numero, RE.DESTINO, R.Sentido, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V, RUTA_ESPECIAL RE WHERE RE.ID_C=C.ID and U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' AND O.fecha BETWEEN '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and C.Empresa like '%Especiales%' ORDER BY O.fecha, R.Nombre"); 
			dataViajesEspeciales2.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT R.ID, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES as Observacion FROM Cliente C, ContactoServicio CS, RUTA_ESPECIAL RE, RUTA R WHERE C.ID=CS.IdCliente AND C.ID=RE.ID_C AND C.ID=R.IdSubEmpresa AND RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' AND R.ID not in (select R2.ID from Cliente C2, RUTA R2, OPERACION O2, OPERACION_OPERADOR OO2, OPERADOR OP2  where C2.ID=R2.IdSubEmpresa and R2.ID=O2.id_ruta and O2.id_operacion=OO2.id_operacion and O2.estatus='1' and OO2.id_operador=OP2.ID and R2.Sentido='Entrada' and C2.Empresa='Especiales') ORDER BY RE.FECHA_SALIDA");
			cancelados();
		}
		
		void DtFechaEspecialFinValueChanged(	object sender, EventArgs e)
		{
			dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT RE.ID_RE, OP.Alias, V.Numero, RE.DESTINO, R.Sentido, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V, RUTA_ESPECIAL RE WHERE RE.ID_C=C.ID and U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' AND O.fecha BETWEEN '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and C.Empresa like '%Especiales%' ORDER BY O.fecha, R.Nombre"); 
			dataViajesEspeciales2.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT R.ID, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES as Observacion FROM Cliente C, ContactoServicio CS, RUTA_ESPECIAL RE, RUTA R WHERE C.ID=CS.IdCliente AND C.ID=RE.ID_C AND C.ID=R.IdSubEmpresa AND RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' AND R.ID not in (select R2.ID from Cliente C2, RUTA R2, OPERACION O2, OPERACION_OPERADOR OO2, OPERADOR OP2  where C2.ID=R2.IdSubEmpresa and R2.ID=O2.id_ruta and O2.id_operacion=OO2.id_operacion and O2.estatus='1' and OO2.id_operador=OP2.ID and R2.Sentido='Entrada' and C2.Empresa='Especiales') ORDER BY RE.FECHA_SALIDA");
			cancelados();
		}
		#endregion
		
		#region IMPRIMIR REPORTES
		void BtnExcelClick(object sender, EventArgs e)
		{
			Excels.ReporteVentas1(dataViajesEspeciales);
		}
		
		void BtnExcel2Click(object sender, EventArgs e)
		{
			Excels.ReporteVentas2(dataViajesEspeciales2);
		}
		#endregion
		
		#region CANCELADOS
		public void cancelados()
		{
			for(int x=0; x<dataViajesEspeciales2.Rows.Count; x++)
			{
				int l=0;
				int m=0;
				
				
				String consulta;
				//consulta = "select Alias, V.Numero from CANCELACION_PUNTO C, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=C.ID_OPERADOR and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and C.ID_RUTA='"+dataViajesEspeciales2[2,x].Value.ToString()+"' and C.FECHA='"+dataViajesEspeciales2[5,x].Value.ToString().Substring(0,10)+"'";
				consulta = "select * from CANCELACION_PUNTO C, OPERADOR O where O.ID=C.ID_OPERADOR and C.ID_RUTA="+dataViajesEspeciales2[2,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dataViajesEspeciales2[0,x].Value=conn.leer["Alias"].ToString();
					//dataViajesEspeciales2[1,x].Value=conn.leer["Numero"].ToString();
					
					for(int y=0; y<dataViajesEspeciales2.Columns.Count; y++)
					{
						dataViajesEspeciales2[y,x].Style.BackColor=Color.Red;
					}
				}
				else
				{
					l=1;
				}
				conn.conexion.Close();
				
				if(l==1)
				{
					//MessageBox.Show(dataViajesEspeciales2[2,x].Value.ToString());
					conn.getAbrirConexion("select E.estado from RUTA R, RUTA_ESPECIAL E where R.IdSubEmpresa=E.ID_C and R.ID="+dataViajesEspeciales2[2,x].Value.ToString()+" and E.FECHA_SALIDA='"+dataViajesEspeciales2[5,x].Value.ToString().Substring(0,10)+"'");
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						if(conn.leer["estado"].ToString()=="Cancelado")
						{
							dataViajesEspeciales2[0,x].Value="Cancelado";
							for(int y=0; y<dataViajesEspeciales2.Columns.Count; y++)
							{
								dataViajesEspeciales2[y,x].Style.BackColor=Color.Yellow;
							}
						}
						else
						{
							m=1;
						}
					}
					else
					{
						m=1;
					}
					conn.conexion.Close();
				}
				
				if(m==1)
				{
					conn.getAbrirConexion("select TIPO from RUTA where ID="+dataViajesEspeciales2[2,x].Value.ToString());
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						if(conn.leer["TIPO"].ToString()=="Cancelada")
						{
							dataViajesEspeciales2[0,x].Value="Cancelado";
							for(int y=0; y<dataViajesEspeciales2.Columns.Count; y++)
							{
								dataViajesEspeciales2[y,x].Style.BackColor=Color.Yellow;
							}
						}
						else
						{
							dataViajesEspeciales2[0,x].Value="Sin asignar";
						}
					}
					else
					{
						dataViajesEspeciales2[0,x].Value="Sin asignar";
					}
					conn.conexion.Close();
				}
			}
		}
		#endregion
	}
}
