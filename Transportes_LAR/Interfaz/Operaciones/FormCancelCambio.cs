using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormCancelCambio : Form
	{
		public FormCancelCambio(FormEmpresasOperaciones refEmpO, int R, int C)
		{
			InitializeComponent();
			refEmpOper=refEmpO;
			indexCol=C;
			indexFil=R;
		}
				
		public int indexCol=0;
		public int indexFil=0;
		
		private bool viaje=false;
		private bool hora=false;
		
		public FormEmpresasOperaciones refEmpOper = null;
		
		void FormCancelCambioLoad(object sender, EventArgs e)
		{
			
			if(indexCol<9)
			{
				try
				{
					txtDato.Text=refEmpOper.dtgEmpresas[4,indexFil].Value.ToString();
					lblDato.Text=refEmpOper.dtgEmpresas[3,indexFil].Value.ToString()+"-"+refEmpOper.dtgEmpresas[6,indexFil].Value.ToString();
				}
				catch(Exception)
				{
					
				}
				if(refEmpOper.dtgEmpresas[0,indexFil].Style.BackColor.Name!="MediumSpringGreen")
				{
					CmdCancelarViaje.Enabled=false;
					cmdRec.Enabled=false;
					cmdPunto.Enabled=false;
					cmdCanc2.Enabled=false;
					cmdPruebas.Enabled=false;
				}
				else
				{
					cmdQuitarOperador.Enabled=false;
				}
				
				if(refEmpOper.dtgEmpresas[6,indexFil].Value.ToString() == " " || refEmpOper.dtgEmpresas[6,indexFil].Value.ToString() == "" )
					btnUberTaxi.Enabled = false;
			}
			else
			{
				try
				{
					txtDato.Text=refEmpOper.dtgEmpresas[12,indexFil].Value.ToString();
					lblDato.Text=refEmpOper.dtgEmpresas[11,indexFil].Value.ToString()+"-"+refEmpOper.dtgEmpresas[14,indexFil].Value.ToString();
				}
				catch(Exception)
				{
					
				}
				
				if(refEmpOper.dtgEmpresas[9,indexFil].Style.BackColor.Name!="MediumSpringGreen")
				{
					CmdCancelarViaje.Enabled=false;
					cmdRec.Enabled=false;
					cmdPunto.Enabled=false;
					cmdCanc2.Enabled=false;
					cmdPruebas.Enabled=false;
				}
				else
				{
					cmdQuitarOperador.Enabled=false;
				}
				
				if(refEmpOper.dtgEmpresas[14,indexFil].Value.ToString() == " " || refEmpOper.dtgEmpresas[14,indexFil].Value.ToString() == "" )
					btnUberTaxi.Enabled = false;
			}
			
			if(refEmpOper.nomEmpresa=="Especiales")
			{
				cmdCancelaEspecial.Enabled=true;
			}
			
			if(refEmpOper.refPrincipal.principal.lblDatoNivel.Text == "MASTER")
				cmdApoyos.Enabled = true;
			else
				cmdApoyos.Enabled = false;
			
			/*if(refEmpOper.refPrincipal.principal.lblDatoNivel.Text == "COORDINADOR")
				cmdApoyos.Enabled = true;
			else
				cmdApoyos.Enabled = false;*/
		}
			
		#region EVENTOS BOTONES
		void CmdCancelarViajeClick(object sender, EventArgs e)
		{
			txtDato.Text="Operador-Ruta";
			cmdGuardar.Enabled=true;
			viaje=true;
			
			borradoAsignacion();
			this.Close();
		}
		
		void CdmCambiarHoraClick(object sender, EventArgs e)
		{
			txtDato.Enabled=true;
			cmdGuardar.Enabled=true;
			hora=true;
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(viaje)
				borradoAsignacion();
			
			//if(hora)
			cambioHora();
			
			this.Close();
		}
		
		void CmdCancelProcesoClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CmdQuitarOperadorClick(object sender, EventArgs e)
		{
			modColores(1);
			this.Close();
		}
		
		void CmdPuntoClick(object sender, EventArgs e)
		{
			// FALTA MANDAR PARA SOLO UN SENCILLO DEL LADO IZQUIERDO
			
			if(refEmpOper.datosEspeciales==true)
			{
				if(indexCol<9)
				{
					refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[2,indexFil].Value));
				}
				
				if(refEmpOper.dtgEmpresas[14,indexFil].Style.BackColor.Name=="MediumSpringGreen")
				{
					refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[10,indexFil].Value));
				}
			}
			
			if(indexCol<9)
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion2(Convert.ToInt64(refEmpOper.dtgEmpresas[17,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario);
				new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaPunto(Convert.ToInt64(refEmpOper.dtgEmpresas[18,indexFil].Value), Convert.ToInt64(refEmpOper.dtgEmpresas[2,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario,refEmpOper.refPrincipal.ConsTurno, refEmpOper.refPrincipal.fecha_despacho);
				
				if(refEmpOper.dtgEmpresas[14,indexFil].Style.BackColor.Name=="MediumSpringGreen")
					new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion2(Convert.ToInt64(refEmpOper.dtgEmpresas[21,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario);
				
				modColores(2);
			}
			else
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion2(Convert.ToInt64(refEmpOper.dtgEmpresas[21,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario);
				new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaPunto(Convert.ToInt64(refEmpOper.dtgEmpresas[22,indexFil].Value), Convert.ToInt64(refEmpOper.dtgEmpresas[10,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario,refEmpOper.refPrincipal.ConsTurno, refEmpOper.refPrincipal.fecha_despacho);
				
				modColores(4);
			}
			
			
			this.Close();
		}
		
		
		void CmdRecClick(object sender, EventArgs e)
		{
			new Interfaz.Operaciones.FormReconRutas(refEmpOper.refPrincipal, this).ShowDialog();
			this.Close();
		}
		
		void CmdPruebasClick(object sender, EventArgs e)
		{
			new Interfaz.Operaciones.FormPruebasRend(refEmpOper.refPrincipal, this).ShowDialog();
			this.Close();
		}
		
		void CmdApoyosClick(object sender, EventArgs e)
		{
			new Interfaz.Operaciones.FormApoyos(refEmpOper.refPrincipal, this).ShowDialog();
			this.Close();
		}
		#endregion
		
		public void cambioHora()
		{
			if(indexCol<9)
				new Conexion_Servidor.Desapacho.SQL_Operaciones().updateRuta(txtDato.Text,Convert.ToInt64(refEmpOper.dtgEmpresas[2,indexFil].Value));
			else
				new Conexion_Servidor.Desapacho.SQL_Operaciones().updateRuta(txtDato.Text,Convert.ToInt64(refEmpOper.dtgEmpresas[10,indexFil].Value));
			
			modHora();
		}
		
		public void borradoAsignacion()
		{
			if(indexCol<9)
			{
				if(refEmpOper.datosEspeciales==true)
				{
					refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[2,indexFil].Value));
				}
				new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion2(Convert.ToInt64(refEmpOper.dtgEmpresas[17,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario);
			}
			else
			{
				if(refEmpOper.datosEspeciales==true)
				{
					refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[10,indexFil].Value));
				}
				new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion2(Convert.ToInt64(refEmpOper.dtgEmpresas[21,indexFil].Value), refEmpOper.refPrincipal.principal.idUsuario);
			}
			
			modColores(1);
		}
		
		public void modHora()
		{
			if(indexCol<9)
				refEmpOper.dtgEmpresas[4,indexFil].Value=txtDato.Text;
			else
				refEmpOper.dtgEmpresas[12,indexFil].Value=txtDato.Text;
		}
		
		public void modColores(int tipo)
		{
			if(tipo==1)
			{
				if(indexCol<9)
				{
					refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[3,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
					refEmpOper.dtgEmpresas[3,indexFil].Value="Operador";
					refEmpOper.dtgEmpresas[5,indexFil].Value="00:00";
					refEmpOper.dtgEmpresas[7,indexFil].Value="00:00";
					for(int x=0; x<9; x++)
					{
						refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
					}
					refEmpOper.dtgEmpresas[0,indexFil].Style.BackColor=Color.Red;
					//refEmpOper.dtgEmpresas[3,indexFil].Style.BackColor=Color.MediumSpringGreen;
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[17].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[18].Value="";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[19].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[20].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[8].Value=false;
				}
				else
				{
					refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[11,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
					refEmpOper.dtgEmpresas[11,indexFil].Value="Operador";
					refEmpOper.dtgEmpresas[13,indexFil].Value="00:00";
					refEmpOper.dtgEmpresas[15,indexFil].Value="00:00";
					for(int x=9; x<17; x++)
					{
						refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
					}
					refEmpOper.dtgEmpresas[9,indexFil].Style.BackColor=Color.Red;
					//refEmpOper.dtgEmpresas[11,indexFil].Style.BackColor=Color.MediumSpringGreen;
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[21].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[22].Value="";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[23].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[24].Value=" ";
					refEmpOper.dtgEmpresas.Rows[indexFil].Cells[16].Value=false;
					//refEmpOper.dtgEmpresas[16,indexFil].f;
				}
			}
			else if(tipo==2)
			{
				refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[3,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
				refEmpOper.dtgEmpresas[3,indexFil].Value="Operador";
				refEmpOper.dtgEmpresas[5,indexFil].Value="00:00";
				refEmpOper.dtgEmpresas[7,indexFil].Value="00:00";
				for(int x=0; x<9; x++)
				{
					refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
				}
				refEmpOper.dtgEmpresas[0,indexFil].Style.BackColor=Color.Red;
				
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[17].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[18].Value="";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[19].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[20].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[8].Value=false;
			
				refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[11,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
				refEmpOper.dtgEmpresas[11,indexFil].Value="Operador";
				refEmpOper.dtgEmpresas[13,indexFil].Value="00:00";
				refEmpOper.dtgEmpresas[15,indexFil].Value="00:00";
				for(int x=9; x<17; x++)
				{
					refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
				}
				refEmpOper.dtgEmpresas[9,indexFil].Style.BackColor=Color.Red;
				
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[21].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[22].Value="";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[23].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[24].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[16].Value=false;
			}
			else if(tipo==4)
			{
				refEmpOper.refPrincipal.principal.contandoViajes(-1,refEmpOper.dtgEmpresas[11,indexFil].Value.ToString(), refEmpOper.lblNombreEmp.Text, "A");
				refEmpOper.dtgEmpresas[11,indexFil].Value="Operador";
				refEmpOper.dtgEmpresas[13,indexFil].Value="00:00";
				refEmpOper.dtgEmpresas[15,indexFil].Value="00:00";
				for(int x=9; x<17; x++)
				{
					refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.White;
				}
				refEmpOper.dtgEmpresas[9,indexFil].Style.BackColor=Color.Red;
				//refEmpOper.dtgEmpresas[11,indexFil].Style.BackColor=Color.MediumSpringGreen;
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[21].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[22].Value="";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[23].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[24].Value=" ";
				refEmpOper.dtgEmpresas.Rows[indexFil].Cells[16].Value=false;
			}
		}
		
		void CmdCancelaEspecialClick(object sender, EventArgs e)
		{
			if(refEmpOper.dtgEmpresas[0,indexFil].Style.BackColor.Name!="MediumSpringGreen")
			{
				if(refEmpOper.datosEspeciales==true)
				{
					refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[2,indexFil].Value));
					refEmpOper.forDatosEsp.delConfirmacion(Convert.ToInt64(refEmpOper.dtgEmpresas[10,indexFil].Value));
				}
				
				for(int x=0; x<17; x++)
				{
					refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.Red;
				}
				refEmpOper.dtgEmpresas[3,indexFil].Value="Cancelado";
				refEmpOper.dtgEmpresas[11,indexFil].Value="Cancelado";
				
				new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaEspecial(refEmpOper.dtgEmpresas[2,indexFil].Value.ToString());
				new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaEspecial(refEmpOper.dtgEmpresas[10,indexFil].Value.ToString());
				this.Close();
			}
			else
			{
				MessageBox.Show("Para cancelar desasigna al operador");
				/*DialogResult rs2 = MessageBox.Show(" La ruta tiene un operador asignado desea cancelar viaje. \n La asignacion se eliminara sin comision al operador. \n¿Desea Cancelar viaje?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes==rs2)
				{
					for(int x=0; x<17; x++)
					{
						refEmpOper.dtgEmpresas[x,indexFil].Style.BackColor=Color.Red;
					}
					refEmpOper.dtgEmpresas[3,indexFil].Value="Cancelado";
					refEmpOper.dtgEmpresas[11,indexFil].Value="Cancelado";
					
					new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion(Convert.ToInt16(refEmpOper.dtgEmpresas[17,indexFil].Value));
					new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion(Convert.ToInt16(refEmpOper.dtgEmpresas[21,indexFil].Value));
					
					new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaEspecial(refEmpOper.dtgEmpresas[2,indexFil].Value.ToString());
				}*/
			}
		}
		
		void BtnUberTaxiClick(object sender, EventArgs e)
		{
			refEmpOper.refPrincipal.timer1.Stop();
			if(indexCol<9)
				new Interfaz.Controles.Uber_Taxi.FormUber_Taxi(this, refEmpOper.dtgEmpresas[2,indexFil].Value.ToString(), refEmpOper.refPrincipal.principal.idUsuario.ToString(), refEmpOper.refPrincipal.ConsTurno, refEmpOper.refPrincipal.fecha_despacho).ShowDialog();
			else
				new Interfaz.Controles.Uber_Taxi.FormUber_Taxi(this, refEmpOper.dtgEmpresas[10,indexFil].Value.ToString(), refEmpOper.refPrincipal.principal.idUsuario.ToString(), refEmpOper.refPrincipal.ConsTurno, refEmpOper.refPrincipal.fecha_despacho).ShowDialog();			
			this.Close();
		}
	}
}
