using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormRegistrosComp : Form
	{
		#region CONSTRUCTOR
		public FormRegistrosComp(Interfaz.Mantenimiento.Complementos.FormOrdenCompra form)
		{
			InitializeComponent();
			formOrdenCompra = form;
		}
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento sqlmant =  new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		private FormOrdenCompra formOrdenCompra =  null;
		#endregion
		
		#region INICIO
		void FormRegistrosCompLoad(object sender, EventArgs e)
		{
			ColoresAlternadosRows(dataRegistrosComp);
			CargaRegistros();
		}
		#endregion
		
		#region ADAPTADOR
		private void CargaRegistros()
		{
			int contador = 0;
			dataRegistrosComp.Rows.Clear();
			dataRegistrosComp.ClearSelection();
			conn.getAbrirConexion("SELECT oc.ID, oc.FOLIO, oc.FECHA, oc.FACTURA, COUNT(lo.ID) AS CONCEPTOS, oc.TOTAL FROM ORDEN_COMPRA oc, LISTA_ORDENCOMPRA lo WHERE lo.ID_ORDENC = oc.ID GROUP BY oc.ID, oc.FOLIO, oc.FECHA, oc.FACTURA, oc.TOTAL");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataRegistrosComp.Rows.Add();
				dataRegistrosComp.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataRegistrosComp.Rows[contador].Cells[1].Value = conn.leer["FOLIO"].ToString();
				dataRegistrosComp.Rows[contador].Cells[2].Value = conn.leer["FECHA"].ToString();
				dataRegistrosComp.Rows[contador].Cells[3].Value = conn.leer["FACTURA"].ToString();
				dataRegistrosComp.Rows[contador].Cells[4].Value = conn.leer["CONCEPTOS"].ToString();
				dataRegistrosComp.Rows[contador].Cells[5].Value = conn.leer["TOTAL"].ToString();
				contador++;
			}
			conn.conexion.Close();
			
			Enabled_btnDesplegar();
		}
		#endregion
		
		#region BOTONES
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnDesplegarClick(object sender, EventArgs e)
		{
			int indice = dataRegistrosComp.CurrentRow.Index;
			if(indice >= 0)
			{
				String idCompra = dataRegistrosComp.Rows[indice].Cells[0].Value.ToString();
				formOrdenCompra.idOrdCmpQuery = idCompra;
				formOrdenCompra.ConsultaExterna();
			}
		}
		#endregion
		
		#region METODOS
		private void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
			
		}
		
		private void Enabled_btnDesplegar()
		{
			Boolean boo = (sqlmant.ConteoOrdenes().Equals("0")) ? false : true;
			btnDesplegar.Enabled = boo;
		}
		#endregion
	}
}
