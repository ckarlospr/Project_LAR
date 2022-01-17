using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using NumeroLetras;
using System.Collections.Generic; 
using System.Globalization;

namespace Transportes_LAR.Interfaz.Nomina.Recibo
{
	public partial class FormRecibo : Form
	{
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		Interfaz.Nomina.FormNomina formnomina = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Proceso.PDF PDFs = new Transportes_LAR.Proceso.PDF();	
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		public List<Interfaz.Nomina.Dato.Nomina> listNomina = null;
		#endregion
		
		#region VARIABLES
		int x = 0;
		int DiasTrabajados = 0;
		double TotalDeducciones = 0.0;
		double Compesacion = 0.0;
		double Retener = 0.0;
		String Nombre = "";
		String NombrePatron = "";
		String NS = "";
		String FechaHoy = DateTime.Now.ToString("yyyy-MM-dd");
		String Fechecarpeta = "";
		String Alias="";
		DateTime FechaInicio;
		DateTime FechaCorte;
		DateTime FechaInicioR;
		DateTime FechaCorteR;
		DateTime FechaInicioIncapacidad;
		DateTime FechaCorteIncapacidad;
		TimeSpan tsI01;
		TimeSpan tsI02;
		TimeSpan tsI03;
		String[,] Hoja = new String[1000,20];
		#endregion
		
		#region CONSTRUCTORES
		public FormRecibo()
		{
			InitializeComponent();
		}
		
		public FormRecibo(Interfaz.FormPrincipal principal, String FechaInicioC, String FechaCorteC, Interfaz.Nomina.FormNomina formnomina)
		{
			InitializeComponent();
			this.principal=principal;
			this.formnomina = formnomina;
			dtInicio.Value = (Convert.ToDateTime(FechaInicioC.Substring(0,10)));
			dtFin.Value = (Convert.ToDateTime(FechaCorteC.Substring(0,10)));
			FechaInicioR = (Convert.ToDateTime(FechaInicioC.Substring(0,10)));
			FechaCorteR = (Convert.ToDateTime(FechaCorteC.Substring(0,10)));
			FechaInicio = dtInicio.Value;
			FechaCorte = dtFin.Value;
		}
		#endregion
		
		#region DATOS
		void Empleado(String id_operador)
		{
			conn.getAbrirConexion("select Alias, Nombre, Apellido_Pat, Apellido_Mat, tipo_empleado " +
				                      "from OPERADOR " +
				                      "WHERE ID ="+id_operador);
			conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					Nombre = conn.leer["Apellido_Pat"].ToString()+" "+conn.leer["Apellido_Mat"].ToString()+" "+conn.leer["Nombre"].ToString();
					txtNombreCompleto.Text = Nombre;
					txtPuesto.Text = conn.leer["tipo_empleado"].ToString();
					Alias = conn.leer["Alias"].ToString();
				}
			conn.conexion.Close();
		}
		
		void Patron(String id_patron)
		{
			int booleano = 0;
			txtPatron.Text = "";
			NombrePatron = "";
			String Planta = "";
			
			conn.getAbrirConexion("select * from OperadorContrato WHERE  TipoContrato = 'Planta'  and IdOperador ="+ id_patron);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Planta = "Planta";
			}
			conn.conexion.Close();
			
			if(Planta != "Planta"){
				conn.getAbrirConexion("select NombrePatron, ns_patron " +
				                      "from OperadorContrato " +
				                      "WHERE FechaInicioContrato<='"+dtInicio.Value.ToShortDateString()+"' and fecha_vencimiento>='"+dtInicio.Value.ToShortDateString()+"' and TipoContrato!='Planta' and IdOperador ="+id_patron);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NombrePatron = conn.leer["NombrePatron"].ToString();
					NS = conn.leer["ns_patron"].ToString();
					txtPatron.Text = NombrePatron;
					txtNs.Text = NS;
					booleano = 1;
				}
				conn.conexion.Close();
			}
			
			if(NombrePatron==String.Empty)
			{
				conn.getAbrirConexion("select TOP 1 NombrePatron, ns_patron " +
				                      "from OperadorContrato " +
				                      "WHERE TipoContrato!='Planta' and IdOperador ="+id_patron+""+
				                      "ORDER BY ID DESC");
					conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NombrePatron = conn.leer["NombrePatron"].ToString();
					NS = conn.leer["ns_patron"].ToString();
					txtPatron.Text = NombrePatron;
					txtNs.Text = NS;
					booleano = 1;
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select * from OperadorContrato WHERE  TipoContrato = 'Planta'  and IdOperador ="+ id_patron);
					conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					booleano = 0;
				}
				conn.conexion.Close();
			}
			
			if(booleano!=1)
			{
				conn.getAbrirConexion("select NombrePatron, ns_patron " +
				                      "from OperadorContrato " +
				                      "WHERE TipoContrato='Planta' and IdOperador ="+id_patron);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					NombrePatron = conn.leer["NombrePatron"].ToString();
					NS = conn.leer["ns_patron"].ToString();
					txtPatron.Text = NombrePatron;
					txtNs.Text = NS;
				}
				conn.conexion.Close();
			}
		}
		
		void SueldoEmpleado(String id_operador)
		{
			Compesacion = 0.0;
			Retener = 0.0;
			txtAguinaldo.Text = "0.0";
			conn.getAbrirConexion("Select O.CURP, O.RFC, O.IMSS, S.IMSS AS VALORIMSS, S.ISR, S.INFONAVIT, S.SUELDO_BASE, S.Aguinaldo, S.Retener, S.Compensacion " +
				                      "from OPERADOR O, SUELDO S " +
				                      "where O.ID=S.ID_OPERADOR AND O.ID ="+id_operador);
			conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					txtCurp.Text = conn.leer["CURP"].ToString();
					txtRfc.Text = conn.leer["RFC"].ToString();
					txtNumImss.Text = conn.leer["IMSS"].ToString();
					txtIsr.Text = conn.leer["ISR"].ToString();
					txtInfonavit.Text = conn.leer["INFONAVIT"].ToString();
					txtSueldo.Text = conn.leer["SUELDO_BASE"].ToString();
					txtAguinaldo.Text = conn.leer["Aguinaldo"].ToString();
					Compesacion = (Convert.ToDouble(conn.leer["Compensacion"]));
					Retener = (Convert.ToDouble(conn.leer["Retener"]));
				}
			conn.conexion.Close();
		}
		
		void Proceso(int x)
		{
			CalculoDiasTrabajados();
			LlenadoDataGrid();
			DatosOperador(x);
			FechaIngreso(x);
			PatronOperador(x);
			CalcularSueldo();
		}
		
		void DatosOperador(int x)
		{
			if(tabOperadores.SelectedIndex==0)
				Empleado(dtOperador[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==1)
				Empleado(dtOperador2[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==3)
				Empleado(dtOperadorPrima[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==2)
				Empleado(dataAdministrativos[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==4)
				Empleado(dataAguinaldo[0,x].Value.ToString());
		}
		
		void FechaIngreso(int x)
		{
			txtFechaIngreso.Text =  "Temporal";
			if(tabOperadores.SelectedIndex==0)
				txtFechaIngreso.Text =  new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(dtOperador[0,x].Value.ToString());
			else if(tabOperadores.SelectedIndex==1)
				txtFechaIngreso.Text =  new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(dtOperador2[0,x].Value.ToString());
			else if(tabOperadores.SelectedIndex==2)
				txtFechaIngreso.Text =  new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(dataAdministrativos[0,x].Value.ToString());
			else if(tabOperadores.SelectedIndex==3)
				txtFechaIngreso.Text =  new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(dtOperadorPrima[0,x].Value.ToString());
			else if(tabOperadores.SelectedIndex==4)
				txtFechaIngreso.Text =  new Conexion_Servidor.Nomina.SQL_Recibo().FechaIngreso(dataAguinaldo[0,x].Value.ToString());
		}
		
		void DiasIncapacidades(int x)
		{
			bool boolInicio = false;
			bool boolFin = false;
			bool boolAmbos = false;
			bool boolIncapacitado = false;
			
			if(tabOperadores.SelectedIndex==0)
			{
				conn.getAbrirConexion("select FECHA_INICIO " +
				                      "from INCAPACIDAD " +
				                      "WHERE FECHA_INICIO BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+dtOperador[0,x].Value);
				conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						FechaInicioIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString().Substring(0,10)));
						tsI01 = FechaCorte - FechaInicioIncapacidad;
						boolInicio = true;
					}			
				conn.conexion.Close();
					
				conn.getAbrirConexion("select FECHA_FIN " +
				                      "from INCAPACIDAD " +
				                      "WHERE FECHA_FIN BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+dtOperador[0,x].Value);
				conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						FechaCorteIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_FIN"].ToString().Substring(0,10)));
						tsI02 = FechaCorteIncapacidad - FechaInicio;
						boolFin = true;
					}		
				conn.conexion.Close();
					
				conn.getAbrirConexion("select FECHA_FIN, FECHA_INICIO " +
				                      "from INCAPACIDAD " +
				                      "WHERE FECHA_FIN BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and FECHA_INICIO BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+dtOperador[0,x].Value);
				conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						FechaCorteIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_FIN"].ToString().Substring(0,10)));
						FechaInicioIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString().Substring(0,10)));
						tsI03 = FechaCorteIncapacidad - FechaInicioIncapacidad;
						boolAmbos = true;
					}		
				conn.conexion.Close();
					
				conn.getAbrirConexion("select FECHA_FIN, FECHA_INICIO " +
				                      "from INCAPACIDAD " +
				                      "WHERE FECHA_FIN >'"+FechaInicio.ToString().Substring(0,10)+"' and FECHA_INICIO <'"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+dtOperador[0,x].Value);
				conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						boolIncapacitado = true;
					}		
				conn.conexion.Close();
				
					if((boolInicio == true)&&(boolFin == false))
					{
					dataPercepciones.Rows[0].Cells[2].Value = tsI01.Days + 1;
					}
					else if((boolInicio == false)&&(boolFin == true))
					{
					dataPercepciones.Rows[0].Cells[2].Value = tsI02.Days + 1;
					}
					else if(boolAmbos == true)
					{
					dataPercepciones.Rows[0].Cells[2].Value = tsI03.Days + 1;
					}
					else if(boolIncapacitado == true)
					{
					dataPercepciones.Rows[0].Cells[2].Value = 14;
					}
			}
		}
		
		void PatronOperador(int x)
		{
			if(tabOperadores.SelectedIndex==0)
				Patron(dtOperador[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==1)
				Patron(dtOperador2[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==3)
				Patron(dtOperadorPrima[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==2)
				Patron(dataAdministrativos[0,x].Value.ToString());
			if(tabOperadores.SelectedIndex==4)
				Patron(dataAguinaldo[0,x].Value.ToString());
		}
		
		#endregion
		
		#region INICIO - CERRADO
		void FormReciboLoad(object sender, EventArgs e)
		{
			cmbTipoOpAguinaldo.SelectedIndex = 0;
			Adaptadores();
			CalculoDiasTrabajados();
			Fechecarpeta = dtInicio.Value.ToString("yyyy-MM-dd")+" al "+dtFin.Value.ToString("yyyy-MM-dd");
			txtPrima.Text = new Conexion_Servidor.Nomina.SQL_Recibo().PrimaVacacional().ToString();
			tabOperadores.SelectedIndex = 1;
			tabOperadores.SelectedIndex = 2;
			tabOperadores.SelectedIndex = 3;
			tabOperadores.SelectedIndex = 4;
			tabOperadores.SelectedIndex = 5;
			tabOperadores.SelectedIndex = 0;
		}
		
		void FormReciboFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.recibos = false;
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptadores()
		{
			dtOperador.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.ID, O.alias as Alias_Op, O.tipo_empleado " +
			                                                                               "from OPERADOR O, OperadorContrato OC " +
			                                                                               "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' " +
			                                                                               "AND O.tipo_empleado='OPERADOR' and O.ID not in "+
												                                                                               "(select O.ID " +
												                                                                               "from OPERADOR O, OperadorContrato OC " +
												                                                                               "where O.ID=OC.IdOperador and O.Estatus='1' and OC.TipoContrato='Temporal' and O.Alias!='Admvo' and O.ID NOT IN (SELECT O.ID FROM OPERADOR O, OperadorContrato OC where O.ID=OC.IdOperador and OC.TipoContrato='Planta')" +
												                                                                               " and ((OC.FechaInicioContrato BETWEEN '"+(Convert.ToDateTime(FechaInicio)).AddDays(1).ToString().Substring(0,10)+"' and '"+FechaCorte.AddDays(-1).ToString().Substring(0,10)+"') or " +
												                                                                               "(OC.fecha_vencimiento BETWEEN '"+(Convert.ToDateTime(FechaInicio)).AddDays(1).ToString().Substring(0,10)+"' and '"+FechaCorte.AddDays(-1).ToString().Substring(0,10)+"'))"+
																															   "group by O.ID) " +
			                                                                               "group by O.ID, O.alias, O.tipo_empleado order by O.alias");
			
			//AdaptadorVencimientoOperador(dtOperador2, " tipo_empleado='OPERADOR' ", "'"+(Convert.ToDateTime(FechaInicio)).AddDays(1).ToString().Substring(0,10)+"' and '"+(Convert.ToDateTime(FechaCorte)).AddDays(0).ToString().Substring(0,10)+"'", FechaInicio, FechaCorte);
			AdaptadorVencimientoOperador(dtOperador2, " tipo_empleado='OPERADOR' ", "'"+(Convert.ToDateTime(FechaInicio)).AddDays(1).ToString().Substring(0,10)+"' and '"+(Convert.ToDateTime(FechaCorte)).AddDays(-1).ToString().Substring(0,10)+"'", FechaInicio, FechaCorte);
			
			AdaptadorPlanta();
			dataAdministrativos.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.ID, O.alias as Alias_Op, O.tipo_empleado " +
			                                                                                        "from OPERADOR O, OperadorContrato OC " +
			                                                                                        "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' " +
			                                                                                        "AND O.tipo_empleado!='OPERADOR' " +
			                                                                                        "group by O.ID, O.alias, O.tipo_empleado order by O.alias");
			AdaptadorAguinaldo();
		}
			
		void AdaptadorVencimientoOperador(DataGridView dtOperador2, String tipoEmpleado, String FechaVen, DateTime FechaInicio, DateTime FechaCorte)
		{
			int contador = 0;
			
			dtOperador2.Rows.Clear();
			dtOperador2.ClearSelection();
			/*
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' " +
			                      "and "+tipoEmpleado+" AND OC.TipoContrato='Temporal' " +
			                      "and OC.fecha_vencimiento BETWEEN "+FechaVen+" and O.ID not in " +
		                                                                               "(select IdOperador " +
		                                                                               "from OperadorContrato " +
		                                                                               "where TipoContrato='Planta') " +
			                      "group by O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento " +
			                      "order by O.Alias, OC.fecha_vencimiento");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador2.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dtOperador2.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				dtOperador2.Rows[contador].Cells[3].Value = FechaInicio.ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = (Convert.ToDateTime(conn.leer["fecha_vencimiento"]).AddDays(-1)).ToString().Substring(0,10);
				++contador;
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = dtOperador2.Rows[contador-1].Cells[0].Value;
				dtOperador2.Rows[contador].Cells[1].Value = dtOperador2.Rows[contador-1].Cells[1].Value+"2";
				dtOperador2.Rows[contador].Cells[2].Value = dtOperador2.Rows[contador-1].Cells[2].Value;
				dtOperador2.Rows[contador].Cells[3].Value = (Convert.ToDateTime(dtOperador2.Rows[contador-1].Cells[4].Value).AddDays(1)).ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = FechaCorte.ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();*/
			
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' " +
			                      "and "+tipoEmpleado+" AND OC.TipoContrato='Temporal' " +
			                      "and OC.fecha_vencimiento BETWEEN '"+(Convert.ToDateTime(FechaInicio)).AddDays(0).ToString().Substring(0,10)+"' and '"+(Convert.ToDateTime(FechaCorte)).AddDays(-1).ToString().Substring(0,10)+"' and O.ID not in " +
		                                                                               "(select IdOperador " +
		                                                                               "from OperadorContrato " +
		                                                                               "where TipoContrato='Planta') " +
			                      "group by O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento " +
			                      "order by O.Alias, OC.fecha_vencimiento");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador2.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dtOperador2.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				dtOperador2.Rows[contador].Cells[3].Value = FechaInicio.ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = (Convert.ToDateTime(conn.leer["fecha_vencimiento"]).AddDays(0)).ToString().Substring(0,10);
				++contador;
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = dtOperador2.Rows[contador-1].Cells[0].Value;
				dtOperador2.Rows[contador].Cells[1].Value = dtOperador2.Rows[contador-1].Cells[1].Value+"2";
				dtOperador2.Rows[contador].Cells[2].Value = dtOperador2.Rows[contador-1].Cells[2].Value;
				dtOperador2.Rows[contador].Cells[3].Value = (Convert.ToDateTime(dtOperador2.Rows[contador-1].Cells[4].Value).AddDays(1)).ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = FechaCorte.ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();
		
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, OC.FechaInicioContrato " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and  "+tipoEmpleado+" and O.Alias!='Admvo' " +
			                      "AND OC.TipoContrato='Temporal' and " +
			                      "OC.FechaInicioContrato BETWEEN "+FechaVen+" and O.ID not in " +
	                                                                               "(select IdOperador " +
	                                                                               "from OperadorContrato " +
	                                                                               "where TipoContrato='Planta') and O.ID not in " +
			                      	"(select O.ID from OPERADOR O, OperadorContrato OC where O.ID=OC.IdOperador and " +
			                      "OC.fecha_vencimiento BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"')" +
			                      "group by O.ID, O.Alias, O.tipo_empleado, OC.FechaInicioContrato " +
			                      "order by O.Alias, OC.FechaInicioContrato");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador2.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString()+"2";
				dtOperador2.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				dtOperador2.Rows[contador].Cells[3].Value = conn.leer["FechaInicioContrato"].ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = FechaCorte.ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();
		}
		
		void AdaptadorVencimientoEmpleado(DataGridView dtOperador2, String tipoEmpleado, String FechaVen, DateTime FechaInicio, DateTime FechaCorte)
		{
			int contador = 0;
			
			dtOperador2.Rows.Clear();
			dtOperador2.ClearSelection();
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' " +
			                      "and "+tipoEmpleado+" AND OC.TipoContrato='Temporal' " +
			                      "and OC.fecha_vencimiento BETWEEN "+FechaVen+"and O.ID not in " +
		                                                                               "(select IdOperador " +
		                                                                               "from OperadorContrato " +
		                                                                               "where TipoContrato='Planta') " +
			                      "group by O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento " +
			                      "order by O.Alias, OC.fecha_vencimiento");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador2.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dtOperador2.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				dtOperador2.Rows[contador].Cells[3].Value = FechaInicio.ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = (Convert.ToDateTime(conn.leer["fecha_vencimiento"]).AddDays(-1)).ToString().Substring(0,10);
				++contador;
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = dtOperador2.Rows[contador-1].Cells[0].Value;
				dtOperador2.Rows[contador].Cells[1].Value = dtOperador2.Rows[contador-1].Cells[1].Value+"2";
				dtOperador2.Rows[contador].Cells[2].Value = dtOperador2.Rows[contador-1].Cells[2].Value;
				dtOperador2.Rows[contador].Cells[3].Value = (Convert.ToDateTime(dtOperador2.Rows[contador-1].Cells[4].Value).AddDays(1)).ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = FechaCorte.ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();
		
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, OC.FechaInicioContrato " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and  "+tipoEmpleado+" and O.Alias!='Admvo' " +
			                      "AND OC.TipoContrato='Temporal' and " +
			                      "OC.FechaInicioContrato BETWEEN "+FechaVen+" and O.ID not in " +
                                                                               "(select IdOperador " +
                                                                               "from OperadorContrato " +
                                                                               "where TipoContrato='Planta') and O.ID not in " +
			                      	"(select O.ID from OPERADOR O, OperadorContrato OC where O.ID=OC.IdOperador and " +
			                      "OC.fecha_vencimiento BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"')" +
			                      "group by O.ID, O.Alias, O.tipo_empleado, OC.FechaInicioContrato " +
			                      "order by O.Alias, OC.FechaInicioContrato");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador2.Rows.Add();
				dtOperador2.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador2.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString()+"2";
				dtOperador2.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				dtOperador2.Rows[contador].Cells[3].Value = conn.leer["FechaInicioContrato"].ToString().Substring(0,10);
				dtOperador2.Rows[contador].Cells[4].Value = FechaCorte.ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();
		}
		
		void AdaptadorPlanta()
		{
			int contador = 0;
			DateTime FechaInicioPlanta;
		
			dtOperadorPrima.Rows.Clear();
			dtOperadorPrima.ClearSelection();
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, min(OC.FechaInicioContrato) as Ingreso " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and tipo_empleado='OPERADOR' " +
			                      "and O.Alias!='Admvo' " +
			                      "group by O.ID, O.Alias, O.tipo_empleado " +
			                      "order by O.Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperadorPrima.Rows.Add();
				dtOperadorPrima.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperadorPrima.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dtOperadorPrima.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				FechaInicioPlanta = (Convert.ToDateTime(conn.leer["Ingreso"].ToString().Substring(0,10)));
				TimeSpan ts = FechaCorte - FechaInicioPlanta;
				dtOperadorPrima.Rows[contador].Cells[3].Value = ts.Days + 1;
				
				if((Convert.ToInt32(dtOperadorPrima.Rows[contador].Cells[3].Value))<104)
				{
					dtOperadorPrima.Rows[contador].Cells[1].Style.BackColor = Color.SteelBlue;
					dtOperadorPrima.Rows[contador].Cells[3].Style.BackColor = Color.SteelBlue;
				}
				++contador;
			}
			conn.conexion.Close();
		}
		
		void AdaptadorAguinaldo()
		{
			int contador = 0;
			DateTime FechaInicioAguinaldo;
			String tipoOp = "O.tipo_empleado='OPERADOR'";
			
			if(cmbTipoOpAguinaldo.Text=="Operador")
				tipoOp = "O.tipo_empleado='OPERADOR'";
			else
				tipoOp = "O.tipo_empleado!='OPERADOR'";
			
			dataAguinaldo.Rows.Clear();
			dataAguinaldo.ClearSelection();
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, min(OC.FechaInicioContrato) as Fecha " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and " + tipoOp + " "+
			                      "and O.Alias!='Admvo' " +
			                      "group by O.ID, O.Alias, O.tipo_empleado " +
			                      "order by O.Alias ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataAguinaldo.Rows.Add();
				dataAguinaldo.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataAguinaldo.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dataAguinaldo.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				FechaInicioAguinaldo = (Convert.ToDateTime(conn.leer["Fecha"].ToString().Substring(0,10)));
				TimeSpan ts = FechaCorte - FechaInicioAguinaldo;
				dataAguinaldo.Rows[contador].Cells[3].Value = ts.Days + 1;
				
				if((Convert.ToInt32(dataAguinaldo.Rows[contador].Cells[3].Value))<60)
				{
					dataAguinaldo.Rows[contador].Cells[1].Style.BackColor = Color.SteelBlue;
					dataAguinaldo.Rows[contador].Cells[2].Style.BackColor = Color.SteelBlue;
					dataAguinaldo.Rows[contador].Cells[3].Style.BackColor = Color.SteelBlue;
				}
				++contador;
			}
			conn.conexion.Close();
		}
		
		void CmbTipoOpAguinaldoSelectedIndexChanged(object sender, EventArgs e)
		{
			AdaptadorAguinaldo();
		}
		#endregion
		
		#region EVENTO PRINCIPAL
		void DtOperadorCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(tabOperadores.SelectedIndex==0)
			{
				int x = 0;
				if(e.RowIndex>-1)
				{
					x = dtOperador.CurrentRow.Index;
					this.x = x;
					MetodoPrincipal(x);
				}
			}
		}
		
		void DtOperador2CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(tabOperadores.SelectedIndex==1)
			{
				int x = 0;
				if(e.RowIndex>-1)
				{
					x = dtOperador2.CurrentRow.Index;
					this.x = x;
					MetodoPrincipal(x);
				}
			}
		}
		
		void DtOperadorPlantaCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(tabOperadores.SelectedIndex==3)
			{
				int x = 0;
				if(e.RowIndex>-1)
				{
					x = dtOperadorPrima.CurrentRow.Index;
					this.x = x;
					MetodoPrincipal(x);
				}
			}
		}
		
		void DataAdministrativosCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(tabOperadores.SelectedIndex==2)
			{
				int x = 0;
				if(e.RowIndex>-1)
				{
					x = dataAdministrativos.CurrentRow.Index;
					this.x = x;
					MetodoPrincipal(x);
				}
			}
		}
		
		void DataAguinaldoCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(tabOperadores.SelectedIndex==4)
			{
				int x = 0;
				if(e.RowIndex>-1)
				{
					x = dataAguinaldo.CurrentRow.Index;
					this.x = x;
					MetodoPrincipal(x);
				}
			}
		}
		#endregion
		
		#region METODO PRINCIPAL
		void MetodoPrincipal(int x)
		{
			dataPercepciones.Rows[0].Cells[2].Value = 0;
			if(tabOperadores.SelectedIndex==0)
			{
				SueldoEmpleado(dtOperador[0,x].Value.ToString());
				DiasIncapacidades(x);
				Proceso(x);
			}
			if(tabOperadores.SelectedIndex==1)
			{
				SueldoEmpleado(dtOperador2[0,x].Value.ToString());
				dtInicio.Value = (Convert.ToDateTime(dtOperador2.Rows[x].Cells[3].Value));
				dtFin.Value = (Convert.ToDateTime(dtOperador2.Rows[x].Cells[4].Value));
				Proceso(x);
			}
			if(tabOperadores.SelectedIndex==3)
			{
				SueldoEmpleado(dtOperadorPrima[0,x].Value.ToString());
				Proceso(x);
			}
			if(tabOperadores.SelectedIndex==2)
			{
				SueldoEmpleado(dataAdministrativos[0,x].Value.ToString());
				Proceso(x);
			}
			if(tabOperadores.SelectedIndex==4)
			{
				if(dataAguinaldo[0,x].Value!=null)
				{
					SueldoEmpleado(dataAguinaldo[0,x].Value.ToString());
					Proceso(x);
				}
			}
		}
		#endregion
		
		#region BOTONES
		void BtnImprimirPDFsClick(object sender, EventArgs e)
		{
			if(tabOperadores.SelectedIndex==0)
				ImprimirTodosPDF(dtOperador);
			else if(tabOperadores.SelectedIndex==1)
				ImprimirTodosPDF(dtOperador2);
			else if(tabOperadores.SelectedIndex==3)
				ImprimirTodosPDF(dtOperadorPrima);
			else if(tabOperadores.SelectedIndex==2)
	        	ImprimirTodosPDF(dataAdministrativos);
			else if(tabOperadores.SelectedIndex==4)
				ImprimirTodosPDF(dataAguinaldo);
		}
		#endregion
		
		#region IMPRIMIR TODOS LOS PDF´s
		void ImprimirTodosPDF(DataGridView data)
		{
			for(int x=0; x<data.Rows.Count; x++)
			{
				if(data.Rows[x].Cells[1].Style.BackColor.Name!="SteelBlue")
				{
					principal.progressbarPrin.Minimum = 1;
		    		principal.progressbarPrin.Maximum = data.Rows.Count; 
		    		this.x = x;
					if(x>0)
					{
						data.Rows[x-1].Selected = false;
					}
					data.Rows[x].Selected = true;
					listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(data[0,x].Value.ToString());
					String Unidad = listNomina[0].Unidad;
					MetodoPrincipal(x);
					CalcularSueldo();
					CalcularSueldo();
					CalcularSueldo();
					Hoja[x,0] = txtNombreCompleto.Text;
					Hoja[x,1] = txtSueldo.Text;
					Hoja[x,2] = txtDiasTrabajados.Text;
					Hoja[x,3] = dataPercepciones.Rows[0].Cells[0].Value.ToString();
					Hoja[x,4] = dataPercepciones.Rows[0].Cells[5].Value.ToString();
					Hoja[x,5] = dataPercepciones.Rows[0].Cells[6].Value.ToString();
					Hoja[x,6] = dataPercepciones.Rows[0].Cells[7].Value.ToString();
					Hoja[x,7] = dataPercepciones.Rows[0].Cells[4].Value.ToString();
					Hoja[x,8] = dataPercepciones.Rows[0].Cells[8].Value.ToString();
					Hoja[x,9] = dataDeducciones.Rows[0].Cells[1].Value.ToString();
					Hoja[x,10] = dataDeducciones.Rows[0].Cells[3].Value.ToString();
					Hoja[x,11] = dataDeducciones.Rows[0].Cells[0].Value.ToString();
					Hoja[x,12] = dataDeducciones.Rows[0].Cells[4].Value.ToString();
					Hoja[x,13] = dataDeducciones.Rows[0].Cells[5].Value.ToString();
					Hoja[x,14] = txtPatron.Text;
					Hoja[x,15] = Alias;
					Hoja[x,16] = Unidad;
					Hoja[x,17] = formnomina.RetornoSueldoAlias(Alias).ToString();
					Hoja[x,18] = formnomina.RetornoSueldoFinalAlias(Alias).ToString();
					Hoja[x,19] = new Transportes_LAR.Conexion_Servidor.Cuenta.SQL_Cuenta().ReturnNumero(data[0,x].Value.ToString());
					ImprimirRecibo(x);
				}
				principal.progressbarPrin.Increment(1);
			}
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;				
		}
		
		/*void ImprimirTodosExcel(DataGridView data, DataGridView data2)
		{
			for(int x=0; x<data.Rows.Count; x++)
			{
				if(data.Rows[x].Cells[1].Style.BackColor.Name!="SteelBlue")
				{
					principal.progressbarPrin.Minimum = 1;
		    		principal.progressbarPrin.Maximum = data.Rows.Count; 
		    		this.x = x;
					if(x>0)
					{
						data.Rows[x-1].Selected = false;
					}
					data.Rows[x].Selected = true;
					listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(data[0,x].Value.ToString());
					String Unidad = listNomina[0].Unidad;
					MetodoPrincipal(x);
					CalcularSueldo();
					CalcularSueldo();
					CalcularSueldo();
					Hoja[x,0] = txtNombreCompleto.Text;
					Hoja[x,1] = txtSueldo.Text;
					Hoja[x,2] = txtDiasTrabajados.Text;
					Hoja[x,3] = dataPercepciones.Rows[0].Cells[0].Value.ToString();
					Hoja[x,4] = dataPercepciones.Rows[0].Cells[5].Value.ToString();
					Hoja[x,5] = dataPercepciones.Rows[0].Cells[6].Value.ToString();
					Hoja[x,6] = dataPercepciones.Rows[0].Cells[7].Value.ToString();
					Hoja[x,7] = dataPercepciones.Rows[0].Cells[4].Value.ToString();
					Hoja[x,8] = dataPercepciones.Rows[0].Cells[8].Value.ToString();
					Hoja[x,9] = dataDeducciones.Rows[0].Cells[1].Value.ToString();
					Hoja[x,10] = dataDeducciones.Rows[0].Cells[3].Value.ToString();
					Hoja[x,11] = dataDeducciones.Rows[0].Cells[0].Value.ToString();
					Hoja[x,12] = dataDeducciones.Rows[0].Cells[4].Value.ToString();
					Hoja[x,13] = dataDeducciones.Rows[0].Cells[5].Value.ToString();
					Hoja[x,14] = txtPatron.Text;
					Hoja[x,15] = Alias;
					Hoja[x,16] = Unidad;
					Hoja[x,17] = formnomina.RetornoSueldoAlias(Alias).ToString();
					Hoja[x,18] = formnomina.RetornoSueldoFinalAlias(Alias).ToString();
					Hoja[x,19] = new Transportes_LAR.Conexion_Servidor.Cuenta.SQL_Cuenta().ReturnNumero(data[0,x].Value.ToString());
				}
				principal.progressbarPrin.Increment(1);
			}
			
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
			
			for(int x=0; x<data2.Rows.Count; x++)
			{
				if(data2.Rows[x].Cells[1].Style.BackColor.Name!="SteelBlue")
				{
					principal.progressbarPrin.Minimum = 1;
		    		principal.progressbarPrin.Maximum = data2.Rows.Count; 
		    		this.x = x;
					if(x>0)
					{
						data2.Rows[x-1].Selected = false;
					}
					data2.Rows[x].Selected = true;
					listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(data2[0,x].Value.ToString());
					String Unidad = listNomina[0].Unidad;
					MetodoPrincipal(x);
					CalcularSueldo();
					CalcularSueldo();
					CalcularSueldo();
					Hoja[data.Rows.Count+x,0] = txtNombreCompleto.Text;
					Hoja[data.Rows.Count+x,1] = txtSueldo.Text;
					Hoja[data.Rows.Count+x,2] = txtDiasTrabajados.Text;
					Hoja[data.Rows.Count+x,3] = dataPercepciones.Rows[0].Cells[0].Value.ToString();
					Hoja[data.Rows.Count+x,4] = dataPercepciones.Rows[0].Cells[5].Value.ToString();
					Hoja[data.Rows.Count+x,5] = dataPercepciones.Rows[0].Cells[6].Value.ToString();
					Hoja[data.Rows.Count+x,6] = dataPercepciones.Rows[0].Cells[7].Value.ToString();
					Hoja[data.Rows.Count+x,7] = dataPercepciones.Rows[0].Cells[4].Value.ToString();
					Hoja[data.Rows.Count+x,8] = dataPercepciones.Rows[0].Cells[8].Value.ToString();
					Hoja[data.Rows.Count+x,9] = dataDeducciones.Rows[0].Cells[1].Value.ToString();
					Hoja[data.Rows.Count+x,10] = dataDeducciones.Rows[0].Cells[3].Value.ToString();
					Hoja[data.Rows.Count+x,11] = dataDeducciones.Rows[0].Cells[0].Value.ToString();
					Hoja[data.Rows.Count+x,12] = dataDeducciones.Rows[0].Cells[4].Value.ToString();
					Hoja[data.Rows.Count+x,13] = dataDeducciones.Rows[0].Cells[5].Value.ToString();
					Hoja[data.Rows.Count+x,14] = txtPatron.Text;
					Hoja[data.Rows.Count+x,15] = Alias;
					Hoja[data.Rows.Count+x,16] = Unidad;
					Hoja[data.Rows.Count+x,17] = formnomina.RetornoSueldoAlias(Alias).ToString();
					Hoja[data.Rows.Count+x,18] = formnomina.RetornoSueldoFinalAlias(Alias).ToString();
					Hoja[data.Rows.Count+x,19] = new Transportes_LAR.Conexion_Servidor.Cuenta.SQL_Cuenta().ReturnNumero(data2[0,x].Value.ToString());
				}
				principal.progressbarPrin.Increment(1);
			}
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;				
		}*/
		#endregion
		
		#region IMPRIMIR RECIBO
		void ImprimirRecibo(int x)
		{
			String activeDir = "";
	        string newPath = "";
	        FileStream file = null;
	        String opcion = "1";
	        String opcion2 = "1";
	        
	        if(tabOperadores.SelectedIndex==0)
	        {
				activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
	        	newPath = System.IO.Path.Combine(activeDir, "Recibos "+Fechecarpeta);
	        	opcion = "1";
	        	opcion2 = "1";
	        }
			if(tabOperadores.SelectedIndex==1)
			{
				activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
	        	newPath = System.IO.Path.Combine(activeDir, "Recibos "+Fechecarpeta+@"\Periodo Incompleto");
	        	opcion = "1";
	        	opcion2 = "1";
			}
			if(tabOperadores.SelectedIndex==3)
			{
				activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
	        	newPath = System.IO.Path.Combine(activeDir, "Recibos "+Fechecarpeta+@"\Prima Vacacional");
	        	opcion = "2";
			}
			if(tabOperadores.SelectedIndex==2)
			{
				activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
	       		newPath = System.IO.Path.Combine(activeDir, "Recibos "+Fechecarpeta+@"\Administrativo");
	       		opcion = "1";
	       		opcion2 = "2";
			}
			if(tabOperadores.SelectedIndex==4)
			{
				activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
	        	newPath = System.IO.Path.Combine(activeDir, "Recibos "+Fechecarpeta+@"\Aguinaldo");
	        	opcion = "3";
	        	
			}
			
	        System.IO.Directory.CreateDirectory(newPath);
			try
			{	
				Document doc = new Document(PageSize.LETTER, 15, 15, 10, 10);
				if(tabOperadores.SelectedIndex==0)
	        	{
	        	file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\"+dtOperador[1,x].Value.ToString()+" Recibo.pdf",
				                      FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);              
	        	}
				if(tabOperadores.SelectedIndex==1)
				{
		        	file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Periodo Incompleto\"+dtOperador2[1,x].Value.ToString()+" Recibo.pdf",
					                      FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				}
				if(tabOperadores.SelectedIndex==3)
				{
					file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Prima Vacacional\"+dtOperadorPrima[1,x].Value.ToString()+" Recibo.pdf",
					                      FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				}
				if(tabOperadores.SelectedIndex==2)
				{
					file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Administrativo\"+dataAdministrativos[1,x].Value.ToString()+" Recibo.pdf",
					                     FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				}
				if(tabOperadores.SelectedIndex==4)
				{
					file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Aguinaldo\"+dataAguinaldo[1,x].Value.ToString()+" Recibo.pdf",
					                     FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
				}
				
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				
				if(tabOperadores.SelectedIndex==4)
					GenerarDocumentoReciboAguinaldo(doc, writer, opcion);
				else if(tabOperadores.SelectedIndex==3)
					GenerarDocumentoReciboPrima(doc, writer, opcion);
				else
					GenerarDocumentoRecibo(doc, writer, opcion, opcion2);
				
		        doc.Close();	
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		
		#region RECIBO
		public void GenerarDocumentoRecibo(Document document, PdfWriter writer, String Opcion, String Opcion2)
		{
			FormatoPdf.Recibo(principal, document, writer, Opcion, Alias, txtPatron, txtNs, 
			                  txtPuesto, txtRfc, txtNumImss, txtDiasTrabajados, dtInicio, dtFin, 
			                  dataPercepciones, dataDeducciones, TotalDeducciones, txtPrima, 
			                  txtPrimaVacacional, txtAguinaldo, Compesacion, Retener,
			                  txtNombreCompleto, formnomina, Nombre, dtOperador, dtOperador[0,x].Value.ToString(), Opcion2);
		}
		
		public void GenerarDocumentoReciboAguinaldo(Document document, PdfWriter writer, String Opcion)
		{
			FormatoPdf.Recibo(principal, document, writer, Opcion, Alias, txtPatron, txtNs, 
			                  txtPuesto, txtRfc, txtNumImss, txtDiasTrabajados, dtInicio, dtFin, 
			                  dataPercepciones, dataDeducciones, TotalDeducciones, txtPrima, 
			                  txtPrimaVacacional, txtAguinaldo, Compesacion, Retener,
			                  txtNombreCompleto, formnomina, Nombre, dataAguinaldo, dataAguinaldo[0,x].Value.ToString(), "0");
		}
		
		//checar
		public void GenerarDocumentoReciboPrima(Document document, PdfWriter writer, String Opcion)
		{
			FormatoPdf.Recibo(principal, document, writer, Opcion, Alias, txtPatron, txtNs, 
			                  txtPuesto, txtRfc, txtNumImss, txtDiasTrabajados, dtInicio, dtFin, 
			                  dataPercepciones, dataDeducciones, TotalDeducciones, txtPrima, 
			                  txtPrimaVacacional, txtAguinaldo, Compesacion, Retener,
			                  txtNombreCompleto, formnomina, Nombre, dtOperadorPrima, dtOperadorPrima[0,x].Value.ToString(), "0");
		}
		#endregion
			
		#region CALCULAR DIAS TRABAJADOS - INCAPACIDAD
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			CalculoDiasTrabajados();
		}
		
		void DtFinValueChanged(object sender, EventArgs e)
		{
			CalculoDiasTrabajados();
		}
		
		void CalculoDiasTrabajados()
		{
			FechaInicio = dtInicio.Value;
			FechaCorte = dtFin.Value;
			TimeSpan ts = FechaCorte - FechaInicio;
			DiasTrabajados = ts.Days + 1;
			txtDiasTrabajados.Text = DiasTrabajados.ToString();
			
			//if((Convert.ToInt32(dataPercepciones.Rows[0].Cells[2].Value)>3))
			if((Convert.ToInt32(dataPercepciones.Rows[0].Cells[2].Value)>0))
			{
				if((Convert.ToInt32(dataPercepciones.Rows[0].Cells[2].Value)<14))
			   	{	
			   	   	DiasTrabajados = DiasTrabajados - (Convert.ToInt32(dataPercepciones.Rows[0].Cells[2].Value));
			   	   	txtDiasTrabajados.Text = DiasTrabajados.ToString();
			   	}
			   	else
			   	{
			   		DiasTrabajados = 0;
			   		txtDiasTrabajados.Text = DiasTrabajados.ToString();
			   	}
			}
		}
		#endregion
		
		#region CALCULAR SUELDO
		void CalcularSueldo()
		{
			TotalDeducciones = 0.0;
			dataPercepciones.Rows[0].Cells[0].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtSueldo.Text))/Convert.ToDouble(txtIntegracion.Text))), 2);
			dataPercepciones.Rows[0].Cells[5].Value = Math.Round(((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value) * 0.1)), 2);
			dataPercepciones.Rows[0].Cells[6].Value = Math.Round(((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value) * 0.1)), 2);
			dataPercepciones.Rows[0].Cells[7].Value = Math.Round((Convert.ToDouble(txtSalariominimo.Text) * 0 * DiasTrabajados), 2);
			dataPercepciones.Rows[0].Cells[1].Value = "0.00";
			dataPercepciones.Rows[0].Cells[3].Value = "S. P. E.";
			CalculoImporteISPT();
			BaseGravable();
			
				if(txtPuesto.Text!="OPERADOR")
				{
					dataPercepciones.Rows[0].Cells[8].Value = Math.Round(((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value)) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[4].Value))) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[5].Value))) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[6].Value))) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[7].Value)))), 2).ToString();
					
					dataDeducciones.Rows[0].Cells[0].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtIsr.Text))/7)), 2).ToString();
					dataDeducciones.Rows[0].Cells[1].Value = Math.Round((((Convert.ToDouble(2.375)) * (Convert.ToDouble(txtSueldo.Text)) * (Convert.ToDouble(DiasTrabajados)))/100), 2);
					dataDeducciones.Rows[0].Cells[3].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtInfonavit.Text))/7)), 2).ToString();
				}
				else
				{
					/*//antiguos criterios operadores
					dataPercepciones.Rows[0].Cells[5].Value = 0.0;
					dataPercepciones.Rows[0].Cells[6].Value = 0.0;
					dataPercepciones.Rows[0].Cells[7].Value = 0.0;
					dataPercepciones.Rows[0].Cells[8].Value = Math.Round(((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value)) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[4].Value)))), 2).ToString();
					
					dataDeducciones.Rows[0].Cells[0].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtIsr.Text))/14)), 2).ToString();
					dataDeducciones.Rows[0].Cells[1].Value = Math.Round((((Convert.ToDouble(2.375)) * (Convert.ToDouble(txtSueldo.Text)) * (Convert.ToDouble(DiasTrabajados)))/100), 2);
					dataDeducciones.Rows[0].Cells[3].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtInfonavit.Text))/14)), 2).ToString();
					//*/
					dataPercepciones.Rows[0].Cells[4].Value = Math.Round((Convert.ToDouble(dataTotalesISPT14.Rows[9].Cells[1].Value)), 2);
					dataPercepciones.Rows[0].Cells[8].Value = Math.Round(((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value)) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[4].Value))) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[5].Value))) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[6].Value))) + ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[7].Value)))), 2).ToString();
					
					dataDeducciones.Rows[0].Cells[0].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtIsr.Text))/14)), 2).ToString();
					
					if(DiasTrabajados > 0 && DiasTrabajados < 14)
						dataDeducciones.Rows[0].Cells[0].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtIsr.Text))/DiasTrabajados)), 2).ToString();
					
					
					dataDeducciones.Rows[0].Cells[1].Value = Math.Round((((Convert.ToDouble(2.375)) * (Convert.ToDouble(txtSueldo.Text)) * (Convert.ToDouble(DiasTrabajados)))/100), 2);
					dataDeducciones.Rows[0].Cells[3].Value = Math.Round(((Convert.ToDouble(DiasTrabajados)) * ((Convert.ToDouble(txtInfonavit.Text))/14)), 2).ToString();
				}
				
			dataDeducciones.Rows[0].Cells[2].Value =  "INF";
			dataDeducciones.Rows[0].Cells[5].Value =  Math.Round(((Convert.ToDouble(dataPercepciones.Rows[0].Cells[8].Value))-(Convert.ToDouble(dataDeducciones.Rows[0].Cells[0].Value))-(Convert.ToDouble(dataDeducciones.Rows[0].Cells[1].Value))-(Convert.ToDouble(dataDeducciones.Rows[0].Cells[3].Value))), 2).ToString();
			TotalDeducciones = (Convert.ToDouble(dataDeducciones.Rows[0].Cells[0].Value)) + (Convert.ToDouble(dataDeducciones.Rows[0].Cells[1].Value)) + (Convert.ToDouble(dataDeducciones.Rows[0].Cells[3].Value));	
			dataDeducciones.Rows[0].Cells[4].Value =  TotalDeducciones;
		}
		
		void BaseGravable()
		{
			if(txtPuesto.Text!="OPERADOR")
			{
			 	dataTotalesISPT7.Rows[0].Cells[1].Value = (Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[5].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[6].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[7].Value));
				
			 	for(int x=0;x<dataTarifas7.Rows.Count;x++)
				{
					if(((Convert.ToDouble(dataTarifas7.Rows[x].Cells[0].Value))<=(Convert.ToDouble(dataTotalesISPT7.Rows[0].Cells[1].Value)))&&((Convert.ToDouble(dataTarifas7.Rows[x].Cells[1].Value))>=(Convert.ToDouble(dataTotalesISPT7.Rows[0].Cells[1].Value))))
					{
					   	dataTotalesISPT7.Rows[1].Cells[1].Value = dataTarifas7.Rows[x].Cells[0].Value;
					   	dataTotalesISPT7.Rows[2].Cells[1].Value = ((Convert.ToDouble(dataTotalesISPT7.Rows[0].Cells[1].Value))-(Convert.ToDouble(dataTotalesISPT7.Rows[1].Cells[1].Value)));
					   	dataTotalesISPT7.Rows[3].Cells[1].Value = dataTarifas7.Rows[x].Cells[3].Value;
					    dataTotalesISPT7.Rows[4].Cells[1].Value =  (Convert.ToDouble(dataTotalesISPT7.Rows[2].Cells[1].Value))*(Convert.ToDouble(dataTotalesISPT7.Rows[3].Cells[1].Value));
					   	dataTotalesISPT7.Rows[5].Cells[1].Value = dataTarifas7.Rows[x].Cells[2].Value;  
					   	dataTotalesISPT7.Rows[6].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT7.Rows[4].Cells[1].Value))	+ (Convert.ToDouble(dataTotalesISPT7.Rows[5].Cells[1].Value));
					   	
					   	for(int z=0;z<dataGobierno7.Rows.Count;z++)
						{
							if(((Convert.ToDouble(dataGobierno7.Rows[z].Cells[0].Value))<=(Convert.ToDouble(dataTotalesISPT7.Rows[0].Cells[1].Value)))&&((Convert.ToDouble(dataGobierno7.Rows[z].Cells[1].Value))>=(Convert.ToDouble(dataTotalesISPT7.Rows[0].Cells[1].Value))))
							{
								dataTotalesISPT7.Rows[7].Cells[1].Value = dataGobierno7.Rows[z].Cells[2].Value;
							   	break;
							}
						}
					   	dataTotalesISPT7.Rows[8].Cells[1].Value = ((Convert.ToDouble(dataTotalesISPT7.Rows[6].Cells[1].Value)) - (Convert.ToDouble(dataTotalesISPT7.Rows[7].Cells[1].Value)));
					   	
					   	if((Convert.ToDouble(dataTotalesISPT7.Rows[8].Cells[1].Value))<0)
					   		dataTotalesISPT7.Rows[8].Cells[1].Value = (((Convert.ToDouble(dataTotalesISPT7.Rows[6].Cells[1].Value)) - (Convert.ToDouble(dataTotalesISPT7.Rows[7].Cells[1].Value)))*-1);
					   	else
							dataTotalesISPT7.Rows[8].Cells[1].Value = 0;
				   		
					   	dataPercepciones.Rows[0].Cells[4].Value = Math.Round((Convert.ToDouble(dataTotalesISPT7.Rows[8].Cells[1].Value)), 2);
					   	break;
					}
				}
			}
			else
			{
				dataTotalesISPT14.Rows[0].Cells[1].Value = (Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[5].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[6].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[7].Value))/(Convert.ToDouble(txtDiasTrabajados.Text));
				double baseGravable = ((Convert.ToDouble(dataPercepciones.Rows[0].Cells[0].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[5].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[6].Value) + Convert.ToDouble(dataPercepciones.Rows[0].Cells[7].Value)))/(Convert.ToDouble(txtDiasTrabajados.Text));
				
				for(int x=0;x<dataTarifas14.Rows.Count;x++)
				{
					if(((Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value))<=(baseGravable))&&((Convert.ToDouble(dataTarifas14.Rows[x].Cells[1].Value))>=(baseGravable)))
					{
					   	dataTotalesISPT14.Rows[0].Cells[1].Value = (baseGravable);
					   	dataTotalesISPT14.Rows[1].Cells[1].Value = (Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value));
					   	dataTotalesISPT14.Rows[2].Cells[1].Value = (baseGravable)-(Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value));
					   	dataTotalesISPT14.Rows[3].Cells[1].Value = dataTarifas14.Rows[x].Cells[3].Value;
					    dataTotalesISPT14.Rows[4].Cells[1].Value =  (Convert.ToDouble(dataTarifas14.Rows[x].Cells[3].Value))*(Convert.ToDouble(dataTotalesISPT14.Rows[2].Cells[1].Value));
					    dataTotalesISPT14.Rows[5].Cells[1].Value = dataTarifas14.Rows[x].Cells[2].Value;
					   	dataTotalesISPT14.Rows[6].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[4].Cells[1].Value))	+ (Convert.ToDouble(dataTotalesISPT14.Rows[5].Cells[1].Value));
					   	break;
					}
				}
				
				for(int x=0;x<dataSubsidio14.Rows.Count;x++)
				{
					if(((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[0].Value))<=(baseGravable))&&((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[1].Value))>=(baseGravable)))
					{
					   	dataTotalesISPT14.Rows[7].Cells[1].Value = dataSubsidio14.Rows[x].Cells[2].Value;
					   	dataTotalesISPT14.Rows[8].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[6].Cells[1].Value)) - (Convert.ToDouble(dataTotalesISPT14.Rows[7].Cells[1].Value));
					  	
					   	if((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))>0)
					   		dataTotalesISPT14.Rows[9].Cells[1].Value = 0;
					  	else
					  		dataTotalesISPT14.Rows[9].Cells[1].Value = Math.Round((((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))*(Convert.ToDouble(txtDiasTrabajados.Text)))*(-1)),2);
					  	
					  	if((Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))>0)
					  		dataTotalesISPT14.Rows[8].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value))*(Convert.ToDouble(txtDiasTrabajados.Text));
					  	else
					  		dataTotalesISPT14.Rows[8].Cells[1].Value = 0;
					  	
					 
					  	break;
					}
				}
				try{					
					//new Conexion_Servidor.Nomina.SQL_Recibo().ISR(dtOperador[0,this.x].Value.ToString(), Math.Round(Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value), 2));
					/*
					if(tabOperadores.SelectedIndex==0)
						new Conexion_Servidor.Nomina.SQL_Recibo().ISR(dtOperador[0,this.x].Value.ToString(), Math.Round(Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value), 2));
					if(tabOperadores.SelectedIndex==1)
						new Conexion_Servidor.Nomina.SQL_Recibo().ISR(dtOperador2[0,this.x].Value.ToString(), Math.Round(Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value), 2));
					if(tabOperadores.SelectedIndex==3)
						new Conexion_Servidor.Nomina.SQL_Recibo().ISR(dtOperadorPrima[0,this.x].Value.ToString(), Math.Round(Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value), 2));
					if(tabOperadores.SelectedIndex==2)
						new Conexion_Servidor.Nomina.SQL_Recibo().ISR(dataAdministrativos[0,this.x].Value.ToString(), Math.Round(Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value), 2));
					if(tabOperadores.SelectedIndex==4)
						new Conexion_Servidor.Nomina.SQL_Recibo().ISR(dataAguinaldo[0,this.x].Value.ToString(), Math.Round(Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value), 2));		
*/	
				}catch(Exception ex){
					MessageBox.Show("Error Recibo: "+ex.Message);
				}
				txtIsr.Text = Math.Round(Convert.ToDouble(dataTotalesISPT14.Rows[8].Cells[1].Value), 2).ToString();
			}
				
		}
		#endregion
		
		#region CALCULO IMPORTE ISPT
		void CalculoImporteISPT()
		{
			/*for(int x=0;x<dataTarifas14.Rows.Count;x++)
			{
				if(((Convert.ToDouble(dataTarifas14.Rows[x].Cells[0].Value))<=(Convert.ToDouble(txtSueldo.Text)/Convert.ToDouble(txtIntegracion.Text)))&&((Convert.ToDouble(dataTarifas14.Rows[x].Cells[1].Value))>=(Convert.ToDouble(txtSueldo.Text)/Convert.ToDouble(txtIntegracion.Text))))
				{
				   	dataTotalesISPT14.Rows[0].Cells[1].Value = dataTarifas14.Rows[x].Cells[0].Value;
				   	dataTotalesISPT14.Rows[1].Cells[1].Value = ((Convert.ToDouble(txtSueldo.Text))/Convert.ToDouble(txtIntegracion.Text))-(Convert.ToDouble(dataTotalesISPT14.Rows[0].Cells[1].Value));
				   	dataTotalesISPT14.Rows[2].Cells[1].Value = dataTarifas14.Rows[x].Cells[3].Value;
				    dataTotalesISPT14.Rows[3].Cells[1].Value =  (Convert.ToDouble(dataTarifas14.Rows[x].Cells[3].Value))*(Convert.ToDouble(dataTotalesISPT14.Rows[1].Cells[1].Value));
				   	dataTotalesISPT14.Rows[4].Cells[1].Value = dataTarifas14.Rows[x].Cells[2].Value;  
				   	dataTotalesISPT14.Rows[5].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[4].Cells[1].Value))	+ (Convert.ToDouble(dataTotalesISPT14.Rows[3].Cells[1].Value));
				   	break;
				}
				else
				{
					dataTotalesISPT14.Rows[0].Cells[1].Value = 1;
					dataTotalesISPT14.Rows[2].Cells[1].Value = 4;
					dataTotalesISPT14.Rows[4].Cells[1].Value = 3;  
				}
			}
			
			for(int x=0;x<dataSubsidio14.Rows.Count;x++)
			{
				if(((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[0].Value))<=(Convert.ToDouble(txtSueldo.Text)/Convert.ToDouble(txtIntegracion.Text)))&&((Convert.ToDouble(dataSubsidio14.Rows[x].Cells[1].Value))>=(Convert.ToDouble(txtSueldo.Text)/Convert.ToDouble(txtIntegracion.Text))))
				{
				   	dataTotalesISPT14.Rows[6].Cells[1].Value = dataSubsidio14.Rows[x].Cells[2].Value;
				   	dataTotalesISPT14.Rows[7].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[5].Cells[1].Value)) - (Convert.ToDouble(dataTotalesISPT14.Rows[6].Cells[1].Value));
				  	
				   	if((Convert.ToDouble(dataTotalesISPT14.Rows[7].Cells[1].Value))<0)
				   		dataTotalesISPT14.Rows[8].Cells[1].Value = 0;
				  	else
				   		dataTotalesISPT14.Rows[8].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[7].Cells[1].Value))*(Convert.ToDouble(txtDiasTrabajados.Text));
				  	
				  	if((Convert.ToDouble(dataTotalesISPT14.Rows[7].Cells[1].Value))<0)
				  		dataTotalesISPT14.Rows[9].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[7].Cells[1].Value))*(Convert.ToDouble(txtDiasTrabajados.Text));
				  	else
				  		dataTotalesISPT14.Rows[9].Cells[1].Value = 0;
				  	
				  	if((Convert.ToDouble(dataTotalesISPT14.Rows[9].Cells[1].Value))<0)
				  		dataTotalesISPT14.Rows[9].Cells[1].Value = (Convert.ToDouble(dataTotalesISPT14.Rows[9].Cells[1].Value))*(-1);
				 
				  	break;
				}
				else
					dataTotalesISPT14.Rows[6].Cells[1].Value = 3;
			}*/
		}
		#endregion
		
		#region LLENADO TABLA DE IMPUESTOS
		void LlenadoDataGrid()
		{
			dataTarifas14.Rows.Clear();
			dataTarifas14.ClearSelection();
			dataTarifas14.Rows.Add(0.01, 19.03, 0, 0.0192);
			dataTarifas14.Rows.Add(19.04, 161.52, 0.37, 0.0640);
			dataTarifas14.Rows.Add(161.53, 283.86, 9.48, 0.1088);
			dataTarifas14.Rows.Add(283.87, 329.97, 22.79, 0.16);
			dataTarifas14.Rows.Add(329.98, 395.06, 30.17, 0.1792);
			dataTarifas14.Rows.Add(395.07, 796.79, 41.84, 0.2136);
			dataTarifas14.Rows.Add(796.8, 1255.85, 127.65, 0.2352);
			dataTarifas14.Rows.Add(1255.86, 2397.62, 235.62, 0.3);
			dataTarifas14.Rows.Add(2397.63, 3196.82, 578.15, 0.32);
			dataTarifas14.Rows.Add(3196.83, 9590.46, 833.89, 0.34);
			dataTarifas14.Rows.Add(9590.47, 999999, 3007.73, 0.35);
			
			dataSubsidio14.Rows.Clear();
			dataSubsidio14.ClearSelection();
			dataSubsidio14.Rows.Add(0.01, 58.19, 13.39);
			dataSubsidio14.Rows.Add(58.20, 87.28, 13.38);
			dataSubsidio14.Rows.Add(87.29, 114.24, 13.38);
			dataSubsidio14.Rows.Add(114.39, 116.38, 12.92);
			dataSubsidio14.Rows.Add(116.39, 146.25, 12.58);
			dataSubsidio14.Rows.Add(146.26, 155.17, 11.65);
			dataSubsidio14.Rows.Add(155.18, 175.51, 10.69);
			dataSubsidio14.Rows.Add(175.52, 204.76, 9.69);
			dataSubsidio14.Rows.Add(204.77, 234.01, 8.34);
			dataSubsidio14.Rows.Add(234.02, 242.84, 7.16);
			dataSubsidio14.Rows.Add(242.85, 999999, 0);
			
			/*dataTotalesISPT14.Rows.Clear();
			dataTotalesISPT14.ClearSelection();
			dataTotalesISPT14.Rows.Add("Limte Inferior de la tarifa del Art.113", 0);
			dataTotalesISPT14.Rows.Add("Excedente sobre limite inferior", 0);
			dataTotalesISPT14.Rows.Add("Tasa aplicable s/ limite inferior", 0);
			dataTotalesISPT14.Rows.Add("", 0);
			dataTotalesISPT14.Rows.Add("Cuota Fija", 0);
			dataTotalesISPT14.Rows.Add("ISR conforme a al Art. 113 ISR", 0);
			dataTotalesISPT14.Rows.Add("ISPT del periodo", 0);
			dataTotalesISPT14.Rows.Add("Subsidio para el empleo", 0);
			dataTotalesISPT14.Rows.Add("ISR a Cargo", 0);
			dataTotalesISPT14.Rows.Add("Subsidio a Favor", 0);*/
			dataTotalesISPT14.Rows.Clear();
			dataTotalesISPT14.ClearSelection();
			dataTotalesISPT14.Rows.Add("Base Gravable", 0);
			dataTotalesISPT14.Rows.Add("Limite Inferior", 0);
			dataTotalesISPT14.Rows.Add("Exedente", 0);
			dataTotalesISPT14.Rows.Add("% ISR conforme a al Art. 113", 0);
			dataTotalesISPT14.Rows.Add("Impuesto Marginal", 0);
			dataTotalesISPT14.Rows.Add("Cuota Fija", 0);
			dataTotalesISPT14.Rows.Add("Impuesto según Art 113", 0);
			dataTotalesISPT14.Rows.Add("SPE de la Tabla", 0);
			dataTotalesISPT14.Rows.Add("ISR a Cargo", 0);
			dataTotalesISPT14.Rows.Add("Subsidio a Favor", 0);
			
			///////////////////////////////////////////////// REPORTE ADMINISTRATIVOS /////////////////////////////////////////////////
			
			/*dataTarifas7.Rows.Clear();
			dataTarifas7.ClearSelection();
			dataTarifas7.Rows.Add(0.01, 114.24, 0, 0.0192);
			dataTarifas7.Rows.Add(114.25, 969.5, 2.17, 0.064);
			dataTarifas7.Rows.Add(969.51, 1703.80, 56.91, 0.1088);
			dataTarifas7.Rows.Add(1703.81, 1980.58, 136.85, 0.16);
			dataTarifas7.Rows.Add(1980.59, 2371.32, 181.09, 0.1792);
			dataTarifas7.Rows.Add(2371.33, 4782.61, 251.16, 0.2136);
			dataTarifas7.Rows.Add(4782.62, 7538.09, 766.15, 0.2352);
			dataTarifas7.Rows.Add(7538.10, 14391.44, 1414.28, 0.3);
			dataTarifas7.Rows.Add(14391.45, 19188.61, 3470.26, 0.32);
			dataTarifas7.Rows.Add(19188.62, 57585.76, 5005.35, 0.34);
			dataTarifas7.Rows.Add(57585.77, 999999, 18063.63, 0.35);*/
			
			dataTarifas7.Rows.Clear();
			dataTarifas7.ClearSelection();
			dataTarifas7.Rows.Add(0.01, 133.21, 0, 0.0192);
			dataTarifas7.Rows.Add(133.22, 1130.64, 2.59, 0.064);
			dataTarifas7.Rows.Add(1130.65, 1987.02, 66.36, 0.1088);
			dataTarifas7.Rows.Add(1987.03, 2309.79, 159.53, 0.16);
			dataTarifas7.Rows.Add(2309.80, 2765.42, 211.19, 0.1792);
			dataTarifas7.Rows.Add(2765.43, 5577.53, 292.88, 0.2136);
			dataTarifas7.Rows.Add(5577.54, 8790.95, 893.55, 0.2352);
			dataTarifas7.Rows.Add(8790.96, 16783.34, 1649.34, 0.3);
			dataTarifas7.Rows.Add(16783.35, 22377.74, 4047.05, 0.32);
			dataTarifas7.Rows.Add(22377.75, 67133.22, 5837.23, 0.34);
			dataTarifas7.Rows.Add(67133.23, 999999, 21054.11, 0.35);
			
			dataGobierno7.Rows.Clear();
			dataGobierno7.ClearSelection();
			dataGobierno7.Rows.Add(0.01, 407.33, 93.73);
			dataGobierno7.Rows.Add(407.34, 610.96, 93.66);
			dataGobierno7.Rows.Add(610.97, 799.68, 93.66);
			dataGobierno7.Rows.Add(799.69, 814.66, 90.44);
			dataGobierno7.Rows.Add(814.67, 1023.75, 88.06);
			dataGobierno7.Rows.Add(1023.76, 1086.19, 81.55);
			dataGobierno7.Rows.Add(1086.20, 1228.57, 74.83);
			dataGobierno7.Rows.Add(1228.58, 1433.32, 67.83);
			dataGobierno7.Rows.Add(1433.33, 1638.07, 58.38);
			dataGobierno7.Rows.Add(1638.08, 1699.88, 50.12);
			dataGobierno7.Rows.Add(1699.89, 999999, 0);
			
			dataTotalesISPT7.Rows.Clear();
			dataTotalesISPT7.ClearSelection();
			dataTotalesISPT7.Rows.Add("Base Gravable", 0);
			dataTotalesISPT7.Rows.Add("Limite Inferior", 0);
			dataTotalesISPT7.Rows.Add("Exedente", 0);
			dataTotalesISPT7.Rows.Add("% ISR conforme a al Art. 113", 0);
			dataTotalesISPT7.Rows.Add("Impuesto Marginal", 0);
			dataTotalesISPT7.Rows.Add("Cuota Fija", 0);
			dataTotalesISPT7.Rows.Add("Impuesto según Art 113", 0);
			dataTotalesISPT7.Rows.Add("SPE de la Tabla", 0);
			dataTotalesISPT7.Rows.Add("Subsidio a Favor", 0);
			dataTotalesISPT7.Rows.Add("ISR a Cargo", 0);
		}
		#endregion
		
		#region SELECION TAB
		void TabOperadoresSelectedIndexChanged(object sender, EventArgs e)
		{
			if(tabOperadores.SelectedIndex==0)
			{
				dtOperador2.ClearSelection();
				dtOperadorPrima.ClearSelection();
				dataAdministrativos.ClearSelection();
				dataAguinaldo.ClearSelection();
				dtInicio.Value = (Convert.ToDateTime(FechaInicioR));
				dtFin.Value = (Convert.ToDateTime(FechaCorteR));
			}
			else if(tabOperadores.SelectedIndex==1)
			{
				dtOperador.ClearSelection();
				dtOperadorPrima.ClearSelection();
				dataAdministrativos.ClearSelection();
				dataAguinaldo.ClearSelection();
				txtFechaIngreso.Text="Temporal";
			}
			else if(tabOperadores.SelectedIndex==3)
			{
				dtOperador.ClearSelection();
				dtOperador2.ClearSelection();
				dataAdministrativos.ClearSelection();
				dataAguinaldo.ClearSelection();
				dtInicio.Value = (Convert.ToDateTime(FechaInicioR));
				dtFin.Value = (Convert.ToDateTime(FechaCorteR));
			}
			else if(tabOperadores.SelectedIndex==2)
			{
				dtOperador.ClearSelection();
				dtOperador2.ClearSelection();
				dtOperadorPrima.ClearSelection();
				dataAguinaldo.ClearSelection();
				dtInicio.Value = DateTime.Now.AddDays(-5);
				dtFin.Value = DateTime.Now.AddDays(1);
			}
			else if(tabOperadores.SelectedIndex==4)
			{
				dtOperador.ClearSelection();
				dtOperador2.ClearSelection();
				dtOperadorPrima.ClearSelection();
				dataAdministrativos.ClearSelection();
				dtInicio.Value = (Convert.ToDateTime(FechaInicioR));
				dtFin.Value = (Convert.ToDateTime(FechaCorteR));
			}
			else if(tabOperadores.SelectedIndex==3)
			{
				dtOperador.ClearSelection();
				dtOperador2.ClearSelection();
				dtOperadorPrima.ClearSelection();
				dataAguinaldo.ClearSelection();
				dtInicio.Value = (Convert.ToDateTime(FechaInicioR));
				dtFin.Value = (Convert.ToDateTime(FechaCorteR));
			}
		}
		#endregion
		
		#region EVENTO IMPRIMIR RECIBO DOBLE-CLICK
		void DtOperadorCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ImprimirRecibo(x);		
			try{
				Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\"+dtOperador[1,x].Value.ToString()+" Recibo.pdf"));
			}catch{}
		}
		
		void DtOperador2CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ImprimirRecibo(x);		
			try{
				System.Diagnostics.Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Periodo Incompleto\"+dtOperador2[1,x].Value.ToString()+" Recibo.pdf"));
			}catch{}
		}
		
		void DtOperadorPlantaCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ImprimirRecibo(x);		
			try{
				System.Diagnostics.Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Prima Vacacional\"+dtOperadorPrima[1,x].Value.ToString()+" Recibo.pdf"));
			}catch{}
		}
		
		void DataAdministrativosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ImprimirRecibo(x);		
			try{
				System.Diagnostics.Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Administrativo\"+dataAdministrativos[1,x].Value.ToString()+" Recibo.pdf"));
			}catch{}
		}
		void DataAguinaldoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ImprimirRecibo(x);		
			try{
				System.Diagnostics.Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Recibos "+Fechecarpeta+@"\Aguinaldo\"+dataAguinaldo[1,x].Value.ToString()+" Recibo.pdf"));
			}catch{}
		}
		#endregion	
		
		#region REPORTE FISCAL
		void BtnReciboClick(object sender, EventArgs e)
		{
			if(tabOperadores.SelectedIndex == 0)
	        {
				ImprimirTodosPDF(dtOperador);
				Excels.ReporteNominalFiscal(principal, dtOperador.RowCount+dtOperador2.RowCount, Hoja);
			}
			if(tabOperadores.SelectedIndex == 1)
	        {
				ImprimirTodosPDF(dtOperador);
				Excels.ReporteNominalFiscal(principal, dtOperador.RowCount+dtOperador2.RowCount, Hoja);
			}
			else if(tabOperadores.SelectedIndex == 2)
	        {
				ImprimirTodosPDF(dataAdministrativos);
				Excels.ReporteNominalFiscal(principal, dataAdministrativos.RowCount, Hoja);
			}
		}
		
		void BtnResumenPercepcionesClick(object sender, EventArgs e)
		{
			if(tabOperadores.SelectedIndex == 0)
	        {
				ImprimirTodosPDF(dtOperador);
				Excels.ReporteNominalFiscal(principal, dtOperador.RowCount+dtOperador2.RowCount, Hoja, Alias);
			}
			else if(tabOperadores.SelectedIndex == 1)
	        {
				ImprimirTodosPDF(dtOperador2);
				Excels.ReporteNominalFiscal(principal, dtOperador.RowCount+dtOperador2.RowCount, Hoja);
			}
			else if(tabOperadores.SelectedIndex == 2)
	        {
				ImprimirTodosPDF(dataAdministrativos);
				Excels.ReporteNominalFiscal(principal, dataAdministrativos.RowCount, Hoja, Alias);
			}
		}
		#endregion
		
	
	}
}
