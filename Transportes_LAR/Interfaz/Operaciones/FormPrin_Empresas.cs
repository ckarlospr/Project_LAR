using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Configuration;
using nmExcel = Microsoft.Office.Interop.Excel;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormPrin_Empresas : Form
	{
		#region VARIABLES E INSTANCIAS
		Interfaz.Operaciones.Despacho.FormPrincOperadores prinOperadores;
		
		bool listaEmp = false;
		
		String consEmpresas;
		String consEmpresas2;
		
		public List<String> rutasOperador = new List<String>();
		public List<String> IDrutasOperador = new List<String>();
		
		public bool carga=false;
		
		public Transportes_LAR.Interfaz.FormPrincipal principal=null;
		public Transportes_LAR.Interfaz.Operaciones.FormOperadores operadores= null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		private int posicion=0;
		private int posicion2=0;
		
		private int alto=0;
		private int color=0;
		
		public List<Interfaz.Operaciones.FormEmpresasOperaciones> refMOV =new List<Interfaz.Operaciones.FormEmpresasOperaciones>();
		public List<Interfaz.Operaciones.FormEmpresasOperaciones> refMSec =new List<Interfaz.Operaciones.FormEmpresasOperaciones>();
		private List<int> idMOV =new List<int>();
		private List<int> posMOV = new List<int>();
		private int indMOV=0;
		
		public List<Interfaz.Operaciones.FormEmpresasOperaciones> referencias = new List<Interfaz.Operaciones.FormEmpresasOperaciones>();
		public List<String> nomRef=new List<String>();
		public List<int> indRef=new List<int>();
		public int contRef = 0;
		public String ConsTurno="Mañana";
		private int sentido=0;
		private int sentido2=0;
		private int sentido3=0;
		private Interfaz.Operaciones.FormComentarios formcom = null;
		
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		public String fecha_despacho="";
		public String fecha_Base_Datos="";
		
		public List<String> listNomSubempresas=null ;
		private Interfaz.Operaciones.FormEmpresasOperaciones getFormEmpresasDtGrid = null;
		#endregion
		
		#region CONSTRUCTOR
		public FormPrin_Empresas(String turno, Transportes_LAR.Interfaz.FormPrincipal princ, String fecha_desp)
		{
			InitializeComponent();
			ConsTurno=turno;
			principal=princ;
			fecha_despacho=fecha_desp;
			fechaDatos(fecha_desp);
		}
		
		public void fechaDatos(String fecha)
		{
			String diaExtra = fecha.Substring(0,2);
			String mesExtra = fecha.Substring(3,2);
			String anioExtra = fecha.Substring(6,4);
			
			fecha_Base_Datos = anioExtra+"-"+mesExtra+"-"+diaExtra;
		}
		#endregion
		
		#region EVENTO LOAD
		void FormPrin_EmpresasLoad(object sender, EventArgs e)
		{
			getConsEmp();
			getSubNombresEmpresas();
			principal.refEmpresasPrinc=refMOV;
			
			txtBusqOper.AutoCompleteCustomSource = autocomp.AutoOp();
			txtBusqOper.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtBusqOper.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			lblTurno.Text=ConsTurno;
			lblDia.Text=fecha_despacho;
			tcPrincipal.TabPages[0].Text=ConsTurno;
			tcPrincipal.TabPages[1].Text=getTurnoSecundario(ConsTurno);
			tcPrincipal.TabPages[2].Show();
			tcPrincipal.SendToBack();
			
			formcom = new Interfaz.Operaciones.FormComentarios(this);
			formcom.MdiParent=principal;
			formcom.Show();
			formcom.Visible=false;
			
			pPrincEmp.SendToBack();
			getEmpresas();
			recRutas();
			recPruebasRend();
			datosApoyos();
			getMsjGral();
			
			if(lblDia.Text==DateTime.Now.ToString("dd/MM/yyyy"))
			{
				//new Actializacion.FormActualizacion(this);
				new Despacho.FormRecados().ShowDialog();
			}
			//getOperadores();
			obtenerParametroTiempo();
			UberTaxiPendientes();
		}
		
		
		// ----  NEW OPERADORES ---- //
		
		void getOperadores()
		{
			prinOperadores = new Interfaz.Operaciones.Despacho.FormPrincOperadores(this);
            prinOperadores.TopLevel = false;
            
            prinOperadores.FormBorderStyle = FormBorderStyle.None;
            this.pOperadores.Tag = prinOperadores;
            this.pOperadores.Controls.Add(prinOperadores);
           
            //prinOperadores.Size = new System.Drawing.Size(1100,(prinOperadores.dtgEmpresas.Size.Height+25));
            //getFormEmpresasDtGrid.panel1.AutoSize=true;
            
            prinOperadores.Location = new System.Drawing.Point(0,0);
            prinOperadores.Size = new System.Drawing.Size(pOperadores.Size.Width, pOperadores.Size.Height);
            
			prinOperadores.Show();
		}
		
		void FormPrin_EmpresasSizeChanged(object sender, EventArgs e)
		{
			//prinOperadores.Size = new System.Drawing.Size(pOperadores.Size.Width, pOperadores.Size.Height);
		}
		
		// ----  NEW OPERADORES ---- //
		
		public String getTurnoSecundario(String turno)
		{
			String Respuesta="";
			
			if(turno=="Mañana")
				Respuesta="Nocturno";
			else if(turno=="Medio día")
				Respuesta="Mañana";
			else if(turno=="Vespertino")
				Respuesta="Medio día";
			else if(turno=="Vespertino")
				Respuesta="Medio día";
			else if(turno=="Nocturno")
				Respuesta="Vespertino";
			
			return Respuesta;
		}
		
		public void recRutas()
		{
			dgReconocimientos.Rows.Clear();
			List<Interfaz.Operaciones.Dato.Operador> listRec = new Conexion_Servidor.Desapacho.SQL_Operaciones().getDatosRec(fecha_Base_Datos, ConsTurno);
			
			if(listRec!=null)
			{
				for(int x=0; x<listRec.Count; x++)
				{
					dgReconocimientos.Rows.Add(listRec[x].id, listRec[x].alias, (new Conexion_Servidor.Desapacho.SQL_Operaciones().getOpMuestra(Convert.ToInt16(listRec[x].id))), listRec[x].estatus.ToUpper());
				}
			}
			dgReconocimientos.ClearSelection();
		}
		
		public void recPruebasRend()
		{
			dgPruebasRend.Rows.Clear();
			List<Interfaz.Operaciones.Dato.Operador> listRec = new Conexion_Servidor.Desapacho.SQL_Operaciones().getDatosPruebas(fecha_Base_Datos, ConsTurno);
			
			if(listRec!=null)
			{
				for(int x=0; x<listRec.Count; x++)
				{
					dgPruebasRend.Rows.Add(listRec[x].id, listRec[x].alias, (new Conexion_Servidor.Desapacho.SQL_Operaciones().getOpMuestra2(Convert.ToInt16(listRec[x].id))), listRec[x].estatus.ToUpper());
				}
			}
			dgPruebasRend.ClearSelection();
		}
		
		public void datosApoyos()
		{
			dgApoyos.Rows.Clear();
			List<Interfaz.Operaciones.Dato.Operador> listRec = new Conexion_Servidor.Desapacho.SQL_Operaciones().getapoyos(fecha_Base_Datos, ConsTurno);
			
			if(listRec!=null)
			{
				for(int x=0; x<listRec.Count; x++)
				{
					dgApoyos.Rows.Add(listRec[x].id, listRec[x].alias, listRec[x].tipoV.ToUpper(), listRec[x].estatus.ToUpper(), listRec[x].ruta.ToUpper(), listRec[x].usuario.ToUpper(), listRec[x].empresa.ToUpper());
				}
			}
			dgApoyos.ClearSelection();
		}
		
		public void getMsjGral()
		{
			txtMSJ.Text = new Conexion_Servidor.Desapacho.SQL_Operaciones().getMSJGRAL();
		}
		#endregion
		
		#region CARGA DE FORMULARIOS EN PANEL
		public void getConsEmp()
		{
				consEmpresas="select NOMBRE from ORDEN_EMPRESAS WHERE ";
				
				String diaExtra = fecha_despacho.Substring(0,2);
				String mesExtra = fecha_despacho.Substring(3,2);
				String anioExtra = fecha_despacho.Substring(6,4);
				
				DateTime dateValue = new DateTime(Convert.ToInt16(anioExtra), Convert.ToInt16(mesExtra), Convert.ToInt16(diaExtra));
				
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="lunes")
					consEmpresas=consEmpresas+" LU='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="martes")
					consEmpresas=consEmpresas+" MA='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="miércoles")
					consEmpresas=consEmpresas+" MI='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="jueves")
					consEmpresas=consEmpresas+" JU='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="viernes")
					consEmpresas=consEmpresas+" VI='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="sábado")
					consEmpresas=consEmpresas+" SA='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="domingo")
					consEmpresas=consEmpresas+" DO='1' ";
				
				if(ConsTurno=="Mañana")
					consEmpresas=consEmpresas+" and T1='1' ";
				else if(ConsTurno=="Medio día")
					consEmpresas=consEmpresas+" and T2='1' ";
				else if(ConsTurno=="Vespertino")
					consEmpresas=consEmpresas+" and T3='1' ";
				else if(ConsTurno=="Nocturno")
					consEmpresas=consEmpresas+" and T4='1' ";
				
				consEmpresas=consEmpresas+" ORDER BY NUMERO ";
				
				consEmpresas2="select NOMBRE from ORDEN_EMPRESAS WHERE ";
				
				bool NUCTURNO = false;
				
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="lunes")
					consEmpresas2=consEmpresas2+" LU='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="martes")
					consEmpresas2=consEmpresas2+" MA='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="miércoles")
					consEmpresas2=consEmpresas2+" MI='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="jueves")
					consEmpresas2=consEmpresas2+" JU='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="viernes")
					consEmpresas2=consEmpresas2+" VI='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="sábado")
					consEmpresas2=consEmpresas2+" SA='1' ";
				if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="domingo")
					consEmpresas2=consEmpresas2+" DO='1' ";
				
				if(ConsTurno=="Mañana")
				{
					consEmpresas2="select NOMBRE from ORDEN_EMPRESAS WHERE ";
					consEmpresas2=consEmpresas2+" T4='1' ";
					NUCTURNO = true;
				}
				else if(ConsTurno=="Medio día")
					consEmpresas2=consEmpresas2+" AND T1='1' ";
				else if(ConsTurno=="Vespertino")
					consEmpresas2=consEmpresas2+" AND T2='1' ";
				else if(ConsTurno=="Nocturno")
					consEmpresas2=consEmpresas2+" AND T3='1' ";
				
				if(NUCTURNO==true)
				{
					if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="lunes")
						consEmpresas2=consEmpresas2+" AND DO='1' ";
					if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="martes")
						consEmpresas2=consEmpresas2+" AND LU='1' ";
					if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="miércoles")
						consEmpresas2=consEmpresas2+" AND MA='1' ";
					if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="jueves")
						consEmpresas2=consEmpresas2+" AND MI='1' ";
					if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="viernes")
						consEmpresas2=consEmpresas2+" AND JU='1' ";
					if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="sábado")
						consEmpresas2=consEmpresas2+" AND VI='1' ";
					if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="domingo")
						consEmpresas2=consEmpresas2+" AND SA='1' ";
				}
				
				consEmpresas2=consEmpresas2+" ORDER BY NUMERO ";
		}
		
		public void getSubNombresEmpresas()
		{
			posicion=0;
			while(pPrincEmp.Controls.Count > 0)
			{
            	this.pPrincEmp.Controls.RemoveAt(0);
			}
				
			listNomSubempresas = new Conexion_Servidor.Desapacho.SQL_Operaciones().getSubEmpresas(consEmpresas);
			
			for(int y=0; y<listNomSubempresas.Count ;y++)
			{
				getFormEmpresasDt(listNomSubempresas[y].ToString());
			}
			
			listNomSubempresas = new Conexion_Servidor.Desapacho.SQL_Operaciones().getSubEmpresas(consEmpresas2);
			
			for(int y=0; y<listNomSubempresas.Count ;y++)
			{
				if(listNomSubempresas[y].ToString()!="ESPECIALES")
				{
					getFormEmpresasDtSecundaria(listNomSubempresas[y].ToString());
				}
			}
		}
		
		private void getFormEmpresasDt(String name)
		{
			/*if (pPrincEmp.Controls.Count > 0)
			{
            	this.pPrincEmp.Controls.RemoveAt(0);
			}*/
            getFormEmpresasDtGrid = new Transportes_LAR.Interfaz.Operaciones.FormEmpresasOperaciones(this, fecha_despacho);
            getFormEmpresasDtGrid.nomEmpresa=name;
            getFormEmpresasDtGrid.lblNombreEmp.Text=name;
            getFormEmpresasDtGrid.TopLevel = false;
            
            if(color==0)
            {
            	getFormEmpresasDtGrid.BackColor=Color.PapayaWhip;
            	color=1;
            }
            else
            {
            	getFormEmpresasDtGrid.BackColor=Color.White;
            	color=0;
            }
            
            getFormEmpresasDtGrid.FormBorderStyle = FormBorderStyle.None;
            this.pPrincEmp.Tag = getFormEmpresasDtGrid;
            this.pPrincEmp.Controls.Add(getFormEmpresasDtGrid);
            
            
            getFormEmpresasDtGrid.getIdEmpresa();
            getFormEmpresasDtGrid.getDatosEmpresas(ConsTurno);
            
            if(name!="ESPECIALES")
            	getFormEmpresasDtGrid.apoyoOp_Ruta();
            
            getFormEmpresasDtGrid.dtgEmpresas.AutoSize=true;
           
            getFormEmpresasDtGrid.Size = new System.Drawing.Size(1100,(getFormEmpresasDtGrid.dtgEmpresas.Size.Height+25));
            //getFormEmpresasDtGrid.panel1.AutoSize=true;
            
            getFormEmpresasDtGrid.Location = new System.Drawing.Point(0,posicion);
            getFormEmpresasDtGrid.pMOV = posicion;
            
			getFormEmpresasDtGrid.Show();
			
			alto=getFormEmpresasDtGrid.Size.Height;
			posicion=posicion+alto;
		}
		
		private void getFormEmpresasDtSecundaria(String name)
		{
			Transportes_LAR.Interfaz.Operaciones.FormEmpresasOperaciones getFormEmp = new Transportes_LAR.Interfaz.Operaciones.FormEmpresasOperaciones(this, ((ConsTurno=="Mañana")?diaAnterior(fecha_despacho):fecha_despacho));
            getFormEmp.nomEmpresa=name;
            getFormEmp.lblNombreEmp.Text=name;
            getFormEmp.TopLevel = false;
            
            if(color==0)
            {
            	getFormEmp.BackColor=Color.PapayaWhip;
            	color=1;
            }
            else
            {
            	getFormEmp.BackColor=Color.White;
            	color=0;
            }
            
            getFormEmp.FormBorderStyle = FormBorderStyle.None;
            this.pSecundario.Tag = getFormEmp;
            this.pSecundario.Controls.Add(getFormEmp);
            
            getFormEmp.panelSec=true;
            getFormEmp.getDatosEmpresas(getTurnoSecundario(ConsTurno));
            
            getFormEmp.dtgEmpresas.AutoSize=true;
           
            getFormEmp.Size = new System.Drawing.Size(1100,(getFormEmp.dtgEmpresas.Size.Height+25));
            //getFormEmp.panel1.AutoSize=true;
            
            getFormEmp.Location = new System.Drawing.Point(0,posicion2);
            getFormEmp.pMOV = posicion2;
			
            getFormEmp.cmdAgregar.Visible = false;
            getFormEmp.cmdDelete.Visible = false;
			getFormEmp.Show();
			
			alto=getFormEmp.Size.Height;
			posicion2=posicion2+alto;
		}
		
		public String diaAnterior(String dia)
		{
			String Respuesta="";
			int fecha_actual = Convert.ToInt16(dia.Substring(0,2));
			if(fecha_actual==1)
			{
				Respuesta=dia;
			}
			else
			{
				fecha_actual=fecha_actual-1;
				Respuesta=((fecha_actual<10)?"0"+Convert.ToString(fecha_actual):fecha_actual.ToString())+"/"+dia.Substring(3,7);
			}
			
			return Respuesta;
		}
		#endregion
		
		#region ACOMODO DE FORMULARIOS
		public void mueve(Interfaz.Operaciones.FormEmpresasOperaciones EmpOp, int pos)
		{
			refMOV.Add(EmpOp);
			idMOV.Add(indMOV);
			indMOV++;
			posMOV.Add(pos);
		}
		
		public void secRef(Interfaz.Operaciones.FormEmpresasOperaciones EmpOp2)
		{
			refMSec.Add(EmpOp2);
		}
		
		public void mueve2(Interfaz.Operaciones.FormEmpresasOperaciones EmpOp)
		{
			int cambio=0;
			for(int x=0; x<refMOV.Count; x++)
			{
				if(refMOV[x]==EmpOp)
				{
					for(int y=x+1; y<refMOV.Count; y++)
					{
						if(refMOV[y].Visible==true)
						{
							int poss=refMOV[y].Location.Y;
							refMOV[y].Location = new System.Drawing.Point(0,poss-refMOV[x].Size.Height);
							/*if(cambio==0 && )
							{
								if(refMOV[y-2].BackColor.Name=="White")
								{
									refMOV[y].BackColor=Color.PapayaWhip;
								}
								else
								{
									refMOV[y].BackColor=Color.White;
								}
								cambio=1;
							}
							else
							{*/
								if(refMOV[y-1].BackColor.Name=="White")
								{
									refMOV[y].BackColor=Color.PapayaWhip;
								}
								else
								{
									refMOV[y].BackColor=Color.White;
								}
							//}
							//MessageBox.Show(refMOV[y-1].BackColor.Name.ToString()+" | "+refMOV[y].BackColor.Name.ToString());
						}
					}
				}
			}
		}
		
		public void nuevoTamanio()
		{
			for(int x=0; x<refMOV.Count; x++)
			{
				refMOV[x].dtgEmpresas.AutoSize=true;
			}
			
			for(int x=0; x<refMOV.Count; x++)
			{
				refMOV[x].Size = new System.Drawing.Size(1100,(refMOV[x].dtgEmpresas.Size.Height+25));
			}
		}
		
		public void getEmpresasOrden2()
		{
			posicion=0;
			pPrincEmp.AutoScrollPosition=new System.Drawing.Point(0,0);
			for(int x=0; x<refMOV.Count; x++)
			{
				if(refMOV[x].Visible==true)
				{
					refMOV[x].Location = new System.Drawing.Point(0,posicion);
					refMOV[x].pMOV = posicion;
					//MessageBox.Show(refMOV[x].cantRutas.ToString());
					
					alto=refMOV[x].Size.Height;
					posicion=posicion+alto;
				}
			}
		}
		#endregion
		
		#region GUARDADO DE REFERENCIAS FORMULARIOS
		public void getReferencias(Interfaz.Operaciones.FormEmpresasOperaciones refDatagrids, String name)
		{
			referencias.Add(refDatagrids);
			nomRef.Add(name);
			indRef.Add(contRef);
			contRef++;
		}
		#endregion
		
		#region MOSTRAR FORMULARIO OCULTO
		void TddbEmpresasDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (pPrincEmp.Controls.Count > 0)
			{
            	this.pPrincEmp.Controls.RemoveAt(0);
			}
			
			pPrincEmp.AutoScrollPosition=new System.Drawing.Point(0,0);
			
			for(int x=0; x<referencias.Count; x++)
			{
				int miref=0;
				if(referencias[x]!=null)
				{
					if(referencias[x].nomEmpresa.Equals(e.ClickedItem.ToString()))
					{
						// *************** posicionando ***************
						Interfaz.Operaciones.FormEmpresasOperaciones temporal = new Interfaz.Operaciones.FormEmpresasOperaciones(refMOV[0].refPrincipal,fecha_despacho);
						temporal=refMOV[0];
						refMOV[0]=refMOV[x];
						refMOV[x]=temporal;
						// *******************************************
						
						pPrincEmp.Controls.Add(referencias[x]);
						referencias[x].Location = new System.Drawing.Point(0,0);
						referencias[x].Visible=true;
						referencias[x].BackColor=Color.PapayaWhip;
						//colores=referencias[x].BackColor.Name;
						int poss=referencias[x].Size.Height;
						
						//int vuelta=x;
						
						for(int L=0; L<refMOV.Count; L++)
						{
							if(refMOV[L]!=referencias[x])
							{
								if(refMOV[L].Visible==true)
								{
									pPrincEmp.Controls.Add(refMOV[L]);
									refMOV[L].Location = new System.Drawing.Point(0,poss);
									poss=poss+refMOV[L].Size.Height;
									
									if(refMOV[miref].BackColor.Name=="White")
						            {
										refMOV[L].BackColor=Color.PapayaWhip;
						            }
						            else
						            {
						            	refMOV[L].BackColor=Color.White;
						            }
						            miref=L;
								}
							}
						}
						referencias[x]=null;
					}	
				}	
			}	
		}
		#endregion
		
		#region ACOMODOS TEMPORALES
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			/*if(cmbVisual.Text=="Orden alfabetico")
			{
				ordenAlfabetico(sentido);
				if(sentido==0)
				{
					sentido=1;
				}
				else
				{
					sentido=0;
				}
			}
			else
			{
				if(cmbVisual.Text=="Mayor Cantidad")
				{
					ordenCantidad(sentido2);
					if(sentido2==0)
					{
						sentido2=1;
					}
					else
					{
						sentido2=0;
					}
				}
				else 
				{
					if(cmbVisual.Text=="Urgente")
					{
						ordenUrgente(sentido3);
						if(sentido3==0)
						{
							sentido3=1;
						}
						else
						{
							sentido3=0;
						}
					}
				}
			}*/
		}
		
		public void ordenAlfabetico(int sent)
		{
			// ************** ORDEN *****************
			if(sentido==0)
			{
				for(int y=0; y<refMOV.Count; y++)
				{
					for(int x=0; x<refMOV.Count-1; x++)
					{
						//MessageBox.Show(string.CompareOrdinal(Emp[x],Emp[x+1]).ToString());
						if(string.CompareOrdinal(refMOV[x].lblNombreEmp.Text,refMOV[x+1].lblNombreEmp.Text)<0)
						{
							Interfaz.Operaciones.FormEmpresasOperaciones temporal=refMOV[x];
							refMOV[x]=(refMOV[x+1]);
							refMOV[x+1]=temporal;
						}
					}
				}
				posicion=0;
				getEmpresasOrden();
			}
			else
			{
				for(int y=0; y<refMOV.Count; y++)
				{
					for(int x=0; x<refMOV.Count-1; x++)
					{
						//MessageBox.Show(string.CompareOrdinal(Emp[x],Emp[x+1]).ToString());
						if(string.CompareOrdinal(refMOV[x].lblNombreEmp.Text,refMOV[x+1].lblNombreEmp.Text)>0)
						{
							Interfaz.Operaciones.FormEmpresasOperaciones temporal=refMOV[x];
							refMOV[x]=(refMOV[x+1]);
							refMOV[x+1]=temporal;
						}
					}
				}
				posicion=0;
				getEmpresasOrden();
			}
			// **************************************
		}
		
		public void ordenCantidad(int sent)
		{
			// ************** ORDEN POR CANTIDAD *****************
			if(sent==0)
			{
				for(int y=0; y<refMOV.Count; y++)
				{
					for(int x=0; x<refMOV.Count-1; x++)
					{
						//MessageBox.Show(string.CompareOrdinal(Emp[x],Emp[x+1]).ToString());
						if(refMOV[x].cantRutas>refMOV[x+1].cantRutas)
						{
							Interfaz.Operaciones.FormEmpresasOperaciones temporal=refMOV[x];
							refMOV[x]=(refMOV[x+1]);
							refMOV[x+1]=temporal;
						}
					}
				}
				posicion=0;
				getEmpresasOrden();
			}
			else
			{
				for(int y=0; y<refMOV.Count; y++)
				{
					for(int x=0; x<refMOV.Count-1; x++)
					{
						//MessageBox.Show(string.CompareOrdinal(Emp[x],Emp[x+1]).ToString());
						if(refMOV[x].cantRutas<refMOV[x+1].cantRutas)
						{
							Interfaz.Operaciones.FormEmpresasOperaciones temporal=refMOV[x];
							refMOV[x]=(refMOV[x+1]);
							refMOV[x+1]=temporal;
						}
					}
				}
				posicion=0;
				getEmpresasOrden();
			}
			// **************************************
		}
		
		public void ordenUrgente(int sent)
		{
			try
			{
				for(int x=0; x<refMOV.Count; x++)
				{
					if(refMOV[x].dtgEmpresas[4,0].Value.Equals(""))
					{
						//MessageBox.Show(refMOV[x].dtgEmpresas[11,0].Value.ToString());
						//MessageBox.Show(refMOV[x].dtgEmpresas[11,0].Value.ToString().Substring(0,2)+refMOV[x].dtgEmpresas[11,0].Value.ToString().Substring(3,2));
						refMOV[x].hora=Convert.ToInt16(refMOV[x].dtgEmpresas[11,0].Value.ToString().Substring(0,2)+refMOV[x].dtgEmpresas[11,0].Value.ToString().Substring(3,2));
					}
					else
					{
						//MessageBox.Show(refMOV[x].dtgEmpresas[4,0].Value.ToString().Substring(0,2)+refMOV[x].dtgEmpresas[4,0].Value.ToString().Substring(3,2));
						refMOV[x].hora=Convert.ToInt16(refMOV[x].dtgEmpresas[4,0].Value.ToString().Substring(0,2)+refMOV[x].dtgEmpresas[4,0].Value.ToString().Substring(3,2));
					}
				}
				
				if(sent==0)
				{
					for(int y=0; y<refMOV.Count; y++)
					{
						for(int x=0; x<refMOV.Count-1; x++)
						{
							//MessageBox.Show(string.CompareOrdinal(Emp[x],Emp[x+1]).ToString());
							if(refMOV[x].hora>refMOV[x+1].hora)
							{
								Interfaz.Operaciones.FormEmpresasOperaciones temporal=refMOV[x];
								refMOV[x]=(refMOV[x+1]);
								refMOV[x+1]=temporal;
							}
						}
					}
					posicion=0;
					getEmpresasOrden();
				}
				else
				{
					for(int y=0; y<refMOV.Count; y++)
					{
						for(int x=0; x<refMOV.Count-1; x++)
						{
							//MessageBox.Show(string.CompareOrdinal(Emp[x],Emp[x+1]).ToString());
							if(refMOV[x].hora<refMOV[x+1].hora)
							{
								Interfaz.Operaciones.FormEmpresasOperaciones temporal=refMOV[x];
								refMOV[x]=(refMOV[x+1]);
								refMOV[x+1]=temporal;
							}
						}
					}
					posicion=0;
					getEmpresasOrden();
				}
			}
			catch(Exception)
			{
				
			}
		}
		#endregion
		
		#region METODOS OCULTAR Y MOSTRAR FORMULARIOS
		public void getEmpresasOrden()
		{	
			int miref=0;
			pPrincEmp.AutoScrollPosition=new System.Drawing.Point(0,0);
			for(int x=0; x<refMOV.Count; x++)
			{
				if(refMOV[x].Visible==true)
				{
					refMOV[x].Location = new System.Drawing.Point(0,posicion);
					refMOV[x].pMOV = posicion;
					//MessageBox.Show(refMOV[x].cantRutas.ToString());
					
					alto=refMOV[x].Size.Height;
					posicion=posicion+alto;
					
					if(refMOV[miref].BackColor.Name=="White")
		            {
						refMOV[x].BackColor=Color.PapayaWhip;
		            }
		            else
		            {
		            	refMOV[x].BackColor=Color.White;
		            }
		            miref=x;
				}
			}
		}
		#endregion
		
		#region EVENTO CLOSING
		void FormPrin_EmpresasFormClosing(object sender, FormClosingEventArgs e)
		{
			//MessageBox.Show(e.CloseReason.ToString());
		    // Estos son los valores posibles
		    principal.operador=false;
			principal.prinEmpresas=false;
			respaldo();
		    
			//MessageBox.Show("PrinEmpresas "+e.CloseReason.ToString());
			
		    switch(e.CloseReason)
		    {
		        case CloseReason.ApplicationExitCall:
		    		revisionTerminado();
		    		for(int x=0; x<refMOV.Count; x++)
					{
						if(refMOV[x].lblNombreEmp.Text=="ESPECIALES")
						{
							refMOV[x].forDatosEsp.Close();
						}
					}
		    		// +++++++++++++++++++++++++++
		    		//principal.actualizacionOperadores();
		        	break;
		        case CloseReason.UserClosing:
		        			confirmaDormidas();
		            		if(revisionTerminado()==true)
							{
								for(int x=0; x<refMOV.Count; x++)
								{
									if(refMOV[x].lblNombreEmp.Text=="ESPECIALES")
									{
										refMOV[x].forDatosEsp.Close();
									}
								}
								
								if(txtMSJ.Text!="")
									new Conexion_Servidor.Desapacho.SQL_Operaciones().msjGral2("update MENSAJE_GRAL set ID_U="+principal.idUsuario+", MENSAJE='"+txtMSJ.Text+"', DIA='"+fecha_Base_Datos+"', HORA=(SELECT CONVERT (time, SYSDATETIME())), TURNO='"+ConsTurno+"'");
								
								principal.operador=false;
								principal.prinEmpresas=false;
								principal.formListaOperador.Close();
								//**********************************************
								//principal.actualizacionOperadores();
							}
							else
							{
								DialogResult result=MessageBox.Show("Existen Rutas sin asignar. ¿Desea continuar con el cerrado?","Cerrando operaciones",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
								if(DialogResult.Cancel==result)
								{
									e.Cancel=true;
									for(int x=0; x<refMOV.Count; x++)
									{
										refMOV[x].cancelarCerrado();
									}
								}
								else
								{
									for(int x=0; x<refMOV.Count; x++)
									{
										if(refMOV[x].lblNombreEmp.Text=="ESPECIALES")
										{
											refMOV[x].forDatosEsp.Close();
										}
									}
									
									if(txtMSJ.Text!="")
										new Conexion_Servidor.Desapacho.SQL_Operaciones().msjGral2("update MENSAJE_GRAL set ID_U="+principal.idUsuario+", MENSAJE='"+txtMSJ.Text+"', DIA='"+fecha_Base_Datos+"', HORA=(SELECT CONVERT (time, SYSDATETIME())), TURNO='"+ConsTurno+"'");
									
									principal.operador=false;
									principal.prinEmpresas=false;
									principal.formListaOperador.Close();
									// ++++++++++++++++++++++++++++++++++++++
									//principal.actualizacionOperadores();
								}
							}
		            break;
		        case CloseReason.MdiFormClosing:
		            principal.operador=true;
			  		principal.prinEmpresas=true;
		            e.Cancel=true;
		            break;
		    }
		}
		
		void respaldo()
		{
			if(ConsTurno=="Nocturno" && DateTime.Now.ToString("dddd", new CultureInfo("es-ES"))=="sábado" && (DateTime.Now<Convert.ToDateTime("20:30") && DateTime.Now<Convert.ToDateTime("23:50")))
			{
				/*MessageBox.Show(DateTime.Now+"<"+Convert.ToDateTime("20:30") +" && "+ DateTime.Now+"<"+Convert.ToDateTime("23:50"));
				MessageBox.Show("Entra");*/
				Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
				
				//string DATO = @"'C:\Users\LarEquipo\Dropbox\transportes_LAR'+@fecha+'.bak'";
				string DATO = @"'C:\Users\"+ System.Windows.Forms.SystemInformation.UserName +@"\Dropbox\transportes_LAR'+@fecha+'.bak'";
				
				String consul = "USE transportes_LAR; " +
					"GO " +
					"declare @fecha varchar(MAX) " +
					"declare @archivo varchar(MAX) " +
					"set @fecha = CONVERT(Varchar(max), GETDATE(),102)+'_'+SUBSTRING(CONVERT(varchar(10), getdate(),108),1,2)+SUBSTRING(CONVERT(varchar(10), getdate(),108),4,2)+'horas' " +
					"set @archivo = "+ DATO +
					"BACKUP DATABASE transportes_LAR " +
					"TO DISK = @archivo "+
					"	WITH FORMAT, " +
					"	MEDIANAME = 'D_SQLServerBackups', " +
					"	NAME = 'Full Backup of transportes_LAR'; " +
					"GO";
				conn.getAbrirConexion(consul); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
			}
			
			if(ConsTurno=="Nocturno" && (DateTime.Now>Convert.ToDateTime("20:00") && DateTime.Now<Convert.ToDateTime("23:59"))){
				DialogResult res = MessageBox.Show(""+principal.nombreUsuario+", vas a cerrar el despacho, ¿Quieres generar el folio de la ultima autorizacion de combustible?", "Folio Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if(DialogResult.Yes == res){
					String  folio = "", consulta = " select top(1) * from AUTORIZACION where FECHA_REG = '"+DateTime.Now.ToString("dd/MM/yyyy")+"' order by numero desc";
					try{
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())					
							folio  =  getUltimoFolio( (Convert.ToInt64(conn.leer["Numero"]) + 1), Convert.ToDateTime(conn.leer["FECHA_REG"]));
						conn.conexion.Close();
						MessageBox.Show("El último folio de autorización fue guardado en el portapapeles, favor de pegarlo en el mensaje correspondiente de Whatsapp. El Folio Fue: "+folio, "Folio Autorizado", MessageBoxButtons.OK);
						String datos = "SIGUIENTE AUTORIZACIÓN DE COMBUSTIBLE: "+folio;
						Clipboard.Clear();
					 	Clipboard.SetDataObject(datos);
					}catch(Exception){						
					}finally{
						if(conn.conexion != null)
						   conn.conexion.Close();
					}
				}
			}
		}
		
		public String getUltimoFolio(Int64 numero, DateTime fecha)
		{
			String dato="";			
			String numReg = "";
						
			// +++++++++++++++++++ registro ++++++++++++++++++++++++
			if(numero==0)
				numReg="01";
			else if(numero.ToString().Length==1)
				numReg="0"+numero;
			else
				numReg=numero.ToString();

			// ++++++++++++++++++++++++++++++++++++++++++++++++++++			
			if(fecha.ToString("MMM")=="may")
				dato=fecha.ToString("yyyy").Substring(3,1)+"Y"+fecha.ToString("dd")+numReg;
			else if(fecha.ToString("MMM")=="jul")
				dato=fecha.ToString("yyyy").Substring(3,1)+"L"+fecha.ToString("dd")+numReg;
			else if(fecha.ToString("MMM")=="ago")
				dato=fecha.ToString("yyyy").Substring(3,1)+"G"+fecha.ToString("dd")+numReg;
			else
				dato=fecha.ToString("yyyy").Substring(3,1)+fecha.ToString("MMMMM").Substring(0,1).ToUpper()+fecha.ToString("dd")+numReg;					
			return dato;
		}

		public void cerrado()
		{
			for(int x=0; x<refMOV.Count; x++)
			{
				if(refMOV[x].lblNombreEmp.Text=="ESPECIALES")
				{
					refMOV[x].forDatosEsp.Close();
				}
			}
			
			if(txtMSJ.Text!="")
				new Conexion_Servidor.Desapacho.SQL_Operaciones().msjGral2("update MENSAJE_GRAL set ID_U="+principal.idUsuario+", MENSAJE='"+txtMSJ.Text+"', DIA='"+fecha_Base_Datos+"', HORA=(SELECT CONVERT (time, SYSDATETIME())), TURNO='"+ConsTurno+"'");
			
			
			principal.formListaOperador.Close();
		}
	
		void confirmaDormidas()
		{
			if(new Conexion_Servidor.Desapacho.SQL_Operaciones().getDormidas(fecha_Base_Datos, ConsTurno))
			{
				//new Interfaz.Asignacion.FormValidacionCardex(this).ShowDialog();
			}
		}
		#endregion
		
		#region METEDO REVISION DE RUTAS SIN ASIGNAR
		public bool revisionTerminado()
		{
			bool respuesta=true;
			for(int x=0; x<refMOV.Count; x++)
			{
				if(refMOV[x].Visible==true)
				{
					if(refMOV[x].revisionTerminado()==false)
						respuesta=false;
				}
				else
				{
					for(int y=0; y<referencias.Count; y++)
					{
						if(refMOV[x]==referencias[y])
						{
							if(refMOV[x].revisionTerminado()==false)
								respuesta=false;
						}
					}
				}
			}
			
			for(int x=0; x<refMSec.Count; x++)
			{
				try
				{
					refMSec[x].revisionTerminado();
				}
				catch (Exception)
				{
					
				}
			}
			return respuesta;
		}
		#endregion
		
		#region COMETARIOS nuevos mensajes por ende se elimino
		/*void LblMensajeClick(object sender, EventArgs e)
		{
			lblMensaje.BackColor=Color.PapayaWhip;
			if(formcom.Visible==true)
				formcom.Visible=false;
			else
				formcom.Visible=true;
		}*/
		
		#region TIMER COMENTARIO
		void TcomentariosTick(object sender, EventArgs e)
		{
			//Thread.Sleep(500);
			//this.lblMensaje.ForeColor= Color.Black;
		}
		
		void Tcomentarios2Tick(object sender, EventArgs e)
		{
			//Thread.Sleep(500);
			//this.lblMensaje.ForeColor= Color.Red;
			
		}
		#endregion
		#endregion 
		
		#region AUTO COMPLETE ALIAS OPERADOR
		void TxtBusqOperKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				principal.seleccionOperador(txtBusqOper.Text);
			}
		}
		#endregion
		
		#region BOTON ORDEN
		void CmdOrdenClick(object sender, EventArgs e)
		{
			new FormOrdenEmpresas(this, this.ConsTurno).ShowDialog();
		}
		#endregion
		
		#region LLENADO TABLA BUSQUEDA EMPRESA
		private List<Interfaz.Operaciones.Dato.OrdenEmpresas> listaEmpOrden = null;
		
		public void getEmpresas()
		{
			dgBusqueda.Rows.Clear();
			
			consEmpresas="select ID, NOMBRE, NUMERO, NOMENCLATURA from ORDEN_EMPRESAS WHERE ";
			
			String diaExtra = fecha_despacho.Substring(0,2);
			String mesExtra = fecha_despacho.Substring(3,2);
			String anioExtra = fecha_despacho.Substring(6,4);
			
			DateTime dateValue = new DateTime(Convert.ToInt16(anioExtra), Convert.ToInt16(mesExtra), Convert.ToInt16(diaExtra));
			
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="lunes")
				consEmpresas=consEmpresas+" LU='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="martes")
				consEmpresas=consEmpresas+" MA='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="miércoles")
				consEmpresas=consEmpresas+" MI='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="jueves")
				consEmpresas=consEmpresas+" JU='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="viernes")
				consEmpresas=consEmpresas+" VI='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="sábado")
				consEmpresas=consEmpresas+" SA='1' ";
			if(dateValue.ToString("dddd", new CultureInfo("es-ES"))=="domingo")
				consEmpresas=consEmpresas+" DO='1' ";
			
			if(ConsTurno=="Mañana")
				consEmpresas=consEmpresas+" and T1='1' ";
			else if(ConsTurno=="Medio Día")
				consEmpresas=consEmpresas+" and T2='1' ";
			else if(ConsTurno=="Vespertino")
				consEmpresas=consEmpresas+" and T3='1' ";
			else if(ConsTurno=="Nocturno")
				consEmpresas=consEmpresas+" and T4='1' ";
			
			consEmpresas=consEmpresas+" ORDER BY NUMERO ";
			
			listaEmpOrden = new Conexion_Servidor.Desapacho.SQL_Operaciones().getEmpOrden(consEmpresas);
			
			if(listaEmpOrden!=null)
			{
				for(int x=0; x<listaEmpOrden.Count; x++)
				{
					dgBusqueda.Rows.Add(listaEmpOrden[x].nomenc , listaEmpOrden[x].nombre);
				}
			}
			dgBusqueda.ClearSelection();
		}
		
		void DgBusquedaCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				for(int x=0; x<refMOV.Count; x++)
				{
					if(dgBusqueda[1,e.RowIndex].Value.ToString().ToUpper()==refMOV[x].nomEmpresa.ToUpper())
					{
						refMOV[x].Select();
					}
				}
			}
		}
		#endregion
		
		#region LIMPIANDO SELECCION
		public void limpiarSelect(Interfaz.Operaciones.FormEmpresasOperaciones formEmp)
		{
			for(int x=0; x<refMOV.Count; x++)
			{
				if(refMOV[x]!=formEmp)
				{
					refMOV[x].dtgEmpresas.ClearSelection();
				}
			}
		}
		#endregion
		
		#region PRUEBA DE RENDIMIENTO
		void CmdPruebaRendClick(object sender, EventArgs e)
		{
			new FormPruebaRendimiento(this).ShowDialog();
		}

		public void obtRutas(string operador)
		{
			for(int x=0; x<refMOV.Count; x++)
			{
				for(int y=0; y<refMOV[x].dtgEmpresas.Rows.Count; y++)
				{
					if(refMOV[x].dtgEmpresas[3,y].Value.ToString()==operador && refMOV[x].dtgEmpresas[3,y].Style.BackColor.Name=="MediumSpringGreen")
					{
						rutasOperador.Add(refMOV[x].dtgEmpresas[6,y].Value.ToString());
						IDrutasOperador.Add(refMOV[x].dtgEmpresas[2,y].Value.ToString());	
					}
					else if(refMOV[x].dtgEmpresas[11,y].Value.ToString()==operador && refMOV[x].dtgEmpresas[10,y].Style.BackColor.Name=="MediumSpringGreen")
					{
						rutasOperador.Add(refMOV[x].dtgEmpresas[14,y].Value.ToString());
						IDrutasOperador.Add(refMOV[x].dtgEmpresas[10,y].Value.ToString());	
					}
				}
			}
		}
		#endregion
		
		void TxtBusqOperMouseClick(object sender, MouseEventArgs e)
		{
			txtBusqOper.SelectAll();
		}
		
		void CmdImprimirClick(object sender, EventArgs e)
		{
			principal.imprimirDespacho();
		}
		
		#region ELIMINAR PRUEBAS DE REND Y RECONOCIMIENTOS DE RUTAS
		void CmdEliminarRecClick(object sender, EventArgs e)
		{
			try
			{
				if(dgReconocimientos.CurrentRow.Index!=-1)
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().eliminarPrubaRec("delete from RECONOCIMIENTO_RUTA where ID="+dgReconocimientos[0,dgReconocimientos.CurrentRow.Index].Value.ToString());
					recRutas();
				}
			}
			catch(Exception)
			{
				
			}
		}
		
		void CmdEliminarPruebClick(object sender, EventArgs e)
		{
			try
			{
				if(dgPruebasRend.CurrentRow.Index!=-1)
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().eliminarPrubaRec("delete from PRUEBA_RENDIMIENTO where ID_PR="+dgPruebasRend[0,dgPruebasRend.CurrentRow.Index].Value.ToString());
					recPruebasRend();
				}
			}
			catch(Exception)
			{
				
			}
		}
		
		void CmdEliminaApoyoClick(object sender, EventArgs e)
		{
			try
			{
				if(dgApoyos.CurrentRow.Index!=-1)
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().eliminarApoyo("delete from APOYOS where ID="+dgApoyos[0,dgApoyos.CurrentRow.Index].Value.ToString());
					datosApoyos();
				}
			}
			catch(Exception)
			{
				
			}
		}
		#endregion
		
		void CmdRepEmpresaClick(object sender, EventArgs e)
		{
			new Interfaz.Cliente.FormHistorialEmpresa(this, 0).ShowDialog();
		}
		
		void LblAbrirClick(object sender, EventArgs e)
		{
			if(listaEmp==true)
			{
				pListaEmp.Size = new System.Drawing.Size(10,852);
				listaEmp = false;
				cmdOrden.Visible=false;
				dgBusqueda.Visible=false;
				lblAbrir.Text=">";
			}
			else
			{
				pListaEmp.Size = new System.Drawing.Size(113,852);
				listaEmp = true;
				cmdOrden.Visible=true;
				dgBusqueda.Visible=true;
				lblAbrir.Text="<";
			}
		}
		
		// ******** new operadores ********
		
		public void contandoViajes(int incremento, String alias, String emp)
		{
			for(int x=0; x<prinOperadores.dgOperadores.Rows.Count; x++)
			{
				if(prinOperadores.dgOperadores[2,x].Value.ToString().Equals(alias))
				{
					//dgOperadores[2,x].Value();
				}
			}
		}
		// ********************************
		
		void CmdCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		#region EVENTO MUESTRA LISTA EMPRESAS
		void PListaEmpMouseEnter(object sender, EventArgs e)
		{
			pListaEmp.Size = new System.Drawing.Size(113,852);
			listaEmp = true;
			cmdOrden.Visible=true;
			dgBusqueda.Visible=true;
			lblAbrir.Text="<";
		}
		
		void DgBusquedaMouseEnter(object sender, EventArgs e)
		{
			pListaEmp.Size = new System.Drawing.Size(113,852);
			listaEmp = true;
			cmdOrden.Visible=true;
			dgBusqueda.Visible=true;
			lblAbrir.Text="<";
		}
		
		void DgBusquedaMouseLeave(object sender, EventArgs e)
		{
			pListaEmp.Size = new System.Drawing.Size(10,852);
			listaEmp = false;
			cmdOrden.Visible=false;
			dgBusqueda.Visible=false;
			lblAbrir.Text=">";
		}
		#endregion
		
		void FormPrin_EmpresasFormClosed(object sender, FormClosedEventArgs e)
		{
			//principal.actualizacionOperadores();
		}
		
		#region LISTA DE SUELDOS
		void CmdSueldosClick(object sender, EventArgs e)
		{
			new FormListaSueldos().Show();
		}
		#endregion
		
		void CmdRepCoordClick(object sender, EventArgs e)
		{
			new Interfaz.Reportes.FormCardexCoordinador(this).ShowDialog();
			//new Interfaz.Caja.FormHilo().Show();
		}
		
		void CmdAutorizacionClick(object sender, EventArgs e)
		{
			Transportes_LAR.Interfaz.Combustible.FormCombOperaciones formComOperaciones  = new Transportes_LAR.Interfaz.Combustible.FormCombOperaciones(principal);
			formComOperaciones.WindowState = FormWindowState.Normal;
			formComOperaciones.BringToFront();
			formComOperaciones.Show();
		}
		
		 
		///////////////////////////////////////////////////////////////   UBER - TAXI   ///////////////////////////////////////////////////////////////
		double parametro = 0;
		
		void BtnUberTaXiClick(object sender, EventArgs e)
		{
			timer1.Stop();
			new Interfaz.Controles.Uber_Taxi.FormUber_Taxi(this, principal.idUsuario.ToString(), ConsTurno, fecha_despacho).ShowDialog();
		}		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			try{
				string consulta = @"SELECT COUNT(*) NUMERO FROM UBER_TAXI WHERE TIPO = 'RUTA' AND  ESTADO = 'PROGRAMADA' AND ESTATUS = 'Activo' AND FECHA_PLANEACION = '"+fecha_despacho+"' AND TURNO = '"+ConsTurno+"' AND  HORA_INICIO < '"+DateTime.Now.AddMinutes(-(parametro)).ToString("HH:mm")+"'";
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(!(string.IsNullOrEmpty(conn.leer["NUMERO"].ToString()))){
						if(Convert.ToInt32(conn.leer["NUMERO"]) > 0){
		     				btnUberTaXi.BackColor = Color.Red;
							btnUberTaXi.Size = new Size(69, 59);
							btnUberTaXi.Location = new Point(290, 4);
						}
					}							 						
				}
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error en aviso: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				timer1.Stop();
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}
		}
		
		public void UberTaxiPendientes(){
			btnUberTaXi.BackColor = Color.Transparent;
			btnUberTaXi.Size = new Size(49, 39);
			btnUberTaXi.Location = new Point(308, 4);
			
			bool respuesta = true;
			string consul = @"SELECT COUNT(*) NUMERO FROM UBER_TAXI WHERE TIPO ='RUTA' AND ESTADO = 'PROGRAMADA' AND ESTATUS = 'Activo' AND FECHA_PLANEACION = '"+fecha_despacho+"' AND TURNO = '"+ConsTurno+"'";
			try{
				conn.getAbrirConexion(consul);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					if(Convert.ToInt32(conn.leer["NUMERO"]) > 0)
						respuesta = true;
					else
						respuesta = false;					
				}				
				conn.conexion.Close();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener aviso de uber - taxi programados: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	      		respuesta = false;	
			}
			if(respuesta)
				timer1.Start();
			else
				timer1.Stop();
		}
		
		public void obtenerParametroTiempo() {
			try{
				conn.getAbrirConexion("select PARAMETRO6 from PARAMETROS_GENERALES where ID = 4");
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read())
					parametro = Convert.ToDouble(conn.leer["PARAMETRO6"]);
				conn.conexion.Close();
			}catch(Exception){
				parametro = 0.0;
			}finally{
				if(conn.conexion != null)
					conn.conexion.Close();
			}	
		}
	}
}

