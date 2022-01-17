using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormPagosUnidad : Form
	{
		public FormPagosUnidad()
		{
			InitializeComponent();
			
		}
	/*
	 * 
		int columnaselect = 1;		
		String consultaP = "";
		bool CONCATENA = false;
		String filtrado = " ";
		bool principal = false;
		
		#region METODOS
		public void getNodesFiltro(int columna)
		{
			tvFiltros.Nodes.Clear();
			tvFiltros.Nodes.Add(dgRelacion.Columns[columna].HeaderText);
			tvFiltros.Nodes[0].Checked=true;
			List<String> listaFiltrada = new List<String>();
			
			for(int x=0; x<dgRelacion.Rows.Count; x++)
			{
				int bandera=0;
				if(listaFiltrada.Count>0)
				{
					for(int y=0; y<listaFiltrada.Count; y++)
					{
						if(listaFiltrada[y].ToString()==dgRelacion[columna,x].Value.ToString())
						{
							bandera=1;
						}
					}
					if(bandera==0)
					{
						listaFiltrada.Add(dgRelacion[columna,x].Value.ToString());
					}
				}
				else
				{
					listaFiltrada.Add(dgRelacion[columna,x].Value.ToString());
				}
			}
			
			principal=true;
			for(int x=0; x<listaFiltrada.Count; x++)
			{
				tvFiltros.Nodes[0].Nodes.Add(listaFiltrada[x].ToString()).Checked=true;
			}
			principal=false;
			
			tvFiltros.Nodes[0].Expand();
		}		
		
		public void concatenado()
		{
			String dato="";
			bool Desvio = false;
			
			if(tvFiltros.Nodes[0].Text=="COBRO")
			{
				dato=" and C.COBRO ";
			}
			else if(tvFiltros.Nodes[0].Text=="UNID.")
			{
				dato=" and V.numero ";
			}
			else if(tvFiltros.Nodes[0].Text=="CELULAR")
			{
				dato=" and C.TELEFONO ";
			}
			else if(tvFiltros.Nodes[0].Text=="SALDO")
			{
				dato=" and C.SALDO ";
			}
			else if(tvFiltros.Nodes[0].Text=="DESTINO")
			{
				dato=" and RE.DESTINO ";
			}
			else if(tvFiltros.Nodes[0].Text=="AGENCIA")
			{
				dato=" and RE.FACTURA ";
			}
			else if(tvFiltros.Nodes[0].Text=="F. SALIDA")
			{
				dato=" and RE.FECHA_SALIDA ";
			}
			else if(tvFiltros.Nodes[0].Text=="F. VALIDACION")
			{
				dato=" and RE.FECHA_SALIDA ";
			}
			else if(tvFiltros.Nodes[0].Text=="ID")
			{
				dato=" and RE.ID_RE ";
			}
			else if(tvFiltros.Nodes[0].Text=="I")
			{
				dato=" and C.INCOBRABLE ";
			}
			else if(tvFiltros.Nodes[0].Text=="OP. COBRÓ")
			{
				dato=" and RE.OP_COBRA ";
				Desvio = true;
			}
			else if(tvFiltros.Nodes[0].Text=="OBSERVACIONES")
			{
				dato=" and C.OBSERVACIONES ";
			}
			else if(tvFiltros.Nodes[0].Text=="FACTURA")
			{
				dato=" and C.NUMERO_FACT ";
			}
			else if(tvFiltros.Nodes[0].Text=="OPERADOR")
			{
				dato=" and O.Alias ";
			}
			else if(tvFiltros.Nodes[0].Text=="NUMERO")
			{
				dato=" and C.IDENTIFICADOR ";
			}
			
			for(int x=0; x<tvFiltros.Nodes[0].Nodes.Count; x++)
			{
				if(tvFiltros.Nodes[0].Nodes[x].Checked==true)
				{
					if(Desvio==false)
					{
						filtrado = dato +"='"+ tvFiltros.Nodes[0].Nodes[x].Text +"' ";
					}
					else
					{
						filtrado = dato +"='"+((tvFiltros.Nodes[0].Nodes[x].Text=="SI")?"1":"0")+"' ";
					}
						consultaP = "select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' "+filtrado;
					
						if(cbPagados.Checked == false)
						{
							consultaP=consultaP+" and C.PAGO='0' ";
						}
						
						if(cbBorrados.Checked == false)
						{
							consultaP=consultaP+" and C.BORRADO='0' ";
						}
						getDatos2();
				}
			}
		}
		
		void DgRelacionMouseClick(object sender, MouseEventArgs e)
		{
			int y=0;
				double suma=0;
				
				for(int x=0; x<dgRelacion.Rows.Count; x++)
				{
					if(dgRelacion.Rows[x].Selected==true)
					{
						suma=suma+Convert.ToDouble(dgRelacion[5,x].Value);
						y++;
					}
				}
				
				txtCantidad.Text=y.ToString();
				txtTotal.Text=suma.ToString();
		}
		
		#endregion
		
		#region EVENTOS		
		void DgRelacionCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.RowIndex==-1 && e.ColumnIndex!=12 && e.ColumnIndex!=13 && e.ColumnIndex!=14 && e.ColumnIndex!=15)
			{
				if(e.Button == MouseButtons.Right)
				{
					getNodesFiltro(e.ColumnIndex);
					columnaselect=e.ColumnIndex;
				}
				
			}
			else if(e.Button == MouseButtons.Right  && e.RowIndex!=-1 && e.RowIndex<dgRelacion.Rows.Count && e.ColumnIndex==5)
			{
				bool entra = false;
				Int64 idSelect = 0;
				int vuelta = 0;
				int cant = 0;
				
				if(dgRelacion.SelectedRows.Count>0)
				{
					for(int x=0; x<dgRelacion.Rows.Count; x++)
					{
						if(dgRelacion.Rows[x].Selected==true)
						{
							cant++;
						}
						
						if(dgRelacion.Rows[x].Selected==true && dgRelacion.Rows[x+1].Selected==true)
						{
							vuelta++;
							if(vuelta>0 && dgRelacion[0,x].Value.ToString()!=dgRelacion[0,x+1].Value.ToString())
							{
								entra=true;
							}
						}
					}
				}
				
				if(entra==true)
				{
					MessageBox.Show("Seleccione registros del mismo servicio.");
				}
			}
		}
			
		void TxtBusquedaKeyUp(object sender, KeyEventArgs e)
		{
			if(txtBusqueda.Text=="")
			{
				getDatos();
				getNodesFiltro(columnaselect);
			}
			else
			{
				
				int columna = 0;
				for(int y=1; y<dgRelacion.Columns.Count; y++)
				{
					if(dgRelacion.Columns[y].HeaderText==tvFiltros.Nodes[0].Text)
					{
						columna=y;
					}
				}
				
				tvFiltros.Nodes[0].Nodes.Clear();
				
				List<String> listaFiltrada = new List<String>();
			
				for(int x=0; x<dgRelacion.Rows.Count; x++)
				{
					int bandera=0;
					if(listaFiltrada.Count>0)
					{
						for(int y=0; y<listaFiltrada.Count; y++)
						{
							if(listaFiltrada[y].ToString()==dgRelacion[columna,x].Value.ToString() && dgRelacion[columna,x].Value.ToString().Contains(txtBusqueda.Text))
							{
								bandera=1;
							}
						}
						if(bandera==0 && dgRelacion[columna,x].Value.ToString().Contains(txtBusqueda.Text))
						{
							listaFiltrada.Add(dgRelacion[columna,x].Value.ToString());
						}
					}
					else if(dgRelacion[columna,x].Value.ToString().Contains(txtBusqueda.Text)==true)
					{
						listaFiltrada.Add(dgRelacion[columna,x].Value.ToString());
					}
				}
				
				principal=true;
				for(int x=0; x<listaFiltrada.Count; x++)
				{
					tvFiltros.Nodes[0].Nodes.Add(listaFiltrada[x].ToString()).Checked=true;
				}
				principal=false;
			
			}
		}
		
		void DtFechaEspecialInicioValueChanged(object sender, EventArgs e)
		{
			getNodesFiltro(1);
		}
		
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			CONCATENA=false;
			dgRelacion.Rows.Clear();
			getDatos();
			getNodesFiltro(1);
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			CONCATENA=false;
			dgRelacion.Rows.Clear();
			getDatos();
			getNodesFiltro(1);
		}
		
		void DgRelacionDoubleClick(object sender, EventArgs e)
		{
			if(dgRelacion.CurrentRow.Index>-1 && dgRelacion.CurrentCell.ColumnIndex!=19)
			{
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgRelacion[0,dgRelacion.CurrentRow.Index].Value));
				formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();
			}
		}
		
		void TvFiltrosAfterCheck(object sender, TreeViewEventArgs e)
		{
			if(e.Node.Level==0)
			{
				if(tvFiltros.Nodes[0].Checked==true)
				{
					principal=true;
					for(int x=0; x<tvFiltros.Nodes[0].Nodes.Count; x++)
					{
						tvFiltros.Nodes[0].Nodes[x].Checked=true;
					}
					filtrado=" ";
					dgRelacion.Rows.Clear();
					getDatos();
					principal=false;
					CONCATENA=false;
				}
				else
				{
					principal=true;
					for(int x=0; x<tvFiltros.Nodes[0].Nodes.Count; x++)
					{
						tvFiltros.Nodes[0].Nodes[x].Checked=false;
					}
					filtrado=" ";
					dgRelacion.Rows.Clear();
					principal=false;
					CONCATENA=false;
				}
			}
			else if(e.Node.Level==1 && principal==false)
			{
				dgRelacion.Rows.Clear();
				concatenado();
				CONCATENA=true;
			}
		}
		
		void CbPagadosCheckedChanged(object sender, EventArgs e)
		{
			getDatos();
			getNodesFiltro(1);
		}
		
		void CbFacturadosCheckedChanged(object sender, EventArgs e)
		{
			getDatos();
			getNodesFiltro(1);
		}
		
		void CbBorradosCheckedChanged(object sender, EventArgs e)
		{
				getDatos();
				getNodesFiltro(1);
			
		}
		#endregion		
		
		#region BOTONES
		void CmdPagoClick(object sender, EventArgs e)
		{
			List<int> rowsSelect = new List<int>();
			if(dgRelacion.SelectedRows.Count>0)
			{
				new FormPagos(this).ShowDialog();
				if(realizado==true)
				{
					for(int x=0; x<dgRelacion.Rows.Count; x++)
					{
						if(dgRelacion[2,x].Selected==true && dgRelacion[13,x].Value.ToString()=="NO" && dgRelacion[15,x].Value.ToString()=="NO")
						{
							dgRelacion[13,x].Style.BackColor=Color.MediumBlue;
							dgRelacion[13,x].Style.ForeColor=Color.White;
							dgRelacion[13,x].Value="SI";
							
							conn.getAbrirConexion("INSERT INTO AUDITA_COBRO_ESP VALUES ('"+dgRelacion[16,x].Value.ToString()+"', 'PAGADO', 'N/A', '"+formPrincipal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))");
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
							
							rowsSelect.Add(x);
						}
					}
				}
				realizado=false;
			}
		}
		
		void CmdExcelClick(object sender, EventArgs e)
		{
			exportaExcel();
		}
		
		#endregion
		
		#region GETDATOS	
		public void getDatos()
		{
			int cont = 0;
			consultaP = "select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
		
			if(cbPagados.Checked == false)
			{
				consultaP=consultaP+" and C.PAGO='0' ";
			}
			
			if(cbBorrados.Checked == false)
			{
				consultaP=consultaP+" and C.BORRADO='0' ";
			}
			
			
			consultaP=consultaP+" order BY RE.FECHA_SALIDA ";
			conn.getAbrirConexion(consultaP);
			conn.leer=conn.comando.ExecuteReader();
			int x=0;
			while(conn.leer.Read())
			{
				dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(), 
				                    conn.leer["COBRO"].ToString(), 
				                    conn.leer["Alias"].ToString(), 
				                    conn.leer["Numero"].ToString(), 
				                    conn.leer["TELEFONO"].ToString(), 
				                    conn.leer["SALDO"].ToString(), 
				                    conn.leer["DESTINO"].ToString(), 
				                    conn.leer["FACTURA"].ToString(), 
				                    conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), 
				                    conn.leer["NUMERO_FACT"].ToString(), 
				                    conn.leer["IDENTIFICADOR"].ToString(), 
				                    conn.leer["FECHA"].ToString().Substring(0,10),
				                    "E",
				                    ((conn.leer["PAGO"].ToString()=="1")?"SI":"NO"), 
				                    ((conn.leer["fact"].ToString()=="1")?"SI":"NO"), 
				                    ((conn.leer["INCOBRABLE"].ToString()=="1")?"SI":"NO"), 
				                    conn.leer["IDCC"].ToString(),conn.leer["anticipo"].ToString(), 
				                    conn.leer["OBSERVACIONES"].ToString(),
				                    ((conn.leer["CASETAS"].ToString()=="N/A")?"0":(conn.leer["CASETAS"]).ToString()),
				                    conn.leer["ID_OP"].ToString(), 
				                    ((conn.leer["OP_COBRA"].ToString()=="1")?"SI":"NO"));
				if(conn.leer["TIPO_VIAJE"].ToString()=="C. PUNTO")
				{
					dgRelacion[5,x].Style.BackColor=Color.Red;
				}
				x++;
			}
			
			conn.conexion.Close();			
			getOperadores();
			coloresDatagrid();
			
			dgRelacion.ClearSelection();
			txtCantidad.Text="";
			txtTotal.Text="";
		}					
		
		void getOperadores()
		{
			for(int x=0; x<dgRelacion.Rows.Count; x++)
			{
				if(dgRelacion[21,x].Value.ToString()=="SI")
				{
					dgRelacion[21,x].Style.BackColor=Color.MediumSpringGreen;
				}
				
				if(dgRelacion[2,x].Value.ToString()=="ADMVO")
				{
					String consultOpera = "select * from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and V.Numero='"+dgRelacion[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consultOpera);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgRelacion[2,x].Value=conn.leer["Alias"].ToString();
						dgRelacion[20,x].Value=conn.leer["ID"].ToString();
					}
					
					conn.conexion.Close();
				}
				
				if(dgRelacion[19,x].Value.ToString()!="0")
				{
					String consultOpera = "select * from cobro_casetas where ID_O="+dgRelacion[20,x].Value.ToString()+" and id_re="+dgRelacion[0,x].Value.ToString();
					conn.getAbrirConexion(consultOpera);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgRelacion[19,x].Value=Convert.ToDouble(dgRelacion[19,x].Value)-Convert.ToDouble(conn.leer["CANTIDAD"]);
					}
					
					conn.conexion.Close();
				}
			}
		}		
		
		#region COLORES
		public void coloresDatagrid()
		{
			for(int x=0; x<dgRelacion.Rows.Count; x++)
			{
				if(dgRelacion[13,x].Value.ToString()=="SI")
				{
					dgRelacion[13,x].Style.BackColor=Color.MediumBlue;
					dgRelacion[13,x].Style.ForeColor=Color.White;
				}
				if(dgRelacion[14,x].Value.ToString()=="SI")
				{
					dgRelacion[14,x].Style.BackColor=Color.OrangeRed;
					dgRelacion[14,x].Style.ForeColor=Color.White;
				}
				if(dgRelacion[15,x].Value.ToString()=="SI")
				{
					dgRelacion[15,x].Style.BackColor=Color.Red;
					dgRelacion[15,x].Style.ForeColor=Color.White;
				}
				if(dgRelacion[13,x].Value.ToString()=="SI" && dgRelacion[14,x].Value.ToString()=="SI")
				{
					for(int y=0; y<10; y++)
					{
						dgRelacion[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
		}
		#endregion
		
		public void getDatos2()
		{
			int cont = 0;
			
			consultaP=consultaP+" order BY RE.FECHA_SALIDA ";
			//consulta=consulta+" group by C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA , C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID, C.OBSERVACIONES ";
			conn.getAbrirConexion(consultaP);
			conn.leer=conn.comando.ExecuteReader();
			int x=0;
			while(conn.leer.Read())
			{
				dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(), conn.leer["COBRO"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["TELEFONO"].ToString(), conn.leer["SALDO"].ToString(), conn.leer["DESTINO"].ToString(), conn.leer["FACTURA"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["NUMERO_FACT"].ToString(), conn.leer["IDENTIFICADOR"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), "E", ((conn.leer["PAGO"].ToString()=="1")?"SI":"NO"), ((conn.leer["fact"].ToString()=="1")?"SI":"NO"), ((conn.leer["INCOBRABLE"].ToString()=="1")?"SI":"NO"), conn.leer["IDCC"].ToString(),conn.leer["anticipo"].ToString(),conn.leer["OBSERVACIONES"].ToString(), ((conn.leer["CASETAS"].ToString()=="N/A")?"0":(conn.leer["CASETAS"]).ToString()), conn.leer["ID_OP"].ToString(), ((conn.leer["OP_COBRA"].ToString()=="1")?"SI":"NO"));
				//dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(), conn.leer["COBRO"].ToString(), "OPERADOR", conn.leer["Numero"].ToString(), conn.leer["TELEFONO"].ToString(), conn.leer["SALDO"].ToString(), conn.leer["DESTINO"].ToString(), conn.leer["FACTURA"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["NUMERO_FACT"].ToString(), conn.leer["IDENTIFICADOR"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["TIPO_VIAJE"].ToString(), ((conn.leer["PAGO"].ToString()=="1")?"SI":"NO"), ((conn.leer["fact"].ToString()=="1")?"SI":"NO"), ((conn.leer["INCOBRABLE"].ToString()=="1")?"SI":"NO"));
				if(conn.leer["TIPO_VIAJE"].ToString()=="C. PUNTO")
				{
					dgRelacion[5,(dgRelacion.Rows.Count-1)].Style.BackColor=Color.Red;
				}
			}
			
			conn.conexion.Close();
			
			//getUnidades();
			getOperadores();
			dgRelacion.ClearSelection();
			coloresDatagrid();
			
			txtCantidad.Text="";
			txtTotal.Text="";
		}
		#endregion
			
		#region IMPRESION EXCEL
		void exportaExcel()
		{
			if(dgRelacion.Rows.Count>0)
			{
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
					
				int i = 1;
			
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
				ExcelApp.Cells[i,  11] 	= "AGENCIA";
				ExcelApp.Cells[i,  12] 	= "FECHA";
				ExcelApp.Cells[i,  13] 	= "OBSERVACIONES";
				ExcelApp.Cells[i,  14] 	= "FACTURA";
				
				for(int y=0; y<dgRelacion.Rows.Count; y++)
				{
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
		#endregion
		*/
	}
}
