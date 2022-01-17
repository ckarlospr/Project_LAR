using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormTerminoFact : Form
	{
		public FormTerminoFact(Interfaz.Nomina.Especiales.FormCuentasEsp formFact)
		{
			InitializeComponent();
			refPrincipal = formFact;
		}
		
		#region AUTOCOMPLETE Y EVENTO LOAD
		private Interfaz.Nomina.Especiales.FormCuentasEsp refPrincipal = null; 
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		bool varias=false;
		
		void FormTerminoFactLoad(object sender, EventArgs e)
		{
			if(refPrincipal.dgEspeciales.SelectedRows.Count==1 && Convert.ToInt16(refPrincipal.dgEspeciales[6,refPrincipal.dgEspeciales.CurrentRow.Index].Value)>1)
			{
				cbVarias.Enabled=true;
			}
			
			txtDato.AutoCompleteCustomSource = auto.AutoReconocimiento("select NUMERO_FACT dato from COBRO_ESPECIAL");
			txtDato.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtDato.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		#endregion
		
		#region VALIDACION DE COMPONENTES
		private void getCargarValidacionCampos(FormTerminoFact formDat)
		{
			formDat.txtDato.KeyPress	+= new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumeros);
		}
		#endregion
		
		#region EVENTO BOTON
		void CmdGuardrClick(object sender, EventArgs e)
		{
			if(txtDato.Text!="" || dgFacturas.Rows.Count>0)
			{
				if(varias==true)
				{
					refPrincipal.guardaDatos("VARIOS", false);
					
					for(int x=0; x<dgFacturas.Rows.Count; x++)
					{
						refPrincipal.guardaVarios(dgFacturas[3,x].Value.ToString());
						
						conn.getAbrirConexion("update COBRO_ESPECIAL set NUMERO_FACT='"+dgFacturas[3,x].Value.ToString().ToUpper()+"' where ID="+dgFacturas[0,x].Value.ToString());
						conn.comando.ExecuteNonQuery();
						conn.conexion.Close();
					}
				}
				else
				{
					refPrincipal.guardaDatos(txtDato.Text, true);
				}
				
				this.Close();
			}
			else
			{
				MessageBox.Show("Ingrese dato de factura.");
			}
		}
		#endregion
		
		void CbVariasCheckedChanged(object sender, EventArgs e)
		{
			if(cbVarias.Checked==true)
			{
				if(aceptado()==true)
				{
					getViajes();
					this.Size = new System.Drawing.Size(359, 278);
					txtDato.Text="";
					txtDato.Enabled=false;
					varias=true;
					
					dgFacturas.ClearSelection();
				}
				else
				{
					MessageBox.Show("No esta en flujo el servicio para esta acción. Esperar.");
					cbVarias.Checked=false;
				}
			}
			else
			{
				this.Size = new System.Drawing.Size(359, 117);
				
				txtDato.Enabled=true;
				varias=false;
				dgFacturas.Rows.Clear();
			}
		}
		
		public bool aceptado()
		{
			bool acepta=false;
			
			String consulta = "select COUNT(ID) cant from COBRO_ESPECIAL where ID_RE="+refPrincipal.dgEspeciales[0,refPrincipal.dgEspeciales.CurrentRow.Index].Value.ToString();
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				if(conn.leer["cant"].ToString()==refPrincipal.dgEspeciales[6,refPrincipal.dgEspeciales.CurrentRow.Index].Value.ToString())
					acepta=true;
			}
			conn.conexion.Close();
			
			return acepta;
		}
		
		void getViajes()
		{
			String consulta = "select * from COBRO_ESPECIAL C, OPERADOR O where C.ID_OP=O.ID and C.ID_RE="+refPrincipal.dgEspeciales[0,refPrincipal.dgEspeciales.CurrentRow.Index].Value.ToString();
			int x=0;
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				x++;
				dgFacturas.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString(), x.ToString());
			}
			conn.conexion.Close();
		}
	}
}
