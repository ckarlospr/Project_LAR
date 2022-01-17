using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormReporteVentas : Form
	{
		#region INSTANCIAS DE LOS OBJETOS
		private Interfaz.FormPrincipal principal = null;	
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		public FormReporteVentas(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal = principal;
		}
		
		public FormReporteVentas()
		{
			InitializeComponent();
		}
		
		void FormReporteVentasLoad(object sender, EventArgs e)
		{
			//dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, V.Numero, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O, OPERACION OP, OPERACION_OPERADOR OO, RUTA R, RUTA_ESPECIAL RE, Cliente C, ContactoServicio CS  where V.ID=A.ID_UNIDAD and A.ID_OPERADOR=O.ID and O.ID=OO.id_operador AND OP.ESTATUS='1' and OO.id_operacion=OP.id_operacion and OP.id_ruta=R.ID and R.IdSubEmpresa=C.ID and C.ID=RE.ID_C  and C.ID=CS.IdCliente and RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' order by RE.FECHA_SALIDA");
			dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT RE.ID_RE, OP.Alias, V.Numero, RE.DESTINO, R.Sentido, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V, RUTA_ESPECIAL RE WHERE RE.ID_C=C.ID and U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' AND O.fecha BETWEEN '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and C.Empresa like '%Especiales%' ORDER BY O.fecha, R.Nombre"); 
			dataViajesEspeciales2.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT R.ID, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES as Observacion FROM Cliente C, ContactoServicio CS, RUTA_ESPECIAL RE, RUTA R WHERE C.ID=CS.IdCliente AND C.ID=RE.ID_C AND C.ID=R.IdSubEmpresa AND RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' AND R.ID not in (select R2.ID from Cliente C2, RUTA R2, OPERACION O2, OPERACION_OPERADOR OO2, OPERADOR OP2  where C2.ID=R2.IdSubEmpresa and R2.ID=O2.id_ruta and O2.id_operacion=OO2.id_operacion and O2.estatus='1' and OO2.id_operador=OP2.ID and R2.Sentido='Entrada' and C2.Empresa='Especiales') ORDER BY RE.FECHA_SALIDA");
			cancelados();
		}
		
		void DtFechaEspecialInicioValueChanged(object sender, EventArgs e)
		{
			//dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, V.Numero, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O, OPERACION OP, OPERACION_OPERADOR OO, RUTA R, RUTA_ESPECIAL RE, Cliente C, ContactoServicio CS  where V.ID=A.ID_UNIDAD and A.ID_OPERADOR=O.ID and O.ID=OO.id_operador AND OP.ESTATUS='1' and OO.id_operacion=OP.id_operacion and OP.id_ruta=R.ID and R.IdSubEmpresa=C.ID and C.ID=RE.ID_C  and C.ID=CS.IdCliente and RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' order by RE.FECHA_SALIDA");
			dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT RE.ID_RE, OP.Alias, V.Numero, RE.DESTINO, R.Sentido, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V, RUTA_ESPECIAL RE WHERE RE.ID_C=C.ID and U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' AND O.fecha BETWEEN '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and C.Empresa like '%Especiales%' ORDER BY O.fecha, R.Nombre"); 
			dataViajesEspeciales2.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT R.ID, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES as Observacion FROM Cliente C, ContactoServicio CS, RUTA_ESPECIAL RE, RUTA R WHERE C.ID=CS.IdCliente AND C.ID=RE.ID_C AND C.ID=R.IdSubEmpresa AND RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' AND R.ID not in (select R2.ID from Cliente C2, RUTA R2, OPERACION O2, OPERACION_OPERADOR OO2, OPERADOR OP2  where C2.ID=R2.IdSubEmpresa and R2.ID=O2.id_ruta and O2.id_operacion=OO2.id_operacion and O2.estatus='1' and OO2.id_operador=OP2.ID and R2.Sentido='Entrada' and C2.Empresa='Especiales') ORDER BY RE.FECHA_SALIDA");
			cancelados();
		}
		
		void DtFechaEspecialFinValueChanged(	object sender, EventArgs e)
		{
			//dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, V.Numero, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O, OPERACION OP, OPERACION_OPERADOR OO, RUTA R, RUTA_ESPECIAL RE, Cliente C, ContactoServicio CS  where V.ID=A.ID_UNIDAD and A.ID_OPERADOR=O.ID and O.ID=OO.id_operador AND OP.ESTATUS='1' and OO.id_operacion=OP.id_operacion and OP.id_ruta=R.ID and R.IdSubEmpresa=C.ID and C.ID=RE.ID_C  and C.ID=CS.IdCliente and RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' order by RE.FECHA_SALIDA");
			dataViajesEspeciales.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT RE.ID_RE, OP.Alias, V.Numero, RE.DESTINO, R.Sentido, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V, RUTA_ESPECIAL RE WHERE RE.ID_C=C.ID and U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' AND O.fecha BETWEEN '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' and C.Empresa like '%Especiales%' ORDER BY O.fecha, R.Nombre"); 
			dataViajesEspeciales2.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("SELECT R.ID, R.NOMBRE as Destino, RE.PRECIO, RE.FECHA_SALIDA, RE.FACTURA, RE.DOMICILIO, RE.OBSERVACIONES as Observacion FROM Cliente C, ContactoServicio CS, RUTA_ESPECIAL RE, RUTA R WHERE C.ID=CS.IdCliente AND C.ID=RE.ID_C AND C.ID=R.IdSubEmpresa AND RE.FECHA_SALIDA between '"+dtFechaEspecialInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtFechaEspecialFin.Value.ToString("yyyy-MM-dd")+"' AND R.Sentido='ENTRADA' AND R.ID not in (select R2.ID from Cliente C2, RUTA R2, OPERACION O2, OPERACION_OPERADOR OO2, OPERADOR OP2  where C2.ID=R2.IdSubEmpresa and R2.ID=O2.id_ruta and O2.id_operacion=OO2.id_operacion and O2.estatus='1' and OO2.id_operador=OP2.ID and R2.Sentido='Entrada' and C2.Empresa='Especiales') ORDER BY RE.FECHA_SALIDA");
			cancelados();
		}
		
		void FormReporteVentasFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.RutaEspecialReporte = false;
		}
		
		#region GENERADORREPORTES
				void BtnExcelClick(object sender, EventArgs e)
				{
					nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
				for (int i = 0; i < dataViajesEspeciales.Rows.Count-1; i++)
				{
					if(i==0)
					{
						ExcelApp.Cells[i + 1,  2] = "NOMBRE";
						ExcelApp.Cells[i + 1,  3] = "CARRO";
						ExcelApp.Cells[i + 1,  4] = "DESTINO";
						ExcelApp.Cells[i + 1,  5] = "IMPORTE";
						ExcelApp.Cells[i + 1,  6] = "FECHA";
						ExcelApp.Cells[i + 1,  7] = "FACTURA";
						ExcelApp.Cells[i + 1,  8] = "DOMICILIO";
						ExcelApp.Cells[i + 1,  9] = "OBSERVACIONES";
						ExcelApp.Cells[i + 1,  10] = "ID_SERVICIO";
						ExcelApp.Cells[i + 1,  11] = "SENTIDO";
					}
					else
					{
						for (int j = 0; j < 9; j++)
						{
							if(dataViajesEspeciales.Rows[i].Cells[j].Value.ToString().Equals(""))
							{
								if(j!=0 && j!=4)
								{
									ExcelApp.Cells[i + 1, j + 1]="";
								}
							}
							else
							{
								if(j==0)
								{
									ExcelApp.Cells[i + 1, 10] = dataViajesEspeciales.Rows[i-1].Cells[0].Value.ToString();	
								}
								else if(j>=4)
								{
									ExcelApp.Cells[i + 1, 11] = dataViajesEspeciales.Rows[i-1].Cells[4].Value.ToString();	
									ExcelApp.Cells[i + 1, j + 1] = dataViajesEspeciales.Rows[i-1].Cells[j+1].Value.ToString();
								}
								else if(j!=0)
								{
									ExcelApp.Cells[i + 1, j + 1] = dataViajesEspeciales.Rows[i-1].Cells[j].Value.ToString();	
								}
							}
						}
					}
				}
								// ---------- cuadro de dialogo para Guardar
								SaveFileDialog CuadroDialogo = new SaveFileDialog();
								CuadroDialogo.DefaultExt = "xls";
								CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
								CuadroDialogo.AddExtension = true;
								CuadroDialogo.RestoreDirectory = true;
								CuadroDialogo.Title = "Guardar";
								CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
								CuadroDialogo.FileName = DateTime.Now.ToString("yyyy-MM-dd") + "Reporte Ventas Asignados";
								if (CuadroDialogo.ShowDialog() == DialogResult.OK)
								{
								ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
								ExcelApp.ActiveWorkbook.Saved = true;
								CuadroDialogo.Dispose();
								CuadroDialogo = null;
								ExcelApp.Quit();
								MessageBox.Show("Se exportaron los datos Correctamente ... ");
								}
								else
								{
								MessageBox.Show("No Genero el Reporte ... ");
								}
				}
				#endregion
		
		void BtnExcel2Click(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
			        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			for (int i = 0; i < dataViajesEspeciales2.Columns.Count-1; i++)
			{
				if(i==0)
				{					
					ExcelApp.Cells[i + 1,  1] = "NOMBRE";
					ExcelApp.Cells[i + 1,  2] = "CARRO";
					ExcelApp.Cells[i + 1,  3] = "DESTINO";
					ExcelApp.Cells[i + 1,  4] = "IMPORTE";
					ExcelApp.Cells[i + 1,  5] = "FECHA";
					ExcelApp.Cells[i + 1,  6] = "FACTURA";
				}
				else
				{
					for (int j = 0; j <dataViajesEspeciales2.Columns.Count; j++)
					{
						if(dataViajesEspeciales2.Rows[i].Cells[j].Value==null)
						{
							ExcelApp.Cells[i + 1, j + 1]="";
						}
						else
						{
							ExcelApp.Cells[i + 1, j + 1] = dataViajesEspeciales2.Rows[i-1].Cells[j].Value.ToString();	
						}
					}
				}
			}
							// ---------- cuadro de dialogo para Guardar
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = DateTime.Now.ToString("yyyy-MM-dd") + "Reporte Ventas Sin Asignar";
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
			else
			{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		
		public void cancelados()
		{
			for(int x=0; x<dataViajesEspeciales2.Rows.Count; x++)
			{
				int l=0;
				int m=0;
				conn.getAbrirConexion("select Alias, V.Numero from CANCELACION_PUNTO C, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=C.ID_OPERADOR and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and C.ID_RUTA='"+dataViajesEspeciales2[2,x].Value.ToString()+"' and C.FECHA='"+dataViajesEspeciales2[5,x].Value.ToString().Substring(0,10)+"'");
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dataViajesEspeciales2[0,x].Value=conn.leer["Alias"].ToString();
					dataViajesEspeciales2[1,x].Value=conn.leer["Numero"].ToString();
					
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
		
		void DataViajesEspeciales2CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show("ID: "+e.ColumnIndex);
		}
	}
}
