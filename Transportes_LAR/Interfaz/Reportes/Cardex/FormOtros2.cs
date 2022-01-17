
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transportes_LAR.Interfaz.Reportes.Cardex
{
	public partial class FormOtros2 : Form
	{
		#region CONSTRUCTOR		
		public FormOtros2(FormCardex refPrinc)
		{
			InitializeComponent();
			refPrincipal=refPrinc;
		}
		
		#endregion		
		
		#region VARIABLES
		String TIPOCombustible = "";
		String TIPOOperaciones = "";
		String TIPODiversos = "";
		Int64 ID_OPP = 0;
		#endregion
		
		#region INSTANCIAS
		public FormCardex refPrincipal;
		private Proceso.AutoCompleClass auto= new Transportes_LAR.Proceso.AutoCompleClass();
		private Conexion_Servidor.SQL_Conexion conn= new Conexion_Servidor.SQL_Conexion();
		private Conexion_Servidor.Reportes.SQL_Reportes connR = new Conexion_Servidor.Reportes.SQL_Reportes();
		#endregion
		
		#region INICIO - FIN
		void FormOtros2Load(object sender, EventArgs e)
		{
			txtOperador.AutoCompleteCustomSource = auto.AutocompleteGeneral("select alias from OPERADOR WHERE tipo_empleado='OPERADOR'", "Alias");
           	txtOperador.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtOperador.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}
	
		#endregion
		
		#region BOTONES
		void CmdGuardaClick(object sender, EventArgs e)
		{			
			if(txtOperador.Text.Length > 0)
			{
				if(validarExistaOperador())
				{
					if(txtComentario.Text!="")
					{
						if(cmbTurno.Text != "")
						{
							guardaDatos();
							limpiaDatos();
						}else{
							MessageBox.Show("Selecciona el turno");
						}						
					}
					else
					{
						MessageBox.Show("Ingrese comentario");
					}
				}
				else
				{
					MessageBox.Show("El operador no existe");
				}
			}
			else
			{
				MessageBox.Show("Seleccione un operador");
			}
			
		}		
		#endregion
		
		#region METODOS
		public Boolean validarExistaOperador()
		{
			Boolean valida = false;
			conn.getAbrirConexion("select ID, ALIAS from OPERADOR where ALIAS='"+txtOperador.Text+"'");
			conn.leer=conn.comando.ExecuteReader();
			while(conn.leer.Read())
			{
				ID_OPP = Convert.ToInt64(conn.leer["ID"]);
				valida = true;
			}				
			conn.conexion.Close();								
			return valida;
			
		}
		
		void limpiaDatos()
		{
			rbDormida.Checked = false;
			rbInicioRutaTarde.Checked = false;
			rbTaller.Checked = false;
			rbNegarseHacerServicio.Checked = false;
			rbPermiso.Checked = false;
			rbNoRespetaItinerario.Checked = false;
			rbIncapacidad.Checked = false;
			rbDiferenciaDiessel.Checked = false;
			rbCargaFueradeHorario.Checked = false;
			rbMovNoAutorizado.Checked = false;
			rbExceso.Checked = false;
			rbUniforme.Checked = false;
			rbImagenUnidad.Checked = false;
			rbActitud.Checked = false;
			rbImagenOperador.Checked = false;
			rbChoques.Checked = false;
			rbOtros.Checked = false;
			cmbTurno.SelectedIndex=-1;
			txtComentario.Text="";
			txtOperador.Text="";
			txtOperador.Focus();
		}
		#endregion
		
		#region GUARDADO DE DATOS
		void guardaDatos()
		{
			if(TIPOCombustible != "")
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe2(ID_OPP,TIPOCombustible,txtComentario.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), cmbTurno.Text, refPrincipal.refPrincipal.idUsuario);
						
				conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '"+cmbTurno.Text+"', '"+TIPOCombustible+"', '"+txtComentario.Text+"', "+refPrincipal.refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
			
			if(TIPOOperaciones != "")
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe2(ID_OPP,TIPOOperaciones,txtComentario.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), cmbTurno.Text, refPrincipal.refPrincipal.idUsuario);
						
				conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '"+cmbTurno.Text+"', '"+TIPOOperaciones+"', '"+txtComentario.Text+"', "+refPrincipal.refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}
			
			if(TIPODiversos != "")
			{
				new Conexion_Servidor.Desapacho.SQL_Operaciones().almacenarHistorialOpe2(ID_OPP,TIPODiversos,txtComentario.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), cmbTurno.Text, refPrincipal.refPrincipal.idUsuario);
						
				conn.getAbrirConexion("insert into DETALLE_CARDEX values ((select MAX(ID_HO) from HISTORIALOPERADOR), (SELECT CONVERT (TIME, SYSDATETIME())), '"+dtpFecha.Value.ToString("dd/MM/yyyy")+"', '"+cmbTurno.Text+"', '"+TIPODiversos+"', '"+txtComentario.Text+"', "+refPrincipal.refPrincipal.idUsuario+", (SELECT CONVERT (DATE, SYSDATETIME())), NULL, NULL, 'ABIERTO', NULL)");
				conn.comando.ExecuteNonQuery();
				conn.conexion.Close();
			}			
		}
		#endregion		
			
		#region EVENTO CHECKED
		
		//				Operaciones
		void RbDormidaCheckedChanged(object sender, EventArgs e)
		{
			if(rbDormida.Checked==true)
				TIPOOperaciones = rbDormida.Text;
			else
				TIPOOperaciones = "";
		}
		
		void RbInicioRutaTardeCheckedChanged(object sender, EventArgs e)
		{
			if(rbInicioRutaTarde.Checked==true)
				TIPOOperaciones = rbInicioRutaTarde.Text;
			else
				TIPOOperaciones = "";
		}
		
		void RbTallerCheckedChanged(object sender, EventArgs e)
		{
			if(rbTaller.Checked==true)
				TIPOOperaciones = rbTaller.Text;
			else
				TIPOOperaciones = "";
		}
		
		void RbNegarseHacerServicioCheckedChanged(object sender, EventArgs e)
		{
			if(rbNegarseHacerServicio.Checked==true)
				TIPOOperaciones = rbNegarseHacerServicio.Text;
			else
				TIPOOperaciones = "";
		}
		
		void RbPermisoCheckedChanged(object sender, EventArgs e)
		{
			if(rbPermiso.Checked==true)
				TIPOOperaciones = rbPermiso.Text;
			else
				TIPOOperaciones = "";
		}
		
		void RbNoRespetaItinerarioCheckedChanged(object sender, EventArgs e)
		{
			if(rbNoRespetaItinerario.Checked==true)
				TIPOOperaciones = rbNoRespetaItinerario.Text;
			else
				TIPOOperaciones = "";
		}
		
		void RbIncapacidadCheckedChanged(object sender, EventArgs e)
		{
			if(rbIncapacidad.Checked==true)
				TIPOOperaciones = rbIncapacidad.Text;
			else
				TIPOOperaciones = "";
		}
		
		
		//				Combustible
		void RbDiferenciaDiesselCheckedChanged(object sender, EventArgs e)
		{
			if(rbDiferenciaDiessel.Checked==true)
				TIPOCombustible = rbDiferenciaDiessel.Text;
			else
				TIPOCombustible = "";
		}
		
		void RbCargaFueradeHorarioCheckedChanged(object sender, EventArgs e)
		{
			if(rbCargaFueradeHorario.Checked==true)
				TIPOCombustible = rbCargaFueradeHorario.Text;
			else
				TIPOCombustible = "";
		}
		
		void RbMovNoAutorizadoCheckedChanged(object sender, EventArgs e)
		{
			if(rbMovNoAutorizado.Checked==true)
				TIPOCombustible = rbMovNoAutorizado.Text;
			else
				TIPOCombustible = "";
		}
		
		void RbExcesoCheckedChanged(object sender, EventArgs e)
		{
			if(rbExceso.Checked==true)
				TIPOCombustible = rbExceso.Text;
			else
				TIPOCombustible = "";
		}
				
		//				Diversos
		
		void RbUniformeCheckedChanged(object sender, EventArgs e)
		{
			if(rbUniforme.Checked==true)
				TIPODiversos =  rbUniforme.Text;
			else
				TIPODiversos = "";
		}
		
		void RbImagenUnidadCheckedChanged(object sender, EventArgs e)
		{
			if(rbImagenUnidad.Checked==true)
				TIPODiversos = rbImagenUnidad.Text;
			else
				TIPODiversos = "";
		}
		
		void RbActitudCheckedChanged(object sender, EventArgs e)
		{
			if(rbActitud.Checked==true)
				TIPODiversos = rbActitud.Text;
			else
				TIPODiversos = "";
		}
		
		void RbImagenOperadorCheckedChanged(object sender, EventArgs e)
		{
			if(rbImagenOperador.Checked==true)
				TIPODiversos = rbImagenOperador.Text;
			else
				TIPODiversos = "";
		}
		
		void RbChoquesCheckedChanged(object sender, EventArgs e)
		{
			if(rbChoques.Checked==true)
				TIPODiversos = rbChoques.Text;
			else
				TIPODiversos = "";
		}
		
		void RbOtrosCheckedChanged(object sender, EventArgs e)
		{
			if(rbOtros.Checked==true)
				TIPODiversos = rbOtros.Text;
			else
				TIPODiversos = "";
		}
		#endregion		
	}
}
