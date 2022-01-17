using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Ruta
{
	public partial class FormProgramaRutas : Form
	{
		public FormProgramaRutas(FormPrincipal refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#region REFERENCIAS
		FormPrincipal refPrincipal;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		#endregion
		
		#region EVENTO LOAD
		void FormProgramaRutasLoad(object sender, EventArgs e)
		{
			getProgramadas();
		}
		#endregion
		
		#region GET PROGRAMADAS
		void getProgramadas()
		{
			dgForsac.Rows.Clear();
			String consulta = 	"select R.ID, R.Nombre, R.extra, R.Sentido, R.Turno " +
								"from RUTA R, Cliente C " +
								"where R.IdSubEmpresa=C.ID and R.nombre like '%(B)%' and TIPO='EXT' and C.Empresa like '%forsa%' and R.ID>32975 " +
								"order by R.extra desc, R.Turno";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgForsac.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["extra"].ToString(), conn.leer["Turno"].ToString(), conn.leer["Sentido"].ToString());
			}
			conn.conexion.Close();
			dgForsac.ClearSelection();
		}
		#endregion
		
		#region EVENTO BOTONES
		void BtnManianaClick(object sender, EventArgs e)
		{
			guardaRuta("Maniana");
		}
		
		void BtnTardeClick(object sender, EventArgs e)
		{
			guardaRuta("Tarde");
		}
		#endregion
		
		#region GUARDADO Y BORRADO
		void guardaRuta(String tipo)
		{
			if(tipo=="Tarde")
			{
				DateTime fecha2;
				fecha2 = dtpTarde.Value.AddDays(1);
				
				String consul = "Insert into RUTA values ('(B) ANGEL LEAÑO','Vespertino','Entrada','40','17:30','N/A','60','70','70','90','70','90','26','1','10000000','"+dtpTarde.Value.ToString("yyyy-MM-dd")+"','0','00:00:00.0000000','EXT','0','0','0','0','', '00:00')";
				conn.getAbrirConexion(consul); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();

				consul = "Insert into RUTA values ('(B) ANGEL LEAÑO','Mañana','Salida','40','07:15','N/A','60','70','70','90','70','90','26','1','10000000','"+fecha2.ToString("yyyy-MM-dd")+"','0','00:00:00.0000000','EXT','0','0','0','0','', '00:00')";
				conn.getAbrirConexion(consul); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();				
			}
			else
			{
				String consul = "Insert into RUTA values ('(B) ANGEL LEAÑO','Mañana','Entrada','40','05:20','N/A','60','70','70','90','70','90','26','1','10000000','"+dtpManiana.Value.ToString("yyyy-MM-dd")+"','0','00:00:00.0000000','EXT','0','0','0','0','', '00:00')";
				conn.getAbrirConexion(consul); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();	
				
				consul = "Insert into RUTA values ('(B) ANGEL LEAÑO','Vespertino','Salida','40','19:15','N/A','60','70','70','90','70','90','26','1','10000000','"+dtpManiana.Value.ToString("yyyy-MM-dd")+"','0','00:00:00.0000000','EXT','0','0','0','0','', '00:00')";
				conn.getAbrirConexion(consul); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();	
			}
			
			getProgramadas();
		}
		
		void eliminaRuta()
		{
			if(dgForsac.SelectedRows.Count==1)
			{
				try
				{
					String consul = "delete from RUTA where ID="+dgForsac[0,dgForsac.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(consul); 
					conn.comando.ExecuteNonQuery(); 
						
				}
				catch(Exception)
				{
					MessageBox.Show("No se pude eliminar la ruta");
				}
				finally
				{
					conn.conexion.Close();
				}
			}
			else
			{
				MessageBox.Show("Seleccione un registro");
			}
		}
		#endregion
	}
}
