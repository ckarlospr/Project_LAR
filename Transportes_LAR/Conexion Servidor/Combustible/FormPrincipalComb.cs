using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Collections.Generic;
using nmExcel = Microsoft.Office.Interop.Excel;
using System.Net.NetworkInformation;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class formPrincipalComb : Form
	{
		public formPrincipalComb(FormPrincipal formPrinc)
		{
			InitializeComponent();
			refPrincipal=formPrinc;
		}
		
		#region VARIABLES
		bool iniciaTickets = true;
		
		bool cambioAnular = false;
		
		double factorEficiencia = 0.0;
		double factorLitros = 0.0;
		double factorKm = 0.0;
		double factorRend = 0.0;
		double factorMaximoEf = 0.0;
		double factorMaximoKm = 0.0;
		
		double factorETMaxi = 0.0;
		double factorETMin = 0.0;
		double factorLitTikets = 0.0;
		
		Int64 ID_UNN = 0;
		bool cambioCom = false;
		
		Int64 ID_OPERADOR = 0;
		Int64 ID_UNIDAD = 0;
		Int64 ID_GASOLINERA = 0;
		Int64 ID_COMBUSTIBLE = 1 ;
		bool entra = false;
		public List<Datos.Autorizaciones> listAut;
		
		String FechaInicio;
		String FechaFin;
		Int64 ID_Auto = 0;
		String Hora_Auto = "00:00";
		Double KM_Auto=0.0;
		String Estatus_Auto="0";
		
		bool inicio = true;
		bool inicio2 = true;
		bool cambio = false;
		
		int seleccion = 0;
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.SQL_Conexion conn2= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.SQL_Conexion conn3= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.SQL_Conexion conn4= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormPrincipalCombLoad(object sender, EventArgs e)
		{
			getCombustible();
			datosAutocomplete();
			iniciaCombo();
			getDatosDatagrid();
			getCargarValidacionCampos(this);
			getHistorialAut();
			//getReporte();
			getDatosDGestatus();
			getFaltantes();
			getTipoAutorizacion();
			getFactor();
			//getDatosDGTickets();
			
			tcPrincipalComb.TabPages.RemoveAt(2);			
			
			/*if(refPrincipal.lblDatoNivel.Text!="MASTER" && refPrincipal.lblDatoNivel.Text!="GERENCIAL")
				tcPrincipalComb.TabPages.RemoveAt(2);*/

			FechaFin = DateTime.Now.ToString("dd/MM/yyyy");
			FechaInicio = DateTime.Now.ToString("dd/MM/yyyy");
			
			//dtpHoraC.Format = DateTimePickerFormat.Custom;
			//dtpHoraC.CustomFormat = "HH:mm:ss";
			
			txtNumUnidad.Focus();
			cmbRendimiento.SelectedIndex=0;
			cmbAnular.SelectedIndex=0;
			
			if(refPrincipal.lblDatoNivel.Text=="GERENCIAL" || refPrincipal.lblDatoNivel.Text=="MASTER")
			{
				cmdRegresaTicket.Visible=true;
			}
		}
		#endregion
		
		#region CLOSE
		void FormPrincipalCombFormClosing(object sender, FormClosingEventArgs e)
		{
			refPrincipal.combustible=false;
		}
		#endregion
		
		#region AUTOCOMPLETE
		void datosAutocomplete()
		{
			txtRepOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtRepOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtRepOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtRepUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtRepUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtRepUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtNumUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtNumUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtNumUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtGasolinera.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA");
			txtGasolinera.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtGasolinera.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUnidadValidacion.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtUnidadValidacion.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidadValidacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperadorValidacion.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperadorValidacion.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperadorValidacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtMarca.AutoCompleteCustomSource = auto.AutoReconocimiento("select Marca dato from VEHICULO");
			txtMarca.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtMarca.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtbusUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtbusUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtbusUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			/*********************tikets***********************/
			
			txtUnidadR3.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtUnidadR3.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidadR3.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperadosR3.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperadosR3.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperadosR3.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtGasolineraR3.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA");
			txtGasolineraR3.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtGasolineraR3.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUnidadR3M.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtUnidadR3M.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidadR3M.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperadorR3M.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperadorR3M.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperadorR3M.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtGasolineraR3M.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA");
			txtGasolineraR3M.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtGasolineraR3M.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			/**************************************************/
		}
		#endregion
		
		#region VALIDACION DE CAMPOS
		private void getCargarValidacionCampos(formPrincipalComb formRef)
		{
			formRef.txtNumUnidad.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formRef.txtbusUnidad.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formRef.txtUnidadValidacion.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			formRef.txtOperadorValidacion.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			//--************************
			//formRef.txtKms.KeyPress							+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		//*********************************************************************************************************************************
		//****************************************************** AUTORIZACION *************************************************************
		//*********************************************************************************************************************************
		
		#region [ AUTORIZACION ]
		void LblKmUltimoDoubleClick(object sender, EventArgs e)
		{
			txtKms.Text=lblKmUltimo.Text;
		}
		
		#region REFRESCA INFORMACION
		void BtnRefrescaClick(object sender, EventArgs e)
		{
			getDatosDatagrid();
			getDatosDGestatus();
			getFaltantes();
		}
		#endregion
		
		void CbGasExternaCheckedChanged(object sender, EventArgs e)
		{
			if(cbGasExterna.Checked==true)
			{
				txtGasolinera.Enabled=false;
				dtpInicioNum.Enabled=true;
				dtpHoraNum.Enabled=true;
				
				String consulta = "SELECT * FROM GASOLINERA WHERE TIPO='EXTERNA'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_GASOLINERA=Convert.ToInt64(conn.leer["ID"]);
					txtGasolinera.Text=conn.leer["nombre"].ToString();
					txtGasolinera.BackColor=Color.MediumSpringGreen;
				}
				
				conn.conexion.Close();
			}
			else
			{
				ID_GASOLINERA=0;
				txtGasolinera.Text="";
				
				txtGasolinera.Enabled=true;
				dtpInicioNum.Enabled=false;
				dtpHoraNum.Enabled=false;
			}
		}
		
		#region TIPO AUTORIZACION
		void getTipoAutorizacion()
		{
			String consulta = "SELECT CONVERT (DATETIME, SYSDATETIME()) HORA";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(Convert.ToDateTime(conn.leer["HORA"]).Hour>10)
				{
					lblTipoAtutorizacion.Text="FUERA DE HORARIO";
					lblTipoAtutorizacion.BackColor=Color.Red;
					
					rbTaller.Enabled=true;
					rbPersonal.Enabled=true;
					rbEspecial.Enabled=true;
					
					
					cmbNoCarga.Items.Clear();
					cmbNoCarga.Items.Add("");
					cmbNoCarga.Items.Add("LLAMADA");
					cmbNoCarga.Items.Add("CARGA MAS TARDE");
					cmbNoCarga.Items.Add("CARGA MAÑANA");
					cmbNoCarga.Text="LLAMADA";
					
					rbContesta.Enabled=true;
				}
				else
				{
					lblTipoAtutorizacion.Text="EN HORARIO";
					lblTipoAtutorizacion.BackColor=Color.MediumSpringGreen;
					rbContesta.Enabled=false;
					
					rbTaller.Enabled=false;
					rbPersonal.Enabled=false;
					rbEspecial.Enabled=false;
					
					cmbNoCarga.Items.Clear();
					cmbNoCarga.Items.Add("");
					cmbNoCarga.Items.Add("CARGA MAS TARDE");
					cmbNoCarga.Items.Add("CARGA MAÑANA");
					
					cmbNoCarga.Text="";
				}
			}
			
			conn.conexion.Close();
		}
		
		void getTipoAutorizacion2()
		{
			String consulta = "SELECT CONVERT (DATETIME, SYSDATETIME()) HORA";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(Convert.ToDateTime(conn.leer["HORA"]).Hour>10)
				{
					lblTipoAtutorizacion.Text="FUERA DE HORARIO";
					lblTipoAtutorizacion.BackColor=Color.Red;
				}
				else
				{
					lblTipoAtutorizacion.Text="EN HORARIO";
					lblTipoAtutorizacion.BackColor=Color.MediumSpringGreen;
				}
			}
			conn.conexion.Close();
		}
		
		void getCombustible()
		{
			String consulta = "select P.ID, T.NOMBRE from TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and ESTATUS='1' and T.NOMBRE='"+cmbTipoComb.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_COMBUSTIBLE=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				ID_COMBUSTIBLE=0;
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		void CmbTipoCombKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtKms.Focus();
			}
		}
		
		void TxtKmsEnter(object sender, EventArgs e)
		{
			txtKms.SelectAll();
		}
		
		void RbTallerCheckedChanged(object sender, EventArgs e)
		{
			if(rbTaller.Checked==true)
				dtpHora.Enabled=false;
			else if(cmbNoCarga.Text=="CARGA MAS TARDE")
				dtpHora.Enabled=true;
		}
		
		#region CAMBIO DE LLAMADA
		void DgAutorizacionCellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				if(e.RowIndex!=-1 && dgAutorizacion[3,e.RowIndex].Style.BackColor.Name=="LightPink")
				{
					Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set PEDIDO=(SELECT CONVERT (TIME, SYSDATETIME())) where ID="+dgAutorizacion[0, e.RowIndex].Value.ToString();
					connM.getAbrirConexion(consul); 
					connM.comando.ExecuteNonQuery(); 
					connM.conexion.Close();	
					
					getDatosDatagrid();
				}
			}
		}
		
		void BtnLlamadaClick(object sender, EventArgs e)
		{
			if(dgAutorizacion.SelectedRows.Count>=0)
			{
				for(int x=0; x<dgAutorizacion.Rows.Count; x++)
				{
					if(dgAutorizacion.Rows[x].Selected==true && dgAutorizacion[3,x].Style.BackColor.Name=="LightPink")
					{
						Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
						String consul = "update AUTORIZACION set PEDIDO=(SELECT CONVERT (TIME, SYSDATETIME())) where ID="+dgAutorizacion[0, x].Value.ToString();
						connM.getAbrirConexion(consul);
						connM.comando.ExecuteNonQuery();
						connM.conexion.Close();
					}
				}
				getDatosDatagrid();
			}
		}
		#endregion
		
		#region EVENTOS TEXTBOX
		// ******************************UN SOLO PUNTO
		void TxtbusUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				dgAutorizacion.ClearSelection();
				
				for(int x=0; x<dgAutorizacion.Rows.Count; x++)
				{
					if(txtbusUnidad.Text==dgAutorizacion[2,x].Value.ToString())
					{
						dgAutorizacion.Rows[x].Selected = true;
						dgAutorizacion.FirstDisplayedCell = dgAutorizacion.Rows[x].Cells[1];
					}
				}
			}
			else if(txtbusUnidad.Text.Length==3)
			{
				dgAutorizacion.ClearSelection();
				
				for(int x=0; x<dgAutorizacion.Rows.Count; x++)
				{
					if(txtbusUnidad.Text==dgAutorizacion[2,x].Value.ToString())
					{
						dgAutorizacion.Rows[x].Selected = true;
						dgAutorizacion.FirstDisplayedCell = dgAutorizacion.Rows[x].Cells[1];
					}
				}
			}
		}
		
		void TxtKmsKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtKms.Text.Contains(".")==false))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void TxtNumUnidadMouseClick(object sender, MouseEventArgs e)
		{
			txtNumUnidad.SelectAll();
		}
		
		void TxtOperadorMouseClick(object sender, MouseEventArgs e)
		{
			txtOperador.SelectAll();
		}
		
		void TxtGasolineraMouseClick(object sender, MouseEventArgs e)
		{
			txtGasolinera.SelectAll();
		}
		
		#region SELECCION OPERADOR
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				if(txtOperador.Text!="")
				{
					txtNumUnidad.Focus();
				}
			}
		}
		
		void TxtOperadorLeave(object sender, EventArgs e)
		{
			Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
			Conexion_Servidor.SQL_Conexion connex1= new Conexion_Servidor.SQL_Conexion();
			
			String consulta = "SELECT * FROM OPERADOR WHERE ALIAS='"+txtOperador.Text+"'";
			connex.getAbrirConexion(consulta);
			connex.leer=connex.comando.ExecuteReader();
			if(connex.leer.Read())
			{
				ID_OPERADOR=Convert.ToInt64(connex.leer["ID"]);
				txtOperador.ForeColor=Color.SpringGreen;
				
				lblTipoEmp.Text=connex.leer["tipo_empleado"].ToString();
				lblTipoEmp.BackColor=Color.Yellow;
			}
			else
			{
				txtOperador.Text="";
				lblTipoEmp.Text="Tipo empleado";
				lblTipoEmp.BackColor=Color.White;
				ID_OPERADOR=0;
				txtOperador.ForeColor=Color.Black;
			}
			
			connex.conexion.Close();
			
			#region DEMAS DATOS
			consulta = "select V.ID, V.Numero, V.Marca from ASIGNACIONUNIDAD A, VEHICULO V, OPERADOR O where A.ID_OPERADOR=O.ID and A.ID_UNIDAD=V.ID and O.Alias='"+txtOperador.Text+"'";
			connex1.getAbrirConexion(consulta);
			connex1.leer=connex1.comando.ExecuteReader();
			if(connex1.leer.Read())
			{
				entra = true;
				
				ID_UNIDAD=Convert.ToInt64(connex1.leer["ID"]);
				txtNumUnidad.Text=connex1.leer["Numero"].ToString();
				txtNumUnidad.ForeColor=Color.SpringGreen;
				
				txtMarca.Text=connex1.leer["Marca"].ToString();
				txtMarca.BackColor=Color.Yellow;
				
				//**************************
				Conexion_Servidor.SQL_Conexion connex2= new Conexion_Servidor.SQL_Conexion();
				consulta = "select TOP 1 A.ID AID, G.ID, G.NOMBRE from AUTORIZACION A, OPERADOR O, GASOLINERA G where A.ESTATUS!=0 and A.ID_O=O.ID and A.ID_G=G.ID and Alias='"+txtOperador.Text+"' order by A.ID desc";
				connex2.getAbrirConexion(consulta);
				connex2.leer=connex2.comando.ExecuteReader();
				if(connex2.leer.Read())
				{
					ID_GASOLINERA=Convert.ToInt64(connex2.leer["ID"]);
					txtGasolinera.Text=connex2.leer["NOMBRE"].ToString().ToUpper();
				}
				else
				{
					ID_GASOLINERA=0;
					txtGasolinera.Text="";
				}
				
				connex2.conexion.Close();
				//***********************************
				
				//txtGasolinera.Focus();
			}
			else
			{
				txtNumUnidad.Text="000";
				txtMarca.Text="Marca";
				txtMarca.BackColor=Color.White;
				ID_UNIDAD=0;
				txtNumUnidad.ForeColor=Color.Red;
			}
			
			connex1.conexion.Close();
			
			if(ID_UNIDAD!=0)
			{
				getTipoRend();
			}
			
			getUltimoKm();
			
			#region GET TIPO COMBUSTIBLE
			cambioCom=true;
			bool entra2 = false;
			
			Conexion_Servidor.SQL_Conexion conna= new Conexion_Servidor.SQL_Conexion();
			
			//consulta = "select T.* from AUTORIZACION A, VEHICULO V, TIPOS_COMB T where A.ESTATUS!=0 and A.ID_V=V.ID and A.ID_COM=T.ID and V.Numero='"+txtNumUnidad.Text+"'";
			
			consulta = "select T.NOMBRE, P.ID from AUTORIZACION A, VEHICULO V, TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and A.ID_V=V.ID and A.ID_COM=P.ID and A.ESTATUS!='0' and P.ESTATUS='1' and V.Numero='"+txtNumUnidad.Text+"' order by A.FECHA_REG desc, A.ID desc";
			conna.getAbrirConexion(consulta);
			conna.leer=conna.comando.ExecuteReader();
			if(conna.leer.Read())
			{
				ID_COMBUSTIBLE=Convert.ToInt64(conna.leer["ID"]);
				cmbTipoComb.Text=conna.leer["NOMBRE"].ToString().ToUpper();
				entra2 = true;
			}
			else
			{
				entra2 = false;
				cmbTipoComb.Text="DIESEL";
			}
			
			conna.conexion.Close();
			
			/*if(entra2 == false)
			{
				consulta = "select P.ID, T.NOMBRE from TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and ESTATUS='1' and T.NOMBRE='"+cmbTipoComb.Text+"'";
				conna.getAbrirConexion(consulta);
				conna.leer=conna.comando.ExecuteReader();
				if(conna.leer.Read())
				{
					ID_COMBUSTIBLE=Convert.ToInt64(conna.leer["ID"]);
				}
				
				conna.conexion.Close();
			}*/
				
			cambioCom=false;
			#endregion
			
			#endregion
			
			validaSeleccion();
			
			entra=false;
		}
		#endregion
		
		#region SELECCION UNIDAD
		void TxtNumUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtGasolinera.Focus();
			}
		}
		
		void TxtNumUnidadLeave(object sender, EventArgs e)
		{
			Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
			Conexion_Servidor.SQL_Conexion connex1= new Conexion_Servidor.SQL_Conexion();
			Conexion_Servidor.SQL_Conexion connex2= new Conexion_Servidor.SQL_Conexion();
			
			if(txtNumUnidad.Text.Length==2)
			{
				txtNumUnidad.Text="0"+txtNumUnidad.Text;
			} 
			
			String consulta = "SELECT * FROM VEHICULO WHERE Numero='"+txtNumUnidad.Text+"'";
			connex.getAbrirConexion(consulta);
			connex.leer=connex.comando.ExecuteReader();
			if(connex.leer.Read())
			{
				ID_UNIDAD=Convert.ToInt64(connex.leer["ID"]);
				txtNumUnidad.ForeColor=Color.SpringGreen;
				txtNumUnidad.Text=connex.leer["Numero"].ToString();
				
				txtMarca.Text=connex.leer["Marca"].ToString();
				txtMarca.BackColor=Color.Yellow;
			}
			else
			{
				txtNumUnidad.Text="000";
				
				txtMarca.Text="Marca";
				txtMarca.BackColor=Color.White;
				
				ID_UNIDAD=0;
				txtNumUnidad.ForeColor=Color.Red;
			}
			
			connex.conexion.Close();
			
			getUltimoKm();
			
			if(ID_UNIDAD!=0)
			{
				getTipoRend();
			}
			
			#region GET TIPO COMBUSTIBLE
			cambioCom=true;
			bool entra = false;
			Conexion_Servidor.SQL_Conexion conna= new Conexion_Servidor.SQL_Conexion();
			//**
			consulta = "select T.NOMBRE, P.ID from AUTORIZACION A, VEHICULO V, TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and A.ID_V=V.ID and A.ID_COM=P.ID and A.ESTATUS!='0' and P.ESTATUS='1' and V.Numero='"+txtNumUnidad.Text+"' order by A.FECHA_REG desc, A.ID desc";
			conna.getAbrirConexion(consulta);
			conna.leer=conna.comando.ExecuteReader();
			if(conna.leer.Read())
			{
				ID_COMBUSTIBLE=Convert.ToInt64(conna.leer["ID"]);
				cmbTipoComb.Text=conna.leer["NOMBRE"].ToString().ToUpper();
				entra = true;
			}
			else
			{
				entra = false;
				cmbTipoComb.Text="DIESEL";
			}
			
			conna.conexion.Close();
			
			cambioCom=false;
			#endregion
			
			if(txtGasolinera.Text=="")
			{
				consulta = "select G.ID, G.NOMBRE from AUTORIZACION A, OPERADOR O, GASOLINERA G where A.ESTATUS!=0 and A.ID_O=O.ID and A.ID_G=G.ID and Alias='"+txtOperador.Text+"'";
				connex2.getAbrirConexion(consulta);
				connex2.leer=connex2.comando.ExecuteReader();
				if(connex2.leer.Read())
				{
					ID_GASOLINERA=Convert.ToInt64(connex2.leer["ID"]);
					txtGasolinera.Text=connex2.leer["NOMBRE"].ToString().ToUpper();
					txtGasolinera.ForeColor=Color.SpringGreen;
				}
				else
				{
					ID_GASOLINERA=0;
					txtGasolinera.Text="";
					txtGasolinera.ForeColor=Color.Black;
				}
				
				connex2.conexion.Close();
			}
			
			validaSeleccion();
		}
		
		void TxtMarcaKeyUp(object sender, KeyEventArgs e)
		{
			//bool ent = false;
			
			if(e.KeyCode.ToString()=="Return")
			{
				/*String consulta = "SELECT * FROM VEHICULO WHERE Marca='"+txtMarca.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_UNIDAD=Convert.ToInt64(conn.leer["ID"]);
					txtNumUnidad.Text=conn.leer["Numero"].ToString();
					txtNumUnidad.ForeColor=Color.SpringGreen;
					//ent = true;
					
					txtMarca.Text=conn.leer["Marca"].ToString();
					txtMarca.BackColor=Color.Yellow;
				}
				else
				{
					txtNumUnidad.Text="000";
					txtMarca.Text="Marca";
					txtMarca.BackColor=Color.White;
					ID_UNIDAD=0;
					txtNumUnidad.ForeColor=Color.Red;
					//ent = false;
				}
				
				conn.conexion.Close();*/
				txtGasolinera.Focus();
			}
		}
		
		void TxtMarcaLeave(object sender, EventArgs e)
		{
			if(txtNumUnidad.ForeColor.Name!="SpringGreen" && txtNumUnidad.BackColor.Name!="SpringGreen")
			{
				String consulta = "SELECT * FROM VEHICULO WHERE Marca='"+txtMarca.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_UNIDAD=Convert.ToInt64(conn.leer["ID"]);
					txtNumUnidad.Text=conn.leer["Numero"].ToString();
					txtNumUnidad.ForeColor=Color.SpringGreen;
					
					txtMarca.Text=conn.leer["Marca"].ToString();
					txtMarca.BackColor=Color.Yellow;
				}
				else
				{
					txtNumUnidad.Text="000";
					txtMarca.Text="Marca";
					txtMarca.BackColor=Color.White;
					ID_UNIDAD=0;
					txtNumUnidad.ForeColor=Color.Red;
				}
				
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region SELECCION GASOLINERA
		void TxtGasolineraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				/*String consulta = "SELECT * FROM GASOLINERA WHERE SUBNOMBRE='"+txtGasolinera.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_GASOLINERA=Convert.ToInt64(conn.leer["ID"]);
					txtGasolinera.ForeColor=Color.SpringGreen;
				}
				else
				{
					txtGasolinera.Text="";
					ID_GASOLINERA=0;
					txtGasolinera.ForeColor=Color.Black;
				}
				
				conn.conexion.Close();
				validaSeleccion();*/
				cmbTipoComb.Focus();
			}
		}
		
		void TxtGasolineraLeave(object sender, EventArgs e)
		{
			Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
			String consulta = "SELECT * FROM GASOLINERA WHERE SUBNOMBRE='"+txtGasolinera.Text+"'";
			connex.getAbrirConexion(consulta);
			connex.leer=connex.comando.ExecuteReader();
			if(connex.leer.Read())
			{
				ID_GASOLINERA=Convert.ToInt64(connex.leer["ID"]);
				txtGasolinera.ForeColor=Color.SpringGreen;
			}
			else
			{
				txtGasolinera.Text="";
				ID_GASOLINERA=0;
				txtGasolinera.ForeColor=Color.Black;
			}
			
			connex.conexion.Close();
			validaSeleccion();
		}
		#endregion
		
		void getTipoRend()
		{
			Conexion_Servidor.SQL_Conexion connXC= new Conexion_Servidor.SQL_Conexion();
			
			String consulta = "select top 1  * from AUTORIZACION where ESTATUS!=0 and ID_V in (select ID from VEHICULO where Numero='"+txtNumUnidad.Text+"')  order by fecha_base desc";
			
			connXC.getAbrirConexion(consulta);
			connXC.leer=connXC.comando.ExecuteReader();
			while(connXC.leer.Read())
			{
				if(connXC.leer["RENDIMIENTO"].ToString()=="")
				{
					cmbRendimiento.SelectedIndex=0;
				}
				else
				{
					cmbRendimiento.Text=connXC.leer["RENDIMIENTO"].ToString();
				}
			}
			
			connXC.conexion.Close();
		}
		
		void getUltimoKm()
		{
			Conexion_Servidor.SQL_Conexion connXC= new Conexion_Servidor.SQL_Conexion();
			
			int cambio=0;
			//String consulta = "select TOP 2 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V in (select ID from VEHICULO where Numero='') order by A.FECHA_BASE desc";
			String consulta = "select A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V = (select ID from VEHICULO where Numero='"+txtNumUnidad.Text+"') and FECHA_BASE<=(SELECT CONVERT (DATETIME, SYSDATETIME())) order by A.FECHA_REG desc, A.NUMERO desc";
			
			connXC.getAbrirConexion(consulta);
			connXC.leer=connXC.comando.ExecuteReader();
			while(connXC.leer.Read())
			{
				if(cambio==0)
				{
					lblKmUltimo.Text=((connXC.leer["KM"].ToString()=="")?"0.00":connXC.leer["KM"].ToString());
					cambio++;
				}
			}
			
			connXC.conexion.Close();
			
			consulta = "select TOP 1 * from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.FECHA_BASE < (SELECT CONVERT (DATE, SYSDATETIME())) and A.ID_V="+ID_UNIDAD+" order by A.FECHA_BASE desc";
			
			connXC.getAbrirConexion(consulta);
			connXC.leer=connXC.comando.ExecuteReader();
			if(connXC.leer.Read())
			{
				if(connXC.leer["LITROS"].ToString()=="")
				{
					lblFalta.Visible=true;
				}
				else
				{
					lblFalta.Visible=false;
				}
			}
			
			connXC.conexion.Close();
			
			if(cambio!=0)
			{
				lblKmRecorrido.Text=(Convert.ToDouble(txtKms.Text)-Convert.ToDouble(lblKmUltimo.Text)).ToString();
				
				if(Convert.ToDouble(lblKmRecorrido.Text)>Convert.ToDouble(lblKmPermitido.Text))
				{
					lblAprobacion.BackColor=Color.Red;
					lblAprobacion.Text="CARGAR";
				}
				else
				{
					lblAprobacion.BackColor=Color.MediumSpringGreen;
					lblAprobacion.Text="PERMISO";
				}
			}
		}
		
		bool buscaValidacion()
		{
			bool respuesta=true;
			
			Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
			String consulta = "select * from AUTORIZACION where ESTATUS!=0 and ID_V in (select ID from VEHICULO where Numero='"+txtNumUnidad.Text+"') and FECHA_BASE=(SELECT CONVERT (DATE, SYSDATETIME()))";
			connex.getAbrirConexion(consulta);
			connex.leer=connex.comando.ExecuteReader();
			if(connex.leer.Read())
			{
				respuesta=false;
			}
			
			connex.conexion.Close();
			
			return respuesta;
		}	
		#endregion
		
		#region VALIDA SELECCION
		void validaSeleccion()
		{
			if(cmbNoCarga.Text!="")
			{
				if(ID_OPERADOR!=0)
				{
					txtOperador.BackColor=Color.SpringGreen;
					txtOperador.ForeColor=Color.Black;
					
					
					if(ID_UNIDAD!=0)
					{
						txtNumUnidad.BackColor=Color.SpringGreen;
						txtNumUnidad.ForeColor=Color.Black;
					}
					
					if(ID_GASOLINERA!=0)
					{
						txtGasolinera.BackColor=Color.SpringGreen;
						txtGasolinera.ForeColor=Color.Black;
					}
					
					//cmdGenera.Enabled=true;
					//cmdGenera.Focus();
					
					/*txtKms.Focus();
					txtKms.SelectAll();*/
				}
				else
				{
					cmdGenera.Enabled=false;
					//txtGasolinera.BackColor=Color.White;
					txtOperador.BackColor=Color.White;
					txtNumUnidad.BackColor=Color.Silver;
				}
			}
			else
			{
				if(ID_OPERADOR!=0 && ID_GASOLINERA!=0 && ID_UNIDAD!=0)
				{
					//cmdGenera.Enabled=true;
					txtGasolinera.BackColor=Color.SpringGreen;
					txtOperador.BackColor=Color.SpringGreen;
					txtNumUnidad.BackColor=Color.SpringGreen;
					
					txtGasolinera.ForeColor=Color.Black;
					txtOperador.ForeColor=Color.Black;
					txtNumUnidad.ForeColor=Color.Black;
					
					//cmdGenera.Focus();
					/*txtKms.Focus();
					txtKms.SelectAll();*/
				}
				else
				{
					cmdGenera.Enabled=false;
					txtGasolinera.BackColor=Color.White;
					txtOperador.BackColor=Color.White;
					txtNumUnidad.BackColor=Color.Silver;
				}
			}
		}
		#endregion
		
		#region GET VALIDACION
		void CmdGeneraClick(object sender, EventArgs e)
		{
			//MessageBox.Show(getValidacion());
			if(ID_OPERADOR!=0)// || (ID_OPERADOR!=0 && ID_UNIDAD!=0))
			{
				if(revision()!="PASA")
				{
					DialogResult rs2 = MessageBox.Show("EL KILOMETRAJE ES "+revision()+". \n ¿Deséa continuar con el guardado?", "ERROR EN EL KILOMETRAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
					if (DialogResult.Yes==rs2)
					{
						guardar();
					}
				}
				else
				{
					guardar();
				}
			}
		}
		
		void guardar()
		{
			getTipoAutorizacion2();
			lblAutorizacion.Text=getValidacion();
			getDatosDatagrid();
			
			txtKms.Text="0";
			limpia();
			getCombustible();
			
			getHistorialAut();
			//getReporte();
			getDatosDGestatus();
			getFaltantes();
			getTipoAutorizacion();
		}
		
		String revision()
		{
			string respuesta = "PASA";
			
			if(Convert.ToDouble(lblKmRecorrido.Text)<0)
			{
				respuesta="MENOR";
			}
			else if(Convert.ToDouble(lblKmRecorrido.Text)>factorMaximoKm)
			{
				respuesta="MAYOR";
			}
				
			return respuesta;
		}
		#endregion
				
		#region LIMPIA DATOS
		void limpia()
		{
			cmdGenera.Enabled=false;
			lblFalta.Visible=false;
			
			txtKms.Enabled=true;
			txtGasolinera.Enabled=true;
			cmbTipoComb.Enabled=true;
			cmbRendimiento.Enabled=true;
			cmbNoCarga.SelectedIndex=0;
			
			txtGasolinera.Text="";
			txtNumUnidad.Text="000";
			
			txtMarca.Text="Marca";
			txtMarca.BackColor=Color.White;
			
			lblTipoEmp.Text="Tipo empleado";
			lblTipoEmp.BackColor=Color.White;
			txtOperador.Text="";
			txtKms.Text="0";
			
			txtGasolinera.ForeColor=Color.Black;
			txtOperador.ForeColor=Color.Black;
			txtNumUnidad.ForeColor=Color.Red;
			
			txtGasolinera.BackColor=Color.White;
			txtOperador.BackColor=Color.White;
			txtNumUnidad.BackColor=Color.Silver;
			
			ID_GASOLINERA=0;
			ID_OPERADOR=0;
			ID_UNIDAD=0;
			
			lblKmUltimo.Text="0.00";
			lblKmRecorrido.Text="0.00";
			
			txtComent.Text="";	
			txtOperador.Focus();
			
			cbGasExterna.Checked=false;
			lblKmUltimo.Text="";
		}
		#endregion
		
		#region NUMERO DE VALIDACION
		String getValidacion2(int cantidad)
		{
			String dato="";
			
			//String consulta = "SELECT MAX(NUMERO) NUMERO FROM AUTORIZACION WHERE FECHA_BASE='"+dtpInicioNum.Value.ToString("dd/MM/yyyy")+"'";
			String consulta = "SELECT MAX(NUMERO) NUMERO FROM AUTORIZACION WHERE FECHA_REG=(select DATEADD (day, "+cantidad+", (SELECT CONVERT (DATE, SYSDATETIME()))))";
			Int64 numero = 0;
			String numReg = "";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				try
				{
					numero=Convert.ToInt64(conn.leer["NUMERO"]);
					numero++;
				}
				catch (Exception)
				{
					
				}
			}
			conn.conexion.Close();
			
			if(numero==0)
			{
				numReg="01";
			}
			else if(numero.ToString().Length==1)
			{
				numReg="0"+numero;
			}
			else
			{
				numReg=numero.ToString();
			}
			
			string FECHA = "";
			consulta ="select DATEADD (day, "+cantidad+", (SELECT CONVERT (DATE, SYSDATETIME()))) as FECHA";
								
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				FECHA = conn.leer["FECHA"].ToString();
			}
			conn.conexion.Close();
			
			consulta ="execute SP_AUTORIZA2 "+refPrincipal.idUsuario+", "+ID_UNIDAD+", "+ID_OPERADOR+", "+ID_GASOLINERA+", "+ID_COMBUSTIBLE+", "+txtKms.Text+", '"+numReg+"', '"+txtComent.Text+"', NULL, '"+cmbRendimiento.Text+"', '1', '"+FECHA+"'";
								
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
			
			if(Convert.ToDateTime(FECHA).ToString("MMM")=="may")
			{
				dato=Convert.ToDateTime(FECHA).ToString("yyyy").Substring(3,1)+"Y"+Convert.ToDateTime(FECHA).ToString("dd")+numReg;
			}
			else if(Convert.ToDateTime(FECHA).ToString("MMM")=="jul")
			{
				dato=Convert.ToDateTime(FECHA).ToString("yyyy").Substring(3,1)+"L"+Convert.ToDateTime(FECHA).ToString("dd")+numReg;
			}
			else if(Convert.ToDateTime(FECHA).ToString("MMM")=="ago")
			{
				dato=Convert.ToDateTime(FECHA).ToString("yyyy").Substring(3,1)+"G"+Convert.ToDateTime(FECHA).ToString("dd")+numReg;
			}
			else
			{
				dato=Convert.ToDateTime(FECHA).ToString("yyyy").Substring(3,1)+Convert.ToDateTime(FECHA).ToString("MMMMM").Substring(0,1).ToUpper()+Convert.ToDateTime(FECHA).ToString("dd")+numReg;
			}
			
			return dato;
		}
		
		String getValidacion()
		{
			String dato="";
			String consulta = "";
			
			if(cbGasExterna.Checked==true)
				consulta = "SELECT MAX(NUMERO) NUMERO FROM AUTORIZACION WHERE FECHA_BASE='"+dtpInicioNum.Value.ToString("dd/MM/yyyy")+"'";
			else
				consulta = "SELECT MAX(NUMERO) NUMERO FROM AUTORIZACION WHERE FECHA_REG=(SELECT CONVERT (DATE, SYSDATETIME()))";
			
			
			Int64 numero = 0;
			String numReg = "";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				try
				{
					numero=Convert.ToInt64(conn.leer["NUMERO"]);
					numero++;
				}
				catch (Exception)
				{
					
				}
			}
			conn.conexion.Close();
			
			// +++++++++++++++++++ registro ++++++++++++++++++++++++
			if(numero==0)
			{
				numReg="01";
			}
			else if(numero.ToString().Length==1)
			{
				numReg="0"+numero;
			}
			else
			{
				numReg=numero.ToString();
			}
			/*else if(numero.ToString().Length==2)
			{
				numReg="0"+numero;
			}*/
			
			if(cmbNoCarga.Text=="")
			{
				if(cbGasExterna.Checked==false)
					consulta ="execute SP_AUTORIZA "+refPrincipal.idUsuario+", "+ID_UNIDAD+", "+ID_OPERADOR+", "+ID_GASOLINERA+", "+ID_COMBUSTIBLE+", "+txtKms.Text+", '"+numReg+"', '"+txtComent.Text+"', NULL, '"+cmbRendimiento.Text+"', '1', null, null, '"+lblTipoAtutorizacion.Text+"'";
				else
					consulta ="execute SP_AUTORIZA_GAS_EXTERNA "+refPrincipal.idUsuario+", "+ID_UNIDAD+", "+ID_OPERADOR+", "+ID_GASOLINERA+", "+ID_COMBUSTIBLE+", "+txtKms.Text+", '"+numReg+"', '"+txtComent.Text+"', NULL, '"+cmbRendimiento.Text+"', '1', null, null, 'DEFASADA', '"+dtpInicioNum.Value.ToString("dd/MM/yyyy")+"', '"+dtpHoraNum.Value.ToString("HH:mm")+"'";
			}
			else
			{
				if(ID_UNIDAD!=0)
				{
					consulta ="execute SP_AUTORIZA "+refPrincipal.idUsuario+", "+ID_UNIDAD+", "+ID_OPERADOR+", null, null, "+txtKms.Text+", '"+numReg+"', '"+txtComent.Text+"', '"+cmbNoCarga.Text+"', NULL, '2', 	"+((cmbNoCarga.Text=="CARGA MAS TARDE" && rbTaller.Checked==false)?"'"+dtpHora.Value.ToString("HH")+":00'":"NULL")+", 	'"+((rbTaller.Checked==true)?"TALLER":((rbEspecial.Checked==true)?"ESPECIAL":((rbContesta.Checked==true)?"NO CONTESTÓ":"PERSONAL")))+"', '"+lblTipoAtutorizacion.Text+"'";
				}
				else
				{
					consulta ="execute SP_AUTORIZA "+refPrincipal.idUsuario+", null, "+ID_OPERADOR+", null, null, "+txtKms.Text+", '"+numReg+"', '"+txtComent.Text+"', '"+cmbNoCarga.Text+"', NULL, '2', 			"+((cmbNoCarga.Text=="CARGA MAS TARDE" && rbTaller.Checked==false)?"'"+dtpHora.Value.ToString("HH")+":00'":"NULL")+", 	'"+((rbTaller.Checked==true)?"TALLER":((rbEspecial.Checked==true)?"ESPECIAL":((rbContesta.Checked==true)?"NO CONTESTÓ":"PERSONAL")))+"', '"+lblTipoAtutorizacion.Text+"'";
				}
			}
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
			
			// ++++++++++++++++++++++++++++++++++++++++++++++++++++
			
			if(dtpInicioNum.Value.ToString("MMM")=="may")
			{
				dato=dtpInicioNum.Value.ToString("yyyy").Substring(3,1)+"Y"+dtpInicioNum.Value.ToString("dd")+numReg;
			}
			else if(dtpInicioNum.Value.ToString("MMM")=="jul")
			{
				dato=dtpInicioNum.Value.ToString("yyyy").Substring(3,1)+"L"+dtpInicioNum.Value.ToString("dd")+numReg;
			}
			else if(dtpInicioNum.Value.ToString("MMM")=="ago")
			{
				dato=dtpInicioNum.Value.ToString("yyyy").Substring(3,1)+"G"+dtpInicioNum.Value.ToString("dd")+numReg;
			}
			else
			{
				dato=dtpInicioNum.Value.ToString("yyyy").Substring(3,1)+dtpInicioNum.Value.ToString("MMMMM").Substring(0,1).ToUpper()+dtpInicioNum.Value.ToString("dd")+numReg;
			}
			
			return dato;
						
			/*String consulta = "EXECUTE SP_AUTORIZACION_2 "+refPrincipal.idUsuario+", "+ID_UNIDAD+", "+ID_OPERADOR+", "+ID_GASOLINERA+", "+ID_COMBUSTIBLE+", "+txtKms.Text;
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				lblAutorizacion.Text=conn.leer["NUM"].ToString();
			}
			conn.conexion.Close();*/
		}
		
		public String getNumeroValidacion(Int64 numero, DateTime fecha)
		{
			String dato="";
			
			String numReg = "";
			
			
			// +++++++++++++++++++ registro ++++++++++++++++++++++++
			if(numero==0)
			{
				numReg="01";
			}
			else if(numero.ToString().Length==1)
			{
				numReg="0"+numero;
			}
			else
			{
				numReg=numero.ToString();
			}

			// ++++++++++++++++++++++++++++++++++++++++++++++++++++
			
			if(fecha.ToString("MMM")=="may")
			{
				dato=fecha.ToString("yyyy").Substring(3,1)+"Y"+fecha.ToString("dd")+numReg;
			}
			else if(fecha.ToString("MMM")=="jul")
			{
				dato=fecha.ToString("yyyy").Substring(3,1)+"L"+fecha.ToString("dd")+numReg;
			}
			else if(fecha.ToString("MMM")=="ago")
			{
				dato=fecha.ToString("yyyy").Substring(3,1)+"G"+fecha.ToString("dd")+numReg;
			}
			else
			{
				dato=fecha.ToString("yyyy").Substring(3,1)+fecha.ToString("MMMMM").Substring(0,1).ToUpper()+fecha.ToString("dd")+numReg;
			}
			
			return dato;
		}
		#endregion
		
		#region MUESTRA DATAGRID DE AUTORIZACIONES
		void getDatosDatagrid()
		{
			dgAutorizacion.Rows.Clear();
			cmdCancelar.Enabled=false;
			
			String consulta = "";
			
			if(rbTDatos.Checked==false && cbExternas.Checked==false)
				consulta = "select * from AUTORIZACION WHERE ESTATUS='1' and FECHA_REG BETWEEN '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' and ID_O!=0";
			else if(rbTDatos.Checked==false && cbExternas.Checked==true)
				consulta = "select * from AUTORIZACION WHERE ESTATUS='1' and FECHA_REG BETWEEN '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpFin.Value.ToString("dd/MM/yyyy")+"'";
			else if(rbTDatos.Checked==false && cbExternas.Checked==false)
				consulta = "select * from AUTORIZACION WHERE ESTATUS!='0' and FECHA_REG BETWEEN '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' and ID_V=0";
			else if(rbTDatos.Checked==true && cbExternas.Checked==false)
				consulta = "select * from AUTORIZACION WHERE ESTATUS!='0' and FECHA_REG BETWEEN '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpFin.Value.ToString("dd/MM/yyyy")+"' and ID_O!=0";
			else
				consulta = "select * from AUTORIZACION WHERE ESTATUS!='0' and FECHA_REG BETWEEN '"+dtpInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpFin.Value.ToString("dd/MM/yyyy")+"'";
				
		
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgAutorizacion.Rows.Add(conn.leer["ID"].ToString(), getNumeroValidacion(Convert.ToInt64(conn.leer["NUMERO"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), "", conn.leer["ID_G"].ToString(), Convert.ToDateTime(conn.leer["FECHA_REG"]), ((conn.leer["HORA_REG"].ToString()!="")?conn.leer["HORA_REG"].ToString():"00:00").Substring(0,8), "", "", "",Convert.ToInt64(conn.leer["KM"]), ((conn.leer["PERMISO"].ToString()!="")?conn.leer["PERMISO"].ToString():"N/A"), ((conn.leer["RENDIMIENTO"].ToString()!="")?conn.leer["RENDIMIENTO"].ToString():"N/A"), conn.leer["ESTATUS"].ToString(), conn.leer["COMENTARIO"].ToString(), conn.leer["PEDIDO"].ToString());
				lblAutorizacion.Text=getNumeroValidacion(Convert.ToInt64(conn.leer["NUMERO"]), Convert.ToDateTime(conn.leer["FECHA_BASE"]));
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgAutorizacion.Rows.Count; x++)
			{
				if(dgAutorizacion[5,x].Value.ToString()!="")
				{
					try
					{
						Convert.ToInt64(dgAutorizacion[5,x].Value.ToString());
						consulta = "select G.*, C.NUMERO from GASOLINERA G, CONTACTO_GASOLINERA C where G.ID=C.ID_G and G.ID='"+dgAutorizacion[5,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgAutorizacion[5,x].Value=conn.leer["NOMBRE"].ToString();
							dgAutorizacion[5,x].ToolTipText = conn.leer["NUMERO"].ToString();
						}
						conn.conexion.Close();
					}
					catch
					{
						
					}
				}
				
				if(dgAutorizacion[3,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgAutorizacion[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacion[3,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacion[3,x].Value.ToString()!="")
				{
					consulta = "SELECT T.Numero FROM TELEFONOCHOFER T, OPERADOR O WHERE T.ID_Chofer=O.ID AND T.Tipo='LAR' AND O.Alias = '"+dgAutorizacion[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacion[4,x].Value=conn.leer["Numero"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacion[2,x].Value.ToString()!="")
				{
					consulta = "select Numero from VEHICULO where ID='"+dgAutorizacion[2,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacion[2,x].Value=conn.leer["Numero"].ToString();
					}
					conn.conexion.Close();
				}
			}
			dgAutorizacion.ClearSelection();
			
			
			inicio2 = false;
			
			coloresValidacion();
		}
		#endregion
		
		#region EXTERNAS
		void CmdExternasClick(object sender, EventArgs e)
		{
			new FormEspExternas(this).ShowDialog();
			
			/*NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
			
			String sMacAddress = string.Empty;
			foreach (NetworkInterface adapter in nics)
			{
			    if (sMacAddress == String.Empty)// only return MAC Address from first card  
			    {
			        IPInterfaceProperties properties = adapter.GetIPProperties();
			        sMacAddress = adapter.GetPhysicalAddress().ToString();
			    }
			} 
			
			MessageBox.Show(sMacAddress);*/
		}
		
		public void generaExternas()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			++i;
			ExcelApp.Cells[i,  1] = "FOLIOS DEL "+DateTime.Now.ToString("dddd dd")+" de "+DateTime.Now.ToString("MMMM")+" del "+DateTime.Now.ToString("yyyy");
			++i;
			ExcelApp.Cells[i,  1] = "NUMERO";
			ExcelApp.Cells[i,  2] = "UNIDAD";
			ExcelApp.Cells[i,  3] = "OPERADOR";
			ExcelApp.Cells[i,  4] = "GASOLINERA";
			ExcelApp.Cells[i,  5] = "KILOMETRAJE";
			ExcelApp.Cells[i,  6] = "HORA";
			ExcelApp.Cells[i,  7] = "LITROS";
			ExcelApp.Cells[i,  8] = "AUTORIZA";
			
			for(int x=0; x<10; x++)
			{
				++i;
				/*try{*/ExcelApp.Cells[i,  1] = getValidacion();	/*}catch (Exception){ExcelApp.Cells[i,  1] = "";}*/
				
			}
			
			++i;
			++i;
			ExcelApp.Cells[i,  1] = "FOLIOS DEL "+DateTime.Now.AddDays(1).ToString("dddd dd")+" de "+DateTime.Now.AddDays(1).ToString("MMMM")+" del "+DateTime.Now.AddDays(1).ToString("yyyy");
			
			for(int x=0; x<10; x++)
			{
				++i;
				/*try{*/ExcelApp.Cells[i,  1] = getValidacion2(1);	/*}catch (Exception){ExcelApp.Cells[i,  1] = "";}*/
				
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "EXTERNAS "+DateTime.Now.ToString("dd-MM-yyyy");
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
			
			
			getDatosDatagrid();
			limpia();
		}
		
		public void generaExternas2(int cant)
		{
			limpia();
			
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
			int numero = 10;
			
			for(int y=0; y<=cant; y++)
			{
				ExcelApp.Cells[i,  1] = "FOLIOS DEL "+DateTime.Now.AddDays(y).ToString("dddd dd")+" de "+DateTime.Now.ToString("MMMM")+" del "+DateTime.Now.ToString("yyyy");
				++i;
				ExcelApp.Cells[i,  1] = "NUMERO";
				ExcelApp.Cells[i,  2] = "UNIDAD";
				ExcelApp.Cells[i,  3] = "OPERADOR";
				ExcelApp.Cells[i,  4] = "GASOLINERA";
				ExcelApp.Cells[i,  5] = "FECHA";
				ExcelApp.Cells[i,  6] = "HORA";
				
				if(y==0 || y==cant)
					numero=10;
				else
					numero=15;
				
				for(int x=0; x<numero; x++)
				{
					++i;
					ExcelApp.Cells[i,  1] = getValidacion2(y);
				}
				++i;
				++i;
			}
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "EXTERNAS "+DateTime.Now.ToString("dd-MM-yyyy");
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
			
			
			getDatosDatagrid();
			limpia();
		}
		#endregion
		
		#region TIPO DE FILTROS
		void CbExternasCheckedChanged(object sender, EventArgs e)
		{
			getDatosDatagrid();
			getDatosDGestatus();
		}
		
		public void coloresValidacion()
		{
			for(int x=0; x<dgAutorizacion.Rows.Count; x++)
			{
				if(dgAutorizacion[2,x].Value.ToString()=="0")
				{
					for(int y=0; y<dgAutorizacion.Columns.Count; y++)
					{
						dgAutorizacion[y,x].Style.BackColor=Color.Yellow;
					}
				}
				else if(dgAutorizacion[12,x].Value.ToString()!="N/A")
				{
					//dgAutorizacion[11,x].Style.BackColor=Color.MediumSpringGreen;
				}
				else if(dgAutorizacion[14,x].Value.ToString()=="2")
				{
					for(int y=0; y<dgAutorizacion.Columns.Count; y++)
					{
						dgAutorizacion[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
				else
				{
					for(int y=0; y<dgAutorizacion.Columns.Count; y++)
					{
						dgAutorizacion[y,x].Style.BackColor=Color.White;
					}
				}
				
				if(dgAutorizacion[16,x].Style.BackColor.Name=="White" && dgAutorizacion[16,x].Value.ToString()=="" && dgAutorizacion[12,x].Value.ToString()=="N/A")
				{
					for(int y=0; y<dgAutorizacion.Columns.Count; y++)
					{
						dgAutorizacion[y,x].Style.BackColor=Color.LightPink;
					}
				}
			}
		}
		
		void DgAutorizacionDoubleClick(object sender, EventArgs e)
		{
			if(dgAutorizacion[0,dgAutorizacion.CurrentRow.Index].Style.BackColor.Name=="Yellow")
			{
				new FormExternos(this).ShowDialog();
			}
			else if(dgAutorizacion[12,dgAutorizacion.CurrentRow.Index].Value.ToString()=="N/A") //if(dgAutorizacion[0,dgAutorizacion.CurrentRow.Index].Style.BackColor.Name!="MediumSpringGreen")
			{
				getFactor();
				
				cambioAnular=false;
				Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
				String consul = "update AUTORIZACION set PEDIDO=(SELECT CONVERT (TIME, SYSDATETIME())) where ID="+dgAutorizacion[0,dgAutorizacion.CurrentRow.Index].Value.ToString();
				connM.getAbrirConexion(consul); 
				connM.comando.ExecuteNonQuery(); 
				connM.conexion.Close();	
				
				getTodo(dgAutorizacion[2,dgAutorizacion.CurrentRow.Index].Value.ToString(), Convert.ToInt64(dgAutorizacion[0,dgAutorizacion.CurrentRow.Index].Value));
				calculaKmET();
				gbCargas.Enabled=false;
			}
		}
		
		
		public void getTodo(String numero_unidad, Int64 ID_AUT)
		{
			txtOperadorValidacion.Text="";
			if(existe2(numero_unidad)==true)
			{
				txtUnidadValidacion.BackColor=Color.MediumSpringGreen;
				txtOperadorValidacion.BackColor=Color.MediumSpringGreen;
				gbMovimientos.Enabled=true;
				txtUnidadValidacion.Text=numero_unidad;
				tcPrincipalComb.SelectedIndex=1;
			}
			else
			{
				txtUnidadValidacion.BackColor=Color.White;
				txtOperadorValidacion.BackColor=Color.White;
				txtUnidadValidacion.Text=dgAutorizacion[2,dgAutorizacion.CurrentRow.Index].Value.ToString();
				gbMovimientos.Enabled=false;
				lblRendimiento.Text="0";
			}
			
			//getAutorizacionesValidacionAlt(Convert.ToInt64(dgAutorizacion[0,dgAutorizacion.CurrentRow.Index].Value));
			getAutorizacionesValidacionAlt(ID_AUT);
			getOperador();
			getViajesValidacion();
			
			/*try
			{*/
				getValidado(Convert.ToInt64(dgAutorizacionValida[11,0].Value), 1);
				cmdCalcularKm.Enabled=true;
				getRendimiento();
				dgAutorizacionValida.SelectAll();
				
				//dgAutorizacionValida.CurrentCell = dgAutorizacionValida[8,0];
				dgAutorizacionValida[8,0].Selected=true;
				//dgAutorizacionValida.EditMode = edit
			/*}
			catch(Exception)
			{
				dgValidado.Rows.Clear();
				MessageBox.Show("La unidad seleccionada no tiene registro..");
				conn.conexion.Close();
				cmdCalcularKm.Enabled=false;
			}*/
			
			cambioAnular = true;
		}
		#endregion
		
		#region EVENTOS CAMBIOS DE FECHAS
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			dtpFin.Value=dtpInicio.Value;
		}
		
		void DtpInicioNumValueChanged(object sender, EventArgs e)
		{
			dtpInicio.Value=dtpInicioNum.Value;
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			getDatosDatagrid();
		}
		#endregion
		
		#region EVENTOS TIPO DE COMBUSTIBLE
		void iniciaCombo()
		{
			cmbTipoComb.Items.Clear();
			String consulta = "select * from TIPOS_COMB";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				cmbTipoComb.Items.Add(conn.leer["NOMBRE"].ToString());
			}
			conn.conexion.Close();
			
			cmbTipoComb.SelectedIndex=0;
		}
		
		void CmbTipoCombSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cambioCom==false)
			{
				String consulta = "select P.ID, T.NOMBRE from TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and ESTATUS='1' and T.NOMBRE='"+cmbTipoComb.Text+"'";
				conn4.getAbrirConexion(consulta);
				conn4.leer=conn4.comando.ExecuteReader();
				if(conn4.leer.Read())
				{
					ID_COMBUSTIBLE=Convert.ToInt64(conn4.leer["ID"]);
				}
				else
				{
					ID_COMBUSTIBLE=0;
				}
				
				conn4.conexion.Close();
			}
		}
		#endregion
		
		#region SELECCION DE BOTON GENERA
		void CmdGeneraEnter(object sender, EventArgs e)
		{
			cmdGenera.BackColor=Color.SpringGreen;
		}
		
		void CmdGeneraLeave(object sender, EventArgs e)
		{
			cmdGenera.BackColor=Color.Transparent;
		}
		#endregion
		
		#region CAMBIO 
		void DgAutorizacionCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==6 && inicio2==false)// VALIDO HORA 
			{
				try
				{
					Convert.ToDateTime(dgAutorizacion[6,e.RowIndex].Value);
				}
				catch(Exception)
				{
					if(dgAutorizacion[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper()=="X")
					{
						dgAutorizacion[e.ColumnIndex, e.RowIndex].Value=DateTime.Now.ToString("HH:mm:ss");
					}
					else
					{
						String consulta = "select * from AUTORIZACION where ESTATUS!=0 and ID="+dgAutorizacion[0, e.RowIndex].Value.ToString();
			
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgAutorizacion[e.ColumnIndex, e.RowIndex].Value=conn.leer["HORA_AUTORIZACION"].ToString();
						}
						conn.conexion.Close();
					}
				}
				
				Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
				String consul = "update AUTORIZACION set HORA_AUTORIZACION='"+dgAutorizacion[e.ColumnIndex, e.RowIndex].Value.ToString()+"' where ID="+dgAutorizacion[0, e.RowIndex].Value.ToString();
				connM.getAbrirConexion(consul); 
				connM.comando.ExecuteNonQuery(); 
				connM.conexion.Close();	
			}
		}
		#endregion
		
		#region CANCELAR AUTORIZACION
		void CmdCancelarClick(object sender, EventArgs e)
		{
			if(dgAutorizacion.Rows.Count>0 && dgAutorizacion.SelectedRows.Count==1)
			{
				cancelaAutorizacion();
				
				string consulta = "INSERT INTO AUDITORIA_AUTORIZACION VALUES ("+dgAutorizacion[0, dgAutorizacion.CurrentRow.Index].Value.ToString()+", 'CANCELACIÓN', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATETIME, SYSDATETIME())))";
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
		}
		
		
		void cancelaAutorizacion()
		{
			if(dgAutorizacion.SelectedRows.Count==1 && dgAutorizacion.CurrentRow.Index!=-1)
			{
				String consulta ="update AUTORIZACION set ESTATUS='0' where ID="+dgAutorizacion[0,dgAutorizacion.CurrentRow.Index].Value.ToString();
									
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				dgAutorizacion.Rows.RemoveAt(dgAutorizacion.CurrentRow.Index);
				dgAutorizacion.ClearSelection();
				cmdCancelar.Enabled=false;
			}
			else
			{
				MessageBox.Show("Selecione un registro");
			}
		}
		
		void DgAutorizacionCellClick(object sender, DataGridViewCellEventArgs e)
		{
			cmdCancelar.Enabled=true;
			
			if(dgAutorizacion.Rows.Count>0 && e.RowIndex>-1)
			{
				/*if(e.ColumnIndex==15)
				{
					if(dgAutorizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "0" || dgAutorizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "False")
					{
						dgAutorizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;	
						dgAutorizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
						
						//MessageBox.Show("TRUE");
					}
					else
					{
						dgAutorizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;	
						dgAutorizacion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
						
						//MessageBox.Show("FALSE");
					}
				}*/
			}
		}
		#endregion
		
		void CmdIniciaClick(object sender, EventArgs e)
		{
			lblAutorizacion.Text="0";
			new FormInicializaComb().ShowDialog();
		}
				
		void SbSDatosCheckedChanged(object sender, EventArgs e)
		{
			getDatosDatagrid();
			getDatosDGestatus();
		}
		
		#region VALIDA INGRESO DE KILOMETRAJE
		void TxtKmsKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				if(txtKms.Text!="")
				{
					if(Convert.ToDouble(txtKms.Text)>0)
					{
						cmdGenera.Enabled=true;
						cmdGenera.Focus();
					}
					else
					{
						cmdGenera.Enabled=false;
					}
				}
				else
				{			
					cmdGenera.Enabled=false;
					
					txtKms.Text="0";
				}
			}
			
			
			if(txtKms.Text!="" && lblKmUltimo.Text!="" && lblKmUltimo.Text!="0.00")
			{
				lblKmRecorrido.Text=(Convert.ToDouble(txtKms.Text)-Convert.ToDouble(lblKmUltimo.Text)).ToString();
				
				if(Convert.ToDouble(lblKmRecorrido.Text)>Convert.ToDouble(lblKmPermitido.Text))
				{
					lblAprobacion.BackColor=Color.Red;
					lblAprobacion.Text="CARGAR";
				}
				else
				{
					lblAprobacion.BackColor=Color.MediumSpringGreen;
					lblAprobacion.Text="PERMISO";
				}
			}
		}
		
		void TxtKmsLeave(object sender, EventArgs e)
		{
			if(txtKms.Text!="")
			{
				if(Convert.ToDouble(txtKms.Text)>0)
				{
					cmdGenera.Enabled=true;	
				}
				else
				{
					cmdGenera.Enabled=false;
				}
			}
			else
			{
				txtKms.Text="0";
				cmdGenera.Enabled=false;	
			}
		}
		#endregion
		
		#region NO CARGA
		void CmbNoCargaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbNoCarga.Text!="")
			{
				//txtKms.Text="0";
				txtKms.Enabled=true;
				txtGasolinera.Enabled=false;
				cmbTipoComb.Enabled=false;
				cmbRendimiento.Enabled=false;
				
				txtNumUnidad.Enabled=true;
				txtOperador.Enabled=true;
				//txtMarca.Enabled=true;
				txtComent.Enabled=true;
				
				cmdGenera.Enabled=true;
				
				txtOperador.Focus();
				txtOperador.SelectAll();
				
				/**********/
				rbEspecial.Enabled=true;
				rbTaller.Enabled=true;
				rbPersonal.Enabled=true;
				
				if(cmbNoCarga.Text=="LLAMADA")
				{
					rbContesta.Enabled=true;
				}
				else
				{
					rbContesta.Enabled=false;
				}
				
				if(cmbNoCarga.Text=="CARGA MAS TARDE")
				{
					dtpHora.Enabled=true;
				}
				else
				{
					dtpHora.Enabled=false;
				}
				/**********/
			}
			else
			{
				txtKms.Enabled=true;
				
				if(cbGasExterna.Checked==false)
					txtGasolinera.Enabled=true;
				
				cmbTipoComb.Enabled=true;
				cmbRendimiento.Enabled=true;
				
				cmdGenera.Enabled=false;
				rbContesta.Enabled=false;
				
				txtKms.Focus();
				txtKms.SelectAll();
				
				/**********/
				/*if(lblTipoAtutorizacion.Text=="EN TIEMPO")
				{*/
				rbEspecial.Enabled=false;
				rbTaller.Enabled=false;
				rbPersonal.Enabled=false;
				//}
				dtpHora.Enabled=false;
				/**********/
			}
		}
		#endregion
		
		#region EXPORTA EXCEL
		void CmdExcelClick(object sender, EventArgs e)
		{
			ExportaExcel();
		}
		
		void ExportaExcel()
		{
			if(dgAutorizacion.Rows.Count>0)
			{
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
					
				int i = 1;
			
				++i;
				ExcelApp.Cells[i,  1] 	= "FOLIO";
				ExcelApp.Cells[i,  2] 	= "UNIDAD";
				ExcelApp.Cells[i,  3] 	= "OPERADOR";
				ExcelApp.Cells[i,  4] 	= "GASOLINERA";
				ExcelApp.Cells[i,  5] 	= "FECHA";
				ExcelApp.Cells[i,  6] 	= "HORA";
				ExcelApp.Cells[i,  7] 	= "KMS";
				ExcelApp.Cells[i,  8] 	= "SIN CARGA";
				ExcelApp.Cells[i,  9] 	= "COMENTARIO";
				
				for(int y=0; y<dgAutorizacion.Rows.Count; y++)
				{
					++i;
					
					ExcelApp.Cells[i,  1]	= dgAutorizacion[1,y].Value.ToString();
					ExcelApp.Cells[i,  2]	= dgAutorizacion[2,y].Value.ToString();
					ExcelApp.Cells[i,  3]	= dgAutorizacion[3,y].Value.ToString();
					ExcelApp.Cells[i,  4]	= dgAutorizacion[4,y].Value.ToString();
					ExcelApp.Cells[i,  5]	= dgAutorizacion[5,y].Value.ToString();
					ExcelApp.Cells[i,  6]	= dgAutorizacion[6,y].Value.ToString();
					ExcelApp.Cells[i,  7]	= dgAutorizacion[10,y].Value.ToString();
					ExcelApp.Cells[i,  8]	= dgAutorizacion[11,y].Value.ToString();
					ExcelApp.Cells[i,  9]	= dgAutorizacion[14,y].Value.ToString();
				}
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "AUTORIZACIONES_"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
		#region DATAGIRD ALTERNO
		void getFaltantes()
		{
			dgFaltantes.Rows.Clear();
			
			String consulta = 	"select A.ID, V.Numero, O.Alias, A.FECHA_REG from AUTORIZACION A, VEHICULO V, OPERADOR O where O.ID=A.ID_O and A.ID_V=V.ID and  A.ESTATUS='1' and A.ID_V!=0 and A.FECHA_REG>'2015-01-16' and A.FECHA_REG<(SELECT CONVERT (DATE, SYSDATETIME()))";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgFaltantes.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString(), conn.leer["Alias"].ToString(), (Convert.ToDateTime(conn.leer["FECHA_REG"])).ToString("dd/MM/yyyy"));
			}
			
			conn.conexion.Close();
			
			#region TELEFONO DE OPERADOR
			if(dgFaltantes.Rows.Count>0)
			{
				for(int x=0; x<dgFaltantes.Rows.Count; x++)
				{
					consulta = 	"SELECT O.Alias, T.* FROM OPERADOR O, TELEFONOCHOFER T WHERE O.ID=T.ID_Chofer and T.Tipo='LAR' and O.Estatus='1' and O.Alias='"+dgFaltantes[2,x].Value.ToString()+"'";
					
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgFaltantes[4,x].Value=conn.leer["Numero"].ToString();
					}
					
					conn.conexion.Close();
				}
			}
			#endregion
			
			dgFaltantes.ClearSelection();
		}
		
		void DgEstatusDoubleClick(object sender, EventArgs e)
		{
			txtOperador.Focus();
			txtOperador.Text=dgEstatus[1,dgEstatus.CurrentRow.Index].Value.ToString();
			txtNumUnidad.Focus();
		}
		
		void BtnCargaMasTardeClick(object sender, EventArgs e)
		{
			if(dgEstatus.Rows.Count>0)
			{
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
					
				int i = 1;
			
				++i;
				ExcelApp.Cells[i,  1] 	= "OPERADOR";
				ExcelApp.Cells[i,  2] 	= "UNIDAD";
				
				for(int y=0; y<dgEstatus.Rows.Count; y++)
				{
					if(dgEstatus[4,y].Value.ToString().Contains("/"))
					{
						++i;
						
						ExcelApp.Cells[i,  1]	= dgEstatus[1,y].Value.ToString();
						ExcelApp.Cells[i,  2]	= dgEstatus[3,y].Value.ToString();
					}
				}
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "AUTORIZADOS_"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
		void getDatosDGestatus()
		{
			dgEstatus.Rows.Clear();
			
			String consulta = 	"";
			
			if(DateTime.Now.Hour<11)
			{
				consulta = 	"select * from OPERADOR where Estatus='1' and Alias!='ADMVO' and tipo_empleado='OPERADOR' and ID not in (select ID_O from AUTORIZACION where FECHA_REG=(SELECT CONVERT (DATE, SYSDATETIME())) and ESTATUS='2') order by Alias";
			}
			else
			{
				consulta = 	"select * from OPERADOR where estatus='1' and Alias!='ADMVO' and tipo_empleado='OPERADOR' and ID not in (select A.ID_O from AUTORIZACION A, OPERADOR O where A.ID_O=O.ID and A.FECHA_REG=(SELECT CONVERT (DATE, SYSDATETIME())) and A.ESTATUS='2'  and (A.PERMISO IS NULL OR A.PERMISO = 'CARGA MAÑANA' OR A.PERMISO = 'CIERRE')) order by Alias";
			}
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgEstatus.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString(), "", "", "");
			}
			
			conn.conexion.Close();
			
			completaDG(dgEstatus, "(SELECT CONVERT (DATE, SYSDATETIME()))", 1);
			
			#region TELEFONO DE OPERADOR
			if(dgEstatus.Rows.Count>0)
			{
				for(int x=0; x<dgEstatus.Rows.Count; x++)
				{
					consulta = 	"SELECT O.Alias, T.* FROM OPERADOR O, TELEFONOCHOFER T WHERE O.ID=T.ID_Chofer and T.Tipo='LAR' and O.Estatus='1' and O.ID="+dgEstatus[0,x].Value.ToString();
					
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgEstatus[5,x].Value=conn.leer["Numero"].ToString();
					}
					
					conn.conexion.Close();
				}
			}
			#endregion
			
			/***********/
			dgEstatusAnterior.Rows.Clear();
			
			consulta = 	"select * from OPERADOR where estatus='1' and Alias!='ADMVO' and tipo_empleado='OPERADOR' and ID not in (select A.ID_O from AUTORIZACION A, OPERADOR O where A.ID_O=O.ID and A.FECHA_REG=(select DATEADD (day, -1, (SELECT CONVERT (DATE, SYSDATETIME()))) as FECHA) and A.ESTATUS='2'  and (A.PERMISO IS NULL OR A.PERMISO = 'CARGA MAÑANA' OR A.PERMISO = 'CIERRE')) order by Alias";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgEstatusAnterior.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString(), "", "", "");
			}
			
			conn.conexion.Close();
			
			#region TELEFONO DE OPERADOR
			if(dgEstatusAnterior.Rows.Count>0)
			{
				for(int x=0; x<dgEstatusAnterior.Rows.Count; x++)
				{
					consulta = 	"SELECT O.Alias, T.* FROM OPERADOR O, TELEFONOCHOFER T WHERE O.ID=T.ID_Chofer and T.Tipo='LAR' and O.Estatus='1' and O.ID="+dgEstatusAnterior[0,x].Value.ToString();
					
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgEstatusAnterior[5,x].Value=conn.leer["Numero"].ToString();
					}
					
					conn.conexion.Close();
				}
			}
			#endregion
			
			completaDG(dgEstatusAnterior, "(select DATEADD (day, -1, (SELECT CONVERT (DATE, SYSDATETIME()))))", 2);
			
			dgEstatusAnterior.ClearSelection();
			dgEstatus.ClearSelection();
			/***********/
		}
		
		void completaDG(DataGridView dgestatusV, String FECHA_BUS, int tipo)
		{
			for(int x=0; x<dgestatusV.Rows.Count; x++)
			{
				String consulta = "select V.Numero, V.ID, A.estatus from ASIGNACIONUNIDAD A, OPERADOR O, VEHICULO V where V.ID=A.ID_UNIDAD and O.estatus='1' and A.ID_OPERADOR=O.ID and A.ID_OPERADOR="+dgestatusV[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgestatusV[2,x].Value=conn.leer["ID"].ToString();
					dgestatusV[3,x].Value=conn.leer["Numero"].ToString();
					dgestatusV[4,x].Value=((conn.leer["estatus"].ToString()=="T")?"TALLER":((conn.leer["estatus"].ToString()=="E")?"ESPECIAL":((conn.leer["estatus"].ToString()=="P")?"PERMISO":((conn.leer["estatus"].ToString()=="A")?"SIN REPORTAR":((conn.leer["estatus"].ToString()=="I")?"INCAPACIDAD":"SIN REPORTARSE")))));
				}
				else
				{
					dgestatusV[3,x].Value="SIN UNIDAD";
					dgestatusV[4,x].Value="SIN UNIDAD";
				}
				
				conn.conexion.Close();
				
				if(dgestatusV[2,x].Value.ToString()!="")
				{
					consulta = "select * from AUTORIZACION where FECHA_REG="+FECHA_BUS+" and ESTATUS='2' and (PERMISO = 'CARGA MAS TARDE' or PERMISO = 'LLAMADA') and ID_V ="+dgestatusV[2,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						if(conn.leer["PERMISO"].ToString()=="CARGA MAS TARDE")
						{
							dgestatusV[4,x].Value=conn.leer["TIPO"].ToString()+" / "+((conn.leer["HR_SIGUIENTE"].ToString()=="")?"":conn.leer["HR_SIGUIENTE"].ToString().Substring(0,5));
						}
						
						if(conn.leer["PERMISO"].ToString()=="LLAMADA")
						{
							dgestatusV[4,x].Value=conn.leer["PERMISO"].ToString()+" "+conn.leer["TIPO"].ToString();
						}
					}
					
					conn.conexion.Close();
				}
				
				consulta = "select * from AUTORIZACION where FECHA_REG="+FECHA_BUS+" and estatus='1' and ID_O="+dgestatusV[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgestatusV[4,x].Value="TERMINAR";
				}
				
				conn.conexion.Close();
				
				
				if(dgestatusV[4,x].Value.ToString()=="TERMINAR" || dgestatusV[4,x].Value.ToString().Contains("CARGA/"))
					dgestatusV[4,x].Style.BackColor=Color.Yellow;
				else if(dgestatusV[4,x].Value.ToString()!="")
					dgestatusV[4,x].Style.BackColor=Color.Red;
			}
			
			for(int x=dgestatusV.Rows.Count-1; x>-1; x--)
			{
				//*************  DIAS  **************
				if(dgestatusV[2,x].Value.ToString()!="")
				{
					DateTime fecha2 = DateTime.Now;
					String consulta = "";
					
					if(tipo==2)
						consulta = "(select DATEADD (day, -1, (SELECT CONVERT (DATE, SYSDATETIME()))) as fecha)";
					else
						consulta = "(SELECT CONVERT (DATE, SYSDATETIME()) as fecha)";
					
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()==false)
					{
						fecha2 = Convert.ToDateTime(conn.leer["fecha"]);
					}
					conn.conexion.Close();
					
					consulta = "select * from DIAS_CARGA where "+((fecha2.ToString("dddd")=="sábado")?"sabado":((fecha2.ToString("dddd")=="miércoles")?"miercoles":fecha2.ToString("dddd")))+"='0' and ID_V="+dgestatusV[2,x].Value.ToString();
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						if(dgestatusV[4,x].Value.ToString()!="TERMINAR")
						{
							Conexion_Servidor.SQL_Conexion conne= new Conexion_Servidor.SQL_Conexion();
							consulta = "select * from AUTORIZACION where FECHA_REG=(select DATEADD (day, -1, '"+fecha2.ToString("dd/MM/yyyy")+"')) and PERMISO='CARGA MAÑANA' and ID_V="+dgestatusV[2,x].Value.ToString();
							conne.getAbrirConexion(consulta);
							conne.leer=conne.comando.ExecuteReader();
							if(conne.leer.Read()==false)
							{
								dgestatusV.Rows.RemoveAt(x);
							}
							conne.conexion.Close();
						}
					}
					
					conn.conexion.Close();
				}
				
				//***********************************
			}
			
		}
		#endregion
		
		void DgFaltantesDoubleClick(object sender, EventArgs e)
		{
			if(dgFaltantes.CurrentRow.Index!=-1)
			{
				getTodo(dgFaltantes[1,dgFaltantes.CurrentRow.Index].Value.ToString(), Convert.ToInt64(dgFaltantes[0,dgFaltantes.CurrentRow.Index].Value));
			}
		}
		
		void CmdTerminacionClick(object sender, EventArgs e)
		{
			limpia();
			getDatosDGestatus();
			
			if(dgEstatusAnterior.Rows.Count>0)
			{
				for(int x=0; x<dgEstatusAnterior.Rows.Count; x++)
				{
					if(dgEstatusAnterior[4,x].Value.ToString()=="SIN UNIDAD")
					{
						guardaOtros(2, dgEstatusAnterior[0,x].Value.ToString(), dgEstatusAnterior[2,x].Value.ToString(), dgEstatusAnterior[4,x].Value.ToString());
					}
					else
					{
						guardaOtros(1, dgEstatusAnterior[0,x].Value.ToString(), dgEstatusAnterior[2,x].Value.ToString(), dgEstatusAnterior[4,x].Value.ToString());
					}
				}
			}
			
			getDatosDGestatus();
			getDatosDatagrid();
		}
		
		void guardaOtros(int tipo, String ID_O, String ID_V, String DATO_CIERRE)
		{
			String consulta = "SELECT MAX(NUMERO) NUMERO FROM AUTORIZACION WHERE FECHA_REG=(select DATEADD (day, -1, (SELECT CONVERT (DATE, SYSDATETIME()))))";
			
			Int64 numero = 0;
			String numReg = "";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				try
				{
					numero=Convert.ToInt64(conn.leer["NUMERO"]);
					numero++;
				}
				catch (Exception)
				{
					
				}
			}
			conn.conexion.Close();
			
			// +++++++++++++++++++ registro ++++++++++++++++++++++++
			if(numero==0)
				numReg="01";
			else if(numero.ToString().Length==1)
				numReg="0"+numero;
			else
				numReg=numero.ToString();
			
			String fecha_atras =  "";
			String hora_atras =  "";
			consulta = "(select DATEADD (day, -1, (SELECT CONVERT (DATE, SYSDATETIME()))) as fecha)";
				
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				fecha_atras = Convert.ToDateTime(conn.leer["fecha"].ToString()).ToString("dd/MM/yyyy");
			}
			conn.conexion.Close();
			
			consulta = "(SELECT CONVERT (TIME, SYSDATETIME()) as hora)";
				
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				hora_atras = conn.leer["hora"].ToString().Substring(0,5);
			}
			conn.conexion.Close();
			
			if(tipo==1)
				consulta ="execute SP_AUTORIZA_GAS_EXTERNA "+ refPrincipal.idUsuario+", "+ID_V+", "+ID_O+", null, null, 0, '"+numReg+"', '', 'CIERRE', null, '2', null, '"+DATO_CIERRE+"', 'SIN REPORTARSE', '"+fecha_atras+"', '"+hora_atras+"'";
			else
				consulta ="execute SP_AUTORIZA_GAS_EXTERNA "+ refPrincipal.idUsuario+", 0, "+ID_O+", null, null, 0, '"+numReg+"', '', 'CIERRE', null, '2', null, '"+DATO_CIERRE+"', 'SIN REPORTARSE', '"+fecha_atras+"', '"+hora_atras+"'";
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
		}
		
		#endregion
		
		//*********************************************************************************************************************************
		//****************************************************** VALIDACION ***************************************************************
		//********************************************************************************************************************************* 
		
		#region [ VALIDACION ]
		#region EVENTOS SELECCION EN TEXTBOX
		void TxtUnidadValidacionKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				if(txtUnidadValidacion.Text.Length==2)
				{
					txtUnidadValidacion.Text="0"+txtUnidadValidacion.Text;
				}
				
				txtOperadorValidacion.Text="";
				if(existe(1)==true)
				{
					txtUnidadValidacion.BackColor=Color.MediumSpringGreen;
					txtOperadorValidacion.BackColor=Color.MediumSpringGreen;
					gbMovimientos.Enabled=true;
				}
				else
				{
					txtUnidadValidacion.BackColor=Color.White;
					txtOperadorValidacion.BackColor=Color.White;
					gbMovimientos.Enabled=false;
					lblRendimiento.Text="0";
					ID_UNN=0;
				}
				
				getAutorizacionesValidacion(1);
				getOperador();
				getViajesValidacion();
				try
				{
					getValidado(Convert.ToInt64(dgAutorizacionValida[11,0].Value), 1);
					cmdCalcularKm.Enabled=true;
					getRendimiento();
				}
				catch(Exception)
				{
					dgValidado.Rows.Clear();
					MessageBox.Show("La unidad seleccionada no tiene registro...");
					conn.conexion.Close();
					cmdCalcularKm.Enabled=false;
				}
				
				cambioAnular = true;
			}
		}
		
		void TxtOperadorValidacionKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtUnidadValidacion.Text="";
				if(existe(2)==true)
				{
					txtUnidadValidacion.BackColor=Color.MediumSpringGreen;
					txtOperadorValidacion.BackColor=Color.MediumSpringGreen;
					gbMovimientos.Enabled=true;
				}
				else
				{
					txtUnidadValidacion.BackColor=Color.White;
					txtOperadorValidacion.BackColor=Color.White;
					gbMovimientos.Enabled=false;
					lblRendimiento.Text="0";
					ID_UNN=0;
				}
					
				getAutorizacionesValidacion(2);
				getUnidad();
				getViajesValidacion();
				try
				{
					getValidado(Convert.ToInt64(dgAutorizacionValida[11,0].Value), 1);
					getRendimiento();
				}
				catch(Exception)
				{
					dgValidado.Rows.Clear();
					MessageBox.Show("El operador seleccionador no tiene registro.");
					conn.conexion.Close();
				}
				
				cambioAnular = true;
			}
		}
		
		void TxtOperadorValidacionLeave(object sender, EventArgs e)
		{
			/*txtUnidadValidacion.Text="";
			if(existe(2)==true)
			{
				txtUnidadValidacion.BackColor=Color.MediumSpringGreen;
				txtOperadorValidacion.BackColor=Color.MediumSpringGreen;
				gbMovimientos.Enabled=true;
			}
			else
			{
				txtUnidadValidacion.BackColor=Color.White;
				txtOperadorValidacion.BackColor=Color.White;
				gbMovimientos.Enabled=false;
				lblRendimiento.Text="0";
				ID_UNN=0;
			}
				
			getAutorizacionesValidacion(2);
			getUnidad();
			getViajesValidacion();
			try
			{
				getValidado(Convert.ToInt64(dgAutorizacionValida[11,0].Value), 1);
				getRendimiento();
			}
			catch(Exception)
			{
				dgValidado.Rows.Clear();
				MessageBox.Show("El operador seleccionador no tiene registro.");
				conn.conexion.Close();
			}*/
		}
		#endregion
	
		#region GET BUSQUEDA OPERADOR UNIDAD
		void getOperador()
		{
			String consulta = "select * from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O where V.ID=A.ID_UNIDAD and A.ID_OPERADOR=O.ID and V.Numero='"+txtUnidadValidacion.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				txtOperadorValidacion.Text = conn.leer["Alias"].ToString();	
			}
			
			conn.conexion.Close();
		}
		
		void getUnidad()
		{
			String consulta = "select V.numero, V.Rendimiento_Optimo, V.ID from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O where V.ID=A.ID_UNIDAD and A.ID_OPERADOR=O.ID and O.Alias='"+txtOperadorValidacion.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtUnidadValidacion.Text = conn.leer["numero"].ToString();	
				lblRendOp.Text=(Convert.ToDecimal(conn.leer["Rendimiento_Optimo"])).ToString();
				
				ID_UNN = Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				ID_UNN=0;
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		#region VALIDA DATO EXISTENTE
		bool existe(int tipo)
		{
			bool respuesta = false;
			if(tipo==1)
			{
				String consulta = "select * from VEHICULO where Numero='"+txtUnidadValidacion.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					respuesta=true;
					//lblRendOp.Text=(Convert.ToDecimal(conn.leer["Rendimiento_Optimo"])).ToString();
					ID_UNN=Convert.ToInt64(conn.leer["ID"]);
				}
				conn.conexion.Close();
			}
			else
			{
				String consulta = "select * from OPERADOR where Alias='"+txtOperadorValidacion.Text+"' and Estatus='1'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					respuesta=true;
					
				}
				conn.conexion.Close();
			}
			return respuesta;
		}
		
		bool existe2(String ID)
		{
			bool respuesta = false;
			
			String consulta = "select * from VEHICULO where Numero='"+ID+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				respuesta=true;
				//lblRendOp.Text=(Convert.ToDecimal(conn.leer["Rendimiento_Optimo"])).ToString();
				ID_UNN=Convert.ToInt64(conn.leer["ID"]);
				
			}
			conn.conexion.Close();
			
			return respuesta;
		}
		#endregion
		
		#region GET ULTIMA AUTORIZACION
		public void getAutorizacionesValidacionAlt(Int64 ID_AUT)
		{
			String consulta = "";
			
			inicio=true;
			int cambio = 0;
			ID_Auto = 0;
			Hora_Auto = "00:00";
			Estatus_Auto="0";
			lblUltima.Text="00/00/0000";
			lblHrUltima.Text="00:00";
			
			
			lblRendimiento.Text="0";
			lblRendimiento.BackColor=Color.LightGray;
			lblSimboloPorcent.BackColor=Color.LightGray;
			lblEficiencia.Text="0";
			lblEficiencia.BackColor=Color.LightGray;
			lblLitros.Text="0";
			lblLitros.BackColor=Color.LightGray;
			
			dgAutorizacionValida.Rows.Clear();
			
			bool igual = false;
			String HoraFin = "23:59";
				
			consulta = "select TOP 2 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V = (select ID_V from AUTORIZACION where ESTATUS!=0 and ID="+ID_AUT+") and A.FECHA_BASE <= (select FECHA_BASE from AUTORIZACION  where ESTATUS!=0 and ID="+ID_AUT+") and A.ID<="+ID_AUT+" order by A.FECHA_REG desc, A.NUMERO desc";
			//consulta = "select TOP 2 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V = (select ID_V from AUTORIZACION where ESTATUS!=0 and ID="+ID_AUT+") and A.FECHA_BASE <= (select FECHA_BASE from AUTORIZACION  where ESTATUS!=0 and ID="+ID_AUT+") order by A.FECHA_REG desc, A.NUMERO desc";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(cambio==0)
				{
					dgAutorizacionValida.Rows.Add(conn.leer["ID"].ToString(), 
					                              getNumeroValidacion(Convert.ToInt64(conn.leer["NUMERO"]), 
					                              Convert.ToDateTime(conn.leer["FECHA_BASE"])), 
					                              conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), 
					                              ((conn.leer["FECHA_BASE"].ToString()=="")?"":conn.leer["FECHA_BASE"].ToString().Substring(0,10)), 
					                              conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5), 
					                              conn.leer["ID_G"].ToString(), 
					                              ((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString()), 
					                              ((conn.leer["HORA_CARGA"].ToString()=="")?"00:00":conn.leer["HORA_CARGA"].ToString()), 
					                              ((conn.leer["LITROS"].ToString()=="")?"0.00":conn.leer["LITROS"].ToString()), 
					                              conn.leer["ID_COM"].ToString(),
					                              conn.leer["ID_V"].ToString(), 
					                              conn.leer["ID_O"].ToString(), 
					                              conn.leer["ID_G"].ToString(), 
					                              conn.leer["ID_COM"].ToString(),
					                              conn.leer["ESTATUS"].ToString(), 
					                              conn.leer["KM_ET"].ToString(),
					                              ((conn.leer["PERMISO"].ToString()=="")?"N/A":conn.leer["PERMISO"].ToString()));
					
					FechaFin=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
					HoraFin=conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);;
					lblFactor.Text=((conn.leer["RENDIMIENTO"].ToString()=="")?"N/A":((conn.leer["RENDIMIENTO"].ToString()=="MANTENIMIENTO")?"MTTO":conn.leer["RENDIMIENTO"].ToString()));
					cambio++;
					
					#region OTROS
					if(conn.leer["ANULADO"].ToString()!="")
					{
						cbAnular.Checked=true;
						cmbAnular.Text=conn.leer["ANULADO"].ToString();
					}
					else
					{
						cbAnular.Checked=false;
					}
					
					if(conn.leer["LT_RECUPERADOS"].ToString()=="")
					{
						cbRecupera.Checked=false;
						txtRecupera.Text="0";
					}
					else
					{
						cbRecupera.Checked=true;
						txtRecupera.Text=conn.leer["LT_RECUPERADOS"].ToString();
					}
					
					if(conn.leer["KM_INICIAL"].ToString()=="")
					{
						cbKmInicial.Checked=false;
						txtKmInicial.Text="0";
					}
					else
					{
						cbKmInicial.Checked=true;
						txtKmInicial.Text=conn.leer["KM_INICIAL"].ToString();
					}
					
					if(conn.leer["ANALISIS"].ToString()=="")
					{
						cbPostAnalisis.Checked=false;
					}
					else
					{
						cbPostAnalisis.Checked=true;
					}
					#endregion
				}
				else
				{
					lblUltima.Text=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
					FechaInicio=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
					
					lblHrUltima.Text=((conn.leer["HORA_CARGA"].ToString()=="")?"00:00":conn.leer["HORA_CARGA"].ToString().Substring(0,5));
					
					lblKmUltima.Text=((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString());
					
					ID_Auto = Convert.ToInt64(conn.leer["ID"]);
					Hora_Auto = conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);
					KM_Auto = Convert.ToDouble(((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString()));
					Estatus_Auto=conn.leer["ESTATUS"].ToString();
					
					//MessageBox.Show(Convert.ToDateTime(Hora_Auto).TimeOfDay+"<"+Convert.ToDateTime(HoraFin).TimeOfDay);
					if(conn.leer["FECHA_BASE"].ToString().Substring(0,10)==FechaFin && Convert.ToDateTime(Hora_Auto).TimeOfDay>Convert.ToDateTime(HoraFin).TimeOfDay)
					{
						igual=true;
					}
				}
			}
			conn.conexion.Close();
			
			calculoEfciencia();
			dgAutorizacionValida.ClearSelection();
			
			for(int x=0; x<dgAutorizacionValida.Rows.Count; x++)
			{
				if(dgAutorizacionValida[6,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from GASOLINERA where ID='"+dgAutorizacionValida[6,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[6,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[3,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgAutorizacionValida[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[3,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[2,x].Value.ToString()!="")
				{
					consulta = "select Numero from VEHICULO where ID='"+dgAutorizacionValida[2,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[2,x].Value=conn.leer["Numero"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[10,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from TIPOS_COMB where ID='"+dgAutorizacionValida[10,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[10,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
			}
			
			colorEstatusV();
			
			inicio=false;
			
			getUltimas5();
		}
		
		// mandar llamar
		void calculoEfciencia()
		{
			if(dgAutorizacionValida.Rows.Count>0)
			{
				String consulta = "select* from RENDIMIENTOS WHERE TIPO='"+((lblFactor.Text=="MTTO")?"MANTENIMIENTO":lblFactor.Text)+"' AND ID_V="+dgAutorizacionValida[11,0].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					lblRendOp.Text=conn.leer["FACTOR"].ToString();
					// calculo de eficiencia
				}
				else
				{
					lblRendOp.Text="SR";
				}
				conn.conexion.Close();
			}
			
			int contt = 0;
			String consultt = "select A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and ESTATUS='1' and ID_V in (select ID from VEHICULO where Numero='"+txtUnidadValidacion.Text+"') and FECHA_BASE <= (SELECT CONVERT (DATE, SYSDATETIME())) and FECHA_REG>'25/01/2015' order by FECHA_BASE";
			conn.getAbrirConexion(consultt);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(contt==0)
				{
					cmdHistorial.Enabled=false;
					lblFaltanteObliga.Visible=false;
					contt++;
				}
				else
				{
					cmdHistorial.Enabled=true;
					lblFaltanteObliga.Visible=true;
				}
			}
			conn.conexion.Close();
		}
		
		void getAutorizacionesValidacion(int tipo)
		{
			inicio=true;
			int cambio = 0;
			ID_Auto = 0;
			Hora_Auto = "00:00";
			Estatus_Auto="0";
			lblUltima.Text="00/00/0000";
			lblHrUltima.Text="00:00";
			
			lblRendimiento.Text="0";
			lblRendimiento.BackColor=Color.Transparent;
			lblEficiencia.Text="0";
			lblEficiencia.BackColor=Color.Transparent;
			lblLitros.Text="0";
			lblLitros.BackColor=Color.Transparent;
			
			dgAutorizacionValida.Rows.Clear();
			
			
			bool igual = false;
			String HoraFin = "23:59";
			
			String consulta = "";
			
			if(tipo==1)
				consulta = "select TOP 2 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V in (select ID from VEHICULO where Numero='"+txtUnidadValidacion.Text+"') order by A.FECHA_BASE desc";
			else
				consulta = "select TOP 2 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_O in (select ID from OPERADOR where Alias='"+txtOperadorValidacion.Text+"')  order by A.FECHA_BASE desc";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(cambio==0)
				{
					dgAutorizacionValida.Rows.Add(conn.leer["ID"].ToString(), getNumeroValidacion(Convert.ToInt64(conn.leer["NUMERO"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), ((conn.leer["FECHA_BASE"].ToString()=="")?"":conn.leer["FECHA_BASE"].ToString().Substring(0,10)), conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5), conn.leer["ID_G"].ToString(), ((conn.leer["LITROS"].ToString()=="")?"0.00":conn.leer["LITROS"].ToString()), ((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString()), ((conn.leer["HORA_CARGA"].ToString()=="")?"00:00":conn.leer["HORA_CARGA"].ToString()), conn.leer["ID_COM"].ToString(), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), conn.leer["ID_G"].ToString(), conn.leer["ID_COM"].ToString(), conn.leer["ESTATUS"].ToString(), conn.leer["KM_ET"].ToString(), ((conn.leer["PERMISO"].ToString()=="")?"N/A":conn.leer["PERMISO"].ToString()));
					FechaFin=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
					HoraFin=conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);;
					lblFactor.Text=((conn.leer["RENDIMIENTO"].ToString()=="")?"N/A":((conn.leer["RENDIMIENTO"].ToString()=="MANTENIMIENTO")?"MTTO":conn.leer["RENDIMIENTO"].ToString()));
					
					cambio++;
					
					if(conn.leer["ANULADO"].ToString()=="0")
						cbAnular.Checked=true;
				}
				else
				{
					lblUltima.Text=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
					FechaInicio=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
					
					lblHrUltima.Text=conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);
					
					ID_Auto = Convert.ToInt64(conn.leer["ID"]);
					Hora_Auto = conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);
					KM_Auto = Convert.ToDouble(((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString()));
					Estatus_Auto=conn.leer["ESTATUS"].ToString();
					
					if(conn.leer["FECHA_BASE"].ToString().Substring(0,10)==FechaFin && Convert.ToDateTime(Hora_Auto).TimeOfDay>Convert.ToDateTime(HoraFin).TimeOfDay)
					{
						igual=true;
					}
				}
			}
			
			conn.conexion.Close();
			
			/*if(igual==true)
			{
				igual = false;
				
				if(tipo==1)
					consulta = "select TOP 2 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V in (select ID from VEHICULO where Numero='"+txtUnidadValidacion.Text+"') order by A.FECHA_BASE desc";
				else
					consulta = "select TOP 2 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_O in (select ID from OPERADOR where Alias='"+txtOperadorValidacion.Text+"')  order by A.FECHA_BASE desc";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(cambio==0)
					{
						dgAutorizacionValida.Rows.Add(conn.leer["ID"].ToString(), getNumeroValidacion(Convert.ToInt64(conn.leer["NUMERO"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), ((conn.leer["FECHA_BASE"].ToString()=="")?"":conn.leer["FECHA_BASE"].ToString().Substring(0,10)), conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5), conn.leer["ID_G"].ToString(), ((conn.leer["LITROS"].ToString()=="")?"0.00":conn.leer["LITROS"].ToString()), ((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString()), ((conn.leer["HORA_CARGA"].ToString()=="")?"00:00":conn.leer["HORA_CARGA"].ToString()), conn.leer["ID_COM"].ToString(), conn.leer["ID_V"].ToString(), conn.leer["ID_O"].ToString(), conn.leer["ID_G"].ToString(), conn.leer["ID_COM"].ToString(), conn.leer["ESTATUS"].ToString());
						FechaFin=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
						HoraFin=conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);;
						lblFactor.Text=((conn.leer["RENDIMIENTO"].ToString()=="")?"N/A":((conn.leer["RENDIMIENTO"].ToString()=="MANTENIMIENTO")?"MTTO":conn.leer["RENDIMIENTO"].ToString()));
						
						cambio++;
					}
					else
					{
						lblUltima.Text=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
						FechaInicio=conn.leer["FECHA_BASE"].ToString().Substring(0,10);
						
						lblHrUltima.Text=conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);
						
						ID_Auto = Convert.ToInt64(conn.leer["ID"]);
						Hora_Auto = conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5);
						KM_Auto = Convert.ToDouble(((conn.leer["KM"].ToString()=="")?"0.00":conn.leer["KM"].ToString()));
						Estatus_Auto=conn.leer["ESTATUS"].ToString();
						
						if(conn.leer["FECHA_BASE"].ToString().Substring(0,10)==FechaFin && Convert.ToDateTime(Hora_Auto).TimeOfDay<Convert.ToDateTime(HoraFin).TimeOfDay)
						{
							igual=true;
						}
					}
				}
				conn.conexion.Close();
			}*/
			
			
			calculoEfciencia();
			dgAutorizacionValida.ClearSelection();
			
			for(int x=0; x<dgAutorizacionValida.Rows.Count; x++)
			{
				if(dgAutorizacionValida[6,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from GASOLINERA where ID='"+dgAutorizacionValida[6,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[6,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[3,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgAutorizacionValida[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[3,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[2,x].Value.ToString()!="")
				{
					consulta = "select Numero from VEHICULO where ID='"+dgAutorizacionValida[2,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[2,x].Value=conn.leer["Numero"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgAutorizacionValida[10,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from TIPOS_COMB where ID='"+dgAutorizacionValida[10,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgAutorizacionValida[10,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
			}
			
			colorEstatusV();
			
			inicio=false;
			
			getUltimas5();
		}
		#endregion
		
		#region GET VIAJES POR VALIDAR
		void getViajesValidacion()
		{
			dgMovimientosRutas.Rows.Clear();
			
			if(dgAutorizacionValida.Rows.Count>0)
			{
				//String consulta = "select O.id_operacion, O.fecha, O.turno, R.HoraInicio, R.Sentido, R.Nombre, OP.Alias, OE.NOMBRE emp, V.Numero, R.kilometros from ORDEN_EMPRESAS OE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, VEHICULO V, TURNOS T where T.NOMBRE=O.turno and V.ID=OO.id_vehiculo and OE.ID=C.ID_ORDEN and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.id_ruta=R.ID and O.estatus='1' and R.IdSubEmpresa=C.ID and O.fecha between '"+FechaInicio+"' and '"+FechaFin+"' and V.Numero like '%"+txtUnidadValidacion.Text+"%' and O.id_operacion not in (select ID_R from RELACION_MOVIMIENTO where TIPO='VIAJE' and ID_A!='"+dgAutorizacionValida[0,dgAutorizacionValida.CurrentRow.Index].Value.ToString()+"') order by O.fecha, T.ORDEN, R.nombre";
				String consulta = "select O.id_operacion, O.fecha, O.turno, R.HoraInicio, R.Sentido, R.Nombre, OP.Alias, OE.NOMBRE emp, V.Numero, R.kilometros from ORDEN_EMPRESAS OE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, VEHICULO V, TURNOS T where T.NOMBRE=O.turno and V.ID=OO.id_vehiculo and OE.ID=C.ID_ORDEN and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.id_ruta=R.ID and O.estatus='1' and R.IdSubEmpresa=C.ID and O.fecha between '"+FechaInicio+"' and '"+FechaFin+"' and V.Numero like '%"+txtUnidadValidacion.Text+"%' order by O.fecha, T.ORDEN, R.nombre";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["fecha"].ToString().Substring(0,10)==lblUltima.Text && Convert.ToDateTime(conn.leer["HoraInicio"].ToString())<Convert.ToDateTime(lblHrUltima.Text) && conn.leer["turno"].ToString()!="Nocturno")
					{
						
					}
					else if((conn.leer["fecha"].ToString().Substring(0,10)==dgAutorizacionValida[4,0].Value.ToString() && Convert.ToDateTime(conn.leer["HoraInicio"].ToString()).Hour>=Convert.ToDateTime(dgAutorizacionValida[5,0].Value.ToString()).Hour && Convert.ToDateTime(conn.leer["HoraInicio"].ToString()).Minute>Convert.ToDateTime(dgAutorizacionValida[5,0].Value.ToString()).Minute) || (conn.leer["fecha"].ToString().Substring(0,10)==dgAutorizacionValida[4,0].Value.ToString() && conn.leer["turno"].ToString()=="Nocturno"))
					{
						
					}
					else
					{
						dgMovimientosRutas.Rows.Add(conn.leer["id_operacion"].ToString(), conn.leer["emp"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["fecha"].ToString().Substring(0,10), conn.leer["HoraInicio"].ToString(), conn.leer["turno"].ToString(), conn.leer["Sentido"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), "", "", conn.leer["kilometros"].ToString());
					}
				}
				conn.conexion.Close();
				
				dgMovimientosRutas.ClearSelection();
				getViajesValidacion2();
				sumaKm();
			}
		}
		
		void sumaKm()
		{
			double total = 0.0;
			if(dgMovimientosRutas.Rows.Count>0)
			{
				for(int x=0; x<dgMovimientosRutas.Rows.Count; x++)
				{
					total =  total + Convert.ToDouble(dgMovimientosRutas[11,x].Value);
				}
				
				txtKmTotal.Text=total.ToString();
			}
		}
		
		public void getViajesValidacion2()
		{
			dgMovimientosRutas2.Rows.Clear();
			
			if(dgAutorizacionValida.Rows.Count>0)
			{
				String consulta = "SELECT * FROM VIAJES_FALTANTES WHERE ID_A="+dgAutorizacionValida[0,0].Value.ToString();
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgMovimientosRutas2.Rows.Add(conn.leer["id"].ToString(), conn.leer["EMPRESA"].ToString(), conn.leer["RUTA"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["HORA"].ToString(), conn.leer["TURNO"].ToString(), conn.leer["TIPO"].ToString());
				}
				conn.conexion.Close();
				
				dgMovimientosRutas2.ClearSelection();
			}
		}
		#endregion
		
		#region VALIDACION DTGRID
		void DgAutorizacionValidaCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(inicio==false)
			{
				if(e.ColumnIndex==3)// VALIDO OPERADOR
				{
					Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
					String consulta = "SELECT * FROM OPERADOR WHERE Alias='"+dgAutorizacionValida[3,e.RowIndex].Value.ToString()+"'";
					
					connex.getAbrirConexion(consulta);
					connex.leer=connex.comando.ExecuteReader();
					if(connex.leer.Read())
					{
						dgAutorizacionValida[3,e.RowIndex].Value=connex.leer["Alias"].ToString();
						dgAutorizacionValida[11,0].Value=connex.leer["ID"].ToString();
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
					}
					else
					{
						dgAutorizacionValida[3,e.RowIndex].Value="OPERADOR";
						dgAutorizacionValida[11,0].Value="0";
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
					}
					
					connex.conexion.Close();
				}
				if(e.ColumnIndex==4)// VALIDO FECHA 
				{
					try{Convert.ToDateTime(dgAutorizacionValida[4,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
					catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value=DateTime.Now.ToString("dd/MM/yyyy");dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
				}
				if(e.ColumnIndex==5)// VALIDO HORA 
				{
					try{Convert.ToDateTime(dgAutorizacionValida[5,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
					catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value=DateTime.Now.ToString("HH:mm:ss");dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
				}
				if(e.ColumnIndex==6)// VALIDO GASOLINERA
				{
					Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
					String consulta = "SELECT * FROM GASOLINERA WHERE NOMBRE='"+dgAutorizacionValida[6,e.RowIndex].Value.ToString()+"'";
					
					connex.getAbrirConexion(consulta);
					connex.leer=connex.comando.ExecuteReader();
					if(connex.leer.Read())
					{
						dgAutorizacionValida[6,e.RowIndex].Value=connex.leer["NOMBRE"].ToString();
						dgAutorizacionValida[13,0].Value=connex.leer["ID"].ToString();
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
					}
					else
					{
						dgAutorizacionValida[3,e.RowIndex].Value="GASOLINERA";
						dgAutorizacionValida[13,0].Value="0";
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
					}
					
					connex.conexion.Close();
				}
				if(e.ColumnIndex==9)// VALIDO DECIMAL
				{
					try
					{
						Convert.ToDouble(dgAutorizacionValida[9,e.RowIndex].Value);
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
						
						if(cbKmInicial.Checked==false)
							lblKmHubo.Text=(Convert.ToDouble(dgAutorizacionValida[7,e.RowIndex].Value)-KM_Auto).ToString();
						else
							lblKmHubo.Text=(Convert.ToDouble(dgAutorizacionValida[7,e.RowIndex].Value)-Convert.ToDouble(txtKmInicial.Text)).ToString();
						
						lblRendimiento.Text=decimales((Convert.ToDouble(lblKmHubo.Text)/Convert.ToDouble(dgAutorizacionValida[9,e.RowIndex].Value)).ToString());
						
						if(Convert.ToDouble(dgAutorizacionValida[9,e.RowIndex].Value)>Convert.ToDouble(txtLitrosACargar.Text)*1.15)
							txtLitrosACargar.BackColor=Color.Red;
						else
							txtLitrosACargar.BackColor=Color.White;
						
						
						//new Interfaz.Combustible.FormMensajeRend(this).ShowDialog();
					}
					catch(Exception)
					{
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value="0.00";
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
						txtLitrosACargar.BackColor=Color.White;
					}
				}
				if(e.ColumnIndex==7)// VALIDO DECIMAL
				{
					try
					{
						Convert.ToDouble(dgAutorizacionValida[7,e.RowIndex].Value);
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
						if(cbKmInicial.Checked==false)
							lblKmHubo.Text=(Convert.ToDouble(dgAutorizacionValida[7,e.RowIndex].Value)-KM_Auto).ToString();
						else
							lblKmHubo.Text=(Convert.ToDouble(dgAutorizacionValida[7,e.RowIndex].Value)-Convert.ToDouble(txtKmInicial.Text)).ToString();
							
						lblRendimiento.Text=decimales((Convert.ToDouble(lblKmHubo.Text)/Convert.ToDouble(dgAutorizacionValida[9,e.RowIndex].Value)).ToString());
					}
					catch(Exception)
					{
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value="0.00";
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
					}
				}
				if(e.ColumnIndex==8)// VALIDO HORA 
				{
					try{Convert.ToDateTime(dgAutorizacionValida[8,e.RowIndex].Value);dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;}
					catch(Exception){dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value=DateTime.Now.ToString("HH:mm:ss");dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;}
				}
				if(e.ColumnIndex==10)// VALIDO HORA 
				{
					Conexion_Servidor.SQL_Conexion connex= new Conexion_Servidor.SQL_Conexion();
					String consulta = "SELECT * FROM TIPOS_COMB WHERE NOMBRE='"+dgAutorizacionValida[10,e.RowIndex].Value.ToString()+"'";
					
					connex.getAbrirConexion(consulta);
					connex.leer=connex.comando.ExecuteReader();
					if(connex.leer.Read())
					{
						dgAutorizacionValida[10,e.RowIndex].Value=connex.leer["NOMBRE"].ToString();
						dgAutorizacionValida[14,0].Value=connex.leer["ID"].ToString();
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
					}
					else
					{
						dgAutorizacionValida[10,e.RowIndex].Value="DIESEL";
						dgAutorizacionValida[14,0].Value="1";
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
					}
					
					connex.conexion.Close();
				}
				if(e.ColumnIndex==16)// VALIDO HORA 
				{
					try
					{
						Convert.ToDouble(dgAutorizacionValida[16,e.RowIndex].Value);
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
					}
					catch(Exception)
					{
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Value="0.00";
						dgAutorizacionValida[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
					}
				}
			}
		}
		#endregion
		
		#region GETRENDIMIENTO
		void getRendimiento()
		{
			if(cbAnular.Checked==false)
			{
				if(cbKmInicial.Checked==false)
					lblKmHubo.Text=(Convert.ToDouble(dgAutorizacionValida[7,0].Value)-KM_Auto).ToString();
				else
					lblKmHubo.Text=(Convert.ToDouble(dgAutorizacionValida[7,0].Value)-Convert.ToDouble(txtKmInicial.Text)).ToString();
						
				lblRendimiento.Text=decimales((Convert.ToDouble(lblKmHubo.Text)/Convert.ToDouble(dgAutorizacionValida[9,0].Value)).ToString());
			}
		}
		#endregion
		
		#region CABIO DE COLOR LBLRENDIMIENTO
		void LblRendimientoTextChanged(object sender, EventArgs e)
		{
			try
			{
				if(Convert.ToDouble(lblRendimiento.Text)<Convert.ToDouble(lblRendOp.Text)-(Convert.ToDouble(lblRendOp.Text)*(factorRend/100)))
					lblRendimiento.BackColor=Color.Red;
				else
					lblRendimiento.BackColor=Color.MediumSpringGreen;
				
				lblEficiencia.Text=decimales(((Convert.ToDouble(lblRendimiento.Text)*Convert.ToDouble(100))/Convert.ToDouble(lblRendOp.Text)).ToString());
				
				if(Convert.ToDouble(lblEficiencia.Text)<factorEficiencia || Convert.ToDouble(lblEficiencia.Text)>factorMaximoEf)
				{
					lblEficiencia.BackColor=Color.Red;
					lblSimboloPorcent.BackColor=Color.Red;
				}
				else
				{
					lblEficiencia.BackColor=Color.MediumSpringGreen;
					lblSimboloPorcent.BackColor=Color.MediumSpringGreen;
				}
					
					
				lblLitros.Text=decimales((Convert.ToDouble(dgAutorizacionValida[9,0].Value.ToString())-(Convert.ToDouble(lblKmHubo.Text)/Convert.ToDouble(lblRendOp.Text))).ToString());
				
				if(Convert.ToDouble(lblLitros.Text)>factorLitros)
				{
					lblLitros.BackColor=Color.Red;
					if(cbRecupera.Checked==false)
						txtRecupera.Text=lblLitros.Text;
					
					txtRecupera.BackColor=Color.Red;
				}
				else
				{
					lblLitros.BackColor=Color.MediumSpringGreen;
					if(cbRecupera.Checked==false)
						txtRecupera.Text="0";
					
					txtRecupera.BackColor=Color.White;
				}
				
			}
			catch(Exception)
			{
				
			}
		}
		#endregion
		
		bool validaFacturado(Int64 id_a)
		{
			bool respuesta=false;
			
			String consulta = "select * from AUT_FACT where ESTATUS=1 and ID_F is not null and ID_A="+id_a;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				respuesta=false;
			else
				respuesta=true;
			
			conn.conexion.Close();
			
			return respuesta;
		}
		
		#region MODIFICA AUTORIZACION (CARGA)
		void CmdGuardaCargaClick(object sender, EventArgs e)
		{
			cambioAnular = false;
			bool entra = false;
			bool guardaa = true;
			
			if(cbRecupera.Checked==true)
			{
				if(Convert.ToDouble(txtRecupera.Text)>Convert.ToDouble(lblLitros.Text))
				{
					MessageBox.Show("Es una cantidad mayor a la pérdida generada por el operador de "+lblLitros.Text+" Litros.");
					//txtRecupera.Text="0";
					txtComentarioRecupera.Enabled=false;
					txtComentarioRecupera.Text="Comentario";
					txtComentarioRecupera.BackColor=Color.White;
					txtRecupera.Focus();
					txtRecupera.SelectAll();
					guardaa = false;
				}
				
				if(Convert.ToDouble(txtRecupera.Text)<Convert.ToDouble(lblLitros.Text) && (txtComentarioRecupera.Text=="" || txtComentarioRecupera.Text=="Comentario"))
				{
					MessageBox.Show("Es necesario ingrese comentario");
					txtComentarioRecupera.Enabled=true;
					txtComentarioRecupera.BackColor=Color.Yellow;
					txtComentarioRecupera.Focus();
					txtComentarioRecupera.SelectAll();
					guardaa = false;
				}
			}
			
			if(guardaa == true && validaFacturado(Convert.ToInt64(dgAutorizacionValida[0,0].Value))==true)
			{
				String consulta = "select * from AUTORIZACION WHERE ID='"+dgAutorizacionValida[0,0].Value.ToString()+"'";
					
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["litros"].ToString()!="")
					{
						entra = true;
					}
				}
				
				conn.conexion.Close();
			
				if(entra==true)
				{
					consulta ="EXECUTE AUDITA_GRAL 'AUTORIZACION', "+dgAutorizacionValida[0,0].Value.ToString()+", 'UPDATE', '"+refPrincipal.idUsuario+"'";
					
					conn.getAbrirConexion(consulta); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
				}
				else
				{
					consulta ="UPDATE AUTORIZACION SET HR_DATOS=(SELECT CONVERT (TIME, SYSDATETIME())) WHERE ID='"+dgAutorizacionValida[0,0].Value.ToString()+"'";
				
					conn.getAbrirConexion(consulta); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
				}
			
				consulta ="UPDATE AUTORIZACION SET KM_ET="+dgAutorizacionValida[16,0].Value.ToString()+", ID_COM="+((dgAutorizacionValida[14,0].Value.ToString()=="0")?"null":dgAutorizacionValida[14,0].Value.ToString())+", ID_G="+((dgAutorizacionValida[13,0].Value.ToString()=="0")?"null":dgAutorizacionValida[13,0].Value.ToString())+", ID_O="+((dgAutorizacionValida[12,0].Value.ToString()=="0")?"null":dgAutorizacionValida[12,0].Value.ToString())+", FECHA_BASE='"+dgAutorizacionValida[4,0].Value.ToString()+" "+dgAutorizacionValida[5,0].Value.ToString()+"', HORA_AUTORIZACION='"+dgAutorizacionValida[5,0].Value.ToString()+"', LITROS='"+dgAutorizacionValida[9,0].Value.ToString()+"', KM='"+dgAutorizacionValida[7,0].Value.ToString()+"', HORA_CARGA='"+dgAutorizacionValida[8,0].Value.ToString()+"', ESTATUS='2' WHERE ID='"+dgAutorizacionValida[0,0].Value.ToString()+"'";
				
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				#region GUARDADO DE DATOS EXTRAS
				// +++++++++++++++++++++++++++++ KM INICIAL (NUEVO HUBODOMETRO)
				
				if(cbKmInicial.Checked==true)
				{
					Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set KM_INICIAL='"+txtKmInicial.Text+"' where ID="+dgAutorizacionValida[0,0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				else
				{
					Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set KM_INICIAL=NULL where ID="+dgAutorizacionValida[0,0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				
				// +++++++++++++++++++++++++++++ POST ANALISIS (POR POSIBLE NUEVA CARGA)
				if(cbPostAnalisis.Checked==true)
				{
					Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set ANALISIS='1' where ID="+dgAutorizacionValida[0,0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				else
				{
					Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set ANALISIS=NULL where ID="+dgAutorizacionValida[0,0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				
				// +++++++++++++++++++++++++++++ RECUEPRACION DE LITROS A COBRAR AL OPERADOR
				if(cbRecupera.Checked==true)
				{
					Conexion_Servidor.SQL_Conexion connM = new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set LT_RECUPERADOS='"+txtRecupera.Text+"', COMENTARIO_REC='"+txtComentarioRecupera.Text+"' where ID="+dgAutorizacionValida[0,0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				else
				{
					Conexion_Servidor.SQL_Conexion connM = new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set LT_RECUPERADOS=NULL, COMENTARIO_REC=NULL where ID="+dgAutorizacionValida[0,0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				
				// +++++++++++++++++++++++++++++ ANULACION DE CALCULO DE RENDIMIENTO
				if(cbAnular.Checked==true)
				{
					Conexion_Servidor.SQL_Conexion connM = new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set ANULADO='"+cmbAnular.Text+"'  where ID="+dgAutorizacionValida[0, 0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				else
				{
					Conexion_Servidor.SQL_Conexion connM = new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set ANULADO=NULL  where ID="+dgAutorizacionValida[0, 0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
				}
				#endregion
				
				consulta = "INSERT INTO AUDITORIA_AUTORIZACION VALUES ("+dgAutorizacionValida[0, 0].Value.ToString()+", 'ANULAR="+cbAnular.Checked.ToString()+"("+cmbAnular.Text+") -RECUPERAR="+cbRecupera.Checked.ToString()+"("+txtRecupera.Text+") -KM_INICIAL="+cbKmInicial.Checked.ToString()+"("+txtKmInicial.Text+") -ANALISIS="+cbPostAnalisis.Checked.ToString()+" ', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATETIME, SYSDATETIME())))";
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				//new Interfaz.FormMensaje("Datos de carga guardados. ").Show();
				new Interfaz.Combustible.FormMensajeRend(this).ShowDialog();
				
				dgAutorizacionValida[15,0].Value="2";
				dgAutorizacionValida.ClearSelection();
				
				colorEstatusV();
				txtUnidadValidacion.SelectAll();
				
				getDatosDatagrid();
				
				getDatosDGestatus();
				getFaltantes();
				getTipoAutorizacion();
			}
			else
			{
				MessageBox.Show("No se guardaron los datos.");
			}
		}
		
		void colorEstatusV()
		{
			for(int x=0; x<dgAutorizacionValida.Rows.Count; x++)
			{
				if(dgAutorizacionValida[15,x].Value.ToString()=="2")
				{
					for(int y=3; y<dgAutorizacionValida.Columns.Count; y++)
					{
						dgAutorizacionValida[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
					// permite modificacion o no
					//dgAutorizacionValida.Enabled=false;
				}
				else
				{
					//dgAutorizacionValida.Enabled=true;
				}
			}
		}
		#endregion
		
		#region AGREGA VACIO
		void CmdAgregarMovClick(object sender, EventArgs e)
		{
			new FormVacios(this).ShowDialog();
		}
		#endregion
		
		#region CAMBIOS DE POSICION
		void CmdArribaClick(object sender, EventArgs e)
		{
			/*if(seleccion!=1)
			{*/
				if(seleccion!=0 && dgValidado[3,seleccion-1].Style.BackColor.Name!="Yellow")
				{
					int pos = dgValidado.CurrentRow.Index;
					
					String ID 			= dgValidado[0,seleccion-1].Value.ToString();
					String ID_R 		= dgValidado[1,seleccion-1].Value.ToString();
					String FECHA 		= dgValidado[2,seleccion-1].Value.ToString();	
					String TIPO 		= dgValidado[3,seleccion-1].Value.ToString();
					String NOMBRE 		= dgValidado[4,seleccion-1].Value.ToString();
					String COMENTARIO 	= dgValidado[5,seleccion-1].Value.ToString();
					String DOS 			= dgValidado[6,seleccion-1].Value.ToString();
					String SIETE		= dgValidado[7,seleccion-1].Value.ToString();
					String OCHO			= dgValidado[8,seleccion-1].Value.ToString();	
					String NUEVE		= dgValidado[9,seleccion-1].Value.ToString();
					String DIEZ			= dgValidado[10,seleccion-1].Value.ToString();
					String ONCE			= dgValidado[11,seleccion-1].Value.ToString();
					String DOCE			= dgValidado[12,seleccion-1].Value.ToString();
					String TRECE		= dgValidado[13,seleccion-1].Value.ToString();
					
					dgValidado[0,seleccion-1].Value=dgValidado[0,seleccion].Value.ToString();
					dgValidado[1,seleccion-1].Value=dgValidado[1,seleccion].Value.ToString();
					dgValidado[2,seleccion-1].Value=dgValidado[2,seleccion].Value.ToString();
					dgValidado[3,seleccion-1].Value=dgValidado[3,seleccion].Value.ToString();
					dgValidado[4,seleccion-1].Value=dgValidado[4,seleccion].Value.ToString();
					dgValidado[5,seleccion-1].Value=dgValidado[5,seleccion].Value.ToString();
					dgValidado[6,seleccion-1].Value=dgValidado[6,seleccion].Value.ToString();
					dgValidado[7,seleccion-1].Value=dgValidado[7,seleccion].Value.ToString();
					dgValidado[8,seleccion-1].Value=dgValidado[8,seleccion].Value.ToString();
					dgValidado[9,seleccion-1].Value=dgValidado[9,seleccion].Value.ToString();
					dgValidado[10,seleccion-1].Value=dgValidado[10,seleccion].Value.ToString();
					dgValidado[11,seleccion-1].Value=dgValidado[11,seleccion].Value.ToString();
					dgValidado[12,seleccion-1].Value=dgValidado[12,seleccion].Value.ToString();
					dgValidado[13,seleccion-1].Value=dgValidado[13,seleccion].Value.ToString();
					
					
					dgValidado[0,seleccion].Value=ID;
					dgValidado[1,seleccion].Value=ID_R;
					dgValidado[2,seleccion].Value=FECHA;
					dgValidado[3,seleccion].Value=TIPO;
					dgValidado[4,seleccion].Value=NOMBRE;
					dgValidado[5,seleccion].Value=COMENTARIO;
					dgValidado[6,seleccion].Value=DOS;
					dgValidado[7,seleccion].Value=SIETE;
					dgValidado[8,seleccion].Value=OCHO;
					dgValidado[9,seleccion].Value=NUEVE;
					dgValidado[10,seleccion].Value=DIEZ;
					dgValidado[11,seleccion].Value=ONCE;
					dgValidado[12,seleccion].Value=DOCE;
					dgValidado[13,seleccion].Value=TRECE;
					
					/*for(int x=0; x<dgValidado.Columns.Count; x++)
					{
						dgValidado[x,seleccion].Style.BackColor=Color.White;
						dgValidado[x,seleccion-1].Style.BackColor=Color.White;
					}*/
					
					//dgValidado.ClearSelection();
					
					dgValidado.Rows[seleccion-1].Selected = true;
					if(seleccion!=dgValidado.Rows.Count-1)
					{
						//dgValidado.Rows[seleccion].Selected = false;
					}
					seleccion=seleccion-1;
				}
			/*}
			else if(dgValidado.SelectedRows.Count==0)
			{
				MessageBox.Show("Seleccione un registro para moverlo");
			}
			else
			{
				MessageBox.Show("Seleccione solo un registro");
			}*/
		}
		
		void CmdAbajoClick(object sender, EventArgs e)
		{
			/*if(seleccion!=0)
			//{*/
				if(seleccion!=dgValidado.Rows.Count-1 && dgValidado[3,seleccion].Style.BackColor.Name!="Yellow")
				{
					String ID 			= dgValidado[0,seleccion+1].Value.ToString();
					String ID_R 		= dgValidado[1,seleccion+1].Value.ToString();
					String FECHA 		= dgValidado[2,seleccion+1].Value.ToString();	
					String TIPO 		= dgValidado[3,seleccion+1].Value.ToString();
					String NOMBRE 		= dgValidado[4,seleccion+1].Value.ToString();
					String COMENTARIO 	= dgValidado[5,seleccion+1].Value.ToString();
					String DOS 			= dgValidado[6,seleccion+1].Value.ToString();
					String SIETE		= dgValidado[7,seleccion-1].Value.ToString();
					String OCHO			= dgValidado[8,seleccion-1].Value.ToString();	
					String NUEVE		= dgValidado[9,seleccion-1].Value.ToString();
					String DIEZ			= dgValidado[10,seleccion-1].Value.ToString();
					String ONCE			= dgValidado[11,seleccion-1].Value.ToString();
					String DOCE			= dgValidado[12,seleccion-1].Value.ToString();
					String TRECE		= dgValidado[13,seleccion-1].Value.ToString();
					
					dgValidado[0,seleccion+1].Value=dgValidado[0,seleccion].Value.ToString();
					dgValidado[1,seleccion+1].Value=dgValidado[1,seleccion].Value.ToString();
					dgValidado[2,seleccion+1].Value=dgValidado[2,seleccion].Value.ToString();
					dgValidado[3,seleccion+1].Value=dgValidado[3,seleccion].Value.ToString();
					dgValidado[4,seleccion+1].Value=dgValidado[4,seleccion].Value.ToString();
					dgValidado[5,seleccion+1].Value=dgValidado[5,seleccion].Value.ToString();
					dgValidado[6,seleccion+1].Value=dgValidado[6,seleccion].Value.ToString();
					dgValidado[7,seleccion-1].Value=dgValidado[7,seleccion].Value.ToString();
					dgValidado[8,seleccion-1].Value=dgValidado[8,seleccion].Value.ToString();
					dgValidado[9,seleccion-1].Value=dgValidado[9,seleccion].Value.ToString();
					dgValidado[10,seleccion-1].Value=dgValidado[10,seleccion].Value.ToString();
					dgValidado[11,seleccion-1].Value=dgValidado[11,seleccion].Value.ToString();
					dgValidado[12,seleccion-1].Value=dgValidado[12,seleccion].Value.ToString();
					dgValidado[13,seleccion-1].Value=dgValidado[13,seleccion].Value.ToString();
					
					dgValidado[0,seleccion].Value=ID;
					dgValidado[1,seleccion].Value=ID_R;
					dgValidado[2,seleccion].Value=FECHA;
					dgValidado[3,seleccion].Value=TIPO;
					dgValidado[4,seleccion].Value=NOMBRE;
					dgValidado[5,seleccion].Value=COMENTARIO;
					dgValidado[6,seleccion].Value=DOS;
					dgValidado[7,seleccion].Value=SIETE;
					dgValidado[8,seleccion].Value=OCHO;
					dgValidado[9,seleccion].Value=NUEVE;
					dgValidado[10,seleccion].Value=DIEZ;
					dgValidado[11,seleccion].Value=ONCE;
					dgValidado[12,seleccion].Value=DOCE;
					dgValidado[13,seleccion].Value=TRECE;
					
					/*for(int x=0; x<dgValidado.Columns.Count; x++)
					{
						dgValidado[x,seleccion].Style.BackColor=Color.White;
						dgValidado[x,seleccion+1].Style.BackColor=Color.White;
					}*/
					
					//dgValidado.ClearSelection();
					dgValidado.Rows[seleccion+1].Selected = true;
					if(seleccion!=0)
					{
						//dgValidado.Rows[seleccion-1].Selected = false;
					}
					seleccion=seleccion+1;
				}
			/*}
			else if(dgValidado.SelectedRows.Count==0)
			{
				MessageBox.Show("Seleccione un registro para moverlo");
			}
			else if(dgValidado.CurrentRow.Index==0)
			{
				MessageBox.Show("Este registro no se puede mover");
			}
			else
			{
				MessageBox.Show("Seleccione solo un registro");
			}*/
		}
		#endregion
		
		#region MODIFICACION DE VALIDADO
		void CmdGuardaValidadoClick(object sender, EventArgs e)
		{
			if(rbFaltantes.Checked==true)
			{
				if(dgMovimientosRutas.Rows.Count>0)
				{
					bool incompleto = false;
				
					for(int x=0; x<dgMovimientosRutas.Rows.Count; x++)
					{
						//MessageBox.Show(dgMovimientosRutas[1,x].Style.BackColor.Name+"!=Red");
						if(dgMovimientosRutas[1,x].Style.BackColor.Name!="Red")
						{
							incompleto=true;
						}
					}
					
					if(incompleto==true)
					{
						DialogResult rs2 = MessageBox.Show("Faltan viajes por validar \n ¿desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (DialogResult.Yes==rs2)
						{
							for(int x=0; x<dgValidado.Rows.Count; x++)
							{
								if(dgValidado[0,x].Style.BackColor.Name!="Yellow")
								{
									String consulta ="update RELACION_MOVIMIENTO set ORDEN='"+x+"', ESTATUS='2' where ID="+dgValidado[0,x].Value.ToString();
								
									conn.getAbrirConexion(consulta); 
									conn.comando.ExecuteNonQuery(); 
									conn.conexion.Close();
								
									dgValidado[10,x].Value="2";
								}
							}
						}
					}
					else
					{
						for(int x=0; x<dgValidado.Rows.Count; x++)
						{
							if(dgValidado[0,x].Style.BackColor.Name!="Yellow")
							{
								String consulta ="update RELACION_MOVIMIENTO set ORDEN='"+x+"', ESTATUS='2' where ID="+dgValidado[0,x].Value.ToString();
							
								conn.getAbrirConexion(consulta); 
								conn.comando.ExecuteNonQuery(); 
								conn.conexion.Close();
							
								dgValidado[10,x].Value="2";
							}
						}
					}
				}
				else
				{
					for(int x=0; x<dgValidado.Rows.Count; x++)
					{
						if(dgValidado[0,x].Style.BackColor.Name!="Yellow")
						{
							String consulta ="update RELACION_MOVIMIENTO set ORDEN='"+x+"', ESTATUS='2' where ID="+dgValidado[0,x].Value.ToString();
						
							conn.getAbrirConexion(consulta); 
							conn.comando.ExecuteNonQuery(); 
							conn.conexion.Close();
						
							dgValidado[10,x].Value="2";
						}
					}
				}
			}
			else
			{
				bool incompleto = false;
				
				for(int x=0; x<dgMovimientosRutas.Rows.Count; x++)
				{
					if(dgMovimientosRutas[1,x].Style.BackColor.Name!="MediumSpringGreen" && dgMovimientosRutas[1,x].Style.BackColor.Name!="Red")
					{
						incompleto=true;
					}
				}
				
				if(incompleto==true)
				{
					DialogResult rs2 = MessageBox.Show("Faltan viajes por validar \n ¿desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs2)
					{
						for(int x=0; x<dgValidado.Rows.Count; x++)
						{
							if(dgValidado[0,x].Style.BackColor.Name!="Yellow")
							{
								String consulta ="update RELACION_MOVIMIENTO set ORDEN='"+x+"', ESTATUS='2' where ID="+dgValidado[0,x].Value.ToString();
							
								conn.getAbrirConexion(consulta); 
								conn.comando.ExecuteNonQuery(); 
								conn.conexion.Close();
								
								dgValidado[10,x].Value="2";
							}
						}
					}
				}
				else
				{
					for(int x=0; x<dgValidado.Rows.Count; x++)
					{
						if(dgValidado[0,x].Style.BackColor.Name!="Yellow")
						{
							String consulta ="update RELACION_MOVIMIENTO set ORDEN='"+x+"', ESTATUS='2' where ID="+dgValidado[0,x].Value.ToString();
						
							conn.getAbrirConexion(consulta); 
							conn.comando.ExecuteNonQuery(); 
							conn.conexion.Close();
							
							dgValidado[10,x].Value="2";
						}
					}
				}
			}
			
			colorVacios();
			//calculoKm();
			
		}
		#endregion
		
		
		
		#region COLOR VALIDADO VACIOS
		void colorVacios()
		{
			for(int x=0; x<dgValidado.Rows.Count; x++)
			{
				if(dgValidado[10,x].Value.ToString()=="2" && dgValidado[3,x].Style.BackColor.Name!="Yellow")
				{
					for(int y=0; y<dgValidado.Columns.Count; y++)
					{
						dgValidado[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
		}
		#endregion
		
		#region FILTRO DE CBFALTANTES
		void RbFaltantesCheckedChanged(object sender, EventArgs e)
		{
			getViajesValidacion();
			colorValidado();
		}
		#endregion
		
		#region ELIMINA UN GUARDADO
		void CmdEliminaMovClick(object sender, EventArgs e)
		{
			if(dgValidado.SelectedRows.Count==1 && dgValidado.CurrentRow.Index!=-1)
			{
				String consulta ="update RELACION_MOVIMIENTO set ESTATUS='0' where ID="+dgValidado[0,dgValidado.CurrentRow.Index].Value.ToString();
						
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				dgValidado.Rows.RemoveAt(dgValidado.CurrentRow.Index);
				if(dgValidado[4,dgValidado.CurrentRow.Index].Value.ToString()=="VIAJE")
				{
					getViajesValidacion();
					colorValidado();
				}
			}
		}
		#endregion
		
		#region SELECCION
		void TxtUnidadValidacionEnter(object sender, EventArgs e)
		{
			dgMovimientosRutas.ClearSelection();
			dgValidado.ClearSelection();
			seleccion=0;
			txtUnidadValidacion.SelectAll();
		}
		
		void TxtUnidadValidacionClick(object sender, EventArgs e)
		{
			txtUnidadValidacion.SelectAll();
			dgMovimientosRutas.ClearSelection();
			dgValidado.ClearSelection();
			seleccion=0;
		}
		
		void TxtOperadorValidacionEnter(object sender, EventArgs e)
		{
			txtOperadorValidacion.SelectAll();
			dgMovimientosRutas.ClearSelection();
			dgValidado.ClearSelection();
			seleccion=0;
		}
		
		void TxtOperadorValidacionClick(object sender, EventArgs e)
		{
			txtOperadorValidacion.SelectAll();
			dgMovimientosRutas.ClearSelection();
			dgValidado.ClearSelection();
			seleccion=0;
		}
		#endregion
		
		#region MUESTRA SELECCION
		void CmdHistorialClick(object sender, EventArgs e)
		{
			new FormHistorialValidacion(this).ShowDialog();
		}
		
		void DgValidadoCellClick(object sender, DataGridViewCellEventArgs e)
		{
			seleccion=e.RowIndex;
			
			if(e.RowIndex!=-1 && dgValidado[4,e.RowIndex].Value.ToString()=="VIAJE")
			{
				for(int x=0; x<dgMovimientosRutas.Rows.Count; x++)
				{
					if(dgValidado[1,e.RowIndex].Value.ToString()==dgMovimientosRutas[0,x].Value.ToString())
					{
						dgMovimientosRutas.ClearSelection();
						dgMovimientosRutas.Rows[x].Selected = true;
					}
				}
			}
		}
		#endregion
		
		#region VALIDACION DE VIAJES DEL OPERADOR
		
		#region VALIDA RUTA
		void CmdValidaClick(object sender, EventArgs e)
		{
			//for(int x=dgMovimientosRutas.Rows.Count-1; x>-1; x--)
			for(int x=0; x<dgValidado.Rows.Count; x++)
			{
				if(dgValidado[0,x].Style.BackColor.Name!="Yellow")
				{
					String consult ="update RELACION_MOVIMIENTO set ORDEN='"+x+"' where ID="+dgValidado[0,x].Value.ToString();
				
					conn.getAbrirConexion(consult); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
				}
			}
			
			for(int x=0; x<dgMovimientosRutas.Rows.Count; x++)
			{
				if(dgMovimientosRutas[1,x].Style.BackColor.Name!="MediumSpringGreen" && dgMovimientosRutas[1,x].Style.BackColor.Name!="Red" && dgMovimientosRutas[1,x].Selected==true)
				{
					Valida(Convert.ToInt64(dgMovimientosRutas[0,x].Value), Convert.ToInt64(dgAutorizacionValida[11,dgAutorizacionValida.CurrentRow.Index].Value),"VIAJE", txtComentario.Text, dgMovimientosRutas[3,x].Value.ToString(), dgMovimientosRutas[4,x].Value.ToString());
				}
			}
			
			getValidado(Convert.ToInt64(dgAutorizacionValida[11,0].Value), 3);
			dgMovimientosRutas.ClearSelection();
			txtComentario.Text="";
			
			colorValidado();
			
			dgMovimientosRutas.ClearSelection();
			
			/*if(dgMovimientosRutas[1,dgMovimientosRutas.CurrentRow.Index].Style.BackColor.Name!="MediumSpringGreen" && dgMovimientosRutas[1,dgMovimientosRutas.CurrentRow.Index].Style.BackColor.Name!="Red")
			{
				//************************************
				Valida(Convert.ToInt64(dgMovimientosRutas[0,dgMovimientosRutas.CurrentRow.Index].Value), Convert.ToInt64(dgAutorizacionValida[11,dgAutorizacionValida.CurrentRow.Index].Value),"VIAJE", txtComentario.Text, dgMovimientosRutas[3,dgMovimientosRutas.CurrentRow.Index].Value.ToString());
				getValidado(Convert.ToInt64(dgAutorizacionValida[11,dgAutorizacionValida.CurrentRow.Index].Value), 1);
				dgMovimientosRutas.ClearSelection();
				txtComentario.Text="";
			}*/
			
			gbCargas.Enabled=true;
		}
		
		public void Valida(Int64 ID_REG, Int64 ID_VE, String TIPO, String COMENTARIO, String FECHA, string HORA)
		{
			String consulta ="INSERT INTO RELACION_MOVIMIENTO VALUES ('"+ID_REG+"','"+dgAutorizacionValida[0,dgAutorizacionValida.CurrentRow.Index].Value.ToString()+"','"+TIPO+"', 0, '"+COMENTARIO+"', '"+FECHA+"', '"+HORA+"','1',(SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())));";
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();	
		}
		#endregion
		
		#region MANDA A REVISION
		void DgMovimientosRutasDoubleClick(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region A REVISION
		void CmdSinRealizarClick(object sender, EventArgs e)
		{
			if(dgMovimientosRutas.SelectedRows.Count==1)
			{
				if(dgMovimientosRutas.CurrentRow.Index!=-1 && dgMovimientosRutas[2,dgMovimientosRutas.CurrentRow.Index].Style.BackColor.Name!="Red")
				{
					DialogResult rs = MessageBox.Show("¿Mandar a revisión?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs)
					{
						String consulta = "insert into REVISION_VIAJES values ("+dgMovimientosRutas[0,dgMovimientosRutas.CurrentRow.Index].Value.ToString()+", 'N/A', '1', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())));";
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
						
						for(int x=0; x<dgMovimientosRutas.Columns.Count; x++)
						{
							dgMovimientosRutas[x,dgMovimientosRutas.CurrentRow.Index].Style.BackColor=Color.Red;
						}
						dgMovimientosRutas.ClearSelection();
					}
				}
				else if(dgMovimientosRutas[2,dgMovimientosRutas.CurrentRow.Index].Style.BackColor.Name=="Red")
				{
					DialogResult rs = MessageBox.Show("¿Desea quitar de revisión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs)
					{
						String consulta = "UPDATE REVISION_VIAJES SET ESTATUS='0' WHERE ID_O="+dgMovimientosRutas[0,dgMovimientosRutas.CurrentRow.Index].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
						
						for(int x=0; x<dgMovimientosRutas.Columns.Count; x++)
						{
							dgMovimientosRutas[x,dgMovimientosRutas.CurrentRow.Index].Style.BackColor=Color.White;
						}
						dgMovimientosRutas.ClearSelection();
					}
				}
				
				gbCargas.Enabled=true;
			}
			else
			{
				MessageBox.Show("Seleccione un solo registro.");
			}
		}
		
		void CmdFaltantesClick(object sender, EventArgs e)
		{
			new FormFaltantes(this).ShowDialog();
			gbCargas.Enabled=true;
		}
		#endregion
		
		#endregion
		
		#region MUESTRA TODAS LAS AUTORIZACIONES
		void LblUltimaDoubleClick(object sender, EventArgs e)
		{
			if(ID_UNN!=0)
			{
				new FormAutorizaciones(this, ID_UNN).ShowDialog();
			}
		}
		#endregion
		
		#region GET DATOS ULTIMAS 5 CARGAS
		void getUltimas5()
		{
			dgUltimas.Rows.Clear();
			int conteo = 0;
			
			if(dgAutorizacionValida.Rows.Count>0)
			{
				String consulta = "SELECT A.*, U.usuario, O.tipo_empleado FROM AUTORIZACION A, VEHICULO V, OPERADOR O, USUARIO U WHERE U.id_usuario=A.ID_U AND A.ESTATUS!=0 AND A.ID_V=V.ID AND A.ID_O=O.ID AND V.Numero LIKE '%"+dgAutorizacionValida[2,0].Value.ToString()+"%' and A.FECHA_REG>(select DATEADD (day, -15, (SELECT CONVERT (DATE, SYSDATETIME())))) order by V.Numero, A.FECHA_REG, A.Numero";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conteo==0)
						conteo++;
					else
						dgUltimas.Rows.Add(conn.leer["ID"].ToString(), 
						                   getNumeroValidacion(Convert.ToInt64(conn.leer["Numero"]), Convert.ToDateTime(conn.leer["FECHA_BASE"])), 
						                   conn.leer["ID_V"].ToString(),  
						                   conn.leer["ID_G"].ToString(), 
						                   conn.leer["ID_O"].ToString(), 
						                   conn.leer["FECHA_BASE"].ToString().Substring(0,10), 
						                   conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5), 
						                   conn.leer["LITROS"].ToString(), 
						                   conn.leer["KM"].ToString(),
						                   conn.leer["HORA_CARGA"].ToString(), 
						                   conn.leer["COMENTARIO"].ToString(),
						                   conn.leer["KM_INICIAL"].ToString(), 
						                   "", 
						                   conn.leer["RENDIMIENTO"].ToString(), 
						                   "", 
						                   "", 
						                   "",
						                   conn.leer["ID_COM"].ToString(), 
						                   "", 
						                   "", 
						                   "",
						                   ((conn.leer["HR_DATOS"].ToString()=="")?"":conn.leer["HR_DATOS"].ToString().Substring(0,5)), 
						                   conn.leer["PERMISO"].ToString(), 
						                   conn.leer["TIPO"].ToString(),
						                   conn.leer["COMENTARIO"].ToString(), 
						                   "", 
						                   "",
						                   conn.leer["usuario"].ToString().ToUpper(), 
						                   conn.leer["LT_RECUPERADOS"].ToString(), 
						                   "",
						                   conn.leer["ANULADO"].ToString(),
						                   conn.leer["tipo_empleado"].ToString().ToUpper(), 
						                   conn.leer["INTEGRA"].ToString(), 
						                   conn.leer["TIPO_INTEGRA"].ToString(),
						                   conn.leer["ANALISIS"].ToString());
				}
				conn.conexion.Close();
				
				for(int x=0; x<dgUltimas.Rows.Count; x++)
				{
					if(dgUltimas[3,x]==null || dgUltimas[4,x].Value.ToString()!="")
					{
						consulta = "select NOMBRE from GASOLINERA where ID='"+dgUltimas[3,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgUltimas[3,x].Value=conn.leer["NOMBRE"].ToString();
						}
						conn.conexion.Close();
					}
					
					if(dgUltimas[2,x].Value.ToString()!="")
					{
						consulta = "select Numero from VEHICULO where ID='"+dgUltimas[2,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgUltimas[2,x].Value=conn.leer["Numero"].ToString();
						}
						conn.conexion.Close();
					}
					
					if(dgUltimas[4,x].Value.ToString()!="")
					{
						consulta = "select Alias from OPERADOR where ID='"+dgUltimas[4,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgUltimas[4,x].Value=conn.leer["Alias"].ToString();
						}
						conn.conexion.Close();
					}
					
					if(dgUltimas[17,x].Value.ToString()!="")
					{
						consulta = "SELECT P.ID, T.NOMBRE, P.PRECIO FROM TIPOS_COMB T, PRECIOS_COMB P WHERE T.ID=P.ID_TC AND P.ID = '"+dgUltimas[17,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							dgUltimas[17,x].Value=conn.leer["NOMBRE"].ToString();
							dgUltimas[18,x].Value=conn.leer["PRECIO"].ToString();
						}
						conn.conexion.Close();
					}
				}
				
				dgUltimas.ClearSelection();
				//dgUltimas.Rows[dgUltimas.Rows.Count-1].Selected = true;
				if(dgUltimas.Rows.Count>0)
				{
					dgUltimas.FirstDisplayedCell = dgUltimas.Rows[dgUltimas.Rows.Count-1].Cells[1];
				}
				
				calculaRendUltimas();
				dgUltimas.ClearSelection();
			}
		}
		#endregion
		
		#region CALCULO DE RENDIMIENTOS DE 5 ULTIMOS
		void calculaRendUltimas()
		{
			getFactor();
			
			if(dgUltimas.Rows.Count>0)
			{
				double litroDia = 0.0;
				for(int x=0; x<dgUltimas.Rows.Count; x++)
				{
					getKmAnteriorUltimas(Convert.ToInt64(dgUltimas[0,x].Value), x, Convert.ToDateTime(dgUltimas[5,x].Value));
					getRendIdealUltimas(x);
					
					if(dgUltimas[7,x].Value.ToString()!="")
					{
						dgUltimas[20,x].Value=decimales((Convert.ToDouble(dgUltimas[7,x].Value)*Convert.ToDouble(dgUltimas[18,x].Value)).ToString());
						
						if(dgUltimas[11,x].Value.ToString()!="0" && dgUltimas[13,x].Value.ToString()!="0")
						{
							// ********************************************* VALIDA CARGA MISMO DIA *******************************************
							// ****************************************************************************************************************
							// ****************************************************************************************************************
							if(x==0 || dgUltimas[2,x-1].Value.ToString()!=dgUltimas[2,x].Value.ToString() || Convert.ToDateTime(dgUltimas[5,x-1].Value)<Convert.ToDateTime(dgUltimas[5,x].Value) || dgUltimas[3,x-1].Value.ToString()=="")
							{
								litroDia = 0.0;
								litroDia = Convert.ToDouble(dgUltimas[7,x].Value);
								
								dgUltimas[12,x].Value=(Convert.ToDouble(dgUltimas[8,x].Value)-Convert.ToDouble(dgUltimas[11,x].Value)).ToString();
								
								dgUltimas[14,x].Value=decimales((Convert.ToDouble(dgUltimas[12,x].Value)/(Convert.ToDouble(dgUltimas[7,x].Value))).ToString());
								
								
								try
								{
									if(dgUltimas[14,x].Value.ToString()!="")
									{
										if(Convert.ToDouble(dgUltimas[14,x].Value)<Convert.ToDouble(dgUltimas[13,x].Value)-(Convert.ToDouble(dgUltimas[13,x].Value)*(factorRend/100)))
										{
											dgUltimas[14,x].Style.BackColor=Color.Red;
										}
										else
										{
											dgUltimas[14,x].Style.BackColor=Color.MediumSpringGreen;
										}
										
										//*********************
										
										dgUltimas[15,x].Value=decimales(Convert.ToString((Convert.ToDecimal(dgUltimas[14,x].Value)/Convert.ToDecimal(dgUltimas[13,x].Value))*Convert.ToDecimal(100.0)));
										
										if(Convert.ToDouble(dgUltimas[15,x].Value)<factorEficiencia || Convert.ToDouble(dgUltimas[15,x].Value)>factorMaximoEf)
											dgUltimas[15,x].Style.BackColor=Color.Red;
										else
											dgUltimas[15,x].Style.BackColor=Color.MediumSpringGreen;
										
										dgUltimas[15,x].Value=dgUltimas[15,x].Value.ToString()+"%";
										
										//*********************	
										
										dgUltimas[16,x].Value=decimales((Convert.ToDouble(dgUltimas[7,x].Value)-(Convert.ToDouble(dgUltimas[12,x].Value)/Convert.ToDouble(dgUltimas[13,x].Value))).ToString());
										
										if(Convert.ToDouble(dgUltimas[16,x].Value)>factorLitros)
											dgUltimas[16,x].Style.BackColor=Color.Red;
										else
											dgUltimas[16,x].Style.BackColor=Color.MediumSpringGreen;
										
										
										dgUltimas[19,x].Value=decimales((Convert.ToDouble(dgUltimas[16,x].Value)*Convert.ToDouble(dgUltimas[18,x].Value)).ToString());
									}
								}
								catch(Exception)
								{
									//MessageBox.Show("Row: "+x);
								}
							}
							else
							{
								if(Convert.ToDateTime(dgUltimas[5,x-1].Value)==Convert.ToDateTime(dgUltimas[5,x].Value))
								{
									dgUltimas[11,x].Value=dgUltimas[11,x-1].Value;
									dgUltimas[14,x-1].Value="";
									dgUltimas[15,x-1].Value="";
									dgUltimas[16,x-1].Value="";
									dgUltimas[19,x-1].Value="";
									
									dgUltimas[14,x-1].Style.BackColor=Color.Yellow;
									dgUltimas[15,x-1].Style.BackColor=Color.Yellow;
									dgUltimas[16,x-1].Style.BackColor=Color.Yellow;
									
									dgUltimas[12,x].Value=(Convert.ToDouble(dgUltimas[8,x].Value)-Convert.ToDouble(dgUltimas[11,x].Value)).ToString();
									
									litroDia = litroDia+(Convert.ToDouble(dgUltimas[7,x].Value));
									
									dgUltimas[14,x].Value=decimales((Convert.ToDouble(dgUltimas[12,x].Value)/litroDia).ToString());
									
									try
									{
										if(dgUltimas[14,x].Value.ToString()!="")
										{
											if(Convert.ToDouble(dgUltimas[14,x].Value)<Convert.ToDouble(dgUltimas[13,x].Value)-(Convert.ToDouble(dgUltimas[13,x].Value)*(factorRend/100)))
											{
												dgUltimas[14,x].Style.BackColor=Color.Red;
											}
											else
											{
												dgUltimas[14,x].Style.BackColor=Color.MediumSpringGreen;
											}
											
											//*********************
											
											dgUltimas[15,x].Value=decimales(Convert.ToString((Convert.ToDecimal(dgUltimas[14,x].Value)/Convert.ToDecimal(dgUltimas[13,x].Value))*Convert.ToDecimal(100.0)));
											
											if(Convert.ToDouble(dgUltimas[15,x].Value)<factorEficiencia || Convert.ToDouble(dgUltimas[15,x].Value)>factorMaximoEf)
												dgUltimas[15,x].Style.BackColor=Color.Red;
											else
												dgUltimas[15,x].Style.BackColor=Color.MediumSpringGreen;
											
											dgUltimas[15,x].Value=dgUltimas[15,x].Value.ToString()+"%";
											
											//*********************	
											
											dgUltimas[16,x].Value=decimales((litroDia-(Convert.ToDouble(dgUltimas[12,x].Value)/Convert.ToDouble(dgUltimas[13,x].Value))).ToString());
											
											if(Convert.ToDouble(dgUltimas[16,x].Value)>factorLitros)
												dgUltimas[16,x].Style.BackColor=Color.Red;
											else
												dgUltimas[16,x].Style.BackColor=Color.MediumSpringGreen;
											
											
											dgUltimas[19,x].Value=decimales((Convert.ToDouble(dgUltimas[16,x].Value)*Convert.ToDouble(dgUltimas[18,x].Value)).ToString());
										}
									}
									catch(Exception)
									{
										//MessageBox.Show("Row: "+x);
									}
								}
							}
						}
						else
						{
							dgUltimas[12,x].Value="0";
							dgUltimas[12,x].Style.BackColor=Color.Red;
						}
					}
					
					#region OTROS
					
					if(dgUltimas[28,x].Value.ToString()!="")
					{
						dgUltimas[7,x].Style.BackColor=Color.MediumSpringGreen;
						dgUltimas[14,x].Style.BackColor=Color.MediumSpringGreen;
						dgUltimas[15,x].Style.BackColor=Color.MediumSpringGreen;
						dgUltimas[16,x].Style.BackColor=Color.MediumSpringGreen;
					}
					
					if(dgUltimas[30,x].Value.ToString()!="")
					{
						dgUltimas[12,x].Value="0";
						dgUltimas[12,x].Style.BackColor=Color.Red;
						
						dgUltimas[14,x].Value="";
						dgUltimas[15,x].Value="";
						dgUltimas[16,x].Value="";
						dgUltimas[19,x].Value="";
						
						dgUltimas[14,x].Style.BackColor=Color.White;
						dgUltimas[15,x].Style.BackColor=Color.White;
						dgUltimas[16,x].Style.BackColor=Color.White;
					}
					
					if(dgUltimas[32,x].Value.ToString()!="")
					{
						double litroDia2 = 0.0;
						bool ENCUENTRA = false;
						DateTime fecha_servicio = DateTime.Now;
						int contta = 0;
						int contta2 = 0;
						Int64 ID_INTEGRA = 0;
						
						
						Conexion_Servidor.SQL_Conexion connI = new Conexion_Servidor.SQL_Conexion();
						string consulta = "select TOP 10 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.FECHA_REG=(SELECT FECHA_REG FROM AUTORIZACION WHERE ID="+dgUltimas[32,x].Value.ToString()+") and A.ID_V=(SELECT ID_V FROM AUTORIZACION WHERE ID="+dgUltimas[32,x].Value.ToString()+")"; 
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							litroDia2 = litroDia2+Convert.ToDouble(conn.leer["LITROS"]);
							if(contta == 0)
							{
								fecha_servicio = Convert.ToDateTime(conn.leer["FECHA_REG"]);
								ID_INTEGRA = Convert.ToInt64(conn.leer["ID"]);
							}
							// ************ POSIBLE WHILE ***********
							if(conn.leer["INTEGRA"].ToString()!="")
							{
								String nuevaConslt = "select TOP 10 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.FECHA_REG=(SELECT FECHA_REG FROM AUTORIZACION WHERE ID="+conn.leer["INTEGRA"].ToString()+") and A.ID_V=(SELECT ID_V FROM AUTORIZACION WHERE ID="+conn.leer["INTEGRA"].ToString()+")";
								connI.getAbrirConexion(nuevaConslt);
								connI.leer=connI.comando.ExecuteReader();
								while(connI.leer.Read())
								{
									litroDia2 = litroDia2+Convert.ToDouble(connI.leer["LITROS"]);
									if(contta2 == 0)
									{
										fecha_servicio = Convert.ToDateTime(connI.leer["FECHA_REG"]);
										ID_INTEGRA = Convert.ToInt64(connI.leer["ID"]);
									}
									
									contta++;
								}
								connI.conexion.Close();
							}
							
							contta++;
							ENCUENTRA = true;
						}
						conn.conexion.Close();
						
						litroDia2 = litroDia2+Convert.ToDouble(dgUltimas[7,x].Value);
						
						if(ENCUENTRA==true)
						{
							getKmAnterior2Ultimas(ID_INTEGRA, x, fecha_servicio);
							
							dgUltimas[12,x].Value=(Convert.ToDouble(dgUltimas[8,x].Value)-Convert.ToDouble(dgUltimas[11,x].Value)).ToString();
							dgUltimas[14,x].Value=decimales((Convert.ToDouble(dgUltimas[12,x].Value)/litroDia2).ToString());
							
							try
							{
								if(dgUltimas[14,x].Value.ToString()!="")
								{
									if(Convert.ToDouble(dgUltimas[14,x].Value)<Convert.ToDouble(dgUltimas[13,x].Value)-(Convert.ToDouble(dgUltimas[13,x].Value)*(factorRend/100)))
									{
										dgUltimas[14,x].Style.BackColor=Color.Red;
									}
									else
									{
										dgUltimas[14,x].Style.BackColor=Color.MediumSpringGreen;
									}
									
									dgUltimas[15,x].Value=decimales(Convert.ToString((Convert.ToDecimal(dgUltimas[14,x].Value)/Convert.ToDecimal(dgUltimas[13,x].Value))*Convert.ToDecimal(100.0)));
									
									if(Convert.ToDouble(dgUltimas[15,x].Value)<factorEficiencia || Convert.ToDouble(dgUltimas[15,x].Value)>factorMaximoEf)
										dgUltimas[15,x].Style.BackColor=Color.Red;
									else
										dgUltimas[15,x].Style.BackColor=Color.MediumSpringGreen;
									
									dgUltimas[15,x].Value=dgUltimas[15,x].Value.ToString()+"%";
									
									dgUltimas[16,x].Value=decimales(((litroDia2)-(Convert.ToDouble(dgUltimas[12,x].Value)/Convert.ToDouble(dgUltimas[13,x].Value))).ToString());
									
									if(Convert.ToDouble(dgUltimas[16,x].Value)>factorLitros)
										dgUltimas[16,x].Style.BackColor=Color.Red;
									else
										dgUltimas[16,x].Style.BackColor=Color.MediumSpringGreen;
									
									
									dgUltimas[19,x].Value=decimales((Convert.ToDouble(dgUltimas[16,x].Value)*Convert.ToDouble(dgUltimas[18,x].Value)).ToString());
								}
							}
							catch(Exception)
							{
								//MessageBox.Show("Row: "+x);
							}
						}
						
						for(int v=0; v<dgUltimas.Rows.Count; v++)
						{
							if(dgUltimas[32,x].Value.ToString()==dgUltimas[0,v].Value.ToString())
							{
								dgUltimas[14,v].Value="";
								dgUltimas[15,v].Value="";
								dgUltimas[16,v].Value="";
								dgUltimas[19,v].Value="";
								
								dgUltimas[14,v].Style.BackColor=Color.Yellow;
								dgUltimas[15,v].Style.BackColor=Color.Yellow;
								dgUltimas[16,v].Style.BackColor=Color.Yellow;
							}
						}
					}
					
					if(dgUltimas[32,x].Value.ToString()=="" && dgUltimas[34,x].Value.ToString()!="")
					{						
						dgUltimas[14,x].Style.BackColor=Color.SkyBlue;
						dgUltimas[15,x].Style.BackColor=Color.SkyBlue;
						dgUltimas[16,x].Style.BackColor=Color.SkyBlue;
					}
					
					#endregion
				}
			}
		}
		
		void getKmAnteriorUltimas(Int64 ID_AUT, int rowInd, DateTime fecha_Serv)
		{		
			int cambio = 0;
			bool entraa = false;
			
			String consulta = 	"select TOP 10 A.* " +
								"from AUTORIZACION A, GASOLINERA G " +
								"WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V = (select ID_V from AUTORIZACION where ESTATUS!=0 and ID="+ID_AUT+") " +
											"and A.FECHA_BASE <= (select FECHA_BASE from AUTORIZACION  where ESTATUS!=0 and ID="+ID_AUT+") " +
								"order by A.FECHA_REG desc, A.NUMERO desc";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(dgUltimas[9,rowInd].Value!=null && dgUltimas[9,rowInd].Value.ToString()!="" && dgUltimas[11,rowInd].Value.ToString()=="")
				{
					if(cambio==1 && dgUltimas[11,rowInd].Value.ToString()=="" && dgUltimas[22,rowInd].Value.ToString()=="")
					{
						if(fecha_Serv>Convert.ToDateTime(conn.leer["FECHA_REG"]))
						{
							dgUltimas[11,rowInd].Value=conn.leer["KM"].ToString();
							entraa = true;
						}
						else if(fecha_Serv==Convert.ToDateTime(conn.leer["FECHA_REG"]))
						{
							if(Convert.ToDateTime(dgUltimas[9,rowInd].Value).Hour > ((conn.leer["HORA_CARGA"].ToString()=="")?0:Convert.ToDateTime((conn.leer["HORA_CARGA"].ToString())).Hour))
							{
								dgUltimas[11,rowInd].Value=conn.leer["KM"].ToString();
								entraa = true;
							}
						}
					}
					else if(cambio==2 && dgUltimas[11,rowInd].Value.ToString()=="" && dgUltimas[22,rowInd].Value.ToString()=="" && fecha_Serv==Convert.ToDateTime(conn.leer["FECHA_REG"]))
					{
						if(Convert.ToDateTime(dgUltimas[9,rowInd].Value).Hour > ((conn.leer["HORA_CARGA"].ToString()=="")?0:Convert.ToDateTime((conn.leer["HORA_CARGA"].ToString())).Hour))
						{
							dgUltimas[11,rowInd].Value=conn.leer["KM"].ToString();
							entraa = true;
						}
					}
					
					if(entraa == false)
					{
						if(fecha_Serv>Convert.ToDateTime(conn.leer["FECHA_REG"]))
						{
							dgUltimas[11,rowInd].Value=conn.leer["KM"].ToString();
							entraa=true;
						}
					}
					
					cambio++;
					
				}
			}
			conn.conexion.Close();
			
			if(cambio==1)
				dgUltimas[11,rowInd].Value="0";
			
			if(dgUltimas[11,rowInd].Value.ToString()=="")
				dgUltimas[11,rowInd].Value="0";
		}
		
		void getKmAnterior2Ultimas(Int64 ID_AUT, int rowInd, DateTime fecha_Serv)
		{
			int contt = 0;
			int contt2 = 0;
			DateTime primerFecha = DateTime.Now;
			double km_Ant = 0;
			
			String consulta = 	"select TOP 10 A.* " +
								"from AUTORIZACION A, GASOLINERA G " +
								"WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V = (select ID_V from AUTORIZACION where ESTATUS!=0 and ID="+ID_AUT+") " +
											"and A.FECHA_BASE <= (select FECHA_BASE from AUTORIZACION  where ESTATUS!=0 and ID="+ID_AUT+") " +
								"order by A.FECHA_REG desc, A.NUMERO desc";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(contt==0) 
				{
					primerFecha=Convert.ToDateTime(conn.leer["FECHA_REG"]);
					km_Ant=Convert.ToDouble(conn.leer["KM"]);
				}
				else
				{
					if(Convert.ToDateTime(conn.leer["FECHA_REG"])==primerFecha)
					{
						km_Ant=Convert.ToDouble(conn.leer["KM"]);
					}
					else if(Convert.ToDateTime(conn.leer["FECHA_REG"])<primerFecha && contt2==0)
					{
						km_Ant=Convert.ToDouble(conn.leer["KM"]);
						contt2++;
					}
				}
				
				contt++;
			}
			conn.conexion.Close();
			
			dgUltimas[11,rowInd].Value=km_Ant;
		}
		
		void getRendIdealUltimas(int rowInd)
		{
			String consulta = "select top 1 R.* from RENDIMIENTOS R, VEHICULO V, AUTORIZACION A WHERE A.ID_V=V.ID and R.ID_V=V.ID AND R.TIPO='"+((dgUltimas[13,rowInd].Value.ToString()=="MTTO")?"MANTENIMIENTO":dgUltimas[13,rowInd].Value.ToString())+"' AND A.ID="+dgUltimas[0,rowInd].Value.ToString();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
				dgUltimas[13,rowInd].Value=conn.leer["FACTOR"].ToString();
			else
				dgUltimas[13,rowInd].Value="0";
			
			conn.conexion.Close();		
		}
		
		String decimales(String dato)
		{
			String respuesta = dato;
			int punto = 0;
			
			for(int x=0; x<dato.Length; x++)
			{
				if(dato.Substring(x, 1)==".")
				{
					punto = x;
				}
			}
			
			if(punto>0)
			{
				if(punto+4<=dato.Length)
				{
					respuesta = dato.Substring(0,punto+4);
				}
				else if(punto+3<=dato.Length)
				{
					respuesta = dato.Substring(0,punto+3);
				}
				else if(punto+2<=dato.Length)
				{
					respuesta = dato.Substring(0,punto+2);
				}
			}
			
			return respuesta;
		}
		#endregion
		
		#region KM INICIAL
		void CbKmInicialCheckedChanged(object sender, EventArgs e)
		{
			if(cbKmInicial.Checked==true)
			{
				txtKmInicial.Enabled=true;
				cbKmInicial.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				txtKmInicial.Enabled=false;
				cbKmInicial.BackColor=Color.Transparent;
			}
		}
		
		void TxtKmInicialKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtKms.Text.Contains(".")==false))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void TxtKmInicialLeave(object sender, EventArgs e)
		{
			if(txtKmInicial.Text=="")
			{
				txtKmInicial.Text="0";
			}
		}
		
		/*void BtnGuardaInicialClick(object sender, EventArgs e)
		{
			if(dgAutorizacionValida.Rows.Count>0)
			{
				Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
				String consul = "update AUTORIZACION set KM_INICIAL='"+txtKmInicial.Text+"' where ID="+dgAutorizacionValida[0,0].Value.ToString();
				connM.getAbrirConexion(consul);
				connM.comando.ExecuteNonQuery();
				connM.conexion.Close();
				
				new Interfaz.FormMensaje("Kilometraje inicial guardado").Show();
				
				txtKmInicial.Text="0";
				cbKmInicial.Checked=false;
			}
		}*/
		#endregion
		
		#region LITROS A RECUPERAR
		void CbRecuperaCheckedChanged(object sender, EventArgs e)
		{
			if(cbRecupera.Checked==true)
			{
				txtRecupera.Enabled=true;
				txtRecupera.Text=lblLitros.Text;
				txtRecupera.BackColor=Color.Red;
				cbRecupera.BackColor=Color.MediumSpringGreen;
				txtComentarioRecupera.Enabled=true;
			}
			else
			{
				txtRecupera.Enabled=false;
				txtRecupera.Text="0";
				txtRecupera.BackColor=Color.White;
				cbRecupera.BackColor=Color.Transparent;
				txtComentarioRecupera.Enabled=false;
			}
		}
		
		/*void BtnRecuperaClick(object sender, EventArgs e)
		{
			if(dgAutorizacionValida.Rows.Count>0)
			{ 
				if(txtRecupera.Text!="" && txtRecupera.Text!="." && Convert.ToDouble(txtRecupera.Text)<=Convert.ToDouble(lblLitros.Text))
				{
					Conexion_Servidor.SQL_Conexion connM = new Conexion_Servidor.SQL_Conexion();
					String consul = "update AUTORIZACION set LT_RECUPERADOS='"+txtRecupera.Text+"' where ID="+dgAutorizacionValida[0,0].Value.ToString();
					connM.getAbrirConexion(consul);
					connM.comando.ExecuteNonQuery();
					connM.conexion.Close();
					
					new Interfaz.FormMensaje("litros por recuperar ha sido guardados").Show();
				
					txtRecupera.Text="0";
					txtRecupera.BackColor=Color.White;
					cbRecupera.Checked=false;
				}
				else
				{
					MessageBox.Show("Cantidad incorrecta");
				}
			}
		}*/
		
		void TxtRecuperaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtRecupera.Text.Contains(".")==false))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void TxtRecuperaKeyUp(object sender, KeyEventArgs e)
		{
			/*if(Convert.ToDouble(txtRecupera.Text)>Convert.ToDouble(lblLitros.Text))
			{
				//MessageBox.Show("Es una cantidad mayor a la pérdida generada por el operador de "+lblLitros.Text+" Litros.");
				//txtRecupera.Text="0";
				txtComentarioRecupera.Enabled=true;
				txtComentarioRecupera.Text="Comentario";
				txtComentarioRecupera.BackColor=Color.White;
				//txtComentarioRecupera.Focus();
				//txtComentarioRecupera.SelectAll();
			}
			else if(Convert.ToDouble(txtRecupera.Text)<Convert.ToDouble(lblLitros.Text)) //&& (txtComentarioRecupera.Text=="" || txtComentarioRecupera.Text=="Comentario"))
			{
				//MessageBox.Show("Es necesario ingrese comentario");
				txtComentarioRecupera.Enabled=true;
				txtComentarioRecupera.BackColor=Color.Yellow;
				//txtComentarioRecupera.Focus();
				//txtComentarioRecupera.SelectAll();
			}
			else
			{
				txtComentarioRecupera.Enabled=false;
				txtComentarioRecupera.Text="Comentario";
				txtComentarioRecupera.BackColor=Color.White;
			}*/
		}
		
		void TxtRecuperaLeave(object sender, EventArgs e)
		{
			if(txtRecupera.Text=="")
			{
				txtRecupera.Text="0";
			}
		}
		#endregion
		
		#region GET FACTORES
		void getFactor()
		{
			String consulta = "select * from FACTOR_COBRO where ESTATUS='1'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["NOMBRE"].ToString()=="LITROS")
					factorLitros=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="EFICIENCIA")
					factorEficiencia=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="RENDIMIENTO")
					factorRend=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="KM")
					factorKm=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="MAYOR_EFICIENCIA")
					factorMaximoEf=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="MAYOR_KM")
					factorMaximoKm=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="MINIMO_ET")
					factorETMin=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="MAXIMO_ET")
					factorETMaxi=Convert.ToDouble(conn.leer["FACTOR"]);
				
				if(conn.leer["NOMBRE"].ToString()=="LITROS_TICKETS")
					factorLitTikets=Convert.ToDouble(conn.leer["FACTOR"]);
				
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		#region ANULACION DE CALCULOS
		void CbAnularCheckedChanged(object sender, EventArgs e)
		{
			if(cbAnular.Checked==true)
			{
				cmbAnular.Enabled=true;
				
				lblRendimiento.Text="0";
				lblEficiencia.Text="0";
				lblLitros.Text="0";
				
				lblRendimiento.BackColor=Color.LightGray;
				lblEficiencia.BackColor=Color.LightGray;
				lblSimboloPorcent.BackColor=Color.LightGray;
				lblLitros.BackColor=Color.LightGray;
				
				cbAnular.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				cmbAnular.Enabled=false;
				getRendimiento();
				cbAnular.BackColor=Color.Transparent;
			}
		}
		#endregion
		
		#region POST-ANALISIS
		void CbPostAnalisisCheckedChanged(object sender, EventArgs e)
		{
			if(cbPostAnalisis.Checked==true)
			{
				cbPostAnalisis.BackColor=Color.MediumSpringGreen;
			}
			else
			{
				cbPostAnalisis.BackColor=Color.Transparent;
			}
		}
		#endregion
		
		void BtnBrincoClick(object sender, EventArgs e)
		{
			gbCargas.Enabled=true;
		}
		
		#endregion
		
		#region [ PUNTOS MUERTOS ]
		
		#region COLOR MOVIMIENTOS VALIDADOS
		void colorValidado()
		{
			for(int x=0; x<dgValidado.Rows.Count; x++)
			{
				for(int y=0; y<dgMovimientosRutas.Rows.Count; y++)
				{
					if(dgValidado[1,x].Value.ToString()==dgMovimientosRutas[0,y].Value.ToString())
					{
						if(rbValidados.Checked==true)
						{
							for(int z=0; z<dgMovimientosRutas.Columns.Count; z++)
							{
								dgMovimientosRutas[z,y].Style.BackColor=Color.MediumSpringGreen;
							}
						}
						else
						{
							dgMovimientosRutas.Rows.RemoveAt(y);
						}
					}
				}
			}
			
			for(int y=0; y<dgMovimientosRutas.Rows.Count; y++)
			{
				String consulta = "select * from REVISION_VIAJES where ID_O="+dgMovimientosRutas[0,y].Value.ToString()+" and ESTATUS='1'";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					for(int z=0; z<dgMovimientosRutas.Columns.Count; z++)
					{
						dgMovimientosRutas[z,y].Style.BackColor=Color.Red;
					}
				}
				
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region GET DATOS VALIDADOS
		public void getValidado(Int64 ID_VE, int tipo)
		{
			dgValidado.Rows.Clear();
			
			String consulta = "SELECT * FROM RELACION_MOVIMIENTO WHERE ID_A="+dgAutorizacionValida[0,dgAutorizacionValida.CurrentRow.Index].Value.ToString()+" and (ESTATUS='1' OR ESTATUS='2') ORDER BY ORDEN, FECHA, HORA";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgValidado.Rows.Add(conn.leer["ID"].ToString(), 
				                    conn.leer["ID_R"].ToString(), 
				                    conn.leer["TIPO"].ToString(), 
				                    "", 
				                    "",
				                    "", 
				                    conn.leer["FECHA"].ToString().Substring(0,10), 
				                    "",
				                    conn.leer["HORA"].ToString().Substring(0,5), 
				                    conn.leer["COMENTARIO"].ToString(), 
				                    conn.leer["ESTATUS"].ToString(), 
				                    "", 
				                    "0",
				                    "0");
			}
			
			conn.conexion.Close();
			
			dgValidado.ClearSelection();
			seleccion=0;
			
			if(dgValidado.Rows.Count>0)
			{
				for(int x=0; x<dgValidado.Rows.Count; x++)
				{
					if(dgValidado[2,x].Value.ToString()=="VIAJE")
					{
						consulta = "select O.id_operacion, O.fecha, O.turno, R.Kilometros, R.Sentido, R.Nombre, OP.Alias, C.Empresa, V.Numero from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, VEHICULO V where O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and OO.id_vehiculo=V.ID and O.id_ruta=R.ID and R.IdSubEmpresa=C.ID and O.estatus='1' and O.id_operacion='"+dgValidado[1,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							dgValidado[3,x].Value=conn.leer["Nombre"].ToString();
							dgValidado[4,x].Value=conn.leer["Sentido"].ToString();
							dgValidado[5,x].Value=conn.leer["Empresa"].ToString();
							dgValidado[7,x].Value=conn.leer["turno"].ToString();
						}
				
						conn.conexion.Close();
					}
					else
					{
						consulta = "SELECT * FROM RELACION_UBICACION where ID="+dgValidado[1,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							dgValidado[3,x].Value=conn.leer["NOMBRE"].ToString();
							dgValidado[4,x].Value="-";
							dgValidado[5,x].Value="-";
							dgValidado[7,x].Value="-";
						}
						
						conn.conexion.Close();
					}
				}
			}
			
			if(tipo==1)
			{
				colorValidado();
			}
			
			colorVacios();
			
			dgMovimientosRutas.ClearSelection();
		}
		#endregion
		
		#region GUARDA REGISTRO DE VALIDADOS
		public void agregaValidado()
		{
			String consulta="";
			
			consulta = "SELECT TOP 1 * FROM RELACION_MOVIMIENTO WHERE ID_A="+dgAutorizacionValida[0,dgAutorizacionValida.CurrentRow.Index].Value.ToString()+" and (ESTATUS='1' OR ESTATUS='2') order by ID desc";
			
			/*****/
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgValidado.Rows.Add(conn.leer["ID"].ToString(), 
				                    conn.leer["ID_R"].ToString(), 
				                    conn.leer["TIPO"].ToString(), 
				                    "", 
				                    "",
				                    "", 
				                    conn.leer["FECHA"].ToString().Substring(0,10), 
				                    "",
				                    conn.leer["HORA"].ToString().Substring(0,5), 
				                    conn.leer["COMENTARIO"].ToString(), 
				                    conn.leer["ESTATUS"].ToString(), 
				                    "", 
				                    "0",
				                    "0");
			}
			conn.conexion.Close();
			/*****/
			
			dgValidado.ClearSelection();
			seleccion=0;
			
			if(dgValidado.Rows.Count>0)
			{
				for(int x=0; x<dgValidado.Rows.Count; x++)
				{
					if(dgValidado[2,x].Value.ToString()=="VIAJE")
					{
						consulta = "select O.id_operacion, O.fecha, O.turno, R.Kilometros, R.Sentido, R.Nombre, OP.Alias, C.Empresa, V.Numero from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, VEHICULO V where O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and OO.id_vehiculo=V.ID and O.id_ruta=R.ID and R.IdSubEmpresa=C.ID and O.estatus='1' and O.id_operacion='"+dgValidado[1,x].Value.ToString()+"'";
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							dgValidado[3,x].Value=conn.leer["Nombre"].ToString();
							dgValidado[4,x].Value=conn.leer["Sentido"].ToString();
							dgValidado[5,x].Value=conn.leer["Empresa"].ToString();
							dgValidado[7,x].Value=conn.leer["turno"].ToString();
						}
				
						conn.conexion.Close();
					}
					else
					{
						consulta = "SELECT * FROM RELACION_UBICACION where ID="+dgValidado[1,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							dgValidado[3,x].Value=conn.leer["NOMBRE"].ToString();
							dgValidado[4,x].Value="-";
							dgValidado[5,x].Value="-";
							dgValidado[7,x].Value="-";
						}
						
						conn.conexion.Close();
					}
				}
			}
			
			
			colorValidado();
			colorVacios();
			
			dgMovimientosRutas.ClearSelection();
		}
		#endregion
		
		#region GET CASA O GASOLINERA
		void CmdCasaClick(object sender, EventArgs e)
		{
			Int64 idC=0;
			bool entra=false;
			
			String consulta = "select ID from RELACION_UBICACION where ESTATUS='1' and TIPO='VIVIENDA' and NOMBRE='"+txtOperadorValidacion.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				entra=true;
				idC=Convert.ToInt64(conn.leer["ID"]);
			}
			
			conn.conexion.Close();
			
			if(entra)
			{
				Valida(idC, Convert.ToInt64(dgAutorizacionValida[11,dgAutorizacionValida.CurrentRow.Index].Value),"VACIO", "", DateTime.Now.ToString("dd/MM/yyyy"), "00:00");
				agregaValidado();
			}
		}
		
		void CmdGasolineraClick(object sender, EventArgs e)
		{
			getGasolinera();
		}
		
		void getGasolinera()
		{
			Int64 idG=0;
			bool entra=false;
			
			String consulta = "select R.ID, R.NOMBRE from RELACION_UBICACION R, AUTORIZACION A, OPERADOR O, GASOLINERA G where R.ID_R=G.ID and R.TIPO='GASOLINERA' and A.ID_O=O.ID and A.ID_G=G.ID and Alias='"+txtOperadorValidacion.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				entra=true;
				idG=Convert.ToInt64(conn.leer["ID"]);
			}
			
			conn.conexion.Close();
			
			if(entra)
			{
				Valida(idG, Convert.ToInt64(dgAutorizacionValida[11,dgAutorizacionValida.CurrentRow.Index].Value),"VACIO", "", DateTime.Now.ToString("dd/MM/yyyy"), "00:00");
				
				agregaValidado();
			}
		}
		#endregion
		
		#region CALCULO DE KILOMETROS
		void CmdCalcularKmClick(object sender, EventArgs e)
		{
			calculoKm();
		}
		
		void calculoKm()
		{
			#region GET IDS
			for(int x=0; x<dgValidado.Rows.Count; x++)
			{
				if(dgValidado[2,x].Value.ToString()=="VIAJE")
				{
					String consulta = "select ID from RELACION_UBICACION where TIPO='RUTA' and ID_R in (select id_ruta from OPERACION where id_operacion="+dgValidado[1,x].Value.ToString()+")";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgValidado[11,x].Value=conn.leer["ID"].ToString();
					}
					else
					{
						dgValidado[11,x].Value="0";
						dgValidado[11,x].Style.BackColor=Color.Red;
					}
					conn.conexion.Close();
					
					consulta = "select Kilometros from RUTA where ID in (select id_ruta from OPERACION where id_operacion="+dgValidado[1,x].Value.ToString()+")";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgValidado[13,x].Value=conn.leer["Kilometros"].ToString();
					}
					else
					{
						dgValidado[13,x].Value="0";
						dgValidado[13,x].Style.BackColor=Color.Red;
					}
					conn.conexion.Close();
				}
				else if(dgValidado[2,x].Value.ToString()=="VACIO")
				{
					dgValidado[11,x].Value=dgValidado[1,x].Value.ToString();
					dgValidado[13,x].Value="0";
				}
			}
			#endregion
			
			#region GET KMS
			for(int x=1; x<dgValidado.Rows.Count; x++)
			{
				String consulta = "select * from MOVIMIENTO where ID_X='"+dgValidado[11,x-1].Value.ToString()+"' and ID_Y='"+dgValidado[11,x].Value.ToString()+"' ";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgValidado[12,x].Value=conn.leer["KM"].ToString();
				}
				conn.conexion.Close();
			}
			#endregion
			
			#region SUMA DE KMS
			double sumaVacio = 0.0;
			double sumaRuta = 0.0;
			double sumaTotal = 0.0;
			for(int x=0; x<dgValidado.Rows.Count; x++)
			{
				sumaVacio=sumaVacio+Convert.ToDouble(dgValidado[12,x].Value);
				sumaRuta=sumaRuta+Convert.ToDouble(dgValidado[13,x].Value);
				sumaTotal=sumaTotal+Convert.ToDouble(dgValidado[12,x].Value)+Convert.ToDouble(dgValidado[13,x].Value);
			}
			
			lblKmVacio.Text=sumaVacio.ToString();
			lblKmRuta.Text=sumaRuta.ToString();
			lblKmTotal.Text=sumaTotal.ToString();
			#endregion
		}
		#endregion
		
		#region GET AUTOMATICO
		void CmdTodoClick(object sender, EventArgs e)
		{
			if(validaCompleta())
			{
				eventoTodos();
			}
			else
			{
				DialogResult rs2 = MessageBox.Show("Es necesario validar todos lo viajes. ¿Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (DialogResult.Yes==rs2)
				{
					eventoTodos();
				}
			}
		}
		
		void eventoTodos()
		{
			for(int x=0; x<dgValidado.Rows.Count; x++)
			{
				
			}
		}
		
		bool validaCompleta()
		{
			bool respuesta = true;
			
			if(dgMovimientosRutas.Rows.Count>0)
			{
				for(int x=0; x<dgMovimientosRutas.Rows.Count;  x++)
				{
					if(dgMovimientosRutas[8,x].Style.BackColor!=Color.MediumSpringGreen && dgMovimientosRutas[8,x].Style.BackColor!=Color.Yellow)
					{
						respuesta = false;
					}
				}
			}
			
			return respuesta;
		}
		
		#region OBTIENE LAS GASOLINERAS REGISTRADAS		
		void getGasolineraReg(String consulta, String fechaa , int tipo, string HORAA)
		{
			Int64 idG=0;
			string hora = "00:00";
			bool entra=false;
			
			if(tipo==1)
			{
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					entra=true;
					idG = Convert.ToInt64(conn.leer["ID_G"]);
					hora = conn.leer["hora"].ToString();
				}
				
				conn.conexion.Close();
			}
			else
			{
				idG=Convert.ToInt64(consulta);
				hora = HORAA;
				entra=true;
			}
			
			if(entra==true)
			{
				Valida(idG, Convert.ToInt64(dgAutorizacionValida[11,dgAutorizacionValida.CurrentRow.Index].Value),"VACIO", "", fechaa, hora);
				agregaValidado();
			}
		}
		#endregion
		
		#region	MUEVE FILA
		void mueveFila(int indice)
		{
			String ID_N, EMPRESA_N, RUTA_N, FECHA_N, HORA_N, TURNO_N, SENTIDO_N, OPERADOR_N, UNIDAD_N;
			
			ID_N 		= dgMovimientosRutas[0,(indice-1)].Value.ToString();
			EMPRESA_N 	= dgMovimientosRutas[1,(indice-1)].Value.ToString();
			RUTA_N 		= dgMovimientosRutas[2,(indice-1)].Value.ToString();
			FECHA_N 	= dgMovimientosRutas[3,(indice-1)].Value.ToString();
			HORA_N 		= dgMovimientosRutas[4,(indice-1)].Value.ToString();
			TURNO_N 	= dgMovimientosRutas[5,(indice-1)].Value.ToString();
			SENTIDO_N 	= dgMovimientosRutas[6,(indice-1)].Value.ToString();
			OPERADOR_N	= dgMovimientosRutas[7,(indice-1)].Value.ToString();
			UNIDAD_N 	= dgMovimientosRutas[8,(indice-1)].Value.ToString();
			
			for(int x=0; x<dgMovimientosRutas.Columns.Count-2; x++)
			{
				dgMovimientosRutas[x,indice-1].Value=dgMovimientosRutas[x,indice].Value.ToString();
			}	
			
			dgMovimientosRutas[0,indice].Value = ID_N;
			dgMovimientosRutas[1,indice].Value = EMPRESA_N;
			dgMovimientosRutas[2,indice].Value = RUTA_N;
			dgMovimientosRutas[3,indice].Value = FECHA_N;
			dgMovimientosRutas[4,indice].Value = HORA_N;
			dgMovimientosRutas[5,indice].Value = TURNO_N;
			dgMovimientosRutas[6,indice].Value = SENTIDO_N;
			dgMovimientosRutas[7,indice].Value = OPERADOR_N;
			dgMovimientosRutas[8,indice].Value = UNIDAD_N;
		}
		#endregion
		#endregion
		
		#endregion
		
		//*********************************************************************************************************************************
		//******************************************************* HISTORIAL ***************************************************************
		//********************************************************************************************************************************* 
		
		#region [ HISTORIAL ]
		#region HISTORIAL
		void DtpFechaHistorialValueChanged(object sender, EventArgs e)
		{
			getHistorialAut();
		}
		
		void CmdMuestraClick(object sender, EventArgs e)
		{
			getHistorialAut();
		}
		
		public void getHistorialAut()
		{
			listAut = new Conexion_Servidor.Combustible.SQL_Combustible().getAutorizaciones(dtpFechaHistorial.Value.ToString("dd/MM/yyyy"));
			
			dgHistorial.Rows.Clear();
			
			String consulta = "";
			
			if(cbTodo.Checked==false)
			{
				consulta = "select V.ID, V.Numero, V.Tipo_Unidad, A.estatus from VEHICULO V, ASIG_UNIDAD A where V.ID=A.ID_UNIDAD and V.Estado='1' and V.ID not in (select ID_V from AUTORIZACION A, VEHICULO V where A.ESTATUS!=0 and A.ID_V=V.ID and FECHA_BASE='"+dtpFechaHistorial.Value.ToString("dd/MM/yyyy")+"') order by V.Tipo_Unidad, V.Numero";
			}
			else
			{
				consulta = "select V.ID, V.Numero, V.Tipo_Unidad, A.estatus from VEHICULO V, ASIG_UNIDAD A where V.ID=A.ID_UNIDAD and V.Estado='1' order by V.Tipo_Unidad, V.Numero";
			}
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgHistorial.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString(), conn.leer["Tipo_Unidad"].ToString(), "", "", "", "", "", "", "", "", "", conn.leer["estatus"].ToString());
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgHistorial.Rows.Count; x++)
			{
				if(dgHistorial[12,x].Value.ToString()=="A")
				{
					dgHistorial[12,x].Value="ACTIVO";
					dgHistorial[12,x].Style.BackColor=Color.MediumSpringGreen;
				}
				else if(dgHistorial[12,x].Value.ToString()=="T")
				{
					dgHistorial[12,x].Value="TALLER";
					dgHistorial[12,x].Style.BackColor=Color.Yellow;
				}
				else if(dgHistorial[12,x].Value.ToString()=="E")
				{
					dgHistorial[12,x].Value="ESPECIAL";
					dgHistorial[12,x].Style.BackColor=Color.Yellow;
				}
				else if(dgHistorial[12,x].Value.ToString()=="P")
				{
					dgHistorial[12,x].Value="PERMISO";
					dgHistorial[12,x].Style.BackColor=Color.Yellow;
				}
			}
						
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
							dgHistorial[6,x].Value=listAut[y].HORA_A.Substring(0,5);
							dgHistorial[7,x].Value=listAut[y].LITROS;
							dgHistorial[8,x].Value=listAut[y].KM;
							dgHistorial[9,x].Value=listAut[y].HORA_C;
							dgHistorial[11,x].Value=listAut[y].PERMISO;
						}
					}
				}
			}
			
			for(int x=0; x<dgHistorial.Rows.Count; x++)
			{
				consulta = "select * from REPORTE_CARGAS where ID_V='"+dgHistorial[0,x].Value.ToString()+"' and FECHA='"+dtpFechaHistorial.Value.ToString("dd/MM/yyyy")+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgHistorial[11,x].Value=conn.leer["CONCEPTO"].ToString();
					dgHistorial[11,x].Style.BackColor=Color.Red;
				}
				conn.conexion.Close();
				
				
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
			}
		}
		
		void CbTodoCheckedChanged(object sender, EventArgs e)
		{
			getHistorialAut();
		}
		#endregion
		
		#region JUSTIFICA
		void CmdJustificaClick(object sender, EventArgs e)
		{
			/*if(dgHistorial.SelectedRows.Count!=0)
			{
				new FormJustifica(this).ShowDialog();
			}
			else
			{
				MessageBox.Show("Seleccione un registro");
			}*/
		}
		#endregion
		#endregion
		
		//*********************************************************************************************************************************
		//******************************************************** REPORTE ****************************************************************
		//********************************************************************************************************************************* 
		
		#region [ REPORTE ]
		
		#region GET DATOS REPORTE
		void getReporte()
		{
			dgReporte.Rows.Clear();
			
			String consulta = "SELECT A.*, U.usuario, O.tipo_empleado FROM AUTORIZACION A, VEHICULO V, OPERADOR O, USUARIO U WHERE U.id_usuario=A.ID_U AND A.ESTATUS!=0 and A.FECHA_REG BETWEEN '"+dtpRepIni.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpRepFin.Value.ToString("dd/MM/yyyy")+"' AND A.ID_V=V.ID AND A.ID_O=O.ID AND O.Alias LIKE '%"+txtRepOperador.Text+"%' AND V.Numero LIKE '%"+txtRepUnidad.Text+"%' order by V.Numero, A.FECHA_REG, A.Numero ";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgReporte.Rows.Add(conn.leer["ID"].ToString(), 
				                   getNumeroValidacion(Convert.ToInt64(conn.leer["Numero"]), 
				                   Convert.ToDateTime(conn.leer["FECHA_REG"])), 
				                   conn.leer["ID_V"].ToString(),  
				                   conn.leer["ID_G"].ToString(), 
				                   conn.leer["ID_O"].ToString(), 
				                   conn.leer["FECHA_BASE"].ToString().Substring(0,10), 
				                   conn.leer["HORA_AUTORIZACION"].ToString().Substring(0,5), 
				                   conn.leer["LITROS"].ToString(), conn.leer["KM"].ToString(), 
				                   conn.leer["HORA_CARGA"].ToString(), 
				                   Convert.ToDouble(conn.leer["KM_ET"]),
				                   conn.leer["KM_INICIAL"].ToString(), 
				                   "",
				                   0.0,
				                   conn.leer["RENDIMIENTO"].ToString(), 
				                   0.0,
				                   0.0,
				                   0.0,
				                   conn.leer["ID_COM"].ToString(), 
				                   "", 
				                   "", 
				                   "", 
				                   ((conn.leer["HR_DATOS"].ToString()=="")?"":conn.leer["HR_DATOS"].ToString().Substring(0,5)), 
				                   conn.leer["PERMISO"].ToString(), 
				                   conn.leer["TIPO"].ToString(),  
				                   conn.leer["COMENTARIO"].ToString(), 
				                   "", 
				                   "", 
				                   conn.leer["usuario"].ToString().ToUpper(), 
				                   conn.leer["LT_RECUPERADOS"].ToString(), 
				                   "",
				                   conn.leer["ANULADO"].ToString(), 
				                   conn.leer["tipo_empleado"].ToString().ToUpper(), 
				                   conn.leer["INTEGRA"].ToString(), 
				                   conn.leer["TIPO_INTEGRA"].ToString(), 
				                   conn.leer["ANALISIS"].ToString());
			}
			conn.conexion.Close();
			
			
			for(int x=0; x<dgReporte.Rows.Count; x++)
			{
				if(dgReporte[3,x]==null || dgReporte[4,x].Value.ToString()!="")
				{
					consulta = "select NOMBRE from GASOLINERA where ID='"+dgReporte[3,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgReporte[3,x].Value=conn.leer["NOMBRE"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgReporte[2,x].Value.ToString()!="")
				{
					consulta = "select * from VEHICULO where ID='"+dgReporte[2,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgReporte[2,x].Value=conn.leer["Numero"].ToString();
						dgReporte[26,x].Value=conn.leer["tipo_unidad"].ToString();
						dgReporte[27,x].Value=conn.leer["Marca"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgReporte[4,x].Value.ToString()!="")
				{
					consulta = "select Alias from OPERADOR where ID='"+dgReporte[4,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgReporte[4,x].Value=conn.leer["Alias"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgReporte[18,x].Value.ToString()!="")
				{
					consulta = "SELECT P.ID, T.NOMBRE, P.PRECIO FROM TIPOS_COMB T, PRECIOS_COMB P WHERE T.ID=P.ID_TC AND P.ID = '"+dgReporte[18,x].Value.ToString()+"'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgReporte[18,x].Value=conn.leer["NOMBRE"].ToString();
						dgReporte[19,x].Value=conn.leer["PRECIO"].ToString();
					}
					conn.conexion.Close();
				}
				
				if(dgReporte[29,x].Value.ToString()!="")
				{
					dgReporte[30,x].Value=(Convert.ToDouble(dgReporte[29,x].Value)*Convert.ToDouble(dgReporte[19,x].Value));
				}
			}
			
			calculaRendimiento();
			dgReporte.ClearSelection();
		}
		#endregion
		
		#region FILTROS
		void TxtRepUnidadKeyUp(object sender, KeyEventArgs e)
		{
			//getReporte();
		}
		
		void TxtRepOperadorKeyUp(object sender, KeyEventArgs e)
		{
			//getReporte();
		}
		
		void DtpRepIniValueChanged(object sender, EventArgs e)
		{
			dtpRepFin.Value=dtpRepIni.Value;
		}
		
		void DtpRepFinValueChanged(object sender, EventArgs e)
		{
			//getReporte();
		}
		#endregion
		
		#region RENDIMIENTOS
		void calculaRendimiento()
		{
			getFactor();
			
			if(dgReporte.Rows.Count>0)
			{
				double litroDia = 0.0;
				for(int x=0; x<dgReporte.Rows.Count; x++)
				{
					//double litroDia = 0.0;
					getKmAnterior(Convert.ToInt64(dgReporte[0,x].Value), x, Convert.ToDateTime(dgReporte[5,x].Value));
					getRendIdeal(x);
					
					if(dgReporte[7,x].Value.ToString()!="")
					{
						dgReporte[21,x].Value=decimales((Convert.ToDouble(dgReporte[7,x].Value)*Convert.ToDouble(dgReporte[19,x].Value)).ToString());
						
						if(dgReporte[11,x].Value.ToString()!="0" && dgReporte[14,x].Value.ToString()!="0")
						{
							// ********************************************* VALIDA CARGA MISMO DIA *******************************************
							// ****************************************************************************************************************
							// ****************************************************************************************************************
							if(cbIntegracion.Checked==false)
							{
								if(x==0 || dgReporte[2,x-1].Value.ToString()!=dgReporte[2,x].Value.ToString() || Convert.ToDateTime(dgReporte[5,x-1].Value)<Convert.ToDateTime(dgReporte[5,x].Value) || dgReporte[3,x-1].Value.ToString()=="")// || dgReporte[12,x-1].Value.ToString()=="")
								{
									litroDia = 0.0;
									//litroDia = (Convert.ToDouble(dgReporte[7,x].Value)-((dgReporte[28,x].Value.ToString()=="")?0.0:Convert.ToDouble(dgReporte[28,x].Value)));
									litroDia = Convert.ToDouble(dgReporte[7,x].Value);
									
									dgReporte[12,x].Value=decimales((Convert.ToDouble(dgReporte[8,x].Value)-Convert.ToDouble(dgReporte[11,x].Value)).ToString());
									
									if(dgReporte[10,x].Value.ToString()!="0")
										dgReporte[13,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)-Convert.ToDouble(dgReporte[10,x].Value)).ToString()));
									else
										dgReporte[13,x].Value=0.0;
									
									if(Convert.ToDouble(dgReporte[13,x].Value)<-factorETMin) 
										dgReporte[13,x].Style.BackColor=Color.LightSkyBlue;
									else if (Convert.ToDouble(dgReporte[13,x].Value)>factorETMaxi)
										dgReporte[13,x].Style.BackColor=Color.Red;
									else
										dgReporte[13,x].Style.BackColor=Color.White;
									
									dgReporte[15,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)/(Convert.ToDouble(dgReporte[7,x].Value))).ToString()));
									
									try
									{
										if(dgReporte[15,x].Value.ToString()!="")
										{
											if(Convert.ToDouble(dgReporte[15,x].Value)<Convert.ToDouble(dgReporte[14,x].Value)-(Convert.ToDouble(dgReporte[14,x].Value)*(factorRend/100)))
											{
												dgReporte[15,x].Style.BackColor=Color.Red;
											}
											else
											{
												dgReporte[15,x].Style.BackColor=Color.MediumSpringGreen;
											}
											
											//*********************
											
											dgReporte[16,x].Value=Convert.ToDouble(decimales(Convert.ToString((Convert.ToDecimal(dgReporte[15,x].Value)/Convert.ToDecimal(dgReporte[14,x].Value))*Convert.ToDecimal(100.0))));
											
											if(Convert.ToDouble(dgReporte[16,x].Value)<factorEficiencia || Convert.ToDouble(dgReporte[16,x].Value)>factorMaximoEf)
												dgReporte[16,x].Style.BackColor=Color.Red;
											else
												dgReporte[16,x].Style.BackColor=Color.MediumSpringGreen;
											
											//dgReporte[16,x].Value=dgReporte[16,x].Value.ToString()+"%";
											
											//*********************	
											
											//dgReporte[16,x].Value=decimales(((Convert.ToDouble(dgReporte[7,x].Value)-((dgReporte[28,x].Value.ToString()=="")?0.0:Convert.ToDouble(dgReporte[28,x].Value)))-(Convert.ToDouble(dgReporte[12,x].Value)/Convert.ToDouble(dgReporte[13,x].Value))).ToString());
											dgReporte[17,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[7,x].Value)-(Convert.ToDouble(dgReporte[12,x].Value)/Convert.ToDouble(dgReporte[14,x].Value))).ToString()));
											
											if(Convert.ToDouble(dgReporte[17,x].Value)>factorLitros)
												dgReporte[17,x].Style.BackColor=Color.Red;
											else
												dgReporte[17,x].Style.BackColor=Color.MediumSpringGreen;
											
											
											dgReporte[20,x].Value=decimales((Convert.ToDouble(dgReporte[17,x].Value)*Convert.ToDouble(dgReporte[19,x].Value)).ToString());
										}
									}
									catch(Exception)
									{
										//MessageBox.Show("Row: "+x);
									}
								}
								else
								{
									if(Convert.ToDateTime(dgReporte[5,x-1].Value)==Convert.ToDateTime(dgReporte[5,x].Value))// || dgReporte[32,x].Value.ToString()!="")
									{
										dgReporte[11,x].Value=dgReporte[11,x-1].Value;
										dgReporte[15,x-1].Value=0.0;
										dgReporte[16,x-1].Value=0.0;
										dgReporte[17,x-1].Value=0.0;
										dgReporte[20,x-1].Value="";
										
										dgReporte[15,x-1].Style.BackColor=Color.Yellow;
										dgReporte[16,x-1].Style.BackColor=Color.Yellow;
										dgReporte[17,x-1].Style.BackColor=Color.Yellow;
										
										dgReporte[12,x].Value=decimales((Convert.ToDouble(dgReporte[8,x].Value)-Convert.ToDouble(dgReporte[11,x].Value)).ToString());
										
										if(dgReporte[10,x].Value.ToString()!="0")
											dgReporte[13,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)-Convert.ToDouble(dgReporte[10,x].Value)).ToString()));
										else
											dgReporte[13,x].Value=0.0;
										
										if(Convert.ToDouble(dgReporte[13,x].Value)<-factorETMin)// || Convert.ToDouble(dgReporte[13,x].Value)>factorETMaxi)
											dgReporte[13,x].Style.BackColor=Color.LightSkyBlue;
										else if (Convert.ToDouble(dgReporte[13,x].Value)>factorETMaxi)
											dgReporte[13,x].Style.BackColor=Color.Red;
										else
											dgReporte[13,x].Style.BackColor=Color.White;
										
										litroDia = litroDia+(Convert.ToDouble(dgReporte[7,x].Value));
										
										dgReporte[15,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)/litroDia).ToString()));
										
										try
										{
											if(dgReporte[15,x].Value.ToString()!="")
											{
												if(Convert.ToDouble(dgReporte[15,x].Value)<Convert.ToDouble(dgReporte[14,x].Value)-(Convert.ToDouble(dgReporte[14,x].Value)*(factorRend/100)))
												{
													dgReporte[15,x].Style.BackColor=Color.Red;
												}
												else
												{
													dgReporte[15,x].Style.BackColor=Color.MediumSpringGreen;
												}
												
												//*********************
												
												dgReporte[16,x].Value=Convert.ToDouble(decimales(Convert.ToString((Convert.ToDecimal(dgReporte[15,x].Value)/Convert.ToDecimal(dgReporte[14,x].Value))*Convert.ToDecimal(100.0))));
												
												if(Convert.ToDouble(dgReporte[16,x].Value)<factorEficiencia || Convert.ToDouble(dgReporte[16,x].Value)>factorMaximoEf)
													dgReporte[16,x].Style.BackColor=Color.Red;
												else
													dgReporte[16,x].Style.BackColor=Color.MediumSpringGreen;
												
												//dgReporte[16,x].Value=dgReporte[16,x].Value.ToString()+"%";
												
												//*********************	
												
												dgReporte[17,x].Value=Convert.ToDouble(decimales((litroDia-(Convert.ToDouble(dgReporte[12,x].Value)/Convert.ToDouble(dgReporte[14,x].Value))).ToString()));
												
												if(Convert.ToDouble(dgReporte[17,x].Value)>factorLitros)
													dgReporte[17,x].Style.BackColor=Color.Red;
												else
													dgReporte[17,x].Style.BackColor=Color.MediumSpringGreen;
												
												
												dgReporte[20,x].Value=decimales((Convert.ToDouble(dgReporte[17,x].Value)*Convert.ToDouble(dgReporte[19,x].Value)).ToString());
											}
										}
										catch(Exception)
										{
											//MessageBox.Show("Row: "+x);
										}
									}
								}
							}
							else
							{
								litroDia = 0.0;
								//litroDia = (Convert.ToDouble(dgReporte[7,x].Value)-((dgReporte[28,x].Value.ToString()=="")?0.0:Convert.ToDouble(dgReporte[28,x].Value)));
								litroDia = Convert.ToDouble(dgReporte[7,x].Value);
								
								dgReporte[12,x].Value=decimales((Convert.ToDouble(dgReporte[8,x].Value)-Convert.ToDouble(dgReporte[11,x].Value)).ToString());
								
								if(dgReporte[10,x].Value.ToString()!="0")
									dgReporte[13,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)-Convert.ToDouble(dgReporte[10,x].Value)).ToString()));
								else
									dgReporte[13,x].Value=0.0;
								
								if(Convert.ToDouble(dgReporte[13,x].Value)<-factorETMin)// || Convert.ToDouble(dgReporte[13,x].Value)>factorETMaxi)
									dgReporte[13,x].Style.BackColor=Color.LightSkyBlue;
								else if (Convert.ToDouble(dgReporte[13,x].Value)>factorETMaxi)
									dgReporte[13,x].Style.BackColor=Color.Red;
								else
									dgReporte[13,x].Style.BackColor=Color.White;
								
								//dgReporte[14,x].Value=decimales((Convert.ToDouble(dgReporte[12,x].Value)/(Convert.ToDouble(dgReporte[7,x].Value)-((dgReporte[28,x].Value.ToString()=="")?0.0:Convert.ToDouble(dgReporte[28,x].Value)))).ToString());
								dgReporte[15,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)/(Convert.ToDouble(dgReporte[7,x].Value))).ToString()));
								
								try
								{
									if(dgReporte[15,x].Value.ToString()!="")
									{
										if(Convert.ToDouble(dgReporte[15,x].Value)<Convert.ToDouble(dgReporte[14,x].Value)-(Convert.ToDouble(dgReporte[14,x].Value)*(factorRend/100)))
										{
											dgReporte[15,x].Style.BackColor=Color.Red;
										}
										else
										{
											dgReporte[15,x].Style.BackColor=Color.MediumSpringGreen;
										}
										
										//*********************
										
										dgReporte[16,x].Value=Convert.ToDouble(decimales(Convert.ToString((Convert.ToDecimal(dgReporte[15,x].Value)/Convert.ToDecimal(dgReporte[14,x].Value))*Convert.ToDecimal(100.0))));
										
										if(Convert.ToDouble(dgReporte[16,x].Value)<factorEficiencia || Convert.ToDouble(dgReporte[16,x].Value)>factorMaximoEf)
											dgReporte[16,x].Style.BackColor=Color.Red;
										else
											dgReporte[16,x].Style.BackColor=Color.MediumSpringGreen;
										
										//dgReporte[16,x].Value=dgReporte[16,x].Value.ToString()+"%";
										
										//*********************	
										
										dgReporte[17,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[7,x].Value)-(Convert.ToDouble(dgReporte[12,x].Value)/Convert.ToDouble(dgReporte[14,x].Value))).ToString()));
										
										if(Convert.ToDouble(dgReporte[17,x].Value)>factorLitros)
											dgReporte[17,x].Style.BackColor=Color.Red;
										else
											dgReporte[17,x].Style.BackColor=Color.MediumSpringGreen;
										
										
										dgReporte[20,x].Value=decimales((Convert.ToDouble(dgReporte[17,x].Value)*Convert.ToDouble(dgReporte[19,x].Value)).ToString());
									}
								}
								catch(Exception)
								{
									//MessageBox.Show("Row: "+x);
								}
							}
						}
						else
						{
							dgReporte[12,x].Value="0";
							dgReporte[13,x].Value=0.0;
							dgReporte[13,x].Style.BackColor=Color.White;
							
							dgReporte[12,x].Style.BackColor=Color.Red;
						}
					}
					
					#region OTROS
					
					if(dgReporte[29,x].Value.ToString()!="")
					{
						dgReporte[7,x].Style.BackColor=Color.MediumSpringGreen;
						dgReporte[15,x].Style.BackColor=Color.MediumSpringGreen;
						dgReporte[16,x].Style.BackColor=Color.MediumSpringGreen;
						dgReporte[17,x].Style.BackColor=Color.MediumSpringGreen;
					}
					
					if(dgReporte[31,x].Value.ToString()!="")
					{
						dgReporte[12,x].Value="0";
						dgReporte[13,x].Value=0.0;
						dgReporte[13,x].Style.BackColor=Color.White;
						dgReporte[12,x].Style.BackColor=Color.Red;
						
						dgReporte[15,x].Value=0.0;
						dgReporte[16,x].Value=0.0;
						dgReporte[17,x].Value=0.0;
						dgReporte[20,x].Value="";
						
						dgReporte[15,x].Style.BackColor=Color.White;
						dgReporte[16,x].Style.BackColor=Color.White;
						dgReporte[17,x].Style.BackColor=Color.White;
					}
					
					if(dgReporte[33,x].Value.ToString()!="" && cbIntegracion.Checked==false)
					{
						double litroDia2 = 0.0;
						bool ENCUENTRA = false;
						DateTime fecha_servicio = DateTime.Now;
						int contta = 0;
						int contta2 = 0;
						Int64 ID_INTEGRA = 0;
						
						
						Conexion_Servidor.SQL_Conexion connI = new Conexion_Servidor.SQL_Conexion();
						string consulta = "select TOP 10 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.FECHA_REG=(SELECT FECHA_REG FROM AUTORIZACION WHERE ID="+dgReporte[33,x].Value.ToString()+") and A.ID_V=(SELECT ID_V FROM AUTORIZACION WHERE ID="+dgReporte[33,x].Value.ToString()+")"; 
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							litroDia2 = litroDia2+Convert.ToDouble(conn.leer["LITROS"]);
							if(contta == 0)
							{
								fecha_servicio = Convert.ToDateTime(conn.leer["FECHA_REG"]);
								ID_INTEGRA = Convert.ToInt64(conn.leer["ID"]);
							}
							// ************ POSIBLE WHILE ***********
							if(conn.leer["INTEGRA"].ToString()!="")
							{
								String nuevaConslt = "select TOP 10 A.* from AUTORIZACION A, GASOLINERA G WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.FECHA_REG=(SELECT FECHA_REG FROM AUTORIZACION WHERE ID="+conn.leer["INTEGRA"].ToString()+") and A.ID_V=(SELECT ID_V FROM AUTORIZACION WHERE ID="+conn.leer["INTEGRA"].ToString()+")";
								connI.getAbrirConexion(nuevaConslt);
								connI.leer=connI.comando.ExecuteReader();
								while(connI.leer.Read())
								{
									litroDia2 = litroDia2+Convert.ToDouble(connI.leer["LITROS"]);
									if(contta2 == 0)
									{
										fecha_servicio = Convert.ToDateTime(connI.leer["FECHA_REG"]);
										ID_INTEGRA = Convert.ToInt64(connI.leer["ID"]);
									}
									
									contta++;
								}
								connI.conexion.Close();
							}
							
							contta++;
							ENCUENTRA = true;
						}
						conn.conexion.Close();
						
						litroDia2 = litroDia2+Convert.ToDouble(dgReporte[7,x].Value);
						
						if(ENCUENTRA==true)
						{
							getKmAnterior2(ID_INTEGRA, x, fecha_servicio);
							
							dgReporte[12,x].Value=decimales((Convert.ToDouble(dgReporte[8,x].Value)-Convert.ToDouble(dgReporte[11,x].Value)).ToString());
							
							if(dgReporte[10,x].Value.ToString()!="0")
								dgReporte[13,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)-Convert.ToDouble(dgReporte[10,x].Value)).ToString()));
							else
								dgReporte[13,x].Value=0.0;
							
							if(Convert.ToDouble(dgReporte[13,x].Value)<-factorETMin)// || Convert.ToDouble(dgReporte[13,x].Value)>factorETMaxi)
								dgReporte[13,x].Style.BackColor=Color.LightSkyBlue;
							else if (Convert.ToDouble(dgReporte[13,x].Value)>factorETMaxi)
								dgReporte[13,x].Style.BackColor=Color.Red;
							else
								dgReporte[13,x].Style.BackColor=Color.White;
							
							dgReporte[15,x].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,x].Value)/litroDia2).ToString()));
							
							try
							{
								if(dgReporte[15,x].Value.ToString()!="")
								{
									if(Convert.ToDouble(dgReporte[15,x].Value)<Convert.ToDouble(dgReporte[14,x].Value)-(Convert.ToDouble(dgReporte[14,x].Value)*(factorRend/100)))
									{
										dgReporte[15,x].Style.BackColor=Color.Red;
									}
									else
									{
										dgReporte[15,x].Style.BackColor=Color.MediumSpringGreen;
									}
									
									dgReporte[16,x].Value=Convert.ToDouble(decimales(Convert.ToString((Convert.ToDecimal(dgReporte[15,x].Value)/Convert.ToDecimal(dgReporte[14,x].Value))*Convert.ToDecimal(100.0))));
									
									if(Convert.ToDouble(dgReporte[16,x].Value)<factorEficiencia || Convert.ToDouble(dgReporte[16,x].Value)>factorMaximoEf)
										dgReporte[16,x].Style.BackColor=Color.Red;
									else
										dgReporte[16,x].Style.BackColor=Color.MediumSpringGreen;
									
									//dgReporte[16,x].Value=dgReporte[16,x].Value.ToString()+"%";
									
									dgReporte[17,x].Value=Convert.ToDouble(decimales(((litroDia2)-(Convert.ToDouble(dgReporte[12,x].Value)/Convert.ToDouble(dgReporte[14,x].Value))).ToString()));
									
									if(Convert.ToDouble(dgReporte[17,x].Value)>factorLitros)
										dgReporte[17,x].Style.BackColor=Color.Red;
									else
										dgReporte[17,x].Style.BackColor=Color.MediumSpringGreen;
									
									
									dgReporte[20,x].Value=decimales((Convert.ToDouble(dgReporte[17,x].Value)*Convert.ToDouble(dgReporte[19,x].Value)).ToString());
								}
							}
							catch(Exception)
							{
								//MessageBox.Show("Row: "+x);
							}
						}
						
						for(int v=0; v<dgReporte.Rows.Count; v++)
						{
							if(dgReporte[33,x].Value.ToString()==dgReporte[0,v].Value.ToString())
							{
								dgReporte[15,v].Value=0.0;
								dgReporte[16,v].Value=0.0;
								dgReporte[17,v].Value=0.0;
								dgReporte[20,v].Value="";
								
								dgReporte[15,v].Style.BackColor=Color.Yellow;
								dgReporte[16,v].Style.BackColor=Color.Yellow;
								dgReporte[17,v].Style.BackColor=Color.Yellow;
							}
						}
					}
					
					if(dgReporte[33,x].Value.ToString()=="" && dgReporte[35,x].Value.ToString()!="")
					{						
						dgReporte[15,x].Style.BackColor=Color.SkyBlue;
						dgReporte[16,x].Style.BackColor=Color.SkyBlue;
						dgReporte[17,x].Style.BackColor=Color.SkyBlue;
					}
					
					#endregion
				}
			}
		}
		
		void getKmAnterior(Int64 ID_AUT, int rowInd, DateTime fecha_Serv)
		{
			int cambio = 0;
			bool entraa = false;
			try
			{
				String consulta = 	"select TOP 10 A.* " +
									"from AUTORIZACION A, GASOLINERA G " +
									"WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V = (select ID_V from AUTORIZACION where ESTATUS!=0 and ID="+ID_AUT+") " +
												"and A.FECHA_BASE <= (select FECHA_BASE from AUTORIZACION  where ESTATUS!=0 and ID="+ID_AUT+") " +
									"order by A.FECHA_REG desc, A.NUMERO desc";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(dgReporte[9,rowInd].Value!=null && dgReporte[9,rowInd].Value.ToString()!="" && dgReporte[11,rowInd].Value=="")
					{
						if(cambio==1 && dgReporte[11,rowInd].Value.ToString()=="" && dgReporte[23,rowInd].Value.ToString()=="")
						{
							if(fecha_Serv>Convert.ToDateTime(conn.leer["FECHA_REG"]))// || (cbIntegracion.Checked==true && fecha_Serv==Convert.ToDateTime(conn.leer["FECHA_REG"]))
							{
								dgReporte[11,rowInd].Value=conn.leer["KM"].ToString();
								dgReporte[36,rowInd].Value=conn.leer["FECHA_REG"].ToString();
								dgReporte[37,rowInd].Value=conn.leer["HORA_CARGA"].ToString();
								entraa = true;
							}
							else if(fecha_Serv==Convert.ToDateTime(conn.leer["FECHA_REG"]))
							{
								if(Convert.ToDateTime(dgReporte[9,rowInd].Value) > Convert.ToDateTime((conn.leer["HORA_CARGA"].ToString())))// && Convert.ToDateTime(dgReporte[9,rowInd].Value).Minute > Convert.ToDateTime((conn.leer["HORA_CARGA"].ToString())).Minute)
								{
									dgReporte[11,rowInd].Value=conn.leer["KM"].ToString();
									dgReporte[36,rowInd].Value=conn.leer["FECHA_REG"].ToString();
									dgReporte[37,rowInd].Value=conn.leer["HORA_CARGA"].ToString();
									entraa = true;
								}
							}
						}
						else if(cambio==2 && dgReporte[11,rowInd].Value.ToString()=="" && dgReporte[23,rowInd].Value.ToString()=="" && fecha_Serv==Convert.ToDateTime(conn.leer["FECHA_REG"]))
						{
							if(Convert.ToDateTime(dgReporte[9,rowInd].Value) > Convert.ToDateTime((conn.leer["HORA_CARGA"].ToString())))
							{
								dgReporte[11,rowInd].Value=conn.leer["KM"].ToString();
								dgReporte[36,rowInd].Value=conn.leer["FECHA_REG"].ToString();
								dgReporte[37,rowInd].Value=conn.leer["HORA_CARGA"].ToString();
								entraa = true;
							}
						}
						
						if(entraa == false)
						{
							if(fecha_Serv>Convert.ToDateTime(conn.leer["FECHA_REG"]))
							{
								dgReporte[11,rowInd].Value=conn.leer["KM"].ToString();
								dgReporte[36,rowInd].Value=conn.leer["FECHA_REG"].ToString();
								dgReporte[37,rowInd].Value=conn.leer["HORA_CARGA"].ToString();
								entraa=true;
							}
						}
						
						cambio++;
					}
				}
			}
			catch(Exception)
			{
				
			}
			finally
			{
				conn.conexion.Close();
			}
			
			if(cambio==1)
				dgReporte[11,rowInd].Value="0";
			
			if(dgReporte[11,rowInd].Value.ToString()=="")
				dgReporte[11,rowInd].Value="0";
		}
		
		void getKmAnterior2(Int64 ID_AUT, int rowInd, DateTime fecha_Serv)
		{
			int contt = 0;
			int contt2 = 0;
			DateTime primerFecha = DateTime.Now;
			double km_Ant = 0;
			
			String consulta = 	"select TOP 10 A.* " +
								"from AUTORIZACION A, GASOLINERA G " +
								"WHERE A.ID_G=G.ID and A.ESTATUS!='0' and A.ID_V = (select ID_V from AUTORIZACION where ESTATUS!=0 and ID="+ID_AUT+") " +
											"and A.FECHA_BASE <= (select FECHA_BASE from AUTORIZACION  where ESTATUS!=0 and ID="+ID_AUT+") " +
								"order by A.FECHA_REG desc, A.NUMERO desc";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(contt==0) 
				{
					primerFecha=Convert.ToDateTime(conn.leer["FECHA_REG"]);
					km_Ant=Convert.ToDouble(conn.leer["KM"]);
				}
				else
				{
					if(Convert.ToDateTime(conn.leer["FECHA_REG"])==primerFecha)
					{
						km_Ant=Convert.ToDouble(conn.leer["KM"]);
					}
					else if(Convert.ToDateTime(conn.leer["FECHA_REG"])<primerFecha && contt2==0)
					{
						km_Ant=Convert.ToDouble(conn.leer["KM"]);
						contt2++;
					}
				}
				
				contt++;
			}
			conn.conexion.Close();
			
			dgReporte[11,rowInd].Value=km_Ant;
		}
		
		void getRendIdeal(int rowInd)
		{
			String consulta = "select top 1 R.* from RENDIMIENTOS R, VEHICULO V, AUTORIZACION A WHERE A.ID_V=V.ID and R.ID_V=V.ID AND R.TIPO='"+((dgReporte[14,rowInd].Value.ToString()=="MTTO")?"MANTENIMIENTO":dgReporte[14,rowInd].Value.ToString())+"' AND A.ID="+dgReporte[0,rowInd].Value.ToString();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				dgReporte[14,rowInd].Value=conn.leer["FACTOR"].ToString();
			}
			else
			{
				dgReporte[14,rowInd].Value="0";
			}
			
			conn.conexion.Close();		
		}
		#endregion
		
		#region EXPORTA A EXCEL REPORTE
		void BtnExcelReporteClick(object sender, EventArgs e)
		{
			if(dgReporte.Rows.Count>0)
			{
				generaExcelReporte();
			}
		}
		
		void generaExcelReporte()
		{
			if(dgReporte.Rows.Count>0)
			{
				nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
					        
				ExcelApp.Application.Workbooks.Add(Type.Missing);
				ExcelApp.Columns.ColumnWidth = 20;
					
				int i = 1;
			
				++i;
				ExcelApp.Cells[i,  1] 	= "ID";
				ExcelApp.Cells[i,  2] 	= "NUMERO";
				ExcelApp.Cells[i,  3] 	= "VEHICULO";
				ExcelApp.Cells[i,  4] 	= "GASOLINERA";
				ExcelApp.Cells[i,  5] 	= "OPERADOR";
				ExcelApp.Cells[i,  6] 	= "FECHA";
				ExcelApp.Cells[i,  7] 	= "HR. AUTORIZACION";
				ExcelApp.Cells[i,  8] 	= "LITROS";
				ExcelApp.Cells[i,  9] 	= "KMS";
				ExcelApp.Cells[i,  10] 	= "HR. CARGA";
				ExcelApp.Cells[i,  11] 	= "KM ET";
				ExcelApp.Cells[i,  12] 	= "KM ANTERIOR";
				ExcelApp.Cells[i,  13] 	= "KM RECORRIDOS";
				ExcelApp.Cells[i,  14] 	= "R. IDEAL";
				ExcelApp.Cells[i,  15] 	= "R. OBTENIDO";
				ExcelApp.Cells[i,  16] 	= "EFICIENCIA";
				ExcelApp.Cells[i,  17] 	= "LITROS EXTRAS";
				ExcelApp.Cells[i,  18] 	= "TIPO COMBUSTIBLE";
				ExcelApp.Cells[i,  19] 	= "PRECIO";
				ExcelApp.Cells[i,  20] 	= "$";
				ExcelApp.Cells[i,  21] 	= "CONSUMO";
				ExcelApp.Cells[i,  22] 	= "TERMINA";
				ExcelApp.Cells[i,  23] 	= "PERMISO";
				ExcelApp.Cells[i,  24] 	= "RAZON";
				ExcelApp.Cells[i,  25] 	= "COMENTARIO";
				ExcelApp.Cells[i,  26] 	= "TIPO_UNIDAD";
				ExcelApp.Cells[i,  27] 	= "MARCA";
				ExcelApp.Cells[i,  28] 	= "USUARIO";
				ExcelApp.Cells[i,  29] 	= "LT. RECUPERADOS";
				ExcelApp.Cells[i,  30] 	= "$ RECUPERADO";
				ExcelApp.Cells[i,  31] 	= "ANULACION DE REND.";
				ExcelApp.Cells[i,  32] 	= "DEPARTAMENTO";
				
				for(int y=0; y<dgReporte.Rows.Count; y++)
				{
					++i;
					
					ExcelApp.Cells[i,  1]	= dgReporte[0,y].Value.ToString();
					ExcelApp.Cells[i,  2]	= dgReporte[1,y].Value.ToString();
					ExcelApp.Cells[i,  3]	= dgReporte[2,y].Value.ToString();
					ExcelApp.Cells[i,  4]	= dgReporte[3,y].Value.ToString();
					ExcelApp.Cells[i,  5]	= dgReporte[4,y].Value.ToString();
					ExcelApp.Cells[i,  6]	= dgReporte[5,y].Value.ToString();
					ExcelApp.Cells[i,  7]	= dgReporte[6,y].Value.ToString();
					ExcelApp.Cells[i,  8]	= dgReporte[7,y].Value.ToString();
					ExcelApp.Cells[i,  9]	= dgReporte[8,y].Value.ToString();
					ExcelApp.Cells[i,  10]	= dgReporte[9,y].Value.ToString();
					ExcelApp.Cells[i,  11]	= dgReporte[10,y].Value.ToString();
					ExcelApp.Cells[i,  12]	= dgReporte[11,y].Value.ToString();
					ExcelApp.Cells[i,  13]	= dgReporte[12,y].Value.ToString();
					ExcelApp.Cells[i,  14]	= dgReporte[14,y].Value.ToString();
					ExcelApp.Cells[i,  15]	= dgReporte[15,y].Value.ToString();
					ExcelApp.Cells[i,  16]	= dgReporte[16,y].Value.ToString();
					ExcelApp.Cells[i,  17]	= dgReporte[17,y].Value.ToString();
					ExcelApp.Cells[i,  18]	= dgReporte[18,y].Value.ToString();
					ExcelApp.Cells[i,  19]	= dgReporte[19,y].Value.ToString();
					ExcelApp.Cells[i,  20]	= dgReporte[20,y].Value.ToString();
					ExcelApp.Cells[i,  21]	= dgReporte[21,y].Value.ToString();
					ExcelApp.Cells[i,  22]	= dgReporte[22,y].Value.ToString();
					ExcelApp.Cells[i,  23]	= dgReporte[23,y].Value.ToString();
					ExcelApp.Cells[i,  24]	= dgReporte[24,y].Value.ToString();
					ExcelApp.Cells[i,  25]	= dgReporte[25,y].Value.ToString();
					ExcelApp.Cells[i,  26]	= dgReporte[26,y].Value.ToString();
					ExcelApp.Cells[i,  27]	= dgReporte[27,y].Value.ToString();
					ExcelApp.Cells[i,  28]	= dgReporte[28,y].Value.ToString();
					ExcelApp.Cells[i,  29]	= dgReporte[29,y].Value.ToString();
					ExcelApp.Cells[i,  30]	= dgReporte[30,y].Value.ToString();
					ExcelApp.Cells[i,  31]	= dgReporte[31,y].Value.ToString();
					ExcelApp.Cells[i,  32]	= dgReporte[32,y].Value.ToString();
				}
				
				SaveFileDialog CuadroDialogo = new SaveFileDialog();
				CuadroDialogo.DefaultExt = "xls";
				CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
				CuadroDialogo.AddExtension = true;
				CuadroDialogo.RestoreDirectory = true;
				CuadroDialogo.Title = "Guardar";
				CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				CuadroDialogo.FileName = "REPORTE_"+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
		#region BOTON CONSULTA
		void BtnConsultarClick(object sender, EventArgs e)
		{
			getReporte();
		}
		#endregion
		
		void DgReporteDoubleClick(object sender, EventArgs e)
		{
			if(dgReporte[23,dgReporte.CurrentRow.Index].Value.ToString()=="")
			{
				cambioAnular=false;
				
				getTodo(dgReporte[2,dgReporte.CurrentRow.Index].Value.ToString(), Convert.ToInt64(dgReporte[0,dgReporte.CurrentRow.Index].Value));
				calculaKmET();
			}
		}
		
		#region INTEGRACION DE CARGAS
		Int64 ID_INTEGRA = 0;
		void BtnIntegraClick(object sender, EventArgs e)
		{
			if(dgReporte.SelectedRows.Count==2)
			{
				String ID_INTEGRA = "0";
				int cont = 0;
				for(int x=0; x<dgReporte.Rows.Count; x++)
				{
					if(dgReporte.Rows[x].Selected==true)
					{
						cont++;
						
						if(cont==1)
						{
							ID_INTEGRA=Convert.ToString(dgReporte[0,x].Value);
						}
						
						if(cont==2)
						{
							if(dgReporte[4,x].Value.ToString()==dgReporte[4,x-1].Value.ToString())
							{
								DialogResult rs2 = MessageBox.Show("Integracion por mala carga. \n¿Desea continuar?", "TIPO DE INTEGRACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
								if (DialogResult.Yes==rs2)
								{
									string consulta = "INSERT INTO AUDITORIA_AUTORIZACION VALUES ("+dgReporte[0,x].Value.ToString()+", 'INTEGRACIÓN DE "+dgReporte[0,x].Value.ToString()+" CON "+ID_INTEGRA+"', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATETIME, SYSDATETIME())))";
									conn.getAbrirConexion(consulta);
									conn.comando.ExecuteNonQuery();
									conn.conexion.Close();
									
									guardaIntegracion("MALA CARGA", ID_INTEGRA, dgReporte[0,x].Value.ToString());
									getReporte();
								}
							}
							else
							{
								DialogResult rs2 = MessageBox.Show("Integracion por cambio de operador. \n¿Desea continuar?", "TIPO DE INTEGRACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
								if (DialogResult.Yes==rs2)
								{
									guardaIntegracion("CAMBIO DE OPERADOR", ID_INTEGRA, dgReporte[0,x].Value.ToString());
									getReporte();
								}
							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Para la integracion de las cargas es necesario la  \nseleccion de dos registros.");
			}
		}
		
		void guardaIntegracion(String tipo, string ID_A1, string ID_A2)
		{
			Conexion_Servidor.SQL_Conexion connM= new Conexion_Servidor.SQL_Conexion();
			String consul = "update AUTORIZACION set INTEGRA="+ID_A1+", TIPO_INTEGRA='"+tipo+"' where ID="+ID_A2;
			connM.getAbrirConexion(consul); 
			connM.comando.ExecuteNonQuery(); 
			connM.conexion.Close();	
			
			consul = "INSERT INTO AUDITORIA_AUTORIZACION VALUES ("+ID_A2+", 'INTEGRA CON "+ID_A1+"', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATETIME, SYSDATETIME())))";
			conn.getAbrirConexion(consul);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region IMRIME KILOMETROS
		void BtnKmClick(object sender, EventArgs e)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;
		
			++i;
			ExcelApp.Cells[i,  1] 	= "UNIDAD";
			ExcelApp.Cells[i,  2] 	= "KM";
			ExcelApp.Cells[i,  3] 	= "MARCA";
		
			
			String consulta2 = "";
			String consulta = "select * from VEHICULO where estatus='1' order by Numero";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;
				
				ExcelApp.Cells[i,  1]	= 	conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["Marca"].ToString();
				
				consulta2 = "select ID from AUTORIZACION where KM_INICIAL is not null and ID_V="+conn.leer["ID"].ToString();
				conn3.getAbrirConexion(consulta2);
				conn3.leer=conn3.comando.ExecuteReader();
				if(conn3.leer.Read())
				{
					consulta2 = "select MAX(KM) KM from AUTORIZACION where ESTATUS!='0' and ID>"+conn3.leer["ID"].ToString()+" and ID_V="+conn.leer["ID"].ToString();
					conn2.getAbrirConexion(consulta2);
					conn2.leer=conn2.comando.ExecuteReader();
					while(conn2.leer.Read())
					{
						ExcelApp.Cells[i,  2]	= 	((conn2.leer["KM"].ToString()=="")?"0":conn2.leer["KM"].ToString());
					}
					conn2.conexion.Close();
				}
				else
				{
					consulta2 = "select MAX(KM) KM from AUTORIZACION where ESTATUS!='0' and ID_V="+conn.leer["ID"].ToString();
					conn2.getAbrirConexion(consulta2);
					conn2.leer=conn2.comando.ExecuteReader();
					while(conn2.leer.Read())
					{
						ExcelApp.Cells[i,  2]	= 	((conn2.leer["KM"].ToString()=="")?"0":conn2.leer["KM"].ToString());
					}
					conn2.conexion.Close();
				}
				conn3.conexion.Close();
			}
			conn.conexion.Close();
				
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "KM  "+DateTime.Now.ToString("dd")+"_"+DateTime.Now.ToString("MM")+"_"+DateTime.Now.ToString("yyyy");
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
		
		#region RECALCULO DE ET
		void BtnETClick(object sender, EventArgs e)
		{
			for(int x=0; x<dgReporte.Rows.Count; x++)
			{
				try
				{
					if(dgReporte[3,x].Value.ToString()!="" && dgReporte[7,x].Value.ToString()!="")
						recalculaKmET(dgReporte[2,x].Value.ToString(), x, dgReporte[36,x].Value.ToString(), dgReporte[37,x].Value.ToString());
				}
				catch(Exception)
				{
					dgReporte[10,x].Style.BackColor=Color.Red;
				}
			}
		}
		
		void recalculaKmET(string unidad, int rowI, string fechaAnterior, string horaAnterior)
		{
			String MAC_U = "";
			bool entra = false;
			
			String consulta = "select M.MAC from MAC_UNIDAD M, VEHICULO V where M.ID_V=V.ID and V.Numero='"+unidad+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				MAC_U=conn.leer["MAC"].ToString();
				entra = true;
			}
			
			conn.conexion.Close();
			
			if(entra==true)
			{
				List<Interfaz.Combustible.Datos.Coordenadas> listCoor = getListaCoordenadas2(fechaAnterior.Substring(0,10), dgReporte[5,rowI].Value.ToString().Substring(0,10), MAC_U, horaAnterior.Substring(0,5), dgReporte[6,rowI].Value.ToString().Substring(0,5));
				double kmET = 0.0;
				String consul = "";
				
				if(rowI==5)
					dgKMET.Rows.Clear();
				
				if(listCoor!=null)
				{
					for(int x=0; x<listCoor.Count-1; x++)
					{
						double lLat1 = Radianes(Convert.ToDouble(listCoor[x].LAT));
						double lLon1 = Radianes(Convert.ToDouble(listCoor[x].LON));
						double lLat2 = Radianes(Convert.ToDouble(listCoor[x+1].LAT));
						double lLon2 = Radianes(Convert.ToDouble(listCoor[x+1].LON));
						double lDLat = lLat2 - lLat1;                         
						double lDLon = lLon2 - lLon1;                         
						double lA = Math.Pow(Math.Sin(lDLat/2),2) + Math.Cos(lLat1) * Math.Cos(lLat2) *  Math.Pow(Math.Sin(lDLon/2),2);
						double lC =  2 * Math.Atan2(Math.Sqrt(lA),Math.Sqrt(1-lA));
						if(rowI==5)
							dgKMET.Rows.Add(listCoor[x].FECHA, listCoor[x].HORA, listCoor[x+1].FECHA, listCoor[x+1].HORA, (6371 * lC));
						
						kmET = kmET + (6371 * lC);
					}
					
					dgReporte[10,rowI].Value=decimales(kmET.ToString());
					
					if(dgReporte[10,rowI].Value.ToString()!="0")
						dgReporte[13,rowI].Value=Convert.ToDouble(decimales((Convert.ToDouble(dgReporte[12,rowI].Value)-Convert.ToDouble(dgReporte[10,rowI].Value)).ToString()));
					else
						dgReporte[13,rowI].Value=0.0;
					
					if(Convert.ToDouble(dgReporte[13,rowI].Value)<-factorETMin)// || Convert.ToDouble(dgReporte[13,rowI].Value)>factorETMaxi)
						dgReporte[13,rowI].Style.BackColor=Color.LightSkyBlue;
					else if (Convert.ToDouble(dgReporte[13,rowI].Value)>factorETMaxi)
						dgReporte[13,rowI].Style.BackColor=Color.Red;
					else
						dgReporte[13,rowI].Style.BackColor=Color.White;
					
					
					dgReporte[10,rowI].Style.BackColor=Color.MediumSpringGreen;
					
					consul = "update AUTORIZACION set KM_ET='"+dgReporte[10,rowI].Value.ToString()+"' where ID="+dgReporte[0,rowI].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				else
				{
					dgReporte[10,rowI].Value="0.00";
					dgReporte[13,rowI].Value="0";
					dgReporte[10,rowI].Style.BackColor=Color.Yellow;
					
					consul = "update AUTORIZACION set KM_ET='"+dgReporte[10,rowI].Value.ToString()+"' where ID="+dgReporte[0,rowI].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
			}
		}
		
		List<Interfaz.Combustible.Datos.Coordenadas> getListaCoordenadas2(String fecha_1, String fecha_2, String MAC, String hora1, String hora2)
		{
			List<Interfaz.Combustible.Datos.Coordenadas> listCoor = new List<Interfaz.Combustible.Datos.Coordenadas>();
			
			String consulta = "";
			
			if(fecha_1==fecha_2)
				consulta = "select * from mac_"+MAC+" where FECHA between '"+fecha_1+"' and '"+fecha_2+"' and HORA between '"+hora1+"' and '"+hora2+"' order by ID ";
			else
				consulta = "select * from mac_"+MAC+" where FECHA between '"+fecha_1+"' and '"+fecha_2+"' order by ID ";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(fecha_1==fecha_2)
				{
					Interfaz.Combustible.Datos.Coordenadas Coordenadas = new Interfaz.Combustible.Datos.Coordenadas();
					
					Coordenadas.FECHA	= conn.leer["FECHA"].ToString();
					Coordenadas.HORA	= conn.leer["HORA"].ToString();
					Coordenadas.LAT		= conn.leer["LAT"].ToString();
					Coordenadas.LON		= conn.leer["LON"].ToString();
					
					listCoor.Add(Coordenadas);
				}
				else if((conn.leer["FECHA"].ToString().Substring(0,10)==fecha_1 && Convert.ToDateTime(conn.leer["HORA"].ToString())>=Convert.ToDateTime(hora1)) || 
				   (conn.leer["FECHA"].ToString().Substring(0,10)==fecha_2 && Convert.ToDateTime(conn.leer["HORA"].ToString())<=Convert.ToDateTime(hora2)) || 
				   (Convert.ToDateTime(conn.leer["FECHA"].ToString())>Convert.ToDateTime(fecha_1) && Convert.ToDateTime(conn.leer["FECHA"].ToString())<Convert.ToDateTime(fecha_2)))
				{
					Interfaz.Combustible.Datos.Coordenadas Coordenadas = new Interfaz.Combustible.Datos.Coordenadas();
					
					Coordenadas.FECHA	= conn.leer["FECHA"].ToString();
					Coordenadas.HORA	= conn.leer["HORA"].ToString();
					Coordenadas.LAT		= conn.leer["LAT"].ToString();
					Coordenadas.LON		= conn.leer["LON"].ToString();
					
					listCoor.Add(Coordenadas);
				}
			}
			conn.conexion.Close();
			
			return (listCoor.Count>0)?listCoor:null;
		}
		#endregion
		
		#endregion
		
		//*********************************************************************************************************************************
		//******************************************************** TICKETS ****************************************************************
		//*********************************************************************************************************************************

		#region [ TICKETS ]
		
		#region VARIABLES
		Int64 ID_OP_R3 = 0;
		Int64 ID_UNI_R3 = 0;
		Int64 ID_GAS_R3 = 0;
		Int64 ID_COMB_R3 = 0;
		#endregion
		
		void CmdRegresaTicketClick(object sender, EventArgs e)
		{
			if(dgTickets.SelectedRows.Count==1)
			{
				String consul = "update AUT_FACT set ESTATUS='0', ID_F=null where ID_A="+dgTickets[0,dgTickets.CurrentRow.Index].Value.ToString();
				conn.getAbrirConexion(consul);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				dgTickets[13,dgTickets.CurrentRow.Index].Value="";
				dgTickets[14,dgTickets.CurrentRow.Index].Value="";
				dgTickets[15,dgTickets.CurrentRow.Index].Value="";
				dgTickets[16,dgTickets.CurrentRow.Index].Value="";
				dgTickets[17,dgTickets.CurrentRow.Index].Value="";
				
				dgTickets[13,dgTickets.CurrentRow.Index].Style.BackColor=Color.White;
				dgTickets[14,dgTickets.CurrentRow.Index].Style.BackColor=Color.White;
				dgTickets[15,dgTickets.CurrentRow.Index].Style.BackColor=Color.White;
				dgTickets[16,dgTickets.CurrentRow.Index].Style.BackColor=Color.White;
				dgTickets[17,dgTickets.CurrentRow.Index].Style.BackColor=Color.White;
			}
		}
		
		void DgTicketsDoubleClick(object sender, EventArgs e)
		{
			if(dgTickets.SelectedRows.Count==1)
			{
				cambioAnular=false;
				
				getTodo(dgTickets[3,dgTickets.CurrentRow.Index].Value.ToString(), Convert.ToInt64(dgTickets[0,dgTickets.CurrentRow.Index].Value));
				calculaKmET();
			}
		}
		
		void BtnConsTicketsClick(object sender, EventArgs e)
		{
			getDatosDGTickets();
		}
		
		#region GET DATOS
		void getDatosDGTickets()
		{
			dgTickets.Rows.Clear();
			iniciaTickets=true;
			txtTotalFactura.Text="0.0";
			
			String consulta = "SELECT A.*, U.usuario, O.tipo_empleado, G.Nombre GASOLINERA, V.Numero UNIDAD, O.Alias, P.PRECIO , P.ID ID_COMB FROM AUTORIZACION A, VEHICULO V, OPERADOR O, USUARIO U, GASOLINERA G, PRECIOS_COMB P WHERE G.ID=A.ID_G AND U.id_usuario=A.ID_U AND P.ID=A.ID_COM AND A.ID_V=V.ID AND A.ID_O=O.ID AND A.ESTATUS!='0' and G.NOMBRE like '%"+txtGasolineraR3.Text+"%' and A.FECHA_REG BETWEEN '"+dtpFechaIR3.Value.ToString("dd/MM/yyyy")+"' AND '"+dtpFechaFR3.Value.ToString("dd/MM/yyyy")+"' AND O.Alias LIKE '%"+txtOperadosR3.Text+"%' AND V.Numero LIKE '%"+txtUnidadR3.Text+"%' order by A.FECHA_REG, A.Numero ";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgTickets.Rows.Add(conn.leer["ID"].ToString(), 
				                   getNumeroValidacion(Convert.ToInt64(conn.leer["Numero"]), Convert.ToDateTime(conn.leer["FECHA_REG"])), 
				                   conn.leer["GASOLINERA"].ToString(), 
				                   conn.leer["UNIDAD"].ToString(), 
				                   conn.leer["Alias"].ToString(), 
				                   Convert.ToDateTime(conn.leer["FECHA_REG"]),
				                   conn.leer["HORA_CARGA"].ToString(), 
				                   conn.leer["ID_COMB"].ToString(), 
				                   conn.leer["PRECIO"].ToString(),
				                   ((conn.leer["KM"].ToString()=="")?0:Convert.ToDouble(conn.leer["KM"])),
				                   ((conn.leer["LITROS"].ToString()=="")?0:Convert.ToDouble(conn.leer["LITROS"])), 
				                   ((conn.leer["LITROS"].ToString()=="")?"0.0":decimales((Convert.ToDouble(conn.leer["LITROS"])*Convert.ToDouble(conn.leer["PRECIO"])).ToString())), "", "", "", "", "");
			}	
			conn.conexion.Close();
			
			getDatosFaltantesR3();
			getGasolineraR3();
			calculos();
			
			iniciaTickets=false;
			dgTickets.ClearSelection();
		}
		
		void getDatosFaltantesR3()
		{
			for(int x=(dgTickets.Rows.Count-1); x>-1; x--)
			{
				String consulta = "SELECT LITROS, TIPO FROM AUT_FACT WHERE ESTATUS='1' AND ID_A="+dgTickets[0,x].Value.ToString();
			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="GASOLINERA")
					{
						dgTickets[13,x].Value=conn.leer["LITROS"].ToString();
						dgTickets[17,x].Value=decimales((Convert.ToDouble(dgTickets[13,x].Value)-Convert.ToDouble(dgTickets[10,x].Value)).ToString());
						if(Convert.ToDouble(dgTickets[17,x].Value)>factorLitTikets)
							dgTickets[17,x].Style.BackColor=Color.Red;
						else
							dgTickets[17,x].Style.BackColor=Color.White;
						
						if(conn.leer["LITROS"].ToString()!="")
							dgTickets[15,x].Value=Convert.ToDouble(dgTickets[8,x].Value)*Convert.ToDouble(dgTickets[13,x].Value);
					}
					
					if(conn.leer["TIPO"].ToString()=="TICKET")
					{
						dgTickets[14,x].Value=conn.leer["LITROS"].ToString();
						dgTickets[17,x].Value=decimales((Convert.ToDouble(dgTickets[14,x].Value)-Convert.ToDouble(dgTickets[10,x].Value)).ToString());
						if(Convert.ToDouble(dgTickets[17,x].Value)>factorLitTikets)
							dgTickets[17,x].Style.BackColor=Color.Red;
						else
							dgTickets[17,x].Style.BackColor=Color.White;
						
						if(conn.leer["LITROS"].ToString()!="")
							dgTickets[15,x].Value=Convert.ToDouble(dgTickets[8,x].Value)*Convert.ToDouble(dgTickets[14,x].Value);
					}
				}
				conn.conexion.Close();
				
				consulta = "SELECT R.LITROS, F.FOLIO, R.TIPO FROM AUT_FACT R, FACTURA_COMB F WHERE F.ID=R.ID_F and R.ESTATUS='1' AND R.ID_A="+dgTickets[0,x].Value.ToString();
			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="GASOLINERA")
					{
						dgTickets[13,x].Value=conn.leer["LITROS"].ToString();
						dgTickets[17,x].Value=decimales((Convert.ToDouble(dgTickets[13,x].Value)-Convert.ToDouble(dgTickets[10,x].Value)).ToString());
						if(Convert.ToDouble(dgTickets[17,x].Value)>factorLitTikets)
							dgTickets[17,x].Style.BackColor=Color.Red;
						else
							dgTickets[17,x].Style.BackColor=Color.White;
						
						dgTickets[16,x].Value=conn.leer["FOLIO"].ToString();
						dgTickets[16,x].Style.BackColor=Color.MediumSpringGreen;
						dgTickets[16,x].ReadOnly=true;
						dgTickets[13,x].ReadOnly=true;
						
						if(conn.leer["LITROS"].ToString()!="")
							dgTickets[15,x].Value=Convert.ToDouble(dgTickets[8,x].Value)*Convert.ToDouble(dgTickets[13,x].Value);
					}
					
					if(conn.leer["TIPO"].ToString()=="TICKET")
					{
						dgTickets[14,x].Value=conn.leer["LITROS"].ToString();
						dgTickets[17,x].Value=decimales((Convert.ToDouble(dgTickets[14,x].Value)-Convert.ToDouble(dgTickets[10,x].Value)).ToString());
						if(Convert.ToDouble(dgTickets[17,x].Value)>factorLitTikets)
							dgTickets[17,x].Style.BackColor=Color.Red;
						else
							dgTickets[17,x].Style.BackColor=Color.White;
						
						dgTickets[16,x].Value=conn.leer["FOLIO"].ToString();
						dgTickets[16,x].Style.BackColor=Color.MediumSpringGreen;
						dgTickets[16,x].ReadOnly=true;
						
						dgTickets[13,x].ReadOnly=true;
						
						if(conn.leer["LITROS"].ToString()!="")
							dgTickets[15,x].Value=Convert.ToDouble(dgTickets[8,x].Value)*Convert.ToDouble(dgTickets[14,x].Value);
						
						/*if(cbTodoTickets.Checked==false)
						{
							dgTickets.Rows.RemoveAt(x);
						}*/
					}
				}
				conn.conexion.Close();
			}
			
			
			for(int x=(dgTickets.Rows.Count-1); x>-1; x--)
			{
				String consulta = "SELECT R.LITROS, F.FOLIO, R.TIPO FROM AUT_FACT R, FACTURA_COMB F WHERE F.ID=R.ID_F and R.ESTATUS='1' AND R.ID_A="+dgTickets[0,x].Value.ToString();
			
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="TICKET")
					{
						if(cbTodoTickets.Checked==false)
						{
							dgTickets.Rows.RemoveAt(x);
						}
					}
				}
				conn.conexion.Close();
			}
		}
		
		void getGasolineraR3()
		{
			for(int x=0; x<dgTickets.Rows.Count; x++)
			{
				String consulta = "select * from TIPOS_COMB T, PRECIOS_COMB P where T.ID=P.ID_TC and ESTATUS='1' and P.ID="+dgTickets[7,x].Value.ToString();
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgTickets[7,x].Value=conn.leer["NOMBRE"].ToString();
				}
				conn.conexion.Close();
			}
		}
		
		void calculos()
		{
			double total=0.0;
			double total2 = 0.0;
			
			for(int x=0; x<dgTickets.Rows.Count; x++)
			{
				if(dgTickets[11,x].Value.ToString()!="")
					total=total+Convert.ToDouble(dgTickets[11,x].Value);
				
				if(dgTickets[15,x].Value.ToString()!="")
					total2 = total2 + Convert.ToDouble(dgTickets[15,x].Value);
			}
			
			txtTotalSistema.Text=decimales(total.ToString());
			txtTotalFactura.Text=total2.ToString();
		}
		#endregion
		
		#region EVENTOS DE BUSQUEDA	
		void TxtUnidadR3TextChanged(object sender, EventArgs e)
		{
			//getDatosDGTickets();
		}
		
		void TxtOperadosR3TextChanged(object sender, EventArgs e)
		{
			//getDatosDGTickets();
		}
		
		void TxtGasolineraR3TextChanged(object sender, EventArgs e)
		{
			//getDatosDGTickets();
		}
		
		void DtpFechaIR3ValueChanged(object sender, EventArgs e)
		{
			dtpFechaFR3.Value=dtpFechaIR3.Value;
		}
		
		void DtpFechaFR3ValueChanged(object sender, EventArgs e)
		{
			//getDatosDGTickets();
		}
		#endregion
		
		#region INGRESO DE LITROS EN DG
		void DgTicketsCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(iniciaTickets==false)
			{
				if(e.ColumnIndex==13)
				{
					try
					{
						Convert.ToDouble(dgTickets[e.ColumnIndex,e.RowIndex].Value);
						dgTickets[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
						
						if(dgTickets[14,e.RowIndex].Value.ToString()=="")
							dgTickets[15,e.RowIndex].Value=(Convert.ToDouble(dgTickets[8,e.RowIndex].Value)*Convert.ToDouble(dgTickets[13,e.RowIndex].Value)).ToString();
						
						
						double total2 = 0.0;
						for(int x=0; x<dgTickets.Rows.Count; x++)
						{
							if(dgTickets[15,x].Value.ToString()!="")
							{
								total2 = total2 + Convert.ToDouble(dgTickets[15,x].Value);
							}
						}
						txtTotalFactura.Text=total2.ToString();
						
						guardaLitros(e.RowIndex, "GASOLINERA");
					}
					catch(Exception)
					{
						dgTickets[e.ColumnIndex, e.RowIndex].Value="";
						dgTickets[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
						//guardaLitros(e.RowIndex, "GASOLINERA");
					}
				}
				
				if(e.ColumnIndex==14)
				{
					try
					{
						Convert.ToDouble(dgTickets[e.ColumnIndex,e.RowIndex].Value);
						dgTickets[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
						
						dgTickets[15,e.RowIndex].Value=(Convert.ToDouble(dgTickets[8,e.RowIndex].Value)*Convert.ToDouble(dgTickets[14,e.RowIndex].Value)).ToString();
						
						if(dgTickets[14,e.RowIndex].Value.ToString()=="")
							dgTickets[15,e.RowIndex].Value=(Convert.ToDouble(dgTickets[8,e.RowIndex].Value)*Convert.ToDouble(dgTickets[13,e.RowIndex].Value)).ToString();
						
						double total2 = 0.0;
						for(int x=0; x<dgTickets.Rows.Count; x++)
						{
							if(dgTickets[15,x].Value.ToString()!="")
							{
								total2 = total2 + Convert.ToDouble(dgTickets[15,x].Value);
							}
						}
						txtTotalFactura.Text=total2.ToString();
						
						guardaLitros(e.RowIndex, "TICKET");
					}
					catch(Exception)
					{
						dgTickets[e.ColumnIndex, e.RowIndex].Value="";
						dgTickets[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
						/***************************************************/
						//guardaLitros(e.RowIndex, "TICKET");
						
						if(dgTickets[13,e.RowIndex].Value.ToString()!="")
							dgTickets[15,e.RowIndex].Value=(Convert.ToDouble(dgTickets[8,e.RowIndex].Value)*Convert.ToDouble(dgTickets[13,e.RowIndex].Value)).ToString();
					}
				}
			}
		}
		
		void guardaLitros(int fila, String tipo)
		{
			String consul = "UPDATE AUT_FACT SET ESTATUS='0' WHERE TIPO='"+tipo+"' AND ID_A="+dgTickets[0,fila].Value.ToString();
			conn.getAbrirConexion(consul);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consul = "INSERT INTO AUT_FACT VALUES ("+dgTickets[0,fila].Value.ToString()+", "+((dgTickets[16,fila].Value.ToString()=="")?"NULL":dgTickets[16,fila].Value.ToString())+", '"+((tipo!="TICKET")?dgTickets[13,fila].Value.ToString():dgTickets[14,fila].Value.ToString())+"', '"+dgTickets[15,fila].Value.ToString()+"', (SELECT CONVERT (DATETIME, SYSDATETIME())), '1', '"+tipo+"', "+refPrincipal.idUsuario+");";
			conn.getAbrirConexion(consul);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region CAMBIOS EN AUTORIZACION
		
		#region EVENTO CELLCLICK
		void DgTicketsCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1 && e.ColumnIndex==1 && dgTickets.SelectedRows.Count==1 && dgTickets[16,e.RowIndex].Style.BackColor.Name!="MediumSpringGreen")
			{
				gbModificación.Enabled=true;
				seleccionR3();
				ValidaR3();
			}
			else
			{
				gbModificación.Enabled=false;
				LimpiaR3();
			}
		}
		#endregion
		
		#region LIMPIA DATOS
		void LimpiaR3()
		{
			txtOperadorR3M.Text="";
			txtUnidadR3M.Text="";
			txtGasolineraR3M.Text="";
			cmbTipoCombR3M.Text="";
		}
		#endregion
		
		#region SELECCION DE AUTORIZACION
		void seleccionR3()
		{
			txtOperadorR3M.Text=dgTickets[4,dgTickets.CurrentRow.Index].Value.ToString();
			txtUnidadR3M.Text=dgTickets[3,dgTickets.CurrentRow.Index].Value.ToString();
			txtGasolineraR3M.Text=dgTickets[2,dgTickets.CurrentRow.Index].Value.ToString();
			cmbTipoCombR3M.Text=dgTickets[7,dgTickets.CurrentRow.Index].Value.ToString();
			
			String consulta = "select ID from OPERADOR where Alias='"+txtOperadorR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_OP_R3 = Convert.ToInt64(conn.leer["ID"]);
				txtOperadorR3M.ForeColor=Color.MediumSpringGreen;
			}
			else
			{
				ID_OP_R3 = 0;
				txtOperadorR3M.ForeColor=Color.Black;
			}
			conn.conexion.Close();
			
			consulta = "select ID from VEHICULO where Numero='"+txtUnidadR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_UNI_R3 = Convert.ToInt64(conn.leer["ID"]);
				txtUnidadR3M.ForeColor=Color.MediumSpringGreen;
			}
			else
			{
				ID_UNI_R3 = 0;
				txtUnidadR3M.ForeColor=Color.Black;
			}
			conn.conexion.Close();
			
			consulta = "select ID from GASOLINERA where NOMBRE='"+txtGasolineraR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_GAS_R3 = Convert.ToInt64(conn.leer["ID"]);
				txtGasolineraR3M.ForeColor=Color.MediumSpringGreen;
			}
			else
			{
				ID_GAS_R3 = 0;
				txtGasolineraR3M.ForeColor=Color.Black;
			}
			conn.conexion.Close();
			
			consulta = "select P.ID from TIPOS_COMB T, PRECIOS_COMB P where P.ESTATUS='1' and T.ID=P.ID_TC and T.NOMBRE='"+cmbTipoCombR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_COMB_R3 = Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				ID_COMB_R3 = 0;
			}
			conn.conexion.Close();
		}
		
		void ValidaR3()
		{
			if(ID_OP_R3!=0 && ID_UNI_R3!=0 && ID_GAS_R3!=0 && ID_COMB_R3!=0)
			{
				txtOperadorR3M.ForeColor=Color.MediumSpringGreen;
				txtUnidadR3M.ForeColor=Color.MediumSpringGreen;
				txtGasolineraR3M.ForeColor=Color.MediumSpringGreen;
				
				btnModifica.Enabled=true;
			}
			else
			{
				if(ID_OP_R3==0)
					txtOperadorR3M.ForeColor=Color.Black;
				
				if(ID_UNI_R3==0)
					txtUnidadR3M.ForeColor=Color.Black;
				
				if(ID_GAS_R3==0)
					txtGasolineraR3M.ForeColor=Color.Black;
				
				btnModifica.Enabled=false;
			}
		}
		#endregion
		
		#region ENTER
		void TxtOperadorR3MMouseClick(object sender, MouseEventArgs e)
		{
			txtOperadorR3M.SelectAll();
		}
		
		void TxtOperadorR3MEnter(object sender, EventArgs e)
		{
			txtOperadorR3M.SelectAll();
		}
		
		void TxtUnidadR3MMouseClick(object sender, MouseEventArgs e)
		{
			txtUnidadR3M.SelectAll();
		}
		
		void TxtUnidadR3MEnter(object sender, EventArgs e)
		{
			txtUnidadR3M.SelectAll();
		}
		
		void TxtGasolineraR3MMouseClick(object sender, MouseEventArgs e)
		{
			txtGasolineraR3M.SelectAll();
		}
		
		void TxtGasolineraR3MEnter(object sender, EventArgs e)
		{
			txtGasolineraR3M.SelectAll();
		}
		#endregion
		
		#region SELECCION
		void TxtOperadorR3MKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtUnidadR3M.Focus();
			}
		}
		
		void TxtOperadorR3MLeave(object sender, EventArgs e)
		{
			String consulta = "select ID from OPERADOR where Alias='"+txtOperadorR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_OP_R3 = Convert.ToInt64(conn.leer["ID"]);
				txtOperadorR3M.ForeColor=Color.MediumSpringGreen;
			}
			else
			{
				ID_OP_R3 = 0;
				txtOperadorR3M.ForeColor=Color.Black;
			}
			conn.conexion.Close();
			
			ValidaR3();
		}
		
		void TxtUnidadR3MKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtGasolineraR3M.Focus();
			}
		}
		
		void TxtUnidadR3MLeave(object sender, EventArgs e)
		{
			String consulta = "select ID from VEHICULO where Numero='"+txtUnidadR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_UNI_R3 = Convert.ToInt64(conn.leer["ID"]);
				txtUnidadR3M.ForeColor=Color.MediumSpringGreen;
			}
			else
			{
				ID_UNI_R3 = 0;
				txtUnidadR3M.ForeColor=Color.Black;
			}
			conn.conexion.Close();
			
			ValidaR3();
		}
		
		void TxtGasolineraR3MKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				cmbTipoCombR3M.Focus();
			}
		}
		
		void TxtGasolineraR3MLeave(object sender, EventArgs e)
		{
			String consulta = "select ID from GASOLINERA where NOMBRE='"+txtGasolineraR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_GAS_R3 = Convert.ToInt64(conn.leer["ID"]);
				txtGasolineraR3M.ForeColor=Color.MediumSpringGreen;
			}
			else
			{
				ID_GAS_R3 = 0;
				txtGasolineraR3M.ForeColor=Color.Black;
			}
			conn.conexion.Close();
			
			ValidaR3();
		}
		
		void CmbTipoCombR3MSelectedIndexChanged(object sender, EventArgs e)
		{
			String consulta = "select P.ID from TIPOS_COMB T, PRECIOS_COMB P where P.ESTATUS='1' and T.ID=P.ID_TC and T.NOMBRE='"+cmbTipoCombR3M.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_COMB_R3 = Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				ID_COMB_R3 = 0;
			}
			conn.conexion.Close();
			
			ValidaR3();
		}
		#endregion
		
		#region GUARDA MODIFICACION
		void BtnModificaClick(object sender, EventArgs e)
		{
			if(dgTickets.SelectedRows.Count==1)
			{
				guardaModificaion();
				getDatosDGTickets();
			}
			else
			{
				MessageBox.Show("Seleccione un solo registro.");
			}
		}
		
		void guardaModificaion()
		{
			String consul = "INSERT INTO AUDITORIA_AUTORIZACION VALUES ("+dgTickets[0,dgTickets.CurrentRow.Index].Value.ToString()+", 'MODIFICACION EN REVISION DE TICKETS (OPERADOR:"+dgTickets[4,dgTickets.CurrentRow.Index].Value.ToString()+", UNIDAD:"+dgTickets[3,dgTickets.CurrentRow.Index].Value.ToString()+", GASOLINERA:"+dgTickets[2,dgTickets.CurrentRow.Index].Value.ToString()+", TIPO_COM="+dgTickets[7,dgTickets.CurrentRow.Index].Value.ToString()+")', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATETIME, SYSDATETIME())))";
			conn.getAbrirConexion(consul);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consul = "update AUTORIZACION set ID_O="+ID_OP_R3+", ID_V="+ID_UNI_R3+", ID_G="+ID_GAS_R3+", ID_COM="+ID_COMB_R3+"  where ID="+dgTickets[0,dgTickets.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consul); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
		}
		#endregion
		
		#endregion
		
		#region FACTURA
		
		#region EVENTO BOTON
		void BtnGuardaFacturaClick(object sender, EventArgs e)
		{
			if(validaFactura()==true)
			{
				guardaFactura();
				getDatosDGTickets();
			}
			else
			{
				DialogResult rs2 = MessageBox.Show("Existen registros sin datos. ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs2)
				{
					guardaFactura();
					getDatosDGTickets();
				}
			}
		}
		#endregion
		
		#region GUARDADO DE FACTURA DE COMBUSTIBLE
		void guardaFactura()
		{
			String ID_FACT = "";
			String consul = "INSERT INTO FACTURA_COMB VALUES ('"+txtFacturaComb.Text+"', '"+dtpFechaIR3.Value.ToString("dd/MM/yyyy")+"', '"+dtpFechaFR3.Value.ToString("dd/MM/yyyy")+"', '"+txtTotalFactura.Text+"', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATETIME, SYSDATETIME())));";
			conn.getAbrirConexion(consul);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			consul = "select MAX(ID) ID from FACTURA_COMB";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				ID_FACT = conn.leer["ID"].ToString();
			}
			conn.conexion.Close();
			
			for(int x=0; x<dgTickets.Rows.Count; x++)
			{
				if(dgTickets[14,x].Value.ToString()!="" && dgTickets[16,x].Value.ToString()=="")
				{
					consul = "UPDATE AUT_FACT SET ID_F='"+ID_FACT+"' WHERE ESTATUS='1' AND ID_A="+dgTickets[0,x].Value.ToString();
					conn.getAbrirConexion(consul);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					dgTickets[16,x].Style.BackColor=Color.MediumSpringGreen;
					dgTickets[16,x].ReadOnly=true;
					dgTickets[13,x].ReadOnly=true;
				}
			}
			
			txtFacturaComb.Text="";
		}
		
		bool validaFactura()
		{
			bool respuesta = true;
			
			for(int x=0; x<dgTickets.Rows.Count; x++)
			{
				if(dgTickets[15,x].Value.ToString()=="")
				{
					respuesta = false;
					dgTickets[15,x].Style.BackColor=Color.Red;
				}
			}
			
			return respuesta;
		}
		#endregion
		
		#endregion
		
		#endregion
		
		//*********************************************************************************************************************************
		//****************************************************** EASY TRACK ***************************************************************
		//*********************************************************************************************************************************
		
		#region [ CALCULO DE KM E.T. ]
		void calculaKmET()
		{
			String MAC_U = "";
			bool entra = false;
			
			String consulta = "select M.MAC from MAC_UNIDAD M, VEHICULO V where M.ID_V=V.ID and V.Numero='"+dgAutorizacionValida[2,0].Value.ToString()+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				MAC_U=conn.leer["MAC"].ToString();
				entra = true;
			}
			
			conn.conexion.Close();
			
			if(entra==true)
			{
				List<Interfaz.Combustible.Datos.Coordenadas> listCoor = getListaCoordenadas(lblUltima.Text, dgAutorizacionValida[4,0].Value.ToString(), MAC_U);
				double kmET = 0.0;
				dgKMET.Rows.Clear();
				
				if(listCoor!=null)
				{
					for(int x=0; x<listCoor.Count-1; x++)
					{
						double lLat1 = Radianes(Convert.ToDouble(listCoor[x].LAT));
						double lLon1 = Radianes(Convert.ToDouble(listCoor[x].LON));
						double lLat2 = Radianes(Convert.ToDouble(listCoor[x+1].LAT));
						double lLon2 = Radianes(Convert.ToDouble(listCoor[x+1].LON));
						double lDLat = lLat2 - lLat1;                         
						double lDLon = lLon2 - lLon1;                         
						double lA = Math.Pow(Math.Sin(lDLat/2),2) + Math.Cos(lLat1) * Math.Cos(lLat2) *  Math.Pow(Math.Sin(lDLon/2),2);
						double lC =  2 * Math.Atan2(Math.Sqrt(lA),Math.Sqrt(1-lA));  
						dgKMET.Rows.Add(listCoor[x].FECHA, listCoor[x].HORA, listCoor[x+1].FECHA, listCoor[x+1].HORA, (6371 * lC));
						kmET = kmET + (6371 * lC);
					}
					
					txtET.Text=decimales(kmET.ToString());
					dgAutorizacionValida[16,0].Value=txtET.Text;
					txtLitrosACargar.Text=decimales((Convert.ToDouble(txtET.Text)/Convert.ToDouble(lblRendOp.Text)).ToString());
				}
				else
				{
					txtET.Text="0";
					txtLitrosACargar.Text="0";
				}
			}
		}
		
		List<Interfaz.Combustible.Datos.Coordenadas> getListaCoordenadas(String fecha_1, String fecha_2, String MAC)
		{
			List<Interfaz.Combustible.Datos.Coordenadas> listCoor = new List<Interfaz.Combustible.Datos.Coordenadas>();
			
			String consulta = "";
			
			if(fecha_1==fecha_2)
				consulta = "select * from mac_"+MAC+" where FECHA between '"+fecha_1+"' and '"+fecha_2+"' and HORA between '"+lblHrUltima.Text+"' and '"+dgAutorizacionValida[5,0].Value.ToString()+"' order by FECHA, HORA, ID ";
			else
				consulta = "select * from mac_"+MAC+" where FECHA between '"+fecha_1+"' and '"+fecha_2+"' order by FECHA, HORA, ID ";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(fecha_1==fecha_2)
				{
					Interfaz.Combustible.Datos.Coordenadas Coordenadas = new Interfaz.Combustible.Datos.Coordenadas();
					
					Coordenadas.FECHA	= conn.leer["FECHA"].ToString();
					Coordenadas.HORA	= conn.leer["HORA"].ToString();
					Coordenadas.LAT		= conn.leer["LAT"].ToString();
					Coordenadas.LON		= conn.leer["LON"].ToString();
					
					listCoor.Add(Coordenadas);
				}
				else if((conn.leer["FECHA"].ToString().Substring(0,10)==fecha_1 && Convert.ToDateTime(conn.leer["HORA"].ToString())>=Convert.ToDateTime(lblHrUltima.Text)) || 
				   (conn.leer["FECHA"].ToString().Substring(0,10)==fecha_2 && Convert.ToDateTime(conn.leer["HORA"].ToString())<=Convert.ToDateTime(dgAutorizacionValida[5,0].Value)) || 
				   (Convert.ToDateTime(conn.leer["FECHA"].ToString())>Convert.ToDateTime(fecha_1) && Convert.ToDateTime(conn.leer["FECHA"].ToString())<Convert.ToDateTime(fecha_2)))
				{
					Interfaz.Combustible.Datos.Coordenadas Coordenadas = new Interfaz.Combustible.Datos.Coordenadas();
					
					Coordenadas.FECHA	= conn.leer["FECHA"].ToString();
					Coordenadas.HORA	= conn.leer["HORA"].ToString();
					Coordenadas.LAT		= conn.leer["LAT"].ToString();
					Coordenadas.LON		= conn.leer["LON"].ToString();
					
					listCoor.Add(Coordenadas);
				}
			}
			conn.conexion.Close();
			
			return (listCoor.Count>0)?listCoor:null;
		}
		
		double Radianes(double val)
	    {
	        return (Math.PI / 180) * val;
	    }
		#endregion
	}
}
