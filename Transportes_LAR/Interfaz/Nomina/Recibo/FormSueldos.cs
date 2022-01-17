using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Recibo
{
	public partial class FormSueldos : Form
	{
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region VARIABLES
		String tipo_empleado="";
		#endregion
		
		#region CONSTRUCTOR
		public FormSueldos()
		{
			InitializeComponent();
		}
		
		public FormSueldos(Interfaz.FormPrincipal principal, String tipo_Emple)
		{
			InitializeComponent();
			this.principal=principal;
			this.tipo_empleado=tipo_Emple;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormSueldosLoad(object sender, EventArgs e)
		{	
			if(tipo_empleado=="OPERADOR")
			{
				dataImpuestos.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select S.ID_OPERADOR as ID, O.Alias, S.INFONAVIT, S.IMSS, S.ISR, S.Telcel, S.SUELDO_BASE, S.ID_SUELDO as Clave, S.aguinaldo as Aguinaldo, S.Compensacion as Compensacion, S.Retener as Retener from OPERADOR O, SUELDO S where O.Alias!='Admvo' and O.Estatus='1' and O.tipo_empleado='Operador' and O.ID=S.ID_OPERADOR order by O.Alias");
				txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
	           	txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			}
			else
			{
				dataImpuestos.DataSource=new Conexion_Servidor.Operador.SQL_Operador().getTabla("select S.ID_OPERADOR as ID, O.Alias, S.INFONAVIT, S.IMSS, S.ISR, S.Telcel, S.SUELDO_BASE, S.ID_SUELDO as Clave, S.aguinaldo as Aguinaldo, S.Compensacion as Compensacion, S.Retener as Retener from OPERADOR O, SUELDO S where O.Alias!='Admvo' and O.Estatus='1' and O.tipo_empleado!='Operador' and O.ID=S.ID_OPERADOR order by O.Alias");
				txtAlias.AutoCompleteCustomSource = auto.AutocompleteActivoAdmin();
	           	txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			}
            Colores();
            cmbVista.SelectedIndex = 0;
		}
		
		void FormSueldosFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.sueldosbool=false;
		}
		#endregion
		
		#region GUARDAR MODIFICACIONES
		void ModificarPercepciones()
		{
			for(int a = 0; a<(dataImpuestos.RowCount); a++)
				{
					try
					{
					string sentencia = "";
					sentencia = "UPDATE SUELDO SET INFONAVIT="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[2].Value))+", IMSS="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[3].Value))+", ISR="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[4].Value))+", Telcel="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[5].Value))+", SUELDO_BASE="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[6].Value))+", Aguinaldo="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[8].Value))+", Compensacion="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[9].Value))+", Retener="+(Convert.ToDouble(dataImpuestos.Rows[a].Cells[10].Value))+" WHERE ID_SUELDO="+dataImpuestos.Rows[a].Cells[7].Value;
					conn.getAbrirConexion(sentencia);
					conn.comando.ExecuteNonQuery();
					}
					catch(Exception ex)
					{
						MessageBox.Show("Ocurrio una Exception: "+ex);
					}
					conn.conexion.Close();	
			    }
		}
		#endregion
		
		#region VALIDAR
		void DataImpuestosEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			((TextBox)e.Control).KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosPunto);
		}
		#endregion
		
		#region BOTONES
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnGuardarEditarClick(object sender, EventArgs e)
		{
			ModificarPercepciones();
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
		
		void DataImpuestosMouseEnter(object sender, EventArgs e)
		{
			Colores();
		}
		#endregion
		
		#region BUSCADOR OPERADOR
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				for(int x=0; x<dataImpuestos.Rows.Count; x++)
				{
					if(txtAlias.Text==dataImpuestos.Rows[x].Cells[1].Value.ToString())
						{
							dataImpuestos.ClearSelection();
							dataImpuestos.Rows[x].Cells[1].Selected = true;
							dataImpuestos.FirstDisplayedCell = dataImpuestos.Rows[x].Cells[1];
							for(int y=0; y<dataImpuestos.ColumnCount;y++)
								dataImpuestos.Rows[x].Cells[y].Style.BackColor = Color.LightSteelBlue;
						}
				}
				DatosOperador(txtAlias.Text);
			}
		}
		#endregion
		
		#region DATOS OPERADOR
		void DatosOperador(String AliasOP)
		{
			String Nombre = "";
			conn.getAbrirConexion("select O.Nombre, O.Apellido_Pat, O.Apellido_Mat from Operador O where O.Alias='"+AliasOP+"'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				Nombre = conn.leer["Nombre"].ToString()+" "+conn.leer["Apellido_Pat"].ToString()+" "+conn.leer["Apellido_Mat"].ToString();

			conn.conexion.Close();
			txtNombre.Text = Nombre;
		}
		#endregion
		
		#region VISTA
		void CmbVistaSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbVista.Text=="Normal")
			{
				dataImpuestos.Columns[8].Visible=false;
				dataImpuestos.Columns[9].Visible=false;
				dataImpuestos.Columns[10].Visible=false;
			}
			else
			{
				dataImpuestos.Columns[8].Visible=true;
				dataImpuestos.Columns[9].Visible=true;
				dataImpuestos.Columns[10].Visible=true;
			}
		}
		#endregion
		
	}
}
