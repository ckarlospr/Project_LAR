using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormExternos : Form
	{
		public FormExternos(formPrincipalComb refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		Int64 idUnidad = 0 ;
		Int64 idOperador = 0 ;
		Int64 idGasolinera = 0 ;
		Int64 idUsuario = 0 ;
		Int64 ID_COMBUSTIBLE = 0;
		bool entra = false;
		#endregion
		
		#region INSTANCIAS
		formPrincipalComb refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormExternosLoad(object sender, EventArgs e)
		{
			txtUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtGasolinera.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA");
			txtGasolinera.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtGasolinera.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUsuario.AutoCompleteCustomSource = auto.AutoReconocimiento("select UPPER(RTRIM(usuario)) dato from usuario");
			txtUsuario.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			iniciaCombo();
			
			dtpHora.Format = DateTimePickerFormat.Custom;
  		 	dtpHora.CustomFormat = "HH:mm";
  		 	
  		 	getDatos();
  		 	
  		 	txtOperador.Focus();
		}
		#endregion
		
		#region OBTIENE DATOS
		void getDatos()
		{
			txtFolio.Text=refPrincipal.dgAutorizacion[1, refPrincipal.dgAutorizacion.CurrentRow.Index].Value.ToString();
		}
		#endregion
		
		#region EVENTOS
		void TxtKmsKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtKms.Text.Contains(".")==false))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void DtpHoraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				cmbTipoComb.Focus();
			}
		}
		
		void CmbTipoCombKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtUsuario.Focus();
			}
		}
		
		void TxtKmsEnter(object sender, EventArgs e)
		{
			txtKms.SelectAll();
		}
		
		void TxtKmsKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				if(txtKms.Text!="")
				{
					if(Convert.ToDouble(txtKms.Text)>0 && entra == true)
					{
						cmdGuardar.Enabled=true;
						cmdGuardar.Focus();
					}
					else
					{
						cmdGuardar.Enabled=false;
					}
				}
				else
				{			
					cmdGuardar.Enabled=false;
					txtKms.Text="0";
				}
			}
		}
		
		void TxtKmsLeave(object sender, EventArgs e)
		{
			if(txtKms.Text!="")
			{
				if(Convert.ToDouble(txtKms.Text)>0 && entra == true)
				{
					cmdGuardar.Enabled=true;	
					cmdGuardar.Focus();
				}
				else
				{
					cmdGuardar.Enabled=false;
				}
			}
			else
			{
				txtKms.Text="0";
				cmdGuardar.Enabled=false;	
			}
		}
		
		void TxtUsuarioEnter(object sender, EventArgs e)
		{
			txtOperador.SelectAll();
		}
		
		void TxtUsuarioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtKms.Focus();
			}
		}
		
		void TxtUsuarioLeave(object sender, EventArgs e)
		{
			String consulta = "SELECT * FROM usuario WHERE usuario='"+txtUsuario.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				idUsuario=Convert.ToInt64(conn.leer["id_usuario"]);
				txtUsuario.BackColor=Color.SpringGreen;
			}
			else
			{
				txtUsuario.Text="";
				idUsuario=0;
				txtUsuario.ForeColor=Color.Black;
				txtUsuario.BackColor=Color.White;
			}
			
			conn.conexion.Close();
			
			validaSeleccion();
		}
		
		void TxtOperadorEnter(object sender, EventArgs e)
		{
			txtOperador.SelectAll();
		}
		
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtUnidad.Focus();
			}
		}
		
		void TxtOperadorLeave(object sender, EventArgs e)
		{
			
			String consulta = "SELECT * FROM OPERADOR WHERE ALIAS='"+txtOperador.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				idOperador=Convert.ToInt64(conn.leer["ID"]);
				txtOperador.BackColor=Color.SpringGreen;
			}
			else
			{
				txtOperador.Text="";
				idOperador=0;
				txtOperador.ForeColor=Color.Black;
				txtOperador.BackColor=Color.White;
			}
			
			conn.conexion.Close();
			
			if(txtUnidad.Text=="000")
			{
				Conexion_Servidor.SQL_Conexion conn2= new Conexion_Servidor.SQL_Conexion();
				consulta = "select V.ID, V.Numero, V.Marca from ASIGNACIONUNIDAD A, VEHICULO V, OPERADOR O where A.ID_OPERADOR=O.ID and A.ID_UNIDAD=V.ID and O.Alias='"+txtOperador.Text+"'";
				conn2.getAbrirConexion(consulta);
				conn2.leer=conn2.comando.ExecuteReader();
				if(conn2.leer.Read())
				{
					idUnidad=Convert.ToInt64(conn2.leer["ID"]);
					txtUnidad.Text=conn2.leer["Numero"].ToString();
					txtUnidad.BackColor=Color.SpringGreen;
				}
				else
				{
					txtUnidad.Text="000";
					idUnidad=0;
					txtUnidad.ForeColor=Color.Red;
					txtUnidad.BackColor=Color.White;
				}
				
				conn2.conexion.Close();
			}
			
			if(txtGasolinera.Text=="")
			{
				Conexion_Servidor.SQL_Conexion connex2= new Conexion_Servidor.SQL_Conexion();
				consulta = "select G.ID, G.NOMBRE from AUTORIZACION A, OPERADOR O, GASOLINERA G where A.ESTATUS!=0 and A.ID_O=O.ID and A.ID_G=G.ID and Alias='"+txtOperador.Text+"'";
				connex2.getAbrirConexion(consulta);
				connex2.leer=connex2.comando.ExecuteReader();
				if(connex2.leer.Read())
				{
					idGasolinera=Convert.ToInt64(connex2.leer["ID"]);
					txtGasolinera.Text=connex2.leer["NOMBRE"].ToString().ToUpper();
					txtGasolinera.BackColor=Color.SpringGreen;
				}
				else
				{
					idGasolinera=0;
					txtGasolinera.Text="";
					txtGasolinera.ForeColor=Color.Red;
					txtGasolinera.BackColor=Color.White;
				}
				
				connex2.conexion.Close();
			}
			
			
			#region GET TIPO COMBUSTIBLE
			Conexion_Servidor.SQL_Conexion conna= new Conexion_Servidor.SQL_Conexion();
			
			consulta = "select T.NOMBRE, P.ID from AUTORIZACION A, VEHICULO V, TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and A.ID_V=V.ID and A.ID_COM=P.ID and A.ESTATUS!='0' and P.ESTATUS='1' and V.Numero='"+txtUnidad.Text+"' order by A.FECHA_REG desc";
			conna.getAbrirConexion(consulta);
			conna.leer=conna.comando.ExecuteReader();
			if(conna.leer.Read())
			{
				ID_COMBUSTIBLE=Convert.ToInt64(conna.leer["ID"]);
				cmbTipoComb.Text=conna.leer["NOMBRE"].ToString().ToUpper();
			}
			else
			{
				cmbTipoComb.Text="DIESEL";
				ID_COMBUSTIBLE=0;
			}
			
			conna.conexion.Close();
			#endregion
			
			validaSeleccion();
		}
		
		void TxtUnidadEnter(object sender, EventArgs e)
		{
			txtUnidad.SelectAll();
		}
		
		void TxtUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtGasolinera.Focus();
			}
		}
		
		void TxtUnidadLeave(object sender, EventArgs e)
		{
			
			String consulta = "SELECT * FROM VEHICULO WHERE Numero='"+txtUnidad.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				idUnidad=Convert.ToInt64(conn.leer["ID"]);
				txtUnidad.BackColor=Color.SpringGreen;
			}
			else
			{
				txtUnidad.Text="000";
				idUnidad=0;
				txtUnidad.ForeColor=Color.Red;
				txtUnidad.BackColor=Color.White;
			}
			
			conn.conexion.Close();
			
			if(txtGasolinera.Text=="")
			{
				Conexion_Servidor.SQL_Conexion connex2= new Conexion_Servidor.SQL_Conexion();
				consulta = "select G.ID, G.NOMBRE from AUTORIZACION A, OPERADOR O, GASOLINERA G where A.ESTATUS!=0 and A.ID_O=O.ID and A.ID_G=G.ID and Alias='"+txtOperador.Text+"'";
				connex2.getAbrirConexion(consulta);
				connex2.leer=connex2.comando.ExecuteReader();
				if(connex2.leer.Read())
				{
					idGasolinera=Convert.ToInt64(connex2.leer["ID"]);
					txtGasolinera.Text=connex2.leer["NOMBRE"].ToString().ToUpper();
				}
				else
				{
					idGasolinera=0;
					txtGasolinera.Text="";
				}
				
				connex2.conexion.Close();
			}
			
			#region GET TIPO COMBUSTIBLE
			Conexion_Servidor.SQL_Conexion conna= new Conexion_Servidor.SQL_Conexion();
			
			consulta = "select T.NOMBRE, P.ID from AUTORIZACION A, VEHICULO V, TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and A.ID_V=V.ID and A.ID_COM=P.ID and A.ESTATUS!='0' and P.ESTATUS='1' and V.Numero='"+txtUnidad.Text+"' order by A.FECHA_REG desc";
			conna.getAbrirConexion(consulta);
			conna.leer=conna.comando.ExecuteReader();
			if(conna.leer.Read())
			{
				ID_COMBUSTIBLE=Convert.ToInt64(conna.leer["ID"]);
				cmbTipoComb.Text=conna.leer["NOMBRE"].ToString().ToUpper();
			}
			else
			{
				cmbTipoComb.Text="DIESEL";
				ID_COMBUSTIBLE=0;
			}
			
			conna.conexion.Close();
			#endregion
			
			validaSeleccion();
		}
		
		void TxtGasolineraEnter(object sender, EventArgs e)
		{
			txtGasolinera.SelectAll();
		}
		
		void TxtGasolineraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				dtpHora.Focus();
			}
		}
		
		void TxtGasolineraLeave(object sender, EventArgs e)
		{
			String consulta = "SELECT * FROM GASOLINERA WHERE SUBNOMBRE='"+txtGasolinera.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				idGasolinera=Convert.ToInt64(conn.leer["ID"]);
				txtGasolinera.ForeColor=Color.SpringGreen;
			}
			else
			{
				txtGasolinera.Text="";
				idGasolinera=0;
				txtGasolinera.ForeColor=Color.Black;
				txtGasolinera.BackColor=Color.White;
			}
			
			conn.conexion.Close();
			validaSeleccion();
		}
		#endregion
		
		#region INICIA COMBOBOX COMBUSTIBLE
		void iniciaCombo()
		{
			cmbTipoComb.Items.Clear();
			String consulta = "select * from TIPOS_COMB";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				cmbTipoComb.Items.Add(conn.leer["NOMBRE"].ToString());
			}
			
			conn.conexion.Close();
			
			cmbTipoComb.SelectedIndex=0;
		}
		#endregion
				
		#region GUADAR DATOS
		void CmdGuardarClick(object sender, EventArgs e)
		{
			getCombustible();
			
			guardaDtos();
		}
		
		void guardaDtos()
		{
			String consulta ="UPDATE AUTORIZACION SET ID_COM="+((ID_COMBUSTIBLE==0)?"null":ID_COMBUSTIBLE.ToString())+", ID_G="+((idGasolinera==0)?"null":idGasolinera.ToString())+", ID_O="+((idOperador==0)?"null":idOperador.ToString())+", ID_V="+((idUnidad==0)?"null":idUnidad.ToString())+", HORA_AUTORIZACION='"+dtpHora.Value.ToString("HH:mm")+"', KM='"+txtKms.Text+"' WHERE ID='"+refPrincipal.dgAutorizacion[0,refPrincipal.dgAutorizacion.CurrentRow.Index].Value.ToString()+"'";
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
			
			refPrincipal.dgAutorizacion[2,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=txtUnidad.Text;
			refPrincipal.dgAutorizacion[3,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=txtOperador.Text;
			refPrincipal.dgAutorizacion[4,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=txtGasolinera.Text;
			refPrincipal.dgAutorizacion[6,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=dtpHora.Value.ToString("HH:mm");
			
			
			for(int y=0; y<refPrincipal.dgAutorizacion.Columns.Count; y++)
			{
				refPrincipal.dgAutorizacion[y,refPrincipal.dgAutorizacion.CurrentRow.Index].Style.BackColor=Color.White;
			}
			
			this.Close();
		}
		#endregion
		
		#region VALIDACION
		void validaSeleccion()
		{
			if(idGasolinera!=0 && idOperador!=0 && idUnidad!=0 && idUsuario!=0)
			{
				txtGasolinera.BackColor=Color.SpringGreen;
				txtOperador.BackColor=Color.SpringGreen;
				txtUnidad.BackColor=Color.SpringGreen;
				txtUsuario.BackColor=Color.SpringGreen;
				
				txtGasolinera.ForeColor=Color.Black;
				txtOperador.ForeColor=Color.Black;
				txtUnidad.ForeColor=Color.Black;
				txtUsuario.ForeColor=Color.Black;
				entra = true;
			}
			else
			{
				cmdGuardar.Enabled=false;
				txtGasolinera.BackColor=Color.White;
				txtOperador.BackColor=Color.White;
				txtUnidad.BackColor=Color.White;
				txtUsuario.BackColor=Color.White;
				entra = false;
			}
		}
		#endregion
		
		void CmbTipoCombSelectedIndexChanged(object sender, EventArgs e)
		{
			getCombustible();
		}
		
		void getCombustible()
		{
			String consulta = "select P.ID from TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and ESTATUS='1' and T.NOMBRE='"+cmbTipoComb.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_COMBUSTIBLE=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				ID_COMBUSTIBLE=0;
			}
			
			conn.conexion.Close();
		}
	}
}
