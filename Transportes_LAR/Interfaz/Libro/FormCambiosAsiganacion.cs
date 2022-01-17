using System;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Libro
{
	public partial class FormCambiosAsiganacion : Form
	{
		public FormCambiosAsiganacion(FormValidacionEsp refValidacion, int tipo)
		{
			InitializeComponent();
			
			refValida=refValidacion;
			TIPO=tipo;
		}
		
		#region VARIABLES	
		String telefono = "0000000";
		
		int TIPO=0;
		
		Int64 idOperadoEnt = 0 ;
		Int64 idOperadoSal = 0 ;
		
		Int64 id_vehiculo_Ent = 0;
		Int64 id_vehiculo_sal = 0;
		
		String tipoVehiculoEnt = "";
		String tipoVehiculoSal = "";
		
		Int64 idOperacionEnt = 0 ;
		Int64 idOperacionSal = 0 ;
		
		Int64 idUnidad = 0;
		
		string ACCION = "";
		#endregion
		
		#region REFERENCIAS
		private FormValidacionEsp refValida = null;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		#endregion
		
		#region EVENTO LOAD
		void FormCambiosAsiganacionLoad(object sender, EventArgs e)
		{
			 getDatos();
			 
			 txtEntrada.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias Dato from OPERADOR where (ID in (select ID from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR)) OR tipo_empleado='Externo'");
			 txtEntrada.AutoCompleteMode =AutoCompleteMode.Suggest;
			 txtEntrada.AutoCompleteSource = AutoCompleteSource.CustomSource;
			 
			 txtSalida.AutoCompleteCustomSource = auto.AutoReconocimiento("select Alias Dato from OPERADOR where (ID in (select ID from OPERADOR O, ASIGNACIONUNIDAD A where O.ID=A.ID_OPERADOR)) OR tipo_empleado='Externo'");
			 txtSalida.AutoCompleteMode =AutoCompleteMode.Suggest;
			 txtSalida.AutoCompleteSource = AutoCompleteSource.CustomSource;
			 
			 if(refValida.dgDatos[0,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="Activo" && TIPO==0)
			 {
			 	cmdCambioOp.Enabled=false;
			 	cmdAtciva.Enabled=true;
			 	cmdCancelAnt.Enabled=false;
			 	cmdCancelPunto.Enabled=false;
			 }
			 
			 if(TIPO==1)
			 {
			 	cmdCambioOp.Enabled=true;
			 	cmdAtciva.Enabled=false;
			 	cmdCambioOp.Text="Desasignar";
			 	cmdCancelAnt.Enabled=false;
			 	cmdCancelPunto.Enabled=false;
			 }
		}
		#endregion
		
		#region EVENTO BOTONES
		void CmdAtcivaClick(object sender, EventArgs e)
		{
			cmdCambioOp.Enabled=false;
		 	cmdAtciva.Enabled=false;
		 	cmdCancelAnt.Enabled=true;
		 	cmdCancelPunto.Enabled=true;
		 	txtEntrada.Enabled=true;
		 	txtSalida.Enabled=true;
		 	
		 	ACCION="ACTIVA";
		}
		
		void CmdCambioOpClick(object sender, EventArgs e)
		{
			if(cmdCambioOp.Text=="Desasignar")
			{
				cmdCambioOp.Enabled=false;
			 	cmdAtciva.Enabled=true;
			 	cmdCancelAnt.Enabled=false;
			 	cmdCancelPunto.Enabled=false;
			 	
				ACCION = "LISTO";
			}
			else
			{
				txtEntrada.Enabled=true;
				txtSalida.Enabled=true;
				lblEnt.ForeColor=Color.Black;
				lblSal.ForeColor=Color.Black;
				idOperadoSal=0;
				idOperadoEnt=0;
				
				ACCION = "ASIGNA";
			}
		}
		
		void CmdCancelPuntoClick(object sender, EventArgs e)
		{
			ACCION = "PUNTO";
			lblDestino.ForeColor=Color.Red;
		}
		
		void CmdCancelAntClick(object sender, EventArgs e)
		{
			ACCION = "CANCELA";
			lblDestino.ForeColor=Color.Red;
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(ACCION=="ASIGNA")
			{
				if(idOperadoSal!=0 && idOperadoEnt!=0)
				{
					desasignar(Convert.ToInt64(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value));
					
					desasignar(Convert.ToInt64(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value));
					
					asignacionViaje(Convert.ToInt64(refValida.dgDatos[1,refValida.dgDatos.CurrentRow.Index].Value), idOperadoEnt, id_vehiculo_Ent, tipoVehiculoEnt);
					String consult = "select MAX(id_operacion) OP from OPERACION ";
					conn.getAbrirConexion(consult);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						idOperacionEnt=Convert.ToInt64(conn.leer["OP"]);
					}
					conn.conexion.Close();
					
						consult = " select V.ID from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.Alias='"+txtEntrada.Text+"'";
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							idUnidad=Convert.ToInt64(conn.leer["ID"]);
						}
						else
						{
							idUnidad=109;
						}
						conn.conexion.Close();
					
					asignacionViaje(Convert.ToInt64(refValida.dgDatos[2,refValida.dgDatos.CurrentRow.Index].Value), idOperadoSal, id_vehiculo_sal, tipoVehiculoSal);
					consult = "select MAX(id_operacion) OP from OPERACION ";
					conn.getAbrirConexion(consult);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						idOperacionSal=Convert.ToInt64(conn.leer["OP"]);
					}
					conn.conexion.Close();
					
						consult = " select V.ID from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.Alias='"+txtSalida.Text+"'";
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							idUnidad=Convert.ToInt64(conn.leer["ID"]);
						}
						else
						{
							idUnidad=109;
						}
						conn.conexion.Close();
					
					this.Close();
				}
				else if(idOperadoEnt!=0)
				{
					if(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
					{
						desasignar(Convert.ToInt64(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value));
						asignacionViaje(Convert.ToInt64(refValida.dgDatos[1,refValida.dgDatos.CurrentRow.Index].Value), idOperadoEnt, id_vehiculo_Ent, tipoVehiculoEnt);
						String consult = "select MAX(id_operacion) OP from OPERACION ";
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							idOperacionEnt=Convert.ToInt64(conn.leer["OP"]);
						}
						conn.conexion.Close();
						
						consult = " select V.ID from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.Alias='"+txtEntrada.Text+"'";
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							idUnidad=Convert.ToInt64(conn.leer["ID"]);
						}
						else
						{
							idUnidad=109;
						}
						conn.conexion.Close();
					}
					this.Close();
				}
				else if(idOperadoSal!=0)
				{
					if(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
					{
						desasignar(Convert.ToInt64(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value));
						asignacionViaje(Convert.ToInt64(refValida.dgDatos[2,refValida.dgDatos.CurrentRow.Index].Value), idOperadoSal, id_vehiculo_sal, tipoVehiculoSal);
						String consult = "select MAX(id_operacion) OP from OPERACION ";
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							idOperacionSal=Convert.ToInt64(conn.leer["OP"]);
						}
						conn.conexion.Close();
						
						consult = " select V.ID from OPERADOR O, ASIGNACIONUNIDAD A, VEHICULO V where O.ID=A.ID_OPERADOR and A.ID_UNIDAD=V.ID and O.Alias='"+txtSalida.Text+"'";
						conn.getAbrirConexion(consult);
						conn.leer=conn.comando.ExecuteReader();
						if(conn.leer.Read())
						{
							idUnidad=Convert.ToInt64(conn.leer["ID"]);
						}
						else
						{
							idUnidad=109;
						}
						conn.conexion.Close();
					}
					this.Close();
				}
				else if(idOperadoEnt==0 && idOperadoSal==0)
				{
					MessageBox.Show("Es necesario la asignacion del operador nuevo por asignar");
				}
				
				cambioAsignacion();
			}
			else if(ACCION=="PUNTO")
			{
				if(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
				{
					int idOp=0;
			
					String consul = "select OP.id_operador from OPERACION O, OPERACION_OPERADOR OP where O.id_operacion=OP.id_operacion and O.id_operacion='"+refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value.ToString()+"'";
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						idOp=Convert.ToInt16(conn.leer["id_operador"]);
					}
					conn.conexion.Close();
					
					cancelacionPunto(idOp, Convert.ToInt16(refValida.dgDatos[1,refValida.dgDatos.CurrentRow.Index].Value));
					desasignar(Convert.ToInt64(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value));
					desasignar(Convert.ToInt64(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value));
					this.Close();
				}
				else if(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
				{
					int idOp=0;
			
					String consul = "select OP.id_operador from OPERACION O, OPERACION_OPERADOR OP where O.id_operacion=OP.id_operacion and O.id_operacion='"+refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value.ToString()+"'";
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						idOp=Convert.ToInt16(conn.leer["id_operador"]);
					}
					conn.conexion.Close();
					
					cancelacionPunto(idOp, Convert.ToInt16(refValida.dgDatos[2,refValida.dgDatos.CurrentRow.Index].Value));
					desasignar(Convert.ToInt64(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value));
					this.Close();
				}
				else if(idOperadoEnt!=0)
				{
					String id_ope= idOperadoEnt.ToString();
					cancelacionPunto(Convert.ToInt16(id_ope), Convert.ToInt16(refValida.dgDatos[1,refValida.dgDatos.CurrentRow.Index].Value));
					desasignar(Convert.ToInt64(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value));
					this.Close();
				}
				else
				{
					MessageBox.Show("Es necesaria la asignacion de un operador para poder cancelar en el punto");
				}
				cambioCancelPunto();
			}
			else if(ACCION=="CANCELA")
			{
				if(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
				{
					desasignar(Convert.ToInt64(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value));
				}
				
				if(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
				{
					desasignar(Convert.ToInt64(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value));
				}
				
				canceladoAnt(Convert.ToInt16(refValida.dgDatos[1,refValida.dgDatos.CurrentRow.Index].Value));
				canceladoAnt(Convert.ToInt16(refValida.dgDatos[2,refValida.dgDatos.CurrentRow.Index].Value));
				cambioCancelAnt();
				this.Close();
				
				cambioCancelAnt();
			}
			else if(ACCION=="LISTO")
			{
				this.Close();
				
				if(refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Style.BackColor.Name=="Black")
				{
					desasignar(Convert.ToInt64(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value));
					refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.Red;
					refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Style.ForeColor=Color.Black;
					refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Value=refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Value.ToString().Substring(8,(refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value.ToString().Length-8));
				}
				
				if(refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Style.BackColor.Name=="Black")
				{
					desasignar(Convert.ToInt64(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value));
					refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.Red;
					refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Style.ForeColor=Color.Black;
					refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value=refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value.ToString().Substring(8,(refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value.ToString().Length-8));
				}
			}
			else if(ACCION=="ACTIVA")
			{
				refValida.dgDatos[0, refValida.dgDatos.CurrentRow.Index].Value="Activo";
				refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Value="OPERADOR";
				refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value="OPERADOR";
				refValida.dgDatos[13, refValida.dgDatos.CurrentRow.Index].Value="OPERADOR";
				refValida.dgDatos[14, refValida.dgDatos.CurrentRow.Index].Value="00000000";
				refValida.dgDatos[22, refValida.dgDatos.CurrentRow.Index].Value="";
				refValida.dgDatos[22, refValida.dgDatos.CurrentRow.Index].Value="167";
				
				for(int x=0; x<refValida.dgDatos.Columns.Count; x++)
				{
					if(x!=4 && x!=8 && x!=13)
					{
						refValida.dgDatos[x,refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.White;
					}
					if(x==4 && x==8 && x==13)
					{
						refValida.dgDatos[x,refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.Gainsboro;
					}
				}
				
				this.Close();
			}
			refValida.dgDatos.ClearSelection();
		}
		
		void cambioAsignacion()
		{
			refValida.dgDatos[0, refValida.dgDatos.CurrentRow.Index].Value="Activo";
			refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Value=txtEntrada.Text;
			refValida.dgDatos[10, refValida.dgDatos.CurrentRow.Index].Value=((idOperacionEnt!=0)?idOperacionEnt.ToString():refValida.dgDatos[10, refValida.dgDatos.CurrentRow.Index].Value.ToString());
			refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value=txtSalida.Text;
			refValida.dgDatos[12, refValida.dgDatos.CurrentRow.Index].Value=((idOperacionSal!=0)?idOperacionSal.ToString():refValida.dgDatos[12, refValida.dgDatos.CurrentRow.Index].Value.ToString());
			refValida.dgDatos[13, refValida.dgDatos.CurrentRow.Index].Value=txtSalida.Text;
			refValida.dgDatos[14, refValida.dgDatos.CurrentRow.Index].Value=telefono;
		    refValida.dgDatos[21, refValida.dgDatos.CurrentRow.Index].Value=((idUnidad!=0)?idUnidad.ToString():refValida.dgDatos[21, refValida.dgDatos.CurrentRow.Index].Value.ToString());
		    refValida.dgDatos[24, refValida.dgDatos.CurrentRow.Index].Value=idOperadoEnt;
		    
		    for(int x=0; x<refValida.dgDatos.Columns.Count; x++)
			{
				if(x!=4 && x!=8 && x!=13)
				{
					refValida.dgDatos[x,refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.White;
				}
				if(x==4 || x==8 || x==13)
				{
					refValida.dgDatos[x,refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.Gainsboro;
				}
			}
		}
		
		void cambioCancelPunto()
		{
			refValida.dgDatos[0, refValida.dgDatos.CurrentRow.Index].Value="C. PUNTO";
			refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Value=txtEntrada.Text;
			refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value=txtSalida.Text;
			refValida.dgDatos[13, refValida.dgDatos.CurrentRow.Index].Value="OPERADOR";
		    refValida.dgDatos[14, refValida.dgDatos.CurrentRow.Index].Value="000000000";
		    for(int x=0; x<refValida.dgDatos.Columns.Count; x++)
			{
				refValida.dgDatos[x,refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.Red;
		    }
		}
		
		void cambioCancelAnt()
		{
			refValida.dgDatos[0, refValida.dgDatos.CurrentRow.Index].Value="CANCELADA";
			refValida.dgDatos[9, refValida.dgDatos.CurrentRow.Index].Value="OPERADOR";
			refValida.dgDatos[11, refValida.dgDatos.CurrentRow.Index].Value="OPERADOR";
			refValida.dgDatos[13, refValida.dgDatos.CurrentRow.Index].Value="OPERADOR";
		    refValida.dgDatos[14, refValida.dgDatos.CurrentRow.Index].Value="000000000";
		    
		    for(int x=0; x<refValida.dgDatos.Columns.Count; x++)
			{
				refValida.dgDatos[x,refValida.dgDatos.CurrentRow.Index].Style.BackColor=Color.Yellow;
		    }
		}
		#endregion	
		
		#region MUESTRA DATOS
		public void getDatos()
		{
			txtDestino.Text=refValida.dgDatos[4,refValida.dgDatos.CurrentRow.Index].Value.ToString();
			if(refValida.dgDatos[0,refValida.dgDatos.CurrentRow.Index].Value.ToString()=="Activo")
			{
				if(refValida.dgDatos[10,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
					txtEntrada.Text=refValida.dgDatos[9,refValida.dgDatos.CurrentRow.Index].Value.ToString();
				if(refValida.dgDatos[12,refValida.dgDatos.CurrentRow.Index].Value.ToString()!="0")
					txtSalida.Text=refValida.dgDatos[11,refValida.dgDatos.CurrentRow.Index].Value.ToString();
			}
			else
			{
				lblDestino.Text=refValida.dgDatos[0,refValida.dgDatos.CurrentRow.Index].Value.ToString()+" "+lblDestino.Text;
				lblDestino.ForeColor=Color.Red;
			}
		}
		#endregion
		
		#region METODOS DB
		#region DESASIGNAR
		void desasignar(Int64 id_operacion)
		{
			new Conexion_Servidor.Desapacho.SQL_Operaciones().deleteAsignacion(id_operacion);
		}
		#endregion
		
		#region ASIGNAR
		void asignacionViaje(Int64 id_ruta, Int64 id_operador, Int64 id_vehiculo, String tipo_vehiculo)
		{
			string fecha="";
			
			String consul = "select RE.FECHA_SALIDA from RUTA_ESPECIAL RE, RUTA R where RE.ID_C=R.IdSubEmpresa and R.ID='"+id_ruta+"'";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				fecha=conn.leer["FECHA_SALIDA"].ToString();
			}
			conn.conexion.Close();
			
			new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarViaje(0, id_ruta.ToString(), refValida.refLibro.principal.idUsuario, id_operador, "00:00", "00:00", 1, id_vehiculo, tipo_vehiculo, "Mañana", 0, " ", fecha.Substring(0,10), "Espsciales");
		}
		#endregion
		
		#region CANCELADO EN EL PUNTO
		void cancelacionPunto(int id_operador, int id_ruta)
		{
			string fecha="";
			
			String consul = "select RE.FECHA_SALIDA from RUTA_ESPECIAL RE, RUTA R where RE.ID_C=R.IdSubEmpresa and R.ID='"+id_ruta+"'";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				fecha=conn.leer["FECHA_SALIDA"].ToString();
			}
			conn.conexion.Close();
			
			new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaPunto(id_operador, id_ruta, refValida.refLibro.principal.idUsuario, "Mañana", fecha.Substring(0,10));
		}
		#endregion
		
		#region
		void canceladoAnt(int id_ruta)
		{
			new Conexion_Servidor.Desapacho.SQL_Operaciones().cancelaEspecial(id_ruta.ToString());
		}
		#endregion
		#endregion
		
		#region COMPLETA DATAGRID
		void TxtEntradaKeyUp(object sender, KeyEventArgs e)
		{
			int dato=0;
			
			if(e.KeyCode == Keys.Return)
			{
				String consul = "select ID from OPERADOR where Estatus='1' and Alias='"+txtEntrada.Text+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idOperadoEnt=Convert.ToInt64(conn.leer["ID"]);
					txtEntrada.Enabled=false;
					lblEnt.ForeColor=Color.SpringGreen;
					if(idOperadoSal==0)
					{
						idOperadoSal=Convert.ToInt64(conn.leer["ID"]);
						txtSalida.Text=txtEntrada.Text;
						txtSalida.Enabled=false;
						lblSal.ForeColor=Color.SpringGreen;
					}
					dato=1;
				}
				
				conn.conexion.Close();
				
				consul = "select Numero from TELEFONOCHOFER where Tipo='LAR' and ID_Chofer='"+idOperadoEnt+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					telefono=conn.leer["Numero"].ToString();
				}
				
				conn.conexion.Close();
				
				if(dato==1)
				{
					consul = "select V.ID, V.Tipo_Unidad, O.tipo_empleado from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O where V.ID=A.ID_UNIDAD and O.ID=A.ID_OPERADOR and ID_OPERADOR='"+idOperadoEnt+"'";
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						if(conn.leer["tipo_empleado"].ToString()=="Externo")
						{
							id_vehiculo_Ent=109;
							tipoVehiculoEnt="Camion";
						}
						else
						{
							id_vehiculo_Ent=Convert.ToInt64(conn.leer["ID"]);
							tipoVehiculoEnt=conn.leer["Tipo_Unidad"].ToString();
							id_vehiculo_sal=Convert.ToInt64(conn.leer["ID"]);
							tipoVehiculoSal=conn.leer["Tipo_Unidad"].ToString();
						}
					}
					else
					{
						id_vehiculo_Ent=109;
						tipoVehiculoEnt="Camion";
					}
					conn.conexion.Close();
				}
				else
				{
					id_vehiculo_Ent=109;
					tipoVehiculoEnt="Camion";
				}
			}
		}
		
		void TxtSalidaKeyUp(object sender, KeyEventArgs e)
		{
			int dato=0;
			
			if(e.KeyCode == Keys.Return)
			{
				String consul = "select * from OPERADOR where Estatus='1' and Alias='"+txtSalida.Text+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					idOperadoSal=Convert.ToInt64(conn.leer["ID"]);
					lblSal.ForeColor=Color.SpringGreen;
					txtSalida.Enabled=false;
					txtEntrada.Enabled=false;
					dato=1;
				}
				
				conn.conexion.Close();
				
				if(dato==1)
				{
					consul = "select V.ID, V.Tipo_Unidad, O.tipo_empleado from VEHICULO V, ASIGNACIONUNIDAD A, OPERADOR O where V.ID=A.ID_UNIDAD and O.ID=A.ID_OPERADOR and ID_OPERADOR='"+idOperadoSal+"'";
					conn.getAbrirConexion(consul);
					conn.leer=conn.comando.ExecuteReader();
					if(conn.leer.Read())
					{
						if(conn.leer["tipo_empleado"].ToString()=="Externo")
						{
							id_vehiculo_sal=109;
							tipoVehiculoSal="Camion";
						}
						else
						{
							id_vehiculo_sal=Convert.ToInt64(conn.leer["ID"]);
							tipoVehiculoSal=conn.leer["Tipo_Unidad"].ToString();
						}
					}
					else
					{
						id_vehiculo_Ent=109;
						tipoVehiculoEnt="Camion";
					}
					conn.conexion.Close();
				}
			}
		}		
		#endregion
	}
}
