using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormReporteBonificaciones : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		Interfaz.FormPrincipal principal = null;
		#endregion
		
		#region CONSTRUCTORES
		public FormReporteBonificaciones()
		{
			InitializeComponent();
		}
		
		public FormReporteBonificaciones(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region BOTONES
		void BtnExcelClick(object sender, EventArgs e)
		{
			
		}
		#endregion
		
		#region ADAPTADORES
		public void AdaptadorOperador()
		{
			int contador = 0;
			dataBonos.Rows.Clear();
			dataBonos.ClearSelection();
			conn.getAbrirConexion("select O.Alias, O.Nombre, O.Apellido_pat, O.Apellido_mat, H.TIPO, H.Motivo, U.usuario, P.Fecha " +
                                  "from NUEVO_HISTORIAL_BONO_OPERADOR h, OPERADOR O, USUARIO U, PERDIDA_BONO P " +
                                  "WHERE U.ID_usuario=H.iD_USUARIO AND O.ID=H.ID_O AND H.ID=P.Id_Historial AND H.BONIFICACION='1' " +
                                  "AND P.FECHA between '"+dtInicio.Value.ToString("dd-MM-yyyy")+"' and '"+dtCorte.Value.ToString("dd-MM-yyyy")+"' ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataBonos.Rows.Add();
				dataBonos.Rows[contador].Cells[0].Value = conn.leer["FECHA"].ToString().Substring(0,10);
				dataBonos.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dataBonos.Rows[contador].Cells[2].Value = conn.leer["Nombre"].ToString();
				dataBonos.Rows[contador].Cells[3].Value = conn.leer["Apellido_pat"].ToString();
				dataBonos.Rows[contador].Cells[4].Value = conn.leer["Apellido_mat"].ToString();
				dataBonos.Rows[contador].Cells[5].Value = conn.leer["TIPO"].ToString();
				dataBonos.Rows[contador].Cells[6].Value = conn.leer["MOTIVO"].ToString();
				dataBonos.Rows[contador].Cells[7].Value = conn.leer["USUARIO"].ToString();
				++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			 AdaptadorOperador();
		}
		
		void DtCorteValueChanged(object sender, EventArgs e)
		{
			 AdaptadorOperador();
		}
		
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		       {
			 	  AdaptadorOperador();
			   }
		}
		
		void FormReporteBonificacionesLoad(object sender, EventArgs e)
		{
			dtInicio.Value.AddDays(-90);
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			AdaptadorOperador();
		}
	}
}
