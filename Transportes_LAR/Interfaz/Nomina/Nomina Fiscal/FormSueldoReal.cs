using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Nomina_Fiscal
{
	public partial class FormSueldoReal : Form
	{
		#region INSTANCIAS
		//private FormPrincipal refPrincipal = null;
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.Nomina.SQL_Nomina connN = new Conexion_Servidor.Nomina.SQL_Nomina();
		private Conexion_Servidor.Controles.SQL_Controles connC = new Conexion_Servidor.Controles.SQL_Controles();
		#endregion
		
		#region CONSTRUCTOR
		public FormSueldoReal(string id_usu)
		{
			InitializeComponent();
			id_usuario = id_usu;
		}
		#endregion
		
		#region VARIABLES
		string id_usuario = "0";
		Int64 id_operador = 0;
		Int64 id_SueldoR = 0;
		int index_Rows = 0;
		#endregion
		
		#region INICIO - FIN	
		void FormSueldoRealLoad(object sender, EventArgs e)
		{
			Inicio();
		}
		
		void FormSueldoRealFormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
		#endregion
		
		#region ADAPTADOR
		private void Adaptador(){				
			string sentencia = @"select Alias, o.Nombre + ' ' + o.Apellido_Pat + ' ' + o.Apellido_Mat nombre, sr.id, sr.ID_OPERADOR, SUELDO, sr.TIPO_EMPLEADO, TIPO_SUELDO, sr.ESTATUS  
								from OPERADOR o JOIN SUELDO_REAL sr on o.ID = sr.ID_OPERADOR where sr.Estatus = 'ACTIVO' and o.alias like '%"+txtBuscar.Text+"%'";		
			ColoresAlternadosRows(dgSueldos);
			dgSueldos.Rows.Clear();			
			conn.getAbrirConexion(sentencia);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read()){
				dgSueldos.Rows.Add(conn.leer["ID"].ToString(),
				                     conn.leer["ID_OPERADOR"].ToString(),
				                     conn.leer["Alias"].ToString(),
				                     conn.leer["nombre"].ToString(),
				                     conn.leer["TIPO_EMPLEADO"].ToString(),
				                     conn.leer["TIPO_SUELDO"].ToString(),
				                     conn.leer["SUELDO"].ToString());
			}
			conn.conexion.Close();	
			dgSueldos.ClearSelection();		
		}
		#endregion
		
		#region METODOS
		public void Inicio(){
			txtEmpleado.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Alias from OPERADOR where tipo_empleado != 'externo' and Estatus = '1'", "Alias");
           	txtEmpleado.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEmpleado.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
			txtBuscar.AutoCompleteCustomSource = auto.AutocompleteGeneral("select Alias from OPERADOR where tipo_empleado != 'externo' and Estatus = '1'", "Alias");
           	txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            
            this.txtEmpleado.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			this.txtBuscar.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasyEspacios);
			this.txtSueldo.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			Adaptador();
		}
		
		private void ColoresAlternadosRows(DataGridView datag){
			datag.RowsDefaultCellStyle.BackColor = Color.LightBlue;
			datag.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
		}
		
		private void Validacion(){			
			if(txtEmpleado.BackColor == Color.LightGreen && id_operador > 0){
				txtSueldo.Enabled = true;
				pnTE.Enabled = true;
				pnTS.Enabled = true;
				btnAgregar.Enabled = true;
				if(connC.ObtenerTipoEmpledo(id_operador) == "OPERADOR"){
					rbToperador.Checked = true;
					rbTcatorcena.Checked = true;
				}else{
					rbTadministrativo.Checked = true;
					rbTsemanal.Checked = true;
				}
			}else{
				txtSueldo.Enabled = false;
				pnTE.Enabled = false;
				pnTS.Enabled = false;
				btnAgregar.Enabled = false;
				rbToperador.Checked = true;
				rbTcatorcena.Checked = true;
			}
		}
		
		private void Limpiar(){
			txtEmpleado.Text = "";
			txtSueldo.Text = "";
			id_operador = 0;
			id_SueldoR = 0;
			Validacion();
			Adaptador();
			btnAgregar.Text = "Agregar";
			dgSueldos.Enabled = true;
			dgSueldos.ClearSelection();
			index_Rows = 0;
			btnCancelar.Enabled = false;
			txtEmpleado.Enabled = true;
		}
		#endregion
		
		#region EVENTOS		
		void TxtEmpleadoTextChanged(object sender, EventArgs e)
		{
			if(txtEmpleado.Text.Length == 0){
				txtEmpleado.BackColor = Color.White;
				id_operador = 0;
			}
			if(txtEmpleado.Text.Length > 0){
				id_operador = connC.validaUsuarioOperador(txtEmpleado.Text);
				if(id_operador > 0)
					txtEmpleado.BackColor = Color.LightGreen;
				else
					txtEmpleado.BackColor = Color.Red;
			}
			Validacion();
		}
		
		void FormSueldoRealKeyUp(object sender, KeyEventArgs e)
		{			
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}
		
		void DgSueldosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1){
				btnAgregar.Text = "Modificar";
				id_SueldoR = Convert.ToInt64(dgSueldos[0,e.RowIndex].Value);
				id_operador = Convert.ToInt64(dgSueldos[1,e.RowIndex].Value);
				txtEmpleado.Text = dgSueldos[2,e.RowIndex].Value.ToString();
				
				if(dgSueldos[4,e.RowIndex].Value.ToString() == "OPERADOR")
					rbToperador.Checked = true;
				else
					rbTadministrativo.Checked = true;				
				if(dgSueldos[5,e.RowIndex].Value.ToString() == "CATORCENAL")
					rbTcatorcena.Checked = true;
				else
					rbTsemanal.Checked = true;
				
				txtSueldo.Text = dgSueldos[6,e.RowIndex].Value.ToString();
				dgSueldos.Enabled = false;
				index_Rows = e.RowIndex;
				btnCancelar.Enabled = true;
				txtEmpleado.Enabled = false;
			}
		}
		#endregion
		
		#region BOTONES
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if(btnAgregar.Text == "Agregar" && id_SueldoR == 0){
				if(connC.InsertarSueldo(id_operador.ToString(), txtSueldo.Text, ((rbToperador.Checked==true)?"OPERADOR":"ADMINISTRATIVO"), ((rbTcatorcena.Checked==true)?"CATORCENAL":"SEMANAL"))){
					MessageBox.Show("Se agrego correctamente el sueldo a "+txtEmpleado.Text, "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);					
					Limpiar();
				}else{
					MessageBox.Show("Error al agregar el sueldo", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
				}
			}else{
				if(connC.ModificarSueldo(id_SueldoR.ToString(), txtSueldo.Text, ((rbToperador.Checked==true)?"OPERADOR":"ADMINISTRATIVO"), ((rbTcatorcena.Checked==true)?"CATORCENAL":"SEMANAL"), id_usuario, 
				                       dgSueldos[6, index_Rows].Value.ToString(), dgSueldos[4, index_Rows].Value.ToString(), dgSueldos[5, index_Rows].Value.ToString())){
					MessageBox.Show("Se modifico correctamente el sueldo a "+txtEmpleado.Text, "Listo",MessageBoxButtons.OK, MessageBoxIcon.Information);					
					Limpiar();
				}else{
					MessageBox.Show("Error al modificar el sueldo", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);	
				}
			}				
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Limpiar();
		}
		#endregion
		
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			Adaptador();
		}
	}
}
