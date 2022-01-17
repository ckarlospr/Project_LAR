using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormReporteNomina : Form
	{
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		public FormReporteNomina()
		{
			InitializeComponent();
		}
		
		public FormReporteNomina(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		
		void Periodo()
		{
			conn.getAbrirConexion("select FECHAINICIO, FECHAFIN from PERIODO WHERE FECHAINICIO <= '"+dtFechaActual.Value.ToString().Substring(0,10)+"' and FECHAFIN >= '"+dtFechaActual.Value.AddDays(-2).ToString().Substring(0,10)+"'");
			conn.leer=conn.comando.ExecuteReader();
            if(conn.leer.Read())
            {
            	dtInicio.Value = (Convert.ToDateTime(conn.leer["FECHAINICIO"].ToString().Substring(0,10)));
            	dtCorte.Value = (Convert.ToDateTime(conn.leer["FECHAFIN"].ToString().Substring(0,10)));
			}
			conn.conexion.Close();
			
			dataBonosPerdidos.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, H.TIPO, H.Motivo, U.usuario " +
			                                                                                       "from NUEVO_HISTORIAL_BONO_OPERADOR h, OPERADOR O, USUARIO U " +
			                                                                                       "WHERE U.ID_usuario=H.iD_USUARIO AND O.ID=H.ID_O AND H.ESTATUS='0'  AND H.FECHA_INICIO='"+dtInicio.Value.ToShortDateString()+"' AND H.FECHA_FIN='"+dtCorte.Value.ToShortDateString()+"' ");
			
			dataBonosBonificados.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, H.TIPO, H.Motivo, U.usuario " +
			                                                                                          "from NUEVO_HISTORIAL_BONO_OPERADOR h, OPERADOR O, USUARIO U " +
			                                                                                          "WHERE U.ID_usuario=H.iD_USUARIO AND O.ID=H.ID_O AND H.BONIFICACION='1' AND H.FECHA_INICIO='"+dtInicio.Value.ToShortDateString()+"' AND H.FECHA_FIN='"+dtCorte.Value.ToShortDateString()+"' ");
			
			datapercepccionesExtras.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, I.DETALLE, I.IMPORTE, U.usuario "+
																										"from NOMINA N, ingreso_nomina I, OPERADOR O, USUARIO U "+
																										"WHERE U.ID_USUARIO=I.ID_USUARIO AND O.ID=N.IDOPERADOR AND N.ID=ID_NOMINA AND N.FECHA_INICIO='"+dtInicio.Value.ToShortDateString()+"' AND N.FECHA_FIN='"+dtCorte.Value.ToShortDateString()+"' ");
			
			dataPrestamosAdicionales.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, DT.IMPORTE, U.usuario "+
																			                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O, USUARIO U "+
																			                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR AND U.ID_USUARIO=D.ID_USUARIO "+
																			                               "and FLUJO!='3' and FLUJO!='5' AND DESCRIPCION ='PRESTAMO ADICIONAL' and DT.FECHA between '"+dtInicio.Value.AddDays(15).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(14).ToString("yyyy/MM/dd")+"' ");
			
			dataAjustesNominales.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, N.Importe1, N.Sueldo_total, U.usuario "+
																										"from NOMINA N, OPERADOR O, USUARIO U "+
																										"WHERE U.ID_USUARIO=N.ID_USUARIO AND O.ID=N.IDOPERADOR AND N.Importe1>'0' AND N.FECHA_INICIO='"+dtInicio.Value.ToShortDateString()+"' AND N.FECHA_FIN='"+dtCorte.Value.ToShortDateString()+"' ");
			dataprestamosdia.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, DT.IMPORTE, U.usuario "+
																			                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O, USUARIO U "+
																			                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR AND U.ID_USUARIO=D.ID_USUARIO "+
																			                               "and FLUJO!='3' and FLUJO!='5' AND DESCRIPCION ='PRESTAMO ADICIONAL' and DT.FECHA between '"+dtInicio.Value.AddDays(15).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(14).ToString("yyyy/MM/dd")+"' ");
			
			dataprestamosborrados.DataSource =  new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, D.IMPORTE_TOTAL, U.usuario, D.observacion "+
																			                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O, USUARIO U "+
																			                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR AND U.ID_USUARIO=D.ID_USUARIO and O.Estatus='1' "+
																			                               "and FLUJO='5' and D.OBSERVACION!='Descuento Nominal Totalizado' and DT.FECHA between '"+dtInicio.Value.ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(2).ToString("yyyy/MM/dd")+"' "+//);// +
																										   "group by O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, D.IMPORTE_TOTAL, U.usuario, D.observacion ");
			
			
			dataBonosPerdidos.AutoSize = true;
			dataBonosBonificados.AutoSize = true;
			datapercepccionesExtras.AutoSize = true;
			dataPrestamosAdicionales.AutoSize = true;
			dataAjustesNominales.AutoSize = true;
			dataprestamosdia.AutoSize = true;
			dataprestamosborrados.AutoSize = true;
			
			for(int x = 0; x < dataprestamosborrados.Rows.Count; x++){
				string cadena = dataprestamosborrados.Rows[x].Cells[6].Value.ToString();
				string[] datos = cadena.Split(':');
				string Sirve = datos[1];
				
				dataprestamosborrados.Rows[x].Cells[6].Value = Sirve;
			}
		}
		
		void FormReporteNominaLoad(object sender, EventArgs e)
		{
			Periodo();
		}
		
		void FormReporteNominaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.reportenomina = false;
		}
		
		void DtFechaActualValueChanged(object sender, EventArgs e)
		{
			Periodo();
		}
	}
}
