using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Anticipos
{
	public partial class FormPrestamoTotalizado : Form
	{
		#region VARIABLES
		DataGridView data1 = new DataGridView();
		DateTime FechaInicio;
		DateTime FechaCorte;
		String id_op;
		String id_descuento;
		int Row = 0;
		#endregion
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		Interfaz.Nomina.Anticipos.FormPrincAnticipos anticipos = new Interfaz.Nomina.Anticipos.FormPrincAnticipos();
		#endregion
		
		#region CONSTRUCTOR
		public FormPrestamoTotalizado(String Nombre, DataGridView data2, DateTime Fechainicio, DateTime Fechacorte, String id_ope, 
		                              Interfaz.FormPrincipal principal, Interfaz.Nomina.Anticipos.FormPrincAnticipos formAnticipos, 
		                              int row)
		{
			InitializeComponent();
			lblAlias.Text = Nombre;
			this.data1 = data2;
			this.FechaInicio = Fechainicio;
			this.FechaCorte = Fechacorte;
			this.id_op = id_ope;
			this.principal=principal;
			this.anticipos=formAnticipos;
			this.Row = row;
		}
		#endregion
		
		#region BOTONES
		void BtnAnticiposClick(object sender, EventArgs e)
		{
			Totalizar();
			GuardarDescuentos();
			GuardarHistorialTotalizado();
			anticipos.AdaptadorDatosPrincipal(Row);
			anticipos.AdaptadorDescuentoQuincenal(Row);
		}
		#endregion
		
		#region PAGOS
		void TxtDescNominalTextChanged(object sender, EventArgs e)
		{
			String Descripcion = "";
			if(txtDescNominal.Text.Contains(".")==true)
					Proceso.ValidarCampo.punto = true;
				else
					Proceso.ValidarCampo.punto = false;
				
			if(txtDescNominal.Text!=""&&txtImporteNo.Text!="")
			{
				if ((Convert.ToDouble(txtDescNominal.Text))>(Convert.ToDouble(txtImporteNo.Text)))
				{
	               txtDescNominal.Text= "0";
	               dataAnticipos.Rows.Clear();
	               MessageBox.Show("Numero mayor al de importe", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            }
				else
				{
					Descripcion =  "PRESTAMO";
					try
					{
						anticipos.AdaptadorPagos(dataAnticipos, txtImporteNo, txtDescNominal, Descripcion.Substring(0,3));
						if((Convert.ToDouble(txtDescNominal.Text))>0)
							anticipos.ContabilizadorPagos(dataAnticipos, dataDetallePrestamos);
						}
					catch
					{
						 MessageBox.Show("Selecciona el tipo de descuento", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
		}
		#endregion
		
		#region INICIO
		void FormPrestamoTotalizadoLoad(object sender, EventArgs e)
		{
			int contador = 0;
			int contador2 = 0;
			Validar(this);
			for(int m=0; m<data1.Rows.Count; m++)
			{
				if(data1.Rows[m].Cells[4].Value.ToString()=="1")
					{
						conn.getAbrirConexion("select DT.ID, DT.ID_DESCUENTO, DT.FECHA, DT.NOMENCLATURA, D.DESCRIPCION, DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               //"and (D.DESCRIPCION like '%TAXI%' OR D.DESCRIPCION like '%COMBUSTIBLE%' OR D.DESCRIPCION like '%PRESTAMO%' OR D.DESCRIPCION like '%CHOQUE%') " +
	                               "and DT.FECHA>='"+FechaInicio.AddDays(1).ToString("yyyy/MM/dd")+"' " +
	                               "and DT.ID_DESCUENTO="+data1.Rows[m].Cells[0].Value.ToString()+" and D.ID_OPERADOR="+id_op+" " +
	                               "order by DT.FECHA");
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
								dataPrestamos1.Rows.Add();
								dataPrestamos1.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
								dataPrestamos1.Rows[contador].Cells[1].Value = conn.leer["ID_DESCUENTO"].ToString();
								dataPrestamos1.Rows[contador].Cells[2].Value = conn.leer["FECHA"].ToString().Substring(0,10);
								dataPrestamos1.Rows[contador].Cells[3].Value = conn.leer["NOMENCLATURA"].ToString();
								dataPrestamos1.Rows[contador].Cells[4].Value = conn.leer["IMPORTE"].ToString();
								++contador;
						}
						conn.conexion.Close();
						
						conn.getAbrirConexion("select DT.ID, DT.ID_DESCUENTO, DT.FECHA, DT.NOMENCLATURA, D.DESCRIPCION, DT.IMPORTE "+
	                               "from DESCUENTO D, DESCUENTO_DETALLE DT, OPERADOR O "+
	                               "where D.ID=DT.ID_DESCUENTO AND O.ID=D.ID_OPERADOR "+
	                               //"and (D.DESCRIPCION like '%PRESTAMO%' OR D.DESCRIPCION like '%CHOQUE%') " +
	                               "and DT.FECHA<'"+FechaInicio.AddDays(1).ToString("yyyy/MM/dd")+"' " +
	                               "and DT.ID_DESCUENTO="+data1.Rows[m].Cells[0].Value.ToString()+" and D.ID_OPERADOR="+id_op+" " +
	                               "order by DT.FECHA");
						conn.leer=conn.comando.ExecuteReader();
						while(conn.leer.Read())
						{
								dataPrestamos2.Rows.Add();
								dataPrestamos2.Rows[contador2].Cells[0].Value = conn.leer["ID"].ToString();
								dataPrestamos2.Rows[contador2].Cells[1].Value = conn.leer["ID_DESCUENTO"].ToString();
								dataPrestamos2.Rows[contador2].Cells[2].Value = conn.leer["FECHA"].ToString().Substring(0,10);
								dataPrestamos2.Rows[contador2].Cells[3].Value = conn.leer["NOMENCLATURA"].ToString();
								dataPrestamos2.Rows[contador2].Cells[4].Value = conn.leer["IMPORTE"].ToString();
								++contador2;
						}
						conn.conexion.Close();
					}
			}
			SumaPagosNoEfectuados();
			SumaPagosEfectuados();
			try
			{
			txtTotal.Text = ((Convert.ToDouble(txtImporteSi.Text))+(Convert.ToDouble(txtImporteNo.Text))).ToString();
			}
			catch
			{
			txtTotal.Text = "0.0";	
			}
		}
		#endregion
		
		#region VALIDAR
		void Validar(Interfaz.Nomina.Anticipos.FormPrestamoTotalizado formPrestamoTotalizado)
		{
			formPrestamoTotalizado.txtDescNominal.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		#region CANTIDAD DE PAGOS
		void SumaPagosNoEfectuados()
		{
			double sumaNoEfectuados=0.0;
			for(int m=0; m<dataPrestamos1.Rows.Count; m++)
			{
				sumaNoEfectuados = sumaNoEfectuados + (Convert.ToDouble(dataPrestamos1.Rows[m].Cells[4].Value));
				txtImporteNo.Text = sumaNoEfectuados.ToString();
			}
		}
		
		void SumaPagosEfectuados()
		{
			double sumaEfectuados=0.0;
			for(int m=0; m<dataPrestamos2.Rows.Count; m++)
			{
				sumaEfectuados = sumaEfectuados + (Convert.ToDouble(dataPrestamos2.Rows[m].Cells[4].Value));
				txtImporteSi.Text = sumaEfectuados.ToString();
			}
		}
		#endregion
		
		#region TOTALIZAR
		void Totalizar()
		{
			for(int m=0; m<dataPrestamos1.Rows.Count; m++)
			{
				new Conexion_Servidor.Anticipos.SQL_Anticipos().ActualizarTotalizadoDescuento(dataPrestamos1.Rows[m].Cells[0].Value.ToString());
			}
			
			for(int z=0; z<dataPrestamos2.Rows.Count; z++)
			{
				new Conexion_Servidor.Anticipos.SQL_Anticipos().ActualizarTotalizadoDescuento(dataPrestamos2.Rows[z].Cells[0].Value.ToString());
			}
		}
		#endregion
		
		#region GUARDAR DESCUENTO
		void GuardarDescuentos()
		{
				id_descuento="";
				if(txtTotal.Text!="" && txtDescNominal.Text!="")
				{
					if((Convert.ToDouble(txtImporteNo.Text)>0) && (Convert.ToDouble(txtDescNominal.Text)>0))
					{
						Name = "A";
						
						new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuento((Convert.ToInt32(id_op)), "PRESTAMO - DEUDA TOTAL", Name, (Convert.ToDouble(txtImporteNo.Text)), principal.idUsuario, "Descuento Nominal Totalizado");
						this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
						for(int contador = 0; contador<dataAnticipos.RowCount; contador++)
							new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarDescuentoDetalle(this.id_descuento, dataAnticipos.Rows[contador].Cells[2].Value.ToString(), dataAnticipos.Rows[contador].Cells[3].Value.ToString(), (Convert.ToDouble(dataAnticipos.Rows[contador].Cells[4].Value)));
						
						dataAnticipos.Rows.Clear();
						dataDetallePrestamos.Rows.Clear();
						anticipos.AdaptadorDatosPrincipal(Row);
						anticipos.AdaptadorDescuentoQuincenal(Row);
					}
					else
						MessageBox.Show("No es posible Guardar en 0", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
					MessageBox.Show("Existen Campos sin llenar", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		void GuardarHistorialTotalizado()
		{
			this.id_descuento = new Conexion_Servidor.Anticipos.SQL_Anticipos().MaxID();
			for(int m=0; m<dataPrestamos1.Rows.Count; m++)
			{
				new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarHistorialTotalizado(id_descuento, dataPrestamos1.Rows[m].Cells[1].Value.ToString());
			}
			
			for(int z=0; z<dataPrestamos2.Rows.Count; z++)
			{
				new Conexion_Servidor.Anticipos.SQL_Anticipos().InsertarHistorialTotalizado(id_descuento, dataPrestamos2.Rows[z].Cells[1].Value.ToString());
			}
		}
		#endregion
	}
}
