using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Cliente
{
	public partial class FormHistorialEmpresa : Form
	{
		public FormHistorialEmpresa(Interfaz.Operaciones.FormPrin_Empresas refDesp, int id_Emp)
		{
			InitializeComponent();
			id_empresa=id_Emp;
			refDespacho=refDesp;
		}
		
		#region VARIABLES
		int id_empresa;
		bool seleccion;
		
		String problema;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		Interfaz.Operaciones.FormPrin_Empresas refDespacho = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region EVENTO LOAD
		void FormHistorialEmpresaLoad(object sender, EventArgs e)
		{
			txtEmpresa.AutoCompleteCustomSource = auto.AutoReconocimiento("select SubNombre dato from Cliente where nomenclatura!='A'");;
			txtEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			if(id_empresa!=0)
			{
				getDatos(id_empresa);
			}
			
			llenadoDatagrid();
			
			seleccion = false;
			problema = "";
		}
		#endregion
		
		#region GET EMPRESAS AL DATAGRID
		public void llenadoDatagrid()
		{
			dgEmpresa.Rows.Clear();
			
			String consulta = "select ID, SubNombre from Cliente where nomenclatura!='A' order by SubNombre";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				dgEmpresa.Rows.Add(conn.leer["ID"].ToString(),conn.leer["SubNombre"].ToString());
			}
			
			conn.conexion.Close();
			dgEmpresa.ClearSelection();
		}
		#endregion
		
		#region evento cellclick
		void DgEmpresaCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex>-1)
			{
				gbTipo.Enabled=true;
				//getDatos(Convert.ToInt16(dgEmpresa[0,e.RowIndex]));
			}
		}
		
		public void getDatos(int ID)
		{
			String consulta = "select * from HISTORIAL_EMPRESA where DIA='"+refDespacho.fecha_despacho+"' and TURNO='"+refDespacho.ConsTurno+"' and ID_C="+ID;
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				/*if(conn.leer["TIPO"].ToString()=="FALLA UNIDAD")
				{
					cbFUnidad.Checked=true;
					FUnidad = true;
				}
				if(conn.leer["TIPO"].ToString()=="FALLA OPERADOR")
				{
					cbFOperador.Checked=true;
					FOperador = true;
				}
				if(conn.leer["TIPO"].ToString()=="FALLA COORDINACION")
				{
					cbFCoordina.Checked=true;
					FCoordina = true;
				}
				if(conn.leer["TIPO"].ToString()=="FALTA DE UNIDAD")
				{
					cbFaltaUnidad.Checked=true;
					FaltaUnidad = true;
				}
				if(conn.leer["TIPO"].ToString()=="INCIDENTE")
				{
					cbIncidente.Checked=true;
					Incidente = true;
				}*/
			}
			
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTOS RADIO BUTTON
		void RbFUnidadCheckedChanged(object sender, EventArgs e)
		{
			problema="FALLA DE UNIDAD";
			seleccion=true;
		}
		
		void RbFOperadorCheckedChanged(object sender, EventArgs e)
		{
			problema="FALLA DE OPERADOR";
			seleccion=true;
		}
		
		void RbFCoordinaCheckedChanged(object sender, EventArgs e)
		{
			problema="FALLA DE COORDINACION";
			seleccion=true;
		}
		
		void RbFaltaUnidadCheckedChanged(object sender, EventArgs e)
		{
			problema="FALTA DE UNIDAD";
			seleccion=true;
		}
		
		void RbIncidenteCheckedChanged(object sender, EventArgs e)
		{
			problema="INCIDENTE";
			seleccion=true;
		}
		#endregion
		
		#region
		void CmdGuardarClick(object sender, EventArgs e)
		{
			String miconsult = "";
			
			if(txtComentario.Text != "")
			{
				if(seleccion==true)
				{
					miconsult = "insert into HISTORIAL_EMPRESA values ("+dgEmpresa[0, dgEmpresa.CurrentRow.Index].Value.ToString()+", '"+problema+"', '"+txtComentario.Text+"', '"+refDespacho.ConsTurno+"', '"+refDespacho.fecha_despacho+"', '"+refDespacho.principal.idUsuario+"', (SELECT CONVERT (date, SYSDATETIME())), (SELECT CONVERT(VARCHAR,getdate(),108)))";
					conn.getAbrirConexion(miconsult);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					this.Close();
				}
				else
				{
					MessageBox.Show("Es necesario la selección de un tipo de problema.");
				}
			}
			else
			{
				MessageBox.Show("Ingrese algun comentario.");
			}
		}
		#endregion
		
		#region	BUSQUEDA
		void TxtEmpresaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				for(int x=0; x<dgEmpresa.Rows.Count; x++)
				{
					if(txtEmpresa.Text==dgEmpresa[1,x].Value.ToString())
					{
						dgEmpresa.Rows[x].Selected=true;
						gbTipo.Enabled=true;
					}
				}
			}
		}
		#endregion
	}
}
