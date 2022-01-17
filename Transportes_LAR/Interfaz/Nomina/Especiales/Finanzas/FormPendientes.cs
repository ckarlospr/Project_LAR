using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	public partial class FormPendientes : Form
	{
		public FormPendientes(FormPrincipal formPrinc)
		{
			InitializeComponent();
			refPrincipal=formPrinc;
		}
		
		#region VARIABLES
		#endregion
		
		#region INSTACIAS
		public FormPrincipal refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region LOAD
		void FormPendientesLoad(object sender, EventArgs e)
		{
			dtpInicio.Value=Convert.ToDateTime("01/10/2014");
		}
		#endregion
		
		#region GET DATOS
		void getDatos()
		{
			dgPendiente.Rows.Clear();
			String consulta = 	"select E.ID_RE, O.Alias, C.SALDO, E.DESTINO, E.FECHA_SALIDA, E.FECHA_REGRESO, E.OP_COBRA, E.TIPO_PAGO, E.FECHA, R.HORA_FIN, E.FACTURA " +
								"from COBRO_ESPECIAL C, RUTA_ESPECIAL E, OPERADOR O, RUTA R " +
								"where C.ID_RE=E.ID_RE AND O.ID=C.ID_OP and R.ID=C.ID_RUTA_SAL " +
								"AND (OP_COBRA='1' OR E.TIPO_PAGO='EFECTIVO') AND C.PAGO='0' AND E.estado!='Cancelado' and E.DATO_PAGO='0' and E.FECHA_REGRESO > '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' " +
								"ORDER BY E.FECHA_REGRESO";
			
			if(cbMostrar.Checked==false)
			{
			 	consulta = 		"select E.ID_RE, O.Alias, C.SALDO, E.DESTINO, E.FECHA_SALIDA, E.FECHA_REGRESO, E.OP_COBRA, E.TIPO_PAGO, E.FECHA, R.HORA_FIN, E.FACTURA " +
								"from COBRO_ESPECIAL C, RUTA_ESPECIAL E, OPERADOR O, RUTA R " +
								"where C.ID_RE=E.ID_RE AND O.ID=C.ID_OP and R.ID=C.ID_RUTA_SAL " +
								"AND (OP_COBRA='1' OR E.TIPO_PAGO='EFECTIVO') AND C.PAGO='0' AND E.estado!='Cancelado' and E.DATO_PAGO='1' and E.FECHA_REGRESO > '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' " +
								"ORDER BY E.FECHA_REGRESO";
			}
			
			if(rbIncobrable.Checked==true)
			{
				consulta = 		"select E.ID_RE, O.Alias, C.SALDO, E.DESTINO, E.FECHA_SALIDA, E.FECHA_REGRESO, E.OP_COBRA, E.TIPO_PAGO, E.FECHA, R.HORA_FIN, E.FACTURA " +
								"from COBRO_ESPECIAL C, RUTA_ESPECIAL E, OPERADOR O, RUTA R " +
								"where C.ID_RE=E.ID_RE AND O.ID=C.ID_OP and R.ID=C.ID_RUTA_SAL AND E.estado!='Cancelado' and E.INCOBRABLE!='0' and E.FECHA_REGRESO > '01/01/2014' " +
								"ORDER BY E.FECHA_REGRESO";
			}
			else if(rbPagados.Checked==true)
			{
				consulta = 		"select E.ID_RE, O.Alias, C.SALDO, E.DESTINO, E.FECHA_SALIDA, E.FECHA_REGRESO, E.OP_COBRA, E.TIPO_PAGO, E.FECHA, R.HORA_FIN, E.FACTURA " +
								"from COBRO_ESPECIAL C, RUTA_ESPECIAL E, OPERADOR O, RUTA R " +
								"where C.ID_RE=E.ID_RE AND O.ID=C.ID_OP and R.ID=C.ID_RUTA_SAL AND E.estado!='Cancelado' and E.PAGADO!='3' and E.FECHA_REGRESO > '01/01/2014' " +
								"ORDER BY E.FECHA_REGRESO";
			}
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgPendiente.Rows.Add(conn.leer["ID_RE"].ToString(), 
				                     conn.leer["Alias"].ToString(), 
				                     conn.leer["SALDO"].ToString(), 
				                     conn.leer["DESTINO"].ToString(), 
				                     conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), 
				                     conn.leer["FECHA_REGRESO"].ToString().Substring(0,10), 
				                     "0", 
				                     ((conn.leer["OP_COBRA"].ToString()=="1")?"SI":"NO"), 
				                     conn.leer["TIPO_PAGO"].ToString(), 
				                     conn.leer["FECHA"].ToString().Substring(0,10),
				                     conn.leer["HORA_FIN"].ToString().Substring(0,5), 
				                     "", 
				                     conn.leer["FACTURA"].ToString());
			}
			conn.conexion.Close();
			
			if(rbPendiente.Checked==true)
			{
				// **************************** FECHA ********************************
				DateTime Fecha_base=DateTime.Now;
				consulta = 	"SELECT CONVERT (DATETIME, SYSDATETIME()) FECHA";
					
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					Fecha_base = Convert.ToDateTime(conn.leer["FECHA"]);
				}
				conn.conexion.Close();
				// *******************************************************************
				
				
				for(int x=0; x<dgPendiente.Rows.Count; x++)
				{
					dgPendiente[11,x].Value=Fecha_base+"-"+(Convert.ToDateTime(dgPendiente[5,x].Value+" "+dgPendiente[10,x].Value));
					String diferencia = (Fecha_base-(Convert.ToDateTime(dgPendiente[5,x].Value+" "+dgPendiente[10,x].Value))).ToString();
					int cantidad = 0;
					bool punto = false;
					bool doble = false;
					bool entra = true;
					for(int y=0; y<diferencia.Length; y++)
					{
						if(diferencia.Substring(y,1).Contains("."))
						{
							entra=false;
							if(doble==false)
							{
								punto = true;
							}
						}
						else if(diferencia.Substring(y,1).Contains(":"))
						{
							doble=true;
							entra=false;
						}
						
						if(entra==true)
						{
							cantidad++;
						}
					}
					
					int Diass = 0;
					int Horass = 0;
					if(punto==true)
					{
						Diass = Convert.ToInt16(diferencia.Substring(0,cantidad));
						Horass = Convert.ToInt16(diferencia.Substring(cantidad+1,2));
					}
					else
					{
						Horass = Convert.ToInt16(diferencia.Substring(0,cantidad));
					}
					
					
					dgPendiente[6,x].Value=((Diass*24)+Horass);
					dgPendiente[10,x].Value="Dias: "+Diass+ " Horas:"+Horass;
					
					if(((Diass*24)+Horass)>24)
					{
						dgPendiente[6,x].Style.BackColor=Color.Yellow;
					}
					
					if(((Diass*24)+Horass)>48)
					{
						dgPendiente[6,x].Style.BackColor=Color.Red;
					}
				}
			}
		 	else
			{
			   	for(int x=0; x<dgPendiente.Rows.Count; x++)
				{
			   		dgPendiente[6,x].Style.BackColor=Color.White;
			   		dgPendiente[6,x].Value="N/A";
			   	}
			}
			
			
			dgPendiente.ClearSelection();
		}
		#endregion
		
		void CmdRefrescaClick(object sender, EventArgs e)
		{
			getDatos();
		}
		
		void DgPendienteDoubleClick(object sender, EventArgs e)
		{
			Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgPendiente[0,dgPendiente.CurrentRow.Index].Value));
			formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
			formDatos.ShowDialog();
		}
		
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			getDatos();
		}
		
		void CmdExcelClick(object sender, EventArgs e)
		{
			exportaExcel();
		}
		
		#region EXCEL
		void exportaExcel()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			
			ExcelApp.Cells[i,1] = "ID";
			ExcelApp.Cells[i,2] = "OPERADOR";
			ExcelApp.Cells[i,3] = "SALDO";
			ExcelApp.Cells[i,4] = "DESTINO";
			ExcelApp.Cells[i,5] = "SALIDA";
			ExcelApp.Cells[i,6] = "REGRESO";
			ExcelApp.Cells[i,7] = "HORAS";
			ExcelApp.Cells[i,8] = "OP. COBRA";
			ExcelApp.Cells[i,9] = "TIPO PAGO";
			ExcelApp.Cells[i,10] = "REGISTRO";
			
			
			for(int x=0; x<dgPendiente.Rows.Count; x++)
			{
				i++;
				
				ExcelApp.Cells[i, 1] = dgPendiente[0,x].Value.ToString();
				ExcelApp.Cells[i, 2] = dgPendiente[1,x].Value.ToString();
				ExcelApp.Cells[i, 3] = dgPendiente[2,x].Value.ToString();
				ExcelApp.Cells[i, 4] = dgPendiente[3,x].Value.ToString();
				ExcelApp.Cells[i, 5] = dgPendiente[4,x].Value.ToString();
				ExcelApp.Cells[i, 6] = dgPendiente[5,x].Value.ToString();
				ExcelApp.Cells[i, 7] = dgPendiente[6,x].Value.ToString();
				ExcelApp.Cells[i, 8] = dgPendiente[7,x].Value.ToString();
				ExcelApp.Cells[i, 9] = dgPendiente[8,x].Value.ToString();
				ExcelApp.Cells[i, 10] = dgPendiente[9,x].Value.ToString();
			}
			
			// ---------- cuadro de dialogo para Guardar
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "PENDIENTES "+DateTime.Now.ToString("dd_MM_yyyy");
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
		
		void CmdListoClick(object sender, EventArgs e)
		{
			if(dgPendiente.SelectedRows.Count>0)
			{
				for(int x=0; x<dgPendiente.Rows.Count; x++)
				{	
					if(dgPendiente.Rows[x].Selected==true)
					{
						String consulta = "UPDATE RUTA_ESPECIAL SET DATO_PAGO='1' WHERE ID_RE="+dgPendiente[0,x].Value.ToString();
					
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();
					}
				}
				
				borrar();
			}
		}
		
		void borrar()
		{
			for(int x=dgPendiente.Rows.Count-1; x>-1; x--)
			{
				if(dgPendiente.Rows[x].Selected==true)
				{
					dgPendiente.Rows.RemoveAt(x);
				}
			}
			dgPendiente.ClearSelection();
		}
		
		#region EVENTOS RADIO BUTTONS
		void RbPendienteCheckedChanged(object sender, EventArgs e)
		{
			if(rbPendiente.Checked==false)
			{
				cmdListo.Enabled=false;
				cbMostrar.Enabled=false;
			}
			else
			{
				cmdListo.Enabled=true;
				cbMostrar.Enabled=true;
			}
			
			getDatos();
		}
		
		void RbIncobrableCheckedChanged(object sender, EventArgs e)
		{
			getDatos();
		}
		
		void RbPagadosCheckedChanged(object sender, EventArgs e)
		{
			getDatos();
		}
		#endregion
	}
}
