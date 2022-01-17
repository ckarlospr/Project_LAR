using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones
{
	public partial class FormRutasCercanas : Form
	{
		public int id_op=-1;
		public String nomOp="";
		public List<String> listRutas = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		
		public FormRutasCercanas(int id, String name)
		{
			InitializeComponent();
			id_op=id;
			nomOp=name;
		}
		
		void FormRutasCercanasLoad(object sender, EventArgs e)
		{
			lblNombreOp.Text=nomOp;
			cargaRutas();
		}
		
		public void cargaRutas()
		{
			/*listRutas = new Conexion_Servidor.Desapacho.SQL_Operaciones().getRutaOp(id_op);
			try
			{
				for(int x=0; x<listRutas.Count; x++)
				{
					dtgRutas.Rows.Add(listRutas[x]);
				}
			}
			catch
			{
				this.Close();
			}*/
			
			String consulta = "select C.Empresa, R.Nombre from Cliente C, RUTA R, OPERADOR OP, OPERACION O, OPERACION_OPERADOR OO " +
				"where C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and OO.id_operador=OP.ID and OO.id_operacion=O.id_operacion  and OP.ID="+id_op+" and C.Empresa!='Especiales' and R.TIPO='NRM' " +
				"group by C.Empresa, R.Nombre " +
				"order by C.Empresa, R.Nombre";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtgRutas.Rows.Add(conn.leer["Empresa"].ToString(),conn.leer["Nombre"].ToString());
			}
			conn.conexion.Close();
		}
	}
}
