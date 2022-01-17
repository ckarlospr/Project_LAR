using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormDatosExternos : Form
	{
		public FormDatosExternos(formPrincipalComb refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region VARIABLES
		Int64 idUnidad = 0 ;
		Int64 idOperador = 0 ;
		Int64 idGasolinera = 0 ;
		Int64 ID_COMBUSTIBLE = 0;
		#endregion
		
		#region INSTANCIAS
		formPrincipalComb refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.SQL_Conexion conn2= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region LOAD
		void FormDatosExternosLoad(object sender, EventArgs e)
		{
			dtpAutorizacion.Focus();
			iniciaCombo();
			
			cmbTipoComb.Text="DIESEL";
			getCombustible();
			
			dtpAutorizacion.Format = DateTimePickerFormat.Custom;
  		 	dtpAutorizacion.CustomFormat = "HH:mm";
			
			txtNumero.Text=refPrincipal.dgAutorizacion[1, refPrincipal.dgAutorizacion.CurrentRow.Index].Value.ToString();
			dtpAutorizacion.Value=Convert.ToDateTime(refPrincipal.dgAutorizacion[6, refPrincipal.dgAutorizacion.CurrentRow.Index].Value);
			dtpFechaBase.Value=Convert.ToDateTime(refPrincipal.dgAutorizacion[5, refPrincipal.dgAutorizacion.CurrentRow.Index].Value);
			
			
			txtUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtNumUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO");
			txtNumUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtNumUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtGasolinera.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA");
			txtGasolinera.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtGasolinera.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		void getCombustible()
		{
			String consulta = "select P.ID, T.NOMBRE from TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and ESTATUS='1' and T.NOMBRE='"+cmbTipoComb.Text+"'";
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
		
		#region GUARDAR
		void CmdGuardarClick(object sender, EventArgs e)
		{
			/*getID_COM();
			
			String consulta ="UPDATE AUTORIZACION SET ID_COM="+((ID_COMBUSTIBLE==0)?"null":ID_COMBUSTIBLE.ToString())+", ID_G="+((idGasolinera==0)?"null":idGasolinera.ToString())+", ID_O="+((idOperador==0)?"null":idOperador.ToString())+", ID_V="+((idUnidad==0)?"null":idUnidad.ToString())+", HORA_AUTORIZACION='"+dtpAutorizacion.Value.ToString("HH:mm")+"', KM='"+txtKms.Text+"' WHERE ID='"+refPrincipal.dgAutorizacion[0,refPrincipal.dgAutorizacion.CurrentRow.Index].Value.ToString()+"'";
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
			
			refPrincipal.dgAutorizacion[2,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=txtNumUnidad.Text;
			refPrincipal.dgAutorizacion[3,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=txtOperador.Text;
			refPrincipal.dgAutorizacion[4,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=txtGasolinera.Text;
			refPrincipal.dgAutorizacion[5,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=dtpFechaBase.Value.ToString("dd/MM/yyyy");
			refPrincipal.dgAutorizacion[6,refPrincipal.dgAutorizacion.CurrentRow.Index].Value=dtpAutorizacion.Value.ToString("HH:mm");
			
			
			for(int y=0; y<refPrincipal.dgAutorizacion.Columns.Count; y++)
			{
				refPrincipal.dgAutorizacion[y,refPrincipal.dgAutorizacion.CurrentRow.Index].Style.BackColor=Color.White;
			}
			
			this.Close();*/
		}
		#endregion
		
		#region BUSQUEDAS
		#region UNIDAD
		void TxtNumUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				/*String consulta = "SELECT * FROM VEHICULO WHERE Numero='"+txtNumUnidad.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idUnidad=Convert.ToInt64(conn.leer["ID"]);
					txtNumUnidad.ForeColor=Color.SpringGreen;
					txtOperador.Focus();
				}
				else
				{
					txtNumUnidad.Text="000";
					idUnidad=0;
					txtNumUnidad.ForeColor=Color.Red;
				}
				
				conn.conexion.Close();
				
				consulta = "select O.ID, O.Alias from ASIGNACIONUNIDAD A, VEHICULO V, OPERADOR O where A.ID_OPERADOR=O.ID and A.ID_UNIDAD=V.ID and V.Numero='"+txtNumUnidad.Text+"'";
				conn2.getAbrirConexion(consulta);
				conn2.leer=conn2.comando.ExecuteReader();
				if(conn2.leer.Read())
				{
					idOperador=Convert.ToInt64(conn2.leer["ID"]);
					txtOperador.Text=conn2.leer["Alias"].ToString().ToUpper();
				}
				else
				{
					idOperador=0;
					txtOperador.Text="";
				}
				
				conn2.conexion.Close();
				
				validaSeleccion();*/
				
				txtOperador.Focus();
			}
		}
		
		void TxtNumUnidadLeave(object sender, EventArgs e)
		{
			String consulta = "SELECT * FROM VEHICULO WHERE Numero='"+txtNumUnidad.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				idUnidad=Convert.ToInt64(conn.leer["ID"]);
				txtNumUnidad.BackColor=Color.SpringGreen;
				txtOperador.Focus();
			}
			else
			{
				txtNumUnidad.Text="000";
				idUnidad=0;
				txtNumUnidad.ForeColor=Color.Red;
				txtNumUnidad.BackColor=Color.White;
			}
			
			conn.conexion.Close();
			
			consulta = "select O.ID, O.Alias from ASIGNACIONUNIDAD A, VEHICULO V, OPERADOR O where A.ID_OPERADOR=O.ID and A.ID_UNIDAD=V.ID and V.Numero='"+txtNumUnidad.Text+"'";
			conn2.getAbrirConexion(consulta);
			conn2.leer=conn2.comando.ExecuteReader();
			if(conn2.leer.Read())
			{
				idOperador=Convert.ToInt64(conn2.leer["ID"]);
				txtOperador.Text=conn2.leer["Alias"].ToString().ToUpper();
				txtOperador.BackColor=Color.SpringGreen;
			}
			else
			{
				idOperador=0;
				txtOperador.Text="";
				txtOperador.BackColor=Color.White;
			}
			
			conn2.conexion.Close();
			
			validaSeleccion();
		}
		#endregion
		
		#region OPERADOR
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				/*String consulta = "SELECT * FROM OPERADOR WHERE ALIAS='"+txtOperador.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idOperador=Convert.ToInt64(conn.leer["ID"]);
					txtOperador.BackColor=Color.SpringGreen;
					txtGasolinera.Focus();
				}
				else
				{
					txtOperador.Text="";
					idOperador=0;
					txtOperador.ForeColor=Color.Black;
					txtOperador.BackColor=Color.White;
				}
				
				conn.conexion.Close();
				
				validaSeleccion();*/
				
				txtGasolinera.Focus();
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
					txtGasolinera.Focus();
				}
				else
				{
					txtOperador.Text="";
					idOperador=0;
					txtOperador.ForeColor=Color.Black;
					txtOperador.BackColor=Color.White;
				}
				
				conn.conexion.Close();
				
				validaSeleccion();
		}
		#endregion
		
		#region GASOLINERA
		void TxtGasolineraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				/*String consulta = "SELECT * FROM GASOLINERA WHERE SUBNOMBRE='"+txtGasolinera.Text+"'";
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
				}
				
				conn.conexion.Close();
				validaSeleccion();*/
				txtKms.Focus();
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
				cmdGuardar.Focus();
			}
			else
			{
				txtGasolinera.Text="";
				idGasolinera=0;
				txtGasolinera.ForeColor=Color.Black;
			}
			
			conn.conexion.Close();
			validaSeleccion();
		}
		#endregion
		#endregion
		
		#region VALIDA SELECCION
		void validaSeleccion()
		{
			if(idGasolinera!=0 && idOperador!=0 && idUnidad!=0)
			{
				//cmdGuardar.Enabled=true;
				txtGasolinera.BackColor=Color.SpringGreen;
				txtOperador.BackColor=Color.SpringGreen;
				txtNumUnidad.BackColor=Color.SpringGreen;
				
				txtGasolinera.ForeColor=Color.Black;
				txtOperador.ForeColor=Color.Black;
				txtNumUnidad.ForeColor=Color.Black;
				txtKms.Focus();
			}
			else
			{
				cmdGuardar.Enabled=false;
				txtGasolinera.BackColor=Color.White;
				txtOperador.BackColor=Color.White;
				txtNumUnidad.BackColor=Color.White;
			}
		}
		#endregion
		
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
		
		void CmbTipoCombSelectedIndexChanged(object sender, EventArgs e)
		{
			getID_COM();
		}
		
		void getID_COM()
		{
			String consulta = "select P.ID, T.NOMBRE from TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and ESTATUS='1' and T.NOMBRE='"+cmbTipoComb.Text+"'";
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
		
		void TxtNumUnidadEnter(object sender, EventArgs e)
		{
			txtNumUnidad.SelectAll();
		}
		
		void TxtGasolineraEnter(object sender, EventArgs e)
		{
			txtGasolinera.SelectAll();
		}
		
		void TxtOperadorEnter(object sender, EventArgs e)
		{
			txtOperador.SelectAll();
		}
		
		
		#region EVENTO TXTKMS
		void TxtKmsKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				if(txtKms.Text!="")
				{
					if(Convert.ToDouble(txtKms.Text)>0)
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
				if(Convert.ToDouble(txtKms.Text)>0)
				{
					cmdGuardar.Enabled=true;	
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
		#endregion
	}
}
