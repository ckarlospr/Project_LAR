using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormCardexCoordinador : Form
	{
		public FormCardexCoordinador(Interfaz.Operaciones.FormPrin_Empresas refPrinc)
		{
			InitializeComponent();
			refPrincipal = refPrinc;
		}
		
		#region VARIABLES
		Int64 ID_OP=0;
		#endregion
		
		#region INSTANCIAS
		Interfaz.Operaciones.FormPrin_Empresas refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormCardexCoordinadorLoad(object sender, EventArgs e)
		{
			txtCoordinador.AutoCompleteCustomSource = auto.AutoReconocimiento("select UPPER(Alias) dato from OPERADOR where Estatus='1' and tipo_empleado like '%COORDI%'");
			txtCoordinador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtCoordinador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			cmbAnomalia.SelectedIndex=0;
		}
		#endregion
		
		#region SELECCION DE COORDINADOR
		void TxtCoordinadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consulta = "SELECT * FROM OPERADOR WHERE Alias='"+txtCoordinador.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_OP = Convert.ToInt64(conn.leer["ID"]);
					txtCoordinador.BackColor=Color.MediumSpringGreen;
					cmbAnomalia.Focus();
				}
				else
				{
					ID_OP = 0;
					txtCoordinador.BackColor=Color.White;
				}
				
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region SELECCION DE ANOMALIA
		void CmbAnomaliaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbAnomalia.Text=="OTRO")
			{
				txtAnomalia.Enabled=true;
				txtAnomalia.Focus();
			}
			else
			{
				txtAnomalia.Enabled=false;
				txtAnomalia.Text="";
			}
		}
		#endregion
		
		#region BOTON GUARDAR
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(ID_OP!=0)
			{
				if(txtComentario.Text!="")
				{
					guardaDatos();
					Limpia();
				}
				else
				{
					MessageBox.Show("Ingrese comentario");
				}
			}
			else
			{
				MessageBox.Show("Seleccione un operador");
			}
		}
		#endregion
		
		#region GUARDADO
		void guardaDatos()
		{
			String consulta ="INSERT INTO HISTORIAL_COORDINADOR VALUES " +
				"('"+refPrincipal.principal.idUsuario+"', '"+ID_OP+"', '"+cmbAnomalia.Text+"', '"+txtComentario.Text+"', '"+refPrincipal.principal.Turno+"', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', " +
				"(SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())), '1', '0');";
			
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();	
		}
		#endregion
		
		#region LIMPIA DATOS
		void Limpia()
		{
			txtCoordinador.Text="";
			txtAnomalia.Text="";
			txtComentario.Text="";
			ID_OP=0;
			txtCoordinador.BackColor=Color.White;
		}
		#endregion
	}
}
