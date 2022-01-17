using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Asignacion
{
	public partial class FormDesasignacion : Form
	{
		private int ID_Operador;
		private int ID_Vehiculo;
		private int id_usuario;
		private bool insistencia=false;
		private Int64 id_H;
		private String estatus="D";
		private String tipo="Actitud";
		private Interfaz.Operaciones.FormOperacionesOperador refOperador = null;
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		
		public FormDesasignacion(int idO, int idV, Interfaz.Operaciones.FormOperacionesOperador referencia)
		{
			InitializeComponent();
			ID_Operador=idO;
			ID_Vehiculo=idV;
			refOperador=referencia;
		}
		
		#region EVENTO LOAD
		void FormDesasignacionLoad(object sender, EventArgs e)
		{
			dtpTiempo.Value=DateTime.Now;
			txtUsuario.Text=refOperador.refPrincipal.principal.nombreUsuario;
			id_usuario=refOperador.refPrincipal.principal.idUsuario;
			this.Text="Transportes LAR - Desasignacion";
			
			txtUsuario.AutoCompleteCustomSource = auto.AutoReconocimiento("select usuario dato from usuario where PRIVILEGIO='COORDINADOR' OR PRIVILEGIO='GERENCIAL'");
			txtUsuario.AutoCompleteMode =AutoCompleteMode.Suggest;
			txtUsuario.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			datos();
		}
		#endregion
		
		#region EVENTO BOTONES
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnContinuarClick(object sender, EventArgs e)
		{
			if(estatus=="")
			{
				MessageBox.Show("Seleccione Estatus");
			}
			else
			{
				if(estatus=="T")
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialVeh(ID_Vehiculo,estatus,txtDescripcion.Text, refOperador.refPrincipal.DIA, refOperador.refPrincipal.TURNO, refOperador.refPrincipal.principal.idUsuario);
					
					conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), '"+dtpTiempo.Value.ToString("hh:mm:ss")+"', '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', 'TALLER', '"+txtDescripcion.Text+"', "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					this.Close();
				}
				else if(estatus=="O")
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe(ID_Operador,estatus,txtDescripcion.Text, refOperador.refPrincipal.principal.formPrincEmp.fecha_despacho, refOperador.refPrincipal.principal.formPrincEmp.ConsTurno, refOperador.refPrincipal.principal.idUsuario);
						
					conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', '"+tipo+"', '"+txtDescripcion.Text+"', "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					this.Close();
				}
				else if(estatus=="I")
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe(ID_Operador,estatus,txtDescripcion.Text, refOperador.refPrincipal.principal.formPrincEmp.fecha_despacho, refOperador.refPrincipal.principal.formPrincEmp.ConsTurno, refOperador.refPrincipal.principal.idUsuario);
					
					conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', '"+tipo+"', '"+txtDescripcion.Text+"', "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), '"+dtpDia.Value.ToString("dd/MM/yyyy")+"', '"+cmbTurno.Text+"', 'ABIERTO', NULL)");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					this.Close();
				}
				else if(estatus=="P")
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe(ID_Operador,estatus,txtDescripcion.Text, refOperador.refPrincipal.principal.formPrincEmp.fecha_despacho, refOperador.refPrincipal.principal.formPrincEmp.ConsTurno, refOperador.refPrincipal.principal.idUsuario);
					
					conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', '"+tipo+"', '"+txtDescripcion.Text+"', "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), '"+dtpDia.Value.ToString("dd/MM/yyyy")+"', '"+cmbTurno.Text+"', 'ABIERTO', NULL)");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					this.Close();
				}
				else if(insistencia==true && estatus=="D")
				{
					conn.getAbrirConexion("insert into DETALLE_CARDEX values ("+id_H+", '"+dtpTiempo.Value.ToString("hh:mm:ss")+"', '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', 'INSISTENCIA', '"+txtDescripcion.Text+"', "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					this.Close();
				}
				else if(insistencia==false && estatus=="D")
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe(ID_Operador,estatus,txtDescripcion.Text, refOperador.refPrincipal.principal.formPrincEmp.fecha_despacho, refOperador.refPrincipal.principal.formPrincEmp.ConsTurno, refOperador.refPrincipal.principal.idUsuario);
					
					
					conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), '"+dtpTiempo.Value.ToString("hh:mm:ss")+"', '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', 'INSISTENCIA', '"+txtDescripcion.Text+"', "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					this.Close();
				}
				else
				{
					new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe(ID_Operador,estatus,txtDescripcion.Text, refOperador.refPrincipal.principal.formPrincEmp.fecha_despacho, refOperador.refPrincipal.principal.formPrincEmp.ConsTurno, refOperador.refPrincipal.principal.idUsuario);
					
					conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), '"+dtpTiempo.Value.ToString("hh:mm:ss")+"', '"+refOperador.refPrincipal.DIA+"', '"+refOperador.refPrincipal.TURNO+"', '"+estatus+"', '"+txtDescripcion.Text+"', "+id_usuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
					conn.comando.ExecuteNonQuery();
					conn.conexion.Close();
					
					this.Close();
				}
				
				refOperador.colorEstado(estatus);
			}
		}
		#endregion
		
		#region EVENTOS RADIO BUTTONS
		void RbDCheckedChanged(object sender, EventArgs e)
		{
			if(rbD.Checked==true)
			{
		 		estatus="D";
		 		datos();
		 		cambioTamanio(true);
			}
			else
			{
				gbInsistencia.Enabled=false;
				insistencia=false;
			}
		}
		
		void RbACheckedChanged(object sender, EventArgs e)
		{
			if(rbA.Checked==true)
			{
				cambioTamanio(false);
				estatus="A";
			}
		}
		
		void RbTCheckedChanged(object sender, EventArgs e)
		{
			if(rbT.Checked==true)
			{
				cambioTamanio(false);
				estatus="T";
			}
		}
		
		void RbECheckedChanged(object sender, EventArgs e)
		{
			if(rbE.Checked==true)
			{
				cambioTamanio(false);
				estatus="E";
			}
		}
		
		void RbPCheckedChanged(object sender, EventArgs e)
		{
			if(rbP.Checked==true)
			{
				cambioTamanio(true);
				estatus="P";
				gbInicio.Enabled=true;
				cmbTurno.Text=turnoSig(refOperador.refPrincipal.TURNO);
			}
			else
			{
				gbInicio.Enabled=false;
			}
		}
		
		void RbXCheckedChanged(object sender, EventArgs e)
		{
			if(rbX.Checked==true)
			{
				estatus="O";
				gbOtro.Enabled=true;
				cambioTamanio(true);
			}
			else
			{
				gbOtro.Enabled=false;
			}
		}
		
		void RbICheckedChanged(object sender, EventArgs e)
		{
			if(rbI.Checked==true)
			{
				estatus="I";
				cambioTamanio(true);
				gbInicio.Enabled=true;
				cmbTurno.Text=turnoSig(refOperador.refPrincipal.TURNO);
			}
			else
			{
				gbInicio.Enabled=false;
			}
		}
		
		void cambioTamanio(bool tipo)
		{
			if(tipo)
			{
				this.Size = new System.Drawing.Size(794, 316);
			}
			else
			{
				this.Size = new System.Drawing.Size(451, 316);
			}
		}
		#endregion
		
		#region GET TURNO
		String turnoSig(String Turno)
		{
			String respuesta="";
			
			if(Turno=="Mañana")
				respuesta="Medio día";
			else if(Turno=="Medio día")
				respuesta="Vespertino";
			else if(Turno=="Vespertino")
				respuesta="Nocturno";
			else if(Turno=="Nocturno")
				respuesta="Mañana";
			
			return respuesta;
		}
		#endregion
		
		#region KEY UP
		void TxtUsuarioKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Return)
			{
				String consul = "select id_usuario from usuario where (PRIVILEGIO='COORDINADOR' OR PRIVILEGIO='GERENCIAL') and usuario='"+txtUsuario.Text+"'";
				conn.getAbrirConexion(consul);
				conn.leer=conn.comando.ExecuteReader();
				if(conn.leer.Read())
				{
					id_usuario=Convert.ToInt16(conn.leer["id_usuario"]);
				}
				else
				{
					MessageBox.Show("Usuario no valido.");
					txtUsuario.Text="";
				}
				
				conn.conexion.Close();
			}
		}
		#endregion
		
		#region GET DATOS
		public void datos()
		{
			bool getDgDatos=false;
			
			String consul = "select ID_HO from HISTORIALOPERADOR where ESTATUS='D' and TURNO='"+refOperador.refPrincipal.TURNO+"' and FECHA='"+refOperador.refPrincipal.DIA+"' and ID_O='"+ID_Operador+"'";
			conn.getAbrirConexion(consul);
			conn.leer=conn.comando.ExecuteReader();
			if(conn.leer.Read())
			{
				id_H=Convert.ToInt64(conn.leer["ID_HO"]);
				gbInsistencia.Enabled=true;
				insistencia=true;
				getDgDatos=true;
			}
			else
			{
				gbInsistencia.Enabled=false;
				insistencia=false;
			}
			
			conn.conexion.Close();
			
			if(getDgDatos)
				getDatagrid();
		}
		
		void getDatagrid()
		{
			conn.getAbrirConexion("select * from DETALLE_CARDEX D, usuario U WHERE D.ID_U=U.id_usuario AND ID_H='"+id_H+"' and D.DIA='"+refOperador.refPrincipal.DIA+"' and D.TIPO='INSISTENCIA' and D.TURNO='"+refOperador.refPrincipal.TURNO+"'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				dgInsistencia.Rows.Add(conn.leer["ID"].ToString(), conn.leer["HORA"].ToString(), conn.leer["usuario"].ToString());
			}
			conn.conexion.Close();
		}
		#endregion
		
		#region
		void RbActividadCheckedChanged(object sender, EventArgs e)
		{
			tipo="Actitud";
		}
		
		void RbUniformeCheckedChanged(object sender, EventArgs e)
		{
			tipo="Uniforme";
		}
		
		void RbDisponibilidadCheckedChanged(object sender, EventArgs e)
		{
			tipo="Disponibilidad";
		}
		#endregion		
	}
}
