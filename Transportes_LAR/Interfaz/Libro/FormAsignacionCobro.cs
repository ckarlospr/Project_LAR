using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormAsignacionCobro : Form
	{
		public FormAsignacionCobro(FormValidacionEsp valEsp, int tip)
		{
			InitializeComponent();
			formValidacion=valEsp;
			TIPO=tip;
		}
		
		#region VARIABLES
		int TIPO = 0;
		String tipoCobro="OPERADOR";
		#endregion
		
		#region REFERENCIAS
		FormValidacionEsp formValidacion = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region VALIDACION DE COMPONENTES
		private void getCargarValidacionCampos(FormAsignacionCobro formDat)
		{
			formDat.txtSaldo.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
			formDat.txtTelefono.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloNumeros);
		}
		#endregion
		
		#region EVENTO LOAD
		void FormAsignacionCobroLoad(object sender, EventArgs e)
		{
			txtCobro.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' AND (tipo_empleado='OPERADOR' OR tipo_empleado='Externo')");
			txtCobro.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtCobro.AutoCompleteSource = AutoCompleteSource.CustomSource;
			if(TIPO==2)
			{
				 datos();
			}
			
			if(Convert.ToDouble(formValidacion.dgDatos[7, formValidacion.dgDatos.CurrentRow.Index].Value)==0.00)
			{
				rbPagoAnt.Checked=true;
			}
			
			getCargarValidacionCampos(this);
		}
		#endregion
		
		#region EVENTOS RADIOBUTONS
		void RbDepositoCheckedChanged(object sender, EventArgs e)
		{
			if(rbDeposito.Checked==true)
			{
				txtCobro.Text="Deposito";
				txtTelefono.Text=formValidacion.dgDatos[14, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro="DEPOSITO";
			}
			/*else if(rbDeposito.Checked==false)
			{
				txtCobro.Text="";
				txtTelefono.Text="N/A";
			}*/
		}
		
		void RbPagoAntCheckedChanged(object sender, EventArgs e)
		{
			if(rbPagoAnt.Checked==true)
			{
				txtCobro.Text="PAGADO";
				txtTelefono.Text=formValidacion.dgDatos[14, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro="PAGADO";
				txtCobro.Focus();
			}
			/*else if(rbPagoAnt.Checked==false)
			{
				txtCobro.Text="";
			}*/
		}
		
		void RbFactCobroCheckedChanged(object sender, EventArgs e)
		{
			if(rbFactCobro.Checked==true)
			{
				txtCobro.Text="FACTURA A COBRO";
				txtTelefono.Text=formValidacion.dgDatos[14, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro="FACTURA";
				txtCobro.Focus();
			}
			/*else if(rbFactCobro.Checked==false)
			{
				txtCobro.Text="";
			}*/
		}
		
		void RbOperadorCheckedChanged(object sender, EventArgs e)
		{
			if(rbOperador.Checked==true)
			{
				txtCobro.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias dato from OPERADOR where Estatus='1' AND (tipo_empleado='OPERADOR' OR tipo_empleado='Externo')");
				txtCobro.AutoCompleteMode =AutoCompleteMode.Suggest;
				txtCobro.AutoCompleteSource = AutoCompleteSource.CustomSource;
				
				txtCobro.Text=formValidacion.dgDatos[13, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				txtTelefono.Text=formValidacion.dgDatos[14, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
				tipoCobro="OPERADOR";
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
		#endregion
		
		#region GET TELEFONO
		void TxtCobroKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.ToString()=="Return")
			{
				String consul = "select T.Numero from TELEFONOCHOFER T, OPERADOR O where T.Descripcion='Red LAR' and T.ID_Chofer=O.ID AND O.Alias='"+txtCobro.Text+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					txtTelefono.Text=conn.leer["Numero"].ToString();
				}
				
				conn.conexion.Close();
			}
		}
		#endregion
		
		public void datos()
		{
			txtCobro.Text=formValidacion.dgDatos[13, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
			txtTelefono.Text=formValidacion.dgDatos[14, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
			txtSaldo.Text=formValidacion.dgDatos[7, formValidacion.dgDatos.CurrentRow.Index].Value.ToString();
		}		
		
		void CmdAceptarClick(object sender, EventArgs e)
		{
			bool Continua=true;
			if(Convert.ToDouble(txtSaldo.Text)!=Convert.ToDouble(formValidacion.dgDatos[7, formValidacion.dgDatos.CurrentRow.Index].Value))
			{
				if(txtComentario.Text=="")
				{
					MessageBox.Show("Justifique el cambio de saldo en comentarios.");
					Continua=false;
				}
			}
			
			if(Continua)
			{
				if(txtTelefono.Text!="" && !(txtTelefono.Text.Contains("00000000")))
				{
					if(TIPO==1)
					{
						formValidacion.setValidacion(tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text);
					}
					else if(TIPO==2)
					{
						formValidacion.dgDatos[13, formValidacion.dgDatos.CurrentRow.Index].Value=txtCobro.Text;
						formValidacion.dgDatos[19, formValidacion.dgDatos.CurrentRow.Index].Value=tipoCobro;
						formValidacion.dgDatos[7, formValidacion.dgDatos.CurrentRow.Index].Value=txtSaldo.Text;
						
						if(formValidacion.guardaValidacion(formValidacion.dgDatos[3,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[1,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[2,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text, formValidacion.dgDatos[0,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), formValidacion.dgDatos[21,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), txtSaldo.Text, formValidacion.dgDatos[24,formValidacion.dgDatos.CurrentRow.Index].Value.ToString()))
						{
							formValidacion.dgDatos[15,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
							formValidacion.dgDatos[15,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
							formValidacion.dgDatos[17,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
							formValidacion.dgDatos[17,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
							
							if(formValidacion.cbValidados.Checked==false)
							{
								formValidacion.dgDatos.Rows.RemoveAt(formValidacion.dgDatos.CurrentRow.Index);
							}
						}
					}
					this.Close();
					Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron guardados correctamente");
				}
				else
				{
					DialogResult rs2 = MessageBox.Show("¿Desea guardar sin numero de telefono?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (DialogResult.Yes==rs2)
					{
						if(TIPO==1)
						{
							formValidacion.setValidacion(tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text);
						}
						else if(TIPO==2)
						{
							formValidacion.dgDatos[13, formValidacion.dgDatos.CurrentRow.Index].Value=txtCobro.Text;
							formValidacion.dgDatos[19, formValidacion.dgDatos.CurrentRow.Index].Value=tipoCobro;
							formValidacion.dgDatos[7, formValidacion.dgDatos.CurrentRow.Index].Value=txtSaldo.Text;
							
							if(formValidacion.guardaValidacion(formValidacion.dgDatos[3,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[1,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(),formValidacion.dgDatos[2,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), tipoCobro, txtCobro.Text, txtComentario.Text, txtTelefono.Text, formValidacion.dgDatos[0,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), formValidacion.dgDatos[21,formValidacion.dgDatos.CurrentRow.Index].Value.ToString(), txtSaldo.Text, formValidacion.dgDatos[24,formValidacion.dgDatos.CurrentRow.Index].Value.ToString()))
							{
								formValidacion.dgDatos[15,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
								formValidacion.dgDatos[15,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
								formValidacion.dgDatos[17,formValidacion.dgDatos.CurrentRow.Index].Value="SI";
								formValidacion.dgDatos[17,formValidacion.dgDatos.CurrentRow.Index].Style.BackColor=Color.SpringGreen;
								
								if(formValidacion.cbValidados.Checked==false)
								{
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
	}
}
