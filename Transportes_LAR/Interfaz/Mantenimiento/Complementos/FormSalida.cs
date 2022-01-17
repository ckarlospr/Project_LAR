using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormSalida : Form
	{
		#region VARIABLES
		String ID_USUARIO;
		//int contador;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region CONSTRUCTORES
		public FormSalida(String id_u)
		{
			InitializeComponent();
			this.ID_USUARIO=id_u;
		}
		
		public FormSalida()
		{
			InitializeComponent();
		}
		#endregion
		
		#region ADAPTADOR
		/*
		void Adaptador()
		{		
			contador = 0;
			dataSalida.Rows.Clear();
			dataSalida.ClearSelection();
			conn.getAbrirConexion("select spa.ID AS ID_Salida, spa.CANTIDAD, P.MEDICION as MEDICION,  P.PIEZA, P.ESTADO_PIEZA, P.CODIGO_BARRAS, G.NOMBRE AS GRUPO, ot.ID AS ORDEN_TRABAJO, ot.FECHA_ORDEN, o.Nombre AS MECANICO , ti.NOMBRE AS INTERVENCION, v.Numero AS VEHICULO "+
  									"from SALIDA_PRODUCTO_ALMACEN spa , Grupo_Producto G, PRODUCTO_ALMACEN P, ORDEN_TRABAJO ot, OPERADOR o, TIPO_INTERVENCION ti, VEHICULO v "+
   									"WHERE  spa.ID_PRODUCTO = P.ID AND P.ID_GRUPO = G.ID AND spa.ID_ORDENTRABAJO = ot.ID AND ot.ID_VEHICULO = v.ID AND ot.ID_MECANICO = o.ID AND ti.ID = ot.ID_INTERVENCION");
			conn.leer=conn.comando.ExecuteReader();			
			while(conn.leer.Read())
			{
				dataSalida.Rows.Add();
				dataSalida.Rows[contador].Cells[0].Value = conn.leer["ID_Salida"].ToString();				
				dataSalida.Rows[contador].Cells[1].Value = conn.leer["CANTIDAD"].ToString();
				dataSalida.Rows[contador].Cells[2].Value = conn.leer["MEDICION"].ToString();
				dataSalida.Rows[contador].Cells[3].Value = conn.leer["PIEZA"].ToString();
				dataSalida.Rows[contador].Cells[4].Value = conn.leer["ESTADO_PIEZA"].ToString();
				dataSalida.Rows[contador].Cells[5].Value = conn.leer["CODIGO_BARRAS"].ToString();
				dataSalida.Rows[contador].Cells[6].Value = conn.leer["GRUPO"].ToString();
				dataSalida.Rows[contador].Cells[7].Value = conn.leer["ORDEN_TRABAJO"].ToString();
				dataSalida.Rows[contador].Cells[8].Value = conn.leer["FECHA_ORDEN"].ToString();
				dataSalida.Rows[contador].Cells[9].Value = conn.leer["MECANICO"].ToString();
				dataSalida.Rows[contador].Cells[10].Value = conn.leer["INTERVENCION"].ToString();
				dataSalida.Rows[contador].Cells[11].Value = conn.leer["VEHICULO"].ToString();
				++contador;
			}			
			conn.conexion.Close();			
			txtTotalSal.Text = Convert.ToString(contador);
			txtTotalProds.Text = Convert.ToString(new Transportes_LAR.Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().TotalEntradasProds());			
		}
		*/
		#endregion
		
		#region INICIO
		void FormSalidaLoad(object sender, EventArgs e)
		{
			this.Validar(this);
			ColoresAlternadosRows(dataSalida);				
			//Adaptador();
			/**
			txtCodigoBarras.AutoCompleteCustomSource = auto.AutocompleteGeneral("select CODIGO_BARRAS from PRODUCTO_ALMACEN", "CODIGO_BARRAS");
           	txtCodigoBarras.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCodigoBarras.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            txtOrdenTrabajo.AutoCompleteCustomSource = auto.AutocompleteGeneral("select ID from ORDEN_TRABAJO", "ID");
           	txtOrdenTrabajo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOrdenTrabajo.AutoCompleteSource = AutoCompleteSource.CustomSource;      
            
            txtIdProducto.AutoCompleteCustomSource = auto.AutocompleteGeneral("select ID from PRODUCTO_ALMACEN", "ID");
           	txtIdProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtIdProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            */
		}
		#endregion
	
		#region EVENTOS TECLAS		
		void TxtCantidadKeyUp(object sender, KeyEventArgs e)
		{
		if (e.KeyCode == Keys.Enter){
				if(txtOrdenTrabajo.Text.Length > 0){
					if(txtCantidad.Text.Length > 0){
						if(Convert.ToInt32(txtCantidad.Text)>0){
							new Transportes_LAR.Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().InsertarSalida(new Transportes_LAR.Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().RetornaIdProducto("", txtCodigoBarras.Text), txtCantidad.Text, txtOrdenTrabajo.Text, ID_USUARIO);
							LimpiarCampos();
							}else{
								MessageBox.Show("No es posible insertar 0 cantidad", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}else{
							txtCantidad.Focus();
						}	
				}else{
					txtOrdenTrabajo.Focus();
				}							
			}
		}
	
		#endregion
		
		#region VALIDACION CAMPOS
		void Validar(Interfaz.Mantenimiento.Complementos.FormSalida salida)
		{
			salida.txtIdProducto.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			salida.txtCantidad.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}		
		#endregion
		
		#region METODOS
		public void ColoresAlternadosRows(DataGridView datag)
		{
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		public void LimpiarCampos(){
			txtCodigoBarras.Text = "";
			txtOrdenTrabajo.Text = "";
			txtIdProducto.Text = "";
			txtCantidad.Text = "";													
			//Adaptador();
		}
		#endregion		
		
		#region BOTONES
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(txtOrdenTrabajo.Text.Length > 0){
					if(txtCantidad.Text.Length > 0){
						if(Convert.ToInt32(txtCantidad.Text)>0){
							new Transportes_LAR.Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().InsertarSalida(new Transportes_LAR.Conexion_Servidor.Mantenimiento.SQL_Mantenimiento().RetornaIdProducto("", txtCodigoBarras.Text), txtCantidad.Text,  txtOrdenTrabajo.Text, ID_USUARIO);
							LimpiarCampos();
							}else{
								MessageBox.Show("No es posible insertar 0 cantidad", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}else{
							txtCantidad.Focus();
						}	
				}else{
					txtOrdenTrabajo.Focus();
				}						
		}
	
		#endregion
	}
}
