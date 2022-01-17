using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormCuentasEsp : Form
	{
		Thread hilo;
		bool detener;
		
		Thread hilo2;
		bool detener2;
		
		delegate void SetTextCallback(string text);
		
		public FormCuentasEsp(FormPrincipal refPrinc, int tipo)
		{
			InitializeComponent();
			
			hilo=null;
			detener=false;
			
			hilo2=null;
			detener2=false;
			
			formPrincipal=refPrinc;
			
			TIPO=tipo;
		}
		
		#region VARIABLES
		public bool realizado=false;
		
		int TIPO;
		int columnaselect=1;
		
		String consulta = "";
		String consulta2 = "";
		String filtrado = " ";
		bool principal=false;
		#endregion
		
		#region INSTANCIAS
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		
		public FormPrincipal formPrincipal;
		
		public bool fil0=false;
		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO CELLMOUSEUP
		void DgDatosCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			/*if(e.RowIndex==-1)
			{
				if(e.Button == MouseButtons.Right)
				{
					getNodesFiltro(e.ColumnIndex);
				}
			}*/
		}
		
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
				//Int64 idSelect = 0;
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
				
				if(entra==false)
				{
					//MessageBox.Show("Entra");
					new FormCabiosReg(e.RowIndex, this, cant).ShowDialog();
				}
				else
				{
					MessageBox.Show("Seleccione registros del mismo servicio.");
				}
			}
		}
		#endregion
				
		#region EVENTOS BOTONES
		void CmdEliminaClick(object sender, EventArgs e)
		{
			Eliminar();
		}
		
		void CmdBorrarClick(object sender, EventArgs e)
		{
			new FormElimina(this).ShowDialog();
			/*List<int> rowsSelect = new List<int>();
			
			if(dgRelacion.SelectedRows.Count>0)
			{
				for(int x=0; x<dgRelacion.Rows.Count; x++)
				{
					if(dgRelacion[2,x].Selected==true && (dgRelacion[13,x].Value.ToString()=="SI" || dgRelacion[15,x].Value.ToString()=="SI"))
					{
						new Conexion_Servidor.Libros.SQL_Libros().borradoEsp(dgRelacion[10,x].Value.ToString());
						rowsSelect.Add(x);
					}
				}
				
				for(int x=rowsSelect.Count-1; x>-1; x--)
				{
					if(cbBorrados.Checked==false)
					{
						dgRelacion.Rows.RemoveAt(rowsSelect[x]);
					}
				}
			}
			
			dgRelacion.ClearSelection();*/
		}
		
		public void borrarPagos()
		{
			List<int> rowsSelect = new List<int>();
			
			for(int x=0; x<dgRelacion.Rows.Count; x++)
			{
				if(dgRelacion[13,x].Value.ToString()=="SI")
				{
					new Conexion_Servidor.Libros.SQL_Libros().borradoEsp(dgRelacion[10,x].Value.ToString());
					rowsSelect.Add(x);
				}
			}
			
			for(int x=rowsSelect.Count-1; x>-1; x--)
			{
				if(cbBorrados.Checked==false)
				{
					dgRelacion.Rows.RemoveAt(rowsSelect[x]);
				}
			}
		}
		
		void CmdPagoClick(object sender, EventArgs e)
		{
			List<int> rowsSelect = new List<int>();
			//prende();
			if(dgRelacion.SelectedRows.Count>0)
			{
				new FormFormaPago(this).ShowDialog();
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
			/*revisionElimina(rowsSelect, "PAGO");
			coloresDatagrid();
			dgRelacion.ClearSelection();*/
		}
		
		void CmdFacturaClick(object sender, EventArgs e)
		{
			if(dgRelacion.SelectedRows.Count>0)
			{
				new FormIngresoFact(this).ShowDialog();
			}
		}
		
		public void guardaDatosFact(String DATO)
		{
			if(dgRelacion.CurrentRow.Index>-1)
			{
				List<int> rowsSelect = new List<int>();
				//prende2();
				
				
				for(int x=0; x<dgRelacion.Rows.Count; x++)
				{
					if(dgRelacion[2,x].Selected==true && dgRelacion[15,x].Value.ToString()=="NO")// && dgRelacion[14,x].Value.ToString()=="NO")
					{
						dgRelacion[14,x].Style.BackColor=Color.OrangeRed;
						dgRelacion[14,x].Style.ForeColor=Color.White;
						dgRelacion[14,x].Value="SI";
						dgRelacion[9,x].Value=DATO;
						new Conexion_Servidor.Libros.SQL_Libros().facturaEsp(dgRelacion[10,x].Value.ToString(), dgRelacion[9,x].Value.ToString());
						
						conn.getAbrirConexion("UPDATE RUTA_ESPECIAL SET FACTURADO='3', NUMERO_ANTI='"+DATO+"'  WHERE ID_RE="+dgRelacion[0,x].Value.ToString());
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
						rowsSelect.Add(x);
						
						conn.getAbrirConexion("INSERT INTO AUDITA_COBRO_ESP VALUES ('"+dgRelacion[16,x].Value.ToString()+"', 'FACTURA', '"+DATO+"', '"+formPrincipal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))");
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
					
				revisionElimina(rowsSelect, "FACTURA");
				coloresDatagrid();
				dgRelacion.ClearSelection();
			}
		}
		
		void CmdIncobraClick(object sender, EventArgs e)
		{
			if(dgRelacion.SelectedRows.Count==1)
			{
				if(dgRelacion[15,dgRelacion.CurrentRow.Index].Value.ToString()=="NO")
				{
					new FormTipoPago(this, 1).ShowDialog();
				}
				else
				{
					MessageBox.Show("Registro ya establecido como incobrable.");
				}
			}
			else
			{
				MessageBox.Show("Seleccione un registro.");
			}
		}
		
		public void incobrable()
		{
			List<int> rowsSelect = new List<int>();
			//prende2();
			
			for(int x=0; x<dgRelacion.Rows.Count; x++)
			{
				if(dgRelacion[2,x].Selected==true && dgRelacion[15,x].Value.ToString()=="NO" && dgRelacion[13,x].Value.ToString()=="NO" && dgRelacion[14,x].Value.ToString()=="NO")
				{
					dgRelacion[15,x].Style.BackColor=Color.Red;
					dgRelacion[15,x].Style.ForeColor=Color.White;
					dgRelacion[15,x].Value="SI";
					new Conexion_Servidor.Libros.SQL_Libros().IncobraEsp(dgRelacion[10,x].Value.ToString());
					rowsSelect.Add(x);
				}
			}
			coloresDatagrid();
		}
		
		void revisionElimina(List<int> rowsSelect, String tipo)
		{
			for(int x=rowsSelect.Count-1; x>-1; x--)
			{
				if(cbFacturados.Checked==false && tipo=="FACTURA")
				{
					dgRelacion.Rows.RemoveAt(rowsSelect[x]);
				}
				if(cbPagados.Checked==false  && tipo=="PAGO")
				{
					dgRelacion.Rows.RemoveAt(rowsSelect[x]);
				}
				if(cbBorrados.Checked==false && tipo=="BORRADO")
				{
					dgRelacion.Rows.RemoveAt(rowsSelect[x]);
				}
			}
		}
		
		void CmdFiltrarClick(object sender, EventArgs e)
		{
			/*for(int x=0; x<tvFiltros.Nodes.Count; x++)
			{
				if(tvFiltros.Nodes[x].Checked==true)
				{
					MessageBox.Show(tvFiltros.Nodes[x].Text);
				}
			}*/
		}
		#endregion
		
		#region EVENTO DE FECHAS
		void DtFechaEspecialInicioValueChanged(object sender, EventArgs e)
		{
			getNodesFiltro(1);
		}
		
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			dgRelacion.Rows.Clear();
			obternerConsulta();
			consigueConsulta();
			getDatos();
			getNodesFiltro(1);
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			dgRelacion.Rows.Clear();
			obternerConsulta();
			consigueConsulta();
			getDatos();
			getNodesFiltro(1);
		}
		#endregion
				
		#region EVENTO LOAD
		void FormCuentasEspLoad(object sender, EventArgs e)
		{			
			txtUbica.AutoCompleteCustomSource = auto.AutoReconocimiento("select UBICA dato from ANTICIPOS_ESPECIALES");
			txtUbica.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtUbica.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			getComentario(); 
			dtpInicio.Value = Convert.ToDateTime("01/01/2016");// DateTime.Now;
			dtpFin.Value = DateTime.Now;
			
			obtenerConsultaFact();
			consulta2=consulta2+" and RE.FACTURADO='2' ";
			getDatosFact();
			getCanceladosFact();
			
			obternerConsulta();
			consigueConsulta();
			getDatos();
			getNodesFiltro(1);
			cbFacturados.Checked=true;
			
			if(TIPO==1)
			{
				cmdPago.Visible=true;
				//cmdIncobra.Visible=true;
				cmdFactura.Visible=true;
				//cmdBorrar.Visible=true;
				//cbBorrados.Visible=true;
			}
			else if(TIPO==3)
			{
				cbPagados.Checked=true;
				obternerConsultaPago();
				consigueConsulta();
				getDatos();
			}
			else if(TIPO==4)
			{
				dtpInicio.Value = Convert.ToDateTime("13/07/2013");
				dgRelacion.Rows.Clear();
				obternerConsulta();
				consigueConsulta();
				getDatos();
				cmdBorrar.Visible=true;
				cbBorrados.Visible=true;
				tcCobros.TabPages.RemoveAt(1);
				txtTotal.Visible=false;
				lblTotal.Visible=false;
			}
			
			getServicios();
		}
		#endregion
		
		#region FILTROS (TREEVIEW)
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
		
		void CmdCerrarClick(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region GETDATOS
		#region GET DATOS DATAGRID
		public void obternerConsulta()
		{
			//consulta="select C.ID_RE, C.COBRO, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V WHERE C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			// ULTIMA consulta="select C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID IDCC, C.OBSERVACIONES from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP WHERE C.ID_RUTA_SAL=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			// ultima: consulta = "select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			
			consulta = "select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and (re.PAGADO = '0' or re.PAGADO = '1') and re.estado = 'Activo' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' ";
			//if(TIPO==4 && cbBorrados.Checked==false)
			//	consulta=consulta+" and C.ID not in (select ID_C from RESUMEN_VENTAS) ";
		}
		
		public void obternerConsultaPago()
		{
			//consulta="select C.ID_RE, C.COBRO, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V WHERE C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' ";
			// ULTIMA consulta="select C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID IDCC, C.OBSERVACIONES from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP WHERE C.ID_RUTA_SAL=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' ";
			
			consulta = "select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and C.ESTATUS='1' ";
			if(TIPO==4 && cbBorrados.Checked==false)
				consulta=consulta+" and C.ID not in (select ID_C from RESUMEN_VENTAS) ";
		}
		
		public void getDatos()
		{
			//int cont = 0;
			
			consulta=consulta+" order BY RE.FECHA_SALIDA ";
			//consulta=consulta+" group by C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA , C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID, C.OBSERVACIONES ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			int x=0;
			while(conn.leer.Read())
			{
				dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(), conn.leer["COBRO"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["TELEFONO"].ToString(), conn.leer["SALDO"].ToString(), conn.leer["DESTINO"].ToString(), conn.leer["FACTURA"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["NUMERO_FACT"].ToString(), conn.leer["IDENTIFICADOR"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), "E", ((conn.leer["PAGO"].ToString()=="1")?"SI":"NO"), ((conn.leer["fact"].ToString()=="1")?"SI":"NO"), ((conn.leer["INCOBRABLE"].ToString()=="1")?"SI":"NO"), conn.leer["IDCC"].ToString(),conn.leer["anticipo"].ToString(), conn.leer["OBSERVACIONES"].ToString(), ((conn.leer["CASETAS"].ToString()=="N/A")?"0":(conn.leer["CASETAS"]).ToString()), conn.leer["ID_OP"].ToString(), ((conn.leer["OP_COBRA"].ToString()=="1")?"SI":"NO"));
				if(conn.leer["TIPO_VIAJE"].ToString()=="C. PUNTO")
				{
					dgRelacion[5,x].Style.BackColor=Color.Red;
				}
				x++;
			}
			
			conn.conexion.Close();
			
			//getUnidades();
			getOperadores();
			dgRelacion.ClearSelection();
			coloresDatagrid();
			
			txtCantidad.Text="";
			txtTotal.Text="";
		}
		
		public void getDatos2()
		{
			//int cont = 0;
			
			consulta=consulta+" order BY RE.FECHA_SALIDA ";
			//consulta=consulta+" group by C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA , C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID, C.OBSERVACIONES ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			//int x=0;
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
		
		public void getUnidades()
		{
			for(int x=0; x<dgRelacion.Rows.Count; x++)
			{
				String consultUnidad = "SELECT Numero FROM VEHICULO WHERE ID IN (SELECT OO.id_vehiculo FROM COBRO_ESPECIAL C, OPERACION O, OPERACION_OPERADOR OO where C.ID_RUTA_SAL=O.id_ruta AND O.id_operacion=OO.id_operacion AND C.IDENTIFICADOR='"+dgRelacion[10,x].Value.ToString()+"')";
				conn.getAbrirConexion(consultUnidad);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgRelacion[3,x].Value=conn.leer["Numero"].ToString();
				}
				
				conn.conexion.Close();
				
				/*consultUnidad = "SELECT Alias FROM OPERADOR WHERE ID IN (SELECT OO.id_operador FROM COBRO_ESPECIAL C, OPERACION O, OPERACION_OPERADOR OO where C.ID_RUTA_SAL=O.id_ruta AND O.id_operacion=OO.id_operacion AND C.IDENTIFICADOR='"+dgRelacion[10,x].Value.ToString()+"')";
				conn.getAbrirConexion(consultUnidad);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgRelacion[2,x].Value=conn.leer["Alias"].ToString();
				}
				
				conn.conexion.Close();*/
			}
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
		#endregion
				
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
		#endregion
		
		#region keypres txtbusqueda
		void TxtBusquedaKeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		#endregion
		
		#region BUSQUEDA POR CONTENIDO
		void TxtBusquedaKeyUp(object sender, KeyEventArgs e)
		{
			if(txtBusqueda.Text=="")
			{
				obternerConsulta();
				consigueConsulta();
				getDatos();
				getNodesFiltro(columnaselect);
				/*for(int y=1; y<dgRelacion.Columns.Count; y++)
				{
					if(dgRelacion.Columns[y].HeaderText==tvFiltros.Nodes[0].Text)
					{
						getNodesFiltro(y);
					}
				}*/
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
		#endregion
		
		#region EJEMPLO HILOS
		public void prende()
		{
			ThreadStart ts = new ThreadStart(hiloEjecucion);
			hilo = new Thread(ts);
			hilo.Start();
		}
		
		public void prende2()
		{
			ThreadStart ts2 = new ThreadStart(hiloEjecucion2);
			hilo2 = new Thread(ts2);
			hilo2.Start();
		}
		
		public void hiloEjecucion()
		{
			//Thread.Sleep(3000);
			int a=0;
			while(!detener)
			{
				setText("3");
				Thread.Sleep(1000);
				a++;
				if(a==10)
				{
					detener=true;
				}
			}
			detener=false;
		}
		
		public void setText(String dato)
		{
			/*if (this.txt1.InvokeRequired)
			{	
				SetTextCallback d = new SetTextCallback(setText);
				this.Invoke(d, new object[] { dato });
			}
			else
			{
				this.txt1.Text=txt1.Text+dato;
			}*/
		}
		
		public void hiloEjecucion2()
		{
			//Thread.Sleep(3000);
			int a=0;
			while(!detener2)
			{
				setText2("2");
				Thread.Sleep(1000);
				a++;
				if(a==20)
				{
					detener2=true;
				}
			}
			detener2=false;
		}
		
		public void setText2(String dato)
		{
			/*if (this.txt2.InvokeRequired)
			{	
				SetTextCallback d2 = new SetTextCallback(setText);
				this.Invoke(d2, new object[] { dato });
			}
			else
			{
				this.txt2.Text=txt2.Text+dato;
			}*/
		}
		#endregion
		
		#region EVENTOS TREEVIEW
		void DgRelacionDoubleClick(object sender, EventArgs e)
		{
			if(dgRelacion.CurrentRow.Index>-1 && dgRelacion.CurrentCell.ColumnIndex!=19)
			{
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgRelacion[0,dgRelacion.CurrentRow.Index].Value));
				formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();
			}
			else if(dgRelacion.CurrentCell.ColumnIndex==19)
			{
				//new FormCobroCasetas(this, Convert.ToInt64(dgRelacion[0, dgRelacion.CurrentRow.Index].Value)).ShowDialog();
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
					obternerConsulta();
					consigueConsulta();
					getDatos();
					principal=false;
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
				}
			}
			else if(e.Node.Level==1 && principal==false)
			{
				//concatenado(tvFiltros.Nodes[0].Text, e.Node.Text, e.Node.Checked);
				dgRelacion.Rows.Clear();
				concatenado();
			}
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
					//consulta="select C.ID_RE, C.COBRO, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V WHERE C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' "+filtrado;
					// ULTIMA consulta="select C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID IDCC, C.OBSERVACIONES from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP WHERE C.ID_RUTA_SAL=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and (O.estatus='1' or O.estatus='5') and C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' "+filtrado;
					consulta = "select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and C.ESTATUS='1' and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' "+filtrado;
					consigueConsulta();
					getDatos2();
				}
			}
		}
		
		void CbPagadosCheckedChanged(object sender, EventArgs e)
		{
			obternerConsulta();
			consigueConsulta();
			getDatos();
			getNodesFiltro(1);
		}
		
		void CbFacturadosCheckedChanged(object sender, EventArgs e)
		{
			obternerConsulta();
			consigueConsulta();
			getDatos();
			getNodesFiltro(1);
		}
		
		void CbBorradosCheckedChanged(object sender, EventArgs e)
		{
			if(cbBorrados.Checked==true)
			{
				obternerConsulta();
				consigueConsulta();
				getDatos();
				getNodesFiltro(1);
			}
			else
			{
				obternerConsulta();
				consigueConsulta();
				getDatos();
				getNodesFiltro(1);
			}
		}
		
		void consigueConsulta()
		{
			if(cbFacturados.Checked==false)
			{
				consulta=consulta+" and C.FACTURA='0' ";
			}
			
			if(cbPagados.Checked==false)
			{
				consulta=consulta+" and C.PAGO='0' ";
			}
			
			if(cbBorrados.Checked==false)
			{
				consulta=consulta+" and C.BORRADO='0' ";
			}
		}
		#endregion
		
		#region IMPRESION EXCEL
		void CmdExcelClick(object sender, EventArgs e)
		{
			exportaExcel();
		}
		
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
					//int x=0;
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
		
		#region	METODO SUMA
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
		
		void FormCuentasEspMouseEnter(object sender, EventArgs e)
		{
			if(TIPO==3)
			{
				new FormTotalFecha(this).ShowDialog();
			}
		}
		#endregion
		
		#region TP_ANTICIPOS
		#region ELECCION PARA VISUALIZAR TIPO DE ANTICIPOS
		void RbDepositosCheckedChanged(object sender, EventArgs e)
		{
			getServicios();
			if(rbDepositos.Checked==true)
			{
				txtUbica.Enabled=true;
			}
			else
			{
				txtUbica.Text="";
				txtUbica.Enabled=false;
			}
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			getServicios();
		}
		#endregion
		
		void getServicios()
		{
			dgServiciosAnt.Rows.Clear();
			dgAnticipos.Rows.Clear();
			
			String miCons="";
			
			if(rbEfectivo.Checked==true)
			{
				miCons = "select * from RUTA_ESPECIAL where ID_RE IN (select ID_RE from ANTICIPOS_ESPECIALES where TIPO='EFECTIVO' and ESTATUS='0') AND estado='Activo'";
			}
			else
			{
				miCons = "select * from RUTA_ESPECIAL where ID_RE IN (select ID_RE from ANTICIPOS_ESPECIALES where TIPO='DEPOSITO' and ESTATUS='0') AND estado='Activo'";
			}
			conn.getAbrirConexion(miCons);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgServiciosAnt.Rows.Add(conn.leer["ID_RE"].ToString(), conn.leer["DESTINO"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), ((conn.leer["FACTURADO"].ToString()!="0")?"Si":"No"), conn.leer["FACTURA"].ToString());
			}
			
			conn.conexion.Close();
			
			dgServiciosAnt.ClearSelection();
		}
		
		void DgServiciosAntCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				getAnticipos(Convert.ToInt64(dgServiciosAnt[0,e.RowIndex].Value));
			}
		}
		
		void getAnticipos(Int64 id)
		{
			dgAnticipos.Rows.Clear();
			
			String miCons = "";
			
			if(rbEfectivo.Checked==true)
			{
				miCons =  "select * from ANTICIPOS_ESPECIALES where TIPO='EFECTIVO' and ESTATUS='0' and ID_RE="+id;
			}
			else
			{
				miCons =  "select * from ANTICIPOS_ESPECIALES where TIPO='DEPOSITO' and ESTATUS='0' and ID_RE="+id;
			}
			
			conn.getAbrirConexion(miCons);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgAnticipos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["CANTIDAD"].ToString(), conn.leer["NUMERO"].ToString(), conn.leer["cometario"].ToString());
			}
			
			conn.conexion.Close();
			dgAnticipos.ClearSelection();
		}
		
		void CmdConfirmarClick(object sender, EventArgs e)
		{
			if(dgAnticipos.SelectedRows.Count>0)
			{
				String miconsult="update ANTICIPOS_ESPECIALES set ESTATUS='1', ID_U='"+formPrincipal.idUsuario+"', FECHA_CONFIRMADO=(SELECT CONVERT (DATE, SYSDATETIME())), UBICA='"+txtUbica.Text+"' where ID="+dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString();
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				dgAnticipos.Rows.RemoveAt(dgAnticipos.CurrentRow.Index);
				
				dgAnticipos.ClearSelection();
				
				if(dgAnticipos.Rows.Count==0)
				{
					validaCompleto(dgServiciosAnt[0,dgServiciosAnt.CurrentRow.Index].Value.ToString());
					getServicios();
				}
			}
		}
		
		
		void validaCompleto(String ID_RE)
		{
			String consDato = "EXECUTE COSTO_VIAJE "+ID_RE;
			String dato = "";
			bool valida=false;
			
			conn.getAbrirConexion(consDato);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				if(conn.leer["SALDO"].ToString()==conn.leer["TOTAL"].ToString())
				{
					dato="IGUALES= SALDO:"+conn.leer["SALDO"].ToString()+"    TOTAL:"+conn.leer["TOTAL"].ToString();
					MessageBox.Show(dato+" VALIDACION COMPLETA");
					valida=true;
				}
				else
				{
					dato="DIFERENTES= SALDO:"+conn.leer["SALDO"].ToString()+"    TOTAL:"+conn.leer["TOTAL"].ToString();
				}
			}
			
			conn.conexion.Close();
			
			//MessageBox.Show(dato);
			
			if(valida==true)
			{
				String consDat = "update COBRO_ESPECIAL set PAGO='1' where ID_RE="+ID_RE;
						
				conn.getAbrirConexion(consDat);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region CERRADO
		void FormCuentasEspFormClosing(object sender, FormClosingEventArgs e)
		{
			switch(e.CloseReason)
		    {
		        case CloseReason.MdiFormClosing:
					if(dgServiciosAnt.Rows.Count>0)
					{
						if(TIPO==1)
						{
							MessageBox.Show("Existen anticipos sin confirmar.");
						}
					}
					break;
				case CloseReason.ApplicationExitCall:
					if(dgServiciosAnt.Rows.Count>0)
					{
						if(TIPO==1)
						{
							MessageBox.Show("Existen anticipos sin confirmar.");
						}
					}
					break;
				case CloseReason.UserClosing:
					if(TIPO==1)
					{
						if(dgServiciosAnt.Rows.Count>0)
						{
							MessageBox.Show("Existen anticipos sin confirmar.");
						}
					}
					break;					
			}
		}
		#endregion
		
		// *************************************************************************** //
		
		#region CARGA DATOS EN DATAGRID
		void obtenerConsultaFact()
		{
			if(cbMuestraFact.Checked==false)
			{
				consulta2="select RE.NUMERO_ANTI,RE.ID_RE, RE.FACTURA, RE.DESTINO, CS.Nombre, RE.RESPONSABLE, RE.CANT_UNIDADES, RE.tipoVehiculo, RE.FACTURADO, RE.FECHA_SALIDA, RE.CORREO, RE.PRECIO from RUTA_ESPECIAL RE, ContactoServicio CS where RE.ID_C=CS.IdCliente and RE.ID_C in (select IdSubEmpresa from RUTA where TIPO!='cancelada') and RE.FECHA_SALIDA>'2013-07-13' and RE.estado='Activo' and RE.ID_RE not in (select ID_RE from COBRO_ESPECIAL where PAGO='1' and FECHA<'01/12/2013') AND RE.FACTURA LIKE '"+txtRazonSocial.Text+"%' ";
			}
			else
			{
				consulta2="select RE.NUMERO_ANTI, RE.ID_RE, RE.FACTURA, RE.DESTINO, CS.Nombre, RE.RESPONSABLE, RE.CANT_UNIDADES, RE.tipoVehiculo, RE.FACTURADO, RE.FECHA_SALIDA, RE.CORREO, RE.PRECIO from RUTA_ESPECIAL RE, ContactoServicio CS where RE.ID_C=CS.IdCliente and RE.ID_C in (select IdSubEmpresa from RUTA where TIPO!='cancelada') and RE.FECHA_SALIDA>'2013-07-13' and RE.estado='Activo' AND RE.FACTURA LIKE '"+txtRazonSocial.Text+"%' ";
			}
			
			txtRazonSocial.AutoCompleteCustomSource = auto.AutocompleteGeneral(consulta2);
			txtRazonSocial.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtRazonSocial.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			if(cbMuestraFact.Checked==true)
			{
				consulta2=consulta2+" and (RE.FACTURADO='3' or RE.FACTURADO='2') ";
			}
			else
			{
				consulta2=consulta2+" and RE.FACTURADO='2' ";
			}
		}
		
		public void getDatosFact()
		{
			dgEspeciales.Rows.Clear();
			
			conn.getAbrirConexion(consulta2);
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				dgEspeciales.Rows.Add(conn.leer["ID_RE"].ToString(),conn.leer["FACTURA"].ToString(), ((cbMuestraFact.Checked==true)?conn.leer["NUMERO_ANTI"].ToString()+"-":" ")+conn.leer["DESTINO"].ToString(),conn.leer["Nombre"].ToString(), conn.leer["RESPONSABLE"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["CANT_UNIDADES"].ToString(), conn.leer["tipoVehiculo"].ToString(), conn.leer["PRECIO"].ToString(), conn.leer["FACTURADO"].ToString(), "", conn.leer["CORREO"].ToString(), "");
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgEspeciales.Rows.Count; x++)
			{
				String cons = "select * from MENSAJE_FACTURACION_ESP where ID_RE="+dgEspeciales[0,x].Value.ToString();
				conn.getAbrirConexion(cons);
				conn.leer=conn.comando.ExecuteReader();
				
				if(conn.leer.Read())
				{
					dgEspeciales[10,x].Value=conn.leer["MENSAJE"].ToString();
					dgEspeciales[12,x].Value=conn.leer["FACTURA"].ToString();
				}
				else
				{
					dgEspeciales[10,x].Value="";
					dgEspeciales[12,x].Value="";
				}
				
				conn.conexion.Close();
			}
			
			if(cbMuestraFact.Checked==true)
			{
				for(int x=0; x<dgEspeciales.Rows.Count; x++)
				{
					if(dgEspeciales[9,x].Value.ToString()=="3")
					{
						/*for(int y=0; y<dgEspeciales.Columns.Count; y++)
						{
							dgEspeciales[y,x].Style.BackColor=Color.MediumSpringGreen;
						}*/
						
						dgEspeciales[2,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}

			dgEspeciales.ClearSelection();
		}
		#endregion
		
		#region CBFACTURADO
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			obtenerConsultaFact();
			getDatosFact();
			getCanceladosFact();
		}
		#endregion
		
		#region BOTON REALIZADO
		void CmdRealizadoClick(object sender, EventArgs e)
		{
			if(dgEspeciales.SelectedRows.Count>0)
			{
				new Interfaz.Libro.FormTerminoFact(this).ShowDialog();
			}
		}
		#endregion
		
		#region GUARDA DATOS
		public void guardaVarios(string DATO)
		{
			if(dgEspeciales.CurrentRow.Index>-1)
			{
				for(int x=0; x<dgEspeciales.Rows.Count; x++)
				{
					if(dgEspeciales.Rows[x].Selected==true)
					{
						String insert = "INSERT INTO FACTURA_VARIOS VALUES ("+dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value.ToString()+", "+DATO+")" ;
						conn.getAbrirConexion(insert);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
			}
		}
		
		public void guardaDatos(String DATO, bool entrada)
		{
			List<int> rowsSelect = new List<int>();
			
			if(dgEspeciales.CurrentRow.Index>-1)
			{
				for(int x=0; x<dgEspeciales.Rows.Count; x++)
				{
					if(dgEspeciales.Rows[x].Selected==true && dgEspeciales[2,x].Style.BackColor.Name!="MediumSpringGreen")
					{
						String datt = "execute AUDITA_GRAL	'RUTA_ESPECIAL', "+dgEspeciales[0,x].Value.ToString()+", 'UPDATE', "+formPrincipal.idUsuario;
						conn.getAbrirConexion(datt);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
						
						conn.getAbrirConexion("UPDATE RUTA_ESPECIAL SET FACTURADO='3', NUMERO_ANTI='"+DATO+"' WHERE ID_RE="+dgEspeciales[0,x].Value.ToString());
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
						
						if(entrada==true)
						{
							conn.getAbrirConexion("update COBRO_ESPECIAL set FACTURA='1', NUMERO_FACT='"+DATO+"' where ID_RE="+dgEspeciales[0,x].Value.ToString());
							conn.comando.ExecuteNonQuery();	
							conn.conexion.Close();
							
							rowsSelect.Add(x);
							
							// ***** revisar una auditoria ***** //
							/*conn.getAbrirConexion("INSERT INTO AUDITA_COBRO_ESP VALUES ('"+dgFacturas[0,x].Value.ToString()+"', 'FACTURA2', '"+txtDato.Text+"', '"+refPrincipal.formPrincipal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))");
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();*/
						}
					}
				}
				
				obternerConsulta();
				consigueConsulta();
				getDatos();
				getNodesFiltro(1);
				
				for(int x=rowsSelect.Count-1; x>-1; x--)
				{
					dgEspeciales.Rows.RemoveAt(rowsSelect[x]);
				}
				
				dgEspeciales.ClearSelection();
			}
		}
		
		public void Eliminar()
		{
			if(dgEspeciales.CurrentRow.Index>-1)
			{
				for(int x=0; x<dgEspeciales.Rows.Count; x++)
				{
					if(dgEspeciales.Rows[x].Selected==true)
					{
						conn.getAbrirConexion("UPDATE RUTA_ESPECIAL SET FACTURADO='3' WHERE ID_RE="+dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value.ToString());
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
				
				if(cbMuestraFact.Checked==false)
				{
					for(int x=dgEspeciales.Rows.Count-1; x>-1; x--)
					{
						if(dgEspeciales.Rows[x].Selected==true)
						{
							dgEspeciales.Rows.RemoveAt(dgEspeciales.CurrentRow.Index);
						}
					}
				}
			}
		}
		#endregion
		
		void DgEspecialesDoubleClick(object sender, EventArgs e)
		{
			new Interfaz.Libro.FormDatosFactura(4, dgEspeciales[1,dgEspeciales.CurrentRow.Index].Value.ToString(), dgEspeciales[11,dgEspeciales.CurrentRow.Index].Value.ToString()).ShowDialog();
		}
		
		void CmdDatosClick(object sender, EventArgs e)
		{
			if(dgEspeciales.SelectedRows.Count>0)
			{
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgEspeciales[0,dgEspeciales.CurrentRow.Index].Value));
				formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();
				
				txtMsj.Text="";
			}
		}
		
		#region CANCELADOS EN EL PUNTO DE FACTURACION
		void getCanceladosFact()
		{
			for(int x=0; x<dgEspeciales.Rows.Count; x++)
			{
				String cons = "select R.* from RUTA_ESPECIAL RE, RUTA R, CANCELACION_PUNTO C where IdSubEmpresa=RE.ID_C and ID_RE="+dgEspeciales[0,x].Value.ToString()+" and C.ID_RUTA=R.ID";
				conn.getAbrirConexion(cons);
				conn.leer=conn.comando.ExecuteReader();
				
				if(conn.leer.Read())
				{
					dgEspeciales[8,x].Value="?";
					dgEspeciales[8,x].Style.BackColor=Color.Red;
				}
				
				conn.conexion.Close();
			}
			
			
			for(int x=0; x<dgEspeciales.Rows.Count; x++)
			{
				if(dgEspeciales[8,x].Value.ToString()=="?")
				{
					dgEspeciales[8,x].Value="0";
					String cons = "select * from COBRO_ESPECIAL where ID_RE = "+dgEspeciales[0,x].Value.ToString();
					conn.getAbrirConexion(cons);
					conn.leer=conn.comando.ExecuteReader();
					
					while(conn.leer.Read())
					{
						dgEspeciales[8,x].Value=Convert.ToDouble(dgEspeciales[8,x].Value)+Convert.ToDouble(conn.leer["SALDO"]);
					}
					
					conn.conexion.Close();
					
					if(dgEspeciales[8,x].Value.ToString()=="0")
					{
						dgEspeciales[8,x].Value="?";
					}
				}
			}
		}
		#endregion
		
		#region GET COMENTARIO
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
		}
		#endregion
		
		void DgEspecialesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				if(dgEspeciales.SelectedRows.Count==1)
					txtMsj.Text=dgEspeciales[10,e.RowIndex].Value.ToString();
			}
		}
		
		void DgEspecialesSelectionChanged(object sender, EventArgs e)
		{
			int total=0;
			
			for(int x=0; x<dgEspeciales.Rows.Count; x++)
			{
				if(dgEspeciales.Rows[x].Selected==true)
				{
					total=total+Convert.ToInt16(dgEspeciales[6,x].Value);
				}
			}
			//**************************************
			txtConteo.Text=total.ToString();
		}
		
		void CmdModTipoClick(object sender, EventArgs e)
		{
			String dato = "";
			if(rbEfectivo.Checked==true)
				dato="DEPOSITO";
			else
				dato="EFECTIVO";
			
			String sentenc = "UPDATE ANTICIPOS_ESPECIALES SET TIPO='"+dato+"' WHERE ID="+dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString();
						
			conn.getAbrirConexion(sentenc);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			getServicios();
		}
		
		void CmdModFechaClick(object sender, EventArgs e)
		{
			String sentenc = "UPDATE ANTICIPOS_ESPECIALES SET FECHA='"+dtpFecha.Value.ToString("dd/MM/yyyy")+"' WHERE ID="+dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString();
						
			conn.getAbrirConexion(sentenc);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			dgAnticipos[1,dgAnticipos.CurrentRow.Index].Value=dtpFecha.Value.ToString("dd/MM/yyyy");
		}
		
		void DgAnticiposCellClick(object sender, DataGridViewCellEventArgs e)
		{
			dtpFecha.Value=Convert.ToDateTime(dgAnticipos[1,dgAnticipos.CurrentRow.Index].Value.ToString());
			txtComentAnt.Text=dgAnticipos[4,e.RowIndex].Value.ToString();
			txtNumero.Text=dgAnticipos[3,e.RowIndex].Value.ToString();
			
			String dato = "Cambiar a";
			if(rbEfectivo.Checked==true)
				dato=dato+" 'Deposito'";
			else
				dato=dato+" 'Efectivo'";
			
			lblModifica.Text=dato;
		}
		
		void CmdModComentClick(object sender, EventArgs e)
		{
			String sentenc = "update ANTICIPOS_ESPECIALES set cometario='"+txtComentAnt.Text+"' where ID="+dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString();
						
			conn.getAbrirConexion(sentenc);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			txtComentAnt.Text="";
			getAnticipos(Convert.ToInt64(dgServiciosAnt[0,dgServiciosAnt.CurrentRow.Index].Value));
			dgAnticipos.ClearSelection();
		}
		
		void CmdModNumeroClick(object sender, EventArgs e)
		{
			String sentenc = "update ANTICIPOS_ESPECIALES set NUMERO='"+txtNumero.Text+"' where ID="+dgAnticipos[0,dgAnticipos.CurrentRow.Index].Value.ToString();
						
			conn.getAbrirConexion(sentenc);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			txtNumero.Text="";
			getAnticipos(Convert.ToInt64(dgServiciosAnt[0,dgServiciosAnt.CurrentRow.Index].Value));
			dgAnticipos.ClearSelection();
		}
		
		void TxtRazonSocialTextChanged(object sender, EventArgs e)
		{
			obtenerConsultaFact();
			getDatosFact();
			getCanceladosFact();
		}
		
		void DgServiciosAntDoubleClick(object sender, EventArgs e)
		{
			if(dgServiciosAnt.Rows.Count>0)
			{
				if(dgServiciosAnt.CurrentCell.ColumnIndex==3 && dgServiciosAnt[3,dgServiciosAnt.CurrentRow.Index].Value.ToString()=="Si")
				{
					new Interfaz.Libro.FormDatosFactura(3,dgServiciosAnt[4,dgServiciosAnt.CurrentRow.Index].Value.ToString()).ShowDialog();
				}
			}
		}
	}
}