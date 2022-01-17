using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Linq.Expressions;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormOrdenCompra : Form
	{
//		========================
		#region PENDIENTES POR PROGRAMAR
		// * Desactivar boton nuevo si hay columna vacia
		// * Servicios en "Concepto" del DataGridView (Mantenimiento, reparacion, alineacion, ...)
		// * Actualizar solo las ordenes de compra del mismo dia en que se dan de alta (max ¿n? dias)
		// * Ver como añadir simbolos ("$" y "%") al calcular resultados sin afectar funcionalidad
		// * Copiar todas las clases de almacen a una carpeta
		#endregion
//		========================
		
		#region NEW
		
			#region INICIO
			void FormOrdenCompraLoad(object sender, EventArgs e)
			{						
				this.Validar(this);
				txtClave.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT CLAVE FROM PROVEEDOR_ALMACEN WHERE ESTATUS = 'Activo'", "CLAVE");
	           	txtClave.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
	            txtClave.AutoCompleteSource = AutoCompleteSource.CustomSource;
	            
	            txtNombre.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT NOMBRE FROM PROVEEDOR_ALMACEN WHERE ESTATUS = 'Activo'", "NOMBRE");
	           	txtNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
	            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
	            
	            CambiaCustomFormat();
	            ColoresAlternadosRows(dataOrdenCompra);
	            switchInsertaActualiza = true;
	            AgregarFila();
	            OrdenesRegistradas();
	            
	            btnNuevaFila.Enabled = false;
	            btnActualizar.Enabled = false;
	            //btnVerOrdenCompra.Enabled = false;
			}
			#endregion
			
			#region INSTANCIAS
			private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento sqlmant =  new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
			private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
			private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
			private Proceso.FormatosPDF FormatoPdf = new Transportes_LAR.Proceso.FormatosPDF();
			private Proceso.Semana sema = new Proceso.Semana();
			private Proceso.Numalet numalet = new Proceso.Numalet();
			private FormRegistrosComp registros =  null;
			Interfaz.FormPrincipal principal = null;
			#endregion
		
			#region VARIABLES
			ArrayList eliminaID = new ArrayList();
			String ID_USUARIO;
			public String idOrdCmpQuery = "";
			int contMov = 0;
			int noFilas;
			Boolean validaFila;
			Boolean validaInsercion;
			Boolean validaActualizacion;
			Boolean switchInsertaActualiza;
			#endregion			
		
			#region CONSTRUCTOR
			public FormOrdenCompra(String id_u, Interfaz.FormPrincipal princ)
			{
				InitializeComponent();
				this.ID_USUARIO=id_u;
				this.principal=princ;
			}
			
	
			#endregion
			
			#region CELLPAINTING / CLIK
			void DataOrdenCompraCellContentClick(object sender, DataGridViewCellEventArgs e)
			{
				if(dtpFecha.Enabled == true)
				{
					// Confirmar la fila
					if (e.ColumnIndex == 7 && e.RowIndex >= 0)
		  			{
						ValidaConcepto(e.RowIndex);
						if(validaFila)
						{
							dataOrdenCompra.Rows[e.RowIndex].Cells[7].Style.BackColor =  System.Drawing.Color.Lime;
							dataOrdenCompra.Rows[e.RowIndex].Cells[7].Selected = false;
							btnNuevaFila.Enabled = true;
							ActualizaCampos();
							CalculaTotal();
						}
					}
					// Quitar una fila
					if (e.ColumnIndex == 8 && e.RowIndex >= 0)
		  			{
						if(switchInsertaActualiza == false)
						{
							eliminaID.Add(dataOrdenCompra.Rows[e.RowIndex].Cells[0].Value.ToString());
						}
						btnNuevaFila.Enabled = true;
						dataOrdenCompra.Rows.RemoveAt(e.RowIndex);
						ActualizaCampos();
						CalculaTotal();
						contMov--;
					}
				}
			}
			
			void DataOrdenCompraCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
			{
				if (e.ColumnIndex == 7 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataOrdenCompra.Rows[e.RowIndex].Cells[7] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\v.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+10, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
				
				if (e.ColumnIndex == 8 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataOrdenCompra.Rows[e.RowIndex].Cells[8] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+10, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
			}
			#endregion
			
			#region BOTONES
			
				#region GUARDAR
				void Button3Click(object sender, EventArgs e)
				{
					String movi; String cant; String prod; String carr; String preu; String subt; String idmov;
					
					#region INSERTAR
					if(switchInsertaActualiza)
					{
						ValidaTodoInsercion();
						if(validaInsercion)
						{
							sqlmant.InsertarOrdenCompra(txtFolio.Text, dtpFecha.Text, txtFactura.Text, txtSemana.Text, dtpVencimiento.Text, Convert.ToInt32(sqlmant.IDProveedor(txtNombre.Text)), String.Format("{0:#0.00}", txtSubtotal1.Text), txtTipoDesc1.Text, String.Format("{0:#0.00}", txtDescuento1.Text), txtTipoIVA.Text, String.Format("{0:#0.00}", txtIVA.Text), String.Format("{0:#0.00}", txtSubtotal2.Text), txtTipoDesc2.Text, String.Format("{0:#0.00}", txtDescuento2.Text), String.Format("{0:#0.00}", txtTotal.Text), txtLetraTotal.Text, txtObervaciones.Text);
							for(int x = 0; x < noFilas; x++)
							{
								movi = dataOrdenCompra.Rows[x].Cells[1].Value.ToString();
								cant = dataOrdenCompra.Rows[x].Cells[2].Value.ToString();
								prod = dataOrdenCompra.Rows[x].Cells[3].Value.ToString();
								carr = dataOrdenCompra.Rows[x].Cells[4].Value.ToString();
								preu = dataOrdenCompra.Rows[x].Cells[5].Value.ToString();
								subt = dataOrdenCompra.Rows[x].Cells[6].Value.ToString();
								sqlmant.InsertarListaCompra(Convert.ToInt32(sqlmant.IDOrdenCompra()), movi, cant, Convert.ToInt32(sqlmant.RetornaIdProducto("PIEZA", ObtenPrimerString(prod))), Convert.ToInt32(sqlmant.IDVehiculo(ObtenPrimerString(carr))), preu, subt);
							}
							LabelsObligaVisible(false);
							LimpiarCampos();
							LimpiarConcepto();
						}
					}
					#endregion
					
					#region ACTUALIZAR
					else
					{
						ValidaTodoActualizacion();
						if(validaActualizacion)
						{
							sqlmant.ActualizarOrdenCompra(Convert.ToInt32(idOrdCmpQuery), txtFolio.Text, dtpFecha.Text, txtFactura.Text, txtSemana.Text, dtpVencimiento.Text, Convert.ToInt32(sqlmant.IDProveedor(txtNombre.Text)), String.Format("{0:#0.00}", txtSubtotal1.Text), txtTipoDesc1.Text, String.Format("{0:#0.00}", txtDescuento1.Text), txtTipoIVA.Text, String.Format("{0:#0.00}", txtIVA.Text), String.Format("{0:#0.00}", txtSubtotal2.Text), txtTipoDesc2.Text, String.Format("{0:#0.00}", txtDescuento2.Text), String.Format("{0:#0.00}", txtTotal.Text), txtLetraTotal.Text, txtObervaciones.Text);
							for(int x = 0; x < eliminaID.Count; x++)
							{
								sqlmant.EliminarListaOrdenCompra(eliminaID[x].ToString());
							}
							eliminaID.Clear();
							for(int x = 0; x < noFilas; x++)
							{
								idmov = dataOrdenCompra.Rows[x].Cells[0].Value.ToString();
								movi = dataOrdenCompra.Rows[x].Cells[1].Value.ToString();
								cant = dataOrdenCompra.Rows[x].Cells[2].Value.ToString();
								prod = dataOrdenCompra.Rows[x].Cells[3].Value.ToString();
								carr = dataOrdenCompra.Rows[x].Cells[4].Value.ToString();
								preu = dataOrdenCompra.Rows[x].Cells[5].Value.ToString();
								subt = dataOrdenCompra.Rows[x].Cells[6].Value.ToString();
								if(dataOrdenCompra.Rows[x].Cells[9].Value.ToString().Equals("Actualizar"))
								{
									sqlmant.ActualizarListaCompra(Convert.ToInt32(idmov), movi, cant, Convert.ToInt32(sqlmant.RetornaIdProducto("PIEZA", ObtenPrimerString(prod))), Convert.ToInt32(sqlmant.IDVehiculo(ObtenPrimerString(carr))), preu, subt);
								}
								if(dataOrdenCompra.Rows[x].Cells[9].Value.ToString().Equals("Insertar"))
								{
									sqlmant.InsertarListaCompra(Convert.ToInt32(idOrdCmpQuery), movi, cant, Convert.ToInt32(sqlmant.RetornaIdProducto("PIEZA", ObtenPrimerString(prod))), Convert.ToInt32(sqlmant.IDVehiculo(ObtenPrimerString(carr))), preu, subt);
								}
							}
							LabelsObligaVisible(false);
						}
					}
					#endregion
					
					OrdenesRegistradas();
				}
				#endregion
			
				#region VACIAR DATAGRIDVIEW
				void Button5Click(object sender, EventArgs e)
				{
					LimpiarConcepto();
					txtFolio.AutoCompleteMode = AutoCompleteMode.None;
					txtFactura.AutoCompleteMode = AutoCompleteMode.None;
					AgregarFila();
					TxtBoxReadOnly(false);
					btnGuardar.Enabled = true;
					btnActualizar.Enabled = false;
					switchInsertaActualiza = true;
				}
				#endregion
				
				#region VACIAR CAMPOS DE TEXTO
				void BtnLimpiaCamposClick(object sender, EventArgs e)
				{
					LimpiarCampos();
					txtFolio.AutoCompleteMode = AutoCompleteMode.None;
					txtFactura.AutoCompleteMode = AutoCompleteMode.None;
					TxtBoxReadOnly(false);
					DteTimePickerEnabled(true);
					btnGuardar.Enabled = true;
					btnActualizar.Enabled = false;
					switchInsertaActualiza = true;
				}
				#endregion
				
				#region AGREGAR FILA
				void BtnNuevaFilaClick(object sender, EventArgs e)
				{
					AgregarFila();
					btnNuevaFila.Enabled = false;
				}
				#endregion
				
				#region CONSULTAR
				void BtnConsultarClick(object sender, EventArgs e)
				{
					LimpiarCampos();
					LimpiarConcepto();
					
					txtFolio.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT FOLIO FROM ORDEN_COMPRA", "FOLIO");
		           	txtFolio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		            txtFolio.AutoCompleteSource = AutoCompleteSource.CustomSource;
		            
		            txtFactura.AutoCompleteCustomSource = auto.AutocompleteGeneral("SELECT FACTURA FROM ORDEN_COMPRA", "FACTURA");
		           	txtFactura.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		            txtFactura.AutoCompleteSource = AutoCompleteSource.CustomSource;
		            
		            TxtBoxReadOnly(true);
					DteTimePickerEnabled(false);
					
		            btnGuardar.Enabled = false;
		            btnActualizar.Enabled = true;
				}
				#endregion
				
				#region ACTUALIZAR
				void BtnActualizarClick(object sender, EventArgs e)
				{
					TxtBoxReadOnly(false);
					DteTimePickerEnabled(true);
					
		            btnGuardar.Enabled = true;
		            btnActualizar.Enabled = false;
		            btnNuevaFila.Enabled = true;
		            
		            switchInsertaActualiza = false;
				}
				#endregion
				
				#region VER ORDENES COMPRA
				void BtnVerRegistrosClick(object sender, EventArgs e)
				{
					FormRegistrosComp reg = this.InstanciaForm;
					registros.Show();
					registros.BringToFront();
				}
				#endregion
				
			#endregion
			
			#region METODOS
			
				#region CALCULO TOTAL DE ORDEN COMPRA
				public void CalculaTotal()
				{
					Double subt1 = 0; Double desc1; Double iva; Double subt2; Double desc2; Double tot;
					
					for(int x = 0; x < noFilas; x++)
					{
						subt1 += Convert.ToDouble(dataOrdenCompra.Rows[x].Cells[6].Value);
					}
					 
					desc1 = (txtTipoDesc1.Text != "0" && txtTipoDesc1.Text != "") ? (subt1 * Convert.ToDouble(txtTipoDesc1.Text)) / 100 : 0 ;
					iva = (txtTipoIVA.Text != "0" && txtTipoIVA.Text != "") ? ((subt1 - desc1) * Convert.ToDouble(txtTipoIVA.Text)) / 100 : 0;
					subt2 = (subt1 - desc1) + iva;
					desc2 = (txtTipoDesc2.Text != "0" && txtTipoDesc2.Text != "") ? (subt2 * Convert.ToDouble(txtTipoDesc2.Text)) / 100 : 0;
					tot = subt2 - desc2;
					
					txtSubtotal1.Text = subt1.ToString("#0.00", CultureInfo.InvariantCulture);
					txtDescuento1.Text = desc1.ToString("#0.00", CultureInfo.InvariantCulture);
					txtIVA.Text = iva.ToString("#0.00", CultureInfo.InvariantCulture);
					txtSubtotal2.Text = subt2.ToString("#0.00", CultureInfo.InvariantCulture);
					txtDescuento2.Text = desc2.ToString("#0.00", CultureInfo.InvariantCulture);
					txtTotal.Text = tot.ToString("#0.00", CultureInfo.InvariantCulture);
				}
				#endregion
				
				#region VACIA CAMPOS DE TEXTO 
				public void LimpiarCampos()
				{
					CambiaCustomFormat();
					txtFolio.Text = "";
					dtpFecha.Text = "";
					txtFactura.Text = "";
					txtSemana.Text = "";
					dtpVencimiento.Text = "";
					txtClave.Text = "";
					txtNombre.Text = "";
					txtClase.Text = "";
					txtTelefono.Text = "";
					txtDireccion.Text = "";
					txtObervaciones.Text = "";
					txtSubtotal1.Text = "$ 0.00";
					txtTipoDesc1.Text = "0";
					txtDescuento1.Text = "$ 0.00";
					txtTipoIVA.Text = "0";
					txtIVA.Text = "$ 0.00";
					txtSubtotal2.Text = "$ 0.00";
					txtTipoDesc2.Text = "0";
					txtDescuento2.Text = "$ 0.00";
					txtTotal.Text = "$ 0.00";
					txtLetraTotal.Text = "";
				}
				#endregion
				
				#region BORRA FILAS DATAGRIDVIEW
				public void LimpiarConcepto()
				{	
					for(int fila = noFilas - 1; fila > -1; fila--)
					{
						dataOrdenCompra.Rows.RemoveAt(fila);
						contMov--;
					}
				
					txtSubtotal1.Text = "$ 0.00";
					txtTipoDesc1.Text = "0";
					txtDescuento1.Text = "$ 0.00";
					txtTipoIVA.Text = "0";
					txtIVA.Text = "$ 0.00";
					txtSubtotal2.Text = "$ 0.00";
					txtTipoDesc2.Text = "0";
					txtDescuento2.Text = "$ 0.00";
					txtTotal.Text = "$ 0.00";
					txtLetraTotal.Text = "";
				}
				#endregion
				
				#region AGREGA UNA NUEVA FILA
				public void AgregarFila()
				{
					dataOrdenCompra.Rows.Add();
					// ID LISTA_ORDENCOMPRA
					dataOrdenCompra.Rows[contMov].Cells[0].Value = "";
					// MOVIMIENTO
					dataOrdenCompra.Rows[contMov].Cells[1].Value = "1";
					// CANTIDAD
					dataOrdenCompra.Rows[contMov].Cells[2].Value = "";
					// CONCEPTO
					dataOrdenCompra.Rows[contMov].Cells[3].Value = "";
					// CARRO
					dataOrdenCompra.Rows[contMov].Cells[4].Value = "";
					// PRECIO UNITARIO
					dataOrdenCompra.Rows[contMov].Cells[5].Value = "";
					// SUBTOTAL
					dataOrdenCompra.Rows[contMov].Cells[6].Value = "0.00";
					// PARA INSERTAR AL EDITAR
					if(switchInsertaActualiza == false)
					{
						dataOrdenCompra.Rows[contMov].Cells[9].Value = "Insertar";
					}
					contMov++;
					// NO FILAS AGREGADAS
				}
				#endregion
				
				#region ACTUALIZA FILAS
				public void ActualizaCampos()
				{
					int x;
					for(x = 0; x < noFilas ; x++)
					{
						dataOrdenCompra.Rows[x].Cells[1].Value =  Convert.ToString(x + 1);
						if(dataOrdenCompra.Rows[x].Cells[2].Value.ToString() != "" && dataOrdenCompra.Rows[x].Cells[5].Value.ToString() != "")
						{
							Double canti =  Convert.ToDouble(dataOrdenCompra.Rows[x].Cells[2].Value);
							Double precU = Convert.ToDouble(dataOrdenCompra.Rows[x].Cells[5].Value);
							Double subt = canti * precU;
							dataOrdenCompra.Rows[x].Cells[6].Value = Convert.ToString(subt);
						}
						else
						{
							dataOrdenCompra.Rows[x].Cells[6].Value = "0.00";
						}
					}
				}
				#endregion
	
				#region COMPLETA INFORMACION DE PROVEEDOR
				private void CamposProveedor(int txtBox)
				{	
					String idProv = "";
					if(txtBox == 1)
					{
						idProv = sqlmant.IDProveedor2("Clave", txtClave.Text);
						txtNombre.Text = sqlmant.DatosProveedor("Nombre", idProv);
					}
					if(txtBox == 2)
					{
						idProv = sqlmant.IDProveedor2("Nombre", txtNombre.Text);
						txtClave.Text = sqlmant.DatosProveedor("Clave", idProv);
					}
					txtClase.Text = sqlmant.DatosProveedor("Clase", idProv);
					txtTelefono.Text = sqlmant.DatosProveedor("Telefono", idProv);
					txtDireccion.Text = sqlmant.DatosProveedor("Direccion", idProv);
				}
				#endregion
	
				#region SEPARA Y RETORNA EL PRIMER STRING DE UNA CADENA
				private String ObtenPrimerString(String str)
				{
					String[] separadores = new String[]{" - "};
					String[] result;
					
					result = str.Split(separadores, StringSplitOptions.None);
			
					return result[0];
				}
				#endregion
				
				#region COLORES DE FILAS ALTERNADOS
				private void ColoresAlternadosRows(DataGridView datag)
				{
					datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
					datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
				}
				#endregion
				
				#region CAMBIA PROPIEDAD EDITABLE DE CAMPOS
				private void TxtBoxReadOnly(Boolean boo)
				{
					txtSemana.ReadOnly = boo;
					txtClave.ReadOnly = boo;
					txtNombre.ReadOnly = boo;
					dataOrdenCompra.Columns[2].ReadOnly = boo;
					dataOrdenCompra.Columns[3].ReadOnly = boo;
					dataOrdenCompra.Columns[4].ReadOnly = boo;
					dataOrdenCompra.Columns[5].ReadOnly = boo;
					dataOrdenCompra.Columns[7].ReadOnly = boo;
					dataOrdenCompra.Columns[8].ReadOnly = boo;
					txtTipoDesc1.ReadOnly = boo;
					txtTipoIVA.ReadOnly = boo;
					txtTipoDesc2.ReadOnly = boo;
					txtObervaciones.ReadOnly = boo;
				}
				
				private void DteTimePickerEnabled(Boolean boo)
				{
					dtpFecha.Enabled = boo;
					dtpVencimiento.Enabled = boo;
				}
				#endregion
				
				#region OBTIENE REGISTRO DE ORDEN COMPRA
				private void ConsultaOrdenCompra(int campo)
				{
					String consulta = "";
					String conProvID;
					String vencim = "";
					
					switch(campo)
					{
						case 0: consulta = "SELECT * FROM ORDEN_COMPRA WHERE FOLIO = " + txtFolio.Text;
								break;
						case 1: consulta = "SELECT * FROM ORDEN_COMPRA WHERE FACTURA = " + txtFactura.Text;
								break;
						case 2: consulta = "SELECT * FROM ORDEN_COMPRA WHERE ID = " + idOrdCmpQuery;
								break;
					}
					
					dtpFecha.CustomFormat = "dd / MM / yy";
					dtpVencimiento.CustomFormat = "dd / MM / yy";
					
					conn.getAbrirConexion(consulta);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						idOrdCmpQuery = conn.leer["ID"].ToString();
						txtFolio.Text = conn.leer["FOLIO"].ToString();
						dtpFecha.Text = conn.leer["FECHA"].ToString();
						txtFactura.Text = conn.leer["FACTURA"].ToString();
						txtSemana.Text = conn.leer["SEMANA"].ToString();
						vencim = conn.leer["VENCIMIENTO"].ToString();
						conProvID = conn.leer["ID_PROVEE"].ToString();
						txtClave.Text = sqlmant.DatosProveedor("CLAVE", conProvID);
						txtSubtotal1.Text = conn.leer["SUBTOTAL_1"].ToString();
						txtTipoDesc1.Text = conn.leer["TIPO_DESC1"].ToString();
						txtDescuento1.Text = conn.leer["DESCUENTO_1"].ToString();
						txtTipoIVA.Text = conn.leer["TIPO_IVA"].ToString();
						txtIVA.Text = conn.leer["IVA"].ToString();
						txtSubtotal2.Text = conn.leer["SUBTOTAL_2"].ToString();
						txtTipoDesc2.Text = conn.leer["TIPO_DESC2"].ToString();
						txtDescuento2.Text = conn.leer["DESCUENTO_2"].ToString();
						txtTotal.Text = conn.leer["TOTAL"].ToString();
						txtLetraTotal.Text = conn.leer["TOTAL_LETRA"].ToString();
						txtObervaciones.Text = conn.leer["OBSERVACIONES"].ToString();
					}
					conn.conexion.Close();
					if(vencim != " ")
					{
						dtpVencimiento.Text = vencim;
					}
					else
					{
						dtpVencimiento.Text = "01/01/00";
						dtpVencimiento.CustomFormat = " ";
					}
					CamposProveedor(1);
				}
				#endregion
				
				#region OBTIENE REGISTROS DE LISTA ORDDENCOMPRA
				private void ConsultaListaCompra()
				{
					int contador = 0;
					contMov = 0;
					dataOrdenCompra.Rows.Clear();
					conn.getAbrirConexion("SELECT * FROM LISTA_ORDENCOMPRA WHERE ID_ORDENC = "+idOrdCmpQuery);
					conn.leer = conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						dataOrdenCompra.Rows.Add();
						dataOrdenCompra.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
						dataOrdenCompra.Rows[contador].Cells[1].Value = conn.leer["MOVIMIENTO"].ToString();
						dataOrdenCompra.Rows[contador].Cells[2].Value = conn.leer["CANTIDAD"].ToString();
						dataOrdenCompra.Rows[contador].Cells[3].Value = sqlmant.CadenaProdOrdenC(conn.leer["ID_PROD"].ToString());
						dataOrdenCompra.Rows[contador].Cells[4].Value = sqlmant.CadenaCarroOrdenC(conn.leer["ID_CARRO"].ToString());
						dataOrdenCompra.Rows[contador].Cells[5].Value = conn.leer["PRECIO_U"].ToString();
						dataOrdenCompra.Rows[contador].Cells[6].Value = conn.leer["SUBTOTAL"].ToString();
						dataOrdenCompra.Rows[contador].Cells[9].Value = "Consulta";
						
						contador++;
						contMov++;						
					}
					conn.conexion.Close();
				}
				#endregion
				
				#region CAMBIA FORMATO DE DATETIMEPICKERS
				private void CambiaCustomFormat()
				{
					dtpFecha.Format = DateTimePickerFormat.Custom;
					dtpFecha.CustomFormat = " ";
					dtpVencimiento.Format = DateTimePickerFormat.Custom;
					dtpVencimiento.CustomFormat = " ";
				}
			
				void DtpFechaCloseUp(object sender, EventArgs e)
				{
					dtpFecha.Format = DateTimePickerFormat.Custom;
					dtpFecha.CustomFormat = "dd / MM / yy";
					DateTime dateT;
					dateT = Convert.ToDateTime(dtpFecha.Text);
					txtSemana.Text = sema.SemanaAno(dateT);
				}
				
				void DtpVencimientoCloseUp(object sender, EventArgs e)
				{
					DateTime mindateFecha = Convert.ToDateTime(dtpFecha.Text);
					dtpVencimiento.MinDate = mindateFecha.AddDays(1);
					dtpVencimiento.Format = DateTimePickerFormat.Custom;
					dtpVencimiento.CustomFormat = "dd / MM / yy";	
				}
				#endregion
				
				#region CAMPOS OBLIGATORIOS
				private void LabelsObligaVisible(Boolean boo)
				{
					lbObligado1.Visible = boo;
					lbObligado2.Visible = boo;
					lbObligado3.Visible = boo;
					lbObligado4.Visible = boo;
					lbObligado5.Visible = boo;
				}
				#endregion
				
				#region CONTEO ORDENES COMPRA
				private void OrdenesRegistradas()
				{
					txtOrdenesReg.Text = sqlmant.ConteoOrdenes();
				}
				#endregion
				
				#region CONSULTA EXTERNA
				public void ConsultaExterna()
				{
					LimpiarCampos();
					LimpiarConcepto();
					
					TxtBoxReadOnly(true);
					DteTimePickerEnabled(false);
					
		            btnGuardar.Enabled = false;
		            btnActualizar.Enabled = true;
		            
		            ConsultaOrdenCompra(2);
					ConsultaListaCompra();
				}
				#endregion
				
			#endregion
			
			#region LLENADO / AUTOCOMPLETADO DE DATOS
			
				#region AUTOCOMPLETA DATAGRIDVIEW TEXTBOX E IPUTS
				void DataOrdenCompraEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
				{
					int column = dataOrdenCompra.CurrentCell.ColumnIndex;
					e.Control.KeyPress -= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
					
					if(column == 3)
					{
						TextBox tbConcepto = e.Control as TextBox;
						
						if(tbConcepto != null)
						{
							tbConcepto.AutoCompleteCustomSource = auto.AutocompleteOrdenCompra("Concepto");
							tbConcepto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
							tbConcepto.AutoCompleteSource = AutoCompleteSource.CustomSource;
						}
					}
					
					if(column == 4)
					{
						TextBox tbCarro = e.Control as TextBox;
						
						if(tbCarro != null)
						{
							tbCarro.AutoCompleteCustomSource = auto.AutocompleteOrdenCompra("Carro");
							tbCarro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
							tbCarro.AutoCompleteSource = AutoCompleteSource.CustomSource;
						}
					}
					
					if(column == 2)
					{
						TextBox tbCantidad = e.Control as TextBox;
						
						tbCantidad.AutoCompleteMode = AutoCompleteMode.None;
						tbCantidad.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
					}
					
					if(column == 5)
					{
						TextBox tbPrecioU = e.Control as TextBox;
						
						tbPrecioU.AutoCompleteMode = AutoCompleteMode.None;
						tbPrecioU.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
					}
				}
				#endregion
				
				#region LLENA CAMPOS PROVEEDOR
				void TxtClaveLeave(object sender, EventArgs e)
				{
					if(txtClave.Text != "" && sqlmant.IDProveedor2("Clave", txtClave.Text) != "")
					CamposProveedor(1);
				}
				
				void TxtNombreLeave(object sender, EventArgs e)
				{
					if(txtNombre.Text != "" && sqlmant.IDProveedor2("Nombre", txtNombre.Text) != "")
					CamposProveedor(2);
				}
				
				void TxtClaveKeyUp(object sender, KeyEventArgs e)
				{
					if(txtClave.Text != "" && sqlmant.IDProveedor2("Clave", txtClave.Text) != "")
					{
						if(e.KeyCode == Keys.Enter)
						{
							CamposProveedor(1);
						}
					}
				}
				
				void TxtNombreKeyUp(object sender, KeyEventArgs e)
				{
					if(txtNombre.Text != "" && sqlmant.IDProveedor2("Nombre", txtNombre.Text) != "")
					{
						if(e.KeyCode == Keys.Enter)
						{
							CamposProveedor(2);
						}
					}
				}
				#endregion
				
				#region LLENA TOTALES
				void TxtTipoDesc1Leave(object sender, EventArgs e)
				{
					CalculaTotal();
				}
				
				void TxtTipoIVALeave(object sender, EventArgs e)
				{
					CalculaTotal();
				}
				
				void TxtTipoDesc2Leave(object sender, EventArgs e)
				{
					CalculaTotal();
				}
				
				void TxtTipoDesc2KeyUp(object sender, KeyEventArgs e)
				{
					if(e.KeyCode == Keys.Enter)
					{
						CalculaTotal();
					}
				}
				#endregion
				
				#region LLENA FORMULARIO AL CONSULTAR
				void TxtFolioKeyUp(object sender, KeyEventArgs e)
				{
					if(e.KeyCode == Keys.Enter)
					{
						if(dtpFecha.Enabled == false)
						{
							if(txtFolio.Text != "" && sqlmant.ValidaOrdenCompra("FOLIO", txtFolio.Text, "") == false)
							{
								ConsultaOrdenCompra(0);
								ConsultaListaCompra();
							}
						}
					}
				}
				
				void TxtFacturaKeyUp(object sender, KeyEventArgs e)
				{
					if(e.KeyCode == Keys.Enter)
					{
						if(dtpFecha.Enabled == false)
						{
							if(txtFactura.Text != "" && sqlmant.ValidaOrdenCompra("FACTURA", txtFactura.Text, "") == false)
							{
								ConsultaOrdenCompra(1);
								ConsultaListaCompra();
							}
						}
					}
				}
				#endregion
				
			#endregion
			
			#region VALIDACIONES
				
				#region INSERCION
				private void ValidaTodoInsercion()
				{
					String idprov1 = (txtNombre.Text != "") ? txtNombre.Text : " ";
					String idprov2 = (txtClave.Text != "") ? txtClave.Text : " ";
					int ultimoIndex = noFilas - 1;
					
					
					if(txtFolio.Text != "" && dtpFecha.CustomFormat != " " && txtFactura.Text != "" && txtNombre.Text != "" && txtClave.Text != "")
					{
						if(sqlmant.ValidaOrdenCompra("Folio", txtFolio.Text, "") && sqlmant.ValidaOrdenCompra("Factura", txtFactura.Text, ""))
						{
							if(sqlmant.IDProveedor2("Nombre", idprov1) != "" || sqlmant.IDProveedor2("Clave", idprov2) != "")
							{
								
								if(noFilas >= 1)
								{
									ValidaConcepto(ultimoIndex);
									if(validaFila)
									{
										validaInsercion = true;
									}
									else
									{
										MessageBox.Show("Parece que se agrego una fila sin validar\nal final de la tabla de 'Concepto'", "Error al procesar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
										validaInsercion = false;
									}
								}
								else
								{
									MessageBox.Show("Aun no se ha capturado un concepto\npara la orden de compra", "Error al procesar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									validaInsercion = false;
								}
							}
							else
							{
								MessageBox.Show("La clave o nombre de proveedor no coinciden con\nningun proveedor de la base de datos del sistema", "Error de referencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								txtClave.Focus();
								validaInsercion = false;
							}
						}
						else
						{
							MessageBox.Show("El folio o numero de factura especificados coinciden con\nuna orden de conpra ya cargada en el sitema", "Error de coincidencia datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txtFolio.Focus();
							validaInsercion = false;
						}
					}
					else
					{
						MessageBox.Show("Los campos marcados con el asterisco (*)\ndeben ser completados", "Error al procesar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						LabelsObligaVisible(true);
						txtFolio.Focus();
						validaInsercion = false;
					}
				}
				#endregion
				
				#region ACTUALIZACION
				private void ValidaTodoActualizacion()
				{
					String idprov1 = (txtNombre.Text != "") ? txtNombre.Text : " ";
					String idprov2 = (txtClave.Text != "") ? txtClave.Text : " ";
					
					if(txtFolio.Text != "" && dtpFecha.CustomFormat != " " && txtFactura.Text != "" && txtNombre.Text != "" && txtClave.Text != "")
					{
						if(sqlmant.ValidaOrdenCompra("Folio", txtFolio.Text, "AND FOLIO !='"+sqlmant.DatosOrdenCompra("FOLIO", idOrdCmpQuery)+"'") && sqlmant.ValidaOrdenCompra("Factura", txtFactura.Text, "AND FACTURA !='"+sqlmant.DatosOrdenCompra("FACTURA", idOrdCmpQuery)+"'"))
						{
							if(sqlmant.IDProveedor2("Nombre", idprov1) != "" || sqlmant.IDProveedor2("Clave", idprov2) != "")
							{
								ValidaConcepto(0);
								if(noFilas >= 1 && validaFila)
								{
									validaActualizacion = true;
								}
								else
								{
									MessageBox.Show("Debe haber almenos un registro especificado en\nla seccion de 'Concepto' para guardar los datos", "Error al procesar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
									validaActualizacion = false;
								}
							}
							else
							{
								MessageBox.Show("La clave o nombre de proveedor no coinciden con\nningun proveedor de la base de datos del sistema", "Error de referencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								txtClave.Focus();
								validaActualizacion = false;
							}
						}
						else
						{
							MessageBox.Show("El folio o numero de factura especificados coinciden con\nuna orden de conpra ya cargada en el sitema", "Error de coincidencia datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txtFolio.Focus();
							validaActualizacion = false;
						}
					}
					else
					{
						MessageBox.Show("Los campos marcados con el asterisco (*)\ndeben ser completados", "Error al procesar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						LabelsObligaVisible(true);
						txtFolio.Focus();
						validaActualizacion = false;
					}
				}
				#endregion
			
				#region DATAGRIDVIEW
				private void ValidaConcepto(int indice)
				{
					String movi = ""; String cant = ""; String prod = ""; String carr = ""; String preU = "";
					
					movi = dataOrdenCompra.Rows[indice].Cells[1].Value.ToString();
					cant = dataOrdenCompra.Rows[indice].Cells[2].Value.ToString();
					prod = dataOrdenCompra.Rows[indice].Cells[3].Value.ToString();
					carr = dataOrdenCompra.Rows[indice].Cells[4].Value.ToString();
					preU = dataOrdenCompra.Rows[indice].Cells[5].Value.ToString();
					
					if(cant != "")
					{
						if(prod != "" && sqlmant.RetornaIdProducto("PIEZA", ObtenPrimerString(prod)) != "")
						{
							if(carr != "" && sqlmant.IDVehiculo(ObtenPrimerString(carr)) != "")
							{
								if(preU != "")
								{
									validaFila = true;
								}
								else
								{
									dataOrdenCompra.Rows[indice].Cells[5].Selected = true;
									validaFila = false;
								}
							}
							else
							{
								dataOrdenCompra.Rows[indice].Cells[4].Selected = true;
								MessageBox.Show("Ningun registro en el sistema coincide con el texto introducido en\nla celda de 'Carro'", "Error al validar la fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								validaFila = false;
							}
						}
						else
						{
							dataOrdenCompra.Rows[indice].Cells[3].Selected = true;
							MessageBox.Show("Ningun registro en el sistema coincide con el texto introducido en\nla celda de 'Concepto'", "Error al validar la fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							validaFila = false;
						}
					}
					else
					{
						dataOrdenCompra.Rows[indice].Cells[2].Selected = true;
						validaFila = false;						
					}
				}
				#endregion
				
				#region IMPUT TECLADO
				void Validar(Interfaz.Mantenimiento.Complementos.FormOrdenCompra ordenConmpra)
				{
					ordenConmpra.txtFolio.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
					ordenConmpra.txtFactura.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
					ordenConmpra.txtSemana.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
					ordenConmpra.txtClave.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
					ordenConmpra.txtTipoDesc1.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
					ordenConmpra.txtTipoIVA.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
					ordenConmpra.txtTipoDesc2.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
				}
				#endregion
				
				#region VENTANA REGISTROS
				private FormRegistrosComp InstanciaForm
				{
					get
					{
						if(registros == null)
						{
							registros =  new FormRegistrosComp(this);
							registros.Disposed += new EventHandler(registros_Disposed);
						}
						
						return registros;
					}
				}
				
				void registros_Disposed(object sender, EventArgs e)
				{
					registros = null;
				}
				#endregion
			
			#endregion
			
			#region EVENTOS
			
				#region CONTADOR CONCEPTOS
				void DataOrdenCompraRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
				{
					txtCuentaOrdenesCompra.Text = dataOrdenCompra.Rows.Count.ToString();
					
					if(dataOrdenCompra.FirstDisplayedScrollingColumnIndex < 0)
					{
						txtCuentaOrdenesCompra.Text = "0";
					}
					noFilas = Convert.ToInt16(txtCuentaOrdenesCompra.Text);
				}
				
				void DataOrdenCompraRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
				{
					txtCuentaOrdenesCompra.Text = dataOrdenCompra.Rows.Count.ToString();
					
					if(dataOrdenCompra.FirstDisplayedScrollingColumnIndex < 0)
					{
						txtCuentaOrdenesCompra.Text = "0";
					}
					noFilas = Convert.ToInt16(txtCuentaOrdenesCompra.Text);
				}
				#endregion
				
				#region TOTAL A CARDINAL
				void TxtTotalTextChanged(object sender, EventArgs e)
				{
					if(txtTotal.Text != "$ 0.00" && txtTotal.Text != "0.00")
					{
						numalet.ConvertirDecimales = true;
						numalet.SeparadorDecimalSalida = "pesos con";
						numalet.MascaraSalidaDecimal = "centavos";							
						txtLetraTotal.Text = numalet.ToCustomCardinal(txtTotal.Text);
					}
				}
				#endregion
				
				#region FILA A ACTUALIZAR
				void DataOrdenCompraCellEndEdit(object sender, DataGridViewCellEventArgs e)
				{
					if(switchInsertaActualiza == false)
					{
						String valor = (dataOrdenCompra.Rows[e.RowIndex].Cells[9].Value != null) ? dataOrdenCompra.Rows[e.RowIndex].Cells[9].Value.ToString() : "";
							
						if(valor != "Insertar")
						{
							String cant = ""; String prod = ""; String vehi = ""; String preu = "";
							String idListaComp = dataOrdenCompra.Rows[e.RowIndex].Cells[0].Value.ToString();
							
							conn.getAbrirConexion("SELECT CANTIDAD, ID_PROD, ID_CARRO, PRECIO_U FROM LISTA_ORDENCOMPRA WHERE ID = "+idListaComp);
							conn.leer = conn.comando.ExecuteReader();
							while(conn.leer.Read())
							{
								cant = conn.leer["CANTIDAD"].ToString();
								prod = sqlmant.CadenaProdOrdenC(conn.leer["ID_PROD"].ToString());
								vehi = sqlmant.CadenaCarroOrdenC(conn.leer["ID_CARRO"].ToString());
								preu = conn.leer["PRECIO_U"].ToString();
							}
							conn.conexion.Close();
							
							String canti = dataOrdenCompra.Rows[e.RowIndex].Cells[2].Value.ToString();
							String idpro = dataOrdenCompra.Rows[e.RowIndex].Cells[3].Value.ToString();
							String idveh = dataOrdenCompra.Rows[e.RowIndex].Cells[4].Value.ToString();
							String preci = dataOrdenCompra.Rows[e.RowIndex].Cells[5].Value.ToString();
							
							if(canti != cant || idpro != prod || idveh != vehi || preci != preu)
							{
								dataOrdenCompra.Rows[e.RowIndex].Cells[9].Value = "Actualizar";
							}
						}
					}
				}
				#endregion
			
			#endregion
			
		#endregion
		
		#region OLD
			
			#region INSTANCIAS
			/*
			private Proceso.FormatosPDF pdf = new Transportes_LAR.Proceso.FormatosPDF();
			private Proceso.PDF PDFs= new Transportes_LAR.Proceso.PDF();
			*/
			#endregion
			
			#region EVENTOS BOTONES
			/*			
			void BtnVerOrdenCompraClick(object sender, EventArgs e)
			{		
				PDF();
				String [] cantidad = new String[contador];
				String [] concepto = new String[contador];
				String [] precioUni = new String[contador];
				String [] importes = new String[contador];
				
				
				cantidad[0] = dataOrdenCompra.Rows[0].Cells[1].Value.ToString();
				concepto[0] = dataOrdenCompra.Rows[0].Cells[2].Value.ToString();
				precioUni[0] = dataOrdenCompra.Rows[0].Cells[3].Value.ToString();
				importes[0] = dataOrdenCompra.Rows[0].Cells[4].Value.ToString();
				
				cmbProveedorNombre.Text = null;
				cmbProveedorRFC.Text = null;
				txtProveedorDomicilio.Text = "";
				txtProveedorTelefono.Text = "";
				cmbUnidad.Text = null;
				txtCantidadConcepto.Text="";
				cmbIdProducto.Text = null;
				cmbProductoNombre.Text = null;
			}
			*/
			#endregion
			
			#region METODOS
			/*
			public void tablaContenido(Document doc)
			{
				Paragraph espacio = new Paragraph("                                                                                     ", FontFactory.GetFont("ARIAL", 5));
					
				PdfPTable datoscontenido = new PdfPTable(dataOrdenCompra.Columns.Count);
					for(int j = 0; j < dataOrdenCompra.Columns.Count; j++){
						datoscontenido.AddCell(PDFs.TitLgray115308(dataOrdenCompra.Columns[j].HeaderText));
					}
					datoscontenido.HeaderRows = 1;
					for(int i = 0; i < dataOrdenCompra.Rows.Count; i++)
					{
						for(int k = 0; k < dataOrdenCompra.Columns.Count; k++)
						{
							if(dataOrdenCompra[k, i].Value != null)
							{
								datoscontenido.AddCell(new Phrase(dataOrdenCompra[k, i].Value.ToString()));
							}
						}
					}				
					datoscontenido.WidthPercentage = 100;
					datoscontenido.HorizontalAlignment = 1;
					doc.Add(datoscontenido);
					
					//inicia total neto
					float[] widthsNeto = new float[] {50f, 50f};
					PdfPTable datosNeto = new PdfPTable(2);
					datosNeto.SetWidths(widthsNeto);
					datosNeto.WidthPercentage = 20;
					datosNeto.HorizontalAlignment = 2;
		   		    datosNeto.AddCell(new Paragraph("Subtotal", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
		   		    datosNeto.AddCell(new Paragraph("$", FontFactory.GetFont("Arial", 8)));
		   		    datosNeto.AddCell(new Paragraph("IVA", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
		   		    datosNeto.AddCell(new Paragraph("$", FontFactory.GetFont("Arial", 8)));
		   		    datosNeto.AddCell(new Paragraph("Total", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD)));
		   		    datosNeto.AddCell(new Paragraph("$", FontFactory.GetFont("Arial", 8)));
					doc.Add(datosNeto);
					
					//inicia final del recibo
					doc.Add(new Paragraph(espacio));
					
					float[] widthsfirma = new float[] {50f, 50f};
					PdfPTable datosfirma = new PdfPTable(2);
					datosfirma.SetWidths(widthsfirma);
					datosfirma.WidthPercentage = 100;
					datosfirma.AddCell(new Paragraph("Observaciones:\n"+txtObervaciones.Text));
		   		    datosfirma.AddCell(new Paragraph(".                                                                                                                                                                           " +
					                                 ".                                                                                                                                                                           " +
					                                 ".                                                                                                                                                                           " +
					                                 ".                                                                                                                                                                           " +
					                                 ".                                                                                                                                                                           " +
					                                 "-------------------------------------------------------------------------------------------------------------.                                                  Firma Empleado", FontFactory.GetFont("Arial", 8)));
					datosfirma.HorizontalAlignment = 1;
					doc.Add(datosfirma);
					
			}
			*/
			#endregion				
			
			#region PDF
			/*
			void PDF()
			{
				String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
				string newPath = System.IO.Path.Combine(activeDir, "Orden "+DateTime.Now.ToString("dd-MM-yyyy"));
		        System.IO.Directory.CreateDirectory(newPath);
		       
		        Document doc = new Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10);
	            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
	            saveFileDialog1.InitialDirectory = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Orden "+DateTime.Now.ToString("dd-MM-yyyy");
	            saveFileDialog1.Title = "Guardar Reporte";
	            saveFileDialog1.DefaultExt = "pdf";
	            saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
	            saveFileDialog1.FilterIndex = 2;
	            saveFileDialog1.RestoreDirectory = true;
	            string filename = "Informe de Productos";
	            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
	            {
	                filename = saveFileDialog1.FileName;
	            }
	
	            if (filename.Trim() != "")
	            {
	                FileStream file = new FileStream(filename,
	                FileMode.OpenOrCreate,
	                FileAccess.ReadWrite,
	                FileShare.ReadWrite);
	            	
	               	PdfWriter writer = PdfWriter.GetInstance(doc, file);
	                doc.Open();
	               
	                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\Transportes LAR - Slim\Transportes_LAR\bin\Debug\LAR.JPG");
	                
					imagen.BorderWidth = 0;
					imagen.Alignment = Element.ALIGN_RIGHT;
					float percentage = 0.0f;
					percentage = 250 / imagen.Width;
					imagen.ScalePercent(percentage * 100);
					doc.Add(imagen);
					
					pdf.OrdenCompra(doc, writer, cmbProveedorNombre.Text, cmbProveedorRFC.Text, txtProveedorDomicilio.Text, txtProveedorTelefono.Text, cmbUnidad.Text, txtObervaciones.Text);
	      			
					tablaContenido(doc);
	                doc.Close();
	                Process.Start(filename);
				
	            }		
			}
			*/
			#endregion
			
		#endregion
		
		void BtnVerOrdenCompraClick(object sender, EventArgs e)
		{
			String Fechecarpeta = "test";
			int folio = 1;
			String activeDir = System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop";
			string newPath = System.IO.Path.Combine(activeDir, "OrdenCompra "+Fechecarpeta);
	        System.IO.Directory.CreateDirectory(newPath);
        
			try
			{		
				//DatosOperadorPDF(x);
				Document doc = new Document(PageSize.LETTER, 15, 15 ,10, 10);
				FileStream file = new FileStream(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\OrdenCompra "+Fechecarpeta+@"\"+folio+" OC.pdf",
				                                 FileMode.OpenOrCreate,
				                                 FileAccess.ReadWrite,
				                                 FileShare.ReadWrite);
				PdfWriter writer = PdfWriter.GetInstance(doc, file);
				doc.Open();
				GenerarDocumentoDinamicamente(doc, writer);
		        doc.Close();
		        Process.Start(System.Environment.SystemDirectory.Substring(0, 3) + @"Users\" + System.Windows.Forms.SystemInformation.UserName + @"\Desktop\OrdenCompra "+Fechecarpeta+@"\"+folio+" OC.pdf");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		public void GenerarDocumentoDinamicamente(Document document, PdfWriter writer)
		{ 
			FormatoPdf.OrdenCompra(principal, document, writer, txtFolio.Text, dtpFecha.Value.ToShortDateString(), txtFactura.Text,
			                       	txtSemana.Text, dtpVencimiento.Value.ToShortDateString(), txtClave.Text, txtClase.Text, "otros", txtNombre.Text,
			                      	txtDireccion.Text, txtTelefono.Text, dataOrdenCompra, txtSubtotal1.Text, txtTipoDesc1.Text, txtDescuento1.Text, txtTipoIVA.Text, txtIVA.Text, 
			                      	txtSubtotal2.Text, txtTipoDesc2.Text, txtDescuento2.Text, txtTotal.Text, txtLetraTotal.Text, txtObervaciones.Text);
		}
	}	
}
