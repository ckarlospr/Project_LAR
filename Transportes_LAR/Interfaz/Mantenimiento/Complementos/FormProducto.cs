using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormProducto : Form
	{
		#region VARIABLES
			int id = 0;
			short Accion = 1;
			String codigoBarras = "";
			String busqueda = "";
			String simbol = "=";
			Boolean switchInsAct;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento sqlmant = new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		#endregion
		
		#region CONSTRUCTORES
		public FormProducto()
		{
			InitializeComponent();
		}
		#endregion
		
		#region INICIO
		void FormProductoLoad(object sender, EventArgs e)
		{
			this.Validar(this);
			SuggestGrupo();
			ColoresAlternadosRows(dataProducto);
			Adaptador(busqueda);
            btnModificar.Enabled = false;
            switchInsAct = true;
            cmbBuscarPor.Text = "Articulo";
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador(String buscar)
		{		
			int contador = 0;
			dataProducto.Rows.Clear();
			dataProducto.ClearSelection();
			conn.getAbrirConexion("SELECT P.*, G.NOMBRE AS GRUPO FROM PRODUCTO_ALMACEN P, GRUPO_PRODUCTO G WHERE G.ID=P.ID_GRUPO " + buscar + " ORDER BY ESTATUS, ID");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataProducto.Rows.Add();
				dataProducto.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataProducto.Rows[contador].Cells[1].Value = conn.leer["Pieza"].ToString();				
				dataProducto.Rows[contador].Cells[2].Value = conn.leer["Marca"].ToString();
				dataProducto.Rows[contador].Cells[3].Value = conn.leer["Modelo"].ToString();
				dataProducto.Rows[contador].Cells[4].Value = conn.leer["Aplicacion"].ToString();
				dataProducto.Rows[contador].Cells[5].Value = conn.leer["Tipovehiculo"].ToString();
				dataProducto.Rows[contador].Cells[6].Value = conn.leer["EXISTENCIA"].ToString();
				dataProducto.Rows[contador].Cells[7].Value = conn.leer["MEDICION"].ToString();
				dataProducto.Rows[contador].Cells[8].Value = conn.leer["ESTATUS"].ToString();
				dataProducto.Rows[contador].Cells[9].Value = conn.leer["Grupo"].ToString();
				dataProducto.Rows[contador].Cells[10].Value = conn.leer["NO_SERIE"].ToString();
				dataProducto.Rows[contador].Cells[11].Value = conn.leer["CODIGO_BARRAS"].ToString();
				contador++;			
				foreach (DataGridViewRow row in dataProducto.Rows)
				{
					if (Convert.ToString(row.Cells[8].Value) == "Desactivado")
		     		{
		         		row.DefaultCellStyle.BackColor = Color.Gray; 
			     	}
				}
			}
			conn.conexion.Close();
			sqlmant.ConteoProdProv("PRODUCTO_ALMACEN", "Activado", lbActivos);
			sqlmant.ConteoProdProv("PRODUCTO_ALMACEN", "Desactivado", lbInactivos);
		}
		#endregion
		
		#region EVENTO CELLPAINTING - DOUBLE CLICK
			
			#region ACTIVAR / DESACTIVAR
			void DataProductoCellContentClick(object sender, DataGridViewCellEventArgs e)
			{
				if (e.ColumnIndex == 12 && e.RowIndex >= 0)
	  			{
					sqlmant.DesactivarProducto(dataProducto.Rows[e.RowIndex].Cells[0].Value.ToString());
					Adaptador(busqueda);
					LimpiarCampos();
				}
				
				if (e.ColumnIndex == 13 && e.RowIndex >= 0)
	  			{
					sqlmant.ActivarProducto(dataProducto.Rows[e.RowIndex].Cells[0].Value.ToString());
					Adaptador(busqueda);
					LimpiarCampos();
				}
			}
			#endregion
			
			#region PINTAR CELDAS
			void DataProductoCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
			{
				if (e.ColumnIndex == 12 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataProducto.Rows[e.RowIndex].Cells[12] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+10, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
				
				if (e.ColumnIndex == 13 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataProducto.Rows[e.RowIndex].Cells[13] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\v.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+10, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
			}
			#endregion
			
			#region REGISTRO A CAMPOS
			void DataProductoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
			{
				if(e.RowIndex >=0 && e.ColumnIndex < 12)
				{
					String code;
					id = Convert.ToInt32(dataProducto.Rows[e.RowIndex].Cells[0].Value);
					txtArticulo.Text = dataProducto.Rows[e.RowIndex].Cells[1].Value.ToString();
					txtMarca.Text = dataProducto.Rows[e.RowIndex].Cells[2].Value.ToString();				
					txtModelo.Text = dataProducto.Rows[e.RowIndex].Cells[3].Value.ToString();
					txtObservaciones.Text = dataProducto.Rows[e.RowIndex].Cells[4].Value.ToString();
					cmbTipoVehiculo.Text = dataProducto.Rows[e.RowIndex].Cells[5].Value.ToString();				
					cmbMetrica.Text = dataProducto.Rows[e.RowIndex].Cells[7].Value.ToString();
					txtGrupo.Text = dataProducto.Rows[e.RowIndex].Cells[9].Value.ToString();
					txtNoSerie.Text = dataProducto.Rows[e.RowIndex].Cells[10].Value.ToString();
					code = dataProducto.Rows[e.RowIndex].Cells[11].Value.ToString();
					lbCod1.Text = code.Substring(0, 3);
					lbCod2.Text = code.Substring(3, 2);
					lbCod3.Text = code.Substring(5, 2);
					lbCod4.Text = code.Substring(7, 2);
					lbCod5.Text = code.Substring(9, 2);
					lbCod6.Text = code.Substring(11);				
					btnModificar.Enabled = true;
					btnAgregar.Enabled = false;
					switchInsAct = false;
					Accion = 2;
				}
			}
			#endregion
			
		#endregion
		
		#region BOTONES
		
			#region VACIAR CAMPOS
			void BtnNuevoClick(object sender, EventArgs e)
			{	
				LimpiarCampos();
				btnModificar.Enabled = false;	
				btnAgregar.Enabled = true;
				txtBuscarComo.Text = "";
				txtArticulo.Focus();
				Accion = 1;
			}
			#endregion
			
			#region	 REGISTRAR PRODUCTO
			void BtnAgregarClick(object sender, EventArgs e)
			{
				if(ValidaInsAct(switchInsAct) != false)
				{
						GenerarCodigoBarras();
						sqlmant.InsertarProducto(txtArticulo.Text, txtMarca.Text, txtModelo.Text, txtObservaciones.Text, cmbTipoVehiculo.Text, 0, cmbMetrica.Text, sqlmant.IDAgrupacion(txtGrupo.Text), txtNoSerie.Text, codigoBarras);
						Adaptador(busqueda);
						LimpiarCampos();	
						btnModificar.Enabled = false;
						switchInsAct = true;
						txtArticulo.Focus();
				}
			}
			#endregion
			
			#region MODIFICAR PRODUCTO
			void BtnModificarClick(object sender, EventArgs e)
			{
				if(ValidaInsAct(switchInsAct) != false)
				{
						GenerarCodigoBarras();
						sqlmant.ActualizarProducto(txtArticulo.Text, txtMarca.Text, txtModelo.Text, txtObservaciones.Text, cmbTipoVehiculo.Text, cmbMetrica.Text, sqlmant.IDAgrupacion(txtGrupo.Text), txtNoSerie.Text, codigoBarras, id);
						Adaptador(busqueda);		
						LimpiarCampos();
						btnModificar.Enabled = false;	
						btnAgregar.Enabled = true;
						switchInsAct = true;
						txtArticulo.Focus();
				}
			}
			#endregion
		
		#endregion
						
		#region VALIDACIONES
		
			#region INSERCION
			private Boolean ValidaInsAct(Boolean accion)
			{
				Boolean validado = false;
				
				if(txtArticulo.Text != "")
				{
					if(txtMarca.Text != "")
					{
						if(txtModelo.Text != "")
						{
							if(cmbTipoVehiculo.Text != null)
							{
								if(txtGrupo.Text != "")
								{
									String consulta = (accion) ? "" : "AND PIEZA !='"+sqlmant.NombreProduc(Convert.ToString(id))+"'";
									if(sqlmant.ValidarExisteProducto(txtArticulo.Text, consulta) == true)
									{
										if(sqlmant.ValidarExisteAgrupacion(txtGrupo.Text) == false)
										{
											validado = true;
										}
										else
										{
											MessageBox.Show("El nombre de grupo proporcionado no coincide con\nninguno registrado en el sistema", "Error de duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
											txtGrupo.Focus();
											validado = false;
										}
									}
									else
									{
										MessageBox.Show("Ya existe un articulo con el mismo nombre\n(puede que este solo este desactivado)\nVerifique los datos a insertar", "Error de duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
										txtArticulo.Focus();
										validado = false;
									}
								}
								else
								{
									MessageBox.Show("Es necesario completar el campo de 'Grupo'", "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									txtGrupo.Focus();
									validado = false;
								}
							}
							else
							{
								MessageBox.Show("Es necesario completar el campo de 'Tipo Vehiculo'", "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								cmbTipoVehiculo.Focus();
								validado = false;
							}
						}
						else
						{
							MessageBox.Show("Es necesario completar el campo de 'Modelo'", "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txtModelo.Focus();
							validado = false;
						}
					}
					else
					{
						MessageBox.Show("Es necesario completar el campo de 'Marca'", "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txtMarca.Focus();
						validado = false;
					}
				}
				else
				{
					MessageBox.Show("Es necesario completar el campo de 'Articulo'", "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtArticulo.Focus();
					validado = false;
				}
				
				return validado;
			}
			#endregion
		
			#region  INPUTS TECLADO
			void Validar(Interfaz.Mantenimiento.Complementos.FormProducto producto)
			{
				producto.txtArticulo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
				producto.txtMarca.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
				producto.txtModelo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
				producto.txtObservaciones.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
				producto.txtNoSerie.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
			}
			#endregion
			
		#endregion
		
		#region METODOS
		
			#region COLORES ALTERNADOS DATAGRIDVIEW
			public void ColoresAlternadosRows(DataGridView datag)
			{
				datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
				datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
			}
			#endregion
			
			#region VACIA LOS CAMPOS
			public void LimpiarCampos()
			{
				txtArticulo.Text = "";
				txtMarca.Text = "";
				txtModelo.Text = "";
				txtObservaciones.Text = "";
				cmbTipoVehiculo.Text = null;
				cmbMetrica.Text = null;			
				txtGrupo.Text = null;
				txtNoSerie.Text = "";
				lbCod1.Text = "000";
				lbCod2.Text = "00";
				lbCod3.Text = "00";
				lbCod4.Text = "00";
				lbCod5.Text = "00";
				lbCod6.Text = "00";
				switchInsAct = true;
			}
			#endregion
			
			#region CONSTRUYE EL CODIGO DE BARRAS
			public void GenerarCodigoBarras()
			{
				codigoBarras = lbCod1.Text + lbCod2.Text + lbCod3.Text + lbCod4.Text + lbCod5.Text + lbCod6.Text;
			}
			#endregion
			
			#region POSICION QUE OCUPA CHAR EN ALFABETO
			public String NoPosicionletraString(String str, int num)
			{
				str = str.ToLower();
				
				char ch = Convert.ToChar("a");
				char chStr = str[num];
				int chMatch = 0;
				String numch;
								
				while(ch <= chStr)
				{
					chMatch++;
					ch++;
				}
				
				return numch = (chMatch < 10) ? "0"+chMatch.ToString() : chMatch.ToString();
			}
			#endregion
			
			#region DA FORMATO AL ID DEL CODIGO DE BARRAS
			public void IDpCodB(Int16 accion)
			{
				if(accion == 1) //Para Insertar
				{
					String IDnuevo = "";
					int idp = Convert.ToInt32(sqlmant.IDCodigo());
					if(idp < 10){IDnuevo = "00" + sqlmant.IDCodigo();}
					if(idp >= 10 && idp <= 99){IDnuevo = "0" + sqlmant.IDCodigo();}
					if(idp >= 100){IDnuevo = sqlmant.IDCodigo();}
						
					lbCod1.Text = IDnuevo;
				}
				
				if(accion == 2) //Para Actualizar
				{
					String IDnuevo = "";
					if(id < 10){IDnuevo = "00" + Convert.ToString(id);}
					if(id >= 10 && id <= 99){IDnuevo = "0" + Convert.ToString(id);}
					if(id >= 100){IDnuevo = Convert.ToString(id);}
						
					lbCod1.Text = IDnuevo;
				}
			}
			#endregion
			
			#region AUTOCOMPLETA GRUPO
			void SuggestGrupo()
			{		
				txtGrupo.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT * FROM GRUPO_PRODUCTO gp", "NOMBRE");
	           	txtGrupo.AutoCompleteMode = AutoCompleteMode.Suggest;
	            txtGrupo.AutoCompleteSource = AutoCompleteSource.CustomSource;
			}
			#endregion
			
		#endregion		
		
		#region EVENTOS
		
			#region EVENTO BUSQUEDA		
			void TxtBusquedanombreKeyUp(object sender, KeyEventArgs e)
			{
				try{				
					if(txtBuscarComo.Text != "")
					{
						switch(cmbBuscarPor.SelectedIndex)
						{
							case 0: busqueda = "AND P.PIEZA LIKE '%" + txtBuscarComo.Text + "%'";
									Adaptador(busqueda);
									break;
							case 1:	busqueda = "AND P.MARCA LIKE '%" + txtBuscarComo.Text + "%'";						
									Adaptador(busqueda);
									break;
							case 2: busqueda = "AND P.MODELO LIKE '%" + txtBuscarComo.Text + "%'";	
									Adaptador(busqueda);
									break;
							case 3:	busqueda = "AND P.TIPOVEHICULO LIKE '%" + txtBuscarComo.Text + "%'";
									Adaptador(busqueda);
									break;		
							case 4:	radioButtonMenor.Visible = true;
									radioButtonMayor.Visible = true;							
									busqueda = "AND P.EXISTENCIA " + simbol + " " + txtBuscarComo.Text;
									Adaptador(busqueda);
									break;
							case 5: busqueda = "AND G.NOMBRE LIKE '%" + txtBuscarComo.Text + "%'";
									Adaptador(busqueda);
									break;
							case 6: busqueda = "AND P.NO_SERIE LIKE '%" + txtBuscarComo.Text + "%'";
									Adaptador(busqueda);
									break;
						}				
					}
					else
					{
						busqueda = "";
						Adaptador(busqueda);
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message, "A ocurrido un error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			#endregion
			
			#region CANBIO INPUT TECLADO
			void CmbBuscarProductoSelectedIndexChanged(object sender, EventArgs e)
			{
				LimpiarCampos();
				switch(cmbBuscarPor.SelectedIndex)
				{
					case 0:	
					case 1:	
					case 2: 
					case 3:	OcultarRadios(); //Articulo, Marca, Modelo y Tipo de vehiculo
							txtBuscarComo.Text = "";
							this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyEspacios);
							break;	
					case 4: txtBuscarComo.Text = ""; //Existencias
							this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
							break;	
					case 5: 
					case 6: OcultarRadios(); //Grupo y No de serie
							txtBuscarComo.Text = "";
							this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
							break;
				}
				
			}
			#endregion
			
			#region RADIOS BUTTON		
			void RadioButtonMayorCheckedChanged(object sender, EventArgs e)
			{
				if(radioButtonMayor.Checked)
					simbol = ">";
			}
			
			void RadioButtonMenorCheckedChanged(object sender, EventArgs e)
			{
				if(radioButtonMenor.Checked)
					simbol = "<";
			}
			
			void OcultarRadios()
			{
				radioButtonMenor.Visible = false;
				radioButtonMayor.Visible = false;
			}
			#endregion				
			
			#region PARA CODIGO DE BARRAS
			void TxtArticuloLeave(object sender, EventArgs e)
			{
				IDpCodB(Accion);
				lbCod2.Text = (txtArticulo.Text != "") ? NoPosicionletraString(txtArticulo.Text, 0) : "00";
			}
			
			void TxtMarcaLeave(object sender, EventArgs e)
			{
				lbCod3.Text = (txtMarca.Text != "") ? NoPosicionletraString(txtMarca.Text, 0) : "00";
			}
			
			void TxtModeloLeave(object sender, EventArgs e)
			{
				lbCod4.Text = (txtModelo.Text != "") ? NoPosicionletraString(txtModelo.Text, 0) : "00";
			}
			
			void CmbTipoVehiculoLeave(object sender, EventArgs e)
			{
				lbCod5.Text = (cmbTipoVehiculo.Text != null) ? "0" + Convert.ToString(cmbTipoVehiculo.SelectedIndex + 1) : "00";
			}
			
			void TxtGrupoLeave(object sender, EventArgs e)
			{
				if(txtGrupo.Text != "")
				{
					String noGrupo = txtGrupo.Text.Substring(1); 
					String grupo = (Convert.ToInt16(noGrupo) < 10) ? "0" + noGrupo : noGrupo;
					lbCod6.Text = grupo;
				}
			}
			#endregion
			
			#region EVENTOS TECLAS
			void TxtNoSerieKeyUp(object sender, KeyEventArgs e)
			{
				if(e.KeyCode == Keys.Enter)
				{
					if(switchInsAct == true)
					{
						if(ValidaInsAct(switchInsAct) != false)
						{
								GenerarCodigoBarras();
								sqlmant.InsertarProducto(txtArticulo.Text, txtMarca.Text, txtModelo.Text, txtObservaciones.Text, cmbTipoVehiculo.Text, 0, cmbMetrica.Text, sqlmant.IDAgrupacion(txtGrupo.Text), txtNoSerie.Text, codigoBarras);
								Adaptador(busqueda);
								LimpiarCampos();	
								btnModificar.Enabled = false;
								switchInsAct = true;
								txtArticulo.Focus();
						}
					}
					else
					{
						if(ValidaInsAct(switchInsAct) != false)
						{
								GenerarCodigoBarras();
								sqlmant.ActualizarProducto(txtArticulo.Text, txtMarca.Text, txtModelo.Text, txtObservaciones.Text, cmbTipoVehiculo.Text, cmbMetrica.Text, sqlmant.IDAgrupacion(txtGrupo.Text), txtNoSerie.Text, codigoBarras, id);
								Adaptador(busqueda);		
								LimpiarCampos();
								btnModificar.Enabled = false;	
								btnAgregar.Enabled = true;
								switchInsAct = true;
								txtArticulo.Focus();
						}
					}
				}
			}
			#endregion

		#endregion
	}
}
