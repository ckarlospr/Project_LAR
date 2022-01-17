using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormCardex : Form
	{
		#region CONSTRUCTORES
		public FormCardex(FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		#endregion
		
		#region VARIABLES
		bool turno1 = true;
		bool turno2 = true;
		bool turno3 = true;
		bool turno4 = true;
		
		bool tipo1 = true;
		bool tipo2 = true;
		bool tipo3 = true;
		bool tipo4 = true;
		
		string consulta="";
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region INICIO
		void FormCardexLoad(object sender, EventArgs e)
		{
			dtpInicio.Value=DateTime.Now;
			dtpFin.Value=DateTime.Now;
			obternerConsulta();
			txtOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR WHERE tipo_empleado='OPERADOR'", "Alias");
           	txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region CAMBIO CHECKBOX
		void CbOperadorCheckedChanged(object sender, EventArgs e)
		{
			if(cbOperador.Checked)
			{
				txtOperador.Enabled=true;
			}
			else
			{
				txtOperador.Enabled=false;
			}
		}
		#endregion
		
		#region ADAPTADOR DATAGRID
		public void getDatos()
		{
			dgCardex.Rows.Clear();
			String estado="";
			
			if(cbOperador.Checked==true)
				consulta = consulta+" and O.Alias like '"+txtOperador.Text+"%' ";
			
			consulta = consulta+" order by H.FECHA, O.Alias, H.TURNO";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				int band=0;
				
				if(conn.leer["ESTATUS"].ToString()=="D")
					estado="Dormida";
				if(conn.leer["ESTATUS"].ToString()=="P")
					estado="Permiso";
				if(conn.leer["ESTATUS"].ToString()=="O")
					estado="Otro";
				if(conn.leer["ESTATUS"].ToString()=="C")
					estado="Combustible";
				if(conn.leer["ESTATUS"].ToString()=="N")
					estado="Movimientos no autorizados";
				if(conn.leer["ESTATUS"].ToString()=="X")
					estado="Excesos de velocidad";
				if(conn.leer["ESTATUS"].ToString()=="H")
					estado="Choque";
				if(conn.leer["ESTATUS"].ToString()=="G")
					estado="Guardia";
				if(conn.leer["ESTATUS"].ToString()=="R")
					estado="Reconocimiento de ruta";
				
				for(int x=0; x<dgCardex.Rows.Count; x++)
				{
					//MessageBox.Show(dgCardex[0,x].Value.ToString()+"=="+conn.leer["Alias"].ToString() +" && "+ dgCardex[2,x].Value.ToString()+"=="+conn.leer["FECHA"].ToString().Substring(0,10) +" && "+ dgCardex[5,x].Value.ToString()+"=="+estado);
					if(dgCardex[0,x].Value.ToString()==conn.leer["Alias"].ToString() && dgCardex[2,x].Value.ToString()==conn.leer["FECHA"].ToString().Substring(0,10) && dgCardex[5,x].Value.ToString()==estado && dgCardex[4,x].Value.ToString()==conn.leer["TURNO"].ToString())
					{
						band=1;
						if(dgCardex[6,x].Value.ToString()=="-" && conn.leer["DESCRIPCION"].ToString()!="")
						{
							dgCardex[6,x].Value=conn.leer["DESCRIPCION"].ToString();
							dgCardex[7,x].Value=conn.leer["usuario"].ToString();
						}
					}
				}
				
				if(band==0)
				{
					dgCardex.Rows.Add(conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["HORA"].ToString(), conn.leer["TURNO"].ToString(), estado, conn.leer["DESCRIPCION"].ToString(), conn.leer["usuario"].ToString(), conn.leer["ESTADO"].ToString(), conn.leer["SEGUIMIENTO"].ToString(), "*", conn.leer["ID_HO"].ToString());
				}
			}
			conn.conexion.Close();
			
			if(tipo3==true)
				getDatosTaller();
		}
		
		public void getDatosTaller()
		{
			if(cbOperador.Checked==true)
				conn.getAbrirConexion("select O.Alias, V.Numero, H.FECHA, H.HORA, H.turno, 'T' ESTATUS, H.DESCRIPCION, U.usuario " +
				                      "from HISTORIALVEHICULO H, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U " +
				                      "where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO and H.ID_UNIDAD=V.ID and H.ESTATUS='Taller' and O.Alias like '"+txtOperador.Text+"%' and H.FECHA between '"+dtpInicio.Value.ToString().Substring(0,10)+"' and '"+dtpFin.Value.ToString().Substring(0,10)+"' " +
				                      "order by H.FECHA, O.Alias, H.TURNO");
			else
				conn.getAbrirConexion("select O.Alias, V.Numero, H.FECHA, H.HORA, H.turno, 'T' ESTATUS, H.DESCRIPCION, U.usuario " +
				                      "from HISTORIALVEHICULO H, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U " +
				                      "where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO and H.ID_UNIDAD=V.ID and H.ESTATUS='Taller' and H.FECHA between '"+dtpInicio.Value.ToString().Substring(0,10)+"' and '"+dtpFin.Value.ToString().Substring(0,10)+"' " +
				                      "order by H.FECHA, O.Alias, H.TURNO");
			
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				int band=0;
				
				for(int x=0; x<dgCardex.Rows.Count; x++)
				{
					//MessageBox.Show(dgCardex[0,x].Value.ToString()+"=="+conn.leer["Alias"].ToString() +" && "+ dgCardex[2,x].Value.ToString()+"=="+conn.leer["FECHA"].ToString().Substring(0,10) +" && "+ dgCardex[5,x].Value.ToString()+"==TALLER");
					if(dgCardex[0,x].Value.ToString()==conn.leer["Alias"].ToString() && dgCardex[2,x].Value.ToString()==conn.leer["FECHA"].ToString().Substring(0,10) && dgCardex[5,x].Value.ToString()=="Taller" &&  dgCardex[4,x].Value.ToString()==conn.leer["turno"].ToString())
					{
						band=1;
						if(dgCardex[6,x].Value.ToString()=="-" && conn.leer["DESCRIPCION"].ToString()!="")
						{
							dgCardex[6,x].Value=conn.leer["DESCRIPCION"].ToString();
							dgCardex[7,x].Value=conn.leer["usuario"].ToString();
						}
					}
				}
				
				if(band==0)
				{
					dgCardex.Rows.Add(conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["HORA"].ToString(), conn.leer["TURNO"].ToString(), "Taller", conn.leer["DESCRIPCION"].ToString(), conn.leer["usuario"].ToString());
				}
			}
			conn.conexion.Close();
		}
		
		public void obternerConsulta()
		{
			consulta="select O.Alias, V.Numero, H.FECHA, H.HORA, H.TURNO, H.ESTATUS, H.DESCRIPCION, U.usuario, D.ESTADO, D.SEGUIMIENTO, H.ID_HO " +
				"from HISTORIALOPERADOR H, DETALLE_CARDEX D, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U " +
				"where H.ID_O=O.ID AND D.ID_H=H.ID_HO and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO AND H.ESTATUS!='A' AND H.ESTATUS!='G' AND H.ESTATUS!='E' and H.FECHA between '"+dtpInicio.Value.ToString().Substring(0,10)+"' and '"+dtpFin.Value.ToString().Substring(0,10)+"' " +
				"AND H.ESTATUS!='R' AND H.ESTATUS!='G' ";
			
			if(tipo1==false)
				consulta=consulta+" and H.ESTATUS!='D' ";
			if(tipo2==false)
				consulta=consulta+" and H.ESTATUS!='P' ";
			if(tipo3==false)
				consulta=consulta+" and H.ESTATUS!='T' ";
			if(tipo4==false)
				consulta=consulta+" and H.ESTATUS!='O' and H.ESTATUS!='C' AND H.ESTATUS!='N' AND H.ESTATUS!='X' AND H.ESTATUS!='H' ";
			if(turno1==false)
				consulta=consulta+" and H.TURNO!='Mañana' ";
			if(turno2==false)
				consulta=consulta+" and H.TURNO!='Medio día' ";
			if(turno3==false)
				consulta=consulta+" and H.TURNO!='Vespertino' ";
			if(turno4==false)
				consulta=consulta+" and H.TURNO!='Nocturno' ";
		}
		#endregion
		
		#region EVENTOS CONSULTA
		void CbDCheckedChanged(object sender, EventArgs e)
		{
			if(cbD.Checked==true)
				tipo1=true;
			else
				tipo1=false;
			
			
			obternerConsulta();
			getDatos();
		}
		
		void CbPCheckedChanged(object sender, EventArgs e)
		{
			if(cbP.Checked==true)
				tipo2=true;
			else
				tipo2=false;
			
			
			obternerConsulta();
			getDatos();
		}
		
		void CbTCheckedChanged(object sender, EventArgs e)
		{
			if(cbT.Checked==true)
				tipo3=true;
			else
				tipo3=false;
			
			
			obternerConsulta();
			getDatos();
		}
		
		void CbOCheckedChanged(object sender, EventArgs e)
		{
			if(cbO.Checked==true)
				tipo4=true;
			else
				tipo4=false;
			
			
			obternerConsulta();
			getDatos();
		}
		
		void CmTurno1CheckedChanged(object sender, EventArgs e)
		{
			if(cmTurno1.Checked==true)
				turno1=true;
			else
				turno1=false;
			
			
			obternerConsulta();
			getDatos();
		}
		
		void CmTurno2CheckedChanged(object sender, EventArgs e)
		{
			if(cmTurno2.Checked==true)
				turno2=true;
			else
				turno2=false;
			
			
			obternerConsulta();
			getDatos();
		}
		
		void CmTurno3CheckedChanged(object sender, EventArgs e)
		{
			if(cmTurno3.Checked==true)
				turno3=true;
			else
				turno3=false;
			
			
			obternerConsulta();
			getDatos();
		}
		
		void CmTurno4CheckedChanged(object sender, EventArgs e)
		{
			if(cmTurno4.Checked==true)
				turno4=true;
			else
				turno4=false;
			
			
			obternerConsulta();
			getDatos();
		}
		#endregion
		
		#region EVENTOS FECHAS
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			obternerConsulta();
			getDatos();
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			obternerConsulta();
			getDatos();
		}
		#endregion
		
		#region CAMBIO OPERADOR
		void TxtOperadorTextChanged(object sender, EventArgs e)
		{
			obternerConsulta();
			getDatos();
		}
		#endregion
		
		#region REPORTE EXCEL
		void BtnExcelClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();       
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 10;
		
			ExcelApp.Cells[1,1] = "ALIAS";
			ExcelApp.Cells[1,2] = "VEHICULO";
			ExcelApp.Cells[1,3] = "FECHA";
			ExcelApp.Cells[1,4] = "HORA";
			ExcelApp.Cells[1,5] = "TURNO";
			ExcelApp.Cells[1,6] = "ESTADO";
			ExcelApp.Cells[1,7] = "MOTIVO";
			ExcelApp.Cells[1,8] = "USUARIO";

			for(int x=0; x<dgCardex.Rows.Count; x++)
				{
					for(int y=0; y<dgCardex.ColumnCount; y++)
					{
						if(dgCardex.Rows[x].Cells[y].Value!=null)
							ExcelApp.Cells[x+2, y+1] = dgCardex.Rows[x].Cells[y].Value.ToString();
						else
							ExcelApp.Cells[x+2, y+1] = "-";
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
				CuadroDialogo.FileName ="Cardex";
				if(CuadroDialogo.ShowDialog() == DialogResult.OK)
				{
					ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
					ExcelApp.ActiveWorkbook.Saved = true;
					CuadroDialogo.Dispose();
					CuadroDialogo = null;
					ExcelApp.Quit();
					ExcelApp = null;
				}
				else
					MessageBox.Show("No Genero el Reporte ... ");
		}
		#endregion
		
		#region BOTONES
		void CmdMasClick(object sender, EventArgs e)
		{
			//new Transportes_LAR.Interfaz.Reportes.Cardex.FormOtros(this).ShowDialog();
			new Transportes_LAR.Interfaz.Reportes.Cardex.FormOtros(this).ShowDialog();
		}
		#endregion
		
		#region SEGUIMIENTO CARDEX
		void DgCardexCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==10 && dgCardex[11,e.RowIndex].Value!=null)
			{
				if(e.ColumnIndex==10 && dgCardex[11,e.RowIndex].Value.ToString()!="")
				{
					new Interfaz.Reportes.Cardex.FormSeguimiento(dgCardex[11,e.RowIndex].Value.ToString(), this).ShowDialog();
				}
			}
		}
		#endregion
		
	}
}
