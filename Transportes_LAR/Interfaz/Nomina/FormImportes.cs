using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina
{
	public partial class FormImportes : Form
	{
		#region VARIABLES
		String ID_IMPORTE = "";
		bool seleccionador=false;
		String [] ArrayImporte = new String[1000];
		#endregion
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region CONTRUCTORES
		public FormImportes(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormImportesLoad(object sender, EventArgs e)
		{
			CostoDiferentes();
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			AdaptadorOperador();
			TraerDatos();
			InsertarEstado();
		}
		
		void FormImportesFormClosing(object sender, FormClosingEventArgs e)
		{
			String sentencia2 = "update ESTADO_IMPORTE set ESTATUS='0' where ID_VALOR_IMPORTE='19' and ID_OPERADOR in "+
								  "(select O.ID " +
			                      "from OPERADOR O, OperadorContrato OC " +
			                      "where O.ID=OC.IdOperador and O.Estatus='1' and tipo_empleado='OPERADOR' " +
			                      "and O.Alias!='Admvo' and O.Alias!='ADMINOO' " +
			                      "group by O.ID " +
				"HAVING DATEDIFF(day, min(OC.FechaInicioContrato), '"+DateTime.Now.ToShortDateString()+"') < 104) ";
						
			conn.getAbrirConexion(sentencia2);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			//principal.importesNom = false;
		}
		#endregion
		
		#region TRAER VALORES
		void CostoDiferentes()
		{
			int contador = 0;
			dataValorImporte.Rows.Clear();
			dataValorImporte.ClearSelection();
			conn.getAbrirConexion("select ID, NOMBRE, SALDO, TIPO " +
			                      "from VALOR_IMPORTE");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
					dataValorImporte.Rows.Add();
					dataValorImporte.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
					dataValorImporte.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
					dataValorImporte.Rows[contador].Cells[2].Value = conn.leer["SALDO"].ToString();
					dataValorImporte.Rows[contador].Cells[3].Value = conn.leer["TIPO"].ToString();
					++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region BOTONES
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(btnGuardar.Text=="Agregar")
			{
				if(txtNombre.Text!=""&&txtImporte.Text!=""&&cmbTipo.Text!="")
				{
					new Conexion_Servidor.Nomina.SQL_Nomina().InsertarImporte(txtNombre.Text, txtImporte.Text, cmbTipo.Text);
					CostoDiferentes();
					AdaptadorOperador();
				}
				else
					MessageBox.Show("Faltan Campos por llenar!!", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if(txtNombre.Text!=""&&txtImporte.Text!=""&&cmbTipo.Text!="")
				{
					new Conexion_Servidor.Nomina.SQL_Nomina().getActualizarImporte(ID_IMPORTE, txtNombre.Text, txtImporte.Text, cmbTipo.Text);
					CostoDiferentes();
					AdaptadorOperador();
				}
				else
					MessageBox.Show("Faltan Campos por llenar!!", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void BtnNuevoClick(object sender, EventArgs e)
		{
			ID_IMPORTE = "";
			txtImporte.Text = "";
			txtNombre.Text = "";
			cmbTipo.Text = "";
			btnGuardar.Text = "Agregar";
			dataValorImporte.ClearSelection();
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			ModificarEstado();
		}
		#endregion
		
		#region VALIDAR
		void Validar(Interfaz.Nomina.FormImportes formimportes)
		{
			formimportes.txtImporte.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formimportes.txtNombre.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			formimportes.cmbTipo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
		}
		
		void TxtImporteTextChanged(object sender, EventArgs e)
		{
			if(txtImporte.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		#endregion
		
		#region ADAPTADOR OPERADOR
		void AdaptadorOperador()
		{
			int contador = 0;
			int contarray = 0;
			dataImpuestos.Rows.Clear();
			dataImpuestos.ClearSelection();
			String sentencia = "select ID, alias " +
								"from OPERADOR " +
								"where Estatus='1' AND tipo_empleado='OPERADOR' and Alias!='Admvo' and Alias!='ADMINOO' " +
								"order by alias";
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataImpuestos.Rows.Add();
				dataImpuestos.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataImpuestos.Rows[contador].Cells[1].Value = conn.leer["alias"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			String sentencia2 = "select nombre " +
								"from VALOR_IMPORTE " +
								"where Tipo='Variable' or Tipo='Extra' ";
			conn.getAbrirConexion(sentencia2);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				DataGridViewCheckBoxColumn txt =new DataGridViewCheckBoxColumn();
				txt.Name = conn.leer["nombre"].ToString();
			    txt.HeaderText = conn.leer["nombre"].ToString();
			    txt.TrueValue=1;
			    txt.FalseValue=0;
				ArrayImporte[contarray] = conn.leer["nombre"].ToString();
				dataImpuestos.Columns.Add(txt);
				++contarray;	
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region BUSCADOR OPERADOR
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				for(int x=0; x<dataImpuestos.Rows.Count; x++)
				{
					if(txtAlias.Text==dataImpuestos.Rows[x].Cells[1].Value.ToString())
						{
							dataImpuestos.ClearSelection();
							dataImpuestos.Rows[x].Cells[1].Selected = true;
							dataImpuestos.FirstDisplayedCell = dataImpuestos.Rows[x].Cells[1];
							for(int y=0; y<dataImpuestos.ColumnCount;y++)
								dataImpuestos.Rows[x].Cells[y].Style.BackColor = Color.LightSteelBlue;
						}
				}
			}
		}
		#endregion
		
		#region SELECCIONAR - DESELECCIONAR
		void DataImpuestosColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.ColumnIndex!=0&&e.ColumnIndex!=1)
			{
				if(seleccionador == false)
				{
					for(int a = 0; a<(dataImpuestos.RowCount); a++)
					{
						dataImpuestos.Rows[a].Cells[e.ColumnIndex].Value = true;
						dataImpuestos.Rows[a].Cells[e.ColumnIndex].Value = 1;
					}
					seleccionador = true;
				}
				else
				{
					for(int a = 0; a<(dataImpuestos.RowCount); a++)
					{
						dataImpuestos.Rows[a].Cells[e.ColumnIndex].Value = false;
						dataImpuestos.Rows[a].Cells[e.ColumnIndex].Value = 0;
					}
					seleccionador = false;
				}
			}
		}
		#endregion
		
		#region TRAER DATOS
		public void TraerDatos()
		{
			int contarray = 0;
			String id_valor = "";
			
			for(int b = 2; b<(dataImpuestos.ColumnCount); b++)
			{
				conn.getAbrirConexion("select ID " +
			                      "from VALOR_IMPORTE " +
			                      "where nombre='"+ArrayImporte[contarray].ToString()+"'");
				conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
						id_valor = conn.leer["ID"].ToString();
				conn.conexion.Close();
				
				for(int z = 0; z<(dataImpuestos.RowCount); z++)
				{
					dataImpuestos.Rows[z].Cells[b].Value = new Conexion_Servidor.Nomina.SQL_Nomina().Estado_Importe(dataImpuestos.Rows[z].Cells[0].Value.ToString(), id_valor);
					if(new Conexion_Servidor.Nomina.SQL_Nomina().Estado_Importe(dataImpuestos.Rows[z].Cells[0].Value.ToString(), id_valor)==true)
						dataImpuestos.Rows[z].Cells[b].Value = 1;
					else
						dataImpuestos.Rows[z].Cells[b].Value = 0;
				}
				++contarray;
			}
		}
		
		void DataValorImporteCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1)
			{
				ID_IMPORTE = dataValorImporte.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtNombre.Text = dataValorImporte.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtImporte.Text = dataValorImporte.Rows[e.RowIndex].Cells[2].Value.ToString();
				cmbTipo.Text = dataValorImporte.Rows[e.RowIndex].Cells[3].Value.ToString();
				btnGuardar.Text = "Actualizar";
			}
		}
		#endregion
		
		#region INSERTAR ESTADO
		public void InsertarEstado()
		{
			bool Switch = false;
			string sentencia = "";
			int contarray = 0;
			String id_valor = "";
			
			for(int b = 2; b<(dataImpuestos.ColumnCount); b++)
			{
				conn.getAbrirConexion("select ID " +
			                      "from VALOR_IMPORTE " +
			                      "where nombre='"+ArrayImporte[contarray].ToString()+"'");
				conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
						id_valor = conn.leer["ID"].ToString();
				conn.conexion.Close();
				
				for(int a = 0; a<(dataImpuestos.RowCount); a++)
				{
					conn.getAbrirConexion("select ID from ESTADO_IMPORTE where ID_OPERADOR="+dataImpuestos.Rows[a].Cells[0].Value.ToString()+" AND ID_VALOR_IMPORTE="+id_valor);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
						Switch = true;
					else
						Switch = false;
					conn.conexion.Close();
					
					if(Switch==false)
					{
						sentencia = "insert into ESTADO_IMPORTE values ('"+id_valor+"', '"+dataImpuestos.Rows[a].Cells[0].Value.ToString()+"', '0')";
						conn.getAbrirConexion(sentencia);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
				++contarray;
			}
		}
		#endregion
		
		#region MODIFICAR ESTADO
		public void ModificarEstado()
		{
			string sentencia = "";
			int contarray = 0;
			String id_valor = "";
			
			for(int b = 2; b<(dataImpuestos.ColumnCount); b++)
			{
				conn.getAbrirConexion("select ID " +
			                      "from VALOR_IMPORTE " +
			                      "where nombre='"+ArrayImporte[contarray].ToString()+"'");
				conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
						id_valor = conn.leer["ID"].ToString();
				conn.conexion.Close();
				
				for(int a = 0; a<(dataImpuestos.RowCount); a++)
				{
						sentencia = "update ESTADO_IMPORTE set ESTATUS='"+dataImpuestos.Rows[a].Cells[b].Value.ToString()+"' where ID_VALOR_IMPORTE='"+id_valor+"' and ID_OPERADOR='"+dataImpuestos.Rows[a].Cells[0].Value.ToString()+"' ";
						conn.getAbrirConexion(sentencia);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
				}
				++contarray;
			}
		}
		#endregion
		
	}
}
