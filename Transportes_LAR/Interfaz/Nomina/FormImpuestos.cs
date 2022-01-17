using System;
using System.Drawing;
using System.Windows.Forms;
 

namespace Transportes_LAR.Interfaz.Nomina
{
	public partial class FormImpuestos : Form
	{
		#region INSTANCIAS
		Interfaz.Nomina.FormNomina formnomina = null;
		Interfaz.FormPrincipal formPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region VARIABLES
		public String ShortFecha = "";
		String Valor = "";
		#endregion
		
		#region CONSTRUCTORES
		public FormImpuestos(Interfaz.Nomina.FormNomina NOMINA, String Sueldo)
		{
			InitializeComponent();
			this.formnomina = NOMINA;
			this.Valor = Sueldo;
		}
		
		public FormImpuestos(Interfaz.FormPrincipal formPrincipal, String Telcel)
		{
			InitializeComponent();
			this.formPrincipal = formPrincipal;
			this.Valor = Telcel;
		}
		#endregion
		
		#region EVENTO LOAD - CERRADO
		void FormImpuestosLoad(object sender, EventArgs e)
		{
			ShortFecha = DateTime.Now.ToString().Substring(0,10);
			AdaptadorQuincenal();
			Colores();
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		void FormImpuestosFormClosing(object sender, FormClosingEventArgs e)
		{
			if(Valor=="Telcel")
				formPrincipal.prestamos = false;
			else
				formnomina.prestamos = false;
		}
		#endregion
		
		#region BOTONES
		void CmdGuardarClick(object sender, EventArgs e)
		{
			Excels.ReporteQuincenal(dataImpuestos);
		}
		#endregion
		
		#region COLORES
		void Colores()
		{
			for(int x=0; x<dataImpuestos.Rows.Count; x++)
			{
				for(int y=0; y<dataImpuestos.ColumnCount; y++)
				{
					if(x%2==0)
						dataImpuestos.Rows[x].Cells[y].Style.BackColor = Color.Gainsboro;
				}
			}
		}
		
		void DataImpuestosEnter(object sender, EventArgs e)
		{
			Colores();
		}
		
		void DataImpuestosColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Colores();
		}
		#endregion
		
		#region HISTORIAL QUINCENAL
		void AdaptadorQuincenal()
		{
			int contador = 0;
			dataImpuestos.Rows.Clear();
			dataImpuestos.ClearSelection();
			String sentencia = "select alias " +
								"from OPERADOR " +
								"where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' " +
								"order by alias";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataImpuestos.Rows.Add();
				dataImpuestos.Rows[contador].Cells[0].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			
			String sentencia2 = "select FECHAINICIO, FECHAFIN " +
								"from PERIODO " +
								"where FECHAFIN<='"+ShortFecha+"'";
			conn.getAbrirConexion(sentencia2);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				DataGridViewTextBoxColumn txt =new DataGridViewTextBoxColumn();
				
				txt.Name = conn.leer["FECHAINICIO"].ToString().Substring(0,10)+" - "+conn.leer["FECHAFIN"].ToString().Substring(0,10);
			    txt.HeaderText = conn.leer["FECHAINICIO"].ToString().Substring(0,10)+" - "+conn.leer["FECHAFIN"].ToString().Substring(0,10);
			    //dataImpuestos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
			    dataImpuestos.Columns.Add(txt);
				//txt.HeaderCell.Style = StringAlignment.
				//dataImpuestos.Columns[0].HeaderCell.
			}
			conn.conexion.Close();
			
			if(Valor=="Telcel")
			{
				for(int z=0; z<dataImpuestos.Rows.Count; z++)
				{
				 for(int y=1; y<dataImpuestos.ColumnCount; y++)
					{
						String sentencia3 = "select n.Telcel, n.fecha_inicio, n.FECHA_FIN " +
											"from nomina n, operador o " +
											"where n.IdOperador=o.ID and o.alias='"+dataImpuestos.Rows[z].Cells[0].Value.ToString()+"'";
						conn.getAbrirConexion(sentencia3);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							if(conn.leer["fecha_inicio"].ToString().Substring(0,10)+" - "+conn.leer["FECHA_FIN"].ToString().Substring(0,10)==dataImpuestos.Columns[y].HeaderText)
								dataImpuestos.Rows[z].Cells[y].Value = (Convert.ToDouble(conn.leer["Telcel"])).ToString("C");
						}
						conn.conexion.Close();
			    	}
			 	}
			}
			else
			{
			 for(int z=0; z<dataImpuestos.Rows.Count; z++)
				{
				 for(int y=1; y<dataImpuestos.ColumnCount; y++)
					{
						String sentencia3 = "select n.Sueldo_Total, n.fecha_inicio, n.FECHA_FIN " +
											"from nomina n, operador o " +
											"where n.IdOperador=o.ID and o.alias='"+dataImpuestos.Rows[z].Cells[0].Value.ToString()+"'";
						conn.getAbrirConexion(sentencia3);
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
							if(conn.leer["fecha_inicio"].ToString().Substring(0,10)+" - "+conn.leer["FECHA_FIN"].ToString().Substring(0,10)==dataImpuestos.Columns[y].HeaderText)
								dataImpuestos.Rows[z].Cells[y].Value = (Convert.ToDouble(conn.leer["Sueldo_Total"])).ToString("C");
						}
						conn.conexion.Close();
			    	}
			 	}
			}
		}
		#endregion
		
		#region BUSCADOR OPERADOR
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				for(int x=0; x<dataImpuestos.Rows.Count; x++)
				{
					if(txtAlias.Text==dataImpuestos.Rows[x].Cells[0].Value.ToString())
						{
							dataImpuestos.ClearSelection();
							dataImpuestos.Rows[x].Cells[0].Selected = true;
							dataImpuestos.FirstDisplayedCell = dataImpuestos.Rows[x].Cells[0];
							for(int y=0; y<dataImpuestos.ColumnCount;y++)
							{
								dataImpuestos.Rows[x].Cells[y].Style.BackColor = Color.LightSteelBlue;
							}
						}
				}
			}
		}
		#endregion
	}
}
