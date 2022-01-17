using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operaciones.Despacho
{
	public partial class FormPrincOperadores : Form
	{
		public FormPrincOperadores(FormPrin_Empresas refPrincEmpresas)
		{
			InitializeComponent();
		}
		
		#region VARIABLES
		public List<Dato.Operador> listOperadores;
		public List<Dato.Unidades> listUnidades;
		public List<Despacho.Conteo> conteOperador = new List<Despacho.Conteo>();
		#endregion
		
		#region INSTANCIAS
		FormPrin_Empresas refPrincEmp;
		#endregion
		
		#region
		void FormPrincOperadoresLoad(object sender, EventArgs e)
		{
			getDatos();
			
			
		}
		#endregion
		
		#region GETDATOS
		public void getDatos()
		{
			dgOperadores.Rows.Clear();
			bool NA = false;
			
			listOperadores = new Conexion_Servidor.Operador.SQL_Operador().getOperadores();
			listUnidades = new Conexion_Servidor.Operador.SQL_Operador().getUnidades();
			
			if(listOperadores!=null)
			{
				for(int x=0; x<listOperadores.Count; x++)
				{
					Despacho.Conteo datConteo = new Conteo(Convert.ToInt64(listOperadores[x].id));
					dgOperadores.Rows.Add("", listOperadores[x].id, listOperadores[x].alias);
					conteOperador.Add(datConteo);
				}
			}
			
			for(int x=0; x<dgOperadores.Rows.Count; x++)
			{
				for(int y=0; y<listUnidades.Count; y++)
				{
					if(dgOperadores[1,x].Value.ToString()==listUnidades[y].ID_OP)
					{
						dgOperadores[0,x].Value=((listUnidades[y].TIPO=="Camión")?"CAM":"CTA");
						NA=true;
						
						dgOperadores[3,x].Value=listUnidades[y].ID_U;
						dgOperadores[4,x].Value=listUnidades[y].NUMERO;
					}
				}
				
				if(NA==false)
				{
					dgOperadores[0,x].Value="N/A";
					dgOperadores[0,x].Style.BackColor=Color.Red;
				}
				NA=false;
			}
			
			dgOperadores.Sort(dgOperadores.Columns[2], ListSortDirection.Ascending);
		}
		#endregion
	}
}
