using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Operador.Pre_Seleccion
{
	public partial class FormParametros : Form
	{		
		#region VARIABLES
		bool respuesta = false;
		Int32 id_u;
		public List <Operador.Dato.Zonas> listZonas = null;
		public List <Operador.Dato.Fuentes> listFuentes = null; 
		#endregion
		
		#region CONSTRUCTOR
		public FormParametros(FormContratacion refp, Int32 idU)
		{
			InitializeComponent();
			contratacion = refp;
			id_u = idU;
		}	
		#endregion
		
		#region INSTANCIAS
		FormContratacion contratacion = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Operador.SQL_Operador connO = new Conexion_Servidor.Operador.SQL_Operador();
		#endregion
		
		#region INICIO - FIN
		void FormParametrosLoad(object sender, EventArgs e)
		{			
			adaptador();
			
			txtImagen.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtInfonavit.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtDual.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtDirTrasera.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtTransPersonal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			txtDescEstatal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);			
			txtDescFederal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			txtVigenciaEstatal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtVigenciaFederal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtVigenciaMedico.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			txtNumeroOficina.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			txtNumeroTaller.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
				
		#region ADAPTADOR
		public void adaptador(){			
			try{	
				string sentencia = "select * from PARAMETROS_GENERALES where id = 5";
				conn.getAbrirConexion(sentencia);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					nudEdadMin.Text = conn.leer["PARAMETRO1"].ToString();
					nudEdadMax.Text = conn.leer["PARAMETRO2"].ToString();
					txtImagen.Text = conn.leer["PARAMETRO3"].ToString();
					cmbTatuajes.Text = conn.leer["PARAMETRO4"].ToString();
					cmbPercing.Text = conn.leer["PARAMETRO5"].ToString();
					txtInfonavit.Text = conn.leer["PARAMETRO6"].ToString();
				}		
				conn.conexion.Close();
				
				sentencia = "select * from PARAMETROS_GENERALES where id = 6";
				conn.getAbrirConexion(sentencia);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					txtDual.Text = conn.leer["PARAMETRO1"].ToString();
					txtDirTrasera.Text = conn.leer["PARAMETRO2"].ToString();
					txtTransPersonal.Text = conn.leer["PARAMETRO3"].ToString();
					txtDescEstatal.Text = conn.leer["PARAMETRO4"].ToString();
					txtDescFederal.Text = conn.leer["PARAMETRO5"].ToString();
				}		
				conn.conexion.Close();
				
				sentencia = "select * from PARAMETROS_GENERALES where id = 7";
				conn.getAbrirConexion(sentencia);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){					
					cmbTipoLicEstatal.Text = conn.leer["PARAMETRO1"].ToString();
					txtVigenciaEstatal.Text = conn.leer["PARAMETRO2"].ToString();
					cmbTipoLicFederal.Text = conn.leer["PARAMETRO3"].ToString();
					txtVigenciaFederal.Text = conn.leer["PARAMETRO4"].ToString();
					txtVigenciaMedico.Text = conn.leer["PARAMETRO5"].ToString();
				}		
				conn.conexion.Close();
				
				sentencia = "select * from PARAMETROS_GENERALES where id = 8";
				conn.getAbrirConexion(sentencia);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){					
					txtContactoTaller.Text = conn.leer["PARAMETRO1"].ToString();
					txtNumeroTaller.Text = conn.leer["PARAMETRO2"].ToString();
					txtContactoOficina.Text = conn.leer["PARAMETRO3"].ToString();
					txtNumeroOficina.Text = conn.leer["PARAMETRO4"].ToString();
				}		
				conn.conexion.Close();
				
						
				sentencia = "SELECT COUNT(ID) VALOR FROM PRE_OPERADOR_ZONAS_FUENTES WHERE ESTATUS = 'Activo' AND TIPO = 'ZONA'";
				conn.getAbrirConexion(sentencia);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					txtZona.Text = conn.leer["VALOR"].ToString();			
				conn.conexion.Close();
	
				sentencia = "SELECT COUNT(ID) VALOR FROM PRE_OPERADOR_ZONAS_FUENTES WHERE ESTATUS = 'Activo' AND TIPO = 'FUENTE'";
				conn.getAbrirConexion(sentencia);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					txtFuente.Text = conn.leer["VALOR"].ToString();			
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
		}
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{	
			try{
				if(validaGuadado()){
					connO.modificarParametros(nudEdadMin.Text, nudEdadMax.Text, txtImagen.Text, cmbTatuajes.Text, cmbPercing.Text, txtInfonavit.Text, 5, id_u);
					connO.modificarParametros(txtDual.Text, txtDirTrasera.Text, txtTransPersonal.Text, txtDescEstatal.Text, txtDescFederal.Text, "", 6, id_u);
					connO.modificarParametros(cmbTipoLicEstatal.Text, txtVigenciaEstatal.Text, cmbTipoLicFederal.Text, txtVigenciaFederal.Text, txtVigenciaMedico.Text, "", 7, id_u);
					connO.modificarParametros(txtContactoTaller.Text, txtNumeroTaller.Text, txtContactoOficina.Text, txtNumeroOficina.Text, "", "", 8, id_u);					
					connO.setZonasFuente(listZonas, listFuentes, id_u);
					
					respuesta = true;
				}
			}catch(Exception ex){
				respuesta = false;
				MessageBox.Show("Error al guardar Parámetros : "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
			}
			if(respuesta){
				contratacion.getParametros();
				contratacion.getZonasFuentes();
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Se actualizaron los datos");
				mensaje.Show();
				this.Close();
			}
		}		
		#endregion
		
		#region METODOS
		private bool validaGuadado(){
			respuesta = true;
			errorProvider1.Clear();
			if(nudEdadMin.Text.Length == 0){				
				errorProvider1.SetError(nudEdadMin, "Ingresa la edad mínima");
				nudEdadMin.Focus();
				respuesta = false;
			}
			if(nudEdadMax.Text.Length == 0){				
				errorProvider1.SetError(nudEdadMax, "Ingresa la edad máxima");
				nudEdadMax.Focus();
				respuesta = false;
			}
			if(txtDual.Text.Length == 0){				
				errorProvider1.SetError(txtDual, "Ingresa la experiencia mínima");
				txtDual.Focus();
				respuesta = false;
			}
			if(txtDirTrasera.Text.Length == 0){				
				errorProvider1.SetError(txtDirTrasera, "Ingresa la experiencia mínima");
				txtDirTrasera.Focus();
				respuesta = false;
			}
			if(txtTransPersonal.Text.Length == 0){				
				errorProvider1.SetError(txtTransPersonal, "Ingresa la experiencia mínima");
				txtTransPersonal.Focus();
				respuesta = false;
			}
			if(cmbTipoLicEstatal.SelectedIndex == -1){				
				errorProvider1.SetError(cmbTipoLicEstatal, "Ingresa el tipo de licencia Estatal");
				cmbTipoLicEstatal.Focus();
				respuesta = false;
			}			
			if(txtVigenciaEstatal.Text.Length == 0){				
				errorProvider1.SetError(txtVigenciaEstatal, "Ingresa los meses de vigencia para la Licencia Estatal");
				txtVigenciaEstatal.Focus();
				respuesta = false;
			}
			if(cmbTipoLicFederal.SelectedIndex == -1){				
				errorProvider1.SetError(cmbTipoLicFederal, "Ingresa el tipo de licencia Federal");
				cmbTipoLicFederal.Focus();
				respuesta = false;
			}			
			if(txtVigenciaFederal.Text.Length == 0){				
				errorProvider1.SetError(txtVigenciaFederal, "Ingresa los meses de vigencia para la Licencia Federal");
				txtVigenciaFederal.Focus();
				respuesta = false;
			}		
			if(txtVigenciaMedico.Text.Length == 0){				
				errorProvider1.SetError(txtVigenciaMedico, "Ingresa los meses de vigencia para el Apto Medico");
				txtVigenciaMedico.Focus();
				respuesta = false;
			}
			return respuesta;
		}
		#endregion		
		
		#region EVENTOS
		void FormParametrosKeyUp(object sender, KeyEventArgs e)
		{			
			if(e.KeyCode == Keys.Escape)
				this.Close();
		}
		
		void TxtZonaClick(object sender, EventArgs e)
		{
			new FormZonasFuentes(this, id_u).ShowDialog();
		}
		
		void TxtFuenteClick(object sender, EventArgs e)
		{
			new FormZonasFuentes(this, id_u).ShowDialog();
		}
		#endregion
		
		#region BOTON-EXCEL
		
		void BtnExcelClick(object sender, EventArgs e)
		{
			generaExcelReportePreSeleccion();
		}
		
		#endregion
		
		#region REPORTE-EXCEL
		
		private void generaExcelReportePreSeleccion()
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();			
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;			
			ExcelApp.Cells[i,  1] 	= "NOMBRE";
			ExcelApp.Cells[i,  2]   = "APELLIDO_PAT";
			ExcelApp.Cells[i,  3]   = "APELLIDO_MAT";
			ExcelApp.Cells[i,  4]   = "FECHA_NACIMIENTO";
			ExcelApp.Cells[i,  5]   = "LUGAR_NACIMIENTO";
			ExcelApp.Cells[i,  6]   = "MUNICIPIO_NACIMIENTO";
			ExcelApp.Cells[i,  7]   = "ESTADO_NACIMIENTO";
			ExcelApp.Cells[i,  8]   = "ZONA";
			ExcelApp.Cells[i,  9]   = "FUENTE";
			ExcelApp.Cells[i,  10]  = "DETALLE_FUENTE";
			ExcelApp.Cells[i,  11]  = "DIA";
			ExcelApp.Cells[i,  12]  = "TATUAJES";
			ExcelApp.Cells[i,  13]  = "CALLE";
			ExcelApp.Cells[i,  14]  = "NUM_EXT";
			ExcelApp.Cells[i,  15]  = "NUM_INT";
			ExcelApp.Cells[i,  16]  = "MUNICIPIO";
			ExcelApp.Cells[i,  17]  = "COLONIA";
			ExcelApp.Cells[i,  18]  = "CP";
			ExcelApp.Cells[i,  19]  = "ESTADO";
			ExcelApp.Cells[i,  20]  = "CRUCE1";
			ExcelApp.Cells[i,  21]  = "CRUCE2";
			ExcelApp.Cells[i,  22]  = "TIPO_CASA";
			ExcelApp.Cells[i,  23]  = "DUAL";
			ExcelApp.Cells[i,  24]  = "DIR_TRASERA";
			ExcelApp.Cells[i,  25]  = "TRANSP_PERSONAL";
			ExcelApp.Cells[i,  26]  = "TIPO_ESTATAL";
			ExcelApp.Cells[i,  27]  = "NUM_ESTATAL";
			ExcelApp.Cells[i,  28]  = "VIGENCIA_ESTATAL";
			ExcelApp.Cells[i,  29]  = "TIPO_FEDERAL";
			ExcelApp.Cells[i,  30]  = "NUM_FEDERAL";
			ExcelApp.Cells[i,  31]  = "VIGENCIA_FEDERAL";
			ExcelApp.Cells[i,  32]  = "NUM_APTO_MEDICO";
			ExcelApp.Cells[i,  33]  = "VIGENCIA_APTO_MEDICO";
			ExcelApp.Cells[i,  34]  = "FLUJO";
			ExcelApp.Cells[i,  35]  = "ESTATUS";
			ExcelApp.Cells[i,  36]  = "FECHA_REGISTRO";
			ExcelApp.Cells[i,  37]  = "HORA_REGISTRO";
			ExcelApp.Cells[i,  38]  = "IMAGEN_PERSONAL";
			ExcelApp.Cells[i,  39]  = "SEXO";
			ExcelApp.Cells[i,  40]  = "PESO";
			ExcelApp.Cells[i,  41]  = "ALTURA";
			ExcelApp.Cells[i,  42]  = "CORREO";
			ExcelApp.Cells[i,  43]  = "INFONAVIT";
			ExcelApp.Cells[i,  44]  = "INFONAVIT_MONTO";
			ExcelApp.Cells[i,  45]  = "PIERCING";
			ExcelApp.Cells[i,  46]  = "DUALM";
			ExcelApp.Cells[i,  47]  = "DIR_TRASERAM";
			ExcelApp.Cells[i,  48]  = "TRANSP_PERSONALM";
			ExcelApp.Cells[i,  49]  = "TRAMITE";
			ExcelApp.Cells[i,  50]  = "TIPO";
			ExcelApp.Cells[i,  51]  = "ESTADO_ESTATAL";
			ExcelApp.Cells[i,  52]  = "ESTADO_FEDERAL";
			ExcelApp.Cells[i,  53]  = "AJUSTE_LIC";
			ExcelApp.Cells[i,  54]  = "MOTIVO_BT";
			ExcelApp.Cells[i,  55]  = "BT";
			ExcelApp.Cells[i,  56]  = "TIPO_TELEFONO";
			ExcelApp.Cells[i,  57]  = "NUMERO";
			
			String consulta = @"select NOMBRE, APELLIDO_PAT, APELLIDO_MAT, FECHA_NACIMIENTO, LUGAR_NACIMIENTO, MUNICIPIO_NACIMIENTO, ESTADO_NACIMIENTO, ZONA, 
								FUENTE, DETALLE_FUENTE, DIA, TATUAJES, CALLE, NUM_EXT, NUM_INT, MUNICIPIO, COLONIA, CP, ESTADO, CRUCE1, CRUCE2, TIPO_CASA, 
								DUAL, DIR_TRASERA, TRANSP_PERSONAL, TIPO_ESTATAL, NUM_ESTATAL, VIGENCIA_ESTATAL, TIPO_FEDERAL, NUM_FEDERAL, VIGENCIA_FEDERAL, NUM_APTO_MEDICO, 
								VIGENCIA_APTO_MEDICO, FLUJO, PRE_OPERADOR.ESTATUS, FECHA_REGISTRO, HORA_REGISTRO, IMAGEN_PERSONAL, SEXO, PESO,ALTURA, CORREO, INFONAVIT, INFONAVIT_MONTO, 
								PIERCING, DUALM, DIR_TRASERAM, TRANSP_PERSONALM, TRAMITE, PRE_OPERADOR.TIPO, ESTADO_ESTATAL, ESTADO_FEDERAL, AJUSTE_LIC, MOTIVO_BT, BT, 
								TELEFONOS_PRE_OPERADOR.TIPO as TIPO_TELEFONO, NUMERO from PRE_OPERADOR, TELEFONOS_PRE_OPERADOR WHERE PRE_OPERADOR.ID = TELEFONOS_PRE_OPERADOR.ID_PREOPERADOR and DESCRIPCION = 'PROPIO'";

			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				++i;			
				ExcelApp.Cells[i,  1]	= 	conn.leer["NOMBRE"].ToString();
				ExcelApp.Cells[i,  2]   =   conn.leer["APELLIDO_PAT"].ToString();
				ExcelApp.Cells[i,  3]	= 	conn.leer["APELLIDO_MAT"].ToString();
				ExcelApp.Cells[i,  4]   =   conn.leer["FECHA_NACIMIENTO"].ToString();
				ExcelApp.Cells[i,  5]	= 	conn.leer["LUGAR_NACIMIENTO"].ToString();
				ExcelApp.Cells[i,  6]   =   conn.leer["MUNICIPIO_NACIMIENTO"].ToString();
				ExcelApp.Cells[i,  7]   =   conn.leer["ESTADO_NACIMIENTO"].ToString();
				ExcelApp.Cells[i,  8]   =   conn.leer["ZONA"].ToString();
				ExcelApp.Cells[i,  9]   =   conn.leer["FUENTE"].ToString();
				ExcelApp.Cells[i,  10]   =   conn.leer["DETALLE_FUENTE"].ToString();
				ExcelApp.Cells[i,  11]   =   conn.leer["DIA"].ToString();
				ExcelApp.Cells[i,  12]   =   conn.leer["TATUAJES"].ToString();
				ExcelApp.Cells[i,  13]   =   conn.leer["CALLE"].ToString();
				ExcelApp.Cells[i,  14]   =   conn.leer["NUM_EXT"].ToString();
				ExcelApp.Cells[i,  15]   =   conn.leer["NUM_INT"].ToString();
				ExcelApp.Cells[i,  16]   =   conn.leer["MUNICIPIO"].ToString();
				ExcelApp.Cells[i,  17]   =   conn.leer["COLONIA"].ToString();
				ExcelApp.Cells[i,  18]   =   conn.leer["CP"].ToString();
				ExcelApp.Cells[i,  19]   =   conn.leer["ESTADO"].ToString();
				ExcelApp.Cells[i,  20]   =   conn.leer["CRUCE1"].ToString();
				ExcelApp.Cells[i,  21]   =   conn.leer["CRUCE2"].ToString();
				ExcelApp.Cells[i,  22]   =   conn.leer["TIPO_CASA"].ToString();
				ExcelApp.Cells[i,  23]   =   conn.leer["DUAL"].ToString();
				ExcelApp.Cells[i,  24]   =   conn.leer["DIR_TRASERA"].ToString();
				ExcelApp.Cells[i,  25]   =   conn.leer["TRANSP_PERSONAL"].ToString();
				ExcelApp.Cells[i,  26]   =   conn.leer["TIPO_ESTATAL"].ToString();
				ExcelApp.Cells[i,  27]   =   conn.leer["NUM_ESTATAL"].ToString();
				ExcelApp.Cells[i,  28]   =   conn.leer["VIGENCIA_ESTATAL"].ToString();
				ExcelApp.Cells[i,  29]   =   conn.leer["TIPO_FEDERAL"].ToString();
				ExcelApp.Cells[i,  30]   =   conn.leer["NUM_FEDERAL"].ToString();
				ExcelApp.Cells[i,  31]   =   conn.leer["VIGENCIA_FEDERAL"].ToString();
				ExcelApp.Cells[i,  32]   =   conn.leer["NUM_APTO_MEDICO"].ToString();
				ExcelApp.Cells[i,  33]   =   conn.leer["VIGENCIA_APTO_MEDICO"].ToString();
				ExcelApp.Cells[i,  34]   =   conn.leer["FLUJO"].ToString();
				ExcelApp.Cells[i,  35]   =   conn.leer["ESTATUS"].ToString();
				ExcelApp.Cells[i,  36]   =   conn.leer["FECHA_REGISTRO"].ToString();
				ExcelApp.Cells[i,  37]   =   conn.leer["HORA_REGISTRO"].ToString();
				ExcelApp.Cells[i,  38]   =   conn.leer["IMAGEN_PERSONAL"].ToString();
				ExcelApp.Cells[i,  39]   =   conn.leer["SEXO"].ToString();
				ExcelApp.Cells[i,  40]   =   conn.leer["PESO"].ToString();
				ExcelApp.Cells[i,  41]   =   conn.leer["ALTURA"].ToString();
				ExcelApp.Cells[i,  42]   =   conn.leer["CORREO"].ToString();
				ExcelApp.Cells[i,  43]   =   conn.leer["INFONAVIT"].ToString();
				ExcelApp.Cells[i,  44]   =   conn.leer["INFONAVIT_MONTO"].ToString();
				ExcelApp.Cells[i,  45]   =   conn.leer["PIERCING"].ToString();
				ExcelApp.Cells[i,  46]   =   conn.leer["DUALM"].ToString();
				ExcelApp.Cells[i,  47]   =   conn.leer["DIR_TRASERAM"].ToString();
				ExcelApp.Cells[i,  48]   =   conn.leer["TRANSP_PERSONALM"].ToString();
				ExcelApp.Cells[i,  49]   =   conn.leer["TRAMITE"].ToString();
				ExcelApp.Cells[i,  50]   =   conn.leer["TIPO"].ToString();
				ExcelApp.Cells[i,  51]   =   conn.leer["ESTADO_ESTATAL"].ToString();
				ExcelApp.Cells[i,  52]   =   conn.leer["ESTADO_FEDERAL"].ToString();
				ExcelApp.Cells[i,  53]   =   conn.leer["AJUSTE_LIC"].ToString();
				ExcelApp.Cells[i,  54]   =   conn.leer["MOTIVO_BT"].ToString();
				ExcelApp.Cells[i,  55]   =   conn.leer["BT"].ToString();
				ExcelApp.Cells[i,  56]   =   conn.leer["TIPO_TELEFONO"].ToString();
				ExcelApp.Cells[i,  57]   =   conn.leer["NUMERO"].ToString();
				
			}
			conn.conexion.Close();
					
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xlsx";
			CuadroDialogo.Filter = "xlsx file(*.xlsx)|*.xlsx";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "Reporte PRE-SELECCION";
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
	}
}
