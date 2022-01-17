using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Especiales.Finanzas
{
	public partial class FormCompleta : Form
	{
		public FormCompleta(String id_re, FormReporte rep)
		{
			InitializeComponent();
			refReporte=rep;
			ID=id_re;
		}
		
		#region VARIABLES
		String ID;
		String consulta;
		#endregion
		
		#region INSTANCIAS
		FormReporte refReporte;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass autocomp = new Transportes_LAR.Proceso.AutoCompleClass();
		#endregion
		
		#region EVENTO LOAD
		void FormCompletaLoad(object sender, EventArgs e)
		{
			txtFaltante.Text=refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
			txtRecuperado.Text=refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
			
			txtUbica.AutoCompleteCustomSource = autocomp.AutoReconocimiento("select UBICA dato from ANTICIPOS_ESPECIALES");
			txtUbica.AutoCompleteMode = AutoCompleteMode.Suggest;
			txtUbica.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region GUARDAR
		void CmdGuardaClick(object sender, EventArgs e)
		{
			if(txtComentario.Text!="" && txtComentario.Text!="Comentario...")
			{
				if(Convert.ToDouble(txtRecuperado.Text)<=Convert.ToDouble(txtFaltante.Text))
				{
					// ***************************************************** REVISA DUPLICADO **********************************************************
					// *********************************************************************************************************************************
					// *********************************************************************************************************************************
					//
													//bool ingresa = true;
					/*double CANTIDAD = 0.0;
					double PRECIO = 0.0;
					bool FACTURADO = false;
					
					double ENTRADO = 0.0;*/
					
					/*String consult = "select * from ANTICIPOS_ESPECIALES where ID_COBRO="+dgCobros[0,dgCobros.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(consult);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						ingresa = false;
					}
					
					conn.conexion.Close();*/
					
					/*consult = "select CANT_UNIDADES, PRECIO, FACTURADO from RUTA_ESPECIAL where ID_RE="+refReporte.dgReporte[0,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(consult);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						CANTIDAD = Convert.ToDouble(conn.leer["CANT_UNIDADES"]);
						PRECIO = Convert.ToDouble(conn.leer["PRECIO"]);
						FACTURADO = ((conn.leer["FACTURADO"].ToString()!="0")?true:false);
					}
					
					conn.conexion.Close();
					
					consult = "select * from ANTICIPOS_ESPECIALES where ID_RE="+refReporte.dgReporte[0,refReporte.dgReporte.CurrentRow.Index].Value.ToString();
					conn.getAbrirConexion(consult);
					conn.leer=conn.comando.ExecuteReader();
					while(conn.leer.Read())
					{
						ENTRADO = ENTRADO + Convert.ToDouble(conn.leer["CANTIDAD"]);
					}
					
					conn.conexion.Close();
					
					if()
					{
						// aki validare los duplicados
					}*/
					
					// *********************************************************************************************************************************
					// *********************************************************************************************************************************
					// *********************************************************************************************************************************
					
					
					
					string tipo="";
					
					if(rbEfectivo.Checked==true)
						tipo="EFECTIVO";
					else if(rbDeposito.Checked==true)
						tipo="DEPOSITO";
					
					if(cbAbono.Checked==true)
					{
						String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+ID+", '"+txtRecuperado.Text+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refReporte.refPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', '"+tipo+"', '"+txtComentario.Text+"', 'ABONO', '"+txtUbica.Text+"', null) ";
						conn.getAbrirConexion(sentencia);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
					else
					{
						String sentencia = " INSERT INTO ANTICIPOS_ESPECIALES VALUES ( "+ID+", '"+txtRecuperado.Text+"', 'N/A', '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '1', '"+refReporte.refPrincipal.idUsuario+"', '"+DateTime.Now.ToString("dd/MM/yyyy")+"', '"+tipo+"', '"+txtComentario.Text+"', 'AJUSTE', '"+txtUbica.Text+"', null) ";
						conn.getAbrirConexion(sentencia);
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
						
					if(rbEfectivo.Checked==true)
						refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value=(Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(txtRecuperado.Text)).ToString();
					else
						refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value=(Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(txtRecuperado.Text)).ToString();
						
					//MessageBox.Show(Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+" + "+Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value)+" + "+Convert.ToDouble(refReporte.dgReporte[11,refReporte.dgReporte.CurrentRow.Index].Value));
					refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Value)+Convert.ToDouble(refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Value);//+Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value);
					refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value=Convert.ToDouble(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Value)-Convert.ToDouble(txtRecuperado.Text);
					
					if(Convert.ToDouble(refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value)==Convert.ToDouble(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value) && refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Red")
						refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					else if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name=="Red" && refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[6,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name!="Yellow" && refReporte.dgReporte[9,refReporte.dgReporte.CurrentRow.Index].Value.ToString()=="0")
						refReporte.dgReporte[2,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.MediumSpringGreen;
					
					
					if(refReporte.dgReporte[7,refReporte.dgReporte.CurrentRow.Index].Value.ToString()==refReporte.dgReporte[4,refReporte.dgReporte.CurrentRow.Index].Value.ToString())
						refReporte.dgReporte[5,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
					
					if(refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor.Name=="OrangeRed")
						refReporte.dgReporte[8,refReporte.dgReporte.CurrentRow.Index].Style.BackColor=Color.White;
					
					
					this.Close();
				}
				else
				{
					MessageBox.Show("La cantidad recuperada que ingreso no es correcta");
					txtRecuperado.SelectAll();
				}
			}
			else
			{
				MessageBox.Show("Ingrese en comentarios la razon.");
				txtComentario.SelectAll();
			}
		}
		#endregion
		
		#region EVENTOS TXT
		void TxtComentarioClick(object sender, EventArgs e)
		{
			txtComentario.SelectAll();
		}
		
		void TxtRecuperadoKeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || ((e.KeyChar==46) && !(txtComentario.Text.Contains("."))))
				e.Handled=false;
			else
				e.Handled=true;
		}
		
		void TxtRecuperadoClick(object sender, EventArgs e)
		{
			txtRecuperado.SelectAll();
		}
		#endregion
		
		#region EVENTO CHECKBOX
		void CbAbonoCheckedChanged(object sender, EventArgs e)
		{
			if(cbAbono.Checked==true)
			{
				txtRecuperado.Enabled=true;
			}
			else
			{
				txtRecuperado.Enabled=false;
				txtRecuperado.Text=txtFaltante.Text;
			}
		}
		#endregion
		
		void RbEfectivoCheckedChanged(object sender, EventArgs e)
		{
			if(rbEfectivo.Checked==true)
			{
				txtUbica.Text="";
				txtUbica.Enabled=false;
			}
			else
			{
				txtUbica.Enabled=true;
			}
		}
	}
}
