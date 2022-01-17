using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Transportes_LAR.Interfaz.Nomina
{
	public partial class FormOperadorExterno : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region VARIABLES
		DateTime FechaInicio;
		DateTime FechaCorte;
		
		int x = 0;
		#endregion
		
		#region CONSTRUCTORES
		public FormOperadorExterno()
		{
			InitializeComponent();
		}
		
		public FormOperadorExterno(Interfaz.FormPrincipal principal, String FechaInicioC, String FechaCorteC)
		{
			InitializeComponent();
			this.principal=principal;
			dtInicio.Value = (Convert.ToDateTime(FechaInicioC.Substring(0,10)));
			dtCorte.Value = (Convert.ToDateTime(FechaCorteC.Substring(0,10)));
			FechaInicio = dtInicio.Value;
			FechaCorte = dtCorte.Value;
		}
		#endregion
		
		#region ADAPTADORES
		void Adaptadores()
		{
			dtEmpleado.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, alias as Alias_Op, tipo_empleado from OPERADOR where estatus='1' and (tipo_empleado='Externo' or tipo_empleado='AUX. COORDINADOR' or tipo_empleado='COORDINADOR' or tipo_empleado='MECANICO') order by alias");
		}
		
		void AdaptadorNormales(int x)
		{
			int contador = 0;
			dataViajesNormales.Rows.Clear();
			dataViajesNormales.ClearSelection();
			
			//oscar 27-03-2018 add(R.VELADA / dataViajesNormales[15])
			String Conss = "select R.ID, R.VELADA, C.Empresa as Empresa, R.Nombre as Ruta, O.turno As Turno, O.fecha as Fecha, OO.vehiculo as Vehiculo, R.foranea, R.sentido as Sentido, R.Kilometros, R.Tiempo, R.Tipo, R.HoraInicio, R.Hora_LLEGADA "+
	                               "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
	                               "where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
	                               "and OO.id_operador=OP.ID and C.Empresa!='Especiales' and O.estatus='1' and O.fecha between '"+FechaInicio.ToString().Substring(0,10)+"' AND '"+FechaCorte.ToString().Substring(0,10)+"' and oo.id_operador ="+dtEmpleado[0,x].Value.ToString()+" order by O.fecha";
			
			conn.getAbrirConexion(Conss);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataViajesNormales.Rows.Add();
				dataViajesNormales.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataViajesNormales.Rows[contador].Cells[1].Value = Convert.ToDateTime(conn.leer["Fecha"]).ToShortDateString();
				dataViajesNormales.Rows[contador].Cells[2].Value = conn.leer["Empresa"].ToString();
				dataViajesNormales.Rows[contador].Cells[3].Value = conn.leer["Ruta"].ToString();
				dataViajesNormales.Rows[contador].Cells[4].Value = conn.leer["Sentido"].ToString();
				dataViajesNormales.Rows[contador].Cells[5].Value = conn.leer["Turno"].ToString();
				dataViajesNormales.Rows[contador].Cells[6].Value = conn.leer["Vehiculo"].ToString();
				dataViajesNormales.Rows[contador].Cells[7].Value = conn.leer["foranea"].ToString();
				
				if(dtEmpleado.Rows[this.x].Cells[2].Value.ToString()=="Externo")
					dataViajesNormales.Rows[contador].Cells[8].Value = new Conexion_Servidor.Facturacion.SQL_Facturacion().getPagoExternoSencillo(conn.leer["ID"].ToString());
				
				dataViajesNormales.Rows[contador].Cells[9].Value = "Sencillo";
				dataViajesNormales.Rows[contador].Cells[9].Style.BackColor = Color.MediumBlue;
				dataViajesNormales.Rows[contador].Cells[10].Value = conn.leer["Kilometros"].ToString();
				dataViajesNormales.Rows[contador].Cells[11].Value = conn.leer["Tiempo"].ToString();
				dataViajesNormales.Rows[contador].Cells[12].Value = conn.leer["Tipo"].ToString();
				dataViajesNormales.Rows[contador].Cells[13].Value = conn.leer["HoraInicio"].ToString();
				dataViajesNormales.Rows[contador].Cells[14].Value = conn.leer["Hora_llegada"].ToString();
				
				//oscar 27-03-2018
				if(conn.leer["VELADA"].ToString().Contains("1"))
					dataViajesNormales.Rows[contador].Cells[15].Value = "1";
				else
					dataViajesNormales.Rows[contador].Cells[15].Value =  "0";
				
				++contador;
			}
			conn.conexion.Close();
			
			dataViajesNormales.AutoSize=true;
			
			contador = 0;
			String consulta = 		"select A.ID, O.Alias, A.turno, A.DIA, A.TIPO, A.COMENTARIOS, R.NOMBRE " +
			                      	"from APOYOS A, RUTA R, OPERADOR O " +
									"where A.ID_OP_APOYO=O.ID AND R.ID=A.ID_RUTA AND A.DIA between '"+FechaInicio.ToString().Substring(0,10)+"' AND '"+FechaCorte.ToString().Substring(0,10)+"' and A.ID_OP_APOYO="+dtEmpleado[0,x].Value+" order by A.DIA";
			dataApoyos.Rows.Clear();
			dataApoyos.ClearSelection();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataApoyos.Rows.Add();
				dataApoyos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataApoyos.Rows[contador].Cells[2].Value = conn.leer["Alias"].ToString();
				dataApoyos.Rows[contador].Cells[3].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataApoyos.Rows[contador].Cells[4].Value = conn.leer["NOMBRE"].ToString();
				dataApoyos.Rows[contador].Cells[5].Value = conn.leer["turno"].ToString();
				dataApoyos.Rows[contador].Cells[6].Value = conn.leer["TIPO"].ToString();
				//dataApoyos.Rows[contador].Cells[6].Value = conn.leer["TIPO"].ToString()+" "+conn.leer["NOMBRE"].ToString();
				dataApoyos.Rows[contador].Cells[7].Value = conn.leer["COMENTARIOS"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataApoyos.AutoSize=true;
			if(dataApoyos.RowCount<=0)
			{
				dataApoyos.Visible = false;
				lblApoyo.Visible = false;
			}
			else
			{
				dataApoyos.Visible = true;
				lblApoyo.Visible = true;
			}
		}
		#endregion
		
		#region EXPORTAR EXCEL
		void BtnExcelClick(object sender, EventArgs e)
		{
			Excels.ReporteOperadoresExternos(dataViajesNormales, dataApoyos);
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormOperadorExternoLoad(object sender, EventArgs e)
		{
			Adaptadores();
		}
		
		void FormOperadorExternoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.OperadorExterno = false;
		}
		#endregion
		
		#region EVENTO PRINCIPAL
		void DtOperadorCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				x = dtEmpleado.CurrentRow.Index;
				AdaptadorNormales(x);
				SumaViajesNormales(dataViajesNormales);
			}
		}
		#endregion
		
		#region VALIDACION VIAJES COMPLETOS
		public void SumaViajesNormales(DataGridView dataViajesNormales)
		{
			String FechaViajeNormal="";
			String EmpresaViajenormal="";
			String SentidoViajeNormal="";
			String FechaViajeNormal2="";
			String EmpresaViajenormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal="";
			String TurnoViajeNormal2="";
			String Extra="";
			String Extra2="";

			for(int y = 0; y<(dataViajesNormales.RowCount-1); y++)
			{
				FechaViajeNormal = dataViajesNormales.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales.Rows[y].Cells[2].Value.ToString();
				SentidoViajeNormal = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
				TurnoViajeNormal = dataViajesNormales.Rows[y].Cells[5].Value.ToString();
				Extra = dataViajesNormales.Rows[y].Cells[12].Value.ToString();
				
				if(Extra=="DIF")
					Extra="NRM";
				
				for(int x = 1; x<(dataViajesNormales.RowCount); x++)
				{
					FechaViajeNormal2 = dataViajesNormales.Rows[x].Cells[1].Value.ToString();
					EmpresaViajenormal2 = dataViajesNormales.Rows[x].Cells[2].Value.ToString();
					SentidoViajeNormal2 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
					TurnoViajeNormal2 = dataViajesNormales.Rows[x].Cells[5].Value.ToString();
					Extra2 = dataViajesNormales.Rows[x].Cells[12].Value.ToString();
					
					if(Extra2=="DIF")
						Extra2="NRM";
					
					if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2))
					{
						if((dataViajesNormales.Rows[y].Cells[9].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[9].Value.ToString()!="Completo"))
						{
							dataViajesNormales.Rows[y].Cells[9].Value="Completo";
							dataViajesNormales.Rows[y].Cells[4].Value = "E/S";
							dataViajesNormales.Rows[x].Cells[9].Value="Completo";
							dataViajesNormales.Rows[x].Cells[4].Value = "E/S";
							if(x!=y)
							{
								if((Convert.ToDouble(dataViajesNormales.Rows[y].Cells[10].Value))>=(Convert.ToDouble(dataViajesNormales.Rows[x].Cells[10].Value)))
								{
									if(dtEmpleado.Rows[this.x].Cells[2].Value.ToString()=="Externo")
										dataViajesNormales.Rows[y].Cells[8].Value = new Conexion_Servidor.Facturacion.SQL_Facturacion().getPagoExternoCompleto(dataViajesNormales.Rows[y].Cells[0].Value.ToString());
									dataViajesNormales.Rows[y].Cells[9].Style.BackColor = Color.LimeGreen;
									dataViajesNormales.Rows[y].Cells[9].Style.ForeColor = Color.Black;
									dataViajesNormales.Rows.RemoveAt(x);
									if(x>0)
									    --x;
								}
								else
								{
									if(dtEmpleado.Rows[this.x].Cells[2].Value.ToString()=="Externo")
										dataViajesNormales.Rows[x].Cells[8].Value = new Conexion_Servidor.Facturacion.SQL_Facturacion().getPagoExternoCompleto(dataViajesNormales.Rows[x].Cells[0].Value.ToString());
									dataViajesNormales.Rows[x].Cells[9].Style.BackColor=Color.LimeGreen;
									dataViajesNormales.Rows[x].Cells[9].Style.ForeColor = Color.Black;
									dataViajesNormales.Rows.RemoveAt(y);
									if(x>0)
									{
										--y;
										break;
									}
								}
							}
						}
					}
				}//TERMINA 2 FOR
			}//TERMINA 1 FOR
			if(dtEmpleado.Rows[this.x].Cells[2].Value.ToString()!="Externo")
			{
				PreciosCompletos();
			}
		}
		#endregion
		
		#region FECHA DE INICIO - TERMINO
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			FechaInicio = dtInicio.Value;
			FechaCorte = dtCorte.Value;
			if(dataViajesNormales.RowCount>1)
			{
				AdaptadorNormales(x);
				SumaViajesNormales(dataViajesNormales);
			}
		}
		
		void DtCorteValueChanged(object sender, EventArgs e)
		{
			FechaInicio = dtInicio.Value;
			FechaCorte = dtCorte.Value;
			if(dataViajesNormales.RowCount>1)
			{
				AdaptadorNormales(x);
				SumaViajesNormales(dataViajesNormales);
			}
		}
		#endregion
		
		#region PRECIOS COMPLETOS
		void PreciosCompletos()
		{
			TimeSpan dif;
			double tiempo = 0;
			int domingo = 0;
			int velada = 0;
			DateTime DiaSemanaFacturacion;
			String DiaFacturacion = "";

			for(int a = 0; a<(dataViajesNormales.RowCount);a++)
			{
				DiaSemanaFacturacion = (Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[1].Value));
				DiaFacturacion = DiaSemanaFacturacion.DayOfWeek.ToString();
								
				if(DiaFacturacion == "Sunday")
				{					
					domingo = 1;					
				}
				
				if(dataViajesNormales.Rows[a].Cells[12].Value.ToString() == "VL" || dataViajesNormales.Rows[a].Cells[15].Value.ToString() == "1")
				{
					velada = 1;
				}
				
					string cadena = dataViajesNormales.Rows[a].Cells[14].Value.ToString();
					string[] datos = cadena.Split(':');
					int hora = Convert.ToInt16(datos[0]);
					string minuto = datos[1];
					
					string cadena2 = dataViajesNormales.Rows[a].Cells[13].Value.ToString();
					string[] datos2 = cadena2.Split(':');
					int hora2 = Convert.ToInt16(datos2[0]);
					string minuto2 = datos2[1];
					if(hora == 00 && hora2 == 23){
						hora = 23;
						hora2 = 22;
						dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);
							//MessageBox.Show("min "+dif);
						//hora = 23;
						//hora2 = 22;						
						//dataViajesNormales.Rows[contador].Cells[14].Value = hora +":"+ minuto+":00";
						//dataViajesNormales.Rows[contador].Cells[13].Value = hora2 +":"+ minuto2+":00";
					}else if(hora == 00 && hora2 == 22){
						hora = 23;
						hora2 = 21;
						dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
					}else{
						dif = Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[14].Value) - Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[13].Value);
					}
					
				tiempo = dif.TotalMinutes;
				try
				{
					if(dtEmpleado.Rows[this.x].Cells[2].Value.ToString()!="Externo")
					{
						dataViajesNormales.Rows[a].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas(dataViajesNormales.Rows[a].Cells[9].Value.ToString(), dataViajesNormales.Rows[a].Cells[6].Value.ToString(), Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value), tiempo, domingo, velada, Convert.ToInt32(dataViajesNormales.Rows[a].Cells[7].Value));
					}
					tiempo = 0;
					domingo = 0;
					velada = 0;
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				finally
				{
					conn.conexion.Close();
				}
			}
		}
		#endregion
	}
}
