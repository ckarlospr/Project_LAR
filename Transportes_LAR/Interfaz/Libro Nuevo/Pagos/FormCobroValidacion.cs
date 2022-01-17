using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro_Nuevo.Pagos
{
	public partial class FormCobroValidacion : Form
	{		
		#region INSTANCIAS
		FormLibroViajes formValidacion = null;
		private Proceso.AutoCompleClass auto = new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn = new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region CONSTRUCTOR
		public FormCobroValidacion(FormLibroViajes valEsp, int tip)
		{
			InitializeComponent();
			formValidacion = valEsp;
			TIPO = tip;
		}		
		#endregion
		
		#region VARIABLES
		int TIPO = 0;
		String tipoCobro = "OPERADOR";
		string precioServicio;
		#endregion		
		
		#region INICIO - FIN
		void FormCobroValidacionLoad(object sender, EventArgs e)
		{	
			precioServicio = formValidacion.dgDatos[5, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();			
			this.txtSaldo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			this.txtTelefono.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			
			txtCobro.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' AND (tipo_empleado='OPERADOR' OR tipo_empleado='Externo')");
			txtCobro.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtCobro.AutoCompleteSource = AutoCompleteSource.CustomSource;
			if(TIPO==2)
				 datos();			
			
			if(Convert.ToDouble(formValidacion.dgDatos[5, formValidacion.dgDatos.CurrentRow.Index].Value) == 0.00)
				rbPagoAnt.Checked=true;
			
		}		
		#endregion
		
		#region EVENTOS 
		void TxtCobroKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString() == "Return"){
				String consul = "select T.Numero from TELEFONOCHOFER T, OPERADOR O where T.Descripcion='Red LAR' and T.ID_Chofer=O.ID AND O.Alias = '"+txtCobro.Text+"'";
				conn.getAbrirConexion(consul);
				conn.leer = conn.comando.ExecuteReader();
				if(conn.leer.Read()){
					txtTelefono.Text = conn.leer["Numero"].ToString();
				}				
				conn.conexion.Close();
			}
		}
		
		void RbDepositoCheckedChanged(object sender, EventArgs e)
		{
			if(rbDeposito.Checked == true){
				txtCobro.Text = "Deposito";
				txtTelefono.Text = formValidacion.dgDatos[20, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro = "DEPOSITO";
			}
		}
		
		void RbPagoAntCheckedChanged(object sender, EventArgs e)
		{
			if(rbPagoAnt.Checked == true){
				txtCobro.Text = "PAGADO";
				txtTelefono.Text = formValidacion.dgDatos[20, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro = "PAGADO";
				txtCobro.Focus();
			}			
		}
		
		void RbFactCobroCheckedChanged(object sender, EventArgs e)
		{
			if(rbFactCobro.Checked == true){
				txtCobro.Text = "FACTURA A COBRO";
				txtTelefono.Text = formValidacion.dgDatos[20, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro = "FACTURA";
				txtCobro.Focus();
			}
		}
		
		void RbOperadorCheckedChanged(object sender, EventArgs e)
		{
			if(rbOperador.Checked == true){
				txtCobro.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' AND (tipo_empleado='OPERADOR' OR tipo_empleado='Externo')");
				txtCobro.AutoCompleteMode = AutoCompleteMode.Suggest;
				txtCobro.AutoCompleteSource = AutoCompleteSource.CustomSource;
				
				txtCobro.Text=formValidacion.dgDatos[19, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				txtTelefono.Text=formValidacion.dgDatos[20, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro = "OPERADOR";
			}
		}
		
		void RbCoordinadorCheckedChanged(object sender, EventArgs e)
		{
			if(rbCoordinador.Checked==true)
			{
				txtCobro.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' AND tipo_empleado='Coordinador'");
				txtCobro.AutoCompleteMode =AutoCompleteMode.Suggest;
				txtCobro.AutoCompleteSource = AutoCompleteSource.CustomSource;
				
				txtCobro.Text="Coordinador?";
				txtTelefono.Text="0000000000";
				tipoCobro="COORDINADOR";
				txtCobro.Focus();
			}
		}
		
		void RbincobrableCheckedChanged(object sender, EventArgs e)
		{
			if(rbincobrable.Checked == true){
				txtCobro.Text = "Incobrable";
				txtTelefono.Text = "0000000000";
				tipoCobro = "INCOBRABLE";
				txtSaldo.Text = "0";
			}
		}
		#endregion
		
		#region METODOS
		public void datos(){
			txtCobro.Text = formValidacion.dgDatos[19, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
			txtTelefono.Text = formValidacion.dgDatos[20, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
			txtSaldo.Text = formValidacion.dgDatos[5, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
		}
		
		public void setValidacion(String tipo, String cobro, String observaciones, String telefono)
		{				
			bool respuesta = false;
			for(int x=0; x<formValidacion.dgDatos.Rows.Count; x++){
				if(formValidacion.dgDatos.Rows[x].Selected == true){
					if(formValidacion.dgDatos.Rows[x].Selected == true && (formValidacion.dgDatos[0,x].Value.ToString() != "CANCELADA" && formValidacion.dgDatos[0,x].Value.ToString() != "SIN CONF.")){				
						if(guardaValidacion(formValidacion.dgDatos[3,x].Value.ToString(), formValidacion.dgDatos[1,x].Value.ToString(), formValidacion.dgDatos[2,x].Value.ToString(), tipo, cobro, observaciones, telefono, 
						                    formValidacion.dgDatos[0,x].Value.ToString(), formValidacion.dgDatos[8,x].Value.ToString(), formValidacion.dgDatos[5,x].Value.ToString(), formValidacion.dgDatos[7,x].Value.ToString()))
						{
							respuesta = true;
						}
					}
				}
			}
			if(respuesta == true){
				for(int x=formValidacion.dgDatos.Rows.Count-1; x>-1; x--){
					if(formValidacion.dgDatos.Rows[x].Selected == true){
						if(formValidacion.cbValidados.Checked == false)
							formValidacion.dgDatos.Rows.RemoveAt(x);
					}
				}
				formValidacion.dgDatos.ClearSelection();
			}
		}
		
		public bool guardaValidacion(String ID_RE, String id_r1, String id_r2, String tipo, String cobro, String observaciones, String telefono, String Tipo_V, String id_vehiculo, String saldo, string id_operador)
		{
			bool respuesta = false;
			Int64 IDENT = 0;
			string comen = observaciones + " Folio: " + txtFolio.Text;
			
			String miconsult = "select MAX(NUMERO)+1 num from COBRO_ESPECIAL";
			conn.getAbrirConexion(miconsult);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read()){
				try{
					IDENT = Convert.ToInt64(conn.leer["num"]);
				}catch(Exception){
					IDENT = 1;
				}
			}				
			conn.conexion.Close();
			
			try{
				miconsult="insert into COBRO_ESPECIAL values ('"+ID_RE+"','"+id_r1+"', '"+id_r2+"', '"+tipo+"', '"+cobro+"', '"+comen+"', "+IDENT+", '"+telefono+"', '1', (SELECT CONVERT (date, SYSDATETIME())), "+formValidacion.id_usuario+", '"+IDENT+"-"+DateTime.Now.ToString("yyMM")+"', '0', '0', '0', '0', '"+Tipo_V+"', '"+id_vehiculo+"', '"+saldo+"', '', "+id_operador+")";	//
				conn.getAbrirConexion(miconsult);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				conn.getAbrirConexion("update RUTA set PAGO='1' where ID="+id_r1);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				conn.getAbrirConexion("update RUTA set PAGO='1' where ID="+id_r2);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				respuesta=true;
			}catch(Exception){
				respuesta = false;
			}			
			return respuesta;
		}
		
		#endregion
		
		#region BOTONES
		void CmdAceptarClick(object sender, EventArgs e)
		{
			bool Continua = true;
			if(Convert.ToDouble(txtSaldo.Text) != Convert.ToDouble(formValidacion.dgDatos[5, formValidacion.dgDatos.CurrentRow.Index].Value)){
				if(txtComentario.Text == ""){
					MessageBox.Show("Justifique el cambio de saldo en comentarios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
					Continua = false;
				}
			}
			
			if(Continua){
				if(txtTelefono.Text!="" && !(txtTelefono.Text.Contains("00000000"))){
					if(TIPO == 1){
						setValidacion(tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text);
					}else if(TIPO == 2){
						formValidacion.dgDatos[19, formValidacion.dgDatos.CurrentRow.Index].Value=txtCobro.Text;
						formValidacion.dgDatos[24, formValidacion.dgDatos.CurrentRow.Index].Value=tipoCobro;
						formValidacion.dgDatos[5, formValidacion.dgDatos.CurrentRow.Index].Value=txtSaldo.Text;
						
						if(guardaValidacion(formValidacion.dgDatos[3,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[1,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[2,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), 
								                    tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text, formValidacion.dgDatos[0,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), formValidacion.dgDatos[8,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), txtSaldo.Text, formValidacion.dgDatos[7,formValidacion.dgDatos.CurrentRow.Index].Value.ToString()))
						{
							formValidacion.dgDatos[26,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
							formValidacion.dgDatos[26,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
							formValidacion.dgDatos[27,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
							formValidacion.dgDatos[27,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
							
							if(formValidacion.cbValidados.Checked == false)
							{
								formValidacion.dgDatos.Rows.RemoveAt(formValidacion.dgDatos.CurrentRow.Index);
							}
						}
					}
					this.Close();
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron guardados correctamente");
				}else{
					DialogResult rs2 = MessageBox.Show("¿Desea guardar sin numero de telefono?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes == rs2){
						if(TIPO == 1){
							setValidacion(tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text);
						}
						else if(TIPO==2)
						{
							formValidacion.dgDatos[19, formValidacion.dgDatos.CurrentRow.Index].Value=txtCobro.Text;
							formValidacion.dgDatos[24, formValidacion.dgDatos.CurrentRow.Index].Value=tipoCobro;
							formValidacion.dgDatos[5, formValidacion.dgDatos.CurrentRow.Index].Value=txtSaldo.Text;
							
							if(guardaValidacion(formValidacion.dgDatos[3,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[1,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[2,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), 
							                    tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text, formValidacion.dgDatos[0,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), formValidacion.dgDatos[8,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), txtSaldo.Text, formValidacion.dgDatos[7,formValidacion.dgDatos.CurrentRow.Index].Value.ToString()))
							{
								formValidacion.dgDatos[26,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
								formValidacion.dgDatos[26,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
								formValidacion.dgDatos[27,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
								formValidacion.dgDatos[27,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
								
								if(formValidacion.cbValidados.Checked == false){
									formValidacion.dgDatos.Rows.RemoveAt(formValidacion.dgDatos.CurrentRow.Index);
								}
							}
						}
						this.Close();
						Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron guardados correctamente");
					}
				}
			}
		}		
		#endregion					
		
		void TxtSaldoTextChanged(object sender, EventArgs e)
		{
			if(txtSaldo.Text != precioServicio){
				txtComentario.Enabled = true;
				cmdAceptar.Enabled = false;
				txtFolio.Enabled = true;
			}else{
				txtComentario.Enabled = false;
				cmdAceptar.Enabled = true;
				txtFolio.Enabled = false;
				txtComentario.Text = "";
				txtFolio.Text = "";
			}
		}
		
		void TxtComentarioTextChanged(object sender, EventArgs e)
		{
			if(txtComentario.Text.Length > 0)
				cmdAceptar.Enabled = true;
		}
	}
}
