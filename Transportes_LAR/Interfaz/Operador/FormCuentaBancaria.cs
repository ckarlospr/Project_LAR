using System;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
	
namespace Transportes_LAR.Interfaz.Operador
{
	public partial class FormCuentaBancaria : Form
	{
		int id_usuario;
		int x = 0;
		String id_cuenta = "";
		System.IO.MemoryStream ms = null;
		
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		Interfaz.FormPrincipal principal = null;
		public List<Interfaz.Nomina.Dato.Nomina> listNomina = null;
		
		public FormCuentaBancaria(Interfaz.FormPrincipal principal, int id_u)
		{
			InitializeComponent();
			this.principal = principal;
			id_usuario = id_u;
		}
		
		void FormCuentaBancariaLoad(object sender, EventArgs e)
		{
			AdaptadorOperador();
			txtAlias.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR where Estatus='1' ", "Alias");
			txtAlias.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtAlias.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
		
		void AdaptadorOperador()
		{
			dtOperador.DataSource = new Conexion_Servidor.Operador.SQL_Operador().getTabla("select O.ID, O.alias as Alias_Op from OPERADOR O where Estatus='1' and Alias!='Admvo' order by alias");
		}
		
		void DtOperadorCellEnter(object sender, DataGridViewCellEventArgs e)
		{
			int x = 0;
			id_cuenta = "";
			if(e.RowIndex>-1)
			{
				x = dtOperador.CurrentRow.Index;
				this.x = x;
				txtAlias.Text = dtOperador.Rows[e.RowIndex].Cells[1].Value.ToString();
				id_cuenta = new Transportes_LAR.Conexion_Servidor.Cuenta.SQL_Cuenta().ReturnIdCuenta(dtOperador.Rows[e.RowIndex].Cells[0].Value.ToString());
				txtCuentaBancaria.Text = new Transportes_LAR.Conexion_Servidor.Cuenta.SQL_Cuenta().ReturnNumero(dtOperador.Rows[e.RowIndex].Cells[0].Value.ToString());
				DatosOperadorPDF(x);
			}
		}
		
		public void DatosOperadorPDF(int x)
		{	
			ptbImagen.Image = System.Drawing.Image.FromFile(@"../debug/Nomina.jpg");
			try
			{
			conn.getAbrirConexion("select Imagen from operador where ID="+dtOperador.Rows[x].Cells[0].Value);
			conn.leer = conn.comando.ExecuteReader();
			while(conn.leer.Read())
				{
					byte[] imageBuffer = (byte[]) conn.leer["Imagen"];
		  			ms = new System.IO.MemoryStream(imageBuffer);
		  			ptbImagen.Image = System.Drawing.Image.FromStream(ms);
				}
			}
			catch{}
			conn.conexion.Close();
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			string sentencia = "";
			if(id_cuenta=="0"||id_cuenta==null)
			{
				sentencia = "insert into CUENTA_BANCARIA (NUMERO, FECHA, HORA, ID_USUARIO, ID_OPERADOR) values ('"+txtCuentaBancaria.Text+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("hh:mm:ss")+"', "+id_usuario.ToString()+", "+dtOperador.Rows[x].Cells[0].Value.ToString()+")";
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron insertados correctamente");
				mensaje.Show();
			}
			else if(id_cuenta!="0"&&id_cuenta!=null)
			{
				sentencia = "UPDATE CUENTA_BANCARIA SET Numero='"+txtCuentaBancaria.Text+"' where ID="+id_cuenta;
				conn.getAbrirConexion(sentencia);
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				
				Interfaz.FormMensaje mensaje = new Interfaz.FormMensaje("Los datos fueron actualizados correctamente");
				mensaje.Show();
			}
		}
		
		void TxtAliasKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
		      {
				    for(int x=0; x<dtOperador.Rows.Count; x++)
					{
				    	if(dtOperador.Rows[x].Cells[1].Value.ToString()==txtAlias.Text)
				    	{
							if(x>0)
								dtOperador.Rows[x-1].Selected = false;

							dtOperador.ClearSelection();
							dtOperador.Rows[x].Selected = true;
							this.x = x;
							DatosOperadorPDF(x);
				    	}
				    }				
				}
		}
		
		void TxtAliasEnter(object sender, EventArgs e)
		{
			txtAlias.Text = "";
		}
		
		void FormCuentaBancariaFormClosing(object sender, FormClosingEventArgs e)
		{
			principal.cuentabancaria = false;
		}
	}
}
