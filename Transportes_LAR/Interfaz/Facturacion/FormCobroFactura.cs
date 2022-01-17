using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormCobroFactura : Form
	{
		#region VARIABLES
		int contador = 0;
		String Empresa = "";
		String tiporuta = "EXT";
		bool seleccionador = false;
		#endregion
		
		#region INSTANCIAS
		Interfaz.FormPrincipal principal=null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region CONSTRUCTOR
		public FormCobroFactura()
		{
			InitializeComponent();
		}
		
		public FormCobroFactura(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
			conn.getAbrirConexion("Select Distinct(Empresa) As NombreEmpresa from Cliente where Empresa!='Especiales' ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtEmpresa.Rows.Add();
				dtEmpresa.Rows[contador].Cells[0].Value = conn.leer["NombreEmpresa"].ToString();
				++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormCobroFacturaLoad(object sender, EventArgs e)
		{
			cmbTipo.SelectedIndex = 0;
			Validar(this);
		}
		
		void FormCobroFacturaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.costofactura = false;
		}
		#endregion
		
		#region VALIDAR
		void Validar(Interfaz.Facturacion.FormCobroFactura formCobro)
		{
			formCobro.txtccom.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formCobro.txtcsen.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formCobro.txtctacom.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formCobro.txtctasen.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		#endregion
		
		#region FILTROS
		void CkMañanaCheckedChanged(object sender, EventArgs e)
		{
			datagridRuta();
		}
		
		void CkMedioCheckedChanged(object sender, EventArgs e)
		{
			datagridRuta();
		}
		
		void CkVespertinoCheckedChanged(object sender, EventArgs e)
		{
			datagridRuta();
		}
		
		void CkNocturnoCheckedChanged(object sender, EventArgs e)
		{
			datagridRuta();
		}
		
		void CmbTipoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTipo.Text=="Normales")
				tiporuta = "EXT";
			else
				tiporuta = "NRM";
			
			datagridRuta();
		}
		#endregion
		
		#region ADAPTADOR
		void datagridRuta()
		{
			/*String consulta = "Select R.id, R.Nombre, R.Turno " +
							"from Ruta R, Cliente C " +
							"where C.ID=R.IdSubEmpresa and R.Nombre='%"+txtNombreRuta.Text+"%' and C.Empresa='"+Empresa+"' and tipo!='"+tiporuta+"' ";*/
			
			String consulta = "Select R.id, R.Nombre, R.Turno " +
							"from Ruta R, Cliente C " +
							"where C.ID=R.IdSubEmpresa and C.Empresa='"+Empresa+"' and tipo!='"+tiporuta+"' AND R.id in (select R.ID "+
																						                               "from CLIENTE C, RUTA R, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP "+
																						                               "where O.Estatus='1' and C.ID=R.IdSubEmpresa and R.ID=O.id_ruta and O.id_operacion=OO.id_operacion "+
																						                               "and OO.id_operador=OP.ID and C.Empresa!='Especiales' and O.estatus='1' and O.fecha>'01-01-2015' and dia!='10000000') ";
				
			if(ckMañana.Checked==false)
			{
				consulta = consulta+" and Turno!='Mañana' ";
			}
			if(ckMedio.Checked==false)
			{
				consulta = consulta+" and Turno!='Medio día' ";
			}
			if(ckVespertino.Checked==false)
			{
				consulta = consulta+" and Turno!='Vespertino' ";
			}
			if(ckNocturno.Checked==false)
			{
				consulta = consulta+" and Turno!='Nocturno' ";
			}
			
			consulta = consulta+" order by R.Nombre, R.Turno ";
			
			contador = 0;
			dtRuta.Rows.Clear();
			dtRuta.ClearSelection();
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtRuta.Rows.Add();
				dtRuta.Rows[contador].Cells[0].Value = conn.leer["id"].ToString();
				dtRuta.Rows[contador].Cells[1].Value = conn.leer["Nombre"].ToString();
				dtRuta.Rows[contador].Cells[2].Value = conn.leer["Turno"].ToString();
				dtRuta.Rows[contador].Cells[3].Value = false;
				dtRuta.Rows[contador].Cells[4].Value =  new Conexion_Servidor.Facturacion.SQL_Facturacion().getPagoExternoSencillo(conn.leer["ID"].ToString());
				dtRuta.Rows[contador].Cells[5].Value =  new Conexion_Servidor.Facturacion.SQL_Facturacion().getPagoExternoCompleto(conn.leer["ID"].ToString());
				++contador;
			}
			conn.conexion.Close();
			Colores();
		}
		#endregion
		
		#region SELECCION EMPRESA
		void DtEmpresaCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			Empresa = dtEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
			datagridRuta();
		}
		#endregion
		
		#region FALSO - ACTIVO
		void DtRutaColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if(e.ColumnIndex==3)
			{
				if(seleccionador == false)
				{
					for(int a = 0; a<(dtRuta.RowCount); a++)
					{
						dtRuta.Rows[a].Cells[3].Value = true;
						dtRuta.Rows[a].Cells[3].Value = 1;
					}
					seleccionador = true;
				}
				else
				{
					for(int a = 0; a<(dtRuta.RowCount); a++)
					{
						dtRuta.Rows[a].Cells[3].Value = false;
						dtRuta.Rows[a].Cells[3].Value = 0;
					}
					seleccionador = false;
				}
			}
			Colores();
		}
		#endregion
		
		#region EVENTO VALIDADOR
		void TxtccomTextChanged(object sender, EventArgs e)
		{
			if(txtccom.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtcsenTextChanged(object sender, EventArgs e)
		{
			if(txtcsen.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtctacomTextChanged(object sender, EventArgs e)
		{
			if(txtctacom.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtctasenTextChanged(object sender, EventArgs e)
		{
			if(txtctasen.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		#endregion
		
		void BtnPrestamoAdicionalClick(object sender, EventArgs e)
		{
			for(int a = 0; a<(dtRuta.RowCount); a++)
			{
				if(Convert.ToBoolean(dtRuta.Rows[a].Cells[3].Value)==true&&Convert.ToDouble(txtPagoExternoSencillo.Text)>0)
				{
					new Conexion_Servidor.Facturacion.SQL_Facturacion().PagoExterno(dtRuta.Rows[a].Cells[0].Value.ToString(), Convert.ToDouble(txtPagoExternoSencillo.Text), Convert.ToDouble(txtPagoExternoCompleto.Text), principal.idUsuario.ToString(), DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH:mm"));
				}
			}
		}
		
		void Colores()
		{
			for(int x=0; x<dtRuta.Rows.Count; x++)
			{
				for(int y=0; y<dtRuta.ColumnCount; y++)
				{
					if(x%2==0)
						dtRuta.Rows[x].Cells[y].Style.BackColor = Color.Gainsboro;
				}
			}
		}
	}
}
