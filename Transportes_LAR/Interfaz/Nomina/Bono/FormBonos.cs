using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Bono
{
	public partial class FormBonos : Form
	{
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		private Interfaz.Nomina.Bono.FormPerdida formcomBonos = null;
		private Interfaz.Nomina.Bono.FormBonificacion formBonificacion = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region VARIABLES
		bool apagadorcom = false;
		public static String User;
		String id_usuario = "";
		#endregion
		
		#region CONSTRUCTORES
		public FormBonos()
		{
			InitializeComponent();
		}
		
		public FormBonos(Interfaz.FormPrincipal principal, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			this.id_usuario =  id_usuario;
		}
		
		public FormBonos(Interfaz.FormPrincipal principal, String alias, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			txtAlias.Text = alias;
			this.id_usuario =  id_usuario;
		}
		#endregion
		
		#region LOAD
		void FormBonosLoad(object sender, EventArgs e)
		{
		  	dtFechaActual.Value = DateTime.Now;
		  	PeriodoBonos();
		  	AdaptadorOperador();
		  	ActualizarBonos();
	    	User = principal.nombreUsuario;
	  		txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
		  	txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
		    txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		    if(principal.lblDatoNivel.Text!="GERENCIAL" && principal.lblDatoNivel.Text!="MASTER")
		    {
		    	dataBonos.Columns[7].Visible = false;
		    	dataBonos.Columns[6].Visible = false;
		    }
		    else
		    {
		    	dataBonos.Columns[7].Visible = true;
		    	dataBonos.Columns[6].Visible = true;
		    }
		    Buscador(txtAlias);
		}
		#endregion
		
		#region EVENTO CLICK
		void DataBonosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string sentencia = "";
			string Normal = "";
			string Extra = "";
			string Especial = "";
			string ApoyoCoordinacion = "";
			string Bonificacion = "";
			
			if(e.RowIndex>-1)
			{
				if(dataBonos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "0" || dataBonos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "False")
				{
					dataBonos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;	
					dataBonos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
						if(e.ColumnIndex==8)
						{
							dataBonos.Rows[e.RowIndex].Cells[3].Value = dataBonos.Rows[e.RowIndex].Cells[8].Value;	
							dataBonos.Rows[e.RowIndex].Cells[3].Value = dataBonos.Rows[e.RowIndex].Cells[8].Value;
							formBonificacion = new Interfaz.Nomina.Bono.FormBonificacion(User, dataBonos.Rows[e.RowIndex].Cells[1].Value.ToString(),
										apagadorcom, principal, dataBonos.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                        dtInicio, dtCorte, dataBonos, e.RowIndex, dataBonos.Rows[e.RowIndex].Cells[2].Value.ToString(), id_usuario);
							formBonificacion.ShowDialog();
							if(new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaBono(dataBonos.Rows[e.RowIndex].Cells[1].Value.ToString(), dtInicio.Value.ToString("dd-MM-yyyy"), dtCorte.Value.ToString("dd-MM-yyyy"))==false)
							{
								conn.getAbrirConexion("insert into NUEVO_HISTORIAL_BONO_OPERADOR values ("+dataBonos.Rows[e.RowIndex].Cells[1].Value+", '"+dataBonos.Rows[e.RowIndex].Cells[3].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[4].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[5].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[6].Value+"', '"+dtInicio.Value.ToString("dd-MM-yyyy")+"', '"+dtCorte.Value.ToString("dd-MM-yyyy")+"', 'N/A', 'NINGUNA', '0', '"+principal.idUsuario+"', '0.00')");
								conn.comando.ExecuteNonQuery();
								conn.conexion.Close();
							}
						}
				}
				else
				{
					dataBonos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
					dataBonos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
					if(e.ColumnIndex==8)
					{
						dataBonos.Rows[e.RowIndex].Cells[3].Value = dataBonos.Rows[e.RowIndex].Cells[8].Value;	
						dataBonos.Rows[e.RowIndex].Cells[3].Value = dataBonos.Rows[e.RowIndex].Cells[8].Value;
					}
					if(e.ColumnIndex==3)
					{
						apagadorcom = false;
						formcomBonos = new Interfaz.Nomina.Bono.FormPerdida(User, dataBonos.Rows[e.RowIndex].Cells[1].Value.ToString(),
																		apagadorcom, principal, dataBonos.Rows[e.RowIndex].Cells[0].Value.ToString(),
						                                                dtInicio, dtCorte, dataBonos, e.RowIndex);
						formcomBonos.ShowDialog();
					}
				}
				
				if(dataBonos.Rows[e.RowIndex].Cells[3].Value.ToString()=="1"||dataBonos.Rows[e.RowIndex].Cells[3].Value.ToString()=="True")
					Normal = "1";
				else
					Normal = "0";
				
				if(dataBonos.Rows[e.RowIndex].Cells[4].Value.ToString()=="1"||dataBonos.Rows[e.RowIndex].Cells[4].Value.ToString()=="True")
				{
					Extra = "1";
					if(new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaBono(dataBonos.Rows[e.RowIndex].Cells[1].Value.ToString(), dtInicio.Value.ToString("dd-MM-yyyy"), dtCorte.Value.ToString("dd-MM-yyyy"))==false)
					{
						conn.getAbrirConexion("insert into NUEVO_HISTORIAL_BONO_OPERADOR values ("+dataBonos.Rows[e.RowIndex].Cells[1].Value+", '"+dataBonos.Rows[e.RowIndex].Cells[3].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[4].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[5].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[6].Value+"', '"+dtInicio.Value.ToString("dd-MM-yyyy")+"', '"+dtCorte.Value.ToString("dd-MM-yyyy")+"', 'N/A', 'NINGUNA', '0', '"+principal.idUsuario+"', '0.00')");
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
				else
					Extra = "0";
				
				if(dataBonos.Rows[e.RowIndex].Cells[5].Value.ToString()=="1"||dataBonos.Rows[e.RowIndex].Cells[5].Value.ToString()=="True")
				{
					Especial = "1";
					if(new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaBono(dataBonos.Rows[e.RowIndex].Cells[1].Value.ToString(), dtInicio.Value.ToString("dd-MM-yyyy"), dtCorte.Value.ToString("dd-MM-yyyy"))==false)
					{
						conn.getAbrirConexion("insert into NUEVO_HISTORIAL_BONO_OPERADOR values ("+dataBonos.Rows[e.RowIndex].Cells[1].Value+", '"+dataBonos.Rows[e.RowIndex].Cells[3].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[4].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[5].Value+"', '"+dataBonos.Rows[e.RowIndex].Cells[6].Value+"', '"+dtInicio.Value.ToString("dd-MM-yyyy")+"', '"+dtCorte.Value.ToString("dd-MM-yyyy")+"', 'N/A', 'NINGUNA', '0', '"+principal.idUsuario+"', '0.00')");
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
				else
					Especial = "0";
				
				if(dataBonos.Rows[e.RowIndex].Cells[6].Value.ToString()=="1"||dataBonos.Rows[e.RowIndex].Cells[6].Value.ToString()=="True")
					ApoyoCoordinacion = "1";
				else
					ApoyoCoordinacion = "0";
				
				if(dataBonos.Rows[e.RowIndex].Cells[8].Value.ToString()=="1"||dataBonos.Rows[e.RowIndex].Cells[8].Value.ToString()=="True")
					Bonificacion = "1";
				else
					Bonificacion = "0";
				
				sentencia = "UPDATE BONO_OPERADOR SET ESTATUS4='"+ApoyoCoordinacion+"', CANTIDAD='"+dataBonos.Rows[e.RowIndex].Cells[7].Value+"'  where ID="+dataBonos.Rows[e.RowIndex].Cells[0].Value;
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
	
				sentencia = "UPDATE NUEVO_HISTORIAL_BONO_OPERADOR SET ESTATUS='"+Normal+"', ESTATUS2='"+Extra+"', ESTATUS3='"+Especial+"', ESTATUS4='"+ApoyoCoordinacion+"', BONIFICACION='"+Bonificacion+"', ID_USUARIO='"+principal.idUsuario+"'  where FECHA_INICIO='"+dtInicio.Value.ToString("dd-MM-yyyy")+"' and FECHA_FIN='"+dtCorte.Value.ToString("dd-MM-yyyy")+"' and ID_O="+dataBonos.Rows[e.RowIndex].Cells[1].Value;
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region CLOSE
		void FormBonosFormClosing(object sender, FormClosingEventArgs e)
		{
			this.principal.bonos = false;
		}
		#endregion
		
		#region METODOS
		void AdaptadorOperador()
		{
			int contador = 0;
			dataBonos.Rows.Clear();
			dataBonos.ClearSelection();
			
			conn.getAbrirConexion("select B.ID, O.ID as IDO, O.Alias, B.ESTATUS, B.ESTATUS2, B.ESTATUS3, B.ESTATUS4, B.CANTIDAD from OPERADOR O, BONO_OPERADOR B where O.Alias!='Admvo' and O.Estatus='1' and O.ID=B.ID_O AND O.tipo_empleado='OPERADOR' order by Alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataBonos.Rows.Add();
				dataBonos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataBonos.Rows[contador].Cells[1].Value = conn.leer["IDO"].ToString();
				dataBonos.Rows[contador].Cells[2].Value = conn.leer["Alias"].ToString();
				
				if(conn.leer["ESTATUS"].ToString()=="1")
					dataBonos.Rows[contador].Cells[3].Value = true;
				else
					dataBonos.Rows[contador].Cells[3].Value = false;
				
				if(conn.leer["ESTATUS2"].ToString()=="1")
					dataBonos.Rows[contador].Cells[4].Value = true;
				else
					dataBonos.Rows[contador].Cells[4].Value = false;
				
				if(conn.leer["ESTATUS3"].ToString()=="1")
					dataBonos.Rows[contador].Cells[5].Value = true;
				else
					dataBonos.Rows[contador].Cells[5].Value = false;
				
				if(conn.leer["ESTATUS4"].ToString()=="1")
					dataBonos.Rows[contador].Cells[6].Value = true;
				else
					dataBonos.Rows[contador].Cells[6].Value = false;
				
				dataBonos.Rows[contador].Cells[7].Value = conn.leer["CANTIDAD"].ToString();
				dataBonos.Rows[contador].Cells[8].Value = false;
				++contador;
			}
			conn.conexion.Close();
			Colores();
		}
		#endregion
		
		#region ACTUALIZAR BONO
		void ActualizarBonos()
		{
			for(int x=0; x<dataBonos.Rows.Count; x++)
			{
				conn.getAbrirConexion("select B.ESTATUS, B.ESTATUS2, B.ESTATUS3, B.ESTATUS4, B.BONIFICACION " +
				                      "from OPERADOR O, NUEVO_HISTORIAL_BONO_OPERADOR B " +
				                      "where O.Alias!='Admvo' and O.Estatus='1' and O.ID=B.ID_O " +
				                      "AND O.tipo_empleado='OPERADOR' and B.FECHA_INICIO='"+dtInicio.Value.ToString("dd-MM-yyyy")+"' " +
				                      "and B.FECHA_FIN='"+dtCorte.Value.ToString("dd-MM-yyyy")+"' and B.ID_O="+dataBonos.Rows[x].Cells[1].Value);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
				if(conn.leer["ESTATUS"].ToString()=="1")
					dataBonos.Rows[x].Cells[3].Value = true;
				else
					dataBonos.Rows[x].Cells[3].Value = false;
				
				if(conn.leer["ESTATUS2"].ToString()=="1")
					dataBonos.Rows[x].Cells[4].Value = true;
				else
					dataBonos.Rows[x].Cells[4].Value = false;
				
				if(conn.leer["ESTATUS3"].ToString()=="1")
					dataBonos.Rows[x].Cells[5].Value = true;
				else
					dataBonos.Rows[x].Cells[5].Value = false;
				
				if(conn.leer["ESTATUS4"].ToString()=="1")
					dataBonos.Rows[x].Cells[6].Value = true;
				else
					dataBonos.Rows[x].Cells[6].Value = false;
				
				if(conn.leer["BONIFICACION"].ToString()=="1")
					dataBonos.Rows[x].Cells[8].Value = true;
				else
					dataBonos.Rows[x].Cells[8].Value = false;
				}
			conn.conexion.Close();
			}
		}
		#endregion
		
		#region COLORES
		void Colores()
		{
			for(int x=0; x<dataBonos.Rows.Count; x++)
			{
				for(int y=0; y<dataBonos.ColumnCount; y++)
				{
					if(x%2==0)
						dataBonos.Rows[x].Cells[y].Style.BackColor = Color.Gainsboro;
				}
			}
		}
		#endregion
		
		#region BUSCADOR
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Buscador(txtAlias);
		}
		
		void Buscador(TextBox txtAlias)
		{
			for(int x=0; x<dataBonos.Rows.Count; x++)
				{
					if(txtAlias.Text==dataBonos.Rows[x].Cells[2].Value.ToString())
					{
						dataBonos.ClearSelection();
						dataBonos.Rows[x].Cells[2].Selected = true;
						dataBonos.FirstDisplayedCell = dataBonos.Rows[x].Cells[2];
						for(int y=0; y<dataBonos.ColumnCount;y++)
							dataBonos.Rows[x].Cells[y].Style.BackColor = Color.LightSteelBlue;
					}
				}
		}
		#endregion
		
		#region PERIODO 
		void PeriodoBonos()
		{
			conn.getAbrirConexion("select FECHAINICIO, FECHAFIN from PERIODO WHERE FECHAINICIO <= '"+dtFechaActual.Value.ToString().Substring(0,10)+"' and FECHAFIN >= '"+dtFechaActual.Value.AddDays(-2).ToString().Substring(0,10)+"'");
			conn.leer=conn.comando.ExecuteReader();
            if(conn.leer.Read())
            {
            	dtInicio.Value = (Convert.ToDateTime(conn.leer["FECHAINICIO"].ToString().Substring(0,10)));
            	dtCorte.Value = (Convert.ToDateTime(conn.leer["FECHAFIN"].ToString().Substring(0,10)));
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTO DATETIME
		void DtFechaActualValueChanged(object sender, EventArgs e)
		{
			PeriodoBonos();
		  	AdaptadorOperador();
		  	ActualizarBonos();
		}
		#endregion
		
	}
}
