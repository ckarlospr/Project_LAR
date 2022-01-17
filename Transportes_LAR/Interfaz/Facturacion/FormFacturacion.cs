using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormFacturacion : Form
	{	
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Proceso.PDF PDFs= new Transportes_LAR.Proceso.PDF();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
	//private Interfaz.Nomina.SinPrecio.FormViajesSinPrecio formSinPrecio = null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();		
		private Conexion_Servidor.Facturacion.SQL_Facturacion connF = new Conexion_Servidor.Facturacion.SQL_Facturacion();
		#endregion
		 
		#region VARIABLES
		String FechaInicio;
		String FechaCorte;
		String NomEmpresa="";
		String Fechecarpeta = "";
		String DiaFacturacion = "";
		String FechaPDF = "";
		int cont = 0;
		int inc=0;
		String[]Datos;
		int acumulador = 0;
		int progreso = 1;
		//bool autosize = false;
		
		// Variables precios Rimsa
		double Csencillos, Ccompletos, Calmacen, ClaVenta, CVsencillo, CVCompleto, CDiferenciavanilla;
		#endregion
		
		#region CONSTRUCTORES
		public FormFacturacion(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region DATETIME
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			FechaInicio = (dateInicio.Value.ToShortDateString());
			FechaCorte = (dateCorte.Value.ToShortDateString());
		}
		
		void DtCorteValueChanged(object sender, EventArgs e)
		{
			FechaInicio = (dateInicio.Value.ToShortDateString());
			FechaCorte = (dateCorte.Value.ToShortDateString());
		}
		#endregion
		
		#region EVENTO LOAD - CERRADO
		void FormFacturacionLoad(object sender, EventArgs e)
		{
			Ocultartab();
			Fechecarpeta = DateTime.Now.ToString("yyyy-MM-dd");
			AdaptadorEmpresas();
			if(principal.lblDatoNivel.Text=="MASTER")
			{
				ckAutosize.Enabled = true;
				ckActivarCopia.Enabled = true;
			}
			
			if(principal.lblDatoUsuario.Text=="JANETH")
			{
				ckAutosize.Enabled = true;
				ckActivarCopia.Enabled = true;
			}
			
			if(principal.lblDatoUsuario.Text=="NAVARRO")
			{
				ckAutosize.Enabled = true;
			}
		}
		
		void FormFacturacionFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.Factura=false;
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
				
				if(Extra=="DIF")
					Extra="NRM";
				if(RutaViajeNormal == "SALTO" && Extra == "NRM" && TurnoViajeNormal == "Vespertino")
					RutaViajeNormal = "CASA BLANCA";
				if(EmpresaViajenormal == "GRAN VITA" && RutaViajeNormal == "SALITRE"){
					Extra = "NRM";
					RutaViajeNormal = "AMECA";
				}
				if(EmpresaViajenormal == "GRAN VITA" && RutaViajeNormal == "TALA" && TurnoViajeNormal == "Nocturno" && SentidoViajeNormal == "Entrada"){
					Extra = "NRM";
					RutaViajeNormal = "CUISILLOS";
				}
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
					
					if(Extra2=="DIF")
					Extra2="NRM";	
					if(RutaViajeNormal2 == "SALTO" && Extra2 == "NRM" && TurnoViajeNormal2 == "Vespertino")
						RutaViajeNormal2 = "CASA BLANCA";
					
					if(dataViajesNormales.Rows[y].Cells[4].Value.ToString() !=  dataViajesNormales.Rows[x].Cells[4].Value.ToString()){
						if(EmpresaViajenormal2 == "GRAN VITA" && RutaViajeNormal2 == "SALITRE"){
							Extra2 = "NRM";
							RutaViajeNormal2 = "AMECA";
						}
					}
					if(EmpresaViajenormal2 == "GRAN VITA" && RutaViajeNormal2 == "TALA" && TurnoViajeNormal2 == "Nocturno" && SentidoViajeNormal2 == "Entrada"){
						Extra = "NRM";
						RutaViajeNormal = "CUISILLOS";
					}
					
					
					if(EmpresaViajenormal2=="TRATE TALA" && TurnoViajeNormal2!="Mañana")
					{
						//nada
					}
	//if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2))
					else if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2)) //&&(RutaViajeNormal==RutaViajeNormal2)
						{
							if((dataViajesNormales.Rows[y].Cells[0].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[0].Value.ToString()!="Completo"))
							{
								dataViajesNormales.Rows[y].Cells[0].Value="Completo";
								dataViajesNormales.Rows[x].Cells[0].Value="Completo";
								dataViajesNormales.Rows[y].Cells[5].Value="E/S";
								dataViajesNormales.Rows[x].Cells[5].Value="E/S";
								
								string nombreR1 = "", nombreR2 = "";
								if( (EmpresaViajenormal == "GRAN VITA" && dataViajesNormales.Rows[y].Cells[4].Value.ToString() == "SALITRE") ||
								     (EmpresaViajenormal2 == "GRAN VITA" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "SALITRE") ){
									nombreR1 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
									nombreR2 = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
									dataViajesNormales.Rows[x].Cells[4].Value = nombreR1 +" - "+ nombreR2;		
									dataViajesNormales.Rows[y].Cells[4].Value = nombreR1 +" - "+ nombreR2;
								}else if(EmpresaViajenormal == "GRAN VITA" && dataViajesNormales.Rows[y].Cells[4].Value.ToString() != dataViajesNormales.Rows[x].Cells[4].Value.ToString()){
									nombreR1 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
									nombreR2 = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
									dataViajesNormales.Rows[x].Cells[4].Value = nombreR1 +" - "+ nombreR2;		
									dataViajesNormales.Rows[y].Cells[4].Value = nombreR1 +" - "+ nombreR2;
								}
				
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
		
		void ValidarViajesXNombreRuta()
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
			String Horario="";
			String Horario2="";

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
				Horario = dataViajesNormales.Rows[y].Cells[12].Value.ToString();
				
				if(Extra=="DIF")
					Extra="NRM";
				if(RutaViajeNormal=="TALA II")
					RutaViajeNormal = "TALA";
				//if(RutaViajeNormal=="MESA")
					//RutaViajeNormal = "MOLINOS";
			
				// MODIFICO LALO
				if(RutaViajeNormal=="URBI - MOLINOS")
					RutaViajeNormal = "MOLINOS";
				//
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
					Horario2 = dataViajesNormales.Rows[x].Cells[12].Value.ToString();
			
					if(Extra2=="DIF")
						Extra2="NRM";
					if(RutaViajeNormal2=="TALA II")
						RutaViajeNormal2 = "TALA";
					//if(RutaViajeNormal2=="MESA")
					//	RutaViajeNormal2 = "MOLINOS";					
					
					//if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2)&&(RutaViajeNormal.Contains(RutaViajeNormal2))&&(Horario!="17:00"&&Horario2!="17:00"))
					if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2)&&(RutaViajeNormal == RutaViajeNormal2)&&(Horario!="17:00"&&Horario2!="17:00"))
						{
						if((dataViajesNormales.Rows[y].Cells[0].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[0].Value.ToString()!="Completo"))
							{
								dataViajesNormales.Rows[y].Cells[0].Value="Completo";
								dataViajesNormales.Rows[x].Cells[0].Value="Completo";
								dataViajesNormales.Rows[y].Cells[5].Value="E/S";
								dataViajesNormales.Rows[x].Cells[5].Value="E/S";
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
		
		void ValidarViajesXNombreRutaVitro()
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
			String Horario="";
			String Horario2="";
			String Alias="";
			String Alias2="";

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
				Horario = dataViajesNormales.Rows[y].Cells[12].Value.ToString();
				if(dataViajesNormales.Rows[y].Cells[18].Value.ToString()=="VITRO")
					Alias = "VITRO";
				else
					Alias = "LAR";
				
				if(Extra=="DIF")
					Extra="NRM";
				if(RutaViajeNormal=="TALA II")
					RutaViajeNormal = "TALA";
				
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
					Horario2 = dataViajesNormales.Rows[x].Cells[12].Value.ToString();
					if(dataViajesNormales.Rows[x].Cells[18].Value.ToString()=="VITRO")
						Alias2 = "VITRO";
					else
						Alias2 = "LAR";
			
					if(Extra2=="DIF")
						Extra2="NRM";
					if(RutaViajeNormal2=="TALA II")
						RutaViajeNormal2 = "TALA";
					
					if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2)&&(RutaViajeNormal.Contains(RutaViajeNormal2))&&(Horario!="17:00"&&Horario2!="17:00")&&(Alias==Alias2))
						{
						if((dataViajesNormales.Rows[y].Cells[0].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[0].Value.ToString()!="Completo"))
							{
								dataViajesNormales.Rows[y].Cells[0].Value="Completo";
								dataViajesNormales.Rows[x].Cells[0].Value="Completo";
								dataViajesNormales.Rows[y].Cells[5].Value="E/S";
								dataViajesNormales.Rows[x].Cells[5].Value="E/S";
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
		
		void ValidarViajesPLEXUS()
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

			for(int y = 0; y<(dataViajesNormales.RowCount-1); y++)
			{
				FechaViajeNormal = dataViajesNormales.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales.Rows[y].Cells[2].Value.ToString();
				RutaViajeNormal = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
				SentidoViajeNormal = dataViajesNormales.Rows[y].Cells[5].Value.ToString();
				TurnoViajeNormal = dataViajesNormales.Rows[y].Cells[6].Value.ToString();
				VehiculoNormal = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
				
				for(int x = 1; x<(dataViajesNormales.RowCount); x++)
				{
					progresobarra(dataViajesNormales.RowCount);
					FechaViajeNormal2 = dataViajesNormales.Rows[x].Cells[1].Value.ToString();
					EmpresaViajenormal2 = dataViajesNormales.Rows[x].Cells[2].Value.ToString();
					RutaViajeNormal2 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
					SentidoViajeNormal2 = dataViajesNormales.Rows[x].Cells[5].Value.ToString();
					TurnoViajeNormal2 = dataViajesNormales.Rows[x].Cells[6].Value.ToString();
					VehiculoNormal2 = dataViajesNormales.Rows[x].Cells[7].Value.ToString();
					
					if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(RutaViajeNormal==RutaViajeNormal2))
						{
						if((dataViajesNormales.Rows[y].Cells[0].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[0].Value.ToString()!="Completo"))
							{
								dataViajesNormales.Rows[y].Cells[0].Value="Completo";
								dataViajesNormales.Rows[x].Cells[0].Value="Completo";
								dataViajesNormales.Rows[y].Cells[5].Value="E/S";
								dataViajesNormales.Rows[x].Cells[5].Value="E/S";
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
		
		void ValidarViajesXNombreRutaJabil()
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
			String Horario="";
			String Horario2="";

			for(int y = 0; y<(dataViajesNormales.RowCount-1); y++){
				FechaViajeNormal = dataViajesNormales.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales.Rows[y].Cells[2].Value.ToString();
				RutaViajeNormal = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
				SentidoViajeNormal = dataViajesNormales.Rows[y].Cells[5].Value.ToString();
				TurnoViajeNormal = dataViajesNormales.Rows[y].Cells[6].Value.ToString();
				VehiculoNormal = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
				Extra = dataViajesNormales.Rows[y].Cells[9].Value.ToString();
				SubEmpresa = dataViajesNormales.Rows[y].Cells[10].Value.ToString();
				Horario = dataViajesNormales.Rows[y].Cells[12].Value.ToString();
				
				if(Extra=="DIF")
					Extra="NRM";
				
				if(RutaViajeNormal=="TALA II")
					RutaViajeNormal = "TALA";
			
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
					Horario2 = dataViajesNormales.Rows[x].Cells[12].Value.ToString();
			
					if(Extra2=="DIF")
						Extra2="NRM";
					if(RutaViajeNormal2=="TALA II")
						RutaViajeNormal2 = "TALA";
					
					if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Extra==Extra2)&&(SubEmpresa==SubEmpresa2)&&(RutaViajeNormal == RutaViajeNormal2)&&(Horario!="17:00"&&Horario2!="17:00"))
						{
						if((dataViajesNormales.Rows[y].Cells[0].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[0].Value.ToString()!="Completo"))
							{
								dataViajesNormales.Rows[y].Cells[0].Value="Completo";
								dataViajesNormales.Rows[x].Cells[0].Value="Completo";
								dataViajesNormales.Rows[y].Cells[5].Value="E/S";
								dataViajesNormales.Rows[x].Cells[5].Value="E/S";
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
		
		#region EVENTO-PRINCIPAL
		void DtEmpresaCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1 && dtEmpresa.RowCount>1)
			{
				if(e.ColumnIndex>=0 && e.ColumnIndex<=2){
					if (dtEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("FORSAC")) {
						label4.Text = "Galerias Ctas S";
						label5.Text = "Tabachines Ctas S";
					}
					else {
						label4.Text = "Camionetas Completas";
						label5.Text = "Camionetas Sencillas";
					}
				}
				if(e.ColumnIndex==1)
				{
					NomEmpresa =  dtEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
					EventoFecha();
					MensajeValidador();
					new Conexion_Servidor.Facturacion.SQL_Facturacion().ActualizarValores(NomEmpresa, dateInicio.Value.ToString("dd-MM-yyyy"), dateCorte.Value.ToString("dd-MM-yyyy"));
				}
				
				if(e.ColumnIndex==2)
				{
					NomEmpresa =  dtEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
					lblEmpresa.Text = NomEmpresa;
					Mostrartab();
				}
			}
		}
		
		void DtEmpresaCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1 && dtEmpresa.RowCount>1)
			{
				if(e.ColumnIndex==0)
				{
					NomEmpresa =  dtEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
					EventoFecha();
				}
			}	
		}
		
		void DtEmpresaCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 1 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dtEmpresa.Rows[e.RowIndex].Cells[1] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\pdficon.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
			
			if (e.ColumnIndex == 2 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dtEmpresa.Rows[e.RowIndex].Cells[2] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\detalle.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		#endregion
		
		#region ADAPTADORES PRINCIPALES
		void AdaptadorEmpresas()
		{
			int contador = 0;
			dtEmpresa.Rows.Clear();
			dtEmpresa.ClearSelection();
			//conn.getAbrirConexion("Select Distinct(Empresa) As NombreEmpresa from Cliente where Empresa!='Especiales'");
			conn.getAbrirConexion(@"Select Distinct(Empresa) As NombreEmpresa from Cliente where Empresa not in ('Especiales', 'ALDO AUTOPARTES', 'ALTAMIRA',
									'AUTOGRAFICA', 'FLEXTRONIX', 'INTERPLEX', 'PLEXUS', 'WALKMART', 'GRAN VITA', 'GUADALAJARA PLAZA', 'HENNIGES', 'JABIL', 'RIMSA', 'SUNNINGDALE 2') and ID not in (select ID_cliente from clientesEliminados)");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtEmpresa.Rows.Add();
				dtEmpresa.Rows[contador].Cells[0].Value = conn.leer["NombreEmpresa"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			//dtEmpresa.Rows.Add();
			//dtEmpresa.Rows[contador].Cells[0].Value = "RIMSA VANILLA";
			
			dtEmpresa.Sort(dtEmpresa.Columns[0], ListSortDirection.Ascending);
		}
		
		void AdaptadorNormales()
		{
			int contador = 0;
			String sentencia = "";
			if(lblEmpresa.Text == "TEVA")
				sentencia = "select C.Empresa as Empresa, C.SubNombre as SubNombre, R.Nombre as Ruta, R.tipo, R.ID, "+
							"O.turno As Turno, O.fecha as Fecha, C.tipo_cobro as Viaje, C.Dato, "+ 
							"OO.vehiculo as Vehiculo, R.sentido as Sentido, Oe.Nombre as Nombre, R.Velada, R.HoraInicio, R.kilometros, R.foranea, O.pasajeros, op.Alias, "+
							"CASE WHEN O.turno = 'mañana' THEN 1 "+
								"WHEN O.turno = 'vespertino' THEN 2 "+
      							"ELSE 3 "+
     						"END AS orden "+                                                
							"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe "+ 
							"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+ 
							"and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID AND C.Empresa='TEVA' "+
							"and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.FACTURA!='1' "+
							"order by O.fecha, orden, R.Nombre, HoraInicio ";
			else if(lblEmpresa.Text == "CONVER")
				sentencia = "select C.Empresa as Empresa, C.SubNombre as SubNombre, R.Nombre as Ruta, R.tipo, R.ID, " +
			                      	"O.turno As Turno, O.fecha as Fecha, C.tipo_cobro as Viaje, C.Dato, " +
			                        "OO.vehiculo as Vehiculo, R.sentido as Sentido, Oe.Nombre as Nombre, R.Velada, R.HoraInicio, R.kilometros, R.foranea, O.pasajeros, op.Alias "+                                                   
                               		"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe "+
                               		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                    "and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID AND C.Empresa='"+NomEmpresa+"' and " +
                                    "O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.FACTURA!='1' " +
                                    "order by O.fecha, R.Nombre desc, Sentido  ";
			else sentencia = "select C.Empresa as Empresa, C.SubNombre as SubNombre, R.Nombre as Ruta, R.tipo, R.ID, " +
			                      	"O.turno As Turno, O.fecha as Fecha, C.tipo_cobro as Viaje, C.Dato, " +
			                        "OO.vehiculo as Vehiculo, R.sentido as Sentido, Oe.Nombre as Nombre, R.Velada, R.HoraInicio, R.kilometros, R.foranea, O.pasajeros, op.Alias "+                                                   
                               		"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe "+
                               		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                    "and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID AND C.Empresa='"+NomEmpresa+"' and " +
                                    "O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.FACTURA!='1' " +
                                    "order by O.fecha, Sentido  ";
			
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
				if(conn.leer["Nombre"].ToString().Contains("CAMIONETAS")==true){
					if(conn.leer["SubNombre"].ToString()=="FARMACIAS GUADALAJARA TIEMPO EXTRA" && conn.leer["Vehiculo"].ToString()=="Camión"){
						dataViajesNormales.Rows[contador].Cells[7].Value = "CAMION";
					}
					else{
						dataViajesNormales.Rows[contador].Cells[7].Value = "CAMIONETA";
					}
				}
				else if(conn.leer["Nombre"].ToString().Contains("TRATE")==true){
					dataViajesNormales.Rows[contador].Cells[7].Value = conn.leer["Viaje"].ToString();
				}
				else
					dataViajesNormales.Rows[contador].Cells[7].Value = "CAMION";
				dataViajesNormales.Rows[contador].Cells[11].Value = conn.leer["Velada"].ToString();
				dataViajesNormales.Rows[contador].Cells[12].Value = conn.leer["HoraInicio"].ToString();
				dataViajesNormales.Rows[contador].Cells[13].Value = conn.leer["kilometros"].ToString();
				dataViajesNormales.Rows[contador].Cells[14].Value = conn.leer["foranea"].ToString();
				dataViajesNormales.Rows[contador].Cells[17].Value = conn.leer["pasajeros"].ToString();
				dataViajesNormales.Rows[contador].Cells[18].Value = conn.leer["Alias"].ToString();
				dataViajesNormales.Rows[contador].Cells[19].Value = "0";
				dataViajesNormales.Rows[contador].Cells[20].Value = conn.leer["ID"].ToString();
				
				if(conn.leer["kilometros"].ToString()=="0")
					dataViajesNormales.Rows[contador].Cells[13].Style.BackColor=Color.Red;
				else
					dataViajesNormales.Rows[contador].Cells[13].Style.BackColor=Color.White;
				dataViajesNormales.Rows[contador].Cells[16].Value = new Transportes_LAR.Proceso.Semana().SemanaAno(Convert.ToDateTime(conn.leer["Fecha"]));
				++contador;
			}
			conn.conexion.Close();
			
			//teva camiones
			//dataViajesNormales.Rows.Clear();
			if(lblEmpresa.Text == "TEVA") {
			//dataViajesNormales.Rows.Clear();
			dataViajesNormales.ClearSelection();
			int tamano = dataViajesNormales.RowCount;
			for(int w = 0; w<tamano; w++) {
				for(int x = w+1; x<dataViajesNormales.RowCount; x++){
					//checo si la fecha, turno y ruta son iguales pero el sentido es diferente
					//ultima actualizacion de 08 junio 2018
					if((dataViajesNormales.Rows[w].Cells[1].Value.ToString() == dataViajesNormales.Rows[x].Cells[1].Value.ToString())/*fecha*/
					  && dataViajesNormales.Rows[w].Cells[6].Value.ToString() == dataViajesNormales.Rows[x].Cells[6].Value.ToString()/*turno*/
					  && dataViajesNormales.Rows[w].Cells[4].Value.ToString() == dataViajesNormales.Rows[x].Cells[4].Value.ToString()/*ruta*/
					  && dataViajesNormales.Rows[w].Cells[5].Value.ToString() != dataViajesNormales.Rows[x].Cells[5].Value.ToString())/*sentido*/{
						if(dataViajesNormales.Rows[w].Cells[5].Value.ToString() == "Salida"){
							if(dataViajesNormales.Rows[w].Cells[9].Value.ToString() != "EXT"){
								dataViajesNormales.Rows[w].Cells[12].Value = dataViajesNormales.Rows[x].Cells[12].Value.ToString() +" / "+ dataViajesNormales.Rows[w].Cells[12].Value.ToString();
								dataViajesNormales.Rows[w].Cells[13].Value = dataViajesNormales.Rows[x].Cells[13].Value.ToString() +" / "+ dataViajesNormales.Rows[w].Cells[13].Value.ToString();
								dataViajesNormales.Rows[w].Cells[17].Value = dataViajesNormales.Rows[x].Cells[17].Value.ToString() +" / "+ dataViajesNormales.Rows[w].Cells[17].Value.ToString();
								if(dataViajesNormales.Rows[w].Cells[18].Value.ToString() != dataViajesNormales.Rows[x].Cells[18].Value.ToString())
									dataViajesNormales.Rows[w].Cells[18].Value = dataViajesNormales.Rows[x].Cells[18].Value.ToString() +" / "+ dataViajesNormales.Rows[w].Cells[18].Value.ToString();	
							}
						}
						else{
							if(dataViajesNormales.Rows[w].Cells[9].Value.ToString() != "EXT"){
								dataViajesNormales.Rows[w].Cells[12].Value = dataViajesNormales.Rows[w].Cells[12].Value.ToString() +" / "+ dataViajesNormales.Rows[x].Cells[12].Value.ToString();
								dataViajesNormales.Rows[w].Cells[13].Value = dataViajesNormales.Rows[w].Cells[13].Value.ToString() +" / "+ dataViajesNormales.Rows[x].Cells[13].Value.ToString();
								dataViajesNormales.Rows[w].Cells[17].Value = dataViajesNormales.Rows[w].Cells[17].Value.ToString() +" / "+ dataViajesNormales.Rows[x].Cells[17].Value.ToString();
								if(dataViajesNormales.Rows[w].Cells[18].Value.ToString() != dataViajesNormales.Rows[x].Cells[18].Value.ToString())
									dataViajesNormales.Rows[w].Cells[18].Value = dataViajesNormales.Rows[w].Cells[18].Value.ToString() +" / "+ dataViajesNormales.Rows[x].Cells[18].Value.ToString();	
							}
						}
						if(dataViajesNormales.Rows[w].Cells[9].Value.ToString() != "EXT"){
							dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
							dataViajesNormales.Rows[w].Cells[0].Value = "Completo";
							dataViajesNormales.Rows[w].Cells[5].Value = "E/S";
							dataViajesNormales.Rows.RemoveAt(x);
							tamano--;	
						}
						break;
					}
				}
			}
			}
			DataGridView temp =  dataViajesNormales;
		}
				
		void AdaptadorExtras(DataGridView dtViajesEstandarExtras)
		{
			int contador = 0;
			String sentencia = "select R.Nombre as Ruta, O.turno As Turno, O.fecha as Fecha, " +
			                        "C.tipo_cobro as Vehiculo, R.sentido as Sentido "+                                                   
                               		"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
                               		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                    "and OO.id_operador=OP.ID and C.Empresa='"+NomEmpresa+"' and (R.tipo='APO' or R.tipo='EXT' or R.tipo='DOM') and " +
                                    "O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.FACTURA!='1' " +
                                    "order by O.fecha";
				
			dtViajesEstandarExtras.Rows.Clear();
			dtViajesEstandarExtras.ClearSelection();
			
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtViajesEstandarExtras.Rows.Add();
				dtViajesEstandarExtras.Rows[contador].Cells[0].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dtViajesEstandarExtras.Rows[contador].Cells[1].Value = conn.leer["Turno"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[2].Value = conn.leer["Ruta"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[3].Value = conn.leer["Sentido"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[4].Value = conn.leer["Vehiculo"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			if(dtViajesEstandarExtras.RowCount<=0)
			{
				dtViajesEstandarExtras.Visible = false;
				lblExtraEstandar.Visible = false;
			}
			else
			{
				if(ckAutosize.Checked==true)
				{
					dtViajesEstandarExtras.Visible = true;
					lblExtraEstandar.Visible = true;
					dtViajesEstandarExtras.AutoSize = true;
				}
			}
		}
		#endregion
		
		#region METODO PRINCIPAL
		void EventoFecha()
		{
			if(ckPeriodo.Checked == false)
			{
				if(NomEmpresa=="INTERPLEX")
				{
					dateInicio.Value = dateActual.Value.AddDays(-8);
					dateCorte.Value = dateActual.Value.AddDays(-2);
					EventoPrincipal();
				}
				else if(NomEmpresa=="RIMSA")
				{
					dateInicio.Value = dateActual.Value.AddDays(-14);
					dateCorte.Value = dateActual.Value.AddDays(-1);
					EventoPrincipal();
				}
				else if(NomEmpresa=="RIMSA VANILLA")
				{
					dateInicio.Value = dateActual.Value.AddDays(-7);
					dateCorte.Value = dateActual.Value.AddDays(-1);
					EventoPrincipal();
				}				
				else if(NomEmpresa=="TRACSA")
				{
					DateTime dateValueI;
					DateTime dateValueF;
					String dias = dateActual.Value.ToString("dd-MM-yyyy");
					dias = dias.Substring(0,2);
					String mes = dateActual.Value.ToString("dd-MM-yyyy");
					mes = mes.Substring(3,2);
					String ano = dateActual.Value.ToString("dd-MM-yyyy");
					ano = ano.Substring(6,4);
					
					if(Convert.ToInt32(dias)>15)
					{
						dateValueI = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), 1);
						dateValueF = new DateTime(Convert.ToInt32(ano), Convert.ToInt32(mes), 15);
					}
					else 
					{
						if(mes=="01")
						{
							int cantDias = DateTime.DaysInMonth((Convert.ToInt32(ano)-1), 12);
							dateValueI = new DateTime(Convert.ToInt32(ano), 12, 16);
							dateValueF = new DateTime(Convert.ToInt32(ano), 12, cantDias);
						}
						else
						{
							int cantDias = DateTime.DaysInMonth(Convert.ToInt32(ano), (Convert.ToInt32(mes)-1));
							dateValueI = new DateTime(Convert.ToInt32(ano), (Convert.ToInt32(mes)-1), 16);
							dateValueF = new DateTime(Convert.ToInt32(ano), (Convert.ToInt32(mes)-1), cantDias);
						}
					}
					dateInicio.Value = dateValueI;
					dateCorte.Value = dateValueF;
					EventoPrincipal();
				}
				else
				{
					dateInicio.Value = dateActual.Value.AddDays(-7);
					dateCorte.Value = dateActual.Value.AddDays(-1);
					EventoPrincipal();
				}
			}
			else
				EventoPrincipal();
		}
		
		void EventoPrincipal()
		{
			lblEmpresa.Text = NomEmpresa;
			Ocultartab();
			if(lblEmpresa.Text!="CONVER" && lblEmpresa.Text!="FORSAC" && lblEmpresa.Text!="JABIL" && lblEmpresa.Text!="COREY CAMIONES" && lblEmpresa.Text!="COREY CAMIONETAS" && lblEmpresa.Text!="RIMSA"  && lblEmpresa.Text!="RIMSA VANILLA" && lblEmpresa.Text!="FARMACIAS GUADALAJARA APOYOS" && lblEmpresa.Text!="FARMACIAS GUADALAJARA" && lblEmpresa.Text!="FARMACIAS GUADALAJARA EXTRA" && lblEmpresa.Text!="HENNIGES" && lblEmpresa.Text!="VITRO" && lblEmpresa.Text!="PLEXUS")
			{
				AdaptadorNormales();
				AdaptadorExtras(dataViajesEstandarExtras);
				ValidarViajes();
				
				if(NomEmpresa != "GRAN VITA" && NomEmpresa != "CARESTREAM" && NomEmpresa != "LIVERPOOL")
					CalculoPrecios(); // lalo								
				else{
					if(NomEmpresa == "CARESTREAM" || NomEmpresa == "LIVERPOOL")
						CalculoPreciosCarestreamLiverpool(); // lalo
					else
						CalculoPreciosCONVER_GRANVITA();
				}					
				
				CalculoFacturizacion();
				Dias();
				BorradoVacios();
				Suma();
			}
			else if(lblEmpresa.Text=="FARMACIAS GUADALAJARA")
			{
				AdaptadorNormales();
				ValidarViajes();
				CalculoPreciosFGDL(1);
				FacturizacionFarmacias();
			}
			else if(lblEmpresa.Text=="FARMACIAS GUADALAJARA APOYOS")
			{
				AdaptadorNormales();
				ValidarViajes();
				CalculoPreciosFGDL(1);
				FacturizacionFarmacias();
			}
			else if(lblEmpresa.Text=="FARMACIAS GUADALAJARA EXTRA")
			{
				AdaptadorNormales();
				ValidarViajes();				
				CalculoPreciosFGDL(2);
				FacturizacionFarmaciasExtras();
				FacturizacionFarmaciasExtrasDesglose();
			} 			
			else if(lblEmpresa.Text=="COREY CAMIONES" || lblEmpresa.Text=="COREY CAMIONETAS" || lblEmpresa.Text=="FORSAC")
			{
				AdaptadorNormales();
				AdaptadorExtras(dataViajesExtrasCorey);
				ValidarViajes();
				CalculoPrecios(); // lalo
				CalculoFacturizacionCOREY();
				BorradoVaciosCOREY();
				SumaCOREY();
				SumaFORSACExtra();
			}
			/*
			//forsac123
			else if(lblEmpresa.Text=="FORSAC")
			{
				AdaptadorNormales();
				AdaptadorExtras(dataViajesExtrasForsac);
				ValidarViajes();
				CalculoPrecios(); // lalo
				CalculoFacturizacionCOREY();
				BorradoVaciosFORSAC();
				SumaCOREY();
				SumaFORSACExtra();
			}*/
			else if(lblEmpresa.Text=="RIMSA" || lblEmpresa.Text=="RIMSA VANILLA")
			{
				//AdaptadoresRIMSA();
				PrecioRimsa();
				AdaptadoresRIMSANuevo();
				AdaptadorExtrasRimsa(dataViajesExtrasRimsa);
				totalesRimsa();
				//SumaViajesRIMSALuis();
				//SumaViajesRIMSAChuy();
				//ConsultasRimsaFecha();
				//CalculoRimsa();
				//CalculoRimsa2();
				//SumaRimsa2(); // Rimsa calculo anteriol 
			}					
			else if(lblEmpresa.Text=="HENNIGES" || lblEmpresa.Text=="VITRO")
			{
				AdaptadorNormales();
				ValidarViajesXNombreRuta();
				CalculoFacturizacionHENNIEGES(0);
				CalculoFacturizacionHENNIEGESExtra();
				//CalculoFacturizacionHENNIEGESExtra2();
				CalculoFacturizacionHENNIEGESEspecial();
				if(lblEmpresa.Text=="VITRO")
					CalculoFacturizacionHENNIEGES(3);
				
				CalculoPreciosVitroHenniges(); // lalo
			}
			else if(lblEmpresa.Text=="JABIL")
			{
				AdaptadorNormales();
				ValidarViajesXNombreRutaJabil();
				CalculoFacturizacionJABIL(dataJabilP, 0, "CAMION", dttotalesproduccamion);
				CalculoFacturizacionJABIL(dataJabilA, 1, "CAMION", dttotalesAdminCamion);
				CalculoFacturizacionJABIL(dataJabilP2, 0, "CAMIONETA", dttotalesproduccamioneta);
				CalculoFacturizacionJABIL(dataJabilA2, 1, "CAMIONETA", dttotalesAdmincamioneta);
				PrecioJabil();
			}
			else if(lblEmpresa.Text=="PLEXUS")
			{
				AdaptadorNormales();
				ValidarViajesPLEXUS();
				CalculoFacturizacionPLEXUS(dataCamionLocalPlex, dataCamionForaneoPlex, dataCamionetaLocalPlex, dataCamionetaForaneoPlex
				                          , txtCamionLocal, txtCamionForaneo, txtCamionetaLocal, txtCamionetaForaneo, false);
				CalculoFacturizacionPLEXUS(dataCamionLocalPlexOF, dataCamionForaneaPlexOF, dataCamionetaLocalPlexOF, dataCamionetaForaneaPlexOF,
				                           txtCamionLocalOF, txtCamionForaneoOF, txtCamionetaLocalOF, txtCamionetaForaneaOF, true);
				detalledtPlexus(dtDetalleplex, 1);
				detalledtPlexus(dtDetalleplexOF, 0);
			}
			else if(lblEmpresa.Text=="CONVER")
			{
				AdaptadorNormales();
				AdaptadorExtras(dataViajesEstandarExtras);
				ValidarViajes();
				CalculoPreciosCONVER_GRANVITA();
				CalculoFacturizacion();
				Dias();
				BorradoVacios();
				Suma();
				CalculoFacturizacionCONVER();
			}
		}
		#endregion
		
		#region CALCULO TOTALES REPORTE
		void Suma()
		{			
			// NORMALES
			int CS=0;
			int CNTS=0;
			int CC=0;
			int CNTC=0;
			int almacen=0;
			
			for(int x = 0; x<dataTotales.RowCount; x++)
			{
				CS = CS + (Convert.ToInt32(dataTotales.Rows[x].Cells[6].Value)); //camiones completos
				CNTS = CNTS + (Convert.ToInt32(dataTotales.Rows[x].Cells[4].Value)); //salidas
				CC = CC + (Convert.ToInt32(dataTotales.Rows[x].Cells[5].Value)); //camiones sencillos
				CNTC = CNTC + (Convert.ToInt32(dataTotales.Rows[x].Cells[3].Value)); //entradas
				if (NomEmpresa == "TEVA") {
					CS = CS + (Convert.ToInt32(dataTotales.Rows[x].Cells[12].Value)); //camiones completos almacen
				}
			}
			
			txtCamionesC.Text = CC.ToString();
			txtCamionesS.Text = CS.ToString();
			txtCamionetasC.Text = CNTC.ToString();
			txtCamionetasS.Text = CNTS.ToString();
		}
		#endregion
		
		#region CALCULO FACTURACION	
		//dataViajesNormales.Rows[x].Cells[19].Value = (Math.Round(Convert.ToDouble(conn.leer["PRECIO"]), 2)).ToString();
		void CalculoPrecios()
		{	
			for(int x = 0; x<dataViajesNormales.RowCount; x++){
				//Oscar
				String consss = "";
				if (NomEmpresa == "TEVA" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "ALMACEN") {
					//dataViajesNormales.Rows[x].Cells[0].Value = "Completo";
					conn.getAbrirConexion("select Sentido from RUTA WHERE ID = '"+dataViajesNormales.Rows[x].Cells[20].Value.ToString()+"'");
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						dataViajesNormales.Rows[x].Cells[5].Value = conn.leer["Sentido"].ToString();
					conn.conexion.Close();
				
					//oscar
					if (NomEmpresa == "TEVA" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "ALMACEN" && dataViajesNormales.Rows[x].Cells[9].Value.ToString() == "NRM")
						consss ="Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = 'NA' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' ";
					else consss ="Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = 'Sencillo' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' ";
				}
				else /*
					if (NomEmpresa == "TEVA" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "ZAPOPAN" && dataViajesNormales.Rows[x].Cells[6].Value.ToString() == "Vespertino"){//oscar zapopan
						dataViajesNormales.Rows[x].Cells[0].Value = "Completo";
						//dataViajesNormales.Rows[x].Cells[5].Value = "E/S";
						conn.getAbrirConexion("Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' ");
					}
					else			*/
					/*Oscar*/
				
					if (NomEmpresa == "FORSAC")
						consss ="Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' and IDENTIFICADOR = '" + dataViajesNormales.Rows[x].Cells[4].Value.ToString() + "'";
					else if (NomEmpresa == "TRATE TALA")
						consss ="Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' and IDENTIFICADOR = '" + dataViajesNormales.Rows[x].Cells[4].Value.ToString() + "'";
					else	consss ="Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' ";
				
				conn.getAbrirConexion(consss);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()) {
					//OSCAR precio anterior es de 694
					if(NomEmpresa == "TRACSA" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "REFUGIO")
						dataViajesNormales.Rows[x].Cells[19].Value = "1274.40";
					else if(NomEmpresa == "TEVA" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "ZAPOPAN")
						dataViajesNormales.Rows[x].Cells[19].Value = "1210.19";
					else {
						/*if(NomEmpresa == "TEVA" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "ALMACEN" && dataViajesNormales.Rows[x].Cells[9].Value.ToString() == "EXT")
							dataViajesNormales.Rows[x].Cells[19].Value = "693.54";
						/*else 
							if (NomEmpresa == "TEVA" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION" && dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "ALMACEN" && dataViajesNormales.Rows[x].Cells[9].Value.ToString() == "NRM")
						*/		
						/*else */dataViajesNormales.Rows[x].Cells[19].Value = conn.leer["PRECIO"].ToString();
					}	
				}
				else
					dataViajesNormales.Rows[x].Cells[19].Style.BackColor = Color.Red;
				conn.conexion.Close();
			}
		}		
		
		void CalculoPreciosCarestreamLiverpool()
		{				
			txtCamionesSFo.Text = "0";
			string consulta = "";
			for(int x = 0; x<dataViajesNormales.RowCount; x++){
				if(NomEmpresa == "CARESTREAM"){
					consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and Turno = '"+dataViajesNormales.Rows[x].Cells[6].Value.ToString()+"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' ";
				}else{
					// Liverpool
					if(dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "ARENAL" || dataViajesNormales.Rows[x].Cells[4].Value.ToString() == "AMATITAN")
						dataViajesNormales.Rows[x].Cells[14].Value = "1";
					
					
					if(dataViajesNormales.Rows[x].Cells[6].Value.ToString()=="Medio día")
					{
						consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and IDENTIFICADOR='MEDIO DIA' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
						+"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' and FORANEA = '" +(dataViajesNormales.Rows[x].Cells[14].Value.ToString() == "1"? "SI" : "NO")+ "' ";
					}
					else
					{
						consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
						+"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' and FORANEA = '" +(dataViajesNormales.Rows[x].Cells[14].Value.ToString() == "1"? "SI" : "NO")+ "' ";
					}
				}
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					dataViajesNormales.Rows[x].Cells[19].Value = conn.leer["PRECIO"].ToString();
				else
					dataViajesNormales.Rows[x].Cells[19].Style.BackColor = Color.Red;
				conn.conexion.Close();
				if(dataViajesNormales.Rows[x].Cells[0].Value.ToString() == "Sencillo" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION" && dataViajesNormales.Rows[x].Cells[14].Value.ToString() == "1")
					txtCamionesSFo.Text = (Convert.ToInt32(txtCamionesSFo.Text) + 1).ToString();
			}
		}
		
		void CalculoPreciosVitroHenniges()
		{	
			for(int x = 0; x<dataViajesNormales.RowCount; x++){
				String sentence = "";
				if(NomEmpresa == "VITRO"){
					sentence = "Select PRECIO from dbo.FACTURA_PRECIOS with(nolock) where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and IDENTIFICADOR = '"+dataViajesNormales.Rows[x].Cells[4].Value.ToString()+"' and Turno = '"+dataViajesNormales.Rows[x].Cells[6].Value.ToString()+"' ";
				}else{
					sentence = "Select PRECIO from dbo.FACTURA_PRECIOS with(nolock) where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and TIPO = '"+dataViajesNormales.Rows[x].Cells[8].Value.ToString()+"' and IDENTIFICADOR = '"+dataViajesNormales.Rows[x].Cells[4].Value.ToString()
				                      +"' and Turno = '"+dataViajesNormales.Rows[x].Cells[6].Value.ToString()+"' ";
				}
				conn.getAbrirConexion(sentence);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					dataViajesNormales.Rows[x].Cells[19].Value = conn.leer["PRECIO"].ToString();
				else
					dataViajesNormales.Rows[x].Cells[19].Style.BackColor = Color.Red;
				conn.conexion.Close();
			}
		}
		
		void CalculoPreciosFGDL(int bandera)
		{	
			// bandera 1: NRM, 2: EXT
			string consulta = "";
			for(int x = 0; x<dataViajesNormales.RowCount; x++){
				if(bandera == 1){
					consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"'";
				}else{
					if(dataViajesNormales.Rows[x].Cells[11].Value.ToString() == "1"){
						consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = 'NA' and VEHICULO = 'CAMIONETA' and IDENTIFICADOR = 'VELADA' and TIPO = 'EXT' ";				
						//consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = 'NA' and IDENTIFICADOR = 'VELADA' and TIPO = 'EXT' ";				
					}else{
						consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"'and TIPO = 'EXT' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                      +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"'";	
					}
				}
					
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					dataViajesNormales.Rows[x].Cells[19].Value = conn.leer["PRECIO"].ToString();
				else
					dataViajesNormales.Rows[x].Cells[19].Style.BackColor = Color.Red;
				conn.conexion.Close();
			}
		}
		
		void CalculoPreciosCONVER_GRANVITA()
		{	
			string consulta = ""; // - 
			for(int x = 0; x<dataViajesNormales.RowCount; x++){
				if(NomEmpresa == "GRAN VITA" && dataViajesNormales.Rows[x].Cells[4].Value.ToString().Contains("-")){
					string nombre1 = "", nombre2 = "";
					double precio1 = 0, precio2 = 0;
					
				    Char delimiter = '-';
				    String[] substrings = dataViajesNormales.Rows[x].Cells[4].Value.ToString().Split(delimiter);
				    nombre1 = substrings[0].Trim();
				    nombre2 = substrings[1].Trim();
				    
				    consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' and IDENTIFICADOR = '"+nombre1+"'";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						precio1 = Convert.ToDouble(conn.leer["PRECIO"]);
					conn.conexion.Close();
					
				    consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' and IDENTIFICADOR = '"+nombre2+"'";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						precio2 = Convert.ToDouble(conn.leer["PRECIO"]);
					conn.conexion.Close();
					
					if(precio1 >= precio2)
						dataViajesNormales.Rows[x].Cells[19].Value = precio1;
					else
						dataViajesNormales.Rows[x].Cells[19].Value = precio2;
					
					if(precio1 == 0 && precio2 == 0)
						dataViajesNormales.Rows[x].Cells[19].Style.BackColor = Color.Red;
					
				}else{
					consulta = "Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = '"+NomEmpresa+"' and SENTIDO = '"+dataViajesNormales.Rows[x].Cells[0].Value.ToString()
				                +"' and VEHICULO = '"+dataViajesNormales.Rows[x].Cells[7].Value.ToString()+"' and IDENTIFICADOR = '"+dataViajesNormales.Rows[x].Cells[4].Value.ToString()+"'";
					
						
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						dataViajesNormales.Rows[x].Cells[19].Value = Convert.ToDouble(conn.leer["PRECIO"]);
					else
						dataViajesNormales.Rows[x].Cells[19].Style.BackColor = Color.Red;
					conn.conexion.Close();
				}
			}
		}
		
		void CalculoFacturizacion()
		{	/*
			if(NomEmpresa == "TEVA"){
				Console.WriteLine("HOla");
			}*/
			int contador = 0;
			dataTotales.Rows.Clear();
			try
				{
				conn.getAbrirConexion("Select Distinct(O.fecha) as Fecha " +
				                      "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO "+
                                       "where C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                       "and C.Empresa='"+NomEmpresa+"' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' Order by O.Fecha");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataTotales.Rows.Add();
					dataTotales.Rows[contador].Cells[2].Value = "Mañana";
					dataTotales.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
					++contador;
					dataTotales.Rows.Add();
					dataTotales.Rows[contador].Cells[2].Value = "Medio día";
					dataTotales.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
					++contador;
					dataTotales.Rows.Add();
					dataTotales.Rows[contador].Cells[2].Value = "Vespertino";
					dataTotales.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
					++contador;
					dataTotales.Rows.Add();
					dataTotales.Rows[contador].Cells[2].Value = "Nocturno";
					dataTotales.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
					++contador;
				}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();	
				
				dataViajesNormales.ClearSelection();
				dataTotales.ClearSelection();
				//teva camiones
				
				
				for(int w = 0; w<dataViajesNormales.RowCount; w++)
				{
					progresobarra(dataViajesNormales.RowCount);
					for(int y = 0; y<dataTotales.RowCount; y++)
					{
						if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataTotales.Rows[y].Cells[1].Value.ToString()&&dataViajesNormales.Rows[w].Cells[6].Value.ToString()==dataTotales.Rows[y].Cells[2].Value.ToString())
						{
							if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMION")
							{
								if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
								{ 
									if(dataViajesNormales.Rows[w].Cells[4].Value.ToString()=="ALMACEN" && dataViajesNormales.Rows[w].Cells[2].Value.ToString()!="TEVA ALMACEN"){
										if(dataViajesNormales.Rows[w].Cells[2].Value.ToString()=="TEVA"){
											dataTotales.Rows[y].Cells[6].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[6].Value) + 1;
											dataTotales.Rows[y].Cells[8].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[8].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
											dataTotales.Rows[y].Cells[11].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
											dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
											dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
										}
										else {
											dataTotales.Rows[y].Cells[12].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[12].Value) + 1;
											dataTotales.Rows[y].Cells[13].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[13].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// oscar
											dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
											dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
											dataTotales.Rows[y].Cells[13].Style.BackColor = Color.LightGray;	
										}
									}
									else {
										dataTotales.Rows[y].Cells[6].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[6].Value) + 1;
										dataTotales.Rows[y].Cells[8].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[8].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataTotales.Rows[y].Cells[11].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
									}
									break;
								}
								else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
								{
									dataTotales.Rows[y].Cells[5].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[5].Value) + 1;
									dataTotales.Rows[y].Cells[7].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[7].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataTotales.Rows[y].Cells[11].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
									dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
									break;
								}
							}
							else if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA")
							{
								if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
								{
									dataTotales.Rows[y].Cells[4].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[4].Value) + 1;
									dataTotales.Rows[y].Cells[10].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[10].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataTotales.Rows[y].Cells[11].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
									dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
									break;
								}
								else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
								{
									dataTotales.Rows[y].Cells[3].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[3].Value) + 1;
									dataTotales.Rows[y].Cells[9].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[9].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataTotales.Rows[y].Cells[11].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
									dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
									break;
								}
							}
							else if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="ABIERTO")
							{
								if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
								{
									dataTotales.Rows[y].Cells[6].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[6].Value) + 1;
									dataTotales.Rows[y].Cells[11].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
									dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
									break;
								}
								else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
								{
									dataTotales.Rows[y].Cells[5].Value = Convert.ToInt32(dataTotales.Rows[y].Cells[5].Value) + 1;
									dataTotales.Rows[y].Cells[11].Value = Convert.ToDouble(dataTotales.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
									dataTotales.Rows[y].Cells[11].Style.BackColor = Color.LightGray;
									break;
								}
							}
						}
					}
				}
				
				dataTotales.ClearSelection();
				//correccion 22 mayo 2018 oscar, totales teva
				if(lblEmpresa.Text == "TEVA")
					for(int y = 0; y<dataTotales.RowCount; y++){
						//if(dataTotales.Rows[y].Cells[1].Value.ToString() == "18/05/2018" && dataTotales.Rows[y].Cells[2].Value.ToString() == "Nocturno")//123456
						if(dataTotales.Rows[y].Cells[5].Value != null) {
							conn.getAbrirConexion("Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = 'TEVA' and SENTIDO = 'Completo' and VEHICULO = 'CAMION'");
							conn.leer = conn.comando.ExecuteReader();
							if(conn.leer.Read())
								dataTotales.Rows[y].Cells[7].Value = (float.Parse(conn.leer["PRECIO"].ToString(), CultureInfo.InvariantCulture.NumberFormat)*float.Parse(dataTotales.Rows[y].Cells[5].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat)).ToString();
							conn.conexion.Close();
							//MessageBox.Show(dataTotales.Rows[y].Cells[5].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
						}
						if(dataTotales.Rows[y].Cells[6].Value != null) {
//							conn.getAbrirConexion("Select PRECIO from FACTURA_PRECIOS where ESTATUS = 'Activo' and EMPRESA = 'TEVA' and SENTIDO = 'Sencillo' and VEHICULO = 'CAMION'");
//							conn.leer = conn.comando.ExecuteReader();
//							if(conn.leer.Read())
//								dataTotales.Rows[y].Cells[8].Value = (float.Parse(conn.leer["PRECIO"].ToString(), CultureInfo.InvariantCulture.NumberFormat)*float.Parse(dataTotales.Rows[y].Cells[6].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat)).ToString();
//							conn.conexion.Close();
							//MessageBox.Show(dataTotales.Rows[y].Cells[5].Value.ToString(), "Atención", MessageBoxButtons.YesNo);
						}
						if(dataTotales.Rows[y].Cells[7].Value != null && dataTotales.Rows[y].Cells[8].Value != null) {
							dataTotales.Rows[y].Cells[11].Value = (float.Parse(dataTotales.Rows[y].Cells[7].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat) + float.Parse(dataTotales.Rows[y].Cells[8].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat)).ToString();
						}
						else {
							if(dataTotales.Rows[y].Cells[7].Value == null && dataTotales.Rows[y].Cells[8].Value != null) {
								dataTotales.Rows[y].Cells[11].Value = (float.Parse(dataTotales.Rows[y].Cells[8].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat)).ToString();
							}
							else {
								if(dataTotales.Rows[y].Cells[7].Value != null && dataTotales.Rows[y].Cells[8].Value == null) {
									dataTotales.Rows[y].Cells[11].Value = (float.Parse(dataTotales.Rows[y].Cells[7].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat)).ToString();
								}
								else {
									dataTotales.Rows[y].Cells[11].Value = "0";
								}
							}
						}
					}
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
		}
	    #endregion
	    
	    #region DIAS
		void Dias()
		{
			for(int y = 0; y<dataTotales.RowCount; y++)
				dataTotales.Rows[y].Cells[0].Value = DiaFactura(dataTotales.Rows[y].Cells[1].Value.ToString());
		}
		
		public String DiaFactura(String FechaPDF)
		{
			DateTime DiaSemanaFacturacion;
			DiaFacturacion = "";
			DiaSemanaFacturacion = (Convert.ToDateTime(FechaPDF));
		
			DiaFacturacion = DiaSemanaFacturacion.DayOfWeek.ToString();
			
			if(DiaFacturacion == "Monday")
			{
				DiaFacturacion = "Lunes";
			}
			else if(DiaFacturacion == "Tuesday")
			{
				DiaFacturacion = "Martes";
			}
			else if(DiaFacturacion == "Wednesday")
			{
				DiaFacturacion = "Miércoles";
			}
			else if(DiaFacturacion == "Thursday")
			{
				DiaFacturacion = "Jueves";
			}
			else if(DiaFacturacion == "Friday")
			{
				DiaFacturacion = "Viernes";
			}
			else if(DiaFacturacion == "Saturday")
			{
				DiaFacturacion = "Sábado";
			}
			else if(DiaFacturacion == "Sunday")
			{
				DiaFacturacion = "Domingo";
			}
			return DiaFacturacion;
		}
		#endregion
		
		#region BORRADO VACIOS
		void BorradoVacios()
		{
			for(int y = 0; y<dataTotales.RowCount; y++)
			{
				if((dataTotales.Rows[y].Cells[3].Value==null)&&(dataTotales.Rows[y].Cells[4].Value==null)&&(dataTotales.Rows[y].Cells[5].Value==null)&&(dataTotales.Rows[y].Cells[6].Value==null))
				{
					dataTotales.Rows.RemoveAt(y);
					y=y-1;
				}
			}
		}
		#endregion
		
		#region LLENADO ARREGLO FECHA PDF
		public void LlenadoArregloFecha(String FechaInicio, String FechaCorte)
		{			
				cont = 0;
				inc = 0;
				String sentencia = "";
				
				if(lblEmpresa.Text=="RIMSA" || lblEmpresa.Text=="RIMSA VANILLA" ||lblEmpresa.Text=="FARMACIAS GUADALAJARA"||lblEmpresa.Text=="FARMACIAS GUADALAJARA EXTRA"||ckActivarCopia.Checked==true)
				{
					sentencia = "select Distinct(O.fecha) " +
				                "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
                                "where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                "and OO.id_operador=OP.ID and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' order by O.fecha";
				}
				else
				{
					sentencia = "select Distinct(O.fecha) " +
				                "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
                                "where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                "and OO.id_operador=OP.ID and C.Empresa='"+NomEmpresa+"' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' order by O.fecha";
				}
				
				conn.getAbrirConexion(sentencia);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						cont = cont + 1;
					}
					conn.conexion.Close();	
					
					Datos = new String[cont];
					
					conn.getAbrirConexion(sentencia);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						Datos[inc]= conn.leer["Fecha"].ToString().Substring(0,10);
						++inc;
					}
					conn.conexion.Close();
					
		}	
		#endregion
		
		#region METODO DE IMPRESION PDF
		void ImprimirPDF()
		{
			try
			{
				String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				string newPath = System.IO.Path.Combine(activeDir, "Facturacion "+Fechecarpeta);
		        System.IO.Directory.CreateDirectory(newPath);
				
				Document doc = new Document(PageSize.LETTER, 10, 10 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Facturacion "+Fechecarpeta+@"\"+lblEmpresa.Text+" "+dateInicio.Value.ToString("dd-MM-yyyy")+" "+dateCorte.Value.ToString("dd-MM-yyyy")+" Facturacion.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				
				if(lblEmpresa.Text=="HENNIGES" || lblEmpresa.Text=="VITRO")
				{
					if(lblEmpresa.Text=="VITRO")
					{
						CalculoFacturizacionHENNIEGES(0);
						GenerarDocumentoReporteHENNIGES(doc, writer, "VITRO NORMAL");
						doc.NewPage();
						CalculoFacturizacionHENNIEGES(3);
						GenerarDocumentoReporteHENNIGES(doc, writer, "VITRO EXTRAS");
						doc.NewPage();
						CalculoFacturizacionHENNIEGES(2);
						GenerarDocumentoReporteHENNIGES(doc, writer, "VITRO EXTERNOS");
						doc.NewPage();
						CalculoFacturizacionHENNIEGES(1);
						GenerarDocumentoReporteVITRO2(doc, writer);
					}
					if(lblEmpresa.Text=="HENNIGES")
					{
						GenerarDocumentoReporteHENNIGES(doc, writer, "HENNIGES");
						doc.NewPage();
						GenerarDocumentoReporteHENNIGESExtra(doc, writer);
					}
				}
				else if(lblEmpresa.Text=="RIMSA")
				{
					//GenerarDocumentoReporteRIMSA2(doc, writer);
					//doc.NewPage();
					//GenerarDocumentoReporteRIMSA(doc, writer);
					
					GenerarDocumentoReporteRIMSA3(doc, writer, "");
				}
				else if(lblEmpresa.Text=="RIMSA VANILLA")
				{
					GenerarDocumentoReporteRIMSA3(doc, writer, "VANILLA");
				}
				else if(lblEmpresa.Text=="COREY CAMIONETAS" || lblEmpresa.Text=="COREY CAMIONES")
				{
					GenerarDocumentoReporteCOREY(doc, writer);
				}
				else if(lblEmpresa.Text=="FORSAC")
				{
					GenerarDocumentoReporteFORSAC(doc, writer);
				}
				else if(lblEmpresa.Text=="FARMACIAS GUADALAJARA")
				{
					GenerarDocumentoReporteFGDL(doc, writer);
				}
				else if(lblEmpresa.Text=="FARMACIAS GUADALAJARA EXTRA")
				{
					GenerarDocumentoReporteFGDLExtra(doc, writer);
					doc.NewPage();
					GenerarDocumentoReporteFGDLExtraDesglose(doc, writer);
				}
				else if(lblEmpresa.Text=="JABIL")
				{
					GenerarDocumentoReporteJABIL(doc, writer, 0);
					doc.NewPage();
					GenerarDocumentoReporteJABIL(doc, writer, 1);
					GenerarDocumentoReporteJABILTotales(doc, writer);
				}
				else if(lblEmpresa.Text=="PLEXUS")
				{
					GenerarDocumentoReportePLEXUS(doc, writer);
					doc.NewPage();
					GenerarDocumentoReportePLEXUSOF(doc, writer);
				}
				else if(lblEmpresa.Text=="CARESTREAM")
				{
					GenerarDocumentoReporteCarestream(doc, writer);
				}
				else if(lblEmpresa.Text=="LIVERPOOL")
				{
					GenerarDocumentoReporteLiverpool(doc, writer);
				}				
				else
				{
					GenerarDocumentoReporte(doc, writer);
				}
				doc.Close();
				Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Facturacion "+Fechecarpeta+@"\"+lblEmpresa.Text+" "+dateInicio.Value.ToString("dd-MM-yyyy")+" "+dateCorte.Value.ToString("dd-MM-yyyy")+" Facturacion.pdf");
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		
		#region EVENTO CHECKED
		void CkPeriodoCheckedChanged(object sender, EventArgs e)
		{
			if(ckPeriodo.Checked==true)
			{
				dateInicio.Enabled = true;
				dateCorte.Enabled = true;
			}
			else
			{
				dateInicio.Enabled = false;
				dateCorte.Enabled = false;
				EventoFecha();
			}
		}
		
		void CkActivarCopiaCheckedChanged(object sender, EventArgs e)
		{
			if(ckActivarCopia.Checked==true)
			{
				dateInicioCopia.Enabled = true;
				dateCorteCopia.Enabled = true;
			}
			else
			{
				dateInicioCopia.Enabled = false;
				dateCorteCopia.Enabled = false;
			}
		}
		#endregion
		
		//REPORTES
		
		#region REPORTE ESTANDAR
		public void GenerarDocumentoReporte(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoGeneralFacturacion(FechaInicio, FechaCorte, dataTotales, txtCamionetasS, txtCamionetasC, 
			                                     txtCamionesS, txtCamionesC, document, lblEmpresa, Datos, FechaPDF, 
			                                     DiaFacturacion, dataViajesNormales, dataViajesEstandarExtras, writer, principal, dataCONVER);
		}
		#endregion
		
		#region REPORTE COREY - FORSAC
		public void GenerarDocumentoReporteCOREY(Document document,  PdfWriter writer)
		{
			if(ckActivarCopia.Checked==false)
			{
				LlenadoArregloFecha(FechaInicio, FechaCorte);
				FormatoPdf.FormatoCOREYFacturacion(FechaInicio, FechaCorte, dataCorey, txtCamionetasS, txtCamionetasC, 
				                                     txtCamionesS, txtCamionesC, txtOtroVehiculo, document, lblEmpresa, Datos, FechaPDF, 
				                                     DiaFacturacion, dataViajesNormales, dataViajesExtrasCorey, writer, principal);
			}
			else
			{
				LlenadoArregloFecha(dateInicioCopia.Value.ToString("dd-MM-yyyy"), dateCorteCopia.Value.ToString("dd-MM-yyyy"));
				FormatoPdf.FormatoCOREYFacturacion(dateInicioCopia.Value.ToString("dd-MM-yyyy"), dateCorteCopia.Value.ToString("dd-MM-yyyy"), dataCorey, txtCamionetasS, txtCamionetasC,
				                                     txtCamionesS, txtCamionesC, txtOtroVehiculo, document, lblEmpresa, Datos, FechaPDF, 
				                                     DiaFacturacion, dataViajesNormales, dataViajesExtrasCorey, writer, principal);
			}
		}
		
		public void GenerarDocumentoReporteFORSAC(Document document,  PdfWriter writer)
		{
			if(ckActivarCopia.Checked==false)
			{
				LlenadoArregloFecha(FechaInicio, FechaCorte);
				FormatoPdf.FormatoFORSACFacturacion(FechaInicio, FechaCorte, dataCorey, txtCamionetasS, txtCamionetasC, 
				                                     txtCamionesS, txtCamionesC, txtOtroVehiculo, txtCamionetasSEXTRA, txtCamionetasCEXTRA, 
				                                     txtCamionesSEXTRA, txtCamionesCEXTRA, txtOtroVehiculoEXTRA, document, lblEmpresa, Datos, FechaPDF, 
				                                     DiaFacturacion, dataViajesNormales, dataViajesExtrasCorey, writer, principal);
			}
			else
			{
				LlenadoArregloFecha(dateInicioCopia.Value.ToString("dd-MM-yyyy"), dateCorteCopia.Value.ToString("dd-MM-yyyy"));
				FormatoPdf.FormatoFORSACFacturacion(dateInicioCopia.Value.ToString("dd-MM-yyyy"), dateCorteCopia.Value.ToString("dd-MM-yyyy"), dataCorey, txtCamionetasS, txtCamionetasC,
				                                     txtCamionesS, txtCamionesC, txtOtroVehiculo, txtCamionetasSEXTRA, txtCamionetasCEXTRA, 
				                                     txtCamionesSEXTRA, txtCamionesCEXTRA, txtOtroVehiculoEXTRA, document, lblEmpresa, Datos, FechaPDF, 
				                                     DiaFacturacion, dataViajesNormales, dataViajesExtrasCorey, writer, principal);
			}
		}
		#endregion
		
		#region REPORTE RIMSA
		public void GenerarDocumentoReporteRIMSA(Document document,  PdfWriter writer)
		{		
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoRIMSA1Facturacion(FechaInicio, FechaCorte, dataLuisNormales, dataChuyNormales, dataLuisAlmacen, dataChuyAlmacen, txtSencilloLuis,
			   		    						txtAlmacen, txtEntrada, txtSalida, txtSencilloChuy, txtAlamcenChuy, txtEntradaChuy,
			   		    						txtSalidaChuy, document, lblEmpresa, Datos, FechaPDF, 
			                                    DiaFacturacion, writer, principal);
		}
		
		public void GenerarDocumentoReporteRIMSA2(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoRIMSA2Facturacion(FechaInicio, FechaCorte, dataRimsa, dataViajesExtrasRimsa, txtNormales,
												txtCompletasEntradas,txtCompletasSalidas,
												txtAlmacenRimsa2, document, lblEmpresa, Datos, FechaPDF, 
			                                    DiaFacturacion, writer, principal);			
		}
		
		public void GenerarDocumentoReporteRIMSA3(Document document,  PdfWriter writer, string Tipo)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoRIMSA3Facturacion(FechaInicio, FechaCorte, dgTotalesRimsa, dataRimsa, dataViajesExtrasRimsa, dataDatoLuisAlmacen, txtNormales,
												txtCompletasEntradas,txtCompletasSalidas,
												txtAlmacenRimsa2, document, lblEmpresa, Datos, FechaPDF, 
			                                    DiaFacturacion, writer, principal, Tipo, Calmacen);			
		}
		#endregion
		
		#region REPORTE FARMACIAS
		public void GenerarDocumentoReporteFGDL(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoFarmacias1Facturacion(FechaInicio, FechaCorte, dataFarmaciasNormales, txtCamionetasS, txtCamionetasC, 
			                                     txtCamionesS, txtCamionesC, document, lblEmpresa, Datos, FechaPDF, 
			                                     DiaFacturacion, writer, principal);			
		}
		
		public void GenerarDocumentoReporteFGDLExtra(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoFarmacias2Facturacion(FechaInicio, FechaCorte, dataFarmaciasExtras, txtCamionetasS, txtCamionetasC, 
			                                     txtCamionesS, txtCamionesC, document, lblEmpresa, Datos, FechaPDF, 
			                                     DiaFacturacion, writer, principal, txtOtroVehiculo);			
		}
		
		public void GenerarDocumentoReporteFGDLExtraDesglose(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoFarmacias3Facturacion(FechaInicio, FechaCorte, dataDesgloseFar, document, lblEmpresa, Datos, FechaPDF, 
			                                   		  DiaFacturacion, writer, principal);	
		}
		#endregion
		
		#region REPORTE JABIL
		public void GenerarDocumentoReporteJABIL(Document document,  PdfWriter writer, int opcion)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			if(opcion==0)
			{
				FormatoPdf.FormatoJABILFacturacion(FechaInicio, FechaCorte, dataJabilP, dataJabilP2, document, lblEmpresa, Datos, FechaPDF, 
			                                   		  DiaFacturacion, writer, principal, "Servicios de Producción", dttotalesproduccamion, dttotalesproduccamioneta);	
			}
			else
			{
				FormatoPdf.FormatoJABILFacturacion(FechaInicio, FechaCorte, dataJabilA, dataJabilA2, document, lblEmpresa, Datos, FechaPDF, 
			                                   		  DiaFacturacion, writer, principal, "Servicios de Administrativos", dttotalesAdminCamion, dttotalesAdmincamioneta);		
			}
		}		
		
		public void GenerarDocumentoReporteJABILTotales(Document document,  PdfWriter writer)
		{			
			FormatoPdf.FormatoJABILFacturacionTotales(FechaInicio, FechaCorte, dataJabilP, dataJabilP2, document, lblEmpresa, Datos, FechaPDF, 
			                                   		  DiaFacturacion, writer, principal, "Servicios de Producción", dttotalesproduccamion, dttotalesproduccamioneta);	
		}
		#endregion
		
		#region REPORTE HENNIGES - VITRO
		public void GenerarDocumentoReporteHENNIGES(Document document,  PdfWriter writer, String Titulo)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoHENNIEGESFacturacion(FechaInicio, FechaCorte, dataHenniegesNormales, document, Titulo, 
			                                       writer, principal, txtViajesHenniges.Text, txtTotalHennieges.Text);
		}
		
		public void GenerarDocumentoReporteHENNIGESExtra(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoHENNIEGESFacturacionExtra(FechaInicio, FechaCorte, dataHenniegesExtras, document, lblEmpresa, 
			                                            writer, principal, txtViajesExtHenniges.Text, txtTotalExtHennieges.Text, 
			                                            dataHennigesEspecial, txtViajesExtHenniges2.Text, txtTotalExtHennieges2.Text, 
			                                            dataHenniegesExtras2, txtnumviajesEspeciales.Text, txtcostoviajesEspeciales.Text, 
			                                            dataViajesNormales);
		}
		
		public void GenerarDocumentoReporteVITRO2(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoVITROFacturacion(FechaInicio, FechaCorte, dataLuisVitro, datavitrovitro, txtLuisSencillo,
			   		    						txtLuisCompleto, txtLuisCompleto, txtVitroSencillo, txtVitroCompleto,
			   		    						txtVitroCompleto, document, lblEmpresa, Datos, FechaPDF, 
			                                    DiaFacturacion, writer, principal);
		}
		#endregion
		
		#region REPORTE PLEXUS
		public void GenerarDocumentoReportePLEXUS(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoPLEXUSFacturacion(FechaInicio, FechaCorte, txtCamionLocal, txtCamionForaneo, 
			                                     txtCamionetaLocal, txtCamionetaForaneo, document, lblEmpresa, 
			                                     DiaFacturacion, writer, principal, dataCamionLocalPlex, dataCamionForaneoPlex, dataCamionetaLocalPlex, dataCamionetaForaneoPlex, dtDetalleplex);
		}
		
		public void GenerarDocumentoReportePLEXUSOF(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoPLEXUSFacturacion(FechaInicio, FechaCorte, txtCamionLocalOF, txtCamionForaneoOF, 
			                                     txtCamionetaLocalOF, txtCamionetaForaneaOF, document, lblEmpresa, 
			                                     DiaFacturacion, writer, principal, dataCamionLocalPlexOF, dataCamionForaneaPlexOF, dataCamionetaLocalPlexOF, dataCamionetaForaneaPlexOF, dtDetalleplexOF);
		}
		#endregion
				
		#region REPORTE CARESTREAM
		public void GenerarDocumentoReporteCarestream(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoGeneralFacturacionCarestream(FechaInicio, FechaCorte, dataTotales, txtCamionetasS, txtCamionetasC, 
			                                     txtCamionesS, txtCamionesC, document, lblEmpresa, Datos, FechaPDF, 
			                                     DiaFacturacion, dataViajesNormales, dataViajesEstandarExtras, writer, principal, dataCONVER);
		}
		#endregion
		
		#region REPORTE LIVERPOOL
		public void GenerarDocumentoReporteLiverpool(Document document,  PdfWriter writer)
		{
			LlenadoArregloFecha(FechaInicio, FechaCorte);
			FormatoPdf.FormatoGeneralFacturacionLiverpool(FechaInicio, FechaCorte, dataTotales, txtCamionetasS, txtCamionetasC, 
			                                     txtCamionesS, txtCamionesC, document, lblEmpresa, Datos, FechaPDF, 
			                                     DiaFacturacion, dataViajesNormales, dataViajesEstandarExtras, writer, principal, dataCONVER, txtCamionesSFo);
		}
		#endregion
		//RIMSA
		
		#region ADAPTADORES RIMSA
		void AdaptadoresRIMSA()
		{
			int contador = 0;
			dataDatoChuy.Rows.Clear();
			dataDatoChuy.ClearSelection();
			conn.getAbrirConexion("select O.fecha, R.Nombre, R.Sentido, R.Turno " +
                                 "from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C " +
                                 "where O.Estatus='1' and C.ID=R.IdSubEmpresa and O.id_ruta=R.ID " +
                                 "and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID " +
                                 "and OP.tipo_empleado='Externo' AND " +
                                 "O.fecha between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' " +
                                 "AND OP.Alias='EDGAR A.' and R.Nombre!='Almacen' and C.Empresa='RIMSA' and R.tipo!='APO' " +
                                 "and R.tipo != 'EXT' and R.tipo != 'DOM' and R.FACTURA!='1'" +
                                 "order by fecha");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataDatoChuy.Rows.Add();
				dataDatoChuy.Rows[contador].Cells[1].Value = conn.leer["fecha"].ToString().Substring(0,10);
				dataDatoChuy.Rows[contador].Cells[2].Value = conn.leer["Nombre"].ToString();
				dataDatoChuy.Rows[contador].Cells[3].Value = conn.leer["Sentido"].ToString();
				dataDatoChuy.Rows[contador].Cells[4].Value = conn.leer["Turno"].ToString();
				dataDatoChuy.Rows[contador].Cells[0].Style.BackColor=Color.DodgerBlue;
				dataDatoChuy.Rows[contador].Cells[0].Value="Sencillo";
				
				++contador;
			}
			conn.conexion.Close();
			
			contador = 0;
			dataDatoLuis.Rows.Clear();
			dataDatoLuis.ClearSelection();
			conn.getAbrirConexion("select O.fecha, R.Nombre, R.Sentido, R.Turno " +
	                             "from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C " +
	                             "where O.Estatus='1' and C.ID=R.IdSubEmpresa and O.id_ruta=R.ID and " +
	                             "O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID AND " +
	                             "O.fecha between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' " +
	                             "AND OP.Alias!='EDGAR A.' and R.Nombre!='Almacen' and " +
	                             "C.Empresa='RIMSA' and R.tipo != 'EXT' and R.tipo != 'DOM' and R.tipo != 'APO' and R.FACTURA!='1'" +
	                             "order by fecha");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataDatoLuis.Rows.Add();
				dataDatoLuis.Rows[contador].Cells[1].Value = conn.leer["fecha"].ToString().Substring(0,10);
				dataDatoLuis.Rows[contador].Cells[2].Value = conn.leer["Nombre"].ToString();
				dataDatoLuis.Rows[contador].Cells[3].Value = conn.leer["Sentido"].ToString();
				dataDatoLuis.Rows[contador].Cells[4].Value = conn.leer["Turno"].ToString();
				dataDatoLuis.Rows[contador].Cells[0].Style.BackColor=Color.DodgerBlue;
				dataDatoLuis.Rows[contador].Cells[0].Value="Sencillo";
				++contador;
			}
			conn.conexion.Close();
			
			contador = 0;
			dataDatoChuyAlmacen.Rows.Clear();
			dataDatoChuyAlmacen.ClearSelection();
			conn.getAbrirConexion("select O.fecha, R.Nombre, R.Sentido, R.Turno " +
                                "from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C " +
                                "where O.Estatus='1' and C.ID=R.IdSubEmpresa and O.id_ruta=R.ID and " +
                                "O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and OP.tipo_empleado='Externo' " +
                                "AND O.fecha between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' AND " +
                                "OP.Alias='EDGAR A.' and R.Nombre='Almacen' and C.Empresa='RIMSA' and R.FACTURA!='1'" +
                                "order by fecha");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataDatoChuyAlmacen.Rows.Add();
				dataDatoChuyAlmacen.Rows[contador].Cells[0].Value = conn.leer["fecha"].ToString().Substring(0,10);
				dataDatoChuyAlmacen.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
				dataDatoChuyAlmacen.Rows[contador].Cells[2].Value = conn.leer["Sentido"].ToString();
				dataDatoChuyAlmacen.Rows[contador].Cells[3].Value = conn.leer["Turno"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			contador = 0;
			dataDatoLuisAlmacen.Rows.Clear();
			dataDatoLuisAlmacen.ClearSelection();
			conn.getAbrirConexion("select O.fecha, R.Nombre, R.Sentido, R.Turno " +
                                "from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C " +
                                "where O.Estatus='1' and C.ID=R.IdSubEmpresa and O.id_ruta=R.ID and O.id_operacion=OO.id_operacion and " +
                                "OO.id_operador=OP.ID AND O.fecha between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' " +
                                "AND OP.Alias!='EDGAR A.' and R.Nombre='Almacen' and C.Empresa='RIMSA' and R.FACTURA!='1'" +
                                "order by fecha");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataDatoLuisAlmacen.Rows.Add();
				dataDatoLuisAlmacen.Rows[contador].Cells[0].Value = conn.leer["fecha"].ToString().Substring(0,10);
				dataDatoLuisAlmacen.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
				dataDatoLuisAlmacen.Rows[contador].Cells[2].Value = conn.leer["Sentido"].ToString();
				dataDatoLuisAlmacen.Rows[contador].Cells[3].Value = conn.leer["Turno"].ToString();
				++contador;
			}
			conn.conexion.Close();
		}
		
		void AdaptadoresRIMSANuevo()
		{
			int contador = 0;
			string consulta = @"select c.tipo_cobro, O.fecha, R.Nombre, R.Sentido, R.Turno, C.SubNombre, oo.vehiculo, r.TIPO, r.VELADA from OPERACION O,
								OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C where O.Estatus='1' and C.ID = R.IdSubEmpresa and 
								O.id_ruta=R.ID and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.fecha 
								between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' " +
                             	@"AND R.Nombre!='Almacen' and C.Empresa='RIMSA' and R.tipo!='APO' and R.tipo != 'EXT' and R.tipo != 'DOM' and R.FACTURA!='1' order by fecha";			
			
			dataRimsa.Rows.Clear();
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dataRimsa.Rows.Add();
				dataRimsa.Rows[contador].Cells[0].Value = "Sencillo";
				dataRimsa.Rows[contador].Cells[0].Style.BackColor = Color.DodgerBlue;
				dataRimsa.Rows[contador].Cells[1].Value = conn.leer["fecha"].ToString().Substring(0,10);
				dataRimsa.Rows[contador].Cells[2].Value = conn.leer["SubNombre"].ToString();
				dataRimsa.Rows[contador].Cells[3].Value = conn.leer["Nombre"].ToString();
				dataRimsa.Rows[contador].Cells[4].Value = conn.leer["Sentido"].ToString();
				dataRimsa.Rows[contador].Cells[5].Value = conn.leer["Turno"].ToString();				
				dataRimsa.Rows[contador].Cells[6].Value = conn.leer["tipo_cobro"].ToString();				
				dataRimsa.Rows[contador].Cells[7].Value = conn.leer["TIPO"].ToString();
				dataRimsa.Rows[contador].Cells[8].Value = conn.leer["VELADA"].ToString();
				dataRimsa.Rows[contador].Cells[9].Value = "NO";					
				dataRimsa.Rows[contador].Cells[10].Value = "0.0";
				
				//if(dataRimsa.Rows[contador].Cells[6].Value.ToString() == "Camioneta" && dataRimsa.Rows[contador].Cells[8].Value.ToString() == "1"){
				if(dataRimsa.Rows[contador].Cells[6].Value.ToString() == "CAMIONETA"){
					if(dataRimsa.Rows[contador].Cells[3].Value.ToString().Equals("LA VENTA")){
						dataRimsa.Rows[contador].Cells[11].Value = ClaVenta;
						dataRimsa.Rows[contador].Cells[12].Value = ClaVenta;
					}else if(dataRimsa.Rows[contador].Cells[2].Value.ToString() == "RIMSA VANILLA CAMIONES" || dataRimsa.Rows[contador].Cells[2].Value.ToString() == "RIMSA VANILLA CAMIONETAS"){
						dataRimsa.Rows[contador].Cells[9].Value = "SI";					
						dataRimsa.Rows[contador].Cells[10].Value = CVsencillo;
						dataRimsa.Rows[contador].Cells[11].Value = "0.0";
						dataRimsa.Rows[contador].Cells[12].Value = CVsencillo;
					}else{
						dataRimsa.Rows[contador].Cells[9].Value = "NO";					
						dataRimsa.Rows[contador].Cells[10].Value = "0.0";
						dataRimsa.Rows[contador].Cells[11].Value = CVsencillo;
						dataRimsa.Rows[contador].Cells[12].Value = CVsencillo;						
					}
				}else{
					if(dataRimsa.Rows[contador].Cells[2].Value.ToString() == "RIMSA VANILLA CAMIONES" || dataRimsa.Rows[contador].Cells[2].Value.ToString() == "RIMSA VANILLA CAMIONETAS" ){
						dataRimsa.Rows[contador].Cells[9].Value = "SI";					
						dataRimsa.Rows[contador].Cells[10].Value = CVsencillo;
						dataRimsa.Rows[contador].Cells[11].Value = "0.0";
						dataRimsa.Rows[contador].Cells[12].Value = CVsencillo;
					}else{
						dataRimsa.Rows[contador].Cells[11].Value = Csencillos;
						dataRimsa.Rows[contador].Cells[12].Value = Csencillos;	
					}										
				}	
				
				++contador;
			}
			conn.conexion.Close();		
			
			
			contador = 0;
			consulta = "select c.tipo_cobro, O.fecha, R.Nombre, R.Sentido, R.Turno " +
                                "from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C " +
                                "where O.Estatus='1' and C.ID=R.IdSubEmpresa and O.id_ruta=R.ID and O.id_operacion=OO.id_operacion and " +
                                "OO.id_operador=OP.ID AND O.fecha between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' " +
                                "AND R.Nombre='Almacen' and C.Empresa='RIMSA' and R.FACTURA!='1'" +
                                "order by fecha";
			
			dataDatoLuisAlmacen.Rows.Clear();			
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dataDatoLuisAlmacen.Rows.Add();
				dataDatoLuisAlmacen.Rows[contador].Cells[0].Value = conn.leer["fecha"].ToString().Substring(0,10);
				dataDatoLuisAlmacen.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
				dataDatoLuisAlmacen.Rows[contador].Cells[2].Value = conn.leer["Sentido"].ToString();
				dataDatoLuisAlmacen.Rows[contador].Cells[3].Value = conn.leer["Turno"].ToString();
				dataDatoLuisAlmacen.Rows[contador].Cells[4].Value = Calmacen;
				dataDatoLuisAlmacen.Rows[contador].Cells[5].Value = conn.leer["tipo_cobro"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			CalculoRimsaNormal();
			CalculoRimsaCS();
		}
		
		void CalculoRimsaNormal(){	
			dataRimsa.Sort(dataRimsa.Columns[2], ListSortDirection.Descending);
			string fecha = "";
			string subNombre = "";
			string ruta = "";
			string sentido = "";
			string turno = "";
			string vehiculo = "";
			string tipo = "";
			string velada = "";
			
			string fecha2 = "";
			string subNombre2 = "";
			string ruta2 = "";
			string sentido2 = "";
			string turno2 = "";
			string vehiculo2 = "";
			string tipo2 = "";
			string velada2 = "";
			
			for(int y = 0; y<(dataRimsa.RowCount-1); y++){
				fecha = dataRimsa.Rows[y].Cells[1].Value.ToString();
				subNombre = dataRimsa.Rows[y].Cells[2].Value.ToString();
				ruta = dataRimsa.Rows[y].Cells[3].Value.ToString();
				sentido = dataRimsa.Rows[y].Cells[4].Value.ToString();
				turno = dataRimsa.Rows[y].Cells[5].Value.ToString();
				vehiculo = dataRimsa.Rows[y].Cells[6].Value.ToString();
				tipo = dataRimsa.Rows[y].Cells[7].Value.ToString();
				velada = dataRimsa.Rows[y].Cells[8].Value.ToString();
				
				for(int x = 1; x<(dataRimsa.RowCount); x++){
					fecha2 = dataRimsa.Rows[x].Cells[1].Value.ToString();
					subNombre2 = dataRimsa.Rows[x].Cells[2].Value.ToString();
					ruta2 = dataRimsa.Rows[x].Cells[3].Value.ToString();
					sentido2 = dataRimsa.Rows[x].Cells[4].Value.ToString();
					turno2 = dataRimsa.Rows[x].Cells[5].Value.ToString();
					vehiculo2 = dataRimsa.Rows[x].Cells[6].Value.ToString();
					tipo2 = dataRimsa.Rows[x].Cells[7].Value.ToString();
					velada2 = dataRimsa.Rows[x].Cells[8].Value.ToString();
					
					if( dataRimsa.Rows[y].Cells[0].Value.ToString() != "Completo" && dataRimsa.Rows[x].Cells[0].Value.ToString()!="Completo" && ruta != "LA VENTA" && ruta2 != "LA VENTA" ){
						if( (subNombre == "RIMSA LAR CAMIONETAS" && subNombre2 == "RIMSA LAR CAMIONETAS") || (subNombre == "RIMSA LAR CAMIONES" && subNombre2 == "RIMSA LAR CAMIONES") ){
							if(fecha==fecha2 && sentido!=sentido2 && turno==turno2){ // && ruta == ruta2
								dataRimsa.Rows[y].Cells[4].Value = "E/S";
								dataRimsa.Rows[x].Cells[4].Value = "E/S";
								dataRimsa.Rows[x].Cells[9].Value = "NO";			
								dataRimsa.Rows[y].Cells[9].Value = "NO";			
								dataRimsa.Rows[y].Cells[0].Value="Completo";
								dataRimsa.Rows[x].Cells[0].Value="Completo";
								dataRimsa.Rows[y].Cells[0].Style.BackColor = Color.SpringGreen;			
								dataRimsa.Rows[x].Cells[0].Style.BackColor = Color.SpringGreen;	
								dataRimsa.Rows[y].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
								dataRimsa.Rows[y].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
								dataRimsa.Rows[x].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
								dataRimsa.Rows[x].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
										
								if(vehiculo == "CAMION"){
									dataRimsa.Rows[y].Cells[11].Value = Ccompletos;
									dataRimsa.Rows[y].Cells[12].Value = Ccompletos;
									dataRimsa.Rows[x].Cells[11].Value = Ccompletos;
									dataRimsa.Rows[x].Cells[12].Value = Ccompletos;										
								}else{										
									dataRimsa.Rows[y].Cells[11].Value = CVCompleto;
									dataRimsa.Rows[y].Cells[12].Value = CVCompleto;
									dataRimsa.Rows[x].Cells[11].Value = CVCompleto;
									dataRimsa.Rows[x].Cells[12].Value = CVCompleto;
								}	
										
								if(x!=y){
									dataRimsa.Rows.RemoveAt(x);
									if(y>0)
										--x;
								}			
							}
						}									
					}
				}
			}
			
			dataRimsa.ClearSelection();
		}
		
		
		void CalculoRimsaCS(){			
			dataRimsa.Sort(dataRimsa.Columns[2], ListSortDirection.Descending);
			string fecha = "";
			string subNombre = "";
			string ruta = "";
			string sentido = "";
			string turno = "";
			string vehiculo = "";
			string tipo = "";
			string velada = "";
			
			string fecha2 = "";
			string subNombre2 = "";
			string ruta2 = "";
			string sentido2 = "";
			string turno2 = "";
			string vehiculo2 = "";
			string tipo2 = "";
			string velada2 = "";
			
			for(int y = 0; y<(dataRimsa.RowCount-1); y++){
				fecha = dataRimsa.Rows[y].Cells[1].Value.ToString();
				subNombre = dataRimsa.Rows[y].Cells[2].Value.ToString();
				ruta = dataRimsa.Rows[y].Cells[3].Value.ToString();
				sentido = dataRimsa.Rows[y].Cells[4].Value.ToString();
				turno = dataRimsa.Rows[y].Cells[5].Value.ToString();
				vehiculo = dataRimsa.Rows[y].Cells[6].Value.ToString();
				tipo = dataRimsa.Rows[y].Cells[7].Value.ToString();
				velada = dataRimsa.Rows[y].Cells[8].Value.ToString();
				
				if(sentido == "Entrada" && turno == "Mañana" && ruta == "CUISILLOS")
					ruta = "REFUGIO";
				for(int x = 1; x<(dataRimsa.RowCount); x++){	
					fecha2 = dataRimsa.Rows[x].Cells[1].Value.ToString();
					subNombre2 = dataRimsa.Rows[x].Cells[2].Value.ToString();
					ruta2 = dataRimsa.Rows[x].Cells[3].Value.ToString();
					sentido2 = dataRimsa.Rows[x].Cells[4].Value.ToString();
					turno2 = dataRimsa.Rows[x].Cells[5].Value.ToString();
					vehiculo2 = dataRimsa.Rows[x].Cells[6].Value.ToString();
					tipo2 = dataRimsa.Rows[x].Cells[7].Value.ToString();
					velada2 = dataRimsa.Rows[x].Cells[8].Value.ToString();
					
					if(sentido2 == "Entrada" && turno2 == "Mañana" && ruta2 == "CUISILLOS")
						ruta2 = "REFUGIO";					
						
					if( dataRimsa.Rows[y].Cells[0].Value.ToString() != "Completo" && dataRimsa.Rows[x].Cells[0].Value.ToString()!="Completo" && ruta != "LA VENTA" && ruta2 != "LA VENTA" ){
						if( (turno == "Mañana" && turno2 == "Mañana") || (turno == "Vespertino" && turno2 == "Vespertino") ){
							if(subNombre == "RIMSA VANILLA CAMIONETAS" || subNombre2 == "RIMSA VANILLA CAMIONETAS"){
								if(subNombre != "RIMSA LAR CAMIONETAS" && subNombre2 != "RIMSA LAR CAMIONETAS"){
									if(fecha==fecha2 && sentido!=sentido2 && turno==turno2){ // && ruta == ruta2
										dataRimsa.Rows[y].Cells[4].Value = "E/S";
										dataRimsa.Rows[x].Cells[4].Value = "E/S";
										dataRimsa.Rows[x].Cells[9].Value = "SI";			
										dataRimsa.Rows[y].Cells[9].Value = "SI";			
										dataRimsa.Rows[y].Cells[0].Value="Completo";
										dataRimsa.Rows[x].Cells[0].Value="Completo";
										dataRimsa.Rows[y].Cells[0].Style.BackColor = Color.SpringGreen;			
										dataRimsa.Rows[x].Cells[0].Style.BackColor = Color.SpringGreen;	
										dataRimsa.Rows[y].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
										dataRimsa.Rows[y].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
										dataRimsa.Rows[x].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
										dataRimsa.Rows[x].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
										
										if(subNombre == subNombre2){										
											dataRimsa.Rows[y].Cells[10].Value = CVCompleto;
											dataRimsa.Rows[y].Cells[11].Value = 0.0;
											dataRimsa.Rows[y].Cells[12].Value = CVCompleto;				
											dataRimsa.Rows[x].Cells[10].Value = CVCompleto;
											dataRimsa.Rows[x].Cells[11].Value = 0.0;
											dataRimsa.Rows[x].Cells[12].Value = CVCompleto;	
										}else{
											if(subNombre == "RIMSA LAR CAMIONETAS" || subNombre2 == "RIMSA LAR CAMIONETAS"){
												dataRimsa.Rows[y].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[y].Cells[11].Value = CVsencillo;
												dataRimsa.Rows[y].Cells[12].Value = CDiferenciavanilla + CVsencillo;
												dataRimsa.Rows[x].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[x].Cells[11].Value = CVsencillo;
												dataRimsa.Rows[x].Cells[12].Value = CDiferenciavanilla + CVsencillo;
											}else{
												dataRimsa.Rows[y].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[y].Cells[11].Value = Csencillos;
												dataRimsa.Rows[y].Cells[12].Value = CDiferenciavanilla + Csencillos;
												dataRimsa.Rows[x].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[x].Cells[11].Value = Csencillos;
												dataRimsa.Rows[x].Cells[12].Value = CDiferenciavanilla + Csencillos;
											}
										}
										
										if(x!=y){
											dataRimsa.Rows.RemoveAt(x);
											if(y>0)
												--x;
										}			
									}
								}									
							}else{
								if(fecha==fecha2 && sentido!=sentido2 && turno==turno2 && vehiculo == vehiculo2 && subNombre == subNombre2){
									dataRimsa.Rows[y].Cells[0].Value="Completo";
									dataRimsa.Rows[x].Cells[0].Value="Completo";
									dataRimsa.Rows[y].Cells[0].Style.BackColor = Color.SpringGreen;			
									dataRimsa.Rows[x].Cells[0].Style.BackColor = Color.SpringGreen;	
									
									dataRimsa.Rows[y].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
									dataRimsa.Rows[y].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
									dataRimsa.Rows[x].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
									dataRimsa.Rows[x].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
										
									dataRimsa.Rows[y].Cells[4].Value = "E/S";
									dataRimsa.Rows[x].Cells[4].Value = "E/S";
									
									dataRimsa.Rows[y].Cells[9].Value = "NO";
									dataRimsa.Rows[y].Cells[10].Value = 0.0;
									
									if(vehiculo == "CAMION"){
										dataRimsa.Rows[y].Cells[11].Value = Ccompletos;
										dataRimsa.Rows[y].Cells[12].Value = Ccompletos;
										dataRimsa.Rows[x].Cells[11].Value = Ccompletos;
										dataRimsa.Rows[x].Cells[12].Value = Ccompletos;										
									}else{										
										dataRimsa.Rows[y].Cells[11].Value = CVCompleto;
										dataRimsa.Rows[y].Cells[12].Value = CVCompleto;
										dataRimsa.Rows[x].Cells[11].Value = CVCompleto;
										dataRimsa.Rows[x].Cells[12].Value = CVCompleto;
									}

																		
									if(x!=y){
										dataRimsa.Rows.RemoveAt(x);
										if(y>0)
											--x;
									}			
								}
							}
						}else{						
							if(subNombre != "RIMSA VANILLA CAMIONETAS" && subNombre2 != "RIMSA VANILLA CAMIONETAS"){
								if(fecha==fecha2 && sentido!=sentido2 && turno==turno2 && vehiculo == vehiculo2 && subNombre == subNombre2){
									dataRimsa.Rows[y].Cells[0].Value="Completo";
									dataRimsa.Rows[x].Cells[0].Value="Completo";
									dataRimsa.Rows[y].Cells[0].Style.BackColor = Color.SpringGreen;			
									dataRimsa.Rows[x].Cells[0].Style.BackColor = Color.SpringGreen;	
									
									dataRimsa.Rows[y].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
									dataRimsa.Rows[y].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
									dataRimsa.Rows[x].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
									dataRimsa.Rows[x].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
										
									dataRimsa.Rows[y].Cells[4].Value = "E/S";
									dataRimsa.Rows[x].Cells[4].Value = "E/S";
									
									dataRimsa.Rows[y].Cells[9].Value = "NO";
									dataRimsa.Rows[y].Cells[10].Value = 0.0;
									
									if(vehiculo == "CAMION"){
										dataRimsa.Rows[y].Cells[11].Value = Ccompletos;
										dataRimsa.Rows[y].Cells[12].Value = Ccompletos;										
									}else{										
										dataRimsa.Rows[y].Cells[11].Value = CVCompleto;
										dataRimsa.Rows[y].Cells[12].Value = CVCompleto;
									}
									
									if(x!=y){
										dataRimsa.Rows.RemoveAt(x);
										if(y>0)
											--x;
									}			
								}
							}else{
								if(subNombre == subNombre2){
									if(fecha==fecha2 && sentido!=sentido2 && turno==turno2 ){ // && ruta == ruta2
										dataRimsa.Rows[x].Cells[9].Value = "SI";			
										dataRimsa.Rows[y].Cells[9].Value = "SI";		
										dataRimsa.Rows[y].Cells[0].Value="Completo";
										dataRimsa.Rows[x].Cells[0].Value="Completo";
										dataRimsa.Rows[y].Cells[4].Value = "E/S";
										dataRimsa.Rows[x].Cells[4].Value = "E/S";
										dataRimsa.Rows[y].Cells[0].Style.BackColor = Color.SpringGreen;			
										dataRimsa.Rows[x].Cells[0].Style.BackColor = Color.SpringGreen;	
										dataRimsa.Rows[y].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
										dataRimsa.Rows[y].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;
										dataRimsa.Rows[x].Cells[2].Value = dataRimsa.Rows[y].Cells[2].Value +" - "+dataRimsa.Rows[x].Cells[2].Value;										
										dataRimsa.Rows[x].Cells[3].Value = dataRimsa.Rows[y].Cells[3].Value +" - "+dataRimsa.Rows[x].Cells[3].Value;	
										
										if(subNombre == subNombre2){										
											dataRimsa.Rows[y].Cells[10].Value = CVCompleto;
											dataRimsa.Rows[y].Cells[11].Value = 0.0;
											dataRimsa.Rows[y].Cells[12].Value = CVCompleto;	
										}else{
											if(vehiculo == "CAMION"){
												dataRimsa.Rows[y].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[y].Cells[11].Value = Csencillos;
												dataRimsa.Rows[y].Cells[12].Value = CDiferenciavanilla + Csencillos;	
												dataRimsa.Rows[x].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[x].Cells[11].Value = Csencillos;
												dataRimsa.Rows[x].Cells[12].Value = CDiferenciavanilla + Csencillos;										
											}else{
												dataRimsa.Rows[y].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[y].Cells[11].Value = CVsencillo;
												dataRimsa.Rows[y].Cells[12].Value = CDiferenciavanilla + CVsencillo;
												dataRimsa.Rows[x].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[x].Cells[11].Value = CVsencillo;
												dataRimsa.Rows[x].Cells[12].Value = CDiferenciavanilla + CVsencillo;
											}
											if(vehiculo2 == "CAMION"){
												dataRimsa.Rows[y].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[y].Cells[11].Value = Csencillos;
												dataRimsa.Rows[y].Cells[12].Value = CDiferenciavanilla + Csencillos;
												dataRimsa.Rows[x].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[x].Cells[11].Value = Csencillos;
												dataRimsa.Rows[x].Cells[12].Value = CDiferenciavanilla + Csencillos;										
											}else{
												dataRimsa.Rows[y].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[y].Cells[11].Value = CVsencillo;
												dataRimsa.Rows[y].Cells[12].Value = CDiferenciavanilla + CVsencillo;
												dataRimsa.Rows[x].Cells[10].Value = CDiferenciavanilla;
												dataRimsa.Rows[x].Cells[11].Value = CVsencillo;
												dataRimsa.Rows[x].Cells[12].Value = CDiferenciavanilla + CVsencillo;
											}
											
												
										}
										
										if(x!=y){
											dataRimsa.Rows.RemoveAt(x);
											if(y>0)
												--x;
										}			
									}
								}
							}
								
						}						
					}				
				}
			}
			
			dataRimsa.ClearSelection();
		}
		
		void AdaptadorExtrasRimsa(DataGridView dtViajesEstandarExtras)
		{
			////////////////////////////////////////////////// EXTRAS //////////////////////////////////////////////////
			int contador = 0;
			String sentencia = "select R.Nombre as Ruta, O.turno As Turno, O.fecha as Fecha, C.SubNombre," +
			                        "C.tipo_cobro as Vehiculo, R.sentido as Sentido "+                                                   
                               		"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
                               		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                    "and OO.id_operador=OP.ID and C.Empresa='RIMSA' and (R.tipo='APO' or R.tipo='EXT' or R.tipo='DOM') and " +
                                    "O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.FACTURA!='1' AND C.ID NOT IN (13, 1490) " +
                                    "order by O.fecha";
				
			dtViajesEstandarExtras.Rows.Clear();
			dtViajesEstandarExtras.ClearSelection();
			
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtViajesEstandarExtras.Rows.Add();
				dtViajesEstandarExtras.Rows[contador].Cells[0].Value = "Sencillo";
				dtViajesEstandarExtras.Rows[contador].Cells[0].Style.BackColor = Color.DodgerBlue;
				dtViajesEstandarExtras.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dtViajesEstandarExtras.Rows[contador].Cells[2].Value = conn.leer["Turno"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[3].Value = conn.leer["Ruta"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[4].Value = conn.leer["Sentido"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[5].Value = conn.leer["Vehiculo"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[6].Value = conn.leer["SubNombre"].ToString();
				dtViajesEstandarExtras.Rows[contador].Cells[7].Value = ((conn.leer["Vehiculo"].ToString().Equals("CAMION")) ? Csencillos : CVsencillo);
				++contador;
			}
			conn.conexion.Close();
			
			if(dtViajesEstandarExtras.RowCount<=0)
			{
				dtViajesEstandarExtras.Visible = false;
				lblExtraEstandar.Visible = false;
			}
			else
			{
				if(ckAutosize.Checked==true)
				{
					dtViajesEstandarExtras.Visible = true;
					lblExtraEstandar.Visible = true;
					dtViajesEstandarExtras.AutoSize = true;
				}
			}				
			dtViajesEstandarExtras.ClearSelection();
			
			// CONTEO SE SENCILLOS Y COMPLETOS 
			String FechaViajeNormal="";
			String RutaViajeNormal="";
			String SentidoViajeNormal="";
			String TurnoViajeNormal="";
			String VehiculoNormal="";
			String SubNombre="";
			
			String FechaViajeNormal2="";
			String RutaViajeNormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal2="";
			String VehiculoNormal2="";
			String SubNombre2="";

			for(int y = 0; y<(dtViajesEstandarExtras.RowCount-1); y++){
				FechaViajeNormal = dtViajesEstandarExtras.Rows[y].Cells[1].Value.ToString();
				TurnoViajeNormal = dtViajesEstandarExtras.Rows[y].Cells[2].Value.ToString();
				RutaViajeNormal = dtViajesEstandarExtras.Rows[y].Cells[3].Value.ToString();
				SentidoViajeNormal = dtViajesEstandarExtras.Rows[y].Cells[4].Value.ToString();
				VehiculoNormal = dtViajesEstandarExtras.Rows[y].Cells[5].Value.ToString();	
				SubNombre = dtViajesEstandarExtras.Rows[y].Cells[6].Value.ToString();				
				
				for(int x = 1; x<(dtViajesEstandarExtras.RowCount); x++){				
					FechaViajeNormal2 = dtViajesEstandarExtras.Rows[x].Cells[1].Value.ToString();
					TurnoViajeNormal2 = dtViajesEstandarExtras.Rows[x].Cells[2].Value.ToString();
					RutaViajeNormal2 = dtViajesEstandarExtras.Rows[x].Cells[3].Value.ToString();
					SentidoViajeNormal2 = dtViajesEstandarExtras.Rows[x].Cells[4].Value.ToString();
					VehiculoNormal2 = dtViajesEstandarExtras.Rows[x].Cells[5].Value.ToString();	
					SubNombre2 = dtViajesEstandarExtras.Rows[x].Cells[6].Value.ToString();		
	
					if(((FechaViajeNormal==FechaViajeNormal2)&&(RutaViajeNormal==RutaViajeNormal2)&&(SubNombre==SubNombre2)&&(TurnoViajeNormal==TurnoViajeNormal2)&&(VehiculoNormal==VehiculoNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2))
						{
							if((dtViajesEstandarExtras.Rows[y].Cells[0].Value.ToString()!="Completo")&&(dtViajesEstandarExtras.Rows[x].Cells[0].Value.ToString()!="Completo"))
							{
								
								dtViajesEstandarExtras.Rows[y].Cells[3].Value = dtViajesEstandarExtras.Rows[y].Cells[3].Value +" - "+dtViajesEstandarExtras.Rows[x].Cells[3].Value;										
								dtViajesEstandarExtras.Rows[y].Cells[6].Value = dtViajesEstandarExtras.Rows[y].Cells[6].Value +" - "+dtViajesEstandarExtras.Rows[x].Cells[6].Value;
								dtViajesEstandarExtras.Rows[x].Cells[3].Value = dtViajesEstandarExtras.Rows[y].Cells[3].Value +" - "+dtViajesEstandarExtras.Rows[x].Cells[3].Value;										
								dtViajesEstandarExtras.Rows[x].Cells[6].Value = dtViajesEstandarExtras.Rows[y].Cells[6].Value +" - "+dtViajesEstandarExtras.Rows[x].Cells[6].Value;	
											
								dtViajesEstandarExtras.Rows[x].Cells[7].Value = Ccompletos;								
								dtViajesEstandarExtras.Rows[y].Cells[7].Value = Ccompletos;
								
								dtViajesEstandarExtras.Rows[y].Cells[0].Value="Completo";
								dtViajesEstandarExtras.Rows[x].Cells[0].Value="Completo";
								dtViajesEstandarExtras.Rows[y].Cells[0].Style.BackColor = Color.SpringGreen;			
								dtViajesEstandarExtras.Rows[x].Cells[0].Style.BackColor = Color.SpringGreen;

								dtViajesEstandarExtras.Rows[y].Cells[4].Value = "E/S";
								dtViajesEstandarExtras.Rows[x].Cells[4].Value = "E/S";
								
								if(x!=y){
									dtViajesEstandarExtras.Rows.RemoveAt(x);
									if(y>0)
										--x;
								}
							}
						}
				}
			}		
			
		}
		
		void totalesRimsa(){
			dgTotalesRimsa.Rows.Clear();
			TimeSpan ts = Convert.ToDateTime(dateCorte.Value) - Convert.ToDateTime(dateInicio.Value);
			int dias = ts.Days;
			if(Convert.ToDateTime(dateInicio.Value) < Convert.ToDateTime(dateCorte.Value))
				dias++;
			
			for(int x = 0; x<=dias; x++){
				if(dateInicio.Value.AddDays(x) <= dateCorte.Value ){					
					dgTotalesRimsa.Rows.Add(dateInicio.Value.AddDays(x).ToString("dd/MM/yyyy"), "Mañana", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
					dgTotalesRimsa.Rows.Add(dateInicio.Value.AddDays(x).ToString("dd/MM/yyyy"), "Medio día", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
					dgTotalesRimsa.Rows.Add(dateInicio.Value.AddDays(x).ToString("dd/MM/yyyy"), "Vespertino", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
					dgTotalesRimsa.Rows.Add(dateInicio.Value.AddDays(x).ToString("dd/MM/yyyy"), "Nocturno", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
					dgTotalesRimsa.Rows.Add(dateInicio.Value.AddDays(x).ToString("dd/MM/yyyy"), "Almacen", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
				}
			}
			
			if(dgTotalesRimsa.RowCount <= 0){
				dgTotalesRimsa.Visible = false;
			}else{
				if(ckAutosize.Checked==true){
					dgTotalesRimsa.Visible = true;
					dgTotalesRimsa.AutoSize = true;
				}
			}
			
			for(int y=0; y<dataRimsa.RowCount; y++){
				for(int z=0; z<dgTotalesRimsa.RowCount; z++){
					if(dgTotalesRimsa[0,z].Value.ToString() == dataRimsa[1,y].Value.ToString() && dgTotalesRimsa[1,z].Value.ToString() == dataRimsa[5,y].Value.ToString() ){
						if(dataRimsa[0,y].Value.ToString() == "Completo"){
							if(dataRimsa[9,y].Value.ToString().Equals("SI")){
								if(dataRimsa[2,y].Value.ToString().Contains("LAR")){
									if(dataRimsa[2,y].Value.ToString().Contains("LAR CAMIONES"))
										dgTotalesRimsa[3,z].Value = Convert.ToInt64(dgTotalesRimsa[3,z].Value) + 1;
									else
										dgTotalesRimsa[11,z].Value = Convert.ToInt64(dgTotalesRimsa[11,z].Value) + 1;
										
									dgTotalesRimsa[8,z].Value = Convert.ToDouble(dgTotalesRimsa[8,z].Value) + Convert.ToDouble(dataRimsa[11,y].Value);									
									dgTotalesRimsa[6,z].Value = Convert.ToInt64(dgTotalesRimsa[6,z].Value) + 1;
									dgTotalesRimsa[9,z].Value = Convert.ToDouble(dgTotalesRimsa[9,z].Value) + Convert.ToDouble(dataRimsa[10,y].Value);
								}else{
									dgTotalesRimsa[4,z].Value = Convert.ToInt64(dgTotalesRimsa[4,z].Value) + 1;
									dgTotalesRimsa[9,z].Value = Convert.ToDouble(dgTotalesRimsa[9,z].Value) + Convert.ToDouble(dataRimsa[10,y].Value);									
								}									
							}else{
								if(dataRimsa[6,y].Value.ToString().Equals("CAMION"))									
									dgTotalesRimsa[2,z].Value = Convert.ToInt64(dgTotalesRimsa[2,z].Value) + 1;
								else	
									dgTotalesRimsa[10,z].Value = Convert.ToInt64(dgTotalesRimsa[10,z].Value) + 1;
									
								dgTotalesRimsa[8,z].Value = Convert.ToDouble(dgTotalesRimsa[8,z].Value) + Convert.ToDouble(dataRimsa[11,y].Value);	
							}
						}else{
							if(dataRimsa[9,y].Value.ToString().Equals("SI")){
								//if(dataRimsa[6,y].Value.ToString().Equals("CAMION"))									
								dgTotalesRimsa[5,z].Value = Convert.ToInt64(dgTotalesRimsa[5,z].Value) + 1;
								//else	 camionata vanilla
									//dgTotalesRimsa[11,z].Value = Convert.ToInt64(dgTotalesRimsa[11,z].Value) + 1;
								dgTotalesRimsa[9,z].Value = Convert.ToDouble(dgTotalesRimsa[9,z].Value) + Convert.ToDouble(dataRimsa[10,y].Value);							
							}else{
								if(dataRimsa[6,y].Value.ToString().Equals("CAMION"))								
									dgTotalesRimsa[3,z].Value = Convert.ToInt64(dgTotalesRimsa[3,z].Value) + 1;
								else										
									dgTotalesRimsa[11,z].Value = Convert.ToInt64(dgTotalesRimsa[11,z].Value) + 1;
								dgTotalesRimsa[8,z].Value = Convert.ToDouble(dgTotalesRimsa[8,z].Value) + Convert.ToDouble(dataRimsa[11,y].Value);	
							}
						}
					}
				}
			}
			
			for(int b=0; b<dgTotalesRimsa.RowCount; b++){
				for(int a=0; a<dataDatoLuisAlmacen.RowCount; a++){
					if(dataDatoLuisAlmacen[0,a].Value != null && dataDatoLuisAlmacen[3,a].Value != null){
						if(dgTotalesRimsa[0,b].Value.ToString() == dataDatoLuisAlmacen[0,a].Value.ToString() && dgTotalesRimsa[1,b].Value.ToString() == dataDatoLuisAlmacen[3,a].Value.ToString() ){
							dgTotalesRimsa[7,b].Value = Convert.ToInt64(dgTotalesRimsa[7,b].Value) + 1;		
							dgTotalesRimsa[8,b].Value = Convert.ToDouble(dgTotalesRimsa[8,b].Value) + Convert.ToDouble(dataDatoLuisAlmacen[4,a].Value);
						}
					}						
				}
			}
		}
		
		void PrecioRimsa(){
		  	/*Csencillos = 762.56;
			Ccompletos = 932.70;
			Calmacen = 197.48;
			ClaVenta = 450.00;
			CVsencillo = 648.17;
			CVCompleto = 839.43;
			CDiferenciavanilla = 170.14;*/
			Csencillos = connF.obtenerPrecioRIMSA("NA", "Sencillo", "CAMION");
			Ccompletos = connF.obtenerPrecioRIMSA("NA", "Completo", "CAMION");
			Calmacen = connF.obtenerPrecioRIMSA("ALMACEN", "NA", "CAMION");
			ClaVenta = connF.obtenerPrecioRIMSA("LA VENTA", "NA", "CAMIONETA");
			CVsencillo = connF.obtenerPrecioRIMSA("VANILLA", "Sencillo", "CAMIONETA");
			CVCompleto = connF.obtenerPrecioRIMSA("VANILLA", "Completo", "CAMIONETA");
			CDiferenciavanilla = connF.obtenerPrecioRIMSA("DIFERENCIA", "NA", "CAMIONETA");
		}
		#endregion
				
		#region MATRIZ RIMSA
		void CalculoRimsa2()
		{
			int contador = 0;
			int condia = 0;
			int NormalesM = 0;
			int CompletosM = 0;
			int NormalesMD = 0;
			int CompletosMD = 0;
			int NormalesV = 0;
			int CompletosV = 0;
			int NormalesN = 0;
			int CompletosN = 0;
			int Almacen = 0;

			String FechaTotales = "";
			String FechaTotales2 = "";
			String FechaFinal = "";
			
			dataRimsa.Rows.Clear();
			while(dateInicio.Value.AddDays(condia)<=dateCorte.Value)
			{
					dataRimsa.Rows.Add();
					dataRimsa.Rows[contador].Cells[1].Value = "Mañana";
					dataRimsa.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					dataRimsa.Rows.Add();
					dataRimsa.Rows[contador].Cells[1].Value = "Medio día";
					dataRimsa.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					dataRimsa.Rows.Add();
					dataRimsa.Rows[contador].Cells[1].Value = "Vespertino";
					dataRimsa.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					dataRimsa.Rows.Add();
					dataRimsa.Rows[contador].Cells[1].Value = "Nocturno";
					dataRimsa.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					dataRimsa.Rows.Add();
					dataRimsa.Rows[contador].Cells[1].Value = "Almacen";
					dataRimsa.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					++condia;
			}	
				
				dataDatoLuis.ClearSelection();
				dataDatoChuy.ClearSelection();
				dataDatoChuyAlmacen.ClearSelection();
				dataDatoLuisAlmacen.ClearSelection();
				dataRimsa.ClearSelection();
				
				for(int y = 0; y<dataRimsa.RowCount; y++)
				{
						NormalesM = 0;
						CompletosM = 0;
						NormalesMD = 0;
						CompletosMD = 0;
						NormalesV = 0;
						CompletosV = 0;
						NormalesN = 0;
						CompletosN = 0;
						Almacen = 0;
									
						FechaTotales = dataRimsa.Rows[y].Cells[0].Value.ToString();
						for(int x = 0; x<dataDatoLuis.RowCount-1; x++)
						{
							FechaTotales2 = ""+dataDatoLuis.Rows[x].Cells[1].Value;
							FechaFinal = FechaTotales2.Substring(0,10);
							if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Mañana"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Mañana")
								{
									CompletosM = CompletosM + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosM;
									dataRimsa.Rows[y].Cells[4].Value = CompletosM;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Medio día"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Medio día")
								{
									CompletosMD = CompletosMD + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosMD;
									dataRimsa.Rows[y].Cells[4].Value = CompletosMD;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Vespertino"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Vespertino")
								{
									CompletosV = CompletosV + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosV;
									dataRimsa.Rows[y].Cells[4].Value = CompletosV;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Nocturno"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Nocturno")
								{
									CompletosN = CompletosN + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosN;
									dataRimsa.Rows[y].Cells[4].Value = CompletosN;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Mañana"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Mañana")
								{
									NormalesM = NormalesM + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesM;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Medio día"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Medio día")
								{
									NormalesMD = NormalesMD + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesMD;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Vespertino"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Vespertino")
								{
									NormalesV = NormalesV + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesV;
								}
							} 
							else if((FechaTotales==FechaFinal)&&(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoLuis.Rows[x].Cells[4].Value.ToString()=="Nocturno"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Nocturno")
								{
									NormalesN = NormalesN + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesN;
								}
							}
						}
						
						for(int x = 0; x<dataDatoChuy.RowCount-1; x++)
						{
							FechaTotales2 = ""+dataDatoChuy.Rows[x].Cells[1].Value;
							FechaFinal = FechaTotales2.Substring(0,10);
							if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Mañana"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Mañana")
								{
									CompletosM = CompletosM + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosM;
									dataRimsa.Rows[y].Cells[4].Value = CompletosM;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Medio día"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Medio día")
								{
									CompletosMD = CompletosMD + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosMD;
									dataRimsa.Rows[y].Cells[4].Value = CompletosMD;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Vespertino"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Vespertino")
								{
									CompletosV = CompletosV + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosV;
									dataRimsa.Rows[y].Cells[4].Value = CompletosV;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Completo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Nocturno"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Nocturno")
								{
									CompletosN = CompletosN + 1;
									dataRimsa.Rows[y].Cells[3].Value = CompletosN;
									dataRimsa.Rows[y].Cells[4].Value = CompletosN;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Mañana"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Mañana")
								{
									NormalesM = NormalesM + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesM;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Medio día"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Medio día")
								{
									NormalesMD = NormalesMD + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesMD;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Vespertino"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Vespertino")
								{
									NormalesV = NormalesV + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesV;
								}
							}
							else if((FechaTotales==FechaFinal)&&(dataDatoChuy.Rows[x].Cells[0].Value.ToString()=="Sencillo")&&(dataDatoChuy.Rows[x].Cells[4].Value.ToString()=="Nocturno"))
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Nocturno")
								{
									NormalesN = NormalesN + 1;
									dataRimsa.Rows[y].Cells[2].Value = NormalesN;
								}
							}
						}
						
						for(int x = 0; x<dataDatoChuyAlmacen.RowCount-1; x++)
						{
							FechaTotales2 = ""+dataDatoChuyAlmacen.Rows[x].Cells[0].Value;
							FechaFinal = FechaTotales2.Substring(0,10);
							if(FechaTotales==FechaFinal)
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Almacen")
								{
									Almacen = Almacen + 1;
									dataRimsa.Rows[y].Cells[2].Value = Almacen;
								}
							}
						}
						
						for(int x = 0; x<dataDatoLuisAlmacen.RowCount-1; x++)
						{
							FechaTotales2 = ""+dataDatoLuisAlmacen.Rows[x].Cells[0].Value;
							FechaFinal = FechaTotales2.Substring(0,10);
							if(FechaTotales==FechaFinal)
							{
								if(dataRimsa.Rows[y].Cells[1].Value.ToString()=="Almacen")
								{
									Almacen = Almacen + 1;
									dataRimsa.Rows[y].Cells[2].Value = Almacen;
								}
							}
						}
						
				}
				
		}
		#endregion
		
		#region SENCILLO - COMPLETO RIMSA
		void SumaViajesRIMSAChuy()
		{
			String FechaViajeNormal="";
			String SentidoViajeNormal="";
			String FechaViajeNormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal="";
			String TurnoViajeNormal2="";
			for(int y = 0; y<(dataDatoChuy.RowCount-2); y++)
			{
				FechaViajeNormal = dataDatoChuy.Rows[y].Cells[1].Value.ToString();
				SentidoViajeNormal = dataDatoChuy.Rows[y].Cells[3].Value.ToString();
				TurnoViajeNormal = dataDatoChuy.Rows[y].Cells[4].Value.ToString();
				for(int x = 1; x<(dataDatoChuy.RowCount-1); x++)
				{
					FechaViajeNormal2 = dataDatoChuy.Rows[x].Cells[1].Value.ToString();
					SentidoViajeNormal2 = dataDatoChuy.Rows[x].Cells[3].Value.ToString();
					TurnoViajeNormal2 = dataDatoChuy.Rows[x].Cells[4].Value.ToString();
						if(((FechaViajeNormal==FechaViajeNormal2)&&(TurnoViajeNormal==TurnoViajeNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2))
						{
							if((dataDatoChuy.Rows[y].Cells[0].Style.BackColor.Name!="SpringGreen")&&(dataDatoChuy.Rows[x].Cells[0].Style.BackColor.Name!="SpringGreen"))
							{
								dataDatoChuy.Rows[y].Cells[0].Value="Completo";
								dataDatoChuy.Rows[y].Cells[0].Style.BackColor=Color.SpringGreen;
								dataDatoChuy.Rows[y].Cells[0].Style.ForeColor=Color.Black;
								dataDatoChuy.Rows[x].Cells[0].Value="Completo";
								dataDatoChuy.Rows[x].Cells[0].Style.BackColor=Color.SpringGreen;
								dataDatoChuy.Rows[x].Cells[0].Style.ForeColor=Color.Black;
								if(x!=y)
								{
										dataDatoChuy.Rows.RemoveAt(x);
										if(y>0)
											--x;
								}
							}
						}
				}//TERMINA 2 FOR
			}//TERMINA 1 FOR
		}
		
		void SumaViajesRIMSALuis()
		{
			String FechaViajeNormal="";
			String SentidoViajeNormal="";
			String FechaViajeNormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal="";
			String TurnoViajeNormal2="";

			for(int y = 0; y<(dataDatoLuis.RowCount-2); y++)
			{
				FechaViajeNormal = dataDatoLuis.Rows[y].Cells[1].Value.ToString();
				SentidoViajeNormal = dataDatoLuis.Rows[y].Cells[3].Value.ToString();
				TurnoViajeNormal = dataDatoLuis.Rows[y].Cells[4].Value.ToString();
				for(int x = 1; x<(dataDatoLuis.RowCount-1); x++)
				{
					FechaViajeNormal2 = dataDatoLuis.Rows[x].Cells[1].Value.ToString();
					SentidoViajeNormal2 = dataDatoLuis.Rows[x].Cells[3].Value.ToString();
					TurnoViajeNormal2 = dataDatoLuis.Rows[x].Cells[4].Value.ToString();
					if(((FechaViajeNormal==FechaViajeNormal2)&&(TurnoViajeNormal==TurnoViajeNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2))
					{
						if((dataDatoLuis.Rows[y].Cells[0].Style.BackColor.Name!="SpringGreen")&&(dataDatoLuis.Rows[x].Cells[0].Style.BackColor.Name!="SpringGreen"))
						{
							dataDatoLuis.Rows[y].Cells[0].Value="Completo";
							dataDatoLuis.Rows[y].Cells[0].Style.BackColor=Color.SpringGreen;
							dataDatoLuis.Rows[y].Cells[0].Style.ForeColor=Color.Black;
							dataDatoLuis.Rows[x].Cells[0].Value="Completo";
							dataDatoLuis.Rows[x].Cells[0].Style.BackColor=Color.SpringGreen;
							dataDatoLuis.Rows[x].Cells[0].Style.ForeColor=Color.Black;
							
							
							if(x!=y)
							{
									dataDatoLuis.Rows.RemoveAt(x);
									if(y>0)
										--x;
							}
							
						}
					}
				}//TERMINA 2 FOR
			}//TERMINA 1 FOR
		}
		#endregion
		
		#region CALCULO RIMSA
		void ConsultasRimsaFecha()
		{
			int dias = 0;
			
			dataLuisNormales.Rows.Clear();
			dataChuyNormales.Rows.Clear();
			dataLuisAlmacen.Rows.Clear();
			dataChuyAlmacen.Rows.Clear();
			while(dateInicio.Value.AddDays(dias)<=dateCorte.Value)
			{
				dataLuisNormales.Rows.Add();
				dataLuisNormales.Rows[dias].Cells[0].Value = dateInicio.Value.AddDays(dias).ToString().Substring(0,10);

				dataChuyNormales.Rows.Add();
				dataChuyNormales.Rows[dias].Cells[0].Value = dateInicio.Value.AddDays(dias).ToString().Substring(0,10);

				dataLuisAlmacen.Rows.Add();
				dataLuisAlmacen.Rows[dias].Cells[0].Value = dateInicio.Value.AddDays(dias).ToString().Substring(0,10);

				dataChuyAlmacen.Rows.Add();
				dataChuyAlmacen.Rows[dias].Cells[0].Value = dateInicio.Value.AddDays(dias).ToString().Substring(0,10);
				++dias;
			}
		}
		
		void CalculoRimsa()
		{
			int CompletoLuis=0;
			int SencilloChuy=0;
			int SencilloLuis=0;
			int CompletoChuy=0;
			int SencilloLuisA=0;
			int SencilloChuyA=0;
			int CompletoLuisA=0;
			int CompletoChuyA=0;
			String FechaRimsa = "";
			String FechaRimsa2 = "";
			
			for(int a=0; a<dataLuisNormales.RowCount; a++)
			{
				CompletoLuis = 0;
				SencilloLuis = 0;
				FechaRimsa = dataLuisNormales.Rows[a].Cells[0].Value.ToString();
				for(int x=0; x<dataDatoLuis.RowCount-1; x++)
				{
					FechaRimsa2 = dataDatoLuis.Rows[x].Cells[1].Value.ToString();
						if(FechaRimsa2.Substring(0,10)==FechaRimsa)
						{
							if(dataDatoLuis.Rows[x].Cells[0].Value.ToString()=="Completo")
							   {
							   	 CompletoLuis = CompletoLuis + 1;
							   	 dataLuisNormales.Rows[a].Cells[2].Value = CompletoLuis;
							   }
							   else
							   {
							   	 SencilloLuis = SencilloLuis + 1;
							   	 dataLuisNormales.Rows[a].Cells[1].Value = SencilloLuis;
							   }
						}
				}
			}
				
			for(int b=0; b<dataChuyNormales.RowCount; b++)
			{
				CompletoChuy = 0;
				SencilloChuy = 0;
				FechaRimsa = dataChuyNormales.Rows[b].Cells[0].Value.ToString();
				for(int y=0; y<dataDatoChuy.RowCount-1; y++)
				{
					FechaRimsa2 = dataDatoChuy.Rows[y].Cells[1].Value.ToString();
					if(FechaRimsa2.Substring(0,10)==FechaRimsa)
					{
						if(dataDatoChuy.Rows[y].Cells[0].Value.ToString()=="Completo")
						   {
						   	 CompletoChuy = CompletoChuy + 1;
						   	 dataChuyNormales.Rows[b].Cells[2].Value = CompletoChuy;
						   }
						   else
						   {
						   	 SencilloChuy = SencilloChuy + 1;
						   	 dataChuyNormales.Rows[b].Cells[1].Value = SencilloChuy;
						   }
					}
				}
			}
			
			for(int c=0; c<dataLuisAlmacen.RowCount; c++)
			{
					CompletoLuisA = 0;
					SencilloLuisA = 0;
					FechaRimsa = dataLuisAlmacen.Rows[c].Cells[0].Value.ToString();
					for(int w=0; w<dataDatoLuisAlmacen.RowCount-1; w++)
					{
						FechaRimsa2 = dataDatoLuisAlmacen.Rows[w].Cells[0].Value.ToString();
						
						if(FechaRimsa2.Substring(0,10)==FechaRimsa)
						{
							if(dataDatoLuisAlmacen.Rows[w].Cells[0].Value.ToString()=="Completo")
							   {
							   	 CompletoLuisA = CompletoLuisA + 1;
							   	 dataLuisAlmacen.Rows[c].Cells[2].Value = CompletoLuisA;
							   }
							   else
							   {
							   	 SencilloLuisA = SencilloLuisA + 1;
							   	 dataLuisAlmacen.Rows[c].Cells[1].Value = SencilloLuisA;
							   }
						}
				}
			}
			
			for(int d=0; d<dataChuyAlmacen.RowCount; d++)
			{
				CompletoChuyA = 0;
				SencilloChuyA = 0;
				
				FechaRimsa = dataChuyAlmacen.Rows[d].Cells[0].Value.ToString();
		
				for(int z=0; z<dataDatoChuyAlmacen.RowCount-1; z++)
				{
					FechaRimsa2 = dataDatoChuyAlmacen.Rows[z].Cells[0].Value.ToString();
					
					if(FechaRimsa2.Substring(0,10)==FechaRimsa)
					{
						if(dataDatoChuyAlmacen.Rows[z].Cells[0].Value.ToString()=="Completo")
						   {
						   	 CompletoChuyA = CompletoChuyA + 1;
						   	 dataLuisNormales.Rows[d].Cells[2].Value = CompletoChuyA;
						   }
						   else
						   {
						   	 SencilloChuyA = SencilloChuyA + 1;
						   	 dataChuyAlmacen.Rows[d].Cells[1].Value = SencilloChuyA;
						   }
					}
				}
			}
			SumaRimsaFinal();
		}
		#endregion
		
		#region SUMA FINAL RIMSA
		void SumaRimsaFinal()
		{
			int SumaViajesSNLuis=0;
			int SumaViajesCNLuis=0;
			int SumaViajesSNChuy=0;
			int SumaViajesCNChuy=0;
			int SumaViajesSALuis=0;
			int SumaViajesSAChuy=0;
			
			txtSencilloLuis.Text = "0";
			txtEntrada.Text = "0";
			txtSalida.Text =  "0";
			txtSencilloChuy.Text = "0";
			txtEntradaChuy.Text =  "0";
			txtSalidaChuy.Text =  "0";
			txtAlmacen.Text = "0";
			txtAlamcenChuy.Text = "0";
			
			for(int a=0; a<dataLuisNormales.RowCount; a++)
			{
				SumaViajesCNLuis = SumaViajesCNLuis + (Convert.ToInt32(dataLuisNormales.Rows[a].Cells[2].Value));
				SumaViajesSNLuis = SumaViajesSNLuis + (Convert.ToInt32(dataLuisNormales.Rows[a].Cells[1].Value));
				txtSencilloLuis.Text = SumaViajesSNLuis.ToString();
				txtEntrada.Text =  SumaViajesCNLuis.ToString();
				txtSalida.Text =  SumaViajesCNLuis.ToString();
			}
			
			for(int b=0; b<dataChuyNormales.RowCount; b++)
			{
				SumaViajesCNChuy = SumaViajesCNChuy + (Convert.ToInt32(dataChuyNormales.Rows[b].Cells[2].Value));
				SumaViajesSNChuy = SumaViajesSNChuy + (Convert.ToInt32(dataChuyNormales.Rows[b].Cells[1].Value));
				txtSencilloChuy.Text = SumaViajesSNChuy.ToString();
				txtEntradaChuy.Text =  SumaViajesCNChuy.ToString();
				txtSalidaChuy.Text =  SumaViajesCNChuy.ToString();
			}
			
			for(int c=0; c<dataLuisAlmacen.RowCount; c++)
			{
				SumaViajesSALuis = SumaViajesSALuis + (Convert.ToInt32(dataLuisAlmacen.Rows[c].Cells[1].Value));
				txtAlmacen.Text = SumaViajesSALuis.ToString();
			}
			
			for(int d=0; d<dataChuyAlmacen.RowCount; d++)
			{
				SumaViajesSAChuy = SumaViajesSAChuy + (Convert.ToInt32(dataChuyAlmacen.Rows[d].Cells[1].Value));
				txtAlamcenChuy.Text = SumaViajesSAChuy.ToString();
			}	
		}
		
		void SumaRimsa2()
		{
			int Normales=0;
			int Entradas=0;
			int Salidas=0;
			int Almacen=0;
			
			for(int x = 0; x<dataRimsa.RowCount; x++)
			{
				if(dataRimsa.Rows[x].Cells[1].Value.ToString()!="Almacen")
					Normales = Normales + (Convert.ToInt32(dataRimsa.Rows[x].Cells[2].Value));
				
				if(dataRimsa.Rows[x].Cells[1].Value.ToString()=="Almacen")
					Almacen = Almacen + (Convert.ToInt32(dataRimsa.Rows[x].Cells[2].Value));
				
				Entradas = Entradas + (Convert.ToInt32(dataRimsa.Rows[x].Cells[3].Value));
				Salidas = Salidas + (Convert.ToInt32(dataRimsa.Rows[x].Cells[4].Value));
			}
			txtNormales.Text = Normales.ToString();
			txtCompletasEntradas.Text = Entradas.ToString();
			txtCompletasSalidas.Text = Salidas.ToString();
			txtAlmacenRimsa2.Text = Almacen.ToString();
		}
		#endregion
		
		//COREY	- FORSAC	
		
		#region BORRADO VACIOS COREY - FORSAC
		void BorradoVaciosCOREY()
		{
			for(int y = 0; y<dataCorey.RowCount; y++)
			{
				if((dataCorey.Rows[y].Cells[2].Value==null)&&(dataCorey.Rows[y].Cells[3].Value==null)&&(dataCorey.Rows[y].Cells[4].Value==null)&&(dataCorey.Rows[y].Cells[5].Value==null)&&(dataCorey.Rows[y].Cells[6].Value==null))
				{
					dataCorey.Rows.RemoveAt(y);
					y=y-1;
				}
			}
		}
		#endregion
		
		#region CALCULO FACTURACION
		void CalculoFacturizacionCOREY()
		{	
			int contador = 0;
			int condia = 0;
			dataViajesNormales.ClearSelection();
			dataCorey.Rows.Clear();
			dataCorey.ClearSelection();
			
			while(dateInicio.Value.AddDays(condia)<=dateCorte.Value)
			{
				if(lblEmpresa.Text=="COREY CAMIONES" || lblEmpresa.Text=="COREY CAMIONETAS")
				{
					dataCorey.Columns[2].HeaderText = "Camionetas Completas";
					dataCorey.Columns[3].HeaderText = "Camionetas Sencillas";
					dataCorey.Rows.Add();
					dataCorey.Rows[contador].Cells[1].Value = "Mañana";
					dataCorey.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					dataCorey.Rows.Add();
					dataCorey.Rows[contador].Cells[1].Value = "Medio día";
					dataCorey.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					dataCorey.Rows.Add();
					dataCorey.Rows[contador].Cells[1].Value = "Vespertino";
					dataCorey.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
					dataCorey.Rows.Add();
					dataCorey.Rows[contador].Cells[1].Value = "Nocturno";
					dataCorey.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
					++contador;
				}
				else
				{
					dataCorey.Columns[2].HeaderText = "Galerias Ctas Sencillas";
					dataCorey.Columns[3].HeaderText = "Tabachines Ctas Sencillas";
					conn.getAbrirConexion("Select Distinct(R.HoraInicio) as Dato " +
						                     "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, Orden_empresas Oe "+
		                               		"where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
		                                    "and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID AND C.Empresa='"+NomEmpresa+"' and " +
		                                    "O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.FACTURA!='1' ");
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dataCorey.Rows.Add();
						dataCorey.Rows[contador].Cells[1].Value = conn.leer["Dato"].ToString();
						dataCorey.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
						++contador;
					}
					conn.conexion.Close();
				}
					++condia;
			}
				
				for(int w = 0; w<dataViajesNormales.RowCount; w++)
				{
					progresobarra(dataViajesNormales.RowCount);
					for(int y = 0; y < dataCorey.RowCount; y++)
					{
						if(lblEmpresa.Text=="COREY CAMIONES" || lblEmpresa.Text=="COREY CAMIONETAS")
						{
							if(dataViajesNormales.Rows[w].Cells[6].Value.ToString()=="Mañana")
							{
								if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataCorey.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[6].Value.ToString()==dataCorey.Rows[y].Cells[1].Value.ToString()&&dataViajesNormales.Rows[w].Cells[4].Value.ToString()=="SUR" && dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA")
								{
									dataCorey.Rows[y].Cells[6].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[6].Value) + 1;
									dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
									
									dataCorey.Rows[y].Cells[11].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
									dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
									
									break;
								}
							}
							else if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataCorey.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[6].Value.ToString()==dataCorey.Rows[y].Cells[1].Value.ToString()&&dataViajesNormales.Rows[w].Cells[4].Value.ToString()=="SUR" && dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA")
							{
								if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA")
								{
									if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
									{
										dataCorey.Rows[y].Cells[3].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[3].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[8].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[8].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
									
										break;
									}
									else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
									{
										dataCorey.Rows[y].Cells[2].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[2].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[7].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[7].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										break;
									}
								}
							} 
						}
						/*else
						{
							if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataCorey.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[12].Value.ToString()==dataCorey.Rows[y].Cells[1].Value.ToString()&&(dataViajesNormales.Rows[w].Cells[4].Value.ToString().Contains("ANGEL")||dataViajesNormales.Rows[w].Cells[4].Value.ToString().Contains("LEAÑO")))
							{
								dataCorey.Rows[y].Cells[6].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[6].Value) + 1;
								dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
								
								dataCorey.Rows[y].Cells[11].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
								dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
								dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
								break;
							}
						}*/
						if(lblEmpresa.Text=="COREY CAMIONES" || lblEmpresa.Text=="COREY CAMIONETAS")
						{
							//if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataCorey.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[6].Value.ToString()==dataCorey.Rows[y].Cells[1].Value.ToString()&&dataViajesNormales.Rows[w].Cells[9].Value.ToString()!="EXT")
							if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataCorey.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[6].Value.ToString()==dataCorey.Rows[y].Cells[1].Value.ToString())
							{
								if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMION")
								{
									if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
									{
										dataCorey.Rows[y].Cells[5].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[5].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[10].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[10].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
									else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
									{
										dataCorey.Rows[y].Cells[4].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[4].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[9].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[9].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
								}
								else if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA")
								{
									if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
									{
										dataCorey.Rows[y].Cells[3].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[3].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[8].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[8].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
									else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
									{
										dataCorey.Rows[y].Cells[2].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[2].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[7].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[7].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
								}
							}
						}
						else
						{
							//if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataCorey.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[6].Value.ToString()==dataCorey.Rows[y].Cells[1].Value.ToString()&&dataViajesNormales.Rows[w].Cells[9].Value.ToString()!="EXT")
							if(dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataCorey.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[12].Value.ToString()==dataCorey.Rows[y].Cells[1].Value.ToString())
							{
								if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMION")
								{
									if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
									{
										dataCorey.Rows[y].Cells[5].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[5].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[10].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[10].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
									else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
									{
										dataCorey.Rows[y].Cells[4].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[4].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[9].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[9].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
								}
								else if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA")
								{
									if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
									{	
										if (dataViajesNormales.Rows[w].Cells[4].Value.ToString() == "GALERIAS" && dataViajesNormales.Rows[w].Cells[1].Value.ToString() == dataCorey.Rows[y].Cells[0].Value.ToString() && dataViajesNormales.Rows[w].Cells[12].Value.ToString() == dataCorey.Rows[y].Cells[1].Value.ToString()) {
											//MessageBox.Show("gALE");
											dataCorey.Rows[y].Cells[2].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[2].Value) + 1;
										}
										if (dataViajesNormales.Rows[w].Cells[4].Value.ToString() == "TABACHINES" && dataViajesNormales.Rows[w].Cells[1].Value.ToString() == dataCorey.Rows[y].Cells[0].Value.ToString() && dataViajesNormales.Rows[w].Cells[12].Value.ToString() == dataCorey.Rows[y].Cells[1].Value.ToString()) {
											//MessageBox.Show("TABACHINES");
											dataCorey.Rows[y].Cells[3].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[3].Value) + 1;
										}
										//dataCorey.Rows[y].Cells[3].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[3].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[8].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[8].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
									else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
									{
										dataCorey.Rows[y].Cells[2].Value = Convert.ToInt32(dataCorey.Rows[y].Cells[2].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										
										dataCorey.Rows[y].Cells[7].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[7].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Value = Convert.ToDouble(dataCorey.Rows[y].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[w].Cells[19].Value);// lalo
										dataCorey.Rows[y].Cells[12].Style.BackColor = Color.LightGray;
										
										break;
									}
								}
							}
						}
					}
				}
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
		}
	    #endregion
	    
	    #region CALCULO TOTALES REPORTE COREY - FORSAC
		void SumaCOREY()
		{
			int CS=0;
			int CNTS=0;
			int CC=0;
			int CNTC=0;
			int CNTOF=0;
			
			for(int x = 0; x<dataCorey.RowCount; x++)
			{
				CS = CS + (Convert.ToInt32(dataCorey.Rows[x].Cells[5].Value));
				CNTS = CNTS + (Convert.ToInt32(dataCorey.Rows[x].Cells[3].Value));
				CC = CC + (Convert.ToInt32(dataCorey.Rows[x].Cells[4].Value));
				CNTC = CNTC + (Convert.ToInt32(dataCorey.Rows[x].Cells[2].Value));
				CNTOF = CNTOF + (Convert.ToInt32(dataCorey.Rows[x].Cells[6].Value));
			}
			
			txtCamionesC.Text = CC.ToString();
			txtCamionesS.Text = CS.ToString();
			txtCamionetasC.Text = CNTC.ToString();
			txtCamionetasS.Text = CNTS.ToString();
			txtOtroVehiculo.Text = CNTOF.ToString();
		}
		
		void SumaFORSACExtra()
		{
			int CSE = 0;
			int CNTSE = 0;
			int CCE = 0;
			int CNTCE = 0;
			int CNTOFE = 0;
			
			if(lblEmpresa.Text == "FORSAC"){
				for(int x = 0; x<dataViajesNormales.RowCount; x++){
					if(dataViajesNormales.Rows[x].Cells[9].Value.ToString() == "EXT"){				
						if(dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMION"){
							if(dataViajesNormales.Rows[x].Cells[0].Value.ToString() == "Sencillo")
								CSE = CSE +1;										
							else if(dataViajesNormales.Rows[x].Cells[0].Value.ToString() == "Completo")
								CCE = CCE +1;
						}
						else if(dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "CAMIONETA"){
							if(dataViajesNormales.Rows[x].Cells[0].Value.ToString() == "Sencillo")
								CNTSE = CNTSE +1;										
							else if(dataViajesNormales.Rows[x].Cells[0].Value.ToString() == "Completo")
								CNTCE = CNTCE +1;
						}else{
							CNTOFE = CNTOFE +1;
						}
					}
				}
			
				txtCamionesCEXTRA.Text = CCE.ToString();
				txtCamionesSEXTRA.Text = CSE.ToString();
				txtCamionetasCEXTRA.Text = CNTCE.ToString();
				txtCamionetasSEXTRA.Text = CNTSE.ToString();
				txtOtroVehiculoEXTRA.Text = CNTOFE.ToString();					
			}
		}
		#endregion
		
		//FARMACIAS GUADALAJARA
		
		#region CALCULO FARMACIAS GDL
		void FacturizacionFarmacias()
		{	
			int contador = 0;
			int condia = 0;
			dataFarmaciasNormales.Rows.Clear();
			dataFarmaciasNormales.ClearSelection();
			while(dateInicio.Value.AddDays(condia)<=dateCorte.Value)
			{
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                       "where C.Empresa='FARMACIAS GUADALAJARA' and Dato!='FGDL EXTRA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasNormales.Rows.Add();
					dataFarmaciasNormales.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasNormales.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasNormales.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasNormales.Rows[contador].Cells[2].Value = "Mañana";
					dataFarmaciasNormales.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                       "where C.Empresa='FARMACIAS GUADALAJARA' and Dato!='FGDL EXTRA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasNormales.Rows.Add();
					dataFarmaciasNormales.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasNormales.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasNormales.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasNormales.Rows[contador].Cells[2].Value = "Medio día";
					dataFarmaciasNormales.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();	
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                       "where C.Empresa='FARMACIAS GUADALAJARA' and Dato!='FGDL EXTRA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasNormales.Rows.Add();
					dataFarmaciasNormales.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasNormales.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasNormales.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasNormales.Rows[contador].Cells[2].Value = "Vespertino";
					dataFarmaciasNormales.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();	
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                       "where C.Empresa='FARMACIAS GUADALAJARA' and Dato!='FGDL EXTRA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasNormales.Rows.Add();
					dataFarmaciasNormales.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasNormales.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasNormales.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasNormales.Rows[contador].Cells[2].Value = "Nocturno";
					dataFarmaciasNormales.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();			
				condia = condia + 1;
			 }
				for(int y = 0; y<dataViajesNormales.RowCount; y++)
				{
					progresobarra(dataViajesNormales.RowCount);
					for(int z = 0; z<dataFarmaciasNormales.RowCount; z++)
					{
						if(dataViajesNormales.Rows[y].Cells[1].Value.ToString()==dataFarmaciasNormales.Rows[z].Cells[1].Value.ToString()&&dataViajesNormales.Rows[y].Cells[6].Value.ToString()==dataFarmaciasNormales.Rows[z].Cells[2].Value.ToString()&&dataViajesNormales.Rows[y].Cells[10].Value.ToString()==dataFarmaciasNormales.Rows[z].Cells[3].Value.ToString())
						{
							if(dataViajesNormales.Rows[y].Cells[7].Value.ToString()=="CAMION")
							{
								if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Sencillo")
								{
									dataFarmaciasNormales.Rows[z].Cells[7].Value = Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[7].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
																		
									dataFarmaciasNormales.Rows[z].Cells[11].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Style.BackColor = Color.LightGray;
									
									break;
								}
								else if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Completo")
								{
									dataFarmaciasNormales.Rows[z].Cells[6].Value = Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[6].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
																	
									dataFarmaciasNormales.Rows[z].Cells[10].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[10].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Style.BackColor = Color.LightGray;
									
									break;
								}
							}
							else if(dataViajesNormales.Rows[y].Cells[7].Value.ToString()=="CAMIONETA")
							{
								if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Sencillo")
								{
									dataFarmaciasNormales.Rows[z].Cells[5].Value = Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[5].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
																	
									dataFarmaciasNormales.Rows[z].Cells[9].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[9].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Style.BackColor = Color.LightGray;
									
									break;
								}
								else if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Completo")
								{
									dataFarmaciasNormales.Rows[z].Cells[4].Value = Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[4].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
																	
									dataFarmaciasNormales.Rows[z].Cells[8].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[8].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Value = Convert.ToDouble(dataFarmaciasNormales.Rows[z].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasNormales.Rows[z].Cells[12].Style.BackColor = Color.LightGray;
									
									break;
								}
							}
						}
					}
				}
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				for(int z = 0; z<dataFarmaciasNormales.RowCount; z++)
				{
					if(dataFarmaciasNormales.Rows[z].Cells[4].Value==null && dataFarmaciasNormales.Rows[z].Cells[5].Value==null && dataFarmaciasNormales.Rows[z].Cells[6].Value==null && dataFarmaciasNormales.Rows[z].Cells[7].Value==null)
					{
						dataFarmaciasNormales.Rows.RemoveAt(z);
						z=z-1;
					}
				}
				txtCamionetasC.Text = "0";
				txtCamionetasS.Text = "0";
				txtCamionesC.Text = "0";
				txtCamionesS.Text = "0";
				for(int z = 0; z<dataFarmaciasNormales.RowCount; z++)
				{	
					txtCamionetasC.Text = ((Convert.ToInt32(txtCamionetasC.Text))+(Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[4].Value))).ToString();
					txtCamionetasS.Text = ((Convert.ToInt32(txtCamionetasS.Text))+(Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[5].Value))).ToString();
					txtCamionesC.Text = ((Convert.ToInt32(txtCamionesC.Text))+(Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[6].Value))).ToString();
					txtCamionesS.Text = ((Convert.ToInt32(txtCamionesS.Text))+(Convert.ToInt32(dataFarmaciasNormales.Rows[z].Cells[7].Value))).ToString();
				}
		}
		
		void FacturizacionFarmaciasExtras()
		{	
			int contador = 0;
			int condia = 0;
			dataFarmaciasExtras.Rows.Clear();
			dataFarmaciasExtras.ClearSelection();
			while(dateInicio.Value.AddDays(condia)<=dateCorte.Value)
			{
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                       "where C.Empresa='FARMACIAS GUADALAJARA EXTRA' and Dato!='FGDL POSADA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasExtras.Rows.Add();
					dataFarmaciasExtras.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasExtras.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasExtras.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasExtras.Rows[contador].Cells[2].Value = "Mañana";
					dataFarmaciasExtras.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                       "where C.Empresa='FARMACIAS GUADALAJARA EXTRA' and Dato!='FGDL POSADA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasExtras.Rows.Add();
					dataFarmaciasExtras.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasExtras.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasExtras.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasExtras.Rows[contador].Cells[2].Value = "Medio día";
					dataFarmaciasExtras.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();	
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                       "where C.Empresa='FARMACIAS GUADALAJARA EXTRA' and Dato!='FGDL POSADA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasExtras.Rows.Add();
					dataFarmaciasExtras.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasExtras.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasExtras.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasExtras.Rows[contador].Cells[2].Value = "Vespertino";
					dataFarmaciasExtras.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();	
				conn.getAbrirConexion("Select Distinct(Dato) as Dato " +
				                      "from CLIENTE C "+
                                      "where C.Empresa='FARMACIAS GUADALAJARA EXTRA' and Dato!='FGDL POSADA'");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataFarmaciasExtras.Rows.Add();
					dataFarmaciasExtras.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataFarmaciasExtras.Rows[contador].Cells[0].Value = DiaFactura(dataFarmaciasExtras.Rows[contador].Cells[1].Value.ToString());
					dataFarmaciasExtras.Rows[contador].Cells[2].Value = "Nocturno";
					dataFarmaciasExtras.Rows[contador].Cells[3].Value = conn.leer["Dato"].ToString();
					++contador;
				}
				conn.conexion.Close();			
				condia = condia + 1;
			 }
				for(int y = 0; y<dataViajesNormales.RowCount; y++)
				{
					progresobarra(dataViajesNormales.RowCount);
					for(int z = 0; z<dataFarmaciasExtras.RowCount; z++)
					{
						if(dataViajesNormales.Rows[y].Cells[1].Value.ToString()==dataFarmaciasExtras.Rows[z].Cells[1].Value.ToString()&&dataViajesNormales.Rows[y].Cells[6].Value.ToString()==dataFarmaciasExtras.Rows[z].Cells[2].Value.ToString()&&dataViajesNormales.Rows[y].Cells[10].Value.ToString()==dataFarmaciasExtras.Rows[z].Cells[3].Value.ToString())
						{
							if(dataViajesNormales.Rows[y].Cells[11].Value.ToString()=="1")
							{
								dataFarmaciasExtras.Rows[z].Cells[8].Value = Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[8].Value) + 1;
								dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;								
								
								dataFarmaciasExtras.Rows[z].Cells[13].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[13].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
								dataFarmaciasExtras.Rows[z].Cells[14].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[14].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
								dataFarmaciasExtras.Rows[z].Cells[14].Style.BackColor = Color.LightGray;
									
								break;
							}
							else if(dataViajesNormales.Rows[y].Cells[7].Value.ToString()=="CAMION")
							{
								if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Sencillo")
								{
									dataFarmaciasExtras.Rows[z].Cells[7].Value = Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[7].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
									
									dataFarmaciasExtras.Rows[z].Cells[12].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[12].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[14].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Style.BackColor = Color.LightGray;
								
									break;
								}
								else if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Completo")
								{
									dataFarmaciasExtras.Rows[z].Cells[6].Value = Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[6].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
									
									dataFarmaciasExtras.Rows[z].Cells[11].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[11].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[14].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Style.BackColor = Color.LightGray;
									
									break;
								}
							}
							else if(dataViajesNormales.Rows[y].Cells[7].Value.ToString()=="CAMIONETA")
							{
								if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Sencillo")
								{
									dataFarmaciasExtras.Rows[z].Cells[5].Value = Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[5].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
									
									dataFarmaciasExtras.Rows[z].Cells[10].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[10].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[14].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Style.BackColor = Color.LightGray;
									
									break;
								}
								else if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Completo")
								{
									dataFarmaciasExtras.Rows[z].Cells[4].Value = Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[4].Value) + 1;
									dataViajesNormales.Rows[y].Cells[4].Style.BackColor = Color.LightGray;
									
									dataFarmaciasExtras.Rows[z].Cells[9].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[9].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Value = Convert.ToDouble(dataFarmaciasExtras.Rows[z].Cells[14].Value) + Convert.ToDouble(dataViajesNormales.Rows[y].Cells[19].Value);
									dataFarmaciasExtras.Rows[z].Cells[14].Style.BackColor = Color.LightGray;
									
									break;
								}
							}
						}
					}
				}
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				txtCamionetasC.Text = "0";
				txtCamionetasS.Text = "0";
				txtCamionesC.Text = "0";
				txtCamionesS.Text = "0";
				txtOtroVehiculo.Text = "0";
				for(int z = 0; z<dataFarmaciasExtras.RowCount; z++)
				{	
					txtCamionetasC.Text = ((Convert.ToInt32(txtCamionetasC.Text))+(Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[4].Value))).ToString();
					txtCamionetasS.Text = ((Convert.ToInt32(txtCamionetasS.Text))+(Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[5].Value))).ToString();
					txtCamionesC.Text = ((Convert.ToInt32(txtCamionesC.Text))+(Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[6].Value))).ToString();
					txtCamionesS.Text = ((Convert.ToInt32(txtCamionesS.Text))+(Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[7].Value))).ToString();
					txtOtroVehiculo.Text = ((Convert.ToInt32(txtOtroVehiculo.Text))+(Convert.ToInt32(dataFarmaciasExtras.Rows[z].Cells[8].Value))).ToString();
				}
		}
		
		void FacturizacionFarmaciasExtrasDesglose()
		{	
			int contador = 0;
			int condia = 0;
			int a = 0;
			int b = 0;
			int c = 0;
			int d = 0;
			dataDesgloseFar.Rows.Clear();
			dataDesgloseFar.ClearSelection();
			while(dateInicio.Value.AddDays(condia)<=dateCorte.Value)
			{
				a = 0;
				b = 0;
				c = 0;
				d = 0;
				
				while(a<25)
				{
					dataDesgloseFar.Rows.Add();
					dataDesgloseFar.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataDesgloseFar.Rows[contador].Cells[0].Value = DiaFactura(dataDesgloseFar.Rows[contador].Cells[1].Value.ToString());
					dataDesgloseFar.Rows[contador].Cells[3].Value = "Mañana";
					++contador;
					++a;
				}
				
				while(b<25)
				{
					dataDesgloseFar.Rows.Add();
					dataDesgloseFar.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataDesgloseFar.Rows[contador].Cells[0].Value = DiaFactura(dataDesgloseFar.Rows[contador].Cells[1].Value.ToString());
					dataDesgloseFar.Rows[contador].Cells[3].Value = "Medio día";
					++contador;
					++b;
				}
				
				while(c<25)
				{
					dataDesgloseFar.Rows.Add();
					dataDesgloseFar.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataDesgloseFar.Rows[contador].Cells[0].Value = DiaFactura(dataDesgloseFar.Rows[contador].Cells[1].Value.ToString());
					dataDesgloseFar.Rows[contador].Cells[3].Value = "Vespertino";
					++contador;
					++c;
				}
				
				while(d<30)
				{
					dataDesgloseFar.Rows.Add();
					dataDesgloseFar.Rows[contador].Cells[1].Value = dateInicio.Value.AddDays(condia).ToString("dd/MM/yyyy");
					dataDesgloseFar.Rows[contador].Cells[0].Value = DiaFactura(dataDesgloseFar.Rows[contador].Cells[1].Value.ToString());
					dataDesgloseFar.Rows[contador].Cells[3].Value = "Nocturno";
					++contador;
					++d;
				}	
				
				condia = condia + 1;
			}
				for(int y = 0; y<dataViajesNormales.RowCount; y++)
				{
					for(int z = 0; z<dataDesgloseFar.RowCount; z++)
					{
						if(dataViajesNormales.Rows[y].Cells[1].Value.ToString()==dataDesgloseFar.Rows[z].Cells[1].Value.ToString()&&dataViajesNormales.Rows[y].Cells[6].Value.ToString()==dataDesgloseFar.Rows[z].Cells[3].Value.ToString()&&dataDesgloseFar.Rows[z].Cells[4].Value==null&&dataDesgloseFar.Rows[z].Cells[5].Value==null)
						{
							if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Sencillo")
							{
								if(dataViajesNormales.Rows[y].Cells[5].Value.ToString()=="Entrada")
								{
									dataDesgloseFar.Rows[z].Cells[4].Value = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
									dataDesgloseFar.Rows[z].Cells[2].Value = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
									break;
								}
								if(dataViajesNormales.Rows[y].Cells[5].Value.ToString()=="Salida")
								{
									dataDesgloseFar.Rows[z].Cells[5].Value = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
									dataDesgloseFar.Rows[z].Cells[2].Value = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
									break;
								}
							}
							else if(dataViajesNormales.Rows[y].Cells[0].Value.ToString()=="Completo")
							{
								dataDesgloseFar.Rows[z].Cells[4].Value = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
								dataDesgloseFar.Rows[z].Cells[5].Value = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
								dataDesgloseFar.Rows[z].Cells[2].Value = dataViajesNormales.Rows[y].Cells[7].Value.ToString();
								break;
							}
						}
					}
				}
				for(int z = 0; z<dataDesgloseFar.RowCount; z++)
				{
					if(dataDesgloseFar.Rows[z].Cells[4].Value==null && dataDesgloseFar.Rows[z].Cells[5].Value==null)
					{
						dataDesgloseFar.Rows.RemoveAt(z);
						z=z-1;
					}
				}
		}
		#endregion
		
		//HENNIEGES - VITRO
		
		#region HENNIGES - VITRO
		void CalculoFacturizacionHENNIEGES(int interruptor)
		{	
			int contador = 0;
			dataViajesNormales.ClearSelection();
			dataHenniegesNormales.Rows.Clear();
			dataHenniegesNormales.ClearSelection();
			
				conn.getAbrirConexion("Select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and TIPO='NRM' AND TURNO='Mañana' and EMPRESA='"+NomEmpresa+"' order by IDENTIFICADOR");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["IDENTIFICADOR"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["SENTIDO"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Mañana";
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["PRECIO"].ToString();				
					++contador;
				}
				conn.conexion.Close();

				conn.getAbrirConexion("Select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and TIPO='NRM' AND TURNO='Medio día' and EMPRESA='"+NomEmpresa+"' order by IDENTIFICADOR");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["IDENTIFICADOR"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["SENTIDO"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Medio día";
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["PRECIO"].ToString();
					
					++contador;
				}
				conn.conexion.Close();

				conn.getAbrirConexion("Select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and TIPO='NRM' AND TURNO='Vespertino' and EMPRESA='"+NomEmpresa+"' order by IDENTIFICADOR");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["IDENTIFICADOR"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["SENTIDO"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Vespertino";
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["PRECIO"].ToString();
					++contador;
				}
				conn.conexion.Close();

				conn.getAbrirConexion("Select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and TIPO='NRM' AND TURNO='Nocturno' and EMPRESA='"+NomEmpresa+"' order by IDENTIFICADOR");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["IDENTIFICADOR"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["SENTIDO"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Nocturno";
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["PRECIO"].ToString();
					++contador;
				}
				conn.conexion.Close();	
				
				/*
				  * 
				conn.getAbrirConexion("Select * from FACT_HENNIEGES where tipo='NRM' AND Turno='Mañana' and cliente='"+NomEmpresa+"' order by Nombre");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["Servicio"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Mañana";
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["Costo"].ToString();
					
					++contador;
				}
				conn.conexion.Close();

				conn.getAbrirConexion("Select * from FACT_HENNIEGES where tipo='NRM' AND Turno='Medio día' and cliente='"+NomEmpresa+"' order by Nombre");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["Servicio"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Medio día";
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["Costo"].ToString();
					++contador;
				}
				conn.conexion.Close();

				conn.getAbrirConexion("Select * from FACT_HENNIEGES where tipo='NRM' AND Turno='Vespertino' and cliente='"+NomEmpresa+"' order by Nombre");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["Servicio"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Vespertino";
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["Costo"].ToString();
					++contador;
				}
				conn.conexion.Close();

				conn.getAbrirConexion("Select * from FACT_HENNIEGES where tipo='NRM' AND Turno='Nocturno' and cliente='"+NomEmpresa+"' order by Nombre");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesNormales.Rows.Add();
					dataHenniegesNormales.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[1].Value = conn.leer["Servicio"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[18].Value = conn.leer["Costo"].ToString();
					dataHenniegesNormales.Rows[contador].Cells[17].Value = "0";
					dataHenniegesNormales.Rows[contador].Cells[2].Value = "Nocturno";
					++contador;
				}
				conn.conexion.Close();	
				*/
				
				int dias = 0;
				if(NomEmpresa=="HENNIGES")
				{
					while(dateInicio.Value.AddDays(dias)<dateCorte.Value)
					{
						for(int z = 0; z<dataViajesNormales.RowCount; z++)
						{
							progresobarra(dataViajesNormales.RowCount);
							for(int y = 0; y<dataHenniegesNormales.RowCount; y++)
							{
								if(dataViajesNormales.Rows[z].Cells[1].Value.ToString()==dateInicio.Value.AddDays(dias).ToString("dd/MM/yyyy")&&(dataViajesNormales.Rows[z].Cells[4].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString()||dataViajesNormales.Rows[z].Cells[4].Value.ToString().Substring(0,3)==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString().Substring(0,3))&&dataViajesNormales.Rows[z].Cells[6].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[2].Value.ToString()&&dataViajesNormales.Rows[z].Cells[10].Value.ToString()!="HENNIGES EXTRA"&&dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()==dataViajesNormales.Rows[z].Cells[0].Value.ToString())
								{
									if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Completo")
									{
										dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
										dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
										dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
									else if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Sencillo")
									{
										if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Entrada")
										{
											dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
										else if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Salida")
										{
											dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
									}
								}
							}
						}
						++dias;
					}
				}
				else if(NomEmpresa=="VITRO" && interruptor == 0)
				{
					dias = 0;
					while(dateInicio.Value.AddDays(dias)<=dateCorte.Value)
					{
						for(int z = 0; z<dataViajesNormales.RowCount; z++)
						{
							progresobarra(dataViajesNormales.RowCount);
							for(int y = 0; y<dataHenniegesNormales.RowCount; y++)
							{
								if(dataViajesNormales.Rows[z].Cells[9].Value.ToString()!="EXT"&&dataViajesNormales.Rows[z].Cells[1].Value.ToString()==dateInicio.Value.AddDays(dias).ToString("dd/MM/yyyy")&&(dataViajesNormales.Rows[z].Cells[4].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString()||dataViajesNormales.Rows[z].Cells[4].Value.ToString().Substring(0,3)==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString().Substring(0,3))&&dataViajesNormales.Rows[z].Cells[6].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[2].Value.ToString()&&dataViajesNormales.Rows[z].Cells[10].Value.ToString()!="HENNIGES EXTRA"&&dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()==dataViajesNormales.Rows[z].Cells[0].Value.ToString())
								{
									if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Completo")
									{
										dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
										dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
										dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
									else if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Sencillo")
									{
										if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Entrada")
										{
											dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
										else if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Salida")
										{
											dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
									}
								}
							}
						}
						++dias;
					}
				}
				else if(NomEmpresa=="VITRO" && interruptor == 3)
				{
					dias = 0;
					while(dateInicio.Value.AddDays(dias)<=dateCorte.Value)
					{
						for(int z = 0; z<dataViajesNormales.RowCount; z++)
						{
							progresobarra(dataViajesNormales.RowCount);
							for(int y = 0; y<dataHenniegesNormales.RowCount; y++)
							{
								if(dataViajesNormales.Rows[z].Cells[9].Value.ToString()=="EXT"&&dataViajesNormales.Rows[z].Cells[1].Value.ToString()==dateInicio.Value.AddDays(dias).ToString("dd/MM/yyyy")&&(dataViajesNormales.Rows[z].Cells[4].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString()||dataViajesNormales.Rows[z].Cells[4].Value.ToString().Substring(0,3)==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString().Substring(0,3))&&dataViajesNormales.Rows[z].Cells[6].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[2].Value.ToString()&&dataViajesNormales.Rows[z].Cells[10].Value.ToString()!="HENNIGES EXTRA"&&dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()==dataViajesNormales.Rows[z].Cells[0].Value.ToString())
								{
									if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Completo")
									{
										dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
										dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
										dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
									else if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Sencillo")
									{
										if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Entrada")
										{
											dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
										else if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Salida")
										{
											dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
									}
								}
							}
						}
						++dias;
					}
				}
				else if(NomEmpresa=="VITRO" && interruptor == 2)
				{
					dias = 0;
					while(dateInicio.Value.AddDays(dias)<=dateCorte.Value)
					{
						for(int z = 0; z<dataViajesNormales.RowCount; z++)
						{
							progresobarra(dataViajesNormales.RowCount);
							for(int y = 0; y<dataHenniegesNormales.RowCount; y++)
							{
								if(dataViajesNormales.Rows[z].Cells[1].Value.ToString()==dateInicio.Value.AddDays(dias).ToString("dd/MM/yyyy")&&(dataViajesNormales.Rows[z].Cells[4].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString()||dataViajesNormales.Rows[z].Cells[4].Value.ToString().Substring(0,3)==dataHenniegesNormales.Rows[y].Cells[0].Value.ToString().Substring(0,3))&&dataViajesNormales.Rows[z].Cells[6].Value.ToString()==dataHenniegesNormales.Rows[y].Cells[2].Value.ToString()&&dataViajesNormales.Rows[z].Cells[10].Value.ToString()!="HENNIGES EXTRA"&&dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()==dataViajesNormales.Rows[z].Cells[0].Value.ToString()&&dataViajesNormales.Rows[z].Cells[18].Value.ToString()=="VITRO")
								{
									if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Completo")
									{
										dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
										dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
										dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
									else if(dataHenniegesNormales.Rows[y].Cells[1].Value.ToString()=="Sencillo")
									{
										if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Entrada")
										{
											dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[3+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
										else if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Salida")
										{
											dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value = Convert.ToInt32(dataHenniegesNormales.Rows[y].Cells[4+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
									}
								}
							}
						}
						++dias;
					}
				}
				else if(NomEmpresa=="VITRO" && interruptor == 1)
				{
						dias = 0;
						int cLuis = 0;
						int sLuis = 0;
						int cVitro = 0;
						int sVitro = 0;
						
						dataLuisVitro.Rows.Clear();
						datavitrovitro.Rows.Clear();
						while(dateInicio.Value.AddDays(dias)<=dateCorte.Value)
						{
							dataLuisVitro.Rows.Add();
							dataLuisVitro.Rows[dias].Cells[0].Value = dateInicio.Value.AddDays(dias).ToString().Substring(0,10);
							
							datavitrovitro.Rows.Add();
							datavitrovitro.Rows[dias].Cells[0].Value = dateInicio.Value.AddDays(dias).ToString().Substring(0,10);
							++dias;
						}
						
						for(int a=0; a<dataLuisVitro.RowCount; a++)
						{
							int CompletoLuisV = 0;
							int SencilloLuisV = 0;
							for(int x=0; x<dataViajesNormales.RowCount; x++)
							{
								if(dataViajesNormales.Rows[x].Cells[1].Value.ToString()==dataLuisVitro.Rows[a].Cells[0].Value.ToString()&&dataViajesNormales.Rows[x].Cells[18].Value.ToString()!="VITRO")
								{
									if(dataViajesNormales.Rows[x].Cells[0].Value.ToString()=="Completo")
									   {
									   	 CompletoLuisV = CompletoLuisV + 1;
									   	 cLuis = cLuis + 1;
									   	 dataLuisVitro.Rows[a].Cells[2].Value = CompletoLuisV;
									   }
									   else
									   {
									   	 sLuis = sLuis + 1;
									   	 SencilloLuisV = SencilloLuisV + 1;
									   	 dataLuisVitro.Rows[a].Cells[1].Value = SencilloLuisV;
									   }
								}
							}
						}
						
						for(int a=0; a<datavitrovitro.RowCount; a++)
						{
							int CompletoLuisV = 0;
							int SencilloLuisV = 0;
							for(int x=0; x<dataViajesNormales.RowCount; x++)
							{
								if(dataViajesNormales.Rows[x].Cells[1].Value.ToString()==datavitrovitro.Rows[a].Cells[0].Value.ToString()&&dataViajesNormales.Rows[x].Cells[18].Value.ToString()=="VITRO")
								{
									if(dataViajesNormales.Rows[x].Cells[0].Value.ToString()=="Completo")
									   {
									   	 CompletoLuisV = CompletoLuisV + 1;
									   	 cVitro = cVitro + 1;
									   	 datavitrovitro.Rows[a].Cells[2].Value = CompletoLuisV;
									   }
									   else
									   {
									   	 SencilloLuisV = SencilloLuisV + 1;
									   	 sVitro = sVitro + 1;
									   	 datavitrovitro.Rows[a].Cells[1].Value = SencilloLuisV;
									   }
								}
							}
						}
						
						txtVitroCompleto.Text = cVitro.ToString();
						txtVitroSencillo.Text = sVitro.ToString();
						txtLuisSencillo.Text = sLuis.ToString();
						txtLuisCompleto.Text = cLuis.ToString();
				}
				
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				txtViajesHenniges.Text = "0";
				txtTotalHennieges.Text = "0";
				for(int n = 0; n<dataHenniegesNormales.RowCount; n++)
				{
					for(int m = 3; m<dataHenniegesNormales.ColumnCount-3; m++)
					{
						dataHenniegesNormales.Rows[n].Cells[17].Value = (Convert.ToInt32(dataHenniegesNormales.Rows[n].Cells[17].Value)) + (Convert.ToInt32(dataHenniegesNormales.Rows[n].Cells[m].Value));
					}
					dataHenniegesNormales.Rows[n].Cells[19].Value = (Convert.ToDouble(dataHenniegesNormales.Rows[n].Cells[17].Value)) * (Convert.ToDouble(dataHenniegesNormales.Rows[n].Cells[18].Value));
					txtViajesHenniges.Text = (Convert.ToInt32(txtViajesHenniges.Text) + Convert.ToInt32(dataHenniegesNormales.Rows[n].Cells[17].Value)).ToString();
					txtTotalHennieges.Text = (Convert.ToDouble(txtTotalHennieges.Text) + Convert.ToDouble(dataHenniegesNormales.Rows[n].Cells[19].Value)).ToString();
				}
				
				for(int d = 0; d<dataHenniegesNormales.RowCount; d++)
				{	
					if(dataHenniegesNormales.Rows[d].Cells[17].Value.ToString()=="0")
					{
						dataHenniegesNormales.Rows.RemoveAt(d);
						--d;
					}
				}
		}
		
		void CalculoFacturizacionHENNIEGESExtra()
		{	
			int contador = 0;
			String ruta  = "";
			dataViajesNormales.ClearSelection();
			dataHenniegesExtras.Rows.Clear();
			dataHenniegesExtras.ClearSelection();
			
				//conn.getAbrirConexion("Select * from FACT_HENNIEGES where tipo='EXT' and cliente='"+NomEmpresa+"' order by Nombre");
				conn.getAbrirConexion("Select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and TIPO='EXT' and EMPRESA='"+NomEmpresa+"' order by IDENTIFICADOR");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesExtras.Rows.Add();
					dataHenniegesExtras.Rows[contador].Cells[0].Value = conn.leer["IDENTIFICADOR"].ToString();
					dataHenniegesExtras.Rows[contador].Cells[1].Value = conn.leer["SENTIDO"].ToString();
					dataHenniegesExtras.Rows[contador].Cells[16].Value = "0";
					dataHenniegesExtras.Rows[contador].Cells[17].Value = conn.leer["PRECIO"].ToString();
					/*
					dataHenniegesExtras.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
					dataHenniegesExtras.Rows[contador].Cells[1].Value = conn.leer["Servicio"].ToString();
					dataHenniegesExtras.Rows[contador].Cells[16].Value = "0";
					dataHenniegesExtras.Rows[contador].Cells[17].Value = conn.leer["Costo"].ToString();*/
					++contador;
				}
				conn.conexion.Close();
		
				int dias = 0;
				while(dateInicio.Value.AddDays(dias)<=dateCorte.Value)
				{
					for(int z = 0; z<dataViajesNormales.RowCount; z++)
					{
						progresobarra(dataViajesNormales.RowCount);
						if(dataViajesNormales.Rows[z].Cells[10].Value.ToString()=="HENNIGES EXTRA")
						{
							ruta = dataViajesNormales.Rows[z].Cells[4].Value.ToString();
							
							if(ruta=="TALA II")
								ruta = "TALA";
							
							if(ruta=="AMECA II")
								ruta = "AMECA";
							
							if(ruta=="CUISILLOS II")
								ruta = "CUISILLOS";
							
							if(ruta=="ETZATLAN II")
								ruta = "ETZATLAN";
							
							for(int y = 0; y<dataHenniegesExtras.RowCount; y++)
							{
								if(dataViajesNormales.Rows[z].Cells[1].Value.ToString()==dateInicio.Value.AddDays(dias).ToString("dd/MM/yyyy")&&ruta==dataHenniegesExtras.Rows[y].Cells[0].Value.ToString()&&dataHenniegesExtras.Rows[y].Cells[1].Value.ToString()==dataViajesNormales.Rows[z].Cells[0].Value.ToString())
								{
									if(dataHenniegesExtras.Rows[y].Cells[1].Value.ToString()=="Completo")
									{
										dataHenniegesExtras.Rows[y].Cells[2+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras.Rows[y].Cells[2+(dias*2)].Value) + 1;
										dataHenniegesExtras.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras.Rows[y].Cells[3+(dias*2)].Value) + 1;
										dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
									else if(dataHenniegesExtras.Rows[y].Cells[1].Value.ToString()=="Sencillo")
									{
										if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Entrada")
										{
											dataHenniegesExtras.Rows[y].Cells[2+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras.Rows[y].Cells[2+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
										else if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Salida")
										{
											dataHenniegesExtras.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras.Rows[y].Cells[3+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
									}
								}
							}
						}
					}
					++dias;
				}
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				txtViajesExtHenniges.Text = "0";
				txtTotalExtHennieges.Text = "0";
				CalculoFacturizacionHENNIEGESExtra2(dataHenniegesExtras);
				for(int n = 0; n<dataHenniegesExtras.RowCount; n++)
				{
					for(int m = 2; m<dataHenniegesExtras.ColumnCount-3; m++)
					{
						dataHenniegesExtras.Rows[n].Cells[16].Value = (Convert.ToInt32(dataHenniegesExtras.Rows[n].Cells[16].Value)) + (Convert.ToInt32(dataHenniegesExtras.Rows[n].Cells[m].Value));
					}
					dataHenniegesExtras.Rows[n].Cells[18].Value = (Convert.ToDouble(dataHenniegesExtras.Rows[n].Cells[16].Value)) * (Convert.ToDouble(dataHenniegesExtras.Rows[n].Cells[17].Value));
					txtViajesExtHenniges.Text = (Convert.ToInt32(txtViajesExtHenniges.Text) + Convert.ToInt32(dataHenniegesExtras.Rows[n].Cells[16].Value)).ToString();
					txtTotalExtHennieges.Text = (Convert.ToDouble(txtTotalExtHennieges.Text) + Convert.ToDouble(dataHenniegesExtras.Rows[n].Cells[18].Value)).ToString();
				}
				
				for(int d = 0; d<dataHenniegesExtras.RowCount; d++)
				{	
					if(dataHenniegesExtras.Rows[d].Cells[16].Value.ToString()=="0")
					{
						dataHenniegesExtras.Rows.RemoveAt(d);
						--d;
					}
				}
		}
		
		void CalculoFacturizacionHENNIEGESExtra2(DataGridView dataHenniegesExtras2)
		{	
			//int contador = 0;
			String ruta  = "";
			/*dataViajesNormales.ClearSelection();
			dataHenniegesExtras2.Rows.Clear();
			dataHenniegesExtras2.ClearSelection();
			
				conn.getAbrirConexion("Select * from FACT_HENNIEGES where tipo='EXT' order by Nombre");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHenniegesExtras2.Rows.Add();
					dataHenniegesExtras2.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
					dataHenniegesExtras2.Rows[contador].Cells[1].Value = conn.leer["Servicio"].ToString();
					dataHenniegesExtras2.Rows[contador].Cells[16].Value = "0";
					dataHenniegesExtras2.Rows[contador].Cells[17].Value = conn.leer["Costo"].ToString();
					++contador;
				}
				conn.conexion.Close();*/

				int dias = 6;
				while(dateInicio.Value.AddDays(dias)<=dateCorte.Value)
				{
					for(int z = 0; z<dataViajesNormales.RowCount; z++)
					{
						progresobarra(dataViajesNormales.RowCount);
						if(dataViajesNormales.Rows[z].Cells[10].Value.ToString()!="HENNIGES EXTRA")
						{
							ruta = dataViajesNormales.Rows[z].Cells[4].Value.ToString();
							
							if(ruta=="TALA II")
								ruta = "TALA";
							
							if(ruta=="AMECA II")
								ruta = "AMECA";
							
							if(ruta=="CUISILLOS II")
								ruta = "CUISILLOS";
							
							if(ruta=="ETZATLAN II")
								ruta = "ETZATLAN";
							
							for(int y = 0; y<dataHenniegesExtras2.RowCount; y++)
							{
								if(dataViajesNormales.Rows[z].Cells[1].Value.ToString()==dateInicio.Value.AddDays(dias).ToString("dd/MM/yyyy")&&ruta==dataHenniegesExtras2.Rows[y].Cells[0].Value.ToString()&&dataHenniegesExtras2.Rows[y].Cells[1].Value.ToString()==dataViajesNormales.Rows[z].Cells[0].Value.ToString())
								{
									if(dataHenniegesExtras2.Rows[y].Cells[1].Value.ToString()=="Completo")
									{
										dataHenniegesExtras2.Rows[y].Cells[2+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras2.Rows[y].Cells[2+(dias*2)].Value) + 1;
										dataHenniegesExtras2.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras2.Rows[y].Cells[3+(dias*2)].Value) + 1;
										dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
									else if(dataHenniegesExtras2.Rows[y].Cells[1].Value.ToString()=="Sencillo")
									{
										if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Entrada")
										{
											dataHenniegesExtras2.Rows[y].Cells[2+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras2.Rows[y].Cells[2+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
										else if(dataViajesNormales.Rows[z].Cells[5].Value.ToString()=="Salida")
										{
											dataHenniegesExtras2.Rows[y].Cells[3+(dias*2)].Value = Convert.ToInt32(dataHenniegesExtras2.Rows[y].Cells[3+(dias*2)].Value) + 1;
											dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
											break;
										}
									}
								}
							}
						}
					}
					++dias;
				}
				/*principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				txtViajesExtHenniges2.Text = "0";
				txtTotalExtHennieges2.Text = "0";
				for(int n = 0; n<dataHenniegesExtras2.RowCount; n++)
				{
					for(int m = 2; m<dataHenniegesExtras2.ColumnCount-3; m++)
					{
						dataHenniegesExtras2.Rows[n].Cells[16].Value = (Convert.ToInt32(dataHenniegesExtras2.Rows[n].Cells[16].Value)) + (Convert.ToInt32(dataHenniegesExtras2.Rows[n].Cells[m].Value));
					}
					dataHenniegesExtras2.Rows[n].Cells[18].Value = (Convert.ToDouble(dataHenniegesExtras2.Rows[n].Cells[16].Value)) * (Convert.ToDouble(dataHenniegesExtras2.Rows[n].Cells[17].Value));
					txtViajesExtHenniges2.Text = (Convert.ToInt32(txtViajesExtHenniges2.Text) + Convert.ToInt32(dataHenniegesExtras2.Rows[n].Cells[16].Value)).ToString();
					txtTotalExtHennieges2.Text = (Convert.ToDouble(txtTotalExtHennieges2.Text) + Convert.ToDouble(dataHenniegesExtras2.Rows[n].Cells[18].Value)).ToString();
				}
				
				for(int d = 0; d<dataHenniegesExtras2.RowCount; d++)
				{	
					if(dataHenniegesExtras2.Rows[d].Cells[16].Value.ToString()=="0")
					{
						dataHenniegesExtras2.Rows.RemoveAt(d);
						--d;
					}
				}*/
		}
		
		void CalculoFacturizacionHENNIEGESEspecial()
		{	
			int contador = 0;
			String ruta  = "";
			dataViajesNormales.ClearSelection();
			dataHennigesEspecial.Rows.Clear();
			dataHennigesEspecial.ClearSelection();
			
				//conn.getAbrirConexion("Select * from FACT_HENNIEGES where tipo='ESP' and cliente='"+NomEmpresa+"' ");
				conn.getAbrirConexion("Select * from FACTURA_PRECIOS where ESTATUS = 'Activo' and TIPO='ESP' and EMPRESA='"+NomEmpresa+"' ");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataHennigesEspecial.Rows.Add();
					dataHennigesEspecial.Rows[contador].Cells[0].Value = conn.leer["IDENTIFICADOR"].ToString();
					dataHennigesEspecial.Rows[contador].Cells[1].Value = "0";
					dataHennigesEspecial.Rows[contador].Cells[2].Value = conn.leer["PRECIO"].ToString();
					/*
					dataHennigesEspecial.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
					dataHennigesEspecial.Rows[contador].Cells[1].Value = "0";
					dataHennigesEspecial.Rows[contador].Cells[2].Value = conn.leer["Costo"].ToString();
					 */
					++contador;
				}
				conn.conexion.Close();

					for(int z = 0; z<dataViajesNormales.RowCount; z++)
					{
						progresobarra(dataViajesNormales.RowCount);
						ruta = dataViajesNormales.Rows[z].Cells[4].Value.ToString();
						
						for(int y = 0; y<dataHennigesEspecial.RowCount; y++)
						{
							if(ruta==dataHennigesEspecial.Rows[y].Cells[0].Value.ToString())
							{
								dataHennigesEspecial.Rows[y].Cells[1].Value = Convert.ToInt32(dataHennigesEspecial.Rows[y].Cells[1].Value) + 1;
								dataViajesNormales.Rows[z].Cells[4].Style.BackColor = Color.LightGray;
								break;
							}
						}
					}
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;	
				txtnumviajesEspeciales.Text = "0";
				txtcostoviajesEspeciales.Text = "0";
				for(int n = 0; n<dataHennigesEspecial.RowCount; n++)
				{
					dataHennigesEspecial.Rows[n].Cells[3].Value = (Convert.ToDouble(dataHennigesEspecial.Rows[n].Cells[1].Value)) * (Convert.ToDouble(dataHennigesEspecial.Rows[n].Cells[2].Value));
					txtnumviajesEspeciales.Text = (Convert.ToInt32(txtnumviajesEspeciales.Text) + Convert.ToInt32(dataHennigesEspecial.Rows[n].Cells[1].Value)).ToString();
					txtcostoviajesEspeciales.Text = (Convert.ToDouble(txtcostoviajesEspeciales.Text) + Convert.ToDouble(dataHennigesEspecial.Rows[n].Cells[3].Value)).ToString();
				}
				
				if(ckAutosize.Checked==true)
				{
					if(dataHennigesEspecial.RowCount>=0)
						dataHennigesEspecial.AutoSize = true;
				}
		}
		#endregion
		
		//JABIL
		
		#region JABIL
		void CalculoFacturizacionJABIL(DataGridView dataJabilP, int opcion, String VehiculoJabil, DataGridView dataTotalesJabil)
		{	
			int contador = 0;
			int condia = 0;
			int contador2 = 0;
			String sentencia = "";
				
			if(opcion==0)
			{
			sentencia = "Select Distinct(R.Nombre) " +
                      	"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO "+
                   		"where C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                   		"and C.Empresa='"+NomEmpresa+"' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.Nombre not like '%OF'";
			}
			else
			{
			sentencia = "Select Distinct(R.Nombre) " +
                      	"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO "+
                   		"where C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                   		"and C.Empresa='"+NomEmpresa+"' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and R.Nombre like '%OF'";
			}
			
			dataViajesNormales.ClearSelection();
			dataJabilP.Rows.Clear();
			dataJabilP.ClearSelection();
			
			while(dateInicio.Value.AddDays(condia)<=dateCorte.Value)
			{
					conn.getAbrirConexion(sentencia);
					conn.leer=conn.comando.ExecuteReader();	
					while(conn.leer.Read())
					{
						dataJabilP.Rows.Add();
						dataJabilP.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
						dataJabilP.Rows[contador].Cells[2].Value = VehiculoJabil;
						dataJabilP.Rows[contador].Cells[3].Value = "Mañana";
						dataJabilP.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
						++contador;
						dataJabilP.Rows.Add();
						dataJabilP.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
						dataJabilP.Rows[contador].Cells[2].Value = VehiculoJabil;
						dataJabilP.Rows[contador].Cells[3].Value = "Medio día";
						dataJabilP.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
						++contador;
						dataJabilP.Rows.Add();
						dataJabilP.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
						dataJabilP.Rows[contador].Cells[2].Value = VehiculoJabil;
						dataJabilP.Rows[contador].Cells[3].Value = "Vespertino";
						dataJabilP.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
						++contador;
						dataJabilP.Rows.Add();
						dataJabilP.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
						dataJabilP.Rows[contador].Cells[2].Value = VehiculoJabil;
						dataJabilP.Rows[contador].Cells[3].Value = "Nocturno";
						dataJabilP.Rows[contador].Cells[0].Value = dateInicio.Value.AddDays(condia).ToString().Substring(0,10);
						++contador;
					}
					conn.conexion.Close();
					++condia;
			}
			
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
				{
					progresobarra(dataViajesNormales.RowCount);
					for(int y = 0; y<dataJabilP.RowCount; y++)
					{						
						if( VehiculoJabil == dataViajesNormales.Rows[w].Cells[7].Value.ToString()  && dataViajesNormales.Rows[w].Cells[1].Value.ToString()==dataJabilP.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[6].Value.ToString()==dataJabilP.Rows[y].Cells[3].Value.ToString() && dataViajesNormales.Rows[w].Cells[4].Value.ToString()==dataJabilP.Rows[y].Cells[1].Value.ToString())
						{
							if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()==dataJabilP.Rows[y].Cells[2].Value.ToString())
							{
								if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
								{
									if(dataViajesNormales.Rows[w].Cells[5].Value.ToString()=="Entrada")
									{
										dataJabilP.Rows[y].Cells[6].Value = dataViajesNormales.Rows[w].Cells[13].Value.ToString();
										dataJabilP.Rows[y].Cells[7].Value = dataViajesNormales.Rows[w].Cells[14].Value.ToString();
										dataJabilP.Rows[y].Cells[4].Value = Convert.ToInt32(dataJabilP.Rows[y].Cells[4].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
									if(dataViajesNormales.Rows[w].Cells[5].Value.ToString()=="Salida")
									{
										dataJabilP.Rows[y].Cells[6].Value = dataViajesNormales.Rows[w].Cells[13].Value.ToString();
										dataJabilP.Rows[y].Cells[7].Value = dataViajesNormales.Rows[w].Cells[14].Value.ToString();
										dataJabilP.Rows[y].Cells[5].Value = Convert.ToInt32(dataJabilP.Rows[y].Cells[5].Value) + 1;
										dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
										break;
									}
								}
								else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
								{
									dataJabilP.Rows[y].Cells[6].Value = dataViajesNormales.Rows[w].Cells[13].Value.ToString();
									dataJabilP.Rows[y].Cells[7].Value = dataViajesNormales.Rows[w].Cells[14].Value.ToString();
									dataJabilP.Rows[y].Cells[5].Value = Convert.ToInt32(dataJabilP.Rows[y].Cells[5].Value) + 1;
									dataJabilP.Rows[y].Cells[4].Value = Convert.ToInt32(dataJabilP.Rows[y].Cells[4].Value) + 1;
									dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
									break;
								}
							}
						}
					}
				}
			
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				
				dataTotalesJabil.Rows.Clear();
				dataTotalesJabil.ClearSelection();
				dataTotalesJabil.Rows.Add();
				dataTotalesJabil.Rows[contador2].Cells[0].Value = "Largo Sencillo";
				
				if(opcion==0)
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilP("Sencillo", 46, 86, 0, VehiculoJabil);
				else
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilA("Sencillo", 46, 86, 0, VehiculoJabil);
				
				++contador2;
				dataTotalesJabil.Rows.Add();
				dataTotalesJabil.Rows[contador2].Cells[0].Value = "Largo Completo";
				
				if(opcion==0)
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilP("Completo", 46, 86, 0, VehiculoJabil);
				else
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilA("Completo", 46, 86, 0, VehiculoJabil);
					
				++contador2;
				dataTotalesJabil.Rows.Add();
				dataTotalesJabil.Rows[contador2].Cells[0].Value = "Corto Sencillo";
				
				if(opcion==0)
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilP("Sencillo", 0, 45, 0, VehiculoJabil);
				else
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilA("Sencillo", 0, 45, 0, VehiculoJabil);
				
				++contador2;
				dataTotalesJabil.Rows.Add();
				dataTotalesJabil.Rows[contador2].Cells[0].Value = "Corto Completo";
				
				if(opcion==0)
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilP("Completo", 0, 45, 0, VehiculoJabil);
				else
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilA("Completo", 0, 45, 0, VehiculoJabil);
					
				++contador2;
				dataTotalesJabil.Rows.Add();
				dataTotalesJabil.Rows[contador2].Cells[0].Value = "Foraneo Sencillo";
				
				if(opcion==0)
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilP("Sencillo", 0, 150, 1, VehiculoJabil);
				else
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilA("Sencillo", 0, 150, 1, VehiculoJabil);
				
				++contador2;
				dataTotalesJabil.Rows.Add();
				dataTotalesJabil.Rows[contador2].Cells[0].Value = "Foraneo Completo";
				
				if(opcion==0)
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilP("Completo", 0, 150, 1, VehiculoJabil);
				else
					dataTotalesJabil.Rows[contador2].Cells[1].Value = TraerResultadofacturaJabilA("Completo", 0, 150, 1, VehiculoJabil);
				
				for(int d = 0; d<dataJabilP.RowCount; d++)
				{	
					if(dataJabilP.Rows[d].Cells[4].Value==null&&dataJabilP.Rows[d].Cells[5].Value==null)
					{
						dataJabilP.Rows.RemoveAt(d);
						--d;
					}
				}							
		}
		
		int TraerResultadofacturaJabilP(String tipo, double km1, double km2, int foraneo, string vehiculo)
		{
			int res = 0;
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
			{	
				if( vehiculo == dataViajesNormales.Rows[w].Cells[7].Value.ToString()  && dataViajesNormales.Rows[w].Cells[0].Value.ToString()==tipo && dataViajesNormales.Rows[w].Cells[14].Value.ToString()==foraneo.ToString() && !dataViajesNormales.Rows[w].Cells[4].Value.ToString().EndsWith("OF"))
				{
				   	if(Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value)>=km1 && Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value)<km2)
						res = res + 1;
				}
			}
			return res;
		}
		

		int TraerResultadofacturaJabilA(String tipo, double km1, double km2, int foraneo, string vehiculo)
		{
			int res = 0;
			
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
			{	
				if( vehiculo == dataViajesNormales.Rows[w].Cells[7].Value.ToString() && dataViajesNormales.Rows[w].Cells[0].Value.ToString()==tipo && dataViajesNormales.Rows[w].Cells[14].Value.ToString()==foraneo.ToString() && dataViajesNormales.Rows[w].Cells[4].Value.ToString().EndsWith("OF"))
				{
				   	if(Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value)>=km1 && Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value)<km2)
						res = res + 1;
				}
			}
				
			return res;
		}
		
		private void PrecioJabil(){
			/*
			double fc = 864.00, fs = 702.00;
			double lcCamion = 943.92, lsCamion = 764.64;
			double ccCamion = 855.36, csCamion = 673.92;
			double lcCamioneta = 799.20, lsCamioneta = 652.32;
			double ccCamioneta = 730.08, csCamioneta = 573.48;*/
			
			double fc = connF.obtenerPrecioJABIL("FORANEO", "Completo", "CAMION", "SI");
			double fs = connF.obtenerPrecioJABIL("FORANEO", "Sencillo", "CAMION", "SI");
			double lcCamion = connF.obtenerPrecioJABIL("LARGA", "Completo", "CAMION", "NO");
			double lsCamion = connF.obtenerPrecioJABIL("LARGA", "Sencillo", "CAMION", "NO");
			double ccCamion = connF.obtenerPrecioJABIL("CORTA", "Completo", "CAMION", "NO"); 
			double csCamion = connF.obtenerPrecioJABIL("CORTA", "Sencillo", "CAMION", "NO");
			double lcCamioneta = connF.obtenerPrecioJABIL("LARGA", "Completo", "CAMIONETA", "NO");
			double lsCamioneta = connF.obtenerPrecioJABIL("LARGA", "Sencillo", "CAMIONETA", "NO");
			double ccCamioneta = connF.obtenerPrecioJABIL("CORTA", "Completo", "CAMIONETA", "NO");
			double csCamioneta = connF.obtenerPrecioJABIL("CORTA", "Sencillo", "CAMIONETA", "NO");
			
			//  PRODUCCION CAMIONES			
			dttotalesproduccamion.Rows[0].Cells[2].Value = lsCamion;
			dttotalesproduccamion.Rows[1].Cells[2].Value = lcCamion;
			dttotalesproduccamion.Rows[2].Cells[2].Value = csCamion;
			dttotalesproduccamion.Rows[3].Cells[2].Value = ccCamion;
			dttotalesproduccamion.Rows[4].Cells[2].Value = fs;
			dttotalesproduccamion.Rows[5].Cells[2].Value = fc;			
			dttotalesproduccamion.Rows[0].Cells[3].Value = Convert.ToInt64(dttotalesproduccamion.Rows[0].Cells[1].Value) * lsCamion;
			dttotalesproduccamion.Rows[1].Cells[3].Value = Convert.ToInt64(dttotalesproduccamion.Rows[1].Cells[1].Value) * lcCamion;
			dttotalesproduccamion.Rows[2].Cells[3].Value = Convert.ToInt64(dttotalesproduccamion.Rows[2].Cells[1].Value) * csCamion;
			dttotalesproduccamion.Rows[3].Cells[3].Value = Convert.ToInt64(dttotalesproduccamion.Rows[3].Cells[1].Value) * ccCamion;
			dttotalesproduccamion.Rows[4].Cells[3].Value = Convert.ToInt64(dttotalesproduccamion.Rows[4].Cells[1].Value) * fs;
			dttotalesproduccamion.Rows[5].Cells[3].Value = Convert.ToInt64(dttotalesproduccamion.Rows[5].Cells[1].Value) * fc;
			
			//  ADMINISTRATIVO CAMIONES
			dttotalesAdminCamion.Rows[0].Cells[2].Value = lsCamion;
			dttotalesAdminCamion.Rows[1].Cells[2].Value = lcCamion;
			dttotalesAdminCamion.Rows[2].Cells[2].Value = csCamion;
			dttotalesAdminCamion.Rows[3].Cells[2].Value = ccCamion;
			dttotalesAdminCamion.Rows[4].Cells[2].Value = fs;
			dttotalesAdminCamion.Rows[5].Cells[2].Value = fc;
			dttotalesAdminCamion.Rows[0].Cells[3].Value = Convert.ToInt64(dttotalesAdminCamion.Rows[0].Cells[1].Value) * lsCamion;
			dttotalesAdminCamion.Rows[1].Cells[3].Value = Convert.ToInt64(dttotalesAdminCamion.Rows[1].Cells[1].Value) * lcCamion;
			dttotalesAdminCamion.Rows[2].Cells[3].Value = Convert.ToInt64(dttotalesAdminCamion.Rows[2].Cells[1].Value) * csCamion;
			dttotalesAdminCamion.Rows[3].Cells[3].Value = Convert.ToInt64(dttotalesAdminCamion.Rows[3].Cells[1].Value) * ccCamion;
			dttotalesAdminCamion.Rows[4].Cells[3].Value = Convert.ToInt64(dttotalesAdminCamion.Rows[4].Cells[1].Value) * fs;
			dttotalesAdminCamion.Rows[5].Cells[3].Value = Convert.ToInt64(dttotalesAdminCamion.Rows[5].Cells[1].Value) * fc;
			
			//  PRODUCCION CAMIONETAS
			dttotalesproduccamioneta.Rows[0].Cells[2].Value = lsCamioneta;
			dttotalesproduccamioneta.Rows[1].Cells[2].Value = lcCamioneta;
			dttotalesproduccamioneta.Rows[2].Cells[2].Value = csCamioneta;
			dttotalesproduccamioneta.Rows[3].Cells[2].Value = ccCamioneta;
			dttotalesproduccamioneta.Rows[4].Cells[2].Value = fs;
			dttotalesproduccamioneta.Rows[5].Cells[2].Value = fc;
			dttotalesproduccamioneta.Rows[0].Cells[3].Value = Convert.ToInt64(dttotalesproduccamioneta.Rows[0].Cells[1].Value) * lsCamioneta;
			dttotalesproduccamioneta.Rows[1].Cells[3].Value = Convert.ToInt64(dttotalesproduccamioneta.Rows[1].Cells[1].Value) * lcCamioneta;
			dttotalesproduccamioneta.Rows[2].Cells[3].Value = Convert.ToInt64(dttotalesproduccamioneta.Rows[2].Cells[1].Value) * csCamioneta;
			dttotalesproduccamioneta.Rows[3].Cells[3].Value = Convert.ToInt64(dttotalesproduccamioneta.Rows[3].Cells[1].Value) * ccCamioneta;
			dttotalesproduccamioneta.Rows[4].Cells[3].Value = Convert.ToInt64(dttotalesproduccamioneta.Rows[4].Cells[1].Value) * fs;
			dttotalesproduccamioneta.Rows[5].Cells[3].Value = Convert.ToInt64(dttotalesproduccamioneta.Rows[5].Cells[1].Value) * fc;
			
			//  ADMINISTRATIVO CAMIONETAS
			dttotalesAdmincamioneta.Rows[0].Cells[2].Value = lsCamioneta;
			dttotalesAdmincamioneta.Rows[1].Cells[2].Value = lcCamioneta;
			dttotalesAdmincamioneta.Rows[2].Cells[2].Value = csCamioneta;
			dttotalesAdmincamioneta.Rows[3].Cells[2].Value = ccCamioneta;
			dttotalesAdmincamioneta.Rows[4].Cells[2].Value = fs;
			dttotalesAdmincamioneta.Rows[5].Cells[2].Value = fc;
			dttotalesAdmincamioneta.Rows[0].Cells[3].Value = Convert.ToInt64(dttotalesAdmincamioneta.Rows[0].Cells[1].Value) * lsCamioneta;
			dttotalesAdmincamioneta.Rows[1].Cells[3].Value = Convert.ToInt64(dttotalesAdmincamioneta.Rows[1].Cells[1].Value) * lcCamioneta;
			dttotalesAdmincamioneta.Rows[2].Cells[3].Value = Convert.ToInt64(dttotalesAdmincamioneta.Rows[2].Cells[1].Value) * csCamioneta;
			dttotalesAdmincamioneta.Rows[3].Cells[3].Value = Convert.ToInt64(dttotalesAdmincamioneta.Rows[3].Cells[1].Value) * ccCamioneta;
			dttotalesAdmincamioneta.Rows[4].Cells[3].Value = Convert.ToInt64(dttotalesAdmincamioneta.Rows[4].Cells[1].Value) * fs;
			dttotalesAdmincamioneta.Rows[5].Cells[3].Value = Convert.ToInt64(dttotalesAdmincamioneta.Rows[5].Cells[1].Value) * fc;			
		}
		#endregion
		
		//PLEXUS
		
		#region PLEXUS
		void CalculoFacturizacionPLEXUS(DataGridView dataCamionLocalPlex, DataGridView dataCamionForaneoPlex, DataGridView dataCamionetaLocalPlex,
		                                DataGridView dataCamionetaForaneoPlex, TextBox txtCamionLocal,  
		                                TextBox txtCamionForaneo, TextBox txtCamionetaLocal, TextBox txtCamionetaForaneo, bool OFPlex)
		{	
			int contador = 0;
			
			//data camion local
			dataCamionLocalPlex.Rows.Clear();
			dataCamionLocalPlex.ClearSelection();
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 40;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 700;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 40.1;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 50;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 795;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 50.1;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 850;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 70.1;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 80;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 900;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 80.1;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 100;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 1000;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 30;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 600;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 30.1;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 50;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 650;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionLocalPlex.Rows.Add();
			dataCamionLocalPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionLocalPlex.Rows[contador].Cells[1].Value = 50.1;
			dataCamionLocalPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionLocalPlex.Rows[contador].Cells[4].Value = 780;
			dataCamionLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			
			//data Camionetas locales
			contador = 0;
			dataCamionetaLocalPlex.Rows.Clear();
			dataCamionetaLocalPlex.ClearSelection();
			
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 40;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 600;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 40.1;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 50;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 680;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 50.1;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 750;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 70.1;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 80;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 800;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 80.1;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 100;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 900;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 30;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 480;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 30.1;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 50;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 550;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaLocalPlex.Rows.Add();
			dataCamionetaLocalPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionetaLocalPlex.Rows[contador].Cells[1].Value = 50.1;
			dataCamionetaLocalPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionetaLocalPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaLocalPlex.Rows[contador].Cells[4].Value = 650;
			dataCamionetaLocalPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			
			//data camion foraneo
			contador = 0;
			dataCamionForaneoPlex.Rows.Clear();
			dataCamionForaneoPlex.ClearSelection();
			
			dataCamionForaneoPlex.Rows.Add();
			dataCamionForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionForaneoPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[2].Value = 40;
			dataCamionForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[4].Value = 850;
			dataCamionForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionForaneoPlex.Rows.Add();
			dataCamionForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionForaneoPlex.Rows[contador].Cells[1].Value = 40.1;
			dataCamionForaneoPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[4].Value = 950;
			dataCamionForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionForaneoPlex.Rows.Add();
			dataCamionForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionForaneoPlex.Rows[contador].Cells[1].Value = 70.1;
			dataCamionForaneoPlex.Rows[contador].Cells[2].Value = 100;
			dataCamionForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[4].Value = 1100;
			dataCamionForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionForaneoPlex.Rows.Add();
			dataCamionForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionForaneoPlex.Rows[contador].Cells[1].Value = 100.1;
			dataCamionForaneoPlex.Rows[contador].Cells[2].Value = 170;
			dataCamionForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[4].Value = 1300;
			dataCamionForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
						
			dataCamionForaneoPlex.Rows.Add();
			dataCamionForaneoPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionForaneoPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[2].Value = 40;
			dataCamionForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[4].Value = 700;
			dataCamionForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionForaneoPlex.Rows.Add();
			dataCamionForaneoPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionForaneoPlex.Rows[contador].Cells[1].Value = 40.1;
			dataCamionForaneoPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionForaneoPlex.Rows[contador].Cells[4].Value = 800;
			dataCamionForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			
			//data camioneta foraneo
			contador = 0;
			dataCamionetaForaneoPlex.Rows.Clear();
			dataCamionetaForaneoPlex.ClearSelection();
			
			dataCamionetaForaneoPlex.Rows.Add();
			dataCamionetaForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaForaneoPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[2].Value = 40;
			dataCamionetaForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[4].Value = 720;
			dataCamionetaForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaForaneoPlex.Rows.Add();
			dataCamionetaForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaForaneoPlex.Rows[contador].Cells[1].Value = 40.1;
			dataCamionetaForaneoPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionetaForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[4].Value = 800;
			dataCamionetaForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaForaneoPlex.Rows.Add();
			dataCamionetaForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaForaneoPlex.Rows[contador].Cells[1].Value = 70.1;
			dataCamionetaForaneoPlex.Rows[contador].Cells[2].Value = 100;
			dataCamionetaForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[4].Value = 900;
			dataCamionetaForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaForaneoPlex.Rows.Add();
			dataCamionetaForaneoPlex.Rows[contador].Cells[0].Value = "Completo";
			dataCamionetaForaneoPlex.Rows[contador].Cells[1].Value = 100.1;
			dataCamionetaForaneoPlex.Rows[contador].Cells[2].Value = 170;
			dataCamionetaForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[4].Value = 1000;
			dataCamionetaForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
						
			dataCamionetaForaneoPlex.Rows.Add();
			dataCamionetaForaneoPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionetaForaneoPlex.Rows[contador].Cells[1].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[2].Value = 40;
			dataCamionetaForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[4].Value = 680;
			dataCamionetaForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			dataCamionetaForaneoPlex.Rows.Add();
			dataCamionetaForaneoPlex.Rows[contador].Cells[0].Value = "Sencillo";
			dataCamionetaForaneoPlex.Rows[contador].Cells[1].Value = 40.1;
			dataCamionetaForaneoPlex.Rows[contador].Cells[2].Value = 70;
			dataCamionetaForaneoPlex.Rows[contador].Cells[3].Value = 0;
			dataCamionetaForaneoPlex.Rows[contador].Cells[4].Value = 730;
			dataCamionetaForaneoPlex.Rows[contador].Cells[5].Value = 0;
			++contador;
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
				{
					progresobarra(dataViajesNormales.RowCount);
					for(int y = 0; y<dataCamionLocalPlex.RowCount; y++)
					{						
						if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()==dataCamionLocalPlex.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMION"&&dataViajesNormales.Rows[w].Cells[14].Value.ToString()=="0"&&OFPlex==dataViajesNormales.Rows[w].Cells[4].Value.ToString().Contains("OF"))
						{
							if(((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))>=(Convert.ToDouble(dataCamionLocalPlex.Rows[y].Cells[1].Value)))&&((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))<=(Convert.ToDouble(dataCamionLocalPlex.Rows[y].Cells[2].Value))))
							{
								dataCamionLocalPlex.Rows[y].Cells[3].Value = (Convert.ToDouble(dataCamionLocalPlex.Rows[y].Cells[3].Value)) + 1;
								dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
								dataViajesNormales.Rows[w].Cells[15].Value = dataCamionLocalPlex.Rows[y].Cells[4].Value;
								break;
							}
						}
					}
					for(int y = 0; y<dataCamionetaLocalPlex.RowCount; y++)
					{						
						if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()==dataCamionetaLocalPlex.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA"&&dataViajesNormales.Rows[w].Cells[14].Value.ToString()=="0"&&OFPlex==dataViajesNormales.Rows[w].Cells[4].Value.ToString().Contains("OF"))
						{
							if(((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))>=(Convert.ToDouble(dataCamionetaLocalPlex.Rows[y].Cells[1].Value)))&&((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))<=(Convert.ToDouble(dataCamionetaLocalPlex.Rows[y].Cells[2].Value))))
							{
								dataCamionetaLocalPlex.Rows[y].Cells[3].Value = (Convert.ToDouble(dataCamionetaLocalPlex.Rows[y].Cells[3].Value)) + 1;
								dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
								dataViajesNormales.Rows[w].Cells[15].Value = dataCamionetaLocalPlex.Rows[y].Cells[4].Value;
								break;
							}
						}
					}
					for(int y = 0; y<dataCamionForaneoPlex.RowCount; y++)
					{						
						if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()==dataCamionForaneoPlex.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMION"&&dataViajesNormales.Rows[w].Cells[14].Value.ToString()=="1"&&OFPlex==dataViajesNormales.Rows[w].Cells[4].Value.ToString().Contains("OF"))
						{
							if(((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))>=(Convert.ToDouble(dataCamionForaneoPlex.Rows[y].Cells[1].Value)))&&((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))<=(Convert.ToDouble(dataCamionForaneoPlex.Rows[y].Cells[2].Value))))
							{
								dataCamionForaneoPlex.Rows[y].Cells[3].Value = (Convert.ToDouble(dataCamionForaneoPlex.Rows[y].Cells[3].Value)) + 1;
								dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
								dataViajesNormales.Rows[w].Cells[15].Value = dataCamionForaneoPlex.Rows[y].Cells[4].Value;
								break;
							}
						}
					}
					for(int y = 0; y<dataCamionetaForaneoPlex.RowCount; y++)
					{						
						if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()==dataCamionetaForaneoPlex.Rows[y].Cells[0].Value.ToString()&&dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA"&&dataViajesNormales.Rows[w].Cells[14].Value.ToString()=="1"&&OFPlex==dataViajesNormales.Rows[w].Cells[4].Value.ToString().Contains("OF"))
						{
							if(((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))>=(Convert.ToDouble(dataCamionetaForaneoPlex.Rows[y].Cells[1].Value)))&&((Convert.ToDouble(dataViajesNormales.Rows[w].Cells[13].Value))<=(Convert.ToDouble(dataCamionetaForaneoPlex.Rows[y].Cells[2].Value))))
							{
								dataCamionetaForaneoPlex.Rows[y].Cells[3].Value = (Convert.ToDouble(dataCamionetaForaneoPlex.Rows[y].Cells[3].Value)) + 1;
								dataViajesNormales.Rows[w].Cells[4].Style.BackColor = Color.LightGray;
								dataViajesNormales.Rows[w].Cells[15].Value = dataCamionetaForaneoPlex.Rows[y].Cells[4].Value;
								break;
							}
						}
					}
				}
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;
				txtCamionLocal.Text = "0.0";
				txtCamionetaLocal.Text = "0.0";
				txtCamionForaneo.Text = "0.0";
				txtCamionetaForaneo.Text = "0.0";
			
				for(int y = 0; y<dataCamionLocalPlex.RowCount; y++)	
					dataCamionLocalPlex.Rows[y].Cells[5].Value = (Convert.ToDouble(dataCamionLocalPlex.Rows[y].Cells[3].Value)) * (Convert.ToDouble(dataCamionLocalPlex.Rows[y].Cells[4].Value));
				
				for(int y = 0; y<dataCamionetaLocalPlex.RowCount; y++)
					dataCamionetaLocalPlex.Rows[y].Cells[5].Value = (Convert.ToDouble(dataCamionetaLocalPlex.Rows[y].Cells[3].Value)) * (Convert.ToDouble(dataCamionetaLocalPlex.Rows[y].Cells[4].Value));
				
				for(int y = 0; y<dataCamionForaneoPlex.RowCount; y++)		
					dataCamionForaneoPlex.Rows[y].Cells[5].Value = (Convert.ToDouble(dataCamionForaneoPlex.Rows[y].Cells[3].Value)) * (Convert.ToDouble(dataCamionForaneoPlex.Rows[y].Cells[4].Value));
			
				for(int y = 0; y<dataCamionetaForaneoPlex.RowCount; y++)			
					dataCamionetaForaneoPlex.Rows[y].Cells[5].Value = (Convert.ToDouble(dataCamionetaForaneoPlex.Rows[y].Cells[3].Value)) * (Convert.ToDouble(dataCamionetaForaneoPlex.Rows[y].Cells[4].Value));
				
				for(int y = 0; y<dataCamionLocalPlex.RowCount; y++)	
					txtCamionLocal.Text = (Convert.ToDouble(txtCamionLocal.Text) + Convert.ToDouble(dataCamionLocalPlex.Rows[y].Cells[5].Value)).ToString();
				
				for(int y = 0; y<dataCamionetaLocalPlex.RowCount; y++)
					txtCamionetaLocal.Text = (Convert.ToDouble(txtCamionetaLocal.Text) + Convert.ToDouble(dataCamionetaLocalPlex.Rows[y].Cells[5].Value)).ToString();
				
				for(int y = 0; y<dataCamionForaneoPlex.RowCount; y++)		
					txtCamionForaneo.Text = (Convert.ToDouble(txtCamionForaneo.Text) + Convert.ToDouble(dataCamionForaneoPlex.Rows[y].Cells[5].Value)).ToString();
			
				for(int y = 0; y<dataCamionetaForaneoPlex.RowCount; y++)			
					txtCamionetaForaneo.Text = (Convert.ToDouble(txtCamionetaForaneo.Text) + Convert.ToDouble(dataCamionetaForaneoPlex.Rows[y].Cells[5].Value)).ToString();
		}
		
		void detalledtPlexus(DataGridView dtdetalleplex, int opcion)
		{
			int contador = 0;
			String sentencia = "";
			if(opcion==1)
			{
					sentencia = "select R.Nombre, Oe.Nombre as Vehiculo, R.Kilometros, R.foranea " +
                                "from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, Orden_empresas Oe "+
                                "where O.Estatus='1' and C.ID=R.IdSubEmpresa and O.id_ruta=R.ID and " +
                                "O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID " +
                                "AND O.fecha between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' " +
                                "and C.Empresa='PLEXUS' and R.FACTURA!='1' and R.Nombre not like '%OF%' " +
                                "group by R.Nombre, Oe.Nombre, R.Kilometros, R.foranea " +
                                "order by Oe.Nombre, Kilometros, Nombre ";
			}
			if(opcion==0)
			{
					sentencia = "select R.Nombre, Oe.Nombre as Vehiculo, R.Kilometros, R.foranea " +
                                "from OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, Orden_empresas Oe "+
                                "where O.Estatus='1' and C.ID=R.IdSubEmpresa and O.id_ruta=R.ID and " +
                                "O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and C.ID_ORDEN=Oe.ID " +
                                "AND O.fecha between '"+dateInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dateCorte.Value.ToString("yyyy-MM-dd")+"' " +
                                "and C.Empresa='PLEXUS' and R.FACTURA!='1' and R.Nombre like '%OF%' " +
                                "group by R.Nombre, Oe.Nombre, R.Kilometros, R.foranea " +
                                "order by Oe.Nombre, Kilometros, Nombre ";
			}
			dtdetalleplex.Rows.Clear();
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtdetalleplex.Rows.Add();
				dtdetalleplex.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
				dtdetalleplex.Rows[contador].Cells[1].Value = "Sencillo";
				
				if(conn.leer["Vehiculo"].ToString().Contains("CAMIONETAS")==true)
					dtdetalleplex.Rows[contador].Cells[2].Value = "CAMIONETA";
				else
					dtdetalleplex.Rows[contador].Cells[2].Value = "CAMION";
				
				if(conn.leer["foranea"].ToString()=="1")
					dtdetalleplex.Rows[contador].Cells[3].Value = "Foranea";
				else
					dtdetalleplex.Rows[contador].Cells[3].Value = "Local";
				
				dtdetalleplex.Rows[contador].Cells[4].Value = conn.leer["Kilometros"].ToString();
				dtdetalleplex.Rows[contador].Cells[5].Value = "0";
				++contador;
				dtdetalleplex.Rows.Add();
				dtdetalleplex.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
				dtdetalleplex.Rows[contador].Cells[1].Value = "Completo";
				
				if(conn.leer["Vehiculo"].ToString().Contains("CAMIONETAS")==true)
					dtdetalleplex.Rows[contador].Cells[2].Value = "CAMIONETA";
				else
					dtdetalleplex.Rows[contador].Cells[2].Value = "CAMION";
					
				
				if(conn.leer["foranea"].ToString()=="1")
					dtdetalleplex.Rows[contador].Cells[3].Value = "Foranea";
				else
					dtdetalleplex.Rows[contador].Cells[3].Value = "Local";
				
				dtdetalleplex.Rows[contador].Cells[4].Value = conn.leer["Kilometros"].ToString();
				dtdetalleplex.Rows[contador].Cells[5].Value = "0";
				++contador;
			}
			conn.conexion.Close();
			
			for(int y = 0; y<dtdetalleplex.RowCount; y++)
			{
				for(int z = 0; z<dataViajesNormales.RowCount; z++)
				{
					if(dtdetalleplex.Rows[y].Cells[4].Value.ToString()==dataViajesNormales.Rows[z].Cells[13].Value.ToString()&&dtdetalleplex.Rows[y].Cells[2].Value.ToString()==dataViajesNormales.Rows[z].Cells[7].Value.ToString()&&dtdetalleplex.Rows[y].Cells[1].Value.ToString()==dataViajesNormales.Rows[z].Cells[0].Value.ToString()&&dtdetalleplex.Rows[y].Cells[0].Value.ToString()==dataViajesNormales.Rows[z].Cells[4].Value.ToString())
						dtdetalleplex.Rows[y].Cells[5].Value = (Convert.ToInt32(dtdetalleplex.Rows[y].Cells[5].Value)) + 1;
					
					if(dataViajesNormales.Rows[z].Cells[4].Value.ToString().Contains("OF"))
						dataViajesNormales.Rows[z].Cells[10].Value = "OFICINAS";
					else
						dataViajesNormales.Rows[z].Cells[10].Value = "PRODUCCION";
				}
			}
			
			for(int y = 0; y<dtdetalleplex.RowCount; y++)
			{
				if(dtdetalleplex.Rows[y].Cells[5].Value.ToString()=="0")
				{
					dtdetalleplex.Rows.RemoveAt(y);
					--y;
				}
			}
			if(ckAutosize.Checked==true)
				{
					if(dtdetalleplex.RowCount>=0)
							dtdetalleplex.AutoSize = true;
				}
		}
		
		#endregion
		
		//CONVER
		
		#region PROCESO CONVER
		void CalculoFacturizacionCONVER()
		{	
			int contador = 0;
			String sentencia = "";
				
			sentencia = "Select Distinct(R.Nombre) " +
                      	"from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO "+
                   		"where C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                   		"and C.Empresa='"+NomEmpresa+"' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"'";
			
			dataViajesNormales.ClearSelection();
			dataCONVER.Rows.Clear();
			dataCONVER.ClearSelection();
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();	
			while(conn.leer.Read())
			{
				dataCONVER.Rows.Add();
				dataCONVER.Rows[contador].Cells[0].Value = conn.leer["Nombre"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
				{
					progresobarra(dataViajesNormales.RowCount);
					for(int y = 0; y<dataCONVER.RowCount; y++)
					{
						if(dataViajesNormales.Rows[w].Cells[4].Value.ToString()==dataCONVER.Rows[y].Cells[0].Value.ToString())
						{
							if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMION")
							{
								if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
								{
									dataCONVER.Rows[y].Cells[4].Value = Convert.ToInt32(dataCONVER.Rows[y].Cells[4].Value) + 1;
									break;
								}
								else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
								{
									dataCONVER.Rows[y].Cells[3].Value = Convert.ToInt32(dataCONVER.Rows[y].Cells[3].Value) + 1;
									break;
								}
							}
							else if(dataViajesNormales.Rows[w].Cells[7].Value.ToString()=="CAMIONETA")
							{
								if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Sencillo")
								{
									dataCONVER.Rows[y].Cells[2].Value = Convert.ToInt32(dataCONVER.Rows[y].Cells[2].Value) + 1;
									break;
								}
								else if(dataViajesNormales.Rows[w].Cells[0].Value.ToString()=="Completo")
								{
									dataCONVER.Rows[y].Cells[1].Value = Convert.ToInt32(dataCONVER.Rows[y].Cells[1].Value) + 1;
									break;
								}
							}
						}
					}
				}
			
				principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;							
		}
		#endregion
	
		#region OCULTAR TAB
		void Ocultartab()
		{
//			tabCoreyForsac.Parent = null;
//			tabHennieges.Parent = null;
//			tabJabil.Parent = null;
//			tabFarmacias.Parent = null;
//			tabRimsa.Parent = null;
//			tabNormales.Parent = null;
//			tabPlexus.Parent = null;
//			tabConver.Parent = null;
		}
		#endregion
		
		#region MOSTRAR TAB
		void Mostrartab()
		{
			Ocultartab();
			if(lblEmpresa.Text!="CONVER" && lblEmpresa.Text!="JABIL" && lblEmpresa.Text!="COREY CAMIONES" && lblEmpresa.Text!="COREY CAMIONETAS" && lblEmpresa.Text!="RIMSA" && lblEmpresa.Text!="RIMSA VANILLA" && lblEmpresa.Text!="FARMACIAS GUADALAJARA" && lblEmpresa.Text!="FARMACIAS GUADALAJARA EXTRA" && lblEmpresa.Text!="HENNIGES" && lblEmpresa.Text!="PLEXUS" && lblEmpresa.Text!="VITRO" && lblEmpresa.Text!="FORSAC")
			{
				tabNormales.Parent = tabEmpresas;
				if(lblEmpresa.Text == "TEVA"){
					dataTotales.Columns["Almacen"].Visible = true;
					dataTotales.Columns["PrecioA"].Visible = true;
				}
				else {
					dataTotales.Columns["Almacen"].Visible = false;
					dataTotales.Columns["PrecioA"].Visible = false;
				}
				pTotales.Visible = true;
				if(ckAutosize.Checked==true)
				{
					dataTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataViajesEstandarExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataTotales.AutoSize=true;
				}
			}
			else if(lblEmpresa.Text=="FARMACIAS GUADALAJARA")
			{
				pTotales.Visible = true;
				tabFarmacias.Parent = tabEmpresas;
				if(ckAutosize.Checked==true)
				{
					dataFarmaciasNormales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					if(dataFarmaciasNormales.RowCount>=0)
						dataFarmaciasNormales.AutoSize=true;
				}
			}
			else if(lblEmpresa.Text=="FARMACIAS GUADALAJARA EXTRA")
			{
				pTotales.Visible = true;
				tabFarmacias.Parent = tabEmpresas;
				if(ckAutosize.Checked==true)
				{
					dataFarmaciasExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataDesgloseFar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					if(dataFarmaciasExtras.RowCount>=0)
						dataFarmaciasExtras.AutoSize=true;
					if(dataDesgloseFar.RowCount>=0)
						dataDesgloseFar.AutoSize=true;
				}
				
			} 			
			else if(lblEmpresa.Text=="COREY CAMIONES" || lblEmpresa.Text=="COREY CAMIONETAS" ||lblEmpresa.Text=="FORSAC")
			{
				tabCoreyForsac.Parent = tabEmpresas;				
				if(dataViajesExtrasCorey.RowCount<=0)
				{
					dataViajesExtrasCorey.Visible = false;
					lblExtrasCorey.Visible = false;
				}
				else
				{
					dataViajesExtrasCorey.Visible = true;
					lblExtrasCorey.Visible = true;
				}
				if(ckAutosize.Checked==true)
				{
					dataViajesExtrasCorey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataCorey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					if(dataCorey.RowCount>=0)
					dataCorey.AutoSize = true;
				}
			}/*
			else if(lblEmpresa.Text=="FORSAC")
			{
				tabForsac.Parent = tabEmpresas;				
				if(dataViajesExtrasForsac.RowCount<=0)
				{
					dataViajesExtrasForsac.Visible = false;
					lblExtrasForsac.Visible = false;
				}
				else
				{
					dataViajesExtrasForsac.Visible = true;
					lblExtrasForsac.Visible = true;
				}
				if(ckAutosize.Checked==true)
				{
					dataViajesExtrasForsac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataForsac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					if(dataForsac.RowCount>=0)
					dataForsac.AutoSize = true;
				}
			}*/
			else if(lblEmpresa.Text=="RIMSA" || lblEmpresa.Text=="RIMSA VANILLA")
			{
				tabRimsa.Parent = tabEmpresas;
				pTotales.Visible = false;
				if(ckAutosize.Checked==true)
				{
					dataRimsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataViajesExtrasRimsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataLuisNormales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataChuyNormales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataLuisAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataChuyAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataDatoLuis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataDatoChuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataDatoLuisAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataDatoChuyAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					
					if(dataDatoChuy.RowCount>=0)
						dataDatoChuy.AutoSize=true;
					if(dataDatoLuis.RowCount>=0)
						dataDatoLuis.AutoSize=true;
					if(dataDatoChuyAlmacen.RowCount>=0)
						dataDatoChuyAlmacen.AutoSize=true;
					if(dataDatoLuisAlmacen.RowCount>=0)
						dataDatoLuisAlmacen.AutoSize=true;
					if(dataRimsa.RowCount>0)
						dataRimsa.AutoSize=true;
					if(dataLuisNormales.RowCount>=0)
						dataLuisNormales.AutoSize=true;
					if(dataChuyNormales.RowCount>=0)
						dataChuyNormales.AutoSize=true;
					if(dataChuyAlmacen.RowCount>=0)
						dataChuyAlmacen.AutoSize=true;
					if(dataLuisAlmacen.RowCount>=0)
						dataLuisAlmacen.AutoSize=true;
				}
			}
			else if(lblEmpresa.Text=="HENNIGES" || lblEmpresa.Text=="VITRO")
			{
				tabHennieges.Parent = tabEmpresas;
				pTotales.Visible = false;
				if(ckAutosize.Checked==true)
				{
					dataHenniegesNormales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataHenniegesExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataHenniegesExtras2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataHennigesEspecial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					
					if(dataHenniegesNormales.RowCount>=0)
						dataHenniegesNormales.AutoSize = true;
					if(dataHenniegesExtras.RowCount>=0)
						dataHenniegesExtras.AutoSize = true;
					if(dataHenniegesExtras2.RowCount>=0)
						dataHenniegesExtras2.AutoSize = true;
					if(dataHennigesEspecial.RowCount>=0)
						dataHennigesEspecial.AutoSize = true;
					if(dataLuisVitro.RowCount>=0)
						dataLuisVitro.AutoSize = true;
					if(datavitrovitro.RowCount>=0)
						datavitrovitro.AutoSize = true;
				}
			}
			else if(lblEmpresa.Text=="JABIL")
			{
				tabJabil.Parent = tabEmpresas;
				if(ckAutosize.Checked==true)
				{
					dataJabilA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataJabilA2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataJabilP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataJabilP2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dttotalesAdminCamion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dttotalesproduccamion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dttotalesAdmincamioneta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dttotalesproduccamioneta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					
					if(dataJabilP.RowCount>=0)
						dataJabilP.AutoSize = true;
					if(dataJabilA.RowCount>=0)
						dataJabilA.AutoSize = true;
					if(dataJabilP2.RowCount>=0)
						dataJabilP2.AutoSize = true;
					if(dataJabilA2.RowCount>=0)
						dataJabilA2.AutoSize = true;
					dttotalesproduccamion.AutoSize = true;
					dttotalesAdminCamion.AutoSize = true;
					dttotalesproduccamioneta.AutoSize = true;
					dttotalesAdmincamioneta.AutoSize = true;
					
				}
			}
			else if(lblEmpresa.Text=="PLEXUS")
			{
				tabPlexus.Parent = tabEmpresas;
				if(ckAutosize.Checked==true)
				{
					dataCamionLocalPlex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataCamionForaneoPlex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataCamionetaLocalPlex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataCamionetaForaneoPlex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					if(dataCamionLocalPlex.RowCount>=0)
						dataCamionLocalPlex.AutoSize = true;
					if(dataCamionetaLocalPlex.RowCount>=0)
						dataCamionetaLocalPlex.AutoSize = true;
					if(dataCamionForaneoPlex.RowCount>=0)
						dataCamionForaneoPlex.AutoSize = true;
					if(dataCamionetaForaneoPlex.RowCount>=0)
						dataCamionetaForaneoPlex.AutoSize = true;
					if(dataCamionLocalPlexOF.RowCount>=0)
						dataCamionLocalPlexOF.AutoSize = true;
					if(dataCamionetaLocalPlexOF.RowCount>=0)
						dataCamionetaLocalPlexOF.AutoSize = true;
					if(dataCamionForaneaPlexOF.RowCount>=0)
						dataCamionForaneaPlexOF.AutoSize = true;
					if(dataCamionetaForaneaPlexOF.RowCount>=0)
						dataCamionetaForaneaPlexOF.AutoSize = true;
				}
			}
			else if(lblEmpresa.Text=="CONVER")
			{
				tabNormales.Parent = tabEmpresas;
				pTotales.Visible = true;
				tabConver.Parent = tabEmpresas;
				if(ckAutosize.Checked==true)
				{
					dataTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataViajesEstandarExtras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					dataTotales.AutoSize=true;
					dataCONVER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
					if(dataCONVER.RowCount>=0)
						dataCONVER.AutoSize = true;
				}
			}
		}
		#endregion
		
		#region VALIDADOR FACTURAS
		void MensajeValidador()
		{
			
			String mensaje = "Hay rutas que no están en la factura";
			bool blanco = false;
		
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
			{
				if(dataViajesNormales.Rows[w].Cells[4].Style.BackColor.Name!="LightGray")
				{
					mensaje = mensaje + "\n *"+dataViajesNormales.Rows[w].Cells[4].Value.ToString();
					blanco = true;
				}
			}
			 
			String mensaje2 = "Hay rutas sin kilometraje ";
			bool blanco2 = false;
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
			{
				if(dataViajesNormales.Rows[w].Cells[13].Style.BackColor.Name=="Red")
				{
					mensaje2 = mensaje2 + "\n *"+dataViajesNormales.Rows[w].Cells[4].Value.ToString();
					blanco2 = true;
				}
			}
			
			if(blanco==true)
				MessageBox.Show(mensaje, "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			if(blanco2==true)
				MessageBox.Show(mensaje2, "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			
			///////////////////////////////////////// VALIDACION PRECIOS ////////////////////////////////////////
			String mensaje3 = "Hay rutas sin PRECIOS";
			bool blanco3 = false;
			for(int w = 0; w<dataViajesNormales.RowCount; w++)
			{
				if(dataViajesNormales.Rows[w].Cells[19].Style.BackColor.Name=="Red")
				{
					mensaje3 = mensaje3 + "\n *"+dataViajesNormales.Rows[w].Cells[4].Value.ToString();
					blanco3 = true;
				}
			}
			if(blanco3 == true)
				MessageBox.Show(mensaje3, "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			/////////////////////////////////////////////////////////////////////////////////////////////////////
						
			if(blanco==false&&blanco2==false&&blanco3==false)
				ImprimirPDF();
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
		
		#region INDEX COLUMN
		void DataViajesNormalesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show(""+e.ColumnIndex);
		}
		#endregion
		
		#region BOTONES
		void BtnExcelClick(object sender, EventArgs e)
		{
			Excels.ReportePlexus(dataViajesNormales, NomEmpresa);
		}
		#endregion
		
		#region AUTO_SIZE
		void CkAutosizeCheckedChanged(object sender, EventArgs e)
		{
			if(ckAutosize.Checked==true)
				dtEmpresa.Columns[2].Visible=true;
			else
				dtEmpresa.Columns[2].Visible=false;
		}
		#endregion
		
		void Panel6Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void DataCoreyCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void DtEmpresaCellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if(e.RowIndex>-1 && dtEmpresa.RowCount>1)
			{
				if(e.ColumnIndex>=0 && e.ColumnIndex<=2){
					if (dtEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("FORSAC")) {
						label4.Text = "Galerias Ctas S";
						label5.Text = "Tabachines Ctas S";
					}
					else {
						label4.Text = "Camionetas Completas";
						label5.Text = "Camionetas Sencillas";
					}
				}
			}
		}
	}
}

