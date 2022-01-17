using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormPrincEspeciales : Form
	{
		public FormPrincEspeciales(FormEmpresasOperaciones refEmpresa)
		{
			InitializeComponent();
			
			refEmpresaOper=refEmpresa;
		}
		
		#region REFERENCIAS
		public FormEmpresasOperaciones refEmpresaOper = null;
		public FormOperadorEsp formVista = null;
		public FormDatosEspecial formDatos = null;
		public FormOperadorEsp formSelec = null;
		#endregion
		
		#region VARIBLES
		//Thread hilo1;
		
		public List<String> listaEspeciales = null;
		public List<FormOperadorEsp> listaFormEspeciales = null;
		public List<FormDatosEspecial> listaFormDatos = new List<FormDatosEspecial>();
		
		public int posicion=0; 
		public int posicion2=0;
		public int ident=0;
		public int act=0;
		public int CantVistaR=0;
		
		public bool vista=false;
		#endregion
		
		void FormPrincEspecialesLoad(object sender, EventArgs e)
		{
			dtpInicio.Value=Convert.ToDateTime(refEmpresaOper.refPrincipal.fecha_despacho);
			dtpFin.Value=Convert.ToDateTime(refEmpresaOper.refPrincipal.fecha_despacho);
			
			getNombreViajes();
			
			//hilo1 = new Thread(new ThreadStart(procesoHilo1));
			//hilo1.Start();
		}
		
		#region PROCESO HILO
		void BtnRefrescaClick(object sender, EventArgs e)
		{
			getNombreViajes();
		}
		
		public void procesoHilo1()
		{
            while (true)
            {
                Invoke(new Action(() => getNombreViajes()));
                Thread.Sleep(300000);
            }
       	}
		#endregion
		
		#region	GET FORMULARIOS VISTA RAPIDA
		public void getNombreViajes()
		{
			posicion=0;
			posicion2=0;
			while (pVistaRapida.Controls.Count > 0)
			{
            	this.pVistaRapida.Controls.RemoveAt(0);
			}
			
			while (pDatos.Controls.Count > 0)
			{
            	this.pDatos.Controls.RemoveAt(0);
			}
			
			//listaEspeciales = new Conexion_Servidor.Desapacho.SQL_Operaciones().idEspeciales("select ID_RE dato from RUTA_ESPECIAL where FECHA_SALIDA BETWEEN '"+dtpInicio.Value.ToString().Substring(0,10)+"' AND '"+dtpFin.Value.ToString().Substring(0,10)+"' and id_c in (select IdSubEmpresa from RUTA) order by H_PLANTON");
			listaEspeciales = new Conexion_Servidor.Desapacho.SQL_Operaciones().idEspeciales("select ID_RE dato from RUTA_ESPECIAL where FECHA_SALIDA BETWEEN '"+dtpInicio.Value.ToString().Substring(0,10)+"' AND '"+dtpFin.Value.ToString().Substring(0,10)+"' and estado='Activo' and id_c in (select IdSubEmpresa from RUTA) AND ID_C IN (SELECT ID_C FROM ContactoServicio) order by FECHA_SALIDA, H_PLANTON");
			
			listaFormEspeciales = new List<FormOperadorEsp>();
			
			if(listaEspeciales!=null)
			{
				for(int y=0; y<listaEspeciales.Count ;y++)
				{
					getFormVR(listaEspeciales[y].ToString());
					getFormDatosEsp(listaEspeciales[y].ToString());
				}
			}
			act=1;
			conteoCantidades();
		}
		
		public void getFormVR(String id_Especial)
		{
			formVista = new Transportes_LAR.Interfaz.Operaciones.FormOperadorEsp(this, Convert.ToInt16(id_Especial));
			formVista.TopLevel = false;
			
			this.pVistaRapida.Tag = formVista;
            this.pVistaRapida.Controls.Add(formVista);
            
            formVista.Location = new System.Drawing.Point(0,posicion);
            
			try
            {
				formVista.Show();
            }
            catch(Exception ex)
            {
            	MessageBox.Show(ex.Message);
            }
			
			int alto=formVista.Size.Height;
			posicion=posicion+alto;
			
			listaFormEspeciales.Add(formVista);
		}
		
		public void getFormDatosEsp(String id_Especial)
		{
			formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(this, Convert.ToInt16(id_Especial));
			formDatos.TopLevel = false;
			
			this.pDatos.Tag = formDatos;
            this.pDatos.Controls.Add(formDatos);
            
            formDatos.Location = new System.Drawing.Point(0,posicion2);
            try
            {
				formDatos.Show();
            }
            catch(Exception ex)
            {
            	MessageBox.Show(ex.Message);
            }
			
			int alto=formDatos.Size.Height;
			posicion2=posicion2+alto;
			
			listaFormDatos.Add(formDatos);
		}
		#endregion
		
		#region EVENTO PARA MOVER FORMULARIOS DE VISTA RAPIDA
		public void mueveFormVR(FormOperadorEsp refForm)
		{
			int cambio=0;
			int pos=0;
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				if(cambio==1)
				{
					listaFormEspeciales[x].Location = new System.Drawing.Point(0,pos);
					pos=pos+listaFormEspeciales[x].Size.Height;
				}
				
				if(listaFormEspeciales[x]==refForm)
				{
					cambio=1;
					pos=listaFormEspeciales[x].Location.Y+listaFormEspeciales[x].Size.Height;
				}
			}
		}
		#endregion
		
		#region SELECCION
		public void seleccionDatos(FormOperadorEsp refForm)
		{
			for(int x=0; x<listaFormDatos.Count; x++)
			{
				if(listaFormDatos[x].RUTA==refForm.id_Viaje)
				{
					while (pDatos.Controls.Count > 0)
					{
		            	this.pDatos.Controls.RemoveAt(0);
					}
					
					listaFormDatos[x].Location = new System.Drawing.Point(0,0);
					this.pDatos.Tag = listaFormDatos[x];
		            this.pDatos.Controls.Add(listaFormDatos[x]);
		            
		            if(formSelec!=null)
		            {
		            	formSelec.cmdSeleccionar.Text=">";
						formSelec.BackColor=Color.Tan;
		            }
		            formSelec=refForm;
				}
			}
		}
		
		public void desSeleccion()
		{
			posicion2=0;
			while (pDatos.Controls.Count > 0)
			{
            	this.pDatos.Controls.RemoveAt(0);
			}
			
			for(int x=0; x<listaFormDatos.Count; x++)
			{
				this.pDatos.Tag = listaFormDatos[x];
	            this.pDatos.Controls.Add(listaFormDatos[x]);
	            
	            listaFormDatos[x].Location = new System.Drawing.Point(0,posicion2);
	            
	            int alto=listaFormDatos[x].Size.Height;
				posicion2=posicion2+alto;
			}
			formSelec=null;
		}
		#endregion
		
		#region EVENTOS DATE TIME PICKER
		void DtpInicioValueChanged(object sender, EventArgs e)
		{
			if(act==1)
				getNombreViajes();
		}
		
		void DtpFinValueChanged(object sender, EventArgs e)
		{
			if(act==1)
				getNombreViajes();
		}
		#endregion
		
		#region ASIGNA OPERADOR
		public void asignaOperador(Int64 id_Ruta, bool limpiar)
		{
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				for(int y=0; y<listaFormEspeciales[x].dtDatos.Rows.Count; y++)
				{
					if(Convert.ToInt64(listaFormEspeciales[x].dtDatos[4,y].Value)==id_Ruta)
					{
						listaFormEspeciales[x].dtDatos[1,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.numeroVehiculo.ToString();
						listaFormEspeciales[x].dtDatos[2,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.txtAlias.Text.ToString();
						listaFormEspeciales[x].dtDatos[6,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
						listaFormEspeciales[x].dtDatos[7,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
						listaFormEspeciales[x].dtDatos[8,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
						
						if(limpiar==true)
						{
							listaFormEspeciales[x].dtDatos[0,y].Style.BackColor=Color.Silver;
							listaFormEspeciales[x].dtDatos[1,y].Style.BackColor=Color.White;
							listaFormEspeciales[x].dtDatos[2,y].Style.BackColor=Color.White;
						}
					}
					else if(Convert.ToInt64(listaFormEspeciales[x].dtDatos[9,y].Value)==id_Ruta)
					{
						listaFormEspeciales[x].dtDatos[15,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.numeroVehiculo.ToString();
						listaFormEspeciales[x].dtDatos[16,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.txtAlias.Text.ToString();
						listaFormEspeciales[x].dtDatos[11,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_OPERADOR.ToString();
						listaFormEspeciales[x].dtDatos[12,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.ID_VEHICULO.ToString();
						listaFormEspeciales[x].dtDatos[13,y].Value=refEmpresaOper.refPrincipal.principal.datosOpAsi.tipoVehiculo.ToString();
						
						if(limpiar==true)
						{
							listaFormEspeciales[x].dtDatos[14,y].Style.BackColor=Color.Silver;
							listaFormEspeciales[x].dtDatos[15,y].Style.BackColor=Color.White;
							listaFormEspeciales[x].dtDatos[16,y].Style.BackColor=Color.White;
						}
					}
				}
			}
		}
		#endregion
		
		#region CONFIRMA OPERADOR
		public void confirmaAsignacion(Int64 id_Ruta, Int64 id_operacion, int posRow, String CONFIRM)
		{
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				for(int y=0; y<listaFormEspeciales[x].dtDatos.Rows.Count; y++)
				{
					if(Convert.ToInt64(listaFormEspeciales[x].dtDatos[4,y].Value)==id_Ruta && listaFormEspeciales[x].dtDatos[1,y].Value.ToString()!="000")
					{
						listaFormEspeciales[x].dtDatos[5,y].Value=id_operacion;
						listaFormEspeciales[x].dtDatos[3,y].Value=id_operacion;
						
						for(int z=0; z<3; z++)
						{
							listaFormEspeciales[x].dtDatos[z,y].Style.BackColor=Color.MediumSpringGreen;
						}
					}
					if(Convert.ToInt64(listaFormEspeciales[x].dtDatos[9,y].Value)==id_Ruta && listaFormEspeciales[x].dtDatos[15,y].Value.ToString()!="000")
					{
						listaFormEspeciales[x].dtDatos[10,y].Value=id_operacion;
						listaFormEspeciales[x].dtDatos[17,y].Value=id_operacion;
						
						for(int z=14; z<17; z++)
						{
							listaFormEspeciales[x].dtDatos[z,y].Style.BackColor=Color.MediumSpringGreen;
						}
					}
				}
			}
			
			conteoCantidades();
		}
		
		public void delConfirmacion(Int64 id_Ruta)
		{
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				for(int y=0; y<listaFormEspeciales[x].dtDatos.Rows.Count; y++)
				{
					if(Convert.ToInt64(listaFormEspeciales[x].dtDatos[4,y].Value)==id_Ruta)
					{
						listaFormEspeciales[x].dtDatos[5,y].Value=" ";
						listaFormEspeciales[x].dtDatos[3,y].Value=" ";
						
						listaFormEspeciales[x].dtDatos[0,y].Style.BackColor=Color.Silver;
						listaFormEspeciales[x].dtDatos[1,y].Style.BackColor=Color.White;
						listaFormEspeciales[x].dtDatos[2,y].Style.BackColor=Color.White;
						
					}
					else if(Convert.ToInt64(listaFormEspeciales[x].dtDatos[9,y].Value)==id_Ruta)
					{
						listaFormEspeciales[x].dtDatos[10,y].Value=" ";
						listaFormEspeciales[x].dtDatos[17,y].Value=" ";
						
						listaFormEspeciales[x].dtDatos[14,y].Style.BackColor=Color.Silver;
						listaFormEspeciales[x].dtDatos[15,y].Style.BackColor=Color.White;
						listaFormEspeciales[x].dtDatos[16,y].Style.BackColor=Color.White;
					}
				}
			}
			
			conteoCantidades();
		}
		#endregion
		
		void FormPrincEspecialesFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel=true;
			refEmpresaOper.datosEspeciales=false;
			this.Visible=false;
		}
		
		#region REFRESCA INFORMACION
		void FormPrincEspecialesVisibleChanged(object sender, EventArgs e)
		{
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				for(int y=0; y<listaFormEspeciales[x].dtDatos.Rows.Count; y++)
				{
					//if(listaFormEspeciales[x].dtDatos[2,y].Style.BackColor.Name.ToString()!="MediumSpringGreen")
					//{
						refEmpresaOper.getPlaneacionAlt(Convert.ToInt64(listaFormEspeciales[x].dtDatos[4,y].Value));
					/*}
					else if(listaFormEspeciales[x].dtDatos[16,y].Style.BackColor.Name.ToString()!="MediumSpringGreen")
					{*/
						refEmpresaOper.getPlaneacionAlt(Convert.ToInt64(listaFormEspeciales[x].dtDatos[9,y].Value));
					//}
				}
			}
			/*
			if(this.Visible==true)
				hilo1.Resume();
			else
				hilo1.Suspend();*/
		}
		#endregion
		
		#region CONTEO DE VIAJES SIN ASIGNAR
		public void conteoCantidades()
		{
			lblTotal.Text="0";
			lblSinAsignar.Text="0";
			
			//MessageBox.Show("listaFormEspeciales.Count="+listaFormEspeciales.Count);
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				listaFormEspeciales[x].conteoFaltante();
				
				//MessageBox.Show(Convert.ToInt64(lblTotal.Text)+"+"+Convert.ToInt64(listaFormEspeciales[x].lblCantidad.Text));
				lblTotal.Text=(Convert.ToInt64(lblTotal.Text)+Convert.ToInt64(listaFormEspeciales[x].lblCantidad.Text)).ToString();
				
				if(Convert.ToInt64(listaFormEspeciales[x].lblRestEnt.Text)==Convert.ToInt64(listaFormEspeciales[x].lblRestRegresos.Text) && Convert.ToInt64(listaFormEspeciales[x].lblRestEnt.Text)!=0)
				{
					lblSinAsignar.Text=(Convert.ToInt64(lblSinAsignar.Text)+Convert.ToInt64(listaFormEspeciales[x].lblRestEnt.Text)).ToString();
				}
				else if(Convert.ToInt64(listaFormEspeciales[x].lblRestEnt.Text)<Convert.ToInt64(listaFormEspeciales[x].lblRestRegresos.Text))
				{
					lblSinAsignar.Text=(Convert.ToInt64(lblSinAsignar.Text)+Convert.ToInt64(listaFormEspeciales[x].lblRestRegresos.Text)).ToString();
				}
				else if(Convert.ToInt64(listaFormEspeciales[x].lblRestEnt.Text)>Convert.ToInt64(listaFormEspeciales[x].lblRestRegresos.Text))
				{
					lblSinAsignar.Text=(Convert.ToInt64(lblSinAsignar.Text)+Convert.ToInt64(listaFormEspeciales[x].lblRestEnt.Text)).ToString();
				}
				
				if(lblSinAsignar.Text.ToString()!="0")
					lblSinAsignar.ForeColor=Color.Red;
				else
					lblSinAsignar.ForeColor=Color.Black;
			}
		}
		#endregion
		
		#region ABRIR O CERRAR FORMULARIOS
		void CmdMostrarClick(object sender, EventArgs e)
		{
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				listaFormEspeciales[x].ABRE();
			}
			mueveFormVR(listaFormEspeciales[0]);
		}
		
		void CmdCerrarClick(object sender, EventArgs e)
		{
			for(int x=0; x<listaFormEspeciales.Count; x++)
			{
				listaFormEspeciales[x].CIERRE();
			}
			mueveFormVR(listaFormEspeciales[0]);
		}
		#endregion
		
		void CmdTodoClick(object sender, EventArgs e)
		{
			if(vista==true)
			{
				for(int x=0; x<listaFormEspeciales.Count; x++)
				{
					listaFormEspeciales[x].CIERRE();
				}
				mueveFormVR(listaFormEspeciales[0]);
				
				desSeleccion();
				
				vista=false;
			}
			else if(vista==false)
			{
				for(int x=0; x<listaFormEspeciales.Count; x++)
				{
					listaFormEspeciales[x].ABRE();
				}
				mueveFormVR(listaFormEspeciales[0]);
				
				desSeleccion();
				
				vista=true;
			}
		}
		
		void CmdAgregaEspClick(object sender, EventArgs e)
		{
			Interfaz.Libro.FormIngresoRapido viajesNuevos = new Interfaz.Libro.FormIngresoRapido();
			
			viajesNuevos.ShowDialog();
		}
		
		void FormPrincEspecialesFormClosed(object sender, FormClosedEventArgs e)
		{
			//hilo1.Abort();
		}
		
		
	}
}
