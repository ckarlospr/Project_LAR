using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace Transportes_LAR.Interfaz.Nomina.Especiales
{
public partial class FormMalFlujo : Form
	{
		#region CONSTRUCTOR	
		public FormMalFlujo(FormPrincipal refPrinc)
		{
			InitializeComponent();
			formPrincipal=refPrinc;
		}
		#endregion
		
		#region VARIABLES
		public bool realizado=false;
		#endregion
		
		#region INSTANCIAS
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();		
		public FormPrincipal formPrincipal;		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region INICIO - FIN		
		void FormMalFlujoLoad(object sender, EventArgs e)
		{
			filtros();
		}
		void FormMalFlujoFormClosing(object sender, FormClosingEventArgs e)
		{
			formPrincipal.revisionMalFlujo = false;
		}
		#endregion	
		
		#region ADAPTADOR
		public void getDatos(String consulta){			
			//int cont = 0;			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			int x=0;
			while(conn.leer.Read())
			{
				dgRelacion.Rows.Add(conn.leer["ID_RE"].ToString(), conn.leer["COBRO"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["TELEFONO"].ToString(), conn.leer["SALDO"].ToString(), conn.leer["DESTINO"].ToString(), conn.leer["FACTURA"].ToString(), conn.leer["FECHA_SALIDA"].ToString().Substring(0,10), conn.leer["NUMERO_FACT"].ToString(), conn.leer["IDENTIFICADOR"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), "E", ((conn.leer["PAGO"].ToString()=="1")?"SI":"NO"), ((conn.leer["fact"].ToString()=="1")?"SI":"NO"), ((conn.leer["INCOBRABLE"].ToString()=="1")?"SI":"NO"), conn.leer["IDCC"].ToString(),conn.leer["anticipo"].ToString(), conn.leer["OBSERVACIONES"].ToString(), ((conn.leer["CASETAS"].ToString()=="N/A")?"0":(conn.leer["CASETAS"]).ToString()), conn.leer["ID_OP"].ToString(), ((conn.leer["OP_COBRA"].ToString()=="1")?"SI":"NO"));
				if(conn.leer["TIPO_VIAJE"].ToString()=="C. PUNTO")
				{
					dgRelacion[5,x].Style.BackColor=Color.Red;
				}
				x++;
			}			
			conn.conexion.Close();	
			lblContador.Text = "Son: "+x;			
		}
		
		#endregion
		
		#region FILTROS
		public void filtros(){
			dgRelacion.Rows.Clear();
			getDatos(@"select C.ID_RE, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA, C.PAGO, C.FACTURA fact, 
			C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, RE.CASETAS, C.ID_OP, RE.OP_COBRA
 			from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O where O.ID=C.ID_OP AND C.ID_VEHICULO=V.ID AND C.ID_RE=RE.ID_RE and C.ESTATUS='1' 
			and RE.FECHA_SALIDA between '"+dtpInicio.Value.ToString("yyyy-MM-dd")+"' AND '"+dtpFin.Value.ToString("yyyy-MM-dd")+"' and C.PAGO = 1 and re.ID_RE not in (select ID_RE from ANTICIPOS_ESPECIALES)");	
	
			coloresDatagrid();
			dgRelacion.ClearSelection();
		}		
		#endregion		
		
		#region COLORES
		public void coloresDatagrid()
		{
			for(int x=0; x<dgRelacion.Rows.Count; x++)
			{
				if(dgRelacion[13,x].Value.ToString()=="SI")
				{
					dgRelacion[13,x].Style.BackColor=Color.MediumBlue;
					dgRelacion[13,x].Style.ForeColor=Color.White;
				}
				if(dgRelacion[14,x].Value.ToString()=="SI")
				{
					dgRelacion[14,x].Style.BackColor=Color.OrangeRed;
					dgRelacion[14,x].Style.ForeColor=Color.White;
				}
				if(dgRelacion[15,x].Value.ToString()=="SI")
				{
					dgRelacion[15,x].Style.BackColor=Color.Red;
					dgRelacion[15,x].Style.ForeColor=Color.White;
				}
				if(dgRelacion[13,x].Value.ToString()=="SI" && dgRelacion[14,x].Value.ToString()=="SI")
				{
					for(int y=0; y<10; y++)
					{
						dgRelacion[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
			}
		}
		#endregion
		
		#region EVENTOS FECHAS		
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			filtros();
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			filtros();
		}
		#endregion
		
		#region BOTONES		
		void CmdPagoClick(object sender, EventArgs e)
		{
			List<int> rowsSelect = new List<int>();
			//prende();
			if(dgRelacion.SelectedRows.Count>0)
			{
				new FormFormaPago2(this).ShowDialog();
				if(realizado==true)
				{
					for(int x=0; x<dgRelacion.Rows.Count; x++)
					{
						if(dgRelacion[2,x].Selected==true /*&& dgRelacion[13,x].Value.ToString()=="NO" && dgRelacion[15,x].Value.ToString()=="NO"*/)
						{
							dgRelacion[13,x].Style.BackColor=Color.MediumBlue;
							dgRelacion[13,x].Style.ForeColor=Color.White;
							dgRelacion[13,x].Value="SI";
							
							conn.getAbrirConexion("INSERT INTO AUDITA_COBRO_ESP VALUES ('"+dgRelacion[16,x].Value.ToString()+"', 'PAGADO', 'N/A', '"+formPrincipal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))");
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
							
							rowsSelect.Add(x);
							
						}
					}
					filtros();
				}
				realizado=false;
			}			
		}		
		#endregion
		
		#region EVENTOS DE DATAGRIDVIEW
		void DgRelacionDoubleClick(object sender, EventArgs e)
		{
			if(dgRelacion.CurrentRow.Index>-1 && dgRelacion.CurrentCell.ColumnIndex!=19)
			{
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(dgRelacion[0,dgRelacion.CurrentRow.Index].Value));
				formDatos.FormBorderStyle=FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();
			}			
		}
		#endregion
	}
}
