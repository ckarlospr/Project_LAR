using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Caja
{
	public partial class FormResponsable : Form
	{
		public FormResponsable()
		{
			InitializeComponent();
		}
		
		#region VARIABLES
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region EVENTO LOAD
		void FormResponsableLoad(object sender, EventArgs e)
		{
			getValidacionCampos(this);
			
			txtAlias.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' ");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			getDatosDG();
		}
		#endregion
		
		#region VALIDACION DE CAMPOS
		private void getValidacionCampos(FormResponsable formRef)
		{
			formRef.txtNombre.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formRef.txtAp_pat.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formRef.txtAp_mat.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formRef.txtAlias.KeyPress					+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formRef.txtTelefono.KeyPress				+= new KeyPressEventHandler(Proceso.ValidarCampo.numeroGuion);
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdNuevoClick(object sender, EventArgs e)
		{
			limpiaDatos();
			dgDatos.ClearSelection();
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(txtNombre.Text=="")
			{
				MessageBox.Show("Ingrese nombre");
				txtNombre.SelectAll();
			}
			else if(txtAp_pat.Text=="")
			{
				MessageBox.Show("Ingrese apellido paterno");
				txtAp_pat.SelectAll();
			}
			else if(txtAp_mat.Text=="")
			{
				MessageBox.Show("Ingrese apellido materno");
				txtAp_mat.SelectAll();
			}
			else if(txtAlias.Text=="")
			{
				MessageBox.Show("Ingrese alias");
				txtAlias.SelectAll();
			}
			else if(txtTelefono.Text=="")
			{
				MessageBox.Show("Ingrese telefono");
				txtTelefono.SelectAll();
			}
			else if(txtComentario.Text=="")
			{
				MessageBox.Show("Ingrese cometario");
				txtComentario.SelectAll();
			}
			else
			{
				guarda();
				limpiaDatos();
			}
		}
		#endregion
		
		#region GUARDADO DE DATOS
		void guarda()
		{
			if(dgDatos.SelectedRows.Count==0)
			{
				if(rbEmpleado.Checked==false)
				{
					String consulta ="INSERT INTO RESPONSABLE VALUES ('"+txtNombre.Text+"', '"+txtAp_pat.Text+"', '"+txtAp_mat.Text+"', '"+txtAlias.Text+"', null, '"+((rbEmpleado.Checked==false)?((rbArriaga.Checked==false)?"EXTERNO":"ARRIAGA"):"EMPLEADO")+"', '"+txtTelefono.Text+"', '"+txtComentario.Text+"');";
					
					conn.getAbrirConexion(consulta); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();	
				}
				else
				{
					Int64 ID_OP = 0;
					
					String consulta = "select * from OPERADOR WHERE ALIAS='"+txtAlias.Text+"'";
				
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						ID_OP=Convert.ToInt64(conn.leer["ID"]);
					}
					else
					{
						ID_OP = 0;
					}
					
					conn.conexion.Close();
					
					if(ID_OP==0)
					{
						MessageBox.Show("No esxite empleado. \n Es necesario escriba el Nick correcto con el que esta registrado.");
					}
					else
					{
						consulta ="INSERT INTO RESPONSABLE VALUES ('"+txtNombre.Text+"', '"+txtAp_pat.Text+"', '"+txtAp_mat.Text+"', '"+txtAlias.Text+"', '"+ID_OP+"', '"+((rbEmpleado.Checked==false)?((rbArriaga.Checked==false)?"EXTERNO":"ARRIAGA"):"EMPLEADO")+"', '"+txtTelefono.Text+"', '"+txtComentario.Text+"');";
						
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();	
					}
				}
				getDatosDG();
			}
			else
			{
				if(rbEmpleado.Checked==false)
				{
					String consulta ="UPDATE RESPONSABLE SET NOMBRE='"+txtNombre.Text+"', APELLIDO_PAT='"+txtAp_pat.Text+"', APELLIDO_MAT='"+txtAp_mat.Text+"', ALIAS='"+txtAlias.Text+"', ID_O=null, TIPO='"+((rbEmpleado.Checked==false)?((rbArriaga.Checked==false)?"EXTERNO":"ARRIAGA"):"EMPLEADO")+"', TELEFONO='"+txtTelefono.Text+"', COMENTARIO='"+txtComentario.Text+"' WHERE ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
						
					conn.getAbrirConexion(consulta); 
					conn.comando.ExecuteNonQuery(); 
					conn.conexion.Close();
				}
				else
				{
					Int64 ID_OP = 0;
					
					String consulta = "select * from OPERADOR WHERE ALIAS='"+txtAlias.Text+"'";
				
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						ID_OP=Convert.ToInt64(conn.leer["ID"]);
					}
					else
					{
						ID_OP = 0;
					}
					
					conn.conexion.Close();
					
					if(ID_OP==0)
					{
						MessageBox.Show("No esxite empleado. \n Es necesario escriba el Nick correcto con el que esta registrado.");
					}
					else
					{
						consulta ="UPDATE RESPONSABLE SET NOMBRE='"+txtNombre.Text+"', APELLIDO_PAT='"+txtAp_pat.Text+"', APELLIDO_MAT='"+txtAp_mat.Text+"', ALIAS='"+txtAlias.Text+"', ID_O="+ID_OP+", TIPO='"+((rbEmpleado.Checked==false)?((rbArriaga.Checked==false)?"EXTERNO":"ARRIAGA"):"EMPLEADO")+"', TELEFONO='"+txtTelefono.Text+"', COMENTARIO='"+txtComentario.Text+"' WHERE ID="+dgDatos[0,dgDatos.CurrentRow.Index].Value.ToString();
						
						conn.getAbrirConexion(consulta); 
						conn.comando.ExecuteNonQuery(); 
						conn.conexion.Close();	
					}
				}
				getDatosDG();
			}
		}
		#endregion
		
		#region LIMPIA DE CAMPOS
		void limpiaDatos()
		{
			txtNombre.Text="";
			txtAp_pat.Text="";
			txtAp_mat.Text="";
			txtAlias.Text="";
			txtComentario.Text="";
			txtTelefono.Text="";
		}
		#endregion
		
		#region GET DATOS DG
		void getDatosDG()
		{
			dgDatos.Rows.Clear();
			
			String consulta = "select * from RESPONSABLE";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDatos.Rows.Add(conn.leer["ID"].ToString(), conn.leer["ALIAS"].ToString(), conn.leer["TIPO"].ToString(), conn.leer["NOMBRE"].ToString() +" "+ conn.leer["APELLIDO_PAT"].ToString() +" "+ conn.leer["APELLIDO_MAT"].ToString(), conn.leer["TELEFONO"].ToString(), conn.leer["COMENTARIO"].ToString());
			}
			
			conn.conexion.Close();
			
			dgDatos.ClearSelection();
		}
		#endregion
		
		#region KEYUP TXTALIAS
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return" && rbEmpleado.Checked==true)
			{
				getDatosAlias(txtAlias.Text);
			}
		}
		
		void getDatosAlias(String alias)
		{
			String consulta = "SELECT * FROM OPERADOR WHERE ALIAS='"+alias+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtNombre.Text=conn.leer["Nombre"].ToString();
				txtAp_pat.Text=conn.leer["Apellido_Pat"].ToString();
				txtAp_mat.Text=conn.leer["Apellido_Mat"].ToString();
				txtTelefono.Focus();
				txtTelefono.SelectAll();
			}
			conn.conexion.Close();
		}
		#endregion
		
		void DgDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtAlias.Text=dgDatos[1,dgDatos.CurrentRow.Index].Value.ToString();
			txtNombre.Text=dgDatos[3,dgDatos.CurrentRow.Index].Value.ToString();
			getDatosAlias(dgDatos[1,dgDatos.CurrentRow.Index].Value.ToString());
			txtComentario.Text=dgDatos[5,dgDatos.CurrentRow.Index].Value.ToString();
			txtTelefono.Text=dgDatos[4,dgDatos.CurrentRow.Index].Value.ToString();
			
			rbEmpleado.Checked=((dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString()=="EMPLEADO")?true:false);
			rbArriaga.Checked=((dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString()=="ARRIAGA")?true:false);
			rbExterno.Checked=((dgDatos[2,dgDatos.CurrentRow.Index].Value.ToString()=="EXTERNO")?true:false);
		}
	}
}
