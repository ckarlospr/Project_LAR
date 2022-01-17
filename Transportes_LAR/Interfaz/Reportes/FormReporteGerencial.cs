using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using Transportes_LAR.Interfaz.Operaciones;
 

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormReporteGerencial : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		Interfaz.FormPrincipal principal = null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region VARIABLES
		int acumulador = 0;
		int progreso = 1;
		#endregion
		
		#region CONTRUCTORES
		public FormReporteGerencial()
		{
			InitializeComponent();
		}
		
		public FormReporteGerencial(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region ADAPTADOR
		void AdaptadorNormales()
		{
			int contador = 0;
			String sentencia = "select C.Empresa as Empresa, C.SubNombre as SubNombre, R.Nombre as Ruta, R.tipo, " +
			                      	"O.turno As Turno, O.fecha as Fecha, C.tipo_cobro as Viaje, C.Dato, " +
			                        "OO.vehiculo as Vehiculo, O.llegada, R.sentido as Sentido, Oe.Nombre as Nombre, R.Velada, R.HoraInicio, R.HORA_LLEGADA, R.kilometros, R.foranea, OP.alias "+                                                   
                               		"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe "+
                               		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                    "and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID and " +
									"O.fecha between '"+dtInicio.Value.ToShortDateString()+"' AND '"+dtCorte.Value.ToShortDateString()+"' and R.FACTURA!='1' " +
                                    "order by O.fecha, R.Nombre ";
			
			dataViajesNormales.Rows.Clear();
			dataViajesNormales.ClearSelection();
			
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataViajesNormales.Rows.Add();
				dataViajesNormales.Rows[contador].Cells[0].Value = "Sencillo";
				dataViajesNormales.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dataViajesNormales.Rows[contador].Cells[2].Value = conn.leer["Empresa"].ToString();
				dataViajesNormales.Rows[contador].Cells[3].Value = conn.leer["SubNombre"].ToString();
				dataViajesNormales.Rows[contador].Cells[4].Value = conn.leer["Ruta"].ToString();
				dataViajesNormales.Rows[contador].Cells[5].Value = conn.leer["Sentido"].ToString();
				dataViajesNormales.Rows[contador].Cells[6].Value = conn.leer["Turno"].ToString();
				dataViajesNormales.Rows[contador].Cells[8].Value = conn.leer["Vehiculo"].ToString();
				dataViajesNormales.Rows[contador].Cells[9].Value = conn.leer["tipo"].ToString();
				dataViajesNormales.Rows[contador].Cells[10].Value = conn.leer["Dato"].ToString();
				if(conn.leer["Nombre"].ToString().Contains("CAMIONETAS")==true)
					dataViajesNormales.Rows[contador].Cells[7].Value = "CAMIONETA";
				else
					dataViajesNormales.Rows[contador].Cells[7].Value = "CAMION";
				dataViajesNormales.Rows[contador].Cells[11].Value = conn.leer["Velada"].ToString();
				dataViajesNormales.Rows[contador].Cells[12].Value = conn.leer["HoraInicio"].ToString();
				dataViajesNormales.Rows[contador].Cells[13].Value = conn.leer["HORA_LLEGADA"].ToString();
				dataViajesNormales.Rows[contador].Cells[14].Value = conn.leer["llegada"].ToString();				
				dataViajesNormales.Rows[contador].Cells[15].Value = conn.leer["kilometros"].ToString();
				dataViajesNormales.Rows[contador].Cells[16].Value = conn.leer["foranea"].ToString();
				dataViajesNormales.Rows[contador].Cells[17].Value = new Transportes_LAR.Proceso.Semana().SemanaAno(Convert.ToDateTime(conn.leer["Fecha"]));
				dataViajesNormales.Rows[contador].Cells[18].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			ValidarViajes();
		}
		#endregion
		
		#region SENCILLOS O COMPLETOS
		void ValidarViajes()
		{
			String FechaViajeNormal="";
			String EmpresaViajenormal="";
			String RutaViajeNormal="";
			String SentidoViajeNormal="";
			String FechaViajeNormal2="";
			String EmpresaViajenormal2="";
			String RutaViajeNormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal="";
			String TurnoViajeNormal2="";
			String VehiculoNormal="";
			String VehiculoNormal2="";
			String Extra="";
			String Extra2="";
			String SubEmpresa="";
			String SubEmpresa2="";
			String Alias="";
			String Alias2="";
			acumulador = 0;
			progreso = 1;

			for(int y = 0; y<(dataViajesNormales.RowCount-1); y++)
			{
				FechaViajeNormal = dataViajesNormales.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales.Rows[y].Cells[2].Value.ToString();
				RutaViajeNormal = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
				SentidoViajeNormal = dataViajesNormales.Rows[y].Cells[5].Value.ToString();
				TurnoViajeNormal = dataViajesNormales.Rows[y].Cells[6].Value.ToString();
				VehiculoNormal = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
				Extra = dataViajesNormales.Rows[y].Cells[9].Value.ToString();
				SubEmpresa = dataViajesNormales.Rows[y].Cells[10].Value.ToString();
				Alias = dataViajesNormales.Rows[y].Cells[17].Value.ToString();
				
				if(Extra=="DIF")
					Extra="NRM";
				
				for(int x = 1; x<(dataViajesNormales.RowCount); x++)
				{
					progresobarra(dataViajesNormales.RowCount);
					FechaViajeNormal2 = dataViajesNormales.Rows[x].Cells[1].Value.ToString();
					EmpresaViajenormal2 = dataViajesNormales.Rows[x].Cells[2].Value.ToString();
					RutaViajeNormal2 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
					SentidoViajeNormal2 = dataViajesNormales.Rows[x].Cells[5].Value.ToString();
					TurnoViajeNormal2 = dataViajesNormales.Rows[x].Cells[6].Value.ToString();
					VehiculoNormal2 = dataViajesNormales.Rows[x].Cells[7].Value.ToString();
					Extra2 = dataViajesNormales.Rows[x].Cells[9].Value.ToString();
					SubEmpresa2 = dataViajesNormales.Rows[x].Cells[10].Value.ToString();
					Alias2 = dataViajesNormales.Rows[x].Cells[17].Value.ToString();
					
					if(Extra2=="DIF")
					Extra2="NRM";
					
						if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2)&&(Alias==Alias2))
						{
							if((dataViajesNormales.Rows[y].Cells[0].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[0].Value.ToString()!="Completo"))
							{
								dataViajesNormales.Rows[y].Cells[0].Value="Completo";
								dataViajesNormales.Rows[x].Cells[0].Value="Completo";
								dataViajesNormales.Rows[y].Cells[5].Value="E/S";
								dataViajesNormales.Rows[x].Cells[5].Value="E/S";
								dataViajesNormales.Rows[y].Cells[4].Value=dataViajesNormales.Rows[x].Cells[4].Value+" - "+dataViajesNormales.Rows[y].Cells[4].Value;
								//dataViajesNormales.Rows[y].Cells[17].Value=dataViajesNormales.Rows[x].Cells[17].Value+" - "+dataViajesNormales.Rows[y].Cells[17].Value;
								if(x!=y)
								{
									dataViajesNormales.Rows.RemoveAt(x);
									if(y>0)
									--x;
								}
							}
						}
				}
			}
			principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
		}
		#endregion
		
		#region BOTONES
		void BtnReporteDClick(object sender, EventArgs e)
		{
			AdaptadorNormales();
			//Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Importando los datos a Excel...");
			//mensaje.ShowDialog();
			//mensaje.BringToFront();
			Excels.ReporteDirectivoExcel(dataViajesNormales, dtInicio, dtCorte, principal);
		}
		
		void BtnTotalesClick(object sender, EventArgs e)
		{
			Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Importando los datos a Excel...");
			mensaje.ShowDialog();
			mensaje.BringToFront();
			Excels.ReporteTotalesExcel(dtInicio, dtCorte, principal);
		}
		
		void BtnNoCobrablesClick(object sender, EventArgs e)
		{
			Excels.ReporteEva(dtInicio.Value.ToShortDateString(), dtCorte.Value.ToShortDateString());
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormReporteGerencialLoad(object sender, EventArgs e)
		{
			string sentencia = "";
			sentencia = "update OPERACION_OPERADOR set id_vehiculo=109 where id_operacion in (select O.id_operacion from OPERACION_OPERADOR O, OPERADOR OP where O.id_operador=OP.ID and id_vehiculo=1000)";
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();	
		}
		
		void FormReporteGerencialFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.reportegerencial=false;
		}
		#endregion
		
		#region BARRA DE PROCESO
		void progresobarra(int x)
		{
			principal.progressbarPrin.Minimum = 1;
    		principal.progressbarPrin.Maximum = 100;
    		
    		int variable;
    		
			variable = (x/100);
		
			++acumulador;
			
			if(acumulador==variable && progreso<101)
			{
				principal.progressbarPrin.Increment(progreso);
		    	principal.progressbarPrin.Value=progreso;
		    	progreso = progreso + 1;
		    	acumulador = 0;
			}
		}
		#endregion
		
	}
}
