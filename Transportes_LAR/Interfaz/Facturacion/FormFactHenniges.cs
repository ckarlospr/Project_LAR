using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Facturacion
{
	public partial class FormFactHenniges : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Facturacion.SQL_Facturacion connF= new Conexion_Servidor.Facturacion.SQL_Facturacion();
		Interfaz.FormPrincipal principal=null;
		#endregion
		
		#region VARIABLE
		int id_fact = 0;
		#endregion
		
		#region CONSTRUCTOR
		public FormFactHenniges(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			this.principal=principal;
		}
		#endregion
		
		#region BOTONES
		void BtnModificarClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Facturacion.SQL_Facturacion().ActualizarRutasHenniges(id_fact.ToString(), txtNombre.Text, cmbServicio.Text, txtImporte.Text, cmbTipo.Text, cmbTurno.Text);
			Adaptador();
		}
		
		void BtnInsertarClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Facturacion.SQL_Facturacion().AgregarRutasHenniges(txtNombre.Text, cmbServicio.Text, txtImporte.Text, cmbTipo.Text, cmbTurno.Text, cmbCliente.Text);
			Adaptador();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Double costo = 0;
			if(txtAumento.Text.Length >= 0){
				DialogResult boton1 = MessageBox.Show("Seguro que quieres cambiar el costo de todas las rutas de la empresa "+cmbCliente.Text, "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					for(int x=0; x<dtFactHennieges.Rows.Count; x++)
					{
						costo = ((Convert.ToDouble(dtFactHennieges[3,x].Value)* Convert.ToDouble(txtAumento.Text) ) / 100 ) + Convert.ToDouble(dtFactHennieges[3,x].Value);
						connF.Auditoria(dtFactHennieges[0,x].Value.ToString(), dtFactHennieges[3,x].Value.ToString(), costo, this.principal.idUsuario);
						try{						
								String consul = "update FACT_HENNIEGES set COSTO ="+costo+" where CLIENTE = '"+cmbCliente.Text+"' and ID = "+dtFactHennieges[0,x].Value.ToString();
								conn.getAbrirConexion(consul); 
								conn.comando.ExecuteNonQuery(); 
								conn.conexion.Close();							
						}catch(Exception){
							
						}					
					}
					Adaptador();
					txtAumento.Enabled = false;		
				}
			}else{
				DialogResult boton1 = MessageBox.Show("Ingresa el porcentaje para el aumento", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
			
		}
		
			void Button2Click(object sender, EventArgs e)
		{
			Double costo = 0;
			if(txtAumento.Text.Length >= 0){
				DialogResult boton1 = MessageBox.Show("Seguro que quieres cambiar el costo de todas las rutas de la empresa "+cmbCliente.Text, "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					for(int x=0; x<dtFactHennieges.Rows.Count; x++)
					{
						costo = (Convert.ToDouble(dtFactHennieges[3,x].Value) - (Convert.ToDouble(dtFactHennieges[3,x].Value) * Convert.ToDouble(txtdecremento.Text) ) / 100 );
						connF.Auditoria(dtFactHennieges[0,x].Value.ToString(), dtFactHennieges[3,x].Value.ToString(), costo, this.principal.idUsuario);
						try{						
								String consul = "update FACT_HENNIEGES set COSTO ="+costo+" where CLIENTE = '"+cmbCliente.Text+"' and ID = "+dtFactHennieges[0,x].Value.ToString();
								conn.getAbrirConexion(consul); 
								conn.comando.ExecuteNonQuery(); 
								conn.conexion.Close();							
						}catch(Exception){
							
						}					
					}
					Adaptador();
					txtdecremento.Enabled = false;		
				}
			}else{
				DialogResult boton1 = MessageBox.Show("Ingresa el porcentaje para el aumento", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			}
		}
		
		#endregion
		
		/*
		 select O.id_operacion, O.fecha, O.turno, R.HoraInicio, R.Sentido, R.Nombre, OP.Alias, OE.NOMBRE emp, V.Numero, R.kilometros, RV.FECHA_REG
			from ORDEN_EMPRESAS OE, OPERACION O, OPERACION_OPERADOR OO, OPERADOR OP, RUTA R, Cliente C, VEHICULO V, TURNOS T, REVISION_VIAJES RV
			where T.NOMBRE=O.turno and V.ID=OO.id_vehiculo and OE.ID=C.ID_ORDEN and O.id_operacion=OO.id_operacion 
			and OO.id_operador=OP.ID and O.id_ruta=R.ID and O.estatus='1' and R.IdSubEmpresa=C.ID and RV.ID_O = O.id_operacion AND O.fecha 
			between '"+FechaInicio+"' and '"+FechaFin+"' and V.Numero like '%"+txtUnidadValidacion.Text+"%' order by O.fecha, T.ORDEN, R.nombre
					 * */
		#region EVENTOS -DATAGRIDVIEW
		void DtFactHenniegesCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex>-1&&dtFactHennieges.RowCount>0)
			{
				id_fact = Convert.ToInt32(dtFactHennieges.Rows[e.RowIndex].Cells[0].Value);
				if(dtFactHennieges.Rows[e.RowIndex].Cells[1].Value!=null)
					txtNombre.Text = dtFactHennieges.Rows[e.RowIndex].Cells[1].Value.ToString();
				if(dtFactHennieges.Rows[e.RowIndex].Cells[2].Value!=null)
					cmbServicio.Text = dtFactHennieges.Rows[e.RowIndex].Cells[2].Value.ToString();
				if(dtFactHennieges.Rows[e.RowIndex].Cells[3].Value!=null)
					txtImporte.Text = dtFactHennieges.Rows[e.RowIndex].Cells[3].Value.ToString();
				if(dtFactHennieges.Rows[e.RowIndex].Cells[4].Value!=null)
					cmbTipo.Text = dtFactHennieges.Rows[e.RowIndex].Cells[4].Value.ToString();
				if(dtFactHennieges.Rows[e.RowIndex].Cells[5].Value!=null)
					cmbTurno.Text = dtFactHennieges.Rows[e.RowIndex].Cells[5].Value.ToString();
			}
		}
		
		void DtFactHenniegesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 6 && e.RowIndex >= 0)
  			{
				new Conexion_Servidor.Facturacion.SQL_Facturacion().EliminarRutasHenniges(id_fact.ToString());
				Adaptador();
			}
		}
		
		void DtFactHenniegesCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			/*if (e.ColumnIndex == 6 && e.RowIndex >= 0)
  			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
		        DataGridViewButtonCell celBoton = this.dtFactHennieges.Rows[e.RowIndex].Cells[6] as DataGridViewButtonCell;
		        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
		        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+2, e.CellBounds.Top+3);
      		    e.Handled = true;
			}*/
		}
		#endregion
		
		#region INICIO - CERRADO
		void FormFactHennigesLoad(object sender, EventArgs e)
		{
			Adaptador();
			txtNombre.AutoCompleteCustomSource = auto.AutocompleteRuta("");
			txtNombre.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.txtAumento.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		
		void FormFactHennigesFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.Facturahnn = false;
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador()
		{
			int contador = 0;
			dtFactHennieges.Rows.Clear();
			dtFactHennieges.ClearSelection();
			
			conn.getAbrirConexion("select * from FACT_HENNIEGES WHERE CLIENTE='"+cmbCliente.Text+"' order by Nombre, tipo, servicio ");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dtFactHennieges.Rows.Add();
				dtFactHennieges.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dtFactHennieges.Rows[contador].Cells[1].Value = conn.leer["NOMBRE"].ToString();
				dtFactHennieges.Rows[contador].Cells[2].Value = conn.leer["SERVICIO"].ToString();
				dtFactHennieges.Rows[contador].Cells[3].Value = conn.leer["COSTO"].ToString();
				dtFactHennieges.Rows[contador].Cells[4].Value = conn.leer["TIPO"].ToString();
				dtFactHennieges.Rows[contador].Cells[5].Value = conn.leer["Turno"].ToString();
				dtFactHennieges.Rows[contador].Cells[6].Value = "Eliminar";
				++contador;
			}
			conn.conexion.Close();
			
			Colores();
		}
		#endregion
		
		#region EVENTO COMBOBOX
		void CmbTipoSelectedValueChanged(object sender, EventArgs e)
		{
			if(cmbTipo.Text=="ESP")
			{
				cmbTurno.Text = "NA";
				cmbServicio.Text = "NA";
			}
		}
		#endregion
		
		#region SELECT TAB
		void CmbClienteSelectedIndexChanged(object sender, EventArgs e)
		{			
			Adaptador();
		}
		#endregion
		
		#region COLORES
		void Colores()
		{
			for(int x=0; x<dtFactHennieges.Rows.Count; x++)
			{
				for(int y=0; y<dtFactHennieges.ColumnCount-1; y++)
				{
					if(x%2==0)
						dtFactHennieges.Rows[x].Cells[y].Style.BackColor = Color.Gainsboro;
					else
						dtFactHennieges.Rows[x].Cells[y].Style.BackColor = Color.White;
				}
			}
		}
		
		void DtFactHenniegesEnter(object sender, EventArgs e)
		{
			Colores();
		}
		
		void DtFactHenniegesColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Colores();
		}
		#endregion
		
		#region EVENTO DE TEXTBOX		
		void TxtAumentoClick(object sender, EventArgs e)
		{
			txtAumento.Enabled = true;	
		}
		#endregion
	
		#region EVENTOS LABEL´s	
		void Label2DoubleClick(object sender, EventArgs e)
		{
			txtAumento.Enabled = true;
		}
		
		void Label3DoubleClick(object sender, EventArgs e)
		{
			txtdecremento.Enabled = true;
		}
		#endregion
	}
}
