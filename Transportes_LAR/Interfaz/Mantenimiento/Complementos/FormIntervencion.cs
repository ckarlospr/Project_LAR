using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormIntervencion : Form
	{	
		#region VARIABLES
			 int contador = 0;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region CONSTRUCTORES		
		public FormIntervencion()
		{
			InitializeComponent();
			Adaptador();
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador()
		{		
			ColoresAlternadosRows(dataIntervencion);
			int contador = 0;
			dataIntervencion.Rows.Clear();
			dataIntervencion.ClearSelection();
			conn.getAbrirConexion("select ID, NOMBRE, DESCRIPCION from TIPO_INTERVENCION");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataIntervencion.Rows.Add();
				dataIntervencion.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataIntervencion.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
				dataIntervencion.Rows[contador].Cells[2].Value = conn.leer["Descripcion"].ToString();
				++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region BOTONES		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(txtNombre.Text!="")
			{
				if(new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().ValidarExisteIntervencion(txtNombre.Text) == true)
				{
				   	new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().InsertarIntervencion(txtNombre.Text, txtDescripcion.Text);
					Adaptador();
					LimpiarCampos();
				}else{
					MessageBox.Show("El tipo de intervencion ya existe", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					LimpiarCampos();
				}				
			}			
		}
		#endregion
		
		#region EVENTO CELLPAINTING - CLICK
		void DataIntervencionCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 3 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataIntervencion.Rows[e.RowIndex].Cells[3] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+2);
      		    e.Handled = true;
			}	
		}
		
		void DataIntervencionCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 3 && e.RowIndex >= 0)
  			{
				if(new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().ValidarEliminarImtervencion(dataIntervencion.Rows[contador].Cells[0].Value.ToString()) == true)
				{
					new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().EliminarIntervencion(dataIntervencion.Rows[e.RowIndex].Cells[0].Value.ToString());
					Adaptador();
				}
				else
				{
					MessageBox.Show("No se puede eliminar la intervencion porque está una orden de tranajo asociada", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}					
		#endregion
		
		#region EVENTOS TECLAS
		
		void TxtNombreKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		    {
				if(txtNombre.Text!="")
				{
					txtDescripcion.Focus();
				}
				else
				{
					txtNombre.Focus();
				}
			}
		}
		
		void TxtDescripcionKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		    {
				if(txtNombre.Text!="")
				{
					if(new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().ValidarExisteIntervencion(txtNombre.Text) == true)
					{
			   			new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().InsertarIntervencion(txtNombre.Text, txtDescripcion.Text);
						Adaptador();
						txtNombre.Text = "";
						txtDescripcion.Text = "";
						txtNombre.Focus();
					}else
					{
						MessageBox.Show("El Tipo de intervencion ya existe", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txtNombre.Text = "";
						txtDescripcion.Text = "";
						txtNombre.Focus();
					}
				}
				else
				{
					txtNombre.Focus();
				}
			}
		}
		
		void DataIntervencionKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().ActualizarIntervencion( 
				    dataIntervencion.Rows[contador].Cells[1].Value.ToString(), dataIntervencion.Rows[contador].Cells[2].Value.ToString(),  Convert.ToInt32(dataIntervencion.Rows[contador].Cells[0].Value));
				Adaptador();
				txtNombre.Text = "";
			}
		}
			
		
		#endregion
		
		#region EVENTOS CELADAS
		void DataIntervencionCellClick(object sender, DataGridViewCellEventArgs e)
		{
			contador = e.RowIndex;
		}
		#endregion
		
		#region METODOS
		public void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		public void LimpiarCampos(){
			txtNombre.Text = "";
			txtDescripcion.Text = "";
			txtNombre.Focus();
		}
		#endregion			
		
		#region INICIO
		void FormIntervencionLoad(object sender, EventArgs e)
		{
			Adaptador();
		}
		#endregion	
	}
}
