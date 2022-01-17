using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormEntrada : Form
	{
		// ==========
		   #region PENDIENTES
		// * Cantidad.enabled a true
		// * Validacion de agregar va en insercion
		// * Popular Matriz
		// * Imprimir Codigos barras
		// * campo folio readolny=true al insertar en codigoarticulo (btnNuevo readonly=false) 
		#endregion
		// ==========
		
		#region VARIABLES
		String ID_USUARIO;
		int contador;
		int contadorNE = 0;
		int noFilas;
		Boolean validaIns;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento sqlmant = new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		#endregion
		
		#region CONSTRUCTORES
		public FormEntrada(String id_u)
		{
			InitializeComponent();
			this.ID_USUARIO=id_u;
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador(string folio)
		{		
			cmdValidar.Enabled=true;
			cmdAgregar.Enabled=false;
			dataEntrada.Rows.Clear();
			dataEntrada.ClearSelection();
			String consulta = 	"select P.ID, P.PIEZA, p.MARCA, P.MODELO, L.CANTIDAD, P.CODIGO_BARRAS, O.ID_PROVEE, O.FechaCreacion, L.flujo "+
								"from dbo.ORDEN_COMPRA O with(nolock)" +
								"	inner join dbo.LISTA_ORDENCOMPRA L with(nolock) on O.ID=L.ID_ORDENC"+
								"	inner join dbo.PRODUCTO_ALMACEN P with(nolock) on L.ID_PROD=P.ID "+
								"where O.FOLIO='"+folio+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataEntrada.Rows.Add(conn.leer["ID"].ToString(), 
				                     "",
				                   	conn.leer["PIEZA"].ToString(), 
				                   	conn.leer["MARCA"].ToString(),
				                  	conn.leer["MODELO"].ToString(),
				                	conn.leer["CANTIDAD"].ToString(),
				                	conn.leer["CODIGO_BARRAS"].ToString(),
				                	conn.leer["ID_PROVEE"].ToString(),
				                	"",
				               		conn.leer["FechaCreacion"].ToString(),
				              		conn.leer["flujo"].ToString());
			}
			conn.conexion.Close();
			CuentaRegistros();
			dataEntrada.ClearSelection();
			
			if(dataEntrada.RowCount>0){
				for(int i=0; i<dataEntrada.Rows.Count; i++){
					if(dataEntrada[10,i].Value.ToString()=="2"){
						for(int y=0; y<10; y++){
							dataEntrada[y,i].Style.BackColor=Color.MediumSpringGreen;
						}
					}else{
						cmdValidar.Enabled=false;
					}
				}
			}
		}
		
		void getDataFolio(String folio){
			//dgOCompra
			
			dgOCompra.Rows.Clear();
			dgOCompra.ClearSelection();
			String consulta = "select ID, FOLIO, FECHA from dbo.ORDEN_COMPRA with(nolock) where FOLIO like '%"+folio+"%' and FLUJO="+((cbValidados.Checked==true)?2:1);
			
//			if(cbValidados.Checked==true)
//				consulta = "select ID, FOLIO, FECHA from dbo.ORDEN_COMPRA with(nolock) where FOLIO like '%"+folio+"%' and ";
//			else 
//				consulta = "select ID, FOLIO, FECHA from dbo.ORDEN_COMPRA with(nolock) where FOLIO like '%"+folio+"%'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgOCompra.Rows.Add(conn.leer["ID"].ToString(), conn.leer["FOLIO"].ToString(), conn.leer["FECHA"].ToString());
			}
			dgOCompra.ClearSelection();
			conn.conexion.Close();
		}
		#endregion
		
		#region BOTONES
		void BtnNuevoClick(object sender, EventArgs e)
		{
			dataEntrada.Rows.Clear();
			dataEntrada.ClearSelection();
			CamposEnabled(true);
			txtFolioOrdenC.Text = "";
			//txtFolioOrdenC.ReadOnly = false;
//			txtCodigoArt.Text = "";
//			txtFecha.Text = "";
//			rbComprado.Checked = true;
//			cmbBuscarPor.Text = null;
//			txtBuscarComo.Text = "";
//			chbAgrupar.Checked = false;
			btnAgregar.Enabled = true;
//			txtFecha.Text = Fecha();
			dataEntrada.Columns[5].ReadOnly = false;
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{	
			String cant;
			String orig;
			
			//sqlmant.InsertarEntrada(txtFecha.Text, Convert.ToInt32(sqlmant.IdOrdenC(txtFolioOrdenC.Text)));
			//orig = (rbComprado.Checked == true) ? "Comprado" : "Garantia";
			
			for(int x = 0; x == noFilas; x++)
			{
				cant = dataEntrada.Rows[x].Cells[5].Value.ToString();
				//sqlmant.InsertarDetalleEntrada(Convert.ToInt32(sqlmant.IDEntradaTop()), cant, orig);
			}
			
			sqlmant.InsertarHistorialEntrada(Convert.ToInt32(sqlmant.IDEntradaTop()), Fecha(), ID_USUARIO);
			
			for(int i = 0; i < noFilas; i++)
			{
				String idProd = sqlmant.RetornaIdProducto("CODIGO_BARRAS", dataEntrada.Rows[i].Cells[6].Value.ToString());
				String cantidad = dataEntrada.Rows[i].Cells[5].Value.ToString();
				sqlmant.ActualizaExistencias(cantidad, Convert.ToInt32(idProd));
			}
			
			btnAgregar.Enabled = false;
		}
		
		void BtnVistaClick(object sender, EventArgs e)
		{
			CamposEnabled(false);
			txtFolioOrdenC.Text = "";
//			txtCodigoArt.Text = "";
//			txtFecha.Text = "";
//			rbComprado.Checked = true;
//			cmbBuscarPor.Text = null;
//			txtBuscarComo.Text = "";
//			chbAgrupar.Checked = false;
			//Adaptador();
			btnAgregar.Enabled = false;
			dataEntrada.Columns[5].ReadOnly = true;
		}
		#endregion
		
		#region INICIO
		void FormEntradaLoad(object sender, EventArgs e)
		{
			CamposEnabled(false);
			this.Validar(this);
			ColoresAlternadosRows(dataEntrada);
			btnAgregar.Enabled = false;			
			//Adaptador();
			getDataFolio("");
			
//			txtFolioOrdenC.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT * FROM ORDEN_COMPRA oc", "FOLIO");
//	        txtFolioOrdenC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
//	        txtFolioOrdenC.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region METODOS
			
			#region COLORES ALTERNADOS DATAGRIDVIEW
			public void ColoresAlternadosRows(DataGridView datag)
			{
				datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
				datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
			}
			#endregion
			
			#region SUGGEST CODIGO SEGUN ORDENCOMPRA
			private void ProductosOrdenCompra(String idOrdenC)
			{
//				txtCodigoArt.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT pa.CODIGO_BARRAS FROM PRODUCTO_ALMACEN pa, ORDEN_COMPRA oc, LISTA_ORDENCOMPRA lo WHERE pa.ID = lo.ID_PROD AND lo.ID_ORDENC = oc.ID AND oc.ID = "+idOrdenC, "CODIGO_BARRAS");
//	           	txtCodigoArt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
//	            txtCodigoArt.AutoCompleteSource = AutoCompleteSource.CustomSource;
			}
			#endregion
		
			#region OBTIENE Y DA FORMATO A FECHA
			private String Fecha()
			{
				DateTime dateToday = DateTime.Today;
				String fechaActual = dateToday.ToString("MM/dd/yy");
				return fechaActual;
			}
			#endregion
			
			#region CUENTA ENTRADAS DEL DATAGRIDVIEW
			private void CuentaRegistros()
			{
				noFilas = dataEntrada.Rows.Count;
					
				if(dataEntrada.FirstDisplayedScrollingColumnIndex < 0)
				{
					noFilas = 0;
				}
				
//				lbEntradas.Text = Convert.ToString(noFilas);
			}
			#endregion
			
			#region ACTIVA/DESACTIVA ENABLED DE CAMPOS
			private void CamposEnabled(Boolean accion)
			{
				//txtFolioOrdenC.Enabled = accion;
//				txtCodigoArt.Enabled = accion;
//				txtFecha.Enabled = accion;
//				rbComprado.Enabled = accion;
//				rbGarantia.Enabled = accion;
			}
			#endregion
			
		#endregion
		
		#region VALIDACIONES
		void Validar(Interfaz.Mantenimiento.Complementos.FormEntrada entrada)
		{
			entrada.txtFolioOrdenC.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
//			entrada.txtCodigoArt.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void DataEntradaEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			int column = dataEntrada.CurrentCell.ColumnIndex;
			
			if(column == 4)
			{
				TextBox tbCantidad = e.Control as TextBox;
				tbCantidad.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			}
		}
		
		private bool ValidarInsercion()
		{
			if(txtFolioOrdenC.Text != "")
			{
				if(sqlmant.ValidaOrdenCompra("FOLIO", txtFolioOrdenC.Text, "") == false)
				{
//					if(txtCodigoArt.Text != "")
//					{
//						if(sqlmant.RetornaIdProducto("CODIGO_BARRAS", txtCodigoArt.Text) != "")
//						{
//							if(txtFecha.Text != "")
//							{
//								validaIns = true;
//							}
//							else
//							{
//								MessageBox.Show("El campo de 'Fecha' no puede quedar vacio","Error al registrar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//								txtFecha.Focus();
//								validaIns = false;
//							}
//						}
//						else
//						{
//							MessageBox.Show("El codigo de articulo especificado no existe","Error al registrar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//							txtCodigoArt.Focus();
//							validaIns = false;
//						}
//					}
//					else
//					{
//						MessageBox.Show("El campo de 'Codigo articulo' no puede quedar vacio","Error al registrar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//						txtCodigoArt.Focus();
//						validaIns = false;
//					}
				}
				else
				{
					MessageBox.Show("El numero de Folio especificado no existe","Error al registrar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtFolioOrdenC.Focus();
					validaIns = false;
				}
			}
			else
			{
				MessageBox.Show("El campo de 'Folio orden' no puede quedar vacio","Error al registrar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFolioOrdenC.Focus();
				validaIns = false;
			}
			return validaIns;
		}
		#endregion
		
		#region EVENTOS
		/*
		void TxtCodigoArtTextChanged(object sender, EventArgs e)
		{
			String cod = txtCodigoArt.Text;
			if(cod.Length == 13)
			{
				String idP = sqlmant.RetornaIdProducto("CODIGO_BARRAS", txtCodigoArt.Text);
				if(sqlmant.ArticuloDeOrdenC(sqlmant.IdOrdenC(txtFolioOrdenC.Text), idP) ==  true)
				{
					String ori = (rbComprado.Checked == true) ? "Comprado" : "Garantia";
					
					dataEntrada.ClearSelection();
					conn.getAbrirConexion("SELECT pa.PIEZA, pa.MARCA, pa.MODELO, oc.ID_PROVEE " +
										  "FROM ORDEN_COMPRA oc, LISTA_ORDENCOMPRA lo, PRODUCTO_ALMACEN pa " +
										  "WHERE lo.ID_ORDENC = oc.ID AND lo.ID_PROD = pa.ID AND pa.ID = '"+idP+"';");
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dataEntrada.Rows.Add();
						dataEntrada.Rows[contadorNE].Cells[1].Value = Convert.ToString(contador+1);
						dataEntrada.Rows[contadorNE].Cells[2].Value = conn.leer["PIEZA"].ToString();
						dataEntrada.Rows[contadorNE].Cells[3].Value = conn.leer["MARCA"].ToString();
						dataEntrada.Rows[contadorNE].Cells[4].Value = conn.leer["MODELO"].ToString();
						dataEntrada.Rows[contadorNE].Cells[5].Value = "1";
						dataEntrada.Rows[contadorNE].Cells[6].Value = txtCodigoArt.Text;
						dataEntrada.Rows[contadorNE].Cells[7].Value = sqlmant.DatosProveedor("NOMBRE", conn.leer["ID_PROVEE"].ToString());
						dataEntrada.Rows[contadorNE].Cells[8].Value = ori;
						dataEntrada.Rows[contadorNE].Cells[9].Value = txtFecha.Text;
						contador++;
					}
					conn.conexion.Close();
					txtCodigoArt.Text = "";
					txtCodigoArt.Focus();
					CuentaRegistros();
				}
				else
				{
					MessageBox.Show("El folio ingresado no corresponde a la orden de compra señalada","Error al insertar la fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				txtFolioOrdenC.ReadOnly = true;
			}
		}
		264
		*/
		void TxtCodigoArtKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
//				String cod = txtCodigoArt.Text;
//				if(cod.Length == 13)
//				{
//					String idP = sqlmant.RetornaIdProducto("CODIGO_BARRAS", txtCodigoArt.Text);
//					String ori = (rbComprado.Checked == true) ? "Comprado" : "Garantia";
//					
//					dataEntrada.ClearSelection();
//					String sentence = "SELECT pa.PIEZA, pa.MARCA, pa.MODELO, oc.ID_PROVEE " +
//										  "FROM ORDEN_COMPRA oc, LISTA_ORDENCOMPRA lo, PRODUCTO_ALMACEN pa " +
//										  "WHERE lo.ID_ORDENC = oc.ID AND lo.ID_PROD = pa.ID AND pa.ID = '"+idP+"';";
//					conn.getAbrirConexion(sentence);
//					conn.leer=conn.comando.ExecuteReader();
//					while(conn.leer.Read())
//					{
//						dataEntrada.Rows.Add();
//						dataEntrada.Rows[contadorNE].Cells[1].Value = Convert.ToString(contador+1);
//						dataEntrada.Rows[contadorNE].Cells[2].Value = conn.leer["PIEZA"].ToString();
//						dataEntrada.Rows[contadorNE].Cells[3].Value = conn.leer["MARCA"].ToString();
//						dataEntrada.Rows[contadorNE].Cells[4].Value = conn.leer["MODELO"].ToString();
//						dataEntrada.Rows[contadorNE].Cells[5].Value = "1";
//						dataEntrada.Rows[contadorNE].Cells[6].Value = txtCodigoArt.Text;
//						dataEntrada.Rows[contadorNE].Cells[7].Value = sqlmant.DatosProveedor("NOMBRE", conn.leer["ID_PROVEE"].ToString());
//						dataEntrada.Rows[contadorNE].Cells[8].Value = ori;
//						dataEntrada.Rows[contadorNE].Cells[9].Value = txtFecha.Text;
//						contador++;
//					}
//					conn.conexion.Close();
//					txtCodigoArt.Text = "";
//					txtCodigoArt.Focus();
//					CuentaRegistros();
//				}
			}
		}
		
		void TxtFolioOrdenCLeave(object sender, EventArgs e)
		{
//			if(txtFolioOrdenC.Text != "")
//			{
//				ProductosOrdenCompra(sqlmant.IdOrdenC(txtFolioOrdenC.Text));
//			}
			
			
		}
		#endregion
		/*
		#region Codigo
		public Window1()
		
		{
		
		    InitializeComponent();
		
		 
		
		    // register for both handled and unhandled Executed events
		
		    tb.AddHandler(CommandManager.ExecutedEvent,
		
		        new RoutedEventHandler(CommandExecuted), true);
		
		}
		
		 
		
		private void CommandExecuted(object sender, RoutedEventArgs e)
		
		{
		
		    if ((e as ExecutedRoutedEventArgs).Command
		
		        == ApplicationCommands.Paste)
		
		    {
		
		        // verify that the textbox handled the paste command
		
		        if (e.Handled)
		
		        {
		
		            MessageBox.Show("Paste handled");
		
		        }
		
		    }
		
		}
		#endregion
		*/
		
		void TxtCodigoArtKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
				{ 
				MessageBox.Show("El folio ingresado no corresponde a la orden de compra señalada","Error al insertar la fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
				} 
		}
		
		void DgOCompraCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1){
				//MessageBox.Show(dgOCompra[e.ColumnIndex, e.RowIndex].Value.ToString());
				Adaptador(dgOCompra[1, e.RowIndex].Value.ToString());
			}
		}
		
		void TxtBuscarComoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtFolioOrdenCKeyUp(object sender, KeyEventArgs e)
		{
			getDataFolio(txtFolioOrdenC.Text);
			dataEntrada.Rows.Clear();
		}
		
		void CbValidadosCheckedChanged(object sender, EventArgs e)
		{
			getDataFolio(txtFolioOrdenC.Text);
			dataEntrada.Rows.Clear();
		}
		
		void DataEntradaCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dataEntrada[10,e.RowIndex].Value.ToString()=="1"){
				cmdAgregar.Enabled=true;
			}else{
				cmdAgregar.Enabled=false;
			}
		}
		
		void CmdAgregarClick(object sender, EventArgs e)
		{
			AgregarEntrada(dataEntrada[0, dataEntrada.CurrentRow.Index].Value.ToString());
		}
		
		void AgregarEntrada(String ID_Producto){
			//sqlmant.
			
		}
	}
}
