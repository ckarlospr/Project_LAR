using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
	
namespace Transportes_LAR.Interfaz.Nomina
{
	public partial class FormNomina : Form
	{
		#region INSTANCIAS		
		private Conexion_Servidor.Nomina.SQL_Nomina connN = new Conexion_Servidor.Nomina.SQL_Nomina();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Proceso.PDF PDFs = new Transportes_LAR.Proceso.PDF();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
		private Interfaz.Nomina.FormImpuestos formimpuestos= null;
		private Interfaz.Nomina.Recibo.FormRecibo Recibo = null;
		private Interfaz.Nomina.FormOperadorExterno OperadorExterno = null;
		Interfaz.FormPrincipal principal = null;
		public static String User;
		public List<Interfaz.Nomina.Dato.Nomina> listNomina = null;
		public List<Interfaz.Nomina.Dato.ViajeEmpresarial> listViajesEmpresariales = null;
		public Interfaz.Nomina.FormEfectivoCheque formefectivocheque = null;
		#endregion
		
		#region VARIABLES
		public String ShortFecha = "";
		String Alias;
		String Nombre="";
		String FechaInicio;
		String FechaCorte;
		String Unidad="";
		String NameEmpresa = "";
		String idusuario = "";
		String BonoOperador = "0";
		String BonoOperadorEx = "0";
		String BonoOperadorEs = "0";
		String BonoBonificacion = "0";
		String ApoyoCoordinacion = "0";
		String DiaNomina1 = "";
		String DiaNomina2 = "";
		String Fechecarpeta = "";
		String ActivoDoctor = "";
		String Ingreso = "";
		String Celular = "";
		String Estatal = "";
		String Federal = "";
		String Nomb = "";
		String Ape = "";
		String VigEstatal = "";
		String VigFederal = "";
		String foraneo="";
		String tipoUnidad = "";
		int ContadorV = 0;
		int ContadorG = 0;
		int ContadorGNull = 0;
		int ContadorVE = 0;
		int contadorEmpresas=0;
		int contadorCompletos = 0;
		int contadorSencillos = 0;
		int IdOperador = 0;
		long IdNom = 0;
		int AcumuladorViajes = 0;
		int AcumuladorSencillos = 0;
		int AcumuladorCompletos = 0;
		int AcumuladorBonos = 0;
		int Reconocimientos = 0;
		int Cancelaciones = 0;
		int x = 0;
		int viajesapoyos=0;
		int AcumuladorTaller = 0;
		int AcumuladorDormida = 0;
		int AcumuladorPermiso = 0;
		int contadorPRendimiento=0;
		int DiasTrabajados = 0;
		String id_descuento = "0";
		public int cuenta = 0;
		public int cuentaLocal = 0;
		public int cuentaForaneo = 0;
		public double SueldoLocal = 0.0;
		public double SueldoForaneo = 0.0;
		double sueldoViajesG = 0;
		double infonavit= 0.0;
		double telcel= 0.0;
		double total= 0.0;
		double subtotal= 0.0;
		double extra1= 0.0;
		double anticipos= 0.0;
		double isr= 0.0;
		double imss= 0.0;
		double bonos= 0.0;
		double impuestos = 0.0;
		double totalViajes = 0.0;
		double valorBono = 0.0;
		double valorBonoEx = 0.0;
		double valorBonoEs = 0.0;
		double PorcentajeBono = 0.0;
		double valorBonoApoyoCoord = 0.0;
		double sueldoViajes = 0.0;
		double sueldoViajesE = 0.0;
		double sueldoRecono = 0.0;
		double sueldoCanc = 0.0;
		double sueldoPRendimiento = 0.0;
		double sumapoyos=0.0;
		double contadorDineroEmpresas=0.0;
		public double subtotalviajesneto = 0.0;
		double precioBonoNormal = 0.0;
		double precioBonoExtra = 0.0;
		double precioBonoEspecial = 0.0;
		double totalBonos = 0.0;
		double totalpercepciones = 0.0;
		double DescuentoPeriodo = 0.0;
		double DescuentoPrestamo = 0.0;
		double totalIngresos = 0.0;
		double Tickets = 0.0;
		double prestamoRestante = 0.0;
		double pagare =0.0;
		double aguinaldo = 0.0;
		double retener = 0.0;
		double aguinaldoneto = 0.0;
		double primavacacional = 0.0;
		public bool prestamos = false;
		int [] ArraySencillo = new int[1000];
		int [] ArrayCompleto = new int[1000];
		int [] ArrayNumero = new int[1000];
		double [] ArrayDinero = new double[1000];
		String [] ArrayEmpresa = new String[1000];
		System.IO.MemoryStream ms = null;
		DateTime fechaaviso;
		#endregion
		
		#region CONTRUCTORES
		public FormNomina()
		{
			InitializeComponent();
		}
		
		public FormNomina(Interfaz.FormPrincipal principal, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			this.idusuario = id_usuario;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormNominaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.nomina=false;
		}
		
		void FormNominaLoad(object sender, EventArgs e)
		{
			//AdaptadorOperador();
			AdaptadorOperadorNomina();
			Importes();
			fechaaviso = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO()));
			dtInicio.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO()));
			dtCorte.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN()));
			Fechecarpeta = dtInicio.Value.ToString("yyyy-MM-dd")+" al "+dtCorte.Value.ToString("yyyy-MM-dd");
			Validar(this);
			Nivel();
			//Importes();
			User = principal.nombreUsuario;
			ShortFecha = DateTime.Now.ToString("yyyy-MM-dd");
			precioBonoNormal = (Convert.ToDouble(dataValorImporte.Rows[0].Cells[2].Value.ToString()));
			precioBonoExtra = (Convert.ToDouble(dataValorImporte.Rows[1].Cells[2].Value.ToString()));
			precioBonoEspecial = (Convert.ToDouble(dataValorImporte.Rows[2].Cells[2].Value.ToString()));
			CargarTabPage();
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtEnvio.AutoCompleteCustomSource = auto.AutocompleteEmpresa();
			txtEnvio.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtEnvio.AutoCompleteSource = AutoCompleteSource.CustomSource;
			InsercionNominas();
		}
		#endregion
		
		#region BOTONES
		void BtnImprimirClick(object sender, EventArgs e)
		{
			DialogResult boton1 = MessageBox.Show("Desea imprimir todas las Nóminas?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (boton1 == DialogResult.Yes)
				ImprimirTodosPDF();
		}
				
		void BtnHistorialClick(object sender, EventArgs e)
		{
			if(this.prestamos==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				formimpuestos=new Interfaz.Nomina.FormImpuestos(this, "Sueldo");
				formimpuestos.WindowState = FormWindowState.Maximized;
				formimpuestos.MdiParent = principal;
				formimpuestos.Show();
				formimpuestos.BringToFront();
				this.prestamos=true;
			}
		}
		
		void BtnReciboClick(object sender, EventArgs e)
		{
			if(principal.recibos==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				Recibo=new Interfaz.Nomina.Recibo.FormRecibo(this.principal, FechaInicio, FechaCorte, this);
				Recibo.WindowState = FormWindowState.Maximized;
				Recibo.MdiParent = principal;
				Recibo.Show();
				Recibo.BringToFront();
				principal.recibos=true;
			}
		}
		
		void BtnExternosClick(object sender, EventArgs e)
		{
			if(principal.OperadorExterno==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				OperadorExterno=new Interfaz.Nomina.FormOperadorExterno(principal, FechaInicio, FechaCorte);
				OperadorExterno.WindowState = FormWindowState.Maximized;
				OperadorExterno.MdiParent = principal;
				OperadorExterno.Show();
				OperadorExterno.BringToFront();
				principal.recibos=true;
			}
		}
		
		void BtnExtrasClick(object sender, EventArgs e)
		{
			if(principal.extras==true)
				MessageBox.Show("La ventana ya esta abierta ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			else
			{
				Interfaz.Nomina.FormIngresoExtra formIngresoExtra = new Interfaz.Nomina.FormIngresoExtra(principal, FechaInicio, FechaCorte, Alias, idusuario);
				formIngresoExtra.WindowState = FormWindowState.Maximized;
				formIngresoExtra.MdiParent = principal;
				formIngresoExtra.Show();
				formIngresoExtra.BringToFront();
				principal.extras=true;
			}
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			conn.getAbrirConexion("UPDATE NOMINA SET Importe1="+txtImporte1.Text+" where fecha_inicio='"+FechaInicio+"' and fecha_fin='"+FechaCorte+"' and IdOperador="+IdOperador);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();	
		}
		
		void BtnExcelClick(object sender, EventArgs e)
		{
			FechaInicio = (dtInicio.Value.ToString("yyyy-MM-dd"));
			FechaCorte = (dtCorte.Value.ToString("yyyy-MM-dd"));
			Fechecarpeta = dtInicio.Value.ToString("yyyy-MM-dd")+" al "+dtCorte.Value.ToString("yyyy-MM-dd");
				
			String[,] Hoja = new String[1000,9];
			double Total_nomina = 0.0;
			double Total_nomina_real = 0.0;
			double Total_prestamos = 0.0;			
			 
			for(x=0; x<dtOperador.Rows.Count; x++)
			{
			 total = 0.0;
			 totalIngresos = 0.0;
			 totalpercepciones = 0.0;
			 aguinaldoneto = 0.0;
			 primavacacional = 0.0;
			 aguinaldoneto = 0.0;
			 DescuentoPeriodo = 0.0;
			 DescuentoPrestamo = 0.0;
			 infonavit = 0.0;
			 isr = 0.0;
			 imss = 0.0;
			 extra1 = 0.0;
					IdNom = 0;
					principal.progressbarPrin.Minimum = 1;
		    		principal.progressbarPrin.Maximum = dtOperador.Rows.Count; 
		    		
					if(x>0)
						dtOperador.Rows[x-1].Selected = false;
					
					dtOperador.Rows[x].Selected = true;
					
					MetodoPrincipalPDF(this.x);
					
					if(Unidad!=""&&Unidad!=null)
						Hoja[x,0] = Unidad;
					else
						Hoja[x,0] = "No tiene unidad";
					
					double residuo = 0;
					if(Math.Round(total, 2)%5!=0)
					{
						residuo = Math.Round(total,2)%5;
						residuo = 5 - residuo;
						total = Math.Round(total,2) + residuo;
					}					
					//total = ((totalIngresos+extra1+totalpercepciones)-(aguinaldoneto+primavacacional)) - (infonavit+isr+imss) - (DescuentoPeriodo) - (DescuentoPrestamo);
					Hoja[x,1] = Alias;
					Hoja[x,2] =  Math.Round(total).ToString("C"); 
					//Hoja[x,2] = total.ToString();
					Hoja[x,3] = ((totalIngresos+extra1+totalpercepciones)-(aguinaldoneto+primavacacional)).ToString("C");
					Hoja[x,4] = aguinaldoneto.ToString("C");
					Hoja[x,5] = primavacacional.ToString("C");
					Hoja[x,6] = DescuentoPeriodo.ToString("C");
					Hoja[x,7] = DescuentoPrestamo.ToString("C");
					Hoja[x,8] = (infonavit+isr+imss).ToString("C");
					
			
					Total_nomina = Total_nomina + total;
					
					Total_nomina_real = Total_nomina_real + ((totalIngresos+extra1+totalpercepciones)-(aguinaldoneto+primavacacional));		
					principal.progressbarPrin.Increment(1);
			}
					Total_prestamos = Total_nomina_real - Total_nomina;
					principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;	
							
			Excels.SueldoQuincenaActual(principal, Hoja, dtOperador.Rows.Count, Total_nomina, Total_nomina_real, Total_prestamos);
		}
		
		void BtnBonoClick(object sender, EventArgs e)
		{
			if(principal.bonos==true)
			{
				if(principal.formBonos.WindowState==FormWindowState.Minimized)
					principal.formBonos.WindowState = FormWindowState.Maximized;
				else
					principal.formBonos.BringToFront();
			}
			else
			{
				principal.formBonos=new Interfaz.Nomina.Bono.FormBonos(principal, Alias);
				principal.formBonos.WindowState = FormWindowState.Normal;
				principal.formBonos.Show();
				principal.formBonos.BringToFront();
				principal.formBonos.MdiParent=principal;
				principal.bonos=true;	
			}
		}
		
		void BtnprestamoClick(object sender, EventArgs e)
		{
			if(principal.anticipos==true)
			{
				if(principal.formPrinAnticipo.WindowState==FormWindowState.Minimized)
					principal.formPrinAnticipo.WindowState = FormWindowState.Maximized;
				else
					principal.formPrinAnticipo.BringToFront();
			}
			else
			{
				principal.formPrinAnticipo = new Transportes_LAR.Interfaz.Nomina.Anticipos.FormPrincAnticipos(principal, Alias, idusuario);
				principal.formPrinAnticipo.WindowState = FormWindowState.Maximized;
				principal.formPrinAnticipo.BringToFront();
				principal.formPrinAnticipo.Show();
				principal.formPrinAnticipo.MdiParent=principal;
				principal.anticipos=true;
			}
		}
		
		void BtnBonificacionClick(object sender, EventArgs e)
		{
			Excels.ReporteBonificaciones(principal);
		}
		
		void BtnTipoPagoClick(object sender, EventArgs e)
		{
			new Transportes_LAR.Interfaz.Nomina.FormEfectivoCheque(principal).ShowDialog();
		}
		#endregion
		
		#region CALCULAR TOTALES
		public void CalcularTotales ()
		{
			try
			{
				txtInfonavit.Text = infonavit.ToString();
				txtTelcel.Text = telcel.ToString();
				txtImss.Text = imss.ToString();
				txtIsr.Text = isr.ToString();
				anticipos = DescuentoPrestamo+DescuentoPeriodo;
				txtAnticipos.Text = anticipos.ToString();
				txtImpuestos.Text = (infonavit+isr+imss).ToString();
				bonos = Convert.ToDouble(txtBono.Text);
				impuestos = Convert.ToDouble(txtImpuestos.Text);
				totalBonos = bonos + valorBonoEx + valorBonoEs + valorBonoApoyoCoord;
				subtotalviajesneto = (sueldoPRendimiento+sueldoRecono+sumapoyos+sueldoViajes+sueldoViajesE+sueldoViajesG+sueldoCanc);
				subtotal = (extra1+totalBonos+subtotalviajesneto+totalIngresos);
				txtSueldoViajes.Text = (subtotalviajesneto).ToString();
				txtSubtotal.Text = (subtotal).ToString();
				totalpercepciones = subtotalviajesneto + totalBonos;
				txtTotal.Text = (subtotal-impuestos-anticipos+(Convert.ToDouble(txtPrestamoAdicional.Text))).ToString();
				total =  Math.Round((Convert.ToDouble(txtTotal.Text)), 2);
				txtPromedio.Text = (Math.Round(Convert.ToDouble(AcumuladorBonos)/dataMatriz.RowCount, 2)).ToString();
				txtViajesRealizados.Text = AcumuladorViajes.ToString();
				TipoPago();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ocurrió una Exception "+ex);
			}
		}
		
		void TipoPago()
		{
			String pago = new Conexion_Servidor.Nomina.SQL_Nomina().TraerTipoPago();
			
			double residuo = 0;
			if(Math.Round(total, 2)>0)
			{
				if(Math.Round(total, 2)%5!=0)
				{
					residuo = Math.Round(total, 2)%5;
					residuo = 5 - residuo;
					total = total + residuo;
				}
			}
			
			if(foraneo=="1" && pago=="EFECTIVO")
			{
				txtCheque.Text = "0.00";
				txtEfectivo.Text = total.ToString();
			}
			else if(pago=="EFECTIVO")
			{
				txtCheque.Text = "0.00";
				txtEfectivo.Text = total.ToString();
			}
			else
			{
				if(total>=5400)
				{
					txtCheque.Text = "4900";
					txtEfectivo.Text = (total - 4900).ToString();
				}
				else if(total<1001)
				{
					txtCheque.Text = "0.00";
					txtEfectivo.Text = total.ToString();
				}
				else
				{
					txtCheque.Text = (total - 500).ToString();
					txtEfectivo.Text = "500.00";
				}
			}
		}
		#endregion

		#region VALIDACION CAMPOS
		void Validar(Interfaz.Nomina.FormNomina formNomina)
		{
			formNomina.txtImporte1.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formNomina.txtPrestamoAdicional.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		
		void TxtPrestamoAdicionalTextChanged(object sender, EventArgs e)
		{
			if(txtPrestamoAdicional.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtImporte1TextChanged(object sender, EventArgs e)
		{
			if(txtImporte1.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		#endregion
		
		#region ENVIAR DATOS PDF's
		public void DirectorioIlustradoPDF(Document document, PdfWriter writer, string vehiculo, String opcion)
		{
			FormatoPdf.DirectorioIlustrado(principal, document, writer, dtOperador, Ingreso, VigEstatal, 
			                               VigFederal, ptbImagen, Celular, Unidad, Alias, Nomb, Ape, ShortFecha, ms, this, vehiculo, opcion);
		}
		
		public void DirectorioTelefonicoPDF(Document document, PdfWriter writer)
		{
			FormatoPdf.DirectorioTelefonico(principal, document, writer, dtOperador, Ingreso, VigEstatal, 
			                               VigFederal, ptbImagen, Celular, Unidad, Alias, Nomb, Ape, ShortFecha, ms, this);
		}
		
		public void GenerarDocumentoDinamicamente(Document document, PdfWriter writer)
		{ 
			DiaSemana();
			FormatoPdf.FormatoNomina(principal, document, writer, ms, ptbImagen, DiaNomina1, DiaNomina2, FechaInicio, 
			                         FechaCorte, Nombre, Alias, Unidad, dtConteo, sueldoViajes, sueldoViajesE, 
			                         sueldoViajesG, sueldoRecono, sumapoyos, sueldoCanc, sueldoPRendimiento, 
			                         subtotalviajesneto, imss, infonavit, isr, telcel, extra1, 
			                         bonos, valorBonoEx, valorBonoEs, txtApoyoCoord, totalpercepciones, 
			                         anticipos, impuestos, total, Celular, Ingreso, Estatal, Federal, 
			                         AcumuladorViajes, dataDescuentos, dataPrestamos, dataMatriz, txtEnvio, dataChoque, 
			                         dataTaxis, dataBono, DescuentoPeriodo, DescuentoPrestamo, AcumuladorBonos,
			                         AcumuladorTaller, AcumuladorDormida, AcumuladorPermiso, dataIngresosExtras, 
			                         totalIngresos, Tickets, prestamoRestante, foraneo, pagare, AcumuladorSencillos, 
			                         AcumuladorCompletos, tipoUnidad, txtPrestamoAdicional, txtEfectivo, txtCheque);
		}
		#endregion.
		
		#region COMPLETOS - SENCILLOS
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
			String Nomenclatura="";
			String Nomenclatura2="";

			for(int y = 0; y<(dataViajesNormales.RowCount-1); y++)
			{
				FechaViajeNormal = dataViajesNormales.Rows[y].Cells[1].Value.ToString();
				EmpresaViajenormal = dataViajesNormales.Rows[y].Cells[2].Value.ToString();
				SentidoViajeNormal = dataViajesNormales.Rows[y].Cells[4].Value.ToString();
				TurnoViajeNormal = dataViajesNormales.Rows[y].Cells[5].Value.ToString();
				Nomenclatura = dataViajesNormales.Rows[y].Cells[12].Value.ToString();
				
				//if(Nomenclatura=="EXT"||Nomenclatura=="DOM")
				if(Nomenclatura=="EXT" && EmpresaViajenormal=="TRATE TALA")
				{
					Nomenclatura="EXT";
				}
				else if(Nomenclatura=="DIF"||Nomenclatura=="EXT"||Nomenclatura=="DOM")
				{
					Nomenclatura="NRM";
				}
				
				for(int x = 1; x<(dataViajesNormales.RowCount); x++)
				{
					FechaViajeNormal2 = dataViajesNormales.Rows[x].Cells[1].Value.ToString();
					EmpresaViajenormal2 = dataViajesNormales.Rows[x].Cells[2].Value.ToString();
					SentidoViajeNormal2 = dataViajesNormales.Rows[x].Cells[4].Value.ToString();
					TurnoViajeNormal2 = dataViajesNormales.Rows[x].Cells[5].Value.ToString();
					Nomenclatura2 = dataViajesNormales.Rows[x].Cells[12].Value.ToString();
					
					//if(Nomenclatura=="EXT"||Nomenclatura=="DOM")
					if(Nomenclatura2=="EXT" && EmpresaViajenormal2=="TRATE TALA")
					{
						Nomenclatura2="EXT";
					}
					else if(Nomenclatura2=="DIF"||Nomenclatura2=="EXT"||Nomenclatura2=="DOM")
					{
						Nomenclatura2="NRM";
					}
					
					if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2)&&(Nomenclatura==Nomenclatura2))
						{
							if((dataViajesNormales.Rows[y].Cells[9].Value.ToString()!="Completo")&&(dataViajesNormales.Rows[x].Cells[9].Value.ToString()!="Completo"))
							{
								dataViajesNormales.Rows[y].Cells[9].Value="Completo";
								dataViajesNormales.Rows[y].Cells[4].Value = "E/S";
								dataViajesNormales.Rows[x].Cells[9].Value="Completo";
								dataViajesNormales.Rows[x].Cells[4].Value = "E/S";
								if(x!=y)
								{
									if((Convert.ToDouble(dataViajesNormales.Rows[y].Cells[10].Value))>=(Convert.ToDouble(dataViajesNormales.Rows[x].Cells[10].Value))
									   && (Convert.ToDouble(dataViajesNormales.Rows[y].Cells[15].Value))>=(Convert.ToDouble(dataViajesNormales.Rows[x].Cells[15].Value)))
									{
										dataViajesNormales.Rows[y].Cells[9].Style.BackColor = Color.LimeGreen;
										dataViajesNormales.Rows[y].Cells[9].Style.ForeColor = Color.Black;
										
										if(dataViajesNormales.Rows[y].Cells[7].Value.ToString() == "0" && dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "1"){											
											dataViajesNormales.Rows[y].Cells[7].Value = dataViajesNormales.Rows[x].Cells[7].Value;
											dataViajesNormales.Rows[y].Cells[7].Style.BackColor = Color.MediumPurple;
										}
										
										dataViajesNormales.Rows.RemoveAt(x);
										if(x>0)
										    --x;
									}
									else
									{
										dataViajesNormales.Rows[x].Cells[9].Style.BackColor = Color.LimeGreen;
										dataViajesNormales.Rows[x].Cells[9].Style.ForeColor = Color.Black;
										
										if(dataViajesNormales.Rows[x].Cells[7].Value.ToString() == "0" && dataViajesNormales.Rows[y].Cells[7].Value.ToString() == "1"){
											dataViajesNormales.Rows[x].Cells[7].Value = dataViajesNormales.Rows[y].Cells[7].Value;
											dataViajesNormales.Rows[x].Cells[7].Style.BackColor = Color.MediumPurple;
										}
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
		}
		
		void SumaViajesEspeciales()
		{
			String FechaViajeNormal="";
			String EmpresaViajenormal="";
			String SentidoViajeNormal="";
			String FechaViajeNormal2="";
			String EmpresaViajenormal2="";
			String SentidoViajeNormal2="";
			String TurnoViajeNormal="";
			String TurnoViajeNormal2="";

			for(int y = 0; y<(dataViajesEspeciales.RowCount-1); y++)
			{
				FechaViajeNormal = dataViajesEspeciales.Rows[y].Cells[2].Value.ToString();
				EmpresaViajenormal = dataViajesEspeciales.Rows[y].Cells[3].Value.ToString();
				SentidoViajeNormal = dataViajesEspeciales.Rows[y].Cells[5].Value.ToString();
				TurnoViajeNormal = dataViajesEspeciales.Rows[y].Cells[6].Value.ToString();
				
				for(int x = 1; x<(dataViajesEspeciales.RowCount); x++)
				{
					FechaViajeNormal2 = dataViajesEspeciales.Rows[x].Cells[2].Value.ToString();
					EmpresaViajenormal2 = dataViajesEspeciales.Rows[x].Cells[3].Value.ToString();
					SentidoViajeNormal2 = dataViajesEspeciales.Rows[x].Cells[5].Value.ToString();
					TurnoViajeNormal2 = dataViajesEspeciales.Rows[x].Cells[6].Value.ToString();
					
						if(((FechaViajeNormal==FechaViajeNormal2)&&(EmpresaViajenormal==EmpresaViajenormal2)&&(TurnoViajeNormal==TurnoViajeNormal2))&&(SentidoViajeNormal!=SentidoViajeNormal2))
						{
							if((dataViajesEspeciales.Rows[y].Cells[10].Style.BackColor.Name!="GhostWhite")&&(dataViajesEspeciales.Rows[x].Cells[10].Style.BackColor.Name!="GhostWhite"))
							{
								dataViajesEspeciales.Rows[y].Cells[10].Value="Completo";
								dataViajesEspeciales.Rows[y].Cells[10].Style.BackColor=Color.GhostWhite;
								dataViajesEspeciales.Rows[y].Cells[5].Value = "E/S";
								dataViajesEspeciales.Rows[x].Cells[10].Value="Completo";
								dataViajesEspeciales.Rows[x].Cells[10].Style.BackColor=Color.GhostWhite;
								dataViajesEspeciales.Rows[x].Cells[5].Value = "E/S";
								
								if(x!=y)
								{
									if((Convert.ToDouble(dataViajesEspeciales.Rows[y].Cells[9].Value))>=(Convert.ToDouble(dataViajesEspeciales.Rows[x].Cells[9].Value)))
									{
										dataViajesEspeciales.Rows[y].Cells[1].Style.BackColor=Color.LimeGreen;
										dataViajesEspeciales.Rows.RemoveAt(x);
										if(x>0)
											--x;
									}
									else
									{
										dataViajesEspeciales.Rows[x].Cells[1].Style.BackColor=Color.LimeGreen;
										dataViajesEspeciales.Rows.RemoveAt(y);
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
			ValoresRedEsp();
		}
		#endregion
		
		#region EVENTOS
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			if(cbPeriodo.Checked == false){
				FechaInicio = (dtInicio.Value.ToString("yyyy-MM-dd"));
				FechaCorte = (dtCorte.Value.ToString("yyyy-MM-dd"));
				Fechecarpeta = dtInicio.Value.ToString("yyyy-MM-dd")+" al "+dtCorte.Value.ToString("yyyy-MM-dd");
				dtCorte.MinDate = dtInicio.Value;
				CalculoDiasTrabajados();
				MetodoPrincipalPDF(this.x);
				CalcularTotales();
				CalcularTotales();
				CalcularTotales();
				if(fechaaviso.ToString("yyyy-MM-dd")!=FechaInicio)
				{
					pOperador.BackColor =  Color.Red;
				}
				else
				{
					if(pOperador.BackColor==Color.Red)
						pOperador.BackColor = Color.WhiteSmoke;
				}
			}else{
				dtCorte.MinDate = dtInicio.Value;
			}
		}
		
		void DtCorteValueChanged(object sender, EventArgs e)
		{			
			if(cbPeriodo.Checked == false){
				FechaInicio = (dtInicio.Value.ToShortDateString());
				FechaCorte = (dtCorte.Value.ToShortDateString());
				Fechecarpeta = dtInicio.Value.ToString("yyyy-MM-dd")+" al "+dtCorte.Value.ToString("yyyy-MM-dd");
				CalculoDiasTrabajados();
				MetodoPrincipalPDF(this.x);
				CalcularTotales();
				CalcularTotales();
				CalcularTotales();
			}				
		}
		
		void DataViajesNormalesColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			SumaViajesNormales(dataViajesNormales);
		}
		
		void DtOperadorCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			int x = 0;
			
			if(e.RowIndex>-1)
			{
				x = dtOperador.CurrentRow.Index;
				this.x = x;
				MetodoPrincipalPDF(x);
			}
		}
		
		void DtOperadorCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dtOperador.Rows[e.RowIndex].Cells[1].Style.BackColor.Name!="Red")
			{
				CalcularTotales();
				CalcularTotales();
				CalcularTotales();
				Guardar(x);
				PDF();
			}
			else
				MessageBox.Show("Tiene viaje(s) sin precio, Favor de checarlo ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}
		
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			 if (e.KeyCode == Keys.Enter)
		      {
				    for(int x=0; x<dtOperador.Rows.Count; x++)
					{
				    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==txtAlias.Text)
				    	{
							if(x>0)
								dtOperador.Rows[x-1].Selected = false;

							dtOperador.ClearSelection();
							dtOperador.Rows[x].Selected = true;
							dtOperador.FirstDisplayedCell = dtOperador.Rows[x].Cells[1];
							this.x = x;
							MetodoPrincipalPDF(this.x);
							CalcularTotales();
							CalcularTotales();
							CalcularTotales();
							break;
				    	}
				    }				
				}
		}
		#endregion
		
		#region CONTADORES VIAJES
		void ContadorViajes()
		{
			ContadorV = 0;
			for(int a = 0; a<(dataViajesNormales.RowCount); a++)
				ContadorV = ContadorV + 1;
		}
		
		void ContadorViajesE()
		{
			ContadorVE = 0;
			for(int a = 0; a<(dataViajesEspeciales.RowCount); a++)
				ContadorVE = ContadorVE + 1;
		}
		
		void ContadorViajesG()
		{
			ContadorG = 0;
			for(int a = 0; a<(dataGuardia.RowCount); a++)
				ContadorG = ContadorG + 1;
		}
		
		#endregion
		
		#region ACUMULADORES VIAJES
		void SumaCostosViajes()
		{
			sueldoViajes = 0;
			if(dataViajesNormales.RowCount>0)
			{
				for(int a = 0; a<(dataViajesNormales.RowCount); a++)
					sueldoViajes = sueldoViajes + (Convert.ToDouble(dataViajesNormales.Rows[a].Cells[8].Value));
			}
		}
		
		void SumaCostosViajesE()
		{
			sueldoViajesE = 0;
			if(dataViajesEspeciales.RowCount>0)
			{
				for(int a = 0; a<(dataViajesEspeciales.RowCount); a++)
					sueldoViajesE = sueldoViajesE + (Convert.ToDouble(dataViajesEspeciales.Rows[a].Cells[9].Value));
			}
		}
		
		void SumaCostosViajesG()
		{
			sueldoViajesG = 0;
			if(dataGuardia.RowCount>0)
			{
				for(int a = 0; a<(dataGuardia.RowCount); a++)
					sueldoViajesG = sueldoViajesG + (Convert.ToDouble(dataGuardia.Rows[a].Cells[5].Value));
			}
		}
		
		void SumaCostosReconocimientso()
		{
				Reconocimientos = 0;
				sueldoRecono = 0;
				for(int a = 0; a<(dataReconocimientos.RowCount); a++)
				{
					Reconocimientos = Reconocimientos +1;
					sueldoRecono = sueldoRecono + (Convert.ToDouble(dataReconocimientos.Rows[a].Cells[8].Value));
				}
		}
		
		void SumaCostosCancelacion()
		{
				Cancelaciones = 0;
				sueldoCanc = 0;
				for(int a = 0; a<(dataCancelacion.RowCount); a++)
				{
					Cancelaciones = Cancelaciones +1;
					sueldoCanc = sueldoCanc + (Convert.ToDouble(dataCancelacion.Rows[a].Cells[5].Value));
				}
		}
		
		void SumaCostosApoyos()
		{
				viajesapoyos = 0;
				sumapoyos = 0;
				for(int a = 0; a<(dataApoyos.RowCount); a++)
				{
					viajesapoyos = viajesapoyos +1;
					sumapoyos = sumapoyos + (Convert.ToDouble(dataApoyos.Rows[a].Cells[8].Value));
				}
		}
		
		void SumaCostosPRendimiento()
		{
				contadorPRendimiento = 0;
				sueldoPRendimiento = 0;
				for(int a = 0; a<(dataRendimiento.RowCount); a++)
				{
					contadorPRendimiento = contadorPRendimiento +1;
					sueldoPRendimiento = sueldoPRendimiento + (Convert.ToDouble(dataRendimiento.Rows[a].Cells[7].Value));
				}
		}
		
		#endregion
		
		//region PRECIOS DE VIAJES
		void ValoresRedEmp()
		{
			if(dataViajesNormales.RowCount>0)
			{
				for(int a = 0; a<(dataViajesNormales.RowCount); a++)
				{
					if(dataViajesNormales.Rows[a].Cells[8].Value==null)
					{
						dataViajesNormales.Rows[a].Cells[8].Value = 0;
						dataViajesNormales.Rows[a].Cells[8].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.White;
					}
					else if(dataViajesNormales.Rows[a].Cells[8].Value.ToString()=="0")
					{
						dataViajesNormales.Rows[a].Cells[8].Value = 0;
						dataViajesNormales.Rows[a].Cells[8].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.White;
					}
					else if(dataViajesNormales.Rows[a].Cells[8].Value.ToString()=="N/A")
					{
						dataViajesNormales.Rows[a].Cells[8].Value = 0;
						dataViajesNormales.Rows[a].Cells[8].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.White;
					}
					else if((Convert.ToDouble(dataViajesNormales.Rows[a].Cells[8].Value))<=0)
					{
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.White;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.Black;
					}
				}
			}
		}
		
		void ValoresRedEsp()
		{
			if(dataViajesEspeciales.RowCount>0)
			{
				for(int a = 0; a<(dataViajesEspeciales.RowCount); a++)
				{
					if(dataViajesEspeciales.Rows[a].Cells[9].Value==null)
					{
						dataViajesEspeciales.Rows[a].Cells[10].Value = 0;
						dataViajesEspeciales.Rows[a].Cells[10].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.White;
					}
					else if(dataViajesEspeciales.Rows[a].Cells[9].Value.ToString()=="0")
					{
						dataViajesEspeciales.Rows[a].Cells[9].Value = 0;
						dataViajesEspeciales.Rows[a].Cells[9].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.White;
					}
					else if(dataViajesEspeciales.Rows[a].Cells[9].Value.ToString()=="N/A")
					{
						dataViajesEspeciales.Rows[a].Cells[9].Value = 0;
						dataViajesEspeciales.Rows[a].Cells[9].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.Red;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.White;
					}
					else
					{
						dtOperador.Rows[x].Cells[1].Style.BackColor = Color.White;
						dtOperador.Rows[x].Cells[1].Style.ForeColor = Color.Black;
					}
				}
			}
		}
		
		void PreciosRutas()
		{
			TimeSpan dif;
			double tiempo = 0;
			int domingo = 0;
			int velada = 0;
			int foran = 0;
			DateTime DiaSemanaFacturacion;
			String DiaFacturacion = "";

			for(int a = 0; a<(dataViajesNormales.RowCount);a++){
				DiaSemanaFacturacion = (Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[1].Value));
				DiaFacturacion = DiaSemanaFacturacion.DayOfWeek.ToString();
								
				if(DiaFacturacion == "Sunday"){					
					domingo = 1;					
				}				
				//Velada campo de la BD
				velada = connN.validaVelada(dataViajesNormales.Rows[a].Cells[0].Value.ToString());
				
				if(dataViajesNormales.Rows[a].Cells[12].Value.ToString() == "VL"){
					velada = 1;
				}
								
				if(dataViajesNormales.Rows[a].Cells[14].Value.ToString() != ""){
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
					}else if(hora == 00 && hora2 == 22){
						hora = 23;
						hora2 = 21;
						dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
					}else if(hora == 01 && hora2 == 23){
						hora = 23;
						hora2 = 22;
						dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
					}else{
						dif = Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[14].Value) - Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[13].Value);						
					}
					tiempo = dif.TotalMinutes;
										
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "1" && dtOperador.Rows[x].Cells[2].Value.ToString() == "1")
						foran = 0;
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "0" && dtOperador.Rows[x].Cells[2].Value.ToString() == "0")
						foran = 0;
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "0" && dtOperador.Rows[x].Cells[2].Value.ToString() == "1")
						foran = 1;
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "1" && dtOperador.Rows[x].Cells[2].Value.ToString() == "0")
						foran = 1;	
							 
					if(Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value) < 21.0)
						foran = 0;
				}
				
				try{
					//dataViajesNormales.Rows[a].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas(dataViajesNormales.Rows[a].Cells[9].Value.ToString(), dataViajesNormales.Rows[a].Cells[6].Value.ToString(), Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value), tiempo, domingo, velada, Convert.ToInt32(dataViajesNormales.Rows[a].Cells[7].Value));
					
					if(dataViajesNormales[2,a].Value.ToString().Contains("DIF") && dataViajesNormales[9,a].Value.ToString()=="Completo"){
						dataViajesNormales.Rows[a].Cells[8].Value = 180;
//					}else if(dataViajesNormales[2,a].Value.ToString().Contains("CONVER") && dataViajesNormales[9,a].Value.ToString()=="Completo"
//					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("CANTAROS")){
//						dataViajesNormales.Rows[a].Cells[8].Value = 130;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("CONVER") && dataViajesNormales[9,a].Value.ToString()=="Completo"){
						dataViajesNormales.Rows[a].Cells[8].Value = 170;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("CONVER") && dataViajesNormales[9,a].Value.ToString()!="Completo"){
						dataViajesNormales.Rows[a].Cells[8].Value = 100;
					}else if(dataViajesNormales[2,a].Value.ToString() == "TEVA" && dataViajesNormales[9,a].Value.ToString()!="Completo"
					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("ZAPOPAN")){
						dataViajesNormales.Rows[a].Cells[8].Value = 130;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("TEVA VANILLA") && dataViajesNormales[9,a].Value.ToString()!="Completo"
					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("ZAPOPAN")){
						dataViajesNormales.Rows[a].Cells[8].Value = 90;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("COREY CAMIONES") 
					         && dataViajesNormales[9,a].Value.ToString()!="Completo"
					         && dataViajesNormales[5,a].Value.ToString().Contains("Nocturno")
					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("PONCITLAN")){
						dataViajesNormales.Rows[a].Cells[8].Value = 150;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("TRATE") ){
						dataViajesNormales.Rows[a].Cells[8].Value = 125;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("TEVA CAMIONETAS") && dataViajesNormales[9,a].Value.ToString()!="Completo" 
					         && dataViajesNormales[6,a].Value.ToString()=="Camioneta"){
						dataViajesNormales.Rows[a].Cells[8].Value = 90;
					}else{
						dataViajesNormales.Rows[a].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas(dataViajesNormales.Rows[a].Cells[9].Value.ToString(), dataViajesNormales.Rows[a].Cells[6].Value.ToString(), Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value), tiempo, domingo, velada, foran);
					}
					
					
					
					if(dataViajesNormales.Rows[a].Cells[2].Value.ToString() == "TEVA" && dataViajesNormales.Rows[a].Cells[3].Value.ToString() ==  "ALMACEN")
						dataViajesNormales.Rows[a].Cells[8].Value = 25.0;
					if(dataViajesNormales.Rows[a].Cells[2].Value.ToString() == "TEVA ALMACEN" && dataViajesNormales.Rows[a].Cells[3].Value.ToString() ==  "ALMACEN")
						dataViajesNormales.Rows[a].Cells[8].Value = 25.0;
					tiempo = 0;
					domingo = 0;
					velada = 0;
					foran = 0;
					
					//if(dtOperador.Rows[dtOperador.CurrentRow.Index].Cells[1].Value.ToString() == "ONOFRE" && dataViajesNormales.Rows[a].Cells[3].Value.ToString() == "JAUJA")
					//	dataViajesNormales.Rows[a].Cells[8].Value = 110;
					
				}catch(Exception ex){
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}finally{
					conn.conexion.Close();
				}
			}
			
			for(int a = 0; a<(dataViajesEspeciales.RowCount);a++)
			{
				try
				{
				conn.getAbrirConexion("select R.CompletoCamion, R.CompletoCamioneta from CLIENTE C, RUTA R where C.ID=R.IdSubEmpresa and R.ID="+dataViajesEspeciales.Rows[a].Cells[0].Value);
				conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							if((dataViajesEspeciales.Rows[a].Cells[10].Value.ToString()=="Completo")&&(dataViajesEspeciales.Rows[a].Cells[7].Value.ToString()=="Camión"))
								dataViajesEspeciales.Rows[a].Cells[9].Value = conn.leer["CompletoCamion"];
							else if((dataViajesEspeciales.Rows[a].Cells[10].Value.ToString()=="Completo")&&(dataViajesEspeciales.Rows[a].Cells[7].Value.ToString()=="Camioneta"))
								dataViajesEspeciales.Rows[a].Cells[9].Value = conn.leer["CompletoCamioneta"];
							else
							{
								if(dataViajesEspeciales.Rows[a].Cells[10].Value.ToString()=="Completo")
									dataViajesEspeciales.Rows[a].Cells[9].Value = conn.leer["CompletoCamioneta"];
							}
						}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();
			}
			ValoresRedEmp();
		}
		
		void PreciosRutas2(string foraneo)
		{
			TimeSpan dif;
			double tiempo = 0;
			int domingo = 0;
			int velada = 0;
			int foran = 0;
			DateTime DiaSemanaFacturacion;
			String DiaFacturacion = "";

			for(int a = 0; a<(dataViajesNormales.RowCount);a++){
				DiaSemanaFacturacion = (Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[1].Value));
				DiaFacturacion = DiaSemanaFacturacion.DayOfWeek.ToString();
								
				if(DiaFacturacion == "Sunday"){					
					domingo = 1;					
				}				
				velada = connN.validaVelada(dataViajesNormales.Rows[a].Cells[0].Value.ToString());
				
				if(dataViajesNormales.Rows[a].Cells[12].Value.ToString() == "VL")
					velada = 1;
								
				if(dataViajesNormales.Rows[a].Cells[14].Value.ToString() != ""){
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
					}else if(hora == 00 && hora2 == 22){
						hora = 23;
						hora2 = 21;
						dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
					}else if(hora == 01 && hora2 == 23){
						hora = 23;
						hora2 = 22;
						dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
					}else{
						dif = Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[14].Value) - Convert.ToDateTime(dataViajesNormales.Rows[a].Cells[13].Value);						
					}
					tiempo = dif.TotalMinutes;
										
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "1" && foraneo == "1")
						foran = 0;
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "0" && foraneo == "0")
						foran = 0;
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "0" && foraneo == "1")
						foran = 1;
					if(dataViajesNormales.Rows[a].Cells[7].Value.ToString() == "1" && foraneo == "0")
						foran = 1;
					
					if(Convert.ToInt32(dataViajesNormales.Rows[a].Cells[10].Value) < 21)
						foran = 0;
				}
				
				try{
					
//					if(dataViajesNormales[2,a].Value.ToString().Contains("DIF") && dataViajesNormales[9,a].Value.ToString()=="Completo"){
//						dataViajesNormales.Rows[a].Cells[8].Value = 180;
//					}else {
//						//dataViajesNormales.Rows[a].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas(dataViajesNormales.Rows[a].Cells[9].Value.ToString(), dataViajesNormales.Rows[a].Cells[6].Value.ToString(), Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value), tiempo, domingo, velada, Convert.ToInt32(dataViajesNormales.Rows[a].Cells[7].Value));
//						dataViajesNormales.Rows[a].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas(dataViajesNormales.Rows[a].Cells[9].Value.ToString(), dataViajesNormales.Rows[a].Cells[6].Value.ToString(), Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value), tiempo, domingo, velada, foran);
//					}
//					
//					tiempo = 0;
//					domingo = 0;
//					velada = 0;
//					foran = 0;
					
					if(dataViajesNormales[2,a].Value.ToString().Contains("DIF") && dataViajesNormales[9,a].Value.ToString()=="Completo"){
						dataViajesNormales.Rows[a].Cells[8].Value = 180;
//					}else if(dataViajesNormales[2,a].Value.ToString().Contains("CONVER") && dataViajesNormales[9,a].Value.ToString()=="Completo"
//					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("CANTAROS")){
//						dataViajesNormales.Rows[a].Cells[8].Value = 130;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("CONVER") && dataViajesNormales[9,a].Value.ToString()=="Completo"){
						dataViajesNormales.Rows[a].Cells[8].Value = 170;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("CONVER") && dataViajesNormales[9,a].Value.ToString()!="Completo"){
						dataViajesNormales.Rows[a].Cells[8].Value = 100;
					}else if(dataViajesNormales[2,a].Value.ToString() == "TEVA" && dataViajesNormales[9,a].Value.ToString()!="Completo"
					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("ZAPOPAN")){
						dataViajesNormales.Rows[a].Cells[8].Value = 130;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("TEVA VANILLA") && dataViajesNormales[9,a].Value.ToString()!="Completo"
					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("ZAPOPAN")){
						dataViajesNormales.Rows[a].Cells[8].Value = 90;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("COREY CAMIONES") 
					         && dataViajesNormales[9,a].Value.ToString()!="Completo"
					         && dataViajesNormales[5,a].Value.ToString().Contains("Nocturno")
					         && dataViajesNormales.Rows[a].Cells[3].Value.ToString().Contains("PONCITLAN")){
						dataViajesNormales.Rows[a].Cells[8].Value = 150;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("TRATE") ){
						dataViajesNormales.Rows[a].Cells[8].Value = 125;
					}else if(dataViajesNormales[2,a].Value.ToString().Contains("TEVA CAMIONETAS") && dataViajesNormales[9,a].Value.ToString()!="Completo" 
					         && dataViajesNormales[6,a].Value.ToString()=="Camioneta"){
						dataViajesNormales.Rows[a].Cells[8].Value = 115;
					}else{
						dataViajesNormales.Rows[a].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas(dataViajesNormales.Rows[a].Cells[9].Value.ToString(), dataViajesNormales.Rows[a].Cells[6].Value.ToString(), Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value), tiempo, domingo, velada, foran);
					}
					
					
					
					if(dataViajesNormales.Rows[a].Cells[2].Value.ToString() == "TEVA" && dataViajesNormales.Rows[a].Cells[3].Value.ToString() ==  "ALMACEN")
						dataViajesNormales.Rows[a].Cells[8].Value = 25.0;
					if(dataViajesNormales.Rows[a].Cells[2].Value.ToString() == "TEVA ALMACEN" && dataViajesNormales.Rows[a].Cells[3].Value.ToString() ==  "ALMACEN")
						dataViajesNormales.Rows[a].Cells[8].Value = 25.0;
					tiempo = 0;
					domingo = 0;
					velada = 0;
					foran = 0;
				}catch(Exception ex){
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}finally{
					conn.conexion.Close();
				}
			}
			
			for(int a = 0; a<(dataViajesEspeciales.RowCount);a++)
			{
				try
				{
				conn.getAbrirConexion("select R.CompletoCamion, R.CompletoCamioneta from CLIENTE C, RUTA R where C.ID=R.IdSubEmpresa and R.ID="+dataViajesEspeciales.Rows[a].Cells[0].Value);
				conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							if((dataViajesEspeciales.Rows[a].Cells[10].Value.ToString()=="Completo")&&(dataViajesEspeciales.Rows[a].Cells[7].Value.ToString()=="Camión"))
								dataViajesEspeciales.Rows[a].Cells[9].Value = conn.leer["CompletoCamion"];
							else if((dataViajesEspeciales.Rows[a].Cells[10].Value.ToString()=="Completo")&&(dataViajesEspeciales.Rows[a].Cells[7].Value.ToString()=="Camioneta"))
								dataViajesEspeciales.Rows[a].Cells[9].Value = conn.leer["CompletoCamioneta"];
							else
							{
								if(dataViajesEspeciales.Rows[a].Cells[10].Value.ToString()=="Completo")
									dataViajesEspeciales.Rows[a].Cells[9].Value = conn.leer["CompletoCamioneta"];
							}
						}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocurrió una Excepcion "+ex);
				}
				conn.conexion.Close();
			}
			ValoresRedEmp();
		}
		//endregion
		
		#region DATOS OPERADOR
		public void DatosOperadorPDF(int x)
		{	
			Ingreso = "";
			Nombre = "";
			Nomb = "";
			Ape = "";
			Unidad = "";
			Celular = "";
			Estatal = "";
			VigFederal = "";
			Federal = "";
			VigFederal = "";
			ptbImagen.Image = null;
			
			listNomina = new Conexion_Servidor.Nomina.SQL_Nomina().Operador(dtOperador[0,x].Value.ToString());
			Ingreso = listNomina[0].Ingreso;
			Nombre = listNomina[0].Nombre;
			Nomb = listNomina[0].Nomb;
			Ape = listNomina[0].Ape;
			Unidad = listNomina[0].Unidad;
			Celular = listNomina[0].Celular;
			Estatal = listNomina[0].Estatal;
			VigFederal = listNomina[0].VigEstatal;
			Federal = listNomina[0].Federal;
			VigFederal = listNomina[0].VigFederal;
			tipoUnidad = listNomina[0].TipoUnidad;
			lblVehiculo.Text = "Unidad: "+tipoUnidad;
			txtUnidad.Text = Unidad;
			txtTelefono.Text = Celular;
			
			
			try{
				ptbImagen.Image = System.Drawing.Image.FromFile(@"../debug/Nomina.jpg");
			}
			catch{
				
			}
			
				
				try
				{
					
				conn.getAbrirConexion("select Imagen from operador where ID="+dtOperador.Rows[x].Cells[0].Value);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					{
					byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
		  			ms = new System.IO.MemoryStream(imageBuffer);
		  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
					}
				}
				catch{}
				conn.conexion.Close();
		}
		#endregion
		
		#region CONTEO EMPRESAS
		void ConteoEmpresasPDF(int x)
		{
			int increment=0;
			try
			{
			String conss = "Select distinct(C.Empresa) from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP where C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and oo.id_operador ="+dtOperador[0,x].Value; 
			conn.getAbrirConexion(conss);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["Empresa"].ToString()!="Especiales")
				{
					ArrayEmpresa[increment]=conn.leer["Empresa"].ToString();
					contadorDineroEmpresas = 0;
					contadorEmpresas = 0;
					contadorCompletos = 0;
					contadorSencillos = 0;
					for(int y = 0; y<(dataViajesNormales.RowCount); y++)
					{
						if(dataViajesNormales.Rows[y].Cells[2].Value.ToString()==ArrayEmpresa[increment].ToString())
						{
							contadorDineroEmpresas = contadorDineroEmpresas + (Convert.ToDouble(dataViajesNormales.Rows[y].Cells[8].Value));
							if(dataViajesNormales.Rows[y].Cells[9].Value.ToString()=="Completo")
							{
								contadorCompletos = contadorCompletos + 1;
								NameEmpresa = ArrayEmpresa[increment].ToString();
							}
							if(dataViajesNormales.Rows[y].Cells[9].Value.ToString()=="Sencillo")
							{
								contadorSencillos = contadorSencillos + 1;
								NameEmpresa = ArrayEmpresa[increment].ToString();
							}
							contadorEmpresas = contadorEmpresas + 1;
							ArrayDinero[increment]=contadorDineroEmpresas;
							ArrayNumero[increment]=contadorEmpresas;
							ArrayCompleto[increment]=contadorCompletos;
							ArraySencillo[increment]=contadorSencillos;
						}
				}
				if(NameEmpresa==ArrayEmpresa[increment].ToString())
					ArrayNumero[increment]= contadorEmpresas;

				++increment;
				}
			  }
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ocurrió una Excepcion "+ex);
			}
			conn.conexion.Close();
			
			try
			{
			String cons = "Select distinct(RE.DESTINO) " +
				                  "from CLIENTE C, RUTA_ESPECIAL RE, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, ContactoServicio CS " +
				                  "where O.Estatus='1' and C.ID=RE.ID_C and C.ID=R.IdSubEmpresa and C.ID=CS.IdCliente and RE.ID_C = CS.IdCliente and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID and RE.FECHA_REGRESO between '"+FechaInicio+"' AND '"+FechaCorte+"' and oo.id_operador ="+dtOperador[0,x].Value;
			conn.getAbrirConexion(cons);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					ArrayEmpresa[increment]=conn.leer["DESTINO"].ToString();
					contadorDineroEmpresas = 0;
					contadorEmpresas = 0;
					contadorCompletos = 0;
					contadorSencillos = 0;
					for(int y = 0; y<(dataViajesEspeciales.RowCount); y++)
					{
						if(dataViajesEspeciales.Rows[y].Cells[4].Value.ToString()==ArrayEmpresa[increment].ToString())
						{
							contadorDineroEmpresas = contadorDineroEmpresas + (Convert.ToDouble(dataViajesEspeciales.Rows[y].Cells[9].Value));
							if(dataViajesEspeciales.Rows[y].Cells[10].Value.ToString()=="Completo")
							{
								contadorCompletos = contadorCompletos + 1;
								NameEmpresa = ArrayEmpresa[increment].ToString();
							}
							if(dataViajesEspeciales.Rows[y].Cells[10].Value.ToString()=="Sencillo")
							{
								contadorSencillos = contadorSencillos + 1;
								NameEmpresa = ArrayEmpresa[increment].ToString();
							}
							contadorEmpresas = contadorEmpresas + 1;
							ArrayDinero[increment]=contadorDineroEmpresas;
							ArrayNumero[increment]=contadorEmpresas;
							ArrayCompleto[increment]=contadorCompletos;
							ArraySencillo[increment]=contadorSencillos;
						}
				}
				if(NameEmpresa==ArrayEmpresa[increment].ToString())
					ArrayNumero[increment]= contadorEmpresas;
				
				++increment;
			  }
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ocurrió una Excepcion "+ex);
			}
			conn.conexion.Close();
			if(dataGuardia.RowCount>-1)
			{
				++increment;
				ContadorViajesG();
				SumaCostosViajesG();
				ArrayEmpresa[increment]="GUARDIA";
				ArrayNumero[increment]=ContadorG;
				ArrayDinero[increment]=sueldoViajesG;
			}
			if(dataReconocimientos.RowCount>-1)
			{
				++increment;
				SumaCostosReconocimientso();
				ArrayEmpresa[increment]="RECONOCIMIENTO DE RUTA";
				ArrayNumero[increment]=Reconocimientos;
				ArrayDinero[increment]=sueldoRecono;
			}
			
			if(dataCancelacion.RowCount>-1)
			{
				++increment;
				SumaCostosCancelacion();
				ArrayEmpresa[increment]="CANCELACIÓN EN PUNTO";
				ArrayNumero[increment]=Cancelaciones;
				ArrayDinero[increment]=sueldoCanc;
			}
			
			if(dataApoyos.RowCount>-1)
			{
				++increment;
				SumaCostosApoyos();
				ArrayEmpresa[increment]="APOYO";
				ArrayNumero[increment]=viajesapoyos;
				ArrayDinero[increment]=sumapoyos;
			}
			
			if(dataRendimiento.RowCount>-1)
			{
				++increment;
				SumaCostosApoyos();
				ArrayEmpresa[increment]="PRUEBA DE RENDIMIENTO";
				ArrayNumero[increment]=contadorPRendimiento;
				ArrayDinero[increment]=sueldoPRendimiento;
			}
			LlenadoDataGridConteo();
		}
		#endregion
		
		#region DATOS DATAGRID	
		void LlenadoDtGuardias()
		{
			ContadorGNull=0;
			for(int y = 0; y<(dataGuardia.RowCount); y++)
			{
				if(dataGuardia.Rows[y].Cells[3].Value.ToString()=="0")
					dataGuardia.Rows[y].Cells[5].Value = dataValorImporte.Rows[4].Cells[2].Value.ToString();
				else
				{
					dataGuardia.Rows[y].Cells[5].Value=0;
					ContadorGNull = ContadorGNull + 1;
				}
			}
		}
		
		void LlenadoDataGridConteo()
		{
			for(int y = 0; y<(ArrayEmpresa.Length); y++)
			{
				if(ArrayNumero[y].ToString()!="0")
				{
					string[] row = { ArrayEmpresa[y], ArraySencillo[y].ToString(), ArrayCompleto[y].ToString(), ArrayNumero[y].ToString(), ArrayDinero[y].ToString()};
					dtConteo.Rows.Add(row);
				}
			}
			VaciadoArray();
			dtConteo.AutoSize=true;
		}

		void VaciadoArray()
		{
			for(int y = 0; y<(ArrayEmpresa.Length); y++)
			{
				ArrayEmpresa[y]="";
				ArrayNumero[y]=(Convert.ToInt16("0"));
				ArraySencillo[y]=(Convert.ToInt16("0"));
				ArrayCompleto[y]=(Convert.ToInt16("0"));
				ArrayDinero[y]=(Convert.ToDouble("0"));
			}
		}
		
		void BorradoRow()
		{
			dtConteo.Rows.Clear();
		}
		#endregion
		
		#region BONOS
		void TraerBono(int x)
		{
			string consulta;
			PorcentajeBono = 0.0;
			BonoBonificacion = "0";
			try
			{	
				consulta = "select ESTATUS, ESTATUS2, ESTATUS3, ESTATUS4, CANTIDAD " +
				                      "from BONO_OPERADOR " +
				                      "where ID_O = "+dtOperador.Rows[x].Cells[0].Value;
				conn.getAbrirConexion(consulta);
				//conn.getAbrirConexion("select ESTATUS, ESTATUS2, ESTATUS3, ESTATUS4, CANTIDAD from BONO_OPERADOR where ID_O = "+IdOperador);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					BonoOperador = conn.leer["ESTATUS"].ToString();
					BonoOperadorEx = conn.leer["ESTATUS2"].ToString();
					BonoOperadorEs = conn.leer["ESTATUS3"].ToString();
					ApoyoCoordinacion = conn.leer["ESTATUS4"].ToString();
					valorBonoApoyoCoord = (Convert.ToDouble(conn.leer["CANTIDAD"].ToString()));
				}
				conn.conexion.Close();
				
				consulta = "select ESTATUS, ESTATUS2, ESTATUS3, BONIFICACION, Porcentaje " +
				                      "from NUEVO_HISTORIAL_BONO_OPERADOR " +
				                      "where FECHA_INICIO='"+Convert.ToDateTime(FechaInicio).ToString("dd-MM-yyyy")+"' and FECHA_FIN='"+Convert.ToDateTime(FechaCorte).ToString("dd-MM-yyyy")+"' and ID_O = "+dtOperador.Rows[x].Cells[0].Value;
				// 					"where FECHA_INICIO='"+dtInicio.Value.ToString("dd-MM-yyyy")+"' and FECHA_FIN='"+dtCorte.Value.ToString("dd-MM-yyyy")+"' and ID_O = "+dtOperador.Rows[x].Cells[0].Value);
				
				conn.getAbrirConexion(consulta);
				
				//conn.getAbrirConexion("select ESTATUS, ESTATUS2, ESTATUS3 from NUEVO_HISTORIAL_BONO_OPERADOR where FECHA_INICIO='"+dtInicio.Value.ToString("dd-MM-yyyy")+"' and FECHA_FIN='"+dtCorte.Value.ToString("dd-MM-yyyy")+"' and ID_O = "+IdOperador);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					BonoOperador = conn.leer["ESTATUS"].ToString();
					BonoOperadorEx = conn.leer["ESTATUS2"].ToString();
					BonoOperadorEs = conn.leer["ESTATUS3"].ToString();
					
					if(conn.leer["BONIFICACION"].ToString()=="1" && BonoOperador == "1")
					{
						BonoBonificacion = conn.leer["BONIFICACION"].ToString();
						PorcentajeBono = Convert.ToDouble(conn.leer["Porcentaje"]);
					}
				}
				conn.conexion.Close();
			
				if(BonoOperador == "0")
					ckBono.Checked = false;
				else
					ckBono.Checked = true;
			
				if(BonoOperadorEx == "0")
					ckExtra.Checked = false;
				else
					ckExtra.Checked = true;
				
				if(BonoOperadorEs == "0")
					ckEspecial.Checked = false;
				else
					ckEspecial.Checked = true;
				
				if(ApoyoCoordinacion == "0")
					{
						ckApoyo.Checked = false;
						txtApoyoCoord.Text = "0.00";
						valorBonoApoyoCoord = 0.0;
					}
					else
					{
						ckApoyo.Checked = true;
						txtApoyoCoord.Text = valorBonoApoyoCoord.ToString();
					}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Ocurrió una Excepcion "+ex);
			}
		}
		
		void ValorBono()
		{
			totalViajes = 0.0;
			AcumuladorViajes = 0;
			AcumuladorSencillos = 0;
			AcumuladorCompletos = 0;
			AcumuladorBonos = 0;
			valorBono = 0.0;
			valorBonoEs = 0.0;
			valorBonoEx = 0.0;
			
			int contadorQuita = 0;
			for(int t = 0; t<dataViajesNormales.Rows.Count; t++){
				if(dataViajesNormales[2,t].Value.ToString() == "RIMSA" && dataViajesNormales[3,t].Value.ToString() == "ALMACEN")
					++contadorQuita;
			}
				
			for(int y = 0; y<(dtConteo.RowCount); y++)
			{
				AcumuladorViajes = AcumuladorViajes + (Convert.ToInt32(dtConteo.Rows[y].Cells[3].Value));
				AcumuladorSencillos = AcumuladorSencillos + (Convert.ToInt32(dtConteo.Rows[y].Cells[1].Value));
				AcumuladorCompletos = AcumuladorCompletos + (Convert.ToInt32(dtConteo.Rows[y].Cells[2].Value));
				
				if(dtConteo.Rows[y].Cells[0].Value.ToString()!="CANCELACIÓN EN PUNTO" && dtConteo.Rows[y].Cells[0].Value.ToString()!="PRUEBA DE RENDIMIENTO" && dtConteo.Rows[y].Cells[0].Value.ToString()!="APOYO" && dtConteo.Rows[y].Cells[0].Value.ToString()!="RECONOCIMIENTO DE RUTA" && dtConteo.Rows[y].Cells[0].Value.ToString()!="GUARDIA")
					AcumuladorBonos = AcumuladorBonos + (Convert.ToInt32(dtConteo.Rows[y].Cells[3].Value));
			}
			
			AcumuladorBonos = AcumuladorBonos - contadorQuita;
			
			if(ckBono.Checked == true)
			{
				if(BonoBonificacion == "1")
				{
					totalViajes = (Convert.ToDouble(AcumuladorViajes));
					valorBono = ((AcumuladorBonos * precioBonoNormal) * PorcentajeBono);
					txtBono.Text = valorBono.ToString();
				}
				else
				{
					totalViajes = (Convert.ToDouble(AcumuladorViajes));
					valorBono = (AcumuladorBonos * precioBonoNormal);
					txtBono.Text = valorBono.ToString();
				}
			}
			else
				txtBono.Text = "0.00";
			
			if(ckExtra.Checked == true)
			{
				totalViajes = (Convert.ToDouble(AcumuladorViajes));
				valorBonoEx = (AcumuladorBonos * precioBonoExtra);
				txtBonoExtra.Text = valorBonoEx.ToString();
			}
			else
				txtBonoExtra.Text = "0.00";
			
			if(ckEspecial.Checked == true)
			{
				totalViajes = (Convert.ToDouble(AcumuladorViajes));
				valorBonoEs = (AcumuladorBonos * precioBonoEspecial);
				txtBonoEspecial.Text = valorBonoEs.ToString();
			}
			else
				txtBonoEspecial.Text = "0.00";
		}
		#endregion
		
		#region LIMPIAR CAMPOS
		void LimpiarCampos()
		{
			txtImporte1.Text = "0.0";
			txtBonoExtra.Text = "0.0";
			txtBonoEspecial.Text = "0.0";
			txtEnvio.Text = "";
			txtPrestamoAdicional.Text = "0.0";
		}
		
		void TxtAliasEnter(object sender, EventArgs e)
		{
			txtAlias.Text="";
		}
		#endregion
		
		#region DATOS IMPUESTOS
		void DatosImpuestosTotal(int x)
		{			
			telcel = 0.0;
			infonavit = 0.0;
			imss = 0.0;
			isr = 0.0;
			extra1 = 0.0;
			aguinaldo = 0.0;
			retener = 0.0;
			aguinaldoneto = 0.0;
			try
			{
			conn.getAbrirConexion("Select Importe1 from NOMINA where fecha_inicio='"+FechaInicio+"' AND fecha_fin='"+FechaCorte+"' and IdOperador ="+dtOperador[0,x].Value);
			conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					txtImporte1.Text = conn.leer["Importe1"].ToString();
					extra1 = (Convert.ToDouble(conn.leer["Importe1"]));
				}
			}
			catch{}
			finally
			{
				conn.conexion.Close();
			}
			try
			{	
			conn.getAbrirConexion("Select INFONAVIT, IMSS, ISR, Telcel, Aguinaldo, Retener from SUELDO where ID_OPERADOR ="+dtOperador[0,x].Value);
			conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					telcel = (Convert.ToDouble(conn.leer["Telcel"]));
					infonavit = (Convert.ToDouble(conn.leer["INFONAVIT"]));
					imss = (Convert.ToDouble(conn.leer["IMSS"]));
					isr = (Convert.ToDouble(conn.leer["ISR"]));
					imss = (Convert.ToDouble(conn.leer["IMSS"]));
					isr = (Convert.ToDouble(conn.leer["ISR"]));
					aguinaldo = (Convert.ToDouble(conn.leer["Aguinaldo"]));
					retener = (Convert.ToDouble(conn.leer["Retener"]));
					aguinaldoneto = aguinaldo - retener;
					
					infonavit = Math.Round( ((infonavit/14)*DiasTrabajados) ,2);
					imss = Math.Round( ((imss/14)*DiasTrabajados) ,2);
					isr = Math.Round( ((isr/14)*DiasTrabajados) ,2);
				}
			}
			catch{}
			finally
			{
				conn.conexion.Close();
			}
				
		}
		#endregion
		
		#region METODO GUARDAR
		void Guardar(int x)
		{
			if(dtOperador.RowCount>x)
			{
				conn.getAbrirConexion("Select ID from NOMINA where fecha_inicio='"+FechaInicio+"' AND fecha_fin='"+FechaCorte+"' and IdOperador="+dtOperador.Rows[x].Cells[0].Value.ToString());
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
					IdNom = (Convert.ToInt64(conn.leer["ID"]));
				conn.conexion.Close();
				
				CalcularTotales();
				CalcularTotales();
				CalcularTotales();
				
				new Conexion_Servidor.Nomina.SQL_Nomina().getActualizarRecibo(Convert.ToInt32(dtOperador[0,x].Value),
							                                                            infonavit,
							                                                            imss,
							                                                            isr,
							                                                            telcel,
							                                                            "Ajuste Nomina",
						                                                           		extra1,
							                                                            sueldoViajesE,
							                                                            sueldoViajes,
							                                                            bonos,
							                                                            Convert.ToDouble(txtTotal.Text),
							                                                            ShortFecha.ToString(),
																						Convert.ToInt64(IdNom), 
																						//dtInicio.Value.ToString("yyyy-MM-dd"),
																						//dtCorte.Value.ToString("yyyy-MM-dd"),																						
																						FechaInicio,
																						FechaCorte,
																						principal.idUsuario, 
																						txtDiasTrabajados.Text, 
																						txtViajesRealizados.Text,
																						totalIngresos.ToString(),
																						txtCheque.Text, 
																						txtEfectivo.Text, 
																						txtEnvio.Text, 
																						subtotalviajesneto);
			}
		}
		#endregion
		
		#region METODO PRINCIPAL	
		public void MetodoPrincipalPDF(int x)
		{
			if(dtOperador.RowCount>1)
			{
				txtAlias.Text = dtOperador.Rows[x].Cells[1].Value.ToString();
				ckBono.Checked = false;
				Alias = dtOperador.Rows[x].Cells[1].Value.ToString();
				IdOperador = (Convert.ToInt32(dtOperador.Rows[x].Cells[0].Value));
				foraneo = dtOperador.Rows[x].Cells[2].Value.ToString();
				
				LimpiarCampos();
				// Puede ser
				CalculoDiasTrabajados();
				
				DatosImpuestosTotal(x);
				BorradoRow();
				DatosOperadorPDF(x);
				
				AdaptadorNormales(x);
				AdaptadorEspeciales(x);
				AdaptadorGuardia(x);
				AdaptadorReconocimientos(x);
				AdaptadorCancelacion(x);
				AdaptadorApoyos(x);
				AdaptadorPRendimiento(x);
				AdaptadorDescuentos(x);
				AdaptadorPrestamos(x);
				CalculoPagare(x);
				AdaptadorCausas(x);
				AdaptadorChoque(x);
				AdaptadorTaxi(x);
				AdaptadorIngresos(x);
				TraerBono(x);
				SumaViajesNormales(dataViajesNormales);
				SumaViajesEspeciales();
				PreciosRutas();
				Matriz(x);
				CasetasTotal();
				
				SumaCostosViajes();
				SumaCostosViajesE();
				SumaCostosViajesG();
				SumaCostosReconocimientso();
				SumaCostosApoyos();
				SumaCostosPRendimiento();
				
				ContadorViajes();
				ContadorViajesE();
				ContadorViajesG();
				ConteoEmpresasPDF(x);
				ValorBono();
				CalcularTotales();
			}
		}
		#endregion
		
		#region METODO CREACION-PDF
		void PDF()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Nomina "+Fechecarpeta);
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				DatosOperadorPDF(x);
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Nomina "+Fechecarpeta+@"\"+Alias+" Nomina.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				GenerarDocumentoDinamicamente(doc, writer);
		        doc.Close();
		        Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Nomina "+Fechecarpeta+@"\"+Alias+" Nomina.pdf");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void ImprimirTodosPDF()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
	        string newPath =  System.IO.Path.Combine(activeDir, "Nomina "+Fechecarpeta);
	        System.IO.Directory.CreateDirectory(newPath);
	        
			Document doc = new Document(PageSize.LETTER, 15, 15, 10, 10);
				try
				{			
					FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Nomina "+Fechecarpeta+@"\Transportes LAR (Nominas).pdf",
						                                 FileMode.OpenOrCreate,
						                                 FileAccess.ReadWrite,
						                                 FileShare.ReadWrite);
					PdfWriter writer = PdfWriter.GetInstance(doc, file);		
					doc.Open();
					for(x=0; x<dtOperador.Rows.Count; x++)
					{
						IdNom = 0;
						principal.progressbarPrin.Minimum = 1;
			    		principal.progressbarPrin.Maximum = dtOperador.Rows.Count; 
			    		
						if(x>0)
							dtOperador.Rows[x-1].Selected = false;
						
						dtOperador.Rows[x].Selected = true;
						
						MetodoPrincipalPDF(this.x);
						Guardar(x);
						GenerarDocumentoDinamicamente(doc, writer);
						doc.NewPage();
						principal.progressbarPrin.Increment(1);
					}
					principal.progressbarPrin.Value = principal.progressbarPrin.Minimum;	
			        doc.Close();
			        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Nomina "+Fechecarpeta+@"\Transportes LAR (Nominas).pdf"));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
		}
		
		void FormatoDirectorioCaritasCamion(string vehiculo)
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Directorio "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				DatosOperadorPDF(x);
				Document doc = new Document(PageSize.LETTER, 10, 10, 30, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Camiones.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				DirectorioIlustradoPDF(doc, writer, vehiculo, "1");
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Camiones.pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void FormatoDirectorioCaritasCamioneta(string vehiculo)
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Directorio "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				DatosOperadorPDF(x);
				Document doc = new Document(PageSize.LETTER, 10, 10 ,30, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Camioneta.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				DirectorioIlustradoPDF(doc, writer, vehiculo, "1");
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Camioneta.pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void FormatoDirectorioCaritasAlfabetico(string vehiculo)
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Directorio "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				DatosOperadorPDF(x);
				Document doc = new Document(PageSize.LETTER, 10, 10 ,30, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Alfabético.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				DirectorioIlustradoPDF(doc, writer, vehiculo, "1");
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Alfabético.pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void FormatoDirectorioCaritasVentas(string vehiculo)
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Directorio "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				DatosOperadorPDF(x);
				Document doc = new Document(PageSize.LETTER, 10, 10 ,30, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Ventas.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				DirectorioIlustradoPDF(doc, writer, vehiculo, "2");
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio Ilustrado Ventas.pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		void FormatoDirectorioTelefonico()
		{
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "Directorio "+DateTime.Now.ToString("dd-MM-yyyy"));
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				DatosOperadorPDF(x);
				Document doc = new Document(PageSize.LETTER, 10, 10 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio telefónico.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				DirectorioTelefonicoPDF(doc, writer);
		        doc.Close();
		        Process.Start((System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Directorio "+DateTime.Now.ToString("dd-MM-yyyy")+@"\Directorio telefónico.pdf"));
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion
		
		#region DIA SEMANA
		public void DiaSemana()
		{
			DateTime DiaSemanaNomina1;
			DiaNomina1 = "";
			DiaSemanaNomina1 = (Convert.ToDateTime(FechaInicio));
			DateTime DiaSemanaNomina2;
			DiaNomina2 = "";
			DiaSemanaNomina2 = (Convert.ToDateTime(FechaCorte));
			DiaNomina1 = DiaSemanaNomina1.DayOfWeek.ToString();
			DiaNomina2 = DiaSemanaNomina2.DayOfWeek.ToString();
			
					if(DiaNomina1 == "Monday")
						DiaNomina1 = "Lunes";
					else if(DiaNomina1 == "Tuesday")
						DiaNomina1 = "Martes";
					else if(DiaNomina1 == "Wednesday")
						DiaNomina1 = "Miercoles";
					else if(DiaNomina1 == "Thursday")
						DiaNomina1 = "Jueves";
					else if(DiaNomina1 == "Friday")
						DiaNomina1 = "Viernes";
					else if(DiaNomina1 == "Saturday")
						DiaNomina1 = "Sabado";
					else if(DiaNomina1 == "Sunday")
						DiaNomina1 = "Domingo";

					if(DiaNomina2 == "Monday")
						DiaNomina2 = "Lunes";
					else if(DiaNomina2 == "Tuesday")
						DiaNomina2 = "Martes";
					else if(DiaNomina2 == "Wednesday")
						DiaNomina2 = "Miercoles";
					else if(DiaNomina2 == "Thursday")
						DiaNomina2 = "Jueves";
					else if(DiaNomina2 == "Friday")
						DiaNomina2 = "Viernes";
					else if(DiaNomina2 == "Saturday")
						DiaNomina2 = "Sabado";
					else if(DiaNomina2 == "Sunday")
						DiaNomina2 = "Domingo";
		}
		#endregion

		#region CARGAR_TABCONTROL
		void CargarTabPage()
		{
			tabViajes.SelectedIndex = 0;
			tabViajes.SelectedIndex = 1;
			tabViajes.SelectedIndex = 2;
			tabViajes.SelectedIndex = 3;
			tabViajes.SelectedIndex = 4;
			tabViajes.SelectedIndex = 5;
			tabViajes.SelectedIndex = 6;
			tabViajes.SelectedIndex = 7;
			tabViajes.SelectedIndex = 8;
			tabViajes.SelectedIndex = 9;
			tabViajes.SelectedIndex = 10;
			tabViajes.SelectedIndex = 0;
		}
		#endregion
		
		#region ADAPTADORES
		public void AdaptadorOperadorAll()
		{
			int contador = 0;
			dtOperador.Rows.Clear();
			dtOperador.ClearSelection();
			
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where tipo_empleado='OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' order by alias");			
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador.Rows.Add();
				dtOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador.Rows[contador].Cells[1].Value = conn.leer["Alias_Op"].ToString();
				dtOperador.Rows[contador].Cells[2].Value = conn.leer["foraneo"].ToString();
				
				if(dtOperador.Rows[contador].Cells[2].Value.ToString()=="1")
					dtOperador.Rows[contador].Cells[1].Style.BackColor = Color.Gold;
				++contador;
			}
			conn.conexion.Close();
		}
		
		public void AdaptadorOperador()
		{
			int contador = 0;
			dtOperador.Rows.Clear();
			dtOperador.ClearSelection();
			
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' order by alias");			
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador.Rows.Add();
				dtOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador.Rows[contador].Cells[1].Value = conn.leer["Alias_Op"].ToString();
				dtOperador.Rows[contador].Cells[2].Value = conn.leer["foraneo"].ToString();
				
				if(dtOperador.Rows[contador].Cells[2].Value.ToString()=="1")
					dtOperador.Rows[contador].Cells[1].Style.BackColor = Color.Gold;
				++contador;
			}
			conn.conexion.Close();
		}
		
		public void AdaptadorOperadorNomina()
		{
			int contador = 0;
			dtOperador.Rows.Clear();
			dtOperador.ClearSelection();
			
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where Estatus='1' AND tipo_empleado='OPERADOR' and Alias not in( 'Admvo','ADMINOO') order by alias");
			/*
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where Estatus='1' AND tipo_empleado='OPERADOR' and Alias not in( 'Admvo', 'ADRIAN', 'ANGUIANO', 'BRUNO', 'HUMBERTO', 'JAVIER', 'MARIN', 'OSCAR', 'RAMON', 'ROCHA') order by alias");
			
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' order by alias");
			
			*/
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador.Rows.Add();
				dtOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador.Rows[contador].Cells[1].Value = conn.leer["Alias_Op"].ToString();
				dtOperador.Rows[contador].Cells[2].Value = conn.leer["foraneo"].ToString();
				
				if(dtOperador.Rows[contador].Cells[2].Value.ToString()=="1")
					dtOperador.Rows[contador].Cells[1].Style.BackColor = Color.Gold;
				++contador;
			}
			conn.conexion.Close();
		}
		
		public void AdaptadorOperadorPrestamos()
		{
			int contador = 0;
			dtOperador.Rows.Clear();
			dtOperador.ClearSelection();
			
			
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' order by alias");			
					
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador.Rows.Add();
				dtOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador.Rows[contador].Cells[1].Value = conn.leer["Alias_Op"].ToString();
				dtOperador.Rows[contador].Cells[2].Value = conn.leer["foraneo"].ToString();
				
				if(dtOperador.Rows[contador].Cells[2].Value.ToString()=="1")
					dtOperador.Rows[contador].Cells[1].Style.BackColor = Color.Gold;
				++contador;
			}
			conn.conexion.Close();
		}
		
		void AdaptadorOperadorPorCamion()
		{
			dtOperador.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.ID, O.alias as Alias_Op, O.foraneo " +
			                                                                               "from OPERADOR O, Vehiculo V, ASIGNACIONUNIDAD A " +
			                                                                               "where O.ID=A.ID_OPERADOR AND V.ID=A.ID_UNIDAD AND O.Estatus='1' AND O.tipo_empleado='OPERADOR' and O.Alias!='Admvo' and Alias!='ADMINOO' and V.tipo_unidad='camión' " +
			                                                                               "order by tipo_unidad, V.Numero");
		}
		
		void AdaptadorOperadorPorCamioneta()
		{
			dtOperador.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.ID, O.alias as Alias_Op, O.foraneo " +
			                                                                               "from OPERADOR O, Vehiculo V, ASIGNACIONUNIDAD A " +
			                                                                               "where O.ID=A.ID_OPERADOR AND V.ID=A.ID_UNIDAD AND O.Estatus='1' AND O.tipo_empleado='OPERADOR' and O.Alias!='Admvo' and Alias!='ADMINOO' and V.tipo_unidad='camioneta' " +
			                                                                               "order by V.Numero");
		}
		
		void AdaptadorNormales(int x)
		{
			int contador = 0;
			dataViajesNormales.Rows.Clear();
			dataViajesNormales.ClearSelection();
			
			String Conss = "select R.ID, R.VELADA, C.Empresa as Empresa, R.Nombre as Ruta, O.turno As Turno, O.fecha as Fecha, OO.vehiculo as Vehiculo, R.foranea, R.sentido as Sentido, R.Kilometros, R.Tiempo, R.Tipo, R.HoraInicio, R.Hora_LLEGADA "+
	                               "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
	                               "where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
	                               "and OO.id_operador=OP.ID and C.Empresa!='Especiales' and O.estatus='1' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and oo.id_operador ="+dtOperador[0,x].Value.ToString()+" order by O.fecha, R.HoraInicio desc";
			//23/01/2018	05/02/2018
			/*if (dtOperador[0,x].Value.ToString() == "773" && FechaInicio == "23/01/2018" && FechaCorte == "05/02/2018") {
				Conss = "select R.ID, R.VELADA, C.Empresa as Empresa, R.Nombre as Ruta, O.turno As Turno, O.fecha as Fecha, OO.vehiculo as Vehiculo, R.foranea, R.sentido as Sentido, R.Kilometros, R.Tiempo, R.Tipo, R.HoraInicio, R.Hora_LLEGADA "+
	                               "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
	                               "where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
	                               "and OO.id_operador=OP.ID and C.Empresa!='Especiales' and O.estatus='1' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and oo.id_operador ="+dtOperador[0,x].Value.ToString()+"  and R.Nombre != 'LAZARO CARDENAS' order by O.fecha, R.HoraInicio desc";	
			}*/
			
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
				dataViajesNormales.Rows[contador].Cells[9].Value = "Sencillo";
				dataViajesNormales.Rows[contador].Cells[9].Style.BackColor = Color.MediumBlue;
				dataViajesNormales.Rows[contador].Cells[10].Value = conn.leer["Kilometros"].ToString();
				dataViajesNormales.Rows[contador].Cells[11].Value = conn.leer["Tiempo"].ToString();
				dataViajesNormales.Rows[contador].Cells[12].Value = conn.leer["Tipo"].ToString();
				dataViajesNormales.Rows[contador].Cells[13].Value = conn.leer["HoraInicio"].ToString();
				dataViajesNormales.Rows[contador].Cells[14].Value = conn.leer["Hora_llegada"].ToString();
				dataViajesNormales.Rows[contador].Cells[15].Value = "";
				if( conn.leer["VELADA"].ToString().Contains("1"))
					dataViajesNormales.Rows[contador].Cells[16].Value = "SI";
				else
					dataViajesNormales.Rows[contador].Cells[16].Value =  "NO";
				
				try{
					if(dataViajesNormales.Rows[contador].Cells[14].Value.ToString() != "" && dataViajesNormales.Rows[contador].Cells[13].Value.ToString() != ""){
						TimeSpan dif;
						string cadena = dataViajesNormales.Rows[contador].Cells[14].Value.ToString();
						string[] datos = cadena.Split(':');
						int hora = Convert.ToInt16(datos[0]);
						string minuto = datos[1];
						
						string cadena2 = dataViajesNormales.Rows[contador].Cells[13].Value.ToString();
						string[] datos2 = cadena2.Split(':');
						int hora2 = Convert.ToInt16(datos2[0]);
						string minuto2 = datos2[1];
						if(hora == 00 && hora2 == 23){
							hora = 23;
							hora2 = 22;
							dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);
						}else if(hora == 00 && hora2 == 22){
							hora = 23;
							hora2 = 21;
							dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
						}else if(hora == 01 && hora2 == 23){
							hora = 23;
							hora2 = 22;
							dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
						}else{
							dif = Convert.ToDateTime(dataViajesNormales.Rows[contador].Cells[14].Value) - Convert.ToDateTime(dataViajesNormales.Rows[contador].Cells[13].Value);						
						}
						dataViajesNormales.Rows[contador].Cells[15].Value = dif.TotalMinutes;
					}
				}catch(Exception){
					
				}					
				
				/*if(dataViajesNormales.Rows[contador].Cells[12].Value.ToString() != "EXT"){
					string cadena = dataViajesNormales.Rows[contador].Cells[14].Value.ToString();
					string[] datos = cadena.Split(':');
					int hora = Convert.ToInt16(datos[0]);
					string minuto = datos[1];
					
					string cadena2 = dataViajesNormales.Rows[contador].Cells[13].Value.ToString();
					string[] datos2 = cadena2.Split(':');
					int hora2 = Convert.ToInt16(datos2[0]);
					string minuto2 = datos2[1];
					if(hora == 00){
						hora = 23;
						hora2 = 22;						
						dataViajesNormales.Rows[contador].Cells[14].Value = hora +":"+ minuto+":00";
						dataViajesNormales.Rows[contador].Cells[13].Value = hora2 +":"+ minuto2+":00";
					}	
				}*/
				++contador;
			}
			conn.conexion.Close();
			dataViajesNormales.AutoSize=true;
		}
		
		void AdaptadorEspeciales(int x)
		{
			int contador = 0;
			
			dataViajesEspeciales.Rows.Clear();
			dataViajesEspeciales.ClearSelection();
			
			string consulta = "select R.ID, O.fecha as Fecha, CS.Nombre as Cliente, RE.DESTINO as Destino, O.turno As Turno, OO.vehiculo as Vehiculo, R.foranea,  R.extra, R.sentido as Sentido, R.Kilometros, R.Tiempo, R.Tipo, RE.C_CASETAS, case "+
                                        "when OO.vehiculo = 'Camión' or OO.vehiculo = 'Camion' then R.SencilloCamion " +
	                               		"when OO.vehiculo = 'Camioneta' then R.SencilloCamioneta " +
	                               		"end as Costo "+
                                        "from dbo.CLIENTE C with(nolock) "+
                                        "INNER JOIN dbo.RUTA_ESPECIAL RE with(nolock) on C.ID=RE.ID_C "+
                                        "INNER JOIN dbo.RUTA R with(nolock) on C.ID=R.IdSubEmpresa "+
                                        "INNER JOIN dbo.OPERACION O with(nolock) on R.ID=O.id_ruta  "+
                                        "INNER JOIN dbo.OPERACION_OPERADOR OO with(nolock) on O.id_operacion=OO.id_operacion "+
                                        "INNER JOIN dbo.OPERADOR OP with(nolock) on OO.id_operador=OP.ID "+
                                        "INNER JOIN dbo.ContactoServicio CS with(nolock) on RE.ID_C = CS.IdCliente and C.ID=CS.IdCliente "+
                                        "where O.Estatus='1' and " +
										"RE.FECHA_REGRESO between '"+FechaInicio+"' AND '"+FechaCorte+"' and "+
                                        "oo.id_operador ="+dtOperador[0,x].Value;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataViajesEspeciales.Rows.Add();
				dataViajesEspeciales.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[2].Value = Convert.ToDateTime(conn.leer["Fecha"]).ToShortDateString();
				dataViajesEspeciales.Rows[contador].Cells[3].Value = conn.leer["Cliente"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[4].Value = conn.leer["Destino"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[5].Value = conn.leer["Sentido"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[6].Value = conn.leer["Turno"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[7].Value = conn.leer["Vehiculo"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[8].Value = conn.leer["foranea"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[9].Value = conn.leer["Costo"].ToString();
				dataViajesEspeciales.Rows[contador].Cells[10].Value = "Sencillo";
				dataViajesEspeciales.Rows[contador].Cells[1].Style.BackColor = Color.MediumBlue;
				
				if(conn.leer["C_CASETAS"].ToString()!="N/A")
					dataViajesEspeciales.Rows[contador].Cells[11].Value = conn.leer["C_CASETAS"];
				else
					dataViajesEspeciales.Rows[contador].Cells[11].Value = "0.0";
				++contador;
			}
			conn.conexion.Close();
			
			dataViajesEspeciales.AutoSize=true;
			if(dataViajesEspeciales.RowCount<=0)
			{
				dataViajesEspeciales.Visible = false;
				lblEspeciales.Visible = false;
			}
			else
			{
				dataViajesEspeciales.Visible = true;
				lblEspeciales.Visible = true;
			}
		}
		
		void AdaptadorReconocimientos(int x)
		{
			int contador = 0;			
			String consulta = "select RR.ID, RR.ID_RUTA, RR.ID_OPERADOR, RR.ID_OP_MUESTRA, C.Empresa as Empresa, R.Nombre as Ruta, RR.turno As Turno, RR.DIA " +
			                      "from CLIENTE C, RUTA R, OPERADOR OP, RECONOCIMIENTO_RUTA RR " +
			                      "where C.ID=R.IdSubEmpresa and R.ID=RR.ID_RUTA and OP.ID=RR.ID_OPERADOR and C.Empresa!='Especiales' and RR.DIA between '"+FechaInicio+"' AND '"+FechaCorte+"' and RR.ID_OPERADOR="+dtOperador[0,x].Value+" order by RR.DIA";
			
			dataReconocimientos.Rows.Clear();
			dataReconocimientos.ClearSelection();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{				
				dataReconocimientos.Rows.Add();
				dataReconocimientos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataReconocimientos.Rows[contador].Cells[1].Value = conn.leer["ID_RUTA"].ToString();
				dataReconocimientos.Rows[contador].Cells[2].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataReconocimientos.Rows[contador].Cells[3].Value = new Conexion_Servidor.Operador.SQL_Operador().getOpAlias(conn.leer["ID_OPERADOR"].ToString());//conn.leer["ID_OPERADOR"].ToString(); se cambio debido a que el puro id no servia de nada
				dataReconocimientos.Rows[contador].Cells[4].Value = new Conexion_Servidor.Operador.SQL_Operador().getOpAlias(conn.leer["ID_OP_MUESTRA"].ToString());//conn.leer["ID_OP_MUESTRA"].ToString();
				dataReconocimientos.Rows[contador].Cells[5].Value = conn.leer["Empresa"].ToString();
				dataReconocimientos.Rows[contador].Cells[6].Value = conn.leer["Ruta"].ToString();
				dataReconocimientos.Rows[contador].Cells[7].Value = conn.leer["Turno"].ToString();
				dataReconocimientos.Rows[contador].Cells[8].Value = dataValorImporte.Rows[7].Cells[2].Value.ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataReconocimientos.AutoSize=true;
			if(dataReconocimientos.RowCount<=0)
			{
				dataReconocimientos.Visible = false;
				lblReconocimiento.Visible = false;
			}
			else
			{
				dataReconocimientos.Visible = true;
				lblReconocimiento.Visible = true;
			}
		}
		
		void AdaptadorGuardia(int x)
		{
			int contador = 0;
			dataGuardia.Rows.Clear();
			dataGuardia.ClearSelection();
			
			conn.getAbrirConexion("select G.ID, C.Empresa as Empresa, G.turno As Turno, G.DIA, G.TIPO " +
			                      "from CLIENTE C, OPERADOR OP, GUARDIA G " +
			                      "where C.ID=G.ID_SUBEMPRESA and OP.ID=G.ID_OPERADOR and C.Empresa!='Especiales' and G.DIA between '"+FechaInicio+"' AND '"+FechaCorte+"' and G.ID_OPERADOR="+dtOperador[0,x].Value+" order by G.DIA");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataGuardia.Rows.Add();
				dataGuardia.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataGuardia.Rows[contador].Cells[1].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataGuardia.Rows[contador].Cells[2].Value = conn.leer["Empresa"].ToString();
				dataGuardia.Rows[contador].Cells[4].Value = conn.leer["Turno"].ToString();
				dataGuardia.Rows[contador].Cells[3].Value = conn.leer["TIPO"].ToString();
				dataGuardia.Rows[contador].Cells[5].Value = 0;
				++contador;
			}
			conn.conexion.Close();
			
			LlenadoDtGuardias();
			dataGuardia.AutoSize=true;
			if(dataGuardia.RowCount<=0)
			{
				dataGuardia.Visible = false;
				lblGuardia.Visible = false;
			}
			else
			{
				dataGuardia.Visible = true;
				lblGuardia.Visible = true;
			}
		}
		
		void AdaptadorCancelacion(int x)
		{
			int contador = 0;
			dataCancelacion.Rows.Clear();
			dataCancelacion.ClearSelection();
			
			conn.getAbrirConexion("select CP.ID, CP.ID_RUTA, R.Nombre, CP.turno, CP.Fecha " +
			                      "from RUTA R, OPERADOR OP, CANCELACION_PUNTO CP " +
			                      "where R.ID=CP.ID_RUTA and OP.ID=CP.ID_OPERADOR and CP.Fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and CP.ID_OPERADOR="+dtOperador[0,x].Value+" order by CP.Fecha");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataCancelacion.Rows.Add();
				dataCancelacion.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataCancelacion.Rows[contador].Cells[1].Value = conn.leer["ID_RUTA"].ToString();
				dataCancelacion.Rows[contador].Cells[2].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dataCancelacion.Rows[contador].Cells[3].Value = conn.leer["Nombre"].ToString();
				dataCancelacion.Rows[contador].Cells[4].Value = conn.leer["turno"].ToString();
				dataCancelacion.Rows[contador].Cells[5].Value = dataValorImporte.Rows[6].Cells[2].Value.ToString();
				++contador;
			}
			conn.conexion.Close();
			dataCancelacion.AutoSize=true;
			if(dataCancelacion.RowCount<=0)
			{
				dataCancelacion.Visible = false;
				lblCancelacion.Visible = false;
			}
			else
			{
				dataCancelacion.Visible = true;
				lblCancelacion.Visible = true;
			}
		}

		void AdaptadorApoyos(int x)
		{
			int contador = 0;
			String consulta = "select A.ID, A.ID_OP_APOYO, A.turno, A.DIA, A.TIPO, A.COMENTARIOS, A.ID_RUTA " +
			                      "from APOYOS A " +
			                      "where A.DIA between '"+FechaInicio+"' AND '"+FechaCorte+"' and A.ID_OP_APOYO="+dtOperador[0,x].Value+" order by A.DIA";
			
			dataApoyos.Rows.Clear();
			dataApoyos.ClearSelection();
			try{
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataApoyos.Rows.Add();
				dataApoyos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataApoyos.Rows[contador].Cells[2].Value = conn.leer["ID_OP_APOYO"].ToString();
				dataApoyos.Rows[contador].Cells[3].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataApoyos.Rows[contador].Cells[5].Value = conn.leer["turno"].ToString();
				dataApoyos.Rows[contador].Cells[6].Value = conn.leer["TIPO"].ToString();
				dataApoyos.Rows[contador].Cells[7].Value = conn.leer["COMENTARIOS"].ToString();
				dataApoyos.Rows[contador].Cells[8].Value = dataValorImporte.Rows[5].Cells[2].Value.ToString();
				if(conn.leer["ID_RUTA"].ToString() != "0"){
					
					dataApoyos.Rows[contador].Cells[1].Value = conn.leer["ID_RUTA"].ToString();
				
					if(conn.leer["TIPO"].ToString() == "RUTA CORTA")
					{
						dataApoyos.Rows[contador].Cells[8].Value = dataValorImporte.Rows[8].Cells[2].Value.ToString();
					}else if(conn.leer["TIPO"].ToString() == "RUTA MEDIA")
					{					
						dataApoyos.Rows[contador].Cells[8].Value = dataValorImporte.Rows[9].Cells[2].Value.ToString();
					}else if(conn.leer["TIPO"].ToString() == "RUTA COMPLETA")
					{
						//dataApoyos.Rows[contador].Cells[8].Value = dataValorImporte.Rows[10].Cells[2].Value.ToString();				
						Conexion_Servidor.SQL_Conexion conn1 = new Conexion_Servidor.SQL_Conexion();
							TimeSpan dif;
							double tiempo = 0;
							int domingo = 0;
							int velada = 0;
							DateTime DiaSemanaFacturacion;
							String DiaFacturacion = "";
							
							String TipoRuta= "";
							String VEHUCLO = "";
							Double km = 0.0;
							String inicio = "";
							String fin = "";
							int forania = 0;
							String consulta1 = "";
							
							String fecha = conn.leer["DIA"].ToString().Substring(0,10);
							DiaSemanaFacturacion = Convert.ToDateTime(fecha);
							DiaFacturacion = DiaSemanaFacturacion.DayOfWeek.ToString();
							
							consulta1 = "select top (1) R.*, OO.vehiculo from RUTA R, OPERACION O, OPERACION_OPERADOR OO where R.ID = O.id_ruta  AND O.id_operacion = OO.id_operacion AND O.estatus = '1' AND R.ID =" + conn.leer["ID_RUTA"].ToString();
							conn1.getAbrirConexion(consulta1);
							conn1.leer=conn1.comando.ExecuteReader();
							while(conn1.leer.Read())
							{
								if(conn1.leer["TIPO"].ToString() == "VL"){
									velada = 1;
								}
								TipoRuta= conn1.leer["TIPO"].ToString();
								VEHUCLO = conn1.leer["vehiculo"].ToString();
								km = Convert.ToDouble(conn1.leer["KILOMETROS"]);
								inicio = conn1.leer["HORAINICIO"].ToString();
								fin = conn1.leer["HORA_LLEGADA"].ToString();
								forania = Convert.ToInt32(conn1.leer["FORANEA"]);
							}
							conn1.conexion.Close();
							
								
							if(DiaFacturacion == "Sunday")
							{					
								domingo = 1;					
							}
							
							
							string cadena = fin;
							string[] datos = cadena.Split(':');
							int hora = Convert.ToInt16(datos[0]);
							string minuto = datos[1];
							
							string cadena2 = inicio;
							string[] datos2 = cadena2.Split(':');
							int hora2 = Convert.ToInt16(datos2[0]);
							string minuto2 = datos2[1];
							if(hora == 00 && hora2 == 23){
								hora = 23;
								hora2 = 22;
								dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);
							}else if(hora == 00 && hora2 == 22){
								hora = 23;
								hora2 = 21;
								dif = Convert.ToDateTime(hora+":"+minuto) - Convert.ToDateTime(hora2+":"+minuto2);	
							}else{
								dif = Convert.ToDateTime(fin) - Convert.ToDateTime(inicio);
							}
						tiempo = dif.TotalMinutes;
						
						// Quitar bonos de domingos, velada, forania
						domingo = 0;
						velada = 0;
						forania = 0;
						
						switch (tipoUnidad) {
							case "Camión": dataApoyos.Rows[contador].Cells[8].Value = "100";
										break;								
							case "Camioneta": dataApoyos.Rows[contador].Cells[8].Value = "90";
										break;
						}
						
						try{
							//dataApoyos.Rows[contador].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas("Sencillo", VEHUCLO, km, tiempo, domingo, velada, forania);
							
							//Se modifico el 14-02-2018, debido a que los precios son 130 Camión y 115 Camioneta) y cambian a 100 y 90 
							//dataApoyos.Rows[contador].Cells[8].Value = new Conexion_Servidor.Nomina.SQL_Nomina().PreciosRutas("Completo", tipoUnidad, km, tiempo, domingo, velada, forania);
						}catch(Exception ex){
							MessageBox.Show("Ocurrió una Excepcion "+ex);
						}finally{
							if(conn1.conexion != null)
							conn1.conexion.Close();
						}						
					}
					
			}else{
				dataApoyos.Rows[contador].Cells[8].Value = dataValorImporte.Rows[5].Cells[2].Value.ToString();
			}				
				++contador;
			}
			}
			catch{}
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
			
			try{
				for(int l=0; l < dataApoyos.RowCount; l++ ){
					if(dataApoyos.Rows[l].Cells[1].Value == null){
						dataApoyos.Rows[l].Cells[9].Value = "";
					}else{
						consulta = "SELECT C.Empresa FROM RUTA R JOIN CLIENTE C ON C.ID = R.IdSubEmpresa WHERE R.ID = " + dataApoyos.Rows[l].Cells[1].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
							dataApoyos.Rows[l].Cells[9].Value = conn.leer["Empresa"].ToString();		
						conn.conexion.Close();
					}
				}
			}catch(Exception){	}			
		}
		
		void AdaptadorPRendimiento(int x)
		{
			int contador = 0;
			dataRendimiento.Rows.Clear();
			dataRendimiento.ClearSelection();
			
			conn.getAbrirConexion("select P.ID_PR, P.ID_RUTA, P.ID_OPERADOR, P.ID_OP_SUPERVISOR, R.Nombre, R.CompletoCamion, P.turno, P.DIA " +
			                      "from RUTA R, OPERADOR OP, PRUEBA_RENDIMIENTO P " +
			                      "where R.ID=P.ID_RUTA and OP.ID=P.ID_OPERADOR and P.DIA between '"+FechaInicio+"' AND '"+FechaCorte+"' and P.ID_OP_SUPERVISOR="+dtOperador[0,x].Value+" order by P.DIA");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataRendimiento.Rows.Add();
				dataRendimiento.Rows[contador].Cells[0].Value = conn.leer["ID_PR"].ToString();
				dataRendimiento.Rows[contador].Cells[1].Value = conn.leer["ID_RUTA"].ToString();
				dataRendimiento.Rows[contador].Cells[2].Value = conn.leer["ID_OPERADOR"].ToString();
				dataRendimiento.Rows[contador].Cells[3].Value = conn.leer["ID_OP_SUPERVISOR"].ToString();
				dataRendimiento.Rows[contador].Cells[4].Value = conn.leer["DIA"].ToString().Substring(0,10);
				dataRendimiento.Rows[contador].Cells[5].Value = conn.leer["Nombre"].ToString();
				dataRendimiento.Rows[contador].Cells[6].Value = conn.leer["turno"].ToString();
				dataRendimiento.Rows[contador].Cells[7].Value = ((Convert.ToDouble(conn.leer["CompletoCamion"]))+Convert.ToDouble(dataValorImporte.Rows[3].Cells[2].Value.ToString())).ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataRendimiento.AutoSize=true;
			if(dataRendimiento.RowCount<=0)
			{
				dataRendimiento.Visible = false;
				lblPruebas.Visible = false;
			}
			else
			{
				dataRendimiento.Visible = true;
				lblPruebas.Visible = true;
			}
		}
		
		void AdaptadorCausas(int x)
		{
			int contador = 0;
			dataBono.Rows.Clear();
			dataBono.ClearSelection();
			
			conn.getAbrirConexion("select P.FECHA, P.TIPO, H.MOTIVO " +
			                      "from NUEVO_HISTORIAL_BONO_OPERADOR H, OPERADOR O, PERDIDA_BONO P " +
			                      "where H.ID_O=O.ID AND H.ID=P.Id_Historial AND H.FECHA_INICIO='"+FechaInicio+"' AND H.FECHA_FIN='"+FechaCorte+"' and O.ID="+dtOperador[0,x].Value);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataBono.Rows.Add();
				dataBono.Rows[contador].Cells[0].Value = conn.leer["FECHA"].ToString().Substring(0,10);
				dataBono.Rows[contador].Cells[1].Value = conn.leer["TIPO"].ToString();
				dataBono.Rows[contador].Cells[2].Value = conn.leer["MOTIVO"].ToString();
				dataBono.Rows[contador].Cells[3].Value = "0";
				dataBono.Rows[contador].Cells[4].Value = "0";
				++contador;
			}
			conn.conexion.Close();
			
			for(int s=0; s<dataBono.RowCount; s++)
			{
				conn.getAbrirConexion("select count(P.Id_Historial) as Perdida " +
				                      "from NUEVO_HISTORIAL_BONO_OPERADOR H, OPERADOR O, PERDIDA_BONO P " +
				                      "where H.ID_O=O.ID AND H.ID=P.Id_Historial and P.TIPO='"+dataBono.Rows[s].Cells[1].Value.ToString()+"' and O.ID="+dtOperador[0,x].Value);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataBono.Rows[s].Cells[3].Value = conn.leer["Perdida"].ToString();
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select count(H.ID) as Boni " +
				                      "from NUEVO_HISTORIAL_BONO_OPERADOR H, OPERADOR O, PERDIDA_BONO P " +
				                      "where H.ID_O=O.ID AND H.ID=P.Id_Historial and H.BONIFICACION='1' and P.TIPO='"+dataBono.Rows[s].Cells[1].Value.ToString()+"' and O.ID="+dtOperador[0,x].Value);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataBono.Rows[s].Cells[4].Value = conn.leer["Boni"].ToString();
				}
				conn.conexion.Close();
			}
			dataBono.AutoSize=true;
			if(dataBono.RowCount<=0)
			{
				dataBono.Visible = false;
				lblCausa.Visible = false;
			}
			else
			{
				dataBono.Visible = true;
				lblCausa.Visible = true;
			}
		}
		
		void AdaptadorChoque(int x)
		{
			int contador = 0;
			dataChoque.Rows.Clear();
			dataChoque.ClearSelection();
			String sentencia = "select DT.FECHA, D.OBSERVACION, D.IMPORTE_TOTAL " +
						"from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O " +
						"where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='3' and DT.FLUJO!='5' "+
						"and D.DESCRIPCION like '%CHOQUE%' and DT.FECHA between '"+DateTime.Now.AddDays(-180).ToString("dd-MM-yyyy")+"' AND '"+FechaCorte+"' and D.ID_OPERADOR="+dtOperador[0,x].Value;
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataChoque.Rows.Add();
				dataChoque.Rows[contador].Cells[0].Value = conn.leer["FECHA"].ToString().Substring(0,10);
				dataChoque.Rows[contador].Cells[1].Value = conn.leer["OBSERVACION"].ToString();
				dataChoque.Rows[contador].Cells[2].Value = conn.leer["IMPORTE_TOTAL"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataChoque.AutoSize=true;
			if(dataChoque.RowCount<=0)
			{
				dataChoque.Visible = false;
				lblChoque.Visible = false;
			}
			else
			{
				dataChoque.Visible = true;
				lblChoque.Visible = true;
			}
		}
		
		void AdaptadorTaxi(int x)
		{
			int contador = 0;
			dataTaxis.Rows.Clear();
			dataTaxis.ClearSelection();
			String sentencia = "select DT.FECHA, D.OBSERVACION, D.IMPORTE_TOTAL " +
								"from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O " +
								"where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='3' AND DT.FLUJO!='5' "+
								"and D.DESCRIPCION like '%TAXI%' and DT.FECHA between '"+DateTime.Now.AddDays(-180).ToString("dd-MM-yyyy")+"' AND '"+FechaCorte+"' and D.ID_OPERADOR="+dtOperador[0,x].Value;
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataTaxis.Rows.Add();
				dataTaxis.Rows[contador].Cells[0].Value = conn.leer["FECHA"].ToString().Substring(0,10);
				dataTaxis.Rows[contador].Cells[1].Value = "1";
				dataTaxis.Rows[contador].Cells[2].Value = conn.leer["OBSERVACION"].ToString();
				dataTaxis.Rows[contador].Cells[3].Value = ((Convert.ToDouble(conn.leer["IMPORTE_TOTAL"]))*2).ToString();
				dataTaxis.Rows[contador].Cells[4].Value = conn.leer["IMPORTE_TOTAL"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			dataTaxis.AutoSize=true;
			if(dataTaxis.RowCount<=0)
			{
				dataTaxis.Visible = false;
				lbltaxi.Visible = false;
			}
			else
			{
				dataTaxis.Visible = true;
				lbltaxi.Visible = true;
			}
		}
		
		void AdaptadorIngresos(int x)
		{
			int contador = 0;
			totalIngresos = 0.0;
			primavacacional = 0.0;
			dataIngresosExtras.Rows.Clear();
			dataIngresosExtras.ClearSelection();
			
			conn.getAbrirConexion("select V.SALDO, V.NOMBRE, E.ESTATUS "+
	                               "from ESTADO_IMPORTE E, VALOR_IMPORTE V, OPERADOR O "+
	                               "where V.ID=E.ID_VALOR_IMPORTE and O.ID=E.ID_OPERADOR and V.Tipo='Variable' "+
	                               "and E.ID_OPERADOR="+dtOperador[0,x].Value);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["ESTATUS"].ToString()=="1")
				{
					dataIngresosExtras.Rows.Add();
					dataIngresosExtras.Rows[contador].Cells[0].Value = "0";
					dataIngresosExtras.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					if(conn.leer["NOMBRE"].ToString()=="AGUINALDO")
					{
						dataIngresosExtras.Rows[contador].Cells[2].Value = aguinaldoneto.ToString();
						totalIngresos = totalIngresos + aguinaldoneto;
					}
					else
					{
						dataIngresosExtras.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
						totalIngresos = totalIngresos + (Convert.ToDouble(conn.leer["SALDO"]));
					}
					if(conn.leer["NOMBRE"].ToString()=="PRIMA VACACIONAL")
					{
						primavacacional = (Convert.ToDouble(conn.leer["SALDO"]));
					}
					++contador;
				}
				if(conn.leer["ESTATUS"].ToString()!="1" && conn.leer["NOMBRE"].ToString()=="AGUINALDO")
				{
					aguinaldoneto = 0.00;
				}
			}
			conn.conexion.Close();
			
			conn.getAbrirConexion("select I.ID, I.DETALLE, I.IMPORTE " +
			                      "from INGRESO_NOMINA I, NOMINA N " +
			                      "where N.ID=I.ID_NOMINA AND N.fecha_inicio='"+FechaInicio+"' AND N.fecha_fin='"+FechaCorte+"' and N.IdOperador="+dtOperador.Rows[x].Cells[0].Value);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataIngresosExtras.Rows.Add();
				dataIngresosExtras.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataIngresosExtras.Rows[contador].Cells[1].Value = conn.leer["DETALLE"].ToString();
				dataIngresosExtras.Rows[contador].Cells[2].Value = conn.leer["IMPORTE"].ToString();
				totalIngresos = totalIngresos + (Convert.ToDouble(conn.leer["IMPORTE"]));
				++contador;
			}
			conn.conexion.Close();
			
			dataIngresosExtras.AutoSize=true;
			if(dataIngresosExtras.RowCount<=0)
			{
				dataIngresosExtras.Visible = false;
				lblIngresos.Visible = false;
			}
			else
			{
				dataIngresosExtras.Visible = true;
				lblIngresos.Visible = true;
			}
		}
		
		void AdaptadorDescuentos(int x)
		{
			string consulta;
			int contador = 0;
				
			dataDescuentos.Rows.Clear();
			dataDescuentos.ClearSelection();
			
			//ActivoDoctor = new Conexion_Servidor.Anticipos.SQL_Anticipos().MinFecha((Convert.ToInt32(dtOperador.Rows[x].Cells[0].Value)), dtInicio.Value.ToString("yyyy-MM-dd").Substring(0,10), dtCorte.Value.ToString("yyyy-MM-dd").Substring(0,10));
			ActivoDoctor = new Conexion_Servidor.Anticipos.SQL_Anticipos().MinFecha((Convert.ToInt32(dtOperador.Rows[x].Cells[0].Value)), FechaInicio.ToString(), FechaCorte.ToString());
			consulta = "select V.SALDO, V.NOMBRE, E.ESTATUS "+
	                               "from ESTADO_IMPORTE E, VALOR_IMPORTE V, OPERADOR O "+
	                               "where V.ID=E.ID_VALOR_IMPORTE and O.ID=E.ID_OPERADOR and V.Tipo='Extra' "+
	                               "and E.ID_OPERADOR="+dtOperador[0,x].Value;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(Convert.ToDouble(ActivoDoctor)>0 && conn.leer["NOMBRE"].ToString()=="DOCTOR" && conn.leer["ESTATUS"].ToString()=="1")
				{
					dataDescuentos.Rows.Add();
					dataDescuentos.Rows[contador].Cells[0].Value = "0";
					dataDescuentos.Rows[contador].Cells[1].Value = FechaCorte;
					dataDescuentos.Rows[contador].Cells[2].Value = "Periodo";
					dataDescuentos.Rows[contador].Cells[3].Value = "x/x";
					dataDescuentos.Rows[contador].Cells[4].Value = conn.leer["NOMBRE"].ToString();
					dataDescuentos.Rows[contador].Cells[5].Value = conn.leer["SALDO"].ToString();
					++contador;
				}
				else if(conn.leer["NOMBRE"].ToString()!="DOCTOR" && conn.leer["ESTATUS"].ToString()=="1")
				{
					dataDescuentos.Rows.Add();
					dataDescuentos.Rows[contador].Cells[0].Value = "0";
					dataDescuentos.Rows[contador].Cells[1].Value = FechaCorte;
					dataDescuentos.Rows[contador].Cells[2].Value = "Periodo";
					dataDescuentos.Rows[contador].Cells[3].Value = "x/x";
					dataDescuentos.Rows[contador].Cells[4].Value = conn.leer["NOMBRE"].ToString();
					dataDescuentos.Rows[contador].Cells[5].Value = conn.leer["SALDO"].ToString();
					++contador;
				}
			}
			conn.conexion.Close();
			
			if(Convert.ToDouble(telcel)>0)
			{
				dataDescuentos.Rows.Add();
				dataDescuentos.Rows[contador].Cells[0].Value = "0";
				dataDescuentos.Rows[contador].Cells[1].Value = FechaCorte;
				dataDescuentos.Rows[contador].Cells[2].Value = "Periodo";
				dataDescuentos.Rows[contador].Cells[3].Value = "x/x";
				dataDescuentos.Rows[contador].Cells[4].Value = "TELCEL";
				dataDescuentos.Rows[contador].Cells[5].Value = telcel + ".00";
				++contador;
			}
			consulta = "select DT.ID_DESCUENTO, DT.FECHA, D.Observacion, DT.IMPORTE, DT.NOMENCLATURA, D.TIPO "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='5' and FLUJO!='3' "+
				"and DESCRIPCION not like '%PRESTAMO%' AND DESCRIPCION not like '%CHOQUE%' AND DT.FECHA between '"+Convert.ToDateTime(FechaInicio).AddDays(2).ToString("yyyy/MM/dd")+"' AND '"+Convert.ToDateTime(FechaCorte).AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA";
			//  "and DESCRIPCION not like '%PRESTAMO%' AND DESCRIPCION not like '%CHOQUE%' AND DT.FECHA between '"+dtInicio.Value.AddDays(2).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataDescuentos.Rows.Add();
				dataDescuentos.Rows[contador].Cells[0].Value = conn.leer["ID_DESCUENTO"].ToString();
				dataDescuentos.Rows[contador].Cells[1].Value = conn.leer["FECHA"].ToString().Substring(0,10);
				
				if(conn.leer["TIPO"].ToString()=="U")
				dataDescuentos.Rows[contador].Cells[2].Value = "Uniforme";
				else if(conn.leer["TIPO"].ToString()=="O")
				dataDescuentos.Rows[contador].Cells[2].Value = "Otro";
				else if(conn.leer["TIPO"].ToString()=="T")
				dataDescuentos.Rows[contador].Cells[2].Value = "Taller";
				else if(conn.leer["TIPO"].ToString()=="A")
				dataDescuentos.Rows[contador].Cells[2].Value = "Préstamo";
				else if(conn.leer["TIPO"].ToString()=="L")
				dataDescuentos.Rows[contador].Cells[2].Value = "Trámite";
				else if(conn.leer["TIPO"].ToString()=="P")
				dataDescuentos.Rows[contador].Cells[2].Value = "Descuento";
				else if(conn.leer["TIPO"].ToString()=="D")
				dataDescuentos.Rows[contador].Cells[2].Value = "Descuento";
				
				dataDescuentos.Rows[contador].Cells[3].Value = conn.leer["NOMENCLATURA"].ToString();
				dataDescuentos.Rows[contador].Cells[4].Value = conn.leer["Observacion"].ToString();
				dataDescuentos.Rows[contador].Cells[5].Value = conn.leer["IMPORTE"].ToString();	
				++contador;
			}
			conn.conexion.Close();
			
			DescuentoPeriodo = 0.0;
			for(int s=0; s<dataDescuentos.RowCount; s++)
			{
				DescuentoPeriodo = DescuentoPeriodo + (Convert.ToDouble(dataDescuentos.Rows[s].Cells[5].Value));
			}
			
			dataDescuentos.AutoSize=true;
			if(dataDescuentos.RowCount<=0)
			{
				dataDescuentos.Visible = false;
				lblDescuentos.Visible = false;
			}
			else
			{
				dataDescuentos.Visible = true;
				lblDescuentos.Visible = true;
			}
		}
		
		void AdaptadorPrestamos(int x)
		{
			string consulta = "";
			int contador = 0;
			dataPrestamos.Rows.Clear();
			dataPrestamos.ClearSelection();
			consulta = "select DT.ID_DESCUENTO, DT.FECHA, D.DESCRIPCION, D.observacion, DT.IMPORTE,  D.TIPO "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
				"and FLUJO!='3' and FLUJO!='5' AND (DESCRIPCION like '%PRESTAMO%' OR DESCRIPCION like '%CHOQUE%') and DT.FECHA between '"+Convert.ToDateTime(FechaInicio).AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+Convert.ToDateTime(FechaCorte).AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA";
			//                      "and FLUJO!='3' and FLUJO!='5' AND (DESCRIPCION like '%PRESTAMO%' OR DESCRIPCION like '%CHOQUE%') and DT.FECHA between '"+dtInicio.Value.AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataPrestamos.Rows.Add();
					dataPrestamos.Rows[contador].Cells[0].Value = conn.leer["ID_DESCUENTO"].ToString();
					dataPrestamos.Rows[contador].Cells[1].Value = conn.leer["FECHA"].ToString().Substring(0,10);
					
					if(conn.leer["TIPO"].ToString()=="P")
						dataPrestamos.Rows[contador].Cells[2].Value = "Choque";
					else
						dataPrestamos.Rows[contador].Cells[2].Value = "Préstamo";
					
					dataPrestamos.Rows[contador].Cells[3].Value = conn.leer["observacion"].ToString();
					dataPrestamos.Rows[contador].Cells[4].Value = 0;
					dataPrestamos.Rows[contador].Cells[5].Value = conn.leer["IMPORTE"].ToString();
					dataPrestamos.Rows[contador].Cells[6].Value = "Cancelar $";
					++contador;
			}
			
			conn.conexion.Close();
			dataPrestamos.AutoSize=true;
			if(dataPrestamos.RowCount<=0)
			{
				dataPrestamos.Visible = false;
				lblPrestamos.Visible = false;
			}
			else
			{
				dataPrestamos.Visible = true;
				lblPrestamos.Visible = true;
			}
			
			consulta = "select DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
				                    "and FLUJO!='3' and FLUJO!='5' AND DESCRIPCION ='PRESTAMO ADICIONAL' and DT.FECHA between '"+Convert.ToDateTime(FechaInicio).AddDays(15).ToString("yyyy/MM/dd")+"' AND '"+Convert.ToDateTime(FechaCorte).AddDays(14).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA";
	                          //   "and FLUJO!='3' and FLUJO!='5' AND DESCRIPCION ='PRESTAMO ADICIONAL' and DT.FECHA between '"+dtInicio.Value.AddDays(15).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(14).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtPrestamoAdicional.Text = conn.leer["IMPORTE"].ToString();
				txtPrestamoAdicional.Enabled = false;
				btnPrestamoAdicional.Enabled = false;
			}
			else
			{
				txtPrestamoAdicional.Enabled = true;
				btnPrestamoAdicional.Enabled = true;
				Nivel();
			}
			conn.conexion.Close();
		}
		
		/*void AdaptadorCasetas(int x)
		{
			int contador = 0;
			dataCasetas.Rows.Clear();
			dataCasetas.ClearSelection();
			conn.getAbrirConexion("select RE.DESTINO as Destino, RE.CASETAS "+
                                        "from RUTA_ESPECIAL RE, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
                                        "where O.Estatus='1' and C.ID=RE.ID_C and C.ID=R.IdSubEmpresa and " +
                                        "R.ID=O.id_ruta and O.id_operacion=OO.id_operacion and OO.id_operador=OP.ID " +
                                        "and C.Empresa='Especiales' and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' and "+
                                        "oo.id_operador ="+dtOperador[0,x].Value);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataCasetas.Rows.Add();
				dataCasetas.Rows[contador].Cells[0].Value = conn.leer["DESTINO"].ToString();
				dataCasetas.Rows[contador].Cells[1].Value = conn.leer["Casetas"].ToString();
				dataCasetas.Rows[contador].Cells[2].Value = conn.leer["Cliente"].ToString();
				dataCasetas.Rows[contador].Cells[3].Value = conn.leer["Destino"].ToString();				
				++contador;
			}
			conn.conexion.Close();
		}*/
		#endregion
		
		#region PRIVILEGIOS
		void Nivel()
		{
			if((principal.lblDatoNivel.Text!="NOMINA")&&(principal.lblDatoNivel.Text!="GERENCIAL")&&(principal.lblDatoNivel.Text!="MASTER"))
			{
				btnExcel.Visible = false;
				btnImprimir.Visible = false;
				//btnRecibo.Visible = false;
				btnHistorial.Visible=  false;
				btnExternos.Visible = false;
				btnBono.Visible = false;
				btnprestamo.Visible = false;
				dataValorImporte.Columns[2].ReadOnly=true;
				txtPrestamoAdicional.Enabled = false;
				btnPrestamoAdicional.Enabled = false;
				btnGuardar.Enabled = false;
				txtImporte1.Enabled = false;
				btnExtras.Enabled = false;
			}
			
			if(principal.lblDatoNivel.Text=="COORDINADOR"||principal.lblDatoNivel.Text=="OPERACION")
				btnExternos.Visible = true;
			
			if(principal.lblDatoNivel.Text=="COBRANZA")
			{
				btnExcel.Visible = true;
				btnExternos.Visible = true;
				txtPrestamoAdicional.Enabled = true;
				btnPrestamoAdicional.Enabled = true;
			}
			
			if((principal.lblDatoNivel.Text!="GERENCIAL")||(principal.lblDatoNivel.Text!="MASTER"))
				dataViajesNormales.Columns[8].Visible=true;
				
		}
		#endregion
		
		#region MATRIZ
		void Matriz(int x)
		{
			int contador = 0;
			int viajesMatriz = 0;
			int tallerMatriz = 0;
			int dormidaMatriz = 0;
			int permisoMatriz = 0;
			
			dataMatriz.Rows.Clear();
			dataMatriz.ClearSelection();	
			conn.getAbrirConexion("select O.fecha " +
				                      "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
                                      "where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
                                      "and OO.id_operador=OP.ID and O.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"' " +
                                      "group by O.fecha " +
                                      "order by O.fecha");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dataMatriz.Rows.Add();
					dataMatriz.Rows[contador].Cells[0].Value = conn.leer["FECHA"].ToString().Substring(0,10);
					++contador;
				}
			conn.conexion.Close();
			
			for(int m=0; m<dataMatriz.Rows.Count-1; m++)
			{	
				viajesMatriz = 0;
				tallerMatriz = 0;
				dormidaMatriz = 0;
				permisoMatriz = 0;
				for(int n=0; n<dataViajesNormales.Rows.Count; n++)
				{
					if(dataMatriz.Rows[m].Cells[0].Value.ToString()==dataViajesNormales.Rows[n].Cells[1].Value.ToString())
					{
						if(dataViajesNormales.Rows[n].Cells[5].Value.ToString()=="Mañana")
						{
							dataMatriz.Rows[m].Cells[1].Value = "V";
							++viajesMatriz;
						}
						else if(dataViajesNormales.Rows[n].Cells[5].Value.ToString()=="Medio día")
						{
							dataMatriz.Rows[m].Cells[5].Value = "V";
							++viajesMatriz;
						}
						else if(dataViajesNormales.Rows[n].Cells[5].Value.ToString()=="Vespertino")
						{
							dataMatriz.Rows[m].Cells[9].Value = "V";
							++viajesMatriz;
						}
						else if(dataViajesNormales.Rows[n].Cells[5].Value.ToString()=="Nocturno")
						{
							dataMatriz.Rows[m].Cells[13].Value = "V";
							++viajesMatriz;
						}
					}
				}
				
				for(int n=0; n<dataViajesEspeciales.Rows.Count; n++)
				{
					if(dataViajesEspeciales.RowCount>0)
					{
						if(dataMatriz.Rows[m].Cells[0].Value.ToString()==dataViajesEspeciales.Rows[n].Cells[2].Value.ToString())
						{
							if(dataViajesEspeciales.Rows[n].Cells[6].Value.ToString()=="Mañana")
							{
								dataMatriz.Rows[m].Cells[1].Value = "V";
								++viajesMatriz;
							}
							else if(dataViajesEspeciales.Rows[n].Cells[6].Value.ToString()=="Medio día")
							{
								dataMatriz.Rows[m].Cells[5].Value = "V";
								++viajesMatriz;
							}
							else if(dataViajesEspeciales.Rows[n].Cells[6].Value.ToString()=="Vespertino")
							{
								dataMatriz.Rows[m].Cells[9].Value = "V";
								++viajesMatriz;
							}
							else if(dataViajesEspeciales.Rows[n].Cells[6].Value.ToString()=="Nocturno")
							{
								dataMatriz.Rows[m].Cells[13].Value = "V";
								++viajesMatriz;
							}
						}
					}
				}
				String a="select H.DIA, H.turno " +
				                      "from CARDEX H, OPERADOR O " +
				                      "where H.ID_OPERADOR=O.ID and H.ESTATUS='T' and O.ID='"+dtOperador.Rows[x].Cells[0].Value+"'and H.DIA='"+dataMatriz.Rows[m].Cells[0].Value+"' ";
				conn.getAbrirConexion(a);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["turno"].ToString()=="Mañana")
					{
						dataMatriz.Rows[m].Cells[3].Value = "T";
						++tallerMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Medio día")
					{
						dataMatriz.Rows[m].Cells[7].Value = "T";
						++tallerMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Vespertino")
					{
						dataMatriz.Rows[m].Cells[11].Value = "T";
						++tallerMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Nocturno")
					{
						dataMatriz.Rows[m].Cells[15].Value = "T";
						++tallerMatriz;
					}
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select H.FECHA, H.turno " +
				                      "from HISTORIALOPERADOR H, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U " +
				                      "where H.ID_O=O.ID and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO AND H.ESTATUS='D' and O.ID='"+dtOperador.Rows[x].Cells[0].Value+"'and H.FECHA='"+dataMatriz.Rows[m].Cells[0].Value+"' group by H.FECHA, H.TURNO");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["turno"].ToString()=="Mañana")
					{
						dataMatriz.Rows[m].Cells[4].Value = "D";
						++dormidaMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Medio día")
					{
						dataMatriz.Rows[m].Cells[8].Value = "D";
						++dormidaMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Vespertino")
					{
						dataMatriz.Rows[m].Cells[12].Value = "D";
						++dormidaMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Nocturno")
					{
						dataMatriz.Rows[m].Cells[16].Value = "D";
						++dormidaMatriz;
					}
				}
				conn.conexion.Close();
				
				conn.getAbrirConexion("select H.FECHA, H.turno " +
				                      "from HISTORIALOPERADOR H, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U " +
				                      "where H.ID_O=O.ID and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO  AND H.ESTATUS='P' and O.ID='"+dtOperador.Rows[x].Cells[0].Value+"'and H.FECHA='"+dataMatriz.Rows[m].Cells[0].Value+"' " +
				                      "group by H.FECHA, H.TURNO");
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["turno"].ToString()=="Mañana")
					{
						dataMatriz.Rows[m].Cells[2].Value = "P";
						++permisoMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Medio día")
					{
						dataMatriz.Rows[m].Cells[6].Value = "P";
						++permisoMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Vespertino")
					{
						dataMatriz.Rows[m].Cells[10].Value = "P";
						++permisoMatriz;
					}
					else if(conn.leer["turno"].ToString()=="Nocturno")
					{
						dataMatriz.Rows[m].Cells[14].Value = "P";
						++permisoMatriz;
					}
				}
				conn.conexion.Close();
				
				dataMatriz.Rows[m].Cells[17].Value = viajesMatriz;
				dataMatriz.Rows[m].Cells[18].Value = tallerMatriz;
				dataMatriz.Rows[m].Cells[19].Value = dormidaMatriz;
				dataMatriz.Rows[m].Cells[20].Value = permisoMatriz;
				
				AcumuladorDormida = 0;
				AcumuladorTaller = 0;
				AcumuladorPermiso = 0;
				for(int s=0; s<dataMatriz.RowCount; s++)
				{
					AcumuladorTaller = AcumuladorTaller + (Convert.ToInt32(dataMatriz.Rows[s].Cells[18].Value));
					AcumuladorDormida = AcumuladorDormida + (Convert.ToInt32(dataMatriz.Rows[s].Cells[19].Value));
					AcumuladorPermiso = AcumuladorPermiso + (Convert.ToInt32(dataMatriz.Rows[s].Cells[20].Value));
				}
			}
			dataMatriz.AutoSize=true;
		}	
		#endregion
		
		#region CASETAS
		void CasetasTotal()
		{
			/*Tickets = 0.0;
			for(int s=0; s<dataViajesEspeciales.RowCount; s++)
			{
				Tickets = Tickets + Convert.ToDouble(dataViajesEspeciales.Rows[s].Cells[11].Value);
				txtTickets.Text = Tickets.ToString();
			}*/
		}
		#endregion	

		#region TRAER VALORES
		void Importes()
		{
			int contador = 0;
			
			dataValorImporte.Rows.Clear();
			dataValorImporte.ClearSelection();
			
			conn.getAbrirConexion("select ID, NOMBRE, SALDO " +
			                      "from VALOR_IMPORTE " +
			                      "where id=7 or id=8 or id=9 or id=10 or id=11 or id=12 or id=13 or id=14");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValorImporte.Rows.Add();
					dataValorImporte.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValorImporte.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValorImporte.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					if(conn.leer["NOMBRE"].ToString() == "APOYOS")
						dataValorImporte.Rows[contador].Cells[3].Value = "ADMINISTRATIVO";
					else
						dataValorImporte.Rows[contador].Cells[3].Value = "N/A";
					++contador;
			}
			conn.conexion.Close();
			
			// APOYOS			
			conn.getAbrirConexion("SELECT * FROM VALOR_IMPORTE_APOYOS");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValorImporte.Rows.Add();
					dataValorImporte.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValorImporte.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValorImporte.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					dataValorImporte.Rows[contador].Cells[3].Value = conn.leer["TAMANO"].ToString();
					++contador;
			}
			conn.conexion.Close();
			
			dataValorImporte.AutoSize=true;
		}
		#endregion
		
		#region DIRECTORIO ILUSTRADO DIFERENTE ORDEN
		public void DirectorioIlustradoOrden(int opcion)
		{
			try
			{
				if (opcion == 1)
				{
					AdaptadorOperadorPorCamion();
					FormatoDirectorioCaritasCamion("TRANSPORTES LAR (CAMIONES)");
				}
				else if(opcion == 2)
				{
					AdaptadorOperadorPorCamioneta();
					FormatoDirectorioCaritasCamioneta("TRANSPORTES LAR (CAMIONETAS)");
				}
				else if(opcion == 3)
				{
					AdaptadorOperador();
					FormatoDirectorioCaritasAlfabetico("TRANSPORTES LAR");
				}
				else if(opcion == 4)
				{
					AdaptadorOperador();
					FormatoDirectorioCaritasVentas("TRANSPORTES LAR");
				}
			}
			catch{}
		}
		#endregion
		
		#region DIRECTORIO TELEFONICO
		public void DirectorioTelefonico()
		{
			AdaptadorOperador();
			FormatoDirectorioTelefonico();
		}
		#endregion
		
		#region ACTUALIZAR - IMPORTES
		void BtnActualizarClick(object sender, EventArgs e)
		{
			for(int x=0; x<dataValorImporte.Rows.Count; x++)
			{
				try{
				new Conexion_Servidor.Anticipos.SQL_Anticipos().ActualizarValores(dataValorImporte.Rows[x].Cells[0].Value.ToString(), dataValorImporte.Rows[x].Cells[2].Value.ToString());
				}catch{}
			}
		}
		#endregion
		
		#region CALCULAR DIAS TRABAJADOS
		void CalculoDiasTrabajados()
		{
			int diasIncapasitados = 0;
			diasIncapasitados =  DiasIncapacidades(dtOperador[0,x].Value.ToString());
						
			TimeSpan ts = dtCorte.Value - dtInicio.Value;
			DiasTrabajados = ts.Days + 1;
			txtDiasTrabajados.Text = DiasTrabajados.ToString();
			
			string inicio = "";	
			string consulta = "";
			bool respuesta = false;
			
			try{
				consulta = @"select o.ID, OC.ID AS CONTRATO, o.Alias, oc.FechaInicioContrato, oc.fecha_vencimiento, oc.TipoContrato from OPERADOR o join OperadorContrato oc 
							on o.ID = oc.IdOperador where OC.TipoContrato = 'Temporal' and FechaInicioContrato between '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"
							+dtCorte.Value.ToString("yyyy-MM-dd")+"' and O.ID not in (select O.ID from OPERADOR O, OperadorContrato OC where O.ID = OC.IdOperador and " +
			                "OC.fecha_vencimiento BETWEEN '"+dtInicio.Value.ToString("yyyy-MM-dd")+"' and '"+dtCorte.Value.ToString("yyyy-MM-dd")+"') and O.ID = "+dtOperador[0,x].Value;			
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					respuesta = true;
					inicio = conn.leer["FechaInicioContrato"].ToString().Substring(0,10);	
				}		
				conn.conexion.Close();
				
				if(respuesta){
					ts =  dtCorte.Value - Convert.ToDateTime(inicio);
					DiasTrabajados = ts.Days + 1;
					txtDiasTrabajados.Text = DiasTrabajados.ToString();				
				}
				DiasTrabajados = ts.Days + 1;
				txtDiasTrabajados.Text = DiasTrabajados.ToString();			
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
			// Incapacidad
			DiasTrabajados = DiasTrabajados-diasIncapasitados;
			txtDiasTrabajados.Text = DiasTrabajados.ToString();
			
		}
		#endregion
		
		#region RETORNO PAGARE
		void CalculoPagare(int x)
		{
			DescuentoPrestamo = 0.0;
			prestamoRestante = 0.0;
			pagare = 0.0;
			for(int s=0; s<dataPrestamos.RowCount; s++)
				{
					conn.getAbrirConexion("select DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='3' AND DT.FLUJO!='5' "+
	                               "and DT.FECHA>'"+dtCorte.Value.AddDays(1).ToString("yyyy-MM-dd")+"' " +
	                               "and D.ID_OPERADOR="+dtOperador[0,x].Value+" and DT.ID_DESCUENTO="+dataPrestamos.Rows[s].Cells[0].Value);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dataPrestamos.Rows[s].Cells[4].Value = (Convert.ToDouble(dataPrestamos.Rows[s].Cells[4].Value)) + (Convert.ToDouble(conn.leer["IMPORTE"]));
					}
					conn.conexion.Close();
					DescuentoPrestamo = DescuentoPrestamo + (Convert.ToDouble(dataPrestamos.Rows[s].Cells[5].Value));
					prestamoRestante = prestamoRestante + (Convert.ToDouble(dataPrestamos.Rows[s].Cells[4].Value));
				}
			
			for(int s=0; s<dataDescuentos.RowCount; s++)
				{
					if(dataDescuentos.Rows[s].Cells[2].Value!=null)
						{
						if(dataDescuentos.Rows[s].Cells[2].Value.ToString()!="Periodo" && dataDescuentos.Rows[s].Cells[2].Value.ToString()!="Trámite" && dataDescuentos.Rows[s].Cells[4].Value.ToString()!="TEPADI" && dataDescuentos.Rows[s].Cells[3].Value.ToString().Contains("CRE")==false && dataDescuentos.Rows[s].Cells[3].Value.ToString().Contains("FIA")==false && dataDescuentos.Rows[s].Cells[3].Value.ToString().Contains("FUN")==false)
							{
								String query = "select DT.IMPORTE "+
				                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
				                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='3' AND DT.FLUJO!='5' AND D.Tipo!='U' AND D.Descripcion!='CREDITO ADICIONAL' "+
				                               "and DT.FECHA>'"+dtCorte.Value.AddDays(2).ToString("yyyy-MM-dd")+"' " +
				                               "and D.ID_OPERADOR="+dtOperador[0,x].Value+" and DT.ID_DESCUENTO="+dataDescuentos.Rows[s].Cells[0].Value;
								conn.getAbrirConexion(query);
								conn.leer=conn.comando.ExecuteReader();
								while(conn.leer.Read())
								{
									pagare = pagare + (Convert.ToDouble(conn.leer["IMPORTE"]));
								}
								conn.conexion.Close();
							}
						}
				}
			
				String Sentencia3 = "select DT.IMPORTE "+
                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='3' AND DT.FLUJO!='5' AND D.Tipo!='U' and D.Tipo!='L' AND D.Descripcion!='CREDITO ADICIONAL' "+
                               "and DT.FECHA>'"+dtCorte.Value.AddDays(1).ToString("yyyy-MM-dd")+"' " +
                               "and D.ID_OPERADOR="+dtOperador[0,x].Value+" AND DT.ID_DESCUENTO NOT IN (select DT.ID_DESCUENTO "+
																		                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
																		                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='5' and FLUJO!='3' "+
																										"AND DT.FECHA between '"+Convert.ToDateTime(FechaInicio).AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+Convert.ToDateTime(FechaCorte).AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+")  AND DT.ID_DESCUENTO NOT IN (select DT.ID_DESCUENTO "+
																		                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
																		                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='5' and FLUJO!='3' "+
																										"AND DT.FECHA > '"+Convert.ToDateTime(FechaCorte).AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" AND D.Descripcion='CASETAS' )";
				 																					// "AND DT.FECHA between '"+dtInicio.Value.AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+")";
				conn.getAbrirConexion(Sentencia3);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					pagare = pagare + (Convert.ToDouble(conn.leer["IMPORTE"]));
				}
				conn.conexion.Close();
				
				/*String Sentencia4 = "select DT.IMPORTE "+
                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='3' AND DT.FLUJO!='5' AND D.Tipo!='U' and D.Tipo!='L' AND D.Descripcion!='CREDITO ADICIONAL' "+
                               "and DT.FECHA>'"+dtCorte.Value.AddDays(1).ToString("yyyy-MM-dd")+"' " +
                               "and D.ID_OPERADOR="+dtOperador[0,x].Value+" AND DT.ID_DESCUENTO NOT IN (select DT.ID_DESCUENTO "+
																		                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
																		                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR and DT.FLUJO!='5' and FLUJO!='3' "+
																		                               "AND DT.FECHA between '"+dtInicio.Value.AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+")";
				conn.getAbrirConexion(Sentencia4);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					pagare = pagare + (Convert.ToDouble(conn.leer["IMPORTE"]));
				}
				conn.conexion.Close();*/
			
				pagare = pagare + prestamoRestante;
				txtPagare.Text = pagare.ToString();
		}
		
		public double RetornoPagare(int row)
		{
			double RetornoP = 0.0;
			
			dtInicio.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO()));
			dtCorte.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN()));
			FechaInicio = dtInicio.Value.ToString("yyyy-MM-dd");
			FechaCorte = dtCorte.Value.ToString("yyyy-MM-dd");
			AdaptadorPrestamos(row);
			AdaptadorDescuentos(row);
			CalculoPagare(row);
			RetornoP = pagare;
			
			return RetornoP;
		}
		
		public double RetornoPagare(int row, DateTimePicker dtInicio, DateTimePicker dtCorte)
		{
			double RetornoP = 0.0;
			
			this.dtInicio.Value = dtInicio.Value;
			this.dtCorte.Value = dtCorte.Value;
			FechaInicio = dtInicio.Value.ToString("yyyy-MM-dd");
			FechaCorte = dtCorte.Value.ToString("yyyy-MM-dd");
			AdaptadorPrestamos(row);
			AdaptadorDescuentos(row);
			CalculoPagare(row);
			RetornoP = pagare;
			
			return RetornoP;
		}
		
		public double RetornoPagareAlias(String AliasObj)
		{
			double RetornoP = 0.0;
			AdaptadorOperador();
			Importes();
			dtInicio.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO()));
			dtCorte.Value = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN()));
			FechaInicio = dtInicio.Value.ToString("yyyy-MM-dd");
			FechaCorte = dtCorte.Value.ToString("yyyy-MM-dd");
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
		    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==AliasObj)
		    	{
					if(x>0)
						dtOperador.Rows[x-1].Selected = false;

					dtOperador.ClearSelection();
					dtOperador.Rows[x].Selected = true;
					this.x = x;
					AdaptadorPrestamos(x);
					AdaptadorDescuentos(x);
					CalculoPagare(x);
					RetornoP = pagare;
		    	}
			}
			return RetornoP;
		}
		#endregion 
		
		#region RETORNO SUELDO
		public double RetornoSueldo(int row)
		{
			x = row;
			double RetornoS = 0.0;	
			FechaInicio = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO())).ToString("yyyy-MM-dd");
			FechaCorte = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN())).ToString("yyyy-MM-dd");
			Importes();
			AdaptadorNormales(row);
			AdaptadorEspeciales(row);
			SumaViajesNormales(dataViajesNormales);
			SumaViajesEspeciales();
			PreciosRutas();
			ConteoEmpresasPDF(row);
			LlenadoDataGridConteo();
			BorradoRow();
			sueldoViajes = 0.0;
			sueldoViajesE = 0.0;
			if(dataViajesNormales.RowCount>0)
			{
				for(int a = 0; a<(dataViajesNormales.RowCount); a++)
				{
					sueldoViajes = sueldoViajes + (Convert.ToDouble(dataViajesNormales.Rows[a].Cells[8].Value));
				}
			}
			if(dataViajesEspeciales.RowCount>0)
			{
				for(int a = 0; a<(dataViajesEspeciales.RowCount); a++)
				{
					sueldoViajesE = sueldoViajesE + (Convert.ToDouble(dataViajesEspeciales.Rows[a].Cells[9].Value));
				}
			}
			RetornoS = sueldoViajes + sueldoViajesE;


			AdaptadorGuardia(row);
			AdaptadorReconocimientos(row);
			AdaptadorCancelacion(row);
			AdaptadorApoyos(row);
			AdaptadorPRendimiento(row);
			double	sueldoG = 0.0, sueldoR = 0.0, sueldoC = 0.0, sueldoA = 0.0, sueldoPR = 0.0;										
			
			if(dataGuardia.RowCount > 0){
				for(int a = 0; a<(dataGuardia.RowCount); a++)
					sueldoG = sueldoG + (Convert.ToDouble(dataGuardia.Rows[a].Cells[5].Value));
			}
			if(dataReconocimientos.RowCount > 0){
				for(int a = 0; a<(dataReconocimientos.RowCount); a++)
					sueldoR = sueldoR + (Convert.ToDouble(dataReconocimientos.Rows[a].Cells[8].Value));
			}			
			if(dataCancelacion.RowCount > 0){
				for(int a = 0; a<(dataCancelacion.RowCount); a++)
					sueldoC = sueldoC + (Convert.ToDouble(dataCancelacion.Rows[a].Cells[5].Value));
			}
			if(dataApoyos.RowCount > 0){
				for(int a = 0; a<(dataApoyos.RowCount); a++)
					sueldoA = sueldoA + (Convert.ToDouble(dataApoyos.Rows[a].Cells[8].Value));
			}
			if(dataRendimiento.RowCount > 0){
				for(int a = 0; a<(dataRendimiento.RowCount); a++)
					sueldoPR = sueldoPR + (Convert.ToDouble(dataRendimiento.Rows[a].Cells[7].Value));
			}
						
			RetornoS += sueldoG + sueldoR + sueldoC + sueldoA + sueldoPR; 
			return RetornoS;
		}
		
		public double RetornoSueldoAlias(String AliasObj)
		{
			AdaptadorOperador();
			Importes();
			double RetornoS = 0.0;	
			FechaInicio = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO())).ToString("yyyy-MM-dd");
			FechaCorte = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN())).ToString("yyyy-MM-dd");
			cuenta = 0;
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
		    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==AliasObj)
		    	{
					if(x>0)
						dtOperador.Rows[x-1].Selected = false;
					
					AdaptadorNormales(x);
					AdaptadorEspeciales(x);
					SumaViajesNormales(dataViajesNormales);
					SumaViajesEspeciales();
					PreciosRutas();
					sueldoViajes = 0.0;
					sueldoViajesE = 0.0;
					
					if(dataViajesNormales.RowCount>0)
					{
						for(int a = 0; a<(dataViajesNormales.RowCount); a++)
						{
							sueldoViajes = sueldoViajes + (Convert.ToDouble(dataViajesNormales.Rows[a].Cells[8].Value));
							cuenta++;
						}
					}
					if(dataViajesEspeciales.RowCount>0)
					{
						for(int a = 0; a<(dataViajesEspeciales.RowCount); a++)
						{
							sueldoViajesE = sueldoViajesE + (Convert.ToDouble(dataViajesEspeciales.Rows[a].Cells[9].Value));
							cuenta++;
						}
					}
					RetornoS = sueldoViajes + sueldoViajesE; 
		    	}
		    }
			return RetornoS;
		}
		
		public void AdaptadorCalculo(){
			int contador = 0;
			dtOperador.Rows.Clear();
			dtOperador.ClearSelection();
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' order by alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador.Rows.Add();
				dtOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador.Rows[contador].Cells[1].Value = conn.leer["Alias_Op"].ToString();
				dtOperador.Rows[contador].Cells[2].Value = conn.leer["foraneo"].ToString();
				
				if(dtOperador.Rows[contador].Cells[2].Value.ToString()=="1")
					dtOperador.Rows[contador].Cells[1].Style.BackColor = Color.Gold;
				++contador;
			}
			conn.conexion.Close();
			
			contador = 0;
			
			dataValorImporte.Rows.Clear();
			dataValorImporte.ClearSelection();
			
			conn.getAbrirConexion("select ID, NOMBRE, SALDO " +
			                      "from VALOR_IMPORTE " +
			                      "where id=7 or id=8 or id=9 or id=10 or id=11 or id=12 or id=13 or id=14");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValorImporte.Rows.Add();
					dataValorImporte.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValorImporte.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValorImporte.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					if(conn.leer["NOMBRE"].ToString() == "APOYOS")
						dataValorImporte.Rows[contador].Cells[3].Value = "ADMINISTRATIVO";
					else
						dataValorImporte.Rows[contador].Cells[3].Value = "N/A";
					++contador;
			}
			conn.conexion.Close();
			
			// APOYOS			
			conn.getAbrirConexion("SELECT * FROM VALOR_IMPORTE_APOYOS");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValorImporte.Rows.Add();
					dataValorImporte.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValorImporte.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValorImporte.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					dataValorImporte.Rows[contador].Cells[3].Value = conn.leer["TAMANO"].ToString();
					++contador;
			}
			conn.conexion.Close();
			
			dataValorImporte.AutoSize=true;
		}
				
		public void AdaptadorCalculo2(string consulta){
			int contador = 0;
			dtOperador.Rows.Clear();
			dtOperador.ClearSelection();
			conn.getAbrirConexion("select ID, alias as Alias_Op, foraneo " +
			                      "from OPERADOR " +
			                      "where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' order by alias");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador.Rows.Add();
				dtOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador.Rows[contador].Cells[1].Value = conn.leer["Alias_Op"].ToString();
				dtOperador.Rows[contador].Cells[2].Value = conn.leer["foraneo"].ToString();
				
				if(dtOperador.Rows[contador].Cells[2].Value.ToString()=="1")
					dtOperador.Rows[contador].Cells[1].Style.BackColor = Color.Gold;
				++contador;
			}
			conn.conexion.Close();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtOperador.Rows.Add();
				dtOperador.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtOperador.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dtOperador.Rows[contador].Cells[2].Value = conn.leer["foraneo"].ToString();
				
				if(dtOperador.Rows[contador].Cells[2].Value.ToString()=="1")
					dtOperador.Rows[contador].Cells[1].Style.BackColor = Color.Gold;
				++contador;
			}
			conn.conexion.Close();
						
			
			contador = 0;			
			dataValorImporte.Rows.Clear();
			dataValorImporte.ClearSelection();
			
			conn.getAbrirConexion("select ID, NOMBRE, SALDO " +
			                      "from VALOR_IMPORTE " +
			                      "where id=7 or id=8 or id=9 or id=10 or id=11 or id=12 or id=13 or id=14");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValorImporte.Rows.Add();
					dataValorImporte.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValorImporte.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValorImporte.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					if(conn.leer["NOMBRE"].ToString() == "APOYOS")
						dataValorImporte.Rows[contador].Cells[3].Value = "ADMINISTRATIVO";
					else
						dataValorImporte.Rows[contador].Cells[3].Value = "N/A";
					++contador;
			}
			conn.conexion.Close();
			
			// APOYOS			
			conn.getAbrirConexion("SELECT * FROM VALOR_IMPORTE_APOYOS");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValorImporte.Rows.Add();
					dataValorImporte.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValorImporte.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValorImporte.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					dataValorImporte.Rows[contador].Cells[3].Value = conn.leer["TAMANO"].ToString();
					++contador;
			}
			conn.conexion.Close();
			
			dataValorImporte.AutoSize=true;
						
			for(int x = 0; x<(dtOperador.RowCount-1); x++){
				for(int y = x+1; y<dtOperador.RowCount; y++){
					if(dtOperador[0,x].Value.ToString() == dtOperador[0,y].Value.ToString()){
						dtOperador.Rows.RemoveAt(y);
						if(x>0){
							--x;
							break;
						}
					}
				}
			}
		}
		
		public double RetornoSueldoAlias2(String AliasObj, string inicio, string fin)
		{			
			double	sueldoG = 0.0, sueldoR = 0.0, sueldoC = 0.0, sueldoA = 0.0, sueldoPR = 0.0, sueldoI = 0.0;
			double RetornoS = 0.0;	
			FechaInicio = inicio;
			FechaCorte = fin;
			cuenta = 0;
			cuentaLocal = 0;
			cuentaForaneo = 0;
			SueldoLocal = 0.0;
			SueldoForaneo = 0.0;
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
		    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==AliasObj)
		    	{
					if(x>0)
						dtOperador.Rows[x-1].Selected = false;
					
					AdaptadorNormales(x);
					AdaptadorEspeciales(x);			
					AdaptadorGuardia(x);
					AdaptadorReconocimientos(x);
					AdaptadorCancelacion(x);
					AdaptadorApoyos(x);
					AdaptadorPRendimiento(x);
					AdaptadorIngresos(x);
				
					SumaViajesNormales(dataViajesNormales);
					SumaViajesEspeciales();
					PreciosRutas2(dtOperador.Rows[x].Cells[2].Value.ToString());
					sueldoViajes = 0.0;
					sueldoViajesE = 0.0;
					sueldoG = 0.0;
					sueldoR = 0.0;
					sueldoC = 0.0;
					sueldoA = 0.0;
					sueldoPR = 0.0;
					sueldoI = 0.0;
					
					if(dataViajesNormales.RowCount>0)
					{
						for(int a = 0; a<(dataViajesNormales.RowCount); a++)
						{
							sueldoViajes = sueldoViajes + (Convert.ToDouble(dataViajesNormales.Rows[a].Cells[8].Value));
							cuenta++;
							cuentaLocal++;
						}
					}
					if(dataViajesEspeciales.RowCount>0)
					{
						for(int a = 0; a<(dataViajesEspeciales.RowCount); a++){
							sueldoViajesE = sueldoViajesE + (Convert.ToDouble(dataViajesEspeciales.Rows[a].Cells[9].Value));
							cuenta++;
							cuentaForaneo++;
						}
					}										
					
					if(dataGuardia.RowCount > 0){
						for(int a = 0; a<(dataGuardia.RowCount); a++){
							sueldoG = sueldoG + (Convert.ToDouble(dataGuardia.Rows[a].Cells[5].Value));
							cuenta++;
							cuentaLocal++;
						}
					}
					if(dataReconocimientos.RowCount > 0){
						for(int a = 0; a<(dataReconocimientos.RowCount); a++){
							sueldoR = sueldoR + (Convert.ToDouble(dataReconocimientos.Rows[a].Cells[8].Value));
							cuenta++;
							cuentaLocal++;
						}
					}
					
					if(dataCancelacion.RowCount > 0){
						for(int a = 0; a<(dataCancelacion.RowCount); a++){
							sueldoC = sueldoC + (Convert.ToDouble(dataCancelacion.Rows[a].Cells[5].Value));
							cuenta++;
							cuentaLocal++;
						}
					}
					if(dataApoyos.RowCount > 0){
						for(int a = 0; a<(dataApoyos.RowCount); a++){
							sueldoA = sueldoA + (Convert.ToDouble(dataApoyos.Rows[a].Cells[8].Value));
							cuenta++;
							cuentaLocal++;
						}
					}
					if(dataRendimiento.RowCount > 0){
						for(int a = 0; a<(dataRendimiento.RowCount); a++){
							sueldoPR = sueldoPR + (Convert.ToDouble(dataRendimiento.Rows[a].Cells[7].Value));
							cuenta++;
							cuentaLocal++;
						}
					}
					if(dataIngresosExtras.RowCount > 0){
						for(int a = 0; a<(dataIngresosExtras.RowCount); a++){
							sueldoI = sueldoI + (Convert.ToDouble(dataIngresosExtras.Rows[a].Cells[2].Value));
						}
					}
								
					RetornoS = sueldoViajes + sueldoViajesE + sueldoG + sueldoR + sueldoC + sueldoA + sueldoPR + sueldoI; 
					
					SueldoLocal = sueldoViajes + sueldoG + sueldoR + sueldoC + sueldoA + sueldoPR + sueldoI; 
					SueldoForaneo = sueldoViajesE; 
		    	}
		    }
			return RetornoS;
		}
		
		void AdaptadorPrestamos2(int x)
		{
			int contador = 0;
			dataPrestamos.Rows.Clear();
			dataPrestamos.ClearSelection();
			conn.getAbrirConexion("select DT.ID_DESCUENTO, DT.FECHA, D.DESCRIPCION, D.observacion, DT.IMPORTE,  D.TIPO "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               "and FLUJO!='3' and FLUJO!='5' AND (DESCRIPCION like '%PRESTAMO%' OR DESCRIPCION like '%CHOQUE%') and DT.FECHA between '"+Convert.ToDateTime(FechaInicio).AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+Convert.ToDateTime(FechaCorte).AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA");
//			                       "and FLUJO!='3' and FLUJO!='5' AND (DESCRIPCION like '%PRESTAMO%' OR DESCRIPCION like '%CHOQUE%') and DT.FECHA between '"+dtInicio.Value.AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataPrestamos.Rows.Add();
					dataPrestamos.Rows[contador].Cells[0].Value = conn.leer["ID_DESCUENTO"].ToString();
					dataPrestamos.Rows[contador].Cells[1].Value = conn.leer["FECHA"].ToString().Substring(0,10);
					
					if(conn.leer["TIPO"].ToString()=="P")
						dataPrestamos.Rows[contador].Cells[2].Value = "Choque";
					else
						dataPrestamos.Rows[contador].Cells[2].Value = "Préstamo";
					
					dataPrestamos.Rows[contador].Cells[3].Value = conn.leer["observacion"].ToString();
					dataPrestamos.Rows[contador].Cells[4].Value = 0;
					dataPrestamos.Rows[contador].Cells[5].Value = conn.leer["IMPORTE"].ToString();
					dataPrestamos.Rows[contador].Cells[6].Value = "Cancelar $";
					++contador;
			}
			
			conn.conexion.Close();
			dataPrestamos.AutoSize=true;
			if(dataPrestamos.RowCount<=0)
			{
				dataPrestamos.Visible = false;
				lblPrestamos.Visible = false;
			}
			else
			{
				dataPrestamos.Visible = true;
				lblPrestamos.Visible = true;
			}
			
			conn.getAbrirConexion("select DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               "and FLUJO!='3' and FLUJO!='5' AND DESCRIPCION ='PRESTAMO ADICIONAL' and DT.FECHA between '"+Convert.ToDateTime(FechaInicio).AddDays(15).ToString("yyyy/MM/dd")+"' AND '"+Convert.ToDateTime(FechaCorte).AddDays(14).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA");
			                      // "and FLUJO!='3' and FLUJO!='5' AND DESCRIPCION ='PRESTAMO ADICIONAL' and DT.FECHA between '"+dtInicio.Value.AddDays(15).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(14).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" order by DT.FECHA");
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				txtPrestamoAdicional.Text = conn.leer["IMPORTE"].ToString();
				txtPrestamoAdicional.Enabled = false;
				btnPrestamoAdicional.Enabled = false;
			}
			conn.conexion.Close();
		}
				
		public double RetornoSueldoAlias3(String AliasObj, string inicio, string fin)
		{				
			double RetornoS = 0.0;	
			FechaInicio = inicio;
			FechaCorte = fin;
			
			precioBonoNormal = (Convert.ToDouble(dataValorImporte.Rows[0].Cells[2].Value.ToString()));
			precioBonoExtra = (Convert.ToDouble(dataValorImporte.Rows[1].Cells[2].Value.ToString()));
			precioBonoEspecial = (Convert.ToDouble(dataValorImporte.Rows[2].Cells[2].Value.ToString()));
			
			TimeSpan ts = Convert.ToDateTime(fin) -  Convert.ToDateTime(inicio);
			DiasTrabajados = ts.Days + 1;
			txtDiasTrabajados.Text = DiasTrabajados.ToString();			
			
			for(int x=0; x<dtOperador.Rows.Count; x++){
				if(dtOperador.Rows[x].Cells[1].Value.ToString() == AliasObj){
					if(x>0)
						dtOperador.Rows[x-1].Selected = false;			
			
						txtAlias.Text = dtOperador.Rows[x].Cells[1].Value.ToString();
						
						ckBono.Checked = false;
						Alias = dtOperador.Rows[x].Cells[1].Value.ToString();
						IdOperador = (Convert.ToInt32(dtOperador.Rows[x].Cells[0].Value));
						foraneo = dtOperador.Rows[x].Cells[2].Value.ToString();
						
						total = 0.0;
						totalIngresos = 0.0;
						totalpercepciones = 0.0;
						aguinaldoneto = 0.0;
						primavacacional = 0.0;
						aguinaldoneto = 0.0;
						DescuentoPeriodo = 0.0;
						DescuentoPrestamo = 0.0;
						infonavit = 0.0;
						isr = 0.0;
						imss = 0.0;
						extra1 = 0.0;
						IdNom = 0;	
							
						this.x=x;
						txtBono.Text = "0";
						txtBonoEspecial.Text = "0";
						txtBonoExtra.Text = "0";
						txtApoyoCoord.Text = "0";
		    			txtSueldoViajes.Text = "0";
						txtImpuestos.Text = "0";
						txtAnticipos.Text = "0";

		    	
						LimpiarCampos();
						DatosImpuestosTotal(x);
						BorradoRow();
						
						AdaptadorNormales(x);
						AdaptadorEspeciales(x);
						AdaptadorGuardia(x);
						AdaptadorReconocimientos(x);
						AdaptadorCancelacion(x);
						AdaptadorApoyos(x);
						AdaptadorPRendimiento(x);
						
						AdaptadorDescuentos(x);
						AdaptadorPrestamos2(x);
						
						CalculoPagare(x);
						AdaptadorCausas(x);
						AdaptadorChoque(x);
						AdaptadorTaxi(x);
						AdaptadorIngresos(x);
						TraerBono(x);
						SumaViajesNormales(dataViajesNormales);
						SumaViajesEspeciales();
						PreciosRutas();
						
						SumaCostosViajes();
						SumaCostosViajesE();
						SumaCostosViajesG();
						SumaCostosReconocimientso();
						SumaCostosApoyos();
						SumaCostosPRendimiento();
						
						ContadorViajes();
						ContadorViajesE();
						ContadorViajesG();
						ConteoEmpresasPDF(x);
						ValorBono();
						CalcularTotales();
					
						double residuo = 0;
						if(Math.Round(total, 2)%5!=0){
							residuo = Math.Round(total,2)%5;
							residuo = 5 - residuo;
							total = Math.Round(total,2) + residuo;
						}				
						//total = ((totalIngresos+extra1+totalpercepciones)-(aguinaldoneto+primavacacional)) - (infonavit+isr+imss) - (DescuentoPeriodo) - (DescuentoPrestamo);
					
					/*					
					//total = ((totalIngresos+extra1+totalpercepciones)-(aguinaldoneto+primavacacional)) - (infonavit+isr+imss) - (DescuentoPeriodo) - (DescuentoPrestamo);
					Hoja[x,1] = Alias;
					Hoja[x,2] =  Math.Round(total).ToString("C"); 
					//Hoja[x,2] = total.ToString();
					Hoja[x,3] = ((totalIngresos+extra1+totalpercepciones)-(aguinaldoneto+primavacacional)).ToString("C");
					Hoja[x,4] = aguinaldoneto.ToString("C");
					Hoja[x,5] = primavacacional.ToString("C");
					Hoja[x,6] = DescuentoPeriodo.ToString("C");
					Hoja[x,7] = DescuentoPrestamo.ToString("C");
					Hoja[x,8] = (infonavit+isr+imss).ToString("C");
					*/
						RetornoS = Math.Round(total);
		    	}
		    }
			return RetornoS;
		}
		
		public Int32 RetornoCantViajesOperador(String AliasObj, string inicio, string fin)
		{
			AdaptadorOperadorAll();
			Importes();
			FechaInicio = inicio;
			FechaCorte = fin;
			cuenta = 0;
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
		    	if(dtOperador.Rows[x].Cells[1].Value.ToString() == AliasObj)
		    	{
					if(x>0)
						dtOperador.Rows[x-1].Selected = false;
					
					AdaptadorNormales(x);
					AdaptadorEspeciales(x);
					SumaViajesNormales(dataViajesNormales);
					SumaViajesEspeciales();
					
					if(dataViajesNormales.RowCount > 0){
						for(int a = 0; a<(dataViajesNormales.RowCount); a++){
							cuenta++;
						}
					}
					if(dataViajesEspeciales.RowCount > 0){
						for(int a = 0; a<(dataViajesEspeciales.RowCount); a++){
							cuenta++;
						}
					}
		    	}
		    }
			return cuenta;
		}
	
		
		public double RetornoSueldoFinalAlias(String AliasObj)
		{
			AdaptadorOperador();
			Importes();
			FechaInicio = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO())).ToString("yyyy-MM-dd");
			FechaCorte = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN())).ToString("yyyy-MM-dd");
			double RetornoS = 0.0;	
			cuenta = 0;
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
				if(x>0)
					dtOperador.Rows[x-1].Selected = false;
		    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==AliasObj)
		    	{
					dtOperador.Rows[x].Selected = true;
					MetodoPrincipalPDF(x);
					CalcularTotales();
					CalcularTotales();
					CalcularTotales();
					double residuo = 0;
					if(Math.Round(total, 2)>0)
					{
						if(Math.Round(total, 2)%5!=0)
						{
							residuo = Math.Round(total,2)%5;
							residuo = 5 - residuo;
							total = total + residuo;
						}
					}
					RetornoS = total; 
		    	}
		    }
			return RetornoS;
		}
		
		public double RetornoNumeroViajes(String AliasObj)
		{
			AdaptadorOperador();
			Importes();
			double RetornoV = 0.0;	
			FechaInicio = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().INICIO())).ToString("yyyy-MM-dd");
			FechaCorte = (Convert.ToDateTime(new Conexion_Servidor.Nomina.SQL_Nomina().FIN())).ToString("yyyy-MM-dd");
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
		    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==AliasObj)
		    	{
					if(x>0)
						dtOperador.Rows[x-1].Selected = false;
					AdaptadorNormales(x);
					AdaptadorEspeciales(x);
					SumaViajesNormales(dataViajesNormales);
					SumaViajesEspeciales();
					RetornoV = dataViajesEspeciales.RowCount + dataViajesNormales.RowCount; 
		    	}
		    }
			return RetornoV;
		}
		#endregion
		
		#region REGISTRAR NOMINAS
		void InsercionNominas()
		{
			String nomina = "";
			for(int x=0; x<dtOperador.Rows.Count; x++)
			{
				nomina = new Conexion_Servidor.Anticipos.SQL_Anticipos().ExistenciaNomina(dtOperador.Rows[x].Cells[0].Value.ToString(), FechaInicio, FechaCorte);
				//nomina = new Conexion_Servidor.Anticipos.SQL_Anticipos().ExistenciaNomina(dtOperador.Rows[x].Cells[0].Value.ToString(), dtInicio.Value.ToString().Substring(0,10), dtCorte.Value.ToString().Substring(0,10));
				if(nomina == "")
					new Conexion_Servidor.Nomina.SQL_Nomina().InsertarNomina(dtOperador.Rows[x].Cells[0].Value.ToString(), DateTime.Now.ToString().Substring(0,10), FechaInicio, FechaCorte);
				//  new Conexion_Servidor.Nomina.SQL_Nomina().InsertarNomina(dtOperador.Rows[x].Cells[0].Value.ToString(), DateTime.Now.ToString().Substring(0,10), dtInicio.Value.ToString().Substring(0,10), dtCorte.Value.ToString().Substring(0,10));
			}
		}
		#endregion
		
		#region CASETAS
		void DataViajesEspecialesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 12 && e.RowIndex >= 0)
				new Transportes_LAR.Interfaz.Nomina.Especiales.FormCobroCasetas(Convert.ToInt64(dataViajesEspeciales.Rows[e.RowIndex].Cells[0].Value), Convert.ToInt64(dtOperador.Rows[x].Cells[0].Value), Alias).ShowDialog();
		}

		void DataViajesEspecialesCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 12 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataViajesEspeciales.Rows[e.RowIndex].Cells[12] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\i.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		#endregion
		
		#region PRESTAMO ADICIONAL
		void BtnPrestamoAdicionalClick(object sender, EventArgs e)
		{
			id_descuento = "0";
			if(Convert.ToDouble(txtPrestamoAdicional.Text)>0)
			{
				new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), "PRESTAMO ADICIONAL", "A", Convert.ToDouble(txtPrestamoAdicional.Text), principal.idUsuario, "PRESTAMO DEL DIA DE PAGO");
				this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
				new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dtCorte.Value.AddDays(7).ToShortDateString(), "PRE 1/1", (Convert.ToDouble(txtPrestamoAdicional.Text)));
				txtPrestamoAdicional.Enabled = false;
				btnPrestamoAdicional.Enabled = false;
				CalcularTotales();
				CalcularTotales();
				CalcularTotales();
			}
			else
				MessageBox.Show("El prestamo deba de ser mayor a 0 ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		#endregion		
		
		void CbPeriodoCheckedChanged(object sender, EventArgs e)
		{
			if(cbPeriodo.Checked == false){				
				FechaInicio = (dtInicio.Value.ToString("yyyy-MM-dd"));
				FechaCorte = (dtCorte.Value.ToString("yyyy-MM-dd"));
				Fechecarpeta = dtInicio.Value.ToString("yyyy-MM-dd")+" al "+dtCorte.Value.ToString("yyyy-MM-dd");
				dtCorte.MinDate = dtInicio.Value;
				CalculoDiasTrabajados();
				MetodoPrincipalPDF(this.x);
				CalcularTotales();
				CalcularTotales();
				CalcularTotales();
				if(fechaaviso.ToString("yyyy-MM-dd")!=FechaInicio)
				{
					pOperador.BackColor =  Color.Red;
				}
				else
				{
					if(pOperador.BackColor==Color.Red)
						pOperador.BackColor = Color.WhiteSmoke;
				}
			}
		}
		
		private int DiasIncapacidades(string id_operador)
		{			
			DateTime FechaInicio = dtInicio.Value;
			DateTime FechaCorte = dtCorte.Value;
			
			bool boolInicio = false;
			bool boolFin = false;
			bool boolAmbos = false;
			bool boolIncapacitado = false;
			
			DateTime FechaInicioIncapacidad;
			DateTime FechaCorteIncapacidad;
			TimeSpan tsI01 =  (FechaCorte - FechaInicio);
			TimeSpan tsI02 =  (FechaCorte - FechaInicio);
			TimeSpan tsI03 =  (FechaCorte - FechaInicio);
					
			string consulta = "select FECHA_INICIO from INCAPACIDAD WHERE FECHA_INICIO BETWEEN '"+
				                      FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+id_operador;
				
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				FechaInicioIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString().Substring(0,10)));
				tsI01 = FechaCorte - FechaInicioIncapacidad;
				boolInicio = true;
			}			
			conn.conexion.Close();
			
			consulta = "select FECHA_FIN from INCAPACIDAD WHERE FECHA_FIN BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)
						+"' and ID_OPERADOR ="+id_operador;
			
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				FechaCorteIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_FIN"].ToString().Substring(0,10)));
				tsI02 = FechaCorteIncapacidad - FechaInicio;
				boolFin = true;
			}		
			conn.conexion.Close();
			
			consulta = "select FECHA_FIN, FECHA_INICIO from INCAPACIDAD WHERE FECHA_FIN BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)
						+"' and FECHA_INICIO BETWEEN '"+FechaInicio.ToString().Substring(0,10)+"' and '"+FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+id_operador;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				FechaCorteIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_FIN"].ToString().Substring(0,10)));
				FechaInicioIncapacidad = (Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString().Substring(0,10)));
				tsI03 = FechaCorteIncapacidad - FechaInicioIncapacidad;
				boolAmbos = true;
			}		
			conn.conexion.Close();
			
			consulta = "select FECHA_FIN, FECHA_INICIO from INCAPACIDAD WHERE FECHA_FIN >'"+FechaInicio.ToString().Substring(0,10)+"' and FECHA_INICIO <'"+
						FechaCorte.ToString().Substring(0,10)+"' and ID_OPERADOR ="+id_operador;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				boolIncapacitado = true;
			}	
			conn.conexion.Close();
				
			if((boolInicio == true)&&(boolFin == false))
				return Convert.ToInt32(tsI01.Days + 1);
			else if((boolInicio == false)&&(boolFin == true))
				return Convert.ToInt32(tsI02.Days + 1);
			else if(boolAmbos == true)
				return Convert.ToInt32(tsI03.Days + 1);
			else if(boolIncapacitado == true)
				return 14;
			else
				return 0;
		}
		
	}
}
