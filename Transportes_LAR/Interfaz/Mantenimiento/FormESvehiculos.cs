using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento
{
	public partial class FormESvehiculos : Form
	{
		#region VARIABLES
		String idunidad = "";
		String id_usuario = "";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		public static String User;
		#endregion
		
		#region CONSTRUCTORES
		public FormESvehiculos()
		{
			InitializeComponent();
		}
		
		public FormESvehiculos(Interfaz.FormPrincipal principal, String id_usuario)
		{
			InitializeComponent();
			this.principal = principal;
			this.id_usuario = id_usuario;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormESvehiculosLoad(object sender, EventArgs e)
		{
			this.txtNumOperacion.Focus();
			this.txtIdOP.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtNumOperacion.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			AdaptadorOperadorVehiculo();
		}
		
		void AdaptadorOperadorVehiculo()
		{
			dataOperadorVehiculo.DataSource=new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getTabla("select V.ID ID_UNIDAD, O.ID ID_OPERADOR, O.Alias OPERADOR, V.Numero UNIDAD, A.estatus, V.Marca MARCA " +
			                                                                                                 "from ASIGNACIONUNIDAD A, VEHICULO V, OPERADOR O " +
			                                                                                                 "where A.ID_OPERADOR=O.ID and A.ID_UNIDAD=V.ID and  O.tipo_empleado='OPERADOR' " +
			                                                                                                 "order by OPERADOR");
		}
		
		void FormESvehiculosFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.esVehiculos = false;
		}
		#endregion
		
		#region CONSULTA
		public void consultaLista()
		{
			if(txtAliasAnticipos.Text!="")
			{
				int contador = 0;
				dgvHistorialOV.Rows.Clear();
				dgvHistorialOV.ClearSelection();
				conn.getAbrirConexion("select O.ID, V.ID idv, H.FECHA fecha, H.HORA hora, O.Alias nombre, V.Tipo_Unidad tv, V.Numero nv, H.DATO descripcion " +
				                                                                             "from HISTORIALOPERADORVEHICULO H, VEHICULO V, OPERADOR O " +
				                                                                             "where H.ID_OPERADOR=O.ID and H.ID_UNIDAD=V.ID and O.ID ="+txtIdOP.Text);
				conn.leer=conn.comando.ExecuteReader();
				while(conn.leer.Read())
				{
					dgvHistorialOV.Rows.Add();
					dgvHistorialOV.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dgvHistorialOV.Rows[contador].Cells[1].Value = conn.leer["idv"].ToString();
					dgvHistorialOV.Rows[contador].Cells[2].Value = conn.leer["fecha"].ToString().Substring(0,10);
					dgvHistorialOV.Rows[contador].Cells[3].Value = conn.leer["hora"].ToString();
					dgvHistorialOV.Rows[contador].Cells[4].Value = conn.leer["nombre"].ToString();
					dgvHistorialOV.Rows[contador].Cells[5].Value = conn.leer["tv"].ToString();
					dgvHistorialOV.Rows[contador].Cells[6].Value = conn.leer["nv"].ToString();
					dgvHistorialOV.Rows[contador].Cells[7].Value = conn.leer["descripcion"].ToString();
					++contador;
				}
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region KEYUP - ENTER
		void TxtNumOperacionKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      {
					txtResponsable.Text = principal.lblDatoUsuario.Text;
					if(txtNumOperacion.Text=="1")
					{
						txtOperacion.Text = "SE ASIGNO UNIDAD";
						txtIdUnidad.Enabled = true;
						txtIdUnidad.Focus();
						txtNumOperacion.Enabled = false;
					}
					else if(txtNumOperacion.Text=="2")
					{
						txtOperacion.Text = "SE DEASIGNO UNIDAD";
						txtIdUnidad.Enabled = true;
						txtIdUnidad.Focus();
						txtNumOperacion.Enabled = false;
					}
					else if(txtNumOperacion.Text=="3")
					{
						txtOperacion.Text = "ENTRO A TALLER";
						txtIdUnidad.Enabled = true;
						txtIdUnidad.Focus();
						txtNumOperacion.Enabled = false;
					}
					else if(txtNumOperacion.Text=="4")
					{
						txtOperacion.Text = "SALIO DEL TALLER";
						txtIdUnidad.Enabled = true;
						txtIdUnidad.Focus();
						txtNumOperacion.Enabled = false;
					}
					else
						txtNumOperacion.Text="";
			  }
		}
		
		void TxtIdUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      {
					DatosVehiculo(txtIdUnidad.Text);
				 	if(txtIdUnidad.Text!="" && txtMarca.Text!="")
				 	{
				 		txtIdOP.Enabled = true;
				 		txtIdOP.Focus();
				 		txtIdUnidad.Enabled = false;
				 	}
			  }
		}
		
		void TxtIdOPKeyUp(object sender, KeyEventArgs e)
		{
			 if (e.KeyCode == Keys.Enter)
		      {
				 	DatosOperador(Convert.ToInt32(txtIdOP.Text));
				 	consultaLista();
				 	if(txtIdOP.Text!="" && txtAliasAnticipos.Text!="")
				 	{
					 	if(txtNumOperacion.Text=="1")
						{
							new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getInsertarAsignacionUnidad(idunidad, txtIdOP.Text, id_usuario);
							new Interfaz.FormMensaje("Asignación establecida").Show();
							consultaLista();
							Limpiar();
							AdaptadorOperadorVehiculo();
						}
						else if(txtNumOperacion.Text=="2")
						{
							new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getEliminarAsignacionUnidad(idunidad, txtIdOP.Text, id_usuario);
							consultaLista();
							Limpiar();
							AdaptadorOperadorVehiculo();
						}
						else if(txtNumOperacion.Text=="3")
						{
							new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getGenerarHistorialVehiculo(idunidad, txtIdOP.Text, "T", "ENTRO AL TALLER", id_usuario);
							new Interfaz.FormMensaje("Entró a taller").Show();
							consultaLista();
							Limpiar();
							AdaptadorOperadorVehiculo();
						}
						else if(txtNumOperacion.Text=="4")
						{
							new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getGenerarHistorialVehiculo(idunidad, txtIdOP.Text, "A", "SALIO DE TALLER", id_usuario);
							new Interfaz.FormMensaje("Salió a taller").Show();
							consultaLista();
							Limpiar();
							AdaptadorOperadorVehiculo();
						}
				 	}
			  }
		}
		#endregion
		
		#region DATOS OPERADOR
		void DatosOperador(int id)
		{
			String Nombre = "";		
			if(txtNumOperacion.Text=="1")
			{
				conn.getAbrirConexion("select O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat " +
			                      "from Operador O " +
			                      "where O.tipo_empleado='OPERADOR' and O.Estatus=1 and O.ID not in (select ID_OPERADOR from ASIGNACIONUNIDAD) AND O.ID ="+id);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					Nombre = conn.leer["Nombre"].ToString()+" "+conn.leer["Apellido_Pat"].ToString()+" "+conn.leer["Apellido_Mat"].ToString();
					txtNombreAnticipos.Text = Nombre;
					txtAliasAnticipos.Text = conn.leer["Alias"].ToString();
				}
				else
				{
					txtIdOP.Text = "";
					txtAliasAnticipos.Text = "";
					txtNombreAnticipos.Text = "";
					MessageBox.Show("Este operador ya está tiene una unidad, desasignele la unidad para asignarle otra", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				conn.conexion.Close();
			}
			else if(txtNumOperacion.Text=="2" || txtNumOperacion.Text=="3" || txtNumOperacion.Text=="4")
			{
				conn.getAbrirConexion("select O.Alias, O.Nombre, O.Apellido_Pat, O.Apellido_Mat " +
			                      "from Operador O " +
			                      "where O.tipo_empleado='OPERADOR' and O.Estatus=1 and O.ID in (select ID_OPERADOR from ASIGNACIONUNIDAD) AND O.ID ="+id);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					Nombre = conn.leer["Nombre"].ToString()+" "+conn.leer["Apellido_Pat"].ToString()+" "+conn.leer["Apellido_Mat"].ToString();
					txtNombreAnticipos.Text = Nombre;
					txtAliasAnticipos.Text = conn.leer["Alias"].ToString();
				}
				else
				{
					txtIdOP.Text = "";
					txtAliasAnticipos.Text = "";
					txtNombreAnticipos.Text = "";
					MessageBox.Show("Este operador no estaba asignado, por lo que no se puede desasignar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				conn.conexion.Close();
			}		
		}
		#endregion
		
		#region DATOS VEHICULO
		void DatosVehiculo(String id)
		{			
			if(txtNumOperacion.Text=="1")
			{
				conn.getAbrirConexion("select ID, Marca, Tipo_Unidad " +
			                      "from Vehiculo " +
			                      "where ID not in (select ID_UNIDAD from ASIGNACIONUNIDAD) AND Numero ='"+id+"'");
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idunidad = conn.leer["ID"].ToString();
					txtTipoUnidad.Text = conn.leer["Tipo_Unidad"].ToString();
					txtMarca.Text = conn.leer["Marca"].ToString();
				}
				else
				{
					txtIdUnidad.Text = "";
					txtMarca.Text = "";
					txtTipoUnidad.Text = "";
					MessageBox.Show("Esta unidad ya está ocupada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				conn.conexion.Close();
			}
			else if(txtNumOperacion.Text=="2" || txtNumOperacion.Text=="3" || txtNumOperacion.Text=="4")
			{
				conn.getAbrirConexion("select ID, Marca, Tipo_Unidad " +
			                      "from Vehiculo " +
			                      "where ID in (select ID_UNIDAD from ASIGNACIONUNIDAD) AND Numero ='"+id+"'");
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idunidad = conn.leer["ID"].ToString();
					txtTipoUnidad.Text = conn.leer["Tipo_Unidad"].ToString();
					txtMarca.Text = conn.leer["Marca"].ToString();
				}
				else
				{
					txtIdUnidad.Text = "";
					txtMarca.Text = "";
					txtTipoUnidad.Text = "";
					MessageBox.Show("Esta unidad no estaba asignada, por lo que no se puede desasignar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				conn.conexion.Close();
			}			
		}
		#endregion
		
		#region LIMPIAR
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			Limpiar();
		}
		
		void Limpiar()
		{
			txtIdOP.Text = "";
			txtIdUnidad.Text = "";
			txtOperacion.Text = "";
			txtMarca.Text = "";
			txtTipoUnidad.Text = "";
			txtAliasAnticipos.Text = "";
			txtNombreAnticipos.Text = "";
			txtResponsable.Text = "";
			txtNumOperacion.Text = "";
			txtIdUnidad.Enabled = false;
			txtIdOP.Enabled = false;
			txtNumOperacion.Enabled = true;
			txtNumOperacion.Focus();
		}
		#endregion		
	}
}
