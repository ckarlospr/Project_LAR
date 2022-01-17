using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Data;
//using System.Net.Mail;
//using System.Net;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormPrincCombustible : Form
	{
		public FormPrincCombustible(FormPrincipal formPrinc)
		{
			InitializeComponent();
			refPrincipal=formPrinc;
		}
		
		#region VARIABLES
		private Int64 id_unidad=0;
		private Int64 id_operador=0;
		private Int64 id_gasolinera=0;
		private Int64 id_combustible=1;
		public List<Datos.Autorizaciones> listAut;
		List<Interfaz.Combustible.Datos.Kilometrajes> listKm = null;
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormPrincCombustibleLoad(object sender, EventArgs e)
		{
			//listAut = new Conexion_Servidor.Combustible.SQL_Combustible().getAutorizaciones(dtpFechaHistorial.Value.ToString("dd/MM/yyyy"));
			//getHistorialAut();
			datosAutocomplete();
			getUnidades();
			getCargarValidacionCampos(this);
			getAutorizaciones();
			dgAutorizacion.ClearSelection();
			iniciaCombo();
			
			listAut = new Conexion_Servidor.Combustible.SQL_Combustible().getAutorizaciones(dtpFechaHistorial.Value.ToString("dd/MM/yyyy"));
			getHistorialAut();
			
			cmdGenera.Focus();
			
			FechaFin = DateTime.Now.ToString("dd/MM/yyyy");
			FechaInicio = DateTime.Now.ToString("dd/MM/yyyy");
		}
		#endregion
		
		#region GETDATOS PRINCIPALES
		void datosAutocomplete()
		{
			txtBusVehiculo.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtBusVehiculo.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtBusVehiculo.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtNumUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtNumUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtNumUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUnidadValidacion.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtUnidadValidacion.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidadValidacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where tipo_empleado='OPERADOR' and Estatus='1'");
			txtOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperadorValidacion.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where tipo_empleado='OPERADOR' and Estatus='1'");
			txtOperadorValidacion.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperadorValidacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			/*txtCombustible.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from TIPOS_COMB");
			txtCombustible.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtCombustible.AutoCompleteSource = AutoCompleteSource.CustomSource;*/
			
			
			txtGasolinera.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA");
			txtGasolinera.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtGasolinera.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		void getUnidades()
		{
			String consulta = "select ID, Numero, Rendimiento_Optimo, Tipo_Unidad from VEHICULO order by Numero";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgVehiculo.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString(), conn.leer["Rendimiento_Optimo"].ToString(), conn.leer["Tipo_Unidad"].ToString());
			}
			
			conn.conexion.Close();
			
			dgVehiculo.ClearSelection();
		}
		#endregion
		
		#region SELECCION DE UNIDAD
		void TxtBusVehiculoKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				dgVehiculo.ClearSelection();
				
				for(int x=0; x<dgVehiculo.Rows.Count; x++)
				{
					if(txtBusVehiculo.Text==dgVehiculo[1,x].Value.ToString())
					{
						dgVehiculo.Rows[x].Selected = true;
						dgVehiculo.FirstDisplayedCell = dgVehiculo.Rows[x].Cells[1];
						
						lblTipoVeh.Text=dgVehiculo[3,x].Value.ToString();
						txtSelRendimiento.Text=dgVehiculo[2,x].Value.ToString();
						txtSelVehiculo.Text=dgVehiculo[1,x].Value.ToString();
						getOperador(dgVehiculo[1,x].Value.ToString(), txtSelOperador);
					}
				}
			}
		}
		
		void DgVehiculoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				txtBusVehiculo.Text=dgVehiculo[1,e.RowIndex].Value.ToString();
				txtSelRendimiento.Text=dgVehiculo[2,e.RowIndex].Value.ToString();
				txtSelVehiculo.Text=dgVehiculo[1,e.RowIndex].Value.ToString();
				lblTipoVeh.Text=dgVehiculo[3,e.RowIndex].Value.ToString();
				getOperador(dgVehiculo[1,e.RowIndex].Value.ToString(), txtSelOperador);
			}
		}
		
		void DgVehiculoKeyUp(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter)
			{
				if(dgVehiculo.Rows.Count>0)
				{
					txtBusVehiculo.Text=dgVehiculo[1,dgVehiculo.CurrentRow.Index].Value.ToString();
					txtSelRendimiento.Text=dgVehiculo[2,dgVehiculo.CurrentRow.Index].Value.ToString();
					txtSelVehiculo.Text=dgVehiculo[1,dgVehiculo.CurrentRow.Index].Value.ToString();
					lblTipoVeh.Text=dgVehiculo[3,dgVehiculo.CurrentRow.Index].Value.ToString();
					getOperador(dgVehiculo[1,dgVehiculo.CurrentRow.Index].Value.ToString(), txtSelOperador);
				}
			}
		}
		
		void getOperador(string NUMERO_UNI, TextBox AGREGA)
		{
			mcDias.Enabled=true;
			int id_v = 0 ;
			
			String consulta = "select O.Alias, V.ID from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and V.ID=A.ID_UNIDAD and O.Estatus='1' and V.Numero='"+NUMERO_UNI+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				AGREGA.Text=conn.leer["Alias"].ToString();
				id_v=Convert.ToInt16(conn.leer["ID"]);
			}
			else
			{
				AGREGA.Text="Sin asignación";
				id_v=0;
			}
			
			conn.conexion.Close();
			
			getId_Operador();
			//getTiposEmp();
			
			if(id_v!=0)
				getViajes(id_v);//********************************************************************************************************************************
			else
				dgViajes.Rows.Clear();
				
			getFormularios();
		}
		#endregion
		
		#region GET VIAJES POR UNIDAD
		void getViajes(int id)
		{
			dgViajes.Rows.Clear();
			
			String consulta = "select O.id_operacion, O.fecha, O.turno, R.Sentido, R.Nombre, OP.Alias, OE.NOMBRE emp from ORDEN_EMPRESAS OE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C where OE.ID=C.ID_ORDEN and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.id_ruta=R.ID and O.estatus='1' and R.IdSubEmpresa=C.ID and O.fecha between '"+mcDias.SelectionRange.Start.ToString("dd/MM/yyy")+"' and '"+mcDias.SelectionRange.End.ToString("dd/MM/yyy")+"' and OO.id_vehiculo="+id+" order by O.fecha, O.turno, R.nombre";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgViajes.Rows.Add(conn.leer["id_operacion"].ToString(), conn.leer["fecha"].ToString().Substring(0,10), conn.leer["turno"].ToString(), conn.leer["Sentido"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["Alias"].ToString(), conn.leer["emp"].ToString());
			}
			
			conn.conexion.Close();
			
			dgViajes.ClearSelection();
		}
		#endregion
		
		#region VALIDACION
		private void getCargarValidacionCampos(FormPrincCombustible formRef)
		{
			formRef.txtBusVehiculo.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formRef.txtSelVehiculo.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			formRef.txtSelRendimiento.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			formRef.txtSelOperador.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			
			formRef.txtNumUnidad.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formRef.txtOperador.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formRef.txtGasolinera.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formRef.txtKm.KeyPress							+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formRef.txtLitros.KeyPress						+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			formRef.txtUnidadValidacion.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formRef.txtOperadorValidacion.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		#endregion
		
		#region CAMBIO PRECIOS COMBUSTIBLE
		void CbModificarCheckedChanged(object sender, EventArgs e)
		{
			if(cbModificar.Checked==true)
			{
				txtPrecioGasolina.Enabled=true;
				txtPrecioDiesel.Enabled=true;
				cmdGuardarPrecios.Enabled=true;
			}
			else
			{
				txtPrecioGasolina.Enabled=false;
				txtPrecioDiesel.Enabled=false;
				cmdGuardarPrecios.Enabled=false;
			}
		}
		#endregion
		
		void CmdAgregarMovClick(object sender, EventArgs e)
		{
			
		}
		
		#region SELECCION DEL MONTH CALENDAR
		void McDiasDateChanged(object sender, DateRangeEventArgs e)
		{
			getViajes(Convert.ToInt16(dgVehiculo[0,dgVehiculo.CurrentRow.Index].Value));//*********************************************************************************
			getFormularios();
		}
		
		void getFormularios()
		{
			while(pDatos.Controls.Count > 0)
			{
            	this.pDatos.Controls.RemoveAt(0);
			}
			
			TimeSpan ts = mcDias.SelectionRange.End - mcDias.SelectionRange.Start;
			
			for(int x=0; x<(ts.Days + 1); x++)
			{
				agregaFormDatos(mcDias.SelectionRange.Start.AddDays(+x).ToShortDateString(), 79*x);
			}
		}
		
		public void agregaFormDatos(String fecha, int posicion)
		{
			Interfaz.Combustible.FormDatosDia formdia = new FormDatosDia(fecha);
			formdia.TopLevel = false;
			
			this.pDatos.Tag = formdia;
            this.pDatos.Controls.Add(formdia);
            
            formdia.Location = new System.Drawing.Point(0,posicion);
            
            formdia.Show();
		}
		#endregion
		
		// ******************************************************** AUTORIZACION *************************************************************
		
		#region EVENTOS BOTONES
		void CmdEliminarClick(object sender, EventArgs e)
		{
			if(dgAutorizacion.SelectedRows.Count>0)
			{
				new Conexion_Servidor.Combustible.SQL_Combustible().eliminaAutorizacion(Convert.ToInt64(lblAutorizacion.Text));
				epFaltantes.Clear();
				limpaDatosAutorisacion();
				dgAutorizacion.Rows.RemoveAt(dgAutorizacion.CurrentRow.Index);
				dgAutorizacion.ClearSelection();
			}
		}
		
		void CmdExternasClick(object sender, EventArgs e)
		{
			
		}
		
		void CmdGeneraClick(object sender, EventArgs e)
		{
			if(lblAutorizacion.Text=="#")
			{
				lblAutorizacion.Text=(new Conexion_Servidor.Combustible.SQL_Combustible().getNumAutorizacion(refPrincipal.idUsuario)).ToString();
				cmdGuardar.Enabled=true;
				cmdNuevo.Enabled=true;
				dgAutorizacion.Rows.Clear();
				/*if(dtpFechaCons.Value.ToString()==dtpFechaBase.Value.ToString())
				{*/
					getAutorizaciones();
					dgAutorizacion.ClearSelection();
					for(int x=0; x<dgAutorizacion.Rows.Count; x++)
					{
						if(dgAutorizacion[1,x].Value.ToString()==lblAutorizacion.Text)
						{
							dgAutorizacion.Rows[x].Selected = true;
							dgAutorizacion.FirstDisplayedCell = dgAutorizacion.Rows[x].Cells[1];
						}
					}
				//}
			}
		}
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			limpaDatosAutorisacion();
			epFaltantes.Clear();
			cmdGuardar.Enabled=false;
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			validaGuardado();
			limpaDatosAutorisacion();
			cmdGuardar.Enabled=false;
			if(dtpFechaCons.Value.ToString("dd/MM/yyyy")==dtpFechaBase.Value.ToString("dd/MM/yyyy"))
			{
				getAutorizaciones();
				dgAutorizacion.ClearSelection();
			}
			else
			{
				dgAutorizacion.Rows.RemoveAt(dgAutorizacion.CurrentRow.Index);
				dgAutorizacion.ClearSelection();
			}
		}
		
		void CmdHoraClick(object sender, EventArgs e)
		{
			dtpCarga.Value = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
			//MessageBox.Show(dtpCarga.Value.ToString("HH:mm:ss"));
		}
		
		void CmdHrAutorizaClick(object sender, EventArgs e)
		{
			dtpAutorizacion.Value = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
		}
		#endregion
		
		#region LIMPIA DATOS AUTORIZACION
		void limpaDatosAutorisacion()
		{
			lblAutorizacion.Text="#";
			txtNumUnidad.Text="000";
			txtOperador.Text="";
			txtVehiculo.Text="000";
			txtGasolinera.Text="";
			cmbTipoCom.SelectedIndex=0;
			txtLitros.Text="0";
			txtKm.Text="0";
			dtpCarga.Value = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));
			
			id_unidad=0;
			id_operador=0;
			id_gasolinera=0;
			id_combustible=1;
		}
		#endregion
		
		#region EVENTOS TXTNUMUNIDAD
		void TxtNumUnidadMouseClick(object sender, MouseEventArgs e)
		{
			txtNumUnidad.SelectAll();
		}
		
		void TxtNumUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				getOperador(txtNumUnidad.Text, txtOperador);
				getId_Unidad();
			}
		}
		
		void TxtNumUnidadLeave(object sender, EventArgs e)
		{
			getOperador(txtNumUnidad.Text, txtOperador);
			getId_Unidad();
		}
		#endregion
		
		#region LLENADO DGAUTORIZACION
		void DtpFechaConsValueChanged(object sender, EventArgs e)
		{
			getAutorizaciones();
		}
		
		void getAutorizaciones()
		{
			//dgViajes.Rows.Clear();
			dgAutorizacion.Rows.Clear();
			
			String consulta = "select * from AUTORIZACION WHERE ESTATUS!='0' and (FECHA_BASE='"+dtpFechaCons.Value.ToString("dd/MM/yyyy")+"' or FECHA_BASE is null)";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgAutorizacion.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NUMERO"].ToString(), ((conn.leer["FECHA_BASE"].ToString()=="")?"":conn.leer["FECHA_BASE"].ToString().Substring(0,10)), conn.leer["HORA_AUTORIZACION"].ToString(), conn.leer["ID_G"].ToString(), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), conn.leer["LITROS"].ToString(), conn.leer["KM"].ToString(), conn.leer["HORA_CARGA"].ToString(), conn.leer["ID_COM"].ToString(), conn.leer["ID_G"].ToString(), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString());
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgAutorizacion.Rows.Count; x++)
			{
				//MessageBox.Show("_"+dgAutorizacion[4,x].Value.ToString()+"_");
				if(dgAutorizacion[4,x].Value.ToString()!="")
				{
					try
					{
						Convert.ToInt64(dgAutorizacion[4,x].Value.ToString());
						consulta = "select NOMBRE from GASOLINERA where ID='"+dgAutorizacion[4,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgAutorizacion[4,x].Value=conn.leer["NOMBRE"].ToString();
						}
						conn.conexion.Close();
					}
					catch
					{
						
					}
				}
				
				if(dgAutorizacion[6,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgAutorizacion[6,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacion[6,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacion[5,x].Value.ToString()!="")
				{
					consulta = "select Numero from VEHICULO where ID='"+dgAutorizacion[5,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacion[5,x].Value=conn.leer["Numero"].ToString();
					}
					conn.conexion.Close();
				}
				
				/*if(dgAutorizacion[10,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from TIPOS_COMB where ID='"+dgAutorizacion[10,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacion[10,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}*/
			}
		}
		#endregion
		
		#region LLENADO DE COMBOBOX TIPO COMBUSTIBLE EN AUORIZACION
		void iniciaCombo()
		{
			cmbTipoEmp.Items.Clear();
			String consulta = "select * from TIPOS_COMB";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				cmbTipoCom.Items.Add(conn.leer["NOMBRE"].ToString());
			}
			
			conn.conexion.Close();
			
			cmbTipoCom.SelectedIndex=0;
		}
		#endregion
		
		#region GET ID'S
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				getId_Operador();
				getTiposEmp();
			}
		}
		
		void TxtOperadorLeave(object sender, EventArgs e)
		{
			getId_Operador();
			getTiposEmp();
		}
		
		void TxtGasolineraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				getId_Gasolinera();
			}
		}
		
		void TxtGasolineraLeave(object sender, EventArgs e)
		{
			getId_Gasolinera();
		}
		
		void CmbTipoComSelectedIndexChanged(object sender, EventArgs e)
		{
			getId_Combust();
		}
		
		void getId_Unidad()
		{
			String consulta = "select * from VEHICULO where Numero='"+txtNumUnidad.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				id_unidad=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				id_unidad=0;
			}
			
			conn.conexion.Close();
		}
		
		void getId_Operador()
		{
			String consulta = "select * from OPERADOR where Alias='"+txtOperador.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				id_operador=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				id_operador=0;
			}
			
			conn.conexion.Close();
		}
		
		void getId_Gasolinera()
		{
			String consulta = "select * from GASOLINERA where SUBNOMBRE='"+txtGasolinera.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				id_gasolinera=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				id_gasolinera=0;
			}
			
			conn.conexion.Close();
		}
		
		void getId_Combust()
		{
			String consulta = "select * from TIPOS_COMB where NOMBRE='"+cmbTipoCom.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				id_combustible=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				id_combustible=0;
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTO CELLCLICK DEL DGAUTORIZACION
		void DgAutorizacionCellClick(object sender, DataGridViewCellEventArgs e)
		{
			limpaDatosAutorisacion();
			epFaltantes.Clear();
			
			if(e.RowIndex>-1)
			{
				lblAutorizacion.Text=dgAutorizacion[1,e.RowIndex].Value.ToString();
				
				if(dgAutorizacion[5,e.RowIndex].Value.ToString()=="")
				{
					//epFaltantes.SetError(this.txtNumUnidad,"Falta unidad.");
					id_unidad=0;
				}
				else
				{
					id_unidad=Convert.ToInt64(dgAutorizacion[12,e.RowIndex].Value);
					txtNumUnidad.Text=dgAutorizacion[5,e.RowIndex].Value.ToString();
				}
				
				if(dgAutorizacion[2,e.RowIndex].Value.ToString()!="")
					dtpFechaBase.Value=Convert.ToDateTime(dgAutorizacion[2,e.RowIndex].Value.ToString());
				/*else
					epFaltantes.SetError(this.dtpFechaBase,"Ingrese fecha de carga.");*/
				
				
				if(dgAutorizacion[3,e.RowIndex].Value.ToString()!="")
					dtpAutorizacion.Value=Convert.ToDateTime(dgAutorizacion[3,e.RowIndex].Value.ToString());
				/*else
					epFaltantes.SetError(this.dtpAutorizacion,"Ingrese la hora en que autorizó la carga.");*/
					
				
				if(dgAutorizacion[6,e.RowIndex].Value.ToString()=="")
				{
					//epFaltantes.SetError(this.txtOperador,"Ingrese nombre de quien solicito la carga.");
					cmbTipoEmp.Items.Clear();
					id_combustible=0;
				}
				else
				{
					txtOperador.Text=dgAutorizacion[6,e.RowIndex].Value.ToString();
					
					getTiposEmp();
					
					id_operador=Convert.ToInt64(dgAutorizacion[13,e.RowIndex].Value);
					String consulta = "select tipo_empleado from OPERADOR where ID='"+dgAutorizacion[13,e.RowIndex].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						for(int x=0; x<cmbTipoEmp.Items.Count; x++)
						{
							if(cmbTipoEmp.Items[x].ToString()==conn.leer["tipo_empleado"].ToString())
							{
								cmbTipoEmp.SelectedIndex=x;
							}
						}
					}
					
					conn.conexion.Close();
				}
					
				if(dgAutorizacion[4,e.RowIndex].Value.ToString()=="")
				{
					//epFaltantes.SetError(this.txtGasolinera,"Ingrese Gasolinera donde se realizó la carga.");
					id_gasolinera=0;
				}
				else
				{
					id_gasolinera=Convert.ToInt64(dgAutorizacion[11,e.RowIndex].Value);
					txtGasolinera.Text=dgAutorizacion[4,e.RowIndex].Value.ToString();
				}
				
				if(dgAutorizacion[10,e.RowIndex].Value.ToString()=="")
				{
					//epFaltantes.SetError(this.cmbTipoCom,"Seleccione tipo de combustible.");
					id_combustible=0;
				}
				else
				{
					id_combustible=Convert.ToInt64(dgAutorizacion[10,e.RowIndex].Value);
					String consulta = "select NOMBRE from TIPOS_COMB where ID='"+dgAutorizacion[10,e.RowIndex].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						for(int x=0; x<cmbTipoCom.Items.Count; x++)
						{
							if(cmbTipoCom.Items[x].ToString()==conn.leer["NOMBRE"].ToString())
							{
								cmbTipoCom.SelectedIndex=x;
							}
						}
					}
					
					conn.conexion.Close();
				}
						
				if(dgAutorizacion[7,e.RowIndex].Value.ToString()!="" || dgAutorizacion[7,e.RowIndex].Value.ToString()!="0")
					txtLitros.Text=dgAutorizacion[7,e.RowIndex].Value.ToString();
				/*else
					epFaltantes.SetError(this.txtLitros,"Ingrese la cantidad de litros que se cargaron.");*/
				
				if(dgAutorizacion[8,e.RowIndex].Value.ToString()!="" || dgAutorizacion[8,e.RowIndex].Value.ToString()!="0")
					txtKm.Text=dgAutorizacion[8,e.RowIndex].Value.ToString();
				/*else
					epFaltantes.SetError(this.txtKm,"Ingrese el kilometraje del hubodometro.");*/
					
				
				if(dgAutorizacion[9,e.RowIndex].Value.ToString()!="")
					dtpCarga.Value=Convert.ToDateTime(dgAutorizacion[9,e.RowIndex].Value.ToString());
				/*else
					epFaltantes.SetError(this.dtpCarga,"Ingrese hora en que cargo la unidad.");*/
					
				
				cmdGuardar.Enabled=true;
				cmdNuevo.Enabled=true;
			}
		}
		#endregion
		
		#region GUARDA_MODIFICA
		void validaGuardado()
		{
			epFaltantes.Clear();
			
			if(id_unidad==0)
				epFaltantes.SetError(this.txtNumUnidad,"Ingrese unidad."); 
			if(id_operador==0)
				epFaltantes.SetError(this.txtOperador,"Quien pide autorización.");
			if(id_gasolinera==0)
				epFaltantes.SetError(this.txtGasolinera,"Ingrese gasolinera."); 
			if(id_combustible==0)
				epFaltantes.SetError(this.cmbTipoCom,"Selecccione tipo de combustible."); 
			
			if(id_unidad==0)
			{
				DialogResult rs = MessageBox.Show("Unidad no asiganda. ¿Desea guardar sin unidad?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs)
				{
					guardaAutorizacion();
				}
			}
			else if(id_operador==0)
			{
				DialogResult rs = MessageBox.Show("No se ha asignado quien pide autorización. ¿Desea guardar sin nombre?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs)
				{
					guardaAutorizacion();
				}
			}
			else if(id_gasolinera==0)
			{
				DialogResult rs = MessageBox.Show("Gasolinera no asiganda. ¿Desea guardar sin nombre de gasolinera?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs)
				{
					guardaAutorizacion();
				}
			}
			else if(id_combustible==0)
			{
				DialogResult rs = MessageBox.Show("Tipo de combustible no seleccionado. ¿Desea guardar sin combustible seleccionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs)
				{
					guardaAutorizacion();
				}
			}
			else
			{
				guardaAutorizacion();
			}
		}
		
		void guardaAutorizacion()
		{
			//MessageBox.Show(id_gasolinera+":ID_gas, "+id_operador+":ID_Ope, "+id_unidad+":ID_Unid, "+ id_combustible+":id_comb, "+ dtpFechaBase.Value.ToString("dd/MM/yyyy")+", "+ dtpAutorizacion.Value.ToString("HH:mm:ss")+", "+ Convert.ToDouble(txtLitros.Text)+", "+ Convert.ToDouble(txtKm.Text)+", "+ dtpCarga.Value.ToString("HH:mm:ss")+", "+ Convert.ToInt64(lblAutorizacion.Text));
			new Conexion_Servidor.Combustible.SQL_Combustible().modificaAutorizacion(id_gasolinera, id_operador, id_unidad, id_combustible, dtpFechaBase.Value.ToString("dd/MM/yyyy"), dtpAutorizacion.Value.ToString("HH:mm:ss"), Convert.ToDouble(txtLitros.Text), Convert.ToDouble(txtKm.Text), dtpCarga.Value.ToString("HH:mm:ss"), Convert.ToInt64(lblAutorizacion.Text));
			
			epFaltantes.Clear();
			
			cmdGenera.Focus();
		}
		#endregion
		
		#region VALIDACION DE CEROS	
		void TxtKmLeave(object sender, EventArgs e)
		{
			if(txtKm.Text=="")
			{
				txtKm.Text="0";
			}
		}
		
		void TxtLitrosLeave(object sender, EventArgs e)
		{
			if(txtLitros.Text=="")
			{
				txtLitros.Text="0";
			}
		}
		#endregion
		
		#region GETDATOS OPERADOR SELECCIONADO
		void getTiposEmp()
		{
			cmbTipoEmp.Items.Clear();
			
			String consulta = "select tipo_empleado from OPERADOR where ALIAS='"+txtOperador.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				cmbTipoEmp.Items.Add(conn.leer["tipo_empleado"].ToString());
			}
			
			conn.conexion.Close();
			
			if(cmbTipoEmp.Items.Count>0)
				cmbTipoEmp.SelectedIndex=0;
			
			if(cmbTipoEmp.Items.Count==1)
				cmbTipoEmp.Enabled=false;
			else
				cmbTipoEmp.Enabled=true;
			
			consulta = "select V.NUMERO from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.ALIAS='"+txtOperador.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtVehiculo.Text=conn.leer["NUMERO"].ToString();
			}
			else
			{
				txtVehiculo.Text="000";
			}
			
			conn.conexion.Close();
		}
		
		void CmbTipoEmpSelectedIndexChanged(object sender, EventArgs e)
		{
			String consulta = "select * from OPERADOR where ALIAS='"+txtOperador.Text+"' and tipo_empleado='"+cmbTipoEmp.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				id_operador=Convert.ToInt64(conn.leer["ID"]);
			}
			conn.conexion.Close();
			
			consulta = "select V.NUMERO from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.ALIAS='"+txtOperador.Text+"' and tipo_empleado='"+cmbTipoEmp.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtVehiculo.Text=conn.leer["NUMERO"].ToString();
			}
			else
			{
				txtVehiculo.Text="000";
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region VALIDACION VALORES DEL DATAGRID DE VALIDACION
		void DgAutorizacionCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			/*try
			{
				Convert.ToDouble(dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Value);
				dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
			}
			catch(Exception)
			{
				dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Value="0.00";
				dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
			}*/
		}
		#endregion
		
		// ***********************************************************************************************************************************
		
		// ********************************************************** HISTORIAL **************************************************************
		#region LLENADO DE DATAGRID HISTORIAL
		void getHistorialAut()
		{
			dgHistorial.Rows.Clear();
			
			String consulta = "select ID, Numero, Tipo_Unidad from VEHICULO where Estado='1' order by Tipo_Unidad, Numero";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgHistorial.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString(), conn.leer["Tipo_Unidad"].ToString(), "", "", "", "", "", "");
			}
			
			conn.conexion.Close();
			
			if(listAut!=null)
			{
				for(int x=0; x<dgHistorial.Rows.Count; x++)
				{
					for(int y=0; y<listAut.Count; y++)
					{
						if(listAut[y].ID_UNIDAD==dgHistorial[0,x].Value.ToString())
						{
							dgHistorial[3,x].Value=listAut[y].ID_AUTORIZACION;
							dgHistorial[4,x].Value=listAut[y].GASOLINERA;
							dgHistorial[5,x].Value=listAut[y].OPERADOR;
							dgHistorial[6,x].Value=listAut[y].HORA_A;
							dgHistorial[7,x].Value=listAut[y].LITROS;
							dgHistorial[8,x].Value=listAut[y].KM;
							dgHistorial[9,x].Value=listAut[y].HORA_C;
						}
					}
				}
			}
			
			for(int x=0; x<dgHistorial.Rows.Count; x++)
			{
				if(dgHistorial[4,x]==null || dgHistorial[4,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from GASOLINERA where ID='"+dgHistorial[4,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgHistorial[4,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgHistorial[6,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgHistorial[5,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgHistorial[5,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				//dgHistorial.Columns[2].SortMode = SortOrder.Descending;
				
				// para kilometraje .....??????????
				/*if(dgHistorial[3,x].Value.ToString()=="")
				{
					consulta="SELECT sum(cast(R.Kilometros as DECIMAL(10,2))) total FROM usuario U, Cliente C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, " +
						"OPERADOR OP, VEHICULO V WHERE U.id_usuario=O.id_usuario and C.ID=R.IdSubEmpresa AND R.ID=O.id_ruta AND O.id_operacion=OO.id_operacion " +
						"AND OO.id_operador=OP.ID and V.ID=OO.id_vehiculo  and O.estatus='1' and R.FACTURA='0' AND O.fecha BETWEEN (select top 1 FECHA_BASE " +
						"from AUTORIZACION WHERE ID_V="+dgHistorial[0,x].Value.ToString()+"  and FECHA_BASE<'"+dtpFechaHistorial.Value.ToString("yyyy/MM/dd")+"' order by FECHA_BASE desc) AND '"+dtpFechaHistorial.Value.ToString("yyyy/MM/dd")+"' AND V.ID="+dgHistorial[0,x].Value.ToString();
					
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgHistorial[10,x].Value=conn.leer["total"].ToString();
					}
					conn.conexion.Close();
				}*/
			}
			
			/*listKm =  new Conexion_Servidor.Combustible.SQL_Combustible().getKmrecorridos(dtpFechaHistorial.Value.ToString("yyyy/MM/dd"));
			
			for(int y=0; y<listKm.Count; y++)
			{
				//MessageBox.Show(listKm[y].KM);
			}
			
			for(int x=0; x<dgHistorial.Rows.Count; x++)
			{
				for(int y=0; y<listKm.Count; y++)
				{
					if(dgHistorial[0,x].Value.ToString()==listKm[y].ID_V)
					{
						dgHistorial[10,x].Value=listKm[y].KM;
					}
				}
			}*/
		}
		
		void DtpFechaHistorialValueChanged(object sender, EventArgs e)
		{
			listAut = new Conexion_Servidor.Combustible.SQL_Combustible().getAutorizaciones(dtpFechaHistorial.Value.ToString("dd/MM/yyyy"));
			getHistorialAut();
		}
		
		void CmdMuestraClick(object sender, EventArgs e)
		{
			listAut = new Conexion_Servidor.Combustible.SQL_Combustible().getAutorizaciones(dtpFechaHistorial.Value.ToString("dd/MM/yyyy"));
			getHistorialAut();
		}
		#endregion
		// ***********************************************************************************************************************************
		
		#region EXPORTADO A EXCEL
		void CmdExportaHistClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			++i;
			ExcelApp.Cells[i,  1] = "NUMERO";
			ExcelApp.Cells[i,  2] = "VEHÍCULO";
			ExcelApp.Cells[i,  3] = "GASOLINERA";
			ExcelApp.Cells[i,  4] = "OPERADOR";
			ExcelApp.Cells[i,  5] = "HR. AUTORIZACION";
			ExcelApp.Cells[i,  6] = "LITROS";
			ExcelApp.Cells[i,  7] = "KM";
			ExcelApp.Cells[i,  8] = "HR. CARGA";
			
			for(int x=0; x<dgHistorial.Rows.Count; x++)
			{
				++i;
				try{ExcelApp.Cells[i,  1] = dgHistorial[1,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  1] = "";}
				try{ExcelApp.Cells[i,  2] = dgHistorial[2,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  2] = "";}
				try{ExcelApp.Cells[i,  3] = dgHistorial[4,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  3] = "";}
				try{ExcelApp.Cells[i,  4] = dgHistorial[5,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  4] = "";}
				try{ExcelApp.Cells[i,  5] = dgHistorial[6,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  5] = "";}
				try{ExcelApp.Cells[i,  6] = dgHistorial[7,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  6] = "";}
				try{ExcelApp.Cells[i,  7] = dgHistorial[8,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  7] = "";}
				try{ExcelApp.Cells[i,  8] = dgHistorial[9,x].Value.ToString();}catch (Exception){ExcelApp.Cells[i,  8] = "";}
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Carga de combustible "+DateTime.Now.ToString("dd-MM-yyyy");
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
		
		#region PARA ENVIO DE CORREOS ELECTRONICOS
		/*private bool adj = false;
		private String archivo;
		
		void CmdAdjuntarClick(object sender, EventArgs e)
		{
			adj = true;
			
			OpenFileDialog _file = new OpenFileDialog();
			_file.Title="Seleccionar archivo";
			_file.InitialDirectory=@"c:\";
			_file.Filter="All files(*.*)|*.*";
			_file.FilterIndex=1;
			_file.RestoreDirectory=true;
			_file.ShowDialog();
			archivo=_file.FileName;
		}
		
		void CmdMailClick(object sender, EventArgs e)
		{
			MailMessage _Correo = new MailMessage();
			_Correo.From = new MailAddress("lar@lar.com.mx"); // PARA. CORREO A QUIEN ENVIAMOS
			
			_Correo.To.Add("ckarlos_perez@hotmail.es"); // DE. CORREO DE QUIEN ENVIAMOS
			_Correo.Subject="Asunto prueba";
			_Correo.Body="Estoy mandando una prueba y esto es el contenido";
			
			_Correo.IsBodyHtml=false; // NO ES HTML
			_Correo.Priority=MailPriority.Normal;	//TIPO DE PRIORIDAD
			
			if(adj==true)
			{
				Attachment _attatchment = new Attachment(@archivo);
				_Correo.Attachments.Add(_attatchment);
				adj=false;
			}
			
			SmtpClient smtp = new SmtpClient();
			smtp.Credentials =  new NetworkCredential("lar@lar.com.mx","11111");
			
			//smtp.Host="smtp.gmail.com";
			smtp.Host="smtp.webmail.lar.com.mx";
			smtp.Port=587;
			smtp.EnableSsl=true;
			
			try
			{
				smtp.Send(_Correo);
				MessageBox.Show("Correo enviado");
			}
			catch(Exception)
			{
				MessageBox.Show("Correo no enviado");
			}
			_Correo.Dispose();
			
			//referencia: http://codigofuentenet.wordpress.com/2012/06/20/mandar-correos-con-visual-estudio-2010-c/
		}*/
		#endregion
		
		
		//  *********************************************************************************************************************************
		//  ******************************************************* VALIDACION **********************************************************
		//  *********************************************************************************************************************************
		
		String FechaInicio;
		String FechaFin;
		
		#region BUSQUEDA PARA VALIDACION
		void TxtUnidadValidacionKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				getViajesValidacion();
				getAutorizacionesValidacion();
			}
		}
		
		void TxtUnidadValidacionEnter(object sender, EventArgs e)
		{
			txtUnidadValidacion.SelectAll();
		}
		
		void TxtOperadorValidacionKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				getViajesValidacion();
				getAutorizacionesValidacion();
			}
		}
		
		void TxtOperadorValidacionEnter(object sender, EventArgs e)
		{
			txtOperadorValidacion.SelectAll();
		}
		#endregion
		
		#region GET DATOS EN LOS DATAGRID
		void getAutorizacionesValidacion()
		{
			dgAutorizacionValida.Rows.Clear();
			
			String consulta = "select * from AUTORIZACION WHERE ESTATUS!='0' and (FECHA_BASE between '"+FechaInicio+"' and '"+FechaFin+"' or FECHA_BASE is null) and (ID_O in (select ID from OPERADOR where Alias like '%"+txtOperadorValidacion.Text+"%') or ID_O is null) and (ID_V in (select ID from VEHICULO where Numero like '%"+txtUnidadValidacion.Text+"%') or ID_V is null)  order by NUMERO";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgAutorizacionValida.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NUMERO"].ToString(), ((conn.leer["FECHA_BASE"].ToString()=="")?"":conn.leer["FECHA_BASE"].ToString().Substring(0,10)), conn.leer["HORA_AUTORIZACION"].ToString(), conn.leer["ID_G"].ToString(), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), conn.leer["LITROS"].ToString(), conn.leer["KM"].ToString(), conn.leer["HORA_CARGA"].ToString(), conn.leer["ID_COM"].ToString(), conn.leer["ID_G"].ToString(), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString());
			}
			
			conn.conexion.Close();
			dgAutorizacionValida.ClearSelection();
			
			for(int x=0; x<dgAutorizacionValida.Rows.Count; x++)
			{
				//MessageBox.Show("_"+dgAutorizacion[4,x].Value.ToString()+"_");
				if(dgAutorizacionValida[4,x].Value.ToString()!="")
				{
					try
					{
						Convert.ToInt64(dgAutorizacionValida[4,x].Value.ToString());
						consulta = "select NOMBRE from GASOLINERA where ID='"+dgAutorizacionValida[4,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgAutorizacionValida[4,x].Value=conn.leer["NOMBRE"].ToString();
						}
						conn.conexion.Close();
					}
					catch
					{
						
					}
				}
				
				if(dgAutorizacionValida[6,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgAutorizacionValida[6,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[6,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[5,x].Value.ToString()!="")
				{
					consulta = "select Numero from VEHICULO where ID='"+dgAutorizacionValida[5,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[5,x].Value=conn.leer["Numero"].ToString();
					}
					conn.conexion.Close();
				}
				
				/*if(dgAutorizacion[10,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from TIPOS_COMB where ID='"+dgAutorizacion[10,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacion[10,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}*/
			}
		}
		
		void getViajesValidacion()
		{
			dgMovimientosRutas.Rows.Clear();
			
			String consulta = "select O.id_operacion, O.fecha, O.turno, R.Sentido, R.Nombre, OP.Alias, OE.NOMBRE emp, V.Numero from ORDEN_EMPRESAS OE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, VEHICULO V where V.ID=OO.id_vehiculo and OE.ID=C.ID_ORDEN and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.id_ruta=R.ID and O.estatus='1' and R.IdSubEmpresa=C.ID and O.fecha between '"+FechaInicio+"' and '"+FechaFin+"' and OP.Alias like '%"+txtOperadorValidacion.Text+"%' and  V.Numero like '%"+txtUnidadValidacion.Text+"%' order by O.fecha, O.turno, R.nombre";;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgMovimientosRutas.Rows.Add(conn.leer["id_operacion"].ToString(), conn.leer["fecha"].ToString().Substring(0,10), conn.leer["turno"].ToString(), conn.leer["Sentido"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["emp"].ToString());
			}
			
			conn.conexion.Close();
			
			dgMovimientosRutas.ClearSelection();
		}
		#endregion
		
		void McValidacionDateChanged(object sender, DateRangeEventArgs e)
		{
			getViajesValidacion();
			getAutorizacionesValidacion();
		}
	}
}
