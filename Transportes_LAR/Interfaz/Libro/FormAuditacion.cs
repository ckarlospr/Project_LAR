using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class formAuditacion : Form
	{
		#region CONSTRUCTOR		
		public formAuditacion(FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		#endregion
		
		#region VARIABLES 
		bool abierto = true;
		#endregion
		
		#region INSTANCIAS
		FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormAuditacionLoad(object sender, EventArgs e)
		{
			getDatos();
			getViajes();
			dupCalificaion.SelectedIndex=0;
			tcAudita.TabPages.RemoveAt(1);
			
			//cargaTxtScript();
			
			txtUsuario.Text=refPrincipal.nombreUsuario.ToString();
			txtUsuario2.Text=refPrincipal.nombreUsuario.ToString();
			
			txtUsu1.Text=refPrincipal.nombreUsuario.ToString();
			txtUsu2.Text=refPrincipal.nombreUsuario.ToString();
			
			dtInicio.Value=DateTime.Now;
            dtCorte.Value = DateTime.Now;		
		}
		#endregion
		
		#region VALIDACION
		private void getCargarValidacionCampos(formAuditacion formAud)
		{
			formAud.txtPrecio.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAud.txtAnticipo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		/************************************************************************************************************************************************/
		/************************************************************************************************************************************************/
		/************************************************************************************************************************************************/
		
		#region [ COSTOS ]
		
		#region GET DATAGRIDVIEW
		void getDatos()
		{
			dgDatos.Rows.Clear();
			
			String consulta = "";
			if(cbMuestra.Checked==false)
			{
				consulta = "select RE.ID_RE, CS.Nombre, RE.RESPONSABLE, RE.FECHA_SALIDA, RE.DESTINO from RUTA_ESPECIAL RE, ContactoServicio CS where RE.ID_C=CS.IdCliente and RE.FECHA_SALIDA>='"+DateTime.Now.ToString("dd/MM/yyyy")+"' and RE.estado='Activo'  and RE.ID_RE not in (select ID_RE from DATOS_AUDITADOS) order by RE.FECHA_SALIDA";
			}
			else
			{
				consulta = "select RE.ID_RE, CS.Nombre, RE.RESPONSABLE, RE.FECHA_SALIDA, RE.DESTINO from RUTA_ESPECIAL RE, ContactoServicio CS where RE.ID_C=CS.IdCliente and RE.FECHA_SALIDA>='"+DateTime.Now.ToString("dd/MM/yyyy")+"' and RE.estado='Activo' order by RE.FECHA_SALIDA";
			}
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID_RE"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["RESPONSABLE"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["DESTINO"].ToString());
			}
			
			conn.conexion.Close();
			
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region MUESTRA DATOS
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				muestrDatos();
			}
		}
		
		void muestrDatos()
		{
			String consulta = "select R.tipoVehiculo, R.ID_RE, C.Nombre, responsable as Responsable, R.fecha, RT.HoraInicio, R.fecha_salida, R.h_planton, R.cant_unidades, R.domicilio, R.destino, CL.Estado, CL.Rumbo,  R.casetas, R.precio, C.Telefono As Telefono, R.factura, R.observaciones,  R.correo, R.fecha_regreso, R.anticipo, R.estado as Estado_especial, RT.CompletoCamioneta, R.CONF_CLIENTE from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID and RT.Sentido='ENTRADA' and R.ID_RE="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				txtResponsable.Text = conn.leer["Responsable"].ToString();
				txtResponsable2.Text = conn.leer["Responsable"].ToString();
				txtHora.Text = conn.leer["HoraInicio"].ToString();
				txtSalida.Text = conn.leer["fecha_salida"].ToString().Substring(0,10);
				txtCantidad.Text = conn.leer["cant_unidades"].ToString();
				txtDomicilio.Text = conn.leer["domicilio"].ToString();
				txtDestino.Text = conn.leer["destino"].ToString();
				txtCruces.Text = conn.leer["Rumbo"].ToString();
				txtColonia.Text = conn.leer["Estado"].ToString();
				txtTelefono.Text = conn.leer["Telefono"].ToString();
				txtTipo.Text = conn.leer["tipoVehiculo"].ToString();
				// = conn.leer["observaciones"].ToString();
				txtRegreso.Text= conn.leer["fecha_regreso"].ToString().Substring(0,10);
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTO FECHAS
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			limpiaDatos();
			getDatos();
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			limpiaDatos();
			getDatos();
		}
		#endregion
		
		#region LIMPIA DATOS
		void limpiaDatos()
		{
			txtResponsable.Text = "";
			txtResponsable2.Text = "";
			txtHora.Text = "";
			txtSalida.Text = "";
			txtCantidad.Text = "";
			txtDomicilio.Text = "";
			txtDestino.Text = "";
			txtCruces.Text = "";
			txtColonia.Text = "";
			txtTelefono.Text = "";
			txtTipo.Text = "";
			txtRegreso.Text = "";
			txtPrecio.Text = "0";
			txtAnticipo.Text = "0";
			txtComentario.Text = "";
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtPrecio.Text!="0" && txtPrecio.Text!="")
			{
				String miconsult = "insert into DATOS_AUDITADOS values ('"+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString()+"','"+txtPrecio.Text+"','"+txtAnticipo.Text+"', '"+txtComentario.Text+"', '"+((cbDiferencias.Checked==true)?1:0)+"', '1', '"+refPrincipal.idUsuario+"',(SELECT CONVERT (date, SYSDATETIME())),(SELECT CONVERT(VARCHAR,getdate(),108)))";	//
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				limpiaDatos();
				dgDatos.Rows.RemoveAt(dgDatos.CurrentRow.Index);
				dgDatos.ClearSelection();
			}
			else
			{
				MessageBox.Show("Ingrese precio");
			}
		}
		
		void CmdNoAplicaClick(object sender, EventArgs e)
		{
			String miconsult = "insert into DATOS_AUDITADOS values ('"+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString()+"','N/A','N/A','N/A', '"+((cbDiferencias.Checked==true)?1:0)+"','0','"+refPrincipal.idUsuario+"',(SELECT CONVERT (date, SYSDATETIME())),(SELECT CONVERT(VARCHAR,getdate(),108)))";	//
			conn.getAbrirConexion(miconsult);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			limpiaDatos();
			dgDatos.Rows.RemoveAt(dgDatos.CurrentRow.Index);
			dgDatos.ClearSelection();
		}
		#endregion
		
		void CmdScriptClick(object sender, EventArgs e)
		{
			if(abierto==false)
			{
				 this.Size = new System.Drawing.Size(780, 708);
				 abierto = true;
			}
			else
			{
				this.Size = new System.Drawing.Size(1235, 708);
				 abierto = false;				
			}
				
		}
		
		void CbDiferenciasCheckedChanged(object sender, EventArgs e)
		{
			if(cbDiferencias.Checked==true)
			{
				txtPrecio.Text="0";
				txtAnticipo.Text="0";
				txtPrecio.Enabled=false;
				txtAnticipo.Enabled=false;
			}
			else
			{
				txtPrecio.Enabled=true;
				txtAnticipo.Enabled=true;
			}
		}
		#endregion
		
		
		/************************************************************************************************************************************************/
		/************************************************************************************************************************************************/
		/************************************************************************************************************************************************/
		
		
		#region [ ENCUESTA ]
		
		#region GET DGVIAJES
		void getViajes()
		{
			dgViajes.Rows.Clear();
			
			String consulta = "select RE.ID_RE, CS.Nombre, RE.RESPONSABLE, RE.FECHA_SALIDA, RE.DESTINO, CS.Telefono from RUTA_ESPECIAL RE, ContactoServicio CS where RE.ID_C=CS.IdCliente and RE.FECHA_SALIDA between '01/01/"+DateTime.Now.ToString("yyyy")+"' and '"+DateTime.Now.ToString("dd/MM/yyyy")+"' and RE.estado='Activo'  and RE.ID_RE not in (select ID_RE from ENCUESTA) order by RE.FECHA_SALIDA desc";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgViajes.Rows.Add(conn.leer["ID_RE"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["RESPONSABLE"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["DESTINO"].ToString(), conn.leer["Telefono"].ToString());
			}
			
			conn.conexion.Close();
			
			dgViajes.ClearSelection();
		}
		#endregion
		
		#region MUESTRA DATOS
		void DgViajesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				muestraViaje();
			}
		}
		
		void muestraViaje()
		{
			String consulta = "select R.tipoVehiculo, R.ID_RE, C.Nombre, responsable as Responsable, R.fecha, RT.HoraInicio, R.fecha_salida, R.h_planton, R.cant_unidades, R.domicilio, R.destino, CL.Estado, CL.Rumbo,  R.casetas, R.precio, C.Telefono As Telefono, R.factura, R.observaciones,  R.correo, R.fecha_regreso, R.anticipo, R.estado as Estado_especial, RT.CompletoCamioneta, R.CONF_CLIENTE from RUTA_ESPECIAL R, Ruta RT, ContactoServicio C, Cliente CL where RT.IdSubEmpresa=CL.ID and R.ID_C=C.idCliente and R.ID_C=CL.ID and RT.Sentido='ENTRADA' and R.ID_RE="+dgViajes[0,dgViajes.CurrentRow.Index].Value.ToString();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				txtCliente.Text = conn.leer["Responsable"].ToString();
				txtTell.Text=conn.leer["Telefono"].ToString();
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region 
		void BtnGuardaEncuestaClick(object sender, EventArgs e)
		{
			if(dgViajes.SelectedRows.Count==1)
			{
				String miconsult = "insert into ENCUESTA values ('"+dgViajes[0,dgViajes.CurrentRow.Index].Value.ToString()+"','"+refPrincipal.idUsuario+"','1', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), '"+dupCalificaion.Text+"', '"+txtEncuesta.Text+"', '"+((cbLimpieza.Checked==true)?1:0)+"', '"+((cbImagen.Checked==true)?1:0)+"', '"+((cbActitud.Checked==true)?1:0)+"', '"+((cbPuntualidad.Checked==true)?1:0)+"', '"+((cbVelocidad.Checked==true)?1:0)+"', '"+((cbFalla.Checked==true)?1:0)+"')";	
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				dgViajes.Rows.RemoveAt(dgViajes.CurrentRow.Index);
				LimpiaEncuesta();
			}
		}
		#endregion
		#endregion
		
		#region METODOS
		public void generarReporte(){		
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
				
			int i = 1;		
			
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "RESPONSABLE";
			ExcelApp.Cells[i,  3] 	= "FECHA_SALIDA";
			ExcelApp.Cells[i,  4] 	= "CANT UNIDADES";
			ExcelApp.Cells[i,  5] 	= "UNIDAD";
			ExcelApp.Cells[i,  6] 	= "OPERADOR";
			ExcelApp.Cells[i,  7] 	= "DOMICILIO";
			ExcelApp.Cells[i,  8] 	= "DESTINO";
			ExcelApp.Cells[i,  9] 	= "TIPO VEHICULO";
			ExcelApp.Cells[i,  10] 	= "COMENTARIO";
			ExcelApp.Cells[i,  11] 	= "CALIFICACION";
			ExcelApp.Cells[i,  12] 	= "COMENTARIO ENCUESTA";
			ExcelApp.Cells[i,  13] 	= "LIMPIEZA";
			ExcelApp.Cells[i,  14] 	= "IMAGEN";
			ExcelApp.Cells[i,  15] 	= "ACTITUD";
			ExcelApp.Cells[i,  16] 	= "PUNTUALIDAD";
			ExcelApp.Cells[i,  17] 	= "VELOCIDAD";
			ExcelApp.Cells[i,  18] 	= "FALLA";
/*			
			ExcelApp.Cells[i,  1] 	= "ID_RE";
			ExcelApp.Cells[i,  2] 	= "RESPONSABLE";
			ExcelApp.Cells[i,  3] 	= "FECHA_SALIDA";
			ExcelApp.Cells[i,  4] 	= "CANT UNIDADES";
			ExcelApp.Cells[i,  5] 	= "DOMICILIO";
			ExcelApp.Cells[i,  6] 	= "DESTINO";
			ExcelApp.Cells[i,  7] 	= "TIPO VEHICULO";
			ExcelApp.Cells[i,  8] 	= "COMENTARIO";
			ExcelApp.Cells[i,  9] 	= "CALIFICACION";
			ExcelApp.Cells[i,  10] 	= "COMENTARIO ENCUESTA";
			ExcelApp.Cells[i,  11] 	= "LIMPIEZA";
			ExcelApp.Cells[i,  12] 	= "IMAGEN";
			ExcelApp.Cells[i,  13] 	= "ACTITUD";
			ExcelApp.Cells[i,  14] 	= "PUNTUALIDAD";
			ExcelApp.Cells[i,  15] 	= "VELOCIDAD";
			ExcelApp.Cells[i,  16] 	= "FALLA";
			*/
			//String consulta = @"SELECT r.ID_RE, r.RESPONSABLE, CONVERT(CHAR(10),r.FECHA_SALIDA, 103) AS SALIDA, r.CANT_UNIDADES, r.DOMICILIO, r.DESTINO ,r.tipoVehiculo, r.COMENTARIO, e.CALIFICACION, E.COMETARIO AS COMENTARIO_ENC, e.LIMPIEZA, e.IMAGEN, e.ACTITUD, e.PUNTUALIDAD, e.VELOCIDAD, e.FALLA 
			//					FROM RUTA_ESPECIAL R, ENCUESTA E WHERE R.ID_RE = E.ID_RE AND R.estado = 'ACTIVO' AND r.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' order by r.ID_RE";

			String consulta = @"SELECT r.ID_RE, r.RESPONSABLE, CONVERT(CHAR(10),r.FECHA_SALIDA, 103) AS SALIDA, r.CANT_UNIDADES, r.DOMICILIO, r.DESTINO ,r.tipoVehiculo, r.COMENTARIO, e.CALIFICACION, E.COMETARIO AS COMENTARIO_ENC, e.LIMPIEZA, 
								e.IMAGEN, e.ACTITUD, e.PUNTUALIDAD, e.VELOCIDAD, e.FALLA, OP.Alias, v.Numero
								FROM RUTA_ESPECIAL R, ENCUESTA E, RUTA RR, OPERADOR OP, OPERACION_OPERADOR OO, OPERACION O, VEHICULO V
								WHERE R.ID_C = RR.IdSubEmpresa AND RR.ID = O.id_ruta AND O.id_operacion = OO.id_operacion AND OO.id_operador = OP.ID AND V.ID = oo.id_vehiculo and o.estatus = '1'
								AND R.ID_RE = E.ID_RE AND R.estado = 'ACTIVO' and RR.Sentido = 'Entrada' AND r.FECHA_SALIDA BETWEEN '"+dtInicio.Value.ToString("dd/MM/yyyy")+"' AND '"+dtCorte.Value.ToString("dd/MM/yyyy")+"' order by r.ID_RE";
						
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				++i;	
			
			
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID_RE"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["RESPONSABLE"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["SALIDA"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["CANT_UNIDADES"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["Numero"].ToString();
				ExcelApp.Cells[i,  6]	= 	conn.leer["Alias"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["DOMICILIO"].ToString();
				ExcelApp.Cells[i,  8]	= 	conn.leer["DESTINO"].ToString();
				ExcelApp.Cells[i,  9]	= 	conn.leer["tipoVehiculo"].ToString();
				ExcelApp.Cells[i,  10]	= 	conn.leer["COMENTARIO"].ToString();
				ExcelApp.Cells[i,  11]	= 	conn.leer["CALIFICACION"].ToString();
				ExcelApp.Cells[i,  12]	= 	conn.leer["COMENTARIO_ENC"].ToString();
				ExcelApp.Cells[i,  13]	= 	conn.leer["LIMPIEZA"].ToString();
				ExcelApp.Cells[i,  14]	= 	conn.leer["IMAGEN"].ToString();
				ExcelApp.Cells[i,  15]	= 	conn.leer["ACTITUD"].ToString();
				ExcelApp.Cells[i,  16]	= 	conn.leer["PUNTUALIDAD"].ToString();
				ExcelApp.Cells[i,  17]	= 	conn.leer["VELOCIDAD"].ToString();
				ExcelApp.Cells[i,  18]	= 	conn.leer["FALLA"].ToString();	
/*				
				ExcelApp.Cells[i,  1]	= 	conn.leer["ID_RE"].ToString();
				ExcelApp.Cells[i,  2]	= 	conn.leer["RESPONSABLE"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["SALIDA"].ToString();
				ExcelApp.Cells[i,  4]	= 	conn.leer["CANT_UNIDADES"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["DOMICILIO"].ToString();
				ExcelApp.Cells[i,  6]	= 	conn.leer["DESTINO"].ToString();
				ExcelApp.Cells[i,  7]	= 	conn.leer["tipoVehiculo"].ToString();
				ExcelApp.Cells[i,  8]	= 	conn.leer["COMENTARIO"].ToString();
				ExcelApp.Cells[i,  9]	= 	conn.leer["CALIFICACION"].ToString();
				ExcelApp.Cells[i,  10]	= 	conn.leer["COMENTARIO_ENC"].ToString();
				ExcelApp.Cells[i,  11]	= 	conn.leer["LIMPIEZA"].ToString();
				ExcelApp.Cells[i,  12]	= 	conn.leer["IMAGEN"].ToString();
				ExcelApp.Cells[i,  13]	= 	conn.leer["ACTITUD"].ToString();
				ExcelApp.Cells[i,  14]	= 	conn.leer["PUNTUALIDAD"].ToString();
				ExcelApp.Cells[i,  15]	= 	conn.leer["VELOCIDAD"].ToString();
				ExcelApp.Cells[i,  16]	= 	conn.leer["FALLA"].ToString();		
*/		
			}
			conn.conexion.Close();
				
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte de Encuesta "+dtInicio.Value.ToString("dd.MM.yyyy")+ " A "+dtCorte.Value.ToString("dd.MM.yyyy");
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
		
		void LimpiaEncuesta()
		{
			dgViajes.ClearSelection();
			cbLimpieza.Checked=false;
			cbImagen.Checked=false;
			cbActitud.Checked=false;
			cbPuntualidad.Checked=false;
			cbVelocidad.Checked=false;
			cbFalla.Checked=false;
			gbMenor.Enabled=false;
			txtEncuesta.Text="";
			dupCalificaion.SelectedIndex=1;
		}
		
		void colores()
		{
			for(int x=0; x<dgDatos.Rows.Count; x++)
			{
				String consulta="select ID_RE from DATOS_AUDITADOS where id_re="+dgDatos[0,x].Value.ToString();
					
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDatos[1,x].Style.BackColor=Color.MediumSpringGreen;
				}
				
				conn.conexion.Close();
			}
		}
		
		#endregion	
		
		#region BOTONES	
		void BtnExcelReporteClick(object sender, EventArgs e)
		{
			generarReporte();
		}		
		#endregion	
		
		void DupCalificaionKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled=true;
		}
		
		void DupCalificaionSelectedItemChanged(object sender, EventArgs e)
		{
			if(Convert.ToInt16(dupCalificaion.Text)==10)
			{
				gbMenor.Enabled=false;
			}
			else
			{
				gbMenor.Enabled=true;
			}
		}
		
		void CbMuestraCheckedChanged(object sender, EventArgs e)
		{
			getDatos();
			colores();
		}
		
	}
}
