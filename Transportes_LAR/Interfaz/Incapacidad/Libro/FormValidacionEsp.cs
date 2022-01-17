using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormValidacionEsp : Form
	{
		public FormValidacionEsp(LibroViajes refLib)
		{
			InitializeComponent();
			refLibro=refLib;
		}
		
		#region VARIABLES
		String consulta ="";
		int filaSelect=0;
		public List<Dato.datosViajes> listRutaSalida = null;
		#endregion
		
		#region INSTANCIAS
		public LibroViajes refLibro = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region EVENTO LOAD
		void FormValidacionEspLoad(object sender, EventArgs e)
		{
			dtpInicio.Value = DateTime.Now;
			dtpFin.Value = DateTime.Now;
			
			
			obternerConsulta();
			consulta=consulta+" and FECHA_SALIDA between '2013/02/12' and '10/12/2013' and R.PAGO='0' ";//DateTime.Now.ToString("yyyy/MM/dd")+"' and R.PAGO='0' "; //
			getDatosDatagird();
			getSalidas();
		}
		#endregion
		
		#region LLENADO DE DATAGRID (dgDatos)
		public void getDatosDatagird()
		{
			dgDatos.Rows.Clear();
			
			consulta=consulta+" ORDER BY RE.FECHA_SALIDA, C.ID ";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			
			int x=0;
			
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["estado"].ToString(),conn.leer["ID"].ToString(), "0",conn.leer["ID_RE"].ToString(),conn.leer["DESTINO"].ToString(),"$"+conn.leer["PRECIO"].ToString(), "$"+conn.leer["ANTICIPO"].ToString(), conn.leer["SALDO"].ToString(),conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), "OPERADOR", "0", "OPERADOR", "0", "OPERADOR", "000000000", "N/A", "N/A", "N/A", "N/A", "OPERADOR", conn.leer["PAGO"].ToString());
				dgDatos[23, x].Value=conn.leer["FACTURADO"].ToString();
				x++;
			}
			
			conn.conexion.Close();
			dgDatos.ClearSelection();
		}
		
		public void getSalidas()
		{
			listRutaSalida = new Conexion_Servidor.Libros.SQL_Libros().getIdsSalidas();
			
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				for(int y=0; y<listRutaSalida.Count; y++)
				{
					if(dgDatos[2,x].Value.ToString()=="0" && dgDatos[3,x].Value.ToString()==listRutaSalida[y].dato2 && dgDatos[4,x].Value.ToString()==listRutaSalida[y].dato3)
					{
						dgDatos[2,x].Value=listRutaSalida[y].dato1;
						listRutaSalida.RemoveAt(y);
					}
				}
			}
			
			datosCompleta();
		}
			
		public void obternerConsulta()
		{
			consulta="select R.ID, RE.ID_RE, RE.DESTINO, RE.PRECIO, RE.anticipo, (RE.PRECIO-RE.anticipo) as SALDO, RE.FECHA_SALIDA, RE.estado, R.PAGO, RE.FACTURADO from RUTA R, Cliente C, RUTA_ESPECIAL RE where R.IdSubEmpresa=C.ID and C.ID=RE.ID_C AND R.Sentido='ENTRADA' ";
		}	// AND RE.estado='Activo'
		
		public void datosCompleta()
		{
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				String consul = "select OP.Alias, O.id_operacion, R.PAGO FLUJO, OO.id_vehiculo, OO.vehiculo from RUTA R, Cliente C, RUTA_ESPECIAL RE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP where R.IdSubEmpresa=C.ID and C.ID=RE.ID_C and O.id_ruta=R.ID and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.estatus='1' and R.ID="+dgDatos[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[9,x].Value=conn.leer["Alias"].ToString();
					dgDatos[10,x].Value=conn.leer["id_operacion"].ToString();
					dgDatos[13,x].Value=conn.leer["Alias"].ToString();
					
					dgDatos[15,x].Value=((Convert.ToInt16(conn.leer["FLUJO"])>0)?"SI":"NO");
					dgDatos[16,x].Value=((Convert.ToInt16(conn.leer["FLUJO"])>1)?"SI":"NO");
						
				}
				
				conn.conexion.Close();
				
				consul = "select OP.Alias, O.id_operacion, R.PAGO FLUJO, OO.id_vehiculo, OO.vehiculo from RUTA R, Cliente C, RUTA_ESPECIAL RE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP where R.IdSubEmpresa=C.ID and C.ID=RE.ID_C and O.id_ruta=R.ID and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.estatus='1' and R.ID="+dgDatos[2,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[11,x].Value=conn.leer["Alias"].ToString();
					dgDatos[12,x].Value=conn.leer["id_operacion"].ToString();
					dgDatos[13,x].Value=conn.leer["Alias"].ToString();
					dgDatos[21,x].Value=conn.leer["id_vehiculo"].ToString();
					dgDatos[22,x].Value=conn.leer["vehiculo"].ToString();
					
					dgDatos[17,x].Value=((Convert.ToInt16(conn.leer["FLUJO"])>0)?"SI":"NO");
					dgDatos[18,x].Value=((Convert.ToInt16(conn.leer["FLUJO"])>1)?"SI":"NO");
					
				}
				
				conn.conexion.Close();
				
				// **********************
				
				consul = "select T.Numero from TELEFONOCHOFER T, OPERADOR O where T.Tipo='LAR' and T.ID_Chofer=O.ID AND O.Alias='"+dgDatos[11,x].Value.ToString()+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[14,x].Value=conn.leer["Numero"].ToString();
				}
				
				conn.conexion.Close();
				
				
				consul = "select TIPO from RUTA where ID="+dgDatos[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="Cancelada")
					{
						dgDatos[9,x].Style.BackColor=Color.Yellow;
						dgDatos[9,x].Value="CANCELADA";
					}
				}
				
				conn.conexion.Close();
				
				
				consul = "select TIPO from RUTA where ID="+dgDatos[2,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="Cancelada")
					{
						dgDatos[11,x].Style.BackColor=Color.Yellow;
						dgDatos[11,x].Value="CANCELADA";
					}
				}
				
				conn.conexion.Close();
				
				
				consul = "select O.Alias from CANCELACION_PUNTO C, OPERADOR O WHERE C.ID_OPERADOR=O.ID and ID_RUTA="+dgDatos[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[0,x].Value="C. PUNTO";
					if(dgDatos[10,x].Value.ToString()=="0")
					{
						dgDatos[9,x].Value=conn.leer["Alias"].ToString();
						dgDatos[13,x].Value=conn.leer["Alias"].ToString();
						dgDatos[21,x].Value="109";
						dgDatos[22,x].Value="N/A";
					}
					else
					{
						dgDatos[9,x].Value="'Error' "+dgDatos[9,x].Value.ToString();
						dgDatos[9,x].Style.ForeColor=Color.White;
						//dgDatos[21,x].Value="109";
						//dgDatos[22,x].Value="N/A";
					}
					
					if(dgDatos[12,x].Value.ToString()=="0")
					{
						dgDatos[11,x].Value=conn.leer["Alias"].ToString();
						dgDatos[13,x].Value=conn.leer["Alias"].ToString();
						dgDatos[21,x].Value="109";
						dgDatos[22,x].Value="N/A";
						
					}
					else
					{
						dgDatos[11,x].Value="'Error' "+dgDatos[11,x].Value.ToString();
						dgDatos[11,x].Style.ForeColor=Color.White;
						//dgDatos[21,x].Value="109";
						//dgDatos[22,x].Value="N/A";
					}
				}
				
				conn.conexion.Close();
				
				
				if(dgDatos[9,x].Value.ToString()=="CANCELADA" && dgDatos[11,x].Value.ToString()=="CANCELADA")
				{
					dgDatos[0,x].Value="CANCELADA";
					for(int y=0; y<dgDatos.Columns.Count; y++)
					{
						dgDatos[y,x].Style.BackColor=Color.Yellow;
					}
				}
				else if(dgDatos[0,x].Value.ToString()=="Cancelado")
				{
					dgDatos[0,x].Value="SIN CONF.";
					for(int y=0; y<dgDatos.Columns.Count; y++)
					{
						dgDatos[y,x].Style.BackColor=Color.Yellow;
					}
				}
				else if(dgDatos[0,x].Value.ToString()=="C. PUNTO")
				{
					for(int y=0; y<dgDatos.Columns.Count; y++)
					{
						if(y==9 && dgDatos[10,x].Value.ToString()!="0")
						{
							dgDatos[y,x].Style.BackColor=Color.Black;
						}
						else if(y==11 && dgDatos[12,x].Value.ToString()!="0")
						{
							dgDatos[y,x].Style.BackColor=Color.Black;
						}
						else
						{
							dgDatos[y,x].Style.BackColor=Color.Red;
						}
					}
				}
				
				validados(x);
			}
			//getTelefonos();
			//getCancelados();
		}
		
		public void getTelefonos()
		{
			/*for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				String consul = "select T.Numero from TELEFONOCHOFER T, OPERADOR O where T.Descripcion='LAR' and T.ID_Chofer=O.ID AND O.Alias='"+dgDatos[11,x].Value.ToString()+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[14,x].Value=conn.leer["Numero"].ToString();
				}
				
				conn.conexion.Close();
			}*/
		}
				
		public void getCancelados()
		{
			/*for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				String consul = "select TIPO from RUTA where ID="+dgDatos[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="Cancelada")
					{
						dgDatos[9,x].Style.BackColor=Color.Yellow;
						dgDatos[9,x].Value="CANCELADA";
					}
				}
				
				conn.conexion.Close();
				
				
				consul = "select TIPO from RUTA where ID="+dgDatos[2,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="Cancelada")
					{
						dgDatos[11,x].Style.BackColor=Color.Yellow;
						dgDatos[11,x].Value="CANCELADA";
					}
				}
				
				conn.conexion.Close();
				
				
				consul = "select O.Alias from CANCELACION_PUNTO C, OPERADOR O WHERE C.ID_OPERADOR=O.ID and ID_RUTA="+dgDatos[1,x].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[0,x].Value="C. PUNTO";
					if(dgDatos[10,x].Value.ToString()=="0")
					{
						dgDatos[9,x].Value=conn.leer["Alias"].ToString();
						dgDatos[13,x].Value=conn.leer["Alias"].ToString();
					}
					else
					{
						dgDatos[9,x].Value="'Error' "+dgDatos[9,x].Value.ToString();
						dgDatos[9,x].Style.ForeColor=Color.White;
					}
					
					if(dgDatos[12,x].Value.ToString()=="0")
					{
						dgDatos[11,x].Value=conn.leer["Alias"].ToString();
						dgDatos[13,x].Value=conn.leer["Alias"].ToString();
					}
					else
					{
						dgDatos[11,x].Value="'Error' "+dgDatos[9,x].Value.ToString();
						dgDatos[11,x].Style.ForeColor=Color.White;
					}
				}
				
				conn.conexion.Close();
				
				
				if(dgDatos[9,x].Value.ToString()=="CANCELADA" && dgDatos[11,x].Value.ToString()=="CANCELADA")
				{
					dgDatos[0,x].Value="CANCELADA";
					for(int y=0; y<dgDatos.Columns.Count; y++)
					{
						dgDatos[y,x].Style.BackColor=Color.Yellow;
					}
				}
				else if(dgDatos[0,x].Value.ToString()=="Cancelado")
				{
					dgDatos[0,x].Value="SIN CONF.";
					for(int y=0; y<dgDatos.Columns.Count; y++)
					{
						dgDatos[y,x].Style.BackColor=Color.Yellow;
					}
				}
				else if(dgDatos[0,x].Value.ToString()=="C. PUNTO")
				{
					for(int y=0; y<dgDatos.Columns.Count; y++)
					{
						if(y==9 && dgDatos[10,x].Value.ToString()!="0")
						{
							dgDatos[y,x].Style.BackColor=Color.Black;
						}
						else if(y==11 && dgDatos[12,x].Value.ToString()!="0")
						{
							dgDatos[y,x].Style.BackColor=Color.Black;
						}
						else
						{
							dgDatos[y,x].Style.BackColor=Color.Red;
						}
					}
				}
				
				validados(x);
			}*/
		}
		#endregion
		
		#region EVENTO DOBLE CLICK PARA MOSTRAR DATOS
		void DgDatosDoubleClick(object sender, EventArgs e)
		{
			if(dgDatos.CurrentRow.Index>-1)
			{
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgDatos[3,dgDatos.CurrentRow.Index].Value));
				formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();
			}
		}
		#endregion
		
		#region AUTOCOMPLETE DEL DATAGRID
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			filaSelect=e.RowIndex;
		}
		
		void DgDatosEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if(dgDatos.CurrentCell.ColumnIndex==13)
			{
				if(dgDatos.CurrentCell.ColumnIndex==13)// && dtgEmpresas[6,dtgEmpresas.CurrentRow.Index].Style.BackColor.Name.ToString()!="MediumSpringGreen")
				{
					//dtgEmpresas[3,filaSelect].Style.BackColor=Color.White;
					if (e.Control is DataGridViewTextBoxEditingControl)
		            {
						((TextBox)e.Control).AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias Dato from OPERADOR where (ID in (select ID from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR)) OR tipo_empleado='Externo'");
		                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;
		                
		                //((TextBox)e.Control).KeyUp += DtgEmpresasKeyUp;
		                //autoComp=1;
		            }
				}
				else
				{
					if(dgDatos.CurrentCell.ColumnIndex==13)
						dgDatos[13,dgDatos.CurrentRow.Index].ReadOnly=true;
					
					if (e.Control is DataGridViewTextBoxEditingControl )
						((TextBox)e.Control).AutoCompleteCustomSource = null;
				}
			}
			else
			{
				if (e.Control is DataGridViewTextBoxEditingControl )
					((TextBox)e.Control).AutoCompleteCustomSource = null;
			}
			
			if(dgDatos.CurrentCell.ColumnIndex==13)
				dgDatos[13,dgDatos.CurrentRow.Index].ReadOnly=false;
		}
		
		void DgDatosKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Return && filaSelect!=-1)
			{
				if(dgDatos.CurrentCell.ColumnIndex==13)
				{
					String consul = "SELECT ID FROM OPERADOR WHERE Alias= '"+dgDatos[13,filaSelect].Value.ToString()+"'";
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgDatos[19,filaSelect].Value=conn.leer["ID"].ToString();
					}
					else
					{
						dgDatos[13,filaSelect].Value=dgDatos[11,filaSelect].Value.ToString();
					}
					
					conn.conexion.Close();
					
					filaSelect=0;
				}
			}
		}
		#endregion
		
		#region CLICK IZQUIERDO
		void DgDatosCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				if(e.RowIndex!=-1)
				{
					
				}
			}
		}
		#endregion
		
		#region VALIDACION
		void CmdValidaClick(object sender, EventArgs e)
		{
			bool continua = true;
			bool error = false;
			bool entra = true;
			bool faltante = false;
			
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				if(dgDatos.Rows[x].Selected==true)
				{
					if(dgDatos[15,x].Value.ToString()=="SI")
					{
						continua=false;
					}
					
					if(dgDatos[9,x].Style.BackColor.Name.ToString()=="Black" || dgDatos[11,x].Style.BackColor.Name.ToString()=="Black")
					{
						error=true;
					}
					
					if(dgDatos[13,x].Value.ToString()=="OPERADOR" && dgDatos[13,x].Style.BackColor.Name.ToString()!="Yellow")
					{
						faltante=true;
					}
				}
			}
			
			if(continua==true)
			{
				for(int x=0; x<dgDatos.Rows.Count; x++)
				{
					if(dgDatos.Rows[x].Selected==true)
					{
						if(dgDatos[0,x].Value.ToString()=="CANCELADA" || dgDatos[0,x].Value.ToString()=="SIN CONF.")
						{
							validaCancelados(dgDatos[1,x].Value.ToString(), dgDatos[2,x].Value.ToString());
						}
						
						if(dgDatos[0,x].Value.ToString()=="Activo" || dgDatos[0,x].Value.ToString()=="C. PUNTO")
						{
							entra=false;
						}
					}
				}
				
				if(faltante==true)
				{
					MessageBox.Show("Es necesario ingresar operador en cobro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if(error==true)
				{
					DialogResult rs2 = MessageBox.Show("Existe un error de asignacion. \n ¿Desea continuar?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
					if (DialogResult.OK==rs2)
					{
						valida();
					}
				}
				else
				{
					if(entra==true)
					{
						List<int> rowsSelect = new List<int>();
						for(int x=0; x<dgDatos.Rows.Count; x++)
						{
							if(dgDatos.Rows[x].Selected==true)
							{
								dgDatos[15,x].Value="SI";
								dgDatos[15,x].Style.BackColor=Color.SpringGreen;
								dgDatos[17,x].Value="SI";
								dgDatos[17,x].Style.BackColor=Color.SpringGreen;
								rowsSelect.Add(x);
							}
						}
						
						for(int x=rowsSelect.Count-1; x>-1; x--)
						{
							if(cbValidados.Checked==false)
							{
								dgDatos.Rows.RemoveAt(rowsSelect[x]);
							}
						}
							
						Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron guardados correctamente");
						mensaje.Show();
						dgDatos.ClearSelection();
					}
					else
					{
						valida();
					}
				}
			}
			else
			{
				MessageBox.Show("Selecciono un registro ya validado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		public void valida()
		{
			if(rbDefault.Checked==true)
			{
				List<int> rowsSelect = new List<int>();
				
				if(dgDatos.SelectedRows.Count>0)
				{
					for(int x=0; x<dgDatos.Rows.Count; x++)
					{
						if(dgDatos.Rows[x].Selected==true && (dgDatos[0,x].Value.ToString()!="CANCELADA" && dgDatos[0,x].Value.ToString()!="SIN CONF.") && dgDatos[13,x].Value.ToString()!="OPERADOR")
						{
							guardaValidacion(dgDatos[3,x].Value.ToString(),dgDatos[1,x].Value.ToString(), dgDatos[2,x].Value.ToString(), "OPERADOR", dgDatos[13,x].Value.ToString(), " ", dgDatos[14,x].Value.ToString(), dgDatos[0,x].Value.ToString(), dgDatos[21,x].Value.ToString(), dgDatos[7,x].Value.ToString());
							dgDatos[15,x].Value="SI";
							dgDatos[15,x].Style.BackColor=Color.SpringGreen;
							dgDatos[17,x].Value="SI";
							dgDatos[17,x].Style.BackColor=Color.SpringGreen;
							rowsSelect.Add(x);
						}
						
						/*if(dgDatos.Rows[x].Selected==true && (dgDatos[0,x].Value.ToString()!="CANCELADA" && dgDatos[0,x].Value.ToString()!="SIN CONF."))
						{
							dgDatos[15,x].Value="SI";
							dgDatos[15,x].Style.BackColor=Color.SpringGreen;
							dgDatos[17,x].Value="SI";
							dgDatos[17,x].Style.BackColor=Color.SpringGreen;
						}*/
					}
					
					/*for(int x=dgDatos.Rows.Count-1; x>-1; x--)
					{
						if(dgDatos.Rows[x].Selected==true)
						{
							if(cbValidados.Checked==false)
							{
								dgDatos.Rows.RemoveAt(x);
							}
						}
					}*/
					
					for(int x=rowsSelect.Count-1; x>-1; x--)
					{
						if(cbValidados.Checked==false)
						{
							dgDatos.Rows.RemoveAt(rowsSelect[x]);
						}
					}
						
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron guardados correctamente");
					mensaje.Show();
					dgDatos.ClearSelection();
				}
				else
				{
					MessageBox.Show("Seleccione un registro de la tabla.");
				}
			}
			else if(rbDefault.Checked==false)
			{
				if(dgDatos.SelectedRows.Count>1)
				{
					new FormAsignacionCobro(this,1).ShowDialog();
				}
				else if(dgDatos.SelectedRows.Count==1)
				{
					new FormAsignacionCobro(this,2).ShowDialog();
				}
				else
				{
					MessageBox.Show("Seleccione un registro de la tabla.");
				}
			}
		}
		
		public void setValidacion(String tipo, String cobro, String observaciones, String telefono)
		{
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				if(dgDatos.Rows[x].Selected==true)
				{
					if(dgDatos.Rows[x].Selected==true && (dgDatos[0,x].Value.ToString()!="CANCELADA" && dgDatos[0,x].Value.ToString()!="SIN CONF."))
					{
						//dgDatos[13,x].Style.BackColor=Color.MediumBlue;
						dgDatos[13, x].Value=cobro;
						dgDatos[19, x].Value=tipo;
						dgDatos[15,x].Value="SI";
						dgDatos[15,x].Style.BackColor=Color.SpringGreen;
						dgDatos[17,x].Value="SI";
						dgDatos[17,x].Style.BackColor=Color.SpringGreen;
						guardaValidacion(dgDatos[3,x].Value.ToString(),dgDatos[1,x].Value.ToString(),dgDatos[2,x].Value.ToString(), tipo, cobro, observaciones, telefono, dgDatos[0,x].Value.ToString(), dgDatos[21,x].Value.ToString(), dgDatos[7,x].Value.ToString());
					}
				}
			}
			
			for(int x=dgDatos.Rows.Count-1; x>-1; x--)
			{
				if(dgDatos.Rows[x].Selected==true)
				{
					if(cbValidados.Checked==false)
					{
						dgDatos.Rows.RemoveAt(x);
					}
				}
			}
			dgDatos.ClearSelection();
		}
		
		public void guardaValidacion(String ID_RE, String id_r1, String id_r2, String tipo, String cobro, String observaciones, String telefono, String Tipo_V, String id_vehiculo, String saldo)
		{
			Int64 IDENT = 0;
			
			String miconsult = "select MAX(NUMERO)+1 num from COBRO_ESPECIAL";
			conn.getAbrirConexion(miconsult);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				try
				{
					IDENT=Convert.ToInt64(conn.leer["num"]);
				}
				catch(Exception)
				{
					IDENT=1;
				}
			}
				
			conn.conexion.Close();
			
			miconsult="insert into COBRO_ESPECIAL values ('"+ID_RE+"','"+id_r1+"', '"+id_r2+"', '"+tipo+"', '"+cobro+"', '"+observaciones+"', "+IDENT+", '"+telefono+"', '1', (SELECT CONVERT (date, SYSDATETIME())), "+refLibro.principal.idUsuario+", '"+IDENT+"-"+DateTime.Now.ToString("yyMM")+"', '0', '0', '0', '0', '"+Tipo_V+"', '"+id_vehiculo+"', '"+saldo+"', '')";	//
			conn.getAbrirConexion(miconsult);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			conn.getAbrirConexion("update RUTA set PAGO='1' where ID="+id_r1);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			conn.getAbrirConexion("update RUTA set PAGO='1' where ID="+id_r2);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		
		public void validaCancelados(String id_r1, String id_r2)
		{
			conn.getAbrirConexion("update RUTA set PAGO='1' where ID="+id_r1);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			conn.getAbrirConexion("update RUTA set PAGO='1' where ID="+id_r2);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region MUESTRA VALIDADOS
		void CbValidadosCheckedChanged(object sender, EventArgs e)
		{
			if(cbValidados.Checked==true)
			{
				dtpInicio.Enabled=true;
				dtpFin.Enabled=true;
				dgDatos.Rows.Clear();
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Seleccione rango de fechas");
				mensaje.Show();
				dtpInicio.Show();
			}
			else if(cbValidados.Checked==false)
			{
				dtpInicio.Enabled=false;
				dtpFin.Enabled=false;
				obternerConsulta();
				consulta=consulta+" and FECHA_SALIDA between '2013/02/12' and '"+DateTime.Now.ToString("yyyy/MM/dd")+"' and R.PAGO='0' ";
				getDatosDatagird();
				getSalidas();
			}
		}
		
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			if(cbValidados.Checked==true)
			{
				obternerConsulta();
				consulta=consulta+" and FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy/MM/dd")+"' and '"+dtpFin.Value.ToString("yyyy/MM/dd")+"' and (R.PAGO='0' OR R.PAGO='1') ";
				getDatosDatagird();
				getSalidas();
			}
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			if(cbValidados.Checked==true)
			{
				obternerConsulta();
				consulta=consulta+" and FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy/MM/dd")+"' and '"+dtpFin.Value.ToString("yyyy/MM/dd")+"' and (R.PAGO='0' OR R.PAGO='1') ";
				getDatosDatagird();
				getSalidas();
			}
		}
		
		public void validados(int x)
		{
			if(dgDatos[15,x].Value.ToString()=="SI")
				dgDatos[15,x].Style.BackColor=Color.SpringGreen;
			if(dgDatos[16,x].Value.ToString()=="SI")
				dgDatos[16,x].Style.BackColor=Color.SpringGreen;
			
			if(dgDatos[17,x].Value.ToString()=="SI")
				dgDatos[17,x].Style.BackColor=Color.SpringGreen;
			if(dgDatos[18,x].Value.ToString()=="SI")
				dgDatos[18,x].Style.BackColor=Color.SpringGreen;
		}
		#endregion
		
		#region CAMBIOS
		void CmdCambiosClick(object sender, EventArgs e)
		{
			if(dgDatos.SelectedRows.Count>0)
			{
				if(dgDatos.SelectedRows.Count==1 && (dgDatos[9,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString()!="Black" && dgDatos[11,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString()!="Black"))
				{
					new FormCambiosAsiganacion(this, 0).ShowDialog();
				}
				else if(dgDatos[9,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString()=="Black" || dgDatos[11,dgDatos.CurrentRow.Index].Style.BackColor.Name.ToString()=="Black")
				{
					DialogResult rs2 = MessageBox.Show("Es necesario eliminar la asignacion.", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
					if (DialogResult.OK==rs2)
					{
						new FormCambiosAsiganacion(this, 1).ShowDialog();
					}
				}
				else
				{
					MessageBox.Show("Seleccionar solo un registro.");
				}
			}
			else 
			{
				MessageBox.Show("Seleccione un regritro de la tabla.");
			}
		}
		#endregion
		
		#region FACTURACION
		void CmdFacturaClick(object sender, EventArgs e)
		{
			bool continua = true;
			
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				if(dgDatos.Rows[x].Selected==true)
				{
					if(dgDatos[16,x].Value.ToString()=="SI")
					{
						continua=false;
					}
				}
			}
			
			if(continua==true)
			{
				List<int> rowsSelect = new List<int>();
				
				for(int x=0; x<dgDatos.Rows.Count; x++)
				{
					if(dgDatos.Rows[x].Selected==true)
					{
						dgDatos[16,x].Style.BackColor=Color.SpringGreen;
						dgDatos[16,x].Value="SI";
						dgDatos[18,x].Style.BackColor=Color.SpringGreen;
						dgDatos[18,x].Value="SI";
						guardaFacturados(dgDatos[1,x].Value.ToString(), dgDatos[2,x].Value.ToString());
						rowsSelect.Add(x);
						
						rowsSelect.Add(x);
					}
				}
				
				/*for(int x=0; x<rowsSelect.Count; x++)
				{
					if(cbFacturados.Checked==false)
					{
						dgDatos.Rows.RemoveAt(rowsSelect[x]);
					}
				}*/
			}
			else
			{
				MessageBox.Show("Selecciono un registro ya facturado.");
			}
		}
		
		public void guardaFacturados(String id_r1, String id_r2)
		{
			conn.getAbrirConexion("update RUTA set FACTURA='1' where ID="+id_r1);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			conn.getAbrirConexion("update RUTA set FACTURA='1' where ID="+id_r2);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		void CmdAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
