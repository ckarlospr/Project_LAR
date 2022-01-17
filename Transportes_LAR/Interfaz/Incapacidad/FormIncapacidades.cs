
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Incapacidad
{
	public partial class FormIncapacidades : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal=null;
		#endregion
		
		#region VARIABLES
		int ID_Operador = 0;
		String Tipo = "";
		String Motivo = "";
		#endregion
		
		#region CONSTRUCTORES
		public FormIncapacidades()
		{
			InitializeComponent();
		}
		
		public FormIncapacidades(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		void BtnGuardarEditarClick(object sender, EventArgs e)
		{	
			Insertar();
		}
		
		#region INICIO CERRADO
		void FormIncapacidadesFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.incapacidad = false;
		}
		
		void FormIncapacidadesLoad(object sender, EventArgs e)
		{
			Adaptador();
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			conn.getAbrirConexion("select FECHAINICIO, FECHAFIN from PERIODO WHERE FECHAINICIO <= '"+DateTime.Now.ToString("dd-MM-yyyy")+"' and FECHAFIN >= '"+DateTime.Now.ToString("dd-MM-yyyy")+"'");
			conn.leer=conn.comando.ExecuteReader();
            if(conn.leer.Read())
            {
            	dtInicio.Value = (Convert.ToDateTime(conn.leer["FECHAINICIO"]));
            	dtCorte.Value = (Convert.ToDateTime(conn.leer["FECHAFIN"]));
			}
			conn.conexion.Close();
		}
		#endregion
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Insertar()
		{	
			if(txtAlias.Text!=""&&Motivo!=""&&Tipo!="")
			{
				new Conexion_Servidor.Incapacidad.SQL_Incapacidad().InsertarIncapacidad(ID_Operador.ToString(), Tipo, dtInicio.Value.ToString().Substring(0,10), dtCorte.Value.ToString().Substring(0,10), Motivo);
				Adaptador();
			}
			else
				MessageBox.Show("Existen Campos sin llenar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		void RInicialEnter(object sender, EventArgs e)
		{
			Tipo = rInicial.Text;
		}
		
		void RSubsecuenteEnter(object sender, EventArgs e)
		{
			Tipo = rSubsecuente.Text;
		}
		
		void RGeneralEnter(object sender, EventArgs e)
		{
			Motivo = rGeneral.Text;
		}
		
		void RRiesgoEnter(object sender, EventArgs e)
		{
			Motivo = rRiesgo.Text;
		}
		
		void RMaternidadEnter(object sender, EventArgs e)
		{
			Motivo = rMaternidad.Text;
		}
		
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      {
					try
					{
						ID_Operador = (Convert.ToInt32(new Conexion_Servidor.Incapacidad.SQL_Incapacidad().ID(txtAlias.Text)));
						DatosOperador();
					}
					catch
					{
						MessageBox.Show("Operador NO Encotrado", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						if (dataIncapacidad.Rows.Count > 0)
							for (int i = dataIncapacidad.Rows.Count - 1; i >= 0; i--)
								dataIncapacidad.Rows.RemoveAt(i);
						txtNombreAnticipos.Text = "";
					}
		      }
		}
		
		void Adaptador()
		{
			dataIncapacidad.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select I.ID_INCAPACIDAD as ID_INCAPACIDAD, O.alias as Alias, I.tipo as Tipo_incapacidad, I.Fecha_Inicio as Fecha_Inicio, I.Fecha_Fin as Fecha_Fin, I.motivo as motivos from OPERADOR O, INCAPACIDAD I where O.ID=I.ID_OPERADOR and Fecha_Fin>='"+DateTime.Now.ToString("yyyy-MM-dd")+"' order by alias");
		}
		
		void Adaptador2(String alias)
		{
			dataIncapacidad.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select I.ID_INCAPACIDAD as ID_INCAPACIDAD, O.alias as Alias, I.tipo as Tipo_incapacidad, I.Fecha_Inicio as Fecha_Inicio, I.Fecha_Fin as Fecha_Fin, I.motivo as motivos from OPERADOR O, INCAPACIDAD I where O.ID=I.ID_OPERADOR and O.Alias = '"+alias+"' order by Fecha_Inicio desc");
		}
		
		#region DATOS OPERADOR
		void DatosOperador()
		{
			String Nombre = "";
			String alias = ""; 
			conn.getAbrirConexion("select O.Nombre, O.Apellido_Pat, O.Apellido_Mat, V.Numero, O.Alias from Operador O,  vehiculo V, ASIGNACIONUNIDAD AU where V.ID = AU.ID_UNIDAD and O.ID = AU.ID_OPERADOR and O.ID ="+ID_Operador);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				Nombre = conn.leer["Nombre"].ToString()+" "+conn.leer["Apellido_Pat"].ToString()+" "+conn.leer["Apellido_Mat"].ToString();
				alias = conn.leer["Alias"].ToString();
			}
			conn.conexion.Close();
			txtNombreAnticipos.Text = Nombre;
			Adaptador2(alias);
		}
		#endregion
		
		void DataIncapacidadCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==6)
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de eliminar este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Conexion_Servidor.Incapacidad.SQL_Incapacidad().EliminarIncapacidad((Convert.ToInt32(dataIncapacidad[0,e.RowIndex].Value)));
					Adaptador();
				}
			}
		}
	}
}
