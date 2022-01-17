using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormOperadores : Form
	{
		// ******************* REFERENCIAS LOGISTICA OPERACIONES ********************
		
		public List<Transportes_LAR.Interfaz.Operaciones.FormOperacionesOperador> RefOperadores = new List<Transportes_LAR.Interfaz.Operaciones.FormOperacionesOperador>();
		
		
		// **************************************************************************
		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		public Interfaz.FormPrincipal principal = null;
		int localizacionx=2;
		int localizaciony=0;
		int x = 0;
		public bool MsjGral=false;
		public String DIA="";
		public String TURNO="";
		
		//Interfaz.Operaciones.FormOperacionesOperador Operadores = null;
		
		public  FormOperadores(Interfaz.FormPrincipal principal, String fecha, String turno)
		{
			InitializeComponent();
			this.principal = principal;
			DIA=fecha;
			TURNO=turno;
		}
		
		public FormOperadores()
		{
			InitializeComponent();
		}
		
		void FormOperadoresLoad(object sender, EventArgs e)
		{
			GeneradorOperadoresInt();
			principal.RefOperadoresPrinc=RefOperadores;
			
			tcOperadores.TabPages[0].Text=TURNO;
			tcOperadores.TabPages[1].Text=getTurnoSecundario(TURNO);
			tcOperadores.SendToBack();
			
			getMsjGral();
		}
		
		public String getTurnoSecundario(String turno)
		{
			String Respuesta="";
			
			if(turno=="Mañana")
				Respuesta="Nocturno";
			else if(turno=="Medio día")
				Respuesta="Mañana";
			else if(turno=="Vespertino")
				Respuesta="Medio día";
			else if(turno=="Vespertino")
				Respuesta="Medio día";
			else if(turno=="Nocturno")
				Respuesta="Vespertino";
			
			return Respuesta;
		}
		
		private void GeneradorOperadoresInt()
		{
			conn.getAbrirConexion("select V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad from OPERADOR O, ASIGNACIONUNIDAD AU, VEHICULO V Where O.ID = AU.ID_OPERADOR AND AU.ID_UNIDAD=V.ID AND AU.ID_OPERADOR IN (SELECT ID_OPERADOR FROM ASIGNACIONUNIDAD) AND V.Tipo_Unidad='Camión' group by V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad order by Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Interfaz.Operaciones.FormOperacionesOperador Operadores = new Interfaz.Operaciones.FormOperacionesOperador(this);
				Operadores.TopLevel = false;
				this.pOperadorInt.Tag = Operadores;
				this.pOperadorInt.Controls.Add(Operadores);
				this.pOperadorInt.Location = new System.Drawing.Point(0, 0);
				Operadores.Location = new System.Drawing.Point(localizacionx, localizaciony);
				Operadores.txtAlias.Text = conn.leer["alias"].ToString();
				Operadores.txtEstado.Text = conn.leer["Estatus"].ToString();
				Operadores.ID_OPERADOR = Convert.ToInt16(conn.leer["id"]);
				Operadores.ID_VEHICULO = Convert.ToInt16(conn.leer["ID_UNIDAD"]);
				Operadores.tipoVehiculo = conn.leer["Tipo_Unidad"].ToString();
				Operadores.numeroVehiculo = conn.leer["Numero"].ToString();
				Operadores.getEstatus();
				Operadores.txtNum.Text = "0";
				Operadores.Show();
				localizacionx = localizacionx + 82;
				++x;
				if(x==9)
				{
					//localizaciony = localizaciony + 75;
					localizaciony = localizaciony + 50;
					x=0;
					localizacionx = 2;
				}
			}
			conn.conexion.Close();
			
			
			localizacionx=2;
			localizaciony=0;
			x=0;
			
			conn.getAbrirConexion("select V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad from OPERADOR O, ASIGNACIONUNIDAD AU, VEHICULO V WHERE O.ID = AU.ID_OPERADOR AND AU.ID_UNIDAD=V.ID AND AU.ID_OPERADOR IN (SELECT ID_OPERADOR FROM ASIGNACIONUNIDAD) AND V.Tipo_Unidad='Camioneta' group by V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad order by Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Interfaz.Operaciones.FormOperacionesOperador Operadores = new Interfaz.Operaciones.FormOperacionesOperador(this);
				Operadores.TopLevel = false;
				this.pOperadorCam.Tag = Operadores;
				this.pOperadorCam.Controls.Add(Operadores);
				this.pOperadorCam.Location = new System.Drawing.Point(0, 0);
				Operadores.Location = new System.Drawing.Point(localizacionx, localizaciony);
				Operadores.txtAlias.Text = conn.leer["alias"].ToString();
				Operadores.txtEstado.Text = conn.leer["Estatus"].ToString();
				Operadores.ID_OPERADOR = Convert.ToInt16(conn.leer["id"]);
				Operadores.ID_VEHICULO = Convert.ToInt16(conn.leer["ID_UNIDAD"]);
				Operadores.tipoVehiculo = conn.leer["Tipo_Unidad"].ToString();
				Operadores.numeroVehiculo = conn.leer["Numero"].ToString();
				
				
				Operadores.getEstatus();
				Operadores.txtNum.Text = "0";
				Operadores.Show();
				localizacionx = localizacionx + 82;
				++x;
				if(x==9)
				{
					//localizaciony = localizaciony + 75;
					localizaciony = localizaciony + 50;
					x=0;
					localizacionx = 2;
				}
			}
			conn.conexion.Close();
			
			// *********************************************externos
			localizacionx=2;
			localizaciony=0;
			x=0;
			conn.getAbrirConexion("select Alias, ID from OPERADOR where tipo_empleado='Externo' and estatus='1'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Interfaz.Operaciones.FormOperacionesOperador Operadores = new Interfaz.Operaciones.FormOperacionesOperador(this);
				Operadores.TopLevel = false;
				this.pOperadorExterno.Tag = Operadores;
				this.pOperadorExterno.Controls.Add(Operadores);
				this.pOperadorExterno.Location = new System.Drawing.Point(0, 0);
				Operadores.Location = new System.Drawing.Point(localizacionx, localizaciony);
				Operadores.txtAlias.Text = conn.leer["alias"].ToString();
				Operadores.txtEstado.Text = "A";
				Operadores.ID_OPERADOR = Convert.ToInt16(conn.leer["id"]);
				Operadores.ID_VEHICULO = 109;
				Operadores.numeroVehiculo = "100";
				Operadores.tipoVehiculo = "Camion/Camioneta";
				Operadores.txtNum.Text = "0";
				Operadores.tipo="Externo";
				Operadores.Show();
				localizacionx = localizacionx + 82;
				++x;
				if(x==9)
				{
					//localizaciony = localizaciony + 75;
					localizaciony = localizaciony + 50;
					x=0;
					localizacionx = 2;
				}
			}
			conn.conexion.Close();
		}
		
		public void CapturaRefOperadores(Transportes_LAR.Interfaz.Operaciones.FormOperacionesOperador RefOpera)
		{
			RefOperadores.Add(RefOpera);
		}
		
		void FormOperadoresFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.prinOperador=false;
			
			switch(e.CloseReason)
		    {
		        case CloseReason.FormOwnerClosing:
		            cerrado();
		            break;
		        case CloseReason.MdiFormClosing:
		            principal.prinOperador=true;
		            cerrado();
		            e.Cancel=true;
		            break;
		        case CloseReason.UserClosing:
		            e.Cancel=false;
		            cerrado();
            	break;
			}
		}
		
		public void cerrado()
		{
			Conexion_Servidor.Desapacho.SQL_Operaciones conexx = new Conexion_Servidor.Desapacho.SQL_Operaciones();
					
    		for(int x=0; x<RefOperadores.Count; x++)
			{
    			conexx.guardaEstatus(RefOperadores[x].ID_OPERADOR, RefOperadores[x].txtEstado.Text, DIA, TURNO, Convert.ToInt16(RefOperadores[x].txtNum.Text));
			}
		}
		
		void POperadorIntMouseUp(object sender, MouseEventArgs e)
		{
			
		}
		
		void POperadorIntMouseEnter(object sender, EventArgs e)
		{
			pOperadorInt.Select();
		}
		
		#region MENSAJE GENERAL
		public void getMsjGral()
		{
			String anio = principal.Fecha.Substring(6,4);
			String mes = principal.Fecha.Substring(3,2);
			int dia = Convert.ToInt16(principal.Fecha.Substring(0,2));
			
			String miTurno = "";
			
			if(principal.Turno=="Mañana")
			{
				miTurno="Nocturno";
				if(dia>1)
					dia=dia-1;
			}
			if(principal.Turno=="Medio día")
				miTurno="Mañana";
			if(principal.Turno=="Vespertino")
				miTurno="Medio día";
			if(principal.Turno=="Nocturno")
				miTurno="Vespertino";
			
			String mi_dia="";
			if(dia<10)
				mi_dia="0"+dia;
			else
				mi_dia=dia.ToString();
				
			String fech = anio+"-"+mes+"-"+mi_dia;
			
			List<Interfaz.Operaciones.Dato.msjGral> listaMsj = new Conexion_Servidor.Desapacho.SQL_Operaciones().getMsjGral();
			
			if(listaMsj!=null)
			{
				dgHoy.Rows.Clear();
				dgTodos.Rows.Clear();
				
				for(int x=0; x<listaMsj.Count; x++)
				{
					dgTodos.Rows.Add(listaMsj[x].ID_MSJ, listaMsj[x].USUARIO, listaMsj[x].FECHA.Substring(0,10), listaMsj[x].HORA.Substring(0,5), listaMsj[x].MSJ);
					
					if(listaMsj[x].FECHA.Substring(0,10)==principal.Fecha)
					{
						dgHoy.Rows.Add(listaMsj[x].ID_MSJ, listaMsj[x].USUARIO, listaMsj[x].HORA.Substring(0,5), listaMsj[x].MSJ);
					}
				}
			}
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			new FormMsjGral(this).ShowDialog();
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Desapacho.SQL_Operaciones().eliminarMsjGral(Convert.ToInt16(dgHoy.CurrentRow.Cells[0].Value));
			getMsjGral();
		}
		#endregion
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			cerrado();
		}
		
		void CmdExportaExcelClick(object sender, EventArgs e)
		{
			imprimirDatosOperador();
		}
		
		public void imprimirDatosOperador()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			
			++i;
			ExcelApp.Cells[i,  1] = DIA;
			ExcelApp.Cells[i,  2] = TURNO;
			
			++i;
			++i;
			ExcelApp.Cells[i,  1] = "CAMIONES";
			++i;
			ExcelApp.Cells[i,  1] 	= "UNIDAD";
			ExcelApp.Cells[i,  2] 	= "OPERADOR";
			ExcelApp.Cells[i,  3] 	= "ESTATUS";
			//ExcelApp.Cells[i,  4] 	= "VIAJES";
			
			String consulta = "select V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad from OPERADOR O, ASIGNACIONUNIDAD AU, VEHICULO V Where O.ID = AU.ID_OPERADOR AND AU.ID_UNIDAD=V.ID AND AU.ID_OPERADOR IN (SELECT ID_OPERADOR FROM ASIGNACIONUNIDAD) AND  V.Tipo_Unidad='Camión'  group by V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad  order by Alias";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;
				
				ExcelApp.Cells[i,  1] 	= conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  2] 	= conn.leer["alias"].ToString();
				ExcelApp.Cells[i,  3] 	= conn.leer["Estatus"].ToString();
				//ExcelApp.Cells[i,  4] 	= conn.leer["Tipo_Unidad"].ToString();
			}
			
			conn.conexion.Close();
			
			++i;
			ExcelApp.Cells[i,  1] = "CAMIONETAS";
			++i;
			ExcelApp.Cells[i,  1] 	= "UNIDAD";
			ExcelApp.Cells[i,  2] 	= "OPERADOR";
			ExcelApp.Cells[i,  3] 	= "ESTATUS";
			//ExcelApp.Cells[i,  4] 	= "VIAJES";
			
			consulta = "select V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad from OPERADOR O, ASIGNACIONUNIDAD AU, VEHICULO V WHERE O.ID = AU.ID_OPERADOR AND AU.ID_UNIDAD=V.ID AND AU.ID_OPERADOR IN (SELECT ID_OPERADOR FROM ASIGNACIONUNIDAD) AND V.Tipo_Unidad='Camioneta' group by V.Numero, O.id, O.alias, AU.Estatus, AU.ID_UNIDAD, V.Tipo_Unidad order by Alias";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;
				
				ExcelApp.Cells[i,  1] 	= conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  2] 	= conn.leer["alias"].ToString();
				ExcelApp.Cells[i,  3] 	= conn.leer["Estatus"].ToString();
				//ExcelApp.Cells[i,  4] 	= conn.leer["Tipo_Unidad"].ToString();
			}
			
			conn.conexion.Close();
			
			// ---------- cuadro de dialogo para Guardar
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "OPERADORES_"+DIA.Substring(0,2)+"_"+DIA.Substring(3,2)+"_"+DIA.Substring(6,4)+"_"+TURNO;
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
}
