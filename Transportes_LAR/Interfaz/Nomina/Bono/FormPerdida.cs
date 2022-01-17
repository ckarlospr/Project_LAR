using System;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Nomina.Bono
{
	public partial class FormPerdida : Form
	{
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		Interfaz.FormPrincipal principal = null;
		DateTimePicker dtInicio = new DateTimePicker();
		DateTimePicker dtCorte = new DateTimePicker();
		DataGridView dataBonos = new DataGridView();
		#endregion
		
		#region VARIABLES
		String idO = "0";
		String ID = "0";
		String nombre = "";
		bool swicth = false;
		String tipoCausa;
		int row;
		String ID_HISTORIAL = "";
		#endregion
		
		#region CONSTRUCTORES
		public FormPerdida()
		{
			InitializeComponent();
		}
		
		public FormPerdida(String Usuario, String ID_O, bool apagador, 
		                   Interfaz.FormPrincipal principal, String ID,
		                   DateTimePicker dtInicio, DateTimePicker dtCorte, 
		                   DataGridView dataBonos, int row)
		{
			InitializeComponent();
			this.nombre = Usuario;
			this.idO = ID_O;
			this.ID = ID;
			this.swicth = apagador;
			this.principal=principal;
			this.dtInicio = dtInicio;
			this.dtCorte = dtCorte;
			this.dataBonos = dataBonos;
			this.row = row;
		}
		#endregion
		
		#region EVENTOS BOTONES
		void CmdNuevoClick(object sender, EventArgs e)
		{
			if(swicth==false)
			{
				if(txtNota.Text!=""&&tipoCausa!="")
				{
					conn.getAbrirConexion("UPDATE BONO_OPERADOR SET DESCRIPCION='"+txtNota.Text+"' where ID="+ID);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					conn.getAbrirConexion("UPDATE NUEVO_HISTORIAL_BONO_OPERADOR SET ESTATUS='0', MOTIVO='"+txtNota.Text+"', ID_USUARIO='"+principal.idUsuario+"', TIPO='"+tipoCausa+"' where FECHA_INICIO='"+dtInicio.Value.ToString("dd-MM-yyyy")+"' and FECHA_FIN='"+dtCorte.Value.ToString("dd-MM-yyyy")+"' and ID_O="+idO);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();	
					txtNota.Text = "";
					this.Hide();
				}
				else
					MessageBox.Show("Faltan Campos por llenar!!!", "Aviso Importante!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
				this.Hide();
		}
		#endregion
		
		#region LOAD
		void FormComentariosLoad(object sender, EventArgs e)
		{
			txtNota.Text = "";
			lblRealizado.Text = nombre;
			lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
			if(new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaBono(idO, dtInicio.Value.ToString("dd-MM-yyyy"), dtCorte.Value.ToString("dd-MM-yyyy"))==false)
			{
				conn.getAbrirConexion("insert into NUEVO_HISTORIAL_BONO_OPERADOR values ("+idO+", '"+dataBonos.Rows[row].Cells[3].Value+"', '"+dataBonos.Rows[row].Cells[4].Value+"', '"+dataBonos.Rows[row].Cells[5].Value+"', '"+dataBonos.Rows[row].Cells[6].Value+"', '"+dtInicio.Value.ToString("dd-MM-yyyy")+"', '"+dtCorte.Value.ToString("dd-MM-yyyy")+"', '"+txtNota.Text+"', '"+tipoCausa+"', '0', '"+principal.idUsuario+"', '0.00')");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
			ID_HISTORIAL = new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().Traer_ID(idO, dtInicio.Value.ToString("dd-MM-yyyy"), dtCorte.Value.ToString("dd-MM-yyyy"));
			CargarPerdidasBono();
		}
		#endregion
		
		void Adaptador()
		{
			int contador = 0;
			dataPerdidas.Rows.Clear();
			dataPerdidas.ClearSelection();
			String sentencia = "select ID, ID_HISTORIAL, TIPO " +
								"from PERDIDA_BONO " +
								"where ID_HISTORIAL="+ID_HISTORIAL;
			conn.getAbrirConexion(sentencia);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dataPerdidas.Rows.Add();
				dataPerdidas.Rows[contador].Cells[0].Value = conn.leer["ID"].ToString();
				dataPerdidas.Rows[contador].Cells[1].Value = conn.leer["ID_HISTORIAL"].ToString();
				dataPerdidas.Rows[contador].Cells[2].Value = conn.leer["TIPO"].ToString();
				++contador;
			}
			conn.conexion.Close();
		}
		
		#region SELECCION CAUSA
		void CkOtroCheckedChanged(object sender, EventArgs e)
		{
			tipoCausa = "";
			if(ckDormida.Checked==true)
			{
				tipoCausa = ckDormida.Text;
				if(new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa)==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckDormida.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
			
			if(ckEspeciales.Checked==true)
			{
				tipoCausa = ckEspeciales.Text;
				if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa))==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckEspeciales.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
			
			if(ckCombustible.Checked==true)
			{
				tipoCausa = ckCombustible.Text;
				if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa))==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckCombustible.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
			
			if(ckMalaActitud.Checked==true)
			{
				tipoCausa = ckMalaActitud.Text;
				if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa))==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckMalaActitud.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
			
			if(ckUniforme.Checked==true)
			{
				tipoCausa = ckUniforme.Text;
				if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa))==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckUniforme.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
			
			if(ckChoque.Checked==true)
			{
				tipoCausa = ckChoque.Text;
				if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa))==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckChoque.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
			
			if(ckTaxi.Checked==true)
			{
				tipoCausa = ckTaxi.Text;
				if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa))==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckTaxi.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
			
			if(ckExceso.Checked==true)
			{
				tipoCausa = ckExceso.Text;
				if(new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, tipoCausa)==false)
				{
					conn.getAbrirConexion("insert into PERDIDA_BONO values ("+ID_HISTORIAL+", '"+tipoCausa+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToString("HH:mm:ss")+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				Adaptador();
			}
			else
			{
				tipoCausa = ckExceso.Text;
				conn.getAbrirConexion("DELETE FROM PERDIDA_BONO WHERE Id_Historial="+ID_HISTORIAL+" and Tipo='"+tipoCausa+"'");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
				Adaptador();
			}
		}
		
		void CargarPerdidasBono()
		{
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckDormida.Text))==true)
					ckDormida.Checked = true;
			
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckUniforme.Text))==true)
					ckUniforme.Checked = true;
			
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckExceso.Text))==true)
					ckEspeciales.Checked = true;
			
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckEspeciales.Text))==true)
					ckEspeciales.Checked = true;
			
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckCombustible.Text))==true)
					ckCombustible.Checked = true;
			
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckTaxi.Text))==true)
					ckTaxi.Checked = true;
			
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckMalaActitud.Text))==true)
					ckMalaActitud.Checked = true;
			
			if((new Transportes_LAR.Conexion_Servidor.Nomina.SQL_Bono().ExistenciaPerdida(ID_HISTORIAL, ckChoque.Text))==true)
					ckChoque.Checked = true;
		}
		#endregion
	}
}
