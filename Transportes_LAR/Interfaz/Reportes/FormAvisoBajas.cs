using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes
{
	public partial class FormAvisoBajas : Form
	{
		public FormAvisoBajas(Interfaz.FormPrincipal principal)
		{
			InitializeComponent();
			princ=principal;
		}
		
		#region VARIABLES
		public Interfaz.FormPrincipal princ;
		String fechaInicio="";
		String fechaFin="";
		#endregion
		
		#region INSTANCIAS
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region RANGOS
		public void getFechas()
		{
			fechaFin = DateTime.Now.ToString("dd/MM/yyyy");
						
			fechaInicio = DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy");
			
			getOperadores();
		}
		#endregion
		
		void FormAvisoBajasLoad(object sender, EventArgs e)
		{
			getDatosFaltantes();
			getDormidas();
		}
		
		#region CARDEX
		public void getDatos(int fila)
		{
			dgCardex.Rows.Clear();
			String estado="";
			
			String consulta = "select H.ID_HO, O.Alias, H.FECHA, H.HORA, H.TURNO, H.ESTATUS, H.DESCRIPCION, U.usuario from HISTORIALOPERADOR H, OPERADOR O, usuario U where H.ID_O=O.ID and U.id_usuario=H.ID_USUARIO AND H.ESTATUS!='A' AND H.ESTATUS!='G' AND H.ESTATUS!='E' and O.ID="+dgOperador[0,fila].Value.ToString()+" and H.FECHA between '"+fechaInicio+"' and '"+fechaFin+"' ";
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				int band=0;
				
				if(conn.leer["ESTATUS"].ToString()=="D")
					estado="Dormida";
				if(conn.leer["ESTATUS"].ToString()=="P")
					estado="Permiso";
				if(conn.leer["ESTATUS"].ToString()=="O")
					estado="Otro";
				if(dgCardex.Rows.Count>1)
				{
					for(int x=0; x<dgCardex.Rows.Count; x++)
					{
						if(dgCardex[1,x].Value.ToString()==conn.leer["Alias"].ToString() && dgCardex[3,x].Value.ToString()==conn.leer["FECHA"].ToString().Substring(0,10) && dgCardex[6,x].Value.ToString()==estado)
						{
							band=1;
						}
					}
				}
				
				if(band==0)
				{
					dgCardex.Rows.Add(conn.leer["ID_HO"].ToString(), conn.leer["Alias"].ToString(), /*conn.leer["Numero"].ToString()*/ "", conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["HORA"].ToString(), conn.leer["TURNO"].ToString(), estado, conn.leer["DESCRIPCION"].ToString(), conn.leer["usuario"].ToString());
				}
			}
			conn.conexion.Close();
			
			getDatosTaller(fila);
		}
		
		public void getDatosTaller(int fila)
		{
			conn.getAbrirConexion("select H.ID_HV, O.Alias, V.Numero, H.FECHA, H.HORA, H.turno, 'T' ESTATUS, H.DESCRIPCION, U.usuario from HISTORIALVEHICULO H, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO and H.ID_UNIDAD=V.ID and H.ESTATUS='Taller' and O.ID="+dgOperador[0,fila].Value.ToString()+" and H.FECHA between '"+fechaInicio+"' and '"+fechaFin+"' order by H.FECHA, O.Alias, H.TURNO");
						
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				int band=0;
				
				for(int x=0; x<dgCardex.Rows.Count; x++)
				{
					if(dgCardex[0,x].Value.ToString()==conn.leer["Alias"].ToString() && dgCardex[2,x].Value.ToString()==conn.leer["FECHA"].ToString().Substring(0,10) && dgCardex[6,x].Value.ToString()=="Taller")
					{
						band=1;
					}
				}
				
				if(band==0)
				{
					dgCardex.Rows.Add(conn.leer["ID_HV"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["HORA"].ToString(), conn.leer["TURNO"].ToString(), "Taller", conn.leer["DESCRIPCION"].ToString(), conn.leer["usuario"].ToString());
				}
			}
			conn.conexion.Close();
		}
		#endregion
		
		public void getOperadores()
		{
			dgOperador.Rows.Clear();
			
			conn.getAbrirConexion("select O.ID, O.Alias, O.CURP from OPERADOR O, OPERACION_OPERADOR OO, HISTORIALOPERADOR H where O.ID=OO.id_operador and O.ID=H.ID_O and O.tipo_empleado='OPERADOR' and O.Estatus='1' and O.ID not in (select OO.id_operador from OPERACION O , OPERACION_OPERADOR OO where O.id_operacion=OO.id_operacion and O.fecha between '"+fechaInicio+"' and '"+fechaFin+"' group by OO.id_operador) group by O.ID, O.Alias, O.CURP");
						
			conn.leer=conn.comando.ExecuteReader();
			
			while(conn.leer.Read())
			{
				dgOperador.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString(), conn.leer["CURP"].ToString());
			}
			conn.conexion.Close();
			
			dgOperador.ClearSelection();
		}
		
		void DgOperadorCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex!=-1)
			{
				getDatos(e.RowIndex);
				this.Size = new System.Drawing.Size(900,460);
			}
		}
		
		void getRegresos()
		{
			for(int x=0; x<dgCardex.Rows.Count; x++)
			{
				if(dgCardex[6,x].Value.ToString()=="Dormida" || dgCardex[6,x].Value.ToString()=="Permiso")
				{
					conn.getAbrirConexion("select DIA_REG, TURNO_REG from DETALLE_CARDEX WHERE ID_H="+dgCardex[0,x].Value.ToString());
						
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						dgCardex[9,x].Value=conn.leer["DIA_REG"].ToString();
					}
					conn.conexion.Close();
				}
			}
		}
		
		#region
		void getDatosFaltantes()
		{
			dgDocument.Rows.Clear();
			conn.getAbrirConexion("select * from OPERADOR where indicador='INCOMPLETO' and tipo_empleado='OPERADOR' and Estatus='1'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgDocument.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Alias"].ToString(), conn.leer["Nombre"].ToString(), conn.leer["Apellido_Pat"].ToString(), conn.leer["Apellido_Mat"].ToString());
			}
			conn.conexion.Close();
			dgDocument.ClearSelection();
			
			dgEvalua.Rows.Clear();
			conn.getAbrirConexion("select * from OPERADOR where indicador='VALIDA' and tipo_empleado='OPERADOR'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgEvalua.Rows.Add(conn.leer["ID"].ToString(), conn.leer["Nombre"].ToString()+" "+ conn.leer["Apellido_Pat"].ToString(), conn.leer["Apellido_Pat"].ToString(), conn.leer["Apellido_Pat"].ToString(), conn.leer["Apellido_Mat"].ToString());
			}
			conn.conexion.Close();
			dgEvalua.ClearSelection();
		}
		#endregion
		
		#region EVENTOS DOBLE CLICK
		void DgDocumentDoubleClick(object sender, EventArgs e)
		{
			if(dgDocument.SelectedRows.Count>0)
			{
				Interfaz.Operador.FormOperador cambios = new Interfaz.Operador.FormOperador(princ,dgDocument[0,dgDocument.CurrentRow.Index].Value.ToString());
				cambios.ShowDialog();
				cambios.tabControl2.SelectedTab=cambios.tpDocumentos;
				getDatosFaltantes();
			}
		}
		
		void DgEvaluaDoubleClick(object sender, EventArgs e)
		{
			if(dgEvalua.SelectedRows.Count>0)
			{
				new Interfaz.Operador.FormDetalleBaja(dgEvalua[0,dgEvalua.CurrentRow.Index].Value.ToString(), dgEvalua[2,dgEvalua.CurrentRow.Index].Value.ToString(), dgEvalua[3,dgEvalua.CurrentRow.Index].Value.ToString(), dgEvalua[4,dgEvalua.CurrentRow.Index].Value.ToString()).ShowDialog();
				getDatosFaltantes();
			}
		}
		#endregion
		
		void CmdBajaClick(object sender, EventArgs e)
		{
			if(dgOperador.CurrentRow.Index>-1)
			{
				String consulta = "update operador set Estatus='0', indicador='VALIDA', alias='BAJA_"+dgOperador[1,dgOperador.CurrentRow.Index].Value.ToString()+"_"+dgOperador[0,dgOperador.CurrentRow.Index].Value.ToString()+"' where ID="+dgOperador[0,dgOperador.CurrentRow.Index].Value.ToString();
			
				conn.getAbrirConexion(consulta); 
				conn.comando.ExecuteNonQuery(); 
				conn.conexion.Close();
				
				getOperadores();
				dgOperador.ClearSelection();
			}
		}
		
		void getDormidas()
		{
			String consulta="select O.Alias, V.Numero, H.FECHA, H.HORA, H.TURNO, H.ESTATUS, H.DESCRIPCION, U.usuario from HISTORIALOPERADOR H, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U where H.ID_O=O.ID and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO and H.FECHA between '"+DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy")+"' and '"+DateTime.Now.ToString("dd/MM/yyyy")+"' and H.ESTATUS='D' order by H.FECHA, O.Alias, H.TURNO";
			//String consulta="select O.Alias, V.Numero, H.FECHA, H.HORA, H.TURNO, H.ESTATUS, H.DESCRIPCION, U.usuario from HISTORIALOPERADOR H, OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V, usuario U where H.ID_O=O.ID and O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and U.id_usuario=H.ID_USUARIO and H.FECHA='"+DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy")+"'  and H.ESTATUS='D' order by H.FECHA, O.Alias, H.TURNO";
			
			dgCardex2.Rows.Clear();
			String estado="";
			
			conn.getAbrirConexion(consulta);
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				if(conn.leer["ESTATUS"].ToString()=="D")
					estado="Dormida";
				
				dgCardex2.Rows.Add(conn.leer["Alias"].ToString(), conn.leer["Numero"].ToString(), conn.leer["FECHA"].ToString().Substring(0,10), conn.leer["HORA"].ToString(), conn.leer["TURNO"].ToString(), estado, conn.leer["DESCRIPCION"].ToString(), conn.leer["usuario"].ToString());
				
			}
			conn.conexion.Close();
		}
	}
}
