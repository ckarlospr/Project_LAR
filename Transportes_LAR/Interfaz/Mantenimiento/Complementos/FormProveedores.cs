using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Transportes_LAR.Interfaz.Mantenimiento.Complementos
{
	public partial class FormProveedores : Form
	{
		
		#region VARIABLES
			int id = 0 ;
			String busqueda = "";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Proceso.ValidarCampo valida = new Transportes_LAR.Proceso.ValidarCampo();
		private Conexion_Servidor.Mantenimiento.SQL_Mantenimiento sqlmant = new Conexion_Servidor.Mantenimiento.SQL_Mantenimiento();
		#endregion
		
		#region INICIO
		void FormProveedoresLoad(object sender, EventArgs e)
		{
			ImplementaToolTip();
			ColoresAlternadosRows(dataProveedores);
			Adaptador(busqueda);
			this.Validar(this);
			txtBuscarComo.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Nombre from PROVEEDOR_ALMACEN", "Nombre");
           	txtBuscarComo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarComo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            btnModificar.Enabled = false;
            cmbBuscarPor.Text = "Clave";
		}
		#endregion
		
		#region CONSTRUCTORES
		public FormProveedores()
		{
			InitializeComponent();
		}
		#endregion
		
		#region BOTONES
		void BtnNuevoClick(object sender, EventArgs e)
		{
			limpirarcampos();
			this.Validar(this);
			btnModificar.Enabled = false;
			btnAgregar.Enabled = true;
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(txtClave.Text!="" && txtNombre.Text!="" && cmbClase.Text!="" && txtTelefono.Text!="" && txtDireccion.Text!="" && email_bien_escrito(txtEmail.Text) && ValidarRFC(txtRFC.Text) != 1)
			{	
				sqlmant.InsertarProveedores(txtClave.Text, txtNombre.Text, txtNombreCom.Text, txtAtencion.Text, txtPlazoCredito.Text, cmbClase.Text, txtTelefono.Text, txtContacto.Text, txtDireccion.Text, txtRFC.Text, txtDescripcion.Text, txtEmail.Text);
				limpirarcampos();
				Adaptador(busqueda);			
			}
			else
			{
				MessageBox.Show("Llena todos los campos", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);				
			}
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if(txtClave.Text!="" && txtNombre.Text!="" && cmbClase.Text!="" && txtTelefono.Text!="" && txtDireccion.Text!="" && email_bien_escrito(txtEmail.Text) && ValidarRFC(txtRFC.Text) != 1)
			{
				sqlmant.ActualizarProveedores(id, txtClave.Text, txtNombre.Text, txtNombreCom.Text, txtAtencion.Text, txtPlazoCredito.Text, cmbClase.Text, txtTelefono.Text, txtContacto.Text, txtDireccion.Text, txtRFC.Text, txtDescripcion.Text, txtEmail.Text);
				Adaptador(busqueda);
				limpirarcampos();
				btnModificar.Enabled = false;	
				btnAgregar.Enabled = true;
			}
		}
		#endregion
		
		#region ADAPTADOR
		void Adaptador(String buscar)
		{		
			int cX = 0;
			dataProveedores.Rows.Clear();
			dataProveedores.ClearSelection();
			conn.getAbrirConexion("SELECT * FROM PROVEEDOR_ALMACEN " + buscar + " ORDER BY ESTATUS, ID");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataProveedores.Rows.Add();
				dataProveedores.Rows[cX].Cells[0].Value = conn.leer["ID"].ToString();
				dataProveedores.Rows[cX].Cells[1].Value = conn.leer["Clave"].ToString();
				dataProveedores.Rows[cX].Cells[2].Value = conn.leer["Nombre"].ToString();
				dataProveedores.Rows[cX].Cells[3].Value = conn.leer["NombreCom"].ToString();
				dataProveedores.Rows[cX].Cells[4].Value = conn.leer["Atencion"].ToString();
				dataProveedores.Rows[cX].Cells[5].Value = conn.leer["PlazoCredito"].ToString();
				dataProveedores.Rows[cX].Cells[6].Value = conn.leer["Clase"].ToString();
				dataProveedores.Rows[cX].Cells[7].Value = conn.leer["Telefono"].ToString();
				dataProveedores.Rows[cX].Cells[8].Value = conn.leer["Contacto"].ToString();
				dataProveedores.Rows[cX].Cells[9].Value = conn.leer["Direccion"].ToString();
				dataProveedores.Rows[cX].Cells[10].Value = conn.leer["RFC"].ToString();
				dataProveedores.Rows[cX].Cells[11].Value = conn.leer["Descripcion"].ToString();
				dataProveedores.Rows[cX].Cells[12].Value = conn.leer["Correo"].ToString();
				dataProveedores.Rows[cX].Cells[13].Value = conn.leer["Estatus"].ToString();
				++cX;
				foreach (DataGridViewRow row in dataProveedores.Rows)
				{
					if (Convert.ToString(row.Cells[13].Value) == "Inactivo")
		     		{
		         		row.DefaultCellStyle.BackColor = Color.Gray; 
			     	}
				}
			}
			conn.conexion.Close();
			sqlmant.ConteoProdProv("PROVEEDOR_ALMACEN", "Activo", lbActivos);
			sqlmant.ConteoProdProv("PROVEEDOR_ALMACEN", "Inactivo", lbInactivos);
		}
		#endregion
		
		#region EVENTO PAINTING - CLICK
		
			#region ACTIVAR / DESACTIVAR
			void DataProveedoresCellContentClick(object sender, DataGridViewCellEventArgs e)
			{
				if(e.ColumnIndex == 14 && e.RowIndex >= 0)
	  			{
					sqlmant.DesactivarProveedor(dataProveedores.Rows[e.RowIndex].Cells[0].Value.ToString());
					Adaptador(busqueda);
					limpirarcampos();
				}
				
				if(e.ColumnIndex == 15 && e.RowIndex >= 0)
				{
					sqlmant.ActivarProveedor(dataProveedores.Rows[e.RowIndex].Cells[0].Value.ToString());
					Adaptador(busqueda);
					limpirarcampos();
				}
			}
			#endregion
		
			#region PINTAR CELDAS
			void DataProveedoresCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
			{
				if (e.ColumnIndex == 14 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataProveedores.Rows[e.RowIndex].Cells[14] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\x.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+10, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
				
				if (e.ColumnIndex == 15 && e.RowIndex >= 0)
	  			{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All);
			        DataGridViewButtonCell celBoton = this.dataProveedores.Rows[e.RowIndex].Cells[15] as DataGridViewButtonCell;
			        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\v.ico");
			        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left+10, e.CellBounds.Top+2);
	      		    e.Handled = true;
				}
			}
			#endregion
		
			#region REGISTRO A CAMPOS
			void DataProveedoresCellClick(object sender, DataGridViewCellEventArgs e)
			{
				limpirarcampos();			
				id = Convert.ToInt16(dataProveedores.Rows[e.RowIndex].Cells[0].Value);
				txtClave.Text =  dataProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtNombre.Text = dataProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
				txtNombreCom.Text = dataProveedores.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtAtencion.Text = dataProveedores.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtPlazoCredito.Text = dataProveedores.Rows[e.RowIndex].Cells[5].Value.ToString();
				cmbClase.Text = dataProveedores.Rows[e.RowIndex].Cells[6].Value.ToString();
				txtTelefono.Text = dataProveedores.Rows[e.RowIndex].Cells[7].Value.ToString();
				txtContacto.Text = dataProveedores.Rows[e.RowIndex].Cells[8].Value.ToString();
				txtDireccion.Text = dataProveedores.Rows[e.RowIndex].Cells[9].Value.ToString();
				txtRFC.Text = dataProveedores.Rows[e.RowIndex].Cells[10].Value.ToString();
				txtDescripcion.Text = dataProveedores.Rows[e.RowIndex].Cells[11].Value.ToString();
				txtEmail.Text = dataProveedores.Rows[e.RowIndex].Cells[12].Value.ToString();
				btnAgregar.Enabled = false;
				btnModificar.Enabled = true;
			}
			#endregion
			
		#endregion
		
		#region EVENTO BUSQUEDA
		void TxtNombreBusquedaKeyUp(object sender, KeyEventArgs e)
		{			
			if(txtBuscarComo.Text != "")
			{
				switch(cmbBuscarPor.SelectedIndex)
				{
					case 0:	busqueda = "WHERE Clave LIKE '%" + txtBuscarComo.Text + "%'"; 
							Adaptador(busqueda);
							break;
					case 1: busqueda = "WHERE Nombre LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
					case 2: busqueda = "WHERE NombreCom LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
							case 3: busqueda = "WHERE Atencion LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
					case 4: busqueda = "WHERE PlazoCredito LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
					case 5: busqueda = "WHERE Clase LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
					case 6: busqueda = "WHERE Telefono LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
							case 7: busqueda = "WHERE Contacto LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
					case 8: busqueda = "WHERE Direccion LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
					case 9: busqueda = "WHERE RFC LIKE '%" + txtBuscarComo.Text + "%'";
							Adaptador(busqueda);
							break;
					case 10: busqueda = "WHERE Correo LIKE '%" + txtBuscarComo.Text + "%'";
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
		#endregion	
		
		#region EVENTO CAMBIO INPUT TECLADO
		void CmbBuscarProveedorSelectedIndexChanged(object sender, EventArgs e)
		{
			switch(cmbBuscarPor.SelectedIndex)
			{
			case 0: txtBuscarComo.Text = ""; //Clave
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
					break;
			case 1: txtBuscarComo.Text = ""; //Nombre
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
					break;
			case 2:	txtBuscarComo.Text = ""; //NombreCom
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
					break;
			case 3:	txtBuscarComo.Text = ""; //Atencion
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
					break;	
			case 4: txtBuscarComo.Text = ""; //PlazoCredito
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
					break;
			case 5: txtBuscarComo.Text = ""; //Clase
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
					break;
			case 6: txtBuscarComo.Text = ""; //Telefono
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.paraTelefonos);
					break;
			case 7: txtBuscarComo.Text = ""; //Contacto
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
					break;
			case 8: txtBuscarComo.Text = ""; //Direccion
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyOtros);
					break;
			case 9: txtBuscarComo.Text = ""; //RFC
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
					break;
			case 10: txtBuscarComo.Text = ""; //Email
					this.txtBuscarComo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyOtros);
					break;						
			}			
		}
		#endregion
		
		#region VALIDACION CAMPOS
			void Validar(Interfaz.Mantenimiento.Complementos.FormProveedores proveedor)
			{
				// Clave
				this.txtClave.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
				// Plazo de credito
				this.txtPlazoCredito.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
				// E-mail
				this.txtEmail.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloCaracteresEmail);
				// Telefono
				this.txtTelefono.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.paraTelefonos);
			}
		#endregion
		
		#region METODOS
		
			// Colores Alternados Tabla
			public void ColoresAlternadosRows(DataGridView datag)
			{
				datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
				datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
			}
			
			// Borrar Campos
			void limpirarcampos()
			{
				txtClave.Text = "";
				txtNombre.Text = "";
				txtNombreCom.Text = "";
				txtAtencion.Text = "";
				txtPlazoCredito.Text = "";
				cmbClase.Text = null;
				txtTelefono.Text = "";
				txtContacto.Text = "";
				txtDireccion.Text = "";
				txtRFC.Text = "";
				txtDescripcion.Text = "";
				txtEmail.Text = "";
			}
			
			// Ayuda ToolTip
			private void ImplementaToolTip()
			{
				ToolTip toolTip1 = new ToolTip();
				toolTip1.AutoPopDelay = 5000;
				toolTip1.InitialDelay = 1000;
				toolTip1.ReshowDelay = 500;
				toolTip1.ShowAlways = true;
				toolTip1.SetToolTip(txtRFC, "FORMATO DE RFC\n" +
				                    		"Componentes:\n" +
				                    		"\t* [AP]ellido pat,  [A]pellidoM, [N]ombre\n" +
				                    		"\t* Año, Mes, Dia de nacimiento [AAMMDD]\n" +
				                    		"\t* Homoclave de 3 digitos [XXX]\n" +
				                    		"Estructura:\n" +
				                    		"\tRFC: [AP][A][N][AAMMDD][XXX]\n" +
				                    		"Ejemplo:\n" +
				                    		"\tRFC: ANDS901022H3Z");
			}
			
			public static Boolean email_bien_escrito(String email)
			{
			   String expresion;
			   expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
			   if (Regex.IsMatch(email,expresion))
			   {
			      if (Regex.Replace(email, expresion, String.Empty).Length == 0)
			      {
			         return true;
			      }
			      else
			      {
			         return false;
			      }
			   }
			   else
			   {
			      return false;
			   }
			}
	 	
		 	public static int ValidarRFC(string cadena)
	        {
	            int i = 0;
	            bool confirmacion = true;
	            if (cadena.Length > 11 && cadena.Length < 14)
	            {
	                if (cadena.Length == 12)
	                {
	                    cadena = "-" + cadena;
	                    i = 1;
	                }
	                for (int j = i; j <= 3; j++)
	                {
	                    if (!char.IsLetter(cadena[j]))
	                        confirmacion = false;
	                }
	                for (int j = 4; j <= 9; j++)
	                {
	                    if (!char.IsDigit(cadena[j]))
	                        confirmacion = false;
	                }
	                for (int j = 9; j < 13; j++)
	                {
	                    if (!char.IsLetterOrDigit(cadena[j]))
	                        confirmacion = false;
	                }
	                if (!confirmacion)
	                {
	                    MessageBox.Show("El formato del RFC no es valido.", "RFC", MessageBoxButtons.OK, MessageBoxIcon.Error);
	                    return 1;
	                }
	            }
	            else
	            {
	                MessageBox.Show("La longitud del RFC no es valido.", "RFC", MessageBoxButtons.OK, MessageBoxIcon.Error);
	                return 1;
	            }
	            if (confirmacion)
	                return 0;
	            else
	                return 1;
	        }	 
		#endregion
	}
}
