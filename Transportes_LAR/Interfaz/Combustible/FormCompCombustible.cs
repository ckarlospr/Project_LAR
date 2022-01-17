using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormCompCombustible : Form
	{
		public FormCompCombustible(FormPrincipal formPrinc)
		{
			InitializeComponent();
			refPrincipal=formPrinc;
		}
		
		#region VARIABLES
		bool otro = false;
		bool inicio = true;
		
		public bool respu = false;
		#endregion
		
		#region INSTANCIAS
		public FormPrincipal refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.SQL_Conexion conn2 = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		
		List<Interfaz.Combustible.Datos.DatosMatriz> listMatrizBase = null;
		List<Interfaz.Combustible.Datos.DatosMatriz> listMatrizBaseX = null;
		List<Interfaz.Combustible.Datos.DatosMatriz> listMatrizBaseY = null;
		#endregion
		
		#region EVENTO LOAD
		void FormCompCombustibleLoad(object sender, EventArgs e)
		{
			getRandimientos();
			getDatosFactor();
			
			getCargarValidacionCampos(this);
			getGasolineras();
			getPrecios();
			cmTipo.SelectedIndex=0;
			getUnidades();
			
			//getMatriz();
			inicio=false;
		}
		#endregion
		
		#region VALIDACION
		private void getCargarValidacionCampos(FormCompCombustible formRef)
		{
			formRef.txtTelefono.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyOtros);
			formRef.txtPrecio.KeyPress						+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
		}
		#endregion
		
		#region EVENTOS BOTONES
		void CmdOtroClick(object sender, EventArgs e)
		{
			otro=true;
			dgContactos.Rows.Add("0", txtContacto.Text, txtTelefono.Text);
			txtContacto.Text="";
			txtTelefono.Text="";
		}
		
		void CmdNuevoGasClick(object sender, EventArgs e)
		{
			cmdGuardarGas.Enabled=true;
			cmdModificarGas.Enabled=false;
			cmdEliminarGas.Enabled=false;
			dgGasolinera.ClearSelection();
			txtEmpresa.Text="";
			txtNombreGas.Text="";
			txtMunicipio.Text="";
			txtColonia.Text="";
			txtDomicilio.Text="";
			txtContacto.Text="";
			txtTelefono.Text="";
			dgContactos.Rows.Clear();
		}
		
		void CmdModificarGasClick(object sender, EventArgs e)
		{
			modificar();
			limpiarComponentes();
			getGasolineras();
			
			cmdGuardarGas.Enabled=true;
			dgGasolinera.ClearSelection();
			txtEmpresa.Text="";
			txtNombreGas.Text="";
			txtMunicipio.Text="";
			txtColonia.Text="";
			txtDomicilio.Text="";
			txtContacto.Text="";
			txtTelefono.Text="";
			dgContactos.Rows.Clear();
		}
		
		void CmdEliminarGasClick(object sender, EventArgs e)
		{
			dgGasolinera.Rows.RemoveAt(dgGasolinera.CurrentRow.Index);
		}
		
		void CmdGuardarGasClick(object sender, EventArgs e)
		{
			if(txtNombreGas.Text=="")
			{
				MessageBox.Show("Ingrese nombre de la gasilonera.");
				txtNombreGas.SelectAll();
			}
			else if(txtMunicipio.Text=="")
			{
				MessageBox.Show("Ingrese Municipio.");
				txtMunicipio.SelectAll();
			}
			else if(txtColonia.Text=="")
			{
				MessageBox.Show("Ingrese Colonia.");
				txtColonia.SelectAll();
			}
			else if(txtDomicilio.Text=="")
			{
				MessageBox.Show("Ingrese domicilio.");
				txtDomicilio.SelectAll();
			}
			else if(dgContactos.Rows.Count==0 && txtContacto.Text=="" && txtTelefono.Text=="")
			{
				MessageBox.Show("Ingrese almenos un contacto con telefono.");
				txtContacto.SelectAll();
			}
			else if(txtContacto.Text!="" && txtTelefono.Text!="")
			{
				guarda(1);
			}
			else if(dgContactos.Rows.Count>0)
			{
				guarda(2);
			}
			else
			{
				MessageBox.Show("Ingrese almenos un contacto con telefono.");
				txtContacto.SelectAll();
			}
		}
		#endregion
		
		#region GUARDADO DE DATOS
		void guarda(int dato)
		{
			if(dato==1)
			{
				new Conexion_Servidor.Combustible.SQL_Combustible().guardaGasolinera(txtEmpresa.Text, txtNombreGas.Text, txtMunicipio.Text, txtColonia.Text, txtDomicilio.Text);
				new Conexion_Servidor.Combustible.SQL_Combustible().guardaContacto(txtContacto.Text, txtTelefono.Text);
			}
			else
			{
				new Conexion_Servidor.Combustible.SQL_Combustible().guardaGasolinera(txtEmpresa.Text, txtNombreGas.Text, txtMunicipio.Text, txtColonia.Text, txtDomicilio.Text);
				for(int x=0; x<dgContactos.RowCount; x++)
				{
					new Conexion_Servidor.Combustible.SQL_Combustible().guardaContacto(dgContactos[1,x].Value.ToString(), dgContactos[2,x].Value.ToString());
				}
			}
			limpiarComponentes();
			getGasolineras();
		}
		#endregion
		
		#region LIMPIA DATOS
		void limpiarComponentes()
		{
			txtEmpresa.Text="";
			txtNombreGas.Text="";
			txtMunicipio.Text="";
			txtColonia.Text="";
			txtDomicilio.Text="";
			txtContacto.Text="";
			txtTelefono.Text="";
			dgContactos.Rows.Clear();
		}
		#endregion
		
		#region GET GASOLINERAS
		void getGasolineras()
		{
			dgGasolinera.Rows.Clear();
			String consulta = "select * from GASOLINERA";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgGasolinera.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString(), conn.leer["SUBNOMBRE"].ToString(), "", "", conn.leer["MUNICIPIO"].ToString() +", "+ conn.leer["COLONIA"].ToString()+", "+ conn.leer["DIRECCION"].ToString());
			}
			
			conn.conexion.Close();
			
			if(dgGasolinera.Rows.Count>0)
			{
				for(int x=0; x<dgGasolinera.Rows.Count; x++)
				{
					consulta = "select * from CONTACTO_GASOLINERA where ID_G="+dgGasolinera[0,x].Value.ToString();
				
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgGasolinera[3,x].Value=conn.leer["NUMERO"].ToString();
						dgGasolinera[4,x].Value=conn.leer["CONTACTO"].ToString();
					}
					conn.conexion.Close();
				}
			}
			
			dgGasolinera.ClearSelection();
		}
		#endregion
		
		#region UPDATE GASOLINERAS
		void modificar()
		{
			new Conexion_Servidor.Combustible.SQL_Combustible().modificaGasolinera(txtEmpresa.Text, txtNombreGas.Text, txtMunicipio.Text, txtColonia.Text, txtDomicilio.Text, Convert.ToInt16(dgGasolinera[0,dgGasolinera.CurrentRow.Index].Value));
			
			if(txtContacto.Text!="" && txtTelefono.Text!="")
			{
				new Conexion_Servidor.Combustible.SQL_Combustible().guardaContactoNuevo(txtContacto.Text, txtTelefono.Text, Convert.ToInt16(dgGasolinera[0,dgGasolinera.CurrentRow.Index].Value));
			}
			
			if(dgContactos.Rows.Count>0)
			{
				for(int x=0; x<dgContactos.Rows.Count; x++)
				{
					if(dgContactos[0,x].Value.ToString()=="")
					{
						//new Conexion_Servidor.Combustible.SQL_Combustible().guardaContactoNuevo(txtContacto.Text, txtTelefono.Text, Convert.ToInt16(dgGasolinera[0,dgGasolinera.CurrentRow.Index].Value));
						new Conexion_Servidor.Combustible.SQL_Combustible().guardaContactoNuevo(dgContactos[1,x].Value.ToString(), dgContactos[2,x].Value.ToString(), Convert.ToInt16(dgGasolinera[0,dgGasolinera.CurrentRow.Index].Value));
					}
					else
					{
						new Conexion_Servidor.Combustible.SQL_Combustible().modificaContacto(dgContactos[1,x].Value.ToString(), dgContactos[2,x].Value.ToString(), Convert.ToInt16(dgContactos[0,x].Value));
					}
				}
			}
		}
			
		#region SELECCION
		void DgGasolineraCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)
			{
				cmdGuardarGas.Enabled=false;
				cmdModificarGas.Enabled=true;
				cmdEliminarGas.Enabled=true;
				
				txtEmpresa.Text=dgGasolinera[1,e.RowIndex].Value.ToString();
				txtNombreGas.Text=dgGasolinera[2,e.RowIndex].Value.ToString();
				
				String consulta = "select * from GASOLINERA where ID="+dgGasolinera[0,e.RowIndex].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtMunicipio.Text=conn.leer["MUNICIPIO"].ToString();
					txtColonia.Text=conn.leer["COLONIA"].ToString();
					txtDomicilio.Text=conn.leer["DIRECCION"].ToString();
				}
				conn.conexion.Close();
				
				dgContactos.Rows.Clear();
				
				consulta = "select * from CONTACTO_GASOLINERA where ID_G="+dgGasolinera[0,e.RowIndex].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgContactos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["CONTACTO"].ToString(), conn.leer["NUMERO"].ToString());
				}
				conn.conexion.Close();
				
				dgContactos.ClearSelection();
			}
		}
		#endregion
		#endregion
		
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///////////////////////////////////////////////////// PRECIOS //////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region ALL PRECIOS		
			#region EVENTOS BOTONES PRECIOS
			void CmdNuevoPrecClick(object sender, EventArgs e)
			{
				getPrecios();
				txtNombrePrec.Text="";
				txtPrecio.Text="";
				cmdModificarPrec.Enabled=false;
				cmdGuardarPrec.Enabled=true;
				cmdEliminarPrec.Enabled=false;
			}
			
			void CmdGuardarPrecClick(object sender, EventArgs e)
			{
				if(txtNombrePrec.Text=="")
				{
					MessageBox.Show("Ingresar nombre del combustible.");
					txtNombrePrec.Focus();
				}
				else if(txtPrecio.Text=="")
				{
					MessageBox.Show("Ingresar precio del combustible.");
					txtPrecio.Focus();
				}
				else
				{
					guardaPrec();
					getPrecios();
					txtNombrePrec.Text="";
					txtPrecio.Text="";
				}
			}
			
			void CmdModificarPrecClick(object sender, EventArgs e)
			{
				if(txtNombrePrec.Text=="")
				{
					MessageBox.Show("Ingresar nombre del combustible.");
					txtNombrePrec.Focus();
				}
				else if(txtPrecio.Text=="")
				{
					MessageBox.Show("Ingresar precio del combustible.");
					txtPrecio.Focus();
				}
				else
				{
					modificaPrec();
					getPrecios();
					txtNombrePrec.Text="";
					txtPrecio.Text="";
				}
			}
			
			void CmdEliminarPrecClick(object sender, EventArgs e)
			{
				dgPrecios.Rows.RemoveAt(dgPrecios.CurrentRow.Index);
			}
			#endregion
			
			#region GUARDAR Y MODIFICA PRECIOS
			void guardaPrec()
			{
				new Conexion_Servidor.Combustible.SQL_Combustible().guardaPrecios(txtNombrePrec.Text, txtPrecio.Text, refPrincipal.idUsuario);
			}
			
			void modificaPrec()
			{
				new Conexion_Servidor.Combustible.SQL_Combustible().modificaPrecios(txtNombrePrec.Text, txtPrecio.Text, Convert.ToInt16(dgPrecios[0,dgPrecios.CurrentRow.Index].Value), refPrincipal.idUsuario);
			}
			#endregion
			
			#region GET PRECIOS
			void getPrecios()
			{
				dgPrecios.Rows.Clear();
				
				String consulta = "select T.ID, T.NOMBRE, P.PRECIO from TIPOS_COMB T, PRECIOS_COMB P WHERE T.ID=P.ID_TC and P.ESTATUS='1'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgPrecios.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString(), conn.leer["PRECIO"].ToString());
				}
				conn.conexion.Close();
				
				dgPrecios.ClearSelection();
			}
			#endregion
			
			#region EVENTO CELLCLICK DGPRECIOS
		void DgPreciosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void DgPreciosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtNombrePrec.Text=dgPrecios[1,dgPrecios.CurrentRow.Index].Value.ToString();
			txtPrecio.Text=dgPrecios[2,dgPrecios.CurrentRow.Index].Value.ToString();
			cmdGuardarPrec.Enabled=false;
			cmdModificarPrec.Enabled=true;
			cmdEliminarPrec.Enabled=true;
		}
		#endregion		
		#endregion
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////// PUNTOS MUERTOS //////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region ALL PUNTOS MUERTOS
			#region SELECCION DE TIPO
			void CmTipoSelectedIndexChanged(object sender, EventArgs e)
			{
				txtMovimiento.Text="";
				
				dgPrincRuta.Columns[1].HeaderText=cmTipo.Text;
				
				if(cmTipo.Text=="EMPRESA")
				{
					txtMovimiento.AutoCompleteCustomSource = auto.AutoReconocimiento("SELECT NOMBRE Dato FROM GENERAL_CLIENTE where ID not in (select ID_R from RELACION_UBICACION where TIPO='EMPRESA')");
					txtMovimiento.AutoCompleteMode =AutoCompleteMode.Suggest;
					txtMovimiento.AutoCompleteSource = AutoCompleteSource.CustomSource;
					
					dgPrincRuta.Enabled=true;
					dgPrincRuta.Rows.Clear();
					dgRutas.Rows.Clear();
					dgRutas.Enabled=false;
					
					String consulta = "SELECT * FROM GENERAL_CLIENTE where ID not in (select ID_R from RELACION_UBICACION where TIPO='EMPRESA' and ESTATUS='1')";
				
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgPrincRuta.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString());
					}
					
					conn.conexion.Close();
					dgPrincRuta.ClearSelection();
				}
				else if(cmTipo.Text=="GASOLINERA")
				{
					txtMovimiento.AutoCompleteCustomSource = auto.AutoReconocimiento("select SUBNOMBRE dato from GASOLINERA where ID not in (select ID_R from RELACION_UBICACION where TIPO='GASOLINERA')");
					txtMovimiento.AutoCompleteMode =AutoCompleteMode.Suggest;
					txtMovimiento.AutoCompleteSource = AutoCompleteSource.CustomSource;
					
					dgPrincRuta.Enabled=true;
					dgPrincRuta.Rows.Clear();
					dgRutas.Rows.Clear();
					dgRutas.Enabled=false;
					
					String consulta = "select * from GASOLINERA where ID not in (select ID_R from RELACION_UBICACION where TIPO='GASOLINERA' and ESTATUS='1')";
				
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgPrincRuta.Rows.Add(conn.leer["ID"].ToString(), conn.leer["SUBNOMBRE"].ToString());
					}
					
					conn.conexion.Close();
					dgPrincRuta.ClearSelection();
				}	
				else if(cmTipo.Text=="OFICINA")
				{
					txtMovimiento.AutoCompleteCustomSource = null;
					dgPrincRuta.Rows.Clear();
					dgRutas.Rows.Clear();
					dgRutas.Enabled=false;
					dgPrincRuta.Enabled=false;
				}
				else if(cmTipo.Text=="ZONA")
				{
					txtMovimiento.AutoCompleteCustomSource = null;
					dgPrincRuta.Rows.Clear();
					dgRutas.Rows.Clear();
					dgRutas.Enabled=false;
					dgPrincRuta.Enabled=false;
				}			
				else if(cmTipo.Text=="RUTA")
				{
					txtMovimiento.AutoCompleteCustomSource = auto.AutoReconocimiento("select R.Nombre dato from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and (R.TIPO='NRM' or R.TIPO='DIF' or R.TIPO='VL' or R.TIPO='RI') and Dia!='10000000' and R.ID not in (select ID_R from RELACION_UBICACION where TIPO='RUTA') group by R.Nombre order by R.Nombre");
					txtMovimiento.AutoCompleteMode =AutoCompleteMode.Suggest;
					txtMovimiento.AutoCompleteSource = AutoCompleteSource.CustomSource;
					
					dgPrincRuta.Enabled=true;
					dgRutas.Enabled=true;
					dgRutas.Rows.Clear();
					dgPrincRuta.Rows.Clear();
					
					
					String consulta = "select R.Nombre from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and (R.TIPO='NRM' or R.TIPO='DIF' or R.TIPO='VL' or R.TIPO='RI') and Dia!='10000000' and R.ID not in (select ID_R from RELACION_UBICACION where TIPO='RUTA' and ESTATUS='1')  group by R.Nombre order by R.Nombre"; 
																																											
				    
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgPrincRuta.Rows.Add("", conn.leer["Nombre"].ToString());
					}
					
					conn.conexion.Close();
					dgPrincRuta.ClearSelection();
				}	
				else if(cmTipo.Text=="TALLER")
				{
					txtMovimiento.AutoCompleteCustomSource = null;
					dgPrincRuta.Rows.Clear();
					dgRutas.Rows.Clear();
					dgPrincRuta.Enabled=false;
					dgRutas.Enabled=false;
				}
				else if(cmTipo.Text=="VIVIENDA")
				{
					txtMovimiento.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' and ID not in (select ID_R from RELACION_UBICACION where TIPO='VIVIENDA')");
					txtMovimiento.AutoCompleteMode =AutoCompleteMode.Suggest;
					txtMovimiento.AutoCompleteSource = AutoCompleteSource.CustomSource;
					
					dgPrincRuta.Enabled=true;
					dgPrincRuta.Rows.Clear();
					dgRutas.Enabled=false;
					
					String consulta = "select * from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' and ID not in (select ID_R from RELACION_UBICACION where TIPO='VIVIENDA' and ESTATUS='1') ORDER BY Alias";
				
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgPrincRuta.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString());
					}
					
					conn.conexion.Close();
					dgPrincRuta.ClearSelection();
				}
			}
			#endregion
			
			#region 
			void TxtMovimientoKeyUp(object sender, KeyEventArgs e)
			{
				if(e.KeyCode.ToString()=="Return")
				{
					//if(cmTipo.Text=="RUTA")
					//{
						dgRutas.ClearSelection();
						
						for(int x=0; x<dgPrincRuta.Rows.Count; x++)
						{
							if(dgPrincRuta[1,x].Value.ToString()==txtMovimiento.Text)
							{
								dgPrincRuta.Rows[x].Selected = true;
								dgPrincRuta.FirstDisplayedCell = dgPrincRuta.Rows[x].Cells[1];
								getRutas(dgPrincRuta[1,x].Value.ToString());
							}
						}
					//}
				}
			}
			
			void DgPrincRutaCellClick(object sender, DataGridViewCellEventArgs e)
			{
				getRutas(dgPrincRuta[1,e.RowIndex].Value.ToString());
				
				if(cmTipo.Text!="RUTA"){					
					String dat="";
					/*if(cmTipo.Text=="EMPRESA")				
						dat="EMP";				
					else if(cmTipo.Text=="GASOLINERA")				
						dat="GAS";				
					else if(cmTipo.Text=="OFICINA")
						dat="OF";				
					else if(cmTipo.Text=="TALLER")
						dat="TALLER";
					else if(cmTipo.Text=="VIVIENDA")
						dat="OP";
					else if(cmTipo.Text=="ZONA")
						dat="ZONA";	*/			
					txtMovimiento.Text=dat+" "+dgPrincRuta[1,e.RowIndex].Value.ToString();
				}else{
					txtMovimiento.Text="";
				}
			}
			
			void getRutas(String ruta)
			{
				if(cmTipo.Text=="RUTA")
				{
					dgRutas.Enabled=true;
					dgRutas.Rows.Clear();
					String consulta = "select C.Empresa, C.tipo_cobro, C.SubNombre, R.ID, R.Nombre, R.Sentido, R.Turno, R.TIPO from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and (R.TIPO='NRM' or R.TIPO='DIF' or R.TIPO='VL' or R.TIPO='RI') and Dia!='10000000' and R.nombre='"+dgPrincRuta[1,dgPrincRuta.CurrentRow.Index].Value.ToString()+"' AND R.ID NOT IN (select ID_R from RELACION_UBICACION where TIPO='RUTA') order by R.Nombre";
				
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dgRutas.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Empresa"].ToString(), conn.leer["tipo_cobro"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["Sentido"].ToString(), conn.leer["Turno"].ToString());
					}
					
					conn.conexion.Close();
					dgRutas.ClearSelection();
				}
				else
				{
					dgRutas.Enabled=false;
				}
			}
			#endregion
			
			#region INGRESAR MOVIMIENTO
			void CmdAddMovimientoClick(object sender, EventArgs e)
			{
				if(txtMovimiento.Text != "" && txtMovimiento.Text != " "){
					validaMovimiento();
					//getUltimo();
					txtMovimiento.Focus();
					if(cmTipo.Text == "RUTA" && dgRutas.SelectedRows.Count == 1){
						if(dgRutas.Rows.Count==0){
							dgPrincRuta.Rows.RemoveAt(dgPrincRuta.CurrentRow.Index);
							dgPrincRuta.ClearSelection();
						}
					}
				}else{
					MessageBox.Show("Ingrese nombre para la asignación");
				}
				txtMovimiento.Text="";
			}
			
			void validaMovimiento()
			{
				if(cmTipo.Text=="OFICINA" || cmTipo.Text=="TALLER" || cmTipo.Text=="ZONA"){
					guardaUbicacion(txtMovimiento.Text, cmTipo.Text, "0");
					dgPrincRuta.ClearSelection();
				}else if(cmTipo.Text=="RUTA"){
					if(dgRutas.SelectedRows.Count>0){
						guardaUbicacion(txtMovimiento.Text, cmTipo.Text, dgRutas[0,dgRutas.CurrentRow.Index].Value.ToString());
						dgRutas.Rows.RemoveAt(dgRutas.CurrentRow.Index);
						dgRutas.ClearSelection();
					}else{
						DialogResult rs = MessageBox.Show("La ruta no fue seleccionada desde la tabla de rutas, se guardara sin ID de ruta ¿Desea continuar?", "Alerta Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (DialogResult.Yes==rs)
							guardaUbicacion(txtMovimiento.Text, cmTipo.Text, "0");
					}
				}else{
					guardaUbicacion(txtMovimiento.Text, cmTipo.Text, dgPrincRuta[0,dgPrincRuta.CurrentRow.Index].Value.ToString());
					dgPrincRuta.Rows.RemoveAt(dgPrincRuta.CurrentRow.Index);
					dgPrincRuta.ClearSelection();
				}
			}
			
			void guardaUbicacion(String nombre, String tipo, String ID)
			{
				String sentencia = "insert into RELACION_UBICACION values ("+((ID=="0")?"null":ID)+", '"+nombre+"', '"+tipo+"', '1')";				
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				guardaMatriz();
			}
			#endregion
			
		void BtnPuntosClick(object sender, EventArgs e)
		{
			new FormMovimientos(this, refPrincipal.idUsuario).ShowDialog();
		}
		
		void BtnCargarMatrizClick(object sender, EventArgs e)
		{
			getMatriz();
		}
		#endregion
		
		//************************************************     MATRIZ     **************************************************
		
		#region [GET MATRIZ]
		public List<Interfaz.Combustible.Datos.DatosMatriz> getDatosMatriz2(Int64 idDat)
		{
			List<Interfaz.Combustible.Datos.DatosMatriz> listMatriz=new List<Interfaz.Combustible.Datos.DatosMatriz>();
			
			String consult = " SELECT * FROM MOVIMIENTO WHERE ESTATUS='1' and ID_X="+idDat;
			
			conn.getAbrirConexion(consult);
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Interfaz.Combustible.Datos.DatosMatriz datos = new Interfaz.Combustible.Datos.DatosMatriz();
				datos.X	= conn.leer["ID_X"].ToString();
				datos.Y	= conn.leer["ID_Y"].ToString();
				datos.km = conn.leer["KM"].ToString();
				listMatriz.Add(datos);
			}
			conn.conexion.Close();
			
			return (listMatriz.Count>0)?listMatriz:null;
		}
		
		public List<Interfaz.Combustible.Datos.DatosMatriz> getDatosMatriz()
		{
			List<Interfaz.Combustible.Datos.DatosMatriz> listMatriz=new List<Interfaz.Combustible.Datos.DatosMatriz>();
			
			String consult = "SELECT * FROM MOVIMIENTO WHERE ESTATUS='1' ";
			
			conn.getAbrirConexion(consult);
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Interfaz.Combustible.Datos.DatosMatriz datos = new Interfaz.Combustible.Datos.DatosMatriz();
				datos.X	= conn.leer["ID_X"].ToString();
				datos.Y	= conn.leer["ID_Y"].ToString();
				datos.km = conn.leer["KM"].ToString();
				listMatriz.Add(datos);
			}
			conn.conexion.Close();
			
			return (listMatriz.Count>0)?listMatriz:null;
		}
		
		public List<Interfaz.Combustible.Datos.DatosMatriz> getDatosMatrizX()
		{
			List<Interfaz.Combustible.Datos.DatosMatriz> listMatriz=new List<Interfaz.Combustible.Datos.DatosMatriz>();
			
			String consult = "SELECT * FROM RELACION_UBICACION WHERE ESTATUS='1' ";
			
			conn.getAbrirConexion(consult);
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Interfaz.Combustible.Datos.DatosMatriz datos = new Interfaz.Combustible.Datos.DatosMatriz();
				datos.X	= conn.leer["ID"].ToString();
				listMatriz.Add(datos);
			}
			conn.conexion.Close();
			
			return (listMatriz.Count>0)?listMatriz:null;
		}
		
		void guardaMatriz()
		{
			listMatrizBaseX = getDatosMatrizX();
			
			if(listMatrizBaseX!=null)
			{
				Int64 ID_ULTIMO = 0; 
				String consult = "SELECT MAX(ID) ID FROM RELACION_UBICACION";
				conn.getAbrirConexion(consult);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()==true)
				{
					ID_ULTIMO = Convert.ToInt64(conn.leer["ID"]);
				}
				conn.conexion.Close();
				
				for(int x=0; x<listMatrizBaseX.Count-1; x++)
				{
					String sentencia = "insert into MOVIMIENTO values ("+listMatrizBaseX[x].X+", "+ID_ULTIMO+", '0', '1',"+refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
				
					conn2.getAbrirConexion(sentencia);
					conn2.comando.ExecuteNonQuery();
					conn2.conexion.Close();
				}
				
				for(int x=0; x<listMatrizBaseX.Count; x++)
				{
					String sentencia = "insert into MOVIMIENTO values ("+ID_ULTIMO+", "+listMatrizBaseX[x].X+", '0', '1',"+refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
				
					conn2.getAbrirConexion(sentencia);
					conn2.comando.ExecuteNonQuery();
					conn2.conexion.Close();
				}
				
				
				
				
				/*for(int x=0; x<listMatrizBaseX.Count; x++)
				{
					for(int y=0; y<listMatrizBaseX.Count; y++)
					{
						//Int64 ID_U = 0;
						String consult = "SELECT * FROM MOVIMIENTO WHERE ID_X='"+listMatrizBaseX[x].X+"' AND ID_Y='"+listMatrizBaseX[y].X+"'";
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read()==false)
						{
							String sentencia = "insert into MOVIMIENTO values ("+listMatrizBaseX[x].X+", "+listMatrizBaseX[y].X+", '0', '1',"+refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
				
							conn2.getAbrirConexion(sentencia);
							conn2.comando.ExecuteNonQuery();
							conn2.conexion.Close();
						}
						conn.conexion.Close();
					}
				}*/
			}
			else
			{
				String sentencia = "insert into MOVIMIENTO values (1, 1, '0', "+refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))";
				
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
		}
		
		void getUltimo()
		{
			
			String consulta = "SELECT * FROM RELACION_UBICACION where ID = (SELECT MAX(ID) FROM RELACION_UBICACION) and ESTATUS='1'";
		
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				DataGridViewTextBoxColumn txt = new DataGridViewTextBoxColumn();
				txt.Name = conn.leer["ID"].ToString();
			    txt.HeaderText = conn.leer["NOMBRE"].ToString();
				dgPuntosMuertos.Columns.Add(txt);
				
				dgPuntosMuertos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString());
				
				for(int x=0; x<dgPuntosMuertos.Rows.Count; x++)
				{
					dgPuntosMuertos[(dgPuntosMuertos.Columns.Count-1),x].Value="0.00";
				}
				
				for(int x=2; x<dgPuntosMuertos.Columns.Count; x++)
				{
					dgPuntosMuertos[x,(dgPuntosMuertos.Rows.Count-1)].Value="0.00";
				}
			}
			
			conn.conexion.Close();
			dgPuntosMuertos.ClearSelection();
		}
		
		void getMatriz()
		{
			if(dgPuntosMuertos.Columns.Count>0)
			{
				dgPuntosMuertos.Columns.Clear();
			}
			
			DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
			columna.Name = "ID_M";
		    columna.HeaderText = "ID";
		    columna.ReadOnly = true;
			columna.Visible = false;
			dgPuntosMuertos.Columns.Add(columna);
			
			StringFormat l_objformat = new StringFormat();
			
			DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
			columna2.Name = "nombre_m";
		    columna2.HeaderText = "*" ;
		    columna2.DefaultCellStyle.BackColor = Color.LightBlue;
		    columna2.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		    columna2.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
		    columna2.ReadOnly = true;
			columna2.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dgPuntosMuertos.Columns.Add(columna2);
			
			
			dgPuntosMuertos.Rows.Clear();
			String consulta = "select * from RELACION_UBICACION where ESTATUS='1' ORDER BY NOMBRE ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				DataGridViewTextBoxColumn txt = new DataGridViewTextBoxColumn();
				txt.Name = conn.leer["ID"].ToString();
			    txt.HeaderText = conn.leer["NOMBRE"].ToString();
			    txt.SortMode = DataGridViewColumnSortMode.NotSortable;
				dgPuntosMuertos.Columns.Add(txt);
				
				txt.FillWeight = 0.1f;

				dgPuntosMuertos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["NOMBRE"].ToString());
			}
			
			conn.conexion.Close();
			dgPuntosMuertos.ClearSelection();
			
			
			/**************************************** LLAMADO DE LOS KILOMETROS **********************************************/
			
			listMatrizBase = getDatosMatriz();
			
			//BARRIDO PARA JALAR UNO POR UNO
			/*if(listMatrizBase!=null)
			{
				for(int x=0; x<dgPuntosMuertos.Rows.Count; x++)
				{
					for(int y=2; y<dgPuntosMuertos.Columns.Count; y++)
					{
						for(int z=0; z<listMatrizBase.Count; z++)
						{
							//MessageBox.Show(dgPuntosMuertos[0,x].Value.ToString()+"=="+listMatrizBase[z].X +"&&"+ dgPuntosMuertos.Columns[y].Name+"=="+listMatrizBase[z].Y);
							
							if(dgPuntosMuertos[0,x].Value.ToString()==listMatrizBase[z].X && dgPuntosMuertos.Columns[y].Name==listMatrizBase[z].Y)
							{
								//MessageBox.Show(y+","+x+"..............Entro");
								dgPuntosMuertos[y,x].Value=listMatrizBase[z].km;
								if(listMatrizBase[z].km=="0.00")
									dgPuntosMuertos[y,x].Style.BackColor=Color.MediumSpringGreen;
							}
						}
					}
				}
			}*/
			if(listMatrizBase!=null)
			{
				for(int x=0; x<dgPuntosMuertos.Rows.Count; x++)
				{
					listMatrizBase = getDatosMatriz2(Convert.ToInt64(dgPuntosMuertos[0,x].Value));
					for(int y=2; y<dgPuntosMuertos.Columns.Count; y++)
					{
						for(int z=0; z<listMatrizBase.Count; z++)
						{
							if(dgPuntosMuertos.Columns[y].Name==listMatrizBase[z].Y)
							{
								dgPuntosMuertos[y,x].Value=listMatrizBase[z].km;
								if(listMatrizBase[z].km=="0.00")
									dgPuntosMuertos[y,x].Style.BackColor=Color.MediumSpringGreen;
							}
						}
					}
				}
			}
		}		
		#endregion
		
		#region [TEXTO DE DATAGRID EN SENTIDO VERTICAL]
		void DgPuntosMuertosCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			StringFormat l_objformat = new StringFormat();

            ///////////////////////////////////////////////////////////////
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);

               //////////////////////////////////////////////////////////////////
                e.PaintBackground(e.ClipBounds, true);
  				Rectangle rect = this.dgPuntosMuertos.GetColumnDisplayRectangle (e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
               
  				/*if (this.dgPuntosMuertos.ColumnHeadersHeight < titleSize.Width)
                    this.dgPuntosMuertos.ColumnHeadersHeight = titleSize.Width;*/
              
                rect.X += 0;
                rect.Y += 0;
                
                l_objformat.FormatFlags = StringFormatFlags.DirectionVertical;
                e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font, Brushes.Black, rect, l_objformat);
                e.Handled = true;//This is required, else the original painting of the data grid view overwrites the changes.
                
                if(e.ColumnIndex>1)
                	dgPuntosMuertos.Columns[e.ColumnIndex].Width=60;
            }
		}
		#endregion
		
		// *****************************************************************************************************************
		
		#region GUARDADO DE KILIMETRAJES MUERTOS
		void CmdGuardaKmClick(object sender, EventArgs e)
		{
			bool Errores = false;
			for(int x=0; x<dgPuntosMuertos.Rows.Count; x++)
			{
				for(int y=2; y<dgPuntosMuertos.Columns.Count; y++)
				{
					if(dgPuntosMuertos[y,x].Style.BackColor.Name=="Yellow")//dgPuntosMuertos[y,x].Value.ToString()!="0.00" && dgPuntosMuertos[y,x].Value.ToString()!="0" && dgPuntosMuertos[y,x].Value.ToString()!="00" && dgPuntosMuertos[y,x].Value.ToString()!=".")
					{
						bool entra = false;
						String datito =dgPuntosMuertos[y,x].Value.ToString();
			
						for(int z=0; z<datito.Length; z++)
						{
							if(char.IsControl(datito.Substring(z,1),0))
							{
								//MessageBox.Show("->"+datito.Substring(x,1)+"<-");
								entra = true;
							}
						}
						
						String sentencia="";
						
						if(entra==false)
						{
							sentencia = "update MOVIMIENTO set KM='"+dgPuntosMuertos[y,x].Value.ToString()+"' where ID_X="+dgPuntosMuertos[0,x].Value.ToString()+" and ID_Y="+dgPuntosMuertos.Columns[y].Name;//************************************************   PENDIENTE
							dgPuntosMuertos[y,x].Style.BackColor=Color.White;
						}
						else
						{
							sentencia = "update MOVIMIENTO set KM='"+dgPuntosMuertos[y,x].Value.ToString().Substring(0,Convert.ToString(dgPuntosMuertos[y,x].Value).Length-1)+"' where ID_X="+dgPuntosMuertos[0,x].Value.ToString()+" and ID_Y="+dgPuntosMuertos.Columns[y].Name;//************************************************   PENDIENTE
							dgPuntosMuertos[y,x].Style.BackColor=Color.White;
						}
						
						try
						{
							conn.getAbrirConexion(sentencia);
							conn.comando.ExecuteNonQuery();
						}
						catch(Exception)
						{
							dgPuntosMuertos[y,x].Style.BackColor=Color.Red;
							Errores = true;
						}
						finally
						{
							conn.conexion.Close();
						}
					}
					else if((dgPuntosMuertos[y,x].Value.ToString()=="" || dgPuntosMuertos[y,x].Value.ToString()=="  " || dgPuntosMuertos[y,x].Value.ToString()=="0" || dgPuntosMuertos[y,x].Value.ToString()=="00" || dgPuntosMuertos[y,x].Value.ToString()==".") && dgPuntosMuertos[y,x].Style.BackColor.Name!="Red" )
					{
						dgPuntosMuertos[y,x].Value="0.00";
						dgPuntosMuertos[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
					else if(dgPuntosMuertos[y,x].Style.BackColor.Name=="Red")
					{
						dgPuntosMuertos[y,x].Value="0.00";
						dgPuntosMuertos[y,x].Style.BackColor=Color.MediumSpringGreen;
					}
				}
				dgPuntosMuertos.ClearSelection();
			}
			
			if(Errores==true){
				MessageBox.Show("Se ingresaron datos erroneos.");
			}else{
				MessageBox.Show("Se guardó correctamente la matriz");
			}
		}
		#endregion
		
		#region PEGADO DE INFORMACION EN DATAGRID CAMOBIOS DE COLOR EN LA VALIDACION
		void DgPuntosMuertosKeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control && e.KeyCode == Keys.V)
			{
				string s = Clipboard.GetText();
				string[] lines = s.Split('\n');
				int row = dgPuntosMuertos.CurrentCell.RowIndex;
				int col = dgPuntosMuertos.CurrentCell.ColumnIndex;
				foreach (string line in lines)
				{
					if (row < dgPuntosMuertos.RowCount && line.Length >0)
					{
						string[] cells = line.Split('\t');
						for (int i = 0; i < cells.GetLength(0); ++i)
						{
							if (col + i <this.dgPuntosMuertos.ColumnCount)
							{
								dgPuntosMuertos[col + i, row].Value = Convert.ChangeType(cells[i], dgPuntosMuertos[col + i, row].ValueType);
								//dgPuntosMuertos[col + i, row].Style.BackColor = Color.Yellow;
							}
							else
							{
								break;
							}
						}
						row++;
					}
					else
					{
						break;
					}
				}
			}
		}
		
		void DgPuntosMuertosCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(inicio==false)
			{
				if(e.RowIndex > -1 && e.ColumnIndex > 1){
					try{
						Convert.ToDouble(dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Value);
						dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Yellow;
					}catch(Exception){
						dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Value="0.00";
						dgPuntosMuertos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
					}
				}
			}
		}
		#endregion
		
		#region ACRONIMOS EXCLUSIVO RUTAS
		void DgRutasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				String Turno = "";
				String Sentido = "";
				String tipoUnidad = "";
				
				if(dgRutas[5,e.RowIndex].Value.ToString()=="Mañana")
					Turno="1";
				else if(dgRutas[5,e.RowIndex].Value.ToString()=="Medio día")
					Turno="2";
				else if(dgRutas[5,e.RowIndex].Value.ToString()=="Vespertino")
					Turno="3";
				else if(dgRutas[5,e.RowIndex].Value.ToString()=="Nocturno")
					Turno="4";
				
				if(dgRutas[4,e.RowIndex].Value.ToString()=="Entrada")
					Sentido="E";
				else
					Sentido="S";
				
				if(dgRutas[2,e.RowIndex].Value.ToString()=="CAMION")
					tipoUnidad="C";
				else
					tipoUnidad="T";
				
				
				txtMovimiento.Text = dgRutas[1,e.RowIndex].Value.ToString()+" "+tipoUnidad+" "+ dgRutas[3,e.RowIndex].Value.ToString()+" "+Turno+" "+Sentido;
			}
		}
		#endregion
		
		#region ELIMINAR REGISTRO DE MATRIZ
		void CmdEliminaClick(object sender, EventArgs e)
		{
			if(dgPuntosMuertos.SelectedCells.Count==1)
			{
				String sentencia = "UPDATE RELACION_UBICACION SET ESTATUS='0' WHERE ID="+dgPuntosMuertos[0,dgPuntosMuertos.CurrentRow.Index].Value.ToString();
					
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				sentencia = "UPDATE MOVIMIENTO SET ESTATUS='0' WHERE ID_X="+dgPuntosMuertos[0,dgPuntosMuertos.CurrentRow.Index].Value.ToString()+" or ID_Y="+dgPuntosMuertos[0,dgPuntosMuertos.CurrentRow.Index].Value.ToString();
					
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				
				for(int x=0; x<dgPuntosMuertos.CurrentCell.ColumnIndex;x++)
				{
					if(dgPuntosMuertos[0,dgPuntosMuertos.CurrentRow.Index].Value.ToString()==dgPuntosMuertos[x,dgPuntosMuertos.CurrentRow.Index].Value.ToString())
					{
						dgPuntosMuertos.Columns.RemoveAt(x);
						dgPuntosMuertos.Rows.RemoveAt(dgPuntosMuertos.CurrentRow.Index);
					}
				}
				
				dgPuntosMuertos.ClearSelection();
				cmdElimina.Enabled = false;
			}
			else
			{
				MessageBox.Show("Es necesario solo seleccionar un registro.");
			}
		}
		
		void DgPuntosMuertosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgPuntosMuertos.CurrentCell.ColumnIndex == 1 && dgPuntosMuertos.CurrentCell.RowIndex > -1)
				cmdElimina.Enabled=true;			
			else
				cmdElimina.Enabled=false;
		}
		#endregion
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/////////////////////////////////////////////////// RENDIMIENTOS  //////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			
		#region RENDIMIENTOS
		void getRandimientos()
		{
			dgRendTodo.Rows.Clear();
			
			String consulta = "SELECT * FROM VEHICULO where estatus='1' order by Numero";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgRendTodo.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString(), "", "", "");
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgRendTodo.Rows.Count; x++)
			{
				consulta = "SELECT R.*, V.Numero FROM RENDIMIENTOS R, VEHICULO V WHERE R.ID_V=V.ID and V.ID="+dgRendTodo[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="LOCAL")
						dgRendTodo[2,x].Value=conn.leer["FACTOR"].ToString();
					else if(conn.leer["TIPO"].ToString()=="FORANEO")
						dgRendTodo[3,x].Value=conn.leer["FACTOR"].ToString();
					else if(conn.leer["TIPO"].ToString()=="MANTENIMIENTO")
						dgRendTodo[4,x].Value=conn.leer["FACTOR"].ToString();
					else if(conn.leer["TIPO"].ToString()=="OPTIMO")
						dgRendTodo[5,x].Value=conn.leer["FACTOR"].ToString();
				}
				
				conn.conexion.Close();
			}
			dgRendTodo.ClearSelection();
			
		}
		
		void BtnGuardaTodoClick(object sender, EventArgs e)
		{
			for(int x=0; x<dgRendTodo.Rows.Count; x++)
			{
				bool LOCAL = false;
				bool FORANEA = false;
				bool MANTENIMIENTO = false;
				bool OPTIMO = false;
				
				String consulta = "SELECT R.*, V.Numero FROM RENDIMIENTOS R, VEHICULO V WHERE R.ID_V=V.ID and V.ID="+dgRendTodo[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					if(conn.leer["TIPO"].ToString()=="LOCAL")
						LOCAL=true;
					else if(conn.leer["TIPO"].ToString()=="FORANEO")
						FORANEA=true;
					else if(conn.leer["TIPO"].ToString()=="MANTENIMIENTO")
						MANTENIMIENTO=true;
					else if(conn.leer["TIPO"].ToString()=="OPTIMO")
						OPTIMO=true;
				}
				
				conn.conexion.Close();
			
				if(LOCAL==true && dgRendTodo[2,x].Value.ToString()!="")
				{
					try
					{
						Convert.ToDouble(dgRendTodo[2,x].Value);
						consulta = "update RENDIMIENTOS set FACTOR='"+dgRendTodo[2,x].Value.ToString()+"' where TIPO='LOCAL' and ID_V="+dgRendTodo[0,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
				else
				{
					try
					{
						Convert.ToDouble(dgRendTodo[2,x].Value);
						consulta = "INSERT INTO RENDIMIENTOS  VALUES ("+dgRendTodo[0,x].Value.ToString()+",'LOCAL','"+dgRendTodo[2,x].Value.ToString()+"')";
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
				
				if(FORANEA==true && dgRendTodo[3,x].Value.ToString()!="")
				{
					try
					{
						Convert.ToDouble(dgRendTodo[3,x].Value);
						consulta = "update RENDIMIENTOS set FACTOR='"+dgRendTodo[3,x].Value.ToString()+"' where TIPO='FORANEO' and ID_V="+dgRendTodo[0,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
				else
				{
					try
					{
						Convert.ToDouble(dgRendTodo[3,x].Value);
						consulta = "INSERT INTO RENDIMIENTOS  VALUES ("+dgRendTodo[0,x].Value.ToString()+",'FORANEO','"+dgRendTodo[3,x].Value.ToString()+"')";
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
				
				if(MANTENIMIENTO==true && dgRendTodo[4,x].Value.ToString()!="")
				{
					try
					{
						Convert.ToDouble(dgRendTodo[4,x].Value);
						consulta = "update RENDIMIENTOS set FACTOR='"+dgRendTodo[4,x].Value.ToString()+"' where TIPO='MANTENIMIENTO' and ID_V="+dgRendTodo[0,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
				else
				{
					try
					{
						Convert.ToDouble(dgRendTodo[4,x].Value);
						consulta = "INSERT INTO RENDIMIENTOS  VALUES ("+dgRendTodo[0,x].Value.ToString()+",'MANTENIMIENTO','"+dgRendTodo[4,x].Value.ToString()+"')";
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
				
				if(OPTIMO==true && dgRendTodo[5,x].Value.ToString()!="")
				{
					try
					{
						Convert.ToDouble(dgRendTodo[5,x].Value);
						consulta = "update RENDIMIENTOS set FACTOR='"+dgRendTodo[5,x].Value.ToString()+"' where TIPO='OPTIMO' and ID_V="+dgRendTodo[0,x].Value.ToString();
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
				else
				{
					try
					{
						Convert.ToDouble(dgRendTodo[5,x].Value);
						consulta = "INSERT INTO RENDIMIENTOS  VALUES ("+dgRendTodo[0,x].Value.ToString()+",'OPTIMO','"+dgRendTodo[5,x].Value.ToString()+"')";
						conn.getAbrirConexion(consulta);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					catch(Exception)
					{
						
					}
				}
			}
			
			try{
				string sentencia = @"INSERT INTO AUDITORIA_GENERAL VALUES('UPDATE', 'EL USUARIO CAMBIO LOS RENDIEMINTOS DE LOS VEHICULOS',
									(SELECT CONVERT (DATE, SYSDATETIME())) , (SELECT CONVERT (TIME, SYSDATETIME())),"+refPrincipal.idUsuario+", 'RENDIMIENTOS')";
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}catch(Exception){}
					
			
			getRandimientos();
		}
		
		void BtnDesbloquearClick(object sender, EventArgs e)
		{
			new FormContrasena(this, "").ShowDialog();			
			if(respu){
				btnGuardaTodo.Enabled = true;
				dgRendTodo.Enabled = true;
				groupBox2.Enabled = true;	
				btnDesbloquear.Visible = false;
				btnBloquear.Visible = true;				
			}else{
				btnGuardaTodo.Enabled = false;
				dgRendTodo.Enabled = false;
				groupBox2.Enabled = false;
				btnDesbloquear.Visible = true;
				btnBloquear.Visible = false;	
			}
		}
		
		void BtnBloquearClick(object sender, EventArgs e)
		{
			btnGuardaTodo.Enabled = false;
			dgRendTodo.Enabled = false;
			groupBox2.Enabled = false;
			btnDesbloquear.Visible = true;
			btnBloquear.Visible = false;
			respu = false;			
		}
		#endregion
		
		
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////// DIAS DE CARGA  //////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		#region ALL DIAS DE CARGA
		void getUnidades()
		{
			dgDias.Rows.Clear();
			
			String consulta = "SELECT ID, Numero FROM VEHICULO where estatus='1' order by Numero";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDias.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Numero"].ToString());
			}
			
			conn.conexion.Close();
			
			for(int x=0; x<dgDias.Rows.Count; x++)
			{
				consulta = "select * from DIAS_CARGA where ID_V="+dgDias[0,x].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					dgDias[2,x].Value=((conn.leer["LUNES"].ToString()=="1")?"SI":"NO");
					dgDias[2,x].Style.BackColor=((conn.leer["LUNES"].ToString()=="1")?Color.LightGray:Color.White);
					
					dgDias[3,x].Value=((conn.leer["MARTES"].ToString()=="1")?"SI":"NO");
					dgDias[3,x].Style.BackColor=((conn.leer["MARTES"].ToString()=="1")?Color.LightGray:Color.White);
					
					dgDias[4,x].Value=((conn.leer["MIERCOLES"].ToString()=="1")?"SI":"NO");
					dgDias[4,x].Style.BackColor=((conn.leer["MIERCOLES"].ToString()=="1")?Color.LightGray:Color.White);
					
					dgDias[5,x].Value=((conn.leer["JUEVES"].ToString()=="1")?"SI":"NO");
					dgDias[5,x].Style.BackColor=((conn.leer["JUEVES"].ToString()=="1")?Color.LightGray:Color.White);
					
					dgDias[6,x].Value=((conn.leer["VIERNES"].ToString()=="1")?"SI":"NO");
					dgDias[6,x].Style.BackColor=((conn.leer["VIERNES"].ToString()=="1")?Color.LightGray:Color.White);
					
					dgDias[7,x].Value=((conn.leer["SABADO"].ToString()=="1")?"SI":"NO");
					dgDias[7,x].Style.BackColor=((conn.leer["SABADO"].ToString()=="1")?Color.LightGray:Color.White);
					
					dgDias[8,x].Value=((conn.leer["DOMINGO"].ToString()=="1")?"SI":"NO");
					dgDias[8,x].Style.BackColor=((conn.leer["DOMINGO"].ToString()=="1")?Color.LightGray:Color.White);
				}
				
				conn.conexion.Close();
			}
			
			dgDias.ClearSelection();
		}
		
		void BtnGuardarDiasClick(object sender, EventArgs e)
		{
			guardaDias();
		}
		
		void guardaDias()
		{
			if(dgDias.SelectedRows.Count>0)
			{
				for(int x=0; x<dgDias.Rows.Count; x++)
				{
					if(dgDias.Rows[x].Selected==true)
					{
						String sentencia = "EXECUTE INSERTA_DIAS "+dgDias[0,x].Value.ToString()+","+((cbLunes.Checked==true)?"1":"0")+","+((cbMartes.Checked==true)?"1":"0")+","+((cbMiercoles.Checked==true)?"1":"0")+","+((cbJueves.Checked==true)?"1":"0")+","+((cbViernes.Checked==true)?"1":"0")+","+((cbSabado.Checked==true)?"1":"0")+","+((cbDomingo.Checked==true)?"1":"0");
						
						conn.getAbrirConexion(sentencia);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
			}
			
			getUnidades();
		}
		
		void DgDiasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1 && dgDias.SelectedRows.Count==1)
			{
				String consulta = "select * from DIAS_CARGA where ID_V="+dgDias[0,e.RowIndex].Value.ToString();
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					cbLunes.Checked=((conn.leer["LUNES"].ToString()=="1")?true:false);
					cbMartes.Checked=((conn.leer["MARTES"].ToString()=="1")?true:false);
					cbMiercoles.Checked=((conn.leer["MIERCOLES"].ToString()=="1")?true:false);
					cbJueves.Checked=((conn.leer["JUEVES"].ToString()=="1")?true:false);
					cbViernes.Checked=((conn.leer["VIERNES"].ToString()=="1")?true:false);
					cbSabado.Checked=((conn.leer["SABADO"].ToString()=="1")?true:false);
					cbDomingo.Checked=((conn.leer["DOMINGO"].ToString()=="1")?true:false);
				}
				
				conn.conexion.Close();
			}
		}
		#endregion
		
		// **************************************************************************************************************************************************
		
		
		// **************************************************************************************************************************************************
		// *************************************************************** FACTOR DE COBROS *****************************************************************
		
		#region ALL FACTOR DE COBROS
		void getDatosFactor()
		{
			String consulta = "select * from FACTOR_COBRO where ESTATUS='1'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["NOMBRE"].ToString()=="LITROS")
					txtLitros.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="EFICIENCIA")
					txtEficiencia.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="KM")
					txtKmT.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="RENDIMIENTO")
					txtRend.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="MAYOR_EFICIENCIA")
					txtMayorEficiencia.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="MAYOR_KM")
					txtMayorKm.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="MINIMO_ET")
					txtMinET.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="MAXIMO_ET")
					txtMaxET.Text=conn.leer["FACTOR"].ToString();
				
				if(conn.leer["NOMBRE"].ToString()=="LITROS_TICKETS")
					txtLitrosTickes.Text=conn.leer["FACTOR"].ToString();
			}
			
			conn.conexion.Close();
		}
		
		void BtnGuardaFactorClick(object sender, EventArgs e)
		{
			String sentencia = " UPDATE FACTOR_COBRO SET ESTATUS='0' WHERE NOMBRE='MAXIMO_ET' OR NOMBRE='MINIMO_ET' OR NOMBRE='EFICIENCIA' OR NOMBRE='LITROS' OR NOMBRE='RENDIMIENTO' OR NOMBRE='KM' OR NOMBRE='MENOR_EFICIENCIA' OR NOMBRE='MAYOR_EFICIENCIA' OR NOMBRE='MENOR_KM' OR NOMBRE='MAYOR_KM' ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('LITROS', '"+txtLitros.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('EFICIENCIA', '"+txtEficiencia.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('KM', '"+txtKmT.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('RENDIMIENTO', '"+txtRend.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('MAYOR_EFICIENCIA', '"+txtMayorEficiencia.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('MAYOR_KM', '"+txtMayorKm.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('MINIMO_ET', '"+txtMinET.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('MAXIMO_ET', '"+txtMaxET.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			sentencia = " INSERT INTO FACTOR_COBRO VALUES ('LITROS_TICKETS', '"+txtLitrosTickes.Text+"', '1', '"+refPrincipal.idUsuario+"', (SELECT CONVERT (DATETIME, SYSDATETIME()))) ";
			
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();	
				
			new Interfaz.FormMensaje("Factores de cobro guardados.").Show();
		}
		
		void TxtEficienciaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtEficiencia.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtLitrosKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitros.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtRendKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitros.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtKmTKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitros.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtMenorEficienciaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitros.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtMayorEficienciaKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitros.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtMenorKmKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitros.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtMayorKmKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitros.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtMinETKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtMinET.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtMaxETKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtMaxET.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtLitrosTickesKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtLitrosTickes.Text.Contains(".")==false))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		#endregion
		
		#region OTROS
		/*************************************************/
		
		void TxtEficienciaLeave(object sender, EventArgs e)
		{
			if(txtEficiencia.Text=="")
				txtEficiencia.Text="0";
		}
		
		void TxtLitrosLeave(object sender, EventArgs e)
		{
			if(txtLitros.Text=="")
				txtLitros.Text="0";
		}
		
		void TxtRendLeave(object sender, EventArgs e)
		{
			if(txtRend.Text=="")
				txtRend.Text="0";
		}
		
		void TxtKmTLeave(object sender, EventArgs e)
		{
			if(txtKmT.Text=="")
				txtRend.Text="0";
		}
		
		void TxtMayorEficienciaLeave(object sender, EventArgs e)
		{
			if(txtMayorEficiencia.Text=="")
				txtMayorEficiencia.Text="0";
		}
		
		void TxtMayorKmLeave(object sender, EventArgs e)
		{
			if(txtMayorKm.Text=="")
				txtMayorKm.Text="0";
		}
		
		void TxtEficienciaKeyUp(object sender, KeyEventArgs e)
		{
			if(txtEficiencia.Text!="")
			{
				txtRend.Text=Convert.ToString(100-Convert.ToDouble(txtEficiencia.Text));
			}
		}
		
		void TxtMinETLeave(object sender, EventArgs e)
		{
			if(txtMinET.Text=="")
				txtMinET.Text="0";
		}
		
		void TxtMaxETLeave(object sender, EventArgs e)
		{
			if(txtMaxET.Text=="")
				txtMaxET.Text="0";
		}
		
		void TxtLitrosTickesLeave(object sender, EventArgs e)
		{
			if(txtLitrosTickes.Text=="")
				txtLitrosTickes.Text="0";
		}
		
		// **************************************************************************************************************************************************
				
		void TxtBusquedaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Return"){
				dgPuntosMuertos.ClearSelection();
				for(int x=0; x<dgPuntosMuertos.Rows.Count; x++){
					if(txtBusqueda.Text == dgPuntosMuertos[1,x].Value.ToString()){
						dgPuntosMuertos.Rows[x].Selected = true;
						dgPuntosMuertos.FirstDisplayedCell = dgPuntosMuertos.Rows[x].Cells[1];
					}
				}
			}
			else if(txtBusqueda.Text.Length == 3){
				dgPuntosMuertos.ClearSelection();
				for(int x=0; x<dgPuntosMuertos.Rows.Count; x++){
					if(txtBusqueda.Text == dgPuntosMuertos[1,x].Value.ToString()){
						dgPuntosMuertos.Rows[x].Selected = true;
						dgPuntosMuertos.FirstDisplayedCell = dgPuntosMuertos.Rows[x].Cells[1];
					}
				}
			}
		}
		
		
		void TcComplementosSelectedIndexChanged(object sender, EventArgs e)
		{
			txtBusqueda.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"select nombre from RELACION_UBICACION where ESTATUS = '1'", "nombre");
           	txtBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
            
			if(tcComplementos.SelectedIndex == 3)
				inicioPreciosGas();
		}
		
		void DgPuntosMuertosCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == 1){
				new FormModificarMovimiento(this, dgPuntosMuertos[0, e.RowIndex].Value.ToString()).ShowDialog();
			}
		}		
		#endregion
		
		#region PRECIOS COMBUSTIBLE POR GASOLINERAS
		
		 #region METODOS
			private void inicioPreciosGas(){		
				dtpInicioGasolinera.Value = DateTime.Now;
				
				txtBusquedaGasolinera.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA");
				txtBusquedaGasolinera.AutoCompleteMode =AutoCompleteMode.Suggest;
				txtBusquedaGasolinera.AutoCompleteSource = AutoCompleteSource.CustomSource;
				filtrosPreciosGas();
			}
		 
			private void ColoresAlternadosRows(DataGridView datag){
				datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
				datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
			}
			
			private bool GuardaPrecios(){
				bool respuesta = true;
				for(int x=0; x<dgPreciosGas.RowCount; x++){
					if(dgPreciosGas[2,x].Value.ToString() != "SIN REGISTRO" && dgPreciosGas[3,x].Value.ToString() != "SIN REGISTRO"
					   && dgPreciosGas[4,x].Value.ToString() != "SIN REGISTRO"){
						if(dgPreciosGas[2,x].Style.BackColor != Color.Red && dgPreciosGas[3,x].Style.BackColor != Color.Red && 
						   dgPreciosGas[4,x].Style.BackColor != Color.Red && dgPreciosGas[5,x].Style.BackColor != Color.Red &&
						   dgPreciosGas[6,x].Style.BackColor != Color.Red ){
							
							if( !(ValidaExiste(dgPreciosGas[2,x].Value.ToString(), dgPreciosGas[3,x].Value.ToString(), dgPreciosGas[4,x].Value.ToString(), 
							                   dgPreciosGas[5,x].Value.ToString(), dgPreciosGas[6,x].Value.ToString(), dgPreciosGas[0,x].Value.ToString())) ){
								try{
									string consulta = @"insert into PRECIOS_GASOLINERA (ID_GASOLINERA, MAGNA, PREMIUM, DIESEL, FECHA_REG, HORA_REG, NUMERO, ID_USUARIO, ESTATUS) 
									values ('"+dgPreciosGas[0,x].Value.ToString()+"', '"+dgPreciosGas[2,x].Value.ToString()+"', '"+dgPreciosGas[3,x].Value.ToString()
										+"', '"+dgPreciosGas[4,x].Value.ToString()+"', '"+dgPreciosGas[5,x].Value.ToString()+"', '"+dgPreciosGas[6,x].Value.ToString()
										+"', '"+obtenerNumero(dgPreciosGas[0,x].Value.ToString())+"', "+refPrincipal.idUsuario+", 'Activo')";
									conn.getAbrirConexion(consulta);
									conn.comando.ExecuteNonQuery();
									conn.conexion.Close();
								}catch(Exception ex){
									x = dgPreciosGas.RowCount;
									respuesta = false;
									MessageBox.Show("Error guardar los precios del combustible: "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);	
								}finally{
									if(conn.conexion != null)
										conn.conexion.Close();
								}
							}
														
						}
					}						
				}
				return respuesta;
			}
		 
		 	private Boolean EsFecha(String fecha){
			    try{
			        DateTime.Parse(fecha);
			        return true;
			    }catch{
			        return false;
			    }
			}
			
			private Boolean EsPrecio(String fecha){
			    try{
			        Double.Parse(fecha);
			        return true;
			    }catch{
			        return false;
			    }
			}
		 
			public int obtenerNumero(string id_P){			
				int numero = 0;
				conn.getAbrirConexion("select MAX(NUMERO) NUMERO from PRECIOS_GASOLINERA WHERE ID_GASOLINERA = "+id_P);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read()){					
					try{
						numero = Convert.ToInt32(conn.leer["NUMERO"]);
					}catch (Exception){
						numero = 0;
					}
				}
				conn.conexion.Close();			 
				return numero+1;
			}
		 
			 public bool ValidaExiste(string MAGNA, string PREMIUM, string DIESEL, string FECHA_REG, string HORA_REG, string id_g){			
				bool respuesta = true;
				string consulta = @"select * from PRECIOS_GASOLINERA where ESTATUS = 'ACTIVO' and MAGNA = '"+MAGNA+"' and PREMIUM = '"+PREMIUM
								 +"' and DIESEL = '"+DIESEL+"' and FECHA_REG = '"+FECHA_REG+"' and HORA_REG = '"+HORA_REG+"' and ID_GASOLINERA = "+id_g;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){	
					respuesta = true;
				}else{
					respuesta = false;
				}
				conn.conexion.Close();			 
				return respuesta;
			}
		 
		 #endregion
		 
		 #region FILTROS - ADAPTADOR		 
			public void filtrosPreciosGas(){
				string consulta = "";
		 	
				if(cbTodasGasolinera.Checked == true){
					consulta = "select g.NOMBRE, pg.* from GASOLINERA g JOIN PRECIOS_GASOLINERA pg on pg.ID_GASOLINERA = g.id where g.nombre like '%"+txtBusquedaGasolinera.Text
						+"%' and FECHA_REG between '"+dtpInicioGasolinera.Value.ToShortDateString()+"' and '"+dtpFinGasolinera.Value.ToShortDateString()+"'";
				}else{
					consulta = "select id, NOMBRE from GASOLINERA where nombre like '%"+txtBusquedaGasolinera.Text+"%'";
				}
				
				int contador = 0;	
				try{
					ColoresAlternadosRows(dgPreciosGas);
					dgPreciosGas.Rows.Clear();	
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read()){
						if(cbTodasGasolinera.Checked == true){
							dgPreciosGas.Rows.Add(conn.leer["ID_GASOLINERA"].ToString(),conn.leer["NOMBRE"].ToString(),
	 	                      					conn.leer["MAGNA"].ToString(),conn.leer["PREMIUM"].ToString(),
	 	                      					conn.leer["DIESEL"].ToString(),conn.leer["FECHA_REG"].ToString().Substring(0,10),
	 	                      					conn.leer["HORA_REG"].ToString().Substring(0,8),conn.leer["ESTATUS"].ToString());
							if(conn.leer["ESTATUS"].ToString().Equals("INACTIVO"))
							dgPreciosGas[1,contador].Style.BackColor = Color.Red;
						}else{							
							dgPreciosGas.Rows.Add(conn.leer["ID"].ToString(),conn.leer["NOMBRE"].ToString(), "", "", "", "", "", "");
						}						
						dgPreciosGas[1,contador].Style.BackColor = Color.LightGray;
						
						contador++;	
					}					
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener los precios del combustible (error al llenar la tabla): "+ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);	
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}	
				if(cbTodasGasolinera.Checked == false)
					ComplementosPreciosGas();
				dgPreciosGas.ClearSelection();
				dgPreciosGas.Sort(dgPreciosGas.Columns[2], ListSortDirection.Descending);
			}
		 	
			private void ComplementosPreciosGas(){
				string consulta = "";
		 		for(int x=0; x<dgPreciosGas.RowCount; x++){
		 		consulta = @"select * from PRECIOS_GASOLINERA where ESTATUS = 'ACTIVO' and ID_GASOLINERA = "+dgPreciosGas[0,x].Value.ToString()+
		 					" order by FECHA_REG DESC, HORA_REG DESC";
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						dgPreciosGas[2,x].Value = conn.leer["MAGNA"].ToString();	
						dgPreciosGas[3,x].Value = conn.leer["PREMIUM"].ToString();	
						dgPreciosGas[4,x].Value = conn.leer["DIESEL"].ToString();				
						dgPreciosGas[5,x].Value = conn.leer["FECHA_REG"].ToString().Substring(0,10);	
						dgPreciosGas[6,x].Value = conn.leer["HORA_REG"].ToString().Substring(0,8);	
						dgPreciosGas[7,x].Value = conn.leer["ESTATUS"].ToString();
					}else{
						dgPreciosGas[2,x].Value = "SIN REGISTRO";	
						dgPreciosGas[3,x].Value = "SIN REGISTRO";	
						dgPreciosGas[4,x].Value = "SIN REGISTRO";	
						dgPreciosGas[5,x].Value = DateTime.Now.ToString("dd/MM/yyyy");
						dgPreciosGas[6,x].Value = "00:00";	
						dgPreciosGas[7,x].Value = "SIN REGISTRO";	
					}
					conn.conexion.Close();	
			 	}
			 }
		 #endregion
		 
		 #region EVENTOS		 
			void DgPreciosGasCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
			{
				if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4){
					if(dgPreciosGas[e.ColumnIndex, e.RowIndex].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsPrecio(e.FormattedValue.ToString())){
			                MessageBox.Show("El dato introducido no es un precio valido","Error de validación", MessageBoxButtons.OK,MessageBoxIcon.Error);				
							dgPreciosGas[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[e.ColumnIndex, e.RowIndex].Style.BackColor = dgPreciosGas[7, e.RowIndex].Style.BackColor;
						}
					}     
		        }
		        if (e.ColumnIndex == 5){
					if(dgPreciosGas[e.ColumnIndex, e.RowIndex].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsFecha(e.FormattedValue.ToString())){
			                MessageBox.Show("El dato introducido no es de tipo hora","Error de validación", MessageBoxButtons.OK,MessageBoxIcon.Error);				
							dgPreciosGas[5, e.RowIndex].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[e.ColumnIndex, e.RowIndex].Style.BackColor = dgPreciosGas[7, e.RowIndex].Style.BackColor;
						}
					}        
		        } 
				if (e.ColumnIndex == 6){
					if(dgPreciosGas[e.ColumnIndex, e.RowIndex].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsFecha(e.FormattedValue.ToString())){
			                MessageBox.Show("El dato introducido no es de tipo hora","Error de validación", MessageBoxButtons.OK,MessageBoxIcon.Error);				
							dgPreciosGas[6, e.RowIndex].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[e.ColumnIndex, e.RowIndex].Style.BackColor = dgPreciosGas[7, e.RowIndex].Style.BackColor;
						}
					}       
		        }
			}	
		
		 	void DtpInicioGasolineraValueChanged(object sender, EventArgs e)
			{
				dtpFinGasolinera.MinDate = dtpInicioGasolinera.Value;
				filtrosPreciosGas();
			}
		 	
			void DtpFinGasolineraValueChanged(object sender, EventArgs e)
			{
				filtrosPreciosGas();
			}
			
			void TxtBusquedaGasolineraTextChanged(object sender, EventArgs e)
			{
				filtrosPreciosGas();
			}
			
			void CbTodasGasolineraCheckedChanged(object sender, EventArgs e)
			{
				if(cbTodasGasolinera.Checked == true){
					dtpInicioGasolinera.Enabled = true;
					dtpFinGasolinera.Enabled = true;
					btnGuardarPrecios.Enabled = false;
				}else{
					btnGuardarPrecios.Enabled = true;
					dtpInicioGasolinera.Enabled = false;
					dtpFinGasolinera.Enabled = false;
					dtpInicioGasolinera.Value = DateTime.Now;		
				}
				filtrosPreciosGas();
			}
			
			void BtnGuardarPreciosClick(object sender, EventArgs e)
			{
				if(validaPrecios()){
					if(GuardaPrecios())
						MessageBox.Show("Se guardó correctamente los precios del combustible", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);	
				}else{
					DialogResult rs = MessageBox.Show("Hay gasolineras que no tienen un precio o fecha valida y no se guardaran. ¿Desea continuar?", "Alerta Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs){					
						if(GuardaPrecios())
							MessageBox.Show("Se guardó correctamente los precios del combustible", "Listo", MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
				}
			}
			
			private bool validaPrecios(){
				bool respuesta = true;
				for(int x=0; x<dgPreciosGas.RowCount; x++){
					if(dgPreciosGas[2,x].Value.ToString() != "SIN REGISTRO" || dgPreciosGas[3,x].Value.ToString() != "SIN REGISTRO"
					  || dgPreciosGas[4,x].Value.ToString() != "SIN REGISTRO" || dgPreciosGas[5,x].Value.ToString() != "SIN REGISTRO"){
						dgPreciosGas[2,x].Value.ToString().Replace(" ", "");
						dgPreciosGas[3,x].Value.ToString().Replace(" ", "");
						dgPreciosGas[4,x].Value.ToString().Replace(" ", "");
						dgPreciosGas[5,x].Value.ToString().Replace(" ", "");
						dgPreciosGas[6,x].Value.ToString().Replace(" ", "");						
						
						dgPreciosGas[2,x].Value.ToString().Replace(",", ".");
						dgPreciosGas[3,x].Value.ToString().Replace(",", ".");
						dgPreciosGas[4,x].Value.ToString().Replace(",", ".");
					}
					
					if(dgPreciosGas[2,x].Value.ToString() == "" || dgPreciosGas[3,x].Value.ToString() == ""
					  || dgPreciosGas[4,x].Value.ToString() == "" || dgPreciosGas[5,x].Value.ToString() == ""){
						dgPreciosGas[2,x].Style.BackColor = Color.Red;				
						dgPreciosGas[3,x].Style.BackColor = Color.Red;				
						dgPreciosGas[4,x].Style.BackColor = Color.Red;				
						dgPreciosGas[5,x].Style.BackColor = Color.Red;				
						dgPreciosGas[6,x].Style.BackColor = Color.Red;	
					}
					
					
					if(dgPreciosGas[2, x].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsPrecio(dgPreciosGas[2,x].Value.ToString())){
			                dgPreciosGas[2,x].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[2,x].Style.BackColor = dgPreciosGas[7,x].Style.BackColor;
						}
					} 
					if(dgPreciosGas[3,x].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsPrecio(dgPreciosGas[3,x].Value.ToString())){
			                dgPreciosGas[3,x].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[3,x].Style.BackColor = dgPreciosGas[7,x].Style.BackColor;
						}
					} 
					if(dgPreciosGas[4,x].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsPrecio(dgPreciosGas[4,x].Value.ToString())){
			                dgPreciosGas[4,x].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[4,x].Style.BackColor = dgPreciosGas[7,x].Style.BackColor;
						}
					} 
					if(dgPreciosGas[5,x].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsFecha(dgPreciosGas[5,x].Value.ToString())){
			                dgPreciosGas[5,x].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[5,x].Style.BackColor = dgPreciosGas[7,x].Style.BackColor;
						}
					} 	
					if(dgPreciosGas[6,x].Value.ToString() != "SIN REGISTRO"){
						if (!this.EsFecha(dgPreciosGas[6,x].Value.ToString())){
			                dgPreciosGas[6,x].Style.BackColor = Color.Red;					
						}else{
							dgPreciosGas[6,x].Style.BackColor = dgPreciosGas[7,x].Style.BackColor;
						}
					}
				}
				return respuesta;
			}
		 #endregion
		 
		#endregion
		
		#region PRIVILEGIOS PRECIOS COMBUSTIBLE
		void BtnDesbloquear2Click(object sender, EventArgs e)
		{
			new FormContrasena(this, "PRECIOS").ShowDialog();			
			if(respu){
				cmdModificarPrec.Enabled = true;
				cmdEliminarPrec.Enabled = true;
				cmdGuardarPrec.Enabled = true;
				cmdNuevoPrec.Enabled = true;
				btnGuardarPrecios.Enabled = true;	
				btnDesbloquear2.Visible = false;
				btnBloquear2.Visible = true;		
			}else{
				cmdModificarPrec.Enabled = false;
				cmdEliminarPrec.Enabled = false;
				cmdGuardarPrec.Enabled = false;
				cmdNuevoPrec.Enabled = false;
				btnGuardarPrecios.Enabled = false;	
				btnDesbloquear2.Visible = true;
				btnBloquear2.Visible = false;
			}
		}
		
		void BtnBloquear2Click(object sender, EventArgs e)
		{
			cmdModificarPrec.Enabled = false;
			cmdEliminarPrec.Enabled = false;
			cmdGuardarPrec.Enabled = false;
			cmdNuevoPrec.Enabled = false;
			btnGuardarPrecios.Enabled = false;
			btnDesbloquear2.Visible = true;
			btnBloquear2.Visible = false;
			respu = false;
		}
		#endregion		
	}
}
