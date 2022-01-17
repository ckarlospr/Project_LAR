using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Operador.Modificar
{
	public partial class FormModificaOp : Form
	{
		public FormModificaOp(Int64 id_Operador)
		{
			InitializeComponent();
			id_Ope = id_Operador;
		}
		
		#region VARIABLES
		public Int64 id_Ope;
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormModificaOpLoad(object sender, EventArgs e)
		{
			cmbTipo.SelectedIndex=0;
			getDatos();
		}
		#endregion
		
		#region GETDATOS
		void getDatos()
		{
			conn.getAbrirConexion("select O.Municipio, O.Colonia, O.Calle, O.Num_Interior from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.ID="+id_Ope);
			
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				txtMunicipio.Text		=conn.leer["Municipio"].ToString().ToUpper();
				txtColonia.Text			=conn.leer["Colonia"].ToString().ToUpper();
				txtCalle.Text			=conn.leer["Calle"].ToString().ToUpper();
				txtNumero.Text		 	=conn.leer["Num_Interior"].ToString();
			}
			conn.conexion.Close();
			
			conn.getAbrirConexion("select * from TELEFONOCHOFER where ID_Chofer="+id_Ope);
			
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgNumeros.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Tipo"].ToString().ToUpper(), conn.leer["Numero"].ToString(), conn.leer["Descripcion"].ToString().ToUpper());
			}
			conn.conexion.Close();
			dgNumeros.ClearSelection();
			
		}
		#endregion
		
		#region EVENTO DE BOTONES
		void CmdAgregarClick(object sender, EventArgs e)
		{
			if(txtNumTelefono.Text!="" && dgNumeros.SelectedRows.Count==0)
			{
				dgNumeros.Rows.Add("", cmbTipo.Text, txtNumTelefono.Text, txtDescripcion.Text);
				
				cmbTipo.SelectedIndex=1;
				txtNumTelefono.Text="";
				txtDescripcion.Text="";
			}
			else
			{
				dgNumeros[1,dgNumeros.CurrentRow.Index].Value=cmbTipo.Text;
				dgNumeros[2,dgNumeros.CurrentRow.Index].Value=txtNumTelefono.Text;
				dgNumeros[3,dgNumeros.CurrentRow.Index].Value=txtDescripcion.Text;
				
				cmbTipo.SelectedIndex=1;
				txtNumTelefono.Text="";
				txtDescripcion.Text="";
			}
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			dgNumeros.Rows.RemoveAt(dgNumeros.CurrentRow.Index);
		}
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			dgNumeros.ClearSelection();
			cmbTipo.SelectedIndex=1;
			txtNumTelefono.Text="";
			txtDescripcion.Text="";
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			guardaDatos();
		}
		#endregion
		
		#region EVENTO CELL CLICK
		void DgNumerosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				for(int x=0; x<cmbTipo.Items.Count; x++)
				{
					if(cmbTipo.Items[x].ToString()==dgNumeros[1,dgNumeros.CurrentRow.Index].Value.ToString().ToUpper())
					{
						cmbTipo.SelectedIndex=x;
					}
				}
				
				txtNumTelefono.Text=dgNumeros[2,dgNumeros.CurrentRow.Index].Value.ToString();
				txtDescripcion.Text=dgNumeros[3,dgNumeros.CurrentRow.Index].Value.ToString();
				
				cmdEliminar.Enabled=true;
			}
		}
		#endregion
		
		#region EVENTO GUARDAR
		void guardaDatos()
		{
			conn.getAbrirConexion("update OPERADOR set Municipio='"+txtMunicipio.Text+"' , Colonia='"+txtColonia.Text+"' , Calle='"+txtCalle.Text+"' , Num_Interior='"+txtNumero.Text+"' where ID="+id_Ope);
			conn.comando.ExecuteNonQuery();
			conn.conexion.Close();
			
			String conssulta;
			
			for(int x=0; x<dgNumeros.Rows.Count; x++)
			{
				if(dgNumeros[0,x].Value.ToString()!="")
				{
					conssulta = "UPDATE TELEFONOCHOFER set Tipo='"+dgNumeros[1,x].Value.ToString()+"', Numero='"+dgNumeros[2,x].Value.ToString()+"', Descripcion='"+dgNumeros[3,x].Value.ToString()+"' where ID="+dgNumeros[0,x].Value.ToString();
					conn.getAbrirConexion(conssulta);
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
				else
				{
					conn.getAbrirConexion("insert into TELEFONOCHOFER values ('"+dgNumeros[1,x].Value.ToString()+"', '"+dgNumeros[2,x].Value.ToString()+"', '"+dgNumeros[3,x].Value.ToString()+"', '"+id_Ope+"')");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
				}
			}
			
			this.Close();
		}
		#endregion
	}
}
