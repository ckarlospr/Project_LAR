using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina
{
	public partial class FormIngresoExtra : Form
	{
		#region VARIABLES
		String FechaInicio;
		String FechaCorte;
		String IdOperador;
		String IdNom;
		System.IO.MemoryStream ms = null;
		String id_usuario = "";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		#endregion
		
		#region CONSTRUCTORES
		public FormIngresoExtra(Interfaz.FormPrincipal principal, String FechaI, String FechaC, String Alias, String id_usuario)
		{
			InitializeComponent();
			this.principal=principal;
			this.FechaCorte = FechaC;
			this.FechaInicio = FechaI;
			DatosOperador(Alias);
			txtAlias.Text=Alias;
			this.id_usuario = id_usuario;
		}
		#endregion
		
		#region LOAD - CLOSED
		void FormIngresoExtraLoad(object sender, EventArgs e)
		{
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' and tipo_empleado='OPERADOR' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
			Validar(this);
		}
		
		void FormIngresoExtraFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.extras = false;
		}
		#endregion
		
		#region INSERTAR AJUSTES
		void BtnExtrasClick(object sender, EventArgs e)
		{
			new Conexion_Servidor.Nomina.SQL_Nomina().InsertarExtra(txtDetalleIng.Text, txtImporteIng.Text, id_usuario, IdNom);
			Adaptador();
		}
		
		void CkFiniquitoCheckedChanged(object sender, EventArgs e)
		{
			if(txtAlias.Text!="")
			{
				if(ckFiniquito.Checked==true)
				{
					if(txtFiniquito.Text!=""&&(Convert.ToDouble(txtFiniquito.Text)>0))
						{
							new Conexion_Servidor.Nomina.SQL_Nomina().InsertarExtra("Finiquito", txtFiniquito.Text, id_usuario, IdNom);
							Adaptador();
						}
				}
				else if(ckFiniquito.Checked==false)
				{
					new Conexion_Servidor.Nomina.SQL_Nomina().EliminarExtra("Finiquito", IdNom);
					Adaptador();
				}
			}
		}
		#endregion
		
		#region VALIDAR
		void Validar(Interfaz.Nomina.FormIngresoExtra formExtra)
		{
			formExtra.txtAlias.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetras);
			formExtra.txtDetalleIng.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloLetrasNumerosyOtros);
			formExtra.txtFiniquito.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
			formExtra.txtImporteIng.KeyPress += new KeyPressEventHandler(Proceso.ValidarCampo.soloNumerosUnPunto);
		}
		
		void TxtFiniquitoTextChanged(object sender, EventArgs e)
		{
			if(txtFiniquito.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		
		void TxtImporteIngTextChanged(object sender, EventArgs e)
		{
			if(txtImporteIng.Text.Contains(".")==true)
				Proceso.ValidarCampo.punto = true;
			else
				Proceso.ValidarCampo.punto = false;
		}
		#endregion
		
		#region DATOS OPERADOR
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      {
				DatosOperador(txtAlias.Text);
			  }
		}
		
		void DatosOperador(String AliasOP)
		{
			IdOperador="";
			IdNom="";
			try
			{
			conn.getAbrirConexion("Select ID from OPERADOR where Alias='"+AliasOP+"'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				IdOperador = (Convert.ToInt32(conn.leer["ID"])).ToString();
			
			conn.conexion.Close();
			
			conn.getAbrirConexion("Select ID from NOMINA where fecha_inicio='"+FechaInicio+"' AND fecha_fin='"+FechaCorte+"' and IdOperador ="+IdOperador);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
				IdNom = (Convert.ToInt32(conn.leer["ID"])).ToString();
			
			conn.conexion.Close();
			}
			catch
			{}
			
			ptbImagen.Image = null;
			ptbImagen.Image = System.Drawing.Image.FromFile(@"../debug/Nomina.jpg");
			try
			{
			conn.getAbrirConexion("select Imagen from operador where ID="+IdOperador);
			conn.leer = conn.comando.ExecuteReader();
			if(conn.leer.Read())
				{
				byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
	  			ms = new System.IO.MemoryStream(imageBuffer);
	  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			catch{}
			conn.conexion.Close();
			Adaptador();
		}
		
		void Adaptador()
		{
			int contador = 0;
			dataIngreso.Rows.Clear();
			dataIngreso.ClearSelection();
			
			conn.getAbrirConexion("select I.ID, I.DETALLE, I.IMPORTE, I.ID_NOMINA " +
			                      "from INGRESO_NOMINA I, NOMINA N " +
			                      "where N.ID=I.ID_NOMINA AND N.fecha_inicio='"+FechaInicio+"' AND N.fecha_fin='"+FechaCorte+"' and N.IdOperador="+IdOperador);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataIngreso.Rows.Add();
				dataIngreso.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataIngreso.Rows[contador].Cells[1].Value = conn.leer["ID_NOMINA"].ToString();
				dataIngreso.Rows[contador].Cells[2].Value = conn.leer["DETALLE"].ToString();
				dataIngreso.Rows[contador].Cells[3].Value = conn.leer["IMPORTE"].ToString();
				dataIngreso.Rows[contador].Cells[4].Value = "X";
				++contador;
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region ELIMINAR REGISTRO
		void DataIngresoCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==4)
			{
				DialogResult boton1 = MessageBox.Show("Estas seguro de eliminar este Registro?", "Aviso Importante!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (boton1 == DialogResult.Yes)
				{
					new Conexion_Servidor.Nomina.SQL_Nomina().EliminarExtra(dataIngreso.Rows[e.RowIndex].Cells[2].Value.ToString(), IdNom);
					Adaptador();
				}
			}
		}
		#endregion
		
		#region LIMPIAR
		void TxtFiniquitoEnter(object sender, EventArgs e)
		{
			txtFiniquito.Text="";
		}
		#endregion
		
	}
}
