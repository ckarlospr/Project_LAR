using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using Transportes_LAR.Interfaz.Operaciones;

namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	public partial class FormPrincAnticipos : Form
	{
		#region VARIABLES
		int x = 0;
		int y = 0;
		int NumPagos = 0;
		int NumPagosExtra = 0;
		int totalPagos = 0;
		int id_operador = 0;
		double pantalonN = 0.0;
		double camisaN = 0.0;
		double CorbataE = 0.0;
		double GafeteE = 0.0;
		double totalNuevas = 0.0;
		double DescPant = 0.0;
		double DescCorbata = 0.0;
		double DescCamisa = 0.0;
		double DescGafete = 0.0;
		double totalC = 0.0;
		double totalP = 0.0;
		double pantalon = 0.00;
		double camisa = 0.00;
		double corbata = 0.00;
		double Gafete = 0.0;		
		double TotalSumaDescuentos=0.0;
		bool BoolResiduo = false;
		bool Tramite = false;
		String TipoDesc = "Regular";
		String Nombre = "";
		String id_descuento = "";
		String Descripcion = "prueba";
		String Residuo = "";
		String id_usuario = "";
		DateTime FechaDesglose;
		DateTime FechaComparacion = DateTime.Now;
		String [] ArrayContabilizador = new String[30];
		String [] ArrayPrestamos = new String[100];
		#endregion
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Interfaz.Nomina.Anticipos.FormPrestamoTotalizado formtotalizado = null;
		private Interfaz.Nomina.Anticipos.FormModificarFechaAnticipo ModificarFecha = null;
		Interfaz.Nomina.FormNomina fnomina = null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region CONSTRUCTORES
		public FormPrincAnticipos()
		{
			InitializeComponent();
		}
		
		public FormPrincAnticipos(Interfaz.FormPrincipal principal, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			Interfaz.Nomina.FormNomina formnomina = new Interfaz.Nomina.FormNomina(principal, id_usuario);
			this.fnomina = formnomina;
			fnomina.AdaptadorOperadorPrestamos();
			this.id_usuario = id_usuario;
		}
		
		public FormPrincAnticipos(Interfaz.FormPrincipal principal, String Alias, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			Interfaz.Nomina.FormNomina formnomina = new Interfaz.Nomina.FormNomina(principal, id_usuario);
			this.fnomina = formnomina;
			fnomina.AdaptadorOperadorPrestamos();
			txtAliasAnticipos.Text = Alias;
			this.id_usuario = id_usuario;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormPrincAnticiposLoad(object sender, EventArgs e)
		{
			Adaptadores();
			Validar(this);
			dtFechaActual.Value = DateTime.Now;
			PeriodoAnticipos();
			txtAliasAnticipos.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAliasAnticipos.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAliasAnticipos.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtOtroDescuento.AutoCompleteCustomSource = auto.AutocompletePrestamos();
			txtOtroDescuento.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOtroDescuento.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtEmpresa.AutoCompleteCustomSource = auto.AutocompleteEmpresa();
			txtEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource;
			Nivel();
			TraerPrecios();
			dtOperador.ClearSelection();
			dataPrincipal.Rows.Clear();
			dataDescuentoQuincenal.Rows.Clear();
			if(txtAliasAnticipos.Text!="")
			{
				BusquedaOperadorAlias();
				DatosOperador(x);
			}
			/*if(DateTime.Now.DayOfWeek.ToString()=="Wednesday")
			{
				btnTotalizar.Enabled=false;
			}*/
		}
		
		void FormPrincAnticiposFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.anticipos = false;
			fnomina = null;
		}
		#endregion
		
		#region ADAPTADORES
		void Adaptadores()
		{
			dtOperador.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, alias as Alias_Op, tipo_empleado from OPERADOR where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' order by alias");
		}
		
		public void AdaptadorDescuentoQuincenal(int x)
		{
			int contador = 0;
			
			dataDescuentoQuincenal.Rows.Clear();
			dataDescuentoQuincenal.ClearSelection();
			conn.getAbrirConexion("select DT.ID, DT.ID_DESCUENTO, DT.FECHA, DT.NOMENCLATURA, D.OBSERVACION, DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               "and FLUJO!='3' and FLUJO!='5' and  D.DESCRIPCION not like '%PRESTAMO%' AND D.DESCRIPCION not like '%CHOQUE%' " +
	                               "AND DT.FECHA between '"+dtInicio.Value.AddDays(2).ToString("yyyy/MM/dd")+"' " +
	                               "AND '"+dtCorte.Value.AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" " +
	                               "group by DT.ID, DT.ID_DESCUENTO, DT.FECHA, DT.NOMENCLATURA, D.OBSERVACION, DT.IMPORTE " +
	                               "order by DT.FECHA");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataDescuentoQuincenal.Rows.Add();
					dataDescuentoQuincenal.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[1].Value = conn.leer["ID_DESCUENTO"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[2].Value = conn.leer["FECHA"].ToString().Substring(0,10);
					dataDescuentoQuincenal.Rows[contador].Cells[3].Value = conn.leer["NOMENCLATURA"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[4].Value = conn.leer["OBSERVACION"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[5].Value = conn.leer["IMPORTE"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[6].Style.BackColor = Color.Black;
					dataDescuentoQuincenal.Rows[contador].Cells[7].Style.BackColor = Color.Black;
					++contador;
			}
			conn.conexion.Close();
			
			conn.getAbrirConexion("select DT.ID, DT.ID_DESCUENTO, DT.FECHA, DT.NOMENCLATURA, D.OBSERVACION, DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               "and FLUJO!='3' and FLUJO!='5' AND (D.DESCRIPCION like '%PRESTAMO%' OR D.DESCRIPCION like '%CHOQUE%') " +
	                               "and DT.FECHA between '"+dtInicio.Value.AddDays(1).ToString("yyyy/MM/dd")+"' " +
	                               "AND '"+dtCorte.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" " +
	                               "order by DT.FECHA");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataDescuentoQuincenal.Rows.Add();
					dataDescuentoQuincenal.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[1].Value = conn.leer["ID_DESCUENTO"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[2].Value = conn.leer["FECHA"].ToString().Substring(0,10);
					dataDescuentoQuincenal.Rows[contador].Cells[3].Value = conn.leer["NOMENCLATURA"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[4].Value = conn.leer["OBSERVACION"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[5].Value = conn.leer["IMPORTE"].ToString();
					dataDescuentoQuincenal.Rows[contador].Cells[6].Style.BackColor = Color.Black;
					dataDescuentoQuincenal.Rows[contador].Cells[7].Style.BackColor = Color.Black;
					++contador;
			}
			conn.conexion.Close();
		}
		
		public void AdaptadorDatosPrincipal(int x)
		{
			int contador = 0;
			
			dataPrincipal.Rows.Clear();
			dataPrincipal.ClearSelection();
			conn.getAbrirConexion("select D.ID, D.DESCRIPCION, D.IMPORTE_TOTAL "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               "and FLUJO!='5' and FLUJO!='3' AND D.DESCRIPCION not like '%PRESTAMO%' AND D.DESCRIPCION not like '%CHOQUE%' AND DT.FECHA between '"+dtInicio.Value.AddDays(2).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(2).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" " +
	                               "Group by D.ID, D.DESCRIPCION, D.IMPORTE_TOTAL");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataPrincipal.Rows.Add();
				dataPrincipal.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataPrincipal.Rows[contador].Cells[1].Value = conn.leer["DESCRIPCION"].ToString();
				dataPrincipal.Rows[contador].Cells[2].Value = conn.leer["IMPORTE_TOTAL"].ToString();
				dataPrincipal.Rows[contador].Cells[3].Style.BackColor = Color.Red;
				dataPrincipal.Rows[contador].Cells[4].Value = 0;
				if(dataPrincipal.Rows[contador].Cells[1].Value.ToString().Contains("CREDITO ADICIONAL") == true //|| dataPrincipal.Rows[contador].Cells[1].Value.ToString().Contains("Licencia") == true 
				   || dataPrincipal.Rows[contador].Cells[1].Value.ToString().Contains("Apto") == true)
					dataPrincipal.Rows[contador].Cells[4].ReadOnly=true;
				++contador;
			}
			conn.conexion.Close();
			
			dataPrincipal.ClearSelection();
			conn.getAbrirConexion("select D.ID, D.DESCRIPCION, D.IMPORTE_TOTAL "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               "and FLUJO!='3' and FLUJO!='5' AND (D.DESCRIPCION like '%PRESTAMO%' OR D.DESCRIPCION like '%CHOQUE%') and DT.FECHA between '"+dtInicio.Value.AddDays(1).ToString("yyyy/MM/dd")+"' AND '"+dtCorte.Value.AddDays(1).ToString("yyyy/MM/dd")+"' and D.ID_OPERADOR="+dtOperador[0,x].Value+" " +
	                               "Group by D.ID, D.DESCRIPCION, D.IMPORTE_TOTAL");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataPrincipal.Rows.Add();
				dataPrincipal.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataPrincipal.Rows[contador].Cells[1].Value = conn.leer["DESCRIPCION"].ToString();
				dataPrincipal.Rows[contador].Cells[2].Value = conn.leer["IMPORTE_TOTAL"].ToString();
				dataPrincipal.Rows[contador].Cells[3].Style.BackColor = Color.Red;
				dataPrincipal.Rows[contador].Cells[4].Value=0;
				++contador;
			}
			conn.conexion.Close();
			SumaDeudaQuincenal();
		}
		
		 public void AdaptadorPagos(DataGridView dataAnticipos, TextBox txtImporteAnticipos, TextBox txtNumPagosAnt, String Name)
		{
			int contador = 1;
			int AumentoFechas = 0;
			//date
			FechaDesglose = dtFechaActual.Value;
			if(rCasetas.Checked==true && txtID_RE.Text!="")
			{
				String query = "select top 1 FECHA_REGRESO from dbo.RUTA_ESPECIAL with(nolock) where ID_RE='19350'";
				conn.getAbrirConexion(query);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					FechaDesglose = Convert.ToDateTime(conn.leer["FECHA_REGRESO"].ToString());
				}
				conn.conexion.Close();
			}
			
			NumPagosExtra = 0;
			dataAnticipos.Rows.Clear();
			dataAnticipos.ClearSelection();
			if(txtNumPagosAnt.Text!=""&&txtImporteAnticipos.Text!="")
			{
				Desglose(txtImporteAnticipos, txtNumPagosAnt);
				for(int x=0; x<(Convert.ToInt32(NumPagos)); x++)
				{
					if(BoolResiduo == false)
					{
						dataAnticipos.Rows.Add();
						dataAnticipos.Rows[x].Cells[2].Value = FechaDesglose.AddDays(AumentoFechas).ToString("dd-MM-yyyy").Substring(0,10);
						dataAnticipos.Rows[x].Cells[3].Value = Name+" "+contador+"/"+(Convert.ToInt32(NumPagos));
						dataAnticipos.Rows[x].Cells[4].Value = Math.Round((Convert.ToDouble(txtNumPagosAnt.Text)), 2);
						++contador;
						AumentoFechas = AumentoFechas + 14;
					}
					else
					{
						dataAnticipos.Rows.Add();
						dataAnticipos.Rows[x].Cells[2].Value = FechaDesglose.AddDays(AumentoFechas).ToString("dd-MM-yyyy").Substring(0,10);
						dataAnticipos.Rows[x].Cells[3].Value = Name+" "+contador+"/"+(Convert.ToInt32(NumPagos+1));
						dataAnticipos.Rows[x].Cells[4].Value = Math.Round((Convert.ToDouble(txtNumPagosAnt.Text)), 2);
						++contador;
						AumentoFechas = AumentoFechas + 14;	
						
						if(x==(Convert.ToInt32(NumPagos))-1)
						{
							dataAnticipos.Rows.Add();
							dataAnticipos.Rows[x+1].Cells[2].Value = FechaDesglose.AddDays(AumentoFechas).ToString("dd-MM-yyyy").Substring(0,10);
							dataAnticipos.Rows[x+1].Cells[3].Value = Name+" "+contador+"/"+(Convert.ToInt32(NumPagos+1));
							dataAnticipos.Rows[x+1].Cells[4].Value = Math.Round((Convert.ToDouble(Residuo)), 2);
							++contador;
							AumentoFechas = AumentoFechas + 14;	
							NumPagosExtra = NumPagos + 1;
						}
					}
				}
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTO PRINCIPAL
		void DtOperadorCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			int x = 0;
			id_operador = 0;
			
			if(txtAliasAnticipos.Text!="")
			{
				if(e.RowIndex>-1)
				{
					Limpiar();
					x = dtOperador.CurrentRow.Index;
					id_operador = (Convert.ToInt32(dtOperador[0,x].Value));
					this.x = x;
					AdaptadorDescuentoQuincenal(x);
					AdaptadorDatosPrincipal(x);
				}
			}
		}
		#endregion
		
		#region VALIDAR
		void Validar(Interfaz.Nomina.Anticipos.FormPrincAnticipos formAnticipos)
		{
			formAnticipos.txtPantN.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formAnticipos.txtCamN.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formAnticipos.txtCorbatE.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formAnticipos.txtDescPant.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtCostoP.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtDescCam.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtDescCorbata.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtNumPagos.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtNumPagosAnt.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtImporteAnticipos.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtImporteLicApto.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formAnticipos.txtID_RE.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
		
		#region METODO GUARDAR
			void GuardarUniforme()
			{
				Descripcion = "";
				String fechamax = "";
				bool Uniforme = false;
				this.id_descuento="";
				
				if(txtPantN.Text!="0"&&txtPantN.Text!="")
				{
					if(pantalonN>1)
						Descripcion += pantalonN + " Pantalones Nuevos ";
					else
						Descripcion += pantalonN + " Pantalón Nuevo ";
				}
				
				if(txtCamN.Text!="0"&&txtCamN.Text!="")
				{
					if(camisaN>1)
						Descripcion += camisaN + " Camisas Nuevas ";
					else
						Descripcion += camisaN + " Camisa Nueva ";
				}
				
				if(txtCorbatE.Text!="0"&&txtCorbatE.Text!="")
				{
					if(CorbataE>1)
						Descripcion += CorbataE + " Corbatas Extras ";
					else
						Descripcion += CorbataE + " Corbata Extra ";
				}
				
				if(txtGafeteE.Text!="0"&&txtGafeteE.Text!="")
				{
					if(GafeteE>1)
						Descripcion += CorbataE + " Gafetes Extras ";
					else
						Descripcion += CorbataE + " Gafete Extra ";
				}
				
				if(txtTotalPrendas.Text!="0" && txtAliasAnticipos.Text!="" && txtNombreAnticipos.Text!="")
				{
					Uniforme = new Conexion_Servidor.Anticipos.SQL_Anticipos().TraerTramite((Convert.ToInt32(dtOperador[0,x].Value)).ToString(),  dtInicio.Value.ToString().Substring(0,10), dtCorte.Value.ToString().Substring(0,10), "U");
					if(Uniforme==false)
					{
						new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), "UNIFORME", "U", (Convert.ToDouble(txtTotalCosto.Text)), principal.idUsuario, Descripcion);
						this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
						for(int contador = 0; contador<dataDescuentosUniformes.RowCount; contador++)
							new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataDescuentosUniformes.Rows[contador].Cells[2].Value.ToString(), dataDescuentosUniformes.Rows[contador].Cells[3].Value.ToString(), (Convert.ToDouble(dataDescuentosUniformes.Rows[contador].Cells[4].Value)));
					
						AdaptadorDescuentoQuincenal(x);
						AdaptadorDatosPrincipal(x);
						dataDetalleUniforme.Rows.Clear();
					}
					else
					{
						MessageBox.Show("No es posible realizar la operación porque ya tiene un registro Vigente", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						fechamax = new Conexion_Servidor.Anticipos.SQL_Anticipos().TraerFechaDisponibleUniforme((Convert.ToInt32(dtOperador[0,x].Value)).ToString());
						DialogResult boton1 = MessageBox.Show("Quieres poner el descuento en la siguiente fecha disponible? Sería el "+fechamax+"", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (boton1 == DialogResult.Yes)
						{
							dtFechaActual.Value = (Convert.ToDateTime(fechamax));
							SumaCostos();
							new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), "UNIFORME", "U", (Convert.ToDouble(txtTotalCosto.Text)), principal.idUsuario, Descripcion);
							this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
							for(int contador = 0; contador<dataDescuentosUniformes.RowCount; contador++)
								new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataDescuentosUniformes.Rows[contador].Cells[2].Value.ToString(), dataDescuentosUniformes.Rows[contador].Cells[3].Value.ToString(), (Convert.ToDouble(dataDescuentosUniformes.Rows[contador].Cells[4].Value)));
						
							AdaptadorDescuentoQuincenal(x);
							AdaptadorDatosPrincipal(x);
							dataDetalleUniforme.Rows.Clear();
						}
					}
				}
				else
					MessageBox.Show("El registro no contiene nada!! Inserta las prendas correspondientes", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
			void GuardarTramites()
			{
				Descripcion = "";
				Tramite = false;
				this.id_descuento="";
				
				if((txtNumPagos.Text!="" && txtImporteLicApto.Text!="" && txtAliasAnticipos.Text!="" && txtNombreAnticipos.Text!=""))
				{
					if((Convert.ToDouble(txtNumPagos.Text)>0) && (Convert.ToDouble(txtImporteLicApto.Text)>0))
					{
						if(rApto.Checked == true)
							Descripcion = "Apto Medico";
						else if(rFederal.Checked == true)
							Descripcion = "Licencia Federal";
						else if(rEstatal.Checked == true)
							Descripcion = "Licencia Estatal";
						
						Tramite = new Conexion_Servidor.Anticipos.SQL_Anticipos().TraerTramite((Convert.ToInt32(dtOperador[0,x].Value)).ToString(),  dtInicio.Value.ToString().Substring(0,10), dtCorte.Value.ToString().Substring(0,10), "L");
		
						if(Tramite==false)
						{
							new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), Descripcion, "L", TotalSumaDescuentos, principal.idUsuario, "");
							this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
							for(int contador = 0; contador<dataPagosLicApto.RowCount; contador++)
								new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataPagosLicApto.Rows[contador].Cells[2].Value.ToString(), dataPagosLicApto.Rows[contador].Cells[3].Value.ToString(), (Convert.ToDouble(dataPagosLicApto.Rows[contador].Cells[4].Value)));

							AdaptadorDescuentoQuincenal(x);
							AdaptadorDatosPrincipal(x);
							AdaptadorPagos(dataPagosLicApto, txtImporteLicApto, txtNumPagos, "LIC");
							txtNumPagos.Text="";
							dataDetalleTramites.Rows.Clear();
						}
						else
							MessageBox.Show("No es posible realizar la operación porque ya tiene un tramite Vigente", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
						MessageBox.Show("No es posible Guardar en 0", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
					MessageBox.Show("Existen Campos sin llenar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
			void GuardarDescuentos(DataGridView dataAnticipos, TextBox txtImporteAnticipos, TextBox txtNumPagosAnt, TextBox txtOtroDescuento, String Name)
			{
				Descripcion = "";
				this.id_descuento="";
				bool caseta = false;
				
				//TraerPrecios fecha de regreso de ruta especial
				if(rCasetas.Checked==true && txtID_RE.Text!="")
				{
					String query = "select top 1 FECHA_REGRESO from dbo.RUTA_ESPECIAL with(nolock) where ID_RE='19350'";
					conn.getAbrirConexion(query);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						caseta = true;
					}
					conn.conexion.Close();
				}
				
				if(caseta==true || rCasetas.Checked==false)
				{
					if(txtNumPagosAnt.Text!="" &&  txtImporteAnticipos.Text!="" && txtOtroDescuento.Text!="" && txtAliasAnticipos.Text!="" && txtNombreAnticipos.Text!="")
					{
						if((Convert.ToDouble(txtNumPagosAnt.Text)>0) && (Convert.ToDouble(txtImporteAnticipos.Text)>0))
						{
							if(rChoque.Checked == true)
								Descripcion = rChoque.Text ;
							else if(rCasetas.Checked == true)
								Descripcion = rCasetas.Text;
							else if(rCombustible.Checked == true)
								Descripcion = rCombustible.Text;
							else if(rFuneral.Checked == true)
								Descripcion = rFuneral.Text;
							else if(rInfracciones.Checked == true)
								Descripcion = rInfracciones.Text;
							else if(rPrestamo.Checked == true)
							{
								Descripcion = rPrestamo.Text;
								Name = "A";
							}
							else if(rTaxi.Checked == true)
								Descripcion = rTaxi.Text;
							else if(rTepadi.Checked == true)
								Descripcion = rTepadi.Text;
							else if(rOtroPrestamo.Checked == true)
								Descripcion =  txtOtroDescuento.Text;
							else if(rTaller.Checked == true)
							{
								Descripcion = rTaller.Text;
								Name = "T";
							}
							
							if(Descripcion=="CHOQUE" || Descripcion=="TAXI")
							{
								if(txtDescripcion.Text!="FAVOR DE INSERTAR LA EMPRESA" && txtDescripcion.Text!="FAVOR DE INSERTAR LA DESCRIPCIÓN DEL ACCIDENTE" && txtDescripcion.Text!="")
								{
									new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), Descripcion, Name, TotalSumaDescuentos, principal.idUsuario, txtDescripcion.Text);
									this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
									for(int contador = 0; contador<dataAnticipos.RowCount; contador++)
										new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataAnticipos.Rows[contador].Cells[2].Value.ToString(), dataAnticipos.Rows[contador].Cells[3].Value.ToString(), (Convert.ToDouble(dataAnticipos.Rows[contador].Cells[4].Value)));
	
									AdaptadorDescuentoQuincenal(x);
									AdaptadorDatosPrincipal(x);
									dataAnticipos.Rows.Clear();
									dataDetallePrestamosOtros.Rows.Clear();
									txtNumPagosAnt.Text="";
									txtImporteAnticipos.Text="";
								}
								else
									MessageBox.Show("Favor de llenar el campo rosa", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
							else
							{
								new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), Descripcion, Name, TotalSumaDescuentos, principal.idUsuario, txtDescripcion.Text);
								this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
								for(int contador = 0; contador<dataAnticipos.RowCount; contador++)
									new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataAnticipos.Rows[contador].Cells[2].Value.ToString(), dataAnticipos.Rows[contador].Cells[3].Value.ToString(), (Convert.ToDouble(dataAnticipos.Rows[contador].Cells[4].Value)));
	
								AdaptadorDescuentoQuincenal(x);
								AdaptadorDatosPrincipal(x);
								dataAnticipos.Rows.Clear();
								dataDetallePrestamosOtros.Rows.Clear();
								txtNumPagosAnt.Text="";
								txtImporteAnticipos.Text="";
							}
						}
						else
							MessageBox.Show("No es posible Guardar en 0", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
						MessageBox.Show("Existen Campos sin llenar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("El ID_RE no es correcto", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtID_RE.Focus();
					txtID_RE.SelectAll();
				}
			}
			
			void GuardarLiquidacion(DataGridView dataAnticipos)
			{
				Descripcion = "";
				this.id_descuento="";
				if(txtAliasAnticipos.Text!="")
				{
					Descripcion = "Liquidación";
					for(int contador = 0; contador<dataAnticipos.RowCount; contador++)
					{
						new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), "LIQUIDACION "+dataAnticipos.Rows[contador].Cells[1].Value.ToString(), "LIQ", (Convert.ToDouble(dataAnticipos.Rows[contador].Cells[4].Value)), principal.idUsuario, "LIQUIDACION");
						this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
						new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataAnticipos.Rows[contador].Cells[1].Value.ToString(), dataAnticipos.Rows[contador].Cells[2].Value.ToString(), (Convert.ToDouble(dataAnticipos.Rows[contador].Cells[4].Value)));
					}
					
					for(int contador = 0; contador<dataPrincipal.RowCount; contador++)
					{
						new Conexion_Servidor.Anticipos.SQL_Anticipos().EliminarDescuento(dataPrincipal.Rows[contador].Cells[0].Value.ToString(), id_usuario, "LIQUIDACION DEL PRESTAMO");
					}
					AdaptadorDescuentoQuincenal(x);
					AdaptadorDatosPrincipal(x);
					dataAnticipos.Rows.Clear();
				}
				else
					MessageBox.Show("Existen Campos sin llenar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			#endregion
			
		#region METODO ELIMINAR
		void DataPrincipalUniCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==3)
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de eliminar este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					//new Conexion_Servidor.Anticipos.SQL_Anticipos().EliminarDescuento(dataPrincipal[0,e.RowIndex].Value.ToString());
					new Interfaz.Nomina.Anticipos.FormMotivoEliminar(dataPrincipal[0,e.RowIndex].Value.ToString(), id_usuario).ShowDialog();
					AdaptadorDescuentoQuincenal(x);
					AdaptadorDatosPrincipal(x);
				}
			}
			if(e.ColumnIndex==4)
			{
				if(((Convert.ToInt32(dataPrincipal.Rows[e.RowIndex].Cells[4].Value))==0)&&(dataPrincipal.Rows[e.RowIndex].Cells[4].ReadOnly==false))
					dataPrincipal.Rows[e.RowIndex].Cells[4].Value=1;
				else
					dataPrincipal.Rows[e.RowIndex].Cells[4].Value=0;
			}
			
		}
		#endregion
			
		#region UNIFORME
		
			#region VALIDACION PUNTO
			void TxtPantNTextChanged(object sender, EventArgs e)
			{
				if(txtPantN.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;

				SumaPrendas();
			}
			
			
			void TxtCamNTextChanged(object sender, EventArgs e)
			{
				if(txtCamN.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				
				SumaPrendas();
			}
			
			void TxtCorbatETextChanged(object sender, EventArgs e)
			{
				if(txtCorbatE.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				
				SumaPrendas();
			}
			
			void TxtDescPantTextChanged(object sender, EventArgs e)
			{
				if(txtDescPant.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				SumaCostos();
			}
			
			void TxtDescCamTextChanged(object sender, EventArgs e)
			{
				if(txtDescCam.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				SumaCostos();
			}
			
			void TxtDescCorbataTextChanged(object sender, EventArgs e)
			{
				if(txtDescCorbata.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				SumaCostos();
			}
			
			void TxtDescGafeteTextChanged(object sender, EventArgs e)
			{
			if(txtDescGafete.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				SumaCostos();
			}
		
			void TxtGafeteETextChanged(object sender, EventArgs e)
			{
			if(txtGafeteE.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				SumaPrendas();
			}
			
			void TxtCostoPTextChanged(object sender, EventArgs e)
			{
				if(txtCostoP.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				SumaCostos();
			}
			#endregion
			
			#region VALORES NULOS
			void EntregarValorNull()
			{
				if(txtPantN.Text.Equals(""))
					pantalonN=0.0;
				else
					pantalonN = Convert.ToDouble(txtPantN.Text);
				
				if(txtCamN.Text.Equals(""))
					camisaN=0.0;
				else
					camisaN = Convert.ToDouble(txtCamN.Text);
				
				if(txtCorbatE.Text.Equals(""))
					CorbataE=0.0;
				else
					CorbataE = Convert.ToDouble(txtCorbatE.Text);
				
				if(txtGafeteE.Text.Equals(""))
					GafeteE=0.0;
				else
					GafeteE = Convert.ToDouble(txtGafeteE.Text);
				
				if(txtDescPant.Text.Equals("")||txtDescPant.Text.Equals(".")||txtDescPant.Text.Equals("0")||txtDescPant.Text.Equals("0.")||txtDescPant.Text.Equals("0.0")||txtDescPant.Text.Equals(".0"))
					DescPant  = 0.0;
				else
					DescPant = Convert.ToDouble(txtDescPant.Text);
				
				if(txtDescCam.Text.Equals("")||txtDescCam.Text.Equals(".")||txtDescCam.Text.Equals("0")||txtDescCam.Text.Equals("0.")||txtDescCam.Text.Equals("0.0")||txtDescCam.Text.Equals(".0"))
					DescCamisa  = 0.0;
				else
					DescCamisa = Convert.ToDouble(txtDescCam.Text);
				
				if(txtDescCorbata.Text.Equals("")||txtDescCorbata.Text.Equals(".")||txtDescCorbata.Text.Equals("0")||txtDescCorbata.Text.Equals("0.")||txtDescCorbata.Text.Equals("0.0")||txtDescCorbata.Text.Equals(".0"))
					DescCorbata  = 0.0;
				else
					DescCorbata = Convert.ToDouble(txtDescCorbata.Text);
				
				if(txtDescGafete.Text.Equals("")||txtDescGafete.Text.Equals(".")||txtDescGafete.Text.Equals("0")||txtDescGafete.Text.Equals("0.")||txtDescGafete.Text.Equals("0.0")||txtDescGafete.Text.Equals(".0"))
					DescGafete  = 0.0;
				else
					DescGafete = Convert.ToDouble(txtDescGafete.Text);
			}
			#endregion
			
			#region CALCULO DE PRENDAS
			void SumaPrendas()
			{
				EntregarValorNull();
				
				totalNuevas = camisaN + pantalonN + CorbataE + GafeteE;
				
				txtTotalPrendas.Text = totalNuevas.ToString();
				
				txtDescPant.Text = (pantalonN * (Convert.ToDouble(dataValores.Rows[4].Cells[2].Value))).ToString();
				txtDescCorbata.Text = (CorbataE * (Convert.ToDouble(dataValores.Rows[5].Cells[2].Value))).ToString();
				txtDescCam.Text = (camisaN * (Convert.ToDouble(dataValores.Rows[3].Cells[2].Value))).ToString();
				txtDescGafete.Text = (GafeteE * (Convert.ToDouble(txtCostoP.Text))).ToString();
			}
			
			void SumaCostos()
			{
				totalC = 0.0;
				totalP = 0.0;
				
				if(txtDescPant.Text=="")
					pantalon = 0.00;
				else
					pantalon = (Convert.ToDouble(txtDescPant.Text));
				
				if(txtDescCam.Text=="")
					camisa =  0.00;
				else
					camisa =  (Convert.ToDouble(txtDescCam.Text));
				
				if(txtDescCorbata.Text=="")
					corbata =  0.00;
				else
					corbata =  (Convert.ToDouble(txtDescCorbata.Text));
				
				if(txtDescGafete.Text=="")
					Gafete =  0.00;
				else
					Gafete =  (Convert.ToDouble(txtDescGafete.Text));
				
				txtTotalCosto.Text = (pantalon + camisa + corbata + Gafete).ToString();
				totalC = (Convert.ToDouble(txtTotalCosto.Text));
				
				if(txtCostoP.Text!=""&&(Convert.ToDouble(txtCostoP.Text)>1))
					totalP = (Convert.ToDouble(txtCostoP.Text));
				else
					totalP = 100.0;
					
				totalPagos = (Convert.ToInt32(totalC / totalP));
				AdaptadorPagos(dataDescuentosUniformes, txtTotalCosto, txtCostoP, "U");
				
				if(totalPagos>0)
					ContabilizadorPagos(dataDescuentosUniformes, dataDetalleUniforme);
			}
			#endregion
			
			#region TIMER
			void TimeCalcularTick(object sender, EventArgs e)
			{
				EntregarValorNull();
			}
			#endregion
			
			#region LIMPIAR
			void Limpiar()
			{
				txtPantN.Text = "0";
				txtCamN.Text = "0";
				txtCorbatE.Text = "0";
				txtDescCorbata.Text = "0.00";
				txtDescCam.Text = "0.00";
				txtDescPant.Text = "0.00";			
			}
			#endregion
				
		#endregion
	
		#region METODOS DE SUMA DATAGRID
		void SumaPagos(DataGridView dataPagos, int NumPagos)
		{
			TotalSumaDescuentos = 0.0;
			
			for(int x=0; x<NumPagos; x++)
				TotalSumaDescuentos = TotalSumaDescuentos + (Convert.ToDouble(dataPagos.Rows[x].Cells[4].Value));
		}
		#endregion
		
		#region PERIODO ANTICIPOS
		void PeriodoAnticipos()
		{
			conn.getAbrirConexion("select FECHAINICIO, FECHAFIN from PERIODO WHERE FECHAINICIO <= '"+dtFechaActual.Value.ToString().Substring(0,10)+"' and FECHAFIN >= '"+dtFechaActual.Value.AddDays(-2).ToString().Substring(0,10)+"'");
			conn.leer=conn.comando.ExecuteReader();
            if(conn.leer.Read())
            {
            	dtInicio.Value = (Convert.ToDateTime(conn.leer["FECHAINICIO"].ToString().Substring(0,10)));
            	dtCorte.Value = (Convert.ToDateTime(conn.leer["FECHAFIN"].ToString().Substring(0,10)));
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region BOTONES
		void BtnAceptarClick(object sender, EventArgs e)
		{
			GuardarUniforme();
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnAceptarLicenciaClick(object sender, EventArgs e)
		{
			if(dataPagosLicApto.RowCount>0)
			{
				SumaPagos(dataPagosLicApto, NumPagosExtra);
				GuardarTramites();
			}
			else
				MessageBox.Show("No hay Datos para guardar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		void MenuConcetradoDescuentosClick(object sender, EventArgs e)
		{
			Excels.ConcetradoDescuento(principal);
		}
		
		void BtnAnticiposClick(object sender, EventArgs e)
		{
			if(rCasetas.Checked==true && txtID_RE.Text=="")
			{
				MessageBox.Show("Ingrese ID de ruta especial", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtID_RE.Focus();
			}
			else
			{
				if(dataAnticipos.RowCount>0)
				{
					SumaPagos(dataAnticipos, NumPagosExtra);
					GuardarDescuentos(dataAnticipos, txtImporteAnticipos, txtNumPagosAnt, txtOtroDescuento, "D");
				}
				else
					MessageBox.Show("No hay Datos para guardar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
				txtDescripcion.Text = "";
			}
		}
		
		void BtnTotalizarClick(object sender, EventArgs e)
		{
				formtotalizado = new Interfaz.Nomina.Anticipos.FormPrestamoTotalizado(txtNombreAnticipos.Text, dataPrincipal, dtInicio.Value, dtCorte.Value, dtOperador[0,x].Value.ToString(), principal, this, x);
				formtotalizado.ShowDialog();
				formtotalizado.BringToFront();
		}
		
		void BtnRecalcularClick(object sender, EventArgs e)
		{
			DialogResult boton1 = MessageBox.Show("Esta Seguro de Modificar los Pagos?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if (boton1 == DialogResult.Yes)
			{
				if(ckLiquidar.Checked==true)
				{
					GuardarLiquidacion(dataLiquidacion);				
					AdaptadorDescuentoQuincenal(x);
					AdaptadorDatosPrincipal(x);
				}
				else
				{
					AdaptadorDescuentoQuincenal(x);
					AdaptadorDatosPrincipal(x);
				}
			}
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			for(int x=0; x<dataValores.Rows.Count; x++)
				new Conexion_Servidor.Anticipos.SQL_Anticipos().ActualizarValores(dataValores.Rows[x].Cells[0].Value.ToString(), dataValores.Rows[x].Cells[2].Value.ToString());
		}
		
		#endregion
		
		#region EVENTO DATAPICKER
		void DtFechaActualValueChanged(object sender, EventArgs e)
		{
			PeriodoAnticipos();
			AdaptadorDescuentoQuincenal(x);
			AdaptadorDatosPrincipal(x);
			ckLiquidar.Checked = false;
			if(tabDescuentos.SelectedTab==tabAnticipos)
			{
				NumeroPagosPrincipal();
			}
			if(tabDescuentos.SelectedTab==tabLicencia)
			{
				NumeroPagosTramites();
			}
			if(tabDescuentos.SelectedTab==tabUniforme)
			{
				SumaCostos();
			}
			
		}
		#endregion
		
		#region METODOS DE PAGO
		void NumeroPagosPrincipal()
		{
			if(txtNumPagosAnt.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			
			if(txtNumPagosAnt.Text!=""&&txtImporteAnticipos.Text!="")
			{
				if ((Convert.ToDouble(txtNumPagosAnt.Text))>(Convert.ToDouble(txtImporteAnticipos.Text)))
				{
	               txtNumPagosAnt.Text= "0";
	               dataAnticipos.Rows.Clear();
	               MessageBox.Show("Numero mayor al de importe", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            }
				else
				{
					Descripcion = "";
					
					if(rChoque.Checked == true)
						Descripcion = rChoque.Text;
					else if(rCasetas.Checked == true)
						Descripcion = rCasetas.Text;
					else if(rCombustible.Checked == true)
						Descripcion = rCombustible.Text;
					else if(rFuneral.Checked == true)
						Descripcion = rFuneral.Text;
					else if(rInfracciones.Checked == true)
						Descripcion = rInfracciones.Text;
					else if(rPrestamo.Checked == true)
					{
						Descripcion = rPrestamo.Text;
						Name = "A";
					}
					else if(rTaxi.Checked == true)
						Descripcion = rTaxi.Text;
					else if(rTepadi.Checked == true)
						Descripcion = rTepadi.Text;
					else if(rOtroPrestamo.Checked == true)
						Descripcion =  txtOtroDescuento.Text;
					else if(rTaller.Checked == true)
					{
						Descripcion = rTaller.Text;
						Name = "T";
					}
					try
					{
						if(Descripcion!="")
						{
							AdaptadorPagos(dataAnticipos, txtImporteAnticipos, txtNumPagosAnt, Descripcion.Substring(0,3));
						if((Convert.ToDouble(txtNumPagosAnt.Text))>0)
							ContabilizadorPagos(dataAnticipos, dataDetallePrestamosOtros);
						}
					}
					catch(Exception ex)
					{
						 MessageBox.Show(""+ex, "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}
		
		void NumeroPagosTramites()
		{
			if(txtNumPagos.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			
			if(txtNumPagos.Text!=""&&txtImporteLicApto.Text!="")
			{
				if ((Convert.ToDouble(txtNumPagos.Text))>(Convert.ToDouble(txtImporteLicApto.Text)))
				{
	               txtNumPagos.Text= "0";
	               dataDetalleTramites.Rows.Clear();
	               MessageBox.Show("Numero mayor al de importe", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            }
				else
				{
					AdaptadorPagos(dataPagosLicApto, txtImporteLicApto, txtNumPagos, "LIC");
					if((Convert.ToDouble(txtNumPagos.Text))>0)
						ContabilizadorPagos(dataPagosLicApto, dataDetalleTramites);
				}
			}
		}
		#endregion
		
		#region EVENTO NUMERO DE PAGOS
		void TxtNumPagosAntTextChanged(object sender, EventArgs e)
		{
			NumeroPagosPrincipal();
		}
		
		void TxtNumPagosTextChanged(object sender, EventArgs e)
		{
			NumeroPagosTramites();
		}
		
		void TxtImporteAnticiposTextChanged(object sender, EventArgs e)
		{
			if(txtImporteAnticipos.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
	
			txtNumPagosAnt.Text = txtImporteAnticipos.Text;
		}
		
		void TxtImporteLicAptoTextChanged(object sender, EventArgs e)
		{
			if(txtImporteLicApto.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			
			txtNumPagos.Text = txtImporteLicApto.Text;
		}

		#endregion
		
		#region BUSQUEDA OPERADOR
		void BusquedaOperadorAlias()
		{
				for(int x=0; x<dtOperador.Rows.Count; x++)
				{
					if(txtAliasAnticipos.Text==dtOperador.Rows[x].Cells[1].Value.ToString())
						{
							dtOperador.ClearSelection();
							dtOperador.Focus();
							dtOperador.Rows[x].Cells[1].Selected = true;
							this.x = x;
							SumaDeudaQuincenal();
						}
				}
		}
		#endregion
		
		#region EVENTO KEY UP		
		void TxtAliasAnticiposKeyUp(object sender, KeyEventArgs e)
		{
			 if (e.KeyCode == Keys.Enter)
		      {
		       	BusquedaOperadorAlias();
		       	DatosOperador(x);
		       	ckLiquidar.Checked = false;
		      }
		}
		#endregion
		
		#region DATOS OPERADOR
		void DatosOperador(int x)
		{
			Nombre = "";
			conn.getAbrirConexion("select O.Nombre, O.Apellido_Pat, O.Apellido_Mat from Operador O where O.ID ="+dtOperador[0,x].Value);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				Nombre = conn.leer["Nombre"].ToString()+" "+conn.leer["Apellido_Pat"].ToString()+" "+conn.leer["Apellido_Mat"].ToString();

			conn.conexion.Close();
			txtNombreAnticipos.Text = Nombre;
			TimeSpan ts = DateTime.Now - (Convert.ToDateTime(new Conexion_Servidor.Anticipos.SQL_Anticipos().FechaIngreso(dtOperador.Rows[x].Cells[0].Value.ToString())));
			lblFechaInicio.Text = ts.Days.ToString()+" dias";
			lblTipoContrato.Text = new Conexion_Servidor.Contrato.SQL_Contrato().TipoContrato(dtOperador.Rows[x].Cells[0].Value.ToString());
		}
		#endregion
		
		#region DESGLOSE
		void Desglose(TextBox txtImporte, TextBox txtDescuentoQ)
		{
			BoolResiduo = false;
			Residuo = "";
			NumPagos = 0;
			try
			{
				if((Convert.ToDouble(txtImporte.Text))>0)
				{
					Residuo = (Convert.ToInt64(Math.Truncate(Convert.ToDouble(txtImporte.Text)%(Convert.ToDouble(txtDescuentoQ.Text))))).ToString();
				
					if((Convert.ToDouble(txtDescuentoQ.Text))>0)
					{
						if((Convert.ToDouble(Residuo)==0) || Residuo.ToString()==txtDescuentoQ.Text)
						{
							BoolResiduo = false;
							NumPagos = Convert.ToInt32(Convert.ToDouble(txtImporte.Text)/(Convert.ToDouble(txtDescuentoQ.Text)));
							NumPagosExtra = NumPagos;
						}
						else if((Convert.ToDouble(Residuo)>0) && Residuo.ToString()!=txtDescuentoQ.Text)
						{
							BoolResiduo = true;
							NumPagos = Convert.ToInt32(Math.Truncate(Convert.ToDouble(txtImporte.Text)/(Convert.ToDouble(txtDescuentoQ.Text))));
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(""+ex);
			}
		}
		#endregion
		
		#region VALIDACION DATAGRID
		void DataAnticiposEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			((TextBox)e.Control).KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void DataPagosLicAptoEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			((TextBox)e.Control).KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void DataOtrosEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			((TextBox)e.Control).KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void DataPagosTallerEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			((TextBox)e.Control).KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void DataValoresEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (dataValores.CurrentCell.ColumnIndex == 2)
				((TextBox)e.Control).KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
		}
		#endregion
		
		#region ADEUDOS
		void DeudaRestante()
		{
			int plus = 0;
			dataLiquidacion.Rows.Clear();
			dataLiquidacion.ClearSelection();
			for(int x=0; x<dataPrincipal.Rows.Count; x++)
			{
				if(dataPrincipal.Rows[x].Cells[1].Value.ToString().ToUpper().Contains("LICENCIA")==false)
				{
					dataLiquidacion.Rows.Add();
					dataLiquidacion.Rows[plus].Cells[0].Value = dataPrincipal.Rows[x].Cells[0].Value;
					dataLiquidacion.Rows[plus].Cells[1].Value = DateTime.Now.ToString("dd-MM-yyyy");
					dataLiquidacion.Rows[plus].Cells[2].Value = dataPrincipal.Rows[x].Cells[1].Value.ToString().Substring(0,3)+" "+(dataPrincipal[0,x].Value).ToString();
					dataLiquidacion.Rows[plus].Cells[3].Value = dataPrincipal.Rows[x].Cells[1].Value;			
					dataLiquidacion.Rows[plus].Cells[4].Value = new Conexion_Servidor.Anticipos.SQL_Anticipos().TraerDescuentoNominal(dtInicio.Value.ToString().Substring(0,10), (Convert.ToInt32(dataPrincipal[0,x].Value)).ToString(), (dataPrincipal[1,x].Value).ToString());
					++plus;
				}
			}
		}
		#endregion
		
		#region EVENTO ENTER
		void DataPrincipalCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>0)
			{
				y = dataPrincipal.CurrentRow.Index;
			}
		}
		
		void TxtImporteAnticiposEnter(object sender, EventArgs e)
		{
			txtImporteAnticipos.Text="";
		}
		
		void TxtNumPagosAntEnter(object sender, EventArgs e)
		{
			txtNumPagosAnt.Text="";
		}
		
		void TxtImporteLicAptoEnter(object sender, EventArgs e)
		{
			txtImporteLicApto.Text="";
		}
		
		void TxtNumPagosEnter(object sender, EventArgs e)
		{
			txtNumPagos.Text="";
		}
		
		void TxtPantNEnter(object sender, EventArgs e)
		{
			txtPantN.Text="";
		}
		
		void TxtCamNEnter(object sender, EventArgs e)
		{
			txtCamN.Text="";
		}
		
		void TxtCorbatEEnter(object sender, EventArgs e)
		{
			txtCorbatE.Text="";
		}
		
		void TxtDescPantEnter(object sender, EventArgs e)
		{
			txtDescPant.Text="";
		}
		
		void TxtDescCamEnter(object sender, EventArgs e)
		{
			txtDescCam.Text="";
		}
		
		void TxtDescCorbataEnter(object sender, EventArgs e)
		{
			txtDescCorbata.Text="";
		}
		
		void TxtDescGafeteEnter(object sender, EventArgs e)
		{
			txtDescGafete.Text="";
		}
		
		void TxtGafeteEEnter(object sender, EventArgs e)
		{
			txtGafeteE.Text="";
		}
		#endregion
		
		#region PRIVILEGIOS
		void Nivel()
		{
			if(principal.lblDatoNivel.Text!="GERENCIAL" && principal.lblDatoNivel.Text!="COBRANZA" && principal.lblDatoNivel.Text!="MASTER" && principal.lblDatoNivel.Text!="NOMINA")
			{
				toolMenu.Enabled=false;
				tabDescuentos.TabPages.Remove(tabAnticipos);
				tabDescuentos.TabPages.Remove(tabVariables);
				tabDescuentos.TabPages.Remove(tabModPagos);
				dataPrincipal.Columns[3].Visible=false;
				dataPrincipal.Columns[4].Visible=false;
				dataDescuentoQuincenal.Columns[2].Visible = false;
				lblDescuentoQuincenal.Visible = false;
				lblSueldoQuincenal.Visible = false;
				lblRestante.Visible = false;
			}
			if(principal.lblDatoNivel.Text=="NOMINA")
			{
				tabDescuentos.TabPages.Remove(tabUniforme);
			}
			if(principal.lblDatoNivel.Text=="MANTENIMIENTO")
			{
				tabDescuentos.TabPages.Remove(tabUniforme);
				tabDescuentos.TabPages.Remove(tabLicencia);
			}
			if(principal.lblDatoNivel.Text=="COMBUSTIBLE")
			{
				tabDescuentos.TabPages.Add(tabAnticipos);
				tabDescuentos.TabPages.Remove(tabUniforme);
				tabDescuentos.TabPages.Remove(tabLicencia);
				rPrestamo.Checked = false;
				rFuneral.Enabled = false;
				rPrestamo.Enabled = false;
				rOtroPrestamo.Enabled = false;
				rInfracciones.Enabled = false;
				rTaller.Enabled = false;
				rTepadi.Enabled = false;
				rChoque.Enabled=false;
			}
		}
		#endregion
		
		#region CONTABILIZARDOR PAGOS
		public void ContabilizadorPagos(DataGridView data, DataGridView data2)
		{
			int contador = 0;
			int contador2 = 0;
			
			data2.Rows.Clear();
			data2.Rows.Add();
			data2.Rows[0].Cells[1].Value = data.Rows[0].Cells[4].Value.ToString();
						
			for(int x=0; x<data.Rows.Count; x++)
			{
				if(data2.Rows[0].Cells[1].Value.ToString()==data.Rows[x].Cells[4].Value.ToString())
				{
					contador = contador + 1;
					data2.Rows[0].Cells[0].Value = contador;
				}
			}
			
			if(data2.Rows[0].Cells[1].Value.ToString()!=data.Rows[data.Rows.Count-1].Cells[4].Value.ToString())
			{
				data2.Rows.Add();
				data2.Rows[1].Cells[1].Value = data.Rows[data.Rows.Count-1].Cells[4].Value.ToString();
				
					for(int x=0; x<data.Rows.Count; x++)
					{
						if(data2.Rows[1].Cells[1].Value.ToString()==data.Rows[x].Cells[4].Value.ToString())
						{
							contador2 = contador2 + 1;
							data2.Rows[1].Cells[0].Value = contador2;
						}
					}
			}
		}
		#endregion
		
		#region TRAER IMPUESTOS VALORES
		void TraerPrecios()
		{
			int contador = 0;
			
			dataValores.Rows.Clear();
			dataValores.ClearSelection();
			
			conn.getAbrirConexion("select ID, NOMBRE, SALDO from VALOR_IMPORTE where id!=7 and id!=8 and id!=9 and id!=10 and id!=11 and id!=12 and id!=13 and id!=14");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValores.Rows.Add();
					dataValores.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValores.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValores.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTO RADIO-CHECKED
		void CkLiquidarCheckedChanged(object sender, EventArgs e)
		{
			if(ckLiquidar.Checked == true)
			{
				DeudaRestante();
				ckRegreso.Checked = false;
			}
			else
			{
				dataLiquidacion.Rows.Clear();
				dataLiquidacion.ClearSelection();
			}
		}
		
		void CkRegresoCheckedChanged(object sender, EventArgs e)
		{
			if(ckRegreso.Checked == true)
			{
				dataLiquidacion.Rows.Clear();
				dataLiquidacion.ClearSelection();
				ckLiquidar.Checked = false;
			}
			else
			{
				
			}
		}
		
		void RadicionalCheckedChanged(object sender, EventArgs e)
		{
			   if(radicional.Checked==true)
			   {
			   		txtTramiteAdicional.Enabled=true;
			   		txtTramiteAdicional.Text = "";
			   		txtTramiteAdicional.Focus();
			   		txtImporteLicApto.Enabled=true;
			   		txtImporteLicApto.Text="0.00";
			   		txtNumPagos.Text="0.00";
			   		dataDetalleTramites.Rows.Clear();
			   }
			   else
			   {
			   		txtTramiteAdicional.Text="TRAMITE ADICIONAL";
			   		txtTramiteAdicional.Enabled=false;
			   		txtImporteLicApto.Enabled=false;
			   		dataDetalleTramites.Rows.Clear();
			   }
		}
		
		void RFederalCheckedChanged(object sender, EventArgs e)
		{
			if(rFederal.Checked==true)
			{
				txtImporteLicApto.Text = dataValores.Rows[0].Cells[2].Value.ToString();
				txtNumPagos.Text = dataValores.Rows[0].Cells[2].Value.ToString();
				AdaptadorPagos(dataPagosLicApto, txtImporteLicApto, txtNumPagos, "LIC");
			}
		}
		
		void RRefFederalCheckedChanged(object sender, EventArgs e)
		{
			if(rRefFederal.Checked==true)
			{
				txtImporteLicApto.Text = dataValores.Rows[1].Cells[2].Value.ToString();
				txtNumPagos.Text = dataValores.Rows[1].Cells[2].Value.ToString();
				AdaptadorPagos(dataPagosLicApto, txtImporteLicApto, txtNumPagos, "LIC");
			}
		}
		
		void RAptoCheckedChanged(object sender, EventArgs e)
		{
			if(rApto.Checked==true)
			{
				txtImporteLicApto.Text = dataValores.Rows[2].Cells[2].Value.ToString();
				txtNumPagos.Text = dataValores.Rows[2].Cells[2].Value.ToString();
				AdaptadorPagos(dataPagosLicApto, txtImporteLicApto, txtNumPagos, "LIC");
			}
		}
		
		void REstatalCheckedChanged(object sender, EventArgs e)
		{
			if(rEstatal.Checked==true)
			{
				txtImporteLicApto.Text = dataValores.Rows[6].Cells[2].Value.ToString();
				txtNumPagos.Text = dataValores.Rows[6].Cells[2].Value.ToString();
				AdaptadorPagos(dataPagosLicApto, txtImporteLicApto, txtNumPagos, "LIC");
			}
		}
		
		void ROtroPrestamoCheckedChanged(object sender, EventArgs e)
		{
			 if(rOtroPrestamo.Checked==true)
			   {
			   		txtOtroDescuento.Enabled=true;
			   		txtOtroDescuento.Text = "";
			   		txtOtroDescuento.Focus();
			   		txtImporteLicApto.Text="0.00";
			   		txtNumPagos.Text="0.00";
			   		dataDetallePrestamosOtros.Rows.Clear();
			   }
			   else
			   {
			   		txtOtroDescuento.Text="OTRO";
			   		txtOtroDescuento.Enabled=false;
			   		dataDetallePrestamosOtros.Rows.Clear();
			   }
		}
		
		void RTaxiCheckedChanged(object sender, EventArgs e)
		{
			if(rTaxi.Checked==true)
			{
				lblDescripcion.Text = "Empresa";
				txtDescripcion.AutoCompleteCustomSource = auto.AutocompleteEmpresa();
				txtDescripcion.AutoCompleteMode =AutoCompleteMode.Suggest;
				txtDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
				txtDescripcion.BackColor = Color.Pink;
				txtDescripcion.Text = "Favor de insertar la empresa";
			}
			else
			{
				lblDescripcion.Text = "Descripción";
				txtDescripcion.Text="";
				txtDescripcion.BackColor = Color.White;
				txtDescripcion.AutoCompleteCustomSource = null;
			}
		}
		
		void TxtDescripcionEnter(object sender, EventArgs e)
		{
			txtDescripcion.Text="";
		}
		
		void RChoqueCheckedChanged(object sender, EventArgs e)
		{
			if(rChoque.Checked==true)
			{
				txtDescripcion.BackColor = Color.Pink;
				txtDescripcion.Text = "Favor de insertar la descripción del accidente";
			}
			else
			{
				txtDescripcion.Text="";
				txtDescripcion.BackColor = Color.White;
			}
		}
		
		void RPrestamoCheckedChanged(object sender, EventArgs e)
		{
			if(rPrestamo.Checked==true)
			{
				txtDescripcion.BackColor = Color.Pink;
				txtDescripcion.Text = "Favor de insertar la descripción del préstamo";
			}
			else
			{
				txtDescripcion.Text="";
				txtDescripcion.BackColor = Color.White;
			}
		}
		
		void RTallerCheckedChanged(object sender, EventArgs e)
		{
			if(rTaller.Checked==true)
			{
				txtDescripcion.BackColor = Color.Pink;
				txtDescripcion.Text = "Favor de insertar la descripción del Descuento";
			}
			else
			{
				txtDescripcion.Text="";
				txtDescripcion.BackColor = Color.White;
			}
		}
		#endregion
		
		#region MODIFICAR FECHA
		void DataVistaCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==2)
			{
				ModificarFecha = new Interfaz.Nomina.Anticipos.FormModificarFechaAnticipo((Convert.ToInt64(dataDescuentoQuincenal.Rows[e.RowIndex].Cells[0].Value)), x, this);
				ModificarFecha.ShowDialog();
				ModificarFecha.BringToFront();
			}
		}
		#endregion
		
		#region SELECT INDEX CHANGED
		void TabDescuentosSelectedIndexChanged(object sender, EventArgs e)
		{
			if(tabDescuentos.SelectedTab==tabAnticipos)
			{
				NumeroPagosPrincipal();
			}
			if(tabDescuentos.SelectedTab==tabLicencia)
			{
				NumeroPagosTramites();
			}
			if(tabDescuentos.SelectedTab==tabUniforme)
			{
				SumaCostos();
			}
		}
		#endregion
		
		#region MENSAJE DE AYUDA
		void DataDescuentoQuincenalCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				MessageBox.Show(new Conexion_Servidor.Anticipos.SQL_Anticipos().TraerAyuda(dataPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString()), "El Descuento fue insertado en esta fecha",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
			}
		}
		
		void DataPrincipalCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				new Transportes_LAR.Interfaz.Nomina.Anticipos.FormHistorialTotalizado(dataPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
			}
		}
		#endregion
		
		#region IMAGEN DATAGRIDVIEW
		void DataPrincipalCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 3 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataPrincipal.Rows[e.RowIndex].Cells[3] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+20, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		
		void DataDescuentoQuincenalCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 6 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataDescuentoQuincenal.Rows[e.RowIndex].Cells[3] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\delante.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+50, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
			if (e.ColumnIndex == 7 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataDescuentoQuincenal.Rows[e.RowIndex].Cells[3] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\retroceso.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+40, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		#endregion
		
		#region SUELDO - PAGARE
		void SumaDeudaQuincenal()
		{
			if(txtAliasAnticipos.Text!="")
			{
				double SumaQuincenal = 0.0;
				for(int m=0; m<dataDescuentoQuincenal.Rows.Count; m++)
				{
					SumaQuincenal = SumaQuincenal + Convert.ToDouble(dataDescuentoQuincenal.Rows[m].Cells[5].Value);
				}
				lblDescuentoQuincenal.Text = SumaQuincenal.ToString("C");
				lblSueldoQuincenal.Text = fnomina.RetornoSueldo(x).ToString("C");
				lblRestante.Text = fnomina.RetornoPagare(x, dtInicio, dtCorte).ToString("C");
				lblinfonavit.Text = new Conexion_Servidor.Anticipos.SQL_Anticipos().Infonavit(dtOperador.Rows[x].Cells[0].Value.ToString());
				AUTORIZACION();
			}
		}
		
		void AUTORIZACION()
		{
			double deuda = 0.00;
			double IMSS = 0.0;
			double ISR = 0.0;
			double INFONAVIT = 0.0;
			double TELCEL = 0.0;
			double OTROS = 0.0;
			txtCantSugerida.Text = "0.00";
			if(txtAliasAnticipos.Text!="")
			{
				double SumaQuincenal = 0.0;
				for(int m=0; m<dataDescuentoQuincenal.Rows.Count; m++)
				{
					SumaQuincenal = SumaQuincenal + Convert.ToDouble(dataDescuentoQuincenal.Rows[m].Cells[5].Value);
				}
				if(tabAutorización!=null)
				{
					txtPagare.Text = fnomina.RetornoPagare(x, dtInicio, dtCorte).ToString();
					lblSueldoProm.Text = Math.Round(new Conexion_Servidor.Nomina.SQL_Nomina().PROEMDIO_SUELDO(dtOperador.Rows[x].Cells[0].Value.ToString()), 2).ToString();
					lblSueldoAprox.Text = (fnomina.RetornoSueldo(x)*2).ToString("C");
					txtDescuentoAcumulado.Text = (SumaQuincenal).ToString();
					deuda = (fnomina.RetornoPagare(x, dtInicio, dtCorte));
					TELCEL = Convert.ToDouble(new Conexion_Servidor.Anticipos.SQL_Anticipos().TELCEL(dtOperador.Rows[x].Cells[0].Value.ToString()));
					INFONAVIT = Convert.ToDouble(new Conexion_Servidor.Anticipos.SQL_Anticipos().Infonavit(dtOperador.Rows[x].Cells[0].Value.ToString()));
					IMSS = Convert.ToDouble(new Conexion_Servidor.Anticipos.SQL_Anticipos().IMSS(dtOperador.Rows[x].Cells[0].Value.ToString()));
					ISR = Convert.ToDouble(new Conexion_Servidor.Anticipos.SQL_Anticipos().ISR(dtOperador.Rows[x].Cells[0].Value.ToString()));
					if(new Conexion_Servidor.Anticipos.SQL_Anticipos().OTROS(dtOperador.Rows[x].Cells[0].Value.ToString())!="" && new Conexion_Servidor.Anticipos.SQL_Anticipos().OTROS(dtOperador.Rows[x].Cells[0].Value.ToString())!=null)
						OTROS = Convert.ToDouble(new Conexion_Servidor.Anticipos.SQL_Anticipos().OTROS(dtOperador.Rows[x].Cells[0].Value.ToString()));
					else
						OTROS = 0.0;
					txtImpuestos.Text = (TELCEL+INFONAVIT+ISR+IMSS+OTROS).ToString();
					
					if(deuda>100&&deuda<300)
						txtCantSugerida.Text = "100.00";
					else if(deuda>300.01&&deuda<1500)
						txtCantSugerida.Text = "300.00";
					else if(deuda>1500.01&&deuda<2500)
						txtCantSugerida.Text = "400.00";
					else if(deuda>2500.01&&deuda<4000)
						txtCantSugerida.Text = "500";
					else if(deuda>4000.01&&deuda<6000)
						txtCantSugerida.Text = "800";
					else if(deuda>6001.01)
						txtCantSugerida.Text = "1000";
					
					lblTotalCatorcenal.Text = (Convert.ToDouble(txtDescuentoAcumulado.Text)+Convert.ToDouble(txtCantSolicitada.Text)+Convert.ToDouble(txtImpuestos.Text)).ToString();
					
					if(rRegular.Checked==true)
					{
						//txtCantSolicitada.Enabled = false;
					}
				}
			}
		}
		#endregion
		
		#region ELIMINAR PAGO
		void DataDescuentoQuincenalCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			id_descuento = "";
			if(e.ColumnIndex==6)
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de ¡¡¡ADELANTAR!!! el pago este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					id_descuento = dataDescuentoQuincenal.Rows[e.RowIndex].Cells[1].Value.ToString();
					AdaptadorDegloseDescuento(x, "MAS");
					AdaptadorDescuentoQuincenal(x);
					AdaptadorDatosPrincipal(x);
					dataDesglose.Rows.Clear();
					dataDesglose.ClearSelection();
				}
			}
			if(e.ColumnIndex==7)
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de ¡¡¡RETRASAR!!! el pago este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					id_descuento = dataDescuentoQuincenal.Rows[e.RowIndex].Cells[1].Value.ToString();
					if(new Transportes_LAR.Conexion_Servidor.Anticipos.SQL_Anticipos().TraerRetrocesoDescuento(id_operador.ToString(), dtInicio.Value.AddDays(-14).ToShortDateString(), dtCorte.Value.AddDays(-14).ToShortDateString(), id_descuento)==false)
					{
						AdaptadorDegloseDescuento(x, "MENOS");
						AdaptadorDescuentoQuincenal(x);
						AdaptadorDatosPrincipal(x);
						dataDesglose.Rows.Clear();
						dataDesglose.ClearSelection();
					}
					else
					{
						MessageBox.Show("No es posible realizar esta operación ya hay un descuento igual en la quincena pasada", "Aviso Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
		}
		#endregion
		
		#region ADAPTADOR DESGLOSE
		void AdaptadorDegloseDescuento(int x, String MasMenos)
		{
			int contador = 0;
			int AumentoFechas = 0;
			
			if(MasMenos=="MAS")
			{
				AumentoFechas = 0;
			}
			else if(MasMenos=="MENOS")
			{
				AumentoFechas = -28;
			}
			
			dataDesglose.Rows.Clear();
			dataDesglose.ClearSelection();
			String sentencia = "select DT.ID, DT.ID_DESCUENTO, DT.FECHA, DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               "and O.Alias='"+dtOperador[1,x].Value+"' and DT.ID_DESCUENTO="+id_descuento+" order by DT.FECHA";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if((Convert.ToDateTime(conn.leer["FECHA"]))>dtInicio.Value.AddDays(2))
				{
					dataDesglose.Rows.Add();
					dataDesglose.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataDesglose.Rows[contador].Cells[1].Value = conn.leer["ID_DESCUENTO"].ToString();
					dataDesglose.Rows[contador].Cells[2].Value = conn.leer["FECHA"].ToString().Substring(0,10);
					dataDesglose.Rows[contador].Cells[3].Value = conn.leer["IMPORTE"].ToString();
					++contador;
				}
			}
			conn.conexion.Close();
			
			for(int s=0; s<dataDesglose.RowCount; s++)
				{
					AumentoFechas = AumentoFechas + 14;
					dataDesglose.Rows[s].Cells[2].Value = dtCorte.Value.AddDays(AumentoFechas).ToString("dd-MM-yyyy").Substring(0,10);
				}
			
			for(int s=0; s<dataDesglose.RowCount; s++)
					new Conexion_Servidor.Anticipos.SQL_Anticipos().UpdateFechaAnticipos(dataDesglose.Rows[s].Cells[2].Value.ToString(), dataDesglose.Rows[s].Cells[0].Value.ToString(), "");
			
			new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarCancelacionPago(dataDesglose.Rows[0].Cells[1].Value.ToString(), id_usuario);
		}
		#endregion
		
		void TxtCantSolicitadaTextChanged(object sender, EventArgs e)
		{
			if(txtCantSolicitada.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			if(txtCantSolicitada.Text!=""&&txtCantSolicitada.Text!=".")
			{
				if(Convert.ToDouble(txtCantSolicitada.Text)>0)
				{
					AUTORIZACION();
				}
				if(Convert.ToDouble(txtCantSolicitada.Text)>Convert.ToDouble(txtCantSugerida.Text))
				{
					rAutorizado.Checked = true;
				}
				else
				{
					rRegular.Checked = true;
				}
			}

		}
		
		void BtnGuardarPresClick(object sender, EventArgs e)
		{
			id_descuento = "0";
			if(Convert.ToDouble(txtCantSolicitada.Text)>0)
			{
				if(Convert.ToDouble(txtCantSolicitada.Text)>Convert.ToDouble(txtCantSugerida.Text))
				{
					TipoDesc = rAutorizado.Text;
					new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), "PRESTAMO", "A", Convert.ToDouble(txtCantSolicitada.Text), principal.idUsuario, txtObservaciones.Text);
					this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
					new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dtCorte.Value.ToShortDateString(), "PRE 1/1", (Convert.ToDouble(txtCantSolicitada.Text)));
					new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoEmpresa(this.id_descuento, txtEmpresa.Text, TipoDesc);
				}
				else
				{
					new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(dtOperador[0,x].Value)), "PRESTAMO", "A", Convert.ToDouble(txtCantSolicitada.Text), principal.idUsuario, txtObservaciones.Text);
					this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
					new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dtCorte.Value.ToShortDateString(), "PRE 1/1", (Convert.ToDouble(txtCantSolicitada.Text)));
					new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoEmpresa(this.id_descuento, txtEmpresa.Text, TipoDesc);
				}
			}
			else
				MessageBox.Show("El prestamo deba de ser mayor a 0 ... ", "Aviso",  MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			AdaptadorDescuentoQuincenal(x);
			AdaptadorDatosPrincipal(x);
		}
		
		void RRegularCheckedChanged(object sender, EventArgs e)
		{
			if(rRegular.Checked==true)
			{
				TipoDesc = rRegular.Text;
			}
			else
			{
				TipoDesc = rAutorizado.Text;
			}
		}
		
		void RAutorizadoCheckedChanged(object sender, EventArgs e)
		{
			if(rRegular.Checked==true)
			{
				TipoDesc = rRegular.Text;
			}
			else
			{
				TipoDesc = rAutorizado.Text;
			}
		}
		
		void BtnAutorizacionExcelClick(object sender, EventArgs e)
		{
			Excels.ReporteDescEmpresas(principal, dtInicio.Value.ToShortDateString(), dtCorte.Value.ToShortDateString());
		}
		
		void RTepadiCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void RCasetasCheckedChanged(object sender, EventArgs e)
		{
			if(rCasetas.Checked==true)
			{
				txtID_RE.Enabled=true;
				txtID_RE.Text = "";
				txtID_RE.Focus();
				txtImporteLicApto.Text="0.00";
				txtNumPagos.Text="0.00";
				dataDetallePrestamosOtros.Rows.Clear();
			}
			else
			{
				txtID_RE.Text="ID_RE";
				txtID_RE.Enabled=false;
				dataDetallePrestamosOtros.Rows.Clear();
			}
		}
	}
}
