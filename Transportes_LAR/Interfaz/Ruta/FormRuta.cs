using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Ruta
{
	public partial class FormRuta : Form
	{
		private DataGridView tabla=null;
		private string idSubEmpresa="";
		private Interfaz.FormPrincipal principal = null;
		private Interfaz.Operaciones.FormEmpresasOperaciones formEmpresa = null;
		public int TIPO=0;
		
		#region CONSTRUCTOR
		public FormRuta(Interfaz.Operaciones.FormEmpresasOperaciones formE, DataGridView tabla,string idSubEmpresa, int tipo)
		{
			InitializeComponent();
			this.tabla=tabla;
			this.idSubEmpresa=idSubEmpresa;
			formEmpresa=formE;
			if(formE!=null)
			{
				cargaTurno();
				txtCantidades.Visible=true;
				lblCantidades.Visible=true;
			}
			TIPO=tipo;
			
			if(tipo==1)
				gbDias.Enabled=false;
		}
		#endregion
		
		#region EVENTO_BOTON (LOAD - CLOSING)
		void FormRutaLoad(object sender, EventArgs e)
		{
			getCargarValidacionCampos(this);
			//cmbTurno.SelectedIndex=0;
			//cmbSentido.SelectedIndex=0;
			cbEntrada.Checked=false;
			cbSalida.Checked=false;
			new Conexion_Servidor.Zona.SQL_Zona().getNombreZona(cmbZona);//CARGA_LAS_ZONAS
			this.MdiParent=principal;
		}
		
		void FormRutaFormClosing(object sender, FormClosingEventArgs e){
			
		}
		#endregion
		
		#region EVENTO_BOTONES (AGREGAR - CANCELAR)
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(tabla!=null)
			{
				if(getValidarCampo())
				{
					MessageBox.Show("Para poder agregar una ruta es necesario completar el llenado de todos los campos.","Agregar ruta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					tabControl1.SelectedIndex = 1;
				}
				else
				{
					getInsertarRuta();
					//tabla.DataSource=new Conexion_Servidor.Ruta.SQL_Ruta().getTabla("select ID, Nombre from RUTA where idSubEmpresa="+idSubEmpresa);
					tabla.DataSource=new Conexion_Servidor.Ruta.SQL_Ruta().getTabla("select ID, Nombre from RUTA where idSubEmpresa="+idSubEmpresa+" and extra='0' and TIPO='NRM' order by Nombre");
					getLimpiarCampo();
					new Interfaz.FormMensaje("Ruta almacenada exitosamente").Show();
				}
			}
			else
			{
				if(TIPO==0)
				{
					if(getValidarCampo())
					{
						MessageBox.Show("Para poder agregar una ruta es necesario completar el llenado de todos los campos.","Agregar ruta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
						tabControl1.SelectedIndex = 1;
					}
					else
					{
						getInsertarRuta();
						agreagarRuta();
						this.Close();
						formEmpresa.refPrincipal.getEmpresasOrden2();
					}
				}
				else
				{
					if(txtCantidades.Text!="" && txtCantidades.Text!="0")
					{
						if(txtNombre.Text=="" || txtKilometros.Text=="")
						{
							MessageBox.Show("Existen campos obligatorios sin llenar");
						}
						else
						{
							for(int y=0; y<Convert.ToInt16(txtCantidades.Text); y++)
							{
								getInsertarRuta();
								agreagarRuta();
								this.Close();
								formEmpresa.refPrincipal.getEmpresasOrden2();
							}
						}
					}
					else
					{
						txtCompletoForaneo.BackColor=(txtCompletoForaneo.Text=="")?Color.LightPink:Color.White;
						txtCantidades.BackColor=(txtCantidades.Text=="0" || txtCantidades.Text=="")?Color.LightPink:Color.White;
						MessageBox.Show("Cantidad no valida.");
					}
				}
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
		
		#region VALIDAR_CAMPOS_VACIOS
		private bool getValidarCampo()
		{
			txtNombre.BackColor=(txtNombre.Text=="")?Color.LightPink:Color.White;
			txtKilometros.BackColor=(txtKilometros.Text=="")?Color.LightPink:Color.White;
			txtIntinerario.BackColor=(txtIntinerario.Text=="")?Color.LightPink:Color.White;
			txtSencilloCamioneta.BackColor=(txtSencilloCamioneta.Text=="")?Color.LightPink:Color.White;
			txtCompletoCamioneta.BackColor=(txtCompletoCamioneta.Text=="")?Color.LightPink:Color.White;
			txtSencilloCamion.BackColor=(txtSencilloCamion.Text=="")?Color.LightPink:Color.White;
			txtCompletoCamion.BackColor=(txtCompletoCamion.Text=="")?Color.LightPink:Color.White;
			txtSencilloForaneo.BackColor=(txtSencilloForaneo.Text=="")?Color.LightPink:Color.White;
			
			gbDias.BackColor=(  cbxLunes.Checked 		==false&&
								cbxMartes.Checked		==false&&
								cbxMiercoles.Checked	==false&&
								cbxJueves.Checked		==false&&
								cbxViernes.Checked		==false&&
								cbxSabado.Checked		==false&&
								cbxDomingo.Checked		==false)?Color.LightPink:Color.White;
			if(cmbZona.Text=="")
				error.SetError(this.cmbZona,"Seleccione una zona"); 
			else
				error.SetError(this.cmbZona,""); 
			
			return (txtNombre.Text				==""||
			        txtKilometros.Text			==""||
			        txtIntinerario.Text			==""||
			        txtSencilloCamion.Text		==""||
			        txtCompletoCamion.Text		==""||
			        txtSencilloCamioneta.Text	==""||
			        txtCompletoCamioneta.Text	==""||
			        txtSencilloForaneo.Text		==""||
			        txtCompletoForaneo.Text		==""||
			        diasIns()
			       )?true:false;
		}
		
		public bool diasIns()
		{
			return(	cbxLunes.Checked 		==false&&
					cbxMartes.Checked		==false&&
					cbxMiercoles.Checked	==false&&
					cbxJueves.Checked		==false&&
					cbxViernes.Checked		==false&&
					cbxSabado.Checked		==false&&
					cbxDomingo.Checked		==false)?true:false;
		}
		#endregion
		
		#region VALIDAR_CAMPOS_DEL_FORMULARIO
		private void getCargarValidacionCampos(FormRuta formRuta){
			formRuta.txtSencilloCamion.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formRuta.txtSencilloCamioneta.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formRuta.txtSencilloForaneo.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formRuta.txtCompletoCamion.KeyPress			+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formRuta.txtCompletoCamioneta.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formRuta.txtCompletoForaneo.KeyPress		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
			formRuta.txtCantidades.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
		
		#region SQL_METODOS
		private void getInsertarRuta()
		{
			int foranea=0;
			if(cbEntrada.Checked==true)
			{
				if(formEmpresa==null || TIPO==0)
				{
					string minuto=(Convert.ToInt16(numMinuto.Text)<10)? "0"+numMinuto.Text:numMinuto.Text;
					string hora=(Convert.ToInt32(numHora.Text)<10)?"0"+numHora.Text+":"+minuto:numHora.Text+":"+minuto;
					string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(cmbZona.Text);
					new Conexion_Servidor.Ruta.SQL_Ruta().getInsertar("",
					                                                  idSubEmpresa,
					                                                  txtNombre.Text,
					                                                  cmbTurno.Text,
					                                                  "Entrada",
					                                                  txtKilometros.Text,
					                                                  hora,
					                                                  idZona,
					                                                  txtSencilloCamion.Text,
					                                                  txtCompletoCamion.Text,
					                                                  txtSencilloCamioneta.Text,
					                                                  txtCompletoCamioneta.Text,
					                                                  txtSencilloForaneo.Text,
					                                                  txtCompletoForaneo.Text,
					                                                  txtIntinerario.Text,
					                                                  getDiasIns(),
					                                                  foranea=((cbForanea.Checked==true)?1:0)
					                                                 );
				}
				else
				{
					String diaExtra = formEmpresa.DIA_DESPACHO.Substring(0,2);
					String mesExtra = formEmpresa.DIA_DESPACHO.Substring(3,2);
					String anioExtra = formEmpresa.DIA_DESPACHO.Substring(6,4);
					
					String miFecha = anioExtra+"-"+mesExtra+"-"+diaExtra;
					
					string minuto=(Convert.ToInt16(numMinuto.Text)<10)? "0"+numMinuto.Text:numMinuto.Text;
					string hora=(Convert.ToInt32(numHora.Text)<10)?"0"+numHora.Text+":"+minuto:numHora.Text+":"+minuto;
					string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(cmbZona.Text);
					new Conexion_Servidor.Ruta.SQL_Ruta().getInsertarApoyo("",
					                                                  idSubEmpresa,
					                                                  txtNombre.Text,
					                                                  cmbTurno.Text,
					                                                  "Entrada",
					                                                  txtKilometros.Text,
					                                                  hora,
					                                                  idZona,
					                                                  txtIntinerario.Text,
					                                                  foranea=((cbForanea.Checked==true)?1:0),
					                                                  miFecha,
					                                                  txtSencilloCamion.Text,
					                                                  txtCompletoCamion.Text,
					                                                  txtSencilloCamioneta.Text,
					                                                  txtCompletoCamioneta.Text,
					                                                  txtSencilloForaneo.Text,
					                                                  txtCompletoForaneo.Text);
				}
			}
			if(cbSalida.Checked==true)
			{
				if(formEmpresa==null || TIPO==0)
				{
					string minuto=(Convert.ToInt16(numMinuto.Text)<10)? "0"+numMinuto.Text:numMinuto.Text;
					string hora=(Convert.ToInt32(numHora.Text)<10)?"0"+numHora.Text+":"+minuto:numHora.Text+":"+minuto;
					string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(cmbZona.Text);
					new Conexion_Servidor.Ruta.SQL_Ruta().getInsertar("",
					                                                  idSubEmpresa,
					                                                  txtNombre.Text,
					                                                  cmbTurno.Text,
					                                                  "Salida",
					                                                  txtKilometros.Text,
					                                                  hora,
					                                                  idZona,
					                                                  txtSencilloCamion.Text,
					                                                  txtCompletoCamion.Text,
					                                                  txtSencilloCamioneta.Text,
					                                                  txtCompletoCamioneta.Text,
					                                                  txtSencilloForaneo.Text,
					                                                  txtCompletoForaneo.Text,
					                                                  txtIntinerario.Text,
					                                                  getDiasIns(),
					                                                  foranea=((cbForanea.Checked==true)?1:0)
					                                                 );
				}
				else
				{
					String diaExtra = formEmpresa.DIA_DESPACHO.Substring(0,2);
					String mesExtra = formEmpresa.DIA_DESPACHO.Substring(3,2);
					String anioExtra = formEmpresa.DIA_DESPACHO.Substring(6,4);
					
					String miFecha = anioExtra+"-"+mesExtra+"-"+diaExtra;
					
					string minuto=(Convert.ToInt16(numMinuto.Text)<10)? "0"+numMinuto.Text:numMinuto.Text;
					string hora=(Convert.ToInt32(numHora.Text)<10)?"0"+numHora.Text+":"+minuto:numHora.Text+":"+minuto;
					string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(cmbZona.Text);
					new Conexion_Servidor.Ruta.SQL_Ruta().getInsertarApoyo("",
					                                                  idSubEmpresa,
					                                                  txtNombre.Text,
					                                                  cmbTurno.Text,
					                                                  "Salida",
					                                                  txtKilometros.Text,
					                                                  hora,
					                                                  idZona,
					                                                  txtIntinerario.Text,
					                                                  foranea=((cbForanea.Checked==true)?1:0),
					                                                  miFecha,
					                                                  txtSencilloCamion.Text,
					                                                  txtCompletoCamion.Text,
					                                                  txtSencilloCamioneta.Text,
					                                                  txtCompletoCamioneta.Text,
					                                                  txtSencilloForaneo.Text,
					                                                  txtCompletoForaneo.Text);
				}
			}
		}
		#endregion		
		
		#region LIMPIAR_CAMPOS
		private void getLimpiarCampo()
		{
			txtNombre.Text="";
			cmbTurno.SelectedIndex=0;
			//cmbSentido.SelectedIndex=0;
			cbEntrada.Checked=false;
			cbSalida.Checked=false;
			txtKilometros.Text="0";
			numHora.Value=0;
			numMinuto.Value=0;
			txtSencilloCamion.Text="0";
			txtCompletoCamion.Text="0";
			txtSencilloCamioneta.Text="0";
			txtCompletoCamioneta.Text="0";
			txtSencilloForaneo.Text="0";
			txtCompletoForaneo.Text="0";
			txtIntinerario.Text="Pendiente";
			tabControl1.SelectedIndex = 0;
			cbxLunes.Checked 		=true;
			cbxMartes.Checked		=true;
			cbxMiercoles.Checked	=true;
			cbxJueves.Checked		=true;
			cbxViernes.Checked		=true;
			cbxSabado.Checked		=true;
			cbxDomingo.Checked		=true;
			if(cmbZona.Items.Count>0)
			{
				cmbZona.SelectedIndex=0;	
			}
		}
		
		#endregion
		
		#region VALIDACION_DE_HORA
		void NumFormatoKeyPress(object sender, KeyPressEventArgs e)
		{
			//e.Handled=true;
		}
		#endregion
		
		#region Obtencion de dias 
		public String getDiasIns()
		{
			String dia="1";
			
			if(cbxLunes.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxMartes.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxMiercoles.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxJueves.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxViernes.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxSabado.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			if(cbxDomingo.Checked==true)
				dia=dia+"1";
			else
				dia=dia+"0";
			
			return dia;
		}
		
		#endregion
		
		void CbxJuevesCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		public void agreagarRuta()
		{
			if(formEmpresa!=null)
			{
				string minuto=(Convert.ToInt16(numMinuto.Text)<10)? "0"+numMinuto.Text:numMinuto.Text;
				string hora=(Convert.ToInt32(numHora.Text)<10)?"0"+numHora.Text+":"+minuto:numHora.Text+":"+minuto;
				string idZona=new Conexion_Servidor.Zona.SQL_Zona().getIdZona(cmbZona.Text);
				
				Int64 idruta = new Conexion_Servidor.Ruta.SQL_Ruta().getIDRuta();
				
				if(cbEntrada.Checked==true && cbSalida.Checked==true)
				{
					formEmpresa.dtgEmpresas.Rows.Add("0", formEmpresa.nomEmpresa, (idruta-1).ToString(), "Operador", hora, "00:00", txtNombre.Text, "00:00", false, "0", idruta.ToString(), "Operador", hora,"00:00",txtNombre.Text,"00:00", false, "0", "0", "0", "", "0", "0", "0", "", "", "");
				}
				else
				{
					if(cbEntrada.Checked==true)
						formEmpresa.dtgEmpresas.Rows.Add("0", formEmpresa.nomEmpresa, idruta.ToString(), "Operador", hora, "00:00", txtNombre.Text, "00:00", false, "", "", "", "", "", " ", "", false, "0", "0", "0", "", "0", "0", "0", "", "", "");
					
					if(cbSalida.Checked==true)
						formEmpresa.dtgEmpresas.Rows.Add( "0",formEmpresa.nomEmpresa, "", "", "", "", "", "", false, "0", idruta.ToString(), "Operador", hora,"00:00",txtNombre.Text,"00:00", false, "0", "0", "0", "", "0", "0", "0", "", "", "");
					
					
					formEmpresa.refPrincipal.mueve2(formEmpresa);
				}
			}
		}
		
		public void cargaTurno()
		{
			for(int x=0; x<cmbTurno.Items.Count; x++)
			{
				if(cmbTurno.Items[x].ToString()==formEmpresa.refPrincipal.ConsTurno.ToString())
				{
					cmbTurno.SelectedIndex=x;
				}
			}
		}
	}
}
