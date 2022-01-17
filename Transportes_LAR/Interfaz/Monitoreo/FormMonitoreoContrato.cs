using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Monitoreo
{
	public partial class FormMonitoreoContrato : Form
	{
		#region VARIABLES
		private bool falta=true;
		private bool vencido=true;		
		public bool contratoCerrado=false;
		DateTime Fecha = DateTime.Now;
		#endregion
		
		#region INSTANCIAS
		public Interfaz.FormPrincipal principal=null;
		private Interfaz.Contrato.FormDatoContrato formDatoContrato=null;
		private Interfaz.Contrato.FormHistorialContrato formHistorialContrato=null;
		public Interfaz.FormLogin login=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTOR
		public FormMonitoreoContrato(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region  EVENTO ( LOAD - CLOSING )
		void FormMonitoreoContratoLoad(object sender, EventArgs e)
		{
			getContenidoTabla();
			 if(vencido)
			 {
				if(dataVencimiento.Rows.Count>0)
				{
					MessageBox.Show("Existen operadores con contratos vencidos.","Contrato vencido",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
			if(falta)
			{
				if(dataFaltante.Rows.Count>0)
				{
					MessageBox.Show("Existen operadores sin contrato.","Operador sin contrato",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
		}
		
		public void FormMonitoreoContratoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.toolContrato.Visible=true;
			principal.contrato=false;
			this.contratoCerrado=true;
		}
		#endregion
		
		#region CARGAR_CONTENIDO_EN_LA_TABLA
		private void getContenidoTabla()
		{
			dataFaltante.DataSource=		new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, Alias, tipo_empleado from OPERADOR where Estatus='1'and Alias!='Admvo' and Alias!='ADMINOO' and tipo_empleado!='Externo' and ID not in (select IdOperador from OperadorContrato) order by Alias");		
			AdaptadorVencimiento();
			
			if(dataFaltante.Rows.Count==0)
			{
				tabControl1.TabPages.Remove(this.tabPage1);
				falta=false;
			}
			
			if(dataVencimiento.Rows.Count==0)
			{
				tabControl1.TabPages.Remove(this.tabPage2);
				vencido=false;
			}
			
			if((dataFaltante.Rows.Count==0)&&(dataVencimiento.Rows.Count==0))
			{
				this.WindowState = FormWindowState.Minimized;
			}
		}
		#endregion
		
		#region EVENTO_BOTONES ( ACEPTAR - GENERAR_CONTRATO - HISTORIA_CONTRATO )
		void BtnAceptarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnGenerarContratoClick(object sender, EventArgs e)
		{
			if(principal.datoContrato==false)
			{
				if(tabControl1.SelectedTab.Name=="tabPage1" && dataFaltante.Rows.Count>0){
					
					string idOperador=dataFaltante[0,dataFaltante.CurrentRow.Index].Value.ToString();
					formDatoContrato=new Interfaz.Contrato.FormDatoContrato(principal, idOperador);					
					principal.datoContrato=true;
					formDatoContrato.Show();
					
					
				}else if(tabControl1.SelectedTab.Name=="tabPage2" && dataVencimiento.Rows.Count>0){
					
					string idOperador=dataVencimiento[0,dataVencimiento.CurrentRow.Index].Value.ToString();
					formDatoContrato=new Interfaz.Contrato.FormDatoContrato(principal, idOperador);
					principal.datoContrato=true;
					formDatoContrato.Show();
					
				}else{
					
					MessageBox.Show("Proceso negado debido a que no existen operadores con contrato vencido o contrato faltante.","Generar contrato",MessageBoxButtons.OK,MessageBoxIcon.Information);
					
				}
				
			}
			else
			{
				MessageBox.Show("La ventana ya esta abierta.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		
		void BtnHistorialClick(object sender, EventArgs e){
			if(principal.historialContrato==true)
			{
				MessageBox.Show("La ventana ya esta abierta.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			else
			{
				formHistorialContrato=new Transportes_LAR.Interfaz.Contrato.FormHistorialContrato(principal);
				formHistorialContrato.WindowState = FormWindowState.Maximized;
				formHistorialContrato.Show();
				formHistorialContrato.MdiParent=principal;
				principal.historialContrato=true;
			}
		}
		
		#endregion
		
		#region COLOR
		public void color()
		{
			for(int x=0;x<dataFaltante.RowCount; x++)
			{
				if(dataFaltante[2,x].Value.ToString()==("OPERADOR"))
			    {
					
			    }
				else
				{
					dataFaltante[1,x].Style.BackColor=Color.LightSkyBlue;
				}
			}
		}
		#endregion
		
		#region ADAPTADOR VENCIMIENTO
		void AdaptadorVencimiento()
		{
			int contador = 0;
	
			dataVencimiento.Rows.Clear();
			dataVencimiento.ClearSelection();
			
			conn.getAbrirConexion("select O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento from OPERADOR O, OperadorContrato OC where O.ID=OC.IdOperador and O.Estatus='1' and O.Alias!='Admvo' and O.Alias!='ADMINOO' AND OC.TipoContrato='Temporal' and O.ID not in (select IdOperador from OperadorContrato where TipoContrato='Planta') group by O.ID, O.Alias, O.tipo_empleado, OC.fecha_vencimiento order by O.Alias, OC.fecha_vencimiento");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataVencimiento.Rows.Add();
				dataVencimiento.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataVencimiento.Rows[contador].Cells[1].Value = conn.leer["Alias"].ToString();
				dataVencimiento.Rows[contador].Cells[2].Value = conn.leer["tipo_empleado"].ToString();
				dataVencimiento.Rows[contador].Cells[3].Value = conn.leer["fecha_vencimiento"].ToString().Substring(0,10);
				++contador;
			}
			conn.conexion.Close();
			
			for(int x=0; x<dataVencimiento.RowCount; x++)
			{
				if(dataVencimiento.RowCount-1>x)
				{
					if(dataVencimiento.Rows[x].Cells[1].Value.ToString()==dataVencimiento.Rows[x+1].Cells[1].Value.ToString())
					{
						dataVencimiento.Rows.RemoveAt(x);
						if(x>-1)
						{
							--x;
						}
					}
				}
			}
			
			for(int x=0; x<dataVencimiento.RowCount; x++)
			{
				if(dataVencimiento.RowCount-1>=x)
				{
					if((Convert.ToDateTime(dataVencimiento.Rows[x].Cells[3].Value))>(Convert.ToDateTime(Fecha.ToString().Substring(0,10))).AddDays(7))
					{
						dataVencimiento.Rows.RemoveAt(x);
						if(x>-1)
						{
							--x;
						}
					}
				}
			}
		}
		#endregion
		
		void DataFaltanteCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)
			{
				if(dataFaltante.Rows.Count>0 )
					{
						new Conexion_Servidor.Operador.SQL_Operador().getOperador(dataFaltante[0,dataFaltante.CurrentRow.Index].Value.ToString(),ptbImagen, txtAlias , txtNombre , txtApellidoP , txtApellidoM, cmbTipo);
					}
			}
		}
		
		void DataVencimientoCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>=0)
			{
				if(dataVencimiento.Rows.Count>0 )
				{
					new Conexion_Servidor.Operador.SQL_Operador().getOperador(dataVencimiento[0,dataVencimiento.CurrentRow.Index].Value.ToString(),ptbImagen, txtAlias , txtNombre , txtApellidoP , txtApellidoM, cmbTipo);
				}
			}
		}
	}
}
