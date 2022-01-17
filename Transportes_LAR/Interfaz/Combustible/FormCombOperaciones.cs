using System;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;

namespace Transportes_LAR.Interfaz.Combustible
{
	public partial class FormCombOperaciones : Form
	{
		#region CONSTRUCTOR
		public FormCombOperaciones(Interfaz.FormPrincipal formPrinc)
		{
			InitializeComponent();
			formPrincipal = formPrinc;
		}
		#endregion
		
		#region VARIABLES E INSTANCIAS
		Int64 ID_OPERADOR = 0;
		Int64 ID_UNIDAD = 0;
		Int64 ID_GASOLINERA = 0;
		Int64 ID_COMBUSTIBLE = 0;
		bool ENTRA = false;
		String RENDIMIENTO = "LOCAL";
		bool inicio=false;
		
		string placaActual = "";
		string placaActual2 = "";
		
		Interfaz.FormPrincipal formPrincipal;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormCombOperacionesLoad(object sender, EventArgs e)
		{
			datosAutocomplete();
		}
		#endregion
		
		#region AUTOCOMPLETE
		void datosAutocomplete()
		{
			txtOperador.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1'");
			txtOperador.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtUnidad.AutoCompleteCustomSource = auto.AutoReconocimiento("select Numero dato from VEHICULO WHERE ESTATUS='1'");
			txtUnidad.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUnidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			txtGasolinera.AutoCompleteCustomSource = auto.AutoReconocimiento("select NOMBRE dato from GASOLINERA WHERE NOMBRE !='EXTERNA'");
			txtGasolinera.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtGasolinera.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region SELECCION
		void TxtOperadorKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return" && inicio==false)
			{
				txtUnidad.Focus();
			}
			
			inicio=false;
		}
		
		void TxtOperadorLeave(object sender, EventArgs e)
		{
			String consulta = "SELECT * FROM OPERADOR WHERE ALIAS='"+txtOperador.Text+"'";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_OPERADOR=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				ID_OPERADOR=0;
				txtOperador.Text="";
			}
			conn.conexion.Close();
			
			if(ID_UNIDAD==0)
			{
				int dato=0;
				consulta = "select V.ID, V.Numero, V.Marca from ASIGNACIONUNIDAD A, VEHICULO V, OPERADOR O where A.ID_OPERADOR=O.ID and A.ID_UNIDAD=V.ID and O.Alias='"+txtOperador.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_UNIDAD=Convert.ToInt64(conn.leer["ID"]);
					txtUnidad.Text=conn.leer["Numero"].ToString();
					dato=1;
				}
				else
				{
					txtUnidad.Text="000";
					ID_UNIDAD=0;
					dato=0;
				}
				
				conn.conexion.Close();
				
				if(dato==1){
					getPlacas();
					txtGasolinera.Focus();			
				}
			}
			
			/*if(ID_GASOLINERA==0)
			{
				int dato=0;
				consulta = "select G.ID, G.NOMBRE from AUTORIZACION A, OPERADOR O, GASOLINERA G where A.ESTATUS!=0 and A.ID_O=O.ID and A.ID_G=G.ID and Alias='"+txtOperador.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_GASOLINERA=Convert.ToInt64(conn.leer["ID"]);
					txtGasolinera.Text=conn.leer["NOMBRE"].ToString();
					dato=1;
				}
				else
				{
					ID_GASOLINERA=0;
					txtGasolinera.Text="";
					dato=0;
				}
				conn.conexion.Close();
				
				if(dato==1)
					txtKms.Focus();
			}*/
			
			if(ID_COMBUSTIBLE==0)
			{
				consulta = "select T.NOMBRE, P.ID from AUTORIZACION A, VEHICULO V, TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and A.ID_V=V.ID and A.ID_COM=P.ID and A.ESTATUS!='0' and P.ESTATUS='1' and V.Numero='"+txtUnidad.Text+"' order by A.FECHA_REG desc";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_COMBUSTIBLE=Convert.ToInt64(conn.leer["ID"]);
				}
				else
				{
					ID_COMBUSTIBLE=0;
				}
				
				conn.conexion.Close();
			}
			validaSeleccion();
		}
		
		void TxtUnidadKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtGasolinera.Focus();
			}
		}
		
		void TxtUnidadLeave(object sender, EventArgs e)
		{
			string consulta = "select ID, Numero, Marca from VEHICULO where Numero='"+txtUnidad.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_UNIDAD=Convert.ToInt64(conn.leer["ID"]);
			}
			else
			{
				txtUnidad.Text="000";
				ID_UNIDAD=0;
			}
			
			conn.conexion.Close();
			
			/*if(ID_GASOLINERA==0)
			{
				int dato=0;
				consulta = "select G.ID, G.NOMBRE from AUTORIZACION A, OPERADOR O, GASOLINERA G where A.ESTATUS!=0 and A.ID_O=O.ID and A.ID_G=G.ID and Alias='"+txtOperador.Text+"'";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_GASOLINERA=Convert.ToInt64(conn.leer["ID"]);
					txtGasolinera.Text=conn.leer["NOMBRE"].ToString();
					dato=1;
				}
				else
				{
					ID_GASOLINERA=0;
					txtGasolinera.Text="";
					dato=0;
				}
				conn.conexion.Close();
				
				if(dato==1)
					txtGasolinera.Focus();
			}*/
			
			if(ID_COMBUSTIBLE==0)
			{
				consulta = "select T.NOMBRE, P.ID from AUTORIZACION A, VEHICULO V, TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and A.ID_V=V.ID and A.ID_COM=P.ID and A.ESTATUS!='0' and P.ESTATUS='1' and V.Numero='"+txtUnidad.Text+"' order by A.FECHA_REG desc";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_COMBUSTIBLE=Convert.ToInt64(conn.leer["ID"]);
				}
				else
				{
					ID_COMBUSTIBLE=0;
				}
				
				conn.conexion.Close();
			}
					
			getPlacas();
			validaSeleccion();
		}
				
		void TxtGasolineraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				txtKms.Focus();
			}
		}
		
		void TxtGasolineraLeave(object sender, EventArgs e)
		{
			string consulta = "select G.ID, G.NOMBRE from AUTORIZACION A, OPERADOR O, GASOLINERA G where A.ESTATUS!=0 and A.ID_O=O.ID and A.ID_G=G.ID and G.NOMBRE='"+txtGasolinera.Text+"'";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				ID_GASOLINERA=Convert.ToInt64(conn.leer["ID"]);
				txtGasolinera.Text=conn.leer["NOMBRE"].ToString();
			}
			else
			{
				ID_GASOLINERA=0;
				txtGasolinera.Text="";
			}
			conn.conexion.Close();
			
			if(ID_COMBUSTIBLE==0)
			{
				consulta = "select T.NOMBRE, P.ID from AUTORIZACION A, VEHICULO V, TIPOS_COMB T, PRECIOS_COMB P where P.ID_TC=T.ID and A.ID_V=V.ID and A.ID_COM=P.ID and A.ESTATUS!='0' and P.ESTATUS='1' and V.Numero='"+txtUnidad.Text+"' order by A.FECHA_REG desc";
				conn.getAbrirConexion(consulta);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					ID_COMBUSTIBLE=Convert.ToInt64(conn.leer["ID"]);
				}
				else
				{
					ID_COMBUSTIBLE=0;
				}
				
				conn.conexion.Close();
			}
			validaSeleccion();
		}
		#endregion
		
		#region VALIDA KMS
		void TxtKmsKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar==46 && txtKms.Text.Contains(".")==false))
			{
				e.Handled=false;
			}
			else
			{
				e.Handled=true;
			}
		}
		
		void TxtKmsLeave(object sender, EventArgs e)
		{
			if(txtKms.Text!="")
			{
				if(Convert.ToDouble(txtKms.Text)>0 && ENTRA == true)
				{
					if(cmbMotivo.SelectedIndex == -1){
						cmdGuardar.Enabled=false;
					}else{
						cmdGuardar.Enabled=true;
						cmdGuardar.Focus();
					}
					
				}
				else
				{
					cmdGuardar.Enabled=false;
				}
			}
			else
			{
				txtKms.Text="0";
				cmdGuardar.Enabled=false;	
			}
		}
		
		void TxtKmsKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				if(txtKms.Text!="")
				{
					if(Convert.ToDouble(txtKms.Text)>0 && ENTRA == true)
					{
						if(cmbMotivo.SelectedIndex == -1){
							cmdGuardar.Enabled=false;
						}else{
							cmdGuardar.Enabled=true;
							cmdGuardar.Focus();
						}
					}
					else
					{
						cmdGuardar.Enabled=false;
					}
				}
				else
				{			
					cmdGuardar.Enabled=false;					
					txtKms.Text="0";
				}
			}
		}
		
		void TxtKmsEnter(object sender, EventArgs e)
		{
			txtKms.SelectAll();
		}
		
		void CmbMotivoSelectedIndexChanged(object sender, EventArgs e)
		{
			if(txtKms.Text != ""){
				if(Convert.ToDouble(txtKms.Text)>0 && ENTRA == true){
					if(cmbMotivo.SelectedIndex == -1){
						cmdGuardar.Enabled=false;
					}else{
						cmdGuardar.Enabled=true;
						cmdGuardar.Focus();
					}				
				}else{
					cmdGuardar.Enabled=false;
				}
			}else{
				txtKms.Text="0";
				cmdGuardar.Enabled=false;	
			}
		}
		#endregion
		
		#region VALIDACION
		void validaSeleccion()
		{
			if(ID_GASOLINERA!=0 && ID_OPERADOR!=0 && ID_UNIDAD!=0)
			{
				txtGasolinera.BackColor=Color.SpringGreen;
				txtOperador.BackColor=Color.SpringGreen;
				txtUnidad.BackColor=Color.SpringGreen;
				
				txtGasolinera.ForeColor=Color.Black;
				txtOperador.ForeColor=Color.Black;
				txtUnidad.ForeColor=Color.Black;
				ENTRA = true;
			}
			else
			{
				ENTRA = false;
				cmdGuardar.Enabled=false;
				txtGasolinera.BackColor=Color.White;
				txtOperador.BackColor=Color.White;
				txtUnidad.BackColor=Color.White;
			}
		}
		#endregion
		
		#region LIMPIA DATOS
		void limpiaDatos()
		{
			ID_GASOLINERA = 0;
			ID_OPERADOR = 0;
			ID_UNIDAD = 0;
			validaSeleccion();
				
			cmbMotivo.SelectedIndex = -1;
			txtOperador.Text="OPERADOR";
			txtUnidad.Text="000";
			txtGasolinera.Text="";
			txtKms.Text="0";
			cmdGuardar.Enabled=false;
			
			ID_OPERADOR=0;
			ID_UNIDAD=0;
			ID_GASOLINERA=0;
			ID_COMBUSTIBLE=0;
			
			txtOperador.Focus();
			txtOperador.SelectAll();
			
			placaActual = "";
			txtPlacaE.Text = "";
			txtPlacaE.BackColor = Color.White;
			txtPlacaF.Text = "";
			txtPlacaF.BackColor = Color.White;
			cbPlacaMal.Checked = false;
			txtPlacaNueva.Text = "";
			txtPlacaNueva.BackColor = Color.White;
			txtPlacaF.BackColor = Color.White;
			txtPlacaE.BackColor = Color.White;
			
			placaActual = "";
			placaActual2 = "";
		}
		#endregion
		
		#region BOTON
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(validaPlacas()){
				inicio=true;
				if(ID_COMBUSTIBLE==0){
					string consulta = "select P.* from PRECIOS_COMB P, TIPOS_COMB T where P.ID_TC=T.ID and ESTATUS='1' and T.NOMBRE='Diesel'";
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
						ID_COMBUSTIBLE=Convert.ToInt64(conn.leer["ID"]);					
					conn.conexion.Close();
				}
				
				string consult = "select top 1 * from AUTORIZACION where ESTATUS!=0 and RENDIMIENTO is not null and RENDIMIENTO != '' and ID_V in (select ID from VEHICULO where Numero='"+txtUnidad.Text+"')  order by fecha_base desc";
				conn.getAbrirConexion(consult);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
					RENDIMIENTO = conn.leer["RENDIMIENTO"].ToString();
				conn.conexion.Close();
				
				if(RENDIMIENTO == "")
					RENDIMIENTO = "LOCAL";
							
				try{
					consult = "select foraneo from OPERADOR where id = "+ID_OPERADOR;			
					conn.getAbrirConexion(consult);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						if(conn.leer["foraneo"].ToString() == "1")
							RENDIMIENTO = "FORANEO";
					conn.conexion.Close();
				}catch(Exception){
					
				}finally{
					if(conn.conexion != null)
						conn.conexion.Close();
				}
				
				txtFolio.Text=getValidacion();		
				
				if(txtFolio.Text != "0"){
					string Marca = "";
					string consulta = "select Marca from VEHICULO where id ="+ID_UNIDAD;
					try{
						conn.getAbrirConexion(consulta);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
							Marca = conn.leer["Marca"].ToString();	
						conn.conexion.Close();
					}catch(Exception){
						if(conn.conexion != null)
						conn.conexion.Close();
					}
							
						
					//String datos = txtFolio.Text.ToString().Substring(2, txtFolio.Text.Length-2)+" "+txtOperador.Text+", "+txtUnidad.Text+", "+txtKms.Text+" KM, "+txtGasolinera.Text+", "+cmbMotivo.Text+".";
					String datos = txtFolio.Text+" "+txtOperador.Text+", "+txtUnidad.Text+", "+Marca+", "+txtKms.Text+" KM, "+txtGasolinera.Text+", "+cmbMotivo.Text+".";
					Clipboard.Clear();
				 	Clipboard.SetDataObject(datos);
				}				
				limpiaDatos();
			}else{
				MessageBox.Show("Ingresa una placa de la unidad valida", "Placa Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPlacaNueva.Focus();
			}
		}			
		#endregion
		
		#region GUARDA VALIDACION
		String getValidacion()
		{
			String dato="";
			String consulta = "SELECT MAX(NUMERO) NUMERO FROM AUTORIZACION WHERE FECHA_REG=(SELECT CONVERT (DATE, SYSDATETIME()))";
			
			Int64 numero = 0;
			String numReg = "";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				try
				{
					numero=Convert.ToInt64(conn.leer["NUMERO"]);
					numero++;
				}
				catch (Exception)
				{
					
				}
			}
			conn.conexion.Close();
			
			// +++++++++++++++++++ registro ++++++++++++++++++++++++
			if(numero==0)
			{
				numReg="01";
			}
			else if(numero.ToString().Length==1)
			{
				numReg="0"+numero;
			}
			else
			{
				numReg=numero.ToString();
			}
			
			consulta ="execute SP_AUTORIZA "+formPrincipal.idUsuario+", "+ID_UNIDAD+", "+ID_OPERADOR+", "+ID_GASOLINERA+", "+ID_COMBUSTIBLE+", '"+txtKms.Text+"', '"+numReg+"', '', NULL, '"+RENDIMIENTO+"', '1', null, null, 'EXTERNA'";
			conn.getAbrirConexion(consulta); 
			conn.comando.ExecuteNonQuery(); 
			conn.conexion.Close();
			
			// ++++++++++++++++++++++++++++++++++++++++++++++++++++
			
			// ++++++++++++++++++++++++++++++++++++++++++++++++++++ DATOS LALO
			bool  exiteRegistro = true;
			string idAutR = "0";
			try{
				consulta = @"select MAX(id) ID from AUTORIZACION WHERE ID_O = "+ID_OPERADOR+ "and ID_V = "+ID_UNIDAD;
				conn.getAbrirConexion(consulta);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					idAutR = conn.leer["ID"].ToString();
					exiteRegistro = true;
				}
				else{
					idAutR = "0";
					exiteRegistro = false;
				}				
				conn.conexion.Close();
				
				if(exiteRegistro){
					conn.getAbrirConexion(@"select ID_A from MAS_DATOS_AUTORIZACION where ID_A = "+idAutR);
					conn.leer = conn.comando.ExecuteReader();
					if(conn.leer.Read())
						exiteRegistro = true;
					else
						exiteRegistro = false;
					conn.conexion.Close();
				}
				
				string TipoP = "";
				string Placa = "";
				string estatusPlaca = "";
				if(cbPlacaMal.Checked)
					TipoP = "O";
				else{
					if(txtPlacaE.BackColor == Color.LightGreen)
						TipoP = "E";
					else if(txtPlacaF.BackColor == Color.LightGreen)					
						TipoP = "F";
					else				
						TipoP = "N";
				}
				
				Placa = ((TipoP == "O")? txtPlacaNueva.Text : ((TipoP == "E")? txtPlacaE.Text : ((TipoP == "F")? txtPlacaF.Text : "NO SE REVISO") ) );
				if(placaActual != ""){
					if(placaActual == TipoP)
						estatusPlaca = "CORRECTO";
					else
						estatusPlaca = "INCORRECTO";
				}else
					estatusPlaca = "NO SE REVISO";
				
				
				if(TipoP == "N")
					estatusPlaca = "NO SE REVISO";
					
				if(exiteRegistro)
					consulta = "UPDATE MAS_DATOS_AUTORIZACION SET PLACAS_AUTORIZACION = '"+Placa+"' and TIPO_PLACAS = '"+TipoP+"' AND PLACA_ESTATUS = '"+estatusPlaca+"'  WHERE ID_A = "+idAutR;
				else
					consulta = "INSERT INTO MAS_DATOS_AUTORIZACION(ID_A, KM_RUTA, PLACAS_AUTORIZACION, TIPO_PLACAS, PLACA_ESTATUS, PLACA_REVISION)VALUES( "+idAutR+", '', '"+Placa+"', '"+TipoP+"', '"+estatusPlaca+"', 'NO')"; 
				conn.getAbrirConexion(consulta);
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
			}catch(Exception){
				if(conn.conexion != null)
					conn.conexion.Close();
			}		
			
			// ++++++++++++++++++++++++++++++++++++++++++++++++++++
			
			
			DateTime FECHA = DateTime.Now;
			
			if(FECHA.ToString("MMM")=="may")
			{
				dato=FECHA.ToString("yyyy").Substring(3,1)+"Y"+FECHA.ToString("dd")+numReg;
			}
			else if(FECHA.ToString("MMM")=="jul")
			{
				dato=FECHA.ToString("yyyy").Substring(3,1)+"L"+FECHA.ToString("dd")+numReg;
			}
			else if(FECHA.ToString("MMM")=="ago")
			{
				dato=FECHA.ToString("yyyy").Substring(3,1)+"G"+FECHA.ToString("dd")+numReg;
			}
			else
			{
				dato=FECHA.ToString("yyyy").Substring(3,1)+FECHA.ToString("MMMMM").Substring(0,1).ToUpper()+FECHA.ToString("dd")+numReg;
			}
			
			return dato;
		}
		#endregion				
		
		#region EVENTOS
		void CbPlacaMalCheckedChanged(object sender, EventArgs e)
		{
			if(cbPlacaMal.Checked == true){				
				txtPlacaNueva.Enabled = true;
				txtPlacaNueva.BackColor = Color.LightGreen;
				txtPlacaF.BackColor = Color.White;
				txtPlacaE.BackColor = Color.White;
				txtPlacaNueva.Focus();
			}
			else{
				txtPlacaNueva.BackColor = Color.White;
				txtPlacaF.BackColor = Color.White;
				txtPlacaE.BackColor = Color.White;
				txtPlacaNueva.Enabled = false;	
				if(placaActual == "E")
					txtPlacaE.BackColor = Color.LightGreen;
				else if(placaActual == "F")
					txtPlacaF.BackColor = Color.LightGreen;
			}
		}
		
		void TxtPlacaEClick(object sender, EventArgs e)
		{
			txtPlacaNueva.Text = "";
			cbPlacaMal.Checked = false;
			txtPlacaNueva.BackColor = Color.White;
			txtPlacaF.BackColor = Color.White;
			txtPlacaE.BackColor = Color.LightGreen;
		}
		
		void TxtPlacaFClick(object sender, EventArgs e)
		{		
			txtPlacaNueva.Text = "";
			cbPlacaMal.Checked = false;	
			txtPlacaNueva.BackColor = Color.White;
			txtPlacaF.BackColor = Color.LightGreen;
			txtPlacaE.BackColor = Color.White;
		}
		#endregion
		
		#region METODOS
		private bool validaPlacas(){
			bool respuesta = true; 
			Regex rgx1 = new Regex(@"^[0-9]{2}[A-Z]{2}[0-9]{1}[A-Z]{1}$"); // FEDERAL: 2#/2L/1#/1L
			Regex rgx2 = new Regex(@"^[0-9]{3}[A-Z]{2}[0-9]{1}$"); // FEDERAL: 3#/2L/1#
			Regex rgx3 = new Regex(@"^[0-9]{1}[A-Z]{3}[0-9]{2}$"); // ESTATAL: 1#/3L/2#
			
			if(cbPlacaMal.Checked){
				if(txtPlacaNueva.Text.Length == 6){
					if(rgx1.IsMatch(txtPlacaNueva.Text) || rgx2.IsMatch(txtPlacaNueva.Text) || rgx3.IsMatch(txtPlacaNueva.Text) )
						respuesta = true;
					else
						respuesta = false;
				}else
					respuesta = false;
			}
		    return respuesta;
		}
		
		private void getPlacas(){
			if(ID_UNIDAD != 0){
				string consulta = "";
				try{
					consulta = "select Placa_Estatal, Placa_Federal from VEHICULO where id = "+ID_UNIDAD;
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						txtPlacaE.Text = conn.leer["Placa_Estatal"].ToString();
						txtPlacaF.Text = conn.leer["Placa_Federal"].ToString();
					}else{
						txtPlacaE.Text = "0";
						txtPlacaF.Text = "0";
					}					
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener las placas de la unidad: "+ex.Message, "Error de Placas", MessageBoxButtons.OK, MessageBoxIcon.Error);
					if(conn.conexion != null)
						conn.conexion.Close();
				}
				try{
					consulta = "select PLACA_ACTUAL from VEHICULOS_PERIODOS where ID_VEHICULO = "+ID_UNIDAD;
					conn.getAbrirConexion(consulta);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read()){
						if(conn.leer["PLACA_ACTUAL"].ToString().Equals("E")){
							txtPlacaE.BackColor = Color.LightGreen;
							txtPlacaF.BackColor = Color.White;
							placaActual = "E";
							placaActual2 = txtPlacaE.Text;
						}else if(conn.leer["PLACA_ACTUAL"].ToString().Equals("F")){
							txtPlacaF.BackColor = Color.LightGreen;
							txtPlacaE.BackColor = Color.White;
							placaActual = "F";
							placaActual2 = txtPlacaF.Text;
						}else{
							txtPlacaF.BackColor = Color.White;
							txtPlacaE.BackColor = Color.White;
							placaActual = "";
							placaActual2 = "";
						}
					}else{
						txtPlacaF.BackColor = Color.White;
						txtPlacaE.BackColor = Color.White;
						placaActual = "";
						placaActual2 = "";
					}					
					conn.conexion.Close();
				}catch(Exception ex){
					MessageBox.Show("Error al obtener las placas de la unidad: "+ex.Message, "Error de Placas", MessageBoxButtons.OK, MessageBoxIcon.Error);
					if(conn.conexion != null)
						conn.conexion.Close();
				}
			}
		}
		#endregion
	}
}
