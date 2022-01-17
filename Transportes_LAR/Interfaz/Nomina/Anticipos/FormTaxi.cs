using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	public partial class FormTaxi : Form
	{
		#region VARIABLES
		Int64 IdOperador;
		String IdUnidad;
		String id_descuento;
		String id_usuario = "";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		private Proceso.Excel Excels = new Transportes_LAR.Proceso.Excel();
		#endregion
		
		#region CONTRUCTORES
		public FormTaxi(Interfaz.FormPrincipal principal, String id_usuario)
		{
			InitializeComponent();
			this.principal = principal;
			this.id_usuario = id_usuario;
		}
		#endregion
		
		#region BOTONES
		void BtnAgregarClick(object sender, EventArgs e)
		{
			Guardar();
		}
		
		void BtnExcelClick(object sender, EventArgs e)
		{
			//Excels.HojaDescuentos();
		}
		#endregion
		
		#region GUARDAR
		void Guardar()
		{
			if(txtEmpresa.Text=="")
				txtEmpresa.BackColor = Color.LightPink;
			else
				txtEmpresa.BackColor = Color.White;
			
			if(txtOperador.Text=="")
				txtOperador.BackColor = Color.LightPink;
			else
				txtOperador.BackColor = Color.White;
			
			if(txtUnidad.Text=="")
			{
				txtUnidad.BackColor = Color.LightPink;
				txtUnidad.Text = "100";
			}
			else
				txtUnidad.BackColor = Color.White;
			
			if(txtImporteTaxi.Text=="")
				txtImporteTaxi.BackColor = Color.LightPink;
			else
				txtImporteTaxi.BackColor = Color.White;
			
			if(txtRuta.Text=="")
				txtRuta.BackColor = Color.LightPink;
			else
				txtRuta.BackColor = Color.White;

			if(txtEmpresa.Text!="" && txtUnidad.Text!="" && txtOperador.Text!="" && txtImporteTaxi.Text!=""  && txtRuta.Text!="")
			{
				new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento(IdOperador, "TAXI", "A", 0.00, principal.idUsuario, "DESCUENTO DE TAXI");
				this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
				new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoTaxi(id_descuento, dtFechaCobro.Value.ToString("yyyy-MM-dd"), dtFechaTaxi.Value.ToString("yyyy-MM-dd"), txtEmpresa.Text, txtRuta.Text, cmbTurno.Text, Convert.ToDouble(txtImporteTaxi.Text), IdUnidad, cmbEstado.Text);
			}
			else
				MessageBox.Show("Favor de llenar el campo rosa", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			
			Adaptadores();
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormTaxiLoad(object sender, EventArgs e)
		{
			Validar(this);
			PeriodoAnticipos();
			Nivel();
			dtFechaCobro.MinDate = dtFechaTaxi.Value;
			txtUnidad.AutoCompleteCustomSource = auto.AutocompleteUnidad();
			txtUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' ", "Alias");
			txtOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtEmpresa.AutoCompleteCustomSource = auto.AutocompleteEmpresa();
			txtEmpresa.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtEmpresa.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cmbTurno.SelectedIndex = 0;
			cmbEstado.SelectedIndex = 0;
			Adaptadores();
		}
		
		void FormTaxiFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.taxi =  false;
		}
		#endregion
		
		#region RETORNO DE DATOS
		void TxtUnidadKeyUp(object sender, KeyEventArgs e)
		{
			 if (e.KeyCode == Keys.Enter)
			 {
			 	try{
			 	txtOperador.Text = (new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getTraerOperador(txtUnidad.Text)).ToString();
			 	IdOperador = Convert.ToInt64(new Conexion_Servidor.Operador.SQL_Operador().getIdOperador(txtOperador.Text));
			 	IdUnidad = new Conexion_Servidor.Unidad.SQL_Unidad().getId(txtUnidad.Text).ToString();
			 	}catch{}
			 }
		}
		
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			 if (e.KeyCode == Keys.Enter)
			 {
			 	try{
			 	txtUnidad.Text = new Conexion_Servidor.Asignacion.SQL_OperadorVehiculo().getTraerUnidad(txtOperador.Text);
			 	IdOperador = Convert.ToInt64(new Conexion_Servidor.Operador.SQL_Operador().getIdOperador(txtOperador.Text));
			 	IdUnidad = new Conexion_Servidor.Unidad.SQL_Unidad().getId(txtUnidad.Text).ToString();
			 	}catch{}
			 }
		}
		
		void TxtEmpresaKeyUp(object sender, KeyEventArgs e)
		{
			 if (e.KeyCode == Keys.Enter)
		      {
			 		txtRuta.AutoCompleteCustomSource = auto.AutocompleteRuta(txtEmpresa.Text);
					txtRuta.AutoCompleteMode =AutoCompleteMode.Suggest;
					txtRuta.AutoCompleteSource = AutoCompleteSource.CustomSource;
			  }
		}
		#endregion
		
		#region IMAGEN DATAGRIDVIEW
		void DataInvetigarCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 8 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataInvestigar.Rows[e.RowIndex].Cells[8] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\a.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+20, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
			if (e.ColumnIndex == 9 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataInvestigar.Rows[e.RowIndex].Cells[9] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\i.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+20, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		
		void DataCobrarCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 9 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataCobrar.Rows[e.RowIndex].Cells[9] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\c.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+20, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		
		void DataListadoCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 11 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dataListado.Rows[e.RowIndex].Cells[11] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+20, e.CellBounds.Top+3);
      		    e.Handled = true;
			}
		}
		#endregion
		
		#region MODIFICAR ESTADO
		void DataInvestigarCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 8 && e.RowIndex >= 0)
  			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de mandar a cobro este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Conexion_Servidor.Anticipos.SQL_Anticipos().ModificarEstadoTaxi(dataInvestigar.Rows[e.RowIndex].Cells[0].Value.ToString(), "Cobrable");
					Adaptadores();
				}
			}
			if (e.ColumnIndex == 9 && e.RowIndex >= 0)
  			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de mandar a como incobrable este Registro??", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Conexion_Servidor.Anticipos.SQL_Anticipos().ModificarEstadoTaxi(dataInvestigar.Rows[e.RowIndex].Cells[0].Value.ToString(), "Incobrable");
					Adaptadores();
				}
			}
		}
		#endregion
		
		#region ENVIAR A COBRO TAXI
		void DataCobrarCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 9 && e.RowIndex >= 0)
  			{
				if(dataCobrar.Rows[e.RowIndex].Cells[11].Value.ToString()!="Incobrable")
				{
					Interfaz.Nomina.Anticipos.FormTaxiPago FormDescontar = new Transportes_LAR.Interfaz.Nomina.Anticipos.FormTaxiPago(principal, dataCobrar.Rows[e.RowIndex].Cells[0].Value.ToString(), dataCobrar.Rows[e.RowIndex].Cells[10].Value.ToString(), id_usuario);
					FormDescontar.ShowDialog();
					Adaptadores();
				}
				else
				{
					MessageBox.Show("Este taxi es incobrable, no es posible mandar a cobro", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				}
			}
		}
		#endregion
		
		#region ELIMINAR TAXI
		void DataListadoCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 11 && e.RowIndex >= 0)
  			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de eliminar este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Conexion_Servidor.Anticipos.SQL_Anticipos().EliminarDetalleTaxi(dataListado.Rows[e.RowIndex].Cells[0].Value.ToString());
					Adaptadores();
				}
			}
		}
		#endregion
		
		#region VALIDAR
		void Validar(Interfaz.Nomina.Anticipos.FormTaxi formtaxi)
		{
			formtaxi.txtOperador.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formtaxi.txtEmpresa.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formtaxi.txtRuta.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formtaxi.cmbTurno.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			formtaxi.cmbEstado.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloVacio);
			formtaxi.txtImporteTaxi.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		
		void TxtImporteTaxiTextChanged(object sender, EventArgs e)
		{
			if(txtImporteTaxi.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		#endregion
		
		#region PERIODO PAGO
		void PeriodoAnticipos()
		{
			conn.getAbrirConexion("select FECHAINICIO, FECHAFIN from PERIODO WHERE FECHAINICIO <= '"+dtFechaActual.Value.ToString().Substring(0,10)+"' and FECHAFIN >= '"+dtFechaActual.Value.AddDays(-2).ToString().Substring(0,10)+"'");
			conn.leer=conn.comando.ExecuteReader();
            if(conn.leer.Read())
            {
            	dtInicio.Value = (Convert.ToDateTime(conn.leer["FECHAINICIO"].ToString().Substring(0,10)));
            	dtCorte.Value = (Convert.ToDateTime(conn.leer["FECHAFIN"].ToString().Substring(0,10)));
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region EVENTO DATAPICKER
		void DtFechaActualValueChanged(object sender, EventArgs e)
		{
			dtFechaCobro.MaxDate = dtCorte.Value;
			dtFechaCobro.MinDate = dtInicio.Value;
		}
		
		void DtFechaTaxiValueChanged(object sender, EventArgs e)
		{
			dtFechaCobro.MinDate = dtFechaTaxi.Value;
			dtFechaCobro.MaxDate = dtCorte.Value;
		}
		#endregion
		
		#region ADAPTADORES
		void Adaptadores()
		{
			int contador = 0;
			dataListado.Rows.Clear();
			dataListado.ClearSelection();
			conn.getAbrirConexion("select DTA.ID, O.Alias, V.NUMERO, DTA.FECHA_PAGO, DTA.FECHA_TAXI, DTA.EMPRESA, DTA.RUTA, DTA.TURNO, DTA.IMPORTE_TAXI, DTA.ESTADO, D.IMPORTE_TOTAL,  D.ID AS ID_DESC " +
			                      "FROM OPERADOR O, VEHICULO V, DESCUENTO_TAXI DTA, DESCUENTO D " +
			                      "WHERE D.ID=DTA.ID_DESCUENTO and D.ID_OPERADOR=O.ID and DTA.ID_UNIDAD=V.ID");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataListado.Rows.Add();
				dataListado.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataListado.Rows[contador].Cells[1].Value = Convert.ToDateTime(conn.leer["FECHA_TAXI"]).ToShortDateString();
				dataListado.Rows[contador].Cells[2].Value = Convert.ToDateTime(conn.leer["FECHA_PAGO"]).ToShortDateString();
				dataListado.Rows[contador].Cells[3].Value = conn.leer["NUMERO"].ToString();	
				dataListado.Rows[contador].Cells[4].Value = conn.leer["Alias"].ToString();
				dataListado.Rows[contador].Cells[5].Value = conn.leer["EMPRESA"].ToString();
				dataListado.Rows[contador].Cells[6].Value = conn.leer["RUTA"].ToString();
				dataListado.Rows[contador].Cells[7].Value = conn.leer["TURNO"].ToString();	
				dataListado.Rows[contador].Cells[8].Value = conn.leer["IMPORTE_TAXI"].ToString();
				dataListado.Rows[contador].Cells[9].Value = conn.leer["IMPORTE_TOTAL"].ToString();
				dataListado.Rows[contador].Cells[10].Value = conn.leer["ESTADO"].ToString();
				dataListado.Rows[contador].Cells[12].Value = conn.leer["ID_DESC"].ToString();				
				++contador;
			}
			conn.conexion.Close();
			
			contador = 0;
			dataInvestigar.Rows.Clear();
			dataInvestigar.ClearSelection();
			conn.getAbrirConexion("select DTA.ID, O.Alias, V.NUMERO, DTA.FECHA_PAGO, DTA.FECHA_TAXI, DTA.EMPRESA, DTA.RUTA, DTA.TURNO, DTA.IMPORTE_TAXI, DTA.ESTADO, D.IMPORTE_TOTAL, D.ID AS ID_DESC " +
			                      "FROM OPERADOR O, VEHICULO V, DESCUENTO_TAXI DTA, DESCUENTO D " +
			                      "WHERE D.ID=DTA.ID_DESCUENTO and D.ID_OPERADOR=O.ID and DTA.ID_UNIDAD=V.ID AND DTA.ESTADO='INVESTIGAR'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataInvestigar.Rows.Add();
				dataInvestigar.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataInvestigar.Rows[contador].Cells[1].Value = Convert.ToDateTime(conn.leer["FECHA_PAGO"]).ToShortDateString();
				dataInvestigar.Rows[contador].Cells[2].Value = conn.leer["NUMERO"].ToString();	
				dataInvestigar.Rows[contador].Cells[3].Value = conn.leer["Alias"].ToString();
				dataInvestigar.Rows[contador].Cells[4].Value = conn.leer["EMPRESA"].ToString();
				dataInvestigar.Rows[contador].Cells[5].Value = conn.leer["RUTA"].ToString();
				dataInvestigar.Rows[contador].Cells[6].Value = conn.leer["TURNO"].ToString();	
				dataInvestigar.Rows[contador].Cells[7].Value = conn.leer["IMPORTE_TAXI"].ToString();
				dataInvestigar.Rows[contador].Cells[10].Value = conn.leer["ID_DESC"].ToString();
				++contador;
			}
			conn.conexion.Close();
			
			contador = 0;
			dataCobrar.Rows.Clear();
			dataCobrar.ClearSelection();
			conn.getAbrirConexion("select DTA.ID, O.Alias, V.NUMERO, DTA.FECHA_PAGO, DTA.FECHA_TAXI, DTA.EMPRESA, DTA.RUTA, DTA.TURNO, DTA.IMPORTE_TAXI, DTA.ESTADO, D.IMPORTE_TOTAL, D.ID AS ID_DESC, DTA.ESTADO " +
			                      "FROM OPERADOR O, VEHICULO V, DESCUENTO_TAXI DTA, DESCUENTO D " +
			                      "WHERE D.ID=DTA.ID_DESCUENTO and D.ID_OPERADOR=O.ID and DTA.ID_UNIDAD=V.ID AND (DTA.ESTADO='COBRABLE' OR DTA.ESTADO='INCOBRABLE')");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataCobrar.Rows.Add();
				dataCobrar.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataCobrar.Rows[contador].Cells[1].Value = Convert.ToDateTime(conn.leer["FECHA_TAXI"]).ToShortDateString();
				dataCobrar.Rows[contador].Cells[2].Value = Convert.ToDateTime(conn.leer["FECHA_PAGO"]).ToShortDateString();
				dataCobrar.Rows[contador].Cells[3].Value = conn.leer["NUMERO"].ToString();	
				dataCobrar.Rows[contador].Cells[4].Value = conn.leer["Alias"].ToString();
				dataCobrar.Rows[contador].Cells[5].Value = conn.leer["EMPRESA"].ToString();
				dataCobrar.Rows[contador].Cells[6].Value = conn.leer["RUTA"].ToString();
				dataCobrar.Rows[contador].Cells[7].Value = conn.leer["TURNO"].ToString();	
				dataCobrar.Rows[contador].Cells[8].Value = conn.leer["IMPORTE_TAXI"].ToString();	
				dataCobrar.Rows[contador].Cells[10].Value = conn.leer["ID_DESC"].ToString();
				dataCobrar.Rows[contador].Cells[11].Value = conn.leer["ESTADO"].ToString();
				for(int s=0; s<dataCobrar.ColumnCount; s++)
				{
					if(dataCobrar.Rows[contador].Cells[11].Value.ToString()=="Incobrable")
						dataCobrar.Rows[contador].Cells[s].Style.BackColor = Color.Gainsboro;
				}
				++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region NIVEL
		void Nivel()
		{
			if(principal.lblDatoNivel.Text!="GERENCIAL" && principal.lblDatoNivel.Text!="NOMINA" && principal.lblDatoNivel.Text!="MASTER")
			{
				tabTaxis.TabPages.Remove(tabCobrables);
				tabTaxis.TabPages.Remove(tabInvestigar);
				gpDatos.Visible = false;
			}
			if(principal.lblDatoNivel.Text=="COMBUSTIBLE")
			{
				tabTaxis.TabPages.Add(tabInvestigar);
			}
		}
		#endregion
	}
}
