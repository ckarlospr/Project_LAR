using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Ruta
{
	public partial class FormRutasExtras : Form
	{
		public FormRutasExtras(Interfaz.Operaciones.FormEmpresasOperaciones formEmp, Int64 idSubEmp)
		{
			InitializeComponent();
			formEmpresa = formEmp;
			idSubEmpresa = idSubEmp;
		}
		
		#region VARIABLES
		private Int64 idSubEmpresa;
		private int bandera=0;
		String idOrden="0";
		
		Double KILOMETROS;
		Double sencCam;
		Double compCam;
		Double sencCta;
		Double compCta;
		Double sencFor;
		Double compFor;
		#endregion
		
		#region INSTANCIAS
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Interfaz.Operaciones.FormEmpresasOperaciones formEmpresa = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormRutasExtrasLoad(object sender, EventArgs e)
		{
			for(int x=0; x<cmbTurno.Items.Count; x++)
			{
				if(cmbTurno.Items[x].ToString()==formEmpresa.refPrincipal.ConsTurno.ToString())
				{
					cmbTurno.SelectedIndex=x;
				}
			}
			
			txtDestino.AutoCompleteCustomSource = auto.AutoReconocimiento("select Nombre dato from RUTA where TIPO='NRM' or TIPO='VL' or TIPO='DIF' group by Nombre");
			txtDestino.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtDestino.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtAutoriza.AutoCompleteCustomSource = auto.AutoReconocimiento("select AUTORIZA dato from SERV_DOMICILIADO");
			txtAutoriza.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAutoriza.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUsuario.AutoCompleteCustomSource = auto.AutoReconocimiento("select usuario dato from SERV_DOMICILIADO");
			txtUsuario.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			getSubnombres();
		}
		#endregion
		
		#region GETSUBNOMBRES
		void getSubnombres()
		{
			String consulta=" select DATO, ID_ORDEN from Cliente where ID="+idSubEmpresa;
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtSubNombre.Text=conn.leer["DATO"].ToString();
				idOrden=conn.leer["ID_ORDEN"].ToString();
				
			}
			conn.conexion.Close();
			
			txtSubNombre.AutoCompleteCustomSource = auto.AutoReconocimiento("select DATO dato from Cliente where ID_ORDEN="+idOrden);
			txtSubNombre.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtSubNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdAgregarClick(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtDestino.Text=="")
			{
				MessageBox.Show("Inserte nombre destino de la ruta.");
				txtDestino.SelectAll();
			}
			else if(txtCantidad.Text=="" || txtCantidad.Text=="0")
			{
				MessageBox.Show("Ingrese cantidad de servicios.");
				txtCantidad.SelectAll();
			}
			else if(txtHora.Text.Length<5)
			{
				MessageBox.Show("Hora incorrecta.");
				txtHora.SelectAll();
			}			
			else if(txtHora.Text=="00:00")
			{
				MessageBox.Show("Hora incorrecta.");
				txtHora.SelectAll();
			}
			else if(cbDomiciliada.Checked==true)
			{
				if(txtAutoriza.Text=="")
				{
					MessageBox.Show("Ingrese el nombre que autoriza.");
					txtAutoriza.SelectAll();
				}
				else if(dgUsuarios.Rows.Count==0)
				{
					MessageBox.Show("Ingrese usuario.");
					txtUsuario.SelectAll();
				}
				else 
				{
					if(validaHora()){
						for(int x=0; x<Convert.ToInt16(txtCantidad.Text); x++)
						{
							if(cbEntrada.Checked==true)
								guardaRutaDom("Entrada");
							if(cbSalida.Checked==true)
								guardaRutaDom("Salida");
							
							agregaRuta();
							formEmpresa.refPrincipal.nuevoTamanio();
						}
						formEmpresa.refPrincipal.getEmpresasOrden2();
					}else{
						errorProvider1.SetError(txtHora, "Error el horario no coincide con el turno del despacho");
						txtHora.Focus();
					}
				}
			}
			else
			{
				if(validaHora()){
					for(int x=0; x<Convert.ToInt16(txtCantidad.Text); x++)
					{
						if(cbEntrada.Checked==true)
							guardaRutaExt("Entrada");
						if(cbSalida.Checked==true)
							guardaRutaExt("Salida");
						
						agregaRuta();
						formEmpresa.refPrincipal.nuevoTamanio();
					}
					formEmpresa.refPrincipal.getEmpresasOrden2();
				}else{
					errorProvider1.SetError(txtHora, "Error el horario no coincide con el turno del despacho");
					txtHora.Focus();
				}
			}
		}
		#endregion
		
		#region EVENTO CHECKBOK DOMICILIADA
		void CbDomiciliadaCheckedChanged(object sender, EventArgs e)
		{
			if(cbDomiciliada.Checked==true)
			{
				gbDatosDom.Enabled=true;
				txtCantidad.Text="1";
				txtCantidad.Enabled=false;
			}
			else
			{
				gbDatosDom.Enabled=false;
				txtCantidad.Enabled=true;
				txtAutoriza.Text="";
				txtUsuario.Text="";
				txtTelefono.Text="";
				txtDomicilio.Text="";
				txtColonia.Text="";
				txtComentario.Text="Comentario";
				cmdEliminarUsuario.Enabled=false;
				dgUsuarios.Rows.Clear();
			}
		}
		#endregion
		
		#region METODO PARA LA HORA
		void TxtHoraKeyPress(object sender, KeyPressEventArgs e)
		{
			if(Char.IsNumber(e.KeyChar))
			{
				if(bandera==0)
				{
					if(Convert.ToInt16(e.KeyChar.ToString())<3)
						e.Handled=false;
					else if(Convert.ToInt16(e.KeyChar.ToString())>2)
					{
						e.Handled=true;
						txtHora.Text="0"+e.KeyChar.ToString();
					}
					
					bandera=1;
				}
				else if(txtHora.Text.Length==1)
				{
					if(txtHora.Text=="1" || txtHora.Text=="0")
						e.Handled=false;
					else if(txtHora.Text=="2" && Convert.ToInt16(e.KeyChar.ToString())<4)
						e.Handled=false;
					else
						e.Handled=true;
				}
				else if(txtHora.Text.Length==2 && Convert.ToInt16(e.KeyChar.ToString())<6)
				{
					e.Handled=true;
					txtHora.Text=txtHora.Text+":"+e.KeyChar.ToString();
				}
				else if(txtHora.Text.Length==4)
				{
					e.Handled=true;
					txtHora.Text=txtHora.Text+e.KeyChar.ToString();
				}
				else
				{
					txtHora.SelectAll();
					e.Handled=true;
				}
			}
			else if(e.KeyChar == (char)Keys.Back)
			{
				txtHora.Text="";
				bandera=0;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void TxtHoraClick(object sender, EventArgs e)
		{
			txtHora.SelectAll();
			bandera=0;
		}
		
		void TxtComentarioClick(object sender, EventArgs e)
		{
			txtComentario.SelectAll();
		}
		#endregion
		
		#region VALIDACION TXTCANTIDAD
		void TxtCantidadKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!(Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
				e.Handled=true;
		}
		#endregion
		
		#region INSERTAR RUTA
		bool guardaRutaExt(String sentido)
		{
			bool respuesta=false;
			
			String diaExtra = formEmpresa.DIA_DESPACHO.Substring(0,2);
			String mesExtra = formEmpresa.DIA_DESPACHO.Substring(3,2);
			String anioExtra = formEmpresa.DIA_DESPACHO.Substring(6,4);
			
			String miFecha = anioExtra+"-"+mesExtra+"-"+diaExtra;
			//String TIPO="";
						
			if(new Conexion_Servidor.Ruta.SQL_Ruta().getInsertarExt("",
		                                                  idSubEmpresa.ToString(),
		                                                  txtDestino.Text,
		                                                  cmbTurno.Text,
		                                                  sentido,
		                                                  KILOMETROS.ToString(),
		                                                  txtHora.Text,
		                                                  "1",
		                                                  "N/A",
		                                                  ((cbForanea.Checked==true)?1:0),
		                                                  miFecha.ToString(),
		                                                  sencCam.ToString(),
		                                                  compCam.ToString(),
		                                                  sencCta.ToString(),
		                                                  compCta.ToString(),
		                                                  sencFor.ToString(),
		                                                  compFor.ToString(),
		                                                  "EXT", 
		                                                  ((cbVelada.Checked==true)?1:0), 
		                                                  ((cbCobrar.Checked==true)?1:0),
		                                                  txtDescripcion.Text)==true)
			{
				respuesta=true;
			}
						
			return respuesta;
		}
		
		bool guardaRutaDom(String sentido)
		{
			bool respuesta=false;
			
			String diaExtra = formEmpresa.DIA_DESPACHO.Substring(0,2);
			String mesExtra = formEmpresa.DIA_DESPACHO.Substring(3,2);
			String anioExtra = formEmpresa.DIA_DESPACHO.Substring(6,4);
			
			String miFecha = anioExtra+"-"+mesExtra+"-"+diaExtra;
			//String TIPO="";
			
			if(new Conexion_Servidor.Ruta.SQL_Ruta().getInsertarDom("",
		                                                  idSubEmpresa.ToString(),
		                                                  txtDestino.Text,
		                                                  cmbTurno.Text,
		                                                  sentido,
		                                                  KILOMETROS.ToString(),
		                                                  txtHora.Text,
		                                                  "1",
		                                                  "",
		                                                  ((cbForanea.Checked==true)?1:0),
		                                                  miFecha.ToString(),
		                                                  sencCam.ToString(),
		                                                  compCam.ToString(),
		                                                  sencCta.ToString(),
		                                                  compCta.ToString(),
		                                                  sencFor.ToString(),
		                                                  compFor.ToString(),
		                                                  "DOM",
		                                                  txtAutoriza.Text, 
		                                                  txtUsuario.Text, 
		                                                  txtDomicilio.Text,
		                                                  txtColonia.Text,
		                                                  txtTelefono.Text, 
		                                                  txtComentario.Text, 
		                                                  formEmpresa.refPrincipal.principal.idUsuario,
		                                                  ((cbVelada.Checked==true)?1:0), 
		                                                  ((cbCobrar.Checked==true)?1:0))==true)
			{
				for(int n=0; n<dgUsuarios.Rows.Count; n++)
				{
					string conss = "INSERT INTO SERV_DOMICILIADO VALUES ((SELECT MAX(ID) FROM RUTA), '"+txtAutoriza.Text+"', '"+dgUsuarios[1,n].Value.ToString()+"', '"+dgUsuarios[3,n].Value.ToString()+"', '"+dgUsuarios[4,n].Value.ToString()+"', '"+dgUsuarios[2,n].Value.ToString()+"', '"+dgUsuarios[5,n].Value.ToString()+"', '"+formEmpresa.refPrincipal.principal.idUsuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (time, SYSDATETIME())))";
					conn.getAbrirConexion(conss);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				respuesta=true;
			}
			
			return respuesta;
		}
		
		void agregaRuta()
		{
			Int64 idruta = new Conexion_Servidor.Ruta.SQL_Ruta().getIDRuta();
			
			if(cbEntrada.Checked==true && cbSalida.Checked==true)
			{
				formEmpresa.dtgEmpresas.Rows.Add("0", formEmpresa.nomEmpresa, (idruta-1).ToString(), "Operador", txtHora.Text, "00:00", txtDestino.Text, "00:00", false, "0", idruta.ToString(), "Operador", txtHora.Text,"00:00",txtDestino.Text,"00:00", false, "0", "0", "0", "", "0", "0", "0", "", "", "", txtSubNombre.Text);
			}
			else
			{
				if(cbEntrada.Checked==true)
					formEmpresa.dtgEmpresas.Rows.Add("0", formEmpresa.nomEmpresa, idruta.ToString(), "Operador", txtHora.Text, "00:00", txtDestino.Text, "00:00", false, "", "", "", "", "", " ", "", false, "0", "0", "0", "", "0", "0", "0", "", "", "", txtSubNombre.Text);
				
				if(cbSalida.Checked==true)
					formEmpresa.dtgEmpresas.Rows.Add( "0",formEmpresa.nomEmpresa, "", "", "", "", "", "", false, "0", idruta.ToString(), "Operador", txtHora.Text,"00:00",txtDestino.Text,"00:00", false, "0", "0", "0", "", "0", "0", "0", "", "", "", txtSubNombre.Text);
			}
			
			formEmpresa.refPrincipal.mueve2(formEmpresa);
			
			this.Close();
		}
		#endregion
		
		#region EVENTOS RADIO BUTTON
		void RbNormalCheckedChanged(object sender, EventArgs e)
		{
			if(rbNormal.Checked==true)
			{
				KILOMETROS = 20;
		 		sencCam = 65;
		 		compCam = 85;
		 		sencCta = 50;
		 		compCta = 60;
		 		sencFor = 65;
		 		compFor = 85;
			}
		}
		
		void RbMedianaCheckedChanged(object sender, EventArgs e)
		{
			if(rbMediana.Checked==true)
			{
				KILOMETROS = 40;
		 		sencCam = 70;
		 		compCam = 90;
		 		sencCta = 60;
		 		compCta = 70;
		 		sencFor = 70;
		 		compFor = 90;
			}
		}
		
		void RbLargaCheckedChanged(object sender, EventArgs e)
		{
			if(rbLarga.Checked==true)
			{
				KILOMETROS = 60;
		 		sencCam = 75;
		 		compCam = 95;
		 		sencCta = 70;
		 		compCta = 90;
		 		sencFor = 75;
		 		compFor = 95;
			}
		}
		
		void RbExtLargaCheckedChanged(object sender, EventArgs e)
		{
			if(rbExtLarga.Checked==true)
			{
				KILOMETROS = 80;
		 		sencCam = 90;
		 		compCam = 110;
		 		sencCta = 90;
		 		compCta = 100;
		 		sencFor = 90;
		 		compFor = 110;
			}
		}
		
		void RbPendienteCheckedChanged(object sender, EventArgs e)
		{
			if(rbPendiente.Checked==true)
			{
				KILOMETROS = 0;
		 		sencCam = 0;
		 		compCam = 0;
		 		sencCta = 0;
		 		compCta = 0;
		 		sencFor = 0;
		 		compFor = 0;
			}
		}
		#endregion
		
		#region AUTOCOMPLETE DATOS USUARIOS
		void TxtSubNombreKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta=" select ID from Cliente where DATO='"+txtSubNombre.Text+"' and ID_ORDEN="+idOrden;
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idSubEmpresa=Convert.ToInt64(conn.leer["ID"].ToString());
				}
				conn.conexion.Close();
			}
		}
		
		void CmdEliminarUsuarioClick(object sender, EventArgs e)
		{
			if(dgUsuarios.SelectedRows.Count>0)
			{
				dgUsuarios.Rows.RemoveAt(dgUsuarios.CurrentRow.Index);
				dgUsuarios.ClearSelection();
			}
		}
		
		void CmdAgregarUsuarioClick(object sender, EventArgs e)
		{
			if(txtUsuario.Text=="")
			{
				MessageBox.Show("Ingrese nombre del usuario");
			}
			else
			{
				dgUsuarios.Rows.Add("", txtUsuario.Text, txtTelefono.Text, txtDomicilio.Text, txtColonia.Text, ((txtComentario.Text=="Comentario")?"":txtComentario.Text));
				dgUsuarios.ClearSelection();
				txtUsuario.Text="";
				txtTelefono.Text="";
				txtColonia.Text="";
				txtDomicilio.Text="";
				txtComentario.Text="Comentario";
				dgUsuarios.ClearSelection();
			}
		}
		#endregion
		
		#region CARGA DE DATOS
		void TxtAutorizaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta="SELECT * FROM SERV_DOMICILIADO where AUTORIZA='"+txtAutoriza.Text+"'";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtUsuario.Text=conn.leer["USUARIO"].ToString();
					txtTelefono.Text=conn.leer["TELEFONO"].ToString();
					txtDomicilio.Text=conn.leer["DOMICILIO"].ToString();
					txtColonia.Text=conn.leer["COLONIA"].ToString();
				}
				conn.conexion.Close();
			}
		}
		
		void TxtUsuarioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta="SELECT * FROM SERV_DOMICILIADO where USUARIO='"+txtUsuario.Text+"'";
				
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtTelefono.Text=conn.leer["TELEFONO"].ToString();
					txtDomicilio.Text=conn.leer["DOMICILIO"].ToString();
					txtColonia.Text=conn.leer["COLONIA"].ToString();
				}
				conn.conexion.Close();
			}
		}
		#endregion
		
		void CbVeladaCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void GbDatosDomEnter(object sender, EventArgs e)
		{
			
		}
		
		#region VALIDA HORARIOS
		private bool validaHora(){
			bool respuesta = false;
			if(cmbTurno.Text == "Mañana"){
				if( Convert.ToDateTime(txtHora.Text) >= Convert.ToDateTime("03:00") &&  Convert.ToDateTime(txtHora.Text) <= Convert.ToDateTime("10:59"))
					respuesta = true;
			}
			if(cmbTurno.Text == "Medio día"){
				if( Convert.ToDateTime(txtHora.Text) >= Convert.ToDateTime("11:00") &&  Convert.ToDateTime(txtHora.Text) <= Convert.ToDateTime("15:59"))
					respuesta = true;
			}
			if(cmbTurno.Text == "Vespertino"){
				if( Convert.ToDateTime(txtHora.Text) >= Convert.ToDateTime("16:00") &&  Convert.ToDateTime(txtHora.Text) <= Convert.ToDateTime("18:59"))
					respuesta = true;
			}
			if(cmbTurno.Text == "Nocturno"){
				if( Convert.ToDateTime(txtHora.Text) >= Convert.ToDateTime("19:00") &&  Convert.ToDateTime(txtHora.Text) <= Convert.ToDateTime("23:59"))
					respuesta = true;	
				if( Convert.ToDateTime(txtHora.Text) >= Convert.ToDateTime("00:00") &&  Convert.ToDateTime(txtHora.Text) <= Convert.ToDateTime("02:59"))
					respuesta = true;
			}
			return respuesta;
		}
		#endregion
		
	}
}
