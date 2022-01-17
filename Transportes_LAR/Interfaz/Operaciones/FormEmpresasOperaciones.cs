using System;
using System.CodeDom;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using Transportes_LAR.Interfaz.Operaciones.Dato;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormEmpresasOperaciones : Form
	{
		#region VARIABLES E INSTANCIAS
		public int extendida=0;
		
		// ****** Mensajes comentarios
		public FormMensaje formMsj = null;
		public FormGloboMsj msjGlobo = new FormGloboMsj();
		public int msj=0;
		public List<Interfaz.Operaciones.Dato.msjRuta> listMsjRuta = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		// ******
		
		
		int primera=0;
		
		public int idMsj=-1;
		
		// **************
		public bool panelSec=false;
		// **************
		public List<Interfaz.Operaciones.Dato.Ruta> listRutaEntrada=null;
		public List<Interfaz.Operaciones.Dato.Ruta> listRutaSalida=null;
		
		public List<Interfaz.Operaciones.Dato.Ruta> listRutaEntrada2=null;
		public List<Interfaz.Operaciones.Dato.Ruta> listRutaSalida2=null;
		
		public String nomEmpresa;
		
		public Interfaz.Operaciones.FormPrin_Empresas refPrincipal;
		private Interfaz.Operaciones.FormAddDelRutas formAdDeRuta;
		
		
		public int ancho;
		public int pMOV;
		public int cantRutas=0;
		public int hora=0;
		public int rutaSelected=-1;
		public int rutaSelectedColumn=-1;
		public int rutaEspecial=-1;
		
		public int indic=0;
		public int indic2=0;
		
		public int id_Empresa=-1;
		
		public List<Interfaz.Operaciones.Dato.Apoyo> ApoyoRutaOp;
		
		// -- DIA DE DESPACHO -- //
		public String DIA_DESPACHO="";
		
		public String miTurno=""; 
		
		#endregion
		
		public FormEmpresasOperaciones(Interfaz.Operaciones.FormPrin_Empresas refer, String DIA_DESP)
		{
			this.refPrincipal=refer;
			InitializeComponent();
			DIA_DESPACHO=DIA_DESP;
		}
		
		#region ACOMODO RUTAS DATAGRID
		public void getDatosEmpresas(String turno)
		{
			miTurno=turno;
			String diaExtra = DIA_DESPACHO.Substring(0,2);
			String mesExtra = DIA_DESPACHO.Substring(3,2);
			String anioExtra = DIA_DESPACHO.Substring(6,4);
			
			String miFecha = anioExtra+"-"+mesExtra+"-"+diaExtra;
			
			listRutaEntrada = new Conexion_Servidor.Desapacho.SQL_Operaciones().getListRutaEnt(turno, lblNombreEmp.Text, refPrincipal.fecha_Base_Datos);
			listRutaSalida = new Conexion_Servidor.Desapacho.SQL_Operaciones().getListRutaSal(turno, lblNombreEmp.Text, refPrincipal.fecha_Base_Datos);
			try
			{
				if(listRutaEntrada!=null)
				{
					for(int x=0; x<listRutaEntrada.Count; x++)
					{
						if(validandoDia(listRutaEntrada[x].dia, ((miTurno=="Nocturno")?1:0)) || listRutaEntrada[x].extra.Equals(miFecha))// || listRutaEntrada[x].empresa.Equals("Especiales"))
						{
							if( nomEmpresa!="ESPECIALES")
							{
								dtgEmpresas.Rows.Add("0", listRutaEntrada[x].empresa, listRutaEntrada[x].id_ruta, "Operador", listRutaEntrada[x].hora, "00:00", listRutaEntrada[x].nombre, "00:00", false, " ", " ", " ", " ", " ", " ", " ", false, " ", "", " ", " ", " ", "", " ", " ", " ", " ", listRutaEntrada[x].DATO.ToUpper());
								cantRutas++;
							}
							else if(nomEmpresa=="ESPECIALES")
							{
								dtgEmpresas.Rows.Add("0", listRutaEntrada[x].ID_C, listRutaEntrada[x].id_ruta, "Operador", listRutaEntrada[x].hora, "00:00", listRutaEntrada[x].nombre, "00:00", false, " ", " ", " ", " ", " ", " ", " ", false, " ", "", " ", " ", " ", "", " ", " ", " ", " ", listRutaEntrada[x].DATO.ToUpper());
								cantRutas++;
							}
						}
					}
				}
				
				if(listRutaSalida!=null)
				{
					for(int x=0; x<listRutaSalida.Count ;x++)
					{
						if(validandoDia(listRutaSalida[x].dia,((miTurno=="Nocturno")?1:0)) || listRutaSalida[x].extra.Equals(miFecha))// || listRutaEntrada[x].empresa.Equals("Especiales"))
						{
								int N=0;
								for(int y=0; y<(dtgEmpresas.RowCount-1) ;y++)
								{
									if(nomEmpresa!="ESPECIALES" && listRutaSalida[x].nombre.ToString().Equals(dtgEmpresas[6,y].Value.ToString()) && listRutaSalida[x].empresa.ToString().Equals(dtgEmpresas[1,y].Value.ToString()) && dtgEmpresas[13,y].Value.ToString()==" ")
									{
										dtgEmpresas.Rows[y].Cells[9].Value="0";
										dtgEmpresas.Rows[y].Cells[10].Value=listRutaSalida[x].id_ruta;
										dtgEmpresas.Rows[y].Cells[11].Value="Operador";
										dtgEmpresas.Rows[y].Cells[12].Value=listRutaSalida[x].hora;
										dtgEmpresas.Rows[y].Cells[13].Value="00:00";
										dtgEmpresas.Rows[y].Cells[14].Value=listRutaSalida[x].nombre;
										dtgEmpresas.Rows[y].Cells[15].Value="00:00";
										dtgEmpresas.Rows[y].Cells[16].Value=false;
										dtgEmpresas.Rows[y].Cells[17].Value=" ";
										dtgEmpresas.Rows[y].Cells[18].Value="";
										dtgEmpresas.Rows[y].Cells[19].Value=" ";
										dtgEmpresas.Rows[y].Cells[20].Value=" ";
										dtgEmpresas.Rows[y].Cells[21].Value=" ";
										dtgEmpresas.Rows[y].Cells[22].Value="";
										dtgEmpresas.Rows[y].Cells[23].Value=" ";
										dtgEmpresas.Rows[y].Cells[24].Value=" ";
										dtgEmpresas.Rows[y].Cells[25].Value=" ";
										dtgEmpresas.Rows[y].Cells[26].Value=" ";
										dtgEmpresas.Rows[y].Cells[27].Value=listRutaSalida[x].DATO.ToUpper();
										N=1;
										break;
									}
									else if(nomEmpresa=="ESPECIALES" && listRutaSalida[x].nombre.ToString().Equals(dtgEmpresas[6,y].Value.ToString()) && listRutaSalida[x].ID_C.ToString().Equals(dtgEmpresas[1,y].Value.ToString()) && dtgEmpresas[13,y].Value.ToString()==" ")
									{
										dtgEmpresas.Rows[y].Cells[9].Value="0";
										dtgEmpresas.Rows[y].Cells[10].Value=listRutaSalida[x].id_ruta;
										dtgEmpresas.Rows[y].Cells[11].Value="Operador";
										dtgEmpresas.Rows[y].Cells[12].Value=listRutaSalida[x].hora;
										dtgEmpresas.Rows[y].Cells[13].Value="00:00";
										dtgEmpresas.Rows[y].Cells[14].Value=listRutaSalida[x].nombre;
										dtgEmpresas.Rows[y].Cells[15].Value="00:00";
										dtgEmpresas.Rows[y].Cells[16].Value=false;
										dtgEmpresas.Rows[y].Cells[17].Value=" ";
										dtgEmpresas.Rows[y].Cells[18].Value="";
										dtgEmpresas.Rows[y].Cells[19].Value=" ";
										dtgEmpresas.Rows[y].Cells[20].Value=" ";
										dtgEmpresas.Rows[y].Cells[21].Value=" ";
										dtgEmpresas.Rows[y].Cells[22].Value="";
										dtgEmpresas.Rows[y].Cells[23].Value=" ";
										dtgEmpresas.Rows[y].Cells[24].Value=" ";
										dtgEmpresas.Rows[y].Cells[25].Value=" ";
										dtgEmpresas.Rows[y].Cells[26].Value=" ";
										dtgEmpresas.Rows[y].Cells[27].Value=listRutaSalida[x].DATO.ToUpper();
										N=1;
										break;
									}
								}
								if(N==0) 
								{
									if(nomEmpresa!="ESPECIALES")
									{
										dtgEmpresas.Rows.Add("0",listRutaSalida[x].empresa, " ", " ", " ", " ", " ", " ", false, "0",listRutaSalida[x].id_ruta, "Operador", listRutaSalida[x].hora,"00:00",listRutaSalida[x].nombre,"00:00", false, " ", "", " ", " ", " ", "", " ", " ", " ", " ", listRutaSalida[x].DATO.ToUpper());
										cantRutas++;
									}
									else if(nomEmpresa=="ESPECIALES")
									{
										dtgEmpresas.Rows.Add("0",listRutaSalida[x].ID_C, " ", " ", " ", " ", " ", " ", false, "0",listRutaSalida[x].id_ruta, "Operador", listRutaSalida[x].hora,"00:00",listRutaSalida[x].nombre,"00:00", false, " ", "", " ", " ", " ", "", " ", " ", " ", " ", listRutaSalida[x].DATO.ToUpper());
										cantRutas++;
									}
								}
						}
					}
				}
				
				checarEspeciales();
				getGuardia();
				mensajes();
			}
			catch(Exception)
			{
				//MessageBox.Show("ERROR 003");
			}
		}
		
		public void mensajes()
		{
			String anio = refPrincipal.fecha_despacho.Substring(6,4);
			String mes = refPrincipal.fecha_despacho.Substring(3,2);
			String dia = refPrincipal.fecha_despacho.Substring(0,2);
			
			
			String fech = anio+"/"+mes+"/"+dia;
			listMsjRuta = new Conexion_Servidor.Desapacho.SQL_Operaciones().getMsjRuta(fech,refPrincipal.ConsTurno);
			
			
			if(listMsjRuta!=null)
			{
				for(int y=0; y<dtgEmpresas.Rows.Count-1; y++)
				{
					for(int x=0; x<listMsjRuta.Count; x++)
					{
						if(dtgEmpresas[2,y].Value.ToString()==listMsjRuta[x].ID_RUTA.ToString() || dtgEmpresas[10,y].Value.ToString()==listMsjRuta[x].ID_RUTA.ToString())
						{
							dtgEmpresas[26, y].Value=listMsjRuta[x].MENSAJE;
							dtgEmpresas[26, y].Style.BackColor=Color.Red;
						}
					}
				}
			}
		}
		
		public void checarEspeciales()
		{
			List<String> RutasAsignadas = null;
			if(lblNombreEmp.Text!="ESPECIALES")
			{
				RutasAsignadas = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdEspAsig(miTurno, DIA_DESPACHO);
			}
			else if(lblNombreEmp.Text=="ESPECIALES")
			{
				List<String> RutasAsignadas2 = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdEspAsigEsp(DIA_DESPACHO);
				RutasAsignadas=RutasAsignadas2;
			}
			
			if(RutasAsignadas.Count>0)
			{
				for(int y=0; y<dtgEmpresas.Rows.Count; y++)
				{
					for(int x=0; x<RutasAsignadas.Count; x++)
					{
						if(Convert.ToString(dtgEmpresas[2,y].Value)==RutasAsignadas[x])
						{
							Interfaz.Operaciones.Dato.Busqueda DATOS = new Conexion_Servidor.Desapacho.SQL_Operaciones().getOperador(dtgEmpresas[2,y].Value.ToString(), miTurno, DIA_DESPACHO, lblNombreEmp.Text);
							dtgEmpresas[0,y].Value=DATOS.Cantidad;
							dtgEmpresas[3,y].Value=DATOS.nomOperador;
							dtgEmpresas[5,y].Value=DATOS.confirmada.Substring(0,5);
							dtgEmpresas[7,y].Value=DATOS.llegada.Substring(0,5);
							dtgEmpresas[8,y].Value=true;
							dtgEmpresas[17,y].Value=DATOS.id_operacion;
							dtgEmpresas[18,y].Value=DATOS.id_operador;
							dtgEmpresas[19,y].Value=DATOS.id_vehiculo;
							dtgEmpresas[20,y].Value=DATOS.vehiculo;
							
							if(refPrincipal.carga==false && panelSec==false)
								refPrincipal.principal.contandoViajes(1,DATOS.nomOperador,lblNombreEmp.Text, "A");
							
							for(int z=0; z<9; z++)
							{
								dtgEmpresas[z,y].Style.BackColor=Color.MediumSpringGreen;
							}
						}
						if(Convert.ToString(dtgEmpresas[10,y].Value)==RutasAsignadas[x])
						{
							Interfaz.Operaciones.Dato.Busqueda DATOS = new Conexion_Servidor.Desapacho.SQL_Operaciones().getOperador(dtgEmpresas[10,y].Value.ToString(), miTurno, DIA_DESPACHO, lblNombreEmp.Text);
							dtgEmpresas[9,y].Value=DATOS.Cantidad;
							dtgEmpresas[11,y].Value=DATOS.nomOperador;
							dtgEmpresas[13,y].Value=DATOS.confirmada.Substring(0,5);
							dtgEmpresas[15,y].Value=DATOS.llegada.Substring(0,5);
							dtgEmpresas[16,y].Value=true;
							dtgEmpresas[21,y].Value=DATOS.id_operacion;
							dtgEmpresas[22,y].Value=DATOS.id_operador;
							dtgEmpresas[23,y].Value=DATOS.id_vehiculo;
							dtgEmpresas[24,y].Value=DATOS.vehiculo;
							
							if(refPrincipal.carga==false && panelSec==false)
							 	refPrincipal.principal.contandoViajes(1,DATOS.nomOperador, lblNombreEmp.Text, "A");
							
							
							for(int z=9; z<17; z++)
							{
								dtgEmpresas[z,y].Style.BackColor=Color.MediumSpringGreen;
							}
						}
					}
				}
			}
		}
		
		public bool validandoDia(String DIA, int cambio)
		{
			bool respuesta=false;
			int D=0;
			DateTime diahora = DateTime.Now;
			
			String diaExtra = DIA_DESPACHO.Substring(0,2);
			String mesExtra = DIA_DESPACHO.Substring(3,2);
			String anioExtra = DIA_DESPACHO.Substring(6,4);
			
			DateTime dateValue = new DateTime(Convert.ToInt16(anioExtra), Convert.ToInt16(mesExtra), Convert.ToInt16(diaExtra));
			
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="lunes")
				D=1;
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="martes")
				D=2;
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="miércoles")
				D=3;
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="jueves")
				D=4;
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="viernes")
				D=5;
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="sábado")
				D=6;
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="domingo")
				D=7;
			
			try
			{
				if(DIA.Substring(D,1)=="1")
				{
					respuesta=true;
				}
			}
			catch(Exception)
			{
				return true;
			}
				
			return respuesta;
		}
		
		public void getGuardia()
		{
			String turnoB="Mañana";
			String fechaB=refPrincipal.fecha_Base_Datos;
			String Respuesta="";
			
			if(miTurno=="Mañana")
			{
				int fecha_actual = Convert.ToInt16(refPrincipal.fecha_Base_Datos.Substring(8,2));
				if(fecha_actual==1)
				{
					Respuesta=fechaB;
				}
				else
				{
					fecha_actual=fecha_actual-1;
					Respuesta=fechaB.Substring(0,7)+"-"+((fecha_actual<10)?"0"+Convert.ToString(fecha_actual):fecha_actual.ToString());
				}
				turnoB="Nocturno";
				fechaB=Respuesta;
			}
			else if(miTurno=="Medio Día")
				turnoB="Mañana";
			else if(miTurno=="Vespertino")
				turnoB="Medio Día";
			else if(miTurno=="Nocturno")
				turnoB="Vespertino";
				
			if(panelSec==true)
			{
				List<String> datos = new Conexion_Servidor.Desapacho.SQL_Operaciones().getGuardia("select G.ID ID_G, O.Alias, O.ID ID_O from OPERADOR O, GUARDIA G where O.ID=G.ID_OPERADOR and DIA='"+fechaB+"' and TURNO='"+turnoB+"' and ID_SUBEMPRESA='"+id_Empresa+"'");
				if(datos.Count>0)
				{
					MessageBox.Show(datos[1]);
					lblGuardia.Visible=true;
					lblG.Visible=true;
					lblGuardia.Text=datos[1];
					lblIDG.Text=datos[0];
					lblIDO.Text=datos[2];
					cmdGuardia.Enabled=false;
				}
			}
			else
			{
				List<String> datos = new Conexion_Servidor.Desapacho.SQL_Operaciones().getGuardia("select G.ID ID_G, O.Alias, O.ID ID_O from OPERADOR O, GUARDIA G where O.ID=G.ID_OPERADOR and DIA='"+refPrincipal.fecha_Base_Datos+"' and TURNO='"+miTurno+"' and ID_SUBEMPRESA='"+id_Empresa+"'");
				if(datos.Count>0)
				{
					lblGuardia.Visible=true;
					lblG.Visible=true;
					lblGuardia.Text=datos[1];
					lblIDG.Text=datos[0];
					lblIDO.Text=datos[2];
					cmdGuardia.Enabled=false;
				}
			}
		}
		#endregion
		
		#region EVENTO LOAD
		public void FormEmpresasOperacionesLoad(object sender, EventArgs e)
		{
			getMensajes();
			
            this.Text=nomEmpresa;
            ancho=dtgEmpresas.Size.Height;
			
            if(panelSec==false)
            	refPrincipal.mueve(this,pMOV);
            else if(panelSec==true)
            	refPrincipal.secRef(this);
			
            dtgEmpresas.AllowUserToAddRows = false;
			
			dtgEmpresas.ClearSelection();
			panel1.SendToBack();
			
			if(panelSec==true)
			{
				button2.Enabled=false;
			}
			
			dtgEmpresas.EndEdit();
			
			lblNombreEmp.SendToBack();
			
			if(lblNombreEmp.Text=="ESPECIALES")
			{
				cmdInformacion.Visible=true;
				lblSepara1.Visible=true;
				cmdAgregar.Enabled=false;
				forDatosEsp = new FormPrincEspeciales(this);
				panel1.AutoScroll = true;
			}
		}
		#endregion
		
		public void getIdEmpresa()
		{
			id_Empresa= new Conexion_Servidor.Desapacho.SQL_Operaciones().getIDEmpresa(nomEmpresa);
		}
		
		#region EVENTO BOTONES
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show(refPrincipal.principal.Size.ToString());
		}
		
		public bool datosEspeciales = false;
		public FormPrincEspeciales forDatosEsp = null;
		
		void CmdInformacionClick(object sender, EventArgs e)
		{
			if(datosEspeciales == false)
			{
				forDatosEsp.Visible = true;
				datosEspeciales = true;
			}
			else
			{
				MessageBox.Show("La interfaz ya esta abierta.");
			}
		}
		#endregion
		
		#region ASIGNACION OPERADOR-RUTA Y "GUARDADO EN BD"
		void DtgEmpresasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			bandera=0;
			filaSelect=e.RowIndex;
			if(e.ColumnIndex==3 || e.ColumnIndex==11)
				primera=0;
			
			desSeleccion();
			try
			{
				if(e.RowIndex!=-1 && e.RowIndex<dtgEmpresas.Rows.Count)
				{
					refPrincipal.limpiarSelect(this);
					rutaSelected=e.RowIndex;
					rutaSelectedColumn=e.ColumnIndex;
					if(refPrincipal.principal.AliasOperador!="")
					{
						if(e.ColumnIndex<8 && e.ColumnIndex>-1)
						{
							if(dtgEmpresas[6,e.RowIndex].Value.ToString()!=" ")
							{
								try
								{
									if(dtgEmpresas[8,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
									{
										cambio(1,dtgEmpresas[3,e.RowIndex].Value.ToString(),e.RowIndex,refPrincipal.principal.AliasOperador);
									}
									else
									{
										if(dtgEmpresas[3,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen") && e.ColumnIndex==8)
										{
											
										}
										else 
										{
											planeacion(1, e);
										}
									}
								}
								catch(Exception)
								{
									MessageBox.Show("Error en la asiganacion 002");
								}
							}
						}
						else 
						{
							if(dtgEmpresas[13,e.RowIndex].Value.ToString()!=" " && e.ColumnIndex>-1)
							{
								try
								{
									if(dtgEmpresas[16,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
									{
										cambio(2,dtgEmpresas[10,e.RowIndex].Value.ToString(),e.RowIndex,refPrincipal.principal.AliasOperador);
									}
									else
									{
										if(dtgEmpresas[11,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen") && e.ColumnIndex==16)
										{
											
										}
										else
										{
											planeacion(2, e);
										}
									}
								}
								catch(Exception)
								{
									MessageBox.Show("Error en la asiganacion 002");
								}
							}
							else if(e.ColumnIndex==-1)
							{
								if(dtgEmpresas[6,e.RowIndex].Value.ToString()!=" " && dtgEmpresas[8,e.RowIndex].Style.BackColor.Name.ToString()!="MediumSpringGreen")
								{
									if(dtgEmpresas[18,e.RowIndex].Value.ToString()!="")
									{
										refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[18,e.RowIndex].Value),lblNombreEmp.Text, "C");
									}
									
									dtgEmpresas[3,e.RowIndex].Value=refPrincipal.principal.AliasOperador.ToString();
									dtgEmpresas[18,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
									dtgEmpresas[19,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
									dtgEmpresas[20,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
									
									dtgEmpresas[3,e.RowIndex].Style.BackColor=Color.MediumSpringGreen;
									
									if(panelSec!=true)
									{
										refPrincipal.principal.contandoViajes(1,dtgEmpresas[3,e.RowIndex].Value.ToString(), lblNombreEmp.Text, "B");
									}
								}
								
								if(dtgEmpresas[14,e.RowIndex].Value.ToString()!=" " && dtgEmpresas[16,e.RowIndex].Style.BackColor.Name.ToString()!="MediumSpringGreen")
								{
									if(dtgEmpresas[3,e.RowIndex].Value.ToString()==dtgEmpresas[11,e.RowIndex].Value.ToString())
									{
										planeacion(2, e);
									}
								}
								dtgEmpresas.ClearSelection();
							}
						}
					}
					else if(e.ColumnIndex==-1)
					{
						if(dtgEmpresas.CurrentRow.Cells[6].Value.ToString()!="" && dtgEmpresas.CurrentRow.Cells[3].Value.ToString()!="" && dtgEmpresas[3,e.RowIndex].Style.BackColor.Name.ToString()!="MediumSpringGreen")
						{
							refPrincipal.principal.datosOpAsi=null;
							
							if(panelSec!=true)
								refPrincipal.principal.contandoViajes(1,dtgEmpresas.CurrentRow.Cells[3].Value.ToString(),lblNombreEmp.Text, "C");
							
							if(refPrincipal.principal.datosOpAsi!=null)
							{
								dtgEmpresas.CurrentRow.Cells[18].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
								dtgEmpresas.CurrentRow.Cells[19].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
								dtgEmpresas.CurrentRow.Cells[20].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
								dtgEmpresas.CurrentRow.Cells[3].Style.BackColor=Color.MediumSpringGreen;
							}
						}
							
						if(dtgEmpresas.CurrentRow.Cells[14].Value.ToString()!="" && dtgEmpresas.CurrentRow.Cells[11].Value.ToString()!="" && dtgEmpresas[11,e.RowIndex].Style.BackColor.Name.ToString()!="MediumSpringGreen")
						{
							if(dtgEmpresas[3,e.RowIndex].Value.ToString()==dtgEmpresas[11,e.RowIndex].Value.ToString())
							{
								refPrincipal.principal.datosOpAsi=null;
								
								if(panelSec!=true)
									refPrincipal.principal.contandoViajes(1,dtgEmpresas.CurrentRow.Cells[11].Value.ToString(), lblNombreEmp.Text, "C");
								
								if(refPrincipal.principal.datosOpAsi!=null)
								{
									dtgEmpresas.CurrentRow.Cells[22].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
									dtgEmpresas.CurrentRow.Cells[23].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
									dtgEmpresas.CurrentRow.Cells[24].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
									
									dtgEmpresas.CurrentRow.Cells[11].Style.BackColor=Color.MediumSpringGreen;
								}
							}
						}
						
						dtgEmpresas.ClearSelection();
					}
				}
			}
			catch(Exception)
			{
				MessageBox.Show("Error en la asiganacion 001");
				desSeleccion();
			}
		}
		
		public void planeacion(int tipo, DataGridViewCellEventArgs e)
		{
			if(tipo==1)
			{
				if(dtgEmpresas[3,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
				{
					refPrincipal.principal.contandoViajes(-1,dtgEmpresas[3,e.RowIndex].Value.ToString(), lblNombreEmp.Text, "B");
				}
				else if(dtgEmpresas[18,e.RowIndex].Value.ToString()!="")
				{
					refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[18,e.RowIndex].Value),lblNombreEmp.Text, "C");
				}
				
				dtgEmpresas[3,e.RowIndex].Value=refPrincipal.principal.AliasOperador.ToString();
				dtgEmpresas[18,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
				dtgEmpresas[19,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
				dtgEmpresas[20,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
				
				dtgEmpresas[3,e.RowIndex].Style.BackColor=Color.MediumSpringGreen;
				
				if(panelSec!=true)
				{
					refPrincipal.principal.contandoViajes(1,dtgEmpresas[3,e.RowIndex].Value.ToString(), lblNombreEmp.Text, "A");
				}
			}
			else if(tipo==2)
			{
				if(dtgEmpresas[11,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
				{
					refPrincipal.principal.contandoViajes(-1,dtgEmpresas[11,e.RowIndex].Value.ToString(), lblNombreEmp.Text, "B");
				}
				else if(dtgEmpresas[22,e.RowIndex].Value.ToString()!="")
				{
					refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[22,e.RowIndex].Value),lblNombreEmp.Text, "C");
				}
				
				dtgEmpresas[11,e.RowIndex].Value=refPrincipal.principal.AliasOperador.ToString();
				dtgEmpresas[22,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
				dtgEmpresas[23,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
				dtgEmpresas[24,e.RowIndex].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
				
				dtgEmpresas[11,e.RowIndex].Style.BackColor=Color.MediumSpringGreen;
				
				if(panelSec!=true)
				{
					refPrincipal.principal.contandoViajes(1,dtgEmpresas[11,e.RowIndex].Value.ToString(), lblNombreEmp.Text, "A");
				}
			}
		}
		
		public void cambio(int sentido,String aliasAnt,int fila,String aliasSig)
		{
			Interfaz.Operaciones.FormSuplente Pregunta = new Interfaz.Operaciones.FormSuplente(this,sentido,aliasAnt,fila,aliasSig);
			Pregunta.ShowDialog();
		}
		
		// *************************************Guardado BD Viajes*************************************
		public bool guardaViaje(String idRuta, String confirmada, String llegada, int tipo, Int64 idOperacion, Int64 idOperador, Int64 idVehiculo, String vehiculo, int pasajeros, String conf2)
		{
			bool respuesta=true;
			
			//MessageBox.Show(refPrincipal.principal.idUsuario+"**"+idRuta+"*"+confirmada+"*"+llegada+"*"+tipo+"*"+idOperacion+"*"+idOperador+"*"+idVehiculo+"*"+vehiculo);
			if(new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarViaje(idOperacion,idRuta,refPrincipal.principal.idUsuario,idOperador,confirmada,llegada,tipo,idVehiculo,vehiculo, miTurno,pasajeros,conf2,DIA_DESPACHO, nomEmpresa))
			{
				respuesta=true;
			}
			else
			{
				respuesta=false;
			}
			//MessageBox.Show("ID RUTA:"+idRuta+" ID OPERADOR:"+idOperador+" ID OPERACION:"+idOperacion);
			if(lblIDO.Text==idOperador.ToString())
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().viajeGuardia(Convert.ToInt16(lblIDG.Text));
			}
			
			return respuesta;
		}
		
		public void camnioOperador(int idOperadorCambio, int idVehiculo, String vehiculo, int idOperadorAnterior, int idViaje)
		{
			new Conexion_Servidor.Desapacho.SQL_Operaciones().cambioOperadorViaje(idOperadorCambio, idVehiculo, vehiculo, idOperadorAnterior, idViaje);
		}
		
		public void asignacionIdOperacion(int fila, int sentido)
		{
			Int64 IDOPERACION = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOperacionMax();
			if(sentido==2)
			{
				dtgEmpresas[21,fila].Value=IDOPERACION;
			}
			else
			{
				dtgEmpresas[17,fila].Value=IDOPERACION;
			}
		}
		//*********************************************************************************************
		
		public void desSeleccion()
		{
			for(int x=0; x<refPrincipal.refMOV.Count; x++)
			{
				for(int y=0; y<refPrincipal.refMOV[x].dtgEmpresas.Rows.Count; y++)
				{
					if(refPrincipal.refMOV[x].dtgEmpresas[0,y].Style.BackColor.Name=="DodgerBlue" || refPrincipal.refMOV[x].dtgEmpresas[9,y].Style.BackColor.Name=="DodgerBlue")
					{
						if(refPrincipal.refMOV[x].dtgEmpresas[0,y].Style.BackColor.Name=="DodgerBlue")
						{
							for(int z=0; z<8; z++)
							{
								refPrincipal.refMOV[x].dtgEmpresas[z,y].Style.BackColor=Color.White;
								if(z==0 || z==9)
								{
									refPrincipal.refMOV[x].dtgEmpresas[z,y].Style.BackColor=Color.Red;
								}
								if(dtgEmpresas.Rows[y].Cells[18].Value.ToString()!="" && dtgEmpresas.Rows[y].Cells[18].Value.ToString()!="")
								{
									refPrincipal.refMOV[x].dtgEmpresas[3,y].Style.BackColor=Color.MediumSpringGreen;
								}
							}
						}
						else if(refPrincipal.refMOV[x].dtgEmpresas[9,y].Style.BackColor.Name=="DodgerBlue")
						{
							for(int z=9; z<16; z++)
							{
								refPrincipal.refMOV[x].dtgEmpresas[z,y].Style.BackColor=Color.White;
								if(z==0 || z==9)
								{
									refPrincipal.refMOV[x].dtgEmpresas[z,y].Style.BackColor=Color.Red;
								}
								if(dtgEmpresas.Rows[y].Cells[22].Value.ToString()!="" && dtgEmpresas.Rows[y].Cells[18].Value.ToString()!="")
								{
									refPrincipal.refMOV[x].dtgEmpresas[11,y].Style.BackColor=Color.MediumSpringGreen;
								}
							}
						}
					}
				}
			}
			
			refPrincipal.principal.RutaDatagris=-1;
			refPrincipal.principal.Empresa="";
			refPrincipal.principal.sent=0;
		}
		
		
		public void Revisando(int sentido,String aliasAnt,int fila, String aliasSig, String cambio)
		{
			int parar=0;
			int revisado=1;
			if(sentido==1)
			{
				for(int x=0; x<refPrincipal.refMOV.Count; x++)
				{
					for(int y=0; y<refPrincipal.refMOV[x].dtgEmpresas.Rows.Count; y++)
					{
						if(refPrincipal.refMOV[x].dtgEmpresas[3,y].Value.Equals(aliasAnt))
						{
							if(panelSec!=true)
								refPrincipal.principal.contandoViajes(-1,aliasAnt, lblNombreEmp.Text, "A");
							
							if(cambio=="cambiar")
							{
								camnioOperador(refPrincipal.principal.datosOpAsi.ID_OPERADOR,
									            refPrincipal.principal.datosOpAsi.ID_VEHICULO,
									            refPrincipal.principal.datosOpAsi.tipoVehiculo,
									            Convert.ToInt16(dtgEmpresas[18,fila].Value),
									            Convert.ToInt16(dtgEmpresas[17,fila].Value));
							}
							
							dtgEmpresas[3,fila].Value=aliasSig;
							revisado=Convert.ToInt16(dtgEmpresas[18,fila].Value);
							dtgEmpresas[18,fila].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR;
							dtgEmpresas[19,fila].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO;
							dtgEmpresas[20,fila].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo;
							dtgEmpresas[5,fila].Value=System.DateTime.Now.ToString("HH:mm");
							for(int z=0; z<9; z++)
							{
								dtgEmpresas[z,fila].Style.BackColor=Color.MediumSpringGreen;
							}
							
							
							if(cambio=="suplir")
							{
								if(revisado!=Convert.ToInt16(dtgEmpresas[18,fila].Value))
								{
									DialogResult result=MessageBox.Show("¿El operador se encontraba en ruta?","Supliendo Ruta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
									if(DialogResult.OK==result)
									{
										guardaViaje(dtgEmpresas[2,fila].Value.ToString(),
										            dtgEmpresas[5,fila].Value.ToString(),
										            dtgEmpresas[7,fila].Value.ToString(),
										            20,Convert.ToInt16(dtgEmpresas[17,fila].Value),
										            Convert.ToInt16(dtgEmpresas[18,fila].Value),
										            Convert.ToInt16(dtgEmpresas[19,fila].Value),
										            dtgEmpresas[20,fila].Value.ToString(),
										            Convert.ToInt16(dtgEmpresas[0,fila].Value),
										           	Convert.ToString(dtgEmpresas[26,fila].Value));
									}
									else
									{
										guardaViaje(dtgEmpresas[2,fila].Value.ToString(),
										            dtgEmpresas[5,fila].Value.ToString(),
										            dtgEmpresas[7,fila].Value.ToString(),
										            21,Convert.ToInt16(dtgEmpresas[17,fila].Value),
										            Convert.ToInt16(dtgEmpresas[18,fila].Value),
										            Convert.ToInt16(dtgEmpresas[19,fila].Value),
										            dtgEmpresas[20,fila].Value.ToString(),
										            Convert.ToInt16(dtgEmpresas[0,fila].Value),
										           	Convert.ToString(dtgEmpresas[26,fila].Value));
									}
								}
							}
							
							if(panelSec!=true)
								refPrincipal.principal.contandoViajes(1,aliasSig, lblNombreEmp.Text, "A");
							
							
							break;
							parar=1;
						}
					}
					if(parar==1)
						break;
				}
			}
			if(sentido==2)
			{
				for(int x=0; x<refPrincipal.refMOV.Count; x++)
				{
					for(int y=0; y<refPrincipal.refMOV[x].dtgEmpresas.Rows.Count; y++)
					{
						if(refPrincipal.refMOV[x].dtgEmpresas[10,y].Value.Equals(aliasAnt))
						{
							if(panelSec!=true)
								refPrincipal.principal.contandoViajes(-1,aliasAnt, lblNombreEmp.Text, "A");
							
							if(cambio=="cambiar")
							{
								camnioOperador(refPrincipal.principal.datosOpAsi.ID_OPERADOR,
									            refPrincipal.principal.datosOpAsi.ID_VEHICULO,
									            refPrincipal.principal.datosOpAsi.tipoVehiculo,
									            Convert.ToInt16(dtgEmpresas[22,fila].Value),
									            Convert.ToInt16(dtgEmpresas[23,fila].Value));
							}
							
							dtgEmpresas[11,fila].Value=aliasSig;
							dtgEmpresas[22,fila].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR;
							dtgEmpresas[23,fila].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO;
							dtgEmpresas[24,fila].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo;
							dtgEmpresas[13,fila].Value=System.DateTime.Now.ToString("HH:mm");
							for(int z=9; z<17; z++)
							{
								dtgEmpresas[z,fila].Style.BackColor=Color.MediumSpringGreen;
							}
							
							if(cambio=="suplir")
							{
								if(revisado!=Convert.ToInt16(dtgEmpresas[22,fila].Value))
								{
									DialogResult result=MessageBox.Show("¿El operador se encontraba en ruta?","Supliendo Ruta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
									if(DialogResult.OK==result)
									{
										guardaViaje(dtgEmpresas[10,fila].Value.ToString(),
										            dtgEmpresas[13,fila].Value.ToString(),
										            dtgEmpresas[15,fila].Value.ToString(),
										            20,Convert.ToInt16(dtgEmpresas[21,fila].Value),
										            Convert.ToInt16(dtgEmpresas[22,fila].Value),
										            Convert.ToInt16(dtgEmpresas[23,fila].Value),
										            dtgEmpresas[24,fila].Value.ToString(),
										            Convert.ToInt16(dtgEmpresas[9,fila].Value),
										           	Convert.ToString(dtgEmpresas[26,fila].Value));
									}
									else
									{
										guardaViaje(dtgEmpresas[10,fila].Value.ToString(),
										            dtgEmpresas[13,fila].Value.ToString(),
										            dtgEmpresas[15,fila].Value.ToString(),
										            21,Convert.ToInt16(dtgEmpresas[21,fila].Value),
										            Convert.ToInt16(dtgEmpresas[22,fila].Value),
										            Convert.ToInt16(dtgEmpresas[23,fila].Value),
										            dtgEmpresas[24,fila].Value.ToString(),
										            Convert.ToInt16(dtgEmpresas[9,fila].Value),
										           	Convert.ToString(dtgEmpresas[26,fila].Value));
									}
								}
							}
							
							if(panelSec!=true)
								refPrincipal.principal.contandoViajes(1,aliasSig, lblNombreEmp.Text, "A");
							
							
							break;
							parar=1;
						}
					}
					if(parar==1)
						break;
				}
			}
		}
		
		public void rutaOperador(int sentido, String alias, int fila)
		{
			if(sentido==1)
			{
				if(dtgEmpresas[3,fila].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
				{
					refPrincipal.principal.contandoViajes(-1,dtgEmpresas[3,fila].Value.ToString(), lblNombreEmp.Text, "B");
				}
				
				dtgEmpresas[3,fila].Value=alias;
				dtgEmpresas[18,fila].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
				dtgEmpresas[19,fila].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
				dtgEmpresas[20,fila].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
				
				dtgEmpresas[3,fila].Style.BackColor=Color.MediumSpringGreen;
				
				if(panelSec!=true)
				{
					refPrincipal.principal.contandoViajes(1,dtgEmpresas[3,fila].Value.ToString(), lblNombreEmp.Text, "A");
				}
				
				dtgEmpresas[0,fila].Style.BackColor=Color.Red;
				for(int z=4; z<9; z++)
				{
					dtgEmpresas[z,fila].Style.BackColor=Color.White;
				}
			}
			if(sentido==2)
			{
				if(dtgEmpresas[11,fila].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
				{
					refPrincipal.principal.contandoViajes(-1,dtgEmpresas[11,fila].Value.ToString(), lblNombreEmp.Text, "B");
				}
				
				dtgEmpresas[11,fila].Value=alias;
				dtgEmpresas[22,fila].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
				dtgEmpresas[23,fila].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
				dtgEmpresas[24,fila].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
				
				dtgEmpresas[11,fila].Style.BackColor=Color.MediumSpringGreen;
				
				if(panelSec!=true)
				{
					refPrincipal.principal.contandoViajes(1,dtgEmpresas[11,fila].Value.ToString(), lblNombreEmp.Text, "A");
				}
				
				dtgEmpresas[9,fila].Style.BackColor=Color.Red;
				for(int z=12; z<17; z++)
				{
					dtgEmpresas[z,fila].Style.BackColor=Color.White;
				}
			}
		}
		#endregion
		
		#region BOTON ELIMINAR RUTA
		void CmdDeleteClick(object sender, EventArgs e)
		{
			if(rutaSelected!=-1)
			{
				if(dtgEmpresas[6,rutaSelected].Style.BackColor.Name!="MediumSpringGreen" || dtgEmpresas[14,rutaSelected].Style.BackColor.Name!="MediumSpringGreen")
				{
					if(rutaSelected<dtgEmpresas.Rows.Count)
					{
						if(dtgEmpresas[6,rutaSelected].Value.ToString()!=" " && dtgEmpresas[14,rutaSelected].Value.ToString()!=" ")
						{
							if(dtgEmpresas[6,rutaSelected].Style.BackColor.Name!="MediumSpringGreen" && dtgEmpresas[14,rutaSelected].Style.BackColor.Name!="MediumSpringGreen")
							{
								formAdDeRuta = new Interfaz.Operaciones.FormAddDelRutas(this,"C");
								formAdDeRuta.modRuta("¿Como desea eliminar la ruta?");
								formAdDeRuta.ShowDialog();
								indic=1;
							}
							else
							{
								MandarMsj();
							}
						}
						else
						{
							MandarMsj();
						}
					}
					else
					{
						MessageBox.Show("Seleccione una ruta");
					}
				}
				else
				{
					MessageBox.Show("No se puede eliminar por que ya tiene un operador asignado");
				}
			}
			else
			{
				MessageBox.Show("Es necesario seleccionar una ruta");
			}
		}
		
		
		#region MENSAJE ELIMINACION RUTA
		public void MandarMsj()
		{
			if(dtgEmpresas[6,rutaSelected].Value.ToString()!=" " && rutaSelectedColumn<9)
			{
				if(dtgEmpresas[6,rutaSelected].Style.BackColor.Name!="MediumSpringGreen")
				{
					formAdDeRuta = new Interfaz.Operaciones.FormAddDelRutas(this,"E");
					formAdDeRuta.modRuta("¿Como desea eliminar la ruta?");
					formAdDeRuta.ShowDialog();
					indic=1;
				}
				else
				{
					MessageBox.Show("No se puede agregar por que ya tiene un operador asignado");
				}
			}
			else
			{
				if(dtgEmpresas[14,rutaSelected].Value.ToString()!=" " && rutaSelectedColumn>8 && rutaSelectedColumn<17)
				{
					if(dtgEmpresas[14,rutaSelected].Style.BackColor.Name!="MediumSpringGreen")
					{	
						formAdDeRuta = new Interfaz.Operaciones.FormAddDelRutas(this,"S");
						formAdDeRuta.modRuta("¿Como desea eliminar la ruta?");
						formAdDeRuta.ShowDialog();
						indic=1;
					}
					else
					{
						MessageBox.Show("No se puede agregar por que ya tiene un operador asignado");
					}
				}
				else
				{
					MessageBox.Show("Seleccione una ruta");
				}
			}
		}
		#endregion
		#endregion
		
		#region BOTON NUEVA RUTA
		void CmdAgregarClick(object sender, EventArgs e)
		{
			Int64 id_emmp = 0;
			if(lblNombreEmp.Text.Contains("FARMACIAS") && lblNombreEmp.Text.Contains("CAMIONETAS"))
			{
				id_emmp=42;
			}
			else if(lblNombreEmp.Text.Contains("FARMACIAS") && lblNombreEmp.Text.Contains("CAMIONES") && !lblNombreEmp.Text.Contains("APOYOS"))
			{
				id_emmp=14;
			}
			else if (lblNombreEmp.Text.Contains("HENNIGES") && lblNombreEmp.Text.Contains("CAMIONETAS"))
			{
				id_emmp=22;
			}
			else if (lblNombreEmp.Text.Contains("HENNIGES") && lblNombreEmp.Text.Contains("CAMIONES"))
			{
				id_emmp=3403;
			}
			
			if(id_emmp!=0)
			{
				new Interfaz.Ruta.FormRutasExtras(this, id_emmp).ShowDialog();
			}
			else
			{
				new Interfaz.Ruta.FormRutasExtras(this, id_Empresa).ShowDialog();
			}
			
			
			indic2=0;
			indic=0;
			extendida=0;
		}
		
		public void nuevaruta(int tipo)
		{
			if(tipo==1)
			{
				getIdEmpresa();
				if(id_Empresa>0)
				{
					Interfaz.Ruta.FormRuta nuevaRuta = new Transportes_LAR.Interfaz.Ruta.FormRuta(this,null,id_Empresa.ToString(),1);
					nuevaRuta.ShowDialog();
					nuevaRuta.gbDias.Enabled=false;
					//nuevaRuta.tabControl1.TabPages.RemoveAt(1);
					nuevaRuta.MdiParent=refPrincipal.principal;
				}
			}
			else
			{
				getIdEmpresa();
				if(id_Empresa>0)
				{
					Interfaz.Ruta.FormRuta nuevaRuta = new Transportes_LAR.Interfaz.Ruta.FormRuta(this,null,id_Empresa.ToString(),0);
					nuevaRuta.ShowDialog();
					
					//nuevaRuta.gbDias.Enabled=false;
					//nuevaRuta.tabControl1.TabPages.RemoveAt(1);
					nuevaRuta.MdiParent=refPrincipal.principal;
				}
			}
		}
		#endregion
		
		#region DOUBLE CLICK DATAGRID
		void DtgEmpresasDoubleClick(object sender, EventArgs e)
		{
			try
			{
				if(nomEmpresa=="ESPECIALES")
				{
					cmdInformacion.Visible=true;
				}
					
				if(dtgEmpresas.CurrentCell.ColumnIndex>0 && dtgEmpresas.CurrentCell.ColumnIndex<9)
				{
					rutaEspecial=Convert.ToInt16(dtgEmpresas.CurrentRow.Cells[2].Value);	
				}
				else if(dtgEmpresas.CurrentCell.ColumnIndex>8)
				{
					rutaEspecial=Convert.ToInt16(dtgEmpresas.CurrentRow.Cells[10].Value);
				}
				
				if(dtgEmpresas.CurrentCell.ColumnIndex==0)
				{
					if(dtgEmpresas.CurrentRow.Cells[6].Value.ToString()!="" && dtgEmpresas.CurrentRow.Cells[3].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas.CurrentRow.Cells[6].Style.BackColor.Name!="MediumSpringGreen")
					{
						for(int y=0; y<9; y++)
						{
							dtgEmpresas[y,dtgEmpresas.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
							if(y==5)
							{
								dtgEmpresas[y,dtgEmpresas.CurrentRow.Index].Value=System.DateTime.Now.ToString("HH:mm");
							}
						}
						guardaViaje(dtgEmpresas[2,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            dtgEmpresas[5,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            dtgEmpresas[7,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            1,((dtgEmpresas[17,dtgEmpresas.CurrentRow.Index].Value.ToString()==" ")?0:Convert.ToInt16(dtgEmpresas[17,dtgEmpresas.CurrentRow.Index].Value)),
						            Convert.ToInt16(dtgEmpresas[18,dtgEmpresas.CurrentRow.Index].Value),
						            Convert.ToInt16(dtgEmpresas[19,dtgEmpresas.CurrentRow.Index].Value),
						            dtgEmpresas[20,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            Convert.ToInt16(dtgEmpresas[0,dtgEmpresas.CurrentRow.Index].Value),
						            ((dtgEmpresas[26,dtgEmpresas.CurrentRow.Index].Value.ToString()==" ")?" ":dtgEmpresas[26,dtgEmpresas.CurrentRow.Index].Value.ToString()));
						
						asignacionIdOperacion(dtgEmpresas.CurrentRow.Index,1);
						
						dtgEmpresas[8,dtgEmpresas.CurrentRow.Index].Value=true;
						//MessageBox.Show("1");
						
						if(datosEspeciales==true)
						{
							forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[2,dtgEmpresas.CurrentRow.Index].Value), Convert.ToInt64(dtgEmpresas[17,dtgEmpresas.CurrentRow.Index].Value), dtgEmpresas.CurrentRow.Index, dtgEmpresas[5,dtgEmpresas.CurrentRow.Index].Value.ToString());
						}
					}
						
					if(dtgEmpresas.CurrentRow.Cells[14].Value.ToString()!="" && dtgEmpresas.CurrentRow.Cells[14].Value.ToString()!="" && dtgEmpresas.CurrentRow.Cells[11].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas.CurrentRow.Cells[14].Style.BackColor.Name!="MediumSpringGreen")
					{
						for(int y=9; y<17; y++)
						{
							dtgEmpresas[y,dtgEmpresas.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
							if(y==13)
							{
								dtgEmpresas[y,dtgEmpresas.CurrentRow.Index].Value=System.DateTime.Now.ToString("HH:mm");
								
							}
						}
						
						guardaViaje(dtgEmpresas[10,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            dtgEmpresas[13,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            dtgEmpresas[15,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            1,((dtgEmpresas[21,dtgEmpresas.CurrentRow.Index].Value.ToString()==" ")?0:Convert.ToInt16(dtgEmpresas[21,dtgEmpresas.CurrentRow.Index].Value)),
						            Convert.ToInt16(dtgEmpresas[22,dtgEmpresas.CurrentRow.Index].Value),
						            Convert.ToInt16(dtgEmpresas[23,dtgEmpresas.CurrentRow.Index].Value),
						            dtgEmpresas[24,dtgEmpresas.CurrentRow.Index].Value.ToString(),
						            Convert.ToInt16(dtgEmpresas[9,dtgEmpresas.CurrentRow.Index].Value),
						           	((dtgEmpresas[26,dtgEmpresas.CurrentRow.Index].Value.ToString()==" ")?" ":dtgEmpresas[26,dtgEmpresas.CurrentRow.Index].Value.ToString()));
						           	
						asignacionIdOperacion(dtgEmpresas.CurrentRow.Index,2);
						dtgEmpresas[16,dtgEmpresas.CurrentRow.Index].Value=true;
						//MessageBox.Show("2");
						if(datosEspeciales==true)
						{
							forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[10,dtgEmpresas.CurrentRow.Index].Value), Convert.ToInt64(dtgEmpresas[21,dtgEmpresas.CurrentRow.Index].Value), dtgEmpresas.CurrentRow.Index, dtgEmpresas[13,dtgEmpresas.CurrentRow.Index].Value.ToString());
						}
					}
					
					dtgEmpresas.ClearSelection();
				}
				else if(dtgEmpresas.CurrentCell.ColumnIndex!=8 && dtgEmpresas.CurrentCell.ColumnIndex!=16)
				{
					if(dtgEmpresas.CurrentCell.Style.BackColor.Name!="MediumSpringGreen" && dtgEmpresas.CurrentCell.ColumnIndex<24 && panelSec==false)
					{
						if(dtgEmpresas.CurrentCell.ColumnIndex<9)
						{
							if(dtgEmpresas.CurrentRow.Cells[6].Value.ToString()!="")
							{
								// Entrada
								refPrincipal.principal.RutaDatagris=dtgEmpresas.CurrentRow.Index;
								refPrincipal.principal.Empresa=lblNombreEmp.Text;
								refPrincipal.principal.sent=1;
								
								for(int y=0; y<8; y++)
								{
									dtgEmpresas.CurrentRow.Cells[y].Style.BackColor=Color.DodgerBlue;
								}
							}
						}
						else
						{
							if(dtgEmpresas.CurrentRow.Cells[14].Value.ToString()!="")
							{
								// Salida
								refPrincipal.principal.RutaDatagris=dtgEmpresas.CurrentRow.Index;
								refPrincipal.principal.Empresa=lblNombreEmp.Text;
								refPrincipal.principal.sent=2;
								for(int y=9; y<16; y++)
								{
									dtgEmpresas.CurrentRow.Cells[y].Style.BackColor=Color.DodgerBlue;
								}
							}
						}
					}
				}
			}
			catch(Exception)
			{
					
			}
		}
		#endregion
		
		#region REVISION CERRADO
		void CmdGuardaCuposClick(object sender, EventArgs e)
		{
			int band=0;
			
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(dtgEmpresas[0,x].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas[6,x].Value.ToString()!=" ")
				{
					try
					{
						new Conexion_Servidor.Desapacho.SQL_Operaciones().modificarLlegada2(Convert.ToInt64(dtgEmpresas[17,x].Value),((dtgEmpresas[7,x].Value.ToString().Length<5)?"00:00":dtgEmpresas[7,x].Value.ToString()), Convert.ToInt64(dtgEmpresas[0,x].Value));
						new Interfaz.FormMensaje("Cupos guardados correctamente");
					}
					catch
					{
						band=1;
					}
				}
				
				if(dtgEmpresas[9,x].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas[14,x].Value.ToString()!=" ")
				{
					try
					{
						new Conexion_Servidor.Desapacho.SQL_Operaciones().modificarLlegada2(Convert.ToInt64(dtgEmpresas[21,x].Value),"00:00", Convert.ToInt64(dtgEmpresas[9,x].Value));
						new Interfaz.FormMensaje("Cupos guardados correctamente");
					}
					catch
					{
						band=1;
					}
				}
			}
			
			if(band==1)
			{
				MessageBox.Show("Existío un error en la captura de cupos.");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(revisionTerminado())
			{
				// chekar en las referencias guardadas
				this.Visible=false;
				refPrincipal.mueve2(this);
			}
			else
			{
				DialogResult result=MessageBox.Show("Existen Rutas sin asignar. ¿Desea continuar con el cerrado?","Cerrando la aplicación",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
				if(DialogResult.OK==result)
				{
					// chekar en las referencias guardadas
					this.Visible=false;
					refPrincipal.mueve2(this);
				}
				else
				{
					cancelarCerrado();
				}
			}
		}
		
		public void cancelarCerrado()
		{
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(dtgEmpresas[6,x].Style.BackColor.Name=="LightPink")
				{
					dtgEmpresas[6,x].Style.BackColor=Color.White;
					dtgEmpresas[0,x].Style.BackColor=Color.Red;
				}
			}
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(dtgEmpresas[14,x].Style.BackColor.Name=="LightPink")
				{
					dtgEmpresas[14,x].Style.BackColor=Color.White;
					dtgEmpresas[9,x].Style.BackColor=Color.Red;
				}
			}
		}
		
		public bool revisionTerminado()
		{
			bool respuesta=false;
			int bandera=0;
			int regM=0;
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(dtgEmpresas[0,x].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas[6,x].Value.ToString()!=" ")
				{
					if(Convert.ToInt16(dtgEmpresas[0,x].Value)>0)
					{
						try
						{
							new Conexion_Servidor.Desapacho.SQL_Operaciones().modificarLlegada(Convert.ToInt64(dtgEmpresas[17,x].Value), ((dtgEmpresas[7,x].Value.ToString().Length<5)?"00:00":dtgEmpresas[7,x].Value.ToString()), Convert.ToInt64(dtgEmpresas[0,x].Value));
						}
						catch
						{
							bandera=1;
							regM=1;
						}
					}
				}
				else
				{
					if(dtgEmpresas[6,x].Value.ToString()!=" ")
					{
						bandera=1;
						dtgEmpresas[6,x].Style.BackColor=Color.LightPink;
					}
				}
			}
			
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(dtgEmpresas[9,x].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas[14,x].Value.ToString()!=" ")
				{
					if(Convert.ToInt16(dtgEmpresas[9,x].Value)>0)
					{
						try
						{
							new Conexion_Servidor.Desapacho.SQL_Operaciones().modificarLlegada(Convert.ToInt64(dtgEmpresas[21,x].Value),"00:00", Convert.ToInt64(dtgEmpresas[9,x].Value));
						}
						catch
						{
							bandera=1;
							regM=1;
						}
					}
				}
				else
				{
					if(dtgEmpresas[14,x].Value.ToString()!=" ")
					{
						bandera=1;
						dtgEmpresas[14,x].Style.BackColor=Color.LightPink;
					}
				}
			}
			if(bandera==1)
			{
				if(regM==1)
				{
					MessageBox.Show("Existen errores de registro de pasajeros");
				}
				respuesta=false;
			}
			else
			{
				respuesta=true;
			}
			
			if(refPrincipal.principal.cerrrado==true)
			{
				respuesta=true;
			}
			
			return respuesta;
		}
		#endregion
		
		#region CANCELAR O CAMBIAR HORA DE RUTA
		void DtgEmpresasCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.Button== MouseButtons.Right)
			{
				if(e.RowIndex!=-1 && e.RowIndex<dtgEmpresas.Rows.Count && e.ColumnIndex<17)
				{
					FormCancelCambio CanCam = new FormCancelCambio(this,e.RowIndex,e.ColumnIndex);
					CanCam.ShowDialog();
				}
				else if(e.RowIndex!=-1 && e.RowIndex<dtgEmpresas.Rows.Count && e.ColumnIndex==26)
				{
					//dtgEmpresas[e.ColumnIndex, e.RowIndex].Style.BackColor=Color.Red;
					formMsj = new FormMensaje(e.RowIndex, e.ColumnIndex, this);
					formMsj.ShowDialog();
				}
			}
		}
		#endregion
		
		#region AGREGAR APOYO RUTA
		public void apoyoOp_Ruta()
		{
			DateTime Hoy = DateTime.Today;
			int dia =  Convert.ToInt16(Hoy.ToString("dd"))-1;
 			String fecha_actual = Hoy.ToString("MM-yyyy");
			
 			
 			ApoyoRutaOp = new Conexion_Servidor.Desapacho.SQL_Operaciones().getListApoyoRuta_Op(miTurno, dia+"-"+fecha_actual, nomEmpresa);
			try
			{
				for(int x=0; x<dtgEmpresas.Rows.Count; x++)
				{
					if(Convert.ToString(dtgEmpresas[6,x].Value)!="")
					{
						for(int y=0; y<ApoyoRutaOp.Count; y++)
						{
							if(ApoyoRutaOp[y].Empresa.Equals(lblNombreEmp.Text) &&
							   ApoyoRutaOp[y].Ruta.Equals(dtgEmpresas[6,x].Value.ToString()) &&
							   dtgEmpresas[6,x].Style.BackColor.Name.ToString()!="MediumSpringGreen" &&
							   ApoyoRutaOp[y].Sentido.Equals("Entrada"))
							{
								dtgEmpresas[3,x].Value=ApoyoRutaOp[y].Operador;
							}
						}
					}
				}
				
				for(int x=0; x<dtgEmpresas.Rows.Count; x++)
				{
					if(Convert.ToString(dtgEmpresas[14,x].Value)!="")
					{
						for(int y=0; y<ApoyoRutaOp.Count; y++)
						{
							if(ApoyoRutaOp[y].Empresa.Equals(lblNombreEmp.Text) &&
							   ApoyoRutaOp[y].Ruta.Equals(dtgEmpresas[14,x].Value.ToString()) &&
							   dtgEmpresas[14,x].Style.BackColor.Name.ToString()!="MediumSpringGreen" &&
							   ApoyoRutaOp[y].Sentido.Equals("Salida"))
							{
								dtgEmpresas[11,x].Value=ApoyoRutaOp[y].Operador;
							}
						}
					}
				}
			}
			catch(Exception)
			{
				
			}
		} 
		#endregion
		
		#region MENEJO DATOS GUARDIA
		#region ASIGNANDO GUARDIA
		void CmdGuardiaClick(object sender, EventArgs e)
		{
			if(refPrincipal.principal.datosOpAsi!=null)
			{
				if(lblGuardia.Visible==false)
				{
					// ************************************************************************************************************
					lblGuardia.Visible=true;
					lblG.Visible=true;
					lblGuardia.Text=refPrincipal.principal.AliasOperador;
					lblIDO.Text=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
					
					new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarGuardias(refPrincipal.principal.idUsuario,refPrincipal.principal.datosOpAsi.ID_OPERADOR,id_Empresa,refPrincipal.fecha_despacho,refPrincipal.lblTurno.Text,"0","G");
					
					for(int x=0; x<refPrincipal.principal.RefOperadoresPrinc.Count; x++)
					{
						if(refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.Text.Equals(refPrincipal.principal.AliasOperador))
						{
							refPrincipal.principal.RefOperadoresPrinc[x].colorEstado("G");
							refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.BackColor=Color.White;
						}
					}
					
					refPrincipal.principal.AliasOperador="";
					refPrincipal.principal.guardia="";
					refPrincipal.principal.datosAsignacion(null);
					cmdGuardia.Enabled=false;
					lblIDG.Text = (new Conexion_Servidor.Desapacho.SQL_Operaciones().getIDGuardia()).ToString();
					rutaGuardia();
					// ************************************************************************************************************
				}
				else
				{
					if(lblGuardia.Text!=refPrincipal.principal.AliasOperador)
					{
						DialogResult result=MessageBox.Show(lblGuardia.Text+" esta cubriendo la guardia. \n¿Desea cambiar el operador de guardia?","Guardia ya asignada.",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
		                if(DialogResult.OK==result)
		                {
		                	// ************************************************************************************************************
		                	for(int x=0; x<refPrincipal.principal.RefOperadoresPrinc.Count; x++)
							{
								if(refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.Text.Equals(lblGuardia.Text))
								{
									refPrincipal.principal.RefOperadoresPrinc[x].colorEstado("A");
									refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.BackColor=Color.White;
								}
							}
		                	
		                	lblGuardia.Text=refPrincipal.principal.AliasOperador;
		                	lblIDO.Text=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
							
		                	new Conexion_Servidor.Desapacho.SQL_Operaciones().cambiarGuardia(Convert.ToInt16(lblIDG.Text), refPrincipal.principal.datosOpAsi.ID_OPERADOR);
							
							for(int x=0; x<refPrincipal.principal.RefOperadoresPrinc.Count; x++)
							{
								if(refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.Text.Equals(refPrincipal.principal.AliasOperador))
								{
									refPrincipal.principal.RefOperadoresPrinc[x].colorEstado("G");
									refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.BackColor=Color.White;
								}
							}
							refPrincipal.principal.AliasOperador="";
							refPrincipal.principal.guardia="";
							refPrincipal.principal.datosAsignacion(null);
							cmdGuardia.Enabled=false;
							rutaGuardia();
							// ************************************************************************************************************
		                }
					}
					else
					{
						MessageBox.Show("Ya esta asignado el operador en la guardia.");
					}
				}
			}
			else
			{
				MessageBox.Show("Seleccione un operador para asignar a una guardia");
			}
		}
		#endregion
		
		#region CANCELANDO GUARDIA
		void LblGuardiaMouseUp(object sender, MouseEventArgs e)
		{
			if(e.Button== MouseButtons.Right)
			{
				if(lblGuardia.Visible==true && lblGuardia.Text!="Operador")
				{
					DialogResult result=MessageBox.Show("¿Desea cancelar guardia?","Cancelando guardia.",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
	                if(DialogResult.OK==result)
	                {
	                	for(int x=0; x<refPrincipal.principal.RefOperadoresPrinc.Count; x++)
						{
							if(refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.Text.Equals(lblGuardia.Text))
							{
								refPrincipal.principal.RefOperadoresPrinc[x].colorEstado("A");
								refPrincipal.principal.RefOperadoresPrinc[x].txtAlias.BackColor=Color.White;
							}
						}
	                	new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelarGuardia(Convert.ToInt16(lblIDG.Text), Convert.ToInt16(lblIDO.Text));
	                	lblGuardia.Text="";
	                	lblGuardia.Visible=false;
	                	lblG.Visible=false;
	                	lblIDO.Text="";
	                	lblIDG.Text="";
	                }
				}
			}
		}
		#endregion
		
		#region CHEKAR RUTA
		public void rutaGuardia()
		{
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				/*if(dtgEmpresas[3,x].Value.ToString()==lblGuardia.Text)
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().viajeGuardia(Convert.ToInt16(lblIDG.Text));
				}*/
				if(dtgEmpresas[11,x].Value.ToString()==lblGuardia.Text)
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().viajeGuardia(Convert.ToInt16(lblIDG.Text));
				}
			}
		}
		#endregion
		#endregion
		
		#region CONFIRMADA DE ASIGNACION
		void DtgEmpresasCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				//MessageBox.Show(dtgEmpresas[8,e.RowIndex].Value.ToString());
				if((dtgEmpresas[8,e.RowIndex].Value.ToString()=="0" || dtgEmpresas[8,e.RowIndex].Value.ToString()=="False") && dtgEmpresas[3,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen") && e.ColumnIndex==8)
				{
					dtgEmpresas[8,e.RowIndex].Value=true;
					confirmaAsignacion(1,e);
				}
				else if(e.ColumnIndex==8 && dtgEmpresas[6,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
				{
					dtgEmpresas[8,e.RowIndex].Value=false;
					new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion2(Convert.ToInt64(dtgEmpresas[17,e.RowIndex].Value), refPrincipal.principal.idUsuario);
					dtgEmpresas[5,e.RowIndex].Value="00:00";
					dtgEmpresas[7,e.RowIndex].Value="00:00";
					dtgEmpresas[17,e.RowIndex].Value="0";
					for(int x=0; x<9; x++)
					{
						dtgEmpresas[x,e.RowIndex].Style.BackColor=Color.White;
					}
					dtgEmpresas[0,e.RowIndex].Style.BackColor=Color.Red;
					dtgEmpresas[3,e.RowIndex].Style.BackColor=Color.MediumSpringGreen;
					
					if(datosEspeciales==true)
					{
						forDatosEsp.delConfirmacion(Convert.ToInt64(dtgEmpresas[2,filaSelect].Value));
					}
				}
				else if(e.ColumnIndex==8)
				{
					dtgEmpresas[8,e.RowIndex].Value=false;
					dtgEmpresas[8,e.RowIndex].Value=0;
				}
				/*else if(e.ColumnIndex==8 && dtgEmpresas[3,e.RowIndex].Style.BackColor.Name.ToString().Equals("White"))
				{
					dtgEmpresas[8,e.RowIndex].Value=false;
				}*/
				
				if((dtgEmpresas[16,e.RowIndex].Value.ToString()=="0" || dtgEmpresas[16,e.RowIndex].Value.ToString()=="False") && dtgEmpresas[11,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen") && e.ColumnIndex==16)
				{
					dtgEmpresas[16,e.RowIndex].Value=true;
					confirmaAsignacion(2,e);
				}
				else if(e.ColumnIndex==16 && dtgEmpresas[14,e.RowIndex].Style.BackColor.Name.ToString().Equals("MediumSpringGreen"))
				{
					dtgEmpresas[16,e.RowIndex].Value=false;
					new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion2(Convert.ToInt64(dtgEmpresas[21,e.RowIndex].Value), refPrincipal.principal.idUsuario);
					dtgEmpresas[13,e.RowIndex].Value="00:00";
					dtgEmpresas[15,e.RowIndex].Value="00:00";
					dtgEmpresas[21,e.RowIndex].Value="0";
					for(int x=9; x<17; x++)
					{
						dtgEmpresas[x,e.RowIndex].Style.BackColor=Color.White;
					}
					dtgEmpresas[9,e.RowIndex].Style.BackColor=Color.Red;
					dtgEmpresas[11,e.RowIndex].Style.BackColor=Color.MediumSpringGreen;
					
					if(datosEspeciales==true)
					{
						forDatosEsp.delConfirmacion(Convert.ToInt64(dtgEmpresas[10,filaSelect].Value));
					}
				}
				else if(e.ColumnIndex==16)
				{
					dtgEmpresas[16,e.RowIndex].Value=false;
					dtgEmpresas[16,e.RowIndex].Value=0;
				}
				/*else if(e.ColumnIndex==16 && dtgEmpresas[11,e.RowIndex].Style.BackColor.Name.ToString().Equals("White"))
				{
					dtgEmpresas[16,e.RowIndex].Value=false;
				}*/
			}
		}
		
		public void confirmaAsignacion(int tipo, DataGridViewCellEventArgs e)
		{
			if(tipo==1)
			{
				if(guardaViaje(dtgEmpresas[2,e.RowIndex].Value.ToString(),
				            dtgEmpresas[5,e.RowIndex].Value.ToString(),
				            dtgEmpresas[7,e.RowIndex].Value.ToString(),
				            1,((dtgEmpresas[17,e.RowIndex].Value.ToString()==" " || dtgEmpresas[17,e.RowIndex].Value.ToString()=="")?0:Convert.ToInt64(dtgEmpresas[17,e.RowIndex].Value)),
				            Convert.ToInt64(dtgEmpresas[18,e.RowIndex].Value),
				            Convert.ToInt64(dtgEmpresas[19,e.RowIndex].Value),
				            dtgEmpresas[20,e.RowIndex].Value.ToString(),
				            Convert.ToInt16(dtgEmpresas[0,e.RowIndex].Value),
				            ((dtgEmpresas[26,e.RowIndex].Value.ToString()==" " || dtgEmpresas[26,e.RowIndex].Value.ToString()=="")?" ":dtgEmpresas[26,e.RowIndex].Value.ToString())))
				{
					//**************************************************
					bool encuentra=false;
					if(listMsj.Count>0)
					{
						for(int r=0; r<listMsj.Count; r++)
						{
							//MessageBox.Show(dtgEmpresas[18,e.RowIndex].Value.ToString()+"=="+listMsj[r].USUARIO);
							if(dtgEmpresas[18,e.RowIndex].Value.ToString()==listMsj[r].USUARIO && encuentra==false)
							{
								new Operaciones.Despacho.FormRecadoOperador(Convert.ToInt64(dtgEmpresas[18,e.RowIndex].Value)).ShowDialog();
								encuentra=true;
							}
						}
						encuentra=false;
					}
					//**************************************************
					
					for(int y=0; y<9; y++)
					{
						dtgEmpresas[y,e.RowIndex].Style.BackColor=Color.MediumSpringGreen;
						if(y==5)
						{
							dtgEmpresas[y,e.RowIndex].Value=System.DateTime.Now.ToString("HH:mm");
						}
					}
					
					
					asignacionIdOperacion(e.RowIndex,1);
					
					if(datosEspeciales==true)
					{
						forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[2,filaSelect].Value), Convert.ToInt64(dtgEmpresas[17,filaSelect].Value), e.RowIndex, dtgEmpresas[5,filaSelect].Value.ToString());
					}
				}
			}
			else if(tipo==2)
			{
				if(guardaViaje(dtgEmpresas[10,e.RowIndex].Value.ToString(),
				            dtgEmpresas[13,e.RowIndex].Value.ToString(),
				            dtgEmpresas[15,e.RowIndex].Value.ToString(),
				            1,((dtgEmpresas[21,e.RowIndex].Value.ToString()==" ")?0:Convert.ToInt64(dtgEmpresas[21,e.RowIndex].Value)),
				            Convert.ToInt64(dtgEmpresas[22,e.RowIndex].Value),
				            Convert.ToInt64(dtgEmpresas[23,e.RowIndex].Value),
				            dtgEmpresas[24,e.RowIndex].Value.ToString(),
				            Convert.ToInt16(dtgEmpresas[9,e.RowIndex].Value),
				           	((dtgEmpresas[26,e.RowIndex].Value.ToString()==" ")?" ":dtgEmpresas[26,e.RowIndex].Value.ToString())))
				{
					for(int y=9; y<17; y++)
					{
						dtgEmpresas[y,e.RowIndex].Style.BackColor=Color.MediumSpringGreen;
						if(y==13)
						{
							dtgEmpresas[y,e.RowIndex].Value=System.DateTime.Now.ToString("HH:mm");
							
						}
					}
					           	
					asignacionIdOperacion(e.RowIndex,2);
					
					if(datosEspeciales==true)
					{
						forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[10,filaSelect].Value), Convert.ToInt64(dtgEmpresas[21,filaSelect].Value), e.RowIndex, dtgEmpresas[13,filaSelect].Value.ToString());
					}
				}
			}
		}
		
		void FormEmpresasOperacionesMouseEnter(object sender, EventArgs e)
		{
			//refPrincipal.pPrincEmp.Select();
		}
		#endregion
		
		#region VALIDACION DATAGRID
		public int bandera=0;
		void DtgEmpresasKeyPress(object sender, KeyPressEventArgs e)
		{
			if((dtgEmpresas.CurrentCell.ColumnIndex==7 && dtgEmpresas.CurrentRow.Cells[7].Style.BackColor.Name=="MediumSpringGreen") || (dtgEmpresas.CurrentCell.ColumnIndex==15 && dtgEmpresas.CurrentRow.Cells[15].Style.BackColor.Name=="MediumSpringGreen"))
			{
				if(Char.IsNumber(e.KeyChar))
				{
					if(bandera==0)
					{
						if(Convert.ToInt16(e.KeyChar.ToString())<3)
						{
							dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value=e.KeyChar.ToString();
						}
						else if(Convert.ToInt16(e.KeyChar.ToString())>2)
						{
							dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value="0"+e.KeyChar.ToString();
						}
						bandera=1;
					}
					else if(dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString().Length==1)
					{
						if(dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()=="1" || dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()=="0")
						{
							dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value=dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
						}
						else if(dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()=="2" && Convert.ToInt16(e.KeyChar.ToString())<4)
						{
							dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value=dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
						}
						else
						{
							e.Handled=true;
						}
					}
					else if(dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString().Length==2 && Convert.ToInt16(e.KeyChar.ToString())<6)
					{
						dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value=dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()+":"+e.KeyChar.ToString();
					}
					else if(dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString().Length==4)
					{
						dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value=dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
					}
				}
				else if(e.KeyChar == (char)Keys.Back)
				{
					dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value="";
					bandera=0;
				}
			}
			else
			{
				e.Handled=true;
			}
			
			
			if((dtgEmpresas.CurrentCell.ColumnIndex==0 && dtgEmpresas.CurrentRow.Cells[0].Style.BackColor.Name=="MediumSpringGreen") || (dtgEmpresas.CurrentCell.ColumnIndex==9 && dtgEmpresas.CurrentRow.Cells[9].Style.BackColor.Name=="MediumSpringGreen"))
			{
				if(Char.IsNumber(e.KeyChar))
				{
					if(bandera==0)
					{
						dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value=e.KeyChar.ToString();
						bandera=1;
					}
					else if(bandera==1)
					{
						dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value=dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value.ToString()+e.KeyChar.ToString();
					}
				}
				else if(e.KeyChar == (char)Keys.Back)
				{
					dtgEmpresas.CurrentRow.Cells[dtgEmpresas.CurrentCell.ColumnIndex].Value="";
					bandera=0;
				}
			}
		}
		#endregion
		
		#region AUTOCOMPLETE DATAGRID
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		private int filaSelect=0;
		private int autoComp=0;
		
		void DtgEmpresasEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			//filaSelect = dtgEmpresas.CurrentRow.Index;
			if(dtgEmpresas.CurrentCell.ColumnIndex==3 || dtgEmpresas.CurrentCell.ColumnIndex==11)
			{
				if(dtgEmpresas.CurrentCell.ColumnIndex==3 && dtgEmpresas[6,dtgEmpresas.CurrentRow.Index].Style.BackColor.Name.ToString()!="MediumSpringGreen")
				{
					dtgEmpresas[3,filaSelect].Style.BackColor=Color.White;
					if (e.Control is DataGridViewTextBoxEditingControl)
		            {
						((TextBox)e.Control).AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias Dato from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR ");
		                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;
		                
		                ((TextBox)e.Control).KeyUp += DtgEmpresasKeyUp;
		                autoComp=1;
		            }
				}
				else if(dtgEmpresas.CurrentCell.ColumnIndex==11 && dtgEmpresas[14,dtgEmpresas.CurrentRow.Index].Style.BackColor.Name.ToString()!="MediumSpringGreen")
				{
					dtgEmpresas[11,filaSelect].Style.BackColor=Color.White;
					if (e.Control is DataGridViewTextBoxEditingControl )
		            {
						((TextBox)e.Control).AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias Dato from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR");
		                ((TextBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		                ((TextBox)e.Control).AutoCompleteSource = AutoCompleteSource.CustomSource;
		                
		                ((TextBox)e.Control).KeyUp += DtgEmpresasKeyUp;
		                autoComp=1;
		            }
				}
				else
				{
					if(dtgEmpresas.CurrentCell.ColumnIndex==3)
						dtgEmpresas[3,dtgEmpresas.CurrentRow.Index].ReadOnly=true;
					
					if(dtgEmpresas.CurrentCell.ColumnIndex==11)
						dtgEmpresas[11,dtgEmpresas.CurrentRow.Index].ReadOnly=true;
					
					
					if (e.Control is DataGridViewTextBoxEditingControl )
						((TextBox)e.Control).AutoCompleteCustomSource = null;
				}
			}
			else
			{
				if (e.Control is DataGridViewTextBoxEditingControl )
					((TextBox)e.Control).AutoCompleteCustomSource = null;
			}
			
			try
			{
				if(dtgEmpresas.CurrentCell.ColumnIndex==3)
					dtgEmpresas[3,dtgEmpresas.CurrentRow.Index].ReadOnly=false;
				
				if(dtgEmpresas.CurrentCell.ColumnIndex==11)
					dtgEmpresas[11,dtgEmpresas.CurrentRow.Index].ReadOnly=false;
			}
			catch(Exception)
			{
				
			}
		}
		
		void DtgEmpresasKeyUp(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next)
			{
				bandera=0;
				primera=0;
				if(dtgEmpresas.CurrentCell.ColumnIndex==3 || dtgEmpresas.CurrentCell.ColumnIndex==11)
				{
					filaSelect=dtgEmpresas.CurrentRow.Index;
				}
			}
			
			if(e.KeyCode == Keys.Return)
			{
				if(autoComp==0)
					dtgEmpresas.KeyDown += DtgEmpresasKeyDown;
				
				
				autoComp=0;
				
				if(filaSelect!=-1)
				{
					if(dtgEmpresas.CurrentCell.ColumnIndex==3)
					{
						refPrincipal.principal.datosOpAsi=null;
						
						if(panelSec!=true)
							refPrincipal.principal.contandoViajes(1,dtgEmpresas[3,filaSelect].Value.ToString(),lblNombreEmp.Text, "C");
						else if(panelSec==true)
							refPrincipal.principal.contandoViajes(0,dtgEmpresas[3,filaSelect].Value.ToString(),lblNombreEmp.Text, "C");
						
						
						if(refPrincipal.principal.datosOpAsi!=null)
						{
							if(dtgEmpresas[18,filaSelect].Value.ToString()!="")
							{
								if(panelSec!=true)
									refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[18,filaSelect].Value),lblNombreEmp.Text, "C");
								
								
								//MessageBox.Show(dtgEmpresas[3,filaSelect].Value.ToString()+"  "+filaSelect+"  "+refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString());
								dtgEmpresas[18,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
								dtgEmpresas[19,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
								dtgEmpresas[20,filaSelect].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								//MessageBox.Show(dtgEmpresas[18,filaSelect].Value.ToString());
								dtgEmpresas[3,filaSelect].Style.BackColor=Color.MediumSpringGreen;
								if(datosEspeciales==true)
								{
									forDatosEsp.asignaOperador(Convert.ToInt64(dtgEmpresas[2,filaSelect].Value), false);
								}
							}
							else
							{
								//MessageBox.Show(refPrincipal.principal.datosOpAsi.txtAlias.Text.ToString()+" DARIO "+refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString());
								dtgEmpresas[18,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
								dtgEmpresas[19,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
								dtgEmpresas[20,filaSelect].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
								dtgEmpresas[3,filaSelect].Style.BackColor=Color.MediumSpringGreen;
								if(datosEspeciales==true)
								{
									forDatosEsp.asignaOperador(Convert.ToInt64(dtgEmpresas[2,filaSelect].Value), false);
								}
							}
							//MessageBox.Show("("+dtgEmpresas[14,filaSelect].Style.BackColor.Name.ToString()+"!=MediumSpringGreen || "+dtgEmpresas[14,filaSelect].Style.BackColor.Name.ToString()+"!=0 ) && ("+dtgEmpresas.CurrentRow.Cells[14].Value.ToString()+"!=vacio espacio  || "+dtgEmpresas.CurrentRow.Cells[14].Value.ToString()+"!=sin espacio)");
							//MessageBox.Show("*"+dtgEmpresas[14,filaSelect].Value.ToString()+"*"+dtgEmpresas[14,filaSelect].Style.BackColor.Name.ToString());
							if(dtgEmpresas[14,filaSelect].Style.BackColor.Name.ToString()!="MediumSpringGreen" && dtgEmpresas[14,filaSelect].Value.ToString()!=" ")
							{
								if(dtgEmpresas[22,filaSelect].Value.ToString()!="" && panelSec!=true)
								{
									refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[22,filaSelect].Value),lblNombreEmp.Text, "C");
								}
								
								/*if(panelSec!=true)
									refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[22,filaSelect].Value),lblNombreEmp.Text, "C");*/
								if(panelSec!=true)
									refPrincipal.principal.contandoViajes(1,dtgEmpresas[3,filaSelect].Value.ToString(),lblNombreEmp.Text, "C");
								
								dtgEmpresas[11,filaSelect].Value=dtgEmpresas[3,filaSelect].Value.ToString();
								dtgEmpresas[22,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
								dtgEmpresas[23,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
								dtgEmpresas[24,filaSelect].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
								dtgEmpresas[11,filaSelect].Style.BackColor=Color.MediumSpringGreen;
								
								if(datosEspeciales==true)
								{
									forDatosEsp.asignaOperador(Convert.ToInt64(dtgEmpresas[10,filaSelect].Value), false);
								}
							}
							
						}
						else
						{
							dtgEmpresas[3,filaSelect].Value="Operador";
						}
					}
					
					if(dtgEmpresas.CurrentCell.ColumnIndex==11)
					{
						refPrincipal.principal.datosOpAsi=null;
						
						if(panelSec!=true)	
							refPrincipal.principal.contandoViajes(1,dtgEmpresas[11,filaSelect].Value.ToString(), lblNombreEmp.Text, "C");
						else if(panelSec==true)
							refPrincipal.principal.contandoViajes(0,dtgEmpresas[11,filaSelect].Value.ToString(),lblNombreEmp.Text, "C");
						
						if(refPrincipal.principal.datosOpAsi!=null)
						{
							if(dtgEmpresas[22,filaSelect].Value.ToString()!="")
							{
								if(panelSec!=true)
									refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[22,filaSelect].Value),lblNombreEmp.Text, "C");
								
								dtgEmpresas[22,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
								dtgEmpresas[23,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
								dtgEmpresas[24,filaSelect].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
								dtgEmpresas[11,filaSelect].Style.BackColor=Color.MediumSpringGreen;
							}
							else 
							{
								dtgEmpresas[22,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
								dtgEmpresas[23,filaSelect].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
								dtgEmpresas[24,filaSelect].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
								
								dtgEmpresas[11,filaSelect].Style.BackColor=Color.MediumSpringGreen;
							}
							
							if(datosEspeciales==true)
							{
								forDatosEsp.asignaOperador(Convert.ToInt64(dtgEmpresas[10,filaSelect].Value), false);
							}
						}
						else
						{
							dtgEmpresas[11,filaSelect].Value="Operador";
						}
					}
					dtgEmpresas.ClearSelection();
				}
				filaSelect=-1;
			}
		}
		#endregion
		
		void DtgEmpresasKeyDown(object sender, KeyEventArgs e)
		{
			if(dtgEmpresas.CurrentCell.ColumnIndex==3 && dtgEmpresas.CurrentCell.ColumnIndex==11)
			{
				filaSelect=dtgEmpresas.CurrentRow.Index;
				dtgEmpresas.KeyDown += DtgEmpresasKeyDown;
			}
		}
		
		//int mensaje=0; 
		void DtgEmpresasCellLeave(object sender, DataGridViewCellEventArgs e)
		{
			/*if(mensaje==0)
			{
				MessageBox.Show(" "+e.RowIndex);
				mensaje=1;
			}
			else if(mensaje==1)
			{
				mensaje=0;
			}*/
		}
		
		void DtgEmpresasCellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==26 && e.RowIndex!=-1)
			{
				if(dtgEmpresas[e.ColumnIndex,e.RowIndex].Style.BackColor.Name=="Red")
				{
					msjGlobo.muestrarMsj(dtgEmpresas[e.ColumnIndex,e.RowIndex].Value.ToString());
					msjGlobo.Location  = new System.Drawing.Point(Control.MousePosition.X, Control.MousePosition.Y);
					msjGlobo.Visible=true;
					msj=1;
				}
				else if(msj==1)
				{
					msjGlobo.Visible=false;
					msj=0;
				}
			}
			else if(msj==1)
			{
				msjGlobo.Visible=false;
				msj=0;
			}
		}
		
		void FormEmpresasOperacionesFormClosing(object sender, FormClosingEventArgs e)
		{
			forDatosEsp.Close();
		}
		
		// ************************************************ ESPECIALES ************************************************* //
		public void AsignacionOperadorAlt(Int64 id_RE)//, Int64 id_RS)
		{
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(((dtgEmpresas[2,x].Value.ToString()==" ")?0:Convert.ToInt64(dtgEmpresas[2,x].Value))==id_RE)
				{
					if(dtgEmpresas[18,x].Value.ToString()!="")
						refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[18,x].Value),lblNombreEmp.Text, "C");
									
					dtgEmpresas[3,x].Value=refPrincipal.principal.datosOpAsi.txtAlias.Text;
					dtgEmpresas[18,x].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
					dtgEmpresas[19,x].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
					dtgEmpresas[20,x].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
					
					dtgEmpresas[3,x].Style.BackColor=Color.MediumSpringGreen;
				}
				else if(((dtgEmpresas[10,x].Value.ToString()==" ")?0:Convert.ToInt64(dtgEmpresas[10,x].Value))==id_RE)
				{
					if(dtgEmpresas[22,x].Value.ToString()!="")
						refPrincipal.principal.apoyoDes(-1,Convert.ToInt16(dtgEmpresas[18,x].Value),lblNombreEmp.Text, "C");
									
					dtgEmpresas[11,x].Value=refPrincipal.principal.datosOpAsi.txtAlias.Text;
					dtgEmpresas[22,x].Value=refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
					dtgEmpresas[23,x].Value=refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
					dtgEmpresas[24,x].Value=refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
					
					dtgEmpresas[11,x].Style.BackColor=Color.MediumSpringGreen;
				}
			}
		}
		
		public void confirmaAlt(Int64 id_R)
		{
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(Convert.ToInt64(dtgEmpresas[2,x].Value)==id_R)
				{
					if(dtgEmpresas[6,x].Value.ToString()!="" && dtgEmpresas[3,x].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas[6,x].Style.BackColor.Name!="MediumSpringGreen")
					{
						if(guardaViaje(dtgEmpresas[2,x].Value.ToString(),
						            dtgEmpresas[5,x].Value.ToString(),
						            dtgEmpresas[7,x].Value.ToString(),
						            1,((dtgEmpresas[17,x].Value.ToString()==" ")?0:Convert.ToInt16(dtgEmpresas[17,x].Value)),
						            Convert.ToInt16(dtgEmpresas[18,x].Value),
						            Convert.ToInt16(dtgEmpresas[19,x].Value),
						            dtgEmpresas[20,x].Value.ToString(),
						            Convert.ToInt16(dtgEmpresas[0,x].Value),
						            ((dtgEmpresas[26,x].Value.ToString()==" ")?" ":dtgEmpresas[26,x].Value.ToString())))
						{
							for(int y=0; y<9; y++)
							{
								dtgEmpresas[y,x].Style.BackColor=Color.MediumSpringGreen;
								if(y==5)
								{
									dtgEmpresas[y,x].Value=System.DateTime.Now.ToString("HH:mm");
								}
							}
							
							
							asignacionIdOperacion(x,1);
							
							dtgEmpresas[8,x].Value=true;
							//MessageBox.Show("1");
							
							if(datosEspeciales==true)
							{
								forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[2,x].Value), Convert.ToInt64(dtgEmpresas[17,x].Value), x, dtgEmpresas[5,x].Value.ToString());
							}
						}
					}
				}
				
				if(((dtgEmpresas[10,x].Value.ToString()==" ")?0:Convert.ToInt64(dtgEmpresas[10,x].Value))==id_R)//Convert.ToInt64(dtgEmpresas[10,x].Value)==id_R)
				{
					if(dtgEmpresas.CurrentRow.Cells[14].Value.ToString()!="" && dtgEmpresas.CurrentRow.Cells[11].Style.BackColor.Name=="MediumSpringGreen" && dtgEmpresas.CurrentRow.Cells[14].Style.BackColor.Name!="MediumSpringGreen")
					{
						if(guardaViaje(dtgEmpresas[10,x].Value.ToString(),
						            dtgEmpresas[13,x].Value.ToString(),
						            dtgEmpresas[15,x].Value.ToString(),
						            1,((dtgEmpresas[21,x].Value.ToString()==" ")?0:Convert.ToInt16(dtgEmpresas[21,x].Value)),
						            Convert.ToInt16(dtgEmpresas[22,x].Value),
						            Convert.ToInt16(dtgEmpresas[23,x].Value),
						            dtgEmpresas[24,x].Value.ToString(),
						            Convert.ToInt16(dtgEmpresas[9,x].Value),
						            ((dtgEmpresas[26,x].Value.ToString()==" ")?" ":dtgEmpresas[26,x].Value.ToString())))
						{
							for(int y=9; y<17; y++)
							{
								dtgEmpresas[y,x].Style.BackColor=Color.MediumSpringGreen;
								if(y==13)
								{
									dtgEmpresas[y,x].Value=System.DateTime.Now.ToString("HH:mm");
								}
							}
							
							asignacionIdOperacion(x,2);
							dtgEmpresas[16,x].Value=true;
							//MessageBox.Show("2");
							
							if(datosEspeciales==true)
							{
								forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[10,x].Value), Convert.ToInt64(dtgEmpresas[21,x].Value), x, dtgEmpresas[13,x].Value.ToString());
							}
						}
					}
				}
			}
		}
		
		public void getPlaneacionAlt(Int64 id_Ruta)
		{
			for(int x=0; x<dtgEmpresas.Rows.Count; x++)
			{
				if(((dtgEmpresas[2,x].Value.ToString()==" ")?0:Convert.ToInt64(dtgEmpresas[2,x].Value)) == id_Ruta) // 10
				{
					if(dtgEmpresas[6,x].Style.BackColor.Name.ToString() == "MediumSpringGreen") // 14
					{
						forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[2,x].Value), Convert.ToInt64(dtgEmpresas[17,x].Value), x, dtgEmpresas[5,x].Value.ToString());
					}
					else if(dtgEmpresas[3,x].Style.BackColor.Name.ToString() == "MediumSpringGreen") // 11 
					{
						forDatosEsp.asignaOperador(Convert.ToInt64(dtgEmpresas[2,x].Value), true);
					}
				}
				else if(((dtgEmpresas[10,x].Value.ToString()==" ")?0:Convert.ToInt64(dtgEmpresas[10,x].Value)) == id_Ruta)
				{
					if(dtgEmpresas[14,x].Style.BackColor.Name.ToString() == "MediumSpringGreen") // 14
					{
						forDatosEsp.confirmaAsignacion(Convert.ToInt64(dtgEmpresas[10,x].Value), Convert.ToInt64(dtgEmpresas[21,x].Value), x, dtgEmpresas[13,x].Value.ToString());
					}
					else if(dtgEmpresas[11,x].Style.BackColor.Name.ToString() == "MediumSpringGreen") // 11 
					{
						forDatosEsp.asignaOperador(Convert.ToInt64(dtgEmpresas[10,x].Value), true);
					}
				}
			}
		}
		// **************************************************************************************************
		
		#region REVISION DE MENSAJES
		List<Interfaz.Operaciones.Dato.msjGerencial> listMsj = new List<Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial>();
		void getMensajes()
		{
			/*Mensajes unicos*/
			almacenaMensajes("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='1' and FECHA_INICIO=(SELECT CONVERT (DATE, SYSDATETIME())) and ID_O!=0");
			
			/*Mensajes diarios*/
			almacenaMensajes("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='2' and ID_O!=0 ");
			
			/*Mensajes por semana*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='3' and ID_O!=0 ");
			
			/*Cada dos semanas*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='4' and ID_O!=0 ");
			
			/*Por mes*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='5' and ID_O!=0 ");
			
			/*Por año*/
			almacenaMensajes2("select * from MENSAJE_GERECIAL where ESTATUS='1' AND TIPO='6' and ID_O!=0 ");
		}
		
		void almacenaMensajes(String Consulta)
		{
			conn.getAbrirConexion(Consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial datos = new Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial();
				datos.MENSAJE	=conn.leer["MENSAJE"].ToString();
				datos.ESTATUS	=conn.leer["ESTATUS"].ToString();
				datos.TIPO		=conn.leer["TIPO"].ToString();
				datos.CANTIDAD	=conn.leer["CANTIDAD"].ToString();
				datos.FECHA		=conn.leer["FECHA_REG"].ToString();
				datos.USUARIO	=conn.leer["ID_O"].ToString();
				
				listMsj.Add(datos);
			}
			conn.conexion.Close();
		}
		
		void almacenaMensajes2(String Consulta)
		{
			conn.getAbrirConexion(Consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				int x=0;
				int cantidad=0;
				DateTime fechaBase = Convert.ToDateTime(conn.leer["FECHA_INICIO"].ToString());
				
				do
				{
					x++;
					//MessageBox.Show(fechaBase.AddDays(cantidad).ToString("dd/MM/yyyy")+"=="+DateTime.Now.ToString("dd/MM/yyyy"));
					if(fechaBase.AddDays(cantidad).ToString("dd/MM/yyyy")==DateTime.Now.ToString("dd/MM/yyyy"))
					{
						Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial datos = new Transportes_LAR.Interfaz.Operaciones.Dato.msjGerencial();
						datos.MENSAJE	=conn.leer["MENSAJE"].ToString();
						datos.ESTATUS	=conn.leer["ESTATUS"].ToString();
						datos.TIPO		=conn.leer["TIPO"].ToString();
						datos.CANTIDAD	=conn.leer["CANTIDAD"].ToString();
						datos.FECHA		=conn.leer["FECHA_REG"].ToString();
						datos.USUARIO	=conn.leer["ID_O"].ToString();
						
						listMsj.Add(datos);
					}
					
					cantidad=Convert.ToInt16(conn.leer["CANTIDAD"])*x;
					//MessageBox.Show(fechaBase.AddDays(cantidad)+">"+DateTime.Now);
				}while(fechaBase.AddDays(cantidad)<DateTime.Now);
			}
			conn.conexion.Close();
		}
		#endregion
	}
}