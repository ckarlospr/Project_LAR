using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Combustible.EasyTrack
{
	public partial class FormDatos : Form
	{
		public FormDatos(FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		
		bool inicio = true;
		bool seleccion = false;
		
		#region REFERENCIAS
		FormPrincipal refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormDatosLoad(object sender, EventArgs e)
		{
			getTablas();
			getdgMacUnidad();
			getDatosEV();
			
			inicio = false;
		}
		#endregion
		
		// ********************************************************************
		// ******************************************************************** SEPARACION Y GUARDADO
		// ********************************************************************
		
		#region GET MAC
		void getTablas()
		{
			dgTablas.Rows.Clear();
			
			String consulta = "SELECT * FROM transportes_LAR.INFORMATION_SCHEMA.TABLES where TABLE_NAME like 'mac_%' and TABLE_NAME != 'MAC_OPERACION' and TABLE_NAME != 'MAC_UNIDAD'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgTablas.Rows.Add(conn.leer["TABLE_NAME"].ToString());
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgTablas.Rows.Count; x++)
			{
				consulta = "select V.*, V.Numero from MAC_UNIDAD M, VEHICULO V where M.ID_V=V.ID and M.MAC='"+dgTablas[0,x].Value.ToString().Substring(4,dgTablas[0,x].Value.ToString().Length-4)+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgTablas[1,x].Value=conn.leer["Numero"].ToString();
				}
				
				conn.conexion.Close();
			}
			
			dgTablas.ClearSelection();
		}
		#endregion
		
		#region EVENTOS
		void TxtDatosDoubleClick(object sender, EventArgs e)
		{
			txtDatos.SelectAll();
		}
		
		void DgTablasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtDatos.Enabled=true;
			getUltimoRegistro();
		}
		#endregion
		
		#region EVENTO BOTON SEPARA
		void BtnSeparaClick(object sender, EventArgs e)
		{
			dgDatos.Rows.Clear();
			int guiaRow = 0;
			int guiaColumn = 0;
			bool puntuacion = false;
			bool control = false;
			bool agrega = true;
			
			bool inicio = true;
			
			for(int x=0; x<txtDatos.Text.Length; x++)
			{
				if(agrega==true)
					dgDatos.Rows.Add("", "", "", "", "", "", "", "", "", "", "");
					
				if(Char.IsNumber(txtDatos.Text.Substring(x,1),0)==true || txtDatos.Text.Substring(x,1).Contains(".") || txtDatos.Text.Substring(x,1).Contains("-") || txtDatos.Text.Substring(x,1).Contains(":"))
				{
					puntuacion=false;
					control=false;
					dgDatos[guiaColumn, guiaRow].Value=dgDatos[guiaColumn, guiaRow].Value.ToString()+txtDatos.Text.Substring(x,1);
					agrega=false;
					inicio = false;
				}
				else if(Char.IsPunctuation(txtDatos.Text.Substring(x,1), 0)==true)
				{
					if(puntuacion==false )
					{
						if(inicio == false)
							guiaColumn++;
						
						puntuacion=true;
						agrega=false;
						inicio = false;
					}
				}
				else if(Char.IsControl(txtDatos.Text.Substring(x,1), 0)==true)
				{
					if(control==false)
					{
						guiaRow++;
						guiaColumn=0;
						control=true;
						agrega=true;
						inicio = false;
					}
					else
					{
						agrega=false;
						inicio = false;
					}
				}
			}
			
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region EVENTO GUARDADO DE COORDENADAS
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(dgTablas.SelectedCells.Count==1)
			{
				for(int x=0; x<dgDatos.Rows.Count; x++)
				{
					if(dgDatos[0,x].Value.ToString()!="")
					{
						String consulta = "DELETE FROM "+dgTablas[0,dgTablas.CurrentRow.Index].Value.ToString()+" WHERE ID="+dgDatos[0,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
						
						consulta = "INSERT INTO "+dgTablas[0,dgTablas.CurrentRow.Index].Value.ToString()+" VALUES (" +
											"'"+dgDatos[0,x].Value.ToString()+"', " +
											"'"+dgDatos[1,x].Value.ToString()+"', " +
											"'"+dgDatos[2,x].Value.ToString()+"', " +
											"'"+dgDatos[3,x].Value.ToString()+"', " +
											"'"+dgDatos[4,x].Value.ToString()+"', " +
											"'"+dgDatos[5,x].Value.ToString()+"', " +
											"'"+dgDatos[6,x].Value.ToString()+"', " +
											"'"+dgDatos[7,x].Value.ToString().Substring(0,Convert.ToString(dgDatos[7,x].Value).Length-1)+"', '0')";
												//dgDatos[7,x].Value.ToString().Substring(0,Convert.ToString(dgDatos[y,x].Value).Length-1)
												//dgPuntosMuertos[y,x].Value.ToString().Substring(0,Convert.ToString(dgPuntosMuertos[y,x].Value).Length-1)
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					
						dgDatos[0,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
		}
		#endregion
		
		// ********************************************************************
		// ******************************************************************** GUARDADO DE MAC
		// ********************************************************************
		
		#region GET MAC_UNIDAD
		void getdgMacUnidad()
		{
			dgMacUnidad.Rows.Clear();
			
			String consulta = "select ID, Numero from VEHICULO where estatus='1' and (Tipo_Unidad='Camión' or Tipo_Unidad='Camioneta' or id = 98) order by Numero";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgMacUnidad.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString(), "", "");
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgMacUnidad.Rows.Count; x++)
			{
				consulta = "select * from MAC_UNIDAD where ID_V="+dgMacUnidad[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgMacUnidad[2,x].Value=conn.leer["MAC"].ToString();
					dgMacUnidad[3,x].Value=conn.leer["MAC"].ToString();
					dgMacUnidad[2,x].Style.BackColor=Color.MediumSpringGreen;
				}
				
				conn.conexion.Close();
			}
			getDiasCarga();
			
			dgMacUnidad.ClearSelection();
		}
		#endregion
		
		#region GUARDA MAC
		void BtnGuardaMacClick(object sender, EventArgs e)
		{
			for(int x=0; x<dgMacUnidad.Rows.Count; x++)
			{
				if(dgMacUnidad[2,x].Value.ToString()!="" && dgMacUnidad[2,x].Value.ToString().Length==12)
				{
					if(verifica(x)=="INGRESA")
					{
						String consulta = "INSERT INTO MAC_UNIDAD VALUES ("+dgMacUnidad[0,x].Value.ToString()+", '"+dgMacUnidad[2,x].Value.ToString()+"')";
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();
						
						consulta =  "CREATE TABLE mac_"+dgMacUnidad[2,x].Value.ToString()+" (" +
									"ID BIGINT PRIMARY KEY," +
									"FECHA DATE," +
									"HORA TIME," +
									"LAT DECIMAL(17,12)," +
									"LON DECIMAL(17,12)," +
									"VELOCIDAD INT, " +
									"DISTANCIA DECIMAL(22,16)," +
									"TIEMPO INT," +
									"ESTATUS VARCHAR(10));";
						
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();
						
						dgMacUnidad[2,x].Style.BackColor=Color.MediumSpringGreen;
						dgMacUnidad[3,x].Value=dgMacUnidad[2,x].Value.ToString();
					}
					else
					{
						String consulta = "sp_rename 'mac_"+dgMacUnidad[3,x].Value.ToString()+"','mac_"+dgMacUnidad[2,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();
						
						consulta = "UPDATE MAC_UNIDAD SET MAC='"+dgMacUnidad[2,x].Value.ToString()+"' WHERE ID_V="+dgMacUnidad[0,x].Value.ToString();
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();
						
						dgMacUnidad[2,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
			
			dgMacUnidad.ClearSelection();
			getTablas();
		}
		
		String verifica(int selectRow)
		{
			String respuesta="";
				
			String consulta = "select * from MAC_UNIDAD where ID_V="+dgMacUnidad[0,selectRow].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				respuesta="MODIFICA";
			}
			else
			{
				respuesta="INGRESA";
			}
			
			conn.conexion.Close();
			
			return respuesta;
		}
		#endregion
		
		#region SELECCION DE MAC PARA DIAS
		void DgMacUnidadCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1 && e.ColumnIndex==2 && dgMacUnidad[2,e.RowIndex].Value.ToString()!="")
			{
				seleccion=true;
				getDias();
				seleccion=false;
			}
		}
		
		void DgMacUnidadSelectionChanged(object sender, EventArgs e)
		{
			if(inicio == false)
			{
				seleccion=true;
				getDias();
				seleccion=false;
			}
		}
		#endregion
		
		#region GET DIAS
		void getDias()
		{
			dgFechas.Rows.Clear();
			
			if(dgMacUnidad[2,dgMacUnidad.CurrentRow.Index].Value.ToString()!="")
			{
				String consulta = "select FECHA from mac_"+dgMacUnidad[2,dgMacUnidad.CurrentRow.Index].Value.ToString()+" group by FECHA order by FECHA";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgFechas.Rows.Add(conn.leer["FECHA"].ToString().Substring(0,10));
				}
				conn.conexion.Close();
				
				dgFechas.ClearSelection();
			}
		}
		#endregion
		
		#region GUARDADO
		void DgFechasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			/*if(e.RowIndex>-1)
			{
				getDiasCompleto();
			}*/
		}
		
		void DgFechasSelectionChanged(object sender, EventArgs e)
		{
			if(dgFechas.CurrentRow.Index>-1 && seleccion==false)
			{
				getDiasCompleto();
			}
		}
		
		void getDiasCompleto()
		{
			dgCompleto.Rows.Clear();
			
			for(int x=0; x<dgFechas.Rows.Count; x++)
			{
				if(dgFechas[0,x].Selected==true)
				{
					String consulta = "select * from mac_"+dgMacUnidad[3,dgMacUnidad.CurrentRow.Index].Value.ToString() +" WHERE FECHA='"+dgFechas[0,x].Value.ToString()+"' order by ID";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgCompleto.Rows.Add(conn.leer["ID"].ToString(), conn.leer["FECHA"].ToString(), conn.leer["HORA"].ToString(), conn.leer["LAT"].ToString(), conn.leer["LON"].ToString(), conn.leer["VELOCIDAD"].ToString(), conn.leer["DISTANCIA"].ToString(), conn.leer["TIEMPO"].ToString(), conn.leer["ESTATUS"].ToString());
					}
					conn.conexion.Close();
				}
			}
			
			dgCompleto.ClearSelection();
		}
		#endregion
		
		#region [ ********************* ]
		void TxtCantidadKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtCantidad.Text.Contains(".")==false))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void BtnGenerarClick(object sender, EventArgs e)
		{
			if(txtCantidad.Text!="")
			{
				dgDatos.Rows.Clear();
				for(int x=0; x<Convert.ToInt64(txtCantidad.Text); x++)
				{
					dgDatos.Rows.Add("", "", "", "", "", "", "", "");
				}
				dgDatos.ClearSelection();
			}
		}
		
		void DgDatosCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			
		}
		
		void DgDatosKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control && e.KeyCode == Keys.V)
			{
				string s = Clipboard.GetText();
				string[] lines = s.Split('\n');
				int row = dgDatos.CurrentCell.RowIndex;
				int col = dgDatos.CurrentCell.ColumnIndex;
				foreach (string line in lines)
				{
					if (row < dgDatos.RowCount && line.Length >0)
					{
						string[] cells = line.Split('\t');
						for (int i = 0; i < cells.GetLength(0); ++i)
						{
							if (col + i <this.dgDatos.ColumnCount)
							{
								dgDatos[col + i, row].Value = Convert.ChangeType(cells[i], dgDatos[col + i, row].ValueType);
							}
							else
							{
								break;
							}
						}
						row++;
					}
					else
					{
						break;
					}
				}
			}
		}
		#endregion
		
		#region
		void getDiasCarga()
		{
			for(int x=3; x>0; x--)
			{
				DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
				columna.Name = "D"+x;
				columna.HeaderText = DateTime.Now.AddDays(-x).ToString("dd/MM") ;
				columna.ReadOnly = true;
				columna.Width=70;
				columna.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				dgMacUnidad.Columns.Add(columna);
			}
			
			
			for(int x=0; x<dgMacUnidad.Rows.Count; x++)
			{
				if(dgMacUnidad[3,x].Value.ToString()!="")
				{
					int guia = 1;
					for(int y=3; y>0; y--)
					{
						String consulta = "select top 1 * from mac_"+dgMacUnidad[3,x].Value.ToString()+" where FECHA='"+DateTime.Now.AddDays(-y).ToString("dd/MM/yyyy")+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgMacUnidad[3+guia,x].Value="SI";
							dgMacUnidad[3+guia,x].Style.BackColor=Color.MediumSpringGreen;
						}
						else
						{
							dgMacUnidad[3+guia,x].Value="NO";
							dgMacUnidad[3+guia,x].Style.BackColor=Color.Red;
						}
						conn.conexion.Close();
						guia++;
					}
				}
			}
		}
		#endregion
		
		void BtnEliminaClick(object sender, EventArgs e)
		{
			if(dgFechas.SelectedRows.Count>0)
			{
				for(int x=0; x<dgFechas.Rows.Count; x++)
				{
					if(dgFechas[0,x].Selected==true)
					{
						String consulta = "DELETE FROM mac_"+dgMacUnidad[2,dgMacUnidad.CurrentRow.Index].Value.ToString()+" WHERE FECHA='"+dgFechas[0,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
			}
		}
		
		void getUltimoRegistro()
		{
			dgAnterior.Rows.Clear();
			
			//String consulta = "select top 1 * from "+dgTablas[0,dgTablas.CurrentRow.Index].Value.ToString()+" order by ID desc ";
			String consulta = "select top 1 * from "+dgTablas[0,dgTablas.CurrentRow.Index].Value.ToString()+" where FECHA in (select top 1 FECHA from "+dgTablas[0,dgTablas.CurrentRow.Index].Value.ToString()+" order by FECHA desc) order by ID desc ";
			
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgAnterior.Rows.Add(conn.leer["ID"].ToString(), conn.leer["FECHA"].ToString(), conn.leer["HORA"].ToString(), conn.leer["LAT"].ToString(), conn.leer["LON"].ToString(), conn.leer["VELOCIDAD"].ToString(), conn.leer["DISTANCIA"].ToString(), conn.leer["TIEMPO"].ToString(), conn.leer["ESTATUS"].ToString());
			}
			conn.conexion.Close();
			
			dgAnterior.ClearSelection();
		}
		
		//******************************************************************************************************************************************************
		//**************************************************************** EXCESOS DE VELOCIDAD ****************************************************************
		//******************************************************************************************************************************************************
		
		#region [ EXCESOS DE VELOCIDAD ]
		void getDatosEV()
		{
			dgVelocidades.Rows.Clear();
			
			String consulta = "SELECT * FROM transportes_LAR.INFORMATION_SCHEMA.TABLES where TABLE_NAME like 'mac_%' and TABLE_NAME != 'MAC_OPERACION' and TABLE_NAME != 'MAC_UNIDAD'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgVelocidades.Rows.Add(conn.leer["TABLE_NAME"].ToString());
				dgVelocidades.Rows.Add(conn.leer["TABLE_NAME"].ToString());
				dgVelocidades.Rows.Add(conn.leer["TABLE_NAME"].ToString());
				dgVelocidades.Rows.Add(conn.leer["TABLE_NAME"].ToString());
				dgVelocidades.Rows.Add(conn.leer["TABLE_NAME"].ToString());
			}
			
			conn.conexion.Close();
			
			int dias = -5;
			bool cambio = true; 
				
			for(int x=0; x<dgVelocidades.Rows.Count; x++)
			{
				if(dias==0)
				{
					dias=-5;
					cambio=!(cambio);
				}
				
				if(cambio==false)
				{
					for(int y=0; y<4; y++)
					{
						dgVelocidades[y,x].Style.BackColor=Color.LightGray;
					}
				}
				
				consulta = "select V.*, V.Numero from MAC_UNIDAD M, VEHICULO V where M.ID_V=V.ID and M.MAC='"+dgVelocidades[0,x].Value.ToString().Substring(4,dgVelocidades[0,x].Value.ToString().Length-4)+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgVelocidades[1,x].Value=conn.leer["Numero"].ToString();
				}
				conn.conexion.Close();
				
				consulta = "select O.Alias from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O where V.ID=A.ID_UNIDAD and A.ID_OPERADOR=O.ID and V.Numero='"+dgVelocidades[1,x].Value.ToString()+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgVelocidades[2,x].Value=conn.leer["Alias"].ToString();
				}
				else
				{
					dgVelocidades[2,x].Value="S/A";
				}
				conn.conexion.Close();
				
				dgVelocidades[3,x].Value=DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy");
				dias++;
			}
			getVelocidades();
			dgVelocidades.ClearSelection();
		}
		
		void getVelocidades()
		{
			for(int x=0; x<dgVelocidades.Rows.Count; x++)
			{
				bool primero = false;
				bool segundo = false;
				bool tercero = false;
				
				String consulta = " select * from "+dgVelocidades[0,x].Value.ToString()+" where VELOCIDAD>'80' and FECHA='"+dgVelocidades[3,x].Value.ToString()+"' ";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(Convert.ToDouble(conn.leer["VELOCIDAD"])>80 && Convert.ToDouble(conn.leer["VELOCIDAD"])<85)
					{
						dgVelocidades[4,x].Value="SI";
						dgVelocidades[4,x].Style.BackColor=Color.MediumSpringGreen;
						primero=true;
					}
					else if(Convert.ToDouble(conn.leer["VELOCIDAD"])>=85 && Convert.ToDouble(conn.leer["VELOCIDAD"])<92)
					{
						dgVelocidades[5,x].Value="SI";
						dgVelocidades[5,x].Style.BackColor=Color.MediumSpringGreen;
						segundo=true;
					}
					else if(Convert.ToDouble(conn.leer["VELOCIDAD"])>=92)
					{
						dgVelocidades[6,x].Value="SI";
						dgVelocidades[6,x].Style.BackColor=Color.MediumSpringGreen;
						tercero=true;
					}
				}
				conn.conexion.Close();
				
				if(primero==false)
				{
					dgVelocidades[4,x].Value="NO";
					dgVelocidades[4,x].Style.BackColor=Color.White;
				}
				
				if(segundo==false)
				{
					dgVelocidades[5,x].Value="NO";
					dgVelocidades[5,x].Style.BackColor=Color.White;
				}
				
				if(tercero==false)
				{
					dgVelocidades[6,x].Value="NO";
					dgVelocidades[6,x].Style.BackColor=Color.White;
				}
			}
		}
		
		void DgVelocidadesSelectionChanged(object sender, EventArgs e)
		{
			dgVE.Rows.Clear();
			
			if(dgVelocidades.CurrentCell.RowIndex>3)
			{
				for(int x=0; x<dgVelocidades.Rows.Count; x++)
				{
					for(int y=4; y<dgVelocidades.Columns.Count; y++)
					{
						if(dgVelocidades[y,x].Selected==true)
						{
							int minimo=80;
							int maximo=200;
							
							if(dgVelocidades.Columns[y].HeaderText=="80")
							{
								minimo=80;
								maximo=85;
							}
							else if(dgVelocidades.Columns[y].HeaderText=="80")
							{
								minimo=85;
								maximo=92;
							}
							else if(dgVelocidades.Columns[y].HeaderText=="80")
							{
								minimo=92;
								maximo=200;
							}
							
							String consulta = " select * from "+dgVelocidades[0,x].Value.ToString()+" where VELOCIDAD>'"+minimo+"' and VELOCIDAD<='"+maximo+"' and FECHA='"+dgVelocidades[3,x].Value.ToString()+"' ";
							conn.getAbrirConexion(consulta);
							conn.leer=conn.comando.ExecuteReader();
							while(conn.leer.Read())
							{
								dgVE.Rows.Add(dgVelocidades[1,x].Value.ToString(), dgVelocidades[2,x].Value.ToString(), conn.leer["ID"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["HORA"].ToString(), conn.leer["LAT"].ToString(), conn.leer["LON"].ToString(), conn.leer["VELOCIDAD"].ToString(), conn.leer["DISTANCIA"].ToString(), conn.leer["TIEMPO"].ToString());
							}
							conn.conexion.Close();
						}
					}
				}
			}
			
			dgVE.ClearSelection();
		}
		
		void BtnExcelEVClick(object sender, EventArgs e)
		{
			if(dgVelocidades.Rows.Count>0)
			{
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
					
				int i = 1;
			
				++i;
				ExcelApp.Cells[i,  1] 	= "MAC";
				ExcelApp.Cells[i,  2] 	= "UNIDAD";
				ExcelApp.Cells[i,  3] 	= "OPERADOR";
				ExcelApp.Cells[i,  4] 	= "FECHA";
				ExcelApp.Cells[i,  5] 	= "80";
				ExcelApp.Cells[i,  6] 	= "85";
				ExcelApp.Cells[i,  7] 	= "92";
				
				for(int y=0; y<dgVelocidades.Rows.Count; y++)
				{
					++i;
					
					ExcelApp.Cells[i,  1]	= dgVelocidades[0,y].Value.ToString();
					ExcelApp.Cells[i,  2]	= dgVelocidades[1,y].Value.ToString();
					ExcelApp.Cells[i,  3]	= dgVelocidades[2,y].Value.ToString();
					ExcelApp.Cells[i,  4]	= dgVelocidades[3,y].Value.ToString();
					ExcelApp.Cells[i,  5]	= dgVelocidades[4,y].Value.ToString();
					ExcelApp.Cells[i,  6]	= dgVelocidades[5,y].Value.ToString();
					ExcelApp.Cells[i,  7]	= dgVelocidades[6,y].Value.ToString();
				}
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "VELOCIDADES_"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
		void BtnExcelEV2Click(object sender, EventArgs e)
		{
			if(dgVE.Rows.Count>0)
			{
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
					
				int i = 1;
			
				++i;
				ExcelApp.Cells[i,  1] 	= "UNIDAD";
				ExcelApp.Cells[i,  2] 	= "OPERADOR";
				ExcelApp.Cells[i,  3] 	= "ID";
				ExcelApp.Cells[i,  4] 	= "FECHA";
				ExcelApp.Cells[i,  5] 	= "HORA";
				ExcelApp.Cells[i,  6] 	= "LAT";
				ExcelApp.Cells[i,  7] 	= "LON";
				ExcelApp.Cells[i,  8] 	= "VELOCIDAD";
				ExcelApp.Cells[i,  9] 	= "DISTANCIA";
				ExcelApp.Cells[i,  10] 	= "TIEMPO";
				
				for(int y=0; y<dgVE.Rows.Count; y++)
				{
					++i;
					
					ExcelApp.Cells[i,  1]	= dgVE[0,y].Value.ToString();
					ExcelApp.Cells[i,  2]	= dgVE[1,y].Value.ToString();
					ExcelApp.Cells[i,  3]	= dgVE[2,y].Value.ToString();
					ExcelApp.Cells[i,  4]	= dgVE[3,y].Value.ToString();
					ExcelApp.Cells[i,  5]	= dgVE[4,y].Value.ToString();
					ExcelApp.Cells[i,  6]	= dgVE[5,y].Value.ToString();
					ExcelApp.Cells[i,  7]	= dgVE[6,y].Value.ToString();
					ExcelApp.Cells[i,  8]	= dgVE[7,y].Value.ToString();
					ExcelApp.Cells[i,  9]	= dgVE[8,y].Value.ToString();
					ExcelApp.Cells[i,  10]	= dgVE[9,y].Value.ToString();
				}
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "DETALLADO_"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
	}
}
