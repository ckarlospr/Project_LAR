using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Transportes_LAR.Interfaz.Contrato
{
	public partial class FormHistorialContrato : Form
	{
		#region INSTANCIAS
		private Interfaz.FormPrincipal principal=null;
		private Interfaz.Contrato.FormDatoContrato formDatoContrato=null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.Excel Excels = new Proceso.Excel();
		#endregion
		
		#region VARIABLES
		public string IDDato="";
		int ID_Contrato = 0;
		#endregion
		
		#region CONSTRUCTORES
		public  FormHistorialContrato(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		
		public FormHistorialContrato()
		{
			InitializeComponent();
		}
		#endregion
		
		#region EVENTOS
		void TxtAliasTextChanged(object sender, EventArgs e)
		{
			dataContrato.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select o.Alias,  oc.* from OperadorContrato oc, Operador o where oc.IdOperador = o.ID and o.Estatus='1' and o.Alias like '"+txtAlias.Text+"%'");
			color();
		}
		
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			dataContrato.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select o.Alias, oc.*, o.Nombre from OperadorContrato oc, Operador o where oc.IdOperador = o.ID and o.Estatus='1' and o.Nombre like '"+txtNombre.Text+"%'");
			color();
		}
		
		void TxtApellidoPTextChanged(object sender, EventArgs e)
		{
			dataContrato.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select o.Alias, oc.*, o.Apellido_Pat from OperadorContrato oc, Operador o where oc.IdOperador = o.ID and o.Estatus='1' and o.Apellido_Pat like '"+txtApellidoP.Text+"%'");
			color();
		}
		
		void TxtApellidoMTextChanged(object sender, EventArgs e)
		{
			dataContrato.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select o.Alias, oc.*, o.Apellido_Mat from OperadorContrato oc, Operador o where oc.IdOperador = o.ID and o.Estatus='1' and o.Apellido_Mat like '"+txtApellidoM.Text+"%'");
			color();

		}
		
		void DataContratoClick(object sender, EventArgs e)
		{
			color();
		}
		
		void DataContratoMouseClick(object sender, MouseEventArgs e)
		{
			color();
		}
		
		void DataContratoMouseLeave(object sender, EventArgs e)
		{
			color();
		}
		
		void DataContratoMouseHover(object sender, EventArgs e)
		{
			color();
		}
		#endregion
		
		#region EVENTOS BOTONES
		void BtnModificarClick(object sender, EventArgs e)
		{
			if(principal.datoContrato==true)
				MessageBox.Show("La ventana se encuentra abierta.","Ventana",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			else
			{
				formDatoContrato = new Interfaz.Contrato.FormDatoContrato(principal, dataContrato[1,dataContrato.CurrentRow.Index].Value.ToString(), dataContrato[2,dataContrato.CurrentRow.Index].Value.ToString(), dataContrato[27,dataContrato.CurrentRow.Index].Value.ToString(), dataContrato[3,dataContrato.CurrentRow.Index].Value.ToString(), dataContrato[26,dataContrato.CurrentRow.Index].Value.ToString());
				principal.datoContrato=true;
				formDatoContrato.btnAceptar.Text= "Modificar";
				formDatoContrato.MdiParent=principal;
				formDatoContrato.Show();
			}
		}
		
		void BtnReporteClick(object sender, EventArgs e)
		{
			GenerarReporteHistorialContrato();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			DialogResult boton1 = MessageBox.Show("Desea Eliminar este contrato?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (boton1 == DialogResult.Yes)
				new Conexion_Servidor.Contrato.SQL_Contrato().EliminarContrato(ID_Contrato);
			
			dataContrato.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select o.Alias, oc.*, o.Nombre from OperadorContrato oc, Operador o where oc.IdOperador = o.ID and o.Estatus='1' and o.Nombre like '"+txtNombre.Text+"%'");
		}
		#endregion
		
		#region METODOS GENERACION REPORTES
		public void GenerarReporteHistorialContrato()
		{
			Excels.Historial_Contrato(dataContrato);
		}
		#endregion
		
		#region EVENTO INICIO - CERRADO
		void FormHistorialContratoLoad(object sender, EventArgs e)
		{
			dataContrato.DataSource=new Conexion_Servidor.Contrato.SQL_Contrato().getTabla("select o.Alias, oc.* from OperadorContrato oc, Operador o where oc.IdOperador = o.ID and o.Estatus='1' ");
			color();
			txtApellidoM.AutoCompleteCustomSource = auto.AutocompleteApeMaT();
			txtApellidoM.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtApellidoM.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtApellidoP.AutoCompleteCustomSource =auto.AutocompleteApePat();
			txtApellidoP.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtApellidoP.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtNombre.AutoCompleteCustomSource = auto.AutocompleteNombre();
			txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' ", "Alias");
			txtAlias.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		void FormHistorialContratoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.historialContrato=false;
		}
		#endregion
		
		#region COLOR
		public void color()
		{
			for(int x=0;x<dataContrato.RowCount; x++)
			{
				DateTime fechaContrato = Convert.ToDateTime(dataContrato[3,x].Value.ToString());
				DateTime Hoy = DateTime.Today;
				for(int y=0; y<dataContrato.ColumnCount;y++)
				{
					if(fechaContrato<Hoy)
						dataContrato[y,x].Style.BackColor=Color.Beige;
				}
			}
		}
		#endregion
		
		#region SELECCIONAR
		void DataContratoCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			ID_Contrato = 0;
			if(e.RowIndex>-1)
				ID_Contrato = (Convert.ToInt32(dataContrato.Rows[e.RowIndex].Cells[1].Value));
		}
		#endregion
		
	}
}
