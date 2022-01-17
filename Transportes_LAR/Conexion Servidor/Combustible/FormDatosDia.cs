using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormDatosDia : Form
	{
		public FormDatosDia(String fecha)
		{
			InitializeComponent();
			pruebaAgrego();
			FECHA=fecha;
		}
		
		#region VARIABLES
		String FECHA;
		#endregion
		
		#region evento load
		void FormDatosDiaLoad(object sender, EventArgs e)
		{
			txtFecha.Text=FECHA;
		}
		#endregion
		
		
		public void pruebaAgrego()
		{
			//dgViajes.Rows.Add("a","a","a","a","a", false);
		}
		
		void DgViajesCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			//dgViajes.Columns[5].
			//dgViajes[5,e.RowIndex].
			/*if(dgViajes.)
			{
				MessageBox.Show("Evento");
			}*/
			/*if(Convert.ToInt32(dgViajes.Rows[e.RowIndex].Cells[5].Value) == 1)
			{
				MessageBox.Show("Prueba");
			}*/
		}
		
		void DgViajesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*if(dgViajes[5,e.RowIndex].Value.ToString()=="False")
			{
				dgViajes[5,e.RowIndex].Value=true;
				MessageBox.Show("Prueba 1 -");
			}
			else
			{
				dgViajes[5,e.RowIndex].Value=false;
				MessageBox.Show("Prueba 0 -");
			}*/
		}
		
		void DgViajesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
