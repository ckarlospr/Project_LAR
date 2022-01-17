using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormAsignOperadores : Form
	{
		public FormAsignOperadores(FormIngresoRapido formIngreso)
		{
			InitializeComponent();
			
			formIng = formIngreso;
		}
		
		#region VARIABLES
		int idOpApoya = 0;
		int columnSelect = 0;
		#endregion
		
		#region	REFERENCIAS
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		FormIngresoRapido formIng=null;
		#endregion
		
		#region VALIDACION
		private void getCargarValidacionCampos(FormAsignOperadores formAsig)
		{
			formAsig.txtOperador.KeyPress 		+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
		}
		#endregion
		
		#region EVENTO LOAD
		void FormAsignOperadoresLoad(object sender, EventArgs e)
		{
			txtOperador.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias Dato from OPERADOR where (ID in (select ID from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR)) OR tipo_empleado='Externo'");
	        txtOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
	        txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
	        
	        getCargarValidacionCampos(this);
		}
		#endregion
		
		#region SELECCION DE OPERADOR
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				MessageBox.Show(e.KeyCode.ToString()+" 1:1 "+e.KeyValue.ToString());
			}
			if(txtOperador.Text!="")
			{
				cmdAgregar.Enabled=true;
			}
		}
		#endregion
		
		#region EVENTO BOTONES
		#region AGREGA OPERADOR
		void CmdAgregarClick(object sender, EventArgs e)
		{
			idOpApoya = new Conexion_Servidor.Desapacho.SQL_Operaciones().getIdOpRec(txtOperador.Text);
			
			if(idOpApoya!=0)
			{
				dgAsignados.Rows.Add(idOpApoya, txtOperador.Text);
			}
			else if(idOpApoya==0)
			{
				MessageBox.Show("Operador no encontrado.");
			}
			txtOperador.Text="";
			dgAsignados.ClearSelection();
			columnSelect=0;
		}
		#endregion
		
		#region ELIMINAR OPERADOR
		void CmdEliminarClick(object sender, EventArgs e)
		{
			if(columnSelect!=0)
			{
				dgAsignados.Rows.RemoveAt(columnSelect);
			}
			columnSelect=0;
		}
		#endregion
		#endregion
		
		void DgAsignadosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				columnSelect = e.RowIndex;
				cmdEliminar.Enabled=true;
			}
		}
	}
}
