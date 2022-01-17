using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel; 
using Transportes_LAR.Interfaz.Operaciones.Dato;

namespace Transportes_LAR.Interfaz.Caja
{
	public partial class FormPrincipalCaja : Form
	{
		public FormPrincipalCaja(FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		
		#region VARIABLES
		Int64 ID_RESPONSABLE = 0;
		#endregion
		
		#region INSTANCIAS
		FormPrincipal refPrincipal;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormPrincipalCajaLoad(object sender, EventArgs e)
		{
			getCargarValidacionCampos(this);
			
			txtAutoriza.AutoCompleteCustomSource = auto.AutoReconocimiento("select AUTORIZA dato from CAJA");
			txtAutoriza.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtAutoriza.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtResponsable.AutoCompleteCustomSource = auto.AutoReconocimiento("select ALIAS dato from RESPONSABLE");
			txtResponsable.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtConcepto.AutoCompleteCustomSource = auto.AutoReconocimiento("select CONCEPTO dato from CAJA");
			txtConcepto.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtConcepto.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			getDatosDG();
		}
		#endregion
		
		#region VALIDACION DE CAMPOS
		private void getCargarValidacionCampos(FormPrincipalCaja formRef)
		{		
			formRef.txtCantidad.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formRef.txtAutoriza.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		#endregion
				
		#region MUESTRA FORMULARIO DE RESPONSABLE
		void ToolStripLabel1Click(object sender, EventArgs e)
		{
			new FormResponsable().ShowDialog();
			getCargarValidacionCampos(this);
			txtResponsable.AutoCompleteCustomSource = auto.AutoReconocimiento("select ALIAS dato from RESPONSABLE");
			txtResponsable.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtResponsable.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region GUARDAR DATOS
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(Convert.ToDouble(txtCantidad.Text)<1)
			{
				MessageBox.Show("Error en la cantidad a registrar.");
				txtCantidad.Focus();
			}
			else if(txtResponsable.BackColor.Name!="MediumSpringGreen")
			{
				MessageBox.Show("Responsable no registrado");
				txtResponsable.Focus();
			}
			else if((txtConcepto.Text=="" || txtConcepto.Text==" ") && rbCierre.Checked==true)
			{
				MessageBox.Show("Ingrese concepto");
				txtConcepto.Focus();
			}
			else if((txtAutoriza.Text=="" || txtAutoriza.Text==" ") && rbCierre.Checked==false)
			{
				MessageBox.Show("Ingrese nombre de quien autoriza");
				txtAutoriza.Focus();
			}
			else if((txtObservacion.Text=="" || txtObservacion.Text==" ") && rbCierre.Checked==false)
			{
				MessageBox.Show("Ingrese comentario u observación");
				txtObservacion.Focus();
			}
			else
			{
				guardarDatos();
			}
		}
		
		void guardarDatos()
		{
			if(validaCierre()==true)
			{
				String consulta = "insert into CAJA values ("+ID_RESPONSABLE+", '"+txtCantidad.Text+"', '"+txtConcepto.Text+"', '"+txtAutoriza.Text+"', '"+txtObservacion.Text+"', '"+((rbEntrada.Checked==true)?"ENTRADA":((rbSalida.Checked==true)?"SALIDA":"CIERRE"))+"', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())));";
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			
				limpiaDatos();
			}
			else
			{
				MessageBox.Show("Ya se realizó el cierre del día: "+dtpFecha.Value.ToString("dd/MM/yyyy"));
			}
		}
		
		bool validaCierre()
		{
			bool respuesta = true;
			
			String consulta = "select * from caja where FECHA='"+dtpFecha.Value.ToString("dd/MM/yyyy")+"' and TIPO='CIERRE' and FLUJO='1'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				respuesta=false;
			}
			conn.conexion.Close();
			
			return respuesta;
		}
		#endregion
		
		#region LIMPIA DATOS
		void limpiaDatos()
		{
			txtCantidad.Text="0";
			txtResponsable.Text="";
			ID_RESPONSABLE=0;
			txtConcepto.Text="";
			txtAutoriza.Text="";
			txtObservacion.Text="";
			txtCantidad.Focus();
			txtCantidad.SelectAll();
			txtResponsable.BackColor=Color.White;
			
			getDatosDG();
		}
		#endregion
		
		#region GET DATOS DATAGRID
		void getDatosDG()
		{
			dgDatos.Rows.Clear();
			
			String consulta = "";
			
			if(dtpInicio.Value.ToString("dd/MM/yyyy")==dtpFin.Value.ToString("dd/MM/yyyy"))
			{
				consulta = "select top 1 * from caja where FECHA<='"+dtpInicio.Value.AddDays(-1).ToString("dd/MM/yyyy")+"' and TIPO='CIERRE' and FLUJO='1' order by FECHA desc";
			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtInicio.Text=conn.leer["CANTIDAD"].ToString();
					txtInicio.BackColor=Color.MediumSpringGreen;
					lblDato.Text="Cierre del día "+conn.leer["FECHA"].ToString().Substring(0,10);
				}
				else
				{
					txtInicio.Text="0";
					txtInicio.BackColor=Color.White;
					lblDato.Text="Sin registros de cierre";
				}
				
				conn.conexion.Close();
			}
			else
			{
				txtInicio.Text="0";
			}
			
			consulta = "select C.ID, C.FECHA, R.ALIAS, C.CANTIDAD, C.CONCEPTO, C.AUTORIZA, C.OBSERVACIONES, C.TIPO, C.FLUJO  from CAJA C, RESPONSABLE R WHERE R.ID=C.ID_R and C.FECHA between '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' and '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' and C.FLUJO!='0' and C.CONCEPTO like '%"+txtBusConc.Text+"%' and C.AUTORIZA like '%"+txtBusAut.Text+"%'and R.ALIAS like '%"+txtBusResp.Text+"%'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["ALIAS"].ToString(), conn.leer["CANTIDAD"].ToString(), conn.leer["CONCEPTO"].ToString(), conn.leer["AUTORIZA"].ToString(), conn.leer["OBSERVACIONES"].ToString(), conn.leer["TIPO"].ToString() , conn.leer["FLUJO"].ToString());
			}
			
			conn.conexion.Close();
			
			Double entrada = 0;
			Double salida = 0;
			Double total = 0;
			
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				if(dgDatos[7,x].Value.ToString()=="ENTRADA")
				{
					entrada=entrada+Convert.ToDouble(dgDatos[3,x].Value);
				}
				
				if(dgDatos[7,x].Value.ToString()=="SALIDA")
				{
					salida=salida+Convert.ToDouble(dgDatos[3,x].Value);
				}
				
				if(dgDatos[7,x].Value.ToString()!="CIERRE")
				{
					total=total+Convert.ToDouble(dgDatos[3,x].Value);
				}
			}
			
			txtTotal.Text=total.ToString();
			txtEntrada.Text=entrada.ToString();
			txtSalida.Text=salida.ToString();
			
			if(txtInicio.Text!="0")
			{
				txtDisponible.Text=(Convert.ToDouble(txtInicio.Text)+(Convert.ToDouble(txtEntrada.Text)-Convert.ToDouble(txtSalida.Text))).ToString();
			}
			else
			{
				txtDisponible.Text="0";
			}
			
			dgDatos.ClearSelection();
			coloresTipo();
			
			dtpFecha.Value=dtpInicio.Value;
		}
		
		void coloresTipo()
		{
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				if(dgDatos[7,x].Value.ToString()=="ENTRADA")
				{
					dgDatos[7,x].Style.BackColor=Color.MediumSpringGreen;
				}
				else if(dgDatos[7,x].Value.ToString()=="SALIDA")
				{
					dgDatos[7,x].Style.BackColor=Color.Red;
				}
				else
				{
					dgDatos[7,x].Style.BackColor=Color.MediumSlateBlue;
				}
			}
		}
		#endregion
		
		#region SELECCION DE RESPONSABLE
		void TxtResponsableKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta = "SELECT * FROM RESPONSABLE WHERE ALIAS='"+txtResponsable.Text+"'";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_RESPONSABLE = Convert.ToInt64(conn.leer["ID"]);
					txtResponsable.BackColor = Color.MediumSpringGreen;
				}
				else
				{
					ID_RESPONSABLE = 0;
					txtResponsable.BackColor = Color.White;
				}
				conn.conexion.Close();
				
				txtConcepto.Focus();
			}
		}
		
		void TxtResponsableLeave(object sender, EventArgs e)
		{
			String consulta = "SELECT * FROM RESPONSABLE WHERE ALIAS='"+txtResponsable.Text+"'";
				
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_RESPONSABLE = Convert.ToInt64(conn.leer["ID"]);
				txtResponsable.BackColor = Color.MediumSpringGreen;
			}
			else
			{
				ID_RESPONSABLE = 0;
				txtResponsable.BackColor = Color.White;
			}
			conn.conexion.Close();
			
			txtConcepto.Focus();
		}
		#endregion
		
		#region EVENTO ENTER
		void TxtCantidadEnter(object sender, EventArgs e)
		{
			txtCantidad.SelectAll();
		}
		
		void TxtResponsableEnter(object sender, EventArgs e)
		{
			txtResponsable.SelectAll();
		}
		
		void TxtConceptoEnter(object sender, EventArgs e)
		{
			txtConcepto.SelectAll();
		}
		
		void TxtAutorizaEnter(object sender, EventArgs e)
		{
			txtAutoriza.SelectAll();
		}
		
		void TxtObservacionEnter(object sender, EventArgs e)
		{
			txtObservacion.SelectAll();
		}
		#endregion
		
		#region VALIDANDO CERO		
		void TxtCantidadLeave(object sender, EventArgs e)
		{
			if(txtCantidad.Text=="")
			{
				txtCantidad.Text="0";
			}
		}
		#endregion
		
		#region BUSQUEDA
		void DtpFechaValueChanged(object sender, EventArgs e)
		{
			dtpInicio.Value=dtpFecha.Value;
		}
		
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			dtpFin.Value=dtpInicio.Value;
			
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			getDatosDG();
		}
		
		void TxtBusRespKeyUp(object sender, KeyEventArgs e)
		{
			getDatosDG();
		}
		
		void TxtBusConcKeyUp(object sender, KeyEventArgs e)
		{
			getDatosDG();
		}
		
		void TxtBusAutKeyUp(object sender, KeyEventArgs e)
		{
			getDatosDG();
		}
		#endregion
		
		#region EXPORTAR A EXCEL
		void CmdExcelClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			
			ExcelApp.Cells[i,1] = "ID";
			ExcelApp.Cells[i,2] = "FECHA";
			ExcelApp.Cells[i,3] = "RESPONSABLE";
			ExcelApp.Cells[i,4] = "ENTRADA";
			ExcelApp.Cells[i,5] = "SALIDA";
			ExcelApp.Cells[i,6] = "CONCEPTO";
			ExcelApp.Cells[i,7] = "AUTORIZA";
			ExcelApp.Cells[i,8] = "OBSERVACIONES";
			ExcelApp.Cells[i,9] = "TIPO";
			
			
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				
				++i;
				/*for(int y=0; y<dgDatos.ColumnCount-1; y++)
				{*/
					/*if(dgDatos.Rows[x].Cells[y].Value!=null)
					{*/
						if(dgDatos[7,x].Value.ToString()=="ENTRADA")
						{
							ExcelApp.Cells[i,  4] = dgDatos[3,x].Value.ToString();
						}
						else if(dgDatos[7,x].Value.ToString()=="SALIDA")
						{
							ExcelApp.Cells[i,  5] = dgDatos[3,x].Value.ToString();
						}
						else
						{
							ExcelApp.Cells[i,  4] = dgDatos[3,x].Value.ToString();
						}
						
						ExcelApp.Cells[i, 1] = dgDatos[0,x].Value.ToString();
						ExcelApp.Cells[i, 2] = dgDatos[1,x].Value.ToString();
						ExcelApp.Cells[i, 3] = dgDatos[2,x].Value.ToString();
						ExcelApp.Cells[i, 6] = dgDatos[4,x].Value.ToString();
						ExcelApp.Cells[i, 7] = dgDatos[5,x].Value.ToString();
						ExcelApp.Cells[i, 8] = dgDatos[6,x].Value.ToString();
						ExcelApp.Cells[i, 9] = dgDatos[7,x].Value.ToString();
					//}
				//}
			}
			
			
			ExcelApp.Cells[dgDatos.Rows.Count+3, 4] = "ENTRADA";
			ExcelApp.Cells[dgDatos.Rows.Count+3, 5] = "SALIDA";
			ExcelApp.Cells[dgDatos.Rows.Count+3, 6] = "TOTAL";
			ExcelApp.Cells[dgDatos.Rows.Count+3, 7] = "DISPONIBLE";
			
			
			ExcelApp.Cells[dgDatos.Rows.Count+4, 4] = txtEntrada.Text;
			ExcelApp.Cells[dgDatos.Rows.Count+4, 5] = txtSalida.Text;
			ExcelApp.Cells[dgDatos.Rows.Count+4, 6] = txtTotal.Text;
			ExcelApp.Cells[dgDatos.Rows.Count+4, 7] = txtDisponible.Text;
								
			// ---------- cuadro de dialogo para Guardar
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "CAJA";
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
		#endregion
		
		#region CIERRE
		void RbCierreCheckedChanged(object sender, EventArgs e)
		{
			if(modifica==false)
			{
				if(rbCierre.Checked==true)
				{
					txtCantidad.Text=txtDisponible.Text;
					txtResponsable.Text=refPrincipal.lblDatoUsuario.Text;
					txtConcepto.Text="CAJA";
					
					txtAutoriza.Text="";
					txtAutoriza.Enabled=false;
					txtObservacion.Text="";
					txtObservacion.Enabled=false;
				}
				else
				{
					txtCantidad.Text="0";
					txtResponsable.Text="";
					txtConcepto.Text="";
					txtAutoriza.Text="";
					txtObservacion.Text="";
					txtAutoriza.Enabled=true;
					txtObservacion.Enabled=true;
				}
			}
		}
		#endregion
		
		bool modifica = false;
		
		#region MODIFICACION DE DATOS
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgDatos.SelectedRows.Count>0 && e.RowIndex!=-1)
			{
				modifica=true;
				
				dtpFecha.Value=Convert.ToDateTime(dgDatos[1,e.RowIndex].Value);
				txtCantidad.Text	= dgDatos[3,e.RowIndex].Value.ToString();
				txtResponsable.Focus();
				txtResponsable.Text	= dgDatos[2,e.RowIndex].Value.ToString();
				txtConcepto.Focus();
				txtConcepto.Text	= dgDatos[4,e.RowIndex].Value.ToString();
				
				int x = e.RowIndex;
				
				if(dgDatos[7,e.RowIndex].Value.ToString()!="CIERRE")
				{
					txtAutoriza.Enabled=true;
					txtObservacion.Enabled=true;
					txtAutoriza.Text	= dgDatos[5,e.RowIndex].Value.ToString();
					txtObservacion.Text	= dgDatos[6,e.RowIndex].Value.ToString();
				}
				else
				{
					txtAutoriza.Text="";
					txtAutoriza.Enabled=false;
					txtObservacion.Text="";
					txtObservacion.Enabled=false;
				}
				
				rbEntrada.Checked=((dgDatos[7,e.RowIndex].Value.ToString()=="ENTRADA")?true:false);
				rbSalida.Checked=((dgDatos[7,e.RowIndex].Value.ToString()=="SALIDA")?true:false);
				rbCierre.Checked=((dgDatos[7,e.RowIndex].Value.ToString()=="CIERRE")?true:false);
				
				cmdElimina.Enabled=true;
				cmdModifica.Enabled=true;
				cmdNuevo.Enabled=true;
				cmdGuardar.Enabled=false;
				
				dgDatos.Rows[x].Selected = true;
				dgDatos.FirstDisplayedCell = dgDatos.Rows[x].Cells[1];
			}
		}
		#endregion
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			nuevoResgistro();
			getDatosDG();
		}
		
		void nuevoResgistro()
		{
			dgDatos.ClearSelection();
			limpiaDatos();
			cmdElimina.Enabled=false;
			cmdModifica.Enabled=false;
			cmdNuevo.Enabled=false;
			cmdGuardar.Enabled=true;
		}
		
		void CmdModificaClick(object sender, EventArgs e)
		{
			if(dgDatos[7,dgDatos.CurrentRow.Index].Value.ToString()!="CIERRE")
			{
				String consulta = "update CAJA set ID_R="+ID_RESPONSABLE+", CANTIDAD='"+txtCantidad.Text+"', CONCEPTO='"+txtConcepto.Text+"', AUTORIZA='"+txtAutoriza.Text+"', OBSERVACIONES='"+txtObservacion.Text+"', TIPO='"+((rbEntrada.Checked==true)?"ENTRADA":((rbSalida.Checked==true)?"SALIDA":"CIERRE"))+"', FECHA='"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', FLUJO='1', FECHA_REG=(SELECT CONVERT (DATE, SYSDATETIME())), HORA_REG=(SELECT CONVERT (TIME, SYSDATETIME())) where ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				nuevoResgistro();
				getDatosDG();
			}
			else if(validaCierre()==false && dgDatos[7,dgDatos.CurrentRow.Index].Value.ToString()=="CIERRE")
			{
				String consulta = "update CAJA set ID_R="+ID_RESPONSABLE+", CANTIDAD='"+txtCantidad.Text+"', CONCEPTO='"+txtConcepto.Text+"', AUTORIZA='"+txtAutoriza.Text+"', OBSERVACIONES='"+txtObservacion.Text+"', TIPO='"+((rbEntrada.Checked==true)?"ENTRADA":((rbSalida.Checked==true)?"SALIDA":"CIERRE"))+"', FECHA='"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', FLUJO='1', FECHA_REG=(SELECT CONVERT (DATE, SYSDATETIME())), HORA_REG=(SELECT CONVERT (TIME, SYSDATETIME())) where ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				nuevoResgistro();
				getDatosDG();
			}
			else
			{
				MessageBox.Show("Ya se realizó el cierre del día: "+dtpFecha.Value.ToString("dd/MM/yyyy"));
			}
		}
		
		void CmdEliminaClick(object sender, EventArgs e)
		{
			String consulta = "update CAJA set FLUJO='0' where ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			
			dgDatos.Rows.RemoveAt(dgDatos.CurrentRow.Index);
			
			nuevoResgistro();
		}
	}
}
