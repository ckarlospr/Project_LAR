using System;
using System.Drawing;
using System.Windows.Forms;
using Transportes_LAR.Conexion_Servidor;

namespace Transportes_LAR.Interfaz.Usuario
{
	public partial class FormUsuario : Form
	{
		private Interfaz.FormPrincipal principal=null;
		
		private String[,] cadena=null;
		private string id_usuario="";
		private String[] privilegio =null;
		private int contador=0,operacion=0;
		
		#region SOBRECARGA_DE_CONSTRUCTORES
		
		public FormUsuario(int operacion)
		{
			InitializeComponent();
			this.operacion=operacion;
		}
		
		public FormUsuario(int operacion,Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.operacion=operacion;
			this.principal=principal;
		}
		
		public FormUsuario(int operacion,Interfaz.FormPrincipal principal, string id_usuario){
			InitializeComponent();
			new Conexion_Servidor.Usuario.SQL_Usuario().getCargarDatos(txtNombre,txtApellidoPaterno,txtApellidoMaterno,txtUsuario,txtContrasena,id_usuario, cmbNivelUsuario);
			privilegio=new Conexion_Servidor.Usuario.SQL_Usuario().getPrilvilegios(id_usuario);
			txtContrasenaRepeticion.Text=txtContrasena.Text;
			this.id_usuario=id_usuario;
		}
		
		#endregion
		
		//--EVENTO_INICIO_DE_INTERFAZ
		void FormUsuarioLoad(object sender, EventArgs e)
		{
			getContenidoPrivilegio();
			this.cadena=new string[7,3];
			cadena[0,2]="0";
			cadena[6,2]="0";
			this.MdiParent=principal;
		}
		
		#region EVENTOS_DE_LOS_BOTONES (AGREGAR_CANCELAR)

		void BtnAgregarClick(object sender, EventArgs e)
		{
			bool estado=true;
			if(new Operacion(this).getValidarCampo())
			{
				if(txtContrasena.Text!= txtContrasenaRepeticion.Text)
				{
					MessageBox.Show("Las contraseñas ingresadas no son idénticas.","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
					estado=false;
				}
				else
				{
					if(new Conexion_Servidor.Usuario.SQL_Usuario().getPersonaExistencia(txtNombre.Text,txtApellidoPaterno.Text,txtApellidoMaterno.Text) && new Conexion_Servidor.Usuario.SQL_Usuario().getUsuarioExistencia(txtUsuario.Text) || id_usuario!="")
					{
						if(!getVerificarPrivilegio(0))
						{
							DialogResult result= MessageBox.Show("¿Desea almacenar al usuario sin asignar privilegios?","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
							if(result==DialogResult.OK)
							{
								getCargarPrivilegio(0,0,0);
								if(id_usuario=="")
									new Interfaz.FormMensaje("Usuario almacenado.").Show();
								else
									new Interfaz.FormMensaje("Usuario modificado correctamente.").Show();
								
								new Conexion_Servidor.Usuario.SQL_Usuario().getInsertarUsuario(id_usuario,txtNombre.Text,txtApellidoPaterno.Text,txtApellidoMaterno.Text, txtUsuario.Text,txtContrasena.Text, cadena, cmbNivelUsuario);
								new Interfaz.Usuario.Operacion(this).getLimpiarCampo(dataPrivilegio);
							}
							else
							{
								estado=false;
							}
						}
						else
						{
							getCargarPrivilegio(0,0,0);
							
							if(id_usuario=="")
							{
								new Interfaz.FormMensaje("Usuario almacenado.").Show();
							}
							else
								new Interfaz.FormMensaje("Usuario modificar correctamente.").Show();
							
							new Conexion_Servidor.Usuario.SQL_Usuario().getInsertarUsuario(id_usuario,txtNombre.Text,txtApellidoPaterno.Text,txtApellidoMaterno.Text, txtUsuario.Text,txtContrasena.Text, cadena, cmbNivelUsuario);
							new Interfaz.Usuario.Operacion(this).getLimpiarCampo(dataPrivilegio);
						}
					}
					else
					{
						string mensaje=(new Conexion_Servidor.Usuario.SQL_Usuario().getUsuarioExistencia(txtUsuario.Text))?"La persona "+txtNombre.Text+" "+txtApellidoPaterno.Text+" "+txtApellidoMaterno.Text+" ya se encuentra registrado dentro del sistema.":"El nombre de usuario "+txtUsuario.Text+" ya se encuentra registrado en la base de datos.";
						MessageBox.Show(mensaje,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Stop);
						estado=false;
					}
				}
			}
			else
			{
				if(id_usuario=="")
				{
					MessageBox.Show("Para poder almacenar un nuevo usuario es necesario llenar todos los campos señalados con el color ROSA.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show("Para poder modificar al usuario es necesario llenar todos los campos señalados con el color ROSA.","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
				estado=false;
			}
			if(operacion==0 && estado)
			{
				this.Close();
			}
			else
			{
				estado=true;
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		#endregion
		
		#region CARGANDO_LISTA_DE_LOS_PRIVILEGIOS
		
		private void getContenidoPrivilegio()
		{
			dataPrivilegio.Rows.Add(false,"OPERADOR");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"UNIDAD");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"RUTA");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"ASEGURADORA");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"CLIENTE - EMPRESA");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"USUARIOS");
			dataPrivilegio.Rows.Add(false,"    Crear");
			dataPrivilegio.Rows.Add(false,"    Modificar");
			dataPrivilegio.Rows.Add(false,"    Eliminar");
			dataPrivilegio.Rows.Add(false,"SERVIDOR");
			dataPrivilegio.Rows.Add(false,"    Ver configuración");
			dataPrivilegio.Rows.Add(false,"    Modificar configuración");
			getCargarEstilo(0);
			if(id_usuario!="")
			{
				getCargarPrivilegio();
				this.btnAgregar.Text="Modificar";
			}
		}
		
		private Object getCargarEstilo(int contador)
		{
			contador=(contador==4)?3:contador;
			dataPrivilegio.Rows[contador].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
			dataPrivilegio.Rows[contador].DefaultCellStyle.ForeColor=Color.DarkBlue;
			dataPrivilegio.Rows[contador].DefaultCellStyle.BackColor = Color.LightSteelBlue;
			return (4+contador<=23)?getCargarEstilo(4+contador):null;
		}
		
		#endregion
		
		#region CAMBIO_DE_INTERFAZ (DATOS-PRIVILEGIOS
		private void getCambiarOpcion(int opcion){
			if(opcion==0){
				pnlPrivilegio.Visible=false;
			}else if(opcion==1){
				pnlPrivilegio.Visible=true;
			}
		}
		
		//--EVENTO_CAMBIO_DE_OPCION
		void ListViewItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e){
			getCambiarOpcion(Convert.ToInt16(e.ItemIndex.ToString()));
		}
		#endregion
		
		
		//--EVENTO_CLICK_EN_LA_CELDA
		void DataPrivilegioCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dataPrivilegio.CurrentCell.ColumnIndex==0)
			{
				dataPrivilegio[0,dataPrivilegio.CurrentRow.Index].Value=(dataPrivilegio[0,dataPrivilegio.CurrentRow.Index].Value.ToString()=="True")?false:true;
			}
			getCargarSeleccion1();
			getCargarSeleccion2();
		}
		
		#region VALIDANDO_CLICK_DE_PRIVILEGIO
		
		private void getCargarSeleccion1(){
			//OPERADOR
			if(dataPrivilegio.CurrentCell.ColumnIndex==0 && dataPrivilegio.CurrentRow.Index==0){
				dataPrivilegio[0,1].Value=(dataPrivilegio[0,0].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,2].Value=(dataPrivilegio[0,0].Value.ToString()=="True")?true:false;
			}
			//UNIDAD
			if(dataPrivilegio.CurrentCell.ColumnIndex==0 && dataPrivilegio.CurrentRow.Index==3){
				dataPrivilegio[0,4].Value=(dataPrivilegio[0,3].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,5].Value=(dataPrivilegio[0,3].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,6].Value=(dataPrivilegio[0,3].Value.ToString()=="True")?true:false;
			}
			//RUTA
			if(dataPrivilegio.CurrentCell.ColumnIndex==0 && dataPrivilegio.CurrentRow.Index==7){
				dataPrivilegio[0,8].Value  =(dataPrivilegio[0,7].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,9].Value  =(dataPrivilegio[0,7].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,10].Value =(dataPrivilegio[0,7].Value.ToString()=="True")?true:false;
			}
			if(dataPrivilegio.CurrentCell.ColumnIndex==0 && dataPrivilegio.CurrentRow.Index==11){
				dataPrivilegio[0,12].Value  =(dataPrivilegio[0,11].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,13].Value  =(dataPrivilegio[0,11].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,14].Value  =(dataPrivilegio[0,11].Value.ToString()=="True")?true:false;
			}
			if(dataPrivilegio.CurrentCell.ColumnIndex==0 && dataPrivilegio.CurrentRow.Index==15){
				dataPrivilegio[0,16].Value  =(dataPrivilegio[0,15].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,17].Value  =(dataPrivilegio[0,15].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,18].Value  =(dataPrivilegio[0,15].Value.ToString()=="True")?true:false;
			}
			if(dataPrivilegio.CurrentCell.ColumnIndex==0 && dataPrivilegio.CurrentRow.Index==19){
				dataPrivilegio[0,20].Value  =(dataPrivilegio[0,19].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,21].Value  =(dataPrivilegio[0,19].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,22].Value  =(dataPrivilegio[0,19].Value.ToString()=="True")?true:false;
			}
			if(dataPrivilegio.CurrentCell.ColumnIndex==0 && dataPrivilegio.CurrentRow.Index==23){
				dataPrivilegio[0,24].Value  =(dataPrivilegio[0,23].Value.ToString()=="True")?true:false;
				dataPrivilegio[0,25].Value  =(dataPrivilegio[0,23].Value.ToString()=="True")?true:false;
			}
		}
		
		#endregion
		
		//--EVENTO_SELECCION_3:HIJOS
		private void getCargarSeleccion2()
		{
			dataPrivilegio[0,0].Value=(dataPrivilegio[0,1].Value.ToString()=="True" && dataPrivilegio[0,2].Value.ToString()=="True")?true:false;
			dataPrivilegio[0,3].Value=(dataPrivilegio[0,4].Value.ToString()=="True" && dataPrivilegio[0,5].Value.ToString()=="True" && dataPrivilegio[0,6].Value.ToString()=="True")?true:false;
			dataPrivilegio[0,7].Value=(dataPrivilegio[0,8].Value.ToString()=="True" && dataPrivilegio[0,9].Value.ToString()=="True" && dataPrivilegio[0,10].Value.ToString()=="True")?true:false;
			dataPrivilegio[0,11].Value=(dataPrivilegio[0,12].Value.ToString()=="True" && dataPrivilegio[0,13].Value.ToString()=="True" && dataPrivilegio[0,14].Value.ToString()=="True")?true:false;
			dataPrivilegio[0,15].Value=(dataPrivilegio[0,16].Value.ToString()=="True" && dataPrivilegio[0,17].Value.ToString()=="True" && dataPrivilegio[0,18].Value.ToString()=="True")?true:false;
			dataPrivilegio[0,19].Value=(dataPrivilegio[0,20].Value.ToString()=="True" && dataPrivilegio[0,21].Value.ToString()=="True" && dataPrivilegio[0,22].Value.ToString()=="True")?true:false;
			dataPrivilegio[0,23].Value=(dataPrivilegio[0,24].Value.ToString()=="True" && dataPrivilegio[0,25].Value.ToString()=="True")?true:false;
		}
		
		
		#region ALGORITMO_CARGAR_PRIVILEGIOS
		private object getCargarPrivilegio(int contador,int puntero, int localizacion){
			if(puntero == getPuntero(dataPrivilegio[1,contador].Value.ToString(),puntero )){
				cadena[puntero,localizacion]=(dataPrivilegio[0,contador].Value.ToString()=="True")? (localizacion==0)?"1" : (localizacion==1)?"2":"3" : "0";
			}
			localizacion=(localizacion<2)? (puntero < getPuntero(dataPrivilegio[1,contador].Value.ToString(),puntero ))? 0 : ++localizacion : 0;
			return (contador<Convert.ToInt32(dataPrivilegio.Rows.Count.ToString())-1)? getCargarPrivilegio(++contador, getPuntero(dataPrivilegio[1,contador].Value.ToString(),puntero), localizacion) : null;
		}
		
		private int getPuntero(string texto, int puntero){
			//return (texto!= "    Crear")? (texto!= "    Modificar")? (texto!= "    Eliminar")? ++puntero : puntero : puntero : puntero;
			return (texto!= "    Crear")? (texto!= "    Modificar")? (texto!= "    Eliminar")? (texto!= "    Ver configuración")? (texto!= "    Modificar configuración")?++puntero : puntero : puntero : puntero : puntero : puntero;
		}
		#endregion
		
		//--VERIFICAR_LA_EXISTENCIA_DE_PRIVILEGIO
		private Boolean getVerificarPrivilegio(int contador)
		{
			return (contador<Convert.ToInt32(dataPrivilegio.Rows.Count.ToString())-1)?(dataPrivilegio[0,contador].Value.ToString()=="True")?true :getVerificarPrivilegio(++contador):false;
		}
		
		//--EVENTO_CLOSING
		void FormUsuarioFormClosing(object sender, FormClosingEventArgs e)
		{
			if(operacion==0){
				if(contador==0){
					contador++;
					if(new Conexion_Servidor.Usuario.SQL_Usuario().getCantidadUsuario()=="0")
					{
						DialogResult rs2 = MessageBox.Show("Si cierra la venta, la aplicación se cerrara totalmente debido a que no existe un usuario dentro de la base de dato para acceder al sistema. ¿Desea continuar con el cierre?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
						if (rs2 == DialogResult.Cancel){
							e.Cancel = true;
		           			contador=0;
						}else
		           			Application.Exit();
					}else{
						if(new Conexion_Servidor.Usuario.SQL_Usuario().getCantidadUsuario()=="1"){
							try{
								if(principal.Visible==false){
									new Interfaz.FormLogin().Show();
								}
							}catch{
								new Interfaz.FormLogin().Show();
							}	
						}	
					}
				}else if(contador==1){
					Application.Exit();
				}
			}else{
				principal.usuario=false;
			}
		}
		
		//--CARGAR_PRIVILEGIOS_DEL_USUARIO_ALMACENADO
		private void getCargarPrivilegio()
		{
			dataPrivilegio[0,0].Value=(privilegio[1].Substring(0,1)=="1" && privilegio[1].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,1].Value=(privilegio[1].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,2].Value=(privilegio[1].Substring(1,1)=="2")?true:false;
			
			dataPrivilegio[0,3].Value=(privilegio[0].Substring(0,1)=="1" && privilegio[0].Substring(1,1)=="2" && privilegio[0].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,4].Value=(privilegio[0].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,5].Value=(privilegio[0].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,6].Value=(privilegio[0].Substring(2,1)=="3")?true:false;
		
			dataPrivilegio[0,7].Value=(privilegio[2].Substring(0,1)=="1" && privilegio[2].Substring(1,1)=="2" && privilegio[2].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,8].Value=(privilegio[2].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,9].Value=(privilegio[2].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,10].Value=(privilegio[2].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,11].Value=(privilegio[3].Substring(0,1)=="1" && privilegio[3].Substring(1,1)=="2" && privilegio[3].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,12].Value=(privilegio[3].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,13].Value=(privilegio[3].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,14].Value=(privilegio[3].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,15].Value=(privilegio[4].Substring(0,1)=="1" && privilegio[4].Substring(1,1)=="2" && privilegio[4].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,16].Value=(privilegio[4].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,17].Value=(privilegio[4].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,18].Value=(privilegio[4].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,19].Value=(privilegio[5].Substring(0,1)=="1" && privilegio[5].Substring(1,1)=="2" && privilegio[5].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,20].Value=(privilegio[5].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,21].Value=(privilegio[5].Substring(1,1)=="2")?true:false;
			dataPrivilegio[0,22].Value=(privilegio[5].Substring(2,1)=="3")?true:false;
			
			dataPrivilegio[0,23].Value=(privilegio[6].Substring(0,1)=="1" && privilegio[6].Substring(1,1)=="2" && privilegio[6].Substring(2,1)=="3")?true:false;
			dataPrivilegio[0,24].Value=(privilegio[6].Substring(0,1)=="1")?true:false;
			dataPrivilegio[0,25].Value=(privilegio[6].Substring(1,1)=="2")?true:false;
		}
	}
}
