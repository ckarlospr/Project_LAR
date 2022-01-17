using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormOperacionesOperador : Form
	{
		public int cant=0;
		public Interfaz.Operaciones.FormOperadores refPrincipal = null;
		private Interfaz.Asignacion.FormDesasignacion refEstatus = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		public int ID_OPERADOR;
		public int ID_VEHICULO;
		public String tipoVehiculo;
		public String numeroVehiculo;
		public String tipo="Operador";
		public List<String> empConteo = new List<String>();
		
		public FormOperacionesOperador(Interfaz.Operaciones.FormOperadores prin)
		{
			InitializeComponent();
			refPrincipal=prin;
		}
		
		void TxtAliasDoubleClick(object sender, EventArgs e)
		{
			if(tipo=="Operador")
			{
				if(txtAlias.BackColor.Name=="DodgerBlue")
				{
					txtAlias.BackColor=Color.White;
					refPrincipal.principal.AliasOperador="";
					refPrincipal.principal.guardia="";
					refPrincipal.principal.datosAsignacion(null);
					
					for(int y=0; y<refPrincipal.principal.formPrincEmp.refMOV.Count; y++)
					{
						refPrincipal.principal.formPrincEmp.refMOV[y].cmdGuardia.Enabled=false;
					}
				}
				//Interfaz.Operaciones.FormRutasCercanas rutaOperador = new Interfaz.Operaciones.FormRutasCercanas(ID_OPERADOR,txtAlias.Text);
				//rutaOperador.ShowDialog();
			}
			else if(tipo=="Externo")
			{
				MessageBox.Show("Operador externo");
			}
		}
		
		void TxtEstadoDoubleClick(object sender, EventArgs e)
		{
			if(tipo!="Externo")// && DateTime.Now.ToString().Substring(0,10)==refPrincipal.DIA)
			{
				refEstatus = new Interfaz.Asignacion.FormDesasignacion(ID_OPERADOR,ID_VEHICULO,this);
				refEstatus.ShowDialog();
			}
		}
		
		#region SELECCION DE OPERADOR
		public void TxtAliasMouseClick(object sender, MouseEventArgs e)
		{
			selecOpe();
		}
		
		public void selecOpe()
		{
			if(txtEstado.Text=="A" || txtEstado.Text=="G" || txtEstado.Text=="R" || txtEstado.Text=="E")
			{
				if(refPrincipal.principal.RutaDatagris==-1)
				{
					refPrincipal.principal.AliasOperador=txtAlias.Text;
					if(txtEstado.Text=="G")
					{
						refPrincipal.principal.guardia="G";
					}
					refPrincipal.principal.datosAsignacion(this);
					for(int x=0; x<refPrincipal.RefOperadores.Count; x++)
					{
						if(refPrincipal.RefOperadores[x].txtAlias.BackColor==Color.DodgerBlue)
						{
							refPrincipal.RefOperadores[x].txtAlias.BackColor=Color.White;
						}
					}
					txtAlias.BackColor=Color.DodgerBlue;					
					if(refPrincipal.principal.lblDatoNivel.Text == "MASTER"){
						for(int x=0; x<refPrincipal.principal.formPrincEmp.refMOV.Count; x++){
							refPrincipal.principal.formPrincEmp.refMOV[x].cmdGuardia.Enabled=true;
						}
					}					
				}
				else
				{
					refPrincipal.principal.datosAsignacion(this);
					refPrincipal.principal.asignandoViaje(txtAlias.Text);
				}
			}
			else
			{
				txtAlias.BackColor=Color.Red;
			}
		}
		
		public void envioDatos()
		{
			refPrincipal.principal.datosAsignacion(this);
		}
		#endregion 
		
		#region LOGICA CONTEO
		private Interfaz.Nomina.FormNomina refNomina = new Transportes_LAR.Interfaz.Nomina.FormNomina();
		public void getCantidad()
		{
			//refNomina.RetornoSueldoAlias2(txtAlias.Text, refPrincipal.principal.formPrincEmp.fecha_despacho);
			cant=refNomina.cuenta;
			CambioColor();
		}
		
		public void addRuta(int can, String emp)
		{
			//getCantidad();
			int x=0;
			
			if(empConteo.Count>0)
			{
				for(int y=0; y<empConteo.Count; y++)
				{
					if(emp==empConteo[y].ToString())
					{
						x++;
					}
				}
			}
			
			if((can==1 && x==2)||(can==1 && x==4)||(can==1 && x==6))
			{
				empConteo.Add(emp);
				cant++;
				CambioColor();
			}
			else if(can==1 && x==0)
			{
				empConteo.Add(emp);
				cant++;
				CambioColor();
			}
			else if((can==1 && x==1)||(can==1 && x==3)||(can==1 && x==5))
			{
				empConteo.Add(emp);
			}
			
			if((can==-1 && x==1)||(can==-1 && x==3)||(can==-1 && x==5))
			{
				apoyo(emp);
				cant--;
				CambioColor();
			}
			else if((can==-1 && x==2)||(can==-1 && x==4)||(can==-1 && x==6))
			{
				apoyo(emp);
			}
			
			for(int y=0; y<refPrincipal.principal.formPrincEmp.refMOV.Count; y++)
			{
				refPrincipal.principal.formPrincEmp.refMOV[y].cmdGuardia.Enabled=false;
			}
			
			txtAlias.BackColor=Color.White;
		}
		
		public void apoyo(String emp)
		{
			if(empConteo.Count>0)
			{
				for(int y=0; y<empConteo.Count; y++)
				{
					if(emp==empConteo[y].ToString())
					{
						empConteo.RemoveAt(y);
						break;
					}
				}
			}
		}
		
		public void CambioColor()
		{
			if(cant>=4)
			{
				this.BackColor=Color.Red;
			}
			else
			{
				if(cant==3)
				{
					this.BackColor=Color.Orange;
				}
				else
				{
					if(cant==2)
					{
						this.BackColor=Color.Gold;
					}
					else
					{
						if(cant==1)
						{
							this.BackColor=Color.MediumSpringGreen;
						}
						else
						{
							if(cant==0)
							{
								this.BackColor=Color.HotPink;
							}
						}
					}
				}
			}
			
			if(cant<0)
			{
				txtNum.Text="0";
			}
			else
			{
				txtNum.Text=cant.ToString();
			}
		}
		#endregion
		
		void FormOperacionesOperadorLoad(object sender, EventArgs e)
		{
			refPrincipal.CapturaRefOperadores(this);
			validacion(this);
			colorEstado(txtEstado.Text);
			//getCantidad();
			txtNumeroV.Text = numeroVehiculo;
		}
		
		public void colorEstado(String estado)
		{
			if(tipo=="Operador")
			{
				txtEstado.Text=estado;
				if(estado=="A" || estado=="a")
				{
					txtEstado.BackColor=Color.White;
					
					if(Convert.ToInt16(txtNum.Text)==0)
						this.BackColor=Color.HotPink;
				}
				if(estado=="D" || estado=="d")
					txtEstado.BackColor=Color.LightSteelBlue;
				if(estado=="T" || estado=="t")
					txtEstado.BackColor=Color.DarkOliveGreen;
				if(estado=="E" || estado=="e")
					txtEstado.BackColor=Color.LimeGreen;
				if(estado=="P" || estado=="p")
					txtEstado.BackColor=Color.Orange;
				if(estado=="X" || estado=="x")
					txtEstado.BackColor=Color.Chocolate;
				if(estado=="G" || estado=="g")
					txtEstado.BackColor=Color.Yellow;
				if(estado=="R" || estado=="r")
					txtEstado.BackColor=Color.BlueViolet;
				if(estado=="I" || estado=="i")
					txtEstado.BackColor=Color.Red;
			}
			/*else if(tipo=="Externo")
			{
				MessageBox.Show("Operador externo");
			}*/
		}
		
		void validacion(FormOperacionesOperador miform)
		{
			miform.txtAlias.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			miform.txtNum.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
		}
		
		void TxtAliasMouseLeave(object sender, EventArgs e)
		{
			if(txtEstado.Text!="A")
			{
				if(txtEstado.Text!="G")
				{
					if(txtEstado.Text!="R")
					{
						if(txtEstado.Text!="E")
							txtAlias.BackColor=Color.White;
					}
				}
			}
			
			//if(msj==1){
				//datosOp.Visible=false;
				//msj=0;
			//}
		}
		
		
		void TxtAliasKeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		
		void TxtNumDoubleClick(object sender, EventArgs e)
		{
			if(tipo!="Externo")
			{
				FormDatosOperador datosOp = new FormDatosOperador(ID_OPERADOR, tipo);
				datosOp.ShowDialog();
			}
		}
		
		
		public String Coment = "";
		public bool guia = false;
		
		void TxtEstadoKeyPress(object sender, KeyPressEventArgs e)
		{
			/*if(DateTime.Now.ToString().Substring(0,10)==refPrincipal.DIA)
			{*/
				if(Char.IsLetter(e.KeyChar) && (e.KeyChar.ToString()=="A" || e.KeyChar.ToString()=="D" || e.KeyChar.ToString()=="T"
				                                || e.KeyChar.ToString()=="E" || e.KeyChar.ToString()=="P" || e.KeyChar.ToString()=="X" || e.KeyChar.ToString()=="G" 
				                                || e.KeyChar.ToString()=="R" || e.KeyChar.ToString()=="a" || e.KeyChar.ToString()=="t" || e.KeyChar.ToString()=="p" 
				                                || e.KeyChar.ToString()=="r" || e.KeyChar.ToString()=="d" || e.KeyChar.ToString()=="e" || e.KeyChar.ToString()=="x" 
				                                || e.KeyChar.ToString()=="g" || e.KeyChar.ToString()=="i" || e.KeyChar.ToString()=="I"))
				{
					new FormComentario(this).ShowDialog();
					
					if(guia==true)
					{
						if(e.KeyChar.ToString()=="T" || e.KeyChar.ToString()=="t")
						{
							new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialVeh(ID_VEHICULO,"T", Coment,refPrincipal.DIA, refPrincipal.TURNO, refPrincipal.principal.idUsuario);
							
							/*new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe(ID_OPERADOR, e.KeyChar.ToString().ToUpper(), Coment, refPrincipal.principal.formPrincEmp.fecha_despacho, refPrincipal.principal.formPrincEmp.ConsTurno, refPrincipal.principal.idUsuario);
							
							conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), '"+dtpTiempo.Value.ToString("hh:mm:ss")+"', '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', 'TALLER', '"+txtDescripcion.Text+"', "+refPrincipal.principal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();*/
						}
						else
						{
							new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe(ID_OPERADOR,e.KeyChar.ToString().ToUpper(), Coment, refPrincipal.principal.formPrincEmp.fecha_despacho, refPrincipal.principal.formPrincEmp.ConsTurno, refPrincipal.principal.idUsuario);
							
							conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+refPrincipal.principal.formPrincEmp.fecha_despacho+"', '"+refPrincipal.principal.formPrincEmp.ConsTurno+"', '"+tipo+"', '"+Coment+"', "+refPrincipal.principal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
							conn.comando.ExecuteNonQuery();
							conn.conexion.Close();
						}
						
						colorEstado(e.KeyChar.ToString());
					}
					
					guia=false;
				}
				else
				{
					e.Handled=true;
				}
			/*}
			else
			{
				e.Handled=true;
			}*/
		}
		
		void TxtEstadoMouseClick(object sender, MouseEventArgs e)
		{
			txtEstado.Focus();
			txtEstado.SelectAll();
		}
		
		void FormOperacionesOperadorMouseEnter(object sender, EventArgs e)
		{
			this.Select();
		}
		
		public void getEstatus()
		{
			new Conexion_Servidor.Desapacho.SQL_Operaciones().getEstatusOp(this.ID_OPERADOR, refPrincipal.DIA, refPrincipal.TURNO, txtEstado);
		}
		
		void TxtAliasMouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
				new FormModificaOperador(this, ID_OPERADOR.ToString(), refPrincipal.principal.idUsuario.ToString()).ShowDialog();
		}
		
		
		public int msj=0;
		public FormMsjDatosOperador datosOp = new FormMsjDatosOperador();
		
		void TxtAliasEnter(object sender, EventArgs e)
		{
			if(msj==1){
				datosOp.Visible=false;
				msj=0;
			}
		}
		
		void TxtAliasMouseHover(object sender, EventArgs e)
		{				
			if(tipo!="Externo" && msj == 0){
				datosOp.Location  = new System.Drawing.Point(Control.MousePosition.X-170, Control.MousePosition.Y+20);
				datosOp.getDatosOpe(ID_OPERADOR, this);
				datosOp.Visible=true;
				msj=1;	
			}else{
				datosOp.Visible=false;
				msj = 0;
			}
		}
		
		void FormOperacionesOperadorMouseLeave(object sender, EventArgs e)
		{
			if(msj==1){
				datosOp.Visible=false;
				msj=0;
			}
		}
		
		void TxtEstadoTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
