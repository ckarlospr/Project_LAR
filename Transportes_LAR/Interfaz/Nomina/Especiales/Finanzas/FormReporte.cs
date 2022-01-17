using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	public partial class FormReporte : Form
	{
		public FormReporte(Interfaz.FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		int colSelect=0;
		bool seleccionTV=false;
		
		String consPrin ;
		String consAnt ;
		String consCob ;
		#endregion
		
		#region INSTANCIAS
		public List<DatosPrin> listDatosPrinc;
		public List<Anticipos> listDatosAntic;
		public List<Validado> listDatosCobros;
		
		public Interfaz.FormPrincipal refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region get consulta
		void getConsultas()
		{
			consPrin = "SELECT ID_RE, FECHA_SALIDA, RESPONSABLE, DESTINO, PRECIO, CANT_UNIDADES, (CONVERT (DECIMAL, PRECIO)*CONVERT (DECIMAL, CANT_UNIDADES)) as COSTO, FACTURADO, INCOBRABLE, PAGADO, NUMERO_ANTI, FACTURA FROM RUTA_ESPECIAL where estado='Activo' and PAGADO='0' and ID_C in (select IdSubEmpresa from RUTA where TIPO='ESP') and FECHA_SALIDA between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' order by FECHA_SALIDA";
			consAnt = " select * from ANTICIPOS_ESPECIALES ";// where ESTATUS!='3'";
			consCob = " select * from COBRO_ESPECIAL where BORRADO='0' and ESTATUS='1' ";
		}
		
		void getConsValidados()
		{
			consPrin = "SELECT ID_RE, FECHA_SALIDA, RESPONSABLE, DESTINO, PRECIO, CANT_UNIDADES, (CONVERT (DECIMAL, PRECIO)*CONVERT (DECIMAL, CANT_UNIDADES)) as COSTO, FACTURADO, INCOBRABLE, PAGADO, NUMERO_ANTI, FACTURA FROM RUTA_ESPECIAL where estado='Activo' and (PAGADO='0' or PAGADO='3') and ID_C in (select IdSubEmpresa from RUTA where TIPO='ESP') and FECHA_SALIDA between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' order by FECHA_SALIDA";
			consAnt = " select * from ANTICIPOS_ESPECIALES";
			consCob = " select * from COBRO_ESPECIAL where BORRADO='0' and ESTATUS='1' ";
		}
		#endregion
		
		#region EVENTO LOAD		
		void FormReporteLoad(object sender, EventArgs e)
		{
			dtpInicio.Value=Convert.ToDateTime("01/01/2014");
			dtpFin.Value=DateTime.Now;
			
			getConsultas();
			
			getDatos(consPrin, consAnt, consCob);
			colores();
		}
		#endregion
		
		#region LLENADO DE DATAGRID
		void getDatos(String consultaPrin, String consultaAnt, String consultaCob)
		{
			dgReporte.Rows.Clear();
			
			listDatosPrinc = new Conexion_Servidor.Reportes.SQL_Reportes().getDatosPrin(consultaPrin);
			listDatosAntic = new Conexion_Servidor.Reportes.SQL_Reportes().getAnticipos(consultaAnt);
			listDatosCobros = new Conexion_Servidor.Reportes.SQL_Reportes().getCobros(consultaCob);
			
			if(listDatosPrinc!=null)
			{
				for(int x=0; x<listDatosPrinc.Count; x++)
				{
					// ((listDatosPrinc[x].FACT!="0")?"FACTURABLE":"")
					dgReporte.Rows.Add(listDatosPrinc[x].ID_RE,
					                   listDatosPrinc[x].RESPONSABLE,
					                   listDatosPrinc[x].DESTINO,
					                   listDatosPrinc[x].FECHA_SALIDA.Substring(0,10),
					                   listDatosPrinc[x].COSTO,
					                   "",
					                   "",
					                   "",
					                   "",
					                   "",
					                   ((listDatosPrinc[x].FACT=="3")?listDatosPrinc[x].NUMERO_FACT:listDatosPrinc[x].FACT),
					                   "",
					                   listDatosPrinc[x].FACT,
					                   listDatosPrinc[x].INCO,
					                   listDatosPrinc[x].FLUJO,
					                   listDatosPrinc[x].FACTURA);
				}
			}
			
			for(int x=0; x<dgReporte.Rows.Count; x++)
			{
				Double efectivo = 0.0;
				Double deposito = 0.0;
				Double faltante = 0.0;
				Double recuperado = 0.0;
				string datFact = "";
				bool efect=false;
				bool depos=false;
				bool cancelPunto=false;
				Double deuda =0.0;
				
				
				if(dgReporte[10,x].Value.ToString()=="1" || dgReporte[10,x].Value.ToString()=="2"){
					dgReporte[10,x].Value="FACTURABLE";
				}
				else if(dgReporte[10,x].Value.ToString()=="VARIOS"){
					dgReporte[10,x].Value="";
					String conns = "select * from FACTURA_VARIOS where ID_RE="+dgReporte[0,x].Value.ToString();
					conn.getAbrirConexion(conns);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgReporte[10,x].Value=dgReporte[10,x].Value+" "+conn.leer["DATO"].ToString();
					}
					conn.conexion.Close();
				}
				else if(dgReporte[10,x].Value.ToString()=="0"){
					dgReporte[10,x].Value="";
				}
					
				if(dgReporte[12,x].Value.ToString()!="0"){
					double IVA = Convert.ToDouble(dgReporte[4,x].Value)*.16;
					dgReporte[4,x].Value=(Convert.ToDouble(dgReporte[4,x].Value)+IVA).ToString();
				}
				
				for(int y=0; y<listDatosAntic.Count; y++){
					if(dgReporte[0,x].Value.ToString()==listDatosAntic[y].ID_RE && listDatosAntic[y].TIPO!="DEPOSITO" && listDatosAntic[y].ESTATUS!="0")
						efectivo=efectivo+Convert.ToDouble(listDatosAntic[y].CANTIDAD);
					else if(dgReporte[0,x].Value.ToString()==listDatosAntic[y].ID_RE && listDatosAntic[y].TIPO=="EFECTIVO")
						efect=true;
					
					if(dgReporte[0,x].Value.ToString()==listDatosAntic[y].ID_RE && listDatosAntic[y].TIPO=="DEPOSITO" && listDatosAntic[y].ESTATUS!="0")
						deposito=deposito+Convert.ToDouble(listDatosAntic[y].CANTIDAD);
					else if(dgReporte[0,x].Value.ToString()==listDatosAntic[y].ID_RE && listDatosAntic[y].TIPO=="DEPOSITO")
						depos=true;
					
					if(dgReporte[0,x].Value.ToString()==listDatosAntic[y].ID_RE)// && (listDatosAntic[y].TIPO=="DEPOSITO" || listDatosAntic[y].TIPO=="DEPOSITO"))
						deuda = deuda + Convert.ToDouble(listDatosAntic[y].CANTIDAD);
				}
				
				dgReporte[5,x].Value=efectivo.ToString();
				if(efect==true)
					dgReporte[5,x].Style.BackColor=Color.Yellow;
				
				dgReporte[6,x].Value=deposito.ToString();
				if(depos==true)
					dgReporte[6,x].Style.BackColor=Color.Yellow;
				
					
				for(int y=0; y<listDatosCobros.Count; y++)
				{
					if(dgReporte[0,x].Value.ToString()==listDatosCobros[y].ID_RE)
					{
						if(dgReporte[0,x].Value.ToString()==listDatosCobros[y].ID_RE && listDatosCobros[y].PAGO=="1")
							recuperado=recuperado+Convert.ToDouble(listDatosCobros[y].SALDO);
						
						if(dgReporte[0,x].Value.ToString()==listDatosCobros[y].ID_RE && listDatosCobros[y].PAGO=="0")
							faltante=faltante+Convert.ToDouble(listDatosCobros[y].SALDO);
						
						//MessageBox.Show(dgReporte[0,x].Value.ToString()+"=="+listDatosCobros[y].ID_RE+" && "+ listDatosCobros[y].DATO_FACT);
						if(dgReporte[0,x].Value.ToString()==listDatosCobros[y].ID_RE && listDatosCobros[y].DATO_FACT!="")
							datFact=listDatosCobros[y].DATO_FACT;
						
						if(listDatosCobros[y].TIPO_VIAJE=="C. PUNTO")
						{
							cancelPunto=true;
							dgReporte[8,x].Style.BackColor=Color.Red;
						}
						
						//deuda=deuda+Convert.ToDouble(listDatosCobros[y].SALDO);
					}
				}
				
				dgReporte[9,x].Value=faltante.ToString();
				if(datFact!="")
				{
					// dgReporte[10,x].Value=datFact; // numero anti para traer varios *********************************************************************************
				}
				dgReporte[11,x].Value=recuperado.ToString();
				
				if(dgReporte[13,x].Value.ToString()=="1")
				{
					dgReporte[8,x].Value="Incobrable";
					dgReporte[8,x].Style.BackColor=Color.Red;
				}
				
				if(dgReporte[8,x].Value.ToString()!="Incobrable")
				{
					if(cancelPunto==false)
						dgReporte[8,x].Value=(Convert.ToDouble(dgReporte[4,x].Value)-deuda);
					else
						dgReporte[8,x].Value="C. PUNTO";
				}
				
				/*for(int y=0; y<listDatosCobros.Count; y++)
				{*/
				dgReporte[7,x].Value=Convert.ToDouble(dgReporte[5,x].Value)+Convert.ToDouble(dgReporte[6,x].Value);//+Convert.ToDouble(dgReporte[11,x].Value);
				if(Convert.ToDouble(dgReporte[4,x].Value)==Convert.ToDouble(dgReporte[7,x].Value) && dgReporte[8,x].Style.BackColor.Name!="Red")
					dgReporte[2,x].Style.BackColor=Color.MediumSpringGreen;
				else if(dgReporte[8,x].Style.BackColor.Name=="Red" && dgReporte[5,x].Style.BackColor.Name!="Yellow" && dgReporte[6,x].Style.BackColor.Name!="Yellow" && dgReporte[9,x].Value.ToString()=="0")
					dgReporte[2,x].Style.BackColor=Color.MediumSpringGreen;
				else if(dgReporte[8,x].Value.ToString()=="Incobrable")
					dgReporte[2,x].Style.BackColor=Color.MediumSpringGreen;
				//}
				
				if(dgReporte[8,x].Value.ToString()!="0" && dgReporte[8,x].Value.ToString()!="C. PUNTO" && dgReporte[8,x].Value.ToString()!="Incobrable")
				{
					dgReporte[8,x].Style.BackColor=Color.OrangeRed;
				}
			}
			
			Double TCosto = 0.0;
			Double TEfectivo = 0.0;
			Double TDeposito = 0.0;
			Double TCaja = 0.0;
			Double TCobrar = 0.0;
			Double TRecuperado = 0.0;
			
			for(int x=0; x<dgReporte.Rows.Count; x++)
			{
				TCosto = TCosto+Convert.ToDouble(dgReporte[4,x].Value.ToString());
			 	TEfectivo = TEfectivo+Convert.ToDouble(dgReporte[5,x].Value.ToString());
			 	TDeposito = TDeposito+Convert.ToDouble(dgReporte[6,x].Value.ToString());
			 	TCaja = TCaja+Convert.ToDouble(dgReporte[7,x].Value.ToString());
			 	TCobrar = TCobrar+((dgReporte[8,x].Value.ToString()=="C. PUNTO" || dgReporte[8,x].Value.ToString()=="Incobrable")?0:Convert.ToDouble(dgReporte[8,x].Value.ToString()));
			 	TRecuperado = TRecuperado+Convert.ToDouble(dgReporte[9,x].Value.ToString());
			}
			
			txtCosto.Text=TCosto.ToString("C");
			txtAnticipo.Text=TEfectivo.ToString("C");
			txtDeposito.Text=TDeposito.ToString("C");
			txtCaja.Text=TCaja.ToString("C");
			txtCobrar.Text=TCobrar.ToString("C");
			txtRecuperado.Text=TRecuperado.ToString("C");
			
			dgReporte.ClearSelection();
		}
		#endregion
		
		#region GETFORMULARIOS DATOS EVENTO DOUBLE CLICK
		void DgReporteDoubleClick(object sender, EventArgs e)
		{
			if(dgReporte.CurrentRow.Index>-1)
			{
				if(dgReporte.CurrentCell.ColumnIndex==0)
				{
					Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgReporte[0,dgReporte.CurrentRow.Index].Value));
					formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
					formDatos.ShowDialog();
				}
				else if(dgReporte.CurrentCell.ColumnIndex==5 && (dgReporte[5,dgReporte.CurrentRow.Index].Style.BackColor.Name=="Yellow" || dgReporte[5,dgReporte.CurrentRow.Index].Value.ToString()!="0"))
				{
					new FormAnticipos(dgReporte[0,dgReporte.CurrentRow.Index].Value.ToString(), this, 1).ShowDialog();
				}
				else if(dgReporte.CurrentCell.ColumnIndex==6 && (dgReporte[6,dgReporte.CurrentRow.Index].Style.BackColor.Name=="Yellow" || dgReporte[6,dgReporte.CurrentRow.Index].Value.ToString()!="0"))
				{
					new FormAnticipos(dgReporte[0,dgReporte.CurrentRow.Index].Value.ToString(), this, 2).ShowDialog();
				}
				else if(dgReporte.CurrentCell.ColumnIndex==9)
				{
					new FormXCobrar(dgReporte[0,dgReporte.CurrentRow.Index].Value.ToString(), this).ShowDialog();
				}
				else if(dgReporte.CurrentCell.ColumnIndex==8 && dgReporte[8,dgReporte.CurrentRow.Index].Value.ToString()=="Incobrable")
				{
					new FormDatosIncobrable(Convert.ToInt64(dgReporte[0,dgReporte.CurrentRow.Index].Value)).ShowDialog();
				}
				else if(dgReporte.CurrentCell.ColumnIndex==8 && dgReporte[8,dgReporte.CurrentRow.Index].Value.ToString()!="0")
				{
					new FormCompleta(dgReporte[0,dgReporte.CurrentRow.Index].Value.ToString(), this).ShowDialog();
				}
			}
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdRelacionClick(object sender, EventArgs e)
		{
			Interfaz.Nomina.Especiales.FormCuentasEsp cuentasEsp = new Interfaz.Nomina.Especiales.FormCuentasEsp(null, 2);
			cuentasEsp.ShowDialog();
		}
		
		void CmdIncobrableClick(object sender, EventArgs e)
		{
			if(dgReporte.SelectedRows.Count>0)
			{
				new FormTipoPago(this, 2).ShowDialog();
			}
		}
		
		void CmdValidarClick(object sender, EventArgs e)
		{
			if(dgReporte.SelectedRows.Count>0)
			{
				if(dgReporte[0,dgReporte.CurrentRow.Index].Style.BackColor.Name=="MediumSpringGreen")
				{
					MessageBox.Show("Registro ya validado.");
				}
				else
				{
					if(dgReporte[2,dgReporte.CurrentRow.Index].Style.BackColor.Name=="MediumSpringGreen")
					{
						new Conexion_Servidor.Libros.SQL_Libros().borradoEspCompleto(dgReporte[0,dgReporte.CurrentRow.Index].Value.ToString());
						dgReporte.Rows.RemoveAt(dgReporte.CurrentRow.Index);
					}
					else
					{
						MessageBox.Show("Para validar un registro es necesario que se validen los todos los pagos del viaje.");
					}
				}
			}
		}
		#endregion
		
		#region METODO INCOBRABLE
		public void incobrable()
		{
			dgReporte[8,dgReporte.CurrentRow.Index].Style.BackColor=Color.Red;
			dgReporte[8,dgReporte.CurrentRow.Index].Value="Incobrable";
			dgReporte[13,dgReporte.CurrentRow.Index].Value="1";
			
			new Conexion_Servidor.Libros.SQL_Libros().IncobraEspCompleto(dgReporte[0,dgReporte.CurrentRow.Index].Value.ToString());
			
			if(Convert.ToDouble(dgReporte[4,dgReporte.CurrentRow.Index].Value)==Convert.ToDouble(dgReporte[7,dgReporte.CurrentRow.Index].Value) && dgReporte[8,dgReporte.CurrentRow.Index].Style.BackColor.Name!="Red")
				dgReporte[2,dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
			else if(dgReporte[8,dgReporte.CurrentRow.Index].Style.BackColor.Name=="Red" && dgReporte[5,dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && dgReporte[6,dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && dgReporte[9,dgReporte.CurrentRow.Index].Value.ToString()=="0")
				dgReporte[2,dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
			
			dgReporte[2,dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
		}
		#endregion
		
		#region IMPRESION EXCEL
		void CmdImprimirClick(object sender, EventArgs e)
		{
			exportaExcel();
		}
		
		void exportaExcel()
		{
			if(dgReporte.Rows.Count>0)
			{
				Double Costo = 0.0;
				Double Efectivo =0.0;
				Double Deposito =0.0;
				Double Caja = 0.0;
				Double Cobrar = 0.0;
				Double Recuperado = 0.0;
				
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
					
				int i = 1;
			
				++i;
				ExcelApp.Cells[i,  1] 	= "ID";
				ExcelApp.Cells[i,  2] 	= "SERVICIO";
				ExcelApp.Cells[i,  3] 	= "UNIDADES";
				ExcelApp.Cells[i,  4] 	= "FECHA";
				ExcelApp.Cells[i,  5] 	= "COSTO";
				ExcelApp.Cells[i,  6] 	= "EFECTIVO";
				ExcelApp.Cells[i,  7] 	= "DEPOSITO";
				ExcelApp.Cells[i,  8] 	= "CAJA";
				ExcelApp.Cells[i,  9] 	= "X COBRAR";
				ExcelApp.Cells[i,  10] 	= "RECUPERADO";
				ExcelApp.Cells[i,  11] 	= "FACTURA";
				for(int y=0; y<dgReporte.Rows.Count; y++)
				{
					++i;
					
					ExcelApp.Cells[i,  1]	= dgReporte[0,y].Value.ToString();
					ExcelApp.Cells[i,  2]	= dgReporte[2,y].Value.ToString();
					
					
						String consulta = "SELECT CANT_UNIDADES FROM RUTA_ESPECIAL WHERE ID_RE="+dgReporte[0,y].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							ExcelApp.Cells[i,  3]	= conn.leer["CANT_UNIDADES"].ToString();
						}
						else
						{
							ExcelApp.Cells[i,  3]	= "";
						}
						
						conn.conexion.Close();
					
					ExcelApp.Cells[i,  4]	= dgReporte[3,y].Value.ToString();
					ExcelApp.Cells[i,  5]	= dgReporte[4,y].Value.ToString();
					ExcelApp.Cells[i,  6]	= dgReporte[5,y].Value.ToString();
					ExcelApp.Cells[i,  7]	= dgReporte[6,y].Value.ToString(); // colocando los totales
					ExcelApp.Cells[i,  8]	= dgReporte[7,y].Value.ToString();
					ExcelApp.Cells[i,  9]	= dgReporte[8,y].Value.ToString();
					ExcelApp.Cells[i,  10]	= dgReporte[9,y].Value.ToString();
					ExcelApp.Cells[i,  11]	= dgReporte[10,y].Value.ToString();
					
					Costo    	= Costo+Convert.ToDouble(dgReporte[4,y].Value.ToString());
					Efectivo 	= Efectivo+Convert.ToDouble(dgReporte[5,y].Value.ToString());
					Deposito 	= Deposito+Convert.ToDouble(dgReporte[6,y].Value.ToString());
					Caja     	= Caja+Convert.ToDouble(dgReporte[7,y].Value.ToString());
					Cobrar 	 	= Cobrar+((dgReporte[8,y].Value.ToString()=="C. PUNTO" || dgReporte[8,y].Value.ToString()=="INCOBRABLE"|| dgReporte[8,y].Value.ToString()=="Incobrable")?0.00:Convert.ToDouble(dgReporte[8,y].Value.ToString()));
				 	Recuperado 	= Recuperado+Convert.ToDouble(dgReporte[9,y].Value.ToString());
				}
				
				++i;
				
				ExcelApp.Cells[i,  4] 	= "TOTALES:";
				ExcelApp.Cells[i,  5] 	= Costo;
				ExcelApp.Cells[i,  6] 	= Efectivo;
				ExcelApp.Cells[i,  7] 	= Deposito;
				ExcelApp.Cells[i,  8] 	= Caja;
				ExcelApp.Cells[i,  9] 	= Cobrar;
				ExcelApp.Cells[i,  10] 	= Recuperado;
			
				// ---------- cuadro de dialogo para Guardar
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "REPORTE "+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
		#region CAMBIO DE RANGO
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			if(cbValidados.Checked==true)
				getConsValidados();
			else
				getConsultas();
			
			getDatos(consPrin, consAnt, consCob);
			colores();
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			if(cbValidados.Checked==true)
				getConsValidados();
			else
				getConsultas();
			
			getDatos(consPrin, consAnt, consCob);
			colores();
		}
		
		void CbValidadosCheckedChanged(object sender, EventArgs e)
		{
			if(cbValidados.Checked==true)
				getConsValidados();
			else
				getConsultas();
			
			getDatos(consPrin, consAnt, consCob);
			colores();
		}
		#endregion
		
		#region COLORES
		void colores()
		{
			for(int x=0; x<dgReporte.Rows.Count; x++)
			{
				if(dgReporte[14,x].Value.ToString()!="0")
				{
					for(int y=0; y<dgReporte.ColumnCount; y++)
					{
						dgReporte[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
		}
		#endregion
		
		#region FILTROS (TREEVIEW)
		void DgReporteCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.RowIndex==-1)// && e.ColumnIndex!=12 && e.ColumnIndex!=13 && e.ColumnIndex!=14 && e.ColumnIndex!=15)
			{
				if(e.Button == MouseButtons.Right)
				{
					seleccionTV=true;
					getNodesFiltro(e.ColumnIndex);
					colSelect=e.ColumnIndex;
					seleccionTV=false;
				}
			}
		}
		
		public void getNodesFiltro(int columna)
		{
			tvFiltros.Nodes.Clear();
			tvFiltros.Nodes.Add(dgReporte.Columns[columna].HeaderText);
			tvFiltros.Nodes[0].Checked=true;
			List<String> listaFiltrada = new List<String>();
			
			for(int x=0; x<dgReporte.Rows.Count; x++)
			{
				int bandera=0;
				if(listaFiltrada.Count>0)
				{
					for(int y=0; y<listaFiltrada.Count; y++)
					{
						if(listaFiltrada[y].ToString()==dgReporte[columna,x].Value.ToString())
						{
							bandera=1;
						}
					}
					if(bandera==0)
					{
						listaFiltrada.Add(dgReporte[columna,x].Value.ToString());
					}
				}
				else
				{
					listaFiltrada.Add(dgReporte[columna,x].Value.ToString());
				}
			}
			
			for(int x=0; x<listaFiltrada.Count; x++)
			{
				tvFiltros.Nodes[0].Nodes.Add(listaFiltrada[x].ToString()).Checked=true;
			}
			
			tvFiltros.Nodes[0].Expand();
		}
		
		void TvFiltrosAfterCheck(object sender, TreeViewEventArgs e)
		{
			if(e.Node.Level==0)
			{
				if(tvFiltros.Nodes[0].Checked==true)
				{
					for(int x=0; x<tvFiltros.Nodes[0].Nodes.Count; x++)
					{
						tvFiltros.Nodes[0].Nodes[x].Checked=true;
					}
				}
				else
				{
					for(int x=0; x<tvFiltros.Nodes[0].Nodes.Count; x++)
					{
						tvFiltros.Nodes[0].Nodes[x].Checked=false;
					}
				}
			}
			else if(e.Node.Level==1 && seleccionTV==false)
			{
				concatenado();
			}
		}
		
		public void concatenado()
		{
			for(int y=0; y<dgReporte.Rows.Count; y++)
			{
				bool muestra = false;
				for(int x=0; x<tvFiltros.Nodes[0].Nodes.Count; x++)
				{
					if(tvFiltros.Nodes[0].Nodes[x].Checked==true)
					{
						if(dgReporte[colSelect,y].Value.ToString()==tvFiltros.Nodes[0].Nodes[x].Text)
						{
							muestra=true;
						}
					}
				}
				
				if(muestra==false)
				{
					dgReporte.Rows[y].Visible=false;
				}
				else
				{
					dgReporte.Rows[y].Visible=true;
				}
			}
		}
		
		
		#endregion
		
	}
}
