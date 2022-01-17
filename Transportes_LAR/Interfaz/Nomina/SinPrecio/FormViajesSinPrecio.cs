using System;
using System.Drawing;
using System.Windows.Forms;
 

namespace Transportes_LAR.Interfaz.Nomina.SinPrecio
{
	public partial class FormViajesSinPrecio : Form
	{
		#region VARIABLES
		String FechaInicio;
		String FechaCorte;
		String Fechecarpeta;
		#endregion 
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTOR
		public FormViajesSinPrecio()
		{
			InitializeComponent();
		}
		
		public FormViajesSinPrecio(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormViajesSinPrecioLoad(object sender, EventArgs e)
		{
			Fechecarpeta = DateTime.Now.ToString("yyyy-MM-dd");
			dtInicio.Value = DateTime.Now.AddDays(-15);
			dtCorte.Value = DateTime.Now;
			Consulta();
		}
		
		void FormViajesSinPrecioFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.rutas0 = false;
		}
		#endregion
		
		#region EVENTO DATETIME
		void DtInicioValueChanged(object sender, EventArgs e)
		{
			FechaInicio = (dtInicio.Value.ToShortDateString());
			FechaCorte = (dtCorte.Value.ToShortDateString());
			Consulta();
		}
		
		void DtCorteValueChanged(object sender, EventArgs e)
		{
			FechaInicio = (dtInicio.Value.ToShortDateString());
			FechaCorte = (dtCorte.Value.ToShortDateString());
			Consulta();
		}
		#endregion
		
		#region GUARDAR
		void BtnAceptarClick(object sender, EventArgs e)
		{
			Actualizar();
		}
		
		void Actualizar()
		{
			for(int a = 0; a<(dataViajesNormales.RowCount); a++)
			{
				if((dataViajesNormales.Rows[a].Cells[9].Value!=null)&&(dataViajesNormales.Rows[a].Cells[10].Value!=null))
					{
					string sentencia = "";
					sentencia = "UPDATE RUTA SET SencilloCamion='"+(Convert.ToDouble(dataViajesNormales.Rows[a].Cells[9].Value))+"', SencilloCamioneta='"+(Convert.ToDouble(dataViajesNormales.Rows[a].Cells[9].Value))+"', SencilloForaneo='"+(Convert.ToDouble(dataViajesNormales.Rows[a].Cells[9].Value))+"', CompletoCamion='"+(Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value))+"', CompletoCamioneta='"+(Convert.ToDouble(dataViajesNormales.Rows[a].Cells[10].Value))+"', CompletoForaneo='"+(dataViajesNormales.Rows[a].Cells[10].Value).ToString()+"', kilometros='"+(dataViajesNormales.Rows[a].Cells[8].Value).ToString()+"' WHERE ID ="+dataViajesNormales.Rows[a].Cells[0].Value;
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();	
					}
		    }
			Consulta();
		}	
		#endregion	
		
		#region CONSULTA
		void Consulta()
		{
			int contador = 0;
			
			dataViajesNormales.Rows.Clear();
			dataViajesNormales.ClearSelection();
			string sentencia = "select R.ID, O.fecha as Fecha,C.SubNombre, R.Nombre, R.HoraInicio, O.turno As Turno, OO.vehiculo as Vehiculo, R.sentido as Sentido, OP.Alias, R.kilometros " +
								"from OPERACION_OPERADOR OO, OPERACION o, RUTA R, Cliente C, OPERADOR OP " +
								"where o.id_ruta=R.ID and O.estatus='1' and C.ID=R.IdSubEmpresa " +
								"and OO.id_operador=OP.ID and OO.id_operacion=o.id_operacion AND (R.SencilloCamion='0' or R.kilometros='0') and R.Tipo!='NRM' " +
								"and o.fecha between '"+FechaInicio+"' AND '"+FechaCorte+"'";
			
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataViajesNormales.Rows.Add();
				dataViajesNormales.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataViajesNormales.Rows[contador].Cells[1].Value = conn.leer["Fecha"].ToString().Substring(0,10);
				dataViajesNormales.Rows[contador].Cells[2].Value = conn.leer["HoraInicio"].ToString();
				dataViajesNormales.Rows[contador].Cells[3].Value = conn.leer["SubNombre"].ToString();
				dataViajesNormales.Rows[contador].Cells[4].Value = conn.leer["Nombre"].ToString();
				dataViajesNormales.Rows[contador].Cells[5].Value = conn.leer["Sentido"].ToString();
				dataViajesNormales.Rows[contador].Cells[6].Value = conn.leer["Turno"].ToString();
				dataViajesNormales.Rows[contador].Cells[7].Value = conn.leer["Vehiculo"].ToString();
				dataViajesNormales.Rows[contador].Cells[8].Value = conn.leer["Kilometros"].ToString();
				dataViajesNormales.Rows[contador].Cells[11].Value = conn.leer["Alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			Colores();
		}
		#endregion
		
		#region COLORES
		void Colores()
		{
			for(int x=0; x<dataViajesNormales.Rows.Count; x++)
			{
				for(int y=0; y<dataViajesNormales.ColumnCount; y++)
				{
					if(x%2==0)
						dataViajesNormales.Rows[x].Cells[y].Style.BackColor = Color.Gainsboro;
					else
						dataViajesNormales.Rows[x].Cells[y].Style.BackColor = Color.White;
				}
			}
		}
		
		void DataViajesNormalesColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Colores();
		}
		
		void DataViajesNormalesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				if(dataViajesNormales.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor.Name=="SteelBlue")
					dataViajesNormales.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
			}
		}
		#endregion
		
	}
}
