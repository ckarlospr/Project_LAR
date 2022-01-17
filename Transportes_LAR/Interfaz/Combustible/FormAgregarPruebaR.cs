using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormAgregarPruebaR : Form
	{		
		#region CONSTRUCTOR
		public FormAgregarPruebaR(FormPruebaRendimiento refp, int tip, Int32 id_u)
		{
			InitializeComponent();
			refPrueba = refp;
			tipo = tip;
			id_usuario = id_u;
		}
		#endregion	
		
		#region VARIABLES
		int tipo;
		Int32 id_usuario;
		string id_operador = "0";
		#endregion
		
		#region INSTANCIAS
		FormPruebaRendimiento refPrueba;
		Conexion_Servidor.Combustible.SQL_Combustible connC = new Conexion_Servidor.Combustible.SQL_Combustible();
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();	
		#endregion
				
		#region INICIO - FIN 
		void FormAgregarPruebaRLoad(object sender, EventArgs e)
		{
			dtpFechaPrueba.MaxDate = DateTime.Now.AddDays(1);
			validaCampo();			
			autoCompleta();
			if(tipo == 3){
				completaCamposModificar();
			}else{
				completaInfo();
			}			
		}
		
		void FormAgregarPruebaRFormClosing(object sender, FormClosingEventArgs e)
		{
			
		}
		#endregion
		
		#region METODOS
		private void completaCamposModificar(){
			txtusuario.Enabled = false;
			txtusuario.Text = refPrueba.dgHistorial[5, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			txtOperador.Text = refPrueba.dgHistorial[4, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			txtUnidad.Text = refPrueba.dgHistorial[2, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();			
			dtpFechaPrueba.Text = refPrueba.dgHistorial[7, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			dtpHoraInicio.Text = refPrueba.dgHistorial[8, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			dtpHoraFin.Text = refPrueba.dgHistorial[9, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();			
			txtLitrosFin.Text = refPrueba.dgHistorial[10, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			txtKmInicio.Text = refPrueba.dgHistorial[11, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			txtKmFin.Text = refPrueba.dgHistorial[12, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();			
			txtCometario.Text = refPrueba.dgHistorial[14, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			txtFactor.Text = refPrueba.dgHistorial[6, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			cbSeguimiento.Text = refPrueba.dgHistorial[13, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
			id_operador = refPrueba.dgHistorial[3, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString();
		}
		
		private void completaInfo(){
			dtpFechaPrueba.Value = DateTime.Now;
			dtpHoraInicio.Value = DateTime.Now;
			dtpHoraFin.Value = DateTime.Now;
			
			txtusuario.Text = refPrueba.refprincipal.lblDatoUsuario.Text;
			txtOperador.Text = refPrueba.dgPruebaRendimiento[3, refPrueba.dgPruebaRendimiento.CurrentRow.Index].Value.ToString();
			txtUnidad.Text =  refPrueba.dgPruebaRendimiento[1, refPrueba.dgPruebaRendimiento.CurrentRow.Index].Value.ToString();
			id_operador = refPrueba.dgPruebaRendimiento[2, refPrueba.dgPruebaRendimiento.CurrentRow.Index].Value.ToString();		
		}
		
		private void autoCompleta(){
			txtusuario.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"select Alias from OPERADOR  where tipo_empleado != 'OPERADOR' and tipo_empleado 
						!= 'SISTEMAS' and tipo_empleado != 'Externo' and tipo_empleado != 'MASTER' and tipo_empleado != 'DOCTOR'", "Alias");
           	txtusuario.AutoCompleteMode = AutoCompleteMode.Suggest;
           	txtusuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            txtOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral(@"select Alias from OPERADOR  where tipo_empleado = 'OPERADOR'", "Alias");
           	txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		private void validaCampo(){
			this.txtKmInicio.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto2);
			this.txtKmFin.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto2);			
			this.txtFactor.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto2);
		}
		
		private bool validaAgregar(){
			errorProvider1.Clear();
			bool respuesta = true;
			Double x = 0.0;
			if(txtusuario.Text.Length == 0){
				errorProvider1.SetError(txtusuario, "Ingresa el usuario que realizo la prueba");
				respuesta = false;
			}
			if(txtOperador.Text.Length == 0){
				errorProvider1.SetError(txtOperador, "Ingresa el operador que realizo la prueba");
				respuesta = false;
			}
			if(txtLitrosFin.Text.Length == 0 || txtLitrosFin.Text == "0" || txtLitrosFin.Text == "0.0"){
				errorProvider1.SetError(txtLitrosFin, "Ingresa los litros que se cargaron al final de la prueba");
				respuesta = false;
			}
			if(txtKmInicio.Text.Length == 0 || txtKmInicio.Text == "0" || txtKmInicio.Text == "0.0"){
				errorProvider1.SetError(txtKmInicio, "Ingresa el Kilometraje del inicio de la prueba");
				respuesta = false;
			}
			if(txtKmFin.Text.Length == 0 || txtKmFin.Text == "0" || txtKmFin.Text == "0.0"){
				errorProvider1.SetError(txtKmFin, "Ingresa el Kilometraje del final de la prueba");
				respuesta = false;
			}			
			if(cbSeguimiento.Text.Length == 0){
				errorProvider1.SetError(cbSeguimiento, "Ingresa el seguimiento de la prueba");
				respuesta = false;
			}
			if(Double.TryParse(txtFactor.Text, out x) == false || txtFactor.Text == "0.0"){
				errorProvider1.SetError(txtFactor, "Ingresa los datos correctos para hacer el calculo");
				respuesta = false;
			}
			if(txtOperador.BackColor.Name == "White"){
				errorProvider1.SetError(txtOperador, "Ingresa un operador correcto");
				respuesta = false;
			}
			if(id_operador == "0"){
				errorProvider1.SetError(txtOperador, "Ingresa un operador correcto");
				respuesta = false;
			}
			
			return respuesta;
		}
		
		private void calculaRendimiento(){
			try{
				if(txtKmFin.Text != "" && txtKmInicio.Text != "" && txtLitrosFin.Text != "")
					txtFactor.Text = (Math.Round((Convert.ToInt64(txtKmFin.Text) - Convert.ToInt64(txtKmInicio.Text)) / Convert.ToDouble(txtLitrosFin.Text), 2)).ToString();
			}catch(Exception){
				txtFactor.Text = "Infinite";
			}
		}
		#endregion
		
		#region EVENTOS
		void TxtOperadorTextChanged(object sender, EventArgs e)
		{
			string consulta = "select ID from OPERADOR where Alias ='"+txtOperador.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer = conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				id_operador = conn.leer["ID"].ToString();
				txtOperador.BackColor = Color.LightSteelBlue;
			}else{
				txtOperador.BackColor = Color.White;
			}
			conn.conexion.Close();
		}
		
		void TxtFactorTextChanged(object sender, EventArgs e)
		{
			if(txtFactor.Text.Length > 0)
				btnAceptar.Enabled = true;
			else
				btnAceptar.Enabled = false;			
		}
		
		void TxtLitrosFinTextChanged(object sender, EventArgs e)
		{
			calculaRendimiento();
		}
		
		void TxtKmInicioTextChanged(object sender, EventArgs e)
		{			
			errorProvider1.Clear();
			if(txtKmInicio.Text.Contains(".") == true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
			if(txtKmInicio.Text.Length > 0 && txtKmFin.Text.Length > 0){
				if(Convert.ToInt64(txtKmInicio.Text) > Convert.ToInt64(txtKmFin.Text)){
					errorProvider1.SetError(txtKmInicio, "El Kilometraje de inicio debe de ser menor al kilometraje de fin");
					txtKmInicio.Focus();
				}					
			}				
			calculaRendimiento();
		}
		
		void TxtKmFinTextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(txtKmFin.Text.Contains(".") == true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;	
			if(txtKmInicio.Text.Length > 0 && txtKmFin.Text.Length > 0){
				if(Convert.ToInt64(txtKmInicio.Text) > Convert.ToInt64(txtKmFin.Text)){
					errorProvider1.SetError(txtKmInicio, "El Kilometraje de inicio debe de ser menor al kilometraje de fin");
				}					
			}			
			calculaRendimiento();
		}
		#endregion		
		
		#region BOTONES
		void BtnCancelarClick(object sender, EventArgs e)
		{
			refPrueba.respuesta = false;
			this.Close();			
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{	
			if(validaAgregar()){
				if(tipo == 1){
					Int64 id_rendimiento = 0;
					id_rendimiento = connC.insertarNuevaPrueba(refPrueba.dgPruebaRendimiento[0, refPrueba.dgPruebaRendimiento.CurrentRow.Index].Value.ToString());
					if(id_rendimiento > 0){							
						if(connC.insertarPrueba(id_rendimiento.ToString(), refPrueba.dgPruebaRendimiento[0, refPrueba.dgPruebaRendimiento.CurrentRow.Index].Value.ToString(),
												id_operador, txtusuario.Text,
						                        dtpFechaPrueba.Value.ToString("yyyy-MM-dd"), dtpHoraInicio.Value.ToString("HH:mm:ss"), dtpHoraFin.Value.ToString("HH:mm:ss"),
												txtLitrosFin.Text, txtKmInicio.Text, txtKmFin.Text, txtCometario.Text, txtFactor.Text, cbSeguimiento.Text, id_usuario, 1)){						
							MessageBox.Show("La prueba de rendimiento se registro correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							refPrueba.respuesta = true;
							this.Close();
						}else{
							MessageBox.Show("Error al agregar La prueba de rendimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							refPrueba.respuesta = false;
							this.Close();
						}
					}else{
						MessageBox.Show("Error al agregar La prueba de rendimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();		
					}
				}
				if(tipo == 2){
					Int64 id_rendimiento = 0;
					id_rendimiento = Convert.ToInt64(refPrueba.dgPruebaRendimiento[4, refPrueba.dgPruebaRendimiento.CurrentRow.Index].Value);
					if(id_rendimiento > 0){						
						if(connC.insertarPrueba(id_rendimiento.ToString(), refPrueba.dgPruebaRendimiento[0, refPrueba.dgPruebaRendimiento.CurrentRow.Index].Value.ToString(), 
						                        id_operador, txtusuario.Text,
						                        dtpFechaPrueba.Value.ToString("yyyy-MM-dd"), dtpHoraInicio.Value.ToString("HH:mm:ss"), dtpHoraFin.Value.ToString("HH:mm:ss"),
												txtLitrosFin.Text, txtKmInicio.Text, txtKmFin.Text, txtCometario.Text, txtFactor.Text, cbSeguimiento.Text, id_usuario, 0)){						
							MessageBox.Show("La prueba de rendimiento se registro correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							refPrueba.respuesta = true;
							this.Close();
						}else{
							MessageBox.Show("Error al agregar La prueba de rendimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							refPrueba.respuesta = false;
							this.Close();
						}
					}else{
						MessageBox.Show("Error al agregar La prueba de rendimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();		
					}
				}
				
				if(tipo == 3){
					Int64 id_rh = 0;
					id_rh= Convert.ToInt64(refPrueba.dgHistorial[1, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString());
					Int64 id_rendimiento = Convert.ToInt64(refPrueba.dgHistorial[0, refPrueba.dgHistorial.CurrentRow.Index].Value.ToString());
					if(id_rh> 0){
						if(connC.modificarPrueba(id_rh.ToString(), txtusuario.Text, dtpFechaPrueba.Value.ToString("yyyy-MM-dd"), dtpHoraInicio.Value.ToString("HH:mm:ss"), dtpHoraFin.Value.ToString("HH:mm:ss"),
												txtLitrosFin.Text, txtKmInicio.Text, txtKmFin.Text, txtCometario.Text, txtFactor.Text, cbSeguimiento.Text, id_usuario, id_rendimiento, id_operador)){						
							MessageBox.Show("La prueba de rendimiento se modifico correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
							refPrueba.respuesta = true;
							this.Close();
						}else{
							MessageBox.Show("Error al modificar La prueba de rendimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							refPrueba.respuesta = false;
							this.Close();
						}
					}else{
						MessageBox.Show("Error al modificar La prueba de rendimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();		
					}
				}
			}
		}
		#endregion		
	}
}
