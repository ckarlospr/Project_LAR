using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormPagoCobroEspecial : Form
	{
		#region CONSTRUCTOR
		public FormPagoCobroEspecial(Int32 ID_R, PrivilegiosPagos refPrivi)
		{
			InitializeComponent();
			id_re = ID_R;
			refpagos = refPrivi;
			id_usuario = refpagos.id_usuario;
		}		
		#endregion
		
		#region INSTANCIAS
		public PrivilegiosPagos refpagos;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VARIABLES
		public Int32 id_re;
		string consulta;
		public bool realizado = false;
		public Int32 id_usuario;
		#endregion
		
		#region INICIO - FIN		
		void FormPagoCobroEspecialLoad(object sender, EventArgs e)
		{
			cargarDatos();
		}
		
		void FormPagoCobroEspecialFormClosing(object sender, FormClosingEventArgs e)
		{
			quitaPagado();
		}
		#endregion
		
		#region ADAPTADOR
		public void adaptador(){
			consulta = @"select C.ID_RE, C.INCOBRABLE, C.TIPO, C.COBRO, O.Alias, C.TELEFONO, RE.PRECIO, RE.anticipo, RE.DESTINO, RE.FACTURA, RE.FECHA_SALIDA, C.IDENTIFICADOR, C.FECHA,
					 C.PAGO, C.FACTURA fact, C.BORRADO, C.INCOBRABLE, C.TIPO_VIAJE, V.Numero, C.NUMERO_FACT, C.SALDO, C.ID IDCC, C.OBSERVACIONES, RE.C_CASETAS, 
					 RE.CASETAS, C.ID_OP, RE.OP_COBRA from COBRO_ESPECIAL C, RUTA_ESPECIAL RE, VEHICULO V, OPERADOR O
					  where O.ID = C.ID_OP AND C.ID_VEHICULO = V.ID AND C.ID_RE =RE.ID_RE  and c.ID_RE = "+ id_re;
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgDatos.Rows.Add(conn.leer["IDCC"].ToString(),
				                 conn.leer["TIPO"].ToString(),
				                 conn.leer["Alias"].ToString(),
				                 conn.leer["Numero"].ToString(),
				                 conn.leer["TELEFONO"].ToString(),
				                 conn.leer["SALDO"].ToString(),
				                 conn.leer["DESTINO"].ToString(),
				                 ((conn.leer["PAGO"].ToString()== "1")? "SI": "NO"),
				                 ((conn.leer["FACTURA"].ToString()== "1")? "SI": "NO"),
				                 conn.leer["OBSERVACIONES"].ToString(),
								 ((conn.leer["INCOBRABLE"].ToString()== "0")? conn.leer["TIPO_VIAJE"].ToString(): "INCOBRABLE"));
			}
			conn.conexion.Close();
			formatoTabla();
		}
		#endregion
		
		#region EVENTOS 
		void DgDatosCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{			
			int y = 0;
			double suma = 0;
			for(int x=0; x<dgDatos.Rows.Count; x++){
				if(dgDatos.Rows[x].Selected == true && dgDatos[1,x].Style.BackColor.Name != "LightGreen"){
						suma = suma+Convert.ToDouble(dgDatos[5,x].Value);
						y++;
					}
				}				
			txtCantidad.Text=y.ToString();
			txtTotal.Text=suma.ToString();
		}
		
		void DgDatosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{			
			if(dgDatos.CurrentRow.Index >-1 && dgDatos.CurrentCell.ColumnIndex <= 10 && dgDatos.CurrentCell.ColumnIndex != 5)
			{
				Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial formDatos = new Transportes_LAR.Interfaz.Operaciones.FormDatosEspecial(null, Convert.ToInt64(id_re));
				formDatos.FormBorderStyle = FormBorderStyle.FixedSingle;
				formDatos.ShowDialog();
			}
		}
		
		void DgDatosCellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
			int y = 0;
			double suma = 0;
			for(int x=0; x<dgDatos.Rows.Count; x++){
				if(dgDatos.Rows[x].Selected == true && dgDatos[1,x].Style.BackColor.Name != "LightGreen"){
						suma=suma+Convert.ToDouble(dgDatos[5,x].Value);
						y++;
					}
				}
			txtCantidad.Text=y.ToString();
			txtTotal.Text=suma.ToString();
		}
		#endregion
				
		#region METODOS
		public void cargarDatos(){
			try{
				txtCliente.Text = refpagos.dgRelacion[4, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
				txtContacto.Text = refpagos.dgRelacion[3, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
				txtSalida.Text = refpagos.dgRelacion[6, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
				txtRegreso.Text = refpagos.dgRelacion[7, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
				txtDestino.Text = refpagos.dgRelacion[5, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
				txtCU.Text = refpagos.dgRelacion[8, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();		
				txtRazonSocial.Text = refpagos.dgRelacion[11, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
				txtCotizado.Text = refpagos.dgRelacion[9, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();			
				txtPrecioP.Text = refpagos.dgRelacion[12, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();
				txtAnticipo.Text = (Convert.ToDouble(refpagos.dgRelacion[13, refpagos.dgRelacion.CurrentRow.Index].Value) 
				                    + Convert.ToDouble(refpagos.dgRelacion[14, refpagos.dgRelacion.CurrentRow.Index].Value)).ToString();		
				txtSaldo.Text = refpagos.dgRelacion[15, refpagos.dgRelacion.CurrentRow.Index].Value.ToString();			
				
				if(refpagos.dgRelacion[0, refpagos.dgRelacion.CurrentRow.Index].Style.BackColor.Name == "LightGreen"){
					txtestatusS.Text = "PAGADO";
					txtestatusS.BackColor = Color.LightGreen;
				}else{
					txtestatusS.Text = "PENDIENTE";
					txtestatusS.BackColor = Color.LightGray;
				}
				consulta = @"SELECT cs.Telefono, re.tipoVehiculo, re.CORREO FROM ContactoServicio cs, RUTA_ESPECIAL re WHERE cs.IdCliente = re.ID_C and ID_RE = "+ id_re;			
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){			
					txtVehiculo.Text = conn.leer["tipoVehiculo"].ToString();
					txttelefono.Text = conn.leer["Telefono"].ToString();
					txtCorreo.Text = conn.leer["CORREO"].ToString();
				}
				conn.conexion.Close();
				adaptador();
			}catch(Exception ex){
				MessageBox.Show("Error al obtener los datos :"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void formatoTabla(){
			for(int x = 0; x<dgDatos.Rows.Count ; x++){
				if(dgDatos[7,x].Value.ToString() == "SI"){
					for(int y = 0; y<dgDatos.Columns.Count; y++)
						dgDatos[y,x].Style.BackColor = Color.LightGreen;
				}
				if(dgDatos[10,x].Value.ToString() == "C. PUNTO")
					dgDatos[10,x].Style.BackColor = Color.Red;
				
				
				if(dgDatos[10,x].Value.ToString() == "INCOBRABLE"){					
					dgDatos[10,x].Style.BackColor = Color.Yellow;
					dgDatos[7,x].Value = "SI";
					for(int y = 0; y<dgDatos.Columns.Count; y++)
						dgDatos[y,x].Style.BackColor = Color.LightGreen;
				}
			}
			dgDatos.ClearSelection();
		}
		
		public bool ValidaPago(){
			bool respuesta = true;
			for(int x = 0; x<dgDatos.Rows.Count; x++){
				if(dgDatos[2,x].Selected == true && dgDatos[7,x].Value.ToString() == "SI"){
					respuesta = false;
					x = dgDatos.Rows.Count - 1;
				}
			}
			return respuesta;
		}
		
		public void quitaPagado(){
			bool respuesta = true;
			for(int x = 0; x<dgDatos.Rows.Count ; x++){
				if(dgDatos[7,x].Value.ToString() == "NO")
					respuesta = false;
			}
			
			if(refpagos.dgRelacion[2, refpagos.dgRelacion.CurrentRow.Index].Value.ToString().Contains("Incobrable") || refpagos.dgRelacion[2, refpagos.dgRelacion.CurrentRow.Index].Value.ToString().Contains("INCOBRABLE"))
				respuesta = false;			
				
			refpagos.dgRelacion[15,refpagos.dgRelacion.CurrentRow.Index].Value = (Convert.ToDouble(refpagos.dgRelacion[12,refpagos.dgRelacion.CurrentRow.Index].Value) - 
				(Convert.ToDouble(refpagos.dgRelacion[13,refpagos.dgRelacion.CurrentRow.Index].Value) + Convert.ToDouble(refpagos.dgRelacion[14,refpagos.dgRelacion.CurrentRow.Index].Value))).ToString();
			
			if(respuesta && refpagos.dgRelacion[2, refpagos.dgRelacion.CurrentRow.Index].Style.BackColor.Name != "LightGreen" && (refpagos.dgRelacion[15,refpagos.dgRelacion.CurrentRow.Index].Value.ToString() == "0" || refpagos.dgRelacion[15,refpagos.dgRelacion.CurrentRow.Index].Value.ToString() == "0.0") ){
				DialogResult rs = MessageBox.Show("Se ha pagado todos los vehiculos ¿Deseas poner como pagado el servicio?", "Alerta Servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes == rs){
					refpagos.pagarServicio();
				}
			}
		}
		
		private bool validaModificacionTipo(){
			bool respuesta = true;
			for(int x=0; x<dgDatos.Rows.Count; x++){
				if(dgDatos[1,x].Style.BackColor.Name == "LightGreen")
					respuesta = false;
			}			
			return respuesta;
		}
		#endregion
				
		#region BOTONES		
		void LblAgregarAnticipoClick(object sender, EventArgs e)
		{
			if(txtSaldo.Text != "0" && txtSaldo.Text != "0.0" && txtSaldo.Text != "0.00")
				new FormNuevoAnticipo(this,id_usuario,id_re).ShowDialog();
		}
				
		void BtnPagoClick(object sender, EventArgs e)
		{
			if(dgDatos.SelectedRows.Count > 0 && ValidaPago()){
				new FormPagos(this).ShowDialog();
				if(realizado == true){
					for(int x=0; x<dgDatos.Rows.Count; x++){
						if(dgDatos[2,x].Selected == true && dgDatos[7,x].Value.ToString() == "NO"){
							dgDatos[7,x].Value = "SI";
							for(int y = 0; y<dgDatos.Columns.Count; y++)
								dgDatos[y,x].Style.BackColor = Color.LightGreen;
							try{
								conn.getAbrirConexion("INSERT INTO AUDITA_COBRO_ESP VALUES ('"+dgDatos[0,x].Value.ToString()+"', 'PAGADO', 'N/A', '"+id_usuario+"', (SELECT CONVERT (DATE, SYSDATETIME())), (SELECT CONVERT (TIME, SYSDATETIME())))");
								conn.comando.ExecuteNonQuery();
								conn.conexion.Close();
								MessageBox.Show("El vehiculo : "+dgDatos[3,x].Value.ToString()+" se ha pagado corretamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);						
							}catch(Exception ex){
								MessageBox.Show("Error al hacer auditoria, esto no afecta en pago realizado : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}		
						}
					}					
				txtSaldo.Text = (Convert.ToDouble(txtPrecioP.Text) -  Convert.ToDouble(txtAnticipo.Text)).ToString();
				}
				realizado = false;
			}else{
				MessageBox.Show("Selecciona un registro valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		#endregion			
		
		#region EVENTOS
		void DgDatosCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{			
			if(e.Button == MouseButtons.Right  && e.RowIndex != -1 && e.RowIndex<dgDatos.Rows.Count && e.ColumnIndex==5){
				//if(dgDatos.SelectedRows.Count == 1 && dgDatos[1, e.RowIndex].Style.BackColor.Name != "LightGreen")
					new FormCambioPrecioVehiculo(this).ShowDialog();
				//else
					//MessageBox.Show("Selecciona un registro valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
			if(e.Button == MouseButtons.Right  && e.RowIndex != -1 && e.ColumnIndex == 1){
				if(dgDatos.SelectedRows.Count > 0 && validaModificacionTipo())
					new FormModificarTipoP(this, id_usuario).ShowDialog();
				else
					MessageBox.Show("Selecciona registros validos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion
	}
}
