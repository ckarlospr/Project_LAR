using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using Transportes_LAR.Interfaz.Consultas;
using Transportes_LAR.Interfaz.Operaciones;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Text;

namespace Transportes_LAR.Proceso
{
	public class Excel
	{
		#region VARIABLES
		int acumulador = 0;
		int progreso = 1;
		int total = 0;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		public Interfaz.Operaciones.FormPrin_Empresas formPrincEmp = null;
		public nmExcel.ApplicationClass ExcelApp = null;
		Interfaz.FormPrincipal principal = null;
		#endregion
		
		#region CONTRUCTOR - DESCTRUCTOR
		public Excel():base()
		{
			
		}
		
		~Excel()  
	    {
	        
	    }
		#endregion
		
		#region SAVEDIALOG
		void SavedialogExcel(String File)
		{
			try{
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xlsx";
				CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = File;
				if(CuadroDialogo.ShowDialog() == DialogResult.OK)
				{
					this.ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
					this.ExcelApp.ActiveWorkbook.Saved = true;
					CuadroDialogo.Dispose();
					CuadroDialogo = null;
					this.ExcelApp = null;
				}
				else
					MessageBox.Show("No Genero el Reporte ... ");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		#endregion
		
		#region LIBERAR MEMORIA EXCEL
		private int GetIDProcces(string nameProcces)
		{
			try
			{
				Process[] asProccess = Process.GetProcessesByName(nameProcces);
				foreach(Process pProccess in asProccess )
				{
					if(pProccess.MainWindowTitle == "")
					{
						return pProccess.Id;
					}
				}
				return -1;
			}
			catch
			{
				return -1;
			}
		}
		
		private void LiberaCOM(object o)
		{
			int idproc = GetIDProcces("EXCEL");
			if(idproc!=-1)
			{
				Process.GetProcessById(idproc).Kill();
			}
		}
		#endregion
		
		#region DIRECTORIO TELEFONICO
		public void DirectorioTelefonicoExcel()
		{
			try{
			int cell = 1;
			int increment=0;
    		String [] ListOperador = new String[1000];
    		this.ExcelApp = new nmExcel.ApplicationClass();     
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "Unidad";
			this.ExcelApp.Cells[1,  2] = "Alias";
			this.ExcelApp.Cells[1,  3] = "LAR";
			this.ExcelApp.Cells[1,  4] = "Celular";
			this.ExcelApp.Cells[1,  5] = "Casa";
			this.ExcelApp.Cells[1,  6] = "PUESTO";
			this.ExcelApp.Cells[1,  7] = "Nombre";
			this.ExcelApp.Cells[1,  8] = "Apellido Paterno";
			this.ExcelApp.Cells[1,  9] = "Apellido Materno";
							
			conn.getAbrirConexion("select O.Alias, O.tipo_empleado, T.Numero As Telefono, Nombre, apellido_pat, apellido_mat " +
			                      "from Operador O, TELEFONOCHOFER T " +
			                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='LAR' and O.Alias!='Admvo' ORDER BY O.Alias");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					ListOperador[increment] = conn.leer["Alias"].ToString();
					this.ExcelApp.Cells[cell + 1, 2] = conn.leer["Alias"].ToString();
					this.ExcelApp.Cells[cell + 1, 3] = conn.leer["Telefono"].ToString();
					this.ExcelApp.Cells[cell + 1, 6] = conn.leer["tipo_empleado"].ToString();
					this.ExcelApp.Cells[cell + 1, 7] = conn.leer["Nombre"].ToString();
					this.ExcelApp.Cells[cell + 1, 8] = conn.leer["apellido_pat"].ToString();
					this.ExcelApp.Cells[cell + 1, 9] = conn.leer["apellido_mat"].ToString();
					cell = cell +1;
					increment = increment + 1;
				}
			conn.conexion.Close();
			
				for(int x=0;  x<(ListOperador.Length); x++)
				{
					if(ListOperador[x] != null)
					{
						conn.getAbrirConexion("select T.Numero As Telefono " +
						                      "from Operador O, TELEFONOCHOFER T " +
						                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='Celular' and O.Alias='"+ListOperador[x].ToString()+"' and O.Alias!='Admvo'");
							conn.leer=conn.comando.ExecuteReader();
							if(conn.leer.Read())
							{
								this.ExcelApp.Cells[x + 2, 4] = conn.leer["Telefono"].ToString();
							}
							else
							{
								this.ExcelApp.Cells[x + 2, 4] = "-";
							}
						conn.conexion.Close();
						
						conn.getAbrirConexion("select T.Numero As Telefono " +
						                      "from Operador O, TELEFONOCHOFER T " +
						                      "where O.ID=T.ID_Chofer and O.Estatus='1' and T.tipo='Fijo' and O.Alias='"+ListOperador[x].ToString()+"' and O.Alias!='Admvo'");
							conn.leer=conn.comando.ExecuteReader();
							if(conn.leer.Read())
							{
								this.ExcelApp.Cells[x + 2, 5] = conn.leer["Telefono"].ToString();
							}
							else
							{
								this.ExcelApp.Cells[x + 2, 5] = "-";
							}
						conn.conexion.Close();
						conn.getAbrirConexion("select V.NUMERO from VEHICULO V, OPERADOR O, ASIGNACIONUNIDAD A where A.ID_UNIDAD=V.ID AND O.ID=A.ID_OPERADOR AND O.Alias='"+ListOperador[x].ToString()+"'");
							conn.leer=conn.comando.ExecuteReader();
							if(conn.leer.Read())
							{
								this.ExcelApp.Cells[x + 2, 1] = conn.leer["NUMERO"].ToString();
							}
							else
							{
								this.ExcelApp.Cells[x + 2, 1] = "-";
							}
						conn.conexion.Close();
					}
					else
						break;
				}
				SavedialogExcel(DateTime.Now.ToString("dd-MM-yyyy") + " Directorio Telefonico");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region SUELDO QUINCENAL
		public void SueldoQuincenaActual(Interfaz.FormPrincipal principal, String[,] Hoja, int num, double Total_nomina, double Total_nomina_real, double Total_prestamos)
		{
			try{
			int cell = 1;
    		principal.progressbarPrin.Minimum = 1;
    		principal.progressbarPrin.Maximum = num; 	
    		this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "UNIDAD";
			this.ExcelApp.Cells[1,  2] = "ALIAS";
			this.ExcelApp.Cells[1,  3] = "SUELDO REAL";
			this.ExcelApp.Cells[1,  4] = "PERCEPCIONES";
			this.ExcelApp.Cells[1,  5] = "AGUINALDO";
			this.ExcelApp.Cells[1,  6] = "PRIMA VACACIONAL";
			this.ExcelApp.Cells[1,  7] = "DESCUENTO FIJO";
			this.ExcelApp.Cells[1,  8] = "PRESTAMOS";
			this.ExcelApp.Cells[1,  9] = "TOTAL IMPUESTOS";
			
			for(int x = 0; x<num; x++)
				{
						this.ExcelApp.Cells[cell + 1, 1] = Hoja[x,0].ToString();
						this.ExcelApp.Cells[cell + 1, 2] = Hoja[x,1].ToString();
						this.ExcelApp.Cells[cell + 1, 3] = Hoja[x,2].ToString();
						this.ExcelApp.Cells[cell + 1, 4] = Hoja[x,3].ToString();
						this.ExcelApp.Cells[cell + 1, 5] = Hoja[x,4].ToString();
						this.ExcelApp.Cells[cell + 1, 6] = Hoja[x,5].ToString();
						this.ExcelApp.Cells[cell + 1, 7] = Hoja[x,6].ToString();
						this.ExcelApp.Cells[cell + 1, 8] = Hoja[x,7].ToString();
						this.ExcelApp.Cells[cell + 1, 9] = Hoja[x,8].ToString();
						cell = cell +1;
						principal.progressbarPrin.Increment(1);
				}
				this.ExcelApp.Cells[cell + 1, 2] = "Totales:";
				this.ExcelApp.Cells[cell + 1, 3] = Total_nomina.ToString("C");
				this.ExcelApp.Cells[cell + 1, 4] = Total_nomina_real.ToString("C");
				this.ExcelApp.Cells[cell + 2, 3] = "Prestamos recuperados";
				this.ExcelApp.Cells[cell + 2, 4] = Total_prestamos.ToString("C");
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				SavedialogExcel(DateTime.Now.ToString("dd-MM-yyyy") + " Sueldo Nomina");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region DATOS OPERADOR
		public void DatosOP(Interfaz.FormPrincipal principal)
		{
			try
			{
			string id = "";
			int cell = 1;
			this.ExcelApp = new nmExcel.ApplicationClass();			
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
                
			this.ExcelApp.Cells[1,  1] = "ID";
			this.ExcelApp.Cells[1,  2] = "ALIAS";
			this.ExcelApp.Cells[1,  3] = "NOMBRE";
			this.ExcelApp.Cells[1,  4] = "APELLIDO_PAT";
			this.ExcelApp.Cells[1,  5] = "APELLIDO_MAT";
			this.ExcelApp.Cells[1,  6] = "CALLE";
			this.ExcelApp.Cells[1,  7] = "COLONIA";
			this.ExcelApp.Cells[1,  8] = "NUM_EXTERIOR";
			this.ExcelApp.Cells[1,  9] = "NUM_INTERIOR";
			this.ExcelApp.Cells[1,  10] = "MUNICIPIO";
			this.ExcelApp.Cells[1,  11] = "FECHA_NACIMIENTO";
			this.ExcelApp.Cells[1,  12] = "RFC";
			this.ExcelApp.Cells[1,  13] = "CURP";
			this.ExcelApp.Cells[1,  14] = "IMSS";
			this.ExcelApp.Cells[1,  15] = "ESTADO CIVIL";
			this.ExcelApp.Cells[1,  16] = "ZONA";
			this.ExcelApp.Cells[1,  17] = "TIPO_EMPLEADO";
			this.ExcelApp.Cells[1,  18] = "FECHA INGRESO";
			this.ExcelApp.Cells[1,  19] = "PROPIA RENTADA";
			//this.ExcelApp.Cells[1,  18] = "PATRON";
				
			/*//conn.getAbrirConexion("select O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, OC.FechaInicioContrato, OC.NombrePatron " +
			conn.getAbrirConexion("select O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, MIN(OC.FechaInicioContrato) As Inicio, R.tipo " +
			                      "from OPERADOR O, OperadorContrato OC, PROPIA_RENTADA R " +
			                      "LEFT JOIN OPERADOR Op ON Op.id=R.id_operador " +
			                      "where O.ID=OC.IdOperador AND O.Tipo_Empleado like 'OPERADOR' and O.Estatus='1' " +
			                      //"GROUP BY O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, OC.FechaInicioContrato, OC.NombrePatron " +
			                      "GROUP BY O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, R.tipo " +
			                      //"HAVING MIN(OC.FechaInicioContrato) > '01-01-1950' " +
			                      "order by O.Alias");*/
			
			conn.getAbrirConexion("select O.ID, O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, MIN(OC.FechaInicioContrato) As Inicio, R.tipo " +
			                      "from OPERADOR O INNER JOIN OperadorContrato OC ON (O.ID=OC.IdOperador) " +
			                      "LEFT JOIN PROPIA_RENTADA R ON O.id=R.id_operador " +
			                      "where O.Tipo_Empleado like 'OPERADOR' and O.Estatus='1' " +
			                      //"GROUP BY O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, OC.FechaInicioContrato, OC.NombrePatron " +
			                      "GROUP BY O.ID, O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, R.tipo " +
			                      //"HAVING MIN(OC.FechaInicioContrato) > '01-01-1950' " +
			                      "order by O.Alias");
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				switch(conn.leer["ID"].ToString().Length){
					case 1: id = "000"; 
						break;
					case 2: id = "00";
						break;
					case 3: id = "0";
						break;
					case 4: id = "";
						break;
					default: id = "";
						break;
				}
				//=SI(LARGO(A2)=1;CONCATENAR("000";A2);SI(LARGO(A2)=2;CONCATENAR("00";A2);SI(LARGO(A2)=3;CONCATENAR("0";A2);A2)))
				//oscaralfredofloressolano
    			//this.ExcelApp.Cells[cell + 1, 1].Formula= "=SI(LARGO(A"+cell+")=1;CONCATENAR('000';"+conn.leer["ID"].ToString()+");SI(LARGO(A"+cell+")=2;CONCATENAR('00';"+conn.leer["ID"].ToString()+");SI(LARGO(A"+cell+")=3;CONCATENAR('0';"+conn.leer["ID"].ToString()+");"+conn.leer["ID"].ToString()+")))";
    			//this.ExcelApp.Cells[cell + 1, 1] = "=SI(LARGO("+conn.leer["ID"].ToString()+")=1;CONCATENAR(\"000\";"+conn.leer["ID"].ToString()+");SI(LARGO("+conn.leer["ID"].ToString()+")=2;CONCATENAR(\"00\";"+conn.leer["ID"].ToString()+");SI(LARGO("+conn.leer["ID"].ToString()+")=3;CONCATENAR(\"0\";"+conn.leer["ID"].ToString()+");"+conn.leer["ID"].ToString()+")))";
				this.ExcelApp.Cells[cell + 1, 1] = id+conn.leer["ID"].ToString();
					//new StringBuilder(id).Append(conn.leer["ID"].ToString()).ToString();
				//string.Concat(id, conn.leer["ID"].ToString()); //id+conn.leer["ID"].ToString();
				this.ExcelApp.Cells[cell + 1, 2] = conn.leer["Alias"].ToString();
				this.ExcelApp.Cells[cell + 1, 3] = conn.leer["Nombre"].ToString();
				this.ExcelApp.Cells[cell + 1, 4] = conn.leer["Apellido_Pat"].ToString();
				this.ExcelApp.Cells[cell + 1, 5] = conn.leer["Apellido_Mat"].ToString();
				this.ExcelApp.Cells[cell + 1, 6] = conn.leer["Calle"].ToString();
				this.ExcelApp.Cells[cell + 1, 7] = conn.leer["Colonia"].ToString();
				this.ExcelApp.Cells[cell + 1, 8] = conn.leer["Num_Interior"].ToString();
				this.ExcelApp.Cells[cell + 1, 9] = conn.leer["Num_Exterior"].ToString();
				this.ExcelApp.Cells[cell + 1, 10] = conn.leer["Municipio"].ToString();
				this.ExcelApp.Cells[cell + 1, 11] = conn.leer["Fecha_Nacimiento"].ToString();
				this.ExcelApp.Cells[cell + 1, 14] = conn.leer["IMSS"].ToString();
				this.ExcelApp.Cells[cell + 1, 12] = conn.leer["RFC"].ToString();
				this.ExcelApp.Cells[cell + 1, 13] = conn.leer["CURP"].ToString();
				this.ExcelApp.Cells[cell + 1, 15] = conn.leer["Estado_Civil"].ToString();
				this.ExcelApp.Cells[cell + 1, 16] = conn.leer["Zona"].ToString();
				this.ExcelApp.Cells[cell + 1, 17] = conn.leer["Tipo_Empleado"].ToString();
				this.ExcelApp.Cells[cell + 1, 18] = conn.leer["Inicio"].ToString().Substring(0,10);
				this.ExcelApp.Cells[cell + 1, 19] = conn.leer["Tipo"].ToString();
				//this.ExcelApp.Cells[cell + 1, 18] = conn.leer["NombrePatron"].ToString();
				cell = cell +1;
			}
			conn.conexion.Close();
			SavedialogExcel(DateTime.Now.ToString("dd-MM-yyyy") + " Datos Operadores");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region DATOS ADMINISTRATIVO
		public void DatosAdmin(Interfaz.FormPrincipal principal)
		{
			try{
			int cell = 1;  
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "ID";
			this.ExcelApp.Cells[1,  2] = "ALIAS";
			this.ExcelApp.Cells[1,  3] = "NOMBRE";
			this.ExcelApp.Cells[1,  4] = "APELLIDO_PAT";
			this.ExcelApp.Cells[1,  5] = "APELLIDO_MAT";
			this.ExcelApp.Cells[1,  6] = "CALLE";
			this.ExcelApp.Cells[1,  7] = "COLONIA";
			this.ExcelApp.Cells[1,  8] = "NUM_INTERIOR";
			this.ExcelApp.Cells[1,  9] = "NUM_EXTERIOR";
			this.ExcelApp.Cells[1,  10] = "MUNICIPIO";
			this.ExcelApp.Cells[1,  11] = "FECHA_NACIMIENTO";
			this.ExcelApp.Cells[1,  12] = "RFC";
			this.ExcelApp.Cells[1,  13] = "CURP";
			this.ExcelApp.Cells[1,  14] = "IMSS";
			this.ExcelApp.Cells[1,  15] = "ESTADO CIVIL";
			this.ExcelApp.Cells[1,  16] = "ZONA";
			this.ExcelApp.Cells[1,  17] = "TIPO_EMPLEADO";
			this.ExcelApp.Cells[1,  18] = "FECHA INGRESO";
			this.ExcelApp.Cells[1,  19] = "PATRON";
				
			conn.getAbrirConexion("select O.ID, O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, MIN(OC.FechaInicioContrato) as Inicio, OC.NombrePatron " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador AND O.Tipo_Empleado!='OPERADOR' and O.Estatus='1' " +
			                      "GROUP BY O.ID, O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat, O.Calle, O.Colonia, O.Num_Interior, O.Num_Exterior, O.Municipio, O.Fecha_Nacimiento, O.RFC, O.CURP, O.IMSS, O.Estado_Civil, O.Zona, O.Tipo_Empleado, OC.NombrePatron " +
			                      "HAVING MAX(OC.FechaInicioContrato) > '01-01-1950' " +
			                      "order by O.Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				this.ExcelApp.Cells[cell + 1, 1] = conn.leer["ID"].ToString();
				this.ExcelApp.Cells[cell + 1, 2] = conn.leer["Alias"].ToString();
				this.ExcelApp.Cells[cell + 1, 3] = conn.leer["Nombre"].ToString();
				this.ExcelApp.Cells[cell + 1, 4] = conn.leer["Apellido_Pat"].ToString();
				this.ExcelApp.Cells[cell + 1, 5] = conn.leer["Apellido_Mat"].ToString();
				this.ExcelApp.Cells[cell + 1, 6] = conn.leer["Calle"].ToString();
				this.ExcelApp.Cells[cell + 1, 7] = conn.leer["Colonia"].ToString();
				this.ExcelApp.Cells[cell + 1, 8] = conn.leer["Num_Interior"].ToString();
				this.ExcelApp.Cells[cell + 1, 9] = conn.leer["Num_Exterior"].ToString();
				this.ExcelApp.Cells[cell + 1, 10] = conn.leer["Municipio"].ToString();
				this.ExcelApp.Cells[cell + 1, 11] = conn.leer["Fecha_Nacimiento"].ToString();
				this.ExcelApp.Cells[cell + 1, 14] = conn.leer["IMSS"].ToString();
				this.ExcelApp.Cells[cell + 1, 12] = conn.leer["RFC"].ToString();
				this.ExcelApp.Cells[cell + 1, 13] = conn.leer["CURP"].ToString();
				this.ExcelApp.Cells[cell + 1, 15] = conn.leer["Estado_Civil"].ToString();
				this.ExcelApp.Cells[cell + 1, 16] = conn.leer["Zona"].ToString();
				this.ExcelApp.Cells[cell + 1, 17] = conn.leer["Tipo_Empleado"].ToString();
				this.ExcelApp.Cells[cell + 1, 18] = conn.leer["Inicio"].ToString().Substring(0,10);
				this.ExcelApp.Cells[cell + 1, 19] = conn.leer["NombrePatron"].ToString();
				cell = cell +1;
			}
			conn.conexion.Close();
			SavedialogExcel(DateTime.Now.ToString("dd-MM-yyyy") + " Datos Operadores");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region CONCENTRADO DESCUENTOS
		public void ConcetradoDescuento(Interfaz.FormPrincipal principal)
		{
			try{
			int cell = 1;
			this.ExcelApp = new nmExcel.ApplicationClass();
    		principal.progressbarPrin.Minimum = 1;
    		principal.progressbarPrin.Maximum = 10000; 	
       
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "OPERADOR";
			this.ExcelApp.Cells[1,  2] = "ID_DESCUENTO";
			this.ExcelApp.Cells[1,  3] = "FECHA";
			this.ExcelApp.Cells[1,  4] = "CONCEPTO";
			this.ExcelApp.Cells[1,  5] = "NUM. PAGO";
			this.ExcelApp.Cells[1,  6] = "IMPORTE";
			this.ExcelApp.Cells[1,  7] = "IMPORTE ORIGINAL";
								
				conn.getAbrirConexion("select O.Alias, DT.ID_DESCUENTO, DT.FECHA, D.DESCRIPCION, D.IMPORTE_TOTAL, DT.IMPORTE,  DT.NOMENCLATURA "+
		                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
		                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
		                               "and FLUJO!='3' and FLUJO!='5' " +
		                               "and O.Estatus='1' AND O.tipo_empleado='OPERADOR' and O.Alias!='Admvo' " +
		                               "order by DT.FECHA");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
						this.ExcelApp.Cells[cell + 1, 1] = conn.leer["Alias"].ToString();
						this.ExcelApp.Cells[cell + 1, 2] = conn.leer["ID_DESCUENTO"].ToString();
						this.ExcelApp.Cells[cell + 1, 3] = conn.leer["FECHA"].ToString().Substring(0,10);
						this.ExcelApp.Cells[cell + 1, 4] = conn.leer["NOMENCLATURA"].ToString();
						this.ExcelApp.Cells[cell + 1, 5] = conn.leer["DESCRIPCION"].ToString();
						this.ExcelApp.Cells[cell + 1, 6] = conn.leer["IMPORTE"].ToString();
						this.ExcelApp.Cells[cell + 1, 7] = conn.leer["IMPORTE_TOTAL"].ToString();
						cell = cell +1;
						principal.progressbarPrin.Increment(1);
				}
				conn.conexion.Close();
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				SavedialogExcel(DateTime.Now.ToString("dd-MM-yyyy") + " Reporte Descuentos");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}			
		}
		#endregion
		
		#region HOJA DESCUENTOS
		public void HojaDescuentos(DataGridView dataTotal)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 10;
			this.ExcelApp.Cells[1,  1] = "UNI";
			this.ExcelApp.Cells[1,  2] = "OPERADOR";
			this.ExcelApp.Cells[1,  3] = "DOCTOR";
			this.ExcelApp.Cells[1,  4] = "PAGO";
			this.ExcelApp.Cells[1,  5] = "UNIFORME";
			this.ExcelApp.Cells[1,  6] = "PAGO";
			this.ExcelApp.Cells[1,  7] = "TRAMITE";
			this.ExcelApp.Cells[1,  8] = "PAGO";
			this.ExcelApp.Cells[1,  9] = "TALLER";
			this.ExcelApp.Cells[1,  10] = "DESC 1";
			this.ExcelApp.Cells[1,  11] = "$";	
			this.ExcelApp.Cells[1,  12] = "DESC 2";
			this.ExcelApp.Cells[1,  13] = "$";	
			this.ExcelApp.Cells[1,  14] = "DESC 3";
			this.ExcelApp.Cells[1,  15] = "$";	
			this.ExcelApp.Cells[1,  16] = "PREST.";
			this.ExcelApp.Cells[1,  17] = "$";	
			this.ExcelApp.Cells[1,  18] = "PREST.";
			this.ExcelApp.Cells[1,  19] = "$";		
			this.ExcelApp.Cells[1,  20] = "TOTAL";
			this.ExcelApp.Cells[1,  21] = "PAGARE";			
			
			for(int x=0; x<dataTotal.Rows.Count; x++)
				{
					for(int y=2; y<dataTotal.ColumnCount; y++)
					{
						if(dataTotal.Rows[x].Cells[y].Value!=null)
							this.ExcelApp.Cells[x+2, y-1] = dataTotal.Rows[x].Cells[y].Value.ToString();
						else
							this.ExcelApp.Cells[x+2, y-1] = "-";
					}
						
				}	
				SavedialogExcel(DateTime.Now.ToString("dd-MM-yyyy") + " Reporte Anticipos");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE ASIGNADOS
		public void ReporteEspecialesAsignados(DataGridView dataViajesEspeciales)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Cells[1,  1] = "ID";
			this.ExcelApp.Cells[1,  2] = "OPERADOR";
			this.ExcelApp.Cells[1,  3] = "UNIDAD";
			this.ExcelApp.Cells[1,  4] = "DESTINO";
			this.ExcelApp.Cells[1,  5] = "SENTIDO";
			this.ExcelApp.Cells[1,  6] = "PRECIO";
			this.ExcelApp.Cells[1,  7] = "FECHA";
			this.ExcelApp.Cells[1,  8] = "FACTURA";
			this.ExcelApp.Cells[1,  9] = "DOMICILIO";
			this.ExcelApp.Cells[1,  10] = "OBSERVACIONES";
			for(int x=0; x<dataViajesEspeciales.Rows.Count; x++)
				{
					for(int y=0; y<dataViajesEspeciales.ColumnCount; y++)
					{
						if(dataViajesEspeciales.Rows[x].Cells[y].Value!=null&&dataViajesEspeciales.Rows[x].Cells[y].Value.ToString()!="")
							this.ExcelApp.Cells[x+2, y+1] = dataViajesEspeciales.Rows[x].Cells[y].Value.ToString();
						else
							this.ExcelApp.Cells[x+2, y+1] = "-";
					}
						
				}	
				SavedialogExcel(DateTime.Now.ToString("yyyy-MM-dd") + " Reporte Ventas Asignados");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE SIN ASIGNAR
		public void ReporteEspecialesSinAsignar(DataGridView dataViajesEspeciales2)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  1] = "ID";
			this.ExcelApp.Cells[1,  2] = "DESTINO";
			this.ExcelApp.Cells[1,  3] = "PRECIO";
			this.ExcelApp.Cells[1,  4] = "FECHA";
			this.ExcelApp.Cells[1,  5] = "DOMICILIO";
			this.ExcelApp.Cells[1,  6] = "FACTURA";
			this.ExcelApp.Cells[1,  7] = "OBSERVACIONES";
			for(int x=0; x<dataViajesEspeciales2.Rows.Count; x++)
				{
					for(int y=2; y<dataViajesEspeciales2.ColumnCount; y++)
					{
						if(dataViajesEspeciales2.Rows[x].Cells[y].Value!=null&&dataViajesEspeciales2.Rows[x].Cells[y].Value.ToString()!="")
							this.ExcelApp.Cells[x+2, y-1] = dataViajesEspeciales2.Rows[x].Cells[y].Value.ToString();
						else
							this.ExcelApp.Cells[x+2, y-1] = "-";
					}
						
				}	
				SavedialogExcel(DateTime.Now.ToString("yyyy-MM-dd") + "  Reporte Ventas Sin Asignar");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE QUINCENAL SUELDO
		public void ReporteQuincenal(DataGridView dataImpuestos)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 30;
			
			for(int x=0; x<dataImpuestos.Rows.Count; x++)
				{
				for(int m=0; m<dataImpuestos.Columns.Count; m++)
					{
						this.ExcelApp.Cells[1,  m+1] = dataImpuestos.Columns[m].HeaderText;
						if(dataImpuestos.Rows[x].Cells[m].Value==null||dataImpuestos.Rows[x].Cells[m].Value.ToString()=="")
							this.ExcelApp.Cells[x + 2, m+1] = "0.0";
						else
							this.ExcelApp.Cells[x + 2, m+1] = dataImpuestos.Rows[x].Cells[m].Value.ToString();
					}
						
				}	
				SavedialogExcel(DateTime.Now.ToString("yyyy-MM-dd") + " Historial Quincenal");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE EVA PELAYO
		public void ReporteEva(String FechaInicio, String FechaCorte)
		{
			try{
			int cell = 1;
			this.ExcelApp = new nmExcel.ApplicationClass();			
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "Estado";
			this.ExcelApp.Cells[1,  2] = "Fecha";
			this.ExcelApp.Cells[1,  3] = "Hora";
			this.ExcelApp.Cells[1,  4] = "Autoriza";
			this.ExcelApp.Cells[1,  5] = "Usuario";
			this.ExcelApp.Cells[1,  6] = "Telefono";
			this.ExcelApp.Cells[1,  7] = "Domicilio";
			this.ExcelApp.Cells[1,  8] = "Colonia";
			this.ExcelApp.Cells[1,  9] = "Sentido";
			this.ExcelApp.Cells[1,  10] = "Nombre";
							
			conn.getAbrirConexion("select O.estatus, O.fecha, R.HoraInicio, S.AUTORIZA, S.USUARIO, S.TELEFONO, S.DOMICILIO, S.COLONIA, R.Sentido, R.Nombre "+
									"from Cliente C, RUTA R, SERV_DOMICILIADO S, OPERACION O "+
									"where C.ID=R.IdSubEmpresa and R.ID=S.ID_R and R.ID=O.id_ruta "+
									"and C.Empresa like '%Farm%' and O.fecha between '"+FechaInicio+"' and '"+FechaCorte+"' "+
									"and (S.AUTORIZA like '%EV%' or S.USUARIO like '%EVa%') and O.estatus='1'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					this.ExcelApp.Cells[cell + 1, 1] = conn.leer["estatus"].ToString();
					this.ExcelApp.Cells[cell + 1, 2] = conn.leer["fecha"].ToString().Substring(0,10);;
					this.ExcelApp.Cells[cell + 1, 3] = conn.leer["HoraInicio"].ToString();
					this.ExcelApp.Cells[cell + 1, 4] = conn.leer["AUTORIZA"].ToString();
					this.ExcelApp.Cells[cell + 1, 5] = conn.leer["USUARIO"].ToString();
					this.ExcelApp.Cells[cell + 1, 6] = conn.leer["TELEFONO"].ToString();
					this.ExcelApp.Cells[cell + 1, 7] = conn.leer["DOMICILIO"].ToString();
					this.ExcelApp.Cells[cell + 1, 8] = conn.leer["COLONIA"].ToString();
					this.ExcelApp.Cells[cell + 1, 9] = conn.leer["Sentido"].ToString();
					this.ExcelApp.Cells[cell + 1, 10] = conn.leer["Nombre"].ToString();
					cell = cell +1;
			}
			conn.conexion.Close();
			SavedialogExcel(DateTime.Now.ToString("yyyy-MM-dd") + " Reporte EVA PELAYO");
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}		
		}
		#endregion
		
		#region REPORTE TOTALES
		public void ReporteTotalesExcel(DateTimePicker dtInicio, DateTimePicker dtCorte, Interfaz.FormPrincipal principal)
		{
			acumulador = 0;
			progreso = 1;
			total = 0;
			this.principal=principal;
			
			try{
			int cell = 1;
			this.ExcelApp = new nmExcel.ApplicationClass();			
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  1] = "VEHICULO";
			this.ExcelApp.Cells[1,  2] = "EMPRESA";
			this.ExcelApp.Cells[1,  3] = "SUBEMPRESA";
			this.ExcelApp.Cells[1,  4] = "FECHA";
			this.ExcelApp.Cells[1,  5] = "TURNO";
			this.ExcelApp.Cells[1,  6] = "RUTA";
			this.ExcelApp.Cells[1,  7] = "SENTIDO";
			this.ExcelApp.Cells[1,  8] = "HORA INICIO";
			this.ExcelApp.Cells[1,  9] = "NICK";
			this.ExcelApp.Cells[1,  10] = "UNIDAD";
			this.ExcelApp.Cells[1,  11] = "HORA DE LLEGADA REAL";
			this.ExcelApp.Cells[1,  12] = "HORA DE LLEGADA ESTABLECIDA";
			this.ExcelApp.Cells[1,  13] = "USUARIOS";
			this.ExcelApp.Cells[1,  14] = "COORDINADOR";
			this.ExcelApp.Cells[1,  15] = "TIPO RUTA";
			this.ExcelApp.Cells[1,  16] = "FORANEA O EXTERNA";
			this.ExcelApp.Cells[1,  17] = "TIPO OPERADOR";
			this.ExcelApp.Cells[1,  18] = "KM";
			
			String consulta = "SELECT count(R.ID) as Registro "+
									"FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V "+
									"WHERE U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' "+
									"AND O.fecha between '"+dtInicio.Value.ToString("dd-MM-yyyy")+"' AND '"+dtCorte.Value.ToString("dd-MM-yyyy")+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				total = Convert.ToInt32(conn.leer["Registro"]);
			conn.conexion.Close();
			
			consulta = "SELECT V.Tipo_Unidad, R.ID, C.Empresa, C.SubNombre, O.fecha, R.Turno, R.Nombre, R.Sentido, R.HoraInicio, OP.Alias, V.Numero, O.llegada, O.pasajeros, U.usuario, O.estatus, R.TIPO, R.foranea, OP.tipo_empleado, R.kilometros, R.hora_llegada "+
									"FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, VEHICULO V "+
									"WHERE U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo and O.estatus='1' "+
									"AND O.fecha between '"+dtInicio.Value.ToString("dd-MM-yyyy")+"' AND '"+dtCorte.Value.ToString("dd-MM-yyyy")+"' ORDER BY O.fecha, R.Turno, R.Nombre";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				this.ExcelApp.Cells[cell + 1, 1] = conn.leer["Tipo_Unidad"].ToString();
				this.ExcelApp.Cells[cell + 1, 2] = conn.leer["Empresa"].ToString();
				this.ExcelApp.Cells[cell + 1, 3] = conn.leer["SubNombre"].ToString();
				this.ExcelApp.Cells[cell + 1, 4] = Convert.ToDateTime(conn.leer["fecha"]);
				this.ExcelApp.Cells[cell + 1, 5] = conn.leer["Turno"].ToString();
				this.ExcelApp.Cells[cell + 1, 6] = conn.leer["Nombre"].ToString();
				this.ExcelApp.Cells[cell + 1, 7] = conn.leer["Sentido"].ToString();
				this.ExcelApp.Cells[cell + 1, 8] = conn.leer["HoraInicio"].ToString();
				this.ExcelApp.Cells[cell + 1, 9] = conn.leer["Alias"].ToString();
				this.ExcelApp.Cells[cell + 1, 10] = conn.leer["Numero"].ToString();
				this.ExcelApp.Cells[cell + 1, 11] = conn.leer["llegada"].ToString();
				this.ExcelApp.Cells[cell + 1, 12] = conn.leer["HORA_llegada"].ToString();
				this.ExcelApp.Cells[cell + 1, 13] = conn.leer["pasajeros"].ToString();
				this.ExcelApp.Cells[cell + 1, 14] = conn.leer["usuario"].ToString();
				this.ExcelApp.Cells[cell + 1, 15] = conn.leer["tipo"].ToString();
				this.ExcelApp.Cells[cell + 1, 16] = ((conn.leer["foranea"].ToString()=="1")?"FORANEA":"LOCAL");
				this.ExcelApp.Cells[cell + 1, 17] = conn.leer["tipo_empleado"].ToString().ToUpper();
				this.ExcelApp.Cells[cell + 1, 18] = conn.leer["kilometros"].ToString().ToUpper();
				cell = cell +1;
				progresobarra(total);
			}
			conn.conexion.Close();
			SavedialogExcel("Reporte Totales "+dtInicio.Value.ToString("dd-MM-yyyy")+" "+dtCorte.Value.ToString("dd-MM-yyyy"));
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE DIRECTIVO
		public void ReporteDirectivoExcel(DataGridView dataReporteDirectivo, DateTimePicker dtInicio, DateTimePicker dtCorte, Interfaz.FormPrincipal principal)
		{
			acumulador = 0;
			progreso = 1;
			this.principal=principal;
			
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "TIPO";
			this.ExcelApp.Cells[1,  2] = "FECHA";
			this.ExcelApp.Cells[1,  3] = "EMPRESA";
			this.ExcelApp.Cells[1,  4] = "SUBEMPRESA";
			this.ExcelApp.Cells[1,  5] = "RUTA";
			this.ExcelApp.Cells[1,  6] = "SENTIDO";
			this.ExcelApp.Cells[1,  7] = "TURNO";
			this.ExcelApp.Cells[1,  8] = "VEHICULO";
			this.ExcelApp.Cells[1,  9] = "VEHICULO REAL";
			this.ExcelApp.Cells[1,  10] = "TIPO_RUTA";
			this.ExcelApp.Cells[1,  11] = "ORDEN";
			this.ExcelApp.Cells[1,  12] = "VELADA";
			this.ExcelApp.Cells[1,  13] = "HORA DE INICIO";
			this.ExcelApp.Cells[1,  14] = "HORA DE FIN";
			this.ExcelApp.Cells[1,  15] = "HORA DE LLEGADA REAL";
			this.ExcelApp.Cells[1,  16] = "KM";
			this.ExcelApp.Cells[1,  17] = "FORANEO";
			this.ExcelApp.Cells[1,  18] = "IMPORTE";
			this.ExcelApp.Cells[1,  19] = "OPERADOR";
			this.ExcelApp.Cells[1,  20] = "SEMANA";
							
			for(int x=0; x<dataReporteDirectivo.Rows.Count; x++)
				{
					for(int z=0; z<dataReporteDirectivo.Columns.Count; z++)
					{
						this.ExcelApp.Cells[x + 2, z+1] = dataReporteDirectivo.Rows[x].Cells[z].Value;
					}
					progresobarra(dataReporteDirectivo.Rows.Count);
				}
				SavedialogExcel("Reporte Directivo "+dtInicio.Value.ToString("dd-MM-yyyy")+" "+dtCorte.Value.ToString("dd-MM-yyyy"));
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;				
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE OPERADORES EXTERNOS
		public void ReporteOperadoresExternos(DataGridView dataViajesNormales, DataGridView dataApoyos)
		{
			try{
				int cell = 1;
				this.ExcelApp = new nmExcel.ApplicationClass();				
				this.ExcelApp.Application.Workbooks.Add(Type.Missing);
				this.ExcelApp.Columns.ColumnWidth = 20;
				
				this.ExcelApp.Cells[1,  1] = "FECHA";
				this.ExcelApp.Cells[1,  2] = "EMPRESA";
				this.ExcelApp.Cells[1,  3] = "RUTA";
				this.ExcelApp.Cells[1,  4] = "SENTIDO";
				this.ExcelApp.Cells[1,  5] = "TURNO";
				this.ExcelApp.Cells[1,  6] = "VEHICULO";
				this.ExcelApp.Cells[1,  7] = "PAGO";
				this.ExcelApp.Cells[1,  8] = "TIPO";
				for(int x=0; x<dataViajesNormales.Rows.Count; x++)
					{
							this.ExcelApp.Cells[cell + 1, 1] = dataViajesNormales.Rows[x].Cells[1].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 2] = dataViajesNormales.Rows[x].Cells[2].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 3] = dataViajesNormales.Rows[x].Cells[3].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 4] = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 5] = dataViajesNormales.Rows[x].Cells[5].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 6] = dataViajesNormales.Rows[x].Cells[6].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 7] = dataViajesNormales.Rows[x].Cells[8].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 8] = dataViajesNormales.Rows[x].Cells[9].Value.ToString();
							cell = cell +1;
					}
				
				++cell;
				++cell;
				
				this.ExcelApp.Cells[cell,  1] = "FECHA";
				this.ExcelApp.Cells[cell,  2] = "ALIAS";
				this.ExcelApp.Cells[cell,  3] = "RUTA";
				this.ExcelApp.Cells[cell,  4] = "TURNO";
				this.ExcelApp.Cells[cell,  5] = "TIPO";
				this.ExcelApp.Cells[cell,  6] = "COMENTARIO";
				
				for(int x=0; x<dataApoyos.Rows.Count; x++)
					{
							this.ExcelApp.Cells[cell + 1, 1] = dataApoyos.Rows[x].Cells[3].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 2] = dataApoyos.Rows[x].Cells[2].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 3] = dataApoyos.Rows[x].Cells[4].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 4] = dataApoyos.Rows[x].Cells[5].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 5] = dataApoyos.Rows[x].Cells[6].Value.ToString();
							this.ExcelApp.Cells[cell + 1, 6] = dataApoyos.Rows[x].Cells[7].Value.ToString();
							cell = cell +1;
					}				
				
				SavedialogExcel("Reporte Externos "+DateTime.Now.ToString("dd-MM-yyyy"));
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE HISTORIAL CONTRATO
		public void Historial_Contrato(DataGridView dataContrato)
		{
			try
			{
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			for (int i = 0; i < dataContrato.Rows.Count-1; i++)
			{
				if(i==0)
				{
					this.ExcelApp.Cells[i + 1,  1] = "ALIAS";
					this.ExcelApp.Cells[i + 1,  2] = "ID";
					this.ExcelApp.Cells[i + 1,  3] = "ID OPERADOR";
					this.ExcelApp.Cells[i + 1,  4] = "FECHA DE INICIO CONTRATO";
					this.ExcelApp.Cells[i + 1,  5] = "FECHA";
					this.ExcelApp.Cells[i + 1,  6] = "HORA";
					this.ExcelApp.Cells[i + 1,  7] = "NOMBRE PATRON";
					this.ExcelApp.Cells[i + 1,  8] = "NACIONALIDAD PATRON";
					this.ExcelApp.Cells[i + 1,  9] = "EDAD PATRON";
					this.ExcelApp.Cells[i + 1,  10] = "SEXO DEL PATRON";
					this.ExcelApp.Cells[i + 1,  11] = "ESTADO CIVIL PATRON";
					this.ExcelApp.Cells[i + 1,  12] = "DOMICILIO PATRON";
					this.ExcelApp.Cells[i + 1,  13] = "NACIONALIDAD";
					this.ExcelApp.Cells[i + 1,  14] = "SEXO";
					this.ExcelApp.Cells[i + 1,  15] = "TIEMPO DE CELEBRACION";
					this.ExcelApp.Cells[i + 1,  16] = "SERVICIO PERSONAL";
					this.ExcelApp.Cells[i + 1,  17] = "LUGAR DESEMPEÑO";
					this.ExcelApp.Cells[i + 1,  18] = "DURACION JORNADA";
					this.ExcelApp.Cells[i + 1,  19] = "TARIFA";
					this.ExcelApp.Cells[i + 1,  20] = "IMPUESTO RENTA";
					this.ExcelApp.Cells[i + 1,  21] = "DIAS DE PAGO";
					this.ExcelApp.Cells[i + 1,  22] = "TIPOS DE PAGO";
					this.ExcelApp.Cells[i + 1,  23] = "VACACIONES";
					this.ExcelApp.Cells[i + 1,  24] = "LO FIRMA";
					this.ExcelApp.Cells[i + 1,  25] = "ELABORO";
					this.ExcelApp.Cells[i + 1,  26] = "TIPO CONTRATO";
				}
				else
				{
					for (int j = 0; j < dataContrato.Columns.Count-1; j++)
					{
						if(dataContrato.Rows[i].Cells[j].Value.ToString().Equals(""))
							this.ExcelApp.Cells[i + 1, j + 1]="null";
						else
							this.ExcelApp.Cells[i + 1, j + 1] = dataContrato.Rows[i-1].Cells[j].Value.ToString();
					}
				}
			}
			SavedialogExcel("Reporte Historial Contrato "+DateTime.Now.ToString("dd-MM-yyyy"));
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE OPERACIONES
		public void imprimirDespacho(Interfaz.Operaciones.FormPrin_Empresas formPrincEmp)
		{
			try
			{
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			
			for(int x=0; x<formPrincEmp.refMOV.Count; x++)
			{
				if(formPrincEmp.refMOV[x].dtgEmpresas.Rows.Count>0)
				{
					++i;
					this.ExcelApp.Cells[i,  1] = formPrincEmp.refMOV[x].lblNombreEmp.Text;
					++i;
					this.ExcelApp.Cells[i,  1] = "Entradas";
					this.ExcelApp.Cells[i,  7] = "Salidas";
					++i;
					this.ExcelApp.Cells[i,  1] 	= "USUARIOS";
					this.ExcelApp.Cells[i,  2] 	= "OPERADOR";
					this.ExcelApp.Cells[i,  3] 	= "HORA";
					this.ExcelApp.Cells[i,  4] 	= "CONFIRMACION";
					this.ExcelApp.Cells[i,  5] 	= "RUTA";
					this.ExcelApp.Cells[i,  6] 	= "LLEGADA";
					this.ExcelApp.Cells[i,  7] 	= "USUARIOS";
					this.ExcelApp.Cells[i,  8] 	= "OPERADOR";
					this.ExcelApp.Cells[i,  9] 	= "HORA";
					this.ExcelApp.Cells[i,  10] 	= "CONFIRMACION";
					this.ExcelApp.Cells[i,  11] 	= "RUTA";
					for(int y=0; y<formPrincEmp.refMOV[x].dtgEmpresas.Rows.Count; y++)
					{
						++i;
						if(formPrincEmp.refMOV[x].dtgEmpresas[3,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[11,y].Style.BackColor.Name=="MediumSpringGreen")
						{
							this.ExcelApp.Cells[i,  1] 	= formPrincEmp.refMOV[x].dtgEmpresas[0,y].Value.ToString();
							this.ExcelApp.Cells[i,  2] 	= formPrincEmp.refMOV[x].dtgEmpresas[3,y].Value.ToString();
							this.ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							this.ExcelApp.Cells[i,  4] 	= formPrincEmp.refMOV[x].dtgEmpresas[5,y].Value.ToString();
							this.ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							this.ExcelApp.Cells[i,  6] 	= formPrincEmp.refMOV[x].dtgEmpresas[7,y].Value.ToString();
							this.ExcelApp.Cells[i,  7] 	= formPrincEmp.refMOV[x].dtgEmpresas[9,y].Value.ToString();
							this.ExcelApp.Cells[i,  8] 	= formPrincEmp.refMOV[x].dtgEmpresas[11,y].Value.ToString();
							this.ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							this.ExcelApp.Cells[i,  10] 	= formPrincEmp.refMOV[x].dtgEmpresas[13,y].Value.ToString();
							this.ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[3,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()!="")
						{
							this.ExcelApp.Cells[i,  1] 	= formPrincEmp.refMOV[x].dtgEmpresas[0,y].Value.ToString();
							this.ExcelApp.Cells[i,  2] 	= formPrincEmp.refMOV[x].dtgEmpresas[3,y].Value.ToString();
							this.ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							this.ExcelApp.Cells[i,  4] 	= formPrincEmp.refMOV[x].dtgEmpresas[5,y].Value.ToString();
							this.ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							this.ExcelApp.Cells[i,  6] 	= formPrincEmp.refMOV[x].dtgEmpresas[7,y].Value.ToString();
							this.ExcelApp.Cells[i,  7] 	= "0";
							this.ExcelApp.Cells[i,  8] 	= " ";
							this.ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							this.ExcelApp.Cells[i,  10] 	= " ";
							this.ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[11,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()!="")
						{
							this.ExcelApp.Cells[i,  1] 	= "0";
							this.ExcelApp.Cells[i,  2] 	= " ";
							this.ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							this.ExcelApp.Cells[i,  4] 	= " ";
							this.ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							this.ExcelApp.Cells[i,  6] 	= " ";
							this.ExcelApp.Cells[i,  7] 	= formPrincEmp.refMOV[x].dtgEmpresas[9,y].Value.ToString();
							this.ExcelApp.Cells[i,  8] 	= formPrincEmp.refMOV[x].dtgEmpresas[11,y].Value.ToString();
							this.ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							this.ExcelApp.Cells[i,  10] 	= formPrincEmp.refMOV[x].dtgEmpresas[13,y].Value.ToString();
							this.ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[3,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()=="")
						{
							this.ExcelApp.Cells[i,  1] 	= formPrincEmp.refMOV[x].dtgEmpresas[0,y].Value.ToString();
							this.ExcelApp.Cells[i,  2] 	= formPrincEmp.refMOV[x].dtgEmpresas[3,y].Value.ToString();
							this.ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							this.ExcelApp.Cells[i,  4] 	= formPrincEmp.refMOV[x].dtgEmpresas[5,y].Value.ToString();
							this.ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							this.ExcelApp.Cells[i,  6] 	= formPrincEmp.refMOV[x].dtgEmpresas[7,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[11,y].Style.BackColor.Name=="MediumSpringGreen" && formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()=="")
						{
							this.ExcelApp.Cells[i,  7] 	= formPrincEmp.refMOV[x].dtgEmpresas[9,y].Value.ToString();
							this.ExcelApp.Cells[i,  8] 	= formPrincEmp.refMOV[x].dtgEmpresas[11,y].Value.ToString();
							this.ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							this.ExcelApp.Cells[i,  10] 	= formPrincEmp.refMOV[x].dtgEmpresas[13,y].Value.ToString();
							this.ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()!="" && formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()!="")
						{
							this.ExcelApp.Cells[i,  1] 	= "0";
							this.ExcelApp.Cells[i,  2] 	= " ";
							this.ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							this.ExcelApp.Cells[i,  4] 	= " ";
							this.ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							this.ExcelApp.Cells[i,  6] 	= " ";
							this.ExcelApp.Cells[i,  7] 	= "0";
							this.ExcelApp.Cells[i,  8] 	= " ";
							this.ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							this.ExcelApp.Cells[i,  10] 	= " ";
							this.ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString()!="")
						{
							this.ExcelApp.Cells[i,  1] 	= "0";
							this.ExcelApp.Cells[i,  2] 	= " ";
							this.ExcelApp.Cells[i,  3] 	= formPrincEmp.refMOV[x].dtgEmpresas[4,y].Value.ToString();
							this.ExcelApp.Cells[i,  4] 	= " ";
							this.ExcelApp.Cells[i,  5] 	= formPrincEmp.refMOV[x].dtgEmpresas[6,y].Value.ToString();
							this.ExcelApp.Cells[i,  6] 	= " ";
						}
						else if(formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString()!="")
						{
							this.ExcelApp.Cells[i,  7] 	= "0";
							this.ExcelApp.Cells[i,  8] 	= " ";
							this.ExcelApp.Cells[i,  9] 	= formPrincEmp.refMOV[x].dtgEmpresas[12,y].Value.ToString();
							this.ExcelApp.Cells[i,  10] 	= " ";
							this.ExcelApp.Cells[i,  11] 	= formPrincEmp.refMOV[x].dtgEmpresas[14,y].Value.ToString();
						}
					}
				}
			}
			SavedialogExcel("Despacho "+"("+formPrincEmp.lblTurno.Text+") "+formPrincEmp.lblDia.Text.Substring(0,2)+"-"+formPrincEmp.lblDia.Text.Substring(3,2)+"-"+formPrincEmp.lblDia.Text.Substring(6,4));
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTES DE VENTAS
		public void ReporteVentas1(DataGridView dataViajesEspeciales)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  2] = "NOMBRE";
			this.ExcelApp.Cells[1,  3] = "CARRO";
			this.ExcelApp.Cells[1,  4] = "DESTINO";
			this.ExcelApp.Cells[1,  5] = "IMPORTE";
			this.ExcelApp.Cells[1,  6] = "FECHA";
			this.ExcelApp.Cells[1,  7] = "FACTURA";
			this.ExcelApp.Cells[1,  8] = "DOMICILIO";
			this.ExcelApp.Cells[1,  9] = "OBSERVACIONES";
			this.ExcelApp.Cells[1,  10] = "ID_SERVICIO";
			this.ExcelApp.Cells[1,  11] = "SENTIDO";
			for (int i = 0; i < dataViajesEspeciales.Rows.Count; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					if(dataViajesEspeciales.Rows[i].Cells[j].Value.ToString().Equals(""))
					{
						if(j!=0 && j!=4)
							this.ExcelApp.Cells[i + 1, j + 1]="";
					}
					else
					{
						if(j==0)
							this.ExcelApp.Cells[i + 2, 10] = dataViajesEspeciales.Rows[i].Cells[0].Value.ToString();	
						else if(j>=4)
						{
							this.ExcelApp.Cells[i + 2, 11] = dataViajesEspeciales.Rows[i].Cells[4].Value.ToString();	
							this.ExcelApp.Cells[i + 2, j + 1] = dataViajesEspeciales.Rows[i].Cells[j+1].Value.ToString();
						}
						else if(j!=0)
							this.ExcelApp.Cells[i + 2, j + 1] = dataViajesEspeciales.Rows[i].Cells[j].Value.ToString();	
					}
				}
			}
			SavedialogExcel("Reporte VENTAS 1 "+DateTime.Now.ToString("dd-MM-yyyy"));
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		
		public void ReporteVentas2(DataGridView dataViajesEspeciales2)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  1] = "NOMBRE";
			this.ExcelApp.Cells[1,  2] = "CARRO";
			this.ExcelApp.Cells[1,  3] = "DESTINO";
			this.ExcelApp.Cells[1,  4] = "IMPORTE";
			this.ExcelApp.Cells[1,  5] = "FECHA";
			this.ExcelApp.Cells[1,  6] = "FACTURA";
			for (int i = 0; i < dataViajesEspeciales2.Rows.Count; i++)
			{
				for (int j = 0; j <dataViajesEspeciales2.Columns.Count; j++)
				{
					if(dataViajesEspeciales2.Rows[i].Cells[j].Value==null)
						this.ExcelApp.Cells[i + 2, j + 1]="";
					else
						this.ExcelApp.Cells[i + 2, j + 1] = dataViajesEspeciales2.Rows[i].Cells[j].Value.ToString();
				}
			}
			SavedialogExcel("Reporte VENTAS 2 "+DateTime.Now.ToString("dd-MM-yyyy"));
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE BONIFICACIONES
		public void ReporteBonificaciones(Interfaz.FormPrincipal principal)
		{
			this.principal=principal;
			try{
			int cell = 1;	 
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  1] = "Alias";
			this.ExcelApp.Cells[1,  2] = "Nombre";
			this.ExcelApp.Cells[1,  3] = "Apellido_pat";
			this.ExcelApp.Cells[1,  4] = "Apellido_mat";
			this.ExcelApp.Cells[1,  5] = "TIPO";
			this.ExcelApp.Cells[1,  6] = "Motivo";
			this.ExcelApp.Cells[1,  7] = "usuario";
			this.ExcelApp.Cells[1,  8] = "Fecha";
			
			conn.getAbrirConexion("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, H.TIPO, H.Motivo, U.usuario, P.Fecha " +
                                  "from NUEVO_HISTORIAL_BONO_OPERADOR h, OPERADOR O, USUARIO U, PERDIDA_BONO P " +
                                  "WHERE U.ID_usuario=H.iD_USUARIO AND O.ID=H.ID_O AND H.ID=P.Id_Historial ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				this.ExcelApp.Cells[cell + 1, 1] = conn.leer["Alias"].ToString();
				this.ExcelApp.Cells[cell + 1, 2] = conn.leer["Nombre"].ToString();
				this.ExcelApp.Cells[cell + 1, 3] = conn.leer["Apellido_pat"].ToString();
				this.ExcelApp.Cells[cell + 1, 4] = conn.leer["Apellido_pat"].ToString();
				this.ExcelApp.Cells[cell + 1, 5] = conn.leer["TIPO"].ToString();
				this.ExcelApp.Cells[cell + 1, 6] = conn.leer["Motivo"].ToString();
				this.ExcelApp.Cells[cell + 1, 7] = conn.leer["usuario"].ToString();
				this.ExcelApp.Cells[cell + 1, 8] = conn.leer["Fecha"].ToString();
				cell = cell +1;
			}
			conn.conexion.Close();
			SavedialogExcel("Reporte Bonificaciones.xlsx");
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE NOMINAL FISCAL
		public void ReporteNominalFiscal(Interfaz.FormPrincipal principal, int var, String[,] Hoja)
		{
			this.principal=principal;
			int cont = 2;
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  1] = "NOMBRE";
			this.ExcelApp.Cells[1,  2] = "SUELDO";
			this.ExcelApp.Cells[1,  3] = "DIAS LABORADOS";
			this.ExcelApp.Cells[1,  4] = "SUELDO QUINCENAL";
			this.ExcelApp.Cells[1,  5] = "PREMIO DE ASISTENCIA";
			this.ExcelApp.Cells[1,  6] = "PREMIO DE PUNTUALIDAD";
			this.ExcelApp.Cells[1,  7] = "DESPENSA";
			this.ExcelApp.Cells[1,  8] = "SUBSIDIO PARA EL EMPLEO";
			this.ExcelApp.Cells[1,  9] = "TOTAL DE PERCEPCIONES";
			this.ExcelApp.Cells[1,  10] = "IMSS";
			this.ExcelApp.Cells[1,  11] = "INFONAVIT";
			this.ExcelApp.Cells[1,  12] = "ISR";
			this.ExcelApp.Cells[1,  13] = "TOTAL RETENCIONES";
			this.ExcelApp.Cells[1,  14] = "SUELDO NETO";
			this.ExcelApp.Cells[1,  15] = "PATRON";
			
			for (int i = 0; i < var; i++)
			{
				this.ExcelApp.Cells[cont,  1] = Hoja[i,0];
				this.ExcelApp.Cells[cont,  2] = Hoja[i,1];
				this.ExcelApp.Cells[cont,  3] = Hoja[i,2];
				this.ExcelApp.Cells[cont,  4] = Hoja[i,3];
				this.ExcelApp.Cells[cont,  5] = Hoja[i,4];
				this.ExcelApp.Cells[cont,  6] = Hoja[i,5];
				this.ExcelApp.Cells[cont,  7] = Hoja[i,6];
				this.ExcelApp.Cells[cont,  8] = Hoja[i,7];
				this.ExcelApp.Cells[cont,  9] = Hoja[i,8];
				this.ExcelApp.Cells[cont,  10] = Hoja[i,9];
				this.ExcelApp.Cells[cont,  11] = Hoja[i,10];
				this.ExcelApp.Cells[cont,  12] = Hoja[i,11];
				this.ExcelApp.Cells[cont,  13] = Hoja[i,12];
				this.ExcelApp.Cells[cont,  14] = Hoja[i,13];
				this.ExcelApp.Cells[cont,  15] = Hoja[i,14];
				cont = cont + 1;
			}
			
			SavedialogExcel("Reporte Nominal Fiscal.xlsx");
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE BANCO
		public void ReporteNominalFiscal(Interfaz.FormPrincipal principal, int var, String[,] Hoja, String Alias)
		{
			this.principal=principal;
			int cont = 2;
			double Sueldo_Fiscal = 0.0;;
			double Sueldo_real = 0.0;
			
			try{ 
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  1] = "UNIDAD";
			this.ExcelApp.Cells[1,  2] = "NICK";
			this.ExcelApp.Cells[1,  3] = "NOMBRE";
			this.ExcelApp.Cells[1,  4] = "TOTAL NOMINA";
			this.ExcelApp.Cells[1,  5] = "EFECTIVO";
			this.ExcelApp.Cells[1,  6] = "TOTAL NOMINA REAL";
			this.ExcelApp.Cells[1,  7] = "NOMINA FISCAL";
			this.ExcelApp.Cells[1,  8] = "DIFERENCIA";
			this.ExcelApp.Cells[1,  9] = "CUENTA";
			this.ExcelApp.Cells[1,  10] = "PATRON";
			
			for (int i = 0; i < var; i++)
			{
				this.ExcelApp.Cells[cont,  1] = Hoja[i,16];
				this.ExcelApp.Cells[cont,  2] = Hoja[i,15];
				this.ExcelApp.Cells[cont,  3] = Hoja[i,0];
				Sueldo_real = (Convert.ToDouble(Hoja[i,18]));
				this.ExcelApp.Cells[cont,  4] = ((Math.Round(Sueldo_real))).ToString("C");
				this.ExcelApp.Cells[cont,  5] = "";
				this.ExcelApp.Cells[cont,  6] = (Convert.ToDouble(Hoja[i,17])).ToString("C");
				Sueldo_Fiscal = (Convert.ToDouble(Hoja[i,13]));
				this.ExcelApp.Cells[cont,  7] = (Sueldo_Fiscal).ToString("C");
				this.ExcelApp.Cells[cont,  8] = (Sueldo_real - Sueldo_Fiscal).ToString("C");
				this.ExcelApp.Cells[cont,  9] = Hoja[i,19];
				this.ExcelApp.Cells[cont,  10] = Hoja[i,14];
				cont = cont + 1;
			}
			
			SavedialogExcel("Reporte Resumen Nominal.xlsx");
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE PLEXUS
		public void ReportePlexus(DataGridView dataReporteDirectivo, String Empresa)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "TIPO";
			this.ExcelApp.Cells[1,  2] = "FECHA";
			this.ExcelApp.Cells[1,  3] = "EMPRESA";
			this.ExcelApp.Cells[1,  4] = "RUTA";
			this.ExcelApp.Cells[1,  5] = "SENTIDO";
			this.ExcelApp.Cells[1,  6] = "TURNO";
			this.ExcelApp.Cells[1,  7] = "VEHICULO";
			this.ExcelApp.Cells[1,  8] = "TIPO_RUTA";
			this.ExcelApp.Cells[1,  9] = "ORDEN";
			this.ExcelApp.Cells[1,  10] = "VELADA";
			this.ExcelApp.Cells[1,  11] = "HORA";
			this.ExcelApp.Cells[1,  12] = "KM";
			this.ExcelApp.Cells[1,  13] = "FORANEO";
			this.ExcelApp.Cells[1,  14] = "IMPORTE";
			this.ExcelApp.Cells[1,  15] = "SEMANA";
							
			for(int x=0; x<dataReporteDirectivo.Rows.Count; x++)
				{
					this.ExcelApp.Cells[x + 2, 1] = dataReporteDirectivo.Rows[x].Cells[0].Value;
					this.ExcelApp.Cells[x + 2, 2] = dataReporteDirectivo.Rows[x].Cells[1].Value;
					this.ExcelApp.Cells[x + 2, 3] = dataReporteDirectivo.Rows[x].Cells[2].Value;
					this.ExcelApp.Cells[x + 2, 4] = dataReporteDirectivo.Rows[x].Cells[4].Value;
					this.ExcelApp.Cells[x + 2, 5] = dataReporteDirectivo.Rows[x].Cells[5].Value;
					this.ExcelApp.Cells[x + 2, 6] = dataReporteDirectivo.Rows[x].Cells[6].Value;
					this.ExcelApp.Cells[x + 2, 7] = dataReporteDirectivo.Rows[x].Cells[7].Value;
					this.ExcelApp.Cells[x + 2, 8] = dataReporteDirectivo.Rows[x].Cells[9].Value;
					this.ExcelApp.Cells[x + 2, 9] = dataReporteDirectivo.Rows[x].Cells[11].Value;
					this.ExcelApp.Cells[x + 2, 10] = dataReporteDirectivo.Rows[x].Cells[12].Value;
					this.ExcelApp.Cells[x + 2, 11] = dataReporteDirectivo.Rows[x].Cells[13].Value;
					this.ExcelApp.Cells[x + 2, 12] = dataReporteDirectivo.Rows[x].Cells[14].Value;
					this.ExcelApp.Cells[x + 2, 13] = dataReporteDirectivo.Rows[x].Cells[15].Value;
					this.ExcelApp.Cells[x + 2, 14] = dataReporteDirectivo.Rows[x].Cells[10].Value;
					this.ExcelApp.Cells[x + 2, 15] = dataReporteDirectivo.Rows[x].Cells[16].Value;
					//progresobarra(dataReporteDirectivo.Rows.Count);
				}
				SavedialogExcel("Reporte "+Empresa);
				//principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;				
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE ASIGNACION - UNIDAD
		public void ReporteO_V(DataGridView dataReporteDirectivo, DataGridView datacamion, DataGridView dataCamioneta, DataGridView dataUtilitario, DataGridView dataOperador)
		{
			try{
				this.ExcelApp = new nmExcel.ApplicationClass();				
				this.ExcelApp.Application.Workbooks.Add(Type.Missing);
				this.ExcelApp.Columns.ColumnWidth = 20;
				
				nmExcel.Worksheet newWorksheet;
				newWorksheet = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				newWorksheet.Name = "Camión Sin Asignar";
				nmExcel.Range cells =  newWorksheet.Cells;
					
				cells[1,  1] = "NUMERO";
				cells[1,  2] = "MARCA";
				for(int x=0; x<datacamion.Rows.Count; x++)
				{
					cells[x + 2, 1] = datacamion.Rows[x].Cells[1].Value;
					cells[x + 2, 2] = datacamion.Rows[x].Cells[2].Value;
				}
				
				nmExcel.Worksheet newWorksheet2 = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				newWorksheet2.Name = "Camioneta Sin Asignar";
				nmExcel.Range cells2 =  newWorksheet2.Cells;
					
				cells2[1,  1] = "NUMERO";
				cells2[1,  2] = "MARCA";
				for(int x=0; x<dataCamioneta.Rows.Count; x++)
				{
					cells2[x + 2, 1] = dataCamioneta.Rows[x].Cells[1].Value;
					cells2[x + 2, 2] = dataCamioneta.Rows[x].Cells[2].Value;
				}
				
				nmExcel.Worksheet newWorksheet3 = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				newWorksheet3.Name = "Utilitarios Sin Asignar";
				nmExcel.Range cells3 =  newWorksheet3.Cells;
					
				cells3[1,  1] = "NUMERO";
				cells3[1,  2] = "MARCA";
				for(int x=0; x<dataUtilitario.Rows.Count; x++)
				{
					cells3[x + 2, 1] = dataUtilitario.Rows[x].Cells[1].Value;
					cells3[x + 2, 2] = dataUtilitario.Rows[x].Cells[2].Value;
				}
				
				nmExcel.Worksheet newWorksheet4 = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				newWorksheet4.Name = "Operadores Sin Asignar";
				nmExcel.Range cells4 =  newWorksheet4.Cells;
					
				cells4[1,  1] = "TIPO";
				cells4[1,  2] = "USUARIO";
				for(int x=0; x<dataOperador.Rows.Count; x++)
				{
					cells4[x + 2, 1] = dataOperador.Rows[x].Cells[1].Value;
					cells4[x + 2, 2] = dataOperador.Rows[x].Cells[2].Value;
				}
				
				nmExcel.Worksheet newWorksheet5 = (nmExcel.Worksheet)ExcelApp.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				newWorksheet5.Name = "Vehiculo-Operador Asignados";
				nmExcel.Range cells5 =  newWorksheet5.Cells;
					
				cells5[1,  1] = "ALIAS";
				cells5[1,  2] = "NUMERO";
				cells5[1,  3] = "ESTATUS";
				cells5[1,  4] = "MARCA";
								
				for(int x=0; x<dataReporteDirectivo.Rows.Count; x++)
				{
					cells5[x + 2, 1] = dataReporteDirectivo.Rows[x].Cells[2].Value;
					cells5[x + 2, 2] = dataReporteDirectivo.Rows[x].Cells[3].Value;
					cells5[x + 2, 3] = dataReporteDirectivo.Rows[x].Cells[4].Value;
					cells5[x + 2, 4] = dataReporteDirectivo.Rows[x].Cells[5].Value;
				}
				//((nmExcel.Worksheet)ExcelApp.ActiveWorkbook.Sheets[1]).Activate();
				SavedialogExcel("Reporte Asignación operador - Vehiculo "+DateTime.Now.ToString("dd-MM-yyyy"));
				MessageBox.Show("Se creo el reporte correctamente ", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}catch(Exception ex){
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}finally{
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region REPORTE HORARIOS(ENTRADA-SALIDA)
		public void ReporteLLEGADA_SALIDA(DataGridView dgHorario)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			/*
			this.ExcelApp.Cells[1,  1] = "ID";
			this.ExcelApp.Cells[1,  2] = "USUARIO";
			this.ExcelApp.Cells[1,  3] = "TIPO";
			this.ExcelApp.Cells[1,  4] = "HORA ENTRADA";
			this.ExcelApp.Cells[1,  5] = "TIPO";
			this.ExcelApp.Cells[1,  6] = "HORA SALIDA";
			this.ExcelApp.Cells[1,  7] = "HORARIO";
			this.ExcelApp.Cells[1,  8] = "RETARDO O SALIDA PREMATURA";
			this.ExcelApp.Cells[1,  9] = "FECHA";
			*/
			
			this.ExcelApp.Cells[1,  1] = "USUARIO";
			this.ExcelApp.Cells[1,  2] = "TIPO";
			this.ExcelApp.Cells[1,  3] = "HORA ENTRADA";
			this.ExcelApp.Cells[1,  4] = "TIPO";
			this.ExcelApp.Cells[1,  5] = "HORA SALIDA";			
			this.ExcelApp.Cells[1,  6] = "I ENTRADA";
			this.ExcelApp.Cells[1,  7] = "I SALIDA";
			this.ExcelApp.Cells[1,  8] = "RETARDO ENTRADA";
			this.ExcelApp.Cells[1,  9] = "EXTRA SALIDA";
			this.ExcelApp.Cells[1,  10] = "FECHA";
							
			for(int x=0; x<dgHorario.Rows.Count; x++)
			{
				this.ExcelApp.Cells[x + 2, 1] = dgHorario.Rows[x].Cells[1].Value;
				// HORAS				
				this.ExcelApp.Cells[x + 2, 2] = dgHorario.Rows[x].Cells[2].Value;				
				this.ExcelApp.Cells[x + 2, 3] = dgHorario.Rows[x].Cells[3].Value;
				this.ExcelApp.Cells[x + 2, 6] = dgHorario.Rows[x].Cells[4].Value;
				this.ExcelApp.Cells[x + 2, 8] = dgHorario.Rows[x].Cells[5].Value.ToString();
				for(int y=x+1; y<dgHorario.Rows.Count; y++)
				{
					if(dgHorario.Rows[x].Cells[1].Value.ToString() ==  dgHorario.Rows[y].Cells[1].Value.ToString() &&	dgHorario.Rows[x].Cells[2].Value.ToString() != dgHorario.Rows[y].Cells[2].Value.ToString() &&  dgHorario.Rows[x].Cells[6].Value.ToString() ==  dgHorario.Rows[y].Cells[6].Value.ToString())
					{
						this.ExcelApp.Cells[x + 2, 4] = dgHorario.Rows[y].Cells[2].Value;
						this.ExcelApp.Cells[x + 2, 5] = dgHorario.Rows[y].Cells[3].Value;	
						this.ExcelApp.Cells[x + 2, 7] = dgHorario.Rows[y].Cells[4].Value;	
						this.ExcelApp.Cells[x + 2, 9] = dgHorario.Rows[y].Cells[5].Value.ToString();
						dgHorario.Rows.RemoveAt(y);						
					}else{
						//this.ExcelApp.Cells[x + 2, 4] = "SALIDA";
						//this.ExcelApp.Cells[x + 2, 5] = "NO HAY REGISTRO";	
						//this.ExcelApp.Cells[x + 2, 7] = " - ";	
						//this.ExcelApp.Cells[x + 2, 9] = "NO HAY REGISTRO";	
					}
				}
				//				
				this.ExcelApp.Cells[x + 2, 10] = dgHorario.Rows[x].Cells[6].Value.ToString();
			}
			SavedialogExcel("Reporte ENTRADAS - SALIDAS "+DateTime.Now.ToString("dd-MM-yyyy"));			
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}		
		
		/*
		 public void ReporteLLEGADA_SALIDA(DataGridView dgHorario)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "ID";
			this.ExcelApp.Cells[1,  2] = "USUARIO";
			this.ExcelApp.Cells[1,  3] = "TIPO";
			this.ExcelApp.Cells[1,  4] = "HORA";
			this.ExcelApp.Cells[1,  5] = "HORARIO";
			this.ExcelApp.Cells[1,  6] = "RETARDO O SALIDA PREMATURA";
			this.ExcelApp.Cells[1,  7] = "FECHA";
							
			for(int x=0; x<dgHorario.Rows.Count; x++)
			{
				this.ExcelApp.Cells[x + 2, 1] = dgHorario.Rows[x].Cells[0].Value;
				this.ExcelApp.Cells[x + 2, 2] = dgHorario.Rows[x].Cells[1].Value;
				this.ExcelApp.Cells[x + 2, 3] = dgHorario.Rows[x].Cells[2].Value;
				this.ExcelApp.Cells[x + 2, 4] = dgHorario.Rows[x].Cells[3].Value;
				this.ExcelApp.Cells[x + 2, 5] = dgHorario.Rows[x].Cells[4].Value;
				this.ExcelApp.Cells[x + 2, 6] = dgHorario.Rows[x].Cells[5].Value.ToString();
				this.ExcelApp.Cells[x + 2, 7] = dgHorario.Rows[x].Cells[6].Value.ToString();
			}
			SavedialogExcel("Reporte ENTRADAS - SALIDAS "+DateTime.Now.ToString("dd-MM-yyyy"));			
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		
		  */
		#endregion
		
		#region TABULAR DE HORARIOS
		public void ReporteHORARIO(DataGridView dgInicio)
		{
			try{
			this.ExcelApp = new nmExcel.ApplicationClass();				
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			
			this.ExcelApp.Cells[1,  1] = "USUARIO";
			this.ExcelApp.Cells[1,  2] = "NOMBRE";
			this.ExcelApp.Cells[1,  3] = "LUNES";
			this.ExcelApp.Cells[1,  4] = "MARTES";
			this.ExcelApp.Cells[1,  5] = "MIERCOLES";
			this.ExcelApp.Cells[1,  6] = "JUEVES";
			this.ExcelApp.Cells[1,  7] = "VIERNES";
			this.ExcelApp.Cells[1,  8] = "SABADO";
			this.ExcelApp.Cells[1,  9] = "DOMINGO";
			
			for(int x=0; x<dgInicio.Rows.Count; x++)
				{
					this.ExcelApp.Cells[x + 2, 1] = dgInicio.Rows[x].Cells[1].Value;
					this.ExcelApp.Cells[x + 2, 2] = dgInicio.Rows[x].Cells[2].Value;
					this.ExcelApp.Cells[x + 2, 3] = dgInicio.Rows[x].Cells[4].Value;
					this.ExcelApp.Cells[x + 2, 4] = dgInicio.Rows[x].Cells[5].Value;
					this.ExcelApp.Cells[x + 2, 5] = dgInicio.Rows[x].Cells[6].Value;
					this.ExcelApp.Cells[x + 2, 6] = dgInicio.Rows[x].Cells[7].Value;
					this.ExcelApp.Cells[x + 2, 7] = dgInicio.Rows[x].Cells[8].Value;
					this.ExcelApp.Cells[x + 2, 8] = dgInicio.Rows[x].Cells[9].Value;
					this.ExcelApp.Cells[x + 2, 9] = dgInicio.Rows[x].Cells[10].Value;
					//progresobarra(dataReporteDirectivo.Rows.Count);
				}
				SavedialogExcel("Reporte HORARIO "+DateTime.Now.ToString("dd-MM-yyyy"));
				//principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;				
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region DESCUENTO POR EMPRESAS
		public void ReporteDescEmpresas(Interfaz.FormPrincipal principal, String FECHAI, String FECHAC)
		{
			string consultas = "";
			this.principal=principal;
			try{
			int cell = 1;	 
			this.ExcelApp = new nmExcel.ApplicationClass();
			this.ExcelApp.Application.Workbooks.Add(Type.Missing);
			this.ExcelApp.Columns.ColumnWidth = 20;
			this.ExcelApp.Cells[1,  1] = "EMPRESA";
			this.ExcelApp.Cells[1,  2] = "OPERADOR";
			this.ExcelApp.Cells[1,  3] = "CANTIDAD";
			this.ExcelApp.Cells[1,  4] = "FIRMA";
			
			consultas = "select O.Alias, E.EMPRESA, D.IMPORTE_TOTAL "+
		                               "from DESCUENTO D, DESCUENTO_DETALLE DT, DESCUENTO_EMPRESA E, OPERADOR O "+
		                               "where D.ID=DT.ID_DESCUENTO AND D.ID=E.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
		                               "and FLUJO!='3' and FLUJO!='5' and DT.fecha between '"+FECHAI+"' AND '"+FECHAC+"'" +
		                               "and O.Estatus='1' AND O.tipo_empleado='OPERADOR' and O.Alias!='Admvo' ";
			conn.getAbrirConexion(consultas);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				this.ExcelApp.Cells[cell + 1, 1] = conn.leer["EMPRESA"].ToString();
				this.ExcelApp.Cells[cell + 1, 2] = conn.leer["Alias"].ToString();
				this.ExcelApp.Cells[cell + 1, 3] = conn.leer["IMPORTE_TOTAL"].ToString();
				cell = cell +1;
			}
			conn.conexion.Close();
			SavedialogExcel("DESCUENTO PARA LAS EMPRESAS.xlsx");
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
			}
			catch(Exception ex)
			{
				MessageBox.Show("ERROR "+ex, "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				
				LiberaCOM(this.ExcelApp);
			}
		}
		#endregion
		
		#region PROGRESSBAR
		void progresobarra(int x)
		{
			principal.progressbarPrin.Minimum = 1;
    		principal.progressbarPrin.Maximum = 100;
    		int variable;
    		
			variable = (x/100);
		
			++acumulador;
			
			if(acumulador==variable && progreso<101)
			{
				principal.progressbarPrin.Increment(progreso);
		    	principal.progressbarPrin.Value=progreso;
		    	progreso = progreso + 1;
		    	acumulador = 0;
			}
		}
		#endregion
		
	}
}
