using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class ReportesPrivilegiosPagos : Form
	{
		#region CONSTRUCTOR
		public ReportesPrivilegiosPagos(PrivilegiosPagos refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}		
		#endregion
			
		#region INSTANCIAS
		PrivilegiosPagos refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN		
		void ReportesPrivilegiosPagosLoad(object sender, EventArgs e)
		{
			
		}
		#endregion
				
		#region METODOS		
		private	void exportaExcelOperador()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "COBRO";
			ExcelApp.Cells[i,  3] 	= "OPERADOR";
			ExcelApp.Cells[i,  4] 	= "UNIDAD";
			ExcelApp.Cells[i,  5] 	= "CELULAR";
			ExcelApp.Cells[i,  6] 	= "TOTAL";				
			ExcelApp.Cells[i,  7] 	= "ANTICIPOS";
			ExcelApp.Cells[i,  8] 	= "SALDO";				
			ExcelApp.Cells[i,  9] 	= "DESTINO";
			ExcelApp.Cells[i,  10] 	= "AGENCIA";
			ExcelApp.Cells[i,  11] 	= "FECHA";
			ExcelApp.Cells[i,  12] 	= "OBSERVACIONES";
			ExcelApp.Cells[i,  13] 	= "FACTURA";
			
			string consulta = @"select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA,
								C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, 
								RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID = C.ID_OP AND C.ID_VEHICULO = V.ID 
							AND C.ID_RE =RE.ID_RE and C.ESTATUS='1' AND C.PAGO = '0' AND C.BORRADO = '0' and (c.TIPO = 'OPERADOR' OR C.TIPO = 'COORDINADOR')";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;					
				ExcelApp.Cells[i,  1]	= conn.leer["ID_RE"].ToString();				
				ExcelApp.Cells[i,  2]	= conn.leer["COBRO"].ToString();				
				ExcelApp.Cells[i,  3]	= conn.leer["Alias"].ToString();
				ExcelApp.Cells[i,  4]	= conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  5]	= conn.leer["TELEFONO"].ToString();
				ExcelApp.Cells[i,  6]	= conn.leer["SALDO"].ToString();
				ExcelApp.Cells[i,  7]	= "";
				ExcelApp.Cells[i,  8]	= conn.leer["SALDO"].ToString();
				ExcelApp.Cells[i,  9]	= conn.leer["DESTINO"].ToString();
				ExcelApp.Cells[i,  10]	= conn.leer["FACTURA"].ToString();
				ExcelApp.Cells[i,  11]	= conn.leer["FECHA_SALIDA"].ToString();
				ExcelApp.Cells[i,  12]	= conn.leer["OBSERVACIONES"].ToString();
				ExcelApp.Cells[i,  13]	= conn.leer["NUMERO_FACT"].ToString();				
			}
			conn.conexion.Close();
			/*
			consulta = @"select SUM(CANTIDAD) AS ANTICIPO from ANTICIPOS_ESPECIALES where ID_RE =  "+ExcelApp.Cells[i, 1].ToString();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){			
				ExcelApp.Cells[i,  7]	= conn.leer["ANTICIPO"].ToString();			
			}else{				
				ExcelApp.Cells[i,  7]	= "0";		
			}
			conn.conexion.Close();
			*/
			// ---------- cuadro de dialogo para Guardar
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Cobro de servicios al Operador "+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
		private	void exportaExcelAdeudos()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "TIPO COBRO";			
			ExcelApp.Cells[i,  3] 	= "CLIENTE";
			ExcelApp.Cells[i,  4] 	= "CONTACTO";
			ExcelApp.Cells[i,  5] 	= "TELEFONO";
			ExcelApp.Cells[i,  6] 	= "EXTENSION";
			ExcelApp.Cells[i,  7] 	= "DESTINO";
			ExcelApp.Cells[i,  8] 	= "FECHA SALIDA";
			ExcelApp.Cells[i,  9] 	= "C/U";				
			ExcelApp.Cells[i,  10] 	= "FACTURA";
			ExcelApp.Cells[i,  11] 	= "PRECIO COTIZADO";				
			ExcelApp.Cells[i,  12] 	= "PRECIO A COBRAR";
			ExcelApp.Cells[i,  13] 	= "ANTICIPOS DEPOSITO";
			ExcelApp.Cells[i,  14] 	= "ANTICIPOS EFECTIVO";
			ExcelApp.Cells[i,  15] 	= "SALDO PENDIENTE POR COBRAR";
			
			for(int y = 0; y < refPrincipal.dgRelacion.Rows.Count; y++){
				++i;					
				ExcelApp.Cells[i,  1]	= refPrincipal.dgRelacion[0,y].Value.ToString();
				ExcelApp.Cells[i,  2]	= refPrincipal.dgRelacion[2,y].Value.ToString();
				ExcelApp.Cells[i,  3]	= refPrincipal.dgRelacion[4,y].Value.ToString();				
				ExcelApp.Cells[i,  4]	= refPrincipal.dgRelacion[3,y].Value.ToString();
			
				String consulta="SELECT Nombre, Telefono, Extension FROM ContactoServicio WHERE IdCliente = "+refPrincipal.dgRelacion[1,y].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read()){
					ExcelApp.Cells[i,  5]	= conn.leer["Telefono"].ToString();	
					ExcelApp.Cells[i,  6]	= conn.leer["Extension"].ToString();						
				}
				conn.conexion.Close();
											
				ExcelApp.Cells[i,  7]	= refPrincipal.dgRelacion[5,y].Value.ToString();
				ExcelApp.Cells[i,  8]	= refPrincipal.dgRelacion[6,y].Value.ToString();			
				ExcelApp.Cells[i,  9]	= refPrincipal.dgRelacion[8,y].Value.ToString();				
				ExcelApp.Cells[i,  10]	= refPrincipal.dgRelacion[10,y].Value.ToString();
				ExcelApp.Cells[i,  11]	= refPrincipal.dgRelacion[9,y].Value.ToString();				
				ExcelApp.Cells[i,  12]	= refPrincipal.dgRelacion[12,y].Value.ToString();
				ExcelApp.Cells[i,  13]	= refPrincipal.dgRelacion[13,y].Value.ToString();
				ExcelApp.Cells[i,  14]	= refPrincipal.dgRelacion[14,y].Value.ToString();
				ExcelApp.Cells[i,  15]	= refPrincipal.dgRelacion[15,y].Value.ToString();
			}
			
			
			// ---------- cuadro de dialogo para Guardar
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Cobro de servicios "+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}else{
				MessageBox.Show("No Genero el Reporte ... ");
			}			
		}
		
		private void exportarExcelCompleto(){
			
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			ExcelApp.Cells[i,  1] = "ID_RE";
			ExcelApp.Cells[i,  2] = "TIPO COBRO";
			ExcelApp.Cells[i,  3] = "CONTACTO";
			ExcelApp.Cells[i,  4] = "CLIENTE";
			ExcelApp.Cells[i,  5] = "DESTINO";
			ExcelApp.Cells[i,  6] = "FECHA SALIDA";
			ExcelApp.Cells[i,  7] = "FECHA REGRESO";
			ExcelApp.Cells[i,  8] = "FACTURA";
			ExcelApp.Cells[i,  9] = "RAZON SOCIAL";
			ExcelApp.Cells[i,  10] = "CANTIDAD UNIDADES";
			ExcelApp.Cells[i,  11] = "PRECIO COTIZADO";
			ExcelApp.Cells[i,  12] = "PRECIO A PAGAR";
			ExcelApp.Cells[i,  13] = "ANTICIPO DEPOSITO";			
			ExcelApp.Cells[i,  14] = "ANTICIPO EFECTIVO";
			ExcelApp.Cells[i,  15] = "SALDO";
			
			for(int x=0; x<refPrincipal.dgRelacion.Rows.Count; x++){
				++i;		
				try{ExcelApp.Cells[i,  1] = refPrincipal.dgRelacion[0,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  1] = "";}
				try{ExcelApp.Cells[i,  2] = refPrincipal.dgRelacion[2,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  3] = refPrincipal.dgRelacion[3,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  3] = "";}
				try{ExcelApp.Cells[i,  4] = refPrincipal.dgRelacion[4,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  4] = "";}
				try{ExcelApp.Cells[i,  5] = refPrincipal.dgRelacion[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  5] = "";}
				try{ExcelApp.Cells[i,  6] = refPrincipal.dgRelacion[6,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
				try{ExcelApp.Cells[i,  7] = refPrincipal.dgRelacion[7,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  7] = "";}
				try{ExcelApp.Cells[i,  8] = refPrincipal.dgRelacion[16,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  8] = "";}
				try{ExcelApp.Cells[i,  9] = refPrincipal.dgRelacion[11,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  9] = "";}
				try{ExcelApp.Cells[i,  10] = refPrincipal.dgRelacion[8,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 10 ] = "";}				
				try{ExcelApp.Cells[i,  11] = refPrincipal.dgRelacion[9,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i, 6 ] = "";}
				try{ExcelApp.Cells[i,  12] = refPrincipal.dgRelacion[12,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}				
				try{ExcelApp.Cells[i,  13] = refPrincipal.dgRelacion[13,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}
				try{ExcelApp.Cells[i,  14] = refPrincipal.dgRelacion[14,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}
				try{ExcelApp.Cells[i,  15] = refPrincipal.dgRelacion[15,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  11] = "";}
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Cobro de servicios Completo "+DateTime.Now.ToString("dd-MM-yyyy");
			if (CuadroDialogo.ShowDialog() == DialogResult.OK){
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}else{
				MessageBox.Show("No Genero el Reporte ... ");
			}
		}
		#endregion	

		#region BOTONES
		void BtnOperadorClick(object sender, EventArgs e)
		{
			exportaExcelOperador();
		}
		
		void BtnAdeudoClick(object sender, EventArgs e)
		{
			exportaExcelAdeudos();
		}
		
		void BtnTablaClick(object sender, EventArgs e)
		{
			exportarExcelCompleto();
		}
		#endregion
		
		#region IMPRESION EXCEL
		/*
		
		void exportaExcel(){
			if(dgRelacion.Rows.Count>0){
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;					
				int i = 0;
				++i;
				ExcelApp.Cells[i,  1] 	= "ID_RE";
				ExcelApp.Cells[i,  2] 	= "COBRO";
				ExcelApp.Cells[i,  3] 	= "OPERADOR";
				ExcelApp.Cells[i,  4] 	= "UNIDAD";
				ExcelApp.Cells[i,  5] 	= "FIRMA";
				ExcelApp.Cells[i,  6] 	= "CELULAR";
				ExcelApp.Cells[i,  7] 	= "SALDO";				
				ExcelApp.Cells[i,  8] 	= "TOTAL";
				ExcelApp.Cells[i,  9] 	= "ANTICIPO";
				ExcelApp.Cells[i,  10] 	= "DESTINO";
				ExcelApp.Cells[i,  11] 	= "RAZON SOCIAL";
				ExcelApp.Cells[i,  12] 	= "FECHA";
				ExcelApp.Cells[i,  13] 	= "OBSERVACIONES";
				ExcelApp.Cells[i,  14] 	= "FACTURA";
				
				for(int y=0; y<dgRelacion.Rows.Count; y++){
					++i;					
					ExcelApp.Cells[i,  1]	= dgRelacion[0,y].Value.ToString();
					ExcelApp.Cells[i,  2]	= dgRelacion[1,y].Value.ToString();
					ExcelApp.Cells[i,  3]	= dgRelacion[2,y].Value.ToString();
					ExcelApp.Cells[i,  4]	= dgRelacion[3,y].Value.ToString();
					ExcelApp.Cells[i,  6]	= dgRelacion[4,y].Value.ToString();
					ExcelApp.Cells[i,  7]	= dgRelacion[5,y].Value.ToString();
					
					String consulta="SELECT * FROM RUTA_ESPECIAL WHERE ID_RE="+dgRelacion[0,y].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					int x=0;
					while(conn.leer.Read())
					{
						if(conn.leer["FACTURADO"].ToString()!="0")
						{
							ExcelApp.Cells[i,  8]	= Convert.ToDouble(conn.leer["CANT_UNIDADES"])*Convert.ToDouble(conn.leer["PRECIO"])*1.16;
							ExcelApp.Cells[i,  9]	= conn.leer["anticipo"].ToString();
						}
						else
						{
							ExcelApp.Cells[i,  8]	= Convert.ToDouble(conn.leer["CANT_UNIDADES"])*Convert.ToDouble(conn.leer["PRECIO"]);
							ExcelApp.Cells[i,  9]	= conn.leer["anticipo"].ToString();
						}
					}
					
					conn.conexion.Close();
					
					ExcelApp.Cells[i,  10]	= dgRelacion[6,y].Value.ToString();
					ExcelApp.Cells[i,  11]	= dgRelacion[7,y].Value.ToString();
					ExcelApp.Cells[i,  12]	= dgRelacion[8,y].Value.ToString();
					ExcelApp.Cells[i,  13]	= dgRelacion[18,y].Value.ToString();
					ExcelApp.Cells[i,  14]	= dgRelacion[9,y].Value.ToString();
				}
			
				// ---------- cuadro de dialogo para Guardar
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "Cobro de servicios "+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		}
		*/
		#endregion
	}
}
