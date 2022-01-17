using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
 
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormPuesto : Form
	{
		int x = 0;
		System.IO.MemoryStream ms = null;
		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		public List<Interfaz.Nomina.Dato.Nomina> listNomina = null;
		
		#region CONTRUCTORES	
		public FormPuesto(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		void FormPuestoLoad(object sender, EventArgs e)
		{
			AdaptadorOperador();
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		void AdaptadorOperador()
		{
			dtOperador.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select ID, alias as Alias_Op, foraneo from OPERADOR where Estatus='1' and Alias!='Admvo' and Alias!='ADMINOO' order by alias");
		}
		
		void DtOperadorCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			int x = 0;
			
			if(e.RowIndex>-1)
			{
				x = dtOperador.CurrentRow.Index;
				this.x = x;
				txtAlias.Text = dtOperador.Rows[e.RowIndex].Cells[1].Value.ToString();
				DatosOperadorPDF(x);
			}
		}
		
		public void DatosOperadorPDF(int x)
		{	
			ptbImagen.Image = System.Drawing.Image.FromFile(@"../debug/Nomina.jpg");
			try
			{
			conn.getAbrirConexion("select tipo_empleado, Imagen from operador where ID="+dtOperador.Rows[x].Cells[0].Value);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read())
				{
					cmbPuesto.Text = conn.leer["tipo_empleado"].ToString();
					byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
		  			ms = new System.IO.MemoryStream(imageBuffer);
		  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			catch{}
			conn.conexion.Close();
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			string sentencia = "";
			sentencia = "UPDATE OPERADOR SET tipo_empleado='"+cmbPuesto.Text+"' where ID="+dtOperador.Rows[x].Cells[0].Value;
			conn.getAbrirConexion(sentencia);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
		}
		
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      {
				    for(int x=0; x<dtOperador.Rows.Count; x++)
					{
				    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==txtAlias.Text)
				    	{
							if(x>0)
								dtOperador.Rows[x-1].Selected = false;

							dtOperador.ClearSelection();
							dtOperador.Rows[x].Selected = true;
							this.x = x;
							DatosOperadorPDF(x);
				    	}
				    }				
				}
		}
		
		void TxtAliasEnter(object sender, EventArgs e)
		{
			txtAlias.Text = "";
		}
		
		void FormPuestoFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.puesto = false;
		}
	}
}
