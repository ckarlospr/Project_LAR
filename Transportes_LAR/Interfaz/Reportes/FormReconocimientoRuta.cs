using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormReconocimientoRuta : Form
	{
		public FormReconocimientoRuta()
		{
			InitializeComponent();
			
			dgOperador.ClearSelection();
			dgEmpresas.ClearSelection();
			
		}
		
		#region VARIABLES
		private String nomEmpresa="";
		
		private int idOpSelect=-1;
		private String AliasOpSelect="";
		
		private int idRutaSelect=-1;
		private String nomRutaSelect="";
		
		private int id_Guia=-1;
		#endregion
		
		#region INSTANCIAS
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		
		List<Interfaz.Operador.Dato.Reconocimiento> listaDatos = null;
		#endregion
		
		#region EVENTO LOAD DE FORMULARIO
		void FormReconocimientoRutaLoad(object sender, EventArgs e)
		{
			txtOperador.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Alias dato from OPERADOR where Estatus=1");
			txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtEmpresa.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select Empresa dato from Cliente where Empresa!='Especiales' group by Empresa");
			txtEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtRutas.AutoCompleteCustomSource = autocomp.AutoReconocimiento(((nomEmpresa=="")?"select R.Nombre dato from RUTA R, Cliente C where C.ID=R.IdSubEmpresa and R.extra='0' and C.Empresa!='Especiales' group by R.Nombre":"select R.Nombre dato from RUTA R, Cliente C where C.ID=R.IdSubEmpresa and R.extra='0' and C.Empresa='"+nomEmpresa+"' group by R.Nombre"));
			txtRutas.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtRutas.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			tablaOperador();
			tablaEmpresas();
			tablaRutas();
		}
		#endregion
		
		#region EVENTOS DE SELECCION KEYUP
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				tablaOperadorSel(txtOperador.Text);
			}
			else if(e.KeyCode.ToString()=="Back" && txtOperador.Text=="")
			{
				tablaOperador();
			}
		}
		
		void TxtEmpresaKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				tablaEmpresasSel(txtEmpresa.Text);
			}
			else if(e.KeyCode.ToString()=="Back" && txtEmpresa.Text=="")
			{
				tablaEmpresas();
			}
		}
		
		void TxtRutasKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				tablaRutasSel("select ID, Nombre, IdSubEmpresa ID2, Sentido Nombre2 from RUTA where Nombre='"+txtRutas.Text+"'");
			}
			else if(e.KeyCode.ToString()=="Back" && txtRutas.Text=="")
			{
				tablaRutas();
			}
		}
		#endregion
		
		#region LLENADO DE TABLAS POR DEFAULT
		public void tablaOperador()
		{
			listaDatos = new Conexion_Servidor.Ruta.SQL_Ruta().getDatosRec("select  ID, Alias Nombre, Apellido_Mat ID2, Apellido_Pat Nombre2 from OPERADOR where Estatus=1 order by Alias");
			
			if(listaDatos!=null)
			{
				dgOperador.Rows.Clear();
				for(int x=0; x<listaDatos.Count; x++)
				{
					dgOperador.Rows.Add(listaDatos[x].ID1, listaDatos[x].Nombre1);
				}
				dgOperador.ClearSelection();
			}
		}
		
		public void tablaEmpresas()
		{
			listaDatos = new Conexion_Servidor.Ruta.SQL_Ruta().getDatosRecEmp("select Empresa Nombre from Cliente where Empresa!='Especiales' group by Empresa");
			
			if(listaDatos!=null)
			{
				dgEmpresas.Rows.Clear();
				for(int x=0; x<listaDatos.Count; x++)
				{
					dgEmpresas.Rows.Add(" ", listaDatos[x].Nombre1);
				}
				dgEmpresas.ClearSelection();
			}
		}
		
		public void tablaRutas()
		{
			listaDatos = new Conexion_Servidor.Ruta.SQL_Ruta().getDatosRec("select ID, Nombre, IdSubEmpresa ID2, Sentido Nombre2 from RUTA where extra='0' order by Nombre");
			
			int bandera=0;
			
			if(listaDatos!=null)
			{
				dgRutas.Rows.Clear();
				for(int x=0; x<listaDatos.Count; x++)
				{
					for(int y=0; y<dgRutas.Rows.Count; y++)
					{
						if(dgRutas[1,y].Value.ToString().ToLower()==listaDatos[x].Nombre1.ToLower())
						{
							bandera=1;
						}
					}
					if(bandera==0)
					{
						dgRutas.Rows.Add(listaDatos[x].ID1, listaDatos[x].Nombre1);
					}
					bandera=0;
				}
				dgRutas.ClearSelection();
			}
		}
		#endregion
		
		#region LLENADO DE TABLAS "SELECCION"
		public void tablaOperadorSel(String Alias)
		{
			listaDatos = new Conexion_Servidor.Ruta.SQL_Ruta().getDatosRec("select  ID, Alias Nombre, Apellido_Mat ID2, Apellido_Pat Nombre2 from OPERADOR where Estatus=1 and alias='"+Alias+"'");
			
			if(listaDatos!=null)
			{
				dgOperador.Rows.Clear();
				for(int x=0; x<listaDatos.Count; x++)
				{
					dgOperador.Rows.Add(listaDatos[x].ID1, listaDatos[x].Nombre1);
				}
				dgOperador.ClearSelection();
			}
		}
		
		public void tablaEmpresasSel(String empresa)
		{
			listaDatos = new Conexion_Servidor.Ruta.SQL_Ruta().getDatosRecEmp("select Empresa Nombre from Cliente where Empresa='"+empresa+"' group by Empresa");
			
			if(listaDatos!=null)
			{
				dgEmpresas.Rows.Clear();
				for(int x=0; x<listaDatos.Count; x++)
				{
					dgEmpresas.Rows.Add(" ", listaDatos[x].Nombre1);
				}
				dgEmpresas.ClearSelection();
			}
		}
		
		public void tablaRutasSel(String Consulta)
		{
			listaDatos = new Conexion_Servidor.Ruta.SQL_Ruta().getDatosRec(Consulta);
			
			int bandera=0;
			
			if(listaDatos!=null)
			{
				dgRutas.Rows.Clear();
				for(int x=0; x<listaDatos.Count; x++)
				{
					for(int y=0; y<dgRutas.Rows.Count; y++)
					{
						if(dgRutas[1,y].Value.ToString().ToLower()==listaDatos[x].Nombre1.ToLower())
						{
							bandera=1;
						}
					}
					if(bandera==0)
					{
						dgRutas.Rows.Add(listaDatos[x].ID1, listaDatos[x].Nombre1);
					}
					bandera=0;
				}
				dgRutas.ClearSelection();
			}
		}
		#endregion
		
		#region EVENTOS DE SELECCION DE DATAGRIDS
		void DgOperadorCellClick(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show(dgOperador[0,e.RowIndex].Value.ToString()+" - "+dgOperador[1,e.RowIndex].Value.ToString());
			if(e.RowIndex!=-1)
			{
				idOpSelect=Convert.ToInt16(dgOperador[0,e.RowIndex].Value);
				AliasOpSelect=dgOperador[1,e.RowIndex].Value.ToString();
				tablaRutasRec();
			}
		}
		
		void DgOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(dgOperador.CurrentRow.Index!=-1)
			{
				if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter)
				{
					idOpSelect=Convert.ToInt16(dgOperador[0,dgOperador.CurrentRow.Index].Value);
					AliasOpSelect=dgOperador[1,dgOperador.CurrentRow.Index].Value.ToString();
					tablaRutasRec();
				}
			}
		}
		
		void DgEmpresasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				nomEmpresa=dgEmpresas[1,e.RowIndex].Value.ToString();
				tablaRutasSel("select R.ID, R.Nombre, R.IdSubEmpresa ID2, R.Sentido Nombre2 from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and C.Empresa='"+dgEmpresas[1,e.RowIndex].Value.ToString()+"' and extra='0'");
			}
		}
		
		void DgEmpresasKeyUp(object sender, KeyEventArgs e)
		{
			if(dgOperador.CurrentRow.Index!=-1)
			{
				if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter)
				{
					nomEmpresa=dgEmpresas[1,dgOperador.CurrentRow.Index].Value.ToString();
					tablaRutasSel("select R.ID, R.Nombre, R.IdSubEmpresa ID2, R.Sentido Nombre2 from RUTA R, Cliente C where R.IdSubEmpresa=C.ID and C.Empresa='"+dgEmpresas[1,dgOperador.CurrentRow.Index].Value.ToString()+"' and extra='0'");
				}
			}
		}
		
		void DgRutasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				idRutaSelect=Convert.ToInt16(dgRutas[0,e.RowIndex].Value);
				nomRutaSelect=dgRutas[1,e.RowIndex].Value.ToString();
			}
		}
		
		void DgRutasKeyUp(object sender, KeyEventArgs e)
		{
			if(dgOperador.CurrentRow.Index!=-1)
			{
				if( e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Tab || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Next || e.KeyCode == Keys.Enter)
				{
					idRutaSelect=Convert.ToInt16(dgRutas[0,dgRutas.CurrentRow.Index].Value);
					nomRutaSelect=dgRutas[1,dgRutas.CurrentRow.Index].Value.ToString();
				}
			}
		}
		#endregion
		
		#region AGREGA RECONOCIMIENTO
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(idOpSelect!=-1 && idRutaSelect!=-1)
			{
				new Conexion_Servidor.Ruta.SQL_Ruta().guardaReconocimiento(idOpSelect, nomRutaSelect);
				tablaRutasRec();
				
				nomEmpresa="";
		
				idOpSelect=-1;
				AliasOpSelect="";
		
				idRutaSelect=-1;
				nomRutaSelect="";
				
				dgOperador.ClearSelection();
				dgEmpresas.ClearSelection();
				dgRutas.ClearSelection();
			}
			else
			{
				MessageBox.Show("Seleccione una ruta para agregar.");
			}
		}
		#endregion
		
		#region GET TABLA RUTAS RECONOCIDAS
		public void tablaRutasRec()
		{
			dgRutasReconocidas.Rows.Clear();
			if(idOpSelect!=-1)
			{
				listaDatos = new Conexion_Servidor.Ruta.SQL_Ruta().getDatosRutasRec(idOpSelect.ToString());
				
				if(listaDatos!=null)
				{
					dgRutasReconocidas.Rows.Clear();
					for(int x=0; x<listaDatos.Count; x++)
					{
						dgRutasReconocidas.Rows.Add(listaDatos[x].ID1, listaDatos[x].Nombre1);
					}
					dgRutasReconocidas.ClearSelection();
				}
			}
		}
		#endregion
		
		#region ELIMINANDO RUTA-RECONOCIMIENTO
		void DgRutasReconocidasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				id_Guia=e.RowIndex;
			}
		}
		
		void DgRutasReconocidasKeyUp(object sender, KeyEventArgs e)
		{
			if(dgRutasReconocidas.CurrentRow.Index!=-1)
			{
				id_Guia=dgRutasReconocidas.CurrentRow.Index;
			}
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			if(id_Guia!=-1)
			{
				new Conexion_Servidor.Ruta.SQL_Ruta().eliminarRec(Convert.ToInt16(dgRutasReconocidas[0,id_Guia].Value));
				dgRutasReconocidas.Rows.RemoveAt(id_Guia);
				dgRutasReconocidas.ClearSelection();
				id_Guia=-1;
			}
		}
		#endregion
	}
}
