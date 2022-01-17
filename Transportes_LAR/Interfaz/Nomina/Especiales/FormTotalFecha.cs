using System;
using System.Drawing;
using System.Windows.Forms;
using nmExcel = Microsoft.Office.Interop.Excel; 

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
	public partial class FormTotalFecha : Form
	{
		public FormTotalFecha(FormCuentasEsp formCuen)
		{
			InitializeComponent();
			formCuentas=formCuen;
		}
		
		#region INSTANCIAS
		FormCuentasEsp formCuentas;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion		
		
		#region EVENTO LOAD
		void FormTotalFechaLoad(object sender, EventArgs e)
		{
			dtpFecha.Value = DateTime.Now;
			for(int x=0; x<formCuentas.dgRelacion.Rows.Count; x++)
			{
				if(formCuentas.dgRelacion[13,x].Value.ToString()=="SI")
				{
					txtImporte.Text=(Convert.ToDouble(txtImporte.Text)+Convert.ToDouble(formCuentas.dgRelacion[5,x].Value)).ToString();
				}
			}
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdGuardarClick(object sender, EventArgs e)
		{
			formCuentas.borrarPagos();
			this.Close();
			formCuentas.Close();
		}
		#endregion
		
		#region EVENTO CLOSING
		void FormTotalFechaFormClosing(object sender, FormClosingEventArgs e)
		{
			formCuentas.Close();
		}
		#endregion
		
		#region GUARDADO DE DATOS
		public void guardadoDatos()
		{
			string consult="insert into COBRO_ESPECIAL values ((SELECT CONVERT (date, SYSDATETIME())),'"+txtImporte.Text+"', "+formCuentas.formPrincipal.idUsuario+")";	//
			conn.getAbrirConexion(consult);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdMostrarClick(object sender, EventArgs e)
		{
			new FormXcobrar().ShowDialog();
		}
		
		void CmdImprimirClick(object sender, EventArgs e)
		{
			new FormRango(this).ShowDialog();
		}
		#endregion
		
		#region IMPRIMIR
		public void imprimirDatos(string fechaInicio, string fechaFin)
		{
			nmExcel.ApplicationClass ExcelApp = new nmExcel.ApplicationClass();
				        
			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Columns.ColumnWidth = 20;
			
			int i = 1;
			
			String consulta = "select C.ID_RE, C.COBRO, OP.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, RE.NUMERO_ANTI, C.SALDO, C.ID IDCC, C.OBSERVACIONES, V.Tipo_Unidad, C.FACTURA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP WHERE C.ID_RUTA_SAL=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and C.ID_RE=RE.ID_RE and C.ID_VEHICULO=V.ID and C.ESTATUS='1' and O.estatus='1' and (C.TIPO='COORDINADOR' OR C.TIPO='OPERADOR') and C.BORRADO='0' and C.INCOBRABLE='0' AND (C.FACTURA='1' OR C.PAGO='1') and RE.FECHA_SALIDA between '"+fechaInicio+"' and '"+fechaFin+"' order by RE.FECHA_SALIDA";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			
			if(conn.leer.Read())
			{
				ExcelApp.Cells[i, 1] = "FECHA";
				ExcelApp.Cells[i, 2] = "DESTINO";
				ExcelApp.Cells[i, 3] = "OPERADOR";
				ExcelApp.Cells[i, 4] = "UNIDAD";
				ExcelApp.Cells[i, 5] = "TIPO";
				ExcelApp.Cells[i, 6] = "VEHICULO";
				ExcelApp.Cells[i, 7] = "IMPORTE";
				ExcelApp.Cells[i, 8] = "FACTURA";
				while(conn.leer.Read())
				{
					i++;
					ExcelApp.Cells[i, 1] = conn.leer["FECHA"].ToString().Substring(0,10);
					ExcelApp.Cells[i, 2] = conn.leer["DESTINO"].ToString();
					ExcelApp.Cells[i, 3] = conn.leer["Alias"].ToString();
					ExcelApp.Cells[i, 4] = conn.leer["Numero"].ToString();
					ExcelApp.Cells[i, 5] = (Convert.ToDouble(conn.leer["PRECIO"].ToString())>1200)?"FORANEA":"LOCAL";
					ExcelApp.Cells[i, 6] = conn.leer["Tipo_Unidad"].ToString();
					ExcelApp.Cells[i, 7] = conn.leer["PRECIO"].ToString();
					ExcelApp.Cells[i, 8] = ((conn.leer["fact"].ToString()=="1")?"SI":"NO");
				}
			}
			
			conn.conexion.Close();
			
			SaveFileDialog CuadroDialogo = new SaveFileDialog();
			CuadroDialogo.DefaultExt = "xls";
			CuadroDialogo.Filter = "xls file(*.xls)|*.xls";
			CuadroDialogo.AddExtension = true;
			CuadroDialogo.RestoreDirectory = true;
			CuadroDialogo.Title = "Guardar";
			CuadroDialogo.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			CuadroDialogo.FileName = "REPORTE VIAJES YA COBRADOS";
			if (CuadroDialogo.ShowDialog() == DialogResult.OK)
			{
				ExcelApp.ActiveWorkbook.SaveCopyAs(CuadroDialogo.FileName);
				ExcelApp.ActiveWorkbook.Saved = true;
				CuadroDialogo.Dispose();
				CuadroDialogo = null;
				ExcelApp.Quit();
				MessageBox.Show("Se exportaron los datos Correctamente ... ");
			}
		}
		#endregion
	}
}
