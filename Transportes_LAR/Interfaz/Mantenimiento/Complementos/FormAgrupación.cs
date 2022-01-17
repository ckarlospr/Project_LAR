using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormAgrupación : Form
	{
		#region VARIABLES
		
		#endregion
				
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento sqlmant = new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		#endregion
		
		#region CONSTRUCTORES
		public FormAgrupación()
		{
			InitializeComponent();
			Adaptador();
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador()
		{		
			ColoresAlternadosRows(dataAgrupación);
			int contador = 0;
			dataAgrupación.Rows.Clear();
			dataAgrupación.ClearSelection();
			conn.getAbrirConexion("SELECT ID, NOMBRE, DESCRIPCION, ESTATUS FROM GRUPO_PRODUCTO ORDER BY ESTATUS, ID");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataAgrupación.Rows.Add();
				dataAgrupación.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataAgrupación.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
				dataAgrupación.Rows[contador].Cells[2].Value = conn.leer["DESCRIPCION"].ToString();
				dataAgrupación.Rows[contador].Cells[3].Value = conn.leer["ESTATUS"].ToString();
				contador++;
				foreach (DataGridViewRow row in dataAgrupación.Rows)
				{
					if (Convert.ToString(row.Cells[3].Value) == "Inactivo")
		     		{
		         		row.DefaultCellStyle.BackColor = Color.Gray; 
			     	}
				}
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region BOTONES
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(txtNombre.Text!="")
			{
				if(sqlmant.ValidarExisteAgrupacion(txtNombre.Text) != false)
				{
				   	sqlmant.InsertarAgrupacion(txtNombre.Text, txtDescripcion.Text);
					Adaptador();
					LimpiarCampos();
				}else{
					MessageBox.Show("El grupo ya existe", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					LimpiarCampos();
				}				
			}
		}
		#endregion
		
		#region EVENTO CELLPAINTING - CLICK
		void DataAgrupaciónCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if(e.ColumnIndex == 4 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataAgrupación.Rows[e.RowIndex].Cells[4] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+2);
      		    e.Handled = true;
			}
			if(e.ColumnIndex == 5 && e.RowIndex >= 0)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataAgrupación.Rows[e.RowIndex].Cells[5] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\v.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+2);
      		    e.Handled = true;
			}
		}
		
		void DataAgrupaciónCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 4 && e.RowIndex >= 0)
  			{
				sqlmant.AgrupacionActivDesact(dataAgrupación.Rows[e.RowIndex].Cells[0].Value.ToString(), "Inactivo");
				Adaptador();
			}
			
			if(e.ColumnIndex == 5 && e.RowIndex >= 0)
			{
				sqlmant.AgrupacionActivDesact(dataAgrupación.Rows[e.RowIndex].Cells[0].Value.ToString(), "Activo");
				Adaptador();
			}
		}
		#endregion
		
		#region EVENTOS TECLAS
		void TxtNombreKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if(txtNombre.Text != "")
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
					if(sqlmant.ValidarExisteAgrupacion(txtNombre.Text) != false)
					{
			   			sqlmant.InsertarAgrupacion(txtNombre.Text, txtDescripcion.Text);
						Adaptador();
						LimpiarCampos();
					}else
					{
						MessageBox.Show("Ya existe un grupo registrado con el sistema con el mismo nombre", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						LimpiarCampos();
					}
				}
				else
				{
					txtNombre.Focus();
				}
			}
		}
		
		void DataAgrupaciónKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int indice = dataAgrupación.CurrentCell.RowIndex;
				String nom = dataAgrupación.Rows[indice].Cells[1].Value.ToString();
				String desc = dataAgrupación.Rows[indice].Cells[2].Value.ToString();
				int id = Convert.ToInt32(dataAgrupación.Rows[indice].Cells[0].Value);
				
				sqlmant.ActualizarAgrupacion(nom, desc, id);
				Adaptador();
				LimpiarCampos();
			}			
		}
		#endregion
		
		#region METODOS
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		private void LimpiarCampos()
		{
			txtNombre.Text = "";
			txtDescripcion.Text = "";
			txtNombre.Focus();
		}
		#endregion
	}
}
